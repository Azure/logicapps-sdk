//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Verified
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VerifiedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostAuthenticateResponse> PostAuthenticate(Expression<Func<int>> withoutIpLock)
        {
            var apiCallPath = "/auth";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["withoutIpLock"] = ExpressionConverter.Convert(withoutIpLock);
            return new ApiConnectionAction<PostAuthenticateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Company> GetCompaniesCompanyId(Expression<Func<string>> token, Expression<Func<string>> companyId)
        {
            var apiCallPath = String.Format("/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<Company>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Recipient[]> GetEnvelopesEnvelopeIdRecipients(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/recipients", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (xNamespace != null)
                callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
            return new ApiConnectionAction<Recipient[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdRecipients(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> bodygivenName, Expression<Func<string>> bodyfamilyName, Expression<Func<bodylanguageInput>> bodylanguage, Expression<Func<bodysigningMethodInput>> bodysigningMethod, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyroleaction, Expression<Func<string>> bodyrolelabel, Expression<Func<string>> bodyrolename, Expression<Func<string>> xNamespace = null, Expression<Func<bodynotificationMethodInput>> bodynotificationMethod = null, Expression<Func<string>> bodytelephone = null, Expression<Func<int>> bodyorder = null, Expression<Func<bool>> bodysecure = null, Expression<Func<bool>> bodysms = null, Expression<Func<string>> bodyssn = null, Expression<Func<string>> bodybank = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/recipients", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Recipient> GetEnvelopesEnvelopeIdRecipientsRecipientId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> xNamespace = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/recipients/{1}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (xNamespace != null)
                callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
            return new ApiConnectionAction<Recipient>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdRecipientsRecipientId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> bodygivenName, Expression<Func<string>> bodyfamilyName, Expression<Func<bodylanguageInput>> bodylanguage, Expression<Func<bodysigningMethodInput>> bodysigningMethod, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyroleaction, Expression<Func<string>> bodyrolelabel, Expression<Func<string>> bodyrolename, Expression<Func<string>> xNamespace = null, Expression<Func<bodynotificationMethodInput>> bodynotificationMethod = null, Expression<Func<string>> bodytelephone = null, Expression<Func<int>> bodyorder = null, Expression<Func<bool>> bodysecure = null, Expression<Func<bool>> bodysms = null, Expression<Func<string>> bodyssn = null, Expression<Func<string>> bodybank = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/recipients/{1}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse> GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrl(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> fileId, Expression<Func<string>> xNamespace = null, Expression<Func<bool>> asObject = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/documents/{1}/files/{2}/url", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (asObject != null)
                callPayload.Queries["asObject"] = ExpressionConverter.Convert(asObject);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (xNamespace != null)
                callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
            return new ApiConnectionAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Setting> GetCompaniesCompanyIdUsersUserIdSettings(Expression<Func<string>> token, Expression<Func<string>> companyId, Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/companies/{0}/users/{1}/settings", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<Setting>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Envelope> GetEnvelopesEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (xNamespace != null)
                callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
            return new ApiConnectionAction<Envelope>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction DeleteEnvelopesEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (xNamespace != null)
                callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<bool>> bodysequentialSigning = null, Expression<Func<string>> bodygreeting = null, Expression<Func<string>> bodyexpiration = null, Expression<Func<double>> bodyautomaticReminders = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdPublishStatus(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<bool>> bodypublished, Expression<Func<string>> xNamespace = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/publish-status", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocumentsDocumentIdTemplatesTemplateIdUserData(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> templateId, Expression<Func<string>> xNamespace = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/documents/{1}/templates/{2}/user-data", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdAbortStatus(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/abort-status", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<File[]> GetEnvelopesEnvelopeIdDocumentsDocumentIdFiles(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/documents/{1}/files", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (xNamespace != null)
                callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
            return new ApiConnectionAction<File[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<File> PostEnvelopesEnvelopeIdDocumentsDocumentIdFiles(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyfileType, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodyhash = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/documents/{1}/files", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<UserInfo> GetAuthUserinfo(Expression<Func<string>> token)
        {
            var apiCallPath = "/auth/userinfo";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<UserInfo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocumentsDocumentIdStatusAborted(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/documents/{1}/status/aborted", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (xNamespace != null)
                callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PutEnvelopesEnvelopeIdTrashStatus(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/trash-status", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<EnvelopeDescriptorString[]> GetQueryEnvelopes(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null, Expression<Func<int>> from = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<EnvelopeDescriptorString[]> GetSearchEnvelopes(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null, Expression<Func<int>> from = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Descriptor[]> GetEnvelopeDescriptors(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<GetFlowsFlowIdJobsEnvelopeIdResponse> GetFlowsFlowIdJobsEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> flowId, Expression<Func<string>> xNamespace = null)
        {
            var apiCallPath = String.Format("/flows/{0}/jobs/{1}", ExpressionConverter.ConvertWithUrlEncoding(flowId, 1), ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (xNamespace != null)
                callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
            return new ApiConnectionAction<GetFlowsFlowIdJobsEnvelopeIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Document> GetEnvelopesEnvelopeIdDocumentsDocumentId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (xNamespace != null)
                callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
            return new ApiConnectionAction<Document>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction DeleteEnvelopesEnvelopeIdDocumentsDocumentId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/documents/{1}", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (xNamespace != null)
                callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse> PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopes(Expression<Func<string>> token, Expression<Func<string>> envelopeDescriptorId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodysenderemail = null, Expression<Func<string>> bodysendergivenName = null, Expression<Func<string>> bodysenderfamilyName = null, Expression<Func<double>> bodyautomaticReminders = null, Expression<Func<string>> bodyexpiration = null, Expression<Func<bodydocumentsInputItem[]>> bodydocuments = null)
        {
            var apiCallPath = String.Format("/envelope-descriptors/{0}/envelopes", ExpressionConverter.ConvertWithUrlEncoding(envelopeDescriptorId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Document[]> GetEnvelopesEnvelopeIdDocuments(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["token"] = ExpressionConverter.Convert(token);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (xNamespace != null)
                callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(xNamespace);
            return new ApiConnectionAction<Document[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction PostEnvelopesEnvelopeIdDocuments(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> bodyname, Expression<Func<string>> xNamespace = null, Expression<Func<int>> bodydescriptorhash = null, Expression<Func<string>> bodysource = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/documents", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse> PostEnvelopesEnvelopeIdJobsGetSignLink(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodyrecipientid = null, Expression<Func<string>> bodyredirectTo = null)
        {
            var apiCallPath = String.Format("/envelopes/{0}/jobs/get.sign.link", ExpressionConverter.ConvertWithUrlEncoding(envelopeId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopeDescriptorsDefaultEnvelopesResponse> PostEnvelopeDescriptorsDefaultEnvelopes(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> bodysenderemail = null, Expression<Func<string>> bodysendergivenName = null, Expression<Func<string>> bodysenderfamilyName = null, Expression<Func<double>> bodyautomaticReminders = null, Expression<Func<string>> bodyexpiration = null, Expression<Func<bodydocumentsInputItem[]>> bodydocuments = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Descriptor> GetEnvelopeDescriptorsDefault(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null)
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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