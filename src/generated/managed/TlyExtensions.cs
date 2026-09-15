//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tly
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TlyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<PixelsGetResponseItem[]> PixelsGet()
        {
            var apiCallPath = "/api/v1/link/pixel";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PixelsGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<PixelPostResponse> Pixel(Expression<Func<string>> bodyname, Expression<Func<string>> bodypixelId, Expression<Func<string>> bodypixelType)
        {
            var apiCallPath = "/api/v1/link/pixel";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            bodypropCount++;
            body["pixel_id"] = CSharpExpressionConverter.ConvertToken(bodypixelId);
            bodypropCount++;
            body["pixel_type"] = CSharpExpressionConverter.ConvertToken(bodypixelType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PixelPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<PixelGetResponse> PixelGet(Expression<Func<string>> pixelId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/link/pixel/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(pixelId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PixelGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<string> PixelDelete(Expression<Func<string>> pixelId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/link/pixel/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(pixelId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<PixelPutResponse> PixelPut(Expression<Func<string>> pixelId, Expression<Func<int>> bodyid = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypixelId = null, Expression<Func<string>> bodypixelType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/link/pixel/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(pixelId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = CSharpExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodypixelId != null)
            {
                body["pixel_id"] = CSharpExpressionConverter.ConvertToken(bodypixelId);
                bodypropCount++;
            }

            if (bodypixelType != null)
            {
                body["pixel_type"] = CSharpExpressionConverter.ConvertToken(bodypixelType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PixelPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinkPostResponse> Link(Expression<Func<string>> bodylongUrl, Expression<Func<string>> bodydomain = null, Expression<Func<string>> bodyexpireAtDatetime = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodypublicStats = null, Expression<Func<bodymetasmartUrlsInputItem[]>> bodymetasmartUrls = null)
        {
            var apiCallPath = "/api/v1/link/shorten";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["long_url"] = CSharpExpressionConverter.ConvertToken(bodylongUrl);
            if (bodydomain != null)
            {
                body["domain"] = CSharpExpressionConverter.ConvertToken(bodydomain);
                bodypropCount++;
            }

            if (bodyexpireAtDatetime != null)
            {
                body["expire_at_datetime"] = CSharpExpressionConverter.ConvertToken(bodyexpireAtDatetime);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodypublicStats != null)
            {
                body["public_stats"] = CSharpExpressionConverter.ConvertToken(bodypublicStats);
                bodypropCount++;
            }

            var metaObject = new JObject();
            var metaObjectpropCount = 0;
            if (bodymetasmartUrls != null)
            {
                metaObject["smart_urls"] = CSharpExpressionConverter.ConvertToken(bodymetasmartUrls);
                metaObjectpropCount++;
            }

            if (metaObjectpropCount > 0)
            {
                body["meta"] = metaObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<LinkPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinkGetResponse> LinkGet(Expression<Func<string>> shortUrl = null)
        {
            var apiCallPath = "/api/v1/link";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (shortUrl != null)
                callPayload.Queries["short_url"] = CSharpExpressionConverter.ConvertO(shortUrl);
            return new ApiConnectionAction<LinkGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<string> LinkDelete(Expression<Func<string>> bodyshortUrl = null)
        {
            var apiCallPath = "/api/v1/link";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyshortUrl != null)
            {
                body["short_url"] = CSharpExpressionConverter.ConvertToken(bodyshortUrl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinkPutResponse> LinkPut(Expression<Func<string>> bodyshortUrl = null, Expression<Func<string>> bodylongUrl = null, Expression<Func<string>> bodydomain = null, Expression<Func<string>> bodyshortId = null, Expression<Func<string>> bodyexpireAtViews = null, Expression<Func<string>> bodyexpireAtDatetime = null, Expression<Func<bool>> bodypublicStats = null, Expression<Func<string>> bodyqrCodeUrl = null, Expression<Func<string>> bodyqrCodeBase64 = null, Expression<Func<int[]>> bodytags = null, Expression<Func<int[]>> bodypixels = null)
        {
            var apiCallPath = "/api/v1/link";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyshortUrl != null)
            {
                body["short_url"] = CSharpExpressionConverter.ConvertToken(bodyshortUrl);
                bodypropCount++;
            }

            if (bodylongUrl != null)
            {
                body["long_url"] = CSharpExpressionConverter.ConvertToken(bodylongUrl);
                bodypropCount++;
            }

            if (bodydomain != null)
            {
                body["domain"] = CSharpExpressionConverter.ConvertToken(bodydomain);
                bodypropCount++;
            }

            if (bodyshortId != null)
            {
                body["short_id"] = CSharpExpressionConverter.ConvertToken(bodyshortId);
                bodypropCount++;
            }

            if (bodyexpireAtViews != null)
            {
                body["expire_at_views"] = CSharpExpressionConverter.ConvertToken(bodyexpireAtViews);
                bodypropCount++;
            }

            if (bodyexpireAtDatetime != null)
            {
                body["expire_at_datetime"] = CSharpExpressionConverter.ConvertToken(bodyexpireAtDatetime);
                bodypropCount++;
            }

            if (bodypublicStats != null)
            {
                body["public_stats"] = CSharpExpressionConverter.ConvertToken(bodypublicStats);
                bodypropCount++;
            }

            if (bodyqrCodeUrl != null)
            {
                body["qr_code_url"] = CSharpExpressionConverter.ConvertToken(bodyqrCodeUrl);
                bodypropCount++;
            }

            if (bodyqrCodeBase64 != null)
            {
                body["qr_code_base64"] = CSharpExpressionConverter.ConvertToken(bodyqrCodeBase64);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = CSharpExpressionConverter.ConvertToken(bodytags);
                bodypropCount++;
            }

            if (bodypixels != null)
            {
                body["pixels"] = CSharpExpressionConverter.ConvertToken(bodypixels);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<LinkPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinkExpandPostResponse> LinkExpand(Expression<Func<string>> bodyshortUrl = null, Expression<Func<string>> bodypassword = null)
        {
            var apiCallPath = "/api/v1/link/expand";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyshortUrl != null)
            {
                body["short_url"] = CSharpExpressionConverter.ConvertToken(bodyshortUrl);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = CSharpExpressionConverter.ConvertToken(bodypassword);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<LinkExpandPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinksGetResponse> LinksGet(Expression<Func<string>> search = null, Expression<Func<string>> tagIds = null, Expression<Func<string>> pixelIds = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> domains = null)
        {
            var apiCallPath = "/api/v1/link/list";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (tagIds != null)
                callPayload.Queries["tag_ids"] = CSharpExpressionConverter.ConvertO(tagIds);
            if (pixelIds != null)
                callPayload.Queries["pixel_ids"] = CSharpExpressionConverter.ConvertO(pixelIds);
            if (startDate != null)
                callPayload.Queries["start_date"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["end_date"] = CSharpExpressionConverter.ConvertO(endDate);
            if (domains != null)
                callPayload.Queries["domains"] = CSharpExpressionConverter.ConvertO(domains);
            return new ApiConnectionAction<LinksGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<string> LinkBulk(Expression<Func<string>> bodydomain = null, Expression<Func<bodylinksInputItem[]>> bodylinks = null, Expression<Func<int[]>> bodytags = null, Expression<Func<int[]>> bodypixels = null)
        {
            var apiCallPath = "/api/v1/link/bulk";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydomain != null)
            {
                body["domain"] = CSharpExpressionConverter.ConvertToken(bodydomain);
                bodypropCount++;
            }

            if (bodylinks != null)
            {
                body["links"] = CSharpExpressionConverter.ConvertToken(bodylinks);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = CSharpExpressionConverter.ConvertToken(bodytags);
                bodypropCount++;
            }

            if (bodypixels != null)
            {
                body["pixels"] = CSharpExpressionConverter.ConvertToken(bodypixels);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<StatGetResponse> StatGet(Expression<Func<string>> shortLink)
        {
            var apiCallPath = "/api/v1/link/stats";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["short_link"] = CSharpExpressionConverter.ConvertO(shortLink);
            return new ApiConnectionAction<StatGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<TagsGetResponseItem[]> TagsGet()
        {
            var apiCallPath = "/api/v1/link/tag";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TagsGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<TagPostResponse> Tag(Expression<Func<string>> bodytag)
        {
            var apiCallPath = "/api/v1/link/tag";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["tag"] = CSharpExpressionConverter.ConvertToken(bodytag);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TagPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<TagGetResponse> TagGet(Expression<Func<string>> tagId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/link/tag/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TagGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<string> TagDelete(Expression<Func<string>> tagId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/link/tag/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<TagPutResponse> TagPut(Expression<Func<string>> tagId, Expression<Func<string>> bodytag)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/v1/link/tag/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["tag"] = CSharpExpressionConverter.ConvertToken(bodytag);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TagPutResponse>(callPayload);
        }
    }

    public class TlyTriggers([ConnectionName] string connectionId)
    {
    }

    public class PixelsGetResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pixel_id")]
        public string PixelId { get; set; }

        [JsonProperty("pixel_type")]
        public string PixelType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class PixelPostResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pixel_id")]
        public string PixelId { get; set; }

        [JsonProperty("pixel_type")]
        public string PixelType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class PixelGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pixel_id")]
        public string PixelId { get; set; }

        [JsonProperty("pixel_type")]
        public string PixelType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class PixelPutResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pixel_id")]
        public string PixelId { get; set; }

        [JsonProperty("pixel_type")]
        public string PixelType { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class LinkPostResponse
    {
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("long_url")]
        public string LongUrl { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("short_id")]
        public string ShortId { get; set; }

        [JsonProperty("expire_at_views")]
        public string ExpireAtViews { get; set; }

        [JsonProperty("expire_at_datetime")]
        public string ExpireAtDatetime { get; set; }

        [JsonProperty("public_stats")]
        public bool PublicStats { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("meta")]
        public LinkPostResponseMetaType Meta { get; set; }
    }

    public class LinkPostResponseMetaType
    {
        [JsonProperty("smart_urls")]
        public LinkPostResponseMetaTypeSmartUrlsTypeItem[] SmartUrls { get; set; }
    }

    public class LinkPostResponseMetaTypeSmartUrlsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class bodymetasmartUrlsInputItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class LinkGetResponse
    {
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("long_url")]
        public string LongUrl { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("short_id")]
        public string ShortId { get; set; }

        [JsonProperty("expire_at_views")]
        public string ExpireAtViews { get; set; }

        [JsonProperty("expire_at_datetime")]
        public string ExpireAtDatetime { get; set; }

        [JsonProperty("public_stats")]
        public bool PublicStats { get; set; }

        [JsonProperty("qr_code_url")]
        public string QrCodeUrl { get; set; }

        [JsonProperty("qr_code_base64")]
        public string QrCodeBase64 { get; set; }

        [JsonProperty("tags")]
        public int[] Tags { get; set; }

        [JsonProperty("pixels")]
        public int[] Pixels { get; set; }
    }

    public class LinkPutResponse
    {
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("long_url")]
        public string LongUrl { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("short_id")]
        public string ShortId { get; set; }

        [JsonProperty("expire_at_views")]
        public string ExpireAtViews { get; set; }

        [JsonProperty("expire_at_datetime")]
        public string ExpireAtDatetime { get; set; }

        [JsonProperty("public_stats")]
        public bool PublicStats { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("meta")]
        public LinkPutResponseMetaType Meta { get; set; }
    }

    public class LinkPutResponseMetaType
    {
        [JsonProperty("smart_urls")]
        public LinkPutResponseMetaTypeSmartUrlsTypeItem[] SmartUrls { get; set; }
    }

    public class LinkPutResponseMetaTypeSmartUrlsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class LinkExpandPostResponse
    {
        [JsonProperty("long_url")]
        public string LongUrl { get; set; }

        [JsonProperty("expired")]
        public bool Expired { get; set; }
    }

    public class LinksGetResponse
    {
        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("data")]
        public LinksGetResponseDataTypeItem[] Data { get; set; }
    }

    public class LinksGetResponseDataTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("long_url")]
        public string LongUrl { get; set; }

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("short_id")]
        public string ShortId { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("team_id")]
        public int TeamId { get; set; }

        [JsonProperty("domain_id")]
        public string DomainId { get; set; }

        [JsonProperty("expire_at_datetime")]
        public string ExpireAtDatetime { get; set; }

        [JsonProperty("expire_at_views")]
        public string ExpireAtViews { get; set; }

        [JsonProperty("public_stats")]
        public bool PublicStats { get; set; }

        [JsonProperty("meta")]
        public LinksGetResponseDataTypeItemMetaType Meta { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("has_password")]
        public bool HasPassword { get; set; }

        [JsonProperty("user")]
        public LinksGetResponseDataTypeItemUserType User { get; set; }

        [JsonProperty("qr_code")]
        public string QrCode { get; set; }

        [JsonProperty("tags")]
        public int[] Tags { get; set; }

        [JsonProperty("pixels")]
        public int[] Pixels { get; set; }
    }

    public class LinksGetResponseDataTypeItemMetaType
    {
        [JsonProperty("smart_urls")]
        public string[] SmartUrls { get; set; }
    }

    public class LinksGetResponseDataTypeItemUserType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class bodylinksInputItem
    {
        public string LongUrl { get; set; }
        public string Backhalf { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
    }

    public class StatGetResponse
    {
        [JsonProperty("clicks")]
        public int Clicks { get; set; }

        [JsonProperty("unique_clicks")]
        public int UniqueClicks { get; set; }

        [JsonProperty("browsers")]
        public string[] Browsers { get; set; }

        [JsonProperty("countries")]
        public string[] Countries { get; set; }

        [JsonProperty("referrers")]
        public string[] Referrers { get; set; }

        [JsonProperty("platforms")]
        public string[] Platforms { get; set; }

        [JsonProperty("daily_clicks")]
        public string[] DailyClicks { get; set; }

        [JsonProperty("data")]
        public StatGetResponseDataType Data { get; set; }
    }

    public class StatGetResponseDataType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("long_url")]
        public string LongUrl { get; set; }

        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class TagsGetResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class TagPostResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class TagGetResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class TagPutResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tly;

    public partial class WorkflowManagedActions
    {
        public TlyActions Tly(string connectionId) => new TlyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TlyTriggers Tly(string connectionId) => new TlyTriggers(connectionId);
    }
}