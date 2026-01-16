//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tavily
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TavilyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<SearchPostResponse> SearchPost(Expression<Func<string>> bodyquery, Expression<Func<bodytopicInput>> bodytopic = null, Expression<Func<bodysearchDepthInput>> bodysearchDepth = null, Expression<Func<int>> bodychunksPerSource = null, Expression<Func<int>> bodymaxResults = null, Expression<Func<bodytimeRangeInput>> bodytimeRange = null, Expression<Func<int>> bodydays = null, Expression<Func<bool>> bodyincludeAnswer = null, Expression<Func<bool>> bodyincludeRawContent = null, Expression<Func<bool>> bodyincludeImages = null, Expression<Func<bool>> bodyincludeImageDescriptions = null, Expression<Func<string[]>> bodyincludeDomains = null, Expression<Func<string[]>> bodyexcludeDomains = null)
        {
            var apiCallPath = "/search";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["query"] = ExpressionConverter.ConvertO(bodyquery);
            if (bodytopic != null)
            {
                body["topic"] = ExpressionConverter.ConvertO(bodytopic);
                bodypropCount++;
            }

            if (bodysearchDepth != null)
            {
                body["search_depth"] = ExpressionConverter.ConvertO(bodysearchDepth);
                bodypropCount++;
            }

            if (bodychunksPerSource != null)
            {
                body["chunks_per_source"] = ExpressionConverter.ConvertO(bodychunksPerSource);
                bodypropCount++;
            }

            if (bodymaxResults != null)
            {
                body["max_results"] = ExpressionConverter.ConvertO(bodymaxResults);
                bodypropCount++;
            }

            if (bodytimeRange != null)
            {
                body["time_range"] = ExpressionConverter.ConvertO(bodytimeRange);
                bodypropCount++;
            }

            if (bodydays != null)
            {
                body["days"] = ExpressionConverter.ConvertO(bodydays);
                bodypropCount++;
            }

            if (bodyincludeAnswer != null)
            {
                body["include_answer"] = ExpressionConverter.ConvertO(bodyincludeAnswer);
                bodypropCount++;
            }

            if (bodyincludeRawContent != null)
            {
                body["include_raw_content"] = ExpressionConverter.ConvertO(bodyincludeRawContent);
                bodypropCount++;
            }

            if (bodyincludeImages != null)
            {
                body["include_images"] = ExpressionConverter.ConvertO(bodyincludeImages);
                bodypropCount++;
            }

            if (bodyincludeImageDescriptions != null)
            {
                body["include_image_descriptions"] = ExpressionConverter.ConvertO(bodyincludeImageDescriptions);
                bodypropCount++;
            }

            if (bodyincludeDomains != null)
            {
                body["include_domains"] = ExpressionConverter.ConvertO(bodyincludeDomains);
                bodypropCount++;
            }

            if (bodyexcludeDomains != null)
            {
                body["exclude_domains"] = ExpressionConverter.ConvertO(bodyexcludeDomains);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SearchPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<ExtractPostResponse> ExtractPost(Expression<Func<string>> bodyurls, Expression<Func<bool>> bodyincludeImages = null, Expression<Func<bodyextractDepthInput>> bodyextractDepth = null)
        {
            var apiCallPath = "/extract";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["urls"] = ExpressionConverter.ConvertO(bodyurls);
            if (bodyincludeImages != null)
            {
                body["include_images"] = ExpressionConverter.ConvertO(bodyincludeImages);
                bodypropCount++;
            }

            if (bodyextractDepth != null)
            {
                body["extract_depth"] = ExpressionConverter.ConvertO(bodyextractDepth);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ExtractPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<CrawlPostResponse> CrawlPost(Expression<Func<string>> bodyurl, Expression<Func<int>> bodymaxDepth = null, Expression<Func<int>> bodymaxBreadth = null, Expression<Func<int>> bodylimit = null, Expression<Func<string>> bodyinstructions = null, Expression<Func<string[]>> bodyselectPaths = null, Expression<Func<string[]>> bodyselectDomains = null, Expression<Func<string[]>> bodyexcludePaths = null, Expression<Func<string[]>> bodyexcludeDomains = null, Expression<Func<bool>> bodyallowExternal = null, Expression<Func<bool>> bodyincludeImages = null, Expression<Func<string[]>> bodycategories = null, Expression<Func<bodyextractDepthInput>> bodyextractDepth = null)
        {
            var apiCallPath = "/crawl";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodymaxDepth != null)
            {
                body["max_depth"] = ExpressionConverter.ConvertO(bodymaxDepth);
                bodypropCount++;
            }

            if (bodymaxBreadth != null)
            {
                body["max_breadth"] = ExpressionConverter.ConvertO(bodymaxBreadth);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                bodypropCount++;
            }

            if (bodyinstructions != null)
            {
                body["instructions"] = ExpressionConverter.ConvertO(bodyinstructions);
                bodypropCount++;
            }

            if (bodyselectPaths != null)
            {
                body["select_paths"] = ExpressionConverter.ConvertO(bodyselectPaths);
                bodypropCount++;
            }

            if (bodyselectDomains != null)
            {
                body["select_domains"] = ExpressionConverter.ConvertO(bodyselectDomains);
                bodypropCount++;
            }

            if (bodyexcludePaths != null)
            {
                body["exclude_paths"] = ExpressionConverter.ConvertO(bodyexcludePaths);
                bodypropCount++;
            }

            if (bodyexcludeDomains != null)
            {
                body["exclude_domains"] = ExpressionConverter.ConvertO(bodyexcludeDomains);
                bodypropCount++;
            }

            if (bodyallowExternal != null)
            {
                body["allow_external"] = ExpressionConverter.ConvertO(bodyallowExternal);
                bodypropCount++;
            }

            if (bodyincludeImages != null)
            {
                body["include_images"] = ExpressionConverter.ConvertO(bodyincludeImages);
                bodypropCount++;
            }

            if (bodycategories != null)
            {
                body["categories"] = ExpressionConverter.ConvertO(bodycategories);
                bodypropCount++;
            }

            if (bodyextractDepth != null)
            {
                body["extract_depth"] = ExpressionConverter.ConvertO(bodyextractDepth);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CrawlPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<MapPostResponse> MapPost(Expression<Func<string>> bodyurl, Expression<Func<int>> bodymaxDepth = null, Expression<Func<int>> bodymaxBreadth = null, Expression<Func<int>> bodylimit = null, Expression<Func<string>> bodyinstructions = null, Expression<Func<string[]>> bodyselectPaths = null, Expression<Func<string[]>> bodyselectDomains = null, Expression<Func<string[]>> bodyexcludePaths = null, Expression<Func<string[]>> bodyexcludeDomains = null, Expression<Func<bool>> bodyallowExternal = null, Expression<Func<bodycategoriesInputItem[]>> bodycategories = null)
        {
            var apiCallPath = "/map";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["url"] = ExpressionConverter.ConvertO(bodyurl);
            if (bodymaxDepth != null)
            {
                body["max_depth"] = ExpressionConverter.ConvertO(bodymaxDepth);
                bodypropCount++;
            }

            if (bodymaxBreadth != null)
            {
                body["max_breadth"] = ExpressionConverter.ConvertO(bodymaxBreadth);
                bodypropCount++;
            }

            if (bodylimit != null)
            {
                body["limit"] = ExpressionConverter.ConvertO(bodylimit);
                bodypropCount++;
            }

            if (bodyinstructions != null)
            {
                body["instructions"] = ExpressionConverter.ConvertO(bodyinstructions);
                bodypropCount++;
            }

            if (bodyselectPaths != null)
            {
                body["select_paths"] = ExpressionConverter.ConvertO(bodyselectPaths);
                bodypropCount++;
            }

            if (bodyselectDomains != null)
            {
                body["select_domains"] = ExpressionConverter.ConvertO(bodyselectDomains);
                bodypropCount++;
            }

            if (bodyexcludePaths != null)
            {
                body["exclude_paths"] = ExpressionConverter.ConvertO(bodyexcludePaths);
                bodypropCount++;
            }

            if (bodyexcludeDomains != null)
            {
                body["exclude_domains"] = ExpressionConverter.ConvertO(bodyexcludeDomains);
                bodypropCount++;
            }

            if (bodyallowExternal != null)
            {
                body["allow_external"] = ExpressionConverter.ConvertO(bodyallowExternal);
                bodypropCount++;
            }

            if (bodycategories != null)
            {
                body["categories"] = ExpressionConverter.ConvertO(bodycategories);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MapPostResponse>(callPayload);
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

    public enum bodytopicInput
    {
        [EnumMember(Value = "general")]
        General,
        [EnumMember(Value = "news")]
        News
    }

    public enum bodysearchDepthInput
    {
        [EnumMember(Value = "basic")]
        Basic,
        [EnumMember(Value = "advanced")]
        Advanced
    }

    public enum bodytimeRangeInput
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

    public enum bodyextractDepthInput
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

    public class MapPostResponse
    {
        [JsonProperty("base_url")]
        public string BaseUrl { get; set; }

        [JsonProperty("results")]
        public string[] Results { get; set; }

        [JsonProperty("response_time")]
        public double ResponseTime { get; set; }
    }

    public enum bodycategoriesInputItem
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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