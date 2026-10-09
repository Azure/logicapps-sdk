//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Libraryofcongressip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LibraryofcongressipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "libraryofcongressip")]
        [WorkflowExpressionFactory(nameof(__BuildSearch))]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> fa = null, [WorkflowExpression] Func<int> c = null, [WorkflowExpression] Func<int> sp = null, [WorkflowExpression] Func<string> at = null, [WorkflowExpression] Func<string> sb = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchResponse> __BuildSearch(WorkflowExpression<string> q, WorkflowExpression<string> fa = null, WorkflowExpression<int> c = null, WorkflowExpression<int> sp = null, WorkflowExpression<string> at = null, WorkflowExpression<string> sb = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(fa, nameof(fa), required: false);
            WorkflowExpression.Validate(c, nameof(c), required: false);
            WorkflowExpression.Validate(sp, nameof(sp), required: false);
            WorkflowExpression.Validate(at, nameof(at), required: false);
            WorkflowExpression.Validate(sb, nameof(sb), required: false);
            return new DeferredBodyAction<SearchResponse>(() =>
            {
                var apiCallPath = "/search/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                if (fa != null)
                    callPayload.Queries["fa"] = ExpressionConverter.Convert(fa);
                if (c != null)
                    callPayload.Queries["c"] = ExpressionConverter.Convert(c);
                if (sp != null)
                    callPayload.Queries["sp"] = ExpressionConverter.Convert(sp);
                if (at != null)
                    callPayload.Queries["at"] = ExpressionConverter.Convert(at);
                if (sb != null)
                    callPayload.Queries["sb"] = ExpressionConverter.Convert(sb);
                return new ApiConnectionAction<SearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "libraryofcongressip")]
        [WorkflowExpressionFactory(nameof(__BuildCollection))]
        public IBodyWorkflowAction<CollectionResponse> Collection([WorkflowExpression] Func<string> collection, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> fa = null, [WorkflowExpression] Func<int> c = null, [WorkflowExpression] Func<int> sp = null, [WorkflowExpression] Func<string> at = null, [WorkflowExpression] Func<string> sb = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CollectionResponse> __BuildCollection(WorkflowExpression<string> collection, WorkflowExpression<string> q, WorkflowExpression<string> fa = null, WorkflowExpression<int> c = null, WorkflowExpression<int> sp = null, WorkflowExpression<string> at = null, WorkflowExpression<string> sb = null)
        {
            WorkflowExpression.Validate(collection, nameof(collection), required: true);
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(fa, nameof(fa), required: false);
            WorkflowExpression.Validate(c, nameof(c), required: false);
            WorkflowExpression.Validate(sp, nameof(sp), required: false);
            WorkflowExpression.Validate(at, nameof(at), required: false);
            WorkflowExpression.Validate(sb, nameof(sb), required: false);
            return new DeferredBodyAction<CollectionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/collections/{0}", ExpressionConverter.ConvertWithUrlEncoding(collection, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                if (fa != null)
                    callPayload.Queries["fa"] = ExpressionConverter.Convert(fa);
                if (c != null)
                    callPayload.Queries["c"] = ExpressionConverter.Convert(c);
                if (sp != null)
                    callPayload.Queries["sp"] = ExpressionConverter.Convert(sp);
                if (at != null)
                    callPayload.Queries["at"] = ExpressionConverter.Convert(at);
                if (sb != null)
                    callPayload.Queries["sb"] = ExpressionConverter.Convert(sb);
                return new ApiConnectionAction<CollectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "libraryofcongressip")]
        [WorkflowExpressionFactory(nameof(__BuildFormat))]
        public IBodyWorkflowAction<FormatResponse> Format([WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<string> fa = null, [WorkflowExpression] Func<int> c = null, [WorkflowExpression] Func<int> sp = null, [WorkflowExpression] Func<string> at = null, [WorkflowExpression] Func<string> sb = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FormatResponse> __BuildFormat(WorkflowExpression<formatInput> format, WorkflowExpression<string> q, WorkflowExpression<string> fa = null, WorkflowExpression<int> c = null, WorkflowExpression<int> sp = null, WorkflowExpression<string> at = null, WorkflowExpression<string> sb = null)
        {
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(fa, nameof(fa), required: false);
            WorkflowExpression.Validate(c, nameof(c), required: false);
            WorkflowExpression.Validate(sp, nameof(sp), required: false);
            WorkflowExpression.Validate(at, nameof(at), required: false);
            WorkflowExpression.Validate(sb, nameof(sb), required: false);
            return new DeferredBodyAction<FormatResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/", ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                if (fa != null)
                    callPayload.Queries["fa"] = ExpressionConverter.Convert(fa);
                if (c != null)
                    callPayload.Queries["c"] = ExpressionConverter.Convert(c);
                if (sp != null)
                    callPayload.Queries["sp"] = ExpressionConverter.Convert(sp);
                if (at != null)
                    callPayload.Queries["at"] = ExpressionConverter.Convert(at);
                if (sb != null)
                    callPayload.Queries["sb"] = ExpressionConverter.Convert(sb);
                return new ApiConnectionAction<FormatResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "libraryofcongressip")]
        [WorkflowExpressionFactory(nameof(__BuildItem))]
        public IBodyWorkflowAction<ItemResponse> Item([WorkflowExpression] Func<string> identifier)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemResponse> __BuildItem(WorkflowExpression<string> identifier)
        {
            WorkflowExpression.Validate(identifier, nameof(identifier), required: true);
            return new DeferredBodyAction<ItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/item/{0}/", ExpressionConverter.ConvertWithUrlEncoding(identifier, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ItemResponse>(callPayload);
            });
        }
    }

    public class LibraryofcongressipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchResponse
    {
        [JsonProperty("breadcrumbs")]
        public SearchResponseBreadcrumbsTypeItem[] Breadcrumbs { get; set; }

        [JsonProperty("expert_resources")]
        public string ExpertResources { get; set; }

        [JsonProperty("facet_trail")]
        public SearchResponseFacetTrailTypeItem[] FacetTrail { get; set; }

        [JsonProperty("facet_views")]
        public SearchResponseFacetViewsType FacetViews { get; set; }

        [JsonProperty("facets")]
        public SearchResponseFacetsTypeItem[] Facets { get; set; }

        [JsonProperty("form_facets")]
        public JToken FormFacets { get; set; }

        [JsonProperty("options")]
        public SearchResponseOptionsType Options { get; set; }

        [JsonProperty("results")]
        public SearchResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("search")]
        public SearchResponseSearchType Search { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("views")]
        public SearchResponseViewsType Views { get; set; }
    }

    public class SearchResponseBreadcrumbsTypeItem
    {
        [JsonProperty("Library of Congress")]
        public string LibraryOfCongress { get; set; }
        public string Search { get; set; }
    }

    public class SearchResponseFacetTrailTypeItem
    {
        [JsonProperty("facet")]
        public string Facet { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("superset")]
        public string Superset { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SearchResponseFacetViewsType
    {
        [JsonProperty("calendar")]
        public string Calendar { get; set; }

        [JsonProperty("chart")]
        public string Chart { get; set; }

        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("list")]
        public string List { get; set; }
    }

    public class SearchResponseFacetsTypeItem
    {
        [JsonProperty("filters")]
        public SearchResponseFacetsTypeItemFiltersTypeItem[] Filters { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }
    }

    public class SearchResponseFacetsTypeItemFiltersTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("not")]
        public string Not { get; set; }

        [JsonProperty("off")]
        public string Off { get; set; }

        [JsonProperty("on")]
        public string On { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }
    }

    public class SearchResponseOptionsType
    {
        [JsonProperty("access_group")]
        public string[] AccessGroup { get; set; }

        [JsonProperty("access_group_raw")]
        public string AccessGroupRaw { get; set; }

        [JsonProperty("all")]
        public string All { get; set; }

        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        [JsonProperty("app_context")]
        public string AppContext { get; set; }

        [JsonProperty("application_version")]
        public string ApplicationVersion { get; set; }

        [JsonProperty("attribute")]
        public string Attribute { get; set; }

        [JsonProperty("attribute!")]
        public string AttributeNot { get; set; }

        [JsonProperty("attribute_map")]
        public string AttributeMap { get; set; }

        [JsonProperty("cache_tags")]
        public string[] CacheTags { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("clip")]
        public string Clip { get; set; }

        [JsonProperty("clip_image_width")]
        public string ClipImageWidth { get; set; }

        [JsonProperty("clip_rotation")]
        public string ClipRotation { get; set; }

        [JsonProperty("content_filter")]
        public string ContentFilter { get; set; }

        [JsonProperty("content_replacement")]
        public string ContentReplacement { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("dates")]
        public string Dates { get; set; }

        [JsonProperty("delimiter")]
        public string Delimiter { get; set; }

        [JsonProperty("digital_id")]
        public string DigitalId { get; set; }

        [JsonProperty("display_level")]
        public string DisplayLevel { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }

        [JsonProperty("downloadOption")]
        public string DownloadOption { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("embed")]
        public string[] Embed { get; set; }

        [JsonProperty("embed!")]
        public string[] EmbedNot { get; set; }

        [JsonProperty("excludeTerms")]
        public string ExcludeTerms { get; set; }

        [JsonProperty("facetLimits")]
        public string FacetLimits { get; set; }

        [JsonProperty("facetPrefix")]
        public string FacetPrefix { get; set; }

        [JsonProperty("facet_count")]
        public string FacetCount { get; set; }

        [JsonProperty("facet_style")]
        public string FacetStyle { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("ical")]
        public bool Ical { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iiif")]
        public bool Iiif { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("inputEncoding")]
        public string InputEncoding { get; set; }

        [JsonProperty("is_portal")]
        public string IsPortal { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("items")]
        public string Items { get; set; }

        [JsonProperty("keys")]
        public string Keys { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("latlong")]
        public string Latlong { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("newSearch")]
        public string NewSearch { get; set; }

        [JsonProperty("new_clip_url")]
        public bool NewClipUrl { get; set; }

        [JsonProperty("onsite")]
        public bool Onsite { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("outputEncoding")]
        public string OutputEncoding { get; set; }

        [JsonProperty("page_has_campaign")]
        public bool PageHasCampaign { get; set; }

        [JsonProperty("path_info")]
        public string PathInfo { get; set; }

        [JsonProperty("port")]
        public string Port { get; set; }

        [JsonProperty("proxypath")]
        public string Proxypath { get; set; }

        [JsonProperty("query_string")]
        public string QueryString { get; set; }

        [JsonProperty("redirect_proxy")]
        public bool RedirectProxy { get; set; }

        [JsonProperty("redirect_to_item")]
        public string RedirectToItem { get; set; }

        [JsonProperty("referer")]
        public string Referer { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("release_id")]
        public int ReleaseId { get; set; }

        [JsonProperty("request_url")]
        public string RequestUrl { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("resource_sequence")]
        public string ResourceSequence { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("searchIn")]
        public string SearchIn { get; set; }

        [JsonProperty("searchTerms")]
        public string SearchTerms { get; set; }

        [JsonProperty("segments")]
        public string Segments { get; set; }

        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        [JsonProperty("site_type")]
        public string SiteType { get; set; }

        [JsonProperty("solrQuery")]
        public string SolrQuery { get; set; }

        [JsonProperty("sortBy")]
        public string SortBy { get; set; }

        [JsonProperty("sortOrder")]
        public string SortOrder { get; set; }

        [JsonProperty("startPage")]
        public string StartPage { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("suggested")]
        public string Suggested { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("timestamp")]
        public double Timestamp { get; set; }

        [JsonProperty("unionFacets")]
        public string UnionFacets { get; set; }

        [JsonProperty("webcast_permalink")]
        public string WebcastPermalink { get; set; }
    }

    public class SearchResponseResultsTypeItem
    {
        [JsonProperty("access_restricted")]
        public bool AccessRestricted { get; set; }

        [JsonProperty("aka")]
        public string[] Aka { get; set; }

        [JsonProperty("campaigns")]
        public string[] Campaigns { get; set; }

        [JsonProperty("description")]
        public string[] Description { get; set; }

        [JsonProperty("digitized")]
        public bool Digitized { get; set; }

        [JsonProperty("extract_timestamp")]
        public string ExtractTimestamp { get; set; }

        [JsonProperty("group")]
        public string[] Group { get; set; }

        [JsonProperty("hassegments")]
        public bool Hassegments { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image_url")]
        public string[] ImageUrl { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("mime_type")]
        public string[] MimeType { get; set; }

        [JsonProperty("online_format")]
        public string[] OnlineFormat { get; set; }

        [JsonProperty("other_title")]
        public string[] OtherTitle { get; set; }

        [JsonProperty("partof")]
        public string[] Partof { get; set; }

        [JsonProperty("shelf_id")]
        public string ShelfId { get; set; }

        [JsonProperty("site")]
        public string[] Site { get; set; }

        [JsonProperty("subject")]
        public string[] Subject { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dates")]
        public string[] Dates { get; set; }

        [JsonProperty("original_format")]
        public string[] OriginalFormat { get; set; }

        [JsonProperty("location")]
        public string[] Location { get; set; }

        [JsonProperty("contributor")]
        public string[] Contributor { get; set; }

        [JsonProperty("item")]
        public SearchResponseResultsTypeItemItemType Item { get; set; }

        [JsonProperty("number")]
        public string[] Number { get; set; }

        [JsonProperty("number_former_id")]
        public string[] NumberFormerId { get; set; }

        [JsonProperty("related")]
        public SearchResponseResultsTypeItemRelatedType Related { get; set; }

        [JsonProperty("reproductions")]
        public string Reproductions { get; set; }

        [JsonProperty("resources")]
        public SearchResponseResultsTypeItemResourcesTypeItem[] Resources { get; set; }

        [JsonProperty("unrestricted")]
        public bool Unrestricted { get; set; }

        [JsonProperty("segments")]
        public SearchResponseResultsTypeItemSegmentsTypeItem[] Segments { get; set; }
    }

    public class SearchResponseResultsTypeItemItemType
    {
        [JsonProperty("call_number")]
        public string CallNumber { get; set; }

        [JsonProperty("contributor_names")]
        public string[] ContributorNames { get; set; }

        [JsonProperty("contributors")]
        public string[] Contributors { get; set; }

        [JsonProperty("control_number")]
        public string ControlNumber { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("creators")]
        public SearchResponseResultsTypeItemItemTypeCreatorsTypeItem[] Creators { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("digital_id")]
        public string[] DigitalId { get; set; }

        [JsonProperty("format")]
        public string[] Format { get; set; }

        [JsonProperty("formats")]
        public SearchResponseResultsTypeItemItemTypeFormatsTypeItem[] Formats { get; set; }

        [JsonProperty("genre")]
        public string[] Genre { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("marc")]
        public string Marc { get; set; }

        [JsonProperty("medium")]
        public string[] Medium { get; set; }

        [JsonProperty("medium_brief")]
        public string MediumBrief { get; set; }

        [JsonProperty("mediums")]
        public string[] Mediums { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }

        [JsonProperty("other_control_numbers")]
        public string[] OtherControlNumbers { get; set; }

        [JsonProperty("part_of")]
        public string PartOf { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("reproduction_number")]
        public string ReproductionNumber { get; set; }

        [JsonProperty("resource_links")]
        public string[] ResourceLinks { get; set; }

        [JsonProperty("rights_advisory")]
        public string RightsAdvisory { get; set; }

        [JsonProperty("rights_information")]
        public string RightsInformation { get; set; }

        [JsonProperty("service_low")]
        public string ServiceLow { get; set; }

        [JsonProperty("service_medium")]
        public string ServiceMedium { get; set; }

        [JsonProperty("sort_date")]
        public string SortDate { get; set; }

        [JsonProperty("source_created")]
        public string SourceCreated { get; set; }

        [JsonProperty("source_modified")]
        public string SourceModified { get; set; }

        [JsonProperty("subject_headings")]
        public string[] SubjectHeadings { get; set; }

        [JsonProperty("subjects")]
        public string[] Subjects { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("thumb_gallery")]
        public string ThumbGallery { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("lc_classification")]
        public string LcClassification { get; set; }

        [JsonProperty("other_formats")]
        public string[] OtherFormats { get; set; }

        [JsonProperty("extent")]
        public string[] Extent { get; set; }

        [JsonProperty("form")]
        public string[] Form { get; set; }

        [JsonProperty("display_offsite")]
        public bool DisplayOffsite { get; set; }

        [JsonProperty("source_collection")]
        public string[] SourceCollection { get; set; }
    }

    public class SearchResponseResultsTypeItemItemTypeCreatorsTypeItem
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SearchResponseResultsTypeItemItemTypeFormatsTypeItem
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SearchResponseResultsTypeItemRelatedType
    {
        [JsonProperty("neighbors")]
        public string Neighbors { get; set; }
    }

    public class SearchResponseResultsTypeItemResourcesTypeItem
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("files")]
        public int Files { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SearchResponseResultsTypeItemSegmentsTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SearchResponseSearchType
    {
        [JsonProperty("dates")]
        public string Dates { get; set; }

        [JsonProperty("facet_limits")]
        public string FacetLimits { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("hits")]
        public int Hits { get; set; }

        [JsonProperty("in")]
        public string In { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("recommended")]
        public int Recommended { get; set; }

        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("sort_by")]
        public string SortBy { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("union_facets")]
        public string UnionFacets { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SearchResponseViewsType
    {
        [JsonProperty("brief")]
        public string Brief { get; set; }

        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("gallery")]
        public string Gallery { get; set; }

        [JsonProperty("grid")]
        public string Grid { get; set; }

        [JsonProperty("list")]
        public string List { get; set; }

        [JsonProperty("slideshow")]
        public string Slideshow { get; set; }
    }

    public class CollectionResponse
    {
        [JsonProperty("aka")]
        public string[] Aka { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("content")]
        public CollectionResponseContentType Content { get; set; }

        [JsonProperty("content_is_post")]
        public bool ContentIsPost { get; set; }

        [JsonProperty("digitized")]
        public int Digitized { get; set; }

        [JsonProperty("expert_resources")]
        public CollectionResponseExpertResourcesTypeItem[] ExpertResources { get; set; }

        [JsonProperty("facet_trail")]
        public CollectionResponseFacetTrailTypeItem[] FacetTrail { get; set; }

        [JsonProperty("facet_views")]
        public CollectionResponseFacetViewsType FacetViews { get; set; }

        [JsonProperty("facets")]
        public CollectionResponseFacetsTypeItem[] Facets { get; set; }

        [JsonProperty("featured_items")]
        public CollectionResponseFeaturedItemsTypeItem[] FeaturedItems { get; set; }

        [JsonProperty("form_facets")]
        public JToken FormFacets { get; set; }

        [JsonProperty("options")]
        public CollectionResponseOptionsType Options { get; set; }

        [JsonProperty("original_formats")]
        public string[] OriginalFormats { get; set; }

        [JsonProperty("partof")]
        public string[] Partof { get; set; }

        [JsonProperty("research-centers")]
        public string[] ResearchCenters { get; set; }

        [JsonProperty("results")]
        public CollectionResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("search")]
        public CollectionResponseSearchType Search { get; set; }

        [JsonProperty("shards")]
        public string[] Shards { get; set; }

        [JsonProperty("site_type")]
        public string SiteType { get; set; }

        [JsonProperty("subjects")]
        public string[] Subjects { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("topics")]
        public string[] Topics { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("views")]
        public CollectionResponseViewsType Views { get; set; }
    }

    public class CollectionResponseContentType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("markup")]
        public string Markup { get; set; }

        [JsonProperty("results")]
        public CollectionResponseContentTypeResultsTypeItem[] Results { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("views")]
        public CollectionResponseContentTypeViewsType Views { get; set; }
    }

    public class CollectionResponseContentTypeResultsTypeItem
    {
        [JsonProperty("access_restricted")]
        public bool AccessRestricted { get; set; }

        [JsonProperty("aka")]
        public string[] Aka { get; set; }

        [JsonProperty("campaigns")]
        public string[] Campaigns { get; set; }

        [JsonProperty("contributor")]
        public string[] Contributor { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dates")]
        public string[] Dates { get; set; }

        [JsonProperty("description")]
        public string[] Description { get; set; }

        [JsonProperty("digitized")]
        public bool Digitized { get; set; }

        [JsonProperty("extract_timestamp")]
        public string ExtractTimestamp { get; set; }

        [JsonProperty("group")]
        public string[] Group { get; set; }

        [JsonProperty("hassegments")]
        public bool Hassegments { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image_url")]
        public string[] ImageUrl { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("item")]
        public CollectionResponseContentTypeResultsTypeItemItemType Item { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("location")]
        public string[] Location { get; set; }

        [JsonProperty("location_country")]
        public string[] LocationCountry { get; set; }

        [JsonProperty("mime_type")]
        public string[] MimeType { get; set; }

        [JsonProperty("number")]
        public string[] Number { get; set; }

        [JsonProperty("number_former_id")]
        public string[] NumberFormerId { get; set; }

        [JsonProperty("number_lccn")]
        public string[] NumberLccn { get; set; }

        [JsonProperty("number_source_modified")]
        public string[] NumberSourceModified { get; set; }

        [JsonProperty("online_format")]
        public string[] OnlineFormat { get; set; }

        [JsonProperty("original_format")]
        public string[] OriginalFormat { get; set; }

        [JsonProperty("other_title")]
        public string[] OtherTitle { get; set; }

        [JsonProperty("partof")]
        public string[] Partof { get; set; }

        [JsonProperty("resources")]
        public CollectionResponseContentTypeResultsTypeItemResourcesTypeItem[] Resources { get; set; }

        [JsonProperty("shelf_id")]
        public string ShelfId { get; set; }

        [JsonProperty("site")]
        public string[] Site { get; set; }

        [JsonProperty("subject")]
        public string[] Subject { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("segments")]
        public CollectionResponseContentTypeResultsTypeItemSegmentsTypeItem[] Segments { get; set; }
    }

    public class CollectionResponseContentTypeResultsTypeItemItemType
    {
        [JsonProperty("call_number")]
        public string[] CallNumber { get; set; }

        [JsonProperty("contributors")]
        public string[] Contributors { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("digital_id")]
        public string[] DigitalId { get; set; }

        [JsonProperty("format")]
        public string[] Format { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("location")]
        public string[] Location { get; set; }

        [JsonProperty("medium")]
        public string[] Medium { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }

        [JsonProperty("number_former_id")]
        public string[] NumberFormerId { get; set; }

        [JsonProperty("repository")]
        public string[] Repository { get; set; }

        [JsonProperty("subjects")]
        public string[] Subjects { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("contents")]
        public string[] Contents { get; set; }

        [JsonProperty("other_title")]
        public string[] OtherTitle { get; set; }

        [JsonProperty("genre")]
        public string[] Genre { get; set; }
    }

    public class CollectionResponseContentTypeResultsTypeItemResourcesTypeItem
    {
        [JsonProperty("files")]
        public int Files { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("captions")]
        public string Captions { get; set; }

        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("segments")]
        public int Segments { get; set; }
    }

    public class CollectionResponseContentTypeResultsTypeItemSegmentsTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CollectionResponseContentTypeViewsType
    {
        [JsonProperty("brief")]
        public string Brief { get; set; }

        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("gallery")]
        public string Gallery { get; set; }

        [JsonProperty("grid")]
        public string Grid { get; set; }

        [JsonProperty("list")]
        public string List { get; set; }

        [JsonProperty("slideshow")]
        public string Slideshow { get; set; }
    }

    public class CollectionResponseExpertResourcesTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CollectionResponseFacetTrailTypeItem
    {
        [JsonProperty("facet")]
        public string Facet { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("superset")]
        public string Superset { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CollectionResponseFacetViewsType
    {
        [JsonProperty("calendar")]
        public string Calendar { get; set; }

        [JsonProperty("chart")]
        public string Chart { get; set; }

        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("list")]
        public string List { get; set; }
    }

    public class CollectionResponseFacetsTypeItem
    {
        [JsonProperty("filters")]
        public CollectionResponseFacetsTypeItemFiltersTypeItem[] Filters { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }
    }

    public class CollectionResponseFacetsTypeItemFiltersTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("not")]
        public string Not { get; set; }

        [JsonProperty("off")]
        public string Off { get; set; }

        [JsonProperty("on")]
        public string On { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }
    }

    public class CollectionResponseFeaturedItemsTypeItem
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CollectionResponseOptionsType
    {
        [JsonProperty("access_group")]
        public string[] AccessGroup { get; set; }

        [JsonProperty("access_group_raw")]
        public string AccessGroupRaw { get; set; }

        [JsonProperty("all")]
        public string All { get; set; }

        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        [JsonProperty("app_context")]
        public string AppContext { get; set; }

        [JsonProperty("application_version")]
        public string ApplicationVersion { get; set; }

        [JsonProperty("attribute")]
        public string Attribute { get; set; }

        [JsonProperty("attribute!")]
        public string AttributeNot { get; set; }

        [JsonProperty("attribute_map")]
        public string AttributeMap { get; set; }

        [JsonProperty("cache_tags")]
        public string[] CacheTags { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("clip")]
        public string Clip { get; set; }

        [JsonProperty("clip_image_width")]
        public string ClipImageWidth { get; set; }

        [JsonProperty("clip_rotation")]
        public string ClipRotation { get; set; }

        [JsonProperty("content_filter")]
        public string ContentFilter { get; set; }

        [JsonProperty("content_replacement")]
        public string ContentReplacement { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }

        [JsonProperty("dates")]
        public string Dates { get; set; }

        [JsonProperty("default_count")]
        public int DefaultCount { get; set; }

        [JsonProperty("delimiter")]
        public string Delimiter { get; set; }

        [JsonProperty("digital_id")]
        public string DigitalId { get; set; }

        [JsonProperty("display_level")]
        public string DisplayLevel { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }

        [JsonProperty("downloadOption")]
        public string DownloadOption { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("embed")]
        public string[] Embed { get; set; }

        [JsonProperty("embed!")]
        public string[] EmbedNot { get; set; }

        [JsonProperty("excludeTerms")]
        public string ExcludeTerms { get; set; }

        [JsonProperty("facetLimits")]
        public string FacetLimits { get; set; }

        [JsonProperty("facetPrefix")]
        public string FacetPrefix { get; set; }

        [JsonProperty("facet_count")]
        public string FacetCount { get; set; }

        [JsonProperty("facet_style")]
        public string FacetStyle { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("groupBy")]
        public string GroupBy { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("ical")]
        public bool Ical { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iiif")]
        public bool Iiif { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("inputEncoding")]
        public string InputEncoding { get; set; }

        [JsonProperty("is_portal")]
        public string IsPortal { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("items")]
        public string Items { get; set; }

        [JsonProperty("keys")]
        public string Keys { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("latlong")]
        public string Latlong { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("newSearch")]
        public string NewSearch { get; set; }

        [JsonProperty("new_clip_url")]
        public bool NewClipUrl { get; set; }

        [JsonProperty("onsite")]
        public bool Onsite { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("outputEncoding")]
        public string OutputEncoding { get; set; }

        [JsonProperty("page_has_campaign")]
        public bool PageHasCampaign { get; set; }

        [JsonProperty("path_info")]
        public string PathInfo { get; set; }

        [JsonProperty("port")]
        public string Port { get; set; }

        [JsonProperty("proxypath")]
        public string Proxypath { get; set; }

        [JsonProperty("query_string")]
        public string QueryString { get; set; }

        [JsonProperty("redirect_proxy")]
        public bool RedirectProxy { get; set; }

        [JsonProperty("redirect_to_item")]
        public string RedirectToItem { get; set; }

        [JsonProperty("referer")]
        public string Referer { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("release_id")]
        public int ReleaseId { get; set; }

        [JsonProperty("request_url")]
        public string RequestUrl { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("resource_sequence")]
        public string ResourceSequence { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("searchIn")]
        public string SearchIn { get; set; }

        [JsonProperty("searchTerms")]
        public string SearchTerms { get; set; }

        [JsonProperty("segments")]
        public string Segments { get; set; }

        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        [JsonProperty("site_type")]
        public string SiteType { get; set; }

        [JsonProperty("solrQuery")]
        public string SolrQuery { get; set; }

        [JsonProperty("sortBy")]
        public string SortBy { get; set; }

        [JsonProperty("sortOrder")]
        public string SortOrder { get; set; }

        [JsonProperty("startPage")]
        public string StartPage { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("suggested")]
        public string Suggested { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("timestamp")]
        public double Timestamp { get; set; }

        [JsonProperty("unionFacets")]
        public string UnionFacets { get; set; }

        [JsonProperty("webcast_permalink")]
        public string WebcastPermalink { get; set; }
    }

    public class CollectionResponseResultsTypeItem
    {
        [JsonProperty("access_restricted")]
        public bool AccessRestricted { get; set; }

        [JsonProperty("aka")]
        public string[] Aka { get; set; }

        [JsonProperty("campaigns")]
        public string[] Campaigns { get; set; }

        [JsonProperty("contributor")]
        public string[] Contributor { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dates")]
        public string[] Dates { get; set; }

        [JsonProperty("description")]
        public string[] Description { get; set; }

        [JsonProperty("digitized")]
        public bool Digitized { get; set; }

        [JsonProperty("extract_timestamp")]
        public string ExtractTimestamp { get; set; }

        [JsonProperty("group")]
        public string[] Group { get; set; }

        [JsonProperty("hassegments")]
        public bool Hassegments { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image_url")]
        public string[] ImageUrl { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("item")]
        public CollectionResponseResultsTypeItemItemType Item { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("location")]
        public string[] Location { get; set; }

        [JsonProperty("location_country")]
        public string[] LocationCountry { get; set; }

        [JsonProperty("mime_type")]
        public string[] MimeType { get; set; }

        [JsonProperty("number")]
        public string[] Number { get; set; }

        [JsonProperty("number_former_id")]
        public string[] NumberFormerId { get; set; }

        [JsonProperty("number_lccn")]
        public string[] NumberLccn { get; set; }

        [JsonProperty("number_source_modified")]
        public string[] NumberSourceModified { get; set; }

        [JsonProperty("online_format")]
        public string[] OnlineFormat { get; set; }

        [JsonProperty("original_format")]
        public string[] OriginalFormat { get; set; }

        [JsonProperty("other_title")]
        public string[] OtherTitle { get; set; }

        [JsonProperty("partof")]
        public string[] Partof { get; set; }

        [JsonProperty("resources")]
        public CollectionResponseResultsTypeItemResourcesTypeItem[] Resources { get; set; }

        [JsonProperty("shelf_id")]
        public string ShelfId { get; set; }

        [JsonProperty("site")]
        public string[] Site { get; set; }

        [JsonProperty("subject")]
        public string[] Subject { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("segments")]
        public CollectionResponseResultsTypeItemSegmentsTypeItem[] Segments { get; set; }
    }

    public class CollectionResponseResultsTypeItemItemType
    {
        [JsonProperty("call_number")]
        public string[] CallNumber { get; set; }

        [JsonProperty("contributors")]
        public string[] Contributors { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("digital_id")]
        public string[] DigitalId { get; set; }

        [JsonProperty("format")]
        public string[] Format { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("location")]
        public string[] Location { get; set; }

        [JsonProperty("medium")]
        public string[] Medium { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }

        [JsonProperty("number_former_id")]
        public string[] NumberFormerId { get; set; }

        [JsonProperty("repository")]
        public string[] Repository { get; set; }

        [JsonProperty("subjects")]
        public string[] Subjects { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("contents")]
        public string[] Contents { get; set; }

        [JsonProperty("other_title")]
        public string[] OtherTitle { get; set; }

        [JsonProperty("genre")]
        public string[] Genre { get; set; }
    }

    public class CollectionResponseResultsTypeItemResourcesTypeItem
    {
        [JsonProperty("files")]
        public int Files { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("captions")]
        public string Captions { get; set; }

        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("segments")]
        public int Segments { get; set; }
    }

    public class CollectionResponseResultsTypeItemSegmentsTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CollectionResponseSearchType
    {
        [JsonProperty("dates")]
        public string Dates { get; set; }

        [JsonProperty("facet_limits")]
        public string FacetLimits { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("hits")]
        public int Hits { get; set; }

        [JsonProperty("in")]
        public string In { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("recommended")]
        public int Recommended { get; set; }

        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("sort_by")]
        public string SortBy { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("union_facets")]
        public string UnionFacets { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CollectionResponseViewsType
    {
        [JsonProperty("brief")]
        public string Brief { get; set; }

        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("gallery")]
        public string Gallery { get; set; }

        [JsonProperty("grid")]
        public string Grid { get; set; }

        [JsonProperty("list")]
        public string List { get; set; }

        [JsonProperty("slideshow")]
        public string Slideshow { get; set; }
    }

    public class FormatResponse
    {
        [JsonProperty("content")]
        public FormatResponseContentType Content { get; set; }

        [JsonProperty("content_is_post")]
        public bool ContentIsPost { get; set; }

        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("expert_resources")]
        public FormatResponseExpertResourcesTypeItem[] ExpertResources { get; set; }

        [JsonProperty("facet_trail")]
        public FormatResponseFacetTrailTypeItem[] FacetTrail { get; set; }

        [JsonProperty("facet_views")]
        public FormatResponseFacetViewsType FacetViews { get; set; }

        [JsonProperty("facets")]
        public FormatResponseFacetsTypeItem[] Facets { get; set; }

        [JsonProperty("featured_items")]
        public FormatResponseFeaturedItemsTypeItem[] FeaturedItems { get; set; }

        [JsonProperty("form_facets")]
        public JToken FormFacets { get; set; }

        [JsonProperty("image_url")]
        public string[] ImageUrl { get; set; }

        [JsonProperty("options")]
        public FormatResponseOptionsType Options { get; set; }

        [JsonProperty("portal")]
        public bool Portal { get; set; }

        [JsonProperty("results")]
        public FormatResponseResultsTypeItem[] Results { get; set; }

        [JsonProperty("search")]
        public FormatResponseSearchType Search { get; set; }

        [JsonProperty("site_type")]
        public string SiteType { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("views")]
        public FormatResponseViewsType Views { get; set; }
    }

    public class FormatResponseContentType
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("results")]
        public FormatResponseContentTypeResultsTypeItem[] Results { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FormatResponseContentTypeResultsTypeItem
    {
        [JsonProperty("access_restricted")]
        public bool AccessRestricted { get; set; }

        [JsonProperty("aka")]
        public string[] Aka { get; set; }

        [JsonProperty("campaigns")]
        public string[] Campaigns { get; set; }

        [JsonProperty("contributor")]
        public string[] Contributor { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dates")]
        public string[] Dates { get; set; }

        [JsonProperty("description")]
        public string[] Description { get; set; }

        [JsonProperty("digitized")]
        public bool Digitized { get; set; }

        [JsonProperty("extract_timestamp")]
        public string ExtractTimestamp { get; set; }

        [JsonProperty("group")]
        public string[] Group { get; set; }

        [JsonProperty("hassegments")]
        public bool Hassegments { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image_url")]
        public string[] ImageUrl { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("item")]
        public FormatResponseContentTypeResultsTypeItemItemType Item { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("location")]
        public string[] Location { get; set; }

        [JsonProperty("number")]
        public string[] Number { get; set; }

        [JsonProperty("number_carrier_type")]
        public string[] NumberCarrierType { get; set; }

        [JsonProperty("number_lccn")]
        public string[] NumberLccn { get; set; }

        [JsonProperty("number_oclc")]
        public string[] NumberOclc { get; set; }

        [JsonProperty("number_source_modified")]
        public string[] NumberSourceModified { get; set; }

        [JsonProperty("original_format")]
        public string[] OriginalFormat { get; set; }

        [JsonProperty("other_title")]
        public string[] OtherTitle { get; set; }

        [JsonProperty("partof")]
        public string[] Partof { get; set; }

        [JsonProperty("resources")]
        public FormatResponseContentTypeResultsTypeItemResourcesTypeItem[] Resources { get; set; }

        [JsonProperty("shelf_id")]
        public string ShelfId { get; set; }

        [JsonProperty("site")]
        public string[] Site { get; set; }

        [JsonProperty("subject")]
        public string[] Subject { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("location_country")]
        public string[] LocationCountry { get; set; }

        [JsonProperty("mime_type")]
        public string[] MimeType { get; set; }

        [JsonProperty("number_former_id")]
        public string[] NumberFormerId { get; set; }

        [JsonProperty("online_format")]
        public string[] OnlineFormat { get; set; }

        [JsonProperty("segments")]
        public FormatResponseContentTypeResultsTypeItemSegmentsTypeItem[] Segments { get; set; }

        [JsonProperty("location_state")]
        public string[] LocationState { get; set; }

        [JsonProperty("location_county")]
        public string[] LocationCounty { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public string Items { get; set; }

        [JsonProperty("subject_topic")]
        public string[] SubjectTopic { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location_city")]
        public string[] LocationCity { get; set; }
    }

    public class FormatResponseContentTypeResultsTypeItemItemType
    {
        [JsonProperty("call_number")]
        public string[] CallNumber { get; set; }

        [JsonProperty("contents")]
        public string[] Contents { get; set; }

        [JsonProperty("contributors")]
        public string[] Contributors { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("format")]
        public string[] Format { get; set; }

        [JsonProperty("genre")]
        public string[] Genre { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("location")]
        public string[] Location { get; set; }

        [JsonProperty("medium")]
        public string[] Medium { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }

        [JsonProperty("other_title")]
        public string[] OtherTitle { get; set; }

        [JsonProperty("subjects")]
        public string[] Subjects { get; set; }

        [JsonProperty("summary")]
        public string[] Summary { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("digital_id")]
        public string[] DigitalId { get; set; }

        [JsonProperty("number_former_id")]
        public string[] NumberFormerId { get; set; }

        [JsonProperty("repository")]
        public string[] Repository { get; set; }
    }

    public class FormatResponseContentTypeResultsTypeItemResourcesTypeItem
    {
        [JsonProperty("files")]
        public int Files { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("captions")]
        public string Captions { get; set; }

        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("segments")]
        public int Segments { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }
    }

    public class FormatResponseContentTypeResultsTypeItemSegmentsTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FormatResponseExpertResourcesTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FormatResponseFacetTrailTypeItem
    {
        [JsonProperty("facet")]
        public string Facet { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("superset")]
        public string Superset { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class FormatResponseFacetViewsType
    {
        [JsonProperty("calendar")]
        public string Calendar { get; set; }

        [JsonProperty("chart")]
        public string Chart { get; set; }

        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("list")]
        public string List { get; set; }
    }

    public class FormatResponseFacetsTypeItem
    {
        [JsonProperty("filters")]
        public FormatResponseFacetsTypeItemFiltersTypeItem[] Filters { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }
    }

    public class FormatResponseFacetsTypeItemFiltersTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("not")]
        public string Not { get; set; }

        [JsonProperty("off")]
        public string Off { get; set; }

        [JsonProperty("on")]
        public string On { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }
    }

    public class FormatResponseFeaturedItemsTypeItem
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class FormatResponseOptionsType
    {
        [JsonProperty("access_group")]
        public string[] AccessGroup { get; set; }

        [JsonProperty("access_group_raw")]
        public string AccessGroupRaw { get; set; }

        [JsonProperty("all")]
        public string All { get; set; }

        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        [JsonProperty("app_context")]
        public string AppContext { get; set; }

        [JsonProperty("application_version")]
        public string ApplicationVersion { get; set; }

        [JsonProperty("attribute")]
        public string Attribute { get; set; }

        [JsonProperty("attribute!")]
        public string AttributeNot { get; set; }

        [JsonProperty("attribute_map")]
        public string AttributeMap { get; set; }

        [JsonProperty("cache_tags")]
        public string[] CacheTags { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("clip")]
        public string Clip { get; set; }

        [JsonProperty("clip_image_width")]
        public string ClipImageWidth { get; set; }

        [JsonProperty("clip_rotation")]
        public string ClipRotation { get; set; }

        [JsonProperty("content_filter")]
        public string ContentFilter { get; set; }

        [JsonProperty("content_replacement")]
        public string ContentReplacement { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }

        [JsonProperty("dates")]
        public string Dates { get; set; }

        [JsonProperty("default_count")]
        public int DefaultCount { get; set; }

        [JsonProperty("delimiter")]
        public string Delimiter { get; set; }

        [JsonProperty("digital_id")]
        public string DigitalId { get; set; }

        [JsonProperty("display_level")]
        public string DisplayLevel { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }

        [JsonProperty("downloadOption")]
        public string DownloadOption { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("embed")]
        public string[] Embed { get; set; }

        [JsonProperty("embed!")]
        public string[] EmbedNot { get; set; }

        [JsonProperty("excludeTerms")]
        public string ExcludeTerms { get; set; }

        [JsonProperty("facetLimits")]
        public string FacetLimits { get; set; }

        [JsonProperty("facetPrefix")]
        public string FacetPrefix { get; set; }

        [JsonProperty("facet_count")]
        public string FacetCount { get; set; }

        [JsonProperty("facet_style")]
        public string FacetStyle { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("ical")]
        public bool Ical { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iiif")]
        public bool Iiif { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("inputEncoding")]
        public string InputEncoding { get; set; }

        [JsonProperty("is_portal")]
        public bool IsPortal { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("items")]
        public string Items { get; set; }

        [JsonProperty("keys")]
        public string Keys { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("latlong")]
        public string Latlong { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("newSearch")]
        public string NewSearch { get; set; }

        [JsonProperty("new_clip_url")]
        public bool NewClipUrl { get; set; }

        [JsonProperty("onsite")]
        public bool Onsite { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("outputEncoding")]
        public string OutputEncoding { get; set; }

        [JsonProperty("page_has_campaign")]
        public bool PageHasCampaign { get; set; }

        [JsonProperty("path_info")]
        public string PathInfo { get; set; }

        [JsonProperty("port")]
        public string Port { get; set; }

        [JsonProperty("proxypath")]
        public string Proxypath { get; set; }

        [JsonProperty("query_string")]
        public string QueryString { get; set; }

        [JsonProperty("redirect_proxy")]
        public bool RedirectProxy { get; set; }

        [JsonProperty("redirect_to_item")]
        public string RedirectToItem { get; set; }

        [JsonProperty("referer")]
        public string Referer { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("release_id")]
        public int ReleaseId { get; set; }

        [JsonProperty("request_url")]
        public string RequestUrl { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("resource_sequence")]
        public string ResourceSequence { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("searchIn")]
        public string SearchIn { get; set; }

        [JsonProperty("searchTerms")]
        public string SearchTerms { get; set; }

        [JsonProperty("segments")]
        public string Segments { get; set; }

        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        [JsonProperty("site_type")]
        public string SiteType { get; set; }

        [JsonProperty("solrQuery")]
        public string SolrQuery { get; set; }

        [JsonProperty("sortBy")]
        public string SortBy { get; set; }

        [JsonProperty("sortOrder")]
        public string SortOrder { get; set; }

        [JsonProperty("startPage")]
        public string StartPage { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("suggested")]
        public string Suggested { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("timestamp")]
        public double Timestamp { get; set; }

        [JsonProperty("unionFacets")]
        public string UnionFacets { get; set; }

        [JsonProperty("webcast_permalink")]
        public string WebcastPermalink { get; set; }
    }

    public class FormatResponseResultsTypeItem
    {
        [JsonProperty("access_restricted")]
        public bool AccessRestricted { get; set; }

        [JsonProperty("aka")]
        public string[] Aka { get; set; }

        [JsonProperty("campaigns")]
        public string[] Campaigns { get; set; }

        [JsonProperty("contributor")]
        public string[] Contributor { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dates")]
        public string[] Dates { get; set; }

        [JsonProperty("description")]
        public string[] Description { get; set; }

        [JsonProperty("digitized")]
        public bool Digitized { get; set; }

        [JsonProperty("extract_timestamp")]
        public string ExtractTimestamp { get; set; }

        [JsonProperty("group")]
        public string[] Group { get; set; }

        [JsonProperty("hassegments")]
        public bool Hassegments { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image_url")]
        public string[] ImageUrl { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("item")]
        public FormatResponseResultsTypeItemItemType Item { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("location")]
        public string[] Location { get; set; }

        [JsonProperty("number")]
        public string[] Number { get; set; }

        [JsonProperty("number_carrier_type")]
        public string[] NumberCarrierType { get; set; }

        [JsonProperty("number_lccn")]
        public string[] NumberLccn { get; set; }

        [JsonProperty("number_oclc")]
        public string[] NumberOclc { get; set; }

        [JsonProperty("number_source_modified")]
        public string[] NumberSourceModified { get; set; }

        [JsonProperty("original_format")]
        public string[] OriginalFormat { get; set; }

        [JsonProperty("other_title")]
        public string[] OtherTitle { get; set; }

        [JsonProperty("partof")]
        public string[] Partof { get; set; }

        [JsonProperty("resources")]
        public FormatResponseResultsTypeItemResourcesTypeItem[] Resources { get; set; }

        [JsonProperty("shelf_id")]
        public string ShelfId { get; set; }

        [JsonProperty("site")]
        public string[] Site { get; set; }

        [JsonProperty("subject")]
        public string[] Subject { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("location_country")]
        public string[] LocationCountry { get; set; }

        [JsonProperty("mime_type")]
        public string[] MimeType { get; set; }

        [JsonProperty("number_former_id")]
        public string[] NumberFormerId { get; set; }

        [JsonProperty("online_format")]
        public string[] OnlineFormat { get; set; }

        [JsonProperty("segments")]
        public FormatResponseResultsTypeItemSegmentsTypeItem[] Segments { get; set; }

        [JsonProperty("location_state")]
        public string[] LocationState { get; set; }

        [JsonProperty("location_county")]
        public string[] LocationCounty { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("items")]
        public string Items { get; set; }

        [JsonProperty("subject_topic")]
        public string[] SubjectTopic { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location_city")]
        public string[] LocationCity { get; set; }
    }

    public class FormatResponseResultsTypeItemItemType
    {
        [JsonProperty("call_number")]
        public string[] CallNumber { get; set; }

        [JsonProperty("contents")]
        public string[] Contents { get; set; }

        [JsonProperty("contributors")]
        public string[] Contributors { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("format")]
        public string[] Format { get; set; }

        [JsonProperty("genre")]
        public string[] Genre { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("location")]
        public string[] Location { get; set; }

        [JsonProperty("medium")]
        public string[] Medium { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }

        [JsonProperty("other_title")]
        public string[] OtherTitle { get; set; }

        [JsonProperty("subjects")]
        public string[] Subjects { get; set; }

        [JsonProperty("summary")]
        public string[] Summary { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("digital_id")]
        public string[] DigitalId { get; set; }

        [JsonProperty("number_former_id")]
        public string[] NumberFormerId { get; set; }

        [JsonProperty("repository")]
        public string[] Repository { get; set; }
    }

    public class FormatResponseResultsTypeItemResourcesTypeItem
    {
        [JsonProperty("files")]
        public int Files { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("captions")]
        public string Captions { get; set; }

        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("segments")]
        public int Segments { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }
    }

    public class FormatResponseResultsTypeItemSegmentsTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FormatResponseSearchType
    {
        [JsonProperty("dates")]
        public string Dates { get; set; }

        [JsonProperty("facet_limits")]
        public string FacetLimits { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("hits")]
        public int Hits { get; set; }

        [JsonProperty("in")]
        public string In { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("recommended")]
        public int Recommended { get; set; }

        [JsonProperty("site")]
        public JToken Site { get; set; }

        [JsonProperty("sort_by")]
        public string SortBy { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("union_facets")]
        public string UnionFacets { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FormatResponseViewsType
    {
        [JsonProperty("brief")]
        public string Brief { get; set; }

        [JsonProperty("current")]
        public string Current { get; set; }

        [JsonProperty("gallery")]
        public string Gallery { get; set; }

        [JsonProperty("grid")]
        public string Grid { get; set; }

        [JsonProperty("list")]
        public string List { get; set; }

        [JsonProperty("slideshow")]
        public string Slideshow { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "manuscripts")]
        Manuscripts,
        [EnumMember(Value = "maps")]
        Maps,
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "photos")]
        Photos,
        [EnumMember(Value = "newspapers")]
        Newspapers,
        [EnumMember(Value = "film-and-videos")]
        FilmAndVideos,
        [EnumMember(Value = "notated-music")]
        NotatedMusic,
        [EnumMember(Value = "websites")]
        Websites
    }

    public class ItemResponse
    {
        [JsonProperty("cite_this")]
        public ItemResponseCiteThisType CiteThis { get; set; }

        [JsonProperty("item")]
        public ItemResponseItemType Item { get; set; }

        [JsonProperty("more_like_this")]
        public ItemResponseMoreLikeThisTypeItem[] MoreLikeThis { get; set; }

        [JsonProperty("options")]
        public ItemResponseOptionsType Options { get; set; }

        [JsonProperty("related")]
        public ItemResponseRelatedType Related { get; set; }

        [JsonProperty("related_items")]
        public ItemResponseRelatedItemsTypeItem[] RelatedItems { get; set; }

        [JsonProperty("reproductions")]
        public string Reproductions { get; set; }

        [JsonProperty("resources")]
        public ItemResponseResourcesTypeItem[] Resources { get; set; }

        [JsonProperty("thesaurus_entry")]
        public string ThesaurusEntry { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("unrestricted")]
        public bool Unrestricted { get; set; }
    }

    public class ItemResponseCiteThisType
    {
        [JsonProperty("apa")]
        public string Apa { get; set; }

        [JsonProperty("chicago")]
        public string Chicago { get; set; }

        [JsonProperty("mla")]
        public string Mla { get; set; }
    }

    public class ItemResponseItemType
    {
        [JsonProperty("_version_")]
        public int Version { get; set; }

        [JsonProperty("access_restricted")]
        public bool AccessRestricted { get; set; }

        [JsonProperty("aka")]
        public string[] Aka { get; set; }

        [JsonProperty("call_number")]
        public string CallNumber { get; set; }

        [JsonProperty("campaigns")]
        public string[] Campaigns { get; set; }

        [JsonProperty("contributor_names")]
        public string[] ContributorNames { get; set; }

        [JsonProperty("contributors")]
        public ItemResponseItemTypeContributorsTypeItem[] Contributors { get; set; }

        [JsonProperty("control_number")]
        public string ControlNumber { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dates")]
        public JToken[] Dates { get; set; }

        [JsonProperty("description")]
        public string[] Description { get; set; }

        [JsonProperty("digital_id")]
        public string[] DigitalId { get; set; }

        [JsonProperty("digitized")]
        public bool Digitized { get; set; }

        [JsonProperty("display_offsite")]
        public bool DisplayOffsite { get; set; }

        [JsonProperty("extract_timestamp")]
        public string ExtractTimestamp { get; set; }

        [JsonProperty("extract_urls")]
        public string[] ExtractUrls { get; set; }

        [JsonProperty("format")]
        public JToken[] Format { get; set; }

        [JsonProperty("format_headings")]
        public string[] FormatHeadings { get; set; }

        [JsonProperty("genre")]
        public string[] Genre { get; set; }

        [JsonProperty("group")]
        public string[] Group { get; set; }

        [JsonProperty("hassegments")]
        public bool Hassegments { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image_url")]
        public string[] ImageUrl { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("item")]
        public ItemResponseItemTypeItemType Item { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("languages")]
        public JToken[] Languages { get; set; }

        [JsonProperty("library_of_congress_control_number")]
        public string LibraryOfCongressControlNumber { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("marc")]
        public string Marc { get; set; }

        [JsonProperty("medium")]
        public string[] Medium { get; set; }

        [JsonProperty("medium_brief")]
        public string MediumBrief { get; set; }

        [JsonProperty("mime_type")]
        public string[] MimeType { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }

        [JsonProperty("number")]
        public string[] Number { get; set; }

        [JsonProperty("number_former_id")]
        public string[] NumberFormerId { get; set; }

        [JsonProperty("number_lccn")]
        public string[] NumberLccn { get; set; }

        [JsonProperty("number_source_modified")]
        public string[] NumberSourceModified { get; set; }

        [JsonProperty("online_format")]
        public string[] OnlineFormat { get; set; }

        [JsonProperty("original_format")]
        public string[] OriginalFormat { get; set; }

        [JsonProperty("other_control_numbers")]
        public string[] OtherControlNumbers { get; set; }

        [JsonProperty("other_formats")]
        public ItemResponseItemTypeOtherFormatsTypeItem[] OtherFormats { get; set; }

        [JsonProperty("other_title")]
        public string[] OtherTitle { get; set; }

        [JsonProperty("partof")]
        public ItemResponseItemTypePartofTypeItem[] Partof { get; set; }

        [JsonProperty("raw_collections")]
        public string[] RawCollections { get; set; }

        [JsonProperty("related")]
        public ItemResponseItemTypeRelatedType Related { get; set; }

        [JsonProperty("repository")]
        public string[] Repository { get; set; }

        [JsonProperty("reproduction_number")]
        public string ReproductionNumber { get; set; }

        [JsonProperty("reproductions")]
        public string[] Reproductions { get; set; }

        [JsonProperty("resource_links")]
        public string[] ResourceLinks { get; set; }

        [JsonProperty("resources")]
        public ItemResponseItemTypeResourcesTypeItem[] Resources { get; set; }

        [JsonProperty("rights")]
        public string[] Rights { get; set; }

        [JsonProperty("rights_advisory")]
        public string RightsAdvisory { get; set; }

        [JsonProperty("rights_information")]
        public string RightsInformation { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("shelf_id")]
        public string ShelfId { get; set; }

        [JsonProperty("site")]
        public string[] Site { get; set; }

        [JsonProperty("sort_date")]
        public string SortDate { get; set; }

        [JsonProperty("source_collection")]
        public string SourceCollection { get; set; }

        [JsonProperty("source_created")]
        public string SourceCreated { get; set; }

        [JsonProperty("source_modified")]
        public string SourceModified { get; set; }

        [JsonProperty("subject")]
        public string[] Subject { get; set; }

        [JsonProperty("subjects")]
        public JToken[] Subjects { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("thumb_gallery")]
        public string ThumbGallery { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string[] Type { get; set; }

        [JsonProperty("unrestricted")]
        public bool Unrestricted { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ItemResponseItemTypeContributorsTypeItem
    {
        [JsonProperty("bain news service")]
        public string BainNewsService { get; set; }
    }

    public class ItemResponseItemTypeItemType
    {
        [JsonProperty("call_number")]
        public string CallNumber { get; set; }

        [JsonProperty("contributors")]
        public string[] Contributors { get; set; }

        [JsonProperty("control_number")]
        public string ControlNumber { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("creators")]
        public ItemResponseItemTypeItemTypeCreatorsTypeItem[] Creators { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("digital_id")]
        public string[] DigitalId { get; set; }

        [JsonProperty("display_offsite")]
        public bool DisplayOffsite { get; set; }

        [JsonProperty("format")]
        public string[] Format { get; set; }

        [JsonProperty("formats")]
        public ItemResponseItemTypeItemTypeFormatsTypeItem[] Formats { get; set; }

        [JsonProperty("genre")]
        public string[] Genre { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("marc")]
        public string Marc { get; set; }

        [JsonProperty("medium")]
        public string[] Medium { get; set; }

        [JsonProperty("medium_brief")]
        public string MediumBrief { get; set; }

        [JsonProperty("mediums")]
        public string[] Mediums { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }

        [JsonProperty("number_former_id")]
        public string[] NumberFormerId { get; set; }

        [JsonProperty("other_control_numbers")]
        public string[] OtherControlNumbers { get; set; }

        [JsonProperty("part_of")]
        public string PartOf { get; set; }

        [JsonProperty("raw_collections")]
        public string[] RawCollections { get; set; }

        [JsonProperty("repository")]
        public string Repository { get; set; }

        [JsonProperty("reproduction_number")]
        public string ReproductionNumber { get; set; }

        [JsonProperty("resource_links")]
        public string[] ResourceLinks { get; set; }

        [JsonProperty("rights_advisory")]
        public string RightsAdvisory { get; set; }

        [JsonProperty("rights_information")]
        public string RightsInformation { get; set; }

        [JsonProperty("service_low")]
        public string ServiceLow { get; set; }

        [JsonProperty("service_medium")]
        public string ServiceMedium { get; set; }

        [JsonProperty("sort_date")]
        public string SortDate { get; set; }

        [JsonProperty("source_collection")]
        public string[] SourceCollection { get; set; }

        [JsonProperty("source_created")]
        public string SourceCreated { get; set; }

        [JsonProperty("source_modified")]
        public string SourceModified { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("thumb_gallery")]
        public string ThumbGallery { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ItemResponseItemTypeItemTypeCreatorsTypeItem
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ItemResponseItemTypeItemTypeFormatsTypeItem
    {
        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ItemResponseItemTypeOtherFormatsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class ItemResponseItemTypePartofTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ItemResponseItemTypeRelatedType
    {
        [JsonProperty("neighbors")]
        public string Neighbors { get; set; }
    }

    public class ItemResponseItemTypeResourcesTypeItem
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("files")]
        public int Files { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ItemResponseMoreLikeThisTypeItem
    {
        [JsonProperty("access_restricted")]
        public bool AccessRestricted { get; set; }

        [JsonProperty("aka")]
        public string[] Aka { get; set; }

        [JsonProperty("campaigns")]
        public string[] Campaigns { get; set; }

        [JsonProperty("contributor")]
        public string[] Contributor { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dates")]
        public string[] Dates { get; set; }

        [JsonProperty("description")]
        public string[] Description { get; set; }

        [JsonProperty("digitized")]
        public bool Digitized { get; set; }

        [JsonProperty("extract_timestamp")]
        public string ExtractTimestamp { get; set; }

        [JsonProperty("group")]
        public string[] Group { get; set; }

        [JsonProperty("hassegments")]
        public bool Hassegments { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image_url")]
        public string[] ImageUrl { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("mime_type")]
        public string[] MimeType { get; set; }

        [JsonProperty("number")]
        public string[] Number { get; set; }

        [JsonProperty("online_format")]
        public string[] OnlineFormat { get; set; }

        [JsonProperty("original_format")]
        public string[] OriginalFormat { get; set; }

        [JsonProperty("other_title")]
        public string[] OtherTitle { get; set; }

        [JsonProperty("partof")]
        public string[] Partof { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("shelf_id")]
        public string ShelfId { get; set; }

        [JsonProperty("site")]
        public string[] Site { get; set; }

        [JsonProperty("subject")]
        public string[] Subject { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ItemResponseOptionsType
    {
        [JsonProperty("access_group")]
        public string[] AccessGroup { get; set; }

        [JsonProperty("access_group_raw")]
        public string AccessGroupRaw { get; set; }

        [JsonProperty("all")]
        public string All { get; set; }

        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }

        [JsonProperty("app_context")]
        public string AppContext { get; set; }

        [JsonProperty("application_version")]
        public string ApplicationVersion { get; set; }

        [JsonProperty("attribute")]
        public string Attribute { get; set; }

        [JsonProperty("attribute!")]
        public string AttributeNot { get; set; }

        [JsonProperty("attribute_map")]
        public string AttributeMap { get; set; }

        [JsonProperty("cache_tags")]
        public string[] CacheTags { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }

        [JsonProperty("clip")]
        public string Clip { get; set; }

        [JsonProperty("clip_image_width")]
        public string ClipImageWidth { get; set; }

        [JsonProperty("clip_rotation")]
        public string ClipRotation { get; set; }

        [JsonProperty("content_filter")]
        public string ContentFilter { get; set; }

        [JsonProperty("content_replacement")]
        public string ContentReplacement { get; set; }

        [JsonProperty("count")]
        public string Count { get; set; }

        [JsonProperty("dates")]
        public string Dates { get; set; }

        [JsonProperty("default_count")]
        public int DefaultCount { get; set; }

        [JsonProperty("delimiter")]
        public string Delimiter { get; set; }

        [JsonProperty("digital_id")]
        public string DigitalId { get; set; }

        [JsonProperty("display_level")]
        public string DisplayLevel { get; set; }

        [JsonProperty("distance")]
        public string Distance { get; set; }

        [JsonProperty("downloadOption")]
        public string DownloadOption { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("embed")]
        public string[] Embed { get; set; }

        [JsonProperty("embed!")]
        public string[] EmbedNot { get; set; }

        [JsonProperty("excludeTerms")]
        public string ExcludeTerms { get; set; }

        [JsonProperty("facetLimits")]
        public string FacetLimits { get; set; }

        [JsonProperty("facetPrefix")]
        public string FacetPrefix { get; set; }

        [JsonProperty("facet_count")]
        public string FacetCount { get; set; }

        [JsonProperty("facet_style")]
        public string FacetStyle { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("ical")]
        public bool Ical { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iiif")]
        public bool Iiif { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("inputEncoding")]
        public string InputEncoding { get; set; }

        [JsonProperty("is_portal")]
        public string IsPortal { get; set; }

        [JsonProperty("item")]
        public string Item { get; set; }

        [JsonProperty("items")]
        public string Items { get; set; }

        [JsonProperty("keys")]
        public string Keys { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("latlong")]
        public string Latlong { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("newSearch")]
        public string NewSearch { get; set; }

        [JsonProperty("new_clip_url")]
        public bool NewClipUrl { get; set; }

        [JsonProperty("onsite")]
        public bool Onsite { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("outputEncoding")]
        public string OutputEncoding { get; set; }

        [JsonProperty("page_has_campaign")]
        public bool PageHasCampaign { get; set; }

        [JsonProperty("path_info")]
        public string PathInfo { get; set; }

        [JsonProperty("port")]
        public string Port { get; set; }

        [JsonProperty("proxypath")]
        public string Proxypath { get; set; }

        [JsonProperty("query_string")]
        public string QueryString { get; set; }

        [JsonProperty("redirect_proxy")]
        public bool RedirectProxy { get; set; }

        [JsonProperty("redirect_to_item")]
        public string RedirectToItem { get; set; }

        [JsonProperty("referer")]
        public string Referer { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("release_id")]
        public int ReleaseId { get; set; }

        [JsonProperty("request_url")]
        public string RequestUrl { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("resource_sequence")]
        public string ResourceSequence { get; set; }

        [JsonProperty("scheme")]
        public string Scheme { get; set; }

        [JsonProperty("searchIn")]
        public string SearchIn { get; set; }

        [JsonProperty("searchTerms")]
        public string SearchTerms { get; set; }

        [JsonProperty("segments")]
        public string Segments { get; set; }

        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        [JsonProperty("site_type")]
        public string SiteType { get; set; }

        [JsonProperty("solrQuery")]
        public string SolrQuery { get; set; }

        [JsonProperty("sortBy")]
        public string SortBy { get; set; }

        [JsonProperty("sortOrder")]
        public string SortOrder { get; set; }

        [JsonProperty("startPage")]
        public string StartPage { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("suggested")]
        public string Suggested { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("timestamp")]
        public double Timestamp { get; set; }

        [JsonProperty("unionFacets")]
        public string UnionFacets { get; set; }

        [JsonProperty("webcast_permalink")]
        public string WebcastPermalink { get; set; }
    }

    public class ItemResponseRelatedType
    {
        [JsonProperty("group_record")]
        public string GroupRecord { get; set; }

        [JsonProperty("lot_link")]
        public string LotLink { get; set; }

        [JsonProperty("neighbors")]
        public string Neighbors { get; set; }

        [JsonProperty("survey_link")]
        public string SurveyLink { get; set; }
    }

    public class ItemResponseRelatedItemsTypeItem
    {
        [JsonProperty("access_restricted")]
        public bool AccessRestricted { get; set; }

        [JsonProperty("aka")]
        public string[] Aka { get; set; }

        [JsonProperty("campaigns")]
        public string[] Campaigns { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dates")]
        public string[] Dates { get; set; }

        [JsonProperty("description")]
        public string[] Description { get; set; }

        [JsonProperty("digitized")]
        public bool Digitized { get; set; }

        [JsonProperty("extract_timestamp")]
        public string ExtractTimestamp { get; set; }

        [JsonProperty("group")]
        public string[] Group { get; set; }

        [JsonProperty("hassegments")]
        public bool Hassegments { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image_url")]
        public string[] ImageUrl { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("language")]
        public string[] Language { get; set; }

        [JsonProperty("location")]
        public string[] Location { get; set; }

        [JsonProperty("mime_type")]
        public string[] MimeType { get; set; }

        [JsonProperty("online_format")]
        public string[] OnlineFormat { get; set; }

        [JsonProperty("original_format")]
        public string[] OriginalFormat { get; set; }

        [JsonProperty("other_title")]
        public string[] OtherTitle { get; set; }

        [JsonProperty("partof")]
        public string[] Partof { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("shelf_id")]
        public string ShelfId { get; set; }

        [JsonProperty("site")]
        public string[] Site { get; set; }

        [JsonProperty("subject")]
        public string[] Subject { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ItemResponseResourcesTypeItem
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("files")]
        public ItemResponseResourcesTypeItemFilesTypeItemItem[][] Files { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ItemResponseResourcesTypeItemFilesTypeItemItem
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("levels")]
        public int Levels { get; set; }

        [JsonProperty("mimetype")]
        public string Mimetype { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Libraryofcongressip;

    public partial class WorkflowManagedActions
    {
        public LibraryofcongressipActions Libraryofcongressip(string connectionId) => new LibraryofcongressipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LibraryofcongressipTriggers Libraryofcongressip(string connectionId) => new LibraryofcongressipTriggers(connectionId);
    }
}