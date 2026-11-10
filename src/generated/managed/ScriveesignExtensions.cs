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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetDocJson(Expression<Func<CancelBodyInput>> body)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetDocStatus(Expression<Func<CancelBodyInput>> body)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetPartyStatus(Expression<Func<GetPartyStatusBodyInput>> body)
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdatePartyEmail(Expression<Func<UpdatePartyEmailBodyInput>> body)
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SendReminder(Expression<Func<CancelBodyInput>> body)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetDocumentPdfContent(Expression<Func<CancelBodyInput>> body)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> StartSigning(Expression<Func<CancelBodyInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateDocJson(Expression<Func<UpdateDocJsonBodyInput>> body)
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> SetFile(Expression<Func<AppendFileBodyInput>> body)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> NewFromPdf(Expression<Func<NewFromPdfBodyInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> AppendFile(Expression<Func<AppendFileBodyInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> Cancel(Expression<Func<CancelBodyInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> AddParty(Expression<Func<AddPartyBodyInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> SetAuthorAttachment(Expression<Func<SetAuthorAttachmentBodyInput>> body)
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
        public IBodyWorkflowTrigger<string, ApiConnectionPollingTriggerConfiguration> StartAndOnDocumentSign(Expression<Func<StartAndOnDocumentSignBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/signed/createandstart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<string>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionPollingTriggerConfiguration> WebhookFromTemplateSign(Expression<Func<string>> templateIdDynamic)
        {
            var __workflow_templateIdDynamic = WorkflowExpression.Compile(templateIdDynamic, nameof(templateIdDynamic), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhooks/signedfromtemplate/create/{0}", __workflow_templateIdDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new WebhookFromTemplateSignBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<string>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<PollSignedDocumentsResponse, ApiConnectionPollingTriggerConfiguration> PollSignedDocuments()
        {
            return new DeferredBodyTrigger<PollSignedDocumentsResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/polling/signed";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionPollingTrigger<PollSignedDocumentsResponse>(callPayload);
            });
        }
    }

    public class CancelBodyInput
    {
        public CancelBodyInput(string documentId)
        {
            this.DocumentId = documentId;
        }

        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }
    }

    public class GetPartyStatusBodyInput
    {
        public GetPartyStatusBodyInput(string documentId, string partyId)
        {
            this.DocumentId = documentId;
            this.PartyId = partyId;
        }

        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("partyId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PartyId { get; set; }
    }

    public class UpdatePartyEmailBodyInput
    {
        public UpdatePartyEmailBodyInput(string documentId, string partyId, string partyEmail)
        {
            this.DocumentId = documentId;
            this.PartyId = partyId;
            this.PartyEmail = partyEmail;
        }

        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("partyId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PartyId { get; set; }

        [JsonProperty("partyEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PartyEmail { get; set; }
    }

    public class UpdateDocJsonBodyInput
    {
        public UpdateDocJsonBodyInput(string documentId, string documentJson)
        {
            this.DocumentId = documentId;
            this.DocumentJson = documentJson;
        }

        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("documentJson", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentJson { get; set; }
    }

    public class AppendFileBodyInput
    {
        public AppendFileBodyInput(string documentId, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent pdfContent)
        {
            this.DocumentId = documentId;
            this.PdfContent = pdfContent;
        }

        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("pdfContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PdfContent { get; set; }
    }

    public class NewFromPdfBodyInput
    {
        public NewFromPdfBodyInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent pdfContent)
        {
            this.PdfContent = pdfContent;
        }

        [JsonProperty("pdfContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PdfContent { get; set; }

        [JsonProperty("authorRole", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAuthorRoleType AuthorRole { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Scriveesign.BodyInputAuthorRoleType.SigningParty;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputAuthorRoleType
    {
        [EnumMember(Value = "signing_party")]
        SigningParty,
        [EnumMember(Value = "viewer")]
        Viewer
    }

    public class AddPartyBodyInput
    {
        public AddPartyBodyInput(string documentId, string partyEmail)
        {
            this.DocumentId = documentId;
            this.PartyEmail = partyEmail;
        }

        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("partyEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PartyEmail { get; set; }

        [JsonProperty("partyRole", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPartyRoleType PartyRole { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Scriveesign.BodyInputPartyRoleType.SigningParty;

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
        public BodyInputDeliveryMethodType? DeliveryMethod { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Scriveesign.BodyInputDeliveryMethodType.Email;

        [JsonProperty("authenticationToView", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthenticationToView { get; set; } = "standard";

        [JsonProperty("authenticationToViewArchived", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthenticationToViewArchived { get; set; } = "standard";

        [JsonProperty("authenticationToSign", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthenticationToSign { get; set; } = "standard";

        [JsonProperty("confirmation", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConfirmationType? Confirmation { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Scriveesign.BodyInputConfirmationType.Email;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPartyRoleType
    {
        [EnumMember(Value = "signing_party")]
        SigningParty,
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "approver")]
        Approver
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDeliveryMethodType
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
    public enum BodyInputConfirmationType
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

    public class SetAuthorAttachmentBodyInput
    {
        public SetAuthorAttachmentBodyInput(string documentId, string attachmentName, BodyInputRequiredType @required, BodyInputAddToSealedFileType addToSealedFile)
        {
            this.DocumentId = documentId;
            this.AttachmentName = attachmentName;
            this.Required = @required;
            this.AddToSealedFile = addToSealedFile;
        }

        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("attachmentName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AttachmentName { get; set; }

        [JsonProperty("required", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRequiredType Required { get; set; }

        [JsonProperty("addToSealedFile", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAddToSealedFileType AddToSealedFile { get; set; }

        [JsonProperty("pdfContent")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent PdfContent { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRequiredType
    {
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputAddToSealedFileType
    {
        Yes,
        No
    }

    public class StartAndOnDocumentSignBodyInput
    {
        public StartAndOnDocumentSignBodyInput(string documentId)
        {
            this.DocumentId = documentId;
        }

        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("webhookUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class WebhookFromTemplateSignBodyInput
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