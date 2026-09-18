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
        public IBodyWorkflowAction<ListNewsResponse> ListNews([WorkflowExpression] Func<string> sources = null, [WorkflowExpression] Func<string> categories = null, [WorkflowExpression] Func<string> countries = null, [WorkflowExpression] Func<string> languages = null, [WorkflowExpression] Func<string> keywords = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<sortInput> sort = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(sources, nameof(sources), required: false);
            SourceExpression.Validate(categories, nameof(categories), required: false);
            SourceExpression.Validate(countries, nameof(countries), required: false);
            SourceExpression.Validate(languages, nameof(languages), required: false);
            SourceExpression.Validate(keywords, nameof(keywords), required: false);
            SourceExpression.Validate(date, nameof(date), required: false);
            SourceExpression.Validate(sort, nameof(sort), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/news";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sources != null)
                    callPayload.Queries["sources"] = SourceExpressionConverter.ConvertO(sources);
                if (categories != null)
                    callPayload.Queries["categories"] = SourceExpressionConverter.ConvertO(categories);
                if (countries != null)
                    callPayload.Queries["countries"] = SourceExpressionConverter.ConvertO(countries);
                if (languages != null)
                    callPayload.Queries["languages"] = SourceExpressionConverter.ConvertO(languages);
                if (keywords != null)
                    callPayload.Queries["keywords"] = SourceExpressionConverter.ConvertO(keywords);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                callPayload.Queries["sort"] = Convert.ToString("published_desc");
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.Convert(sort);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ListNewsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mediastack")]
        public IBodyWorkflowAction<ListSourcesResponse> ListSources([WorkflowExpression] Func<string> search, [WorkflowExpression] Func<string> countries = null, [WorkflowExpression] Func<string> languages = null, [WorkflowExpression] Func<string> categories = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            SourceExpression.Validate(search, nameof(search), required: true);
            SourceExpression.Validate(countries, nameof(countries), required: false);
            SourceExpression.Validate(languages, nameof(languages), required: false);
            SourceExpression.Validate(categories, nameof(categories), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/sources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (countries != null)
                    callPayload.Queries["countries"] = SourceExpressionConverter.ConvertO(countries);
                if (languages != null)
                    callPayload.Queries["languages"] = SourceExpressionConverter.ConvertO(languages);
                if (categories != null)
                    callPayload.Queries["categories"] = SourceExpressionConverter.ConvertO(categories);
                callPayload.Queries["limit"] = Convert.ToString(25);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["offset"] = Convert.ToString(0);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ListSourcesResponse>(BuildSourceInput);
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