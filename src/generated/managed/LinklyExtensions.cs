//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Linkly
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LinklyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<ListConversionsResponse> ListConversions([WorkflowExpression] Func<int> limit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                return callPayload;
            }

            return new ApiConnectionAction<ListConversionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<CreateConversionResponse> CreateConversion([WorkflowExpression] Func<string> bodyeventName, [WorkflowExpression] Func<int> bodyamountCents = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodycurrency = null, [WorkflowExpression] Func<string> bodyeventId = null, [WorkflowExpression] Func<bodyeventTypeInput> bodyeventType = null, [WorkflowExpression] Func<string> bodycustomerId = null, [WorkflowExpression] Func<string> bodyattributionToken = null, [WorkflowExpression] Func<string> bodyoccurredAt = null, [WorkflowExpression] Func<string> bodyvisitorIP = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyamountCents != null)
                {
                    body["amount_cents"] = SourceExpressionConverter.ConvertToken(bodyamountCents);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodycurrency != null)
                {
                    body["currency"] = SourceExpressionConverter.ConvertToken(bodycurrency);
                    bodypropCount++;
                }

                if (bodyeventId != null)
                {
                    body["event_id"] = SourceExpressionConverter.ConvertToken(bodyeventId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["event_name"] = SourceExpressionConverter.ConvertToken(bodyeventName);
                if (bodyeventType != null)
                {
                    body["event_type"] = SourceExpressionConverter.Convert(bodyeventType);
                    bodypropCount++;
                }

                if (bodycustomerId != null)
                {
                    body["external_id"] = SourceExpressionConverter.ConvertToken(bodycustomerId);
                    bodypropCount++;
                }

                if (bodyattributionToken != null)
                {
                    body["linkly_cid"] = SourceExpressionConverter.ConvertToken(bodyattributionToken);
                    bodypropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                if (bodyoccurredAt != null)
                {
                    body["occurred_at"] = SourceExpressionConverter.ConvertToken(bodyoccurredAt);
                    bodypropCount++;
                }

                if (bodyvisitorIP != null)
                {
                    body["visitor_ip"] = SourceExpressionConverter.ConvertToken(bodyvisitorIP);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateConversionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<CreateOrUpdateLinkResponse> CreateOrUpdateLink([WorkflowExpression] Func<string> bodydestinationURL = null, [WorkflowExpression] Func<int> bodylinkId = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<string> bodyslug = null, [WorkflowExpression] Func<bool> bodyenabled = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<string> bodyuTMSource = null, [WorkflowExpression] Func<string> bodyuTMMedium = null, [WorkflowExpression] Func<string> bodyuTMCampaign = null, [WorkflowExpression] Func<string> bodyuTMContent = null, [WorkflowExpression] Func<string> bodyuTMTerm = null, [WorkflowExpression] Func<string> bodymetaPixelId = null, [WorkflowExpression] Func<string> bodygoogleAnalytics4TagId = null, [WorkflowExpression] Func<string> bodygoogleTagManagerId = null, [WorkflowExpression] Func<bool> bodyblockBots = null, [WorkflowExpression] Func<string> bodybodyTags = null, [WorkflowExpression] Func<bool> bodycloaking = null, [WorkflowExpression] Func<bool> bodyforwardParameters = null, [WorkflowExpression] Func<string> bodyheadTags = null, [WorkflowExpression] Func<bool> bodyhideReferrer = null, [WorkflowExpression] Func<string> bodyopenGraphDescription = null, [WorkflowExpression] Func<string> bodyopenGraphImage = null, [WorkflowExpression] Func<string> bodyopenGraphTitle = null, [WorkflowExpression] Func<string> bodytikTokPixelId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/link";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydestinationURL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodydestinationURL);
                    bodypropCount++;
                }

                if (bodylinkId != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodylinkId);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydomain != null)
                {
                    body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                    bodypropCount++;
                }

                if (bodyslug != null)
                {
                    body["slug"] = SourceExpressionConverter.ConvertToken(bodyslug);
                    bodypropCount++;
                }

                if (bodyenabled != null)
                {
                    body["enabled"] = SourceExpressionConverter.ConvertToken(bodyenabled);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["note"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodyuTMSource != null)
                {
                    body["utm_source"] = SourceExpressionConverter.ConvertToken(bodyuTMSource);
                    bodypropCount++;
                }

                if (bodyuTMMedium != null)
                {
                    body["utm_medium"] = SourceExpressionConverter.ConvertToken(bodyuTMMedium);
                    bodypropCount++;
                }

                if (bodyuTMCampaign != null)
                {
                    body["utm_campaign"] = SourceExpressionConverter.ConvertToken(bodyuTMCampaign);
                    bodypropCount++;
                }

                if (bodyuTMContent != null)
                {
                    body["utm_content"] = SourceExpressionConverter.ConvertToken(bodyuTMContent);
                    bodypropCount++;
                }

                if (bodyuTMTerm != null)
                {
                    body["utm_term"] = SourceExpressionConverter.ConvertToken(bodyuTMTerm);
                    bodypropCount++;
                }

                if (bodymetaPixelId != null)
                {
                    body["fb_pixel_id"] = SourceExpressionConverter.ConvertToken(bodymetaPixelId);
                    bodypropCount++;
                }

                if (bodygoogleAnalytics4TagId != null)
                {
                    body["ga4_tag_id"] = SourceExpressionConverter.ConvertToken(bodygoogleAnalytics4TagId);
                    bodypropCount++;
                }

                if (bodygoogleTagManagerId != null)
                {
                    body["gtm_id"] = SourceExpressionConverter.ConvertToken(bodygoogleTagManagerId);
                    bodypropCount++;
                }

                if (bodyblockBots != null)
                {
                    body["block_bots"] = SourceExpressionConverter.ConvertToken(bodyblockBots);
                    bodypropCount++;
                }

                if (bodybodyTags != null)
                {
                    body["body_tags"] = SourceExpressionConverter.ConvertToken(bodybodyTags);
                    bodypropCount++;
                }

                if (bodycloaking != null)
                {
                    body["cloaking"] = SourceExpressionConverter.ConvertToken(bodycloaking);
                    bodypropCount++;
                }

                if (bodyforwardParameters != null)
                {
                    body["forward_params"] = SourceExpressionConverter.ConvertToken(bodyforwardParameters);
                    bodypropCount++;
                }

                if (bodyheadTags != null)
                {
                    body["head_tags"] = SourceExpressionConverter.ConvertToken(bodyheadTags);
                    bodypropCount++;
                }

                if (bodyhideReferrer != null)
                {
                    body["hide_referrer"] = SourceExpressionConverter.ConvertToken(bodyhideReferrer);
                    bodypropCount++;
                }

                if (bodyopenGraphDescription != null)
                {
                    body["og_description"] = SourceExpressionConverter.ConvertToken(bodyopenGraphDescription);
                    bodypropCount++;
                }

                if (bodyopenGraphImage != null)
                {
                    body["og_image"] = SourceExpressionConverter.ConvertToken(bodyopenGraphImage);
                    bodypropCount++;
                }

                if (bodyopenGraphTitle != null)
                {
                    body["og_title"] = SourceExpressionConverter.ConvertToken(bodyopenGraphTitle);
                    bodypropCount++;
                }

                if (bodytikTokPixelId != null)
                {
                    body["tiktok_pixel_id"] = SourceExpressionConverter.ConvertToken(bodytikTokPixelId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateOrUpdateLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<GetLinkResponse> GetLink([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/link/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<GetClicksResponse> GetClicks([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> linkId = null, [WorkflowExpression] Func<string> linkIds = null, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<string> browser = null, [WorkflowExpression] Func<string> platform = null, [WorkflowExpression] Func<string> referer = null, [WorkflowExpression] Func<string> isp = null, [WorkflowExpression] Func<bool> bots = null, [WorkflowExpression] Func<bool> unique = null, [WorkflowExpression] Func<string> timezone = null, [WorkflowExpression] Func<frequencyInput> frequency = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspace/{0}/clicks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (linkId != null)
                    callPayload.Queries["link_id"] = SourceExpressionConverter.ConvertO(linkId);
                if (linkIds != null)
                    callPayload.Queries["link_ids"] = SourceExpressionConverter.ConvertO(linkIds);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (browser != null)
                    callPayload.Queries["browser"] = SourceExpressionConverter.ConvertO(browser);
                if (platform != null)
                    callPayload.Queries["platform"] = SourceExpressionConverter.ConvertO(platform);
                if (referer != null)
                    callPayload.Queries["referer"] = SourceExpressionConverter.ConvertO(referer);
                if (isp != null)
                    callPayload.Queries["isp"] = SourceExpressionConverter.ConvertO(isp);
                if (bots != null)
                    callPayload.Queries["bots"] = SourceExpressionConverter.ConvertO(bots);
                if (unique != null)
                    callPayload.Queries["unique"] = SourceExpressionConverter.ConvertO(unique);
                if (timezone != null)
                    callPayload.Queries["timezone"] = SourceExpressionConverter.ConvertO(timezone);
                callPayload.Queries["frequency"] = Convert.ToString("day");
                if (frequency != null)
                    callPayload.Queries["frequency"] = SourceExpressionConverter.Convert(frequency);
                return callPayload;
            }

            return new ApiConnectionAction<GetClicksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<GetClickCountersResponse> GetClickCounters([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<counterInput> counter, [WorkflowExpression] Func<string> linkId = null, [WorkflowExpression] Func<string> linkIds = null, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> country = null, [WorkflowExpression] Func<bool> bots = null, [WorkflowExpression] Func<bool> unique = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspace/{0}/clicks/counters/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(counter, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (linkId != null)
                    callPayload.Queries["link_id"] = SourceExpressionConverter.ConvertO(linkId);
                if (linkIds != null)
                    callPayload.Queries["link_ids"] = SourceExpressionConverter.ConvertO(linkIds);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                if (country != null)
                    callPayload.Queries["country"] = SourceExpressionConverter.ConvertO(country);
                if (bots != null)
                    callPayload.Queries["bots"] = SourceExpressionConverter.ConvertO(bots);
                if (unique != null)
                    callPayload.Queries["unique"] = SourceExpressionConverter.ConvertO(unique);
                return callPayload;
            }

            return new ApiConnectionAction<GetClickCountersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<ListDomainsResponse> ListDomains([WorkflowExpression] Func<string> workspaceId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspace/{0}/domains", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListDomainsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<string> DeleteLink([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspace/{0}/links/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<ListLinksResponse> ListLinks([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null, [WorkflowExpression] Func<string> sortBy = null, [WorkflowExpression] Func<string> sortDir = null, [WorkflowExpression] Func<bool> deleted = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workspace/{0}/list_links", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["page_size"] = Convert.ToString(1000);
                if (pageSize != null)
                    callPayload.Queries["page_size"] = SourceExpressionConverter.ConvertO(pageSize);
                if (sortBy != null)
                    callPayload.Queries["sort_by"] = SourceExpressionConverter.ConvertO(sortBy);
                if (sortDir != null)
                    callPayload.Queries["sort_dir"] = SourceExpressionConverter.ConvertO(sortDir);
                callPayload.Queries["deleted"] = Convert.ToString(false);
                if (deleted != null)
                    callPayload.Queries["deleted"] = SourceExpressionConverter.ConvertO(deleted);
                return callPayload;
            }

            return new ApiConnectionAction<ListLinksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "linkly")]
        public IBodyWorkflowAction<ListWorkspacesResponseItem[]> ListWorkspaces()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workspaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListWorkspacesResponseItem[]>(BuildSourceInput);
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
        public string ClickID { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("event_id")]
        public string EventID { get; set; }

        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("external_id")]
        public string CustomerID { get; set; }

        [JsonProperty("id")]
        public string ConversionID { get; set; }

        [JsonProperty("inserted_at")]
        public string InsertedAt { get; set; }

        [JsonProperty("ip_source")]
        public ListConversionsResponseConversionsTypeItemIPSourceType IPSource { get; set; }

        [JsonProperty("link_id")]
        public int LinkID { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("occurred_at")]
        public string OccurredAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

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
        public string ClickID { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("event_id")]
        public string EventID { get; set; }

        [JsonProperty("event_name")]
        public string EventName { get; set; }

        [JsonProperty("event_type")]
        public string EventType { get; set; }

        [JsonProperty("external_id")]
        public string CustomerID { get; set; }

        [JsonProperty("id")]
        public string ConversionID { get; set; }

        [JsonProperty("inserted_at")]
        public string InsertedAt { get; set; }

        [JsonProperty("ip_source")]
        public CreateConversionResponseIPSourceType IPSource { get; set; }

        [JsonProperty("link_id")]
        public int LinkID { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("occurred_at")]
        public string OccurredAt { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public enum CreateConversionResponseIPSourceType
    {
        [EnumMember(Value = "visitor")]
        Visitor,
        [EnumMember(Value = "server")]
        Server,
        [EnumMember(Value = "unknown")]
        Unknown
    }

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
        public string MetaPixelID { get; set; }

        [JsonProperty("linkedin_partner_id")]
        public string LinkedInPartnerID { get; set; }

        [JsonProperty("microsoft_uet_tag_id")]
        public string MicrosoftUETTagID { get; set; }

        [JsonProperty("reddit_pixel_id")]
        public string RedditPixelID { get; set; }

        [JsonProperty("tiktok_pixel_id")]
        public string TikTokPixelID { get; set; }

        [JsonProperty("hide_referrer")]
        public bool HideReferrer { get; set; }

        [JsonProperty("expiry_datetime")]
        public string ExpiryDate { get; set; }

        [JsonProperty("expiry_destination")]
        public string ExpiryDestination { get; set; }

        [JsonProperty("rules")]
        public CreateOrUpdateLinkResponseRulesTypeItem[] Rules { get; set; }

        [JsonProperty("twitter_pixel_id")]
        public string XPixelID { get; set; }

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
        public int LinkID { get; set; }

        [JsonProperty("gtm_id")]
        public string GoogleTagManagerID { get; set; }

        [JsonProperty("og_image")]
        public string OpenGraphImage { get; set; }

        [JsonProperty("block_bots")]
        public bool BlockBots { get; set; }

        [JsonProperty("snapchat_pixel_id")]
        public string SnapchatPixelID { get; set; }

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
        public int CreatedByUserID { get; set; }

        [JsonProperty("expiry_clicks")]
        public int ExpiryClicks { get; set; }

        [JsonProperty("notify_slack")]
        public bool NotifySlack { get; set; }

        [JsonProperty("notify_user_ids")]
        public int[] NotifyUserIDs { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceID { get; set; }

        [JsonProperty("public_analytics")]
        public bool PublicAnalytics { get; set; }

        [JsonProperty("pinterest_tag_id")]
        public string PinterestTagID { get; set; }

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
        public string GoogleAnalytics4TagID { get; set; }

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
        public string MetaPixelID { get; set; }

        [JsonProperty("linkedin_partner_id")]
        public string LinkedInPartnerID { get; set; }

        [JsonProperty("microsoft_uet_tag_id")]
        public string MicrosoftUETTagID { get; set; }

        [JsonProperty("reddit_pixel_id")]
        public string RedditPixelID { get; set; }

        [JsonProperty("tiktok_pixel_id")]
        public string TikTokPixelID { get; set; }

        [JsonProperty("hide_referrer")]
        public bool HideReferrer { get; set; }

        [JsonProperty("expiry_datetime")]
        public string ExpiryDate { get; set; }

        [JsonProperty("expiry_destination")]
        public string ExpiryDestination { get; set; }

        [JsonProperty("rules")]
        public GetLinkResponseRulesTypeItem[] Rules { get; set; }

        [JsonProperty("twitter_pixel_id")]
        public string XPixelID { get; set; }

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
        public int LinkID { get; set; }

        [JsonProperty("gtm_id")]
        public string GoogleTagManagerID { get; set; }

        [JsonProperty("og_image")]
        public string OpenGraphImage { get; set; }

        [JsonProperty("block_bots")]
        public bool BlockBots { get; set; }

        [JsonProperty("snapchat_pixel_id")]
        public string SnapchatPixelID { get; set; }

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
        public int CreatedByUserID { get; set; }

        [JsonProperty("expiry_clicks")]
        public int ExpiryClicks { get; set; }

        [JsonProperty("notify_slack")]
        public bool NotifySlack { get; set; }

        [JsonProperty("notify_user_ids")]
        public int[] NotifyUserIDs { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceID { get; set; }

        [JsonProperty("public_analytics")]
        public bool PublicAnalytics { get; set; }

        [JsonProperty("pinterest_tag_id")]
        public string PinterestTagID { get; set; }

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
        public string GoogleAnalytics4TagID { get; set; }

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
        public string MetaPixelID { get; set; }

        [JsonProperty("human_clicks_total")]
        public int HumanClicksTotal { get; set; }

        [JsonProperty("sparkline")]
        public int[] Sparkline { get; set; }

        [JsonProperty("clicks_thirty_days")]
        public int Clicks30Days { get; set; }

        [JsonProperty("tiktok_pixel_id")]
        public string TikTokPixelID { get; set; }

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
        public int LinkID { get; set; }

        [JsonProperty("gtm_id")]
        public string GoogleTagManagerID { get; set; }

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
        public int WorkspaceID { get; set; }

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
        public string GoogleAnalytics4TagID { get; set; }

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
        public int WorkspaceID { get; set; }

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