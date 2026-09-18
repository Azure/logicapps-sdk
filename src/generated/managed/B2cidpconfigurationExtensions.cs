//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.B2cidpconfiguration
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class B2cidpconfigurationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<ApplicationCollection> GetApplications()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/applications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ApplicationCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<Application> PostApplication([WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<bool> bodyisFallbackPublicClient = null, [WorkflowExpression] Func<string[]> bodywebredirectUris = null, [WorkflowExpression] Func<bool> bodywebimplicitGrantSettingsenableIdTokenIssuance = null, [WorkflowExpression] Func<bool> bodywebimplicitGrantSettingsenableAccessTokenIssuance = null)
        {
            SourceExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: false);
            SourceExpression.Validate(bodyisFallbackPublicClient, nameof(bodyisFallbackPublicClient), required: false);
            SourceExpression.Validate(bodywebredirectUris, nameof(bodywebredirectUris), required: false);
            SourceExpression.Validate(bodywebimplicitGrantSettingsenableIdTokenIssuance, nameof(bodywebimplicitGrantSettingsenableIdTokenIssuance), required: false);
            SourceExpression.Validate(bodywebimplicitGrantSettingsenableAccessTokenIssuance, nameof(bodywebimplicitGrantSettingsenableAccessTokenIssuance), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/applications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                if (bodyisFallbackPublicClient != null)
                {
                    body["isFallbackPublicClient"] = SourceExpressionConverter.ConvertToken(bodyisFallbackPublicClient);
                    bodypropCount++;
                }

                var webObject = new JObject();
                var webObjectpropCount = 0;
                if (bodywebredirectUris != null)
                {
                    webObject["redirectUris"] = SourceExpressionConverter.ConvertToken(bodywebredirectUris);
                    webObjectpropCount++;
                }

                var implicitGrantSettingsObject = new JObject();
                var implicitGrantSettingsObjectpropCount = 0;
                if (bodywebimplicitGrantSettingsenableIdTokenIssuance != null)
                {
                    implicitGrantSettingsObject["enableIdTokenIssuance"] = SourceExpressionConverter.ConvertToken(bodywebimplicitGrantSettingsenableIdTokenIssuance);
                    implicitGrantSettingsObjectpropCount++;
                }

                if (bodywebimplicitGrantSettingsenableAccessTokenIssuance != null)
                {
                    implicitGrantSettingsObject["enableAccessTokenIssuance"] = SourceExpressionConverter.ConvertToken(bodywebimplicitGrantSettingsenableAccessTokenIssuance);
                    implicitGrantSettingsObjectpropCount++;
                }

                if (implicitGrantSettingsObjectpropCount > 0)
                {
                    webObject["implicitGrantSettings"] = implicitGrantSettingsObject;
                    webObjectpropCount++;
                }

                if (webObjectpropCount > 0)
                {
                    body["web"] = webObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Application>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IWorkflowAction PatchApplication([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/applications/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IWorkflowAction Me()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<PermissionGrantCollection> GetPermissionGrants()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/oauth2PermissionGrants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PermissionGrantCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<PermissionGrant> PostPermissionGrant([WorkflowExpression] Func<string> bodyclientId = null, [WorkflowExpression] Func<string> bodyconsentType = null, [WorkflowExpression] Func<string> bodyprincipalId = null, [WorkflowExpression] Func<string> bodyresourceId = null, [WorkflowExpression] Func<string> bodyscope = null)
        {
            SourceExpression.Validate(bodyclientId, nameof(bodyclientId), required: false);
            SourceExpression.Validate(bodyconsentType, nameof(bodyconsentType), required: false);
            SourceExpression.Validate(bodyprincipalId, nameof(bodyprincipalId), required: false);
            SourceExpression.Validate(bodyresourceId, nameof(bodyresourceId), required: false);
            SourceExpression.Validate(bodyscope, nameof(bodyscope), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/oauth2PermissionGrants";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyclientId != null)
                {
                    body["clientId"] = SourceExpressionConverter.ConvertToken(bodyclientId);
                    bodypropCount++;
                }

                if (bodyconsentType != null)
                {
                    body["consentType"] = SourceExpressionConverter.ConvertToken(bodyconsentType);
                    bodypropCount++;
                }

                if (bodyprincipalId != null)
                {
                    body["principalId"] = SourceExpressionConverter.ConvertToken(bodyprincipalId);
                    bodypropCount++;
                }

                if (bodyresourceId != null)
                {
                    body["resourceId"] = SourceExpressionConverter.ConvertToken(bodyresourceId);
                    bodypropCount++;
                }

                if (bodyscope != null)
                {
                    body["scope"] = SourceExpressionConverter.ConvertToken(bodyscope);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PermissionGrant>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<UserFlowCollection> GetUserflows()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/identity/userFlows";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserFlowCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<UserFlow> PostUserflow([WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyuserFlowType = null, [WorkflowExpression] Func<int> bodyuserFlowTypeVersion = null)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyuserFlowType, nameof(bodyuserFlowType), required: false);
            SourceExpression.Validate(bodyuserFlowTypeVersion, nameof(bodyuserFlowTypeVersion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/identity/userFlows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyuserFlowType != null)
                {
                    body["userFlowType"] = SourceExpressionConverter.ConvertToken(bodyuserFlowType);
                    bodypropCount++;
                }

                if (bodyuserFlowTypeVersion != null)
                {
                    body["userFlowTypeVersion"] = SourceExpressionConverter.ConvertToken(bodyuserFlowTypeVersion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserFlow>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<UserFlowCollection> GetB2cuserflows()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/identity/b2cUserflows";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserFlowCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<UserFlow> PostB2cUserflow([WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyuserFlowType = null, [WorkflowExpression] Func<int> bodyuserFlowTypeVersion = null, [WorkflowExpression] Func<bool> bodytokenClaimsConfigurationisIssuerEntityUserFlow = null)
        {
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyuserFlowType, nameof(bodyuserFlowType), required: false);
            SourceExpression.Validate(bodyuserFlowTypeVersion, nameof(bodyuserFlowTypeVersion), required: false);
            SourceExpression.Validate(bodytokenClaimsConfigurationisIssuerEntityUserFlow, nameof(bodytokenClaimsConfigurationisIssuerEntityUserFlow), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/beta/identity/b2cUserflows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyuserFlowType != null)
                {
                    body["userFlowType"] = SourceExpressionConverter.ConvertToken(bodyuserFlowType);
                    bodypropCount++;
                }

                if (bodyuserFlowTypeVersion != null)
                {
                    if (bodyuserFlowTypeVersion != null)
                    {
                        body["userFlowTypeVersion"] = SourceExpressionConverter.ConvertToken(bodyuserFlowTypeVersion);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["userFlowTypeVersion"] = 1;
                    bodypropCount++;
                }

                var tokenClaimsConfigurationObject = new JObject();
                var tokenClaimsConfigurationObjectpropCount = 0;
                if (bodytokenClaimsConfigurationisIssuerEntityUserFlow != null)
                {
                    if (bodytokenClaimsConfigurationisIssuerEntityUserFlow != null)
                    {
                        tokenClaimsConfigurationObject["isIssuerEntityUserFlow"] = SourceExpressionConverter.ConvertToken(bodytokenClaimsConfigurationisIssuerEntityUserFlow);
                        tokenClaimsConfigurationObjectpropCount++;
                    }

                    tokenClaimsConfigurationObjectpropCount++;
                }
                else
                {
                    tokenClaimsConfigurationObject["isIssuerEntityUserFlow"] = true;
                    tokenClaimsConfigurationObjectpropCount++;
                }

                if (tokenClaimsConfigurationObjectpropCount > 0)
                {
                    body["tokenClaimsConfiguration"] = tokenClaimsConfigurationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserFlow>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<ServicePrincipleCollection> GetServicePrinciple()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/serviceprincipals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ServicePrincipleCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<ServicePrinciple> PostServicePrinciple([WorkflowExpression] Func<bool> bodyaccountEnabled = null, [WorkflowExpression] Func<string> bodyappId = null, [WorkflowExpression] Func<bool> bodyappRoleAssignmentRequired = null, [WorkflowExpression] Func<string[]> bodyreplyUrls = null)
        {
            SourceExpression.Validate(bodyaccountEnabled, nameof(bodyaccountEnabled), required: false);
            SourceExpression.Validate(bodyappId, nameof(bodyappId), required: false);
            SourceExpression.Validate(bodyappRoleAssignmentRequired, nameof(bodyappRoleAssignmentRequired), required: false);
            SourceExpression.Validate(bodyreplyUrls, nameof(bodyreplyUrls), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1.0/serviceprincipals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccountEnabled != null)
                {
                    body["accountEnabled"] = SourceExpressionConverter.ConvertToken(bodyaccountEnabled);
                    bodypropCount++;
                }

                if (bodyappId != null)
                {
                    body["appId"] = SourceExpressionConverter.ConvertToken(bodyappId);
                    bodypropCount++;
                }

                if (bodyappRoleAssignmentRequired != null)
                {
                    body["appRoleAssignmentRequired"] = SourceExpressionConverter.ConvertToken(bodyappRoleAssignmentRequired);
                    bodypropCount++;
                }

                if (bodyreplyUrls != null)
                {
                    body["replyUrls"] = SourceExpressionConverter.ConvertToken(bodyreplyUrls);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ServicePrinciple>(BuildSourceInput);
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