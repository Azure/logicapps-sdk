//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Verified
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class VerifiedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostAuthenticateResponse> PostAuthenticate(Expression<Func<int>> withoutIpLock)
        {
            var __workflow_withoutIpLock = withoutIpLock == null ? null : WorkflowExpression.Compile(withoutIpLock);
            WorkflowExpression.Validate(__workflow_withoutIpLock, nameof(withoutIpLock), required: true);
            return new DeferredBodyAction<PostAuthenticateResponse>(() =>
            {
                var apiCallPath = "/auth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["withoutIpLock"] = ExpressionConverter.Convert(__workflow_withoutIpLock);
                return new ApiConnectionAction<PostAuthenticateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Company> GetCompaniesCompanyId(Expression<Func<string>> token, Expression<Func<string>> companyId)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_companyId = companyId == null ? null : WorkflowExpression.Compile(companyId);
            WorkflowExpression.Validate(__workflow_companyId, nameof(companyId), required: true);
            return new DeferredBodyAction<Company>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_companyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Company>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Recipient[]> GetEnvelopesEnvelopeIdRecipients(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Recipient[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<Recipient[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdRecipients(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> bodygivenName, Expression<Func<string>> bodyfamilyName, Expression<Func<bodylanguageInput>> bodylanguage, Expression<Func<bodysigningMethodInput>> bodysigningMethod, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyroleaction, Expression<Func<string>> bodyrolelabel, Expression<Func<string>> bodyrolename, Expression<Func<string>> xNamespace = null, Expression<Func<bodynotificationMethodInput>> bodynotificationMethod = null, Expression<Func<string>> bodytelephone = null, Expression<Func<int>> bodyorder = null, Expression<Func<bool>> bodysecure = null, Expression<Func<bool>> bodysms = null, Expression<Func<string>> bodyssn = null, Expression<Func<string>> bodybank = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_bodygivenName = bodygivenName == null ? null : WorkflowExpression.Compile(bodygivenName);
            WorkflowExpression.Validate(__workflow_bodygivenName, nameof(bodygivenName), required: true);
            var __workflow_bodyfamilyName = bodyfamilyName == null ? null : WorkflowExpression.Compile(bodyfamilyName);
            WorkflowExpression.Validate(__workflow_bodyfamilyName, nameof(bodyfamilyName), required: true);
            var __workflow_bodylanguage = bodylanguage == null ? null : WorkflowExpression.Compile(bodylanguage);
            WorkflowExpression.Validate(__workflow_bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodysigningMethod = bodysigningMethod == null ? null : WorkflowExpression.Compile(bodysigningMethod);
            WorkflowExpression.Validate(__workflow_bodysigningMethod, nameof(bodysigningMethod), required: true);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyroleaction = bodyroleaction == null ? null : WorkflowExpression.Compile(bodyroleaction);
            WorkflowExpression.Validate(__workflow_bodyroleaction, nameof(bodyroleaction), required: true);
            var __workflow_bodyrolelabel = bodyrolelabel == null ? null : WorkflowExpression.Compile(bodyrolelabel);
            WorkflowExpression.Validate(__workflow_bodyrolelabel, nameof(bodyrolelabel), required: true);
            var __workflow_bodyrolename = bodyrolename == null ? null : WorkflowExpression.Compile(bodyrolename);
            WorkflowExpression.Validate(__workflow_bodyrolename, nameof(bodyrolename), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodynotificationMethod = bodynotificationMethod == null ? null : WorkflowExpression.Compile(bodynotificationMethod);
            WorkflowExpression.Validate(__workflow_bodynotificationMethod, nameof(bodynotificationMethod), required: false);
            var __workflow_bodytelephone = bodytelephone == null ? null : WorkflowExpression.Compile(bodytelephone);
            WorkflowExpression.Validate(__workflow_bodytelephone, nameof(bodytelephone), required: false);
            var __workflow_bodyorder = bodyorder == null ? null : WorkflowExpression.Compile(bodyorder);
            WorkflowExpression.Validate(__workflow_bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodysecure = bodysecure == null ? null : WorkflowExpression.Compile(bodysecure);
            WorkflowExpression.Validate(__workflow_bodysecure, nameof(bodysecure), required: false);
            var __workflow_bodysms = bodysms == null ? null : WorkflowExpression.Compile(bodysms);
            WorkflowExpression.Validate(__workflow_bodysms, nameof(bodysms), required: false);
            var __workflow_bodyssn = bodyssn == null ? null : WorkflowExpression.Compile(bodyssn);
            WorkflowExpression.Validate(__workflow_bodyssn, nameof(bodyssn), required: false);
            var __workflow_bodybank = bodybank == null ? null : WorkflowExpression.Compile(bodybank);
            WorkflowExpression.Validate(__workflow_bodybank, nameof(bodybank), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Recipient> GetEnvelopesEnvelopeIdRecipientsRecipientId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientId = recipientId == null ? null : WorkflowExpression.Compile(recipientId);
            WorkflowExpression.Validate(__workflow_recipientId, nameof(recipientId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Recipient>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<Recipient>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdRecipientsRecipientId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> bodygivenName, Expression<Func<string>> bodyfamilyName, Expression<Func<bodylanguageInput>> bodylanguage, Expression<Func<bodysigningMethodInput>> bodysigningMethod, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyroleaction, Expression<Func<string>> bodyrolelabel, Expression<Func<string>> bodyrolename, Expression<Func<string>> xNamespace = null, Expression<Func<bodynotificationMethodInput>> bodynotificationMethod = null, Expression<Func<string>> bodytelephone = null, Expression<Func<int>> bodyorder = null, Expression<Func<bool>> bodysecure = null, Expression<Func<bool>> bodysms = null, Expression<Func<string>> bodyssn = null, Expression<Func<string>> bodybank = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientId = recipientId == null ? null : WorkflowExpression.Compile(recipientId);
            WorkflowExpression.Validate(__workflow_recipientId, nameof(recipientId), required: true);
            var __workflow_bodygivenName = bodygivenName == null ? null : WorkflowExpression.Compile(bodygivenName);
            WorkflowExpression.Validate(__workflow_bodygivenName, nameof(bodygivenName), required: true);
            var __workflow_bodyfamilyName = bodyfamilyName == null ? null : WorkflowExpression.Compile(bodyfamilyName);
            WorkflowExpression.Validate(__workflow_bodyfamilyName, nameof(bodyfamilyName), required: true);
            var __workflow_bodylanguage = bodylanguage == null ? null : WorkflowExpression.Compile(bodylanguage);
            WorkflowExpression.Validate(__workflow_bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodysigningMethod = bodysigningMethod == null ? null : WorkflowExpression.Compile(bodysigningMethod);
            WorkflowExpression.Validate(__workflow_bodysigningMethod, nameof(bodysigningMethod), required: true);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyroleaction = bodyroleaction == null ? null : WorkflowExpression.Compile(bodyroleaction);
            WorkflowExpression.Validate(__workflow_bodyroleaction, nameof(bodyroleaction), required: true);
            var __workflow_bodyrolelabel = bodyrolelabel == null ? null : WorkflowExpression.Compile(bodyrolelabel);
            WorkflowExpression.Validate(__workflow_bodyrolelabel, nameof(bodyrolelabel), required: true);
            var __workflow_bodyrolename = bodyrolename == null ? null : WorkflowExpression.Compile(bodyrolename);
            WorkflowExpression.Validate(__workflow_bodyrolename, nameof(bodyrolename), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodynotificationMethod = bodynotificationMethod == null ? null : WorkflowExpression.Compile(bodynotificationMethod);
            WorkflowExpression.Validate(__workflow_bodynotificationMethod, nameof(bodynotificationMethod), required: false);
            var __workflow_bodytelephone = bodytelephone == null ? null : WorkflowExpression.Compile(bodytelephone);
            WorkflowExpression.Validate(__workflow_bodytelephone, nameof(bodytelephone), required: false);
            var __workflow_bodyorder = bodyorder == null ? null : WorkflowExpression.Compile(bodyorder);
            WorkflowExpression.Validate(__workflow_bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodysecure = bodysecure == null ? null : WorkflowExpression.Compile(bodysecure);
            WorkflowExpression.Validate(__workflow_bodysecure, nameof(bodysecure), required: false);
            var __workflow_bodysms = bodysms == null ? null : WorkflowExpression.Compile(bodysms);
            WorkflowExpression.Validate(__workflow_bodysms, nameof(bodysms), required: false);
            var __workflow_bodyssn = bodyssn == null ? null : WorkflowExpression.Compile(bodyssn);
            WorkflowExpression.Validate(__workflow_bodyssn, nameof(bodyssn), required: false);
            var __workflow_bodybank = bodybank == null ? null : WorkflowExpression.Compile(bodybank);
            WorkflowExpression.Validate(__workflow_bodybank, nameof(bodybank), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recipientId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse> GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrl(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> fileId, Expression<Func<string>> xNamespace = null, Expression<Func<bool>> asObject = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_asObject = asObject == null ? null : WorkflowExpression.Compile(asObject);
            WorkflowExpression.Validate(__workflow_asObject, nameof(asObject), required: false);
            return new DeferredBodyAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/files/{2}/url", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_asObject != null)
                    callPayload.Queries["asObject"] = ExpressionConverter.Convert(__workflow_asObject);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Setting> GetCompaniesCompanyIdUsersUserIdSettings(Expression<Func<string>> token, Expression<Func<string>> companyId, Expression<Func<string>> userId)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_companyId = companyId == null ? null : WorkflowExpression.Compile(companyId);
            WorkflowExpression.Validate(__workflow_companyId, nameof(companyId), required: true);
            var __workflow_userId = userId == null ? null : WorkflowExpression.Compile(userId);
            WorkflowExpression.Validate(__workflow_userId, nameof(userId), required: true);
            return new DeferredBodyAction<Setting>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/companies/{0}/users/{1}/settings", ExpressionConverter.ConvertWithUrlEncoding(__workflow_companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Setting>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Envelope> GetEnvelopesEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Envelope>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<Envelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction DeleteEnvelopesEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<bool>> bodysequentialSigning = null, Expression<Func<string>> bodygreeting = null, Expression<Func<string>> bodyexpiration = null, Expression<Func<double>> bodyautomaticReminders = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodysequentialSigning = bodysequentialSigning == null ? null : WorkflowExpression.Compile(bodysequentialSigning);
            WorkflowExpression.Validate(__workflow_bodysequentialSigning, nameof(bodysequentialSigning), required: false);
            var __workflow_bodygreeting = bodygreeting == null ? null : WorkflowExpression.Compile(bodygreeting);
            WorkflowExpression.Validate(__workflow_bodygreeting, nameof(bodygreeting), required: false);
            var __workflow_bodyexpiration = bodyexpiration == null ? null : WorkflowExpression.Compile(bodyexpiration);
            WorkflowExpression.Validate(__workflow_bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodyautomaticReminders = bodyautomaticReminders == null ? null : WorkflowExpression.Compile(bodyautomaticReminders);
            WorkflowExpression.Validate(__workflow_bodyautomaticReminders, nameof(bodyautomaticReminders), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdPublishStatus(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<bool>> bodypublished, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_bodypublished = bodypublished == null ? null : WorkflowExpression.Compile(bodypublished);
            WorkflowExpression.Validate(__workflow_bodypublished, nameof(bodypublished), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/publish-status", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocumentsDocumentIdTemplatesTemplateIdUserData(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> templateId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_templateId = templateId == null ? null : WorkflowExpression.Compile(templateId);
            WorkflowExpression.Validate(__workflow_templateId, nameof(templateId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/templates/{2}/user-data", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_templateId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdAbortStatus(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodycomment = bodycomment == null ? null : WorkflowExpression.Compile(bodycomment);
            WorkflowExpression.Validate(__workflow_bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/abort-status", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<File[]> GetEnvelopesEnvelopeIdDocumentsDocumentIdFiles(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<File[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/files", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<File[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<File> PostEnvelopesEnvelopeIdDocumentsDocumentIdFiles(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyfileType, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodyhash = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodyfileType = bodyfileType == null ? null : WorkflowExpression.Compile(bodyfileType);
            WorkflowExpression.Validate(__workflow_bodyfileType, nameof(bodyfileType), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodyhash = bodyhash == null ? null : WorkflowExpression.Compile(bodyhash);
            WorkflowExpression.Validate(__workflow_bodyhash, nameof(bodyhash), required: false);
            return new DeferredBodyAction<File>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/files", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<UserInfo> GetAuthUserinfo(Expression<Func<string>> token)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            return new DeferredBodyAction<UserInfo>(() =>
            {
                var apiCallPath = "/auth/userinfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<UserInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocumentsDocumentIdStatusAborted(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/status/aborted", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdTrashStatus(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodycomment = bodycomment == null ? null : WorkflowExpression.Compile(bodycomment);
            WorkflowExpression.Validate(__workflow_bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/trash-status", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<EnvelopeDescriptorString[]> GetQueryEnvelopes(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null, Expression<Func<int>> from = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_filters = filters == null ? null : WorkflowExpression.Compile(filters);
            WorkflowExpression.Validate(__workflow_filters, nameof(filters), required: false);
            var __workflow_from = from == null ? null : WorkflowExpression.Compile(from);
            WorkflowExpression.Validate(__workflow_from, nameof(from), required: false);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<EnvelopeDescriptorString[]> GetSearchEnvelopes(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null, Expression<Func<int>> from = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_filters = filters == null ? null : WorkflowExpression.Compile(filters);
            WorkflowExpression.Validate(__workflow_filters, nameof(filters), required: false);
            var __workflow_from = from == null ? null : WorkflowExpression.Compile(from);
            WorkflowExpression.Validate(__workflow_from, nameof(from), required: false);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_sort = sort == null ? null : WorkflowExpression.Compile(sort);
            WorkflowExpression.Validate(__workflow_sort, nameof(sort), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Descriptor[]> GetEnvelopeDescriptors(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_filters = filters == null ? null : WorkflowExpression.Compile(filters);
            WorkflowExpression.Validate(__workflow_filters, nameof(filters), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<GetFlowsFlowIdJobsEnvelopeIdResponse> GetFlowsFlowIdJobsEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> flowId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_flowId = flowId == null ? null : WorkflowExpression.Compile(flowId);
            WorkflowExpression.Validate(__workflow_flowId, nameof(flowId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<GetFlowsFlowIdJobsEnvelopeIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/flows/{0}/jobs/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_flowId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<GetFlowsFlowIdJobsEnvelopeIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Document> GetEnvelopesEnvelopeIdDocumentsDocumentId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Document>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<Document>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction DeleteEnvelopesEnvelopeIdDocumentsDocumentId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = documentId == null ? null : WorkflowExpression.Compile(documentId);
            WorkflowExpression.Validate(__workflow_documentId, nameof(documentId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse> PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopes(Expression<Func<string>> token, Expression<Func<string>> envelopeDescriptorId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodysenderemail = null, Expression<Func<string>> bodysendergivenName = null, Expression<Func<string>> bodysenderfamilyName = null, Expression<Func<double>> bodyautomaticReminders = null, Expression<Func<string>> bodyexpiration = null, Expression<Func<bodydocumentsInputItem[]>> bodydocuments = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeDescriptorId = envelopeDescriptorId == null ? null : WorkflowExpression.Compile(envelopeDescriptorId);
            WorkflowExpression.Validate(__workflow_envelopeDescriptorId, nameof(envelopeDescriptorId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodysenderemail = bodysenderemail == null ? null : WorkflowExpression.Compile(bodysenderemail);
            WorkflowExpression.Validate(__workflow_bodysenderemail, nameof(bodysenderemail), required: false);
            var __workflow_bodysendergivenName = bodysendergivenName == null ? null : WorkflowExpression.Compile(bodysendergivenName);
            WorkflowExpression.Validate(__workflow_bodysendergivenName, nameof(bodysendergivenName), required: false);
            var __workflow_bodysenderfamilyName = bodysenderfamilyName == null ? null : WorkflowExpression.Compile(bodysenderfamilyName);
            WorkflowExpression.Validate(__workflow_bodysenderfamilyName, nameof(bodysenderfamilyName), required: false);
            var __workflow_bodyautomaticReminders = bodyautomaticReminders == null ? null : WorkflowExpression.Compile(bodyautomaticReminders);
            WorkflowExpression.Validate(__workflow_bodyautomaticReminders, nameof(bodyautomaticReminders), required: false);
            var __workflow_bodyexpiration = bodyexpiration == null ? null : WorkflowExpression.Compile(bodyexpiration);
            WorkflowExpression.Validate(__workflow_bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodydocuments = bodydocuments == null ? null : WorkflowExpression.Compile(bodydocuments);
            WorkflowExpression.Validate(__workflow_bodydocuments, nameof(bodydocuments), required: false);
            return new DeferredBodyAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelope-descriptors/{0}/envelopes", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeDescriptorId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Document[]> GetEnvelopesEnvelopeIdDocuments(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Document[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                return new ApiConnectionAction<Document[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocuments(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> bodyname, Expression<Func<string>> xNamespace = null, Expression<Func<int>> bodydescriptorhash = null, Expression<Func<string>> bodysource = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodydescriptorhash = bodydescriptorhash == null ? null : WorkflowExpression.Compile(bodydescriptorhash);
            WorkflowExpression.Validate(__workflow_bodydescriptorhash, nameof(bodydescriptorhash), required: false);
            var __workflow_bodysource = bodysource == null ? null : WorkflowExpression.Compile(bodysource);
            WorkflowExpression.Validate(__workflow_bodysource, nameof(bodysource), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse> PostEnvelopesEnvelopeIdJobsGetSignLink(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodyrecipientid = null, Expression<Func<string>> bodyredirectTo = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodyrecipientid = bodyrecipientid == null ? null : WorkflowExpression.Compile(bodyrecipientid);
            WorkflowExpression.Validate(__workflow_bodyrecipientid, nameof(bodyrecipientid), required: false);
            var __workflow_bodyredirectTo = bodyredirectTo == null ? null : WorkflowExpression.Compile(bodyredirectTo);
            WorkflowExpression.Validate(__workflow_bodyredirectTo, nameof(bodyredirectTo), required: false);
            return new DeferredBodyAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/jobs/get.sign.link", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopeDescriptorsDefaultEnvelopesResponse> PostEnvelopeDescriptorsDefaultEnvelopes(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodysenderemail = null, Expression<Func<string>> bodysendergivenName = null, Expression<Func<string>> bodysenderfamilyName = null, Expression<Func<double>> bodyautomaticReminders = null, Expression<Func<string>> bodyexpiration = null, Expression<Func<bodydocumentsInputItem[]>> bodydocuments = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodysenderemail = bodysenderemail == null ? null : WorkflowExpression.Compile(bodysenderemail);
            WorkflowExpression.Validate(__workflow_bodysenderemail, nameof(bodysenderemail), required: false);
            var __workflow_bodysendergivenName = bodysendergivenName == null ? null : WorkflowExpression.Compile(bodysendergivenName);
            WorkflowExpression.Validate(__workflow_bodysendergivenName, nameof(bodysendergivenName), required: false);
            var __workflow_bodysenderfamilyName = bodysenderfamilyName == null ? null : WorkflowExpression.Compile(bodysenderfamilyName);
            WorkflowExpression.Validate(__workflow_bodysenderfamilyName, nameof(bodysenderfamilyName), required: false);
            var __workflow_bodyautomaticReminders = bodyautomaticReminders == null ? null : WorkflowExpression.Compile(bodyautomaticReminders);
            WorkflowExpression.Validate(__workflow_bodyautomaticReminders, nameof(bodyautomaticReminders), required: false);
            var __workflow_bodyexpiration = bodyexpiration == null ? null : WorkflowExpression.Compile(bodyexpiration);
            WorkflowExpression.Validate(__workflow_bodyexpiration, nameof(bodyexpiration), required: false);
            var __workflow_bodydocuments = bodydocuments == null ? null : WorkflowExpression.Compile(bodydocuments);
            WorkflowExpression.Validate(__workflow_bodydocuments, nameof(bodydocuments), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Descriptor> GetEnvelopeDescriptorsDefault(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_filters = filters == null ? null : WorkflowExpression.Compile(filters);
            WorkflowExpression.Validate(__workflow_filters, nameof(filters), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopIdJobsSendNotification(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodyenvelopegreeting = null, Expression<Func<string>> bodyrecipientid = null)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            var __workflow_envelopeId = envelopeId == null ? null : WorkflowExpression.Compile(envelopeId);
            WorkflowExpression.Validate(__workflow_envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = xNamespace == null ? null : WorkflowExpression.Compile(xNamespace);
            WorkflowExpression.Validate(__workflow_xNamespace, nameof(xNamespace), required: false);
            var __workflow_bodyenvelopegreeting = bodyenvelopegreeting == null ? null : WorkflowExpression.Compile(bodyenvelopegreeting);
            WorkflowExpression.Validate(__workflow_bodyenvelopegreeting, nameof(bodyenvelopegreeting), required: false);
            var __workflow_bodyrecipientid = bodyrecipientid == null ? null : WorkflowExpression.Compile(bodyrecipientid);
            WorkflowExpression.Validate(__workflow_bodyrecipientid, nameof(bodyrecipientid), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/jobs/send.notification", ExpressionConverter.ConvertWithUrlEncoding(__workflow_envelopeId, 1));
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
            });
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
