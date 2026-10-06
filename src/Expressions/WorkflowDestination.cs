// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    [AttributeUsage(AttributeTargets.Parameter)]
    public sealed class WorkflowDestinationAttribute : Attribute
    {
        public WorkflowDestinationAttribute(string schema) { this.Schema = schema; }
        public string Schema { get; }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class WorkflowModelSchemaAttribute : Attribute
    {
        public WorkflowModelSchemaAttribute(int version, string schema)
        {
            this.Version = version;
            this.Schema = schema;
        }
        public int Version { get; }
        public string Schema { get; }
    }

    /// <summary>An immutable destination contract, consumed only from explicit versioned schema data.</summary>
    public sealed class WorkflowDestination
    {
        private static readonly HashSet<string> Keys = new HashSet<string>(StringComparer.Ordinal)
        {
            "version", "destination", "kind", "nullable", "optional", "transforms", "properties", "items",
            "enumPolicy", "enumValues", "inputEncoding", "allowAlreadyEncoded", "runtimeObject",
            "serializerProfile", "default", "clrName", "clrType", "additionalProperties",
        };
        private JToken defaultValue;
        internal string SchemaJson { get; private set; }

        private WorkflowDestination() { }
        public string Name { get; private set; }
        public string Kind { get; private set; }
        public bool Nullable { get; private set; }
        public bool Optional { get; private set; }
        public IReadOnlyList<string> Transforms { get; private set; }
        public IReadOnlyDictionary<string, WorkflowDestination> Properties { get; private set; }
        public WorkflowDestination Items { get; private set; }
        public string EnumPolicy { get; private set; }
        public IReadOnlyList<string> EnumValues { get; private set; }
        public string InputEncoding { get; private set; }
        public bool RuntimeObject { get; private set; }
        public bool AdditionalProperties { get; private set; }
        public string SerializerProfile { get; private set; }
        public bool HasDefault => this.defaultValue != null;
        public JToken DefaultValue => this.defaultValue?.DeepClone();
        internal bool HasTransforms => this.Transforms.Count != 0 ||
            this.Properties.Values.Any(p => p.HasTransforms) || this.Items != null && this.Items.HasTransforms;

        public static WorkflowDestination Parse(string schema)
        {
            if (string.IsNullOrWhiteSpace(schema)) throw new ArgumentException("A versioned destination schema is required.", nameof(schema));
            using (var text = new StringReader(schema))
            using (var reader = new JsonTextReader(text) { DateParseHandling = DateParseHandling.None, MaxDepth = 64 })
            {
                var token = JToken.ReadFrom(reader, new JsonLoadSettings { DuplicatePropertyNameHandling = DuplicatePropertyNameHandling.Error });
                if (reader.Read()) throw new ArgumentException("Trailing content in destination schema.", nameof(schema));
                return ParseNode(token, "$");
            }
        }

        private static WorkflowDestination ParseNode(JToken token, string location)
        {
            if (!(token is JObject node)) throw Error(location, "Expected a destination object.");
            var name = Required<string>(node, "destination", JTokenType.String, location);
            if (string.IsNullOrWhiteSpace(name)) throw Error(location, "A destination name is required.");
            if (node.Properties().Any(p => !Keys.Contains(p.Name))) throw Error(name, "Unknown destination metadata.");
            if (Required<int>(node, "version", JTokenType.Integer, name) != 1)
                throw Error(name, "Unsupported metadata version; only version 1 is supported.");
            var kind = Required<string>(node, "kind", JTokenType.String, name);
            if (!new[] { "text", "number", "boolean", "bytes", "uri", "httpMethod", "enum", "json", "object", "array", "any" }.Contains(kind))
                throw Error(name, "Unsupported normalization kind '" + kind + "'.");
            var result = new WorkflowDestination
            {
                Name = name,
                Kind = kind,
                Nullable = Required<bool>(node, "nullable", JTokenType.Boolean, name),
                Optional = Required<bool>(node, "optional", JTokenType.Boolean, name),
                RuntimeObject = OptionalBool(node, "runtimeObject", name),
                AdditionalProperties = OptionalBool(node, "additionalProperties", name),
                SerializerProfile = OptionalText(node, "serializerProfile", name),
                InputEncoding = OptionalText(node, "inputEncoding", name),
                EnumPolicy = OptionalText(node, "enumPolicy", name),
                SchemaJson = node.ToString(Formatting.None),
            };
            var transforms = Strings(node, "transforms", name);
            bool base64 = false, url = false;
            foreach (var transform in transforms)
            {
                if (transform == "base64" && !base64 && !url) base64 = true;
                else if (transform == "url") url = true;
                else throw Error(name, "Transforms require at most one base64 operation followed by zero or more url operations.");
            }
            result.Transforms = Array.AsReadOnly(transforms);
            if (kind == "bytes" && transforms.Length != 0 && transforms[0] != "base64")
                throw Error(name, "Raw binary requires base64 before URL encoding.");
            if (result.InputEncoding != null && result.InputEncoding != "raw" && result.InputEncoding != "base64")
                throw Error(name, "Unsupported input encoding metadata.");
            var passThrough = OptionalBool(node, "allowAlreadyEncoded", name);
            if ((node["inputEncoding"] != null || node["allowAlreadyEncoded"] != null) && !base64)
                throw Error(name, "Input encoding metadata requires a base64 transform.");
            if (base64 && result.InputEncoding == null)
                throw Error(name, "Base64 requires explicit raw or already-encoded input metadata.");
            if (result.InputEncoding == "base64" && (!passThrough || kind != "text") ||
                passThrough && (kind != "text" || result.InputEncoding == null))
                throw Error(name, "Already-encoded input is unsupported without explicit text pass-through authority.");
            if (result.SerializerProfile != null && (result.SerializerProfile != "compact-json-v1" ||
                !new[] { "json", "any", "object", "array" }.Contains(kind)))
                throw Error(name, "Unsupported or conflicting serializer profile.");
            if ((kind == "json" || transforms.Length != 0 && new[] { "any", "object", "array" }.Contains(kind)) &&
                result.SerializerProfile == null)
                throw Error(name, "JSON normalization requires the explicit compact-json-v1 serializer profile.");
            if (node["runtimeObject"] != null && kind != "object")
                throw Error(name, "Runtime object capability is only valid at an object destination.");
            if (node["additionalProperties"] != null && kind != "object")
                throw Error(name, "Additional properties require an object destination.");
            if (kind == "enum")
            {
                if (result.EnumPolicy != "open" && result.EnumPolicy != "closed") throw Error(name, "An explicit enum policy is required.");
                if (result.EnumPolicy == "closed")
                {
                    var values = Strings(node, "enumValues", name);
                    if (values.Length == 0 || values.Distinct(StringComparer.Ordinal).Count() != values.Length)
                        throw Error(name, "Closed enum values must be non-empty and unique.");
                    result.EnumValues = Array.AsReadOnly(values);
                }
                else if (node["enumValues"] != null) throw Error(name, "Open enum metadata cannot declare a closed value list.");
            }
            else if (node["enumPolicy"] != null || node["enumValues"] != null) throw Error(name, "Enum metadata requires an enum destination.");
            var properties = new Dictionary<string, WorkflowDestination>(StringComparer.Ordinal);
            if (kind == "object")
            {
                if (!(node["properties"] is JObject members)) throw Error(name, "Object properties must be declared explicitly.");
                foreach (var property in members.Properties()) properties.Add(property.Name, ParseNode(property.Value, name + "." + property.Name));
            }
            else if (node["properties"] != null) throw Error(name, "Member metadata requires an object destination.");
            result.Properties = new ReadOnlyDictionary<string, WorkflowDestination>(properties);
            if (kind == "array") result.Items = ParseNode(node["items"], name + "[*]");
            else if (node["items"] != null) throw Error(name, "Element metadata requires an array destination.");
            if (transforms.Length != 0 && (properties.Values.Any(p => p.HasTransforms) || result.Items != null && result.Items.HasTransforms))
                throw Error(name, "Conflicting whole-value and member transforms have no declared precedence.");
            if (node.TryGetValue("default", out var defaultToken))
            {
                if (!(defaultToken is JValue) || defaultToken.Type == JTokenType.Null && !result.Nullable)
                    throw Error(name, "Defaults must be explicitly permitted scalar values.");
                result.defaultValue = SourceSnapshot.CloneJson(defaultToken);
            }
            return result;
        }

        private static T Required<T>(JObject node, string key, JTokenType type, string location)
        {
            if (node[key]?.Type != type) throw Error(location, "Missing or invalid '" + key + "' metadata.");
            return node[key].Value<T>();
        }
        private static bool OptionalBool(JObject node, string key, string location) =>
            node[key] == null ? false : Required<bool>(node, key, JTokenType.Boolean, location);
        private static string OptionalText(JObject node, string key, string location) =>
            node[key] == null ? null : Required<string>(node, key, JTokenType.String, location);
        private static string[] Strings(JObject node, string key, string location)
        {
            if (!(node[key] is JArray values) || values.Any(t => t.Type != JTokenType.String))
                throw Error(location, "Missing or invalid '" + key + "' metadata.");
            return values.Values<string>().ToArray();
        }
        internal static ArgumentException Error(string destination, string message) =>
            new ArgumentException("Destination '" + destination + "': " + message, destination);
    }
}
