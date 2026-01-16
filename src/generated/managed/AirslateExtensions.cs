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
        public IBodyWorkflowAction<CreateSmartLinkResponse> CreateSmartLink(Expression<Func<string>> organizationDomain, Expression<Func<string>> slateId, Expression<Func<object>> fields = null)
        {
            var apiCallPath = String.Format("/flows/{0}/smartLink/create", ExpressionConverter.ConvertWithUrlEncoding(slateId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Organization-Domain"] = ExpressionConverter.Convert(organizationDomain);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Body = ExpressionConverter.ConvertO(fields);
            return new ApiConnectionAction<CreateSmartLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airslate")]
        public IBodyWorkflowAction<StartFlowResponse> StartFlow(Expression<Func<string>> organizationDomain, Expression<Func<string>> slateId, Expression<Func<object>> fields = null)
        {
            var apiCallPath = String.Format("/addon-proxy/flow/v1/flows/{0}/packets/blank", ExpressionConverter.ConvertWithUrlEncoding(slateId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Organization-Domain"] = ExpressionConverter.Convert(organizationDomain);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Body = ExpressionConverter.ConvertO(fields);
            return new ApiConnectionAction<StartFlowResponse>(callPayload);
        }
    }

    public class AirslateTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<CreateSlateTriggerResponse> CreateSlateTrigger(Expression<Func<string>> bodybotAuthorizationToken, string triggerName = null)
        {
            var apiCallPath = "/event";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["botToken"] = ExpressionConverter.ConvertO(bodybotAuthorizationToken);
            body["callback"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<CreateSlateTriggerResponse>(callPayload);
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