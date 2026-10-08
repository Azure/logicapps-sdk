//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bravesearch
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BravesearchActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bravesearch")]
        [WorkflowExpressionFactory(nameof(__BuildWebSearchGet))]
        public IBodyWorkflowAction<WebSearchGetResponse> WebSearchGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<cacheControlInput> cacheControl = null, [WorkflowExpression] Func<string> userAgent = null, [WorkflowExpression] Func<string> xLocLat = null, [WorkflowExpression] Func<string> xLocLong = null, [WorkflowExpression] Func<string> xLocTimezone = null, [WorkflowExpression] Func<string> xLocCity = null, [WorkflowExpression] Func<string> xLocState = null, [WorkflowExpression] Func<string> xLocStateName = null, [WorkflowExpression] Func<string> xLocCountry = null, [WorkflowExpression] Func<string> xLocPostalCode = null, [WorkflowExpression] Func<countryInput> country = null, [WorkflowExpression] Func<searchLangInput> searchLang = null, [WorkflowExpression] Func<uiLangInput> uiLang = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<safesearchInput> safesearch = null, [WorkflowExpression] Func<string> freshness = null, [WorkflowExpression] Func<bool> textDecorations = null, [WorkflowExpression] Func<bool> spellcheck = null, [WorkflowExpression] Func<string> resultFilter = null, [WorkflowExpression] Func<string> gogglesId = null, [WorkflowExpression] Func<string> units = null, [WorkflowExpression] Func<bool> extraSnippets = null, [WorkflowExpression] Func<bool> summary = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebSearchGetResponse> __BuildWebSearchGet(WorkflowExpression<string> q, WorkflowExpression<cacheControlInput> cacheControl = null, WorkflowExpression<string> userAgent = null, WorkflowExpression<string> xLocLat = null, WorkflowExpression<string> xLocLong = null, WorkflowExpression<string> xLocTimezone = null, WorkflowExpression<string> xLocCity = null, WorkflowExpression<string> xLocState = null, WorkflowExpression<string> xLocStateName = null, WorkflowExpression<string> xLocCountry = null, WorkflowExpression<string> xLocPostalCode = null, WorkflowExpression<countryInput> country = null, WorkflowExpression<searchLangInput> searchLang = null, WorkflowExpression<uiLangInput> uiLang = null, WorkflowExpression<int> count = null, WorkflowExpression<int> offset = null, WorkflowExpression<safesearchInput> safesearch = null, WorkflowExpression<string> freshness = null, WorkflowExpression<bool> textDecorations = null, WorkflowExpression<bool> spellcheck = null, WorkflowExpression<string> resultFilter = null, WorkflowExpression<string> gogglesId = null, WorkflowExpression<string> units = null, WorkflowExpression<bool> extraSnippets = null, WorkflowExpression<bool> summary = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(cacheControl, nameof(cacheControl), required: false);
            WorkflowExpression.Validate(userAgent, nameof(userAgent), required: false);
            WorkflowExpression.Validate(xLocLat, nameof(xLocLat), required: false);
            WorkflowExpression.Validate(xLocLong, nameof(xLocLong), required: false);
            WorkflowExpression.Validate(xLocTimezone, nameof(xLocTimezone), required: false);
            WorkflowExpression.Validate(xLocCity, nameof(xLocCity), required: false);
            WorkflowExpression.Validate(xLocState, nameof(xLocState), required: false);
            WorkflowExpression.Validate(xLocStateName, nameof(xLocStateName), required: false);
            WorkflowExpression.Validate(xLocCountry, nameof(xLocCountry), required: false);
            WorkflowExpression.Validate(xLocPostalCode, nameof(xLocPostalCode), required: false);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            WorkflowExpression.Validate(searchLang, nameof(searchLang), required: false);
            WorkflowExpression.Validate(uiLang, nameof(uiLang), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(safesearch, nameof(safesearch), required: false);
            WorkflowExpression.Validate(freshness, nameof(freshness), required: false);
            WorkflowExpression.Validate(textDecorations, nameof(textDecorations), required: false);
            WorkflowExpression.Validate(spellcheck, nameof(spellcheck), required: false);
            WorkflowExpression.Validate(resultFilter, nameof(resultFilter), required: false);
            WorkflowExpression.Validate(gogglesId, nameof(gogglesId), required: false);
            WorkflowExpression.Validate(units, nameof(units), required: false);
            WorkflowExpression.Validate(extraSnippets, nameof(extraSnippets), required: false);
            WorkflowExpression.Validate(summary, nameof(summary), required: false);
            return new DeferredBodyAction<WebSearchGetResponse>(() =>
            {
                var apiCallPath = "/res/v1/web/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                callPayload.Queries["country"] = Convert.ToString("US");
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                callPayload.Queries["search_lang"] = Convert.ToString("en");
                if (searchLang != null)
                    callPayload.Queries["search_lang"] = ExpressionConverter.Convert(searchLang);
                callPayload.Queries["ui_lang"] = Convert.ToString("en");
                if (uiLang != null)
                    callPayload.Queries["ui_lang"] = ExpressionConverter.Convert(uiLang);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                callPayload.Queries["safesearch"] = Convert.ToString("strict");
                if (safesearch != null)
                    callPayload.Queries["safesearch"] = ExpressionConverter.Convert(safesearch);
                if (freshness != null)
                    callPayload.Queries["freshness"] = ExpressionConverter.Convert(freshness);
                if (textDecorations != null)
                    callPayload.Queries["text_decorations"] = ExpressionConverter.Convert(textDecorations);
                callPayload.Queries["spellcheck"] = Convert.ToString(true);
                if (spellcheck != null)
                    callPayload.Queries["spellcheck"] = ExpressionConverter.Convert(spellcheck);
                if (resultFilter != null)
                    callPayload.Queries["result_filter"] = ExpressionConverter.Convert(resultFilter);
                if (gogglesId != null)
                    callPayload.Queries["goggles_id"] = ExpressionConverter.Convert(gogglesId);
                if (units != null)
                    callPayload.Queries["units"] = ExpressionConverter.Convert(units);
                if (extraSnippets != null)
                    callPayload.Queries["extra_snippets"] = ExpressionConverter.Convert(extraSnippets);
                if (summary != null)
                    callPayload.Queries["summary"] = ExpressionConverter.Convert(summary);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                if (cacheControl != null)
                    callPayload.Headers["Cache-Control"] = ExpressionConverter.Convert(cacheControl);
                if (userAgent != null)
                    callPayload.Headers["User-Agent"] = ExpressionConverter.Convert(userAgent);
                if (xLocLat != null)
                    callPayload.Headers["X-Loc-Lat"] = ExpressionConverter.Convert(xLocLat);
                if (xLocLong != null)
                    callPayload.Headers["X-Loc-Long"] = ExpressionConverter.Convert(xLocLong);
                if (xLocTimezone != null)
                    callPayload.Headers["X-Loc-Timezone"] = ExpressionConverter.Convert(xLocTimezone);
                if (xLocCity != null)
                    callPayload.Headers["X-Loc-City"] = ExpressionConverter.Convert(xLocCity);
                if (xLocState != null)
                    callPayload.Headers["X-Loc-State"] = ExpressionConverter.Convert(xLocState);
                if (xLocStateName != null)
                    callPayload.Headers["X-Loc-State-Name"] = ExpressionConverter.Convert(xLocStateName);
                if (xLocCountry != null)
                    callPayload.Headers["X-Loc-Country"] = ExpressionConverter.Convert(xLocCountry);
                if (xLocPostalCode != null)
                    callPayload.Headers["X-Loc-Postal-Code"] = ExpressionConverter.Convert(xLocPostalCode);
                return new ApiConnectionAction<WebSearchGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bravesearch")]
        [WorkflowExpressionFactory(nameof(__BuildImageSearchGet))]
        public IBodyWorkflowAction<ImageSearchGetResponse> ImageSearchGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<countryInput> country = null, [WorkflowExpression] Func<searchLangInput> searchLang = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<safesearchInput> safesearch = null, [WorkflowExpression] Func<bool> spellcheck = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ImageSearchGetResponse> __BuildImageSearchGet(WorkflowExpression<string> q, WorkflowExpression<countryInput> country = null, WorkflowExpression<searchLangInput> searchLang = null, WorkflowExpression<int> count = null, WorkflowExpression<safesearchInput> safesearch = null, WorkflowExpression<bool> spellcheck = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            WorkflowExpression.Validate(searchLang, nameof(searchLang), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(safesearch, nameof(safesearch), required: false);
            WorkflowExpression.Validate(spellcheck, nameof(spellcheck), required: false);
            return new DeferredBodyAction<ImageSearchGetResponse>(() =>
            {
                var apiCallPath = "/res/v1/images/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                callPayload.Queries["country"] = Convert.ToString("US");
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                callPayload.Queries["search_lang"] = Convert.ToString("en");
                if (searchLang != null)
                    callPayload.Queries["search_lang"] = ExpressionConverter.Convert(searchLang);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                callPayload.Queries["safesearch"] = Convert.ToString("strict");
                if (safesearch != null)
                    callPayload.Queries["safesearch"] = ExpressionConverter.Convert(safesearch);
                callPayload.Queries["spellcheck"] = Convert.ToString(true);
                if (spellcheck != null)
                    callPayload.Queries["spellcheck"] = ExpressionConverter.Convert(spellcheck);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<ImageSearchGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bravesearch")]
        [WorkflowExpressionFactory(nameof(__BuildVideoSearchGet))]
        public IBodyWorkflowAction<VideoSearchGetResponse> VideoSearchGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<countryInput> country = null, [WorkflowExpression] Func<searchLangInput> searchLang = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<safesearchInput> safesearch = null, [WorkflowExpression] Func<bool> spellcheck = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VideoSearchGetResponse> __BuildVideoSearchGet(WorkflowExpression<string> q, WorkflowExpression<countryInput> country = null, WorkflowExpression<searchLangInput> searchLang = null, WorkflowExpression<int> count = null, WorkflowExpression<safesearchInput> safesearch = null, WorkflowExpression<bool> spellcheck = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            WorkflowExpression.Validate(searchLang, nameof(searchLang), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(safesearch, nameof(safesearch), required: false);
            WorkflowExpression.Validate(spellcheck, nameof(spellcheck), required: false);
            return new DeferredBodyAction<VideoSearchGetResponse>(() =>
            {
                var apiCallPath = "/res/v1/videos/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                callPayload.Queries["country"] = Convert.ToString("US");
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                callPayload.Queries["search_lang"] = Convert.ToString("en");
                if (searchLang != null)
                    callPayload.Queries["search_lang"] = ExpressionConverter.Convert(searchLang);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                callPayload.Queries["safesearch"] = Convert.ToString("strict");
                if (safesearch != null)
                    callPayload.Queries["safesearch"] = ExpressionConverter.Convert(safesearch);
                callPayload.Queries["spellcheck"] = Convert.ToString(true);
                if (spellcheck != null)
                    callPayload.Queries["spellcheck"] = ExpressionConverter.Convert(spellcheck);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<VideoSearchGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bravesearch")]
        [WorkflowExpressionFactory(nameof(__BuildNewsSearchGet))]
        public IBodyWorkflowAction<NewsSearchGetResponse> NewsSearchGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<countryInput> country = null, [WorkflowExpression] Func<searchLangInput> searchLang = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<safesearchInput> safesearch = null, [WorkflowExpression] Func<bool> spellcheck = null, [WorkflowExpression] Func<freshnessInput> freshness = null, [WorkflowExpression] Func<bool> extraSnippets = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NewsSearchGetResponse> __BuildNewsSearchGet(WorkflowExpression<string> q, WorkflowExpression<countryInput> country = null, WorkflowExpression<searchLangInput> searchLang = null, WorkflowExpression<int> count = null, WorkflowExpression<int> offset = null, WorkflowExpression<safesearchInput> safesearch = null, WorkflowExpression<bool> spellcheck = null, WorkflowExpression<freshnessInput> freshness = null, WorkflowExpression<bool> extraSnippets = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            WorkflowExpression.Validate(searchLang, nameof(searchLang), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(safesearch, nameof(safesearch), required: false);
            WorkflowExpression.Validate(spellcheck, nameof(spellcheck), required: false);
            WorkflowExpression.Validate(freshness, nameof(freshness), required: false);
            WorkflowExpression.Validate(extraSnippets, nameof(extraSnippets), required: false);
            return new DeferredBodyAction<NewsSearchGetResponse>(() =>
            {
                var apiCallPath = "/res/v1/news/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                callPayload.Queries["country"] = Convert.ToString("US");
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                callPayload.Queries["search_lang"] = Convert.ToString("en");
                if (searchLang != null)
                    callPayload.Queries["search_lang"] = ExpressionConverter.Convert(searchLang);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                callPayload.Queries["safesearch"] = Convert.ToString("strict");
                if (safesearch != null)
                    callPayload.Queries["safesearch"] = ExpressionConverter.Convert(safesearch);
                callPayload.Queries["spellcheck"] = Convert.ToString(true);
                if (spellcheck != null)
                    callPayload.Queries["spellcheck"] = ExpressionConverter.Convert(spellcheck);
                if (freshness != null)
                    callPayload.Queries["freshness"] = ExpressionConverter.Convert(freshness);
                if (extraSnippets != null)
                    callPayload.Queries["extra_snippets"] = ExpressionConverter.Convert(extraSnippets);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<NewsSearchGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bravesearch")]
        [WorkflowExpressionFactory(nameof(__BuildSuggestionSearchGet))]
        public IBodyWorkflowAction<SuggestionSearchGetResponse> SuggestionSearchGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<countryInput> country = null, [WorkflowExpression] Func<langInput> lang = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<bool> rich = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SuggestionSearchGetResponse> __BuildSuggestionSearchGet(WorkflowExpression<string> q, WorkflowExpression<countryInput> country = null, WorkflowExpression<langInput> lang = null, WorkflowExpression<int> count = null, WorkflowExpression<bool> rich = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            WorkflowExpression.Validate(lang, nameof(lang), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(rich, nameof(rich), required: false);
            return new DeferredBodyAction<SuggestionSearchGetResponse>(() =>
            {
                var apiCallPath = "/res/v1/suggest/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                callPayload.Queries["country"] = Convert.ToString("US");
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                callPayload.Queries["lang"] = Convert.ToString("en");
                if (lang != null)
                    callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (rich != null)
                    callPayload.Queries["rich"] = ExpressionConverter.Convert(rich);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<SuggestionSearchGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bravesearch")]
        [WorkflowExpressionFactory(nameof(__BuildSpellcheckSearchGet))]
        public IBodyWorkflowAction<SpellcheckSearchGetResponse> SpellcheckSearchGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<countryInput> country = null, [WorkflowExpression] Func<langInput> lang = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SpellcheckSearchGetResponse> __BuildSpellcheckSearchGet(WorkflowExpression<string> q, WorkflowExpression<countryInput> country = null, WorkflowExpression<langInput> lang = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(country, nameof(country), required: false);
            WorkflowExpression.Validate(lang, nameof(lang), required: false);
            return new DeferredBodyAction<SpellcheckSearchGetResponse>(() =>
            {
                var apiCallPath = "/res/v1/spellcheck/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                callPayload.Queries["country"] = Convert.ToString("US");
                if (country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(country);
                callPayload.Queries["lang"] = Convert.ToString("en");
                if (lang != null)
                    callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<SpellcheckSearchGetResponse>(callPayload);
            });
        }
    }

    public class BravesearchTriggers([ConnectionName] string connectionId)
    {
    }

    public class WebSearchGetResponse
    {
        [JsonProperty("query")]
        public WebSearchGetResponseQueryType Query { get; set; }

        [JsonProperty("mixed")]
        public WebSearchGetResponseMixedType Mixed { get; set; }

        [JsonProperty("news")]
        public WebSearchGetResponseNewsType News { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("videos")]
        public WebSearchGetResponseVideosType Videos { get; set; }

        [JsonProperty("web")]
        public WebSearchGetResponseWebType Web { get; set; }
    }

    public class WebSearchGetResponseQueryType
    {
        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("show_strict_warning")]
        public bool ShowStrictWarning { get; set; }

        [JsonProperty("is_navigational")]
        public bool IsNavigational { get; set; }

        [JsonProperty("is_news_breaking")]
        public bool IsNewsBreaking { get; set; }

        [JsonProperty("spellcheck_off")]
        public bool SpellcheckOff { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("bad_results")]
        public bool BadResults { get; set; }

        [JsonProperty("should_fallback")]
        public bool ShouldFallback { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("header_country")]
        public string HeaderCountry { get; set; }

        [JsonProperty("more_results_available")]
        public bool MoreResultsAvailable { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class WebSearchGetResponseMixedType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("main")]
        public WebSearchGetResponseMixedTypeMainTypeItem[] Main { get; set; }

        [JsonProperty("top")]
        public string[] Top { get; set; }

        [JsonProperty("side")]
        public string[] Side { get; set; }
    }

    public class WebSearchGetResponseMixedTypeMainTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("all")]
        public bool All { get; set; }
    }

    public class WebSearchGetResponseNewsType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("results")]
        public WebSearchGetResponseNewsTypeResultsTypeItem[] Results { get; set; }

        [JsonProperty("mutated_by_goggles")]
        public bool MutatedByGoggles { get; set; }
    }

    public class WebSearchGetResponseNewsTypeResultsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_source_local")]
        public bool IsSourceLocal { get; set; }

        [JsonProperty("is_source_both")]
        public bool IsSourceBoth { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("page_age")]
        public string PageAge { get; set; }

        [JsonProperty("family_friendly")]
        public bool FamilyFriendly { get; set; }

        [JsonProperty("meta_url")]
        public WebSearchGetResponseNewsTypeResultsTypeItemMetaUrlType MetaUrl { get; set; }

        [JsonProperty("breaking")]
        public bool Breaking { get; set; }

        [JsonProperty("thumbnail")]
        public WebSearchGetResponseNewsTypeResultsTypeItemThumbnailType Thumbnail { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }
    }

    public class WebSearchGetResponseNewsTypeResultsTypeItemMetaUrlType
    {
        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("netloc")]
        public string Netloc { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class WebSearchGetResponseNewsTypeResultsTypeItemThumbnailType
    {
        [JsonProperty("src")]
        public string Src { get; set; }
    }

    public class WebSearchGetResponseVideosType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("results")]
        public WebSearchGetResponseVideosTypeResultsTypeItem[] Results { get; set; }

        [JsonProperty("mutated_by_goggles")]
        public bool MutatedByGoggles { get; set; }
    }

    public class WebSearchGetResponseVideosTypeResultsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("page_age")]
        public string PageAge { get; set; }

        [JsonProperty("video")]
        public JToken Video { get; set; }

        [JsonProperty("meta_url")]
        public WebSearchGetResponseVideosTypeResultsTypeItemMetaUrlType MetaUrl { get; set; }

        [JsonProperty("thumbnail")]
        public WebSearchGetResponseVideosTypeResultsTypeItemThumbnailType Thumbnail { get; set; }
    }

    public class WebSearchGetResponseVideosTypeResultsTypeItemMetaUrlType
    {
        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("netloc")]
        public string Netloc { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class WebSearchGetResponseVideosTypeResultsTypeItemThumbnailType
    {
        [JsonProperty("src")]
        public string Src { get; set; }
    }

    public class WebSearchGetResponseWebType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("results")]
        public WebSearchGetResponseWebTypeResultsTypeItem[] Results { get; set; }

        [JsonProperty("family_friendly")]
        public bool FamilyFriendly { get; set; }
    }

    public class WebSearchGetResponseWebTypeResultsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_source_local")]
        public bool IsSourceLocal { get; set; }

        [JsonProperty("is_source_both")]
        public bool IsSourceBoth { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("page_age")]
        public string PageAge { get; set; }

        [JsonProperty("profile")]
        public WebSearchGetResponseWebTypeResultsTypeItemProfileType Profile { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("family_friendly")]
        public bool FamilyFriendly { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("meta_url")]
        public WebSearchGetResponseWebTypeResultsTypeItemMetaUrlType MetaUrl { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("cluster_type")]
        public string ClusterType { get; set; }

        [JsonProperty("cluster")]
        public WebSearchGetResponseWebTypeResultsTypeItemClusterTypeItem[] Cluster { get; set; }

        [JsonProperty("thumbnail")]
        public WebSearchGetResponseWebTypeResultsTypeItemThumbnailType Thumbnail { get; set; }
    }

    public class WebSearchGetResponseWebTypeResultsTypeItemProfileType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("long_name")]
        public string LongName { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }
    }

    public class WebSearchGetResponseWebTypeResultsTypeItemMetaUrlType
    {
        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("netloc")]
        public string Netloc { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class WebSearchGetResponseWebTypeResultsTypeItemClusterTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_source_local")]
        public bool IsSourceLocal { get; set; }

        [JsonProperty("is_source_both")]
        public bool IsSourceBoth { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("family_friendly")]
        public bool FamilyFriendly { get; set; }
    }

    public class WebSearchGetResponseWebTypeResultsTypeItemThumbnailType
    {
        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("logo")]
        public bool Logo { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum cacheControlInput
    {
        [EnumMember(Value = "no-cache")]
        NoCache
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum countryInput
    {
        ALL,
        AR,
        AU,
        AT,
        BE,
        BR,
        CA,
        CL,
        DK,
        FI,
        FR,
        DE,
        HK,
        IN,
        ID,
        IT,
        JP,
        KR,
        MY,
        MX,
        NL,
        NZ,
        NO,
        CN,
        PL,
        PT,
        PH,
        RU,
        SA,
        ZA,
        ES,
        SE,
        CH,
        TW,
        TR,
        GB,
        US
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum searchLangInput
    {
        [EnumMember(Value = "ar")]
        Ar,
        [EnumMember(Value = "eu")]
        Eu,
        [EnumMember(Value = "bn")]
        Bn,
        [EnumMember(Value = "bg")]
        Bg,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "zh-hans")]
        ZhHans,
        [EnumMember(Value = "zh-hant")]
        ZhHant,
        [EnumMember(Value = "hr")]
        Hr,
        [EnumMember(Value = "cs")]
        Cs,
        [EnumMember(Value = "da")]
        Da,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "en-gb")]
        EnGb,
        [EnumMember(Value = "et")]
        Et,
        [EnumMember(Value = "fi")]
        Fi,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "gl")]
        Gl,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "gu")]
        Gu,
        [EnumMember(Value = "he")]
        He,
        [EnumMember(Value = "hi")]
        Hi,
        [EnumMember(Value = "hu")]
        Hu,
        [EnumMember(Value = "is")]
        Is,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "jp")]
        Jp,
        [EnumMember(Value = "kn")]
        Kn,
        [EnumMember(Value = "ko")]
        Ko,
        [EnumMember(Value = "lv")]
        Lv,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "ms")]
        Ms,
        [EnumMember(Value = "ml")]
        Ml,
        [EnumMember(Value = "mr")]
        Mr,
        [EnumMember(Value = "nb")]
        Nb,
        [EnumMember(Value = "pl")]
        Pl,
        [EnumMember(Value = "pt-br")]
        PtBr,
        [EnumMember(Value = "pt-pt")]
        PtPt,
        [EnumMember(Value = "pa")]
        Pa,
        [EnumMember(Value = "ro")]
        Ro,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "sr")]
        Sr,
        [EnumMember(Value = "sk")]
        Sk,
        [EnumMember(Value = "sl")]
        Sl,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "sv")]
        Sv,
        [EnumMember(Value = "ta")]
        Ta,
        [EnumMember(Value = "te")]
        Te,
        [EnumMember(Value = "th")]
        Th,
        [EnumMember(Value = "tr")]
        Tr,
        [EnumMember(Value = "uk")]
        Uk,
        [EnumMember(Value = "vi")]
        Vi
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uiLangInput
    {
        [EnumMember(Value = "ar")]
        Ar,
        [EnumMember(Value = "eu")]
        Eu,
        [EnumMember(Value = "bn")]
        Bn,
        [EnumMember(Value = "bg")]
        Bg,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "zh-hans")]
        ZhHans,
        [EnumMember(Value = "zh-hant")]
        ZhHant,
        [EnumMember(Value = "hr")]
        Hr,
        [EnumMember(Value = "cs")]
        Cs,
        [EnumMember(Value = "da")]
        Da,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "en-gb")]
        EnGb,
        [EnumMember(Value = "et")]
        Et,
        [EnumMember(Value = "fi")]
        Fi,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "gl")]
        Gl,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "gu")]
        Gu,
        [EnumMember(Value = "he")]
        He,
        [EnumMember(Value = "hi")]
        Hi,
        [EnumMember(Value = "hu")]
        Hu,
        [EnumMember(Value = "is")]
        Is,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "jp")]
        Jp,
        [EnumMember(Value = "kn")]
        Kn,
        [EnumMember(Value = "ko")]
        Ko,
        [EnumMember(Value = "lv")]
        Lv,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "ms")]
        Ms,
        [EnumMember(Value = "ml")]
        Ml,
        [EnumMember(Value = "mr")]
        Mr,
        [EnumMember(Value = "nb")]
        Nb,
        [EnumMember(Value = "pl")]
        Pl,
        [EnumMember(Value = "pt-br")]
        PtBr,
        [EnumMember(Value = "pt-pt")]
        PtPt,
        [EnumMember(Value = "pa")]
        Pa,
        [EnumMember(Value = "ro")]
        Ro,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "sr")]
        Sr,
        [EnumMember(Value = "sk")]
        Sk,
        [EnumMember(Value = "sl")]
        Sl,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "sv")]
        Sv,
        [EnumMember(Value = "ta")]
        Ta,
        [EnumMember(Value = "te")]
        Te,
        [EnumMember(Value = "th")]
        Th,
        [EnumMember(Value = "tr")]
        Tr,
        [EnumMember(Value = "uk")]
        Uk,
        [EnumMember(Value = "vi")]
        Vi
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum safesearchInput
    {
        [EnumMember(Value = "strict")]
        Strict,
        [EnumMember(Value = "off")]
        Off
    }

    public class ImageSearchGetResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("query")]
        public ImageSearchGetResponseQueryType Query { get; set; }

        [JsonProperty("results")]
        public ImageSearchGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class ImageSearchGetResponseQueryType
    {
        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("spellcheck_off")]
        public bool SpellcheckOff { get; set; }

        [JsonProperty("show_strict_warning")]
        public bool ShowStrictWarning { get; set; }
    }

    public class ImageSearchGetResponseResultsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("page_fetched")]
        public string PageFetched { get; set; }

        [JsonProperty("thumbnail")]
        public ImageSearchGetResponseResultsTypeItemThumbnailType Thumbnail { get; set; }

        [JsonProperty("properties")]
        public ImageSearchGetResponseResultsTypeItemPropertiesType Properties { get; set; }

        [JsonProperty("meta_url")]
        public ImageSearchGetResponseResultsTypeItemMetaUrlType MetaUrl { get; set; }
    }

    public class ImageSearchGetResponseResultsTypeItemThumbnailType
    {
        [JsonProperty("src")]
        public string Src { get; set; }
    }

    public class ImageSearchGetResponseResultsTypeItemPropertiesType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }
    }

    public class ImageSearchGetResponseResultsTypeItemMetaUrlType
    {
        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("netloc")]
        public string Netloc { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class VideoSearchGetResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("query")]
        public VideoSearchGetResponseQueryType Query { get; set; }

        [JsonProperty("results")]
        public VideoSearchGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class VideoSearchGetResponseQueryType
    {
        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("spellcheck_off")]
        public bool SpellcheckOff { get; set; }

        [JsonProperty("show_strict_warning")]
        public bool ShowStrictWarning { get; set; }
    }

    public class VideoSearchGetResponseResultsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("page_age")]
        public string PageAge { get; set; }

        [JsonProperty("video")]
        public VideoSearchGetResponseResultsTypeItemVideoType Video { get; set; }

        [JsonProperty("meta_url")]
        public VideoSearchGetResponseResultsTypeItemMetaUrlType MetaUrl { get; set; }

        [JsonProperty("thumbnail")]
        public VideoSearchGetResponseResultsTypeItemThumbnailType Thumbnail { get; set; }
    }

    public class VideoSearchGetResponseResultsTypeItemVideoType
    {
        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("requires_subscription")]
        public bool RequiresSubscription { get; set; }

        [JsonProperty("author")]
        public VideoSearchGetResponseResultsTypeItemVideoTypeAuthorType Author { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class VideoSearchGetResponseResultsTypeItemVideoTypeAuthorType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class VideoSearchGetResponseResultsTypeItemMetaUrlType
    {
        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("netloc")]
        public string Netloc { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class VideoSearchGetResponseResultsTypeItemThumbnailType
    {
        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }
    }

    public class NewsSearchGetResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("query")]
        public NewsSearchGetResponseQueryType Query { get; set; }

        [JsonProperty("results")]
        public NewsSearchGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class NewsSearchGetResponseQueryType
    {
        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("spellcheck_off")]
        public bool SpellcheckOff { get; set; }

        [JsonProperty("show_strict_warning")]
        public bool ShowStrictWarning { get; set; }
    }

    public class NewsSearchGetResponseResultsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("page_age")]
        public string PageAge { get; set; }

        [JsonProperty("meta_url")]
        public NewsSearchGetResponseResultsTypeItemMetaUrlType MetaUrl { get; set; }

        [JsonProperty("thumbnail")]
        public NewsSearchGetResponseResultsTypeItemThumbnailType Thumbnail { get; set; }
    }

    public class NewsSearchGetResponseResultsTypeItemMetaUrlType
    {
        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("netloc")]
        public string Netloc { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class NewsSearchGetResponseResultsTypeItemThumbnailType
    {
        [JsonProperty("src")]
        public string Src { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum freshnessInput
    {
        [EnumMember(Value = "pd")]
        Pd,
        [EnumMember(Value = "pw")]
        Pw,
        [EnumMember(Value = "pm")]
        Pm,
        [EnumMember(Value = "py")]
        Py
    }

    public class SuggestionSearchGetResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("query")]
        public SuggestionSearchGetResponseQueryType Query { get; set; }

        [JsonProperty("results")]
        public SuggestionSearchGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class SuggestionSearchGetResponseQueryType
    {
        [JsonProperty("original")]
        public string Original { get; set; }
    }

    public class SuggestionSearchGetResponseResultsTypeItem
    {
        [JsonProperty("query")]
        public string Query { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum langInput
    {
        [EnumMember(Value = "ar")]
        Ar,
        [EnumMember(Value = "eu")]
        Eu,
        [EnumMember(Value = "bn")]
        Bn,
        [EnumMember(Value = "bg")]
        Bg,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "zh-hans")]
        ZhHans,
        [EnumMember(Value = "zh-hant")]
        ZhHant,
        [EnumMember(Value = "hr")]
        Hr,
        [EnumMember(Value = "cs")]
        Cs,
        [EnumMember(Value = "da")]
        Da,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "en-gb")]
        EnGb,
        [EnumMember(Value = "et")]
        Et,
        [EnumMember(Value = "fi")]
        Fi,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "gl")]
        Gl,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "gu")]
        Gu,
        [EnumMember(Value = "he")]
        He,
        [EnumMember(Value = "hi")]
        Hi,
        [EnumMember(Value = "hu")]
        Hu,
        [EnumMember(Value = "is")]
        Is,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "jp")]
        Jp,
        [EnumMember(Value = "kn")]
        Kn,
        [EnumMember(Value = "ko")]
        Ko,
        [EnumMember(Value = "lv")]
        Lv,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "ms")]
        Ms,
        [EnumMember(Value = "ml")]
        Ml,
        [EnumMember(Value = "mr")]
        Mr,
        [EnumMember(Value = "nb")]
        Nb,
        [EnumMember(Value = "pl")]
        Pl,
        [EnumMember(Value = "pt-br")]
        PtBr,
        [EnumMember(Value = "pt-pt")]
        PtPt,
        [EnumMember(Value = "pa")]
        Pa,
        [EnumMember(Value = "ro")]
        Ro,
        [EnumMember(Value = "ru")]
        Ru,
        [EnumMember(Value = "sr")]
        Sr,
        [EnumMember(Value = "sk")]
        Sk,
        [EnumMember(Value = "sl")]
        Sl,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "sv")]
        Sv,
        [EnumMember(Value = "ta")]
        Ta,
        [EnumMember(Value = "te")]
        Te,
        [EnumMember(Value = "th")]
        Th,
        [EnumMember(Value = "tr")]
        Tr,
        [EnumMember(Value = "uk")]
        Uk,
        [EnumMember(Value = "vi")]
        Vi
    }

    public class SpellcheckSearchGetResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("query")]
        public SpellcheckSearchGetResponseQueryType Query { get; set; }

        [JsonProperty("results")]
        public SpellcheckSearchGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class SpellcheckSearchGetResponseQueryType
    {
        [JsonProperty("original")]
        public string Original { get; set; }
    }

    public class SpellcheckSearchGetResponseResultsTypeItem
    {
        [JsonProperty("query")]
        public string Query { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bravesearch;

    public partial class WorkflowManagedActions
    {
        public BravesearchActions Bravesearch(string connectionId) => new BravesearchActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BravesearchTriggers Bravesearch(string connectionId) => new BravesearchTriggers(connectionId);
    }
}