//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ifactoproofofdeliver
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IfactoproofofdeliverActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ifactoproofofdeliver")]
        public IBodyWorkflowAction<ListEnvironmentResponse> ListEnvironment()
        {
            var apiCallPath = "/environments/v1.0";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListEnvironmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ifactoproofofdeliver")]
        [WorkflowExpressionFactory(nameof(__BuildListCompany))]
        public IBodyWorkflowAction<ListCompanyResponse> ListCompany([WorkflowExpression] Func<string> bcenvironment)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListCompanyResponse> __BuildListCompany(WorkflowValue<string> bcenvironment)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            return new DeferredBodyAction<ListCompanyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2.0/{0}/api/v2.0/companies", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListCompanyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ifactoproofofdeliver")]
        [WorkflowExpressionFactory(nameof(__BuildGetCompany))]
        public IBodyWorkflowAction<GetCompanyResponse> GetCompany([WorkflowExpression] Func<string> bcenvironment, [WorkflowExpression] Func<string> company)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCompanyResponse> __BuildGetCompany(WorkflowValue<string> bcenvironment, WorkflowValue<string> company)
        {
            WorkflowValue.Validate(bcenvironment, nameof(bcenvironment), required: true);
            WorkflowValue.Validate(company, nameof(company), required: true);
            return new DeferredBodyAction<GetCompanyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2.0/{0}/api/v2.0/companies({1})", ExpressionConverter.ConvertWithUrlEncoding(bcenvironment, 1), ExpressionConverter.ConvertWithUrlEncoding(company, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCompanyResponse>(callPayload);
            });
        }
    }

    public class IfactoproofofdeliverTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListEnvironmentResponse
    {
        [JsonProperty("value")]
        public ListEnvironmentResponseValueTypeItem[] Value { get; set; }
    }

    public class ListEnvironmentResponseValueTypeItem
    {
        [JsonProperty("aadTenantId")]
        public string AadTenantId { get; set; }

        [JsonProperty("applicationFamily")]
        public string ApplicationFamily { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("webServiceUrl")]
        public string WebServiceUrl { get; set; }

        [JsonProperty("webClientLoginUrl")]
        public string WebClientLoginUrl { get; set; }
    }

    public class ListCompanyResponse
    {
        [JsonProperty("value")]
        public ListCompanyResponseValueTypeItem[] Value { get; set; }
    }

    public class ListCompanyResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("systemVersion")]
        public string SystemVersion { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("businessProfileId")]
        public string BusinessProfileId { get; set; }

        [JsonProperty("systemCreatedAt")]
        public string SystemCreatedAt { get; set; }

        [JsonProperty("systemCreatedBy")]
        public string SystemCreatedBy { get; set; }

        [JsonProperty("systemModifiedAt")]
        public string SystemModifiedAt { get; set; }

        [JsonProperty("systemModifiedBy")]
        public string SystemModifiedBy { get; set; }
    }

    public class GetCompanyResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("systemVersion")]
        public string SystemVersion { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("businessProfileId")]
        public string BusinessProfileId { get; set; }

        [JsonProperty("systemCreatedAt")]
        public string SystemCreatedAt { get; set; }

        [JsonProperty("systemCreatedBy")]
        public string SystemCreatedBy { get; set; }

        [JsonProperty("systemModifiedAt")]
        public string SystemModifiedAt { get; set; }

        [JsonProperty("systemModifiedBy")]
        public string SystemModifiedBy { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ifactoproofofdeliver;

    public partial class WorkflowManagedActions
    {
        public IfactoproofofdeliverActions Ifactoproofofdeliver(string connectionId) => new IfactoproofofdeliverActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IfactoproofofdeliverTriggers Ifactoproofofdeliver(string connectionId) => new IfactoproofofdeliverTriggers(connectionId);
    }
}
