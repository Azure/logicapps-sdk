// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Test workflow demonstrating chain joining for fan-out/fan-in patterns.
    /// </summary>
    public class ComplexBranchWorkflow : IWorkflowProvider
    {
        /// <summary>
        /// Gets the complex branch workflow definitions.
        /// </summary>
        public FlowDefinition[] GetWorkflows()
        {
            return new[]
            {
                this.GetComplexBranchWorkflowDefinition(),
                this.GetComplexBranchWithRunAfterWorkflowDefinition(),
            };
        }

        /// <summary>
        /// Creates a workflow that fans out into two branches and then joins them
        /// using the default Then overload on a joined chain.
        /// </summary>
        private FlowDefinition GetComplexBranchWorkflowDefinition()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            // Fan out
            var leftChain = trigger
                .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Left branch"))
                .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Left branch continued"));

            var rightChain = trigger
                .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Right branch"))
                .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Right branch continued"));

            // Fan in by joining chains, then add a response that depends on both
            leftChain
                .Join(rightChain)
                .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Joined"));

            return WorkflowFactory.CreateStatefulWorkflow("complexBranchWorkflow", trigger);
        }

        /// <summary>
        /// Creates a workflow that fans out into two branches and then joins them
        /// using the per-chain runAfter overload for explicit status control.
        /// </summary>
        private FlowDefinition GetComplexBranchWithRunAfterWorkflowDefinition()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            // Fan out
            var leftChain = trigger
                .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Left branch"))
                .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Left branch continued"));

            var rightChain = trigger
                .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Right branch"))
                .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Right branch continued"));

            // Fan in with explicit per-chain statuses
            leftChain
                .Join(rightChain)
                .Then(
                    WorkflowActions.BuiltIn.Compose(inputs: () => "Joined"),
                    runAfter: new[]
                    {
                        new RunAfter(leftChain, FlowStatus.Succeeded),
                        new RunAfter(rightChain, FlowStatus.Succeeded),
                    });

            return WorkflowFactory.CreateStatefulWorkflow("complexBranchWithRunAfterWorkflow", trigger);
        }
    }
}
