// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The nested flow action allows calling a workflow within another workflow.
    /// </summary>
    public class NestedWorkFlowAction(string workflowReferenceName, object requestBody = null, Dictionary<string, string> headers = null) : IWorkflowAction
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the reference name of the workflow to be invoked.
        /// </summary>
        public string WorkflowReferenceName { get; } = workflowReferenceName;

        /// <summary>
        /// Gets or sets the headers for the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, string> Headers { get; set; } = headers;

        /// <summary>
        /// Gets or sets the body of the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public object RequestBody { get; set; } = requestBody;

        /// <summary>
        /// Gets the action definition for this nested workflow action.
        /// </summary>
        /// <returns>A <see cref="FlowTemplateAction"/> representing the nested workflow call.</returns>
        public FlowTemplateAction GetActionDefinition()
        {
            return new FlowTemplateAction
            {
                Type = FlowTemplateOperationType.Workflow,
                Inputs = new WorkflowActionInput
                {
                    Host = new WorkflowActionInputHost
                    {
                        Workflow = new FlowReference
                        {
                            id = this.WorkflowReferenceName,
                        },
                    },
                    Headers = this.Headers,
                    Body = this.RequestBody?.ToJToken(),
                }
            };
        }

        /// <summary>
        /// Sets the name of the nested flow action.
        /// </summary>
        /// <param name="name"></param>
        public void WithName(string name)
        {
            this.Name = name;
        }
    }

    /// <summary>
    /// Represents a nested workflow action with a strongly-typed output body.
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the action.</typeparam>
    public class NestedWorkFlowAction<T> : NestedWorkFlowAction, IOutputWorkflowAction<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NestedWorkFlowAction{T}"/> class.
        /// </summary>
        /// <param name="workflowReferenceName">The reference name of the workflow to call.</param>
        /// <param name="requestBody">The request body (optional).</param>
        /// <param name="headers">The request headers (optional).</param>
        public NestedWorkFlowAction(
            string workflowReferenceName,
            object requestBody = null,
            Dictionary<string, string> headers = null)
            : base(workflowReferenceName, requestBody, headers)
        {
        }

        /// <summary>
        /// Gets the strongly-typed body of the action.
        /// </summary>
        public T Body { get; private set; }
    }
}
