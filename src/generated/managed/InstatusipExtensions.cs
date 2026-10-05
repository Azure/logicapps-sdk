//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Instatusip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InstatusipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildPagesGet))]
        public IBodyWorkflowAction<PagesGetResponseItem[]> PagesGet([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PagesGetResponseItem[]> __BuildPagesGet(WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<PagesGetResponseItem[]>(() =>
            {
                var apiCallPath = "/v2/pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<PagesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildPage))]
        public IBodyWorkflowAction<PagePostResponse> Page([WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodysubdomain = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodylogoUrl = null, [WorkflowExpression] Func<string> bodyfaviconUrl = null, [WorkflowExpression] Func<string> bodywebsiteUrl = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<bool> bodyuseLargeHeader = null, [WorkflowExpression] Func<string> bodybrandColor = null, [WorkflowExpression] Func<string> bodyokColor = null, [WorkflowExpression] Func<string> bodydisruptedColor = null, [WorkflowExpression] Func<string> bodydegradedColor = null, [WorkflowExpression] Func<string> bodydownColor = null, [WorkflowExpression] Func<string> bodynoticeColor = null, [WorkflowExpression] Func<string> bodyunknownColor = null, [WorkflowExpression] Func<string> bodygoogleAnalytics = null, [WorkflowExpression] Func<bool> bodysubscribeBySms = null, [WorkflowExpression] Func<string> bodysmsService = null, [WorkflowExpression] Func<string> bodytwilioSid = null, [WorkflowExpression] Func<string> bodytwilioToken = null, [WorkflowExpression] Func<string> bodytwilioSender = null, [WorkflowExpression] Func<string> bodyhtmlInMeta = null, [WorkflowExpression] Func<string> bodyhtmlAboveHeader = null, [WorkflowExpression] Func<string> bodyhtmlBelowHeader = null, [WorkflowExpression] Func<string> bodyhtmlAboveFooter = null, [WorkflowExpression] Func<string> bodyhtmlBelowFooter = null, [WorkflowExpression] Func<string> bodyhtmlBelowSummary = null, [WorkflowExpression] Func<string> bodycssGlobal = null, [WorkflowExpression] Func<string> bodylaunchDate = null, [WorkflowExpression] Func<string> bodydateFormat = null, [WorkflowExpression] Func<string> bodydateFormatShort = null, [WorkflowExpression] Func<string> bodytimeFormat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PagePostResponse> __BuildPage(WorkflowValue<string> bodyemail = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodysubdomain = null, WorkflowValue<string[]> bodycomponents = null, WorkflowValue<string> bodylogoUrl = null, WorkflowValue<string> bodyfaviconUrl = null, WorkflowValue<string> bodywebsiteUrl = null, WorkflowValue<string> bodylanguage = null, WorkflowValue<bool> bodyuseLargeHeader = null, WorkflowValue<string> bodybrandColor = null, WorkflowValue<string> bodyokColor = null, WorkflowValue<string> bodydisruptedColor = null, WorkflowValue<string> bodydegradedColor = null, WorkflowValue<string> bodydownColor = null, WorkflowValue<string> bodynoticeColor = null, WorkflowValue<string> bodyunknownColor = null, WorkflowValue<string> bodygoogleAnalytics = null, WorkflowValue<bool> bodysubscribeBySms = null, WorkflowValue<string> bodysmsService = null, WorkflowValue<string> bodytwilioSid = null, WorkflowValue<string> bodytwilioToken = null, WorkflowValue<string> bodytwilioSender = null, WorkflowValue<string> bodyhtmlInMeta = null, WorkflowValue<string> bodyhtmlAboveHeader = null, WorkflowValue<string> bodyhtmlBelowHeader = null, WorkflowValue<string> bodyhtmlAboveFooter = null, WorkflowValue<string> bodyhtmlBelowFooter = null, WorkflowValue<string> bodyhtmlBelowSummary = null, WorkflowValue<string> bodycssGlobal = null, WorkflowValue<string> bodylaunchDate = null, WorkflowValue<string> bodydateFormat = null, WorkflowValue<string> bodydateFormatShort = null, WorkflowValue<string> bodytimeFormat = null)
        {
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodysubdomain, nameof(bodysubdomain), required: false);
            WorkflowValue.Validate(bodycomponents, nameof(bodycomponents), required: false);
            WorkflowValue.Validate(bodylogoUrl, nameof(bodylogoUrl), required: false);
            WorkflowValue.Validate(bodyfaviconUrl, nameof(bodyfaviconUrl), required: false);
            WorkflowValue.Validate(bodywebsiteUrl, nameof(bodywebsiteUrl), required: false);
            WorkflowValue.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowValue.Validate(bodyuseLargeHeader, nameof(bodyuseLargeHeader), required: false);
            WorkflowValue.Validate(bodybrandColor, nameof(bodybrandColor), required: false);
            WorkflowValue.Validate(bodyokColor, nameof(bodyokColor), required: false);
            WorkflowValue.Validate(bodydisruptedColor, nameof(bodydisruptedColor), required: false);
            WorkflowValue.Validate(bodydegradedColor, nameof(bodydegradedColor), required: false);
            WorkflowValue.Validate(bodydownColor, nameof(bodydownColor), required: false);
            WorkflowValue.Validate(bodynoticeColor, nameof(bodynoticeColor), required: false);
            WorkflowValue.Validate(bodyunknownColor, nameof(bodyunknownColor), required: false);
            WorkflowValue.Validate(bodygoogleAnalytics, nameof(bodygoogleAnalytics), required: false);
            WorkflowValue.Validate(bodysubscribeBySms, nameof(bodysubscribeBySms), required: false);
            WorkflowValue.Validate(bodysmsService, nameof(bodysmsService), required: false);
            WorkflowValue.Validate(bodytwilioSid, nameof(bodytwilioSid), required: false);
            WorkflowValue.Validate(bodytwilioToken, nameof(bodytwilioToken), required: false);
            WorkflowValue.Validate(bodytwilioSender, nameof(bodytwilioSender), required: false);
            WorkflowValue.Validate(bodyhtmlInMeta, nameof(bodyhtmlInMeta), required: false);
            WorkflowValue.Validate(bodyhtmlAboveHeader, nameof(bodyhtmlAboveHeader), required: false);
            WorkflowValue.Validate(bodyhtmlBelowHeader, nameof(bodyhtmlBelowHeader), required: false);
            WorkflowValue.Validate(bodyhtmlAboveFooter, nameof(bodyhtmlAboveFooter), required: false);
            WorkflowValue.Validate(bodyhtmlBelowFooter, nameof(bodyhtmlBelowFooter), required: false);
            WorkflowValue.Validate(bodyhtmlBelowSummary, nameof(bodyhtmlBelowSummary), required: false);
            WorkflowValue.Validate(bodycssGlobal, nameof(bodycssGlobal), required: false);
            WorkflowValue.Validate(bodylaunchDate, nameof(bodylaunchDate), required: false);
            WorkflowValue.Validate(bodydateFormat, nameof(bodydateFormat), required: false);
            WorkflowValue.Validate(bodydateFormatShort, nameof(bodydateFormatShort), required: false);
            WorkflowValue.Validate(bodytimeFormat, nameof(bodytimeFormat), required: false);
            return new DeferredBodyAction<PagePostResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildPageDelete))]
        public IBodyWorkflowAction<PageDeleteResponse> PageDelete([WorkflowExpression] Func<string> pageId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageDeleteResponse> __BuildPageDelete(WorkflowValue<string> pageId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            return new DeferredBodyAction<PageDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PageDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildPagePut))]
        public IBodyWorkflowAction<PagePutResponse> PagePut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodysubdomain = null, [WorkflowExpression] Func<string> bodylogoUrl = null, [WorkflowExpression] Func<string> bodyfaviconUrl = null, [WorkflowExpression] Func<string> bodywebsiteUrl = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodypublicEmail = null, [WorkflowExpression] Func<bool> bodyuseLargeHeader = null, [WorkflowExpression] Func<string> bodybrandColor = null, [WorkflowExpression] Func<string> bodyokColor = null, [WorkflowExpression] Func<string> bodydisruptedColor = null, [WorkflowExpression] Func<string> bodydegradedColor = null, [WorkflowExpression] Func<string> bodydownColor = null, [WorkflowExpression] Func<string> bodynoticeColor = null, [WorkflowExpression] Func<string> bodyunknownColor = null, [WorkflowExpression] Func<string> bodygoogleAnalytics = null, [WorkflowExpression] Func<bool> bodysubscribeBySms = null, [WorkflowExpression] Func<string> bodysmsService = null, [WorkflowExpression] Func<string> bodytwilioSid = null, [WorkflowExpression] Func<string> bodytwilioToken = null, [WorkflowExpression] Func<string> bodytwilioSender = null, [WorkflowExpression] Func<string> bodyhtmlInMeta = null, [WorkflowExpression] Func<string> bodyhtmlAboveHeader = null, [WorkflowExpression] Func<string> bodyhtmlBelowHeader = null, [WorkflowExpression] Func<string> bodyhtmlAboveFooter = null, [WorkflowExpression] Func<string> bodyhtmlBelowFooter = null, [WorkflowExpression] Func<string> bodyhtmlBelowSummary = null, [WorkflowExpression] Func<string> bodycssGlobal = null, [WorkflowExpression] Func<string> bodylaunchDate = null, [WorkflowExpression] Func<string> bodydateFormat = null, [WorkflowExpression] Func<string> bodydateFormatShort = null, [WorkflowExpression] Func<string> bodytimeFormat = null, [WorkflowExpression] Func<bool> bodyprivate = null, [WorkflowExpression] Func<bool> bodyuseAllowList = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PagePutResponse> __BuildPagePut(WorkflowValue<string> pageId, WorkflowValue<string> bodyid = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodystatus = null, WorkflowValue<string> bodysubdomain = null, WorkflowValue<string> bodylogoUrl = null, WorkflowValue<string> bodyfaviconUrl = null, WorkflowValue<string> bodywebsiteUrl = null, WorkflowValue<string> bodylanguage = null, WorkflowValue<string> bodypublicEmail = null, WorkflowValue<bool> bodyuseLargeHeader = null, WorkflowValue<string> bodybrandColor = null, WorkflowValue<string> bodyokColor = null, WorkflowValue<string> bodydisruptedColor = null, WorkflowValue<string> bodydegradedColor = null, WorkflowValue<string> bodydownColor = null, WorkflowValue<string> bodynoticeColor = null, WorkflowValue<string> bodyunknownColor = null, WorkflowValue<string> bodygoogleAnalytics = null, WorkflowValue<bool> bodysubscribeBySms = null, WorkflowValue<string> bodysmsService = null, WorkflowValue<string> bodytwilioSid = null, WorkflowValue<string> bodytwilioToken = null, WorkflowValue<string> bodytwilioSender = null, WorkflowValue<string> bodyhtmlInMeta = null, WorkflowValue<string> bodyhtmlAboveHeader = null, WorkflowValue<string> bodyhtmlBelowHeader = null, WorkflowValue<string> bodyhtmlAboveFooter = null, WorkflowValue<string> bodyhtmlBelowFooter = null, WorkflowValue<string> bodyhtmlBelowSummary = null, WorkflowValue<string> bodycssGlobal = null, WorkflowValue<string> bodylaunchDate = null, WorkflowValue<string> bodydateFormat = null, WorkflowValue<string> bodydateFormatShort = null, WorkflowValue<string> bodytimeFormat = null, WorkflowValue<bool> bodyprivate = null, WorkflowValue<bool> bodyuseAllowList = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodysubdomain, nameof(bodysubdomain), required: false);
            WorkflowValue.Validate(bodylogoUrl, nameof(bodylogoUrl), required: false);
            WorkflowValue.Validate(bodyfaviconUrl, nameof(bodyfaviconUrl), required: false);
            WorkflowValue.Validate(bodywebsiteUrl, nameof(bodywebsiteUrl), required: false);
            WorkflowValue.Validate(bodylanguage, nameof(bodylanguage), required: false);
            WorkflowValue.Validate(bodypublicEmail, nameof(bodypublicEmail), required: false);
            WorkflowValue.Validate(bodyuseLargeHeader, nameof(bodyuseLargeHeader), required: false);
            WorkflowValue.Validate(bodybrandColor, nameof(bodybrandColor), required: false);
            WorkflowValue.Validate(bodyokColor, nameof(bodyokColor), required: false);
            WorkflowValue.Validate(bodydisruptedColor, nameof(bodydisruptedColor), required: false);
            WorkflowValue.Validate(bodydegradedColor, nameof(bodydegradedColor), required: false);
            WorkflowValue.Validate(bodydownColor, nameof(bodydownColor), required: false);
            WorkflowValue.Validate(bodynoticeColor, nameof(bodynoticeColor), required: false);
            WorkflowValue.Validate(bodyunknownColor, nameof(bodyunknownColor), required: false);
            WorkflowValue.Validate(bodygoogleAnalytics, nameof(bodygoogleAnalytics), required: false);
            WorkflowValue.Validate(bodysubscribeBySms, nameof(bodysubscribeBySms), required: false);
            WorkflowValue.Validate(bodysmsService, nameof(bodysmsService), required: false);
            WorkflowValue.Validate(bodytwilioSid, nameof(bodytwilioSid), required: false);
            WorkflowValue.Validate(bodytwilioToken, nameof(bodytwilioToken), required: false);
            WorkflowValue.Validate(bodytwilioSender, nameof(bodytwilioSender), required: false);
            WorkflowValue.Validate(bodyhtmlInMeta, nameof(bodyhtmlInMeta), required: false);
            WorkflowValue.Validate(bodyhtmlAboveHeader, nameof(bodyhtmlAboveHeader), required: false);
            WorkflowValue.Validate(bodyhtmlBelowHeader, nameof(bodyhtmlBelowHeader), required: false);
            WorkflowValue.Validate(bodyhtmlAboveFooter, nameof(bodyhtmlAboveFooter), required: false);
            WorkflowValue.Validate(bodyhtmlBelowFooter, nameof(bodyhtmlBelowFooter), required: false);
            WorkflowValue.Validate(bodyhtmlBelowSummary, nameof(bodyhtmlBelowSummary), required: false);
            WorkflowValue.Validate(bodycssGlobal, nameof(bodycssGlobal), required: false);
            WorkflowValue.Validate(bodylaunchDate, nameof(bodylaunchDate), required: false);
            WorkflowValue.Validate(bodydateFormat, nameof(bodydateFormat), required: false);
            WorkflowValue.Validate(bodydateFormatShort, nameof(bodydateFormatShort), required: false);
            WorkflowValue.Validate(bodytimeFormat, nameof(bodytimeFormat), required: false);
            WorkflowValue.Validate(bodyprivate, nameof(bodyprivate), required: false);
            WorkflowValue.Validate(bodyuseAllowList, nameof(bodyuseAllowList), required: false);
            return new DeferredBodyAction<PagePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/{0}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildComponentsGet))]
        public IBodyWorkflowAction<ComponentsGetResponseItem[]> ComponentsGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComponentsGetResponseItem[]> __BuildComponentsGet(WorkflowValue<string> pageId, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ComponentsGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/components", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<ComponentsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildComponent))]
        public IBodyWorkflowAction<ComponentPostResponse> Component([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<bool> bodyshowUptime = null, [WorkflowExpression] Func<bool> bodygrouped = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComponentPostResponse> __BuildComponent(WorkflowValue<string> pageId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodystatus = null, WorkflowValue<int> bodyorder = null, WorkflowValue<bool> bodyshowUptime = null, WorkflowValue<bool> bodygrouped = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodyshowUptime, nameof(bodyshowUptime), required: false);
            WorkflowValue.Validate(bodygrouped, nameof(bodygrouped), required: false);
            return new DeferredBodyAction<ComponentPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/components", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildComponentGet))]
        public IBodyWorkflowAction<ComponentGetResponse> ComponentGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> componentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComponentGetResponse> __BuildComponentGet(WorkflowValue<string> pageId, WorkflowValue<string> componentId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(componentId, nameof(componentId), required: true);
            return new DeferredBodyAction<ComponentGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/components/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(componentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComponentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildComponentDelete))]
        public IBodyWorkflowAction<ComponentDeleteResponse> ComponentDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> componentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComponentDeleteResponse> __BuildComponentDelete(WorkflowValue<string> pageId, WorkflowValue<string> componentId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(componentId, nameof(componentId), required: true);
            return new DeferredBodyAction<ComponentDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/components/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(componentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComponentDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildComponentPut))]
        public IBodyWorkflowAction<ComponentPutResponse> ComponentPut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> componentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<bool> bodyshowUptime = null, [WorkflowExpression] Func<bool> bodygrouped = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComponentPutResponse> __BuildComponentPut(WorkflowValue<string> pageId, WorkflowValue<string> componentId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodystatus = null, WorkflowValue<int> bodyorder = null, WorkflowValue<bool> bodyshowUptime = null, WorkflowValue<bool> bodygrouped = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(componentId, nameof(componentId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodyorder, nameof(bodyorder), required: false);
            WorkflowValue.Validate(bodyshowUptime, nameof(bodyshowUptime), required: false);
            WorkflowValue.Validate(bodygrouped, nameof(bodygrouped), required: false);
            return new DeferredBodyAction<ComponentPutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/components/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(componentId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildIncidentsGet))]
        public IBodyWorkflowAction<IncidentsGetResponseItem[]> IncidentsGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IncidentsGetResponseItem[]> __BuildIncidentsGet(WorkflowValue<string> pageId, WorkflowValue<string> status = null, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(status, nameof(status), required: false);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<IncidentsGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<IncidentsGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildIncident))]
        public IBodyWorkflowAction<IncidentPostResponse> Incident([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystarted = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IncidentPostResponse> __BuildIncident(WorkflowValue<string> pageId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodymessage = null, WorkflowValue<string[]> bodycomponents = null, WorkflowValue<string> bodystarted = null, WorkflowValue<string> bodystatus = null, WorkflowValue<bool> bodynotify = null, WorkflowValue<bodystatusesInputItem[]> bodystatuses = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowValue.Validate(bodycomponents, nameof(bodycomponents), required: false);
            WorkflowValue.Validate(bodystarted, nameof(bodystarted), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodynotify, nameof(bodynotify), required: false);
            WorkflowValue.Validate(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<IncidentPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildIncidentGet))]
        public IBodyWorkflowAction<IncidentGetResponse> IncidentGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IncidentGetResponse> __BuildIncidentGet(WorkflowValue<string> pageId, WorkflowValue<string> incidentId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(incidentId, nameof(incidentId), required: true);
            return new DeferredBodyAction<IncidentGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildIncidentDelete))]
        public IBodyWorkflowAction<IncidentDeleteResponse> IncidentDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IncidentDeleteResponse> __BuildIncidentDelete(WorkflowValue<string> pageId, WorkflowValue<string> incidentId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(incidentId, nameof(incidentId), required: true);
            return new DeferredBodyAction<IncidentDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildIncidentPut))]
        public IBodyWorkflowAction<IncidentPutResponse> IncidentPut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystarted = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IncidentPutResponse> __BuildIncidentPut(WorkflowValue<string> pageId, WorkflowValue<string> incidentId, WorkflowValue<string> bodyname = null, WorkflowValue<string[]> bodycomponents = null, WorkflowValue<string> bodystarted = null, WorkflowValue<string> bodystatus = null, WorkflowValue<bool> bodynotify = null, WorkflowValue<bodystatusesInputItem[]> bodystatuses = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(incidentId, nameof(incidentId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodycomponents, nameof(bodycomponents), required: false);
            WorkflowValue.Validate(bodystarted, nameof(bodystarted), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodynotify, nameof(bodynotify), required: false);
            WorkflowValue.Validate(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<IncidentPutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildIncidentTemplate))]
        public IBodyWorkflowAction<IncidentTemplatePostResponse> IncidentTemplate([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> template)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IncidentTemplatePostResponse> __BuildIncidentTemplate(WorkflowValue<string> pageId, WorkflowValue<string> template)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(template, nameof(template), required: true);
            return new DeferredBodyAction<IncidentTemplatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/{0}/incidents/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(template, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentTemplatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildIncidentUpdateGet))]
        public IBodyWorkflowAction<IncidentUpdateGetResponse> IncidentUpdateGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId, [WorkflowExpression] Func<string> incidentUpdateId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IncidentUpdateGetResponse> __BuildIncidentUpdateGet(WorkflowValue<string> pageId, WorkflowValue<string> incidentId, WorkflowValue<string> incidentUpdateId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(incidentId, nameof(incidentId), required: true);
            WorkflowValue.Validate(incidentUpdateId, nameof(incidentUpdateId), required: true);
            return new DeferredBodyAction<IncidentUpdateGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}/incident-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentUpdateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentUpdateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildIncidentUpdateDelete))]
        public IBodyWorkflowAction<IncidentUpdateDeleteResponse> IncidentUpdateDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId, [WorkflowExpression] Func<string> incidentUpdateId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IncidentUpdateDeleteResponse> __BuildIncidentUpdateDelete(WorkflowValue<string> pageId, WorkflowValue<string> incidentId, WorkflowValue<string> incidentUpdateId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(incidentId, nameof(incidentId), required: true);
            WorkflowValue.Validate(incidentUpdateId, nameof(incidentUpdateId), required: true);
            return new DeferredBodyAction<IncidentUpdateDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}/incident-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentUpdateId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentUpdateDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildIncidentUpdatePut))]
        public IBodyWorkflowAction<IncidentUpdatePutResponse> IncidentUpdatePut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId, [WorkflowExpression] Func<string> incidentUpdateId, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystarted = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IncidentUpdatePutResponse> __BuildIncidentUpdatePut(WorkflowValue<string> pageId, WorkflowValue<string> incidentId, WorkflowValue<string> incidentUpdateId, WorkflowValue<string> bodymessage = null, WorkflowValue<string[]> bodycomponents = null, WorkflowValue<string> bodystarted = null, WorkflowValue<string> bodystatus = null, WorkflowValue<bool> bodynotify = null, WorkflowValue<bodystatusesInputItem[]> bodystatuses = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(incidentId, nameof(incidentId), required: true);
            WorkflowValue.Validate(incidentUpdateId, nameof(incidentUpdateId), required: true);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowValue.Validate(bodycomponents, nameof(bodycomponents), required: false);
            WorkflowValue.Validate(bodystarted, nameof(bodystarted), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodynotify, nameof(bodynotify), required: false);
            WorkflowValue.Validate(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<IncidentUpdatePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}/incident-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentUpdateId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildIncidentUpdate))]
        public IBodyWorkflowAction<IncidentUpdatePostResponse> IncidentUpdate([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystarted = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IncidentUpdatePostResponse> __BuildIncidentUpdate(WorkflowValue<string> pageId, WorkflowValue<string> incidentId, WorkflowValue<string> bodymessage = null, WorkflowValue<string[]> bodycomponents = null, WorkflowValue<string> bodystarted = null, WorkflowValue<string> bodystatus = null, WorkflowValue<bool> bodynotify = null, WorkflowValue<bodystatusesInputItem[]> bodystatuses = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(incidentId, nameof(incidentId), required: true);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowValue.Validate(bodycomponents, nameof(bodycomponents), required: false);
            WorkflowValue.Validate(bodystarted, nameof(bodystarted), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodynotify, nameof(bodynotify), required: false);
            WorkflowValue.Validate(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<IncidentUpdatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}/incident-updates", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildIncidentUpdateTemplate))]
        public IBodyWorkflowAction<IncidentUpdateTemplatePostResponse> IncidentUpdateTemplate([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId, [WorkflowExpression] Func<string> template)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IncidentUpdateTemplatePostResponse> __BuildIncidentUpdateTemplate(WorkflowValue<string> pageId, WorkflowValue<string> incidentId, WorkflowValue<string> template)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(incidentId, nameof(incidentId), required: true);
            WorkflowValue.Validate(template, nameof(template), required: true);
            return new DeferredBodyAction<IncidentUpdateTemplatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/{0}/incidents/{1}/incident-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(incidentId, 1), ExpressionConverter.ConvertWithUrlEncoding(template, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IncidentUpdateTemplatePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildMaintenancesGet))]
        public IBodyWorkflowAction<MaintenancesGetResponseItem[]> MaintenancesGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MaintenancesGetResponseItem[]> __BuildMaintenancesGet(WorkflowValue<string> pageId, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<MaintenancesGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<MaintenancesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildMaintenance))]
        public IBodyWorkflowAction<MaintenancePostResponse> Maintenance([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<int> bodyduration = null, [WorkflowExpression] Func<bool> bodynotifyStart = null, [WorkflowExpression] Func<bool> bodynotifyEnd = null, [WorkflowExpression] Func<bool> bodynotifyEarly = null, [WorkflowExpression] Func<int> bodynotifyMinutes = null, [WorkflowExpression] Func<bool> bodyautoStart = null, [WorkflowExpression] Func<bool> bodyautoEnd = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MaintenancePostResponse> __BuildMaintenance(WorkflowValue<string> pageId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodymessage = null, WorkflowValue<string[]> bodycomponents = null, WorkflowValue<string> bodystart = null, WorkflowValue<string> bodyend = null, WorkflowValue<string> bodystatus = null, WorkflowValue<bool> bodynotify = null, WorkflowValue<int> bodyduration = null, WorkflowValue<bool> bodynotifyStart = null, WorkflowValue<bool> bodynotifyEnd = null, WorkflowValue<bool> bodynotifyEarly = null, WorkflowValue<int> bodynotifyMinutes = null, WorkflowValue<bool> bodyautoStart = null, WorkflowValue<bool> bodyautoEnd = null, WorkflowValue<bodystatusesInputItem[]> bodystatuses = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowValue.Validate(bodycomponents, nameof(bodycomponents), required: false);
            WorkflowValue.Validate(bodystart, nameof(bodystart), required: false);
            WorkflowValue.Validate(bodyend, nameof(bodyend), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodynotify, nameof(bodynotify), required: false);
            WorkflowValue.Validate(bodyduration, nameof(bodyduration), required: false);
            WorkflowValue.Validate(bodynotifyStart, nameof(bodynotifyStart), required: false);
            WorkflowValue.Validate(bodynotifyEnd, nameof(bodynotifyEnd), required: false);
            WorkflowValue.Validate(bodynotifyEarly, nameof(bodynotifyEarly), required: false);
            WorkflowValue.Validate(bodynotifyMinutes, nameof(bodynotifyMinutes), required: false);
            WorkflowValue.Validate(bodyautoStart, nameof(bodyautoStart), required: false);
            WorkflowValue.Validate(bodyautoEnd, nameof(bodyautoEnd), required: false);
            WorkflowValue.Validate(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<MaintenancePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildMaintenanceGet))]
        public IBodyWorkflowAction<MaintenanceGetResponse> MaintenanceGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MaintenanceGetResponse> __BuildMaintenanceGet(WorkflowValue<string> pageId, WorkflowValue<string> maintenanceId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(maintenanceId, nameof(maintenanceId), required: true);
            return new DeferredBodyAction<MaintenanceGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MaintenanceGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildMaintenanceDelete))]
        public IBodyWorkflowAction<MaintenanceDeleteResponse> MaintenanceDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MaintenanceDeleteResponse> __BuildMaintenanceDelete(WorkflowValue<string> pageId, WorkflowValue<string> maintenanceId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(maintenanceId, nameof(maintenanceId), required: true);
            return new DeferredBodyAction<MaintenanceDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MaintenanceDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildMaintenancePut))]
        public IBodyWorkflowAction<MaintenancePutResponse> MaintenancePut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MaintenancePutResponse> __BuildMaintenancePut(WorkflowValue<string> pageId, WorkflowValue<string> maintenanceId, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodymessage = null, WorkflowValue<string[]> bodycomponents = null, WorkflowValue<string> bodystart = null, WorkflowValue<string> bodyend = null, WorkflowValue<string> bodystatus = null, WorkflowValue<bool> bodynotify = null, WorkflowValue<bodystatusesInputItem[]> bodystatuses = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(maintenanceId, nameof(maintenanceId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowValue.Validate(bodycomponents, nameof(bodycomponents), required: false);
            WorkflowValue.Validate(bodystart, nameof(bodystart), required: false);
            WorkflowValue.Validate(bodyend, nameof(bodyend), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodynotify, nameof(bodynotify), required: false);
            WorkflowValue.Validate(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<MaintenancePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildMaintenanceUpdateGet))]
        public IBodyWorkflowAction<MaintenanceUpdateGetResponse> MaintenanceUpdateGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId, [WorkflowExpression] Func<string> maintenanceUpdateId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MaintenanceUpdateGetResponse> __BuildMaintenanceUpdateGet(WorkflowValue<string> pageId, WorkflowValue<string> maintenanceId, WorkflowValue<string> maintenanceUpdateId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(maintenanceId, nameof(maintenanceId), required: true);
            WorkflowValue.Validate(maintenanceUpdateId, nameof(maintenanceUpdateId), required: true);
            return new DeferredBodyAction<MaintenanceUpdateGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceUpdateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MaintenanceUpdateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildMaintenanceUpdateDelete))]
        public IBodyWorkflowAction<MaintenanceUpdateDeleteResponse> MaintenanceUpdateDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId, [WorkflowExpression] Func<string> maintenanceUpdateId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MaintenanceUpdateDeleteResponse> __BuildMaintenanceUpdateDelete(WorkflowValue<string> pageId, WorkflowValue<string> maintenanceId, WorkflowValue<string> maintenanceUpdateId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(maintenanceId, nameof(maintenanceId), required: true);
            WorkflowValue.Validate(maintenanceUpdateId, nameof(maintenanceUpdateId), required: true);
            return new DeferredBodyAction<MaintenanceUpdateDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceUpdateId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MaintenanceUpdateDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildMaintenanceUpdatePut))]
        public IBodyWorkflowAction<MaintenanceUpdatePutResponse> MaintenanceUpdatePut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId, [WorkflowExpression] Func<string> maintenanceUpdateId, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystarted = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MaintenanceUpdatePutResponse> __BuildMaintenanceUpdatePut(WorkflowValue<string> pageId, WorkflowValue<string> maintenanceId, WorkflowValue<string> maintenanceUpdateId, WorkflowValue<string> bodymessage = null, WorkflowValue<string[]> bodycomponents = null, WorkflowValue<string> bodystarted = null, WorkflowValue<string> bodyend = null, WorkflowValue<string> bodystatus = null, WorkflowValue<bool> bodynotify = null, WorkflowValue<bodystatusesInputItem[]> bodystatuses = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(maintenanceId, nameof(maintenanceId), required: true);
            WorkflowValue.Validate(maintenanceUpdateId, nameof(maintenanceUpdateId), required: true);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowValue.Validate(bodycomponents, nameof(bodycomponents), required: false);
            WorkflowValue.Validate(bodystarted, nameof(bodystarted), required: false);
            WorkflowValue.Validate(bodyend, nameof(bodyend), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodynotify, nameof(bodynotify), required: false);
            WorkflowValue.Validate(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<MaintenanceUpdatePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceUpdateId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildMaintenanceUpdate))]
        public IBodyWorkflowAction<MaintenanceUpdatePostResponse> MaintenanceUpdate([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystarted = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MaintenanceUpdatePostResponse> __BuildMaintenanceUpdate(WorkflowValue<string> pageId, WorkflowValue<string> maintenanceId, WorkflowValue<string> bodymessage = null, WorkflowValue<string[]> bodycomponents = null, WorkflowValue<string> bodystarted = null, WorkflowValue<string> bodyend = null, WorkflowValue<string> bodystatus = null, WorkflowValue<bool> bodynotify = null, WorkflowValue<bodystatusesInputItem[]> bodystatuses = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(maintenanceId, nameof(maintenanceId), required: true);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowValue.Validate(bodycomponents, nameof(bodycomponents), required: false);
            WorkflowValue.Validate(bodystarted, nameof(bodystarted), required: false);
            WorkflowValue.Validate(bodyend, nameof(bodyend), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodynotify, nameof(bodynotify), required: false);
            WorkflowValue.Validate(bodystatuses, nameof(bodystatuses), required: false);
            return new DeferredBodyAction<MaintenanceUpdatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(maintenanceId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildPageTemplatesGet))]
        public IBodyWorkflowAction<PageTemplatesGetResponseItem[]> PageTemplatesGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PageTemplatesGetResponseItem[]> __BuildPageTemplatesGet(WorkflowValue<string> pageId, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<PageTemplatesGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/templates", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<PageTemplatesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildTemplate))]
        public IBodyWorkflowAction<TemplatePostResponse> Template([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodysubdomain = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodycomponentsInputItem[]> bodycomponents = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TemplatePostResponse> __BuildTemplate(WorkflowValue<string> pageId, WorkflowValue<string> bodysubdomain = null, WorkflowValue<string> bodytype = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodymessage = null, WorkflowValue<string> bodystatus = null, WorkflowValue<bool> bodynotify = null, WorkflowValue<bodycomponentsInputItem[]> bodycomponents = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(bodysubdomain, nameof(bodysubdomain), required: false);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodynotify, nameof(bodynotify), required: false);
            WorkflowValue.Validate(bodycomponents, nameof(bodycomponents), required: false);
            return new DeferredBodyAction<TemplatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/templates", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildTemplateGet))]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> templateId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TemplateGetResponse> __BuildTemplateGet(WorkflowValue<string> pageId, WorkflowValue<string> templateId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<TemplateGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/templates/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildTemplateDelete))]
        public IBodyWorkflowAction<TemplateDeleteResponse> TemplateDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> templateId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TemplateDeleteResponse> __BuildTemplateDelete(WorkflowValue<string> pageId, WorkflowValue<string> templateId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<TemplateDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/templates/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildTemplatePut))]
        public IBodyWorkflowAction<TemplatePutResponse> TemplatePut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodycomponentsInputItem[]> bodycomponents = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TemplatePutResponse> __BuildTemplatePut(WorkflowValue<string> pageId, WorkflowValue<string> templateId, WorkflowValue<string> bodytype = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodymessage = null, WorkflowValue<string> bodystatus = null, WorkflowValue<bool> bodynotify = null, WorkflowValue<bodycomponentsInputItem[]> bodycomponents = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodynotify, nameof(bodynotify), required: false);
            WorkflowValue.Validate(bodycomponents, nameof(bodycomponents), required: false);
            return new DeferredBodyAction<TemplatePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/templates/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildTeammatesGet))]
        public IBodyWorkflowAction<TeammatesGetResponseItem[]> TeammatesGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TeammatesGetResponseItem[]> __BuildTeammatesGet(WorkflowValue<string> pageId, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<TeammatesGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/team", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<TeammatesGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildTeamMember))]
        public IBodyWorkflowAction<string> TeamMember([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodyemail = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildTeamMember(WorkflowValue<string> pageId, WorkflowValue<string> bodyemail = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/team", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildTeamMemberDelete))]
        public IBodyWorkflowAction<string> TeamMemberDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> memberId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildTeamMemberDelete(WorkflowValue<string> pageId, WorkflowValue<string> memberId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(memberId, nameof(memberId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/team/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(memberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildSubscribersGet))]
        public IBodyWorkflowAction<SubscribersGetResponseItem[]> SubscribersGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscribersGetResponseItem[]> __BuildSubscribersGet(WorkflowValue<string> pageId, WorkflowValue<int> page = null, WorkflowValue<int> perPage = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(page, nameof(page), required: false);
            WorkflowValue.Validate(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<SubscribersGetResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/subscribers", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
                return new ApiConnectionAction<SubscribersGetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildSubscriber))]
        public IBodyWorkflowAction<SubscriberPostResponse> Subscriber([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<bool> bodyall = null, [WorkflowExpression] Func<bool> bodyautoConfirm = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SubscriberPostResponse> __BuildSubscriber(WorkflowValue<string> pageId, WorkflowValue<string> bodyemail = null, WorkflowValue<bool> bodyall = null, WorkflowValue<bool> bodyautoConfirm = null)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowValue.Validate(bodyall, nameof(bodyall), required: false);
            WorkflowValue.Validate(bodyautoConfirm, nameof(bodyautoConfirm), required: false);
            return new DeferredBodyAction<SubscriberPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/subscribers", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        [WorkflowExpressionFactory(nameof(__BuildSubscriberDelete))]
        public IBodyWorkflowAction<string> SubscriberDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> subscriberId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildSubscriberDelete(WorkflowValue<string> pageId, WorkflowValue<string> subscriberId)
        {
            WorkflowValue.Validate(pageId, nameof(pageId), required: true);
            WorkflowValue.Validate(subscriberId, nameof(subscriberId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/{0}/subscribers/{1}", ExpressionConverter.ConvertWithUrlEncoding(pageId, 1), ExpressionConverter.ConvertWithUrlEncoding(subscriberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
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
