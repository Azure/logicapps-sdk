// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a directed chain of workflow operations, tracking a start node and one or more end nodes.
    /// <see cref="OperationChain"/> is the result of every <c>.Then()</c> call and implements
    /// <see cref="IChainableNode"/> so that additional operations can be appended fluently.
    /// </summary>
    /// <remarks>
    /// <para>
    /// An <see cref="OperationChain"/> always has exactly one <see cref="Start"/> node (the trigger or first action)
    /// and one or more <see cref="Ends"/> nodes. When a chain has multiple end nodes, it represents a fan-out
    /// (parallel branching) pattern. Calling <c>.Then()</c> on a multi-end chain attaches the next action
    /// to <em>all</em> end nodes, creating a fan-in (merge) point.
    /// </para>
    /// <para>
    /// Use the <see cref="Join"/> method to combine two chains that share the same root into a single chain
    /// with a unified set of end nodes. This is useful for building fan-out/fan-in patterns where branches
    /// are constructed independently.
    /// </para>
    /// </remarks>
    /// <seealso cref="IChainableNode"/>
    /// <seealso cref="IWorkflowOperation"/>
    /// <seealso cref="WorkflowFactory"/>
    public class OperationChain : IChainableNode
    {
        /// <summary>
        /// Gets the first node in the chain.
        /// </summary>
        internal IWorkflowOperation Start { get; private set; }

        /// <summary>
        /// Gets the end node(s) of the chain.
        /// </summary>
        internal IReadOnlyList<IWorkflowOperation> Ends { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationChain"/> class with a single start and end node.
        /// </summary>
        /// <param name="start">The first node in the chain.</param>
        /// <param name="end">The last node in the chain.</param>
        internal OperationChain(IWorkflowOperation start, IWorkflowOperation end)
        {
            this.Start = start ?? throw new ArgumentNullException(nameof(start));
            this.Ends = new[] { end ?? throw new ArgumentNullException(nameof(end)) };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OperationChain"/> class with a single start node and multiple end nodes.
        /// </summary>
        /// <param name="start">The first node in the chain.</param>
        /// <param name="ends">The end nodes of the chain.</param>
        internal OperationChain(IWorkflowOperation start, IWorkflowOperation[] ends)
        {
            this.Start = start ?? throw new ArgumentNullException(nameof(start));
            this.Ends = ends ?? throw new ArgumentNullException(nameof(ends));

            if (ends.Length == 0)
            {
                throw new ArgumentException("At least one end node is required.", nameof(ends));
            }
        }

        /// <summary>
        /// Combines this chain with another chain that shares the same root, producing a single chain
        /// whose end nodes are the union of both chains' end nodes. This enables fan-out/fan-in patterns
        /// where parallel branches are built independently and then merged.
        /// </summary>
        /// <param name="other">
        /// The other chain to join with. Must share the same <see cref="Start"/> node as this chain;
        /// otherwise, an <see cref="InvalidOperationException"/> is thrown.
        /// </param>
        /// <returns>A new <see cref="OperationChain"/> with the same start and the combined end nodes of both chains.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="other"/> is <see langword="null"/>.</exception>
        /// <exception cref="InvalidOperationException">The two chains do not share the same root node.</exception>
        /// <example>
        /// Build two branches from the same trigger, join them, then add a merged action:
        /// <code>
        /// var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
        /// var left = trigger.Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Left").WithName("Left"));
        /// var right = trigger.Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Right").WithName("Right"));
        ///
        /// left.Join(right)
        ///     .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Merged").WithName("Merged"));
        ///
        /// WorkflowFactory.CreateStatefulWorkflow("fanInWorkflow", trigger);
        /// </code>
        /// </example>
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

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action)
        {
            foreach (var end in this.Ends)
            {
                if (object.ReferenceEquals(end, this))
                {
                    continue;
                }
                end.Then(action);
            }

            return new OperationChain(this.Start, action);
        }

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action, FlowStatus[] runAfter)
        {
            foreach (var end in this.Ends)
            {
                if (object.ReferenceEquals(end, this))
                {
                    continue;
                }
                end.Then(action, runAfter);
            }

            return new OperationChain(this.Start, action);
        }

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action, RunAfter[] runAfter)
        {
            foreach (var end in this.Ends)
            {
                if (object.ReferenceEquals(end, this))
                {
                    continue;
                }
                end.Then(action, runAfter);
            }

            return new OperationChain(this.Start, action);
        }

        /// <inheritdoc/>
        public OperationChain Then(Func<IChainableNode, OperationChain[]> branches)
        {
            if (branches == null)
            {
                throw new ArgumentNullException(nameof(branches));
            }

            var branchesArr = branches.Invoke(this)
                ?? throw new InvalidOperationException("Branches must not be null.");

            if (branchesArr.Length == 0)
            {
                throw new InvalidOperationException("At least one branch is required.");
            }

            var allEnds = new List<IWorkflowOperation>();

            foreach (var branch in branchesArr)
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

        /// <summary>
        /// Gets the root trigger of this operation chain (workflow).
        /// </summary>
        internal IWorkflowTrigger GetRootTrigger()
        {
            return this.Start as IWorkflowTrigger ?? throw new InvalidOperationException("Invalid GetRootTrigger usage: operation chain must start with a trigger.");
        }

        /// <summary>
        /// Gets the root action of this operation chain.
        /// </summary>
        internal IWorkflowAction GetRootAction()
        {
            return this.Start as IWorkflowAction ?? throw new InvalidOperationException("Invalid GetRootAction usage: operation chain must start with an action.");
        }
    }
}
