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
        public IBodyWorkflowAction<EnvelopeList, ApiConnectionActionConfiguration> ListEnvelopes(Expression<Func<int>> page = null, Expression<Func<int>> limit = null, Expression<Func<StatusInput>> status = null)
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
        public IBodyWorkflowAction<Envelope, ApiConnectionActionConfiguration> CreateEnvelope(Expression<Func<CreateEnvelopeBodyInput>> body)
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
        public IBodyWorkflowTrigger<WebhookSubscription, ApiConnectionPollingTriggerConfiguration> SubscribeEnvelopeEvents(Expression<Func<SubscribeEnvelopeEventsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<WebhookSubscription, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<WebhookSubscription>(callPayload);
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
        public CreateEnvelopeRecipientResponse[] Recipients { get; set; }

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
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "SCHEDULED")]
        Scheduled,
        [EnumMember(Value = "SENT")]
        Sent,
        [EnumMember(Value = "DELIVERED")]
        Delivered,
        [EnumMember(Value = "PARTIALLY_SIGNED")]
        PartiallySigned,
        [EnumMember(Value = "COMPLETED")]
        Completed,
        [EnumMember(Value = "DECLINED")]
        Declined,
        [EnumMember(Value = "VOIDED")]
        Voided,
        [EnumMember(Value = "EXPIRED")]
        Expired,
        [EnumMember(Value = "RETURNED_TO_SENDER")]
        ReturnedToSender
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EnvelopeSignatureLevelType
    {
        [EnumMember(Value = "SIMPLE")]
        Simple,
        [EnumMember(Value = "ADVANCED")]
        Advanced,
        [EnumMember(Value = "QUALIFIED")]
        Qualified
    }

    public class CreateEnvelopeRecipientResponse
    {
        [JsonProperty("email")]
        public string RecipientEmail { get; set; }

        [JsonProperty("name")]
        public string RecipientName { get; set; }

        [JsonProperty("role")]
        public CreateEnvelopeRecipientRoleTypeResponse Role { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("signedAt")]
        public string SignedAt { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEnvelopeRecipientRoleTypeResponse
    {
        [EnumMember(Value = "SIGNER")]
        Signer,
        [EnumMember(Value = "VIEWER")]
        Viewer,
        [EnumMember(Value = "CARBON_COPY")]
        CarbonCopy,
        [EnumMember(Value = "APPROVER")]
        Approver
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StatusInput
    {
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "SCHEDULED")]
        Scheduled,
        [EnumMember(Value = "SENT")]
        Sent,
        [EnumMember(Value = "DELIVERED")]
        Delivered,
        [EnumMember(Value = "PARTIALLY_SIGNED")]
        PartiallySigned,
        [EnumMember(Value = "COMPLETED")]
        Completed,
        [EnumMember(Value = "DECLINED")]
        Declined,
        [EnumMember(Value = "VOIDED")]
        Voided,
        [EnumMember(Value = "EXPIRED")]
        Expired,
        [EnumMember(Value = "RETURNED_TO_SENDER")]
        ReturnedToSender
    }

    public class CreateEnvelopeBodyInput
    {
        public CreateEnvelopeBodyInput(string subject, CreateEnvelopeRecipient[] recipients)
        {
            this.Subject = subject;
            this.Recipients = recipients;
        }

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
        public CreateEnvelopeRecipient[] Recipients { get; set; }

        [JsonProperty("signatureLevel", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSignatureLevelType? SignatureLevel { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Certyneo.BodyInputSignatureLevelType.Simple;

        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonProperty("category")]
        public BodyInputCategoryType? Category { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("locale")]
        public string Language { get; set; }

        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }

        [JsonProperty("initialsOnEveryPage")]
        public bool? InitialsOnEveryPage { get; set; }

        [JsonProperty("workspaceId")]
        public string Workspace { get; set; }
    }

    public class EnvelopeField
    {
        public EnvelopeField(string signerEmail)
        {
            this.SignerEmail = signerEmail;
        }

        [JsonProperty("recipientEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SignerEmail { get; set; }

        [JsonProperty("documentIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DocumentNumber { get; set; } = 0;

        [JsonProperty("pageNumber", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Page { get; set; } = 1;

        [JsonProperty("fieldType", DefaultValueHandling = DefaultValueHandling.Include)]
        public EnvelopeFieldFieldTypeType FieldType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Certyneo.EnvelopeFieldFieldTypeType.Signature;

        [JsonProperty("anchorText")]
        public string AnchorTextRecommended { get; set; }

        [JsonProperty("anchorPlacement", DefaultValueHandling = DefaultValueHandling.Include)]
        public EnvelopeFieldAnchorPlacementType? AnchorPlacement { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Certyneo.EnvelopeFieldAnchorPlacementType.Right;

        [JsonProperty("anchorIndex", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? AnchorOccurrence { get; set; } = 0;

        [JsonProperty("x", DefaultValueHandling = DefaultValueHandling.Include)]
        public double X { get; set; } = 72;

        [JsonProperty("y", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Y { get; set; } = 700;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Width { get; set; } = 150;

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Height { get; set; } = 40;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EnvelopeFieldFieldTypeType
    {
        [EnumMember(Value = "SIGNATURE")]
        Signature,
        [EnumMember(Value = "INITIALS")]
        Initials,
        [EnumMember(Value = "DATE_SIGNED")]
        DateSigned,
        [EnumMember(Value = "TEXT")]
        Text,
        [EnumMember(Value = "CHECKBOX")]
        Checkbox,
        [EnumMember(Value = "DROPDOWN")]
        Dropdown,
        [EnumMember(Value = "ATTACHMENT")]
        Attachment,
        [EnumMember(Value = "STAMP")]
        Stamp,
        [EnumMember(Value = "DRAWING")]
        Drawing,
        [EnumMember(Value = "RADIO_GROUP")]
        RadioGroup
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

    public class CreateEnvelopeRecipient
    {
        public CreateEnvelopeRecipient(string recipientEmail)
        {
            this.RecipientEmail = recipientEmail;
        }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientEmail { get; set; }

        [JsonProperty("name")]
        public string RecipientName { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateEnvelopeRecipientRoleType? Role { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Certyneo.CreateEnvelopeRecipientRoleType.Signer;

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("signedAt")]
        public string SignedAt { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateEnvelopeRecipientRoleType
    {
        [EnumMember(Value = "SIGNER")]
        Signer,
        [EnumMember(Value = "VIEWER")]
        Viewer,
        [EnumMember(Value = "CARBON_COPY")]
        CarbonCopy,
        [EnumMember(Value = "APPROVER")]
        Approver
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSignatureLevelType
    {
        [EnumMember(Value = "SIMPLE")]
        Simple,
        [EnumMember(Value = "ADVANCED")]
        Advanced,
        [EnumMember(Value = "QUALIFIED")]
        Qualified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCategoryType
    {
        [EnumMember(Value = "CONTRACT")]
        Contract,
        [EnumMember(Value = "AGREEMENT")]
        Agreement,
        [EnumMember(Value = "INVOICE")]
        Invoice,
        [EnumMember(Value = "LETTER")]
        Letter,
        [EnumMember(Value = "QUOTE")]
        Quote,
        [EnumMember(Value = "NDA")]
        Nda,
        HR,
        [EnumMember(Value = "LEGAL")]
        Legal,
        [EnumMember(Value = "REPORT")]
        Report,
        [EnumMember(Value = "PROPOSAL")]
        Proposal,
        [EnumMember(Value = "OTHER")]
        Other
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

    public class SubscribeEnvelopeEventsBodyInput
    {
        public SubscribeEnvelopeEventsBodyInput(BodyInputEventsTypeItem[] events)
        {
            this.Events = events;
        }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEventsTypeItem[] Events { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEventsTypeItem
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