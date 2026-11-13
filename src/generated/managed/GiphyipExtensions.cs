//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Giphyip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GiphyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "giphyip")]
        public IBodyWorkflowAction<GetGifResponse, ApiConnectionActionConfiguration> GetGif(Expression<Func<string>> apiKey, Expression<Func<string>> q, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> rating = null, Expression<Func<string>> lang = null)
        {
            var __workflow_apiKey = WorkflowExpression.Compile(apiKey, nameof(apiKey), required: true);
            var __workflow_q = WorkflowExpression.Compile(q, nameof(q), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_rating = WorkflowExpression.Compile(rating, nameof(rating), required: false);
            var __workflow_lang = WorkflowExpression.Compile(lang, nameof(lang), required: false);
            return new DeferredBodyAction<GetGifResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["API_KEY"] = ExpressionConverter.Convert(__workflow_apiKey);
                callPayload.Queries["q"] = ExpressionConverter.Convert(__workflow_q);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_rating != null)
                    callPayload.Queries["rating"] = ExpressionConverter.Convert(__workflow_rating);
                if (__workflow_lang != null)
                    callPayload.Queries["lang"] = ExpressionConverter.Convert(__workflow_lang);
                return new ApiConnectionAction<GetGifResponse>(callPayload);
            });
        }
    }

    public class GiphyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetGifResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("bitly_gif_url")]
        public string BitlyGifUrl { get; set; }

        [JsonProperty("bitly_url")]
        public string BitlyUrl { get; set; }

        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("content_url")]
        public string ContentUrl { get; set; }

        [JsonProperty("source_tld")]
        public string SourceTld { get; set; }

        [JsonProperty("source_post_url")]
        public string SourcePostUrl { get; set; }

        [JsonProperty("is_sticker")]
        public int IsSticker { get; set; }

        [JsonProperty("import_datetime")]
        public string ImportDatetime { get; set; }

        [JsonProperty("trending_datetime")]
        public string TrendingDatetime { get; set; }

        [JsonProperty("images")]
        public GetGifResponseImagesType Images { get; set; }

        [JsonProperty("user")]
        public GetGifResponseUserType User { get; set; }

        [JsonProperty("analytics_response_payload")]
        public string AnalyticsResponsePayload { get; set; }

        [JsonProperty("analytics")]
        public GetGifResponseAnalyticsType Analytics { get; set; }
    }

    public class GetGifResponseImagesType
    {
        [JsonProperty("original")]
        public GetGifResponseImagesTypeOriginalType Original { get; set; }

        [JsonProperty("downsized")]
        public GetGifResponseImagesTypeDownsizedType Downsized { get; set; }

        [JsonProperty("downsized_large")]
        public GetGifResponseImagesTypeDownsizedLargeType DownsizedLarge { get; set; }

        [JsonProperty("downsized_medium")]
        public GetGifResponseImagesTypeDownsizedMediumType DownsizedMedium { get; set; }

        [JsonProperty("downsized_small")]
        public GetGifResponseImagesTypeDownsizedSmallType DownsizedSmall { get; set; }

        [JsonProperty("downsized_still")]
        public GetGifResponseImagesTypeDownsizedStillType DownsizedStill { get; set; }

        [JsonProperty("fixed_height")]
        public GetGifResponseImagesTypeFixedHeightType FixedHeight { get; set; }

        [JsonProperty("fixed_height_downsampled")]
        public GetGifResponseImagesTypeFixedHeightDownsampledType FixedHeightDownsampled { get; set; }

        [JsonProperty("fixed_height_small")]
        public GetGifResponseImagesTypeFixedHeightSmallType FixedHeightSmall { get; set; }

        [JsonProperty("fixed_height_small_still")]
        public GetGifResponseImagesTypeFixedHeightSmallStillType FixedHeightSmallStill { get; set; }

        [JsonProperty("fixed_height_still")]
        public GetGifResponseImagesTypeFixedHeightStillType FixedHeightStill { get; set; }

        [JsonProperty("fixed_width")]
        public GetGifResponseImagesTypeFixedWidthType FixedWidth { get; set; }

        [JsonProperty("fixed_width_downsampled")]
        public GetGifResponseImagesTypeFixedWidthDownsampledType FixedWidthDownsampled { get; set; }

        [JsonProperty("fixed_width_small")]
        public GetGifResponseImagesTypeFixedWidthSmallType FixedWidthSmall { get; set; }

        [JsonProperty("fixed_width_small_still")]
        public GetGifResponseImagesTypeFixedWidthSmallStillType FixedWidthSmallStill { get; set; }

        [JsonProperty("fixed_width_still")]
        public GetGifResponseImagesTypeFixedWidthStillType FixedWidthStill { get; set; }

        [JsonProperty("looping")]
        public GetGifResponseImagesTypeLoopingType Looping { get; set; }

        [JsonProperty("original_still")]
        public GetGifResponseImagesTypeOriginalStillType OriginalStill { get; set; }

        [JsonProperty("original_mp4")]
        public GetGifResponseImagesTypeOriginalMp4Type OriginalMp4 { get; set; }

        [JsonProperty("preview")]
        public GetGifResponseImagesTypePreviewType Preview { get; set; }

        [JsonProperty("preview_gif")]
        public GetGifResponseImagesTypePreviewGifType PreviewGif { get; set; }

        [JsonProperty("preview_webp")]
        public GetGifResponseImagesTypePreviewWebpType PreviewWebp { get; set; }

        [JsonProperty("480w_still")]
        public GetGifResponseImagesType_480wStillType _480wStill { get; set; }
    }

    public class GetGifResponseImagesTypeOriginalType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonProperty("mp4")]
        public string Mp4 { get; set; }

        [JsonProperty("webp_size")]
        public string WebpSize { get; set; }

        [JsonProperty("webp")]
        public string Webp { get; set; }

        [JsonProperty("frames")]
        public string Frames { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }

    public class GetGifResponseImagesTypeDownsizedType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseImagesTypeDownsizedLargeType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseImagesTypeDownsizedMediumType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseImagesTypeDownsizedSmallType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonProperty("mp4")]
        public string Mp4 { get; set; }
    }

    public class GetGifResponseImagesTypeDownsizedStillType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseImagesTypeFixedHeightType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonProperty("mp4")]
        public string Mp4 { get; set; }

        [JsonProperty("webp_size")]
        public string WebpSize { get; set; }

        [JsonProperty("webp")]
        public string Webp { get; set; }
    }

    public class GetGifResponseImagesTypeFixedHeightDownsampledType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("webp_size")]
        public string WebpSize { get; set; }

        [JsonProperty("webp")]
        public string Webp { get; set; }
    }

    public class GetGifResponseImagesTypeFixedHeightSmallType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonProperty("mp4")]
        public string Mp4 { get; set; }

        [JsonProperty("webp_size")]
        public string WebpSize { get; set; }

        [JsonProperty("webp")]
        public string Webp { get; set; }
    }

    public class GetGifResponseImagesTypeFixedHeightSmallStillType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseImagesTypeFixedHeightStillType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseImagesTypeFixedWidthType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonProperty("mp4")]
        public string Mp4 { get; set; }

        [JsonProperty("webp_size")]
        public string WebpSize { get; set; }

        [JsonProperty("webp")]
        public string Webp { get; set; }
    }

    public class GetGifResponseImagesTypeFixedWidthDownsampledType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("webp_size")]
        public string WebpSize { get; set; }

        [JsonProperty("webp")]
        public string Webp { get; set; }
    }

    public class GetGifResponseImagesTypeFixedWidthSmallType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonProperty("mp4")]
        public string Mp4 { get; set; }

        [JsonProperty("webp_size")]
        public string WebpSize { get; set; }

        [JsonProperty("webp")]
        public string Webp { get; set; }
    }

    public class GetGifResponseImagesTypeFixedWidthSmallStillType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseImagesTypeFixedWidthStillType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseImagesTypeLoopingType
    {
        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonProperty("mp4")]
        public string Mp4 { get; set; }
    }

    public class GetGifResponseImagesTypeOriginalStillType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseImagesTypeOriginalMp4Type
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonProperty("mp4")]
        public string Mp4 { get; set; }
    }

    public class GetGifResponseImagesTypePreviewType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonProperty("mp4")]
        public string Mp4 { get; set; }
    }

    public class GetGifResponseImagesTypePreviewGifType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseImagesTypePreviewWebpType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseImagesType_480wStillType
    {
        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseUserType
    {
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("banner_image")]
        public string BannerImage { get; set; }

        [JsonProperty("banner_url")]
        public string BannerUrl { get; set; }

        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }

        [JsonProperty("username")]
        public string UserName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("instagram_url")]
        public string InstagramUrl { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }
    }

    public class GetGifResponseAnalyticsType
    {
        [JsonProperty("onload")]
        public GetGifResponseAnalyticsTypeOnloadType Onload { get; set; }

        [JsonProperty("onclick")]
        public GetGifResponseAnalyticsTypeOnclickType Onclick { get; set; }

        [JsonProperty("onsent")]
        public GetGifResponseAnalyticsTypeOnsentType Onsent { get; set; }
    }

    public class GetGifResponseAnalyticsTypeOnloadType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseAnalyticsTypeOnclickType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGifResponseAnalyticsTypeOnsentType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Giphyip;

    public partial class WorkflowManagedActions
    {
        public GiphyipActions Giphyip(string connectionId) => new GiphyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GiphyipTriggers Giphyip(string connectionId) => new GiphyipTriggers(connectionId);
    }
}