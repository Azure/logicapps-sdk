//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fuxsyautodeskfusionm
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FuxsyautodeskfusionmActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<GroupsListResponse> GroupsList(Expression<Func<string>> offset = null, Expression<Func<string>> limit = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/api/v3/groups";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<GroupsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<GroupsDetailsResponse> GroupsDetails(Expression<Func<int>> groupID)
        {
            var apiCallPath = String.Format("/api/v3/groups/{0}", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GroupsDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<UsersInGroupResponse> UsersInGroup(Expression<Func<int>> groupID, Expression<Func<string>> offset = null, Expression<Func<string>> limit = null)
        {
            var apiCallPath = String.Format("/api/v3/groups/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<UsersInGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<UsersListResponse> UsersList(Expression<Func<string>> activeOnly = null, Expression<Func<string>> mappedOnly = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/api/v3/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (activeOnly != null)
                callPayload.Queries["activeOnly"] = ExpressionConverter.Convert(activeOnly);
            if (mappedOnly != null)
                callPayload.Queries["mappedOnly"] = ExpressionConverter.Convert(mappedOnly);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            return new ApiConnectionAction<UsersListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<UserDetailsResponse> UserDetails(Expression<Func<string>> userID)
        {
            var apiCallPath = String.Format("/api/v3/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<UserPermissionsListResponse> UserPermissionsList(Expression<Func<string>> userID)
        {
            var apiCallPath = String.Format("/api/v3/users/{0}/permissions", ExpressionConverter.ConvertWithUrlEncoding(userID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserPermissionsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<UserPermissionDetailsResponse> UserPermissionDetails(Expression<Func<int>> workspaceID, Expression<Func<string>> userID, Expression<Func<int>> permissionID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/users/{1}/permissions/{2}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(userID, 1), ExpressionConverter.ConvertWithUrlEncoding(permissionID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserPermissionDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<PermissionsListResponse> PermissionsList()
        {
            var apiCallPath = "/api/v3/permissions/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PermissionsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<PermissionDetailsResponse> PermissionDetails(Expression<Func<int>> permissionID)
        {
            var apiCallPath = String.Format("/api/v3/permissions/{0}", ExpressionConverter.ConvertWithUrlEncoding(permissionID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PermissionDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ManagedItemsResponse> ManagedItems(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/views/11", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ManagedItemsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<AttachmentDetailsResponse> AttachmentDetails(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<int>> attachmentID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/attachments/{2}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1), ExpressionConverter.ConvertWithUrlEncoding(attachmentID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AttachmentDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IWorkflowAction AttachmentCreateVersion(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<int>> attachmentID, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<object>> request123 = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/attachments/{2}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1), ExpressionConverter.ConvertWithUrlEncoding(attachmentID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(request123);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<UserViewDetailsResponse> UserViewDetails(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<int>> viewID, Expression<Func<string>> asc = null, Expression<Func<string>> desc = null, Expression<Func<string>> page = null, Expression<Func<string>> size = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/user-views/{2}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1), ExpressionConverter.ConvertWithUrlEncoding(viewID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (asc != null)
                callPayload.Queries["asc"] = ExpressionConverter.Convert(asc);
            if (desc != null)
                callPayload.Queries["desc"] = ExpressionConverter.Convert(desc);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<UserViewDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemManagedItemsListResponse> ItemManagedItemsList(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/affected-items", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ItemManagedItemsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IWorkflowAction CreateManagedItem(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<acceptInput>> accept = null, Expression<Func<object>> request123 = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/affected-items", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/vnd.autodesk.plm.affected.items.bulk+json");
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            callPayload.Body = ExpressionConverter.ConvertO(request123);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<UserViewsListResponse> UserViewsList(Expression<Func<int>> workspaceID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/user-views", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserViewsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemLogResponse> ItemLog(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<string>> offset = null, Expression<Func<string>> limit = null, Expression<Func<string>> asc = null, Expression<Func<string>> desc = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/logs", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (asc != null)
                callPayload.Queries["asc"] = ExpressionConverter.Convert(asc);
            if (desc != null)
                callPayload.Queries["desc"] = ExpressionConverter.Convert(desc);
            return new ApiConnectionAction<ItemLogResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemDetailsResponse> ItemDetails(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ItemDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IWorkflowAction UpdateItemDetails(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<object>> request123 = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(request123);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IWorkflowAction UpdateItemDetailsPartial(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<object>> request123 = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(request123);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ReportDownloadResponse> ReportDownload(Expression<Func<int>> workspaceID, Expression<Func<int>> reportID, Expression<Func<string>> page = null, Expression<Func<string>> asc = null, Expression<Func<string>> desc = null, Expression<Func<string>> size = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/reports/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(reportID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (asc != null)
                callPayload.Queries["asc"] = ExpressionConverter.Convert(asc);
            if (desc != null)
                callPayload.Queries["desc"] = ExpressionConverter.Convert(desc);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<ReportDownloadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ReportDetailsResponse> ReportDetails(Expression<Func<int>> reportID)
        {
            var apiCallPath = String.Format("/api/rest/v1/reports/{0}", ExpressionConverter.ConvertWithUrlEncoding(reportID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ReportDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<WorkspaceListResponse> WorkspaceList(Expression<Func<string>> limit = null)
        {
            var apiCallPath = "/api/v3/workspaces";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<WorkspaceListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ScriptListResponse> ScriptList(Expression<Func<string>> orderBy = null)
        {
            var apiCallPath = "/api/v3/scripts/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (orderBy != null)
                callPayload.Queries["orderBy"] = ExpressionConverter.Convert(orderBy);
            return new ApiConnectionAction<ScriptListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ScriptDetailsResponse> ScriptDetails(Expression<Func<int>> scriptID)
        {
            var apiCallPath = String.Format("/api/v3/scripts/{0}", ExpressionConverter.ConvertWithUrlEncoding(scriptID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ScriptDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<string[]> ItemRelationships(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/views/10", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemChangeLogResponse> ItemChangeLog(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/views/15", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ItemChangeLogResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<WorkspaceItemTabsListResponse> WorkspaceItemTabsList(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/tabs", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<WorkspaceItemTabsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<WorkspaceConfiguredViewListResponse> WorkspaceConfiguredViewList(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/views/", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<WorkspaceConfiguredViewListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<WorkspaceItemsListResponse> WorkspaceItemsList(Expression<Func<int>> workspaceID, Expression<Func<string>> limit = null, Expression<Func<acceptInput>> accept = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Headers["Accept"] = Convert.ToString("application/vnd.autodesk.plm.items.bulk+json");
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<WorkspaceItemsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IWorkflowAction ItemCreate(Expression<Func<int>> workspaceID, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<object>> request123 = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(request123);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<SearchInTenantResponse> SearchInTenant(Expression<Func<string>> query = null, Expression<Func<string>> limit = null, Expression<Func<string>> sort = null, Expression<Func<acceptInput>> accept = null)
        {
            var apiCallPath = "/api/v3/search-results";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (query != null)
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            callPayload.Headers["Accept"] = Convert.ToString("application/vnd.autodesk.plm.items.bulk+json");
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<SearchInTenantResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemGridRowsResponse> ItemGridRows(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/views/13/rows", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ItemGridRowsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IWorkflowAction AttachmentCreateFolder(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<object>> request123 = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/folders", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(request123);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<AttachmentListResponse> AttachmentList(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<string>> asc = null, Expression<Func<acceptInput>> accept = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/attachments", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (asc != null)
                callPayload.Queries["asc"] = ExpressionConverter.Convert(asc);
            callPayload.Headers["Accept"] = Convert.ToString("application/vnd.autodesk.plm.attachments.bulk+json");
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<AttachmentListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IWorkflowAction AttachmentCreateUpload(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<object>> request123 = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/attachments", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(request123);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<UserOutstandingWorkResponse> UserOutstandingWork(Expression<Func<userIDInput>> userID)
        {
            var apiCallPath = String.Format("/api/v3/users/{0}/outstanding-work", ExpressionConverter.ConvertWithUrlEncoding(userID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserOutstandingWorkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IWorkflowAction ItemGridRowUpdate(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<int>> rowID, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<object>> request123 = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/views/13/rows/{2}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1), ExpressionConverter.ConvertWithUrlEncoding(rowID, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(request123);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemRelationshipsListResponse> ItemRelationshipsList(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<string>> page = null, Expression<Func<string>> size = null, Expression<Func<string>> sort = null, Expression<Func<string>> sortDirection = null)
        {
            var apiCallPath = String.Format("/api/rest/v1/workspaces/{0}/items/{1}/relationships", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (sortDirection != null)
                callPayload.Queries["sortDirection"] = ExpressionConverter.Convert(sortDirection);
            return new ApiConnectionAction<ItemRelationshipsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemWhereUsedResponse> ItemWhereUsed(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/where-used", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ItemWhereUsedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemPrintViewResponse> ItemPrintView(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<string>> printViewID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/print-views/{2}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1), ExpressionConverter.ConvertWithUrlEncoding(printViewID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ItemPrintViewResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemGridFieldDetailsResponse> ItemGridFieldDetails(Expression<Func<int>> workspaceID, Expression<Func<int>> fieldID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/views/13/fields/{1}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(fieldID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ItemGridFieldDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemGridFieldsListResponse> ItemGridFieldsList(Expression<Func<int>> workspaceID, Expression<Func<acceptInput>> accept = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/views/13/fields", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/vnd.autodesk.plm.meta+json");
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<ItemGridFieldsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemDetailsFieldsListResponse> ItemDetailsFieldsList(Expression<Func<int>> workspaceID, Expression<Func<acceptInput>> accept = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/fields", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/vnd.autodesk.plm.meta+json");
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<ItemDetailsFieldsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemDetailsFieldTypesResponse> ItemDetailsFieldTypes()
        {
            var apiCallPath = "/api/v3/field-types/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ItemDetailsFieldTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemPrintViewsListResponse> ItemPrintViewsList(Expression<Func<int>> workspaceID, Expression<Func<string>> asc = null, Expression<Func<string>> desc = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/print-views", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (asc != null)
                callPayload.Queries["asc"] = ExpressionConverter.Convert(asc);
            if (desc != null)
                callPayload.Queries["desc"] = ExpressionConverter.Convert(desc);
            return new ApiConnectionAction<ItemPrintViewsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IWorkflowAction ScriptCreate(Expression<Func<contentTypeInput>> contentType, Expression<Func<object>> request123 = null)
        {
            var apiCallPath = "/api/v3/scripts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(request123);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<PicklistLookupsResponse> PicklistLookups(Expression<Func<string>> picklistID, Expression<Func<string>> offset = null, Expression<Func<string>> limit = null)
        {
            var apiCallPath = String.Format("/api/v3/lookups/{0}", ExpressionConverter.ConvertWithUrlEncoding(picklistID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            return new ApiConnectionAction<PicklistLookupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IWorkflowAction ItemCreateGridRow(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<contentTypeInput>> contentType = null, Expression<Func<object>> request123 = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/views/13/rows/", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(request123);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<WorkspaceTransitionslistResponse> WorkspaceTransitionslist(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/workflows/1/transitions", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<WorkspaceTransitionslistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemTransitionsAvailableResponse> ItemTransitionsAvailable(Expression<Func<int>> workspaceID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/workflows/1/transitions", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ItemTransitionsAvailableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<ItemTabOverviewResponse> ItemTabOverview(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<int>> viewID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/views/{2}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1), ExpressionConverter.ConvertWithUrlEncoding(viewID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ItemTabOverviewResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IWorkflowAction ItemTransition(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<int>> workflowID, Expression<Func<string>> contentLocation, Expression<Func<object>> request123 = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/workflows/{2}/transitions/", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1), ExpressionConverter.ConvertWithUrlEncoding(workflowID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-location"] = ExpressionConverter.Convert(contentLocation);
            callPayload.Body = ExpressionConverter.ConvertO(request123);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IBodyWorkflowAction<_200SectionsItem[]> ItemDetailSections(Expression<Func<int>> workspaceID)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/sections", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<_200SectionsItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fuxsyautodeskfusionm")]
        public IWorkflowAction ItemCreateRelationships(Expression<Func<int>> workspaceID, Expression<Func<int>> itemID, Expression<Func<contentLocationInput>> contentLocation = null, Expression<Func<object>> request123 = null)
        {
            var apiCallPath = String.Format("/api/v3/workspaces/{0}/items/{1}/views/10/", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1), ExpressionConverter.ConvertWithUrlEncoding(itemID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["content-location"] = Convert.ToString("/api/v3/workspaces/:WorkspaceID/items/:ItemID/views/10/linkable-items/:ItemID");
            if (contentLocation != null)
                callPayload.Headers["content-location"] = ExpressionConverter.Convert(contentLocation);
            callPayload.Body = ExpressionConverter.ConvertO(request123);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class FuxsyautodeskfusionmTriggers([ConnectionName] string connectionId)
    {
    }

    public class GroupsListResponse
    {
        [JsonProperty("properties")]
        public GroupsListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsListResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public GroupsListResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("groups")]
        public GroupsListResponsePropertiesTypeGroupsType Groups { get; set; }
    }

    public class GroupsListResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsListResponsePropertiesTypeGroupsType
    {
        [JsonProperty("items")]
        public GroupsListResponsePropertiesTypeGroupsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsListResponsePropertiesTypeGroupsTypeItemsType
    {
        [JsonProperty("properties")]
        public GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("exclusiveGroup")]
        public GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeExclusiveGroupType ExclusiveGroup { get; set; }

        [JsonProperty("invariantName")]
        public GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeInvariantNameType InvariantName { get; set; }

        [JsonProperty("isSystemManaged")]
        public GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeIsSystemManagedType IsSystemManaged { get; set; }

        [JsonProperty("longName")]
        public GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeLongNameType LongName { get; set; }

        [JsonProperty("mappedToOxygen")]
        public GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeMappedToOxygenType MappedToOxygen { get; set; }

        [JsonProperty("minUserCount")]
        public GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeMinUserCountType MinUserCount { get; set; }

        [JsonProperty("restrictIp")]
        public GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeRestrictIpType RestrictIp { get; set; }

        [JsonProperty("shortName")]
        public GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeShortNameType ShortName { get; set; }

        [JsonProperty("urn")]
        public GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeExclusiveGroupType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeInvariantNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeIsSystemManagedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeLongNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeMappedToOxygenType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeMinUserCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeRestrictIpType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeShortNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsListResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsDetailsResponse
    {
        [JsonProperty("properties")]
        public GroupsDetailsResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsDetailsResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public GroupsDetailsResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("exclusiveGroup")]
        public GroupsDetailsResponsePropertiesTypeExclusiveGroupType ExclusiveGroup { get; set; }

        [JsonProperty("isSystemManaged")]
        public GroupsDetailsResponsePropertiesTypeIsSystemManagedType IsSystemManaged { get; set; }

        [JsonProperty("mappedToOxygen")]
        public GroupsDetailsResponsePropertiesTypeMappedToOxygenType MappedToOxygen { get; set; }

        [JsonProperty("minUserCount")]
        public GroupsDetailsResponsePropertiesTypeMinUserCountType MinUserCount { get; set; }

        [JsonProperty("restrictIp")]
        public GroupsDetailsResponsePropertiesTypeRestrictIpType RestrictIp { get; set; }

        [JsonProperty("shortName")]
        public GroupsDetailsResponsePropertiesTypeShortNameType ShortName { get; set; }

        [JsonProperty("urn")]
        public GroupsDetailsResponsePropertiesTypeUrnType Urn { get; set; }
    }

    public class GroupsDetailsResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsDetailsResponsePropertiesTypeExclusiveGroupType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsDetailsResponsePropertiesTypeIsSystemManagedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsDetailsResponsePropertiesTypeMappedToOxygenType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsDetailsResponsePropertiesTypeMinUserCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsDetailsResponsePropertiesTypeRestrictIpType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsDetailsResponsePropertiesTypeShortNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GroupsDetailsResponsePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponse
    {
        [JsonProperty("properties")]
        public UsersInGroupResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public UsersInGroupResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("first")]
        public UsersInGroupResponsePropertiesTypeFirstType First { get; set; }

        [JsonProperty("items")]
        public UsersInGroupResponsePropertiesTypeItemsType Items { get; set; }

        [JsonProperty("last")]
        public UsersInGroupResponsePropertiesTypeLastType Last { get; set; }

        [JsonProperty("limit")]
        public UsersInGroupResponsePropertiesTypeLimitType Limit { get; set; }

        [JsonProperty("offset")]
        public UsersInGroupResponsePropertiesTypeOffsetType Offset { get; set; }

        [JsonProperty("totalCount")]
        public UsersInGroupResponsePropertiesTypeTotalCountType TotalCount { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeFirstType
    {
        [JsonProperty("properties")]
        public UsersInGroupResponsePropertiesTypeFirstTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeFirstTypePropertiesType
    {
        [JsonProperty("count")]
        public UsersInGroupResponsePropertiesTypeFirstTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public UsersInGroupResponsePropertiesTypeFirstTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public UsersInGroupResponsePropertiesTypeFirstTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public UsersInGroupResponsePropertiesTypeFirstTypePropertiesTypeTitleType Title { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeFirstTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeFirstTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeFirstTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeFirstTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsType
    {
        [JsonProperty("items")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsType
    {
        [JsonProperty("properties")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("aboutMe")]
        public JToken AboutMe { get; set; }

        [JsonProperty("active")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActiveType Active { get; set; }

        [JsonProperty("address1")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAddress1Type Address1 { get; set; }

        [JsonProperty("address2")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAddress2Type Address2 { get; set; }

        [JsonProperty("analyticsId")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAnalyticsIdType AnalyticsId { get; set; }

        [JsonProperty("batchNotifyPref")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBatchNotifyPrefType BatchNotifyPref { get; set; }

        [JsonProperty("cellular")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCellularType Cellular { get; set; }

        [JsonProperty("city")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCityType City { get; set; }

        [JsonProperty("consumeLicense")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeConsumeLicenseType ConsumeLicense { get; set; }

        [JsonProperty("country")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCountryType Country { get; set; }

        [JsonProperty("dashboardCharts")]
        public JToken DashboardCharts { get; set; }

        [JsonProperty("dateFormat")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDateFormatType DateFormat { get; set; }

        [JsonProperty("delegations")]
        public string[] Delegations { get; set; }

        [JsonProperty("displayName")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDisplayNameType DisplayName { get; set; }

        [JsonProperty("displayNameExtended")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDisplayNameExtendedType DisplayNameExtended { get; set; }

        [JsonProperty("email")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeEmailType Email { get; set; }

        [JsonProperty("enforce2fa")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeEnforce2faType Enforce2fa { get; set; }

        [JsonProperty("entitlement")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeEntitlementType Entitlement { get; set; }

        [JsonProperty("externalAuthReservationToken")]
        public JToken ExternalAuthReservationToken { get; set; }

        [JsonProperty("externalAuthUserId")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeExternalAuthUserIdType ExternalAuthUserId { get; set; }

        [JsonProperty("fax")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFaxType Fax { get; set; }

        [JsonProperty("firstName")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFirstNameType FirstName { get; set; }

        [JsonProperty("id")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeIdType Id { get; set; }

        [JsonProperty("industry")]
        public JToken Industry { get; set; }

        [JsonProperty("interfaceStyle")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeInterfaceStyleType InterfaceStyle { get; set; }

        [JsonProperty("interfaceStyleMandated")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeInterfaceStyleMandatedType InterfaceStyleMandated { get; set; }

        [JsonProperty("lastAccessTime")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastAccessTimeType LastAccessTime { get; set; }

        [JsonProperty("lastLicenseTimeIssued")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastLicenseTimeIssuedType LastLicenseTimeIssued { get; set; }

        [JsonProperty("lastLoginTime")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastLoginTimeType LastLoginTime { get; set; }

        [JsonProperty("lastMowUpdateDate")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastMowUpdateDateType LastMowUpdateDate { get; set; }

        [JsonProperty("lastName")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastNameType LastName { get; set; }

        [JsonProperty("lastRecalculateStarted")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastRecalculateStartedType LastRecalculateStarted { get; set; }

        [JsonProperty("lastRecalculateUpdate")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastRecalculateUpdateType LastRecalculateUpdate { get; set; }

        [JsonProperty("ldapEnabled")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLdapEnabledType LdapEnabled { get; set; }

        [JsonProperty("licenseFeatureId")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseFeatureIdType LicenseFeatureId { get; set; }

        [JsonProperty("licenseType")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeType LicenseType { get; set; }

        [JsonProperty("loginName")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLoginNameType LoginName { get; set; }

        [JsonProperty("mappedToOxygen")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMappedToOxygenType MappedToOxygen { get; set; }

        [JsonProperty("organization")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOrganizationType Organization { get; set; }

        [JsonProperty("phone")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypePhoneType Phone { get; set; }

        [JsonProperty("plmSearchCrawlerUser")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypePlmSearchCrawlerUserType PlmSearchCrawlerUser { get; set; }

        [JsonProperty("postal")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypePostalType Postal { get; set; }

        [JsonProperty("regularUser")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRegularUserType RegularUser { get; set; }

        [JsonProperty("reset")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeResetType Reset { get; set; }

        [JsonProperty("signupUrl")]
        public JToken SignupUrl { get; set; }

        [JsonProperty("stateProv")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeStateProvType StateProv { get; set; }

        [JsonProperty("surveyDone")]
        public JToken SurveyDone { get; set; }

        [JsonProperty("tenantAdmin")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTenantAdminType TenantAdmin { get; set; }

        [JsonProperty("thumbnailPref")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeThumbnailPrefType ThumbnailPref { get; set; }

        [JsonProperty("timezone")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTimezoneType Timezone { get; set; }

        [JsonProperty("title")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("twoFactorAuthEnabled")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTwoFactorAuthEnabledType TwoFactorAuthEnabled { get; set; }

        [JsonProperty("uomPref")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUomPrefType UomPref { get; set; }

        [JsonProperty("urn")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("userActive")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserActiveType UserActive { get; set; }

        [JsonProperty("userId")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserIdType UserId { get; set; }

        [JsonProperty("userInactive")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserInactiveType UserInactive { get; set; }

        [JsonProperty("userNumber")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserNumberType UserNumber { get; set; }

        [JsonProperty("userStatus")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserStatusType UserStatus { get; set; }

        [JsonProperty("wfNotifyPref")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWfNotifyPrefType WfNotifyPref { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActiveType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAddress1Type
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAddress2Type
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAnalyticsIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBatchNotifyPrefType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCellularType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCityType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeConsumeLicenseType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCountryType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDateFormatType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDisplayNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDisplayNameExtendedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeEmailType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeEnforce2faType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeEntitlementType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeExternalAuthUserIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFaxType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFirstNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeInterfaceStyleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeInterfaceStyleMandatedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastAccessTimeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastLicenseTimeIssuedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastLoginTimeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastMowUpdateDateType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastRecalculateStartedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLastRecalculateUpdateType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLdapEnabledType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseFeatureIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeType
    {
        [JsonProperty("properties")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("description")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesTypeDescriptionType Description { get; set; }

        [JsonProperty("link")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesTypeDescriptionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLicenseTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLoginNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMappedToOxygenType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOrganizationType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypePhoneType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypePlmSearchCrawlerUserType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypePostalType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRegularUserType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeResetType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeStateProvType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTenantAdminType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeThumbnailPrefType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTimezoneType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTwoFactorAuthEnabledType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUomPrefType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserActiveType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserInactiveType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserNumberType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserStatusType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWfNotifyPrefType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeLastType
    {
        [JsonProperty("properties")]
        public UsersInGroupResponsePropertiesTypeLastTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeLastTypePropertiesType
    {
        [JsonProperty("count")]
        public UsersInGroupResponsePropertiesTypeLastTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public UsersInGroupResponsePropertiesTypeLastTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public UsersInGroupResponsePropertiesTypeLastTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public UsersInGroupResponsePropertiesTypeLastTypePropertiesTypeTitleType Title { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeLastTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeLastTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeLastTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeLastTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeLimitType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeOffsetType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersInGroupResponsePropertiesTypeTotalCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersListResponse
    {
        [JsonProperty("properties")]
        public UsersListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersListResponsePropertiesType
    {
        [JsonProperty("users")]
        public UsersListResponsePropertiesTypeUsersType Users { get; set; }
    }

    public class UsersListResponsePropertiesTypeUsersType
    {
        [JsonProperty("items")]
        public UsersListResponsePropertiesTypeUsersTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersListResponsePropertiesTypeUsersTypeItemsType
    {
        [JsonProperty("properties")]
        public UsersListResponsePropertiesTypeUsersTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersListResponsePropertiesTypeUsersTypeItemsTypePropertiesType
    {
        [JsonProperty("deleted")]
        public UsersListResponsePropertiesTypeUsersTypeItemsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public UsersListResponsePropertiesTypeUsersTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public UsersListResponsePropertiesTypeUsersTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public UsersListResponsePropertiesTypeUsersTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class UsersListResponsePropertiesTypeUsersTypeItemsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersListResponsePropertiesTypeUsersTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersListResponsePropertiesTypeUsersTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UsersListResponsePropertiesTypeUsersTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponse
    {
        [JsonProperty("properties")]
        public UserDetailsResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public UserDetailsResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("aboutMe")]
        public JToken AboutMe { get; set; }

        [JsonProperty("active")]
        public UserDetailsResponsePropertiesTypeActiveType Active { get; set; }

        [JsonProperty("address1")]
        public UserDetailsResponsePropertiesTypeAddress1Type Address1 { get; set; }

        [JsonProperty("address2")]
        public UserDetailsResponsePropertiesTypeAddress2Type Address2 { get; set; }

        [JsonProperty("alerts")]
        public UserDetailsResponsePropertiesTypeAlertsType Alerts { get; set; }

        [JsonProperty("analyticsId")]
        public UserDetailsResponsePropertiesTypeAnalyticsIdType AnalyticsId { get; set; }

        [JsonProperty("batchNotifyPref")]
        public UserDetailsResponsePropertiesTypeBatchNotifyPrefType BatchNotifyPref { get; set; }

        [JsonProperty("cellular")]
        public JToken Cellular { get; set; }

        [JsonProperty("city")]
        public UserDetailsResponsePropertiesTypeCityType City { get; set; }

        [JsonProperty("consumeLicense")]
        public UserDetailsResponsePropertiesTypeConsumeLicenseType ConsumeLicense { get; set; }

        [JsonProperty("country")]
        public UserDetailsResponsePropertiesTypeCountryType Country { get; set; }

        [JsonProperty("dashboardCharts")]
        public JToken DashboardCharts { get; set; }

        [JsonProperty("dateFormat")]
        public UserDetailsResponsePropertiesTypeDateFormatType DateFormat { get; set; }

        [JsonProperty("delegations")]
        public UserDetailsResponsePropertiesTypeDelegationsType Delegations { get; set; }

        [JsonProperty("displayName")]
        public UserDetailsResponsePropertiesTypeDisplayNameType DisplayName { get; set; }

        [JsonProperty("displayNameExtended")]
        public UserDetailsResponsePropertiesTypeDisplayNameExtendedType DisplayNameExtended { get; set; }

        [JsonProperty("email")]
        public UserDetailsResponsePropertiesTypeEmailType Email { get; set; }

        [JsonProperty("enforce2fa")]
        public UserDetailsResponsePropertiesTypeEnforce2faType Enforce2fa { get; set; }

        [JsonProperty("entitlement")]
        public UserDetailsResponsePropertiesTypeEntitlementType Entitlement { get; set; }

        [JsonProperty("externalAuthReservationToken")]
        public JToken ExternalAuthReservationToken { get; set; }

        [JsonProperty("externalAuthUserId")]
        public UserDetailsResponsePropertiesTypeExternalAuthUserIdType ExternalAuthUserId { get; set; }

        [JsonProperty("fax")]
        public JToken Fax { get; set; }

        [JsonProperty("firstName")]
        public UserDetailsResponsePropertiesTypeFirstNameType FirstName { get; set; }

        [JsonProperty("groups")]
        public UserDetailsResponsePropertiesTypeGroupsType Groups { get; set; }

        [JsonProperty("id")]
        public UserDetailsResponsePropertiesTypeIdType Id { get; set; }

        [JsonProperty("image")]
        public UserDetailsResponsePropertiesTypeImageType Image { get; set; }

        [JsonProperty("industry")]
        public JToken Industry { get; set; }

        [JsonProperty("interfaceStyle")]
        public UserDetailsResponsePropertiesTypeInterfaceStyleType InterfaceStyle { get; set; }

        [JsonProperty("interfaceStyleMandated")]
        public UserDetailsResponsePropertiesTypeInterfaceStyleMandatedType InterfaceStyleMandated { get; set; }

        [JsonProperty("lastAccessTime")]
        public UserDetailsResponsePropertiesTypeLastAccessTimeType LastAccessTime { get; set; }

        [JsonProperty("lastLicenseTimeIssued")]
        public UserDetailsResponsePropertiesTypeLastLicenseTimeIssuedType LastLicenseTimeIssued { get; set; }

        [JsonProperty("lastLoginTime")]
        public UserDetailsResponsePropertiesTypeLastLoginTimeType LastLoginTime { get; set; }

        [JsonProperty("lastMowUpdateDate")]
        public UserDetailsResponsePropertiesTypeLastMowUpdateDateType LastMowUpdateDate { get; set; }

        [JsonProperty("lastName")]
        public UserDetailsResponsePropertiesTypeLastNameType LastName { get; set; }

        [JsonProperty("lastRecalculateStarted")]
        public UserDetailsResponsePropertiesTypeLastRecalculateStartedType LastRecalculateStarted { get; set; }

        [JsonProperty("lastRecalculateUpdate")]
        public UserDetailsResponsePropertiesTypeLastRecalculateUpdateType LastRecalculateUpdate { get; set; }

        [JsonProperty("ldapEnabled")]
        public UserDetailsResponsePropertiesTypeLdapEnabledType LdapEnabled { get; set; }

        [JsonProperty("licenseFeatureId")]
        public JToken LicenseFeatureId { get; set; }

        [JsonProperty("licenseType")]
        public UserDetailsResponsePropertiesTypeLicenseTypeType LicenseType { get; set; }

        [JsonProperty("loginName")]
        public UserDetailsResponsePropertiesTypeLoginNameType LoginName { get; set; }

        [JsonProperty("mappedToOxygen")]
        public UserDetailsResponsePropertiesTypeMappedToOxygenType MappedToOxygen { get; set; }

        [JsonProperty("organization")]
        public UserDetailsResponsePropertiesTypeOrganizationType Organization { get; set; }

        [JsonProperty("phone")]
        public JToken Phone { get; set; }

        [JsonProperty("plmSearchCrawlerUser")]
        public UserDetailsResponsePropertiesTypePlmSearchCrawlerUserType PlmSearchCrawlerUser { get; set; }

        [JsonProperty("postal")]
        public UserDetailsResponsePropertiesTypePostalType Postal { get; set; }

        [JsonProperty("preferences")]
        public UserDetailsResponsePropertiesTypePreferencesType Preferences { get; set; }

        [JsonProperty("regularUser")]
        public UserDetailsResponsePropertiesTypeRegularUserType RegularUser { get; set; }

        [JsonProperty("reset")]
        public UserDetailsResponsePropertiesTypeResetType Reset { get; set; }

        [JsonProperty("showEnableFullAccess")]
        public UserDetailsResponsePropertiesTypeShowEnableFullAccessType ShowEnableFullAccess { get; set; }

        [JsonProperty("signupUrl")]
        public JToken SignupUrl { get; set; }

        [JsonProperty("stateProv")]
        public UserDetailsResponsePropertiesTypeStateProvType StateProv { get; set; }

        [JsonProperty("surveyDone")]
        public UserDetailsResponsePropertiesTypeSurveyDoneType SurveyDone { get; set; }

        [JsonProperty("tenantAdmin")]
        public UserDetailsResponsePropertiesTypeTenantAdminType TenantAdmin { get; set; }

        [JsonProperty("thumbnailPref")]
        public UserDetailsResponsePropertiesTypeThumbnailPrefType ThumbnailPref { get; set; }

        [JsonProperty("timezone")]
        public UserDetailsResponsePropertiesTypeTimezoneType Timezone { get; set; }

        [JsonProperty("title")]
        public UserDetailsResponsePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("twoFaEnabled")]
        public UserDetailsResponsePropertiesTypeTwoFaEnabledType TwoFaEnabled { get; set; }

        [JsonProperty("twoFactorAuthEnabled")]
        public UserDetailsResponsePropertiesTypeTwoFactorAuthEnabledType TwoFactorAuthEnabled { get; set; }

        [JsonProperty("uomPref")]
        public UserDetailsResponsePropertiesTypeUomPrefType UomPref { get; set; }

        [JsonProperty("urn")]
        public UserDetailsResponsePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("userActive")]
        public UserDetailsResponsePropertiesTypeUserActiveType UserActive { get; set; }

        [JsonProperty("userId")]
        public UserDetailsResponsePropertiesTypeUserIdType UserId { get; set; }

        [JsonProperty("userInactive")]
        public UserDetailsResponsePropertiesTypeUserInactiveType UserInactive { get; set; }

        [JsonProperty("userNumber")]
        public UserDetailsResponsePropertiesTypeUserNumberType UserNumber { get; set; }

        [JsonProperty("userStatus")]
        public UserDetailsResponsePropertiesTypeUserStatusType UserStatus { get; set; }

        [JsonProperty("wfNotifyPref")]
        public UserDetailsResponsePropertiesTypeWfNotifyPrefType WfNotifyPref { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeActiveType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAddress1Type
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAddress2Type
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAlertsType
    {
        [JsonProperty("items")]
        public UserDetailsResponsePropertiesTypeAlertsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAlertsTypeItemsType
    {
        [JsonProperty("properties")]
        public UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesType
    {
        [JsonProperty("acknowledged")]
        public UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeAcknowledgedType Acknowledged { get; set; }

        [JsonProperty("deleted")]
        public UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("message")]
        public UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeMessageType Message { get; set; }

        [JsonProperty("priority")]
        public UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypePriorityType Priority { get; set; }

        [JsonProperty("title")]
        public UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urgent")]
        public UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeUrgentType Urgent { get; set; }

        [JsonProperty("urn")]
        public UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeAcknowledgedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeMessageType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypePriorityType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeUrgentType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAlertsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeAnalyticsIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeBatchNotifyPrefType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeCityType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeConsumeLicenseType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeCountryType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeDateFormatType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeDelegationsType
    {
        [JsonProperty("items")]
        public string Items { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeDisplayNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeDisplayNameExtendedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeEmailType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeEnforce2faType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeEntitlementType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeExternalAuthUserIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeFirstNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeGroupsType
    {
        [JsonProperty("items")]
        public UserDetailsResponsePropertiesTypeGroupsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeGroupsTypeItemsType
    {
        [JsonProperty("properties")]
        public UserDetailsResponsePropertiesTypeGroupsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeGroupsTypeItemsTypePropertiesType
    {
        [JsonProperty("link")]
        public UserDetailsResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("longName")]
        public UserDetailsResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeLongNameType LongName { get; set; }

        [JsonProperty("shortName")]
        public UserDetailsResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeShortNameType ShortName { get; set; }

        [JsonProperty("urn")]
        public UserDetailsResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeLongNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeShortNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeGroupsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeImageType
    {
        [JsonProperty("properties")]
        public UserDetailsResponsePropertiesTypeImageTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeImageTypePropertiesType
    {
        [JsonProperty("large")]
        public UserDetailsResponsePropertiesTypeImageTypePropertiesTypeLargeType Large { get; set; }

        [JsonProperty("medium")]
        public UserDetailsResponsePropertiesTypeImageTypePropertiesTypeMediumType Medium { get; set; }

        [JsonProperty("small")]
        public UserDetailsResponsePropertiesTypeImageTypePropertiesTypeSmallType Small { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeImageTypePropertiesTypeLargeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeImageTypePropertiesTypeMediumType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeImageTypePropertiesTypeSmallType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeInterfaceStyleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeInterfaceStyleMandatedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLastAccessTimeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLastLicenseTimeIssuedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLastLoginTimeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLastMowUpdateDateType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLastNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLastRecalculateStartedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLastRecalculateUpdateType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLdapEnabledType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLicenseTypeType
    {
        [JsonProperty("properties")]
        public UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("description")]
        public UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesTypeDescriptionType Description { get; set; }

        [JsonProperty("link")]
        public UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesTypeDescriptionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLicenseTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeLoginNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeMappedToOxygenType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeOrganizationType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypePlmSearchCrawlerUserType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypePostalType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypePreferencesType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeRegularUserType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeResetType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeShowEnableFullAccessType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeStateProvType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeSurveyDoneType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeTenantAdminType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeThumbnailPrefType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeTimezoneType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeTwoFaEnabledType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeTwoFactorAuthEnabledType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeUomPrefType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeUserActiveType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeUserIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeUserInactiveType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeUserNumberType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeUserStatusType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserDetailsResponsePropertiesTypeWfNotifyPrefType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionsListResponse
    {
        [JsonProperty("properties")]
        public UserPermissionsListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionsListResponsePropertiesType
    {
        [JsonProperty("permissions")]
        public UserPermissionsListResponsePropertiesTypePermissionsType Permissions { get; set; }
    }

    public class UserPermissionsListResponsePropertiesTypePermissionsType
    {
        [JsonProperty("items")]
        public UserPermissionsListResponsePropertiesTypePermissionsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionsListResponsePropertiesTypePermissionsTypeItemsType
    {
        [JsonProperty("properties")]
        public UserPermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesType
    {
        [JsonProperty("deleted")]
        public UserPermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public UserPermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("name")]
        public UserPermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeNameType Name { get; set; }

        [JsonProperty("title")]
        public UserPermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public UserPermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class UserPermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionDetailsResponse
    {
        [JsonProperty("properties")]
        public UserPermissionDetailsResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionDetailsResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public UserPermissionDetailsResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("id")]
        public UserPermissionDetailsResponsePropertiesTypeIdType Id { get; set; }

        [JsonProperty("longName")]
        public UserPermissionDetailsResponsePropertiesTypeLongNameType LongName { get; set; }

        [JsonProperty("shortName")]
        public UserPermissionDetailsResponsePropertiesTypeShortNameType ShortName { get; set; }

        [JsonProperty("urn")]
        public UserPermissionDetailsResponsePropertiesTypeUrnType Urn { get; set; }
    }

    public class UserPermissionDetailsResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionDetailsResponsePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionDetailsResponsePropertiesTypeLongNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionDetailsResponsePropertiesTypeShortNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserPermissionDetailsResponsePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionsListResponse
    {
        [JsonProperty("properties")]
        public PermissionsListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionsListResponsePropertiesType
    {
        [JsonProperty("permissions")]
        public PermissionsListResponsePropertiesTypePermissionsType Permissions { get; set; }
    }

    public class PermissionsListResponsePropertiesTypePermissionsType
    {
        [JsonProperty("items")]
        public PermissionsListResponsePropertiesTypePermissionsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionsListResponsePropertiesTypePermissionsTypeItemsType
    {
        [JsonProperty("properties")]
        public PermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesType
    {
        [JsonProperty("deleted")]
        public PermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public PermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("name")]
        public PermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeNameType Name { get; set; }

        [JsonProperty("title")]
        public PermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public PermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class PermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionsListResponsePropertiesTypePermissionsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionDetailsResponse
    {
        [JsonProperty("properties")]
        public PermissionDetailsResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionDetailsResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public PermissionDetailsResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("id")]
        public PermissionDetailsResponsePropertiesTypeIdType Id { get; set; }

        [JsonProperty("longName")]
        public PermissionDetailsResponsePropertiesTypeLongNameType LongName { get; set; }

        [JsonProperty("shortName")]
        public PermissionDetailsResponsePropertiesTypeShortNameType ShortName { get; set; }

        [JsonProperty("urn")]
        public PermissionDetailsResponsePropertiesTypeUrnType Urn { get; set; }
    }

    public class PermissionDetailsResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionDetailsResponsePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionDetailsResponsePropertiesTypeLongNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionDetailsResponsePropertiesTypeShortNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PermissionDetailsResponsePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponse
    {
        [JsonProperty("properties")]
        public ManagedItemsResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ManagedItemsResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("affectedItems")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsType AffectedItems { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsType
    {
        [JsonProperty("items")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsType
    {
        [JsonProperty("properties")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("item")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemType Item { get; set; }

        [JsonProperty("linkedFields")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsType LinkedFields { get; set; }

        [JsonProperty("type")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemType
    {
        [JsonProperty("properties")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsType
    {
        [JsonProperty("items")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsType
    {
        [JsonProperty("properties")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("isSystemField")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeIsSystemFieldType IsSystemField { get; set; }

        [JsonProperty("title")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("uom")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeUomType Uom { get; set; }

        [JsonProperty("uomConverted")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeUomConvertedType UomConverted { get; set; }

        [JsonProperty("urn")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("value")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeValueType Value { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeIsSystemFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeUomType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeUomConvertedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ManagedItemsResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentDetailsResponse
    {
        [JsonProperty("properties")]
        public AttachmentDetailsResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentDetailsResponsePropertiesType
    {
        [JsonProperty("fileUrl")]
        public AttachmentDetailsResponsePropertiesTypeFileUrlType FileUrl { get; set; }
    }

    public class AttachmentDetailsResponsePropertiesTypeFileUrlType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public enum contentTypeInput
    {
        [EnumMember(Value = "application/json")]
        ApplicationJson
    }

    public class UserViewDetailsResponse
    {
        [JsonProperty("properties")]
        public UserViewDetailsResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public UserViewDetailsResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("columns")]
        public UserViewDetailsResponsePropertiesTypeColumnsType Columns { get; set; }

        [JsonProperty("items")]
        public string[] Items { get; set; }

        [JsonProperty("pageNumber")]
        public UserViewDetailsResponsePropertiesTypePageNumberType PageNumber { get; set; }

        [JsonProperty("pageSize")]
        public UserViewDetailsResponsePropertiesTypePageSizeType PageSize { get; set; }

        [JsonProperty("sortingColumns")]
        public UserViewDetailsResponsePropertiesTypeSortingColumnsType SortingColumns { get; set; }

        [JsonProperty("total")]
        public UserViewDetailsResponsePropertiesTypeTotalType Total { get; set; }

        [JsonProperty("urn")]
        public UserViewDetailsResponsePropertiesTypeUrnType Urn { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeColumnsType
    {
        [JsonProperty("items")]
        public UserViewDetailsResponsePropertiesTypeColumnsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeColumnsTypeItemsType
    {
        [JsonProperty("properties")]
        public UserViewDetailsResponsePropertiesTypeColumnsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeColumnsTypeItemsTypePropertiesType
    {
        [JsonProperty("displayName")]
        public UserViewDetailsResponsePropertiesTypeColumnsTypeItemsTypePropertiesTypeDisplayNameType DisplayName { get; set; }

        [JsonProperty("id")]
        public UserViewDetailsResponsePropertiesTypeColumnsTypeItemsTypePropertiesTypeIdType Id { get; set; }

        [JsonProperty("index")]
        public UserViewDetailsResponsePropertiesTypeColumnsTypeItemsTypePropertiesTypeIndexType Index { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeColumnsTypeItemsTypePropertiesTypeDisplayNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeColumnsTypeItemsTypePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeColumnsTypeItemsTypePropertiesTypeIndexType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypePageNumberType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypePageSizeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeSortingColumnsType
    {
        [JsonProperty("items")]
        public UserViewDetailsResponsePropertiesTypeSortingColumnsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeSortingColumnsTypeItemsType
    {
        [JsonProperty("properties")]
        public UserViewDetailsResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesType
    {
        [JsonProperty("id")]
        public UserViewDetailsResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesTypeIdType Id { get; set; }

        [JsonProperty("index")]
        public UserViewDetailsResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesTypeIndexType Index { get; set; }

        [JsonProperty("order")]
        public UserViewDetailsResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesTypeOrderType Order { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesTypeIndexType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesTypeOrderType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeTotalType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewDetailsResponsePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponse
    {
        [JsonProperty("properties")]
        public ItemManagedItemsListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemManagedItemsListResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("affectedItems")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsType AffectedItems { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsType
    {
        [JsonProperty("items")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("item")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemType Item { get; set; }

        [JsonProperty("linkedFields")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsType LinkedFields { get; set; }

        [JsonProperty("type")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemType
    {
        [JsonProperty("properties")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsType
    {
        [JsonProperty("items")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("isSystemField")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeIsSystemFieldType IsSystemField { get; set; }

        [JsonProperty("title")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("uom")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeUomType Uom { get; set; }

        [JsonProperty("uomConverted")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeUomConvertedType UomConverted { get; set; }

        [JsonProperty("urn")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("value")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeValueType Value { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeIsSystemFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeUomType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeUomConvertedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeLinkedFieldsTypeItemsTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemManagedItemsListResponsePropertiesTypeAffectedItemsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public enum acceptInput
    {
        [EnumMember(Value = "application/vnd.autodesk.plm.meta+json")]
        ApplicationVndAutodeskPlmMetaJson,
        [EnumMember(Value = "application/json")]
        ApplicationJson
    }

    public class UserViewsListResponse
    {
        [JsonProperty("properties")]
        public UserViewsListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewsListResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public UserViewsListResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("links")]
        public UserViewsListResponsePropertiesTypeLinksType Links { get; set; }
    }

    public class UserViewsListResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewsListResponsePropertiesTypeLinksType
    {
        [JsonProperty("items")]
        public UserViewsListResponsePropertiesTypeLinksTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewsListResponsePropertiesTypeLinksTypeItemsType
    {
        [JsonProperty("properties")]
        public UserViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesType
    {
        [JsonProperty("deleted")]
        public UserViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public UserViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public UserViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public UserViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class UserViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponse
    {
        [JsonProperty("properties")]
        public ItemLogResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemLogResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("first")]
        public ItemLogResponsePropertiesTypeFirstType First { get; set; }

        [JsonProperty("items")]
        public ItemLogResponsePropertiesTypeItemsType Items { get; set; }

        [JsonProperty("last")]
        public ItemLogResponsePropertiesTypeLastType Last { get; set; }

        [JsonProperty("limit")]
        public ItemLogResponsePropertiesTypeLimitType Limit { get; set; }

        [JsonProperty("next")]
        public ItemLogResponsePropertiesTypeNextType Next { get; set; }

        [JsonProperty("offset")]
        public ItemLogResponsePropertiesTypeOffsetType Offset { get; set; }

        [JsonProperty("totalCount")]
        public ItemLogResponsePropertiesTypeTotalCountType TotalCount { get; set; }
    }

    public class ItemLogResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeFirstType
    {
        [JsonProperty("properties")]
        public ItemLogResponsePropertiesTypeFirstTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeFirstTypePropertiesType
    {
        [JsonProperty("count")]
        public ItemLogResponsePropertiesTypeFirstTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public ItemLogResponsePropertiesTypeFirstTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemLogResponsePropertiesTypeFirstTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemLogResponsePropertiesTypeFirstTypePropertiesTypeTitleType Title { get; set; }
    }

    public class ItemLogResponsePropertiesTypeFirstTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeFirstTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeFirstTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeFirstTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsType
    {
        [JsonProperty("items")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("action")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionType Action { get; set; }

        [JsonProperty("actionInvoker")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionInvokerType ActionInvoker { get; set; }

        [JsonProperty("description")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDescriptionType Description { get; set; }

        [JsonProperty("details")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsType Details { get; set; }

        [JsonProperty("timeStamp")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTimeStampType TimeStamp { get; set; }

        [JsonProperty("urn")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("user")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserType User { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionType
    {
        [JsonProperty("properties")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesType
    {
        [JsonProperty("longName")]
        public JToken LongName { get; set; }

        [JsonProperty("notifyPermission")]
        public JToken NotifyPermission { get; set; }

        [JsonProperty("shortName")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeShortNameType ShortName { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeShortNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionInvokerType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDescriptionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTimeStampType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserType
    {
        [JsonProperty("properties")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesType
    {
        [JsonProperty("email")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeEmailType Email { get; set; }

        [JsonProperty("image")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageType Image { get; set; }

        [JsonProperty("link")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("status")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeStatusType Status { get; set; }

        [JsonProperty("title")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeEmailType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageType
    {
        [JsonProperty("properties")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesType
    {
        [JsonProperty("large")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeLargeType Large { get; set; }

        [JsonProperty("medium")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeMediumType Medium { get; set; }

        [JsonProperty("small")]
        public ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeSmallType Small { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeLargeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeMediumType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeSmallType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeStatusType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeLastType
    {
        [JsonProperty("properties")]
        public ItemLogResponsePropertiesTypeLastTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeLastTypePropertiesType
    {
        [JsonProperty("count")]
        public ItemLogResponsePropertiesTypeLastTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public ItemLogResponsePropertiesTypeLastTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemLogResponsePropertiesTypeLastTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemLogResponsePropertiesTypeLastTypePropertiesTypeTitleType Title { get; set; }
    }

    public class ItemLogResponsePropertiesTypeLastTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeLastTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeLastTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeLastTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeLimitType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeNextType
    {
        [JsonProperty("properties")]
        public ItemLogResponsePropertiesTypeNextTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeNextTypePropertiesType
    {
        [JsonProperty("count")]
        public ItemLogResponsePropertiesTypeNextTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public ItemLogResponsePropertiesTypeNextTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemLogResponsePropertiesTypeNextTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemLogResponsePropertiesTypeNextTypePropertiesTypeTitleType Title { get; set; }
    }

    public class ItemLogResponsePropertiesTypeNextTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeNextTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeNextTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeNextTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeOffsetType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemLogResponsePropertiesTypeTotalCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponse
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemDetailsResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("audit")]
        public ItemDetailsResponsePropertiesTypeAuditType Audit { get; set; }

        [JsonProperty("bom")]
        public ItemDetailsResponsePropertiesTypeBomType Bom { get; set; }

        [JsonProperty("currentState")]
        public ItemDetailsResponsePropertiesTypeCurrentStateType CurrentState { get; set; }

        [JsonProperty("deleted")]
        public ItemDetailsResponsePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("flatBom")]
        public ItemDetailsResponsePropertiesTypeFlatBomType FlatBom { get; set; }

        [JsonProperty("itemLocked")]
        public ItemDetailsResponsePropertiesTypeItemLockedType ItemLocked { get; set; }

        [JsonProperty("latestRelease")]
        public ItemDetailsResponsePropertiesTypeLatestReleaseType LatestRelease { get; set; }

        [JsonProperty("lifecycle")]
        public ItemDetailsResponsePropertiesTypeLifecycleType Lifecycle { get; set; }

        [JsonProperty("milestones")]
        public ItemDetailsResponsePropertiesTypeMilestonesType Milestones { get; set; }

        [JsonProperty("nestedBom")]
        public ItemDetailsResponsePropertiesTypeNestedBomType NestedBom { get; set; }

        [JsonProperty("owners")]
        public ItemDetailsResponsePropertiesTypeOwnersType Owners { get; set; }

        [JsonProperty("revertible")]
        public ItemDetailsResponsePropertiesTypeRevertibleType Revertible { get; set; }

        [JsonProperty("root")]
        public ItemDetailsResponsePropertiesTypeRootType Root { get; set; }

        [JsonProperty("sections")]
        public ItemDetailsResponsePropertiesTypeSectionsType Sections { get; set; }

        [JsonProperty("sectionsLink")]
        public ItemDetailsResponsePropertiesTypeSectionsLinkType SectionsLink { get; set; }

        [JsonProperty("title")]
        public ItemDetailsResponsePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsResponsePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("whereUsed")]
        public ItemDetailsResponsePropertiesTypeWhereUsedType WhereUsed { get; set; }

        [JsonProperty("workflowReference")]
        public ItemDetailsResponsePropertiesTypeWorkflowReferenceType WorkflowReference { get; set; }

        [JsonProperty("workingHasChanged")]
        public ItemDetailsResponsePropertiesTypeWorkingHasChangedType WorkingHasChanged { get; set; }

        [JsonProperty("workingVersion")]
        public ItemDetailsResponsePropertiesTypeWorkingVersionType WorkingVersion { get; set; }

        [JsonProperty("workspace")]
        public ItemDetailsResponsePropertiesTypeWorkspaceType Workspace { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeAuditType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeAuditTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeAuditTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsResponsePropertiesTypeAuditTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsResponsePropertiesTypeAuditTypePropertiesTypeLinkType Link { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeAuditTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeAuditTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeBomType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeBomTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeBomTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsResponsePropertiesTypeBomTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsResponsePropertiesTypeBomTypePropertiesTypeLinkType Link { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeBomTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeBomTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeCurrentStateType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeCurrentStateTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeCurrentStateTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsResponsePropertiesTypeCurrentStateTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsResponsePropertiesTypeCurrentStateTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemDetailsResponsePropertiesTypeCurrentStateTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsResponsePropertiesTypeCurrentStateTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeCurrentStateTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeCurrentStateTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeCurrentStateTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeCurrentStateTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeFlatBomType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeFlatBomTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeFlatBomTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsResponsePropertiesTypeFlatBomTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsResponsePropertiesTypeFlatBomTypePropertiesTypeLinkType Link { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeFlatBomTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeFlatBomTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeItemLockedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeLatestReleaseType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeLifecycleType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeLifecycleTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeLifecycleTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsResponsePropertiesTypeLifecycleTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsResponsePropertiesTypeLifecycleTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemDetailsResponsePropertiesTypeLifecycleTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsResponsePropertiesTypeLifecycleTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeLifecycleTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeLifecycleTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeLifecycleTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeLifecycleTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeMilestonesType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeMilestonesTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeMilestonesTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsResponsePropertiesTypeMilestonesTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsResponsePropertiesTypeMilestonesTypePropertiesTypeLinkType Link { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeMilestonesTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeMilestonesTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeNestedBomType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeNestedBomTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeNestedBomTypePropertiesType
    {
        [JsonProperty("count")]
        public ItemDetailsResponsePropertiesTypeNestedBomTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public ItemDetailsResponsePropertiesTypeNestedBomTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsResponsePropertiesTypeNestedBomTypePropertiesTypeLinkType Link { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeNestedBomTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeNestedBomTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeNestedBomTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeOwnersType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeOwnersTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeOwnersTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsResponsePropertiesTypeOwnersTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsResponsePropertiesTypeOwnersTypePropertiesTypeLinkType Link { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeOwnersTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeOwnersTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeRevertibleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeRootType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeRootTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeRootTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsResponsePropertiesTypeRootTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsResponsePropertiesTypeRootTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemDetailsResponsePropertiesTypeRootTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsResponsePropertiesTypeRootTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeRootTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeRootTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeRootTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeRootTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsType
    {
        [JsonProperty("items")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesType
    {
        [JsonProperty("fields")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsType Fields { get; set; }

        [JsonProperty("link")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("sectionLocked")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeSectionLockedType SectionLocked { get; set; }

        [JsonProperty("title")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeTitleType Title { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsType
    {
        [JsonProperty("items")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("defaultValue")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeDefaultValueType DefaultValue { get; set; }

        [JsonProperty("formulaField")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeFormulaFieldType FormulaField { get; set; }

        [JsonProperty("isSystemField")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeIsSystemFieldType IsSystemField { get; set; }

        [JsonProperty("title")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("value")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeValueType Value { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeDefaultValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeFormulaFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeIsSystemFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeSectionLockedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeSectionsLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWhereUsedType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeWhereUsedTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWhereUsedTypePropertiesType
    {
        [JsonProperty("count")]
        public ItemDetailsResponsePropertiesTypeWhereUsedTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("link")]
        public ItemDetailsResponsePropertiesTypeWhereUsedTypePropertiesTypeLinkType Link { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWhereUsedTypePropertiesTypeCountType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesType
    {
        [JsonProperty("type")]
        public ItemDetailsResponsePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("value")]
        public ItemDetailsResponsePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesTypeValueType Value { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWhereUsedTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWorkflowReferenceType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWorkingHasChangedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWorkingVersionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWorkspaceType
    {
        [JsonProperty("properties")]
        public ItemDetailsResponsePropertiesTypeWorkspaceTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWorkspaceTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsResponsePropertiesTypeWorkspaceTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsResponsePropertiesTypeWorkspaceTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemDetailsResponsePropertiesTypeWorkspaceTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public ItemDetailsResponsePropertiesTypeWorkspaceTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsResponsePropertiesTypeWorkspaceTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWorkspaceTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWorkspaceTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWorkspaceTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWorkspaceTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsResponsePropertiesTypeWorkspaceTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponse
    {
        [JsonProperty("properties")]
        public ReportDownloadResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ReportDownloadResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("columns")]
        public ReportDownloadResponsePropertiesTypeColumnsType Columns { get; set; }

        [JsonProperty("items")]
        public ReportDownloadResponsePropertiesTypeItemsType Items { get; set; }

        [JsonProperty("pageNumber")]
        public ReportDownloadResponsePropertiesTypePageNumberType PageNumber { get; set; }

        [JsonProperty("pageSize")]
        public ReportDownloadResponsePropertiesTypePageSizeType PageSize { get; set; }

        [JsonProperty("sortingColumns")]
        public ReportDownloadResponsePropertiesTypeSortingColumnsType SortingColumns { get; set; }

        [JsonProperty("total")]
        public ReportDownloadResponsePropertiesTypeTotalType Total { get; set; }

        [JsonProperty("urn")]
        public ReportDownloadResponsePropertiesTypeUrnType Urn { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeColumnsType
    {
        [JsonProperty("items")]
        public ReportDownloadResponsePropertiesTypeColumnsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeColumnsTypeItemsType
    {
        [JsonProperty("properties")]
        public ReportDownloadResponsePropertiesTypeColumnsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeColumnsTypeItemsTypePropertiesType
    {
        [JsonProperty("displayName")]
        public ReportDownloadResponsePropertiesTypeColumnsTypeItemsTypePropertiesTypeDisplayNameType DisplayName { get; set; }

        [JsonProperty("id")]
        public ReportDownloadResponsePropertiesTypeColumnsTypeItemsTypePropertiesTypeIdType Id { get; set; }

        [JsonProperty("index")]
        public ReportDownloadResponsePropertiesTypeColumnsTypeItemsTypePropertiesTypeIndexType Index { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeColumnsTypeItemsTypePropertiesTypeDisplayNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeColumnsTypeItemsTypePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeColumnsTypeItemsTypePropertiesTypeIndexType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsType
    {
        [JsonProperty("items")]
        public ReportDownloadResponsePropertiesTypeItemsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsTypeItemsType
    {
        [JsonProperty("properties")]
        public ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesType
    {
        [JsonProperty("fields")]
        public ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFieldsType Fields { get; set; }

        [JsonProperty("index")]
        public ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeIndexType Index { get; set; }

        [JsonProperty("item")]
        public ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemType Item { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFieldsType
    {
        [JsonProperty("items")]
        public ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFieldsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFieldsTypeItemsType
    {
        [JsonProperty("properties")]
        public ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesType
    {
        [JsonProperty("id")]
        public ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeIdType Id { get; set; }

        [JsonProperty("value")]
        public ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeValueType Value { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeIndexType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemType
    {
        [JsonProperty("properties")]
        public ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("urn")]
        public ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypePageNumberType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypePageSizeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeSortingColumnsType
    {
        [JsonProperty("items")]
        public ReportDownloadResponsePropertiesTypeSortingColumnsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeSortingColumnsTypeItemsType
    {
        [JsonProperty("properties")]
        public ReportDownloadResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesType
    {
        [JsonProperty("id")]
        public ReportDownloadResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesTypeIdType Id { get; set; }

        [JsonProperty("index")]
        public ReportDownloadResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesTypeIndexType Index { get; set; }

        [JsonProperty("order")]
        public ReportDownloadResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesTypeOrderType Order { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesTypeIndexType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeSortingColumnsTypeItemsTypePropertiesTypeOrderType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeTotalType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDownloadResponsePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponse
    {
        [JsonProperty("properties")]
        public ReportDetailsResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesType
    {
        [JsonProperty("reportDefinition")]
        public ReportDetailsResponsePropertiesTypeReportDefinitionType ReportDefinition { get; set; }

        [JsonProperty("reportResult")]
        public ReportDetailsResponsePropertiesTypeReportResultType ReportResult { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportDefinitionType
    {
        [JsonProperty("properties")]
        public ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesType
    {
        [JsonProperty("hasOrphanFields")]
        public ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeHasOrphanFieldsType HasOrphanFields { get; set; }

        [JsonProperty("id")]
        public ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeIdType Id { get; set; }

        [JsonProperty("isChartReport")]
        public ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeIsChartReportType IsChartReport { get; set; }

        [JsonProperty("modifiedDate")]
        public ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeModifiedDateType ModifiedDate { get; set; }

        [JsonProperty("name")]
        public ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeNameType Name { get; set; }

        [JsonProperty("owner")]
        public ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeOwnerType Owner { get; set; }

        [JsonProperty("workspaceId")]
        public ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeWorkspaceIdType WorkspaceId { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeHasOrphanFieldsType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeIsChartReportType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeModifiedDateType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeOwnerType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportDefinitionTypePropertiesTypeWorkspaceIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultType
    {
        [JsonProperty("properties")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesType
    {
        [JsonProperty("columnKey")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeColumnKeyType ColumnKey { get; set; }

        [JsonProperty("row")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowType Row { get; set; }

        [JsonProperty("totalResultCount")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeTotalResultCountType TotalResultCount { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeColumnKeyType
    {
        [JsonProperty("items")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeColumnKeyTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeColumnKeyTypeItemsType
    {
        [JsonProperty("properties")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeColumnKeyTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeColumnKeyTypeItemsTypePropertiesType
    {
        [JsonProperty("label")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeColumnKeyTypeItemsTypePropertiesTypeLabelType Label { get; set; }

        [JsonProperty("value")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeColumnKeyTypeItemsTypePropertiesTypeValueType Value { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeColumnKeyTypeItemsTypePropertiesTypeLabelType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeColumnKeyTypeItemsTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowType
    {
        [JsonProperty("items")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsType
    {
        [JsonProperty("properties")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesType
    {
        [JsonProperty("fields")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsType Fields { get; set; }

        [JsonProperty("rowId")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeRowIdType RowId { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsType
    {
        [JsonProperty("properties")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesType
    {
        [JsonProperty("entry")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryType Entry { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryType
    {
        [JsonProperty("items")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsType
    {
        [JsonProperty("properties")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesType
    {
        [JsonProperty("fieldData")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesTypeFieldDataType FieldData { get; set; }

        [JsonProperty("key")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesTypeKeyType Key { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesTypeFieldDataType
    {
        [JsonProperty("properties")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesTypeFieldDataTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesTypeFieldDataTypePropertiesType
    {
        [JsonProperty("dataType")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesTypeFieldDataTypePropertiesTypeDataTypeType DataType { get; set; }

        [JsonProperty("label")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesTypeFieldDataTypePropertiesTypeLabelType Label { get; set; }

        [JsonProperty("value")]
        public ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesTypeFieldDataTypePropertiesTypeValueType Value { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesTypeFieldDataTypePropertiesTypeDataTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesTypeFieldDataTypePropertiesTypeLabelType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesTypeFieldDataTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeFieldsTypePropertiesTypeEntryTypeItemsTypePropertiesTypeKeyType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeRowTypeItemsTypePropertiesTypeRowIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ReportDetailsResponsePropertiesTypeReportResultTypePropertiesTypeTotalResultCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponse
    {
        [JsonProperty("properties")]
        public WorkspaceListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public WorkspaceListResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("first")]
        public WorkspaceListResponsePropertiesTypeFirstType First { get; set; }

        [JsonProperty("items")]
        public WorkspaceListResponsePropertiesTypeItemsType Items { get; set; }

        [JsonProperty("last")]
        public WorkspaceListResponsePropertiesTypeLastType Last { get; set; }

        [JsonProperty("limit")]
        public WorkspaceListResponsePropertiesTypeLimitType Limit { get; set; }

        [JsonProperty("offset")]
        public WorkspaceListResponsePropertiesTypeOffsetType Offset { get; set; }

        [JsonProperty("totalCount")]
        public WorkspaceListResponsePropertiesTypeTotalCountType TotalCount { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeFirstType
    {
        [JsonProperty("properties")]
        public WorkspaceListResponsePropertiesTypeFirstTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeFirstTypePropertiesType
    {
        [JsonProperty("count")]
        public WorkspaceListResponsePropertiesTypeFirstTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public WorkspaceListResponsePropertiesTypeFirstTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceListResponsePropertiesTypeFirstTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceListResponsePropertiesTypeFirstTypePropertiesTypeTitleType Title { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeFirstTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeFirstTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeFirstTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeFirstTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsType
    {
        [JsonProperty("items")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsType
    {
        [JsonProperty("properties")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesType
    {
        [JsonProperty("category")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCategoryType Category { get; set; }

        [JsonProperty("deleted")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("displayOrder")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDisplayOrderType DisplayOrder { get; set; }

        [JsonProperty("link")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("permissions")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypePermissionsType Permissions { get; set; }

        [JsonProperty("systemName")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSystemNameType SystemName { get; set; }

        [JsonProperty("title")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCategoryType
    {
        [JsonProperty("properties")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCategoryTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCategoryTypePropertiesType
    {
        [JsonProperty("displayOrder")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCategoryTypePropertiesTypeDisplayOrderType DisplayOrder { get; set; }

        [JsonProperty("icon")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCategoryTypePropertiesTypeIconType Icon { get; set; }

        [JsonProperty("name")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCategoryTypePropertiesTypeNameType Name { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCategoryTypePropertiesTypeDisplayOrderType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCategoryTypePropertiesTypeIconType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCategoryTypePropertiesTypeNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDisplayOrderType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypePermissionsType
    {
        [JsonProperty("items")]
        public WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypePermissionsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypePermissionsTypeItemsType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSystemNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeLastType
    {
        [JsonProperty("properties")]
        public WorkspaceListResponsePropertiesTypeLastTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeLastTypePropertiesType
    {
        [JsonProperty("count")]
        public WorkspaceListResponsePropertiesTypeLastTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public WorkspaceListResponsePropertiesTypeLastTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceListResponsePropertiesTypeLastTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceListResponsePropertiesTypeLastTypePropertiesTypeTitleType Title { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeLastTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeLastTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeLastTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeLastTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeLimitType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeOffsetType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceListResponsePropertiesTypeTotalCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponse
    {
        [JsonProperty("properties")]
        public ScriptListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ScriptListResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("scripts")]
        public ScriptListResponsePropertiesTypeScriptsType Scripts { get; set; }
    }

    public class ScriptListResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsType
    {
        [JsonProperty("items")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsType
    {
        [JsonProperty("properties")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("dependsOn")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnType DependsOn { get; set; }

        [JsonProperty("displayName")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDisplayNameType DisplayName { get; set; }

        [JsonProperty("scriptType")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeScriptTypeType ScriptType { get; set; }

        [JsonProperty("uniqueName")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeUniqueNameType UniqueName { get; set; }

        [JsonProperty("urn")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("version")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeVersionType Version { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnType
    {
        [JsonProperty("items")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnTypeItemsType
    {
        [JsonProperty("properties")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnTypeItemsTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnTypeItemsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnTypeItemsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDependsOnTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeDisplayNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeScriptTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeUniqueNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptListResponsePropertiesTypeScriptsTypeItemsTypePropertiesTypeVersionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptDetailsResponse
    {
        [JsonProperty("properties")]
        public ScriptDetailsResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptDetailsResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ScriptDetailsResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("code")]
        public ScriptDetailsResponsePropertiesTypeCodeType Code { get; set; }

        [JsonProperty("dependsOn")]
        public string[] DependsOn { get; set; }

        [JsonProperty("displayName")]
        public ScriptDetailsResponsePropertiesTypeDisplayNameType DisplayName { get; set; }

        [JsonProperty("scriptType")]
        public ScriptDetailsResponsePropertiesTypeScriptTypeType ScriptType { get; set; }

        [JsonProperty("uniqueName")]
        public ScriptDetailsResponsePropertiesTypeUniqueNameType UniqueName { get; set; }

        [JsonProperty("urn")]
        public ScriptDetailsResponsePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("version")]
        public ScriptDetailsResponsePropertiesTypeVersionType Version { get; set; }
    }

    public class ScriptDetailsResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptDetailsResponsePropertiesTypeCodeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptDetailsResponsePropertiesTypeDisplayNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptDetailsResponsePropertiesTypeScriptTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptDetailsResponsePropertiesTypeUniqueNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptDetailsResponsePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ScriptDetailsResponsePropertiesTypeVersionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponse
    {
        [JsonProperty("properties")]
        public ItemChangeLogResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemChangeLogResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("first")]
        public ItemChangeLogResponsePropertiesTypeFirstType First { get; set; }

        [JsonProperty("items")]
        public ItemChangeLogResponsePropertiesTypeItemsType Items { get; set; }

        [JsonProperty("last")]
        public ItemChangeLogResponsePropertiesTypeLastType Last { get; set; }

        [JsonProperty("limit")]
        public ItemChangeLogResponsePropertiesTypeLimitType Limit { get; set; }

        [JsonProperty("next")]
        public ItemChangeLogResponsePropertiesTypeNextType Next { get; set; }

        [JsonProperty("offset")]
        public ItemChangeLogResponsePropertiesTypeOffsetType Offset { get; set; }

        [JsonProperty("totalCount")]
        public ItemChangeLogResponsePropertiesTypeTotalCountType TotalCount { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeFirstType
    {
        [JsonProperty("properties")]
        public ItemChangeLogResponsePropertiesTypeFirstTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeFirstTypePropertiesType
    {
        [JsonProperty("count")]
        public ItemChangeLogResponsePropertiesTypeFirstTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public ItemChangeLogResponsePropertiesTypeFirstTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemChangeLogResponsePropertiesTypeFirstTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemChangeLogResponsePropertiesTypeFirstTypePropertiesTypeTitleType Title { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeFirstTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeFirstTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeFirstTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeFirstTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsType
    {
        [JsonProperty("items")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("action")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionType Action { get; set; }

        [JsonProperty("actionInvoker")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionInvokerType ActionInvoker { get; set; }

        [JsonProperty("description")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDescriptionType Description { get; set; }

        [JsonProperty("details")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsType Details { get; set; }

        [JsonProperty("timeStamp")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTimeStampType TimeStamp { get; set; }

        [JsonProperty("urn")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("user")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserType User { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionType
    {
        [JsonProperty("properties")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesType
    {
        [JsonProperty("longName")]
        public JToken LongName { get; set; }

        [JsonProperty("notifyPermission")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeNotifyPermissionType NotifyPermission { get; set; }

        [JsonProperty("shortName")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeShortNameType ShortName { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeNotifyPermissionType
    {
        [JsonProperty("properties")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeNotifyPermissionTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeNotifyPermissionTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeNotifyPermissionTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeNotifyPermissionTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeNotifyPermissionTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeNotifyPermissionTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeNotifyPermissionTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeNotifyPermissionTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeNotifyPermissionTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeNotifyPermissionTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeShortNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionInvokerType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDescriptionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsType
    {
        [JsonProperty("items")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesType
    {
        [JsonProperty("fieldName")]
        public JToken FieldName { get; set; }

        [JsonProperty("newValue")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesTypeNewValueType NewValue { get; set; }

        [JsonProperty("oldValue")]
        public JToken OldValue { get; set; }

        [JsonProperty("type")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesTypeTypeType Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesTypeNewValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("urn")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTimeStampType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserType
    {
        [JsonProperty("properties")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesType
    {
        [JsonProperty("email")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeEmailType Email { get; set; }

        [JsonProperty("image")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageType Image { get; set; }

        [JsonProperty("link")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("status")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeStatusType Status { get; set; }

        [JsonProperty("title")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeEmailType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageType
    {
        [JsonProperty("properties")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesType
    {
        [JsonProperty("large")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeLargeType Large { get; set; }

        [JsonProperty("medium")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeMediumType Medium { get; set; }

        [JsonProperty("small")]
        public ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeSmallType Small { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeLargeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeMediumType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeSmallType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeStatusType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeLastType
    {
        [JsonProperty("properties")]
        public ItemChangeLogResponsePropertiesTypeLastTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeLastTypePropertiesType
    {
        [JsonProperty("count")]
        public ItemChangeLogResponsePropertiesTypeLastTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public ItemChangeLogResponsePropertiesTypeLastTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemChangeLogResponsePropertiesTypeLastTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemChangeLogResponsePropertiesTypeLastTypePropertiesTypeTitleType Title { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeLastTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeLastTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeLastTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeLastTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeLimitType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeNextType
    {
        [JsonProperty("properties")]
        public ItemChangeLogResponsePropertiesTypeNextTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeNextTypePropertiesType
    {
        [JsonProperty("count")]
        public ItemChangeLogResponsePropertiesTypeNextTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public ItemChangeLogResponsePropertiesTypeNextTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemChangeLogResponsePropertiesTypeNextTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemChangeLogResponsePropertiesTypeNextTypePropertiesTypeTitleType Title { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeNextTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeNextTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeNextTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeNextTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeOffsetType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemChangeLogResponsePropertiesTypeTotalCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemTabsListResponse
    {
        [JsonProperty("properties")]
        public WorkspaceItemTabsListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemTabsListResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public WorkspaceItemTabsListResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("tabs")]
        public WorkspaceItemTabsListResponsePropertiesTypeTabsType Tabs { get; set; }
    }

    public class WorkspaceItemTabsListResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemTabsListResponsePropertiesTypeTabsType
    {
        [JsonProperty("items")]
        public WorkspaceItemTabsListResponsePropertiesTypeTabsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemTabsListResponsePropertiesTypeTabsTypeItemsType
    {
        [JsonProperty("properties")]
        public WorkspaceItemTabsListResponsePropertiesTypeTabsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemTabsListResponsePropertiesTypeTabsTypeItemsTypePropertiesType
    {
        [JsonProperty("name")]
        public WorkspaceItemTabsListResponsePropertiesTypeTabsTypeItemsTypePropertiesTypeNameType Name { get; set; }

        [JsonProperty("sectionCounts")]
        public JToken SectionCounts { get; set; }

        [JsonProperty("totalCount")]
        public WorkspaceItemTabsListResponsePropertiesTypeTabsTypeItemsTypePropertiesTypeTotalCountType TotalCount { get; set; }
    }

    public class WorkspaceItemTabsListResponsePropertiesTypeTabsTypeItemsTypePropertiesTypeNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemTabsListResponsePropertiesTypeTabsTypeItemsTypePropertiesTypeTotalCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceConfiguredViewListResponse
    {
        [JsonProperty("items")]
        public WorkspaceConfiguredViewListResponseItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceConfiguredViewListResponseItemsType
    {
        [JsonProperty("properties")]
        public WorkspaceConfiguredViewListResponseItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceConfiguredViewListResponseItemsTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceConfiguredViewListResponseItemsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceConfiguredViewListResponseItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceConfiguredViewListResponseItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public WorkspaceConfiguredViewListResponseItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class WorkspaceConfiguredViewListResponseItemsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceConfiguredViewListResponseItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceConfiguredViewListResponseItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceConfiguredViewListResponseItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponse
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public WorkspaceItemsListResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("first")]
        public WorkspaceItemsListResponsePropertiesTypeFirstType First { get; set; }

        [JsonProperty("items")]
        public WorkspaceItemsListResponsePropertiesTypeItemsType Items { get; set; }

        [JsonProperty("last")]
        public WorkspaceItemsListResponsePropertiesTypeLastType Last { get; set; }

        [JsonProperty("limit")]
        public WorkspaceItemsListResponsePropertiesTypeLimitType Limit { get; set; }

        [JsonProperty("next")]
        public WorkspaceItemsListResponsePropertiesTypeNextType Next { get; set; }

        [JsonProperty("offset")]
        public WorkspaceItemsListResponsePropertiesTypeOffsetType Offset { get; set; }

        [JsonProperty("totalCount")]
        public WorkspaceItemsListResponsePropertiesTypeTotalCountType TotalCount { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeFirstType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeFirstTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeFirstTypePropertiesType
    {
        [JsonProperty("count")]
        public WorkspaceItemsListResponsePropertiesTypeFirstTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeFirstTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeFirstTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceItemsListResponsePropertiesTypeFirstTypePropertiesTypeTitleType Title { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeFirstTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeFirstTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeFirstTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeFirstTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsType
    {
        [JsonProperty("items")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("audit")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditType Audit { get; set; }

        [JsonProperty("bom")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomType Bom { get; set; }

        [JsonProperty("currentState")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateType CurrentState { get; set; }

        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("flatBom")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomType FlatBom { get; set; }

        [JsonProperty("itemLocked")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemLockedType ItemLocked { get; set; }

        [JsonProperty("latestRelease")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLatestReleaseType LatestRelease { get; set; }

        [JsonProperty("lifecycle")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleType Lifecycle { get; set; }

        [JsonProperty("milestones")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesType Milestones { get; set; }

        [JsonProperty("nestedBom")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomType NestedBom { get; set; }

        [JsonProperty("owners")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersType Owners { get; set; }

        [JsonProperty("root")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootType Root { get; set; }

        [JsonProperty("sections")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsType Sections { get; set; }

        [JsonProperty("sectionsLink")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsLinkType SectionsLink { get; set; }

        [JsonProperty("title")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("whereUsed")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedType WhereUsed { get; set; }

        [JsonProperty("workflowReference")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkflowReferenceType WorkflowReference { get; set; }

        [JsonProperty("workingHasChanged")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkingHasChangedType WorkingHasChanged { get; set; }

        [JsonProperty("workingVersion")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkingVersionType WorkingVersion { get; set; }

        [JsonProperty("workspace")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceType Workspace { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditTypePropertiesTypeLinkType Link { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomTypePropertiesTypeLinkType Link { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomTypePropertiesTypeLinkType Link { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemLockedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLatestReleaseType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesTypePropertiesTypeLinkType Link { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesType
    {
        [JsonProperty("count")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesTypeLinkType Link { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersTypePropertiesTypeLinkType Link { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsType
    {
        [JsonProperty("items")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesType
    {
        [JsonProperty("fields")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsType Fields { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("sectionLocked")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeSectionLockedType SectionLocked { get; set; }

        [JsonProperty("title")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeTitleType Title { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsType
    {
        [JsonProperty("items")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("defaultValue")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeDefaultValueType DefaultValue { get; set; }

        [JsonProperty("formulaField")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeFormulaFieldType FormulaField { get; set; }

        [JsonProperty("isSystemField")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeIsSystemFieldType IsSystemField { get; set; }

        [JsonProperty("title")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("value")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeValueType Value { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeDefaultValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeFormulaFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeIsSystemFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeSectionLockedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesType
    {
        [JsonProperty("count")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeLinkType Link { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesType
    {
        [JsonProperty("type")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("value")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesTypeValueType Value { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkflowReferenceType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkingHasChangedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkingVersionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeLastType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeLastTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeLastTypePropertiesType
    {
        [JsonProperty("count")]
        public WorkspaceItemsListResponsePropertiesTypeLastTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeLastTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeLastTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceItemsListResponsePropertiesTypeLastTypePropertiesTypeTitleType Title { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeLastTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeLastTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeLastTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeLastTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeLimitType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeNextType
    {
        [JsonProperty("properties")]
        public WorkspaceItemsListResponsePropertiesTypeNextTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeNextTypePropertiesType
    {
        [JsonProperty("count")]
        public WorkspaceItemsListResponsePropertiesTypeNextTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public WorkspaceItemsListResponsePropertiesTypeNextTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceItemsListResponsePropertiesTypeNextTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceItemsListResponsePropertiesTypeNextTypePropertiesTypeTitleType Title { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeNextTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeNextTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeNextTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeNextTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeOffsetType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceItemsListResponsePropertiesTypeTotalCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponse
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public SearchInTenantResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("first")]
        public SearchInTenantResponsePropertiesTypeFirstType First { get; set; }

        [JsonProperty("items")]
        public SearchInTenantResponsePropertiesTypeItemsType Items { get; set; }

        [JsonProperty("last")]
        public SearchInTenantResponsePropertiesTypeLastType Last { get; set; }

        [JsonProperty("limit")]
        public SearchInTenantResponsePropertiesTypeLimitType Limit { get; set; }

        [JsonProperty("offset")]
        public SearchInTenantResponsePropertiesTypeOffsetType Offset { get; set; }

        [JsonProperty("totalCount")]
        public SearchInTenantResponsePropertiesTypeTotalCountType TotalCount { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeFirstType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeFirstTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeFirstTypePropertiesType
    {
        [JsonProperty("count")]
        public SearchInTenantResponsePropertiesTypeFirstTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeFirstTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeFirstTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public SearchInTenantResponsePropertiesTypeFirstTypePropertiesTypeTitleType Title { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeFirstTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeFirstTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeFirstTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeFirstTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsType
    {
        [JsonProperty("items")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("audit")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditType Audit { get; set; }

        [JsonProperty("bom")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomType Bom { get; set; }

        [JsonProperty("currentState")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateType CurrentState { get; set; }

        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("flatBom")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomType FlatBom { get; set; }

        [JsonProperty("itemLocked")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemLockedType ItemLocked { get; set; }

        [JsonProperty("latestRelease")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLatestReleaseType LatestRelease { get; set; }

        [JsonProperty("lifecycle")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleType Lifecycle { get; set; }

        [JsonProperty("milestones")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesType Milestones { get; set; }

        [JsonProperty("nestedBom")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomType NestedBom { get; set; }

        [JsonProperty("owners")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersType Owners { get; set; }

        [JsonProperty("root")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootType Root { get; set; }

        [JsonProperty("sections")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsType Sections { get; set; }

        [JsonProperty("sectionsLink")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsLinkType SectionsLink { get; set; }

        [JsonProperty("title")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("whereUsed")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedType WhereUsed { get; set; }

        [JsonProperty("workflowReference")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkflowReferenceType WorkflowReference { get; set; }

        [JsonProperty("workingHasChanged")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkingHasChangedType WorkingHasChanged { get; set; }

        [JsonProperty("workingVersion")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkingVersionType WorkingVersion { get; set; }

        [JsonProperty("workspace")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceType Workspace { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditTypePropertiesType
    {
        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditTypePropertiesTypeLinkType Link { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeAuditTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomTypePropertiesType
    {
        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomTypePropertiesTypeLinkType Link { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeBomTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesType
    {
        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeCurrentStateTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomTypePropertiesType
    {
        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomTypePropertiesTypeLinkType Link { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeFlatBomTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeItemLockedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLatestReleaseType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesType
    {
        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLifecycleTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesTypePropertiesType
    {
        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesTypePropertiesTypeLinkType Link { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeMilestonesTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesType
    {
        [JsonProperty("count")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesTypeLinkType Link { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeNestedBomTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersTypePropertiesType
    {
        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersTypePropertiesTypeLinkType Link { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeOwnersTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesType
    {
        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeRootTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsType
    {
        [JsonProperty("items")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesType
    {
        [JsonProperty("fields")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsType Fields { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("sectionLocked")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeSectionLockedType SectionLocked { get; set; }

        [JsonProperty("title")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeTitleType Title { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsType
    {
        [JsonProperty("items")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("defaultValue")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeDefaultValueType DefaultValue { get; set; }

        [JsonProperty("formulaField")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeFormulaFieldType FormulaField { get; set; }

        [JsonProperty("isSystemField")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeIsSystemFieldType IsSystemField { get; set; }

        [JsonProperty("title")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("value")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeValueType Value { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeDefaultValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeFormulaFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeIsSystemFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeSectionLockedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSectionsLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesType
    {
        [JsonProperty("count")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeLinkType Link { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesType
    {
        [JsonProperty("type")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("value")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesTypeValueType Value { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeCountTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWhereUsedTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkflowReferenceType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkingHasChangedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkingVersionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesType
    {
        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeLastType
    {
        [JsonProperty("properties")]
        public SearchInTenantResponsePropertiesTypeLastTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeLastTypePropertiesType
    {
        [JsonProperty("count")]
        public SearchInTenantResponsePropertiesTypeLastTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public SearchInTenantResponsePropertiesTypeLastTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public SearchInTenantResponsePropertiesTypeLastTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public SearchInTenantResponsePropertiesTypeLastTypePropertiesTypeTitleType Title { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeLastTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeLastTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeLastTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeLastTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeLimitType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeOffsetType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SearchInTenantResponsePropertiesTypeTotalCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponse
    {
        [JsonProperty("properties")]
        public ItemGridRowsResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesType
    {
        [JsonProperty("aggregations")]
        public ItemGridRowsResponsePropertiesTypeAggregationsType Aggregations { get; set; }

        [JsonProperty("rows")]
        public ItemGridRowsResponsePropertiesTypeRowsType Rows { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsType
    {
        [JsonProperty("items")]
        public ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("isSystemField")]
        public ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeIsSystemFieldType IsSystemField { get; set; }

        [JsonProperty("title")]
        public ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("value")]
        public ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeValueType Value { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeIsSystemFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeAggregationsTypeItemsTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsType
    {
        [JsonProperty("items")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesType
    {
        [JsonProperty("metaFieldTableBean")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeMetaFieldTableBeanType MetaFieldTableBean { get; set; }

        [JsonProperty("rowData")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataType RowData { get; set; }

        [JsonProperty("rowID")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowIDType RowID { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeMetaFieldTableBeanType
    {
        [JsonProperty("properties")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeMetaFieldTableBeanTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeMetaFieldTableBeanTypePropertiesType
    {
        [JsonProperty("dataMap")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeMetaFieldTableBeanTypePropertiesTypeDataMapType DataMap { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeMetaFieldTableBeanTypePropertiesTypeDataMapType
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataType
    {
        [JsonProperty("items")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("formulaField")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeFormulaFieldType FormulaField { get; set; }

        [JsonProperty("isSystemField")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeIsSystemFieldType IsSystemField { get; set; }

        [JsonProperty("title")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("value")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeValueType Value { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeFormulaFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeIsSystemFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("urn")]
        public ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowDataTypeItemsTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridRowsResponsePropertiesTypeRowsTypeItemsTypePropertiesTypeRowIDType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponse
    {
        [JsonProperty("properties")]
        public AttachmentListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesType
    {
        [JsonProperty("attachments")]
        public AttachmentListResponsePropertiesTypeAttachmentsType Attachments { get; set; }

        [JsonProperty("item")]
        public AttachmentListResponsePropertiesTypeItemType Item { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsType
    {
        [JsonProperty("items")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsType
    {
        [JsonProperty("properties")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesType
    {
        [JsonProperty("created")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedType Created { get; set; }

        [JsonProperty("description")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeDescriptionType Description { get; set; }

        [JsonProperty("folder")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeFolderType Folder { get; set; }

        [JsonProperty("id")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeIdType Id { get; set; }

        [JsonProperty("markups")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeMarkupsType Markups { get; set; }

        [JsonProperty("name")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeNameType Name { get; set; }

        [JsonProperty("resourceName")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeResourceNameType ResourceName { get; set; }

        [JsonProperty("selfLink")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeSelfLinkType SelfLink { get; set; }

        [JsonProperty("size")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeSizeType Size { get; set; }

        [JsonProperty("status")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeStatusType Status { get; set; }

        [JsonProperty("thumbnails")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeThumbnailsType Thumbnails { get; set; }

        [JsonProperty("type")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("url")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeUrlType Url { get; set; }

        [JsonProperty("urn")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("version")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeVersionType Version { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedType
    {
        [JsonProperty("properties")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesType
    {
        [JsonProperty("timeStamp")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeTimeStampType TimeStamp { get; set; }

        [JsonProperty("user")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserType User { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeTimeStampType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserType
    {
        [JsonProperty("properties")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesType
    {
        [JsonProperty("email")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeEmailType Email { get; set; }

        [JsonProperty("image")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeImageType Image { get; set; }

        [JsonProperty("link")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("status")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeStatusType Status { get; set; }

        [JsonProperty("title")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeEmailType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeImageType
    {
        [JsonProperty("properties")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesType
    {
        [JsonProperty("large")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeLargeType Large { get; set; }

        [JsonProperty("medium")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeMediumType Medium { get; set; }

        [JsonProperty("small")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeSmallType Small { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeLargeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeMediumType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeSmallType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeStatusType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeCreatedTypePropertiesTypeUserTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeDescriptionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeFolderType
    {
        [JsonProperty("properties")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeFolderTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeFolderTypePropertiesType
    {
        [JsonProperty("id")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeFolderTypePropertiesTypeIdType Id { get; set; }

        [JsonProperty("name")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeFolderTypePropertiesTypeNameType Name { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeFolderTypePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeFolderTypePropertiesTypeNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeMarkupsType
    {
        [JsonProperty("properties")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeMarkupsTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeMarkupsTypePropertiesType
    {
        [JsonProperty("count")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeMarkupsTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeMarkupsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeMarkupsTypePropertiesTypeLinkType Link { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeMarkupsTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeMarkupsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeMarkupsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeResourceNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeSelfLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeSizeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeStatusType
    {
        [JsonProperty("properties")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeStatusTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeStatusTypePropertiesType
    {
        [JsonProperty("description")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeStatusTypePropertiesTypeDescriptionType Description { get; set; }

        [JsonProperty("label")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeStatusTypePropertiesTypeLabelType Label { get; set; }

        [JsonProperty("name")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeStatusTypePropertiesTypeNameType Name { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeStatusTypePropertiesTypeDescriptionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeStatusTypePropertiesTypeLabelType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeStatusTypePropertiesTypeNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeThumbnailsType
    {
        [JsonProperty("properties")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeThumbnailsTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeThumbnailsTypePropertiesType
    {
        [JsonProperty("large")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeThumbnailsTypePropertiesTypeLargeType Large { get; set; }

        [JsonProperty("medium")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeThumbnailsTypePropertiesTypeMediumType Medium { get; set; }

        [JsonProperty("small")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeThumbnailsTypePropertiesTypeSmallType Small { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeThumbnailsTypePropertiesTypeLargeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeThumbnailsTypePropertiesTypeMediumType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeThumbnailsTypePropertiesTypeSmallType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("extension")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeExtensionType Extension { get; set; }

        [JsonProperty("fileType")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeFileTypeType FileType { get; set; }

        [JsonProperty("iconImage")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeIconImageType IconImage { get; set; }

        [JsonProperty("id")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeIdType Id { get; set; }

        [JsonProperty("viewable")]
        public AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeViewableType Viewable { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeExtensionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeFileTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeIconImageType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeViewableType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeUrlType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeAttachmentsTypeItemsTypePropertiesTypeVersionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeItemType
    {
        [JsonProperty("properties")]
        public AttachmentListResponsePropertiesTypeItemTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeItemTypePropertiesType
    {
        [JsonProperty("deleted")]
        public AttachmentListResponsePropertiesTypeItemTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public AttachmentListResponsePropertiesTypeItemTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public AttachmentListResponsePropertiesTypeItemTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public AttachmentListResponsePropertiesTypeItemTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeItemTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeItemTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeItemTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AttachmentListResponsePropertiesTypeItemTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponse
    {
        [JsonProperty("properties")]
        public UserOutstandingWorkResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public UserOutstandingWorkResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("count")]
        public UserOutstandingWorkResponsePropertiesTypeCountType Count { get; set; }

        [JsonProperty("lastRecalculateStarted")]
        public UserOutstandingWorkResponsePropertiesTypeLastRecalculateStartedType LastRecalculateStarted { get; set; }

        [JsonProperty("lastRecalculateUpdate")]
        public UserOutstandingWorkResponsePropertiesTypeLastRecalculateUpdateType LastRecalculateUpdate { get; set; }

        [JsonProperty("outstandingWork")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkType OutstandingWork { get; set; }

        [JsonProperty("recalculating")]
        public UserOutstandingWorkResponsePropertiesTypeRecalculatingType Recalculating { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeLastRecalculateStartedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeLastRecalculateUpdateType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkType
    {
        [JsonProperty("items")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsType
    {
        [JsonProperty("properties")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesType
    {
        [JsonProperty("delegated")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeDelegatedType Delegated { get; set; }

        [JsonProperty("escalated")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeEscalatedType Escalated { get; set; }

        [JsonProperty("item")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeItemType Item { get; set; }

        [JsonProperty("milestoneDate")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeMilestoneDateType MilestoneDate { get; set; }

        [JsonProperty("milestoneStatus")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeMilestoneStatusType MilestoneStatus { get; set; }

        [JsonProperty("workflowStateName")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowStateNameType WorkflowStateName { get; set; }

        [JsonProperty("workflowStateSetDate")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowStateSetDateType WorkflowStateSetDate { get; set; }

        [JsonProperty("workflowUser")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserType WorkflowUser { get; set; }

        [JsonProperty("workspace")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceType Workspace { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeDelegatedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeEscalatedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeItemType
    {
        [JsonProperty("properties")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeItemTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeItemTypePropertiesType
    {
        [JsonProperty("deleted")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeItemTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeItemTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeItemTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeItemTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeItemTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeItemTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeItemTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeItemTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeMilestoneDateType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeMilestoneStatusType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowStateNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowStateSetDateType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserType
    {
        [JsonProperty("properties")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesType
    {
        [JsonProperty("email")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeEmailType Email { get; set; }

        [JsonProperty("image")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeImageType Image { get; set; }

        [JsonProperty("link")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("status")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeStatusType Status { get; set; }

        [JsonProperty("title")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeEmailType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeImageType
    {
        [JsonProperty("properties")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeImageTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeImageTypePropertiesType
    {
        [JsonProperty("large")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeImageTypePropertiesTypeLargeType Large { get; set; }

        [JsonProperty("medium")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeImageTypePropertiesTypeMediumType Medium { get; set; }

        [JsonProperty("small")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeImageTypePropertiesTypeSmallType Small { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeImageTypePropertiesTypeLargeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeImageTypePropertiesTypeMediumType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeImageTypePropertiesTypeSmallType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeStatusType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkflowUserTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceType
    {
        [JsonProperty("properties")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceTypePropertiesType
    {
        [JsonProperty("deleted")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeOutstandingWorkTypeItemsTypePropertiesTypeWorkspaceTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class UserOutstandingWorkResponsePropertiesTypeRecalculatingType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public enum userIDInput
    {
        [EnumMember(Value = "@me")]
        Me
    }

    public class ItemRelationshipsListResponse
    {
        [JsonProperty("properties")]
        public ItemRelationshipsListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesType
    {
        [JsonProperty("list")]
        public ItemRelationshipsListResponsePropertiesTypeListType List { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListType
    {
        [JsonProperty("properties")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesType
    {
        [JsonProperty("item-relationship")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipType ItemRelationship { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipType
    {
        [JsonProperty("items")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesType
    {
        [JsonProperty("description")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeDescriptionType Description { get; set; }

        [JsonProperty("direction")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeDirectionType Direction { get; set; }

        [JsonProperty("item")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemType Item { get; set; }

        [JsonProperty("type")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeTypeType Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeDescriptionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeDirectionType
    {
        [JsonProperty("properties")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeDirectionTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeDirectionTypePropertiesType
    {
        [JsonProperty("label")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeDirectionTypePropertiesTypeLabelType Label { get; set; }

        [JsonProperty("value")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeDirectionTypePropertiesTypeValueType Value { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeDirectionTypePropertiesTypeLabelType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeDirectionTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemType
    {
        [JsonProperty("properties")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesType
    {
        [JsonProperty("description")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDescriptionType Description { get; set; }

        [JsonProperty("details")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsType Details { get; set; }

        [JsonProperty("id")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeIdType Id { get; set; }

        [JsonProperty("metaFields")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsType MetaFields { get; set; }

        [JsonProperty("uri")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeUriType Uri { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDescriptionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsType
    {
        [JsonProperty("properties")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("dmsID")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeDmsIDType DmsID { get; set; }

        [JsonProperty("latest")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeLatestType Latest { get; set; }

        [JsonProperty("lifecycleState")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeLifecycleStateType LifecycleState { get; set; }

        [JsonProperty("timeStamp")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeTimeStampType TimeStamp { get; set; }

        [JsonProperty("version")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeVersionType Version { get; set; }

        [JsonProperty("versionID")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeVersionIDType VersionID { get; set; }

        [JsonProperty("workflowState")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeWorkflowStateType WorkflowState { get; set; }

        [JsonProperty("working")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeWorkingType Working { get; set; }

        [JsonProperty("workspaceID")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeWorkspaceIDType WorkspaceID { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeDmsIDType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeLatestType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeLifecycleStateType
    {
        [JsonProperty("properties")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeLifecycleStateTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeLifecycleStateTypePropertiesType
    {
        [JsonProperty("effectivity")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeLifecycleStateTypePropertiesTypeEffectivityType Effectivity { get; set; }

        [JsonProperty("stateID")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeLifecycleStateTypePropertiesTypeStateIDType StateID { get; set; }

        [JsonProperty("stateName")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeLifecycleStateTypePropertiesTypeStateNameType StateName { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeLifecycleStateTypePropertiesTypeEffectivityType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeLifecycleStateTypePropertiesTypeStateIDType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeLifecycleStateTypePropertiesTypeStateNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeTimeStampType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeVersionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeVersionIDType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeWorkflowStateType
    {
        [JsonProperty("properties")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeWorkflowStateTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeWorkflowStateTypePropertiesType
    {
        [JsonProperty("stateId")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeWorkflowStateTypePropertiesTypeStateIdType StateId { get; set; }

        [JsonProperty("stateName")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeWorkflowStateTypePropertiesTypeStateNameType StateName { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeWorkflowStateTypePropertiesTypeStateIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeWorkflowStateTypePropertiesTypeStateNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeWorkingType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeDetailsTypePropertiesTypeWorkspaceIDType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsType
    {
        [JsonProperty("items")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsTypePropertiesType
    {
        [JsonProperty("fieldData")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsTypePropertiesTypeFieldDataType FieldData { get; set; }

        [JsonProperty("key")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsTypePropertiesTypeKeyType Key { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsTypePropertiesTypeFieldDataType
    {
        [JsonProperty("properties")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsTypePropertiesTypeFieldDataTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsTypePropertiesTypeFieldDataTypePropertiesType
    {
        [JsonProperty("dataType")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsTypePropertiesTypeFieldDataTypePropertiesTypeDataTypeType DataType { get; set; }

        [JsonProperty("value")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsTypePropertiesTypeFieldDataTypePropertiesTypeValueType Value { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsTypePropertiesTypeFieldDataTypePropertiesTypeDataTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsTypePropertiesTypeFieldDataTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeMetaFieldsTypeItemsTypePropertiesTypeKeyType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeItemTypePropertiesTypeUriType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("label")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLabelType Label { get; set; }

        [JsonProperty("value")]
        public ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeTypeTypePropertiesTypeValueType Value { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLabelType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemRelationshipsListResponsePropertiesTypeListTypePropertiesTypeItemRelationshipTypeItemsTypePropertiesTypeTypeTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponse
    {
        [JsonProperty("properties")]
        public ItemWhereUsedResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemWhereUsedResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("config")]
        public ItemWhereUsedResponsePropertiesTypeConfigType Config { get; set; }

        [JsonProperty("edges")]
        public ItemWhereUsedResponsePropertiesTypeEdgesType Edges { get; set; }

        [JsonProperty("first")]
        public ItemWhereUsedResponsePropertiesTypeFirstType First { get; set; }

        [JsonProperty("last")]
        public ItemWhereUsedResponsePropertiesTypeLastType Last { get; set; }

        [JsonProperty("limit")]
        public ItemWhereUsedResponsePropertiesTypeLimitType Limit { get; set; }

        [JsonProperty("nodes")]
        public ItemWhereUsedResponsePropertiesTypeNodesType Nodes { get; set; }

        [JsonProperty("offset")]
        public ItemWhereUsedResponsePropertiesTypeOffsetType Offset { get; set; }

        [JsonProperty("root")]
        public ItemWhereUsedResponsePropertiesTypeRootType Root { get; set; }

        [JsonProperty("totalCount")]
        public ItemWhereUsedResponsePropertiesTypeTotalCountType TotalCount { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeConfigType
    {
        [JsonProperty("properties")]
        public ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesType
    {
        [JsonProperty("bias")]
        public ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeBiasType Bias { get; set; }

        [JsonProperty("bomViewDate")]
        public ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeBomViewDateType BomViewDate { get; set; }

        [JsonProperty("viewDef")]
        public ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeViewDefType ViewDef { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeBiasType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeBomViewDateType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeViewDefType
    {
        [JsonProperty("properties")]
        public ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeViewDefTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeViewDefTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeViewDefTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeViewDefTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("urn")]
        public ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeViewDefTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeViewDefTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeViewDefTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeConfigTypePropertiesTypeViewDefTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeEdgesType
    {
        [JsonProperty("items")]
        public ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesType
    {
        [JsonProperty("child")]
        public ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeChildType Child { get; set; }

        [JsonProperty("depth")]
        public ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeDepthType Depth { get; set; }

        [JsonProperty("edgeId")]
        public ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeEdgeIdType EdgeId { get; set; }

        [JsonProperty("edgeLink")]
        public ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeEdgeLinkType EdgeLink { get; set; }

        [JsonProperty("fields")]
        public string[] Fields { get; set; }

        [JsonProperty("itemNumber")]
        public ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeItemNumberType ItemNumber { get; set; }

        [JsonProperty("lastNode")]
        public ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeLastNodeType LastNode { get; set; }

        [JsonProperty("parent")]
        public ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeParentType Parent { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeChildType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeDepthType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeEdgeIdType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeEdgeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeItemNumberType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeLastNodeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeEdgesTypeItemsTypePropertiesTypeParentType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeFirstType
    {
        [JsonProperty("properties")]
        public ItemWhereUsedResponsePropertiesTypeFirstTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeFirstTypePropertiesType
    {
        [JsonProperty("count")]
        public ItemWhereUsedResponsePropertiesTypeFirstTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public ItemWhereUsedResponsePropertiesTypeFirstTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemWhereUsedResponsePropertiesTypeFirstTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemWhereUsedResponsePropertiesTypeFirstTypePropertiesTypeTitleType Title { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeFirstTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeFirstTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeFirstTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeFirstTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeLastType
    {
        [JsonProperty("properties")]
        public ItemWhereUsedResponsePropertiesTypeLastTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeLastTypePropertiesType
    {
        [JsonProperty("count")]
        public ItemWhereUsedResponsePropertiesTypeLastTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public ItemWhereUsedResponsePropertiesTypeLastTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemWhereUsedResponsePropertiesTypeLastTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemWhereUsedResponsePropertiesTypeLastTypePropertiesTypeTitleType Title { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeLastTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeLastTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeLastTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeLastTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeLimitType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesType
    {
        [JsonProperty("items")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesType
    {
        [JsonProperty("bomItems")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeBomItemsType BomItems { get; set; }

        [JsonProperty("bomRoot")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeBomRootType BomRoot { get; set; }

        [JsonProperty("fields")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeFieldsType Fields { get; set; }

        [JsonProperty("item")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemType Item { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeBomItemsType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeBomRootType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeFieldsType
    {
        [JsonProperty("items")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeFieldsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeFieldsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesType
    {
        [JsonProperty("isSystemField")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeIsSystemFieldType IsSystemField { get; set; }

        [JsonProperty("title")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("value")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeValueType Value { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeIsSystemFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeFieldsTypeItemsTypePropertiesTypeValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemType
    {
        [JsonProperty("properties")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("version")]
        public ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemTypePropertiesTypeVersionType Version { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeNodesTypeItemsTypePropertiesTypeItemTypePropertiesTypeVersionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeOffsetType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeRootType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemWhereUsedResponsePropertiesTypeTotalCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewResponse
    {
        [JsonProperty("properties")]
        public ItemPrintViewResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemPrintViewResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("hide")]
        public ItemPrintViewResponsePropertiesTypeHideType Hide { get; set; }

        [JsonProperty("printName")]
        public ItemPrintViewResponsePropertiesTypePrintNameType PrintName { get; set; }

        [JsonProperty("urn")]
        public ItemPrintViewResponsePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemPrintViewResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewResponsePropertiesTypeHideType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewResponsePropertiesTypePrintNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewResponsePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldDetailsResponse
    {
        [JsonProperty("properties")]
        public ItemGridFieldDetailsResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldDetailsResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemGridFieldDetailsResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("defaultValue")]
        public ItemGridFieldDetailsResponsePropertiesTypeDefaultValueType DefaultValue { get; set; }

        [JsonProperty("description")]
        public ItemGridFieldDetailsResponsePropertiesTypeDescriptionType Description { get; set; }

        [JsonProperty("label")]
        public ItemGridFieldDetailsResponsePropertiesTypeLabelType Label { get; set; }

        [JsonProperty("type")]
        public ItemGridFieldDetailsResponsePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public ItemGridFieldDetailsResponsePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemGridFieldDetailsResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldDetailsResponsePropertiesTypeDefaultValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldDetailsResponsePropertiesTypeDescriptionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldDetailsResponsePropertiesTypeLabelType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldDetailsResponsePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public ItemGridFieldDetailsResponsePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldDetailsResponsePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemGridFieldDetailsResponsePropertiesTypeTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemGridFieldDetailsResponsePropertiesTypeTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemGridFieldDetailsResponsePropertiesTypeTypeTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemGridFieldDetailsResponsePropertiesTypeTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemGridFieldDetailsResponsePropertiesTypeTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldDetailsResponsePropertiesTypeTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldDetailsResponsePropertiesTypeTypeTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldDetailsResponsePropertiesTypeTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldDetailsResponsePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponse
    {
        [JsonProperty("properties")]
        public ItemGridFieldsListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemGridFieldsListResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("fields")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsType Fields { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsType
    {
        [JsonProperty("items")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("defaultValue")]
        public JToken DefaultValue { get; set; }

        [JsonProperty("derived")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedType Derived { get; set; }

        [JsonProperty("description")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDescriptionType Description { get; set; }

        [JsonProperty("displayLength")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDisplayLengthType DisplayLength { get; set; }

        [JsonProperty("displayOrder")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDisplayOrderType DisplayOrder { get; set; }

        [JsonProperty("editability")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeEditabilityType Editability { get; set; }

        [JsonProperty("fieldLength")]
        public JToken FieldLength { get; set; }

        [JsonProperty("fieldPrecision")]
        public JToken FieldPrecision { get; set; }

        [JsonProperty("fieldValidators")]
        public JToken FieldValidators { get; set; }

        [JsonProperty("formulaField")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeFormulaFieldType FormulaField { get; set; }

        [JsonProperty("gridFieldAggregationInfo")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeGridFieldAggregationInfoType GridFieldAggregationInfo { get; set; }

        [JsonProperty("label")]
        public JToken Label { get; set; }

        [JsonProperty("name")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeNameType Name { get; set; }

        [JsonProperty("picklist")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypePicklistType Picklist { get; set; }

        [JsonProperty("picklistFieldDefinition")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypePicklistFieldDefinitionType PicklistFieldDefinition { get; set; }

        [JsonProperty("type")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("unitOfMeasure")]
        public JToken UnitOfMeasure { get; set; }

        [JsonProperty("urn")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("validators")]
        public JToken Validators { get; set; }

        [JsonProperty("visibility")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeVisibilityType Visibility { get; set; }

        [JsonProperty("visibleOnPreview")]
        public JToken VisibleOnPreview { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDescriptionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDisplayLengthType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDisplayOrderType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeEditabilityType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeFormulaFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeGridFieldAggregationInfoType
    {
        [JsonProperty("properties")]
        public JToken Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypePicklistType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypePicklistFieldDefinitionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemGridFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeVisibilityType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponse
    {
        [JsonProperty("properties")]
        public ItemDetailsFieldsListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemDetailsFieldsListResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("fields")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsType Fields { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsType
    {
        [JsonProperty("items")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("defaultValue")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDefaultValueType DefaultValue { get; set; }

        [JsonProperty("derived")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedType Derived { get; set; }

        [JsonProperty("derivedFieldSource")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceType DerivedFieldSource { get; set; }

        [JsonProperty("derivedFields")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsType DerivedFields { get; set; }

        [JsonProperty("description")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDescriptionType Description { get; set; }

        [JsonProperty("displayLength")]
        public JToken DisplayLength { get; set; }

        [JsonProperty("displayOrder")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDisplayOrderType DisplayOrder { get; set; }

        [JsonProperty("editability")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeEditabilityType Editability { get; set; }

        [JsonProperty("fieldLength")]
        public JToken FieldLength { get; set; }

        [JsonProperty("fieldPrecision")]
        public JToken FieldPrecision { get; set; }

        [JsonProperty("fieldValidators")]
        public string[] FieldValidators { get; set; }

        [JsonProperty("formulaField")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeFormulaFieldType FormulaField { get; set; }

        [JsonProperty("label")]
        public JToken Label { get; set; }

        [JsonProperty("name")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeNameType Name { get; set; }

        [JsonProperty("picklist")]
        public JToken Picklist { get; set; }

        [JsonProperty("picklistFieldDefinition")]
        public JToken PicklistFieldDefinition { get; set; }

        [JsonProperty("pivotLink")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypePivotLinkType PivotLink { get; set; }

        [JsonProperty("type")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("unitOfMeasure")]
        public JToken UnitOfMeasure { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("validators")]
        public JToken Validators { get; set; }

        [JsonProperty("visibility")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeVisibilityType Visibility { get; set; }

        [JsonProperty("visibleOnPreview")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeVisibleOnPreviewType VisibleOnPreview { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDefaultValueType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceType
    {
        [JsonProperty("properties")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("title")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTypeTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTypeTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldSourceTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsType
    {
        [JsonProperty("items")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("title")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDerivedFieldsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDescriptionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeDisplayOrderType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeEditabilityType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeFormulaFieldType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypePivotLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("properties")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeTypeTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeVisibilityType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldsListResponsePropertiesTypeFieldsTypeItemsTypePropertiesTypeVisibleOnPreviewType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldTypesResponse
    {
        [JsonProperty("properties")]
        public ItemDetailsFieldTypesResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldTypesResponsePropertiesType
    {
        [JsonProperty("field-types")]
        public ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesType FieldTypes { get; set; }
    }

    public class ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesType
    {
        [JsonProperty("items")]
        public ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesTypeItemsTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesTypeItemsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesTypeItemsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemDetailsFieldTypesResponsePropertiesTypeFieldTypesTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewsListResponse
    {
        [JsonProperty("properties")]
        public ItemPrintViewsListResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewsListResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemPrintViewsListResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("links")]
        public ItemPrintViewsListResponsePropertiesTypeLinksType Links { get; set; }
    }

    public class ItemPrintViewsListResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewsListResponsePropertiesTypeLinksType
    {
        [JsonProperty("items")]
        public ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("hidden")]
        public ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeHiddenType Hidden { get; set; }

        [JsonProperty("link")]
        public ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeHiddenType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemPrintViewsListResponsePropertiesTypeLinksTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponse
    {
        [JsonProperty("properties")]
        public PicklistLookupsResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public PicklistLookupsResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("first")]
        public PicklistLookupsResponsePropertiesTypeFirstType First { get; set; }

        [JsonProperty("items")]
        public PicklistLookupsResponsePropertiesTypeItemsType Items { get; set; }

        [JsonProperty("last")]
        public PicklistLookupsResponsePropertiesTypeLastType Last { get; set; }

        [JsonProperty("limit")]
        public PicklistLookupsResponsePropertiesTypeLimitType Limit { get; set; }

        [JsonProperty("offset")]
        public PicklistLookupsResponsePropertiesTypeOffsetType Offset { get; set; }

        [JsonProperty("totalCount")]
        public PicklistLookupsResponsePropertiesTypeTotalCountType TotalCount { get; set; }

        [JsonProperty("urn")]
        public PicklistLookupsResponsePropertiesTypeUrnType Urn { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeFirstType
    {
        [JsonProperty("properties")]
        public PicklistLookupsResponsePropertiesTypeFirstTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeFirstTypePropertiesType
    {
        [JsonProperty("count")]
        public PicklistLookupsResponsePropertiesTypeFirstTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public PicklistLookupsResponsePropertiesTypeFirstTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public PicklistLookupsResponsePropertiesTypeFirstTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public PicklistLookupsResponsePropertiesTypeFirstTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public PicklistLookupsResponsePropertiesTypeFirstTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeFirstTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeFirstTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeFirstTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeFirstTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeFirstTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeItemsType
    {
        [JsonProperty("items")]
        public PicklistLookupsResponsePropertiesTypeItemsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeItemsTypeItemsType
    {
        [JsonProperty("properties")]
        public PicklistLookupsResponsePropertiesTypeItemsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeItemsTypeItemsTypePropertiesType
    {
        [JsonProperty("link")]
        public PicklistLookupsResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public PicklistLookupsResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTitleType Title { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeLastType
    {
        [JsonProperty("properties")]
        public PicklistLookupsResponsePropertiesTypeLastTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeLastTypePropertiesType
    {
        [JsonProperty("count")]
        public PicklistLookupsResponsePropertiesTypeLastTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public PicklistLookupsResponsePropertiesTypeLastTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public PicklistLookupsResponsePropertiesTypeLastTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public PicklistLookupsResponsePropertiesTypeLastTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public PicklistLookupsResponsePropertiesTypeLastTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeLastTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeLastTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeLastTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeLastTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeLastTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeLimitType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeOffsetType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeTotalCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PicklistLookupsResponsePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponse
    {
        [JsonProperty("items")]
        public WorkspaceTransitionslistResponseItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsType
    {
        [JsonProperty("properties")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("actionScript")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeActionScriptType ActionScript { get; set; }

        [JsonProperty("approvers")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeApproversType Approvers { get; set; }

        [JsonProperty("comments")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeCommentsType Comments { get; set; }

        [JsonProperty("customLabel")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeCustomLabelType CustomLabel { get; set; }

        [JsonProperty("delegatorUsers")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeDelegatorUsersType DelegatorUsers { get; set; }

        [JsonProperty("escalationPermission")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeEscalationPermissionType EscalationPermission { get; set; }

        [JsonProperty("fromState")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeFromStateType FromState { get; set; }

        [JsonProperty("hidden")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeHiddenType Hidden { get; set; }

        [JsonProperty("ignoreEscalatedPreconditions")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeIgnoreEscalatedPreconditionsType IgnoreEscalatedPreconditions { get; set; }

        [JsonProperty("labelPositionA")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeLabelPositionAType LabelPositionA { get; set; }

        [JsonProperty("labelPositionB")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeLabelPositionBType LabelPositionB { get; set; }

        [JsonProperty("name")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeNameType Name { get; set; }

        [JsonProperty("notifyPerformers")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeNotifyPerformersType NotifyPerformers { get; set; }

        [JsonProperty("passwordEnabled")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypePasswordEnabledType PasswordEnabled { get; set; }

        [JsonProperty("permission")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypePermissionType Permission { get; set; }

        [JsonProperty("points")]
        public JToken Points { get; set; }

        [JsonProperty("sendEmail")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeSendEmailType SendEmail { get; set; }

        [JsonProperty("showInOutstanding")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeShowInOutstandingType ShowInOutstanding { get; set; }

        [JsonProperty("toState")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeToStateType ToState { get; set; }

        [JsonProperty("urn")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("workspace")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceType Workspace { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeActionScriptType
    {
        [JsonProperty("properties")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeActionScriptTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeActionScriptTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeApproversType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeCommentsType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeCustomLabelType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeDelegatorUsersType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeEscalationPermissionType
    {
        [JsonProperty("properties")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeFromStateType
    {
        [JsonProperty("properties")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeFromStateTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeFromStateTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeHiddenType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeIgnoreEscalatedPreconditionsType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeLabelPositionAType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeLabelPositionBType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeNotifyPerformersType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypePasswordEnabledType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypePermissionType
    {
        [JsonProperty("properties")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypePermissionTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypePermissionTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypePermissionTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypePermissionTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypePermissionTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypePermissionTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypePermissionTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypePermissionTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypePermissionTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypePermissionTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeSendEmailType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeShowInOutstandingType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeToStateType
    {
        [JsonProperty("properties")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeToStateTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeToStateTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeToStateTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeToStateTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeToStateTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeToStateTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeToStateTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeToStateTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeToStateTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeToStateTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceType
    {
        [JsonProperty("properties")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceTypePropertiesType
    {
        [JsonProperty("deleted")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class WorkspaceTransitionslistResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponse
    {
        [JsonProperty("items")]
        public ItemTransitionsAvailableResponseItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsType
    {
        [JsonProperty("properties")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("actionScript")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeActionScriptType ActionScript { get; set; }

        [JsonProperty("approvers")]
        public string[] Approvers { get; set; }

        [JsonProperty("comments")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeCommentsType Comments { get; set; }

        [JsonProperty("conditionScript")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeConditionScriptType ConditionScript { get; set; }

        [JsonProperty("customLabel")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeCustomLabelType CustomLabel { get; set; }

        [JsonProperty("delegatorUsers")]
        public string[] DelegatorUsers { get; set; }

        [JsonProperty("escalationPermission")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeEscalationPermissionType EscalationPermission { get; set; }

        [JsonProperty("fromState")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeFromStateType FromState { get; set; }

        [JsonProperty("hidden")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeHiddenType Hidden { get; set; }

        [JsonProperty("ignoreEscalatedPreconditions")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeIgnoreEscalatedPreconditionsType IgnoreEscalatedPreconditions { get; set; }

        [JsonProperty("labelPositionA")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeLabelPositionAType LabelPositionA { get; set; }

        [JsonProperty("labelPositionB")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeLabelPositionBType LabelPositionB { get; set; }

        [JsonProperty("name")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeNameType Name { get; set; }

        [JsonProperty("notifyPerformers")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeNotifyPerformersType NotifyPerformers { get; set; }

        [JsonProperty("passwordEnabled")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypePasswordEnabledType PasswordEnabled { get; set; }

        [JsonProperty("permission")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypePermissionType Permission { get; set; }

        [JsonProperty("points")]
        public JToken Points { get; set; }

        [JsonProperty("sendEmail")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeSendEmailType SendEmail { get; set; }

        [JsonProperty("showInOutstanding")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeShowInOutstandingType ShowInOutstanding { get; set; }

        [JsonProperty("toState")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeToStateType ToState { get; set; }

        [JsonProperty("urn")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("validationScript")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeValidationScriptType ValidationScript { get; set; }

        [JsonProperty("workspace")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceType Workspace { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeActionScriptType
    {
        [JsonProperty("properties")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeActionScriptTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeActionScriptTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeActionScriptTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeCommentsType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeConditionScriptType
    {
        [JsonProperty("properties")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeConditionScriptTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeConditionScriptTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeConditionScriptTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeConditionScriptTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeConditionScriptTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeConditionScriptTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeConditionScriptTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeConditionScriptTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeConditionScriptTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeConditionScriptTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeCustomLabelType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeEscalationPermissionType
    {
        [JsonProperty("properties")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeEscalationPermissionTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeFromStateType
    {
        [JsonProperty("properties")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeFromStateTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeFromStateTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeFromStateTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeHiddenType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeIgnoreEscalatedPreconditionsType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeLabelPositionAType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeLabelPositionBType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeNotifyPerformersType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypePasswordEnabledType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypePermissionType
    {
        [JsonProperty("properties")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypePermissionTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypePermissionTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypePermissionTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypePermissionTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypePermissionTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypePermissionTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypePermissionTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypePermissionTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypePermissionTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypePermissionTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeSendEmailType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeShowInOutstandingType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeToStateType
    {
        [JsonProperty("properties")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeToStateTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeToStateTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeToStateTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeToStateTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeToStateTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeToStateTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeToStateTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeToStateTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeToStateTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeToStateTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeValidationScriptType
    {
        [JsonProperty("properties")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeValidationScriptTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeValidationScriptTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeValidationScriptTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeValidationScriptTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeValidationScriptTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeValidationScriptTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeValidationScriptTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeValidationScriptTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeValidationScriptTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeValidationScriptTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceType
    {
        [JsonProperty("properties")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceTypePropertiesType
    {
        [JsonProperty("deleted")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("type")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTypeType Type { get; set; }

        [JsonProperty("urn")]
        public ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeTypeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTransitionsAvailableResponseItemsTypePropertiesTypeWorkspaceTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponse
    {
        [JsonProperty("properties")]
        public ItemTabOverviewResponsePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemTabOverviewResponsePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("first")]
        public ItemTabOverviewResponsePropertiesTypeFirstType First { get; set; }

        [JsonProperty("items")]
        public ItemTabOverviewResponsePropertiesTypeItemsType Items { get; set; }

        [JsonProperty("last")]
        public ItemTabOverviewResponsePropertiesTypeLastType Last { get; set; }

        [JsonProperty("limit")]
        public ItemTabOverviewResponsePropertiesTypeLimitType Limit { get; set; }

        [JsonProperty("offset")]
        public ItemTabOverviewResponsePropertiesTypeOffsetType Offset { get; set; }

        [JsonProperty("totalCount")]
        public ItemTabOverviewResponsePropertiesTypeTotalCountType TotalCount { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeFirstType
    {
        [JsonProperty("properties")]
        public ItemTabOverviewResponsePropertiesTypeFirstTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeFirstTypePropertiesType
    {
        [JsonProperty("count")]
        public ItemTabOverviewResponsePropertiesTypeFirstTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public ItemTabOverviewResponsePropertiesTypeFirstTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemTabOverviewResponsePropertiesTypeFirstTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemTabOverviewResponsePropertiesTypeFirstTypePropertiesTypeTitleType Title { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeFirstTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeFirstTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeFirstTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeFirstTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsType
    {
        [JsonProperty("items")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsType Items { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsType
    {
        [JsonProperty("properties")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesType Properties { get; set; }

        [JsonProperty("required")]
        public string[] Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesType
    {
        [JsonProperty("__self__")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSelfType Self { get; set; }

        [JsonProperty("action")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionType Action { get; set; }

        [JsonProperty("actionInvoker")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionInvokerType ActionInvoker { get; set; }

        [JsonProperty("description")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDescriptionType Description { get; set; }

        [JsonProperty("details")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsType Details { get; set; }

        [JsonProperty("timeStamp")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTimeStampType TimeStamp { get; set; }

        [JsonProperty("urn")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType Urn { get; set; }

        [JsonProperty("user")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserType User { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeSelfType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionType
    {
        [JsonProperty("properties")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesType
    {
        [JsonProperty("longName")]
        public JToken LongName { get; set; }

        [JsonProperty("notifyPermission")]
        public JToken NotifyPermission { get; set; }

        [JsonProperty("shortName")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeShortNameType ShortName { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionTypePropertiesTypeShortNameType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeActionInvokerType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDescriptionType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeDetailsType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeTimeStampType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserType
    {
        [JsonProperty("properties")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesType
    {
        [JsonProperty("email")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeEmailType Email { get; set; }

        [JsonProperty("image")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageType Image { get; set; }

        [JsonProperty("link")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("status")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeStatusType Status { get; set; }

        [JsonProperty("title")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeTitleType Title { get; set; }

        [JsonProperty("urn")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeUrnType Urn { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeEmailType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageType
    {
        [JsonProperty("properties")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesType
    {
        [JsonProperty("large")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeLargeType Large { get; set; }

        [JsonProperty("medium")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeMediumType Medium { get; set; }

        [JsonProperty("small")]
        public ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeSmallType Small { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeLargeType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeMediumType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeImageTypePropertiesTypeSmallType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeStatusType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeItemsTypeItemsTypePropertiesTypeUserTypePropertiesTypeUrnType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeLastType
    {
        [JsonProperty("properties")]
        public ItemTabOverviewResponsePropertiesTypeLastTypePropertiesType Properties { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeLastTypePropertiesType
    {
        [JsonProperty("count")]
        public ItemTabOverviewResponsePropertiesTypeLastTypePropertiesTypeCountType Count { get; set; }

        [JsonProperty("deleted")]
        public ItemTabOverviewResponsePropertiesTypeLastTypePropertiesTypeDeletedType Deleted { get; set; }

        [JsonProperty("link")]
        public ItemTabOverviewResponsePropertiesTypeLastTypePropertiesTypeLinkType Link { get; set; }

        [JsonProperty("title")]
        public ItemTabOverviewResponsePropertiesTypeLastTypePropertiesTypeTitleType Title { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeLastTypePropertiesTypeCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeLastTypePropertiesTypeDeletedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeLastTypePropertiesTypeLinkType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeLastTypePropertiesTypeTitleType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeLimitType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeOffsetType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ItemTabOverviewResponsePropertiesTypeTotalCountType
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class _200SectionsItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("sectionType")]
        public string SectionType { get; set; }

        [JsonProperty("fields")]
        public _200SectionsItemFieldsTypeItem[] Fields { get; set; }

        [JsonProperty("sectionLocked")]
        public bool SectionLocked { get; set; }

        [JsonProperty("pimSection")]
        public bool PimSection { get; set; }

        [JsonProperty("__self__")]
        public string Self { get; set; }

        [JsonProperty("urn")]
        public string Urn { get; set; }

        [JsonProperty("matrices")]
        public _200SectionsItemMatricesTypeItem[] Matrices { get; set; }
    }

    public class _200SectionsItemFieldsTypeItem
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("urn")]
        public string Urn { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class _200SectionsItemMatricesTypeItem
    {
        [JsonProperty("__self__")]
        public string Self { get; set; }

        [JsonProperty("urn")]
        public string Urn { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("columnNames")]
        public string[] ColumnNames { get; set; }

        [JsonProperty("rowNames")]
        public string[] RowNames { get; set; }

        [JsonProperty("fields")]
        public _200SectionsItemMatricesTypeItemFieldsTypeItemItem[][] Fields { get; set; }
    }

    public class _200SectionsItemMatricesTypeItemFieldsTypeItemItem
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("urn")]
        public string Urn { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public enum contentLocationInput
    {
        [EnumMember(Value = "/api/v3/workspaces/:WorkspaceID/items/:ItemID/views/10/linkable-items/:ItemID")]
        ApiV3WorkspacesWorkspaceIDItemsItemIDViews10LinkableItemsItemID
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fuxsyautodeskfusionm;

    public partial class WorkflowManagedActions
    {
        public FuxsyautodeskfusionmActions Fuxsyautodeskfusionm(string connectionId) => new FuxsyautodeskfusionmActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FuxsyautodeskfusionmTriggers Fuxsyautodeskfusionm(string connectionId) => new FuxsyautodeskfusionmTriggers(connectionId);
    }
}