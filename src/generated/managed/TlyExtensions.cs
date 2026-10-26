//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tly
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TlyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<PixelsGetResponseItem[], ApiConnectionActionConfiguration> PixelsGet()
        {
            return new DeferredBodyAction<PixelsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/link/pixel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PixelsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<PixelPostResponse, ApiConnectionActionConfiguration> Pixel(Expression<Func<string>> bodyname, Expression<Func<string>> bodypixelId, Expression<Func<string>> bodypixelType)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodypixelId = WorkflowExpression.Compile(bodypixelId, nameof(bodypixelId), required: true);
            var __workflow_bodypixelType = WorkflowExpression.Compile(bodypixelType, nameof(bodypixelType), required: true);
            return new DeferredBodyAction<PixelPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/link/pixel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["pixel_id"] = ExpressionConverter.ConvertO(__workflow_bodypixelId);
                bodypropCount++;
                body["pixel_type"] = ExpressionConverter.ConvertO(__workflow_bodypixelType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PixelPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<PixelGetResponse, ApiConnectionActionConfiguration> PixelGet(Expression<Func<string>> pixelId)
        {
            var __workflow_pixelId = WorkflowExpression.Compile(pixelId, nameof(pixelId), required: true);
            return new DeferredBodyAction<PixelGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/link/pixel/{0}", __workflow_pixelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PixelGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PixelDelete(Expression<Func<string>> pixelId)
        {
            var __workflow_pixelId = WorkflowExpression.Compile(pixelId, nameof(pixelId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/link/pixel/{0}", __workflow_pixelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<PixelPutResponse, ApiConnectionActionConfiguration> PixelPut(Expression<Func<string>> pixelId, Expression<Func<int>> bodyid = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodypixelId = null, Expression<Func<string>> bodypixelType = null)
        {
            var __workflow_pixelId = WorkflowExpression.Compile(pixelId, nameof(pixelId), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodypixelId = WorkflowExpression.Compile(bodypixelId, nameof(bodypixelId), required: false);
            var __workflow_bodypixelType = WorkflowExpression.Compile(bodypixelType, nameof(bodypixelType), required: false);
            return new DeferredBodyAction<PixelPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/link/pixel/{0}", __workflow_pixelId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodypixelId != null)
                {
                    body["pixel_id"] = ExpressionConverter.ConvertO(__workflow_bodypixelId);
                    bodypropCount++;
                }

                if (__workflow_bodypixelType != null)
                {
                    body["pixel_type"] = ExpressionConverter.ConvertO(__workflow_bodypixelType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PixelPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinkPostResponse, ApiConnectionActionConfiguration> Link(Expression<Func<string>> bodylongUrl, Expression<Func<string>> bodydomain = null, Expression<Func<string>> bodyexpireAtDatetime = null, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodypublicStats = null, Expression<Func<bodymetasmartUrlsInputItem[]>> bodymetasmartUrls = null)
        {
            var __workflow_bodylongUrl = WorkflowExpression.Compile(bodylongUrl, nameof(bodylongUrl), required: true);
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: false);
            var __workflow_bodyexpireAtDatetime = WorkflowExpression.Compile(bodyexpireAtDatetime, nameof(bodyexpireAtDatetime), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodypublicStats = WorkflowExpression.Compile(bodypublicStats, nameof(bodypublicStats), required: false);
            var __workflow_bodymetasmartUrls = WorkflowExpression.Compile(bodymetasmartUrls, nameof(bodymetasmartUrls), required: false);
            return new DeferredBodyAction<LinkPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/link/shorten";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["long_url"] = ExpressionConverter.ConvertO(__workflow_bodylongUrl);
                if (__workflow_bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                    bodypropCount++;
                }

                if (__workflow_bodyexpireAtDatetime != null)
                {
                    body["expire_at_datetime"] = ExpressionConverter.ConvertO(__workflow_bodyexpireAtDatetime);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodypublicStats != null)
                {
                    body["public_stats"] = ExpressionConverter.ConvertO(__workflow_bodypublicStats);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (__workflow_bodymetasmartUrls != null)
                {
                    metaObject["smart_urls"] = ExpressionConverter.ConvertO(__workflow_bodymetasmartUrls);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinkGetResponse, ApiConnectionActionConfiguration> LinkGet(Expression<Func<string>> shortUrl = null)
        {
            var __workflow_shortUrl = WorkflowExpression.Compile(shortUrl, nameof(shortUrl), required: false);
            return new DeferredBodyAction<LinkGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/link";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_shortUrl != null)
                    callPayload.Queries["short_url"] = ExpressionConverter.Convert(__workflow_shortUrl);
                return new ApiConnectionAction<LinkGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> LinkDelete(Expression<Func<string>> bodyshortUrl = null)
        {
            var __workflow_bodyshortUrl = WorkflowExpression.Compile(bodyshortUrl, nameof(bodyshortUrl), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/link";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyshortUrl != null)
                {
                    body["short_url"] = ExpressionConverter.ConvertO(__workflow_bodyshortUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinkPutResponse, ApiConnectionActionConfiguration> LinkPut(Expression<Func<string>> bodyshortUrl = null, Expression<Func<string>> bodylongUrl = null, Expression<Func<string>> bodydomain = null, Expression<Func<string>> bodyshortId = null, Expression<Func<string>> bodyexpireAtViews = null, Expression<Func<string>> bodyexpireAtDatetime = null, Expression<Func<bool>> bodypublicStats = null, Expression<Func<string>> bodyqrCodeUrl = null, Expression<Func<string>> bodyqrCodeBase64 = null, Expression<Func<int[]>> bodytags = null, Expression<Func<int[]>> bodypixels = null)
        {
            var __workflow_bodyshortUrl = WorkflowExpression.Compile(bodyshortUrl, nameof(bodyshortUrl), required: false);
            var __workflow_bodylongUrl = WorkflowExpression.Compile(bodylongUrl, nameof(bodylongUrl), required: false);
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: false);
            var __workflow_bodyshortId = WorkflowExpression.Compile(bodyshortId, nameof(bodyshortId), required: false);
            var __workflow_bodyexpireAtViews = WorkflowExpression.Compile(bodyexpireAtViews, nameof(bodyexpireAtViews), required: false);
            var __workflow_bodyexpireAtDatetime = WorkflowExpression.Compile(bodyexpireAtDatetime, nameof(bodyexpireAtDatetime), required: false);
            var __workflow_bodypublicStats = WorkflowExpression.Compile(bodypublicStats, nameof(bodypublicStats), required: false);
            var __workflow_bodyqrCodeUrl = WorkflowExpression.Compile(bodyqrCodeUrl, nameof(bodyqrCodeUrl), required: false);
            var __workflow_bodyqrCodeBase64 = WorkflowExpression.Compile(bodyqrCodeBase64, nameof(bodyqrCodeBase64), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodypixels = WorkflowExpression.Compile(bodypixels, nameof(bodypixels), required: false);
            return new DeferredBodyAction<LinkPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/link";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyshortUrl != null)
                {
                    body["short_url"] = ExpressionConverter.ConvertO(__workflow_bodyshortUrl);
                    bodypropCount++;
                }

                if (__workflow_bodylongUrl != null)
                {
                    body["long_url"] = ExpressionConverter.ConvertO(__workflow_bodylongUrl);
                    bodypropCount++;
                }

                if (__workflow_bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                    bodypropCount++;
                }

                if (__workflow_bodyshortId != null)
                {
                    body["short_id"] = ExpressionConverter.ConvertO(__workflow_bodyshortId);
                    bodypropCount++;
                }

                if (__workflow_bodyexpireAtViews != null)
                {
                    body["expire_at_views"] = ExpressionConverter.ConvertO(__workflow_bodyexpireAtViews);
                    bodypropCount++;
                }

                if (__workflow_bodyexpireAtDatetime != null)
                {
                    body["expire_at_datetime"] = ExpressionConverter.ConvertO(__workflow_bodyexpireAtDatetime);
                    bodypropCount++;
                }

                if (__workflow_bodypublicStats != null)
                {
                    body["public_stats"] = ExpressionConverter.ConvertO(__workflow_bodypublicStats);
                    bodypropCount++;
                }

                if (__workflow_bodyqrCodeUrl != null)
                {
                    body["qr_code_url"] = ExpressionConverter.ConvertO(__workflow_bodyqrCodeUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyqrCodeBase64 != null)
                {
                    body["qr_code_base64"] = ExpressionConverter.ConvertO(__workflow_bodyqrCodeBase64);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodypixels != null)
                {
                    body["pixels"] = ExpressionConverter.ConvertO(__workflow_bodypixels);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LinkPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinkExpandPostResponse, ApiConnectionActionConfiguration> LinkExpand(Expression<Func<string>> bodyshortUrl = null, Expression<Func<string>> bodypassword = null)
        {
            var __workflow_bodyshortUrl = WorkflowExpression.Compile(bodyshortUrl, nameof(bodyshortUrl), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            return new DeferredBodyAction<LinkExpandPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/link/expand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyshortUrl != null)
                {
                    body["short_url"] = ExpressionConverter.ConvertO(__workflow_bodyshortUrl);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LinkExpandPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinksGetResponse, ApiConnectionActionConfiguration> LinksGet(Expression<Func<string>> search = null, Expression<Func<string>> tagIds = null, Expression<Func<string>> pixelIds = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null, Expression<Func<string>> domains = null)
        {
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_tagIds = WorkflowExpression.Compile(tagIds, nameof(tagIds), required: false);
            var __workflow_pixelIds = WorkflowExpression.Compile(pixelIds, nameof(pixelIds), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            var __workflow_domains = WorkflowExpression.Compile(domains, nameof(domains), required: false);
            return new DeferredBodyAction<LinksGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/link/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_tagIds != null)
                    callPayload.Queries["tag_ids"] = ExpressionConverter.Convert(__workflow_tagIds);
                if (__workflow_pixelIds != null)
                    callPayload.Queries["pixel_ids"] = ExpressionConverter.Convert(__workflow_pixelIds);
                if (__workflow_startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(__workflow_endDate);
                if (__workflow_domains != null)
                    callPayload.Queries["domains"] = ExpressionConverter.Convert(__workflow_domains);
                return new ApiConnectionAction<LinksGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> LinkBulk(Expression<Func<string>> bodydomain = null, Expression<Func<bodylinksInputItem[]>> bodylinks = null, Expression<Func<int[]>> bodytags = null, Expression<Func<int[]>> bodypixels = null)
        {
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: false);
            var __workflow_bodylinks = WorkflowExpression.Compile(bodylinks, nameof(bodylinks), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodypixels = WorkflowExpression.Compile(bodypixels, nameof(bodypixels), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/link/bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                    bodypropCount++;
                }

                if (__workflow_bodylinks != null)
                {
                    body["links"] = ExpressionConverter.ConvertO(__workflow_bodylinks);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodypixels != null)
                {
                    body["pixels"] = ExpressionConverter.ConvertO(__workflow_bodypixels);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<StatGetResponse, ApiConnectionActionConfiguration> StatGet(Expression<Func<string>> shortLink)
        {
            var __workflow_shortLink = WorkflowExpression.Compile(shortLink, nameof(shortLink), required: true);
            return new DeferredBodyAction<StatGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/link/stats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["short_link"] = ExpressionConverter.Convert(__workflow_shortLink);
                return new ApiConnectionAction<StatGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<TagsGetResponseItem[], ApiConnectionActionConfiguration> TagsGet()
        {
            return new DeferredBodyAction<TagsGetResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/link/tag";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<TagPostResponse, ApiConnectionActionConfiguration> Tag(Expression<Func<string>> bodytag)
        {
            var __workflow_bodytag = WorkflowExpression.Compile(bodytag, nameof(bodytag), required: true);
            return new DeferredBodyAction<TagPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/link/tag";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tag"] = ExpressionConverter.ConvertO(__workflow_bodytag);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TagPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<TagGetResponse, ApiConnectionActionConfiguration> TagGet(Expression<Func<string>> tagId)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<TagGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/link/tag/{0}", __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> TagDelete(Expression<Func<string>> tagId)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/link/tag/{0}", __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<TagPutResponse, ApiConnectionActionConfiguration> TagPut(Expression<Func<string>> tagId, Expression<Func<string>> bodytag)
        {
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            var __workflow_bodytag = WorkflowExpression.Compile(bodytag, nameof(bodytag), required: true);
            return new DeferredBodyAction<TagPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/link/tag/{0}", __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tag"] = ExpressionConverter.ConvertO(__workflow_bodytag);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TagPutResponse>(callPayload);
            });
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