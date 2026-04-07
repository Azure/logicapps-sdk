// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents a workflow trigger as the root node of a workflow graph.
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
        /// Gets or sets the name of the trigger.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets the child action nodes that run after this trigger.
        /// </summary>
        List<IWorkflowAction> Children { get; }

        /// <summary>
        /// Chains a subsequent action node to run after this trigger.
        /// </summary>
        /// <param name="action">The action node to chain.</param>
        /// <param name="runAfterStatus">The required statuses for the run-after dependency. Not used for trigger-to-action edges in stateful/stateless workflows.</param>
        /// <returns>The chained action node for further fluent chaining.</returns>
        IWorkflowAction Then(IWorkflowAction action, FlowStatus[] runAfterStatus = null);

        /// <summary>
        /// Chains a subsequent action node to run after this trigger.
        /// </summary>
        /// <param name="name">The name of the action.</param>
        /// <param name="action">The action node to chain.</param>
        /// <param name="runAfterStatus">The required statuses for the run-after dependency. Not used for trigger-to-action edges in stateful/stateless workflows.</param>
        /// <returns>The chained action node for further fluent chaining.</returns>
        IWorkflowAction Then(string name, IWorkflowAction action, FlowStatus[] runAfterStatus = null);
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
    /// Represents a workflow trigger with strongly-typed body output for managed connectors.
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
