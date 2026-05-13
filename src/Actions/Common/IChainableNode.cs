// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Defines the fluent chaining contract for workflow nodes.
    /// </summary>
    public interface IChainableNode
    {
        /// <summary>
        /// Chains a subsequent operation to run after this node (operation or chain).
        /// </summary>
        /// <param name="action">The action to append to the chain.</param>
        /// <returns>A <see cref="OperationChain"/> tracking the chain from this node's start to the appended action.</returns>
        OperationChain Then(IWorkflowAction action);

        /// <summary>
        /// Chains a subsequent operation to run after this node (operation or chain) with multiple run-after statuses.
        /// </summary>
        /// <param name="action">The action to append to the chain.</param>
        /// <param name="runAfter">The statuses for the run-after configuration.</param>
        /// <returns>A <see cref="OperationChain"/> tracking the chain from this node's start to the appended action.</returns>
        OperationChain Then(IWorkflowAction action, FlowStatus[] runAfter);

        /// <summary>
        /// Chains a subsequent operation to run after this node (operation or chain) with multiple run-after statuses for different actions.
        /// </summary>
        /// <param name="action">The action to append to the chain.</param>
        /// <param name="runAfter">The run-after configurations.</param>
        /// <returns>A <see cref="OperationChain"/> tracking the chain from this node's start to the appended action.</returns>
        OperationChain Then(IWorkflowAction action, RunAfter[] runAfter);

        /// <summary>
        /// Splits the chain into multiple branches that run in parallel after this node.
        /// </summary>
        /// <param name="branches">A callback that takes the current node and returns multiple new chains that share the same root.</param>
        /// <returns>A new <see cref="OperationChain"/> with the same start and the combined end nodes of all branches.</returns>
        OperationChain Then(Func<IChainableNode, OperationChain[]> branches);
    }
}
