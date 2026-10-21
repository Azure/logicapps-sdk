//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Captisaforms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CaptisaformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "captisaforms")]
        public IBodyWorkflowAction<FormFieldResponse> CreateEntry(Expression<Func<string>> formID, Expression<Func<object>> body = null)
        {
            var __workflow_formID = WorkflowExpression.Compile(formID, nameof(formID), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<FormFieldResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/data/{0}", __workflow_formID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FormFieldResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "captisaforms")]
        public IBodyWorkflowAction<FormFieldResponse> UpdateEntry(Expression<Func<string>> formID, Expression<Func<string>> id, Expression<Func<object>> body = null)
        {
            var __workflow_formID = WorkflowExpression.Compile(formID, nameof(formID), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<FormFieldResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/data/{0}/{1}", __workflow_formID.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FormFieldResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class CaptisaformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookResponse> WebhookCreateTrigger(Expression<Func<string>> formID, FlowRecurrence recurrence = null)
        {
            var __workflow_formID = WorkflowExpression.Compile(formID, nameof(formID), required: true);
            return new DeferredBodyTrigger<WebhookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/msflow/forms/{0}/c/subscribe", __workflow_formID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackURL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<WebhookResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<WebhookResponse> WebhookUpdateTrigger(Expression<Func<string>> formID, FlowRecurrence recurrence = null)
        {
            var __workflow_formID = WorkflowExpression.Compile(formID, nameof(formID), required: true);
            return new DeferredBodyTrigger<WebhookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/msflow/forms/{0}/u/subscribe", __workflow_formID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackURL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<WebhookResponse>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }
    }

    public class FormFieldResponse
    {
        [JsonProperty("content")]
        public JToken Content { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("responseCode")]
        public int ResponseCode { get; set; }
    }

    public class WebhookResponse
    {
        [JsonProperty("content")]
        public WebhookResponseContentType Content { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("responseCode")]
        public int ResponseCode { get; set; }
    }

    public class WebhookResponseContentType
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("webhookDeleteUrl")]
        public string WebhookDeleteUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Captisaforms;

    public partial class WorkflowManagedActions
    {
        public CaptisaformsActions Captisaforms(string connectionId) => new CaptisaformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CaptisaformsTriggers Captisaforms(string connectionId) => new CaptisaformsTriggers(connectionId);
    }
}
