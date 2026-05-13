// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Base class for workflow trigger nodes. Extends <see cref="OperationChain"/> for chain tracking
    /// and implements <see cref="IWorkflowTrigger"/> for trigger-specific behavior.
    /// </summary>
    public abstract class WorkflowTriggerBase : IWorkflowTrigger
    {
        /// <summary>
        /// Gets or sets the name of the trigger.
        /// </summary>
        public string Name { get; set; } = Utility.GetUniqueOperationName(isTrigger: true);

        /// <summary>
        /// Gets the child action nodes that run after this trigger.
        /// </summary>
        public List<IWorkflowAction> Children { get; } = new List<IWorkflowAction>();

        /// <summary>
        /// Gets the trigger definition for the workflow.
        /// </summary>
        public abstract FlowTemplateTrigger GetTriggerDefinition();

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action), "Action cannot be null.");
            }
            this.Children.Add(action);
            return new OperationChain(this, action);
        }

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action, FlowStatus[] runAfter)
        {
            throw new InvalidOperationException("RunAfter configuration can't be specified on first action after a trigger.");
        }

        /// <inheritdoc/>
        public OperationChain Then(IWorkflowAction action, RunAfter[] runAfter)
        {
            throw new InvalidOperationException("RunAfter configuration can't be specified on first action after a trigger.");
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
    }
}
