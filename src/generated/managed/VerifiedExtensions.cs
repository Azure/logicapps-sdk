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
        public IBodyWorkflowAction<PostAuthenticateResponse, ApiConnectionActionConfiguration> PostAuthenticate(Expression<Func<int>> withoutIpLock)
        {
            var __workflow_withoutIpLock = WorkflowExpression.Compile(withoutIpLock, nameof(withoutIpLock), required: true);
            return new DeferredBodyAction<PostAuthenticateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/auth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["withoutIpLock"] = ExpressionConverter.Convert(__workflow_withoutIpLock);
                return new ApiConnectionAction<PostAuthenticateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Company, ApiConnectionActionConfiguration> GetCompaniesCompanyId(Expression<Func<string>> token, Expression<Func<string>> companyId)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            return new DeferredBodyAction<Company, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/companies/{0}", __workflow_companyId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Company>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Recipient[], ApiConnectionActionConfiguration> GetEnvelopesEnvelopeIdRecipients(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Recipient[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/recipients", __workflow_envelopeId.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> PostEnvelopesEnvelopeIdRecipients(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<PostEnvelopesEnvelopeIdRecipientsInput>> body, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/recipients", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Recipient, ApiConnectionActionConfiguration> GetEnvelopesEnvelopeIdRecipientsRecipientId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Recipient, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/recipients/{1}", __workflow_envelopeId.WithUrlEncoding(1), __workflow_recipientId.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> PutEnvelopesEnvelopeIdRecipientsRecipientId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> recipientId, Expression<Func<PutEnvelopesEnvelopeIdRecipientsRecipientIdInput>> body, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/recipients/{1}", __workflow_envelopeId.WithUrlEncoding(1), __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse, ApiConnectionActionConfiguration> GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrl(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> fileId, Expression<Func<string>> xNamespace = null, Expression<Func<bool>> asObject = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_asObject = WorkflowExpression.Compile(asObject, nameof(asObject), required: false);
            return new DeferredBodyAction<GetEnvelopesEnvelopeIdDocumentsDocumentIdFilesFileIdUrlResponse, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Setting, ApiConnectionActionConfiguration> GetCompaniesCompanyIdUsersUserIdSettings(Expression<Func<string>> token, Expression<Func<string>> companyId, Expression<Func<string>> userId)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<Setting, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/companies/{0}/users/{1}/settings", __workflow_companyId.WithUrlEncoding(1), __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<Setting>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Envelope, ApiConnectionActionConfiguration> GetEnvelopesEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Envelope, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}", __workflow_envelopeId.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEnvelopesEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}", __workflow_envelopeId.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> PutEnvelopesEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<PutEnvelopesEnvelopeIdInput>> body, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutEnvelopesEnvelopeIdPublishStatus(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<PutEnvelopesEnvelopeIdPublishStatusInput>> body, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/publish-status", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostEnvelopesEnvelopeIdDocumentsDocumentIdTemplatesTemplateIdUserData(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> templateId, Expression<Func<object>> body, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents/{1}/templates/{2}/user-data", __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1), __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PutEnvelopesEnvelopeIdAbortStatus(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<PutEnvelopesEnvelopeIdAbortStatusInput>> body = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/abort-status", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<File[], ApiConnectionActionConfiguration> GetEnvelopesEnvelopeIdDocumentsDocumentIdFiles(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<File[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents/{1}/files", __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<File, ApiConnectionActionConfiguration> PostEnvelopesEnvelopeIdDocumentsDocumentIdFiles(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null, Expression<Func<PostEnvelopesEnvelopeIdDocumentsDocumentIdFilesInput>> body = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<File, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents/{1}/files", __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<File>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<UserInfo, ApiConnectionActionConfiguration> GetAuthUserinfo(Expression<Func<string>> token)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            return new DeferredBodyAction<UserInfo, ApiConnectionActionConfiguration>(() =>
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
        public IWorkflowAction<ApiConnectionActionConfiguration> PostEnvelopesEnvelopeIdDocumentsDocumentIdStatusAborted(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents/{1}/status/aborted", __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> PutEnvelopesEnvelopeIdTrashStatus(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<PutEnvelopesEnvelopeIdTrashStatusInput>> body = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/trash-status", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<EnvelopeDescriptorString[], ApiConnectionActionConfiguration> GetQueryEnvelopes(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null, Expression<Func<int>> from = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<EnvelopeDescriptorString[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<EnvelopeDescriptorString[], ApiConnectionActionConfiguration> GetSearchEnvelopes(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null, Expression<Func<int>> from = null, Expression<Func<int>> limit = null, Expression<Func<string>> sort = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<EnvelopeDescriptorString[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<Descriptor[], ApiConnectionActionConfiguration> GetEnvelopeDescriptors(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            return new DeferredBodyAction<Descriptor[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<GetFlowsFlowIdJobsEnvelopeIdResponse, ApiConnectionActionConfiguration> GetFlowsFlowIdJobsEnvelopeId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> flowId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_flowId = WorkflowExpression.Compile(flowId, nameof(flowId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<GetFlowsFlowIdJobsEnvelopeIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/flows/{0}/jobs/{1}", __workflow_flowId.WithUrlEncoding(1), __workflow_envelopeId.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<Document, ApiConnectionActionConfiguration> GetEnvelopesEnvelopeIdDocumentsDocumentId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Document, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents/{1}", __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEnvelopesEnvelopeIdDocumentsDocumentId(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> documentId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents/{1}", __workflow_envelopeId.WithUrlEncoding(1), __workflow_documentId.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse, ApiConnectionActionConfiguration> PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopes(Expression<Func<string>> token, Expression<Func<string>> envelopeDescriptorId, Expression<Func<string>> xNamespace = null, Expression<Func<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesInput>> body = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeDescriptorId = WorkflowExpression.Compile(envelopeDescriptorId, nameof(envelopeDescriptorId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelope-descriptors/{0}/envelopes", __workflow_envelopeDescriptorId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Document[], ApiConnectionActionConfiguration> GetEnvelopesEnvelopeIdDocuments(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            return new DeferredBodyAction<Document[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents", __workflow_envelopeId.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> PostEnvelopesEnvelopeIdDocuments(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<PostEnvelopesEnvelopeIdDocumentsInput>> body = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/documents", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse, ApiConnectionActionConfiguration> PostEnvelopesEnvelopeIdJobsGetSignLink(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<PostEnvelopesEnvelopeIdJobsGetSignLinkInput>> body = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/jobs/get.sign.link", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostEnvelopesEnvelopeIdJobsGetSignLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<PostEnvelopeDescriptorsDefaultEnvelopesResponse, ApiConnectionActionConfiguration> PostEnvelopeDescriptorsDefaultEnvelopes(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<PostEnvelopeDescriptorsDefaultEnvelopesInput>> body = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostEnvelopeDescriptorsDefaultEnvelopesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/envelope-descriptors/default/envelopes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostEnvelopeDescriptorsDefaultEnvelopesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "verified")]
        public IBodyWorkflowAction<Descriptor, ApiConnectionActionConfiguration> GetEnvelopeDescriptorsDefault(Expression<Func<string>> token, Expression<Func<string>> xNamespace = null, Expression<Func<string>> filters = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_filters = WorkflowExpression.Compile(filters, nameof(filters), required: false);
            return new DeferredBodyAction<Descriptor, ApiConnectionActionConfiguration>(() =>
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
        public IWorkflowAction<ApiConnectionActionConfiguration> PostEnvelopesEnvelopIdJobsSendNotification(Expression<Func<string>> token, Expression<Func<string>> envelopeId, Expression<Func<string>> xNamespace = null, Expression<Func<PostEnvelopesEnvelopIdJobsSendNotificationInput>> body = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_envelopeId = WorkflowExpression.Compile(envelopeId, nameof(envelopeId), required: true);
            var __workflow_xNamespace = WorkflowExpression.Compile(xNamespace, nameof(xNamespace), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/envelopes/{0}/jobs/send.notification", __workflow_envelopeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_xNamespace != null)
                    callPayload.Headers["x-namespace"] = ExpressionConverter.Convert(__workflow_xNamespace);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class PostEnvelopesEnvelopeIdRecipientsInput
    {
        [JsonProperty("givenName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GivenName { get; set; }

        [JsonProperty("familyName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FamilyName { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostEnvelopesEnvelopeIdRecipientsInputLanguageType Language { get; set; }

        [JsonProperty("signingMethod", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostEnvelopesEnvelopeIdRecipientsInputSigningMethodType SigningMethod { get; set; }

        [JsonProperty("notificationMethod")]
        public PostEnvelopesEnvelopeIdRecipientsInputNotificationMethodType? NotificationMethod { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public RoleInput Role { get; set; }

        [JsonProperty("secure")]
        public bool? Secure { get; set; }

        [JsonProperty("sms")]
        public bool? Sms { get; set; }

        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PostEnvelopesEnvelopeIdRecipientsInputLanguageType
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
    public enum PostEnvelopesEnvelopeIdRecipientsInputSigningMethodType
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
    public enum PostEnvelopesEnvelopeIdRecipientsInputNotificationMethodType
    {
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "sms")]
        Sms
    }

    public class RoleInput
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PutEnvelopesEnvelopeIdRecipientsRecipientIdInput
    {
        [JsonProperty("givenName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GivenName { get; set; }

        [JsonProperty("familyName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FamilyName { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public PutEnvelopesEnvelopeIdRecipientsRecipientIdInputLanguageType Language { get; set; }

        [JsonProperty("signingMethod", DefaultValueHandling = DefaultValueHandling.Include)]
        public PutEnvelopesEnvelopeIdRecipientsRecipientIdInputSigningMethodType SigningMethod { get; set; }

        [JsonProperty("notificationMethod")]
        public PutEnvelopesEnvelopeIdRecipientsRecipientIdInputNotificationMethodType? NotificationMethod { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public RoleInput Role { get; set; }

        [JsonProperty("secure")]
        public bool? Secure { get; set; }

        [JsonProperty("sms")]
        public bool? Sms { get; set; }

        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PutEnvelopesEnvelopeIdRecipientsRecipientIdInputLanguageType
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
    public enum PutEnvelopesEnvelopeIdRecipientsRecipientIdInputSigningMethodType
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
    public enum PutEnvelopesEnvelopeIdRecipientsRecipientIdInputNotificationMethodType
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

    public class PutEnvelopesEnvelopeIdInput
    {
        [JsonProperty("sequentialSigning")]
        public bool? SequentialSigning { get; set; }

        [JsonProperty("greeting")]
        public string Greeting { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("automaticReminders")]
        public double? AutomaticReminders { get; set; }
    }

    public class PutEnvelopesEnvelopeIdPublishStatusInput
    {
        [JsonProperty("published", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Published { get; set; }
    }

    public class PutEnvelopesEnvelopeIdAbortStatusInput
    {
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

    public class PostEnvelopesEnvelopeIdDocumentsDocumentIdFilesInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("fileType", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileType { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
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

    public class PutEnvelopesEnvelopeIdTrashStatusInput
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }
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

    public class PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesInput
    {
        [JsonProperty("sender")]
        public PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesInputSenderType Sender { get; set; }

        [JsonProperty("automaticReminders")]
        public double? AutomaticReminders { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("documents")]
        public PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesInputDocumentsTypeItem[] Documents { get; set; }
    }

    public class PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesInputSenderType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }
    }

    public class PostEnvelopeDescriptorsEnvelopeDescriptorIdEnvelopesInputDocumentsTypeItem
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class PostEnvelopesEnvelopeIdDocumentsInput
    {
        [JsonProperty("descriptor")]
        public PostEnvelopesEnvelopeIdDocumentsInputDescriptorType Descriptor { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class PostEnvelopesEnvelopeIdDocumentsInputDescriptorType
    {
        [JsonProperty("hash")]
        public int? Hash { get; set; }
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

    public class PostEnvelopesEnvelopeIdJobsGetSignLinkInput
    {
        [JsonProperty("recipient")]
        public PostEnvelopesEnvelopeIdJobsGetSignLinkInputRecipientType Recipient { get; set; }

        [JsonProperty("redirectTo")]
        public string RedirectTo { get; set; }
    }

    public class PostEnvelopesEnvelopeIdJobsGetSignLinkInputRecipientType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class PostEnvelopeDescriptorsDefaultEnvelopesResponse
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class PostEnvelopeDescriptorsDefaultEnvelopesInput
    {
        [JsonProperty("sender")]
        public PostEnvelopeDescriptorsDefaultEnvelopesInputSenderType Sender { get; set; }

        [JsonProperty("automaticReminders")]
        public double? AutomaticReminders { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("documents")]
        public PostEnvelopeDescriptorsDefaultEnvelopesInputDocumentsTypeItem[] Documents { get; set; }
    }

    public class PostEnvelopeDescriptorsDefaultEnvelopesInputSenderType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }
    }

    public class PostEnvelopeDescriptorsDefaultEnvelopesInputDocumentsTypeItem
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class PostEnvelopesEnvelopIdJobsSendNotificationInput
    {
        [JsonProperty("envelope")]
        public PostEnvelopesEnvelopIdJobsSendNotificationInputEnvelopeType Envelope { get; set; }

        [JsonProperty("recipient", DefaultValueHandling = DefaultValueHandling.Include)]
        public PostEnvelopesEnvelopIdJobsSendNotificationInputRecipientType Recipient { get; set; }
    }

    public class PostEnvelopesEnvelopIdJobsSendNotificationInputEnvelopeType
    {
        [JsonProperty("greeting")]
        public string Greeting { get; set; }
    }

    public class PostEnvelopesEnvelopIdJobsSendNotificationInputRecipientType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
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