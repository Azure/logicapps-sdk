//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Netdocuments
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NetdocumentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetUserInfoResponse> GetUserInfo(Expression<Func<string>> id, Expression<Func<string>> cabGuid = null)
        {
            var apiCallPath = String.Format("/v1/User/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (cabGuid != null)
                callPayload.Queries["cabGuid"] = ExpressionConverter.Convert(cabGuid);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetUserInfoResponse>(callPayload);
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
            var apiCallPath = String.Format("/v1/Document/{0}/new", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetDocInfo(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1/Document/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction RenameDocument(Expression<Func<string>> id, Expression<Func<string>> renameBodystandardAttributesnewName)
        {
            var apiCallPath = String.Format("/v1/Document/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetDocContent(Expression<Func<string>> id, Expression<Func<bool>> base64 = null)
        {
            var apiCallPath = String.Format("/v1/Document/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["base64"] = Convert.ToString(false);
            if (base64 != null)
                callPayload.Queries["base64"] = ExpressionConverter.Convert(base64);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction DeleteDoc(Expression<Func<string>> id, Expression<Func<bool>> permanent = null)
        {
            var apiCallPath = String.Format("/v1/Document/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["permanent"] = Convert.ToString(false);
            if (permanent != null)
                callPayload.Queries["permanent"] = ExpressionConverter.Convert(permanent);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction UpdateDocument(Expression<Func<string>> id, Expression<Func<string>> extension = null, Expression<Func<bool>> base64 = null, Expression<Func<string>> body = null)
        {
            var apiCallPath = String.Format("/v1/Document/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateFolderResponse> CreateFolder(Expression<Func<string>> name, Expression<Func<string>> parent = null, Expression<Func<string>> cabinet = null)
        {
            var apiCallPath = "/v1/Folder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<CreateFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetFldContent(Expression<Func<string>> id, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/v1/Folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction FileFolder(Expression<Func<string>> id, Expression<Func<string>> item, Expression<Func<actionInput>> action)
        {
            var apiCallPath = String.Format("/v1/Folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction DeleteFolder(Expression<Func<string>> id, Expression<Func<bool>> permanent = null, Expression<Func<bool>> deleteContents = null)
        {
            var apiCallPath = String.Format("/v1/Folder/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction RenameFolder(Expression<Func<string>> id, Expression<Func<string>> renameBodystandardAttributesnewName)
        {
            var apiCallPath = String.Format("/v1/Folder/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction FollowFolder(Expression<Func<string>> id, Expression<Func<string>> recipients, Expression<Func<sendInput>> send = null)
        {
            var apiCallPath = String.Format("/v1/Folder/{0}/follow", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction FollowDocument(Expression<Func<string>> id, Expression<Func<string>> recipients, Expression<Func<sendInput>> send = null)
        {
            var apiCallPath = "/v1/Document/follow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCurrentUserInfoResponse> GetCurrentUserInfo(Expression<Func<string>> cabGuid = null)
        {
            var apiCallPath = "/v1/User/info";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (cabGuid != null)
                callPayload.Queries["cabGuid"] = ExpressionConverter.Convert(cabGuid);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetCurrentUserInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction CheckinDoc(Expression<Func<string>> id, Expression<Func<string>> extension = null, Expression<Func<object>> file = null, Expression<Func<bool>> addToRecent = null)
        {
            var apiCallPath = "/v1/Document/checkin";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction CheckOutDoc(Expression<Func<string>> id, Expression<Func<string>> comment = null, Expression<Func<bool>> download = null, Expression<Func<string>> version = null, Expression<Func<bool>> addToRecent = null)
        {
            var apiCallPath = "/v1/Document/checkout";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateDocumentResponse> CreateDocument(Expression<Func<string>> destination, Expression<Func<object>> file, Expression<Func<bool>> addToRecent = null, Expression<Func<string>> profile = null)
        {
            var apiCallPath = "/v1/Document/upload";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<CreateDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction LockDocumentVersion(Expression<Func<string>> id, Expression<Func<int>> version, Expression<Func<string>> description = null)
        {
            var apiCallPath = "/v1/Document/lock";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetDocumentVersions(Expression<Func<string>> documentID)
        {
            var apiCallPath = String.Format("/v1/Document/{0}/versionList", ExpressionConverter.ConvertWithUrlEncoding(documentID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateSecuredLinkResponse> CreateSecuredLink(Expression<Func<string>> id, Expression<Func<string>> password = null, Expression<Func<string>> expirationdate = null, Expression<Func<string>> version = null, Expression<Func<bool>> download = null, Expression<Func<bool>> notifyme = null, Expression<Func<bool>> @lock = null)
        {
            var apiCallPath = "/v1/Document/createsecuredlink";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<CreateSecuredLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetDocHistory(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1/Document/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateWorkspaceParentChildResponse> CreateWorkspaceParentChild(Expression<Func<string>> cabinetID, Expression<Func<string>> parentID, Expression<Func<string>> childID)
        {
            var apiCallPath = String.Format("/v1/Workspace/{0}/{1}/{2}/info", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1), ExpressionConverter.ConvertWithUrlEncoding(childID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<CreateWorkspaceParentChildResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateWorkspaceSingleResponse> CreateWorkspaceSingle(Expression<Func<string>> cabinetID, Expression<Func<string>> parentID)
        {
            var apiCallPath = String.Format("/v1/Workspace/{0}/{1}/info", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<CreateWorkspaceSingleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetWorkspaceInformation(Expression<Func<string>> workspaceID)
        {
            var apiCallPath = String.Format("/v1/Workspace/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateChildEntryResponse> CreateChildEntry(Expression<Func<string>> repositoryID, Expression<Func<string>> childAttributeID, Expression<Func<string>> parentID, Expression<Func<string>> childID, Expression<Func<bool>> lookupEntryBodyaccessfilteredPermissions, Expression<Func<bool>> lookupEntryBodyaccessforcePermssions, Expression<Func<string>> lookupEntryBodydescription = null, Expression<Func<string>> lookupEntryBodytype = null, Expression<Func<bool>> lookupEntryBodylitigationHold = null, Expression<Func<string>> lookupEntryBodyclosedDate = null, Expression<Func<lookupEntryBodyaccesspermissionsInputItem[]>> lookupEntryBodyaccesspermissions = null)
        {
            var apiCallPath = String.Format("/v1/attributes/{0}/{1}/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(childAttributeID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1), ExpressionConverter.ConvertWithUrlEncoding(childID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetChildEntry(Expression<Func<string>> repositoryID, Expression<Func<string>> childAttributeID, Expression<Func<string>> parentID, Expression<Func<string>> childID)
        {
            var apiCallPath = String.Format("/v1/attributes/{0}/{1}/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(childAttributeID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1), ExpressionConverter.ConvertWithUrlEncoding(childID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<DeleteChildEntryResponse> DeleteChildEntry(Expression<Func<string>> repositoryID, Expression<Func<string>> childAttributeID, Expression<Func<string>> parentID, Expression<Func<string>> childID)
        {
            var apiCallPath = String.Format("/v1/attributes/{0}/{1}/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(childAttributeID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1), ExpressionConverter.ConvertWithUrlEncoding(childID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<DeleteChildEntryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateEntryResponse> CreateEntry(Expression<Func<string>> repositoryID, Expression<Func<string>> attributeID, Expression<Func<string>> parentID, Expression<Func<bool>> lookupEntryBodyaccessfilteredPermissions, Expression<Func<bool>> lookupEntryBodyaccessforcePermssions, Expression<Func<string>> lookupEntryBodydescription = null, Expression<Func<string>> lookupEntryBodytype = null, Expression<Func<bool>> lookupEntryBodylitigationHold = null, Expression<Func<string>> lookupEntryBodyclosedDate = null, Expression<Func<lookupEntryBodyaccesspermissionsInputItem[]>> lookupEntryBodyaccesspermissions = null)
        {
            var apiCallPath = String.Format("/v1/attributes/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(attributeID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetLookupEntry(Expression<Func<string>> repositoryID, Expression<Func<string>> attributeID, Expression<Func<string>> parentID, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null, Expression<Func<orderbyInput>> orderby = null)
        {
            var apiCallPath = String.Format("/v1/attributes/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(attributeID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<DeleteLookupEntryResponse> DeleteLookupEntry(Expression<Func<string>> repositoryID, Expression<Func<string>> attributeID, Expression<Func<string>> parentID)
        {
            var apiCallPath = String.Format("/v1/attributes/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(attributeID, 1), ExpressionConverter.ConvertWithUrlEncoding(parentID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<DeleteLookupEntryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<SearchLookupEntriesResponse> SearchLookupEntries(Expression<Func<string>> repositoryID, Expression<Func<string>> attributeID, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<int>> skip = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = String.Format("/v1/attributes/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(attributeID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction SearchCabinets(Expression<Func<string>> cabinets, Expression<Func<string>> q, Expression<Func<string>> select, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> skiptoken = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction RefreshWorkspace(Expression<Func<string>> workspaceID)
        {
            var apiCallPath = String.Format("/v1/Workspace/{0}", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction LockDocument(Expression<Func<string>> id, Expression<Func<string>> comment = null)
        {
            var apiCallPath = String.Format("/v2/document/{0}/lock", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (comment != null)
                callPayload.Queries["comment"] = ExpressionConverter.Convert(comment);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction UnockDocument(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v2/document/{0}/unlock", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetRepositoryLog(Expression<Func<string>> repositoryID, Expression<Func<logtypeInput>> logtype, Expression<Func<string>> start = null, Expression<Func<string>> end = null)
        {
            var apiCallPath = String.Format("/v1/Repository/{0}/log", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetRepositoryInformation(Expression<Func<string>> repositoryID)
        {
            var apiCallPath = String.Format("/v1/Repository/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetRepositoryUsersResponseItem[]> GetRepositoryUsers(Expression<Func<string>> repositoryID)
        {
            var apiCallPath = String.Format("/v1/Repository/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetRepositoryUsersResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<string[]> GetRepositoryGroups(Expression<Func<string>> repositoryID, Expression<Func<string>> filter = null, Expression<Func<string>> top = null, Expression<Func<bool>> paging = null, Expression<Func<string>> skiptoken = null, Expression<Func<returnInfoInput>> returnInfo = null)
        {
            var apiCallPath = String.Format("/v1/Repository/{0}/groups", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateRepositoryGroupResponse> CreateRepositoryGroup(Expression<Func<string>> repositoryID, Expression<Func<string>> name, Expression<Func<bool>> external, Expression<Func<bool>> hidden, Expression<Func<bool>> hideMembership)
        {
            var apiCallPath = String.Format("/v1/Repository/{0}/group", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
            return new ApiConnectionAction<CreateRepositoryGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction DeleteRepositoryGroup(Expression<Func<string>> repositoryID, Expression<Func<string>> groupID)
        {
            var apiCallPath = String.Format("/v1/Repository/{0}/group/{1}", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1), ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser(Expression<Func<string>> username, Expression<Func<string>> displayFirstName, Expression<Func<string>> displayLastName, Expression<Func<string>> email, Expression<Func<bool>> external, Expression<Func<bool>> sendWelcome, Expression<Func<string>> repository, Expression<Func<string>> displayMiddleName = null)
        {
            var apiCallPath = "/v1/User";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
            return new ApiConnectionAction<CreateUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction AddOrRemoveUserRepository(Expression<Func<string>> repositoryID, Expression<Func<actionInput>> action, Expression<Func<string>> member, Expression<Func<bool>> external, Expression<Func<bool>> deleteIfFederated = null)
        {
            var apiCallPath = String.Format("/v1/Repository/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(repositoryID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateCollabSpaceResponse> CreateCollabSpace(Expression<Func<string>> workspaceID, Expression<Func<string>> name, Expression<Func<string>> description = null)
        {
            var apiCallPath = String.Format("/v2/container/{0}/collabspace", ExpressionConverter.ConvertWithUrlEncoding(workspaceID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
            return new ApiConnectionAction<CreateCollabSpaceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetCabinetSettings(Expression<Func<string>> cabinetID)
        {
            var apiCallPath = String.Format("/v1/cabinet/{0}/settings", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetCabinetInformation(Expression<Func<string>> cabinetID)
        {
            var apiCallPath = String.Format("/v1/cabinet/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<JToken[]> GetCabinetCustomAttributes(Expression<Func<string>> cabinetID)
        {
            var apiCallPath = String.Format("/v1/cabinet/{0}/customAttributes", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCabinetDefaultAccessResponseItem[]> GetCabinetDefaultAccess(Expression<Func<string>> cabinetID)
        {
            var apiCallPath = String.Format("/v1/cabinet/{0}/membership", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetCabinetDefaultAccessResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction AddToOrRemoveGroupFromCabinet(Expression<Func<string>> cabinetID, Expression<Func<actionInput>> action, Expression<Func<string>> id, Expression<Func<bool>> view, Expression<Func<bool>> edit, Expression<Func<bool>> share, Expression<Func<bool>> administer, Expression<Func<bool>> noAccess)
        {
            var apiCallPath = String.Format("/v1/cabinet/{0}/membership", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetCabinetGroupsResponseItem[]> GetCabinetGroups(Expression<Func<string>> cabinetID)
        {
            var apiCallPath = String.Format("/v2/cabinet/{0}/groups", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetCabinetGroupsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<CreateCabinetExternalGroupResponse> CreateCabinetExternalGroup(Expression<Func<string>> cabinetID, Expression<Func<string>> name, Expression<Func<optionsInput>> options = null, Expression<Func<accessInput>> access = null, Expression<Func<string>> collaborationSpaceId = null, Expression<Func<collaborationspaceaccessInput>> collaborationspaceaccess = null, Expression<Func<string>> topwsattributegroupkey = null)
        {
            var apiCallPath = String.Format("/v2/cabinet/{0}/group/external", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
            return new ApiConnectionAction<CreateCabinetExternalGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction SearchCabinetModifyACLs(Expression<Func<string>> cabinetID, Expression<Func<string>> q, Expression<Func<modeInput>> mode, Expression<Func<string>> newAcl, Expression<Func<string>> email = null, Expression<Func<completionEmailInput>> completionEmail = null)
        {
            var apiCallPath = String.Format("/v1/Search/{0}", ExpressionConverter.ConvertWithUrlEncoding(cabinetID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction GetContainerContents(Expression<Func<string>> containerID, Expression<Func<string>> select, Expression<Func<int>> top = null, Expression<Func<string>> skiptoken = null, Expression<Func<string>> orderby = null)
        {
            var apiCallPath = String.Format("/v2/container/{0}", ExpressionConverter.ConvertWithUrlEncoding(containerID, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetGroupInformationResponse> GetGroupInformation(Expression<Func<string>> groupID, Expression<Func<bool>> cabMembership = null)
        {
            var apiCallPath = String.Format("/v1/Group/{0}/info", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["cabMembership"] = Convert.ToString(false);
            if (cabMembership != null)
                callPayload.Queries["cabMembership"] = ExpressionConverter.Convert(cabMembership);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetGroupInformationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IBodyWorkflowAction<GetGroupMembershipResponseItem[]> GetGroupMembership(Expression<Func<string>> groupID)
        {
            var apiCallPath = String.Format("/v1/Group/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction<GetGroupMembershipResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "netdocuments")]
        public IWorkflowAction AddOrRemoveGroupMember(Expression<Func<string>> groupID, Expression<Func<actionInput>> action, Expression<Func<string>> member)
        {
            var apiCallPath = String.Format("/v1/Group/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            callPayload.Headers["Content-Type"] = Convert.ToString("multipart/form-data");
            return new ApiConnectionAction(callPayload);
        }
    }

    public class NetdocumentsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger SearchCab(Expression<Func<string>> cabId, Expression<Func<string>> q, Expression<Func<orderbyInput>> orderby = null, Expression<Func<string>> top = null, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/v1/Search/{0}", ExpressionConverter.ConvertWithUrlEncoding(cabId, 1));
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
            return new ApiConnectionTrigger(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Netdocuments;

    public partial class WorkflowManagedActions
    {
        public NetdocumentsActions Netdocuments(string connectionId) => new NetdocumentsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NetdocumentsTriggers Netdocuments(string connectionId) => new NetdocumentsTriggers(connectionId);
    }
}