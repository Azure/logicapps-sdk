// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// The nested flow action allows calling a workflow within another workflow.
    /// </summary>
    public class NestedWorkflowAction : WorkflowActionBase
    {
        /// <summary>
        /// Gets the reference name of the workflow to be invoked.
        /// </summary>
        public string WorkflowReferenceName { get; }

        /// <summary>
        /// Gets or sets the headers for the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public object Headers { get; set; }

        /// <summary>
        /// Gets or sets the body of the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public object RequestBody { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NestedWorkflowAction"/> class.
        /// </summary>
        /// <param name="workflowReferenceName">The reference name of the workflow to call.</param>
        /// <param name="requestBody">The request body (optional).</param>
        /// <param name="headers">The request headers (optional).</param>
        internal NestedWorkflowAction(
            string workflowReferenceName,
            object requestBody = null,
            object headers = null)
        {
            this.WorkflowReferenceName = workflowReferenceName;
            this.RequestBody = requestBody;
            this.Headers = headers;
        }

        /// <summary>
        /// Gets the action definition for this nested workflow action.
        /// </summary>
        /// <returns>A <see cref="FlowTemplateAction"/> representing the nested workflow call.</returns>
        /// <param name="flowName">The flow name.</param>
        /// <param name="flowKind">The flow kind.</param>
        public override FlowTemplateAction GetActionDefinition(string flowName, FlowKind? flowKind = null)
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
    }

    /// <summary>
    /// Represents a nested workflow action with a strongly-typed output body.
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the action.</typeparam>
    public class NestedWorkflowAction<T> : NestedWorkflowAction, IBodyWorkflowAction<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NestedWorkflowAction{T}"/> class.
        /// </summary>
        /// <param name="workflowReferenceName">The reference name of the workflow to call.</param>
        /// <param name="requestBody">The request body (optional).</param>
        /// <param name="headers">The request headers (optional).</param>
        internal NestedWorkflowAction(
            string workflowReferenceName,
            object requestBody = null,
            object headers = null)
            : base(workflowReferenceName, requestBody, headers)
        {
        }

        /// <summary>
        /// Gets the strongly-typed body of the action.
        /// </summary>
        public T Body { get; private set; }
    }
}
