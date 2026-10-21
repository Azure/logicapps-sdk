//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mediastack
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MediastackActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mediastack")]
        public IBodyWorkflowAction<ListNewsResponse> ListNews(Expression<Func<string>> sources = null, Expression<Func<string>> categories = null, Expression<Func<string>> countries = null, Expression<Func<string>> languages = null, Expression<Func<string>> keywords = null, Expression<Func<string>> date = null, Expression<Func<sortInput>> sort = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_sources = WorkflowExpression.Compile(sources, nameof(sources), required: false);
            var __workflow_categories = WorkflowExpression.Compile(categories, nameof(categories), required: false);
            var __workflow_countries = WorkflowExpression.Compile(countries, nameof(countries), required: false);
            var __workflow_languages = WorkflowExpression.Compile(languages, nameof(languages), required: false);
            var __workflow_keywords = WorkflowExpression.Compile(keywords, nameof(keywords), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ListNewsResponse>(() =>
            {
                var apiCallPath = "/v1/news";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sources != null)
                    callPayload.Queries["sources"] = ExpressionConverter.Convert(__workflow_sources);
                if (__workflow_categories != null)
                    callPayload.Queries["categories"] = ExpressionConverter.Convert(__workflow_categories);
                if (__workflow_countries != null)
                    callPayload.Queries["countries"] = ExpressionConverter.Convert(__workflow_countries);
                if (__workflow_languages != null)
                    callPayload.Queries["languages"] = ExpressionConverter.Convert(__workflow_languages);
                if (__workflow_keywords != null)
                    callPayload.Queries["keywords"] = ExpressionConverter.Convert(__workflow_keywords);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                callPayload.Queries["sort"] = Convert.ToString("published_desc");
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ListNewsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mediastack")]
        public IBodyWorkflowAction<ListSourcesResponse> ListSources(Expression<Func<string>> search, Expression<Func<string>> countries = null, Expression<Func<string>> languages = null, Expression<Func<string>> categories = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: true);
            var __workflow_countries = WorkflowExpression.Compile(countries, nameof(countries), required: false);
            var __workflow_languages = WorkflowExpression.Compile(languages, nameof(languages), required: false);
            var __workflow_categories = WorkflowExpression.Compile(categories, nameof(categories), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ListSourcesResponse>(() =>
            {
                var apiCallPath = "/v1/sources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_countries != null)
                    callPayload.Queries["countries"] = ExpressionConverter.Convert(__workflow_countries);
                if (__workflow_languages != null)
                    callPayload.Queries["languages"] = ExpressionConverter.Convert(__workflow_languages);
                if (__workflow_categories != null)
                    callPayload.Queries["categories"] = ExpressionConverter.Convert(__workflow_categories);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ListSourcesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class MediastackTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListNewsResponse
    {
        [JsonProperty("pagination")]
        public ListNewsResponsePaginationType Pagination { get; set; }

        [JsonProperty("data")]
        public ListNewsResponseDataTypeItem[] Data { get; set; }
    }

    public class ListNewsResponsePaginationType
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class ListNewsResponseDataTypeItem
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortInput
    {
        [EnumMember(Value = "published_desc")]
        PublishedDesc,
        [EnumMember(Value = "published_asc")]
        PublishedAsc,
        [EnumMember(Value = "popularity")]
        Popularity
    }

    public class ListSourcesResponse
    {
        [JsonProperty("pagination")]
        public ListSourcesResponsePaginationType Pagination { get; set; }

        [JsonProperty("data")]
        public ListSourcesResponseDataTypeItem[] Data { get; set; }
    }

    public class ListSourcesResponsePaginationType
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class ListSourcesResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mediastack;

    public partial class WorkflowManagedActions
    {
        public MediastackActions Mediastack(string connectionId) => new MediastackActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MediastackTriggers Mediastack(string connectionId) => new MediastackTriggers(connectionId);
    }
}
