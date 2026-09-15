//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mediastack
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MediastackActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mediastack")]
        public IBodyWorkflowAction<ListNewsResponse> ListNews(Expression<Func<string>> sources = null, Expression<Func<string>> categories = null, Expression<Func<string>> countries = null, Expression<Func<string>> languages = null, Expression<Func<string>> keywords = null, Expression<Func<string>> date = null, Expression<Func<sortInput>> sort = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/v1/news";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sources != null)
                callPayload.Queries["sources"] = CSharpExpressionConverter.ConvertO(sources);
            if (categories != null)
                callPayload.Queries["categories"] = CSharpExpressionConverter.ConvertO(categories);
            if (countries != null)
                callPayload.Queries["countries"] = CSharpExpressionConverter.ConvertO(countries);
            if (languages != null)
                callPayload.Queries["languages"] = CSharpExpressionConverter.ConvertO(languages);
            if (keywords != null)
                callPayload.Queries["keywords"] = CSharpExpressionConverter.ConvertO(keywords);
            if (date != null)
                callPayload.Queries["date"] = CSharpExpressionConverter.ConvertO(date);
            callPayload.Queries["sort"] = Convert.ToString("published_desc");
            if (sort != null)
                callPayload.Queries["sort"] = CSharpExpressionConverter.Convert(sort);
            callPayload.Queries["limit"] = Convert.ToString(25);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            callPayload.Queries["offset"] = Convert.ToString(0);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<ListNewsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mediastack")]
        public IBodyWorkflowAction<ListSourcesResponse> ListSources(Expression<Func<string>> search, Expression<Func<string>> countries = null, Expression<Func<string>> languages = null, Expression<Func<string>> categories = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/v1/sources";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (countries != null)
                callPayload.Queries["countries"] = CSharpExpressionConverter.ConvertO(countries);
            if (languages != null)
                callPayload.Queries["languages"] = CSharpExpressionConverter.ConvertO(languages);
            if (categories != null)
                callPayload.Queries["categories"] = CSharpExpressionConverter.ConvertO(categories);
            callPayload.Queries["limit"] = Convert.ToString(25);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            callPayload.Queries["offset"] = Convert.ToString(0);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            return new ApiConnectionAction<ListSourcesResponse>(callPayload);
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