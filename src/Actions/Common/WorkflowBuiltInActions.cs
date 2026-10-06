// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Provides factory methods for creating built-in workflow actions. Built-in actions are first-party
    /// operations that run directly in the Logic Apps runtime without requiring external API connections.
    /// </summary>
    /// <remarks>
    /// Access this class through <c>WorkflowActions.BuiltIn</c>. Available action types include:
    /// <list type="bullet">
    ///   <item><description><see cref="Compose(Func{string})"/> — Transforms and combines data.</description></item>
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

        [WorkflowExpressionFactory(nameof(__BuildNestedWorkflow))]
        /// <summary>
        /// Creates a nested workflow action that calls another workflow.
        /// </summary>
        /// <param name = "workflowReferenceName">The reference name of the workflow to call.</param>
        /// <param name = "requestBody">The request body to send to the workflow (optional).</param>
        /// <param name = "headers">The request headers to include in the workflow call (optional).</param>
        public IBodyWorkflowAction<JToken> NestedWorkflow([WorkflowExpression] Func<string> workflowReferenceName, [WorkflowExpression] Func<object> requestBody = null, [WorkflowExpression] Func<Dictionary<string, string>> headers = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates a nested workflow action that calls another workflow.
        /// </summary>
        /// <param name = "workflowReferenceName">The reference name of the workflow to call.</param>
        /// <param name = "requestBody">The request body to send to the workflow (optional).</param>
        /// <param name = "headers">The request headers to include in the workflow call (optional).</param>
        public IBodyWorkflowAction<JToken> __BuildNestedWorkflow(WorkflowExpression<string> workflowReferenceName, WorkflowExpression<object> requestBody = null, WorkflowExpression<Dictionary<string, string>> headers = null)
        {
            WorkflowExpression.Validate(workflowReferenceName, nameof(workflowReferenceName), required: true);
            WorkflowExpression.Validate(requestBody, nameof(requestBody), required: false);
            WorkflowExpression.Validate(headers, nameof(headers), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                return new NestedWorkflowAction<JToken>(ExpressionConverter.Convert(workflowReferenceName), requestBody != null ? ExpressionConverter.ConvertO(requestBody) : null, headers != null ? ExpressionConverter.ConvertO(headers) : null);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCompose))]
        /// <summary>
        /// Creates a compose action that combines inputs into a single output.
        /// </summary>
        /// <param name = "inputs">The inputs to compose.</param>
        public IOutputWorkflowAction<JToken> Compose([WorkflowExpression] Func<string> inputs)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates a compose action that combines inputs into a single output.
        /// </summary>
        /// <param name = "inputs">The inputs to compose.</param>
        public IOutputWorkflowAction<JToken> __BuildCompose(WorkflowExpression<string> inputs)
        {
            if (inputs == null) throw new ArgumentNullException(nameof(inputs));
            return new DeferredOutputAction<JToken>(() =>
            {
                return new ComposeAction<JToken>(ExpressionConverter.Convert(inputs));
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildCompose))]
        /// <summary>
        /// Creates a typed compose action that combines inputs into a strongly-typed output.
        /// </summary>
        /// <param name = "input">The input to compose.</param>
        /// <typeparam name = "T">The type of the composed output.</typeparam>
        public IOutputWorkflowAction<T> Compose<T>([WorkflowExpression] Func<T> input)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates a typed compose action that combines inputs into a strongly-typed output.
        /// </summary>
        /// <param name = "input">The input to compose.</param>
        /// <typeparam name = "T">The type of the composed output.</typeparam>
        public IOutputWorkflowAction<T> __BuildCompose<T>(WorkflowExpression<T> input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            return new DeferredOutputAction<T>(() =>
            {
                var jt = ExpressionConverter.ConvertO<T>(input);
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

        [WorkflowExpressionFactory(nameof(__BuildHttpAction))]
        /// <summary>
        /// Creates an HTTP action that sends an HTTP request.
        /// </summary>
        /// <param name = "uri">An expression for the URI of the HTTP request.</param>
        /// <param name = "method">An expression for the HTTP method.</param>
        /// <param name = "requestBody">An expression for the request body (optional).</param>
        /// <param name = "queries">An expression for the query parameters (optional).</param>
        /// <param name = "headers">An expression for the request headers (optional).</param>
        public IBodyWorkflowAction<JToken> HttpAction([WorkflowExpression] Func<Uri> uri, [WorkflowExpression] Func<HttpMethod> method, [WorkflowExpression] Func<object> requestBody = null, [WorkflowExpression] Func<Dictionary<string, string>> queries = null, [WorkflowExpression] Func<Dictionary<string, string>> headers = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates an HTTP action that sends an HTTP request.
        /// </summary>
        /// <param name = "uri">An expression for the URI of the HTTP request.</param>
        /// <param name = "method">An expression for the HTTP method.</param>
        /// <param name = "requestBody">An expression for the request body (optional).</param>
        /// <param name = "queries">An expression for the query parameters (optional).</param>
        /// <param name = "headers">An expression for the request headers (optional).</param>
        public IBodyWorkflowAction<JToken> __BuildHttpAction(WorkflowExpression<Uri> uri, WorkflowExpression<HttpMethod> method, WorkflowExpression<object> requestBody = null, WorkflowExpression<Dictionary<string, string>> queries = null, WorkflowExpression<Dictionary<string, string>> headers = null)
        {
            WorkflowExpression.Validate(uri, nameof(uri), required: true);
            WorkflowExpression.Validate(method, nameof(method), required: true);
            WorkflowExpression.Validate(requestBody, nameof(requestBody), required: false);
            WorkflowExpression.Validate(queries, nameof(queries), required: false);
            WorkflowExpression.Validate(headers, nameof(headers), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                return new HttpAction<JToken>(ExpressionConverter.Convert(uri), ExpressionConverter.Convert(method), requestBody != null ? ExpressionConverter.ConvertO(requestBody) : null, queries != null ? ExpressionConverter.ConvertO(queries) : null, headers != null ? ExpressionConverter.ConvertO(headers) : null);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildResponse))]
        /// <summary>
        /// Creates a response action that sends an HTTP response.
        /// </summary>
        /// <param name = "statusCode">An expression for the HTTP status code to return in the response (optional).</param>
        /// <param name = "responseBody">An expression for the response body (optional).</param>
        /// <param name = "headers">An expression for the response headers (optional).</param>
        /// <param name = "schema">An expression for the response schema (optional).</param>
        public IBodyWorkflowAction<JToken> Response([WorkflowExpression] Func<HttpStatusCode> statusCode = null, [WorkflowExpression] Func<object> responseBody = null, [WorkflowExpression] Func<Dictionary<string, string>> headers = null, [WorkflowExpression] Func<JToken> schema = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates a response action that sends an HTTP response.
        /// </summary>
        /// <param name = "statusCode">An expression for the HTTP status code to return in the response (optional).</param>
        /// <param name = "responseBody">An expression for the response body (optional).</param>
        /// <param name = "headers">An expression for the response headers (optional).</param>
        /// <param name = "schema">An expression for the response schema (optional).</param>
        public IBodyWorkflowAction<JToken> __BuildResponse(WorkflowExpression<HttpStatusCode> statusCode = null, WorkflowExpression<object> responseBody = null, WorkflowExpression<Dictionary<string, string>> headers = null, WorkflowExpression<JToken> schema = null)
        {
            WorkflowExpression.Validate(statusCode, nameof(statusCode), required: false);
            WorkflowExpression.Validate(responseBody, nameof(responseBody), required: false);
            WorkflowExpression.Validate(headers, nameof(headers), required: false);
            WorkflowExpression.Validate(schema, nameof(schema), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                return new ResponseAction<JToken>(ExpressionConverter.ConvertStatusCode(statusCode), responseBody != null ? ExpressionConverter.ConvertO(responseBody) : null, headers != null ? ExpressionConverter.ConvertO(headers) : null, schema != null ? ExpressionConverter.ConvertO(schema) : null);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildAgent))]
        public AgentAction Agent(AgentModelType agentModelType, string deploymentId, AgentModelSettings agentModelSettings, string connectionName, [WorkflowExpression] Func<AgentPromptMessage[]> messages)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public AgentAction __BuildAgent(AgentModelType agentModelType, string deploymentId, AgentModelSettings agentModelSettings, string connectionName, WorkflowExpression<AgentPromptMessage[]> messages)
        {
            WorkflowExpression.Validate(messages, nameof(messages), required: true);
            return new AgentAction(agentModelType, deploymentId, agentModelSettings, connectionName, messages);
        }
    }
}