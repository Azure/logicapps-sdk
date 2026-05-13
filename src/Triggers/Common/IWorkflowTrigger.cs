// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents the entry-point trigger that initiates a workflow execution. Every workflow
    /// must have exactly one trigger, which serves as the root node of the workflow graph.
    /// When the trigger fires (e.g., an HTTP request is received, a timer elapses), the
    /// workflow engine executes the actions chained after it.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Triggers are created using the factory methods on <see cref="WorkflowBuiltInTriggers"/>
    /// (accessed via <c>WorkflowTriggers.BuiltIn</c>) or <see cref="WorkflowManagedTriggers"/>
    /// (accessed via <c>WorkflowTriggers.Managed</c>).
    /// </para>
    /// <para>
    /// After creating a trigger, chain actions using <c>.Then()</c> and register the workflow
    /// with <see cref="WorkflowFactory"/>. Note that <c>.Then()</c> overloads accepting
    /// <see cref="FlowStatus"/>[] or <see cref="RunAfter"/>[] are not valid on the first action
    /// after a trigger, since run-after conditions only apply between actions.
    /// </para>
    /// <para>
    /// For triggers that produce typed output, use the derived interfaces
    /// <see cref="IOutputWorkflowTrigger{T}"/> (for structured output) or
    /// <see cref="IBodyWorkflowTrigger{T}"/> (for body content).
    /// </para>
    /// </remarks>
    /// <seealso cref="IOutputWorkflowTrigger{T}"/>
    /// <seealso cref="IBodyWorkflowTrigger{T}"/>
    /// <seealso cref="WorkflowTriggerBase"/>
    /// <seealso cref="WorkflowFactory"/>
    public interface IWorkflowTrigger : IWorkflowOperation
    {
        /// <summary>
        /// Generates the <see cref="FlowTemplateTrigger"/> definition for this trigger, which is
        /// serialized into the workflow's JSON definition.
        /// </summary>
        /// <returns>A <see cref="FlowTemplateTrigger"/> representing the trigger's type, inputs, and configuration.</returns>
        FlowTemplateTrigger GetTriggerDefinition();
    }

    /// <summary>
    /// Represents a workflow trigger that produces strongly-typed structured output, allowing
    /// downstream actions to reference trigger output values using typed expression properties.
    /// </summary>
    /// <typeparam name="T">The type of the structured output produced by the trigger at runtime.</typeparam>
    /// <example>
    /// Access the HTTP trigger's output in a downstream Compose action:
    /// <code>
    /// var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
    /// var compose = WorkflowActions.BuiltIn.Compose(
    ///     inputs: () => $"Received: {trigger.TriggerOutput.Body}").WithName("LogInput");
    /// trigger.Then(compose);
    /// </code>
    /// </example>
    public interface IOutputWorkflowTrigger<T> : IWorkflowTrigger
    {
        /// <summary>
        /// Gets the strongly-typed output of this trigger. Use this property in expression lambdas
        /// to build workflow expressions that reference the trigger's output at runtime.
        /// </summary>
        T TriggerOutput { get; }
    }

    /// <summary>
    /// Represents a workflow trigger that produces a strongly-typed body output, typically used
    /// for triggers where the incoming payload has a body (e.g., HTTP request triggers).
    /// </summary>
    /// <typeparam name="T">The type of the body content produced by the trigger at runtime.</typeparam>
    public interface IBodyWorkflowTrigger<T> : IWorkflowTrigger
    {
        /// <summary>
        /// Gets the strongly-typed body output of this trigger. Use this property in expression lambdas
        /// to build workflow expressions that reference the trigger's body content at runtime.
        /// </summary>
        T TriggerBody { get; }
    }
}
