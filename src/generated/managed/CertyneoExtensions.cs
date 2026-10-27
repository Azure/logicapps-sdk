//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Certyneo
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CertyneoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certyneo")]
        public IBodyWorkflowAction<TemplateList, ApiConnectionActionConfiguration> ListTemplates()
        {
            return new DeferredBodyAction<TemplateList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certyneo")]
        public IBodyWorkflowAction<EnvelopeList, ApiConnectionActionConfiguration> ListEnvelopes(Expression<Func<int>> page = null, Expression<Func<int>> limit = null, Expression<Func<statusInput>> status = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<EnvelopeList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/envelopes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<EnvelopeList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certyneo")]
        public IBodyWorkflowAction<Envelope, ApiConnectionActionConfiguration> CreateEnvelope(Expression<Func<CreateEnvelopeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Envelope, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/envelopes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Envelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certyneo")]
        public IBodyWorkflowAction<Envelope, ApiConnectionActionConfiguration> GetEnvelope(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Envelope, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Envelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "certyneo")]
        public IBodyWorkflowAction<Envelope, ApiConnectionActionConfiguration> SendEnvelope(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Envelope, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/send", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Envelope>(callPayload);
            });
        }
    }

    public class CertyneoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration> SubscribeEnvelopeEvents(Expression<Func<SubscribeEnvelopeEventsInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<WebhookSubscription>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class TemplateList
    {
        [JsonProperty("data")]
        public Template[] Data { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Template
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("signerCount")]
        public int SignerCount { get; set; }

        [JsonProperty("documentCount")]
        public int DocumentCount { get; set; }
    }

    public class Pagination
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }
    }

    public class EnvelopeList
    {
        [JsonProperty("data")]
        public Envelope[] Data { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public class Envelope
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public EnvelopeStatusType Status { get; set; }

        [JsonProperty("signatureLevel")]
        public EnvelopeSignatureLevelType SignatureLevel { get; set; }

        [JsonProperty("recipients")]
        public Recipient[] Recipients { get; set; }

        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("completedAt")]
        public string CompletedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EnvelopeStatusType
    {
        DRAFT,
        SCHEDULED,
        SENT,
        DELIVERED,
        [EnumMember(Value = "PARTIALLY_SIGNED")]
        PARTIALLYSIGNED,
        COMPLETED,
        DECLINED,
        [EnumMember(Value = "VOIDED")]
        VOIdED,
        EXPIRED,
        [EnumMember(Value = "RETURNED_TO_SENDER")]
        RETURNEDTOSENDER
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EnvelopeSignatureLevelType
    {
        SIMPLE,
        ADVANCED,
        QUALIFIED
    }

    public class Recipient
    {
        [JsonProperty("email")]
        public string RecipientEmail { get; set; }

        [JsonProperty("name")]
        public string RecipientName { get; set; }

        [JsonProperty("role")]
        public RecipientRoleType Role { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("signedAt")]
        public string SignedAt { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecipientRoleType
    {
        SIGNER,
        VIEWER,
        [EnumMember(Value = "CARBON_COPY")]
        CARBONCOPY,
        APPROVER
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        DRAFT,
        SCHEDULED,
        SENT,
        DELIVERED,
        [EnumMember(Value = "PARTIALLY_SIGNED")]
        PARTIALLYSIGNED,
        COMPLETED,
        DECLINED,
        [EnumMember(Value = "VOIDED")]
        VOIdED,
        EXPIRED,
        [EnumMember(Value = "RETURNED_TO_SENDER")]
        RETURNEDTOSENDER
    }

    public class CreateEnvelopeInput
    {
        [JsonProperty("subject", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Subject { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("templateId")]
        public string Template { get; set; }

        [JsonProperty("documentIds")]
        public string[] Documents { get; set; }

        [JsonProperty("fields")]
        public EnvelopeField[] Fields { get; set; }

        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public Recipient[] Recipients { get; set; }

        [JsonProperty("signatureLevel", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateEnvelopeInputSignatureLevelType? SignatureLevel { get; set; } = CreateEnvelopeInputSignatureLevelType.SIMPLE;

        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }
    }

    public class EnvelopeField
    {
        [JsonProperty("recipientEmail")]
        public string SignerEmail { get; set; }

        [JsonProperty("documentIndex")]
        public int DocumentNumber { get; set; }

        [JsonProperty("pageNumber")]
        public int Page { get; set; }

        [JsonProperty("fieldType")]
        public EnvelopeFieldFieldTypeType FieldType { get; set; }

        [JsonProperty("anchorText")]
        public string AnchorTextRecommended { get; set; }

        [JsonProperty("anchorPlacement")]
        public EnvelopeFieldAnchorPlacementType AnchorPlacement { get; set; }

        [JsonProperty("anchorIndex")]
        public int AnchorOccurrence { get; set; }

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EnvelopeFieldFieldTypeType
    {
        SIGNATURE,
        INITIALS,
        [EnumMember(Value = "DATE_SIGNED")]
        DATESIGNED,
        TEXT,
        CHECKBOX,
        DROPDOWN,
        ATTACHMENT,
        STAMP,
        DRAWING,
        [EnumMember(Value = "RADIO_GROUP")]
        RADIOGROUP
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EnvelopeFieldAnchorPlacementType
    {
        [EnumMember(Value = "right")]
        Right,
        [EnumMember(Value = "below")]
        Below,
        [EnumMember(Value = "above")]
        Above,
        [EnumMember(Value = "left")]
        Left
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEnvelopeInputSignatureLevelType
    {
        SIMPLE,
        ADVANCED,
        QUALIFIED
    }

    public class WebhookSubscription
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("events")]
        public string[] Events { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }
    }

    public class SubscribeEnvelopeEventsInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public SubscribeEnvelopeEventsInputEventsTypeItem[] Events { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SubscribeEnvelopeEventsInputEventsTypeItem
    {
        [EnumMember(Value = "envelope.created")]
        EnvelopeCreated,
        [EnumMember(Value = "envelope.sent")]
        EnvelopeSent,
        [EnumMember(Value = "envelope.completed")]
        EnvelopeCompleted,
        [EnumMember(Value = "envelope.declined")]
        EnvelopeDeclined,
        [EnumMember(Value = "envelope.voided")]
        EnvelopeVoided,
        [EnumMember(Value = "envelope.expired")]
        EnvelopeExpired,
        [EnumMember(Value = "envelope.returned_to_sender")]
        EnvelopeReturnedToSender,
        [EnumMember(Value = "envelope.resubmitted")]
        EnvelopeResubmitted,
        [EnumMember(Value = "recipient.signed")]
        RecipientSigned,
        [EnumMember(Value = "recipient.viewed")]
        RecipientViewed,
        [EnumMember(Value = "recipient.approved")]
        RecipientApproved
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Certyneo;

    public partial class WorkflowManagedActions
    {
        public CertyneoActions Certyneo(string connectionId) => new CertyneoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CertyneoTriggers Certyneo(string connectionId) => new CertyneoTriggers(connectionId);
    }
}