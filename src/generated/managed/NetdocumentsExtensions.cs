//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Netdocuments
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NetdocumentsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetUserInfo))]
        public IBodyWorkflowAction<GetUserInfoResponse> GetUserInfo([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> cabGuid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUserInfoResponse> __BuildGetUserInfo(WorkflowExpression<string> id, WorkflowExpression<string> cabGuid = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(cabGuid, nameof(cabGuid), required: false);
            return new DeferredBodyAction<GetUserInfoResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/User/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cabGuid != null)
                    callPayload.Queries["cabGuid"] = ExpressionConverter.Convert(cabGuid);
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
        [WorkflowExpressionFactory(nameof(__BuildNewVersion))]
        public IBodyWorkflowAction<NewVersionResponse> NewVersion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> extension = null, [WorkflowExpression] Func<string> versionDescription = null, [WorkflowExpression] Func<string> verName = null, [WorkflowExpression] Func<bool> official = null, [WorkflowExpression] Func<bool> addToRecent = null, [WorkflowExpression] Func<string> srcVer = null, [WorkflowExpression] Func<bool> allocatesubversion = null, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NewVersionResponse> __BuildNewVersion(WorkflowExpression<string> id, WorkflowExpression<string> extension = null, WorkflowExpression<string> versionDescription = null, WorkflowExpression<string> verName = null, WorkflowExpression<bool> official = null, WorkflowExpression<bool> addToRecent = null, WorkflowExpression<string> srcVer = null, WorkflowExpression<bool> allocatesubversion = null, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(extension, nameof(extension), required: false);
            WorkflowExpression.Validate(versionDescription, nameof(versionDescription), required: false);
            WorkflowExpression.Validate(verName, nameof(verName), required: false);
            WorkflowExpression.Validate(official, nameof(official), required: false);
            WorkflowExpression.Validate(addToRecent, nameof(addToRecent), required: false);
            WorkflowExpression.Validate(srcVer, nameof(srcVer), required: false);
            WorkflowExpression.Validate(allocatesubversion, nameof(allocatesubversion), required: false);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<NewVersionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}/new", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extension != null)
                    callPayload.Queries["extension"] = ExpressionConverter.Convert(extension);
                if (versionDescription != null)
                    callPayload.Queries["version_description"] = ExpressionConverter.Convert(versionDescription);
                if (verName != null)
                    callPayload.Queries["verName"] = ExpressionConverter.Convert(verName);
                callPayload.Queries["official"] = Convert.ToString(true);
                if (official != null)
                    callPayload.Queries["official"] = ExpressionConverter.Convert(official);
                if (addToRecent != null)
                    callPayload.Queries["addToRecent"] = ExpressionConverter.Convert(addToRecent);
                if (srcVer != null)
                    callPayload.Queries["srcVer"] = ExpressionConverter.Convert(srcVer);
                callPayload.Queries["allocatesubversion"] = Convert.ToString(false);
                if (allocatesubversion != null)
                    callPayload.Queries["allocatesubversion"] = ExpressionConverter.Convert(allocatesubversion);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<NewVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocInfo))]
        public IWorkflowAction GetDocInfo([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDocInfo(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildRenameDocument))]
        public IWorkflowAction RenameDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> renameBodystandardAttributesnewName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenameDocument(WorkflowExpression<string> id, WorkflowExpression<string> renameBodystandardAttributesnewName)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(renameBodystandardAttributesnewName, nameof(renameBodystandardAttributesnewName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var renameBody = new JObject();
                var renameBodypropCount = 0;
                var standardAttributesObject = new JObject();
                var standardAttributesObjectpropCount = 0;
                standardAttributesObjectpropCount++;
                standardAttributesObject["name"] = ExpressionConverter.ConvertO(renameBodystandardAttributesnewName);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDocContent))]
        public IWorkflowAction GetDocContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> base64 = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDocContent(WorkflowExpression<string> id, WorkflowExpression<bool> base64 = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(base64, nameof(base64), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["base64"] = Convert.ToString(false);
                if (base64 != null)
                    callPayload.Queries["base64"] = ExpressionConverter.Convert(base64);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDoc))]
        public IWorkflowAction DeleteDoc([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> permanent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteDoc(WorkflowExpression<string> id, WorkflowExpression<bool> permanent = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(permanent, nameof(permanent), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["permanent"] = Convert.ToString(false);
                if (permanent != null)
                    callPayload.Queries["permanent"] = ExpressionConverter.Convert(permanent);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateDocument))]
        public IWorkflowAction UpdateDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> extension = null, [WorkflowExpression] Func<bool> base64 = null, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateDocument(WorkflowExpression<string> id, WorkflowExpression<string> extension = null, WorkflowExpression<bool> base64 = null, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(extension, nameof(extension), required: false);
            WorkflowExpression.Validate(base64, nameof(base64), required: false);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extension != null)
                    callPayload.Queries["extension"] = ExpressionConverter.Convert(extension);
                callPayload.Queries["base64"] = Convert.ToString(true);
                if (base64 != null)
                    callPayload.Queries["base64"] = ExpressionConverter.Convert(base64);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFolder))]
        public IBodyWorkflowAction<CreateFolderResponse> CreateFolder([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> parent = null, [WorkflowExpression] Func<string> cabinet = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateFolderResponse> __BuildCreateFolder(WorkflowExpression<string> name, WorkflowExpression<string> parent = null, WorkflowExpression<string> cabinet = null)
        {
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(parent, nameof(parent), required: false);
            WorkflowExpression.Validate(cabinet, nameof(cabinet), required: false);
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
        [WorkflowExpressionFactory(nameof(__BuildGetFldContent))]
        public IWorkflowAction GetFldContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFldContent(WorkflowExpression<string> id, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildFileFolder))]
        public IWorkflowAction FileFolder([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> item, [WorkflowExpression] Func<actionInput> action)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFileFolder(WorkflowExpression<string> id, WorkflowExpression<string> item, WorkflowExpression<actionInput> action)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(item, nameof(item), required: true);
            WorkflowExpression.Validate(action, nameof(action), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFolder))]
        public IWorkflowAction DeleteFolder([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> permanent = null, [WorkflowExpression] Func<bool> deleteContents = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteFolder(WorkflowExpression<string> id, WorkflowExpression<bool> permanent = null, WorkflowExpression<bool> deleteContents = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(permanent, nameof(permanent), required: false);
            WorkflowExpression.Validate(deleteContents, nameof(deleteContents), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["permanent"] = Convert.ToString(false);
                if (permanent != null)
                    callPayload.Queries["permanent"] = ExpressionConverter.Convert(permanent);
                callPayload.Queries["deleteContents"] = Convert.ToString(false);
                if (deleteContents != null)
                    callPayload.Queries["deleteContents"] = ExpressionConverter.Convert(deleteContents);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildRenameFolder))]
        public IWorkflowAction RenameFolder([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> renameBodystandardAttributesnewName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenameFolder(WorkflowExpression<string> id, WorkflowExpression<string> renameBodystandardAttributesnewName)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(renameBodystandardAttributesnewName, nameof(renameBodystandardAttributesnewName), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Folder/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var renameBody = new JObject();
                var renameBodypropCount = 0;
                var standardAttributesObject = new JObject();
                var standardAttributesObjectpropCount = 0;
                standardAttributesObjectpropCount++;
                standardAttributesObject["name"] = ExpressionConverter.ConvertO(renameBodystandardAttributesnewName);
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
        [WorkflowExpressionFactory(nameof(__BuildFollowFolder))]
        public IWorkflowAction FollowFolder([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> recipients, [WorkflowExpression] Func<sendInput> send = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFollowFolder(WorkflowExpression<string> id, WorkflowExpression<string> recipients, WorkflowExpression<sendInput> send = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(recipients, nameof(recipients), required: true);
            WorkflowExpression.Validate(send, nameof(send), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Folder/{0}/follow", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildFollowDocument))]
        public IWorkflowAction FollowDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> recipients, [WorkflowExpression] Func<sendInput> send = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFollowDocument(WorkflowExpression<string> id, WorkflowExpression<string> recipients, WorkflowExpression<sendInput> send = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(recipients, nameof(recipients), required: true);
            WorkflowExpression.Validate(send, nameof(send), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/Document/follow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetCurrentUserInfo))]
        public IBodyWorkflowAction<GetCurrentUserInfoResponse> GetCurrentUserInfo([WorkflowExpression] Func<string> cabGuid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCurrentUserInfoResponse> __BuildGetCurrentUserInfo(WorkflowExpression<string> cabGuid = null)
        {
            WorkflowExpression.Validate(cabGuid, nameof(cabGuid), required: false);
            return new DeferredBodyAction<GetCurrentUserInfoResponse>(() =>
            {
                var apiCallPath = "/v1/User/info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cabGuid != null)
                    callPayload.Queries["cabGuid"] = ExpressionConverter.Convert(cabGuid);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetCurrentUserInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildCheckinDoc))]
        public IWorkflowAction CheckinDoc([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> extension = null, [WorkflowExpression] Func<object> file = null, [WorkflowExpression] Func<bool> addToRecent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCheckinDoc(WorkflowExpression<string> id, WorkflowExpression<string> extension = null, WorkflowExpression<object> file = null, WorkflowExpression<bool> addToRecent = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(extension, nameof(extension), required: false);
            WorkflowExpression.Validate(file, nameof(file), required: false);
            WorkflowExpression.Validate(addToRecent, nameof(addToRecent), required: false);
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
        [WorkflowExpressionFactory(nameof(__BuildCheckOutDoc))]
        public IWorkflowAction CheckOutDoc([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> comment = null, [WorkflowExpression] Func<bool> download = null, [WorkflowExpression] Func<string> version = null, [WorkflowExpression] Func<bool> addToRecent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCheckOutDoc(WorkflowExpression<string> id, WorkflowExpression<string> comment = null, WorkflowExpression<bool> download = null, WorkflowExpression<string> version = null, WorkflowExpression<bool> addToRecent = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(comment, nameof(comment), required: false);
            WorkflowExpression.Validate(download, nameof(download), required: false);
            WorkflowExpression.Validate(version, nameof(version), required: false);
            WorkflowExpression.Validate(addToRecent, nameof(addToRecent), required: false);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateDocument))]
        public IBodyWorkflowAction<CreateDocumentResponse> CreateDocument([WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<object> file, [WorkflowExpression] Func<bool> addToRecent = null, [WorkflowExpression] Func<string> profile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateDocumentResponse> __BuildCreateDocument(WorkflowExpression<string> destination, WorkflowExpression<object> file, WorkflowExpression<bool> addToRecent = null, WorkflowExpression<string> profile = null)
        {
            WorkflowExpression.Validate(destination, nameof(destination), required: true);
            WorkflowExpression.Validate(file, nameof(file), required: true);
            WorkflowExpression.Validate(addToRecent, nameof(addToRecent), required: false);
            WorkflowExpression.Validate(profile, nameof(profile), required: false);
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
        [WorkflowExpressionFactory(nameof(__BuildLockDocumentVersion))]
        public IWorkflowAction LockDocumentVersion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> version, [WorkflowExpression] Func<string> description = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLockDocumentVersion(WorkflowExpression<string> id, WorkflowExpression<int> version, WorkflowExpression<string> description = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(description, nameof(description), required: false);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentVersions))]
        public IWorkflowAction GetDocumentVersions([WorkflowExpression] Func<string> documentID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDocumentVersions(WorkflowExpression<string> documentID)
        {
            WorkflowExpression.Validate(documentID, nameof(documentID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}/versionList", ExpressionConverter.ConvertWithUrlEncoding(documentID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSecuredLink))]
        public IBodyWorkflowAction<CreateSecuredLinkResponse> CreateSecuredLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> password = null, [WorkflowExpression] Func<string> expirationdate = null, [WorkflowExpression] Func<string> version = null, [WorkflowExpression] Func<bool> download = null, [WorkflowExpression] Func<bool> notifyme = null, [WorkflowExpression] Func<bool> @lock = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSecuredLinkResponse> __BuildCreateSecuredLink(WorkflowExpression<string> id, WorkflowExpression<string> password = null, WorkflowExpression<string> expirationdate = null, WorkflowExpression<string> version = null, WorkflowExpression<bool> download = null, WorkflowExpression<bool> notifyme = null, WorkflowExpression<bool> @lock = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(password, nameof(password), required: false);
            WorkflowExpression.Validate(expirationdate, nameof(expirationdate), required: false);
            WorkflowExpression.Validate(version, nameof(version), required: false);
            WorkflowExpression.Validate(download, nameof(download), required: false);
            WorkflowExpression.Validate(notifyme, nameof(notifyme), required: false);
            WorkflowExpression.Validate(@lock, nameof(@lock), required: false);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDocHistory))]
        public IWorkflowAction GetDocHistory([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDocHistory(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkspaceParentChild))]
        public IBodyWorkflowAction<CreateWorkspaceParentChildResponse> CreateWorkspaceParentChild([WorkflowExpression] Func<string> cabinetID, [WorkflowExpression] Func<string> parentID, [WorkflowExpression] Func<string> childID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateWorkspaceParentChildResponse> __BuildCreateWorkspaceParentChild(WorkflowExpression<string> cabinetID, WorkflowExpression<string> parentID, WorkflowExpression<string> childID)
        {
            WorkflowExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            WorkflowExpression.Validate(parentID, nameof(parentID), required: true);
            WorkflowExpression.Validate(childID, nameof(childID), required: true);
            return new DeferredBodyAction<CreateWorkspaceParentChildResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Workspace/{0}/{1}/{2}/info", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1), ExpressionConverter.ConvertWithUrlEncoding(childID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CreateWorkspaceParentChildResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkspaceSingle))]
        public IBodyWorkflowAction<CreateWorkspaceSingleResponse> CreateWorkspaceSingle([WorkflowExpression] Func<string> cabinetID, [WorkflowExpression] Func<string> parentID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateWorkspaceSingleResponse> __BuildCreateWorkspaceSingle(WorkflowExpression<string> cabinetID, WorkflowExpression<string> parentID)
        {
            WorkflowExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            WorkflowExpression.Validate(parentID, nameof(parentID), required: true);
            return new DeferredBodyAction<CreateWorkspaceSingleResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Workspace/{0}/{1}/info", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<CreateWorkspaceSingleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetWorkspaceInformation))]
        public IWorkflowAction GetWorkspaceInformation([WorkflowExpression] Func<string> workspaceID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetWorkspaceInformation(WorkflowExpression<string> workspaceID)
        {
            WorkflowExpression.Validate(workspaceID, nameof(workspaceID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Workspace/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildCreateChildEntry))]
        public IBodyWorkflowAction<CreateChildEntryResponse> CreateChildEntry([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> childAttributeID, [WorkflowExpression] Func<string> parentID, [WorkflowExpression] Func<string> childID, [WorkflowExpression] Func<bool> lookupEntryBodyaccessfilteredPermissions, [WorkflowExpression] Func<bool> lookupEntryBodyaccessforcePermssions, [WorkflowExpression] Func<string> lookupEntryBodydescription = null, [WorkflowExpression] Func<string> lookupEntryBodytype = null, [WorkflowExpression] Func<bool> lookupEntryBodylitigationHold = null, [WorkflowExpression] Func<string> lookupEntryBodyclosedDate = null, [WorkflowExpression] Func<lookupEntryBodyaccesspermissionsInputItem[]> lookupEntryBodyaccesspermissions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateChildEntryResponse> __BuildCreateChildEntry(WorkflowExpression<string> repositoryID, WorkflowExpression<string> childAttributeID, WorkflowExpression<string> parentID, WorkflowExpression<string> childID, WorkflowExpression<bool> lookupEntryBodyaccessfilteredPermissions, WorkflowExpression<bool> lookupEntryBodyaccessforcePermssions, WorkflowExpression<string> lookupEntryBodydescription = null, WorkflowExpression<string> lookupEntryBodytype = null, WorkflowExpression<bool> lookupEntryBodylitigationHold = null, WorkflowExpression<string> lookupEntryBodyclosedDate = null, WorkflowExpression<lookupEntryBodyaccesspermissionsInputItem[]> lookupEntryBodyaccesspermissions = null)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowExpression.Validate(childAttributeID, nameof(childAttributeID), required: true);
            WorkflowExpression.Validate(parentID, nameof(parentID), required: true);
            WorkflowExpression.Validate(childID, nameof(childID), required: true);
            WorkflowExpression.Validate(lookupEntryBodyaccessfilteredPermissions, nameof(lookupEntryBodyaccessfilteredPermissions), required: true);
            WorkflowExpression.Validate(lookupEntryBodyaccessforcePermssions, nameof(lookupEntryBodyaccessforcePermssions), required: true);
            WorkflowExpression.Validate(lookupEntryBodydescription, nameof(lookupEntryBodydescription), required: false);
            WorkflowExpression.Validate(lookupEntryBodytype, nameof(lookupEntryBodytype), required: false);
            WorkflowExpression.Validate(lookupEntryBodylitigationHold, nameof(lookupEntryBodylitigationHold), required: false);
            WorkflowExpression.Validate(lookupEntryBodyclosedDate, nameof(lookupEntryBodyclosedDate), required: false);
            WorkflowExpression.Validate(lookupEntryBodyaccesspermissions, nameof(lookupEntryBodyaccesspermissions), required: false);
            return new DeferredBodyAction<CreateChildEntryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(childAttributeID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1), ExpressionConverter.ConvertWithUrlEncoding(childID, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var lookupEntryBody = new JObject();
                var lookupEntryBodypropCount = 0;
                if (lookupEntryBodydescription != null)
                {
                    lookupEntryBody["description"] = ExpressionConverter.ConvertO(lookupEntryBodydescription);
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodytype != null)
                {
                    lookupEntryBody["defaulting"] = ExpressionConverter.ConvertO(lookupEntryBodytype);
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodylitigationHold != null)
                {
                    lookupEntryBody["hold"] = ExpressionConverter.ConvertO(lookupEntryBodylitigationHold);
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodyclosedDate != null)
                {
                    lookupEntryBody["closed"] = ExpressionConverter.ConvertO(lookupEntryBodyclosedDate);
                    lookupEntryBodypropCount++;
                }

                var accessObject = new JObject();
                var accessObjectpropCount = 0;
                accessObjectpropCount++;
                accessObject["filtered_permissions"] = ExpressionConverter.ConvertO(lookupEntryBodyaccessfilteredPermissions);
                accessObjectpropCount++;
                accessObject["force_permissions"] = ExpressionConverter.ConvertO(lookupEntryBodyaccessforcePermssions);
                if (lookupEntryBodyaccesspermissions != null)
                {
                    accessObject["permissions"] = ExpressionConverter.ConvertO(lookupEntryBodyaccesspermissions);
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
        [WorkflowExpressionFactory(nameof(__BuildGetChildEntry))]
        public IWorkflowAction GetChildEntry([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> childAttributeID, [WorkflowExpression] Func<string> parentID, [WorkflowExpression] Func<string> childID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetChildEntry(WorkflowExpression<string> repositoryID, WorkflowExpression<string> childAttributeID, WorkflowExpression<string> parentID, WorkflowExpression<string> childID)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowExpression.Validate(childAttributeID, nameof(childAttributeID), required: true);
            WorkflowExpression.Validate(parentID, nameof(parentID), required: true);
            WorkflowExpression.Validate(childID, nameof(childID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(childAttributeID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1), ExpressionConverter.ConvertWithUrlEncoding(childID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteChildEntry))]
        public IBodyWorkflowAction<DeleteChildEntryResponse> DeleteChildEntry([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> childAttributeID, [WorkflowExpression] Func<string> parentID, [WorkflowExpression] Func<string> childID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteChildEntryResponse> __BuildDeleteChildEntry(WorkflowExpression<string> repositoryID, WorkflowExpression<string> childAttributeID, WorkflowExpression<string> parentID, WorkflowExpression<string> childID)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowExpression.Validate(childAttributeID, nameof(childAttributeID), required: true);
            WorkflowExpression.Validate(parentID, nameof(parentID), required: true);
            WorkflowExpression.Validate(childID, nameof(childID), required: true);
            return new DeferredBodyAction<DeleteChildEntryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(childAttributeID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1), ExpressionConverter.ConvertWithUrlEncoding(childID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<DeleteChildEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildCreateEntry))]
        public IBodyWorkflowAction<CreateEntryResponse> CreateEntry([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> attributeID, [WorkflowExpression] Func<string> parentID, [WorkflowExpression] Func<bool> lookupEntryBodyaccessfilteredPermissions, [WorkflowExpression] Func<bool> lookupEntryBodyaccessforcePermssions, [WorkflowExpression] Func<string> lookupEntryBodydescription = null, [WorkflowExpression] Func<string> lookupEntryBodytype = null, [WorkflowExpression] Func<bool> lookupEntryBodylitigationHold = null, [WorkflowExpression] Func<string> lookupEntryBodyclosedDate = null, [WorkflowExpression] Func<lookupEntryBodyaccesspermissionsInputItem[]> lookupEntryBodyaccesspermissions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateEntryResponse> __BuildCreateEntry(WorkflowExpression<string> repositoryID, WorkflowExpression<string> attributeID, WorkflowExpression<string> parentID, WorkflowExpression<bool> lookupEntryBodyaccessfilteredPermissions, WorkflowExpression<bool> lookupEntryBodyaccessforcePermssions, WorkflowExpression<string> lookupEntryBodydescription = null, WorkflowExpression<string> lookupEntryBodytype = null, WorkflowExpression<bool> lookupEntryBodylitigationHold = null, WorkflowExpression<string> lookupEntryBodyclosedDate = null, WorkflowExpression<lookupEntryBodyaccesspermissionsInputItem[]> lookupEntryBodyaccesspermissions = null)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowExpression.Validate(attributeID, nameof(attributeID), required: true);
            WorkflowExpression.Validate(parentID, nameof(parentID), required: true);
            WorkflowExpression.Validate(lookupEntryBodyaccessfilteredPermissions, nameof(lookupEntryBodyaccessfilteredPermissions), required: true);
            WorkflowExpression.Validate(lookupEntryBodyaccessforcePermssions, nameof(lookupEntryBodyaccessforcePermssions), required: true);
            WorkflowExpression.Validate(lookupEntryBodydescription, nameof(lookupEntryBodydescription), required: false);
            WorkflowExpression.Validate(lookupEntryBodytype, nameof(lookupEntryBodytype), required: false);
            WorkflowExpression.Validate(lookupEntryBodylitigationHold, nameof(lookupEntryBodylitigationHold), required: false);
            WorkflowExpression.Validate(lookupEntryBodyclosedDate, nameof(lookupEntryBodyclosedDate), required: false);
            WorkflowExpression.Validate(lookupEntryBodyaccesspermissions, nameof(lookupEntryBodyaccesspermissions), required: false);
            return new DeferredBodyAction<CreateEntryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(attributeID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var lookupEntryBody = new JObject();
                var lookupEntryBodypropCount = 0;
                if (lookupEntryBodydescription != null)
                {
                    lookupEntryBody["description"] = ExpressionConverter.ConvertO(lookupEntryBodydescription);
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodytype != null)
                {
                    lookupEntryBody["defaulting"] = ExpressionConverter.ConvertO(lookupEntryBodytype);
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodylitigationHold != null)
                {
                    lookupEntryBody["hold"] = ExpressionConverter.ConvertO(lookupEntryBodylitigationHold);
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodyclosedDate != null)
                {
                    lookupEntryBody["closed"] = ExpressionConverter.ConvertO(lookupEntryBodyclosedDate);
                    lookupEntryBodypropCount++;
                }

                var accessObject = new JObject();
                var accessObjectpropCount = 0;
                accessObjectpropCount++;
                accessObject["filtered_permissions"] = ExpressionConverter.ConvertO(lookupEntryBodyaccessfilteredPermissions);
                accessObjectpropCount++;
                accessObject["force_permissions"] = ExpressionConverter.ConvertO(lookupEntryBodyaccessforcePermssions);
                if (lookupEntryBodyaccesspermissions != null)
                {
                    accessObject["permissions"] = ExpressionConverter.ConvertO(lookupEntryBodyaccesspermissions);
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
        [WorkflowExpressionFactory(nameof(__BuildGetLookupEntry))]
        public IWorkflowAction GetLookupEntry([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> attributeID, [WorkflowExpression] Func<string> parentID, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<orderbyInput> orderby = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetLookupEntry(WorkflowExpression<string> repositoryID, WorkflowExpression<string> attributeID, WorkflowExpression<string> parentID, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<int> skip = null, WorkflowExpression<int> top = null, WorkflowExpression<orderbyInput> orderby = null)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowExpression.Validate(attributeID, nameof(attributeID), required: true);
            WorkflowExpression.Validate(parentID, nameof(parentID), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(attributeID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["$orderby"] = Convert.ToString("key");
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteLookupEntry))]
        public IBodyWorkflowAction<DeleteLookupEntryResponse> DeleteLookupEntry([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> attributeID, [WorkflowExpression] Func<string> parentID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteLookupEntryResponse> __BuildDeleteLookupEntry(WorkflowExpression<string> repositoryID, WorkflowExpression<string> attributeID, WorkflowExpression<string> parentID)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowExpression.Validate(attributeID, nameof(attributeID), required: true);
            WorkflowExpression.Validate(parentID, nameof(parentID), required: true);
            return new DeferredBodyAction<DeleteLookupEntryResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(attributeID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<DeleteLookupEntryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildSearchLookupEntries))]
        public IBodyWorkflowAction<SearchLookupEntriesResponse> SearchLookupEntries([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> attributeID, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchLookupEntriesResponse> __BuildSearchLookupEntries(WorkflowExpression<string> repositoryID, WorkflowExpression<string> attributeID, WorkflowExpression<string> filter = null, WorkflowExpression<string> select = null, WorkflowExpression<int> skip = null, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowExpression.Validate(attributeID, nameof(attributeID), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<SearchLookupEntriesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(attributeID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["$orderby"] = Convert.ToString("key");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<SearchLookupEntriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildSearchCabinets))]
        public IWorkflowAction SearchCabinets([WorkflowExpression] Func<string> cabinets, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> select, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> skiptoken = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSearchCabinets(WorkflowExpression<string> cabinets, WorkflowExpression<string> q, WorkflowExpression<string> select, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null, WorkflowExpression<string> skiptoken = null)
        {
            WorkflowExpression.Validate(cabinets, nameof(cabinets), required: true);
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: true);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/Search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cabinets"] = ExpressionConverter.Convert(cabinets);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
                if (skiptoken != null)
                    callPayload.Queries["skiptoken"] = ExpressionConverter.Convert(skiptoken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildRefreshWorkspace))]
        public IWorkflowAction RefreshWorkspace([WorkflowExpression] Func<string> workspaceID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRefreshWorkspace(WorkflowExpression<string> workspaceID)
        {
            WorkflowExpression.Validate(workspaceID, nameof(workspaceID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Workspace/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildLockDocument))]
        public IWorkflowAction LockDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> comment = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLockDocument(WorkflowExpression<string> id, WorkflowExpression<string> comment = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(comment, nameof(comment), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/document/{0}/lock", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (comment != null)
                    callPayload.Queries["comment"] = ExpressionConverter.Convert(comment);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildUnockDocument))]
        public IWorkflowAction UnockDocument([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUnockDocument(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/document/{0}/unlock", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetRepositoryLog))]
        public IWorkflowAction GetRepositoryLog([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<logtypeInput> logtype, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetRepositoryLog(WorkflowExpression<string> repositoryID, WorkflowExpression<logtypeInput> logtype, WorkflowExpression<string> start = null, WorkflowExpression<string> end = null)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowExpression.Validate(logtype, nameof(logtype), required: true);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/log", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                callPayload.Queries["Logtype"] = ExpressionConverter.Convert(logtype);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetRepositoryInformation))]
        public IWorkflowAction GetRepositoryInformation([WorkflowExpression] Func<string> repositoryID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetRepositoryInformation(WorkflowExpression<string> repositoryID)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetRepositoryUsers))]
        public IBodyWorkflowAction<GetRepositoryUsersResponseItem[]> GetRepositoryUsers([WorkflowExpression] Func<string> repositoryID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRepositoryUsersResponseItem[]> __BuildGetRepositoryUsers(WorkflowExpression<string> repositoryID)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            return new DeferredBodyAction<GetRepositoryUsersResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetRepositoryUsersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetRepositoryGroups))]
        public IBodyWorkflowAction<string[]> GetRepositoryGroups([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> top = null, [WorkflowExpression] Func<bool> paging = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<returnInfoInput> returnInfo = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildGetRepositoryGroups(WorkflowExpression<string> repositoryID, WorkflowExpression<string> filter = null, WorkflowExpression<string> top = null, WorkflowExpression<bool> paging = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<returnInfoInput> returnInfo = null)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(paging, nameof(paging), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(returnInfo, nameof(returnInfo), required: false);
            return new DeferredBodyAction<string[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/groups", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                callPayload.Queries["paging"] = Convert.ToString(false);
                if (paging != null)
                    callPayload.Queries["paging"] = ExpressionConverter.Convert(paging);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                callPayload.Queries["returnInfo"] = Convert.ToString("");
                if (returnInfo != null)
                    callPayload.Queries["returnInfo"] = ExpressionConverter.Convert(returnInfo);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRepositoryGroup))]
        public IBodyWorkflowAction<CreateRepositoryGroupResponse> CreateRepositoryGroup([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<bool> external, [WorkflowExpression] Func<bool> hidden, [WorkflowExpression] Func<bool> hideMembership)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateRepositoryGroupResponse> __BuildCreateRepositoryGroup(WorkflowExpression<string> repositoryID, WorkflowExpression<string> name, WorkflowExpression<bool> external, WorkflowExpression<bool> hidden, WorkflowExpression<bool> hideMembership)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(external, nameof(external), required: true);
            WorkflowExpression.Validate(hidden, nameof(hidden), required: true);
            WorkflowExpression.Validate(hideMembership, nameof(hideMembership), required: true);
            return new DeferredBodyAction<CreateRepositoryGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/group", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction<CreateRepositoryGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteRepositoryGroup))]
        public IWorkflowAction DeleteRepositoryGroup([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> groupID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteRepositoryGroup(WorkflowExpression<string> repositoryID, WorkflowExpression<string> groupID)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowExpression.Validate(groupID, nameof(groupID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/group/{1}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildCreateUser))]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> displayFirstName, [WorkflowExpression] Func<string> displayLastName, [WorkflowExpression] Func<string> email, [WorkflowExpression] Func<bool> external, [WorkflowExpression] Func<bool> sendWelcome, [WorkflowExpression] Func<string> repository, [WorkflowExpression] Func<string> displayMiddleName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateUserResponse> __BuildCreateUser(WorkflowExpression<string> username, WorkflowExpression<string> displayFirstName, WorkflowExpression<string> displayLastName, WorkflowExpression<string> email, WorkflowExpression<bool> external, WorkflowExpression<bool> sendWelcome, WorkflowExpression<string> repository, WorkflowExpression<string> displayMiddleName = null)
        {
            WorkflowExpression.Validate(username, nameof(username), required: true);
            WorkflowExpression.Validate(displayFirstName, nameof(displayFirstName), required: true);
            WorkflowExpression.Validate(displayLastName, nameof(displayLastName), required: true);
            WorkflowExpression.Validate(email, nameof(email), required: true);
            WorkflowExpression.Validate(external, nameof(external), required: true);
            WorkflowExpression.Validate(sendWelcome, nameof(sendWelcome), required: true);
            WorkflowExpression.Validate(repository, nameof(repository), required: true);
            WorkflowExpression.Validate(displayMiddleName, nameof(displayMiddleName), required: false);
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
        [WorkflowExpressionFactory(nameof(__BuildAddOrRemoveUserRepository))]
        public IWorkflowAction AddOrRemoveUserRepository([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<actionInput> action, [WorkflowExpression] Func<string> member, [WorkflowExpression] Func<bool> external, [WorkflowExpression] Func<bool> deleteIfFederated = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddOrRemoveUserRepository(WorkflowExpression<string> repositoryID, WorkflowExpression<actionInput> action, WorkflowExpression<string> member, WorkflowExpression<bool> external, WorkflowExpression<bool> deleteIfFederated = null)
        {
            WorkflowExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowExpression.Validate(action, nameof(action), required: true);
            WorkflowExpression.Validate(member, nameof(member), required: true);
            WorkflowExpression.Validate(external, nameof(external), required: true);
            WorkflowExpression.Validate(deleteIfFederated, nameof(deleteIfFederated), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCollabSpace))]
        public IBodyWorkflowAction<CreateCollabSpaceResponse> CreateCollabSpace([WorkflowExpression] Func<string> workspaceID, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> description = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCollabSpaceResponse> __BuildCreateCollabSpace(WorkflowExpression<string> workspaceID, WorkflowExpression<string> name, WorkflowExpression<string> description = null)
        {
            WorkflowExpression.Validate(workspaceID, nameof(workspaceID), required: true);
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(description, nameof(description), required: false);
            return new DeferredBodyAction<CreateCollabSpaceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/container/{0}/collabspace", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction<CreateCollabSpaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetCabinetSettings))]
        public IWorkflowAction GetCabinetSettings([WorkflowExpression] Func<string> cabinetID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetCabinetSettings(WorkflowExpression<string> cabinetID)
        {
            WorkflowExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/settings", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetCabinetInformation))]
        public IWorkflowAction GetCabinetInformation([WorkflowExpression] Func<string> cabinetID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetCabinetInformation(WorkflowExpression<string> cabinetID)
        {
            WorkflowExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetCabinetCustomAttributes))]
        public IBodyWorkflowAction<JToken[]> GetCabinetCustomAttributes([WorkflowExpression] Func<string> cabinetID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildGetCabinetCustomAttributes(WorkflowExpression<string> cabinetID)
        {
            WorkflowExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/customAttributes", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetCabinetDefaultAccess))]
        public IBodyWorkflowAction<GetCabinetDefaultAccessResponseItem[]> GetCabinetDefaultAccess([WorkflowExpression] Func<string> cabinetID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCabinetDefaultAccessResponseItem[]> __BuildGetCabinetDefaultAccess(WorkflowExpression<string> cabinetID)
        {
            WorkflowExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            return new DeferredBodyAction<GetCabinetDefaultAccessResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/membership", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetCabinetDefaultAccessResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildAddToOrRemoveGroupFromCabinet))]
        public IWorkflowAction AddToOrRemoveGroupFromCabinet([WorkflowExpression] Func<string> cabinetID, [WorkflowExpression] Func<actionInput> action, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> view, [WorkflowExpression] Func<bool> edit, [WorkflowExpression] Func<bool> share, [WorkflowExpression] Func<bool> administer, [WorkflowExpression] Func<bool> noAccess)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddToOrRemoveGroupFromCabinet(WorkflowExpression<string> cabinetID, WorkflowExpression<actionInput> action, WorkflowExpression<string> id, WorkflowExpression<bool> view, WorkflowExpression<bool> edit, WorkflowExpression<bool> share, WorkflowExpression<bool> administer, WorkflowExpression<bool> noAccess)
        {
            WorkflowExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            WorkflowExpression.Validate(action, nameof(action), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(view, nameof(view), required: true);
            WorkflowExpression.Validate(edit, nameof(edit), required: true);
            WorkflowExpression.Validate(share, nameof(share), required: true);
            WorkflowExpression.Validate(administer, nameof(administer), required: true);
            WorkflowExpression.Validate(noAccess, nameof(noAccess), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/membership", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetCabinetGroups))]
        public IBodyWorkflowAction<GetCabinetGroupsResponseItem[]> GetCabinetGroups([WorkflowExpression] Func<string> cabinetID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCabinetGroupsResponseItem[]> __BuildGetCabinetGroups(WorkflowExpression<string> cabinetID)
        {
            WorkflowExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            return new DeferredBodyAction<GetCabinetGroupsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/cabinet/{0}/groups", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetCabinetGroupsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCabinetExternalGroup))]
        public IBodyWorkflowAction<CreateCabinetExternalGroupResponse> CreateCabinetExternalGroup([WorkflowExpression] Func<string> cabinetID, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<optionsInput> options = null, [WorkflowExpression] Func<accessInput> access = null, [WorkflowExpression] Func<string> collaborationSpaceId = null, [WorkflowExpression] Func<collaborationspaceaccessInput> collaborationspaceaccess = null, [WorkflowExpression] Func<string> topwsattributegroupkey = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCabinetExternalGroupResponse> __BuildCreateCabinetExternalGroup(WorkflowExpression<string> cabinetID, WorkflowExpression<string> name, WorkflowExpression<optionsInput> options = null, WorkflowExpression<accessInput> access = null, WorkflowExpression<string> collaborationSpaceId = null, WorkflowExpression<collaborationspaceaccessInput> collaborationspaceaccess = null, WorkflowExpression<string> topwsattributegroupkey = null)
        {
            WorkflowExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(options, nameof(options), required: false);
            WorkflowExpression.Validate(access, nameof(access), required: false);
            WorkflowExpression.Validate(collaborationSpaceId, nameof(collaborationSpaceId), required: false);
            WorkflowExpression.Validate(collaborationspaceaccess, nameof(collaborationspaceaccess), required: false);
            WorkflowExpression.Validate(topwsattributegroupkey, nameof(topwsattributegroupkey), required: false);
            return new DeferredBodyAction<CreateCabinetExternalGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/cabinet/{0}/group/external", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction<CreateCabinetExternalGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildSearchCabinetModifyACLs))]
        public IWorkflowAction SearchCabinetModifyACLs([WorkflowExpression] Func<string> cabinetID, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<modeInput> mode, [WorkflowExpression] Func<string> newAcl, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<completionEmailInput> completionEmail = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSearchCabinetModifyACLs(WorkflowExpression<string> cabinetID, WorkflowExpression<string> q, WorkflowExpression<modeInput> mode, WorkflowExpression<string> newAcl, WorkflowExpression<string> email = null, WorkflowExpression<completionEmailInput> completionEmail = null)
        {
            WorkflowExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(mode, nameof(mode), required: true);
            WorkflowExpression.Validate(newAcl, nameof(newAcl), required: true);
            WorkflowExpression.Validate(email, nameof(email), required: false);
            WorkflowExpression.Validate(completionEmail, nameof(completionEmail), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Search/{0}", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetContainerContents))]
        public IWorkflowAction GetContainerContents([WorkflowExpression] Func<string> containerID, [WorkflowExpression] Func<string> select, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<string> orderby = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetContainerContents(WorkflowExpression<string> containerID, WorkflowExpression<string> select, WorkflowExpression<int> top = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<string> orderby = null)
        {
            WorkflowExpression.Validate(containerID, nameof(containerID), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: true);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/container/{0}", ExpressionConverter.ConvertWithUrlEncoding(containerID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["select"] = ExpressionConverter.Convert(select);
                if (top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(top);
                if (skiptoken != null)
                    callPayload.Queries["skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (orderby != null)
                    callPayload.Queries["orderby"] = ExpressionConverter.Convert(orderby);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetGroupInformation))]
        public IBodyWorkflowAction<GetGroupInformationResponse> GetGroupInformation([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<bool> cabMembership = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGroupInformationResponse> __BuildGetGroupInformation(WorkflowExpression<string> groupID, WorkflowExpression<bool> cabMembership = null)
        {
            WorkflowExpression.Validate(groupID, nameof(groupID), required: true);
            WorkflowExpression.Validate(cabMembership, nameof(cabMembership), required: false);
            return new DeferredBodyAction<GetGroupInformationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Group/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cabMembership"] = Convert.ToString(false);
                if (cabMembership != null)
                    callPayload.Queries["cabMembership"] = ExpressionConverter.Convert(cabMembership);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetGroupInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildGetGroupMembership))]
        public IBodyWorkflowAction<GetGroupMembershipResponseItem[]> GetGroupMembership([WorkflowExpression] Func<string> groupID)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGroupMembershipResponseItem[]> __BuildGetGroupMembership(WorkflowExpression<string> groupID)
        {
            WorkflowExpression.Validate(groupID, nameof(groupID), required: true);
            return new DeferredBodyAction<GetGroupMembershipResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Group/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetGroupMembershipResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [WorkflowExpressionFactory(nameof(__BuildAddOrRemoveGroupMember))]
        public IWorkflowAction AddOrRemoveGroupMember([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<actionInput> action, [WorkflowExpression] Func<string> member)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddOrRemoveGroupMember(WorkflowExpression<string> groupID, WorkflowExpression<actionInput> action, WorkflowExpression<string> member)
        {
            WorkflowExpression.Validate(groupID, nameof(groupID), required: true);
            WorkflowExpression.Validate(action, nameof(action), required: true);
            WorkflowExpression.Validate(member, nameof(member), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Group/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
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

        [WorkflowExpressionFactory(nameof(__BuildSearchCab))]
        public IWorkflowTrigger SearchCab([WorkflowExpression] Func<string> cabId,[WorkflowExpression] Func<string> q,[WorkflowExpression] Func<orderbyInput> orderby = null,[WorkflowExpression] Func<string> top = null,[WorkflowExpression] Func<string> select = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildSearchCab(WorkflowExpression<string> cabId,WorkflowExpression<string> q,WorkflowExpression<orderbyInput> orderby = null,WorkflowExpression<string> top = null,WorkflowExpression<string> select = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(cabId, nameof(cabId), required: true);
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Search/{0}", ExpressionConverter.ConvertWithUrlEncoding(cabId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                callPayload.Queries["$orderby"] = Convert.ToString("relevance desc");
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
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