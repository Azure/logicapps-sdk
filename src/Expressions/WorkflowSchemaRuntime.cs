// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using Newtonsoft.Json.Linq;

    /// <summary>Definition generation for SDK schema-generated APIs. No authoring delegate is invoked.</summary>
    public static class WorkflowSchemaRuntime
    {
        public static ComposeAction<JToken> Value(string schema, Delegate value)
        {
            var destination = WorkflowDestination.Parse(schema);
            var descriptor = OptionalDescriptor(value, destination);
            return new SchemaAction(() => descriptor == null ? JValue.CreateNull() : Render(descriptor, destination, escapeLiterals: true));
        }

        public static ComposeAction<JToken> Object(string[] names, string[] schemas, Delegate[] values)
        {
            ValidateArguments(schemas, values);
            if (names == null || names.Length != values.Length || names.Any(string.IsNullOrEmpty) ||
                names.Distinct(StringComparer.Ordinal).Count() != names.Length)
                throw new ArgumentException("Generated object fields require unique names and matching schemas and values.", nameof(names));
            var fieldNames = (string[])names.Clone();
            var destinations = schemas.Select(WorkflowDestination.Parse).ToArray();
            var descriptors = values.Select((v, i) => OptionalDescriptor(v, destinations[i])).ToArray();
            return new SchemaAction(() =>
            {
                var result = new JObject();
                for (int i = 0; i < descriptors.Length; i++)
                    if (descriptors[i] != null) result.Add(fieldNames[i], Render(descriptors[i], destinations[i], escapeLiterals: true));
                return result;
            });
        }

        public static ComposeAction<JToken> Path(string format, string[] schemas, Delegate[] values)
        {
            ValidateArguments(schemas, values);
            ValidatePath(format, values.Length);
            var destinations = schemas.Select(WorkflowDestination.Parse).ToArray();
            if (destinations.Any(d => d.Optional || d.Nullable))
                throw new ArgumentException("Path schemas must explicitly require non-null arguments.", nameof(schemas));
            var descriptors = values.Select((v, i) => OptionalDescriptor(v, destinations[i])).ToArray();
            return new SchemaAction(() =>
            {
                var rendered = descriptors.Select((d, i) => Render(d, destinations[i])).ToArray();
                if (rendered.Any(IsNative))
                {
                    var expressions = descriptors.Select((d, i) => Native(d, destinations[i]));
                    return new JValue("#{string.Format(" + SourceSnapshot.Quote(format) + ", " + string.Join(", ", expressions) + ")}");
                }
                var path = new JValue(string.Format(CultureInfo.InvariantCulture, format, rendered.Select(t => (object)t.Value<string>()).ToArray()));
                return descriptors.Select((d, i) => d.IsLiteral && destinations[i].Transforms.Count == 0).All(literal => literal)
                    ? SourceSnapshot.CloneJson(path, escapeLiterals: true) : path;
            });
        }

        private static ISourceDescriptor OptionalDescriptor(Delegate value, WorkflowDestination destination)
        {
            if (value != null) return SourceExpression.GetDescriptor(value);
            if (destination.HasDefault) return new SourceDescriptor<JToken>(SourceSnapshot.Create(destination.DefaultValue));
            if (!destination.Optional) throw WorkflowDestination.Error(destination.Name, "A required argument is missing.");
            return null;
        }

        internal static JToken Render(ISourceDescriptor descriptor, WorkflowDestination destination, bool escapeLiterals = false)
        {
            var structured = descriptor as ISourceStructure;
            if (destination.Transforms.Count != 0 && structured?.Schema != null &&
                structured.Schema != destination && structured.Schema.HasTransforms)
                throw WorkflowDestination.Error(destination.Name, "Conflicting whole-value and model-member transforms have no declared precedence.");
            if (destination.Kind == "object" || destination.Kind == "array")
            {
                if (structured != null && structured.Children != null)
                {
                    var token = RenderStructure(structured, destination, escapeLiterals && destination.Transforms.Count == 0);
                    if (destination.Transforms.Count == 0) return token;
                    if (descriptor.IsLiteral) return EncodeLiteral(token, descriptor.ResultType, destination, escapeLiterals);
                    return new JValue("#{" + Native(descriptor, destination) + "}");
                }
                if (!descriptor.IsLiteral && !destination.RuntimeObject)
                    throw WorkflowDestination.Error(destination.Name, "Runtime-object expressions require an explicit verified runtimeObject capability.");
                if (!descriptor.IsLiteral && destination.HasTransforms && destination.Transforms.Count == 0)
                    throw WorkflowDestination.Error(destination.Name, "Runtime-object member transforms require structural source metadata.");
            }
            if (descriptor.IsLiteral)
            {
                var token = descriptor.RenderToken();
                if (descriptor.ResultType == typeof(byte[]) && token is JArray bytes && destination.Kind != "array")
                    token = new JValue(bytes.Select(b => b.Value<byte>()).ToArray());
                ValidateLiteral(token, descriptor.ResultType, destination);
                if (token.Type == JTokenType.Null) return token;
                if (destination.Transforms.Count == 0 && (destination.Kind == "any" || destination.Kind == "json"))
                    return escapeLiterals ? SourceExpressionConverter.RenderWire(descriptor) : token;
                if (destination.Kind == "object" || destination.Kind == "array")
                {
                    token = RenderLiteralStructure(token, destination, escapeLiterals && destination.Transforms.Count == 0);
                    return destination.Transforms.Count == 0 ? token : EncodeLiteral(token, descriptor.ResultType, destination, escapeLiterals);
                }
                return destination.Transforms.Count == 0 ? SourceSnapshot.CloneJson(token, escapeLiterals) : EncodeLiteral(token, descriptor.ResultType, destination, escapeLiterals);
            }

            ValidateType(descriptor.ResultType, destination);
            if (destination.Transforms.Count == 0 &&
                (destination.Kind == "any" || destination.Kind == "json" ||
                 !(Nullable.GetUnderlyingType(descriptor.ResultType) ?? descriptor.ResultType).IsEnum))
                return escapeLiterals ? SourceExpressionConverter.RenderWire(descriptor) : descriptor.RenderToken();
            return new JValue("#{" + Native(descriptor, destination) + "}");
        }

        private static JToken RenderStructure(ISourceStructure structure, WorkflowDestination destination, bool escapeLiterals)
        {
            if (destination.Kind == "array")
            {
                if (structure.Names != null) throw WorkflowDestination.Error(destination.Name, "Expected an array, not an object.");
                return new JArray(structure.Children.Select(c => Render(c, destination.Items, escapeLiterals)));
            }
            if (structure.Names == null) throw WorkflowDestination.Error(destination.Name, "Expected an object, not an array.");
            var members = structure.Names.Select((name, i) => new { name, Value = structure.Children[i] })
                .ToDictionary(p => p.name, p => p.Value, StringComparer.Ordinal);
            if (!destination.AdditionalProperties && members.Keys.Any(name => !destination.Properties.ContainsKey(name)))
                throw WorkflowDestination.Error(destination.Name, "The value contains members absent from the authoritative schema.");
            var result = new JObject();
            foreach (var property in destination.Properties)
            {
                if (members.TryGetValue(property.Key, out var member)) result.Add(property.Key, Render(member, property.Value, escapeLiterals));
                else if (property.Value.HasDefault) result.Add(property.Key, RenderDefault(property.Value, escapeLiterals));
                else if (!property.Value.Optional) throw WorkflowDestination.Error(property.Value.Name, "A required member is missing.");
            }
            if (destination.AdditionalProperties)
                foreach (var member in members.Where(p => !destination.Properties.ContainsKey(p.Key)))
                    result.Add(member.Key, escapeLiterals ? SourceExpressionConverter.RenderWire(member.Value) : member.Value.RenderToken());
            return result;
        }

        private static JToken RenderLiteralStructure(JToken token, WorkflowDestination destination, bool escapeLiterals)
        {
            if (destination.Kind == "array")
                return new JArray(((JArray)token).Select(t => Render(new SourceDescriptor<JToken>(SourceSnapshot.Create(t)), destination.Items, escapeLiterals)));
            var obj = (JObject)token;
            if (!destination.AdditionalProperties && obj.Properties().Any(p => !destination.Properties.ContainsKey(p.Name)))
                throw WorkflowDestination.Error(destination.Name, "The value contains members absent from the authoritative schema.");
            var result = new JObject();
            foreach (var property in destination.Properties)
            {
                if (obj.TryGetValue(property.Key, out var value))
                    result.Add(property.Key, Render(new SourceDescriptor<JToken>(SourceSnapshot.Create(value)), property.Value, escapeLiterals));
                else if (property.Value.HasDefault) result.Add(property.Key, RenderDefault(property.Value, escapeLiterals));
                else if (!property.Value.Optional) throw WorkflowDestination.Error(property.Value.Name, "A required member is missing.");
            }
            if (destination.AdditionalProperties)
                foreach (var property in obj.Properties().Where(p => !destination.Properties.ContainsKey(p.Name)))
                    result.Add(property.Name, SourceSnapshot.CloneJson(property.Value, escapeLiterals));
            return result;
        }

        private static JToken RenderDefault(WorkflowDestination destination, bool escapeLiterals) =>
            Render(new SourceDescriptor<JToken>(SourceSnapshot.Create(destination.DefaultValue)), destination, escapeLiterals);

        private static JToken EncodeLiteral(JToken token, Type type, WorkflowDestination destination, bool escapeLiterals)
        {
            ValidateLiteral(token, type, destination);
            if (token.Type == JTokenType.Null) return token;
            if (destination.InputEncoding == "base64")
            {
                var text = token.Value<string>();
                if (!destination.Transforms.Contains("url")) return SourceSnapshot.CloneJson(new JValue(text), escapeLiterals);
                return NativeTransforms(SourceSnapshot.Quote(text), destination);
            }
            if (token.Type == JTokenType.Bytes && destination.Transforms.FirstOrDefault() == "base64")
            {
                var encoded = System.Convert.ToBase64String(token.Value<byte[]>());
                var urls = destination.Transforms.Count(t => t == "url");
                if (urls == 0) return new JValue(encoded);
                var expression = SourceSnapshot.Quote(encoded);
                for (int i = 0; i < urls; i++) expression = "encodeURIComponent(" + expression + ")";
                return new JValue("#{" + expression + "}");
            }
            if (token.Type == JTokenType.Bytes)
                throw WorkflowDestination.Error(destination.Name, "Raw binary requires an explicit base64 transform.");
            var normalized = token.Type == JTokenType.String ? token.Value<string>() :
                token.Type == JTokenType.Boolean ? (token.Value<bool>() ? "true" : "false") :
                WorkflowWireRuntime.ToCompactJson(token);
            return NativeTransforms(SourceSnapshot.Quote(normalized), destination);
        }

        private static JToken NativeTransforms(string expression, WorkflowDestination destination)
        {
            foreach (var transform in destination.Transforms)
            {
                if (transform == "base64" && destination.InputEncoding == "base64") continue;
                expression = (transform == "url" ? "encodeURIComponent" : "base64") + "(" + expression + ")";
            }
            return new JValue("#{" + expression + "}");
        }

        private static string Native(ISourceDescriptor descriptor, WorkflowDestination destination)
        {
            ValidateType(descriptor.ResultType, destination);
            var nullableType = Nullable.GetUnderlyingType(descriptor.ResultType);
            var type = Nullable.GetUnderlyingType(descriptor.ResultType) ?? descriptor.ResultType;
            if (destination.Transforms.Count != 0 && destination.InputEncoding != "base64" &&
                !IsScalar(type) && type != typeof(byte[]) &&
                (destination.Kind == "json" || destination.Kind == "object" || destination.Kind == "array" || destination.Kind == "any") &&
                (descriptor is ISourceValueDescriptor || descriptor is ISourceJsonDescriptor))
            {
                var json = descriptor is ISourceValueDescriptor value ? value.RenderJson() : descriptor.RenderNative();
                return "global::Microsoft.Azure.Workflows.Sdk.WorkflowWireRuntime.NormalizeAndEncode(" +
                    json + ", " + SourceSnapshot.Quote(destination.SchemaJson) + ")";
            }
            // Plain JSON text references can use host encoding helpers without an SDK dependency.
            var jsonTextReference = descriptor is ISourceValueDescriptor && destination.Kind == "text";
            if (destination.Transforms.Count != 0 &&
                (nullableType != null || typeof(JToken).IsAssignableFrom(type) && !jsonTextReference))
                return "global::Microsoft.Azure.Workflows.Sdk.WorkflowWireRuntime.NormalizeAndEncode(" +
                    descriptor.RenderNative() + ", " + SourceSnapshot.Quote(destination.SchemaJson) + ")";
            var expression = SourceExpressionConverter.RenderNativeWire(descriptor);
            if (destination.Kind == "enum")
            {
                if (destination.EnumPolicy == "closed" || nullableType != null && !destination.Nullable)
                    expression = "global::Microsoft.Azure.Workflows.Sdk.WorkflowWireRuntime.RequireEnumWire(" + expression +
                        ", " + (destination.EnumValues == null ? "null" : "new string[] { " + string.Join(", ", destination.EnumValues.Select(SourceSnapshot.Quote)) + " }") +
                        ", " + (destination.Nullable ? "true" : "false") + ", " + SourceSnapshot.Quote(destination.Name) + ")";
            }
            if (destination.Transforms.Count == 0) return expression;
            if (destination.InputEncoding != "base64")
            {
                if (destination.Kind == "json" || destination.Kind == "object" || destination.Kind == "array" ||
                    destination.Kind == "any" && !IsScalar(type) && type != typeof(byte[]))
                    expression = CompactJsonExpression(descriptor.ResultType, expression);
                else if (type == typeof(bool)) expression = "(" + expression + ").ToString().ToLowerInvariant()";
                else if (WorkflowWireRuntime.IsNumber(type)) expression = "(" + expression + ").ToString(global::System.Globalization.CultureInfo.InvariantCulture)";
                else if (type == typeof(Uri)) expression = "(" + expression + ").OriginalString";
                else if (type == typeof(System.Net.Http.HttpMethod)) expression = "(" + expression + ").Method";
            }
            foreach (var transform in destination.Transforms)
            {
                if (transform == "base64" && destination.InputEncoding == "base64") continue;
                expression = transform == "base64" && type == typeof(byte[])
                    ? "global::System.Convert.ToBase64String(" + expression + ")"
                    : (transform == "url" ? "encodeURIComponent" : "base64") + "(" + expression + ")";
            }
            return expression;
        }

        // Only closed, finite-valued CLR shapes can use the ordinary Newtonsoft writer
        // without losing the SDK writer's enum, converter, raw-JSON, or NaN checks.
        internal static string CompactJsonExpression(Type sourceType, string expression)
        {
            if (!SupportsFrameworkJson(sourceType))
                return "global::Microsoft.Azure.Workflows.Sdk.WorkflowWireRuntime.ToCompactJson(" + expression + ")";

            return "global::Newtonsoft.Json.Linq.JToken.FromObject((object)(" + expression +
                ") ?? global::Newtonsoft.Json.Linq.JValue.CreateNull(), " +
                "global::Newtonsoft.Json.JsonSerializer.Create(new global::Newtonsoft.Json.JsonSerializerSettings { " +
                "Culture = global::System.Globalization.CultureInfo.InvariantCulture, " +
                "Formatting = global::Newtonsoft.Json.Formatting.None, " +
                "NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Include, " +
                "DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Include, " +
                "ContractResolver = new global::Newtonsoft.Json.Serialization.DefaultContractResolver { " +
                "NamingStrategy = new global::Newtonsoft.Json.Serialization.DefaultNamingStrategy() }, " +
                "DateFormatHandling = global::Newtonsoft.Json.DateFormatHandling.IsoDateFormat, " +
                "DateTimeZoneHandling = global::Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind, " +
                "TypeNameHandling = global::Newtonsoft.Json.TypeNameHandling.None, " +
                "StringEscapeHandling = global::Newtonsoft.Json.StringEscapeHandling.Default, " +
                "FloatFormatHandling = global::Newtonsoft.Json.FloatFormatHandling.String, " +
                "ReferenceLoopHandling = global::Newtonsoft.Json.ReferenceLoopHandling.Error, " +
                "PreserveReferencesHandling = global::Newtonsoft.Json.PreserveReferencesHandling.None " +
                "})).ToString(global::Newtonsoft.Json.Formatting.None)";
        }

        private static bool SupportsFrameworkJson(Type type)
        {
            type = Nullable.GetUnderlyingType(type) ?? type;
            if (type == typeof(string) || type == typeof(bool) || type == typeof(char) ||
                type == typeof(byte) || type == typeof(sbyte) || type == typeof(short) ||
                type == typeof(ushort) || type == typeof(int) || type == typeof(uint) ||
                type == typeof(long) || type == typeof(ulong) || type == typeof(decimal))
                return true;
            if (type.IsArray)
                return type.GetArrayRank() == 1 && type != typeof(byte[]) && SupportsFrameworkJson(type.GetElementType());
            return type.IsSealed && type.Name.StartsWith("<>f__AnonymousType", StringComparison.Ordinal) &&
                type.IsDefined(typeof(CompilerGeneratedAttribute), inherit: false) &&
                type.GetProperties(BindingFlags.Instance | BindingFlags.Public).All(property => SupportsFrameworkJson(property.PropertyType));
        }

        private static void ValidateLiteral(JToken token, Type type, WorkflowDestination destination)
        {
            if (token.Type == JTokenType.Null)
            {
                if (!destination.Nullable) throw WorkflowDestination.Error(destination.Name, "A required non-null value cannot be null.");
                return;
            }
            bool valid;
            switch (destination.Kind)
            {
                case "text": valid = token.Type == JTokenType.String; break;
                case "number": valid = token.Type == JTokenType.Integer || token.Type == JTokenType.Float; break;
                case "boolean": valid = token.Type == JTokenType.Boolean; break;
                case "bytes": valid = token.Type == JTokenType.Bytes; break;
                case "uri": valid = type == typeof(Uri); break;
                case "httpMethod": valid = type == typeof(System.Net.Http.HttpMethod); break;
                case "object": valid = token.Type == JTokenType.Object; break;
                case "array": valid = token.Type == JTokenType.Array; break;
                case "enum":
                    valid = (Nullable.GetUnderlyingType(type) ?? type).IsEnum && token.Type == JTokenType.String;
                    if (valid) WorkflowWireRuntime.RequireEnumWire(token.Value<string>(), destination.EnumValues?.ToArray(), destination.Nullable, destination.Name);
                    break;
                default: valid = true; break;
            }
            if (!valid) throw Unsupported(type, destination);
        }

        private static void ValidateType(Type type, WorkflowDestination destination)
        {
            type = Nullable.GetUnderlyingType(type) ?? type;
            var token = typeof(JToken).IsAssignableFrom(type);
            if (destination.Kind == "enum" && !type.IsEnum ||
                destination.Kind == "text" && type != typeof(string) && type != typeof(char) && !token ||
                destination.Kind == "number" && !WorkflowWireRuntime.IsNumber(type) && !token ||
                destination.Kind == "boolean" && type != typeof(bool) && !token ||
                destination.Kind == "bytes" && type != typeof(byte[]) ||
                destination.Kind == "uri" && type != typeof(Uri) ||
                destination.Kind == "httpMethod" && type != typeof(System.Net.Http.HttpMethod))
                throw Unsupported(type, destination);
        }
        private static NotSupportedException Unsupported(Type type, WorkflowDestination destination) =>
            new NotSupportedException("Destination '" + destination.Name + "' does not support encoding normalization of '" + type.FullName + "' as " + destination.Kind + ".");
        private static bool IsScalar(Type type) =>
            type == typeof(string) || type.IsEnum || type == typeof(bool) || type == typeof(char) ||
            WorkflowWireRuntime.IsNumber(type) || type == typeof(Uri) || type == typeof(System.Net.Http.HttpMethod);
        private static bool IsNative(JToken token) =>
            token.Type == JTokenType.String && token.Value<string>().StartsWith("#{", StringComparison.Ordinal);
        private static void ValidateArguments(string[] schemas, Delegate[] values)
        {
            if (schemas == null || values == null || schemas.Length != values.Length || schemas.Any(s => s == null))
                throw new ArgumentException("Generated fields require one explicit schema per argument.");
        }
        private static void ValidatePath(string format, int count)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            int argument = 0;
            for (int index = 0; index < format.Length; index++)
            {
                if (format[index] != '{' && format[index] != '}') continue;
                var placeholder = "{" + argument.ToString(CultureInfo.InvariantCulture) + "}";
                if (format[index] != '{' || !format.Substring(index).StartsWith(placeholder, StringComparison.Ordinal))
                    throw new ArgumentException("Generated paths require each argument once, in declaration order, without format specifiers.", nameof(format));
                index += placeholder.Length - 1;
                argument++;
            }
            if (argument != count) throw new ArgumentException("Path argument count does not match its schema.", nameof(format));
        }

        private sealed class SchemaAction : ComposeAction<JToken>
        {
            private readonly Func<JToken> render;
            internal SchemaAction(Func<JToken> render) : base(render()) { this.render = render; }
            public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null) =>
                new FlowTemplateAction { Type = FlowTemplateOperationType.Compose, Inputs = this.render() };
        }
    }
}
