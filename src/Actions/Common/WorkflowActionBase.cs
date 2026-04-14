// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Base class for workflow action nodes. Extends <see cref="WorkflowChain"/> for chain tracking
    /// and implements <see cref="IWorkflowAction"/> for action-specific behavior.
    /// </summary>
    public abstract class WorkflowActionBase : WorkflowChain, IWorkflowAction
    {
        /// <summary>
        /// Gets or sets the name of the action.
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// Gets the child action nodes that run after this action.
        /// </summary>
        public List<IWorkflowAction> Children { get; } = new List<IWorkflowAction>();

        /// <summary>
        /// Gets the action definition as a FlowTemplateAction.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        public abstract FlowTemplateAction GetActionDefinition(string flowName);

        /// <summary>
        /// Gets the run-after configuration mapping parent action names to required statuses.
        /// </summary>
        public Dictionary<string, FlowStatus[]> RunAfterConfig { get; } = new Dictionary<string, FlowStatus[]>();

        /// <summary>
        /// Wires a child action to this action's graph, setting run-after configuration.
        /// </summary>
        protected override WorkflowChain AppendAction(IWorkflowAction action, IWorkflowNode end, FlowStatus[] runAfterStatus)
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                this.Name = Utility.GetUniqueActionName();
            }

            action.RunAfterConfig[this.Name] = runAfterStatus ?? new[] { FlowStatus.Succeeded };
            this.Children.Add(action);
            return new WorkflowChain(this, end);
        }
    }
}
