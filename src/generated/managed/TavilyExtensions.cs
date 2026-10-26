//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tavily
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TavilyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<SearchPostResponse, ApiConnectionActionConfiguration> Search(Expression<Func<SearchPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SearchPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SearchPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<ExtractPostResponse, ApiConnectionActionConfiguration> Extract(Expression<Func<ExtractPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ExtractPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<CrawlPostResponse, ApiConnectionActionConfiguration> Crawl(Expression<Func<CrawlPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CrawlPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crawl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CrawlPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<MapPostResponse, ApiConnectionActionConfiguration> Map(Expression<Func<MapPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MapPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/map";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MapPostResponse>(callPayload);
            });
        }
    }

    public class TavilyTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchPostResponse
    {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }

        [JsonProperty("images")]
        public SearchPostResponseImagesTypeItem[] Images { get; set; }

        [JsonProperty("results")]
        public SearchPostResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("response_time")]
        public double ResponseTime { get; set; }
    }

    public class SearchPostResponseImagesTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class SearchPostResponseResultsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("raw_content")]
        public string RawContent { get; set; }
    }

    public class SearchPostInput
    {
        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Query { get; set; }

        [JsonProperty("topic", DefaultValueHandling = DefaultValueHandling.Include)]
        public SearchPostInputTopicType? Topic { get; set; } = SearchPostInputTopicType.General;

        [JsonProperty("search_depth", DefaultValueHandling = DefaultValueHandling.Include)]
        public SearchPostInputSearchDepthType? SearchDepth { get; set; } = SearchPostInputSearchDepthType.Basic;

        [JsonProperty("chunks_per_source")]
        public int? ChunksPerSource { get; set; }

        [JsonProperty("max_results", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxResults { get; set; } = 5;

        [JsonProperty("time_range")]
        public SearchPostInputTimeRangeType? TimeRange { get; set; }

        [JsonProperty("days", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Days { get; set; } = 7;

        [JsonProperty("include_answer", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeAnswer { get; set; } = false;

        [JsonProperty("include_raw_content", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeRawContent { get; set; } = false;

        [JsonProperty("include_images", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeImages { get; set; } = false;

        [JsonProperty("include_image_descriptions")]
        public bool? IncludeImageDescriptions { get; set; }

        [JsonProperty("include_domains")]
        public string[] IncludeDomains { get; set; }

        [JsonProperty("exclude_domains")]
        public string[] ExcludeDomains { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchPostInputTopicType
    {
        [EnumMember(Value = "general")]
        General,
        [EnumMember(Value = "news")]
        News
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchPostInputSearchDepthType
    {
        [EnumMember(Value = "basic")]
        Basic,
        [EnumMember(Value = "advanced")]
        Advanced
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SearchPostInputTimeRangeType
    {
        [EnumMember(Value = "day")]
        Day,
        [EnumMember(Value = "week")]
        Week,
        [EnumMember(Value = "month")]
        Month,
        [EnumMember(Value = "year")]
        Year,
        [EnumMember(Value = "d")]
        D,
        [EnumMember(Value = "w")]
        W,
        [EnumMember(Value = "m")]
        M,
        [EnumMember(Value = "y")]
        Y
    }

    public class ExtractPostResponse
    {
        [JsonProperty("results")]
        public ExtractPostResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("failed_results")]
        public ExtractPostResponseFailedResultsTypeItem[] FailedResults { get; set; }

        [JsonProperty("response_time")]
        public double ResponseTime { get; set; }
    }

    public class ExtractPostResponseResultsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("raw_content")]
        public string RawContent { get; set; }

        [JsonProperty("images")]
        public string[] Images { get; set; }
    }

    public class ExtractPostResponseFailedResultsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public class ExtractPostInput
    {
        [JsonProperty("urls", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Urls { get; set; }

        [JsonProperty("include_images", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeImages { get; set; } = false;

        [JsonProperty("extract_depth", DefaultValueHandling = DefaultValueHandling.Include)]
        public ExtractPostInputExtractDepthType? ExtractDepth { get; set; } = ExtractPostInputExtractDepthType.Basic;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExtractPostInputExtractDepthType
    {
        [EnumMember(Value = "basic")]
        Basic,
        [EnumMember(Value = "advanced")]
        Advanced
    }

    public class CrawlPostResponse
    {
        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }

        [JsonProperty("results")]
        public CrawlPostResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("response_time")]
        public double ResponseTime { get; set; }
    }

    public class CrawlPostResponseResultsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("raw_content")]
        public string RawContent { get; set; }
    }

    public class CrawlPostInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("max_depth")]
        public int? MaxDepth { get; set; }

        [JsonProperty("max_breadth", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxBreadth { get; set; } = 20;

        [JsonProperty("limit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Limit { get; set; } = 50;

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("select_paths")]
        public string[] SelectPaths { get; set; }

        [JsonProperty("select_domains")]
        public string[] SelectDomains { get; set; }

        [JsonProperty("exclude_paths")]
        public string[] ExcludePaths { get; set; }

        [JsonProperty("exclude_domains")]
        public string[] ExcludeDomains { get; set; }

        [JsonProperty("allow_external", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowExternal { get; set; } = false;

        [JsonProperty("include_images", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeImages { get; set; } = false;

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("extract_depth", DefaultValueHandling = DefaultValueHandling.Include)]
        public CrawlPostInputExtractDepthType? ExtractDepth { get; set; } = CrawlPostInputExtractDepthType.Basic;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CrawlPostInputExtractDepthType
    {
        [EnumMember(Value = "basic")]
        Basic,
        [EnumMember(Value = "advanced")]
        Advanced
    }

    public class MapPostResponse
    {
        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }

        [JsonProperty("results")]
        public string[] Results { get; set; }

        [JsonProperty("response_time")]
        public double ResponseTime { get; set; }
    }

    public class MapPostInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("max_depth", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxDepth { get; set; } = 1;

        [JsonProperty("max_breadth", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxBreadth { get; set; } = 20;

        [JsonProperty("limit", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Limit { get; set; } = 50;

        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        [JsonProperty("select_paths")]
        public string[] SelectPaths { get; set; }

        [JsonProperty("select_domains")]
        public string[] SelectDomains { get; set; }

        [JsonProperty("exclude_paths")]
        public string[] ExcludePaths { get; set; }

        [JsonProperty("exclude_domains")]
        public string[] ExcludeDomains { get; set; }

        [JsonProperty("allow_external", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowExternal { get; set; } = false;

        [JsonProperty("categories")]
        public MapPostInputCategoriesTypeItem[] Categories { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MapPostInputCategoriesTypeItem
    {
        Careers,
        Blog,
        Documentation,
        About,
        Pricing,
        Community,
        Developers,
        Contact,
        Media
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tavily;

    public partial class WorkflowManagedActions
    {
        public TavilyActions Tavily(string connectionId) => new TavilyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TavilyTriggers Tavily(string connectionId) => new TavilyTriggers(connectionId);
    }
}