//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using Newtonsoft.Json.Linq;
    using System.Collections.Generic;
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
        /// Visits a binary expression supported by the template converter.
        /// </summary>
        /// <param name="e">The binary expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override JToken Visit(BinaryExpression e, object p)
        {
            var node = e.Visit(new LogicConverter(), null);
            return new JValue(node.Render());
        }

        /// <summary>
        /// Visits a constant expression.
        /// </summary>
        /// <param name="e">The constant expression to visit.</param>
        /// <param name="p">Additional parameter (not used).</param>
        public override JToken Visit(ConstantExpression e, object p)
        {
            if (e.Value == null)
            {
                return JValue.CreateNull();
            }
            if (e.Type == typeof(string))
            {
                return new JValue((string)e.Value);
            }
            if (e.Type == typeof(bool))
            {
                return new JValue((bool)e.Value);
            }
            if (e.Type == typeof(int))
            {
                return new JValue((int)e.Value);
            }
            if (e.Type == typeof(long))
            {
                return new JValue((long)e.Value);
            }
            if (e.Type == typeof(double))
            {
                return new JValue((double)e.Value);
            }
            if (e.Type == typeof(float))
            {
                return new JValue((float)e.Value);
            }
            if (e.Type == typeof(decimal))
            {
                return new JValue((decimal)e.Value);
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

            if (e.Arguments.Count == 0)
            {
                var defaultValues = GetDefaultValues(
                    type: e.Type,
                    boundMemberNames: new HashSet<string>());
                if (defaultValues.HasValues)
                {
                    return defaultValues;
                }
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
        /// Visits a new array initialization expression, converting each element to a JArray.
        /// </summary>
        /// <param name="e">The new array expression to visit.</param>
        /// <param name="p">Additional parameter passed to nested visits.</param>
        public override JToken Visit(NewArrayExpression e, object p)
        {
            var array = new JArray();
            foreach (var expr in e.Expressions)
            {
                array.Add(expr.Visit(this, p));
            }
            return array;
        }

        /// <summary>
        /// Visits a member initialization expression, converting property assignments to a JObject.
        /// </summary>
        /// <param name="e">The member initialization expression to visit.</param>
        /// <param name="p">Additional parameter passed to nested visits.</param>
        public override JToken Visit(MemberInitExpression e, object p)
        {
            var result = new JObject();
            var boundMemberNames = new HashSet<string>();
            foreach (var binding in e.Bindings.OfType<MemberAssignment>())
            {
                var name = GetPropertyName(binding.Member);
                result[name] = binding.Expression.Visit(this, p);
                boundMemberNames.Add(binding.Member.Name);
            }

            result.Merge(
                GetDefaultValues(
                    type: e.Type,
                    boundMemberNames: boundMemberNames));
            return result;
        }

        /// <summary>
        /// Gets generated defaults for properties not explicitly bound by an expression.
        /// </summary>
        /// <param name="type">The generated input type.</param>
        /// <param name="boundMemberNames">The explicitly bound CLR member names.</param>
        private static JObject GetDefaultValues(
            Type type,
            HashSet<string> boundMemberNames)
        {
            var result = new JObject();
            foreach (var property in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (boundMemberNames.Contains(property.Name))
                {
                    continue;
                }

                var defaultValueAttribute = property.GetCustomAttribute<DefaultValueAttribute>();
                if (defaultValueAttribute != null)
                {
                    result[GetPropertyName(property)] = ConvertDefaultValue(
                        defaultValueAttribute.Value,
                        property.PropertyType);
                }
            }

            return result;
        }

        /// <summary>
        /// Converts a property default to its workflow JSON representation.
        /// </summary>
        /// <param name="value">The default value.</param>
        /// <param name="propertyType">The property type.</param>
        private static JToken ConvertDefaultValue(object value, Type propertyType)
        {
            if (value == null)
            {
                return JValue.CreateNull();
            }

            var underlyingType = Nullable.GetUnderlyingType(propertyType) ?? propertyType;
            if (underlyingType.IsEnum)
            {
                var enumName = Enum.GetName(underlyingType, value);
                var member = underlyingType.GetMember(enumName).FirstOrDefault();
                var enumMemberAttribute = member?.GetCustomAttribute<System.Runtime.Serialization.EnumMemberAttribute>();
                return new JValue(enumMemberAttribute?.Value ?? enumName);
            }

            if (typeof(JToken).IsAssignableFrom(underlyingType) &&
                value is string json)
            {
                return JToken.Parse(json);
            }

            return JToken.FromObject(value);
        }

        /// <summary>
        /// Gets the property name from a member, checking for JsonProperty attribute.
        /// </summary>
        /// <param name="member">The member to get the name from.</param>
        private static string GetPropertyName(MemberInfo member)
        {
            var name = member.Name;
            var jsonPropAttr = member.GetCustomAttribute(typeof(Newtonsoft.Json.JsonPropertyAttribute));
            if (jsonPropAttr != null)
            {
                var propName = (string)jsonPropAttr.GetType().GetProperty("PropertyName")?.GetValue(jsonPropAttr);
                if (!string.IsNullOrEmpty(propName))
                    name = propName;
            }
            return name;
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
