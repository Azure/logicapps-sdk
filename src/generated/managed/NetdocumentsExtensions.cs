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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUserInfoResponse> __BuildGetUserInfo(WorkflowValue<string> id, WorkflowValue<string> cabGuid = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(cabGuid, nameof(cabGuid), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NewVersionResponse> __BuildNewVersion(WorkflowValue<string> id, WorkflowValue<string> extension = null, WorkflowValue<string> versionDescription = null, WorkflowValue<string> verName = null, WorkflowValue<bool> official = null, WorkflowValue<bool> addToRecent = null, WorkflowValue<string> srcVer = null, WorkflowValue<bool> allocatesubversion = null, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(extension, nameof(extension), required: false);
            WorkflowValue.Validate(versionDescription, nameof(versionDescription), required: false);
            WorkflowValue.Validate(verName, nameof(verName), required: false);
            WorkflowValue.Validate(official, nameof(official), required: false);
            WorkflowValue.Validate(addToRecent, nameof(addToRecent), required: false);
            WorkflowValue.Validate(srcVer, nameof(srcVer), required: false);
            WorkflowValue.Validate(allocatesubversion, nameof(allocatesubversion), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDocInfo(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenameDocument(WorkflowValue<string> id, WorkflowValue<string> renameBodystandardAttributesnewName)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(renameBodystandardAttributesnewName, nameof(renameBodystandardAttributesnewName), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDocContent(WorkflowValue<string> id, WorkflowValue<bool> base64 = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(base64, nameof(base64), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteDoc(WorkflowValue<string> id, WorkflowValue<bool> permanent = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(permanent, nameof(permanent), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateDocument(WorkflowValue<string> id, WorkflowValue<string> extension = null, WorkflowValue<bool> base64 = null, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(extension, nameof(extension), required: false);
            WorkflowValue.Validate(base64, nameof(base64), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateFolderResponse> __BuildCreateFolder(WorkflowValue<string> name, WorkflowValue<string> parent = null, WorkflowValue<string> cabinet = null)
        {
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(parent, nameof(parent), required: false);
            WorkflowValue.Validate(cabinet, nameof(cabinet), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetFldContent(WorkflowValue<string> id, WorkflowValue<string> select = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(select, nameof(select), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFileFolder(WorkflowValue<string> id, WorkflowValue<string> item, WorkflowValue<actionInput> action)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(item, nameof(item), required: true);
            WorkflowValue.Validate(action, nameof(action), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteFolder(WorkflowValue<string> id, WorkflowValue<bool> permanent = null, WorkflowValue<bool> deleteContents = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(permanent, nameof(permanent), required: false);
            WorkflowValue.Validate(deleteContents, nameof(deleteContents), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRenameFolder(WorkflowValue<string> id, WorkflowValue<string> renameBodystandardAttributesnewName)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(renameBodystandardAttributesnewName, nameof(renameBodystandardAttributesnewName), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFollowFolder(WorkflowValue<string> id, WorkflowValue<string> recipients, WorkflowValue<sendInput> send = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(recipients, nameof(recipients), required: true);
            WorkflowValue.Validate(send, nameof(send), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFollowDocument(WorkflowValue<string> id, WorkflowValue<string> recipients, WorkflowValue<sendInput> send = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(recipients, nameof(recipients), required: true);
            WorkflowValue.Validate(send, nameof(send), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCurrentUserInfoResponse> __BuildGetCurrentUserInfo(WorkflowValue<string> cabGuid = null)
        {
            WorkflowValue.Validate(cabGuid, nameof(cabGuid), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCheckinDoc(WorkflowValue<string> id, WorkflowValue<string> extension = null, WorkflowValue<object> file = null, WorkflowValue<bool> addToRecent = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(extension, nameof(extension), required: false);
            WorkflowValue.Validate(file, nameof(file), required: false);
            WorkflowValue.Validate(addToRecent, nameof(addToRecent), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCheckOutDoc(WorkflowValue<string> id, WorkflowValue<string> comment = null, WorkflowValue<bool> download = null, WorkflowValue<string> version = null, WorkflowValue<bool> addToRecent = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(comment, nameof(comment), required: false);
            WorkflowValue.Validate(download, nameof(download), required: false);
            WorkflowValue.Validate(version, nameof(version), required: false);
            WorkflowValue.Validate(addToRecent, nameof(addToRecent), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateDocumentResponse> __BuildCreateDocument(WorkflowValue<string> destination, WorkflowValue<object> file, WorkflowValue<bool> addToRecent = null, WorkflowValue<string> profile = null)
        {
            WorkflowValue.Validate(destination, nameof(destination), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(addToRecent, nameof(addToRecent), required: false);
            WorkflowValue.Validate(profile, nameof(profile), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLockDocumentVersion(WorkflowValue<string> id, WorkflowValue<int> version, WorkflowValue<string> description = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(version, nameof(version), required: true);
            WorkflowValue.Validate(description, nameof(description), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDocumentVersions(WorkflowValue<string> documentID)
        {
            WorkflowValue.Validate(documentID, nameof(documentID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSecuredLinkResponse> __BuildCreateSecuredLink(WorkflowValue<string> id, WorkflowValue<string> password = null, WorkflowValue<string> expirationdate = null, WorkflowValue<string> version = null, WorkflowValue<bool> download = null, WorkflowValue<bool> notifyme = null, WorkflowValue<bool> @lock = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(password, nameof(password), required: false);
            WorkflowValue.Validate(expirationdate, nameof(expirationdate), required: false);
            WorkflowValue.Validate(version, nameof(version), required: false);
            WorkflowValue.Validate(download, nameof(download), required: false);
            WorkflowValue.Validate(notifyme, nameof(notifyme), required: false);
            WorkflowValue.Validate(@lock, nameof(@lock), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetDocHistory(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateWorkspaceParentChildResponse> __BuildCreateWorkspaceParentChild(WorkflowValue<string> cabinetID, WorkflowValue<string> parentID, WorkflowValue<string> childID)
        {
            WorkflowValue.Validate(cabinetID, nameof(cabinetID), required: true);
            WorkflowValue.Validate(parentID, nameof(parentID), required: true);
            WorkflowValue.Validate(childID, nameof(childID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateWorkspaceSingleResponse> __BuildCreateWorkspaceSingle(WorkflowValue<string> cabinetID, WorkflowValue<string> parentID)
        {
            WorkflowValue.Validate(cabinetID, nameof(cabinetID), required: true);
            WorkflowValue.Validate(parentID, nameof(parentID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetWorkspaceInformation(WorkflowValue<string> workspaceID)
        {
            WorkflowValue.Validate(workspaceID, nameof(workspaceID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateChildEntryResponse> __BuildCreateChildEntry(WorkflowValue<string> repositoryID, WorkflowValue<string> childAttributeID, WorkflowValue<string> parentID, WorkflowValue<string> childID, WorkflowValue<bool> lookupEntryBodyaccessfilteredPermissions, WorkflowValue<bool> lookupEntryBodyaccessforcePermssions, WorkflowValue<string> lookupEntryBodydescription = null, WorkflowValue<string> lookupEntryBodytype = null, WorkflowValue<bool> lookupEntryBodylitigationHold = null, WorkflowValue<string> lookupEntryBodyclosedDate = null, WorkflowValue<lookupEntryBodyaccesspermissionsInputItem[]> lookupEntryBodyaccesspermissions = null)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowValue.Validate(childAttributeID, nameof(childAttributeID), required: true);
            WorkflowValue.Validate(parentID, nameof(parentID), required: true);
            WorkflowValue.Validate(childID, nameof(childID), required: true);
            WorkflowValue.Validate(lookupEntryBodyaccessfilteredPermissions, nameof(lookupEntryBodyaccessfilteredPermissions), required: true);
            WorkflowValue.Validate(lookupEntryBodyaccessforcePermssions, nameof(lookupEntryBodyaccessforcePermssions), required: true);
            WorkflowValue.Validate(lookupEntryBodydescription, nameof(lookupEntryBodydescription), required: false);
            WorkflowValue.Validate(lookupEntryBodytype, nameof(lookupEntryBodytype), required: false);
            WorkflowValue.Validate(lookupEntryBodylitigationHold, nameof(lookupEntryBodylitigationHold), required: false);
            WorkflowValue.Validate(lookupEntryBodyclosedDate, nameof(lookupEntryBodyclosedDate), required: false);
            WorkflowValue.Validate(lookupEntryBodyaccesspermissions, nameof(lookupEntryBodyaccesspermissions), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetChildEntry(WorkflowValue<string> repositoryID, WorkflowValue<string> childAttributeID, WorkflowValue<string> parentID, WorkflowValue<string> childID)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowValue.Validate(childAttributeID, nameof(childAttributeID), required: true);
            WorkflowValue.Validate(parentID, nameof(parentID), required: true);
            WorkflowValue.Validate(childID, nameof(childID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteChildEntryResponse> __BuildDeleteChildEntry(WorkflowValue<string> repositoryID, WorkflowValue<string> childAttributeID, WorkflowValue<string> parentID, WorkflowValue<string> childID)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowValue.Validate(childAttributeID, nameof(childAttributeID), required: true);
            WorkflowValue.Validate(parentID, nameof(parentID), required: true);
            WorkflowValue.Validate(childID, nameof(childID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateEntryResponse> __BuildCreateEntry(WorkflowValue<string> repositoryID, WorkflowValue<string> attributeID, WorkflowValue<string> parentID, WorkflowValue<bool> lookupEntryBodyaccessfilteredPermissions, WorkflowValue<bool> lookupEntryBodyaccessforcePermssions, WorkflowValue<string> lookupEntryBodydescription = null, WorkflowValue<string> lookupEntryBodytype = null, WorkflowValue<bool> lookupEntryBodylitigationHold = null, WorkflowValue<string> lookupEntryBodyclosedDate = null, WorkflowValue<lookupEntryBodyaccesspermissionsInputItem[]> lookupEntryBodyaccesspermissions = null)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowValue.Validate(attributeID, nameof(attributeID), required: true);
            WorkflowValue.Validate(parentID, nameof(parentID), required: true);
            WorkflowValue.Validate(lookupEntryBodyaccessfilteredPermissions, nameof(lookupEntryBodyaccessfilteredPermissions), required: true);
            WorkflowValue.Validate(lookupEntryBodyaccessforcePermssions, nameof(lookupEntryBodyaccessforcePermssions), required: true);
            WorkflowValue.Validate(lookupEntryBodydescription, nameof(lookupEntryBodydescription), required: false);
            WorkflowValue.Validate(lookupEntryBodytype, nameof(lookupEntryBodytype), required: false);
            WorkflowValue.Validate(lookupEntryBodylitigationHold, nameof(lookupEntryBodylitigationHold), required: false);
            WorkflowValue.Validate(lookupEntryBodyclosedDate, nameof(lookupEntryBodyclosedDate), required: false);
            WorkflowValue.Validate(lookupEntryBodyaccesspermissions, nameof(lookupEntryBodyaccesspermissions), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetLookupEntry(WorkflowValue<string> repositoryID, WorkflowValue<string> attributeID, WorkflowValue<string> parentID, WorkflowValue<string> filter = null, WorkflowValue<string> select = null, WorkflowValue<int> skip = null, WorkflowValue<int> top = null, WorkflowValue<orderbyInput> orderby = null)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowValue.Validate(attributeID, nameof(attributeID), required: true);
            WorkflowValue.Validate(parentID, nameof(parentID), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteLookupEntryResponse> __BuildDeleteLookupEntry(WorkflowValue<string> repositoryID, WorkflowValue<string> attributeID, WorkflowValue<string> parentID)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowValue.Validate(attributeID, nameof(attributeID), required: true);
            WorkflowValue.Validate(parentID, nameof(parentID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchLookupEntriesResponse> __BuildSearchLookupEntries(WorkflowValue<string> repositoryID, WorkflowValue<string> attributeID, WorkflowValue<string> filter = null, WorkflowValue<string> select = null, WorkflowValue<int> skip = null, WorkflowValue<int> top = null)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowValue.Validate(attributeID, nameof(attributeID), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSearchCabinets(WorkflowValue<string> cabinets, WorkflowValue<string> q, WorkflowValue<string> select, WorkflowValue<string> orderby = null, WorkflowValue<int> top = null, WorkflowValue<int> skip = null, WorkflowValue<string> skiptoken = null)
        {
            WorkflowValue.Validate(cabinets, nameof(cabinets), required: true);
            WorkflowValue.Validate(q, nameof(q), required: true);
            WorkflowValue.Validate(select, nameof(select), required: true);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(skiptoken, nameof(skiptoken), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRefreshWorkspace(WorkflowValue<string> workspaceID)
        {
            WorkflowValue.Validate(workspaceID, nameof(workspaceID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildLockDocument(WorkflowValue<string> id, WorkflowValue<string> comment = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(comment, nameof(comment), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUnockDocument(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetRepositoryLog(WorkflowValue<string> repositoryID, WorkflowValue<logtypeInput> logtype, WorkflowValue<string> start = null, WorkflowValue<string> end = null)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowValue.Validate(logtype, nameof(logtype), required: true);
            WorkflowValue.Validate(start, nameof(start), required: false);
            WorkflowValue.Validate(end, nameof(end), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetRepositoryInformation(WorkflowValue<string> repositoryID)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRepositoryUsersResponseItem[]> __BuildGetRepositoryUsers(WorkflowValue<string> repositoryID)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string[]> __BuildGetRepositoryGroups(WorkflowValue<string> repositoryID, WorkflowValue<string> filter = null, WorkflowValue<string> top = null, WorkflowValue<bool> paging = null, WorkflowValue<string> skiptoken = null, WorkflowValue<returnInfoInput> returnInfo = null)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(paging, nameof(paging), required: false);
            WorkflowValue.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowValue.Validate(returnInfo, nameof(returnInfo), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateRepositoryGroupResponse> __BuildCreateRepositoryGroup(WorkflowValue<string> repositoryID, WorkflowValue<string> name, WorkflowValue<bool> external, WorkflowValue<bool> hidden, WorkflowValue<bool> hideMembership)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(external, nameof(external), required: true);
            WorkflowValue.Validate(hidden, nameof(hidden), required: true);
            WorkflowValue.Validate(hideMembership, nameof(hideMembership), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteRepositoryGroup(WorkflowValue<string> repositoryID, WorkflowValue<string> groupID)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateUserResponse> __BuildCreateUser(WorkflowValue<string> username, WorkflowValue<string> displayFirstName, WorkflowValue<string> displayLastName, WorkflowValue<string> email, WorkflowValue<bool> external, WorkflowValue<bool> sendWelcome, WorkflowValue<string> repository, WorkflowValue<string> displayMiddleName = null)
        {
            WorkflowValue.Validate(username, nameof(username), required: true);
            WorkflowValue.Validate(displayFirstName, nameof(displayFirstName), required: true);
            WorkflowValue.Validate(displayLastName, nameof(displayLastName), required: true);
            WorkflowValue.Validate(email, nameof(email), required: true);
            WorkflowValue.Validate(external, nameof(external), required: true);
            WorkflowValue.Validate(sendWelcome, nameof(sendWelcome), required: true);
            WorkflowValue.Validate(repository, nameof(repository), required: true);
            WorkflowValue.Validate(displayMiddleName, nameof(displayMiddleName), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddOrRemoveUserRepository(WorkflowValue<string> repositoryID, WorkflowValue<actionInput> action, WorkflowValue<string> member, WorkflowValue<bool> external, WorkflowValue<bool> deleteIfFederated = null)
        {
            WorkflowValue.Validate(repositoryID, nameof(repositoryID), required: true);
            WorkflowValue.Validate(action, nameof(action), required: true);
            WorkflowValue.Validate(member, nameof(member), required: true);
            WorkflowValue.Validate(external, nameof(external), required: true);
            WorkflowValue.Validate(deleteIfFederated, nameof(deleteIfFederated), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCollabSpaceResponse> __BuildCreateCollabSpace(WorkflowValue<string> workspaceID, WorkflowValue<string> name, WorkflowValue<string> description = null)
        {
            WorkflowValue.Validate(workspaceID, nameof(workspaceID), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(description, nameof(description), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetCabinetSettings(WorkflowValue<string> cabinetID)
        {
            WorkflowValue.Validate(cabinetID, nameof(cabinetID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetCabinetInformation(WorkflowValue<string> cabinetID)
        {
            WorkflowValue.Validate(cabinetID, nameof(cabinetID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildGetCabinetCustomAttributes(WorkflowValue<string> cabinetID)
        {
            WorkflowValue.Validate(cabinetID, nameof(cabinetID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCabinetDefaultAccessResponseItem[]> __BuildGetCabinetDefaultAccess(WorkflowValue<string> cabinetID)
        {
            WorkflowValue.Validate(cabinetID, nameof(cabinetID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddToOrRemoveGroupFromCabinet(WorkflowValue<string> cabinetID, WorkflowValue<actionInput> action, WorkflowValue<string> id, WorkflowValue<bool> view, WorkflowValue<bool> edit, WorkflowValue<bool> share, WorkflowValue<bool> administer, WorkflowValue<bool> noAccess)
        {
            WorkflowValue.Validate(cabinetID, nameof(cabinetID), required: true);
            WorkflowValue.Validate(action, nameof(action), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(view, nameof(view), required: true);
            WorkflowValue.Validate(edit, nameof(edit), required: true);
            WorkflowValue.Validate(share, nameof(share), required: true);
            WorkflowValue.Validate(administer, nameof(administer), required: true);
            WorkflowValue.Validate(noAccess, nameof(noAccess), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCabinetGroupsResponseItem[]> __BuildGetCabinetGroups(WorkflowValue<string> cabinetID)
        {
            WorkflowValue.Validate(cabinetID, nameof(cabinetID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateCabinetExternalGroupResponse> __BuildCreateCabinetExternalGroup(WorkflowValue<string> cabinetID, WorkflowValue<string> name, WorkflowValue<optionsInput> options = null, WorkflowValue<accessInput> access = null, WorkflowValue<string> collaborationSpaceId = null, WorkflowValue<collaborationspaceaccessInput> collaborationspaceaccess = null, WorkflowValue<string> topwsattributegroupkey = null)
        {
            WorkflowValue.Validate(cabinetID, nameof(cabinetID), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(options, nameof(options), required: false);
            WorkflowValue.Validate(access, nameof(access), required: false);
            WorkflowValue.Validate(collaborationSpaceId, nameof(collaborationSpaceId), required: false);
            WorkflowValue.Validate(collaborationspaceaccess, nameof(collaborationspaceaccess), required: false);
            WorkflowValue.Validate(topwsattributegroupkey, nameof(topwsattributegroupkey), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSearchCabinetModifyACLs(WorkflowValue<string> cabinetID, WorkflowValue<string> q, WorkflowValue<modeInput> mode, WorkflowValue<string> newAcl, WorkflowValue<string> email = null, WorkflowValue<completionEmailInput> completionEmail = null)
        {
            WorkflowValue.Validate(cabinetID, nameof(cabinetID), required: true);
            WorkflowValue.Validate(q, nameof(q), required: true);
            WorkflowValue.Validate(mode, nameof(mode), required: true);
            WorkflowValue.Validate(newAcl, nameof(newAcl), required: true);
            WorkflowValue.Validate(email, nameof(email), required: false);
            WorkflowValue.Validate(completionEmail, nameof(completionEmail), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetContainerContents(WorkflowValue<string> containerID, WorkflowValue<string> select, WorkflowValue<int> top = null, WorkflowValue<string> skiptoken = null, WorkflowValue<string> orderby = null)
        {
            WorkflowValue.Validate(containerID, nameof(containerID), required: true);
            WorkflowValue.Validate(select, nameof(select), required: true);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGroupInformationResponse> __BuildGetGroupInformation(WorkflowValue<string> groupID, WorkflowValue<bool> cabMembership = null)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
            WorkflowValue.Validate(cabMembership, nameof(cabMembership), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGroupMembershipResponseItem[]> __BuildGetGroupMembership(WorkflowValue<string> groupID)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddOrRemoveGroupMember(WorkflowValue<string> groupID, WorkflowValue<actionInput> action, WorkflowValue<string> member)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
            WorkflowValue.Validate(action, nameof(action), required: true);
            WorkflowValue.Validate(member, nameof(member), required: true);
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
        public IWorkflowTrigger SearchCab([WorkflowExpression] Func<string> cabId, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<orderbyInput> orderby = null, [WorkflowExpression] Func<string> top = null, [WorkflowExpression] Func<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildSearchCab(WorkflowValue<string> cabId, WorkflowValue<string> q, WorkflowValue<orderbyInput> orderby = null, WorkflowValue<string> top = null, WorkflowValue<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(cabId, nameof(cabId), required: true);
            WorkflowValue.Validate(q, nameof(q), required: true);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
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
                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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

    public enum actionInput
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "remove")]
        Remove
    }

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

    public enum optionsInput
    {
        [EnumMember(Value = "hidden")]
        Hidden,
        [EnumMember(Value = "hideMembership")]
        HideMembership,
        [EnumMember(Value = "hidden,hideMembership")]
        HiddenHideMembership
    }

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

    public enum modeInput
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "remove")]
        Remove
    }

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
