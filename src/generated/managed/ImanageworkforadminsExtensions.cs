//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanageworkforadmins
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanageworkforadminsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<GetLibraryRolesResponse, ApiConnectionActionConfiguration> GetLibraryRoles(Expression<Func<string>> libraryId, Expression<Func<bool>> isExternal = null)
        {
            var __workflow_libraryId = WorkflowExpression.Compile(libraryId, nameof(libraryId), required: true);
            var __workflow_isExternal = WorkflowExpression.Compile(isExternal, nameof(isExternal), required: false);
            return new DeferredBodyAction<GetLibraryRolesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getLibraryRoles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(__workflow_libraryId);
                if (__workflow_isExternal != null)
                    callPayload.Queries["is_external"] = ExpressionConverter.Convert(__workflow_isExternal);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                return new ApiConnectionAction<GetLibraryRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<GetLookupAliasesResponse, ApiConnectionActionConfiguration> GetLookupAliases(Expression<Func<string>> libraryId, Expression<Func<string>> lookupFieldId, Expression<Func<string>> parentAlias = null)
        {
            var __workflow_libraryId = WorkflowExpression.Compile(libraryId, nameof(libraryId), required: true);
            var __workflow_lookupFieldId = WorkflowExpression.Compile(lookupFieldId, nameof(lookupFieldId), required: true);
            var __workflow_parentAlias = WorkflowExpression.Compile(parentAlias, nameof(parentAlias), required: false);
            return new DeferredBodyAction<GetLookupAliasesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getLookupAliases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(__workflow_libraryId);
                callPayload.Queries["lookupFieldId"] = ExpressionConverter.Convert(__workflow_lookupFieldId);
                if (__workflow_parentAlias != null)
                    callPayload.Queries["parentAlias"] = ExpressionConverter.Convert(__workflow_parentAlias);
                callPayload.Queries["getParentAliases"] = Convert.ToString(false);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                return new ApiConnectionAction<GetLookupAliasesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<SearchCustomPropertyResponseBody, ApiConnectionActionConfiguration> SearchCustomPropertyAliases(Expression<Func<string>> libraryId, Expression<Func<string>> lookupFieldId, Expression<Func<string>> parentAlias = null, Expression<Func<string>> alias = null, Expression<Func<string>> description = null, Expression<Func<bool>> hipaa = null, Expression<Func<enabledStateInput>> enabledState = null)
        {
            var __workflow_libraryId = WorkflowExpression.Compile(libraryId, nameof(libraryId), required: true);
            var __workflow_lookupFieldId = WorkflowExpression.Compile(lookupFieldId, nameof(lookupFieldId), required: true);
            var __workflow_parentAlias = WorkflowExpression.Compile(parentAlias, nameof(parentAlias), required: false);
            var __workflow_alias = WorkflowExpression.Compile(alias, nameof(alias), required: false);
            var __workflow_description = WorkflowExpression.Compile(description, nameof(description), required: false);
            var __workflow_hipaa = WorkflowExpression.Compile(hipaa, nameof(hipaa), required: false);
            var __workflow_enabledState = WorkflowExpression.Compile(enabledState, nameof(enabledState), required: false);
            return new DeferredBodyAction<SearchCustomPropertyResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/searchCustomPropertyAliases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(__workflow_libraryId);
                callPayload.Queries["lookupFieldId"] = ExpressionConverter.Convert(__workflow_lookupFieldId);
                if (__workflow_parentAlias != null)
                    callPayload.Queries["parentAlias"] = ExpressionConverter.Convert(__workflow_parentAlias);
                if (__workflow_alias != null)
                    callPayload.Queries["alias"] = ExpressionConverter.Convert(__workflow_alias);
                if (__workflow_description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                callPayload.Queries["hipaa"] = Convert.ToString(false);
                if (__workflow_hipaa != null)
                    callPayload.Queries["hipaa"] = ExpressionConverter.Convert(__workflow_hipaa);
                callPayload.Queries["enabled_state"] = Convert.ToString("Both Enabled and Disabled");
                if (__workflow_enabledState != null)
                    callPayload.Queries["enabled_state"] = ExpressionConverter.Convert(__workflow_enabledState);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                return new ApiConnectionAction<SearchCustomPropertyResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateCustomOrPropertyLookup(Expression<Func<CreateCustomOrPropertyLookupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createCustomOrPropertyLookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<CreateUserResponse, ApiConnectionActionConfiguration> CreateUser(Expression<Func<CreateUserInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<AssignUserToLibraryResponse, ApiConnectionActionConfiguration> AssignUserToLibrary(Expression<Func<AssignUserToLibraryInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AssignUserToLibraryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/assignUserToLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AssignUserToLibraryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<CreateFolderResponseBody, ApiConnectionActionConfiguration> AddFolder(Expression<Func<AddFolderInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateFolderResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateFolderResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<CreateTabResponseBody, ApiConnectionActionConfiguration> AddTab(Expression<Func<AddTabInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateTabResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTabResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<GetMyMattersCategoriesResponse, ApiConnectionActionConfiguration> GetMyMattersCategories(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<GetMyMattersCategoriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getMyMattersCategories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["user_id"] = ExpressionConverter.Convert(__workflow_userId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                return new ApiConnectionAction<GetMyMattersCategoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<AddShortcutsToMyMattersAdminResponse, ApiConnectionActionConfiguration> AddShortcutsToMyMattersAdmin(Expression<Func<AddShortcutsToMyMattersAdminInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddShortcutsToMyMattersAdminResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addShortcutsToMyMattersAdmin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddShortcutsToMyMattersAdminResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateCustomField(Expression<Func<UpdateCustomFieldInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updateCustomField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<GetRowsFromCSVDocumentResponse, ApiConnectionActionConfiguration> GetRowsFromCSVDocument(Expression<Func<GetRowsFromCSVDocumentInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetRowsFromCSVDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getRowsFromCSVDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetRowsFromCSVDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<MoveFolderResponseBody, ApiConnectionActionConfiguration> MoveFolder(Expression<Func<MoveFolderInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MoveFolderResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/moveFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MoveFolderResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<UpdateFolderPropertiesResponseBody, ApiConnectionActionConfiguration> UpdateFolder(Expression<Func<UpdateFolderInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateFolderPropertiesResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updateFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateFolderPropertiesResponseBody>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum enabledStateInput
    {
        Enabled,
        Disabled,
        [EnumMember(Value = "Both Enabled and Disabled")]
        BothEnabledAndDisabled
    }

    public class CreateCustomOrPropertyLookupInput
    {
        [JsonProperty("libraryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LibraryId { get; set; }

        [JsonProperty("lookupFieldId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LookupFieldId { get; set; }

        [JsonProperty("aliasInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AliasInfo { get; set; }
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

    public class CreateUserInput
    {
        [JsonProperty("full_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FullName { get; set; }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("is_external", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsExternal { get; set; } = false;

        [JsonProperty("preferred_library", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PreferredLibrary { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("ignore_if_user_already_exists", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IgnoreIfUserAlreadyExists { get; set; } = true;

        [JsonProperty("password_create_method", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateUserInputPasswordCreateMethodType PasswordCreateMethod { get; set; } = CreateUserInputPasswordCreateMethodType.SendAnEmail;

        [JsonProperty("create_password", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken CreatePassword { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateUserInputPasswordCreateMethodType
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

    public class AssignUserToLibraryInput
    {
        [JsonProperty("libraryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LibraryId { get; set; }

        [JsonProperty("user_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Role { get; set; }

        [JsonProperty("is_preferred_library", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsPreferredLibrary { get; set; } = false;
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class AddFolderInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("parentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentId { get; set; }

        [JsonProperty("parentType", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddFolderInputParentTypeType ParentType { get; set; }

        [JsonProperty("default_security", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddFolderInputDefaultSecurityType DefaultSecurity { get; set; } = AddFolderInputDefaultSecurityType.Inherit;

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("subclass")]
        public string Subclass { get; set; }

        [JsonProperty("is_external_as_normal", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsExternalAsNormal { get; set; } = false;

        [JsonProperty("inherit_profile_from_workspace", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddFolderInputInheritProfileFromWorkspaceType InheritProfileFromWorkspace { get; set; } = AddFolderInputInheritProfileFromWorkspaceType.Yes;

        [JsonProperty("profileProperties")]
        public JToken ProfileProperties { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddFolderInputParentTypeType
    {
        Folder,
        Workspace,
        Tab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddFolderInputDefaultSecurityType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddFolderInputInheritProfileFromWorkspaceType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class AddTabInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("parentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentId { get; set; }

        [JsonProperty("default_security", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddTabInputDefaultSecurityType DefaultSecurity { get; set; } = AddTabInputDefaultSecurityType.Inherit;

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddTabInputDefaultSecurityType
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetMyMattersCategoriesResponseDataTypeItemCategoryTypeType
    {
        [EnumMember(Value = "my_matters")]
        MyMatters,
        [EnumMember(Value = "my_favorites")]
        MyFavorites
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class AddShortcutsToMyMattersAdminInput
    {
        [JsonProperty("user_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }

        [JsonProperty("workspace_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkspaceId { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }
    }

    public class UpdateCustomFieldInput
    {
        [JsonProperty("libraryId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LibraryId { get; set; }

        [JsonProperty("lookupFieldId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LookupFieldId { get; set; }

        [JsonProperty("aliasInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AliasInfo { get; set; }
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

    public class GetRowsFromCSVDocumentInput
    {
        [JsonProperty("documentId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DocumentId { get; set; }

        [JsonProperty("column_names", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ColumnNames { get; set; }

        [JsonProperty("latest", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Latest { get; set; } = false;
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

    public class MoveFolderInput
    {
        [JsonProperty("folder_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderId { get; set; }

        [JsonProperty("destination_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestinationId { get; set; }
    }

    public class UpdateFolderPropertiesResponseBody
    {
        [JsonProperty("data")]
        public NewFolderProfile Data { get; set; }
    }

    public class UpdateFolderInput
    {
        [JsonProperty("folderId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("default_security", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateFolderInputDefaultSecurityType? DefaultSecurity { get; set; } = UpdateFolderInputDefaultSecurityType.NoChange;

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("subclass")]
        public string Subclass { get; set; }

        [JsonProperty("is_external_as_normal", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsExternalAsNormal { get; set; } = false;

        [JsonProperty("profile")]
        public JToken Profile { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateFolderInputDefaultSecurityType
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