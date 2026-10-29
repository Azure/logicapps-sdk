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
        public IBodyWorkflowAction<Envelope, ApiConnectionActionConfiguration> CreateEnvelope(Expression<Func<string>> bodysubject, Expression<Func<Recipient[]>> bodyrecipients, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodytemplate = null, Expression<Func<string[]>> bodydocuments = null, Expression<Func<EnvelopeField[]>> bodyfields = null, Expression<Func<bodysignatureLevelInput>> bodysignatureLevel = null, Expression<Func<string>> bodyexpiresAt = null, Expression<Func<bodycategoryInput>> bodycategory = null, Expression<Func<string[]>> bodytags = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodyredirectURL = null, Expression<Func<bool>> bodyinitialsOnEveryPage = null, Expression<Func<string>> bodyworkspace = null)
        {
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: true);
            var __workflow_bodyrecipients = WorkflowExpression.Compile(bodyrecipients, nameof(bodyrecipients), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodytemplate = WorkflowExpression.Compile(bodytemplate, nameof(bodytemplate), required: false);
            var __workflow_bodydocuments = WorkflowExpression.Compile(bodydocuments, nameof(bodydocuments), required: false);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: false);
            var __workflow_bodysignatureLevel = WorkflowExpression.Compile(bodysignatureLevel, nameof(bodysignatureLevel), required: false);
            var __workflow_bodyexpiresAt = WorkflowExpression.Compile(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodyredirectURL = WorkflowExpression.Compile(bodyredirectURL, nameof(bodyredirectURL), required: false);
            var __workflow_bodyinitialsOnEveryPage = WorkflowExpression.Compile(bodyinitialsOnEveryPage, nameof(bodyinitialsOnEveryPage), required: false);
            var __workflow_bodyworkspace = WorkflowExpression.Compile(bodyworkspace, nameof(bodyworkspace), required: false);
            return new DeferredBodyAction<Envelope, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/envelopes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodytemplate != null)
                {
                    body["templateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplate);
                    bodypropCount++;
                }

                if (__workflow_bodydocuments != null)
                {
                    body["documentIds"] = ExpressionConverter.ConvertO(__workflow_bodydocuments);
                    bodypropCount++;
                }

                if (__workflow_bodyfields != null)
                {
                    body["fields"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                    bodypropCount++;
                }

                bodypropCount++;
                body["recipients"] = ExpressionConverter.ConvertO(__workflow_bodyrecipients);
                if (__workflow_bodysignatureLevel != null)
                {
                    if (__workflow_bodysignatureLevel != null)
                    {
                        body["signatureLevel"] = ExpressionConverter.ConvertO(__workflow_bodysignatureLevel);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["signatureLevel"] = "SIMPLE";
                    bodypropCount++;
                }

                if (__workflow_bodyexpiresAt != null)
                {
                    body["expiresAt"] = ExpressionConverter.ConvertO(__workflow_bodyexpiresAt);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["locale"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodyredirectURL != null)
                {
                    body["redirectUrl"] = ExpressionConverter.ConvertO(__workflow_bodyredirectURL);
                    bodypropCount++;
                }

                if (__workflow_bodyinitialsOnEveryPage != null)
                {
                    body["initialsOnEveryPage"] = ExpressionConverter.ConvertO(__workflow_bodyinitialsOnEveryPage);
                    bodypropCount++;
                }

                if (__workflow_bodyworkspace != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspace);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration> SubscribeEnvelopeEvents(Expression<Func<bodyeventsInputItem[]>> bodyevents, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyevents = WorkflowExpression.Compile(bodyevents, nameof(bodyevents), required: true);
            return new DeferredBodyTrigger<WebhookSubscription, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["events"] = ExpressionConverter.ConvertO(__workflow_bodyevents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
    public enum bodysignatureLevelInput
    {
        SIMPLE,
        ADVANCED,
        QUALIFIED
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycategoryInput
    {
        CONTRACT,
        AGREEMENT,
        INVOICE,
        LETTER,
        QUOTE,
        NDA,
        HR,
        LEGAL,
        REPORT,
        PROPOSAL,
        OTHER
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyeventsInputItem
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