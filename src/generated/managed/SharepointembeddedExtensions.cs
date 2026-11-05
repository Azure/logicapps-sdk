//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointembedded
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SharepointembeddedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerList, ApiConnectionActionConfiguration> ListContainers(Expression<Func<string>> containerType)
        {
            var __workflow_containerType = WorkflowExpression.Compile(containerType, nameof(containerType), required: true);
            return new DeferredBodyAction<FileStorageContainerList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/storage/fileStorage/containers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["containerType"] = ExpressionConverter.Convert(__workflow_containerType);
                return new ApiConnectionAction<FileStorageContainerList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ActivateContainer(Expression<Func<string>> containerId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/activate", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RecycleContainer(Expression<Func<string>> containerId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainer, ApiConnectionActionConfiguration> GetContainer(Expression<Func<string>> containerId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            return new DeferredBodyAction<FileStorageContainer, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FileStorageContainer>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainer, ApiConnectionActionConfiguration> UpdateContainer(Expression<Func<string>> containerId, Expression<Func<UpdateContainerBodyInput>> body)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FileStorageContainer, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FileStorageContainer>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerPermissionsList, ApiConnectionActionConfiguration> ListPermissions(Expression<Func<string>> containerId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            return new DeferredBodyAction<FileStorageContainerPermissionsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/permissions", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FileStorageContainerPermissionsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerPermission, ApiConnectionActionConfiguration> CreatePermission(Expression<Func<string>> containerId, Expression<Func<CreatePermissionBodyInput>> body)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FileStorageContainerPermission, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/permissions", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FileStorageContainerPermission>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeletePermission(Expression<Func<string>> containerId, Expression<Func<string>> permissionId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_permissionId = WorkflowExpression.Compile(permissionId, nameof(permissionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/permissions/{1}", __workflow_containerId.WithUrlEncoding(1), __workflow_permissionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerPermission, ApiConnectionActionConfiguration> UpdatePermission(Expression<Func<string>> containerId, Expression<Func<string>> permissionId, Expression<Func<UpdatePermissionBodyInput>> body)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_permissionId = WorkflowExpression.Compile(permissionId, nameof(permissionId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FileStorageContainerPermission, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/permissions/{1}", __workflow_containerId.WithUrlEncoding(1), __workflow_permissionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FileStorageContainerPermission>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerList, ApiConnectionActionConfiguration> ListRecycledContainers(Expression<Func<string>> containerType)
        {
            var __workflow_containerType = WorkflowExpression.Compile(containerType, nameof(containerType), required: true);
            return new DeferredBodyAction<FileStorageContainerList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/storage/fileStorage/deletedContainers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["containerType"] = ExpressionConverter.Convert(__workflow_containerType);
                return new ApiConnectionAction<FileStorageContainerList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteContainer(Expression<Func<string>> containerId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/deletedContainers/{0}", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainer, ApiConnectionActionConfiguration> RestoreContainer(Expression<Func<string>> containerId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            return new DeferredBodyAction<FileStorageContainer, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/deletedContainers/{0}/restore", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FileStorageContainer>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerColumnsList, ApiConnectionActionConfiguration> ListContainerColumns(Expression<Func<string>> containerId, Expression<Func<string>> filter = null)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<FileStorageContainerColumnsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/columns", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<FileStorageContainerColumnsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerColumn, ApiConnectionActionConfiguration> CreateContainerColumn(Expression<Func<string>> containerId, Expression<Func<object>> columnDefinition)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_columnDefinition = WorkflowExpression.Compile(columnDefinition, nameof(columnDefinition), required: true);
            return new DeferredBodyAction<FileStorageContainerColumn, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/columns", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_columnDefinition);
                return new ApiConnectionAction<FileStorageContainerColumn>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerColumn, ApiConnectionActionConfiguration> GetContainerColumn(Expression<Func<string>> containerId, Expression<Func<string>> columnId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_columnId = WorkflowExpression.Compile(columnId, nameof(columnId), required: true);
            return new DeferredBodyAction<FileStorageContainerColumn, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/columns/{1}", __workflow_containerId.WithUrlEncoding(1), __workflow_columnId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FileStorageContainerColumn>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteContainerColumn(Expression<Func<string>> containerId, Expression<Func<string>> columnId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_columnId = WorkflowExpression.Compile(columnId, nameof(columnId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/columns/{1}", __workflow_containerId.WithUrlEncoding(1), __workflow_columnId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerCustomProperties, ApiConnectionActionConfiguration> GetContainerCustomProperties(Expression<Func<string>> containerId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            return new DeferredBodyAction<FileStorageContainerCustomProperties, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/customProperties", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FileStorageContainerCustomProperties>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerCustomProperties, ApiConnectionActionConfiguration> UpdateContainerCustomProperties(Expression<Func<string>> containerId, Expression<Func<object>> body)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FileStorageContainerCustomProperties, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/customProperties", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FileStorageContainerCustomProperties>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<DriveItemCollectionPage, ApiConnectionActionConfiguration> ListContainerFiles(Expression<Func<string>> containerId, Expression<Func<string>> parentId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<int>> top = null, Expression<Func<string>> orderby = null)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            return new DeferredBodyAction<DriveItemCollectionPage, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["parentId"] = ExpressionConverter.Convert(__workflow_parentId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["$select"] = Convert.ToString("id,name,file,folder");
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Queries["$expand"] = Convert.ToString("listItem($expand=fields)");
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                callPayload.Queries["$top"] = Convert.ToString(20);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                return new ApiConnectionAction<DriveItemCollectionPage>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<DriveItem, ApiConnectionActionConfiguration> GetFileProperties(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<DriveItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DriveItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<DriveItem, ApiConnectionActionConfiguration> RenameFile(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<RenameFileBodyInput>> body)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DriveItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DriveItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFile(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFileContent(Expression<Func<string>> fileId, Expression<Func<string>> containerId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/content", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UpdateFileContent(Expression<Func<string>> fileId, Expression<Func<string>> containerId, Expression<Func<global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent>> body)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/content", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<DriveItem, ApiConnectionActionConfiguration> CreateFile(Expression<Func<string>> parentId, Expression<Func<string>> containerId, Expression<Func<string>> fileName, Expression<Func<global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent>> body)
        {
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DriveItem, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}:/{2}:/content", __workflow_containerId.WithUrlEncoding(1), __workflow_parentId.WithUrlEncoding(1), __workflow_fileName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DriveItem>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<SharingLink, ApiConnectionActionConfiguration> CreateSharingLink(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<CreateSharingLinkBodyInput>> body)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SharingLink, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/createLink", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SharingLink>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<SharingPermissionsList, ApiConnectionActionConfiguration> SendSharingInvitation(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<SendSharingInvitationBodyInput>> body)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SharingPermissionsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/invite", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SharingPermissionsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<SharingPermissionsList, ApiConnectionActionConfiguration> ListSharingPermissions(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<SharingPermissionsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/permissions", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SharingPermissionsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<SharingPermissionResponse, ApiConnectionActionConfiguration> GetSharingPermission(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<string>> permissionId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_permissionId = WorkflowExpression.Compile(permissionId, nameof(permissionId), required: true);
            return new DeferredBodyAction<SharingPermissionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/permissions/{2}", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1), __workflow_permissionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SharingPermissionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteSharingPermission(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<string>> permissionId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_permissionId = WorkflowExpression.Compile(permissionId, nameof(permissionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/permissions/{2}", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1), __workflow_permissionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<CreateFilePreviewResponse, ApiConnectionActionConfiguration> CreateFilePreview(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<CreateFilePreviewBodyInput>> body = null)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateFilePreviewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/preview", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateFilePreviewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<ListFileFieldsResponse, ApiConnectionActionConfiguration> ListFileFields(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<ListFileFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/listitem/fields", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListFileFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<UpdateFileFieldsResponse, ApiConnectionActionConfiguration> UpdateFileFields(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<object>> body)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateFileFieldsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/listitem/fields", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateFileFieldsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileVersions, ApiConnectionActionConfiguration> ListFileVersions(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<FileVersions, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/versions", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FileVersions>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileVersion, ApiConnectionActionConfiguration> GetFileVersion(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<string>> versionId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_versionId = WorkflowExpression.Compile(versionId, nameof(versionId), required: true);
            return new DeferredBodyAction<FileVersion, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/versions/{2}", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1), __workflow_versionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FileVersion>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFileVersion(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<string>> versionId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_versionId = WorkflowExpression.Compile(versionId, nameof(versionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/versions/{2}", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1), __workflow_versionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<ThumbnailSets, ApiConnectionActionConfiguration> ListFileThumbnails(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<ThumbnailSets, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/thumbnails", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ThumbnailSets>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<Thumbnail, ApiConnectionActionConfiguration> GetFileThumbnail(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<string>> thumbnailId, Expression<Func<SizeInput>> size)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_thumbnailId = WorkflowExpression.Compile(thumbnailId, nameof(thumbnailId), required: true);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: true);
            return new DeferredBodyAction<Thumbnail, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/thumbnails/{2}/{3}", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1), __workflow_thumbnailId.WithUrlEncoding(1), __workflow_size.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Thumbnail>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CheckInFile(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<CheckInFileBodyInput>> body = null)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/checkin", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CheckOutFile(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/checkout", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DiscardCheckOut(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/drives/{0}/items/{1}/discardCheckout", __workflow_containerId.WithUrlEncoding(1), __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<RecycleBinItemCollection, ApiConnectionActionConfiguration> ListRecycledFiles(Expression<Func<string>> containerId)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            return new DeferredBodyAction<RecycleBinItemCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/recycleBin/items", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RecycleBinItemCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<RestoreRecycledFilesResponse, ApiConnectionActionConfiguration> RestoreRecycledFiles(Expression<Func<string>> containerId, Expression<Func<PermanentDeleteRecycledFilesBodyInput>> body)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RestoreRecycledFilesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/recycleBin/items/restore", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RestoreRecycledFilesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PermanentDeleteRecycledFiles(Expression<Func<string>> containerId, Expression<Func<PermanentDeleteRecycledFilesBodyInput>> body)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/storage/fileStorage/containers/{0}/recycleBin/items/delete", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SharepointembeddedTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetChangesContainerResponse, ApiConnectionTriggerConfiguration> GetChangesContainer(Expression<Func<string>> containerId, Expression<Func<int>> pollingInterval = null, FlowRecurrence recurrence = null)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_pollingInterval = WorkflowExpression.Compile(pollingInterval, nameof(pollingInterval), required: false);
            return new DeferredBodyTrigger<GetChangesContainerResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/v1.0/drives/{0}/root/delta", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pollingInterval"] = Convert.ToString(300);
                if (__workflow_pollingInterval != null)
                    callPayload.Queries["pollingInterval"] = ExpressionConverter.Convert(__workflow_pollingInterval);
                return new ApiConnectionTrigger<GetChangesContainerResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class FileStorageContainerList
    {
        [JsonProperty("value")]
        public FileStorageContainer[] Value { get; set; }
    }

    public class FileStorageContainer
    {
        [JsonProperty("id")]
        public string ContainerId { get; set; }

        [JsonProperty("containerTypeId")]
        public string ContainerTypeId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("customProperties")]
        public FileStorageContainerCustomProperties CustomProperties { get; set; }

        [JsonProperty("permissions")]
        public FileStorageContainerPermission[] Permissions { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class FileStorageContainerCustomProperties
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }
    }

    public class FileStorageContainerPermission
    {
        [JsonProperty("id")]
        public string PermissionId { get; set; }

        [JsonProperty("roles")]
        public CreatePermissionFileStorageContainerPermissionRolesItemResponse[] Roles { get; set; }

        [JsonProperty("grantedToV2")]
        public FileStorageContainerPermissionGrantedToV2Type GrantedToV2 { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePermissionFileStorageContainerPermissionRolesItemResponse
    {
        [EnumMember(Value = "owner")]
        Owner,
        [EnumMember(Value = "manager")]
        Manager,
        [EnumMember(Value = "writer")]
        Writer,
        [EnumMember(Value = "reader")]
        Reader
    }

    public class FileStorageContainerPermissionGrantedToV2Type
    {
        [JsonProperty("user")]
        public FileStorageContainerPermissionGrantedToV2TypeUserType User { get; set; }
    }

    public class FileStorageContainerPermissionGrantedToV2TypeUserType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class UpdateContainerBodyInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("settings")]
        public BodyInputSettingsType Settings { get; set; }
    }

    public class BodyInputSettingsType
    {
        [JsonProperty("isOcrEnabled")]
        public bool? OCREnabled { get; set; }

        [JsonProperty("itemMinorVersionLimit")]
        public int? ItemMinorVersionLimit { get; set; }

        [JsonProperty("isItemVersioningEnabled")]
        public bool? ItemVersioningEnabled { get; set; }
    }

    public class FileStorageContainerPermissionsList
    {
        [JsonProperty("value")]
        public FileStorageContainerPermission[] Value { get; set; }
    }

    public class CreatePermissionBodyInput
    {
        [JsonProperty("roles", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePermissionFileStorageContainerPermissionRolesItem[] Roles { get; set; }

        [JsonProperty("grantedToV2", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputGrantedToV2Type GrantedToV2 { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePermissionFileStorageContainerPermissionRolesItem
    {
        [EnumMember(Value = "owner")]
        Owner,
        [EnumMember(Value = "manager")]
        Manager,
        [EnumMember(Value = "writer")]
        Writer,
        [EnumMember(Value = "reader")]
        Reader
    }

    public class BodyInputGrantedToV2Type
    {
        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputGrantedToV2TypeUserType User { get; set; }
    }

    public class BodyInputGrantedToV2TypeUserType
    {
        [JsonProperty("userPrincipalName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserPrincipalName { get; set; }
    }

    public class UpdatePermissionBodyInput
    {
        [JsonProperty("roles", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePermissionFileStorageContainerPermissionRolesItem[] PermissionRoles { get; set; }
    }

    public class FileStorageContainerColumnsList
    {
        [JsonProperty("value")]
        public FileStorageContainerColumn[] Value { get; set; }
    }

    public class FileStorageContainerColumn
    {
        [JsonProperty("id")]
        public string ColumnId { get; set; }

        [JsonProperty("name")]
        public string ColumnName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enforceUniqueValues")]
        public bool EnforceUniqueValues { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("indexed")]
        public bool Indexed { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }

        [JsonProperty("columnGroup")]
        public string ColumnGroup { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("isDeletable")]
        public bool IsDeletable { get; set; }

        [JsonProperty("isReorderable")]
        public bool IsReorderable { get; set; }

        [JsonProperty("isSealed")]
        public bool IsSealed { get; set; }

        [JsonProperty("propagateChanges")]
        public bool PropagateChanges { get; set; }

        [JsonProperty("defaultValue")]
        public FileStorageContainerColumnDefaultValueType DefaultValue { get; set; }

        [JsonProperty("text")]
        public FileStorageContainerColumnTextType Text { get; set; }

        [JsonProperty("number")]
        public FileStorageContainerColumnNumberType Number { get; set; }

        [JsonProperty("boolean")]
        public JToken Boolean { get; set; }

        [JsonProperty("dateTime")]
        public FileStorageContainerColumnDateTimeType DateTime { get; set; }

        [JsonProperty("choice")]
        public FileStorageContainerColumnChoiceType Choice { get; set; }

        [JsonProperty("lookup")]
        public FileStorageContainerColumnLookupType Lookup { get; set; }

        [JsonProperty("currency")]
        public FileStorageContainerColumnCurrencyType Currency { get; set; }

        [JsonProperty("personOrGroup")]
        public FileStorageContainerColumnPersonOrGroupType PersonOrGroup { get; set; }

        [JsonProperty("hyperlinkOrPicture")]
        public FileStorageContainerColumnHyperlinkOrPictureType HyperlinkOrPicture { get; set; }

        [JsonProperty("calculated")]
        public FileStorageContainerColumnCalculatedType Calculated { get; set; }

        [JsonProperty("geolocation")]
        public JToken GeolocationColumn { get; set; }

        [JsonProperty("thumbnail")]
        public JToken ThumbnailColumnProperties { get; set; }

        [JsonProperty("contentApprovalStatus")]
        public JToken ContentApprovalStatusColumnProperties { get; set; }

        [JsonProperty("term")]
        public FileStorageContainerColumnTermType Term { get; set; }

        [JsonProperty("sourceContentType")]
        public FileStorageContainerColumnSourceContentTypeType SourceContentType { get; set; }
    }

    public class FileStorageContainerColumnDefaultValueType
    {
        [JsonProperty("formula")]
        public string DefaultValueColumnFormula { get; set; }

        [JsonProperty("value")]
        public string DefaultValueColumnValue { get; set; }
    }

    public class FileStorageContainerColumnTextType
    {
        [JsonProperty("maxLength")]
        public int TextColumnMaxLength { get; set; }

        [JsonProperty("allowMultipleLines")]
        public bool TextColumnAllowMultipleLines { get; set; }

        [JsonProperty("appendChangesToExistingText")]
        public bool TextColumnAppendChanges { get; set; }

        [JsonProperty("linesForEditing")]
        public int TextColumnLinesForEditing { get; set; }

        [JsonProperty("textType")]
        public FileStorageContainerColumnTextTypeTextColumnTextTypeType TextColumnTextType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FileStorageContainerColumnTextTypeTextColumnTextTypeType
    {
        [EnumMember(Value = "plain")]
        Plain,
        [EnumMember(Value = "richText")]
        RichText
    }

    public class FileStorageContainerColumnNumberType
    {
        [JsonProperty("decimalPlaces")]
        public FileStorageContainerColumnNumberTypeNumberColumnDecimalPlacesType NumberColumnDecimalPlaces { get; set; }

        [JsonProperty("displayAs")]
        public FileStorageContainerColumnNumberTypeNumberColumnDisplayAsType NumberColumnDisplayAs { get; set; }

        [JsonProperty("maximum")]
        public double NumberColumnMaximum { get; set; }

        [JsonProperty("minimum")]
        public double NumberColumnMinimum { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FileStorageContainerColumnNumberTypeNumberColumnDecimalPlacesType
    {
        [EnumMember(Value = "automatic")]
        Automatic,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "one")]
        One,
        [EnumMember(Value = "two")]
        Two,
        [EnumMember(Value = "three")]
        Three,
        [EnumMember(Value = "four")]
        Four,
        [EnumMember(Value = "five")]
        Five
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FileStorageContainerColumnNumberTypeNumberColumnDisplayAsType
    {
        [EnumMember(Value = "number")]
        Number,
        [EnumMember(Value = "percentage")]
        Percentage
    }

    public class FileStorageContainerColumnDateTimeType
    {
        [JsonProperty("displayAs")]
        public FileStorageContainerColumnDateTimeTypeDateTimeColumnDisplayAsType DateTimeColumnDisplayAs { get; set; }

        [JsonProperty("format")]
        public FileStorageContainerColumnDateTimeTypeDateTimeColumnFormatType DateTimeColumnFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FileStorageContainerColumnDateTimeTypeDateTimeColumnDisplayAsType
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "friendly")]
        Friendly,
        [EnumMember(Value = "standard")]
        Standard
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FileStorageContainerColumnDateTimeTypeDateTimeColumnFormatType
    {
        [EnumMember(Value = "dateOnly")]
        DateOnly,
        [EnumMember(Value = "dateTime")]
        DateTime
    }

    public class FileStorageContainerColumnChoiceType
    {
        [JsonProperty("allowTextEntry")]
        public bool ChoiceColumnAllowTextEntry { get; set; }

        [JsonProperty("choices")]
        public string[] ChoiceColumnChoices { get; set; }

        [JsonProperty("displayAs")]
        public FileStorageContainerColumnChoiceTypeChoiceColumnDisplayAsType ChoiceColumnDisplayAs { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FileStorageContainerColumnChoiceTypeChoiceColumnDisplayAsType
    {
        [EnumMember(Value = "dropDown")]
        DropDown,
        [EnumMember(Value = "radioButtons")]
        RadioButtons,
        [EnumMember(Value = "checkBoxes")]
        CheckBoxes
    }

    public class FileStorageContainerColumnLookupType
    {
        [JsonProperty("allowMultipleValues")]
        public bool LookupColumnAllowMultipleValues { get; set; }

        [JsonProperty("allowUnlimitedLength")]
        public bool LookupColumnAllowUnlimitedLength { get; set; }

        [JsonProperty("listId")]
        public string LookupColumnListId { get; set; }

        [JsonProperty("primaryLookupColumnId")]
        public string LookupColumnPrimaryLookupColumnId { get; set; }
    }

    public class FileStorageContainerColumnCurrencyType
    {
        [JsonProperty("locale")]
        public string CurrencyColumnLocale { get; set; }
    }

    public class FileStorageContainerColumnPersonOrGroupType
    {
        [JsonProperty("allowMultipleSelection")]
        public bool PersonOrGroupColumnAllowMultipleSelection { get; set; }

        [JsonProperty("chooseFromType")]
        public FileStorageContainerColumnPersonOrGroupTypePersonOrGroupColumnChooseFromTypeType PersonOrGroupColumnChooseFromType { get; set; }

        [JsonProperty("displayAs")]
        public string PersonOrGroupColumnDisplayAs { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FileStorageContainerColumnPersonOrGroupTypePersonOrGroupColumnChooseFromTypeType
    {
        [EnumMember(Value = "peopleOnly")]
        PeopleOnly,
        [EnumMember(Value = "peopleAndGroups")]
        PeopleAndGroups
    }

    public class FileStorageContainerColumnHyperlinkOrPictureType
    {
        [JsonProperty("isPicture")]
        public bool HyperlinkOrPictureColumnIsPicture { get; set; }
    }

    public class FileStorageContainerColumnCalculatedType
    {
        [JsonProperty("formula")]
        public string CalculatedColumnFormula { get; set; }

        [JsonProperty("outputType")]
        public FileStorageContainerColumnCalculatedTypeCalculatedColumnOutputTypeType CalculatedColumnOutputType { get; set; }

        [JsonProperty("format")]
        public FileStorageContainerColumnCalculatedTypeCalculatedColumnFormatType CalculatedColumnFormat { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FileStorageContainerColumnCalculatedTypeCalculatedColumnOutputTypeType
    {
        [EnumMember(Value = "boolean")]
        Boolean,
        [EnumMember(Value = "currency")]
        Currency,
        [EnumMember(Value = "dateTime")]
        DateTime,
        [EnumMember(Value = "number")]
        Number,
        [EnumMember(Value = "text")]
        Text
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FileStorageContainerColumnCalculatedTypeCalculatedColumnFormatType
    {
        [EnumMember(Value = "dateOnly")]
        DateOnly,
        [EnumMember(Value = "dateTime")]
        DateTime
    }

    public class FileStorageContainerColumnTermType
    {
        [JsonProperty("allowMultipleValues")]
        public bool TermColumnAllowMultipleValues { get; set; }

        [JsonProperty("showFullyQualifiedName")]
        public bool TermColumnShowFullyQualifiedName { get; set; }
    }

    public class FileStorageContainerColumnSourceContentTypeType
    {
        [JsonProperty("id")]
        public string ContentTypeId { get; set; }

        [JsonProperty("name")]
        public string ContentTypeName { get; set; }
    }

    public class DriveItemCollectionPage
    {
        [JsonProperty("value")]
        public DriveItem[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }
    }

    public class DriveItem
    {
        [JsonProperty("@microsoft.graph.downloadUrl")]
        public string DownloadURL { get; set; }

        [JsonProperty("@microsoft.graph.downloadUrlNoAuth")]
        public string DownloadURLNoAuth { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("webUrl")]
        public string WebURL { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("eTag")]
        public string ETag { get; set; }

        [JsonProperty("cTag")]
        public string CTag { get; set; }

        [JsonProperty("parentReference")]
        public DriveItemParentReferenceType ParentReference { get; set; }

        [JsonProperty("createdBy")]
        public DriveItemCreatedByType CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public DriveItemLastModifiedByType LastModifiedBy { get; set; }

        [JsonProperty("file")]
        public DriveItemFileType File { get; set; }

        [JsonProperty("fileSystemInfo")]
        public DriveItemFileSystemInfoType FileSystemInfo { get; set; }

        [JsonProperty("folder")]
        public DriveItemFolderType Folder { get; set; }

        [JsonProperty("shared")]
        public DriveItemSharedType Shared { get; set; }
    }

    public class DriveItemParentReferenceType
    {
        [JsonProperty("driveType")]
        public string DriveType { get; set; }

        [JsonProperty("driveId")]
        public string DriveId { get; set; }

        [JsonProperty("id")]
        public string ParentId { get; set; }

        [JsonProperty("name")]
        public string ParentName { get; set; }

        [JsonProperty("path")]
        public string ParentPath { get; set; }

        [JsonProperty("siteId")]
        public string SiteId { get; set; }
    }

    public class DriveItemCreatedByType
    {
        [JsonProperty("application")]
        public DriveItemCreatedByTypeApplicationType Application { get; set; }

        [JsonProperty("user")]
        public DriveItemCreatedByTypeUserType User { get; set; }
    }

    public class DriveItemCreatedByTypeApplicationType
    {
        [JsonProperty("id")]
        public string ApplicationId { get; set; }

        [JsonProperty("displayName")]
        public string ApplicationName { get; set; }
    }

    public class DriveItemCreatedByTypeUserType
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("displayName")]
        public string UserName { get; set; }
    }

    public class DriveItemLastModifiedByType
    {
        [JsonProperty("application")]
        public DriveItemLastModifiedByTypeApplicationType Application { get; set; }

        [JsonProperty("user")]
        public DriveItemLastModifiedByTypeUserType User { get; set; }
    }

    public class DriveItemLastModifiedByTypeApplicationType
    {
        [JsonProperty("id")]
        public string ApplicationId { get; set; }

        [JsonProperty("displayName")]
        public string ApplicationName { get; set; }
    }

    public class DriveItemLastModifiedByTypeUserType
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("displayName")]
        public string UserName { get; set; }
    }

    public class DriveItemFileType
    {
        [JsonProperty("mimeType")]
        public string MIMEType { get; set; }

        [JsonProperty("hashes")]
        public DriveItemFileTypeHashesType Hashes { get; set; }
    }

    public class DriveItemFileTypeHashesType
    {
        [JsonProperty("quickXorHash")]
        public string QuickXorHash { get; set; }
    }

    public class DriveItemFileSystemInfoType
    {
        [JsonProperty("createdDateTime")]
        public string CreatedTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedTime { get; set; }
    }

    public class DriveItemFolderType
    {
        [JsonProperty("childCount")]
        public int ChildCount { get; set; }
    }

    public class DriveItemSharedType
    {
        [JsonProperty("scope")]
        public string SharingScope { get; set; }
    }

    public class RenameFileBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SharingLink
    {
        [JsonProperty("id")]
        public string LinkId { get; set; }

        [JsonProperty("link")]
        public SharingLinkLinkType Link { get; set; }
    }

    public class SharingLinkLinkType
    {
        [JsonProperty("type")]
        public SharingLinkLinkTypeLinkTypeType LinkType { get; set; }

        [JsonProperty("scope")]
        public SharingLinkLinkTypeLinkScopeType LinkScope { get; set; }

        [JsonProperty("webUrl")]
        public string WebURL { get; set; }

        [JsonProperty("application")]
        public SharingLinkLinkTypeApplicationType Application { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SharingLinkLinkTypeLinkTypeType
    {
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "edit")]
        Edit,
        [EnumMember(Value = "embed")]
        Embed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SharingLinkLinkTypeLinkScopeType
    {
        [EnumMember(Value = "anonymous")]
        Anonymous,
        [EnumMember(Value = "organization")]
        Organization,
        [EnumMember(Value = "users")]
        Users
    }

    public class SharingLinkLinkTypeApplicationType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateSharingLinkBodyInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputLinkTypeType LinkType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointembedded.BodyInputLinkTypeType.View;

        [JsonProperty("scope", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputLinkScopeType? LinkScope { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointembedded.BodyInputLinkScopeType.Organization;

        [JsonProperty("expirationDateTime")]
        public string ExpirationDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLinkTypeType
    {
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "edit")]
        Edit
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLinkScopeType
    {
        [EnumMember(Value = "anonymous")]
        Anonymous,
        [EnumMember(Value = "organization")]
        Organization,
        [EnumMember(Value = "users")]
        Users
    }

    public class SharingPermissionsList
    {
        [JsonProperty("value")]
        public SharingPermissionResponse[] Value { get; set; }
    }

    public class SharingPermissionResponse
    {
        [JsonProperty("id")]
        public string PermissionId { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("shareId")]
        public string ShareId { get; set; }

        [JsonProperty("grantedTo")]
        public SharingPermissionResponseGrantedToType GrantedTo { get; set; }

        [JsonProperty("link")]
        public SharingPermissionResponseLinkType Link { get; set; }

        [JsonProperty("invitation")]
        public SharingPermissionResponseInvitationType Invitation { get; set; }

        [JsonProperty("expirationDateTime")]
        public string ExpirationDateTime { get; set; }

        [JsonProperty("grantedToIdentities")]
        public SharingPermissionResponseGrantedToIdentitiesTypeItem[] GrantedToIdentities { get; set; }
    }

    public class SharingPermissionResponseGrantedToType
    {
        [JsonProperty("user")]
        public SharingPermissionResponseGrantedToTypeUserType User { get; set; }
    }

    public class SharingPermissionResponseGrantedToTypeUserType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string UserId { get; set; }
    }

    public class SharingPermissionResponseLinkType
    {
        [JsonProperty("scope")]
        public string LinkScope { get; set; }

        [JsonProperty("type")]
        public string LinkType { get; set; }

        [JsonProperty("webUrl")]
        public string WebURL { get; set; }
    }

    public class SharingPermissionResponseInvitationType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("signInRequired")]
        public bool SignInRequired { get; set; }
    }

    public class SharingPermissionResponseGrantedToIdentitiesTypeItem
    {
        [JsonProperty("user")]
        public SharingPermissionResponseGrantedToIdentitiesTypeItemUserType User { get; set; }
    }

    public class SharingPermissionResponseGrantedToIdentitiesTypeItemUserType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string UserId { get; set; }
    }

    public class SendSharingInvitationBodyInput
    {
        [JsonProperty("requireSignIn", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RequireSignIn { get; set; }

        [JsonProperty("roles", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRolesTypeItem[] Roles { get; set; }

        [JsonProperty("recipients", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("sendInvitation", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool SendInvitation { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRolesTypeItem
    {
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "write")]
        Write
    }

    public class BodyInputRecipientsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }
    }

    public class CreateFilePreviewResponse
    {
        [JsonProperty("getUrl")]
        public string GetURL { get; set; }

        [JsonProperty("postParameters")]
        public string PostParameters { get; set; }

        [JsonProperty("postUrl")]
        public string PostURL { get; set; }
    }

    public class CreateFilePreviewBodyInput
    {
        [JsonProperty("page")]
        public int? Page { get; set; }

        [JsonProperty("zoom")]
        public double? ZoomLevel { get; set; }
    }

    public class ListFileFieldsResponse
    {
        [JsonProperty("@odata.etag")]
        public string ETag { get; set; }
    }

    public class UpdateFileFieldsResponse
    {
        [JsonProperty("@odata.etag")]
        public string ETag { get; set; }
    }

    public class FileVersions
    {
        [JsonProperty("value")]
        public FileVersion[] Value { get; set; }
    }

    public class FileVersion
    {
        [JsonProperty("id")]
        public string VersionId { get; set; }

        [JsonProperty("lastModifiedBy")]
        public FileVersionLastModifiedByType LastModifiedBy { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModified { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("publication")]
        public FileVersionPublicationType Publication { get; set; }
    }

    public class FileVersionLastModifiedByType
    {
        [JsonProperty("user")]
        public FileVersionLastModifiedByTypeUserType User { get; set; }
    }

    public class FileVersionLastModifiedByTypeUserType
    {
        [JsonProperty("displayName")]
        public string ModifiedBy { get; set; }

        [JsonProperty("id")]
        public string UserId { get; set; }
    }

    public class FileVersionPublicationType
    {
        [JsonProperty("level")]
        public string PublicationLevel { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }
    }

    public class ThumbnailSets
    {
        [JsonProperty("value")]
        public ThumbnailSet[] Value { get; set; }
    }

    public class ThumbnailSet
    {
        [JsonProperty("id")]
        public string ThumbnailSetId { get; set; }

        [JsonProperty("large")]
        public Thumbnail Large { get; set; }

        [JsonProperty("medium")]
        public Thumbnail Medium { get; set; }

        [JsonProperty("small")]
        public Thumbnail Small { get; set; }

        [JsonProperty("source")]
        public Thumbnail Source { get; set; }
    }

    public class Thumbnail
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SizeInput
    {
        [EnumMember(Value = "small")]
        Small,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "large")]
        Large
    }

    public class CheckInFileBodyInput
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("checkInAs", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputCheckInAsType? CheckInAs { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointembedded.BodyInputCheckInAsType.None;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCheckInAsType
    {
        [EnumMember(Value = "published")]
        Published,
        [EnumMember(Value = "")]
        None
    }

    public class RecycleBinItemCollection
    {
        [JsonProperty("value")]
        public RecycleBinItem[] Value { get; set; }
    }

    public class RecycleBinItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("deletedDateTime")]
        public string DeletedDate { get; set; }

        [JsonProperty("deletedFromLocation")]
        public string DeletedFromLocation { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("deletedBy")]
        public RecycleBinItemDeletedByType DeletedBy { get; set; }
    }

    public class RecycleBinItemDeletedByType
    {
        [JsonProperty("user")]
        public RecycleBinItemDeletedByTypeUserType User { get; set; }
    }

    public class RecycleBinItemDeletedByTypeUserType
    {
        [JsonProperty("displayName")]
        public string DeletedBy { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string UserId { get; set; }
    }

    public class RestoreRecycledFilesResponse
    {
        [JsonProperty("value")]
        public RestoreRecycledFilesResponseValueTypeItem[] Value { get; set; }
    }

    public class RestoreRecycledFilesResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string ItemId { get; set; }
    }

    public class PermanentDeleteRecycledFilesBodyInput
    {
        [JsonProperty("ids", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ItemIDs { get; set; }
    }

    public class GetChangesContainerResponse
    {
        [JsonProperty("value")]
        public DriveItem[] Value { get; set; }

        [JsonProperty("@odata.deltaLink")]
        public string DeltaLink { get; set; }

        [JsonProperty("@odata.context")]
        public string Context { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointembedded;

    public partial class WorkflowManagedActions
    {
        public SharepointembeddedActions Sharepointembedded(string connectionId) => new SharepointembeddedActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SharepointembeddedTriggers Sharepointembedded(string connectionId) => new SharepointembeddedTriggers(connectionId);
    }
}