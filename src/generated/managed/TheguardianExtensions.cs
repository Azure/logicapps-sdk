//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Theguardian
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TheguardianActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<SearchContentGetResponse, ApiConnectionActionConfiguration> SearchContentGet(Expression<Func<string>> q, Expression<Func<string>> queryFields = null, Expression<Func<string>> section = null, Expression<Func<string>> reference = null, Expression<Func<string>> referenceType = null, Expression<Func<string>> tag = null, Expression<Func<string>> rights = null, Expression<Func<string>> ids = null, Expression<Func<string>> productionOffice = null, Expression<Func<string>> lang = null, Expression<Func<StarRatingInput>> starRating = null, Expression<Func<string>> fromDate = null, Expression<Func<string>> toDate = null, Expression<Func<UseDateInput>> useDate = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<OrderByInput>> orderBy = null, Expression<Func<OrderDateInput>> orderDate = null, Expression<Func<string>> showFields = null, Expression<Func<string>> trailText = null, Expression<Func<string>> headline = null, Expression<Func<ShowInRelatedContentInput>> showInRelatedContent = null, Expression<Func<string>> body = null, Expression<Func<string>> lastModified = null, Expression<Func<HasStoryPackageInput>> hasStoryPackage = null, Expression<Func<string>> score = null, Expression<Func<string>> standfirst = null, Expression<Func<string>> shortUrl = null, Expression<Func<string>> thumbnail = null, Expression<Func<string>> wordcount = null, Expression<Func<CommentableInput>> commentable = null, Expression<Func<IsPremoderatedInput>> isPremoderated = null, Expression<Func<AllowUgcInput>> allowUgc = null, Expression<Func<string>> byline = null, Expression<Func<string>> publication = null, Expression<Func<string>> internalPageCode = null, Expression<Func<string>> productionOffice2 = null, Expression<Func<ShouldHideAdvertsInput>> shouldHideAdverts = null, Expression<Func<LiveBloggingNowInput>> liveBloggingNow = null, Expression<Func<string>> commentCloseDate = null, Expression<Func<ShowTagsInput>> showTags = null, Expression<Func<ShowSectionInput>> showSection = null, Expression<Func<ShowBlocksInput>> showBlocks = null, Expression<Func<ShowElementsInput>> showElements = null, Expression<Func<ShowReferencesInput>> showReferences = null, Expression<Func<ShowRightsInput>> showRights = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_queryFields = WorkflowExpression.Compile(queryFields, nameof(queryFields), required: false);
            var __workflow_section = WorkflowExpression.Compile(section, nameof(section), required: false);
            var __workflow_reference = WorkflowExpression.Compile(reference, nameof(reference), required: false);
            var __workflow_referenceType = WorkflowExpression.Compile(referenceType, nameof(referenceType), required: false);
            var __workflow_tag = WorkflowExpression.Compile(tag, nameof(tag), required: false);
            var __workflow_rights = WorkflowExpression.Compile(rights, nameof(rights), required: false);
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            var __workflow_productionOffice = WorkflowExpression.Compile(productionOffice, nameof(productionOffice), required: false);
            var __workflow_lang = WorkflowExpression.Compile(lang, nameof(lang), required: false);
            var __workflow_starRating = WorkflowExpression.Compile(starRating, nameof(starRating), required: false);
            var __workflow_fromDate = WorkflowExpression.Compile(fromDate, nameof(fromDate), required: false);
            var __workflow_toDate = WorkflowExpression.Compile(toDate, nameof(toDate), required: false);
            var __workflow_useDate = WorkflowExpression.Compile(useDate, nameof(useDate), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_orderDate = WorkflowExpression.Compile(orderDate, nameof(orderDate), required: false);
            var __workflow_showFields = WorkflowExpression.Compile(showFields, nameof(showFields), required: false);
            var __workflow_trailText = WorkflowExpression.Compile(trailText, nameof(trailText), required: false);
            var __workflow_headline = WorkflowExpression.Compile(headline, nameof(headline), required: false);
            var __workflow_showInRelatedContent = WorkflowExpression.Compile(showInRelatedContent, nameof(showInRelatedContent), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            var __workflow_hasStoryPackage = WorkflowExpression.Compile(hasStoryPackage, nameof(hasStoryPackage), required: false);
            var __workflow_score = WorkflowExpression.Compile(score, nameof(score), required: false);
            var __workflow_standfirst = WorkflowExpression.Compile(standfirst, nameof(standfirst), required: false);
            var __workflow_shortUrl = WorkflowExpression.Compile(shortUrl, nameof(shortUrl), required: false);
            var __workflow_thumbnail = WorkflowExpression.Compile(thumbnail, nameof(thumbnail), required: false);
            var __workflow_wordcount = WorkflowExpression.Compile(wordcount, nameof(wordcount), required: false);
            var __workflow_commentable = WorkflowExpression.Compile(commentable, nameof(commentable), required: false);
            var __workflow_isPremoderated = WorkflowExpression.Compile(isPremoderated, nameof(isPremoderated), required: false);
            var __workflow_allowUgc = WorkflowExpression.Compile(allowUgc, nameof(allowUgc), required: false);
            var __workflow_byline = WorkflowExpression.Compile(byline, nameof(byline), required: false);
            var __workflow_publication = WorkflowExpression.Compile(publication, nameof(publication), required: false);
            var __workflow_internalPageCode = WorkflowExpression.Compile(internalPageCode, nameof(internalPageCode), required: false);
            var __workflow_productionOffice2 = WorkflowExpression.Compile(productionOffice2, nameof(productionOffice2), required: false);
            var __workflow_shouldHideAdverts = WorkflowExpression.Compile(shouldHideAdverts, nameof(shouldHideAdverts), required: false);
            var __workflow_liveBloggingNow = WorkflowExpression.Compile(liveBloggingNow, nameof(liveBloggingNow), required: false);
            var __workflow_commentCloseDate = WorkflowExpression.Compile(commentCloseDate, nameof(commentCloseDate), required: false);
            var __workflow_showTags = WorkflowExpression.Compile(showTags, nameof(showTags), required: false);
            var __workflow_showSection = WorkflowExpression.Compile(showSection, nameof(showSection), required: false);
            var __workflow_showBlocks = WorkflowExpression.Compile(showBlocks, nameof(showBlocks), required: false);
            var __workflow_showElements = WorkflowExpression.Compile(showElements, nameof(showElements), required: false);
            var __workflow_showReferences = WorkflowExpression.Compile(showReferences, nameof(showReferences), required: false);
            var __workflow_showRights = WorkflowExpression.Compile(showRights, nameof(showRights), required: false);
            return new DeferredBodyAction<SearchContentGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_queryFields != null)
                    callPayload.Queries["query-fields"] = ExpressionConverter.Convert(__workflow_queryFields);
                if (__workflow_section != null)
                    callPayload.Queries["section"] = ExpressionConverter.Convert(__workflow_section);
                if (__workflow_reference != null)
                    callPayload.Queries["reference"] = ExpressionConverter.Convert(__workflow_reference);
                if (__workflow_referenceType != null)
                    callPayload.Queries["reference-type"] = ExpressionConverter.Convert(__workflow_referenceType);
                if (__workflow_tag != null)
                    callPayload.Queries["tag"] = ExpressionConverter.Convert(__workflow_tag);
                if (__workflow_rights != null)
                    callPayload.Queries["rights"] = ExpressionConverter.Convert(__workflow_rights);
                if (__workflow_ids != null)
                    callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                if (__workflow_productionOffice != null)
                    callPayload.Queries["production-office"] = ExpressionConverter.Convert(__workflow_productionOffice);
                callPayload.Queries["lang"] = Convert.ToString("en");
                if (__workflow_lang != null)
                    callPayload.Queries["lang"] = ExpressionConverter.Convert(__workflow_lang);
                if (__workflow_starRating != null)
                    callPayload.Queries["star-rating"] = ExpressionConverter.Convert(__workflow_starRating);
                if (__workflow_fromDate != null)
                    callPayload.Queries["from-date"] = ExpressionConverter.Convert(__workflow_fromDate);
                if (__workflow_toDate != null)
                    callPayload.Queries["to-date"] = ExpressionConverter.Convert(__workflow_toDate);
                if (__workflow_useDate != null)
                    callPayload.Queries["use-date"] = ExpressionConverter.Convert(__workflow_useDate);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page-size"] = ExpressionConverter.Convert(__workflow_pageSize);
                callPayload.Queries["order-by"] = Convert.ToString("relevance");
                if (__workflow_orderBy != null)
                    callPayload.Queries["order-by"] = ExpressionConverter.Convert(__workflow_orderBy);
                callPayload.Queries["order-date"] = Convert.ToString("published");
                if (__workflow_orderDate != null)
                    callPayload.Queries["order-date"] = ExpressionConverter.Convert(__workflow_orderDate);
                if (__workflow_showFields != null)
                    callPayload.Queries["show-fields"] = ExpressionConverter.Convert(__workflow_showFields);
                if (__workflow_trailText != null)
                    callPayload.Queries["trailText"] = ExpressionConverter.Convert(__workflow_trailText);
                if (__workflow_headline != null)
                    callPayload.Queries["headline"] = ExpressionConverter.Convert(__workflow_headline);
                if (__workflow_showInRelatedContent != null)
                    callPayload.Queries["showInRelatedContent"] = ExpressionConverter.Convert(__workflow_showInRelatedContent);
                if (__workflow_body != null)
                    callPayload.Queries["body"] = ExpressionConverter.Convert(__workflow_body);
                if (__workflow_lastModified != null)
                    callPayload.Queries["lastModified"] = ExpressionConverter.Convert(__workflow_lastModified);
                if (__workflow_hasStoryPackage != null)
                    callPayload.Queries["hasStoryPackage"] = ExpressionConverter.Convert(__workflow_hasStoryPackage);
                if (__workflow_score != null)
                    callPayload.Queries["score"] = ExpressionConverter.Convert(__workflow_score);
                if (__workflow_standfirst != null)
                    callPayload.Queries["standfirst"] = ExpressionConverter.Convert(__workflow_standfirst);
                if (__workflow_shortUrl != null)
                    callPayload.Queries["shortUrl"] = ExpressionConverter.Convert(__workflow_shortUrl);
                if (__workflow_thumbnail != null)
                    callPayload.Queries["thumbnail"] = ExpressionConverter.Convert(__workflow_thumbnail);
                if (__workflow_wordcount != null)
                    callPayload.Queries["wordcount"] = ExpressionConverter.Convert(__workflow_wordcount);
                if (__workflow_commentable != null)
                    callPayload.Queries["commentable"] = ExpressionConverter.Convert(__workflow_commentable);
                if (__workflow_isPremoderated != null)
                    callPayload.Queries["isPremoderated"] = ExpressionConverter.Convert(__workflow_isPremoderated);
                if (__workflow_allowUgc != null)
                    callPayload.Queries["allowUgc"] = ExpressionConverter.Convert(__workflow_allowUgc);
                if (__workflow_byline != null)
                    callPayload.Queries["byline"] = ExpressionConverter.Convert(__workflow_byline);
                if (__workflow_publication != null)
                    callPayload.Queries["publication"] = ExpressionConverter.Convert(__workflow_publication);
                if (__workflow_internalPageCode != null)
                    callPayload.Queries["internalPageCode"] = ExpressionConverter.Convert(__workflow_internalPageCode);
                if (__workflow_productionOffice2 != null)
                    callPayload.Queries["productionOffice"] = ExpressionConverter.Convert(__workflow_productionOffice2);
                callPayload.Queries["shouldHideAdverts"] = Convert.ToString("true");
                if (__workflow_shouldHideAdverts != null)
                    callPayload.Queries["shouldHideAdverts"] = ExpressionConverter.Convert(__workflow_shouldHideAdverts);
                if (__workflow_liveBloggingNow != null)
                    callPayload.Queries["liveBloggingNow"] = ExpressionConverter.Convert(__workflow_liveBloggingNow);
                if (__workflow_commentCloseDate != null)
                    callPayload.Queries["commentCloseDate"] = ExpressionConverter.Convert(__workflow_commentCloseDate);
                if (__workflow_showTags != null)
                    callPayload.Queries["show-tags"] = ExpressionConverter.Convert(__workflow_showTags);
                if (__workflow_showSection != null)
                    callPayload.Queries["show-section"] = ExpressionConverter.Convert(__workflow_showSection);
                if (__workflow_showBlocks != null)
                    callPayload.Queries["show-blocks"] = ExpressionConverter.Convert(__workflow_showBlocks);
                if (__workflow_showElements != null)
                    callPayload.Queries["show-elements"] = ExpressionConverter.Convert(__workflow_showElements);
                if (__workflow_showReferences != null)
                    callPayload.Queries["show-references"] = ExpressionConverter.Convert(__workflow_showReferences);
                if (__workflow_showRights != null)
                    callPayload.Queries["show-rights"] = ExpressionConverter.Convert(__workflow_showRights);
                return new ApiConnectionAction<SearchContentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<TagsGetResponse, ApiConnectionActionConfiguration> TagsGet(Expression<Func<string>> q = null, Expression<Func<string>> webTitle = null, Expression<Func<string>> type = null, Expression<Func<string>> section = null, Expression<Func<string>> reference = null, Expression<Func<string>> referenceType = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<ShowReferencesInput>> showReferences = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            var __workflow_webTitle = WorkflowExpression.Compile(webTitle, nameof(webTitle), required: false);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_section = WorkflowExpression.Compile(section, nameof(section), required: false);
            var __workflow_reference = WorkflowExpression.Compile(reference, nameof(reference), required: false);
            var __workflow_referenceType = WorkflowExpression.Compile(referenceType, nameof(referenceType), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_showReferences = WorkflowExpression.Compile(showReferences, nameof(showReferences), required: false);
            return new DeferredBodyAction<TagsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_webTitle != null)
                    callPayload.Queries["web-title"] = ExpressionConverter.Convert(__workflow_webTitle);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_section != null)
                    callPayload.Queries["section"] = ExpressionConverter.Convert(__workflow_section);
                if (__workflow_reference != null)
                    callPayload.Queries["reference"] = ExpressionConverter.Convert(__workflow_reference);
                if (__workflow_referenceType != null)
                    callPayload.Queries["reference-type"] = ExpressionConverter.Convert(__workflow_referenceType);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page-size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_showReferences != null)
                    callPayload.Queries["show-references"] = ExpressionConverter.Convert(__workflow_showReferences);
                return new ApiConnectionAction<TagsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<SectionsGetResponse, ApiConnectionActionConfiguration> SectionsGet(Expression<Func<string>> q = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<SectionsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<SectionsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<EditionsGetResponse, ApiConnectionActionConfiguration> EditionsGet(Expression<Func<string>> q = null)
        {
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: false);
            return new DeferredBodyAction<EditionsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/editions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                return new ApiConnectionAction<EditionsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<ItemGetResponse, ApiConnectionActionConfiguration> ItemGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ItemGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ItemGetResponse>(callPayload);
            });
        }
    }

    public class TheguardianTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchContentGetResponse
    {
        [JsonProperty("response")]
        public SearchContentGetResponseResponseType Response { get; set; }
    }

    public class SearchContentGetResponseResponseType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("userTier")]
        public string UserTier { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("orderBy")]
        public string OrderBy { get; set; }

        [JsonProperty("results")]
        public SearchContentGetResponseResponseTypeResultsTypeItem[] Results { get; set; }
    }

    public class SearchContentGetResponseResponseTypeResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sectionId")]
        public string SectionId { get; set; }

        [JsonProperty("sectionName")]
        public string SectionName { get; set; }

        [JsonProperty("webPublicationDate")]
        public string WebPublicationDate { get; set; }

        [JsonProperty("webTitle")]
        public string WebTitle { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("apiUrl")]
        public string ApiUrl { get; set; }

        [JsonProperty("isHosted")]
        public bool IsHosted { get; set; }

        [JsonProperty("pillarId")]
        public string PillarId { get; set; }

        [JsonProperty("pillarName")]
        public string PillarName { get; set; }
    }

    public enum StarRatingInput
    {
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UseDateInput
    {
        [EnumMember(Value = "published")]
        Published,
        [EnumMember(Value = "first-publication")]
        FirstPublication,
        [EnumMember(Value = "newspaper-edition")]
        NewspaperEdition,
        [EnumMember(Value = "last-modified")]
        LastModified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderByInput
    {
        [EnumMember(Value = "relevance")]
        Relevance,
        [EnumMember(Value = "newest")]
        Newest,
        [EnumMember(Value = "oldest")]
        Oldest
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderDateInput
    {
        [EnumMember(Value = "published")]
        Published,
        [EnumMember(Value = "newspaper-edition")]
        NewspaperEdition,
        [EnumMember(Value = "last-modified")]
        LastModified
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ShowInRelatedContentInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HasStoryPackageInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CommentableInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum IsPremoderatedInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AllowUgcInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ShouldHideAdvertsInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LiveBloggingNowInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ShowTagsInput
    {
        [EnumMember(Value = "blog")]
        Blog,
        [EnumMember(Value = "contributor")]
        Contributor,
        [EnumMember(Value = "keyword")]
        Keyword,
        [EnumMember(Value = "newspaper-book")]
        NewspaperBook,
        [EnumMember(Value = "newspaper-book-section")]
        NewspaperBookSection,
        [EnumMember(Value = "publication")]
        Publication,
        [EnumMember(Value = "series")]
        Series,
        [EnumMember(Value = "tone")]
        Tone,
        [EnumMember(Value = "type")]
        Type,
        [EnumMember(Value = "all")]
        All
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ShowSectionInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ShowBlocksInput
    {
        [EnumMember(Value = "main")]
        Main,
        [EnumMember(Value = "body")]
        Body,
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "body:latest")]
        BodyLatest,
        [EnumMember(Value = "body:oldest")]
        BodyOldest,
        [EnumMember(Value = "body:key-events")]
        BodyKeyEvents
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ShowElementsInput
    {
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "image")]
        Image,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "all")]
        All
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ShowReferencesInput
    {
        [EnumMember(Value = "author")]
        Author,
        [EnumMember(Value = "bisac-prefix")]
        BisacPrefix,
        [EnumMember(Value = "esa-cricket-match")]
        EsaCricketMatch,
        [EnumMember(Value = "esa-football-match")]
        EsaFootballMatch,
        [EnumMember(Value = "esa-football-team")]
        EsaFootballTeam,
        [EnumMember(Value = "esa-football-tournament")]
        EsaFootballTournament,
        [EnumMember(Value = "isbn")]
        Isbn,
        [EnumMember(Value = "imdb")]
        Imdb,
        [EnumMember(Value = "musicbrainz")]
        Musicbrainz,
        [EnumMember(Value = "musicbrainzgenre")]
        Musicbrainzgenre,
        [EnumMember(Value = "opta-cricket-match")]
        OptaCricketMatch,
        [EnumMember(Value = "opta-football-match")]
        OptaFootballMatch,
        [EnumMember(Value = "opta-football-team")]
        OptaFootballTeam,
        [EnumMember(Value = "opta-football-tournament")]
        OptaFootballTournament,
        [EnumMember(Value = "pa-football-competition")]
        PaFootballCompetition,
        [EnumMember(Value = "pa-football-match")]
        PaFootballMatch,
        [EnumMember(Value = "pa-football-team")]
        PaFootballTeam,
        [EnumMember(Value = "r1-film")]
        R1Film,
        [EnumMember(Value = "reuters-index-ric")]
        ReutersIndexRic,
        [EnumMember(Value = "reuters-stock-ric")]
        ReutersStockRic,
        [EnumMember(Value = "witness-assignment")]
        WitnessAssignment
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ShowRightsInput
    {
        [EnumMember(Value = "syndicatable")]
        Syndicatable,
        [EnumMember(Value = "subrscription-databases")]
        SubrscriptionDatabases,
        [EnumMember(Value = "all")]
        All
    }

    public class TagsGetResponse
    {
        [JsonProperty("response")]
        public TagsGetResponseResponseType Response { get; set; }
    }

    public class TagsGetResponseResponseType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("userTier")]
        public string UserTier { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("results")]
        public TagsGetResponseResponseTypeResultsTypeItem[] Results { get; set; }
    }

    public class TagsGetResponseResponseTypeResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("webTitle")]
        public string WebTitle { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("apiUrl")]
        public string ApiUrl { get; set; }

        [JsonProperty("sectionId")]
        public string SectionId { get; set; }

        [JsonProperty("sectionName")]
        public string SectionName { get; set; }
    }

    public class SectionsGetResponse
    {
        [JsonProperty("response")]
        public SectionsGetResponseResponseType Response { get; set; }
    }

    public class SectionsGetResponseResponseType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("userTier")]
        public string UserTier { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("results")]
        public SectionsGetResponseResponseTypeResultsTypeItem[] Results { get; set; }
    }

    public class SectionsGetResponseResponseTypeResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("webTitle")]
        public string WebTitle { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("apiUrl")]
        public string ApiUrl { get; set; }

        [JsonProperty("editions")]
        public SectionsGetResponseResponseTypeResultsTypeItemEditionsTypeItem[] Editions { get; set; }
    }

    public class SectionsGetResponseResponseTypeResultsTypeItemEditionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("webTitle")]
        public string WebTitle { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("apiUrl")]
        public string ApiUrl { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class EditionsGetResponse
    {
        [JsonProperty("response")]
        public EditionsGetResponseResponseType Response { get; set; }
    }

    public class EditionsGetResponseResponseType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("userTier")]
        public string UserTier { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("results")]
        public EditionsGetResponseResponseTypeResultsTypeItem[] Results { get; set; }
    }

    public class EditionsGetResponseResponseTypeResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("edition")]
        public string Edition { get; set; }

        [JsonProperty("webTitle")]
        public string WebTitle { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("apiUrl")]
        public string ApiUrl { get; set; }
    }

    public class ItemGetResponse
    {
        [JsonProperty("response")]
        public ItemGetResponseResponseType Response { get; set; }
    }

    public class ItemGetResponseResponseType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("userTier")]
        public string UserTier { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("content")]
        public ItemGetResponseResponseTypeContentType Content { get; set; }
    }

    public class ItemGetResponseResponseTypeContentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sectionId")]
        public string SectionId { get; set; }

        [JsonProperty("sectionName")]
        public string SectionName { get; set; }

        [JsonProperty("webPublicationDate")]
        public string WebPublicationDate { get; set; }

        [JsonProperty("webTitle")]
        public string WebTitle { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }

        [JsonProperty("apiUrl")]
        public string ApiUrl { get; set; }

        [JsonProperty("isHosted")]
        public bool IsHosted { get; set; }

        [JsonProperty("pillarId")]
        public string PillarId { get; set; }

        [JsonProperty("pillarName")]
        public string PillarName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Theguardian;

    public partial class WorkflowManagedActions
    {
        public TheguardianActions Theguardian(string connectionId) => new TheguardianActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TheguardianTriggers Theguardian(string connectionId) => new TheguardianTriggers(connectionId);
    }
}