// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Base class for workflow trigger nodes providing graph traversal and fluent chaining support.
    /// </summary>
    public abstract class WorkflowTriggerBase : IWorkflowTrigger
    {
        /// <summary>
        /// Gets or sets the name of the trigger.
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// Gets the trigger definition for the workflow.
        /// </summary>
        public abstract FlowTemplateTrigger GetTriggerDefinition();

        /// <summary>
        /// Gets the child action nodes that run after this trigger.
        /// </summary>
        public List<IWorkflowAction> Children { get; } = new List<IWorkflowAction>();

        /// <summary>
        /// Chains a subsequent action node to run after this trigger.
        /// </summary>
        /// <param name="action">The action node to chain.</param>
        /// <param name="runAfterStatus">The required statuses. Not used for trigger-to-action edges in stateful/stateless workflows but stored for agent workflows.</param>
        /// <returns>The chained action node for further fluent chaining.</returns>
        public IWorkflowAction Then(IWorkflowAction action, FlowStatus[] runAfterStatus = null)
        {
            if (string.IsNullOrEmpty(action.Name))
            {
                action.Name = Utility.GetUniqueActionName();
            }

            action.ChainRoot = this;
            this.Children.Add(action);
            return action;
        }

        /// <summary>
        /// Chains a subsequent action node to run after this trigger.
        /// </summary>
        /// <param name="name">The name of the action.</param>
        /// <param name="action">The action node to chain.</param>
        /// <param name="runAfterStatus">The required statuses. Not used for trigger-to-action edges in stateful/stateless workflows but stored for agent workflows.</param>
        /// <returns>The chained action node for further fluent chaining.</returns>
        public IWorkflowAction Then(string name, IWorkflowAction action, FlowStatus[] runAfterStatus = null)
        {
            action.Name = !string.IsNullOrEmpty(name)
                ? name
                : !string.IsNullOrEmpty(action.Name)
                    ? action.Name
                    : Utility.GetUniqueActionName();
            action.ChainRoot = this;
            this.Children.Add(action);
            return action;
        }
    }
}
