﻿using Insql.Providers;
using Insql.Resolvers;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;

namespace Insql.Mappers
{
   internal class InsqlModel : IInsqlModel
   {
      private readonly Dictionary<Type, IInsqlEntityMap> entityMaps = new Dictionary<Type, IInsqlEntityMap>();

      public IEnumerable<IInsqlEntityMap> Maps => this.entityMaps.Values;

      public InsqlModel(IOptions<InsqlModelOptions> options, IInsqlDescriptorLoader descriptorLoader, IInsqlModelMapper entityMapper)
      {
         var optionsValue = options.Value;

         if (optionsValue.IncludeAnnotationMaps)
         {
            this.LoadAnnotationEntityMaps(optionsValue.IncludeAnnotationMapsAssemblies);
         }

         if (optionsValue.IncludeFluentMaps)
         {
            this.LoadFluentEntityMaps(optionsValue.IncludeFluentMapsAssemblies);
         }

         if (optionsValue.IncludeXmlMaps)
         {
            this.LoadXmlEntityMaps(descriptorLoader);
         }

         entityMapper.Mapping(this.entityMaps.Values);
      }

      public IInsqlEntityMap FindMap(Type entityType)
      {
         if (entityType == null)
         {
            throw new ArgumentNullException(nameof(entityType));
         }

         if (this.entityMaps.TryGetValue(entityType, out IInsqlEntityMap entityMap))
         {
            return entityMap;
         }

         return null;
      }

      private void LoadAnnotationEntityMaps(IEnumerable<Assembly> assemblies)
      {
         if (assemblies == null)
         {
            assemblies = AppDomain.CurrentDomain.GetAssemblies();
         }

         assemblies = assemblies.Where(assembly => !assembly.IsDynamic && !assembly.ReflectionOnly);

         var resultMaps = assemblies.SelectMany(assembly =>
         {
            IEnumerable<TypeInfo> definedTypes;

            try
            {
               definedTypes = assembly.DefinedTypes;
            }
            catch
            {
               definedTypes = new List<TypeInfo>();
            }

            return definedTypes.Where(type =>
                   type.IsPublic &&
                   type.IsClass &&
                   !type.IsAbstract &&
                   !type.IsGenericType &&
                   type.GetCustomAttribute(typeof(TableAttribute), true) != null)
               .Select(type => this.CreateAnnotationEntityMap(type));
         }).ToDictionary(item => item.EntityType, item => item);

         foreach (var itemMap in resultMaps)
         {
            this.entityMaps[itemMap.Key] = itemMap.Value;
         }
      }

      private IInsqlEntityMap CreateAnnotationEntityMap(Type entityType)
      {
         TableAttribute tableAttribute = (TableAttribute)entityType.GetCustomAttribute(typeof(TableAttribute), true);

         IInsqlEntityMap resultMap = new InsqlEntityMap(entityType, tableAttribute.Name, tableAttribute.Schema);

         var columnMaps = entityType.GetProperties(BindingFlags.Instance | BindingFlags.Public).Select(propInfo =>
          {
             ColumnAttribute columnAttribute = (ColumnAttribute)propInfo.GetCustomAttribute(typeof(ColumnAttribute), true);
             KeyAttribute keyAttribute = (KeyAttribute)propInfo.GetCustomAttribute(typeof(KeyAttribute), true);
             NotMappedAttribute notMappedAttribute = (NotMappedAttribute)propInfo.GetCustomAttribute(typeof(NotMappedAttribute), true);
             EditableAttribute editableAttribute = (EditableAttribute)propInfo.GetCustomAttribute(typeof(EditableAttribute), true);
             DatabaseGeneratedAttribute databaseGeneratedAttribute = (DatabaseGeneratedAttribute)propInfo.GetCustomAttribute(typeof(DatabaseGeneratedAttribute), true);

             InsqlPropertyMap propertyMap = new InsqlPropertyMap(propInfo, columnAttribute?.Name);

             if (keyAttribute != null)
             {
                propertyMap.IsKey = true;
             }
             if (notMappedAttribute != null)
             {
                propertyMap.IsIgnored = true;
             }
             if (databaseGeneratedAttribute != null)
             {
                if (databaseGeneratedAttribute.DatabaseGeneratedOption == DatabaseGeneratedOption.Identity)
                {
                   propertyMap.IsIdentity = true;
                }
             }
             if (editableAttribute != null && !editableAttribute.AllowEdit)
             {
                propertyMap.IsReadonly = true;
             }

             return propertyMap;
          });

         foreach (var columnMap in columnMaps)
         {
            resultMap.Properties.Add(columnMap);
         }

         InsqlEntityValidator.Instance.Validate(resultMap);

         return resultMap;
      }

      private void LoadFluentEntityMaps(IEnumerable<Assembly> assemblies)
      {
         var baseType = typeof(InsqlEntityBuilder);

         if (assemblies == null)
         {
            assemblies = AppDomain.CurrentDomain.GetAssemblies();
         }

         assemblies = assemblies.Where(assembly => !assembly.IsDynamic && !assembly.ReflectionOnly);

         var resultMaps = assemblies.SelectMany(assembly =>
         {
            IEnumerable<TypeInfo> definedTypes;

            try
            {
               definedTypes = assembly.DefinedTypes;
            }
            catch
            {
               definedTypes = new List<TypeInfo>();
            }

            return definedTypes.Where(type =>
                   type.IsPublic &&
                   type.IsClass &&
                   !type.IsAbstract &&
                   !type.IsGenericType &&
                   baseType != type &&
                   baseType.IsAssignableFrom(type))
               .Select(type => (InsqlEntityBuilder)Activator.CreateInstance(type))
               .Select(builder => builder.Build());
         }).ToDictionary(item => item.EntityType, item => item);

         foreach (var itemMap in resultMaps)
         {
            this.entityMaps[itemMap.Key] = itemMap.Value;
         }
      }

      private void LoadXmlEntityMaps(IInsqlDescriptorLoader descriptorLoader)
      {
         var mapSections = new Dictionary<Type, IInsqlMapSection>();

         var insqlDescriptors = descriptorLoader.Load().Values;

         foreach (var descriptor in insqlDescriptors)
         {
            foreach (var map in descriptor.Maps.Values)
            {
               mapSections[map.Type] = map;
            }
         }

         var resultMaps = mapSections.Values.Select(mapSection =>
         {
            var entityMap = string.IsNullOrWhiteSpace(mapSection.Table) ?
                   new InsqlEntityMap(mapSection.Type) :
                   new InsqlEntityMap(mapSection.Type, mapSection.Table, mapSection.Schema);

            foreach (var mapElement in mapSection.Elements.Values)
            {
               var propertyInfo = mapSection.Type.GetProperty(mapElement.Property);

               if (propertyInfo == null)
               {
                  throw new Exception($"insql entity type : {mapSection.Type} `{mapElement.Property}` property is not exist!");
               }

               entityMap.Properties.Add(new InsqlPropertyMap(propertyInfo, mapElement.Name)
               {
                  IsIdentity = mapElement.Identity,
                  IsKey = mapElement.ElementType == InsqlMapElementType.Key
               });
            }

            InsqlEntityValidator.Instance.Validate(entityMap);

            return entityMap;
         }).ToDictionary(item => item.EntityType, item => (IInsqlEntityMap)item);

         foreach (var itemMap in resultMaps)
         {
            this.entityMaps[itemMap.Key] = itemMap.Value;
         }
      }
   }
}
