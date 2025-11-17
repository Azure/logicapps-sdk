// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Represents an action that performs an API connection operation in a workflow.
    /// </summary>
    public class ApiConnectionAction(ApiConnectionActionInput apiConnectionActionInput) : IWorkflowAction
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the action definition for this API connection action.
        /// </summary>
        /// <returns>
        /// A <see cref="FlowTemplateAction"/> representing the API connection operation to be performed in the workflow.
        /// </returns>
        public FlowTemplateAction GetActionDefinition()
        {
            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.ApiConnection,
                Inputs = apiConnectionActionInput,
            };
        }

        /// <summary>
        /// Adds a name.
        /// </summary>
        /// <param name="name"></param>
        public void WithName(string name)
        {
            this.Name = name;
        }
    }

    /// <summary>
    /// Represents an API connection action with a strongly-typed output body.
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the action.</typeparam>
    public class ApiConnectionAction<T> : ApiConnectionAction, IOutputWorkflowAction<T>
    {
        public ApiConnectionAction(ApiConnectionActionInput apiConnectionActionInput)
            : base(apiConnectionActionInput)
        {
        }

        public T Body { get; private set; }
    }
}
