// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Common interface for all workflow graph nodes (triggers and actions).
    /// Used as the chain root type so that action chains can track back to either
    /// a trigger or the first action in the chain.
    /// </summary>
    public interface IWorkflowNode
    {
        /// <summary>
        /// Gets or sets the name of the workflow node.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets the child action nodes that run after this node.
        /// </summary>
        List<IWorkflowAction> Children { get; }

        /// <summary>
        /// Chains a subsequent action node to run after this node.
        /// </summary>
        /// <param name="action">The action node to chain.</param>
        /// <param name="runAfterStatus">The required statuses for the run-after dependency.</param>
        /// <returns>The chained action node for further fluent chaining.</returns>
        IWorkflowAction Then(IWorkflowAction action, FlowStatus[] runAfterStatus = null);

        /// <summary>
        /// Chains a subsequent action node to run after this node.
        /// </summary>
        /// <param name="name">The name of the action.</param>
        /// <param name="action">The action node to chain.</param>
        /// <param name="runAfterStatus">The required statuses for the run-after dependency.</param>
        /// <returns>The chained action node for further fluent chaining.</returns>
        IWorkflowAction Then(string name, IWorkflowAction action, FlowStatus[] runAfterStatus = null);
    }
}
