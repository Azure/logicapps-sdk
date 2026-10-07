//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanageworkforadmins
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanageworkforadminsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildGetLibraryRoles))]
        public IBodyWorkflowAction<GetLibraryRolesResponse> GetLibraryRoles([WorkflowExpression] Func<string> libraryId, [WorkflowExpression] Func<bool> isExternal = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLibraryRolesResponse> __BuildGetLibraryRoles(WorkflowExpression<string> libraryId, WorkflowExpression<bool> isExternal = null)
        {
            WorkflowExpression.Validate(libraryId, nameof(libraryId), required: true);
            WorkflowExpression.Validate(isExternal, nameof(isExternal), required: false);
            return new DeferredBodyAction<GetLibraryRolesResponse>(() =>
            {
                var apiCallPath = "/getLibraryRoles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(libraryId);
                if (isExternal != null)
                    callPayload.Queries["is_external"] = ExpressionConverter.Convert(isExternal);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                return new ApiConnectionAction<GetLibraryRolesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildGetLookupAliases))]
        public IBodyWorkflowAction<GetLookupAliasesResponse> GetLookupAliases([WorkflowExpression] Func<string> libraryId, [WorkflowExpression] Func<string> lookupFieldId, [WorkflowExpression] Func<string> parentAlias = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLookupAliasesResponse> __BuildGetLookupAliases(WorkflowExpression<string> libraryId, WorkflowExpression<string> lookupFieldId, WorkflowExpression<string> parentAlias = null)
        {
            WorkflowExpression.Validate(libraryId, nameof(libraryId), required: true);
            WorkflowExpression.Validate(lookupFieldId, nameof(lookupFieldId), required: true);
            WorkflowExpression.Validate(parentAlias, nameof(parentAlias), required: false);
            return new DeferredBodyAction<GetLookupAliasesResponse>(() =>
            {
                var apiCallPath = "/getLookupAliases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(libraryId);
                callPayload.Queries["lookupFieldId"] = ExpressionConverter.Convert(lookupFieldId);
                if (parentAlias != null)
                    callPayload.Queries["parentAlias"] = ExpressionConverter.Convert(parentAlias);
                callPayload.Queries["getParentAliases"] = Convert.ToString(false);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                return new ApiConnectionAction<GetLookupAliasesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildSearchCustomPropertyAliases))]
        public IBodyWorkflowAction<SearchCustomPropertyResponseBody> SearchCustomPropertyAliases([WorkflowExpression] Func<string> libraryId, [WorkflowExpression] Func<string> lookupFieldId, [WorkflowExpression] Func<string> parentAlias = null, [WorkflowExpression] Func<string> alias = null, [WorkflowExpression] Func<string> description = null, [WorkflowExpression] Func<bool> hipaa = null, [WorkflowExpression] Func<enabledStateInput> enabledState = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchCustomPropertyResponseBody> __BuildSearchCustomPropertyAliases(WorkflowExpression<string> libraryId, WorkflowExpression<string> lookupFieldId, WorkflowExpression<string> parentAlias = null, WorkflowExpression<string> alias = null, WorkflowExpression<string> description = null, WorkflowExpression<bool> hipaa = null, WorkflowExpression<enabledStateInput> enabledState = null)
        {
            WorkflowExpression.Validate(libraryId, nameof(libraryId), required: true);
            WorkflowExpression.Validate(lookupFieldId, nameof(lookupFieldId), required: true);
            WorkflowExpression.Validate(parentAlias, nameof(parentAlias), required: false);
            WorkflowExpression.Validate(alias, nameof(alias), required: false);
            WorkflowExpression.Validate(description, nameof(description), required: false);
            WorkflowExpression.Validate(hipaa, nameof(hipaa), required: false);
            WorkflowExpression.Validate(enabledState, nameof(enabledState), required: false);
            return new DeferredBodyAction<SearchCustomPropertyResponseBody>(() =>
            {
                var apiCallPath = "/searchCustomPropertyAliases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["libraryId"] = ExpressionConverter.Convert(libraryId);
                callPayload.Queries["lookupFieldId"] = ExpressionConverter.Convert(lookupFieldId);
                if (parentAlias != null)
                    callPayload.Queries["parentAlias"] = ExpressionConverter.Convert(parentAlias);
                if (alias != null)
                    callPayload.Queries["alias"] = ExpressionConverter.Convert(alias);
                if (description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(description);
                callPayload.Queries["hipaa"] = Convert.ToString(false);
                if (hipaa != null)
                    callPayload.Queries["hipaa"] = ExpressionConverter.Convert(hipaa);
                callPayload.Queries["enabled_state"] = Convert.ToString("Both Enabled and Disabled");
                if (enabledState != null)
                    callPayload.Queries["enabled_state"] = ExpressionConverter.Convert(enabledState);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                return new ApiConnectionAction<SearchCustomPropertyResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildCreateCustomOrPropertyLookup))]
        public IBodyWorkflowAction<JToken> CreateCustomOrPropertyLookup([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodylookupFieldId, [WorkflowExpression] Func<object> bodyaliasInfo)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateCustomOrPropertyLookup(WorkflowExpression<string> bodylibraryId, WorkflowExpression<string> bodylookupFieldId, WorkflowExpression<object> bodyaliasInfo)
        {
            WorkflowExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            WorkflowExpression.Validate(bodylookupFieldId, nameof(bodylookupFieldId), required: true);
            WorkflowExpression.Validate(bodyaliasInfo, nameof(bodyaliasInfo), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/createCustomOrPropertyLookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(bodylibraryId);
                bodypropCount++;
                body["lookupFieldId"] = ExpressionConverter.ConvertO(bodylookupFieldId);
                bodypropCount++;
                body["aliasInfo"] = ExpressionConverter.ConvertO(bodyaliasInfo);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildCreateUser))]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser([WorkflowExpression] Func<string> bodyfullName, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<bool> bodyisExternal, [WorkflowExpression] Func<string> bodypreferredLibrary, [WorkflowExpression] Func<string> bodyrole, [WorkflowExpression] Func<bool> bodyignoreIfUserAlreadyExists, [WorkflowExpression] Func<bodypasswordCreateMethodInput> bodypasswordCreateMethod, [WorkflowExpression] Func<object> bodycreatePassword)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateUserResponse> __BuildCreateUser(WorkflowExpression<string> bodyfullName, WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyemail, WorkflowExpression<bool> bodyisExternal, WorkflowExpression<string> bodypreferredLibrary, WorkflowExpression<string> bodyrole, WorkflowExpression<bool> bodyignoreIfUserAlreadyExists, WorkflowExpression<bodypasswordCreateMethodInput> bodypasswordCreateMethod, WorkflowExpression<object> bodycreatePassword)
        {
            WorkflowExpression.Validate(bodyfullName, nameof(bodyfullName), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodyisExternal, nameof(bodyisExternal), required: true);
            WorkflowExpression.Validate(bodypreferredLibrary, nameof(bodypreferredLibrary), required: true);
            WorkflowExpression.Validate(bodyrole, nameof(bodyrole), required: true);
            WorkflowExpression.Validate(bodyignoreIfUserAlreadyExists, nameof(bodyignoreIfUserAlreadyExists), required: true);
            WorkflowExpression.Validate(bodypasswordCreateMethod, nameof(bodypasswordCreateMethod), required: true);
            WorkflowExpression.Validate(bodycreatePassword, nameof(bodycreatePassword), required: true);
            return new DeferredBodyAction<CreateUserResponse>(() =>
            {
                var apiCallPath = "/createUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["full_name"] = ExpressionConverter.ConvertO(bodyfullName);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(bodyid);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
                body["is_external"] = ExpressionConverter.ConvertO(bodyisExternal);
                bodypropCount++;
                body["preferred_library"] = ExpressionConverter.ConvertO(bodypreferredLibrary);
                bodypropCount++;
                body["role"] = ExpressionConverter.ConvertO(bodyrole);
                bodypropCount++;
                body["ignore_if_user_already_exists"] = ExpressionConverter.ConvertO(bodyignoreIfUserAlreadyExists);
                bodypropCount++;
                body["password_create_method"] = ExpressionConverter.ConvertO(bodypasswordCreateMethod);
                bodypropCount++;
                body["create_password"] = ExpressionConverter.ConvertO(bodycreatePassword);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildAssignUserToLibrary))]
        public IBodyWorkflowAction<AssignUserToLibraryResponse> AssignUserToLibrary([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodyuserId, [WorkflowExpression] Func<string> bodyrole, [WorkflowExpression] Func<bool> bodyisPreferredLibrary)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AssignUserToLibraryResponse> __BuildAssignUserToLibrary(WorkflowExpression<string> bodylibraryId, WorkflowExpression<string> bodyuserId, WorkflowExpression<string> bodyrole, WorkflowExpression<bool> bodyisPreferredLibrary)
        {
            WorkflowExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            WorkflowExpression.Validate(bodyrole, nameof(bodyrole), required: true);
            WorkflowExpression.Validate(bodyisPreferredLibrary, nameof(bodyisPreferredLibrary), required: true);
            return new DeferredBodyAction<AssignUserToLibraryResponse>(() =>
            {
                var apiCallPath = "/assignUserToLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(bodylibraryId);
                bodypropCount++;
                body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
                body["role"] = ExpressionConverter.ConvertO(bodyrole);
                bodypropCount++;
                body["is_preferred_library"] = ExpressionConverter.ConvertO(bodyisPreferredLibrary);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AssignUserToLibraryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildAddFolder))]
        public IBodyWorkflowAction<CreateFolderResponseBody> AddFolder([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyparentId, [WorkflowExpression] Func<bodyparentTypeInput> bodyparentType, [WorkflowExpression] Func<bodydefaultSecurityInput> bodydefaultSecurity, [WorkflowExpression] Func<bodyinheritProfileFromWorkspaceInput> bodyinheritProfileFromWorkspace, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<string> bodyClass = null, [WorkflowExpression] Func<string> bodysubclass = null, [WorkflowExpression] Func<bool> bodyisExternalAsNormal = null, [WorkflowExpression] Func<object> bodyprofileProperties = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateFolderResponseBody> __BuildAddFolder(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyparentId, WorkflowExpression<bodyparentTypeInput> bodyparentType, WorkflowExpression<bodydefaultSecurityInput> bodydefaultSecurity, WorkflowExpression<bodyinheritProfileFromWorkspaceInput> bodyinheritProfileFromWorkspace, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyowner = null, WorkflowExpression<string> bodyClass = null, WorkflowExpression<string> bodysubclass = null, WorkflowExpression<bool> bodyisExternalAsNormal = null, WorkflowExpression<object> bodyprofileProperties = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: true);
            WorkflowExpression.Validate(bodyparentType, nameof(bodyparentType), required: true);
            WorkflowExpression.Validate(bodydefaultSecurity, nameof(bodydefaultSecurity), required: true);
            WorkflowExpression.Validate(bodyinheritProfileFromWorkspace, nameof(bodyinheritProfileFromWorkspace), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyowner, nameof(bodyowner), required: false);
            WorkflowExpression.Validate(bodyClass, nameof(bodyClass), required: false);
            WorkflowExpression.Validate(bodysubclass, nameof(bodysubclass), required: false);
            WorkflowExpression.Validate(bodyisExternalAsNormal, nameof(bodyisExternalAsNormal), required: false);
            WorkflowExpression.Validate(bodyprofileProperties, nameof(bodyprofileProperties), required: false);
            return new DeferredBodyAction<CreateFolderResponseBody>(() =>
            {
                var apiCallPath = "/addFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
                bodypropCount++;
                body["parentType"] = ExpressionConverter.ConvertO(bodyparentType);
                bodypropCount++;
                body["default_security"] = ExpressionConverter.ConvertO(bodydefaultSecurity);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyowner != null)
                {
                    body["owner"] = ExpressionConverter.ConvertO(bodyowner);
                    bodypropCount++;
                }

                if (bodyClass != null)
                {
                    body["class"] = ExpressionConverter.ConvertO(bodyClass);
                    bodypropCount++;
                }

                if (bodysubclass != null)
                {
                    body["subclass"] = ExpressionConverter.ConvertO(bodysubclass);
                    bodypropCount++;
                }

                if (bodyisExternalAsNormal != null)
                {
                    if (bodyisExternalAsNormal != null)
                    {
                        body["is_external_as_normal"] = ExpressionConverter.ConvertO(bodyisExternalAsNormal);
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
                body["inherit_profile_from_workspace"] = ExpressionConverter.ConvertO(bodyinheritProfileFromWorkspace);
                if (bodyprofileProperties != null)
                {
                    body["profileProperties"] = ExpressionConverter.ConvertO(bodyprofileProperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateFolderResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildAddTab))]
        public IBodyWorkflowAction<CreateTabResponseBody> AddTab([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyparentId, [WorkflowExpression] Func<bodydefaultSecurityInput> bodydefaultSecurity, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyowner = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTabResponseBody> __BuildAddTab(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyparentId, WorkflowExpression<bodydefaultSecurityInput> bodydefaultSecurity, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyowner = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyparentId, nameof(bodyparentId), required: true);
            WorkflowExpression.Validate(bodydefaultSecurity, nameof(bodydefaultSecurity), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyowner, nameof(bodyowner), required: false);
            return new DeferredBodyAction<CreateTabResponseBody>(() =>
            {
                var apiCallPath = "/addTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["parentId"] = ExpressionConverter.ConvertO(bodyparentId);
                bodypropCount++;
                body["default_security"] = ExpressionConverter.ConvertO(bodydefaultSecurity);
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyowner != null)
                {
                    body["owner"] = ExpressionConverter.ConvertO(bodyowner);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTabResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildGetMyMattersCategories))]
        public IBodyWorkflowAction<GetMyMattersCategoriesResponse> GetMyMattersCategories([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMyMattersCategoriesResponse> __BuildGetMyMattersCategories(WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<GetMyMattersCategoriesResponse>(() =>
            {
                var apiCallPath = "/getMyMattersCategories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["user_id"] = ExpressionConverter.Convert(userId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                return new ApiConnectionAction<GetMyMattersCategoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildAddShortcutsToMyMattersAdmin))]
        public IBodyWorkflowAction<AddShortcutsToMyMattersAdminResponse> AddShortcutsToMyMattersAdmin([WorkflowExpression] Func<string> bodyuserId, [WorkflowExpression] Func<string> bodyworkspaceId, [WorkflowExpression] Func<string> bodycategoryId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddShortcutsToMyMattersAdminResponse> __BuildAddShortcutsToMyMattersAdmin(WorkflowExpression<string> bodyuserId, WorkflowExpression<string> bodyworkspaceId, WorkflowExpression<string> bodycategoryId = null)
        {
            WorkflowExpression.Validate(bodyuserId, nameof(bodyuserId), required: true);
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodycategoryId, nameof(bodycategoryId), required: false);
            return new DeferredBodyAction<AddShortcutsToMyMattersAdminResponse>(() =>
            {
                var apiCallPath = "/addShortcutsToMyMattersAdmin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["user_id"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
                body["workspace_id"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                if (bodycategoryId != null)
                {
                    body["category_id"] = ExpressionConverter.ConvertO(bodycategoryId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddShortcutsToMyMattersAdminResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateCustomField))]
        public IBodyWorkflowAction<JToken> UpdateCustomField([WorkflowExpression] Func<string> bodylibraryId, [WorkflowExpression] Func<string> bodylookupFieldId, [WorkflowExpression] Func<object> bodyaliasInfo)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUpdateCustomField(WorkflowExpression<string> bodylibraryId, WorkflowExpression<string> bodylookupFieldId, WorkflowExpression<object> bodyaliasInfo)
        {
            WorkflowExpression.Validate(bodylibraryId, nameof(bodylibraryId), required: true);
            WorkflowExpression.Validate(bodylookupFieldId, nameof(bodylookupFieldId), required: true);
            WorkflowExpression.Validate(bodyaliasInfo, nameof(bodyaliasInfo), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/updateCustomField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(bodylibraryId);
                bodypropCount++;
                body["lookupFieldId"] = ExpressionConverter.ConvertO(bodylookupFieldId);
                bodypropCount++;
                body["aliasInfo"] = ExpressionConverter.ConvertO(bodyaliasInfo);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildGetRowsFromCSVDocument))]
        public IBodyWorkflowAction<GetRowsFromCSVDocumentResponse> GetRowsFromCSVDocument([WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodycolumnNames, [WorkflowExpression] Func<bool> bodylatest = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRowsFromCSVDocumentResponse> __BuildGetRowsFromCSVDocument(WorkflowExpression<string> bodydocumentId, WorkflowExpression<string> bodycolumnNames, WorkflowExpression<bool> bodylatest = null)
        {
            WorkflowExpression.Validate(bodydocumentId, nameof(bodydocumentId), required: true);
            WorkflowExpression.Validate(bodycolumnNames, nameof(bodycolumnNames), required: true);
            WorkflowExpression.Validate(bodylatest, nameof(bodylatest), required: false);
            return new DeferredBodyAction<GetRowsFromCSVDocumentResponse>(() =>
            {
                var apiCallPath = "/getRowsFromCSVDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(bodydocumentId);
                bodypropCount++;
                body["column_names"] = ExpressionConverter.ConvertO(bodycolumnNames);
                if (bodylatest != null)
                {
                    if (bodylatest != null)
                    {
                        body["latest"] = ExpressionConverter.ConvertO(bodylatest);
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

                return new ApiConnectionAction<GetRowsFromCSVDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildMoveFolder))]
        public IBodyWorkflowAction<MoveFolderResponseBody> MoveFolder([WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodydestinationId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MoveFolderResponseBody> __BuildMoveFolder(WorkflowExpression<string> bodyfolderId, WorkflowExpression<string> bodydestinationId)
        {
            WorkflowExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            WorkflowExpression.Validate(bodydestinationId, nameof(bodydestinationId), required: true);
            return new DeferredBodyAction<MoveFolderResponseBody>(() =>
            {
                var apiCallPath = "/moveFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["folder_id"] = ExpressionConverter.ConvertO(bodyfolderId);
                bodypropCount++;
                body["destination_id"] = ExpressionConverter.ConvertO(bodydestinationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MoveFolderResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateFolder))]
        public IBodyWorkflowAction<UpdateFolderPropertiesResponseBody> UpdateFolder([WorkflowExpression] Func<string> bodyfolderId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bodydefaultSecurityInput> bodydefaultSecurity = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyowner = null, [WorkflowExpression] Func<string> bodyClass = null, [WorkflowExpression] Func<string> bodysubclass = null, [WorkflowExpression] Func<bool> bodyisExternalAsNormal = null, [WorkflowExpression] Func<object> bodyprofile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateFolderPropertiesResponseBody> __BuildUpdateFolder(WorkflowExpression<string> bodyfolderId, WorkflowExpression<string> bodyname = null, WorkflowExpression<bodydefaultSecurityInput> bodydefaultSecurity = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyowner = null, WorkflowExpression<string> bodyClass = null, WorkflowExpression<string> bodysubclass = null, WorkflowExpression<bool> bodyisExternalAsNormal = null, WorkflowExpression<object> bodyprofile = null)
        {
            WorkflowExpression.Validate(bodyfolderId, nameof(bodyfolderId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodydefaultSecurity, nameof(bodydefaultSecurity), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyowner, nameof(bodyowner), required: false);
            WorkflowExpression.Validate(bodyClass, nameof(bodyClass), required: false);
            WorkflowExpression.Validate(bodysubclass, nameof(bodysubclass), required: false);
            WorkflowExpression.Validate(bodyisExternalAsNormal, nameof(bodyisExternalAsNormal), required: false);
            WorkflowExpression.Validate(bodyprofile, nameof(bodyprofile), required: false);
            return new DeferredBodyAction<UpdateFolderPropertiesResponseBody>(() =>
            {
                var apiCallPath = "/updateFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(bodyfolderId);
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodydefaultSecurity != null)
                {
                    if (bodydefaultSecurity != null)
                    {
                        body["default_security"] = ExpressionConverter.ConvertO(bodydefaultSecurity);
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
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyowner != null)
                {
                    body["owner"] = ExpressionConverter.ConvertO(bodyowner);
                    bodypropCount++;
                }

                if (bodyClass != null)
                {
                    body["class"] = ExpressionConverter.ConvertO(bodyClass);
                    bodypropCount++;
                }

                if (bodysubclass != null)
                {
                    body["subclass"] = ExpressionConverter.ConvertO(bodysubclass);
                    bodypropCount++;
                }

                if (bodyisExternalAsNormal != null)
                {
                    if (bodyisExternalAsNormal != null)
                    {
                        body["is_external_as_normal"] = ExpressionConverter.ConvertO(bodyisExternalAsNormal);
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
                    body["profile"] = ExpressionConverter.ConvertO(bodyprofile);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyparentTypeInput
    {
        Folder,
        Workspace,
        Tab
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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