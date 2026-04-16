// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Defines the fluent chaining contract for workflow nodes.
    /// </summary>
    public interface IWorkflowNode
    {
        /// <summary>
        /// Chains a subsequent operation to run after this node (operation or chain).
        /// </summary>
        /// <param name="action">The action to append to the chain.</param>
        /// <param name="name">The name of the action.</param>
        /// <returns>A <see cref="WorkflowChain"/> tracking the chain from this node's start to the appended action.</returns>
        WorkflowChain Then(IWorkflowAction action, string name = null);

        /// <summary>
        /// Chains a subsequent operation to run after this node (operation or chain) with multiple run-after statuses.
        /// </summary>
        /// <param name="action">The action to append to the chain.</param>
        /// <param name="runAfter">The statuses for the run-after configuration.</param>
        /// <param name="name">The name of the action.</param>
        /// <returns>A <see cref="WorkflowChain"/> tracking the chain from this node's start to the appended action.</returns>
        WorkflowChain Then(IWorkflowAction action, FlowStatus[] runAfter, string name = null);

        /// <summary>
        /// Chains a subsequent operation to run after this node (operation or chain) with multiple run-after statuses for different actions.
        /// </summary>
        /// <param name="action">The action to append to the chain.</param>
        /// <param name="runAfter">The run-after configurations.</param>
        /// <param name="name">The name of the action.</param>
        /// <returns>A <see cref="WorkflowChain"/> tracking the chain from this node's start to the appended action.</returns>
        WorkflowChain Then(IWorkflowAction action, RunAfter[] runAfter, string name = null);
    }
}
