// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Test workflow using graph representation.
    /// </summary>
    public static class GraphWorkflow
    {
        /// <summary>
        /// Adds the workflow using graph representation.
        /// </summary>
        public static IWorkflowTrigger GetGraphWorkflow()
        {
            // Create trigger as root node
            var rootNode = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            // Adds action1 as child of trigger and gets pointer to action1 node
            var action1 = WorkflowActions.BuiltIn.Compose(inputs: () => "First action");
            var action1Node = rootNode.Then("Action1", action1);

            // Create 'left' branch: runs after action1 succeeds
            var leftBranchAction1 = WorkflowActions.BuiltIn.Compose(inputs: () => "Left branch 1");
            var leftBranchAction2 = WorkflowActions.BuiltIn.Compose(inputs: () => "Left branch 2");
            var leftBranchLastNode = action1Node
                .Then("LeftAction1", leftBranchAction1, runAfterStatus: new[] { FlowStatus.Succeeded })
                .Then("LeftAction2", leftBranchAction2);
            
            // Create 'right' branch: runs after action1 fails
            var rightBranchAction1 = WorkflowActions.BuiltIn.Compose(inputs: () => "Right branch 1");
            var rightBranchAction2 = WorkflowActions.BuiltIn.Compose(inputs: () => "Right branch 2");
            var rightBranchLastNode = action1Node
                .Then("RightAction1", rightBranchAction1, runAfterStatus: new[] { FlowStatus.Failed })
                .Then("RightAction2", rightBranchAction2);

            return rootNode;
        }
    }
}
