// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Workflow actions entry point providing access to built-in and managed connector actions.
    /// </summary>
    public static class WorkflowActions
    {
        /// <summary>
        /// Built-in actions for workflow agents.
        /// </summary>
        public static WorkflowBuiltInActions BuiltIn = new WorkflowBuiltInActions();

        /// <summary>
        /// Actions provided by managed connectors.
        /// </summary>
        public static WorkflowManagedActions ManagedConnectors = new WorkflowManagedActions();
    }
}
