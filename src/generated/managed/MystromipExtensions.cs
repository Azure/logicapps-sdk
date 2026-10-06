//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mystromip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MystromipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteScene))]
        public IBodyWorkflowAction<ExecuteSceneResponse> ExecuteScene([WorkflowExpression] Func<string> sceneID, [WorkflowExpression] Func<string> authToken)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExecuteSceneResponse> __BuildExecuteScene(WorkflowExpression<string> sceneID, WorkflowExpression<string> authToken)
        {
            WorkflowExpression.Validate(sceneID, nameof(sceneID), required: true);
            WorkflowExpression.Validate(authToken, nameof(authToken), required: true);
            return new DeferredBodyAction<ExecuteSceneResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/scene/{0}", ExpressionConverter.ConvertWithUrlEncoding(sceneID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(authToken);
                return new ApiConnectionAction<ExecuteSceneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        [WorkflowExpressionFactory(nameof(__BuildGetWebhook))]
        public IBodyWorkflowAction<GetWebhookResponse> GetWebhook([WorkflowExpression] Func<string> deviceID, [WorkflowExpression] Func<string> authToken)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetWebhookResponse> __BuildGetWebhook(WorkflowExpression<string> deviceID, WorkflowExpression<string> authToken)
        {
            WorkflowExpression.Validate(deviceID, nameof(deviceID), required: true);
            WorkflowExpression.Validate(authToken, nameof(authToken), required: true);
            return new DeferredBodyAction<GetWebhookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhook/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(authToken);
                return new ApiConnectionAction<GetWebhookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteWebhook))]
        public IBodyWorkflowAction<DeleteWebhookResponse> DeleteWebhook([WorkflowExpression] Func<string> deviceID, [WorkflowExpression] Func<string> authToken)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteWebhookResponse> __BuildDeleteWebhook(WorkflowExpression<string> deviceID, WorkflowExpression<string> authToken)
        {
            WorkflowExpression.Validate(deviceID, nameof(deviceID), required: true);
            WorkflowExpression.Validate(authToken, nameof(authToken), required: true);
            return new DeferredBodyAction<DeleteWebhookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhook/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(authToken);
                return new ApiConnectionAction<DeleteWebhookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWebhook))]
        public IBodyWorkflowAction<CreateWebhookResponse> CreateWebhook([WorkflowExpression] Func<string> deviceID, [WorkflowExpression] Func<string> webhook, [WorkflowExpression] Func<string> authToken)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateWebhookResponse> __BuildCreateWebhook(WorkflowExpression<string> deviceID, WorkflowExpression<string> webhook, WorkflowExpression<string> authToken)
        {
            WorkflowExpression.Validate(deviceID, nameof(deviceID), required: true);
            WorkflowExpression.Validate(webhook, nameof(webhook), required: true);
            WorkflowExpression.Validate(authToken, nameof(authToken), required: true);
            return new DeferredBodyAction<CreateWebhookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/webhook/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["webhook"] = ExpressionConverter.Convert(webhook);
                callPayload.Queries["authToken"] = ExpressionConverter.Convert(authToken);
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