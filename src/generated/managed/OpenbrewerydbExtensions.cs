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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RefBrewery> __BuildGetBrewery(WorkflowValue<string> obdbId)
        {
            WorkflowValue.Validate(obdbId, nameof(obdbId), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RefBrewery[]> __BuildListBreweries(WorkflowValue<string> byCity = null, WorkflowValue<string> byCountry = null, WorkflowValue<string> byDist = null, WorkflowValue<string> byName = null, WorkflowValue<string> byState = null, WorkflowValue<string> byPostal = null, WorkflowValue<byTypeInput> byType = null, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(byCity, nameof(byCity), required: false);
            WorkflowValue.Validate(byCountry, nameof(byCountry), required: false);
            WorkflowValue.Validate(byDist, nameof(byDist), required: false);
            WorkflowValue.Validate(byName, nameof(byName), required: false);
            WorkflowValue.Validate(byState, nameof(byState), required: false);
            WorkflowValue.Validate(byPostal, nameof(byPostal), required: false);
            WorkflowValue.Validate(byType, nameof(byType), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RefBrewery[]> __BuildGetRandom(WorkflowValue<int> size = null)
        {
            WorkflowValue.Validate(size, nameof(size), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RefBrewery[]> __BuildSearchBreweries(WorkflowValue<string> query)
        {
            WorkflowValue.Validate(query, nameof(query), required: true);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CountBreweriesResponse> __BuildCountBreweries(WorkflowValue<string> byCity = null, WorkflowValue<string> byCountry = null, WorkflowValue<string> byName = null, WorkflowValue<string> byState = null, WorkflowValue<string> byPostal = null, WorkflowValue<byTypeInput> byType = null)
        {
            WorkflowValue.Validate(byCity, nameof(byCity), required: false);
            WorkflowValue.Validate(byCountry, nameof(byCountry), required: false);
            WorkflowValue.Validate(byName, nameof(byName), required: false);
            WorkflowValue.Validate(byState, nameof(byState), required: false);
            WorkflowValue.Validate(byPostal, nameof(byPostal), required: false);
            WorkflowValue.Validate(byType, nameof(byType), required: false);
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
