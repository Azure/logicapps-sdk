//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Scriveesign
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ScriveesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetDocJson(Expression<Func<GetDocJsonInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getdocumentjson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetDocStatus(Expression<Func<GetDocStatusInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getdocumentstatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetPartyStatus(Expression<Func<GetPartyStatusInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getpartystatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdatePartyEmail(Expression<Func<UpdatePartyEmailInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updatepartyemail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendReminder(Expression<Func<SendReminderInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sendreminder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetDocumentPdfContent(Expression<Func<GetDocumentPdfContentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getdocumentpdfcontent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> NewDocumentFromTemplate(Expression<Func<string>> templateIdDynamic)
        {
            var __workflow_templateIdDynamic = WorkflowExpression.Compile(templateIdDynamic, nameof(templateIdDynamic), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/newfromtemplate/{0}", __workflow_templateIdDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> StartSigning(Expression<Func<StartSigningInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/startsigning";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateDocJson(Expression<Func<UpdateDocJsonInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updatedocumentjson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdatePartiesFields(Expression<Func<string>> templateIdDynamic, Expression<Func<object>> dynamicTemplateSchema = null)
        {
            var __workflow_templateIdDynamic = WorkflowExpression.Compile(templateIdDynamic, nameof(templateIdDynamic), required: true);
            var __workflow_dynamicTemplateSchema = WorkflowExpression.Compile(dynamicTemplateSchema, nameof(dynamicTemplateSchema), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/updatepartiesfields/{0}", __workflow_templateIdDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_dynamicTemplateSchema != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicTemplateSchema);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdatePartiesProperties(Expression<Func<string>> templateIdDynamic, Expression<Func<object>> dynamicTemplateMetaSchema = null)
        {
            var __workflow_templateIdDynamic = WorkflowExpression.Compile(templateIdDynamic, nameof(templateIdDynamic), required: true);
            var __workflow_dynamicTemplateMetaSchema = WorkflowExpression.Compile(dynamicTemplateMetaSchema, nameof(dynamicTemplateMetaSchema), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/updatepartiesproperties/{0}", __workflow_templateIdDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_dynamicTemplateMetaSchema != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicTemplateMetaSchema);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SetFile(Expression<Func<SetFileInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> NewFromPdf(Expression<Func<NewFromPdfInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/newfrompdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AppendFile(Expression<Func<AppendFileInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/appendfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Cancel(Expression<Func<CancelInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/cancel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddParty(Expression<Func<AddPartyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addparty";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetAuthorAttachment(Expression<Func<SetAuthorAttachmentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/setattachment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ScriveesignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> StartAndOnDocumentSign(Expression<Func<StartAndOnDocumentSignInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/signed/createandstart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> WebhookFromTemplateSign(Expression<Func<string>> templateIdDynamic, Expression<Func<WebhookFromTemplateSignInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_templateIdDynamic = WorkflowExpression.Compile(templateIdDynamic, nameof(templateIdDynamic), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhooks/signedfromtemplate/create/{0}", __workflow_templateIdDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<PollSignedDocumentsResponse, ApiConnectionTriggerConfiguration> PollSignedDocuments(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<PollSignedDocumentsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/polling/signed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<PollSignedDocumentsResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetDocJsonInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
    }

    public class GetDocStatusInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
    }

    public class GetPartyStatusInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("partyId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PartyId { get; set; }
    }

    public class UpdatePartyEmailInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("partyId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PartyId { get; set; }

        [JsonProperty("partyEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PartyEmail { get; set; }
    }

    public class SendReminderInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
    }

    public class GetDocumentPdfContentInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
    }

    public class StartSigningInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
    }

    public class UpdateDocJsonInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("documentJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentJson { get; set; }
    }

    public class SetFileInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("pdfContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PdfContent { get; set; }
    }

    public class NewFromPdfInput
    {
        [JsonProperty("pdfContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PdfContent { get; set; }

        [JsonProperty("authorRole", DefaultValueHandling = DefaultValueHandling.Include)]
        public NewFromPdfInputAuthorRoleType AuthorRole { get; set; } = NewFromPdfInputAuthorRoleType.SigningParty;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NewFromPdfInputAuthorRoleType
    {
        [EnumMember(Value = "signing_party")]
        SigningParty,
        [EnumMember(Value = "viewer")]
        Viewer
    }

    public class AppendFileInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("pdfContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PdfContent { get; set; }
    }

    public class CancelInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
    }

    public class AddPartyInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("partyEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PartyEmail { get; set; }

        [JsonProperty("partyRole", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddPartyInputPartyRoleType PartyRole { get; set; } = AddPartyInputPartyRoleType.SigningParty;

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("personalNumber")]
        public string PersonalNumber { get; set; }

        [JsonProperty("signOrder")]
        public double? SignOrder { get; set; }

        [JsonProperty("deliveryMethod", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddPartyInputDeliveryMethodType? DeliveryMethod { get; set; } = AddPartyInputDeliveryMethodType.Email;

        [JsonProperty("authenticationToView", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthenticationToView { get; set; } = "standard";

        [JsonProperty("authenticationToViewArchived", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthenticationToViewArchived { get; set; } = "standard";

        [JsonProperty("authenticationToSign", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthenticationToSign { get; set; } = "standard";

        [JsonProperty("confirmation", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddPartyInputConfirmationType? Confirmation { get; set; } = AddPartyInputConfirmationType.Email;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddPartyInputPartyRoleType
    {
        [EnumMember(Value = "signing_party")]
        SigningParty,
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "approver")]
        Approver
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddPartyInputDeliveryMethodType
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "mobile")]
        Mobile,
        [EnumMember(Value = "email_mobile")]
        EmailMobile,
        [EnumMember(Value = "pad")]
        Pad,
        [EnumMember(Value = "api")]
        Api
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddPartyInputConfirmationType
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "mobile")]
        Mobile,
        [EnumMember(Value = "email_mobile")]
        EmailMobile,
        [EnumMember(Value = "email_link")]
        EmailLink,
        [EnumMember(Value = "email_link_mobile")]
        EmailLinkMobile,
        [EnumMember(Value = "none")]
        None
    }

    public class SetAuthorAttachmentInput
    {
        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("attachmentName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AttachmentName { get; set; }

        [JsonProperty("required", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetAuthorAttachmentInputRequiredType Required { get; set; }

        [JsonProperty("addToSealedFile", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetAuthorAttachmentInputAddToSealedFileType AddToSealedFile { get; set; }

        [JsonProperty("pdfContent")]
        public string PdfContent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetAuthorAttachmentInputRequiredType
    {
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetAuthorAttachmentInputAddToSealedFileType
    {
        Yes,
        No
    }

    public class StartAndOnDocumentSignInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookFromTemplateSignInput
    {
        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class PollSignedDocumentsResponse
    {
        [JsonProperty("documents")]
        public PollSignedDocumentsResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class PollSignedDocumentsResponseDocumentsTypeItem
    {
        [JsonProperty("mtime")]
        public string Mtime { get; set; }

        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Scriveesign;

    public partial class WorkflowManagedActions
    {
        public ScriveesignActions Scriveesign(string connectionId) => new ScriveesignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ScriveesignTriggers Scriveesign(string connectionId) => new ScriveesignTriggers(connectionId);
    }
}