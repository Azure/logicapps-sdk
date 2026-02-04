//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Captisaforms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CaptisaformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "captisaforms")]
        public IBodyWorkflowAction<FormFieldResponse> CreateEntry(Expression<Func<string>> formID, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/v1/data/{0}", ExpressionConverter.ConvertWithUrlEncoding(formID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<FormFieldResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "captisaforms")]
        public IBodyWorkflowAction<FormFieldResponse> UpdateEntry(Expression<Func<string>> formID, Expression<Func<string>> id, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/v1/data/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(formID, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<FormFieldResponse>(callPayload);
        }
    }

    public class CaptisaformsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookResponse> WebhookCreateTrigger(Expression<Func<string>> formID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/v1/msflow/forms/{0}/c/subscribe", ExpressionConverter.ConvertWithUrlEncoding(formID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackURL"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookResponse> WebhookUpdateTrigger(Expression<Func<string>> formID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/v1/msflow/forms/{0}/u/subscribe", ExpressionConverter.ConvertWithUrlEncoding(formID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackURL"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookResponse>(callPayload, triggerName, recurrence);
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