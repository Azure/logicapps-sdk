//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airslate
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirslateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airslate")]
        public IBodyWorkflowAction<CreateSmartLinkResponse> CreateSmartLink([WorkflowExpression] Func<string> organizationDomain, [WorkflowExpression] Func<string> slateId, [WorkflowExpression] Func<object> fields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/flows/{0}/smartLink/create", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(slateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Organization-Domain"] = SourceExpressionConverter.ConvertO(organizationDomain);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = SourceExpressionConverter.ConvertToken(fields);
                return callPayload;
            }

            return new ApiConnectionAction<CreateSmartLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airslate")]
        public IBodyWorkflowAction<StartFlowResponse> StartFlow([WorkflowExpression] Func<string> organizationDomain, [WorkflowExpression] Func<string> slateId, [WorkflowExpression] Func<object> fields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/addon-proxy/flow/v1/flows/{0}/packets/blank", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(slateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Organization-Domain"] = SourceExpressionConverter.ConvertO(organizationDomain);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = SourceExpressionConverter.ConvertToken(fields);
                return callPayload;
            }

            return new ApiConnectionAction<StartFlowResponse>(BuildSourceInput);
        }
    }

    public class AirslateTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CreateSlateTriggerResponse> CreateSlateTrigger([WorkflowExpression] Func<string> bodybotAuthorizationToken, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/event";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["botToken"] = SourceExpressionConverter.ConvertToken(bodybotAuthorizationToken);
                body["callback"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<CreateSlateTriggerResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class CreateSmartLinkResponse
    {
        [JsonProperty("smartLink")]
        public string SmartLink { get; set; }
    }

    public class StartFlowResponse
    {
        [JsonProperty("data")]
        public StartFlowResponseDataType Data { get; set; }
    }

    public class StartFlowResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateSlateTriggerResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Airslate;

    public partial class WorkflowManagedActions
    {
        public AirslateActions Airslate(string connectionId) => new AirslateActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AirslateTriggers Airslate(string connectionId) => new AirslateTriggers(connectionId);
    }
}