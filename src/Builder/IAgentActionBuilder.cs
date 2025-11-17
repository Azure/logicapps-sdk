// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Interface for building a Codeful Workflow Agent.
    /// </summary>
    public interface IAgentActionBuilder
    {
        /// <summary>
        /// Adds a workflow action to the workflow.
        /// </summary>
        /// <param name="toolBuilder">An action to build the tool.</param>
        /// <param name="description">The description of the tool.</param>
        /// <param name="parameter">The agent tool parameter.</param>
        IAgentActionBuilder AddTool<T>(Action<IAgentToolBuilder<T>> toolBuilder, string description, T parameter) where T : class;
    }
}
