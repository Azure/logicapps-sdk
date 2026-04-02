// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents a workflow action as a graph node with support for fluent chaining.
    /// </summary>
    public interface IWorkflowAction
    {
        /// <summary>
        /// Gets the action definition as a FlowTemplateAction.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        FlowTemplateAction GetActionDefinition(string flowName);

        /// <summary>
        /// Gets or sets the name of the action.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets the child action nodes that run after this node.
        /// </summary>
        List<IWorkflowAction> Children { get; }

        /// <summary>
        /// Gets the run-after configuration mapping parent action names to required statuses.
        /// </summary>
        Dictionary<string, FlowStatus[]> RunAfterConfig { get; }

        /// <summary>
        /// Chains a subsequent action node to run after this node.
        /// </summary>
        /// <param name="action">The action node to chain.</param>
        /// <param name="runAfterStatus">The required statuses for the run-after dependency. Defaults to Succeeded.</param>
        /// <returns>The chained action node for further fluent chaining.</returns>
        IWorkflowAction Then(IWorkflowAction action, FlowStatus[] runAfterStatus = null);
    }

    /// <summary>
    /// Extends IWorkflowAction to support actions with strongly-typed bodies for managed connectors.
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the action.</typeparam>
    public interface IBodyWorkflowAction<T> : IWorkflowAction
    {
        /// <summary>
        /// Gets the body of the action.
        /// </summary>
        T Body { get; }
    }

    /// <summary>
    /// Extends IWorkflowAction to support actions with strongly-typed output.
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the action.</typeparam>
    public interface IOutputWorkflowAction<T> : IWorkflowAction
    {
        /// <summary>
        /// Gets the output of the action.
        /// </summary>
        T Output { get; }
    }
}
