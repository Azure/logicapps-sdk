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
        public IBodyWorkflowAction<SearchResponse, ApiConnectionActionConfiguration> Search(Expression<Func<SearchBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<ExtractResponse, ApiConnectionActionConfiguration> Extract(Expression<Func<ExtractBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExtractResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExtractResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<CrawlResponse, ApiConnectionActionConfiguration> Crawl(Expression<Func<CrawlBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CrawlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/crawl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CrawlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<MapResponse, ApiConnectionActionConfiguration> Map(Expression<Func<MapBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<MapResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/map";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MapResponse>(callPayload);
            });
        }
    }

    public class TavilyTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchResponse
    {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }

        [JsonProperty("images")]
        public SearchResponseImagesTypeItem[] Images { get; set; }

        [JsonProperty("results")]
        public SearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("response_time")]
        public double ResponseTime { get; set; }
    }

    public class SearchResponseImagesTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class SearchResponseResultsTypeItem
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

    public class SearchBodyInput
    {
        public SearchBodyInput(string query)
        {
            this.Query = query;
        }

        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Query { get; set; }

        [JsonProperty("topic", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTopicType? Topic { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Tavily.BodyInputTopicType.General;

        [JsonProperty("search_depth", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputSearchDepthType? SearchDepth { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Tavily.BodyInputSearchDepthType.Basic;

        [JsonProperty("chunks_per_source")]
        public int? ChunksPerSource { get; set; }

        [JsonProperty("max_results", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxResults { get; set; } = 5;

        [JsonProperty("time_range")]
        public BodyInputTimeRangeType? TimeRange { get; set; }

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
    public enum BodyInputTopicType
    {
        [EnumMember(Value = "general")]
        General,
        [EnumMember(Value = "news")]
        News
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSearchDepthType
    {
        [EnumMember(Value = "basic")]
        Basic,
        [EnumMember(Value = "advanced")]
        Advanced
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTimeRangeType
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

    public class ExtractResponse
    {
        [JsonProperty("results")]
        public ExtractResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("failed_results")]
        public ExtractResponseFailedResultsTypeItem[] FailedResults { get; set; }

        [JsonProperty("response_time")]
        public double ResponseTime { get; set; }
    }

    public class ExtractResponseResultsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("raw_content")]
        public string RawContent { get; set; }

        [JsonProperty("images")]
        public string[] Images { get; set; }
    }

    public class ExtractResponseFailedResultsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }
    }

    public class ExtractBodyInput
    {
        public ExtractBodyInput(string urls)
        {
            this.Urls = urls;
        }

        [JsonProperty("urls", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Urls { get; set; }

        [JsonProperty("include_images", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeImages { get; set; } = false;

        [JsonProperty("extract_depth", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputExtractDepthType? ExtractDepth { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Tavily.BodyInputExtractDepthType.Basic;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputExtractDepthType
    {
        [EnumMember(Value = "basic")]
        Basic,
        [EnumMember(Value = "advanced")]
        Advanced
    }

    public class CrawlResponse
    {
        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }

        [JsonProperty("results")]
        public CrawlResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("response_time")]
        public double ResponseTime { get; set; }
    }

    public class CrawlResponseResultsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("raw_content")]
        public string RawContent { get; set; }
    }

    public class CrawlBodyInput
    {
        public CrawlBodyInput(string url)
        {
            this.Url = url;
        }

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
        public BodyInputExtractDepthType? ExtractDepth { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Tavily.BodyInputExtractDepthType.Basic;
    }

    public class MapResponse
    {
        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }

        [JsonProperty("results")]
        public string[] Results { get; set; }

        [JsonProperty("response_time")]
        public double ResponseTime { get; set; }
    }

    public class MapBodyInput
    {
        public MapBodyInput(string url)
        {
            this.Url = url;
        }

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
        public BodyInputCategoriesTypeItem[] Categories { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputCategoriesTypeItem
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