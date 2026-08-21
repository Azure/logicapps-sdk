// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Microsoft.Azure.Workflows.Sdk;
    
    /// <summary>
    /// GOAL specification for trigger/action/agent runtime context, mirroring
    /// <c>TriggerAndActionExpressionTests</c>. Under the C# model these render as free
    /// functions in scope, with member access via C# indexers.
    /// </summary>
    public class CSharpTriggerAndActionExpressionTests
    {
        // -------------------- Trigger outputs --------------------

        [Fact]
        public void Convert_TriggerOutput_Standalone_EmitsTriggerOutputsCall()
        {
            // LA: @{triggerOutputs()}
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("HttpTrigger");
            Assert.Equal(
                "triggerOutputs()",
                CSharpExpressionConverter.ConvertO(() => $"{trigger.TriggerOutput}"));
        }

        [Fact]
        public void Convert_TriggerOutput_MemberAccess_EmitsNullSafeIndexer()
        {
            // LA: @{triggerOutputs()?['Body']}
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("HttpTrigger");
            Assert.Equal(
                "triggerOutputs()?[\"Body\"]",
                CSharpExpressionConverter.ConvertO(() => $"{trigger.TriggerOutput.Body}"));
        }

        [Fact]
        public void Convert_ManagedTriggerBody_Standalone_EmitsTriggerBodyCall()
        {
            // LA: @{triggerBody()}
            var trigger = WorkflowTriggers.Managed.Azurequeues("conn")
                .OnMessages(storageAccountName: () => "a", queueName: () => "q");
            Assert.Equal(
                "triggerBody()",
                CSharpExpressionConverter.ConvertO(() => $"{trigger.TriggerBody}"));
        }

        // -------------------- Action outputs / body --------------------

        [Fact]
        public void Convert_ActionOutput_EmitsOutputsCallWithActionName()
        {
            // LA: @{outputs('ComposeInput')}
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "x").WithName("ComposeInput");
            Assert.Equal(
                "outputs(\"ComposeInput\")",
                CSharpExpressionConverter.ConvertO(() => $"{compose.Output}"));
        }

        [Fact]
        public void Convert_ActionBody_EmitsBodyCallWithActionName()
        {
            // LA: @{body('GetItems')}
            var sharepoint = WorkflowActions.Managed.Sharepointonline("sharepoint")
                .GetItems(dataset: () => "d", table: () => "t")
                .WithName("GetItems");
            Assert.Equal(
                "body(\"GetItems\")",
                CSharpExpressionConverter.ConvertO(() => $"{sharepoint.Body}"));
        }

        // -------------------- Combinations --------------------

        [Fact]
        public void Convert_MixedConcat_EmitsInterpolatedStringWithCalls()
        {
            // LA: a @{outputs('ComposeInput')} b @{body('GetItems')}
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "x").WithName("ComposeInput");
            var sharepoint = WorkflowActions.Managed.Sharepointonline("sharepoint")
                .GetItems(dataset: () => "d", table: () => "t")
                .WithName("GetItems");
            Assert.Equal(
                "$\"a {outputs(\"ComposeInput\")} b {body(\"GetItems\")}\"",
                CSharpExpressionConverter.ConvertO(() => $"a {compose.Output} b {sharepoint.Body}"));
        }

        [Fact]
        public void Convert_TriggerOutputEqualsActionOutput_EmitsEqualityOperator()
        {
            // LA: @equals(triggerOutputs()?['Body'], outputs('ComposeInput'))
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("HttpTrigger");
            var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "x").WithName("ComposeInput");
            Assert.Equal(
                "triggerOutputs()?[\"Body\"] == outputs(\"ComposeInput\")",
                CSharpExpressionConverter.ConvertO(() => trigger.TriggerOutput.Body == compose.Output));
        }

        // -------------------- Agent tool parameters --------------------

        [Fact]
        public void Convert_AgentToolContextParameter_EmitsAgentParametersCall()
        {
            // LA: @{agentparameters('Name')}
            var ctx = new AgentToolContext<Poco>(new Poco { Name = "n" });
            Assert.Equal(
                "agentparameters(\"Name\")",
                CSharpExpressionConverter.ConvertO(() => $"{ctx.Parameters.Name}"));
        }
    }
}
