//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nasaivlibraryip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class NasaivlibraryipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<SearchResponse> Search(Expression<Func<string>> q = null, Expression<Func<string>> center = null, Expression<Func<string>> description = null, Expression<Func<string>> description508 = null, Expression<Func<string>> keywords = null, Expression<Func<string>> location = null, Expression<Func<string>> mediaType = null, Expression<Func<string>> nasaId = null, Expression<Func<int>> page = null, Expression<Func<string>> photographer = null, Expression<Func<string>> secondaryCreator = null, Expression<Func<string>> title = null, Expression<Func<int>> yearStart = null, Expression<Func<int>> yearEnd = null)
        {
            var __workflow_q = q == null ? null : WorkflowExpression.Compile(q);
            WorkflowExpression.Validate(__workflow_q, nameof(q), required: false);
            var __workflow_center = center == null ? null : WorkflowExpression.Compile(center);
            WorkflowExpression.Validate(__workflow_center, nameof(center), required: false);
            var __workflow_description = description == null ? null : WorkflowExpression.Compile(description);
            WorkflowExpression.Validate(__workflow_description, nameof(description), required: false);
            var __workflow_description508 = description508 == null ? null : WorkflowExpression.Compile(description508);
            WorkflowExpression.Validate(__workflow_description508, nameof(description508), required: false);
            var __workflow_keywords = keywords == null ? null : WorkflowExpression.Compile(keywords);
            WorkflowExpression.Validate(__workflow_keywords, nameof(keywords), required: false);
            var __workflow_location = location == null ? null : WorkflowExpression.Compile(location);
            WorkflowExpression.Validate(__workflow_location, nameof(location), required: false);
            var __workflow_mediaType = mediaType == null ? null : WorkflowExpression.Compile(mediaType);
            WorkflowExpression.Validate(__workflow_mediaType, nameof(mediaType), required: false);
            var __workflow_nasaId = nasaId == null ? null : WorkflowExpression.Compile(nasaId);
            WorkflowExpression.Validate(__workflow_nasaId, nameof(nasaId), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_photographer = photographer == null ? null : WorkflowExpression.Compile(photographer);
            WorkflowExpression.Validate(__workflow_photographer, nameof(photographer), required: false);
            var __workflow_secondaryCreator = secondaryCreator == null ? null : WorkflowExpression.Compile(secondaryCreator);
            WorkflowExpression.Validate(__workflow_secondaryCreator, nameof(secondaryCreator), required: false);
            var __workflow_title = title == null ? null : WorkflowExpression.Compile(title);
            WorkflowExpression.Validate(__workflow_title, nameof(title), required: false);
            var __workflow_yearStart = yearStart == null ? null : WorkflowExpression.Compile(yearStart);
            WorkflowExpression.Validate(__workflow_yearStart, nameof(yearStart), required: false);
            var __workflow_yearEnd = yearEnd == null ? null : WorkflowExpression.Compile(yearEnd);
            WorkflowExpression.Validate(__workflow_yearEnd, nameof(yearEnd), required: false);
            return new DeferredBodyAction<SearchResponse>(() =>
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_q != null)
                    callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_center != null)
                    callPayload.Queries["center"] = ExpressionConverter.Convert(__workflow_center);
                if (__workflow_description != null)
                    callPayload.Queries["description"] = ExpressionConverter.Convert(__workflow_description);
                if (__workflow_description508 != null)
                    callPayload.Queries["description_508"] = ExpressionConverter.Convert(__workflow_description508);
                if (__workflow_keywords != null)
                    callPayload.Queries["keywords"] = ExpressionConverter.Convert(__workflow_keywords);
                if (__workflow_location != null)
                    callPayload.Queries["location"] = ExpressionConverter.Convert(__workflow_location);
                if (__workflow_mediaType != null)
                    callPayload.Queries["media_type"] = ExpressionConverter.Convert(__workflow_mediaType);
                if (__workflow_nasaId != null)
                    callPayload.Queries["nasa_id"] = ExpressionConverter.Convert(__workflow_nasaId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_photographer != null)
                    callPayload.Queries["photographer"] = ExpressionConverter.Convert(__workflow_photographer);
                if (__workflow_secondaryCreator != null)
                    callPayload.Queries["secondary_creator"] = ExpressionConverter.Convert(__workflow_secondaryCreator);
                if (__workflow_title != null)
                    callPayload.Queries["title"] = ExpressionConverter.Convert(__workflow_title);
                if (__workflow_yearStart != null)
                    callPayload.Queries["year_start"] = ExpressionConverter.Convert(__workflow_yearStart);
                if (__workflow_yearEnd != null)
                    callPayload.Queries["year_end"] = ExpressionConverter.Convert(__workflow_yearEnd);
                return new ApiConnectionAction<SearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<GetMediaAssetManifestResponse> GetMediaAssetManifest(Expression<Func<string>> nasaId)
        {
            var __workflow_nasaId = nasaId == null ? null : WorkflowExpression.Compile(nasaId);
            WorkflowExpression.Validate(__workflow_nasaId, nameof(nasaId), required: true);
            return new DeferredBodyAction<GetMediaAssetManifestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/asset/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_nasaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMediaAssetManifestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<GetMediaAssetMetadataLocationResponse> GetMediaAssetMetadataLocation(Expression<Func<string>> nasaId)
        {
            var __workflow_nasaId = nasaId == null ? null : WorkflowExpression.Compile(nasaId);
            WorkflowExpression.Validate(__workflow_nasaId, nameof(nasaId), required: true);
            return new DeferredBodyAction<GetMediaAssetMetadataLocationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/metadata/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_nasaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMediaAssetMetadataLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<GetVideoAssetCaptionsLocationResponse> GetVideoAssetCaptionsLocation(Expression<Func<string>> nasaId)
        {
            var __workflow_nasaId = nasaId == null ? null : WorkflowExpression.Compile(nasaId);
            WorkflowExpression.Validate(__workflow_nasaId, nameof(nasaId), required: true);
            return new DeferredBodyAction<GetVideoAssetCaptionsLocationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/captions/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_nasaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetVideoAssetCaptionsLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<GetMediaAlbumContentsResponse> GetMediaAlbumContents(Expression<Func<string>> albumName, Expression<Func<int>> page = null)
        {
            var __workflow_albumName = albumName == null ? null : WorkflowExpression.Compile(albumName);
            WorkflowExpression.Validate(__workflow_albumName, nameof(albumName), required: true);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            return new DeferredBodyAction<GetMediaAlbumContentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/album/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_albumName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<GetMediaAlbumContentsResponse>(callPayload);
            });
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nasaivlibraryip;

    public partial class WorkflowManagedActions
    {
        public NasaivlibraryipActions Nasaivlibraryip(string connectionId) => new NasaivlibraryipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NasaivlibraryipTriggers Nasaivlibraryip(string connectionId) => new NasaivlibraryipTriggers(connectionId);
    }
}
