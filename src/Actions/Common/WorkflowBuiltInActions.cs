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
    ///   <item><description><see cref="HttpAction"/> — Sends HTTP requests to external endpoints.</description></item>
    ///   <item><description><see cref="Response"/> — Returns an HTTP response (for HTTP-triggered workflows).</description></item>
    ///   <item><description><see cref="CustomCode{T}"/> — Executes a C# callback function inline.</description></item>
    ///   <item><description><see cref="NestedWorkflow"/> — Invokes another workflow as a child.</description></item>
    /// </list>
    /// </remarks>
    /// <seealso cref="WorkflowActions"/>
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
        /// <param name="workflowReferenceName">The reference name of the workflow to call.</param>
        /// <param name="requestBody">The request body to send to the workflow (optional).</param>
        /// <param name="headers">The request headers to include in the workflow call (optional).</param>
        public IBodyWorkflowAction<JToken> NestedWorkflow(
            [WorkflowExpression] Func<string> workflowReferenceName,
            [WorkflowExpression] Func<object> requestBody = null,
            [WorkflowExpression] Func<Dictionary<string, string>> headers = null)
        {
            SourceExpression.Validate(workflowReferenceName, nameof(workflowReferenceName), required: true);
            SourceExpression.Validate(requestBody, nameof(requestBody));
            SourceExpression.Validate(headers, nameof(headers));
            return new DeferredBodyAction<JToken>(() => new NestedWorkflowAction<JToken>(
               SourceExpressionConverter.ConvertO(workflowReferenceName),
               requestBody != null ? SourceExpressionConverter.ConvertToken(requestBody) : null,
                headers != null ? SourceExpressionConverter.ConvertObject(headers) : null));
        }

        /// <summary>
        /// Creates a compose action that combines inputs into a single output.
        /// </summary>
        /// <param name="inputs">The inputs to compose.</param>
        public IOutputWorkflowAction<JToken> Compose([WorkflowExpression] Func<string> inputs)
        {
            if (inputs == null) throw new ArgumentNullException(nameof(inputs));
            SourceExpression.Validate(inputs, nameof(inputs));
            return new DeferredOutputAction<JToken>(() => new ComposeAction<JToken>(SourceExpressionConverter.ConvertToken(inputs)));
        }

        /// <summary>
        /// Creates a typed compose action that combines inputs into a strongly-typed output.
        /// </summary>
        /// <param name="input">The input to compose.</param>
        /// <typeparam name="T">The type of the composed output.</typeparam>
        public IOutputWorkflowAction<T> Compose<T>([WorkflowExpression] Func<T> input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            SourceExpression.Validate(input, nameof(input));
            return new DeferredOutputAction<T>(() => new ComposeAction<T>(SourceExpressionConverter.ConvertToken(input)));
        }

        /// <summary>
        /// Creates a custom code action that executes a callback function.
        /// </summary>
        /// <param name="callback">The delegate callback with signature Func<WorkflowContext, Task<T>>.</param>
        /// <typeparam name="T">The return type of the callback.</typeparam>
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
        /// <param name="uri">An expression for the URI of the HTTP request.</param>
        /// <param name="method">An expression for the HTTP method.</param>
        /// <param name="requestBody">An expression for the request body (optional).</param>
        /// <param name="queries">An expression for the query parameters (optional).</param>
        /// <param name="headers">An expression for the request headers (optional).</param>
        public IBodyWorkflowAction<JToken> HttpAction(
            [WorkflowExpression] Func<Uri> uri,
            [WorkflowExpression] Func<HttpMethod> method,
            [WorkflowExpression] Func<object> requestBody = null,
            [WorkflowExpression] Func<Dictionary<string, string>> queries = null,
            [WorkflowExpression] Func<Dictionary<string, string>> headers = null)
        {
            SourceExpression.Validate(uri, nameof(uri), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(requestBody, nameof(requestBody));
            SourceExpression.Validate(queries, nameof(queries));
            SourceExpression.Validate(headers, nameof(headers));
            return new DeferredBodyAction<JToken>(() => new HttpAction<JToken>(
                SourceExpressionConverter.ConvertO(uri),
                SourceExpressionConverter.ConvertO(method),
                requestBody != null ? SourceExpressionConverter.ConvertToken(requestBody) : null,
                queries != null ? SourceExpressionConverter.ConvertObject(queries) : null,
                headers != null ? SourceExpressionConverter.ConvertObject(headers) : null));
        }

        /// <summary>
        /// Creates a response action that sends an HTTP response.
        /// </summary>
        /// <param name="statusCode">An expression for the HTTP status code to return in the response (optional).</param>
        /// <param name="responseBody">An expression for the response body (optional).</param>
        /// <param name="headers">An expression for the response headers (optional).</param>
        /// <param name="schema">An expression for the response schema (optional).</param>
        public IBodyWorkflowAction<JToken> Response(
            [WorkflowExpression] Func<HttpStatusCode> statusCode = null,
            [WorkflowExpression] Func<object> responseBody = null,
            [WorkflowExpression] Func<Dictionary<string, string>> headers = null,
            [WorkflowExpression] Func<JToken> schema = null)
        {
            SourceExpression.Validate(statusCode, nameof(statusCode));
            SourceExpression.Validate(responseBody, nameof(responseBody));
            SourceExpression.Validate(headers, nameof(headers));
            SourceExpression.Validate(schema, nameof(schema));
            return new DeferredBodyAction<JToken>(() => new ResponseAction<JToken>(
                SourceExpressionConverter.ConvertStatusCode(statusCode),
                responseBody != null ? SourceExpressionConverter.ConvertToken(responseBody) : null,
                headers != null ? SourceExpressionConverter.ConvertObject(headers) : null,
                schema != null ? SourceExpressionConverter.ConvertToken(schema) : null));
        }

        public AgentAction Agent(
            AgentModelType agentModelType,
            string deploymentId,
            AgentModelSettings agentModelSettings,
            string connectionName,
            [WorkflowExpression] Func<AgentPromptMessage[]> messages)
        {
            SourceExpression.Validate(messages, nameof(messages));
            return new AgentAction(
                agentModelType: agentModelType,
                deploymentId: deploymentId,
                agentModelSettings: agentModelSettings,
                connectionName: connectionName,
                messages: messages == null ? null : () => SourceExpressionConverter.ConvertObject(messages));
        }
    }
}
