// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Linq.Expressions;
    using System.Net;
    using System.Text.RegularExpressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts LINQ expression trees to the cheapest supported runtime representation.
    /// Expressions supported by the Logic Apps template language remain template expressions;
    /// expressions requiring native C# are emitted inside an <c>@csharp{...}</c> wrapper.
    /// </summary>
    internal static class CSharpExpressionConverter
    {
        private static readonly CSharpExpressionVisitor Visitor = new CSharpExpressionVisitor();

        /// <summary>Converts an expression to its C# source representation.</summary>
        public static string ConvertO<T>(Expression<Func<T>> e)
        {
            if (e == null) return string.Empty;

            if (!RequiresCSharp(e.Body) && TryConvertTemplateScalar(e, out var template))
            {
                return template;
            }

            return WrapCSharp(Visitor.VisitExpression(e.Body, null));
        }

        /// <summary>Converts an expression for a JSON payload while preserving literal token types.</summary>
        public static JToken ConvertToken<T>(Expression<Func<T>> e)
        {
            if (e == null) return null;

            if (TryConvertLocalJsonToken(e.Body, out var token))
            {
                return token;
            }

            if (TryConvertLocalBoxedPrimitive(e.Body, out var primitive))
            {
                return primitive;
            }

            if (!RequiresCSharp(e.Body))
            {
                try
                {
                    return ExpressionConverter.ConvertO(e);
                }
                catch (Exception exception) when (IsUnsupportedTemplateExpression(exception))
                {
                }
            }

            return new JValue(WrapCSharp(Visitor.VisitExpression(e.Body, null)));
        }

        /// <summary>Converts a structured object while applying hybrid conversion to string values.</summary>
        public static TResult ConvertObject<TResult>(Expression<Func<TResult>> expression)
        {
            if (expression == null)
            {
                return default;
            }

            var converted = new HybridObjectExpressionVisitor().Visit(expression.Body);
            if (!IsSafeToEvaluate(converted))
            {
                throw new NotSupportedException(
                    "Structured expressions must be local values or inline initializers. " +
                    "Executable expressions cannot be evaluated while generating a workflow.");
            }

            return Expression.Lambda<Func<TResult>>(converted, expression.Parameters)
                .Compile()
                .Invoke();
        }

        /// <summary>Converts a condition to its designer-compatible or C# representation.</summary>
        public static JToken ConvertCondition(Expression<Func<bool>> expression)
        {
            if (expression == null)
            {
                return null;
            }

            if (!RequiresCSharp(expression.Body) &&
                expression.Body is BinaryExpression binary &&
                binary.NodeType == ExpressionType.Equal)
            {
                return new JObject
                {
                    ["and"] = new JArray
                    {
                        new JObject
                        {
                            ["equals"] = new JArray(
                                ConvertTemplateToken(binary.Left),
                                ConvertTemplateToken(binary.Right)),
                        },
                    },
                };
            }

            return new JValue(ConvertO(expression));
        }

        /// <summary>Converts a response status without evaluating runtime C# during generation.</summary>
        public static JToken ConvertStatusCode(Expression<Func<HttpStatusCode>> expression)
        {
            if (expression == null)
            {
                return new JValue((int)HttpStatusCode.OK);
            }

            if (TryGetLocalValue(expression.Body, out var value) && value is HttpStatusCode statusCode)
            {
                return new JValue((int)statusCode);
            }

            return new JValue(WrapCSharp($"(int)({Visitor.VisitExpression(expression.Body, null)})"));
        }

        private static bool TryConvertLocalJsonToken(
            Expression expression,
            out JToken result)
        {
            if (!typeof(JToken).IsAssignableFrom(expression.Type) ||
                !IsLocalValue(expression))
            {
                result = null;
                return false;
            }

            var value = Expression.Lambda(expression).Compile().DynamicInvoke() as JToken;
            result = value?.DeepClone() ?? JValue.CreateNull();
            return true;
        }

        private static bool TryConvertLocalBoxedPrimitive(
            Expression expression,
            out JToken result)
        {
            if (expression is not UnaryExpression boxing ||
                boxing.NodeType != ExpressionType.Convert ||
                boxing.Type != typeof(object))
            {
                result = null;
                return false;
            }

            expression = boxing.Operand;
            var type = Nullable.GetUnderlyingType(expression.Type) ?? expression.Type;
            if ((!type.IsPrimitive && type != typeof(decimal)) ||
                type == typeof(char) ||
                !IsLocalValue(expression))
            {
                result = null;
                return false;
            }

            var value = Expression.Lambda(expression).Compile().DynamicInvoke();
            result = value == null ? JValue.CreateNull() : JToken.FromObject(value);
            return true;
        }

        private static bool IsLocalValue(Expression expression) => expression switch
        {
            ConstantExpression => true,
            MemberExpression member when member.Member is System.Reflection.FieldInfo &&
                member.Expression != null => IsLocalValue(member.Expression),
            UnaryExpression unary when unary.Method == null &&
                (unary.NodeType == ExpressionType.Convert ||
                 unary.NodeType == ExpressionType.ConvertChecked) => IsLocalValue(unary.Operand),
            _ => false
        };

        private static bool IsSafeToEvaluate(Expression expression) => expression switch
        {
            ConstantExpression => true,
            DefaultExpression => true,
            MemberExpression member when member.Member is System.Reflection.FieldInfo &&
                member.Expression != null => IsSafeToEvaluate(member.Expression),
            UnaryExpression unary when unary.Method == null &&
                (unary.NodeType == ExpressionType.Convert ||
                 unary.NodeType == ExpressionType.ConvertChecked) => IsSafeToEvaluate(unary.Operand),
            NewExpression created => created.Arguments.All(IsSafeToEvaluate),
            NewArrayExpression array => array.Expressions.All(IsSafeToEvaluate),
            MemberInitExpression initialized =>
                IsSafeToEvaluate(initialized.NewExpression) &&
                initialized.Bindings.All(
                    binding => binding is MemberAssignment assignment &&
                        IsSafeToEvaluate(assignment.Expression)),
            ListInitExpression initialized =>
                IsSafeToEvaluate(initialized.NewExpression) &&
                initialized.Initializers
                    .SelectMany(initializer => initializer.Arguments)
                    .All(IsSafeToEvaluate),
            _ => false,
        };

        private static bool TryGetLocalValue(Expression expression, out object value)
        {
            if (expression is ConstantExpression constant)
            {
                value = constant.Value;
                return true;
            }

            if (expression is MemberExpression member &&
                member.Member is System.Reflection.FieldInfo field &&
                TryGetLocalValue(member.Expression, out var target))
            {
                value = field.GetValue(target);
                return true;
            }

            value = null;
            return false;
        }

        private static JToken ConvertTemplateToken(Expression expression) =>
            expression.Visit(new ComplexObjectConverter(), null);

        /// <summary>Converts an expression to unwrapped C# source.</summary>
        internal static string ConvertCSharp<T>(Expression<Func<T>> e)
        {
            if (e == null) return string.Empty;
            return Visitor.VisitExpression(e.Body, null);
        }

        /// <summary>Converts an expression to an unwrapped C# base64 call.</summary>
        internal static string ConvertCSharpWithBase64<T>(Expression<Func<T>> e)
        {
            if (e == null) return string.Empty;
            return $"base64({Visitor.VisitExpression(e.Body, null)})";
        }

        /// <summary>Converts an enum expression to its quoted member-value string.</summary>
        public static string Convert<T>(Expression<Func<T>> e) where T : Enum
        {
            var value = e.Compile().Invoke();
            return Utility.GetEnumMemberValue(value);
        }

        /// <summary>Wraps an expression in encodeURIComponent calls.</summary>
        public static string ConvertWithUrlEncoding(Expression<Func<string>> e, int times)
        {
            if (e == null) return string.Empty;

            if (RequiresCSharp(e.Body))
            {
                return WrapCSharp(WrapEncodeUri(Visitor.VisitExpression(e.Body, null), times));
            }

            try
            {
                return ExpressionConverter.ConvertWithUrlEncoding(e, times);
            }
            catch (Exception exception) when (IsUnsupportedTemplateExpression(exception))
            {
                return WrapCSharp(WrapEncodeUri(Visitor.VisitExpression(e.Body, null), times));
            }
        }

        /// <summary>Wraps an enum expression in encodeURIComponent calls.</summary>
        public static string ConvertWithUrlEncoding<T>(Expression<Func<T>> e, int times) where T : Enum
        {
            return ExpressionConverter.ConvertWithUrlEncoding(e, times);
        }

        /// <summary>Wraps an int expression in encodeURIComponent calls.</summary>
        public static string ConvertWithUrlEncodingWithInt(Expression<Func<int>> e, int times)
        {
            if (e == null) return string.Empty;

            if (RequiresCSharp(e.Body))
            {
                return WrapCSharp(WrapEncodeUri(Visitor.VisitExpression(e.Body, null), times));
            }

            try
            {
                return ExpressionConverter.ConvertWithUrlEncodingWithInt(e, times);
            }
            catch (Exception exception) when (IsUnsupportedTemplateExpression(exception))
            {
                return WrapCSharp(WrapEncodeUri(Visitor.VisitExpression(e.Body, null), times));
            }
        }

        /// <summary>Wraps an expression in a base64() call.</summary>
        public static string ConvertOWithBase64<T>(Expression<Func<T>> e)
        {
            if (e == null) return string.Empty;

            if (RequiresCSharp(e.Body))
            {
                return WrapCSharp($"base64({Visitor.VisitExpression(e.Body, null)})");
            }

            try
            {
                return ExpressionConverter.ConvertOWithBase64(e);
            }
            catch (Exception exception) when (IsUnsupportedTemplateExpression(exception))
            {
                return WrapCSharp($"base64({Visitor.VisitExpression(e.Body, null)})");
            }
        }

        /// <summary>
        /// Converts a composite format string and its converted arguments into a complete
        /// C# expression that can be evaluated at runtime.
        /// </summary>
        public static string ConvertFormattedString(string format, params string[] arguments)
        {
            if (format == null)
            {
                throw new ArgumentNullException(nameof(format));
            }

            if (arguments == null)
            {
                throw new ArgumentNullException(nameof(arguments));
            }

            foreach (var argument in arguments)
            {
                if (string.IsNullOrEmpty(argument))
                {
                    throw new ArgumentException("Converted arguments cannot be null or empty.", nameof(arguments));
                }
            }

            var renderedFormat = CSharpExpressionVisitor.RenderLiteral(format, typeof(string));
            if (arguments.Length == 0)
            {
                return format;
            }

            if (!arguments.Any(IsCSharpExpression))
            {
                return string.Format(
                    System.Globalization.CultureInfo.InvariantCulture,
                    format,
                    arguments.Cast<object>().ToArray());
            }

            var csharpArguments = arguments.Select(ConvertPathArgumentToCSharp);
            return WrapCSharp(
                $"string.Format(System.Globalization.CultureInfo.InvariantCulture, {renderedFormat}, {string.Join(", ", csharpArguments)})");
        }

        internal static ConvertedPathArgument ConvertPathArgumentWithUrlEncoding(
            Expression<Func<string>> expression,
            int times)
        {
            return ConvertPathArgument(
                expression,
                times,
                ExpressionConverter.ConvertWithUrlEncoding);
        }

        internal static ConvertedPathArgument ConvertPathArgumentWithUrlEncoding<T>(
            Expression<Func<T>> expression,
            int times)
            where T : Enum
        {
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }

            var wireValue = Utility.GetEnumMemberValue(expression.Compile().Invoke());
            return new ConvertedPathArgument(
                ExpressionConverter.ConvertWithUrlEncoding(expression, times),
                WrapEncodeUri(
                    CSharpExpressionVisitor.RenderLiteral(wireValue, typeof(string)),
                    times),
                requiresCSharp: false);
        }

        internal static ConvertedPathArgument ConvertPathArgumentWithUrlEncodingWithInt(
            Expression<Func<int>> expression,
            int times)
        {
            return ConvertPathArgument(
                expression,
                times,
                ExpressionConverter.ConvertWithUrlEncodingWithInt);
        }

        internal static string ConvertGeneratedPath(
            string format,
            params ConvertedPathArgument[] arguments)
        {
            if (format == null)
            {
                throw new ArgumentNullException(nameof(format));
            }

            if (arguments == null)
            {
                throw new ArgumentNullException(nameof(arguments));
            }

            if (arguments.Length == 0)
            {
                return format;
            }

            if (!arguments.Any(argument => argument.RequiresCSharp))
            {
                return string.Format(
                    System.Globalization.CultureInfo.InvariantCulture,
                    format,
                    arguments.Select(argument => (object)argument.TemplateExpression).ToArray());
            }

            var renderedFormat = CSharpExpressionVisitor.RenderLiteral(format, typeof(string));
            return WrapCSharp(
                $"string.Format(System.Globalization.CultureInfo.InvariantCulture, {renderedFormat}, {string.Join(", ", arguments.Select(argument => argument.CSharpExpression))})");
        }

        private static bool TryConvertTemplateScalar<T>(Expression<Func<T>> expression, out string result)
        {
            try
            {
                var type = typeof(T);
                if (type == typeof(string))
                {
                    result = ExpressionConverter.Convert(
                        Expression.Lambda<Func<string>>(expression.Body, expression.Parameters));
                    return true;
                }

                if (type == typeof(bool))
                {
                    result = ExpressionConverter.Convert(
                        Expression.Lambda<Func<bool>>(expression.Body, expression.Parameters));
                    return true;
                }

                if (type == typeof(int))
                {
                    result = expression.Body.Visit(new LogicConverter(), null).Render();
                    return true;
                }

                if (type == typeof(double))
                {
                    result = expression.Body.Visit(new LogicConverter(), null).Render();
                    return true;
                }

                if (type == typeof(Uri))
                {
                    result = ExpressionConverter.Convert(
                        Expression.Lambda<Func<Uri>>(expression.Body, expression.Parameters));
                    return true;
                }

                if (type == typeof(HttpMethod))
                {
                    result = ExpressionConverter.Convert(
                        Expression.Lambda<Func<HttpMethod>>(expression.Body, expression.Parameters));
                    return true;
                }

                if (typeof(JToken).IsAssignableFrom(type))
                {
                    var token = ExpressionConverter.ConvertO(expression);
                    if (token is JValue value && value.Type == JTokenType.String)
                    {
                        result = value.Value<string>();
                        return true;
                    }
                }
            }
            catch (Exception exception) when (IsUnsupportedTemplateExpression(exception))
            {
            }

            result = null;
            return false;
        }

        private static bool IsUnsupportedTemplateExpression(Exception exception) =>
            exception is NotSupportedException ||
            exception is NotImplementedException ||
            exception is NullReferenceException ||
            exception is FormatException;

        private static bool RequiresCSharp(Expression expression)
        {
            var detector = new CSharpRequirementDetector();
            detector.Visit(expression);
            return detector.Required;
        }

        private static bool IsCSharpExpression(string expression) =>
            expression.StartsWith("@csharp{", StringComparison.Ordinal) &&
            expression.EndsWith("}", StringComparison.Ordinal);

        private static string WrapCSharp(string expression) => $"@csharp{{{expression}}}";

        private static ConvertedPathArgument ConvertPathArgument<T>(
            Expression<Func<T>> expression,
            int times,
            Func<Expression<Func<T>>, int, string> convertTemplate)
        {
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }

            var csharp = WrapEncodeUri(
                Visitor.VisitExpression(expression.Body, null),
                times);

            if (!RequiresCSharp(expression.Body))
            {
                try
                {
                    return new ConvertedPathArgument(
                        convertTemplate(expression, times),
                        csharp,
                        requiresCSharp: false);
                }
                catch (Exception exception) when (IsUnsupportedTemplateExpression(exception))
                {
                }
            }

            return new ConvertedPathArgument(
                templateExpression: null,
                csharp,
                requiresCSharp: true);
        }

        private static string ConvertPathArgumentToCSharp(string argument)
        {
            if (IsCSharpExpression(argument))
            {
                return argument.Substring("@csharp{".Length, argument.Length - "@csharp{".Length - 1);
            }

            if (argument.StartsWith("@{", StringComparison.Ordinal) &&
                argument.EndsWith("}", StringComparison.Ordinal))
            {
                var templateExpression = argument.Substring(2, argument.Length - 3);
                return Regex.Replace(
                    templateExpression,
                    "'(?<value>(?:[^'\\\\]|\\\\.)*)'",
                    match => CSharpExpressionVisitor.RenderLiteral(
                        match.Groups["value"].Value.Replace("\\'", "'"),
                        typeof(string)));
            }

            return CSharpExpressionVisitor.RenderLiteral(argument, typeof(string));
        }

        private sealed class CSharpRequirementDetector : ExpressionVisitor
        {
            public bool Required { get; private set; }

            protected override Expression VisitMember(MemberExpression node)
            {
                if (node.Expression != null && IsNativeRuntimeType(node.Expression.Type))
                {
                    this.Required = true;
                    return node;
                }

                return base.VisitMember(node);
            }

            protected override Expression VisitBinary(BinaryExpression node)
            {
                if (node.NodeType == ExpressionType.ArrayIndex)
                {
                    this.Required = true;
                    return node;
                }

                return base.VisitBinary(node);
            }

            protected override Expression VisitMethodCall(MethodCallExpression node)
            {
                if (!IsTemplateInfrastructureMethod(node))
                {
                    this.Required = true;
                    return node;
                }

                return base.VisitMethodCall(node);
            }

            private static bool IsTemplateInfrastructureMethod(MethodCallExpression node)
            {
                if (node.Method.Name == "get_Item" &&
                    node.Object != null &&
                    typeof(JToken).IsAssignableFrom(node.Object.Type))
                {
                    return true;
                }

                if (node.Method.DeclaringType == typeof(string) &&
                    (node.Method.Name == nameof(string.Concat) ||
                     node.Method.Name == nameof(string.Format)))
                {
                    return true;
                }

                return node.Method.DeclaringType == typeof(WorkflowFunctions) &&
                       node.Method.Name == nameof(WorkflowFunctions.ToJson);
            }

            private static bool IsNativeRuntimeType(Type type)
            {
                type = Nullable.GetUnderlyingType(type) ?? type;
                return type == typeof(string) ||
                       type == typeof(DateTime) ||
                       type == typeof(DateTimeOffset) ||
                       type == typeof(TimeSpan) ||
                       type == typeof(Guid) ||
                       type == typeof(Uri) ||
                       type.IsPrimitive ||
                       type.IsEnum ||
                       type == typeof(decimal);
            }
        }

        private sealed class HybridObjectExpressionVisitor : ExpressionVisitor
        {
            protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
            {
                if (GetMemberType(node.Member) == typeof(string))
                {
                    return Expression.Bind(
                        node.Member,
                        Expression.Constant(ConvertString(node.Expression), typeof(string)));
                }

                return base.VisitMemberAssignment(node);
            }

            protected override ElementInit VisitElementInit(ElementInit node)
            {
                if (node.Arguments.Count == 2 &&
                    node.Arguments[1].Type == typeof(string))
                {
                    return Expression.ElementInit(
                        node.AddMethod,
                        this.Visit(node.Arguments[0]),
                        Expression.Constant(ConvertString(node.Arguments[1]), typeof(string)));
                }

                return base.VisitElementInit(node);
            }

            private static string ConvertString(Expression expression) =>
                ConvertO(Expression.Lambda<Func<string>>(expression));

            private static Type GetMemberType(System.Reflection.MemberInfo member) => member switch
            {
                System.Reflection.PropertyInfo property => property.PropertyType,
                System.Reflection.FieldInfo field => field.FieldType,
                _ => null,
            };
        }

        internal readonly struct ConvertedPathArgument
        {
            public ConvertedPathArgument(
                string templateExpression,
                string csharpExpression,
                bool requiresCSharp)
            {
                this.TemplateExpression = templateExpression;
                this.CSharpExpression = csharpExpression;
                this.RequiresCSharp = requiresCSharp;
            }

            public string TemplateExpression { get; }

            public string CSharpExpression { get; }

            public bool RequiresCSharp { get; }
        }

        private static string WrapEncodeUri(string inner, int times)
        {
            while (times > 0)
            {
                inner = $"encodeURIComponent({inner})";
                times--;
            }
            return inner;
        }
    }
}
