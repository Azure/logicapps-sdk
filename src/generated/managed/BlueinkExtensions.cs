//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blueink
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlueinkActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> ListBundles(Expression<Func<string>> search = null, Expression<Func<statusInput>> status = null, Expression<Func<statusInInput>> statusIn = null, Expression<Func<string>> tag = null, Expression<Func<string>> tagIn = null, Expression<Func<orderingInput>> ordering = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_statusIn = WorkflowExpression.Compile(statusIn, nameof(statusIn), required: false);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: false);
            var __workflow_tagIn = WorkflowExpression.Compile(tagIn, nameof(tagIn), required: false);
            var __workflow_ordering = WorkflowExpression.Compile(ordering, nameof(ordering), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bundles/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_statusIn != null)
                    callPayload.Queries["status__in"] = ExpressionConverter.Convert(__workflow_statusIn);
                if (__workflow_tag != null)
                    callPayload.Queries["tag"] = ExpressionConverter.Convert(__workflow_tag);
                if (__workflow_tagIn != null)
                    callPayload.Queries["tag__in"] = ExpressionConverter.Convert(__workflow_tagIn);
                if (__workflow_ordering != null)
                    callPayload.Queries["ordering"] = ExpressionConverter.Convert(__workflow_ordering);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListPersonsResponseItem[], ApiConnectionActionConfiguration> ListPersons(Expression<Func<string>> search = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            return new DeferredBodyAction<ListPersonsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/persons/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                return new ApiConnectionAction<ListPersonsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListTemplatesResponse, ApiConnectionActionConfiguration> ListTemplates()
        {
            var apiCallPath = "/templates/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTemplatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListWebhooksResponseItem[], ApiConnectionActionConfiguration> ListWebhooks(Expression<Func<bool>> enabled = null, Expression<Func<eventTypeInput>> eventType = null)
        {
            var __workflow_enabled = WorkflowExpression.Compile(enabled, nameof(enabled), required: false);
            var __workflow_eventType = WorkflowExpression.Compile(eventType, nameof(eventType), required: false);
            return new DeferredBodyAction<ListWebhooksResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_enabled != null)
                    callPayload.Queries["enabled"] = ExpressionConverter.Convert(__workflow_enabled);
                if (__workflow_eventType != null)
                    callPayload.Queries["event_type"] = ExpressionConverter.Convert(__workflow_eventType);
                return new ApiConnectionAction<ListWebhooksResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListWebhookDeliveriesResponseItem[], ApiConnectionActionConfiguration> ListWebhookDeliveries(Expression<Func<string>> webhook = null, Expression<Func<string>> webhookEvent = null, Expression<Func<eventTypeInput>> eventType = null, Expression<Func<int>> status = null, Expression<Func<string>> date = null)
        {
            var __workflow_webhook = WorkflowExpression.Compile(webhook, nameof(webhook), required: false);
            var __workflow_webhookEvent = WorkflowExpression.Compile(webhookEvent, nameof(webhookEvent), required: false);
            var __workflow_eventType = WorkflowExpression.Compile(eventType, nameof(eventType), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            return new DeferredBodyAction<ListWebhookDeliveriesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/deliveries/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_webhook != null)
                    callPayload.Queries["webhook"] = ExpressionConverter.Convert(__workflow_webhook);
                if (__workflow_webhookEvent != null)
                    callPayload.Queries["webhook_event"] = ExpressionConverter.Convert(__workflow_webhookEvent);
                if (__workflow_eventType != null)
                    callPayload.Queries["event_type"] = ExpressionConverter.Convert(__workflow_eventType);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                return new ApiConnectionAction<ListWebhookDeliveriesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListWebhookEventsResponseItem[], ApiConnectionActionConfiguration> ListWebhookEvents(Expression<Func<string>> webhook = null, Expression<Func<eventTypeInput>> eventType = null, Expression<Func<int>> status = null, Expression<Func<bool>> success = null, Expression<Func<string>> date = null)
        {
            var __workflow_webhook = WorkflowExpression.Compile(webhook, nameof(webhook), required: false);
            var __workflow_eventType = WorkflowExpression.Compile(eventType, nameof(eventType), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_success = WorkflowExpression.Compile(success, nameof(success), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            return new DeferredBodyAction<ListWebhookEventsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/events/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_webhook != null)
                    callPayload.Queries["webhook"] = ExpressionConverter.Convert(__workflow_webhook);
                if (__workflow_eventType != null)
                    callPayload.Queries["event_type"] = ExpressionConverter.Convert(__workflow_eventType);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_success != null)
                    callPayload.Queries["success"] = ExpressionConverter.Convert(__workflow_success);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                return new ApiConnectionAction<ListWebhookEventsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListWebhookExtraHeadersResponseItem[], ApiConnectionActionConfiguration> ListWebhookExtraHeaders(Expression<Func<string>> webhook = null, Expression<Func<eventTypeInput>> eventType = null)
        {
            var __workflow_webhook = WorkflowExpression.Compile(webhook, nameof(webhook), required: false);
            var __workflow_eventType = WorkflowExpression.Compile(eventType, nameof(eventType), required: false);
            return new DeferredBodyAction<ListWebhookExtraHeadersResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/headers/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_webhook != null)
                    callPayload.Queries["webhook"] = ExpressionConverter.Convert(__workflow_webhook);
                if (__workflow_eventType != null)
                    callPayload.Queries["event_type"] = ExpressionConverter.Convert(__workflow_eventType);
                return new ApiConnectionAction<ListWebhookExtraHeadersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<GetWebhookSecretResponse, ApiConnectionActionConfiguration> GetWebhookSecret()
        {
            var apiCallPath = "/webhooks/secret/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetWebhookSecretResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<RegenerateWebhookSecretResponse, ApiConnectionActionConfiguration> RegenerateWebhookSecret()
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
