//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointembedded
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SharepointembeddedActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerList> ListContainers(Expression<Func<string>> containerType)
        {
            var apiCallPath = "/beta/storage/fileStorage/containers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["containerType"] = ExpressionConverter.Convert(containerType);
            return new ApiConnectionAction<FileStorageContainerList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction ActivateContainer(Expression<Func<string>> containerId)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/containers/{0}/activate", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction RecycleContainer(Expression<Func<string>> containerId)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/containers/{0}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainer> GetContainer(Expression<Func<string>> containerId)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/containers/{0}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FileStorageContainer>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainer> UpdateContainer(Expression<Func<string>> containerId, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydisplayName = null, Expression<Func<bool>> bodysettingsoCREnabled = null, Expression<Func<int>> bodysettingsitemMinorVersionLimit = null, Expression<Func<bool>> bodysettingsitemVersioningEnabled = null)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/containers/{0}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodydisplayName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                bodypropCount++;
            }

            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            if (bodysettingsoCREnabled != null)
            {
                settingsObject["isOcrEnabled"] = ExpressionConverter.ConvertO(bodysettingsoCREnabled);
                settingsObjectpropCount++;
            }

            if (bodysettingsitemMinorVersionLimit != null)
            {
                settingsObject["itemMinorVersionLimit"] = ExpressionConverter.ConvertO(bodysettingsitemMinorVersionLimit);
                settingsObjectpropCount++;
            }

            if (bodysettingsitemVersioningEnabled != null)
            {
                settingsObject["isItemVersioningEnabled"] = ExpressionConverter.ConvertO(bodysettingsitemVersioningEnabled);
                settingsObjectpropCount++;
            }

            if (settingsObjectpropCount > 0)
            {
                body["settings"] = settingsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FileStorageContainer>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerPermissionsList> ListPermissions(Expression<Func<string>> containerId)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/containers/{0}/permissions", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FileStorageContainerPermissionsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction DeletePermission(Expression<Func<string>> containerId, Expression<Func<string>> permissionId)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/containers/{0}/permissions/{1}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(permissionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerPermission> UpdatePermission(Expression<Func<string>> containerId, Expression<Func<string>> permissionId, Expression<Func<bodypermissionRolesInputItem[]>> bodypermissionRoles = null)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/containers/{0}/permissions/{1}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(permissionId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypermissionRoles != null)
            {
                body["roles"] = ExpressionConverter.ConvertO(bodypermissionRoles);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FileStorageContainerPermission>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerList> ListRecycledContainers(Expression<Func<string>> containerType)
        {
            var apiCallPath = "/beta/storage/fileStorage/deletedContainers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["containerType"] = ExpressionConverter.Convert(containerType);
            return new ApiConnectionAction<FileStorageContainerList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction DeleteContainer(Expression<Func<string>> containerId)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/deletedContainers/{0}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainer> RestoreContainer(Expression<Func<string>> containerId)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/deletedContainers/{0}/restore", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FileStorageContainer>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerColumnsList> ListContainerColumns(Expression<Func<string>> containerId, Expression<Func<string>> filter = null)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/containers/{0}/columns", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<FileStorageContainerColumnsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerColumn> CreateContainerColumn(Expression<Func<string>> containerId)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/containers/{0}/columns", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var columnDefinition = new JObject();
            var columnDefinitionpropCount = 0;
            if (columnDefinitionpropCount > 0)
            {
                callPayload.Body = columnDefinition;
            }

            return new ApiConnectionAction<FileStorageContainerColumn>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerColumn> GetContainerColumn(Expression<Func<string>> containerId, Expression<Func<string>> columnId)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/containers/{0}/columns/{1}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(columnId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FileStorageContainerColumn>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction DeleteContainerColumn(Expression<Func<string>> containerId, Expression<Func<string>> columnId)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/containers/{0}/columns/{1}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(columnId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerCustomProperties> GetContainerCustomProperties(Expression<Func<string>> containerId)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/containers/{0}/customProperties", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FileStorageContainerCustomProperties>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileStorageContainerCustomProperties> UpdateContainerCustomProperties(Expression<Func<string>> containerId)
        {
            var apiCallPath = String.Format("/beta/storage/fileStorage/containers/{0}/customProperties", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FileStorageContainerCustomProperties>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<DriveItemCollectionPage> ListContainerFiles(Expression<Func<string>> containerId, Expression<Func<string>> parentId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> expand = null, Expression<Func<int>> top = null, Expression<Func<string>> orderby = null)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["parentId"] = ExpressionConverter.Convert(parentId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$select"] = Convert.ToString("id,name,file,folder");
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Queries["$expand"] = Convert.ToString("listItem($expand=fields)");
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            callPayload.Queries["$top"] = Convert.ToString(20);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            if (orderby != null)
                callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
            return new ApiConnectionAction<DriveItemCollectionPage>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<DriveItem> GetFileProperties(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DriveItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<DriveItem> RenameFile(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<string>> bodyname = null)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DriveItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction GetFileContent(Expression<Func<string>> fileId, Expression<Func<string>> containerId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<string> UpdateFileContent(Expression<Func<string>> fileId, Expression<Func<string>> containerId, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<DriveItem> CreateFile(Expression<Func<string>> parentId, Expression<Func<string>> containerId, Expression<Func<string>> fileName, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}:/{2}:/content", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(parentId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<DriveItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<SharingLink> CreateSharingLink(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<bodylinkTypeInput>> bodylinkType, Expression<Func<bodylinkScopeInput>> bodylinkScope = null, Expression<Func<string>> bodyexpirationDate = null)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/createLink", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodylinkType);
            if (bodylinkScope != null)
            {
                body["scope"] = ExpressionConverter.ConvertO(bodylinkScope);
                bodypropCount++;
            }

            if (bodyexpirationDate != null)
            {
                body["expirationDateTime"] = ExpressionConverter.ConvertO(bodyexpirationDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SharingLink>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<SharingPermissionsList> SendSharingInvitation(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<bool>> bodyrequireSignIn, Expression<Func<bodyrolesInputItem[]>> bodyroles, Expression<Func<bodyrecipientsInputItem[]>> bodyrecipients, Expression<Func<string>> bodymessage, Expression<Func<bool>> bodysendInvitation)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/invite", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["requireSignIn"] = ExpressionConverter.ConvertO(bodyrequireSignIn);
            bodypropCount++;
            body["roles"] = ExpressionConverter.ConvertO(bodyroles);
            bodypropCount++;
            body["recipients"] = ExpressionConverter.ConvertO(bodyrecipients);
            bodypropCount++;
            body["message"] = ExpressionConverter.ConvertO(bodymessage);
            bodypropCount++;
            body["sendInvitation"] = ExpressionConverter.ConvertO(bodysendInvitation);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SharingPermissionsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<SharingPermissionsList> ListSharingPermissions(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/permissions", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SharingPermissionsList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<SharingPermissionResponse> GetSharingPermission(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<string>> permissionId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/permissions/{2}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1), ExpressionConverter.ConvertWithUrlEncoding(permissionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SharingPermissionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction DeleteSharingPermission(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<string>> permissionId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/permissions/{2}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1), ExpressionConverter.ConvertWithUrlEncoding(permissionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<CreateFilePreviewResponse> CreateFilePreview(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<int>> bodypage = null, Expression<Func<double>> bodyzoomLevel = null)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/preview", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypage != null)
            {
                body["page"] = ExpressionConverter.ConvertO(bodypage);
                bodypropCount++;
            }

            if (bodyzoomLevel != null)
            {
                body["zoom"] = ExpressionConverter.ConvertO(bodyzoomLevel);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateFilePreviewResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<ListFileFieldsResponse> ListFileFields(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/listitem/fields", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListFileFieldsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<UpdateFileFieldsResponse> UpdateFileFields(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/listitem/fields", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateFileFieldsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileVersions> ListFileVersions(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/versions", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FileVersions>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<FileVersion> GetFileVersion(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<string>> versionId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/versions/{2}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1), ExpressionConverter.ConvertWithUrlEncoding(versionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FileVersion>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction DeleteFileVersion(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<string>> versionId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/versions/{2}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1), ExpressionConverter.ConvertWithUrlEncoding(versionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<ThumbnailSets> ListFileThumbnails(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/thumbnails", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ThumbnailSets>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<Thumbnail> GetFileThumbnail(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<string>> thumbnailId, Expression<Func<sizeInput>> size)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/thumbnails/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1), ExpressionConverter.ConvertWithUrlEncoding(thumbnailId, 1), ExpressionConverter.ConvertWithUrlEncoding(size, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Thumbnail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction CheckInFile(Expression<Func<string>> containerId, Expression<Func<string>> fileId, Expression<Func<string>> bodycomment = null, Expression<Func<bodycheckInAsInput>> bodycheckInAs = null)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/checkin", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodycheckInAs != null)
            {
                body["checkInAs"] = ExpressionConverter.ConvertO(bodycheckInAs);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction CheckOutFile(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/checkout", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction DiscardCheckOut(Expression<Func<string>> containerId, Expression<Func<string>> fileId)
        {
            var apiCallPath = String.Format("/v1.0/drives/{0}/items/{1}/discardCheckout", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<RecycleBinItemCollection> ListRecycledFiles(Expression<Func<string>> containerId)
        {
            var apiCallPath = String.Format("/v1.0/storage/fileStorage/containers/{0}/recycleBin/items", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RecycleBinItemCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IBodyWorkflowAction<RestoreRecycledFilesResponse> RestoreRecycledFiles(Expression<Func<string>> containerId, Expression<Func<string[]>> bodyitemIDs)
        {
            var apiCallPath = String.Format("/v1.0/storage/fileStorage/containers/{0}/recycleBin/items/restore", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ids"] = ExpressionConverter.ConvertO(bodyitemIDs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RestoreRecycledFilesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointembedded")]
        public IWorkflowAction PermanentDeleteRecycledFiles(Expression<Func<string>> containerId, Expression<Func<string[]>> bodyitemIDs)
        {
            var apiCallPath = String.Format("/v1.0/storage/fileStorage/containers/{0}/recycleBin/items/delete", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ids"] = ExpressionConverter.ConvertO(bodyitemIDs);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class SharepointembeddedTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetChangesContainerResponse> GetChangesContainer(Expression<Func<string>> containerId, Expression<Func<int>> pollingInterval = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/v1.0/drives/{0}/root/delta", ExpressionConverter.ConvertWithUrlEncoding(containerId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["pollingInterval"] = Convert.ToString(300);
            if (pollingInterval != null)
                callPayload.Queries["pollingInterval"] = ExpressionConverter.Convert(pollingInterval);
            return new ApiConnectionTrigger<GetChangesContainerResponse>(callPayload, triggerName, recurrence);
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
        public string ContainerID { get; set; }

        [JsonProperty("containerTypeId")]
        public string ContainerTypeID { get; set; }

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
        public string PermissionID { get; set; }

        [JsonProperty("roles")]
        public FileStorageContainerPermissionRolesItem[] Roles { get; set; }

        [JsonProperty("grantedToV2")]
        public FileStorageContainerPermissionGrantedToV2Type GrantedToV2 { get; set; }
    }

    public enum FileStorageContainerPermissionRolesItem
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

    public class FileStorageContainerPermissionsList
    {
        [JsonProperty("value")]
        public FileStorageContainerPermission[] Value { get; set; }
    }

    public enum bodypermissionRolesInputItem
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

    public class FileStorageContainerColumnsList
    {
        [JsonProperty("value")]
        public FileStorageContainerColumn[] Value { get; set; }
    }

    public class FileStorageContainerColumn
    {
        [JsonProperty("id")]
        public string ColumnID { get; set; }

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

    public enum FileStorageContainerColumnDateTimeTypeDateTimeColumnDisplayAsType
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "friendly")]
        Friendly,
        [EnumMember(Value = "standard")]
        Standard
    }

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
        public string LookupColumnListID { get; set; }

        [JsonProperty("primaryLookupColumnId")]
        public string LookupColumnPrimaryLookupColumnID { get; set; }
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
        public string ContentTypeID { get; set; }

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
        public string ID { get; set; }

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
        public string DriveID { get; set; }

        [JsonProperty("id")]
        public string ParentID { get; set; }

        [JsonProperty("name")]
        public string ParentName { get; set; }

        [JsonProperty("path")]
        public string ParentPath { get; set; }

        [JsonProperty("siteId")]
        public string SiteID { get; set; }
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
        public string ApplicationID { get; set; }

        [JsonProperty("displayName")]
        public string ApplicationName { get; set; }
    }

    public class DriveItemCreatedByTypeUserType
    {
        [JsonProperty("id")]
        public string UserID { get; set; }

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
        public string ApplicationID { get; set; }

        [JsonProperty("displayName")]
        public string ApplicationName { get; set; }
    }

    public class DriveItemLastModifiedByTypeUserType
    {
        [JsonProperty("id")]
        public string UserID { get; set; }

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

    public class SharingLink
    {
        [JsonProperty("id")]
        public string LinkID { get; set; }

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

    public enum SharingLinkLinkTypeLinkTypeType
    {
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "edit")]
        Edit,
        [EnumMember(Value = "embed")]
        Embed
    }

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

    public enum bodylinkTypeInput
    {
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "edit")]
        Edit
    }

    public enum bodylinkScopeInput
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
        public string PermissionID { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("shareId")]
        public string ShareID { get; set; }

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
        public string UserID { get; set; }
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
        public string UserID { get; set; }
    }

    public enum bodyrolesInputItem
    {
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "write")]
        Write
    }

    public class bodyrecipientsInputItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("objectId")]
        public string ObjectID { get; set; }
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
        public string VersionID { get; set; }

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
        public string UserID { get; set; }
    }

    public class FileVersionPublicationType
    {
        [JsonProperty("level")]
        public string PublicationLevel { get; set; }

        [JsonProperty("versionId")]
        public string VersionID { get; set; }
    }

    public class ThumbnailSets
    {
        [JsonProperty("value")]
        public ThumbnailSet[] Value { get; set; }
    }

    public class ThumbnailSet
    {
        [JsonProperty("id")]
        public string ThumbnailSetID { get; set; }

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

    public enum sizeInput
    {
        [EnumMember(Value = "small")]
        Small,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "large")]
        Large
    }

    public enum bodycheckInAsInput
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
        public string ID { get; set; }

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
        public string UserID { get; set; }
    }

    public class RestoreRecycledFilesResponse
    {
        [JsonProperty("value")]
        public RestoreRecycledFilesResponseValueTypeItem[] Value { get; set; }
    }

    public class RestoreRecycledFilesResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string ItemID { get; set; }
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