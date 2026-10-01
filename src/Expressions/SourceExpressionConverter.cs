// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Net;
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
            return new JValue("#{(int)(" + descriptor.RenderNative() + ")}");
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
                return "#{base64(" + SourceSnapshot.Quote(text) + ")}";
            }
            if (descriptor.Kind == "object" || descriptor.Kind == "array")
                throw new NotSupportedException("Encoding a structured value with runtime leaves requires explicit destination metadata.");
            var native = RenderNativeWire(descriptor);
            var type = Nullable.GetUnderlyingType(descriptor.ResultType) ?? descriptor.ResultType;
            if (type == typeof(bool))
                native = "(" + native + ").ToString().ToLowerInvariant()";
            else if (type.IsPrimitive && type != typeof(char) || type == typeof(decimal))
                native = "(" + native + ").ToString(global::System.Globalization.CultureInfo.InvariantCulture)";
            return "#{base64(" + native + ")}";
        }

        internal static string ConvertWithUrlEncoding<T>(Func<T> expression, int times)
        {
            var argument = ConvertPathArgumentWithUrlEncoding(expression, times);
            return argument.RequiresCSharp ? "#{" + argument.Native() + "}" :
                argument.IsLiteral ? SourceSnapshot.EscapeLiteral(argument.Template) : argument.Template;
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
            if (times == 0 && descriptor.IsLiteral)
            {
                var token = descriptor.RenderToken();
                if (!(token is JValue)) throw new NotSupportedException("A structured value cannot be used as a path argument.");
                var text = token.Type == JTokenType.String ? token.Value<string>() : token.ToString(Newtonsoft.Json.Formatting.None);
                return new ConvertedPathArgument(text, native, false, isLiteral: true);
            }
            return new ConvertedPathArgument(null, native, true);
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
                return arguments.All(a => a.IsLiteral) ? SourceSnapshot.EscapeLiteral(text) : text;
            }
            return "#{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, " +
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
                return new JValue("#{" + RenderNativeWire(descriptor) + "}");
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
                .Select(e => "(" + SourceSnapshot.TypeName(enumType) + ")" + e.ToString("D") + " => " + SourceSnapshot.Quote(WorkflowWireRuntime.EnumWire(e)));
            var nullArm = Nullable.GetUnderlyingType(descriptor.ResultType) != null ? "null => null, " : "";
            return "(" + native + ") switch { " + nullArm + string.Join(", ", mappings) + ", var value => value.ToString() }";
        }

    }
}
