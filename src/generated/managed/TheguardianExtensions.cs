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
        public IBodyWorkflowAction<SearchContentGetResponse> SearchContentGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> queryFields = null, [WorkflowExpression] Func<string> section = null, [WorkflowExpression] Func<string> reference = null, [WorkflowExpression] Func<string> referenceType = null, [WorkflowExpression] Func<string> tag = null, [WorkflowExpression] Func<string> rights = null, [WorkflowExpression] Func<string> ids = null, [WorkflowExpression] Func<string> productionOffice = null, [WorkflowExpression] Func<string> lang = null, [WorkflowExpression] Func<starRatingInput> starRating = null, [WorkflowExpression] Func<string> fromDate = null, [WorkflowExpression] Func<string> toDate = null, [WorkflowExpression] Func<useDateInput> useDate = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<orderByInput> orderBy = null, [WorkflowExpression] Func<orderDateInput> orderDate = null, [WorkflowExpression] Func<string> showFields = null, [WorkflowExpression] Func<string> trailText = null, [WorkflowExpression] Func<string> headline = null, [WorkflowExpression] Func<showInRelatedContentInput> showInRelatedContent = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<string> lastModified = null, [WorkflowExpression] Func<hasStoryPackageInput> hasStoryPackage = null, [WorkflowExpression] Func<string> score = null, [WorkflowExpression] Func<string> standfirst = null, [WorkflowExpression] Func<string> shortUrl = null, [WorkflowExpression] Func<string> thumbnail = null, [WorkflowExpression] Func<string> wordcount = null, [WorkflowExpression] Func<commentableInput> commentable = null, [WorkflowExpression] Func<isPremoderatedInput> isPremoderated = null, [WorkflowExpression] Func<allowUgcInput> allowUgc = null, [WorkflowExpression] Func<string> byline = null, [WorkflowExpression] Func<string> publication = null, [WorkflowExpression] Func<string> internalPageCode = null, [WorkflowExpression] Func<string> productionOffice2 = null, [WorkflowExpression] Func<shouldHideAdvertsInput> shouldHideAdverts = null, [WorkflowExpression] Func<liveBloggingNowInput> liveBloggingNow = null, [WorkflowExpression] Func<string> commentCloseDate = null, [WorkflowExpression] Func<showTagsInput> showTags = null, [WorkflowExpression] Func<showSectionInput> showSection = null, [WorkflowExpression] Func<showBlocksInput> showBlocks = null, [WorkflowExpression] Func<showElementsInput> showElements = null, [WorkflowExpression] Func<showReferencesInput> showReferences = null, [WorkflowExpression] Func<showRightsInput> showRights = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (queryFields != null)
                    callPayload.Queries["query-fields"] = SourceExpressionConverter.ConvertO(queryFields);
                if (section != null)
                    callPayload.Queries["section"] = SourceExpressionConverter.ConvertO(section);
                if (reference != null)
                    callPayload.Queries["reference"] = SourceExpressionConverter.ConvertO(reference);
                if (referenceType != null)
                    callPayload.Queries["reference-type"] = SourceExpressionConverter.ConvertO(referenceType);
                if (tag != null)
                    callPayload.Queries["tag"] = SourceExpressionConverter.ConvertO(tag);
                if (rights != null)
                    callPayload.Queries["rights"] = SourceExpressionConverter.ConvertO(rights);
                if (ids != null)
                    callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                if (productionOffice != null)
                    callPayload.Queries["production-office"] = SourceExpressionConverter.ConvertO(productionOffice);
                callPayload.Queries["lang"] = Convert.ToString("en");
                if (lang != null)
                    callPayload.Queries["lang"] = SourceExpressionConverter.ConvertO(lang);
                if (starRating != null)
                    callPayload.Queries["star-rating"] = SourceExpressionConverter.Convert(starRating);
                if (fromDate != null)
                    callPayload.Queries["from-date"] = SourceExpressionConverter.ConvertO(fromDate);
                if (toDate != null)
                    callPayload.Queries["to-date"] = SourceExpressionConverter.ConvertO(toDate);
                if (useDate != null)
                    callPayload.Queries["use-date"] = SourceExpressionConverter.Convert(useDate);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page-size"] = SourceExpressionConverter.ConvertO(pageSize);
                callPayload.Queries["order-by"] = Convert.ToString("relevance");
                if (orderBy != null)
                    callPayload.Queries["order-by"] = SourceExpressionConverter.Convert(orderBy);
                callPayload.Queries["order-date"] = Convert.ToString("published");
                if (orderDate != null)
                    callPayload.Queries["order-date"] = SourceExpressionConverter.Convert(orderDate);
                if (showFields != null)
                    callPayload.Queries["show-fields"] = SourceExpressionConverter.ConvertO(showFields);
                if (trailText != null)
                    callPayload.Queries["trailText"] = SourceExpressionConverter.ConvertO(trailText);
                if (headline != null)
                    callPayload.Queries["headline"] = SourceExpressionConverter.ConvertO(headline);
                if (showInRelatedContent != null)
                    callPayload.Queries["showInRelatedContent"] = SourceExpressionConverter.Convert(showInRelatedContent);
                if (body != null)
                    callPayload.Queries["body"] = SourceExpressionConverter.ConvertO(body);
                if (lastModified != null)
                    callPayload.Queries["lastModified"] = SourceExpressionConverter.ConvertO(lastModified);
                if (hasStoryPackage != null)
                    callPayload.Queries["hasStoryPackage"] = SourceExpressionConverter.Convert(hasStoryPackage);
                if (score != null)
                    callPayload.Queries["score"] = SourceExpressionConverter.ConvertO(score);
                if (standfirst != null)
                    callPayload.Queries["standfirst"] = SourceExpressionConverter.ConvertO(standfirst);
                if (shortUrl != null)
                    callPayload.Queries["shortUrl"] = SourceExpressionConverter.ConvertO(shortUrl);
                if (thumbnail != null)
                    callPayload.Queries["thumbnail"] = SourceExpressionConverter.ConvertO(thumbnail);
                if (wordcount != null)
                    callPayload.Queries["wordcount"] = SourceExpressionConverter.ConvertO(wordcount);
                if (commentable != null)
                    callPayload.Queries["commentable"] = SourceExpressionConverter.Convert(commentable);
                if (isPremoderated != null)
                    callPayload.Queries["isPremoderated"] = SourceExpressionConverter.Convert(isPremoderated);
                if (allowUgc != null)
                    callPayload.Queries["allowUgc"] = SourceExpressionConverter.Convert(allowUgc);
                if (byline != null)
                    callPayload.Queries["byline"] = SourceExpressionConverter.ConvertO(byline);
                if (publication != null)
                    callPayload.Queries["publication"] = SourceExpressionConverter.ConvertO(publication);
                if (internalPageCode != null)
                    callPayload.Queries["internalPageCode"] = SourceExpressionConverter.ConvertO(internalPageCode);
                if (productionOffice2 != null)
                    callPayload.Queries["productionOffice"] = SourceExpressionConverter.ConvertO(productionOffice2);
                callPayload.Queries["shouldHideAdverts"] = Convert.ToString("true");
                if (shouldHideAdverts != null)
                    callPayload.Queries["shouldHideAdverts"] = SourceExpressionConverter.Convert(shouldHideAdverts);
                if (liveBloggingNow != null)
                    callPayload.Queries["liveBloggingNow"] = SourceExpressionConverter.Convert(liveBloggingNow);
                if (commentCloseDate != null)
                    callPayload.Queries["commentCloseDate"] = SourceExpressionConverter.ConvertO(commentCloseDate);
                if (showTags != null)
                    callPayload.Queries["show-tags"] = SourceExpressionConverter.Convert(showTags);
                if (showSection != null)
                    callPayload.Queries["show-section"] = SourceExpressionConverter.Convert(showSection);
                if (showBlocks != null)
                    callPayload.Queries["show-blocks"] = SourceExpressionConverter.Convert(showBlocks);
                if (showElements != null)
                    callPayload.Queries["show-elements"] = SourceExpressionConverter.Convert(showElements);
                if (showReferences != null)
                    callPayload.Queries["show-references"] = SourceExpressionConverter.Convert(showReferences);
                if (showRights != null)
                    callPayload.Queries["show-rights"] = SourceExpressionConverter.Convert(showRights);
                return callPayload;
            }

            return new ApiConnectionAction<SearchContentGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<TagsGetResponse> TagsGet([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> webTitle = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<string> section = null, [WorkflowExpression] Func<string> reference = null, [WorkflowExpression] Func<string> referenceType = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<showReferencesInput> showReferences = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tags";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (webTitle != null)
                    callPayload.Queries["web-title"] = SourceExpressionConverter.ConvertO(webTitle);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                if (section != null)
                    callPayload.Queries["section"] = SourceExpressionConverter.ConvertO(section);
                if (reference != null)
                    callPayload.Queries["reference"] = SourceExpressionConverter.ConvertO(reference);
                if (referenceType != null)
                    callPayload.Queries["reference-type"] = SourceExpressionConverter.ConvertO(referenceType);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page-size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (showReferences != null)
                    callPayload.Queries["show-references"] = SourceExpressionConverter.Convert(showReferences);
                return callPayload;
            }

            return new ApiConnectionAction<TagsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<SectionsGetResponse> SectionsGet([WorkflowExpression] Func<string> q = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/sections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<SectionsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<EditionsGetResponse> EditionsGet([WorkflowExpression] Func<string> q = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/editions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                return callPayload;
            }

            return new ApiConnectionAction<EditionsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "theguardian")]
        public IBodyWorkflowAction<ItemGetResponse> ItemGet([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ItemGetResponse>(BuildSourceInput);
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
        _1 = 1,
        _2 = 2,
        _3 = 3,
        _4 = 4,
        _5 = 5
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