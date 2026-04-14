// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Base class for all workflow nodes providing chain tracking and fluent operation chaining.
    /// Every workflow operation (action or trigger) is itself a single-node chain where Start and End
    /// are the node itself. When nodes are connected via <see cref="Then(IWorkflowNode, FlowStatus[])"/>,
    /// a new <see cref="WorkflowChain"/> is returned that tracks the full chain from start to end.
    /// Multi-node chains are standalone instances with no Name or Children of their own.
    /// </summary>
    public class WorkflowChain : IWorkflowNode
    {
        private readonly IWorkflowNode _start;
        private readonly IWorkflowNode _end;

        /// <summary>
        /// Gets the first node in the chain. For single-node chains (actions/triggers),
        /// returns the node itself.
        /// </summary>
        public IWorkflowNode Start => this._start ?? this;

        /// <summary>
        /// Gets the last node in the chain. For single-node chains (actions/triggers),
        /// returns the node itself.
        /// </summary>
        public IWorkflowNode End => this._end ?? this;

        /// <summary>
        /// Initializes a new single-node chain. Used by subclasses (actions/triggers)
        /// where Start and End default to the node itself.
        /// </summary>
        protected WorkflowChain()
        {
        }

        /// <summary>
        /// Initializes a new multi-node chain with explicit start and end nodes.
        /// </summary>
        /// <param name="start">The first node in the chain.</param>
        /// <param name="end">The last node in the chain.</param>
        public WorkflowChain(IWorkflowNode start, IWorkflowNode end)
        {
            this._start = start ?? throw new ArgumentNullException(nameof(start));
            this._end = end ?? throw new ArgumentNullException(nameof(end));
        }

        /// <summary>
        /// Wires a resolved child action to this node and returns a new chain.
        /// Called by <see cref="Then(IWorkflowNode, FlowStatus[])"/> for single-node chains.
        /// Override in subclasses to add wiring behavior (e.g., setting RunAfterConfig).
        /// </summary>
        /// <param name="action">The child action to append (already name-resolved).</param>
        /// <param name="end">The end node of the appended segment.</param>
        /// <param name="runAfterStatus">The required statuses for the run-after dependency.</param>
        /// <returns>A new <see cref="WorkflowChain"/> from this node to the appended end.</returns>
        protected virtual WorkflowChain AppendAction(IWorkflowAction action, IWorkflowNode end, FlowStatus[] runAfterStatus)
        {
            throw new InvalidOperationException("Cannot call Then on a bare multi-node WorkflowChain.");
        }

        /// <summary>
        /// Resolves an <see cref="IWorkflowNode"/> to its start action and end node.
        /// Handles single actions, multi-node chains, and interface-typed actions uniformly.
        /// </summary>
        private static (IWorkflowAction StartAction, IWorkflowNode EndNode) ResolveNode(IWorkflowNode node)
        {
            if (node is WorkflowChain chain && !object.ReferenceEquals(chain.Start, chain))
            {
                // Multi-node chain: extract start action and end node
                var startAction = chain.Start as IWorkflowAction
                    ?? throw new InvalidOperationException("Cannot chain a node that starts with a trigger.");
                return (startAction, chain.End);
            }

            if (node is IWorkflowAction action)
            {
                return (action, node);
            }

            throw new InvalidOperationException("Cannot chain a trigger as a child node.");
        }

        #region Then overloads

        /// <summary>
        /// Chains a subsequent node to run after this chain's end.
        /// Accepts single actions, multi-node chains, or interface-typed actions.
        /// </summary>
        /// <param name="node">The node or chain to append. Must resolve to an action start, not a trigger.</param>
        /// <param name="runAfterStatus">The required statuses for the run-after dependency.</param>
        /// <returns>A new <see cref="WorkflowChain"/> tracking the chain from this node's start to the appended node's end.</returns>
        public WorkflowChain Then(IWorkflowNode node, FlowStatus[] runAfterStatus = null)
        {
            // Multi-node chain: delegate to End node
            if (!object.ReferenceEquals(this.End, this))
            {
                var (_, endNode) = ResolveNode(node);
                this.End.Then(node, runAfterStatus);
                return new WorkflowChain(this.Start, endNode);
            }

            // Single-node chain: resolve and wire via subclass
            var (startAction, end) = ResolveNode(node);

            if (string.IsNullOrEmpty(startAction.Name))
            {
                startAction.Name = Utility.GetUniqueActionName();
            }

            return this.AppendAction(startAction, end, runAfterStatus);
        }

        /// <summary>
        /// Chains a subsequent named node to run after this chain's end.
        /// Accepts single actions, multi-node chains, or interface-typed actions.
        /// </summary>
        /// <param name="name">The name to assign to the start action.</param>
        /// <param name="node">The node or chain to append. Must resolve to an action start, not a trigger.</param>
        /// <param name="runAfterStatus">The required statuses for the run-after dependency.</param>
        /// <returns>A new <see cref="WorkflowChain"/> tracking the chain from this node's start to the appended node's end.</returns>
        public WorkflowChain Then(string name, IWorkflowNode node, FlowStatus[] runAfterStatus = null)
        {
            // Multi-node chain: delegate to End node
            if (!object.ReferenceEquals(this.End, this))
            {
                var (_, endNode) = ResolveNode(node);
                this.End.Then(name, node, runAfterStatus);
                return new WorkflowChain(this.Start, endNode);
            }

            // Single-node chain: resolve, assign name, and wire via subclass
            var (startAction, end) = ResolveNode(node);

            startAction.Name = !string.IsNullOrEmpty(name)
                ? name
                : !string.IsNullOrEmpty(startAction.Name)
                    ? startAction.Name
                    : Utility.GetUniqueActionName();

            return this.AppendAction(startAction, end, runAfterStatus);
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Extracts the root action from an <see cref="IWorkflowNode"/> result.
        /// For chains, returns the Start node cast to <see cref="IWorkflowAction"/>.
        /// For single action nodes, returns the node itself.
        /// Used by control action factories to get the root of a branch's action graph.
        /// </summary>
        /// <param name="node">The node or chain returned from a branch callback.</param>
        /// <returns>The root <see cref="IWorkflowAction"/> of the action graph.</returns>
        public static IWorkflowAction GetRootAction(IWorkflowNode node)
        {
            if (node is WorkflowChain chain)
            {
                return chain.Start as IWorkflowAction
                    ?? throw new InvalidOperationException("Branch chain must start with an action, not a trigger.");
            }

            return node as IWorkflowAction
                ?? throw new InvalidOperationException("Branch must contain a workflow action.");
        }

        #endregion
    }
}
