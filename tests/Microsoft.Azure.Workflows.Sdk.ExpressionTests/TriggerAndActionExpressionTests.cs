// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionTests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Characterization tests for expressions that reference workflow runtime state:
    /// trigger outputs (<c>triggerOutputs()</c>) and action bodies/outputs
    /// (<c>body('name')</c> / <c>outputs('name')</c>).
    ///
    /// These JToken-typed members are consumed via string interpolation (as in real
    /// workflows), which routes them through the string-concat rendering path where a
    /// non-literal node is wrapped in <c>@{ ... }</c>.
    /// </summary>
    public class TriggerAndActionExpressionTests
    {
        // -------------------- Trigger outputs --------------------

        [Fact]
        public void Convert_TriggerOutput_Standalone_EmitsTriggerOutputs()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("HttpTrigger");
            Assert.Equal(
                "@{triggerOutputs()}",
                ExpressionConverter.Convert(() => $"{trigger.TriggerOutput}"));
        }

        [Fact]
        public void Convert_TriggerOutput_MemberAccess_EmitsNullSafeBracketAccess()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("HttpTrigger");
            Assert.Equal(
                "@{triggerOutputs()?['Body']}",
                ExpressionConverter.Convert(() => $"{trigger.TriggerOutput.Body}"));
        }

        [Fact]
        public void Convert_ManagedTriggerBody_Standalone_EmitsTriggerBody()
        {
            // A managed-connector trigger implementing IBodyWorkflowTrigger<T> exposes a
            // strongly-typed TriggerBody that renders to triggerBody() (no arguments),
            // as opposed to the built-in trigger's triggerOutputs().
            var trigger = WorkflowTriggers.Managed.Azurequeues("conn")
                .OnMessages(storageAccountName: () => "a", queueName: () => "q");
            Assert.Equal(
                "@{triggerBody()}",
                ExpressionConverter.Convert(() => $"{trigger.TriggerBody}"));
        }

        // -------------------- Action outputs / body --------------------

        [Fact]
        public void Convert_ActionOutput_EmitsOutputsFunctionWithActionName()
        {
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "x").WithName("ComposeInput");
            Assert.Equal(
                "@{outputs('ComposeInput')}",
                ExpressionConverter.Convert(() => $"{compose.Output}"));
        }

        [Fact]
        public void Convert_ActionBody_EmitsBodyFunctionWithActionName()
        {
            var sharepoint = WorkflowActions.Managed.Sharepointonline("sharepoint")
                .GetItems(dataset: () => "d", table: () => "t")
                .WithName("GetItems");
            Assert.Equal(
                "@{body('GetItems')}",
                ExpressionConverter.Convert(() => $"{sharepoint.Body}"));
        }

        // -------------------- Combinations --------------------

        [Fact]
        public void Convert_MixedConcat_EmitsInlineExpressionsWithLiteralText()
        {
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "x").WithName("ComposeInput");
            var sharepoint = WorkflowActions.Managed.Sharepointonline("sharepoint")
                .GetItems(dataset: () => "d", table: () => "t")
                .WithName("GetItems");
            Assert.Equal(
                "a @{outputs('ComposeInput')} b @{body('GetItems')}",
                ExpressionConverter.Convert(() => $"a {compose.Output} b {sharepoint.Body}"));
        }

        [Fact]
        public void Convert_TriggerOutputEqualsActionOutput_EmitsEquals()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("HttpTrigger");
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "x").WithName("ComposeInput");
            Assert.Equal(
                "@equals(triggerOutputs()?['Body'], outputs('ComposeInput'))",
                ExpressionConverter.Convert(() => trigger.TriggerOutput.Body == compose.Output));
        }

        // -------------------- Agent tool parameters --------------------

        [Fact]
        public void Convert_AgentToolContextParameter_EmitsAgentParametersFunction()
        {
            var ctx = new AgentToolContext<Poco>(new Poco { Name = "n" });
            Assert.Equal(
                "@{agentparameters('Name')}",
                ExpressionConverter.Convert(() => $"{ctx.Parameters.Name}"));
        }
    }
}
