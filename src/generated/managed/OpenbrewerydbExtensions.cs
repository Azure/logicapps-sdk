//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openbrewerydb
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenbrewerydbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        public IBodyWorkflowAction<RefBrewery> GetBrewery(Expression<Func<string>> obdbId)
        {
            var __workflow_obdbId = WorkflowExpression.Compile(obdbId, nameof(obdbId), required: true);
            return new DeferredBodyAction<RefBrewery>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/breweries/{0}", __workflow_obdbId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RefBrewery>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        public IBodyWorkflowAction<RefBrewery[]> ListBreweries(Expression<Func<string>> byCity = null, Expression<Func<string>> byCountry = null, Expression<Func<string>> byDist = null, Expression<Func<string>> byName = null, Expression<Func<string>> byState = null, Expression<Func<string>> byPostal = null, Expression<Func<byTypeInput>> byType = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_byCity = WorkflowExpression.Compile(byCity, nameof(byCity), required: false);
            var __workflow_byCountry = WorkflowExpression.Compile(byCountry, nameof(byCountry), required: false);
            var __workflow_byDist = WorkflowExpression.Compile(byDist, nameof(byDist), required: false);
            var __workflow_byName = WorkflowExpression.Compile(byName, nameof(byName), required: false);
            var __workflow_byState = WorkflowExpression.Compile(byState, nameof(byState), required: false);
            var __workflow_byPostal = WorkflowExpression.Compile(byPostal, nameof(byPostal), required: false);
            var __workflow_byType = WorkflowExpression.Compile(byType, nameof(byType), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<RefBrewery[]>(() =>
            {
                var apiCallPath = "/v1/breweries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_byCity != null)
                    callPayload.Queries["by_city"] = ExpressionConverter.Convert(__workflow_byCity);
                if (__workflow_byCountry != null)
                    callPayload.Queries["by_country"] = ExpressionConverter.Convert(__workflow_byCountry);
                if (__workflow_byDist != null)
                    callPayload.Queries["by_dist"] = ExpressionConverter.Convert(__workflow_byDist);
                if (__workflow_byName != null)
                    callPayload.Queries["by_name"] = ExpressionConverter.Convert(__workflow_byName);
                if (__workflow_byState != null)
                    callPayload.Queries["by_state"] = ExpressionConverter.Convert(__workflow_byState);
                if (__workflow_byPostal != null)
                    callPayload.Queries["by_postal"] = ExpressionConverter.Convert(__workflow_byPostal);
                if (__workflow_byType != null)
                    callPayload.Queries["by_type"] = ExpressionConverter.Convert(__workflow_byType);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<RefBrewery[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        public IBodyWorkflowAction<RefBrewery[]> GetRandom(Expression<Func<int>> size = null)
        {
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<RefBrewery[]>(() =>
            {
                var apiCallPath = "/v1/breweries/random";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<RefBrewery[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        public IBodyWorkflowAction<RefBrewery[]> SearchBreweries(Expression<Func<string>> query)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            return new DeferredBodyAction<RefBrewery[]>(() =>
            {
                var apiCallPath = "/v1/breweries/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                return new ApiConnectionAction<RefBrewery[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        public IBodyWorkflowAction<CountBreweriesResponse> CountBreweries(Expression<Func<string>> byCity = null, Expression<Func<string>> byCountry = null, Expression<Func<string>> byName = null, Expression<Func<string>> byState = null, Expression<Func<string>> byPostal = null, Expression<Func<byTypeInput>> byType = null)
        {
            var __workflow_byCity = WorkflowExpression.Compile(byCity, nameof(byCity), required: false);
            var __workflow_byCountry = WorkflowExpression.Compile(byCountry, nameof(byCountry), required: false);
            var __workflow_byName = WorkflowExpression.Compile(byName, nameof(byName), required: false);
            var __workflow_byState = WorkflowExpression.Compile(byState, nameof(byState), required: false);
            var __workflow_byPostal = WorkflowExpression.Compile(byPostal, nameof(byPostal), required: false);
            var __workflow_byType = WorkflowExpression.Compile(byType, nameof(byType), required: false);
            return new DeferredBodyAction<CountBreweriesResponse>(() =>
            {
                var apiCallPath = "/v1/breweries/meta";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_byCity != null)
                    callPayload.Queries["by_city"] = ExpressionConverter.Convert(__workflow_byCity);
                if (__workflow_byCountry != null)
                    callPayload.Queries["by_country"] = ExpressionConverter.Convert(__workflow_byCountry);
                if (__workflow_byName != null)
                    callPayload.Queries["by_name"] = ExpressionConverter.Convert(__workflow_byName);
                if (__workflow_byState != null)
                    callPayload.Queries["by_state"] = ExpressionConverter.Convert(__workflow_byState);
                if (__workflow_byPostal != null)
                    callPayload.Queries["by_postal"] = ExpressionConverter.Convert(__workflow_byPostal);
                if (__workflow_byType != null)
                    callPayload.Queries["by_type"] = ExpressionConverter.Convert(__workflow_byType);
                return new ApiConnectionAction<CountBreweriesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class OpenbrewerydbTriggers([ConnectionName] string connectionId)
    {
    }

    public class RefBrewery
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("brewery_type")]
        public string BreweryType { get; set; }

        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("address_3")]
        public string Address3 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state_province")]
        public string StateProvince { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum byTypeInput
    {
        [EnumMember(Value = "micro")]
        Micro,
        [EnumMember(Value = "nano")]
        Nano,
        [EnumMember(Value = "regional")]
        Regional,
        [EnumMember(Value = "brewpub")]
        Brewpub,
        [EnumMember(Value = "large")]
        Large,
        [EnumMember(Value = "planning")]
        Planning,
        [EnumMember(Value = "bar")]
        Bar,
        [EnumMember(Value = "contract")]
        Contract,
        [EnumMember(Value = "proprietor")]
        Proprietor,
        [EnumMember(Value = "closed")]
        Closed
    }

    public class CountBreweriesResponse
    {
        [JsonProperty("total")]
        public string Total { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Openbrewerydb;

    public partial class WorkflowManagedActions
    {
        public OpenbrewerydbActions Openbrewerydb(string connectionId) => new OpenbrewerydbActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenbrewerydbTriggers Openbrewerydb(string connectionId) => new OpenbrewerydbTriggers(connectionId);
    }
}
