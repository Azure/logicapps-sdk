//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seismiclibrary
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeismiclibraryActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> CreateLibraryFile([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<bool> resolveNameCollision = null, [WorkflowExpression] Func<string> metadata = null, [WorkflowExpression] Func<object> content = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(resolveNameCollision, nameof(resolveNameCollision), required: false);
            SourceExpression.Validate(metadata, nameof(metadata), required: false);
            SourceExpression.Validate(content, nameof(content), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["resolveNameCollision"] = Convert.ToString(false);
                if (resolveNameCollision != null)
                    callPayload.Queries["resolveNameCollision"] = SourceExpressionConverter.ConvertO(resolveNameCollision);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> GetLibraryFileDetails([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> UpdateLibraryFile([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<bool> includeResponse = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyexpiresAt = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodyexternalConnectionId = null, [WorkflowExpression] Func<SeismicLibraryContentManagementContentExperts[]> bodyexperts = null, [WorkflowExpression] Func<SeismicLibraryContentManagementCustomProperties[]> bodycontentProperties = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(includeResponse, nameof(includeResponse), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            SourceExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            SourceExpression.Validate(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            SourceExpression.Validate(bodyexperts, nameof(bodyexperts), required: false);
            SourceExpression.Validate(bodycontentProperties, nameof(bodycontentProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeResponse"] = Convert.ToString(true);
                if (includeResponse != null)
                    callPayload.Queries["includeResponse"] = SourceExpressionConverter.ConvertO(includeResponse);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyexpiresAt != null)
                {
                    body["expiresAt"] = SourceExpressionConverter.ConvertToken(bodyexpiresAt);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["externalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = SourceExpressionConverter.ConvertToken(bodyexternalConnectionId);
                    bodypropCount++;
                }

                if (bodyexperts != null)
                {
                    body["experts"] = SourceExpressionConverter.ConvertToken(bodyexperts);
                    bodypropCount++;
                }

                if (bodycontentProperties != null)
                {
                    body["properties"] = SourceExpressionConverter.ConvertToken(bodycontentProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp> DownloadLibraryFile([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<bool> redirect = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(redirect, nameof(redirect), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(true);
                if (redirect != null)
                    callPayload.Queries["redirect"] = SourceExpressionConverter.ConvertO(redirect);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicCommonDownloadLocationResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> CreateLibraryFileVersion([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<object> content = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(content, nameof(content), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp> DownloadLibraryFileVersion([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> libraryVersionId, [WorkflowExpression] Func<bool> redirect = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(libraryVersionId, nameof(libraryVersionId), required: true);
            SourceExpression.Validate(redirect, nameof(redirect), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}/versions/{2}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryVersionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(true);
                if (redirect != null)
                    callPayload.Queries["redirect"] = SourceExpressionConverter.ConvertO(redirect);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicCommonDownloadLocationResp>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse> CopyLibraryFile([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodyparentFolderId)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/files/{1}/copy", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> CreateLibraryFolder([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyparentFolderId = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodyexternalConnectionId = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            SourceExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            SourceExpression.Validate(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["externalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = SourceExpressionConverter.ConvertToken(bodyexternalConnectionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> GetLibraryFolderDetails([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> UpdateLibraryFolder([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyparentFolderId = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodyexternalConnectionId = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            SourceExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            SourceExpression.Validate(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["externalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = SourceExpressionConverter.ConvertToken(bodyexternalConnectionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementNestedLibraryFoldersResponse> CreateNestedLibraryFolders([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> folderPath = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(folderPath, nameof(folderPath), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/createPath", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementNestedLibraryFoldersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse> CopyLibraryFolder([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodyparentFolderId)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/{1}/copy", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicPagingLibraryContentManagementLibraryGenericItemDetailsResponse> GetLibraryFolderItems([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> includeExpiration = null, [WorkflowExpression] Func<bool> includeProperties = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(includeExpiration, nameof(includeExpiration), required: false);
            SourceExpression.Validate(includeProperties, nameof(includeProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/folders/{1}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["includeExpiration"] = Convert.ToString(false);
                if (includeExpiration != null)
                    callPayload.Queries["includeExpiration"] = SourceExpressionConverter.ConvertO(includeExpiration);
                callPayload.Queries["includeProperties"] = Convert.ToString(false);
                if (includeProperties != null)
                    callPayload.Queries["includeProperties"] = SourceExpressionConverter.ConvertO(includeProperties);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicPagingLibraryContentManagementLibraryGenericItemDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse> GetLibraryItemDetails([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IWorkflowAction DeleteLibraryItem([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse> CopyLibraryItem([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodyparentFolderId)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/copy", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementSimpleItemVersion[]> GetLibraryItemVersion([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/versions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementSimpleItemVersion[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicCommonItemsOfSeismicLibraryContentManagementLibraryGenericItemDetailsResponse> GetLibraryItemsByQuery([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> externalId = null, [WorkflowExpression] Func<string> externalConnectionId = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(externalId, nameof(externalId), required: false);
            SourceExpression.Validate(externalConnectionId, nameof(externalConnectionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (externalId != null)
                    callPayload.Queries["externalId"] = SourceExpressionConverter.ConvertO(externalId);
                if (externalConnectionId != null)
                    callPayload.Queries["externalConnectionId"] = SourceExpressionConverter.ConvertO(externalConnectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicCommonItemsOfSeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<string> UpdateThumbnailItem([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/thumbnail", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicPagingLibraryInstructionsInstructionInfoResponse> GetLibraryInstructions([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<int> limit = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/instructions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicPagingLibraryInstructionsInstructionInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryInstructionsInstructionInfoResponse> AddLibraryInstruction([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodytext = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodytext, nameof(bodytext), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/instructions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodytext != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodytext);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryInstructionsInstructionInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IWorkflowAction DeleteLibraryInstruction([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> instructionId)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(instructionId, nameof(instructionId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/instructions/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(instructionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<string[]> SubmitLibraryItemToWorkflow([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodycomments = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/submit", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IWorkflowAction RecallItemFromWorkflow([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodycomments = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(bodycomments, nameof(bodycomments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/recall", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomments != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryPublishingPublishResponse> PublishLibraryItems([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodypublishAt = null, [WorkflowExpression] Func<SeismicContentManagerPublishContentItem[]> bodycontent = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodypublishAt, nameof(bodypublishAt), required: false);
            SourceExpression.Validate(bodycontent, nameof(bodycontent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/publish", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypublishAt != null)
                {
                    body["publishAt"] = SourceExpressionConverter.ConvertToken(bodypublishAt);
                    bodypropCount++;
                }

                if (bodycontent != null)
                {
                    body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryPublishingPublishResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IWorkflowAction UnpublishLibraryItem([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/items/{1}/unpublish", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryWorkflowWorkflowResponse> UpdateLibraryWorkflowStep([WorkflowExpression] Func<string> approvalWorkflowId, [WorkflowExpression] Func<string> stepId, [WorkflowExpression] Func<bodyactionInput> bodyaction = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodynextApprovernextApproverUsedId = null, [WorkflowExpression] Func<string> bodynextApprovernextApproverUserType = null)
        {
            SourceExpression.Validate(approvalWorkflowId, nameof(approvalWorkflowId), required: true);
            SourceExpression.Validate(stepId, nameof(stepId), required: true);
            SourceExpression.Validate(bodyaction, nameof(bodyaction), required: false);
            SourceExpression.Validate(bodycomment, nameof(bodycomment), required: false);
            SourceExpression.Validate(bodynextApprovernextApproverUsedId, nameof(bodynextApprovernextApproverUsedId), required: false);
            SourceExpression.Validate(bodynextApprovernextApproverUserType, nameof(bodynextApprovernextApproverUserType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/approvalWorkflows/{0}/steps/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(approvalWorkflowId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stepId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaction != null)
                {
                    body["action"] = SourceExpressionConverter.Convert(bodyaction);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                var nextApproverObject = new JObject();
                var nextApproverObjectpropCount = 0;
                if (bodynextApprovernextApproverUsedId != null)
                {
                    nextApproverObject["id"] = SourceExpressionConverter.ConvertToken(bodynextApprovernextApproverUsedId);
                    nextApproverObjectpropCount++;
                }

                if (bodynextApprovernextApproverUserType != null)
                {
                    nextApproverObject["type"] = SourceExpressionConverter.ConvertToken(bodynextApprovernextApproverUserType);
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
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryWorkflowWorkflowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryWorkflowWorkflowResponse> GetLibraryWorkflow([WorkflowExpression] Func<string> approvalWorkflowId)
        {
            SourceExpression.Validate(approvalWorkflowId, nameof(approvalWorkflowId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/approvalWorkflows/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(approvalWorkflowId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryWorkflowWorkflowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicPagingLibraryWorkflowWorkflowResponse> GetWorkflows([WorkflowExpression] Func<string> teamsiteId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> currentStepAssignedTo = null, [WorkflowExpression] Func<string> status = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(currentStepAssignedTo, nameof(currentStepAssignedTo), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/approvalWorkflows";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (teamsiteId != null)
                    callPayload.Queries["teamsiteId"] = SourceExpressionConverter.ConvertO(teamsiteId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (currentStepAssignedTo != null)
                    callPayload.Queries["currentStepAssignedTo"] = SourceExpressionConverter.ConvertO(currentStepAssignedTo);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicPagingLibraryWorkflowWorkflowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> CreateLibraryUrl([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> bodyformat = null, [WorkflowExpression] Func<string> bodyurlurl = null, [WorkflowExpression] Func<bool> bodyurlopenInNewWindow = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyexpiresAt = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodyexternalConnectionId = null, [WorkflowExpression] Func<SeismicLibraryContentManagementContentExperts[]> bodyexperts = null, [WorkflowExpression] Func<SeismicLibraryContentManagementCustomProperties[]> bodycontentProperties = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(bodyformat, nameof(bodyformat), required: false);
            SourceExpression.Validate(bodyurlurl, nameof(bodyurlurl), required: false);
            SourceExpression.Validate(bodyurlopenInNewWindow, nameof(bodyurlopenInNewWindow), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            SourceExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            SourceExpression.Validate(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            SourceExpression.Validate(bodyexperts, nameof(bodyexperts), required: false);
            SourceExpression.Validate(bodycontentProperties, nameof(bodycontentProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/urls", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyformat != null)
                {
                    body["format"] = SourceExpressionConverter.ConvertToken(bodyformat);
                    bodypropCount++;
                }

                var urlObject = new JObject();
                var urlObjectpropCount = 0;
                if (bodyurlurl != null)
                {
                    urlObject["url"] = SourceExpressionConverter.ConvertToken(bodyurlurl);
                    urlObjectpropCount++;
                }

                if (bodyurlopenInNewWindow != null)
                {
                    urlObject["openInNewWindow"] = SourceExpressionConverter.ConvertToken(bodyurlopenInNewWindow);
                    urlObjectpropCount++;
                }

                if (urlObjectpropCount > 0)
                {
                    body["url"] = urlObject;
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyexpiresAt != null)
                {
                    body["expiresAt"] = SourceExpressionConverter.ConvertToken(bodyexpiresAt);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["externalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = SourceExpressionConverter.ConvertToken(bodyexternalConnectionId);
                    bodypropCount++;
                }

                if (bodyexperts != null)
                {
                    body["experts"] = SourceExpressionConverter.ConvertToken(bodyexperts);
                    bodypropCount++;
                }

                if (bodycontentProperties != null)
                {
                    body["properties"] = SourceExpressionConverter.ConvertToken(bodycontentProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> GetLibraryUrlDetails([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/urls/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> UpdateLibraryUrl([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<bool> includeResponse = null, [WorkflowExpression] Func<string> bodyurlurl = null, [WorkflowExpression] Func<bool> bodyurlopenInNewWindow = null, [WorkflowExpression] Func<string> bodyownerId = null, [WorkflowExpression] Func<SeismicLibraryContentManagementContentExperts[]> bodyexperts = null, [WorkflowExpression] Func<SeismicLibraryContentManagementCustomProperties[]> bodycontentProperties = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyexpiresAt = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyparentFolderId = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<string> bodyexternalConnectionId = null)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(includeResponse, nameof(includeResponse), required: false);
            SourceExpression.Validate(bodyurlurl, nameof(bodyurlurl), required: false);
            SourceExpression.Validate(bodyurlopenInNewWindow, nameof(bodyurlopenInNewWindow), required: false);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            SourceExpression.Validate(bodyexperts, nameof(bodyexperts), required: false);
            SourceExpression.Validate(bodycontentProperties, nameof(bodycontentProperties), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyexpiresAt, nameof(bodyexpiresAt), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: false);
            SourceExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            SourceExpression.Validate(bodyexternalConnectionId, nameof(bodyexternalConnectionId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/urls/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeResponse"] = Convert.ToString(true);
                if (includeResponse != null)
                    callPayload.Queries["includeResponse"] = SourceExpressionConverter.ConvertO(includeResponse);
                var body = new JObject();
                var bodypropCount = 0;
                var urlObject = new JObject();
                var urlObjectpropCount = 0;
                if (bodyurlurl != null)
                {
                    urlObject["url"] = SourceExpressionConverter.ConvertToken(bodyurlurl);
                    urlObjectpropCount++;
                }

                if (bodyurlopenInNewWindow != null)
                {
                    urlObject["openInNewWindow"] = SourceExpressionConverter.ConvertToken(bodyurlopenInNewWindow);
                    urlObjectpropCount++;
                }

                if (urlObjectpropCount > 0)
                {
                    body["url"] = urlObject;
                    bodypropCount++;
                }

                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodyexperts != null)
                {
                    body["experts"] = SourceExpressionConverter.ConvertToken(bodyexperts);
                    bodypropCount++;
                }

                if (bodycontentProperties != null)
                {
                    body["properties"] = SourceExpressionConverter.ConvertToken(bodycontentProperties);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyexpiresAt != null)
                {
                    body["expiresAt"] = SourceExpressionConverter.ConvertToken(bodyexpiresAt);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyparentFolderId != null)
                {
                    body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["externalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodyexternalConnectionId != null)
                {
                    body["externalConnectionId"] = SourceExpressionConverter.ConvertToken(bodyexternalConnectionId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse> CopyLibraryUrl([WorkflowExpression] Func<string> teamsiteId, [WorkflowExpression] Func<string> libraryContentId, [WorkflowExpression] Func<string> bodyparentFolderId)
        {
            SourceExpression.Validate(teamsiteId, nameof(teamsiteId), required: true);
            SourceExpression.Validate(libraryContentId, nameof(libraryContentId), required: true);
            SourceExpression.Validate(bodyparentFolderId, nameof(bodyparentFolderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/teamsites/{0}/urls/{1}/copy", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(teamsiteId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(libraryContentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(BuildSourceInput);
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

    public enum SeismicLibraryInstructionsInstructionType
    {
        [EnumMember(Value = "text")]
        Text
    }

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