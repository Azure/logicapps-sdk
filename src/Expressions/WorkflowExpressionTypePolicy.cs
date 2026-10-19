// Copyright (c) Microsoft Corporation. All rights reserved.

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    internal static class WorkflowExpressionTypePolicy
    {
        private static readonly HashSet<string> SupportedAssemblies = new HashSet<string>(StringComparer.Ordinal)
        {
            "System.Private.CoreLib",
            "mscorlib",
            "System.Runtime",
            "netstandard",
            "System.Linq",
            "System.Collections",
            "System.Net.Http",
            "System.Net.Primitives",
            "System.Private.Uri",
            "System.Runtime.Numerics",
            "Newtonsoft.Json",
            "Microsoft.Azure.Workflows.Sdk"
        };

        internal static void Validate(Type type)
        {
            ValidateSynchronous(type);

            if (!IsRuntimeAvailable(type))
            {
                throw new NotSupportedException(
                    $"Runtime type '{type}' is unavailable. Use framework/SDK types or move custom code into a CustomCode action.");
            }
        }

        internal static void ValidateSynchronous(Type type)
        {
            if (IsTaskLike(type))
            {
                throw new NotSupportedException(
                    "Workflow value expressions must be synchronous and cannot use Task or ValueTask values. Use a CustomCode action for asynchronous work.");
            }

            if (type.IsArray)
            {
                ValidateSynchronous(type.GetElementType());
            }
            else if (type.IsGenericType)
            {
                foreach (var argument in type.GetGenericArguments())
                    ValidateSynchronous(argument);
            }
        }

        internal static bool IsRuntimeAvailable(Type type)
        {
            if (type.IsArray)
                return IsRuntimeAvailable(type.GetElementType());
            if (type.IsGenericParameter)
                return false;

            var assembly = type.Assembly.GetName().Name;
            if (!SupportedAssemblies.Contains(assembly))
                return false;

            return !type.IsGenericType || type.GetGenericArguments().All(IsRuntimeAvailable);
        }

        internal static bool IsAnonymous(Type type) =>
            type.IsDefined(typeof(CompilerGeneratedAttribute), false) &&
            type.Name.Contains("AnonymousType");

        internal static bool ContainsAnonymous(Type type) =>
            IsAnonymous(type) ||
            type.HasElementType && ContainsAnonymous(type.GetElementType()) ||
            type.IsGenericType && type.GetGenericArguments().Any(ContainsAnonymous);

        private static bool IsTaskLike(Type type) =>
            typeof(Task).IsAssignableFrom(type) ||
            type == typeof(ValueTask) ||
            type.IsGenericType && type.GetGenericTypeDefinition() == typeof(ValueTask<>);
    }
}
