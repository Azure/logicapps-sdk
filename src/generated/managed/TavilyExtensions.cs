//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tavily
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TavilyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<SearchPostResponse> Search(Expression<Func<string>> bodyquery, Expression<Func<bodytopicInput>> bodytopic = null, Expression<Func<bodysearchDepthInput>> bodysearchDepth = null, Expression<Func<int>> bodychunksPerSource = null, Expression<Func<int>> bodymaxResults = null, Expression<Func<bodytimeRangeInput>> bodytimeRange = null, Expression<Func<int>> bodydays = null, Expression<Func<bool>> bodyincludeAnswer = null, Expression<Func<bool>> bodyincludeRawContent = null, Expression<Func<bool>> bodyincludeImages = null, Expression<Func<bool>> bodyincludeImageDescriptions = null, Expression<Func<string[]>> bodyincludeDomains = null, Expression<Func<string[]>> bodyexcludeDomains = null)
        {
            var __workflow_bodyquery = bodyquery == null ? null : WorkflowExpression.Compile(bodyquery);
            WorkflowExpression.Validate(__workflow_bodyquery, nameof(bodyquery), required: true);
            var __workflow_bodytopic = bodytopic == null ? null : WorkflowExpression.Compile(bodytopic);
            WorkflowExpression.Validate(__workflow_bodytopic, nameof(bodytopic), required: false);
            var __workflow_bodysearchDepth = bodysearchDepth == null ? null : WorkflowExpression.Compile(bodysearchDepth);
            WorkflowExpression.Validate(__workflow_bodysearchDepth, nameof(bodysearchDepth), required: false);
            var __workflow_bodychunksPerSource = bodychunksPerSource == null ? null : WorkflowExpression.Compile(bodychunksPerSource);
            WorkflowExpression.Validate(__workflow_bodychunksPerSource, nameof(bodychunksPerSource), required: false);
            var __workflow_bodymaxResults = bodymaxResults == null ? null : WorkflowExpression.Compile(bodymaxResults);
            WorkflowExpression.Validate(__workflow_bodymaxResults, nameof(bodymaxResults), required: false);
            var __workflow_bodytimeRange = bodytimeRange == null ? null : WorkflowExpression.Compile(bodytimeRange);
            WorkflowExpression.Validate(__workflow_bodytimeRange, nameof(bodytimeRange), required: false);
            var __workflow_bodydays = bodydays == null ? null : WorkflowExpression.Compile(bodydays);
            WorkflowExpression.Validate(__workflow_bodydays, nameof(bodydays), required: false);
            var __workflow_bodyincludeAnswer = bodyincludeAnswer == null ? null : WorkflowExpression.Compile(bodyincludeAnswer);
            WorkflowExpression.Validate(__workflow_bodyincludeAnswer, nameof(bodyincludeAnswer), required: false);
            var __workflow_bodyincludeRawContent = bodyincludeRawContent == null ? null : WorkflowExpression.Compile(bodyincludeRawContent);
            WorkflowExpression.Validate(__workflow_bodyincludeRawContent, nameof(bodyincludeRawContent), required: false);
            var __workflow_bodyincludeImages = bodyincludeImages == null ? null : WorkflowExpression.Compile(bodyincludeImages);
            WorkflowExpression.Validate(__workflow_bodyincludeImages, nameof(bodyincludeImages), required: false);
            var __workflow_bodyincludeImageDescriptions = bodyincludeImageDescriptions == null ? null : WorkflowExpression.Compile(bodyincludeImageDescriptions);
            WorkflowExpression.Validate(__workflow_bodyincludeImageDescriptions, nameof(bodyincludeImageDescriptions), required: false);
            var __workflow_bodyincludeDomains = bodyincludeDomains == null ? null : WorkflowExpression.Compile(bodyincludeDomains);
            WorkflowExpression.Validate(__workflow_bodyincludeDomains, nameof(bodyincludeDomains), required: false);
            var __workflow_bodyexcludeDomains = bodyexcludeDomains == null ? null : WorkflowExpression.Compile(bodyexcludeDomains);
            WorkflowExpression.Validate(__workflow_bodyexcludeDomains, nameof(bodyexcludeDomains), required: false);
            return new DeferredBodyAction<SearchPostResponse>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = ExpressionConverter.ConvertO(__workflow_bodyquery);
                if (__workflow_bodytopic != null)
                {
                    if (__workflow_bodytopic != null)
                    {
                        body["topic"] = ExpressionConverter.ConvertO(__workflow_bodytopic);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["topic"] = "general";
                    bodypropCount++;
                }

                if (__workflow_bodysearchDepth != null)
                {
                    if (__workflow_bodysearchDepth != null)
                    {
                        body["search_depth"] = ExpressionConverter.ConvertO(__workflow_bodysearchDepth);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["search_depth"] = "basic";
                    bodypropCount++;
                }

                if (__workflow_bodychunksPerSource != null)
                {
                    body["chunks_per_source"] = ExpressionConverter.ConvertO(__workflow_bodychunksPerSource);
                    bodypropCount++;
                }

                if (__workflow_bodymaxResults != null)
                {
                    if (__workflow_bodymaxResults != null)
                    {
                        body["max_results"] = ExpressionConverter.ConvertO(__workflow_bodymaxResults);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_results"] = 5;
                    bodypropCount++;
                }

                if (__workflow_bodytimeRange != null)
                {
                    body["time_range"] = ExpressionConverter.ConvertO(__workflow_bodytimeRange);
                    bodypropCount++;
                }

                if (__workflow_bodydays != null)
                {
                    if (__workflow_bodydays != null)
                    {
                        body["days"] = ExpressionConverter.ConvertO(__workflow_bodydays);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["days"] = 7;
                    bodypropCount++;
                }

                if (__workflow_bodyincludeAnswer != null)
                {
                    if (__workflow_bodyincludeAnswer != null)
                    {
                        body["include_answer"] = ExpressionConverter.ConvertO(__workflow_bodyincludeAnswer);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_answer"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyincludeRawContent != null)
                {
                    if (__workflow_bodyincludeRawContent != null)
                    {
                        body["include_raw_content"] = ExpressionConverter.ConvertO(__workflow_bodyincludeRawContent);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_raw_content"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyincludeImages != null)
                {
                    if (__workflow_bodyincludeImages != null)
                    {
                        body["include_images"] = ExpressionConverter.ConvertO(__workflow_bodyincludeImages);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_images"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyincludeImageDescriptions != null)
                {
                    body["include_image_descriptions"] = ExpressionConverter.ConvertO(__workflow_bodyincludeImageDescriptions);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeDomains != null)
                {
                    body["include_domains"] = ExpressionConverter.ConvertO(__workflow_bodyincludeDomains);
                    bodypropCount++;
                }

                if (__workflow_bodyexcludeDomains != null)
                {
                    body["exclude_domains"] = ExpressionConverter.ConvertO(__workflow_bodyexcludeDomains);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SearchPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<ExtractPostResponse> Extract(Expression<Func<string>> bodyurls, Expression<Func<bool>> bodyincludeImages = null, Expression<Func<bodyextractDepthInput>> bodyextractDepth = null)
        {
            var __workflow_bodyurls = bodyurls == null ? null : WorkflowExpression.Compile(bodyurls);
            WorkflowExpression.Validate(__workflow_bodyurls, nameof(bodyurls), required: true);
            var __workflow_bodyincludeImages = bodyincludeImages == null ? null : WorkflowExpression.Compile(bodyincludeImages);
            WorkflowExpression.Validate(__workflow_bodyincludeImages, nameof(bodyincludeImages), required: false);
            var __workflow_bodyextractDepth = bodyextractDepth == null ? null : WorkflowExpression.Compile(bodyextractDepth);
            WorkflowExpression.Validate(__workflow_bodyextractDepth, nameof(bodyextractDepth), required: false);
            return new DeferredBodyAction<ExtractPostResponse>(() =>
            {
                var apiCallPath = "/extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = ExpressionConverter.ConvertO(__workflow_bodyurls);
                if (__workflow_bodyincludeImages != null)
                {
                    if (__workflow_bodyincludeImages != null)
                    {
                        body["include_images"] = ExpressionConverter.ConvertO(__workflow_bodyincludeImages);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_images"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyextractDepth != null)
                {
                    if (__workflow_bodyextractDepth != null)
                    {
                        body["extract_depth"] = ExpressionConverter.ConvertO(__workflow_bodyextractDepth);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["extract_depth"] = "basic";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExtractPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<CrawlPostResponse> Crawl(Expression<Func<string>> bodyurl, Expression<Func<int>> bodymaxDepth = null, Expression<Func<int>> bodymaxBreadth = null, Expression<Func<int>> bodylimit = null, Expression<Func<string>> bodyinstructions = null, Expression<Func<string[]>> bodyselectPaths = null, Expression<Func<string[]>> bodyselectDomains = null, Expression<Func<string[]>> bodyexcludePaths = null, Expression<Func<string[]>> bodyexcludeDomains = null, Expression<Func<bool>> bodyallowExternal = null, Expression<Func<bool>> bodyincludeImages = null, Expression<Func<string[]>> bodycategories = null, Expression<Func<bodyextractDepthInput>> bodyextractDepth = null)
        {
            var __workflow_bodyurl = bodyurl == null ? null : WorkflowExpression.Compile(bodyurl);
            WorkflowExpression.Validate(__workflow_bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodymaxDepth = bodymaxDepth == null ? null : WorkflowExpression.Compile(bodymaxDepth);
            WorkflowExpression.Validate(__workflow_bodymaxDepth, nameof(bodymaxDepth), required: false);
            var __workflow_bodymaxBreadth = bodymaxBreadth == null ? null : WorkflowExpression.Compile(bodymaxBreadth);
            WorkflowExpression.Validate(__workflow_bodymaxBreadth, nameof(bodymaxBreadth), required: false);
            var __workflow_bodylimit = bodylimit == null ? null : WorkflowExpression.Compile(bodylimit);
            WorkflowExpression.Validate(__workflow_bodylimit, nameof(bodylimit), required: false);
            var __workflow_bodyinstructions = bodyinstructions == null ? null : WorkflowExpression.Compile(bodyinstructions);
            WorkflowExpression.Validate(__workflow_bodyinstructions, nameof(bodyinstructions), required: false);
            var __workflow_bodyselectPaths = bodyselectPaths == null ? null : WorkflowExpression.Compile(bodyselectPaths);
            WorkflowExpression.Validate(__workflow_bodyselectPaths, nameof(bodyselectPaths), required: false);
            var __workflow_bodyselectDomains = bodyselectDomains == null ? null : WorkflowExpression.Compile(bodyselectDomains);
            WorkflowExpression.Validate(__workflow_bodyselectDomains, nameof(bodyselectDomains), required: false);
            var __workflow_bodyexcludePaths = bodyexcludePaths == null ? null : WorkflowExpression.Compile(bodyexcludePaths);
            WorkflowExpression.Validate(__workflow_bodyexcludePaths, nameof(bodyexcludePaths), required: false);
            var __workflow_bodyexcludeDomains = bodyexcludeDomains == null ? null : WorkflowExpression.Compile(bodyexcludeDomains);
            WorkflowExpression.Validate(__workflow_bodyexcludeDomains, nameof(bodyexcludeDomains), required: false);
            var __workflow_bodyallowExternal = bodyallowExternal == null ? null : WorkflowExpression.Compile(bodyallowExternal);
            WorkflowExpression.Validate(__workflow_bodyallowExternal, nameof(bodyallowExternal), required: false);
            var __workflow_bodyincludeImages = bodyincludeImages == null ? null : WorkflowExpression.Compile(bodyincludeImages);
            WorkflowExpression.Validate(__workflow_bodyincludeImages, nameof(bodyincludeImages), required: false);
            var __workflow_bodycategories = bodycategories == null ? null : WorkflowExpression.Compile(bodycategories);
            WorkflowExpression.Validate(__workflow_bodycategories, nameof(bodycategories), required: false);
            var __workflow_bodyextractDepth = bodyextractDepth == null ? null : WorkflowExpression.Compile(bodyextractDepth);
            WorkflowExpression.Validate(__workflow_bodyextractDepth, nameof(bodyextractDepth), required: false);
            return new DeferredBodyAction<CrawlPostResponse>(() =>
            {
                var apiCallPath = "/crawl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodymaxDepth != null)
                {
                    body["max_depth"] = ExpressionConverter.ConvertO(__workflow_bodymaxDepth);
                    bodypropCount++;
                }

                if (__workflow_bodymaxBreadth != null)
                {
                    if (__workflow_bodymaxBreadth != null)
                    {
                        body["max_breadth"] = ExpressionConverter.ConvertO(__workflow_bodymaxBreadth);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_breadth"] = 20;
                    bodypropCount++;
                }

                if (__workflow_bodylimit != null)
                {
                    if (__workflow_bodylimit != null)
                    {
                        body["limit"] = ExpressionConverter.ConvertO(__workflow_bodylimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["limit"] = 50;
                    bodypropCount++;
                }

                if (__workflow_bodyinstructions != null)
                {
                    body["instructions"] = ExpressionConverter.ConvertO(__workflow_bodyinstructions);
                    bodypropCount++;
                }

                if (__workflow_bodyselectPaths != null)
                {
                    body["select_paths"] = ExpressionConverter.ConvertO(__workflow_bodyselectPaths);
                    bodypropCount++;
                }

                if (__workflow_bodyselectDomains != null)
                {
                    body["select_domains"] = ExpressionConverter.ConvertO(__workflow_bodyselectDomains);
                    bodypropCount++;
                }

                if (__workflow_bodyexcludePaths != null)
                {
                    body["exclude_paths"] = ExpressionConverter.ConvertO(__workflow_bodyexcludePaths);
                    bodypropCount++;
                }

                if (__workflow_bodyexcludeDomains != null)
                {
                    body["exclude_domains"] = ExpressionConverter.ConvertO(__workflow_bodyexcludeDomains);
                    bodypropCount++;
                }

                if (__workflow_bodyallowExternal != null)
                {
                    if (__workflow_bodyallowExternal != null)
                    {
                        body["allow_external"] = ExpressionConverter.ConvertO(__workflow_bodyallowExternal);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["allow_external"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyincludeImages != null)
                {
                    if (__workflow_bodyincludeImages != null)
                    {
                        body["include_images"] = ExpressionConverter.ConvertO(__workflow_bodyincludeImages);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_images"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodycategories != null)
                {
                    body["categories"] = ExpressionConverter.ConvertO(__workflow_bodycategories);
                    bodypropCount++;
                }

                if (__workflow_bodyextractDepth != null)
                {
                    if (__workflow_bodyextractDepth != null)
                    {
                        body["extract_depth"] = ExpressionConverter.ConvertO(__workflow_bodyextractDepth);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["extract_depth"] = "basic";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CrawlPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<MapPostResponse> Map(Expression<Func<string>> bodyurl, Expression<Func<int>> bodymaxDepth = null, Expression<Func<int>> bodymaxBreadth = null, Expression<Func<int>> bodylimit = null, Expression<Func<string>> bodyinstructions = null, Expression<Func<string[]>> bodyselectPaths = null, Expression<Func<string[]>> bodyselectDomains = null, Expression<Func<string[]>> bodyexcludePaths = null, Expression<Func<string[]>> bodyexcludeDomains = null, Expression<Func<bool>> bodyallowExternal = null, Expression<Func<bodycategoriesInputItem[]>> bodycategories = null)
        {
            var __workflow_bodyurl = bodyurl == null ? null : WorkflowExpression.Compile(bodyurl);
            WorkflowExpression.Validate(__workflow_bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodymaxDepth = bodymaxDepth == null ? null : WorkflowExpression.Compile(bodymaxDepth);
            WorkflowExpression.Validate(__workflow_bodymaxDepth, nameof(bodymaxDepth), required: false);
            var __workflow_bodymaxBreadth = bodymaxBreadth == null ? null : WorkflowExpression.Compile(bodymaxBreadth);
            WorkflowExpression.Validate(__workflow_bodymaxBreadth, nameof(bodymaxBreadth), required: false);
            var __workflow_bodylimit = bodylimit == null ? null : WorkflowExpression.Compile(bodylimit);
            WorkflowExpression.Validate(__workflow_bodylimit, nameof(bodylimit), required: false);
            var __workflow_bodyinstructions = bodyinstructions == null ? null : WorkflowExpression.Compile(bodyinstructions);
            WorkflowExpression.Validate(__workflow_bodyinstructions, nameof(bodyinstructions), required: false);
            var __workflow_bodyselectPaths = bodyselectPaths == null ? null : WorkflowExpression.Compile(bodyselectPaths);
            WorkflowExpression.Validate(__workflow_bodyselectPaths, nameof(bodyselectPaths), required: false);
            var __workflow_bodyselectDomains = bodyselectDomains == null ? null : WorkflowExpression.Compile(bodyselectDomains);
            WorkflowExpression.Validate(__workflow_bodyselectDomains, nameof(bodyselectDomains), required: false);
            var __workflow_bodyexcludePaths = bodyexcludePaths == null ? null : WorkflowExpression.Compile(bodyexcludePaths);
            WorkflowExpression.Validate(__workflow_bodyexcludePaths, nameof(bodyexcludePaths), required: false);
            var __workflow_bodyexcludeDomains = bodyexcludeDomains == null ? null : WorkflowExpression.Compile(bodyexcludeDomains);
            WorkflowExpression.Validate(__workflow_bodyexcludeDomains, nameof(bodyexcludeDomains), required: false);
            var __workflow_bodyallowExternal = bodyallowExternal == null ? null : WorkflowExpression.Compile(bodyallowExternal);
            WorkflowExpression.Validate(__workflow_bodyallowExternal, nameof(bodyallowExternal), required: false);
            var __workflow_bodycategories = bodycategories == null ? null : WorkflowExpression.Compile(bodycategories);
            WorkflowExpression.Validate(__workflow_bodycategories, nameof(bodycategories), required: false);
            return new DeferredBodyAction<MapPostResponse>(() =>
            {
                var apiCallPath = "/map";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodymaxDepth != null)
                {
                    if (__workflow_bodymaxDepth != null)
                    {
                        body["max_depth"] = ExpressionConverter.ConvertO(__workflow_bodymaxDepth);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_depth"] = 1;
                    bodypropCount++;
                }

                if (__workflow_bodymaxBreadth != null)
                {
                    if (__workflow_bodymaxBreadth != null)
                    {
                        body["max_breadth"] = ExpressionConverter.ConvertO(__workflow_bodymaxBreadth);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_breadth"] = 20;
                    bodypropCount++;
                }

                if (__workflow_bodylimit != null)
                {
                    if (__workflow_bodylimit != null)
                    {
                        body["limit"] = ExpressionConverter.ConvertO(__workflow_bodylimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["limit"] = 50;
                    bodypropCount++;
                }

                if (__workflow_bodyinstructions != null)
                {
                    body["instructions"] = ExpressionConverter.ConvertO(__workflow_bodyinstructions);
                    bodypropCount++;
                }

                if (__workflow_bodyselectPaths != null)
                {
                    body["select_paths"] = ExpressionConverter.ConvertO(__workflow_bodyselectPaths);
                    bodypropCount++;
                }

                if (__workflow_bodyselectDomains != null)
                {
                    body["select_domains"] = ExpressionConverter.ConvertO(__workflow_bodyselectDomains);
                    bodypropCount++;
                }

                if (__workflow_bodyexcludePaths != null)
                {
                    body["exclude_paths"] = ExpressionConverter.ConvertO(__workflow_bodyexcludePaths);
                    bodypropCount++;
                }

                if (__workflow_bodyexcludeDomains != null)
                {
                    body["exclude_domains"] = ExpressionConverter.ConvertO(__workflow_bodyexcludeDomains);
                    bodypropCount++;
                }

                if (__workflow_bodyallowExternal != null)
                {
                    if (__workflow_bodyallowExternal != null)
                    {
                        body["allow_external"] = ExpressionConverter.ConvertO(__workflow_bodyallowExternal);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["allow_external"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodycategories != null)
                {
                    body["categories"] = ExpressionConverter.ConvertO(__workflow_bodycategories);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytopicInput
    {
        [EnumMember(Value = "general")]
        General,
        [EnumMember(Value = "news")]
        News
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysearchDepthInput
    {
        [EnumMember(Value = "basic")]
        Basic,
        [EnumMember(Value = "advanced")]
        Advanced
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
