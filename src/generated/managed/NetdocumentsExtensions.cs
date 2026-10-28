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
        public IBodyWorkflowAction<GetUserInfoResponse> GetUserInfo(Expression<Func<string>> id, Expression<Func<string>> cabGuid = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_cabGuid = WorkflowExpression.Compile(cabGuid, nameof(cabGuid), required: false);
            return new DeferredBodyAction<GetUserInfoResponse>(() =>
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
        public IBodyWorkflowAction<GetUserCabinetsResponseItem[]> GetUserCabinets()
        {
            var apiCallPath = "/v1/User/cabinets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetUserCabinetsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<NewVersionResponse> NewVersion(Expression<Func<string>> id, Expression<Func<string>> extension = null, Expression<Func<string>> versionDescription = null, Expression<Func<string>> verName = null, Expression<Func<bool>> official = null, Expression<Func<bool>> addToRecent = null, Expression<Func<string>> srcVer = null, Expression<Func<bool>> allocatesubversion = null, Expression<Func<string>> body = null)
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
            return new DeferredBodyAction<NewVersionResponse>(() =>
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
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NewVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetDocInfo(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Document/{0}/info", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction RenameDocument(Expression<Func<string>> id, Expression<Func<string>> renameBodystandardAttributesnewName)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_renameBodystandardAttributesnewName = WorkflowExpression.Compile(renameBodystandardAttributesnewName, nameof(renameBodystandardAttributesnewName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Document/{0}/info", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var renameBody = new JObject();
                var renameBodypropCount = 0;
                var standardAttributesObject = new JObject();
                var standardAttributesObjectpropCount = 0;
                standardAttributesObjectpropCount++;
                standardAttributesObject["name"] = ExpressionConverter.ConvertO(__workflow_renameBodystandardAttributesnewName);
                if (standardAttributesObjectpropCount > 0)
                {
                    renameBody["standardAttributes"] = standardAttributesObject;
                    renameBodypropCount++;
                }

                if (renameBodypropCount > 0)
                {
                    callPayload.Body = renameBody;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetDocContent(Expression<Func<string>> id, Expression<Func<bool>> base64 = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_base64 = WorkflowExpression.Compile(base64, nameof(base64), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction DeleteDoc(Expression<Func<string>> id, Expression<Func<bool>> permanent = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_permanent = WorkflowExpression.Compile(permanent, nameof(permanent), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction UpdateDocument(Expression<Func<string>> id, Expression<Func<string>> extension = null, Expression<Func<bool>> base64 = null, Expression<Func<string>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_extension = WorkflowExpression.Compile(extension, nameof(extension), required: false);
            var __workflow_base64 = WorkflowExpression.Compile(base64, nameof(base64), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<CreateFolderResponse> CreateFolder(Expression<Func<string>> name, Expression<Func<string>> parent = null, Expression<Func<string>> cabinet = null)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_parent = WorkflowExpression.Compile(parent, nameof(parent), required: false);
            var __workflow_cabinet = WorkflowExpression.Compile(cabinet, nameof(cabinet), required: false);
            return new DeferredBodyAction<CreateFolderResponse>(() =>
            {
                var apiCallPath = "/v1/Folder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CreateFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetFldContent(Expression<Func<string>> id, Expression<Func<string>> select = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction FileFolder(Expression<Func<string>> id, Expression<Func<string>> item, Expression<Func<actionInput>> action)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            var __workflow_action = WorkflowExpression.Compile(action, nameof(action), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Folder/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction DeleteFolder(Expression<Func<string>> id, Expression<Func<bool>> permanent = null, Expression<Func<bool>> deleteContents = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_permanent = WorkflowExpression.Compile(permanent, nameof(permanent), required: false);
            var __workflow_deleteContents = WorkflowExpression.Compile(deleteContents, nameof(deleteContents), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction RenameFolder(Expression<Func<string>> id, Expression<Func<string>> renameBodystandardAttributesnewName)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_renameBodystandardAttributesnewName = WorkflowExpression.Compile(renameBodystandardAttributesnewName, nameof(renameBodystandardAttributesnewName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Folder/{0}/info", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var renameBody = new JObject();
                var renameBodypropCount = 0;
                var standardAttributesObject = new JObject();
                var standardAttributesObjectpropCount = 0;
                standardAttributesObjectpropCount++;
                standardAttributesObject["name"] = ExpressionConverter.ConvertO(__workflow_renameBodystandardAttributesnewName);
                if (standardAttributesObjectpropCount > 0)
                {
                    renameBody["standardAttributes"] = standardAttributesObject;
                    renameBodypropCount++;
                }

                if (renameBodypropCount > 0)
                {
                    callPayload.Body = renameBody;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction FollowFolder(Expression<Func<string>> id, Expression<Func<string>> recipients, Expression<Func<sendInput>> send = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_recipients = WorkflowExpression.Compile(recipients, nameof(recipients), required: true);
            var __workflow_send = WorkflowExpression.Compile(send, nameof(send), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Folder/{0}/follow", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction FollowDocument(Expression<Func<string>> id, Expression<Func<string>> recipients, Expression<Func<sendInput>> send = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_recipients = WorkflowExpression.Compile(recipients, nameof(recipients), required: true);
            var __workflow_send = WorkflowExpression.Compile(send, nameof(send), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/Document/follow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCurrentUserInfoResponse> GetCurrentUserInfo(Expression<Func<string>> cabGuid = null)
        {
            var __workflow_cabGuid = WorkflowExpression.Compile(cabGuid, nameof(cabGuid), required: false);
            return new DeferredBodyAction<GetCurrentUserInfoResponse>(() =>
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
        public IWorkflowAction CheckinDoc(Expression<Func<string>> id, Expression<Func<string>> extension = null, Expression<Func<object>> file = null, Expression<Func<bool>> addToRecent = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_extension = WorkflowExpression.Compile(extension, nameof(extension), required: false);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: false);
            var __workflow_addToRecent = WorkflowExpression.Compile(addToRecent, nameof(addToRecent), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/Document/checkin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction CheckOutDoc(Expression<Func<string>> id, Expression<Func<string>> comment = null, Expression<Func<bool>> download = null, Expression<Func<string>> version = null, Expression<Func<bool>> addToRecent = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            var __workflow_download = WorkflowExpression.Compile(download, nameof(download), required: false);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: false);
            var __workflow_addToRecent = WorkflowExpression.Compile(addToRecent, nameof(addToRecent), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/Document/checkout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateDocumentResponse> CreateDocument(Expression<Func<string>> destination, Expression<Func<object>> file, Expression<Func<bool>> addToRecent = null, Expression<Func<string>> profile = null)
        {
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_addToRecent = WorkflowExpression.Compile(addToRecent, nameof(addToRecent), required: false);
            var __workflow_profile = WorkflowExpression.Compile(profile, nameof(profile), required: false);
            return new DeferredBodyAction<CreateDocumentResponse>(() =>
            {
                var apiCallPath = "/v1/Document/upload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CreateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction LockDocumentVersion(Expression<Func<string>> id, Expression<Func<int>> version, Expression<Func<string>> description = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: true);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/Document/lock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetDocumentVersions(Expression<Func<string>> documentID)
        {
            var __workflow_documentID = WorkflowExpression.Compile(documentID, nameof(documentID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Document/{0}/versionList", __workflow_documentID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateSecuredLinkResponse> CreateSecuredLink(Expression<Func<string>> id, Expression<Func<string>> password = null, Expression<Func<string>> expirationdate = null, Expression<Func<string>> version = null, Expression<Func<bool>> download = null, Expression<Func<bool>> notifyme = null, Expression<Func<bool>> @lock = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_password = WorkflowExpression.Compile(password, nameof(password), required: false);
            var __workflow_expirationdate = WorkflowExpression.Compile(expirationdate, nameof(expirationdate), required: false);
            var __workflow_version = WorkflowExpression.Compile(version, nameof(version), required: false);
            var __workflow_download = WorkflowExpression.Compile(download, nameof(download), required: false);
            var __workflow_notifyme = WorkflowExpression.Compile(notifyme, nameof(notifyme), required: false);
            var __workflow_lock = WorkflowExpression.Compile(@lock, nameof(@lock), required: false);
            return new DeferredBodyAction<CreateSecuredLinkResponse>(() =>
            {
                var apiCallPath = "/v1/Document/createsecuredlink";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CreateSecuredLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetDocHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Document/{0}/history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateWorkspaceParentChildResponse> CreateWorkspaceParentChild(Expression<Func<string>> cabinetID, Expression<Func<string>> parentID, Expression<Func<string>> childID)
        {
            var __workflow_cabinetID = WorkflowExpression.Compile(cabinetID, nameof(cabinetID), required: true);
            var __workflow_parentID = WorkflowExpression.Compile(parentID, nameof(parentID), required: true);
            var __workflow_childID = WorkflowExpression.Compile(childID, nameof(childID), required: true);
            return new DeferredBodyAction<CreateWorkspaceParentChildResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Workspace/{0}/{1}/{2}/info", __workflow_cabinetID.WithUrlEncoding(1), __workflow_parentID.WithUrlEncoding(1), __workflow_childID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CreateWorkspaceParentChildResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateWorkspaceSingleResponse> CreateWorkspaceSingle(Expression<Func<string>> cabinetID, Expression<Func<string>> parentID)
        {
            var __workflow_cabinetID = WorkflowExpression.Compile(cabinetID, nameof(cabinetID), required: true);
            var __workflow_parentID = WorkflowExpression.Compile(parentID, nameof(parentID), required: true);
            return new DeferredBodyAction<CreateWorkspaceSingleResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Workspace/{0}/{1}/info", __workflow_cabinetID.WithUrlEncoding(1), __workflow_parentID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CreateWorkspaceSingleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetWorkspaceInformation(Expression<Func<string>> workspaceID)
        {
            var __workflow_workspaceID = WorkflowExpression.Compile(workspaceID, nameof(workspaceID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Workspace/{0}/info", __workflow_workspaceID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateChildEntryResponse> CreateChildEntry(Expression<Func<string>> repositoryID, Expression<Func<string>> childAttributeID, Expression<Func<string>> parentID, Expression<Func<string>> childID, Expression<Func<bool>> lookupEntryBodyaccessfilteredPermissions, Expression<Func<bool>> lookupEntryBodyaccessforcePermssions, Expression<Func<string>> lookupEntryBodydescription = null, Expression<Func<string>> lookupEntryBodytype = null, Expression<Func<bool>> lookupEntryBodylitigationHold = null, Expression<Func<string>> lookupEntryBodyclosedDate = null, Expression<Func<lookupEntryBodyaccesspermissionsInputItem[]>> lookupEntryBodyaccesspermissions = null)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            var __workflow_childAttributeID = WorkflowExpression.Compile(childAttributeID, nameof(childAttributeID), required: true);
            var __workflow_parentID = WorkflowExpression.Compile(parentID, nameof(parentID), required: true);
            var __workflow_childID = WorkflowExpression.Compile(childID, nameof(childID), required: true);
            var __workflow_lookupEntryBodyaccessfilteredPermissions = WorkflowExpression.Compile(lookupEntryBodyaccessfilteredPermissions, nameof(lookupEntryBodyaccessfilteredPermissions), required: true);
            var __workflow_lookupEntryBodyaccessforcePermssions = WorkflowExpression.Compile(lookupEntryBodyaccessforcePermssions, nameof(lookupEntryBodyaccessforcePermssions), required: true);
            var __workflow_lookupEntryBodydescription = WorkflowExpression.Compile(lookupEntryBodydescription, nameof(lookupEntryBodydescription), required: false);
            var __workflow_lookupEntryBodytype = WorkflowExpression.Compile(lookupEntryBodytype, nameof(lookupEntryBodytype), required: false);
            var __workflow_lookupEntryBodylitigationHold = WorkflowExpression.Compile(lookupEntryBodylitigationHold, nameof(lookupEntryBodylitigationHold), required: false);
            var __workflow_lookupEntryBodyclosedDate = WorkflowExpression.Compile(lookupEntryBodyclosedDate, nameof(lookupEntryBodyclosedDate), required: false);
            var __workflow_lookupEntryBodyaccesspermissions = WorkflowExpression.Compile(lookupEntryBodyaccesspermissions, nameof(lookupEntryBodyaccesspermissions), required: false);
            return new DeferredBodyAction<CreateChildEntryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", __workflow_repositoryID.WithUrlEncoding(1), __workflow_childAttributeID.WithUrlEncoding(1), __workflow_parentID.WithUrlEncoding(1), __workflow_childID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var lookupEntryBody = new JObject();
                var lookupEntryBodypropCount = 0;
                if (__workflow_lookupEntryBodydescription != null)
                {
                    lookupEntryBody["description"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodydescription);
                    lookupEntryBodypropCount++;
                }

                if (__workflow_lookupEntryBodytype != null)
                {
                    lookupEntryBody["defaulting"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodytype);
                    lookupEntryBodypropCount++;
                }

                if (__workflow_lookupEntryBodylitigationHold != null)
                {
                    lookupEntryBody["hold"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodylitigationHold);
                    lookupEntryBodypropCount++;
                }

                if (__workflow_lookupEntryBodyclosedDate != null)
                {
                    lookupEntryBody["closed"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodyclosedDate);
                    lookupEntryBodypropCount++;
                }

                var accessObject = new JObject();
                var accessObjectpropCount = 0;
                accessObjectpropCount++;
                accessObject["filtered_permissions"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodyaccessfilteredPermissions);
                accessObjectpropCount++;
                accessObject["force_permissions"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodyaccessforcePermssions);
                if (__workflow_lookupEntryBodyaccesspermissions != null)
                {
                    accessObject["permissions"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodyaccesspermissions);
                    accessObjectpropCount++;
                }

                if (accessObjectpropCount > 0)
                {
                    lookupEntryBody["access"] = accessObject;
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodypropCount > 0)
                {
                    callPayload.Body = lookupEntryBody;
                }

                return new ApiConnectionAction<CreateChildEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetChildEntry(Expression<Func<string>> repositoryID, Expression<Func<string>> childAttributeID, Expression<Func<string>> parentID, Expression<Func<string>> childID)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            var __workflow_childAttributeID = WorkflowExpression.Compile(childAttributeID, nameof(childAttributeID), required: true);
            var __workflow_parentID = WorkflowExpression.Compile(parentID, nameof(parentID), required: true);
            var __workflow_childID = WorkflowExpression.Compile(childID, nameof(childID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", __workflow_repositoryID.WithUrlEncoding(1), __workflow_childAttributeID.WithUrlEncoding(1), __workflow_parentID.WithUrlEncoding(1), __workflow_childID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<DeleteChildEntryResponse> DeleteChildEntry(Expression<Func<string>> repositoryID, Expression<Func<string>> childAttributeID, Expression<Func<string>> parentID, Expression<Func<string>> childID)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            var __workflow_childAttributeID = WorkflowExpression.Compile(childAttributeID, nameof(childAttributeID), required: true);
            var __workflow_parentID = WorkflowExpression.Compile(parentID, nameof(parentID), required: true);
            var __workflow_childID = WorkflowExpression.Compile(childID, nameof(childID), required: true);
            return new DeferredBodyAction<DeleteChildEntryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", __workflow_repositoryID.WithUrlEncoding(1), __workflow_childAttributeID.WithUrlEncoding(1), __workflow_parentID.WithUrlEncoding(1), __workflow_childID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<DeleteChildEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateEntryResponse> CreateEntry(Expression<Func<string>> repositoryID, Expression<Func<string>> attributeID, Expression<Func<string>> parentID, Expression<Func<bool>> lookupEntryBodyaccessfilteredPermissions, Expression<Func<bool>> lookupEntryBodyaccessforcePermssions, Expression<Func<string>> lookupEntryBodydescription = null, Expression<Func<string>> lookupEntryBodytype = null, Expression<Func<bool>> lookupEntryBodylitigationHold = null, Expression<Func<string>> lookupEntryBodyclosedDate = null, Expression<Func<lookupEntryBodyaccesspermissionsInputItem[]>> lookupEntryBodyaccesspermissions = null)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            var __workflow_attributeID = WorkflowExpression.Compile(attributeID, nameof(attributeID), required: true);
            var __workflow_parentID = WorkflowExpression.Compile(parentID, nameof(parentID), required: true);
            var __workflow_lookupEntryBodyaccessfilteredPermissions = WorkflowExpression.Compile(lookupEntryBodyaccessfilteredPermissions, nameof(lookupEntryBodyaccessfilteredPermissions), required: true);
            var __workflow_lookupEntryBodyaccessforcePermssions = WorkflowExpression.Compile(lookupEntryBodyaccessforcePermssions, nameof(lookupEntryBodyaccessforcePermssions), required: true);
            var __workflow_lookupEntryBodydescription = WorkflowExpression.Compile(lookupEntryBodydescription, nameof(lookupEntryBodydescription), required: false);
            var __workflow_lookupEntryBodytype = WorkflowExpression.Compile(lookupEntryBodytype, nameof(lookupEntryBodytype), required: false);
            var __workflow_lookupEntryBodylitigationHold = WorkflowExpression.Compile(lookupEntryBodylitigationHold, nameof(lookupEntryBodylitigationHold), required: false);
            var __workflow_lookupEntryBodyclosedDate = WorkflowExpression.Compile(lookupEntryBodyclosedDate, nameof(lookupEntryBodyclosedDate), required: false);
            var __workflow_lookupEntryBodyaccesspermissions = WorkflowExpression.Compile(lookupEntryBodyaccesspermissions, nameof(lookupEntryBodyaccesspermissions), required: false);
            return new DeferredBodyAction<CreateEntryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}/{2}", __workflow_repositoryID.WithUrlEncoding(1), __workflow_attributeID.WithUrlEncoding(1), __workflow_parentID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var lookupEntryBody = new JObject();
                var lookupEntryBodypropCount = 0;
                if (__workflow_lookupEntryBodydescription != null)
                {
                    lookupEntryBody["description"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodydescription);
                    lookupEntryBodypropCount++;
                }

                if (__workflow_lookupEntryBodytype != null)
                {
                    lookupEntryBody["defaulting"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodytype);
                    lookupEntryBodypropCount++;
                }

                if (__workflow_lookupEntryBodylitigationHold != null)
                {
                    lookupEntryBody["hold"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodylitigationHold);
                    lookupEntryBodypropCount++;
                }

                if (__workflow_lookupEntryBodyclosedDate != null)
                {
                    lookupEntryBody["closed"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodyclosedDate);
                    lookupEntryBodypropCount++;
                }

                var accessObject = new JObject();
                var accessObjectpropCount = 0;
                accessObjectpropCount++;
                accessObject["filtered_permissions"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodyaccessfilteredPermissions);
                accessObjectpropCount++;
                accessObject["force_permissions"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodyaccessforcePermssions);
                if (__workflow_lookupEntryBodyaccesspermissions != null)
                {
                    accessObject["permissions"] = ExpressionConverter.ConvertO(__workflow_lookupEntryBodyaccesspermissions);
                    accessObjectpropCount++;
                }

                if (accessObjectpropCount > 0)
                {
                    lookupEntryBody["access"] = accessObject;
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodypropCount > 0)
                {
                    callPayload.Body = lookupEntryBody;
                }

                return new ApiConnectionAction<CreateEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetLookupEntry(Expression<Func<string>> repositoryID, Expression<Func<string>> attributeID, Expression<Func<string>> parentID, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, Expression<Func<orderbyInput>> orderby = null)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            var __workflow_attributeID = WorkflowExpression.Compile(attributeID, nameof(attributeID), required: true);
            var __workflow_parentID = WorkflowExpression.Compile(parentID, nameof(parentID), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}/{2}", __workflow_repositoryID.WithUrlEncoding(1), __workflow_attributeID.WithUrlEncoding(1), __workflow_parentID.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<DeleteLookupEntryResponse> DeleteLookupEntry(Expression<Func<string>> repositoryID, Expression<Func<string>> attributeID, Expression<Func<string>> parentID)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            var __workflow_attributeID = WorkflowExpression.Compile(attributeID, nameof(attributeID), required: true);
            var __workflow_parentID = WorkflowExpression.Compile(parentID, nameof(parentID), required: true);
            return new DeferredBodyAction<DeleteLookupEntryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}/{2}", __workflow_repositoryID.WithUrlEncoding(1), __workflow_attributeID.WithUrlEncoding(1), __workflow_parentID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<DeleteLookupEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<SearchLookupEntriesResponse> SearchLookupEntries(Expression<Func<string>> repositoryID, Expression<Func<string>> attributeID, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            var __workflow_attributeID = WorkflowExpression.Compile(attributeID, nameof(attributeID), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<SearchLookupEntriesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/attributes/{0}/{1}", __workflow_repositoryID.WithUrlEncoding(1), __workflow_attributeID.WithUrlEncoding(1)));
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
        public IWorkflowAction SearchCabinets(Expression<Func<string>> cabinets, Expression<Func<string>> q, Expression<Func<string>> select, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> skiptoken = null)
        {
            var __workflow_cabinets = WorkflowExpression.Compile(cabinets, nameof(cabinets), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction RefreshWorkspace(Expression<Func<string>> workspaceID)
        {
            var __workflow_workspaceID = WorkflowExpression.Compile(workspaceID, nameof(workspaceID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Workspace/{0}", __workflow_workspaceID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction LockDocument(Expression<Func<string>> id, Expression<Func<string>> comment = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction UnockDocument(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction GetRepositoryLog(Expression<Func<string>> repositoryID, Expression<Func<logtypeInput>> logtype, Expression<Func<string>> start = null, Expression<Func<string>> end = null)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            var __workflow_logtype = WorkflowExpression.Compile(logtype, nameof(logtype), required: true);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Repository/{0}/log", __workflow_repositoryID.WithUrlEncoding(1)));
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
        public IWorkflowAction GetRepositoryInformation(Expression<Func<string>> repositoryID)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Repository/{0}/info", __workflow_repositoryID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetRepositoryUsersResponseItem[]> GetRepositoryUsers(Expression<Func<string>> repositoryID)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            return new DeferredBodyAction<GetRepositoryUsersResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Repository/{0}/users", __workflow_repositoryID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetRepositoryUsersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<string[]> GetRepositoryGroups(Expression<Func<string>> repositoryID, Expression<Func<string>> filter = null, Expression<Func<string>> top = null, Expression<Func<bool>> paging = null, Expression<Func<string>> skiptoken = null, Expression<Func<returnInfoInput>> returnInfo = null)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_paging = WorkflowExpression.Compile(paging, nameof(paging), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            var __workflow_returnInfo = WorkflowExpression.Compile(returnInfo, nameof(returnInfo), required: false);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Repository/{0}/groups", __workflow_repositoryID.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<CreateRepositoryGroupResponse> CreateRepositoryGroup(Expression<Func<string>> repositoryID, Expression<Func<string>> name, Expression<Func<bool>> external, Expression<Func<bool>> hidden, Expression<Func<bool>> hideMembership)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_external = WorkflowExpression.Compile(external, nameof(external), required: true);
            var __workflow_hidden = WorkflowExpression.Compile(hidden, nameof(hidden), required: true);
            var __workflow_hideMembership = WorkflowExpression.Compile(hideMembership, nameof(hideMembership), required: true);
            return new DeferredBodyAction<CreateRepositoryGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Repository/{0}/group", __workflow_repositoryID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction<CreateRepositoryGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction DeleteRepositoryGroup(Expression<Func<string>> repositoryID, Expression<Func<string>> groupID)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            var __workflow_groupID = WorkflowExpression.Compile(groupID, nameof(groupID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Repository/{0}/group/{1}", __workflow_repositoryID.WithUrlEncoding(1), __workflow_groupID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser(Expression<Func<string>> username, Expression<Func<string>> displayFirstName, Expression<Func<string>> displayLastName, Expression<Func<string>> email, Expression<Func<bool>> external, Expression<Func<bool>> sendWelcome, Expression<Func<string>> repository, Expression<Func<string>> displayMiddleName = null)
        {
            var __workflow_username = WorkflowExpression.Compile(username, nameof(username), required: true);
            var __workflow_displayFirstName = WorkflowExpression.Compile(displayFirstName, nameof(displayFirstName), required: true);
            var __workflow_displayLastName = WorkflowExpression.Compile(displayLastName, nameof(displayLastName), required: true);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: true);
            var __workflow_external = WorkflowExpression.Compile(external, nameof(external), required: true);
            var __workflow_sendWelcome = WorkflowExpression.Compile(sendWelcome, nameof(sendWelcome), required: true);
            var __workflow_repository = WorkflowExpression.Compile(repository, nameof(repository), required: true);
            var __workflow_displayMiddleName = WorkflowExpression.Compile(displayMiddleName, nameof(displayMiddleName), required: false);
            return new DeferredBodyAction<CreateUserResponse>(() =>
            {
                var apiCallPath = "/v1/User";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction<CreateUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction AddOrRemoveUserRepository(Expression<Func<string>> repositoryID, Expression<Func<actionInput>> action, Expression<Func<string>> member, Expression<Func<bool>> external, Expression<Func<bool>> deleteIfFederated = null)
        {
            var __workflow_repositoryID = WorkflowExpression.Compile(repositoryID, nameof(repositoryID), required: true);
            var __workflow_action = WorkflowExpression.Compile(action, nameof(action), required: true);
            var __workflow_member = WorkflowExpression.Compile(member, nameof(member), required: true);
            var __workflow_external = WorkflowExpression.Compile(external, nameof(external), required: true);
            var __workflow_deleteIfFederated = WorkflowExpression.Compile(deleteIfFederated, nameof(deleteIfFederated), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Repository/{0}/members", __workflow_repositoryID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateCollabSpaceResponse> CreateCollabSpace(Expression<Func<string>> workspaceID, Expression<Func<string>> name, Expression<Func<string>> description = null)
        {
            var __workflow_workspaceID = WorkflowExpression.Compile(workspaceID, nameof(workspaceID), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            return new DeferredBodyAction<CreateCollabSpaceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/container/{0}/collabspace", __workflow_workspaceID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction<CreateCollabSpaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetCabinetSettings(Expression<Func<string>> cabinetID)
        {
            var __workflow_cabinetID = WorkflowExpression.Compile(cabinetID, nameof(cabinetID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/cabinet/{0}/settings", __workflow_cabinetID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetCabinetInformation(Expression<Func<string>> cabinetID)
        {
            var __workflow_cabinetID = WorkflowExpression.Compile(cabinetID, nameof(cabinetID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/cabinet/{0}/info", __workflow_cabinetID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<JToken[]> GetCabinetCustomAttributes(Expression<Func<string>> cabinetID)
        {
            var __workflow_cabinetID = WorkflowExpression.Compile(cabinetID, nameof(cabinetID), required: true);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/cabinet/{0}/customAttributes", __workflow_cabinetID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCabinetDefaultAccessResponseItem[]> GetCabinetDefaultAccess(Expression<Func<string>> cabinetID)
        {
            var __workflow_cabinetID = WorkflowExpression.Compile(cabinetID, nameof(cabinetID), required: true);
            return new DeferredBodyAction<GetCabinetDefaultAccessResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/cabinet/{0}/membership", __workflow_cabinetID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetCabinetDefaultAccessResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction AddToOrRemoveGroupFromCabinet(Expression<Func<string>> cabinetID, Expression<Func<actionInput>> action, Expression<Func<string>> id, Expression<Func<bool>> view, Expression<Func<bool>> edit, Expression<Func<bool>> share, Expression<Func<bool>> administer, Expression<Func<bool>> noAccess)
        {
            var __workflow_cabinetID = WorkflowExpression.Compile(cabinetID, nameof(cabinetID), required: true);
            var __workflow_action = WorkflowExpression.Compile(action, nameof(action), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: true);
            var __workflow_edit = WorkflowExpression.Compile(edit, nameof(edit), required: true);
            var __workflow_share = WorkflowExpression.Compile(share, nameof(share), required: true);
            var __workflow_administer = WorkflowExpression.Compile(administer, nameof(administer), required: true);
            var __workflow_noAccess = WorkflowExpression.Compile(noAccess, nameof(noAccess), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/cabinet/{0}/membership", __workflow_cabinetID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCabinetGroupsResponseItem[]> GetCabinetGroups(Expression<Func<string>> cabinetID)
        {
            var __workflow_cabinetID = WorkflowExpression.Compile(cabinetID, nameof(cabinetID), required: true);
            return new DeferredBodyAction<GetCabinetGroupsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cabinet/{0}/groups", __workflow_cabinetID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetCabinetGroupsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateCabinetExternalGroupResponse> CreateCabinetExternalGroup(Expression<Func<string>> cabinetID, Expression<Func<string>> name, Expression<Func<optionsInput>> options = null, Expression<Func<accessInput>> access = null, Expression<Func<string>> collaborationSpaceId = null, Expression<Func<collaborationspaceaccessInput>> collaborationspaceaccess = null, Expression<Func<string>> topwsattributegroupkey = null)
        {
            var __workflow_cabinetID = WorkflowExpression.Compile(cabinetID, nameof(cabinetID), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_options = WorkflowExpression.Compile(options, nameof(options), required: false);
            var __workflow_access = WorkflowExpression.Compile(access, nameof(access), required: false);
            var __workflow_collaborationSpaceId = WorkflowExpression.Compile(collaborationSpaceId, nameof(collaborationSpaceId), required: false);
            var __workflow_collaborationspaceaccess = WorkflowExpression.Compile(collaborationspaceaccess, nameof(collaborationspaceaccess), required: false);
            var __workflow_topwsattributegroupkey = WorkflowExpression.Compile(topwsattributegroupkey, nameof(topwsattributegroupkey), required: false);
            return new DeferredBodyAction<CreateCabinetExternalGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/cabinet/{0}/group/external", __workflow_cabinetID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction<CreateCabinetExternalGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction SearchCabinetModifyACLs(Expression<Func<string>> cabinetID, Expression<Func<string>> q, Expression<Func<modeInput>> mode, Expression<Func<string>> newAcl, Expression<Func<string>> email = null, Expression<Func<completionEmailInput>> completionEmail = null)
        {
            var __workflow_cabinetID = WorkflowExpression.Compile(cabinetID, nameof(cabinetID), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_mode = WorkflowExpression.Compile(mode, nameof(mode), required: true);
            var __workflow_newAcl = WorkflowExpression.Compile(newAcl, nameof(newAcl), required: true);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_completionEmail = WorkflowExpression.Compile(completionEmail, nameof(completionEmail), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Search/{0}", __workflow_cabinetID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetContainerContents(Expression<Func<string>> containerID, Expression<Func<string>> select, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null, Expression<Func<string>> orderby = null)
        {
            var __workflow_containerID = WorkflowExpression.Compile(containerID, nameof(containerID), required: true);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/container/{0}", __workflow_containerID.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<GetGroupInformationResponse> GetGroupInformation(Expression<Func<string>> groupID, Expression<Func<bool>> cabMembership = null)
        {
            var __workflow_groupID = WorkflowExpression.Compile(groupID, nameof(groupID), required: true);
            var __workflow_cabMembership = WorkflowExpression.Compile(cabMembership, nameof(cabMembership), required: false);
            return new DeferredBodyAction<GetGroupInformationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Group/{0}/info", __workflow_groupID.WithUrlEncoding(1)));
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
        public IBodyWorkflowAction<GetGroupMembershipResponseItem[]> GetGroupMembership(Expression<Func<string>> groupID)
        {
            var __workflow_groupID = WorkflowExpression.Compile(groupID, nameof(groupID), required: true);
            return new DeferredBodyAction<GetGroupMembershipResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Group/{0}/members", __workflow_groupID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetGroupMembershipResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction AddOrRemoveGroupMember(Expression<Func<string>> groupID, Expression<Func<actionInput>> action, Expression<Func<string>> member)
        {
            var __workflow_groupID = WorkflowExpression.Compile(groupID, nameof(groupID), required: true);
            var __workflow_action = WorkflowExpression.Compile(action, nameof(action), required: true);
            var __workflow_member = WorkflowExpression.Compile(member, nameof(member), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/Group/{0}/members", __workflow_groupID.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class NetdocumentsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger SearchCab(Expression<Func<string>> cabId, Expression<Func<string>> q, Expression<Func<orderbyInput>> orderby = null, Expression<Func<string>> top = null, Expression<Func<string>> select = null, FlowRecurrence recurrence = null)
        {
            var __workflow_cabId = WorkflowExpression.Compile(cabId, nameof(cabId), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredWorkflowTrigger(() =>
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

    public class CreateFolderResponse
    {
        [JsonProperty("standardAttributes")]
        public CreateFolderResponseStandardAttributesType StandardAttributes { get; set; }
    }

    public class CreateFolderResponseStandardAttributesType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum actionInput
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "remove")]
        Remove
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sendInput
    {
        [EnumMember(Value = "ignoreGenerator")]
        IgnoreGenerator,
        [EnumMember(Value = "ignoreCreator")]
        IgnoreCreator,
        [EnumMember(Value = "always")]
        Always
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

    public class CreateDocumentResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateSecuredLinkResponse
    {
        [JsonProperty("standardAttributes")]
        public CreateSecuredLinkResponseStandardAttributesType StandardAttributes { get; set; }
    }

    public class CreateSecuredLinkResponseStandardAttributesType
    {
        [JsonProperty("view")]
        public string View { get; set; }

        [JsonProperty("download")]
        public string Download { get; set; }
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

    public class lookupEntryBodyaccesspermissionsInputItem
    {
        [JsonProperty("view")]
        public bool View { get; set; }

        [JsonProperty("edit")]
        public bool Edit { get; set; }

        [JsonProperty("share")]
        public bool Share { get; set; }

        [JsonProperty("administer")]
        public bool Administer { get; set; }

        [JsonProperty("noAccess")]
        public bool NoAccess { get; set; }

        [JsonProperty("cabDefault")]
        public bool CabinetDefault { get; set; }

        [JsonProperty("principal")]
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

    public class CreateRepositoryGroupResponse
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
    }

    public class CreateUserResponse
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("external")]
        public bool External { get; set; }
    }

    public class CreateCollabSpaceResponse
    {
        public string Id { get; set; }
        public string EnvUrl { get; set; }
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

    public class CreateCabinetExternalGroupResponse
    {
        public int Type { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Options { get; set; }
        public string Access { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum optionsInput
    {
        [EnumMember(Value = "hidden")]
        Hidden,
        [EnumMember(Value = "hideMembership")]
        HideMembership,
        [EnumMember(Value = "hidden,hideMembership")]
        HiddenHideMembership
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum accessInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "1,2")]
        _12,
        [EnumMember(Value = "1,4")]
        _14,
        [EnumMember(Value = "1,2,4")]
        _124,
        [EnumMember(Value = "1,2,4,8")]
        _1248
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum collaborationspaceaccessInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "1,2")]
        _12,
        [EnumMember(Value = "1,4")]
        _14,
        [EnumMember(Value = "1,2,4")]
        _124,
        [EnumMember(Value = "1,2,4,8")]
        _1248
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum modeInput
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "remove")]
        Remove
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum completionEmailInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "fail")]
        Fail
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
