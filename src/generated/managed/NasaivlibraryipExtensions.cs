//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Nasaivlibraryip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NasaivlibraryipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<SearchResponse> Search(Expression<Func<string>> q = null, Expression<Func<string>> center = null, Expression<Func<string>> description = null, Expression<Func<string>> description508 = null, Expression<Func<string>> keywords = null, Expression<Func<string>> location = null, Expression<Func<string>> mediaType = null, Expression<Func<string>> nasaId = null, Expression<Func<int>> page = null, Expression<Func<string>> photographer = null, Expression<Func<string>> secondaryCreator = null, Expression<Func<string>> title = null, Expression<Func<int>> yearStart = null, Expression<Func<int>> yearEnd = null)
        {
            var apiCallPath = "/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (q != null)
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (center != null)
                callPayload.Queries["center"] = ExpressionConverter.Convert(center);
            if (description != null)
                callPayload.Queries["description"] = ExpressionConverter.Convert(description);
            if (description508 != null)
                callPayload.Queries["description_508"] = ExpressionConverter.Convert(description508);
            if (keywords != null)
                callPayload.Queries["keywords"] = ExpressionConverter.Convert(keywords);
            if (location != null)
                callPayload.Queries["location"] = ExpressionConverter.Convert(location);
            if (mediaType != null)
                callPayload.Queries["media_type"] = ExpressionConverter.Convert(mediaType);
            if (nasaId != null)
                callPayload.Queries["nasa_id"] = ExpressionConverter.Convert(nasaId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (photographer != null)
                callPayload.Queries["photographer"] = ExpressionConverter.Convert(photographer);
            if (secondaryCreator != null)
                callPayload.Queries["secondary_creator"] = ExpressionConverter.Convert(secondaryCreator);
            if (title != null)
                callPayload.Queries["title"] = ExpressionConverter.Convert(title);
            if (yearStart != null)
                callPayload.Queries["year_start"] = ExpressionConverter.Convert(yearStart);
            if (yearEnd != null)
                callPayload.Queries["year_end"] = ExpressionConverter.Convert(yearEnd);
            return new ApiConnectionAction<SearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<GetMediaAssetManifestResponse> GetMediaAssetManifest(Expression<Func<string>> nasaId)
        {
            var apiCallPath = String.Format("/asset/{0}", ExpressionConverter.ConvertWithUrlEncoding(nasaId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetMediaAssetManifestResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<GetMediaAssetMetadataLocationResponse> GetMediaAssetMetadataLocation(Expression<Func<string>> nasaId)
        {
            var apiCallPath = String.Format("/metadata/{0}", ExpressionConverter.ConvertWithUrlEncoding(nasaId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetMediaAssetMetadataLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<GetVideoAssetCaptionsLocationResponse> GetVideoAssetCaptionsLocation(Expression<Func<string>> nasaId)
        {
            var apiCallPath = String.Format("/captions/{0}", ExpressionConverter.ConvertWithUrlEncoding(nasaId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetVideoAssetCaptionsLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<GetMediaAlbumContentsResponse> GetMediaAlbumContents(Expression<Func<string>> albumName, Expression<Func<int>> page = null)
        {
            var apiCallPath = String.Format("/album/{0}", ExpressionConverter.ConvertWithUrlEncoding(albumName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<GetMediaAlbumContentsResponse>(callPayload);
        }
    }

    public class NasaivlibraryipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchResponse
    {
        [JsonProperty("collection")]
        public SearchResponseCollectionType Collection { get; set; }
    }

    public class SearchResponseCollectionType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("items")]
        public SearchResponseCollectionTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("links")]
        public SearchResponseCollectionTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("metadata")]
        public SearchResponseCollectionTypeMetadataType Metadata { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class SearchResponseCollectionTypeItemsTypeItem
    {
        [JsonProperty("data")]
        public SearchResponseCollectionTypeItemsTypeItemDataTypeItem[] Data { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("links")]
        public SearchResponseCollectionTypeItemsTypeItemLinksTypeItem[] Links { get; set; }
    }

    public class SearchResponseCollectionTypeItemsTypeItemDataTypeItem
    {
        [JsonProperty("center")]
        public string Center { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("album")]
        public string[] Album { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("nasa_id")]
        public string NasaId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SearchResponseCollectionTypeItemsTypeItemLinksTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("render")]
        public string Render { get; set; }
    }

    public class SearchResponseCollectionTypeLinksTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }
    }

    public class SearchResponseCollectionTypeMetadataType
    {
        [JsonProperty("total_hits")]
        public int TotalHits { get; set; }
    }

    public class GetMediaAssetManifestResponse
    {
        [JsonProperty("collection")]
        public GetMediaAssetManifestResponseCollectionType Collection { get; set; }
    }

    public class GetMediaAssetManifestResponseCollectionType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("items")]
        public GetMediaAssetManifestResponseCollectionTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class GetMediaAssetManifestResponseCollectionTypeItemsTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class GetMediaAssetMetadataLocationResponse
    {
        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public class GetVideoAssetCaptionsLocationResponse
    {
        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public class GetMediaAlbumContentsResponse
    {
        [JsonProperty("collection")]
        public GetMediaAlbumContentsResponseCollectionType Collection { get; set; }
    }

    public class GetMediaAlbumContentsResponseCollectionType
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("items")]
        public GetMediaAlbumContentsResponseCollectionTypeItemsTypeItem[] Items { get; set; }

        [JsonProperty("metadata")]
        public GetMediaAlbumContentsResponseCollectionTypeMetadataType Metadata { get; set; }

        [JsonProperty("links")]
        public GetMediaAlbumContentsResponseCollectionTypeLinksTypeItem[] Links { get; set; }
    }

    public class GetMediaAlbumContentsResponseCollectionTypeItemsTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("data")]
        public GetMediaAlbumContentsResponseCollectionTypeItemsTypeItemDataTypeItem[] Data { get; set; }

        [JsonProperty("links")]
        public GetMediaAlbumContentsResponseCollectionTypeItemsTypeItemLinksTypeItem[] Links { get; set; }
    }

    public class GetMediaAlbumContentsResponseCollectionTypeItemsTypeItemDataTypeItem
    {
        [JsonProperty("album")]
        public string[] Album { get; set; }

        [JsonProperty("center")]
        public string Center { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("photographer")]
        public string Photographer { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("nasa_id")]
        public string NasaId { get; set; }

        [JsonProperty("date_created")]
        public string DateCreated { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public class GetMediaAlbumContentsResponseCollectionTypeItemsTypeItemLinksTypeItem
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("render")]
        public string Render { get; set; }
    }

    public class GetMediaAlbumContentsResponseCollectionTypeMetadataType
    {
        [JsonProperty("total_hits")]
        public int TotalHits { get; set; }
    }

    public class GetMediaAlbumContentsResponseCollectionTypeLinksTypeItem
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Nasaivlibraryip;

    public partial class WorkflowManagedActions
    {
        public NasaivlibraryipActions Nasaivlibraryip(string connectionId) => new NasaivlibraryipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NasaivlibraryipTriggers Nasaivlibraryip(string connectionId) => new NasaivlibraryipTriggers(connectionId);
    }
}