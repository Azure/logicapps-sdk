// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Base class for workflow action nodes. Extends <see cref="OperationChain"/> for chain tracking
    /// and implements <see cref="IWorkflowAction"/> for action-specific behavior.
    /// </summary>
    public abstract class WorkflowActionBase : OperationChain, IWorkflowAction
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

        /// <inheritdoc/>
        public override OperationChain Then(IWorkflowAction action, string name = null)
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                this.Name = Utility.GetUniqueActionName();
            }

            action.Name = name ?? Utility.GetUniqueActionName();
            action.RunAfterConfig[this.Name] = new[] { FlowStatus.Succeeded };
            this.Children.Add(action);

            return new OperationChain(this.Start, action);
        }

        /// <inheritdoc/>
        public override OperationChain Then(IWorkflowAction action, FlowStatus[] runAfter, string name = null)
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                this.Name = Utility.GetUniqueActionName();
            }

            action.Name = name ?? Utility.GetUniqueActionName();
            action.RunAfterConfig[this.Name] = runAfter ?? new[] { FlowStatus.Succeeded };
            this.Children.Add(action);

            return new OperationChain(this.Start, action);
        }

        /// <inheritdoc/>
        public override OperationChain Then(IWorkflowAction action, RunAfter[] runAfter, string name = null)
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                this.Name = Utility.GetUniqueActionName();
            }

            action.Name = name ?? Utility.GetUniqueActionName();
            foreach (var ra in runAfter)
            {
                if (ra.Action == null || string.IsNullOrEmpty(ra.Action.Name))
                {
                    throw new InvalidOperationException($"Invalid action '{ra.Action?.Name}' in RunAfter configuration.");
                }
                action.RunAfterConfig[ra.Action.Name] = ra.Status ?? new[] { FlowStatus.Succeeded };
            }
            this.Children.Add(action);

            return new OperationChain(this.Start, action);
        }
    }
}
