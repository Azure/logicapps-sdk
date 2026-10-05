//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pixelmeip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PixelmeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelmeip")]
        public IBodyWorkflowAction<AccountGetResponse> AccountGet()
        {
            var apiCallPath = "/accounts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AccountGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelmeip")]
        [WorkflowExpressionFactory(nameof(__BuildRedirect))]
        public IBodyWorkflowAction<RedirectPostResponse> Redirect([WorkflowExpression] Func<string> bodyurl, [WorkflowExpression] Func<string[]> bodypixelsIds = null, [WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string[]> bodytags = null, [WorkflowExpression] Func<string> bodycampaignId = null, [WorkflowExpression] Func<string> bodysubCampaignId = null, [WorkflowExpression] Func<bodydynamicUrlsInputItem[]> bodydynamicUrls = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RedirectPostResponse> __BuildRedirect(WorkflowValue<string> bodyurl, WorkflowValue<string[]> bodypixelsIds = null, WorkflowValue<string> bodydomain = null, WorkflowValue<string> bodykey = null, WorkflowValue<string[]> bodytags = null, WorkflowValue<string> bodycampaignId = null, WorkflowValue<string> bodysubCampaignId = null, WorkflowValue<bodydynamicUrlsInputItem[]> bodydynamicUrls = null)
        {
            WorkflowValue.Validate(bodyurl, nameof(bodyurl), required: true);
            WorkflowValue.Validate(bodypixelsIds, nameof(bodypixelsIds), required: false);
            WorkflowValue.Validate(bodydomain, nameof(bodydomain), required: false);
            WorkflowValue.Validate(bodykey, nameof(bodykey), required: false);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            WorkflowValue.Validate(bodycampaignId, nameof(bodycampaignId), required: false);
            WorkflowValue.Validate(bodysubCampaignId, nameof(bodysubCampaignId), required: false);
            WorkflowValue.Validate(bodydynamicUrls, nameof(bodydynamicUrls), required: false);
            return new DeferredBodyAction<RedirectPostResponse>(() =>
            {
                var apiCallPath = "/redirects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                if (bodypixelsIds != null)
                {
                    body["pixels_ids"] = ExpressionConverter.ConvertO(bodypixelsIds);
                    bodypropCount++;
                }

                if (bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(bodydomain);
                    bodypropCount++;
                }

                if (bodykey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(bodykey);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                if (bodycampaignId != null)
                {
                    body["campaign_id"] = ExpressionConverter.ConvertO(bodycampaignId);
                    bodypropCount++;
                }

                if (bodysubCampaignId != null)
                {
                    body["sub_campaign_id"] = ExpressionConverter.ConvertO(bodysubCampaignId);
                    bodypropCount++;
                }

                if (bodydynamicUrls != null)
                {
                    body["dynamic_urls"] = ExpressionConverter.ConvertO(bodydynamicUrls);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RedirectPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelmeip")]
        public IBodyWorkflowAction<RedirectsGetResponse> RedirectsGet()
        {
            var apiCallPath = "/redirects";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RedirectsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelmeip")]
        [WorkflowExpressionFactory(nameof(__BuildRedirectPatch))]
        public IBodyWorkflowAction<RedirectPatchResponse> RedirectPatch([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodykey, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RedirectPatchResponse> __BuildRedirectPatch(WorkflowValue<string> id, WorkflowValue<string> bodykey, WorkflowValue<string[]> bodytags = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(bodykey, nameof(bodykey), required: true);
            WorkflowValue.Validate(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<RedirectPatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/redirects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                if (bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RedirectPatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelmeip")]
        [WorkflowExpressionFactory(nameof(__BuildRedirectDelete))]
        public IBodyWorkflowAction<string> RedirectDelete([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildRedirectDelete(WorkflowValue<string> id)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/redirects/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class PixelmeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AccountGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pixels")]
        public AccountGetResponsePixelsTypeItem[] Pixels { get; set; }

        [JsonProperty("domains")]
        public string[] Domains { get; set; }

        [JsonProperty("campaigns")]
        public AccountGetResponseCampaignsTypeItem[] Campaigns { get; set; }

        [JsonProperty("utms")]
        public AccountGetResponseUtmsType Utms { get; set; }
    }

    public class AccountGetResponsePixelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("provider_key")]
        public string ProviderKey { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class AccountGetResponseCampaignsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sub_campaigns")]
        public AccountGetResponseCampaignsTypeItemSubCampaignsTypeItem[] SubCampaigns { get; set; }
    }

    public class AccountGetResponseCampaignsTypeItemSubCampaignsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AccountGetResponseUtmsType
    {
        [JsonProperty("utms_campaign")]
        public string[] UtmsCampaign { get; set; }

        [JsonProperty("utms_medium")]
        public string[] UtmsMedium { get; set; }

        [JsonProperty("utms_source")]
        public string[] UtmsSource { get; set; }
    }

    public class RedirectPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("pixels")]
        public RedirectPostResponsePixelsTypeItem[] Pixels { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("shorten")]
        public string Shorten { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("sub_campaign_id")]
        public string SubCampaignId { get; set; }
    }

    public class RedirectPostResponsePixelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("provider_key")]
        public string ProviderKey { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class bodydynamicUrlsInputItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("rule")]
        public string Rule { get; set; }
    }

    public class RedirectsGetResponse
    {
        [JsonProperty("redirects")]
        public RedirectsGetResponseRedirectsTypeItem[] Redirects { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("start")]
        public int Start { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }
    }

    public class RedirectsGetResponseRedirectsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("shorten")]
        public string Shorten { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("pixels")]
        public string[] Pixels { get; set; }
    }

    public class RedirectPatchResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("pixels")]
        public RedirectPatchResponsePixelsTypeItem[] Pixels { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("shorten")]
        public string Shorten { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("sub_campaign_id")]
        public string SubCampaignId { get; set; }
    }

    public class RedirectPatchResponsePixelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("provider_key")]
        public string ProviderKey { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pixelmeip;

    public partial class WorkflowManagedActions
    {
        public PixelmeipActions Pixelmeip(string connectionId) => new PixelmeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PixelmeipTriggers Pixelmeip(string connectionId) => new PixelmeipTriggers(connectionId);
    }
}
