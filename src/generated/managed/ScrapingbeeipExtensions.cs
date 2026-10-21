//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Scrapingbeeip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ScrapingbeeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scrapingbeeip")]
        public IBodyWorkflowAction<HTMLResponse> HTML(Expression<Func<string>> url, Expression<Func<bool>> renderJs, Expression<Func<string>> jsScenario = null, Expression<Func<int>> wait = null, Expression<Func<string>> waitFor = null, Expression<Func<bool>> blockAds = null, Expression<Func<bool>> blockResources = null, Expression<Func<int>> windowWidth = null, Expression<Func<int>> windowHeight = null, Expression<Func<bool>> premiumProxy = null, Expression<Func<string>> countryCode = null, Expression<Func<bool>> stealthProxy = null, Expression<Func<string>> ownProxy = null, Expression<Func<string>> extractRules = null, Expression<Func<bool>> screenshot = null, Expression<Func<string>> screenshotSelector = null, Expression<Func<bool>> screenshotFullPage = null, Expression<Func<bool>> returnPageSource = null, Expression<Func<int>> sessionId = null, Expression<Func<int>> timeout = null, Expression<Func<string>> cookies = null, Expression<Func<deviceInput>> device = null, Expression<Func<bool>> customGoogle = null)
        {
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: true);
            var __workflow_renderJs = WorkflowExpression.Compile(renderJs, nameof(renderJs), required: true);
            var __workflow_jsScenario = WorkflowExpression.Compile(jsScenario, nameof(jsScenario), required: false);
            var __workflow_wait = WorkflowExpression.Compile(wait, nameof(wait), required: false);
            var __workflow_waitFor = WorkflowExpression.Compile(waitFor, nameof(waitFor), required: false);
            var __workflow_blockAds = WorkflowExpression.Compile(blockAds, nameof(blockAds), required: false);
            var __workflow_blockResources = WorkflowExpression.Compile(blockResources, nameof(blockResources), required: false);
            var __workflow_windowWidth = WorkflowExpression.Compile(windowWidth, nameof(windowWidth), required: false);
            var __workflow_windowHeight = WorkflowExpression.Compile(windowHeight, nameof(windowHeight), required: false);
            var __workflow_premiumProxy = WorkflowExpression.Compile(premiumProxy, nameof(premiumProxy), required: false);
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: false);
            var __workflow_stealthProxy = WorkflowExpression.Compile(stealthProxy, nameof(stealthProxy), required: false);
            var __workflow_ownProxy = WorkflowExpression.Compile(ownProxy, nameof(ownProxy), required: false);
            var __workflow_extractRules = WorkflowExpression.Compile(extractRules, nameof(extractRules), required: false);
            var __workflow_screenshot = WorkflowExpression.Compile(screenshot, nameof(screenshot), required: false);
            var __workflow_screenshotSelector = WorkflowExpression.Compile(screenshotSelector, nameof(screenshotSelector), required: false);
            var __workflow_screenshotFullPage = WorkflowExpression.Compile(screenshotFullPage, nameof(screenshotFullPage), required: false);
            var __workflow_returnPageSource = WorkflowExpression.Compile(returnPageSource, nameof(returnPageSource), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            var __workflow_timeout = WorkflowExpression.Compile(timeout, nameof(timeout), required: false);
            var __workflow_cookies = WorkflowExpression.Compile(cookies, nameof(cookies), required: false);
            var __workflow_device = WorkflowExpression.Compile(device, nameof(device), required: false);
            var __workflow_customGoogle = WorkflowExpression.Compile(customGoogle, nameof(customGoogle), required: false);
            return new DeferredBodyAction<HTMLResponse>(() =>
            {
                var apiCallPath = "/v1";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                callPayload.Queries["render_js"] = ExpressionConverter.Convert(__workflow_renderJs);
                if (__workflow_jsScenario != null)
                    callPayload.Queries["js_scenario"] = ExpressionConverter.Convert(__workflow_jsScenario);
                if (__workflow_wait != null)
                    callPayload.Queries["wait"] = ExpressionConverter.Convert(__workflow_wait);
                if (__workflow_waitFor != null)
                    callPayload.Queries["wait_for"] = ExpressionConverter.Convert(__workflow_waitFor);
                if (__workflow_blockAds != null)
                    callPayload.Queries["block_ads"] = ExpressionConverter.Convert(__workflow_blockAds);
                if (__workflow_blockResources != null)
                    callPayload.Queries["block_resources"] = ExpressionConverter.Convert(__workflow_blockResources);
                if (__workflow_windowWidth != null)
                    callPayload.Queries["window_width"] = ExpressionConverter.Convert(__workflow_windowWidth);
                if (__workflow_windowHeight != null)
                    callPayload.Queries["window_height"] = ExpressionConverter.Convert(__workflow_windowHeight);
                if (__workflow_premiumProxy != null)
                    callPayload.Queries["premium_proxy"] = ExpressionConverter.Convert(__workflow_premiumProxy);
                if (__workflow_countryCode != null)
                    callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                if (__workflow_stealthProxy != null)
                    callPayload.Queries["stealth_proxy"] = ExpressionConverter.Convert(__workflow_stealthProxy);
                if (__workflow_ownProxy != null)
                    callPayload.Queries["own_proxy"] = ExpressionConverter.Convert(__workflow_ownProxy);
                if (__workflow_extractRules != null)
                    callPayload.Queries["extract_rules"] = ExpressionConverter.Convert(__workflow_extractRules);
                if (__workflow_screenshot != null)
                    callPayload.Queries["screenshot"] = ExpressionConverter.Convert(__workflow_screenshot);
                if (__workflow_screenshotSelector != null)
                    callPayload.Queries["screenshot_selector"] = ExpressionConverter.Convert(__workflow_screenshotSelector);
                if (__workflow_screenshotFullPage != null)
                    callPayload.Queries["screenshot_full_page"] = ExpressionConverter.Convert(__workflow_screenshotFullPage);
                callPayload.Queries["json_response"] = Convert.ToString(true);
                if (__workflow_returnPageSource != null)
                    callPayload.Queries["return_page_source"] = ExpressionConverter.Convert(__workflow_returnPageSource);
                if (__workflow_sessionId != null)
                    callPayload.Queries["session_id"] = ExpressionConverter.Convert(__workflow_sessionId);
                if (__workflow_timeout != null)
                    callPayload.Queries["timeout"] = ExpressionConverter.Convert(__workflow_timeout);
                if (__workflow_cookies != null)
                    callPayload.Queries["cookies"] = ExpressionConverter.Convert(__workflow_cookies);
                callPayload.Queries["device"] = Convert.ToString("desktop");
                if (__workflow_device != null)
                    callPayload.Queries["device"] = ExpressionConverter.Convert(__workflow_device);
                if (__workflow_customGoogle != null)
                    callPayload.Queries["custom_google"] = ExpressionConverter.Convert(__workflow_customGoogle);
                return new ApiConnectionAction<HTMLResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scrapingbeeip")]
        public IBodyWorkflowAction<UsageInformationResponse> UsageInformation()
        {
            var apiCallPath = "/v1/usage";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UsageInformationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scrapingbeeip")]
        public IBodyWorkflowAction<SimpleSearchResponse> SimpleSearch(Expression<Func<string>> search, Expression<Func<string>> countryCode = null, Expression<Func<int>> nbResults = null, Expression<Func<int>> page = null, Expression<Func<string>> language = null, Expression<Func<string>> extraParams = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: true);
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: false);
            var __workflow_nbResults = WorkflowExpression.Compile(nbResults, nameof(nbResults), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_language = WorkflowExpression.Compile(language, nameof(language), required: false);
            var __workflow_extraParams = WorkflowExpression.Compile(extraParams, nameof(extraParams), required: false);
            return new DeferredBodyAction<SimpleSearchResponse>(() =>
            {
                var apiCallPath = "/v1/store/google";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_countryCode != null)
                    callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                if (__workflow_nbResults != null)
                    callPayload.Queries["nb_results"] = ExpressionConverter.Convert(__workflow_nbResults);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_language != null)
                    callPayload.Queries["language"] = ExpressionConverter.Convert(__workflow_language);
                if (__workflow_extraParams != null)
                    callPayload.Queries["extra_params"] = ExpressionConverter.Convert(__workflow_extraParams);
                return new ApiConnectionAction<SimpleSearchResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
