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
        public IBodyWorkflowAction<SearchPostResponse> Search([WorkflowExpression] Func<string> bodyquery, [WorkflowExpression] Func<bodytopicInput> bodytopic = null, [WorkflowExpression] Func<bodysearchDepthInput> bodysearchDepth = null, [WorkflowExpression] Func<int> bodychunksPerSource = null, [WorkflowExpression] Func<int> bodymaxResults = null, [WorkflowExpression] Func<bodytimeRangeInput> bodytimeRange = null, [WorkflowExpression] Func<int> bodydays = null, [WorkflowExpression] Func<bool> bodyincludeAnswer = null, [WorkflowExpression] Func<bool> bodyincludeRawContent = null, [WorkflowExpression] Func<bool> bodyincludeImages = null, [WorkflowExpression] Func<bool> bodyincludeImageDescriptions = null, [WorkflowExpression] Func<string[]> bodyincludeDomains = null, [WorkflowExpression] Func<string[]> bodyexcludeDomains = null)
        {
            SourceExpression.Validate(bodyquery, nameof(bodyquery), required: true);
            SourceExpression.Validate(bodytopic, nameof(bodytopic), required: false);
            SourceExpression.Validate(bodysearchDepth, nameof(bodysearchDepth), required: false);
            SourceExpression.Validate(bodychunksPerSource, nameof(bodychunksPerSource), required: false);
            SourceExpression.Validate(bodymaxResults, nameof(bodymaxResults), required: false);
            SourceExpression.Validate(bodytimeRange, nameof(bodytimeRange), required: false);
            SourceExpression.Validate(bodydays, nameof(bodydays), required: false);
            SourceExpression.Validate(bodyincludeAnswer, nameof(bodyincludeAnswer), required: false);
            SourceExpression.Validate(bodyincludeRawContent, nameof(bodyincludeRawContent), required: false);
            SourceExpression.Validate(bodyincludeImages, nameof(bodyincludeImages), required: false);
            SourceExpression.Validate(bodyincludeImageDescriptions, nameof(bodyincludeImageDescriptions), required: false);
            SourceExpression.Validate(bodyincludeDomains, nameof(bodyincludeDomains), required: false);
            SourceExpression.Validate(bodyexcludeDomains, nameof(bodyexcludeDomains), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["query"] = SourceExpressionConverter.ConvertToken(bodyquery);
                if (bodytopic != null)
                {
                    if (bodytopic != null)
                    {
                        body["topic"] = SourceExpressionConverter.Convert(bodytopic);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["topic"] = "general";
                    bodypropCount++;
                }

                if (bodysearchDepth != null)
                {
                    if (bodysearchDepth != null)
                    {
                        body["search_depth"] = SourceExpressionConverter.Convert(bodysearchDepth);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["search_depth"] = "basic";
                    bodypropCount++;
                }

                if (bodychunksPerSource != null)
                {
                    body["chunks_per_source"] = SourceExpressionConverter.ConvertToken(bodychunksPerSource);
                    bodypropCount++;
                }

                if (bodymaxResults != null)
                {
                    if (bodymaxResults != null)
                    {
                        body["max_results"] = SourceExpressionConverter.ConvertToken(bodymaxResults);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_results"] = 5;
                    bodypropCount++;
                }

                if (bodytimeRange != null)
                {
                    body["time_range"] = SourceExpressionConverter.Convert(bodytimeRange);
                    bodypropCount++;
                }

                if (bodydays != null)
                {
                    if (bodydays != null)
                    {
                        body["days"] = SourceExpressionConverter.ConvertToken(bodydays);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["days"] = 7;
                    bodypropCount++;
                }

                if (bodyincludeAnswer != null)
                {
                    if (bodyincludeAnswer != null)
                    {
                        body["include_answer"] = SourceExpressionConverter.ConvertToken(bodyincludeAnswer);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_answer"] = false;
                    bodypropCount++;
                }

                if (bodyincludeRawContent != null)
                {
                    if (bodyincludeRawContent != null)
                    {
                        body["include_raw_content"] = SourceExpressionConverter.ConvertToken(bodyincludeRawContent);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_raw_content"] = false;
                    bodypropCount++;
                }

                if (bodyincludeImages != null)
                {
                    if (bodyincludeImages != null)
                    {
                        body["include_images"] = SourceExpressionConverter.ConvertToken(bodyincludeImages);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_images"] = false;
                    bodypropCount++;
                }

                if (bodyincludeImageDescriptions != null)
                {
                    body["include_image_descriptions"] = SourceExpressionConverter.ConvertToken(bodyincludeImageDescriptions);
                    bodypropCount++;
                }

                if (bodyincludeDomains != null)
                {
                    body["include_domains"] = SourceExpressionConverter.ConvertToken(bodyincludeDomains);
                    bodypropCount++;
                }

                if (bodyexcludeDomains != null)
                {
                    body["exclude_domains"] = SourceExpressionConverter.ConvertToken(bodyexcludeDomains);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SearchPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<ExtractPostResponse> Extract([WorkflowExpression] Func<string> bodyurls, [WorkflowExpression] Func<bool> bodyincludeImages = null, [WorkflowExpression] Func<bodyextractDepthInput> bodyextractDepth = null)
        {
            SourceExpression.Validate(bodyurls, nameof(bodyurls), required: true);
            SourceExpression.Validate(bodyincludeImages, nameof(bodyincludeImages), required: false);
            SourceExpression.Validate(bodyextractDepth, nameof(bodyextractDepth), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/extract";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["urls"] = SourceExpressionConverter.ConvertToken(bodyurls);
                if (bodyincludeImages != null)
                {
                    if (bodyincludeImages != null)
                    {
                        body["include_images"] = SourceExpressionConverter.ConvertToken(bodyincludeImages);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_images"] = false;
                    bodypropCount++;
                }

                if (bodyextractDepth != null)
                {
                    if (bodyextractDepth != null)
                    {
                        body["extract_depth"] = SourceExpressionConverter.Convert(bodyextractDepth);
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
                return callPayload;
            }

            return new ApiConnectionAction<ExtractPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<CrawlPostResponse> Crawl([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<int> bodymaxDepth = null, [WorkflowExpression] Func<int> bodymaxBreadth = null, [WorkflowExpression] Func<int> bodylimit = null, [WorkflowExpression] Func<string> bodyinstructions = null, [WorkflowExpression] Func<string[]> bodyselectPaths = null, [WorkflowExpression] Func<string[]> bodyselectDomains = null, [WorkflowExpression] Func<string[]> bodyexcludePaths = null, [WorkflowExpression] Func<string[]> bodyexcludeDomains = null, [WorkflowExpression] Func<bool> bodyallowExternal = null, [WorkflowExpression] Func<bool> bodyincludeImages = null, [WorkflowExpression] Func<string[]> bodycategories = null, [WorkflowExpression] Func<bodyextractDepthInput> bodyextractDepth = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodymaxDepth, nameof(bodymaxDepth), required: false);
            SourceExpression.Validate(bodymaxBreadth, nameof(bodymaxBreadth), required: false);
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            SourceExpression.Validate(bodyinstructions, nameof(bodyinstructions), required: false);
            SourceExpression.Validate(bodyselectPaths, nameof(bodyselectPaths), required: false);
            SourceExpression.Validate(bodyselectDomains, nameof(bodyselectDomains), required: false);
            SourceExpression.Validate(bodyexcludePaths, nameof(bodyexcludePaths), required: false);
            SourceExpression.Validate(bodyexcludeDomains, nameof(bodyexcludeDomains), required: false);
            SourceExpression.Validate(bodyallowExternal, nameof(bodyallowExternal), required: false);
            SourceExpression.Validate(bodyincludeImages, nameof(bodyincludeImages), required: false);
            SourceExpression.Validate(bodycategories, nameof(bodycategories), required: false);
            SourceExpression.Validate(bodyextractDepth, nameof(bodyextractDepth), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/crawl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodymaxDepth != null)
                {
                    body["max_depth"] = SourceExpressionConverter.ConvertToken(bodymaxDepth);
                    bodypropCount++;
                }

                if (bodymaxBreadth != null)
                {
                    if (bodymaxBreadth != null)
                    {
                        body["max_breadth"] = SourceExpressionConverter.ConvertToken(bodymaxBreadth);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_breadth"] = 20;
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    if (bodylimit != null)
                    {
                        body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["limit"] = 50;
                    bodypropCount++;
                }

                if (bodyinstructions != null)
                {
                    body["instructions"] = SourceExpressionConverter.ConvertToken(bodyinstructions);
                    bodypropCount++;
                }

                if (bodyselectPaths != null)
                {
                    body["select_paths"] = SourceExpressionConverter.ConvertToken(bodyselectPaths);
                    bodypropCount++;
                }

                if (bodyselectDomains != null)
                {
                    body["select_domains"] = SourceExpressionConverter.ConvertToken(bodyselectDomains);
                    bodypropCount++;
                }

                if (bodyexcludePaths != null)
                {
                    body["exclude_paths"] = SourceExpressionConverter.ConvertToken(bodyexcludePaths);
                    bodypropCount++;
                }

                if (bodyexcludeDomains != null)
                {
                    body["exclude_domains"] = SourceExpressionConverter.ConvertToken(bodyexcludeDomains);
                    bodypropCount++;
                }

                if (bodyallowExternal != null)
                {
                    if (bodyallowExternal != null)
                    {
                        body["allow_external"] = SourceExpressionConverter.ConvertToken(bodyallowExternal);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["allow_external"] = false;
                    bodypropCount++;
                }

                if (bodyincludeImages != null)
                {
                    if (bodyincludeImages != null)
                    {
                        body["include_images"] = SourceExpressionConverter.ConvertToken(bodyincludeImages);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["include_images"] = false;
                    bodypropCount++;
                }

                if (bodycategories != null)
                {
                    body["categories"] = SourceExpressionConverter.ConvertToken(bodycategories);
                    bodypropCount++;
                }

                if (bodyextractDepth != null)
                {
                    if (bodyextractDepth != null)
                    {
                        body["extract_depth"] = SourceExpressionConverter.Convert(bodyextractDepth);
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
                return callPayload;
            }

            return new ApiConnectionAction<CrawlPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tavily")]
        public IBodyWorkflowAction<MapPostResponse> Map([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<int> bodymaxDepth = null, [WorkflowExpression] Func<int> bodymaxBreadth = null, [WorkflowExpression] Func<int> bodylimit = null, [WorkflowExpression] Func<string> bodyinstructions = null, [WorkflowExpression] Func<string[]> bodyselectPaths = null, [WorkflowExpression] Func<string[]> bodyselectDomains = null, [WorkflowExpression] Func<string[]> bodyexcludePaths = null, [WorkflowExpression] Func<string[]> bodyexcludeDomains = null, [WorkflowExpression] Func<bool> bodyallowExternal = null, [WorkflowExpression] Func<bodycategoriesInputItem[]> bodycategories = null)
        {
            SourceExpression.Validate(bodyurl, nameof(bodyurl), required: true);
            SourceExpression.Validate(bodymaxDepth, nameof(bodymaxDepth), required: false);
            SourceExpression.Validate(bodymaxBreadth, nameof(bodymaxBreadth), required: false);
            SourceExpression.Validate(bodylimit, nameof(bodylimit), required: false);
            SourceExpression.Validate(bodyinstructions, nameof(bodyinstructions), required: false);
            SourceExpression.Validate(bodyselectPaths, nameof(bodyselectPaths), required: false);
            SourceExpression.Validate(bodyselectDomains, nameof(bodyselectDomains), required: false);
            SourceExpression.Validate(bodyexcludePaths, nameof(bodyexcludePaths), required: false);
            SourceExpression.Validate(bodyexcludeDomains, nameof(bodyexcludeDomains), required: false);
            SourceExpression.Validate(bodyallowExternal, nameof(bodyallowExternal), required: false);
            SourceExpression.Validate(bodycategories, nameof(bodycategories), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/map";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                if (bodymaxDepth != null)
                {
                    if (bodymaxDepth != null)
                    {
                        body["max_depth"] = SourceExpressionConverter.ConvertToken(bodymaxDepth);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_depth"] = 1;
                    bodypropCount++;
                }

                if (bodymaxBreadth != null)
                {
                    if (bodymaxBreadth != null)
                    {
                        body["max_breadth"] = SourceExpressionConverter.ConvertToken(bodymaxBreadth);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_breadth"] = 20;
                    bodypropCount++;
                }

                if (bodylimit != null)
                {
                    if (bodylimit != null)
                    {
                        body["limit"] = SourceExpressionConverter.ConvertToken(bodylimit);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["limit"] = 50;
                    bodypropCount++;
                }

                if (bodyinstructions != null)
                {
                    body["instructions"] = SourceExpressionConverter.ConvertToken(bodyinstructions);
                    bodypropCount++;
                }

                if (bodyselectPaths != null)
                {
                    body["select_paths"] = SourceExpressionConverter.ConvertToken(bodyselectPaths);
                    bodypropCount++;
                }

                if (bodyselectDomains != null)
                {
                    body["select_domains"] = SourceExpressionConverter.ConvertToken(bodyselectDomains);
                    bodypropCount++;
                }

                if (bodyexcludePaths != null)
                {
                    body["exclude_paths"] = SourceExpressionConverter.ConvertToken(bodyexcludePaths);
                    bodypropCount++;
                }

                if (bodyexcludeDomains != null)
                {
                    body["exclude_domains"] = SourceExpressionConverter.ConvertToken(bodyexcludeDomains);
                    bodypropCount++;
                }

                if (bodyallowExternal != null)
                {
                    if (bodyallowExternal != null)
                    {
                        body["allow_external"] = SourceExpressionConverter.ConvertToken(bodyallowExternal);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["allow_external"] = false;
                    bodypropCount++;
                }

                if (bodycategories != null)
                {
                    body["categories"] = SourceExpressionConverter.ConvertToken(bodycategories);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MapPostResponse>(BuildSourceInput);
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