//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Openbrewerydb
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenbrewerydbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        public IBodyWorkflowAction<RefBrewery> GetBrewery(Expression<Func<string>> obdbId)
        {
            var apiCallPath = String.Format("/v1/breweries/{0}", ExpressionConverter.ConvertWithUrlEncoding(obdbId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RefBrewery>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        public IBodyWorkflowAction<RefBrewery[]> ListBreweries(Expression<Func<string>> byCity = null, Expression<Func<string>> byCountry = null, Expression<Func<string>> byDist = null, Expression<Func<string>> byName = null, Expression<Func<string>> byState = null, Expression<Func<string>> byPostal = null, Expression<Func<byTypeInput>> byType = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = "/v1/breweries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (byCity != null)
                callPayload.Queries["by_city"] = ExpressionConverter.Convert(byCity);
            if (byCountry != null)
                callPayload.Queries["by_country"] = ExpressionConverter.Convert(byCountry);
            if (byDist != null)
                callPayload.Queries["by_dist"] = ExpressionConverter.Convert(byDist);
            if (byName != null)
                callPayload.Queries["by_name"] = ExpressionConverter.Convert(byName);
            if (byState != null)
                callPayload.Queries["by_state"] = ExpressionConverter.Convert(byState);
            if (byPostal != null)
                callPayload.Queries["by_postal"] = ExpressionConverter.Convert(byPostal);
            if (byType != null)
                callPayload.Queries["by_type"] = ExpressionConverter.Convert(byType);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<RefBrewery[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        public IBodyWorkflowAction<RefBrewery[]> GetRandom(Expression<Func<int>> size = null)
        {
            var apiCallPath = "/v1/breweries/random";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            return new ApiConnectionAction<RefBrewery[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        public IBodyWorkflowAction<RefBrewery[]> SearchBreweries(Expression<Func<string>> query)
        {
            var apiCallPath = "/v1/breweries/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            return new ApiConnectionAction<RefBrewery[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        public IBodyWorkflowAction<CountBreweriesResponse> CountBreweries(Expression<Func<string>> byCity = null, Expression<Func<string>> byCountry = null, Expression<Func<string>> byName = null, Expression<Func<string>> byState = null, Expression<Func<string>> byPostal = null, Expression<Func<byTypeInput>> byType = null)
        {
            var apiCallPath = "/v1/breweries/meta";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (byCity != null)
                callPayload.Queries["by_city"] = ExpressionConverter.Convert(byCity);
            if (byCountry != null)
                callPayload.Queries["by_country"] = ExpressionConverter.Convert(byCountry);
            if (byName != null)
                callPayload.Queries["by_name"] = ExpressionConverter.Convert(byName);
            if (byState != null)
                callPayload.Queries["by_state"] = ExpressionConverter.Convert(byState);
            if (byPostal != null)
                callPayload.Queries["by_postal"] = ExpressionConverter.Convert(byPostal);
            if (byType != null)
                callPayload.Queries["by_type"] = ExpressionConverter.Convert(byType);
            return new ApiConnectionAction<CountBreweriesResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Openbrewerydb;

    public partial class WorkflowManagedActions
    {
        public OpenbrewerydbActions Openbrewerydb(string connectionId) => new OpenbrewerydbActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpenbrewerydbTriggers Openbrewerydb(string connectionId) => new OpenbrewerydbTriggers(connectionId);
    }
}