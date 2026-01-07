// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Interface for building a codeful workflow.
    /// </summary>
    public interface IWorkflowBuilder : IActionBuilder
    {
        /// <summary>
        /// Adds an agent to the workflow.
        /// </summary>
        /// <param name="action">The agent to be added.</param>
        void AddAgent(IWorkflowAction action);

        /// <summary>
        /// Gets the workflow definition.
        /// </summary>
        FlowPropertiesDefinition GetFlowDefinition();

        /// <summary>
        /// The trigger for the workflow.
        /// </summary>
        IWorkflowTrigger Trigger { get; }
        
        /// <summary>
        /// Gets the flow name.
        /// </summary>
        string FlowName { get; }
    }

    /// <summary>
    /// Interface for building a codeful workflow.
    /// </summary>
    public interface IWorkflowBuilder<T> : IWorkflowBuilder where T : class
    {
        /// <summary>
        /// The trigger output for the workflow.
        /// </summary>
        T TriggerOutput { get; }
    }
}

