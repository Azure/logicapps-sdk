//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airslate
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirslateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airslate")]
        public IBodyWorkflowAction<CreateSmartLinkResponse, ApiConnectionActionConfiguration> CreateSmartLink(Expression<Func<string>> organizationDomain, Expression<Func<string>> slateId, Expression<Func<object>> fields = null)
        {
            var __workflow_organizationDomain = WorkflowExpression.Compile(organizationDomain, nameof(organizationDomain), required: true);
            var __workflow_slateId = WorkflowExpression.Compile(slateId, nameof(slateId), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<CreateSmartLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/flows/{0}/smartLink/create", __workflow_slateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Organization-Domain"] = ExpressionConverter.Convert(__workflow_organizationDomain);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_fields != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_fields);
                return new ApiConnectionAction<CreateSmartLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airslate")]
        public IBodyWorkflowAction<StartFlowResponse, ApiConnectionActionConfiguration> StartFlow(Expression<Func<string>> organizationDomain, Expression<Func<string>> slateId, Expression<Func<object>> fields = null)
        {
            var __workflow_organizationDomain = WorkflowExpression.Compile(organizationDomain, nameof(organizationDomain), required: true);
            var __workflow_slateId = WorkflowExpression.Compile(slateId, nameof(slateId), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<StartFlowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/addon-proxy/flow/v1/flows/{0}/packets/blank", __workflow_slateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Organization-Domain"] = ExpressionConverter.Convert(__workflow_organizationDomain);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_fields != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_fields);
                return new ApiConnectionAction<StartFlowResponse>(callPayload);
            });
        }
    }

    public class AirslateTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CreateSlateTriggerResponse, ApiConnectionTriggerConfiguration> CreateSlateTrigger(Expression<Func<CreateSlateTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<CreateSlateTriggerResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/event";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<CreateSlateTriggerResponse>(callPayload, recurrence: recurrence);
            });
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

    public class CreateSlateTriggerInput
    {
        [JsonProperty("botToken", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BotAuthorizationToken { get; set; }

        [JsonProperty("callback", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callback { get; set; } = "#{listCallbackUrl()}";
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