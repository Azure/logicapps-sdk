//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Captisaforms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CaptisaformsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "captisaforms")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEntry))]
        public IBodyWorkflowAction<FormFieldResponse> CreateEntry([WorkflowExpression] Func<string> formID, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "captisaforms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FormFieldResponse> __BuildCreateEntry(WorkflowExpression<string> formID, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(formID, nameof(formID), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<FormFieldResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/data/{0}", ExpressionConverter.ConvertWithUrlEncoding(formID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<FormFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "captisaforms")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateEntry))]
        public IBodyWorkflowAction<FormFieldResponse> UpdateEntry([WorkflowExpression] Func<string> formID, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "captisaforms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FormFieldResponse> __BuildUpdateEntry(WorkflowExpression<string> formID, WorkflowExpression<string> id, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(formID, nameof(formID), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<FormFieldResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/data/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(formID, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<FormFieldResponse>(callPayload);
            });
        }
    }

    public class CaptisaformsTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildWebhookCreateTrigger))]
        public IBodyWorkflowTrigger<WebhookResponse> WebhookCreateTrigger([WorkflowExpression] Func<string> formID,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebhookResponse> __BuildWebhookCreateTrigger(WorkflowExpression<string> formID,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(formID, nameof(formID), required: true);
            return new DeferredBodyTrigger<WebhookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/msflow/forms/{0}/c/subscribe", ExpressionConverter.ConvertWithUrlEncoding(formID, 1));
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
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildWebhookUpdateTrigger))]
        public IBodyWorkflowTrigger<WebhookResponse> WebhookUpdateTrigger([WorkflowExpression] Func<string> formID,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebhookResponse> __BuildWebhookUpdateTrigger(WorkflowExpression<string> formID,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(formID, nameof(formID), required: true);
            return new DeferredBodyTrigger<WebhookResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/msflow/forms/{0}/u/subscribe", ExpressionConverter.ConvertWithUrlEncoding(formID, 1));
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
            });
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