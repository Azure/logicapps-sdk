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
        [WorkflowExpressionFactory(nameof(__BuildNestedWorkflow))]
        public IBodyWorkflowAction<JToken> NestedWorkflow([WorkflowExpression] Func<string> workflowReferenceName, [WorkflowExpression] Func<object> requestBody = null, [WorkflowExpression] Func<Dictionary<string, string>> headers = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildNestedWorkflow(WorkflowValue<string> workflowReferenceName, WorkflowValue<object> requestBody = null, WorkflowValue<Dictionary<string, string>> headers = null)
        {
            WorkflowValue.Validate(workflowReferenceName, nameof(workflowReferenceName), required: true);
            WorkflowValue.Validate(requestBody, nameof(requestBody), required: false);
            WorkflowValue.Validate(headers, nameof(headers), required: false);
            return new DeferredBodyAction<JToken>(() => new NestedWorkflowAction<JToken>(
                ExpressionConverter.Convert(workflowReferenceName), ExpressionConverter.ConvertO(requestBody), ExpressionConverter.ConvertO(headers)));
        }

        /// <summary>
        /// Creates a compose action that combines inputs into a single output.
        /// </summary>
        /// <param name="inputs">The inputs to compose.</param>
        [WorkflowExpressionFactory(nameof(__BuildCompose))]
        public IOutputWorkflowAction<JToken> Compose([WorkflowExpression] Func<string> inputs)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<JToken> __BuildCompose(WorkflowValue<string> inputs)
        {
            if (inputs == null) throw new ArgumentNullException(nameof(inputs));
            return new DeferredOutputAction<JToken>(() => new ComposeAction<JToken>(ExpressionConverter.ConvertO(inputs)));
        }

        /// <summary>
        /// Creates a typed compose action that combines inputs into a strongly-typed output.
        /// </summary>
        /// <param name="input">The input to compose.</param>
        /// <typeparam name="T">The type of the composed output.</typeparam>
        [WorkflowExpressionFactory(nameof(__BuildCompose))]
        public IOutputWorkflowAction<T> Compose<T>([WorkflowExpression] Func<T> input)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<T> __BuildCompose<T>(WorkflowValue<T> input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            return new DeferredOutputAction<T>(() => new ComposeAction<T>(ExpressionConverter.ConvertO(input)));
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
        [WorkflowExpressionFactory(nameof(__BuildHttpAction))]
        public IBodyWorkflowAction<JToken> HttpAction([WorkflowExpression] Func<Uri> uri, [WorkflowExpression] Func<HttpMethod> method, [WorkflowExpression] Func<object> requestBody = null, [WorkflowExpression] Func<Dictionary<string, string>> queries = null, [WorkflowExpression] Func<Dictionary<string, string>> headers = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildHttpAction(WorkflowValue<Uri> uri, WorkflowValue<HttpMethod> method, WorkflowValue<object> requestBody = null, WorkflowValue<Dictionary<string, string>> queries = null, WorkflowValue<Dictionary<string, string>> headers = null)
        {
            WorkflowValue.Validate(uri, nameof(uri), required: true);
            WorkflowValue.Validate(method, nameof(method), required: true);
            WorkflowValue.Validate(requestBody, nameof(requestBody), required: false);
            WorkflowValue.Validate(queries, nameof(queries), required: false);
            WorkflowValue.Validate(headers, nameof(headers), required: false);
            return new DeferredBodyAction<JToken>(() => new HttpAction<JToken>(
                ExpressionConverter.Convert(uri), ExpressionConverter.Convert(method), ExpressionConverter.ConvertO(requestBody),
                queries: ExpressionConverter.ConvertO(queries), headers: ExpressionConverter.ConvertO(headers)));
        }

        /// <summary>
        /// Creates a response action that sends an HTTP response.
        /// </summary>
        /// <param name="statusCode">An expression for the HTTP status code to return in the response (optional).</param>
        /// <param name="responseBody">An expression for the response body (optional).</param>
        /// <param name="headers">An expression for the response headers (optional).</param>
        /// <param name="schema">An expression for the response schema (optional).</param>
        [WorkflowExpressionFactory(nameof(__BuildResponse))]
        public IBodyWorkflowAction<JToken> Response([WorkflowExpression] Func<HttpStatusCode> statusCode = null, [WorkflowExpression] Func<object> responseBody = null, [WorkflowExpression] Func<Dictionary<string, string>> headers = null, [WorkflowExpression] Func<JToken> schema = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildResponse(WorkflowValue<HttpStatusCode> statusCode = null, WorkflowValue<object> responseBody = null, WorkflowValue<Dictionary<string, string>> headers = null, WorkflowValue<JToken> schema = null)
        {
            WorkflowValue.Validate(statusCode, nameof(statusCode), required: false);
            WorkflowValue.Validate(responseBody, nameof(responseBody), required: false);
            WorkflowValue.Validate(headers, nameof(headers), required: false);
            WorkflowValue.Validate(schema, nameof(schema), required: false);
            return new DeferredBodyAction<JToken>(() => new ResponseAction<JToken>(
                ExpressionConverter.ConvertStatusCode(statusCode), ExpressionConverter.ConvertO(responseBody),
                ExpressionConverter.ConvertO(headers), ExpressionConverter.ConvertO(schema)));
        }

        [WorkflowExpressionFactory(nameof(__BuildAgent))]
        public AgentAction Agent(AgentModelType agentModelType, string deploymentId, AgentModelSettings agentModelSettings, string connectionName, [WorkflowExpression] Func<AgentPromptMessage[]> messages)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public AgentAction __BuildAgent(AgentModelType agentModelType, string deploymentId, AgentModelSettings agentModelSettings, string connectionName, WorkflowValue<AgentPromptMessage[]> messages)
        {
            WorkflowValue.Validate(messages, nameof(messages), required: true);
            return new AgentAction(agentModelType: agentModelType, deploymentId: deploymentId, agentModelSettings: agentModelSettings,
                connectionName: connectionName, messages: () => ExpressionConverter.ConvertO(messages));
        }
    }
}
