//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nableclouduserhub
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NableclouduserhubActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<GetLocalesResponse> GetLocales()
        {
            var apiCallPath = "/directory/v1/locales";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["provider"] = Convert.ToString("spinpanel.platform");
            return new ApiConnectionAction<GetLocalesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<GetUsersResponse> GetUsers([WorkflowExpression] Func<string> filter)
        {
            var apiCallPath = "/directory/v1/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["provider"] = Convert.ToString("spinpanel.users");
            return new ApiConnectionAction<GetUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<GetGraphUserResponse> GetGraphUser([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId)
        {
            var apiCallPath = String.Format("/graph/v1/organizations/{0}/v1.0/users/{1}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(microsoftObjectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetGraphUserResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IWorkflowAction DeleteGraphUser([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId)
        {
            var apiCallPath = String.Format("/graph/v1/organizations/{0}/v1.0/users/{1}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(microsoftObjectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IWorkflowAction PatchGraphUserPassword([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId, [WorkflowExpression] Func<bool> bodypasswordProfileforceChangePasswordNextSignIn = null, [WorkflowExpression] Func<string> bodypasswordProfilepassword = null)
        {
            var apiCallPath = String.Format("/graph/v1/organizations/{0}/v1.0/users/{1}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(microsoftObjectId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<GetOrganizationsResponse> GetOrganizations()
        {
            var apiCallPath = "/directory/v1/organizations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["provider"] = Convert.ToString("spinpanel.users");
            return new ApiConnectionAction<GetOrganizationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<PostGraphUserResponse> PostGraphUser([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId, [WorkflowExpression] Func<bool> bodyaccountEnabled = null, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string> bodymailNickname = null, [WorkflowExpression] Func<string> bodyuserPrincipalName = null, [WorkflowExpression] Func<bool> bodypasswordProfileforceChangePasswordNextSignIn = null, [WorkflowExpression] Func<string> bodypasswordProfilepassword = null)
        {
            var apiCallPath = String.Format("/graph/v1/organizations/{0}/v1.0/users", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<GetUserLicenseDetailsResponse> GetUserLicenseDetails([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId)
        {
            var apiCallPath = String.Format("/graph/v1/organizations/{0}/v1.0/users/{1}/licenseDetails", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(microsoftObjectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetUserLicenseDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<GetsubscribedSkusResponse> GetsubscribedSkus([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId)
        {
            var apiCallPath = String.Format("/graph/v1/organizations/{0}/v1.0/subscribedSkus", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetsubscribedSkusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<PostUserLicenseResponse> PostUserLicense([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId, [WorkflowExpression] Func<bodyaddLicensesInputItem[]> bodyaddLicenses = null, [WorkflowExpression] Func<JToken[]> bodyremoveLicenses = null)
        {
            var apiCallPath = String.Format("/graph/v1/organizations/{0}/v1.0/users/{1}/assignlicense", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(microsoftObjectId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<GetGroupsResponse> GetGroups([WorkflowExpression] Func<string> filter)
        {
            var apiCallPath = "/directory/v1/usergroups";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["provider"] = Convert.ToString("spinpanel.groups");
            return new ApiConnectionAction<GetGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<UserGroupMembersResponse> UserGroupMembers([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId, [WorkflowExpression] Func<string> userGroupId)
        {
            var apiCallPath = String.Format("/directory/v1/organizations/{0}/usergroups/{1}/members", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(userGroupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["provider"] = Convert.ToString("spinpanel.groups");
            return new ApiConnectionAction<UserGroupMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<GetADSecurityGroupsResponse> GetADSecurityGroups([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId)
        {
            var apiCallPath = String.Format("/graph/v1/organizations/{0}/v1.0/groups", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$select"] = Convert.ToString("createdDateTime,displayName,groupTypes,id,securityEnabled");
            return new ApiConnectionAction<GetADSecurityGroupsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<PostGraphGroupResponse> PostGraphGroup([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string[]> bodygroupTypes = null, [WorkflowExpression] Func<bool> bodymailEnabled = null, [WorkflowExpression] Func<string> bodymailNickname = null, [WorkflowExpression] Func<bool> bodysecurityEnabled = null)
        {
            var apiCallPath = String.Format("/graph/v1/organizations/{0}/v1.0/groups", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<GetGraphDomainsResponse> GetGraphDomains([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId)
        {
            var apiCallPath = String.Format("/graph/v1/organizations/{0}/v1.0/domains", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetGraphDomainsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IWorkflowAction DeleteUserGroup([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId, [WorkflowExpression] Func<string> userGroupId)
        {
            var apiCallPath = String.Format("/directory/v1/organizations/{0}/usergroups/{1}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(userGroupId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IWorkflowAction DeleteUserGroupMember([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> userGroupId, [WorkflowExpression] Func<string> userId)
        {
            var apiCallPath = String.Format("/directory/v1/organizations/{0}/usergroups/{1}/members/{2}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(userGroupId, 1), ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IWorkflowAction PostUserGroupMember([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> userGroupId, [WorkflowExpression] Func<string> userId)
        {
            var apiCallPath = String.Format("/directory/v1/organizations/{0}/usergroups/{1}/members/{2}", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(userGroupId, 1), ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IWorkflowAction AddGraphGroupMember([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId, [WorkflowExpression] Func<string> microsoftObjectId, [WorkflowExpression] Func<string> bodyid)
        {
            var apiCallPath = String.Format("/graph/v1/organizations/{0}/v1.0/groups/{1}/members/$ref", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(microsoftObjectId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IWorkflowAction RemoveGraphGroupMember([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> organizationId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> groupMicrosoftObjectId, [WorkflowExpression] Func<string> userMicrosoftObjectId)
        {
            var apiCallPath = String.Format("/graph/v1/organizations/{0}/v1.0/groups/{1}/members/{2}/$ref", ExpressionConverter.ConvertWithUrlEncoding(organizationId, 1), ExpressionConverter.ConvertWithUrlEncoding(groupMicrosoftObjectId, 1), ExpressionConverter.ConvertWithUrlEncoding(userMicrosoftObjectId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IBodyWorkflowAction<GetSubscriptionsResponse> GetSubscriptions([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> partnerId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> customerId, [WorkflowExpression] Func<string> tenantId)
        {
            var apiCallPath = String.Format("/partnercenter/v1/partners/{0}/organizations/{1}/v1.0/customers/{2}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(partnerId, 1), ExpressionConverter.ConvertWithUrlEncoding(customerId, 1), ExpressionConverter.ConvertWithUrlEncoding(tenantId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSubscriptionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nableclouduserhub")]
        public IWorkflowAction PatchSubscriptionQuantity([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> partnerId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> customerId, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tenantId, [WorkflowExpression] Func<string> subscriptionId, [WorkflowExpression] Func<int> bodyquantity = null)
        {
            var apiCallPath = String.Format("/partnercenter/v1/partners/{0}/organizations/{1}/v1.0/customers/{2}/subscriptions/{3}", ExpressionConverter.ConvertWithUrlEncoding(partnerId, 1), ExpressionConverter.ConvertWithUrlEncoding(customerId, 1), ExpressionConverter.ConvertWithUrlEncoding(tenantId, 1), ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1));
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
        }
    }

    public class NableclouduserhubTriggers([ConnectionName] string connectionId)
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nableclouduserhub;

    public partial class WorkflowManagedActions
    {
        public NableclouduserhubActions Nableclouduserhub(string connectionId) => new NableclouduserhubActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NableclouduserhubTriggers Nableclouduserhub(string connectionId) => new NableclouduserhubTriggers(connectionId);
    }
}