// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Specifies a run-after dependency for a workflow action, linking it to a predecessor chain
    /// and the <see cref="FlowStatus"/> values that must be reached before the action executes.
    /// Use this class with the <see cref="IChainableNode.Then(IWorkflowAction, RunAfter[])"/> overload
    /// to configure fan-in scenarios where an action depends on multiple predecessor branches,
    /// each with its own required completion status.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Each <see cref="RunAfter"/> instance references a single predecessor chain that must have
    /// exactly one end node. If the chain has multiple end nodes (e.g., from a parallel branch),
    /// an <see cref="ArgumentException"/> is thrown. To reference multiple predecessors, pass an
    /// array of <see cref="RunAfter"/> objects to the <c>Then</c> method.
    /// </para>
    /// </remarks>
    /// <example>
    /// Configure an action to run after two branches complete with different statuses:
    /// <code>
    /// var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
    /// var successChain = trigger.Then(WorkflowActions.BuiltIn.Compose(inputs: () => "OK").WithName("Success"));
    /// var failChain = trigger.Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Fail").WithName("Fail"));
    /// var cleanup = WorkflowActions.BuiltIn.Compose(inputs: () => "Cleanup").WithName("Cleanup");
    ///
    /// successChain.Join(failChain).Then(cleanup, runAfter: new[]
    /// {
    ///     new RunAfter(successChain, FlowStatus.Succeeded),
    ///     new RunAfter(failChain, FlowStatus.Failed),
    /// });
    /// </code>
    /// </example>
    /// <seealso cref="IChainableNode.Then(IWorkflowAction, RunAfter[])"/>
    /// <seealso cref="FlowStatus"/>
    public class RunAfter
    {
        /// <summary>
        /// Gets or sets the predecessor action that this run-after dependency references.
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="FlowStatus"/> values that the predecessor action must
        /// reach for the dependent action to execute.
        /// </summary>
        public FlowStatus[] Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAfter"/> class that depends on a single
        /// <see cref="FlowStatus"/> from the specified predecessor action name.
        /// </summary>
        /// <param name="actionName">The name of the predecessor action.</param>
        /// <param name="status">The completion status required for the dependent action to execute.</param>
        /// <exception cref="ArgumentException"><paramref name="actionName"/> is <see langword="null"/> or empty.</exception>
        public RunAfter(string actionName, FlowStatus status)
        {
            if (string.IsNullOrEmpty(actionName))
            {
                throw new ArgumentException("Action name must be provided for a RunAfter dependency.", nameof(actionName));
            }
            this.ActionName = actionName;
            this.Status = new[] { status };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAfter"/> class that depends on multiple
        /// <see cref="FlowStatus"/> values from the specified predecessor action name.
        /// </summary>
        /// <param name="actionName">The name of the predecessor action.</param>
        /// <param name="statuses">The completion statuses required for the dependent action to execute.</param>
        /// <exception cref="ArgumentException"><paramref name="actionName"/> is <see langword="null"/> or empty.</exception>
        public RunAfter(string actionName, FlowStatus[] statuses)
        {
            if (string.IsNullOrEmpty(actionName))
            {
                throw new ArgumentException("Action name must be provided for a RunAfter dependency.", nameof(actionName));
            }
            this.ActionName = actionName;
            this.Status = statuses ?? new[] { FlowStatus.Succeeded };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAfter"/> class that depends on a single
        /// <see cref="FlowStatus"/> from the specified predecessor chain.
        /// </summary>
        /// <param name="chain">
        /// The predecessor chain to depend on. Must have exactly one end node.
        /// </param>
        /// <param name="status">The completion status required for the dependent action to execute.</param>
        /// <exception cref="ArgumentNullException"><paramref name="chain"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException">
        /// The chain has more than one end node, or its end node is not an <see cref="IWorkflowAction"/>.
        /// </exception>
        public RunAfter(OperationChain chain, FlowStatus status)
        {
            if (chain == null)
            {
                throw new ArgumentNullException(nameof(chain));
            }

            if (chain.Ends.Count > 1)
            {
                throw new ArgumentException("The chain must have only one end action to specify a run after condition.", nameof(chain));
            }

            var action = chain.Ends.First() as IWorkflowAction ?? throw new ArgumentException("The end of the chain must be an action, not a trigger.", nameof(chain));
            this.ActionName = action.Name;
            this.Status = new[] { status };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAfter"/> class that depends on multiple
        /// <see cref="FlowStatus"/> values from the specified predecessor chain.
        /// </summary>
        /// <param name="chain">
        /// The predecessor chain to depend on. Must have exactly one end node.
        /// </param>
        /// <param name="statuses">
        /// The completion statuses required for the dependent action to execute.
        /// The action will run if the predecessor reaches <em>any</em> of the specified statuses.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="chain"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentException">
        /// The chain has more than one end node, or its end node is not an <see cref="IWorkflowAction"/>.
        /// </exception>
        public RunAfter(OperationChain chain, FlowStatus[] statuses)
        {
            if (chain == null)
            {
                throw new ArgumentNullException(nameof(chain));
            }

            if (chain.Ends.Count > 1)
            {
                throw new ArgumentException("The chain must have only one end action to specify a run after condition.", nameof(chain));
            }

            var action = chain.Ends.First() as IWorkflowAction ?? throw new ArgumentException("The end of the chain must be an action, not a trigger.", nameof(chain));
            this.ActionName = action.Name;
            this.Status = statuses ?? new[] { FlowStatus.Succeeded };
        }
    }
}
