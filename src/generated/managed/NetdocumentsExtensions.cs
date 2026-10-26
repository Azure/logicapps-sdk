//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Netdocuments
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NetdocumentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetUserInfoResponse, ApiConnectionActionConfiguration> GetUserInfo(Expression<Func<string>> id, Expression<Func<string>> cabGuid = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_cabGuid = WorkflowExpression.Compile(cabGuid, nameof(cabGuid), required: false);
            return new DeferredBodyAction<GetUserInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/User/{0}/info", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cabGuid != null)
                    callPayload.Queries["cabGuid"] = ExpressionConverter.Convert(__workflow_cabGuid);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetUserInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetUserCabinetsResponseItem[], ApiConnectionActionConfiguration> GetUserCabinets()
        {
            return new DeferredBodyAction<GetUserCabinetsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/User/cabinets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetUserCabinetsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<NewVersionResponse, ApiConnectionActionConfiguration> NewVersion(Expression<Func<string>> id, Expression<Func<string>> extension = null, Expression<Func<string>> versionDescription = null, Expression<Func<string>> verName = null, Expression<Func<bool>> official = null, Expression<Func<bool>> addToRecent = null, Expression<Func<string>> srcVer = null, Expression<Func<bool>> allocatesubversion = null, Expression<Func<string>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_extension = WorkflowExpression.Compile(extension, nameof(extension), required: false);
            var __workflow_versionDescription = WorkflowExpression.Compile(versionDescription, nameof(versionDescription), required: false);
            var __workflow_verName = WorkflowExpression.Compile(verName, nameof(verName), required: false);
            var __workflow_official = WorkflowExpression.Compile(official, nameof(official), required: false);
            var __workflow_addToRecent = WorkflowExpression.Compile(addToRecent, nameof(addToRecent), required: false);
            var __workflow_srcVer = WorkflowExpression.Compile(srcVer, nameof(srcVer), required: false);
            var __workflow_allocatesubversion = WorkflowExpression.Compile(allocatesubversion, nameof(allocatesubversion), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<NewVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Document/{0}/new", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_extension != null)
                    callPayload.Queries["extension"] = ExpressionConverter.Convert(__workflow_extension);
                if (__workflow_versionDescription != null)
                    callPayload.Queries["version_description"] = ExpressionConverter.Convert(__workflow_versionDescription);
                if (__workflow_verName != null)
                    callPayload.Queries["verName"] = ExpressionConverter.Convert(__workflow_verName);
                callPayload.Queries["official"] = Convert.ToString(true);
                if (__workflow_official != null)
                    callPayload.Queries["official"] = ExpressionConverter.Convert(__workflow_official);
                if (__workflow_addToRecent != null)
                    callPayload.Queries["addToRecent"] = ExpressionConverter.Convert(__workflow_addToRecent);
                if (__workflow_srcVer != null)
                    callPayload.Queries["srcVer"] = ExpressionConverter.Convert(__workflow_srcVer);
                callPayload.Queries["allocatesubversion"] = Convert.ToString(false);
                if (__workflow_allocatesubversion != null)
                    callPayload.Queries["allocatesubversion"] = ExpressionConverter.Convert(__workflow_allocatesubversion);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NewVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDocInfo(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Document/{0}/info", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RenameDocument(Expression<Func<string>> id, Expression<Func<RenameDocumentInput>> renameBody)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_renameBody = WorkflowExpression.Compile(renameBody, nameof(renameBody), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Document/{0}/info", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_renameBody);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDocContent(Expression<Func<string>> id, Expression<Func<bool>> base64 = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_base64 = WorkflowExpression.Compile(base64, nameof(base64), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Document/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["base64"] = Convert.ToString(false);
                if (__workflow_base64 != null)
                    callPayload.Queries["base64"] = ExpressionConverter.Convert(__workflow_base64);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDoc(Expression<Func<string>> id, Expression<Func<bool>> permanent = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_permanent = WorkflowExpression.Compile(permanent, nameof(permanent), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Document/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["permanent"] = Convert.ToString(false);
                if (__workflow_permanent != null)
                    callPayload.Queries["permanent"] = ExpressionConverter.Convert(__workflow_permanent);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateDocument(Expression<Func<string>> id, Expression<Func<string>> body, Expression<Func<string>> extension = null, Expression<Func<bool>> base64 = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_extension = WorkflowExpression.Compile(extension, nameof(extension), required: false);
            var __workflow_base64 = WorkflowExpression.Compile(base64, nameof(base64), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Document/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_extension != null)
                    callPayload.Queries["extension"] = ExpressionConverter.Convert(__workflow_extension);
                callPayload.Queries["base64"] = Convert.ToString(true);
                if (__workflow_base64 != null)
                    callPayload.Queries["base64"] = ExpressionConverter.Convert(__workflow_base64);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetFldContent(Expression<Func<string>> id, Expression<Func<string>> select = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Folder/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFolder(Expression<Func<string>> id, Expression<Func<bool>> permanent = null, Expression<Func<bool>> deleteContents = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_permanent = WorkflowExpression.Compile(permanent, nameof(permanent), required: false);
            var __workflow_deleteContents = WorkflowExpression.Compile(deleteContents, nameof(deleteContents), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Folder/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["permanent"] = Convert.ToString(false);
                if (__workflow_permanent != null)
                    callPayload.Queries["permanent"] = ExpressionConverter.Convert(__workflow_permanent);
                callPayload.Queries["deleteContents"] = Convert.ToString(false);
                if (__workflow_deleteContents != null)
                    callPayload.Queries["deleteContents"] = ExpressionConverter.Convert(__workflow_deleteContents);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RenameFolder(Expression<Func<string>> id, Expression<Func<RenameFolderInput>> renameBody)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_renameBody = WorkflowExpression.Compile(renameBody, nameof(renameBody), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Folder/{0}/info", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_renameBody);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCurrentUserInfoResponse, ApiConnectionActionConfiguration> GetCurrentUserInfo(Expression<Func<string>> cabGuid = null)
        {
            var __workflow_cabGuid = WorkflowExpression.Compile(cabGuid, nameof(cabGuid), required: false);
            return new DeferredBodyAction<GetCurrentUserInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/User/info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cabGuid != null)
                    callPayload.Queries["cabGuid"] = ExpressionConverter.Convert(__workflow_cabGuid);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetCurrentUserInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDocumentVersions(Expression<Func<string>> documentId)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Document/{0}/versionList", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetDocHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Document/{0}/history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateWorkspaceParentChildResponse, ApiConnectionActionConfiguration> CreateWorkspaceParentChild(Expression<Func<string>> cabinetId, Expression<Func<string>> parentId, Expression<Func<string>> childId)
        {
            var __workflow_cabinetId = WorkflowExpression.Compile(cabinetId, nameof(cabinetId), required: true);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            var __workflow_childId = WorkflowExpression.Compile(childId, nameof(childId), required: true);
            return new DeferredBodyAction<CreateWorkspaceParentChildResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Workspace/{0}/{1}/{2}/info", __workflow_cabinetId.WithUrlEncoding(1), __workflow_parentId.WithUrlEncoding(1), __workflow_childId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CreateWorkspaceParentChildResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateWorkspaceSingleResponse, ApiConnectionActionConfiguration> CreateWorkspaceSingle(Expression<Func<string>> cabinetId, Expression<Func<string>> parentId)
        {
            var __workflow_cabinetId = WorkflowExpression.Compile(cabinetId, nameof(cabinetId), required: true);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            return new DeferredBodyAction<CreateWorkspaceSingleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Workspace/{0}/{1}/info", __workflow_cabinetId.WithUrlEncoding(1), __workflow_parentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CreateWorkspaceSingleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetWorkspaceInformation(Expression<Func<string>> workspaceId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Workspace/{0}/info", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateChildEntryResponse, ApiConnectionActionConfiguration> CreateChildEntry(Expression<Func<string>> repositoryId, Expression<Func<string>> childAttributeId, Expression<Func<string>> parentId, Expression<Func<string>> childId, Expression<Func<CreateChildEntryInput>> lookupEntryBody)
        {
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_childAttributeId = WorkflowExpression.Compile(childAttributeId, nameof(childAttributeId), required: true);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            var __workflow_childId = WorkflowExpression.Compile(childId, nameof(childId), required: true);
            var __workflow_lookupEntryBody = WorkflowExpression.Compile(lookupEntryBody, nameof(lookupEntryBody), required: true);
            return new DeferredBodyAction<CreateChildEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", __workflow_repositoryId.WithUrlEncoding(1), __workflow_childAttributeId.WithUrlEncoding(1), __workflow_parentId.WithUrlEncoding(1), __workflow_childId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_lookupEntryBody);
                return new ApiConnectionAction<CreateChildEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetChildEntry(Expression<Func<string>> repositoryId, Expression<Func<string>> childAttributeId, Expression<Func<string>> parentId, Expression<Func<string>> childId)
        {
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_childAttributeId = WorkflowExpression.Compile(childAttributeId, nameof(childAttributeId), required: true);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            var __workflow_childId = WorkflowExpression.Compile(childId, nameof(childId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", __workflow_repositoryId.WithUrlEncoding(1), __workflow_childAttributeId.WithUrlEncoding(1), __workflow_parentId.WithUrlEncoding(1), __workflow_childId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<DeleteChildEntryResponse, ApiConnectionActionConfiguration> DeleteChildEntry(Expression<Func<string>> repositoryId, Expression<Func<string>> childAttributeId, Expression<Func<string>> parentId, Expression<Func<string>> childId)
        {
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_childAttributeId = WorkflowExpression.Compile(childAttributeId, nameof(childAttributeId), required: true);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            var __workflow_childId = WorkflowExpression.Compile(childId, nameof(childId), required: true);
            return new DeferredBodyAction<DeleteChildEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", __workflow_repositoryId.WithUrlEncoding(1), __workflow_childAttributeId.WithUrlEncoding(1), __workflow_parentId.WithUrlEncoding(1), __workflow_childId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<DeleteChildEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateEntryResponse, ApiConnectionActionConfiguration> CreateEntry(Expression<Func<string>> repositoryId, Expression<Func<string>> attributeId, Expression<Func<string>> parentId, Expression<Func<CreateEntryInput>> lookupEntryBody)
        {
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_attributeId = WorkflowExpression.Compile(attributeId, nameof(attributeId), required: true);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            var __workflow_lookupEntryBody = WorkflowExpression.Compile(lookupEntryBody, nameof(lookupEntryBody), required: true);
            return new DeferredBodyAction<CreateEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}/{2}", __workflow_repositoryId.WithUrlEncoding(1), __workflow_attributeId.WithUrlEncoding(1), __workflow_parentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_lookupEntryBody);
                return new ApiConnectionAction<CreateEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetLookupEntry(Expression<Func<string>> repositoryId, Expression<Func<string>> attributeId, Expression<Func<string>> parentId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, Expression<Func<orderbyInput>> orderby = null)
        {
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_attributeId = WorkflowExpression.Compile(attributeId, nameof(attributeId), required: true);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}/{2}", __workflow_repositoryId.WithUrlEncoding(1), __workflow_attributeId.WithUrlEncoding(1), __workflow_parentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$orderby"] = Convert.ToString("key");
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<DeleteLookupEntryResponse, ApiConnectionActionConfiguration> DeleteLookupEntry(Expression<Func<string>> repositoryId, Expression<Func<string>> attributeId, Expression<Func<string>> parentId)
        {
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_attributeId = WorkflowExpression.Compile(attributeId, nameof(attributeId), required: true);
            var __workflow_parentId = WorkflowExpression.Compile(parentId, nameof(parentId), required: true);
            return new DeferredBodyAction<DeleteLookupEntryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}/{2}", __workflow_repositoryId.WithUrlEncoding(1), __workflow_attributeId.WithUrlEncoding(1), __workflow_parentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<DeleteLookupEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<SearchLookupEntriesResponse, ApiConnectionActionConfiguration> SearchLookupEntries(Expression<Func<string>> repositoryId, Expression<Func<string>> attributeId, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null)
        {
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_attributeId = WorkflowExpression.Compile(attributeId, nameof(attributeId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<SearchLookupEntriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}", __workflow_repositoryId.WithUrlEncoding(1), __workflow_attributeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["$orderby"] = Convert.ToString("key");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<SearchLookupEntriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SearchCabinets(Expression<Func<string>> cabinets, Expression<Func<string>> q, Expression<Func<string>> select, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> skiptoken = null)
        {
            var __workflow_cabinets = WorkflowExpression.Compile(cabinets, nameof(cabinets), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/Search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cabinets"] = ExpressionConverter.Convert(__workflow_cabinets);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                callPayload.Queries["select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LockDocument(Expression<Func<string>> id, Expression<Func<string>> comment = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document/{0}/lock", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_comment != null)
                    callPayload.Queries["comment"] = ExpressionConverter.Convert(__workflow_comment);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnockDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/document/{0}/unlock", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetRepositoryLog(Expression<Func<string>> repositoryId, Expression<Func<logtypeInput>> logtype, Expression<Func<string>> start = null, Expression<Func<string>> end = null)
        {
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_logtype = WorkflowExpression.Compile(logtype, nameof(logtype), required: true);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Repository/{0}/log", __workflow_repositoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                callPayload.Queries["Logtype"] = ExpressionConverter.Convert(__workflow_logtype);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetRepositoryInformation(Expression<Func<string>> repositoryId)
        {
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Repository/{0}/info", __workflow_repositoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetRepositoryUsersResponseItem[], ApiConnectionActionConfiguration> GetRepositoryUsers(Expression<Func<string>> repositoryId)
        {
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            return new DeferredBodyAction<GetRepositoryUsersResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Repository/{0}/users", __workflow_repositoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetRepositoryUsersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> GetRepositoryGroups(Expression<Func<string>> repositoryId, Expression<Func<string>> filter = null, Expression<Func<string>> top = null, Expression<Func<bool>> paging = null, Expression<Func<string>> skiptoken = null, Expression<Func<returnInfoInput>> returnInfo = null)
        {
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_paging = WorkflowExpression.Compile(paging, nameof(paging), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            var __workflow_returnInfo = WorkflowExpression.Compile(returnInfo, nameof(returnInfo), required: false);
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Repository/{0}/groups", __workflow_repositoryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["paging"] = Convert.ToString(false);
                if (__workflow_paging != null)
                    callPayload.Queries["paging"] = ExpressionConverter.Convert(__workflow_paging);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                callPayload.Queries["returnInfo"] = Convert.ToString("");
                if (__workflow_returnInfo != null)
                    callPayload.Queries["returnInfo"] = ExpressionConverter.Convert(__workflow_returnInfo);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteRepositoryGroup(Expression<Func<string>> repositoryId, Expression<Func<string>> groupId)
        {
            var __workflow_repositoryId = WorkflowExpression.Compile(repositoryId, nameof(repositoryId), required: true);
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Repository/{0}/group/{1}", __workflow_repositoryId.WithUrlEncoding(1), __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetCabinetSettings(Expression<Func<string>> cabinetId)
        {
            var __workflow_cabinetId = WorkflowExpression.Compile(cabinetId, nameof(cabinetId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/cabinet/{0}/settings", __workflow_cabinetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetCabinetInformation(Expression<Func<string>> cabinetId)
        {
            var __workflow_cabinetId = WorkflowExpression.Compile(cabinetId, nameof(cabinetId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/cabinet/{0}/info", __workflow_cabinetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetCabinetCustomAttributes(Expression<Func<string>> cabinetId)
        {
            var __workflow_cabinetId = WorkflowExpression.Compile(cabinetId, nameof(cabinetId), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/cabinet/{0}/customAttributes", __workflow_cabinetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCabinetDefaultAccessResponseItem[], ApiConnectionActionConfiguration> GetCabinetDefaultAccess(Expression<Func<string>> cabinetId)
        {
            var __workflow_cabinetId = WorkflowExpression.Compile(cabinetId, nameof(cabinetId), required: true);
            return new DeferredBodyAction<GetCabinetDefaultAccessResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/cabinet/{0}/membership", __workflow_cabinetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetCabinetDefaultAccessResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCabinetGroupsResponseItem[], ApiConnectionActionConfiguration> GetCabinetGroups(Expression<Func<string>> cabinetId)
        {
            var __workflow_cabinetId = WorkflowExpression.Compile(cabinetId, nameof(cabinetId), required: true);
            return new DeferredBodyAction<GetCabinetGroupsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cabinet/{0}/groups", __workflow_cabinetId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetCabinetGroupsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetContainerContents(Expression<Func<string>> containerId, Expression<Func<string>> select, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null, Expression<Func<string>> orderby = null)
        {
            var __workflow_containerId = WorkflowExpression.Compile(containerId, nameof(containerId), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/container/{0}", __workflow_containerId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetGroupInformationResponse, ApiConnectionActionConfiguration> GetGroupInformation(Expression<Func<string>> groupId, Expression<Func<bool>> cabMembership = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_cabMembership = WorkflowExpression.Compile(cabMembership, nameof(cabMembership), required: false);
            return new DeferredBodyAction<GetGroupInformationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Group/{0}/info", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cabMembership"] = Convert.ToString(false);
                if (__workflow_cabMembership != null)
                    callPayload.Queries["cabMembership"] = ExpressionConverter.Convert(__workflow_cabMembership);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetGroupInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetGroupMembershipResponseItem[], ApiConnectionActionConfiguration> GetGroupMembership(Expression<Func<string>> groupId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<GetGroupMembershipResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Group/{0}/members", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetGroupMembershipResponseItem[]>(callPayload);
            });
        }
    }

    public class NetdocumentsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> SearchCab(Expression<Func<string>> cabId, Expression<Func<string>> q, Expression<Func<orderbyInput>> orderby = null, Expression<Func<string>> top = null, Expression<Func<string>> select = null, FlowRecurrence recurrence = null)
        {
            var __workflow_cabId = WorkflowExpression.Compile(cabId, nameof(cabId), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Search/{0}", __workflow_cabId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                callPayload.Queries["$orderby"] = Convert.ToString("relevance desc");
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetUserInfoResponse
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("isRepositoryMember")]
        public bool IsRepositoryMember { get; set; }

        [JsonProperty("primaryCabinet")]
        public string PrimaryCabinet { get; set; }

        [JsonProperty("sortLookupBy")]
        public string SortLookupBy { get; set; }

        [JsonProperty("external")]
        public bool External { get; set; }
    }

    public class GetUserCabinetsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isCollaborationSpacesEnabled")]
        public string IsCollaborationSpacesEnabled { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("repositoryId")]
        public string RepositoryId { get; set; }

        [JsonProperty("repositoryName")]
        public string RepositoryName { get; set; }

        [JsonProperty("wsAttrNum")]
        public int WsAttrNum { get; set; }

        [JsonProperty("wsOrgAttrNum")]
        public int WsOrgAttrNum { get; set; }
    }

    public class NewVersionResponse
    {
        [JsonProperty("latestVersionNumber")]
        public int LatestVersionNumber { get; set; }

        [JsonProperty("newVer")]
        public int NewVer { get; set; }

        [JsonProperty("newVersionLabel")]
        public string NewVersionLabel { get; set; }

        [JsonProperty("officialVer")]
        public int OfficialVer { get; set; }

        [JsonProperty("officialVerName")]
        public string OfficialVerName { get; set; }

        [JsonProperty("versions")]
        public int Versions { get; set; }
    }

    public class RenameDocumentInput
    {
        [JsonProperty("standardAttributes")]
        public RenameDocumentInputStandardAttributesType StandardAttributes { get; set; }
    }

    public class RenameDocumentInputStandardAttributesType
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewName { get; set; }
    }

    public class RenameFolderInput
    {
        [JsonProperty("standardAttributes")]
        public RenameFolderInputStandardAttributesType StandardAttributes { get; set; }
    }

    public class RenameFolderInputStandardAttributesType
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NewName { get; set; }
    }

    public class GetCurrentUserInfoResponse
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("isRepositoryMember")]
        public bool IsRepositoryMember { get; set; }

        [JsonProperty("primaryCabinet")]
        public string PrimaryCabinet { get; set; }

        [JsonProperty("sortLookupBy")]
        public string SortLookupBy { get; set; }

        [JsonProperty("external")]
        public bool External { get; set; }
    }

    public class CreateWorkspaceParentChildResponse
    {
        [JsonProperty("standardAttributes")]
        public CreateWorkspaceParentChildResponseStandardAttributesType StandardAttributes { get; set; }
    }

    public class CreateWorkspaceParentChildResponseStandardAttributesType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateWorkspaceSingleResponse
    {
        [JsonProperty("standardAttributes")]
        public CreateWorkspaceSingleResponseStandardAttributesType StandardAttributes { get; set; }
    }

    public class CreateWorkspaceSingleResponseStandardAttributesType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateChildEntryResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class CreateChildEntryInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("defaulting")]
        public string Type { get; set; }

        [JsonProperty("hold")]
        public bool? LitigationHold { get; set; }

        [JsonProperty("closed")]
        public string ClosedDate { get; set; }

        [JsonProperty("access")]
        public CreateChildEntryInputAccessType Access { get; set; }
    }

    public class CreateChildEntryInputAccessType
    {
        [JsonProperty("filtered_permissions", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool FilteredPermissions { get; set; }

        [JsonProperty("force_permissions", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ForcePermssions { get; set; }

        [JsonProperty("permissions")]
        public CreateChildEntryInputAccessTypePermissionsTypeItem[] Permissions { get; set; }
    }

    public class CreateChildEntryInputAccessTypePermissionsTypeItem
    {
        [JsonProperty("view", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool View { get; set; }

        [JsonProperty("edit", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Edit { get; set; }

        [JsonProperty("share", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Share { get; set; }

        [JsonProperty("administer", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Administer { get; set; }

        [JsonProperty("noAccess", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool NoAccess { get; set; }

        [JsonProperty("cabDefault", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CabinetDefault { get; set; }

        [JsonProperty("principal", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Principal { get; set; }
    }

    public class DeleteChildEntryResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class CreateEntryResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class CreateEntryInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("defaulting")]
        public string Type { get; set; }

        [JsonProperty("hold")]
        public bool? LitigationHold { get; set; }

        [JsonProperty("closed")]
        public string ClosedDate { get; set; }

        [JsonProperty("access")]
        public CreateEntryInputAccessType Access { get; set; }
    }

    public class CreateEntryInputAccessType
    {
        [JsonProperty("filtered_permissions", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool FilteredPermissions { get; set; }

        [JsonProperty("force_permissions", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ForcePermssions { get; set; }

        [JsonProperty("permissions")]
        public CreateEntryInputAccessTypePermissionsTypeItem[] Permissions { get; set; }
    }

    public class CreateEntryInputAccessTypePermissionsTypeItem
    {
        [JsonProperty("view", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool View { get; set; }

        [JsonProperty("edit", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Edit { get; set; }

        [JsonProperty("share", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Share { get; set; }

        [JsonProperty("administer", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Administer { get; set; }

        [JsonProperty("noAccess", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool NoAccess { get; set; }

        [JsonProperty("cabDefault", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CabinetDefault { get; set; }

        [JsonProperty("principal", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Principal { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderbyInput
    {
        [EnumMember(Value = "relevance desc")]
        RelevanceDesc,
        [EnumMember(Value = "lastMod desc")]
        LastModDesc,
        [EnumMember(Value = "name asc")]
        NameAsc,
        [EnumMember(Value = "relevance asc")]
        RelevanceAsc,
        [EnumMember(Value = "lastMod asc")]
        LastModAsc,
        [EnumMember(Value = "name desc")]
        NameDesc
    }

    public class DeleteLookupEntryResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class SearchLookupEntriesResponse
    {
        [JsonProperty("rows")]
        public SearchLookupEntriesResponseRowsTypeItem[] Rows { get; set; }
    }

    public class SearchLookupEntriesResponseRowsTypeItem
    {
        [JsonProperty("defaulting")]
        public string Defaulting { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("hold")]
        public bool Hold { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("closed")]
        public string Closed { get; set; }

        [JsonProperty("access")]
        public string Access { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum logtypeInput
    {
        [EnumMember(Value = "consolidated")]
        Consolidated,
        [EnumMember(Value = "admin")]
        Admin
    }

    public class GetRepositoryUsersResponseItem
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("external")]
        public bool External { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastLogin")]
        public string LastLogin { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum returnInfoInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "")]
        None
    }

    public class GetCabinetDefaultAccessResponseItem
    {
        [JsonProperty("administer")]
        public bool Administer { get; set; }

        [JsonProperty("cabDefault")]
        public bool CabDefault { get; set; }

        [JsonProperty("edit")]
        public bool Edit { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("noAccess")]
        public bool NoAccess { get; set; }

        [JsonProperty("principal")]
        public string Principal { get; set; }

        [JsonProperty("share")]
        public bool Share { get; set; }

        [JsonProperty("view")]
        public bool View { get; set; }
    }

    public class GetCabinetGroupsResponseItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool External { get; set; }
        public bool Hidden { get; set; }
    }

    public class GetGroupInformationResponse
    {
        [JsonProperty("external")]
        public bool External { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("hideMembership")]
        public bool HideMembership { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("cabMembership")]
        public GetGroupInformationResponseCabMembershipTypeItem[] CabMembership { get; set; }
    }

    public class GetGroupInformationResponseCabMembershipTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rights")]
        public string Rights { get; set; }
    }

    public class GetGroupMembershipResponseItem
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Netdocuments;

    public partial class WorkflowManagedActions
    {
        public NetdocumentsActions Netdocuments(string connectionId) => new NetdocumentsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NetdocumentsTriggers Netdocuments(string connectionId) => new NetdocumentsTriggers(connectionId);
    }
}