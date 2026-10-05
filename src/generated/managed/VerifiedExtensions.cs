//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Verified
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VerifiedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildPostAuthenticate))]
        public IBodyWorkflowAction<PostAuthenticateResponse> PostAuthenticate([WorkflowExpression] Func<int> withoutIpLock)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostAuthenticateResponse> __BuildPostAuthenticate(WorkflowValue<int> withoutIpLock)
        {
            WorkflowValue.Validate(withoutIpLock, nameof(withoutIpLock), required: true);
            return new DeferredBodyAction<PostAuthenticateResponse>(() =>
            {
                var apiCallPath = "/auth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["withoutIpLock"] = ExpressionConverter.Convert(withoutIpLock);
                return new ApiConnectionAction<PostAuthenticateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildGetCompaniesCompanyId))]
        public IBodyWorkflowAction<Company> GetCompaniesCompanyId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> companyId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Company> __BuildGetCompaniesCompanyId(WorkflowValue<string> token, WorkflowValue<string> companyId)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(companyId, nameof(companyId), required: true);
            return new DeferredBodyAction<Company>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Company>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildGetEnvelopesEnvelopeIdRecipients))]
        public IBodyWorkflowAction<Recipient[]> GetEnvelopesEnvelopeIdRecipients([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Recipient[]> __BuildGetEnvelopesEnvelopeIdRecipients(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> xNamespace = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Recipient[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction<Recipient[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildPostEnvelopesEnvelopeIdRecipients))]
        public IWorkflowAction PostEnvelopesEnvelopeIdRecipients([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> bodygivenName, [WorkflowExpression] Func<string> bodyfamilyName, [WorkflowExpression] Func<bodylanguageInput> bodylanguage, [WorkflowExpression] Func<bodysigningMethodInput> bodysigningMethod, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyroleaction, [WorkflowExpression] Func<string> bodyrolelabel, [WorkflowExpression] Func<string> bodyrolename, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<bodynotificationMethodInput> bodynotificationMethod = null, [WorkflowExpression] Func<string> bodytelephone = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<bool> bodysecure = null, [WorkflowExpression] Func<bool> bodysms = null, [WorkflowExpression] Func<string> bodyssn = null, [WorkflowExpression] Func<string> bodybank = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostEnvelopesEnvelopeIdRecipients(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> bodygivenName, WorkflowValue<string> bodyfamilyName, WorkflowValue<bodylanguageInput> bodylanguage, WorkflowValue<bodysigningMethodInput> bodysigningMethod, WorkflowValue<string> bodyemail, WorkflowValue<string> bodyroleaction, WorkflowValue<string> bodyrolelabel, WorkflowValue<string> bodyrolename, WorkflowValue<string> xNamespace = null, WorkflowValue<bodynotificationMethodInput> bodynotificationMethod = null, WorkflowValue<string> bodytelephone = null, WorkflowValue<int> bodyorder = null, WorkflowValue<bool> bodysecure = null, WorkflowValue<bool> bodysms = null, WorkflowValue<string> bodyssn = null, WorkflowValue<string> bodybank = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(bodygivenName, nameof(bodygivenName), required: true);
            WorkflowValue.Validate(bodyfamilyName, nameof(bodyfamilyName), required: true);
            WorkflowValue.Validate(bodylanguage, nameof(bodylanguage), required: true);
            WorkflowValue.Validate(bodysigningMethod, nameof(bodysigningMethod), required: true);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowValue.Validate(bodyroleaction, nameof(bodyroleaction), required: true);
            WorkflowValue.Validate(bodyrolelabel, nameof(bodyrolelabel), required: true);
            WorkflowValue.Validate(bodyrolename, nameof(bodyrolename), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(bodynotificationMethod, nameof(bodynotificationMethod), required: false);
            WorkflowValue.Validate(bodytelephone, nameof(bodytelephone), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodysecure, nameof(bodysecure), required: false);
            WorkflowValue.Validate(bodysms, nameof(bodysms), required: false);
            WorkflowValue.Validate(bodyssn, nameof(bodyssn), required: false);
            WorkflowValue.Validate(bodybank, nameof(bodybank), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["givenName"] = ExpressionConverter.ConvertO(bodygivenName);
                bodypropCount++;
                body["familyName"] = ExpressionConverter.ConvertO(bodyfamilyName);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
                body["signingMethod"] = ExpressionConverter.ConvertO(bodysigningMethod);
                if (bodynotificationMethod != null)
                {
                    body["notificationMethod"] = ExpressionConverter.ConvertO(bodynotificationMethod);
                    bodypropCount++;
                }

                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodytelephone != null)
                {
                    body["telephone"] = ExpressionConverter.ConvertO(bodytelephone);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(bodyorder);
                    bodypropCount++;
                }

                var roleObject = new JObject();
                var roleObjectpropCount = 0;
                roleObjectpropCount++;
                roleObject["action"] = ExpressionConverter.ConvertO(bodyroleaction);
                roleObjectpropCount++;
                roleObject["label"] = ExpressionConverter.ConvertO(bodyrolelabel);
                roleObjectpropCount++;
                roleObject["name"] = ExpressionConverter.ConvertO(bodyrolename);
                if (roleObjectpropCount > 0)
                {
                    body["role"] = roleObject;
                    bodypropCount++;
                }

                if (bodysecure != null)
                {
                    body["secure"] = ExpressionConverter.ConvertO(bodysecure);
                    bodypropCount++;
                }

                if (bodysms != null)
                {
                    body["sms"] = ExpressionConverter.ConvertO(bodysms);
                    bodypropCount++;
                }

                if (bodyssn != null)
                {
                    body["ssn"] = ExpressionConverter.ConvertO(bodyssn);
                    bodypropCount++;
                }

                if (bodybank != null)
                {
                    body["bank"] = ExpressionConverter.ConvertO(bodybank);
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
        [WorkflowExpressionFactory(nameof(__BuildGetEnvelopesEnvelopeIdRecipientsRecipientId))]
        public IBodyWorkflowAction<Recipient> GetEnvelopesEnvelopeIdRecipientsRecipientId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Recipient> __BuildGetEnvelopesEnvelopeIdRecipientsRecipientId(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> recipientId, WorkflowValue<string> xNamespace = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(recipientId, nameof(recipientId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Recipient>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients/{1}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction<Recipient>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildPutEnvelopesEnvelopeIdRecipientsRecipientId))]
        public IWorkflowAction PutEnvelopesEnvelopeIdRecipientsRecipientId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> bodygivenName, [WorkflowExpression] Func<string> bodyfamilyName, [WorkflowExpression] Func<bodylanguageInput> bodylanguage, [WorkflowExpression] Func<bodysigningMethodInput> bodysigningMethod, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyroleaction, [WorkflowExpression] Func<string> bodyrolelabel, [WorkflowExpression] Func<string> bodyrolename, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<bodynotificationMethodInput> bodynotificationMethod = null, [WorkflowExpression] Func<string> bodytelephone = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<bool> bodysecure = null, [WorkflowExpression] Func<bool> bodysms = null, [WorkflowExpression] Func<string> bodyssn = null, [WorkflowExpression] Func<string> bodybank = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPutEnvelopesEnvelopeIdRecipientsRecipientId(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> recipientId, WorkflowValue<string> bodygivenName, WorkflowValue<string> bodyfamilyName, WorkflowValue<bodylanguageInput> bodylanguage, WorkflowValue<bodysigningMethodInput> bodysigningMethod, WorkflowValue<string> bodyemail, WorkflowValue<string> bodyroleaction, WorkflowValue<string> bodyrolelabel, WorkflowValue<string> bodyrolename, WorkflowValue<string> xNamespace = null, WorkflowValue<bodynotificationMethodInput> bodynotificationMethod = null, WorkflowValue<string> bodytelephone = null, WorkflowValue<int> bodyorder = null, WorkflowValue<bool> bodysecure = null, WorkflowValue<bool> bodysms = null, WorkflowValue<string> bodyssn = null, WorkflowValue<string> bodybank = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(recipientId, nameof(recipientId), required: true);
            WorkflowValue.Validate(bodygivenName, nameof(bodygivenName), required: true);
            WorkflowValue.Validate(bodyfamilyName, nameof(bodyfamilyName), required: true);
            WorkflowValue.Validate(bodylanguage, nameof(bodylanguage), required: true);
            WorkflowValue.Validate(bodysigningMethod, nameof(bodysigningMethod), required: true);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowValue.Validate(bodyroleaction, nameof(bodyroleaction), required: true);
            WorkflowValue.Validate(bodyrolelabel, nameof(bodyrolelabel), required: true);
            WorkflowValue.Validate(bodyrolename, nameof(bodyrolename), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(bodynotificationMethod, nameof(bodynotificationMethod), required: false);
            WorkflowValue.Validate(bodytelephone, nameof(bodytelephone), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodysecure, nameof(bodysecure), required: false);
            WorkflowValue.Validate(bodysms, nameof(bodysms), required: false);
            WorkflowValue.Validate(bodyssn, nameof(bodyssn), required: false);
            WorkflowValue.Validate(bodybank, nameof(bodybank), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/recipients/{1}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["givenName"] = ExpressionConverter.ConvertO(bodygivenName);
                bodypropCount++;
                body["familyName"] = ExpressionConverter.ConvertO(bodyfamilyName);
                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
                body["signingMethod"] = ExpressionConverter.ConvertO(bodysigningMethod);
                if (bodynotificationMethod != null)
                {
                    body["notificationMethod"] = ExpressionConverter.ConvertO(bodynotificationMethod);
                    bodypropCount++;
                }

                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodytelephone != null)
                {
                    body["telephone"] = ExpressionConverter.ConvertO(bodytelephone);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(bodyorder);
                    bodypropCount++;
                }

                var roleObject = new JObject();
                var roleObjectpropCount = 0;
                roleObjectpropCount++;
                roleObject["action"] = ExpressionConverter.ConvertO(bodyroleaction);
                roleObjectpropCount++;
                roleObject["label"] = ExpressionConverter.ConvertO(bodyrolelabel);
                roleObjectpropCount++;
                roleObject["name"] = ExpressionConverter.ConvertO(bodyrolename);
                if (roleObjectpropCount > 0)
                {
                    body["role"] = roleObject;
                    bodypropCount++;
                }

                if (bodysecure != null)
                {
                    body["secure"] = ExpressionConverter.ConvertO(bodysecure);
                    bodypropCount++;
                }

                if (bodysms != null)
                {
                    body["sms"] = ExpressionConverter.ConvertO(bodysms);
                    bodypropCount++;
                }

                if (bodyssn != null)
                {
                    body["ssn"] = ExpressionConverter.ConvertO(bodyssn);
                    bodypropCount++;
                }

                if (bodybank != null)
                {
                    body["bank"] = ExpressionConverter.ConvertO(bodybank);
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
        [WorkflowExpressionFactory(nameof(__BuildGetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrl))]
        public IBodyWorkflowAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse> GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrl([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<bool> asObject = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse> __BuildGetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrl(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> documentId, WorkflowValue<string> fileId, WorkflowValue<string> xNamespace = null, WorkflowValue<bool> asObject = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(fileId, nameof(fileId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(asObject, nameof(asObject), required: false);
            return new DeferredBodyAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/files/{2}/url", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (asObject != null)
                    callPayload.Queries["asObject"] = ExpressionConverter.Convert(asObject);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildGetCompaniesCompanyIdUsersUserIdSettings))]
        public IBodyWorkflowAction<Setting> GetCompaniesCompanyIdUsersUserIdSettings([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> companyId, [WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Setting> __BuildGetCompaniesCompanyIdUsersUserIdSettings(WorkflowValue<string> token, WorkflowValue<string> companyId, WorkflowValue<string> userId)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(companyId, nameof(companyId), required: true);
            WorkflowValue.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<Setting>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/companies/{0}/users/{1}/settings", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Setting>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildGetEnvelopesEnvelopeId))]
        public IBodyWorkflowAction<Envelope> GetEnvelopesEnvelopeId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Envelope> __BuildGetEnvelopesEnvelopeId(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> xNamespace = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Envelope>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction<Envelope>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEnvelopesEnvelopeId))]
        public IWorkflowAction DeleteEnvelopesEnvelopeId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteEnvelopesEnvelopeId(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> xNamespace = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildPutEnvelopesEnvelopeId))]
        public IWorkflowAction PutEnvelopesEnvelopeId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<bool> bodysequentialSigning = null, [WorkflowExpression] Func<string> bodygreeting = null, [WorkflowExpression] Func<string> bodyexpiration = null, [WorkflowExpression] Func<double> bodyautomaticReminders = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPutEnvelopesEnvelopeId(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> xNamespace = null, WorkflowValue<bool> bodysequentialSigning = null, WorkflowValue<string> bodygreeting = null, WorkflowValue<string> bodyexpiration = null, WorkflowValue<double> bodyautomaticReminders = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(bodysequentialSigning, nameof(bodysequentialSigning), required: false);
            WorkflowValue.Validate(bodygreeting, nameof(bodygreeting), required: false);
            WorkflowValue.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            WorkflowValue.Validate(bodyautomaticReminders, nameof(bodyautomaticReminders), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysequentialSigning != null)
                {
                    body["sequentialSigning"] = ExpressionConverter.ConvertO(bodysequentialSigning);
                    bodypropCount++;
                }

                if (bodygreeting != null)
                {
                    body["greeting"] = ExpressionConverter.ConvertO(bodygreeting);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                    bodypropCount++;
                }

                if (bodyautomaticReminders != null)
                {
                    body["automaticReminders"] = ExpressionConverter.ConvertO(bodyautomaticReminders);
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
        [WorkflowExpressionFactory(nameof(__BuildPutEnvelopesEnvelopeIdPublishStatus))]
        public IWorkflowAction PutEnvelopesEnvelopeIdPublishStatus([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<bool> bodypublished, [WorkflowExpression] Func<string> xNamespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPutEnvelopesEnvelopeIdPublishStatus(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<bool> bodypublished, WorkflowValue<string> xNamespace = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(bodypublished, nameof(bodypublished), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/publish-status", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["published"] = ExpressionConverter.ConvertO(bodypublished);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildPostEnvelopesEnvelopeIdDocumentsDocumentIdTemplatesTemplateIdUserData))]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocumentsDocumentIdTemplatesTemplateIdUserData([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostEnvelopesEnvelopeIdDocumentsDocumentIdTemplatesTemplateIdUserData(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> documentId, WorkflowValue<string> templateId, WorkflowValue<string> xNamespace = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/templates/{2}/user-data", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
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
        [WorkflowExpressionFactory(nameof(__BuildPutEnvelopesEnvelopeIdAbortStatus))]
        public IWorkflowAction PutEnvelopesEnvelopeIdAbortStatus([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPutEnvelopesEnvelopeIdAbortStatus(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> xNamespace = null, WorkflowValue<string> bodycomment = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/abort-status", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(bodycomment);
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
        [WorkflowExpressionFactory(nameof(__BuildGetEnvelopesEnvelopeIdDocumentsDocumentIdFiles))]
        public IBodyWorkflowAction<File[]> GetEnvelopesEnvelopeIdDocumentsDocumentIdFiles([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<File[]> __BuildGetEnvelopesEnvelopeIdDocumentsDocumentIdFiles(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> documentId, WorkflowValue<string> xNamespace = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<File[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/files", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction<File[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildPostEnvelopesEnvelopeIdDocumentsDocumentIdFiles))]
        public IBodyWorkflowAction<File> PostEnvelopesEnvelopeIdDocumentsDocumentIdFiles([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyfileType, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodyhash = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<File> __BuildPostEnvelopesEnvelopeIdDocumentsDocumentIdFiles(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> documentId, WorkflowValue<string> bodyname, WorkflowValue<string> bodyfileType, WorkflowValue<string> xNamespace = null, WorkflowValue<string> bodyhash = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodyfileType, nameof(bodyfileType), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(bodyhash, nameof(bodyhash), required: false);
            return new DeferredBodyAction<File>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/files", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["fileType"] = ExpressionConverter.ConvertO(bodyfileType);
                if (bodyhash != null)
                {
                    body["hash"] = ExpressionConverter.ConvertO(bodyhash);
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
        [WorkflowExpressionFactory(nameof(__BuildGetAuthUserinfo))]
        public IBodyWorkflowAction<UserInfo> GetAuthUserinfo([WorkflowExpression] Func<string> token)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserInfo> __BuildGetAuthUserinfo(WorkflowValue<string> token)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            return new DeferredBodyAction<UserInfo>(() =>
            {
                var apiCallPath = "/auth/userinfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<UserInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildPostEnvelopesEnvelopeIdDocumentsDocumentIdStatusAborted))]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocumentsDocumentIdStatusAborted([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostEnvelopesEnvelopeIdDocumentsDocumentIdStatusAborted(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> documentId, WorkflowValue<string> xNamespace = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}/status/aborted", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildPutEnvelopesEnvelopeIdTrashStatus))]
        public IWorkflowAction PutEnvelopesEnvelopeIdTrashStatus([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPutEnvelopesEnvelopeIdTrashStatus(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> xNamespace = null, WorkflowValue<string> bodycomment = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/trash-status", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(bodycomment);
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
        [WorkflowExpressionFactory(nameof(__BuildGetQueryEnvelopes))]
        public IBodyWorkflowAction<EnvelopeDescriptorString[]> GetQueryEnvelopes([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> filters = null, [WorkflowExpression] Func<int> from = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EnvelopeDescriptorString[]> __BuildGetQueryEnvelopes(WorkflowValue<string> token, WorkflowValue<string> xNamespace = null, WorkflowValue<string> filters = null, WorkflowValue<int> from = null, WorkflowValue<int> limit = null, WorkflowValue<string> sort = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(filters, nameof(filters), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<EnvelopeDescriptorString[]>(() =>
            {
                var apiCallPath = "/query/envelopes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(filters);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction<EnvelopeDescriptorString[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildGetSearchEnvelopes))]
        public IBodyWorkflowAction<EnvelopeDescriptorString[]> GetSearchEnvelopes([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> filters = null, [WorkflowExpression] Func<int> from = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EnvelopeDescriptorString[]> __BuildGetSearchEnvelopes(WorkflowValue<string> token, WorkflowValue<string> xNamespace = null, WorkflowValue<string> filters = null, WorkflowValue<int> from = null, WorkflowValue<int> limit = null, WorkflowValue<string> sort = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(filters, nameof(filters), required: false);
            WorkflowValue.Validate(from, nameof(from), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<EnvelopeDescriptorString[]>(() =>
            {
                var apiCallPath = "/search/envelopes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(filters);
                if (from != null)
                    callPayload.Queries["from"] = ExpressionConverter.Convert(from);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction<EnvelopeDescriptorString[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildGetEnvelopeDescriptors))]
        public IBodyWorkflowAction<Descriptor[]> GetEnvelopeDescriptors([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> filters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Descriptor[]> __BuildGetEnvelopeDescriptors(WorkflowValue<string> token, WorkflowValue<string> xNamespace = null, WorkflowValue<string> filters = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(filters, nameof(filters), required: false);
            return new DeferredBodyAction<Descriptor[]>(() =>
            {
                var apiCallPath = "/envelope-descriptors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(filters);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction<Descriptor[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildGetFlowsFlowIdJobsEnvelopeId))]
        public IBodyWorkflowAction<GetFlowsFlowIdJobsEnvelopeIdResponse> GetFlowsFlowIdJobsEnvelopeId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> flowId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFlowsFlowIdJobsEnvelopeIdResponse> __BuildGetFlowsFlowIdJobsEnvelopeId(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> flowId, WorkflowValue<string> xNamespace = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(flowId, nameof(flowId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<GetFlowsFlowIdJobsEnvelopeIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/flows/{0}/jobs/{1}", ExpressionConverter.ConvertWithUrlEncoding(flowId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction<GetFlowsFlowIdJobsEnvelopeIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildGetEnvelopesEnvelopeIdDocumentsDocumentId))]
        public IBodyWorkflowAction<Document> GetEnvelopesEnvelopeIdDocumentsDocumentId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Document> __BuildGetEnvelopesEnvelopeIdDocumentsDocumentId(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> documentId, WorkflowValue<string> xNamespace = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Document>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction<Document>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEnvelopesEnvelopeIdDocumentsDocumentId))]
        public IWorkflowAction DeleteEnvelopesEnvelopeIdDocumentsDocumentId([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteEnvelopesEnvelopeIdDocumentsDocumentId(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> documentId, WorkflowValue<string> xNamespace = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildPostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopes))]
        public IBodyWorkflowAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse> PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopes([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeDescriptorId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodysenderemail = null, [WorkflowExpression] Func<string> bodysendergivenName = null, [WorkflowExpression] Func<string> bodysenderfamilyName = null, [WorkflowExpression] Func<double> bodyautomaticReminders = null, [WorkflowExpression] Func<string> bodyexpiration = null, [WorkflowExpression] Func<bodydocumentsInputItem[]> bodydocuments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse> __BuildPostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopes(WorkflowValue<string> token, WorkflowValue<string> envelopeDescriptorId, WorkflowValue<string> xNamespace = null, WorkflowValue<string> bodysenderemail = null, WorkflowValue<string> bodysendergivenName = null, WorkflowValue<string> bodysenderfamilyName = null, WorkflowValue<double> bodyautomaticReminders = null, WorkflowValue<string> bodyexpiration = null, WorkflowValue<bodydocumentsInputItem[]> bodydocuments = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeDescriptorId, nameof(envelopeDescriptorId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(bodysenderemail, nameof(bodysenderemail), required: false);
            WorkflowValue.Validate(bodysendergivenName, nameof(bodysendergivenName), required: false);
            WorkflowValue.Validate(bodysenderfamilyName, nameof(bodysenderfamilyName), required: false);
            WorkflowValue.Validate(bodyautomaticReminders, nameof(bodyautomaticReminders), required: false);
            WorkflowValue.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            WorkflowValue.Validate(bodydocuments, nameof(bodydocuments), required: false);
            return new DeferredBodyAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelope-descriptors/{0}/envelopes", ExpressionConverter.ConvertWithUrlEncoding(envelopeDescriptorId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var senderObject = new JObject();
                var senderObjectpropCount = 0;
                if (bodysenderemail != null)
                {
                    senderObject["email"] = ExpressionConverter.ConvertO(bodysenderemail);
                    senderObjectpropCount++;
                }

                if (bodysendergivenName != null)
                {
                    senderObject["givenName"] = ExpressionConverter.ConvertO(bodysendergivenName);
                    senderObjectpropCount++;
                }

                if (bodysenderfamilyName != null)
                {
                    senderObject["familyName"] = ExpressionConverter.ConvertO(bodysenderfamilyName);
                    senderObjectpropCount++;
                }

                if (senderObjectpropCount > 0)
                {
                    body["sender"] = senderObject;
                    bodypropCount++;
                }

                if (bodyautomaticReminders != null)
                {
                    body["automaticReminders"] = ExpressionConverter.ConvertO(bodyautomaticReminders);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                    bodypropCount++;
                }

                if (bodydocuments != null)
                {
                    body["documents"] = ExpressionConverter.ConvertO(bodydocuments);
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
        [WorkflowExpressionFactory(nameof(__BuildGetEnvelopesEnvelopeIdDocuments))]
        public IBodyWorkflowAction<Document[]> GetEnvelopesEnvelopeIdDocuments([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Document[]> __BuildGetEnvelopesEnvelopeIdDocuments(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> xNamespace = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Document[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction<Document[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildPostEnvelopesEnvelopeIdDocuments))]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocuments([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<int> bodydescriptorhash = null, [WorkflowExpression] Func<string> bodysource = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostEnvelopesEnvelopeIdDocuments(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> bodyname, WorkflowValue<string> xNamespace = null, WorkflowValue<int> bodydescriptorhash = null, WorkflowValue<string> bodysource = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(bodydescriptorhash, nameof(bodydescriptorhash), required: false);
            WorkflowValue.Validate(bodysource, nameof(bodysource), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var descriptorObject = new JObject();
                var descriptorObjectpropCount = 0;
                if (bodydescriptorhash != null)
                {
                    descriptorObject["hash"] = ExpressionConverter.ConvertO(bodydescriptorhash);
                    descriptorObjectpropCount++;
                }

                if (descriptorObjectpropCount > 0)
                {
                    body["descriptor"] = descriptorObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(bodysource);
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
        [WorkflowExpressionFactory(nameof(__BuildPostEnvelopesEnvelopeIdJobsGetSignLink))]
        public IBodyWorkflowAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse> PostEnvelopesEnvelopeIdJobsGetSignLink([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodyrecipientid = null, [WorkflowExpression] Func<string> bodyredirectTo = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse> __BuildPostEnvelopesEnvelopeIdJobsGetSignLink(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> xNamespace = null, WorkflowValue<string> bodyrecipientid = null, WorkflowValue<string> bodyredirectTo = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(bodyrecipientid, nameof(bodyrecipientid), required: false);
            WorkflowValue.Validate(bodyredirectTo, nameof(bodyredirectTo), required: false);
            return new DeferredBodyAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/jobs/get.sign.link", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var recipientObject = new JObject();
                var recipientObjectpropCount = 0;
                if (bodyrecipientid != null)
                {
                    recipientObject["id"] = ExpressionConverter.ConvertO(bodyrecipientid);
                    recipientObjectpropCount++;
                }

                if (recipientObjectpropCount > 0)
                {
                    body["recipient"] = recipientObject;
                    bodypropCount++;
                }

                if (bodyredirectTo != null)
                {
                    body["redirectTo"] = ExpressionConverter.ConvertO(bodyredirectTo);
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
        [WorkflowExpressionFactory(nameof(__BuildPostEnvelopeDescriptorsDefaultEnvelopes))]
        public IBodyWorkflowAction<PostEnvelopeDescriptorsDefaultEnvelopesResponse> PostEnvelopeDescriptorsDefaultEnvelopes([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodysenderemail = null, [WorkflowExpression] Func<string> bodysendergivenName = null, [WorkflowExpression] Func<string> bodysenderfamilyName = null, [WorkflowExpression] Func<double> bodyautomaticReminders = null, [WorkflowExpression] Func<string> bodyexpiration = null, [WorkflowExpression] Func<bodydocumentsInputItem[]> bodydocuments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostEnvelopeDescriptorsDefaultEnvelopesResponse> __BuildPostEnvelopeDescriptorsDefaultEnvelopes(WorkflowValue<string> token, WorkflowValue<string> xNamespace = null, WorkflowValue<string> bodysenderemail = null, WorkflowValue<string> bodysendergivenName = null, WorkflowValue<string> bodysenderfamilyName = null, WorkflowValue<double> bodyautomaticReminders = null, WorkflowValue<string> bodyexpiration = null, WorkflowValue<bodydocumentsInputItem[]> bodydocuments = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(bodysenderemail, nameof(bodysenderemail), required: false);
            WorkflowValue.Validate(bodysendergivenName, nameof(bodysendergivenName), required: false);
            WorkflowValue.Validate(bodysenderfamilyName, nameof(bodysenderfamilyName), required: false);
            WorkflowValue.Validate(bodyautomaticReminders, nameof(bodyautomaticReminders), required: false);
            WorkflowValue.Validate(bodyexpiration, nameof(bodyexpiration), required: false);
            WorkflowValue.Validate(bodydocuments, nameof(bodydocuments), required: false);
            return new DeferredBodyAction<PostEnvelopeDescriptorsDefaultEnvelopesResponse>(() =>
            {
                var apiCallPath = "/envelope-descriptors/default/envelopes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var senderObject = new JObject();
                var senderObjectpropCount = 0;
                if (bodysenderemail != null)
                {
                    senderObject["email"] = ExpressionConverter.ConvertO(bodysenderemail);
                    senderObjectpropCount++;
                }

                if (bodysendergivenName != null)
                {
                    senderObject["givenName"] = ExpressionConverter.ConvertO(bodysendergivenName);
                    senderObjectpropCount++;
                }

                if (bodysenderfamilyName != null)
                {
                    senderObject["familyName"] = ExpressionConverter.ConvertO(bodysenderfamilyName);
                    senderObjectpropCount++;
                }

                if (senderObjectpropCount > 0)
                {
                    body["sender"] = senderObject;
                    bodypropCount++;
                }

                if (bodyautomaticReminders != null)
                {
                    body["automaticReminders"] = ExpressionConverter.ConvertO(bodyautomaticReminders);
                    bodypropCount++;
                }

                if (bodyexpiration != null)
                {
                    body["expiration"] = ExpressionConverter.ConvertO(bodyexpiration);
                    bodypropCount++;
                }

                if (bodydocuments != null)
                {
                    body["documents"] = ExpressionConverter.ConvertO(bodydocuments);
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
        [WorkflowExpressionFactory(nameof(__BuildGetEnvelopeDescriptorsDefault))]
        public IBodyWorkflowAction<Descriptor> GetEnvelopeDescriptorsDefault([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> filters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Descriptor> __BuildGetEnvelopeDescriptorsDefault(WorkflowValue<string> token, WorkflowValue<string> xNamespace = null, WorkflowValue<string> filters = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(filters, nameof(filters), required: false);
            return new DeferredBodyAction<Descriptor>(() =>
            {
                var apiCallPath = "/envelope-descriptors/default";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filters != null)
                    callPayload.Queries["filters"] = ExpressionConverter.Convert(filters);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                return new ApiConnectionAction<Descriptor>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        [WorkflowExpressionFactory(nameof(__BuildPostEnvelopesEnvelopIdJobsSendNotification))]
        public IWorkflowAction PostEnvelopesEnvelopIdJobsSendNotification([WorkflowExpression] Func<string> token, [WorkflowExpression] Func<string> envelopeId, [WorkflowExpression] Func<string> xNamespace = null, [WorkflowExpression] Func<string> bodyenvelopegreeting = null, [WorkflowExpression] Func<string> bodyrecipientid = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostEnvelopesEnvelopIdJobsSendNotification(WorkflowValue<string> token, WorkflowValue<string> envelopeId, WorkflowValue<string> xNamespace = null, WorkflowValue<string> bodyenvelopegreeting = null, WorkflowValue<string> bodyrecipientid = null)
        {
            WorkflowValue.Validate(token, nameof(token), required: true);
            WorkflowValue.Validate(envelopeId, nameof(envelopeId), required: true);
            WorkflowValue.Validate(xNamespace, nameof(xNamespace), required: false);
            WorkflowValue.Validate(bodyenvelopegreeting, nameof(bodyenvelopegreeting), required: false);
            WorkflowValue.Validate(bodyrecipientid, nameof(bodyrecipientid), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/envelopes/{0}/jobs/send.notification", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
                var body = new JObject();
                var bodypropCount = 0;
                var envelopeObject = new JObject();
                var envelopeObjectpropCount = 0;
                if (bodyenvelopegreeting != null)
                {
                    envelopeObject["greeting"] = ExpressionConverter.ConvertO(bodyenvelopegreeting);
                    envelopeObjectpropCount++;
                }

                if (envelopeObjectpropCount > 0)
                {
                    body["envelope"] = envelopeObject;
                    bodypropCount++;
                }

                var recipientObject = new JObject();
                var recipientObjectpropCount = 0;
                if (bodyrecipientid != null)
                {
                    recipientObject["id"] = ExpressionConverter.ConvertO(bodyrecipientid);
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
