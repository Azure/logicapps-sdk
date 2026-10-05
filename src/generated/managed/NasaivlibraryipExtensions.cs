//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nasaivlibraryip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NasaivlibraryipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        [WorkflowExpressionFactory(nameof(__BuildSearch))]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> center = null, [WorkflowExpression] Func<string> description = null, [WorkflowExpression] Func<string> description508 = null, [WorkflowExpression] Func<string> keywords = null, [WorkflowExpression] Func<string> location = null, [WorkflowExpression] Func<string> mediaType = null, [WorkflowExpression] Func<string> nasaId = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> photographer = null, [WorkflowExpression] Func<string> secondaryCreator = null, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<int> yearStart = null, [WorkflowExpression] Func<int> yearEnd = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchResponse> __BuildSearch(WorkflowValue<string> q = null, WorkflowValue<string> center = null, WorkflowValue<string> description = null, WorkflowValue<string> description508 = null, WorkflowValue<string> keywords = null, WorkflowValue<string> location = null, WorkflowValue<string> mediaType = null, WorkflowValue<string> nasaId = null, WorkflowValue<int> page = null, WorkflowValue<string> photographer = null, WorkflowValue<string> secondaryCreator = null, WorkflowValue<string> title = null, WorkflowValue<int> yearStart = null, WorkflowValue<int> yearEnd = null)
        {
            WorkflowValue.Validate(q, nameof(q), required: false);
            WorkflowValue.Validate(center, nameof(center), required: false);
            WorkflowValue.Validate(description, nameof(description), required: false);
            WorkflowValue.Validate(description508, nameof(description508), required: false);
            WorkflowValue.Validate(keywords, nameof(keywords), required: false);
            WorkflowValue.Validate(location, nameof(location), required: false);
            WorkflowValue.Validate(mediaType, nameof(mediaType), required: false);
            WorkflowValue.Validate(nasaId, nameof(nasaId), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(photographer, nameof(photographer), required: false);
            WorkflowValue.Validate(secondaryCreator, nameof(secondaryCreator), required: false);
            WorkflowValue.Validate(title, nameof(title), required: false);
            WorkflowValue.Validate(yearStart, nameof(yearStart), required: false);
            WorkflowValue.Validate(yearEnd, nameof(yearEnd), required: false);
            return new DeferredBodyAction<SearchResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        [WorkflowExpressionFactory(nameof(__BuildGetMediaAssetManifest))]
        public IBodyWorkflowAction<GetMediaAssetManifestResponse> GetMediaAssetManifest([WorkflowExpression] Func<string> nasaId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMediaAssetManifestResponse> __BuildGetMediaAssetManifest(WorkflowValue<string> nasaId)
        {
            WorkflowValue.Validate(nasaId, nameof(nasaId), required: true);
            return new DeferredBodyAction<GetMediaAssetManifestResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/asset/{0}", ExpressionConverter.ConvertWithUrlEncoding(nasaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMediaAssetManifestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        [WorkflowExpressionFactory(nameof(__BuildGetMediaAssetMetadataLocation))]
        public IBodyWorkflowAction<GetMediaAssetMetadataLocationResponse> GetMediaAssetMetadataLocation([WorkflowExpression] Func<string> nasaId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMediaAssetMetadataLocationResponse> __BuildGetMediaAssetMetadataLocation(WorkflowValue<string> nasaId)
        {
            WorkflowValue.Validate(nasaId, nameof(nasaId), required: true);
            return new DeferredBodyAction<GetMediaAssetMetadataLocationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/metadata/{0}", ExpressionConverter.ConvertWithUrlEncoding(nasaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetMediaAssetMetadataLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        [WorkflowExpressionFactory(nameof(__BuildGetVideoAssetCaptionsLocation))]
        public IBodyWorkflowAction<GetVideoAssetCaptionsLocationResponse> GetVideoAssetCaptionsLocation([WorkflowExpression] Func<string> nasaId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetVideoAssetCaptionsLocationResponse> __BuildGetVideoAssetCaptionsLocation(WorkflowValue<string> nasaId)
        {
            WorkflowValue.Validate(nasaId, nameof(nasaId), required: true);
            return new DeferredBodyAction<GetVideoAssetCaptionsLocationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/captions/{0}", ExpressionConverter.ConvertWithUrlEncoding(nasaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetVideoAssetCaptionsLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        [WorkflowExpressionFactory(nameof(__BuildGetMediaAlbumContents))]
        public IBodyWorkflowAction<GetMediaAlbumContentsResponse> GetMediaAlbumContents([WorkflowExpression] Func<string> albumName, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMediaAlbumContentsResponse> __BuildGetMediaAlbumContents(WorkflowValue<string> albumName, WorkflowValue<int> page = null)
        {
            WorkflowValue.Validate(albumName, nameof(albumName), required: true);
            WorkflowValue.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<GetMediaAlbumContentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/album/{0}", ExpressionConverter.ConvertWithUrlEncoding(albumName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
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
