//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Spinpanel
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SpinpanelActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IBodyWorkflowAction<GetLocalesResponse> GetLocales()
        {
            var apiCallPath = "/directory/v1/locales";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["provider"] = Convert.ToString("spinpanel.platform");
            return new ApiConnectionAction<GetLocalesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildGetUsers))]
        public IBodyWorkflowAction<GetUsersResponse> GetUsers([WorkflowExpression] Func<string> filter)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUsersResponse> __BuildGetUsers(WorkflowExpression<string> filter)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: true);
            return new DeferredBodyAction<GetUsersResponse>(() =>
            {
                var apiCallPath = "/directory/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                callPayload.Queries["provider"] = Convert.ToString("spinpanel.users");
                return new ApiConnectionAction<GetUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildGetGraphUser))]
        public IBodyWorkflowAction<GetGraphUserResponse> GetGraphUser([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGraphUserResponse> __BuildGetGraphUser(WorkflowExpression<string> organizationId, WorkflowExpression<string> microsoftObjectId)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(microsoftObjectId, nameof(microsoftObjectId), required: true);
            return new DeferredBodyAction<GetGraphUserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetGraphUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteGraphUser))]
        public IWorkflowAction DeleteGraphUser([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteGraphUser(WorkflowExpression<string> organizationId, WorkflowExpression<string> microsoftObjectId)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(microsoftObjectId, nameof(microsoftObjectId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildPatchGraphUserPassword))]
        public IWorkflowAction PatchGraphUserPassword([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId, [WorkflowExpression] Func<bool> bodypasswordProfileforceChangePasswordNextSignIn = null, [WorkflowExpression] Func<string> bodypasswordProfilepassword = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPatchGraphUserPassword(WorkflowExpression<string> organizationId, WorkflowExpression<string> microsoftObjectId, WorkflowExpression<bool> bodypasswordProfileforceChangePasswordNextSignIn = null, WorkflowExpression<string> bodypasswordProfilepassword = null)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(microsoftObjectId, nameof(microsoftObjectId), required: true);
            WorkflowExpression.Validate(bodypasswordProfileforceChangePasswordNextSignIn, nameof(bodypasswordProfileforceChangePasswordNextSignIn), required: false);
            WorkflowExpression.Validate(bodypasswordProfilepassword, nameof(bodypasswordProfilepassword), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var passwordProfileObject = new JObject();
                var passwordProfileObjectpropCount = 0;
                if (bodypasswordProfileforceChangePasswordNextSignIn != null)
                {
                    passwordProfileObject["forceChangePasswordNextSignIn"] = ExpressionConverter.ConvertO(bodypasswordProfileforceChangePasswordNextSignIn);
                    passwordProfileObjectpropCount++;
                }

                if (bodypasswordProfilepassword != null)
                {
                    passwordProfileObject["password"] = ExpressionConverter.ConvertO(bodypasswordProfilepassword);
                    passwordProfileObjectpropCount++;
                }

                if (passwordProfileObjectpropCount > 0)
                {
                    body["passwordProfile"] = passwordProfileObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IBodyWorkflowAction<GetOrganizationsResponse> GetOrganizations()
        {
            var apiCallPath = "/directory/v1/organizations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["provider"] = Convert.ToString("spinpanel.users");
            return new ApiConnectionAction<GetOrganizationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildPostGraphUser))]
        public IBodyWorkflowAction<PostGraphUserResponse> PostGraphUser([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<bool> bodyaccountEnabled = null, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string> bodymailNickname = null, [WorkflowExpression] Func<string> bodyuserPrincipalName = null, [WorkflowExpression] Func<bool> bodypasswordProfileforceChangePasswordNextSignIn = null, [WorkflowExpression] Func<string> bodypasswordProfilepassword = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostGraphUserResponse> __BuildPostGraphUser(WorkflowExpression<string> organizationId, WorkflowExpression<bool> bodyaccountEnabled = null, WorkflowExpression<string> bodydisplayName = null, WorkflowExpression<string> bodymailNickname = null, WorkflowExpression<string> bodyuserPrincipalName = null, WorkflowExpression<bool> bodypasswordProfileforceChangePasswordNextSignIn = null, WorkflowExpression<string> bodypasswordProfilepassword = null)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(bodyaccountEnabled, nameof(bodyaccountEnabled), required: false);
            WorkflowExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: false);
            WorkflowExpression.Validate(bodymailNickname, nameof(bodymailNickname), required: false);
            WorkflowExpression.Validate(bodyuserPrincipalName, nameof(bodyuserPrincipalName), required: false);
            WorkflowExpression.Validate(bodypasswordProfileforceChangePasswordNextSignIn, nameof(bodypasswordProfileforceChangePasswordNextSignIn), required: false);
            WorkflowExpression.Validate(bodypasswordProfilepassword, nameof(bodypasswordProfilepassword), required: false);
            return new DeferredBodyAction<PostGraphUserResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccountEnabled != null)
                {
                    body["accountEnabled"] = ExpressionConverter.ConvertO(bodyaccountEnabled);
                    bodypropCount++;
                }

                if (bodydisplayName != null)
                {
                    body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                    bodypropCount++;
                }

                if (bodymailNickname != null)
                {
                    body["mailNickname"] = ExpressionConverter.ConvertO(bodymailNickname);
                    bodypropCount++;
                }

                if (bodyuserPrincipalName != null)
                {
                    body["userPrincipalName"] = ExpressionConverter.ConvertO(bodyuserPrincipalName);
                    bodypropCount++;
                }

                var passwordProfileObject = new JObject();
                var passwordProfileObjectpropCount = 0;
                if (bodypasswordProfileforceChangePasswordNextSignIn != null)
                {
                    passwordProfileObject["forceChangePasswordNextSignIn"] = ExpressionConverter.ConvertO(bodypasswordProfileforceChangePasswordNextSignIn);
                    passwordProfileObjectpropCount++;
                }

                if (bodypasswordProfilepassword != null)
                {
                    passwordProfileObject["password"] = ExpressionConverter.ConvertO(bodypasswordProfilepassword);
                    passwordProfileObjectpropCount++;
                }

                if (passwordProfileObjectpropCount > 0)
                {
                    body["passwordProfile"] = passwordProfileObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostGraphUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildGetUserLicenseDetails))]
        public IBodyWorkflowAction<GetUserLicenseDetailsResponse> GetUserLicenseDetails([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUserLicenseDetailsResponse> __BuildGetUserLicenseDetails(WorkflowExpression<string> organizationId, WorkflowExpression<string> microsoftObjectId)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(microsoftObjectId, nameof(microsoftObjectId), required: true);
            return new DeferredBodyAction<GetUserLicenseDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}/licenseDetails", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserLicenseDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildGetsubscribedSkus))]
        public IBodyWorkflowAction<GetsubscribedSkusResponse> GetsubscribedSkus([WorkflowExpression] Func<string> organizationId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetsubscribedSkusResponse> __BuildGetsubscribedSkus(WorkflowExpression<string> organizationId)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            return new DeferredBodyAction<GetsubscribedSkusResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/subscribedSkus", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetsubscribedSkusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildPostUserLicense))]
        public IBodyWorkflowAction<PostUserLicenseResponse> PostUserLicense([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId, [WorkflowExpression] Func<bodyaddLicensesInputItem[]> bodyaddLicenses = null, [WorkflowExpression] Func<JToken[]> bodyremoveLicenses = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostUserLicenseResponse> __BuildPostUserLicense(WorkflowExpression<string> organizationId, WorkflowExpression<string> microsoftObjectId, WorkflowExpression<bodyaddLicensesInputItem[]> bodyaddLicenses = null, WorkflowExpression<JToken[]> bodyremoveLicenses = null)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(microsoftObjectId, nameof(microsoftObjectId), required: true);
            WorkflowExpression.Validate(bodyaddLicenses, nameof(bodyaddLicenses), required: false);
            WorkflowExpression.Validate(bodyremoveLicenses, nameof(bodyremoveLicenses), required: false);
            return new DeferredBodyAction<PostUserLicenseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}/assignlicense", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaddLicenses != null)
                {
                    body["addLicenses"] = ExpressionConverter.ConvertO(bodyaddLicenses);
                    bodypropCount++;
                }

                if (bodyremoveLicenses != null)
                {
                    body["removeLicenses"] = ExpressionConverter.ConvertO(bodyremoveLicenses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostUserLicenseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IBodyWorkflowAction<GetGroupsResponse> GetGroups()
        {
            var apiCallPath = "/directory/v1/usergroups";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["provider"] = Convert.ToString("spinpanel.groups");
            return new ApiConnectionAction<GetGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildUserGroupMembers))]
        public IBodyWorkflowAction<UserGroupMembersResponse> UserGroupMembers([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> userGroupId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserGroupMembersResponse> __BuildUserGroupMembers(WorkflowExpression<string> organizationId, WorkflowExpression<string> userGroupId)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(userGroupId, nameof(userGroupId), required: true);
            return new DeferredBodyAction<UserGroupMembersResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/directory/v1/organizations/{0}/usergroups/{1}/members", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(userGroupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["provider"] = Convert.ToString("spinpanel.groups");
                return new ApiConnectionAction<UserGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildGetADSecurityGroups))]
        public IBodyWorkflowAction<GetADSecurityGroupsResponse> GetADSecurityGroups([WorkflowExpression] Func<string> organizationId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetADSecurityGroupsResponse> __BuildGetADSecurityGroups(WorkflowExpression<string> organizationId)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            return new DeferredBodyAction<GetADSecurityGroupsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/groups", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$select"] = Convert.ToString("createdDateTime,displayName,groupTypes,id,securityEnabled");
                return new ApiConnectionAction<GetADSecurityGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildPostGraphGroup))]
        public IBodyWorkflowAction<PostGraphGroupResponse> PostGraphGroup([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string[]> bodygroupTypes = null, [WorkflowExpression] Func<bool> bodymailEnabled = null, [WorkflowExpression] Func<string> bodymailNickname = null, [WorkflowExpression] Func<bool> bodysecurityEnabled = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostGraphGroupResponse> __BuildPostGraphGroup(WorkflowExpression<string> organizationId, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodydisplayName = null, WorkflowExpression<string[]> bodygroupTypes = null, WorkflowExpression<bool> bodymailEnabled = null, WorkflowExpression<string> bodymailNickname = null, WorkflowExpression<bool> bodysecurityEnabled = null)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: false);
            WorkflowExpression.Validate(bodygroupTypes, nameof(bodygroupTypes), required: false);
            WorkflowExpression.Validate(bodymailEnabled, nameof(bodymailEnabled), required: false);
            WorkflowExpression.Validate(bodymailNickname, nameof(bodymailNickname), required: false);
            WorkflowExpression.Validate(bodysecurityEnabled, nameof(bodysecurityEnabled), required: false);
            return new DeferredBodyAction<PostGraphGroupResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/groups", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodydisplayName != null)
                {
                    body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                    bodypropCount++;
                }

                if (bodygroupTypes != null)
                {
                    body["groupTypes"] = ExpressionConverter.ConvertO(bodygroupTypes);
                    bodypropCount++;
                }

                if (bodymailEnabled != null)
                {
                    body["mailEnabled"] = ExpressionConverter.ConvertO(bodymailEnabled);
                    bodypropCount++;
                }

                if (bodymailNickname != null)
                {
                    body["mailNickname"] = ExpressionConverter.ConvertO(bodymailNickname);
                    bodypropCount++;
                }

                if (bodysecurityEnabled != null)
                {
                    body["securityEnabled"] = ExpressionConverter.ConvertO(bodysecurityEnabled);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostGraphGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildGetGraphDomains))]
        public IBodyWorkflowAction<GetGraphDomainsResponse> GetGraphDomains([WorkflowExpression] Func<string> organizationId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGraphDomainsResponse> __BuildGetGraphDomains(WorkflowExpression<string> organizationId)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            return new DeferredBodyAction<GetGraphDomainsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/domains", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetGraphDomainsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteUserGroup))]
        public IWorkflowAction DeleteUserGroup([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> userGroupId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteUserGroup(WorkflowExpression<string> organizationId, WorkflowExpression<string> userGroupId)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(userGroupId, nameof(userGroupId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/directory/v1/organizations/{0}/usergroups/{1}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(userGroupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteUserGroupMember))]
        public IWorkflowAction DeleteUserGroupMember([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> userGroupId, [WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteUserGroupMember(WorkflowExpression<string> organizationId, WorkflowExpression<string> userGroupId, WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(userGroupId, nameof(userGroupId), required: true);
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/directory/v1/organizations/{0}/usergroups/{1}/members/{2}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(userGroupId, 1), ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildPostUserGroupMember))]
        public IWorkflowAction PostUserGroupMember([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> userGroupId, [WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPostUserGroupMember(WorkflowExpression<string> organizationId, WorkflowExpression<string> userGroupId, WorkflowExpression<string> userId)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(userGroupId, nameof(userGroupId), required: true);
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/directory/v1/organizations/{0}/usergroups/{1}/members/{2}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(userGroupId, 1), ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildAddGraphGroupMember))]
        public IWorkflowAction AddGraphGroupMember([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId, [WorkflowExpression] Func<string> bodyid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddGraphGroupMember(WorkflowExpression<string> organizationId, WorkflowExpression<string> microsoftObjectId, WorkflowExpression<string> bodyid)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(microsoftObjectId, nameof(microsoftObjectId), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/groups/{1}/members/$ref", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["@odata.id"] = ExpressionConverter.ConvertO(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveGraphGroupMember))]
        public IWorkflowAction RemoveGraphGroupMember([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> groupMicrosoftObjectId, [WorkflowExpression] Func<string> userMicrosoftObjectId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveGraphGroupMember(WorkflowExpression<string> organizationId, WorkflowExpression<string> groupMicrosoftObjectId, WorkflowExpression<string> userMicrosoftObjectId)
        {
            WorkflowExpression.Validate(organizationId, nameof(organizationId), required: true);
            WorkflowExpression.Validate(groupMicrosoftObjectId, nameof(groupMicrosoftObjectId), required: true);
            WorkflowExpression.Validate(userMicrosoftObjectId, nameof(userMicrosoftObjectId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/groups/{1}/members/{2}/$ref", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(groupMicrosoftObjectId, 1), ExpressionConverter.ConvertWithUrlEncoding(userMicrosoftObjectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildGetSubscriptions))]
        public IBodyWorkflowAction<GetSubscriptionsResponse> GetSubscriptions([WorkflowExpression] Func<string> partnerId, [WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> tenantId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSubscriptionsResponse> __BuildGetSubscriptions(WorkflowExpression<string> partnerId, WorkflowExpression<string> customerId, WorkflowExpression<string> tenantId)
        {
            WorkflowExpression.Validate(partnerId, nameof(partnerId), required: true);
            WorkflowExpression.Validate(customerId, nameof(customerId), required: true);
            WorkflowExpression.Validate(tenantId, nameof(tenantId), required: true);
            return new DeferredBodyAction<GetSubscriptionsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/partnercenter/v1/partners/{0}/organizations/{1}/v1.0/customers/{2}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(partnerId, 1), ExpressionConverter.ConvertWithUrlEncoding(customerId, 1), ExpressionConverter.ConvertWithUrlEncoding(tenantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSubscriptionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        [WorkflowExpressionFactory(nameof(__BuildPatchSubscriptionQuantity))]
        public IWorkflowAction PatchSubscriptionQuantity([WorkflowExpression] Func<string> partnerId, [WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<int> bodyquantity = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPatchSubscriptionQuantity(WorkflowExpression<string> partnerId, WorkflowExpression<string> customerId, WorkflowExpression<string> tenantId, WorkflowExpression<string> subscriptionId, WorkflowExpression<int> bodyquantity = null)
        {
            WorkflowExpression.Validate(partnerId, nameof(partnerId), required: true);
            WorkflowExpression.Validate(customerId, nameof(customerId), required: true);
            WorkflowExpression.Validate(tenantId, nameof(tenantId), required: true);
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            WorkflowExpression.Validate(bodyquantity, nameof(bodyquantity), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/partnercenter/v1/partners/{0}/organizations/{1}/v1.0/customers/{2}/subscriptions/{3}", ExpressionConverter.ConvertWithUrlEncoding(partnerId, 1), ExpressionConverter.ConvertWithUrlEncoding(customerId, 1), ExpressionConverter.ConvertWithUrlEncoding(tenantId, 1), ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyquantity != null)
                {
                    body["quantity"] = ExpressionConverter.ConvertO(bodyquantity);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class SpinpanelTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetLocalesResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("value")]
        public GetLocalesResponseValueTypeItem[] Value { get; set; }
    }

    public class GetLocalesResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("localeCode")]
        public string LocaleCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }
    }

    public class GetUsersResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetUsersResponseValueTypeItem[] Value { get; set; }
    }

    public class GetUsersResponseValueTypeItem
    {
        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("microsoftObjectIdentifier")]
        public string MicrosoftObjectIdentifier { get; set; }

        [JsonProperty("upn")]
        public string Upn { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("usageLocation")]
        public string UsageLocation { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public string ModifiedOn { get; set; }
    }

    public class GetGraphUserResponse
    {
        [JsonProperty("accountEnabled")]
        public bool AccountEnabled { get; set; }

        [JsonProperty("employeeId")]
        public string EmployeeId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("usageLocation")]
        public string UsageLocation { get; set; }

        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GetOrganizationsResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetOrganizationsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetOrganizationsResponseValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("microsoftTenantId")]
        public string MicrosoftTenantId { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public string ModifiedOn { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class PostGraphUserResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("businessPhones")]
        public string[] BusinessPhones { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class GetUserLicenseDetailsResponse
    {
        [JsonProperty("value")]
        public GetUserLicenseDetailsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetUserLicenseDetailsResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("skuId")]
        public string SkuId { get; set; }

        [JsonProperty("skuPartNumber")]
        public string SkuPartNumber { get; set; }

        [JsonProperty("servicePlans")]
        public GetUserLicenseDetailsResponseValueTypeItemServicePlansTypeItem[] ServicePlans { get; set; }
    }

    public class GetUserLicenseDetailsResponseValueTypeItemServicePlansTypeItem
    {
        [JsonProperty("servicePlanId")]
        public string ServicePlanId { get; set; }

        [JsonProperty("servicePlanName")]
        public string ServicePlanName { get; set; }

        [JsonProperty("provisioningStatus")]
        public string ProvisioningStatus { get; set; }

        [JsonProperty("appliesTo")]
        public string AppliesTo { get; set; }
    }

    public class GetsubscribedSkusResponse
    {
        [JsonProperty("value")]
        public GetsubscribedSkusResponseValueTypeItem[] Value { get; set; }
    }

    public class GetsubscribedSkusResponseValueTypeItem
    {
        [JsonProperty("capabilityStatus")]
        public string CapabilityStatus { get; set; }

        [JsonProperty("consumedUnits")]
        public int ConsumedUnits { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("skuId")]
        public string SkuId { get; set; }

        [JsonProperty("skuPartNumber")]
        public string SkuPartNumber { get; set; }

        [JsonProperty("appliesTo")]
        public string AppliesTo { get; set; }

        [JsonProperty("prepaidUnits")]
        public GetsubscribedSkusResponseValueTypeItemPrepaidUnitsType PrepaidUnits { get; set; }

        [JsonProperty("servicePlans")]
        public GetsubscribedSkusResponseValueTypeItemServicePlansTypeItem[] ServicePlans { get; set; }
    }

    public class GetsubscribedSkusResponseValueTypeItemPrepaidUnitsType
    {
        [JsonProperty("enabled")]
        public int Enabled { get; set; }

        [JsonProperty("suspended")]
        public int Suspended { get; set; }

        [JsonProperty("warning")]
        public int Warning { get; set; }
    }

    public class GetsubscribedSkusResponseValueTypeItemServicePlansTypeItem
    {
        [JsonProperty("servicePlanId")]
        public string ServicePlanId { get; set; }

        [JsonProperty("servicePlanName")]
        public string ServicePlanName { get; set; }

        [JsonProperty("provisioningStatus")]
        public string ProvisioningStatus { get; set; }

        [JsonProperty("appliesTo")]
        public string AppliesTo { get; set; }
    }

    public class PostUserLicenseResponse
    {
        [JsonProperty("value")]
        public PostUserLicenseResponseValueTypeItem[] Value { get; set; }
    }

    public class PostUserLicenseResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("skuId")]
        public string SkuId { get; set; }

        [JsonProperty("skuPartNumber")]
        public string SkuPartNumber { get; set; }

        [JsonProperty("servicePlans")]
        public PostUserLicenseResponseValueTypeItemServicePlansTypeItem[] ServicePlans { get; set; }
    }

    public class PostUserLicenseResponseValueTypeItemServicePlansTypeItem
    {
        [JsonProperty("servicePlanId")]
        public string ServicePlanId { get; set; }

        [JsonProperty("servicePlanName")]
        public string ServicePlanName { get; set; }

        [JsonProperty("provisioningStatus")]
        public string ProvisioningStatus { get; set; }

        [JsonProperty("appliesTo")]
        public string AppliesTo { get; set; }
    }

    public class bodyaddLicensesInputItem
    {
        [JsonProperty("disabledPlans")]
        public JToken[] DisabledPlans { get; set; }

        [JsonProperty("skuId")]
        public string SkuId { get; set; }
    }

    public class GetGroupsResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetGroupsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetGroupsResponseValueTypeItem
    {
        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public string ModifiedOn { get; set; }
    }

    public class UserGroupMembersResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public UserGroupMembersResponseValueTypeItem[] Value { get; set; }
    }

    public class UserGroupMembersResponseValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("upn")]
        public string Upn { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public string ModifiedOn { get; set; }
    }

    public class GetADSecurityGroupsResponse
    {
        [JsonProperty("value")]
        public GetADSecurityGroupsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetADSecurityGroupsResponseValueTypeItem
    {
        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("groupTypes")]
        public string[] GroupTypes { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("securityEnabled")]
        public bool SecurityEnabled { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }
    }

    public class PostGraphGroupResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deletedDateTime")]
        public string DeletedDateTime { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("creationOptions")]
        public string[] CreationOptions { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("groupTypes")]
        public string[] GroupTypes { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("mailEnabled")]
        public bool MailEnabled { get; set; }

        [JsonProperty("mailNickname")]
        public string MailNickname { get; set; }

        [JsonProperty("onPremisesLastSyncDateTime")]
        public string OnPremisesLastSyncDateTime { get; set; }

        [JsonProperty("onPremisesSecurityIdentifier")]
        public string OnPremisesSecurityIdentifier { get; set; }

        [JsonProperty("onPremisesSyncEnabled")]
        public string OnPremisesSyncEnabled { get; set; }

        [JsonProperty("preferredDataLocation")]
        public string PreferredDataLocation { get; set; }

        [JsonProperty("proxyAddresses")]
        public string[] ProxyAddresses { get; set; }

        [JsonProperty("renewedDateTime")]
        public string RenewedDateTime { get; set; }

        [JsonProperty("resourceBehaviorOptions")]
        public string[] ResourceBehaviorOptions { get; set; }

        [JsonProperty("resourceProvisioningOptions")]
        public string[] ResourceProvisioningOptions { get; set; }

        [JsonProperty("securityEnabled")]
        public bool SecurityEnabled { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("onPremisesProvisioningErrors")]
        public string[] OnPremisesProvisioningErrors { get; set; }
    }

    public class GetGraphDomainsResponse
    {
        [JsonProperty("value")]
        public GetGraphDomainsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetGraphDomainsResponseValueTypeItem
    {
        [JsonProperty("authenticationType")]
        public string AuthenticationType { get; set; }

        [JsonProperty("availabilityStatus")]
        public string AvailabilityStatus { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isAdminManaged")]
        public bool IsAdminManaged { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("isInitial")]
        public bool IsInitial { get; set; }

        [JsonProperty("isRoot")]
        public bool IsRoot { get; set; }

        [JsonProperty("isVerified")]
        public bool IsVerified { get; set; }

        [JsonProperty("supportedServices")]
        public string[] SupportedServices { get; set; }

        [JsonProperty("passwordValidityPeriodInDays")]
        public int PasswordValidityPeriodInDays { get; set; }

        [JsonProperty("passwordNotificationWindowInDays")]
        public int PasswordNotificationWindowInDays { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GetSubscriptionsResponse
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public GetSubscriptionsResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("attributes")]
        public GetSubscriptionsResponseAttributesType Attributes { get; set; }
    }

    public class GetSubscriptionsResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("entitlementId")]
        public string EntitlementId { get; set; }

        [JsonProperty("friendlyName")]
        public string FriendlyName { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("unitType")]
        public string UnitType { get; set; }

        [JsonProperty("creationDate")]
        public string CreationDate { get; set; }

        [JsonProperty("effectiveStartDate")]
        public string EffectiveStartDate { get; set; }

        [JsonProperty("commitmentEndDate")]
        public string CommitmentEndDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("autoRenewEnabled")]
        public bool AutoRenewEnabled { get; set; }

        [JsonProperty("billingType")]
        public string BillingType { get; set; }

        [JsonProperty("contractType")]
        public string ContractType { get; set; }

        [JsonProperty("links")]
        public GetSubscriptionsResponseItemsTypeItemLinksType Links { get; set; }

        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        [JsonProperty("attributes")]
        public GetSubscriptionsResponseItemsTypeItemAttributesType Attributes { get; set; }
    }

    public class GetSubscriptionsResponseItemsTypeItemLinksType
    {
        [JsonProperty("offer")]
        public GetSubscriptionsResponseItemsTypeItemLinksTypeOfferType Offer { get; set; }

        [JsonProperty("self")]
        public GetSubscriptionsResponseItemsTypeItemLinksTypeSelfType Self { get; set; }
    }

    public class GetSubscriptionsResponseItemsTypeItemLinksTypeOfferType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("headers")]
        public JToken[] Headers { get; set; }
    }

    public class GetSubscriptionsResponseItemsTypeItemLinksTypeSelfType
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("headers")]
        public JToken[] Headers { get; set; }
    }

    public class GetSubscriptionsResponseItemsTypeItemAttributesType
    {
        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("objectType")]
        public string ObjectType { get; set; }
    }

    public class GetSubscriptionsResponseAttributesType
    {
        [JsonProperty("objectType")]
        public string ObjectType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Spinpanel;

    public partial class WorkflowManagedActions
    {
        public SpinpanelActions Spinpanel(string connectionId) => new SpinpanelActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SpinpanelTriggers Spinpanel(string connectionId) => new SpinpanelTriggers(connectionId);
    }
}