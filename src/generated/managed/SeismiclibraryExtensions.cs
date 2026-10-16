//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismiclibrary
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismiclibraryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> CreateLibraryFile(Expression<Func<string>> teamsiteId, Expression<Func<bool>> resolveNameCollision = null, Expression<Func<string>> metadata = null, Expression<Func<object>> content = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_resolveNameCollision = WorkflowExpression.Compile(resolveNameCollision, nameof(resolveNameCollision), required: false);
            var __workflow_metadata = WorkflowExpression.Compile(metadata, nameof(metadata), required: false);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resolveNameCollision"] = Convert.ToString(false);
                if (__workflow_resolveNameCollision != null)
                    callPayload.Queries["resolveNameCollision"] = ExpressionConverter.Convert(__workflow_resolveNameCollision);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> GetLibraryFileDetails(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> UpdateLibraryFile(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<bool>> includeResponse = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyexpiresAt = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null, Expression<Func<string>> bodyexternalId = null, Expression<Func<string>> bodyexternalConnectionId = null, Expression<Func<SeismicLibraryContentManagementContentExperts[]>> bodyexperts = null, Expression<Func<SeismicLibraryContentManagementCustomProperties[]>> bodycontentProperties = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_includeResponse = WorkflowExpression.Compile(includeResponse, nameof(includeResponse), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyexpiresAt = WorkflowExpression.Compile(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodyexternalConnectionId = WorkflowExpression.Compile(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            var __workflow_bodyexperts = WorkflowExpression.Compile(bodyexperts, nameof(bodyexperts), required: false);
            var __workflow_bodycontentProperties = WorkflowExpression.Compile(bodycontentProperties, nameof(bodycontentProperties), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeResponse"] = Convert.ToString(true);
                if (__workflow_includeResponse != null)
                    callPayload.Queries["includeResponse"] = ExpressionConverter.Convert(__workflow_includeResponse);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiresAt != null)
                {
                    body["expiresAt"] = ExpressionConverter.ConvertO(__workflow_bodyexpiresAt);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalConnectionId);
                    bodypropCount++;
                }

                if (__workflow_bodyexperts != null)
                {
                    body["experts"] = ExpressionConverter.ConvertO(__workflow_bodyexperts);
                    bodypropCount++;
                }

                if (__workflow_bodycontentProperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(__workflow_bodycontentProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp> DownloadLibraryFile(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<bool>> redirect = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_redirect = WorkflowExpression.Compile(redirect, nameof(redirect), required: false);
            return new DeferredBodyAction<SeismicCommonDownloadLocationResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(true);
                if (__workflow_redirect != null)
                    callPayload.Queries["redirect"] = ExpressionConverter.Convert(__workflow_redirect);
                return new ApiConnectionAction<SeismicCommonDownloadLocationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> CreateLibraryFileVersion(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<object>> content = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp> DownloadLibraryFileVersion(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> libraryVersionId, Expression<Func<bool>> redirect = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_libraryVersionId = WorkflowExpression.Compile(libraryVersionId, nameof(libraryVersionId), required: true);
            var __workflow_redirect = WorkflowExpression.Compile(redirect, nameof(redirect), required: false);
            return new DeferredBodyAction<SeismicCommonDownloadLocationResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}/versions/{2}/content", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryVersionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(true);
                if (__workflow_redirect != null)
                    callPayload.Queries["redirect"] = ExpressionConverter.Convert(__workflow_redirect);
                return new ApiConnectionAction<SeismicCommonDownloadLocationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> CopyLibraryFile(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> bodyparentFolderId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}/copy", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> CreateLibraryFolder(Expression<Func<string>> teamsiteId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyparentFolderId = null, Expression<Func<string>> bodyexternalId = null, Expression<Func<string>> bodyexternalConnectionId = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodyexternalConnectionId = WorkflowExpression.Compile(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalConnectionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> GetLibraryFolderDetails(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> UpdateLibraryFolder(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> bodyname, Expression<Func<string>> bodyparentFolderId = null, Expression<Func<string>> bodyexternalId = null, Expression<Func<string>> bodyexternalConnectionId = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodyexternalConnectionId = WorkflowExpression.Compile(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalConnectionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementNestedLibraryFoldersResponse> CreateNestedLibraryFolders(Expression<Func<string>> teamsiteId, Expression<Func<string>> folderPath = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementNestedLibraryFoldersResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/createPath", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionAction<SeismicLibraryContentManagementNestedLibraryFoldersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> CopyLibraryFolder(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> bodyparentFolderId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/{1}/copy", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicPagingLibraryContentManagementLibraryGenericItemDetailsResponse> GetLibraryFolderItems(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<bool>> includeExpiration = null, Expression<Func<bool>> includeProperties = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_includeExpiration = WorkflowExpression.Compile(includeExpiration, nameof(includeExpiration), required: false);
            var __workflow_includeProperties = WorkflowExpression.Compile(includeProperties, nameof(includeProperties), required: false);
            return new DeferredBodyAction<SeismicPagingLibraryContentManagementLibraryGenericItemDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["includeExpiration"] = Convert.ToString(false);
                if (__workflow_includeExpiration != null)
                    callPayload.Queries["includeExpiration"] = ExpressionConverter.Convert(__workflow_includeExpiration);
                callPayload.Queries["includeProperties"] = Convert.ToString(false);
                if (__workflow_includeProperties != null)
                    callPayload.Queries["includeProperties"] = ExpressionConverter.Convert(__workflow_includeProperties);
                return new ApiConnectionAction<SeismicPagingLibraryContentManagementLibraryGenericItemDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse> GetLibraryItemDetails(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IWorkflowAction DeleteLibraryItem(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse> CopyLibraryItem(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> bodyparentFolderId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/copy", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementSimpleItemVersion[]> GetLibraryItemVersion(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementSimpleItemVersion[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/versions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementSimpleItemVersion[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicCommonItemsOfSeismicLibraryContentManagementLibraryGenericItemDetailsResponse> GetLibraryItemsByQuery(Expression<Func<string>> teamsiteId, Expression<Func<string>> externalId = null, Expression<Func<string>> externalConnectionId = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: false);
            var __workflow_externalConnectionId = WorkflowExpression.Compile(externalConnectionId, nameof(externalConnectionId), required: false);
            return new DeferredBodyAction<SeismicCommonItemsOfSeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_externalId != null)
                    callPayload.Queries["externalId"] = ExpressionConverter.Convert(__workflow_externalId);
                if (__workflow_externalConnectionId != null)
                    callPayload.Queries["externalConnectionId"] = ExpressionConverter.Convert(__workflow_externalConnectionId);
                return new ApiConnectionAction<SeismicCommonItemsOfSeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<string> UpdateThumbnailItem(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/thumbnail", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicPagingLibraryInstructionsInstructionInfoResponse> GetLibraryInstructions(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<SeismicPagingLibraryInstructionsInstructionInfoResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/instructions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<SeismicPagingLibraryInstructionsInstructionInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryInstructionsInstructionInfoResponse> AddLibraryInstruction(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodytext = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodytext = WorkflowExpression.Compile(bodytext, nameof(bodytext), required: false);
            return new DeferredBodyAction<SeismicLibraryInstructionsInstructionInfoResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/instructions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryInstructionsInstructionInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IWorkflowAction DeleteLibraryInstruction(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> instructionId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_instructionId = WorkflowExpression.Compile(instructionId, nameof(instructionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/instructions/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_instructionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<string[]> SubmitLibraryItemToWorkflow(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> bodycomments = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/submit", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IWorkflowAction RecallItemFromWorkflow(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> bodycomments = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/recall", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryPublishingPublishResponse> PublishLibraryItems(Expression<Func<string>> teamsiteId, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodypublishAt = null, Expression<Func<SeismicContentManagerPublishContentItem[]>> bodycontent = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodypublishAt = WorkflowExpression.Compile(bodypublishAt, nameof(bodypublishAt), required: false);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: false);
            return new DeferredBodyAction<SeismicLibraryPublishingPublishResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/publish", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodypublishAt != null)
                {
                    body["publishAt"] = ExpressionConverter.ConvertO(__workflow_bodypublishAt);
                    bodypropCount++;
                }

                if (__workflow_bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryPublishingPublishResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IWorkflowAction UnpublishLibraryItem(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/unpublish", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryWorkflowWorkflowResponse> UpdateLibraryWorkflowStep(Expression<Func<string>> approvalWorkflowId, Expression<Func<string>> stepId, Expression<Func<bodyactionInput>> bodyaction = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodynextApprovernextApproverUsedId = null, Expression<Func<string>> bodynextApprovernextApproverUserType = null)
        {
            var __workflow_approvalWorkflowId = WorkflowExpression.Compile(approvalWorkflowId, nameof(approvalWorkflowId), required: true);
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: true);
            var __workflow_bodyaction = WorkflowExpression.Compile(bodyaction, nameof(bodyaction), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodynextApprovernextApproverUsedId = WorkflowExpression.Compile(bodynextApprovernextApproverUsedId, nameof(bodynextApprovernextApproverUsedId), required: false);
            var __workflow_bodynextApprovernextApproverUserType = WorkflowExpression.Compile(bodynextApprovernextApproverUserType, nameof(bodynextApprovernextApproverUserType), required: false);
            return new DeferredBodyAction<SeismicLibraryWorkflowWorkflowResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/approvalWorkflows/{0}/steps/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_approvalWorkflowId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_stepId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaction != null)
                {
                    body["action"] = ExpressionConverter.ConvertO(__workflow_bodyaction);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                var nextApproverObject = new JObject();
                var nextApproverObjectpropCount = 0;
                if (__workflow_bodynextApprovernextApproverUsedId != null)
                {
                    nextApproverObject["id"] = ExpressionConverter.ConvertO(__workflow_bodynextApprovernextApproverUsedId);
                    nextApproverObjectpropCount++;
                }

                if (__workflow_bodynextApprovernextApproverUserType != null)
                {
                    nextApproverObject["type"] = ExpressionConverter.ConvertO(__workflow_bodynextApprovernextApproverUserType);
                    nextApproverObjectpropCount++;
                }

                if (nextApproverObjectpropCount > 0)
                {
                    body["nextApprover"] = nextApproverObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryWorkflowWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryWorkflowWorkflowResponse> GetLibraryWorkflow(Expression<Func<string>> approvalWorkflowId)
        {
            var __workflow_approvalWorkflowId = WorkflowExpression.Compile(approvalWorkflowId, nameof(approvalWorkflowId), required: true);
            return new DeferredBodyAction<SeismicLibraryWorkflowWorkflowResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/approvalWorkflows/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_approvalWorkflowId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryWorkflowWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicPagingLibraryWorkflowWorkflowResponse> GetWorkflows(Expression<Func<string>> teamsiteId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> currentStepAssignedTo = null, Expression<Func<string>> status = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_currentStepAssignedTo = WorkflowExpression.Compile(currentStepAssignedTo, nameof(currentStepAssignedTo), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<SeismicPagingLibraryWorkflowWorkflowResponse>(() =>
            {
                var apiCallPath = "/approvalWorkflows";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_teamsiteId != null)
                    callPayload.Queries["teamsiteId"] = ExpressionConverter.Convert(__workflow_teamsiteId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_currentStepAssignedTo != null)
                    callPayload.Queries["currentStepAssignedTo"] = ExpressionConverter.Convert(__workflow_currentStepAssignedTo);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                return new ApiConnectionAction<SeismicPagingLibraryWorkflowWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> CreateLibraryUrl(Expression<Func<string>> teamsiteId, Expression<Func<string>> bodyformat = null, Expression<Func<string>> bodyurlurl = null, Expression<Func<bool>> bodyurlopenInNewWindow = null, Expression<Func<string>> bodyownerId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyexpiresAt = null, Expression<Func<string>> bodyexternalId = null, Expression<Func<string>> bodyexternalConnectionId = null, Expression<Func<SeismicLibraryContentManagementContentExperts[]>> bodyexperts = null, Expression<Func<SeismicLibraryContentManagementCustomProperties[]>> bodycontentProperties = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_bodyformat = WorkflowExpression.Compile(bodyformat, nameof(bodyformat), required: false);
            var __workflow_bodyurlurl = WorkflowExpression.Compile(bodyurlurl, nameof(bodyurlurl), required: false);
            var __workflow_bodyurlopenInNewWindow = WorkflowExpression.Compile(bodyurlopenInNewWindow, nameof(bodyurlopenInNewWindow), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyexpiresAt = WorkflowExpression.Compile(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodyexternalConnectionId = WorkflowExpression.Compile(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            var __workflow_bodyexperts = WorkflowExpression.Compile(bodyexperts, nameof(bodyexperts), required: false);
            var __workflow_bodycontentProperties = WorkflowExpression.Compile(bodycontentProperties, nameof(bodycontentProperties), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/urls", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyformat != null)
                {
                    body["format"] = ExpressionConverter.ConvertO(__workflow_bodyformat);
                    bodypropCount++;
                }

                var urlObject = new JObject();
                var urlObjectpropCount = 0;
                if (__workflow_bodyurlurl != null)
                {
                    urlObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyurlurl);
                    urlObjectpropCount++;
                }

                if (__workflow_bodyurlopenInNewWindow != null)
                {
                    urlObject["openInNewWindow"] = ExpressionConverter.ConvertO(__workflow_bodyurlopenInNewWindow);
                    urlObjectpropCount++;
                }

                if (urlObjectpropCount > 0)
                {
                    body["url"] = urlObject;
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiresAt != null)
                {
                    body["expiresAt"] = ExpressionConverter.ConvertO(__workflow_bodyexpiresAt);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalConnectionId);
                    bodypropCount++;
                }

                if (__workflow_bodyexperts != null)
                {
                    body["experts"] = ExpressionConverter.ConvertO(__workflow_bodyexperts);
                    bodypropCount++;
                }

                if (__workflow_bodycontentProperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(__workflow_bodycontentProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> GetLibraryUrlDetails(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/urls/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> UpdateLibraryUrl(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<bool>> includeResponse = null, Expression<Func<string>> bodyurlurl = null, Expression<Func<bool>> bodyurlopenInNewWindow = null, Expression<Func<string>> bodyownerId = null, Expression<Func<SeismicLibraryContentManagementContentExperts[]>> bodyexperts = null, Expression<Func<SeismicLibraryContentManagementCustomProperties[]>> bodycontentProperties = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyexpiresAt = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyparentFolderId = null, Expression<Func<string>> bodyexternalId = null, Expression<Func<string>> bodyexternalConnectionId = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_includeResponse = WorkflowExpression.Compile(includeResponse, nameof(includeResponse), required: false);
            var __workflow_bodyurlurl = WorkflowExpression.Compile(bodyurlurl, nameof(bodyurlurl), required: false);
            var __workflow_bodyurlopenInNewWindow = WorkflowExpression.Compile(bodyurlopenInNewWindow, nameof(bodyurlopenInNewWindow), required: false);
            var __workflow_bodyownerId = WorkflowExpression.Compile(bodyownerId, nameof(bodyownerId), required: false);
            var __workflow_bodyexperts = WorkflowExpression.Compile(bodyexperts, nameof(bodyexperts), required: false);
            var __workflow_bodycontentProperties = WorkflowExpression.Compile(bodycontentProperties, nameof(bodycontentProperties), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyexpiresAt = WorkflowExpression.Compile(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            var __workflow_bodyexternalId = WorkflowExpression.Compile(bodyexternalId, nameof(bodyexternalId), required: false);
            var __workflow_bodyexternalConnectionId = WorkflowExpression.Compile(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/urls/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeResponse"] = Convert.ToString(true);
                if (__workflow_includeResponse != null)
                    callPayload.Queries["includeResponse"] = ExpressionConverter.Convert(__workflow_includeResponse);
                var body = new JObject();
                var bodypropCount = 0;
                var urlObject = new JObject();
                var urlObjectpropCount = 0;
                if (__workflow_bodyurlurl != null)
                {
                    urlObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyurlurl);
                    urlObjectpropCount++;
                }

                if (__workflow_bodyurlopenInNewWindow != null)
                {
                    urlObject["openInNewWindow"] = ExpressionConverter.ConvertO(__workflow_bodyurlopenInNewWindow);
                    urlObjectpropCount++;
                }

                if (urlObjectpropCount > 0)
                {
                    body["url"] = urlObject;
                    bodypropCount++;
                }

                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (__workflow_bodyexperts != null)
                {
                    body["experts"] = ExpressionConverter.ConvertO(__workflow_bodyexperts);
                    bodypropCount++;
                }

                if (__workflow_bodycontentProperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(__workflow_bodycontentProperties);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiresAt != null)
                {
                    body["expiresAt"] = ExpressionConverter.ConvertO(__workflow_bodyexpiresAt);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalId);
                    bodypropCount++;
                }

                if (__workflow_bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = ExpressionConverter.ConvertO(__workflow_bodyexternalConnectionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> CopyLibraryUrl(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> bodyparentFolderId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_bodyparentFolderId = WorkflowExpression.Compile(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/urls/{1}/copy", ExpressionConverter.ConvertWithUrlEncoding(__workflow_teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentFolderId"] = ExpressionConverter.ConvertO(__workflow_bodyparentFolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(callPayload);
            });
        }
    }

    public class SeismiclibraryTriggers([ConnectionName] string connectionId)
    {
    }

    public class SeismicLibraryContentManagementLibraryFileDetailsResponse
    {
        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("assignedToProfiles")]
        public SeismicLibraryContentManagementContentProfile[] AssignedToProfiles { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("contentId")]
        public string ContentId { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("thumbnailId")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("experts")]
        public SeismicLibraryContentManagementContentExperts[] Experts { get; set; }

        [JsonProperty("properties")]
        public SeismicLibraryContentManagementCustomProperties[] ContentProperties { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public SeismicLibraryContentManagementEnumResponseType Type { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public SeismicCommonCreatedByUser CreatedBy { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public SeismicCommonModifiedByUser ModifiedBy { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalConnectionId")]
        public string ExternalConnectionId { get; set; }
    }

    public class SeismicLibraryContentManagementContentProfile
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SeismicLibraryContentManagementContentExperts
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SeismicLibraryContentManagementCustomProperties
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeismicLibraryContentManagementEnumResponseType
    {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "file")]
        File,
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "youtube")]
        Youtube,
        [EnumMember(Value = "vimeo")]
        Vimeo,
        [EnumMember(Value = "datasource")]
        Datasource,
        [EnumMember(Value = "livedoc")]
        Livedoc,
        [EnumMember(Value = "article")]
        Article,
        [EnumMember(Value = "livecomponent")]
        Livecomponent,
        [EnumMember(Value = "emailtemplate")]
        Emailtemplate,
        [EnumMember(Value = "emailcomponent")]
        Emailcomponent,
        [EnumMember(Value = "microapp")]
        Microapp
    }

    public class SeismicCommonCreatedByUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Name { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }
    }

    public class SeismicCommonModifiedByUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Name { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }
    }

    public class SeismicCommonDownloadLocationResp
    {
        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }
    }

    public class SeismicLibraryContentManagementLibraryFolderResponse
    {
        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public SeismicLibraryContentManagementEnumResponseType Type { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public SeismicCommonCreatedByUser CreatedBy { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public SeismicCommonModifiedByUser ModifiedBy { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalConnectionId")]
        public string ExternalConnectionId { get; set; }
    }

    public class SeismicLibraryContentManagementNestedLibraryFoldersResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public SeismicLibraryContentManagementNestedLibraryFoldersResponse[] Path { get; set; }
    }

    public class SeismicPagingLibraryContentManagementLibraryGenericItemDetailsResponse
    {
        [JsonProperty("entries")]
        public SeismicLibraryContentManagementLibraryGenericItemDetailsResponse[] Entries { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageCap")]
        public int PageCap { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }

        [JsonProperty("nextPageLink")]
        public string NextPageLink { get; set; }
    }

    public class SeismicLibraryContentManagementLibraryGenericItemDetailsResponse
    {
        [JsonProperty("url")]
        public SeismicLibraryContentManagementUrlInfo Url { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("assignedToProfiles")]
        public SeismicLibraryContentManagementContentProfile[] AssignedToProfiles { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("contentId")]
        public string ContentId { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("thumbnailId")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("experts")]
        public SeismicLibraryContentManagementContentExperts[] Experts { get; set; }

        [JsonProperty("properties")]
        public SeismicLibraryContentManagementCustomProperties[] ContentProperties { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public SeismicLibraryContentManagementEnumResponseType Type { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public SeismicCommonCreatedByUser CreatedBy { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public SeismicCommonModifiedByUser ModifiedBy { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalConnectionId")]
        public string ExternalConnectionId { get; set; }
    }

    public class SeismicLibraryContentManagementUrlInfo
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("openInNewWindow")]
        public bool OpenInNewWindow { get; set; }

        [JsonProperty("type")]
        public string UrlType { get; set; }
    }

    public class SeismicLibraryContentManagementSimpleItemVersion
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }
    }

    public class SeismicCommonItemsOfSeismicLibraryContentManagementLibraryGenericItemDetailsResponse
    {
        [JsonProperty("itemCount")]
        public int ItemCount { get; set; }

        [JsonProperty("items")]
        public SeismicLibraryContentManagementLibraryGenericItemDetailsResponse[] Items { get; set; }
    }

    public class SeismicPagingLibraryInstructionsInstructionInfoResponse
    {
        [JsonProperty("entries")]
        public SeismicLibraryInstructionsInstructionInfoResponse[] Entries { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageCap")]
        public int PageCap { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }

        [JsonProperty("nextPageLink")]
        public string NextPageLink { get; set; }
    }

    public class SeismicLibraryInstructionsInstructionInfoResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public SeismicLibraryInstructionsInstructionType Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeismicLibraryInstructionsInstructionType
    {
        [EnumMember(Value = "text")]
        Text
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeInput
    {
        [EnumMember(Value = "text")]
        Text
    }

    public class SeismicLibraryPublishingPublishResponse
    {
        [JsonProperty("totalRequests")]
        public int TotalRequests { get; set; }

        [JsonProperty("totalErrors")]
        public int TotalErrors { get; set; }

        [JsonProperty("totalSucceeded")]
        public int TotalSucceeded { get; set; }

        [JsonProperty("totalWarnings")]
        public int TotalWarnings { get; set; }

        [JsonProperty("errors")]
        public SeismicLibraryPublishingPublishResponseStatus[] Errors { get; set; }

        [JsonProperty("warnings")]
        public SeismicLibraryPublishingPublishResponseStatus[] Warnings { get; set; }
    }

    public class SeismicLibraryPublishingPublishResponseStatus
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class SeismicContentManagerPublishContentItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class SeismicLibraryWorkflowWorkflowResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("approvalProcess")]
        public SeismicLibraryWorkflowWorkflowApprovalProcess ApprovalProcess { get; set; }

        [JsonProperty("submittedOn")]
        public string SubmittedOn { get; set; }

        [JsonProperty("submittedBy")]
        public SeismicCommonSubmittedByUser SubmittedBy { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("libraryContent")]
        public SeismicLibraryWorkflowLibraryContent LibraryContent { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("stateChangedOn")]
        public string StateChangedOn { get; set; }

        [JsonProperty("steps")]
        public SeismicLibraryWorkflowWorkflowStep[] Steps { get; set; }
    }

    public class SeismicLibraryWorkflowWorkflowApprovalProcess
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SeismicCommonSubmittedByUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Name { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }
    }

    public class SeismicLibraryWorkflowLibraryContent
    {
        [JsonProperty("id")]
        public string LibraryContentId { get; set; }

        [JsonProperty("versionId")]
        public string LibraryContentVersionId { get; set; }

        [JsonProperty("type")]
        public string LibraryContentType { get; set; }

        [JsonProperty("name")]
        public string LibraryContentName { get; set; }

        [JsonProperty("teamsiteId")]
        public string LibraryContentTeamsiteId { get; set; }
    }

    public class SeismicLibraryWorkflowWorkflowStep
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("approveButtonLabel")]
        public string ApproveButtonLabel { get; set; }

        [JsonProperty("rejectButtonLabel")]
        public string RejectButtonLabel { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("assignedTo")]
        public SeismicLibraryWorkflowAssignedApprover AssignedTo { get; set; }

        [JsonProperty("approvers")]
        public SeismicLibraryWorkflowWorkflowApprover[] Approvers { get; set; }

        [JsonProperty("watchers")]
        public SeismicLibraryWorkflowWorkflowApprover[] Watchers { get; set; }

        [JsonProperty("stateChangedOn")]
        public string StateChangedOn { get; set; }

        [JsonProperty("stateChangedBy")]
        public SeismicCommonStateChangedByUser StateChangedBy { get; set; }
    }

    public class SeismicLibraryWorkflowAssignedApprover
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SeismicLibraryWorkflowWorkflowApprover
    {
        [JsonProperty("id")]
        public string UsedId { get; set; }

        [JsonProperty("type")]
        public string UserType { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefaultUser { get; set; }
    }

    public class SeismicCommonStateChangedByUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Name { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyactionInput
    {
        [EnumMember(Value = "approve")]
        Approve,
        [EnumMember(Value = "reject")]
        Reject,
        [EnumMember(Value = "revoke")]
        Revoke
    }

    public class SeismicPagingLibraryWorkflowWorkflowResponse
    {
        [JsonProperty("entries")]
        public SeismicLibraryWorkflowWorkflowResponse[] Entries { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageCap")]
        public int PageCap { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }

        [JsonProperty("nextPageLink")]
        public string NextPageLink { get; set; }
    }

    public class SeismicLibraryContentManagementLibraryUrlDetailsResponse
    {
        [JsonProperty("url")]
        public SeismicLibraryContentManagementUrlInfo Url { get; set; }

        [JsonProperty("assignedToProfiles")]
        public SeismicLibraryContentManagementContentProfile[] AssignedToProfiles { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("contentId")]
        public string ContentId { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("thumbnailId")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("experts")]
        public SeismicLibraryContentManagementContentExperts[] Experts { get; set; }

        [JsonProperty("properties")]
        public SeismicLibraryContentManagementCustomProperties[] ContentProperties { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public SeismicLibraryContentManagementEnumResponseType Type { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public SeismicCommonCreatedByUser CreatedBy { get; set; }

        [JsonProperty("modifiedAt")]
        public string ModifiedAt { get; set; }

        [JsonProperty("modifiedBy")]
        public SeismicCommonModifiedByUser ModifiedBy { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalConnectionId")]
        public string ExternalConnectionId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Seismiclibrary;

    public partial class WorkflowManagedActions
    {
        public SeismiclibraryActions Seismiclibrary(string connectionId) => new SeismiclibraryActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SeismiclibraryTriggers Seismiclibrary(string connectionId) => new SeismiclibraryTriggers(connectionId);
    }
}
