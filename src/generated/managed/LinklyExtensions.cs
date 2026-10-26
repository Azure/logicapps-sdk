//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Linkly
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LinklyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<ListConversionsResponse, ApiConnectionActionConfiguration> ListConversions(Expression<Func<int>> limit = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<ListConversionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<ListConversionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<CreateConversionResponse, ApiConnectionActionConfiguration> CreateConversion(Expression<Func<string>> bodyeventName, Expression<Func<int>> bodyamountCents = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodycurrency = null, Expression<Func<string>> bodyeventId = null, Expression<Func<bodyeventTypeInput>> bodyeventType = null, Expression<Func<string>> bodycustomerId = null, Expression<Func<string>> bodyattributionToken = null, Expression<Func<string>> bodyoccurredAt = null, Expression<Func<string>> bodyvisitorIP = null)
        {
            var __workflow_bodyeventName = WorkflowExpression.Compile(bodyeventName, nameof(bodyeventName), required: true);
            var __workflow_bodyamountCents = WorkflowExpression.Compile(bodyamountCents, nameof(bodyamountCents), required: false);
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: false);
            var __workflow_bodycurrency = WorkflowExpression.Compile(bodycurrency, nameof(bodycurrency), required: false);
            var __workflow_bodyeventId = WorkflowExpression.Compile(bodyeventId, nameof(bodyeventId), required: false);
            var __workflow_bodyeventType = WorkflowExpression.Compile(bodyeventType, nameof(bodyeventType), required: false);
            var __workflow_bodycustomerId = WorkflowExpression.Compile(bodycustomerId, nameof(bodycustomerId), required: false);
            var __workflow_bodyattributionToken = WorkflowExpression.Compile(bodyattributionToken, nameof(bodyattributionToken), required: false);
            var __workflow_bodyoccurredAt = WorkflowExpression.Compile(bodyoccurredAt, nameof(bodyoccurredAt), required: false);
            var __workflow_bodyvisitorIP = WorkflowExpression.Compile(bodyvisitorIP, nameof(bodyvisitorIP), required: false);
            return new DeferredBodyAction<CreateConversionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/conversions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyamountCents != null)
                {
                    body["amount_cents"] = ExpressionConverter.ConvertO(__workflow_bodyamountCents);
                    bodypropCount++;
                }

                if (__workflow_bodycountry != null)
                {
                    body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                    bodypropCount++;
                }

                if (__workflow_bodycurrency != null)
                {
                    body["currency"] = ExpressionConverter.ConvertO(__workflow_bodycurrency);
                    bodypropCount++;
                }

                if (__workflow_bodyeventId != null)
                {
                    body["event_id"] = ExpressionConverter.ConvertO(__workflow_bodyeventId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["event_name"] = ExpressionConverter.ConvertO(__workflow_bodyeventName);
                if (__workflow_bodyeventType != null)
                {
                    body["event_type"] = ExpressionConverter.ConvertO(__workflow_bodyeventType);
                    bodypropCount++;
                }

                if (__workflow_bodycustomerId != null)
                {
                    body["external_id"] = ExpressionConverter.ConvertO(__workflow_bodycustomerId);
                    bodypropCount++;
                }

                if (__workflow_bodyattributionToken != null)
                {
                    body["linkly_cid"] = ExpressionConverter.ConvertO(__workflow_bodyattributionToken);
                    bodypropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                if (__workflow_bodyoccurredAt != null)
                {
                    body["occurred_at"] = ExpressionConverter.ConvertO(__workflow_bodyoccurredAt);
                    bodypropCount++;
                }

                if (__workflow_bodyvisitorIP != null)
                {
                    body["visitor_ip"] = ExpressionConverter.ConvertO(__workflow_bodyvisitorIP);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateConversionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<CreateOrUpdateLinkResponse, ApiConnectionActionConfiguration> CreateOrUpdateLink(Expression<Func<string>> bodydestinationURL = null, Expression<Func<int>> bodylinkId = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydomain = null, Expression<Func<string>> bodyslug = null, Expression<Func<bool>> bodyenabled = null, Expression<Func<string>> bodynote = null, Expression<Func<string>> bodyuTMSource = null, Expression<Func<string>> bodyuTMMedium = null, Expression<Func<string>> bodyuTMCampaign = null, Expression<Func<string>> bodyuTMContent = null, Expression<Func<string>> bodyuTMTerm = null, Expression<Func<string>> bodymetaPixelId = null, Expression<Func<string>> bodygoogleAnalytics4TagId = null, Expression<Func<string>> bodygoogleTagManagerId = null, Expression<Func<bool>> bodyblockBots = null, Expression<Func<string>> bodybodyTags = null, Expression<Func<bool>> bodycloaking = null, Expression<Func<bool>> bodyforwardParameters = null, Expression<Func<string>> bodyheadTags = null, Expression<Func<bool>> bodyhideReferrer = null, Expression<Func<string>> bodyopenGraphDescription = null, Expression<Func<string>> bodyopenGraphImage = null, Expression<Func<string>> bodyopenGraphTitle = null, Expression<Func<string>> bodytikTokPixelId = null)
        {
            var __workflow_bodydestinationURL = WorkflowExpression.Compile(bodydestinationURL, nameof(bodydestinationURL), required: false);
            var __workflow_bodylinkId = WorkflowExpression.Compile(bodylinkId, nameof(bodylinkId), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydomain = WorkflowExpression.Compile(bodydomain, nameof(bodydomain), required: false);
            var __workflow_bodyslug = WorkflowExpression.Compile(bodyslug, nameof(bodyslug), required: false);
            var __workflow_bodyenabled = WorkflowExpression.Compile(bodyenabled, nameof(bodyenabled), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodyuTMSource = WorkflowExpression.Compile(bodyuTMSource, nameof(bodyuTMSource), required: false);
            var __workflow_bodyuTMMedium = WorkflowExpression.Compile(bodyuTMMedium, nameof(bodyuTMMedium), required: false);
            var __workflow_bodyuTMCampaign = WorkflowExpression.Compile(bodyuTMCampaign, nameof(bodyuTMCampaign), required: false);
            var __workflow_bodyuTMContent = WorkflowExpression.Compile(bodyuTMContent, nameof(bodyuTMContent), required: false);
            var __workflow_bodyuTMTerm = WorkflowExpression.Compile(bodyuTMTerm, nameof(bodyuTMTerm), required: false);
            var __workflow_bodymetaPixelId = WorkflowExpression.Compile(bodymetaPixelId, nameof(bodymetaPixelId), required: false);
            var __workflow_bodygoogleAnalytics4TagId = WorkflowExpression.Compile(bodygoogleAnalytics4TagId, nameof(bodygoogleAnalytics4TagId), required: false);
            var __workflow_bodygoogleTagManagerId = WorkflowExpression.Compile(bodygoogleTagManagerId, nameof(bodygoogleTagManagerId), required: false);
            var __workflow_bodyblockBots = WorkflowExpression.Compile(bodyblockBots, nameof(bodyblockBots), required: false);
            var __workflow_bodybodyTags = WorkflowExpression.Compile(bodybodyTags, nameof(bodybodyTags), required: false);
            var __workflow_bodycloaking = WorkflowExpression.Compile(bodycloaking, nameof(bodycloaking), required: false);
            var __workflow_bodyforwardParameters = WorkflowExpression.Compile(bodyforwardParameters, nameof(bodyforwardParameters), required: false);
            var __workflow_bodyheadTags = WorkflowExpression.Compile(bodyheadTags, nameof(bodyheadTags), required: false);
            var __workflow_bodyhideReferrer = WorkflowExpression.Compile(bodyhideReferrer, nameof(bodyhideReferrer), required: false);
            var __workflow_bodyopenGraphDescription = WorkflowExpression.Compile(bodyopenGraphDescription, nameof(bodyopenGraphDescription), required: false);
            var __workflow_bodyopenGraphImage = WorkflowExpression.Compile(bodyopenGraphImage, nameof(bodyopenGraphImage), required: false);
            var __workflow_bodyopenGraphTitle = WorkflowExpression.Compile(bodyopenGraphTitle, nameof(bodyopenGraphTitle), required: false);
            var __workflow_bodytikTokPixelId = WorkflowExpression.Compile(bodytikTokPixelId, nameof(bodytikTokPixelId), required: false);
            return new DeferredBodyAction<CreateOrUpdateLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/link";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydestinationURL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodydestinationURL);
                    bodypropCount++;
                }

                if (__workflow_bodylinkId != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodylinkId);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                    bodypropCount++;
                }

                if (__workflow_bodyslug != null)
                {
                    body["slug"] = ExpressionConverter.ConvertO(__workflow_bodyslug);
                    bodypropCount++;
                }

                if (__workflow_bodyenabled != null)
                {
                    body["enabled"] = ExpressionConverter.ConvertO(__workflow_bodyenabled);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["note"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodyuTMSource != null)
                {
                    body["utm_source"] = ExpressionConverter.ConvertO(__workflow_bodyuTMSource);
                    bodypropCount++;
                }

                if (__workflow_bodyuTMMedium != null)
                {
                    body["utm_medium"] = ExpressionConverter.ConvertO(__workflow_bodyuTMMedium);
                    bodypropCount++;
                }

                if (__workflow_bodyuTMCampaign != null)
                {
                    body["utm_campaign"] = ExpressionConverter.ConvertO(__workflow_bodyuTMCampaign);
                    bodypropCount++;
                }

                if (__workflow_bodyuTMContent != null)
                {
                    body["utm_content"] = ExpressionConverter.ConvertO(__workflow_bodyuTMContent);
                    bodypropCount++;
                }

                if (__workflow_bodyuTMTerm != null)
                {
                    body["utm_term"] = ExpressionConverter.ConvertO(__workflow_bodyuTMTerm);
                    bodypropCount++;
                }

                if (__workflow_bodymetaPixelId != null)
                {
                    body["fb_pixel_id"] = ExpressionConverter.ConvertO(__workflow_bodymetaPixelId);
                    bodypropCount++;
                }

                if (__workflow_bodygoogleAnalytics4TagId != null)
                {
                    body["ga4_tag_id"] = ExpressionConverter.ConvertO(__workflow_bodygoogleAnalytics4TagId);
                    bodypropCount++;
                }

                if (__workflow_bodygoogleTagManagerId != null)
                {
                    body["gtm_id"] = ExpressionConverter.ConvertO(__workflow_bodygoogleTagManagerId);
                    bodypropCount++;
                }

                if (__workflow_bodyblockBots != null)
                {
                    body["block_bots"] = ExpressionConverter.ConvertO(__workflow_bodyblockBots);
                    bodypropCount++;
                }

                if (__workflow_bodybodyTags != null)
                {
                    body["body_tags"] = ExpressionConverter.ConvertO(__workflow_bodybodyTags);
                    bodypropCount++;
                }

                if (__workflow_bodycloaking != null)
                {
                    body["cloaking"] = ExpressionConverter.ConvertO(__workflow_bodycloaking);
                    bodypropCount++;
                }

                if (__workflow_bodyforwardParameters != null)
                {
                    body["forward_params"] = ExpressionConverter.ConvertO(__workflow_bodyforwardParameters);
                    bodypropCount++;
                }

                if (__workflow_bodyheadTags != null)
                {
                    body["head_tags"] = ExpressionConverter.ConvertO(__workflow_bodyheadTags);
                    bodypropCount++;
                }

                if (__workflow_bodyhideReferrer != null)
                {
                    body["hide_referrer"] = ExpressionConverter.ConvertO(__workflow_bodyhideReferrer);
                    bodypropCount++;
                }

                if (__workflow_bodyopenGraphDescription != null)
                {
                    body["og_description"] = ExpressionConverter.ConvertO(__workflow_bodyopenGraphDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyopenGraphImage != null)
                {
                    body["og_image"] = ExpressionConverter.ConvertO(__workflow_bodyopenGraphImage);
                    bodypropCount++;
                }

                if (__workflow_bodyopenGraphTitle != null)
                {
                    body["og_title"] = ExpressionConverter.ConvertO(__workflow_bodyopenGraphTitle);
                    bodypropCount++;
                }

                if (__workflow_bodytikTokPixelId != null)
                {
                    body["tiktok_pixel_id"] = ExpressionConverter.ConvertO(__workflow_bodytikTokPixelId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateOrUpdateLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<GetLinkResponse, ApiConnectionActionConfiguration> GetLink(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetLinkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/link/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetLinkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<GetClicksResponse, ApiConnectionActionConfiguration> GetClicks(Expression<Func<string>> workspaceId, Expression<Func<string>> linkId = null, Expression<Func<string>> linkIds = null, Expression<Func<string>> start = null, Expression<Func<string>> end = null, Expression<Func<string>> country = null, Expression<Func<string>> browser = null, Expression<Func<string>> platform = null, Expression<Func<string>> referer = null, Expression<Func<string>> isp = null, Expression<Func<bool>> bots = null, Expression<Func<bool>> unique = null, Expression<Func<string>> timezone = null, Expression<Func<frequencyInput>> frequency = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_linkId = WorkflowExpression.Compile(linkId, nameof(linkId), required: false);
            var __workflow_linkIds = WorkflowExpression.Compile(linkIds, nameof(linkIds), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_browser = WorkflowExpression.Compile(browser, nameof(browser), required: false);
            var __workflow_platform = WorkflowExpression.Compile(platform, nameof(platform), required: false);
            var __workflow_referer = WorkflowExpression.Compile(referer, nameof(referer), required: false);
            var __workflow_isp = WorkflowExpression.Compile(isp, nameof(isp), required: false);
            var __workflow_bots = WorkflowExpression.Compile(bots, nameof(bots), required: false);
            var __workflow_unique = WorkflowExpression.Compile(unique, nameof(unique), required: false);
            var __workflow_timezone = WorkflowExpression.Compile(timezone, nameof(timezone), required: false);
            var __workflow_frequency = WorkflowExpression.Compile(frequency, nameof(frequency), required: false);
            return new DeferredBodyAction<GetClicksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspace/{0}/clicks", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_linkId != null)
                    callPayload.Queries["link_id"] = ExpressionConverter.Convert(__workflow_linkId);
                if (__workflow_linkIds != null)
                    callPayload.Queries["link_ids"] = ExpressionConverter.Convert(__workflow_linkIds);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_browser != null)
                    callPayload.Queries["browser"] = ExpressionConverter.Convert(__workflow_browser);
                if (__workflow_platform != null)
                    callPayload.Queries["platform"] = ExpressionConverter.Convert(__workflow_platform);
                if (__workflow_referer != null)
                    callPayload.Queries["referer"] = ExpressionConverter.Convert(__workflow_referer);
                if (__workflow_isp != null)
                    callPayload.Queries["isp"] = ExpressionConverter.Convert(__workflow_isp);
                if (__workflow_bots != null)
                    callPayload.Queries["bots"] = ExpressionConverter.Convert(__workflow_bots);
                if (__workflow_unique != null)
                    callPayload.Queries["unique"] = ExpressionConverter.Convert(__workflow_unique);
                if (__workflow_timezone != null)
                    callPayload.Queries["timezone"] = ExpressionConverter.Convert(__workflow_timezone);
                callPayload.Queries["frequency"] = Convert.ToString("day");
                if (__workflow_frequency != null)
                    callPayload.Queries["frequency"] = ExpressionConverter.Convert(__workflow_frequency);
                return new ApiConnectionAction<GetClicksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<GetClickCountersResponse, ApiConnectionActionConfiguration> GetClickCounters(Expression<Func<string>> workspaceId, Expression<Func<counterInput>> counter, Expression<Func<string>> linkId = null, Expression<Func<string>> linkIds = null, Expression<Func<string>> start = null, Expression<Func<string>> end = null, Expression<Func<string>> country = null, Expression<Func<bool>> bots = null, Expression<Func<bool>> unique = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_counter = WorkflowExpression.Compile(counter, nameof(counter), required: true);
            var __workflow_linkId = WorkflowExpression.Compile(linkId, nameof(linkId), required: false);
            var __workflow_linkIds = WorkflowExpression.Compile(linkIds, nameof(linkIds), required: false);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_bots = WorkflowExpression.Compile(bots, nameof(bots), required: false);
            var __workflow_unique = WorkflowExpression.Compile(unique, nameof(unique), required: false);
            return new DeferredBodyAction<GetClickCountersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspace/{0}/clicks/counters/{1}", __workflow_workspaceId.WithUrlEncoding(1), __workflow_counter.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_linkId != null)
                    callPayload.Queries["link_id"] = ExpressionConverter.Convert(__workflow_linkId);
                if (__workflow_linkIds != null)
                    callPayload.Queries["link_ids"] = ExpressionConverter.Convert(__workflow_linkIds);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_bots != null)
                    callPayload.Queries["bots"] = ExpressionConverter.Convert(__workflow_bots);
                if (__workflow_unique != null)
                    callPayload.Queries["unique"] = ExpressionConverter.Convert(__workflow_unique);
                return new ApiConnectionAction<GetClickCountersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<ListDomainsResponse, ApiConnectionActionConfiguration> ListDomains(Expression<Func<string>> workspaceId)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            return new DeferredBodyAction<ListDomainsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspace/{0}/domains", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListDomainsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DeleteLink(Expression<Func<string>> workspaceId, Expression<Func<int>> id)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspace/{0}/links/{1}", __workflow_workspaceId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<ListLinksResponse, ApiConnectionActionConfiguration> ListLinks(Expression<Func<string>> workspaceId, Expression<Func<string>> search = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null, Expression<Func<string>> sortBy = null, Expression<Func<string>> sortDir = null, Expression<Func<bool>> deleted = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            var __workflow_sortBy = WorkflowExpression.Compile(sortBy, nameof(sortBy), required: false);
            var __workflow_sortDir = WorkflowExpression.Compile(sortDir, nameof(sortDir), required: false);
            var __workflow_deleted = WorkflowExpression.Compile(deleted, nameof(deleted), required: false);
            return new DeferredBodyAction<ListLinksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workspace/{0}/list_links", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["page_size"] = Convert.ToString(1000);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page_size"] = ExpressionConverter.Convert(__workflow_pageSize);
                if (__workflow_sortBy != null)
                    callPayload.Queries["sort_by"] = ExpressionConverter.Convert(__workflow_sortBy);
                if (__workflow_sortDir != null)
                    callPayload.Queries["sort_dir"] = ExpressionConverter.Convert(__workflow_sortDir);
                callPayload.Queries["deleted"] = Convert.ToString(false);
                if (__workflow_deleted != null)
                    callPayload.Queries["deleted"] = ExpressionConverter.Convert(__workflow_deleted);
                return new ApiConnectionAction<ListLinksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<ListWorkspacesResponseItem[], ApiConnectionActionConfiguration> ListWorkspaces()
        {
            return new DeferredBodyAction<ListWorkspacesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workspaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListWorkspacesResponseItem[]>(callPayload);
            });
        }
    }

    public class LinklyTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListConversionsResponse
    {
        [JsonProperty("conversions")]
        public ListConversionsResponseConversionsTypeItem[] Conversions { get; set; }
    }

    public class ListConversionsResponseConversionsTypeItem
    {
        [JsonProperty("amount_cents")]
        public int AmountCents { get; set; }

        [JsonProperty("click_id")]
        public string ClickId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("external_id")]
        public string CustomerId { get; set; }

        [JsonProperty("id")]
        public string ConversionId { get; set; }

        [JsonProperty("inserted_at")]
        public string InsertedAt { get; set; }

        [JsonProperty("ip_source")]
        public ListConversionsResponseConversionsTypeItemIPSourceType IPSource { get; set; }

        [JsonProperty("link_id")]
        public int LinkId { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("occurred_at")]
        public string OccurredAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListConversionsResponseConversionsTypeItemIPSourceType
    {
        [EnumMember(Value = "visitor")]
        Visitor,
        [EnumMember(Value = "server")]
        Server,
        [EnumMember(Value = "unknown")]
        Unknown
    }

    public class CreateConversionResponse
    {
        [JsonProperty("amount_cents")]
        public int AmountCents { get; set; }

        [JsonProperty("click_id")]
        public string ClickId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("external_id")]
        public string CustomerId { get; set; }

        [JsonProperty("id")]
        public string ConversionId { get; set; }

        [JsonProperty("inserted_at")]
        public string InsertedAt { get; set; }

        [JsonProperty("ip_source")]
        public CreateConversionResponseIPSourceType IPSource { get; set; }

        [JsonProperty("link_id")]
        public int LinkId { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("occurred_at")]
        public string OccurredAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateConversionResponseIPSourceType
    {
        [EnumMember(Value = "visitor")]
        Visitor,
        [EnumMember(Value = "server")]
        Server,
        [EnumMember(Value = "unknown")]
        Unknown
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyeventTypeInput
    {
        [EnumMember(Value = "lead")]
        Lead,
        [EnumMember(Value = "sale")]
        Sale,
        [EnumMember(Value = "custom")]
        Custom
    }

    public class CreateOrUpdateLinkResponse
    {
        [JsonProperty("fb_pixel_id")]
        public string MetaPixelId { get; set; }

        [JsonProperty("linkedin_partner_id")]
        public string LinkedInPartnerId { get; set; }

        [JsonProperty("microsoft_uet_tag_id")]
        public string MicrosoftUETTagId { get; set; }

        [JsonProperty("reddit_pixel_id")]
        public string RedditPixelId { get; set; }

        [JsonProperty("tiktok_pixel_id")]
        public string TikTokPixelId { get; set; }

        [JsonProperty("hide_referrer")]
        public bool HideReferrer { get; set; }

        [JsonProperty("expiry_datetime")]
        public string ExpiryDate { get; set; }

        [JsonProperty("expiry_destination")]
        public string ExpiryDestination { get; set; }

        [JsonProperty("rules")]
        public CreateOrUpdateLinkResponseRulesTypeItem[] Rules { get; set; }

        [JsonProperty("twitter_pixel_id")]
        public string XPixelId { get; set; }

        [JsonProperty("cloaking")]
        public bool Cloaking { get; set; }

        [JsonProperty("linkify_words")]
        public string LinkifyWords { get; set; }

        [JsonProperty("full_url")]
        public string ShortURL { get; set; }

        [JsonProperty("og_description")]
        public string OpenGraphDescription { get; set; }

        [JsonProperty("skip_social_crawler_tracking")]
        public bool SkipSocialCrawlerTracking { get; set; }

        [JsonProperty("body_tags")]
        public string BodyTags { get; set; }

        [JsonProperty("og_title")]
        public string OpenGraphTitle { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int LinkId { get; set; }

        [JsonProperty("gtm_id")]
        public string GoogleTagManagerId { get; set; }

        [JsonProperty("og_image")]
        public string OpenGraphImage { get; set; }

        [JsonProperty("block_bots")]
        public bool BlockBots { get; set; }

        [JsonProperty("snapchat_pixel_id")]
        public string SnapchatPixelId { get; set; }

        [JsonProperty("utm_content")]
        public string UTMContent { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("url")]
        public string DestinationURL { get; set; }

        [JsonProperty("replacements")]
        public string Replacements { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("webhooks")]
        public string[] Webhooks { get; set; }

        [JsonProperty("created_by_user_id")]
        public int CreatedByUserId { get; set; }

        [JsonProperty("expiry_clicks")]
        public int ExpiryClicks { get; set; }

        [JsonProperty("notify_slack")]
        public bool NotifySlack { get; set; }

        [JsonProperty("notify_user_ids")]
        public int[] NotifyUserIDs { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

        [JsonProperty("public_analytics")]
        public bool PublicAnalytics { get; set; }

        [JsonProperty("pinterest_tag_id")]
        public string PinterestTagId { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("utm_source")]
        public string UTMSource { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("forward_params")]
        public bool ForwardParameters { get; set; }

        [JsonProperty("utm_medium")]
        public string UTMMedium { get; set; }

        [JsonProperty("head_tags")]
        public string HeadTags { get; set; }

        [JsonProperty("ga4_tag_id")]
        public string GoogleAnalytics4TagId { get; set; }

        [JsonProperty("utm_term")]
        public string UTMTerm { get; set; }

        [JsonProperty("utm_campaign")]
        public string UTMCampaign { get; set; }
    }

    public class CreateOrUpdateLinkResponseRulesTypeItem
    {
        [JsonProperty("matches")]
        public string Matches { get; set; }

        [JsonProperty("percentage")]
        public int Percentage { get; set; }

        [JsonProperty("url")]
        public string RuleURL { get; set; }

        [JsonProperty("what")]
        public string What { get; set; }
    }

    public class GetLinkResponse
    {
        [JsonProperty("fb_pixel_id")]
        public string MetaPixelId { get; set; }

        [JsonProperty("linkedin_partner_id")]
        public string LinkedInPartnerId { get; set; }

        [JsonProperty("microsoft_uet_tag_id")]
        public string MicrosoftUETTagId { get; set; }

        [JsonProperty("reddit_pixel_id")]
        public string RedditPixelId { get; set; }

        [JsonProperty("tiktok_pixel_id")]
        public string TikTokPixelId { get; set; }

        [JsonProperty("hide_referrer")]
        public bool HideReferrer { get; set; }

        [JsonProperty("expiry_datetime")]
        public string ExpiryDate { get; set; }

        [JsonProperty("expiry_destination")]
        public string ExpiryDestination { get; set; }

        [JsonProperty("rules")]
        public GetLinkResponseRulesTypeItem[] Rules { get; set; }

        [JsonProperty("twitter_pixel_id")]
        public string XPixelId { get; set; }

        [JsonProperty("cloaking")]
        public bool Cloaking { get; set; }

        [JsonProperty("linkify_words")]
        public string LinkifyWords { get; set; }

        [JsonProperty("full_url")]
        public string ShortURL { get; set; }

        [JsonProperty("og_description")]
        public string OpenGraphDescription { get; set; }

        [JsonProperty("skip_social_crawler_tracking")]
        public bool SkipSocialCrawlerTracking { get; set; }

        [JsonProperty("body_tags")]
        public string BodyTags { get; set; }

        [JsonProperty("og_title")]
        public string OpenGraphTitle { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int LinkId { get; set; }

        [JsonProperty("gtm_id")]
        public string GoogleTagManagerId { get; set; }

        [JsonProperty("og_image")]
        public string OpenGraphImage { get; set; }

        [JsonProperty("block_bots")]
        public bool BlockBots { get; set; }

        [JsonProperty("snapchat_pixel_id")]
        public string SnapchatPixelId { get; set; }

        [JsonProperty("utm_content")]
        public string UTMContent { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("url")]
        public string DestinationURL { get; set; }

        [JsonProperty("replacements")]
        public string Replacements { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("webhooks")]
        public string[] Webhooks { get; set; }

        [JsonProperty("created_by_user_id")]
        public int CreatedByUserId { get; set; }

        [JsonProperty("expiry_clicks")]
        public int ExpiryClicks { get; set; }

        [JsonProperty("notify_slack")]
        public bool NotifySlack { get; set; }

        [JsonProperty("notify_user_ids")]
        public int[] NotifyUserIDs { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

        [JsonProperty("public_analytics")]
        public bool PublicAnalytics { get; set; }

        [JsonProperty("pinterest_tag_id")]
        public string PinterestTagId { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("utm_source")]
        public string UTMSource { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("forward_params")]
        public bool ForwardParameters { get; set; }

        [JsonProperty("utm_medium")]
        public string UTMMedium { get; set; }

        [JsonProperty("head_tags")]
        public string HeadTags { get; set; }

        [JsonProperty("ga4_tag_id")]
        public string GoogleAnalytics4TagId { get; set; }

        [JsonProperty("utm_term")]
        public string UTMTerm { get; set; }

        [JsonProperty("utm_campaign")]
        public string UTMCampaign { get; set; }
    }

    public class GetLinkResponseRulesTypeItem
    {
        [JsonProperty("matches")]
        public string Matches { get; set; }

        [JsonProperty("percentage")]
        public int Percentage { get; set; }

        [JsonProperty("url")]
        public string RuleURL { get; set; }

        [JsonProperty("what")]
        public string What { get; set; }
    }

    public class GetClicksResponse
    {
        [JsonProperty("traffic")]
        public GetClicksResponseTrafficTypeItem[] Traffic { get; set; }
    }

    public class GetClicksResponseTrafficTypeItem
    {
        [JsonProperty("t")]
        public string BucketStart { get; set; }

        [JsonProperty("y")]
        public int Clicks { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum frequencyInput
    {
        [EnumMember(Value = "day")]
        Day,
        [EnumMember(Value = "hour")]
        Hour
    }

    public class GetClickCountersResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("values")]
        public GetClickCountersResponseValuesTypeItem[] Values { get; set; }
    }

    public class GetClickCountersResponseValuesTypeItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum counterInput
    {
        [EnumMember(Value = "country")]
        Country,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "region")]
        Region,
        [EnumMember(Value = "platform")]
        Platform,
        [EnumMember(Value = "destination")]
        Destination,
        [EnumMember(Value = "referer")]
        Referer,
        [EnumMember(Value = "bot_name")]
        BotName,
        [EnumMember(Value = "isp")]
        Isp,
        [EnumMember(Value = "remote_ip")]
        RemoteIp,
        [EnumMember(Value = "top_params")]
        TopParams,
        [EnumMember(Value = "ad_network")]
        AdNetwork,
        [EnumMember(Value = "utm_source")]
        UtmSource,
        [EnumMember(Value = "utm_medium")]
        UtmMedium,
        [EnumMember(Value = "utm_campaign")]
        UtmCampaign,
        [EnumMember(Value = "utm_content")]
        UtmContent,
        [EnumMember(Value = "utm_term")]
        UtmTerm
    }

    public class ListDomainsResponse
    {
        [JsonProperty("domains")]
        public ListDomainsResponseDomainsTypeItem[] Domains { get; set; }
    }

    public class ListDomainsResponseDomainsTypeItem
    {
        [JsonProperty("name")]
        public string DomainName { get; set; }
    }

    public class ListLinksResponse
    {
        [JsonProperty("links")]
        public ListLinksResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("page_number")]
        public int PageNumber { get; set; }

        [JsonProperty("page_size")]
        public int PageSize { get; set; }

        [JsonProperty("total_entries")]
        public int TotalEntries { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_rows")]
        public int TotalRows { get; set; }

        [JsonProperty("workspace_link_count")]
        public int WorkspaceLinkCount { get; set; }
    }

    public class ListLinksResponseLinksTypeItem
    {
        [JsonProperty("fb_pixel_id")]
        public string MetaPixelId { get; set; }

        [JsonProperty("human_clicks_total")]
        public int HumanClicksTotal { get; set; }

        [JsonProperty("sparkline")]
        public int[] Sparkline { get; set; }

        [JsonProperty("clicks_thirty_days")]
        public int Clicks30Days { get; set; }

        [JsonProperty("tiktok_pixel_id")]
        public string TikTokPixelId { get; set; }

        [JsonProperty("hide_referrer")]
        public bool HideReferrer { get; set; }

        [JsonProperty("rules")]
        public ListLinksResponseLinksTypeItemRulesTypeItem[] Rules { get; set; }

        [JsonProperty("cloaking")]
        public bool Cloaking { get; set; }

        [JsonProperty("linkify_words")]
        public string LinkifyWords { get; set; }

        [JsonProperty("full_url")]
        public string ShortURL { get; set; }

        [JsonProperty("clicks_today")]
        public int ClicksToday { get; set; }

        [JsonProperty("og_description")]
        public string OpenGraphDescription { get; set; }

        [JsonProperty("body_tags")]
        public string BodyTags { get; set; }

        [JsonProperty("og_title")]
        public string OpenGraphTitle { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int LinkId { get; set; }

        [JsonProperty("gtm_id")]
        public string GoogleTagManagerId { get; set; }

        [JsonProperty("og_image")]
        public string OpenGraphImage { get; set; }

        [JsonProperty("block_bots")]
        public bool BlockBots { get; set; }

        [JsonProperty("clicks_total")]
        public int TotalClicks { get; set; }

        [JsonProperty("human_clicks_thirty_days")]
        public int HumanClicks30Days { get; set; }

        [JsonProperty("utm_content")]
        public string UTMContent { get; set; }

        [JsonProperty("human_clicks_today")]
        public int HumanClicksToday { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("url")]
        public string DestinationURL { get; set; }

        [JsonProperty("replacements")]
        public string Replacements { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

        [JsonProperty("public_analytics")]
        public bool PublicAnalytics { get; set; }

        [JsonProperty("utm_source")]
        public string UTMSource { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("forward_params")]
        public bool ForwardParameters { get; set; }

        [JsonProperty("utm_medium")]
        public string UTMMedium { get; set; }

        [JsonProperty("head_tags")]
        public string HeadTags { get; set; }

        [JsonProperty("ga4_tag_id")]
        public string GoogleAnalytics4TagId { get; set; }

        [JsonProperty("utm_term")]
        public string UTMTerm { get; set; }

        [JsonProperty("utm_campaign")]
        public string UTMCampaign { get; set; }

        [JsonProperty("human_clicks_previous_day")]
        public int HumanClicksYesterday { get; set; }
    }

    public class ListLinksResponseLinksTypeItemRulesTypeItem
    {
        [JsonProperty("matches")]
        public string Matches { get; set; }

        [JsonProperty("percentage")]
        public int Percentage { get; set; }

        [JsonProperty("url")]
        public string RuleURL { get; set; }

        [JsonProperty("what")]
        public string What { get; set; }
    }

    public class ListWorkspacesResponseItem
    {
        [JsonProperty("id")]
        public int WorkspaceId { get; set; }

        [JsonProperty("name")]
        public string WorkspaceName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Linkly;

    public partial class WorkflowManagedActions
    {
        public LinklyActions Linkly(string connectionId) => new LinklyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LinklyTriggers Linkly(string connectionId) => new LinklyTriggers(connectionId);
    }
}