//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mystromip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MystromipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<ExecuteSceneResponse, ApiConnectionActionConfiguration> ExecuteScene(Expression<Func<string>> sceneId, Expression<Func<string>> authToken)
        {
            var __workflow_sceneId = WorkflowExpression.Compile(sceneId, nameof(sceneId), required: true);
            var __workflow_authToken = WorkflowExpression.Compile(authToken, nameof(authToken), required: true);
            return new DeferredBodyAction<ExecuteSceneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/scene/{0}", __workflow_sceneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(__workflow_authToken);
                return new ApiConnectionAction<ExecuteSceneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<GetWebhookResponse, ApiConnectionActionConfiguration> GetWebhook(Expression<Func<string>> deviceId, Expression<Func<string>> authToken)
        {
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_authToken = WorkflowExpression.Compile(authToken, nameof(authToken), required: true);
            return new DeferredBodyAction<GetWebhookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhook/{0}", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(__workflow_authToken);
                return new ApiConnectionAction<GetWebhookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<DeleteWebhookResponse, ApiConnectionActionConfiguration> DeleteWebhook(Expression<Func<string>> deviceId, Expression<Func<string>> authToken)
        {
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_authToken = WorkflowExpression.Compile(authToken, nameof(authToken), required: true);
            return new DeferredBodyAction<DeleteWebhookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhook/{0}", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(__workflow_authToken);
                return new ApiConnectionAction<DeleteWebhookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<CreateWebhookResponse, ApiConnectionActionConfiguration> CreateWebhook(Expression<Func<string>> deviceId, Expression<Func<string>> webhook, Expression<Func<string>> authToken, Expression<Func<object>> body = null)
        {
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_webhook = WorkflowExpression.Compile(webhook, nameof(webhook), required: true);
            var __workflow_authToken = WorkflowExpression.Compile(authToken, nameof(authToken), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateWebhookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhook/{0}", __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["webhook"] = ExpressionConverter.Convert(__workflow_webhook);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(__workflow_authToken);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateWebhookResponse>(callPayload);
            });
        }
    }

    public class MystromipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ExecuteSceneResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class GetWebhookResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class DeleteWebhookResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class CreateWebhookResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mystromip;

    public partial class WorkflowManagedActions
    {
        public MystromipActions Mystromip(string connectionId) => new MystromipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MystromipTriggers Mystromip(string connectionId) => new MystromipTriggers(connectionId);
    }
}