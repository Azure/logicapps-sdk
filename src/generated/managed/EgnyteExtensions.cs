//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Egnyte
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EgnyteActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateGroupResponse> CreateGroup([WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<bodymembersInputItem[]> bodymembers = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/CreateGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                if (bodymembers != null)
                {
                    body["members"] = SourceExpressionConverter.ConvertToken(bodymembers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<GroupInfoByIdResponse> GroupInfoById([WorkflowExpression] Func<string> bodyid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/GroupInfoById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GroupInfoByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ListGroupsResponse> ListGroups([WorkflowExpression] Func<int> bodystartIndex = null, [WorkflowExpression] Func<int> bodycount = null, [WorkflowExpression] Func<string> bodyfilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/ListGroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystartIndex != null)
                {
                    body["startIndex"] = SourceExpressionConverter.ConvertToken(bodystartIndex);
                    bodypropCount++;
                }

                if (bodycount != null)
                {
                    body["count"] = SourceExpressionConverter.ConvertToken(bodycount);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ListGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<UserInfoResponse> GetUser([WorkflowExpression] Func<int> bodyid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/GetUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<UserListResponse> GetUserList([WorkflowExpression] Func<int> bodystartIndex = null, [WorkflowExpression] Func<int> bodycount = null, [WorkflowExpression] Func<string> bodyfilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/GetUserList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystartIndex != null)
                {
                    body["startIndex"] = SourceExpressionConverter.ConvertToken(bodystartIndex);
                    bodypropCount++;
                }

                if (bodycount != null)
                {
                    body["count"] = SourceExpressionConverter.ConvertToken(bodycount);
                    bodypropCount++;
                }

                if (bodyfilter != null)
                {
                    body["filter"] = SourceExpressionConverter.ConvertToken(bodyfilter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<UpdateUserResponse> UpdateUser([WorkflowExpression] Func<int> bodyid, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodynamegivenName = null, [WorkflowExpression] Func<string> bodynamefamilyName = null, [WorkflowExpression] Func<bool> bodyactive = null, [WorkflowExpression] Func<bool> bodysendInvite = null, [WorkflowExpression] Func<bodylanguageInput> bodylanguage = null, [WorkflowExpression] Func<bodyauthTypeInput> bodyauthType = null, [WorkflowExpression] Func<bodyuserTypeInput> bodyuserType = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodyidpUserId = null, [WorkflowExpression] Func<string> bodyuserPrincipalName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/UpdateUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                if (bodynamegivenName != null)
                {
                    nameObject["givenName"] = SourceExpressionConverter.ConvertToken(bodynamegivenName);
                    nameObjectpropCount++;
                }

                if (bodynamefamilyName != null)
                {
                    nameObject["familyName"] = SourceExpressionConverter.ConvertToken(bodynamefamilyName);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodysendInvite != null)
                {
                    body["sendInvite"] = SourceExpressionConverter.ConvertToken(bodysendInvite);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.Convert(bodylanguage);
                    bodypropCount++;
                }

                if (bodyauthType != null)
                {
                    body["authType"] = SourceExpressionConverter.Convert(bodyauthType);
                    bodypropCount++;
                }

                if (bodyuserType != null)
                {
                    body["userType"] = SourceExpressionConverter.Convert(bodyuserType);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                    bodypropCount++;
                }

                if (bodyidpUserId != null)
                {
                    body["idpUserId"] = SourceExpressionConverter.ConvertToken(bodyidpUserId);
                    bodypropCount++;
                }

                if (bodyuserPrincipalName != null)
                {
                    body["userPrincipalName"] = SourceExpressionConverter.ConvertToken(bodyuserPrincipalName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser([WorkflowExpression] Func<string> bodyuserName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<bool> bodyactive, [WorkflowExpression] Func<bodyuserTypeInput> bodyuserType, [WorkflowExpression] Func<bodyauthTypeInput> bodyauthType, [WorkflowExpression] Func<string> bodynamegivenName = null, [WorkflowExpression] Func<string> bodynamefamilyName = null, [WorkflowExpression] Func<string> bodyexternalId = null, [WorkflowExpression] Func<bool> bodysendInvite = null, [WorkflowExpression] Func<bool> bodyisServiceAccount = null, [WorkflowExpression] Func<bodylanguageInput> bodylanguage = null, [WorkflowExpression] Func<string> bodyrole = null, [WorkflowExpression] Func<string> bodyidpUserId = null, [WorkflowExpression] Func<string> bodyuserPrincipalName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/CreateUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userName"] = SourceExpressionConverter.ConvertToken(bodyuserName);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                if (bodynamegivenName != null)
                {
                    nameObject["givenName"] = SourceExpressionConverter.ConvertToken(bodynamegivenName);
                    nameObjectpropCount++;
                }

                if (bodynamefamilyName != null)
                {
                    nameObject["familyName"] = SourceExpressionConverter.ConvertToken(bodynamefamilyName);
                    nameObjectpropCount++;
                }

                if (nameObjectpropCount > 0)
                {
                    body["name"] = nameObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                bodypropCount++;
                body["userType"] = SourceExpressionConverter.Convert(bodyuserType);
                bodypropCount++;
                body["authType"] = SourceExpressionConverter.Convert(bodyauthType);
                if (bodyexternalId != null)
                {
                    body["externalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodysendInvite != null)
                {
                    body["sendInvite"] = SourceExpressionConverter.ConvertToken(bodysendInvite);
                    bodypropCount++;
                }

                if (bodyisServiceAccount != null)
                {
                    body["isServiceAccount"] = SourceExpressionConverter.ConvertToken(bodyisServiceAccount);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.Convert(bodylanguage);
                    bodypropCount++;
                }

                if (bodyrole != null)
                {
                    body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                    bodypropCount++;
                }

                if (bodyidpUserId != null)
                {
                    body["idpUserId"] = SourceExpressionConverter.ConvertToken(bodyidpUserId);
                    bodypropCount++;
                }

                if (bodyuserPrincipalName != null)
                {
                    body["userPrincipalName"] = SourceExpressionConverter.ConvertToken(bodyuserPrincipalName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction DeleteUser([WorkflowExpression] Func<int> bodyid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/DeleteUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateFolderResponse> CreateFolder([WorkflowExpression] Func<string> bodypath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/CreateFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeleteFileByPathResponse> DeleteFileByPath([WorkflowExpression] Func<string> bodypath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/DeleteFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteFileByPathResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeleteFolderByPathResponse> DeleteFolderByPath([WorkflowExpression] Func<string> bodypath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/DeleteFolderByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteFolderByPathResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeleteFolderByIdResponse> DeleteFolderById([WorkflowExpression] Func<string> bodyid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/DeleteFolderById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteFolderByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeleteFileByIdResponse> DeleteFileById([WorkflowExpression] Func<string> bodyid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/DeleteFileById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteFileByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CopyFileByPathResponse> CopyFileByPath([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/CopyFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
                body["destination_path"] = SourceExpressionConverter.ConvertToken(bodydestinationPath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CopyFileByPathResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CopyFolderByPathResponse> CopyFolderByPath([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/CopyFolderByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
                body["destination_path"] = SourceExpressionConverter.ConvertToken(bodydestinationPath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CopyFolderByPathResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FullGroupUpdateResponse> FullGroupUpdate([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<bodymembersInputItem2[]> bodymembers = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/FullGroupUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                if (bodymembers != null)
                {
                    body["members"] = SourceExpressionConverter.ConvertToken(bodymembers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FullGroupUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<PartialGroupUpdateResponse> PartialGroupUpdate([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<bodymembersInputItem22[]> bodymembers = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/PartialGroupUpdate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                if (bodymembers != null)
                {
                    body["members"] = SourceExpressionConverter.ConvertToken(bodymembers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PartialGroupUpdateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction DeleteGroup([WorkflowExpression] Func<string> bodyid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/DeleteGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CopyFileByIdResponse> CopyFileById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/CopyFileById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["destination_path"] = SourceExpressionConverter.ConvertToken(bodydestinationPath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CopyFileByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CopyFolderByIdResponse> CopyFolderById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/CopyFolderById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["destination_path"] = SourceExpressionConverter.ConvertToken(bodydestinationPath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CopyFolderByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MoveFileByPathResponse> MoveFileByPath([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/MoveFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
                body["destination_path"] = SourceExpressionConverter.ConvertToken(bodydestinationPath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MoveFileByPathResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MoveFolderByPathResponse> MoveFolderByPath([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/MoveFolderByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
                body["destination_path"] = SourceExpressionConverter.ConvertToken(bodydestinationPath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MoveFolderByPathResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MoveFileByIdResponse> MoveFileById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/MoveFileById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["destination_path"] = SourceExpressionConverter.ConvertToken(bodydestinationPath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MoveFileByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MoveFolderByIdResponse> MoveFolderById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodydestinationPath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/MoveFolderById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["destination_path"] = SourceExpressionConverter.ConvertToken(bodydestinationPath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MoveFolderByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ShareFileResponse> ShareFile([WorkflowExpression] Func<string> bodypath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/ShareFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ShareFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ShareFolderResponse> ShareFolder([WorkflowExpression] Func<string> bodypath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/ShareFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ShareFolderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FileInfoResponse> FileInfoByPath([WorkflowExpression] Func<string> bodypath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/FileInfoByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FileInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FolderInfoResponse> FolderInfoByPath([WorkflowExpression] Func<string> bodypath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/FolderInfoByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FolderInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ModifyFolderOptionsResponse> ModifyFolderOptions([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodyfolderDescription = null, [WorkflowExpression] Func<bool> bodyallowLinks = null, [WorkflowExpression] Func<bodypublicLinksInput> bodypublicLinks = null, [WorkflowExpression] Func<bool> bodyrestrictMoveDelete = null, [WorkflowExpression] Func<bool> bodyemailPreferencescontentUpdates = null, [WorkflowExpression] Func<bool> bodyemailPreferencescontentAccessed = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/ModifyFolderOptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                if (bodyfolderDescription != null)
                {
                    body["folder_description"] = SourceExpressionConverter.ConvertToken(bodyfolderDescription);
                    bodypropCount++;
                }

                if (bodyallowLinks != null)
                {
                    body["allow_links"] = SourceExpressionConverter.ConvertToken(bodyallowLinks);
                    bodypropCount++;
                }

                if (bodypublicLinks != null)
                {
                    body["public_links"] = SourceExpressionConverter.Convert(bodypublicLinks);
                    bodypropCount++;
                }

                if (bodyrestrictMoveDelete != null)
                {
                    body["restrict_move_delete"] = SourceExpressionConverter.ConvertToken(bodyrestrictMoveDelete);
                    bodypropCount++;
                }

                var emailPreferencesObject = new JObject();
                var emailPreferencesObjectpropCount = 0;
                if (bodyemailPreferencescontentUpdates != null)
                {
                    emailPreferencesObject["content_updates"] = SourceExpressionConverter.ConvertToken(bodyemailPreferencescontentUpdates);
                    emailPreferencesObjectpropCount++;
                }

                if (bodyemailPreferencescontentAccessed != null)
                {
                    emailPreferencesObject["content_accessed"] = SourceExpressionConverter.ConvertToken(bodyemailPreferencescontentAccessed);
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
                return callPayload;
            }

            return new ApiConnectionAction<ModifyFolderOptionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FileInfoResponse> FileInfoById([WorkflowExpression] Func<string> bodyid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/FileInfoById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FileInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<FolderInfoResponse> FolderInfoById([WorkflowExpression] Func<string> bodyid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/FolderInfoById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FolderInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<LockFileByPathResponse> LockFileByPath([WorkflowExpression] Func<string> bodypath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/LockFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LockFileByPathResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction UnlockFileByPath([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodylockToken)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/UnlockFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
                body["lock_token"] = SourceExpressionConverter.ConvertToken(bodylockToken);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<LockFileByIdResponse> LockFileById([WorkflowExpression] Func<string> bodyid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/LockFileById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LockFileByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction UnlockFileById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodylockToken)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/UnlockFileById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["lock_token"] = SourceExpressionConverter.ConvertToken(bodylockToken);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction GetFileContentByPath([WorkflowExpression] Func<string> bodyfilePath, [WorkflowExpression] Func<bool> bodyenableAISafeguards = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/DownloadFileByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["filePath"] = SourceExpressionConverter.ConvertToken(bodyfilePath);
                if (bodyenableAISafeguards != null)
                {
                    if (bodyenableAISafeguards != null)
                    {
                        body["enableAISafeguards"] = SourceExpressionConverter.ConvertToken(bodyenableAISafeguards);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["enableAISafeguards"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction GetFileContentById([WorkflowExpression] Func<string> bodyfileId, [WorkflowExpression] Func<bool> bodyenableAISafeguards = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/DownloadFileById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fileId"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                if (bodyenableAISafeguards != null)
                {
                    if (bodyenableAISafeguards != null)
                    {
                        body["enableAISafeguards"] = SourceExpressionConverter.ConvertToken(bodyenableAISafeguards);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["enableAISafeguards"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateFileResponse> CreateFile([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<string> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/UploadFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["Path"] = SourceExpressionConverter.ConvertO(path);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<CreateFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction SetMetadataByFileId([WorkflowExpression] Func<string> bodyfileId, [WorkflowExpression] Func<string> bodynamespaceName, [WorkflowExpression] Func<string> bodymetadataName, [WorkflowExpression] Func<string> bodymetadataValue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/SetMetadataByFileId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fileId"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                bodypropCount++;
                body["namespaceName"] = SourceExpressionConverter.ConvertToken(bodynamespaceName);
                bodypropCount++;
                body["metadataName"] = SourceExpressionConverter.ConvertToken(bodymetadataName);
                if (bodymetadataValue != null)
                {
                    body["metadataValue"] = SourceExpressionConverter.ConvertToken(bodymetadataValue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction SetMetadataByFolderId([WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodynamespaceName, [WorkflowExpression] Func<string> bodymetadataName, [WorkflowExpression] Func<string> bodymetadataValue)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/SetMetadataByFolderId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                bodypropCount++;
                body["namespaceName"] = SourceExpressionConverter.ConvertToken(bodynamespaceName);
                bodypropCount++;
                body["metadataName"] = SourceExpressionConverter.ConvertToken(bodymetadataName);
                bodypropCount++;
                body["metadataValue"] = SourceExpressionConverter.ConvertToken(bodymetadataValue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<NamespaceItem[]> GetAllNamespaces()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/GetAllNamespaces";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<NamespaceItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction CreateNamespace([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodyscopeInput> bodyscope, [WorkflowExpression] Func<bodykeysInputItem[]> bodykeys, [WorkflowExpression] Func<string> bodydisplayName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/CreateNamespace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["scope"] = SourceExpressionConverter.Convert(bodyscope);
                bodypropCount++;
                body["keys"] = SourceExpressionConverter.ConvertToken(bodykeys);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<NamespaceItem> UpdateNamespaceAttributes([WorkflowExpression] Func<string> bodyNamespace, [WorkflowExpression] Func<string> bodydisplayName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/UpdateNamespaceAttributes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["namespace"] = SourceExpressionConverter.ConvertToken(bodyNamespace);
                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
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
                return callPayload;
            }

            return new ApiConnectionAction<NamespaceItem>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<UpdateNamespaceKeysResponse> UpdateNamespaceKeys([WorkflowExpression] Func<string> bodyNamespace, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<string> bodyhelpText, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<double> bodypriority = null, [WorkflowExpression] Func<string> bodydata = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/UpdateNamespaceKeys";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["namespace"] = SourceExpressionConverter.ConvertToken(bodyNamespace);
                bodypropCount++;
                body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                bodypropCount++;
                body["helpText"] = SourceExpressionConverter.ConvertToken(bodyhelpText);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateNamespaceKeysResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<NamespaceItem> GetNamespace([WorkflowExpression] Func<string> bodyNamespace)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/GetNamespace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["namespace"] = SourceExpressionConverter.ConvertToken(bodyNamespace);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NamespaceItem>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction DeleteNamespace([WorkflowExpression] Func<string> bodyNamespace, [WorkflowExpression] Func<bool> bodyforce = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/DeleteNamespace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["namespace"] = SourceExpressionConverter.ConvertToken(bodyNamespace);
                if (bodyforce != null)
                {
                    body["force"] = SourceExpressionConverter.ConvertToken(bodyforce);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ProjectItem[]> GetAllProjects()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/GetAllProjects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProjectItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<MarkFolderAsProjectResponse> MarkFolderAsProject([WorkflowExpression] Func<string> bodyrootFolderId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodycompletionDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/MarkFolderAsProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["rootFolderId"] = SourceExpressionConverter.ConvertToken(bodyrootFolderId);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodycompletionDate != null)
                {
                    body["completionDate"] = SourceExpressionConverter.ConvertToken(bodycompletionDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MarkFolderAsProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateProjectFromTemplateResponse> CreateProjectFromTemplate([WorkflowExpression] Func<string> bodyparentFolderId, [WorkflowExpression] Func<string> bodytemplateFolderId, [WorkflowExpression] Func<string> bodyfolderName, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<string> bodycustomerName = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodycompletionDate = null, [WorkflowExpression] Func<string> bodylocationstreetAddress1 = null, [WorkflowExpression] Func<string> bodylocationstreetAddress2 = null, [WorkflowExpression] Func<string> bodylocationcity = null, [WorkflowExpression] Func<string> bodylocationstate = null, [WorkflowExpression] Func<string> bodylocationcountry = null, [WorkflowExpression] Func<string> bodylocationpostalCode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/CreateProjectFromTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parentFolderId"] = SourceExpressionConverter.ConvertToken(bodyparentFolderId);
                bodypropCount++;
                body["templateFolderId"] = SourceExpressionConverter.ConvertToken(bodytemplateFolderId);
                bodypropCount++;
                body["folderName"] = SourceExpressionConverter.ConvertToken(bodyfolderName);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodycustomerName != null)
                {
                    body["customerName"] = SourceExpressionConverter.ConvertToken(bodycustomerName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodycompletionDate != null)
                {
                    body["completionDate"] = SourceExpressionConverter.ConvertToken(bodycompletionDate);
                    bodypropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (bodylocationstreetAddress1 != null)
                {
                    locationObject["streetAddress1"] = SourceExpressionConverter.ConvertToken(bodylocationstreetAddress1);
                    locationObjectpropCount++;
                }

                if (bodylocationstreetAddress2 != null)
                {
                    locationObject["streetAddress2"] = SourceExpressionConverter.ConvertToken(bodylocationstreetAddress2);
                    locationObjectpropCount++;
                }

                if (bodylocationcity != null)
                {
                    locationObject["city"] = SourceExpressionConverter.ConvertToken(bodylocationcity);
                    locationObjectpropCount++;
                }

                if (bodylocationstate != null)
                {
                    locationObject["state"] = SourceExpressionConverter.ConvertToken(bodylocationstate);
                    locationObjectpropCount++;
                }

                if (bodylocationcountry != null)
                {
                    locationObject["country"] = SourceExpressionConverter.ConvertToken(bodylocationcountry);
                    locationObjectpropCount++;
                }

                if (bodylocationpostalCode != null)
                {
                    locationObject["postalCode"] = SourceExpressionConverter.ConvertToken(bodylocationpostalCode);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateProjectFromTemplateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ProjectItem> GetProjectById([WorkflowExpression] Func<string> bodyprojectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/GetProjectById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectItem>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction UpdateProjectById([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodycustomProjectId = null, [WorkflowExpression] Func<string> bodycustomerName = null, [WorkflowExpression] Func<string> bodylocationstreetAddress1 = null, [WorkflowExpression] Func<string> bodylocationstreetAddress2 = null, [WorkflowExpression] Func<string> bodylocationcity = null, [WorkflowExpression] Func<string> bodylocationstate = null, [WorkflowExpression] Func<string> bodylocationpostalCode = null, [WorkflowExpression] Func<string> bodylocationcountry = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodycompletionDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/UpdateProjectById";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                bodypropCount++;
                body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                if (bodycustomProjectId != null)
                {
                    body["customProjectId"] = SourceExpressionConverter.ConvertToken(bodycustomProjectId);
                    bodypropCount++;
                }

                if (bodycustomerName != null)
                {
                    body["customerName"] = SourceExpressionConverter.ConvertToken(bodycustomerName);
                    bodypropCount++;
                }

                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (bodylocationstreetAddress1 != null)
                {
                    locationObject["streetAddress1"] = SourceExpressionConverter.ConvertToken(bodylocationstreetAddress1);
                    locationObjectpropCount++;
                }

                if (bodylocationstreetAddress2 != null)
                {
                    locationObject["streetAddress2"] = SourceExpressionConverter.ConvertToken(bodylocationstreetAddress2);
                    locationObjectpropCount++;
                }

                if (bodylocationcity != null)
                {
                    locationObject["city"] = SourceExpressionConverter.ConvertToken(bodylocationcity);
                    locationObjectpropCount++;
                }

                if (bodylocationstate != null)
                {
                    locationObject["state"] = SourceExpressionConverter.ConvertToken(bodylocationstate);
                    locationObjectpropCount++;
                }

                if (bodylocationpostalCode != null)
                {
                    locationObject["postalCode"] = SourceExpressionConverter.ConvertToken(bodylocationpostalCode);
                    locationObjectpropCount++;
                }

                if (bodylocationcountry != null)
                {
                    locationObject["country"] = SourceExpressionConverter.ConvertToken(bodylocationcountry);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    body["location"] = locationObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                if (bodystartDate != null)
                {
                    body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodycompletionDate != null)
                {
                    body["completionDate"] = SourceExpressionConverter.ConvertToken(bodycompletionDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction DeleteProjectById([WorkflowExpression] Func<string> projectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api-proxy/DeleteProjectById/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ProjectItem[]> GetProjectByRootFolderId([WorkflowExpression] Func<string> bodyrootFolderId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/GetProjectByRootFolderId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["rootFolderId"] = SourceExpressionConverter.ConvertToken(bodyrootFolderId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProjectItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CleanupProjectResponse> CleanupProject([WorkflowExpression] Func<string> bodyprojectId, [WorkflowExpression] Func<bool> bodydeleteLinks, [WorkflowExpression] Func<int[]> bodyusersToDelete = null, [WorkflowExpression] Func<int[]> bodyusersToDisable = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/CleanupProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["projectId"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                bodypropCount++;
                body["deleteLinks"] = SourceExpressionConverter.ConvertToken(bodydeleteLinks);
                if (bodyusersToDelete != null)
                {
                    body["usersToDelete"] = SourceExpressionConverter.ConvertToken(bodyusersToDelete);
                    bodypropCount++;
                }

                if (bodyusersToDisable != null)
                {
                    body["usersToDisable"] = SourceExpressionConverter.ConvertToken(bodyusersToDisable);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CleanupProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction CreateMetadataKey([WorkflowExpression] Func<string> bodyNamespace, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyhelpText, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<double> bodypriority = null, [WorkflowExpression] Func<string[]> bodydata = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/CreateMetadataKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["namespace"] = SourceExpressionConverter.ConvertToken(bodyNamespace);
                bodypropCount++;
                body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                bodypropCount++;
                body["helpText"] = SourceExpressionConverter.ConvertToken(bodyhelpText);
                if (bodydata != null)
                {
                    body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction DeleteMetadataKey([WorkflowExpression] Func<string> bodyNamespace, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<bool> bodyforce = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/DeleteMetadataKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["namespace"] = SourceExpressionConverter.ConvertToken(bodyNamespace);
                bodypropCount++;
                body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                if (bodyforce != null)
                {
                    body["force"] = SourceExpressionConverter.ConvertToken(bodyforce);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction GetMetadataByFileId([WorkflowExpression] Func<string> bodyfileId, [WorkflowExpression] Func<string> bodyNamespace)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/GetMetadataByFileId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fileId"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                bodypropCount++;
                body["namespace"] = SourceExpressionConverter.ConvertToken(bodyNamespace);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction GetMetadataByFolderId([WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodyNamespace)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/GetMetadataByFolderId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                bodypropCount++;
                body["namespace"] = SourceExpressionConverter.ConvertToken(bodyNamespace);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction SearchMetadata([WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<bodyhasKeyInputItem[]> bodyhasKey = null, [WorkflowExpression] Func<bodykeyWithValueInputItem[]> bodykeyWithValue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/SearchMetadata";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodyhasKey != null)
                {
                    body["hasKey"] = SourceExpressionConverter.ConvertToken(bodyhasKey);
                    bodypropCount++;
                }

                if (bodykeyWithValue != null)
                {
                    body["keyWithValue"] = SourceExpressionConverter.ConvertToken(bodykeyWithValue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<GetEffectivePermissionsResponse> GetEffectivePermissions([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<string> bodyusername)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/GetEffectivePermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
                body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetEffectivePermissionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction SetFolderPermissions([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<bool> bodyinheritsPermissions = null, [WorkflowExpression] Func<bool> bodykeepParentPermissions = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/SetFolderPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
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
                    body["inheritsPermissions"] = SourceExpressionConverter.ConvertToken(bodyinheritsPermissions);
                    bodypropCount++;
                }

                if (bodykeepParentPermissions != null)
                {
                    body["keepParentPermissions"] = SourceExpressionConverter.ConvertToken(bodykeepParentPermissions);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<GetFolderPermissionsResponse> GetFolderPermissions([WorkflowExpression] Func<string> bodypath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/GetFolderPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetFolderPermissionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeepLinksByIdResponse> DeepLinksById([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bodytypeInput> bodytype)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/DeepLinksById";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeepLinksByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<DeepLinksByPathResponse> DeepLinksByPath([WorkflowExpression] Func<string> bodypath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/DeepLinksByPath";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeepLinksByPathResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ShowLinkDetailsResponse> ShowLinkDetails([WorkflowExpression] Func<string> bodylinkId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/ShowLinkDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["linkId"] = SourceExpressionConverter.ConvertToken(bodylinkId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ShowLinkDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<CreateLinkResponse> CreateLink([WorkflowExpression] Func<string> bodypath, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<bool> bodyuseDefaultSettings, [WorkflowExpression] Func<bodyaccessibilityInput> bodyaccessibility = null, [WorkflowExpression] Func<bool> bodysendEmail = null, [WorkflowExpression] Func<string[]> bodyrecipients = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<bool> bodycopyMe = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bool> bodylinkToCurrent = null, [WorkflowExpression] Func<string> bodyexpiryDate = null, [WorkflowExpression] Func<double> bodyexpiryClicks = null, [WorkflowExpression] Func<bool> bodyaddFileName = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<bodyprotectionInput> bodyprotection = null, [WorkflowExpression] Func<bool> bodyfolderPerRecipient = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/CreateLink";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodyaccessibility != null)
                {
                    body["accessibility"] = SourceExpressionConverter.Convert(bodyaccessibility);
                    bodypropCount++;
                }

                bodypropCount++;
                body["useDefaultSettings"] = SourceExpressionConverter.ConvertToken(bodyuseDefaultSettings);
                if (bodysendEmail != null)
                {
                    body["send_email"] = SourceExpressionConverter.ConvertToken(bodysendEmail);
                    bodypropCount++;
                }

                if (bodyrecipients != null)
                {
                    body["recipients"] = SourceExpressionConverter.ConvertToken(bodyrecipients);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodycopyMe != null)
                {
                    body["copy_me"] = SourceExpressionConverter.ConvertToken(bodycopyMe);
                    bodypropCount++;
                }

                if (bodynotify != null)
                {
                    body["notify"] = SourceExpressionConverter.ConvertToken(bodynotify);
                    bodypropCount++;
                }

                if (bodylinkToCurrent != null)
                {
                    body["link_to_current"] = SourceExpressionConverter.ConvertToken(bodylinkToCurrent);
                    bodypropCount++;
                }

                if (bodyexpiryDate != null)
                {
                    body["expiry_date"] = SourceExpressionConverter.ConvertToken(bodyexpiryDate);
                    bodypropCount++;
                }

                if (bodyexpiryClicks != null)
                {
                    body["expiry_clicks"] = SourceExpressionConverter.ConvertToken(bodyexpiryClicks);
                    bodypropCount++;
                }

                if (bodyaddFileName != null)
                {
                    body["add_file_name"] = SourceExpressionConverter.ConvertToken(bodyaddFileName);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodyprotection != null)
                {
                    body["protection"] = SourceExpressionConverter.Convert(bodyprotection);
                    bodypropCount++;
                }

                if (bodyfolderPerRecipient != null)
                {
                    body["folder_per_recipient"] = SourceExpressionConverter.ConvertToken(bodyfolderPerRecipient);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IWorkflowAction DeleteLink([WorkflowExpression] Func<string> bodylinkId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/DeleteLink";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["linkId"] = SourceExpressionConverter.ConvertToken(bodylinkId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AIQuestionResponse> AskDocumentQuestion([WorkflowExpression] Func<string> bodyentryId = null, [WorkflowExpression] Func<string> bodyquestion = null, [WorkflowExpression] Func<bool> bodyincludeCitations = null, [WorkflowExpression] Func<AIMessage[]> bodychatHistorymessages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/AskDocumentQuestion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyentryId != null)
                {
                    body["entryId"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                if (bodyquestion != null)
                {
                    body["question"] = SourceExpressionConverter.ConvertToken(bodyquestion);
                    bodypropCount++;
                }

                if (bodyincludeCitations != null)
                {
                    if (bodyincludeCitations != null)
                    {
                        body["includeCitations"] = SourceExpressionConverter.ConvertToken(bodyincludeCitations);
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
                    chatHistoryObject["messages"] = SourceExpressionConverter.ConvertToken(bodychatHistorymessages);
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
                return callPayload;
            }

            return new ApiConnectionAction<AIQuestionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AISummaryResponse> SummarizeDocument([WorkflowExpression] Func<string> bodyentryId = null, [WorkflowExpression] Func<AIMessage[]> bodychatHistorymessages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/SummarizeDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyentryId != null)
                {
                    body["entryId"] = SourceExpressionConverter.ConvertToken(bodyentryId);
                    bodypropCount++;
                }

                var chatHistoryObject = new JObject();
                var chatHistoryObjectpropCount = 0;
                if (bodychatHistorymessages != null)
                {
                    chatHistoryObject["messages"] = SourceExpressionConverter.ConvertToken(bodychatHistorymessages);
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
                return callPayload;
            }

            return new ApiConnectionAction<AISummaryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AICopilotResponse> CopilotAsk([WorkflowExpression] Func<string> bodyquestion = null, [WorkflowExpression] Func<bodyselectedItemsfoldersInputItem[]> bodyselectedItemsfolders = null, [WorkflowExpression] Func<bodyselectedItemsfilesInputItem[]> bodyselectedItemsfiles = null, [WorkflowExpression] Func<bool> bodyincludeCitations = null, [WorkflowExpression] Func<AIMessage[]> bodychatHistorymessages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/CopilotAsk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyquestion != null)
                {
                    body["question"] = SourceExpressionConverter.ConvertToken(bodyquestion);
                    bodypropCount++;
                }

                var selectedItemsObject = new JObject();
                var selectedItemsObjectpropCount = 0;
                if (bodyselectedItemsfolders != null)
                {
                    selectedItemsObject["folders"] = SourceExpressionConverter.ConvertToken(bodyselectedItemsfolders);
                    selectedItemsObjectpropCount++;
                }

                if (bodyselectedItemsfiles != null)
                {
                    selectedItemsObject["files"] = SourceExpressionConverter.ConvertToken(bodyselectedItemsfiles);
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
                        body["includeCitations"] = SourceExpressionConverter.ConvertToken(bodyincludeCitations);
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
                    chatHistoryObject["messages"] = SourceExpressionConverter.ConvertToken(bodychatHistorymessages);
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
                return callPayload;
            }

            return new ApiConnectionAction<AICopilotResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AICopilotResponse> AskKnowledgeBase([WorkflowExpression] Func<string> bodykbId, [WorkflowExpression] Func<string> bodyquestion = null, [WorkflowExpression] Func<bool> bodyincludeCitations = null, [WorkflowExpression] Func<AIMessage[]> bodychatHistorymessages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/AskKnowledgeBase";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["kbId"] = SourceExpressionConverter.ConvertToken(bodykbId);
                if (bodyquestion != null)
                {
                    body["question"] = SourceExpressionConverter.ConvertToken(bodyquestion);
                    bodypropCount++;
                }

                if (bodyincludeCitations != null)
                {
                    if (bodyincludeCitations != null)
                    {
                        body["includeCitations"] = SourceExpressionConverter.ConvertToken(bodyincludeCitations);
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
                    chatHistoryObject["messages"] = SourceExpressionConverter.ConvertToken(bodychatHistorymessages);
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
                return callPayload;
            }

            return new ApiConnectionAction<AICopilotResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<KnowledgeBaseListResponse> ListKnowledgeBases([WorkflowExpression] Func<bodysortByInput> bodysortBy, [WorkflowExpression] Func<bodysortDirectionInput> bodysortDirection, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<int> bodypage = null, [WorkflowExpression] Func<int> bodysize = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<int> bodycreatedAfter = null, [WorkflowExpression] Func<int> bodycreatedBefore = null, [WorkflowExpression] Func<bool> bodyincludePlaceholderData = null, [WorkflowExpression] Func<bool> bodyincludeProcessingStatistics = null, [WorkflowExpression] Func<bool> bodyincludePrompts = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/ListKnowledgeBases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sortBy"] = SourceExpressionConverter.Convert(bodysortBy);
                bodypropCount++;
                body["sortDirection"] = SourceExpressionConverter.Convert(bodysortDirection);
                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                if (bodypage != null)
                {
                    body["page"] = SourceExpressionConverter.ConvertToken(bodypage);
                    bodypropCount++;
                }

                if (bodysize != null)
                {
                    body["size"] = SourceExpressionConverter.ConvertToken(bodysize);
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = SourceExpressionConverter.ConvertToken(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodycreatedAfter != null)
                {
                    body["createdAfter"] = SourceExpressionConverter.ConvertToken(bodycreatedAfter);
                    bodypropCount++;
                }

                if (bodycreatedBefore != null)
                {
                    body["createdBefore"] = SourceExpressionConverter.ConvertToken(bodycreatedBefore);
                    bodypropCount++;
                }

                if (bodyincludePlaceholderData != null)
                {
                    if (bodyincludePlaceholderData != null)
                    {
                        body["includePlaceholderData"] = SourceExpressionConverter.ConvertToken(bodyincludePlaceholderData);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["includePlaceholderData"] = false;
                    bodypropCount++;
                }

                if (bodyincludeProcessingStatistics != null)
                {
                    if (bodyincludeProcessingStatistics != null)
                    {
                        body["includeProcessingStatistics"] = SourceExpressionConverter.ConvertToken(bodyincludeProcessingStatistics);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["includeProcessingStatistics"] = false;
                    bodypropCount++;
                }

                if (bodyincludePrompts != null)
                {
                    if (bodyincludePrompts != null)
                    {
                        body["includePrompts"] = SourceExpressionConverter.ConvertToken(bodyincludePrompts);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["includePrompts"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<KnowledgeBaseListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<HybridSearchResponse> HybridSearch([WorkflowExpression] Func<double> bodysemanticWeight, [WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<string> bodyfolderPath = null, [WorkflowExpression] Func<string> bodycollectionId = null, [WorkflowExpression] Func<string> bodycreatedBy = null, [WorkflowExpression] Func<int> bodycreatedAfter = null, [WorkflowExpression] Func<int> bodycreatedBefore = null, [WorkflowExpression] Func<int> bodylimit = null, [WorkflowExpression] Func<string> bodypreferredFolderPath = null, [WorkflowExpression] Func<string[]> bodyexcludeFolderPaths = null, [WorkflowExpression] Func<string[]> bodyfolderPaths = null, [WorkflowExpression] Func<string[]> bodyentryIds = null, [WorkflowExpression] Func<bool> bodyenableAISafeguards = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/HybridSearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["semanticWeight"] = SourceExpressionConverter.ConvertToken(bodysemanticWeight);
                bodypropCount++;
                body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                if (bodyfolderPath != null)
                {
                    body["folderPath"] = SourceExpressionConverter.ConvertToken(bodyfolderPath);
                    bodypropCount++;
                }

                if (bodycollectionId != null)
                {
                    body["collectionId"] = SourceExpressionConverter.ConvertToken(bodycollectionId);
                    bodypropCount++;
                }

                if (bodycreatedBy != null)
                {
                    body["createdBy"] = SourceExpressionConverter.ConvertToken(bodycreatedBy);
                    bodypropCount++;
                }

                if (bodycreatedAfter != null)
                {
                    body["createdAfter"] = SourceExpressionConverter.ConvertToken(bodycreatedAfter);
                    bodypropCount++;
                }

                if (bodycreatedBefore != null)
                {
                    body["createdBefore"] = SourceExpressionConverter.ConvertToken(bodycreatedBefore);
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    if (bodylimit != null)
                    {
                        body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["limit"] = 100;
                    bodypropCount++;
                }

                if (bodypreferredFolderPath != null)
                {
                    body["preferredFolderPath"] = SourceExpressionConverter.ConvertToken(bodypreferredFolderPath);
                    bodypropCount++;
                }

                if (bodyexcludeFolderPaths != null)
                {
                    body["excludeFolderPaths"] = SourceExpressionConverter.ConvertToken(bodyexcludeFolderPaths);
                    bodypropCount++;
                }

                if (bodyfolderPaths != null)
                {
                    body["folderPaths"] = SourceExpressionConverter.ConvertToken(bodyfolderPaths);
                    bodypropCount++;
                }

                if (bodyentryIds != null)
                {
                    body["entryIds"] = SourceExpressionConverter.ConvertToken(bodyentryIds);
                    bodypropCount++;
                }

                if (bodyenableAISafeguards != null)
                {
                    if (bodyenableAISafeguards != null)
                    {
                        body["enableAISafeguards"] = SourceExpressionConverter.ConvertToken(bodyenableAISafeguards);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["enableAISafeguards"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HybridSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AgentListResponseItem[]> ListAgents([WorkflowExpression] Func<bodysortByInput> bodysortBy = null, [WorkflowExpression] Func<bodysortOrderInput> bodysortOrder = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/ListAgents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysortBy != null)
                {
                    if (bodysortBy != null)
                    {
                        body["sortBy"] = SourceExpressionConverter.Convert(bodysortBy);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["sortBy"] = "name";
                    bodypropCount++;
                }

                if (bodysortOrder != null)
                {
                    if (bodysortOrder != null)
                    {
                        body["sortOrder"] = SourceExpressionConverter.Convert(bodysortOrder);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["sortOrder"] = "asc";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AgentListResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AskAgentResponse> AskAgent([WorkflowExpression] Func<string> bodyagentId, [WorkflowExpression] Func<string> bodyquestion, [WorkflowExpression] Func<string> bodyinstructions = null, [WorkflowExpression] Func<string> bodyconversationId = null, [WorkflowExpression] Func<AIMessage[]> bodychatHistorymessages = null, [WorkflowExpression] Func<string[]> bodyentryIds = null, [WorkflowExpression] Func<bodyselectedItemsfoldersInputItem[]> bodyselectedItemsfolders = null, [WorkflowExpression] Func<bodyselectedItemsfilesInputItem[]> bodyselectedItemsfiles = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/AskAgent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["agentId"] = SourceExpressionConverter.ConvertToken(bodyagentId);
                bodypropCount++;
                body["question"] = SourceExpressionConverter.ConvertToken(bodyquestion);
                if (bodyinstructions != null)
                {
                    body["instructions"] = SourceExpressionConverter.ConvertToken(bodyinstructions);
                    bodypropCount++;
                }

                if (bodyconversationId != null)
                {
                    body["conversationId"] = SourceExpressionConverter.ConvertToken(bodyconversationId);
                    bodypropCount++;
                }

                var chatHistoryObject = new JObject();
                var chatHistoryObjectpropCount = 0;
                if (bodychatHistorymessages != null)
                {
                    chatHistoryObject["messages"] = SourceExpressionConverter.ConvertToken(bodychatHistorymessages);
                    chatHistoryObjectpropCount++;
                }

                if (chatHistoryObjectpropCount > 0)
                {
                    body["chatHistory"] = chatHistoryObject;
                    bodypropCount++;
                }

                if (bodyentryIds != null)
                {
                    body["entryIds"] = SourceExpressionConverter.ConvertToken(bodyentryIds);
                    bodypropCount++;
                }

                var selectedItemsObject = new JObject();
                var selectedItemsObjectpropCount = 0;
                if (bodyselectedItemsfolders != null)
                {
                    selectedItemsObject["folders"] = SourceExpressionConverter.ConvertToken(bodyselectedItemsfolders);
                    selectedItemsObjectpropCount++;
                }

                if (bodyselectedItemsfiles != null)
                {
                    selectedItemsObject["files"] = SourceExpressionConverter.ConvertToken(bodyselectedItemsfiles);
                    selectedItemsObjectpropCount++;
                }

                if (selectedItemsObjectpropCount > 0)
                {
                    body["selectedItems"] = selectedItemsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AskAgentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<AgentExecutionStatusResponse> GetAgentExecutionStatus([WorkflowExpression] Func<string> bodyagentId, [WorkflowExpression] Func<string> bodyrequestId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/GetAgentExecutionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["agentId"] = SourceExpressionConverter.ConvertToken(bodyagentId);
                bodypropCount++;
                body["requestId"] = SourceExpressionConverter.ConvertToken(bodyrequestId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AgentExecutionStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<ListLinksV2Response> ListLinks([WorkflowExpression] Func<string> bodypath = null, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<string> bodycreatedBefore = null, [WorkflowExpression] Func<string> bodycreatedAfter = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<bodyaccessibilityInput> bodyaccessibility = null, [WorkflowExpression] Func<string> bodyoffset = null, [WorkflowExpression] Func<string> bodycount = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/ListLinksV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypath != null)
                {
                    body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                    bodypropCount++;
                }

                if (bodyusername != null)
                {
                    body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                    bodypropCount++;
                }

                if (bodycreatedBefore != null)
                {
                    body["createdBefore"] = SourceExpressionConverter.ConvertToken(bodycreatedBefore);
                    bodypropCount++;
                }

                if (bodycreatedAfter != null)
                {
                    body["createdAfter"] = SourceExpressionConverter.ConvertToken(bodycreatedAfter);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodyaccessibility != null)
                {
                    body["accessibility"] = SourceExpressionConverter.Convert(bodyaccessibility);
                    bodypropCount++;
                }

                if (bodyoffset != null)
                {
                    body["offset"] = SourceExpressionConverter.ConvertToken(bodyoffset);
                    bodypropCount++;
                }

                if (bodycount != null)
                {
                    body["count"] = SourceExpressionConverter.ConvertToken(bodycount);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ListLinksV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "egnyte")]
        public IBodyWorkflowAction<SearchV2Response> Search([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<bool> bodyenableAISafeguards = null, [WorkflowExpression] Func<int> bodyoffset = null, [WorkflowExpression] Func<int> bodycount = null, [WorkflowExpression] Func<string> bodyfolder = null, [WorkflowExpression] Func<int> bodymodifiedBefore = null, [WorkflowExpression] Func<int> bodymodifiedAfter = null, [WorkflowExpression] Func<int> bodyuploadedBefore = null, [WorkflowExpression] Func<int> bodyuploadedAfter = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<bool> bodysnippetRequested = null, [WorkflowExpression] Func<bodysortByInput> bodysortBy = null, [WorkflowExpression] Func<bodysortDirectionInput> bodysortDirection = null, [WorkflowExpression] Func<bodyfileQueryFieldsInputItem[]> bodyfileQueryFields = null, [WorkflowExpression] Func<bodyfolderQueryFieldsInputItem[]> bodyfolderQueryFields = null, [WorkflowExpression] Func<bodyqueryOperatorInput> bodyqueryOperator = null, [WorkflowExpression] Func<string[]> bodymlt = null, [WorkflowExpression] Func<string[]> bodymltt = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api-proxy/SearchV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                if (bodyenableAISafeguards != null)
                {
                    if (bodyenableAISafeguards != null)
                    {
                        body["enableAISafeguards"] = SourceExpressionConverter.ConvertToken(bodyenableAISafeguards);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["enableAISafeguards"] = false;
                    bodypropCount++;
                }

                if (bodyoffset != null)
                {
                    body["offset"] = SourceExpressionConverter.ConvertToken(bodyoffset);
                    bodypropCount++;
                }

                if (bodycount != null)
                {
                    body["count"] = SourceExpressionConverter.ConvertToken(bodycount);
                    bodypropCount++;
                }

                if (bodyfolder != null)
                {
                    body["folder"] = SourceExpressionConverter.ConvertToken(bodyfolder);
                    bodypropCount++;
                }

                if (bodymodifiedBefore != null)
                {
                    body["modifiedBefore"] = SourceExpressionConverter.ConvertToken(bodymodifiedBefore);
                    bodypropCount++;
                }

                if (bodymodifiedAfter != null)
                {
                    body["modifiedAfter"] = SourceExpressionConverter.ConvertToken(bodymodifiedAfter);
                    bodypropCount++;
                }

                if (bodyuploadedBefore != null)
                {
                    body["uploadedBefore"] = SourceExpressionConverter.ConvertToken(bodyuploadedBefore);
                    bodypropCount++;
                }

                if (bodyuploadedAfter != null)
                {
                    body["uploadedAfter"] = SourceExpressionConverter.ConvertToken(bodyuploadedAfter);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.Convert(bodytype);
                    bodypropCount++;
                }

                if (bodysnippetRequested != null)
                {
                    if (bodysnippetRequested != null)
                    {
                        body["snippetRequested"] = SourceExpressionConverter.ConvertToken(bodysnippetRequested);
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
                    body["sortBy"] = SourceExpressionConverter.Convert(bodysortBy);
                    bodypropCount++;
                }

                if (bodysortDirection != null)
                {
                    body["sortDirection"] = SourceExpressionConverter.Convert(bodysortDirection);
                    bodypropCount++;
                }

                if (bodyfileQueryFields != null)
                {
                    body["fileQueryFields"] = SourceExpressionConverter.ConvertToken(bodyfileQueryFields);
                    bodypropCount++;
                }

                if (bodyfolderQueryFields != null)
                {
                    body["folderQueryFields"] = SourceExpressionConverter.ConvertToken(bodyfolderQueryFields);
                    bodypropCount++;
                }

                if (bodyqueryOperator != null)
                {
                    body["queryOperator"] = SourceExpressionConverter.Convert(bodyqueryOperator);
                    bodypropCount++;
                }

                if (bodymlt != null)
                {
                    body["mlt"] = SourceExpressionConverter.ConvertToken(bodymlt);
                    bodypropCount++;
                }

                if (bodymltt != null)
                {
                    body["mltt"] = SourceExpressionConverter.ConvertToken(bodymltt);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SearchV2Response>(BuildSourceInput);
        }
    }

    public class EgnyteTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger FileLocked([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/FileLocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger FileUnlocked([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/FileUnlocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger FileUpdated([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/FileUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger FileCreated([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/FileCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger ShareLinkCreated([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/ShareLinkCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger ShareLinkDeleted([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/ShareLinkDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger FileOrFolderPermissionChange([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/FileOrFolderPermissionChange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger FileOrFolderMetadataChange([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/FileOrFolderMetadataChange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger FolderProjectAdded([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/FolderProjectAdded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger FolderProjectUnmarked([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/FolderProjectUnmarked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger FolderProjectUpdated([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/FolderProjectUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WorkflowCreated([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/WorkflowCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WorkflowCompleted([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/WorkflowCompleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WorkflowApprovalTaskApproved([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/WorkflowApprovalTaskApproved";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WorkflowApprovalTaskRejected([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/WorkflowApprovalTaskRejected";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger GroupCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/GroupCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger GroupUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/GroupUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger GroupDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhook/GroupDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollCreatedFilesResponseItem[]> PollCreatedFiles([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/polling/created-files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollCreatedFilesResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollCreatedFoldersResponseItem[]> PollCreatedFolders([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/polling/created-folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollCreatedFoldersResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollDeletedFilesResponseItem[]> PollDeletedFiles([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/polling/deleted-files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollDeletedFilesResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollDeletedFoldersResponseItem[]> PollDeletedFolders([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/polling/deleted-folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollDeletedFoldersResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollRenamedFilesResponseItem[]> PollRenamedFiles([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/polling/renamed-files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollRenamedFilesResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollRenamedFoldersResponseItem[]> PollRenamedFolders([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/polling/renamed-folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollRenamedFoldersResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollMovedFilesResponseItem[]> PollMovedFiles([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/polling/moved-files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollMovedFilesResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollMovedFoldersResponseItem[]> PollMovedFolders([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/polling/moved-folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollMovedFoldersResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollCopiedFilesResponseItem[]> PollCopiedFiles([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/polling/copied-files";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollCopiedFilesResponseItem[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<PollCopiedFoldersResponseItem[]> PollCopiedFolders([WorkflowExpression] Func<string> folderPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/polling/copied-folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FolderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionTrigger<PollCopiedFoldersResponseItem[]>(BuildSourceInput, triggerName, recurrence);
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
        ACTIVE,
        DELETED,
        CREATED
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

    public enum bodyaccessibilityInput
    {
        [EnumMember(Value = "anyone")]
        Anyone,
        [EnumMember(Value = "password")]
        Password,
        [EnumMember(Value = "domain")]
        Domain,
        [EnumMember(Value = "recipients")]
        Recipients
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

    public class KnowledgeBaseListResponse
    {
        [JsonProperty("content")]
        public KnowledgeBaseListResponseContentTypeItem[] Content { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("fileLimit")]
        public int FileLimit { get; set; }
    }

    public class KnowledgeBaseListResponseContentTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("paths")]
        public KnowledgeBaseListResponseContentTypeItemPathsTypeItem[] Paths { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdByUser")]
        public KnowledgeBaseListResponseContentTypeItemCreatedByUserType CreatedByUser { get; set; }

        [JsonProperty("createdOn")]
        public int CreatedOn { get; set; }

        [JsonProperty("noResponseMessage")]
        public string NoResponseMessage { get; set; }

        [JsonProperty("iconName")]
        public string IconName { get; set; }

        [JsonProperty("subType")]
        public string SubType { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("lastProcessedAt")]
        public int LastProcessedAt { get; set; }

        [JsonProperty("pathCount")]
        public int PathCount { get; set; }

        [JsonProperty("prompts")]
        public JToken[] Prompts { get; set; }
    }

    public class KnowledgeBaseListResponseContentTypeItemPathsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("folderId")]
        public string FolderId { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class KnowledgeBaseListResponseContentTypeItemCreatedByUserType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("userId")]
        public int UserId { get; set; }
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

    public class HybridSearchResponse
    {
        [JsonProperty("results")]
        public HybridSearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class HybridSearchResponseResultsTypeItem
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("entryId")]
        public string EntryId { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("chunks")]
        public HybridSearchResponseResultsTypeItemChunksTypeItem[] Chunks { get; set; }
    }

    public class HybridSearchResponseResultsTypeItemChunksTypeItem
    {
        [JsonProperty("chunkId")]
        public string ChunkId { get; set; }

        [JsonProperty("chunkText")]
        public string ChunkText { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class AgentListResponseItem
    {
        [JsonProperty("agentId")]
        public string AgentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subType")]
        public string SubType { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("instruction")]
        public string Instruction { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public enum bodysortOrderInput
    {
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class AskAgentResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("conversationId")]
        public string ConversationId { get; set; }
    }

    public class AgentExecutionStatusResponse
    {
        [JsonProperty("status")]
        public AgentExecutionStatusResponseStatusType Status { get; set; }

        [JsonProperty("responseText")]
        public string ResponseText { get; set; }

        [JsonProperty("citations")]
        public AgentExecutionStatusResponseCitationsTypeItem[] Citations { get; set; }

        [JsonProperty("lastUpdated")]
        public int LastUpdated { get; set; }
    }

    public enum AgentExecutionStatusResponseStatusType
    {
        PENDING,
        RUNNING,
        COMPLETED,
        FAILED
    }

    public class AgentExecutionStatusResponseCitationsTypeItem
    {
        [JsonProperty("previewUrl")]
        public string PreviewUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ListLinksV2Response
    {
        [JsonProperty("links")]
        public ListLinksV2ResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("count")]
        public double Count { get; set; }
    }

    public class ListLinksV2ResponseLinksTypeItem
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("accessibility")]
        public string Accessibility { get; set; }

        [JsonProperty("protection")]
        public string Protection { get; set; }

        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("link_to_current")]
        public bool LinkToCurrent { get; set; }

        [JsonProperty("creation_date")]
        public string CreationDate { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("resource_id")]
        public string ResourceId { get; set; }

        [JsonProperty("expiry_clicks")]
        public double ExpiryClicks { get; set; }

        [JsonProperty("last_accessed")]
        public string LastAccessed { get; set; }

        [JsonProperty("expiry_date")]
        public string ExpiryDate { get; set; }
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