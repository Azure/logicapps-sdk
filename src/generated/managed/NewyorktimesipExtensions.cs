//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Newyorktimesip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NewyorktimesipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "newyorktimesip")]
        [WorkflowExpressionFactory(nameof(__BuildArticleSearch))]
        public IBodyWorkflowAction<ArticleSearchResponse> ArticleSearch([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> beginDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "newyorktimesip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ArticleSearchResponse> __BuildArticleSearch(WorkflowExpression<string> q, WorkflowExpression<string> beginDate = null, WorkflowExpression<string> endDate = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(beginDate, nameof(beginDate), required: false);
            WorkflowExpression.Validate(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<ArticleSearchResponse>(() =>
            {
                var apiCallPath = "/search/v2/articlesearch.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                if (beginDate != null)
                    callPayload.Queries["begin_date"] = ExpressionConverter.Convert(beginDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                return new ApiConnectionAction<ArticleSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "newyorktimesip")]
        [WorkflowExpressionFactory(nameof(__BuildTopStories))]
        public IBodyWorkflowAction<TopStoriesResponse> TopStories([WorkflowExpression] Func<sectionInput> section)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "newyorktimesip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TopStoriesResponse> __BuildTopStories(WorkflowExpression<sectionInput> section)
        {
            WorkflowExpression.Validate(section, nameof(section), required: true);
            return new DeferredBodyAction<TopStoriesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/topstories/v2/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(section, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TopStoriesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "newyorktimesip")]
        [WorkflowExpressionFactory(nameof(__BuildMostViewed))]
        public IBodyWorkflowAction<MostViewedResponse> MostViewed([WorkflowExpression] Func<periodInput> period)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "newyorktimesip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MostViewedResponse> __BuildMostViewed(WorkflowExpression<periodInput> period)
        {
            WorkflowExpression.Validate(period, nameof(period), required: true);
            return new DeferredBodyAction<MostViewedResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/mostpopular/v2/viewed/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(period, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MostViewedResponse>(callPayload);
            });
        }
    }

    public class NewyorktimesipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ArticleSearchResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("response")]
        public ArticleSearchResponseResponseType Response { get; set; }
    }

    public class ArticleSearchResponseResponseType
    {
        [JsonProperty("docs")]
        public Article[] Docs { get; set; }

        [JsonProperty("meta")]
        public JToken Meta { get; set; }
    }

    public class Article
    {
        [JsonProperty("web_url")]
        public string WebUrl { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("print_page")]
        public string PrintPage { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("headline")]
        public Headline Headline { get; set; }

        [JsonProperty("keywords")]
        public Keyword[] Keywords { get; set; }

        [JsonProperty("pub_date")]
        public string PubDate { get; set; }

        [JsonProperty("document_type")]
        public string DocumentType { get; set; }

        [JsonProperty("news_desk")]
        public string NewsDesk { get; set; }

        [JsonProperty("type_of_material")]
        public string TypeOfMaterial { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class Headline
    {
        [JsonProperty("main")]
        public string Main { get; set; }

        [JsonProperty("kicker")]
        public string Kicker { get; set; }

        [JsonProperty("content_kicker")]
        public string ContentKicker { get; set; }

        [JsonProperty("print_headline")]
        public string PrintHeadline { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("seo")]
        public string Seo { get; set; }

        [JsonProperty("sub")]
        public string Sub { get; set; }
    }

    public class Keyword
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("major")]
        public string Major { get; set; }
    }

    public class TopStoriesResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("results")]
        public Article[] Results { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sectionInput
    {
        [EnumMember(Value = "arts")]
        Arts,
        [EnumMember(Value = "automobiles")]
        Automobiles,
        [EnumMember(Value = "books")]
        Books,
        [EnumMember(Value = "business")]
        Business,
        [EnumMember(Value = "fashion")]
        Fashion,
        [EnumMember(Value = "food")]
        Food,
        [EnumMember(Value = "health")]
        Health,
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "insider")]
        Insider,
        [EnumMember(Value = "magazine")]
        Magazine,
        [EnumMember(Value = "movies")]
        Movies,
        [EnumMember(Value = "nyregion")]
        Nyregion,
        [EnumMember(Value = "obituaries")]
        Obituaries,
        [EnumMember(Value = "opinion")]
        Opinion,
        [EnumMember(Value = "politics")]
        Politics,
        [EnumMember(Value = "realestate")]
        Realestate,
        [EnumMember(Value = "science")]
        Science,
        [EnumMember(Value = "sports")]
        Sports,
        [EnumMember(Value = "sundayreview")]
        Sundayreview,
        [EnumMember(Value = "technology")]
        Technology,
        [EnumMember(Value = "theater")]
        Theater,
        [EnumMember(Value = "t-magazine")]
        TMagazine,
        [EnumMember(Value = "travel")]
        Travel,
        [EnumMember(Value = "upshot")]
        Upshot,
        [EnumMember(Value = "us")]
        Us,
        [EnumMember(Value = "world")]
        World
    }

    public class MostViewedResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("results")]
        public ViewedArticle[] Results { get; set; }
    }

    public class ViewedArticle
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("adx_keywords")]
        public string AdxKeywords { get; set; }

        [JsonProperty("column")]
        public string Column { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("byline")]
        public string Byline { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("abstract")]
        public string Abstract { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("des_facet")]
        public string[] DesFacet { get; set; }

        [JsonProperty("org_facet")]
        public string[] OrgFacet { get; set; }

        [JsonProperty("per_facet")]
        public string[] PerFacet { get; set; }

        [JsonProperty("geo_facet")]
        public string[] GeoFacet { get; set; }

        [JsonProperty("media")]
        public Media[] Media { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class Media
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("media-metadata")]
        public MediaMetadata[] MediaMetadata { get; set; }
    }

    public class MediaMetadata
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum periodInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "7")]
        _7,
        [EnumMember(Value = "30")]
        _30
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Newyorktimesip;

    public partial class WorkflowManagedActions
    {
        public NewyorktimesipActions Newyorktimesip(string connectionId) => new NewyorktimesipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NewyorktimesipTriggers Newyorktimesip(string connectionId) => new NewyorktimesipTriggers(connectionId);
    }
}