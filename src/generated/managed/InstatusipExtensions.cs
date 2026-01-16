//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Instatusip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InstatusipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PagesGetResponseItem[]> PagesGet(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = "/v2/pages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<PagesGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PagePostResponse> PagePost(Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodysubdomain = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodylogoUrl = null, Expression<Func<string>> bodyfaviconUrl = null, Expression<Func<string>> bodywebsiteUrl = null, Expression<Func<string>> bodylanguage = null, Expression<Func<bool>> bodyuseLargeHeader = null, Expression<Func<string>> bodybrandColor = null, Expression<Func<string>> bodyokColor = null, Expression<Func<string>> bodydisruptedColor = null, Expression<Func<string>> bodydegradedColor = null, Expression<Func<string>> bodydownColor = null, Expression<Func<string>> bodynoticeColor = null, Expression<Func<string>> bodyunknownColor = null, Expression<Func<string>> bodygoogleAnalytics = null, Expression<Func<bool>> bodysubscribeBySms = null, Expression<Func<string>> bodysmsService = null, Expression<Func<string>> bodytwilioSid = null, Expression<Func<string>> bodytwilioToken = null, Expression<Func<string>> bodytwilioSender = null, Expression<Func<string>> bodyhtmlInMeta = null, Expression<Func<string>> bodyhtmlAboveHeader = null, Expression<Func<string>> bodyhtmlBelowHeader = null, Expression<Func<string>> bodyhtmlAboveFooter = null, Expression<Func<string>> bodyhtmlBelowFooter = null, Expression<Func<string>> bodyhtmlBelowSummary = null, Expression<Func<string>> bodycssGlobal = null, Expression<Func<string>> bodylaunchDate = null, Expression<Func<string>> bodydateFormat = null, Expression<Func<string>> bodydateFormatShort = null, Expression<Func<string>> bodytimeFormat = null)
        {
            var apiCallPath = "/v1/pages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodysubdomain != null)
            {
                body["subdomain"] = ExpressionConverter.ConvertO(bodysubdomain);
                bodypropCount++;
            }

            if (bodycomponents != null)
            {
                body["components"] = ExpressionConverter.ConvertO(bodycomponents);
                bodypropCount++;
            }

            if (bodylogoUrl != null)
            {
                body["logoUrl"] = ExpressionConverter.ConvertO(bodylogoUrl);
                bodypropCount++;
            }

            if (bodyfaviconUrl != null)
            {
                body["faviconUrl"] = ExpressionConverter.ConvertO(bodyfaviconUrl);
                bodypropCount++;
            }

            if (bodywebsiteUrl != null)
            {
                body["websiteUrl"] = ExpressionConverter.ConvertO(bodywebsiteUrl);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodyuseLargeHeader != null)
            {
                body["useLargeHeader"] = ExpressionConverter.ConvertO(bodyuseLargeHeader);
                bodypropCount++;
            }

            if (bodybrandColor != null)
            {
                body["brandColor"] = ExpressionConverter.ConvertO(bodybrandColor);
                bodypropCount++;
            }

            if (bodyokColor != null)
            {
                body["okColor"] = ExpressionConverter.ConvertO(bodyokColor);
                bodypropCount++;
            }

            if (bodydisruptedColor != null)
            {
                body["disruptedColor"] = ExpressionConverter.ConvertO(bodydisruptedColor);
                bodypropCount++;
            }

            if (bodydegradedColor != null)
            {
                body["degradedColor"] = ExpressionConverter.ConvertO(bodydegradedColor);
                bodypropCount++;
            }

            if (bodydownColor != null)
            {
                body["downColor"] = ExpressionConverter.ConvertO(bodydownColor);
                bodypropCount++;
            }

            if (bodynoticeColor != null)
            {
                body["noticeColor"] = ExpressionConverter.ConvertO(bodynoticeColor);
                bodypropCount++;
            }

            if (bodyunknownColor != null)
            {
                body["unknownColor"] = ExpressionConverter.ConvertO(bodyunknownColor);
                bodypropCount++;
            }

            if (bodygoogleAnalytics != null)
            {
                body["googleAnalytics"] = ExpressionConverter.ConvertO(bodygoogleAnalytics);
                bodypropCount++;
            }

            if (bodysubscribeBySms != null)
            {
                body["subscribeBySms"] = ExpressionConverter.ConvertO(bodysubscribeBySms);
                bodypropCount++;
            }

            if (bodysmsService != null)
            {
                body["smsService"] = ExpressionConverter.ConvertO(bodysmsService);
                bodypropCount++;
            }

            if (bodytwilioSid != null)
            {
                body["twilioSid"] = ExpressionConverter.ConvertO(bodytwilioSid);
                bodypropCount++;
            }

            if (bodytwilioToken != null)
            {
                body["twilioToken"] = ExpressionConverter.ConvertO(bodytwilioToken);
                bodypropCount++;
            }

            if (bodytwilioSender != null)
            {
                body["twilioSender"] = ExpressionConverter.ConvertO(bodytwilioSender);
                bodypropCount++;
            }

            if (bodyhtmlInMeta != null)
            {
                body["htmlInMeta"] = ExpressionConverter.ConvertO(bodyhtmlInMeta);
                bodypropCount++;
            }

            if (bodyhtmlAboveHeader != null)
            {
                body["htmlAboveHeader"] = ExpressionConverter.ConvertO(bodyhtmlAboveHeader);
                bodypropCount++;
            }

            if (bodyhtmlBelowHeader != null)
            {
                body["htmlBelowHeader"] = ExpressionConverter.ConvertO(bodyhtmlBelowHeader);
                bodypropCount++;
            }

            if (bodyhtmlAboveFooter != null)
            {
                body["htmlAboveFooter"] = ExpressionConverter.ConvertO(bodyhtmlAboveFooter);
                bodypropCount++;
            }

            if (bodyhtmlBelowFooter != null)
            {
                body["htmlBelowFooter"] = ExpressionConverter.ConvertO(bodyhtmlBelowFooter);
                bodypropCount++;
            }

            if (bodyhtmlBelowSummary != null)
            {
                body["htmlBelowSummary"] = ExpressionConverter.ConvertO(bodyhtmlBelowSummary);
                bodypropCount++;
            }

            if (bodycssGlobal != null)
            {
                body["cssGlobal"] = ExpressionConverter.ConvertO(bodycssGlobal);
                bodypropCount++;
            }

            if (bodylaunchDate != null)
            {
                body["launchDate"] = ExpressionConverter.ConvertO(bodylaunchDate);
                bodypropCount++;
            }

            if (bodydateFormat != null)
            {
                body["dateFormat"] = ExpressionConverter.ConvertO(bodydateFormat);
                bodypropCount++;
            }

            if (bodydateFormatShort != null)
            {
                body["dateFormatShort"] = ExpressionConverter.ConvertO(bodydateFormatShort);
                bodypropCount++;
            }

            if (bodytimeFormat != null)
            {
                body["timeFormat"] = ExpressionConverter.ConvertO(bodytimeFormat);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PagePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PageDeleteResponse> PageDelete(Expression<Func<string>> pageId)
        {
            var apiCallPath = String.Format("/v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PageDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PagePutResponse> PagePut(Expression<Func<string>> pageId, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodysubdomain = null, Expression<Func<string>> bodylogoUrl = null, Expression<Func<string>> bodyfaviconUrl = null, Expression<Func<string>> bodywebsiteUrl = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodypublicEmail = null, Expression<Func<bool>> bodyuseLargeHeader = null, Expression<Func<string>> bodybrandColor = null, Expression<Func<string>> bodyokColor = null, Expression<Func<string>> bodydisruptedColor = null, Expression<Func<string>> bodydegradedColor = null, Expression<Func<string>> bodydownColor = null, Expression<Func<string>> bodynoticeColor = null, Expression<Func<string>> bodyunknownColor = null, Expression<Func<string>> bodygoogleAnalytics = null, Expression<Func<bool>> bodysubscribeBySms = null, Expression<Func<string>> bodysmsService = null, Expression<Func<string>> bodytwilioSid = null, Expression<Func<string>> bodytwilioToken = null, Expression<Func<string>> bodytwilioSender = null, Expression<Func<string>> bodyhtmlInMeta = null, Expression<Func<string>> bodyhtmlAboveHeader = null, Expression<Func<string>> bodyhtmlBelowHeader = null, Expression<Func<string>> bodyhtmlAboveFooter = null, Expression<Func<string>> bodyhtmlBelowFooter = null, Expression<Func<string>> bodyhtmlBelowSummary = null, Expression<Func<string>> bodycssGlobal = null, Expression<Func<string>> bodylaunchDate = null, Expression<Func<string>> bodydateFormat = null, Expression<Func<string>> bodydateFormatShort = null, Expression<Func<string>> bodytimeFormat = null, Expression<Func<bool>> bodyprivate = null, Expression<Func<bool>> bodyuseAllowList = null)
        {
            var apiCallPath = String.Format("/v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
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

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodysubdomain != null)
            {
                body["subdomain"] = ExpressionConverter.ConvertO(bodysubdomain);
                bodypropCount++;
            }

            if (bodylogoUrl != null)
            {
                body["logoUrl"] = ExpressionConverter.ConvertO(bodylogoUrl);
                bodypropCount++;
            }

            if (bodyfaviconUrl != null)
            {
                body["faviconUrl"] = ExpressionConverter.ConvertO(bodyfaviconUrl);
                bodypropCount++;
            }

            if (bodywebsiteUrl != null)
            {
                body["websiteUrl"] = ExpressionConverter.ConvertO(bodywebsiteUrl);
                bodypropCount++;
            }

            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodypublicEmail != null)
            {
                body["publicEmail"] = ExpressionConverter.ConvertO(bodypublicEmail);
                bodypropCount++;
            }

            if (bodyuseLargeHeader != null)
            {
                body["useLargeHeader"] = ExpressionConverter.ConvertO(bodyuseLargeHeader);
                bodypropCount++;
            }

            if (bodybrandColor != null)
            {
                body["brandColor"] = ExpressionConverter.ConvertO(bodybrandColor);
                bodypropCount++;
            }

            if (bodyokColor != null)
            {
                body["okColor"] = ExpressionConverter.ConvertO(bodyokColor);
                bodypropCount++;
            }

            if (bodydisruptedColor != null)
            {
                body["disruptedColor"] = ExpressionConverter.ConvertO(bodydisruptedColor);
                bodypropCount++;
            }

            if (bodydegradedColor != null)
            {
                body["degradedColor"] = ExpressionConverter.ConvertO(bodydegradedColor);
                bodypropCount++;
            }

            if (bodydownColor != null)
            {
                body["downColor"] = ExpressionConverter.ConvertO(bodydownColor);
                bodypropCount++;
            }

            if (bodynoticeColor != null)
            {
                body["noticeColor"] = ExpressionConverter.ConvertO(bodynoticeColor);
                bodypropCount++;
            }

            if (bodyunknownColor != null)
            {
                body["unknownColor"] = ExpressionConverter.ConvertO(bodyunknownColor);
                bodypropCount++;
            }

            if (bodygoogleAnalytics != null)
            {
                body["googleAnalytics"] = ExpressionConverter.ConvertO(bodygoogleAnalytics);
                bodypropCount++;
            }

            if (bodysubscribeBySms != null)
            {
                body["subscribeBySms"] = ExpressionConverter.ConvertO(bodysubscribeBySms);
                bodypropCount++;
            }

            if (bodysmsService != null)
            {
                body["smsService"] = ExpressionConverter.ConvertO(bodysmsService);
                bodypropCount++;
            }

            if (bodytwilioSid != null)
            {
                body["twilioSid"] = ExpressionConverter.ConvertO(bodytwilioSid);
                bodypropCount++;
            }

            if (bodytwilioToken != null)
            {
                body["twilioToken"] = ExpressionConverter.ConvertO(bodytwilioToken);
                bodypropCount++;
            }

            if (bodytwilioSender != null)
            {
                body["twilioSender"] = ExpressionConverter.ConvertO(bodytwilioSender);
                bodypropCount++;
            }

            if (bodyhtmlInMeta != null)
            {
                body["htmlInMeta"] = ExpressionConverter.ConvertO(bodyhtmlInMeta);
                bodypropCount++;
            }

            if (bodyhtmlAboveHeader != null)
            {
                body["htmlAboveHeader"] = ExpressionConverter.ConvertO(bodyhtmlAboveHeader);
                bodypropCount++;
            }

            if (bodyhtmlBelowHeader != null)
            {
                body["htmlBelowHeader"] = ExpressionConverter.ConvertO(bodyhtmlBelowHeader);
                bodypropCount++;
            }

            if (bodyhtmlAboveFooter != null)
            {
                body["htmlAboveFooter"] = ExpressionConverter.ConvertO(bodyhtmlAboveFooter);
                bodypropCount++;
            }

            if (bodyhtmlBelowFooter != null)
            {
                body["htmlBelowFooter"] = ExpressionConverter.ConvertO(bodyhtmlBelowFooter);
                bodypropCount++;
            }

            if (bodyhtmlBelowSummary != null)
            {
                body["htmlBelowSummary"] = ExpressionConverter.ConvertO(bodyhtmlBelowSummary);
                bodypropCount++;
            }

            if (bodycssGlobal != null)
            {
                body["cssGlobal"] = ExpressionConverter.ConvertO(bodycssGlobal);
                bodypropCount++;
            }

            if (bodylaunchDate != null)
            {
                body["launchDate"] = ExpressionConverter.ConvertO(bodylaunchDate);
                bodypropCount++;
            }

            if (bodydateFormat != null)
            {
                body["dateFormat"] = ExpressionConverter.ConvertO(bodydateFormat);
                bodypropCount++;
            }

            if (bodydateFormatShort != null)
            {
                body["dateFormatShort"] = ExpressionConverter.ConvertO(bodydateFormatShort);
                bodypropCount++;
            }

            if (bodytimeFormat != null)
            {
                body["timeFormat"] = ExpressionConverter.ConvertO(bodytimeFormat);
                bodypropCount++;
            }

            if (bodyprivate != null)
            {
                body["private"] = ExpressionConverter.ConvertO(bodyprivate);
                bodypropCount++;
            }

            if (bodyuseAllowList != null)
            {
                body["useAllowList"] = ExpressionConverter.ConvertO(bodyuseAllowList);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<PagePutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentsGetResponseItem[]> ComponentsGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = String.Format("/v1/{0}/components", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<ComponentsGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentPostResponse> ComponentPost(Expression<Func<string>> pageId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodyorder = null, Expression<Func<bool>> bodyshowUptime = null, Expression<Func<bool>> bodygrouped = null)
        {
            var apiCallPath = String.Format("/v1/{0}/components", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyorder != null)
            {
                body["order"] = ExpressionConverter.ConvertO(bodyorder);
                bodypropCount++;
            }

            if (bodyshowUptime != null)
            {
                body["showUptime"] = ExpressionConverter.ConvertO(bodyshowUptime);
                bodypropCount++;
            }

            if (bodygrouped != null)
            {
                body["grouped"] = ExpressionConverter.ConvertO(bodygrouped);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ComponentPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentGetResponse> ComponentGet(Expression<Func<string>> pageId, Expression<Func<string>> componentId)
        {
            var apiCallPath = String.Format("/v1/{0}/components/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(componentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ComponentGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentDeleteResponse> ComponentDelete(Expression<Func<string>> pageId, Expression<Func<string>> componentId)
        {
            var apiCallPath = String.Format("/v1/{0}/components/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(componentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ComponentDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentPutResponse> ComponentPut(Expression<Func<string>> pageId, Expression<Func<string>> componentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodyorder = null, Expression<Func<bool>> bodyshowUptime = null, Expression<Func<bool>> bodygrouped = null)
        {
            var apiCallPath = String.Format("/v1/{0}/components/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(componentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyorder != null)
            {
                body["order"] = ExpressionConverter.ConvertO(bodyorder);
                bodypropCount++;
            }

            if (bodyshowUptime != null)
            {
                body["showUptime"] = ExpressionConverter.ConvertO(bodyshowUptime);
                bodypropCount++;
            }

            if (bodygrouped != null)
            {
                body["grouped"] = ExpressionConverter.ConvertO(bodygrouped);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ComponentPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentsGetResponseItem[]> IncidentsGet(Expression<Func<string>> pageId, Expression<Func<string>> status = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = String.Format("/v1/{0}/incidents", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<IncidentsGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentPostResponse> IncidentPost(Expression<Func<string>> pageId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystarted = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var apiCallPath = String.Format("/v1/{0}/incidents", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodycomponents != null)
            {
                body["components"] = ExpressionConverter.ConvertO(bodycomponents);
                bodypropCount++;
            }

            if (bodystarted != null)
            {
                body["started"] = ExpressionConverter.ConvertO(bodystarted);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodynotify != null)
            {
                body["notify"] = ExpressionConverter.ConvertO(bodynotify);
                bodypropCount++;
            }

            if (bodystatuses != null)
            {
                body["statuses"] = ExpressionConverter.ConvertO(bodystatuses);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IncidentPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentGetResponse> IncidentGet(Expression<Func<string>> pageId, Expression<Func<string>> incidentId)
        {
            var apiCallPath = String.Format("/v1/{0}/incidents/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IncidentGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentDeleteResponse> IncidentDelete(Expression<Func<string>> pageId, Expression<Func<string>> incidentId)
        {
            var apiCallPath = String.Format("/v1/{0}/incidents/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IncidentDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentPutResponse> IncidentPut(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> bodyname = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystarted = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var apiCallPath = String.Format("/v1/{0}/incidents/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodycomponents != null)
            {
                body["components"] = ExpressionConverter.ConvertO(bodycomponents);
                bodypropCount++;
            }

            if (bodystarted != null)
            {
                body["started"] = ExpressionConverter.ConvertO(bodystarted);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodynotify != null)
            {
                body["notify"] = ExpressionConverter.ConvertO(bodynotify);
                bodypropCount++;
            }

            if (bodystatuses != null)
            {
                body["statuses"] = ExpressionConverter.ConvertO(bodystatuses);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IncidentPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentTemplatePostResponse> IncidentTemplatePost(Expression<Func<string>> pageId, Expression<Func<string>> template)
        {
            var apiCallPath = String.Format("/v2/{0}/incidents/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(template, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IncidentTemplatePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdateGetResponse> IncidentUpdateGet(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> incidentUpdateId)
        {
            var apiCallPath = String.Format("/v1/{0}/incidents/{1}/incident-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentUpdateId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IncidentUpdateGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdateDeleteResponse> IncidentUpdateDelete(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> incidentUpdateId)
        {
            var apiCallPath = String.Format("/v1/{0}/incidents/{1}/incident-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentUpdateId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IncidentUpdateDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdatePutResponse> IncidentUpdatePut(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> incidentUpdateId, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystarted = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var apiCallPath = String.Format("/v1/{0}/incidents/{1}/incident-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentUpdateId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodycomponents != null)
            {
                body["components"] = ExpressionConverter.ConvertO(bodycomponents);
                bodypropCount++;
            }

            if (bodystarted != null)
            {
                body["started"] = ExpressionConverter.ConvertO(bodystarted);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodynotify != null)
            {
                body["notify"] = ExpressionConverter.ConvertO(bodynotify);
                bodypropCount++;
            }

            if (bodystatuses != null)
            {
                body["statuses"] = ExpressionConverter.ConvertO(bodystatuses);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IncidentUpdatePutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdatePostResponse> IncidentUpdatePost(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystarted = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var apiCallPath = String.Format("/v1/{0}/incidents/{1}/incident-updates", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodycomponents != null)
            {
                body["components"] = ExpressionConverter.ConvertO(bodycomponents);
                bodypropCount++;
            }

            if (bodystarted != null)
            {
                body["started"] = ExpressionConverter.ConvertO(bodystarted);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodynotify != null)
            {
                body["notify"] = ExpressionConverter.ConvertO(bodynotify);
                bodypropCount++;
            }

            if (bodystatuses != null)
            {
                body["statuses"] = ExpressionConverter.ConvertO(bodystatuses);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IncidentUpdatePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdateTemplatePostResponse> IncidentUpdateTemplatePost(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> template)
        {
            var apiCallPath = String.Format("/v2/{0}/incidents/{1}/incident-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1), ExpressionConverter.ConvertWithUrlEncoding(template, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<IncidentUpdateTemplatePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenancesGetResponseItem[]> MaintenancesGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = String.Format("/v1/{0}/maintenances", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<MaintenancesGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenancePostResponse> MaintenancePost(Expression<Func<string>> pageId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodyend = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<int>> bodyduration = null, Expression<Func<bool>> bodynotifyStart = null, Expression<Func<bool>> bodynotifyEnd = null, Expression<Func<bool>> bodynotifyEarly = null, Expression<Func<int>> bodynotifyMinutes = null, Expression<Func<bool>> bodyautoStart = null, Expression<Func<bool>> bodyautoEnd = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var apiCallPath = String.Format("/v1/{0}/maintenances", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodycomponents != null)
            {
                body["components"] = ExpressionConverter.ConvertO(bodycomponents);
                bodypropCount++;
            }

            if (bodystart != null)
            {
                body["start"] = ExpressionConverter.ConvertO(bodystart);
                bodypropCount++;
            }

            if (bodyend != null)
            {
                body["end"] = ExpressionConverter.ConvertO(bodyend);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodynotify != null)
            {
                body["notify"] = ExpressionConverter.ConvertO(bodynotify);
                bodypropCount++;
            }

            if (bodyduration != null)
            {
                body["duration"] = ExpressionConverter.ConvertO(bodyduration);
                bodypropCount++;
            }

            if (bodynotifyStart != null)
            {
                body["notifyStart"] = ExpressionConverter.ConvertO(bodynotifyStart);
                bodypropCount++;
            }

            if (bodynotifyEnd != null)
            {
                body["notifyEnd"] = ExpressionConverter.ConvertO(bodynotifyEnd);
                bodypropCount++;
            }

            if (bodynotifyEarly != null)
            {
                body["notifyEarly"] = ExpressionConverter.ConvertO(bodynotifyEarly);
                bodypropCount++;
            }

            if (bodynotifyMinutes != null)
            {
                body["notifyMinutes"] = ExpressionConverter.ConvertO(bodynotifyMinutes);
                bodypropCount++;
            }

            if (bodyautoStart != null)
            {
                body["autoStart"] = ExpressionConverter.ConvertO(bodyautoStart);
                bodypropCount++;
            }

            if (bodyautoEnd != null)
            {
                body["autoEnd"] = ExpressionConverter.ConvertO(bodyautoEnd);
                bodypropCount++;
            }

            if (bodystatuses != null)
            {
                body["statuses"] = ExpressionConverter.ConvertO(bodystatuses);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MaintenancePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceGetResponse> MaintenanceGet(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId)
        {
            var apiCallPath = String.Format("/v1/{0}/maintenances/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MaintenanceGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceDeleteResponse> MaintenanceDelete(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId)
        {
            var apiCallPath = String.Format("/v1/{0}/maintenances/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MaintenanceDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenancePutResponse> MaintenancePut(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodyend = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var apiCallPath = String.Format("/v1/{0}/maintenances/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodycomponents != null)
            {
                body["components"] = ExpressionConverter.ConvertO(bodycomponents);
                bodypropCount++;
            }

            if (bodystart != null)
            {
                body["start"] = ExpressionConverter.ConvertO(bodystart);
                bodypropCount++;
            }

            if (bodyend != null)
            {
                body["end"] = ExpressionConverter.ConvertO(bodyend);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodynotify != null)
            {
                body["notify"] = ExpressionConverter.ConvertO(bodynotify);
                bodypropCount++;
            }

            if (bodystatuses != null)
            {
                body["statuses"] = ExpressionConverter.ConvertO(bodystatuses);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MaintenancePutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdateGetResponse> MaintenanceUpdateGet(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<string>> maintenanceUpdateId)
        {
            var apiCallPath = String.Format("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceUpdateId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MaintenanceUpdateGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdateDeleteResponse> MaintenanceUpdateDelete(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<string>> maintenanceUpdateId)
        {
            var apiCallPath = String.Format("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceUpdateId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MaintenanceUpdateDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdatePutResponse> MaintenanceUpdatePut(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<string>> maintenanceUpdateId, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystarted = null, Expression<Func<string>> bodyend = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var apiCallPath = String.Format("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceUpdateId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodycomponents != null)
            {
                body["components"] = ExpressionConverter.ConvertO(bodycomponents);
                bodypropCount++;
            }

            if (bodystarted != null)
            {
                body["started"] = ExpressionConverter.ConvertO(bodystarted);
                bodypropCount++;
            }

            if (bodyend != null)
            {
                body["end"] = ExpressionConverter.ConvertO(bodyend);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodynotify != null)
            {
                body["notify"] = ExpressionConverter.ConvertO(bodynotify);
                bodypropCount++;
            }

            if (bodystatuses != null)
            {
                body["statuses"] = ExpressionConverter.ConvertO(bodystatuses);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MaintenanceUpdatePutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdatePostResponse> MaintenanceUpdatePost(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystarted = null, Expression<Func<string>> bodyend = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var apiCallPath = String.Format("/v1/{0}/maintenances/{1}/maintenance-updates", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodycomponents != null)
            {
                body["components"] = ExpressionConverter.ConvertO(bodycomponents);
                bodypropCount++;
            }

            if (bodystarted != null)
            {
                body["started"] = ExpressionConverter.ConvertO(bodystarted);
                bodypropCount++;
            }

            if (bodyend != null)
            {
                body["end"] = ExpressionConverter.ConvertO(bodyend);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodynotify != null)
            {
                body["notify"] = ExpressionConverter.ConvertO(bodynotify);
                bodypropCount++;
            }

            if (bodystatuses != null)
            {
                body["statuses"] = ExpressionConverter.ConvertO(bodystatuses);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MaintenanceUpdatePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PageTemplatesGetResponseItem[]> PageTemplatesGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = String.Format("/v1/{0}/templates", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<PageTemplatesGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplatePostResponse> TemplatePost(Expression<Func<string>> pageId, Expression<Func<string>> bodysubdomain = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodycomponentsInputItem[]>> bodycomponents = null)
        {
            var apiCallPath = String.Format("/v1/{0}/templates", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysubdomain != null)
            {
                body["subdomain"] = ExpressionConverter.ConvertO(bodysubdomain);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodynotify != null)
            {
                body["notify"] = ExpressionConverter.ConvertO(bodynotify);
                bodypropCount++;
            }

            if (bodycomponents != null)
            {
                body["components"] = ExpressionConverter.ConvertO(bodycomponents);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TemplatePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet(Expression<Func<string>> pageId, Expression<Func<string>> templateId)
        {
            var apiCallPath = String.Format("/v1/{0}/templates/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TemplateGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplateDeleteResponse> TemplateDelete(Expression<Func<string>> pageId, Expression<Func<string>> templateId)
        {
            var apiCallPath = String.Format("/v1/{0}/templates/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TemplateDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplatePutResponse> TemplatePut(Expression<Func<string>> pageId, Expression<Func<string>> templateId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodycomponentsInputItem[]>> bodycomponents = null)
        {
            var apiCallPath = String.Format("/v1/{0}/templates/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodynotify != null)
            {
                body["notify"] = ExpressionConverter.ConvertO(bodynotify);
                bodypropCount++;
            }

            if (bodycomponents != null)
            {
                body["components"] = ExpressionConverter.ConvertO(bodycomponents);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<TemplatePutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TeammatesGetResponseItem[]> TeammatesGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = String.Format("/v1/{0}/team", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<TeammatesGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<string> TeamMemberPost(Expression<Func<string>> pageId, Expression<Func<string>> bodyemail = null)
        {
            var apiCallPath = String.Format("/v1/{0}/team", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<string> TeamMemberDelete(Expression<Func<string>> pageId, Expression<Func<string>> memberId)
        {
            var apiCallPath = String.Format("/v1/{0}/team/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<SubscribersGetResponseItem[]> SubscribersGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = String.Format("/v1/{0}/subscribers", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<SubscribersGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<SubscriberPostResponse> SubscriberPost(Expression<Func<string>> pageId, Expression<Func<string>> bodyemail = null, Expression<Func<bool>> bodyall = null, Expression<Func<bool>> bodyautoConfirm = null)
        {
            var apiCallPath = String.Format("/v1/{0}/subscribers", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyall != null)
            {
                body["all"] = ExpressionConverter.ConvertO(bodyall);
                bodypropCount++;
            }

            if (bodyautoConfirm != null)
            {
                body["autoConfirm"] = ExpressionConverter.ConvertO(bodyautoConfirm);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SubscriberPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<string> SubscriberDelete(Expression<Func<string>> pageId, Expression<Func<string>> subscriberId)
        {
            var apiCallPath = String.Format("/v1/{0}/subscribers/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(subscriberId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class InstatusipTriggers([ConnectionName] string connectionId)
    {
    }

    public class PagesGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("faviconUrl")]
        public string FaviconUrl { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("customDomain")]
        public string CustomDomain { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subscribeBySms")]
        public bool SubscribeBySms { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("useLargeHeader")]
        public bool UseLargeHeader { get; set; }

        [JsonProperty("brandColor")]
        public string BrandColor { get; set; }

        [JsonProperty("okColor")]
        public string OkColor { get; set; }

        [JsonProperty("disruptedColor")]
        public string DisruptedColor { get; set; }

        [JsonProperty("degradedColor")]
        public string DegradedColor { get; set; }

        [JsonProperty("downColor")]
        public string DownColor { get; set; }

        [JsonProperty("noticeColor")]
        public string NoticeColor { get; set; }

        [JsonProperty("unknownColor")]
        public string UnknownColor { get; set; }

        [JsonProperty("googleAnalytics")]
        public string GoogleAnalytics { get; set; }

        [JsonProperty("smsService")]
        public string SmsService { get; set; }

        [JsonProperty("htmlInMeta")]
        public string HtmlInMeta { get; set; }

        [JsonProperty("htmlAboveHeader")]
        public string HtmlAboveHeader { get; set; }

        [JsonProperty("htmlBelowHeader")]
        public string HtmlBelowHeader { get; set; }

        [JsonProperty("htmlAboveFooter")]
        public string HtmlAboveFooter { get; set; }

        [JsonProperty("htmlBelowFooter")]
        public string HtmlBelowFooter { get; set; }

        [JsonProperty("htmlBelowSummary")]
        public string HtmlBelowSummary { get; set; }

        [JsonProperty("launchDate")]
        public string LaunchDate { get; set; }

        [JsonProperty("cssGlobal")]
        public string CssGlobal { get; set; }

        [JsonProperty("onboarded")]
        public string Onboarded { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class PagePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("faviconUrl")]
        public string FaviconUrl { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("googleAnalytics")]
        public string GoogleAnalytics { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("customDomain")]
        public string CustomDomain { get; set; }

        [JsonProperty("useLargeHeader")]
        public bool UseLargeHeader { get; set; }

        [JsonProperty("disableDarkMode")]
        public string DisableDarkMode { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("subscribeBySms")]
        public string SubscribeBySms { get; set; }

        [JsonProperty("brandColor")]
        public string BrandColor { get; set; }

        [JsonProperty("okColor")]
        public string OkColor { get; set; }

        [JsonProperty("disruptedColor")]
        public string DisruptedColor { get; set; }

        [JsonProperty("downColor")]
        public string DownColor { get; set; }

        [JsonProperty("degradedColor")]
        public string DegradedColor { get; set; }

        [JsonProperty("noticeColor")]
        public string NoticeColor { get; set; }

        [JsonProperty("htmlInMeta")]
        public string HtmlInMeta { get; set; }

        [JsonProperty("htmlAboveHeader")]
        public string HtmlAboveHeader { get; set; }

        [JsonProperty("htmlBelowHeader")]
        public string HtmlBelowHeader { get; set; }

        [JsonProperty("htmlAboveFooter")]
        public string HtmlAboveFooter { get; set; }

        [JsonProperty("htmlBelowFooter")]
        public string HtmlBelowFooter { get; set; }

        [JsonProperty("htmlBelowSummary")]
        public string HtmlBelowSummary { get; set; }

        [JsonProperty("cssGlobal")]
        public string CssGlobal { get; set; }

        [JsonProperty("onboarded")]
        public string Onboarded { get; set; }

        [JsonProperty("launchDate")]
        public string LaunchDate { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("dateFormatShort")]
        public string DateFormatShort { get; set; }

        [JsonProperty("timeFormat")]
        public string TimeFormat { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("useAllowList")]
        public bool UseAllowList { get; set; }

        [JsonProperty("allowList")]
        public string[] AllowList { get; set; }

        [JsonProperty("components")]
        public PagePostResponseComponentsTypeItem[] Components { get; set; }
    }

    public class PagePostResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("incidents")]
        public string[] Incidents { get; set; }
    }

    public class PageDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class PagePutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("faviconUrl")]
        public string FaviconUrl { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("googleAnalytics")]
        public string GoogleAnalytics { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("customDomain")]
        public string CustomDomain { get; set; }

        [JsonProperty("useLargeHeader")]
        public bool UseLargeHeader { get; set; }

        [JsonProperty("disableDarkMode")]
        public string DisableDarkMode { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("subscribeBySms")]
        public string SubscribeBySms { get; set; }

        [JsonProperty("brandColor")]
        public string BrandColor { get; set; }

        [JsonProperty("okColor")]
        public string OkColor { get; set; }

        [JsonProperty("disruptedColor")]
        public string DisruptedColor { get; set; }

        [JsonProperty("downColor")]
        public string DownColor { get; set; }

        [JsonProperty("degradedColor")]
        public string DegradedColor { get; set; }

        [JsonProperty("noticeColor")]
        public string NoticeColor { get; set; }

        [JsonProperty("htmlInMeta")]
        public string HtmlInMeta { get; set; }

        [JsonProperty("htmlAboveHeader")]
        public string HtmlAboveHeader { get; set; }

        [JsonProperty("htmlBelowHeader")]
        public string HtmlBelowHeader { get; set; }

        [JsonProperty("htmlAboveFooter")]
        public string HtmlAboveFooter { get; set; }

        [JsonProperty("htmlBelowFooter")]
        public string HtmlBelowFooter { get; set; }

        [JsonProperty("htmlBelowSummary")]
        public string HtmlBelowSummary { get; set; }

        [JsonProperty("cssGlobal")]
        public string CssGlobal { get; set; }

        [JsonProperty("onboarded")]
        public string Onboarded { get; set; }

        [JsonProperty("launchDate")]
        public string LaunchDate { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("dateFormatShort")]
        public string DateFormatShort { get; set; }

        [JsonProperty("timeFormat")]
        public string TimeFormat { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("useAllowList")]
        public bool UseAllowList { get; set; }

        [JsonProperty("allowList")]
        public JToken[] AllowList { get; set; }

        [JsonProperty("components")]
        public PagePutResponseComponentsTypeItem[] Components { get; set; }
    }

    public class PagePutResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("order")]
        public string Order { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("incidents")]
        public string[] Incidents { get; set; }
    }

    public class ComponentsGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("uniqueEmail")]
        public string UniqueEmail { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }
    }

    public class ComponentPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("uniqueEmail")]
        public string UniqueEmail { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }
    }

    public class ComponentGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("uniqueEmail")]
        public string UniqueEmail { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }
    }

    public class ComponentDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class ComponentPutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uniqueEmail")]
        public string UniqueEmail { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }
    }

    public class IncidentsGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("resolved")]
        public string Resolved { get; set; }

        [JsonProperty("updates")]
        public IncidentsGetResponseItemUpdatesTypeItem[] Updates { get; set; }

        [JsonProperty("components")]
        public IncidentsGetResponseItemComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentsGetResponseItemUpdatesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("ended")]
        public string Ended { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class IncidentsGetResponseItemComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentsGetResponseItemComponentsTypeItemSiteType Site { get; set; }
    }

    public class IncidentsGetResponseItemComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class IncidentPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("resolved")]
        public string Resolved { get; set; }

        [JsonProperty("updates")]
        public string[] Updates { get; set; }

        [JsonProperty("components")]
        public IncidentPostResponseComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentPostResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentPostResponseComponentsTypeItemSiteType Site { get; set; }
    }

    public class IncidentPostResponseComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class bodystatusesInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class IncidentGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("resolved")]
        public string Resolved { get; set; }

        [JsonProperty("updates")]
        public IncidentGetResponseUpdatesTypeItem[] Updates { get; set; }

        [JsonProperty("components")]
        public IncidentGetResponseComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentGetResponseUpdatesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("ended")]
        public string Ended { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class IncidentGetResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentGetResponseComponentsTypeItemSiteType Site { get; set; }
    }

    public class IncidentGetResponseComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class IncidentDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class IncidentPutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("resolved")]
        public string Resolved { get; set; }

        [JsonProperty("updates")]
        public string[] Updates { get; set; }

        [JsonProperty("components")]
        public IncidentPutResponseComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentPutResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentPutResponseComponentsTypeItemSiteType Site { get; set; }
    }

    public class IncidentPutResponseComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class IncidentTemplatePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameTranslationId")]
        public string NameTranslationId { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("resolved")]
        public string Resolved { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("automated")]
        public bool Automated { get; set; }

        [JsonProperty("impact")]
        public string Impact { get; set; }

        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("siteId")]
        public string SiteId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }
    }

    public class IncidentUpdateGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("incident")]
        public IncidentUpdateGetResponseIncidentType Incident { get; set; }
    }

    public class IncidentUpdateGetResponseIncidentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("components")]
        public IncidentUpdateGetResponseIncidentTypeComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentUpdateGetResponseIncidentTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentUpdateGetResponseIncidentTypeComponentsTypeItemSiteType Site { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class IncidentUpdateGetResponseIncidentTypeComponentsTypeItemSiteType
    {
        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slackIntegrations")]
        public string[] SlackIntegrations { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class IncidentUpdateDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class IncidentUpdatePutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("incident")]
        public IncidentUpdatePutResponseIncidentType Incident { get; set; }
    }

    public class IncidentUpdatePutResponseIncidentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("components")]
        public IncidentUpdatePutResponseIncidentTypeComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentUpdatePutResponseIncidentTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentUpdatePutResponseIncidentTypeComponentsTypeItemSiteType Site { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class IncidentUpdatePutResponseIncidentTypeComponentsTypeItemSiteType
    {
        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slackIntegrations")]
        public string[] SlackIntegrations { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class IncidentUpdatePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("incident")]
        public IncidentUpdatePostResponseIncidentType Incident { get; set; }
    }

    public class IncidentUpdatePostResponseIncidentType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("components")]
        public IncidentUpdatePostResponseIncidentTypeComponentsTypeItem[] Components { get; set; }
    }

    public class IncidentUpdatePostResponseIncidentTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public IncidentUpdatePostResponseIncidentTypeComponentsTypeItemSiteType Site { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class IncidentUpdatePostResponseIncidentTypeComponentsTypeItemSiteType
    {
        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slackIntegrations")]
        public string[] SlackIntegrations { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class IncidentUpdateTemplatePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageTranslationId")]
        public string MessageTranslationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("ended")]
        public string Ended { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("incidentId")]
        public string IncidentId { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("messageHtmlTranslationId")]
        public string MessageHtmlTranslationId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }
    }

    public class MaintenancesGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("notifyStart")]
        public bool NotifyStart { get; set; }

        [JsonProperty("notifyEnd")]
        public bool NotifyEnd { get; set; }

        [JsonProperty("notifyEarly")]
        public bool NotifyEarly { get; set; }

        [JsonProperty("notifyMinutes")]
        public int NotifyMinutes { get; set; }

        [JsonProperty("autoStart")]
        public bool AutoStart { get; set; }

        [JsonProperty("autoEnd")]
        public bool AutoEnd { get; set; }

        [JsonProperty("updates")]
        public MaintenancesGetResponseItemUpdatesTypeItem[] Updates { get; set; }

        [JsonProperty("components")]
        public MaintenancesGetResponseItemComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenancesGetResponseItemUpdatesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("ended")]
        public string Ended { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class MaintenancesGetResponseItemComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public MaintenancesGetResponseItemComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenancesGetResponseItemComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class MaintenancePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("updates")]
        public string[] Updates { get; set; }

        [JsonProperty("components")]
        public MaintenancePostResponseComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenancePostResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public MaintenancePostResponseComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenancePostResponseComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class MaintenanceGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("notifyStart")]
        public bool NotifyStart { get; set; }

        [JsonProperty("notifyEnd")]
        public bool NotifyEnd { get; set; }

        [JsonProperty("notifyEarly")]
        public bool NotifyEarly { get; set; }

        [JsonProperty("notifyMinutes")]
        public int NotifyMinutes { get; set; }

        [JsonProperty("autoStart")]
        public bool AutoStart { get; set; }

        [JsonProperty("autoEnd")]
        public bool AutoEnd { get; set; }

        [JsonProperty("updates")]
        public MaintenanceGetResponseUpdatesTypeItem[] Updates { get; set; }

        [JsonProperty("components")]
        public MaintenanceGetResponseComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenanceGetResponseUpdatesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("ended")]
        public string Ended { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class MaintenanceGetResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public MaintenanceGetResponseComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenanceGetResponseComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class MaintenanceDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MaintenancePutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("updates")]
        public MaintenancePutResponseUpdatesTypeItem[] Updates { get; set; }

        [JsonProperty("components")]
        public MaintenancePutResponseComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenancePutResponseUpdatesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("ended")]
        public string Ended { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class MaintenancePutResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public MaintenancePutResponseComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenancePutResponseComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class MaintenanceUpdateGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("maintenance")]
        public MaintenanceUpdateGetResponseMaintenanceType Maintenance { get; set; }
    }

    public class MaintenanceUpdateGetResponseMaintenanceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("components")]
        public MaintenanceUpdateGetResponseMaintenanceTypeComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenanceUpdateGetResponseMaintenanceTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("site")]
        public MaintenanceUpdateGetResponseMaintenanceTypeComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenanceUpdateGetResponseMaintenanceTypeComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }
    }

    public class MaintenanceUpdateDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MaintenanceUpdatePutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("maintenance")]
        public MaintenanceUpdatePutResponseMaintenanceType Maintenance { get; set; }
    }

    public class MaintenanceUpdatePutResponseMaintenanceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("components")]
        public MaintenanceUpdatePutResponseMaintenanceTypeComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenanceUpdatePutResponseMaintenanceTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }

        [JsonProperty("site")]
        public MaintenanceUpdatePutResponseMaintenanceTypeComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenanceUpdatePutResponseMaintenanceTypeComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class MaintenanceUpdatePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("maintenance")]
        public MaintenanceUpdatePostResponseMaintenanceType Maintenance { get; set; }
    }

    public class MaintenanceUpdatePostResponseMaintenanceType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("components")]
        public MaintenanceUpdatePostResponseMaintenanceTypeComponentsTypeItem[] Components { get; set; }
    }

    public class MaintenanceUpdatePostResponseMaintenanceTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("showUptime")]
        public bool ShowUptime { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }

        [JsonProperty("site")]
        public MaintenanceUpdatePostResponseMaintenanceTypeComponentsTypeItemSiteType Site { get; set; }
    }

    public class MaintenanceUpdatePostResponseMaintenanceTypeComponentsTypeItemSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }
    }

    public class PageTemplatesGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameTranslationId")]
        public string NameTranslationId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageTranslationId")]
        public string MessageTranslationId { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("messageHtmlTranslationId")]
        public string MessageHtmlTranslationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("siteId")]
        public string SiteId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("components")]
        public PageTemplatesGetResponseItemComponentsTypeItem[] Components { get; set; }

        [JsonProperty("translations")]
        public PageTemplatesGetResponseItemTranslationsType Translations { get; set; }
    }

    public class PageTemplatesGetResponseItemComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("componentId")]
        public string ComponentId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }
    }

    public class PageTemplatesGetResponseItemTranslationsType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class TemplatePostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameTranslationId")]
        public string NameTranslationId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageTranslationId")]
        public string MessageTranslationId { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("messageHtmlTranslationId")]
        public string MessageHtmlTranslationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("siteId")]
        public string SiteId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }

        [JsonProperty("translations")]
        public TemplatePostResponseTranslationsType Translations { get; set; }
    }

    public class TemplatePostResponseTranslationsType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class bodycomponentsInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class TemplateGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameTranslationId")]
        public string NameTranslationId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageTranslationId")]
        public string MessageTranslationId { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("messageHtmlTranslationId")]
        public string MessageHtmlTranslationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("siteId")]
        public string SiteId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }

        [JsonProperty("translations")]
        public TemplateGetResponseTranslationsType Translations { get; set; }
    }

    public class TemplateGetResponseTranslationsType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class TemplateDeleteResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("site")]
        public TemplateDeleteResponseSiteType Site { get; set; }
    }

    public class TemplateDeleteResponseSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class TemplatePutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameTranslationId")]
        public string NameTranslationId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("messageTranslationId")]
        public string MessageTranslationId { get; set; }

        [JsonProperty("messageHtml")]
        public string MessageHtml { get; set; }

        [JsonProperty("messageHtmlTranslationId")]
        public string MessageHtmlTranslationId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("siteId")]
        public string SiteId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }

        [JsonProperty("deletedAt")]
        public string DeletedAt { get; set; }

        [JsonProperty("components")]
        public TemplatePutResponseComponentsTypeItem[] Components { get; set; }

        [JsonProperty("translations")]
        public TemplatePutResponseTranslationsType Translations { get; set; }
    }

    public class TemplatePutResponseComponentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("componentId")]
        public string ComponentId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("importedFromStatuspage")]
        public bool ImportedFromStatuspage { get; set; }
    }

    public class TemplatePutResponseTranslationsType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class TeammatesGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user")]
        public TeammatesGetResponseItemUserType User { get; set; }
    }

    public class TeammatesGetResponseItemUserType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

    public class SubscribersGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("webhook")]
        public string Webhook { get; set; }

        [JsonProperty("webhookEmail")]
        public string WebhookEmail { get; set; }

        [JsonProperty("confirmed")]
        public bool Confirmed { get; set; }

        [JsonProperty("all")]
        public bool All { get; set; }

        [JsonProperty("components")]
        public string[] Components { get; set; }
    }

    public class SubscriberPostResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("site")]
        public SubscriberPostResponseSiteType Site { get; set; }
    }

    public class SubscriberPostResponseSiteType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("subdomain")]
        public string Subdomain { get; set; }

        [JsonProperty("publicEmail")]
        public string PublicEmail { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Instatusip;

    public partial class WorkflowManagedActions
    {
        public InstatusipActions Instatusip(string connectionId) => new InstatusipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InstatusipTriggers Instatusip(string connectionId) => new InstatusipTriggers(connectionId);
    }
}