//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pixelmeip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PixelmeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelmeip")]
        public IBodyWorkflowAction<AccountGetResponse, ApiConnectionActionConfiguration> AccountGet()
        {
            return new DeferredBodyAction<AccountGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AccountGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelmeip")]
        public IBodyWorkflowAction<RedirectPostResponse, ApiConnectionActionConfiguration> Redirect(Expression<Func<string>> bodyurl, Expression<Func<string[]>> bodypixelsIds = null, Expression<Func<string>> bodydomain = null, Expression<Func<string>> bodykey = null, Expression<Func<string[]>> bodytags = null, Expression<Func<string>> bodycampaignId = null, Expression<Func<string>> bodysubCampaignId = null, Expression<Func<bodydynamicUrlsInputItem[]>> bodydynamicUrls = null)
        {
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: true);
            var __workflow_bodypixelsIds = WorkflowExpression.Compile(bodypixelsIds, nameof(bodypixelsIds), required: false);
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: false);
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            var __workflow_bodycampaignId = WorkflowExpression.Compile(bodycampaignId, nameof(bodycampaignId), required: false);
            var __workflow_bodysubCampaignId = WorkflowExpression.Compile(bodysubCampaignId, nameof(bodysubCampaignId), required: false);
            var __workflow_bodydynamicUrls = WorkflowExpression.Compile(bodydynamicUrls, nameof(bodydynamicUrls), required: false);
            return new DeferredBodyAction<RedirectPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/redirects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                if (__workflow_bodypixelsIds != null)
                {
                    body["pixels_ids"] = ExpressionConverter.ConvertO(__workflow_bodypixelsIds);
                    bodypropCount++;
                }

                if (__workflow_bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                    bodypropCount++;
                }

                if (__workflow_bodykey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (__workflow_bodycampaignId != null)
                {
                    body["campaign_id"] = ExpressionConverter.ConvertO(__workflow_bodycampaignId);
                    bodypropCount++;
                }

                if (__workflow_bodysubCampaignId != null)
                {
                    body["sub_campaign_id"] = ExpressionConverter.ConvertO(__workflow_bodysubCampaignId);
                    bodypropCount++;
                }

                if (__workflow_bodydynamicUrls != null)
                {
                    body["dynamic_urls"] = ExpressionConverter.ConvertO(__workflow_bodydynamicUrls);
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
        public IBodyWorkflowAction<RedirectsGetResponse, ApiConnectionActionConfiguration> RedirectsGet()
        {
            return new DeferredBodyAction<RedirectsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/redirects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RedirectsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pixelmeip")]
        public IBodyWorkflowAction<RedirectPatchResponse, ApiConnectionActionConfiguration> RedirectPatch(Expression<Func<string>> id, Expression<Func<string>> bodykey, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: true);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<RedirectPatchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/redirects/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> RedirectDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/redirects/{0}", __workflow_id.WithUrlEncoding(1)));
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