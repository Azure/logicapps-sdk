// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Defines the fluent chaining contract for workflow nodes.
    /// Implemented by <see cref="WorkflowChain"/> (multi-node chains),
    /// actions, and triggers (via <see cref="IWorkflowOperation"/>).
    /// </summary>
    public interface IWorkflowNode
    {
        /// <summary>
        /// Chains a subsequent node to run after this node.
        /// Accepts single actions, multi-node chains, or interface-typed actions.
        /// </summary>
        /// <param name="node">The node or chain to append. Must resolve to an action start, not a trigger.</param>
        /// <param name="runAfterStatus">The required statuses for the run-after dependency.</param>
        /// <returns>A <see cref="WorkflowChain"/> tracking the chain from this node to the appended node's end.</returns>
        WorkflowChain Then(IWorkflowNode node, FlowStatus[] runAfterStatus = null);

        /// <summary>
        /// Chains a subsequent named node to run after this node.
        /// Accepts single actions, multi-node chains, or interface-typed actions.
        /// </summary>
        /// <param name="name">The name to assign to the start action.</param>
        /// <param name="node">The node or chain to append. Must resolve to an action start, not a trigger.</param>
        /// <param name="runAfterStatus">The required statuses for the run-after dependency.</param>
        /// <returns>A <see cref="WorkflowChain"/> tracking the chain from this node to the appended node's end.</returns>
        WorkflowChain Then(string name, IWorkflowNode node, FlowStatus[] runAfterStatus = null);
    }
}
