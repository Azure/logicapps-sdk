// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.Runtime.Serialization;
    using Newtonsoft.Json.Linq;

    /// <summary>Renders compiler descriptors, not C# syntax trees or executable delegates.</summary>
    internal static class SourceExpressionConverter
    {
        internal static JToken ConvertToken<T>(Func<T> expression) =>
            expression == null ? null : RenderWire(SourceExpression.GetDescriptor(expression));

        internal static string ConvertO<T>(Func<T> expression)
        {
            if (expression == null) return null;
            var token = ConvertToken(expression);
            if (token.Type == JTokenType.Null) return null;
            if (!(token is JValue)) throw new NotSupportedException("A structured expression cannot be used at a scalar destination.");
            return token.Type == JTokenType.String ? token.Value<string>() : token.ToString(Newtonsoft.Json.Formatting.None);
        }

        internal static T ConvertObject<T>(Func<T> expression)
        {
            if (expression == null) return default;
            var descriptor = SourceExpression.GetDescriptor(expression);
            if (descriptor.Kind == "native" || descriptor.Kind == "template" || descriptor.Kind == "capture" && !descriptor.IsLiteral)
                throw new NotSupportedException("This structured destination requires an explicit object/array descriptor or a captured literal. Executable expressions are not evaluated during definition generation.");
            var token = RenderWire(descriptor);
            if (typeof(T) == typeof(Dictionary<string, string>) || typeof(T) == typeof(AgentPromptMessage[]))
                return token.ToObject<T>(new Newtonsoft.Json.JsonSerializer());
            throw new NotSupportedException($"Structured destination '{typeof(T)}' has not been verified.");
        }

        internal static JToken ConvertCondition(Func<bool> expression) => ConvertToken(expression);

        internal static JToken ConvertStatusCode(Func<HttpStatusCode> expression)
        {
            if (expression == null) return new JValue(200);
            var descriptor = SourceExpression.GetDescriptor(expression);
            if (descriptor.IsLiteral)
            {
                var token = descriptor.RenderToken();
                if (token.Type == JTokenType.Null) throw new ArgumentException("Response statusCode cannot be null.", nameof(expression));
                var status = (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), token.Value<string>());
                return new JValue((int)status);
            }
            return new JValue("@csharp{(int)(" + descriptor.RenderNative() + ")}");
        }

        internal static string Convert<T>(Func<T> expression) where T : Enum => ConvertO(expression);

        internal static string ConvertOWithBase64<T>(Func<T> expression)
        {
            if (expression == null) return null;
            var descriptor = SourceExpression.GetDescriptor(expression);
            if (descriptor.IsLiteral)
            {
                var token = descriptor.RenderToken();
                if (token.Type == JTokenType.Null) return null;
                if (token.Type == JTokenType.Bytes) return System.Convert.ToBase64String(token.Value<byte[]>());
                var text = token.Type == JTokenType.String ? token.Value<string>() : token.ToString(Newtonsoft.Json.Formatting.None);
                return "@base64('" + text.Replace("'", "''") + "')";
            }
            if (descriptor.Kind == "native")
            {
                var native = RenderNativeWire(descriptor);
                var type = Nullable.GetUnderlyingType(descriptor.ResultType) ?? descriptor.ResultType;
                if (type == typeof(bool))
                    native = "(" + native + ").ToString().ToLowerInvariant()";
                else if (type.IsPrimitive && type != typeof(char) || type == typeof(decimal))
                    native = "(" + native + ").ToString(global::System.Globalization.CultureInfo.InvariantCulture)";
                return "@csharp{base64(" + native + ")}";
            }
            if (descriptor.Kind == "object" || descriptor.Kind == "array")
                throw new NotSupportedException("Encoding a structured value with runtime leaves requires explicit destination metadata.");
            return "@base64(" + TemplateArgument(descriptor) + ")";
        }

        internal static string ConvertWithUrlEncoding<T>(Func<T> expression, int times)
        {
            var argument = ConvertPathArgumentWithUrlEncoding(expression, times);
            return argument.RequiresCSharp ? "@csharp{" + argument.Native() + "}" :
                argument.IsLiteral && argument.Template.StartsWith("@", StringComparison.Ordinal) ? "@" + argument.Template : argument.Template;
        }

        internal static string ConvertWithUrlEncodingWithInt(Func<int> expression, int times) =>
            ConvertWithUrlEncoding(expression, times);

        internal static ConvertedPathArgument ConvertPathArgumentWithUrlEncoding<T>(Func<T> expression, int times)
        {
            if (times < 0) throw new ArgumentOutOfRangeException(nameof(times));
            var descriptor = SourceExpression.GetDescriptor(expression);
            if (descriptor.IsLiteral && descriptor.RenderToken().Type == JTokenType.Null)
                throw new ArgumentException("A required path argument cannot be null.", nameof(expression));
            Func<string> native = () => WrapUri(RenderNativeWire(descriptor), times);
            if (descriptor.Kind == "native") return new ConvertedPathArgument(null, native, true);
            if (times == 0 && descriptor.IsLiteral)
            {
                var token = descriptor.RenderToken();
                if (!(token is JValue)) throw new NotSupportedException("A structured value cannot be used as a path argument.");
                var text = token.Type == JTokenType.String ? token.Value<string>() : token.ToString(Newtonsoft.Json.Formatting.None);
                return new ConvertedPathArgument(text, native, false, isLiteral: true);
            }
            var template = TemplateArgument(descriptor);
            for (int i = 0; i < times; i++) template = "encodeURIComponent(" + template + ")";
            return new ConvertedPathArgument("@{" + template + "}", native, false);
        }

        internal static ConvertedPathArgument ConvertPathArgumentWithUrlEncodingWithInt(Func<int> expression, int times) =>
            ConvertPathArgumentWithUrlEncoding(expression, times);

        internal static string ConvertGeneratedPath(string format, params ConvertedPathArgument[] arguments)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (arguments == null || arguments.Any(a => a == null)) throw new ArgumentNullException(nameof(arguments));
            if (!arguments.Any(a => a.RequiresCSharp))
            {
                var text = string.Format(CultureInfo.InvariantCulture, format, arguments.Select(a => (object)a.Template).ToArray());
                return arguments.All(a => a.IsLiteral) && text.StartsWith("@", StringComparison.Ordinal) ? "@" + text : text;
            }
            return "@csharp{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, " +
                SourceSnapshot.Quote(format) + ", " + string.Join(", ", arguments.Select(a => a.Native())) + ")}";
        }

        internal sealed class ConvertedPathArgument
        {
            internal ConvertedPathArgument(string template, Func<string> native, bool requiresCSharp, bool isLiteral = false)
            {
                this.Template = template; this.Native = native; this.RequiresCSharp = requiresCSharp; this.IsLiteral = isLiteral;
            }
            internal string Template { get; }
            internal Func<string> Native { get; }
            internal bool RequiresCSharp { get; }
            internal bool IsLiteral { get; }
        }

        private static string WrapUri(string expression, int times)
        {
            for (int i = 0; i < times; i++) expression = "encodeURIComponent(" + expression + ")";
            return expression;
        }

        internal static string TemplateArgument(ISourceDescriptor descriptor, bool allowNull = false)
        {
            var token = descriptor.RenderToken();
            if (descriptor.IsLiteral)
            {
                if (token.Type == JTokenType.Null)
                {
                    if (allowNull) return "null";
                    throw new NotSupportedException("Encoding a null value is unsupported at this destination.");
                }
                if (!(token is JValue)) throw new NotSupportedException("Encoding a structured literal requires destination metadata.");
                return token.Type == JTokenType.String ? "'" + token.Value<string>().Replace("'", "''") + "'" : token.ToString(Newtonsoft.Json.Formatting.None);
            }
            var text = token.Value<string>();
            if (text.StartsWith("@", StringComparison.Ordinal) && !text.StartsWith("@{", StringComparison.Ordinal))
                return text.Substring(1);
            // A whole interpolation needs one transform, not an independent transform per hole.
            var pieces = new List<string>();
            var cursor = 0;
            while (cursor < text.Length)
            {
                var start = text.IndexOf("@{", cursor, StringComparison.Ordinal);
                if (start < 0) { pieces.Add("'" + text.Substring(cursor).Replace("'", "''") + "'"); break; }
                if (start > cursor) pieces.Add("'" + text.Substring(cursor, start - cursor).Replace("'", "''") + "'");
                var end = FindTemplateEnd(text, start + 2);
                pieces.Add(text.Substring(start + 2, end - start - 2));
                cursor = end + 1;
            }
            return pieces.Count == 1 ? pieces[0] : "concat(" + string.Join(", ", pieces) + ")";
        }

        private static int FindTemplateEnd(string text, int start)
        {
            bool quoted = false;
            for (int i = start; i < text.Length; i++)
            {
                if (text[i] == '\'')
                {
                    if (quoted && i + 1 < text.Length && text[i + 1] == '\'') { i++; continue; }
                    quoted = !quoted;
                }
                if (text[i] == '}' && !quoted) return i;
            }
            throw new NotSupportedException("Invalid compiler template descriptor.");
        }

        internal static JToken RenderWire(ISourceDescriptor descriptor)
        {
            // Walk descriptors, not their rendered strings: mixed objects retain which leaves are executable.
            if (descriptor is ISourceStructure structure && structure.Children != null)
            {
                if (structure.Schema != null) return WorkflowSchemaRuntime.Render(descriptor, structure.Schema, escapeLiterals: true);
                if (structure.Names == null) return new JArray(structure.Children.Select(RenderWire));
                var result = new JObject();
                for (int i = 0; i < structure.Names.Count; i++)
                    result.Add(structure.Names[i], RenderWire(structure.Children[i]));
                return result;
            }
            if (descriptor.IsLiteral) return SourceSnapshot.CloneJson(descriptor.RenderToken(), escapeLiterals: true);
            var enumType = Nullable.GetUnderlyingType(descriptor.ResultType) ?? descriptor.ResultType;
            if (enumType.IsEnum && !descriptor.IsLiteral)
                return new JValue("@csharp{" + RenderNativeWire(descriptor) + "}");
            return descriptor.RenderToken();
        }

        internal static string RenderNativeWire(ISourceDescriptor descriptor)
        {
            if (descriptor is ISourceEnumDescriptor enumDescriptor) return enumDescriptor.RenderNativeWire();
            var native = descriptor.RenderNative();
            if (descriptor is ISourceJsonDescriptor)
                native = SourceBinding.Materialize(native, SourceSnapshot.TypeName(descriptor.ResultType));
            var enumType = Nullable.GetUnderlyingType(descriptor.ResultType) ?? descriptor.ResultType;
            if (!enumType.IsEnum) return native;
            if (descriptor.IsLiteral)
            {
                var token = descriptor.RenderToken();
                return token.Type == JTokenType.Null ? "null" : SourceSnapshot.Quote(token.Value<string>());
            }
            var mappings = Enum.GetValues(enumType).Cast<Enum>()
                .GroupBy(e => e.ToString("D"), StringComparer.Ordinal)
                .Select(group => group.First())
                .Select(e => "(" + SourceSnapshot.TypeName(enumType) + ")" + e.ToString("D") + " => " + SourceSnapshot.Quote(EnumWire(e)));
            var nullArm = Nullable.GetUnderlyingType(descriptor.ResultType) != null ? "null => null, " : "";
            return "(" + native + ") switch { " + nullArm + string.Join(", ", mappings) + ", var value => value.ToString() }";
        }

        internal static string EnumWire(Enum value)
        {
            var type = value.GetType();
            var numeric = value.ToString("D");
            var names = type.GetFields(BindingFlags.Public | BindingFlags.Static)
                .Where(f => ((Enum)f.GetValue(null)).ToString("D") == numeric)
                .Select(f => f.GetCustomAttribute<EnumMemberAttribute>()?.Value ?? f.Name)
                .Distinct(StringComparer.Ordinal).ToArray();
            if (names.Length > 1) throw new NotSupportedException($"Enum '{type.FullName}' has conflicting wire aliases for {numeric}.");
            return names.Length == 1 ? names[0] : value.ToString();
        }
    }
}
