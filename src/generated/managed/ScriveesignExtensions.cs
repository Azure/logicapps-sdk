//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Scriveesign
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
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
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
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
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
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
            bodypropCount++;
            body["partyId"] = CSharpExpressionConverter.ConvertToken(bodypartyId);
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
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
            bodypropCount++;
            body["partyId"] = CSharpExpressionConverter.ConvertToken(bodypartyId);
            bodypropCount++;
            body["partyEmail"] = CSharpExpressionConverter.ConvertToken(bodypartyEmail);
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
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
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
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> NewDocumentFromTemplate(Expression<Func<string>> templateIdDynamic)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/newfromtemplate/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateIdDynamic, 1));
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
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
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
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
            bodypropCount++;
            body["documentJson"] = CSharpExpressionConverter.ConvertToken(bodydocumentJson);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction UpdatePartiesFields(Expression<Func<string>> templateIDDynamic, Expression<Func<object>> dynamicTemplateSchema = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/updatepartiesfields/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateIDDynamic, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(dynamicTemplateSchema);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction UpdatePartiesProperties(Expression<Func<string>> templateIDDynamic, Expression<Func<object>> dynamicTemplateMetaSchema = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/updatepartiesproperties/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateIDDynamic, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(dynamicTemplateMetaSchema);
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
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
            bodypropCount++;
            body["pdfContent"] = CSharpExpressionConverter.ConvertToken(bodypdfContent);
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
            body["pdfContent"] = CSharpExpressionConverter.ConvertToken(bodypdfContent);
            bodypropCount++;
            body["authorRole"] = CSharpExpressionConverter.Convert(bodyauthorRole);
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
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
            bodypropCount++;
            body["pdfContent"] = CSharpExpressionConverter.ConvertToken(bodypdfContent);
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
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
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
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
            bodypropCount++;
            body["partyEmail"] = CSharpExpressionConverter.ConvertToken(bodypartyEmail);
            bodypropCount++;
            body["partyRole"] = CSharpExpressionConverter.Convert(bodypartyRole);
            if (bodyfirstname != null)
            {
                body["firstname"] = CSharpExpressionConverter.ConvertToken(bodyfirstname);
                bodypropCount++;
            }

            if (bodylastname != null)
            {
                body["lastname"] = CSharpExpressionConverter.ConvertToken(bodylastname);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
            }

            if (bodymobile != null)
            {
                body["mobile"] = CSharpExpressionConverter.ConvertToken(bodymobile);
                bodypropCount++;
            }

            if (bodypersonalNumber != null)
            {
                body["personalNumber"] = CSharpExpressionConverter.ConvertToken(bodypersonalNumber);
                bodypropCount++;
            }

            if (bodysignOrder != null)
            {
                body["signOrder"] = CSharpExpressionConverter.ConvertToken(bodysignOrder);
                bodypropCount++;
            }

            if (bodydeliveryMethod != null)
            {
                if (bodydeliveryMethod != null)
                {
                    body["deliveryMethod"] = CSharpExpressionConverter.Convert(bodydeliveryMethod);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["deliveryMethod"] = "email";
                bodypropCount++;
            }

            if (bodyauthenticationToView != null)
            {
                if (bodyauthenticationToView != null)
                {
                    body["authenticationToView"] = CSharpExpressionConverter.Convert(bodyauthenticationToView);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["authenticationToView"] = "standard";
                bodypropCount++;
            }

            if (bodyauthenticationToViewArchived != null)
            {
                if (bodyauthenticationToViewArchived != null)
                {
                    body["authenticationToViewArchived"] = CSharpExpressionConverter.Convert(bodyauthenticationToViewArchived);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["authenticationToViewArchived"] = "standard";
                bodypropCount++;
            }

            if (bodyauthenticationToSign != null)
            {
                if (bodyauthenticationToSign != null)
                {
                    body["authenticationToSign"] = CSharpExpressionConverter.Convert(bodyauthenticationToSign);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["authenticationToSign"] = "standard";
                bodypropCount++;
            }

            if (bodyconfirmation != null)
            {
                if (bodyconfirmation != null)
                {
                    body["confirmation"] = CSharpExpressionConverter.Convert(bodyconfirmation);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["confirmation"] = "email";
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
                body["fileId"] = CSharpExpressionConverter.ConvertToken(bodyfileId);
                bodypropCount++;
            }

            bodypropCount++;
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
            bodypropCount++;
            body["attachmentName"] = CSharpExpressionConverter.ConvertToken(bodyattachmentName);
            bodypropCount++;
            body["required"] = CSharpExpressionConverter.Convert(bodyrequired);
            bodypropCount++;
            body["addToSealedFile"] = CSharpExpressionConverter.Convert(bodyaddToSealedFile);
            if (bodypdfContent != null)
            {
                body["pdfContent"] = CSharpExpressionConverter.ConvertToken(bodypdfContent);
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
        public IBodyWorkflowTrigger<string> StartAndOnDocumentSign(Expression<Func<string>> bodydocumentId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/signed/createandstart";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["documentId"] = CSharpExpressionConverter.ConvertToken(bodydocumentId);
            body["webhookUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> WebhookFromTemplateSign(Expression<Func<string>> templateIdDynamic, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/webhooks/signedfromtemplate/create/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateIdDynamic, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollSignedDocumentsResponse> PollSignedDocuments(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/signed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pollTime"] = Convert.ToString("init");
            return new ApiConnectionTrigger<PollSignedDocumentsResponse>(callPayload, triggerName, recurrence);
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