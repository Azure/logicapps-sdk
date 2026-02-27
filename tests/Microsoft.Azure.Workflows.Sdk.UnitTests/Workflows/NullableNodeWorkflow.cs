// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Test workflow that validates NullableNode rendering.
    /// A NullableNode (e.g. triggerOutputs()) should only emit the null-safe
    /// dereference operator '?' when followed by a member access, not when
    /// used standalone in a template string.
    /// </summary>
    public static class NullableNodeWorkflow
    {
        /// <summary>
        /// Adds the workflow that uses NullableNode (trigger.TriggerOutput) in both standalone and member-access contexts.
        /// </summary>
        public static void AddNullableNodeWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger("HttpTrigger");
            var builder = WorkflowBuilderFactory.CreateStatefulWorkflow("NullableNodeTest", trigger);

            var composeStandalone = WorkflowActions.BuiltIn.Compose(
                inputs: () => $"Output is: {trigger.TriggerOutput}");
            builder.AddAction(composeStandalone, "Compose_Standalone");

            var composeMemberAccess = WorkflowActions.BuiltIn.Compose(
                inputs: () => $"Body is: {trigger.TriggerOutput.Body}");
            builder.AddAction(composeMemberAccess, "Compose_MemberAccess");
        }
    }
}
