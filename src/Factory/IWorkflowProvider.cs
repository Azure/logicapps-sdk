// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Provides workflow definitions for registration with the workflow host.
    /// </summary>
    public interface IWorkflowProvider
    {
        /// <summary>
        /// Gets the workflow definitions to register.
        /// </summary>
        /// <returns>An array of workflow definitions to register.</returns>
        FlowDefinition[] GetWorkflows();
    }
}
