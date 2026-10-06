//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airslate
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirslateActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airslate")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSmartLink))]
        public IBodyWorkflowAction<CreateSmartLinkResponse> CreateSmartLink([WorkflowExpression] Func<string> organizationDomain, [WorkflowExpression] Func<string> slateId, [WorkflowExpression] Func<object> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airslate")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSmartLinkResponse> __BuildCreateSmartLink(WorkflowExpression<string> organizationDomain, WorkflowExpression<string> slateId, WorkflowExpression<object> fields = null)
        {
            WorkflowExpression.Validate(organizationDomain, nameof(organizationDomain), required: true);
            WorkflowExpression.Validate(slateId, nameof(slateId), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<CreateSmartLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/flows/{0}/smartLink/create", ExpressionConverter.ConvertWithUrlEncoding(slateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Organization-Domain"] = ExpressionConverter.Convert(organizationDomain);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(fields);
                return new ApiConnectionAction<CreateSmartLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airslate")]
        [WorkflowExpressionFactory(nameof(__BuildStartFlow))]
        public IBodyWorkflowAction<StartFlowResponse> StartFlow([WorkflowExpression] Func<string> organizationDomain, [WorkflowExpression] Func<string> slateId, [WorkflowExpression] Func<object> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airslate")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StartFlowResponse> __BuildStartFlow(WorkflowExpression<string> organizationDomain, WorkflowExpression<string> slateId, WorkflowExpression<object> fields = null)
        {
            WorkflowExpression.Validate(organizationDomain, nameof(organizationDomain), required: true);
            WorkflowExpression.Validate(slateId, nameof(slateId), required: true);
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<StartFlowResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/addon-proxy/flow/v1/flows/{0}/packets/blank", ExpressionConverter.ConvertWithUrlEncoding(slateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Organization-Domain"] = ExpressionConverter.Convert(organizationDomain);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(fields);
                return new ApiConnectionAction<StartFlowResponse>(callPayload);
            });
        }
    }

    public class AirslateTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildCreateSlateTrigger))]
        public IBodyWorkflowTrigger<CreateSlateTriggerResponse> CreateSlateTrigger([WorkflowExpression] Func<string> bodybotAuthorizationToken, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<CreateSlateTriggerResponse> __BuildCreateSlateTrigger(WorkflowExpression<string> bodybotAuthorizationToken, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodybotAuthorizationToken, nameof(bodybotAuthorizationToken), required: true);
            return new DeferredBodyTrigger<CreateSlateTriggerResponse>(() =>
            {
                var apiCallPath = "/event";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["botToken"] = ExpressionConverter.ConvertO(bodybotAuthorizationToken);
                body["callback"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<CreateSlateTriggerResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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