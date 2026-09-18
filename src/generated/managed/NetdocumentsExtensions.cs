//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Netdocuments
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NetdocumentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetUserInfoResponse> GetUserInfo([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> cabGuid = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(cabGuid, nameof(cabGuid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/User/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cabGuid != null)
                    callPayload.Queries["cabGuid"] = SourceExpressionConverter.ConvertO(cabGuid);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetUserInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetUserCabinetsResponseItem[]> GetUserCabinets()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/User/cabinets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetUserCabinetsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<NewVersionResponse> NewVersion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> extension = null, [WorkflowExpression] Func<string> versionDescription = null, [WorkflowExpression] Func<string> verName = null, [WorkflowExpression] Func<bool> official = null, [WorkflowExpression] Func<bool> addToRecent = null, [WorkflowExpression] Func<string> srcVer = null, [WorkflowExpression] Func<bool> allocatesubversion = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(extension, nameof(extension), required: false);
            SourceExpression.Validate(versionDescription, nameof(versionDescription), required: false);
            SourceExpression.Validate(verName, nameof(verName), required: false);
            SourceExpression.Validate(official, nameof(official), required: false);
            SourceExpression.Validate(addToRecent, nameof(addToRecent), required: false);
            SourceExpression.Validate(srcVer, nameof(srcVer), required: false);
            SourceExpression.Validate(allocatesubversion, nameof(allocatesubversion), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}/new", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extension != null)
                    callPayload.Queries["extension"] = SourceExpressionConverter.ConvertO(extension);
                if (versionDescription != null)
                    callPayload.Queries["version_description"] = SourceExpressionConverter.ConvertO(versionDescription);
                if (verName != null)
                    callPayload.Queries["verName"] = SourceExpressionConverter.ConvertO(verName);
                callPayload.Queries["official"] = Convert.ToString(true);
                if (official != null)
                    callPayload.Queries["official"] = SourceExpressionConverter.ConvertO(official);
                if (addToRecent != null)
                    callPayload.Queries["addToRecent"] = SourceExpressionConverter.ConvertO(addToRecent);
                if (srcVer != null)
                    callPayload.Queries["srcVer"] = SourceExpressionConverter.ConvertO(srcVer);
                callPayload.Queries["allocatesubversion"] = Convert.ToString(false);
                if (allocatesubversion != null)
                    callPayload.Queries["allocatesubversion"] = SourceExpressionConverter.ConvertO(allocatesubversion);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<NewVersionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetDocInfo([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction RenameDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> renameBodystandardAttributesnewName)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(renameBodystandardAttributesnewName, nameof(renameBodystandardAttributesnewName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var renameBody = new JObject();
                var renameBodypropCount = 0;
                var standardAttributesObject = new JObject();
                var standardAttributesObjectpropCount = 0;
                standardAttributesObjectpropCount++;
                standardAttributesObject["name"] = SourceExpressionConverter.ConvertToken(renameBodystandardAttributesnewName);
                if (standardAttributesObjectpropCount > 0)
                {
                    renameBody["standardAttributes"] = standardAttributesObject;
                    renameBodypropCount++;
                }

                if (renameBodypropCount > 0)
                {
                    callPayload.Body = renameBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetDocContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> base64 = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(base64, nameof(base64), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["base64"] = Convert.ToString(false);
                if (base64 != null)
                    callPayload.Queries["base64"] = SourceExpressionConverter.ConvertO(base64);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction DeleteDoc([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> permanent = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(permanent, nameof(permanent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["permanent"] = Convert.ToString(false);
                if (permanent != null)
                    callPayload.Queries["permanent"] = SourceExpressionConverter.ConvertO(permanent);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction UpdateDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> extension = null, [WorkflowExpression] Func<bool> base64 = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(extension, nameof(extension), required: false);
            SourceExpression.Validate(base64, nameof(base64), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (extension != null)
                    callPayload.Queries["extension"] = SourceExpressionConverter.ConvertO(extension);
                callPayload.Queries["base64"] = Convert.ToString(true);
                if (base64 != null)
                    callPayload.Queries["base64"] = SourceExpressionConverter.ConvertO(base64);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateFolderResponse> CreateFolder([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> parent = null, [WorkflowExpression] Func<string> cabinet = null)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(parent, nameof(parent), required: false);
            SourceExpression.Validate(cabinet, nameof(cabinet), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Folder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<CreateFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetFldContent([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Folder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction FileFolder([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> item, [WorkflowExpression] Func<actionInput> action)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(item, nameof(item), required: true);
            SourceExpression.Validate(action, nameof(action), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Folder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction DeleteFolder([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> permanent = null, [WorkflowExpression] Func<bool> deleteContents = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(permanent, nameof(permanent), required: false);
            SourceExpression.Validate(deleteContents, nameof(deleteContents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Folder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["permanent"] = Convert.ToString(false);
                if (permanent != null)
                    callPayload.Queries["permanent"] = SourceExpressionConverter.ConvertO(permanent);
                callPayload.Queries["deleteContents"] = Convert.ToString(false);
                if (deleteContents != null)
                    callPayload.Queries["deleteContents"] = SourceExpressionConverter.ConvertO(deleteContents);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction RenameFolder([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> renameBodystandardAttributesnewName)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(renameBodystandardAttributesnewName, nameof(renameBodystandardAttributesnewName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Folder/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var renameBody = new JObject();
                var renameBodypropCount = 0;
                var standardAttributesObject = new JObject();
                var standardAttributesObjectpropCount = 0;
                standardAttributesObjectpropCount++;
                standardAttributesObject["name"] = SourceExpressionConverter.ConvertToken(renameBodystandardAttributesnewName);
                if (standardAttributesObjectpropCount > 0)
                {
                    renameBody["standardAttributes"] = standardAttributesObject;
                    renameBodypropCount++;
                }

                if (renameBodypropCount > 0)
                {
                    callPayload.Body = renameBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction FollowFolder([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> recipients, [WorkflowExpression] Func<sendInput> send = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(recipients, nameof(recipients), required: true);
            SourceExpression.Validate(send, nameof(send), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Folder/{0}/follow", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction FollowDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> recipients, [WorkflowExpression] Func<sendInput> send = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(recipients, nameof(recipients), required: true);
            SourceExpression.Validate(send, nameof(send), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Document/follow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCurrentUserInfoResponse> GetCurrentUserInfo([WorkflowExpression] Func<string> cabGuid = null)
        {
            SourceExpression.Validate(cabGuid, nameof(cabGuid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/User/info";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cabGuid != null)
                    callPayload.Queries["cabGuid"] = SourceExpressionConverter.ConvertO(cabGuid);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetCurrentUserInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction CheckinDoc([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> extension = null, [WorkflowExpression] Func<object> file = null, [WorkflowExpression] Func<bool> addToRecent = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(extension, nameof(extension), required: false);
            SourceExpression.Validate(file, nameof(file), required: false);
            SourceExpression.Validate(addToRecent, nameof(addToRecent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Document/checkin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction CheckOutDoc([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> comment = null, [WorkflowExpression] Func<bool> download = null, [WorkflowExpression] Func<string> version = null, [WorkflowExpression] Func<bool> addToRecent = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(comment, nameof(comment), required: false);
            SourceExpression.Validate(download, nameof(download), required: false);
            SourceExpression.Validate(version, nameof(version), required: false);
            SourceExpression.Validate(addToRecent, nameof(addToRecent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Document/checkout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateDocumentResponse> CreateDocument([WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<object> file, [WorkflowExpression] Func<bool> addToRecent = null, [WorkflowExpression] Func<string> profile = null)
        {
            SourceExpression.Validate(destination, nameof(destination), required: true);
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(addToRecent, nameof(addToRecent), required: false);
            SourceExpression.Validate(profile, nameof(profile), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Document/upload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<CreateDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction LockDocumentVersion([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<int> version, [WorkflowExpression] Func<string> description = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(description, nameof(description), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Document/lock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetDocumentVersions([WorkflowExpression] Func<string> documentID)
        {
            SourceExpression.Validate(documentID, nameof(documentID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}/versionList", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateSecuredLinkResponse> CreateSecuredLink([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> password = null, [WorkflowExpression] Func<string> expirationdate = null, [WorkflowExpression] Func<string> version = null, [WorkflowExpression] Func<bool> download = null, [WorkflowExpression] Func<bool> notifyme = null, [WorkflowExpression] Func<bool> @lock = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(password, nameof(password), required: false);
            SourceExpression.Validate(expirationdate, nameof(expirationdate), required: false);
            SourceExpression.Validate(version, nameof(version), required: false);
            SourceExpression.Validate(download, nameof(download), required: false);
            SourceExpression.Validate(notifyme, nameof(notifyme), required: false);
            SourceExpression.Validate(@lock, nameof(@lock), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Document/createsecuredlink";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<CreateSecuredLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetDocHistory([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}/history", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateWorkspaceParentChildResponse> CreateWorkspaceParentChild([WorkflowExpression] Func<string> cabinetID, [WorkflowExpression] Func<string> parentID, [WorkflowExpression] Func<string> childID)
        {
            SourceExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            SourceExpression.Validate(parentID, nameof(parentID), required: true);
            SourceExpression.Validate(childID, nameof(childID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Workspace/{0}/{1}/{2}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<CreateWorkspaceParentChildResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateWorkspaceSingleResponse> CreateWorkspaceSingle([WorkflowExpression] Func<string> cabinetID, [WorkflowExpression] Func<string> parentID)
        {
            SourceExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            SourceExpression.Validate(parentID, nameof(parentID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Workspace/{0}/{1}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<CreateWorkspaceSingleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetWorkspaceInformation([WorkflowExpression] Func<string> workspaceID)
        {
            SourceExpression.Validate(workspaceID, nameof(workspaceID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Workspace/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateChildEntryResponse> CreateChildEntry([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> childAttributeID, [WorkflowExpression] Func<string> parentID, [WorkflowExpression] Func<string> childID, [WorkflowExpression] Func<bool> lookupEntryBodyaccessfilteredPermissions, [WorkflowExpression] Func<bool> lookupEntryBodyaccessforcePermssions, [WorkflowExpression] Func<string> lookupEntryBodydescription = null, [WorkflowExpression] Func<string> lookupEntryBodytype = null, [WorkflowExpression] Func<bool> lookupEntryBodylitigationHold = null, [WorkflowExpression] Func<string> lookupEntryBodyclosedDate = null, [WorkflowExpression] Func<lookupEntryBodyaccesspermissionsInputItem[]> lookupEntryBodyaccesspermissions = null)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            SourceExpression.Validate(childAttributeID, nameof(childAttributeID), required: true);
            SourceExpression.Validate(parentID, nameof(parentID), required: true);
            SourceExpression.Validate(childID, nameof(childID), required: true);
            SourceExpression.Validate(lookupEntryBodyaccessfilteredPermissions, nameof(lookupEntryBodyaccessfilteredPermissions), required: true);
            SourceExpression.Validate(lookupEntryBodyaccessforcePermssions, nameof(lookupEntryBodyaccessforcePermssions), required: true);
            SourceExpression.Validate(lookupEntryBodydescription, nameof(lookupEntryBodydescription), required: false);
            SourceExpression.Validate(lookupEntryBodytype, nameof(lookupEntryBodytype), required: false);
            SourceExpression.Validate(lookupEntryBodylitigationHold, nameof(lookupEntryBodylitigationHold), required: false);
            SourceExpression.Validate(lookupEntryBodyclosedDate, nameof(lookupEntryBodyclosedDate), required: false);
            SourceExpression.Validate(lookupEntryBodyaccesspermissions, nameof(lookupEntryBodyaccesspermissions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childAttributeID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childID, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var lookupEntryBody = new JObject();
                var lookupEntryBodypropCount = 0;
                if (lookupEntryBodydescription != null)
                {
                    lookupEntryBody["description"] = SourceExpressionConverter.ConvertToken(lookupEntryBodydescription);
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodytype != null)
                {
                    lookupEntryBody["defaulting"] = SourceExpressionConverter.ConvertToken(lookupEntryBodytype);
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodylitigationHold != null)
                {
                    lookupEntryBody["hold"] = SourceExpressionConverter.ConvertToken(lookupEntryBodylitigationHold);
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodyclosedDate != null)
                {
                    lookupEntryBody["closed"] = SourceExpressionConverter.ConvertToken(lookupEntryBodyclosedDate);
                    lookupEntryBodypropCount++;
                }

                var accessObject = new JObject();
                var accessObjectpropCount = 0;
                accessObjectpropCount++;
                accessObject["filtered_permissions"] = SourceExpressionConverter.ConvertToken(lookupEntryBodyaccessfilteredPermissions);
                accessObjectpropCount++;
                accessObject["force_permissions"] = SourceExpressionConverter.ConvertToken(lookupEntryBodyaccessforcePermssions);
                if (lookupEntryBodyaccesspermissions != null)
                {
                    accessObject["permissions"] = SourceExpressionConverter.ConvertToken(lookupEntryBodyaccesspermissions);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateChildEntryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetChildEntry([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> childAttributeID, [WorkflowExpression] Func<string> parentID, [WorkflowExpression] Func<string> childID)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            SourceExpression.Validate(childAttributeID, nameof(childAttributeID), required: true);
            SourceExpression.Validate(parentID, nameof(parentID), required: true);
            SourceExpression.Validate(childID, nameof(childID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childAttributeID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<DeleteChildEntryResponse> DeleteChildEntry([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> childAttributeID, [WorkflowExpression] Func<string> parentID, [WorkflowExpression] Func<string> childID)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            SourceExpression.Validate(childAttributeID, nameof(childAttributeID), required: true);
            SourceExpression.Validate(parentID, nameof(parentID), required: true);
            SourceExpression.Validate(childID, nameof(childID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childAttributeID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<DeleteChildEntryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateEntryResponse> CreateEntry([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> attributeID, [WorkflowExpression] Func<string> parentID, [WorkflowExpression] Func<bool> lookupEntryBodyaccessfilteredPermissions, [WorkflowExpression] Func<bool> lookupEntryBodyaccessforcePermssions, [WorkflowExpression] Func<string> lookupEntryBodydescription = null, [WorkflowExpression] Func<string> lookupEntryBodytype = null, [WorkflowExpression] Func<bool> lookupEntryBodylitigationHold = null, [WorkflowExpression] Func<string> lookupEntryBodyclosedDate = null, [WorkflowExpression] Func<lookupEntryBodyaccesspermissionsInputItem[]> lookupEntryBodyaccesspermissions = null)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            SourceExpression.Validate(attributeID, nameof(attributeID), required: true);
            SourceExpression.Validate(parentID, nameof(parentID), required: true);
            SourceExpression.Validate(lookupEntryBodyaccessfilteredPermissions, nameof(lookupEntryBodyaccessfilteredPermissions), required: true);
            SourceExpression.Validate(lookupEntryBodyaccessforcePermssions, nameof(lookupEntryBodyaccessforcePermssions), required: true);
            SourceExpression.Validate(lookupEntryBodydescription, nameof(lookupEntryBodydescription), required: false);
            SourceExpression.Validate(lookupEntryBodytype, nameof(lookupEntryBodytype), required: false);
            SourceExpression.Validate(lookupEntryBodylitigationHold, nameof(lookupEntryBodylitigationHold), required: false);
            SourceExpression.Validate(lookupEntryBodyclosedDate, nameof(lookupEntryBodyclosedDate), required: false);
            SourceExpression.Validate(lookupEntryBodyaccesspermissions, nameof(lookupEntryBodyaccesspermissions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attributeID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentID, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var lookupEntryBody = new JObject();
                var lookupEntryBodypropCount = 0;
                if (lookupEntryBodydescription != null)
                {
                    lookupEntryBody["description"] = SourceExpressionConverter.ConvertToken(lookupEntryBodydescription);
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodytype != null)
                {
                    lookupEntryBody["defaulting"] = SourceExpressionConverter.ConvertToken(lookupEntryBodytype);
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodylitigationHold != null)
                {
                    lookupEntryBody["hold"] = SourceExpressionConverter.ConvertToken(lookupEntryBodylitigationHold);
                    lookupEntryBodypropCount++;
                }

                if (lookupEntryBodyclosedDate != null)
                {
                    lookupEntryBody["closed"] = SourceExpressionConverter.ConvertToken(lookupEntryBodyclosedDate);
                    lookupEntryBodypropCount++;
                }

                var accessObject = new JObject();
                var accessObjectpropCount = 0;
                accessObjectpropCount++;
                accessObject["filtered_permissions"] = SourceExpressionConverter.ConvertToken(lookupEntryBodyaccessfilteredPermissions);
                accessObjectpropCount++;
                accessObject["force_permissions"] = SourceExpressionConverter.ConvertToken(lookupEntryBodyaccessforcePermssions);
                if (lookupEntryBodyaccesspermissions != null)
                {
                    accessObject["permissions"] = SourceExpressionConverter.ConvertToken(lookupEntryBodyaccesspermissions);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateEntryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetLookupEntry([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> attributeID, [WorkflowExpression] Func<string> parentID, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<orderbyInput> orderby = null)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            SourceExpression.Validate(attributeID, nameof(attributeID), required: true);
            SourceExpression.Validate(parentID, nameof(parentID), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attributeID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["$orderby"] = Convert.ToString("key");
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.Convert(orderby);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<DeleteLookupEntryResponse> DeleteLookupEntry([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> attributeID, [WorkflowExpression] Func<string> parentID)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            SourceExpression.Validate(attributeID, nameof(attributeID), required: true);
            SourceExpression.Validate(parentID, nameof(parentID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attributeID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<DeleteLookupEntryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<SearchLookupEntriesResponse> SearchLookupEntries([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> attributeID, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            SourceExpression.Validate(attributeID, nameof(attributeID), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attributeID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["$orderby"] = Convert.ToString("key");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<SearchLookupEntriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction SearchCabinets([WorkflowExpression] Func<string> cabinets, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> select, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> skiptoken = null)
        {
            SourceExpression.Validate(cabinets, nameof(cabinets), required: true);
            SourceExpression.Validate(q, nameof(q), required: true);
            SourceExpression.Validate(select, nameof(select), required: true);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/Search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cabinets"] = SourceExpressionConverter.ConvertO(cabinets);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                callPayload.Queries["select"] = SourceExpressionConverter.ConvertO(select);
                if (orderby != null)
                    callPayload.Queries["orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                if (skiptoken != null)
                    callPayload.Queries["skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction RefreshWorkspace([WorkflowExpression] Func<string> workspaceID)
        {
            SourceExpression.Validate(workspaceID, nameof(workspaceID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Workspace/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction LockDocument([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> comment = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(comment, nameof(comment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/document/{0}/lock", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (comment != null)
                    callPayload.Queries["comment"] = SourceExpressionConverter.ConvertO(comment);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction UnockDocument([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/document/{0}/unlock", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetRepositoryLog([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<logtypeInput> logtype, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            SourceExpression.Validate(logtype, nameof(logtype), required: true);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(end, nameof(end), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/log", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("json");
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                callPayload.Queries["Logtype"] = SourceExpressionConverter.Convert(logtype);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetRepositoryInformation([WorkflowExpression] Func<string> repositoryID)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetRepositoryUsersResponseItem[]> GetRepositoryUsers([WorkflowExpression] Func<string> repositoryID)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/users", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetRepositoryUsersResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<string[]> GetRepositoryGroups([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> top = null, [WorkflowExpression] Func<bool> paging = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<returnInfoInput> returnInfo = null)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(paging, nameof(paging), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(returnInfo, nameof(returnInfo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/groups", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                callPayload.Queries["paging"] = Convert.ToString(false);
                if (paging != null)
                    callPayload.Queries["paging"] = SourceExpressionConverter.ConvertO(paging);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                callPayload.Queries["returnInfo"] = Convert.ToString("");
                if (returnInfo != null)
                    callPayload.Queries["returnInfo"] = SourceExpressionConverter.Convert(returnInfo);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateRepositoryGroupResponse> CreateRepositoryGroup([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<bool> external, [WorkflowExpression] Func<bool> hidden, [WorkflowExpression] Func<bool> hideMembership)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(external, nameof(external), required: true);
            SourceExpression.Validate(hidden, nameof(hidden), required: true);
            SourceExpression.Validate(hideMembership, nameof(hideMembership), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/group", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return callPayload;
            }

            return new ApiConnectionAction<CreateRepositoryGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction DeleteRepositoryGroup([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<string> groupID)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/group/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser([WorkflowExpression] Func<string> username, [WorkflowExpression] Func<string> displayFirstName, [WorkflowExpression] Func<string> displayLastName, [WorkflowExpression] Func<string> email, [WorkflowExpression] Func<bool> external, [WorkflowExpression] Func<bool> sendWelcome, [WorkflowExpression] Func<string> repository, [WorkflowExpression] Func<string> displayMiddleName = null)
        {
            SourceExpression.Validate(username, nameof(username), required: true);
            SourceExpression.Validate(displayFirstName, nameof(displayFirstName), required: true);
            SourceExpression.Validate(displayLastName, nameof(displayLastName), required: true);
            SourceExpression.Validate(email, nameof(email), required: true);
            SourceExpression.Validate(external, nameof(external), required: true);
            SourceExpression.Validate(sendWelcome, nameof(sendWelcome), required: true);
            SourceExpression.Validate(repository, nameof(repository), required: true);
            SourceExpression.Validate(displayMiddleName, nameof(displayMiddleName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/User";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return callPayload;
            }

            return new ApiConnectionAction<CreateUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction AddOrRemoveUserRepository([WorkflowExpression] Func<string> repositoryID, [WorkflowExpression] Func<actionInput> action, [WorkflowExpression] Func<string> member, [WorkflowExpression] Func<bool> external, [WorkflowExpression] Func<bool> deleteIfFederated = null)
        {
            SourceExpression.Validate(repositoryID, nameof(repositoryID), required: true);
            SourceExpression.Validate(action, nameof(action), required: true);
            SourceExpression.Validate(member, nameof(member), required: true);
            SourceExpression.Validate(external, nameof(external), required: true);
            SourceExpression.Validate(deleteIfFederated, nameof(deleteIfFederated), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateCollabSpaceResponse> CreateCollabSpace([WorkflowExpression] Func<string> workspaceID, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> description = null)
        {
            SourceExpression.Validate(workspaceID, nameof(workspaceID), required: true);
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(description, nameof(description), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/container/{0}/collabspace", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return callPayload;
            }

            return new ApiConnectionAction<CreateCollabSpaceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetCabinetSettings([WorkflowExpression] Func<string> cabinetID)
        {
            SourceExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/settings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetCabinetInformation([WorkflowExpression] Func<string> cabinetID)
        {
            SourceExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<JToken[]> GetCabinetCustomAttributes([WorkflowExpression] Func<string> cabinetID)
        {
            SourceExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/customAttributes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCabinetDefaultAccessResponseItem[]> GetCabinetDefaultAccess([WorkflowExpression] Func<string> cabinetID)
        {
            SourceExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/membership", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetCabinetDefaultAccessResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction AddToOrRemoveGroupFromCabinet([WorkflowExpression] Func<string> cabinetID, [WorkflowExpression] Func<actionInput> action, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> view, [WorkflowExpression] Func<bool> edit, [WorkflowExpression] Func<bool> share, [WorkflowExpression] Func<bool> administer, [WorkflowExpression] Func<bool> noAccess)
        {
            SourceExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            SourceExpression.Validate(action, nameof(action), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(view, nameof(view), required: true);
            SourceExpression.Validate(edit, nameof(edit), required: true);
            SourceExpression.Validate(share, nameof(share), required: true);
            SourceExpression.Validate(administer, nameof(administer), required: true);
            SourceExpression.Validate(noAccess, nameof(noAccess), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/membership", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCabinetGroupsResponseItem[]> GetCabinetGroups([WorkflowExpression] Func<string> cabinetID)
        {
            SourceExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cabinet/{0}/groups", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetCabinetGroupsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateCabinetExternalGroupResponse> CreateCabinetExternalGroup([WorkflowExpression] Func<string> cabinetID, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<optionsInput> options = null, [WorkflowExpression] Func<accessInput> access = null, [WorkflowExpression] Func<string> collaborationSpaceId = null, [WorkflowExpression] Func<collaborationspaceaccessInput> collaborationspaceaccess = null, [WorkflowExpression] Func<string> topwsattributegroupkey = null)
        {
            SourceExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(options, nameof(options), required: false);
            SourceExpression.Validate(access, nameof(access), required: false);
            SourceExpression.Validate(collaborationSpaceId, nameof(collaborationSpaceId), required: false);
            SourceExpression.Validate(collaborationspaceaccess, nameof(collaborationspaceaccess), required: false);
            SourceExpression.Validate(topwsattributegroupkey, nameof(topwsattributegroupkey), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cabinet/{0}/group/external", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return callPayload;
            }

            return new ApiConnectionAction<CreateCabinetExternalGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction SearchCabinetModifyACLs([WorkflowExpression] Func<string> cabinetID, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<modeInput> mode, [WorkflowExpression] Func<string> newAcl, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<completionEmailInput> completionEmail = null)
        {
            SourceExpression.Validate(cabinetID, nameof(cabinetID), required: true);
            SourceExpression.Validate(q, nameof(q), required: true);
            SourceExpression.Validate(mode, nameof(mode), required: true);
            SourceExpression.Validate(newAcl, nameof(newAcl), required: true);
            SourceExpression.Validate(email, nameof(email), required: false);
            SourceExpression.Validate(completionEmail, nameof(completionEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Search/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetContainerContents([WorkflowExpression] Func<string> containerID, [WorkflowExpression] Func<string> select, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<string> orderby = null)
        {
            SourceExpression.Validate(containerID, nameof(containerID), required: true);
            SourceExpression.Validate(select, nameof(select), required: true);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/container/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["select"] = SourceExpressionConverter.ConvertO(select);
                if (top != null)
                    callPayload.Queries["top"] = SourceExpressionConverter.ConvertO(top);
                if (skiptoken != null)
                    callPayload.Queries["skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (orderby != null)
                    callPayload.Queries["orderby"] = SourceExpressionConverter.ConvertO(orderby);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetGroupInformationResponse> GetGroupInformation([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<bool> cabMembership = null)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            SourceExpression.Validate(cabMembership, nameof(cabMembership), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Group/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cabMembership"] = Convert.ToString(false);
                if (cabMembership != null)
                    callPayload.Queries["cabMembership"] = SourceExpressionConverter.ConvertO(cabMembership);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetGroupInformationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetGroupMembershipResponseItem[]> GetGroupMembership([WorkflowExpression] Func<string> groupID)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Group/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetGroupMembershipResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction AddOrRemoveGroupMember([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<actionInput> action, [WorkflowExpression] Func<string> member)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            SourceExpression.Validate(action, nameof(action), required: true);
            SourceExpression.Validate(member, nameof(member), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Group/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class NetdocumentsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger SearchCab([WorkflowExpression] Func<string> cabId, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<orderbyInput> orderby = null, [WorkflowExpression] Func<string> top = null, [WorkflowExpression] Func<string> select = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(cabId, nameof(cabId), required: true);
            SourceExpression.Validate(q, nameof(q), required: true);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Search/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                callPayload.Queries["$orderby"] = Convert.ToString("relevance desc");
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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