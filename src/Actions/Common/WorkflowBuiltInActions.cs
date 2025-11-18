// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Net;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Built-in actions for workflow agents.
    /// </summary>
    public class WorkflowBuiltInActions
    {
        /// <summary>
        /// Adds a workflow action to the workflow.
        /// </summary>
        /// <param name="workflowReferenceName">The reference name of the workflow to call.</param>
        /// <param name="requestBody">The request body (optional).</param>
        /// <param name="headers">The request headers (optional).</param>
        public IOutputWorkflowAction<JToken> NestedWorkflow(
            Expression<Func<string>> workflowReferenceName,
            Expression<Func<object>> requestBody = null,
            Expression<Func<Dictionary<string, string>>> headers = null)
        {
            if (requestBody != null)
            Console.WriteLine("FRUITCAKE STORE: " + requestBody + " -> " + ExpressionConverter.ConvertObject(requestBody));

            return new NestedWorkFlowAction<JToken>(
                ExpressionConverter.Convert(workflowReferenceName),
                requestBody != null ? ExpressionConverter.ConvertO(requestBody) : null,
                headers != null ? ExpressionConverter.ConvertObject(headers) : null);
        }

        /// <summary>
        /// Adds a child workflow that was created previously.
        /// </summary>
        /// <param name="inputs">The inputs.</param>
        public IOutputWorkflowAction<JToken> Compose(Expression<Func<string>> inputs)
        {
            return new ComposeAction<JToken>(ExpressionConverter.Convert(inputs));
        }

        /// <summary>
        /// Creates an HTTP action in the workflow.
        /// </summary>
        /// <param name="uri">An expression for the URI of the HTTP request.</param>
        /// <param name="method">An expression for the HTTP method.</param>
        /// <param name="requestBody">An expression for the request body (optional).</param>
        /// <param name="queries">An expression for the query parameters (optional).</param>
        /// <param name="headers">An expression for the request headers (optional).</param>
        /// <returns>
        /// An <see cref="IOutputWorkflowAction{JToken}"/> representing the HTTP action.
        /// </returns>
        public IOutputWorkflowAction<JToken> HttpAction(
            Expression<Func<Uri>> uri,
            Expression<Func<HttpMethod>> method,
            Expression<Func<string>> requestBody = null,
            Expression<Func<Dictionary<string, string>>> queries = null,
            Expression<Func<Dictionary<string, string>>> headers = null)
        {
            return new HttpAction<JToken>(
                ExpressionConverter.Convert(uri),
                ExpressionConverter.Convert(method),
                requestBody != null ? ExpressionConverter.Convert(requestBody) : null,
                queries != null ? ExpressionConverter.ConvertObject(queries) : null,
                headers != null ? ExpressionConverter.ConvertObject(headers) : null);
        }

        /// <summary>
        /// Creates a response action in the workflow.
        /// </summary>
        /// <param name="statusCode">An expression for the HTTP status code to return in the response.</param>
        /// <param name="responseBody">An expression for the response body (optional).</param>
        /// <param name="headers">An expression for the response headers (optional).</param>
        /// <param name="schema">An expression for the response schema (optional).</param>
        /// <returns>
        /// An <see cref="IOutputWorkflowAction{JToken}"/> representing the response action.
        /// </returns>
        public IOutputWorkflowAction<JToken> Response(
            Expression<Func<HttpStatusCode>> statusCode = null,
            Expression<Func<object>> responseBody = null,
            Expression<Func<Dictionary<string, string>>> headers = null,
            Expression<Func<JToken>> schema = null)
        {
            return new ResponseAction<JToken>(
                statusCode != null ? ExpressionConverter.ConvertObject(statusCode) : HttpStatusCode.OK,
                responseBody != null ? ExpressionConverter.ConvertO(responseBody) : null,
                headers != null ? ExpressionConverter.ConvertObject(headers) : null,
                schema != null ? ExpressionConverter.ConvertObject(schema) : null);
        }
    }
}
