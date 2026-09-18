// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using Newtonsoft.Json.Linq;

    internal static class CapturedValueResolver
    {
        public static bool TryResolve(Expression expression, out object value, out Type type)
        {
            type = expression?.Type;
            return TryResolve(expression, out value);
        }

        private static bool TryResolve(Expression expression, out object value)
        {
            switch (expression)
            {
                case ConstantExpression constant when IsClosureType(constant.Type):
                    value = constant.Value;
                    return true;

                case UnaryExpression unary when
                    unary.Method == null &&
                    (unary.NodeType == ExpressionType.Convert ||
                     unary.NodeType == ExpressionType.ConvertChecked):
                    return TryResolve(unary.Operand, out value);

                case MemberExpression member when member.Expression != null:
                    if (!TryResolve(member.Expression, out var target))
                    {
                        break;
                    }

                    if (IsWorkflowBoundary(target) ||
                        IsRuntimeValueBoundary(target))
                    {
                        break;
                    }

                    value = ReadMember(member.Member, target);
                    return true;
            }

            value = null;
            return false;
        }

        private static object ReadMember(MemberInfo member, object target)
        {
            if (target == null)
            {
                throw new NotSupportedException(
                    $"Captured member '{member.Name}' cannot be read from a null value.");
            }

            if (member is FieldInfo field)
            {
                return field.GetValue(target);
            }

            if (member is PropertyInfo property)
            {
                var backingField = property.DeclaringType?
                    .GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .FirstOrDefault(candidate =>
                        candidate.GetCustomAttribute<CompilerGeneratedAttribute>() != null &&
                        (candidate.Name == $"<{property.Name}>k__BackingField" ||
                         candidate.Name == $"<{property.Name}>i__Field"));

                if (backingField != null)
                {
                    return backingField.GetValue(target);
                }

                throw new NotSupportedException(
                    $"Captured property '{property.Name}' must be an auto-property. " +
                    "Custom getters cannot be evaluated while generating a workflow.");
            }

            throw new NotSupportedException(
                $"Captured member type '{member.MemberType}' is not supported.");
        }

        private static bool IsClosureType(Type type)
        {
            if (type == null)
            {
                return false;
            }

            return type.IsNested &&
                   type.GetCustomAttribute<CompilerGeneratedAttribute>() != null &&
                   (type.Name.Contains("<>") ||
                    type.Name.StartsWith("<>c__DisplayClass", StringComparison.Ordinal));
        }

        private static bool IsWorkflowBoundary(object value)
        {
            if (value == null)
            {
                return false;
            }

            var type = value.GetType();
            return value is IWorkflowOperation ||
                   value is ForEachItemToken ||
                   ImplementsGenericInterface(type, typeof(IAgentToolContext<>));
        }

        private static bool IsRuntimeValueBoundary(object value)
        {
            if (value == null)
            {
                return false;
            }

            var type = Nullable.GetUnderlyingType(value.GetType()) ?? value.GetType();
            return type == typeof(string) ||
                   type == typeof(DateTime) ||
                   type == typeof(DateTimeOffset) ||
                   type == typeof(TimeSpan) ||
                   type == typeof(Guid) ||
                   type == typeof(Uri) ||
                   type.IsPrimitive ||
                   type.IsEnum ||
                   type == typeof(decimal) ||
                   typeof(JToken).IsAssignableFrom(type);
        }

        private static bool ImplementsGenericInterface(Type type, Type genericInterfaceType) =>
            type.IsGenericType && type.GetGenericTypeDefinition() == genericInterfaceType ||
            type.GetInterfaces().Any(candidate =>
                candidate.IsGenericType &&
                candidate.GetGenericTypeDefinition() == genericInterfaceType);
    }
}
