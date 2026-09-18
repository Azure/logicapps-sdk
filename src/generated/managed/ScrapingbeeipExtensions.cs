//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Scrapingbeeip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ScrapingbeeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scrapingbeeip")]
        public IBodyWorkflowAction<HTMLResponse> HTML([WorkflowExpression] Func<string> url, [WorkflowExpression] Func<bool> renderJs, [WorkflowExpression] Func<string> jsScenario = null, [WorkflowExpression] Func<int> wait = null, [WorkflowExpression] Func<string> waitFor = null, [WorkflowExpression] Func<bool> blockAds = null, [WorkflowExpression] Func<bool> blockResources = null, [WorkflowExpression] Func<int> windowWidth = null, [WorkflowExpression] Func<int> windowHeight = null, [WorkflowExpression] Func<bool> premiumProxy = null, [WorkflowExpression] Func<string> countryCode = null, [WorkflowExpression] Func<bool> stealthProxy = null, [WorkflowExpression] Func<string> ownProxy = null, [WorkflowExpression] Func<string> extractRules = null, [WorkflowExpression] Func<bool> screenshot = null, [WorkflowExpression] Func<string> screenshotSelector = null, [WorkflowExpression] Func<bool> screenshotFullPage = null, [WorkflowExpression] Func<bool> returnPageSource = null, [WorkflowExpression] Func<int> sessionId = null, [WorkflowExpression] Func<int> timeout = null, [WorkflowExpression] Func<string> cookies = null, [WorkflowExpression] Func<deviceInput> device = null, [WorkflowExpression] Func<bool> customGoogle = null)
        {
            SourceExpression.Validate(url, nameof(url), required: true);
            SourceExpression.Validate(renderJs, nameof(renderJs), required: true);
            SourceExpression.Validate(jsScenario, nameof(jsScenario), required: false);
            SourceExpression.Validate(wait, nameof(wait), required: false);
            SourceExpression.Validate(waitFor, nameof(waitFor), required: false);
            SourceExpression.Validate(blockAds, nameof(blockAds), required: false);
            SourceExpression.Validate(blockResources, nameof(blockResources), required: false);
            SourceExpression.Validate(windowWidth, nameof(windowWidth), required: false);
            SourceExpression.Validate(windowHeight, nameof(windowHeight), required: false);
            SourceExpression.Validate(premiumProxy, nameof(premiumProxy), required: false);
            SourceExpression.Validate(countryCode, nameof(countryCode), required: false);
            SourceExpression.Validate(stealthProxy, nameof(stealthProxy), required: false);
            SourceExpression.Validate(ownProxy, nameof(ownProxy), required: false);
            SourceExpression.Validate(extractRules, nameof(extractRules), required: false);
            SourceExpression.Validate(screenshot, nameof(screenshot), required: false);
            SourceExpression.Validate(screenshotSelector, nameof(screenshotSelector), required: false);
            SourceExpression.Validate(screenshotFullPage, nameof(screenshotFullPage), required: false);
            SourceExpression.Validate(returnPageSource, nameof(returnPageSource), required: false);
            SourceExpression.Validate(sessionId, nameof(sessionId), required: false);
            SourceExpression.Validate(timeout, nameof(timeout), required: false);
            SourceExpression.Validate(cookies, nameof(cookies), required: false);
            SourceExpression.Validate(device, nameof(device), required: false);
            SourceExpression.Validate(customGoogle, nameof(customGoogle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                callPayload.Queries["render_js"] = SourceExpressionConverter.ConvertO(renderJs);
                if (jsScenario != null)
                    callPayload.Queries["js_scenario"] = SourceExpressionConverter.ConvertO(jsScenario);
                if (wait != null)
                    callPayload.Queries["wait"] = SourceExpressionConverter.ConvertO(wait);
                if (waitFor != null)
                    callPayload.Queries["wait_for"] = SourceExpressionConverter.ConvertO(waitFor);
                if (blockAds != null)
                    callPayload.Queries["block_ads"] = SourceExpressionConverter.ConvertO(blockAds);
                if (blockResources != null)
                    callPayload.Queries["block_resources"] = SourceExpressionConverter.ConvertO(blockResources);
                if (windowWidth != null)
                    callPayload.Queries["window_width"] = SourceExpressionConverter.ConvertO(windowWidth);
                if (windowHeight != null)
                    callPayload.Queries["window_height"] = SourceExpressionConverter.ConvertO(windowHeight);
                if (premiumProxy != null)
                    callPayload.Queries["premium_proxy"] = SourceExpressionConverter.ConvertO(premiumProxy);
                if (countryCode != null)
                    callPayload.Queries["country_code"] = SourceExpressionConverter.ConvertO(countryCode);
                if (stealthProxy != null)
                    callPayload.Queries["stealth_proxy"] = SourceExpressionConverter.ConvertO(stealthProxy);
                if (ownProxy != null)
                    callPayload.Queries["own_proxy"] = SourceExpressionConverter.ConvertO(ownProxy);
                if (extractRules != null)
                    callPayload.Queries["extract_rules"] = SourceExpressionConverter.ConvertO(extractRules);
                if (screenshot != null)
                    callPayload.Queries["screenshot"] = SourceExpressionConverter.ConvertO(screenshot);
                if (screenshotSelector != null)
                    callPayload.Queries["screenshot_selector"] = SourceExpressionConverter.ConvertO(screenshotSelector);
                if (screenshotFullPage != null)
                    callPayload.Queries["screenshot_full_page"] = SourceExpressionConverter.ConvertO(screenshotFullPage);
                callPayload.Queries["json_response"] = Convert.ToString(true);
                if (returnPageSource != null)
                    callPayload.Queries["return_page_source"] = SourceExpressionConverter.ConvertO(returnPageSource);
                if (sessionId != null)
                    callPayload.Queries["session_id"] = SourceExpressionConverter.ConvertO(sessionId);
                if (timeout != null)
                    callPayload.Queries["timeout"] = SourceExpressionConverter.ConvertO(timeout);
                if (cookies != null)
                    callPayload.Queries["cookies"] = SourceExpressionConverter.ConvertO(cookies);
                callPayload.Queries["device"] = Convert.ToString("desktop");
                if (device != null)
                    callPayload.Queries["device"] = SourceExpressionConverter.Convert(device);
                if (customGoogle != null)
                    callPayload.Queries["custom_google"] = SourceExpressionConverter.ConvertO(customGoogle);
                return callPayload;
            }

            return new ApiConnectionAction<HTMLResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scrapingbeeip")]
        public IBodyWorkflowAction<UsageInformationResponse> UsageInformation()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/usage";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UsageInformationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scrapingbeeip")]
        public IBodyWorkflowAction<SimpleSearchResponse> SimpleSearch([WorkflowExpression] Func<string> search, [WorkflowExpression] Func<string> countryCode = null, [WorkflowExpression] Func<int> nbResults = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> language = null, [WorkflowExpression] Func<string> extraParams = null)
        {
            SourceExpression.Validate(search, nameof(search), required: true);
            SourceExpression.Validate(countryCode, nameof(countryCode), required: false);
            SourceExpression.Validate(nbResults, nameof(nbResults), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(language, nameof(language), required: false);
            SourceExpression.Validate(extraParams, nameof(extraParams), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/store/google";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (countryCode != null)
                    callPayload.Queries["country_code"] = SourceExpressionConverter.ConvertO(countryCode);
                if (nbResults != null)
                    callPayload.Queries["nb_results"] = SourceExpressionConverter.ConvertO(nbResults);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (language != null)
                    callPayload.Queries["language"] = SourceExpressionConverter.ConvertO(language);
                if (extraParams != null)
                    callPayload.Queries["extra_params"] = SourceExpressionConverter.ConvertO(extraParams);
                return callPayload;
            }

            return new ApiConnectionAction<SimpleSearchResponse>(BuildSourceInput);
        }
    }

    public class ScrapingbeeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class HTMLResponse
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("cookies")]
        public HTMLResponseCookiesTypeItem[] Cookies { get; set; }

        [JsonProperty("evaluate_results")]
        public string[] EvaluateResults { get; set; }

        [JsonProperty("js_scenario_report")]
        public JToken JsScenarioReport { get; set; }

        [JsonProperty("headers")]
        public HTMLResponseHeadersType Headers { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("iframes")]
        public string[] Iframes { get; set; }

        [JsonProperty("xhr")]
        public HTMLResponseXhrTypeItem[] Xhr { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("initial-status-code")]
        public int InitialStatusCode { get; set; }

        [JsonProperty("resolved-url")]
        public string ResolvedUrl { get; set; }

        [JsonProperty("metadata")]
        public HTMLResponseMetadataType Metadata { get; set; }
    }

    public class HTMLResponseCookiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("expires")]
        public double Expires { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("httpOnly")]
        public bool HttpOnly { get; set; }

        [JsonProperty("secure")]
        public bool Secure { get; set; }

        [JsonProperty("session")]
        public bool Session { get; set; }

        [JsonProperty("sameParty")]
        public bool SameParty { get; set; }

        [JsonProperty("sourceScheme")]
        public string SourceScheme { get; set; }

        [JsonProperty("sourcePort")]
        public int SourcePort { get; set; }
    }

    public class HTMLResponseHeadersType
    {
        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("cache-control")]
        public string CacheControl { get; set; }

        [JsonProperty("content-encoding")]
        public string ContentEncoding { get; set; }

        [JsonProperty("content-security-policy")]
        public string ContentSecurityPolicy { get; set; }

        [JsonProperty("content-type")]
        public string ContentType { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("referrer-policy")]
        public string ReferrerPolicy { get; set; }

        [JsonProperty("server")]
        public string Server { get; set; }

        [JsonProperty("strict-transport-security")]
        public string StrictTransportSecurity { get; set; }

        [JsonProperty("x-content-type-options")]
        public string XContentTypeOptions { get; set; }

        [JsonProperty("x-frame-options")]
        public string XFrameOptions { get; set; }

        [JsonProperty("x-matched-path")]
        public string XMatchedPath { get; set; }

        [JsonProperty("x-powered-by")]
        public string XPoweredBy { get; set; }

        [JsonProperty("x-vercel-cache")]
        public string XVercelCache { get; set; }

        [JsonProperty("x-vercel-id")]
        public string XVercelId { get; set; }
    }

    public class HTMLResponseXhrTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("headers")]
        public HTMLResponseXhrTypeItemHeadersType Headers { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class HTMLResponseXhrTypeItemHeadersType
    {
        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("cache-control")]
        public string CacheControl { get; set; }

        [JsonProperty("content-length")]
        public string ContentLength { get; set; }

        [JsonProperty("content-security-policy")]
        public string ContentSecurityPolicy { get; set; }

        [JsonProperty("content-type")]
        public string ContentType { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("referrer-policy")]
        public string ReferrerPolicy { get; set; }

        [JsonProperty("server")]
        public string Server { get; set; }

        [JsonProperty("strict-transport-security")]
        public string StrictTransportSecurity { get; set; }

        [JsonProperty("x-content-type-options")]
        public string XContentTypeOptions { get; set; }

        [JsonProperty("x-frame-options")]
        public string XFrameOptions { get; set; }

        [JsonProperty("x-matched-path")]
        public string XMatchedPath { get; set; }

        [JsonProperty("x-vercel-cache")]
        public string XVercelCache { get; set; }

        [JsonProperty("x-vercel-id")]
        public string XVercelId { get; set; }

        [JsonProperty("access-control-allow-origin")]
        public string AccessControlAllowOrigin { get; set; }

        [JsonProperty("access-control-expose-headers")]
        public string AccessControlExposeHeaders { get; set; }

        [JsonProperty("alt-svc")]
        public string AltSvc { get; set; }

        [JsonProperty("vary")]
        public string Vary { get; set; }

        [JsonProperty("via")]
        public string Via { get; set; }

        [JsonProperty("x-envoy-upstream-service-time")]
        public string XEnvoyUpstreamServiceTime { get; set; }

        [JsonProperty("x-amzn-requestid")]
        public string XAmznRequestid { get; set; }

        [JsonProperty("x-amzn-trace-id")]
        public string XAmznTraceId { get; set; }
    }

    public class HTMLResponseMetadataType
    {
        [JsonProperty("microdata")]
        public string[] Microdata { get; set; }

        [JsonProperty("json-ld")]
        public HTMLResponseMetadataTypeJsonLdTypeItem[] JsonLd { get; set; }

        [JsonProperty("opengraph")]
        public HTMLResponseMetadataTypeOpengraphTypeItem[] Opengraph { get; set; }

        [JsonProperty("dublincore")]
        public HTMLResponseMetadataTypeDublincoreTypeItem[] Dublincore { get; set; }
    }

    public class HTMLResponseMetadataTypeJsonLdTypeItem
    {
        [JsonProperty("@context")]
        public string Context { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mainEntityOfPage")]
        public HTMLResponseMetadataTypeJsonLdTypeItemMainEntityOfPageType MainEntityOfPage { get; set; }

        [JsonProperty("image")]
        public HTMLResponseMetadataTypeJsonLdTypeItemImageType Image { get; set; }

        [JsonProperty("publisher")]
        public HTMLResponseMetadataTypeJsonLdTypeItemPublisherType Publisher { get; set; }

        [JsonProperty("sameAs")]
        public string SameAs { get; set; }
    }

    public class HTMLResponseMetadataTypeJsonLdTypeItemMainEntityOfPageType
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class HTMLResponseMetadataTypeJsonLdTypeItemImageType
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class HTMLResponseMetadataTypeJsonLdTypeItemPublisherType
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class HTMLResponseMetadataTypeOpengraphTypeItem
    {
        [JsonProperty("og:title")]
        public string OgTitle { get; set; }

        [JsonProperty("og:description")]
        public string OgDescription { get; set; }

        [JsonProperty("og:site_name")]
        public string OgSiteName { get; set; }

        [JsonProperty("og:url")]
        public string OgUrl { get; set; }

        [JsonProperty("og:image")]
        public string OgImage { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("@context")]
        public HTMLResponseMetadataTypeOpengraphTypeItemContextType Context { get; set; }
    }

    public class HTMLResponseMetadataTypeOpengraphTypeItemContextType
    {
        [JsonProperty("og")]
        public string Og { get; set; }
    }

    public class HTMLResponseMetadataTypeDublincoreTypeItem
    {
        [JsonProperty("elements")]
        public HTMLResponseMetadataTypeDublincoreTypeItemElementsTypeItem[] Elements { get; set; }

        [JsonProperty("terms")]
        public string[] Terms { get; set; }

        [JsonProperty("@context")]
        public JToken Context { get; set; }
    }

    public class HTMLResponseMetadataTypeDublincoreTypeItemElementsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
        public string URI { get; set; }
    }

    public enum deviceInput
    {
        [EnumMember(Value = "desktop")]
        Desktop,
        [EnumMember(Value = "mobile")]
        Mobile
    }

    public class UsageInformationResponse
    {
        [JsonProperty("max_api_credit")]
        public int MaxApiCredit { get; set; }

        [JsonProperty("used_api_credit")]
        public int UsedApiCredit { get; set; }

        [JsonProperty("max_concurrency")]
        public int MaxConcurrency { get; set; }

        [JsonProperty("current_concurrency")]
        public int CurrentConcurrency { get; set; }

        [JsonProperty("renewal_subscription_date")]
        public string RenewalSubscriptionDate { get; set; }
    }

    public class SimpleSearchResponse
    {
        [JsonProperty("meta_data")]
        public SimpleSearchResponseMetaDataType MetaData { get; set; }

        [JsonProperty("organic_results")]
        public SimpleSearchResponseOrganicResultsTypeItem[] OrganicResults { get; set; }

        [JsonProperty("local_results")]
        public string[] LocalResults { get; set; }

        [JsonProperty("top_ads")]
        public string TopAds { get; set; }

        [JsonProperty("bottom_ads")]
        public string BottomAds { get; set; }

        [JsonProperty("related_queries")]
        public SimpleSearchResponseRelatedQueriesTypeItem[] RelatedQueries { get; set; }

        [JsonProperty("questions")]
        public string[] Questions { get; set; }
    }

    public class SimpleSearchResponseMetaDataType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("number_of_results")]
        public int NumberOfResults { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("number_of_organic_results")]
        public int NumberOfOrganicResults { get; set; }

        [JsonProperty("number_of_ads")]
        public int NumberOfAds { get; set; }

        [JsonProperty("number_of_page")]
        public int NumberOfPage { get; set; }

        [JsonProperty("no_results_message")]
        public string NoResultsMessage { get; set; }
    }

    public class SimpleSearchResponseOrganicResultsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("displayed_url")]
        public string DisplayedUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("extra_info")]
        public string ExtraInfo { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SimpleSearchResponseRelatedQueriesTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Scrapingbeeip;

    public partial class WorkflowManagedActions
    {
        public ScrapingbeeipActions Scrapingbeeip(string connectionId) => new ScrapingbeeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ScrapingbeeipTriggers Scrapingbeeip(string connectionId) => new ScrapingbeeipTriggers(connectionId);
    }
}