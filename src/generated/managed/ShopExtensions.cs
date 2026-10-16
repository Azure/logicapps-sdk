//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shop
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ShopActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shop")]
        public IBodyWorkflowAction<SearchResponse> Search(Expression<Func<string>> query = null, Expression<Func<double>> priceMin = null, Expression<Func<double>> priceMax = null, Expression<Func<string>> similarToId = null, Expression<Func<string>> numResults = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_priceMin = WorkflowExpression.Compile(priceMin, nameof(priceMin), required: false);
            var __workflow_priceMax = WorkflowExpression.Compile(priceMax, nameof(priceMax), required: false);
            var __workflow_similarToId = WorkflowExpression.Compile(similarToId, nameof(similarToId), required: false);
            var __workflow_numResults = WorkflowExpression.Compile(numResults, nameof(numResults), required: false);
            return new DeferredBodyAction<SearchResponse>(() =>
            {
                var apiCallPath = "/openai/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_priceMin != null)
                    callPayload.Queries["price_min"] = ExpressionConverter.Convert(__workflow_priceMin);
                if (__workflow_priceMax != null)
                    callPayload.Queries["price_max"] = ExpressionConverter.Convert(__workflow_priceMax);
                if (__workflow_similarToId != null)
                    callPayload.Queries["similar_to_id"] = ExpressionConverter.Convert(__workflow_similarToId);
                if (__workflow_numResults != null)
                    callPayload.Queries["num_results"] = ExpressionConverter.Convert(__workflow_numResults);
                return new ApiConnectionAction<SearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shop")]
        public IBodyWorkflowAction<SearchResponse> Details(Expression<Func<string>> ids)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: true);
            return new DeferredBodyAction<SearchResponse>(() =>
            {
                var apiCallPath = "/openai/details";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                return new ApiConnectionAction<SearchResponse>(callPayload);
            });
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
