// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Test workflows demonstrating parallel branching.
    /// </summary>
    public static class ParallelBranchWorkflow
    {
        /// <summary>
        /// Adds a workflow that splits into two branches based on run-after status,
        /// without merging them back (fan-out without fan-in).
        /// </summary>
        public static void AddParallelBranchWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            var complete = WorkflowActions.BuiltIn.Compose(inputs: () => "Complete");
            var abandon = WorkflowActions.BuiltIn.Compose(inputs: () => "Abandon");

            var workflow = trigger
                .Then(parent => new[]
                {
                    parent.Then(complete, runAfter: new[] { FlowStatus.Succeeded }),
                    parent.Then(abandon, runAfter: new[] { FlowStatus.Failed }),
                });

            WorkflowFactory.CreateStatefulWorkflow("parallelBranchWorkflow", workflow);
        }

        /// <summary>
        /// Adds a workflow that splits into multiple branches and then merges them
        /// back with a subsequent Then call (fan-out followed by fan-in).
        /// </summary>
        public static void AddParallelBranchThenMergeWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            var setup = WorkflowActions.BuiltIn.Compose(inputs: () => "Setup");
            var branch1 = WorkflowActions.BuiltIn.Compose(inputs: () => "Branch 1");
            var branch2 = WorkflowActions.BuiltIn.Compose(inputs: () => "Branch 2");
            var branch3 = WorkflowActions.BuiltIn.Compose(inputs: () => "Branch 3");
            var merged = WorkflowActions.BuiltIn.Compose(inputs: () => "Merged");

            var workflow = trigger
                .Then(setup)
                .Then(parent => new[]
                {
                    parent.Then(branch1),
                    parent.Then(branch2),
                    parent.Then(branch3),
                })
                .Then(merged);

            WorkflowFactory.CreateStatefulWorkflow("parallelBranchThenMergeWorkflow", workflow);
        }
    }
}
