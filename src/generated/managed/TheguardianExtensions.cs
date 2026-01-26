//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Theguardian
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TheguardianActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<SearchContentGetResponse> SearchContentGet(Expression<Func<string>> q, Expression<Func<string>> queryFields = null, Expression<Func<string>> section = null, Expression<Func<string>> reference = null, Expression<Func<string>> referenceType = null, Expression<Func<string>> tag = null, Expression<Func<string>> rights = null, Expression<Func<string>> ids = null, Expression<Func<string>> productionOffice = null, Expression<Func<string>> lang = null, Expression<Func<starRatingInput>> starRating = null, Expression<Func<string>> fromDate = null, Expression<Func<string>> toDate = null, Expression<Func<useDateInput>> useDate = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<orderByInput>> orderBy = null, Expression<Func<orderDateInput>> orderDate = null, Expression<Func<string>> showFields = null, Expression<Func<string>> trailText = null, Expression<Func<string>> headline = null, Expression<Func<showInRelatedContentInput>> showInRelatedContent = null, Expression<Func<string>> body = null, Expression<Func<string>> lastModified = null, Expression<Func<hasStoryPackageInput>> hasStoryPackage = null, Expression<Func<string>> score = null, Expression<Func<string>> standfirst = null, Expression<Func<string>> shortUrl = null, Expression<Func<string>> thumbnail = null, Expression<Func<string>> wordcount = null, Expression<Func<commentableInput>> commentable = null, Expression<Func<isPremoderatedInput>> isPremoderated = null, Expression<Func<allowUgcInput>> allowUgc = null, Expression<Func<string>> byline = null, Expression<Func<string>> publication = null, Expression<Func<string>> internalPageCode = null, Expression<Func<string>> productionOffice = null, Expression<Func<shouldHideAdvertsInput>> shouldHideAdverts = null, Expression<Func<liveBloggingNowInput>> liveBloggingNow = null, Expression<Func<string>> commentCloseDate = null, Expression<Func<showTagsInput>> showTags = null, Expression<Func<showSectionInput>> showSection = null, Expression<Func<showBlocksInput>> showBlocks = null, Expression<Func<showElementsInput>> showElements = null, Expression<Func<showReferencesInput>> showReferences = null, Expression<Func<showRightsInput>> showRights = null)
        {
            var apiCallPath = "/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (queryFields != null)
                callPayload.Queries["query-fields"] = ExpressionConverter.Convert(queryFields);
            if (section != null)
                callPayload.Queries["section"] = ExpressionConverter.Convert(section);
            if (reference != null)
                callPayload.Queries["reference"] = ExpressionConverter.Convert(reference);
            if (referenceType != null)
                callPayload.Queries["reference-type"] = ExpressionConverter.Convert(referenceType);
            if (tag != null)
                callPayload.Queries["tag"] = ExpressionConverter.Convert(tag);
            if (rights != null)
                callPayload.Queries["rights"] = ExpressionConverter.Convert(rights);
            if (ids != null)
                callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            if (productionOffice != null)
                callPayload.Queries["production-office"] = ExpressionConverter.Convert(productionOffice);
            callPayload.Queries["lang"] = Convert.ToString("en");
            if (lang != null)
                callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
            if (starRating != null)
                callPayload.Queries["star-rating"] = ExpressionConverter.Convert(starRating);
            if (fromDate != null)
                callPayload.Queries["from-date"] = ExpressionConverter.Convert(fromDate);
            if (toDate != null)
                callPayload.Queries["to-date"] = ExpressionConverter.Convert(toDate);
            if (useDate != null)
                callPayload.Queries["use-date"] = ExpressionConverter.Convert(useDate);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["page-size"] = ExpressionConverter.Convert(pageSize);
            callPayload.Queries["order-by"] = Convert.ToString("relevance");
            if (orderBy != null)
                callPayload.Queries["order-by"] = ExpressionConverter.Convert(orderBy);
            callPayload.Queries["order-date"] = Convert.ToString("published");
            if (orderDate != null)
                callPayload.Queries["order-date"] = ExpressionConverter.Convert(orderDate);
            if (showFields != null)
                callPayload.Queries["show-fields"] = ExpressionConverter.Convert(showFields);
            if (trailText != null)
                callPayload.Queries["trailText"] = ExpressionConverter.Convert(trailText);
            if (headline != null)
                callPayload.Queries["headline"] = ExpressionConverter.Convert(headline);
            if (showInRelatedContent != null)
                callPayload.Queries["showInRelatedContent"] = ExpressionConverter.Convert(showInRelatedContent);
            if (body != null)
                callPayload.Queries["body"] = ExpressionConverter.Convert(body);
            if (lastModified != null)
                callPayload.Queries["lastModified"] = ExpressionConverter.Convert(lastModified);
            if (hasStoryPackage != null)
                callPayload.Queries["hasStoryPackage"] = ExpressionConverter.Convert(hasStoryPackage);
            if (score != null)
                callPayload.Queries["score"] = ExpressionConverter.Convert(score);
            if (standfirst != null)
                callPayload.Queries["standfirst"] = ExpressionConverter.Convert(standfirst);
            if (shortUrl != null)
                callPayload.Queries["shortUrl"] = ExpressionConverter.Convert(shortUrl);
            if (thumbnail != null)
                callPayload.Queries["thumbnail"] = ExpressionConverter.Convert(thumbnail);
            if (wordcount != null)
                callPayload.Queries["wordcount"] = ExpressionConverter.Convert(wordcount);
            if (commentable != null)
                callPayload.Queries["commentable"] = ExpressionConverter.Convert(commentable);
            if (isPremoderated != null)
                callPayload.Queries["isPremoderated"] = ExpressionConverter.Convert(isPremoderated);
            if (allowUgc != null)
                callPayload.Queries["allowUgc"] = ExpressionConverter.Convert(allowUgc);
            if (byline != null)
                callPayload.Queries["byline"] = ExpressionConverter.Convert(byline);
            if (publication != null)
                callPayload.Queries["publication"] = ExpressionConverter.Convert(publication);
            if (internalPageCode != null)
                callPayload.Queries["internalPageCode"] = ExpressionConverter.Convert(internalPageCode);
            if (productionOffice != null)
                callPayload.Queries["productionOffice"] = ExpressionConverter.Convert(productionOffice);
            callPayload.Queries["shouldHideAdverts"] = Convert.ToString("true");
            if (shouldHideAdverts != null)
                callPayload.Queries["shouldHideAdverts"] = ExpressionConverter.Convert(shouldHideAdverts);
            if (liveBloggingNow != null)
                callPayload.Queries["liveBloggingNow"] = ExpressionConverter.Convert(liveBloggingNow);
            if (commentCloseDate != null)
                callPayload.Queries["commentCloseDate"] = ExpressionConverter.Convert(commentCloseDate);
            if (showTags != null)
                callPayload.Queries["show-tags"] = ExpressionConverter.Convert(showTags);
            if (showSection != null)
                callPayload.Queries["show-section"] = ExpressionConverter.Convert(showSection);
            if (showBlocks != null)
                callPayload.Queries["show-blocks"] = ExpressionConverter.Convert(showBlocks);
            if (showElements != null)
                callPayload.Queries["show-elements"] = ExpressionConverter.Convert(showElements);
            if (showReferences != null)
                callPayload.Queries["show-references"] = ExpressionConverter.Convert(showReferences);
            if (showRights != null)
                callPayload.Queries["show-rights"] = ExpressionConverter.Convert(showRights);
            return new ApiConnectionAction<SearchContentGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<TagsGetResponse> TagsGet(Expression<Func<string>> q = null, Expression<Func<string>> webTitle = null, Expression<Func<string>> type = null, Expression<Func<string>> section = null, Expression<Func<string>> reference = null, Expression<Func<string>> referenceType = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<showReferencesInput>> showReferences = null)
        {
            var apiCallPath = "/tags";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (webTitle != null)
                callPayload.Queries["web-title"] = ExpressionConverter.Convert(webTitle);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (section != null)
                callPayload.Queries["section"] = ExpressionConverter.Convert(section);
            if (reference != null)
                callPayload.Queries["reference"] = ExpressionConverter.Convert(reference);
            if (referenceType != null)
                callPayload.Queries["reference-type"] = ExpressionConverter.Convert(referenceType);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (pageSize != null)
                callPayload.Queries["page-size"] = ExpressionConverter.Convert(pageSize);
            if (showReferences != null)
                callPayload.Queries["show-references"] = ExpressionConverter.Convert(showReferences);
            return new ApiConnectionAction<TagsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<SectionsGetResponse> SectionsGet(Expression<Func<string>> q = null)
        {
            var apiCallPath = "/sections";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<SectionsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<EditionsGetResponse> EditionsGet(Expression<Func<string>> q = null)
        {
            var apiCallPath = "/editions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            return new ApiConnectionAction<EditionsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<ItemGetResponse> ItemGet(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ItemGetResponse>(callPayload);
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

    public enum starRatingInput
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5
    }

    public enum useDateInput
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

    public enum orderByInput
    {
        [EnumMember(Value = "relevance")]
        Relevance,
        [EnumMember(Value = "newest")]
        Newest,
        [EnumMember(Value = "oldest")]
        Oldest
    }

    public enum orderDateInput
    {
        [EnumMember(Value = "published")]
        Published,
        [EnumMember(Value = "newspaper-edition")]
        NewspaperEdition,
        [EnumMember(Value = "last-modified")]
        LastModified
    }

    public enum showInRelatedContentInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum hasStoryPackageInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum commentableInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum isPremoderatedInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum allowUgcInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum shouldHideAdvertsInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum liveBloggingNowInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum showTagsInput
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

    public enum showSectionInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public enum showBlocksInput
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

    public enum showElementsInput
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

    public enum showReferencesInput
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

    public enum showRightsInput
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