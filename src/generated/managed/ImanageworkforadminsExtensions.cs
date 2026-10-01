//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanageworkforadmins
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanageworkforadminsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<GetLibraryRolesResponse> GetLibraryRoles([WorkflowExpression] Func<string> libraryId, [WorkflowExpression] Func<bool> isExternal = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getLibraryRoles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = SourceExpressionConverter.ConvertO(libraryId);
                if (isExternal != null)
                    callPayload.Queries["is_external"] = SourceExpressionConverter.ConvertO(isExternal);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                return callPayload;
            }

            return new ApiConnectionAction<GetLibraryRolesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<GetLookupAliasesResponse> GetLookupAliases([WorkflowExpression] Func<string> libraryId, [WorkflowExpression] Func<string> lookupFieldId, [WorkflowExpression] Func<string> parentAlias = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getLookupAliases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = SourceExpressionConverter.ConvertO(libraryId);
                callPayload.Queries["lookupFieldId"] = SourceExpressionConverter.ConvertO(lookupFieldId);
                if (parentAlias != null)
                    callPayload.Queries["parentAlias"] = SourceExpressionConverter.ConvertO(parentAlias);
                callPayload.Queries["getParentAliases"] = Convert.ToString(false);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                return callPayload;
            }

            return new ApiConnectionAction<GetLookupAliasesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<SearchCustomPropertyResponseBody> SearchCustomPropertyAliases([WorkflowExpression] Func<string> libraryId, [WorkflowExpression] Func<string> lookupFieldId, [WorkflowExpression] Func<string> parentAlias = null, [WorkflowExpression] Func<string> alias = null, [WorkflowExpression] Func<string> description = null, [WorkflowExpression] Func<bool> hipaa = null, [WorkflowExpression] Func<enabledStateInput> enabledState = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/searchCustomPropertyAliases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = SourceExpressionConverter.ConvertO(libraryId);
                callPayload.Queries["lookupFieldId"] = SourceExpressionConverter.ConvertO(lookupFieldId);
                if (parentAlias != null)
                    callPayload.Queries["parentAlias"] = SourceExpressionConverter.ConvertO(parentAlias);
                if (alias != null)
                    callPayload.Queries["alias"] = SourceExpressionConverter.ConvertO(alias);
                if (description != null)
                    callPayload.Queries["description"] = SourceExpressionConverter.ConvertO(description);
                callPayload.Queries["hipaa"] = Convert.ToString(false);
                if (hipaa != null)
                    callPayload.Queries["hipaa"] = SourceExpressionConverter.ConvertO(hipaa);
                callPayload.Queries["enabled_state"] = Convert.ToString("Both Enabled and Disabled");
                if (enabledState != null)
                    callPayload.Queries["enabled_state"] = SourceExpressionConverter.Convert(enabledState);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                return callPayload;
            }

            return new ApiConnectionAction<SearchCustomPropertyResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<JToken> CreateCustomOrPropertyLookup([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodylookupFieldId, [WorkflowExpression] Func<object> bodyaliasInfo)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/createCustomOrPropertyLookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["lookupFieldId"] = SourceExpressionConverter.ConvertToken(bodylookupFieldId);
                bodypropCount++;
                body["aliasInfo"] = SourceExpressionConverter.ConvertToken(bodyaliasInfo);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser([WorkflowExpression] Func<string> bodyfullName, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<bool> bodyisExternal, [WorkflowExpression] Func<string> bodypreferredLibrary, [WorkflowExpression] Func<string> bodyrole, [WorkflowExpression] Func<bool> bodyignoreIfUserAlreadyExists, [WorkflowExpression] Func<bodypasswordCreateMethodInput> bodypasswordCreateMethod, [WorkflowExpression] Func<object> bodycreatePassword)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/createUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["full_name"] = SourceExpressionConverter.ConvertToken(bodyfullName);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["is_external"] = SourceExpressionConverter.ConvertToken(bodyisExternal);
                bodypropCount++;
                body["preferred_library"] = SourceExpressionConverter.ConvertToken(bodypreferredLibrary);
                bodypropCount++;
                body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                bodypropCount++;
                body["ignore_if_user_already_exists"] = SourceExpressionConverter.ConvertToken(bodyignoreIfUserAlreadyExists);
                bodypropCount++;
                body["password_create_method"] = SourceExpressionConverter.Convert(bodypasswordCreateMethod);
                bodypropCount++;
                body["create_password"] = SourceExpressionConverter.ConvertToken(bodycreatePassword);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<AssignUserToLibraryResponse> AssignUserToLibrary([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodyuserId, [WorkflowExpression] Func<string> bodyrole, [WorkflowExpression] Func<bool> bodyisPreferredLibrary)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/assignUserToLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                bodypropCount++;
                body["role"] = SourceExpressionConverter.ConvertToken(bodyrole);
                bodypropCount++;
                body["is_preferred_library"] = SourceExpressionConverter.ConvertToken(bodyisPreferredLibrary);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AssignUserToLibraryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<CreateFolderResponseBody> AddFolder([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyparentId, [WorkflowExpression] Func<bodyparentTypeInput> bodyparentType, [WorkflowExpression] Func<bodydefaultSecurityInput> bodydefaultSecurity, [WorkflowExpression] Func<bodyinheritProfileFromWorkspaceInput> bodyinheritProfileFromWorkspace, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<string> bodyClass = null, [WorkflowExpression] Func<string> bodysubclass = null, [WorkflowExpression] Func<bool> bodyisExternalAsNormal = null, [WorkflowExpression] Func<object> bodyprofileProperties = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/addFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                bodypropCount++;
                body["parentType"] = SourceExpressionConverter.Convert(bodyparentType);
                bodypropCount++;
                body["default_security"] = SourceExpressionConverter.Convert(bodydefaultSecurity);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyowner != null)
                {
                    body["owner"] = SourceExpressionConverter.ConvertToken(bodyowner);
                    bodypropCount++;
                }

                if (bodyClass != null)
                {
                    body["class"] = SourceExpressionConverter.ConvertToken(bodyClass);
                    bodypropCount++;
                }

                if (bodysubclass != null)
                {
                    body["subclass"] = SourceExpressionConverter.ConvertToken(bodysubclass);
                    bodypropCount++;
                }

                if (bodyisExternalAsNormal != null)
                {
                    if (bodyisExternalAsNormal != null)
                    {
                        body["is_external_as_normal"] = SourceExpressionConverter.ConvertToken(bodyisExternalAsNormal);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["is_external_as_normal"] = false;
                    bodypropCount++;
                }

                bodypropCount++;
                body["inherit_profile_from_workspace"] = SourceExpressionConverter.Convert(bodyinheritProfileFromWorkspace);
                if (bodyprofileProperties != null)
                {
                    body["profileProperties"] = SourceExpressionConverter.ConvertToken(bodyprofileProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateFolderResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<CreateTabResponseBody> AddTab([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyparentId, [WorkflowExpression] Func<bodydefaultSecurityInput> bodydefaultSecurity, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyowner = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/addTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["parentId"] = SourceExpressionConverter.ConvertToken(bodyparentId);
                bodypropCount++;
                body["default_security"] = SourceExpressionConverter.Convert(bodydefaultSecurity);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyowner != null)
                {
                    body["owner"] = SourceExpressionConverter.ConvertToken(bodyowner);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateTabResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<GetMyMattersCategoriesResponse> GetMyMattersCategories([WorkflowExpression] Func<string> userId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getMyMattersCategories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["user_id"] = SourceExpressionConverter.ConvertO(userId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                return callPayload;
            }

            return new ApiConnectionAction<GetMyMattersCategoriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<AddShortcutsToMyMattersAdminResponse> AddShortcutsToMyMattersAdmin([WorkflowExpression] Func<string> bodyuserId, [WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodycategoryId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/addShortcutsToMyMattersAdmin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["user_id"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                bodypropCount++;
                body["workspace_id"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                if (bodycategoryId != null)
                {
                    body["category_id"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddShortcutsToMyMattersAdminResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<JToken> UpdateCustomField([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodylookupFieldId, [WorkflowExpression] Func<object> bodyaliasInfo)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updateCustomField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = SourceExpressionConverter.ConvertToken(bodylibraryId);
                bodypropCount++;
                body["lookupFieldId"] = SourceExpressionConverter.ConvertToken(bodylookupFieldId);
                bodypropCount++;
                body["aliasInfo"] = SourceExpressionConverter.ConvertToken(bodyaliasInfo);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<GetRowsFromCSVDocumentResponse> GetRowsFromCSVDocument([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodycolumnNames, [WorkflowExpression] Func<bool> bodylatest = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/getRowsFromCSVDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["column_names"] = SourceExpressionConverter.ConvertToken(bodycolumnNames);
                if (bodylatest != null)
                {
                    if (bodylatest != null)
                    {
                        body["latest"] = SourceExpressionConverter.ConvertToken(bodylatest);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["latest"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetRowsFromCSVDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<MoveFolderResponseBody> MoveFolder([WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodydestinationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/moveFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["folder_id"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                bodypropCount++;
                body["destination_id"] = SourceExpressionConverter.ConvertToken(bodydestinationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MoveFolderResponseBody>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<UpdateFolderPropertiesResponseBody> UpdateFolder([WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bodydefaultSecurityInput> bodydefaultSecurity = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<string> bodyClass = null, [WorkflowExpression] Func<string> bodysubclass = null, [WorkflowExpression] Func<bool> bodyisExternalAsNormal = null, [WorkflowExpression] Func<object> bodyprofile = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updateFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["folderId"] = SourceExpressionConverter.ConvertToken(bodyfolderId);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydefaultSecurity != null)
                {
                    if (bodydefaultSecurity != null)
                    {
                        body["default_security"] = SourceExpressionConverter.Convert(bodydefaultSecurity);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["default_security"] = "no change";
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyowner != null)
                {
                    body["owner"] = SourceExpressionConverter.ConvertToken(bodyowner);
                    bodypropCount++;
                }

                if (bodyClass != null)
                {
                    body["class"] = SourceExpressionConverter.ConvertToken(bodyClass);
                    bodypropCount++;
                }

                if (bodysubclass != null)
                {
                    body["subclass"] = SourceExpressionConverter.ConvertToken(bodysubclass);
                    bodypropCount++;
                }

                if (bodyisExternalAsNormal != null)
                {
                    if (bodyisExternalAsNormal != null)
                    {
                        body["is_external_as_normal"] = SourceExpressionConverter.ConvertToken(bodyisExternalAsNormal);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["is_external_as_normal"] = false;
                    bodypropCount++;
                }

                if (bodyprofile != null)
                {
                    body["profile"] = SourceExpressionConverter.ConvertToken(bodyprofile);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateFolderPropertiesResponseBody>(BuildSourceInput);
        }
    }

    public class ImanageworkforadminsTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetLibraryRolesResponse
    {
        [JsonProperty("data")]
        public GetLibraryRolesResponseDataTypeItem[] Data { get; set; }
    }

    public class GetLibraryRolesResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GetLookupAliasesResponse
    {
        [JsonProperty("data")]
        public GetLookupAliasesResponseDataTypeItem[] Data { get; set; }
    }

    public class GetLookupAliasesResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class SearchCustomPropertyResponseBody
    {
        [JsonProperty("data")]
        public SearchCustomPropertyResponseBodyDataType Data { get; set; }
    }

    public class SearchCustomPropertyResponseBodyDataType
    {
        [JsonProperty("topMatchingResult")]
        public SearchCustomPropertyResponseBodyDataTypeTopMatchingResultType TopMatchingResult { get; set; }

        [JsonProperty("results")]
        public SearchCustomPropertyResult[] Results { get; set; }
    }

    public class SearchCustomPropertyResponseBodyDataTypeTopMatchingResultType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hipaa")]
        public bool Hipaa { get; set; }
    }

    public class SearchCustomPropertyResult
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("hipaa")]
        public bool Hipaa { get; set; }
    }

    public enum enabledStateInput
    {
        Enabled,
        Disabled,
        [EnumMember(Value = "Both Enabled and Disabled")]
        BothEnabledAndDisabled
    }

    public class CreateUserResponse
    {
        [JsonProperty("data")]
        public CreateUserResponseDataType Data { get; set; }
    }

    public class CreateUserResponseDataType
    {
        [JsonProperty("user_num")]
        public int UserNum { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("preferred_library")]
        public string PreferredLibrary { get; set; }

        [JsonProperty("user_nos")]
        public int UserNos { get; set; }

        [JsonProperty("user_id_ex")]
        public string UserIdEx { get; set; }

        [JsonProperty("ssid")]
        public string Ssid { get; set; }

        [JsonProperty("pwd_never_expire")]
        public bool PwdNeverExpire { get; set; }

        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("has_password")]
        public bool HasPassword { get; set; }

        [JsonProperty("force_password_change")]
        public bool ForcePasswordChange { get; set; }

        [JsonProperty("failed_logins")]
        public int FailedLogins { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("pwd_changed_ts")]
        public string PwdChangedTs { get; set; }

        [JsonProperty("allow_logon")]
        public bool AllowLogon { get; set; }

        [JsonProperty("user_created")]
        public bool UserCreated { get; set; }
    }

    public enum bodypasswordCreateMethodInput
    {
        [EnumMember(Value = "Send an email")]
        SendAnEmail,
        [EnumMember(Value = "Create a password")]
        CreateAPassword
    }

    public class AssignUserToLibraryResponse
    {
        [JsonProperty("data")]
        public AssignUserToLibraryResponseDataType Data { get; set; }
    }

    public class AssignUserToLibraryResponseDataType
    {
        [JsonProperty("user_num")]
        public double UserNum { get; set; }
    }

    public class CreateFolderResponseBody
    {
        [JsonProperty("data")]
        public NewFolderProfile Data { get; set; }
    }

    public class NewFolderProfile
    {
        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("default_security")]
        public NewFolderProfileDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("edit_date")]
        public string EditDate { get; set; }

        [JsonProperty("effective_security")]
        public NewFolderProfileEffectiveSecurityType EffectiveSecurity { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("folder_type")]
        public NewFolderProfileFolderTypeType FolderType { get; set; }

        [JsonProperty("folder_url")]
        public string FolderUrl { get; set; }

        [JsonProperty("has_documents")]
        public bool HasDocuments { get; set; }

        [JsonProperty("has_subfolders")]
        public bool HasSubfolders { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("inherited_default_security")]
        public NewFolderProfileInheritedDefaultSecurityType InheritedDefaultSecurity { get; set; }

        [JsonProperty("is_container_saved_search")]
        public bool IsContainerSavedSearch { get; set; }

        [JsonProperty("is_content_saved_search")]
        public bool IsContentSavedSearch { get; set; }

        [JsonProperty("is_external")]
        public bool IsExternal { get; set; }

        [JsonProperty("is_external_as_normal")]
        public bool IsExternalAsNormal { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("owner_description")]
        public string OwnerDescription { get; set; }

        [JsonProperty("profile")]
        public NewFolderProfileProfileType Profile { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("view_type")]
        public NewFolderProfileViewTypeType ViewType { get; set; }

        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        [JsonProperty("workspace_name")]
        public string WorkspaceName { get; set; }

        [JsonProperty("wstype")]
        public NewFolderProfileWstypeType Wstype { get; set; }
    }

    public enum NewFolderProfileDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    public enum NewFolderProfileEffectiveSecurityType
    {
        [EnumMember(Value = "no_access")]
        NoAccess,
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "read_write")]
        ReadWrite,
        [EnumMember(Value = "full_access")]
        FullAccess
    }

    public enum NewFolderProfileFolderTypeType
    {
        [EnumMember(Value = "regular")]
        Regular,
        [EnumMember(Value = "search")]
        Search,
        [EnumMember(Value = "tab")]
        Tab,
        [EnumMember(Value = "category")]
        Category,
        [EnumMember(Value = "my_matters")]
        MyMatters,
        [EnumMember(Value = "my_favorites")]
        MyFavorites
    }

    public enum NewFolderProfileInheritedDefaultSecurityType
    {
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "view")]
        View
    }

    public class NewFolderProfileProfileType
    {
        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("subclass")]
        public string Subclass { get; set; }

        [JsonProperty("custom1")]
        public string Custom1 { get; set; }

        [JsonProperty("custom2")]
        public string Custom2 { get; set; }

        [JsonProperty("custom3")]
        public string Custom3 { get; set; }

        [JsonProperty("custom4")]
        public string Custom4 { get; set; }

        [JsonProperty("custom5")]
        public string Custom5 { get; set; }

        [JsonProperty("custom6")]
        public string Custom6 { get; set; }

        [JsonProperty("custom7")]
        public string Custom7 { get; set; }

        [JsonProperty("custom8")]
        public string Custom8 { get; set; }

        [JsonProperty("custom9")]
        public string Custom9 { get; set; }

        [JsonProperty("custom10")]
        public string Custom10 { get; set; }

        [JsonProperty("custom11")]
        public string Custom11 { get; set; }

        [JsonProperty("custom12")]
        public string Custom12 { get; set; }

        [JsonProperty("custom13")]
        public string Custom13 { get; set; }

        [JsonProperty("custom14")]
        public string Custom14 { get; set; }

        [JsonProperty("custom15")]
        public string Custom15 { get; set; }

        [JsonProperty("custom16")]
        public string Custom16 { get; set; }

        [JsonProperty("custom17")]
        public double Custom17 { get; set; }

        [JsonProperty("custom18")]
        public double Custom18 { get; set; }

        [JsonProperty("custom19")]
        public double Custom19 { get; set; }

        [JsonProperty("custom20")]
        public double Custom20 { get; set; }

        [JsonProperty("custom21")]
        public string Custom21 { get; set; }

        [JsonProperty("custom22")]
        public string Custom22 { get; set; }

        [JsonProperty("custom23")]
        public string Custom23 { get; set; }

        [JsonProperty("custom24")]
        public string Custom24 { get; set; }

        [JsonProperty("custom25")]
        public bool Custom25 { get; set; }

        [JsonProperty("custom26")]
        public bool Custom26 { get; set; }

        [JsonProperty("custom27")]
        public bool Custom27 { get; set; }

        [JsonProperty("custom28")]
        public bool Custom28 { get; set; }

        [JsonProperty("custom29")]
        public string Custom29 { get; set; }

        [JsonProperty("custom30")]
        public string Custom30 { get; set; }
    }

    public enum NewFolderProfileViewTypeType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "email_search")]
        EmailSearch,
        [EnumMember(Value = "document_search")]
        DocumentSearch,
        [EnumMember(Value = "linksite")]
        Linksite,
        [EnumMember(Value = "imanage_share")]
        ImanageShare
    }

    public enum NewFolderProfileWstypeType
    {
        [EnumMember(Value = "folder")]
        Folder,
        [EnumMember(Value = "workspace")]
        Workspace,
        [EnumMember(Value = "folder_shortcut")]
        FolderShortcut,
        [EnumMember(Value = "workspace_shortcut")]
        WorkspaceShortcut
    }

    public enum bodyparentTypeInput
    {
        Folder,
        Workspace,
        Tab
    }

    public enum bodydefaultSecurityInput
    {
        [EnumMember(Value = "no change")]
        NoChange,
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    public enum bodyinheritProfileFromWorkspaceInput
    {
        Yes,
        No
    }

    public class CreateTabResponseBody
    {
        [JsonProperty("data")]
        public NewTabProfile Data { get; set; }
    }

    public class NewTabProfile
    {
        [JsonProperty("database")]
        public string Database { get; set; }

        [JsonProperty("default_security")]
        public NewTabProfileDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("owner_description")]
        public string OwnerDescription { get; set; }

        [JsonProperty("tab_url")]
        public string TabUrl { get; set; }

        [JsonProperty("workspace_id")]
        public string WorkspaceId { get; set; }

        [JsonProperty("workspace_name")]
        public string WorkspaceName { get; set; }
    }

    public enum NewTabProfileDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    public class GetMyMattersCategoriesResponse
    {
        [JsonProperty("data")]
        public GetMyMattersCategoriesResponseDataTypeItem[] Data { get; set; }
    }

    public class GetMyMattersCategoriesResponseDataTypeItem
    {
        [JsonProperty("category_type")]
        public GetMyMattersCategoriesResponseDataTypeItemCategoryTypeType CategoryType { get; set; }

        [JsonProperty("default_security")]
        public GetMyMattersCategoriesResponseDataTypeItemDefaultSecurityType DefaultSecurity { get; set; }

        [JsonProperty("has_subfolders")]
        public bool HasSubfolders { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }
    }

    public enum GetMyMattersCategoriesResponseDataTypeItemCategoryTypeType
    {
        [EnumMember(Value = "my_matters")]
        MyMatters,
        [EnumMember(Value = "my_favorites")]
        MyFavorites
    }

    public enum GetMyMattersCategoriesResponseDataTypeItemDefaultSecurityType
    {
        [EnumMember(Value = "inherit")]
        Inherit,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "view")]
        View,
        [EnumMember(Value = "public")]
        Public
    }

    public class AddShortcutsToMyMattersAdminResponse
    {
        [JsonProperty("data")]
        public AddShortcutsToMyMattersAdminResponseDataType Data { get; set; }
    }

    public class AddShortcutsToMyMattersAdminResponseDataType
    {
        [JsonProperty("shortcuts")]
        public MyMattersShortcutsInArray[] Shortcuts { get; set; }

        [JsonProperty("all_workspace_shortcut_ids")]
        public string AllWorkspaceShortcutIds { get; set; }
    }

    public class MyMattersShortcutsInArray
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("wstype")]
        public MyMattersShortcutsInArrayWstypeType Wstype { get; set; }

        [JsonProperty("target")]
        public MyMattersShortcutsInArrayTargetType Target { get; set; }
    }

    public enum MyMattersShortcutsInArrayWstypeType
    {
        [EnumMember(Value = "workspace_shortcut")]
        WorkspaceShortcut
    }

    public class MyMattersShortcutsInArrayTargetType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class GetRowsFromCSVDocumentResponse
    {
        [JsonProperty("data")]
        public GetRowsFromCSVDocumentResponseDataType Data { get; set; }
    }

    public class GetRowsFromCSVDocumentResponseDataType
    {
        [JsonProperty("rows")]
        public JToken[] Rows { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class MoveFolderResponseBody
    {
        [JsonProperty("data")]
        public MoveFolderResponseBodyDataType Data { get; set; }
    }

    public class MoveFolderResponseBodyDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("folder_url")]
        public string FolderUrl { get; set; }
    }

    public class UpdateFolderPropertiesResponseBody
    {
        [JsonProperty("data")]
        public NewFolderProfile Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Imanageworkforadmins;

    public partial class WorkflowManagedActions
    {
        public ImanageworkforadminsActions Imanageworkforadmins(string connectionId) => new ImanageworkforadminsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ImanageworkforadminsTriggers Imanageworkforadmins(string connectionId) => new ImanageworkforadminsTriggers(connectionId);
    }
}