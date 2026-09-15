//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bravesearch
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BravesearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bravesearch")]
        public IBodyWorkflowAction<WebSearchGetResponse> WebSearchGet(Expression<Func<string>> q, Expression<Func<cacheControlInput>> cacheControl = null, Expression<Func<string>> userAgent = null, Expression<Func<string>> xLocLat = null, Expression<Func<string>> xLocLong = null, Expression<Func<string>> xLocTimezone = null, Expression<Func<string>> xLocCity = null, Expression<Func<string>> xLocState = null, Expression<Func<string>> xLocStateName = null, Expression<Func<string>> xLocCountry = null, Expression<Func<string>> xLocPostalCode = null, Expression<Func<countryInput>> country = null, Expression<Func<searchLangInput>> searchLang = null, Expression<Func<uiLangInput>> uiLang = null, Expression<Func<int>> count = null, Expression<Func<int>> offset = null, Expression<Func<safesearchInput>> safesearch = null, Expression<Func<string>> freshness = null, Expression<Func<bool>> textDecorations = null, Expression<Func<bool>> spellcheck = null, Expression<Func<string>> resultFilter = null, Expression<Func<string>> gogglesId = null, Expression<Func<string>> units = null, Expression<Func<bool>> extraSnippets = null, Expression<Func<bool>> summary = null)
        {
            var apiCallPath = "/res/v1/web/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = CSharpExpressionConverter.ConvertO(q);
            callPayload.Queries["country"] = Convert.ToString("US");
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.Convert(country);
            callPayload.Queries["search_lang"] = Convert.ToString("en");
            if (searchLang != null)
                callPayload.Queries["search_lang"] = CSharpExpressionConverter.Convert(searchLang);
            callPayload.Queries["ui_lang"] = Convert.ToString("en");
            if (uiLang != null)
                callPayload.Queries["ui_lang"] = CSharpExpressionConverter.Convert(uiLang);
            if (count != null)
                callPayload.Queries["count"] = CSharpExpressionConverter.ConvertO(count);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            callPayload.Queries["safesearch"] = Convert.ToString("strict");
            if (safesearch != null)
                callPayload.Queries["safesearch"] = CSharpExpressionConverter.Convert(safesearch);
            if (freshness != null)
                callPayload.Queries["freshness"] = CSharpExpressionConverter.ConvertO(freshness);
            if (textDecorations != null)
                callPayload.Queries["text_decorations"] = CSharpExpressionConverter.ConvertO(textDecorations);
            callPayload.Queries["spellcheck"] = Convert.ToString(true);
            if (spellcheck != null)
                callPayload.Queries["spellcheck"] = CSharpExpressionConverter.ConvertO(spellcheck);
            if (resultFilter != null)
                callPayload.Queries["result_filter"] = CSharpExpressionConverter.ConvertO(resultFilter);
            if (gogglesId != null)
                callPayload.Queries["goggles_id"] = CSharpExpressionConverter.ConvertO(gogglesId);
            if (units != null)
                callPayload.Queries["units"] = CSharpExpressionConverter.ConvertO(units);
            if (extraSnippets != null)
                callPayload.Queries["extra_snippets"] = CSharpExpressionConverter.ConvertO(extraSnippets);
            if (summary != null)
                callPayload.Queries["summary"] = CSharpExpressionConverter.ConvertO(summary);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            if (cacheControl != null)
                callPayload.Headers["Cache-Control"] = CSharpExpressionConverter.Convert(cacheControl);
            if (userAgent != null)
                callPayload.Headers["User-Agent"] = CSharpExpressionConverter.ConvertO(userAgent);
            if (xLocLat != null)
                callPayload.Headers["X-Loc-Lat"] = CSharpExpressionConverter.ConvertO(xLocLat);
            if (xLocLong != null)
                callPayload.Headers["X-Loc-Long"] = CSharpExpressionConverter.ConvertO(xLocLong);
            if (xLocTimezone != null)
                callPayload.Headers["X-Loc-Timezone"] = CSharpExpressionConverter.ConvertO(xLocTimezone);
            if (xLocCity != null)
                callPayload.Headers["X-Loc-City"] = CSharpExpressionConverter.ConvertO(xLocCity);
            if (xLocState != null)
                callPayload.Headers["X-Loc-State"] = CSharpExpressionConverter.ConvertO(xLocState);
            if (xLocStateName != null)
                callPayload.Headers["X-Loc-State-Name"] = CSharpExpressionConverter.ConvertO(xLocStateName);
            if (xLocCountry != null)
                callPayload.Headers["X-Loc-Country"] = CSharpExpressionConverter.ConvertO(xLocCountry);
            if (xLocPostalCode != null)
                callPayload.Headers["X-Loc-Postal-Code"] = CSharpExpressionConverter.ConvertO(xLocPostalCode);
            return new ApiConnectionAction<WebSearchGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bravesearch")]
        public IBodyWorkflowAction<ImageSearchGetResponse> ImageSearchGet(Expression<Func<string>> q, Expression<Func<countryInput>> country = null, Expression<Func<searchLangInput>> searchLang = null, Expression<Func<int>> count = null, Expression<Func<safesearchInput>> safesearch = null, Expression<Func<bool>> spellcheck = null)
        {
            var apiCallPath = "/res/v1/images/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = CSharpExpressionConverter.ConvertO(q);
            callPayload.Queries["country"] = Convert.ToString("US");
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.Convert(country);
            callPayload.Queries["search_lang"] = Convert.ToString("en");
            if (searchLang != null)
                callPayload.Queries["search_lang"] = CSharpExpressionConverter.Convert(searchLang);
            if (count != null)
                callPayload.Queries["count"] = CSharpExpressionConverter.ConvertO(count);
            callPayload.Queries["safesearch"] = Convert.ToString("strict");
            if (safesearch != null)
                callPayload.Queries["safesearch"] = CSharpExpressionConverter.Convert(safesearch);
            callPayload.Queries["spellcheck"] = Convert.ToString(true);
            if (spellcheck != null)
                callPayload.Queries["spellcheck"] = CSharpExpressionConverter.ConvertO(spellcheck);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ImageSearchGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bravesearch")]
        public IBodyWorkflowAction<VideoSearchGetResponse> VideoSearchGet(Expression<Func<string>> q, Expression<Func<countryInput>> country = null, Expression<Func<searchLangInput>> searchLang = null, Expression<Func<int>> count = null, Expression<Func<safesearchInput>> safesearch = null, Expression<Func<bool>> spellcheck = null)
        {
            var apiCallPath = "/res/v1/videos/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = CSharpExpressionConverter.ConvertO(q);
            callPayload.Queries["country"] = Convert.ToString("US");
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.Convert(country);
            callPayload.Queries["search_lang"] = Convert.ToString("en");
            if (searchLang != null)
                callPayload.Queries["search_lang"] = CSharpExpressionConverter.Convert(searchLang);
            if (count != null)
                callPayload.Queries["count"] = CSharpExpressionConverter.ConvertO(count);
            callPayload.Queries["safesearch"] = Convert.ToString("strict");
            if (safesearch != null)
                callPayload.Queries["safesearch"] = CSharpExpressionConverter.Convert(safesearch);
            callPayload.Queries["spellcheck"] = Convert.ToString(true);
            if (spellcheck != null)
                callPayload.Queries["spellcheck"] = CSharpExpressionConverter.ConvertO(spellcheck);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<VideoSearchGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bravesearch")]
        public IBodyWorkflowAction<NewsSearchGetResponse> NewsSearchGet(Expression<Func<string>> q, Expression<Func<countryInput>> country = null, Expression<Func<searchLangInput>> searchLang = null, Expression<Func<int>> count = null, Expression<Func<int>> offset = null, Expression<Func<safesearchInput>> safesearch = null, Expression<Func<bool>> spellcheck = null, Expression<Func<freshnessInput>> freshness = null, Expression<Func<bool>> extraSnippets = null)
        {
            var apiCallPath = "/res/v1/news/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = CSharpExpressionConverter.ConvertO(q);
            callPayload.Queries["country"] = Convert.ToString("US");
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.Convert(country);
            callPayload.Queries["search_lang"] = Convert.ToString("en");
            if (searchLang != null)
                callPayload.Queries["search_lang"] = CSharpExpressionConverter.Convert(searchLang);
            if (count != null)
                callPayload.Queries["count"] = CSharpExpressionConverter.ConvertO(count);
            if (offset != null)
                callPayload.Queries["offset"] = CSharpExpressionConverter.ConvertO(offset);
            callPayload.Queries["safesearch"] = Convert.ToString("strict");
            if (safesearch != null)
                callPayload.Queries["safesearch"] = CSharpExpressionConverter.Convert(safesearch);
            callPayload.Queries["spellcheck"] = Convert.ToString(true);
            if (spellcheck != null)
                callPayload.Queries["spellcheck"] = CSharpExpressionConverter.ConvertO(spellcheck);
            if (freshness != null)
                callPayload.Queries["freshness"] = CSharpExpressionConverter.Convert(freshness);
            if (extraSnippets != null)
                callPayload.Queries["extra_snippets"] = CSharpExpressionConverter.ConvertO(extraSnippets);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<NewsSearchGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bravesearch")]
        public IBodyWorkflowAction<SuggestionSearchGetResponse> SuggestionSearchGet(Expression<Func<string>> q, Expression<Func<countryInput>> country = null, Expression<Func<langInput>> lang = null, Expression<Func<int>> count = null, Expression<Func<bool>> rich = null)
        {
            var apiCallPath = "/res/v1/suggest/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = CSharpExpressionConverter.ConvertO(q);
            callPayload.Queries["country"] = Convert.ToString("US");
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.Convert(country);
            callPayload.Queries["lang"] = Convert.ToString("en");
            if (lang != null)
                callPayload.Queries["lang"] = CSharpExpressionConverter.Convert(lang);
            if (count != null)
                callPayload.Queries["count"] = CSharpExpressionConverter.ConvertO(count);
            if (rich != null)
                callPayload.Queries["rich"] = CSharpExpressionConverter.ConvertO(rich);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<SuggestionSearchGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bravesearch")]
        public IBodyWorkflowAction<SpellcheckSearchGetResponse> SpellcheckSearchGet(Expression<Func<string>> q, Expression<Func<countryInput>> country = null, Expression<Func<langInput>> lang = null)
        {
            var apiCallPath = "/res/v1/spellcheck/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = CSharpExpressionConverter.ConvertO(q);
            callPayload.Queries["country"] = Convert.ToString("US");
            if (country != null)
                callPayload.Queries["country"] = CSharpExpressionConverter.Convert(country);
            callPayload.Queries["lang"] = Convert.ToString("en");
            if (lang != null)
                callPayload.Queries["lang"] = CSharpExpressionConverter.Convert(lang);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<SpellcheckSearchGetResponse>(callPayload);
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

    public enum cacheControlInput
    {
        [EnumMember(Value = "no-cache")]
        NoCache
    }

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