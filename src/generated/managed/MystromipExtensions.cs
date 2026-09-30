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
        public IBodyWorkflowAction<ExecuteSceneResponse> ExecuteScene([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> sceneID, [WorkflowExpression] Func<string> authToken)
        {
            var apiCallPath = String.Format("/scene/{0}", ExpressionConverter.ConvertWithUrlEncoding(sceneID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["authToken"] = ExpressionConverter.Convert(authToken);
            return new ApiConnectionAction<ExecuteSceneResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<GetWebhookResponse> GetWebhook([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> deviceID, [WorkflowExpression] Func<string> authToken)
        {
            var apiCallPath = String.Format("/webhook/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["authToken"] = ExpressionConverter.Convert(authToken);
            return new ApiConnectionAction<GetWebhookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<DeleteWebhookResponse> DeleteWebhook([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> deviceID, [WorkflowExpression] Func<string> authToken)
        {
            var apiCallPath = String.Format("/webhook/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["authToken"] = ExpressionConverter.Convert(authToken);
            return new ApiConnectionAction<DeleteWebhookResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<CreateWebhookResponse> CreateWebhook([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> deviceID, [WorkflowExpression] Func<string> webhook, [WorkflowExpression] Func<string> authToken)
        {
            var apiCallPath = String.Format("/webhook/{0}", ExpressionConverter.ConvertWithUrlEncoding(deviceID, 1));
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