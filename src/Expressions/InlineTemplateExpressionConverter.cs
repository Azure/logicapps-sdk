// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Globalization;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Renders the limited template-language subset required for expressions embedded in strings.
    /// </summary>
    internal sealed class InlineTemplateExpressionConverter
    {
        private readonly struct VisitResult
        {
            public VisitResult(string text, bool isWorkflowData = false, bool isAgentParameters = false)
            {
                this.Text = text;
                this.IsWorkflowData = isWorkflowData;
                this.IsAgentParameters = isAgentParameters;
            }

            public string Text { get; }

            public bool IsWorkflowData { get; }

            public bool IsAgentParameters { get; }
        }

        public string Convert(Expression expression) => Visit(expression).Text;

        private VisitResult Visit(Expression expression)
        {
            expression = StripConvert(expression);

            if (ExpressionConverter.TryConvertLiteral(expression, out var literal))
                return new VisitResult(RenderLiteral(literal));

            return expression switch
            {
                BinaryExpression binary => VisitBinary(binary),
                ConditionalExpression conditional => VisitConditional(conditional),
                MemberExpression member => VisitMember(member),
                MethodCallExpression method => VisitMethod(method),
                UnaryExpression unary when unary.NodeType == ExpressionType.Not =>
                    new VisitResult($"not({Visit(unary.Operand).Text})"),
                _ => throw new NotSupportedException(
                    $"Expression '{expression}' cannot be embedded in a workflow string. Use a complete C# expression value instead."),
            };
        }

        private VisitResult VisitMember(MemberExpression expression)
        {
            if (TryExtractClosureValue(expression) is ForEachItemToken)
                return new VisitResult("item()", isWorkflowData: true);

            var closureValue = TryExtractClosureValue(expression.Expression);

            if (closureValue is IWorkflowAction action)
            {
                if (expression.Member.Name == "Body" &&
                    ImplementsGenericInterface(closureValue.GetType(), typeof(IBodyWorkflowAction<>)))
                {
                    return new VisitResult($"body('{EscapeString(action.Name)}')", isWorkflowData: true);
                }

                if (expression.Member.Name == "Output" &&
                    ImplementsGenericInterface(closureValue.GetType(), typeof(IOutputWorkflowAction<>)))
                {
                    return new VisitResult($"outputs('{EscapeString(action.Name)}')", isWorkflowData: true);
                }
            }

            if (closureValue != null &&
                expression.Member.Name == "TriggerBody" &&
                ImplementsGenericInterface(closureValue.GetType(), typeof(IBodyWorkflowTrigger<>)))
            {
                return new VisitResult("triggerBody()", isWorkflowData: true);
            }

            if (closureValue != null &&
                expression.Member.Name == "TriggerOutput" &&
                ImplementsGenericInterface(closureValue.GetType(), typeof(IOutputWorkflowTrigger<>)))
            {
                return new VisitResult("triggerOutputs()", isWorkflowData: true);
            }

            if (closureValue is IVariableWorkflowAction variable &&
                expression.Member.Name == "Value")
            {
                return new VisitResult(
                    $"variables('{EscapeString(variable.VariableName)}')",
                    isWorkflowData: true);
            }

            if (closureValue != null &&
                expression.Member.Name == "Parameters" &&
                ImplementsGenericInterface(closureValue.GetType(), typeof(IAgentToolContext<>)))
            {
                return new VisitResult("agentparameters()", isAgentParameters: true);
            }

            var target = Visit(expression.Expression);
            var propertyName = GetPropertyName(expression.Member);
            if (target.IsAgentParameters)
                return new VisitResult($"agentparameters('{EscapeString(propertyName)}')", isWorkflowData: true);

            if (target.IsWorkflowData)
            {
                return new VisitResult(
                    $"{target.Text}?['{EscapeString(propertyName)}']",
                    isWorkflowData: true);
            }

            throw new NotSupportedException(
                $"Member access '{expression}' cannot be represented as an inline template expression.");
        }

        private VisitResult VisitMethod(MethodCallExpression expression)
        {
            if (expression.Method.DeclaringType == typeof(WorkflowFunctions))
            {
                var arguments = expression.Arguments.Select(argument => Visit(argument).Text);
                return new VisitResult(
                    $"{WorkflowFunctions.GetExpressionFunctionName(expression.Method.Name)}({string.Join(", ", arguments)})",
                    isWorkflowData: true);
            }

            if (expression.Method.IsGenericMethod &&
                (expression.Method.Name == "ToObject" || expression.Method.Name == "Value") &&
                ((expression.Object != null && typeof(JToken).IsAssignableFrom(StripConvert(expression.Object).Type)) ||
                 (expression.Object == null &&
                  expression.Arguments.Count > 0 &&
                  typeof(JToken).IsAssignableFrom(StripConvert(expression.Arguments[0]).Type))))
            {
                var tokenExpression = expression.Object ?? expression.Arguments[0];
                return Visit(tokenExpression);
            }

            if (expression.Method.Name == "get_Item" && expression.Object != null)
            {
                var target = Visit(expression.Object);
                var index = Visit(expression.Arguments[0]).Text;
                return new VisitResult($"{target.Text}[{index}]", target.IsWorkflowData);
            }

            if (expression.Method.DeclaringType == typeof(string) &&
                expression.Method.Name == "Concat")
            {
                var arguments = expression.Arguments.Count == 1 &&
                    StripConvert(expression.Arguments[0]) is NewArrayExpression array
                    ? array.Expressions
                    : expression.Arguments;
                return new VisitResult(
                    $"concat({string.Join(", ", arguments.Select(argument => Visit(argument).Text))})");
            }

            if (expression.Method.Name == "ToString" &&
                expression.Object != null &&
                expression.Arguments.Count == 0)
            {
                return new VisitResult($"string({Visit(expression.Object).Text})");
            }

            throw new NotSupportedException(
                $"Method '{expression.Method.Name}' cannot be represented as an inline template expression.");
        }

        private VisitResult VisitConditional(ConditionalExpression expression)
        {
            return new VisitResult(
                $"if({Visit(expression.Test).Text}, {Visit(expression.IfTrue).Text}, {Visit(expression.IfFalse).Text})");
        }

        private VisitResult VisitBinary(BinaryExpression expression)
        {
            var left = Visit(expression.Left);
            var right = Visit(expression.Right);

            if (expression.NodeType == ExpressionType.ArrayIndex)
                return new VisitResult($"{left.Text}[{right.Text}]", left.IsWorkflowData);

            var function = expression.NodeType switch
            {
                ExpressionType.Add when expression.Type == typeof(string) => "concat",
                ExpressionType.Add => "add",
                ExpressionType.Subtract => "subtract",
                ExpressionType.Multiply => "multiply",
                ExpressionType.Divide => "divide",
                ExpressionType.Modulo => "mod",
                ExpressionType.Equal => "equals",
                ExpressionType.NotEqual => null,
                ExpressionType.LessThan => "less",
                ExpressionType.LessThanOrEqual => "lessOrEquals",
                ExpressionType.GreaterThan => "greater",
                ExpressionType.GreaterThanOrEqual => "greaterOrEquals",
                ExpressionType.And or ExpressionType.AndAlso => "and",
                ExpressionType.Or or ExpressionType.OrElse => "or",
                _ => throw new NotSupportedException(
                    $"Operator '{expression.NodeType}' cannot be represented as an inline template expression."),
            };

            if (expression.NodeType == ExpressionType.NotEqual)
                return new VisitResult($"not(equals({left.Text}, {right.Text}))");

            return new VisitResult($"{function}({left.Text}, {right.Text})");
        }

        private static string RenderLiteral(JToken literal)
        {
            return literal.Type switch
            {
                JTokenType.Null => "null",
                JTokenType.String => $"'{EscapeString(literal.Value<string>())}'",
                JTokenType.Boolean => literal.Value<bool>() ? "true" : "false",
                JTokenType.Integer or JTokenType.Float =>
                    System.Convert.ToString(((JValue)literal).Value, CultureInfo.InvariantCulture),
                _ => throw new NotSupportedException(
                    $"Literal type '{literal.Type}' cannot be embedded in a template expression."),
            };
        }

        private static object TryExtractClosureValue(Expression expression)
        {
            expression = StripConvert(expression);
            if (expression is MemberExpression member &&
                member.Expression is ConstantExpression constant &&
                IsClosureType(constant.Type))
            {
                return GetMemberValue(member.Member, constant.Value);
            }

            return null;
        }

        private static object GetMemberValue(MemberInfo member, object instance)
        {
            return member switch
            {
                PropertyInfo property => property.GetValue(instance),
                FieldInfo field => field.GetValue(instance),
                _ => null,
            };
        }

        private static string GetPropertyName(MemberInfo member)
        {
            return member.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ?? member.Name;
        }

        private static bool ImplementsGenericInterface(Type type, Type genericInterface)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == genericInterface ||
                type.GetInterfaces().Any(candidate =>
                    candidate.IsGenericType &&
                    candidate.GetGenericTypeDefinition() == genericInterface);
        }

        private static bool IsClosureType(Type type)
        {
            return type != null &&
                type.IsNested &&
                type.GetCustomAttribute<CompilerGeneratedAttribute>() != null;
        }

        private static Expression StripConvert(Expression expression)
        {
            while (expression is UnaryExpression unary &&
                (unary.NodeType == ExpressionType.Convert ||
                 unary.NodeType == ExpressionType.ConvertChecked ||
                 unary.NodeType == ExpressionType.Quote))
            {
                expression = unary.Operand;
            }

            return expression;
        }

        private static string EscapeString(string value) =>
            value.Replace("'", "''");
    }
}
