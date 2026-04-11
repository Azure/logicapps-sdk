// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Base class for workflow action nodes providing graph traversal and fluent chaining support.
    /// </summary>
    public abstract class WorkflowActionBase : IWorkflowAction
    {
        /// <summary>
        /// Gets or sets the name of the action.
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// Gets the action definition as a FlowTemplateAction.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        public abstract FlowTemplateAction GetActionDefinition(string flowName);

        /// <summary>
        /// Gets the child action nodes that run after this node.
        /// </summary>
        public List<IWorkflowAction> Children { get; } = new List<IWorkflowAction>();

        /// <summary>
        /// Gets the run-after configuration mapping parent action names to required statuses.
        /// </summary>
        public Dictionary<string, FlowStatus[]> RunAfterConfig { get; } = new Dictionary<string, FlowStatus[]>();

        /// <summary>
        /// Gets or sets the root node of the chain this action belongs to.
        /// </summary>
        public IWorkflowNode ChainRoot { get; set; }

        /// <summary>
        /// Gets the root of the chain this action belongs to.
        /// Returns <see cref="ChainRoot"/> if set, otherwise returns this action.
        /// </summary>
        public IWorkflowNode GetChainRoot() => this.ChainRoot ?? this;

        /// <summary>
        /// Chains a subsequent action node to run after this node.
        /// </summary>
        /// <param name="action">The action node to chain.</param>
        /// <param name="runAfterStatus">The required statuses for the run-after dependency. Defaults to Succeeded.</param>
        /// <returns>The chained action node for further fluent chaining.</returns>
        public IWorkflowAction Then(IWorkflowAction action, FlowStatus[] runAfterStatus = null)
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                this.Name = Utility.GetUniqueActionName();
            }

            if (string.IsNullOrEmpty(action.Name))
            {
                action.Name = Utility.GetUniqueActionName();
            }

            action.RunAfterConfig[this.Name] = runAfterStatus ?? new[] { FlowStatus.Succeeded };
            action.ChainRoot = this.ChainRoot ?? this;
            this.Children.Add(action);
            return action;
        }

        /// <summary>
        /// Chains a subsequent action node to run after this node.
        /// </summary>
        /// <param name="name">The name of the action.</param>
        /// <param name="action">The action node to chain.</param>
        /// <param name="runAfterStatus">The required statuses for the run-after dependency. Defaults to Succeeded.</param>
        /// <returns>The chained action node for further fluent chaining.</returns>
        public IWorkflowAction Then(string name, IWorkflowAction action, FlowStatus[] runAfterStatus = null)
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                this.Name = Utility.GetUniqueActionName();
            }

            action.Name = !string.IsNullOrEmpty(name)
                ? name
                : !string.IsNullOrEmpty(action.Name)
                    ? action.Name
                    : Utility.GetUniqueActionName();
            action.RunAfterConfig[this.Name] = runAfterStatus ?? new[] { FlowStatus.Succeeded };
            action.ChainRoot = this.ChainRoot ?? this;
            this.Children.Add(action);
            return action;
        }
    }
}
