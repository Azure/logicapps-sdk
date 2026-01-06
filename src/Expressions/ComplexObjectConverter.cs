//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts complex object expression trees to JSON tokens.
    /// </summary>
    internal class ComplexObjectConverter : VisitorBase<JToken, object>
    {
        /// <summary>
        /// Determines whether the specified type is a compiler-generated anonymous type.
        /// </summary>
        /// <param name="type">The type to inspect.</param>
        public static bool IsAnonymousType(Type type)
        {
            if (type == null) return false;

            var hasCompilerGeneratedAttribute = Attribute.IsDefined(type, typeof(CompilerGeneratedAttribute), false);
            var nameContainsAnonymousType = type.Name.Contains("AnonymousType");
            var isSealed = type.IsSealed;
            var isClass = type.IsClass;
            var isNotPublic = !type.IsPublic;

            return isClass && isSealed && isNotPublic && hasCompilerGeneratedAttribute && nameContainsAnonymousType;
        }

        /// <summary>
        /// Visits a list initialization expression.
        /// </summary>
        /// <param name="expr">The list initialization expression to visit.</param>
        /// <param name="param">Additional parameter (not used).</param>
        public override JToken Visit(ListInitExpression expr, object param)
        {
            expr.NewExpression.Visit(this, param);

            return base.Visit(expr, param);
        }

        /// <summary>
        /// Visits a binary expression, with special handling for string concatenation.
        /// </summary>
        /// <param name="expr">The binary expression to visit.</param>
        /// <param name="param">Additional parameter (not used).</param>
        public override JToken Visit(BinaryExpression expr, object param)
        {
            var concat2 = typeof(string).GetMethod("Concat", [typeof(string), typeof(string)]);

            if (expr.Method == concat2)
            {
                var conv = new LogicConverter();
                var node = expr.Visit(conv, null);
                return new JValue(node.Render());
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Visits a constant expression.
        /// </summary>
        /// <param name="expr">The constant expression to visit.</param>
        /// <param name="param">Additional parameter (not used).</param>
        public override JToken Visit(ConstantExpression expr, object param)
        {
            if (expr.Type == typeof(string))
            {
                return new JValue((string)expr.Value);
            }

            throw new NotImplementedException($"ConstantExpression {expr.Type} / {expr.Value}");
        }

        /// <summary>
        /// Visits a new expression, with special handling for anonymous types.
        /// </summary>
        /// <param name="expr">The new expression to visit.</param>
        /// <param name="param">Additional parameter passed to nested visits.</param>
        public override JToken Visit(NewExpression expr, object param)
        {
            if (IsAnonymousType(expr.Type))
            {
                var props = expr.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                if (expr.Arguments.Count != props.Length)
                {
                    throw new FormatException();
                }

                var result = new JObject();

                for (var i = 0; i < props.Length; i++)
                {
                    var arg = expr.Arguments[i];
                    var prop = props[i];

                    result[prop.Name] = arg.Visit(this, param);
                }

                return result;
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Visits a member expression (property or field access).
        /// </summary>
        /// <param name="expr">The member expression to visit.</param>
        /// <param name="param">Additional parameter (not used).</param>
        public override JToken Visit(MemberExpression expr, object param)
        {
            var conv = new LogicConverter();
            var node = e.Visit(conv, null);

            return new JValue(node.Render());
        }

        /// <summary>
        /// Visits a method call expression, with special handling for string formatting.
        /// </summary>
        /// <param name="expr">The method call expression to visit.</param>
        /// <param name="param">Additional parameter (not used).</param>
        public override JToken Visit(MethodCallExpression expr, object param)
        {
            var method = expr.Method;
            if (method.DeclaringType == typeof(string) && method.Name == "Format")
            {
                var conv = new LogicConverter();
                var node = expr.Visit(conv, null);

                return new JValue(node.Render());
            }
            throw new NotImplementedException();
        }

        /// <summary>
        /// Default visit method for unsupported expression types.
        /// </summary>
        /// <param name="expr">The expression that cannot be visited.</param>
        /// <param name="param">Additional parameter (not used).</param>
        public override JToken Visit(Expression expr, object param)
        {
            throw new NotImplementedException();
        }
    }
}
