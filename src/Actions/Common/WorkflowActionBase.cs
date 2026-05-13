// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Provides the base implementation for workflow action nodes. Concrete action types (such as
    /// HTTP actions, Compose actions, and custom code actions) inherit from this class to get
    /// automatic support for the fluent chaining API, name generation, and run-after configuration.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class implements <see cref="IWorkflowAction"/> and all four <see cref="IChainableNode.Then(IWorkflowAction)">Then</see>
    /// overloads. When <c>.Then()</c> is called on an action, the child action is added to <see cref="Children"/>
    /// and its <see cref="IWorkflowAction.RunAfterConfig"/> is updated to reference this action.
    /// </para>
    /// <para>
    /// Subclasses must implement <see cref="GetActionDefinition"/> to produce the
    /// <see cref="FlowTemplateAction"/> that represents this action in the serialized workflow definition.
    /// </para>
    /// </remarks>
    /// <seealso cref="IWorkflowAction"/>
    /// <seealso cref="WorkflowTriggerBase"/>
    public abstract class WorkflowActionBase : IWorkflowAction
    {
        /// <summary>
        /// Gets or sets the name of the action.
        /// </summary>
        public string Name { get; set; } = Utility.GetUniqueOperationName();

        /// <summary>
        /// Gets the child action nodes that run after this action.
        /// </summary>
        public List<IWorkflowAction> Children { get; } = new List<IWorkflowAction>();

        /// <summary>
        /// Gets the action definition as a FlowTemplateAction.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        public abstract FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null);

        /// <summary>
        /// Gets the run-after configuration mapping parent action names to required statuses.
        /// </summary>
        public Dictionary<string, FlowStatus[]> RunAfterConfig { get; } = new Dictionary<string, FlowStatus[]>();

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action), "Action cannot be null.");
            }
            action.RunAfterConfig[this.Name] = new[] { FlowStatus.Succeeded };
            this.Children.Add(action);

            return new OperationChain(this, action);
        }

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action, FlowStatus[] runAfter)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action), "Action cannot be null.");
            }
            action.RunAfterConfig[this.Name] = runAfter ?? new[] { FlowStatus.Succeeded };
            this.Children.Add(action);

            return new OperationChain(this, action);
        }

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action, RunAfter[] runAfter)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action), "Action cannot be null.");
            }
            foreach (var ra in runAfter.CoalesceEnumerable())
            {
                if (string.IsNullOrEmpty(ra.ActionName))
                {
                    throw new InvalidOperationException($"Invalid action '{ra.ActionName}' in RunAfter configuration.");
                }
                action.RunAfterConfig[ra.ActionName] = ra.Status ?? new[] { FlowStatus.Succeeded };
            }
            this.Children.Add(action);

            return new OperationChain(this, action);
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

                if (!object.ReferenceEquals(this, branch.Start))
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

            return new OperationChain(this, allEnds.ToArray());
        }

        /// <inheritdoc/>
        public IWorkflowOperation GetRootOperation()
        {
            return this;
        }
    }
}
