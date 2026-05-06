// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Net;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The nested flow action allows calling a workflow within another workflow.
    /// </summary>
    public class ResponseAction(HttpStatusCode statusCode = HttpStatusCode.OK, object responseBody = null, Dictionary<string, string> headers = null, JToken schema = null) : WorkflowActionBase
    {
        /// <summary>
        /// Gets the reference name of the workflow to be invoked.
        /// </summary>
        public HttpStatusCode StatusCode { get; } = statusCode;

        /// <summary>
        /// Gets or sets the headers for the request.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public Dictionary<string, string> Headers { get; set; } = headers;

        /// <summary>
        /// Gets or sets the body of the request.
        /// </summary>
        [JsonProperty(Required = Required.Default, PropertyName = "requestBody")]
        public object ResponseBody { get; set; } = responseBody;

        /// <summary>
        /// Gets or sets the JSON schema of the response.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public JToken Schema { get; set; } = schema;

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
                Type = FlowTemplateOperationType.Response,
                Inputs = new ResponseActionInput
                {
                    StatusCode = (int)this.StatusCode,
                    Headers = this.Headers,
                    Body = this.ResponseBody?.ToJToken(),
                    Schema = this.Schema,
                },
            };
        }
    }

    /// <summary>
    /// Represents a response action with a strongly-typed output body.
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the action.</typeparam>
    public class ResponseAction<T> : ResponseAction, IBodyWorkflowAction<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAction{T}"/> class.
        /// </summary>
        /// <param name="statusCode">The status code.</param>
        /// <param name="responseBody">The response body (optional).</param>
        /// <param name="headers">The request headers (optional).</param>
        /// <param name="schema">The JSON schema of the response (optional).</param>
        public ResponseAction(HttpStatusCode statusCode = HttpStatusCode.OK, object responseBody = null, Dictionary<string, string> headers = null, JToken schema = null)
            : base(statusCode, responseBody, headers, schema)
        {
        }

        /// <summary>
        /// Gets the strongly-typed body of the action.
        /// </summary>
        public T Body { get; private set; }

        /// <summary>
        /// Sets the action name.
        /// </summary>
        /// <param name="name">The action name.</param>
        public IBodyWorkflowAction<T> WithName(string name)
        {
            this.Name = name;
            return this;
        }
    }
}
