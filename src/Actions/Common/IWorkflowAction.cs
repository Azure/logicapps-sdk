// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// IWorkfowAction interface defines the contract for workflow actions.
    /// </summary>
    public interface IWorkflowAction : INamedObject
    {
        /// <summary>
        /// Gets the action definition as a FlowTemplateAction.
        /// </summary>
        FlowTemplateAction GetActionDefinition();
    }

    /// <summary>
    /// Extends IWorkflowAction to support actions with strongly-typed output bodies.
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the action.</typeparam>
    public interface IOutputWorkflowAction<T> : IWorkflowAction
    {
        /// <summary>
        /// Gets the body of the action.
        /// </summary>
        T Body { get; }
    }
}
