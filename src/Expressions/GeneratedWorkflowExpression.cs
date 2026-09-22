// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Holds expression source generated for a workflow factory invocation.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public sealed class GeneratedWorkflowExpression
    {
        private GeneratedWorkflowExpression(
            string csharpSource,
            string inlineTemplateSource,
            object literalValue,
            bool isLiteral,
            string[] workflowOperationIds,
            string[] capturedValueNames)
        {
            this.CSharpSource = csharpSource;
            this.InlineTemplateSource = inlineTemplateSource;
            this.LiteralValue = literalValue;
            this.IsLiteral = isLiteral;
            this.WorkflowOperationIds = workflowOperationIds ?? Array.Empty<string>();
            this.CapturedValueNames = capturedValueNames ?? Array.Empty<string>();
        }

        internal string CSharpSource { get; }

        internal string InlineTemplateSource { get; }

        internal object LiteralValue { get; }

        internal bool IsLiteral { get; }

        internal string[] WorkflowOperationIds { get; }

        internal string[] CapturedValueNames { get; }

        private Delegate BoundExpression { get; set; }

        public static GeneratedWorkflowExpression FromCSharp(
            string source,
            string inlineTemplateSource,
            string[] workflowOperationIds,
            string[] capturedValueNames) =>
            new GeneratedWorkflowExpression(
                source ?? throw new ArgumentNullException(nameof(source)),
                inlineTemplateSource,
                literalValue: null,
                isLiteral: false,
                workflowOperationIds,
                capturedValueNames);

        public static GeneratedWorkflowExpression FromLiteral(object value) =>
            new GeneratedWorkflowExpression(
                csharpSource: null,
                inlineTemplateSource: null,
                literalValue: value,
                isLiteral: true,
                workflowOperationIds: null,
                capturedValueNames: null);

        internal JToken ToWorkflowToken()
        {
            if (this.IsLiteral)
                return this.LiteralValue == null ? JValue.CreateNull() : JToken.FromObject(this.LiteralValue);

            return new JValue($"#{{{this.ToCSharpSource()}}}");
        }

        internal string ToCSharpSource()
        {
            if (this.IsLiteral)
            {
                var token = this.ToWorkflowToken();
                return token.ToString(Newtonsoft.Json.Formatting.None);
            }

            var source = this.CSharpSource;
            foreach (var operationId in this.WorkflowOperationIds)
            {
                source = source.Replace(
                    GeneratedWorkflowOperationRegistry.GetMarker(operationId),
                    EscapeCSharpString(GeneratedWorkflowOperationRegistry.GetRequiredName(operationId)));
            }

            foreach (var capturedValueName in this.CapturedValueNames)
            {
                source = source.Replace(
                    GetCaptureMarker(capturedValueName),
                    RenderCSharpValue(GetRequiredCapturedValue(capturedValueName)));
            }

            return source;
        }

        internal string ToInlineTemplate()
        {
            if (this.IsLiteral)
            {
                var token = this.ToWorkflowToken();
                return token.Type == JTokenType.String
                    ? $"'{EscapeTemplateString(token.Value<string>())}'"
                    : token.ToString(Newtonsoft.Json.Formatting.None).ToLowerInvariant();
            }

            if (string.IsNullOrEmpty(this.InlineTemplateSource))
            {
                throw new NotSupportedException(
                    "This C# expression cannot be embedded in a connector path or other inline template string.");
            }

            var source = this.InlineTemplateSource;
            foreach (var operationId in this.WorkflowOperationIds)
            {
                source = source.Replace(
                    GeneratedWorkflowOperationRegistry.GetMarker(operationId),
                    EscapeTemplateString(GeneratedWorkflowOperationRegistry.GetRequiredName(operationId)));
            }

            foreach (var capturedValueName in this.CapturedValueNames)
            {
                source = source.Replace(
                    GetCaptureMarker(capturedValueName),
                    RenderTemplateValue(GetRequiredCapturedValue(capturedValueName)));
            }

            return source;
        }

        internal void Bind(Delegate expression)
        {
            this.BoundExpression = expression;
        }

        private static string EscapeCSharpString(string value) =>
            value.Replace("\\", "\\\\").Replace("\"", "\\\"");

        private static string EscapeTemplateString(string value) =>
            value.Replace("'", "''");

        private object GetRequiredCapturedValue(string capturedValueName)
        {
            if (this.BoundExpression?.Target != null &&
                TryFindCapturedValue(
                    this.BoundExpression.Target,
                    capturedValueName,
                    new HashSet<object>(ReferenceComparer.Instance),
                    out var value))
            {
                return value;
            }

            throw new InvalidOperationException(
                $"Captured workflow expression value '{capturedValueName}' could not be resolved.");
        }

        private static bool TryFindCapturedValue(
            object target,
            string name,
            HashSet<object> visited,
            out object value)
        {
            if (target == null || !visited.Add(target))
            {
                value = null;
                return false;
            }

            var fields = target.GetType().GetFields(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var field in fields)
            {
                if (field.Name == name || field.Name.StartsWith($"<{name}>", StringComparison.Ordinal))
                {
                    value = field.GetValue(target);
                    return true;
                }
            }

            foreach (var field in fields)
            {
                var nested = field.GetValue(target);
                if (nested != null &&
                    field.FieldType.GetCustomAttribute<CompilerGeneratedAttribute>() != null &&
                    TryFindCapturedValue(nested, name, visited, out value))
                {
                    return true;
                }
            }

            value = null;
            return false;
        }

        private static string RenderCSharpValue(object value)
        {
            if (value == null)
                return "null";
            if (value is string text)
                return $"\"{EscapeCSharpString(text)}\"";
            if (value is char character)
                return $"'{character}'";
            if (value is bool boolean)
                return boolean ? "true" : "false";
            if (value is float single)
                return single.ToString("R", CultureInfo.InvariantCulture) + "f";
            if (value is double number)
                return number.ToString("R", CultureInfo.InvariantCulture);
            if (value is decimal decimalNumber)
                return decimalNumber.ToString(CultureInfo.InvariantCulture) + "m";
            if (value is long longNumber)
                return longNumber.ToString(CultureInfo.InvariantCulture) + "L";
            if (value is ulong unsignedLong)
                return unsignedLong.ToString(CultureInfo.InvariantCulture) + "UL";
            if (value is uint unsignedInteger)
                return unsignedInteger.ToString(CultureInfo.InvariantCulture) + "U";
            if (value is byte or sbyte or short or ushort or int)
                return Convert.ToString(value, CultureInfo.InvariantCulture);
            if (value is Enum enumValue)
                return $"\"{EscapeCSharpString(GetEnumWireValue(enumValue))}\"";
            if (value is Uri uri)
                return $"new Uri(\"{EscapeCSharpString(uri.ToString())}\")";
            if (value is Guid guid)
                return $"Guid.Parse(\"{guid}\")";
            if (value is DateTime dateTime)
                return $"DateTime.Parse(\"{dateTime.ToString("o", CultureInfo.InvariantCulture)}\")";

            throw new NotSupportedException(
                $"Captured value type '{value.GetType().FullName}' is not supported in workflow C# expressions.");
        }

        private static string RenderTemplateValue(object value)
        {
            if (value == null)
                return "null";
            if (value is string text)
                return $"'{EscapeTemplateString(text)}'";
            if (value is char character)
                return $"'{EscapeTemplateString(character.ToString())}'";
            if (value is bool boolean)
                return boolean ? "true" : "false";
            if (value is Enum enumValue)
                return $"'{EscapeTemplateString(GetEnumWireValue(enumValue))}'";
            if (value is Uri uri)
                return $"'{EscapeTemplateString(uri.ToString())}'";
            if (value is byte or sbyte or short or ushort or int or uint or long or ulong or float or double or decimal)
                return Convert.ToString(value, CultureInfo.InvariantCulture);

            throw new NotSupportedException(
                $"Captured value type '{value.GetType().FullName}' cannot be embedded in an inline workflow expression.");
        }

        private static string GetEnumWireValue(Enum value)
        {
            var member = value.GetType().GetMember(value.ToString())[0];
            return member.GetCustomAttribute<EnumMemberAttribute>()?.Value ?? value.ToString();
        }

        private static string GetCaptureMarker(string capturedValueName) =>
            $"__logicapps_capture_{capturedValueName}__";

        private sealed class ReferenceComparer : IEqualityComparer<object>
        {
            public static ReferenceComparer Instance { get; } = new ReferenceComparer();

            bool IEqualityComparer<object>.Equals(object x, object y) => ReferenceEquals(x, y);

            int IEqualityComparer<object>.GetHashCode(object obj) => RuntimeHelpers.GetHashCode(obj);
        }
    }

    /// <summary>
    /// Associates intercepted delegates with their generated workflow expressions.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class GeneratedWorkflowExpressionRegistry
    {
        private static readonly ConditionalWeakTable<Delegate, GeneratedWorkflowExpression> Expressions =
            new ConditionalWeakTable<Delegate, GeneratedWorkflowExpression>();

        public static void Register(Delegate expression, GeneratedWorkflowExpression generatedExpression)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression));
            if (generatedExpression == null)
                throw new ArgumentNullException(nameof(generatedExpression));

            Expressions.Remove(expression);
            generatedExpression.Bind(expression);
            Expressions.Add(expression, generatedExpression);
        }

        internal static GeneratedWorkflowExpression GetRequired(Delegate expression)
        {
            if (expression != null && Expressions.TryGetValue(expression, out var generatedExpression))
                return generatedExpression;

            throw new InvalidOperationException(
                "The workflow expression was not processed by the Microsoft.Azure.Workflows.Sdk source generator. " +
                "Build the workflow project with a compatible .NET 9.0.2xx or newer SDK.");
        }
    }

    /// <summary>
    /// Associates generated operation IDs with workflow operation instances.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class GeneratedWorkflowOperationRegistry
    {
        private const string MarkerPrefix = "__logicapps_operation_";
        private const string MarkerSuffix = "__";
        private static readonly ConcurrentDictionary<string, WeakReference<IWorkflowOperation>> Operations =
            new ConcurrentDictionary<string, WeakReference<IWorkflowOperation>>();

        public static void Register(string operationId, IWorkflowOperation operation)
        {
            if (string.IsNullOrEmpty(operationId))
                throw new ArgumentException("An operation ID is required.", nameof(operationId));
            if (operation == null)
                throw new ArgumentNullException(nameof(operation));

            Operations[operationId] = new WeakReference<IWorkflowOperation>(operation);
        }

        internal static string GetMarker(string operationId) =>
            $"{MarkerPrefix}{operationId}{MarkerSuffix}";

        internal static string GetRequiredName(string operationId)
        {
            if (Operations.TryGetValue(operationId, out var operationReference) &&
                operationReference.TryGetTarget(out var operation) &&
                !string.IsNullOrEmpty(operation.Name))
            {
                return operation.Name;
            }

            throw new InvalidOperationException(
                $"Workflow operation '{operationId}' was not registered by the Logic Apps SDK source generator.");
        }
    }
}
