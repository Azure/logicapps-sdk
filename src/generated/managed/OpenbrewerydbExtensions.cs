//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Openbrewerydb
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpenbrewerydbActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        [WorkflowExpressionFactory(nameof(__BuildGetBrewery))]
        public IBodyWorkflowAction<RefBrewery> GetBrewery([WorkflowExpression] Func<string> obdbId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RefBrewery> __BuildGetBrewery(WorkflowExpression<string> obdbId)
        {
            WorkflowExpression.Validate(obdbId, nameof(obdbId), required: true);
            return new DeferredBodyAction<RefBrewery>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/breweries/{0}", ExpressionConverter.ConvertWithUrlEncoding(obdbId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RefBrewery>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        [WorkflowExpressionFactory(nameof(__BuildListBreweries))]
        public IBodyWorkflowAction<RefBrewery[]> ListBreweries([WorkflowExpression] Func<string> byCity = null, [WorkflowExpression] Func<string> byCountry = null, [WorkflowExpression] Func<string> byDist = null, [WorkflowExpression] Func<string> byName = null, [WorkflowExpression] Func<string> byState = null, [WorkflowExpression] Func<string> byPostal = null, [WorkflowExpression] Func<byTypeInput> byType = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RefBrewery[]> __BuildListBreweries(WorkflowExpression<string> byCity = null, WorkflowExpression<string> byCountry = null, WorkflowExpression<string> byDist = null, WorkflowExpression<string> byName = null, WorkflowExpression<string> byState = null, WorkflowExpression<string> byPostal = null, WorkflowExpression<byTypeInput> byType = null, WorkflowExpression<int> page = null, WorkflowExpression<int> perPage = null)
        {
            WorkflowExpression.Validate(byCity, nameof(byCity), required: false);
            WorkflowExpression.Validate(byCountry, nameof(byCountry), required: false);
            WorkflowExpression.Validate(byDist, nameof(byDist), required: false);
            WorkflowExpression.Validate(byName, nameof(byName), required: false);
            WorkflowExpression.Validate(byState, nameof(byState), required: false);
            WorkflowExpression.Validate(byPostal, nameof(byPostal), required: false);
            WorkflowExpression.Validate(byType, nameof(byType), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<RefBrewery[]>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        [WorkflowExpressionFactory(nameof(__BuildGetRandom))]
        public IBodyWorkflowAction<RefBrewery[]> GetRandom([WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RefBrewery[]> __BuildGetRandom(WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<RefBrewery[]>(() =>
            {
                var apiCallPath = "/v1/breweries/random";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(size);
                return new ApiConnectionAction<RefBrewery[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        [WorkflowExpressionFactory(nameof(__BuildSearchBreweries))]
        public IBodyWorkflowAction<RefBrewery[]> SearchBreweries([WorkflowExpression] Func<string> query)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RefBrewery[]> __BuildSearchBreweries(WorkflowExpression<string> query)
        {
            WorkflowExpression.Validate(query, nameof(query), required: true);
            return new DeferredBodyAction<RefBrewery[]>(() =>
            {
                var apiCallPath = "/v1/breweries/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
                return new ApiConnectionAction<RefBrewery[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "openbrewerydb")]
        [WorkflowExpressionFactory(nameof(__BuildCountBreweries))]
        public IBodyWorkflowAction<CountBreweriesResponse> CountBreweries([WorkflowExpression] Func<string> byCity = null, [WorkflowExpression] Func<string> byCountry = null, [WorkflowExpression] Func<string> byName = null, [WorkflowExpression] Func<string> byState = null, [WorkflowExpression] Func<string> byPostal = null, [WorkflowExpression] Func<byTypeInput> byType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CountBreweriesResponse> __BuildCountBreweries(WorkflowExpression<string> byCity = null, WorkflowExpression<string> byCountry = null, WorkflowExpression<string> byName = null, WorkflowExpression<string> byState = null, WorkflowExpression<string> byPostal = null, WorkflowExpression<byTypeInput> byType = null)
        {
            WorkflowExpression.Validate(byCity, nameof(byCity), required: false);
            WorkflowExpression.Validate(byCountry, nameof(byCountry), required: false);
            WorkflowExpression.Validate(byName, nameof(byName), required: false);
            WorkflowExpression.Validate(byState, nameof(byState), required: false);
            WorkflowExpression.Validate(byPostal, nameof(byPostal), required: false);
            WorkflowExpression.Validate(byType, nameof(byType), required: false);
            return new DeferredBodyAction<CountBreweriesResponse>(() =>
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
            });
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