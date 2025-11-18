// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Defines a builder interface for creating agent tools with configurable parameters and workflow actions.
    /// </summary>
    /// <typeparam name="T">The type of the parameters used to configure the agent tool.</typeparam>
    public interface IAgentToolBuilder<T> : IActionBuilder
    {
        /// <summary>
        /// The parameters used to configure the agent tool.
        /// </summary>
        T Parameters { get; }

        /// <summary>
        /// Gets the list of the workflow actions in a branch.
        /// </summary>
        (string, FlowTemplateActionToolBranch) GetFlowTemplateActionToolBranch();
    }

    /// <summary>
    /// IAction builder interface to add actions to a workflow.
    /// </summary>
    public interface IActionBuilder
    {
        /// <summary>
        /// Adds a previously created action to the workflow.
        /// </summary>
        /// <param name="action">The previously created workflow action.</param>
        /// <param name="actionName">The action name.</param>
        /// <param name="runAfterSpecifications">The runtime after specifications.</param>
        void AddAction(IWorkflowAction action, string actionName = null, params RunAfterSpecification[] runAfterSpecifications);
    }
}

