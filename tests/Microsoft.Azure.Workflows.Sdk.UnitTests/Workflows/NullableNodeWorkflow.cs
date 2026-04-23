// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Test workflow that validates NullableNode rendering.
    /// </summary>
    public class NullableNodeWorkflow : IWorkflowProvider
    {
        /// <summary>
        /// Gets the workflow that uses NullableNode (trigger.TriggerOutput) in both standalone and member-access contexts.
        /// </summary>
        public FlowPropertiesDefinition[] GetWorkflows()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("HttpTrigger");

            var composeStandalone = WorkflowActions.BuiltIn.Compose(
                inputs: () => $"Output is: {trigger.TriggerOutput}");
            composeStandalone.Name = "Compose_Standalone";

            var composeMemberAccess = WorkflowActions.BuiltIn.Compose(
                inputs: () => $"Body is: {trigger.TriggerOutput.Body}");
            composeMemberAccess.Name = "Compose_MemberAccess";

            trigger
                .Then(composeStandalone)
                .Then(composeMemberAccess);

            return new[] { WorkflowFactory.CreateStatefulWorkflow("NullableNodeTest", trigger) };
        }
    }
}
