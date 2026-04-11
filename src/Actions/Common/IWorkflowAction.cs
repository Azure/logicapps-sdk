// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents a workflow action as a graph node with support for fluent chaining.
    /// </summary>
    public interface IWorkflowAction : IWorkflowNode
    {
        /// <summary>
        /// Gets the action definition as a FlowTemplateAction.
        /// </summary>
        /// <param name="flowName">The flow name.</param>
        FlowTemplateAction GetActionDefinition(string flowName);

        /// <summary>
        /// Gets the run-after configuration mapping parent action names to required statuses.
        /// </summary>
        Dictionary<string, FlowStatus[]> RunAfterConfig { get; }

        /// <summary>
        /// Gets or sets the root node of the chain this action belongs to.
        /// When actions are connected via <see cref="IWorkflowNode.Then(IWorkflowAction, FlowStatus[])"/>,
        /// the chain root tracks the first node in the chain (a trigger or an action) so that
        /// the entire graph can be recovered from any node in the chain.
        /// </summary>
        IWorkflowNode ChainRoot { get; set; }
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
