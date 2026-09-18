// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The HTTP action to send HTTP requests to external services.
    /// </summary>
    public class HttpAction : WorkflowActionBase
    {
        /// <summary>
        /// Gets the URI of the HTTP request.
        /// </summary>
        public string Uri { get; }

        /// <summary>
        /// Gets the HTTP method to be used for the request.
        /// </summary>
        public string Method { get; }

        /// <summary>
        /// Gets or sets the headers for the request.
        /// </summary>
        public JToken Headers { get; set; }

        /// <summary>
        /// Gets or sets the query parameters for the request.
        /// </summary>
        public JToken Queries { get; set; }

        /// <summary>
        /// Gets or sets the body of the request.
        /// </summary>
        public object RequestBody { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpAction"/> class.
        /// </summary>
        /// <param name="uri">The URI of the HTTP request.</param>
        /// <param name="method">The HTTP method to use for the request.</param>
        /// <param name="requestBody">The request body (optional).</param>
        /// <param name="headers">The request headers (optional).</param>
        /// <param name="queries">The query parameters (optional).</param>
        internal HttpAction(
            string uri,
            string method,
            object requestBody = null,
            JToken headers = null,
            JToken queries = null)
        {
            this.Uri = uri;
            this.Method = method;
            this.RequestBody = requestBody;
            this.Headers = headers;
            this.Queries = queries;
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
                Type = FlowTemplateOperationType.Http,
                Inputs = new HttpActionInput
                {
                    Uri = this.Uri,
                    Headers = this.Headers,
                    Body = this.RequestBody?.ToJToken(),
                    Method = this.Method,
                    Queries = this.Queries,
                },
            };
        }
    }

    /// <summary>
    /// Represents an HTTP action with a strongly-typed output body.
    /// </summary>
    /// <typeparam name="T">The type of the output body returned by the action.</typeparam>
    public class HttpAction<T> : HttpAction, IBodyWorkflowAction<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpAction{T}"/> class.
        /// </summary>
        /// <param name="uri">The reference name of the workflow to call.</param>
        /// <param name="method">The HTTP method to use for the request.</param>
        /// <param name="queries">The query parameters.</param>
        /// <param name="requestBody">The request body (optional).</param>
        /// <param name="headers">The request headers (optional).</param>
        internal HttpAction(string uri, string method, object requestBody = null, JToken queries = null, JToken headers = null)
            : base(uri, method, requestBody, queries, headers)
        {
        }

        /// <summary>
        /// Gets the strongly-typed body of the action.
        /// </summary>
        public T Body { get; private set; }
    }
}
