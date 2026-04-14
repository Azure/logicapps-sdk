// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Base class for workflow trigger nodes. Extends <see cref="WorkflowChain"/> for chain tracking
    /// and implements <see cref="IWorkflowTrigger"/> for trigger-specific behavior.
    /// </summary>
    public abstract class WorkflowTriggerBase : WorkflowChain, IWorkflowTrigger
    {
        /// <summary>
        /// Gets or sets the name of the trigger.
        /// </summary>
        public abstract string Name { get; set; }

        /// <summary>
        /// Gets the child action nodes that run after this trigger.
        /// </summary>
        public List<IWorkflowAction> Children { get; } = new List<IWorkflowAction>();

        /// <summary>
        /// Gets the trigger definition for the workflow.
        /// </summary>
        public abstract FlowTemplateTrigger GetTriggerDefinition();

        /// <summary>
        /// Wires a child action to this trigger's graph.
        /// </summary>
        protected override WorkflowChain AppendAction(IWorkflowAction action, IWorkflowNode end, FlowStatus[] runAfterStatus)
        {
            this.Children.Add(action);
            return new WorkflowChain(this, end);
        }
    }
}
