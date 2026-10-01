//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nablecloudcommander
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NablecloudcommanderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<GetOrganizationsResponse> GetOrganizations()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/directory/v1/organizations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["provider"] = Convert.ToString("spinpanel.platform");
                return callPayload;
            }

            return new ApiConnectionAction<GetOrganizationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<GetUsersResponse> GetUsers([WorkflowExpression] Func<string> filter, [WorkflowExpression] Func<int> top, [WorkflowExpression] Func<skipInput> skip = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/directory/v1/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.Convert(skip);
                callPayload.Queries["$count"] = Convert.ToString(true);
                callPayload.Queries["provider"] = Convert.ToString("spinpanel.platform");
                return callPayload;
            }

            return new ApiConnectionAction<GetUsersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<CreateUserResponse> CreateUser([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<bool> bodyaccountEnabled = null, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string> bodymailNickname = null, [WorkflowExpression] Func<string> bodyuserPrincipalName = null, [WorkflowExpression] Func<bool> bodypasswordProfileforceChangePasswordNextSignIn = null, [WorkflowExpression] Func<string> bodypasswordProfilepassword = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccountEnabled != null)
                {
                    body["accountEnabled"] = SourceExpressionConverter.ConvertToken(bodyaccountEnabled);
                    bodypropCount++;
                }

                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                if (bodymailNickname != null)
                {
                    body["mailNickname"] = SourceExpressionConverter.ConvertToken(bodymailNickname);
                    bodypropCount++;
                }

                if (bodyuserPrincipalName != null)
                {
                    body["userPrincipalName"] = SourceExpressionConverter.ConvertToken(bodyuserPrincipalName);
                    bodypropCount++;
                }

                var passwordProfileObject = new JObject();
                var passwordProfileObjectpropCount = 0;
                if (bodypasswordProfileforceChangePasswordNextSignIn != null)
                {
                    passwordProfileObject["forceChangePasswordNextSignIn"] = SourceExpressionConverter.ConvertToken(bodypasswordProfileforceChangePasswordNextSignIn);
                    passwordProfileObjectpropCount++;
                }

                if (bodypasswordProfilepassword != null)
                {
                    passwordProfileObject["password"] = SourceExpressionConverter.ConvertToken(bodypasswordProfilepassword);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<GetGraphUserResponse> GetGraphUser([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetGraphUserResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IWorkflowAction DeleteGraphUser([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IWorkflowAction PatchGraphUser([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string> bodygivenName = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodymail = null, [WorkflowExpression] Func<string> bodymobilePhone = null, [WorkflowExpression] Func<string> bodyofficeLocation = null, [WorkflowExpression] Func<string> bodypreferredLanguage = null, [WorkflowExpression] Func<string> bodysurname = null, [WorkflowExpression] Func<string> bodyuserPrincipalName = null, [WorkflowExpression] Func<bool> bodyaccountEnabled = null, [WorkflowExpression] Func<bool> bodypasswordProfileforceChangePasswordNextSignIn = null, [WorkflowExpression] Func<string> bodypasswordProfilepassword = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                if (bodygivenName != null)
                {
                    body["givenName"] = SourceExpressionConverter.ConvertToken(bodygivenName);
                    bodypropCount++;
                }

                if (bodyjobTitle != null)
                {
                    body["jobTitle"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodymail != null)
                {
                    body["mail"] = SourceExpressionConverter.ConvertToken(bodymail);
                    bodypropCount++;
                }

                if (bodymobilePhone != null)
                {
                    body["mobilePhone"] = SourceExpressionConverter.ConvertToken(bodymobilePhone);
                    bodypropCount++;
                }

                if (bodyofficeLocation != null)
                {
                    body["officeLocation"] = SourceExpressionConverter.ConvertToken(bodyofficeLocation);
                    bodypropCount++;
                }

                if (bodypreferredLanguage != null)
                {
                    body["preferredLanguage"] = SourceExpressionConverter.ConvertToken(bodypreferredLanguage);
                    bodypropCount++;
                }

                if (bodysurname != null)
                {
                    body["surname"] = SourceExpressionConverter.ConvertToken(bodysurname);
                    bodypropCount++;
                }

                if (bodyuserPrincipalName != null)
                {
                    body["userPrincipalName"] = SourceExpressionConverter.ConvertToken(bodyuserPrincipalName);
                    bodypropCount++;
                }

                if (bodyaccountEnabled != null)
                {
                    body["accountEnabled"] = SourceExpressionConverter.ConvertToken(bodyaccountEnabled);
                    bodypropCount++;
                }

                var passwordProfileObject = new JObject();
                var passwordProfileObjectpropCount = 0;
                if (bodypasswordProfileforceChangePasswordNextSignIn != null)
                {
                    passwordProfileObject["forceChangePasswordNextSignIn"] = SourceExpressionConverter.ConvertToken(bodypasswordProfileforceChangePasswordNextSignIn);
                    passwordProfileObjectpropCount++;
                }

                if (bodypasswordProfilepassword != null)
                {
                    passwordProfileObject["password"] = SourceExpressionConverter.ConvertToken(bodypasswordProfilepassword);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<GetUserLicenseDetailsResponse> GetUserLicenseDetails([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}/licenseDetails", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetUserLicenseDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<GetsubscribedSkusResponse> GetsubscribedSkus([WorkflowExpression] Func<string> organizationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/subscribedSkus", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetsubscribedSkusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<PostUserLicenseResponse> PostUserLicense([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId, [WorkflowExpression] Func<bodyaddLicensesInputItem[]> bodyaddLicenses, [WorkflowExpression] Func<string[]> bodyremoveLicenses = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}/assignlicense", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["addLicenses"] = SourceExpressionConverter.ConvertToken(bodyaddLicenses);
                if (bodyremoveLicenses != null)
                {
                    body["removeLicenses"] = SourceExpressionConverter.ConvertToken(bodyremoveLicenses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostUserLicenseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<GetGroupsResponse> GetGroups([WorkflowExpression] Func<string> filter)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/directory/v1/usergroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                callPayload.Queries["provider"] = Convert.ToString("spinpanel.groups");
                return callPayload;
            }

            return new ApiConnectionAction<GetGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<UserGroupMembersResponse> UserGroupMembers([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> userGroupId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/directory/v1/organizations/{0}/usergroups/{1}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userGroupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["provider"] = Convert.ToString("spinpanel.groups");
                return callPayload;
            }

            return new ApiConnectionAction<UserGroupMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<GetADSecurityGroupsResponse> GetADSecurityGroups([WorkflowExpression] Func<string> organizationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/groups", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$select"] = Convert.ToString("createdDateTime,displayName,groupTypes,id,securityEnabled");
                return callPayload;
            }

            return new ApiConnectionAction<GetADSecurityGroupsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<PostGraphGroupResponse> PostGraphGroup([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string[]> bodygroupTypes = null, [WorkflowExpression] Func<bool> bodymailEnabled = null, [WorkflowExpression] Func<string> bodymailNickname = null, [WorkflowExpression] Func<bool> bodysecurityEnabled = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/groups", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                if (bodygroupTypes != null)
                {
                    body["groupTypes"] = SourceExpressionConverter.ConvertToken(bodygroupTypes);
                    bodypropCount++;
                }

                if (bodymailEnabled != null)
                {
                    body["mailEnabled"] = SourceExpressionConverter.ConvertToken(bodymailEnabled);
                    bodypropCount++;
                }

                if (bodymailNickname != null)
                {
                    body["mailNickname"] = SourceExpressionConverter.ConvertToken(bodymailNickname);
                    bodypropCount++;
                }

                if (bodysecurityEnabled != null)
                {
                    body["securityEnabled"] = SourceExpressionConverter.ConvertToken(bodysecurityEnabled);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostGraphGroupResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<GetGraphDomainsResponse> GetGraphDomains([WorkflowExpression] Func<string> organizationId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/domains", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetGraphDomainsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IWorkflowAction DeleteUserGroup([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> userGroupId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/directory/v1/organizations/{0}/usergroups/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userGroupId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IWorkflowAction DeleteUserGroupMember([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> userGroupId, [WorkflowExpression] Func<string> userId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/directory/v1/organizations/{0}/usergroups/{1}/members/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userGroupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IWorkflowAction PostUserGroupMember([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> userGroupId, [WorkflowExpression] Func<string> userId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/directory/v1/organizations/{0}/usergroups/{1}/members/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userGroupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IWorkflowAction AddGraphGroupMember([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId, [WorkflowExpression] Func<string> bodyid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/groups/{1}/members/$ref", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["@odata.id"] = SourceExpressionConverter.ConvertToken(bodyid);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IWorkflowAction RemoveGraphGroupMember([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> groupMicrosoftObjectId, [WorkflowExpression] Func<string> userMicrosoftObjectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/groups/{1}/members/{2}/$ref", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupMicrosoftObjectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userMicrosoftObjectId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<GetSubscriptionsResponse> GetSubscriptions([WorkflowExpression] Func<string> partnerId, [WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> tenantId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/partnercenter/v1/partners/{0}/organizations/{1}/v1.0/customers/{2}/subscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partnerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tenantId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSubscriptionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IWorkflowAction PatchSubscriptionQuantity([WorkflowExpression] Func<string> partnerId, [WorkflowExpression] Func<string> customerId, [WorkflowExpression] Func<string> tenantId, [WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<int> bodyquantity = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/partnercenter/v1/partners/{0}/organizations/{1}/v1.0/customers/{2}/subscriptions/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(partnerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customerId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tenantId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriptionId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyquantity != null)
                {
                    body["quantity"] = SourceExpressionConverter.ConvertToken(bodyquantity);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<GetLocalesResponse> GetLocales()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/directory/v1/locales";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["provider"] = Convert.ToString("spinpanel.platform");
                return callPayload;
            }

            return new ApiConnectionAction<GetLocalesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IBodyWorkflowAction<GetAssignManagerResponse> GetAssignManager([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}/manager", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetAssignManagerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nablecloudcommander")]
        public IWorkflowAction PutAssignManager([WorkflowExpression] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId, [WorkflowExpression] Func<string> bodyid = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/graph/v1/organizations/{0}/v1.0/users/{1}/manager/$ref", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(organizationId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(microsoftObjectId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["@odata.id"] = SourceExpressionConverter.ConvertToken(bodyid);
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
    }

    public class NablecloudcommanderTriggers([ConnectionName] string connectionId)
    {
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

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("productIdentifier")]
        public string ProductIdentifier { get; set; }

        [JsonProperty("productIdentifierType")]
        public string ProductIdentifierType { get; set; }

        [JsonProperty("hybridADEnabled")]
        public bool HybridADEnabled { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public string ModifiedOn { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
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

        [JsonProperty("isHybridUser")]
        public bool IsHybridUser { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public string ModifiedOn { get; set; }
    }

    public enum skipInput
    {
        _0 = 0,
        _5 = 5,
        _15 = 15,
        _30 = 30,
        _50 = 50,
        _100 = 100
    }

    public class CreateUserResponse
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
        public string[] DisabledPlans { get; set; }

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

    public class GetAssignManagerResponse
    {
        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetAssignManagerResponseValueTypeItem[] Value { get; set; }
    }

    public class GetAssignManagerResponseValueTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("microsoftTenantId")]
        public string MicrosoftTenantId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("productIdentifier")]
        public string ProductIdentifier { get; set; }

        [JsonProperty("productIdentifierType")]
        public string ProductIdentifierType { get; set; }

        [JsonProperty("hybridADEnabled")]
        public bool HybridADEnabled { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("modifiedOn")]
        public string ModifiedOn { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nablecloudcommander;

    public partial class WorkflowManagedActions
    {
        public NablecloudcommanderActions Nablecloudcommander(string connectionId) => new NablecloudcommanderActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NablecloudcommanderTriggers Nablecloudcommander(string connectionId) => new NablecloudcommanderTriggers(connectionId);
    }
}