//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mystromip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MystromipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<ExecuteSceneResponse> ExecuteScene([WorkflowExpression] Func<string> sceneID, [WorkflowExpression] Func<string> authToken)
        {
            SourceExpression.Validate(sceneID, nameof(sceneID), required: true);
            SourceExpression.Validate(authToken, nameof(authToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/scene/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sceneID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["authToken"] = SourceExpressionConverter.ConvertO(authToken);
                return callPayload;
            }

            return new ApiConnectionAction<ExecuteSceneResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<GetWebhookResponse> GetWebhook([WorkflowExpression] Func<string> deviceID, [WorkflowExpression] Func<string> authToken)
        {
            SourceExpression.Validate(deviceID, nameof(deviceID), required: true);
            SourceExpression.Validate(authToken, nameof(authToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhook/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deviceID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["authToken"] = SourceExpressionConverter.ConvertO(authToken);
                return callPayload;
            }

            return new ApiConnectionAction<GetWebhookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<DeleteWebhookResponse> DeleteWebhook([WorkflowExpression] Func<string> deviceID, [WorkflowExpression] Func<string> authToken)
        {
            SourceExpression.Validate(deviceID, nameof(deviceID), required: true);
            SourceExpression.Validate(authToken, nameof(authToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhook/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deviceID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["authToken"] = SourceExpressionConverter.ConvertO(authToken);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteWebhookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mystromip")]
        public IBodyWorkflowAction<CreateWebhookResponse> CreateWebhook([WorkflowExpression] Func<string> deviceID, [WorkflowExpression] Func<string> webhook, [WorkflowExpression] Func<string> authToken)
        {
            SourceExpression.Validate(deviceID, nameof(deviceID), required: true);
            SourceExpression.Validate(webhook, nameof(webhook), required: true);
            SourceExpression.Validate(authToken, nameof(authToken), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/webhook/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deviceID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["webhook"] = SourceExpressionConverter.ConvertO(webhook);
                callPayload.Queries["authToken"] = SourceExpressionConverter.ConvertO(authToken);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateWebhookResponse>(BuildSourceInput);
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