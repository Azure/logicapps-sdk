//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tly
{
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
        [WorkflowExpressionFactory(nameof(__BuildPixel))]
        public IBodyWorkflowAction<PixelPostResponse> Pixel([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypixelId, [WorkflowExpression] Func<string> bodypixelType)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PixelPostResponse> __BuildPixel(WorkflowValue<string> bodyname, WorkflowValue<string> bodypixelId, WorkflowValue<string> bodypixelType)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodypixelId, nameof(bodypixelId), required: true);
            WorkflowValue.Validate(bodypixelType, nameof(bodypixelType), required: true);
            return new DeferredBodyAction<PixelPostResponse>(() =>
            {
                var apiCallPath = "/api/v1/link/pixel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["pixel_id"] = ExpressionConverter.ConvertO(bodypixelId);
                bodypropCount++;
                body["pixel_type"] = ExpressionConverter.ConvertO(bodypixelType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PixelPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        [WorkflowExpressionFactory(nameof(__BuildPixelGet))]
        public IBodyWorkflowAction<PixelGetResponse> PixelGet([WorkflowExpression] Func<string> pixelId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PixelGetResponse> __BuildPixelGet(WorkflowValue<string> pixelId)
        {
            WorkflowValue.Validate(pixelId, nameof(pixelId), required: true);
            return new DeferredBodyAction<PixelGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/link/pixel/{0}", ExpressionConverter.ConvertWithUrlEncoding(pixelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PixelGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        [WorkflowExpressionFactory(nameof(__BuildPixelDelete))]
        public IBodyWorkflowAction<string> PixelDelete([WorkflowExpression] Func<string> pixelId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildPixelDelete(WorkflowValue<string> pixelId)
        {
            WorkflowValue.Validate(pixelId, nameof(pixelId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/link/pixel/{0}", ExpressionConverter.ConvertWithUrlEncoding(pixelId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        [WorkflowExpressionFactory(nameof(__BuildPixelPut))]
        public IBodyWorkflowAction<PixelPutResponse> PixelPut([WorkflowExpression] Func<string> pixelId, [WorkflowExpression] Func<int> bodyid = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodypixelId = null, [WorkflowExpression] Func<string> bodypixelType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PixelPutResponse> __BuildPixelPut(WorkflowValue<string> pixelId, WorkflowValue<int> bodyid = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodypixelId = null, WorkflowValue<string> bodypixelType = null)
        {
            WorkflowValue.Validate(pixelId, nameof(pixelId), required: true);
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodypixelId, nameof(bodypixelId), required: false);
            WorkflowValue.Validate(bodypixelType, nameof(bodypixelType), required: false);
            return new DeferredBodyAction<PixelPutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/link/pixel/{0}", ExpressionConverter.ConvertWithUrlEncoding(pixelId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodypixelId != null)
                {
                    body["pixel_id"] = ExpressionConverter.ConvertO(bodypixelId);
                    bodypropCount++;
                }

                if (bodypixelType != null)
                {
                    body["pixel_type"] = ExpressionConverter.ConvertO(bodypixelType);
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
        [WorkflowExpressionFactory(nameof(__BuildLink))]
        public IBodyWorkflowAction<LinkPostResponse> Link([WorkflowExpression] Func<string> bodylongUrl, [WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<string> bodyexpireAtDatetime = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodypublicStats = null, [WorkflowExpression] Func<bodymetasmartUrlsInputItem[]> bodymetasmartUrls = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinkPostResponse> __BuildLink(WorkflowValue<string> bodylongUrl, WorkflowValue<string> bodydomain = null, WorkflowValue<string> bodyexpireAtDatetime = null, WorkflowValue<string> bodydescription = null, WorkflowValue<bool> bodypublicStats = null, WorkflowValue<bodymetasmartUrlsInputItem[]> bodymetasmartUrls = null)
        {
            WorkflowValue.Validate(bodylongUrl, nameof(bodylongUrl), required: true);
            WorkflowValue.Validate(bodydomain, nameof(bodydomain), required: false);
            WorkflowValue.Validate(bodyexpireAtDatetime, nameof(bodyexpireAtDatetime), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodypublicStats, nameof(bodypublicStats), required: false);
            WorkflowValue.Validate(bodymetasmartUrls, nameof(bodymetasmartUrls), required: false);
            return new DeferredBodyAction<LinkPostResponse>(() =>
            {
                var apiCallPath = "/api/v1/link/shorten";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["long_url"] = ExpressionConverter.ConvertO(bodylongUrl);
                if (bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(bodydomain);
                    bodypropCount++;
                }

                if (bodyexpireAtDatetime != null)
                {
                    body["expire_at_datetime"] = ExpressionConverter.ConvertO(bodyexpireAtDatetime);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodypublicStats != null)
                {
                    body["public_stats"] = ExpressionConverter.ConvertO(bodypublicStats);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetasmartUrls != null)
                {
                    metaObject["smart_urls"] = ExpressionConverter.ConvertO(bodymetasmartUrls);
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
        [WorkflowExpressionFactory(nameof(__BuildLinkGet))]
        public IBodyWorkflowAction<LinkGetResponse> LinkGet([WorkflowExpression] Func<string> shortUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinkGetResponse> __BuildLinkGet(WorkflowValue<string> shortUrl = null)
        {
            WorkflowValue.Validate(shortUrl, nameof(shortUrl), required: false);
            return new DeferredBodyAction<LinkGetResponse>(() =>
            {
                var apiCallPath = "/api/v1/link";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (shortUrl != null)
                    callPayload.Queries["short_url"] = ExpressionConverter.Convert(shortUrl);
                return new ApiConnectionAction<LinkGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        [WorkflowExpressionFactory(nameof(__BuildLinkDelete))]
        public IBodyWorkflowAction<string> LinkDelete([WorkflowExpression] Func<string> bodyshortUrl = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildLinkDelete(WorkflowValue<string> bodyshortUrl = null)
        {
            WorkflowValue.Validate(bodyshortUrl, nameof(bodyshortUrl), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/v1/link";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyshortUrl != null)
                {
                    body["short_url"] = ExpressionConverter.ConvertO(bodyshortUrl);
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
        [WorkflowExpressionFactory(nameof(__BuildLinkPut))]
        public IBodyWorkflowAction<LinkPutResponse> LinkPut([WorkflowExpression] Func<string> bodyshortUrl = null, [WorkflowExpression] Func<string> bodylongUrl = null, [WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<string> bodyshortId = null, [WorkflowExpression] Func<string> bodyexpireAtViews = null, [WorkflowExpression] Func<string> bodyexpireAtDatetime = null, [WorkflowExpression] Func<bool> bodypublicStats = null, [WorkflowExpression] Func<string> bodyqrCodeUrl = null, [WorkflowExpression] Func<string> bodyqrCodeBase64 = null, [WorkflowExpression] Func<int[]> bodytags = null, [WorkflowExpression] Func<int[]> bodypixels = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinkPutResponse> __BuildLinkPut(WorkflowValue<string> bodyshortUrl = null, WorkflowValue<string> bodylongUrl = null, WorkflowValue<string> bodydomain = null, WorkflowValue<string> bodyshortId = null, WorkflowValue<string> bodyexpireAtViews = null, WorkflowValue<string> bodyexpireAtDatetime = null, WorkflowValue<bool> bodypublicStats = null, WorkflowValue<string> bodyqrCodeUrl = null, WorkflowValue<string> bodyqrCodeBase64 = null, WorkflowValue<int[]> bodytags = null, WorkflowValue<int[]> bodypixels = null)
        {
            WorkflowValue.Validate(bodyshortUrl, nameof(bodyshortUrl), required: false);
            WorkflowValue.Validate(bodylongUrl, nameof(bodylongUrl), required: false);
            WorkflowValue.Validate(bodydomain, nameof(bodydomain), required: false);
            WorkflowValue.Validate(bodyshortId, nameof(bodyshortId), required: false);
            WorkflowValue.Validate(bodyexpireAtViews, nameof(bodyexpireAtViews), required: false);
            WorkflowValue.Validate(bodyexpireAtDatetime, nameof(bodyexpireAtDatetime), required: false);
            WorkflowValue.Validate(bodypublicStats, nameof(bodypublicStats), required: false);
            WorkflowValue.Validate(bodyqrCodeUrl, nameof(bodyqrCodeUrl), required: false);
            WorkflowValue.Validate(bodyqrCodeBase64, nameof(bodyqrCodeBase64), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowValue.Validate(bodypixels, nameof(bodypixels), required: false);
            return new DeferredBodyAction<LinkPutResponse>(() =>
            {
                var apiCallPath = "/api/v1/link";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyshortUrl != null)
                {
                    body["short_url"] = ExpressionConverter.ConvertO(bodyshortUrl);
                    bodypropCount++;
                }

                if (bodylongUrl != null)
                {
                    body["long_url"] = ExpressionConverter.ConvertO(bodylongUrl);
                    bodypropCount++;
                }

                if (bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(bodydomain);
                    bodypropCount++;
                }

                if (bodyshortId != null)
                {
                    body["short_id"] = ExpressionConverter.ConvertO(bodyshortId);
                    bodypropCount++;
                }

                if (bodyexpireAtViews != null)
                {
                    body["expire_at_views"] = ExpressionConverter.ConvertO(bodyexpireAtViews);
                    bodypropCount++;
                }

                if (bodyexpireAtDatetime != null)
                {
                    body["expire_at_datetime"] = ExpressionConverter.ConvertO(bodyexpireAtDatetime);
                    bodypropCount++;
                }

                if (bodypublicStats != null)
                {
                    body["public_stats"] = ExpressionConverter.ConvertO(bodypublicStats);
                    bodypropCount++;
                }

                if (bodyqrCodeUrl != null)
                {
                    body["qr_code_url"] = ExpressionConverter.ConvertO(bodyqrCodeUrl);
                    bodypropCount++;
                }

                if (bodyqrCodeBase64 != null)
                {
                    body["qr_code_base64"] = ExpressionConverter.ConvertO(bodyqrCodeBase64);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                if (bodypixels != null)
                {
                    body["pixels"] = ExpressionConverter.ConvertO(bodypixels);
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
        [WorkflowExpressionFactory(nameof(__BuildLinkExpand))]
        public IBodyWorkflowAction<LinkExpandPostResponse> LinkExpand([WorkflowExpression] Func<string> bodyshortUrl = null, [WorkflowExpression] Func<string> bodypassword = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinkExpandPostResponse> __BuildLinkExpand(WorkflowValue<string> bodyshortUrl = null, WorkflowValue<string> bodypassword = null)
        {
            WorkflowValue.Validate(bodyshortUrl, nameof(bodyshortUrl), required: false);
            WorkflowValue.Validate(bodypassword, nameof(bodypassword), required: false);
            return new DeferredBodyAction<LinkExpandPostResponse>(() =>
            {
                var apiCallPath = "/api/v1/link/expand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyshortUrl != null)
                {
                    body["short_url"] = ExpressionConverter.ConvertO(bodyshortUrl);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(bodypassword);
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
        [WorkflowExpressionFactory(nameof(__BuildLinksGet))]
        public IBodyWorkflowAction<LinksGetResponse> LinksGet([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> tagIds = null, [WorkflowExpression] Func<string> pixelIds = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> domains = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LinksGetResponse> __BuildLinksGet(WorkflowValue<string> search = null, WorkflowValue<string> tagIds = null, WorkflowValue<string> pixelIds = null, WorkflowValue<string> startDate = null, WorkflowValue<string> endDate = null, WorkflowValue<string> domains = null)
        {
            WorkflowValue.Validate(search, nameof(search), required: false);
            WorkflowValue.Validate(tagIds, nameof(tagIds), required: false);
            WorkflowValue.Validate(pixelIds, nameof(pixelIds), required: false);
            WorkflowValue.Validate(startDate, nameof(startDate), required: false);
            WorkflowValue.Validate(endDate, nameof(endDate), required: false);
            WorkflowValue.Validate(domains, nameof(domains), required: false);
            return new DeferredBodyAction<LinksGetResponse>(() =>
            {
                var apiCallPath = "/api/v1/link/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (tagIds != null)
                    callPayload.Queries["tag_ids"] = ExpressionConverter.Convert(tagIds);
                if (pixelIds != null)
                    callPayload.Queries["pixel_ids"] = ExpressionConverter.Convert(pixelIds);
                if (startDate != null)
                    callPayload.Queries["start_date"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = ExpressionConverter.Convert(endDate);
                if (domains != null)
                    callPayload.Queries["domains"] = ExpressionConverter.Convert(domains);
                return new ApiConnectionAction<LinksGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        [WorkflowExpressionFactory(nameof(__BuildLinkBulk))]
        public IBodyWorkflowAction<string> LinkBulk([WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<bodylinksInputItem[]> bodylinks = null, [WorkflowExpression] Func<int[]> bodytags = null, [WorkflowExpression] Func<int[]> bodypixels = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildLinkBulk(WorkflowValue<string> bodydomain = null, WorkflowValue<bodylinksInputItem[]> bodylinks = null, WorkflowValue<int[]> bodytags = null, WorkflowValue<int[]> bodypixels = null)
        {
            WorkflowValue.Validate(bodydomain, nameof(bodydomain), required: false);
            WorkflowValue.Validate(bodylinks, nameof(bodylinks), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowValue.Validate(bodypixels, nameof(bodypixels), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/v1/link/bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(bodydomain);
                    bodypropCount++;
                }

                if (bodylinks != null)
                {
                    body["links"] = ExpressionConverter.ConvertO(bodylinks);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                if (bodypixels != null)
                {
                    body["pixels"] = ExpressionConverter.ConvertO(bodypixels);
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
        [WorkflowExpressionFactory(nameof(__BuildStatGet))]
        public IBodyWorkflowAction<StatGetResponse> StatGet([WorkflowExpression] Func<string> shortLink)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StatGetResponse> __BuildStatGet(WorkflowValue<string> shortLink)
        {
            WorkflowValue.Validate(shortLink, nameof(shortLink), required: true);
            return new DeferredBodyAction<StatGetResponse>(() =>
            {
                var apiCallPath = "/api/v1/link/stats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["short_link"] = ExpressionConverter.Convert(shortLink);
                return new ApiConnectionAction<StatGetResponse>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildTag))]
        public IBodyWorkflowAction<TagPostResponse> Tag([WorkflowExpression] Func<string> bodytag)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagPostResponse> __BuildTag(WorkflowValue<string> bodytag)
        {
            WorkflowValue.Validate(bodytag, nameof(bodytag), required: true);
            return new DeferredBodyAction<TagPostResponse>(() =>
            {
                var apiCallPath = "/api/v1/link/tag";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tag"] = ExpressionConverter.ConvertO(bodytag);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TagPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        [WorkflowExpressionFactory(nameof(__BuildTagGet))]
        public IBodyWorkflowAction<TagGetResponse> TagGet([WorkflowExpression] Func<string> tagId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagGetResponse> __BuildTagGet(WorkflowValue<string> tagId)
        {
            WorkflowValue.Validate(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<TagGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/link/tag/{0}", ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TagGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        [WorkflowExpressionFactory(nameof(__BuildTagDelete))]
        public IBodyWorkflowAction<string> TagDelete([WorkflowExpression] Func<string> tagId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildTagDelete(WorkflowValue<string> tagId)
        {
            WorkflowValue.Validate(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/link/tag/{0}", ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        [WorkflowExpressionFactory(nameof(__BuildTagPut))]
        public IBodyWorkflowAction<TagPutResponse> TagPut([WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> bodytag)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TagPutResponse> __BuildTagPut(WorkflowValue<string> tagId, WorkflowValue<string> bodytag)
        {
            WorkflowValue.Validate(tagId, nameof(tagId), required: true);
            WorkflowValue.Validate(bodytag, nameof(bodytag), required: true);
            return new DeferredBodyAction<TagPutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/link/tag/{0}", ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tag"] = ExpressionConverter.ConvertO(bodytag);
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
