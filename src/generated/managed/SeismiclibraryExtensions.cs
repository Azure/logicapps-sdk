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
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse, ApiConnectionActionConfiguration> GetLibraryFileDetails(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFileDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/files/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse, ApiConnectionActionConfiguration> UpdateLibraryFile(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<bool>> includeResponse = null, Expression<Func<UpdateLibraryFileInput>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_includeResponse = WorkflowExpression.Compile(includeResponse, nameof(includeResponse), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFileDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/files/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeResponse"] = Convert.ToString(true);
                if (__workflow_includeResponse != null)
                    callPayload.Queries["includeResponse"] = ExpressionConverter.Convert(__workflow_includeResponse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp, ApiConnectionActionConfiguration> DownloadLibraryFile(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<bool>> redirect = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_redirect = WorkflowExpression.Compile(redirect, nameof(redirect), required: false);
            return new DeferredBodyAction<SeismicCommonDownloadLocationResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/files/{1}/content", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(true);
                if (__workflow_redirect != null)
                    callPayload.Queries["redirect"] = ExpressionConverter.Convert(__workflow_redirect);
                return new ApiConnectionAction<SeismicCommonDownloadLocationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicCommonDownloadLocationResp, ApiConnectionActionConfiguration> DownloadLibraryFileVersion(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> libraryVersionId, Expression<Func<bool>> redirect = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_libraryVersionId = WorkflowExpression.Compile(libraryVersionId, nameof(libraryVersionId), required: true);
            var __workflow_redirect = WorkflowExpression.Compile(redirect, nameof(redirect), required: false);
            return new DeferredBodyAction<SeismicCommonDownloadLocationResp, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/files/{1}/versions/{2}/content", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1), __workflow_libraryVersionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString(true);
                if (__workflow_redirect != null)
                    callPayload.Queries["redirect"] = ExpressionConverter.Convert(__workflow_redirect);
                return new ApiConnectionAction<SeismicCommonDownloadLocationResp>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFileDetailsResponse, ApiConnectionActionConfiguration> CopyLibraryFile(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<CopyLibraryFileInput>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFileDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/files/{1}/copy", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFileDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse, ApiConnectionActionConfiguration> CreateLibraryFolder(Expression<Func<string>> teamsiteId, Expression<Func<CreateLibraryFolderInput>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/folders", __workflow_teamsiteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse, ApiConnectionActionConfiguration> GetLibraryFolderDetails(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/folders/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse, ApiConnectionActionConfiguration> UpdateLibraryFolder(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<UpdateLibraryFolderInput>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/folders/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementNestedLibraryFoldersResponse, ApiConnectionActionConfiguration> CreateNestedLibraryFolders(Expression<Func<string>> teamsiteId, Expression<Func<string>> folderPath = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementNestedLibraryFoldersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/folders/createPath", __workflow_teamsiteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionAction<SeismicLibraryContentManagementNestedLibraryFoldersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryFolderResponse, ApiConnectionActionConfiguration> CopyLibraryFolder(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<CopyLibraryFolderInput>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryFolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/folders/{1}/copy", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicPagingLibraryContentManagementLibraryGenericItemDetailsResponse, ApiConnectionActionConfiguration> GetLibraryFolderItems(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null, Expression<Func<bool>> includeExpiration = null, Expression<Func<bool>> includeProperties = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_includeExpiration = WorkflowExpression.Compile(includeExpiration, nameof(includeExpiration), required: false);
            var __workflow_includeProperties = WorkflowExpression.Compile(includeProperties, nameof(includeProperties), required: false);
            return new DeferredBodyAction<SeismicPagingLibraryContentManagementLibraryGenericItemDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/folders/{1}/items", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse, ApiConnectionActionConfiguration> GetLibraryItemDetails(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteLibraryItem(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse, ApiConnectionActionConfiguration> CopyLibraryItem(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<CopyLibraryItemInput>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}/copy", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryGenericItemDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementSimpleItemVersion[], ApiConnectionActionConfiguration> GetLibraryItemVersion(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementSimpleItemVersion[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}/versions", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementSimpleItemVersion[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicCommonItemsOfSeismicLibraryContentManagementLibraryGenericItemDetailsResponse, ApiConnectionActionConfiguration> GetLibraryItemsByQuery(Expression<Func<string>> teamsiteId, Expression<Func<string>> externalId = null, Expression<Func<string>> externalConnectionId = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_externalId = WorkflowExpression.Compile(externalId, nameof(externalId), required: false);
            var __workflow_externalConnectionId = WorkflowExpression.Compile(externalConnectionId, nameof(externalConnectionId), required: false);
            return new DeferredBodyAction<SeismicCommonItemsOfSeismicLibraryContentManagementLibraryGenericItemDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items", __workflow_teamsiteId.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UpdateThumbnailItem(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}/thumbnail", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicPagingLibraryInstructionsInstructionInfoResponse, ApiConnectionActionConfiguration> GetLibraryInstructions(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<int>> offset = null, Expression<Func<int>> limit = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<SeismicPagingLibraryInstructionsInstructionInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}/instructions", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<SeismicLibraryInstructionsInstructionInfoResponse, ApiConnectionActionConfiguration> AddLibraryInstruction(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<AddLibraryInstructionInput>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicLibraryInstructionsInstructionInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}/instructions", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SeismicLibraryInstructionsInstructionInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteLibraryInstruction(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<string>> instructionId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_instructionId = WorkflowExpression.Compile(instructionId, nameof(instructionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}/instructions/{2}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1), __workflow_instructionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> SubmitLibraryItemToWorkflow(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<SubmitLibraryItemToWorkflowInput>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}/submit", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RecallItemFromWorkflow(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<RecallItemFromWorkflowInput>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}/recall", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryPublishingPublishResponse, ApiConnectionActionConfiguration> PublishLibraryItems(Expression<Func<string>> teamsiteId, Expression<Func<PublishLibraryItemsInput>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicLibraryPublishingPublishResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/publish", __workflow_teamsiteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SeismicLibraryPublishingPublishResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnpublishLibraryItem(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/items/{1}/unpublish", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryWorkflowWorkflowResponse, ApiConnectionActionConfiguration> UpdateLibraryWorkflowStep(Expression<Func<string>> approvalWorkflowId, Expression<Func<string>> stepId, Expression<Func<UpdateLibraryWorkflowStepInput>> body = null)
        {
            var __workflow_approvalWorkflowId = WorkflowExpression.Compile(approvalWorkflowId, nameof(approvalWorkflowId), required: true);
            var __workflow_stepId = WorkflowExpression.Compile(stepId, nameof(stepId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicLibraryWorkflowWorkflowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/approvalWorkflows/{0}/steps/{1}", __workflow_approvalWorkflowId.WithUrlEncoding(1), __workflow_stepId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SeismicLibraryWorkflowWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryWorkflowWorkflowResponse, ApiConnectionActionConfiguration> GetLibraryWorkflow(Expression<Func<string>> approvalWorkflowId)
        {
            var __workflow_approvalWorkflowId = WorkflowExpression.Compile(approvalWorkflowId, nameof(approvalWorkflowId), required: true);
            return new DeferredBodyAction<SeismicLibraryWorkflowWorkflowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/approvalWorkflows/{0}", __workflow_approvalWorkflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryWorkflowWorkflowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicPagingLibraryWorkflowWorkflowResponse, ApiConnectionActionConfiguration> GetWorkflows(Expression<Func<string>> teamsiteId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> currentStepAssignedTo = null, Expression<Func<string>> status = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_currentStepAssignedTo = WorkflowExpression.Compile(currentStepAssignedTo, nameof(currentStepAssignedTo), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            return new DeferredBodyAction<SeismicPagingLibraryWorkflowWorkflowResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse, ApiConnectionActionConfiguration> CreateLibraryUrl(Expression<Func<string>> teamsiteId, Expression<Func<CreateLibraryUrlInput>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/urls", __workflow_teamsiteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse, ApiConnectionActionConfiguration> GetLibraryUrlDetails(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/urls/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse, ApiConnectionActionConfiguration> UpdateLibraryUrl(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<bool>> includeResponse = null, Expression<Func<UpdateLibraryUrlInput>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_includeResponse = WorkflowExpression.Compile(includeResponse, nameof(includeResponse), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/urls/{1}", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeResponse"] = Convert.ToString(true);
                if (__workflow_includeResponse != null)
                    callPayload.Queries["includeResponse"] = ExpressionConverter.Convert(__workflow_includeResponse);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seismiclibrary")]
        public IBodyWorkflowAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse, ApiConnectionActionConfiguration> CopyLibraryUrl(Expression<Func<string>> teamsiteId, Expression<Func<string>> libraryContentId, Expression<Func<CopyLibraryUrlInput>> body = null)
        {
            var __workflow_teamsiteId = WorkflowExpression.Compile(teamsiteId, nameof(teamsiteId), required: true);
            var __workflow_libraryContentId = WorkflowExpression.Compile(libraryContentId, nameof(libraryContentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SeismicLibraryContentManagementLibraryUrlDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/teamsites/{0}/urls/{1}/copy", __workflow_teamsiteId.WithUrlEncoding(1), __workflow_libraryContentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class UpdateLibraryFileInput
    {
        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalConnectionId")]
        public string ExternalConnectionId { get; set; }

        [JsonProperty("experts")]
        public SeismicLibraryContentManagementContentExperts[] Experts { get; set; }

        [JsonProperty("properties")]
        public SeismicLibraryContentManagementCustomProperties[] ContentProperties { get; set; }
    }

    public class SeismicCommonDownloadLocationResp
    {
        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }
    }

    public class CopyLibraryFileInput
    {
        [JsonProperty("parentFolderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentFolderId { get; set; }
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

    public class CreateLibraryFolderInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalConnectionId")]
        public string ExternalConnectionId { get; set; }
    }

    public class UpdateLibraryFolderInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

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

    public class CopyLibraryFolderInput
    {
        [JsonProperty("parentFolderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentFolderId { get; set; }
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

    public class CopyLibraryItemInput
    {
        [JsonProperty("parentFolderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentFolderId { get; set; }
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

    public class AddLibraryInstructionInput
    {
        [JsonProperty("type")]
        public SeismicLibraryInstructionsInstructionType? Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SubmitLibraryItemToWorkflowInput
    {
        [JsonProperty("comments")]
        public string Comments { get; set; }
    }

    public class RecallItemFromWorkflowInput
    {
        [JsonProperty("comments")]
        public string Comments { get; set; }
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

    public class PublishLibraryItemsInput
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("publishAt")]
        public string PublishAt { get; set; }

        [JsonProperty("content")]
        public SeismicContentManagerPublishContentItem[] Content { get; set; }
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

    public class UpdateLibraryWorkflowStepInput
    {
        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public SeismicLibraryWorkflowWorkflowApprovalAction Action { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("nextApprover")]
        public SeismicLibraryWorkflowNextWorkflowApprover NextApprover { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SeismicLibraryWorkflowWorkflowApprovalAction
    {
        [EnumMember(Value = "approve")]
        Approve,
        [EnumMember(Value = "reject")]
        Reject,
        [EnumMember(Value = "revoke")]
        Revoke
    }

    public class SeismicLibraryWorkflowNextWorkflowApprover
    {
        [JsonProperty("id")]
        public string NextApproverUsedId { get; set; }

        [JsonProperty("type")]
        public string NextApproverUserType { get; set; }
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

    public class CreateLibraryUrlInput
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("url")]
        public SeismicLibraryContentManagementAddUrl Url { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalConnectionId")]
        public string ExternalConnectionId { get; set; }

        [JsonProperty("experts")]
        public SeismicLibraryContentManagementContentExperts[] Experts { get; set; }

        [JsonProperty("properties")]
        public SeismicLibraryContentManagementCustomProperties[] ContentProperties { get; set; }
    }

    public class SeismicLibraryContentManagementAddUrl
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("openInNewWindow")]
        public bool OpenInNewWindow { get; set; }
    }

    public class UpdateLibraryUrlInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public SeismicLibraryContentManagementAddUrl Url { get; set; }

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("experts")]
        public SeismicLibraryContentManagementContentExperts[] Experts { get; set; }

        [JsonProperty("properties")]
        public SeismicLibraryContentManagementCustomProperties[] ContentProperties { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parentFolderId")]
        public string ParentFolderId { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalConnectionId")]
        public string ExternalConnectionId { get; set; }
    }

    public class CopyLibraryUrlInput
    {
        [JsonProperty("parentFolderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentFolderId { get; set; }
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