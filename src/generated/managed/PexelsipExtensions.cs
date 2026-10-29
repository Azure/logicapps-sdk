//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pexelsip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PexelsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pexelsip")]
        public IBodyWorkflowAction<SearchPhotosResponse, ApiConnectionActionConfiguration> SearchPhotos(Expression<Func<string>> query, Expression<Func<orientationInput>> orientation = null, Expression<Func<sizeInput>> size = null, Expression<Func<string>> color = null, Expression<Func<localeInput>> locale = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_orientation = WorkflowExpression.Compile(orientation, nameof(orientation), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_color = WorkflowExpression.Compile(color, nameof(color), required: false);
            var __workflow_locale = WorkflowExpression.Compile(locale, nameof(locale), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SearchPhotosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_orientation != null)
                    callPayload.Queries["orientation"] = ExpressionConverter.Convert(__workflow_orientation);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_color != null)
                    callPayload.Queries["color"] = ExpressionConverter.Convert(__workflow_color);
                if (__workflow_locale != null)
                    callPayload.Queries["locale"] = ExpressionConverter.Convert(__workflow_locale);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<SearchPhotosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pexelsip")]
        public IBodyWorkflowAction<ListCuratedPhotosResponse, ApiConnectionActionConfiguration> ListCuratedPhotos(Expression<Func<int>> perPage = null, Expression<Func<int>> page = null)
        {
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<ListCuratedPhotosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/curated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<ListCuratedPhotosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pexelsip")]
        public IBodyWorkflowAction<GetPhotoResponse, ApiConnectionActionConfiguration> GetPhoto(Expression<Func<string>> photoId)
        {
            var __workflow_photoId = WorkflowExpression.Compile(photoId, nameof(photoId), required: true);
            return new DeferredBodyAction<GetPhotoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/photos/{0}", __workflow_photoId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPhotoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pexelsip")]
        public IBodyWorkflowAction<SearchVideosResponse, ApiConnectionActionConfiguration> SearchVideos(Expression<Func<string>> query, Expression<Func<orientationInput>> orientation = null, Expression<Func<sizeInput>> size = null, Expression<Func<localeInput>> locale = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: true);
            var __workflow_orientation = WorkflowExpression.Compile(orientation, nameof(orientation), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            var __workflow_locale = WorkflowExpression.Compile(locale, nameof(locale), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SearchVideosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/videos/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_orientation != null)
                    callPayload.Queries["orientation"] = ExpressionConverter.Convert(__workflow_orientation);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                if (__workflow_locale != null)
                    callPayload.Queries["locale"] = ExpressionConverter.Convert(__workflow_locale);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<SearchVideosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pexelsip")]
        public IBodyWorkflowAction<ListPopularVideosResponse, ApiConnectionActionConfiguration> ListPopularVideos(Expression<Func<int>> minWidth = null, Expression<Func<int>> minHeight = null, Expression<Func<int>> minDuration = null, Expression<Func<int>> maxDuration = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_minWidth = WorkflowExpression.Compile(minWidth, nameof(minWidth), required: false);
            var __workflow_minHeight = WorkflowExpression.Compile(minHeight, nameof(minHeight), required: false);
            var __workflow_minDuration = WorkflowExpression.Compile(minDuration, nameof(minDuration), required: false);
            var __workflow_maxDuration = WorkflowExpression.Compile(maxDuration, nameof(maxDuration), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ListPopularVideosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/videos/popular";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_minWidth != null)
                    callPayload.Queries["min_width"] = ExpressionConverter.Convert(__workflow_minWidth);
                if (__workflow_minHeight != null)
                    callPayload.Queries["min_height"] = ExpressionConverter.Convert(__workflow_minHeight);
                if (__workflow_minDuration != null)
                    callPayload.Queries["min_duration"] = ExpressionConverter.Convert(__workflow_minDuration);
                if (__workflow_maxDuration != null)
                    callPayload.Queries["max_duration"] = ExpressionConverter.Convert(__workflow_maxDuration);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<ListPopularVideosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pexelsip")]
        public IBodyWorkflowAction<GetVideoResponse, ApiConnectionActionConfiguration> GetVideo(Expression<Func<int>> videoId)
        {
            var __workflow_videoId = WorkflowExpression.Compile(videoId, nameof(videoId), required: true);
            return new DeferredBodyAction<GetVideoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/videos/videos/{0}", __workflow_videoId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetVideoResponse>(callPayload);
            });
        }
    }

    public class PexelsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchPhotosResponse
    {
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("photos")]
        public SearchPhotosResponsePhotosTypeItem[] Photos { get; set; }

        [JsonProperty("prev_page")]
        public string PrevPage { get; set; }

        [JsonProperty("next_page")]
        public string NextPage { get; set; }
    }

    public class SearchPhotosResponsePhotosTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("photographer")]
        public string Photographer { get; set; }

        [JsonProperty("photographer_url")]
        public string PhotographerUrl { get; set; }

        [JsonProperty("photographer_id")]
        public int PhotographerId { get; set; }

        [JsonProperty("avg_color")]
        public string AvgColor { get; set; }

        [JsonProperty("src")]
        public SearchPhotosResponsePhotosTypeItemSrcType Src { get; set; }

        [JsonProperty("liked")]
        public bool Liked { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }
    }

    public class SearchPhotosResponsePhotosTypeItemSrcType
    {
        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("large2x")]
        public string Large2x { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("portrait")]
        public string Portrait { get; set; }

        [JsonProperty("landscape")]
        public string Landscape { get; set; }

        [JsonProperty("tiny")]
        public string Tiny { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orientationInput
    {
        [EnumMember(Value = "landscape")]
        Landscape,
        [EnumMember(Value = "portrait")]
        Portrait,
        [EnumMember(Value = "square")]
        Square
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sizeInput
    {
        [EnumMember(Value = "large")]
        Large,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "small")]
        Small
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum localeInput
    {
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "pt-BR")]
        PtBR,
        [EnumMember(Value = "es-ES")]
        EsES,
        [EnumMember(Value = "ca-ES")]
        CaES,
        [EnumMember(Value = "de-DE")]
        DeDE,
        [EnumMember(Value = "it-IT")]
        ItIT,
        [EnumMember(Value = "fr-FR")]
        FrFR,
        [EnumMember(Value = "sv-SE")]
        SvSE,
        [EnumMember(Value = "id-ID")]
        IdId,
        [EnumMember(Value = "pl-PL")]
        PlPL,
        [EnumMember(Value = "ja-JP")]
        JaJP,
        [EnumMember(Value = "zh-TW")]
        ZhTW,
        [EnumMember(Value = "zh-CN")]
        ZhCN,
        [EnumMember(Value = "ko-KR")]
        KoKR,
        [EnumMember(Value = "th-TH")]
        ThTH,
        [EnumMember(Value = "nl-NL")]
        NlNL,
        [EnumMember(Value = "hu-HU")]
        HuHU,
        [EnumMember(Value = "vi-VN")]
        ViVN,
        [EnumMember(Value = "cs-CZ")]
        CsCZ,
        [EnumMember(Value = "da-DK")]
        DaDK,
        [EnumMember(Value = "fi-FI")]
        FiFI,
        [EnumMember(Value = "uk-UA")]
        UkUA,
        [EnumMember(Value = "el-GR")]
        ElGR,
        [EnumMember(Value = "ro-RO")]
        RoRO,
        [EnumMember(Value = "nb-NO")]
        NbNO,
        [EnumMember(Value = "sk-SK")]
        SkSK,
        [EnumMember(Value = "tr-TR")]
        TrTR,
        [EnumMember(Value = "ru-RU")]
        RuRU
    }

    public class ListCuratedPhotosResponse
    {
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("photos")]
        public ListCuratedPhotosResponsePhotosTypeItem[] Photos { get; set; }

        [JsonProperty("prev_page")]
        public string PrevPage { get; set; }

        [JsonProperty("next_page")]
        public string NextPage { get; set; }
    }

    public class ListCuratedPhotosResponsePhotosTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("photographer")]
        public string Photographer { get; set; }

        [JsonProperty("photographer_url")]
        public string PhotographerUrl { get; set; }

        [JsonProperty("photographer_id")]
        public int PhotographerId { get; set; }

        [JsonProperty("avg_color")]
        public string AvgColor { get; set; }

        [JsonProperty("src")]
        public ListCuratedPhotosResponsePhotosTypeItemSrcType Src { get; set; }

        [JsonProperty("liked")]
        public bool Liked { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }
    }

    public class ListCuratedPhotosResponsePhotosTypeItemSrcType
    {
        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("large2x")]
        public string Large2x { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("portrait")]
        public string Portrait { get; set; }

        [JsonProperty("landscape")]
        public string Landscape { get; set; }

        [JsonProperty("tiny")]
        public string Tiny { get; set; }
    }

    public class GetPhotoResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("photographer")]
        public string Photographer { get; set; }

        [JsonProperty("photographer_url")]
        public string PhotographerUrl { get; set; }

        [JsonProperty("photographer_id")]
        public int PhotographerId { get; set; }

        [JsonProperty("avg_color")]
        public string AvgColor { get; set; }

        [JsonProperty("src")]
        public GetPhotoResponseSrcType Src { get; set; }

        [JsonProperty("liked")]
        public bool Liked { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }
    }

    public class GetPhotoResponseSrcType
    {
        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("large2x")]
        public string Large2x { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("portrait")]
        public string Portrait { get; set; }

        [JsonProperty("landscape")]
        public string Landscape { get; set; }

        [JsonProperty("tiny")]
        public string Tiny { get; set; }
    }

    public class SearchVideosResponse
    {
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("videos")]
        public SearchVideosResponseVideosTypeItem[] Videos { get; set; }

        [JsonProperty("prev_page")]
        public string PrevPage { get; set; }

        [JsonProperty("next_page")]
        public string NextPage { get; set; }
    }

    public class SearchVideosResponseVideosTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("user")]
        public SearchVideosResponseVideosTypeItemUserType User { get; set; }

        [JsonProperty("video_files")]
        public SearchVideosResponseVideosTypeItemVideoFilesTypeItem[] VideoFiles { get; set; }

        [JsonProperty("video_pictures")]
        public SearchVideosResponseVideosTypeItemVideoPicturesTypeItem[] VideoPictures { get; set; }
    }

    public class SearchVideosResponseVideosTypeItemUserType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SearchVideosResponseVideosTypeItemVideoFilesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("quality")]
        public string Quality { get; set; }

        [JsonProperty("file_type")]
        public string FileType { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class SearchVideosResponseVideosTypeItemVideoPicturesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("nr")]
        public int Nr { get; set; }
    }

    public class ListPopularVideosResponse
    {
        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("videos")]
        public ListPopularVideosResponseVideosTypeItem[] Videos { get; set; }

        [JsonProperty("prev_page")]
        public string PrevPage { get; set; }

        [JsonProperty("next_page")]
        public string NextPage { get; set; }
    }

    public class ListPopularVideosResponseVideosTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("user")]
        public ListPopularVideosResponseVideosTypeItemUserType User { get; set; }

        [JsonProperty("video_files")]
        public ListPopularVideosResponseVideosTypeItemVideoFilesTypeItem[] VideoFiles { get; set; }

        [JsonProperty("video_pictures")]
        public ListPopularVideosResponseVideosTypeItemVideoPicturesTypeItem[] VideoPictures { get; set; }
    }

    public class ListPopularVideosResponseVideosTypeItemUserType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ListPopularVideosResponseVideosTypeItemVideoFilesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("quality")]
        public string Quality { get; set; }

        [JsonProperty("file_type")]
        public string FileType { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class ListPopularVideosResponseVideosTypeItemVideoPicturesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("nr")]
        public int Nr { get; set; }
    }

    public class GetVideoResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("user")]
        public GetVideoResponseUserType User { get; set; }

        [JsonProperty("video_files")]
        public GetVideoResponseVideoFilesTypeItem[] VideoFiles { get; set; }

        [JsonProperty("video_pictures")]
        public GetVideoResponseVideoPicturesTypeItem[] VideoPictures { get; set; }
    }

    public class GetVideoResponseUserType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetVideoResponseVideoFilesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("quality")]
        public string Quality { get; set; }

        [JsonProperty("file_type")]
        public string FileType { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetVideoResponseVideoPicturesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("nr")]
        public int Nr { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pexelsip;

    public partial class WorkflowManagedActions
    {
        public PexelsipActions Pexelsip(string connectionId) => new PexelsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PexelsipTriggers Pexelsip(string connectionId) => new PexelsipTriggers(connectionId);
    }
}