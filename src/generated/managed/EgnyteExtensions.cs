//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Egnyte
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EgnyteActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup([WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<bodymembersInputItem[]> bodymembers = null)
        {
            var apiCallPath = "/api-proxy/CreateGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
            if (bodymembers != null)
            {
                body["members"] = ExpressionConverter.ConvertO(bodymembers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateGroupResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<GroupInfoByIdResponse> GroupInfoById([WorkflowExpression] Func<string> bodyid)
        {
            var apiCallPath = "/api-proxy/GroupInfoById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupInfoByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ListGroupsResponse> ListGroups([WorkflowExpression] Func<int> bodystartIndex = null, [WorkflowExpression] Func<int> bodycount = null, [WorkflowExpression] Func<string> bodyfilter = null)
        {
            var apiCallPath = "/api-proxy/ListGroups";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystartIndex != null)
            {
                body["startIndex"] = ExpressionConverter.ConvertO(bodystartIndex);
                bodypropCount++;
            }

            if (bodycount != null)
            {
                body["count"] = ExpressionConverter.ConvertO(bodycount);
                bodypropCount++;
            }

            if (bodyfilter != null)
            {
                body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ListGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<UserInfoResponse> GetUser([WorkflowExpression] Func<int> bodyid)
        {
            var apiCallPath = "/api-proxy/GetUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<UserListResponse> GetUserList([WorkflowExpression] Func<int> bodystartIndex = null, [WorkflowExpression] Func<int> bodycount = null, [WorkflowExpression] Func<string> bodyfilter = null)
        {
            var apiCallPath = "/api-proxy/GetUserList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystartIndex != null)
            {
                body["startIndex"] = ExpressionConverter.ConvertO(bodystartIndex);
                bodypropCount++;
            }

            if (bodycount != null)
            {
                body["count"] = ExpressionConverter.ConvertO(bodycount);
                bodypropCount++;
            }

            if (bodyfilter != null)
            {
                body["filter"] = ExpressionConverter.ConvertO(bodyfilter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UserListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<UpdateUserResponse> UpdateUser([WorkflowExpression] Func<int> bodyid, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodynamegivenName = null, [WorkflowExpression] Func<string> bodynamefamilyName = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<bool> bodysendInvite = null, [WorkflowExpression] Func<bodylanguageInput> bodylanguage = null, [WorkflowExpression] Func<bodyauthTypeInput> bodyauthType = null, [WorkflowExpression] Func<bodyuserTypeInput> bodyuserType = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodyidpUserId = null, [WorkflowExpression] Func<string> bodyuserPrincipalName = null)
        {
            var apiCallPath = "/api-proxy/UpdateUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            var nameObject = new JObject();
            var nameObjectpropCount = 0;
            if (bodynamegivenName != null)
            {
                nameObject["givenName"] = ExpressionConverter.ConvertO(bodynamegivenName);
                nameObjectpropCount++;
            }

            if (bodynamefamilyName != null)
            {
                nameObject["familyName"] = ExpressionConverter.ConvertO(bodynamefamilyName);
                nameObjectpropCount++;
            }

            if (nameObjectpropCount > 0)
            {
                body["name"] = nameObject;
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            if (bodysendInvite != null)
            {
                body["sendInvite"] = ExpressionConverter.ConvertO(bodysendInvite);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodyauthType != null)
            {
                body["authType"] = ExpressionConverter.ConvertO(bodyauthType);
                bodypropCount++;
            }

            if (bodyuserType != null)
            {
                body["userType"] = ExpressionConverter.ConvertO(bodyuserType);
                bodypropCount++;
            }

            if (bodyrole != null)
            {
                body["role"] = ExpressionConverter.ConvertO(bodyrole);
                bodypropCount++;
            }

            if (bodyidpUserId != null)
            {
                body["idpUserId"] = ExpressionConverter.ConvertO(bodyidpUserId);
                bodypropCount++;
            }

            if (bodyuserPrincipalName != null)
            {
                body["userPrincipalName"] = ExpressionConverter.ConvertO(bodyuserPrincipalName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser([WorkflowExpression] Func<string> bodyuserName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<bool> bodyactive, [WorkflowExpression] Func<bodyuserTypeInput> bodyuserType, [WorkflowExpression] Func<bodyauthTypeInput> bodyauthType, [WorkflowExpression] Func<string> bodynamegivenName = null, [WorkflowExpression] Func<string> bodynamefamilyName = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<bool> bodysendInvite = null, [WorkflowExpression] Func<bool> bodyisServiceAccount = null, [WorkflowExpression] Func<bodylanguageInput> bodylanguage = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodyidpUserId = null, [WorkflowExpression] Func<string> bodyuserPrincipalName = null)
        {
            var apiCallPath = "/api-proxy/CreateUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["userName"] = ExpressionConverter.ConvertO(bodyuserName);
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            var nameObject = new JObject();
            var nameObjectpropCount = 0;
            if (bodynamegivenName != null)
            {
                nameObject["givenName"] = ExpressionConverter.ConvertO(bodynamegivenName);
                nameObjectpropCount++;
            }

            if (bodynamefamilyName != null)
            {
                nameObject["familyName"] = ExpressionConverter.ConvertO(bodynamefamilyName);
                nameObjectpropCount++;
            }

            if (nameObjectpropCount > 0)
            {
                body["name"] = nameObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["active"] = ExpressionConverter.ConvertO(bodyactive);
            bodypropCount++;
            body["userType"] = ExpressionConverter.ConvertO(bodyuserType);
            bodypropCount++;
            body["authType"] = ExpressionConverter.ConvertO(bodyauthType);
            if (bodyexternalId != null)
            {
                body["externalId"] = ExpressionConverter.ConvertO(bodyexternalId);
                bodypropCount++;
            }

            if (bodysendInvite != null)
            {
                body["sendInvite"] = ExpressionConverter.ConvertO(bodysendInvite);
                bodypropCount++;
            }

            if (bodyisServiceAccount != null)
            {
                body["isServiceAccount"] = ExpressionConverter.ConvertO(bodyisServiceAccount);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodyrole != null)
            {
                body["role"] = ExpressionConverter.ConvertO(bodyrole);
                bodypropCount++;
            }

            if (bodyidpUserId != null)
            {
                body["idpUserId"] = ExpressionConverter.ConvertO(bodyidpUserId);
                bodypropCount++;
            }

            if (bodyuserPrincipalName != null)
            {
                body["userPrincipalName"] = ExpressionConverter.ConvertO(bodyuserPrincipalName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction DeleteUser([WorkflowExpression] Func<int> bodyid)
        {
            var apiCallPath = "/api-proxy/DeleteUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateFolderResponse> CreateFolder([WorkflowExpression] Func<string> bodypath)
        {
            var apiCallPath = "/api-proxy/CreateFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeleteFileByPathResponse> DeleteFileByPath([WorkflowExpression] Func<string> bodypath)
        {
            var apiCallPath = "/api-proxy/DeleteFileByPath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DeleteFileByPathResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeleteFolderByPathResponse> DeleteFolderByPath([WorkflowExpression] Func<string> bodypath)
        {
            var apiCallPath = "/api-proxy/DeleteFolderByPath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DeleteFolderByPathResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeleteFolderByIdResponse> DeleteFolderById([WorkflowExpression] Func<string> bodyid)
        {
            var apiCallPath = "/api-proxy/DeleteFolderById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DeleteFolderByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeleteFileByIdResponse> DeleteFileById([WorkflowExpression] Func<string> bodyid)
        {
            var apiCallPath = "/api-proxy/DeleteFileById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DeleteFileByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CopyFileByPathResponse> CopyFileByPath([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            var apiCallPath = "/api-proxy/CopyFileByPath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            bodypropCount++;
            body["destination_path"] = ExpressionConverter.ConvertO(bodydestinationPath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CopyFileByPathResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CopyFolderByPathResponse> CopyFolderByPath([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            var apiCallPath = "/api-proxy/CopyFolderByPath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            bodypropCount++;
            body["destination_path"] = ExpressionConverter.ConvertO(bodydestinationPath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CopyFolderByPathResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FullGroupUpdateResponse> FullGroupUpdate([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<bodymembersInputItem2[]> bodymembers = null)
        {
            var apiCallPath = "/api-proxy/FullGroupUpdate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
            if (bodymembers != null)
            {
                body["members"] = ExpressionConverter.ConvertO(bodymembers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FullGroupUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<PartialGroupUpdateResponse> PartialGroupUpdate([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<bodymembersInputItem22[]> bodymembers = null)
        {
            var apiCallPath = "/api-proxy/PartialGroupUpdate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodydisplayName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                bodypropCount++;
            }

            if (bodymembers != null)
            {
                body["members"] = ExpressionConverter.ConvertO(bodymembers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PartialGroupUpdateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction DeleteGroup([WorkflowExpression] Func<string> bodyid)
        {
            var apiCallPath = "/api-proxy/DeleteGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CopyFileByIdResponse> CopyFileById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            var apiCallPath = "/api-proxy/CopyFileById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["destination_path"] = ExpressionConverter.ConvertO(bodydestinationPath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CopyFileByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CopyFolderByIdResponse> CopyFolderById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            var apiCallPath = "/api-proxy/CopyFolderById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["destination_path"] = ExpressionConverter.ConvertO(bodydestinationPath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CopyFolderByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MoveFileByPathResponse> MoveFileByPath([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            var apiCallPath = "/api-proxy/MoveFileByPath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            bodypropCount++;
            body["destination_path"] = ExpressionConverter.ConvertO(bodydestinationPath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MoveFileByPathResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MoveFolderByPathResponse> MoveFolderByPath([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            var apiCallPath = "/api-proxy/MoveFolderByPath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            bodypropCount++;
            body["destination_path"] = ExpressionConverter.ConvertO(bodydestinationPath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MoveFolderByPathResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MoveFileByIdResponse> MoveFileById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            var apiCallPath = "/api-proxy/MoveFileById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["destination_path"] = ExpressionConverter.ConvertO(bodydestinationPath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MoveFileByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MoveFolderByIdResponse> MoveFolderById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            var apiCallPath = "/api-proxy/MoveFolderById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["destination_path"] = ExpressionConverter.ConvertO(bodydestinationPath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MoveFolderByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ShareFileResponse> ShareFile([WorkflowExpression] Func<string> bodypath)
        {
            var apiCallPath = "/api-proxy/ShareFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ShareFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ShareFolderResponse> ShareFolder([WorkflowExpression] Func<string> bodypath)
        {
            var apiCallPath = "/api-proxy/ShareFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ShareFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FileInfoResponse> FileInfoByPath([WorkflowExpression] Func<string> bodypath)
        {
            var apiCallPath = "/api-proxy/FileInfoByPath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FileInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FolderInfoResponse> FolderInfoByPath([WorkflowExpression] Func<string> bodypath)
        {
            var apiCallPath = "/api-proxy/FolderInfoByPath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FolderInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ModifyFolderOptionsResponse> ModifyFolderOptions([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodyfolderDescription = null, [WorkflowExpression] Func<bool> bodyallowLinks = null, [WorkflowExpression] Func<bodypublicLinksInput> bodypublicLinks = null, [WorkflowExpression] Func<bool> bodyrestrictMoveDelete = null, [WorkflowExpression] Func<bool> bodyemailPreferencescontentUpdates = null, [WorkflowExpression] Func<bool> bodyemailPreferencescontentAccessed = null)
        {
            var apiCallPath = "/api-proxy/ModifyFolderOptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            if (bodyfolderDescription != null)
            {
                body["folder_description"] = ExpressionConverter.ConvertO(bodyfolderDescription);
                bodypropCount++;
            }

            if (bodyallowLinks != null)
            {
                body["allow_links"] = ExpressionConverter.ConvertO(bodyallowLinks);
                bodypropCount++;
            }

            if (bodypublicLinks != null)
            {
                body["public_links"] = ExpressionConverter.ConvertO(bodypublicLinks);
                bodypropCount++;
            }

            if (bodyrestrictMoveDelete != null)
            {
                body["restrict_move_delete"] = ExpressionConverter.ConvertO(bodyrestrictMoveDelete);
                bodypropCount++;
            }

            var emailPreferencesObject = new JObject();
            var emailPreferencesObjectpropCount = 0;
            if (bodyemailPreferencescontentUpdates != null)
            {
                emailPreferencesObject["content_updates"] = ExpressionConverter.ConvertO(bodyemailPreferencescontentUpdates);
                emailPreferencesObjectpropCount++;
            }

            if (bodyemailPreferencescontentAccessed != null)
            {
                emailPreferencesObject["content_accessed"] = ExpressionConverter.ConvertO(bodyemailPreferencescontentAccessed);
                emailPreferencesObjectpropCount++;
            }

            if (emailPreferencesObjectpropCount > 0)
            {
                body["email_preferences"] = emailPreferencesObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ModifyFolderOptionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FileInfoResponse> FileInfoById([WorkflowExpression] Func<string> bodyid)
        {
            var apiCallPath = "/api-proxy/FileInfoById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FileInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FolderInfoResponse> FolderInfoById([WorkflowExpression] Func<string> bodyid)
        {
            var apiCallPath = "/api-proxy/FolderInfoById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FolderInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<LockFileByPathResponse> LockFileByPath([WorkflowExpression] Func<string> bodypath)
        {
            var apiCallPath = "/api-proxy/LockFileByPath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<LockFileByPathResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction UnlockFileByPath([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodylockToken)
        {
            var apiCallPath = "/api-proxy/UnlockFileByPath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            bodypropCount++;
            body["lock_token"] = ExpressionConverter.ConvertO(bodylockToken);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<LockFileByIdResponse> LockFileById([WorkflowExpression] Func<string> bodyid)
        {
            var apiCallPath = "/api-proxy/LockFileById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<LockFileByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction UnlockFileById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylockToken)
        {
            var apiCallPath = "/api-proxy/UnlockFileById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["lock_token"] = ExpressionConverter.ConvertO(bodylockToken);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction GetFileContentByPath([WorkflowExpression] Func<string> bodyfilePath)
        {
            var apiCallPath = "/api-proxy/DownloadFileByPath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["filePath"] = ExpressionConverter.ConvertO(bodyfilePath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction GetFileContentById([WorkflowExpression] Func<string> bodyfileId)
        {
            var apiCallPath = "/api-proxy/DownloadFileById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["fileId"] = ExpressionConverter.ConvertO(bodyfileId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateFileResponse> CreateFile([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<string> body = null)
        {
            var apiCallPath = "/api-proxy/UploadFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Name"] = ExpressionConverter.Convert(name);
            callPayload.Queries["Path"] = ExpressionConverter.Convert(path);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<CreateFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction SetMetadataByFileId([WorkflowExpression] Func<string> bodyfileId, [WorkflowExpression] Func<string> bodynamespaceName, [WorkflowExpression] Func<string> bodymetadataName, [WorkflowExpression] Func<string> bodymetadataValue = null)
        {
            var apiCallPath = "/api-proxy/SetMetadataByFileId";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["fileId"] = ExpressionConverter.ConvertO(bodyfileId);
            bodypropCount++;
            body["namespaceName"] = ExpressionConverter.ConvertO(bodynamespaceName);
            bodypropCount++;
            body["metadataName"] = ExpressionConverter.ConvertO(bodymetadataName);
            if (bodymetadataValue != null)
            {
                body["metadataValue"] = ExpressionConverter.ConvertO(bodymetadataValue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction SetMetadataByFolderId([WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodynamespaceName, [WorkflowExpression] Func<string> bodymetadataName, [WorkflowExpression] Func<string> bodymetadataValue)
        {
            var apiCallPath = "/api-proxy/SetMetadataByFolderId";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
            bodypropCount++;
            body["namespaceName"] = ExpressionConverter.ConvertO(bodynamespaceName);
            bodypropCount++;
            body["metadataName"] = ExpressionConverter.ConvertO(bodymetadataName);
            bodypropCount++;
            body["metadataValue"] = ExpressionConverter.ConvertO(bodymetadataValue);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<NamespaceItem[]> GetAllNamespaces()
        {
            var apiCallPath = "/api-proxy/GetAllNamespaces";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<NamespaceItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction CreateNamespace([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodyscopeInput> bodyscope, [WorkflowExpression] Func<bodykeysInputItem[]> bodykeys, [WorkflowExpression] Func<string> bodydisplayName = null)
        {
            var apiCallPath = "/api-proxy/CreateNamespace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodydisplayName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                bodypropCount++;
            }

            bodypropCount++;
            body["scope"] = ExpressionConverter.ConvertO(bodyscope);
            bodypropCount++;
            body["keys"] = ExpressionConverter.ConvertO(bodykeys);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<NamespaceItem> UpdateNamespaceAttributes([WorkflowExpression] Func<string> bodyNamespace, [WorkflowExpression] Func<string> bodydisplayName = null)
        {
            var apiCallPath = "/api-proxy/UpdateNamespaceAttributes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["namespace"] = ExpressionConverter.ConvertO(bodyNamespace);
            if (bodydisplayName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                bodypropCount++;
            }

            var prioritiesObject = new JObject();
            var prioritiesObjectpropCount = 0;
            if (prioritiesObjectpropCount > 0)
            {
                body["priorities"] = prioritiesObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NamespaceItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<UpdateNamespaceKeysResponse> UpdateNamespaceKeys([WorkflowExpression] Func<string> bodyNamespace, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<double> bodypriority = null, [WorkflowExpression] Func<string> bodydata = null, [WorkflowExpression] Func<string> bodyhelpText = null)
        {
            var apiCallPath = "/api-proxy/UpdateNamespaceKeys";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["namespace"] = ExpressionConverter.ConvertO(bodyNamespace);
            bodypropCount++;
            body["key"] = ExpressionConverter.ConvertO(bodykey);
            if (bodydisplayName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                bodypropCount++;
            }

            if (bodyhelpText != null)
            {
                body["helpText"] = ExpressionConverter.ConvertO(bodyhelpText);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateNamespaceKeysResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<NamespaceItem> GetNamespace([WorkflowExpression] Func<string> bodyNamespace)
        {
            var apiCallPath = "/api-proxy/GetNamespace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["namespace"] = ExpressionConverter.ConvertO(bodyNamespace);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NamespaceItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction DeleteNamespace([WorkflowExpression] Func<string> bodyNamespace, [WorkflowExpression] Func<bool> bodyforce = null)
        {
            var apiCallPath = "/api-proxy/DeleteNamespace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["namespace"] = ExpressionConverter.ConvertO(bodyNamespace);
            if (bodyforce != null)
            {
                body["force"] = ExpressionConverter.ConvertO(bodyforce);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ProjectItem[]> GetAllProjects()
        {
            var apiCallPath = "/api-proxy/GetAllProjects";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProjectItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MarkFolderAsProjectResponse> MarkFolderAsProject([WorkflowExpression] Func<string> bodyrootFolderId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodycompletionDate = null)
        {
            var apiCallPath = "/api-proxy/MarkFolderAsProject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["rootFolderId"] = ExpressionConverter.ConvertO(bodyrootFolderId);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodycompletionDate != null)
            {
                body["completionDate"] = ExpressionConverter.ConvertO(bodycompletionDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MarkFolderAsProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateProjectFromTemplateResponse> CreateProjectFromTemplate([WorkflowExpression] Func<string> bodyparentFolderId, [WorkflowExpression] Func<string> bodytemplateFolderId, [WorkflowExpression] Func<string> bodyfolderName, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<string> bodycustomerName = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodycompletionDate = null, [WorkflowExpression] Func<string> bodylocationstreetAddress1 = null, [WorkflowExpression] Func<string> bodylocationstreetAddress2 = null, [WorkflowExpression] Func<string> bodylocationcity = null, [WorkflowExpression] Func<string> bodylocationstate = null, [WorkflowExpression] Func<string> bodylocationcountry = null, [WorkflowExpression] Func<string> bodylocationpostalCode = null)
        {
            var apiCallPath = "/api-proxy/CreateProjectFromTemplate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parentFolderId"] = ExpressionConverter.ConvertO(bodyparentFolderId);
            bodypropCount++;
            body["templateFolderId"] = ExpressionConverter.ConvertO(bodytemplateFolderId);
            bodypropCount++;
            body["folderName"] = ExpressionConverter.ConvertO(bodyfolderName);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            if (bodycustomerName != null)
            {
                body["customerName"] = ExpressionConverter.ConvertO(bodycustomerName);
                bodypropCount++;
            }

            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodycompletionDate != null)
            {
                body["completionDate"] = ExpressionConverter.ConvertO(bodycompletionDate);
                bodypropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodylocationstreetAddress1 != null)
            {
                locationObject["streetAddress1"] = ExpressionConverter.ConvertO(bodylocationstreetAddress1);
                locationObjectpropCount++;
            }

            if (bodylocationstreetAddress2 != null)
            {
                locationObject["streetAddress2"] = ExpressionConverter.ConvertO(bodylocationstreetAddress2);
                locationObjectpropCount++;
            }

            if (bodylocationcity != null)
            {
                locationObject["city"] = ExpressionConverter.ConvertO(bodylocationcity);
                locationObjectpropCount++;
            }

            if (bodylocationstate != null)
            {
                locationObject["state"] = ExpressionConverter.ConvertO(bodylocationstate);
                locationObjectpropCount++;
            }

            if (bodylocationcountry != null)
            {
                locationObject["country"] = ExpressionConverter.ConvertO(bodylocationcountry);
                locationObjectpropCount++;
            }

            if (bodylocationpostalCode != null)
            {
                locationObject["postalCode"] = ExpressionConverter.ConvertO(bodylocationpostalCode);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                body["location"] = locationObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateProjectFromTemplateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ProjectItem> GetProjectById([WorkflowExpression] Func<string> bodyprojectId)
        {
            var apiCallPath = "/api-proxy/GetProjectById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ProjectItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction UpdateProjectById([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodycustomProjectId = null, [WorkflowExpression] Func<string> bodycustomerName = null, [WorkflowExpression] Func<string> bodylocationstreetAddress1 = null, [WorkflowExpression] Func<string> bodylocationstreetAddress2 = null, [WorkflowExpression] Func<string> bodylocationcity = null, [WorkflowExpression] Func<string> bodylocationstate = null, [WorkflowExpression] Func<string> bodylocationpostalCode = null, [WorkflowExpression] Func<string> bodylocationcountry = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodycompletionDate = null)
        {
            var apiCallPath = "/api-proxy/UpdateProjectById";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            bodypropCount++;
            body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
            if (bodycustomProjectId != null)
            {
                body["customProjectId"] = ExpressionConverter.ConvertO(bodycustomProjectId);
                bodypropCount++;
            }

            if (bodycustomerName != null)
            {
                body["customerName"] = ExpressionConverter.ConvertO(bodycustomerName);
                bodypropCount++;
            }

            var locationObject = new JObject();
            var locationObjectpropCount = 0;
            if (bodylocationstreetAddress1 != null)
            {
                locationObject["streetAddress1"] = ExpressionConverter.ConvertO(bodylocationstreetAddress1);
                locationObjectpropCount++;
            }

            if (bodylocationstreetAddress2 != null)
            {
                locationObject["streetAddress2"] = ExpressionConverter.ConvertO(bodylocationstreetAddress2);
                locationObjectpropCount++;
            }

            if (bodylocationcity != null)
            {
                locationObject["city"] = ExpressionConverter.ConvertO(bodylocationcity);
                locationObjectpropCount++;
            }

            if (bodylocationstate != null)
            {
                locationObject["state"] = ExpressionConverter.ConvertO(bodylocationstate);
                locationObjectpropCount++;
            }

            if (bodylocationpostalCode != null)
            {
                locationObject["postalCode"] = ExpressionConverter.ConvertO(bodylocationpostalCode);
                locationObjectpropCount++;
            }

            if (bodylocationcountry != null)
            {
                locationObject["country"] = ExpressionConverter.ConvertO(bodylocationcountry);
                locationObjectpropCount++;
            }

            if (locationObjectpropCount > 0)
            {
                body["location"] = locationObject;
                bodypropCount++;
            }

            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodystartDate != null)
            {
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
            }

            if (bodycompletionDate != null)
            {
                body["completionDate"] = ExpressionConverter.ConvertO(bodycompletionDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction DeleteProjectById([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> projectId)
        {
            var apiCallPath = String.Format("/api-proxy/DeleteProjectById/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ProjectItem> GetProjectByRootFolderId([WorkflowExpression] Func<string> bodyrootFolderId)
        {
            var apiCallPath = "/api-proxy/GetProjectByRootFolderId";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["rootFolderId"] = ExpressionConverter.ConvertO(bodyrootFolderId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ProjectItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CleanupProjectResponse> CleanupProject([WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<bool> bodydeleteLinks, [WorkflowExpression] Func<int[]> bodyusersToDelete = null, [WorkflowExpression] Func<int[]> bodyusersToDisable = null)
        {
            var apiCallPath = "/api-proxy/CleanupProject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["projectId"] = ExpressionConverter.ConvertO(bodyprojectId);
            bodypropCount++;
            body["deleteLinks"] = ExpressionConverter.ConvertO(bodydeleteLinks);
            if (bodyusersToDelete != null)
            {
                body["usersToDelete"] = ExpressionConverter.ConvertO(bodyusersToDelete);
                bodypropCount++;
            }

            if (bodyusersToDisable != null)
            {
                body["usersToDisable"] = ExpressionConverter.ConvertO(bodyusersToDisable);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CleanupProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction CreateMetadataKey([WorkflowExpression] Func<string> bodyNamespace, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<double> bodypriority = null, [WorkflowExpression] Func<string> bodyhelpText = null, [WorkflowExpression] Func<string[]> bodydata = null)
        {
            var apiCallPath = "/api-proxy/CreateMetadataKey";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["namespace"] = ExpressionConverter.ConvertO(bodyNamespace);
            bodypropCount++;
            body["key"] = ExpressionConverter.ConvertO(bodykey);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodydisplayName != null)
            {
                body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodyhelpText != null)
            {
                body["helpText"] = ExpressionConverter.ConvertO(bodyhelpText);
                bodypropCount++;
            }

            if (bodydata != null)
            {
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction DeleteMetadataKey([WorkflowExpression] Func<string> bodyNamespace, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<bool> bodyforce = null)
        {
            var apiCallPath = "/api-proxy/DeleteMetadataKey";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["namespace"] = ExpressionConverter.ConvertO(bodyNamespace);
            bodypropCount++;
            body["key"] = ExpressionConverter.ConvertO(bodykey);
            if (bodyforce != null)
            {
                body["force"] = ExpressionConverter.ConvertO(bodyforce);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction GetMetadataByFileId([WorkflowExpression] Func<string> bodyfileId, [WorkflowExpression] Func<string> bodyNamespace)
        {
            var apiCallPath = "/api-proxy/GetMetadataByFileId";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["fileId"] = ExpressionConverter.ConvertO(bodyfileId);
            bodypropCount++;
            body["namespace"] = ExpressionConverter.ConvertO(bodyNamespace);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction GetMetadataByFolderId([WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodyNamespace)
        {
            var apiCallPath = "/api-proxy/GetMetadataByFolderId";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
            bodypropCount++;
            body["namespace"] = ExpressionConverter.ConvertO(bodyNamespace);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction SearchMetadata([WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<bodyhasKeyInputItem[]> bodyhasKey = null, [WorkflowExpression] Func<bodykeyWithValueInputItem[]> bodykeyWithValue = null)
        {
            var apiCallPath = "/api-proxy/SearchMetadata";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyhasKey != null)
            {
                body["hasKey"] = ExpressionConverter.ConvertO(bodyhasKey);
                bodypropCount++;
            }

            if (bodykeyWithValue != null)
            {
                body["keyWithValue"] = ExpressionConverter.ConvertO(bodykeyWithValue);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<GetEffectivePermissionsResponse> GetEffectivePermissions([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodyusername)
        {
            var apiCallPath = "/api-proxy/GetEffectivePermissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            bodypropCount++;
            body["username"] = ExpressionConverter.ConvertO(bodyusername);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetEffectivePermissionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction SetFolderPermissions([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<bool> bodyinheritsPermissions = null, [WorkflowExpression] Func<bool> bodykeepParentPermissions = null)
        {
            var apiCallPath = "/api-proxy/SetFolderPermissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            var userPermsObject = new JObject();
            var userPermsObjectpropCount = 0;
            if (userPermsObjectpropCount > 0)
            {
                body["userPerms"] = userPermsObject;
                bodypropCount++;
            }

            var groupPermsObject = new JObject();
            var groupPermsObjectpropCount = 0;
            if (groupPermsObjectpropCount > 0)
            {
                body["groupPerms"] = groupPermsObject;
                bodypropCount++;
            }

            if (bodyinheritsPermissions != null)
            {
                body["inheritsPermissions"] = ExpressionConverter.ConvertO(bodyinheritsPermissions);
                bodypropCount++;
            }

            if (bodykeepParentPermissions != null)
            {
                body["keepParentPermissions"] = ExpressionConverter.ConvertO(bodykeepParentPermissions);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<GetFolderPermissionsResponse> GetFolderPermissions([WorkflowExpression] Func<string> bodypath)
        {
            var apiCallPath = "/api-proxy/GetFolderPermissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetFolderPermissionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeepLinksByIdResponse> DeepLinksById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bodytypeInput> bodytype)
        {
            var apiCallPath = "/api-proxy/DeepLinksById";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DeepLinksByIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeepLinksByPathResponse> DeepLinksByPath([WorkflowExpression] Func<string> bodypath)
        {
            var apiCallPath = "/api-proxy/DeepLinksByPath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DeepLinksByPathResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ListLinksResponse> ListLinks([WorkflowExpression] Func<string> bodypath = null, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<string> bodycreatedBefore = null, [WorkflowExpression] Func<string> bodycreatedAfter = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<bodyaccessibilityInput> bodyaccessibility = null, [WorkflowExpression] Func<string> bodyoffset = null, [WorkflowExpression] Func<string> bodycount = null)
        {
            var apiCallPath = "/api-proxy/ListLinks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypath != null)
            {
                body["path"] = ExpressionConverter.ConvertO(bodypath);
                bodypropCount++;
            }

            if (bodyusername != null)
            {
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
            }

            if (bodycreatedBefore != null)
            {
                body["createdBefore"] = ExpressionConverter.ConvertO(bodycreatedBefore);
                bodypropCount++;
            }

            if (bodycreatedAfter != null)
            {
                body["createdAfter"] = ExpressionConverter.ConvertO(bodycreatedAfter);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyaccessibility != null)
            {
                body["accessibility"] = ExpressionConverter.ConvertO(bodyaccessibility);
                bodypropCount++;
            }

            if (bodyoffset != null)
            {
                body["offset"] = ExpressionConverter.ConvertO(bodyoffset);
                bodypropCount++;
            }

            if (bodycount != null)
            {
                body["count"] = ExpressionConverter.ConvertO(bodycount);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ListLinksResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ShowLinkDetailsResponse> ShowLinkDetails([WorkflowExpression] Func<string> bodylinkId)
        {
            var apiCallPath = "/api-proxy/ShowLinkDetails";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["linkId"] = ExpressionConverter.ConvertO(bodylinkId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ShowLinkDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateLinkResponse> CreateLink([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<bool> bodyuseDefaultSettings, [WorkflowExpression] Func<bodyaccessibilityInput> bodyaccessibility = null, [WorkflowExpression] Func<bool> bodysendEmail = null, [WorkflowExpression] Func<string[]> bodyrecipients = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<bool> bodycopyMe = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bool> bodylinkToCurrent = null, [WorkflowExpression] Func<string> bodyexpiryDate = null, [WorkflowExpression] Func<double> bodyexpiryClicks = null, [WorkflowExpression] Func<bool> bodyaddFileName = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<bodyprotectionInput> bodyprotection = null, [WorkflowExpression] Func<bool> bodyfolderPerRecipient = null)
        {
            var apiCallPath = "/api-proxy/CreateLink";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["path"] = ExpressionConverter.ConvertO(bodypath);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodyaccessibility != null)
            {
                body["accessibility"] = ExpressionConverter.ConvertO(bodyaccessibility);
                bodypropCount++;
            }

            bodypropCount++;
            body["useDefaultSettings"] = ExpressionConverter.ConvertO(bodyuseDefaultSettings);
            if (bodysendEmail != null)
            {
                body["send_email"] = ExpressionConverter.ConvertO(bodysendEmail);
                bodypropCount++;
            }

            if (bodyrecipients != null)
            {
                body["recipients"] = ExpressionConverter.ConvertO(bodyrecipients);
                bodypropCount++;
            }

            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodycopyMe != null)
            {
                body["copy_me"] = ExpressionConverter.ConvertO(bodycopyMe);
                bodypropCount++;
            }

            if (bodynotify != null)
            {
                body["notify"] = ExpressionConverter.ConvertO(bodynotify);
                bodypropCount++;
            }

            if (bodylinkToCurrent != null)
            {
                body["link_to_current"] = ExpressionConverter.ConvertO(bodylinkToCurrent);
                bodypropCount++;
            }

            if (bodyexpiryDate != null)
            {
                body["expiry_date"] = ExpressionConverter.ConvertO(bodyexpiryDate);
                bodypropCount++;
            }

            if (bodyexpiryClicks != null)
            {
                body["expiry_clicks"] = ExpressionConverter.ConvertO(bodyexpiryClicks);
                bodypropCount++;
            }

            if (bodyaddFileName != null)
            {
                body["add_file_name"] = ExpressionConverter.ConvertO(bodyaddFileName);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodyprotection != null)
            {
                body["protection"] = ExpressionConverter.ConvertO(bodyprotection);
                bodypropCount++;
            }

            if (bodyfolderPerRecipient != null)
            {
                body["folder_per_recipient"] = ExpressionConverter.ConvertO(bodyfolderPerRecipient);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateLinkResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction DeleteLink([WorkflowExpression] Func<string> bodylinkId)
        {
            var apiCallPath = "/api-proxy/DeleteLink";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["linkId"] = ExpressionConverter.ConvertO(bodylinkId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AIQuestionResponse> AskDocumentQuestion([WorkflowExpression] Func<string> bodyentryId = null, [WorkflowExpression] Func<string> bodyquestion = null, [WorkflowExpression] Func<bool> bodyincludeCitations = null, [WorkflowExpression] Func<AIMessage[]> bodychatHistorymessages = null)
        {
            var apiCallPath = "/api-proxy/AskDocumentQuestion";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyentryId != null)
            {
                body["entryId"] = ExpressionConverter.ConvertO(bodyentryId);
                bodypropCount++;
            }

            if (bodyquestion != null)
            {
                body["question"] = ExpressionConverter.ConvertO(bodyquestion);
                bodypropCount++;
            }

            if (bodyincludeCitations != null)
            {
                if (bodyincludeCitations != null)
                {
                    body["includeCitations"] = ExpressionConverter.ConvertO(bodyincludeCitations);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["includeCitations"] = false;
                bodypropCount++;
            }

            var chatHistoryObject = new JObject();
            var chatHistoryObjectpropCount = 0;
            if (bodychatHistorymessages != null)
            {
                chatHistoryObject["messages"] = ExpressionConverter.ConvertO(bodychatHistorymessages);
                chatHistoryObjectpropCount++;
            }

            if (chatHistoryObjectpropCount > 0)
            {
                body["chatHistory"] = chatHistoryObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AIQuestionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AISummaryResponse> SummarizeDocument([WorkflowExpression] Func<string> bodyentryId = null, [WorkflowExpression] Func<AIMessage[]> bodychatHistorymessages = null)
        {
            var apiCallPath = "/api-proxy/SummarizeDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyentryId != null)
            {
                body["entryId"] = ExpressionConverter.ConvertO(bodyentryId);
                bodypropCount++;
            }

            var chatHistoryObject = new JObject();
            var chatHistoryObjectpropCount = 0;
            if (bodychatHistorymessages != null)
            {
                chatHistoryObject["messages"] = ExpressionConverter.ConvertO(bodychatHistorymessages);
                chatHistoryObjectpropCount++;
            }

            if (chatHistoryObjectpropCount > 0)
            {
                body["chatHistory"] = chatHistoryObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AISummaryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AICopilotResponse> CopilotAsk([WorkflowExpression] Func<string> bodyquestion = null, [WorkflowExpression] Func<bodyselectedItemsfoldersInputItem[]> bodyselectedItemsfolders = null, [WorkflowExpression] Func<bodyselectedItemsfilesInputItem[]> bodyselectedItemsfiles = null, [WorkflowExpression] Func<bool> bodyincludeCitations = null, [WorkflowExpression] Func<AIMessage[]> bodychatHistorymessages = null)
        {
            var apiCallPath = "/api-proxy/CopilotAsk";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyquestion != null)
            {
                body["question"] = ExpressionConverter.ConvertO(bodyquestion);
                bodypropCount++;
            }

            var selectedItemsObject = new JObject();
            var selectedItemsObjectpropCount = 0;
            if (bodyselectedItemsfolders != null)
            {
                selectedItemsObject["folders"] = ExpressionConverter.ConvertO(bodyselectedItemsfolders);
                selectedItemsObjectpropCount++;
            }

            if (bodyselectedItemsfiles != null)
            {
                selectedItemsObject["files"] = ExpressionConverter.ConvertO(bodyselectedItemsfiles);
                selectedItemsObjectpropCount++;
            }

            if (selectedItemsObjectpropCount > 0)
            {
                body["selectedItems"] = selectedItemsObject;
                bodypropCount++;
            }

            if (bodyincludeCitations != null)
            {
                if (bodyincludeCitations != null)
                {
                    body["includeCitations"] = ExpressionConverter.ConvertO(bodyincludeCitations);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["includeCitations"] = false;
                bodypropCount++;
            }

            var chatHistoryObject = new JObject();
            var chatHistoryObjectpropCount = 0;
            if (bodychatHistorymessages != null)
            {
                chatHistoryObject["messages"] = ExpressionConverter.ConvertO(bodychatHistorymessages);
                chatHistoryObjectpropCount++;
            }

            if (chatHistoryObjectpropCount > 0)
            {
                body["chatHistory"] = chatHistoryObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AICopilotResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<SearchV2Response> Search([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<int> bodyoffset = null, [WorkflowExpression] Func<int> bodycount = null, [WorkflowExpression] Func<string> bodyfolder = null, [WorkflowExpression] Func<int> bodymodifiedBefore = null, [WorkflowExpression] Func<int> bodymodifiedAfter = null, [WorkflowExpression] Func<int> bodyuploadedBefore = null, [WorkflowExpression] Func<int> bodyuploadedAfter = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<bool> bodysnippetRequested = null, [WorkflowExpression] Func<bodysortByInput> bodysortBy = null, [WorkflowExpression] Func<bodysortDirectionInput> bodysortDirection = null, [WorkflowExpression] Func<bodyfileQueryFieldsInputItem[]> bodyfileQueryFields = null, [WorkflowExpression] Func<bodyfolderQueryFieldsInputItem[]> bodyfolderQueryFields = null, [WorkflowExpression] Func<bodyqueryOperatorInput> bodyqueryOperator = null, [WorkflowExpression] Func<string[]> bodymlt = null, [WorkflowExpression] Func<string[]> bodymltt = null)
        {
            var apiCallPath = "/api-proxy/SearchV2";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["query"] = ExpressionConverter.ConvertO(bodyquery);
            if (bodyoffset != null)
            {
                body["offset"] = ExpressionConverter.ConvertO(bodyoffset);
                bodypropCount++;
            }

            if (bodycount != null)
            {
                body["count"] = ExpressionConverter.ConvertO(bodycount);
                bodypropCount++;
            }

            if (bodyfolder != null)
            {
                body["folder"] = ExpressionConverter.ConvertO(bodyfolder);
                bodypropCount++;
            }

            if (bodymodifiedBefore != null)
            {
                body["modifiedBefore"] = ExpressionConverter.ConvertO(bodymodifiedBefore);
                bodypropCount++;
            }

            if (bodymodifiedAfter != null)
            {
                body["modifiedAfter"] = ExpressionConverter.ConvertO(bodymodifiedAfter);
                bodypropCount++;
            }

            if (bodyuploadedBefore != null)
            {
                body["uploadedBefore"] = ExpressionConverter.ConvertO(bodyuploadedBefore);
                bodypropCount++;
            }

            if (bodyuploadedAfter != null)
            {
                body["uploadedAfter"] = ExpressionConverter.ConvertO(bodyuploadedAfter);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodysnippetRequested != null)
            {
                if (bodysnippetRequested != null)
                {
                    body["snippetRequested"] = ExpressionConverter.ConvertO(bodysnippetRequested);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["snippetRequested"] = true;
                bodypropCount++;
            }

            if (bodysortBy != null)
            {
                body["sortBy"] = ExpressionConverter.ConvertO(bodysortBy);
                bodypropCount++;
            }

            if (bodysortDirection != null)
            {
                body["sortDirection"] = ExpressionConverter.ConvertO(bodysortDirection);
                bodypropCount++;
            }

            if (bodyfileQueryFields != null)
            {
                body["fileQueryFields"] = ExpressionConverter.ConvertO(bodyfileQueryFields);
                bodypropCount++;
            }

            if (bodyfolderQueryFields != null)
            {
                body["folderQueryFields"] = ExpressionConverter.ConvertO(bodyfolderQueryFields);
                bodypropCount++;
            }

            if (bodyqueryOperator != null)
            {
                body["queryOperator"] = ExpressionConverter.ConvertO(bodyqueryOperator);
                bodypropCount++;
            }

            if (bodymlt != null)
            {
                body["mlt"] = ExpressionConverter.ConvertO(bodymlt);
                bodypropCount++;
            }

            if (bodymltt != null)
            {
                body["mltt"] = ExpressionConverter.ConvertO(bodymltt);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SearchV2Response>(callPayload);
        }
    }

    public class EgnyteTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger FileLocked([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/FileLocked";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger FileUnlocked([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/FileUnlocked";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger FileUpdated([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/FileUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger FileCreated([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/FileCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger ShareLinkCreated([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/ShareLinkCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger ShareLinkDeleted([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/ShareLinkDeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger FileOrFolderPermissionChange([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/FileOrFolderPermissionChange";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger FileOrFolderMetadataChange([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/FileOrFolderMetadataChange";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger FolderProjectAdded([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/FolderProjectAdded";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger FolderProjectUnmarked([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/FolderProjectUnmarked";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger FolderProjectUpdated([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/FolderProjectUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WorkflowCreated([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/WorkflowCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WorkflowCompleted([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/WorkflowCompleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WorkflowApprovalTaskApproved([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/WorkflowApprovalTaskApproved";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger WorkflowApprovalTaskRejected([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/WorkflowApprovalTaskRejected";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger GroupCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/GroupCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger GroupUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/GroupUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger GroupDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhook/GroupDeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollCreatedFilesResponseItem[]> PollCreatedFiles([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/created-files";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionTrigger<PollCreatedFilesResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollCreatedFoldersResponseItem[]> PollCreatedFolders([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/created-folders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionTrigger<PollCreatedFoldersResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollDeletedFilesResponseItem[]> PollDeletedFiles([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/deleted-files";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionTrigger<PollDeletedFilesResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollDeletedFoldersResponseItem[]> PollDeletedFolders([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/deleted-folders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionTrigger<PollDeletedFoldersResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollRenamedFilesResponseItem[]> PollRenamedFiles([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/renamed-files";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionTrigger<PollRenamedFilesResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollRenamedFoldersResponseItem[]> PollRenamedFolders([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/renamed-folders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionTrigger<PollRenamedFoldersResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollMovedFilesResponseItem[]> PollMovedFiles([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/moved-files";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionTrigger<PollMovedFilesResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollMovedFoldersResponseItem[]> PollMovedFolders([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/moved-folders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionTrigger<PollMovedFoldersResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollCopiedFilesResponseItem[]> PollCopiedFiles([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/copied-files";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionTrigger<PollCopiedFilesResponseItem[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollCopiedFoldersResponseItem[]> PollCopiedFolders([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/polling/copied-folders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FolderPath"] = ExpressionConverter.Convert(folderPath);
            return new ApiConnectionTrigger<PollCopiedFoldersResponseItem[]>(callPayload, triggerName, recurrence);
        }
    }

    public class CreateGroupResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("members")]
        public CreateGroupResponseMembersTypeItem[] Members { get; set; }
    }

    public class CreateGroupResponseMembersTypeItem
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodymembersInputItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GroupInfoByIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("members")]
        public GroupInfoByIdResponseMembersTypeItem[] Members { get; set; }
    }

    public class GroupInfoByIdResponseMembersTypeItem
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class ListGroupsResponse
    {
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("resources")]
        public ListGroupsResponseResourcesTypeItem[] Resources { get; set; }
    }

    public class ListGroupsResponseResourcesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class UserInfoResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public UserInfoResponseNameType Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("lastModificationDate")]
        public string LastModificationDate { get; set; }

        [JsonProperty("lastActiveDate")]
        public string LastActiveDate { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("language")]
        public UserInfoResponseLanguageType Language { get; set; }

        [JsonProperty("authType")]
        public UserInfoResponseAuthTypeType AuthType { get; set; }

        [JsonProperty("userType")]
        public UserInfoResponseUserTypeType UserType { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("idpUserId")]
        public string IdpUserId { get; set; }

        [JsonProperty("isServiceAccount")]
        public bool IsServiceAccount { get; set; }

        [JsonProperty("deleteOnExpiry")]
        public string DeleteOnExpiry { get; set; }

        [JsonProperty("emailChangePending")]
        public bool EmailChangePending { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("groups")]
        public UserInfoResponseGroupsTypeItem[] Groups { get; set; }
    }

    public class UserInfoResponseNameType
    {
        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }
    }

    public enum UserInfoResponseLanguageType
    {
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "de-DE")]
        DeDE
    }

    public enum UserInfoResponseAuthTypeType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "sso")]
        Sso,
        [EnumMember(Value = "egnyte")]
        Egnyte
    }

    public enum UserInfoResponseUserTypeType
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "power")]
        Power,
        [EnumMember(Value = "standard")]
        Standard
    }

    public class UserInfoResponseGroupsTypeItem
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class UserListResponse
    {
        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }

        [JsonProperty("itemsPerPage")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("resources")]
        public UserListResponseResourcesTypeItem[] Resources { get; set; }
    }

    public class UserListResponseResourcesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public UserListResponseResourcesTypeItemNameType Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("lastModificationDate")]
        public string LastModificationDate { get; set; }

        [JsonProperty("lastActiveDate")]
        public string LastActiveDate { get; set; }

        [JsonProperty("language")]
        public UserListResponseResourcesTypeItemLanguageType Language { get; set; }

        [JsonProperty("authType")]
        public UserListResponseResourcesTypeItemAuthTypeType AuthType { get; set; }

        [JsonProperty("userType")]
        public UserListResponseResourcesTypeItemUserTypeType UserType { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("idpUserId")]
        public string IdpUserId { get; set; }

        [JsonProperty("isServiceAccount")]
        public bool IsServiceAccount { get; set; }

        [JsonProperty("deleteOnExpiry")]
        public string DeleteOnExpiry { get; set; }

        [JsonProperty("emailChangePending")]
        public bool EmailChangePending { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class UserListResponseResourcesTypeItemNameType
    {
        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }
    }

    public enum UserListResponseResourcesTypeItemLanguageType
    {
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "de-DE")]
        DeDE
    }

    public enum UserListResponseResourcesTypeItemAuthTypeType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "sso")]
        Sso,
        [EnumMember(Value = "egnyte")]
        Egnyte
    }

    public enum UserListResponseResourcesTypeItemUserTypeType
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "power")]
        Power,
        [EnumMember(Value = "standard")]
        Standard
    }

    public class UpdateUserResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("sendInvite")]
        public bool SendInvite { get; set; }

        [JsonProperty("language")]
        public UpdateUserResponseLanguageType Language { get; set; }

        [JsonProperty("authType")]
        public UpdateUserResponseAuthTypeType AuthType { get; set; }

        [JsonProperty("userType")]
        public UpdateUserResponseUserTypeType UserType { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("idpUserId")]
        public string IdpUserId { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public enum UpdateUserResponseLanguageType
    {
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "de-DE")]
        DeDE
    }

    public enum UpdateUserResponseAuthTypeType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "sso")]
        Sso,
        [EnumMember(Value = "egnyte")]
        Egnyte
    }

    public enum UpdateUserResponseUserTypeType
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "power")]
        Power,
        [EnumMember(Value = "standard")]
        Standard
    }

    public enum bodylanguageInput
    {
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "de-DE")]
        DeDE
    }

    public enum bodyauthTypeInput
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "sso")]
        Sso,
        [EnumMember(Value = "egnyte")]
        Egnyte
    }

    public enum bodyuserTypeInput
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "power")]
        Power,
        [EnumMember(Value = "standard")]
        Standard
    }

    public class CreateUserResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("emailChangePending")]
        public bool EmailChangePending { get; set; }

        [JsonProperty("name")]
        public CreateUserResponseNameType Name { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("authType")]
        public CreateUserResponseAuthTypeType AuthType { get; set; }

        [JsonProperty("userType")]
        public CreateUserResponseUserTypeType UserType { get; set; }

        [JsonProperty("idpUserId")]
        public string IdpUserId { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("lastModificationDate")]
        public string LastModificationDate { get; set; }

        [JsonProperty("lastActiveDate")]
        public string LastActiveDate { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }
    }

    public class CreateUserResponseNameType
    {
        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }
    }

    public enum CreateUserResponseAuthTypeType
    {
        [EnumMember(Value = "ad")]
        Ad,
        [EnumMember(Value = "sso")]
        Sso,
        [EnumMember(Value = "egnyte")]
        Egnyte
    }

    public enum CreateUserResponseUserTypeType
    {
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "power")]
        Power,
        [EnumMember(Value = "standard")]
        Standard
    }

    public class CreateFolderResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }
    }

    public class DeleteFileByPathResponse
    {
        [JsonProperty("parent_folder_path")]
        public string ParentFolderPath { get; set; }
    }

    public class DeleteFolderByPathResponse
    {
        [JsonProperty("parent_folder_path")]
        public string ParentFolderPath { get; set; }
    }

    public class DeleteFolderByIdResponse
    {
        [JsonProperty("parent_folder_path")]
        public string ParentFolderPath { get; set; }
    }

    public class DeleteFileByIdResponse
    {
        [JsonProperty("parent_folder_path")]
        public string ParentFolderPath { get; set; }
    }

    public class CopyFileByPathResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }
    }

    public class CopyFolderByPathResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }
    }

    public class FullGroupUpdateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("members")]
        public FullGroupUpdateResponseMembersTypeItem[] Members { get; set; }
    }

    public class FullGroupUpdateResponseMembersTypeItem
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodymembersInputItem2
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class PartialGroupUpdateResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("members")]
        public PartialGroupUpdateResponseMembersTypeItem[] Members { get; set; }
    }

    public class PartialGroupUpdateResponseMembersTypeItem
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class bodymembersInputItem22
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("operation")]
        public bodymembersInputItemOperationType Operation { get; set; }
    }

    public enum bodymembersInputItemOperationType
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "delete")]
        Delete
    }

    public class CopyFileByIdResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }
    }

    public class CopyFolderByIdResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }
    }

    public class MoveFileByPathResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }
    }

    public class MoveFolderByPathResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }
    }

    public class MoveFileByIdResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }
    }

    public class MoveFolderByIdResponse
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }
    }

    public class ShareFileResponse
    {
        [JsonProperty("links")]
        public ShareFileResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("accessibility")]
        public string Accessibility { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("link_to_current")]
        public bool LinkToCurrent { get; set; }

        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }
    }

    public class ShareFileResponseLinksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }
    }

    public class ShareFolderResponse
    {
        [JsonProperty("links")]
        public ShareFolderResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("accessibility")]
        public string Accessibility { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("link_to_current")]
        public bool LinkToCurrent { get; set; }

        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }
    }

    public class ShareFolderResponseLinksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }
    }

    public class FileInfoResponse
    {
        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("entry_id")]
        public string EntryId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("uploaded_by")]
        public string UploadedBy { get; set; }

        [JsonProperty("uploaded")]
        public int Uploaded { get; set; }

        [JsonProperty("num_versions")]
        public int NumVersions { get; set; }

        [JsonProperty("versions")]
        public FileInfoResponseVersionsTypeItem[] Versions { get; set; }
    }

    public class FileInfoResponseVersionsTypeItem
    {
        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("entry_id")]
        public string EntryId { get; set; }

        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("uploaded_by")]
        public string UploadedBy { get; set; }

        [JsonProperty("uploaded")]
        public int Uploaded { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }
    }

    public class FolderInfoResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastModified")]
        public int LastModified { get; set; }

        [JsonProperty("uploaded")]
        public int Uploaded { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("public_links")]
        public string PublicLinks { get; set; }

        [JsonProperty("allow_links")]
        public bool AllowLinks { get; set; }

        [JsonProperty("restrict_move_delete")]
        public bool RestrictMoveDelete { get; set; }

        [JsonProperty("folders")]
        public FolderInfoResponseFoldersTypeItem[] Folders { get; set; }

        [JsonProperty("files")]
        public FolderInfoResponseFilesTypeItem[] Files { get; set; }
    }

    public class FolderInfoResponseFoldersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastModified")]
        public int LastModified { get; set; }

        [JsonProperty("uploaded")]
        public int Uploaded { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }
    }

    public class FolderInfoResponseFilesTypeItem
    {
        [JsonProperty("checksum")]
        public string Checksum { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("entry_id")]
        public string EntryId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("uploaded_by")]
        public string UploadedBy { get; set; }

        [JsonProperty("uploaded")]
        public int Uploaded { get; set; }

        [JsonProperty("num_versions")]
        public int NumVersions { get; set; }
    }

    public class ModifyFolderOptionsResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lastModified")]
        public int LastModified { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("folder_id")]
        public string FolderId { get; set; }

        [JsonProperty("folder_description")]
        public string FolderDescription { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("public_links")]
        public string PublicLinks { get; set; }

        [JsonProperty("restrict_move_delete")]
        public bool RestrictMoveDelete { get; set; }
    }

    public enum bodypublicLinksInput
    {
        [EnumMember(Value = "files_folders")]
        FilesFolders,
        [EnumMember(Value = "files")]
        Files,
        [EnumMember(Value = "disabled")]
        Disabled
    }

    public class LockFileByPathResponse
    {
        [JsonProperty("timeout")]
        public int Timeout { get; set; }

        [JsonProperty("lock_token")]
        public string LockToken { get; set; }
    }

    public class LockFileByIdResponse
    {
        [JsonProperty("timeout")]
        public int Timeout { get; set; }

        [JsonProperty("lock_token")]
        public string LockToken { get; set; }
    }

    public class CreateFileResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class NamespaceItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("scope")]
        public NamespaceItemScopeType Scope { get; set; }

        [JsonProperty("keys")]
        public JToken Keys { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("priority")]
        public double Priority { get; set; }

        [JsonProperty("inheritable")]
        public bool Inheritable { get; set; }

        [JsonProperty("schemaSystemGenerated")]
        public bool SchemaSystemGenerated { get; set; }

        [JsonProperty("metadataScopeType")]
        public NamespaceItemMetadataScopeTypeType MetadataScopeType { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }
    }

    public enum NamespaceItemScopeType
    {
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "protected")]
        Protected,
        [EnumMember(Value = "private")]
        Private
    }

    public enum NamespaceItemMetadataScopeTypeType
    {
        GLOBAL,
        [EnumMember(Value = "FOLDER_SCOPE")]
        FOLDERSCOPE
    }

    public enum bodyscopeInput
    {
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "protected")]
        Protected,
        [EnumMember(Value = "private")]
        Private
    }

    public class bodykeysInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public bodykeysInputItemTypeType Type { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("priority")]
        public double Priority { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public enum bodykeysInputItemTypeType
    {
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "decimal")]
        Decimal,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "enum")]
        Enum
    }

    public class UpdateNamespaceKeysResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("helpText")]
        public string HelpText { get; set; }

        [JsonProperty("priority")]
        public double Priority { get; set; }
    }

    public enum bodytypeInput
    {
        FOLDER,
        FILE,
        ALL
    }

    public class ProjectItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("rootFolderId")]
        public string RootFolderId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public ProjectLocationItem Location { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdBy")]
        public double CreatedBy { get; set; }

        [JsonProperty("lastUpdatedBy")]
        public double LastUpdatedBy { get; set; }

        [JsonProperty("creationTime")]
        public string CreationTime { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("completionDate")]
        public string CompletionDate { get; set; }
    }

    public class ProjectLocationItem
    {
        [JsonProperty("streetAddress1")]
        public string StreetAddress1 { get; set; }

        [JsonProperty("streetAddress2")]
        public string StreetAddress2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public class MarkFolderAsProjectResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public enum bodystatusInput
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "in-progress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "on-hold")]
        OnHold,
        [EnumMember(Value = "canceled")]
        Canceled
    }

    public class CreateProjectFromTemplateResponse
    {
        [JsonProperty("groupsCreated")]
        public CreateProjectFromTemplateResponseGroupsCreatedTypeItem[] GroupsCreated { get; set; }
    }

    public class CreateProjectFromTemplateResponseGroupsCreatedTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CleanupProjectResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class bodyhasKeyInputItem
    {
        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("keyName")]
        public string KeyName { get; set; }
    }

    public class bodykeyWithValueInputItem
    {
        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("keyName")]
        public string KeyName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetEffectivePermissionsResponse
    {
        [JsonProperty("permission")]
        public GetEffectivePermissionsResponsePermissionType Permission { get; set; }
    }

    public enum GetEffectivePermissionsResponsePermissionType
    {
        None,
        [EnumMember(Value = "Viewer Only")]
        ViewerOnly,
        Viewer,
        Editor,
        Full,
        Owner
    }

    public class GetFolderPermissionsResponse
    {
        [JsonProperty("userPerms")]
        public JToken UserPerms { get; set; }

        [JsonProperty("groupPerms")]
        public JToken GroupPerms { get; set; }

        [JsonProperty("inheritsPermissions")]
        public bool InheritsPermissions { get; set; }

        [JsonProperty("keepParentPermissions")]
        public bool KeepParentPermissions { get; set; }
    }

    public class DeepLinksByIdResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class DeepLinksByPathResponse
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ListLinksResponse
    {
        [JsonProperty("ids")]
        public string[] Ids { get; set; }

        [JsonProperty("offset")]
        public double Offset { get; set; }

        [JsonProperty("count")]
        public double Count { get; set; }

        [JsonProperty("total_count")]
        public double TotalCount { get; set; }
    }

    public enum bodyaccessibilityInput
    {
        [EnumMember(Value = "anyone")]
        Anyone,
        [EnumMember(Value = "password")]
        Password,
        [EnumMember(Value = "domain")]
        Domain,
        [EnumMember(Value = "recipients")]
        Recipients,
        [EnumMember(Value = "none")]
        None
    }

    public class ShowLinkDetailsResponse
    {
        [JsonProperty("links")]
        public ShowLinkDetailsResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("accessibility")]
        public string Accessibility { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("link_to_current")]
        public bool LinkToCurrent { get; set; }

        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("last_accessed")]
        public string LastAccessed { get; set; }
    }

    public class ShowLinkDetailsResponseLinksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }
    }

    public class CreateLinkResponse
    {
        [JsonProperty("links")]
        public CreateLinkResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("accessibility")]
        public string Accessibility { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("link_to_current")]
        public bool LinkToCurrent { get; set; }

        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }
    }

    public class CreateLinkResponseLinksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }
    }

    public enum bodyprotectionInput
    {
        PREVIEW,
        NONE
    }

    public class AIQuestionResponse
    {
        [JsonProperty("response")]
        public AIResponse Response { get; set; }

        [JsonProperty("citations")]
        public AICitation[] Citations { get; set; }
    }

    public class AIResponse
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class AICitation
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("entryId")]
        public string EntryId { get; set; }

        [JsonProperty("chunks")]
        public AICitationChunksTypeItem[] Chunks { get; set; }
    }

    public class AICitationChunksTypeItem
    {
        [JsonProperty("chunkId")]
        public string ChunkId { get; set; }

        [JsonProperty("sourceText")]
        public string SourceText { get; set; }
    }

    public class AIMessage
    {
        [JsonProperty("role")]
        public AIMessageRoleType Role { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public enum AIMessageRoleType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "assistant")]
        Assistant
    }

    public class AISummaryResponse
    {
        [JsonProperty("response")]
        public AIResponse Response { get; set; }
    }

    public class AICopilotResponse
    {
        [JsonProperty("response")]
        public AIResponse Response { get; set; }

        [JsonProperty("citations")]
        public AICitation[] Citations { get; set; }

        [JsonProperty("conversationId")]
        public string ConversationId { get; set; }
    }

    public class bodyselectedItemsfoldersInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class bodyselectedItemsfilesInputItem
    {
        [JsonProperty("entryId")]
        public string EntryId { get; set; }
    }

    public class SearchV2Response
    {
        [JsonProperty("results")]
        public SearchV2ResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }
    }

    public class SearchV2ResponseResultsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("snippet_html")]
        public string SnippetHtml { get; set; }

        [JsonProperty("entry_id")]
        public string EntryId { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("uploaded_by")]
        public string UploadedBy { get; set; }

        [JsonProperty("uploaded_by_username")]
        public string UploadedByUsername { get; set; }

        [JsonProperty("num_versions")]
        public int NumVersions { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }

        [JsonProperty("custom_properties")]
        public SearchV2ResponseResultsTypeItemCustomPropertiesTypeItem[] CustomProperties { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class SearchV2ResponseResultsTypeItemCustomPropertiesTypeItem
    {
        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum bodysortByInput
    {
        [EnumMember(Value = "last_modified")]
        LastModified,
        [EnumMember(Value = "size")]
        Size,
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "score")]
        Score
    }

    public enum bodysortDirectionInput
    {
        [EnumMember(Value = "ascending")]
        Ascending,
        [EnumMember(Value = "descending")]
        Descending
    }

    public enum bodyfileQueryFieldsInputItem
    {
        ALL,
        FILENAME,
        COMMENTS,
        CONTENT
    }

    public enum bodyfolderQueryFieldsInputItem
    {
        ALL,
        FOLDERNAME,
        DESCRIPTION
    }

    public enum bodyqueryOperatorInput
    {
        ANY,
        ALL
    }

    public class PollCreatedFilesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollCreatedFilesResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollCreatedFilesResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        [JsonProperty("target_group_id")]
        public string TargetGroupId { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollCreatedFoldersResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollCreatedFoldersResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollCreatedFoldersResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollDeletedFilesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollDeletedFilesResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }
    }

    public class PollDeletedFilesResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("target_group_id")]
        public string TargetGroupId { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollDeletedFoldersResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollDeletedFoldersResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }
    }

    public class PollDeletedFoldersResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollRenamedFilesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollRenamedFilesResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollRenamedFilesResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        [JsonProperty("target_group_id")]
        public string TargetGroupId { get; set; }

        [JsonProperty("source_path")]
        public string SourcePath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollRenamedFoldersResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollRenamedFoldersResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollRenamedFoldersResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("source_path")]
        public string SourcePath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollMovedFilesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollMovedFilesResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollMovedFilesResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        [JsonProperty("target_group_id")]
        public string TargetGroupId { get; set; }

        [JsonProperty("source_path")]
        public string SourcePath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollMovedFoldersResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollMovedFoldersResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollMovedFoldersResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("source_path")]
        public string SourcePath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollCopiedFilesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollCopiedFilesResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollCopiedFilesResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        [JsonProperty("target_group_id")]
        public string TargetGroupId { get; set; }

        [JsonProperty("source_path")]
        public string SourcePath { get; set; }

        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        [JsonProperty("source_group_id")]
        public string SourceGroupId { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }

    public class PollCopiedFoldersResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("actor")]
        public int Actor { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("data")]
        public PollCopiedFoldersResponseItemDataType Data { get; set; }

        [JsonProperty("action_source")]
        public string ActionSource { get; set; }

        [JsonProperty("object_detail")]
        public string ObjectDetail { get; set; }
    }

    public class PollCopiedFoldersResponseItemDataType
    {
        [JsonProperty("target_path")]
        public string TargetPath { get; set; }

        [JsonProperty("source_path")]
        public string SourcePath { get; set; }

        [JsonProperty("is_folder")]
        public bool IsFolder { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Egnyte;

    public partial class WorkflowManagedActions
    {
        public EgnyteActions Egnyte(string connectionId) => new EgnyteActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EgnyteTriggers Egnyte(string connectionId) => new EgnyteTriggers(connectionId);
    }
}