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
        public IBodyWorkflowAction<ExecuteSceneResponse> ExecuteScene(Expression<Func<string>> sceneID, Expression<Func<string>> authToken)
        {
            var __workflow_sceneID = WorkflowExpression.Compile(sceneID, nameof(sceneID), required: true);
            var __workflow_authToken = WorkflowExpression.Compile(authToken, nameof(authToken), required: true);
            return new DeferredBodyAction<ExecuteSceneResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/scene/{0}", __workflow_sceneID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(__workflow_authToken);
                return new ApiConnectionAction<ExecuteSceneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<GetWebhookResponse> GetWebhook(Expression<Func<string>> deviceID, Expression<Func<string>> authToken)
        {
            var __workflow_deviceID = WorkflowExpression.Compile(deviceID, nameof(deviceID), required: true);
            var __workflow_authToken = WorkflowExpression.Compile(authToken, nameof(authToken), required: true);
            return new DeferredBodyAction<GetWebhookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhook/{0}", __workflow_deviceID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(__workflow_authToken);
                return new ApiConnectionAction<GetWebhookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<DeleteWebhookResponse> DeleteWebhook(Expression<Func<string>> deviceID, Expression<Func<string>> authToken)
        {
            var __workflow_deviceID = WorkflowExpression.Compile(deviceID, nameof(deviceID), required: true);
            var __workflow_authToken = WorkflowExpression.Compile(authToken, nameof(authToken), required: true);
            return new DeferredBodyAction<DeleteWebhookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhook/{0}", __workflow_deviceID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(__workflow_authToken);
                return new ApiConnectionAction<DeleteWebhookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<CreateWebhookResponse> CreateWebhook(Expression<Func<string>> deviceID, Expression<Func<string>> webhook, Expression<Func<string>> authToken)
        {
            var __workflow_deviceID = WorkflowExpression.Compile(deviceID, nameof(deviceID), required: true);
            var __workflow_webhook = WorkflowExpression.Compile(webhook, nameof(webhook), required: true);
            var __workflow_authToken = WorkflowExpression.Compile(authToken, nameof(authToken), required: true);
            return new DeferredBodyAction<CreateWebhookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhook/{0}", __workflow_deviceID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["webhook"] = ExpressionConverter.Convert(__workflow_webhook);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(__workflow_authToken);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
