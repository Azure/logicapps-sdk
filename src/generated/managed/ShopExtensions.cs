//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shop
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShopActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shop")]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<double> priceMin = null, [WorkflowExpression] Func<double> priceMax = null, [WorkflowExpression] Func<string> similarToId = null, [WorkflowExpression] Func<string> numResults = null)
        {
            var apiCallPath = "/openai/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (query != null)
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            if (priceMin != null)
                callPayload.Queries["price_min"] = ExpressionConverter.Convert(priceMin);
            if (priceMax != null)
                callPayload.Queries["price_max"] = ExpressionConverter.Convert(priceMax);
            if (similarToId != null)
                callPayload.Queries["similar_to_id"] = ExpressionConverter.Convert(similarToId);
            if (numResults != null)
                callPayload.Queries["num_results"] = ExpressionConverter.Convert(numResults);
            return new ApiConnectionAction<SearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shop")]
        public IBodyWorkflowAction<SearchResponse> Details([WorkflowExpression] Func<string> ids)
        {
            var apiCallPath = "/openai/details";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            return new ApiConnectionAction<SearchResponse>(callPayload);
        }
    }

    public class ShopTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchResponse
    {
        [JsonProperty("results")]
        public SearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class SearchResponseResultsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Shop;

    public partial class WorkflowManagedActions
    {
        public ShopActions Shop(string connectionId) => new ShopActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ShopTriggers Shop(string connectionId) => new ShopTriggers(connectionId);
    }
}