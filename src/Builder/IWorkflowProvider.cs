// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Provides workflow definitions for registration with the workflow host.
    /// Implement this interface to define one or more workflows that should be
    /// registered during application startup.
    /// </summary>
    public interface IWorkflowProvider
    {
        /// <summary>
        /// Gets the workflow definitions to register.
        /// </summary>
        /// <returns>An array of workflow definitions to register.</returns>
        FlowPropertiesDefinition[] GetWorkflows();
    }
}
