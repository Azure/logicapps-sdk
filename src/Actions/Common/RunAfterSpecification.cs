// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Run after specification for workflow actions.
    /// </summary>
    public class RunAfterSpecification
    {
        /// <summary>
        /// Gets or sets the name of the action that this action should run after.
        /// </summary>
        public IWorkflowAction Action { get; set; }

        /// <summary>
        /// Gets or sets the condition under which this action should run.
        /// </summary>
        public FlowStatus[] Status { get; set; }
    }
}
