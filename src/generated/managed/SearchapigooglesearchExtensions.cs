//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Searchapigooglesearch
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SearchapigooglesearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "searchapigooglesearch")]
        public IBodyWorkflowAction<SearchGetResponse> SearchGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<deviceInput> device = null, [WorkflowExpression] Func<string> location = null, [WorkflowExpression] Func<string> uule = null, [WorkflowExpression] Func<string> googleDomain = null, [WorkflowExpression] Func<string> gl = null, [WorkflowExpression] Func<string> hl = null, [WorkflowExpression] Func<string> lr = null, [WorkflowExpression] Func<string> cr = null, [WorkflowExpression] Func<nfprInput> nfpr = null, [WorkflowExpression] Func<filterInput> filter = null, [WorkflowExpression] Func<safeInput> safe = null, [WorkflowExpression] Func<int> num = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["engine"] = Convert.ToString("google");
                callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                callPayload.Queries["device"] = Convert.ToString("desktop");
                if (device != null)
                    callPayload.Queries["device"] = SourceExpressionConverter.Convert(device);
                if (location != null)
                    callPayload.Queries["location"] = SourceExpressionConverter.ConvertO(location);
                if (uule != null)
                    callPayload.Queries["uule"] = SourceExpressionConverter.ConvertO(uule);
                if (googleDomain != null)
                    callPayload.Queries["google_domain"] = SourceExpressionConverter.ConvertO(googleDomain);
                if (gl != null)
                    callPayload.Queries["gl"] = SourceExpressionConverter.ConvertO(gl);
                if (hl != null)
                    callPayload.Queries["hl"] = SourceExpressionConverter.ConvertO(hl);
                if (lr != null)
                    callPayload.Queries["lr"] = SourceExpressionConverter.ConvertO(lr);
                if (cr != null)
                    callPayload.Queries["cr"] = SourceExpressionConverter.ConvertO(cr);
                if (nfpr != null)
                    callPayload.Queries["nfpr"] = SourceExpressionConverter.Convert(nfpr);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.Convert(filter);
                if (safe != null)
                    callPayload.Queries["safe"] = SourceExpressionConverter.Convert(safe);
                if (num != null)
                    callPayload.Queries["num"] = SourceExpressionConverter.ConvertO(num);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<SearchGetResponse>(BuildSourceInput);
        }
    }

    public class SearchapigooglesearchTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchGetResponse
    {
        [JsonProperty("search_metadata")]
        public SearchGetResponseSearchMetadataType SearchMetadata { get; set; }

        [JsonProperty("search_parameters")]
        public SearchGetResponseSearchParametersType SearchParameters { get; set; }

        [JsonProperty("search_information")]
        public SearchGetResponseSearchInformationType SearchInformation { get; set; }

        [JsonProperty("knowledge_graph")]
        public SearchGetResponseKnowledgeGraphType KnowledgeGraph { get; set; }

        [JsonProperty("related_questions")]
        public SearchGetResponseRelatedQuestionsTypeItem[] RelatedQuestions { get; set; }

        [JsonProperty("related_searches")]
        public SearchGetResponseRelatedSearchesTypeItem[] RelatedSearches { get; set; }

        [JsonProperty("local_map")]
        public SearchGetResponseLocalMapType LocalMap { get; set; }

        [JsonProperty("local_results")]
        public SearchGetResponseLocalResultsTypeItem[] LocalResults { get; set; }

        [JsonProperty("local_results_more_link")]
        public SearchGetResponseLocalResultsMoreLinkType LocalResultsMoreLink { get; set; }

        [JsonProperty("job_results")]
        public SearchGetResponseJobResultsType JobResults { get; set; }

        [JsonProperty("shopping_ads")]
        public SearchGetResponseShoppingAdsTypeItem[] ShoppingAds { get; set; }

        [JsonProperty("shopping_ads_more_link")]
        public SearchGetResponseShoppingAdsMoreLinkType ShoppingAdsMoreLink { get; set; }

        [JsonProperty("ads")]
        public SearchGetResponseAdsTypeItem[] Ads { get; set; }

        [JsonProperty("local_ads")]
        public SearchGetResponseLocalAdsType LocalAds { get; set; }

        [JsonProperty("inline_shopping")]
        public SearchGetResponseInlineShoppingTypeItem[] InlineShopping { get; set; }

        [JsonProperty("inline_videos")]
        public SearchGetResponseInlineVideosTypeItem[] InlineVideos { get; set; }

        [JsonProperty("inline_videos_more_link")]
        public string InlineVideosMoreLink { get; set; }

        [JsonProperty("inline_tweets")]
        public SearchGetResponseInlineTweetsType InlineTweets { get; set; }

        [JsonProperty("inline_tweets_more_link")]
        public SearchGetResponseInlineTweetsMoreLinkType InlineTweetsMoreLink { get; set; }

        [JsonProperty("inline_images")]
        public SearchGetResponseInlineImagesType InlineImages { get; set; }

        [JsonProperty("inline_images_more_link")]
        public SearchGetResponseInlineImagesMoreLinkType InlineImagesMoreLink { get; set; }

        [JsonProperty("inline_recipes")]
        public SearchGetResponseInlineRecipesTypeItem[] InlineRecipes { get; set; }

        [JsonProperty("top_stories")]
        public SearchGetResponseTopStoriesTypeItem[] TopStories { get; set; }
    }

    public class SearchGetResponseSearchMetadataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("request_time_taken")]
        public double RequestTimeTaken { get; set; }

        [JsonProperty("parsing_time_taken")]
        public double ParsingTimeTaken { get; set; }

        [JsonProperty("total_time_taken")]
        public double TotalTimeTaken { get; set; }

        [JsonProperty("request_url")]
        public string RequestUrl { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("json_url")]
        public string JsonUrl { get; set; }
    }

    public class SearchGetResponseSearchParametersType
    {
        [JsonProperty("engine")]
        public string Engine { get; set; }

        [JsonProperty("q")]
        public string Q { get; set; }

        [JsonProperty("google_domain")]
        public string GoogleDomain { get; set; }

        [JsonProperty("hl")]
        public string Hl { get; set; }

        [JsonProperty("gl")]
        public string Gl { get; set; }
    }

    public class SearchGetResponseSearchInformationType
    {
        [JsonProperty("query_displayed")]
        public string QueryDisplayed { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("time_taken_displayed")]
        public double TimeTakenDisplayed { get; set; }

        [JsonProperty("detected_location")]
        public string DetectedLocation { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphType
    {
        [JsonProperty("kgmid")]
        public string Kgmid { get; set; }

        [JsonProperty("knowledge_graph_type")]
        public string KnowledgeGraphType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("source")]
        public SearchGetResponseKnowledgeGraphTypeSourceType Source { get; set; }

        [JsonProperty("initial_release_date")]
        public string InitialReleaseDate { get; set; }

        [JsonProperty("developers")]
        public string Developers { get; set; }

        [JsonProperty("developers_links")]
        public SearchGetResponseKnowledgeGraphTypeDevelopersLinksTypeItem[] DevelopersLinks { get; set; }

        [JsonProperty("engine")]
        public string Engine { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("stable_release")]
        public string StableRelease { get; set; }

        [JsonProperty("written_in")]
        public string WrittenIn { get; set; }

        [JsonProperty("written_in_links")]
        public SearchGetResponseKnowledgeGraphTypeWrittenInLinksTypeItem[] WrittenInLinks { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("reviews")]
        public int Reviews { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_description")]
        public string PriceDescription { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("directions")]
        public string Directions { get; set; }

        [JsonProperty("number_of_employees")]
        public string NumberOfEmployees { get; set; }

        [JsonProperty("number_of_employees_links")]
        public SearchGetResponseKnowledgeGraphTypeNumberOfEmployeesLinksTypeItem[] NumberOfEmployeesLinks { get; set; }

        [JsonProperty("company_reviews")]
        public SearchGetResponseKnowledgeGraphTypeCompanyReviewsTypeItem[] CompanyReviews { get; set; }

        [JsonProperty("extensions")]
        public string[] Extensions { get; set; }

        [JsonProperty("typical_salaries")]
        public SearchGetResponseKnowledgeGraphTypeTypicalSalariesTypeItem[] TypicalSalaries { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("service_options")]
        public string[] ServiceOptions { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("menu")]
        public SearchGetResponseKnowledgeGraphTypeMenuType Menu { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("hours")]
        public string Hours { get; set; }

        [JsonProperty("open_hours")]
        public SearchGetResponseKnowledgeGraphTypeOpenHoursTypeItem[] OpenHours { get; set; }

        [JsonProperty("popular_times")]
        public SearchGetResponseKnowledgeGraphTypePopularTimesType PopularTimes { get; set; }

        [JsonProperty("web_reviews")]
        public SearchGetResponseKnowledgeGraphTypeWebReviewsTypeItem[] WebReviews { get; set; }

        [JsonProperty("user_reviews")]
        public SearchGetResponseKnowledgeGraphTypeUserReviewsTypeItem[] UserReviews { get; set; }

        [JsonProperty("merchant_description")]
        public SearchGetResponseKnowledgeGraphTypeMerchantDescriptionType MerchantDescription { get; set; }

        [JsonProperty("profiles")]
        public SearchGetResponseKnowledgeGraphTypeProfilesTypeItem[] Profiles { get; set; }

        [JsonProperty("people_also_search_for_link")]
        public string PeopleAlsoSearchForLink { get; set; }

        [JsonProperty("local_map")]
        public SearchGetResponseKnowledgeGraphTypeLocalMapType LocalMap { get; set; }

        [JsonProperty("images")]
        public string[] Images { get; set; }

        [JsonProperty("ludocid")]
        public string Ludocid { get; set; }

        [JsonProperty("people_also_search_for")]
        public SearchGetResponseKnowledgeGraphTypePeopleAlsoSearchForTypeItem[] PeopleAlsoSearchFor { get; set; }

        [JsonProperty("organic_results")]
        public SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItem[] OrganicResults { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeDevelopersLinksTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeWrittenInLinksTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeNumberOfEmployeesLinksTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeCompanyReviewsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("rating_text")]
        public string RatingText { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("rating_out_of")]
        public int RatingOutOf { get; set; }

        [JsonProperty("reviews")]
        public int Reviews { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeTypicalSalariesTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("salary")]
        public string Salary { get; set; }

        [JsonProperty("salary_range")]
        public string SalaryRange { get; set; }

        [JsonProperty("source")]
        public SearchGetResponseKnowledgeGraphTypeTypicalSalariesTypeItemSourceType Source { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeTypicalSalariesTypeItemSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeMenuType
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeOpenHoursTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypePopularTimesType
    {
        [JsonProperty("live")]
        public SearchGetResponseKnowledgeGraphTypePopularTimesTypeLiveType Live { get; set; }

        [JsonProperty("chart")]
        public SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartType Chart { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypePopularTimesTypeLiveType
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("typical_time_spent")]
        public string TypicalTimeSpent { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartType
    {
        [JsonProperty("monday")]
        public SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeMondayTypeItem[] Monday { get; set; }

        [JsonProperty("tuesday")]
        public SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeTuesdayTypeItem[] Tuesday { get; set; }

        [JsonProperty("wednesday")]
        public SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeWednesdayTypeItem[] Wednesday { get; set; }

        [JsonProperty("thursday")]
        public SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeThursdayTypeItem[] Thursday { get; set; }

        [JsonProperty("friday")]
        public SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeFridayTypeItem[] Friday { get; set; }

        [JsonProperty("saturday")]
        public SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeSaturdayTypeItem[] Saturday { get; set; }

        [JsonProperty("sunday")]
        public SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeSundayTypeItem[] Sunday { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeMondayTypeItem
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("busyness_score")]
        public int BusynessScore { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeTuesdayTypeItem
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("busyness_score")]
        public int BusynessScore { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeWednesdayTypeItem
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("busyness_score")]
        public int BusynessScore { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeThursdayTypeItem
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("busyness_score")]
        public int BusynessScore { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeFridayTypeItem
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("busyness_score")]
        public int BusynessScore { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeSaturdayTypeItem
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("busyness_score")]
        public int BusynessScore { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypePopularTimesTypeChartTypeSundayTypeItem
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("busyness_score")]
        public int BusynessScore { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeWebReviewsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("rating_text")]
        public string RatingText { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("rating_out_of")]
        public int RatingOutOf { get; set; }

        [JsonProperty("reviews")]
        public int Reviews { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeUserReviewsTypeItem
    {
        [JsonProperty("review")]
        public string Review { get; set; }

        [JsonProperty("review_highlighted_words")]
        public string[] ReviewHighlightedWords { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("user")]
        public SearchGetResponseKnowledgeGraphTypeUserReviewsTypeItemUserType User { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeUserReviewsTypeItemUserType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeMerchantDescriptionType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeProfilesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeLocalMapType
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("gps_coordinates")]
        public SearchGetResponseKnowledgeGraphTypeLocalMapTypeGpsCoordinatesType GpsCoordinates { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeLocalMapTypeGpsCoordinatesType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("altitude")]
        public int Altitude { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypePeopleAlsoSearchForTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItem
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("displayed_link")]
        public string DisplayedLink { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("snippet_highlighted_words")]
        public string[] SnippetHighlightedWords { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("sitelinks")]
        public SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemSitelinksType Sitelinks { get; set; }

        [JsonProperty("about_this_result")]
        public SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemAboutThisResultType AboutThisResult { get; set; }

        [JsonProperty("about_page_link")]
        public string AboutPageLink { get; set; }

        [JsonProperty("cached_page_link")]
        public string CachedPageLink { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("nested_results")]
        public SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemNestedResultsTypeItem[] NestedResults { get; set; }

        [JsonProperty("rich_snippet")]
        public SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemRichSnippetType RichSnippet { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemSitelinksType
    {
        [JsonProperty("inline")]
        public SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemSitelinksTypeInlineTypeItem[] Inline { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemSitelinksTypeInlineTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemAboutThisResultType
    {
        [JsonProperty("source")]
        public SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemAboutThisResultTypeSourceType Source { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemAboutThisResultTypeSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link_source")]
        public string LinkSource { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemNestedResultsTypeItem
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("displayed_link")]
        public string DisplayedLink { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("snippet_highlighted_words")]
        public string[] SnippetHighlightedWords { get; set; }

        [JsonProperty("about_this_result")]
        public SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemNestedResultsTypeItemAboutThisResultType AboutThisResult { get; set; }

        [JsonProperty("about_page_link")]
        public string AboutPageLink { get; set; }

        [JsonProperty("cached_page_link")]
        public string CachedPageLink { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemNestedResultsTypeItemAboutThisResultType
    {
        [JsonProperty("source")]
        public SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemNestedResultsTypeItemAboutThisResultTypeSourceType Source { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemNestedResultsTypeItemAboutThisResultTypeSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("link_source")]
        public string LinkSource { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemRichSnippetType
    {
        [JsonProperty("detected_extensions")]
        public SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemRichSnippetTypeDetectedExtensionsType DetectedExtensions { get; set; }

        [JsonProperty("extensions")]
        public string[] Extensions { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemRichSnippetTypeDetectedExtensionsType
    {
        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("reviews")]
        public int Reviews { get; set; }

        [JsonProperty("questions")]
        public SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemRichSnippetTypeDetectedExtensionsTypeQuestionsTypeItem[] Questions { get; set; }
    }

    public class SearchGetResponseKnowledgeGraphTypeOrganicResultsTypeItemRichSnippetTypeDetectedExtensionsTypeQuestionsTypeItem
    {
        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }
    }

    public class SearchGetResponseRelatedQuestionsTypeItem
    {
        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }

        [JsonProperty("answer_highlight")]
        public string AnswerHighlight { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("source")]
        public SearchGetResponseRelatedQuestionsTypeItemSourceType Source { get; set; }

        [JsonProperty("search")]
        public SearchGetResponseRelatedQuestionsTypeItemSearchType Search { get; set; }
    }

    public class SearchGetResponseRelatedQuestionsTypeItemSourceType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("displayed_link")]
        public string DisplayedLink { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }
    }

    public class SearchGetResponseRelatedQuestionsTypeItemSearchType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseRelatedSearchesTypeItem
    {
        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseLocalMapType
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("gps_coordinates")]
        public SearchGetResponseLocalMapTypeGpsCoordinatesType GpsCoordinates { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }

    public class SearchGetResponseLocalMapTypeGpsCoordinatesType
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("altitude")]
        public int Altitude { get; set; }
    }

    public class SearchGetResponseLocalResultsTypeItem
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("ludocid")]
        public string Ludocid { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("reviews")]
        public int Reviews { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("price_description")]
        public string PriceDescription { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("is_closed")]
        public bool IsClosed { get; set; }

        [JsonProperty("service_options")]
        public string[] ServiceOptions { get; set; }

        [JsonProperty("extensions")]
        public string[] Extensions { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class SearchGetResponseLocalResultsMoreLinkType
    {
        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseJobResultsType
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("filters")]
        public SearchGetResponseJobResultsTypeFiltersTypeItem[] Filters { get; set; }

        [JsonProperty("jobs")]
        public SearchGetResponseJobResultsTypeJobsTypeItem[] Jobs { get; set; }

        [JsonProperty("jobs_more_link")]
        public SearchGetResponseJobResultsTypeJobsMoreLinkType JobsMoreLink { get; set; }
    }

    public class SearchGetResponseJobResultsTypeFiltersTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("is_trending")]
        public bool IsTrending { get; set; }
    }

    public class SearchGetResponseJobResultsTypeJobsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("via")]
        public string Via { get; set; }

        [JsonProperty("extensions")]
        public string[] Extensions { get; set; }
    }

    public class SearchGetResponseJobResultsTypeJobsMoreLinkType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseShoppingAdsTypeItem
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("block_position")]
        public string BlockPosition { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("seller")]
        public string Seller { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("extracted_price")]
        public int ExtractedPrice { get; set; }

        [JsonProperty("order_fullfillmed_method")]
        public string OrderFullfillmedMethod { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("reviews")]
        public int Reviews { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("delivery")]
        public string Delivery { get; set; }

        [JsonProperty("durability")]
        public string Durability { get; set; }
    }

    public class SearchGetResponseShoppingAdsMoreLinkType
    {
        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseAdsTypeItem
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("block_position")]
        public string BlockPosition { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("displayed_link")]
        public string DisplayedLink { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("snippet_highlighted_words")]
        public string[] SnippetHighlightedWords { get; set; }

        [JsonProperty("sitelinks")]
        public SearchGetResponseAdsTypeItemSitelinksType Sitelinks { get; set; }

        [JsonProperty("favicon")]
        public string Favicon { get; set; }
    }

    public class SearchGetResponseAdsTypeItemSitelinksType
    {
        [JsonProperty("expanded")]
        public SearchGetResponseAdsTypeItemSitelinksTypeExpandedTypeItem[] Expanded { get; set; }
    }

    public class SearchGetResponseAdsTypeItemSitelinksTypeExpandedTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseLocalAdsType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("badge")]
        public string Badge { get; set; }

        [JsonProperty("ads")]
        public SearchGetResponseLocalAdsTypeAdsTypeItem[] Ads { get; set; }

        [JsonProperty("see_more_link")]
        public SearchGetResponseLocalAdsTypeSeeMoreLinkType SeeMoreLink { get; set; }

        [JsonProperty("categories")]
        public SearchGetResponseLocalAdsTypeCategoriesTypeItem[] Categories { get; set; }
    }

    public class SearchGetResponseLocalAdsTypeAdsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("reviews")]
        public int Reviews { get; set; }

        [JsonProperty("extensions")]
        public string[] Extensions { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }

    public class SearchGetResponseLocalAdsTypeSeeMoreLinkType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseLocalAdsTypeCategoriesTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseInlineShoppingTypeItem
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("reviews")]
        public int Reviews { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("extracted_price")]
        public double ExtractedPrice { get; set; }

        [JsonProperty("comments")]
        public string[] Comments { get; set; }

        [JsonProperty("extensions")]
        public string[] Extensions { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("review")]
        public SearchGetResponseInlineShoppingTypeItemReviewType Review { get; set; }

        [JsonProperty("durability")]
        public string Durability { get; set; }
    }

    public class SearchGetResponseInlineShoppingTypeItemReviewType
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class SearchGetResponseInlineVideosTypeItem
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("key_moments")]
        public SearchGetResponseInlineVideosTypeItemKeyMomentsTypeItem[] KeyMoments { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class SearchGetResponseInlineVideosTypeItemKeyMomentsTypeItem
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }

    public class SearchGetResponseInlineTweetsType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("displayed_link")]
        public string DisplayedLink { get; set; }

        [JsonProperty("tweets")]
        public SearchGetResponseInlineTweetsTypeTweetsTypeItem[] Tweets { get; set; }
    }

    public class SearchGetResponseInlineTweetsTypeTweetsTypeItem
    {
        [JsonProperty("tweet_id")]
        public string TweetId { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("author")]
        public SearchGetResponseInlineTweetsTypeTweetsTypeItemAuthorType Author { get; set; }

        [JsonProperty("snippet_link")]
        public string SnippetLink { get; set; }

        [JsonProperty("images")]
        public string[] Images { get; set; }
    }

    public class SearchGetResponseInlineTweetsTypeTweetsTypeItemAuthorType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }

    public class SearchGetResponseInlineTweetsMoreLinkType
    {
        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseInlineImagesType
    {
        [JsonProperty("suggestions")]
        public SearchGetResponseInlineImagesTypeSuggestionsTypeItem[] Suggestions { get; set; }

        [JsonProperty("images")]
        public SearchGetResponseInlineImagesTypeImagesTypeItem[] Images { get; set; }
    }

    public class SearchGetResponseInlineImagesTypeSuggestionsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("chips")]
        public string Chips { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }

    public class SearchGetResponseInlineImagesTypeImagesTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("source")]
        public SearchGetResponseInlineImagesTypeImagesTypeItemSourceType Source { get; set; }

        [JsonProperty("original")]
        public SearchGetResponseInlineImagesTypeImagesTypeItemOriginalType Original { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }
    }

    public class SearchGetResponseInlineImagesTypeImagesTypeItemSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseInlineImagesTypeImagesTypeItemOriginalType
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
    }

    public class SearchGetResponseInlineImagesMoreLinkType
    {
        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchGetResponseInlineRecipesTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("reviews")]
        public int Reviews { get; set; }

        [JsonProperty("ingredients")]
        public string[] Ingredients { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }
    }

    public class SearchGetResponseTopStoriesTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }
    }

    public enum deviceInput
    {
        [EnumMember(Value = "desktop")]
        Desktop,
        [EnumMember(Value = "mobile")]
        Mobile,
        [EnumMember(Value = "tablet")]
        Tablet
    }

    public enum nfprInput
    {
        _0 = 0,
        _1 = 1
    }

    public enum filterInput
    {
        _0 = 0,
        _1 = 1
    }

    public enum safeInput
    {
        [EnumMember(Value = "off")]
        Off,
        [EnumMember(Value = "active")]
        Active
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Searchapigooglesearch;

    public partial class WorkflowManagedActions
    {
        public SearchapigooglesearchActions Searchapigooglesearch(string connectionId) => new SearchapigooglesearchActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SearchapigooglesearchTriggers Searchapigooglesearch(string connectionId) => new SearchapigooglesearchTriggers(connectionId);
    }
}