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
    /// Built-in actions for workflows.
    /// </summary>
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
            Expression<Func<string>> workflowReferenceName,
            Expression<Func<object>> requestBody = null,
            Expression<Func<Dictionary<string, string>>> headers = null)
        {
           return new NestedWorkflowAction<JToken>(
                ExpressionConverter.Convert(workflowReferenceName),
                requestBody != null ? ExpressionConverter.ConvertO(requestBody) : null,
                headers != null ? ExpressionConverter.ConvertObject(headers) : null);
        }

        /// <summary>
        /// Creates a compose action that combines inputs into a single output.
        /// </summary>
        /// <param name="inputs">The inputs to compose.</param>
        public IOutputWorkflowAction<JToken> Compose(Expression<Func<string>> inputs)
        {
            return new ComposeAction<JToken>(ExpressionConverter.Convert(inputs));
        }

        /// <summary>
        /// Creates a typed compose action that combines inputs into a strongly-typed output.
        /// </summary>
        /// <param name="input">The input to compose.</param>
        /// <typeparam name="T">The type of the composed output.</typeparam>
        public IOutputWorkflowAction<T> Compose<T>(Expression<Func<T>> input)
        {
            var jt = ExpressionConverter.ConvertO<T>(input);
            return new ComposeAction<T>(jt);
        }

        /// <summary>
        /// Creates a custom code action that executes a callback function.
        /// </summary>
        /// <param name="callback">The delegate callback with signature Func&lt;WorkflowContext, Task&lt;T&gt;&gt;.</param>
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
            Expression<Func<Uri>> uri,
            Expression<Func<HttpMethod>> method,
            Expression<Func<object>> requestBody = null,
            Expression<Func<Dictionary<string, string>>> queries = null,
            Expression<Func<Dictionary<string, string>>> headers = null)
        {
            return new HttpAction<JToken>(
                ExpressionConverter.Convert(uri),
                ExpressionConverter.Convert(method),
                requestBody != null ? ExpressionConverter.ConvertO(requestBody) : null,
                queries != null ? ExpressionConverter.ConvertObject(queries) : null,
                headers != null ? ExpressionConverter.ConvertObject(headers) : null);
        }

        /// <summary>
        /// Creates a response action that sends an HTTP response.
        /// </summary>
        /// <param name="statusCode">An expression for the HTTP status code to return in the response (optional).</param>
        /// <param name="responseBody">An expression for the response body (optional).</param>
        /// <param name="headers">An expression for the response headers (optional).</param>
        /// <param name="schema">An expression for the response schema (optional).</param>
        public IBodyWorkflowAction<JToken> Response(
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

        public AgentAction Agent(
            AgentModelType agentModelType,
            string deploymentId,
            AgentModelSettings agentModelSettings,
            string connectionName,
            Expression<Func<AgentPromptMessage[]>> messages)
        {
            return new AgentAction(
                agentModelType: agentModelType,
                deploymentId: deploymentId,
                agentModelSettings: agentModelSettings,
                connectionName: connectionName,
                messages: messages != null ? ExpressionConverter.ConvertO(messages)?.ToObject<AgentPromptMessage[]>() : null);
        }
    }
}
