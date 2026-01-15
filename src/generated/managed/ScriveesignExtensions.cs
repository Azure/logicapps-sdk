//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Scriveesign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ScriveesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken> GetDocJson(Expression<Func<string>> bodydocumentId)
        {
            var apiCallPath = "/getdocumentjson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> GetDocStatus(Expression<Func<string>> bodydocumentId)
        {
            var apiCallPath = "/getdocumentstatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> GetPartyStatus(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodypartyId)
        {
            var apiCallPath = "/getpartystatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            bodypropCount++;
            body["partyId"] = ExpressionConverter.ConvertO(bodypartyId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken> UpdatePartyEmail(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodypartyId, Expression<Func<string>> bodypartyEmail)
        {
            var apiCallPath = "/updatepartyemail";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            bodypropCount++;
            body["partyId"] = ExpressionConverter.ConvertO(bodypartyId);
            bodypropCount++;
            body["partyEmail"] = ExpressionConverter.ConvertO(bodypartyEmail);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken> SendReminder(Expression<Func<string>> bodydocumentId)
        {
            var apiCallPath = "/sendreminder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> GetDocumentPdfContent(Expression<Func<string>> bodydocumentId)
        {
            var apiCallPath = "/getdocumentpdfcontent";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> NewDocumentFromTemplate(Expression<Func<string>> templateIdDynamic)
        {
            var apiCallPath = String.Format("/newfromtemplate/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateIdDynamic, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> StartSigning(Expression<Func<string>> bodydocumentId)
        {
            var apiCallPath = "/startsigning";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction UpdateDocJson(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodydocumentJson)
        {
            var apiCallPath = "/updatedocumentjson";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            bodypropCount++;
            body["documentJson"] = ExpressionConverter.ConvertO(bodydocumentJson);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction UpdatePartiesFields(Expression<Func<string>> templateIDDynamic, Expression<Func<object>> dynamicTemplateSchema = null)
        {
            var apiCallPath = String.Format("/updatepartiesfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateIDDynamic, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(dynamicTemplateSchema);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction UpdatePartiesProperties(Expression<Func<string>> templateIDDynamic, Expression<Func<object>> dynamicTemplateMetaSchema = null)
        {
            var apiCallPath = String.Format("/updatepartiesproperties/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateIDDynamic, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(dynamicTemplateMetaSchema);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken> SetFile(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodypdfContent)
        {
            var apiCallPath = "/setfile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            bodypropCount++;
            body["pdfContent"] = ExpressionConverter.ConvertO(bodypdfContent);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> NewFromPdf(Expression<Func<string>> bodypdfContent, Expression<Func<bodyauthorRoleInput>> bodyauthorRole)
        {
            var apiCallPath = "/newfrompdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["pdfContent"] = ExpressionConverter.ConvertO(bodypdfContent);
            bodypropCount++;
            body["authorRole"] = ExpressionConverter.ConvertO(bodyauthorRole);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction AppendFile(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodypdfContent)
        {
            var apiCallPath = "/appendfile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            bodypropCount++;
            body["pdfContent"] = ExpressionConverter.ConvertO(bodypdfContent);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction Cancel(Expression<Func<string>> bodydocumentId)
        {
            var apiCallPath = "/cancel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction AddParty(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodypartyEmail, Expression<Func<bodypartyRoleInput>> bodypartyRole, Expression<Func<string>> bodyfirstname = null, Expression<Func<string>> bodylastname = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodymobile = null, Expression<Func<string>> bodypersonalNumber = null, Expression<Func<double>> bodysignOrder = null, Expression<Func<bodydeliveryMethodInput>> bodydeliveryMethod = null, Expression<Func<bodyauthenticationToViewInput>> bodyauthenticationToView = null, Expression<Func<bodyauthenticationToViewArchivedInput>> bodyauthenticationToViewArchived = null, Expression<Func<bodyauthenticationToSignInput>> bodyauthenticationToSign = null, Expression<Func<bodyconfirmationInput>> bodyconfirmation = null)
        {
            var apiCallPath = "/addparty";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            bodypropCount++;
            body["partyEmail"] = ExpressionConverter.ConvertO(bodypartyEmail);
            bodypropCount++;
            body["partyRole"] = ExpressionConverter.ConvertO(bodypartyRole);
            if (bodyfirstname != null)
            {
                body["firstname"] = ExpressionConverter.ConvertO(bodyfirstname);
                bodypropCount++;
            }

            if (bodylastname != null)
            {
                body["lastname"] = ExpressionConverter.ConvertO(bodylastname);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = ExpressionConverter.ConvertO(bodycompany);
                bodypropCount++;
            }

            if (bodymobile != null)
            {
                body["mobile"] = ExpressionConverter.ConvertO(bodymobile);
                bodypropCount++;
            }

            if (bodypersonalNumber != null)
            {
                body["personalNumber"] = ExpressionConverter.ConvertO(bodypersonalNumber);
                bodypropCount++;
            }

            if (bodysignOrder != null)
            {
                body["signOrder"] = ExpressionConverter.ConvertO(bodysignOrder);
                bodypropCount++;
            }

            if (bodydeliveryMethod != null)
            {
                body["deliveryMethod"] = ExpressionConverter.ConvertO(bodydeliveryMethod);
                bodypropCount++;
            }

            if (bodyauthenticationToView != null)
            {
                body["authenticationToView"] = ExpressionConverter.ConvertO(bodyauthenticationToView);
                bodypropCount++;
            }

            if (bodyauthenticationToViewArchived != null)
            {
                body["authenticationToViewArchived"] = ExpressionConverter.ConvertO(bodyauthenticationToViewArchived);
                bodypropCount++;
            }

            if (bodyauthenticationToSign != null)
            {
                body["authenticationToSign"] = ExpressionConverter.ConvertO(bodyauthenticationToSign);
                bodypropCount++;
            }

            if (bodyconfirmation != null)
            {
                body["confirmation"] = ExpressionConverter.ConvertO(bodyconfirmation);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction SetAuthorAttachment(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodyattachmentName, Expression<Func<bodyrequiredInput>> bodyrequired, Expression<Func<bodyaddToSealedFileInput>> bodyaddToSealedFile, Expression<Func<string>> bodyfileId = null, Expression<Func<string>> bodypdfContent = null)
        {
            var apiCallPath = "/setattachment";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfileId != null)
            {
                body["fileId"] = ExpressionConverter.ConvertO(bodyfileId);
                bodypropCount++;
            }

            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            bodypropCount++;
            body["attachmentName"] = ExpressionConverter.ConvertO(bodyattachmentName);
            bodypropCount++;
            body["required"] = ExpressionConverter.ConvertO(bodyrequired);
            bodypropCount++;
            body["addToSealedFile"] = ExpressionConverter.ConvertO(bodyaddToSealedFile);
            if (bodypdfContent != null)
            {
                body["pdfContent"] = ExpressionConverter.ConvertO(bodypdfContent);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class ScriveesignTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<string> StartAndOnDocumentSign(Expression<Func<string>> bodydocumentId)
        {
            var apiCallPath = "/webhooks/signed/createandstart";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
            body["webhookUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> WebhookFromTemplateSign(Expression<Func<string>> templateIdDynamic)
        {
            var apiCallPath = String.Format("/webhooks/signedfromtemplate/create/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateIdDynamic, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<PollSignedDocumentsResponse> PollSignedDocuments()
        {
            var apiCallPath = "/trigger/polling/signed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pollTime"] = Convert.ToString("init");
            return new ApiConnectionTrigger<PollSignedDocumentsResponse>(callPayload);
        }
    }

    public enum bodyauthorRoleInput
    {
        [EnumMember(Value = "signing_party")]
        SigningParty,
        [EnumMember(Value = "viewer")]
        Viewer
    }

    public enum bodypartyRoleInput
    {
        [EnumMember(Value = "signing_party")]
        SigningParty,
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "approver")]
        Approver
    }

    public enum bodydeliveryMethodInput
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

    public enum bodyauthenticationToViewInput
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "sms_pin")]
        SmsPin,
        [EnumMember(Value = "se_bankid")]
        SeBankid,
        [EnumMember(Value = "no_bankid")]
        NoBankid,
        [EnumMember(Value = "dk_nemid")]
        DkNemid,
        [EnumMember(Value = "fi_tupas")]
        FiTupas,
        [EnumMember(Value = "verimi")]
        Verimi,
        [EnumMember(Value = "nl_idin")]
        NlIdin
    }

    public enum bodyauthenticationToViewArchivedInput
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "sms_pin")]
        SmsPin,
        [EnumMember(Value = "se_bankid")]
        SeBankid,
        [EnumMember(Value = "no_bankid")]
        NoBankid,
        [EnumMember(Value = "dk_nemid")]
        DkNemid,
        [EnumMember(Value = "fi_tupas")]
        FiTupas,
        [EnumMember(Value = "verimi")]
        Verimi,
        [EnumMember(Value = "nl_idin")]
        NlIdin
    }

    public enum bodyauthenticationToSignInput
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "sms_pin")]
        SmsPin,
        [EnumMember(Value = "se_bankid")]
        SeBankid,
        [EnumMember(Value = "no_bankid")]
        NoBankid,
        [EnumMember(Value = "dk_nemid")]
        DkNemid,
        [EnumMember(Value = "fi_tupas")]
        FiTupas,
        [EnumMember(Value = "onfido_document_check")]
        OnfidoDocumentCheck,
        [EnumMember(Value = "onfido_document_and_photo_check")]
        OnfidoDocumentAndPhotoCheck
    }

    public enum bodyconfirmationInput
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

    public enum bodyrequiredInput
    {
        Yes,
        No
    }

    public enum bodyaddToSealedFileInput
    {
        Yes,
        No
    }

    public class PollSignedDocumentsResponse
    {
        [JsonProperty("pollTime")]
        public string PollTime { get; set; }

        [JsonProperty("documents")]
        public PollSignedDocumentsResponseDocumentsTypeItem[] Documents { get; set; }
    }

    public class PollSignedDocumentsResponseDocumentsTypeItem
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Scriveesign;

    public partial class WorkflowManagedActions
    {
        public ScriveesignActions Scriveesign(string connectionId) => new ScriveesignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ScriveesignTriggers Scriveesign(string connectionId) => new ScriveesignTriggers(connectionId);
    }
}