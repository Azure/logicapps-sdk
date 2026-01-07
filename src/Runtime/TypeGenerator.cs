// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Runtime
{
    using System;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Type generator for generating JSON schemas from .NET types.
    /// </summary>
    internal class TypeGenerator
    {
        /// <summary>
        /// Generates a JSON schema for the given type.
        /// </summary>
        /// <param name="t">The type.</param>
        /// <param name="desc">The description.</param>
        /// <param name="generateRequired">Whether to generate required properties.</param>
        public static JObject GenerateSchema(Type t, JObject desc, bool generateRequired = true)
        {
            if (IsSimpleType(t))
            {
                if (t == typeof(int))
                {
                    desc["type"] = "integer";
                }
                else if (t == typeof(string))
                {
                    desc["type"] = "string";
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else
            {
                desc["type"] = "object";
                var properties = new JObject();
                var propNames = new List<string>();

                foreach (var prop in t.GetProperties())
                {
                    var propDesc = new JObject();
                    var schema = GenerateSchema(prop.PropertyType, propDesc, generateRequired);
                    propDesc["description"] = $"The {prop.Name} property.";

                    properties[prop.Name] = propDesc;
                    propNames.Add(prop.Name);
                }

                desc["properties"] = properties;

                if (generateRequired)
                {
                    desc["required"] = new JArray(propNames);
                }
            }

            return desc;
        }

        /// <summary>
        /// Checks if the type is a simple type.
        /// </summary>
        /// <param name="type">The type.</param>
        private static bool IsSimpleType(Type type)
        {
            return
                type.IsPrimitive ||
                type.IsEnum ||
                type == typeof(string) ||
                type == typeof(decimal) ||
                type == typeof(DateTime) ||
                type == typeof(DateTimeOffset) ||
                type == typeof(TimeSpan) ||
                type == typeof(Guid);
        }
    }
}
