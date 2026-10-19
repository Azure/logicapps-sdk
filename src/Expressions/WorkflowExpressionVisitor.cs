// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Expressions
{
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Reconstructs supported LINQ expression-tree nodes as late-bound C# source expressions.
    /// </summary>
    internal sealed class WorkflowExpressionVisitor
    {
        private static bool Implements(Type type, Type definition) =>
            (type.IsGenericType && type.GetGenericTypeDefinition() == definition) ||
            type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == definition);

        private readonly HashSet<ParameterExpression> parameters = new HashSet<ParameterExpression>();

        internal WorkflowExpressionFragment Visit(Expression expression)
        {
            WorkflowExpressionTypePolicy.ValidateSynchronous(expression.Type);

            if (this.TryCustomWorkflowPath(expression, out var customPath))
            {
                return customPath;
            }

            if (this.TryWorkflowTokenSource(expression, out var workflowSource))
            {
                return ReadWorkflowValue(workflowSource, expression.Type);
            }

            if (CapturedValueReader.TryRead(expression, out var value))
            {
                if (value is ForEachItemToken item)
                    return WorkflowExpressionFragment.Binding(WorkflowExpressionBinding.Item(item));

                return CSharpSyntaxGenerator.Literal(value, expression.Type);
            }

            return expression switch
            {
                BinaryExpression node => this.Visit(node),
                UnaryExpression node => this.Visit(node),
                ConstantExpression node => this.Visit(node),
                ParameterExpression node => this.Visit(node),
                MethodCallExpression node => this.Visit(node),
                ConditionalExpression node => this.Visit(node),
                LambdaExpression node => this.Visit(node),
                ListInitExpression node => this.Visit(node),
                MemberExpression node => this.Visit(node),
                MemberInitExpression node => this.Visit(node),
                NewExpression node => this.Visit(node),
                NewArrayExpression node => this.Visit(node),
                TypeBinaryExpression node => this.Visit(node),
                DefaultExpression node => this.Visit(node),
                IndexExpression node => this.Visit(node),
                _ => throw Unsupported(expression),
            };
        }

        private WorkflowExpressionFragment Visit(BinaryExpression binaryExpression)
        {
            if (binaryExpression.NodeType == ExpressionType.ArrayIndex)
                return CSharpSyntaxGenerator.ElementAccess(
                    this.Visit(binaryExpression.Left),
                    new[] { this.Visit(binaryExpression.Right) });
            if (binaryExpression.Conversion != null)
                throw new NotSupportedException("Coalesce conversion lambdas are not supported.");

            return CSharpSyntaxGenerator.Binary(
                this.Visit(binaryExpression.Left),
                CSharpSyntaxGenerator.BinaryOperator(binaryExpression.NodeType),
                this.Visit(binaryExpression.Right),
                isChecked: binaryExpression.NodeType is
                    ExpressionType.AddChecked or
                    ExpressionType.SubtractChecked or
                    ExpressionType.MultiplyChecked);
        }

        private WorkflowExpressionFragment Visit(UnaryExpression unaryExpression)
        {
            if (unaryExpression.NodeType == ExpressionType.Quote) return this.Visit(unaryExpression.Operand);
            var operand = this.Visit(unaryExpression.Operand);
            switch (unaryExpression.NodeType)
            {
                case ExpressionType.ArrayLength:
                    return CSharpSyntaxGenerator.MemberAccess(operand, "Length");
                case ExpressionType.Convert:
                case ExpressionType.ConvertChecked:
                    return CSharpSyntaxGenerator.Cast(
                        unaryExpression.Type,
                        operand,
                        isChecked: unaryExpression.NodeType == ExpressionType.ConvertChecked);
                case ExpressionType.Negate:
                    return CSharpSyntaxGenerator.Unary("-", operand);
                case ExpressionType.NegateChecked:
                    return CSharpSyntaxGenerator.Checked(CSharpSyntaxGenerator.Unary("-", operand));
                case ExpressionType.UnaryPlus:
                    return CSharpSyntaxGenerator.Unary("+", operand);
                case ExpressionType.Not:
                    return CSharpSyntaxGenerator.Unary(
                        unaryExpression.Type == typeof(bool) ||
                        Nullable.GetUnderlyingType(unaryExpression.Type) == typeof(bool)
                            ? "!"
                            : "~",
                        operand);
                case ExpressionType.TypeAs:
                    return CSharpSyntaxGenerator.TypeAs(operand, unaryExpression.Type);
                default: throw new NotSupportedException($"Unsupported C# unary operator: {unaryExpression.NodeType}");
            }
        }

        private WorkflowExpressionFragment Visit(ConstantExpression constantExpression) =>
            CSharpSyntaxGenerator.Literal(constantExpression.Value, constantExpression.Type);

        private WorkflowExpressionFragment Visit(ParameterExpression parameterExpression) =>
            this.parameters.Contains(parameterExpression)
                ? WorkflowExpressionFragment.Text(CSharpSyntaxGenerator.Identifier(parameterExpression.Name))
                : throw Unsupported(parameterExpression);

        private WorkflowExpressionFragment Visit(MethodCallExpression methodCallExpression)
        {
            WorkflowExpressionTypePolicy.Validate(methodCallExpression.Method.DeclaringType);
            if (!methodCallExpression.Method.IsPublic)
                throw new NotSupportedException($"Expression runtime member must be public: {methodCallExpression.Method}");

            if (this.TryResolveWorkflowFunctionTyped(methodCallExpression, out var workflowFunction))
                return workflowFunction;

            if (methodCallExpression.Method.Name == "get_Item" && methodCallExpression.Object != null)
            {
                return CSharpSyntaxGenerator.ElementAccess(
                    this.Visit(methodCallExpression.Object),
                    methodCallExpression.Arguments.Select(this.Visit));
            }

            var target = methodCallExpression.Object == null
                ? CSharpSyntaxGenerator.StaticMemberAccess(
                    methodCallExpression.Method.DeclaringType,
                    methodCallExpression.Method.Name)
                : CSharpSyntaxGenerator.MemberAccess(
                    this.Receiver(methodCallExpression.Object),
                    methodCallExpression.Method.Name);

            if (methodCallExpression.Method.GetParameters().Any(p => p.ParameterType.IsByRef))
                throw new NotSupportedException($"Calls with ref/out arguments are not supported: {methodCallExpression.Method}");
            var parameters = methodCallExpression.Method.GetParameters();
            var overloaded = methodCallExpression.Method.DeclaringType.GetMethods()
                .Count(method => method.Name == methodCallExpression.Method.Name) > 1;
            var arguments = methodCallExpression.Arguments.Select(
                (argument, index) => this.Argument(argument, parameters[index].ParameterType, overloaded));
            return CSharpSyntaxGenerator.Invocation(
                target,
                this.GenericArguments(methodCallExpression.Method),
                arguments);
        }

        private IReadOnlyList<Type> GenericArguments(MethodInfo method)
        {
            if (!method.IsGenericMethod)
                return Array.Empty<Type>();

            var arguments = method.GetGenericArguments();
            var canRender = true;
            foreach (var argument in arguments)
            {
                if (WorkflowExpressionTypePolicy.ContainsAnonymous(argument))
                    canRender = false;
                else
                    WorkflowExpressionTypePolicy.Validate(argument);
            }

            return canRender ? arguments : Array.Empty<Type>();
        }

        private WorkflowExpressionFragment Visit(ConditionalExpression conditionalExpression) =>
            CSharpSyntaxGenerator.Conditional(
                this.Visit(conditionalExpression.Test),
                this.Visit(conditionalExpression.IfTrue),
                this.Visit(conditionalExpression.IfFalse));

        private WorkflowExpressionFragment Visit(LambdaExpression lambdaExpression)
        {
            // NOTE(aeldridge): Lambda parameters must be available to the visitor at child nodes, so they are
            // tracked in this.parameters and removed after visiting the body
            foreach (var parameter in lambdaExpression.Parameters)
                this.parameters.Add(parameter);

            try
            {
                return CSharpSyntaxGenerator.Lambda(
                    lambdaExpression.Parameters.Select(parameter => (parameter.Type, parameter.Name)),
                    this.Visit(lambdaExpression.Body));
            }
            finally
            {
                foreach (var parameter in lambdaExpression.Parameters)
                    this.parameters.Remove(parameter);
            }
        }

        private WorkflowExpressionFragment Visit(ListInitExpression listInitExpression) =>
            CSharpSyntaxGenerator.Initializer(
                this.Visit(listInitExpression.NewExpression),
                listInitExpression.Initializers.Select(this.ElementInitializer));

        private WorkflowExpressionFragment Visit(MemberExpression memberExpression)
        {
            if (memberExpression.Expression == null)
            {
                return CSharpSyntaxGenerator.StaticMemberAccess(
                    memberExpression.Member.DeclaringType,
                    memberExpression.Member.Name);
            }

            return CSharpSyntaxGenerator.MemberAccess(
                this.Receiver(memberExpression.Expression),
                memberExpression.Member.Name);
        }

        private WorkflowExpressionFragment Visit(MemberInitExpression memberInitExpression) =>
            CSharpSyntaxGenerator.Initializer(
                memberInitExpression.NewExpression.Arguments.Count == 0
                    ? WorkflowExpressionFragment.Text("new " + CSharpSyntaxGenerator.TypeName(memberInitExpression.Type))
                    : this.Visit(memberInitExpression.NewExpression),
                memberInitExpression.Bindings.Select(this.Binding));

        private WorkflowExpressionFragment Binding(MemberBinding binding)
        {
            return binding switch
            {
                MemberAssignment assignment =>
                    CSharpSyntaxGenerator.Assignment(
                        assignment.Member.Name,
                        this.Visit(assignment.Expression)),

                MemberMemberBinding member =>
                    CSharpSyntaxGenerator.MemberInitializer(
                        member.Member.Name,
                        member.Bindings.Select(this.Binding)),

                MemberListBinding list =>
                    CSharpSyntaxGenerator.MemberInitializer(
                        list.Member.Name,
                        list.Initializers.Select(this.ElementInitializer)),

                _ => throw new NotSupportedException(
                    $"Unsupported object initializer binding: {binding.BindingType}"),
            };
        }

        private WorkflowExpressionFragment ElementInitializer(ElementInit initializer)
        {
            if (!initializer.AddMethod.IsPublic || initializer.AddMethod.IsStatic)
            {
                throw new NotSupportedException(
                    $"Collection initializer method must be a public instance method: {initializer.AddMethod}");
            }

            var parameters = initializer.AddMethod.GetParameters();
            var overloaded = initializer.AddMethod.DeclaringType.GetMethods()
                .Count(method => method.Name == initializer.AddMethod.Name) > 1;
            var arguments = initializer.Arguments.Select(
                (argument, index) => this.Argument(argument, parameters[index].ParameterType, overloaded));
            return initializer.Arguments.Count == 1
                ? arguments.Single()
                : WorkflowExpressionFragment.CommaSeparated(arguments).Braced();
        }

        private WorkflowExpressionFragment Visit(NewExpression newExpression)
        {
            if (WorkflowExpressionTypePolicy.IsAnonymous(newExpression.Type))
            {
                return CSharpSyntaxGenerator.Initializer(
                    WorkflowExpressionFragment.Text("new"),
                    newExpression.Arguments.Select((argument, index) =>
                    {
                        var value = this.Visit(argument);
                        return CSharpSyntaxGenerator.Assignment(
                            newExpression.Members[index].Name,
                            value.IsText("null")
                                ? CSharpSyntaxGenerator.Cast(argument.Type, WorkflowExpressionFragment.Text("null"))
                                : value);
                    }));
            }

            var parameters = newExpression.Constructor?.GetParameters() ?? Array.Empty<ParameterInfo>();
            var overloaded = newExpression.Constructor != null &&
                newExpression.Type.GetConstructors().Length > 1;

            return CSharpSyntaxGenerator.ObjectCreation(
                newExpression.Type,
                newExpression.Arguments.Select(
                    (argument, index) => this.Argument(argument, parameters[index].ParameterType, overloaded)));
        }

        private WorkflowExpressionFragment Visit(NewArrayExpression newArrayExpression)
        {
            if (newArrayExpression.NodeType == ExpressionType.NewArrayBounds)
            {
                return CSharpSyntaxGenerator.ArrayBoundsCreation(
                    newArrayExpression.Type.GetElementType(),
                    newArrayExpression.Expressions.Select(this.Visit));
            }

            var elements = newArrayExpression.Expressions.Select(this.Visit);
            var elementType = newArrayExpression.Type.GetElementType();
            return WorkflowExpressionTypePolicy.ContainsAnonymous(elementType)
                ? CSharpSyntaxGenerator.InferredArrayCreation(elements)
                : CSharpSyntaxGenerator.ArrayCreation(newArrayExpression.Type, elements);
        }

        private WorkflowExpressionFragment Visit(TypeBinaryExpression typeBinaryExpression)
        {
            if (typeBinaryExpression.NodeType != ExpressionType.TypeIs)
                throw Unsupported(typeBinaryExpression);

            return CSharpSyntaxGenerator.TypeTest(
                this.Visit(typeBinaryExpression.Expression),
                typeBinaryExpression.TypeOperand);
        }

        private WorkflowExpressionFragment Visit(DefaultExpression defaultExpression) =>
            CSharpSyntaxGenerator.Default(defaultExpression.Type);

        private WorkflowExpressionFragment Visit(IndexExpression indexExpression) =>
            CSharpSyntaxGenerator.ElementAccess(
                this.Visit(indexExpression.Object),
                indexExpression.Arguments.Select(this.Visit));

        private static NotSupportedException Unsupported(Expression expression) =>
            new NotSupportedException($"C# serialization does not support {expression.NodeType}: {expression}");

        private static WorkflowExpressionFragment ReadWorkflowValue(WorkflowExpressionFragment source, Type type)
        {
            if (typeof(JToken).IsAssignableFrom(type))
                return source;

            WorkflowExpressionTypePolicy.Validate(type);
            return CSharpSyntaxGenerator.Invocation(
                CSharpSyntaxGenerator.MemberAccess(source, "ToObject"),
                new[] { type },
                Array.Empty<WorkflowExpressionFragment>());
        }

        private bool TryCustomWorkflowPath(Expression expression, out WorkflowExpressionFragment code)
        {
            code = null;
            var properties = new List<PropertyInfo>();
            if (!this.TryCollectCustomWorkflowPath(expression, properties, out var root) ||
                properties.Count == 0)
            {
                return false;
            }

            code = root;
            foreach (var property in properties)
            {
                var jsonName = property.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ?? property.Name;
                code = CSharpSyntaxGenerator.ElementAccess(
                    code,
                    new[] { CSharpSyntaxGenerator.Literal(jsonName, typeof(string)) });
            }

            code = ReadWorkflowValue(code, expression.Type);
            return true;
        }

        private bool TryCollectCustomWorkflowPath(
            Expression expression,
            List<PropertyInfo> properties,
            out WorkflowExpressionFragment root)
        {
            if (this.TryWorkflowTokenSource(expression, out root))
                return true;

            if (expression is not MemberExpression member ||
                member.Member is not PropertyInfo property ||
                WorkflowExpressionTypePolicy.IsRuntimeAvailable(property.DeclaringType) ||
                !IsStoredDtoProperty(property) ||
                !this.TryCollectCustomWorkflowPath(member.Expression, properties, out root))
            {
                root = null;
                return false;
            }

            properties.Add(property);
            return true;
        }

        private static bool IsStoredDtoProperty(PropertyInfo property) =>
            property.GetMethod?.IsDefined(typeof(CompilerGeneratedAttribute), inherit: false) == true;

        private bool TryWorkflowTokenSource(Expression expression, out WorkflowExpressionFragment code)
        {
            if (expression is MemberExpression member && TryCreateWorkflowBinding(member, out var binding))
            {
                code = WorkflowExpressionFragment.Binding(binding);
                return true;
            }

            if (expression is MethodCallExpression call &&
                this.TryResolveWorkflowFunction(call, out code, out var metadata) &&
                metadata.ReturnsToken)
            {
                return true;
            }

            code = null;
            return false;
        }

        private static bool TryCreateWorkflowBinding(
            MemberExpression member,
            out WorkflowExpressionBinding binding)
        {
            binding = null;
            if (member.Expression != null && CapturedValueReader.TryRead(member.Expression, out var instance) && instance != null)
            {
                var type = instance.GetType();
                if (Implements(type, typeof(IOutputWorkflowTrigger<>)) && member.Member.Name == "TriggerOutput")
                    binding = WorkflowExpressionBinding.Trigger((IWorkflowTrigger)instance, body: false);
                else if (Implements(type, typeof(IBodyWorkflowTrigger<>)) && member.Member.Name == "TriggerBody")
                    binding = WorkflowExpressionBinding.Trigger((IWorkflowTrigger)instance, body: true);
                else if (Implements(type, typeof(IOutputWorkflowAction<>)) && member.Member.Name == "Output")
                    binding = WorkflowExpressionBinding.Output((IWorkflowAction)instance);
                else if (Implements(type, typeof(IBodyWorkflowAction<>)) && member.Member.Name == "Body")
                    binding = WorkflowExpressionBinding.Body((IWorkflowAction)instance);
                else if (instance is IVariableWorkflowAction variable && member.Member.Name == "Value")
                    binding = WorkflowExpressionBinding.Variable(variable);
            }

            if (binding != null)
                return true;

            if (member.Expression is MemberExpression
                {
                    Member.Name: "Parameters",
                    Expression: not null,
                } parameters &&
                CapturedValueReader.TryRead(parameters.Expression, out var context) &&
                context != null &&
                Implements(context.GetType(), typeof(IAgentToolContext<>)))
            {
                var jsonName = member.Member.GetCustomAttribute<JsonPropertyAttribute>()?.PropertyName ??
                    member.Member.Name;
                binding = WorkflowExpressionBinding.AgentParameter(context, jsonName);
                return true;
            }

            return false;
        }

        private bool TryResolveWorkflowFunction(
            MethodCallExpression call,
            out WorkflowExpressionFragment code,
            out WorkflowFunctionAttribute metadata)
        {
            code = null;
            metadata = null;
            if (call.Method.DeclaringType != typeof(WorkflowFunctions))
                return false;
            metadata = call.Method.GetCustomAttribute<WorkflowFunctionAttribute>() ??
                (call.Method.IsGenericMethod
                    ? call.Method.GetGenericMethodDefinition().GetCustomAttribute<WorkflowFunctionAttribute>()
                    : null) ??
                throw new NotSupportedException(
                    $"Workflow function '{call.Method.Name}' has no runtime mapping.");

            code = CSharpSyntaxGenerator.Invocation(
                WorkflowExpressionFragment.Text(metadata.Name),
                Array.Empty<Type>(),
                call.Arguments.Select(this.Visit));
            return true;
        }

        private bool TryResolveWorkflowFunctionTyped(
            MethodCallExpression call,
            out WorkflowExpressionFragment code)
        {
            if (!this.TryResolveWorkflowFunction(call, out code, out var metadata))
                return false;

            if (metadata.ReturnsToken)
                code = ReadWorkflowValue(code, call.Type);

            return true;
        }

        private WorkflowExpressionFragment Argument(Expression expression, Type parameterType, bool forceType)
        {
            var source = this.Visit(expression);
            if (!forceType || expression.Type == parameterType || WorkflowExpressionTypePolicy.ContainsAnonymous(parameterType))
                return source;

            WorkflowExpressionTypePolicy.Validate(parameterType);
            return CSharpSyntaxGenerator.Cast(parameterType, source);
        }

        private WorkflowExpressionFragment Receiver(Expression expression)
        {
            var code = this.Visit(expression);
            return code.IsText("null")
                ? CSharpSyntaxGenerator.TypedNull(expression.Type)
                : code;
        }
    }
}
