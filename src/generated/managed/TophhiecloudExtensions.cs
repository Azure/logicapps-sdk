//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tophhiecloud
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TophhiecloudActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tophhiecloud")]
        [WorkflowExpressionFactory(nameof(__BuildTophhieCloudTenantInfo))]
        public IBodyWorkflowAction<TophhieCloudTenantInfoResponse> TophhieCloudTenantInfo([WorkflowExpression] Func<string> tenantID = null, [WorkflowExpression] Func<string> domainName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tophhiecloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TophhieCloudTenantInfoResponse> __BuildTophhieCloudTenantInfo(WorkflowExpression<string> tenantID = null, WorkflowExpression<string> domainName = null)
        {
            WorkflowExpression.Validate(tenantID, nameof(tenantID), required: false);
            WorkflowExpression.Validate(domainName, nameof(domainName), required: false);
            return new DeferredBodyAction<TophhieCloudTenantInfoResponse>(() =>
            {
                var apiCallPath = "/tenantinfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (tenantID != null)
                    callPayload.Queries["tenantID"] = ExpressionConverter.Convert(tenantID);
                if (domainName != null)
                    callPayload.Queries["domainName"] = ExpressionConverter.Convert(domainName);
                return new ApiConnectionAction<TophhieCloudTenantInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tophhiecloud")]
        [WorkflowExpressionFactory(nameof(__BuildTophhieCloudEntraIDIDConverter))]
        public IBodyWorkflowAction<TophhieCloudEntraIDIDConverterResponse> TophhieCloudEntraIDIDConverter([WorkflowExpression] Func<string> identifier)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tophhiecloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TophhieCloudEntraIDIDConverterResponse> __BuildTophhieCloudEntraIDIDConverter(WorkflowExpression<string> identifier)
        {
            WorkflowExpression.Validate(identifier, nameof(identifier), required: true);
            return new DeferredBodyAction<TophhieCloudEntraIDIDConverterResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/entra/convertid/{0}", ExpressionConverter.ConvertWithUrlEncoding(identifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TophhieCloudEntraIDIDConverterResponse>(callPayload);
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

    public class TophhieCloudEntraIDIDConverterResponse
    {
        [JsonProperty("originalId")]
        public string OriginalId { get; set; }

        [JsonProperty("returnId")]
        public string ReturnId { get; set; }

        [JsonProperty("convertDirection")]
        public string ConvertDirection { get; set; }

        [JsonProperty("support")]
        public TophhieCloudEntraIDIDConverterResponseSupportType Support { get; set; }
    }

    public class TophhieCloudEntraIDIDConverterResponseSupportType
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