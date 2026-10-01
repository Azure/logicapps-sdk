//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pexelsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PexelsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pexelsip")]
        public IBodyWorkflowAction<SearchPhotosResponse> SearchPhotos([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<orientationInput> orientation = null, [WorkflowExpression] Func<sizeInput> size = null, [WorkflowExpression] Func<string> color = null, [WorkflowExpression] Func<localeInput> locale = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (orientation != null)
                    callPayload.Queries["orientation"] = SourceExpressionConverter.Convert(orientation);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.Convert(size);
                if (color != null)
                    callPayload.Queries["color"] = SourceExpressionConverter.ConvertO(color);
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.Convert(locale);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<SearchPhotosResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pexelsip")]
        public IBodyWorkflowAction<ListCuratedPhotosResponse> ListCuratedPhotos([WorkflowExpression] Func<int> perPage = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/curated";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<ListCuratedPhotosResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pexelsip")]
        public IBodyWorkflowAction<GetPhotoResponse> GetPhoto([WorkflowExpression] Func<string> photoId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/photos/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(photoId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPhotoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pexelsip")]
        public IBodyWorkflowAction<SearchVideosResponse> SearchVideos([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<orientationInput> orientation = null, [WorkflowExpression] Func<sizeInput> size = null, [WorkflowExpression] Func<localeInput> locale = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/videos/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (orientation != null)
                    callPayload.Queries["orientation"] = SourceExpressionConverter.Convert(orientation);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.Convert(size);
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.Convert(locale);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<SearchVideosResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pexelsip")]
        public IBodyWorkflowAction<ListPopularVideosResponse> ListPopularVideos([WorkflowExpression] Func<int> minWidth = null, [WorkflowExpression] Func<int> minHeight = null, [WorkflowExpression] Func<int> minDuration = null, [WorkflowExpression] Func<int> maxDuration = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/videos/popular";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (minWidth != null)
                    callPayload.Queries["min_width"] = SourceExpressionConverter.ConvertO(minWidth);
                if (minHeight != null)
                    callPayload.Queries["min_height"] = SourceExpressionConverter.ConvertO(minHeight);
                if (minDuration != null)
                    callPayload.Queries["min_duration"] = SourceExpressionConverter.ConvertO(minDuration);
                if (maxDuration != null)
                    callPayload.Queries["max_duration"] = SourceExpressionConverter.ConvertO(maxDuration);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<ListPopularVideosResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pexelsip")]
        public IBodyWorkflowAction<GetVideoResponse> GetVideo([WorkflowExpression] Func<int> videoId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/videos/videos/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(videoId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetVideoResponse>(BuildSourceInput);
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

    public enum orientationInput
    {
        [EnumMember(Value = "landscape")]
        Landscape,
        [EnumMember(Value = "portrait")]
        Portrait,
        [EnumMember(Value = "square")]
        Square
    }

    public enum sizeInput
    {
        [EnumMember(Value = "large")]
        Large,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "small")]
        Small
    }

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