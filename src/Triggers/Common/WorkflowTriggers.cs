// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Built-in triggers for workflow.
    /// </summary>
    public static class WorkflowTriggers
    {
        /// <summary>
        /// Built-in workflow triggers.
        /// </summary>
        public static WorkflowBuiltInTriggers BuiltIn = new WorkflowBuiltInTriggers();

        /// <summary>
        /// Triggers provided by managed connectors.
        /// </summary>
        public static WorkflowManagedTriggers Managed = new WorkflowManagedTriggers();
    }
}
