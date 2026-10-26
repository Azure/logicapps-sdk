//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tophhiecloud
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TophhiecloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tophhiecloud")]
        public IBodyWorkflowAction<TophhieCloudTenantInfoResponse, ApiConnectionActionConfiguration> TophhieCloudTenantInfo(Expression<Func<string>> tenantId = null, Expression<Func<string>> domainName = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: false);
            var __workflow_domainName = WorkflowExpression.Compile(domainName, nameof(domainName), required: false);
            return new DeferredBodyAction<TophhieCloudTenantInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tenantinfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tenantId != null)
                    callPayload.Queries["tenantID"] = ExpressionConverter.Convert(__workflow_tenantId);
                if (__workflow_domainName != null)
                    callPayload.Queries["domainName"] = ExpressionConverter.Convert(__workflow_domainName);
                return new ApiConnectionAction<TophhieCloudTenantInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tophhiecloud")]
        public IBodyWorkflowAction<TophhieCloudEntraIdIdConverterResponse, ApiConnectionActionConfiguration> TophhieCloudEntraIdIdConverter(Expression<Func<string>> identifier)
        {
            var __workflow_identifier = WorkflowExpression.Compile(identifier, nameof(identifier), required: true);
            return new DeferredBodyAction<TophhieCloudEntraIdIdConverterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/entra/convertid/{0}", __workflow_identifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TophhieCloudEntraIdIdConverterResponse>(callPayload);
            });
        }
    }

    public class TophhiecloudTriggers([ConnectionName] string connectionId)
    {
    }

    public class TophhieCloudTenantInfoResponse
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("federationBrandName")]
        public string FederationBrandName { get; set; }

        [JsonProperty("tenantDisplayName")]
        public string TenantDisplayName { get; set; }

        [JsonProperty("defaultDomainName")]
        public string DefaultDomainName { get; set; }

        [JsonProperty("bannerLogo")]
        public string BannerLogo { get; set; }

        [JsonProperty("tenantRegion")]
        public string TenantRegion { get; set; }

        [JsonProperty("desktopSsoEnabled")]
        public bool DesktopSsoEnabled { get; set; }

        [JsonProperty("verifiedEmailSignUpDisallowed")]
        public bool VerifiedEmailSignUpDisallowed { get; set; }

        [JsonProperty("tenantIsUnmanaged")]
        public bool TenantIsUnmanaged { get; set; }

        [JsonProperty("verifiedDomains")]
        public int VerifiedDomains { get; set; }

        [JsonProperty("additionalDomains")]
        public string[] AdditionalDomains { get; set; }
    }

    public class TophhieCloudEntraIdIdConverterResponse
    {
        [JsonProperty("originalId")]
        public string OriginalId { get; set; }

        [JsonProperty("returnId")]
        public string ReturnId { get; set; }

        [JsonProperty("convertDirection")]
        public string ConvertDirection { get; set; }

        [JsonProperty("support")]
        public TophhieCloudEntraIdIdConverterResponseSupportType Support { get; set; }
    }

    public class TophhieCloudEntraIdIdConverterResponseSupportType
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tophhiecloud;

    public partial class WorkflowManagedActions
    {
        public TophhiecloudActions Tophhiecloud(string connectionId) => new TophhiecloudActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TophhiecloudTriggers Tophhiecloud(string connectionId) => new TophhiecloudTriggers(connectionId);
    }
}