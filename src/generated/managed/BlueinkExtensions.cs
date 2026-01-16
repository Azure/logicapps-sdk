//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blueink
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlueinkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<JToken[]> ListBundles(Expression<Func<string>> search = null, Expression<Func<statusInput>> status = null, Expression<Func<statusInInput>> statusIn = null, Expression<Func<string>> tag = null, Expression<Func<string>> tagIn = null, Expression<Func<orderingInput>> ordering = null)
        {
            var apiCallPath = "/bundles/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (statusIn != null)
                callPayload.Queries["status__in"] = ExpressionConverter.Convert(statusIn);
            if (tag != null)
                callPayload.Queries["tag"] = ExpressionConverter.Convert(tag);
            if (tagIn != null)
                callPayload.Queries["tag__in"] = ExpressionConverter.Convert(tagIn);
            if (ordering != null)
                callPayload.Queries["ordering"] = ExpressionConverter.Convert(ordering);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListPersonsResponseItem[]> ListPersons(Expression<Func<string>> search = null)
        {
            var apiCallPath = "/persons/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
            return new ApiConnectionAction<ListPersonsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListTemplatesResponse> ListTemplates()
        {
            var apiCallPath = "/templates/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTemplatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListWebhooksResponseItem[]> ListWebhooks(Expression<Func<bool>> enabled = null, Expression<Func<eventTypeInput>> eventType = null)
        {
            var apiCallPath = "/webhooks/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (enabled != null)
                callPayload.Queries["enabled"] = ExpressionConverter.Convert(enabled);
            if (eventType != null)
                callPayload.Queries["event_type"] = ExpressionConverter.Convert(eventType);
            return new ApiConnectionAction<ListWebhooksResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListWebhookDeliveriesResponseItem[]> ListWebhookDeliveries(Expression<Func<string>> webhook = null, Expression<Func<string>> webhookEvent = null, Expression<Func<eventTypeInput>> eventType = null, Expression<Func<int>> status = null, Expression<Func<string>> date = null)
        {
            var apiCallPath = "/webhooks/deliveries/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (webhook != null)
                callPayload.Queries["webhook"] = ExpressionConverter.Convert(webhook);
            if (webhookEvent != null)
                callPayload.Queries["webhook_event"] = ExpressionConverter.Convert(webhookEvent);
            if (eventType != null)
                callPayload.Queries["event_type"] = ExpressionConverter.Convert(eventType);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (date != null)
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
            return new ApiConnectionAction<ListWebhookDeliveriesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListWebhookEventsResponseItem[]> ListWebhookEvents(Expression<Func<string>> webhook = null, Expression<Func<eventTypeInput>> eventType = null, Expression<Func<int>> status = null, Expression<Func<bool>> success = null, Expression<Func<string>> date = null)
        {
            var apiCallPath = "/webhooks/events/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (webhook != null)
                callPayload.Queries["webhook"] = ExpressionConverter.Convert(webhook);
            if (eventType != null)
                callPayload.Queries["event_type"] = ExpressionConverter.Convert(eventType);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (success != null)
                callPayload.Queries["success"] = ExpressionConverter.Convert(success);
            if (date != null)
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
            return new ApiConnectionAction<ListWebhookEventsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListWebhookExtraHeadersResponseItem[]> ListWebhookExtraHeaders(Expression<Func<string>> webhook = null, Expression<Func<eventTypeInput>> eventType = null)
        {
            var apiCallPath = "/webhooks/headers/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (webhook != null)
                callPayload.Queries["webhook"] = ExpressionConverter.Convert(webhook);
            if (eventType != null)
                callPayload.Queries["event_type"] = ExpressionConverter.Convert(eventType);
            return new ApiConnectionAction<ListWebhookExtraHeadersResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<GetWebhookSecretResponse> GetWebhookSecret()
        {
            var apiCallPath = "/webhooks/secret/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetWebhookSecretResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<RegenerateWebhookSecretResponse> RegenerateWebhookSecret()
        {
            var apiCallPath = "/webhooks/secret/regenerate/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RegenerateWebhookSecretResponse>(callPayload);
        }
    }

    public class BlueinkTriggers([ConnectionName] string connectionId)
    {
    }

    public enum statusInput
    {
        [EnumMember(Value = "dr")]
        Dr,
        [EnumMember(Value = "se")]
        Se,
        [EnumMember(Value = "st")]
        St,
        [EnumMember(Value = "co")]
        Co,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "ex")]
        Ex,
        [EnumMember(Value = "fa")]
        Fa
    }

    public enum statusInInput
    {
        [EnumMember(Value = "dr")]
        Dr,
        [EnumMember(Value = "se")]
        Se,
        [EnumMember(Value = "st")]
        St,
        [EnumMember(Value = "co")]
        Co,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "ex")]
        Ex,
        [EnumMember(Value = "fa")]
        Fa
    }

    public enum orderingInput
    {
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "completed_at")]
        CompletedAt
    }

    public class ListPersonsResponseItem
    {
        [JsonProperty("channels")]
        public ListPersonsResponseItemChannelsTypeItem[] Channels { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_user")]
        public bool IsUser { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListPersonsResponseItemChannelsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("kind")]
        public ListPersonsResponseItemChannelsTypeItemKindType Kind { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public enum ListPersonsResponseItemChannelsTypeItemKindType
    {
        [EnumMember(Value = "em")]
        Em,
        [EnumMember(Value = "mp")]
        Mp
    }

    public class ListTemplatesResponse
    {
        [JsonProperty("fields")]
        public JToken[] Fields { get; set; }

        [JsonProperty("file_url")]
        public string FileUrl { get; set; }

        [JsonProperty("is_shared")]
        public bool IsShared { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roles")]
        public ListTemplatesResponseRolesTypeItem[] Roles { get; set; }
    }

    public class ListTemplatesResponseRolesTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class ListWebhooksResponseItem
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("event_types")]
        public ListWebhooksResponseItemEventTypesTypeItem[] EventTypes { get; set; }

        [JsonProperty("extra_headers")]
        public ListWebhooksResponseItemExtraHeadersTypeItem[] ExtraHeaders { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("json")]
        public bool Json { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public enum ListWebhooksResponseItemEventTypesTypeItem
    {
        [EnumMember(Value = "bundle_sent")]
        BundleSent,
        [EnumMember(Value = "bundle_complete")]
        BundleComplete,
        [EnumMember(Value = "bundle_docs_ready")]
        BundleDocsReady,
        [EnumMember(Value = "bundle_error")]
        BundleError,
        [EnumMember(Value = "bundle_cancelled")]
        BundleCancelled,
        [EnumMember(Value = "packet_viewed")]
        PacketViewed,
        [EnumMember(Value = "packet_complete")]
        PacketComplete
    }

    public class ListWebhooksResponseItemExtraHeadersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("webhook")]
        public string Webhook { get; set; }
    }

    public enum eventTypeInput
    {
        [EnumMember(Value = "bundle_sent")]
        BundleSent,
        [EnumMember(Value = "bundle_complete")]
        BundleComplete,
        [EnumMember(Value = "bundle_docs_ready")]
        BundleDocsReady,
        [EnumMember(Value = "bundle_error")]
        BundleError,
        [EnumMember(Value = "bundle_cancelled")]
        BundleCancelled,
        [EnumMember(Value = "packet_viewed")]
        PacketViewed,
        [EnumMember(Value = "packet_complete")]
        PacketComplete
    }

    public class ListWebhookDeliveriesResponseItem
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deliveries")]
        public ListWebhookDeliveriesResponseItemDeliveriesTypeItem[] Deliveries { get; set; }

        [JsonProperty("event_type")]
        public ListWebhookDeliveriesResponseItemEventTypeType EventType { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("pk")]
        public string Pk { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("webhook")]
        public string Webhook { get; set; }
    }

    public class ListWebhookDeliveriesResponseItemDeliveriesTypeItem
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("pk")]
        public string Pk { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public enum ListWebhookDeliveriesResponseItemEventTypeType
    {
        [EnumMember(Value = "bundle_sent")]
        BundleSent,
        [EnumMember(Value = "bundle_complete")]
        BundleComplete,
        [EnumMember(Value = "bundle_docs_ready")]
        BundleDocsReady,
        [EnumMember(Value = "bundle_error")]
        BundleError,
        [EnumMember(Value = "bundle_cancelled")]
        BundleCancelled,
        [EnumMember(Value = "packet_viewed")]
        PacketViewed,
        [EnumMember(Value = "packet_complete")]
        PacketComplete
    }

    public class ListWebhookEventsResponseItem
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("deliveries")]
        public ListWebhookEventsResponseItemDeliveriesTypeItem[] Deliveries { get; set; }

        [JsonProperty("event_type")]
        public ListWebhookEventsResponseItemEventTypeType EventType { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("pk")]
        public string Pk { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("webhook")]
        public string Webhook { get; set; }
    }

    public class ListWebhookEventsResponseItemDeliveriesTypeItem
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("pk")]
        public string Pk { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public enum ListWebhookEventsResponseItemEventTypeType
    {
        [EnumMember(Value = "bundle_sent")]
        BundleSent,
        [EnumMember(Value = "bundle_complete")]
        BundleComplete,
        [EnumMember(Value = "bundle_docs_ready")]
        BundleDocsReady,
        [EnumMember(Value = "bundle_error")]
        BundleError,
        [EnumMember(Value = "bundle_cancelled")]
        BundleCancelled,
        [EnumMember(Value = "packet_viewed")]
        PacketViewed,
        [EnumMember(Value = "packet_complete")]
        PacketComplete
    }

    public class ListWebhookExtraHeadersResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("webhook")]
        public string Webhook { get; set; }
    }

    public class GetWebhookSecretResponse
    {
        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }

    public class RegenerateWebhookSecretResponse
    {
        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blueink;

    public partial class WorkflowManagedActions
    {
        public BlueinkActions Blueink(string connectionId) => new BlueinkActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlueinkTriggers Blueink(string connectionId) => new BlueinkTriggers(connectionId);
    }
}