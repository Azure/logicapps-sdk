//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.B2cidpconfiguration
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class B2cidpconfigurationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<ApplicationCollection, ApiConnectionActionConfiguration> GetApplications()
        {
            return new DeferredBodyAction<ApplicationCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/applications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ApplicationCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<Application, ApiConnectionActionConfiguration> PostApplication(Expression<Func<PostApplicationInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Application, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/applications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Application>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PatchApplication(Expression<Func<string>> id, Expression<Func<object>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/applications/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Me()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<PermissionGrantCollection, ApiConnectionActionConfiguration> GetPermissionGrants()
        {
            return new DeferredBodyAction<PermissionGrantCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/oauth2PermissionGrants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PermissionGrantCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<PermissionGrant, ApiConnectionActionConfiguration> PostPermissionGrant(Expression<Func<PostPermissionGrantInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PermissionGrant, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/oauth2PermissionGrants";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PermissionGrant>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<UserFlowCollection, ApiConnectionActionConfiguration> GetUserflows()
        {
            return new DeferredBodyAction<UserFlowCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/identity/userFlows";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserFlowCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<UserFlow, ApiConnectionActionConfiguration> PostUserflow(Expression<Func<PostUserflowInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UserFlow, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/identity/userFlows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserFlow>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<UserFlowCollection, ApiConnectionActionConfiguration> GetB2cuserflows()
        {
            return new DeferredBodyAction<UserFlowCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/identity/b2cUserflows";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserFlowCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<UserFlow, ApiConnectionActionConfiguration> PostB2cUserflow(Expression<Func<PostB2cUserflowInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UserFlow, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/beta/identity/b2cUserflows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserFlow>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<ServicePrincipleCollection, ApiConnectionActionConfiguration> GetServicePrinciple()
        {
            return new DeferredBodyAction<ServicePrincipleCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/serviceprincipals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ServicePrincipleCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<ServicePrinciple, ApiConnectionActionConfiguration> PostServicePrinciple(Expression<Func<PostServicePrincipleV1Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ServicePrinciple, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/serviceprincipals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ServicePrinciple>(callPayload);
            });
        }
    }

    public class B2cidpconfigurationTriggers([ConnectionName] string connectionId)
    {
    }

    public class ApplicationCollection
    {
        [JsonProperty("value")]
        public Application[] Value { get; set; }
    }

    public class Application
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deletedDateTime")]
        public string DeletedDateTime { get; set; }

        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("applicationTemplateId")]
        public string ApplicationTemplateId { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("groupMembershipClaims")]
        public string GroupMembershipClaims { get; set; }

        [JsonProperty("identifierUris")]
        public string[] IdentifierUris { get; set; }

        [JsonProperty("isDeviceOnlyAuthSupported")]
        public bool IsDeviceOnlyAuthSupported { get; set; }

        [JsonProperty("isFallbackPublicClient")]
        public bool IsFallbackPublicClient { get; set; }

        [JsonProperty("optionalClaims")]
        public string OptionalClaims { get; set; }

        [JsonProperty("publisherDomain")]
        public string PublisherDomain { get; set; }

        [JsonProperty("signInAudience")]
        public string SignInAudience { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("tokenEncryptionKeyId")]
        public string TokenEncryptionKeyId { get; set; }

        [JsonProperty("spa")]
        public ApplicationSpaType Spa { get; set; }

        [JsonProperty("addIns")]
        public JToken[] AddIns { get; set; }

        [JsonProperty("api")]
        public ApplicationApiType Api { get; set; }

        [JsonProperty("appRoles")]
        public JToken[] AppRoles { get; set; }

        [JsonProperty("info")]
        public ApplicationInfoType Info { get; set; }

        [JsonProperty("keyCredentials")]
        public JToken[] KeyCredentials { get; set; }

        [JsonProperty("parentalControlSettings")]
        public ApplicationParentalControlSettingsType ParentalControlSettings { get; set; }

        [JsonProperty("passwordCredentials")]
        public JToken[] PasswordCredentials { get; set; }

        [JsonProperty("publicClient")]
        public ApplicationPublicClientType PublicClient { get; set; }

        [JsonProperty("requiredResourceAccess")]
        public ApplicationRequiredResourceAccessTypeItem[] RequiredResourceAccess { get; set; }

        [JsonProperty("web")]
        public ApplicationWebType Web { get; set; }
    }

    public class ApplicationSpaType
    {
        [JsonProperty("redirectUris")]
        public JToken[] RedirectUris { get; set; }
    }

    public class ApplicationApiType
    {
        [JsonProperty("acceptMappedClaims")]
        public bool AcceptMappedClaims { get; set; }

        [JsonProperty("knownClientApplications")]
        public JToken[] KnownClientApplications { get; set; }

        [JsonProperty("requestedAccessTokenVersion")]
        public int RequestedAccessTokenVersion { get; set; }

        [JsonProperty("oauth2PermissionScopes")]
        public ApplicationApiTypeOauth2PermissionScopesTypeItem[] Oauth2PermissionScopes { get; set; }

        [JsonProperty("preAuthorizedApplications")]
        public JToken[] PreAuthorizedApplications { get; set; }
    }

    public class ApplicationApiTypeOauth2PermissionScopesTypeItem
    {
        [JsonProperty("adminConsentDescription")]
        public string AdminConsentDescription { get; set; }

        [JsonProperty("adminConsentDisplayName")]
        public string AdminConsentDisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("userConsentDescription")]
        public string UserConsentDescription { get; set; }

        [JsonProperty("userConsentDisplayName")]
        public string UserConsentDisplayName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ApplicationInfoType
    {
        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("marketingUrl")]
        public string MarketingUrl { get; set; }

        [JsonProperty("privacyStatementUrl")]
        public string PrivacyStatementUrl { get; set; }

        [JsonProperty("supportUrl")]
        public string SupportUrl { get; set; }

        [JsonProperty("termsOfServiceUrl")]
        public string TermsOfServiceUrl { get; set; }
    }

    public class ApplicationParentalControlSettingsType
    {
        [JsonProperty("countriesBlockedForMinors")]
        public JToken[] CountriesBlockedForMinors { get; set; }

        [JsonProperty("legalAgeGroupRule")]
        public string LegalAgeGroupRule { get; set; }
    }

    public class ApplicationPublicClientType
    {
        [JsonProperty("redirectUris")]
        public string[] RedirectUris { get; set; }
    }

    public class ApplicationRequiredResourceAccessTypeItem
    {
        [JsonProperty("resourceAppId")]
        public string ResourceAppId { get; set; }

        [JsonProperty("resourceAccess")]
        public ApplicationRequiredResourceAccessTypeItemResourceAccessTypeItem[] ResourceAccess { get; set; }
    }

    public class ApplicationRequiredResourceAccessTypeItemResourceAccessTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ApplicationWebType
    {
        [JsonProperty("homePageUrl")]
        public string HomePageUrl { get; set; }

        [JsonProperty("logoutUrl")]
        public string LogoutUrl { get; set; }

        [JsonProperty("redirectUris")]
        public string[] RedirectUris { get; set; }

        [JsonProperty("implicitGrantSettings")]
        public ApplicationWebTypeImplicitGrantSettingsType ImplicitGrantSettings { get; set; }
    }

    public class ApplicationWebTypeImplicitGrantSettingsType
    {
        [JsonProperty("enableAccessTokenIssuance")]
        public bool EnableAccessTokenIssuance { get; set; }

        [JsonProperty("enableIdTokenIssuance")]
        public bool EnableIdTokenIssuance { get; set; }
    }

    public class PostApplicationInput
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("isFallbackPublicClient")]
        public bool? IsFallbackPublicClient { get; set; }

        [JsonProperty("web")]
        public PostApplicationInputWebType Web { get; set; }
    }

    public class PostApplicationInputWebType
    {
        [JsonProperty("redirectUris")]
        public string[] RedirectUris { get; set; }

        [JsonProperty("implicitGrantSettings")]
        public PostApplicationInputWebTypeImplicitGrantSettingsType ImplicitGrantSettings { get; set; }
    }

    public class PostApplicationInputWebTypeImplicitGrantSettingsType
    {
        [JsonProperty("enableIdTokenIssuance")]
        public bool? EnableIdTokenIssuance { get; set; }

        [JsonProperty("enableAccessTokenIssuance")]
        public bool? EnableAccessTokenIssuance { get; set; }
    }

    public class PermissionGrantCollection
    {
        [JsonProperty("value")]
        public PermissionGrant[] Value { get; set; }
    }

    public class PermissionGrant
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("consentType")]
        public string ConsentType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("principalId")]
        public string PrincipalId { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }

    public class PostPermissionGrantInput
    {
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("consentType")]
        public string ConsentType { get; set; }

        [JsonProperty("principalId")]
        public string PrincipalId { get; set; }

        [JsonProperty("resourceId")]
        public string ResourceId { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }

    public class UserFlowCollection
    {
        [JsonProperty("value")]
        public UserFlow[] Value { get; set; }
    }

    public class UserFlow
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("userFlowType")]
        public string UserFlowType { get; set; }

        [JsonProperty("userFlowTypeVersion")]
        public int UserFlowTypeVersion { get; set; }
    }

    public class PostUserflowInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("userFlowType")]
        public string UserFlowType { get; set; }

        [JsonProperty("userFlowTypeVersion")]
        public int? UserFlowTypeVersion { get; set; }
    }

    public class PostB2cUserflowInput
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("userFlowType")]
        public string UserFlowType { get; set; }

        [JsonProperty("userFlowTypeVersion", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? UserFlowTypeVersion { get; set; } = 1;

        [JsonProperty("tokenClaimsConfiguration")]
        public PostB2cUserflowInputTokenClaimsConfigurationType TokenClaimsConfiguration { get; set; }
    }

    public class PostB2cUserflowInputTokenClaimsConfigurationType
    {
        [JsonProperty("isIssuerEntityUserFlow", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsIssuerEntityUserFlow { get; set; } = true;
    }

    public class ServicePrincipleCollection
    {
        [JsonProperty("value")]
        public ServicePrinciple[] Value { get; set; }
    }

    public class ServicePrinciple
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deletedDateTime")]
        public string DeletedDateTime { get; set; }

        [JsonProperty("accountEnabled")]
        public bool AccountEnabled { get; set; }

        [JsonProperty("alternativeNames")]
        public JToken[] AlternativeNames { get; set; }

        [JsonProperty("appDescription")]
        public string AppDescription { get; set; }

        [JsonProperty("appDisplayName")]
        public string AppDisplayName { get; set; }

        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("applicationTemplateId")]
        public string ApplicationTemplateId { get; set; }

        [JsonProperty("appOwnerOrganizationId")]
        public string AppOwnerOrganizationId { get; set; }

        [JsonProperty("appRoleAssignmentRequired")]
        public bool AppRoleAssignmentRequired { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("errorUrl")]
        public string ErrorUrl { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("isAuthorizationServiceEnabled")]
        public bool IsAuthorizationServiceEnabled { get; set; }

        [JsonProperty("loginUrl")]
        public string LoginUrl { get; set; }

        [JsonProperty("logoutUrl")]
        public string LogoutUrl { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("notificationEmailAddresses")]
        public JToken[] NotificationEmailAddresses { get; set; }

        [JsonProperty("preferredSingleSignOnMode")]
        public string PreferredSingleSignOnMode { get; set; }

        [JsonProperty("preferredTokenSigningKeyEndDateTime")]
        public string PreferredTokenSigningKeyEndDateTime { get; set; }

        [JsonProperty("preferredTokenSigningKeyThumbprint")]
        public string PreferredTokenSigningKeyThumbprint { get; set; }

        [JsonProperty("publisherName")]
        public string PublisherName { get; set; }

        [JsonProperty("replyUrls")]
        public string[] ReplyUrls { get; set; }

        [JsonProperty("samlMetadataUrl")]
        public string SamlMetadataUrl { get; set; }

        [JsonProperty("samlSingleSignOnSettings")]
        public string SamlSingleSignOnSettings { get; set; }

        [JsonProperty("servicePrincipalNames")]
        public string[] ServicePrincipalNames { get; set; }

        [JsonProperty("servicePrincipalType")]
        public string ServicePrincipalType { get; set; }

        [JsonProperty("signInAudience")]
        public string SignInAudience { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("tokenEncryptionKeyId")]
        public string TokenEncryptionKeyId { get; set; }

        [JsonProperty("verifiedPublisher")]
        public ServicePrincipleVerifiedPublisherType VerifiedPublisher { get; set; }

        [JsonProperty("addIns")]
        public JToken[] AddIns { get; set; }

        [JsonProperty("api")]
        public ServicePrincipleApiType Api { get; set; }

        [JsonProperty("appRoles")]
        public JToken[] AppRoles { get; set; }

        [JsonProperty("info")]
        public ServicePrincipleInfoType Info { get; set; }

        [JsonProperty("keyCredentials")]
        public JToken[] KeyCredentials { get; set; }

        [JsonProperty("publishedPermissionScopes")]
        public JToken[] PublishedPermissionScopes { get; set; }

        [JsonProperty("passwordCredentials")]
        public JToken[] PasswordCredentials { get; set; }
    }

    public class ServicePrincipleVerifiedPublisherType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("verifiedPublisherId")]
        public string VerifiedPublisherId { get; set; }

        [JsonProperty("addedDateTime")]
        public string AddedDateTime { get; set; }
    }

    public class ServicePrincipleApiType
    {
        [JsonProperty("resourceSpecificApplicationPermissions")]
        public JToken[] ResourceSpecificApplicationPermissions { get; set; }
    }

    public class ServicePrincipleInfoType
    {
        [JsonProperty("termsOfServiceUrl")]
        public string TermsOfServiceUrl { get; set; }

        [JsonProperty("supportUrl")]
        public string SupportUrl { get; set; }

        [JsonProperty("privacyStatementUrl")]
        public string PrivacyStatementUrl { get; set; }

        [JsonProperty("marketingUrl")]
        public string MarketingUrl { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }
    }

    public class PostServicePrincipleV1Input
    {
        [JsonProperty("accountEnabled")]
        public bool? AccountEnabled { get; set; }

        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("appRoleAssignmentRequired")]
        public bool? AppRoleAssignmentRequired { get; set; }

        [JsonProperty("replyUrls")]
        public string[] ReplyUrls { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.B2cidpconfiguration;

    public partial class WorkflowManagedActions
    {
        public B2cidpconfigurationActions B2cidpconfiguration(string connectionId) => new B2cidpconfigurationActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public B2cidpconfigurationTriggers B2cidpconfiguration(string connectionId) => new B2cidpconfigurationTriggers(connectionId);
    }
}