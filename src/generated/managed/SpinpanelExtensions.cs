//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Spinpanel
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SpinpanelActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IBodyWorkflowAction<GetLocalesResponse, ApiConnectionActionConfiguration> GetLocales()
        {
            return new DeferredBodyAction<GetLocalesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/directory/v1/locales";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["provider"] = Convert.ToString("spinpanel.platform");
                return new ApiConnectionAction<GetLocalesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IBodyWorkflowAction<GetUsersResponse, ApiConnectionActionConfiguration> GetUsers(Expression<Func<string>> filter)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: true);
            return new DeferredBodyAction<GetUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/directory/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Queries["provider"] = Convert.ToString("spinpanel.users");
                return new ApiConnectionAction<GetUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IBodyWorkflowAction<GetGraphUserResponse, ApiConnectionActionConfiguration> GetGraphUser(Expression<Func<string>> organizationId, Expression<Func<string>> microsoftObjectId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_microsoftObjectId = WorkflowExpression.Compile(microsoftObjectId, nameof(microsoftObjectId), required: true);
            return new DeferredBodyAction<GetGraphUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}", __workflow_organizationId.WithUrlEncoding(1), __workflow_microsoftObjectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetGraphUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteGraphUser(Expression<Func<string>> organizationId, Expression<Func<string>> microsoftObjectId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_microsoftObjectId = WorkflowExpression.Compile(microsoftObjectId, nameof(microsoftObjectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}", __workflow_organizationId.WithUrlEncoding(1), __workflow_microsoftObjectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PatchGraphUserPassword(Expression<Func<string>> organizationId, Expression<Func<string>> microsoftObjectId, Expression<Func<bool>> bodypasswordProfileforceChangePasswordNextSignIn = null, Expression<Func<string>> bodypasswordProfilepassword = null)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_microsoftObjectId = WorkflowExpression.Compile(microsoftObjectId, nameof(microsoftObjectId), required: true);
            var __workflow_bodypasswordProfileforceChangePasswordNextSignIn = WorkflowExpression.Compile(bodypasswordProfileforceChangePasswordNextSignIn, nameof(bodypasswordProfileforceChangePasswordNextSignIn), required: false);
            var __workflow_bodypasswordProfilepassword = WorkflowExpression.Compile(bodypasswordProfilepassword, nameof(bodypasswordProfilepassword), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}", __workflow_organizationId.WithUrlEncoding(1), __workflow_microsoftObjectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var passwordProfileObject = new JObject();
                var passwordProfileObjectpropCount = 0;
                if (__workflow_bodypasswordProfileforceChangePasswordNextSignIn != null)
                {
                    passwordProfileObject["forceChangePasswordNextSignIn"] = ExpressionConverter.ConvertO(__workflow_bodypasswordProfileforceChangePasswordNextSignIn);
                    passwordProfileObjectpropCount++;
                }

                if (__workflow_bodypasswordProfilepassword != null)
                {
                    passwordProfileObject["password"] = ExpressionConverter.ConvertO(__workflow_bodypasswordProfilepassword);
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
        public IBodyWorkflowAction<GetOrganizationsResponse, ApiConnectionActionConfiguration> GetOrganizations()
        {
            return new DeferredBodyAction<GetOrganizationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/directory/v1/organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["provider"] = Convert.ToString("spinpanel.users");
                return new ApiConnectionAction<GetOrganizationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IBodyWorkflowAction<PostGraphUserResponse, ApiConnectionActionConfiguration> PostGraphUser(Expression<Func<string>> organizationId, Expression<Func<bool>> bodyaccountEnabled = null, Expression<Func<string>> bodydisplayName = null, Expression<Func<string>> bodymailNickname = null, Expression<Func<string>> bodyuserPrincipalName = null, Expression<Func<bool>> bodypasswordProfileforceChangePasswordNextSignIn = null, Expression<Func<string>> bodypasswordProfilepassword = null)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_bodyaccountEnabled = WorkflowExpression.Compile(bodyaccountEnabled, nameof(bodyaccountEnabled), required: false);
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: false);
            var __workflow_bodymailNickname = WorkflowExpression.Compile(bodymailNickname, nameof(bodymailNickname), required: false);
            var __workflow_bodyuserPrincipalName = WorkflowExpression.Compile(bodyuserPrincipalName, nameof(bodyuserPrincipalName), required: false);
            var __workflow_bodypasswordProfileforceChangePasswordNextSignIn = WorkflowExpression.Compile(bodypasswordProfileforceChangePasswordNextSignIn, nameof(bodypasswordProfileforceChangePasswordNextSignIn), required: false);
            var __workflow_bodypasswordProfilepassword = WorkflowExpression.Compile(bodypasswordProfilepassword, nameof(bodypasswordProfilepassword), required: false);
            return new DeferredBodyAction<PostGraphUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graph/v1/organizations/{0}/v1.0/users", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaccountEnabled != null)
                {
                    body["accountEnabled"] = ExpressionConverter.ConvertO(__workflow_bodyaccountEnabled);
                    bodypropCount++;
                }

                if (__workflow_bodydisplayName != null)
                {
                    body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                    bodypropCount++;
                }

                if (__workflow_bodymailNickname != null)
                {
                    body["mailNickname"] = ExpressionConverter.ConvertO(__workflow_bodymailNickname);
                    bodypropCount++;
                }

                if (__workflow_bodyuserPrincipalName != null)
                {
                    body["userPrincipalName"] = ExpressionConverter.ConvertO(__workflow_bodyuserPrincipalName);
                    bodypropCount++;
                }

                var passwordProfileObject = new JObject();
                var passwordProfileObjectpropCount = 0;
                if (__workflow_bodypasswordProfileforceChangePasswordNextSignIn != null)
                {
                    passwordProfileObject["forceChangePasswordNextSignIn"] = ExpressionConverter.ConvertO(__workflow_bodypasswordProfileforceChangePasswordNextSignIn);
                    passwordProfileObjectpropCount++;
                }

                if (__workflow_bodypasswordProfilepassword != null)
                {
                    passwordProfileObject["password"] = ExpressionConverter.ConvertO(__workflow_bodypasswordProfilepassword);
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
        public IBodyWorkflowAction<GetUserLicenseDetailsResponse, ApiConnectionActionConfiguration> GetUserLicenseDetails(Expression<Func<string>> organizationId, Expression<Func<string>> microsoftObjectId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_microsoftObjectId = WorkflowExpression.Compile(microsoftObjectId, nameof(microsoftObjectId), required: true);
            return new DeferredBodyAction<GetUserLicenseDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}/licenseDetails", __workflow_organizationId.WithUrlEncoding(1), __workflow_microsoftObjectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserLicenseDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IBodyWorkflowAction<GetsubscribedSkusResponse, ApiConnectionActionConfiguration> GetsubscribedSkus(Expression<Func<string>> organizationId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            return new DeferredBodyAction<GetsubscribedSkusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graph/v1/organizations/{0}/v1.0/subscribedSkus", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetsubscribedSkusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IBodyWorkflowAction<PostUserLicenseResponse, ApiConnectionActionConfiguration> PostUserLicense(Expression<Func<string>> organizationId, Expression<Func<string>> microsoftObjectId, Expression<Func<bodyaddLicensesInputItem[]>> bodyaddLicenses = null, Expression<Func<JToken[]>> bodyremoveLicenses = null)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_microsoftObjectId = WorkflowExpression.Compile(microsoftObjectId, nameof(microsoftObjectId), required: true);
            var __workflow_bodyaddLicenses = WorkflowExpression.Compile(bodyaddLicenses, nameof(bodyaddLicenses), required: false);
            var __workflow_bodyremoveLicenses = WorkflowExpression.Compile(bodyremoveLicenses, nameof(bodyremoveLicenses), required: false);
            return new DeferredBodyAction<PostUserLicenseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}/assignlicense", __workflow_organizationId.WithUrlEncoding(1), __workflow_microsoftObjectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaddLicenses != null)
                {
                    body["addLicenses"] = ExpressionConverter.ConvertO(__workflow_bodyaddLicenses);
                    bodypropCount++;
                }

                if (__workflow_bodyremoveLicenses != null)
                {
                    body["removeLicenses"] = ExpressionConverter.ConvertO(__workflow_bodyremoveLicenses);
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
        public IBodyWorkflowAction<GetGroupsResponse, ApiConnectionActionConfiguration> GetGroups()
        {
            return new DeferredBodyAction<GetGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/directory/v1/usergroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["provider"] = Convert.ToString("spinpanel.groups");
                return new ApiConnectionAction<GetGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IBodyWorkflowAction<UserGroupMembersResponse, ApiConnectionActionConfiguration> UserGroupMembers(Expression<Func<string>> organizationId, Expression<Func<string>> userGroupId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_userGroupId = WorkflowExpression.Compile(userGroupId, nameof(userGroupId), required: true);
            return new DeferredBodyAction<UserGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/directory/v1/organizations/{0}/usergroups/{1}/members", __workflow_organizationId.WithUrlEncoding(1), __workflow_userGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["provider"] = Convert.ToString("spinpanel.groups");
                return new ApiConnectionAction<UserGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IBodyWorkflowAction<GetADSecurityGroupsResponse, ApiConnectionActionConfiguration> GetADSecurityGroups(Expression<Func<string>> organizationId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            return new DeferredBodyAction<GetADSecurityGroupsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graph/v1/organizations/{0}/v1.0/groups", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$select"] = Convert.ToString("createdDateTime,displayName,groupTypes,id,securityEnabled");
                return new ApiConnectionAction<GetADSecurityGroupsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IBodyWorkflowAction<PostGraphGroupResponse, ApiConnectionActionConfiguration> PostGraphGroup(Expression<Func<string>> organizationId, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodydisplayName = null, Expression<Func<string[]>> bodygroupTypes = null, Expression<Func<bool>> bodymailEnabled = null, Expression<Func<string>> bodymailNickname = null, Expression<Func<bool>> bodysecurityEnabled = null)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: false);
            var __workflow_bodygroupTypes = WorkflowExpression.Compile(bodygroupTypes, nameof(bodygroupTypes), required: false);
            var __workflow_bodymailEnabled = WorkflowExpression.Compile(bodymailEnabled, nameof(bodymailEnabled), required: false);
            var __workflow_bodymailNickname = WorkflowExpression.Compile(bodymailNickname, nameof(bodymailNickname), required: false);
            var __workflow_bodysecurityEnabled = WorkflowExpression.Compile(bodysecurityEnabled, nameof(bodysecurityEnabled), required: false);
            return new DeferredBodyAction<PostGraphGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graph/v1/organizations/{0}/v1.0/groups", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodydisplayName != null)
                {
                    body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                    bodypropCount++;
                }

                if (__workflow_bodygroupTypes != null)
                {
                    body["groupTypes"] = ExpressionConverter.ConvertO(__workflow_bodygroupTypes);
                    bodypropCount++;
                }

                if (__workflow_bodymailEnabled != null)
                {
                    body["mailEnabled"] = ExpressionConverter.ConvertO(__workflow_bodymailEnabled);
                    bodypropCount++;
                }

                if (__workflow_bodymailNickname != null)
                {
                    body["mailNickname"] = ExpressionConverter.ConvertO(__workflow_bodymailNickname);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityEnabled != null)
                {
                    body["securityEnabled"] = ExpressionConverter.ConvertO(__workflow_bodysecurityEnabled);
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
        public IBodyWorkflowAction<GetGraphDomainsResponse, ApiConnectionActionConfiguration> GetGraphDomains(Expression<Func<string>> organizationId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            return new DeferredBodyAction<GetGraphDomainsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graph/v1/organizations/{0}/v1.0/domains", __workflow_organizationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetGraphDomainsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteUserGroup(Expression<Func<string>> organizationId, Expression<Func<string>> userGroupId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_userGroupId = WorkflowExpression.Compile(userGroupId, nameof(userGroupId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/directory/v1/organizations/{0}/usergroups/{1}", __workflow_organizationId.WithUrlEncoding(1), __workflow_userGroupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteUserGroupMember(Expression<Func<string>> organizationId, Expression<Func<string>> userGroupId, Expression<Func<string>> userId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_userGroupId = WorkflowExpression.Compile(userGroupId, nameof(userGroupId), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/directory/v1/organizations/{0}/usergroups/{1}/members/{2}", __workflow_organizationId.WithUrlEncoding(1), __workflow_userGroupId.WithUrlEncoding(1), __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PostUserGroupMember(Expression<Func<string>> organizationId, Expression<Func<string>> userGroupId, Expression<Func<string>> userId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_userGroupId = WorkflowExpression.Compile(userGroupId, nameof(userGroupId), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/directory/v1/organizations/{0}/usergroups/{1}/members/{2}", __workflow_organizationId.WithUrlEncoding(1), __workflow_userGroupId.WithUrlEncoding(1), __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddGraphGroupMember(Expression<Func<string>> organizationId, Expression<Func<string>> microsoftObjectId, Expression<Func<string>> bodyid)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_microsoftObjectId = WorkflowExpression.Compile(microsoftObjectId, nameof(microsoftObjectId), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graph/v1/organizations/{0}/v1.0/groups/{1}/members/$ref", __workflow_organizationId.WithUrlEncoding(1), __workflow_microsoftObjectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["@odata.id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveGraphGroupMember(Expression<Func<string>> organizationId, Expression<Func<string>> groupMicrosoftObjectId, Expression<Func<string>> userMicrosoftObjectId)
        {
            var __workflow_organizationId = WorkflowExpression.Compile(organizationId, nameof(organizationId), required: true);
            var __workflow_groupMicrosoftObjectId = WorkflowExpression.Compile(groupMicrosoftObjectId, nameof(groupMicrosoftObjectId), required: true);
            var __workflow_userMicrosoftObjectId = WorkflowExpression.Compile(userMicrosoftObjectId, nameof(userMicrosoftObjectId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/graph/v1/organizations/{0}/v1.0/groups/{1}/members/{2}/$ref", __workflow_organizationId.WithUrlEncoding(1), __workflow_groupMicrosoftObjectId.WithUrlEncoding(1), __workflow_userMicrosoftObjectId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IBodyWorkflowAction<GetSubscriptionsResponse, ApiConnectionActionConfiguration> GetSubscriptions(Expression<Func<string>> partnerId, Expression<Func<string>> customerId, Expression<Func<string>> tenantId)
        {
            var __workflow_partnerId = WorkflowExpression.Compile(partnerId, nameof(partnerId), required: true);
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: true);
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            return new DeferredBodyAction<GetSubscriptionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/partnercenter/v1/partners/{0}/organizations/{1}/v1.0/customers/{2}/subscriptions", __workflow_partnerId.WithUrlEncoding(1), __workflow_customerId.WithUrlEncoding(1), __workflow_tenantId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSubscriptionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "spinpanel")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PatchSubscriptionQuantity(Expression<Func<string>> partnerId, Expression<Func<string>> customerId, Expression<Func<string>> tenantId, Expression<Func<string>> subscriptionId, Expression<Func<int>> bodyquantity = null)
        {
            var __workflow_partnerId = WorkflowExpression.Compile(partnerId, nameof(partnerId), required: true);
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: true);
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: true);
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            var __workflow_bodyquantity = WorkflowExpression.Compile(bodyquantity, nameof(bodyquantity), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/partnercenter/v1/partners/{0}/organizations/{1}/v1.0/customers/{2}/subscriptions/{3}", __workflow_partnerId.WithUrlEncoding(1), __workflow_customerId.WithUrlEncoding(1), __workflow_tenantId.WithUrlEncoding(1), __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyquantity != null)
                {
                    body["quantity"] = ExpressionConverter.ConvertO(__workflow_bodyquantity);
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