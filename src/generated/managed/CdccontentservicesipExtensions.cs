//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cdccontentservicesip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CdccontentservicesipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<MediaSearchResponse> MediaSearch(Expression<Func<string>> q = null, Expression<Func<string>> mediatypes = null, Expression<Func<string>> name = null, Expression<Func<string>> topic = null, Expression<Func<int>> topicids = null, Expression<Func<string>> audience = null, Expression<Func<string>> languagename = null, Expression<Func<string>> languageisocode = null, Expression<Func<string>> sourcename = null, Expression<Func<string>> sourceacronym = null, Expression<Func<string>> sort = null, Expression<Func<orderInput>> order = null, Expression<Func<int>> max = null, Expression<Func<int>> pagenum = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/resources/media";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (mediatypes != null)
                callPayload.Queries["mediatypes"] = ExpressionConverter.Convert(mediatypes);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (topic != null)
                callPayload.Queries["topic"] = ExpressionConverter.Convert(topic);
            if (topicids != null)
                callPayload.Queries["topicids"] = ExpressionConverter.Convert(topicids);
            if (audience != null)
                callPayload.Queries["audience"] = ExpressionConverter.Convert(audience);
            if (languagename != null)
                callPayload.Queries["languagename"] = ExpressionConverter.Convert(languagename);
            if (languageisocode != null)
                callPayload.Queries["languageisocode"] = ExpressionConverter.Convert(languageisocode);
            if (sourcename != null)
                callPayload.Queries["sourcename"] = ExpressionConverter.Convert(sourcename);
            if (sourceacronym != null)
                callPayload.Queries["sourceacronym"] = ExpressionConverter.Convert(sourceacronym);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (order != null)
                callPayload.Queries["order"] = ExpressionConverter.Convert(order);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (pagenum != null)
                callPayload.Queries["pagenum"] = ExpressionConverter.Convert(pagenum);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<MediaSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<MediaGetResponse> MediaGet(Expression<Func<string>> mediaId, Expression<Func<string>> sort = null, Expression<Func<string>> order = null, Expression<Func<int>> max = null, Expression<Func<int>> pagenum = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/resources/media/{0}", ExpressionConverter.ConvertWithUrlEncoding(mediaId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (order != null)
                callPayload.Queries["order"] = ExpressionConverter.Convert(order);
            if (max != null)
                callPayload.Queries["max"] = ExpressionConverter.Convert(max);
            if (pagenum != null)
                callPayload.Queries["pagenum"] = ExpressionConverter.Convert(pagenum);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<MediaGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<MediaTypesResponse> MediaTypes()
        {
            var apiCallPath = "/resources/mediatypes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MediaTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<TopicsResponse> Topics()
        {
            var apiCallPath = "/resources/topics";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TopicsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<AudiencesResponse> Audiences()
        {
            var apiCallPath = "/resources/audiences";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AudiencesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<TagsResponse> Tags()
        {
            var apiCallPath = "/resources/tags";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TagsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<TagGetResponse> TagGet(Expression<Func<string>> tAGID)
        {
            var apiCallPath = String.Format("/resources/tags/{0}", ExpressionConverter.ConvertWithUrlEncoding(tAGID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TagGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<MediaTagResponse> MediaTag(Expression<Func<string>> tAGID)
        {
            var apiCallPath = String.Format("/resources/tags/{0}/media", ExpressionConverter.ConvertWithUrlEncoding(tAGID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MediaTagResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<TagRelatedResponse> TagRelated(Expression<Func<string>> tAGID)
        {
            var apiCallPath = String.Format("/resources/tags/{0}/related", ExpressionConverter.ConvertWithUrlEncoding(tAGID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TagRelatedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<TagTypesResponse> TagTypes()
        {
            var apiCallPath = "/resources/tagtypes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TagTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<LanguageResponse> Language()
        {
            var apiCallPath = "/resources/languages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<LanguageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<OrganizationResponse> Organization()
        {
            var apiCallPath = "/resources/organizations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OrganizationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<OrganizationTypeResponse> OrganizationType()
        {
            var apiCallPath = "/resources/organizationtypes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<OrganizationTypeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cdccontentservicesip")]
        public IBodyWorkflowAction<SourceResponse> Source()
        {
            var apiCallPath = "/resources/sources";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SourceResponse>(callPayload);
        }
    }

    public class CdccontentservicesipTriggers([ConnectionName] string connectionId)
    {
    }

    public class MediaSearchResponse
    {
        [JsonProperty("meta")]
        public MediaSearchResponseMetaType Meta { get; set; }

        [JsonProperty("results")]
        public MediaSearchResponseResultsTypeItem[] Results { get; set; }
    }

    public class MediaSearchResponseMetaType
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("message")]
        public string[] Message { get; set; }

        [JsonProperty("resultSet")]
        public MediaSearchResponseMetaTypeResultSetType ResultSet { get; set; }

        [JsonProperty("pagination")]
        public MediaSearchResponseMetaTypePaginationType Pagination { get; set; }
    }

    public class MediaSearchResponseMetaTypeResultSetType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MediaSearchResponseMetaTypePaginationType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("pageNum")]
        public int PageNum { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }

        [JsonProperty("previousUrl")]
        public string PreviousUrl { get; set; }

        [JsonProperty("currentUrl")]
        public string CurrentUrl { get; set; }

        [JsonProperty("nextUrl")]
        public string NextUrl { get; set; }
    }

    public class MediaSearchResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("language")]
        public MediaSearchResponseResultsTypeItemLanguageType Language { get; set; }

        [JsonProperty("tags")]
        public MediaSearchResponseResultsTypeItemTagsTypeItem[] Tags { get; set; }

        [JsonProperty("geoTags")]
        public MediaSearchResponseResultsTypeItemGeoTagsTypeItem[] GeoTags { get; set; }

        [JsonProperty("campaigns")]
        public string[] Campaigns { get; set; }

        [JsonProperty("source")]
        public MediaSearchResponseResultsTypeItemSourceType Source { get; set; }

        [JsonProperty("attribution")]
        public string Attribution { get; set; }

        [JsonProperty("domainName")]
        public string DomainName { get; set; }

        [JsonProperty("owningOrgName")]
        public string OwningOrgName { get; set; }

        [JsonProperty("owningOrgId")]
        public string OwningOrgId { get; set; }

        [JsonProperty("maintainingOrgName")]
        public string MaintainingOrgName { get; set; }

        [JsonProperty("maintainingOrgId")]
        public string MaintainingOrgId { get; set; }

        [JsonProperty("sourceUrl")]
        public string SourceUrl { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("persistentUrl")]
        public string PersistentUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("alternateImages")]
        public MediaSearchResponseResultsTypeItemAlternateImagesTypeItem[] AlternateImages { get; set; }

        [JsonProperty("alternateText")]
        public string AlternateText { get; set; }

        [JsonProperty("noScriptText")]
        public string NoScriptText { get; set; }

        [JsonProperty("featuredText")]
        public string FeaturedText { get; set; }

        [JsonProperty("embedCode")]
        public string EmbedCode { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("length")]
        public string Length { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("childCount")]
        public int ChildCount { get; set; }

        [JsonProperty("children")]
        public string[] Children { get; set; }

        [JsonProperty("parentCount")]
        public int ParentCount { get; set; }

        [JsonProperty("parents")]
        public string[] Parents { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("ratingCount")]
        public string RatingCount { get; set; }

        [JsonProperty("ratingCommentCount")]
        public string RatingCommentCount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("datePublished")]
        public string DatePublished { get; set; }

        [JsonProperty("dateModified")]
        public string DateModified { get; set; }

        [JsonProperty("dateContentAuthored")]
        public string DateContentAuthored { get; set; }

        [JsonProperty("dateContentUpdated")]
        public string DateContentUpdated { get; set; }

        [JsonProperty("dateContentPublished")]
        public string DateContentPublished { get; set; }

        [JsonProperty("dateContentReviewed")]
        public string DateContentReviewed { get; set; }

        [JsonProperty("dateSyndicationCaptured")]
        public string DateSyndicationCaptured { get; set; }

        [JsonProperty("dateSyndicationUpdated")]
        public string DateSyndicationUpdated { get; set; }

        [JsonProperty("dateSyndicationVisible")]
        public string DateSyndicationVisible { get; set; }

        [JsonProperty("extendedAttributes")]
        public MediaSearchResponseResultsTypeItemExtendedAttributesType ExtendedAttributes { get; set; }
    }

    public class MediaSearchResponseResultsTypeItemLanguageType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isoCode")]
        public string IsoCode { get; set; }
    }

    public class MediaSearchResponseResultsTypeItemTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class MediaSearchResponseResultsTypeItemGeoTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("geoNameId")]
        public int GeoNameId { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("admin1Code")]
        public string Admin1Code { get; set; }
    }

    public class MediaSearchResponseResultsTypeItemSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("largeLogoUrl")]
        public string LargeLogoUrl { get; set; }

        [JsonProperty("smallLogoUrl")]
        public string SmallLogoUrl { get; set; }
    }

    public class MediaSearchResponseResultsTypeItemAlternateImagesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MediaSearchResponseResultsTypeItemExtendedAttributesType
    {
        [JsonProperty("categoryNav")]
        public string CategoryNav { get; set; }

        [JsonProperty("topicContextTitle")]
        public string TopicContextTitle { get; set; }
    }

    public enum orderInput
    {
        ASC,
        DESC
    }

    public class MediaGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("language")]
        public MediaGetResponseLanguageType Language { get; set; }

        [JsonProperty("tags")]
        public MediaGetResponseTagsTypeItem[] Tags { get; set; }

        [JsonProperty("geoTags")]
        public MediaGetResponseGeoTagsTypeItem[] GeoTags { get; set; }

        [JsonProperty("campaigns")]
        public string[] Campaigns { get; set; }

        [JsonProperty("source")]
        public MediaGetResponseSourceType Source { get; set; }

        [JsonProperty("attribution")]
        public string Attribution { get; set; }

        [JsonProperty("domainName")]
        public string DomainName { get; set; }

        [JsonProperty("owningOrgName")]
        public string OwningOrgName { get; set; }

        [JsonProperty("owningOrgId")]
        public string OwningOrgId { get; set; }

        [JsonProperty("maintainingOrgName")]
        public string MaintainingOrgName { get; set; }

        [JsonProperty("maintainingOrgId")]
        public string MaintainingOrgId { get; set; }

        [JsonProperty("sourceUrl")]
        public string SourceUrl { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("persistentUrl")]
        public string PersistentUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("alternateImages")]
        public MediaGetResponseAlternateImagesTypeItem[] AlternateImages { get; set; }

        [JsonProperty("alternateText")]
        public string AlternateText { get; set; }

        [JsonProperty("noScriptText")]
        public string NoScriptText { get; set; }

        [JsonProperty("featuredText")]
        public string FeaturedText { get; set; }

        [JsonProperty("embedCode")]
        public string EmbedCode { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("length")]
        public string Length { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("childCount")]
        public int ChildCount { get; set; }

        [JsonProperty("children")]
        public string[] Children { get; set; }

        [JsonProperty("parentCount")]
        public int ParentCount { get; set; }

        [JsonProperty("parents")]
        public string[] Parents { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("ratingCount")]
        public string RatingCount { get; set; }

        [JsonProperty("ratingCommentCount")]
        public string RatingCommentCount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("datePublished")]
        public string DatePublished { get; set; }

        [JsonProperty("dateModified")]
        public string DateModified { get; set; }

        [JsonProperty("dateContentAuthored")]
        public string DateContentAuthored { get; set; }

        [JsonProperty("dateContentUpdated")]
        public string DateContentUpdated { get; set; }

        [JsonProperty("dateContentPublished")]
        public string DateContentPublished { get; set; }

        [JsonProperty("dateContentReviewed")]
        public string DateContentReviewed { get; set; }

        [JsonProperty("dateSyndicationCaptured")]
        public string DateSyndicationCaptured { get; set; }

        [JsonProperty("dateSyndicationUpdated")]
        public string DateSyndicationUpdated { get; set; }

        [JsonProperty("dateSyndicationVisible")]
        public string DateSyndicationVisible { get; set; }

        [JsonProperty("extendedAttributes")]
        public MediaGetResponseExtendedAttributesType ExtendedAttributes { get; set; }
    }

    public class MediaGetResponseLanguageType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isoCode")]
        public string IsoCode { get; set; }
    }

    public class MediaGetResponseTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class MediaGetResponseGeoTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("geoNameId")]
        public int GeoNameId { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("admin1Code")]
        public string Admin1Code { get; set; }
    }

    public class MediaGetResponseSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("largeLogoUrl")]
        public string LargeLogoUrl { get; set; }

        [JsonProperty("smallLogoUrl")]
        public string SmallLogoUrl { get; set; }
    }

    public class MediaGetResponseAlternateImagesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MediaGetResponseExtendedAttributesType
    {
        [JsonProperty("categoryNav")]
        public string CategoryNav { get; set; }

        [JsonProperty("topicContextTitle")]
        public string TopicContextTitle { get; set; }
    }

    public class MediaTypesResponse
    {
        [JsonProperty("results")]
        public MediaTypesResponseResultsTypeItem[] Results { get; set; }
    }

    public class MediaTypesResponseResultsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayOrdinal")]
        public int DisplayOrdinal { get; set; }
    }

    public class TopicsResponse
    {
        [JsonProperty("results")]
        public TopicsResponseResultsTypeItem[] Results { get; set; }
    }

    public class TopicsResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("mediaUsageCount")]
        public int MediaUsageCount { get; set; }

        [JsonProperty("displayOrdinal")]
        public int DisplayOrdinal { get; set; }

        [JsonProperty("items")]
        public TopicsResponseResultsTypeItemItemsTypeItem[] Items { get; set; }
    }

    public class TopicsResponseResultsTypeItemItemsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("mediaUsageCount")]
        public int MediaUsageCount { get; set; }

        [JsonProperty("displayOrdinal")]
        public int DisplayOrdinal { get; set; }
    }

    public class AudiencesResponse
    {
        [JsonProperty("results")]
        public AudiencesResponseResultsTypeItem[] Results { get; set; }
    }

    public class AudiencesResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("mediaUsageCount")]
        public int MediaUsageCount { get; set; }

        [JsonProperty("displayOrdinal")]
        public int DisplayOrdinal { get; set; }

        [JsonProperty("items")]
        public AudiencesResponseResultsTypeItemItemsTypeItem[] Items { get; set; }
    }

    public class AudiencesResponseResultsTypeItemItemsTypeItem
    {
        [JsonProperty("results")]
        public AudiencesResponseResultsTypeItemItemsTypeItemResultsTypeItem[] Results { get; set; }
    }

    public class AudiencesResponseResultsTypeItemItemsTypeItemResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("mediaUsageCount")]
        public int MediaUsageCount { get; set; }

        [JsonProperty("displayOrdinal")]
        public int DisplayOrdinal { get; set; }
    }

    public class TagsResponse
    {
        [JsonProperty("results")]
        public TagsResponseResultsTypeItem[] Results { get; set; }
    }

    public class TagsResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class TagGetResponse
    {
        [JsonProperty("results")]
        public TagGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class TagGetResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class MediaTagResponse
    {
        [JsonProperty("results")]
        public MediaTagResponseResultsTypeItem[] Results { get; set; }
    }

    public class MediaTagResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mediaType")]
        public string MediaType { get; set; }

        [JsonProperty("language")]
        public MediaTagResponseResultsTypeItemLanguageType Language { get; set; }

        [JsonProperty("tags")]
        public MediaTagResponseResultsTypeItemTagsTypeItem[] Tags { get; set; }

        [JsonProperty("geoTags")]
        public MediaTagResponseResultsTypeItemGeoTagsTypeItem[] GeoTags { get; set; }

        [JsonProperty("campaigns")]
        public string[] Campaigns { get; set; }

        [JsonProperty("source")]
        public MediaTagResponseResultsTypeItemSourceType Source { get; set; }

        [JsonProperty("attribution")]
        public string Attribution { get; set; }

        [JsonProperty("domainName")]
        public string DomainName { get; set; }

        [JsonProperty("owningOrgName")]
        public string OwningOrgName { get; set; }

        [JsonProperty("owningOrgId")]
        public string OwningOrgId { get; set; }

        [JsonProperty("maintainingOrgName")]
        public string MaintainingOrgName { get; set; }

        [JsonProperty("maintainingOrgId")]
        public string MaintainingOrgId { get; set; }

        [JsonProperty("sourceUrl")]
        public string SourceUrl { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("persistentUrl")]
        public string PersistentUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("alternateImages")]
        public MediaTagResponseResultsTypeItemAlternateImagesTypeItem[] AlternateImages { get; set; }

        [JsonProperty("alternateText")]
        public string AlternateText { get; set; }

        [JsonProperty("noScriptText")]
        public string NoScriptText { get; set; }

        [JsonProperty("featuredText")]
        public string FeaturedText { get; set; }

        [JsonProperty("embedCode")]
        public string EmbedCode { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("length")]
        public string Length { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("childCount")]
        public int ChildCount { get; set; }

        [JsonProperty("children")]
        public string[] Children { get; set; }

        [JsonProperty("parentCount")]
        public int ParentCount { get; set; }

        [JsonProperty("parents")]
        public string[] Parents { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("ratingCount")]
        public string RatingCount { get; set; }

        [JsonProperty("ratingCommentCount")]
        public string RatingCommentCount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("datePublished")]
        public string DatePublished { get; set; }

        [JsonProperty("dateModified")]
        public string DateModified { get; set; }

        [JsonProperty("dateContentAuthored")]
        public string DateContentAuthored { get; set; }

        [JsonProperty("dateContentUpdated")]
        public string DateContentUpdated { get; set; }

        [JsonProperty("dateContentPublished")]
        public string DateContentPublished { get; set; }

        [JsonProperty("dateContentReviewed")]
        public string DateContentReviewed { get; set; }

        [JsonProperty("dateSyndicationCaptured")]
        public string DateSyndicationCaptured { get; set; }

        [JsonProperty("dateSyndicationUpdated")]
        public string DateSyndicationUpdated { get; set; }

        [JsonProperty("dateSyndicationVisible")]
        public string DateSyndicationVisible { get; set; }

        [JsonProperty("extendedAttributes")]
        public MediaTagResponseResultsTypeItemExtendedAttributesType ExtendedAttributes { get; set; }
    }

    public class MediaTagResponseResultsTypeItemLanguageType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isoCode")]
        public string IsoCode { get; set; }
    }

    public class MediaTagResponseResultsTypeItemTagsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class MediaTagResponseResultsTypeItemGeoTagsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("geoNameId")]
        public int GeoNameId { get; set; }

        [JsonProperty("parentId")]
        public int ParentId { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("admin1Code")]
        public string Admin1Code { get; set; }
    }

    public class MediaTagResponseResultsTypeItemSourceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("largeLogoUrl")]
        public string LargeLogoUrl { get; set; }

        [JsonProperty("smallLogoUrl")]
        public string SmallLogoUrl { get; set; }
    }

    public class MediaTagResponseResultsTypeItemAlternateImagesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class MediaTagResponseResultsTypeItemExtendedAttributesType
    {
        [JsonProperty("categoryNav")]
        public string CategoryNav { get; set; }

        [JsonProperty("topicContextTitle")]
        public string TopicContextTitle { get; set; }
    }

    public class TagRelatedResponse
    {
        [JsonProperty("results")]
        public TagRelatedResponseResultsTypeItem[] Results { get; set; }
    }

    public class TagRelatedResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class TagTypesResponse
    {
        [JsonProperty("results")]
        public TagTypesResponseResultsTypeItem[] Results { get; set; }
    }

    public class TagTypesResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class LanguageResponse
    {
        [JsonProperty("results")]
        public LanguageResponseResultsTypeItem[] Results { get; set; }
    }

    public class LanguageResponseResultsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isoCode")]
        public string IsoCode { get; set; }
    }

    public class OrganizationResponse
    {
        [JsonProperty("results")]
        public OrganizationResponseResultsTypeItem[] Results { get; set; }
    }

    public class OrganizationResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website")]
        public OrganizationResponseResultsTypeItemWebsiteTypeItem[] Website { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typeOther")]
        public string TypeOther { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("addressContinued")]
        public string AddressContinued { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateProvince")]
        public string StateProvince { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class OrganizationResponseResultsTypeItemWebsiteTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
    }

    public class OrganizationTypeResponse
    {
        [JsonProperty("results")]
        public OrganizationTypeResponseResultsTypeItem[] Results { get; set; }
    }

    public class OrganizationTypeResponseResultsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayOrdinal")]
        public int DisplayOrdinal { get; set; }
    }

    public class SourceResponse
    {
        [JsonProperty("results")]
        public SourceResponseResultsTypeItem[] Results { get; set; }
    }

    public class SourceResponseResultsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("largeLogoUrl")]
        public string LargeLogoUrl { get; set; }

        [JsonProperty("smallLogoUrl")]
        public string SmallLogoUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cdccontentservicesip;

    public partial class WorkflowManagedActions
    {
        public CdccontentservicesipActions Cdccontentservicesip(string connectionId) => new CdccontentservicesipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CdccontentservicesipTriggers Cdccontentservicesip(string connectionId) => new CdccontentservicesipTriggers(connectionId);
    }
}