//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftforms
{
    using System.Net;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public static class MicrosoftformsExtensions
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftforms")]
        public static IWorkflowTrigger WhenCreateFormWebhook([ConnectionName] string connectionId, [DynamicValues("ListForms")] Expression<Func<string>> formId)
        {
            var apiCallPath = String.Format("/formapi/api/forms/{0}/webhooks", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            // callPayload.Body = ExpressionConverter.ConvertObject(requestBodyOfWebhook);
            return new ApiConnectionTrigger(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftforms")]
        public static IOutputWorkflowAction<JToken> GetFormResponseById([ConnectionName] string connectionId, [DynamicValues("ListForms")] Expression<Func<string>> formId, Expression<Func<int>> responseId)
        {
            var apiCallPath = String.Format("/formapi/api/forms('{0}')/responses", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["response_id"] = ExpressionConverter.Convert(responseId);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class MicrosoftformsInstance(string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "microsoftforms")]
        public IOutputWorkflowAction<JToken> GetFormResponseById([DynamicValues("ListForms")] Expression<Func<string>> formId, Expression<Func<int>> responseId) => MicrosoftformsExtensions.GetFormResponseById(connectionId, formId, responseId);
    }

    public class MicrosoftformsInstanceTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WhenCreateFormWebhook([DynamicValues("ListForms")] Expression<Func<string>> formId) => MicrosoftformsExtensions.WhenCreateFormWebhook(connectionId, formId);
    }

    public class WebhookRequestBody
    {
        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("notificationUrl")]
        public string NotificationUrl { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class FormsListItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Microsoftforms;

    public static class MicrosoftformsTriggerInstanceExtensions
    {
        public static MicrosoftformsInstanceTriggers Microsoftforms(this WorkflowManagedTriggers t, string connectionId) => new MicrosoftformsInstanceTriggers(connectionId);
        public static MicrosoftformsInstance Microsoftforms(this WorkflowManagedActions t, string connectionId) => new MicrosoftformsInstance(connectionId);
    }
}