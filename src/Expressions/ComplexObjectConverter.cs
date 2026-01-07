//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using Newtonsoft.Json.Linq;
    using System.ComponentModel;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;

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
        /// <param name="e">The list initialization expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override JToken Visit(ListInitExpression e, object p)
        {
            e.NewExpression.Visit(this, p);
            foreach (var init in e.Initializers)
            {
            }
            return base.Visit(e, p);
        }

        /// <summary>
        /// Visits a binary expression, with special handling for string concatenation.
        /// </summary>
        /// <param name="e">The binary expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override JToken Visit(BinaryExpression e, object p)
        {
            var concat2 = typeof(string).GetMethod("Concat", [typeof(string), typeof(string)]);

            if (e.Method == concat2)
            {
                var conv = new LogicConverter();
                var node = e.Visit(conv, null);
                return new JValue(node.Render());
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Visits a constant expression.
        /// </summary>
        /// <param name="e">The constant expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override JToken Visit(ConstantExpression e, object p)
        {
            if (e.Type == typeof(string))
            {
                return new JValue((string)e.Value);
            }
            if (e.Type == typeof(bool))
            {
                return new JValue((bool)e.Value);
            }
            if (e.Type.IsEnum)
            {
                var enumValue = e.Value;
                var enumType = e.Type;
                var enumName = Enum.GetName(enumType, enumValue);
                var member = enumType.GetMember(enumName).FirstOrDefault();
                var enumMemberAttr = member?.GetCustomAttribute<System.Runtime.Serialization.EnumMemberAttribute>();
                var value = enumMemberAttr?.Value ?? enumName;
                return new JValue(value);
            }
            throw new NotImplementedException($"ConstantExpression {e.Type} / {e.Value}");
        }

        /// <summary>
        /// Visits a new expression, with special handling for anonymous types.
        /// </summary>
        /// <param name="e">The new expression to visit.</param>
        /// <param name="p">Additional parameter passed to nested visits.</param>
        public override JToken Visit(NewExpression e, object p)
        {
            if (IsAnonymousType(e.Type))
            {
                var props = e.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                if (e.Arguments.Count != props.Length)
                {
                    throw new FormatException();
                }

                var result = new JObject();

                for (var i = 0; i < props.Length; i++)
                {
                    var arg = e.Arguments[i];
                    var prop = props[i];

                    result[prop.Name] = arg.Visit(this, p);
                }
                return result;
            }

            throw new NotImplementedException();
        }

        /// <summary>
        /// Visits a member expression (property or field access).
        /// </summary>
        /// <param name="e">The member expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override JToken Visit(MemberExpression e, object p)
        {
            var conv = new LogicConverter();
            var node = e.Visit(conv, null);
            return new JValue(node.Render());
        }

        /// <summary>
        /// Visits a method call expression.
        /// </summary>
        /// <param name="e">The method call expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override JToken Visit(MethodCallExpression e, object p)
        {
            var conv = new LogicConverter();
            var node = e.Visit(conv, null);
            return new JValue(node.Render());
        }

        /// <summary>
        /// Visits a unary expression.
        /// </summary>
        /// <param name="e">The unary expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override JToken Visit(UnaryExpression e, object p)
        {
            var conv = new LogicConverter();
            var node = e.Visit(conv, null);
            return new JValue(node.Render());
        }

        /// <summary>
        /// Visits a conditional expression.
        /// </summary>
        /// <param name="e">The conditional expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override JToken Visit(ConditionalExpression e, object p)
        {
            var conv = new LogicConverter();
            var node = e.Visit(conv, null);
            return new JValue(node.Render());
        }

        /// <summary>
        /// Default visit method for unsupported expression types.
        /// </summary>
        /// <param name="e">The expression that cannot be visited.</param>
        /// <param name="_">Additional parameter (not used).</param>
        public override JToken Visit(Expression e, object _)
        {
            throw new NotImplementedException();
        }
    }
}
