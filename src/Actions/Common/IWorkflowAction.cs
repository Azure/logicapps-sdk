// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents a workflow action as a graph node with support for fluent chaining.
    /// </summary>
    public interface IWorkflowAction : IWorkflowOperation
    {
        /// <summary>
        /// Gets the action definition as a FlowTemplateAction.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null);

        /// <summary>
        /// Gets the run-after configuration mapping parent action names to required statuses.
        /// </summary>
        Dictionary<string, FlowStatus[]> RunAfterConfig { get; }
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
