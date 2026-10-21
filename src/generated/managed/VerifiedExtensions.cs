//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Verified
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VerifiedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostAuthenticateResponse> PostAuthenticate(Expression<Func<int>> withoutIpLock)
        {
            var __workflow_withoutIpLock = WorkflowExpression.Compile(withoutIpLock, nameof(withoutIpLock), required: true);
            return new DeferredBodyAction<PostAuthenticateResponse>(() =>
            {
                var apiCallPath = "/auth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["withoutIpLock"] = ExpressionConverter.Convert(__workflow_withoutIpLock);
                return new ApiConnectionAction<PostAuthenticateResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Company> GetCompaniesCompanyId(Expression<Func<string>> token, Expression<Func<string>> companyId)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            return new DeferredBodyAction<Company>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/companies/{0}", __workflow_companyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Company>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Recipient[]> GetEnvelopesEnvelopeIdRecipients(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Recipient[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/recipients", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<Recipient[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdRecipients(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> bodygivenName, Expression<Func<string>> bodyfamilyName, Expression<Func<bodylanguageInput>> bodylanguage, Expression<Func<bodysigningMethodInput>> bodysigningMethod, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyroleaction, Expression<Func<string>> bodyrolelabel, Expression<Func<string>> bodyrolename, Expression<Func<string>> xNamespace = null, Expression<Func<bodynotificationMethodInput>> bodynotificationMethod = null, Expression<Func<string>> bodytelephone = null, Expression<Func<int>> bodyorder = null, Expression<Func<bool>> bodysecure = null, Expression<Func<bool>> bodysms = null, Expression<Func<string>> bodyssn = null, Expression<Func<string>> bodybank = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_bodygivenName = WorkflowExpression.Compile(bodygivenName, nameof(bodygivenName), required: true);
            var __workflow_bodyfamilyName = WorkflowExpression.Compile(bodyfamilyName, nameof(bodyfamilyName), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodysigningMethod = WorkflowExpression.Compile(bodysigningMethod, nameof(bodysigningMethod), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyroleaction = WorkflowExpression.Compile(bodyroleaction, nameof(bodyroleaction), required: true);
            var __workflow_bodyrolelabel = WorkflowExpression.Compile(bodyrolelabel, nameof(bodyrolelabel), required: true);
            var __workflow_bodyrolename = WorkflowExpression.Compile(bodyrolename, nameof(bodyrolename), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodynotificationMethod = WorkflowExpression.Compile(bodynotificationMethod, nameof(bodynotificationMethod), required: false);
            var __workflow_bodytelephone = WorkflowExpression.Compile(bodytelephone, nameof(bodytelephone), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodysecure = WorkflowExpression.Compile(bodysecure, nameof(bodysecure), required: false);
            var __workflow_bodysms = WorkflowExpression.Compile(bodysms, nameof(bodysms), required: false);
            var __workflow_bodyssn = WorkflowExpression.Compile(bodyssn, nameof(bodyssn), required: false);
            var __workflow_bodybank = WorkflowExpression.Compile(bodybank, nameof(bodybank), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/recipients", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["givenName"] = ExpressionConverter.ConvertO(__workflow_bodygivenName);
                bodypropCount++;
                body["familyName"] = ExpressionConverter.ConvertO(__workflow_bodyfamilyName);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["signingMethod"] = ExpressionConverter.ConvertO(__workflow_bodysigningMethod);
                if (__workflow_bodynotificationMethod != null)
                {
                    body["notificationMethod"] = ExpressionConverter.ConvertO(__workflow_bodynotificationMethod);
                    bodypropCount++;
                }

                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodytelephone != null)
                {
                    body["telephone"] = ExpressionConverter.ConvertO(__workflow_bodytelephone);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                var roleObject = new JObject();
                var roleObjectpropCount = 0;
                roleObjectpropCount++;
                roleObject["action"] = ExpressionConverter.ConvertO(__workflow_bodyroleaction);
                roleObjectpropCount++;
                roleObject["label"] = ExpressionConverter.ConvertO(__workflow_bodyrolelabel);
                roleObjectpropCount++;
                roleObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrolename);
                if (roleObjectpropCount > 0)
                {
                    body["role"] = roleObject;
                    bodypropCount++;
                }

                if (__workflow_bodysecure != null)
                {
                    body["secure"] = ExpressionConverter.ConvertO(__workflow_bodysecure);
                    bodypropCount++;
                }

                if (__workflow_bodysms != null)
                {
                    body["sms"] = ExpressionConverter.ConvertO(__workflow_bodysms);
                    bodypropCount++;
                }

                if (__workflow_bodyssn != null)
                {
                    body["ssn"] = ExpressionConverter.ConvertO(__workflow_bodyssn);
                    bodypropCount++;
                }

                if (__workflow_bodybank != null)
                {
                    body["bank"] = ExpressionConverter.ConvertO(__workflow_bodybank);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Recipient> GetEnvelopesEnvelopeIdRecipientsRecipientId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Recipient>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/recipients/{1}", __workflow_envelopeId.WithUrlEncoding(1), __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<Recipient>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdRecipientsRecipientId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> bodygivenName, Expression<Func<string>> bodyfamilyName, Expression<Func<bodylanguageInput>> bodylanguage, Expression<Func<bodysigningMethodInput>> bodysigningMethod, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyroleaction, Expression<Func<string>> bodyrolelabel, Expression<Func<string>> bodyrolename, Expression<Func<string>> xNamespace = null, Expression<Func<bodynotificationMethodInput>> bodynotificationMethod = null, Expression<Func<string>> bodytelephone = null, Expression<Func<int>> bodyorder = null, Expression<Func<bool>> bodysecure = null, Expression<Func<bool>> bodysms = null, Expression<Func<string>> bodyssn = null, Expression<Func<string>> bodybank = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_bodygivenName = WorkflowExpression.Compile(bodygivenName, nameof(bodygivenName), required: true);
            var __workflow_bodyfamilyName = WorkflowExpression.Compile(bodyfamilyName, nameof(bodyfamilyName), required: true);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodysigningMethod = WorkflowExpression.Compile(bodysigningMethod, nameof(bodysigningMethod), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyroleaction = WorkflowExpression.Compile(bodyroleaction, nameof(bodyroleaction), required: true);
            var __workflow_bodyrolelabel = WorkflowExpression.Compile(bodyrolelabel, nameof(bodyrolelabel), required: true);
            var __workflow_bodyrolename = WorkflowExpression.Compile(bodyrolename, nameof(bodyrolename), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodynotificationMethod = WorkflowExpression.Compile(bodynotificationMethod, nameof(bodynotificationMethod), required: false);
            var __workflow_bodytelephone = WorkflowExpression.Compile(bodytelephone, nameof(bodytelephone), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodysecure = WorkflowExpression.Compile(bodysecure, nameof(bodysecure), required: false);
            var __workflow_bodysms = WorkflowExpression.Compile(bodysms, nameof(bodysms), required: false);
            var __workflow_bodyssn = WorkflowExpression.Compile(bodyssn, nameof(bodyssn), required: false);
            var __workflow_bodybank = WorkflowExpression.Compile(bodybank, nameof(bodybank), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/recipients/{1}", __workflow_envelopeId.WithUrlEncoding(1), __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["givenName"] = ExpressionConverter.ConvertO(__workflow_bodygivenName);
                bodypropCount++;
                body["familyName"] = ExpressionConverter.ConvertO(__workflow_bodyfamilyName);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                bodypropCount++;
                body["signingMethod"] = ExpressionConverter.ConvertO(__workflow_bodysigningMethod);
                if (__workflow_bodynotificationMethod != null)
                {
                    body["notificationMethod"] = ExpressionConverter.ConvertO(__workflow_bodynotificationMethod);
                    bodypropCount++;
                }

                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodytelephone != null)
                {
                    body["telephone"] = ExpressionConverter.ConvertO(__workflow_bodytelephone);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                var roleObject = new JObject();
                var roleObjectpropCount = 0;
                roleObjectpropCount++;
                roleObject["action"] = ExpressionConverter.ConvertO(__workflow_bodyroleaction);
                roleObjectpropCount++;
                roleObject["label"] = ExpressionConverter.ConvertO(__workflow_bodyrolelabel);
                roleObjectpropCount++;
                roleObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyrolename);
                if (roleObjectpropCount > 0)
                {
                    body["role"] = roleObject;
                    bodypropCount++;
                }

                if (__workflow_bodysecure != null)
                {
                    body["secure"] = ExpressionConverter.ConvertO(__workflow_bodysecure);
                    bodypropCount++;
                }

                if (__workflow_bodysms != null)
                {
                    body["sms"] = ExpressionConverter.ConvertO(__workflow_bodysms);
                    bodypropCount++;
                }

                if (__workflow_bodyssn != null)
                {
                    body["ssn"] = ExpressionConverter.ConvertO(__workflow_bodyssn);
                    bodypropCount++;
                }

                if (__workflow_bodybank != null)
                {
                    body["bank"] = ExpressionConverter.ConvertO(__workflow_bodybank);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse> GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrl(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> fileId, Expression<Func<string>> xNamespace = null, Expression<Func<bool>> asObject = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_asObject = WorkflowExpression.Compile(asObject, nameof(asObject), required: false);
            return new DeferredBodyAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents/{1}/files/{2}/url", __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_asObject != null)
                    callPayload.Queries["asObject"] = ExpressionConverter.Convert(__workflow_asObject);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Setting> GetCompaniesCompanyIdUsersUserIdSettings(Expression<Func<string>> token, Expression<Func<string>> companyId, Expression<Func<string>> userId)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<Setting>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/companies/{0}/users/{1}/settings", __workflow_companyId.WithUrlEncoding(1), __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Setting>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Envelope> GetEnvelopesEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Envelope>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<Envelope>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction DeleteEnvelopesEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<bool>> bodysequentialSigning = null, Expression<Func<string>> bodygreeting = null, Expression<Func<string>> bodyexpiration = null, Expression<Func<double>> bodyautomaticReminders = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodysequentialSigning = WorkflowExpression.Compile(bodysequentialSigning, nameof(bodysequentialSigning), required: false);
            var __workflow_bodygreeting = WorkflowExpression.Compile(bodygreeting, nameof(bodygreeting), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyautomaticReminders = WorkflowExpression.Compile(bodyautomaticReminders, nameof(bodyautomaticReminders), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysequentialSigning != null)
                {
                    body["sequentialSigning"] = ExpressionConverter.ConvertO(__workflow_bodysequentialSigning);
                    bodypropCount++;
                }

                if (__workflow_bodygreeting != null)
                {
                    body["greeting"] = ExpressionConverter.ConvertO(__workflow_bodygreeting);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                    bodypropCount++;
                }

                if (__workflow_bodyautomaticReminders != null)
                {
                    body["automaticReminders"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticReminders);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdPublishStatus(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<bool>> bodypublished, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_bodypublished = WorkflowExpression.Compile(bodypublished, nameof(bodypublished), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/publish-status", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["published"] = ExpressionConverter.ConvertO(__workflow_bodypublished);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocumentsDocumentIdTemplatesTemplateIdUserData(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> templateId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents/{1}/templates/{2}/user-data", __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1), __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdAbortStatus(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/abort-status", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<File[]> GetEnvelopesEnvelopeIdDocumentsDocumentIdFiles(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<File[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents/{1}/files", __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<File[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<File> PostEnvelopesEnvelopeIdDocumentsDocumentIdFiles(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyfileType, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodyhash = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyfileType = WorkflowExpression.Compile(bodyfileType, nameof(bodyfileType), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodyhash = WorkflowExpression.Compile(bodyhash, nameof(bodyhash), required: false);
            return new DeferredBodyAction<File>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents/{1}/files", __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["fileType"] = ExpressionConverter.ConvertO(__workflow_bodyfileType);
                if (__workflow_bodyhash != null)
                {
                    body["hash"] = ExpressionConverter.ConvertO(__workflow_bodyhash);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<File>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<UserInfo> GetAuthUserinfo(Expression<Func<string>> token)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            return new DeferredBodyAction<UserInfo>(() =>
            {
                var apiCallPath = "/auth/userinfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<UserInfo>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocumentsDocumentIdStatusAborted(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents/{1}/status/aborted", __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdTrashStatus(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/trash-status", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<EnvelopeDescriptorString[]> GetQueryEnvelopes(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null, Expression<Func<int>> from = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<EnvelopeDescriptorString[]>(() =>
            {
                var apiCallPath = "/query/envelopes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(__workflow_filters);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<EnvelopeDescriptorString[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<EnvelopeDescriptorString[]> GetSearchEnvelopes(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null, Expression<Func<int>> from = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<EnvelopeDescriptorString[]>(() =>
            {
                var apiCallPath = "/search/envelopes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(__workflow_filters);
                if (__workflow_from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(__workflow_from);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<EnvelopeDescriptorString[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Descriptor[]> GetEnvelopeDescriptors(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            return new DeferredBodyAction<Descriptor[]>(() =>
            {
                var apiCallPath = "/envelope-descriptors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(__workflow_filters);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<Descriptor[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<GetFlowsFlowIdJobsEnvelopeIdResponse> GetFlowsFlowIdJobsEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> flowId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_flowId = WorkflowExpression.Compile(flowId, nameof(flowId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<GetFlowsFlowIdJobsEnvelopeIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/flows/{0}/jobs/{1}", __workflow_flowId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<GetFlowsFlowIdJobsEnvelopeIdResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Document> GetEnvelopesEnvelopeIdDocumentsDocumentId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Document>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents/{1}", __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<Document>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction DeleteEnvelopesEnvelopeIdDocumentsDocumentId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents/{1}", __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse> PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopes(Expression<Func<string>> token, Expression<Func<string>> envelopeDescriptorId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodysenderemail = null, Expression<Func<string>> bodysendergivenName = null, Expression<Func<string>> bodysenderfamilyName = null, Expression<Func<double>> bodyautomaticReminders = null, Expression<Func<string>> bodyexpiration = null, Expression<Func<bodydocumentsInputItem[]>> bodydocuments = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeDescriptorId = WorkflowExpression.Compile(envelopeDescriptorId, nameof(envelopeDescriptorId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodysenderemail = WorkflowExpression.Compile(bodysenderemail, nameof(bodysenderemail), required: false);
            var __workflow_bodysendergivenName = WorkflowExpression.Compile(bodysendergivenName, nameof(bodysendergivenName), required: false);
            var __workflow_bodysenderfamilyName = WorkflowExpression.Compile(bodysenderfamilyName, nameof(bodysenderfamilyName), required: false);
            var __workflow_bodyautomaticReminders = WorkflowExpression.Compile(bodyautomaticReminders, nameof(bodyautomaticReminders), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodydocuments = WorkflowExpression.Compile(bodydocuments, nameof(bodydocuments), required: false);
            return new DeferredBodyAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelope-descriptors/{0}/envelopes", __workflow_envelopeDescriptorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var senderObject = new JObject();
                var senderObjectpropCount = 0;
                if (__workflow_bodysenderemail != null)
                {
                    senderObject["email"] = ExpressionConverter.ConvertO(__workflow_bodysenderemail);
                    senderObjectpropCount++;
                }

                if (__workflow_bodysendergivenName != null)
                {
                    senderObject["givenName"] = ExpressionConverter.ConvertO(__workflow_bodysendergivenName);
                    senderObjectpropCount++;
                }

                if (__workflow_bodysenderfamilyName != null)
                {
                    senderObject["familyName"] = ExpressionConverter.ConvertO(__workflow_bodysenderfamilyName);
                    senderObjectpropCount++;
                }

                if (senderObjectpropCount > 0)
                {
                    body["sender"] = senderObject;
                    bodypropCount++;
                }

                if (__workflow_bodyautomaticReminders != null)
                {
                    body["automaticReminders"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticReminders);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                    bodypropCount++;
                }

                if (__workflow_bodydocuments != null)
                {
                    body["documents"] = ExpressionConverter.ConvertO(__workflow_bodydocuments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Document[]> GetEnvelopesEnvelopeIdDocuments(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Document[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<Document[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocuments(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> bodyname, Expression<Func<string>> xNamespace = null, Expression<Func<int>> bodydescriptorhash = null, Expression<Func<string>> bodysource = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodydescriptorhash = WorkflowExpression.Compile(bodydescriptorhash, nameof(bodydescriptorhash), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var descriptorObject = new JObject();
                var descriptorObjectpropCount = 0;
                if (__workflow_bodydescriptorhash != null)
                {
                    descriptorObject["hash"] = ExpressionConverter.ConvertO(__workflow_bodydescriptorhash);
                    descriptorObjectpropCount++;
                }

                if (descriptorObjectpropCount > 0)
                {
                    body["descriptor"] = descriptorObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse> PostEnvelopesEnvelopeIdJobsGetSignLink(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodyrecipientid = null, Expression<Func<string>> bodyredirectTo = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodyrecipientid = WorkflowExpression.Compile(bodyrecipientid, nameof(bodyrecipientid), required: false);
            var __workflow_bodyredirectTo = WorkflowExpression.Compile(bodyredirectTo, nameof(bodyredirectTo), required: false);
            return new DeferredBodyAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/jobs/get.sign.link", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var recipientObject = new JObject();
                var recipientObjectpropCount = 0;
                if (__workflow_bodyrecipientid != null)
                {
                    recipientObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientid);
                    recipientObjectpropCount++;
                }

                if (recipientObjectpropCount > 0)
                {
                    body["recipient"] = recipientObject;
                    bodypropCount++;
                }

                if (__workflow_bodyredirectTo != null)
                {
                    body["redirectTo"] = ExpressionConverter.ConvertO(__workflow_bodyredirectTo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopeDescriptorsDefaultEnvelopesResponse> PostEnvelopeDescriptorsDefaultEnvelopes(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodysenderemail = null, Expression<Func<string>> bodysendergivenName = null, Expression<Func<string>> bodysenderfamilyName = null, Expression<Func<double>> bodyautomaticReminders = null, Expression<Func<string>> bodyexpiration = null, Expression<Func<bodydocumentsInputItem[]>> bodydocuments = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodysenderemail = WorkflowExpression.Compile(bodysenderemail, nameof(bodysenderemail), required: false);
            var __workflow_bodysendergivenName = WorkflowExpression.Compile(bodysendergivenName, nameof(bodysendergivenName), required: false);
            var __workflow_bodysenderfamilyName = WorkflowExpression.Compile(bodysenderfamilyName, nameof(bodysenderfamilyName), required: false);
            var __workflow_bodyautomaticReminders = WorkflowExpression.Compile(bodyautomaticReminders, nameof(bodyautomaticReminders), required: false);
            var __workflow_bodyexpiration = WorkflowExpression.Compile(bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodydocuments = WorkflowExpression.Compile(bodydocuments, nameof(bodydocuments), required: false);
            return new DeferredBodyAction<PostEnvelopeDescriptorsDefaultEnvelopesResponse>(() =>
            {
                var apiCallPath = "/envelope-descriptors/default/envelopes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var senderObject = new JObject();
                var senderObjectpropCount = 0;
                if (__workflow_bodysenderemail != null)
                {
                    senderObject["email"] = ExpressionConverter.ConvertO(__workflow_bodysenderemail);
                    senderObjectpropCount++;
                }

                if (__workflow_bodysendergivenName != null)
                {
                    senderObject["givenName"] = ExpressionConverter.ConvertO(__workflow_bodysendergivenName);
                    senderObjectpropCount++;
                }

                if (__workflow_bodysenderfamilyName != null)
                {
                    senderObject["familyName"] = ExpressionConverter.ConvertO(__workflow_bodysenderfamilyName);
                    senderObjectpropCount++;
                }

                if (senderObjectpropCount > 0)
                {
                    body["sender"] = senderObject;
                    bodypropCount++;
                }

                if (__workflow_bodyautomaticReminders != null)
                {
                    body["automaticReminders"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticReminders);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(__workflow_bodyexpiration);
                    bodypropCount++;
                }

                if (__workflow_bodydocuments != null)
                {
                    body["documents"] = ExpressionConverter.ConvertO(__workflow_bodydocuments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostEnvelopeDescriptorsDefaultEnvelopesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Descriptor> GetEnvelopeDescriptorsDefault(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            return new DeferredBodyAction<Descriptor>(() =>
            {
                var apiCallPath = "/envelope-descriptors/default";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(__workflow_filters);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<Descriptor>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopIdJobsSendNotification(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodyenvelopegreeting = null, Expression<Func<string>> bodyrecipientid = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodyenvelopegreeting = WorkflowExpression.Compile(bodyenvelopegreeting, nameof(bodyenvelopegreeting), required: false);
            var __workflow_bodyrecipientid = WorkflowExpression.Compile(bodyrecipientid, nameof(bodyrecipientid), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/jobs/send.notification", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var envelopeObject = new JObject();
                var envelopeObjectpropCount = 0;
                if (__workflow_bodyenvelopegreeting != null)
                {
                    envelopeObject["greeting"] = ExpressionConverter.ConvertO(__workflow_bodyenvelopegreeting);
                    envelopeObjectpropCount++;
                }

                if (envelopeObjectpropCount > 0)
                {
                    body["envelope"] = envelopeObject;
                    bodypropCount++;
                }

                var recipientObject = new JObject();
                var recipientObjectpropCount = 0;
                if (__workflow_bodyrecipientid != null)
                {
                    recipientObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientid);
                    recipientObjectpropCount++;
                }

                if (recipientObjectpropCount > 0)
                {
                    body["recipient"] = recipientObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class VerifiedTriggers([ConnectionName] string connectionId)
    {
    }

    public class PostAuthenticateResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class Company
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("regNumber")]
        public string RegNumber { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Recipient
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("role")]
        public RoleActionString Role { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("signingMethod")]
        public string SigningMethod { get; set; }

        [JsonProperty("notificationMethod")]
        public string NotificationMethod { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("notified")]
        public bool Notified { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("demandAttachment")]
        public bool DemandAttachment { get; set; }

        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("secure")]
        public bool Secure { get; set; }

        [JsonProperty("sms")]
        public bool Sms { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("signatures")]
        public JToken Signatures { get; set; }

        [JsonProperty("notifications")]
        public Notification[] Notifications { get; set; }
    }

    public class RoleActionString
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("numMax")]
        public int NumMax { get; set; }

        [JsonProperty("numMin")]
        public int NumMin { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }
    }

    public class Notification
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("details")]
        public JToken Details { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylanguageInput
    {
        [EnumMember(Value = "nb-NO")]
        NbNO,
        [EnumMember(Value = "sv-SE")]
        SvSE,
        [EnumMember(Value = "da-DK")]
        DaDK,
        [EnumMember(Value = "fi-FI")]
        FiFI,
        [EnumMember(Value = "lt-LT")]
        LtLT,
        [EnumMember(Value = "lv-LV")]
        LvLV
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysigningMethodInput
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "bankid-no")]
        BankidNo,
        [EnumMember(Value = "bankid-se")]
        BankidSe,
        [EnumMember(Value = "bankid-dk")]
        BankidDk,
        [EnumMember(Value = "nets-esign-no")]
        NetsEsignNo,
        [EnumMember(Value = "nets-esign-se")]
        NetsEsignSe,
        [EnumMember(Value = "nets-esign-dk")]
        NetsEsignDk,
        [EnumMember(Value = "nets-esign-tupas")]
        NetsEsignTupas,
        [EnumMember(Value = "nets-eident-mobiilivarmenne")]
        NetsEidentMobiilivarmenne,
        [EnumMember(Value = "nets-eident-fi")]
        NetsEidentFi,
        [EnumMember(Value = "nets-eident-dk")]
        NetsEidentDk,
        [EnumMember(Value = "eideasy-ee-ideideasy-lv-id")]
        EideasyEeIdeideasyLvId,
        [EnumMember(Value = "eideasy-lt-id")]
        EideasyLtId,
        [EnumMember(Value = "touch-sign")]
        TouchSign
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodynotificationMethodInput
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "sms")]
        Sms
    }

    public class GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Setting
    {
        [JsonProperty("global")]
        public string Global { get; set; }

        [JsonProperty("preferences")]
        public SettingPreferencesType Preferences { get; set; }
    }

    public class SettingPreferencesType
    {
        [JsonProperty("signatoryLanguage")]
        public string SignatoryLanguage { get; set; }

        [JsonProperty("greeting")]
        public string Greeting { get; set; }

        [JsonProperty("signingMethod")]
        public string SigningMethod { get; set; }

        [JsonProperty("reminderOffset")]
        public string ReminderOffset { get; set; }
    }

    public class Envelope
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("aborted")]
        public bool Aborted { get; set; }

        [JsonProperty("trashed")]
        public bool Trashed { get; set; }

        [JsonProperty("sequentialSigning")]
        public bool SequentialSigning { get; set; }

        [JsonProperty("automaticReminders")]
        public int AutomaticReminders { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("flow")]
        public Flow Flow { get; set; }

        [JsonProperty("descriptor")]
        public Descriptor Descriptor { get; set; }

        [JsonProperty("sender")]
        public Person Sender { get; set; }

        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        [JsonProperty("recipients")]
        public Recipient[] Recipients { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("owners")]
        public Person[] Owners { get; set; }
    }

    public class Flow
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Descriptor
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mandatory")]
        public bool Mandatory { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("roles")]
        public Role[] Roles { get; set; }

        [JsonProperty("owners")]
        public Person[] Owners { get; set; }

        [JsonProperty("flow")]
        public Flow Flow { get; set; }

        [JsonProperty("defaultValues")]
        public DefaultValues DefaultValues { get; set; }

        [JsonProperty("instances")]
        public JToken[] Instances { get; set; }
    }

    public class Role
    {
        [JsonProperty("action")]
        public RoleActionType Action { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("numMax")]
        public int NumMax { get; set; }

        [JsonProperty("numMin")]
        public int NumMin { get; set; }

        [JsonProperty("roleName")]
        public string RoleName { get; set; }
    }

    public class RoleActionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("methods")]
        public string[] Methods { get; set; }
    }

    public class Person
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class DefaultValues
    {
        [JsonProperty("signer")]
        public Person Signer { get; set; }

        [JsonProperty("reviewer")]
        public Person Reviewer { get; set; }
    }

    public class Document
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("hash")]
        public int Hash { get; set; }

        [JsonProperty("numMax")]
        public int NumMax { get; set; }

        [JsonProperty("numMin")]
        public int NumMin { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("rejected")]
        public bool Rejected { get; set; }

        [JsonProperty("signed")]
        public bool Signed { get; set; }

        [JsonProperty("trashed")]
        public bool Trashed { get; set; }

        [JsonProperty("aborted")]
        public bool Aborted { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("attachments")]
        public Attachment[] Attachments { get; set; }

        [JsonProperty("flow")]
        public Flow Flow { get; set; }

        [JsonProperty("roles")]
        public Role[] Roles { get; set; }

        [JsonProperty("template")]
        public Template Template { get; set; }

        [JsonProperty("descriptor")]
        public Descriptor Descriptor { get; set; }

        [JsonProperty("signatures")]
        public Signature[] Signatures { get; set; }
    }

    public class Attachment
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("numMax")]
        public int NumMax { get; set; }

        [JsonProperty("numMin")]
        public int NumMin { get; set; }

        [JsonProperty("hash")]
        public int Hash { get; set; }
    }

    public class Template
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("pdfHtml")]
        public string PdfHtml { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("aborted")]
        public bool Aborted { get; set; }
    }

    public class Signature
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class File
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("fileType")]
        public string FileType { get; set; }

        [JsonProperty("storagePath")]
        public string StoragePath { get; set; }

        [JsonProperty("uploadedAt")]
        public string UploadedAt { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("owners")]
        public FileOwnersTypeItem[] Owners { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class FileOwnersTypeItem
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }
    }

    public class UserInfo
    {
        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("metadata")]
        public UserInfoMetadataType Metadata { get; set; }

        [JsonProperty("missingPassword")]
        public bool MissingPassword { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("roles")]
        public Role[] Roles { get; set; }

        [JsonProperty("validated")]
        public bool Validated { get; set; }
    }

    public class UserInfoMetadataType
    {
        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class EnvelopeDescriptorString
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("aborted")]
        public bool Aborted { get; set; }

        [JsonProperty("trashed")]
        public bool Trashed { get; set; }

        [JsonProperty("sequentialSigning")]
        public bool SequentialSigning { get; set; }

        [JsonProperty("automaticReminders")]
        public int AutomaticReminders { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }

        [JsonProperty("flow")]
        public Flow Flow { get; set; }

        [JsonProperty("descriptor")]
        public string Descriptor { get; set; }

        [JsonProperty("sender")]
        public Person Sender { get; set; }

        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        [JsonProperty("recipients")]
        public Recipient[] Recipients { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("owners")]
        public Person[] Owners { get; set; }
    }

    public class GetFlowsFlowIdJobsEnvelopeIdResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class bodydocumentsInputItem
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class PostEnvelopesEnvelopeIdJobsGetSignLinkResponse
    {
        [JsonProperty("getSignLink")]
        public PostEnvelopesEnvelopeIdJobsGetSignLinkResponseGetSignLinkType GetSignLink { get; set; }
    }

    public class PostEnvelopesEnvelopeIdJobsGetSignLinkResponseGetSignLinkType
    {
        [JsonProperty("recipient")]
        public PostEnvelopesEnvelopeIdJobsGetSignLinkResponseGetSignLinkTypeRecipientType Recipient { get; set; }
    }

    public class PostEnvelopesEnvelopeIdJobsGetSignLinkResponseGetSignLinkTypeRecipientType
    {
        [JsonProperty("{recipient-id}")]
        public PostEnvelopesEnvelopeIdJobsGetSignLinkResponseGetSignLinkTypeRecipientTypeRecipientIdType RecipientId { get; set; }
    }

    public class PostEnvelopesEnvelopeIdJobsGetSignLinkResponseGetSignLinkTypeRecipientTypeRecipientIdType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PostEnvelopeDescriptorsDefaultEnvelopesResponse
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Verified;

    public partial class WorkflowManagedActions
    {
        public VerifiedActions Verified(string connectionId) => new VerifiedActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VerifiedTriggers Verified(string connectionId) => new VerifiedTriggers(connectionId);
    }
}
