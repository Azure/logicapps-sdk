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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateCustomOrPropertyLookup(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodylookupFieldId, Expression<Func<object>> bodyaliasInfo)
        {
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodylookupFieldId = WorkflowExpression.Compile(bodylookupFieldId, nameof(bodylookupFieldId), required: true);
            var __workflow_bodyaliasInfo = WorkflowExpression.Compile(bodyaliasInfo, nameof(bodyaliasInfo), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createCustomOrPropertyLookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["lookupFieldId"] = ExpressionConverter.ConvertO(__workflow_bodylookupFieldId);
                bodypropCount++;
                body["aliasInfo"] = ExpressionConverter.ConvertO(__workflow_bodyaliasInfo);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<CreateUserResponse, ApiConnectionActionConfiguration> CreateUser(Expression<Func<string>> bodyfullName, Expression<Func<string>> bodyid, Expression<Func<string>> bodyemail, Expression<Func<bool>> bodyisExternal, Expression<Func<string>> bodypreferredLibrary, Expression<Func<string>> bodyrole, Expression<Func<bool>> bodyignoreIfUserAlreadyExists, Expression<Func<bodypasswordCreateMethodInput>> bodypasswordCreateMethod, Expression<Func<object>> bodycreatePassword)
        {
            var __workflow_bodyfullName = WorkflowExpression.Compile(bodyfullName, nameof(bodyfullName), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyisExternal = WorkflowExpression.Compile(bodyisExternal, nameof(bodyisExternal), required: true);
            var __workflow_bodypreferredLibrary = WorkflowExpression.Compile(bodypreferredLibrary, nameof(bodypreferredLibrary), required: true);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: true);
            var __workflow_bodyignoreIfUserAlreadyExists = WorkflowExpression.Compile(bodyignoreIfUserAlreadyExists, nameof(bodyignoreIfUserAlreadyExists), required: true);
            var __workflow_bodypasswordCreateMethod = WorkflowExpression.Compile(bodypasswordCreateMethod, nameof(bodypasswordCreateMethod), required: true);
            var __workflow_bodycreatePassword = WorkflowExpression.Compile(bodycreatePassword, nameof(bodycreatePassword), required: true);
            return new DeferredBodyAction<CreateUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/createUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["full_name"] = ExpressionConverter.ConvertO(__workflow_bodyfullName);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                bodypropCount++;
                body["is_external"] = ExpressionConverter.ConvertO(__workflow_bodyisExternal);
                bodypropCount++;
                body["preferred_library"] = ExpressionConverter.ConvertO(__workflow_bodypreferredLibrary);
                bodypropCount++;
                body["role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                bodypropCount++;
                body["ignore_if_user_already_exists"] = ExpressionConverter.ConvertO(__workflow_bodyignoreIfUserAlreadyExists);
                bodypropCount++;
                body["password_create_method"] = ExpressionConverter.ConvertO(__workflow_bodypasswordCreateMethod);
                bodypropCount++;
                body["create_password"] = ExpressionConverter.ConvertO(__workflow_bodycreatePassword);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<AssignUserToLibraryResponse, ApiConnectionActionConfiguration> AssignUserToLibrary(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodyuserId, Expression<Func<string>> bodyrole, Expression<Func<bool>> bodyisPreferredLibrary)
        {
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: true);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: true);
            var __workflow_bodyisPreferredLibrary = WorkflowExpression.Compile(bodyisPreferredLibrary, nameof(bodyisPreferredLibrary), required: true);
            return new DeferredBodyAction<AssignUserToLibraryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/assignUserToLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                bodypropCount++;
                body["role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                bodypropCount++;
                body["is_preferred_library"] = ExpressionConverter.ConvertO(__workflow_bodyisPreferredLibrary);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AssignUserToLibraryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<CreateFolderResponseBody, ApiConnectionActionConfiguration> AddFolder(Expression<Func<string>> bodyname, Expression<Func<string>> bodyparentId, Expression<Func<bodyparentTypeInput>> bodyparentType, Expression<Func<bodydefaultSecurityInput>> bodydefaultSecurity, Expression<Func<bodyinheritProfileFromWorkspaceInput>> bodyinheritProfileFromWorkspace, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodyClass = null, Expression<Func<string>> bodysubclass = null, Expression<Func<bool>> bodyisExternalAsNormal = null, Expression<Func<object>> bodyprofileProperties = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: true);
            var __workflow_bodyparentType = WorkflowExpression.Compile(bodyparentType, nameof(bodyparentType), required: true);
            var __workflow_bodydefaultSecurity = WorkflowExpression.Compile(bodydefaultSecurity, nameof(bodydefaultSecurity), required: true);
            var __workflow_bodyinheritProfileFromWorkspace = WorkflowExpression.Compile(bodyinheritProfileFromWorkspace, nameof(bodyinheritProfileFromWorkspace), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyowner = WorkflowExpression.Compile(bodyowner, nameof(bodyowner), required: false);
            var __workflow_bodyClass = WorkflowExpression.Compile(bodyClass, nameof(bodyClass), required: false);
            var __workflow_bodysubclass = WorkflowExpression.Compile(bodysubclass, nameof(bodysubclass), required: false);
            var __workflow_bodyisExternalAsNormal = WorkflowExpression.Compile(bodyisExternalAsNormal, nameof(bodyisExternalAsNormal), required: false);
            var __workflow_bodyprofileProperties = WorkflowExpression.Compile(bodyprofileProperties, nameof(bodyprofileProperties), required: false);
            return new DeferredBodyAction<CreateFolderResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                bodypropCount++;
                body["parentType"] = ExpressionConverter.ConvertO(__workflow_bodyparentType);
                bodypropCount++;
                body["default_security"] = ExpressionConverter.ConvertO(__workflow_bodydefaultSecurity);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyowner != null)
                {
                    body["owner"] = ExpressionConverter.ConvertO(__workflow_bodyowner);
                    bodypropCount++;
                }

                if (__workflow_bodyClass != null)
                {
                    body["class"] = ExpressionConverter.ConvertO(__workflow_bodyClass);
                    bodypropCount++;
                }

                if (__workflow_bodysubclass != null)
                {
                    body["subclass"] = ExpressionConverter.ConvertO(__workflow_bodysubclass);
                    bodypropCount++;
                }

                if (__workflow_bodyisExternalAsNormal != null)
                {
                    if (__workflow_bodyisExternalAsNormal != null)
                    {
                        body["is_external_as_normal"] = ExpressionConverter.ConvertO(__workflow_bodyisExternalAsNormal);
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
                body["inherit_profile_from_workspace"] = ExpressionConverter.ConvertO(__workflow_bodyinheritProfileFromWorkspace);
                if (__workflow_bodyprofileProperties != null)
                {
                    body["profileProperties"] = ExpressionConverter.ConvertO(__workflow_bodyprofileProperties);
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
        public IBodyWorkflowAction<CreateTabResponseBody, ApiConnectionActionConfiguration> AddTab(Expression<Func<string>> bodyname, Expression<Func<string>> bodyparentId, Expression<Func<bodydefaultSecurityInput>> bodydefaultSecurity, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyowner = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyparentId = WorkflowExpression.Compile(bodyparentId, nameof(bodyparentId), required: true);
            var __workflow_bodydefaultSecurity = WorkflowExpression.Compile(bodydefaultSecurity, nameof(bodydefaultSecurity), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyowner = WorkflowExpression.Compile(bodyowner, nameof(bodyowner), required: false);
            return new DeferredBodyAction<CreateTabResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["parentId"] = ExpressionConverter.ConvertO(__workflow_bodyparentId);
                bodypropCount++;
                body["default_security"] = ExpressionConverter.ConvertO(__workflow_bodydefaultSecurity);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyowner != null)
                {
                    body["owner"] = ExpressionConverter.ConvertO(__workflow_bodyowner);
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
        public IBodyWorkflowAction<AddShortcutsToMyMattersAdminResponse, ApiConnectionActionConfiguration> AddShortcutsToMyMattersAdmin(Expression<Func<string>> bodyuserId, Expression<Func<string>> bodyworkspaceId, Expression<Func<string>> bodycategoryId = null)
        {
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: true);
            var __workflow_bodyworkspaceId = WorkflowExpression.Compile(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: false);
            return new DeferredBodyAction<AddShortcutsToMyMattersAdminResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/addShortcutsToMyMattersAdmin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                bodypropCount++;
                body["workspace_id"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                if (__workflow_bodycategoryId != null)
                {
                    body["category_id"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> UpdateCustomField(Expression<Func<string>> bodylibraryId, Expression<Func<string>> bodylookupFieldId, Expression<Func<object>> bodyaliasInfo)
        {
            var __workflow_bodylibraryId = WorkflowExpression.Compile(bodylibraryId, nameof(bodylibraryId), required: true);
            var __workflow_bodylookupFieldId = WorkflowExpression.Compile(bodylookupFieldId, nameof(bodylookupFieldId), required: true);
            var __workflow_bodyaliasInfo = WorkflowExpression.Compile(bodyaliasInfo, nameof(bodyaliasInfo), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updateCustomField";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["libraryId"] = ExpressionConverter.ConvertO(__workflow_bodylibraryId);
                bodypropCount++;
                body["lookupFieldId"] = ExpressionConverter.ConvertO(__workflow_bodylookupFieldId);
                bodypropCount++;
                body["aliasInfo"] = ExpressionConverter.ConvertO(__workflow_bodyaliasInfo);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<GetRowsFromCSVDocumentResponse, ApiConnectionActionConfiguration> GetRowsFromCSVDocument(Expression<Func<string>> bodydocumentId, Expression<Func<string>> bodycolumnNames, Expression<Func<bool>> bodylatest = null)
        {
            var __workflow_bodydocumentId = WorkflowExpression.Compile(bodydocumentId, nameof(bodydocumentId), required: true);
            var __workflow_bodycolumnNames = WorkflowExpression.Compile(bodycolumnNames, nameof(bodycolumnNames), required: true);
            var __workflow_bodylatest = WorkflowExpression.Compile(bodylatest, nameof(bodylatest), required: false);
            return new DeferredBodyAction<GetRowsFromCSVDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/getRowsFromCSVDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["documentId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentId);
                bodypropCount++;
                body["column_names"] = ExpressionConverter.ConvertO(__workflow_bodycolumnNames);
                if (__workflow_bodylatest != null)
                {
                    if (__workflow_bodylatest != null)
                    {
                        body["latest"] = ExpressionConverter.ConvertO(__workflow_bodylatest);
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
        public IBodyWorkflowAction<MoveFolderResponseBody, ApiConnectionActionConfiguration> MoveFolder(Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodydestinationId)
        {
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            var __workflow_bodydestinationId = WorkflowExpression.Compile(bodydestinationId, nameof(bodydestinationId), required: true);
            return new DeferredBodyAction<MoveFolderResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/moveFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["folder_id"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                bodypropCount++;
                body["destination_id"] = ExpressionConverter.ConvertO(__workflow_bodydestinationId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MoveFolderResponseBody>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanageworkforadmins")]
        public IBodyWorkflowAction<UpdateFolderPropertiesResponseBody, ApiConnectionActionConfiguration> UpdateFolder(Expression<Func<string>> bodyfolderId, Expression<Func<string>> bodyname = null, Expression<Func<bodydefaultSecurityInput>> bodydefaultSecurity = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyowner = null, Expression<Func<string>> bodyClass = null, Expression<Func<string>> bodysubclass = null, Expression<Func<bool>> bodyisExternalAsNormal = null, Expression<Func<object>> bodyprofile = null)
        {
            var __workflow_bodyfolderId = WorkflowExpression.Compile(bodyfolderId, nameof(bodyfolderId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydefaultSecurity = WorkflowExpression.Compile(bodydefaultSecurity, nameof(bodydefaultSecurity), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyowner = WorkflowExpression.Compile(bodyowner, nameof(bodyowner), required: false);
            var __workflow_bodyClass = WorkflowExpression.Compile(bodyClass, nameof(bodyClass), required: false);
            var __workflow_bodysubclass = WorkflowExpression.Compile(bodysubclass, nameof(bodysubclass), required: false);
            var __workflow_bodyisExternalAsNormal = WorkflowExpression.Compile(bodyisExternalAsNormal, nameof(bodyisExternalAsNormal), required: false);
            var __workflow_bodyprofile = WorkflowExpression.Compile(bodyprofile, nameof(bodyprofile), required: false);
            return new DeferredBodyAction<UpdateFolderPropertiesResponseBody, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/updateFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-im-connector-id"] = Convert.ToString("imanage-work-for-admins");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["folderId"] = ExpressionConverter.ConvertO(__workflow_bodyfolderId);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultSecurity != null)
                {
                    if (__workflow_bodydefaultSecurity != null)
                    {
                        body["default_security"] = ExpressionConverter.ConvertO(__workflow_bodydefaultSecurity);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["default_security"] = "no change";
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyowner != null)
                {
                    body["owner"] = ExpressionConverter.ConvertO(__workflow_bodyowner);
                    bodypropCount++;
                }

                if (__workflow_bodyClass != null)
                {
                    body["class"] = ExpressionConverter.ConvertO(__workflow_bodyClass);
                    bodypropCount++;
                }

                if (__workflow_bodysubclass != null)
                {
                    body["subclass"] = ExpressionConverter.ConvertO(__workflow_bodysubclass);
                    bodypropCount++;
                }

                if (__workflow_bodyisExternalAsNormal != null)
                {
                    if (__workflow_bodyisExternalAsNormal != null)
                    {
                        body["is_external_as_normal"] = ExpressionConverter.ConvertO(__workflow_bodyisExternalAsNormal);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["is_external_as_normal"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyprofile != null)
                {
                    body["profile"] = ExpressionConverter.ConvertO(__workflow_bodyprofile);
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
