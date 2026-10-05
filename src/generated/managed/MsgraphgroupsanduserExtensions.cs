//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Msgraphgroupsanduser
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MsgraphgroupsanduserActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msgraphgroupsanduser")]
        public IBodyWorkflowAction<ListUsersResponse> ListUsers()
        {
            var apiCallPath = "/v1.0/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListUsersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msgraphgroupsanduser")]
        [WorkflowExpressionFactory(nameof(__BuildListGroupsByDisplayNameSearch))]
        public IBodyWorkflowAction<ListGroupsByDisplayNameSearchResponse> ListGroupsByDisplayNameSearch([WorkflowExpression] Func<string> search = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListGroupsByDisplayNameSearchResponse> __BuildListGroupsByDisplayNameSearch(WorkflowValue<string> search = null)
        {
            WorkflowValue.Validate(search, nameof(search), required: false);
            return new DeferredBodyAction<ListGroupsByDisplayNameSearchResponse>(() =>
            {
                var apiCallPath = "/v1.0/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$search"] = Convert.ToString("\"displayName:Sales\"");
                if (search != null)
                    callPayload.Queries["$search"] = ExpressionConverter.Convert(search);
                callPayload.Queries["$count"] = Convert.ToString("true");
                callPayload.Headers["ConsistencyLevel"] = Convert.ToString("eventual");
                return new ApiConnectionAction<ListGroupsByDisplayNameSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msgraphgroupsanduser")]
        public IBodyWorkflowAction<ListSubscribedSkusResponse> ListSubscribedSkus()
        {
            var apiCallPath = "/v1.0/subscribedSkus";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListSubscribedSkusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msgraphgroupsanduser")]
        [WorkflowExpressionFactory(nameof(__BuildListDirectGroupMembers))]
        public IBodyWorkflowAction<ListDirectGroupMembersResponse> ListDirectGroupMembers([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListDirectGroupMembersResponse> __BuildListDirectGroupMembers(WorkflowValue<string> groupId, WorkflowValue<string> filter = null, WorkflowValue<string> select = null)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<ListDirectGroupMembersResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$filter"] = Convert.ToString("jobTitle ne null");
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                callPayload.Queries["$select"] = Convert.ToString("displayName,userPrincipalName,id,jobTitle,mailNickname");
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                callPayload.Queries["$count"] = Convert.ToString("true");
                callPayload.Headers["ConsistencyLevel"] = Convert.ToString("eventual");
                return new ApiConnectionAction<ListDirectGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msgraphgroupsanduser")]
        [WorkflowExpressionFactory(nameof(__BuildGetMemberLicenseDetails))]
        public IBodyWorkflowAction<GetMemberLicenseDetailsResponse> GetMemberLicenseDetails([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMemberLicenseDetailsResponse> __BuildGetMemberLicenseDetails(WorkflowValue<string> id, WorkflowValue<string> select = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<GetMemberLicenseDetailsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/users/{0}/licenseDetails", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$select"] = Convert.ToString("skuPartNumber,servicePlans");
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<GetMemberLicenseDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msgraphgroupsanduser")]
        [WorkflowExpressionFactory(nameof(__BuildGetGroupProperties))]
        public IBodyWorkflowAction<GetGroupPropertiesResponse> GetGroupProperties([WorkflowExpression] Func<string> groupId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGroupPropertiesResponse> __BuildGetGroupProperties(WorkflowValue<string> groupId)
        {
            WorkflowValue.Validate(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<GetGroupPropertiesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/groups/{0}", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetGroupPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "msgraphgroupsanduser")]
        [WorkflowExpressionFactory(nameof(__BuildGetMemberGroups))]
        public IBodyWorkflowAction<GetMemberGroupsResponse> GetMemberGroups([WorkflowExpression] Func<string> memberId, [WorkflowExpression] Func<bool> bodysecurityEnabledOnly)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMemberGroupsResponse> __BuildGetMemberGroups(WorkflowValue<string> memberId, WorkflowValue<bool> bodysecurityEnabledOnly)
        {
            WorkflowValue.Validate(memberId, nameof(memberId), required: true);
            WorkflowValue.Validate(bodysecurityEnabledOnly, nameof(bodysecurityEnabledOnly), required: true);
            return new DeferredBodyAction<GetMemberGroupsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/users/{0}/getMemberGroups", ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["securityEnabledOnly"] = ExpressionConverter.ConvertO(bodysecurityEnabledOnly);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetMemberGroupsResponse>(callPayload);
            });
        }
    }

    public class MsgraphgroupsanduserTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListUsersResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public ListUsersResponseValueTypeItem[] Value { get; set; }
    }

    public class ListUsersResponseValueTypeItem
    {
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

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ListGroupsByDisplayNameSearchResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ListGroupsByDisplayNameSearchResponseValueTypeItem[] Value { get; set; }
    }

    public class ListGroupsByDisplayNameSearchResponseValueTypeItem
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
        public JToken[] CreationOptions { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("expirationDateTime")]
        public string ExpirationDateTime { get; set; }

        [JsonProperty("groupTypes")]
        public string[] GroupTypes { get; set; }

        [JsonProperty("isAssignableToRole")]
        public string IsAssignableToRole { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("mailEnabled")]
        public bool MailEnabled { get; set; }

        [JsonProperty("mailNickname")]
        public string MailNickname { get; set; }

        [JsonProperty("membershipRule")]
        public string MembershipRule { get; set; }

        [JsonProperty("membershipRuleProcessingState")]
        public string MembershipRuleProcessingState { get; set; }

        [JsonProperty("onPremisesDomainName")]
        public string OnPremisesDomainName { get; set; }

        [JsonProperty("onPremisesLastSyncDateTime")]
        public string OnPremisesLastSyncDateTime { get; set; }

        [JsonProperty("onPremisesNetBiosName")]
        public string OnPremisesNetBiosName { get; set; }

        [JsonProperty("onPremisesSamAccountName")]
        public string OnPremisesSamAccountName { get; set; }

        [JsonProperty("onPremisesSecurityIdentifier")]
        public string OnPremisesSecurityIdentifier { get; set; }

        [JsonProperty("onPremisesSyncEnabled")]
        public bool OnPremisesSyncEnabled { get; set; }

        [JsonProperty("preferredDataLocation")]
        public string PreferredDataLocation { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }

        [JsonProperty("proxyAddresses")]
        public string[] ProxyAddresses { get; set; }

        [JsonProperty("renewedDateTime")]
        public string RenewedDateTime { get; set; }

        [JsonProperty("resourceBehaviorOptions")]
        public JToken[] ResourceBehaviorOptions { get; set; }

        [JsonProperty("resourceProvisioningOptions")]
        public string[] ResourceProvisioningOptions { get; set; }

        [JsonProperty("securityEnabled")]
        public bool SecurityEnabled { get; set; }

        [JsonProperty("securityIdentifier")]
        public string SecurityIdentifier { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("onPremisesProvisioningErrors")]
        public JToken[] OnPremisesProvisioningErrors { get; set; }
    }

    public class ListSubscribedSkusResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public ListSubscribedSkusResponseValueTypeItem[] Value { get; set; }
    }

    public class ListSubscribedSkusResponseValueTypeItem
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
        public ListSubscribedSkusResponseValueTypeItemPrepaidUnitsType PrepaidUnits { get; set; }

        [JsonProperty("servicePlans")]
        public ListSubscribedSkusResponseValueTypeItemServicePlansTypeItem[] ServicePlans { get; set; }
    }

    public class ListSubscribedSkusResponseValueTypeItemPrepaidUnitsType
    {
        [JsonProperty("enabled")]
        public int Enabled { get; set; }

        [JsonProperty("suspended")]
        public int Suspended { get; set; }

        [JsonProperty("warning")]
        public int Warning { get; set; }
    }

    public class ListSubscribedSkusResponseValueTypeItemServicePlansTypeItem
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

    public class ListDirectGroupMembersResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ListDirectGroupMembersResponseValueTypeItem[] Value { get; set; }
    }

    public class ListDirectGroupMembersResponseValueTypeItem
    {
        [JsonProperty("@odata.type")]
        public string Type { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("mailNickname")]
        public string MailNickname { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("businessPhones")]
        public string[] BusinessPhones { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }
    }

    public class GetMemberLicenseDetailsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public GetMemberLicenseDetailsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetMemberLicenseDetailsResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("skuId")]
        public string SkuId { get; set; }

        [JsonProperty("skuPartNumber")]
        public string SkuPartNumber { get; set; }

        [JsonProperty("servicePlans")]
        public GetMemberLicenseDetailsResponseValueTypeItemServicePlansTypeItem[] ServicePlans { get; set; }
    }

    public class GetMemberLicenseDetailsResponseValueTypeItemServicePlansTypeItem
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

    public class GetGroupPropertiesResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

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

        [JsonProperty("expirationDateTime")]
        public string ExpirationDateTime { get; set; }

        [JsonProperty("groupTypes")]
        public string[] GroupTypes { get; set; }

        [JsonProperty("isAssignableToRole")]
        public string IsAssignableToRole { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("mailEnabled")]
        public bool MailEnabled { get; set; }

        [JsonProperty("mailNickname")]
        public string MailNickname { get; set; }

        [JsonProperty("membershipRule")]
        public string MembershipRule { get; set; }

        [JsonProperty("membershipRuleProcessingState")]
        public string MembershipRuleProcessingState { get; set; }

        [JsonProperty("onPremisesDomainName")]
        public string OnPremisesDomainName { get; set; }

        [JsonProperty("onPremisesLastSyncDateTime")]
        public string OnPremisesLastSyncDateTime { get; set; }

        [JsonProperty("onPremisesNetBiosName")]
        public string OnPremisesNetBiosName { get; set; }

        [JsonProperty("onPremisesSamAccountName")]
        public string OnPremisesSamAccountName { get; set; }

        [JsonProperty("onPremisesSecurityIdentifier")]
        public string OnPremisesSecurityIdentifier { get; set; }

        [JsonProperty("onPremisesSyncEnabled")]
        public bool OnPremisesSyncEnabled { get; set; }

        [JsonProperty("preferredDataLocation")]
        public string PreferredDataLocation { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }

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

        [JsonProperty("securityIdentifier")]
        public string SecurityIdentifier { get; set; }

        [JsonProperty("theme")]
        public string Theme { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("onPremisesProvisioningErrors")]
        public string[] OnPremisesProvisioningErrors { get; set; }
    }

    public class GetMemberGroupsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public string[] Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Msgraphgroupsanduser;

    public partial class WorkflowManagedActions
    {
        public MsgraphgroupsanduserActions Msgraphgroupsanduser(string connectionId) => new MsgraphgroupsanduserActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MsgraphgroupsanduserTriggers Msgraphgroupsanduser(string connectionId) => new MsgraphgroupsanduserTriggers(connectionId);
    }
}
