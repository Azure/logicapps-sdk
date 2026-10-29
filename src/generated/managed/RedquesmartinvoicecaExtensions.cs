//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Redquesmartinvoiceca
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RedquesmartinvoicecaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReturnDocumentConfiguration()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/configuration/return-to-issuer";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> StoreReturnDocumentConfiguration(Expression<Func<StoreReturnDocumentConfigurationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/configuration/return-to-issuer";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetImage(Expression<Func<string>> documentId, Expression<Func<int>> pageIndex, Expression<Func<bool>> isPreview = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_pageIndex = WorkflowExpression.Compile(pageIndex, nameof(pageIndex), required: true);
            var __workflow_isPreview = WorkflowExpression.Compile(isPreview, nameof(isPreview), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/page/{1}/image", __workflow_documentId.WithUrlEncoding(1), __workflow_pageIndex.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isPreview"] = Convert.ToString(false);
                if (__workflow_isPreview != null)
                    callPayload.Queries["isPreview"] = ExpressionConverter.Convert(__workflow_isPreview);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReturnDocument(Expression<Func<string>> documentId, Expression<Func<ReturnDocumentInput>> body = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/return-to-issuer", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiDocumentApiListResult, ApiConnectionActionConfiguration> ListAllDocuments(Expression<Func<ListAllDocumentsInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ApiDocumentApiListResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/documents/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ApiDocumentApiListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DownloadFileAsync(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/file", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiDocument, ApiConnectionActionConfiguration> GetDocument(Expression<Func<string>> documentId, Expression<Func<bool>> isExternalId = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_isExternalId = WorkflowExpression.Compile(isExternalId, nameof(isExternalId), required: false);
            return new DeferredBodyAction<ApiDocument, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["isExternalId"] = Convert.ToString(false);
                if (__workflow_isExternalId != null)
                    callPayload.Queries["isExternalId"] = ExpressionConverter.Convert(__workflow_isExternalId);
                return new ApiConnectionAction<ApiDocument>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<RedQueStatus, ApiConnectionActionConfiguration> UpdateDocuments(Expression<Func<string>> documentId, Expression<Func<UpdateDocumentsInput>> body = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<RedQueStatus, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RedQueStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LockDocument(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/lock", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnlockDocumentAsync(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/lock", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GrantDocumentAccess(Expression<Func<string>> documentId, Expression<Func<string>> userId, Expression<Func<GrantDocumentAccessInput>> body = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/users/{1}", __workflow_documentId.WithUrlEncoding(1), __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveDocumentAccess(Expression<Func<string>> documentId, Expression<Func<string>> userId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/documents/{0}/users/{1}", __workflow_documentId.WithUrlEncoding(1), __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiEnum[], ApiConnectionActionConfiguration> GetAllEnums()
        {
            return new DeferredBodyAction<ApiEnum[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/enums";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ApiEnum[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<StringApiValue, ApiConnectionActionConfiguration> CreateEnum(Expression<Func<CreateEnumInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<StringApiValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/enums";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StringApiValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiEnum, ApiConnectionActionConfiguration> GetEnum(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ApiEnum, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/enums/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ApiEnum>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateEnum(Expression<Func<string>> id, Expression<Func<UpdateEnumInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/enums/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteEnum(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/enums/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetExtractDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/extract/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiFolderCreationResult, ApiConnectionActionConfiguration> CreateFolder()
        {
            return new DeferredBodyAction<ApiFolderCreationResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/folder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ApiFolderCreationResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DownloadFolderArchived(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/folder/{0}/archived", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFolder(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/folder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiFolderWithMembers, ApiConnectionActionConfiguration> GetFolder(Expression<Func<string>> folderId, Expression<Func<bool>> withMembers = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_withMembers = WorkflowExpression.Compile(withMembers, nameof(withMembers), required: false);
            return new DeferredBodyAction<ApiFolderWithMembers, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/folder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["withMembers"] = Convert.ToString(false);
                if (__workflow_withMembers != null)
                    callPayload.Queries["withMembers"] = ExpressionConverter.Convert(__workflow_withMembers);
                return new ApiConnectionAction<ApiFolderWithMembers>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateContainerData(Expression<Func<string>> folderId, Expression<Func<UpdateContainerDataInput>> body = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/folder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<MLicense, ApiConnectionActionConfiguration> GetLicenseInfo()
        {
            return new DeferredBodyAction<MLicense, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/tenant/license";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MLicense>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<StringApiValue, ApiConnectionActionConfiguration> GetRegisterToken()
        {
            return new DeferredBodyAction<StringApiValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/tenant/token";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StringApiValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<StringApiValue, ApiConnectionActionConfiguration> GenerateRegistrationToken()
        {
            return new DeferredBodyAction<StringApiValue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/tenant/token";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StringApiValue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DisableRegistrationToken()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/tenant/token";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiUserApiListResult, ApiConnectionActionConfiguration> ListOfUsers(Expression<Func<ListOfUsersInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ApiUserApiListResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ApiUserApiListResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateUser(Expression<Func<CreateUserInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ChangePassword(Expression<Func<string>> userId, Expression<Func<string>> body = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}/password", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ForceUserPasswordChange(Expression<Func<string>> userId, Expression<Func<ForceUserPasswordChangeInput>> body = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}/password", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteUser(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IBodyWorkflowAction<ApiUser, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<ApiUser, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ApiUser>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateUser(Expression<Func<string>> userId, Expression<Func<UpdateUserInput>> body = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddUserPermissions(Expression<Func<string>> userId, Expression<Func<AddUserPermissionsInput>> body = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}/permission", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "redquesmartinvoiceca")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveUserPermissions(Expression<Func<string>> userId, Expression<Func<RemoveUserPermissionsInput>> body = null)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/users/{0}/permission", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class RedquesmartinvoicecaTriggers([ConnectionName] string connectionId)
    {
    }

    public class StoreReturnDocumentConfigurationInput
    {
        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class ReturnDocumentInput
    {
        [JsonProperty("additionalDocuments")]
        public string[] AdditionalDocuments { get; set; }

        [JsonProperty("recipientEmail")]
        public string RecipientEmail { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("requestedByUserId")]
        public string RequestedByUserId { get; set; }
    }

    public class ApiDocumentApiListResult
    {
        [JsonProperty("list")]
        public ApiDocument[] List { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }
    }

    public class ApiDocument
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("externalDocumentId")]
        public string ExternalDocumentId { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("contentHash")]
        public string ContentHash { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("owner")]
        public ApiUser Owner { get; set; }

        [JsonProperty("state")]
        public DocumentState State { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("isImagesGenerated")]
        public bool IsImagesGenerated { get; set; }

        [JsonProperty("isReturned")]
        public bool IsReturned { get; set; }

        [JsonProperty("returnReason")]
        public string ReturnReason { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("source")]
        public DocumentSource Source { get; set; }

        [JsonProperty("sourceInfo")]
        public string SourceInfo { get; set; }

        [JsonProperty("extractionTime")]
        public string ExtractionTime { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("isAttachment")]
        public bool IsAttachment { get; set; }

        [JsonProperty("isValidated")]
        public bool IsValidated { get; set; }

        [JsonProperty("isEdited")]
        public bool IsEdited { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }

        [JsonProperty("items")]
        public JToken[] Items { get; set; }

        [JsonProperty("pages")]
        public ApiPage[] Pages { get; set; }

        [JsonProperty("pluginResults")]
        public ApiPluginResult[] PluginResults { get; set; }

        [JsonProperty("isPostProcessCompleted")]
        public bool IsPostProcessCompleted { get; set; }

        [JsonProperty("isPrevalidated")]
        public bool IsPrevalidated { get; set; }

        [JsonProperty("lastOpenTime")]
        public string LastOpenTime { get; set; }

        [JsonProperty("lastOpenUserId")]
        public string LastOpenUserId { get; set; }

        [JsonProperty("isLocked")]
        public bool IsLocked { get; set; }

        [JsonProperty("validationTime")]
        public string ValidationTime { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("approvalState")]
        public ApprovalState ApprovalState { get; set; }

        [JsonProperty("currentApproverId")]
        public string CurrentApproverId { get; set; }

        [JsonProperty("lastApprovalStepTime")]
        public string LastApprovalStepTime { get; set; }

        [JsonProperty("isCurrentApproverNotificationSent")]
        public bool IsCurrentApproverNotificationSent { get; set; }

        [JsonProperty("approvalHistory")]
        public ApiApproval[] ApprovalHistory { get; set; }

        [JsonProperty("approvalReminderHistory")]
        public ApiApprovalReminder[] ApprovalReminderHistory { get; set; }

        [JsonProperty("authorizedUserIds")]
        public string[] AuthorizedUserIds { get; set; }

        [JsonProperty("duplicateDocIds")]
        public string[] DuplicateDocIds { get; set; }

        [JsonProperty("approvedBy")]
        public ApiUser ApprovedBy { get; set; }

        [JsonProperty("validatedBy")]
        public ApiUser ValidatedBy { get; set; }
    }

    public class ApiUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentState
    {
        Uploading,
        Uploaded,
        PreProcessed,
        Extracting,
        Extracted,
        Validated,
        Exported,
        Failed,
        UnsupportedType,
        NoLicense
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocumentSource
    {
        WebApp,
        Mail,
        API,
        Plugin
    }

    public class ApiPage
    {
        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("rotation")]
        public double Rotation { get; set; }

        [JsonProperty("words")]
        public ApiWord[] Words { get; set; }

        [JsonProperty("itemTable")]
        public ApiItemTable ItemTable { get; set; }
    }

    public class ApiWord
    {
        [JsonProperty("wordId")]
        public int WordId { get; set; }

        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("locX")]
        public int LocX { get; set; }

        [JsonProperty("locY")]
        public int LocY { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class ApiItemTable
    {
        [JsonProperty("pageIndex")]
        public int PageIndex { get; set; }

        [JsonProperty("offset")]
        public Offset Offset { get; set; }

        [JsonProperty("columns")]
        public ApiItemColumn[] Columns { get; set; }

        [JsonProperty("rows")]
        public ApiItemRow[] Rows { get; set; }
    }

    public class Offset
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class ApiItemColumn
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }
    }

    public class ApiItemRow
    {
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("cells")]
        public ApiItemCell[] Cells { get; set; }
    }

    public class ApiItemCell
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("modifiedByPostProcessing")]
        public bool ModifiedByPostProcessing { get; set; }

        [JsonProperty("pluginResults")]
        public ApiPluginResult[] PluginResults { get; set; }
    }

    public class ApiPluginResult
    {
        [JsonProperty("pluginName")]
        public string PluginName { get; set; }

        [JsonProperty("resultCode")]
        public PostProcessResult ResultCode { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("extraInformationRequired")]
        public bool ExtraInformationRequired { get; set; }

        [JsonProperty("extraInformationMessage")]
        public string ExtraInformationMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PostProcessResult
    {
        SUCCESS,
        FAILURE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ApprovalState
    {
        UNAPPROVED,
        PREAPPROVED,
        PREREJECTED,
        DELEGATED,
        ABANDONED,
        APPROVED,
        REJECTED
    }

    public class ApiApproval
    {
        [JsonProperty("approver")]
        public ApiUser Approver { get; set; }

        [JsonProperty("approvalStepTime")]
        public string ApprovalStepTime { get; set; }

        [JsonProperty("approvalState")]
        public ApprovalState ApprovalState { get; set; }

        [JsonProperty("delegatedTo")]
        public ApiUser DelegatedTo { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class ApiApprovalReminder
    {
        [JsonProperty("fromUser")]
        public ApiUser FromUser { get; set; }

        [JsonProperty("toUser")]
        public ApiUser ToUser { get; set; }

        [JsonProperty("sentTime")]
        public string SentTime { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }
    }

    public class ListAllDocumentsInput
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("filter")]
        public ApiDocumentFilter Filter { get; set; }

        [JsonProperty("control")]
        public ApiListControl Control { get; set; }

        [JsonProperty("sort")]
        public ApiDocumentListSortFieldsApiListSort Sort { get; set; }

        [JsonProperty("scopes")]
        public ApiDocumentScope[] Scopes { get; set; }
    }

    public class ApiDocumentFilter
    {
        [JsonProperty("fileName")]
        public StringApiFilterEqual FileName { get; set; }

        [JsonProperty("state")]
        public DocumentStateApiFilterMultipleChoice State { get; set; }

        [JsonProperty("approvalState")]
        public ApprovalStateApiFilterMultipleChoice ApprovalState { get; set; }

        [JsonProperty("type")]
        public StringApiFilterEqual Type { get; set; }

        [JsonProperty("sourceInfo")]
        public StringApiFilterNotEqual SourceInfo { get; set; }

        [JsonProperty("isPostProcessCompleted")]
        public BooleanApiFilterEqual IsPostProcessCompleted { get; set; }

        [JsonProperty("isReturnedToSender")]
        public BooleanApiFilterEqual IsReturnedToSender { get; set; }

        [JsonProperty("source")]
        public DocumentSourceApiFilterMultipleChoice Source { get; set; }

        [JsonProperty("ownerId")]
        public StringApiFilterMultipleChoice OwnerId { get; set; }

        [JsonProperty("validatorId")]
        public StringApiFilterMultipleChoice ValidatorId { get; set; }

        [JsonProperty("createdDate")]
        public DateTimeNullableApiFilterEqualRange CreatedDate { get; set; }

        [JsonProperty("validatedDate")]
        public DateTimeNullableApiFilterEqualRange ValidatedDate { get; set; }

        [JsonProperty("approvedDate")]
        public DateTimeNullableApiFilterEqualRange ApprovedDate { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class StringApiFilterEqual
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DocumentStateApiFilterMultipleChoice
    {
        [JsonProperty("values")]
        public DocumentState[] Values { get; set; }
    }

    public class ApprovalStateApiFilterMultipleChoice
    {
        [JsonProperty("values")]
        public ApprovalState[] Values { get; set; }
    }

    public class StringApiFilterNotEqual
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BooleanApiFilterEqual
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }

    public class DocumentSourceApiFilterMultipleChoice
    {
        [JsonProperty("values")]
        public DocumentSource[] Values { get; set; }
    }

    public class StringApiFilterMultipleChoice
    {
        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class DateTimeNullableApiFilterEqualRange
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }
    }

    public class ApiListControl
    {
        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("take")]
        public int Take { get; set; }
    }

    public class ApiDocumentListSortFieldsApiListSort
    {
        [JsonProperty("field")]
        public ApiDocumentListSortFields Field { get; set; }

        [JsonProperty("direction")]
        public ApiListSortDirection Direction { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ApiDocumentListSortFields
    {
        FileName,
        CreationTime,
        TotalAmount,
        IssuedByName
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ApiListSortDirection
    {
        Ascending,
        Descending
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ApiDocumentScope
    {
        Metadata,
        Approval,
        PluginResults,
        Fields,
        Words,
        Users
    }

    public class RedQueStatus
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class UpdateDocumentsInput
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("externalDocumentId")]
        public StringApiValueUpdate ExternalDocumentId { get; set; }

        [JsonProperty("containerId")]
        public StringApiValueUpdate ContainerId { get; set; }

        [JsonProperty("fileName")]
        public StringApiValueUpdate FileName { get; set; }

        [JsonProperty("contentType")]
        public StringApiValueUpdate ContentType { get; set; }

        [JsonProperty("source")]
        public DocumentSourceApiValueUpdate Source { get; set; }

        [JsonProperty("sourceInfo")]
        public StringApiValueUpdate SourceInfo { get; set; }

        [JsonProperty("documentClass")]
        public StringApiValueUpdate DocumentClass { get; set; }

        [JsonProperty("isAttachment")]
        public BooleanApiValueUpdate IsAttachment { get; set; }

        [JsonProperty("edited")]
        public BooleanApiValueUpdate Edited { get; set; }

        [JsonProperty("note")]
        public StringApiValueUpdate Note { get; set; }

        [JsonProperty("fields")]
        public ApiFieldValueUpdate[] Fields { get; set; }

        [JsonProperty("items")]
        public ApiFieldValueUpdate[][] Items { get; set; }

        [JsonProperty("validate")]
        public ApiValidateApiValueUpdate Validate { get; set; }

        [JsonProperty("approve")]
        public ApiApproveApiValueUpdate Approve { get; set; }

        [JsonProperty("authorizeUsers")]
        public StringApiListValueUpdate[] AuthorizeUsers { get; set; }

        [JsonProperty("duplicateDocIds")]
        public StringApiListValueUpdate[] DuplicateDocIds { get; set; }
    }

    public class StringApiValueUpdate
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DocumentSourceApiValueUpdate
    {
        [JsonProperty("value")]
        public DocumentSource Value { get; set; }
    }

    public class BooleanApiValueUpdate
    {
        [JsonProperty("value")]
        public bool Value { get; set; }
    }

    public class ApiFieldValueUpdate
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("operation")]
        public ApiListValueOperation Operation { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("isWarning")]
        public bool IsWarning { get; set; }

        [JsonProperty("wordIds")]
        public int[] WordIds { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ApiListValueOperation
    {
        Undefined,
        Add,
        AddIfNotExists,
        Set,
        Remove
    }

    public class ApiValidateApiValueUpdate
    {
        [JsonProperty("value")]
        public ApiValidate Value { get; set; }
    }

    public class ApiValidate
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class ApiApproveApiValueUpdate
    {
        [JsonProperty("value")]
        public ApiApprove Value { get; set; }
    }

    public class ApiApprove
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("state")]
        public ApprovalState State { get; set; }
    }

    public class StringApiListValueUpdate
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("operation")]
        public ApiListValueOperation Operation { get; set; }
    }

    public class GrantDocumentAccessInput
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("data")]
        public ApiDocumentGrantAccessRequest Data { get; set; }
    }

    public class ApiDocumentGrantAccessRequest
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ApiEnum
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public JToken Values { get; set; }

        [JsonProperty("isEditable")]
        public bool IsEditable { get; set; }
    }

    public class StringApiValue
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateEnumInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public JToken Values { get; set; }

        [JsonProperty("isEditable")]
        public bool? IsEditable { get; set; }
    }

    public class UpdateEnumInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public JToken Values { get; set; }

        [JsonProperty("isEditable")]
        public bool? IsEditable { get; set; }
    }

    public class ApiFolderCreationResult
    {
        [JsonProperty("folderId")]
        public string FolderId { get; set; }
    }

    public class ApiFolderWithMembers
    {
        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("members")]
        public ApiDocument[] Members { get; set; }
    }

    public class UpdateContainerDataInput
    {
        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class MLicense
    {
        [JsonProperty("responseCode")]
        public ResponseCode ResponseCode { get; set; }

        [JsonProperty("responseMessage")]
        public string ResponseMessage { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTo")]
        public string ValidTo { get; set; }

        [JsonProperty("nextPeriod")]
        public string NextPeriod { get; set; }

        [JsonProperty("usageLimit")]
        public int UsageLimit { get; set; }

        [JsonProperty("usageLimitPeriod")]
        public LicenseTimePeriod UsageLimitPeriod { get; set; }

        [JsonProperty("isTrial")]
        public bool IsTrial { get; set; }

        [JsonProperty("usageCount")]
        public int UsageCount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ResponseCode
    {
        NONE,
        OK,
        [EnumMember(Value = "NO_CONFIG_FILE")]
        NOCONFIGFILE,
        [EnumMember(Value = "INCOMPLETE_CONFIG_FILE")]
        INCOMPLETECONFIGFILE,
        [EnumMember(Value = "INVALID_CONFIG_FILE")]
        INVALIdCONFIGFILE,
        [EnumMember(Value = "UNREADABLE_CONFIG_FILE")]
        UNREADABLECONFIGFILE,
        [EnumMember(Value = "DATABASE_NOT_AVAILABLE")]
        DATABASENOTAVAILABLE,
        [EnumMember(Value = "DOCUMENT_STORAGE_NOT_AVAILABLE")]
        DOCUMENTSTORAGENOTAVAILABLE,
        [EnumMember(Value = "UNKNOWN_USER")]
        UNKNOWNUSER,
        [EnumMember(Value = "INTERNAL_ERROR")]
        INTERNALERROR,
        [EnumMember(Value = "USER_ALREADY_EXISTS")]
        USERALREADYEXISTS,
        [EnumMember(Value = "LICENSE_SERVER_ERROR")]
        LICENSESERVERERROR,
        [EnumMember(Value = "MODEL_CANT_BE_READ")]
        MODELCANTBEREAD,
        [EnumMember(Value = "NOT_AUTHENTICATED")]
        NOTAUTHENTICATED,
        [EnumMember(Value = "GROUP_ALREADY_EXISTS")]
        GROUPALREADYEXISTS,
        [EnumMember(Value = "UNKNOWN_GROUP")]
        UNKNOWNGROUP,
        [EnumMember(Value = "MODEL_BUILDING")]
        MODELBUILDING,
        [EnumMember(Value = "MODEL_CANT_BE_BUILT")]
        MODELCANTBEBUILT,
        [EnumMember(Value = "MODEL_STORAGE_NOT_AVAILABLE")]
        MODELSTORAGENOTAVAILABLE,
        [EnumMember(Value = "UNDEFINED_LANGUAGE")]
        UNDEFINEDLANGUAGE,
        [EnumMember(Value = "FORMAT_NOT_SUPPORTED")]
        FORMATNOTSUPPORTED,
        [EnumMember(Value = "DOCUMENT_SIZE_EXCEEDED")]
        DOCUMENTSIZEEXCEEDED,
        [EnumMember(Value = "DOCUMENT_NOT_FOUND")]
        DOCUMENTNOTFOUND,
        [EnumMember(Value = "DPI_NOT_SUFFICIENT")]
        DPINOTSUFFICIENT,
        [EnumMember(Value = "DOCUMENT_ALREADY_EXISTS")]
        DOCUMENTALREADYEXISTS,
        [EnumMember(Value = "MODEL_NOT_SPECIFIED")]
        MODELNOTSPECIFIED,
        [EnumMember(Value = "CLASS_NOT_EXISTS")]
        CLASSNOTEXISTS,
        [EnumMember(Value = "MODEL_NOT_FOUND")]
        MODELNOTFOUND,
        [EnumMember(Value = "USER_NOT_REGISTERED")]
        USERNOTREGISTERED,
        [EnumMember(Value = "PAGE_NOT_EXIST")]
        PAGENOTEXIST,
        [EnumMember(Value = "ATTACHMENT_NOT_VALID")]
        ATTACHMENTNOTVALId,
        [EnumMember(Value = "PLUGINS_CANT_BE_LOADED")]
        PLUGINSCANTBELOADED,
        [EnumMember(Value = "PLUGIN_NOT_FOUND")]
        PLUGINNOTFOUND,
        [EnumMember(Value = "DISABLED_FEATURE")]
        DISABLEDFEATURE,
        [EnumMember(Value = "METADATA_NOT_VALID")]
        METADATANOTVALId,
        [EnumMember(Value = "TRANSACTION_ABORTED")]
        TRANSACTIONABORTED,
        [EnumMember(Value = "AUTHBACKEND_INITIALIZATION_FAILED")]
        AUTHBACKENDINITIALIZATIONFAILED,
        [EnumMember(Value = "OUT_OF_MEMORY")]
        OUTOFMEMORY,
        [EnumMember(Value = "ENTITY_COULD_NOT_BE_SAVED")]
        ENTITYCOULDNOTBESAVED,
        [EnumMember(Value = "ENTITY_COULD_NOT_BE_LOADED")]
        ENTITYCOULDNOTBELOADED,
        [EnumMember(Value = "EXTRACTION_ERROR")]
        EXTRACTIONERROR,
        [EnumMember(Value = "TRANSACTION_INVALIDATED")]
        TRANSACTIONINVALIdATED,
        [EnumMember(Value = "SERVICE_NOT_AVAILABLE")]
        SERVICENOTAVAILABLE,
        [EnumMember(Value = "BACKEND_NOT_FOUND")]
        BACKENDNOTFOUND,
        [EnumMember(Value = "INCORRECT_DATA")]
        INCORRECTDATA,
        [EnumMember(Value = "USER_NOT_FOUND")]
        USERNOTFOUND,
        [EnumMember(Value = "PERMISSION_ALREADY_ASSIGNED")]
        PERMISSIONALREADYASSIGNED,
        [EnumMember(Value = "PERMISSION_NOT_FOUND")]
        PERMISSIONNOTFOUND,
        [EnumMember(Value = "ENTITY_ALREADY_EXISTS")]
        ENTITYALREADYEXISTS,
        [EnumMember(Value = "ENTITY_NOT_FOUND")]
        ENTITYNOTFOUND,
        [EnumMember(Value = "POSTPROCESSING_INITIALIZATION_FAILED")]
        POSTPROCESSINGINITIALIZATIONFAILED,
        [EnumMember(Value = "DOCUMENT_ALREADY_OPENED")]
        DOCUMENTALREADYOPENED,
        [EnumMember(Value = "DOCUMENT_OPENED_BY_ANOTHER_USER")]
        DOCUMENTOPENEDBYANOTHERUSER,
        [EnumMember(Value = "DOCUMENT_OLD_VERSION")]
        DOCUMENTOLDVERSION,
        [EnumMember(Value = "DOCUMENT_FILE_CORRUPTED")]
        DOCUMENTFILECORRUPTED,
        [EnumMember(Value = "DOCUMENT_FILE_PROTECTED")]
        DOCUMENTFILEPROTECTED,
        [EnumMember(Value = "POSTPROCESSING_PREVALIDATION_FAILED")]
        POSTPROCESSINGPREVALIdATIONFAILED,
        [EnumMember(Value = "TENANT_ALREADY_EXISTS")]
        TENANTALREADYEXISTS,
        [EnumMember(Value = "NOT_AUTHORIZED")]
        NOTAUTHORIZED,
        [EnumMember(Value = "EXPORT_NO_TEMPLATE")]
        EXPORTNOTEMPLATE,
        [EnumMember(Value = "EXPORT_FILL_ERROR")]
        EXPORTFILLERROR,
        [EnumMember(Value = "EXPORT_SAVE_ERROR")]
        EXPORTSAVEERROR,
        [EnumMember(Value = "EXPORT_REQUIRED_FIELD_MISSING")]
        EXPORTREQUIREDFIELDMISSING,
        [EnumMember(Value = "EXPORT_TEMPLATE_INVALID")]
        EXPORTTEMPLATEINVALId,
        [EnumMember(Value = "BATCH_EXPORT_NO_ROOT")]
        BATCHEXPORTNOROOT,
        [EnumMember(Value = "BATCH_EXPORT_NO_DOCS")]
        BATCHEXPORTNODOCS,
        [EnumMember(Value = "BATCH_EXPORT_TOO_MANY_DOCS")]
        BATCHEXPORTTOOMANYDOCS,
        [EnumMember(Value = "TENANT_NOT_FOUND")]
        TENANTNOTFOUND,
        [EnumMember(Value = "AUTH_BACKEND_ERROR")]
        AUTHBACKENDERROR,
        [EnumMember(Value = "REQUEST_INVALID")]
        REQUESTINVALId,
        [EnumMember(Value = "FIELD_INVALID")]
        FIELDINVALId,
        [EnumMember(Value = "REQUIRED_FIELD_MISSING")]
        REQUIREDFIELDMISSING,
        [EnumMember(Value = "FIELD_VALUE_INVALID")]
        FIELDVALUEINVALId,
        [EnumMember(Value = "FIELD_UNKNOWN")]
        FIELDUNKNOWN,
        [EnumMember(Value = "REQUEST_TIMEOUT")]
        REQUESTTIMEOUT,
        [EnumMember(Value = "NO_CHANGES")]
        NOCHANGES,
        [EnumMember(Value = "ENUM_UNKNOWN_KEY")]
        ENUMUNKNOWNKEY,
        [EnumMember(Value = "ENUM_MISSING_KEY")]
        ENUMMISSINGKEY,
        [EnumMember(Value = "ENUM_DUPLICATE_KEY")]
        ENUMDUPLICATEKEY,
        [EnumMember(Value = "VALIDATION_THRESHOLD_MET")]
        VALIdATIONTHRESHOLDMET,
        [EnumMember(Value = "VALIDATION_THRESHOLD_EXCEEDED")]
        VALIdATIONTHRESHOLDEXCEEDED,
        [EnumMember(Value = "USER_NOT_APPROVED")]
        USERNOTAPPROVED,
        [EnumMember(Value = "WHITELIST_ADDRESS_INVALID")]
        WHITELISTADDRESSINVALId,
        [EnumMember(Value = "WHITELIST_USER_ANOTHER_TENANT")]
        WHITELISTUSERANOTHERTENANT,
        [EnumMember(Value = "LICENSE_MISSING")]
        LICENSEMISSING,
        [EnumMember(Value = "LICENSE_EXPIRED")]
        LICENSEEXPIRED,
        [EnumMember(Value = "LICENSE_NOT_VALID_YET")]
        LICENSENOTVALIdYET,
        [EnumMember(Value = "LICENSE_USAGE_EXCEEDED")]
        LICENSEUSAGEEXCEEDED,
        [EnumMember(Value = "CONTAINER_PARTIALLY_REMOVED")]
        CONTAINERPARTIALLYREMOVED,
        [EnumMember(Value = "CONTAINER_CREATION_FAILED")]
        CONTAINERCREATIONFAILED,
        [EnumMember(Value = "CONTAINER_NOT_FOUND")]
        CONTAINERNOTFOUND,
        [EnumMember(Value = "CONTAINER_NOT_REMOVED")]
        CONTAINERNOTREMOVED,
        [EnumMember(Value = "DOCUMENT_NOT_RETURNED")]
        DOCUMENTNOTRETURNED,
        [EnumMember(Value = "DOCUMENT_RETURNED_NOT_SAVED")]
        DOCUMENTRETURNEDNOTSAVED,
        [EnumMember(Value = "DOCUMENT_NOT_READY")]
        DOCUMENTNOTREADY,
        [EnumMember(Value = "DOCUMENT_UNSUPPORTED_TYPE")]
        DOCUMENTUNSUPPORTEDTYPE,
        [EnumMember(Value = "DOCUMENT_EXTRACT_RESULT_NOT_FOUND")]
        DOCUMENTEXTRACTRESULTNOTFOUND,
        [EnumMember(Value = "DOCUMENT_FILE_NOT_FOUND")]
        DOCUMENTFILENOTFOUND,
        [EnumMember(Value = "DOCUMENT_FILE_UPLOAD_FAILED")]
        DOCUMENTFILEUPLOADFAILED,
        [EnumMember(Value = "DOCUMENT_FORBIDDEN_TYPE")]
        DOCUMENTFORBIdDENTYPE,
        [EnumMember(Value = "ATTACHMENT_NOT_ATTACHED")]
        ATTACHMENTNOTATTACHED,
        [EnumMember(Value = "PASSWORD_NOT_ACCEPTED")]
        PASSWORDNOTACCEPTED,
        [EnumMember(Value = "EMAIL_NOT_FOUND")]
        EMAILNOTFOUND,
        [EnumMember(Value = "NO_TEXT_DETECTED")]
        NOTEXTDETECTED,
        [EnumMember(Value = "ENTITY_DELETE_FAILED")]
        ENTITYDELETEFAILED
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LicenseTimePeriod
    {
        Day,
        Week,
        Month,
        Quarter,
        Year,
        Eternity
    }

    public class ApiUserApiListResult
    {
        [JsonProperty("list")]
        public ApiUser[] List { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }
    }

    public class ListOfUsersInput
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("filter")]
        public ApiUserFilter Filter { get; set; }

        [JsonProperty("control")]
        public ApiListControl Control { get; set; }

        [JsonProperty("sort")]
        public ApiUserSortListFieldsApiListSort Sort { get; set; }
    }

    public class ApiUserFilter
    {
        [JsonProperty("firstName")]
        public StringApiFilterEqual FirstName { get; set; }

        [JsonProperty("lastName")]
        public StringApiFilterEqual LastName { get; set; }

        [JsonProperty("email")]
        public StringApiFilterEqual Email { get; set; }
    }

    public class ApiUserSortListFieldsApiListSort
    {
        [JsonProperty("field")]
        public ApiUserSortListFields Field { get; set; }

        [JsonProperty("direction")]
        public ApiListSortDirection Direction { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ApiUserSortListFields
    {
        FirstName,
        LastName,
        Email
    }

    public class CreateUserInput
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class ForceUserPasswordChangeInput
    {
        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("activationkey")]
        public string Activationkey { get; set; }
    }

    public class UpdateUserInput
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class AddUserPermissionsInput
    {
        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }
    }

    public class RemoveUserPermissionsInput
    {
        [JsonProperty("permissions")]
        public string[] Permissions { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Redquesmartinvoiceca;

    public partial class WorkflowManagedActions
    {
        public RedquesmartinvoicecaActions Redquesmartinvoiceca(string connectionId) => new RedquesmartinvoicecaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RedquesmartinvoicecaTriggers Redquesmartinvoiceca(string connectionId) => new RedquesmartinvoicecaTriggers(connectionId);
    }
}