// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Base class for workflow trigger nodes. Extends <see cref="OperationChain"/> for chain tracking
    /// and implements <see cref="IWorkflowTrigger"/> for trigger-specific behavior.
    /// </summary>
    public abstract class WorkflowTriggerBase : OperationChain, IWorkflowTrigger
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

        /// <inheritdoc/>
        public override OperationChain Then(IWorkflowAction action, string name = null)
        {
            action.Name = name ?? Utility.GetUniqueActionName();
            this.Children.Add(action);

            return new OperationChain(this, action);
        }

        /// <inheritdoc/>
        public override OperationChain Then(IWorkflowAction action, FlowStatus[] runAfter, string name = null)
        {
            throw new NotImplementedException("RunAfter configuration can't be specified on first action after a trigger.");
        }

        /// <inheritdoc/>
        public override OperationChain Then(IWorkflowAction action, RunAfter[] runAfter, string name = null)
        {
            throw new NotImplementedException("RunAfter configuration can't be specified on first action after a trigger.");
        }
    }
}
