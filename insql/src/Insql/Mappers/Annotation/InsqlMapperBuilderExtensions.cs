﻿using Insql.Mappers;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Insql
{
    public static partial class InsqlMapperBuilderExtensions
    {
        public static InsqlMapperBuilder IncludeAnnotationMaps(this InsqlMapperBuilder builder)
        {
            builder.Services.Configure<InsqlModelOptions>(options =>
            {
                options.IncludeAnnotationMaps = true;
            });

            return builder;
        }

        public static InsqlMapperBuilder IncludeAnnotationMaps(this InsqlMapperBuilder builder, IEnumerable<Assembly> assemblies)
        {
            builder.Services.Configure<InsqlModelOptions>(options =>
            {
                options.IncludeAnnotationMaps = true;
                options.IncludeAnnotationMapsAssemblies = assemblies.ToList();
            });

            return builder;
        }
    }
}
