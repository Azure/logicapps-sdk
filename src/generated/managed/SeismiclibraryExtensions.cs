//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismiclibrary
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismiclibraryActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildCreateLibraryFile))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> CreateLibraryFile([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<bool> resolveNameCollision = null, [WorkflowExpression] Func<string> metadata = null, [WorkflowExpression] Func<object> content = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> __BuildCreateLibraryFile(WorkflowExpression<string> teamsiteId, WorkflowExpression<bool> resolveNameCollision = null, WorkflowExpression<string> metadata = null, WorkflowExpression<object> content = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(resolveNameCollision, nameof(resolveNameCollision), required: false);
            WorkflowExpression.Validate(metadata, nameof(metadata), required: false);
            WorkflowExpression.Validate(content, nameof(content), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resolveNameCollision"] = Convert.ToString(false);
                if (resolveNameCollision != null)
                    callPayload.Queries["resolveNameCollision"] = ExpressionConverter.Convert(resolveNameCollision);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildGetLibraryFileDetails))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> GetLibraryFileDetails([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> __BuildGetLibraryFileDetails(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateLibraryFile))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> UpdateLibraryFile([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<bool> includeResponse = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyexpiresAt = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodyexternalConnectionId = null, [WorkflowExpression] Func<SeismicLibraryContentManagementContentExperts[]> bodyexperts = null, [WorkflowExpression] Func<SeismicLibraryContentManagementCustomProperties[]> bodycontentProperties = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> __BuildUpdateLibraryFile(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<bool> includeResponse = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyexpiresAt = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyparentFolderId = null, WorkflowExpression<string> bodyexternalId = null, WorkflowExpression<string> bodyexternalConnectionId = null, WorkflowExpression<SeismicLibraryContentManagementContentExperts[]> bodyexperts = null, WorkflowExpression<SeismicLibraryContentManagementCustomProperties[]> bodycontentProperties = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(includeResponse, nameof(includeResponse), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            WorkflowExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            WorkflowExpression.Validate(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            WorkflowExpression.Validate(bodyexperts, nameof(bodyexperts), required: false);
            WorkflowExpression.Validate(bodycontentProperties, nameof(bodycontentProperties), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeResponse"] = Convert.ToString(true);
                if (includeResponse != null)
                    callPayload.Queries["includeResponse"] = ExpressionConverter.Convert(includeResponse);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyexpiresAt != null)
                {
                    body["expiresAt"] = ExpressionConverter.ConvertO(bodyexpiresAt);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = ExpressionConverter.ConvertO(bodyexternalConnectionId);
                    bodypropCount++;
                }

                if (bodyexperts != null)
                {
                    body["experts"] = ExpressionConverter.ConvertO(bodyexperts);
                    bodypropCount++;
                }

                if (bodycontentProperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodycontentProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildDownloadLibraryFile))]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp> DownloadLibraryFile([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<bool> redirect = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp> __BuildDownloadLibraryFile(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<bool> redirect = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(redirect, nameof(redirect), required: false);
            return new DeferredBodyAction<SeismicCommonDownloadLocationResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(true);
                if (redirect != null)
                    callPayload.Queries["redirect"] = ExpressionConverter.Convert(redirect);
                return new ApiConnectionAction<SeismicCommonDownloadLocationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildCreateLibraryFileVersion))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> CreateLibraryFileVersion([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<object> content = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> __BuildCreateLibraryFileVersion(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<object> content = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(content, nameof(content), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadLibraryFileVersion))]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp> DownloadLibraryFileVersion([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> libraryVersionId, [WorkflowExpression] Func<bool> redirect = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp> __BuildDownloadLibraryFileVersion(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<string> libraryVersionId, WorkflowExpression<bool> redirect = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(libraryVersionId, nameof(libraryVersionId), required: true);
            WorkflowExpression.Validate(redirect, nameof(redirect), required: false);
            return new DeferredBodyAction<SeismicCommonDownloadLocationResp>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}/versions/{2}/content", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryVersionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(true);
                if (redirect != null)
                    callPayload.Queries["redirect"] = ExpressionConverter.Convert(redirect);
                return new ApiConnectionAction<SeismicCommonDownloadLocationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildCopyLibraryFile))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> CopyLibraryFile([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodyparentFolderId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> __BuildCopyLibraryFile(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<string> bodyparentFolderId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}/copy", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildCreateLibraryFolder))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> CreateLibraryFolder([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyparentFolderId = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodyexternalConnectionId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> __BuildCreateLibraryFolder(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyparentFolderId = null, WorkflowExpression<string> bodyexternalId = null, WorkflowExpression<string> bodyexternalConnectionId = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            WorkflowExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            WorkflowExpression.Validate(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = ExpressionConverter.ConvertO(bodyexternalConnectionId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetLibraryFolderDetails))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> GetLibraryFolderDetails([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> __BuildGetLibraryFolderDetails(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateLibraryFolder))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> UpdateLibraryFolder([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyparentFolderId = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodyexternalConnectionId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> __BuildUpdateLibraryFolder(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyparentFolderId = null, WorkflowExpression<string> bodyexternalId = null, WorkflowExpression<string> bodyexternalConnectionId = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            WorkflowExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            WorkflowExpression.Validate(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = ExpressionConverter.ConvertO(bodyexternalConnectionId);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateNestedLibraryFolders))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementNestedLibraryFoldersResponse> CreateNestedLibraryFolders([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> folderPath = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementNestedLibraryFoldersResponse> __BuildCreateNestedLibraryFolders(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> folderPath = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(folderPath, nameof(folderPath), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementNestedLibraryFoldersResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/createPath", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(folderPath);
                return new ApiConnectionAction<SeismicLibraryContentManagementNestedLibraryFoldersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildCopyLibraryFolder))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> CopyLibraryFolder([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodyparentFolderId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> __BuildCopyLibraryFolder(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<string> bodyparentFolderId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFolderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/{1}/copy", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildGetLibraryFolderItems))]
        public IBodyWorkflowAction<SeismicPagingLibraryContentManagementLibraryGenericItemDetailsResponse> GetLibraryFolderItems([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> includeExpiration = null, [WorkflowExpression] Func<bool> includeProperties = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicPagingLibraryContentManagementLibraryGenericItemDetailsResponse> __BuildGetLibraryFolderItems(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null, WorkflowExpression<bool> includeExpiration = null, WorkflowExpression<bool> includeProperties = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(includeExpiration, nameof(includeExpiration), required: false);
            WorkflowExpression.Validate(includeProperties, nameof(includeProperties), required: false);
            return new DeferredBodyAction<SeismicPagingLibraryContentManagementLibraryGenericItemDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["includeExpiration"] = Convert.ToString(false);
                if (includeExpiration != null)
                    callPayload.Queries["includeExpiration"] = ExpressionConverter.Convert(includeExpiration);
                callPayload.Queries["includeProperties"] = Convert.ToString(false);
                if (includeProperties != null)
                    callPayload.Queries["includeProperties"] = ExpressionConverter.Convert(includeProperties);
                return new ApiConnectionAction<SeismicPagingLibraryContentManagementLibraryGenericItemDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildGetLibraryItemDetails))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse> GetLibraryItemDetails([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse> __BuildGetLibraryItemDetails(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteLibraryItem))]
        public IWorkflowAction DeleteLibraryItem([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteLibraryItem(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildCopyLibraryItem))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse> CopyLibraryItem([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodyparentFolderId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse> __BuildCopyLibraryItem(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<string> bodyparentFolderId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/copy", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildGetLibraryItemVersion))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementSimpleItemVersion[]> GetLibraryItemVersion([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementSimpleItemVersion[]> __BuildGetLibraryItemVersion(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementSimpleItemVersion[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/versions", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementSimpleItemVersion[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildGetLibraryItemsByQuery))]
        public IBodyWorkflowAction<SeismicCommonItemsOfSeismicLibraryContentManagementLibraryGenericItemDetailsResponse> GetLibraryItemsByQuery([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> externalId = null, [WorkflowExpression] Func<string> externalConnectionId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicCommonItemsOfSeismicLibraryContentManagementLibraryGenericItemDetailsResponse> __BuildGetLibraryItemsByQuery(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> externalId = null, WorkflowExpression<string> externalConnectionId = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(externalId, nameof(externalId), required: false);
            WorkflowExpression.Validate(externalConnectionId, nameof(externalConnectionId), required: false);
            return new DeferredBodyAction<SeismicCommonItemsOfSeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (externalId != null)
                    callPayload.Queries["externalId"] = ExpressionConverter.Convert(externalId);
                if (externalConnectionId != null)
                    callPayload.Queries["externalConnectionId"] = ExpressionConverter.Convert(externalConnectionId);
                return new ApiConnectionAction<SeismicCommonItemsOfSeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateThumbnailItem))]
        public IBodyWorkflowAction<string> UpdateThumbnailItem([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildUpdateThumbnailItem(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/thumbnail", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildGetLibraryInstructions))]
        public IBodyWorkflowAction<SeismicPagingLibraryInstructionsInstructionInfoResponse> GetLibraryInstructions([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicPagingLibraryInstructionsInstructionInfoResponse> __BuildGetLibraryInstructions(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<int> offset = null, WorkflowExpression<int> limit = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            return new DeferredBodyAction<SeismicPagingLibraryInstructionsInstructionInfoResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/instructions", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                return new ApiConnectionAction<SeismicPagingLibraryInstructionsInstructionInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildAddLibraryInstruction))]
        public IBodyWorkflowAction<SeismicLibraryInstructionsInstructionInfoResponse> AddLibraryInstruction([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodytext = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryInstructionsInstructionInfoResponse> __BuildAddLibraryInstruction(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<bodytypeInput> bodytype = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodytext = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodytext, nameof(bodytext), required: false);
            return new DeferredBodyAction<SeismicLibraryInstructionsInstructionInfoResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/instructions", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(bodytype);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(bodytext);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteLibraryInstruction))]
        public IWorkflowAction DeleteLibraryInstruction([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> instructionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteLibraryInstruction(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<string> instructionId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(instructionId, nameof(instructionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/instructions/{2}", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1), ExpressionConverter.ConvertWithUrlEncoding(instructionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildSubmitLibraryItemToWorkflow))]
        public IBodyWorkflowAction<string[]> SubmitLibraryItemToWorkflow([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodycomments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildSubmitLibraryItemToWorkflow(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<string> bodycomments = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/submit", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
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
        [WorkflowExpressionFactory(nameof(__BuildRecallItemFromWorkflow))]
        public IWorkflowAction RecallItemFromWorkflow([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodycomments = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRecallItemFromWorkflow(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<string> bodycomments = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/recall", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomments != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(bodycomments);
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
        [WorkflowExpressionFactory(nameof(__BuildPublishLibraryItems))]
        public IBodyWorkflowAction<SeismicLibraryPublishingPublishResponse> PublishLibraryItems([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodypublishAt = null, [WorkflowExpression] Func<SeismicContentManagerPublishContentItem[]> bodycontent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryPublishingPublishResponse> __BuildPublishLibraryItems(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> bodycomment = null, WorkflowExpression<string> bodypublishAt = null, WorkflowExpression<SeismicContentManagerPublishContentItem[]> bodycontent = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowExpression.Validate(bodypublishAt, nameof(bodypublishAt), required: false);
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            return new DeferredBodyAction<SeismicLibraryPublishingPublishResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/publish", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                    bodypropCount++;
                }

                if (bodypublishAt != null)
                {
                    body["publishAt"] = ExpressionConverter.ConvertO(bodypublishAt);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = ExpressionConverter.ConvertO(bodycontent);
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
        [WorkflowExpressionFactory(nameof(__BuildUnpublishLibraryItem))]
        public IWorkflowAction UnpublishLibraryItem([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUnpublishLibraryItem(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/unpublish", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateLibraryWorkflowStep))]
        public IBodyWorkflowAction<SeismicLibraryWorkflowWorkflowResponse> UpdateLibraryWorkflowStep([WorkflowExpression] Func<string> approvalWorkflowId, [WorkflowExpression] Func<string> stepId, [WorkflowExpression] Func<bodyactionInput> bodyaction = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodynextApprovernextApproverUsedId = null, [WorkflowExpression] Func<string> bodynextApprovernextApproverUserType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryWorkflowWorkflowResponse> __BuildUpdateLibraryWorkflowStep(WorkflowExpression<string> approvalWorkflowId, WorkflowExpression<string> stepId, WorkflowExpression<bodyactionInput> bodyaction = null, WorkflowExpression<string> bodycomment = null, WorkflowExpression<string> bodynextApprovernextApproverUsedId = null, WorkflowExpression<string> bodynextApprovernextApproverUserType = null)
        {
            WorkflowExpression.Validate(approvalWorkflowId, nameof(approvalWorkflowId), required: true);
            WorkflowExpression.Validate(stepId, nameof(stepId), required: true);
            WorkflowExpression.Validate(bodyaction, nameof(bodyaction), required: false);
            WorkflowExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            WorkflowExpression.Validate(bodynextApprovernextApproverUsedId, nameof(bodynextApprovernextApproverUsedId), required: false);
            WorkflowExpression.Validate(bodynextApprovernextApproverUserType, nameof(bodynextApprovernextApproverUserType), required: false);
            return new DeferredBodyAction<SeismicLibraryWorkflowWorkflowResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/approvalWorkflows/{0}/steps/{1}", ExpressionConverter.ConvertWithUrlEncoding(approvalWorkflowId, 1), ExpressionConverter.ConvertWithUrlEncoding(stepId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaction != null)
                {
                    body["action"] = ExpressionConverter.ConvertO(bodyaction);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                    bodypropCount++;
                }

                var nextApproverObject = new JObject();
                var nextApproverObjectpropCount = 0;
                if (bodynextApprovernextApproverUsedId != null)
                {
                    nextApproverObject["id"] = ExpressionConverter.ConvertO(bodynextApprovernextApproverUsedId);
                    nextApproverObjectpropCount++;
                }

                if (bodynextApprovernextApproverUserType != null)
                {
                    nextApproverObject["type"] = ExpressionConverter.ConvertO(bodynextApprovernextApproverUserType);
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
        [WorkflowExpressionFactory(nameof(__BuildGetLibraryWorkflow))]
        public IBodyWorkflowAction<SeismicLibraryWorkflowWorkflowResponse> GetLibraryWorkflow([WorkflowExpression] Func<string> approvalWorkflowId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryWorkflowWorkflowResponse> __BuildGetLibraryWorkflow(WorkflowExpression<string> approvalWorkflowId)
        {
            WorkflowExpression.Validate(approvalWorkflowId, nameof(approvalWorkflowId), required: true);
            return new DeferredBodyAction<SeismicLibraryWorkflowWorkflowResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/approvalWorkflows/{0}", ExpressionConverter.ConvertWithUrlEncoding(approvalWorkflowId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryWorkflowWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildGetWorkflows))]
        public IBodyWorkflowAction<SeismicPagingLibraryWorkflowWorkflowResponse> GetWorkflows([WorkflowExpression] Func<string> teamsiteId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> currentStepAssignedTo = null, [WorkflowExpression] Func<string> status = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicPagingLibraryWorkflowWorkflowResponse> __BuildGetWorkflows(WorkflowExpression<string> teamsiteId = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<string> currentStepAssignedTo = null, WorkflowExpression<string> status = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(currentStepAssignedTo, nameof(currentStepAssignedTo), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            return new DeferredBodyAction<SeismicPagingLibraryWorkflowWorkflowResponse>(() =>
            {
                var apiCallPath = "/approvalWorkflows";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (teamsiteId != null)
                    callPayload.Queries["teamsiteId"] = ExpressionConverter.Convert(teamsiteId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (currentStepAssignedTo != null)
                    callPayload.Queries["currentStepAssignedTo"] = ExpressionConverter.Convert(currentStepAssignedTo);
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                return new ApiConnectionAction<SeismicPagingLibraryWorkflowWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildCreateLibraryUrl))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> CreateLibraryUrl([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> bodyformat = null, [WorkflowExpression] Func<string> bodyurlurl = null, [WorkflowExpression] Func<bool> bodyurlopenInNewWindow = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyexpiresAt = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodyexternalConnectionId = null, [WorkflowExpression] Func<SeismicLibraryContentManagementContentExperts[]> bodyexperts = null, [WorkflowExpression] Func<SeismicLibraryContentManagementCustomProperties[]> bodycontentProperties = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> __BuildCreateLibraryUrl(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> bodyformat = null, WorkflowExpression<string> bodyurlurl = null, WorkflowExpression<bool> bodyurlopenInNewWindow = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyparentFolderId = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyexpiresAt = null, WorkflowExpression<string> bodyexternalId = null, WorkflowExpression<string> bodyexternalConnectionId = null, WorkflowExpression<SeismicLibraryContentManagementContentExperts[]> bodyexperts = null, WorkflowExpression<SeismicLibraryContentManagementCustomProperties[]> bodycontentProperties = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(bodyformat, nameof(bodyformat), required: false);
            WorkflowExpression.Validate(bodyurlurl, nameof(bodyurlurl), required: false);
            WorkflowExpression.Validate(bodyurlopenInNewWindow, nameof(bodyurlopenInNewWindow), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            WorkflowExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            WorkflowExpression.Validate(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            WorkflowExpression.Validate(bodyexperts, nameof(bodyexperts), required: false);
            WorkflowExpression.Validate(bodycontentProperties, nameof(bodycontentProperties), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/urls", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyformat != null)
                {
                    body["format"] = ExpressionConverter.ConvertO(bodyformat);
                    bodypropCount++;
                }

                var urlObject = new JObject();
                var urlObjectpropCount = 0;
                if (bodyurlurl != null)
                {
                    urlObject["url"] = ExpressionConverter.ConvertO(bodyurlurl);
                    urlObjectpropCount++;
                }

                if (bodyurlopenInNewWindow != null)
                {
                    urlObject["openInNewWindow"] = ExpressionConverter.ConvertO(bodyurlopenInNewWindow);
                    urlObjectpropCount++;
                }

                if (urlObjectpropCount > 0)
                {
                    body["url"] = urlObject;
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyexpiresAt != null)
                {
                    body["expiresAt"] = ExpressionConverter.ConvertO(bodyexpiresAt);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = ExpressionConverter.ConvertO(bodyexternalConnectionId);
                    bodypropCount++;
                }

                if (bodyexperts != null)
                {
                    body["experts"] = ExpressionConverter.ConvertO(bodyexperts);
                    bodypropCount++;
                }

                if (bodycontentProperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodycontentProperties);
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
        [WorkflowExpressionFactory(nameof(__BuildGetLibraryUrlDetails))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> GetLibraryUrlDetails([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> __BuildGetLibraryUrlDetails(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/urls/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateLibraryUrl))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> UpdateLibraryUrl([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<bool> includeResponse = null, [WorkflowExpression] Func<string> bodyurlurl = null, [WorkflowExpression] Func<bool> bodyurlopenInNewWindow = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<SeismicLibraryContentManagementContentExperts[]> bodyexperts = null, [WorkflowExpression] Func<SeismicLibraryContentManagementCustomProperties[]> bodycontentProperties = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyexpiresAt = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodyexternalConnectionId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> __BuildUpdateLibraryUrl(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<bool> includeResponse = null, WorkflowExpression<string> bodyurlurl = null, WorkflowExpression<bool> bodyurlopenInNewWindow = null, WorkflowExpression<string> bodyownerId = null, WorkflowExpression<SeismicLibraryContentManagementContentExperts[]> bodyexperts = null, WorkflowExpression<SeismicLibraryContentManagementCustomProperties[]> bodycontentProperties = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyexpiresAt = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyparentFolderId = null, WorkflowExpression<string> bodyexternalId = null, WorkflowExpression<string> bodyexternalConnectionId = null)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(includeResponse, nameof(includeResponse), required: false);
            WorkflowExpression.Validate(bodyurlurl, nameof(bodyurlurl), required: false);
            WorkflowExpression.Validate(bodyurlopenInNewWindow, nameof(bodyurlopenInNewWindow), required: false);
            WorkflowExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            WorkflowExpression.Validate(bodyexperts, nameof(bodyexperts), required: false);
            WorkflowExpression.Validate(bodycontentProperties, nameof(bodycontentProperties), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            WorkflowExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            WorkflowExpression.Validate(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/urls/{1}", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeResponse"] = Convert.ToString(true);
                if (includeResponse != null)
                    callPayload.Queries["includeResponse"] = ExpressionConverter.Convert(includeResponse);
                var body = new JObject();
                var bodypropCount = 0;
                var urlObject = new JObject();
                var urlObjectpropCount = 0;
                if (bodyurlurl != null)
                {
                    urlObject["url"] = ExpressionConverter.ConvertO(bodyurlurl);
                    urlObjectpropCount++;
                }

                if (bodyurlopenInNewWindow != null)
                {
                    urlObject["openInNewWindow"] = ExpressionConverter.ConvertO(bodyurlopenInNewWindow);
                    urlObjectpropCount++;
                }

                if (urlObjectpropCount > 0)
                {
                    body["url"] = urlObject;
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
                    bodypropCount++;
                }

                if (bodyexperts != null)
                {
                    body["experts"] = ExpressionConverter.ConvertO(bodyexperts);
                    bodypropCount++;
                }

                if (bodycontentProperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodycontentProperties);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyexpiresAt != null)
                {
                    body["expiresAt"] = ExpressionConverter.ConvertO(bodyexpiresAt);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["externalId"] = ExpressionConverter.ConvertO(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = ExpressionConverter.ConvertO(bodyexternalConnectionId);
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
        [WorkflowExpressionFactory(nameof(__BuildCopyLibraryUrl))]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> CopyLibraryUrl([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodyparentFolderId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> __BuildCopyLibraryUrl(WorkflowExpression<string> teamsiteId, WorkflowExpression<string> libraryContentId, WorkflowExpression<string> bodyparentFolderId)
        {
            WorkflowExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            WorkflowExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            WorkflowExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/urls/{1}/copy", ExpressionConverter.ConvertWithUrlEncoding(teamsiteId, 1), ExpressionConverter.ConvertWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
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