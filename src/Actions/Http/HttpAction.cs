// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// The nested flow action allows calling a workflow within another workflow.
    /// </summary>
    public class HttpAction(
        string uri,
        string method,
        object requestBody = null,
        Dictionary<string, string> headers = null,
        Dictionary<string, string> queries = null) : WorkflowActionBase
    {
        /// <summary>
        /// Gets the reference name of the workflow to be invoked.
        /// </summary>
        public string Uri { get; } = uri;

        /// <summary>
        /// Gets the reference name of the workflow to be invoked.
        /// </summary>
        public string Method { get; } = method;

        /// <summary>
        /// Gets or sets the headers for the request.
        /// </summary>
        public Dictionary<string, string> Headers { get; set; } = headers;

        /// <summary>
        /// Gets or sets the headers for the request.
        /// </summary>
        public Dictionary<string, string> Queries { get; set; } = queries;

        /// <summary>
        /// Gets or sets the body of the request.
        /// </summary>
        public object RequestBody { get; set; } = requestBody;

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
        public HttpAction(string uri, string method, object requestBody = null, Dictionary<string, string> queries = null, Dictionary<string, string> headers = null)
            : base(uri, method, requestBody, queries, headers)
        {
        }

        /// <summary>
        /// Gets the strongly-typed body of the action.
        /// </summary>
        public T Body { get; private set; }
    }
}
