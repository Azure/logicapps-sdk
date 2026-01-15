//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Giphyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GiphyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "giphyip")]
        public IBodyWorkflowAction<GetGIFResponse> GetGIF(Expression<Func<string>> aPIKEY, Expression<Func<string>> q, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> rating = null, Expression<Func<string>> lang = null)
        {
            var apiCallPath = "/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["API_KEY"] = ExpressionConverter.Convert(aPIKEY);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (rating != null)
                callPayload.Queries["rating"] = ExpressionConverter.Convert(rating);
            if (lang != null)
                callPayload.Queries["lang"] = ExpressionConverter.Convert(lang);
            return new ApiConnectionAction<GetGIFResponse>(callPayload);
        }
    }

    public class GiphyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetGIFResponse
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
        public string Username { get; set; }

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
        public GetGIFResponseImagesType Images { get; set; }

        [JsonProperty("user")]
        public GetGIFResponseUserType User { get; set; }

        [JsonProperty("analytics_response_payload")]
        public string AnalyticsResponsePayload { get; set; }

        [JsonProperty("analytics")]
        public GetGIFResponseAnalyticsType Analytics { get; set; }
    }

    public class GetGIFResponseImagesType
    {
        [JsonProperty("original")]
        public GetGIFResponseImagesTypeOriginalType Original { get; set; }

        [JsonProperty("downsized")]
        public GetGIFResponseImagesTypeDownsizedType Downsized { get; set; }

        [JsonProperty("downsized_large")]
        public GetGIFResponseImagesTypeDownsizedLargeType DownsizedLarge { get; set; }

        [JsonProperty("downsized_medium")]
        public GetGIFResponseImagesTypeDownsizedMediumType DownsizedMedium { get; set; }

        [JsonProperty("downsized_small")]
        public GetGIFResponseImagesTypeDownsizedSmallType DownsizedSmall { get; set; }

        [JsonProperty("downsized_still")]
        public GetGIFResponseImagesTypeDownsizedStillType DownsizedStill { get; set; }

        [JsonProperty("fixed_height")]
        public GetGIFResponseImagesTypeFixedHeightType FixedHeight { get; set; }

        [JsonProperty("fixed_height_downsampled")]
        public GetGIFResponseImagesTypeFixedHeightDownsampledType FixedHeightDownsampled { get; set; }

        [JsonProperty("fixed_height_small")]
        public GetGIFResponseImagesTypeFixedHeightSmallType FixedHeightSmall { get; set; }

        [JsonProperty("fixed_height_small_still")]
        public GetGIFResponseImagesTypeFixedHeightSmallStillType FixedHeightSmallStill { get; set; }

        [JsonProperty("fixed_height_still")]
        public GetGIFResponseImagesTypeFixedHeightStillType FixedHeightStill { get; set; }

        [JsonProperty("fixed_width")]
        public GetGIFResponseImagesTypeFixedWidthType FixedWidth { get; set; }

        [JsonProperty("fixed_width_downsampled")]
        public GetGIFResponseImagesTypeFixedWidthDownsampledType FixedWidthDownsampled { get; set; }

        [JsonProperty("fixed_width_small")]
        public GetGIFResponseImagesTypeFixedWidthSmallType FixedWidthSmall { get; set; }

        [JsonProperty("fixed_width_small_still")]
        public GetGIFResponseImagesTypeFixedWidthSmallStillType FixedWidthSmallStill { get; set; }

        [JsonProperty("fixed_width_still")]
        public GetGIFResponseImagesTypeFixedWidthStillType FixedWidthStill { get; set; }

        [JsonProperty("looping")]
        public GetGIFResponseImagesTypeLoopingType Looping { get; set; }

        [JsonProperty("original_still")]
        public GetGIFResponseImagesTypeOriginalStillType OriginalStill { get; set; }

        [JsonProperty("original_mp4")]
        public GetGIFResponseImagesTypeOriginalMp4Type OriginalMp4 { get; set; }

        [JsonProperty("preview")]
        public GetGIFResponseImagesTypePreviewType Preview { get; set; }

        [JsonProperty("preview_gif")]
        public GetGIFResponseImagesTypePreviewGifType PreviewGif { get; set; }

        [JsonProperty("preview_webp")]
        public GetGIFResponseImagesTypePreviewWebpType PreviewWebp { get; set; }

        [JsonProperty("480w_still")]
        public GetGIFResponseImagesType_480wStillType _480wStill { get; set; }
    }

    public class GetGIFResponseImagesTypeOriginalType
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

    public class GetGIFResponseImagesTypeDownsizedType
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

    public class GetGIFResponseImagesTypeDownsizedLargeType
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

    public class GetGIFResponseImagesTypeDownsizedMediumType
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

    public class GetGIFResponseImagesTypeDownsizedSmallType
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

    public class GetGIFResponseImagesTypeDownsizedStillType
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

    public class GetGIFResponseImagesTypeFixedHeightType
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

    public class GetGIFResponseImagesTypeFixedHeightDownsampledType
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

    public class GetGIFResponseImagesTypeFixedHeightSmallType
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

    public class GetGIFResponseImagesTypeFixedHeightSmallStillType
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

    public class GetGIFResponseImagesTypeFixedHeightStillType
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

    public class GetGIFResponseImagesTypeFixedWidthType
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

    public class GetGIFResponseImagesTypeFixedWidthDownsampledType
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

    public class GetGIFResponseImagesTypeFixedWidthSmallType
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

    public class GetGIFResponseImagesTypeFixedWidthSmallStillType
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

    public class GetGIFResponseImagesTypeFixedWidthStillType
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

    public class GetGIFResponseImagesTypeLoopingType
    {
        [JsonProperty("mp4_size")]
        public string Mp4Size { get; set; }

        [JsonProperty("mp4")]
        public string Mp4 { get; set; }
    }

    public class GetGIFResponseImagesTypeOriginalStillType
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

    public class GetGIFResponseImagesTypeOriginalMp4Type
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

    public class GetGIFResponseImagesTypePreviewType
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

    public class GetGIFResponseImagesTypePreviewGifType
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

    public class GetGIFResponseImagesTypePreviewWebpType
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

    public class GetGIFResponseImagesType_480wStillType
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

    public class GetGIFResponseUserType
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
        public string Username { get; set; }

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

    public class GetGIFResponseAnalyticsType
    {
        [JsonProperty("onload")]
        public GetGIFResponseAnalyticsTypeOnloadType Onload { get; set; }

        [JsonProperty("onclick")]
        public GetGIFResponseAnalyticsTypeOnclickType Onclick { get; set; }

        [JsonProperty("onsent")]
        public GetGIFResponseAnalyticsTypeOnsentType Onsent { get; set; }
    }

    public class GetGIFResponseAnalyticsTypeOnloadType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGIFResponseAnalyticsTypeOnclickType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetGIFResponseAnalyticsTypeOnsentType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Giphyip;

    public partial class WorkflowManagedActions
    {
        public GiphyipActions Giphyip(string connectionId) => new GiphyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GiphyipTriggers Giphyip(string connectionId) => new GiphyipTriggers(connectionId);
    }
}