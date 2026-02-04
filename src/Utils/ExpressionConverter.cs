namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts LINQ expressions to their string representations.
    /// </summary>
    internal class ExpressionConverter
    {
        /// <summary>
        /// Converts a string expression to its rendered form.
        /// </summary>
        /// <param name="e">The expression to convert.</param>
        public static string Convert(Expression<Func<string>> e)
        {
            if (e == null) return string.Empty;
            var converter = new LogicConverter();
            var expr = e.Body.Visit(converter, null);
            return expr.Render();
        }

        /// <summary>
        /// Converts a URI expression to its rendered form.
        /// </summary>
        /// <param name="e">The expression to convert.</param>
        public static string Convert(Expression<Func<Uri>> e)
        {
            if (e == null) return string.Empty;
            var converter = new LogicConverter();
            var expr = e.Body.Visit(converter, null);
            return expr.Render();
        }

        /// <summary>
        /// Converts an HTTP method expression to its rendered form.
        /// </summary>
        /// <param name="e">The expression to convert.</param>
        public static string Convert(Expression<Func<HttpMethod>> e)
        {
            if (e == null) return string.Empty;
            var converter = new LogicConverter();
            var expr = e.Body.Visit(converter, null);
            return expr.Render();
        }

        /// <summary>
        /// Converts a string expression with URL encoding applied multiple times.
        /// </summary>
        /// <param name="e">The expression to convert.</param>
        /// <param name="times">The number of times to apply URL encoding.</param>
        public static string ConvertWithUrlEncoding(Expression<Func<string>> e, int times)
        {
            if (e == null) return string.Empty;
            var converter = new LogicConverter();
            var expr = e.Body.Visit(converter, null);

            while (times > 0)
            {
                expr = new FunctionCallNode
                {
                    FunctionName = "encodeURIComponent",
                    Arguments = [expr]
                };

                times--;
            }

            return expr.Render(true);
        }

        /// <summary>
        /// Converts a string expression with URL encoding applied multiple times.
        /// </summary>
        /// <param name="e">The expression to convert.</param>
        /// <param name="times">The number of times to apply URL encoding.</param>
        public static string ConvertWithUrlEncodingWithInt(Expression<Func<int>> e, int times)
        {
            if (e == null) return string.Empty;
            var converter = new LogicConverter();
            var expr = e.Body.Visit(converter, null);

            while (times > 0)
            {
                expr = new FunctionCallNode
                {
                    FunctionName = "encodeURIComponent",
                    Arguments = [expr]
                };

                times--;
            }

            return expr.Render(true);
        }

        /// <summary>
        /// Converts an enum expression with URL encoding applied multiple times.
        /// </summary>
        /// <param name="e">The expression to convert.</param>
        /// <param name="times">The number of times to apply URL encoding.</param>
        /// <typeparam name="T">The enum type.</typeparam>
        public static string ConvertWithUrlEncoding<T>(Expression<Func<T>> e, int times) where T : Enum
        {
            var value = e.Compile().Invoke();
            var converted = Utility.GetEnumMemberValue(value);
            return ConvertWithUrlEncoding(() => converted, times);
        }

        /// <summary>
        /// Converts an integer expression to its rendered form.
        /// </summary>
        /// <param name="e">The expression to convert.</param>
        public static string Convert(Expression<Func<int>> e)
        {
            var visitor = new Visitor();
            visitor.Visit(e.Body);
            return visitor.Result;
        }

        /// <summary>
        /// Converts a string array expression to a JSON array.
        /// </summary>
        /// <param name="e">The expression to convert.</param>
        public static JArray Convert(Expression<Func<string[]>> e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Converts a double expression to its rendered form.
        /// </summary>
        /// <param name="e">The expression to convert.</param>
        public static string Convert(Expression<Func<double>> e)
        {
            var visitor = new Visitor();
            visitor.Visit(e.Body);
            return visitor.Result;
        }

        /// <summary>
        /// Converts an enum expression to its member value representation.
        /// </summary>
        /// <param name="e">The expression to convert.</param>
        /// <typeparam name="T">The enum type.</typeparam>
        public static string Convert<T>(Expression<Func<T>> e) where T : Enum
        {
            var value = e.Compile().Invoke();
            var converted = Utility.GetEnumMemberValue(value);
            return converted;
        }

        /// <summary>
        /// Converts a boolean expression to its rendered form.
        /// </summary>
        /// <param name="e">The expression to convert.</param>
        public static string Convert(Expression<Func<bool>> e)
        {
            var visitor = new Visitor();
            visitor.Visit(e.Body);
            return visitor.Result;
        }

        /// <summary>
        /// Converts a class expression to a JSON token representation.
        /// </summary>
        /// <param name="e">The expression to convert.</param>
        /// <typeparam name="T">The class type.</typeparam>
        public static JToken ConvertO<T>(Expression<Func<T>> e)
        {
            var converter = new ComplexObjectConverter();
            return e.Body.Visit(converter, null);
        }

        /// <summary>
        /// Converts an expression to an object by processing member assignments and compiling the result.
        /// </summary>
        /// <param name="e">The expression to convert.</param>
        /// <typeparam name="TResult">The result type.</typeparam>
        public static TResult ConvertObject<TResult>(Expression<Func<TResult>> e)
        {
            var objConvert = new ObjectExpressionConverter();
            var converted = objConvert.Visit(e.Body);

            var newLambda = Expression.Lambda<Func<TResult>>(converted, e.Parameters);
            var compiled = newLambda.Compile();
            return compiled();
        }

        /// <summary>
        /// Expression visitor for converting object member assignments.
        /// </summary>
        class ObjectExpressionConverter : ExpressionVisitor
        {
            /// <summary>
            /// Visits a member assignment and converts string properties using logic converter.
            /// </summary>
            /// <param name="node">The member assignment to visit.</param>
            protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
            {
                var shouldConvert =
                    (node.Member is System.Reflection.PropertyInfo propertyInfo && propertyInfo.PropertyType == typeof(string)) ||
                    (node.Member is System.Reflection.FieldInfo fieldInfo && fieldInfo.FieldType == typeof(string));

                if (shouldConvert)
                {
                    var logicConverter = new LogicConverter();
                    var newExpression = node.Expression.Visit(logicConverter, null);
                    return Expression.Bind(
                        node.Member,
                        Expression.Constant(newExpression.Render(), typeof(string))
                    );
                }
                return base.VisitMemberAssignment(node);
            }
        }

        /// <summary>
        /// Expression visitor for evaluating simple expressions and concatenating results.
        /// </summary>
        class Visitor : ExpressionVisitor
        {
            /// <summary>
            /// Gets the result of the expression visitation.
            /// </summary>
            public string Result { get; private set; }

            /// <summary>
            /// Visits a binary expression and concatenates left and right operands.
            /// </summary>
            /// <param name="node">The binary expression to visit.</param>
            protected override Expression VisitBinary(BinaryExpression node)
            {
                Visit(node.Left);
                var left = Result;
                Visit(node.Right);
                var right = Result;

                Result = left + right;
                return node;
            }

            /// <summary>
            /// Visits a constant expression and stores its value.
            /// </summary>
            /// <param name="node">The constant expression to visit.</param>
            protected override Expression VisitConstant(ConstantExpression node)
            {
                Result = node.Value?.ToString();
                return node;
            }

            /// <summary>
            /// Visits a parameter expression.
            /// </summary>
            /// <param name="node">The parameter expression to visit.</param>
            protected override Expression VisitParameter(ParameterExpression node)
            {
                throw new NotSupportedException("ParameterExpression not supported in this context.");
            }

            /// <summary>
            /// Visits a member expression.
            /// </summary>
            /// <param name="node">The member expression to visit.</param>
            protected override Expression VisitMember(MemberExpression node)
            {
                throw new NotSupportedException("MemberExpression not supported in this context.");
            }

            /// <summary>
            /// Visits any expression type.
            /// </summary>
            /// <param name="node">The expression to visit.</param>
            public override Expression Visit(Expression node)
            {
                return base.Visit(node);
            }
        }
    }
}
