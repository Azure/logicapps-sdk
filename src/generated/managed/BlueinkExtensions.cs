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
        public IBodyWorkflowAction<JToken[]> ListBundles([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<statusInInput> statusIn = null, [WorkflowExpression] Func<string> tag = null, [WorkflowExpression] Func<string> tagIn = null, [WorkflowExpression] Func<orderingInput> ordering = null)
        {
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(statusIn, nameof(statusIn), required: false);
            SourceExpression.Validate(tag, nameof(tag), required: false);
            SourceExpression.Validate(tagIn, nameof(tagIn), required: false);
            SourceExpression.Validate(ordering, nameof(ordering), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bundles/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (statusIn != null)
                    callPayload.Queries["status__in"] = SourceExpressionConverter.Convert(statusIn);
                if (tag != null)
                    callPayload.Queries["tag"] = SourceExpressionConverter.ConvertO(tag);
                if (tagIn != null)
                    callPayload.Queries["tag__in"] = SourceExpressionConverter.ConvertO(tagIn);
                if (ordering != null)
                    callPayload.Queries["ordering"] = SourceExpressionConverter.Convert(ordering);
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListPersonsResponseItem[]> ListPersons([WorkflowExpression] Func<string> search = null)
        {
            SourceExpression.Validate(search, nameof(search), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/persons/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                return callPayload;
            }

            return new ApiConnectionAction<ListPersonsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListTemplatesResponse> ListTemplates()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/templates/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTemplatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListWebhooksResponseItem[]> ListWebhooks([WorkflowExpression] Func<bool> enabled = null, [WorkflowExpression] Func<eventTypeInput> eventType = null)
        {
            SourceExpression.Validate(enabled, nameof(enabled), required: false);
            SourceExpression.Validate(eventType, nameof(eventType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (enabled != null)
                    callPayload.Queries["enabled"] = SourceExpressionConverter.ConvertO(enabled);
                if (eventType != null)
                    callPayload.Queries["event_type"] = SourceExpressionConverter.Convert(eventType);
                return callPayload;
            }

            return new ApiConnectionAction<ListWebhooksResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListWebhookDeliveriesResponseItem[]> ListWebhookDeliveries([WorkflowExpression] Func<string> webhook = null, [WorkflowExpression] Func<string> webhookEvent = null, [WorkflowExpression] Func<eventTypeInput> eventType = null, [WorkflowExpression] Func<int> status = null, [WorkflowExpression] Func<string> date = null)
        {
            SourceExpression.Validate(webhook, nameof(webhook), required: false);
            SourceExpression.Validate(webhookEvent, nameof(webhookEvent), required: false);
            SourceExpression.Validate(eventType, nameof(eventType), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(date, nameof(date), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/deliveries/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (webhook != null)
                    callPayload.Queries["webhook"] = SourceExpressionConverter.ConvertO(webhook);
                if (webhookEvent != null)
                    callPayload.Queries["webhook_event"] = SourceExpressionConverter.ConvertO(webhookEvent);
                if (eventType != null)
                    callPayload.Queries["event_type"] = SourceExpressionConverter.Convert(eventType);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                return callPayload;
            }

            return new ApiConnectionAction<ListWebhookDeliveriesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListWebhookEventsResponseItem[]> ListWebhookEvents([WorkflowExpression] Func<string> webhook = null, [WorkflowExpression] Func<eventTypeInput> eventType = null, [WorkflowExpression] Func<int> status = null, [WorkflowExpression] Func<bool> success = null, [WorkflowExpression] Func<string> date = null)
        {
            SourceExpression.Validate(webhook, nameof(webhook), required: false);
            SourceExpression.Validate(eventType, nameof(eventType), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(success, nameof(success), required: false);
            SourceExpression.Validate(date, nameof(date), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/events/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (webhook != null)
                    callPayload.Queries["webhook"] = SourceExpressionConverter.ConvertO(webhook);
                if (eventType != null)
                    callPayload.Queries["event_type"] = SourceExpressionConverter.Convert(eventType);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (success != null)
                    callPayload.Queries["success"] = SourceExpressionConverter.ConvertO(success);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                return callPayload;
            }

            return new ApiConnectionAction<ListWebhookEventsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<ListWebhookExtraHeadersResponseItem[]> ListWebhookExtraHeaders([WorkflowExpression] Func<string> webhook = null, [WorkflowExpression] Func<eventTypeInput> eventType = null)
        {
            SourceExpression.Validate(webhook, nameof(webhook), required: false);
            SourceExpression.Validate(eventType, nameof(eventType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/headers/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (webhook != null)
                    callPayload.Queries["webhook"] = SourceExpressionConverter.ConvertO(webhook);
                if (eventType != null)
                    callPayload.Queries["event_type"] = SourceExpressionConverter.Convert(eventType);
                return callPayload;
            }

            return new ApiConnectionAction<ListWebhookExtraHeadersResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<GetWebhookSecretResponse> GetWebhookSecret()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/secret/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetWebhookSecretResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blueink")]
        public IBodyWorkflowAction<RegenerateWebhookSecretResponse> RegenerateWebhookSecret()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks/secret/regenerate/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RegenerateWebhookSecretResponse>(BuildSourceInput);
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