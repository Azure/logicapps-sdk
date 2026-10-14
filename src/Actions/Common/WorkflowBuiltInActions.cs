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
    /// Provides factory methods for creating built-in workflow actions. Built-in actions are first-party
    /// operations that run directly in the Logic Apps runtime without requiring external API connections.
    /// </summary>
    /// <remarks>
    /// Access this class through <c>WorkflowActions.BuiltIn</c>. Available action types include:
    /// <list type="bullet">
    ///   <item><description><see cref="Compose"/> — Transforms and combines data.</description></item>
    ///   <item><description><see cref = "HttpAction"/> — Sends HTTP requests to external endpoints.</description></item>
    ///   <item><description><see cref = "Response"/> — Returns an HTTP response (for HTTP-triggered workflows).</description></item>
    ///   <item><description><see cref = "CustomCode{T}"/> — Executes a C# callback function inline.</description></item>
    ///   <item><description><see cref = "NestedWorkflow"/> — Invokes another workflow as a child.</description></item>
    /// </list>
    /// </remarks>
    /// <seealso cref = "WorkflowActions"/>
    public class WorkflowBuiltInActions
    {
        /// <summary>
        /// Control flow actions (Scope, Condition, ForEach, Until, Switch, Terminate).
        /// </summary>
        public WorkflowControlActions Control { get; } = new WorkflowControlActions();
        /// <summary>
        /// Variable actions (InitializeVariable, SetVariable, IncrementVariable, DecrementVariable,
        /// AppendToStringVariable, AppendToArrayVariable).
        /// </summary>
        public WorkflowVariableActions Variables { get; } = new WorkflowVariableActions();

        /// <summary>
        /// Creates a nested workflow action that calls another workflow.
        /// </summary>
        /// <param name = "workflowReferenceName">The reference name of the workflow to call.</param>
        /// <param name = "requestBody">The request body to send to the workflow (optional).</param>
        /// <param name = "headers">The request headers to include in the workflow call (optional).</param>
        public IBodyWorkflowAction<JToken> NestedWorkflow(Expression<Func<string>> workflowReferenceName, Expression<Func<object>> requestBody = null, Expression<Func<Dictionary<string, string>>> headers = null)
        {
            var workflowReferenceNameDescriptor = workflowReferenceName == null ? null : WorkflowExpression.Compile(workflowReferenceName);
            var requestBodyDescriptor = requestBody == null ? null : WorkflowExpression.Compile(requestBody);
            var headersDescriptor = headers == null ? null : WorkflowExpression.Compile(headers);
            WorkflowExpression.Validate(workflowReferenceNameDescriptor, nameof(workflowReferenceName), required: true);
            WorkflowExpression.Validate(requestBodyDescriptor, nameof(requestBody), required: false);
            WorkflowExpression.Validate(headersDescriptor, nameof(headers), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                return new NestedWorkflowAction<JToken>(
                    ExpressionConverter.Convert(workflowReferenceNameDescriptor),
                    requestBodyDescriptor != null ? ExpressionConverter.ConvertO(requestBodyDescriptor) : null,
                    headersDescriptor != null ? ExpressionConverter.ConvertO(headersDescriptor) : null);
            });
        }

        /// <summary>
        /// Creates a compose action that combines inputs into a single output.
        /// </summary>
        /// <param name = "inputs">The inputs to compose.</param>
        public IOutputWorkflowAction<JToken> Compose(Expression<Func<string>> inputs)
        {
            var descriptor = inputs == null ? null : WorkflowExpression.Compile(inputs);
            WorkflowExpression.Validate(descriptor, nameof(inputs), required: true);
            return new DeferredOutputAction<JToken>(() =>
            {
                return new ComposeAction<JToken>(ExpressionConverter.Convert(descriptor));
            });
        }

        /// <summary>
        /// Creates a typed compose action that combines inputs into a strongly-typed output.
        /// </summary>
        /// <param name = "input">The input to compose.</param>
        /// <typeparam name = "T">The type of the composed output.</typeparam>
        public IOutputWorkflowAction<T> Compose<T>(Expression<Func<T>> input)
        {
            var descriptor = input == null ? null : WorkflowExpression.Compile(input);
            WorkflowExpression.Validate(descriptor, nameof(input), required: true);
            return new DeferredOutputAction<T>(() =>
            {
                var jt = ExpressionConverter.ConvertO<T>(descriptor);
                return new ComposeAction<T>(jt);
            });
        }

        /// <summary>
        /// Creates a custom code action that executes a callback function.
        /// </summary>
        /// <param name = "callback">The delegate callback with signature Func<WorkflowContext , Task<T>>.</param>
        /// <typeparam name = "T">The return type of the callback.</typeparam>
        public IBodyWorkflowAction<T> CustomCode<T>(Func<WorkflowContext, Task<T>> callback)
        {
            if (callback == null)
                throw new ArgumentNullException(nameof(callback));
            var methodName = callback.Method.Name;
            return new CSharpScriptCode<T>(callback);
        }

        /// <summary>
        /// Creates an HTTP action that sends an HTTP request.
        /// </summary>
        /// <param name = "uri">An expression for the URI of the HTTP request.</param>
        /// <param name = "method">An expression for the HTTP method.</param>
        /// <param name = "requestBody">An expression for the request body (optional).</param>
        /// <param name = "queries">An expression for the query parameters (optional).</param>
        /// <param name = "headers">An expression for the request headers (optional).</param>
        public IBodyWorkflowAction<JToken> HttpAction(Expression<Func<Uri>> uri, Expression<Func<HttpMethod>> method, Expression<Func<object>> requestBody = null, Expression<Func<Dictionary<string, string>>> queries = null, Expression<Func<Dictionary<string, string>>> headers = null)
        {
            var uriDescriptor = uri == null ? null : WorkflowExpression.Compile(uri);
            var methodDescriptor = method == null ? null : WorkflowExpression.Compile(method);
            var requestBodyDescriptor = requestBody == null ? null : WorkflowExpression.Compile(requestBody);
            var queriesDescriptor = queries == null ? null : WorkflowExpression.Compile(queries);
            var headersDescriptor = headers == null ? null : WorkflowExpression.Compile(headers);
            WorkflowExpression.Validate(uriDescriptor, nameof(uri), required: true);
            WorkflowExpression.Validate(methodDescriptor, nameof(method), required: true);
            WorkflowExpression.Validate(requestBodyDescriptor, nameof(requestBody), required: false);
            WorkflowExpression.Validate(queriesDescriptor, nameof(queries), required: false);
            WorkflowExpression.Validate(headersDescriptor, nameof(headers), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                return new HttpAction<JToken>(
                    ExpressionConverter.Convert(uriDescriptor),
                    ExpressionConverter.Convert(methodDescriptor),
                    requestBodyDescriptor != null ? ExpressionConverter.ConvertO(requestBodyDescriptor) : null,
                    queriesDescriptor != null ? ExpressionConverter.ConvertO(queriesDescriptor) : null,
                    headersDescriptor != null ? ExpressionConverter.ConvertO(headersDescriptor) : null);
            });
        }

        /// <summary>
        /// Creates a response action that sends an HTTP response.
        /// </summary>
        /// <param name = "statusCode">An expression for the HTTP status code to return in the response (optional).</param>
        /// <param name = "responseBody">An expression for the response body (optional).</param>
        /// <param name = "headers">An expression for the response headers (optional).</param>
        /// <param name = "schema">An expression for the response schema (optional).</param>
        public IBodyWorkflowAction<JToken> Response(Expression<Func<HttpStatusCode>> statusCode = null, Expression<Func<object>> responseBody = null, Expression<Func<Dictionary<string, string>>> headers = null, Expression<Func<JToken>> schema = null)
        {
            var statusCodeDescriptor = statusCode == null ? null : WorkflowExpression.Compile(statusCode);
            var responseBodyDescriptor = responseBody == null ? null : WorkflowExpression.Compile(responseBody);
            var headersDescriptor = headers == null ? null : WorkflowExpression.Compile(headers);
            var schemaDescriptor = schema == null ? null : WorkflowExpression.Compile(schema);
            WorkflowExpression.Validate(statusCodeDescriptor, nameof(statusCode), required: false);
            WorkflowExpression.Validate(responseBodyDescriptor, nameof(responseBody), required: false);
            WorkflowExpression.Validate(headersDescriptor, nameof(headers), required: false);
            WorkflowExpression.Validate(schemaDescriptor, nameof(schema), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                return new ResponseAction<JToken>(
                    ExpressionConverter.ConvertStatusCode(statusCodeDescriptor),
                    responseBodyDescriptor != null ? ExpressionConverter.ConvertO(responseBodyDescriptor) : null,
                    headersDescriptor != null ? ExpressionConverter.ConvertO(headersDescriptor) : null,
                    schemaDescriptor != null ? ExpressionConverter.ConvertO(schemaDescriptor) : null);
            });
        }

        public AgentAction Agent(AgentModelType agentModelType, string deploymentId, AgentModelSettings agentModelSettings, string connectionName, Expression<Func<AgentPromptMessage[]>> messages)
        {
            var descriptor = messages == null ? null : WorkflowExpression.Compile(messages);
            WorkflowExpression.Validate(descriptor, nameof(messages), required: true);
            return new AgentAction(agentModelType, deploymentId, agentModelSettings, connectionName, descriptor);
        }
    }
}