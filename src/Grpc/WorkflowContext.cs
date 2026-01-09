// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Threading.Tasks;

    /// <summary>
    /// The workflow context.
    /// </summary>
    public abstract class WorkflowContext
    {
        /// <summary>
        /// Get action results.
        /// </summary>
        /// <param name="actionName">The action name.</param>
        public abstract Task<WorkflowOperationResult> GetActionResults(string actionName);

        /// <summary>
        /// Get trigger results.
        /// </summary>
        public abstract Task<WorkflowOperationResult> GetTriggerResults();
    }
}
