// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Provides fluent extension methods for configuring <see cref="IWorkflowOperation"/> instances.
    /// </summary>
    public static class WorkflowOperationExtensions
    {
        /// <summary>
        /// Assigns a human-readable name to this operation and returns the same instance for fluent chaining.
        /// The name is used as the key in the generated workflow definition and must be unique within a workflow.
        /// </summary>
        /// <typeparam name="T">The operation type. Must implement <see cref="IWorkflowOperation"/>.</typeparam>
        /// <param name="operation">The workflow operation to name.</param>
        /// <param name="name">
        /// The name to assign. This becomes the operation's identifier in the workflow definition JSON.
        /// Use descriptive names (e.g., <c>"ParseInput"</c>, <c>"SendNotification"</c>) for readability.
        /// </param>
        /// <returns>The same <paramref name="operation"/> instance, enabling fluent method chaining.</returns>
        /// <example>
        /// <code>
        /// var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "Hello").WithName("Greeting");
        /// var response = WorkflowActions.BuiltIn.Response(responseBody: () => $"{compose.Output}").WithName("Reply");
        /// </code>
        /// </example>
        public static T WithName<T>(this T operation, string name) where T : IWorkflowOperation
        {
            operation.Name = name;
            return operation;
        }
    }
}
