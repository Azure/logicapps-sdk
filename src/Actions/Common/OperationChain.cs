// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Base class for all workflow nodes providing chain tracking and fluent operation chaining.
    /// Every workflow operation (action or trigger) is itself a single-node chain where Start and Ends
    /// are the node itself. When nodes are connected via <see cref="Then(IWorkflowNode, FlowStatus[])"/>,
    /// a new <see cref="OperationChain"/> is returned that tracks the full chain from start to ends.
    /// Multi-node chains are standalone instances with no Name or Children of their own.
    /// Chains may track multiple end nodes when created via <see cref="Join(OperationChain)"/>
    /// or <see cref="Split(Func{OperationChain, IEnumerable{OperationChain}})"/>.
    /// </summary>
    public class OperationChain : IWorkflowNode
    {
        private readonly IWorkflowOperation _start;
        private readonly IWorkflowOperation[] _ends;

        /// <summary>
        /// Gets the first node in the chain. For single-node chains (actions/triggers),
        /// returns the node itself.
        /// </summary>
        public IWorkflowOperation Start => this._start ?? this as IWorkflowOperation;

        /// <summary>
        /// Gets the end nodes of the chain. For single-node chains (actions/triggers),
        /// returns a single-element array containing the node itself.
        /// For joined chains, returns all end nodes.
        /// </summary>
        public IReadOnlyList<IWorkflowOperation> Ends => this._ends ?? new[] { this as IWorkflowOperation };

        /// <summary>
        /// Initializes a new single-node chain. Used by subclasses (actions/triggers)
        /// where Start and Ends default to the node itself.
        /// </summary>
        protected OperationChain()
        {
        }

        /// <summary>
        /// Initializes a new multi-node chain with explicit start and end nodes.
        /// </summary>
        /// <param name="start">The first node in the chain.</param>
        /// <param name="end">The last node in the chain.</param>
        public OperationChain(IWorkflowOperation start, IWorkflowOperation end)
        {
            this._start = start ?? throw new ArgumentNullException(nameof(start));
            this._ends = new[] { end ?? throw new ArgumentNullException(nameof(end)) };
        }

        /// <summary>
        /// Initializes a new multi-end chain with explicit start and multiple end nodes.
        /// </summary>
        /// <param name="start">The first node in the chain.</param>
        /// <param name="ends">The end nodes of the chain.</param>
        public OperationChain(IWorkflowOperation start, IWorkflowOperation[] ends)
        {
            this._start = start ?? throw new ArgumentNullException(nameof(start));
            this._ends = ends ?? throw new ArgumentNullException(nameof(ends));

            if (ends.Length == 0)
            {
                throw new ArgumentException("At least one end node is required.", nameof(ends));
            }
        }

        /// <summary>
        /// Combines this chain with another chain that shares the same root.
        /// </summary>
        /// <param name="other">The other chain to join with. Must share the same root as this chain.</param>
        /// <returns>A new <see cref="OperationChain"/> with the same start and the combined end nodes of both chains.</returns>
        public OperationChain Join(OperationChain other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            if (!object.ReferenceEquals(this.Start, other.Start))
            {
                throw new InvalidOperationException("Cannot join chains that do not share the same root.");
            }

            var combinedEnds = new List<IWorkflowOperation>(this.Ends);

            foreach (var end in other.Ends)
            {
                if (!combinedEnds.Contains(end))
                {
                    combinedEnds.Add(end);
                }
            }

            return new OperationChain(this.Start, combinedEnds.ToArray());
        }

        /// <summary>
        /// Splits this chain into multiple branches.
        /// </summary>
        /// <param name="branches">A callback that takes the current chain and returns multiple new chains that share the same root.</param>
        /// <returns>A new <see cref="OperationChain"/> with the same start and the combined end nodes of all branches.</returns>
        public OperationChain Split(Func<OperationChain, IEnumerable<OperationChain>> branches)
        {
            if (branches == null)
            {
                throw new ArgumentNullException(nameof(branches));
            }

            var branchesList = branches.Invoke(this)?.ToList()
                ?? throw new InvalidOperationException("Branches must not be null.");

            if (branchesList.Count == 0)
            {
                throw new InvalidOperationException("At least one branch is required.");
            }

            var allEnds = new List<IWorkflowOperation>();

            foreach (var branch in branchesList)
            {
                if (branch == null)
                {
                    throw new InvalidOperationException("Null branch is not allowed.");
                }

                if (!object.ReferenceEquals(this.Start, branch.Start))
                {
                    throw new InvalidOperationException("All branches must share the same root as the parent chain.");
                }

                foreach (var end in branch.Ends)
                {
                    if (!allEnds.Contains(end))
                    {
                        allEnds.Add(end);
                    }
                }
            }

            return new OperationChain(this.Start, allEnds.ToArray());
        }

        /// <inheritdoc/>
        public virtual OperationChain Then(IWorkflowAction action, string name = null)
        {
            foreach (var end in this.Ends)
            {
                if (object.ReferenceEquals(end, this))
                {
                    continue;
                }
                end.Then(action, name);
            }

            return new OperationChain(this.Start, action);
        }

        /// <inheritdoc/>
        public virtual OperationChain Then(IWorkflowAction action, FlowStatus[] runAfter, string name = null)
        {
            foreach (var end in this.Ends)
            {
                if (object.ReferenceEquals(end, this))
                {
                    continue;
                }
                end.Then(action, runAfter, name);
            }

            return new OperationChain(this.Start, action);
        }

        /// <inheritdoc/>
        public virtual OperationChain Then(IWorkflowAction action, RunAfter[] runAfter, string name = null)
        {
            foreach (var end in this.Ends)
            {
                if (object.ReferenceEquals(end, this))
                {
                    continue;
                }
                end.Then(action, runAfter, name);
            }

            return new OperationChain(this.Start, action);
        }

        /// <summary>
        /// Gets the root action of this operation chain.
        /// </summary>
        public IWorkflowAction GetRootAction()
        {
            return this.Start as IWorkflowAction ?? throw new InvalidOperationException("Invalid GetRootAction usage: operation chain must start with an action.");
        }
    }
}
