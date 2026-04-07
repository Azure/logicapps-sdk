// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// The Terminate action stops workflow execution with a specified status.
    /// </summary>
    public class TerminateAction : WorkflowActionBase
    {
        private readonly string status;
        private readonly string message;

        /// <summary>
        /// Initializes a new instance of the <see cref="TerminateAction"/> class.
        /// </summary>
        /// <param name="status">The termination status string (e.g., Failed, Succeeded, Cancelled).</param>
        /// <param name="message">The termination message (optional).</param>
        public TerminateAction(string status, string message = null)
        {
            this.status = status;
            this.message = message;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Gets the action definition for this Terminate action.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName)
        {
            var input = new TerminateActionInput
            {
                RunStatus = this.status,
            };

            if (!string.IsNullOrEmpty(this.message))
            {
                input.RunError = new TerminateRunError
                {
                    Message = this.message,
                };
            }

            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.Terminate,
                Inputs = input,
            };
        }
    }
}
