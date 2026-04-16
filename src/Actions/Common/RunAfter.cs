// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Run after specification for workflow actions.
    /// </summary>
    public class RunAfter
    {
        /// <summary>
        /// Gets or sets the name of the action that this action should run after.
        /// </summary>
        public IWorkflowAction Action { get; set; }

        /// <summary>
        /// Gets or sets the condition under which this action should run.
        /// </summary>
        public FlowStatus[] Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAfter"/> class.
        /// </summary>
        /// <param name="chain">The chain to run after.</param>
        /// <param name="status">The status to run after.</param>
        public RunAfter(WorkflowChain chain, FlowStatus status)
        {
            if (chain == null)
            {
                throw new ArgumentNullException(nameof(chain));
            }

            if (chain.Ends.Count > 1)
            {
                throw new ArgumentException("The chain must have only one end action to specify a run after condition.", nameof(chain));
            }

            var action = chain.Ends.First() as IWorkflowAction ?? throw new ArgumentException("The end of the chain must be an IWorkflowAction.", nameof(chain));
            this.Action = action;
            this.Status = new[] { status };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunAfter"/> class.
        /// </summary>
        /// <param name="chain">The chain to run after.</param>
        /// <param name="statuses">The statuses to run after.</param>
        public RunAfter(WorkflowChain chain, FlowStatus[] statuses)
        {
            if (chain == null)
            {
                throw new ArgumentNullException(nameof(chain));
            }

            if (chain.Ends.Count > 1)
            {
                throw new ArgumentException("The chain must have only one end action to specify a run after condition.", nameof(chain));
            }

            var action = chain.Ends.First() as IWorkflowAction ?? throw new ArgumentException("The end of the chain must be an IWorkflowAction.", nameof(chain));
            this.Action = action;
            this.Status = statuses;
        }
    }
}
