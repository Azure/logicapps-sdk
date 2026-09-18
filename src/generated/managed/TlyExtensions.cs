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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/link/pixel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PixelsGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<PixelPostResponse> Pixel([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodypixelId, [WorkflowExpression] Func<string> bodypixelType)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodypixelId, nameof(bodypixelId), required: true);
            SourceExpression.Validate(bodypixelType, nameof(bodypixelType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/link/pixel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["pixel_id"] = SourceExpressionConverter.ConvertToken(bodypixelId);
                bodypropCount++;
                body["pixel_type"] = SourceExpressionConverter.ConvertToken(bodypixelType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PixelPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<PixelGetResponse> PixelGet([WorkflowExpression] Func<string> pixelId)
        {
            SourceExpression.Validate(pixelId, nameof(pixelId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/link/pixel/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pixelId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PixelGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<string> PixelDelete([WorkflowExpression] Func<string> pixelId)
        {
            SourceExpression.Validate(pixelId, nameof(pixelId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/link/pixel/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pixelId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<PixelPutResponse> PixelPut([WorkflowExpression] Func<string> pixelId, [WorkflowExpression] Func<int> bodyid = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodypixelId = null, [WorkflowExpression] Func<string> bodypixelType = null)
        {
            SourceExpression.Validate(pixelId, nameof(pixelId), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodypixelId, nameof(bodypixelId), required: false);
            SourceExpression.Validate(bodypixelType, nameof(bodypixelType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/link/pixel/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pixelId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypixelId != null)
                {
                    body["pixel_id"] = SourceExpressionConverter.ConvertToken(bodypixelId);
                    bodypropCount++;
                }

                if (bodypixelType != null)
                {
                    body["pixel_type"] = SourceExpressionConverter.ConvertToken(bodypixelType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PixelPutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinkPostResponse> Link([WorkflowExpression] Func<string> bodylongUrl, [WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<string> bodyexpireAtDatetime = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<bool> bodypublicStats = null, [WorkflowExpression] Func<bodymetasmartUrlsInputItem[]> bodymetasmartUrls = null)
        {
            SourceExpression.Validate(bodylongUrl, nameof(bodylongUrl), required: true);
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: false);
            SourceExpression.Validate(bodyexpireAtDatetime, nameof(bodyexpireAtDatetime), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodypublicStats, nameof(bodypublicStats), required: false);
            SourceExpression.Validate(bodymetasmartUrls, nameof(bodymetasmartUrls), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/link/shorten";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["long_url"] = SourceExpressionConverter.ConvertToken(bodylongUrl);
                if (bodydomain != null)
                {
                    body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                    bodypropCount++;
                }

                if (bodyexpireAtDatetime != null)
                {
                    body["expire_at_datetime"] = SourceExpressionConverter.ConvertToken(bodyexpireAtDatetime);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypublicStats != null)
                {
                    body["public_stats"] = SourceExpressionConverter.ConvertToken(bodypublicStats);
                    bodypropCount++;
                }

                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                if (bodymetasmartUrls != null)
                {
                    metaObject["smart_urls"] = SourceExpressionConverter.ConvertToken(bodymetasmartUrls);
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
                return callPayload;
            }

            return new ApiConnectionAction<LinkPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinkGetResponse> LinkGet([WorkflowExpression] Func<string> shortUrl = null)
        {
            SourceExpression.Validate(shortUrl, nameof(shortUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/link";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (shortUrl != null)
                    callPayload.Queries["short_url"] = SourceExpressionConverter.ConvertO(shortUrl);
                return callPayload;
            }

            return new ApiConnectionAction<LinkGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<string> LinkDelete([WorkflowExpression] Func<string> bodyshortUrl = null)
        {
            SourceExpression.Validate(bodyshortUrl, nameof(bodyshortUrl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/link";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyshortUrl != null)
                {
                    body["short_url"] = SourceExpressionConverter.ConvertToken(bodyshortUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinkPutResponse> LinkPut([WorkflowExpression] Func<string> bodyshortUrl = null, [WorkflowExpression] Func<string> bodylongUrl = null, [WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<string> bodyshortId = null, [WorkflowExpression] Func<string> bodyexpireAtViews = null, [WorkflowExpression] Func<string> bodyexpireAtDatetime = null, [WorkflowExpression] Func<bool> bodypublicStats = null, [WorkflowExpression] Func<string> bodyqrCodeUrl = null, [WorkflowExpression] Func<string> bodyqrCodeBase64 = null, [WorkflowExpression] Func<int[]> bodytags = null, [WorkflowExpression] Func<int[]> bodypixels = null)
        {
            SourceExpression.Validate(bodyshortUrl, nameof(bodyshortUrl), required: false);
            SourceExpression.Validate(bodylongUrl, nameof(bodylongUrl), required: false);
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: false);
            SourceExpression.Validate(bodyshortId, nameof(bodyshortId), required: false);
            SourceExpression.Validate(bodyexpireAtViews, nameof(bodyexpireAtViews), required: false);
            SourceExpression.Validate(bodyexpireAtDatetime, nameof(bodyexpireAtDatetime), required: false);
            SourceExpression.Validate(bodypublicStats, nameof(bodypublicStats), required: false);
            SourceExpression.Validate(bodyqrCodeUrl, nameof(bodyqrCodeUrl), required: false);
            SourceExpression.Validate(bodyqrCodeBase64, nameof(bodyqrCodeBase64), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            SourceExpression.Validate(bodypixels, nameof(bodypixels), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/link";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyshortUrl != null)
                {
                    body["short_url"] = SourceExpressionConverter.ConvertToken(bodyshortUrl);
                    bodypropCount++;
                }

                if (bodylongUrl != null)
                {
                    body["long_url"] = SourceExpressionConverter.ConvertToken(bodylongUrl);
                    bodypropCount++;
                }

                if (bodydomain != null)
                {
                    body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                    bodypropCount++;
                }

                if (bodyshortId != null)
                {
                    body["short_id"] = SourceExpressionConverter.ConvertToken(bodyshortId);
                    bodypropCount++;
                }

                if (bodyexpireAtViews != null)
                {
                    body["expire_at_views"] = SourceExpressionConverter.ConvertToken(bodyexpireAtViews);
                    bodypropCount++;
                }

                if (bodyexpireAtDatetime != null)
                {
                    body["expire_at_datetime"] = SourceExpressionConverter.ConvertToken(bodyexpireAtDatetime);
                    bodypropCount++;
                }

                if (bodypublicStats != null)
                {
                    body["public_stats"] = SourceExpressionConverter.ConvertToken(bodypublicStats);
                    bodypropCount++;
                }

                if (bodyqrCodeUrl != null)
                {
                    body["qr_code_url"] = SourceExpressionConverter.ConvertToken(bodyqrCodeUrl);
                    bodypropCount++;
                }

                if (bodyqrCodeBase64 != null)
                {
                    body["qr_code_base64"] = SourceExpressionConverter.ConvertToken(bodyqrCodeBase64);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypixels != null)
                {
                    body["pixels"] = SourceExpressionConverter.ConvertToken(bodypixels);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LinkPutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinkExpandPostResponse> LinkExpand([WorkflowExpression] Func<string> bodyshortUrl = null, [WorkflowExpression] Func<string> bodypassword = null)
        {
            SourceExpression.Validate(bodyshortUrl, nameof(bodyshortUrl), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/link/expand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyshortUrl != null)
                {
                    body["short_url"] = SourceExpressionConverter.ConvertToken(bodyshortUrl);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LinkExpandPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<LinksGetResponse> LinksGet([WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> tagIds = null, [WorkflowExpression] Func<string> pixelIds = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null, [WorkflowExpression] Func<string> domains = null)
        {
            SourceExpression.Validate(search, nameof(search), required: false);
            SourceExpression.Validate(tagIds, nameof(tagIds), required: false);
            SourceExpression.Validate(pixelIds, nameof(pixelIds), required: false);
            SourceExpression.Validate(startDate, nameof(startDate), required: false);
            SourceExpression.Validate(endDate, nameof(endDate), required: false);
            SourceExpression.Validate(domains, nameof(domains), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/link/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (tagIds != null)
                    callPayload.Queries["tag_ids"] = SourceExpressionConverter.ConvertO(tagIds);
                if (pixelIds != null)
                    callPayload.Queries["pixel_ids"] = SourceExpressionConverter.ConvertO(pixelIds);
                if (startDate != null)
                    callPayload.Queries["start_date"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["end_date"] = SourceExpressionConverter.ConvertO(endDate);
                if (domains != null)
                    callPayload.Queries["domains"] = SourceExpressionConverter.ConvertO(domains);
                return callPayload;
            }

            return new ApiConnectionAction<LinksGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<string> LinkBulk([WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<bodylinksInputItem[]> bodylinks = null, [WorkflowExpression] Func<int[]> bodytags = null, [WorkflowExpression] Func<int[]> bodypixels = null)
        {
            SourceExpression.Validate(bodydomain, nameof(bodydomain), required: false);
            SourceExpression.Validate(bodylinks, nameof(bodylinks), required: false);
            SourceExpression.Validate(bodytags, nameof(bodytags), required: false);
            SourceExpression.Validate(bodypixels, nameof(bodypixels), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/link/bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydomain != null)
                {
                    body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                    bodypropCount++;
                }

                if (bodylinks != null)
                {
                    body["links"] = SourceExpressionConverter.ConvertToken(bodylinks);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypixels != null)
                {
                    body["pixels"] = SourceExpressionConverter.ConvertToken(bodypixels);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<StatGetResponse> StatGet([WorkflowExpression] Func<string> shortLink)
        {
            SourceExpression.Validate(shortLink, nameof(shortLink), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/link/stats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["short_link"] = SourceExpressionConverter.ConvertO(shortLink);
                return callPayload;
            }

            return new ApiConnectionAction<StatGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<TagsGetResponseItem[]> TagsGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/link/tag";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TagsGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<TagPostResponse> Tag([WorkflowExpression] Func<string> bodytag)
        {
            SourceExpression.Validate(bodytag, nameof(bodytag), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/link/tag";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tag"] = SourceExpressionConverter.ConvertToken(bodytag);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TagPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<TagGetResponse> TagGet([WorkflowExpression] Func<string> tagId)
        {
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/link/tag/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TagGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<string> TagDelete([WorkflowExpression] Func<string> tagId)
        {
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/link/tag/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tly")]
        public IBodyWorkflowAction<TagPutResponse> TagPut([WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<string> bodytag)
        {
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            SourceExpression.Validate(bodytag, nameof(bodytag), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/link/tag/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tag"] = SourceExpressionConverter.ConvertToken(bodytag);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TagPutResponse>(BuildSourceInput);
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