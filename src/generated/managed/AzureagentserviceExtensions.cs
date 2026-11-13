//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureagentservice
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureagentserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<ListAgentsResponse, ApiConnectionActionConfiguration> ListAgents(Expression<Func<CreateRunApiVersionInput>> apiVersion)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            return new DeferredBodyAction<ListAgentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/assistants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ListAgentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<ListAgentsServiceResponse, ApiConnectionActionConfiguration> ListAgentsFromService()
        {
            return new DeferredBodyAction<ListAgentsServiceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/agents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListAgentsServiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<AgentVersionRecord, ApiConnectionActionConfiguration> CreateHostedAgent(Expression<Func<CreateHostedAgentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AgentVersionRecord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/agents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AgentVersionRecord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<AgentRecord, ApiConnectionActionConfiguration> GetAgentFromService(Expression<Func<string>> agentName)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            return new DeferredBodyAction<AgentRecord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}", __workflow_agentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AgentRecord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<AgentRecord, ApiConnectionActionConfiguration> UpdateHostedAgentRouting(Expression<Func<string>> agentName, Expression<Func<UpdateHostedAgentRoutingBodyInput>> body)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AgentRecord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}", __workflow_agentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AgentRecord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAgent(Expression<Func<string>> agentName, Expression<Func<bool>> force = null)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_force = WorkflowExpression.Compile(force, nameof(force), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}", __workflow_agentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["force"] = Convert.ToString(false);
                if (__workflow_force != null)
                    callPayload.Queries["force"] = ExpressionConverter.Convert(__workflow_force);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EnableHostedAgent(Expression<Func<string>> agentName)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}:enable", __workflow_agentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DisableHostedAgent(Expression<Func<string>> agentName)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}:disable", __workflow_agentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<AgentVersionListResponse, ApiConnectionActionConfiguration> ListAgentVersions(Expression<Func<string>> agentName, Expression<Func<bool>> includeDrafts = null, Expression<Func<int>> limit = null, Expression<Func<OrderInput>> order = null, Expression<Func<string>> after = null, Expression<Func<string>> before = null)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_includeDrafts = WorkflowExpression.Compile(includeDrafts, nameof(includeDrafts), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_order = WorkflowExpression.Compile(order, nameof(order), required: false);
            var __workflow_after = WorkflowExpression.Compile(after, nameof(after), required: false);
            var __workflow_before = WorkflowExpression.Compile(before, nameof(before), required: false);
            return new DeferredBodyAction<AgentVersionListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/versions", __workflow_agentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["include_drafts"] = Convert.ToString(false);
                if (__workflow_includeDrafts != null)
                    callPayload.Queries["include_drafts"] = ExpressionConverter.Convert(__workflow_includeDrafts);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["order"] = Convert.ToString("desc");
                if (__workflow_order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(__workflow_order);
                if (__workflow_after != null)
                    callPayload.Queries["after"] = ExpressionConverter.Convert(__workflow_after);
                if (__workflow_before != null)
                    callPayload.Queries["before"] = ExpressionConverter.Convert(__workflow_before);
                return new ApiConnectionAction<AgentVersionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<AgentVersionRecord, ApiConnectionActionConfiguration> CreateHostedAgentVersion(Expression<Func<string>> agentName, Expression<Func<CreateHostedAgentVersionBodyInput>> body)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AgentVersionRecord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/versions", __workflow_agentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AgentVersionRecord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<AgentVersionRecord, ApiConnectionActionConfiguration> CreatePromptAgentVersion(Expression<Func<string>> agentName, Expression<Func<CreatePromptAgentVersionBodyInput>> body)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AgentVersionRecord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/versions/prompt", __workflow_agentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AgentVersionRecord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<AgentVersionRecord, ApiConnectionActionConfiguration> GetAgentVersion(Expression<Func<string>> agentName, Expression<Func<string>> agentVersion)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_agentVersion = WorkflowExpression.Compile(agentVersion, nameof(agentVersion), required: true);
            return new DeferredBodyAction<AgentVersionRecord, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/versions/{1}", __workflow_agentName.WithUrlEncoding(1), __workflow_agentVersion.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AgentVersionRecord>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAgentVersion(Expression<Func<string>> agentName, Expression<Func<string>> agentVersion, Expression<Func<bool>> force = null)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_agentVersion = WorkflowExpression.Compile(agentVersion, nameof(agentVersion), required: true);
            var __workflow_force = WorkflowExpression.Compile(force, nameof(force), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/versions/{1}", __workflow_agentName.WithUrlEncoding(1), __workflow_agentVersion.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["force"] = Convert.ToString(false);
                if (__workflow_force != null)
                    callPayload.Queries["force"] = ExpressionConverter.Convert(__workflow_force);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<CreateThreadResponse, ApiConnectionActionConfiguration> CreateThread(Expression<Func<CreateRunApiVersionInput>> apiVersion, Expression<Func<CreateThreadRequestBodyInput>> requestBody)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<CreateThreadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/threads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<CreateThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<CreateRunResponse, ApiConnectionActionConfiguration> CreateRun(Expression<Func<CreateRunApiVersionInput>> apiVersion, Expression<Func<string>> threadId, Expression<Func<CreateRunRequestBodyInput>> requestBody)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<CreateRunResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/runs", __workflow_threadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<CreateRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<GetRunResponse, ApiConnectionActionConfiguration> GetRun(Expression<Func<CreateRunApiVersionInput>> apiVersion, Expression<Func<string>> threadId, Expression<Func<string>> runId)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            var __workflow_runId = WorkflowExpression.Compile(runId, nameof(runId), required: true);
            return new DeferredBodyAction<GetRunResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/runs/{1}", __workflow_threadId.WithUrlEncoding(1), __workflow_runId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<GetRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<ListMessageResponse, ApiConnectionActionConfiguration> ListMessages(Expression<Func<CreateRunApiVersionInput>> apiVersion, Expression<Func<string>> threadId)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_threadId = WorkflowExpression.Compile(threadId, nameof(threadId), required: true);
            return new DeferredBodyAction<ListMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/threads/{0}/messages", __workflow_threadId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                return new ApiConnectionAction<ListMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<OpenAIResponse, ApiConnectionActionConfiguration> InvokeAgent(Expression<Func<InvokeAgentApiVersionInput>> apiVersion, Expression<Func<InvokeAgentBodyInput>> body)
        {
            var __workflow_apiVersion = WorkflowExpression.Compile(apiVersion, nameof(apiVersion), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OpenAIResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/openai/responses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = ExpressionConverter.Convert(__workflow_apiVersion);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OpenAIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<OpenAIResponse, ApiConnectionActionConfiguration> InvokeHostedAgentResponses(Expression<Func<string>> agentName, Expression<Func<InvokeHostedAgentResponsesBodyInput>> body)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<OpenAIResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/endpoint/protocols/openai/responses", __workflow_agentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<OpenAIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> InvokeHostedAgentInvocations(Expression<Func<string>> agentName, Expression<Func<object>> body)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/endpoint/protocols/invocations", __workflow_agentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<HostedSession, ApiConnectionActionConfiguration> CreateHostedSession(Expression<Func<string>> agentName, Expression<Func<CreateHostedSessionBodyInput>> body, Expression<Func<string>> xMsUserIsolationKey = null)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_xMsUserIsolationKey = WorkflowExpression.Compile(xMsUserIsolationKey, nameof(xMsUserIsolationKey), required: false);
            return new DeferredBodyAction<HostedSession, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/endpoint/sessions", __workflow_agentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsUserIsolationKey != null)
                    callPayload.Headers["x-ms-user-isolation-key"] = ExpressionConverter.Convert(__workflow_xMsUserIsolationKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<HostedSession>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<HostedSessionListResponse, ApiConnectionActionConfiguration> ListHostedSessions(Expression<Func<string>> agentName, Expression<Func<string>> xMsUserIsolationKey = null)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_xMsUserIsolationKey = WorkflowExpression.Compile(xMsUserIsolationKey, nameof(xMsUserIsolationKey), required: false);
            return new DeferredBodyAction<HostedSessionListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/endpoint/sessions", __workflow_agentName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsUserIsolationKey != null)
                    callPayload.Headers["x-ms-user-isolation-key"] = ExpressionConverter.Convert(__workflow_xMsUserIsolationKey);
                return new ApiConnectionAction<HostedSessionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<HostedSession, ApiConnectionActionConfiguration> GetHostedSession(Expression<Func<string>> agentName, Expression<Func<string>> sessionId, Expression<Func<string>> xMsUserIsolationKey = null)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_xMsUserIsolationKey = WorkflowExpression.Compile(xMsUserIsolationKey, nameof(xMsUserIsolationKey), required: false);
            return new DeferredBodyAction<HostedSession, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/endpoint/sessions/{1}", __workflow_agentName.WithUrlEncoding(1), __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsUserIsolationKey != null)
                    callPayload.Headers["x-ms-user-isolation-key"] = ExpressionConverter.Convert(__workflow_xMsUserIsolationKey);
                return new ApiConnectionAction<HostedSession>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteHostedSession(Expression<Func<string>> agentName, Expression<Func<string>> sessionId, Expression<Func<string>> xMsUserIsolationKey = null)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_xMsUserIsolationKey = WorkflowExpression.Compile(xMsUserIsolationKey, nameof(xMsUserIsolationKey), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/endpoint/sessions/{1}", __workflow_agentName.WithUrlEncoding(1), __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xMsUserIsolationKey != null)
                    callPayload.Headers["x-ms-user-isolation-key"] = ExpressionConverter.Convert(__workflow_xMsUserIsolationKey);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<HostedSessionFileUploadResponse, ApiConnectionActionConfiguration> UploadHostedSessionFile(Expression<Func<string>> agentName, Expression<Func<string>> sessionId, Expression<Func<string>> path, Expression<Func<string>> body, Expression<Func<string>> xMsUserIsolationKey = null)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_xMsUserIsolationKey = WorkflowExpression.Compile(xMsUserIsolationKey, nameof(xMsUserIsolationKey), required: false);
            return new DeferredBodyAction<HostedSessionFileUploadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/endpoint/sessions/{1}/files/content", __workflow_agentName.WithUrlEncoding(1), __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                if (__workflow_xMsUserIsolationKey != null)
                    callPayload.Headers["x-ms-user-isolation-key"] = ExpressionConverter.Convert(__workflow_xMsUserIsolationKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<HostedSessionFileUploadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadHostedSessionFile(Expression<Func<string>> agentName, Expression<Func<string>> sessionId, Expression<Func<string>> path, Expression<Func<string>> xMsUserIsolationKey = null)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_xMsUserIsolationKey = WorkflowExpression.Compile(xMsUserIsolationKey, nameof(xMsUserIsolationKey), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/endpoint/sessions/{1}/files/content", __workflow_agentName.WithUrlEncoding(1), __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                if (__workflow_xMsUserIsolationKey != null)
                    callPayload.Headers["x-ms-user-isolation-key"] = ExpressionConverter.Convert(__workflow_xMsUserIsolationKey);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<HostedSessionFileListResponse, ApiConnectionActionConfiguration> ListHostedSessionFiles(Expression<Func<string>> agentName, Expression<Func<string>> sessionId, Expression<Func<string>> xMsUserIsolationKey = null, Expression<Func<string>> path = null)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_xMsUserIsolationKey = WorkflowExpression.Compile(xMsUserIsolationKey, nameof(xMsUserIsolationKey), required: false);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: false);
            return new DeferredBodyAction<HostedSessionFileListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/endpoint/sessions/{1}/files", __workflow_agentName.WithUrlEncoding(1), __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = Convert.ToString(".");
                if (__workflow_path != null)
                    callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                if (__workflow_xMsUserIsolationKey != null)
                    callPayload.Headers["x-ms-user-isolation-key"] = ExpressionConverter.Convert(__workflow_xMsUserIsolationKey);
                return new ApiConnectionAction<HostedSessionFileListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteHostedSessionFile(Expression<Func<string>> agentName, Expression<Func<string>> sessionId, Expression<Func<string>> path, Expression<Func<string>> xMsUserIsolationKey = null)
        {
            var __workflow_agentName = WorkflowExpression.Compile(agentName, nameof(agentName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_xMsUserIsolationKey = WorkflowExpression.Compile(xMsUserIsolationKey, nameof(xMsUserIsolationKey), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/endpoint/sessions/{1}/files", __workflow_agentName.WithUrlEncoding(1), __workflow_sessionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                if (__workflow_xMsUserIsolationKey != null)
                    callPayload.Headers["x-ms-user-isolation-key"] = ExpressionConverter.Convert(__workflow_xMsUserIsolationKey);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendActivityApplication(Expression<Func<string>> myApplication, Expression<Func<object>> activity = null)
        {
            var __workflow_myApplication = WorkflowExpression.Compile(myApplication, nameof(myApplication), required: true);
            var __workflow_activity = WorkflowExpression.Compile(activity, nameof(activity), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/applications/{0}/protocols/activityprotocol", __workflow_myApplication.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2025-11-15-preview");
                if (__workflow_activity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_activity);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureagentservice")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendActivity(Expression<Func<string>> agentId, Expression<Func<object>> activity = null)
        {
            var __workflow_agentId = WorkflowExpression.Compile(agentId, nameof(agentId), required: true);
            var __workflow_activity = WorkflowExpression.Compile(activity, nameof(activity), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/agents/{0}/endpoint/protocols/activityprotocol", __workflow_agentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api-version"] = Convert.ToString("2025-11-15-preview");
                if (__workflow_activity != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_activity);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class AzureagentserviceTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListAgentsResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public Data[] Data { get; set; }

        [JsonProperty("first_id")]
        public string FirstId { get; set; }

        [JsonProperty("last_id")]
        public string LastId { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class Data
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public CreateRunToolsResponse[] Tools { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("top_p")]
        public double TopP { get; set; }

        [JsonProperty("response_format")]
        public JToken ResponseFormat { get; set; }

        [JsonProperty("tool_resources")]
        public JToken ToolResources { get; set; }
    }

    public class CreateRunToolsResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateRunApiVersionInput
    {
        [EnumMember(Value = "2025-05-01")]
        _20250501
    }

    public class ListAgentsServiceResponse
    {
        [JsonProperty("data")]
        public AgentServiceData[] Data { get; set; }
    }

    public class AgentServiceData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class AgentVersionRecord
    {
        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("definition")]
        public JToken Definition { get; set; }

        [JsonProperty("draft")]
        public bool Draft { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("instance_identity")]
        public JToken InstanceIdentity { get; set; }

        [JsonProperty("blueprint")]
        public JToken Blueprint { get; set; }

        [JsonProperty("blueprint_reference")]
        public JToken BlueprintReference { get; set; }

        [JsonProperty("agent_guid")]
        public string AgentGuid { get; set; }
    }

    public class CreateHostedAgentBodyInput
    {
        public CreateHostedAgentBodyInput(string agentName, HostedAgentDefinition definition)
        {
            this.AgentName = agentName;
            this.Definition = definition;
        }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AgentName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("definition", DefaultValueHandling = DefaultValueHandling.Include)]
        public HostedAgentDefinition Definition { get; set; }
    }

    public class HostedAgentDefinition
    {
        public HostedAgentDefinition(HostedAgentContainerConfiguration containerConfiguration, HostedAgentProtocolVersion[] protocolVersions)
        {
            this.ContainerConfiguration = containerConfiguration;
            this.ProtocolVersions = protocolVersions;
        }

        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        internal HostedAgentDefinitionKindType Kind { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Azureagentservice.HostedAgentDefinitionKindType.Hosted;

        [JsonProperty("container_configuration", DefaultValueHandling = DefaultValueHandling.Include)]
        public HostedAgentContainerConfiguration ContainerConfiguration { get; set; }

        [JsonProperty("cpu", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Cpu { get; set; } = "1";

        [JsonProperty("memory", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Memory { get; set; } = "2Gi";

        [JsonProperty("protocol_versions", DefaultValueHandling = DefaultValueHandling.Include)]
        public HostedAgentProtocolVersion[] ProtocolVersions { get; set; }

        [JsonProperty("environment_variables")]
        public JToken EnvironmentVariables { get; set; }

        [JsonProperty("rai_config")]
        public JToken ResponsibleAIConfiguration { get; set; }

        [JsonProperty("telemetry_config")]
        public JToken TelemetryConfiguration { get; set; }

        [JsonProperty("session_configuration")]
        public JToken SessionConfiguration { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HostedAgentDefinitionKindType
    {
        [EnumMember(Value = "hosted")]
        Hosted
    }

    public class HostedAgentContainerConfiguration
    {
        public HostedAgentContainerConfiguration(string containerImage)
        {
            this.ContainerImage = containerImage;
        }

        [JsonProperty("image", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContainerImage { get; set; }

        [JsonProperty("registry_connection_id")]
        public string RegistryConnectionId { get; set; }
    }

    public class HostedAgentProtocolVersion
    {
        public HostedAgentProtocolVersion(HostedAgentProtocolVersionProtocolType protocol)
        {
            this.Protocol = protocol;
        }

        [JsonProperty("protocol", DefaultValueHandling = DefaultValueHandling.Include)]
        public HostedAgentProtocolVersionProtocolType Protocol { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HostedAgentProtocolVersionProtocolType
    {
        [EnumMember(Value = "responses")]
        Responses,
        [EnumMember(Value = "invocations")]
        Invocations
    }

    public class AgentRecord
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("configuration_state")]
        public string ConfigurationState { get; set; }

        [JsonProperty("state_source")]
        public string StateSource { get; set; }

        [JsonProperty("versions")]
        public AgentRecordVersions Versions { get; set; }

        [JsonProperty("agent_endpoint")]
        public JToken AgentEndpoint { get; set; }

        [JsonProperty("digital_worker_type")]
        public string DigitalWorkerType { get; set; }

        [JsonProperty("instance_identity")]
        public JToken InstanceIdentity { get; set; }

        [JsonProperty("blueprint")]
        public JToken Blueprint { get; set; }

        [JsonProperty("blueprint_reference")]
        public JToken BlueprintReference { get; set; }

        [JsonProperty("agent_card")]
        public JToken AgentCard { get; set; }
    }

    public class AgentRecordVersions
    {
        [JsonProperty("latest")]
        public AgentVersionRecord Latest { get; set; }
    }

    public class UpdateHostedAgentRoutingBodyInput
    {
        public UpdateHostedAgentRoutingBodyInput(HostedAgentEndpointRouting agentEndpoint)
        {
            this.AgentEndpoint = agentEndpoint;
        }

        [JsonProperty("agent_endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        public HostedAgentEndpointRouting AgentEndpoint { get; set; }
    }

    public class HostedAgentEndpointRouting
    {
        public HostedAgentEndpointRouting(HostedAgentVersionSelector versionSelector)
        {
            this.VersionSelector = versionSelector;
        }

        [JsonProperty("version_selector", DefaultValueHandling = DefaultValueHandling.Include)]
        public HostedAgentVersionSelector VersionSelector { get; set; }
    }

    public class HostedAgentVersionSelector
    {
        public HostedAgentVersionSelector(HostedAgentVersionSelectionRule[] versionSelectionRules)
        {
            this.VersionSelectionRules = versionSelectionRules;
        }

        [JsonProperty("version_selection_rules", DefaultValueHandling = DefaultValueHandling.Include)]
        public HostedAgentVersionSelectionRule[] VersionSelectionRules { get; set; }
    }

    public class HostedAgentVersionSelectionRule
    {
        public HostedAgentVersionSelectionRule(string agentVersion)
        {
            this.AgentVersion = agentVersion;
        }

        [JsonProperty("agent_version", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AgentVersion { get; set; }
    }

    public class AgentVersionListResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public AgentVersionRecord[] Data { get; set; }

        [JsonProperty("first_id")]
        public string FirstId { get; set; }

        [JsonProperty("last_id")]
        public string LastId { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class CreateHostedAgentVersionBodyInput
    {
        public CreateHostedAgentVersionBodyInput(HostedAgentDefinition definition)
        {
            this.Definition = definition;
        }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("draft", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateAsDraft { get; set; } = false;

        [JsonProperty("definition", DefaultValueHandling = DefaultValueHandling.Include)]
        public HostedAgentDefinition Definition { get; set; }
    }

    public class CreatePromptAgentVersionBodyInput
    {
        public CreatePromptAgentVersionBodyInput(PromptAgentDefinition definition)
        {
            this.Definition = definition;
        }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("draft", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateAsDraft { get; set; } = false;

        [JsonProperty("definition", DefaultValueHandling = DefaultValueHandling.Include)]
        public PromptAgentDefinition Definition { get; set; }
    }

    public class PromptAgentDefinition
    {
        public PromptAgentDefinition(string modelDeployment)
        {
            this.ModelDeployment = modelDeployment;
        }

        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        internal PromptAgentDefinitionKindType Kind { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Azureagentservice.PromptAgentDefinitionKindType.Prompt;

        [JsonProperty("model", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ModelDeployment { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public JToken[] Tools { get; set; }

        [JsonProperty("tool_choice")]
        public JToken ToolChoice { get; set; }

        [JsonProperty("temperature")]
        public double? Temperature { get; set; }

        [JsonProperty("top_p")]
        public double? TopP { get; set; }

        [JsonProperty("text")]
        public JToken TextConfiguration { get; set; }

        [JsonProperty("reasoning")]
        public JToken ReasoningConfiguration { get; set; }

        [JsonProperty("skills")]
        public JToken[] Skills { get; set; }

        [JsonProperty("structured_inputs")]
        public JToken StructuredInputs { get; set; }

        [JsonProperty("harness")]
        public JToken Harness { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PromptAgentDefinitionKindType
    {
        [EnumMember(Value = "prompt")]
        Prompt
    }

    public class CreateThreadResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class CreateThreadRequestBodyInput
    {
        [JsonProperty("messages")]
        public Messages[] Messages { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("tool_resources")]
        public JToken ToolResources { get; set; }
    }

    public class Messages
    {
        [JsonProperty("role")]
        public MessagesRoleType? Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("attachments")]
        public MessagesAttachmentsTypeItem[] Attachments { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MessagesRoleType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant
    }

    public class MessagesAttachmentsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRunResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("required_action")]
        public JToken RequiredAction { get; set; }

        [JsonProperty("last_error")]
        public JToken LastError { get; set; }

        [JsonProperty("expires_at")]
        public int ExpiresAt { get; set; }

        [JsonProperty("started_at")]
        public int StartedAt { get; set; }

        [JsonProperty("cancelled_at")]
        public int CancelledAt { get; set; }

        [JsonProperty("failed_at")]
        public int FailedAt { get; set; }

        [JsonProperty("completed_at")]
        public int CompletedAt { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public CreateRunToolsResponse[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public FileIds[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("tool_choice")]
        public JToken ToolChoice { get; set; }

        [JsonProperty("max_prompt_tokens")]
        public double MaxPromptTokens { get; set; }

        [JsonProperty("max_completion_tokens")]
        public double MaxCompletionTokens { get; set; }

        [JsonProperty("usage")]
        public JToken Usage { get; set; }

        [JsonProperty("truncation_strategy")]
        public JToken TruncationStrategy { get; set; }

        [JsonProperty("response_format")]
        public string ResponseFormat { get; set; }
    }

    public class FileIds
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateRunRequestBodyInput
    {
        public CreateRunRequestBodyInput(string assistantId)
        {
            this.AssistantId = assistantId;
        }

        [JsonProperty("assistant_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AssistantId { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("additional_instructions")]
        public string AdditionalInstructions { get; set; }

        [JsonProperty("additional_messages")]
        public Messages[] AdditionalMessages { get; set; }

        [JsonProperty("tools")]
        public CreateRunTools[] Tools { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("temperature", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? Temperature { get; set; } = 1;

        [JsonProperty("top_p", DefaultValueHandling = DefaultValueHandling.Include)]
        public double? TopP { get; set; } = 1;

        [JsonProperty("stream")]
        public bool? Stream { get; set; }

        [JsonProperty("max_prompt_tokens")]
        public int? MaxPromptTokens { get; set; }

        [JsonProperty("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        [JsonProperty("truncation_strategy")]
        public JToken TruncationStrategy { get; set; }

        [JsonProperty("tool_choice")]
        public JToken ToolChoice { get; set; }

        [JsonProperty("response_format")]
        public JToken ResponseFormat { get; set; }
    }

    public class CreateRunTools
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetRunResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("thread_id")]
        public string ThreadId { get; set; }

        [JsonProperty("assistant_id")]
        public string AssistantId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("required_action")]
        public JToken RequiredAction { get; set; }

        [JsonProperty("last_error")]
        public JToken LastError { get; set; }

        [JsonProperty("expires_at")]
        public int ExpiresAt { get; set; }

        [JsonProperty("started_at")]
        public int StartedAt { get; set; }

        [JsonProperty("cancelled_at")]
        public int CancelledAt { get; set; }

        [JsonProperty("failed_at")]
        public int FailedAt { get; set; }

        [JsonProperty("completed_at")]
        public int CompletedAt { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("tools")]
        public CreateRunToolsResponse[] Tools { get; set; }

        [JsonProperty("file_ids")]
        public FileIds[] FileIds { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("tool_choice")]
        public JToken ToolChoice { get; set; }

        [JsonProperty("max_prompt_tokens")]
        public double MaxPromptTokens { get; set; }

        [JsonProperty("max_completion_tokens")]
        public double MaxCompletionTokens { get; set; }

        [JsonProperty("usage")]
        public JToken Usage { get; set; }

        [JsonProperty("truncation_strategy")]
        public JToken TruncationStrategy { get; set; }

        [JsonProperty("response_format")]
        public string ResponseFormat { get; set; }
    }

    public class ListMessageResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("data")]
        public Data[] Data { get; set; }

        [JsonProperty("first_id")]
        public string FirstId { get; set; }

        [JsonProperty("last_id")]
        public string LastId { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class OpenAIResponse
    {
        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("top_p")]
        public double TopP { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("service_tier")]
        public OpenAIServiceTier ServiceTier { get; set; }

        [JsonProperty("top_logprobs")]
        public int TopLogprobs { get; set; }

        [JsonProperty("previous_response_id")]
        public string PreviousResponseId { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("reasoning")]
        public OpenAIReasoning Reasoning { get; set; }

        [JsonProperty("background")]
        public bool Background { get; set; }

        [JsonProperty("max_output_tokens")]
        public int MaxOutputTokens { get; set; }

        [JsonProperty("max_tool_calls")]
        public int MaxToolCalls { get; set; }

        [JsonProperty("text")]
        public OpenAIResponseTextType Text { get; set; }

        [JsonProperty("tools")]
        public InvokeAgentOpenAIToolResponse[] Tools { get; set; }

        [JsonProperty("tool_choice")]
        public JToken ToolChoice { get; set; }

        [JsonProperty("prompt")]
        public InvokeAgentOpenAIPromptResponse Prompt { get; set; }

        [JsonProperty("truncation")]
        public OpenAIResponseTruncationType Truncation { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        public OpenAIResponseObjectEntityType ObjectEntity { get; set; }

        [JsonProperty("status")]
        public OpenAIResponseStatusType Status { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("error")]
        public OpenAIResponseError Error { get; set; }

        [JsonProperty("incomplete_details")]
        public OpenAIResponseIncompleteDetailsType IncompleteDetails { get; set; }

        [JsonProperty("output")]
        public OpenAIItemResource[] Output { get; set; }

        [JsonProperty("instructions")]
        public JToken Instructions { get; set; }

        [JsonProperty("output_text")]
        public string OutputText { get; set; }

        [JsonProperty("usage")]
        public OpenAIResponseUsage Usage { get; set; }

        [JsonProperty("parallel_tool_calls")]
        public bool ParallelToolCalls { get; set; }

        [JsonProperty("conversation")]
        public OpenAIResponseConversationType Conversation { get; set; }

        [JsonProperty("agent")]
        public AgentId Agent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIServiceTier
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "flex")]
        Flex,
        [EnumMember(Value = "scale")]
        Scale,
        [EnumMember(Value = "priority")]
        Priority
    }

    public class OpenAIReasoning
    {
        [JsonProperty("effort")]
        public OpenAIReasoningEffortType Effort { get; set; }

        [JsonProperty("summary")]
        public OpenAIReasoningSummaryType Summary { get; set; }

        [JsonProperty("generate_summary")]
        public OpenAIReasoningGenerateSummaryType GenerateSummary { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIReasoningEffortType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIReasoningSummaryType
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "concise")]
        Concise,
        [EnumMember(Value = "detailed")]
        Detailed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIReasoningGenerateSummaryType
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "concise")]
        Concise,
        [EnumMember(Value = "detailed")]
        Detailed
    }

    public class OpenAIResponseTextType
    {
        [JsonProperty("format")]
        public InvokeAgentOpenAIResponseTextFormatConfigurationResponse Format { get; set; }
    }

    public class InvokeAgentOpenAIResponseTextFormatConfigurationResponse
    {
        [JsonProperty("type")]
        public InvokeAgentOpenAIResponseTextFormatConfigurationTypeResponse Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvokeAgentOpenAIResponseTextFormatConfigurationTypeResponse
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "json_schema")]
        JsonSchema,
        [EnumMember(Value = "json_object")]
        JsonObject
    }

    public class InvokeAgentOpenAIToolResponse
    {
        [JsonProperty("type")]
        public InvokeAgentOpenAIToolTypeResponse Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvokeAgentOpenAIToolTypeResponse
    {
        [EnumMember(Value = "file_search")]
        FileSearch,
        [EnumMember(Value = "function")]
        Function,
        [EnumMember(Value = "computer_use_preview")]
        ComputerUsePreview,
        [EnumMember(Value = "web_search_preview")]
        WebSearchPreview,
        [EnumMember(Value = "mcp")]
        Mcp,
        [EnumMember(Value = "code_interpreter")]
        CodeInterpreter,
        [EnumMember(Value = "image_generation")]
        ImageGeneration,
        [EnumMember(Value = "local_shell")]
        LocalShell,
        [EnumMember(Value = "bing_grounding")]
        BingGrounding,
        [EnumMember(Value = "browser_automation_preview")]
        BrowserAutomationPreview,
        [EnumMember(Value = "fabric_dataagent_preview")]
        FabricDataagentPreview,
        [EnumMember(Value = "sharepoint_grounding_preview")]
        SharepointGroundingPreview,
        [EnumMember(Value = "azure_ai_search")]
        AzureAiSearch,
        [EnumMember(Value = "openapi")]
        Openapi,
        [EnumMember(Value = "bing_custom_search_preview")]
        BingCustomSearchPreview,
        [EnumMember(Value = "capture_structured_outputs")]
        CaptureStructuredOutputs,
        [EnumMember(Value = "capture_semantic_events")]
        CaptureSemanticEvents,
        [EnumMember(Value = "a2a_preview")]
        A2aPreview,
        [EnumMember(Value = "azure_function")]
        AzureFunction,
        [EnumMember(Value = "memory_search")]
        MemorySearch
    }

    public class InvokeAgentOpenAIPromptResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("variables")]
        public JToken Variables { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIResponseTruncationType
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "disabled")]
        Disabled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIResponseObjectEntityType
    {
        [EnumMember(Value = "response")]
        Response
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIResponseStatusType
    {
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "in_progress")]
        InProgress,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "queued")]
        Queued,
        [EnumMember(Value = "incomplete")]
        Incomplete
    }

    public class OpenAIResponseError
    {
        [JsonProperty("code")]
        public OpenAIResponseErrorCode Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIResponseErrorCode
    {
        [EnumMember(Value = "server_error")]
        ServerError,
        [EnumMember(Value = "rate_limit_exceeded")]
        RateLimitExceeded,
        [EnumMember(Value = "invalid_prompt")]
        InvalidPrompt,
        [EnumMember(Value = "vector_store_timeout")]
        VectorStoreTimeout,
        [EnumMember(Value = "invalid_image")]
        InvalidImage,
        [EnumMember(Value = "invalid_image_format")]
        InvalidImageFormat,
        [EnumMember(Value = "invalid_base64_image")]
        InvalidBase64Image,
        [EnumMember(Value = "invalid_image_url")]
        InvalidImageUrl,
        [EnumMember(Value = "image_too_large")]
        ImageTooLarge,
        [EnumMember(Value = "image_too_small")]
        ImageTooSmall,
        [EnumMember(Value = "image_parse_error")]
        ImageParseError,
        [EnumMember(Value = "image_content_policy_violation")]
        ImageContentPolicyViolation,
        [EnumMember(Value = "invalid_image_mode")]
        InvalidImageMode,
        [EnumMember(Value = "image_file_too_large")]
        ImageFileTooLarge,
        [EnumMember(Value = "unsupported_image_media_type")]
        UnsupportedImageMediaType,
        [EnumMember(Value = "empty_image_file")]
        EmptyImageFile,
        [EnumMember(Value = "failed_to_download_image")]
        FailedToDownloadImage,
        [EnumMember(Value = "image_file_not_found")]
        ImageFileNotFound
    }

    public class OpenAIResponseIncompleteDetailsType
    {
        [JsonProperty("reason")]
        public OpenAIResponseIncompleteDetailsTypeReasonType Reason { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIResponseIncompleteDetailsTypeReasonType
    {
        [EnumMember(Value = "max_output_tokens")]
        MaxOutputTokens,
        [EnumMember(Value = "content_filter")]
        ContentFilter
    }

    public class OpenAIItemResource
    {
        [JsonProperty("type")]
        public OpenAIItemType Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIItemType
    {
        [EnumMember(Value = "message")]
        Message,
        [EnumMember(Value = "file_search_call")]
        FileSearchCall,
        [EnumMember(Value = "function_call")]
        FunctionCall,
        [EnumMember(Value = "function_call_output")]
        FunctionCallOutput,
        [EnumMember(Value = "computer_call")]
        ComputerCall,
        [EnumMember(Value = "computer_call_output")]
        ComputerCallOutput,
        [EnumMember(Value = "web_search_call")]
        WebSearchCall,
        [EnumMember(Value = "reasoning")]
        Reasoning,
        [EnumMember(Value = "item_reference")]
        ItemReference,
        [EnumMember(Value = "image_generation_call")]
        ImageGenerationCall,
        [EnumMember(Value = "code_interpreter_call")]
        CodeInterpreterCall,
        [EnumMember(Value = "local_shell_call")]
        LocalShellCall,
        [EnumMember(Value = "local_shell_call_output")]
        LocalShellCallOutput,
        [EnumMember(Value = "mcp_list_tools")]
        McpListTools,
        [EnumMember(Value = "mcp_approval_request")]
        McpApprovalRequest,
        [EnumMember(Value = "mcp_approval_response")]
        McpApprovalResponse,
        [EnumMember(Value = "mcp_call")]
        McpCall,
        [EnumMember(Value = "structured_inputs")]
        StructuredInputs,
        [EnumMember(Value = "structured_outputs")]
        StructuredOutputs,
        [EnumMember(Value = "semantic_event")]
        SemanticEvent,
        [EnumMember(Value = "workflow_action")]
        WorkflowAction,
        [EnumMember(Value = "memory_search_call")]
        MemorySearchCall
    }

    public class OpenAIResponseUsage
    {
        [JsonProperty("input_tokens")]
        public int InputTokens { get; set; }

        [JsonProperty("input_tokens_details")]
        public OpenAIResponseUsageInputTokensDetailsType InputTokensDetails { get; set; }

        [JsonProperty("output_tokens")]
        public int OutputTokens { get; set; }

        [JsonProperty("output_tokens_details")]
        public OpenAIResponseUsageOutputTokensDetailsType OutputTokensDetails { get; set; }

        [JsonProperty("total_tokens")]
        public int TotalTokens { get; set; }
    }

    public class OpenAIResponseUsageInputTokensDetailsType
    {
        [JsonProperty("cached_tokens")]
        public int CachedTokens { get; set; }
    }

    public class OpenAIResponseUsageOutputTokensDetailsType
    {
        [JsonProperty("reasoning_tokens")]
        public int ReasoningTokens { get; set; }
    }

    public class OpenAIResponseConversationType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class AgentId
    {
        [JsonProperty("type")]
        public AgentIdTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AgentIdTypeType
    {
        [EnumMember(Value = "agent_id")]
        AgentId
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvokeAgentApiVersionInput
    {
        [EnumMember(Value = "2025-11-15-preview")]
        _20251115Preview
    }

    public class InvokeAgentBodyInput
    {
        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("top_logprobs")]
        public int? TopLogprobs { get; set; }

        [JsonProperty("previous_response_id")]
        public string PreviousResponseId { get; set; }

        [JsonProperty("background", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Background { get; set; } = false;

        [JsonProperty("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        [JsonProperty("max_tool_calls")]
        public int? MaxToolCalls { get; set; }

        [JsonProperty("text")]
        public BodyInputTextType Text { get; set; }

        [JsonProperty("tools")]
        public InvokeAgentOpenAITool[] Tools { get; set; }

        [JsonProperty("tool_choice")]
        public JToken ToolChoice { get; set; }

        [JsonProperty("prompt")]
        public InvokeAgentOpenAIPrompt Prompt { get; set; }

        [JsonProperty("truncation", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTruncationType? Truncation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Azureagentservice.BodyInputTruncationType.Disabled;

        [JsonProperty("input")]
        public JToken Input { get; set; }

        [JsonProperty("include")]
        public OpenAIIncludable[] Include { get; set; }

        [JsonProperty("parallel_tool_calls", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ParallelToolCalls { get; set; } = true;

        [JsonProperty("store", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Store { get; set; } = true;

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("conversation")]
        public BodyInputConversationType Conversation { get; set; }

        [JsonProperty("agent")]
        public AgentReference Agent { get; set; }
    }

    public class BodyInputTextType
    {
        [JsonProperty("format")]
        public InvokeAgentOpenAIResponseTextFormatConfiguration Format { get; set; }
    }

    public class InvokeAgentOpenAIResponseTextFormatConfiguration
    {
        public InvokeAgentOpenAIResponseTextFormatConfiguration(InvokeAgentOpenAIResponseTextFormatConfigurationType type)
        {
            this.Type = type;
        }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InvokeAgentOpenAIResponseTextFormatConfigurationType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvokeAgentOpenAIResponseTextFormatConfigurationType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "json_schema")]
        JsonSchema,
        [EnumMember(Value = "json_object")]
        JsonObject
    }

    public class InvokeAgentOpenAITool
    {
        public InvokeAgentOpenAITool(InvokeAgentOpenAIToolType type)
        {
            this.Type = type;
        }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public InvokeAgentOpenAIToolType Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvokeAgentOpenAIToolType
    {
        [EnumMember(Value = "file_search")]
        FileSearch,
        [EnumMember(Value = "function")]
        Function,
        [EnumMember(Value = "computer_use_preview")]
        ComputerUsePreview,
        [EnumMember(Value = "web_search_preview")]
        WebSearchPreview,
        [EnumMember(Value = "mcp")]
        Mcp,
        [EnumMember(Value = "code_interpreter")]
        CodeInterpreter,
        [EnumMember(Value = "image_generation")]
        ImageGeneration,
        [EnumMember(Value = "local_shell")]
        LocalShell,
        [EnumMember(Value = "bing_grounding")]
        BingGrounding,
        [EnumMember(Value = "browser_automation_preview")]
        BrowserAutomationPreview,
        [EnumMember(Value = "fabric_dataagent_preview")]
        FabricDataagentPreview,
        [EnumMember(Value = "sharepoint_grounding_preview")]
        SharepointGroundingPreview,
        [EnumMember(Value = "azure_ai_search")]
        AzureAiSearch,
        [EnumMember(Value = "openapi")]
        Openapi,
        [EnumMember(Value = "bing_custom_search_preview")]
        BingCustomSearchPreview,
        [EnumMember(Value = "capture_structured_outputs")]
        CaptureStructuredOutputs,
        [EnumMember(Value = "capture_semantic_events")]
        CaptureSemanticEvents,
        [EnumMember(Value = "a2a_preview")]
        A2aPreview,
        [EnumMember(Value = "azure_function")]
        AzureFunction,
        [EnumMember(Value = "memory_search")]
        MemorySearch
    }

    public class InvokeAgentOpenAIPrompt
    {
        public InvokeAgentOpenAIPrompt(string id)
        {
            this.Id = id;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("variables")]
        public JToken Variables { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTruncationType
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "disabled")]
        Disabled
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OpenAIIncludable
    {
        [EnumMember(Value = "code_interpreter_call.outputs")]
        CodeInterpreterCallOutputs,
        [EnumMember(Value = "computer_call_output.output.image_url")]
        ComputerCallOutputOutputImageUrl,
        [EnumMember(Value = "file_search_call.results")]
        FileSearchCallResults,
        [EnumMember(Value = "message.input_image.image_url")]
        MessageInputImageImageUrl,
        [EnumMember(Value = "message.output_text.logprobs")]
        MessageOutputTextLogprobs,
        [EnumMember(Value = "reasoning.encrypted_content")]
        ReasoningEncryptedContent,
        [EnumMember(Value = "memory_search_call.results")]
        MemorySearchCallResults
    }

    public class BodyInputConversationType
    {
        public BodyInputConversationType(BodyInputConversationTypeConversationIdType conversationId)
        {
            this.ConversationId = conversationId;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConversationTypeConversationIdType ConversationId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputConversationTypeConversationIdType
    {
        [EnumMember(Value = "Create new Conversation")]
        CreateNewConversation
    }

    public class AgentReference
    {
        public AgentReference(AgentReferenceTypeType type, string name, string version)
        {
            this.Type = type;
            this.Name = name;
            this.Version = version;
        }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public AgentReferenceTypeType Type { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("version", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Version { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AgentReferenceTypeType
    {
        [EnumMember(Value = "agent_reference")]
        AgentReference
    }

    public class InvokeHostedAgentResponsesBodyInput
    {
        public InvokeHostedAgentResponsesBodyInput(JToken input)
        {
            this.Input = input;
        }

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Input { get; set; }

        [JsonProperty("previous_response_id")]
        public string PreviousResponseId { get; set; }

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("store", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? StoreResponse { get; set; } = true;

        [JsonProperty("background", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunInBackground { get; set; } = false;

        [JsonProperty("max_output_tokens")]
        public int? MaximumOutputTokens { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("stream", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Stream { get; set; } = false;
    }

    public class HostedSession
    {
        [JsonProperty("agent_session_id")]
        public string AgentSessionId { get; set; }

        [JsonProperty("version_indicator")]
        public HostedSessionVersionIndicator VersionIndicator { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("last_accessed_at")]
        public int LastAccessedAt { get; set; }

        [JsonProperty("expires_at")]
        public int ExpiresAt { get; set; }

        [JsonProperty("stopped_at")]
        public int StoppedAt { get; set; }
    }

    public class HostedSessionVersionIndicator
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("agent_version")]
        public string AgentVersion { get; set; }
    }

    public class CreateHostedSessionBodyInput
    {
        [JsonProperty("agent_version")]
        public string AgentVersion { get; set; }
    }

    public class HostedSessionListResponse
    {
        [JsonProperty("data")]
        public HostedSession[] Data { get; set; }

        [JsonProperty("first_id")]
        public string FirstId { get; set; }

        [JsonProperty("last_id")]
        public string LastId { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class HostedSessionFileUploadResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("bytes_written")]
        public int BytesWritten { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("source_type")]
        public string SourceType { get; set; }
    }

    public class HostedSessionFileListResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("entries")]
        public HostedSessionFileEntry[] Entries { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    }

    public class HostedSessionFileEntry
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("is_directory")]
        public bool IsDirectory { get; set; }

        [JsonProperty("modified_time")]
        public int ModifiedTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureagentservice;

    public partial class WorkflowManagedActions
    {
        public AzureagentserviceActions Azureagentservice(string connectionId) => new AzureagentserviceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureagentserviceTriggers Azureagentservice(string connectionId) => new AzureagentserviceTriggers(connectionId);
    }
}