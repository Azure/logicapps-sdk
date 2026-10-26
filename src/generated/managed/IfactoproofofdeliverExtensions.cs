//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ifactoproofofdeliver
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IfactoproofofdeliverActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ifactoproofofdeliver")]
        public IBodyWorkflowAction<ListEnvironmentResponse, ApiConnectionActionConfiguration> ListEnvironment()
        {
            return new DeferredBodyAction<ListEnvironmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/environments/v1.0";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListEnvironmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ifactoproofofdeliver")]
        public IBodyWorkflowAction<ListCompanyResponse, ApiConnectionActionConfiguration> ListCompany(Expression<Func<string>> bcenvironment)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            return new DeferredBodyAction<ListCompanyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2.0/{0}/api/v2.0/companies", __workflow_bcenvironment.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListCompanyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ifactoproofofdeliver")]
        public IBodyWorkflowAction<GetCompanyResponse, ApiConnectionActionConfiguration> GetCompany(Expression<Func<string>> bcenvironment, Expression<Func<string>> company)
        {
            var __workflow_bcenvironment = WorkflowExpression.Compile(bcenvironment, nameof(bcenvironment), required: true);
            var __workflow_company = WorkflowExpression.Compile(company, nameof(company), required: true);
            return new DeferredBodyAction<GetCompanyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2.0/{0}/api/v2.0/companies({1})", __workflow_bcenvironment.WithUrlEncoding(1), __workflow_company.WithUrlEncoding(1)));
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