//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azuread
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureadActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IBodyWorkflowAction<CreateGroupResponse, ApiConnectionActionConfiguration> CreateOffice365Group(Expression<Func<CreateOffice365GroupBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/groups/office365";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IBodyWorkflowAction<CreateGroupResponse, ApiConnectionActionConfiguration> CreateSecurityGroup(Expression<Func<CreateSecurityGroupBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/groups/securityGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IBodyWorkflowAction<GetGroupResponse, ApiConnectionActionConfiguration> GetGroup(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/groups/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IBodyWorkflowAction<GetUserResponse, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateUser(Expression<Func<string>> id, Expression<Func<UpdateUserBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RefreshTokens(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/users/{0}/revokeSignInSessions", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IBodyWorkflowAction<GetUserResponse, ApiConnectionActionConfiguration> CreateUser(Expression<Func<CreateUserBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IBodyWorkflowAction<GetGroupMembersResponse, ApiConnectionActionConfiguration> GetGroupMembers(Expression<Func<string>> id, Expression<Func<int>> top = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<GetGroupMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/groups/{0}/members", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<GetGroupMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveMemberFromGroup(Expression<Func<string>> groupId, Expression<Func<string>> memberId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/groups/{0}/members/{1}/$ref", __workflow_groupId.WithUrlEncoding(1), __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddUserToGroup(Expression<Func<string>> id, Expression<Func<AddUserToGroupBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/groups/{0}/members/$ref", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AssignManager(Expression<Func<string>> id, Expression<Func<AssignManagerBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/users/{0}/manager/$ref", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IBodyWorkflowAction<CreateGroupResponse, ApiConnectionActionConfiguration> CreateGroup(Expression<Func<CreateGroupBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateGroupResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/groups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateGroupResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IBodyWorkflowAction<GetMemberGroupsResponseV2, ApiConnectionActionConfiguration> CheckMemberGroups(Expression<Func<string>> id, Expression<Func<CheckMemberGroupsBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetMemberGroupsResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/v1.0/users/{0}/checkMemberGroups", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetMemberGroupsResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azuread")]
        public IBodyWorkflowAction<GetMemberGroupsResponseV2, ApiConnectionActionConfiguration> GetMemberGroups(Expression<Func<string>> id, Expression<Func<GetMemberGroupsBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetMemberGroupsResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/v1.0/users/{0}/getMemberGroups", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetMemberGroupsResponseV2>(callPayload);
            });
        }
    }

    public class AzureadTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateGroupResponse
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
        public bool OnPremisesSyncEnabled { get; set; }

        [JsonProperty("proxyAddresses")]
        public string[] ProxyAddresses { get; set; }

        [JsonProperty("renewedDateTime")]
        public string RenewedDateTime { get; set; }

        [JsonProperty("securityEnabled")]
        public bool SecurityEnabled { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public class CreateOffice365GroupBodyInput
    {
        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("mailNickname", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MailNickname { get; set; }

        [JsonProperty("groupTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] GroupTypes { get; set; } = new string[]
        {
            "Unified"
        };

        [JsonProperty("securityEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool SecurityEnabled { get; set; }

        [JsonProperty("mailEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool MailEnabled { get; set; }
    }

    public class CreateSecurityGroupBodyInput
    {
        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("mailNickname", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MailNickname { get; set; }

        [JsonProperty("securityEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool SecurityEnabled { get; set; }

        [JsonProperty("mailEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool MailEnabled { get; set; }
    }

    public class GetGroupResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deletedDateTime")]
        public string DeletedDateTime { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("mailEnabled")]
        public bool MailEnabled { get; set; }

        [JsonProperty("onPremisesLastSyncDateTime")]
        public string OnPremisesLastSyncDateTime { get; set; }

        [JsonProperty("onPremisesSyncEnabled")]
        public bool OnPremisesSyncEnabled { get; set; }

        [JsonProperty("securityEnabled")]
        public bool SecurityEnabled { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public class GetUserResponse
    {
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

    public class UpdateUserBodyInput
    {
        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("mailNickname")]
        public string MailNickname { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("accountEnabled")]
        public bool? AccountEnabled { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }

        [JsonProperty("businessPhones")]
        public string[] BusinessPhones { get; set; }

        [JsonProperty("otherMails")]
        public string[] OtherMails { get; set; }

        [JsonProperty("customProperties")]
        public JToken AdditionalProperties { get; set; }

        [JsonProperty("onPremisesExtensionAttributes")]
        public BodyInputOnPremisesExtensionAttributesType OnPremisesExtensionAttributes { get; set; }
    }

    public class BodyInputOnPremisesExtensionAttributesType
    {
        [JsonProperty("extensionAttribute1")]
        public string FirstCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute2")]
        public string SecondCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute3")]
        public string ThirdCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute4")]
        public string FourthCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute5")]
        public string FifthCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute6")]
        public string SixthCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute7")]
        public string SeventhCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute8")]
        public string EighthCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute9")]
        public string NinthCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute10")]
        public string TenthCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute11")]
        public string EleventhCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute12")]
        public string TwelfthCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute13")]
        public string ThirteenthCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute14")]
        public string FourteenthCustomizableExtensionAttribute { get; set; }

        [JsonProperty("extensionAttribute15")]
        public string FifteenthCustomizableExtensionAttribute { get; set; }
    }

    public class CreateUserBodyInput
    {
        [JsonProperty("accountEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AccountEnabled { get; set; }

        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("mailNickname", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MailNickname { get; set; }

        [JsonProperty("passwordProfile", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputPasswordProfileType PasswordProfile { get; set; }

        [JsonProperty("userPrincipalName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserPrincipalName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("businessPhones")]
        public string[] BusinessPhones { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }
    }

    public class BodyInputPasswordProfileType
    {
        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
    }

    public class GetGroupMembersResponse
    {
        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("value")]
        public GetUserResponse[] GroupMembers { get; set; }
    }

    public class AddUserToGroupBodyInput
    {
        [JsonProperty("@odata.id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserId { get; set; }
    }

    public class AssignManagerBodyInput
    {
        [JsonProperty("@odata.id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdOfTheManager { get; set; }
    }

    public class CreateGroupBodyInput
    {
        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty("mailNickname", DefaultValueHandling = DefaultValueHandling.Include)]
        public string MailNickname { get; set; }

        [JsonProperty("groupTypes", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputGroupTypesTypeItem[] GroupTypes { get; set; }

        [JsonProperty("securityEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool SecurityEnabled { get; set; }

        [JsonProperty("mailEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool MailEnabled { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputGroupTypesTypeItem
    {
        Unified,
        None
    }

    public class GetMemberGroupsResponseV2
    {
        [JsonProperty("value")]
        public string[] Value { get; set; }
    }

    public class CheckMemberGroupsBodyInput
    {
        [JsonProperty("groupIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] GroupIds { get; set; }
    }

    public class GetMemberGroupsBodyInput
    {
        [JsonProperty("securityEnabledOnly", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool SecurityEnabledOnly { get; set; } = true;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azuread;

    public partial class WorkflowManagedActions
    {
        public AzureadActions Azuread(string connectionId) => new AzureadActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureadTriggers Azuread(string connectionId) => new AzureadTriggers(connectionId);
    }
}