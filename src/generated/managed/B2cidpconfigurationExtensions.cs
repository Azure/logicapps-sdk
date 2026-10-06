//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.B2cidpconfiguration
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class B2cidpconfigurationActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<ApplicationCollection> GetApplications()
        {
            var apiCallPath = "/v1.0/applications";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ApplicationCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        [WorkflowExpressionFactory(nameof(__BuildPostApplication))]
        public IBodyWorkflowAction<Application> PostApplication([WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<bool> bodyisFallbackPublicClient = null, [WorkflowExpression] Func<string[]> bodywebredirectUris = null, [WorkflowExpression] Func<bool> bodywebimplicitGrantSettingsenableIdTokenIssuance = null, [WorkflowExpression] Func<bool> bodywebimplicitGrantSettingsenableAccessTokenIssuance = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Application> __BuildPostApplication(WorkflowExpression<string> bodydisplayName = null, WorkflowExpression<bool> bodyisFallbackPublicClient = null, WorkflowExpression<string[]> bodywebredirectUris = null, WorkflowExpression<bool> bodywebimplicitGrantSettingsenableIdTokenIssuance = null, WorkflowExpression<bool> bodywebimplicitGrantSettingsenableAccessTokenIssuance = null)
        {
            WorkflowExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: false);
            WorkflowExpression.Validate(bodyisFallbackPublicClient, nameof(bodyisFallbackPublicClient), required: false);
            WorkflowExpression.Validate(bodywebredirectUris, nameof(bodywebredirectUris), required: false);
            WorkflowExpression.Validate(bodywebimplicitGrantSettingsenableIdTokenIssuance, nameof(bodywebimplicitGrantSettingsenableIdTokenIssuance), required: false);
            WorkflowExpression.Validate(bodywebimplicitGrantSettingsenableAccessTokenIssuance, nameof(bodywebimplicitGrantSettingsenableAccessTokenIssuance), required: false);
            return new DeferredBodyAction<Application>(() =>
            {
                var apiCallPath = "/v1.0/applications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydisplayName != null)
                {
                    body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                    bodypropCount++;
                }

                if (bodyisFallbackPublicClient != null)
                {
                    body["isFallbackPublicClient"] = ExpressionConverter.ConvertO(bodyisFallbackPublicClient);
                    bodypropCount++;
                }

                var webObject = new JObject();
                var webObjectpropCount = 0;
                if (bodywebredirectUris != null)
                {
                    webObject["redirectUris"] = ExpressionConverter.ConvertO(bodywebredirectUris);
                    webObjectpropCount++;
                }

                var implicitGrantSettingsObject = new JObject();
                var implicitGrantSettingsObjectpropCount = 0;
                if (bodywebimplicitGrantSettingsenableIdTokenIssuance != null)
                {
                    implicitGrantSettingsObject["enableIdTokenIssuance"] = ExpressionConverter.ConvertO(bodywebimplicitGrantSettingsenableIdTokenIssuance);
                    implicitGrantSettingsObjectpropCount++;
                }

                if (bodywebimplicitGrantSettingsenableAccessTokenIssuance != null)
                {
                    implicitGrantSettingsObject["enableAccessTokenIssuance"] = ExpressionConverter.ConvertO(bodywebimplicitGrantSettingsenableAccessTokenIssuance);
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

                return new ApiConnectionAction<Application>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        [WorkflowExpressionFactory(nameof(__BuildPatchApplication))]
        public IWorkflowAction PatchApplication([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPatchApplication(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/applications/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IWorkflowAction Me()
        {
            var apiCallPath = "/v1.0/me";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<PermissionGrantCollection> GetPermissionGrants()
        {
            var apiCallPath = "/v1.0/oauth2PermissionGrants";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PermissionGrantCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        [WorkflowExpressionFactory(nameof(__BuildPostPermissionGrant))]
        public IBodyWorkflowAction<PermissionGrant> PostPermissionGrant([WorkflowExpression] Func<string> bodyclientId = null, [WorkflowExpression] Func<string> bodyconsentType = null, [WorkflowExpression] Func<string> bodyprincipalId = null, [WorkflowExpression] Func<string> bodyresourceId = null, [WorkflowExpression] Func<string> bodyscope = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PermissionGrant> __BuildPostPermissionGrant(WorkflowExpression<string> bodyclientId = null, WorkflowExpression<string> bodyconsentType = null, WorkflowExpression<string> bodyprincipalId = null, WorkflowExpression<string> bodyresourceId = null, WorkflowExpression<string> bodyscope = null)
        {
            WorkflowExpression.Validate(bodyclientId, nameof(bodyclientId), required: false);
            WorkflowExpression.Validate(bodyconsentType, nameof(bodyconsentType), required: false);
            WorkflowExpression.Validate(bodyprincipalId, nameof(bodyprincipalId), required: false);
            WorkflowExpression.Validate(bodyresourceId, nameof(bodyresourceId), required: false);
            WorkflowExpression.Validate(bodyscope, nameof(bodyscope), required: false);
            return new DeferredBodyAction<PermissionGrant>(() =>
            {
                var apiCallPath = "/v1.0/oauth2PermissionGrants";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyclientId != null)
                {
                    body["clientId"] = ExpressionConverter.ConvertO(bodyclientId);
                    bodypropCount++;
                }

                if (bodyconsentType != null)
                {
                    body["consentType"] = ExpressionConverter.ConvertO(bodyconsentType);
                    bodypropCount++;
                }

                if (bodyprincipalId != null)
                {
                    body["principalId"] = ExpressionConverter.ConvertO(bodyprincipalId);
                    bodypropCount++;
                }

                if (bodyresourceId != null)
                {
                    body["resourceId"] = ExpressionConverter.ConvertO(bodyresourceId);
                    bodypropCount++;
                }

                if (bodyscope != null)
                {
                    body["scope"] = ExpressionConverter.ConvertO(bodyscope);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PermissionGrant>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<UserFlowCollection> GetUserflows()
        {
            var apiCallPath = "/beta/identity/userFlows";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserFlowCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        [WorkflowExpressionFactory(nameof(__BuildPostUserflow))]
        public IBodyWorkflowAction<UserFlow> PostUserflow([WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyuserFlowType = null, [WorkflowExpression] Func<int> bodyuserFlowTypeVersion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserFlow> __BuildPostUserflow(WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodyuserFlowType = null, WorkflowExpression<int> bodyuserFlowTypeVersion = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodyuserFlowType, nameof(bodyuserFlowType), required: false);
            WorkflowExpression.Validate(bodyuserFlowTypeVersion, nameof(bodyuserFlowTypeVersion), required: false);
            return new DeferredBodyAction<UserFlow>(() =>
            {
                var apiCallPath = "/beta/identity/userFlows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodyuserFlowType != null)
                {
                    body["userFlowType"] = ExpressionConverter.ConvertO(bodyuserFlowType);
                    bodypropCount++;
                }

                if (bodyuserFlowTypeVersion != null)
                {
                    body["userFlowTypeVersion"] = ExpressionConverter.ConvertO(bodyuserFlowTypeVersion);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UserFlow>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<UserFlowCollection> GetB2cuserflows()
        {
            var apiCallPath = "/beta/identity/b2cUserflows";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserFlowCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        [WorkflowExpressionFactory(nameof(__BuildPostB2cUserflow))]
        public IBodyWorkflowAction<UserFlow> PostB2cUserflow([WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyuserFlowType = null, [WorkflowExpression] Func<int> bodyuserFlowTypeVersion = null, [WorkflowExpression] Func<bool> bodytokenClaimsConfigurationisIssuerEntityUserFlow = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserFlow> __BuildPostB2cUserflow(WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodyuserFlowType = null, WorkflowExpression<int> bodyuserFlowTypeVersion = null, WorkflowExpression<bool> bodytokenClaimsConfigurationisIssuerEntityUserFlow = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodyuserFlowType, nameof(bodyuserFlowType), required: false);
            WorkflowExpression.Validate(bodyuserFlowTypeVersion, nameof(bodyuserFlowTypeVersion), required: false);
            WorkflowExpression.Validate(bodytokenClaimsConfigurationisIssuerEntityUserFlow, nameof(bodytokenClaimsConfigurationisIssuerEntityUserFlow), required: false);
            return new DeferredBodyAction<UserFlow>(() =>
            {
                var apiCallPath = "/beta/identity/b2cUserflows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodyuserFlowType != null)
                {
                    body["userFlowType"] = ExpressionConverter.ConvertO(bodyuserFlowType);
                    bodypropCount++;
                }

                if (bodyuserFlowTypeVersion != null)
                {
                    if (bodyuserFlowTypeVersion != null)
                    {
                        body["userFlowTypeVersion"] = ExpressionConverter.ConvertO(bodyuserFlowTypeVersion);
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
                        tokenClaimsConfigurationObject["isIssuerEntityUserFlow"] = ExpressionConverter.ConvertO(bodytokenClaimsConfigurationisIssuerEntityUserFlow);
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

                return new ApiConnectionAction<UserFlow>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        public IBodyWorkflowAction<ServicePrincipleCollection> GetServicePrinciple()
        {
            var apiCallPath = "/v1.0/serviceprincipals";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ServicePrincipleCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        [WorkflowExpressionFactory(nameof(__BuildPostServicePrinciple))]
        public IBodyWorkflowAction<ServicePrinciple> PostServicePrinciple([WorkflowExpression] Func<bool> bodyaccountEnabled = null, [WorkflowExpression] Func<string> bodyappId = null, [WorkflowExpression] Func<bool> bodyappRoleAssignmentRequired = null, [WorkflowExpression] Func<string[]> bodyreplyUrls = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "b2cidpconfiguration")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ServicePrinciple> __BuildPostServicePrinciple(WorkflowExpression<bool> bodyaccountEnabled = null, WorkflowExpression<string> bodyappId = null, WorkflowExpression<bool> bodyappRoleAssignmentRequired = null, WorkflowExpression<string[]> bodyreplyUrls = null)
        {
            WorkflowExpression.Validate(bodyaccountEnabled, nameof(bodyaccountEnabled), required: false);
            WorkflowExpression.Validate(bodyappId, nameof(bodyappId), required: false);
            WorkflowExpression.Validate(bodyappRoleAssignmentRequired, nameof(bodyappRoleAssignmentRequired), required: false);
            WorkflowExpression.Validate(bodyreplyUrls, nameof(bodyreplyUrls), required: false);
            return new DeferredBodyAction<ServicePrinciple>(() =>
            {
                var apiCallPath = "/v1.0/serviceprincipals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaccountEnabled != null)
                {
                    body["accountEnabled"] = ExpressionConverter.ConvertO(bodyaccountEnabled);
                    bodypropCount++;
                }

                if (bodyappId != null)
                {
                    body["appId"] = ExpressionConverter.ConvertO(bodyappId);
                    bodypropCount++;
                }

                if (bodyappRoleAssignmentRequired != null)
                {
                    body["appRoleAssignmentRequired"] = ExpressionConverter.ConvertO(bodyappRoleAssignmentRequired);
                    bodypropCount++;
                }

                if (bodyreplyUrls != null)
                {
                    body["replyUrls"] = ExpressionConverter.ConvertO(bodyreplyUrls);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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