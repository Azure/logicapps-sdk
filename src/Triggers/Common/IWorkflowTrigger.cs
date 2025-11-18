// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents an object with a name property and a method to set the name.
    /// </summary>
    public interface INamedObject
    {
        /// <summary>
        /// Gets the name of the object.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Sets the name of the object.
        /// </summary>
        /// <param name="name">The name to assign.</param>
        void WithName(string name);
    }

    /// <summary>
    /// Represents a workflow trigger with a name and a method to get its trigger definition.
    /// </summary>
    public interface IWorkflowTrigger : INamedObject
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
    /// Represents a workflow trigger that produces a strongly-typed output.
    /// </summary>
    /// <typeparam name="T">The type of the trigger output.</typeparam>
    public interface IOutputWorkflowTrigger<T> : IWorkflowTrigger
    {
        /// <summary>
        /// Gets the output parameters for the trigger.
        /// </summary>
        T TriggerOutput { get; }

        void WithRecurrence(FlowRecurrence recurrence);
    }
}
