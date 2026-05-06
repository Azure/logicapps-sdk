// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

using Newtonsoft.Json.Linq;

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

        /// <summary>
        /// Sets the action name.
        /// </summary>
        /// <param name="name">The action name.</param>
        IBodyWorkflowAction<T> WithName(string name);
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

        /// <summary>
        /// Sets the action name.
        /// </summary>
        /// <param name="name">The action name.</param>
        IOutputWorkflowAction<T> WithName(string name);
    }

    /// <summary>
    /// Extends IWorkflowAction to support variable actions.
    /// </summary>
    public interface IVariableWorkflowAction : IWorkflowAction
    {
        /// <summary>
        /// Gets the variable value.
        /// </summary>
        JToken Value { get; }

        /// <summary>
        /// Gets the name of the variable.
        /// </summary>
        string VariableName { get; }

        /// <summary>
        /// Sets the action name.
        /// </summary>
        /// <param name="name">The action name.</param>
        IVariableWorkflowAction WithName(string name);
    }
}
