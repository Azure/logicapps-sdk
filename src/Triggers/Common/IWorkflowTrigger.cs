// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents a workflow trigger node.
    /// </summary>
    public interface IWorkflowTrigger : IWorkflowOperation
    {
        /// <summary>
        /// Gets the trigger definition for the workflow.
        /// </summary>
        /// <returns>
        /// A <see cref="FlowTemplateTrigger"/> representing the trigger configuration.
        /// </returns>
        FlowTemplateTrigger GetTriggerDefinition();
    }

    /// <summary>
    /// Represents a workflow trigger with strongly-typed output.
    /// </summary>
    /// <typeparam name="T">The type of the trigger output.</typeparam>
    public interface IOutputWorkflowTrigger<T> : IWorkflowTrigger
    {
        /// <summary>
        /// Gets the output parameters for the trigger.
        /// </summary>
        T TriggerOutput { get; }
    }

    /// <summary>
    /// Represents a workflow trigger with strongly-typed body output.
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the trigger.</typeparam>
    public interface IBodyWorkflowTrigger<T> : IWorkflowTrigger
    {
        /// <summary>
        /// Gets the body of the trigger.
        /// </summary>
        T TriggerBody { get; }
    }
}
