﻿using System;
using System.Linq;
using System.Reflection;

namespace Insql.Mappers
{
    public class InsqlEntityPropertyBuilder
    {
        private readonly IInsqlEntityMap entityMap;
        private readonly InsqlPropertyMap propertyMap;

        public InsqlEntityPropertyBuilder(IInsqlEntityMap entityMap, PropertyInfo propertyInfo)
        {
            if (entityMap.Properties.Any(o => o.PropertyInfo.Name == propertyInfo.Name))
            {
                throw new Exception($"insql entity builder type : {entityMap.EntityType} `{propertyInfo.Name}` property have been mapped!");
            }

            this.entityMap = entityMap;

            this.propertyMap = new InsqlPropertyMap(propertyInfo);

            this.entityMap.Properties.Add(this.propertyMap);
        }

        public InsqlEntityPropertyBuilder Column(string columnName)
        {
            if (string.IsNullOrWhiteSpace(columnName))
            {
                throw new ArgumentNullException(nameof(columnName));
            }

            this.propertyMap.ColumnName = columnName;

            return this;
        }

        public InsqlEntityPropertyBuilder Key()
        {
            this.propertyMap.IsKey = true;

            return this;
        }

        public InsqlEntityPropertyBuilder Identity()
        {
            this.propertyMap.IsIdentity = true;

            return this;
        }

        public InsqlEntityPropertyBuilder Readonly()
        {
            this.propertyMap.IsReadonly = true;

            return this;
        }

        public InsqlEntityPropertyBuilder Ignore()
        {
            this.propertyMap.IsIgnored = true;

            return this;
        }
    }
}
