//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nasaivlibraryip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NasaivlibraryipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<SearchResponse> Search([WorkflowExpression] Func<string> q = null, [WorkflowExpression] Func<string> center = null, [WorkflowExpression] Func<string> description = null, [WorkflowExpression] Func<string> description508 = null, [WorkflowExpression] Func<string> keywords = null, [WorkflowExpression] Func<string> location = null, [WorkflowExpression] Func<string> mediaType = null, [WorkflowExpression] Func<string> nasaId = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> photographer = null, [WorkflowExpression] Func<string> secondaryCreator = null, [WorkflowExpression] Func<string> title = null, [WorkflowExpression] Func<int> yearStart = null, [WorkflowExpression] Func<int> yearEnd = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (q != null)
                    callPayload.Queries["q"] = SourceExpressionConverter.ConvertO(q);
                if (center != null)
                    callPayload.Queries["center"] = SourceExpressionConverter.ConvertO(center);
                if (description != null)
                    callPayload.Queries["description"] = SourceExpressionConverter.ConvertO(description);
                if (description508 != null)
                    callPayload.Queries["description_508"] = SourceExpressionConverter.ConvertO(description508);
                if (keywords != null)
                    callPayload.Queries["keywords"] = SourceExpressionConverter.ConvertO(keywords);
                if (location != null)
                    callPayload.Queries["location"] = SourceExpressionConverter.ConvertO(location);
                if (mediaType != null)
                    callPayload.Queries["media_type"] = SourceExpressionConverter.ConvertO(mediaType);
                if (nasaId != null)
                    callPayload.Queries["nasa_id"] = SourceExpressionConverter.ConvertO(nasaId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (photographer != null)
                    callPayload.Queries["photographer"] = SourceExpressionConverter.ConvertO(photographer);
                if (secondaryCreator != null)
                    callPayload.Queries["secondary_creator"] = SourceExpressionConverter.ConvertO(secondaryCreator);
                if (title != null)
                    callPayload.Queries["title"] = SourceExpressionConverter.ConvertO(title);
                if (yearStart != null)
                    callPayload.Queries["year_start"] = SourceExpressionConverter.ConvertO(yearStart);
                if (yearEnd != null)
                    callPayload.Queries["year_end"] = SourceExpressionConverter.ConvertO(yearEnd);
                return callPayload;
            }

            return new ApiConnectionAction<SearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<GetMediaAssetManifestResponse> GetMediaAssetManifest([WorkflowExpression] Func<string> nasaId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/asset/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nasaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetMediaAssetManifestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<GetMediaAssetMetadataLocationResponse> GetMediaAssetMetadataLocation([WorkflowExpression] Func<string> nasaId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/metadata/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nasaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetMediaAssetMetadataLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<GetVideoAssetCaptionsLocationResponse> GetVideoAssetCaptionsLocation([WorkflowExpression] Func<string> nasaId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/captions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nasaId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetVideoAssetCaptionsLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nasaivlibraryip")]
        public IBodyWorkflowAction<GetMediaAlbumContentsResponse> GetMediaAlbumContents([WorkflowExpression] Func<string> albumName, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/album/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(albumName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<GetMediaAlbumContentsResponse>(BuildSourceInput);
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