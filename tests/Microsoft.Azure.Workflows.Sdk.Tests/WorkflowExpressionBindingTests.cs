// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Newtonsoft.Json.Linq;
    using Xunit;
    using static WorkflowExpressionTestSource;

    public class WorkflowExpressionBindingTests
    {
        private IOutputWorkflowAction<string> instanceSource;

        [Fact]
        public void InstanceWorkflowHandleRemainsALateBoundOperationBinding()
        {
            this.instanceSource = WorkflowActions.BuiltIn.Compose<string>(() => "hello");
            var action = WorkflowActions.BuiltIn.Compose(() => instanceSource.Output.ToUpperInvariant());
            this.instanceSource.WithName("InstanceSource");

            var source = Input(action);
            AssertReturnExpression("""(outputs("InstanceSource")).ToObject<string>().ToUpperInvariant()""", source);
        }

        [Fact]
        public void ManagedActionAndTriggerPropertiesUseTypedRoots()
        {
            var email = WorkflowActions.Managed.Office365("office").GetEmail(messageId: () => "id").WithName("Email");
            var action = WorkflowActions.BuiltIn.Compose(() => email.Body.Subject.ToUpperInvariant());
            var actionSource = Input(action);
            var actionReturn = ReturnExpression(actionSource);
            Assert.Equal("ToUpperInvariant", ((InvocationExpressionSyntax)actionReturn).Expression
                .DescendantNodesAndSelf().OfType<SimpleNameSyntax>().Last().Identifier.ValueText);
            Assert.Equal("""body("Email")""", actionReturn.DescendantNodesAndSelf().OfType<InvocationExpressionSyntax>()
                .Single(invocation => invocation.Expression.ToString() == "body").ToString());
            Assert.Single(actionReturn.DescendantNodesAndSelf().OfType<GenericNameSyntax>(),
                name => name.Identifier.ValueText == "ToObject");

            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var triggered = WorkflowActions.BuiltIn.Compose(() => trigger.TriggerOutput.Headers["X"]);
            var triggerSource = Input(triggered);
            var triggerReturn = ReturnExpression(triggerSource);
            Assert.Equal("triggerOutputs()", triggerReturn.DescendantNodesAndSelf().OfType<InvocationExpressionSyntax>()
                .Single(invocation => invocation.Expression.ToString() == "triggerOutputs").ToString());
            Assert.Single(triggerReturn.DescendantNodesAndSelf().OfType<GenericNameSyntax>(),
                name => name.Identifier.ValueText == "ToObject");
            Assert.Equal("\"X\"", triggerReturn.DescendantNodesAndSelf().OfType<BracketedArgumentListSyntax>().Single()
                .Arguments.Single().Expression.ToString());
        }

        [Fact]
        public void TriggerBodyUsesTheBodyBinding()
        {
            var trigger = WorkflowTriggers.ServiceProviders.ServiceBus("service")
                .ReceiveQueueMessages(() => "queue");
            var action = WorkflowActions.BuiltIn.Compose(() => trigger.TriggerBody[0].MessageId);

            AssertReturnExpression(
                """(triggerBody()).ToObject<global::Microsoft.Azure.Workflows.Sdk.ServiceProviders.ServiceBus.ReceiveQueueMessagesOutputItem[]>()[0].MessageId""",
                Input(action));
        }

        [Fact]
        public void ControlCallbacksRunOnceAndDefinitionsResolveNamesLate()
        {
            var count = 0;
            var previous = WorkflowActions.BuiltIn.Compose<bool>(() => true);
            var condition = WorkflowActions.BuiltIn.Control.Condition(
                expression: () => previous.Output,
                trueBranch: () => { count++; return WorkflowActions.BuiltIn.Compose(() => "yes"); },
                falseBranch: () => null);
            previous.WithName("Flag");
            var source = condition.GetActionDefinition("flow").Expression.Value<string>();
            AssertReturnExpression("""(outputs("Flag")).ToObject<bool>()""", source);
            condition.GetActionDefinition("flow");
            Assert.Equal(1, count);
        }

        [Fact]
        public void VariablesAndWorkflowForeachItemsUseContextBindings()
        {
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(name: () => "counter", value: () => 1);
            var read = WorkflowActions.BuiltIn.Compose(() => variable.Value.Value<int>() + 1);
            var readSource = Input(read);
            AssertReturnExpression("""variables("counter").Value<int>() + 1""", readSource);
            var loop = WorkflowActions.BuiltIn.Control.ForEach(
                items: () => new[] { "hello" },
                actions: item => WorkflowActions.BuiltIn.Compose(() => item.Value<string>().ToUpperInvariant()).WithName("Upper"));
            var inner = loop.GetActionDefinition("flow").Actions["Upper"].Inputs as JToken;
            AssertReturnExpression("item().Value<string>().ToUpperInvariant()", inner.Value<string>());
        }
    }
}
