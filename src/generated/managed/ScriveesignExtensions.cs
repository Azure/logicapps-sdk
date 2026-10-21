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
        public IBodyWorkflowAction<JToken> GetDocJson(Expression<Func<string>> bodydocumentId)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/getdocumentjson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> GetDocStatus(Expression<Func<string>> bodydocumentId)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/getdocumentstatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> GetPartyStatus(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodypartyId)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodypartyId = WorkflowExpression.Compile(bodypartyId, nameof(bodypartyId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/getpartystatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["partyId"] = ExpressionConverter.ConvertO(__workflow_bodypartyId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken> UpdatePartyEmail(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodypartyId, Expression<Func<string>> bodypartyEmail)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodypartyId = WorkflowExpression.Compile(bodypartyId, nameof(bodypartyId), required: true);
            var __workflow_bodypartyEmail = WorkflowExpression.Compile(bodypartyEmail, nameof(bodypartyEmail), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/updatepartyemail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["partyId"] = ExpressionConverter.ConvertO(__workflow_bodypartyId);
                bodypropCount++;
                body["partyEmail"] = ExpressionConverter.ConvertO(__workflow_bodypartyEmail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken> SendReminder(Expression<Func<string>> bodydocumentId)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/sendreminder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> GetDocumentPdfContent(Expression<Func<string>> bodydocumentId)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/getdocumentpdfcontent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> NewDocumentFromTemplate(Expression<Func<string>> templateIdDynamic)
        {
            var __workflow_templateIdDynamic = WorkflowExpression.Compile(templateIdDynamic, nameof(templateIdDynamic), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/newfromtemplate/{0}", __workflow_templateIdDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> StartSigning(Expression<Func<string>> bodydocumentId)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/startsigning";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction UpdateDocJson(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodydocumentJson)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodydocumentJson = WorkflowExpression.Compile(bodydocumentJson, nameof(bodydocumentJson), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/updatedocumentjson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["documentJson"] = ExpressionConverter.ConvertO(__workflow_bodydocumentJson);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction UpdatePartiesFields(Expression<Func<string>> templateIDDynamic, Expression<Func<object>> dynamicTemplateSchema = null)
        {
            var __workflow_templateIDDynamic = WorkflowExpression.Compile(templateIDDynamic, nameof(templateIDDynamic), required: true);
            var __workflow_dynamicTemplateSchema = WorkflowExpression.Compile(dynamicTemplateSchema, nameof(dynamicTemplateSchema), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/updatepartiesfields/{0}", __workflow_templateIDDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicTemplateSchema);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction UpdatePartiesProperties(Expression<Func<string>> templateIDDynamic, Expression<Func<object>> dynamicTemplateMetaSchema = null)
        {
            var __workflow_templateIDDynamic = WorkflowExpression.Compile(templateIDDynamic, nameof(templateIDDynamic), required: true);
            var __workflow_dynamicTemplateMetaSchema = WorkflowExpression.Compile(dynamicTemplateMetaSchema, nameof(dynamicTemplateMetaSchema), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/updatepartiesproperties/{0}", __workflow_templateIDDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicTemplateMetaSchema);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<JToken> SetFile(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodypdfContent)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodypdfContent = WorkflowExpression.Compile(bodypdfContent, nameof(bodypdfContent), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/setfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["pdfContent"] = ExpressionConverter.ConvertO(__workflow_bodypdfContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IBodyWorkflowAction<string> NewFromPdf(Expression<Func<string>> bodypdfContent, Expression<Func<bodyauthorRoleInput>> bodyauthorRole)
        {
            var __workflow_bodypdfContent = WorkflowExpression.Compile(bodypdfContent, nameof(bodypdfContent), required: true);
            var __workflow_bodyauthorRole = WorkflowExpression.Compile(bodyauthorRole, nameof(bodyauthorRole), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/newfrompdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["pdfContent"] = ExpressionConverter.ConvertO(__workflow_bodypdfContent);
                bodypropCount++;
                body["authorRole"] = ExpressionConverter.ConvertO(__workflow_bodyauthorRole);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction AppendFile(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodypdfContent)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodypdfContent = WorkflowExpression.Compile(bodypdfContent, nameof(bodypdfContent), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/appendfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["pdfContent"] = ExpressionConverter.ConvertO(__workflow_bodypdfContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction Cancel(Expression<Func<string>> bodydocumentId)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/cancel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction AddParty(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodypartyEmail, Expression<Func<bodypartyRoleInput>> bodypartyRole, Expression<Func<string>> bodyfirstname = null, Expression<Func<string>> bodylastname = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodymobile = null, Expression<Func<string>> bodypersonalNumber = null, Expression<Func<double>> bodysignOrder = null, Expression<Func<bodydeliveryMethodInput>> bodydeliveryMethod = null, Expression<Func<bodyauthenticationToViewInput>> bodyauthenticationToView = null, Expression<Func<bodyauthenticationToViewArchivedInput>> bodyauthenticationToViewArchived = null, Expression<Func<bodyauthenticationToSignInput>> bodyauthenticationToSign = null, Expression<Func<bodyconfirmationInput>> bodyconfirmation = null)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodypartyEmail = WorkflowExpression.Compile(bodypartyEmail, nameof(bodypartyEmail), required: true);
            var __workflow_bodypartyRole = WorkflowExpression.Compile(bodypartyRole, nameof(bodypartyRole), required: true);
            var __workflow_bodyfirstname = WorkflowExpression.Compile(bodyfirstname, nameof(bodyfirstname), required: false);
            var __workflow_bodylastname = WorkflowExpression.Compile(bodylastname, nameof(bodylastname), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodymobile = WorkflowExpression.Compile(bodymobile, nameof(bodymobile), required: false);
            var __workflow_bodypersonalNumber = WorkflowExpression.Compile(bodypersonalNumber, nameof(bodypersonalNumber), required: false);
            var __workflow_bodysignOrder = WorkflowExpression.Compile(bodysignOrder, nameof(bodysignOrder), required: false);
            var __workflow_bodydeliveryMethod = WorkflowExpression.Compile(bodydeliveryMethod, nameof(bodydeliveryMethod), required: false);
            var __workflow_bodyauthenticationToView = WorkflowExpression.Compile(bodyauthenticationToView, nameof(bodyauthenticationToView), required: false);
            var __workflow_bodyauthenticationToViewArchived = WorkflowExpression.Compile(bodyauthenticationToViewArchived, nameof(bodyauthenticationToViewArchived), required: false);
            var __workflow_bodyauthenticationToSign = WorkflowExpression.Compile(bodyauthenticationToSign, nameof(bodyauthenticationToSign), required: false);
            var __workflow_bodyconfirmation = WorkflowExpression.Compile(bodyconfirmation, nameof(bodyconfirmation), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/addparty";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["partyEmail"] = ExpressionConverter.ConvertO(__workflow_bodypartyEmail);
                bodypropCount++;
                body["partyRole"] = ExpressionConverter.ConvertO(__workflow_bodypartyRole);
                if (__workflow_bodyfirstname != null)
                {
                    body["firstname"] = ExpressionConverter.ConvertO(__workflow_bodyfirstname);
                    bodypropCount++;
                }

                if (__workflow_bodylastname != null)
                {
                    body["lastname"] = ExpressionConverter.ConvertO(__workflow_bodylastname);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodymobile != null)
                {
                    body["mobile"] = ExpressionConverter.ConvertO(__workflow_bodymobile);
                    bodypropCount++;
                }

                if (__workflow_bodypersonalNumber != null)
                {
                    body["personalNumber"] = ExpressionConverter.ConvertO(__workflow_bodypersonalNumber);
                    bodypropCount++;
                }

                if (__workflow_bodysignOrder != null)
                {
                    body["signOrder"] = ExpressionConverter.ConvertO(__workflow_bodysignOrder);
                    bodypropCount++;
                }

                if (__workflow_bodydeliveryMethod != null)
                {
                    if (__workflow_bodydeliveryMethod != null)
                    {
                        body["deliveryMethod"] = ExpressionConverter.ConvertO(__workflow_bodydeliveryMethod);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["deliveryMethod"] = "email";
                    bodypropCount++;
                }

                if (__workflow_bodyauthenticationToView != null)
                {
                    if (__workflow_bodyauthenticationToView != null)
                    {
                        body["authenticationToView"] = ExpressionConverter.ConvertO(__workflow_bodyauthenticationToView);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["authenticationToView"] = "standard";
                    bodypropCount++;
                }

                if (__workflow_bodyauthenticationToViewArchived != null)
                {
                    if (__workflow_bodyauthenticationToViewArchived != null)
                    {
                        body["authenticationToViewArchived"] = ExpressionConverter.ConvertO(__workflow_bodyauthenticationToViewArchived);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["authenticationToViewArchived"] = "standard";
                    bodypropCount++;
                }

                if (__workflow_bodyauthenticationToSign != null)
                {
                    if (__workflow_bodyauthenticationToSign != null)
                    {
                        body["authenticationToSign"] = ExpressionConverter.ConvertO(__workflow_bodyauthenticationToSign);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["authenticationToSign"] = "standard";
                    bodypropCount++;
                }

                if (__workflow_bodyconfirmation != null)
                {
                    if (__workflow_bodyconfirmation != null)
                    {
                        body["confirmation"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmation);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scriveesign")]
        public IWorkflowAction SetAuthorAttachment(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodyattachmentName, Expression<Func<bodyrequiredInput>> bodyrequired, Expression<Func<bodyaddToSealedFileInput>> bodyaddToSealedFile, Expression<Func<string>> bodyfileId = null, Expression<Func<string>> bodypdfContent = null)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodyattachmentName = WorkflowExpression.Compile(bodyattachmentName, nameof(bodyattachmentName), required: true);
            var __workflow_bodyrequired = WorkflowExpression.Compile(bodyrequired, nameof(bodyrequired), required: true);
            var __workflow_bodyaddToSealedFile = WorkflowExpression.Compile(bodyaddToSealedFile, nameof(bodyaddToSealedFile), required: true);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodypdfContent = WorkflowExpression.Compile(bodypdfContent, nameof(bodypdfContent), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/setattachment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfileId != null)
                {
                    body["fileId"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["attachmentName"] = ExpressionConverter.ConvertO(__workflow_bodyattachmentName);
                bodypropCount++;
                body["required"] = ExpressionConverter.ConvertO(__workflow_bodyrequired);
                bodypropCount++;
                body["addToSealedFile"] = ExpressionConverter.ConvertO(__workflow_bodyaddToSealedFile);
                if (__workflow_bodypdfContent != null)
                {
                    body["pdfContent"] = ExpressionConverter.ConvertO(__workflow_bodypdfContent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class ScriveesignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string> StartAndOnDocumentSign(Expression<Func<string>> bodydocumentId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = "/webhooks/signed/createandstart";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<string> WebhookFromTemplateSign(Expression<Func<string>> templateIdDynamic, FlowRecurrence recurrence = null)
        {
            var __workflow_templateIdDynamic = WorkflowExpression.Compile(templateIdDynamic, nameof(templateIdDynamic), required: true);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/webhooks/signedfromtemplate/create/{0}", __workflow_templateIdDynamic.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IBodyWorkflowTrigger<PollSignedDocumentsResponse> PollSignedDocuments(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/signed";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pollTime"] = Convert.ToString("init");
            return new ApiConnectionTrigger<PollSignedDocumentsResponse>(callPayload, recurrence: recurrence);
        }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyauthorRoleInput
    {
        [EnumMember(Value = "signing_party")]
        SigningParty,
        [EnumMember(Value = "viewer")]
        Viewer
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypartyRoleInput
    {
        [EnumMember(Value = "signing_party")]
        SigningParty,
        [EnumMember(Value = "viewer")]
        Viewer,
        [EnumMember(Value = "approver")]
        Approver
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrequiredInput
    {
        Yes,
        No
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
