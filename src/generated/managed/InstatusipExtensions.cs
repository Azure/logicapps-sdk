//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Instatusip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InstatusipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PagesGetResponseItem[]> PagesGet(Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<PagesGetResponseItem[]>(() =>
            {
                var apiCallPath = "/v2/pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<PagesGetResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PagePostResponse> Page(Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodysubdomain = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodylogoUrl = null, Expression<Func<string>> bodyfaviconUrl = null, Expression<Func<string>> bodywebsiteUrl = null, Expression<Func<string>> bodylanguage = null, Expression<Func<bool>> bodyuseLargeHeader = null, Expression<Func<string>> bodybrandColor = null, Expression<Func<string>> bodyokColor = null, Expression<Func<string>> bodydisruptedColor = null, Expression<Func<string>> bodydegradedColor = null, Expression<Func<string>> bodydownColor = null, Expression<Func<string>> bodynoticeColor = null, Expression<Func<string>> bodyunknownColor = null, Expression<Func<string>> bodygoogleAnalytics = null, Expression<Func<bool>> bodysubscribeBySms = null, Expression<Func<string>> bodysmsService = null, Expression<Func<string>> bodytwilioSid = null, Expression<Func<string>> bodytwilioToken = null, Expression<Func<string>> bodytwilioSender = null, Expression<Func<string>> bodyhtmlInMeta = null, Expression<Func<string>> bodyhtmlAboveHeader = null, Expression<Func<string>> bodyhtmlBelowHeader = null, Expression<Func<string>> bodyhtmlAboveFooter = null, Expression<Func<string>> bodyhtmlBelowFooter = null, Expression<Func<string>> bodyhtmlBelowSummary = null, Expression<Func<string>> bodycssGlobal = null, Expression<Func<string>> bodylaunchDate = null, Expression<Func<string>> bodydateFormat = null, Expression<Func<string>> bodydateFormatShort = null, Expression<Func<string>> bodytimeFormat = null)
        {
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodysubdomain = WorkflowExpression.Compile(bodysubdomain, nameof(bodysubdomain), required: false);
            var __workflow_bodycomponents = WorkflowExpression.Compile(bodycomponents, nameof(bodycomponents), required: false);
            var __workflow_bodylogoUrl = WorkflowExpression.Compile(bodylogoUrl, nameof(bodylogoUrl), required: false);
            var __workflow_bodyfaviconUrl = WorkflowExpression.Compile(bodyfaviconUrl, nameof(bodyfaviconUrl), required: false);
            var __workflow_bodywebsiteUrl = WorkflowExpression.Compile(bodywebsiteUrl, nameof(bodywebsiteUrl), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodyuseLargeHeader = WorkflowExpression.Compile(bodyuseLargeHeader, nameof(bodyuseLargeHeader), required: false);
            var __workflow_bodybrandColor = WorkflowExpression.Compile(bodybrandColor, nameof(bodybrandColor), required: false);
            var __workflow_bodyokColor = WorkflowExpression.Compile(bodyokColor, nameof(bodyokColor), required: false);
            var __workflow_bodydisruptedColor = WorkflowExpression.Compile(bodydisruptedColor, nameof(bodydisruptedColor), required: false);
            var __workflow_bodydegradedColor = WorkflowExpression.Compile(bodydegradedColor, nameof(bodydegradedColor), required: false);
            var __workflow_bodydownColor = WorkflowExpression.Compile(bodydownColor, nameof(bodydownColor), required: false);
            var __workflow_bodynoticeColor = WorkflowExpression.Compile(bodynoticeColor, nameof(bodynoticeColor), required: false);
            var __workflow_bodyunknownColor = WorkflowExpression.Compile(bodyunknownColor, nameof(bodyunknownColor), required: false);
            var __workflow_bodygoogleAnalytics = WorkflowExpression.Compile(bodygoogleAnalytics, nameof(bodygoogleAnalytics), required: false);
            var __workflow_bodysubscribeBySms = WorkflowExpression.Compile(bodysubscribeBySms, nameof(bodysubscribeBySms), required: false);
            var __workflow_bodysmsService = WorkflowExpression.Compile(bodysmsService, nameof(bodysmsService), required: false);
            var __workflow_bodytwilioSid = WorkflowExpression.Compile(bodytwilioSid, nameof(bodytwilioSid), required: false);
            var __workflow_bodytwilioToken = WorkflowExpression.Compile(bodytwilioToken, nameof(bodytwilioToken), required: false);
            var __workflow_bodytwilioSender = WorkflowExpression.Compile(bodytwilioSender, nameof(bodytwilioSender), required: false);
            var __workflow_bodyhtmlInMeta = WorkflowExpression.Compile(bodyhtmlInMeta, nameof(bodyhtmlInMeta), required: false);
            var __workflow_bodyhtmlAboveHeader = WorkflowExpression.Compile(bodyhtmlAboveHeader, nameof(bodyhtmlAboveHeader), required: false);
            var __workflow_bodyhtmlBelowHeader = WorkflowExpression.Compile(bodyhtmlBelowHeader, nameof(bodyhtmlBelowHeader), required: false);
            var __workflow_bodyhtmlAboveFooter = WorkflowExpression.Compile(bodyhtmlAboveFooter, nameof(bodyhtmlAboveFooter), required: false);
            var __workflow_bodyhtmlBelowFooter = WorkflowExpression.Compile(bodyhtmlBelowFooter, nameof(bodyhtmlBelowFooter), required: false);
            var __workflow_bodyhtmlBelowSummary = WorkflowExpression.Compile(bodyhtmlBelowSummary, nameof(bodyhtmlBelowSummary), required: false);
            var __workflow_bodycssGlobal = WorkflowExpression.Compile(bodycssGlobal, nameof(bodycssGlobal), required: false);
            var __workflow_bodylaunchDate = WorkflowExpression.Compile(bodylaunchDate, nameof(bodylaunchDate), required: false);
            var __workflow_bodydateFormat = WorkflowExpression.Compile(bodydateFormat, nameof(bodydateFormat), required: false);
            var __workflow_bodydateFormatShort = WorkflowExpression.Compile(bodydateFormatShort, nameof(bodydateFormatShort), required: false);
            var __workflow_bodytimeFormat = WorkflowExpression.Compile(bodytimeFormat, nameof(bodytimeFormat), required: false);
            return new DeferredBodyAction<PagePostResponse>(() =>
            {
                var apiCallPath = "/v1/pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodysubdomain != null)
                {
                    body["subdomain"] = ExpressionConverter.ConvertO(__workflow_bodysubdomain);
                    bodypropCount++;
                }

                if (__workflow_bodycomponents != null)
                {
                    body["components"] = ExpressionConverter.ConvertO(__workflow_bodycomponents);
                    bodypropCount++;
                }

                if (__workflow_bodylogoUrl != null)
                {
                    body["logoUrl"] = ExpressionConverter.ConvertO(__workflow_bodylogoUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyfaviconUrl != null)
                {
                    body["faviconUrl"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconUrl);
                    bodypropCount++;
                }

                if (__workflow_bodywebsiteUrl != null)
                {
                    body["websiteUrl"] = ExpressionConverter.ConvertO(__workflow_bodywebsiteUrl);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodyuseLargeHeader != null)
                {
                    body["useLargeHeader"] = ExpressionConverter.ConvertO(__workflow_bodyuseLargeHeader);
                    bodypropCount++;
                }

                if (__workflow_bodybrandColor != null)
                {
                    body["brandColor"] = ExpressionConverter.ConvertO(__workflow_bodybrandColor);
                    bodypropCount++;
                }

                if (__workflow_bodyokColor != null)
                {
                    body["okColor"] = ExpressionConverter.ConvertO(__workflow_bodyokColor);
                    bodypropCount++;
                }

                if (__workflow_bodydisruptedColor != null)
                {
                    body["disruptedColor"] = ExpressionConverter.ConvertO(__workflow_bodydisruptedColor);
                    bodypropCount++;
                }

                if (__workflow_bodydegradedColor != null)
                {
                    body["degradedColor"] = ExpressionConverter.ConvertO(__workflow_bodydegradedColor);
                    bodypropCount++;
                }

                if (__workflow_bodydownColor != null)
                {
                    body["downColor"] = ExpressionConverter.ConvertO(__workflow_bodydownColor);
                    bodypropCount++;
                }

                if (__workflow_bodynoticeColor != null)
                {
                    body["noticeColor"] = ExpressionConverter.ConvertO(__workflow_bodynoticeColor);
                    bodypropCount++;
                }

                if (__workflow_bodyunknownColor != null)
                {
                    body["unknownColor"] = ExpressionConverter.ConvertO(__workflow_bodyunknownColor);
                    bodypropCount++;
                }

                if (__workflow_bodygoogleAnalytics != null)
                {
                    body["googleAnalytics"] = ExpressionConverter.ConvertO(__workflow_bodygoogleAnalytics);
                    bodypropCount++;
                }

                if (__workflow_bodysubscribeBySms != null)
                {
                    body["subscribeBySms"] = ExpressionConverter.ConvertO(__workflow_bodysubscribeBySms);
                    bodypropCount++;
                }

                if (__workflow_bodysmsService != null)
                {
                    body["smsService"] = ExpressionConverter.ConvertO(__workflow_bodysmsService);
                    bodypropCount++;
                }

                if (__workflow_bodytwilioSid != null)
                {
                    body["twilioSid"] = ExpressionConverter.ConvertO(__workflow_bodytwilioSid);
                    bodypropCount++;
                }

                if (__workflow_bodytwilioToken != null)
                {
                    body["twilioToken"] = ExpressionConverter.ConvertO(__workflow_bodytwilioToken);
                    bodypropCount++;
                }

                if (__workflow_bodytwilioSender != null)
                {
                    body["twilioSender"] = ExpressionConverter.ConvertO(__workflow_bodytwilioSender);
                    bodypropCount++;
                }

                if (__workflow_bodyhtmlInMeta != null)
                {
                    body["htmlInMeta"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlInMeta);
                    bodypropCount++;
                }

                if (__workflow_bodyhtmlAboveHeader != null)
                {
                    body["htmlAboveHeader"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlAboveHeader);
                    bodypropCount++;
                }

                if (__workflow_bodyhtmlBelowHeader != null)
                {
                    body["htmlBelowHeader"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlBelowHeader);
                    bodypropCount++;
                }

                if (__workflow_bodyhtmlAboveFooter != null)
                {
                    body["htmlAboveFooter"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlAboveFooter);
                    bodypropCount++;
                }

                if (__workflow_bodyhtmlBelowFooter != null)
                {
                    body["htmlBelowFooter"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlBelowFooter);
                    bodypropCount++;
                }

                if (__workflow_bodyhtmlBelowSummary != null)
                {
                    body["htmlBelowSummary"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlBelowSummary);
                    bodypropCount++;
                }

                if (__workflow_bodycssGlobal != null)
                {
                    body["cssGlobal"] = ExpressionConverter.ConvertO(__workflow_bodycssGlobal);
                    bodypropCount++;
                }

                if (__workflow_bodylaunchDate != null)
                {
                    body["launchDate"] = ExpressionConverter.ConvertO(__workflow_bodylaunchDate);
                    bodypropCount++;
                }

                if (__workflow_bodydateFormat != null)
                {
                    body["dateFormat"] = ExpressionConverter.ConvertO(__workflow_bodydateFormat);
                    bodypropCount++;
                }

                if (__workflow_bodydateFormatShort != null)
                {
                    body["dateFormatShort"] = ExpressionConverter.ConvertO(__workflow_bodydateFormatShort);
                    bodypropCount++;
                }

                if (__workflow_bodytimeFormat != null)
                {
                    body["timeFormat"] = ExpressionConverter.ConvertO(__workflow_bodytimeFormat);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PagePostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PageDeleteResponse> PageDelete(Expression<Func<string>> pageId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            return new DeferredBodyAction<PageDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/{0}", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageDeleteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PagePutResponse> PagePut(Expression<Func<string>> pageId, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodysubdomain = null, Expression<Func<string>> bodylogoUrl = null, Expression<Func<string>> bodyfaviconUrl = null, Expression<Func<string>> bodywebsiteUrl = null, Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodypublicEmail = null, Expression<Func<bool>> bodyuseLargeHeader = null, Expression<Func<string>> bodybrandColor = null, Expression<Func<string>> bodyokColor = null, Expression<Func<string>> bodydisruptedColor = null, Expression<Func<string>> bodydegradedColor = null, Expression<Func<string>> bodydownColor = null, Expression<Func<string>> bodynoticeColor = null, Expression<Func<string>> bodyunknownColor = null, Expression<Func<string>> bodygoogleAnalytics = null, Expression<Func<bool>> bodysubscribeBySms = null, Expression<Func<string>> bodysmsService = null, Expression<Func<string>> bodytwilioSid = null, Expression<Func<string>> bodytwilioToken = null, Expression<Func<string>> bodytwilioSender = null, Expression<Func<string>> bodyhtmlInMeta = null, Expression<Func<string>> bodyhtmlAboveHeader = null, Expression<Func<string>> bodyhtmlBelowHeader = null, Expression<Func<string>> bodyhtmlAboveFooter = null, Expression<Func<string>> bodyhtmlBelowFooter = null, Expression<Func<string>> bodyhtmlBelowSummary = null, Expression<Func<string>> bodycssGlobal = null, Expression<Func<string>> bodylaunchDate = null, Expression<Func<string>> bodydateFormat = null, Expression<Func<string>> bodydateFormatShort = null, Expression<Func<string>> bodytimeFormat = null, Expression<Func<bool>> bodyprivate = null, Expression<Func<bool>> bodyuseAllowList = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodysubdomain = WorkflowExpression.Compile(bodysubdomain, nameof(bodysubdomain), required: false);
            var __workflow_bodylogoUrl = WorkflowExpression.Compile(bodylogoUrl, nameof(bodylogoUrl), required: false);
            var __workflow_bodyfaviconUrl = WorkflowExpression.Compile(bodyfaviconUrl, nameof(bodyfaviconUrl), required: false);
            var __workflow_bodywebsiteUrl = WorkflowExpression.Compile(bodywebsiteUrl, nameof(bodywebsiteUrl), required: false);
            var __workflow_bodylanguage = WorkflowExpression.Compile(bodylanguage, nameof(bodylanguage), required: false);
            var __workflow_bodypublicEmail = WorkflowExpression.Compile(bodypublicEmail, nameof(bodypublicEmail), required: false);
            var __workflow_bodyuseLargeHeader = WorkflowExpression.Compile(bodyuseLargeHeader, nameof(bodyuseLargeHeader), required: false);
            var __workflow_bodybrandColor = WorkflowExpression.Compile(bodybrandColor, nameof(bodybrandColor), required: false);
            var __workflow_bodyokColor = WorkflowExpression.Compile(bodyokColor, nameof(bodyokColor), required: false);
            var __workflow_bodydisruptedColor = WorkflowExpression.Compile(bodydisruptedColor, nameof(bodydisruptedColor), required: false);
            var __workflow_bodydegradedColor = WorkflowExpression.Compile(bodydegradedColor, nameof(bodydegradedColor), required: false);
            var __workflow_bodydownColor = WorkflowExpression.Compile(bodydownColor, nameof(bodydownColor), required: false);
            var __workflow_bodynoticeColor = WorkflowExpression.Compile(bodynoticeColor, nameof(bodynoticeColor), required: false);
            var __workflow_bodyunknownColor = WorkflowExpression.Compile(bodyunknownColor, nameof(bodyunknownColor), required: false);
            var __workflow_bodygoogleAnalytics = WorkflowExpression.Compile(bodygoogleAnalytics, nameof(bodygoogleAnalytics), required: false);
            var __workflow_bodysubscribeBySms = WorkflowExpression.Compile(bodysubscribeBySms, nameof(bodysubscribeBySms), required: false);
            var __workflow_bodysmsService = WorkflowExpression.Compile(bodysmsService, nameof(bodysmsService), required: false);
            var __workflow_bodytwilioSid = WorkflowExpression.Compile(bodytwilioSid, nameof(bodytwilioSid), required: false);
            var __workflow_bodytwilioToken = WorkflowExpression.Compile(bodytwilioToken, nameof(bodytwilioToken), required: false);
            var __workflow_bodytwilioSender = WorkflowExpression.Compile(bodytwilioSender, nameof(bodytwilioSender), required: false);
            var __workflow_bodyhtmlInMeta = WorkflowExpression.Compile(bodyhtmlInMeta, nameof(bodyhtmlInMeta), required: false);
            var __workflow_bodyhtmlAboveHeader = WorkflowExpression.Compile(bodyhtmlAboveHeader, nameof(bodyhtmlAboveHeader), required: false);
            var __workflow_bodyhtmlBelowHeader = WorkflowExpression.Compile(bodyhtmlBelowHeader, nameof(bodyhtmlBelowHeader), required: false);
            var __workflow_bodyhtmlAboveFooter = WorkflowExpression.Compile(bodyhtmlAboveFooter, nameof(bodyhtmlAboveFooter), required: false);
            var __workflow_bodyhtmlBelowFooter = WorkflowExpression.Compile(bodyhtmlBelowFooter, nameof(bodyhtmlBelowFooter), required: false);
            var __workflow_bodyhtmlBelowSummary = WorkflowExpression.Compile(bodyhtmlBelowSummary, nameof(bodyhtmlBelowSummary), required: false);
            var __workflow_bodycssGlobal = WorkflowExpression.Compile(bodycssGlobal, nameof(bodycssGlobal), required: false);
            var __workflow_bodylaunchDate = WorkflowExpression.Compile(bodylaunchDate, nameof(bodylaunchDate), required: false);
            var __workflow_bodydateFormat = WorkflowExpression.Compile(bodydateFormat, nameof(bodydateFormat), required: false);
            var __workflow_bodydateFormatShort = WorkflowExpression.Compile(bodydateFormatShort, nameof(bodydateFormatShort), required: false);
            var __workflow_bodytimeFormat = WorkflowExpression.Compile(bodytimeFormat, nameof(bodytimeFormat), required: false);
            var __workflow_bodyprivate = WorkflowExpression.Compile(bodyprivate, nameof(bodyprivate), required: false);
            var __workflow_bodyuseAllowList = WorkflowExpression.Compile(bodyuseAllowList, nameof(bodyuseAllowList), required: false);
            return new DeferredBodyAction<PagePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/{0}", __workflow_pageId.WithUrlEncoding(1)));
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

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodysubdomain != null)
                {
                    body["subdomain"] = ExpressionConverter.ConvertO(__workflow_bodysubdomain);
                    bodypropCount++;
                }

                if (__workflow_bodylogoUrl != null)
                {
                    body["logoUrl"] = ExpressionConverter.ConvertO(__workflow_bodylogoUrl);
                    bodypropCount++;
                }

                if (__workflow_bodyfaviconUrl != null)
                {
                    body["faviconUrl"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconUrl);
                    bodypropCount++;
                }

                if (__workflow_bodywebsiteUrl != null)
                {
                    body["websiteUrl"] = ExpressionConverter.ConvertO(__workflow_bodywebsiteUrl);
                    bodypropCount++;
                }

                if (__workflow_bodylanguage != null)
                {
                    body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                    bodypropCount++;
                }

                if (__workflow_bodypublicEmail != null)
                {
                    body["publicEmail"] = ExpressionConverter.ConvertO(__workflow_bodypublicEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyuseLargeHeader != null)
                {
                    body["useLargeHeader"] = ExpressionConverter.ConvertO(__workflow_bodyuseLargeHeader);
                    bodypropCount++;
                }

                if (__workflow_bodybrandColor != null)
                {
                    body["brandColor"] = ExpressionConverter.ConvertO(__workflow_bodybrandColor);
                    bodypropCount++;
                }

                if (__workflow_bodyokColor != null)
                {
                    body["okColor"] = ExpressionConverter.ConvertO(__workflow_bodyokColor);
                    bodypropCount++;
                }

                if (__workflow_bodydisruptedColor != null)
                {
                    body["disruptedColor"] = ExpressionConverter.ConvertO(__workflow_bodydisruptedColor);
                    bodypropCount++;
                }

                if (__workflow_bodydegradedColor != null)
                {
                    body["degradedColor"] = ExpressionConverter.ConvertO(__workflow_bodydegradedColor);
                    bodypropCount++;
                }

                if (__workflow_bodydownColor != null)
                {
                    body["downColor"] = ExpressionConverter.ConvertO(__workflow_bodydownColor);
                    bodypropCount++;
                }

                if (__workflow_bodynoticeColor != null)
                {
                    body["noticeColor"] = ExpressionConverter.ConvertO(__workflow_bodynoticeColor);
                    bodypropCount++;
                }

                if (__workflow_bodyunknownColor != null)
                {
                    body["unknownColor"] = ExpressionConverter.ConvertO(__workflow_bodyunknownColor);
                    bodypropCount++;
                }

                if (__workflow_bodygoogleAnalytics != null)
                {
                    body["googleAnalytics"] = ExpressionConverter.ConvertO(__workflow_bodygoogleAnalytics);
                    bodypropCount++;
                }

                if (__workflow_bodysubscribeBySms != null)
                {
                    body["subscribeBySms"] = ExpressionConverter.ConvertO(__workflow_bodysubscribeBySms);
                    bodypropCount++;
                }

                if (__workflow_bodysmsService != null)
                {
                    body["smsService"] = ExpressionConverter.ConvertO(__workflow_bodysmsService);
                    bodypropCount++;
                }

                if (__workflow_bodytwilioSid != null)
                {
                    body["twilioSid"] = ExpressionConverter.ConvertO(__workflow_bodytwilioSid);
                    bodypropCount++;
                }

                if (__workflow_bodytwilioToken != null)
                {
                    body["twilioToken"] = ExpressionConverter.ConvertO(__workflow_bodytwilioToken);
                    bodypropCount++;
                }

                if (__workflow_bodytwilioSender != null)
                {
                    body["twilioSender"] = ExpressionConverter.ConvertO(__workflow_bodytwilioSender);
                    bodypropCount++;
                }

                if (__workflow_bodyhtmlInMeta != null)
                {
                    body["htmlInMeta"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlInMeta);
                    bodypropCount++;
                }

                if (__workflow_bodyhtmlAboveHeader != null)
                {
                    body["htmlAboveHeader"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlAboveHeader);
                    bodypropCount++;
                }

                if (__workflow_bodyhtmlBelowHeader != null)
                {
                    body["htmlBelowHeader"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlBelowHeader);
                    bodypropCount++;
                }

                if (__workflow_bodyhtmlAboveFooter != null)
                {
                    body["htmlAboveFooter"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlAboveFooter);
                    bodypropCount++;
                }

                if (__workflow_bodyhtmlBelowFooter != null)
                {
                    body["htmlBelowFooter"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlBelowFooter);
                    bodypropCount++;
                }

                if (__workflow_bodyhtmlBelowSummary != null)
                {
                    body["htmlBelowSummary"] = ExpressionConverter.ConvertO(__workflow_bodyhtmlBelowSummary);
                    bodypropCount++;
                }

                if (__workflow_bodycssGlobal != null)
                {
                    body["cssGlobal"] = ExpressionConverter.ConvertO(__workflow_bodycssGlobal);
                    bodypropCount++;
                }

                if (__workflow_bodylaunchDate != null)
                {
                    body["launchDate"] = ExpressionConverter.ConvertO(__workflow_bodylaunchDate);
                    bodypropCount++;
                }

                if (__workflow_bodydateFormat != null)
                {
                    body["dateFormat"] = ExpressionConverter.ConvertO(__workflow_bodydateFormat);
                    bodypropCount++;
                }

                if (__workflow_bodydateFormatShort != null)
                {
                    body["dateFormatShort"] = ExpressionConverter.ConvertO(__workflow_bodydateFormatShort);
                    bodypropCount++;
                }

                if (__workflow_bodytimeFormat != null)
                {
                    body["timeFormat"] = ExpressionConverter.ConvertO(__workflow_bodytimeFormat);
                    bodypropCount++;
                }

                if (__workflow_bodyprivate != null)
                {
                    body["private"] = ExpressionConverter.ConvertO(__workflow_bodyprivate);
                    bodypropCount++;
                }

                if (__workflow_bodyuseAllowList != null)
                {
                    body["useAllowList"] = ExpressionConverter.ConvertO(__workflow_bodyuseAllowList);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PagePutResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentsGetResponseItem[]> ComponentsGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ComponentsGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/components", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<ComponentsGetResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentPostResponse> Component(Expression<Func<string>> pageId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodyorder = null, Expression<Func<bool>> bodyshowUptime = null, Expression<Func<bool>> bodygrouped = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodyshowUptime = WorkflowExpression.Compile(bodyshowUptime, nameof(bodyshowUptime), required: false);
            var __workflow_bodygrouped = WorkflowExpression.Compile(bodygrouped, nameof(bodygrouped), required: false);
            return new DeferredBodyAction<ComponentPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/components", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                if (__workflow_bodyshowUptime != null)
                {
                    body["showUptime"] = ExpressionConverter.ConvertO(__workflow_bodyshowUptime);
                    bodypropCount++;
                }

                if (__workflow_bodygrouped != null)
                {
                    body["grouped"] = ExpressionConverter.ConvertO(__workflow_bodygrouped);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ComponentPostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentGetResponse> ComponentGet(Expression<Func<string>> pageId, Expression<Func<string>> componentId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_componentId = WorkflowExpression.Compile(componentId, nameof(componentId), required: true);
            return new DeferredBodyAction<ComponentGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/components/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_componentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComponentGetResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentDeleteResponse> ComponentDelete(Expression<Func<string>> pageId, Expression<Func<string>> componentId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_componentId = WorkflowExpression.Compile(componentId, nameof(componentId), required: true);
            return new DeferredBodyAction<ComponentDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/components/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_componentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComponentDeleteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentPutResponse> ComponentPut(Expression<Func<string>> pageId, Expression<Func<string>> componentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodystatus = null, Expression<Func<int>> bodyorder = null, Expression<Func<bool>> bodyshowUptime = null, Expression<Func<bool>> bodygrouped = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_componentId = WorkflowExpression.Compile(componentId, nameof(componentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyorder = WorkflowExpression.Compile(bodyorder, nameof(bodyorder), required: false);
            var __workflow_bodyshowUptime = WorkflowExpression.Compile(bodyshowUptime, nameof(bodyshowUptime), required: false);
            var __workflow_bodygrouped = WorkflowExpression.Compile(bodygrouped, nameof(bodygrouped), required: false);
            return new DeferredBodyAction<ComponentPutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/components/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_componentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyorder != null)
                {
                    body["order"] = ExpressionConverter.ConvertO(__workflow_bodyorder);
                    bodypropCount++;
                }

                if (__workflow_bodyshowUptime != null)
                {
                    body["showUptime"] = ExpressionConverter.ConvertO(__workflow_bodyshowUptime);
                    bodypropCount++;
                }

                if (__workflow_bodygrouped != null)
                {
                    body["grouped"] = ExpressionConverter.ConvertO(__workflow_bodygrouped);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ComponentPutResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentsGetResponseItem[]> IncidentsGet(Expression<Func<string>> pageId, Expression<Func<string>> status = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<IncidentsGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<IncidentsGetResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentPostResponse> Incident(Expression<Func<string>> pageId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystarted = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodycomponents = WorkflowExpression.Compile(bodycomponents, nameof(bodycomponents), required: false);
            var __workflow_bodystarted = WorkflowExpression.Compile(bodystarted, nameof(bodystarted), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodynotify = WorkflowExpression.Compile(bodynotify, nameof(bodynotify), required: false);
            var __workflow_bodystatuses = WorkflowExpression.Compile(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<IncidentPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodycomponents != null)
                {
                    body["components"] = ExpressionConverter.ConvertO(__workflow_bodycomponents);
                    bodypropCount++;
                }

                if (__workflow_bodystarted != null)
                {
                    body["started"] = ExpressionConverter.ConvertO(__workflow_bodystarted);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodynotify != null)
                {
                    body["notify"] = ExpressionConverter.ConvertO(__workflow_bodynotify);
                    bodypropCount++;
                }

                if (__workflow_bodystatuses != null)
                {
                    body["statuses"] = ExpressionConverter.ConvertO(__workflow_bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IncidentPostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentGetResponse> IncidentGet(Expression<Func<string>> pageId, Expression<Func<string>> incidentId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            return new DeferredBodyAction<IncidentGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentGetResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentDeleteResponse> IncidentDelete(Expression<Func<string>> pageId, Expression<Func<string>> incidentId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            return new DeferredBodyAction<IncidentDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentDeleteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentPutResponse> IncidentPut(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> bodyname = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystarted = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodycomponents = WorkflowExpression.Compile(bodycomponents, nameof(bodycomponents), required: false);
            var __workflow_bodystarted = WorkflowExpression.Compile(bodystarted, nameof(bodystarted), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodynotify = WorkflowExpression.Compile(bodynotify, nameof(bodynotify), required: false);
            var __workflow_bodystatuses = WorkflowExpression.Compile(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<IncidentPutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodycomponents != null)
                {
                    body["components"] = ExpressionConverter.ConvertO(__workflow_bodycomponents);
                    bodypropCount++;
                }

                if (__workflow_bodystarted != null)
                {
                    body["started"] = ExpressionConverter.ConvertO(__workflow_bodystarted);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodynotify != null)
                {
                    body["notify"] = ExpressionConverter.ConvertO(__workflow_bodynotify);
                    bodypropCount++;
                }

                if (__workflow_bodystatuses != null)
                {
                    body["statuses"] = ExpressionConverter.ConvertO(__workflow_bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IncidentPutResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentTemplatePostResponse> IncidentTemplate(Expression<Func<string>> pageId, Expression<Func<string>> template)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            return new DeferredBodyAction<IncidentTemplatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/{0}/incidents/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_template.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentTemplatePostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdateGetResponse> IncidentUpdateGet(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> incidentUpdateId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            var __workflow_incidentUpdateId = WorkflowExpression.Compile(incidentUpdateId, nameof(incidentUpdateId), required: true);
            return new DeferredBodyAction<IncidentUpdateGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}/incident-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1), __workflow_incidentUpdateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentUpdateGetResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdateDeleteResponse> IncidentUpdateDelete(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> incidentUpdateId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            var __workflow_incidentUpdateId = WorkflowExpression.Compile(incidentUpdateId, nameof(incidentUpdateId), required: true);
            return new DeferredBodyAction<IncidentUpdateDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}/incident-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1), __workflow_incidentUpdateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentUpdateDeleteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdatePutResponse> IncidentUpdatePut(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> incidentUpdateId, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystarted = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            var __workflow_incidentUpdateId = WorkflowExpression.Compile(incidentUpdateId, nameof(incidentUpdateId), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodycomponents = WorkflowExpression.Compile(bodycomponents, nameof(bodycomponents), required: false);
            var __workflow_bodystarted = WorkflowExpression.Compile(bodystarted, nameof(bodystarted), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodynotify = WorkflowExpression.Compile(bodynotify, nameof(bodynotify), required: false);
            var __workflow_bodystatuses = WorkflowExpression.Compile(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<IncidentUpdatePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}/incident-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1), __workflow_incidentUpdateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodycomponents != null)
                {
                    body["components"] = ExpressionConverter.ConvertO(__workflow_bodycomponents);
                    bodypropCount++;
                }

                if (__workflow_bodystarted != null)
                {
                    body["started"] = ExpressionConverter.ConvertO(__workflow_bodystarted);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodynotify != null)
                {
                    body["notify"] = ExpressionConverter.ConvertO(__workflow_bodynotify);
                    bodypropCount++;
                }

                if (__workflow_bodystatuses != null)
                {
                    body["statuses"] = ExpressionConverter.ConvertO(__workflow_bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IncidentUpdatePutResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdatePostResponse> IncidentUpdate(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystarted = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodycomponents = WorkflowExpression.Compile(bodycomponents, nameof(bodycomponents), required: false);
            var __workflow_bodystarted = WorkflowExpression.Compile(bodystarted, nameof(bodystarted), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodynotify = WorkflowExpression.Compile(bodynotify, nameof(bodynotify), required: false);
            var __workflow_bodystatuses = WorkflowExpression.Compile(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<IncidentUpdatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/incidents/{1}/incident-updates", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodycomponents != null)
                {
                    body["components"] = ExpressionConverter.ConvertO(__workflow_bodycomponents);
                    bodypropCount++;
                }

                if (__workflow_bodystarted != null)
                {
                    body["started"] = ExpressionConverter.ConvertO(__workflow_bodystarted);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodynotify != null)
                {
                    body["notify"] = ExpressionConverter.ConvertO(__workflow_bodynotify);
                    bodypropCount++;
                }

                if (__workflow_bodystatuses != null)
                {
                    body["statuses"] = ExpressionConverter.ConvertO(__workflow_bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IncidentUpdatePostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdateTemplatePostResponse> IncidentUpdateTemplate(Expression<Func<string>> pageId, Expression<Func<string>> incidentId, Expression<Func<string>> template)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_incidentId = WorkflowExpression.Compile(incidentId, nameof(incidentId), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            return new DeferredBodyAction<IncidentUpdateTemplatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/{0}/incidents/{1}/incident-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_incidentId.WithUrlEncoding(1), __workflow_template.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentUpdateTemplatePostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenancesGetResponseItem[]> MaintenancesGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<MaintenancesGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<MaintenancesGetResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenancePostResponse> Maintenance(Expression<Func<string>> pageId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodyend = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<int>> bodyduration = null, Expression<Func<bool>> bodynotifyStart = null, Expression<Func<bool>> bodynotifyEnd = null, Expression<Func<bool>> bodynotifyEarly = null, Expression<Func<int>> bodynotifyMinutes = null, Expression<Func<bool>> bodyautoStart = null, Expression<Func<bool>> bodyautoEnd = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodycomponents = WorkflowExpression.Compile(bodycomponents, nameof(bodycomponents), required: false);
            var __workflow_bodystart = WorkflowExpression.Compile(bodystart, nameof(bodystart), required: false);
            var __workflow_bodyend = WorkflowExpression.Compile(bodyend, nameof(bodyend), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodynotify = WorkflowExpression.Compile(bodynotify, nameof(bodynotify), required: false);
            var __workflow_bodyduration = WorkflowExpression.Compile(bodyduration, nameof(bodyduration), required: false);
            var __workflow_bodynotifyStart = WorkflowExpression.Compile(bodynotifyStart, nameof(bodynotifyStart), required: false);
            var __workflow_bodynotifyEnd = WorkflowExpression.Compile(bodynotifyEnd, nameof(bodynotifyEnd), required: false);
            var __workflow_bodynotifyEarly = WorkflowExpression.Compile(bodynotifyEarly, nameof(bodynotifyEarly), required: false);
            var __workflow_bodynotifyMinutes = WorkflowExpression.Compile(bodynotifyMinutes, nameof(bodynotifyMinutes), required: false);
            var __workflow_bodyautoStart = WorkflowExpression.Compile(bodyautoStart, nameof(bodyautoStart), required: false);
            var __workflow_bodyautoEnd = WorkflowExpression.Compile(bodyautoEnd, nameof(bodyautoEnd), required: false);
            var __workflow_bodystatuses = WorkflowExpression.Compile(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<MaintenancePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodycomponents != null)
                {
                    body["components"] = ExpressionConverter.ConvertO(__workflow_bodycomponents);
                    bodypropCount++;
                }

                if (__workflow_bodystart != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodystart);
                    bodypropCount++;
                }

                if (__workflow_bodyend != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyend);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodynotify != null)
                {
                    body["notify"] = ExpressionConverter.ConvertO(__workflow_bodynotify);
                    bodypropCount++;
                }

                if (__workflow_bodyduration != null)
                {
                    body["duration"] = ExpressionConverter.ConvertO(__workflow_bodyduration);
                    bodypropCount++;
                }

                if (__workflow_bodynotifyStart != null)
                {
                    body["notifyStart"] = ExpressionConverter.ConvertO(__workflow_bodynotifyStart);
                    bodypropCount++;
                }

                if (__workflow_bodynotifyEnd != null)
                {
                    body["notifyEnd"] = ExpressionConverter.ConvertO(__workflow_bodynotifyEnd);
                    bodypropCount++;
                }

                if (__workflow_bodynotifyEarly != null)
                {
                    body["notifyEarly"] = ExpressionConverter.ConvertO(__workflow_bodynotifyEarly);
                    bodypropCount++;
                }

                if (__workflow_bodynotifyMinutes != null)
                {
                    body["notifyMinutes"] = ExpressionConverter.ConvertO(__workflow_bodynotifyMinutes);
                    bodypropCount++;
                }

                if (__workflow_bodyautoStart != null)
                {
                    body["autoStart"] = ExpressionConverter.ConvertO(__workflow_bodyautoStart);
                    bodypropCount++;
                }

                if (__workflow_bodyautoEnd != null)
                {
                    body["autoEnd"] = ExpressionConverter.ConvertO(__workflow_bodyautoEnd);
                    bodypropCount++;
                }

                if (__workflow_bodystatuses != null)
                {
                    body["statuses"] = ExpressionConverter.ConvertO(__workflow_bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MaintenancePostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceGetResponse> MaintenanceGet(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            return new DeferredBodyAction<MaintenanceGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MaintenanceGetResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceDeleteResponse> MaintenanceDelete(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            return new DeferredBodyAction<MaintenanceDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MaintenanceDeleteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenancePutResponse> MaintenancePut(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodyend = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodycomponents = WorkflowExpression.Compile(bodycomponents, nameof(bodycomponents), required: false);
            var __workflow_bodystart = WorkflowExpression.Compile(bodystart, nameof(bodystart), required: false);
            var __workflow_bodyend = WorkflowExpression.Compile(bodyend, nameof(bodyend), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodynotify = WorkflowExpression.Compile(bodynotify, nameof(bodynotify), required: false);
            var __workflow_bodystatuses = WorkflowExpression.Compile(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<MaintenancePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodycomponents != null)
                {
                    body["components"] = ExpressionConverter.ConvertO(__workflow_bodycomponents);
                    bodypropCount++;
                }

                if (__workflow_bodystart != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodystart);
                    bodypropCount++;
                }

                if (__workflow_bodyend != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyend);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodynotify != null)
                {
                    body["notify"] = ExpressionConverter.ConvertO(__workflow_bodynotify);
                    bodypropCount++;
                }

                if (__workflow_bodystatuses != null)
                {
                    body["statuses"] = ExpressionConverter.ConvertO(__workflow_bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MaintenancePutResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdateGetResponse> MaintenanceUpdateGet(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<string>> maintenanceUpdateId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            var __workflow_maintenanceUpdateId = WorkflowExpression.Compile(maintenanceUpdateId, nameof(maintenanceUpdateId), required: true);
            return new DeferredBodyAction<MaintenanceUpdateGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1), __workflow_maintenanceUpdateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MaintenanceUpdateGetResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdateDeleteResponse> MaintenanceUpdateDelete(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<string>> maintenanceUpdateId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            var __workflow_maintenanceUpdateId = WorkflowExpression.Compile(maintenanceUpdateId, nameof(maintenanceUpdateId), required: true);
            return new DeferredBodyAction<MaintenanceUpdateDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1), __workflow_maintenanceUpdateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MaintenanceUpdateDeleteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdatePutResponse> MaintenanceUpdatePut(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<string>> maintenanceUpdateId, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystarted = null, Expression<Func<string>> bodyend = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            var __workflow_maintenanceUpdateId = WorkflowExpression.Compile(maintenanceUpdateId, nameof(maintenanceUpdateId), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodycomponents = WorkflowExpression.Compile(bodycomponents, nameof(bodycomponents), required: false);
            var __workflow_bodystarted = WorkflowExpression.Compile(bodystarted, nameof(bodystarted), required: false);
            var __workflow_bodyend = WorkflowExpression.Compile(bodyend, nameof(bodyend), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodynotify = WorkflowExpression.Compile(bodynotify, nameof(bodynotify), required: false);
            var __workflow_bodystatuses = WorkflowExpression.Compile(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<MaintenanceUpdatePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1), __workflow_maintenanceUpdateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodycomponents != null)
                {
                    body["components"] = ExpressionConverter.ConvertO(__workflow_bodycomponents);
                    bodypropCount++;
                }

                if (__workflow_bodystarted != null)
                {
                    body["started"] = ExpressionConverter.ConvertO(__workflow_bodystarted);
                    bodypropCount++;
                }

                if (__workflow_bodyend != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyend);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodynotify != null)
                {
                    body["notify"] = ExpressionConverter.ConvertO(__workflow_bodynotify);
                    bodypropCount++;
                }

                if (__workflow_bodystatuses != null)
                {
                    body["statuses"] = ExpressionConverter.ConvertO(__workflow_bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MaintenanceUpdatePutResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdatePostResponse> MaintenanceUpdate(Expression<Func<string>> pageId, Expression<Func<string>> maintenanceId, Expression<Func<string>> bodymessage = null, Expression<Func<string[]>> bodycomponents = null, Expression<Func<string>> bodystarted = null, Expression<Func<string>> bodyend = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodystatusesInputItem[]>> bodystatuses = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_maintenanceId = WorkflowExpression.Compile(maintenanceId, nameof(maintenanceId), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodycomponents = WorkflowExpression.Compile(bodycomponents, nameof(bodycomponents), required: false);
            var __workflow_bodystarted = WorkflowExpression.Compile(bodystarted, nameof(bodystarted), required: false);
            var __workflow_bodyend = WorkflowExpression.Compile(bodyend, nameof(bodyend), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodynotify = WorkflowExpression.Compile(bodynotify, nameof(bodynotify), required: false);
            var __workflow_bodystatuses = WorkflowExpression.Compile(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<MaintenanceUpdatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates", __workflow_pageId.WithUrlEncoding(1), __workflow_maintenanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodycomponents != null)
                {
                    body["components"] = ExpressionConverter.ConvertO(__workflow_bodycomponents);
                    bodypropCount++;
                }

                if (__workflow_bodystarted != null)
                {
                    body["started"] = ExpressionConverter.ConvertO(__workflow_bodystarted);
                    bodypropCount++;
                }

                if (__workflow_bodyend != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyend);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodynotify != null)
                {
                    body["notify"] = ExpressionConverter.ConvertO(__workflow_bodynotify);
                    bodypropCount++;
                }

                if (__workflow_bodystatuses != null)
                {
                    body["statuses"] = ExpressionConverter.ConvertO(__workflow_bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MaintenanceUpdatePostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PageTemplatesGetResponseItem[]> PageTemplatesGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<PageTemplatesGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/templates", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<PageTemplatesGetResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplatePostResponse> Template(Expression<Func<string>> pageId, Expression<Func<string>> bodysubdomain = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodycomponentsInputItem[]>> bodycomponents = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_bodysubdomain = WorkflowExpression.Compile(bodysubdomain, nameof(bodysubdomain), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodynotify = WorkflowExpression.Compile(bodynotify, nameof(bodynotify), required: false);
            var __workflow_bodycomponents = WorkflowExpression.Compile(bodycomponents, nameof(bodycomponents), required: false);
            return new DeferredBodyAction<TemplatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/templates", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysubdomain != null)
                {
                    body["subdomain"] = ExpressionConverter.ConvertO(__workflow_bodysubdomain);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodynotify != null)
                {
                    body["notify"] = ExpressionConverter.ConvertO(__workflow_bodynotify);
                    bodypropCount++;
                }

                if (__workflow_bodycomponents != null)
                {
                    body["components"] = ExpressionConverter.ConvertO(__workflow_bodycomponents);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TemplatePostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet(Expression<Func<string>> pageId, Expression<Func<string>> templateId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<TemplateGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/templates/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateGetResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplateDeleteResponse> TemplateDelete(Expression<Func<string>> pageId, Expression<Func<string>> templateId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<TemplateDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/templates/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateDeleteResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplatePutResponse> TemplatePut(Expression<Func<string>> pageId, Expression<Func<string>> templateId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodystatus = null, Expression<Func<bool>> bodynotify = null, Expression<Func<bodycomponentsInputItem[]>> bodycomponents = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodynotify = WorkflowExpression.Compile(bodynotify, nameof(bodynotify), required: false);
            var __workflow_bodycomponents = WorkflowExpression.Compile(bodycomponents, nameof(bodycomponents), required: false);
            return new DeferredBodyAction<TemplatePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/templates/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodynotify != null)
                {
                    body["notify"] = ExpressionConverter.ConvertO(__workflow_bodynotify);
                    bodypropCount++;
                }

                if (__workflow_bodycomponents != null)
                {
                    body["components"] = ExpressionConverter.ConvertO(__workflow_bodycomponents);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TemplatePutResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TeammatesGetResponseItem[]> TeammatesGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<TeammatesGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/team", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<TeammatesGetResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<string> TeamMember(Expression<Func<string>> pageId, Expression<Func<string>> bodyemail = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/team", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<string> TeamMemberDelete(Expression<Func<string>> pageId, Expression<Func<string>> memberId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/team/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_memberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<SubscribersGetResponseItem[]> SubscribersGet(Expression<Func<string>> pageId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SubscribersGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/subscribers", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<SubscribersGetResponseItem[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<SubscriberPostResponse> Subscriber(Expression<Func<string>> pageId, Expression<Func<string>> bodyemail = null, Expression<Func<bool>> bodyall = null, Expression<Func<bool>> bodyautoConfirm = null)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyall = WorkflowExpression.Compile(bodyall, nameof(bodyall), required: false);
            var __workflow_bodyautoConfirm = WorkflowExpression.Compile(bodyautoConfirm, nameof(bodyautoConfirm), required: false);
            return new DeferredBodyAction<SubscriberPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/subscribers", __workflow_pageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyall != null)
                {
                    body["all"] = ExpressionConverter.ConvertO(__workflow_bodyall);
                    bodypropCount++;
                }

                if (__workflow_bodyautoConfirm != null)
                {
                    body["autoConfirm"] = ExpressionConverter.ConvertO(__workflow_bodyautoConfirm);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SubscriberPostResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<string> SubscriberDelete(Expression<Func<string>> pageId, Expression<Func<string>> subscriberId)
        {
            var __workflow_pageId = WorkflowExpression.Compile(pageId, nameof(pageId), required: true);
            var __workflow_subscriberId = WorkflowExpression.Compile(subscriberId, nameof(subscriberId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/{0}/subscribers/{1}", __workflow_pageId.WithUrlEncoding(1), __workflow_subscriberId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
