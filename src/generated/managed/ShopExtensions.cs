//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Shop
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ShopActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "shop")]
        public IBodyWorkflowAction<SearchResponse> Search(Expression<Func<string>> query = null, Expression<Func<double>> priceMin = null, Expression<Func<double>> priceMax = null, Expression<Func<string>> similarToId = null, Expression<Func<string>> numResults = null)
        {
            var __workflow_query = query == null ? null : WorkflowExpression.Compile(query);
            WorkflowExpression.Validate(__workflow_query, nameof(query), required: false);
            var __workflow_priceMin = priceMin == null ? null : WorkflowExpression.Compile(priceMin);
            WorkflowExpression.Validate(__workflow_priceMin, nameof(priceMin), required: false);
            var __workflow_priceMax = priceMax == null ? null : WorkflowExpression.Compile(priceMax);
            WorkflowExpression.Validate(__workflow_priceMax, nameof(priceMax), required: false);
            var __workflow_similarToId = similarToId == null ? null : WorkflowExpression.Compile(similarToId);
            WorkflowExpression.Validate(__workflow_similarToId, nameof(similarToId), required: false);
            var __workflow_numResults = numResults == null ? null : WorkflowExpression.Compile(numResults);
            WorkflowExpression.Validate(__workflow_numResults, nameof(numResults), required: false);
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
            var __workflow_ids = ids == null ? null : WorkflowExpression.Compile(ids);
            WorkflowExpression.Validate(__workflow_ids, nameof(ids), required: true);
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
