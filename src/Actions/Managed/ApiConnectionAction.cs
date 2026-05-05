// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents an action that performs an API connection operation in a workflow.
    /// </summary>
    public class ApiConnectionAction(ApiConnectionActionInput apiConnectionActionInput) : WorkflowActionBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public override string Name { get; set; }

        /// <summary>
        /// Gets the action definition for this API connection action.
        /// </summary>
        /// <returns>
        /// A <see cref="FlowTemplateAction"/> representing the API connection operation to be performed in the workflow.
        /// </returns>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null)
        {
            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.ApiConnection,
                Inputs = apiConnectionActionInput,
            };
        }
    }

    /// <summary>
    /// Represents an API connection action with a strongly-typed output body.
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the action.</typeparam>
    public class ApiConnectionAction<T> : ApiConnectionAction, IBodyWorkflowAction<T>
    {
        public ApiConnectionAction(ApiConnectionActionInput apiConnectionActionInput)
            : base(apiConnectionActionInput)
        {
        }

        public T Body { get; private set; }
    }
}
