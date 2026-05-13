// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents an action step within a workflow. Actions are the individual units of work
    /// that execute after a trigger fires or after preceding actions complete. Each action
    /// produces a workflow definition fragment and can be conditionally executed based on the
    /// completion status of its predecessors via <see cref="RunAfterConfig"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Actions are created using the factory methods on <see cref="WorkflowBuiltInActions"/>
    /// (accessed via <c>WorkflowActions.BuiltIn</c>) or <see cref="WorkflowManagedActions"/>
    /// (accessed via <c>WorkflowActions.Managed</c>).
    /// </para>
    /// <para>
    /// For actions that produce typed output, use the derived interfaces
    /// <see cref="IBodyWorkflowAction{T}"/> (for HTTP-style body content) or
    /// <see cref="IOutputWorkflowAction{T}"/> (for structured output values like Compose results).
    /// These typed variants allow downstream actions to reference the output using strongly-typed
    /// expression properties such as <c>action.Body</c> or <c>action.Output</c>.
    /// </para>
    /// </remarks>
    /// <seealso cref="IBodyWorkflowAction{T}"/>
    /// <seealso cref="IOutputWorkflowAction{T}"/>
    /// <seealso cref="WorkflowActionBase"/>
    /// <seealso cref="RunAfter"/>
    public interface IWorkflowAction : IWorkflowOperation
    {
        /// <summary>
        /// Generates the <see cref="FlowTemplateAction"/> definition for this action, which is
        /// serialized into the workflow's JSON definition.
        /// </summary>
        /// <param name="flowName">The name of the workflow this action belongs to.</param>
        /// <param name="flowKind">The kind of workflow (Stateful, Stateless, or Agent). Defaults to <see langword="null"/>.</param>
        /// <returns>A <see cref="FlowTemplateAction"/> containing the action's type, inputs, and configuration.</returns>
        FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null);

        /// <summary>
        /// Gets the run-after configuration that maps predecessor action names to the
        /// <see cref="FlowStatus"/> values required for this action to execute.
        /// This configuration is populated automatically by <c>.Then()</c> calls and controls
        /// the conditional execution edges in the workflow graph.
        /// </summary>
        Dictionary<string, FlowStatus[]> RunAfterConfig { get; }
    }

    /// <summary>
    /// Represents a workflow action that produces a strongly-typed body output, typically used
    /// for HTTP-style actions where the response has a body payload (e.g., HTTP actions,
    /// nested workflow calls, or custom code actions).
    /// </summary>
    /// <typeparam name="T">The type of the body content returned by the action at runtime.</typeparam>
    /// <remarks>
    /// Use the <see cref="Body"/> property in expression lambdas passed to downstream actions
    /// to reference this action's output. The SDK converts these references into workflow
    /// expressions at build time.
    /// </remarks>
    /// <example>
    /// Reference the body of an HTTP action in a subsequent Compose action:
    /// <code>
    /// var httpAction = WorkflowActions.BuiltIn.HttpAction(
    ///     uri: () => new Uri("https://api.example.com/data"),
    ///     method: () => HttpMethod.Get).WithName("FetchData");
    ///
    /// var compose = WorkflowActions.BuiltIn.Compose(inputs: () => $"Result: {httpAction.Body}").WithName("FormatResult");
    /// </code>
    /// </example>
    public interface IBodyWorkflowAction<T> : IWorkflowAction
    {
        /// <summary>
        /// Gets the strongly-typed body output of this action. Use this property in expression lambdas
        /// to build workflow expressions that reference this action's body content at runtime.
        /// </summary>
        T Body { get; }
    }

    /// <summary>
    /// Represents a workflow action that produces a strongly-typed structured output, typically used
    /// for data-transformation actions such as Compose where the full output is a single typed value.
    /// </summary>
    /// <typeparam name="T">The type of the output value returned by the action at runtime.</typeparam>
    /// <remarks>
    /// Use the <see cref="Output"/> property in expression lambdas passed to downstream actions
    /// to reference this action's output. The SDK converts these references into workflow
    /// expressions at build time.
    /// </remarks>
    /// <example>
    /// Reference a Compose action's output in a Response action:
    /// <code>
    /// var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "Hello, World!").WithName("Greeting");
    /// var response = WorkflowActions.BuiltIn.Response(responseBody: () => $"{compose.Output}").WithName("Reply");
    /// </code>
    /// </example>
    public interface IOutputWorkflowAction<T> : IWorkflowAction
    {
        /// <summary>
        /// Gets the strongly-typed output of this action. Use this property in expression lambdas
        /// to build workflow expressions that reference this action's output value at runtime.
        /// </summary>
        T Output { get; }
    }
}
