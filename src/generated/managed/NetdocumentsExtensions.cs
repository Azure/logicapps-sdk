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
        public IWorkflowAction GetDocumentVersions([WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Document/{0}/versionList", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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
        public IBodyWorkflowAction<CreateWorkspaceParentChildResponse> CreateWorkspaceParentChild([WorkflowExpression] Func<string> cabinetId, [WorkflowExpression] Func<string> parentId, [WorkflowExpression] Func<string> childId)
        {
            SourceExpression.Validate(cabinetId, nameof(cabinetId), required: true);
            SourceExpression.Validate(parentId, nameof(parentId), required: true);
            SourceExpression.Validate(childId, nameof(childId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Workspace/{0}/{1}/{2}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<CreateWorkspaceParentChildResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateWorkspaceSingleResponse> CreateWorkspaceSingle([WorkflowExpression] Func<string> cabinetId, [WorkflowExpression] Func<string> parentId)
        {
            SourceExpression.Validate(cabinetId, nameof(cabinetId), required: true);
            SourceExpression.Validate(parentId, nameof(parentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Workspace/{0}/{1}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<CreateWorkspaceSingleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetWorkspaceInformation([WorkflowExpression] Func<string> workspaceId)
        {
            SourceExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Workspace/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateChildEntryResponse> CreateChildEntry([WorkflowExpression] Func<string> repositoryId, [WorkflowExpression] Func<string> childAttributeId, [WorkflowExpression] Func<string> parentId, [WorkflowExpression] Func<string> childId, [WorkflowExpression] Func<bool> lookupEntryBodyaccessfilteredPermissions, [WorkflowExpression] Func<bool> lookupEntryBodyaccessforcePermssions, [WorkflowExpression] Func<string> lookupEntryBodydescription = null, [WorkflowExpression] Func<string> lookupEntryBodytype = null, [WorkflowExpression] Func<bool> lookupEntryBodylitigationHold = null, [WorkflowExpression] Func<string> lookupEntryBodyclosedDate = null, [WorkflowExpression] Func<lookupEntryBodyaccesspermissionsInputItem[]> lookupEntryBodyaccesspermissions = null)
        {
            SourceExpression.Validate(repositoryId, nameof(repositoryId), required: true);
            SourceExpression.Validate(childAttributeId, nameof(childAttributeId), required: true);
            SourceExpression.Validate(parentId, nameof(parentId), required: true);
            SourceExpression.Validate(childId, nameof(childId), required: true);
            SourceExpression.Validate(lookupEntryBodyaccessfilteredPermissions, nameof(lookupEntryBodyaccessfilteredPermissions), required: true);
            SourceExpression.Validate(lookupEntryBodyaccessforcePermssions, nameof(lookupEntryBodyaccessforcePermssions), required: true);
            SourceExpression.Validate(lookupEntryBodydescription, nameof(lookupEntryBodydescription), required: false);
            SourceExpression.Validate(lookupEntryBodytype, nameof(lookupEntryBodytype), required: false);
            SourceExpression.Validate(lookupEntryBodylitigationHold, nameof(lookupEntryBodylitigationHold), required: false);
            SourceExpression.Validate(lookupEntryBodyclosedDate, nameof(lookupEntryBodyclosedDate), required: false);
            SourceExpression.Validate(lookupEntryBodyaccesspermissions, nameof(lookupEntryBodyaccesspermissions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childAttributeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childId, 1));
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
        public IWorkflowAction GetChildEntry([WorkflowExpression] Func<string> repositoryId, [WorkflowExpression] Func<string> childAttributeId, [WorkflowExpression] Func<string> parentId, [WorkflowExpression] Func<string> childId)
        {
            SourceExpression.Validate(repositoryId, nameof(repositoryId), required: true);
            SourceExpression.Validate(childAttributeId, nameof(childAttributeId), required: true);
            SourceExpression.Validate(parentId, nameof(parentId), required: true);
            SourceExpression.Validate(childId, nameof(childId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childAttributeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<DeleteChildEntryResponse> DeleteChildEntry([WorkflowExpression] Func<string> repositoryId, [WorkflowExpression] Func<string> childAttributeId, [WorkflowExpression] Func<string> parentId, [WorkflowExpression] Func<string> childId)
        {
            SourceExpression.Validate(repositoryId, nameof(repositoryId), required: true);
            SourceExpression.Validate(childAttributeId, nameof(childAttributeId), required: true);
            SourceExpression.Validate(parentId, nameof(parentId), required: true);
            SourceExpression.Validate(childId, nameof(childId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childAttributeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(childId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<DeleteChildEntryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateEntryResponse> CreateEntry([WorkflowExpression] Func<string> repositoryId, [WorkflowExpression] Func<string> attributeId, [WorkflowExpression] Func<string> parentId, [WorkflowExpression] Func<bool> lookupEntryBodyaccessfilteredPermissions, [WorkflowExpression] Func<bool> lookupEntryBodyaccessforcePermssions, [WorkflowExpression] Func<string> lookupEntryBodydescription = null, [WorkflowExpression] Func<string> lookupEntryBodytype = null, [WorkflowExpression] Func<bool> lookupEntryBodylitigationHold = null, [WorkflowExpression] Func<string> lookupEntryBodyclosedDate = null, [WorkflowExpression] Func<lookupEntryBodyaccesspermissionsInputItem[]> lookupEntryBodyaccesspermissions = null)
        {
            SourceExpression.Validate(repositoryId, nameof(repositoryId), required: true);
            SourceExpression.Validate(attributeId, nameof(attributeId), required: true);
            SourceExpression.Validate(parentId, nameof(parentId), required: true);
            SourceExpression.Validate(lookupEntryBodyaccessfilteredPermissions, nameof(lookupEntryBodyaccessfilteredPermissions), required: true);
            SourceExpression.Validate(lookupEntryBodyaccessforcePermssions, nameof(lookupEntryBodyaccessforcePermssions), required: true);
            SourceExpression.Validate(lookupEntryBodydescription, nameof(lookupEntryBodydescription), required: false);
            SourceExpression.Validate(lookupEntryBodytype, nameof(lookupEntryBodytype), required: false);
            SourceExpression.Validate(lookupEntryBodylitigationHold, nameof(lookupEntryBodylitigationHold), required: false);
            SourceExpression.Validate(lookupEntryBodyclosedDate, nameof(lookupEntryBodyclosedDate), required: false);
            SourceExpression.Validate(lookupEntryBodyaccesspermissions, nameof(lookupEntryBodyaccesspermissions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attributeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentId, 1));
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
        public IWorkflowAction GetLookupEntry([WorkflowExpression] Func<string> repositoryId, [WorkflowExpression] Func<string> attributeId, [WorkflowExpression] Func<string> parentId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<orderbyInput> orderby = null)
        {
            SourceExpression.Validate(repositoryId, nameof(repositoryId), required: true);
            SourceExpression.Validate(attributeId, nameof(attributeId), required: true);
            SourceExpression.Validate(parentId, nameof(parentId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attributeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentId, 1));
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
        public IBodyWorkflowAction<DeleteLookupEntryResponse> DeleteLookupEntry([WorkflowExpression] Func<string> repositoryId, [WorkflowExpression] Func<string> attributeId, [WorkflowExpression] Func<string> parentId)
        {
            SourceExpression.Validate(repositoryId, nameof(repositoryId), required: true);
            SourceExpression.Validate(attributeId, nameof(attributeId), required: true);
            SourceExpression.Validate(parentId, nameof(parentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attributeId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(parentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<DeleteLookupEntryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<SearchLookupEntriesResponse> SearchLookupEntries([WorkflowExpression] Func<string> repositoryId, [WorkflowExpression] Func<string> attributeId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(repositoryId, nameof(repositoryId), required: true);
            SourceExpression.Validate(attributeId, nameof(attributeId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/attributes/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attributeId, 1));
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
        public IWorkflowAction GetRepositoryLog([WorkflowExpression] Func<string> repositoryId, [WorkflowExpression] Func<logtypeInput> logtype, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null)
        {
            SourceExpression.Validate(repositoryId, nameof(repositoryId), required: true);
            SourceExpression.Validate(logtype, nameof(logtype), required: true);
            SourceExpression.Validate(start, nameof(start), required: false);
            SourceExpression.Validate(end, nameof(end), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/log", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryId, 1));
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
        public IWorkflowAction GetRepositoryInformation([WorkflowExpression] Func<string> repositoryId)
        {
            SourceExpression.Validate(repositoryId, nameof(repositoryId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetRepositoryUsersResponseItem[]> GetRepositoryUsers([WorkflowExpression] Func<string> repositoryId)
        {
            SourceExpression.Validate(repositoryId, nameof(repositoryId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/users", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetRepositoryUsersResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<string[]> GetRepositoryGroups([WorkflowExpression] Func<string> repositoryId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> top = null, [WorkflowExpression] Func<bool> paging = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<returnInfoInput> returnInfo = null)
        {
            SourceExpression.Validate(repositoryId, nameof(repositoryId), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(paging, nameof(paging), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(returnInfo, nameof(returnInfo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/groups", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryId, 1));
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
        public IWorkflowAction DeleteRepositoryGroup([WorkflowExpression] Func<string> repositoryId, [WorkflowExpression] Func<string> groupId)
        {
            SourceExpression.Validate(repositoryId, nameof(repositoryId), required: true);
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Repository/{0}/group/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(repositoryId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetCabinetSettings([WorkflowExpression] Func<string> cabinetId)
        {
            SourceExpression.Validate(cabinetId, nameof(cabinetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/settings", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetCabinetInformation([WorkflowExpression] Func<string> cabinetId)
        {
            SourceExpression.Validate(cabinetId, nameof(cabinetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<JToken[]> GetCabinetCustomAttributes([WorkflowExpression] Func<string> cabinetId)
        {
            SourceExpression.Validate(cabinetId, nameof(cabinetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/customAttributes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCabinetDefaultAccessResponseItem[]> GetCabinetDefaultAccess([WorkflowExpression] Func<string> cabinetId)
        {
            SourceExpression.Validate(cabinetId, nameof(cabinetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/cabinet/{0}/membership", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetCabinetDefaultAccessResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCabinetGroupsResponseItem[]> GetCabinetGroups([WorkflowExpression] Func<string> cabinetId)
        {
            SourceExpression.Validate(cabinetId, nameof(cabinetId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/cabinet/{0}/groups", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cabinetId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetCabinetGroupsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetContainerContents([WorkflowExpression] Func<string> containerId, [WorkflowExpression] Func<string> select, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<string> orderby = null)
        {
            SourceExpression.Validate(containerId, nameof(containerId), required: true);
            SourceExpression.Validate(select, nameof(select), required: true);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/container/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(containerId, 1));
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
        public IBodyWorkflowAction<GetGroupInformationResponse> GetGroupInformation([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<bool> cabMembership = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(cabMembership, nameof(cabMembership), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Group/{0}/info", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
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
        public IBodyWorkflowAction<GetGroupMembershipResponseItem[]> GetGroupMembership([WorkflowExpression] Func<string> groupId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Group/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetGroupMembershipResponseItem[]>(BuildSourceInput);
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