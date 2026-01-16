//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Azureadapplications
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AzureadapplicationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureadapplications")]
        public IBodyWorkflowAction<ApplicationListDefinition> ListApplications(Expression<Func<string>> select = null, Expression<Func<string>> search = null, Expression<Func<string>> filter = null, Expression<Func<countInput>> count = null, Expression<Func<string>> expand = null, Expression<Func<int>> top = null)
        {
            var apiCallPath = "/v1.0/applications";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (search != null)
                callPayload.Queries["$search"] = ExpressionConverter.Convert(search);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            callPayload.Queries["$count"] = Convert.ToString("true");
            if (count != null)
                callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
            callPayload.Queries["$expand"] = Convert.ToString("Owners");
            if (expand != null)
                callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<ApplicationListDefinition>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureadapplications")]
        public IBodyWorkflowAction<ApplicationDefinition> GetApplication(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1.0/applications/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ApplicationDefinition>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "azureadapplications")]
        public IBodyWorkflowAction<ApplicationOwnersDefinition> GetAppOwners(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v1.0/applications/{0}/owners", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ApplicationOwnersDefinition>(callPayload);
        }
    }

    public class AzureadapplicationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ApplicationListDefinition
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("value")]
        public ApplicationDefinition[] Value { get; set; }
    }

    public class ApplicationDefinition
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deletedDateTime")]
        public string DeletedDateTime { get; set; }

        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("applicationTemplateId")]
        public string ApplicationTemplateId { get; set; }

        [JsonProperty("disabledByMicrosoftStatus")]
        public string DisabledByMicrosoftStatus { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("groupMembershipClaims")]
        public string GroupMembershipClaims { get; set; }

        [JsonProperty("identifierUris")]
        public string[] IdentifierUris { get; set; }

        [JsonProperty("isDeviceOnlyAuthSupported")]
        public JToken IsDeviceOnlyAuthSupported { get; set; }

        [JsonProperty("isFallbackPublicClient")]
        public bool IsFallbackPublicClient { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("optionalClaims")]
        public JToken OptionalClaims { get; set; }

        [JsonProperty("publisherDomain")]
        public string PublisherDomain { get; set; }

        [JsonProperty("signInAudience")]
        public string SignInAudience { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("tokenEncryptionKeyId")]
        public string TokenEncryptionKeyId { get; set; }

        [JsonProperty("verifiedPublisher")]
        public ApplicationDefinitionVerifiedPublisherType VerifiedPublisher { get; set; }

        [JsonProperty("defaultRedirectUri")]
        public string DefaultRedirectUri { get; set; }

        [JsonProperty("addIns")]
        public ApplicationDefinitionAddInsTypeItem[] AddIns { get; set; }

        [JsonProperty("api")]
        public ApplicationDefinitionApiType Api { get; set; }

        [JsonProperty("appRoles")]
        public JToken[] AppRoles { get; set; }

        [JsonProperty("info")]
        public ApplicationDefinitionInfoType Info { get; set; }

        [JsonProperty("keyCredentials")]
        public JToken[] KeyCredentials { get; set; }

        [JsonProperty("parentalControlSettings")]
        public ApplicationDefinitionParentalControlSettingsType ParentalControlSettings { get; set; }

        [JsonProperty("passwordCredentials")]
        public ApplicationDefinitionPasswordCredentialsTypeItem[] PasswordCredentials { get; set; }

        [JsonProperty("publicClient")]
        public ApplicationDefinitionPublicClientType PublicClient { get; set; }

        [JsonProperty("requiredResourceAccess")]
        public ApplicationDefinitionRequiredResourceAccessTypeItem[] RequiredResourceAccess { get; set; }

        [JsonProperty("web")]
        public ApplicationDefinitionWebType Web { get; set; }

        [JsonProperty("spa")]
        public ApplicationDefinitionSpaType Spa { get; set; }
    }

    public class ApplicationDefinitionVerifiedPublisherType
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("verifiedPublisherId")]
        public string VerifiedPublisherId { get; set; }

        [JsonProperty("addedDateTime")]
        public string AddedDateTime { get; set; }
    }

    public class ApplicationDefinitionAddInsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public ApplicationDefinitionAddInsTypeItemPropertiesTypeItem[] Properties { get; set; }
    }

    public class ApplicationDefinitionAddInsTypeItemPropertiesTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ApplicationDefinitionApiType
    {
        [JsonProperty("acceptMappedClaims")]
        public bool AcceptMappedClaims { get; set; }

        [JsonProperty("knownClientApplications")]
        public JToken[] KnownClientApplications { get; set; }

        [JsonProperty("requestedAccessTokenVersion")]
        public JToken RequestedAccessTokenVersion { get; set; }

        [JsonProperty("oauth2PermissionScopes")]
        public ApplicationDefinitionApiTypeOauth2PermissionScopesTypeItem[] Oauth2PermissionScopes { get; set; }

        [JsonProperty("preAuthorizedApplications")]
        public JToken[] PreAuthorizedApplications { get; set; }
    }

    public class ApplicationDefinitionApiTypeOauth2PermissionScopesTypeItem
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

    public class ApplicationDefinitionInfoType
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

    public class ApplicationDefinitionParentalControlSettingsType
    {
        [JsonProperty("countriesBlockedForMinors")]
        public JToken[] CountriesBlockedForMinors { get; set; }

        [JsonProperty("legalAgeGroupRule")]
        public string LegalAgeGroupRule { get; set; }
    }

    public class ApplicationDefinitionPasswordCredentialsTypeItem
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("endDateTime")]
        public string EndDateTime { get; set; }

        [JsonProperty("hint")]
        public string Hint { get; set; }

        [JsonProperty("keyId")]
        public string KeyId { get; set; }

        [JsonProperty("startDateTime")]
        public string StartDateTime { get; set; }
    }

    public class ApplicationDefinitionPublicClientType
    {
        [JsonProperty("redirectUris")]
        public JToken[] RedirectUris { get; set; }
    }

    public class ApplicationDefinitionRequiredResourceAccessTypeItem
    {
        [JsonProperty("resourceAppId")]
        public string ResourceAppId { get; set; }

        [JsonProperty("resourceAccess")]
        public ApplicationDefinitionRequiredResourceAccessTypeItemResourceAccessTypeItem[] ResourceAccess { get; set; }
    }

    public class ApplicationDefinitionRequiredResourceAccessTypeItemResourceAccessTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ApplicationDefinitionWebType
    {
        [JsonProperty("homePageUrl")]
        public string HomePageUrl { get; set; }

        [JsonProperty("logoutUrl")]
        public string LogoutUrl { get; set; }

        [JsonProperty("redirectUris")]
        public string[] RedirectUris { get; set; }

        [JsonProperty("implicitGrantSettings")]
        public ApplicationDefinitionWebTypeImplicitGrantSettingsType ImplicitGrantSettings { get; set; }
    }

    public class ApplicationDefinitionWebTypeImplicitGrantSettingsType
    {
        [JsonProperty("enableAccessTokenIssuance")]
        public bool EnableAccessTokenIssuance { get; set; }

        [JsonProperty("enableIdTokenIssuance")]
        public bool EnableIdTokenIssuance { get; set; }
    }

    public class ApplicationDefinitionSpaType
    {
        [JsonProperty("redirectUris")]
        public JToken[] RedirectUris { get; set; }
    }

    public enum countInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class ApplicationOwnersDefinition
    {
        [JsonProperty("value")]
        public ApplicationOwnersDefinitionValueTypeItem[] Value { get; set; }
    }

    public class ApplicationOwnersDefinitionValueTypeItem
    {
        [JsonProperty("@odata.type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("businessPhones")]
        public JToken[] BusinessPhones { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureadapplications;

    public partial class WorkflowManagedActions
    {
        public AzureadapplicationsActions Azureadapplications(string connectionId) => new AzureadapplicationsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AzureadapplicationsTriggers Azureadapplications(string connectionId) => new AzureadapplicationsTriggers(connectionId);
    }
}