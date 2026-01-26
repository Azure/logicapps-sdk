// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents a workflow trigger with a name and a method to get its trigger definition.
    /// </summary>
    public interface IWorkflowTrigger
    {
        /// <summary>
        /// Gets the trigger definition for the workflow.
        /// </summary>
        /// <returns>
        /// A <see cref="FlowTemplateTrigger"/> representing the trigger configuration.
        /// </returns>
        FlowTemplateTrigger GetTriggerDefinition();

        /// <summary>
        /// Gets the name of the object.
        /// </summary>
        string Name { get; set; }
    }

    /// <summary>
    /// Represents a workflow trigger that produces a strongly-typed output.
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
    /// Extends IWorkflowAction to support actions with strongly-typed bodies for managed connectors.
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
