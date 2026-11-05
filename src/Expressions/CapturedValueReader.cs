// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    internal static class CapturedValueReader
    {
        internal static bool TryRead(Expression expression, out object value)
        {
            value = null;
            if (expression is ConstantExpression constant)
            {
                value = constant.Value;
                return true;
            }

            if (expression is MemberExpression member && member.Member is FieldInfo field &&
                (field.IsLiteral || member.Expression != null && TryRead(member.Expression, out value)))
            {
                value = field.IsLiteral ? field.GetRawConstantValue() : field.GetValue(value);
                if (field.FieldType.IsEnum && value is not Enum)
                    value = Enum.ToObject(field.FieldType, value);
                return true;
            }

            if (expression is MemberExpression propertyMember &&
                propertyMember.Member is PropertyInfo property &&
                propertyMember.Expression != null &&
                TryRead(propertyMember.Expression, out var instance) &&
                instance != null)
            {
                var effectiveProperty = ResolveEffectiveProperty(property, instance.GetType());
                if (effectiveProperty.GetMethod?.IsDefined(
                    typeof(CompilerGeneratedAttribute),
                    inherit: false) != true)
                {
                    return false;
                }

                var backingField = effectiveProperty.DeclaringType.GetField(
                    "<" + effectiveProperty.Name + ">k__BackingField",
                    BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
                if (backingField?.IsDefined(typeof(CompilerGeneratedAttribute), inherit: false) == true)
                {
                    value = backingField.GetValue(instance);
                    return true;
                }
            }

            value = null;
            return false;
        }

        private static PropertyInfo ResolveEffectiveProperty(PropertyInfo property, Type runtimeType)
        {
            var getter = property.GetMethod;
            if (getter == null || !getter.IsVirtual || getter.IsFinal)
                return property;

            var baseDefinition = getter.GetBaseDefinition();
            for (var type = runtimeType; type != null; type = type.BaseType)
            {
                var effectiveProperty = type
                    .GetProperties(
                        BindingFlags.Instance |
                        BindingFlags.Public |
                        BindingFlags.NonPublic |
                        BindingFlags.DeclaredOnly)
                    .FirstOrDefault(candidate =>
                        candidate.GetMethod?.GetBaseDefinition() == baseDefinition);
                if (effectiveProperty != null)
                    return effectiveProperty;
            }

            return property;
        }
    }
}
