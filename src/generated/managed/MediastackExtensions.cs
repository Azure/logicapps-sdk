//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mediastack
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MediastackActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mediastack")]
        [WorkflowExpressionFactory(nameof(__BuildListNews))]
        public IBodyWorkflowAction<ListNewsResponse> ListNews([WorkflowExpression] Func<string> sources = null, [WorkflowExpression] Func<string> categories = null, [WorkflowExpression] Func<string> countries = null, [WorkflowExpression] Func<string> languages = null, [WorkflowExpression] Func<string> keywords = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mediastack")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListNewsResponse> __BuildListNews(WorkflowExpression<string> sources = null, WorkflowExpression<string> categories = null, WorkflowExpression<string> countries = null, WorkflowExpression<string> languages = null, WorkflowExpression<string> keywords = null, WorkflowExpression<string> date = null, WorkflowExpression<sortInput> sort = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(sources, nameof(sources), required: false);
            WorkflowExpression.Validate(categories, nameof(categories), required: false);
            WorkflowExpression.Validate(countries, nameof(countries), required: false);
            WorkflowExpression.Validate(languages, nameof(languages), required: false);
            WorkflowExpression.Validate(keywords, nameof(keywords), required: false);
            WorkflowExpression.Validate(date, nameof(date), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ListNewsResponse>(() =>
            {
                var apiCallPath = "/v1/news";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sources != null)
                    callPayload.Queries["sources"] = ExpressionConverter.Convert(sources);
                if (categories != null)
                    callPayload.Queries["categories"] = ExpressionConverter.Convert(categories);
                if (countries != null)
                    callPayload.Queries["countries"] = ExpressionConverter.Convert(countries);
                if (languages != null)
                    callPayload.Queries["languages"] = ExpressionConverter.Convert(languages);
                if (keywords != null)
                    callPayload.Queries["keywords"] = ExpressionConverter.Convert(keywords);
                if (date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(date);
                callPayload.Queries["sort"] = Convert.ToString("published_desc");
                if (sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<ListNewsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mediastack")]
        [WorkflowExpressionFactory(nameof(__BuildListSources))]
        public IBodyWorkflowAction<ListSourcesResponse> ListSources([WorkflowExpression] Func<string> search, [WorkflowExpression] Func<string> countries = null, [WorkflowExpression] Func<string> languages = null, [WorkflowExpression] Func<string> categories = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mediastack")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListSourcesResponse> __BuildListSources(WorkflowExpression<string> search, WorkflowExpression<string> countries = null, WorkflowExpression<string> languages = null, WorkflowExpression<string> categories = null, WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(search, nameof(search), required: true);
            WorkflowExpression.Validate(countries, nameof(countries), required: false);
            WorkflowExpression.Validate(languages, nameof(languages), required: false);
            WorkflowExpression.Validate(categories, nameof(categories), required: false);
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ListSourcesResponse>(() =>
            {
                var apiCallPath = "/v1/sources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (countries != null)
                    callPayload.Queries["countries"] = ExpressionConverter.Convert(countries);
                if (languages != null)
                    callPayload.Queries["languages"] = ExpressionConverter.Convert(languages);
                if (categories != null)
                    callPayload.Queries["categories"] = ExpressionConverter.Convert(categories);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<ListSourcesResponse>(callPayload);
            });
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