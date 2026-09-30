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
        public IBodyWorkflowAction<PagesGetResponseItem[]> PagesGet([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/pages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<PagesGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PagePostResponse> Page([WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodysubdomain = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodylogoUrl = null, [WorkflowExpression] Func<string> bodyfaviconUrl = null, [WorkflowExpression] Func<string> bodywebsiteUrl = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<bool> bodyuseLargeHeader = null, [WorkflowExpression] Func<string> bodybrandColor = null, [WorkflowExpression] Func<string> bodyokColor = null, [WorkflowExpression] Func<string> bodydisruptedColor = null, [WorkflowExpression] Func<string> bodydegradedColor = null, [WorkflowExpression] Func<string> bodydownColor = null, [WorkflowExpression] Func<string> bodynoticeColor = null, [WorkflowExpression] Func<string> bodyunknownColor = null, [WorkflowExpression] Func<string> bodygoogleAnalytics = null, [WorkflowExpression] Func<bool> bodysubscribeBySms = null, [WorkflowExpression] Func<string> bodysmsService = null, [WorkflowExpression] Func<string> bodytwilioSid = null, [WorkflowExpression] Func<string> bodytwilioToken = null, [WorkflowExpression] Func<string> bodytwilioSender = null, [WorkflowExpression] Func<string> bodyhtmlInMeta = null, [WorkflowExpression] Func<string> bodyhtmlAboveHeader = null, [WorkflowExpression] Func<string> bodyhtmlBelowHeader = null, [WorkflowExpression] Func<string> bodyhtmlAboveFooter = null, [WorkflowExpression] Func<string> bodyhtmlBelowFooter = null, [WorkflowExpression] Func<string> bodyhtmlBelowSummary = null, [WorkflowExpression] Func<string> bodycssGlobal = null, [WorkflowExpression] Func<string> bodylaunchDate = null, [WorkflowExpression] Func<string> bodydateFormat = null, [WorkflowExpression] Func<string> bodydateFormatShort = null, [WorkflowExpression] Func<string> bodytimeFormat = null)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodysubdomain, nameof(bodysubdomain), required: false);
            SourceExpression.Validate(bodycomponents, nameof(bodycomponents), required: false);
            SourceExpression.Validate(bodylogoUrl, nameof(bodylogoUrl), required: false);
            SourceExpression.Validate(bodyfaviconUrl, nameof(bodyfaviconUrl), required: false);
            SourceExpression.Validate(bodywebsiteUrl, nameof(bodywebsiteUrl), required: false);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            SourceExpression.Validate(bodyuseLargeHeader, nameof(bodyuseLargeHeader), required: false);
            SourceExpression.Validate(bodybrandColor, nameof(bodybrandColor), required: false);
            SourceExpression.Validate(bodyokColor, nameof(bodyokColor), required: false);
            SourceExpression.Validate(bodydisruptedColor, nameof(bodydisruptedColor), required: false);
            SourceExpression.Validate(bodydegradedColor, nameof(bodydegradedColor), required: false);
            SourceExpression.Validate(bodydownColor, nameof(bodydownColor), required: false);
            SourceExpression.Validate(bodynoticeColor, nameof(bodynoticeColor), required: false);
            SourceExpression.Validate(bodyunknownColor, nameof(bodyunknownColor), required: false);
            SourceExpression.Validate(bodygoogleAnalytics, nameof(bodygoogleAnalytics), required: false);
            SourceExpression.Validate(bodysubscribeBySms, nameof(bodysubscribeBySms), required: false);
            SourceExpression.Validate(bodysmsService, nameof(bodysmsService), required: false);
            SourceExpression.Validate(bodytwilioSid, nameof(bodytwilioSid), required: false);
            SourceExpression.Validate(bodytwilioToken, nameof(bodytwilioToken), required: false);
            SourceExpression.Validate(bodytwilioSender, nameof(bodytwilioSender), required: false);
            SourceExpression.Validate(bodyhtmlInMeta, nameof(bodyhtmlInMeta), required: false);
            SourceExpression.Validate(bodyhtmlAboveHeader, nameof(bodyhtmlAboveHeader), required: false);
            SourceExpression.Validate(bodyhtmlBelowHeader, nameof(bodyhtmlBelowHeader), required: false);
            SourceExpression.Validate(bodyhtmlAboveFooter, nameof(bodyhtmlAboveFooter), required: false);
            SourceExpression.Validate(bodyhtmlBelowFooter, nameof(bodyhtmlBelowFooter), required: false);
            SourceExpression.Validate(bodyhtmlBelowSummary, nameof(bodyhtmlBelowSummary), required: false);
            SourceExpression.Validate(bodycssGlobal, nameof(bodycssGlobal), required: false);
            SourceExpression.Validate(bodylaunchDate, nameof(bodylaunchDate), required: false);
            SourceExpression.Validate(bodydateFormat, nameof(bodydateFormat), required: false);
            SourceExpression.Validate(bodydateFormatShort, nameof(bodydateFormatShort), required: false);
            SourceExpression.Validate(bodytimeFormat, nameof(bodytimeFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodysubdomain != null)
                {
                    body["subdomain"] = SourceExpressionConverter.ConvertToken(bodysubdomain);
                    bodypropCount++;
                }

                if (bodycomponents != null)
                {
                    body["components"] = SourceExpressionConverter.ConvertToken(bodycomponents);
                    bodypropCount++;
                }

                if (bodylogoUrl != null)
                {
                    body["logoUrl"] = SourceExpressionConverter.ConvertToken(bodylogoUrl);
                    bodypropCount++;
                }

                if (bodyfaviconUrl != null)
                {
                    body["faviconUrl"] = SourceExpressionConverter.ConvertToken(bodyfaviconUrl);
                    bodypropCount++;
                }

                if (bodywebsiteUrl != null)
                {
                    body["websiteUrl"] = SourceExpressionConverter.ConvertToken(bodywebsiteUrl);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodyuseLargeHeader != null)
                {
                    body["useLargeHeader"] = SourceExpressionConverter.ConvertToken(bodyuseLargeHeader);
                    bodypropCount++;
                }

                if (bodybrandColor != null)
                {
                    body["brandColor"] = SourceExpressionConverter.ConvertToken(bodybrandColor);
                    bodypropCount++;
                }

                if (bodyokColor != null)
                {
                    body["okColor"] = SourceExpressionConverter.ConvertToken(bodyokColor);
                    bodypropCount++;
                }

                if (bodydisruptedColor != null)
                {
                    body["disruptedColor"] = SourceExpressionConverter.ConvertToken(bodydisruptedColor);
                    bodypropCount++;
                }

                if (bodydegradedColor != null)
                {
                    body["degradedColor"] = SourceExpressionConverter.ConvertToken(bodydegradedColor);
                    bodypropCount++;
                }

                if (bodydownColor != null)
                {
                    body["downColor"] = SourceExpressionConverter.ConvertToken(bodydownColor);
                    bodypropCount++;
                }

                if (bodynoticeColor != null)
                {
                    body["noticeColor"] = SourceExpressionConverter.ConvertToken(bodynoticeColor);
                    bodypropCount++;
                }

                if (bodyunknownColor != null)
                {
                    body["unknownColor"] = SourceExpressionConverter.ConvertToken(bodyunknownColor);
                    bodypropCount++;
                }

                if (bodygoogleAnalytics != null)
                {
                    body["googleAnalytics"] = SourceExpressionConverter.ConvertToken(bodygoogleAnalytics);
                    bodypropCount++;
                }

                if (bodysubscribeBySms != null)
                {
                    body["subscribeBySms"] = SourceExpressionConverter.ConvertToken(bodysubscribeBySms);
                    bodypropCount++;
                }

                if (bodysmsService != null)
                {
                    body["smsService"] = SourceExpressionConverter.ConvertToken(bodysmsService);
                    bodypropCount++;
                }

                if (bodytwilioSid != null)
                {
                    body["twilioSid"] = SourceExpressionConverter.ConvertToken(bodytwilioSid);
                    bodypropCount++;
                }

                if (bodytwilioToken != null)
                {
                    body["twilioToken"] = SourceExpressionConverter.ConvertToken(bodytwilioToken);
                    bodypropCount++;
                }

                if (bodytwilioSender != null)
                {
                    body["twilioSender"] = SourceExpressionConverter.ConvertToken(bodytwilioSender);
                    bodypropCount++;
                }

                if (bodyhtmlInMeta != null)
                {
                    body["htmlInMeta"] = SourceExpressionConverter.ConvertToken(bodyhtmlInMeta);
                    bodypropCount++;
                }

                if (bodyhtmlAboveHeader != null)
                {
                    body["htmlAboveHeader"] = SourceExpressionConverter.ConvertToken(bodyhtmlAboveHeader);
                    bodypropCount++;
                }

                if (bodyhtmlBelowHeader != null)
                {
                    body["htmlBelowHeader"] = SourceExpressionConverter.ConvertToken(bodyhtmlBelowHeader);
                    bodypropCount++;
                }

                if (bodyhtmlAboveFooter != null)
                {
                    body["htmlAboveFooter"] = SourceExpressionConverter.ConvertToken(bodyhtmlAboveFooter);
                    bodypropCount++;
                }

                if (bodyhtmlBelowFooter != null)
                {
                    body["htmlBelowFooter"] = SourceExpressionConverter.ConvertToken(bodyhtmlBelowFooter);
                    bodypropCount++;
                }

                if (bodyhtmlBelowSummary != null)
                {
                    body["htmlBelowSummary"] = SourceExpressionConverter.ConvertToken(bodyhtmlBelowSummary);
                    bodypropCount++;
                }

                if (bodycssGlobal != null)
                {
                    body["cssGlobal"] = SourceExpressionConverter.ConvertToken(bodycssGlobal);
                    bodypropCount++;
                }

                if (bodylaunchDate != null)
                {
                    body["launchDate"] = SourceExpressionConverter.ConvertToken(bodylaunchDate);
                    bodypropCount++;
                }

                if (bodydateFormat != null)
                {
                    body["dateFormat"] = SourceExpressionConverter.ConvertToken(bodydateFormat);
                    bodypropCount++;
                }

                if (bodydateFormatShort != null)
                {
                    body["dateFormatShort"] = SourceExpressionConverter.ConvertToken(bodydateFormatShort);
                    bodypropCount++;
                }

                if (bodytimeFormat != null)
                {
                    body["timeFormat"] = SourceExpressionConverter.ConvertToken(bodytimeFormat);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PagePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PageDeleteResponse> PageDelete([WorkflowExpression] Func<string> pageId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PageDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PagePutResponse> PagePut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodysubdomain = null, [WorkflowExpression] Func<string> bodylogoUrl = null, [WorkflowExpression] Func<string> bodyfaviconUrl = null, [WorkflowExpression] Func<string> bodywebsiteUrl = null, [WorkflowExpression] Func<string> bodylanguage = null, [WorkflowExpression] Func<string> bodypublicEmail = null, [WorkflowExpression] Func<bool> bodyuseLargeHeader = null, [WorkflowExpression] Func<string> bodybrandColor = null, [WorkflowExpression] Func<string> bodyokColor = null, [WorkflowExpression] Func<string> bodydisruptedColor = null, [WorkflowExpression] Func<string> bodydegradedColor = null, [WorkflowExpression] Func<string> bodydownColor = null, [WorkflowExpression] Func<string> bodynoticeColor = null, [WorkflowExpression] Func<string> bodyunknownColor = null, [WorkflowExpression] Func<string> bodygoogleAnalytics = null, [WorkflowExpression] Func<bool> bodysubscribeBySms = null, [WorkflowExpression] Func<string> bodysmsService = null, [WorkflowExpression] Func<string> bodytwilioSid = null, [WorkflowExpression] Func<string> bodytwilioToken = null, [WorkflowExpression] Func<string> bodytwilioSender = null, [WorkflowExpression] Func<string> bodyhtmlInMeta = null, [WorkflowExpression] Func<string> bodyhtmlAboveHeader = null, [WorkflowExpression] Func<string> bodyhtmlBelowHeader = null, [WorkflowExpression] Func<string> bodyhtmlAboveFooter = null, [WorkflowExpression] Func<string> bodyhtmlBelowFooter = null, [WorkflowExpression] Func<string> bodyhtmlBelowSummary = null, [WorkflowExpression] Func<string> bodycssGlobal = null, [WorkflowExpression] Func<string> bodylaunchDate = null, [WorkflowExpression] Func<string> bodydateFormat = null, [WorkflowExpression] Func<string> bodydateFormatShort = null, [WorkflowExpression] Func<string> bodytimeFormat = null, [WorkflowExpression] Func<bool> bodyPrivate = null, [WorkflowExpression] Func<bool> bodyuseAllowList = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodysubdomain, nameof(bodysubdomain), required: false);
            SourceExpression.Validate(bodylogoUrl, nameof(bodylogoUrl), required: false);
            SourceExpression.Validate(bodyfaviconUrl, nameof(bodyfaviconUrl), required: false);
            SourceExpression.Validate(bodywebsiteUrl, nameof(bodywebsiteUrl), required: false);
            SourceExpression.Validate(bodylanguage, nameof(bodylanguage), required: false);
            SourceExpression.Validate(bodypublicEmail, nameof(bodypublicEmail), required: false);
            SourceExpression.Validate(bodyuseLargeHeader, nameof(bodyuseLargeHeader), required: false);
            SourceExpression.Validate(bodybrandColor, nameof(bodybrandColor), required: false);
            SourceExpression.Validate(bodyokColor, nameof(bodyokColor), required: false);
            SourceExpression.Validate(bodydisruptedColor, nameof(bodydisruptedColor), required: false);
            SourceExpression.Validate(bodydegradedColor, nameof(bodydegradedColor), required: false);
            SourceExpression.Validate(bodydownColor, nameof(bodydownColor), required: false);
            SourceExpression.Validate(bodynoticeColor, nameof(bodynoticeColor), required: false);
            SourceExpression.Validate(bodyunknownColor, nameof(bodyunknownColor), required: false);
            SourceExpression.Validate(bodygoogleAnalytics, nameof(bodygoogleAnalytics), required: false);
            SourceExpression.Validate(bodysubscribeBySms, nameof(bodysubscribeBySms), required: false);
            SourceExpression.Validate(bodysmsService, nameof(bodysmsService), required: false);
            SourceExpression.Validate(bodytwilioSid, nameof(bodytwilioSid), required: false);
            SourceExpression.Validate(bodytwilioToken, nameof(bodytwilioToken), required: false);
            SourceExpression.Validate(bodytwilioSender, nameof(bodytwilioSender), required: false);
            SourceExpression.Validate(bodyhtmlInMeta, nameof(bodyhtmlInMeta), required: false);
            SourceExpression.Validate(bodyhtmlAboveHeader, nameof(bodyhtmlAboveHeader), required: false);
            SourceExpression.Validate(bodyhtmlBelowHeader, nameof(bodyhtmlBelowHeader), required: false);
            SourceExpression.Validate(bodyhtmlAboveFooter, nameof(bodyhtmlAboveFooter), required: false);
            SourceExpression.Validate(bodyhtmlBelowFooter, nameof(bodyhtmlBelowFooter), required: false);
            SourceExpression.Validate(bodyhtmlBelowSummary, nameof(bodyhtmlBelowSummary), required: false);
            SourceExpression.Validate(bodycssGlobal, nameof(bodycssGlobal), required: false);
            SourceExpression.Validate(bodylaunchDate, nameof(bodylaunchDate), required: false);
            SourceExpression.Validate(bodydateFormat, nameof(bodydateFormat), required: false);
            SourceExpression.Validate(bodydateFormatShort, nameof(bodydateFormatShort), required: false);
            SourceExpression.Validate(bodytimeFormat, nameof(bodytimeFormat), required: false);
            SourceExpression.Validate(bodyPrivate, nameof(bodyPrivate), required: false);
            SourceExpression.Validate(bodyuseAllowList, nameof(bodyuseAllowList), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
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

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodysubdomain != null)
                {
                    body["subdomain"] = SourceExpressionConverter.ConvertToken(bodysubdomain);
                    bodypropCount++;
                }

                if (bodylogoUrl != null)
                {
                    body["logoUrl"] = SourceExpressionConverter.ConvertToken(bodylogoUrl);
                    bodypropCount++;
                }

                if (bodyfaviconUrl != null)
                {
                    body["faviconUrl"] = SourceExpressionConverter.ConvertToken(bodyfaviconUrl);
                    bodypropCount++;
                }

                if (bodywebsiteUrl != null)
                {
                    body["websiteUrl"] = SourceExpressionConverter.ConvertToken(bodywebsiteUrl);
                    bodypropCount++;
                }

                if (bodylanguage != null)
                {
                    body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                    bodypropCount++;
                }

                if (bodypublicEmail != null)
                {
                    body["publicEmail"] = SourceExpressionConverter.ConvertToken(bodypublicEmail);
                    bodypropCount++;
                }

                if (bodyuseLargeHeader != null)
                {
                    body["useLargeHeader"] = SourceExpressionConverter.ConvertToken(bodyuseLargeHeader);
                    bodypropCount++;
                }

                if (bodybrandColor != null)
                {
                    body["brandColor"] = SourceExpressionConverter.ConvertToken(bodybrandColor);
                    bodypropCount++;
                }

                if (bodyokColor != null)
                {
                    body["okColor"] = SourceExpressionConverter.ConvertToken(bodyokColor);
                    bodypropCount++;
                }

                if (bodydisruptedColor != null)
                {
                    body["disruptedColor"] = SourceExpressionConverter.ConvertToken(bodydisruptedColor);
                    bodypropCount++;
                }

                if (bodydegradedColor != null)
                {
                    body["degradedColor"] = SourceExpressionConverter.ConvertToken(bodydegradedColor);
                    bodypropCount++;
                }

                if (bodydownColor != null)
                {
                    body["downColor"] = SourceExpressionConverter.ConvertToken(bodydownColor);
                    bodypropCount++;
                }

                if (bodynoticeColor != null)
                {
                    body["noticeColor"] = SourceExpressionConverter.ConvertToken(bodynoticeColor);
                    bodypropCount++;
                }

                if (bodyunknownColor != null)
                {
                    body["unknownColor"] = SourceExpressionConverter.ConvertToken(bodyunknownColor);
                    bodypropCount++;
                }

                if (bodygoogleAnalytics != null)
                {
                    body["googleAnalytics"] = SourceExpressionConverter.ConvertToken(bodygoogleAnalytics);
                    bodypropCount++;
                }

                if (bodysubscribeBySms != null)
                {
                    body["subscribeBySms"] = SourceExpressionConverter.ConvertToken(bodysubscribeBySms);
                    bodypropCount++;
                }

                if (bodysmsService != null)
                {
                    body["smsService"] = SourceExpressionConverter.ConvertToken(bodysmsService);
                    bodypropCount++;
                }

                if (bodytwilioSid != null)
                {
                    body["twilioSid"] = SourceExpressionConverter.ConvertToken(bodytwilioSid);
                    bodypropCount++;
                }

                if (bodytwilioToken != null)
                {
                    body["twilioToken"] = SourceExpressionConverter.ConvertToken(bodytwilioToken);
                    bodypropCount++;
                }

                if (bodytwilioSender != null)
                {
                    body["twilioSender"] = SourceExpressionConverter.ConvertToken(bodytwilioSender);
                    bodypropCount++;
                }

                if (bodyhtmlInMeta != null)
                {
                    body["htmlInMeta"] = SourceExpressionConverter.ConvertToken(bodyhtmlInMeta);
                    bodypropCount++;
                }

                if (bodyhtmlAboveHeader != null)
                {
                    body["htmlAboveHeader"] = SourceExpressionConverter.ConvertToken(bodyhtmlAboveHeader);
                    bodypropCount++;
                }

                if (bodyhtmlBelowHeader != null)
                {
                    body["htmlBelowHeader"] = SourceExpressionConverter.ConvertToken(bodyhtmlBelowHeader);
                    bodypropCount++;
                }

                if (bodyhtmlAboveFooter != null)
                {
                    body["htmlAboveFooter"] = SourceExpressionConverter.ConvertToken(bodyhtmlAboveFooter);
                    bodypropCount++;
                }

                if (bodyhtmlBelowFooter != null)
                {
                    body["htmlBelowFooter"] = SourceExpressionConverter.ConvertToken(bodyhtmlBelowFooter);
                    bodypropCount++;
                }

                if (bodyhtmlBelowSummary != null)
                {
                    body["htmlBelowSummary"] = SourceExpressionConverter.ConvertToken(bodyhtmlBelowSummary);
                    bodypropCount++;
                }

                if (bodycssGlobal != null)
                {
                    body["cssGlobal"] = SourceExpressionConverter.ConvertToken(bodycssGlobal);
                    bodypropCount++;
                }

                if (bodylaunchDate != null)
                {
                    body["launchDate"] = SourceExpressionConverter.ConvertToken(bodylaunchDate);
                    bodypropCount++;
                }

                if (bodydateFormat != null)
                {
                    body["dateFormat"] = SourceExpressionConverter.ConvertToken(bodydateFormat);
                    bodypropCount++;
                }

                if (bodydateFormatShort != null)
                {
                    body["dateFormatShort"] = SourceExpressionConverter.ConvertToken(bodydateFormatShort);
                    bodypropCount++;
                }

                if (bodytimeFormat != null)
                {
                    body["timeFormat"] = SourceExpressionConverter.ConvertToken(bodytimeFormat);
                    bodypropCount++;
                }

                if (bodyPrivate != null)
                {
                    body["private"] = SourceExpressionConverter.ConvertToken(bodyPrivate);
                    bodypropCount++;
                }

                if (bodyuseAllowList != null)
                {
                    body["useAllowList"] = SourceExpressionConverter.ConvertToken(bodyuseAllowList);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PagePutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentsGetResponseItem[]> ComponentsGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/components", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<ComponentsGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentPostResponse> Component([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<bool> bodyshowUptime = null, [WorkflowExpression] Func<bool> bodygrouped = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodyshowUptime, nameof(bodyshowUptime), required: false);
            SourceExpression.Validate(bodygrouped, nameof(bodygrouped), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/components", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                if (bodyshowUptime != null)
                {
                    body["showUptime"] = SourceExpressionConverter.ConvertToken(bodyshowUptime);
                    bodypropCount++;
                }

                if (bodygrouped != null)
                {
                    body["grouped"] = SourceExpressionConverter.ConvertToken(bodygrouped);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ComponentPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentGetResponse> ComponentGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> componentId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(componentId, nameof(componentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/components/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(componentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ComponentGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentDeleteResponse> ComponentDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> componentId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(componentId, nameof(componentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/components/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(componentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ComponentDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<ComponentPutResponse> ComponentPut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> componentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodyorder = null, [WorkflowExpression] Func<bool> bodyshowUptime = null, [WorkflowExpression] Func<bool> bodygrouped = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(componentId, nameof(componentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyorder, nameof(bodyorder), required: false);
            SourceExpression.Validate(bodyshowUptime, nameof(bodyshowUptime), required: false);
            SourceExpression.Validate(bodygrouped, nameof(bodygrouped), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/components/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(componentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyorder != null)
                {
                    body["order"] = SourceExpressionConverter.ConvertToken(bodyorder);
                    bodypropCount++;
                }

                if (bodyshowUptime != null)
                {
                    body["showUptime"] = SourceExpressionConverter.ConvertToken(bodyshowUptime);
                    bodypropCount++;
                }

                if (bodygrouped != null)
                {
                    body["grouped"] = SourceExpressionConverter.ConvertToken(bodygrouped);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ComponentPutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentsGetResponseItem[]> IncidentsGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<IncidentsGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentPostResponse> Incident([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystarted = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodycomponents, nameof(bodycomponents), required: false);
            SourceExpression.Validate(bodystarted, nameof(bodystarted), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodynotify, nameof(bodynotify), required: false);
            SourceExpression.Validate(bodystatuses, nameof(bodystatuses), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodycomponents != null)
                {
                    body["components"] = SourceExpressionConverter.ConvertToken(bodycomponents);
                    bodypropCount++;
                }

                if (bodystarted != null)
                {
                    body["started"] = SourceExpressionConverter.ConvertToken(bodystarted);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodynotify != null)
                {
                    body["notify"] = SourceExpressionConverter.ConvertToken(bodynotify);
                    bodypropCount++;
                }

                if (bodystatuses != null)
                {
                    body["statuses"] = SourceExpressionConverter.ConvertToken(bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IncidentPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentGetResponse> IncidentGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(incidentId, nameof(incidentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(incidentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IncidentGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentDeleteResponse> IncidentDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(incidentId, nameof(incidentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(incidentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IncidentDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentPutResponse> IncidentPut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystarted = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(incidentId, nameof(incidentId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodycomponents, nameof(bodycomponents), required: false);
            SourceExpression.Validate(bodystarted, nameof(bodystarted), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodynotify, nameof(bodynotify), required: false);
            SourceExpression.Validate(bodystatuses, nameof(bodystatuses), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(incidentId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycomponents != null)
                {
                    body["components"] = SourceExpressionConverter.ConvertToken(bodycomponents);
                    bodypropCount++;
                }

                if (bodystarted != null)
                {
                    body["started"] = SourceExpressionConverter.ConvertToken(bodystarted);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodynotify != null)
                {
                    body["notify"] = SourceExpressionConverter.ConvertToken(bodynotify);
                    bodypropCount++;
                }

                if (bodystatuses != null)
                {
                    body["statuses"] = SourceExpressionConverter.ConvertToken(bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IncidentPutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentTemplatePostResponse> IncidentTemplate([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> template)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(template, nameof(template), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/{0}/incidents/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(template, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IncidentTemplatePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdateGetResponse> IncidentUpdateGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId, [WorkflowExpression] Func<string> incidentUpdateId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(incidentId, nameof(incidentId), required: true);
            SourceExpression.Validate(incidentUpdateId, nameof(incidentUpdateId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}/incident-updates/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(incidentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(incidentUpdateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IncidentUpdateGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdateDeleteResponse> IncidentUpdateDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId, [WorkflowExpression] Func<string> incidentUpdateId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(incidentId, nameof(incidentId), required: true);
            SourceExpression.Validate(incidentUpdateId, nameof(incidentUpdateId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}/incident-updates/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(incidentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(incidentUpdateId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IncidentUpdateDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdatePutResponse> IncidentUpdatePut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId, [WorkflowExpression] Func<string> incidentUpdateId, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystarted = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(incidentId, nameof(incidentId), required: true);
            SourceExpression.Validate(incidentUpdateId, nameof(incidentUpdateId), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodycomponents, nameof(bodycomponents), required: false);
            SourceExpression.Validate(bodystarted, nameof(bodystarted), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodynotify, nameof(bodynotify), required: false);
            SourceExpression.Validate(bodystatuses, nameof(bodystatuses), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}/incident-updates/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(incidentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(incidentUpdateId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodycomponents != null)
                {
                    body["components"] = SourceExpressionConverter.ConvertToken(bodycomponents);
                    bodypropCount++;
                }

                if (bodystarted != null)
                {
                    body["started"] = SourceExpressionConverter.ConvertToken(bodystarted);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodynotify != null)
                {
                    body["notify"] = SourceExpressionConverter.ConvertToken(bodynotify);
                    bodypropCount++;
                }

                if (bodystatuses != null)
                {
                    body["statuses"] = SourceExpressionConverter.ConvertToken(bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IncidentUpdatePutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdatePostResponse> IncidentUpdate([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystarted = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(incidentId, nameof(incidentId), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodycomponents, nameof(bodycomponents), required: false);
            SourceExpression.Validate(bodystarted, nameof(bodystarted), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodynotify, nameof(bodynotify), required: false);
            SourceExpression.Validate(bodystatuses, nameof(bodystatuses), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/incidents/{1}/incident-updates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(incidentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodycomponents != null)
                {
                    body["components"] = SourceExpressionConverter.ConvertToken(bodycomponents);
                    bodypropCount++;
                }

                if (bodystarted != null)
                {
                    body["started"] = SourceExpressionConverter.ConvertToken(bodystarted);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodynotify != null)
                {
                    body["notify"] = SourceExpressionConverter.ConvertToken(bodynotify);
                    bodypropCount++;
                }

                if (bodystatuses != null)
                {
                    body["statuses"] = SourceExpressionConverter.ConvertToken(bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IncidentUpdatePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<IncidentUpdateTemplatePostResponse> IncidentUpdateTemplate([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> incidentId, [WorkflowExpression] Func<string> template)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(incidentId, nameof(incidentId), required: true);
            SourceExpression.Validate(template, nameof(template), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/{0}/incidents/{1}/incident-updates/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(incidentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(template, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<IncidentUpdateTemplatePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenancesGetResponseItem[]> MaintenancesGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<MaintenancesGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenancePostResponse> Maintenance([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<int> bodyduration = null, [WorkflowExpression] Func<bool> bodynotifyStart = null, [WorkflowExpression] Func<bool> bodynotifyEnd = null, [WorkflowExpression] Func<bool> bodynotifyEarly = null, [WorkflowExpression] Func<int> bodynotifyMinutes = null, [WorkflowExpression] Func<bool> bodyautoStart = null, [WorkflowExpression] Func<bool> bodyautoEnd = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodycomponents, nameof(bodycomponents), required: false);
            SourceExpression.Validate(bodystart, nameof(bodystart), required: false);
            SourceExpression.Validate(bodyend, nameof(bodyend), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodynotify, nameof(bodynotify), required: false);
            SourceExpression.Validate(bodyduration, nameof(bodyduration), required: false);
            SourceExpression.Validate(bodynotifyStart, nameof(bodynotifyStart), required: false);
            SourceExpression.Validate(bodynotifyEnd, nameof(bodynotifyEnd), required: false);
            SourceExpression.Validate(bodynotifyEarly, nameof(bodynotifyEarly), required: false);
            SourceExpression.Validate(bodynotifyMinutes, nameof(bodynotifyMinutes), required: false);
            SourceExpression.Validate(bodyautoStart, nameof(bodyautoStart), required: false);
            SourceExpression.Validate(bodyautoEnd, nameof(bodyautoEnd), required: false);
            SourceExpression.Validate(bodystatuses, nameof(bodystatuses), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodycomponents != null)
                {
                    body["components"] = SourceExpressionConverter.ConvertToken(bodycomponents);
                    bodypropCount++;
                }

                if (bodystart != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodystart);
                    bodypropCount++;
                }

                if (bodyend != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyend);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodynotify != null)
                {
                    body["notify"] = SourceExpressionConverter.ConvertToken(bodynotify);
                    bodypropCount++;
                }

                if (bodyduration != null)
                {
                    body["duration"] = SourceExpressionConverter.ConvertToken(bodyduration);
                    bodypropCount++;
                }

                if (bodynotifyStart != null)
                {
                    body["notifyStart"] = SourceExpressionConverter.ConvertToken(bodynotifyStart);
                    bodypropCount++;
                }

                if (bodynotifyEnd != null)
                {
                    body["notifyEnd"] = SourceExpressionConverter.ConvertToken(bodynotifyEnd);
                    bodypropCount++;
                }

                if (bodynotifyEarly != null)
                {
                    body["notifyEarly"] = SourceExpressionConverter.ConvertToken(bodynotifyEarly);
                    bodypropCount++;
                }

                if (bodynotifyMinutes != null)
                {
                    body["notifyMinutes"] = SourceExpressionConverter.ConvertToken(bodynotifyMinutes);
                    bodypropCount++;
                }

                if (bodyautoStart != null)
                {
                    body["autoStart"] = SourceExpressionConverter.ConvertToken(bodyautoStart);
                    bodypropCount++;
                }

                if (bodyautoEnd != null)
                {
                    body["autoEnd"] = SourceExpressionConverter.ConvertToken(bodyautoEnd);
                    bodypropCount++;
                }

                if (bodystatuses != null)
                {
                    body["statuses"] = SourceExpressionConverter.ConvertToken(bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MaintenancePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceGetResponse> MaintenanceGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(maintenanceId, nameof(maintenanceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(maintenanceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MaintenanceGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceDeleteResponse> MaintenanceDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(maintenanceId, nameof(maintenanceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(maintenanceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MaintenanceDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenancePutResponse> MaintenancePut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(maintenanceId, nameof(maintenanceId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodycomponents, nameof(bodycomponents), required: false);
            SourceExpression.Validate(bodystart, nameof(bodystart), required: false);
            SourceExpression.Validate(bodyend, nameof(bodyend), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodynotify, nameof(bodynotify), required: false);
            SourceExpression.Validate(bodystatuses, nameof(bodystatuses), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(maintenanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodycomponents != null)
                {
                    body["components"] = SourceExpressionConverter.ConvertToken(bodycomponents);
                    bodypropCount++;
                }

                if (bodystart != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodystart);
                    bodypropCount++;
                }

                if (bodyend != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyend);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodynotify != null)
                {
                    body["notify"] = SourceExpressionConverter.ConvertToken(bodynotify);
                    bodypropCount++;
                }

                if (bodystatuses != null)
                {
                    body["statuses"] = SourceExpressionConverter.ConvertToken(bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MaintenancePutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdateGetResponse> MaintenanceUpdateGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId, [WorkflowExpression] Func<string> maintenanceUpdateId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(maintenanceId, nameof(maintenanceId), required: true);
            SourceExpression.Validate(maintenanceUpdateId, nameof(maintenanceUpdateId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(maintenanceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(maintenanceUpdateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MaintenanceUpdateGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdateDeleteResponse> MaintenanceUpdateDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId, [WorkflowExpression] Func<string> maintenanceUpdateId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(maintenanceId, nameof(maintenanceId), required: true);
            SourceExpression.Validate(maintenanceUpdateId, nameof(maintenanceUpdateId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(maintenanceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(maintenanceUpdateId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MaintenanceUpdateDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdatePutResponse> MaintenanceUpdatePut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId, [WorkflowExpression] Func<string> maintenanceUpdateId, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystarted = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(maintenanceId, nameof(maintenanceId), required: true);
            SourceExpression.Validate(maintenanceUpdateId, nameof(maintenanceUpdateId), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodycomponents, nameof(bodycomponents), required: false);
            SourceExpression.Validate(bodystarted, nameof(bodystarted), required: false);
            SourceExpression.Validate(bodyend, nameof(bodyend), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodynotify, nameof(bodynotify), required: false);
            SourceExpression.Validate(bodystatuses, nameof(bodystatuses), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(maintenanceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(maintenanceUpdateId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodycomponents != null)
                {
                    body["components"] = SourceExpressionConverter.ConvertToken(bodycomponents);
                    bodypropCount++;
                }

                if (bodystarted != null)
                {
                    body["started"] = SourceExpressionConverter.ConvertToken(bodystarted);
                    bodypropCount++;
                }

                if (bodyend != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyend);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodynotify != null)
                {
                    body["notify"] = SourceExpressionConverter.ConvertToken(bodynotify);
                    bodypropCount++;
                }

                if (bodystatuses != null)
                {
                    body["statuses"] = SourceExpressionConverter.ConvertToken(bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MaintenanceUpdatePutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<MaintenanceUpdatePostResponse> MaintenanceUpdate([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> maintenanceId, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string[]> bodycomponents = null, [WorkflowExpression] Func<string> bodystarted = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodystatusesInputItem[]> bodystatuses = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(maintenanceId, nameof(maintenanceId), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodycomponents, nameof(bodycomponents), required: false);
            SourceExpression.Validate(bodystarted, nameof(bodystarted), required: false);
            SourceExpression.Validate(bodyend, nameof(bodyend), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodynotify, nameof(bodynotify), required: false);
            SourceExpression.Validate(bodystatuses, nameof(bodystatuses), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/maintenances/{1}/maintenance-updates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(maintenanceId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodycomponents != null)
                {
                    body["components"] = SourceExpressionConverter.ConvertToken(bodycomponents);
                    bodypropCount++;
                }

                if (bodystarted != null)
                {
                    body["started"] = SourceExpressionConverter.ConvertToken(bodystarted);
                    bodypropCount++;
                }

                if (bodyend != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyend);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodynotify != null)
                {
                    body["notify"] = SourceExpressionConverter.ConvertToken(bodynotify);
                    bodypropCount++;
                }

                if (bodystatuses != null)
                {
                    body["statuses"] = SourceExpressionConverter.ConvertToken(bodystatuses);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MaintenanceUpdatePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<PageTemplatesGetResponseItem[]> PageTemplatesGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/templates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<PageTemplatesGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplatePostResponse> Template([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodysubdomain = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodycomponentsInputItem[]> bodycomponents = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(bodysubdomain, nameof(bodysubdomain), required: false);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodynotify, nameof(bodynotify), required: false);
            SourceExpression.Validate(bodycomponents, nameof(bodycomponents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/templates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysubdomain != null)
                {
                    body["subdomain"] = SourceExpressionConverter.ConvertToken(bodysubdomain);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodynotify != null)
                {
                    body["notify"] = SourceExpressionConverter.ConvertToken(bodynotify);
                    bodypropCount++;
                }

                if (bodycomponents != null)
                {
                    body["components"] = SourceExpressionConverter.ConvertToken(bodycomponents);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TemplatePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> templateId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/templates/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TemplateGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplateDeleteResponse> TemplateDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> templateId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/templates/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TemplateDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TemplatePutResponse> TemplatePut([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<bool> bodynotify = null, [WorkflowExpression] Func<bodycomponentsInputItem[]> bodycomponents = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodynotify, nameof(bodynotify), required: false);
            SourceExpression.Validate(bodycomponents, nameof(bodycomponents), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/templates/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodynotify != null)
                {
                    body["notify"] = SourceExpressionConverter.ConvertToken(bodynotify);
                    bodypropCount++;
                }

                if (bodycomponents != null)
                {
                    body["components"] = SourceExpressionConverter.ConvertToken(bodycomponents);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TemplatePutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<TeammatesGetResponseItem[]> TeammatesGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/team", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<TeammatesGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<string> TeamMember([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodyemail = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/team", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<string> TeamMemberDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> memberId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(memberId, nameof(memberId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/team/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(memberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<SubscribersGetResponseItem[]> SubscribersGet([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/subscribers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<SubscribersGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<SubscriberPostResponse> Subscriber([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<bool> bodyall = null, [WorkflowExpression] Func<bool> bodyautoConfirm = null)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            SourceExpression.Validate(bodyall, nameof(bodyall), required: false);
            SourceExpression.Validate(bodyautoConfirm, nameof(bodyautoConfirm), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/subscribers", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyall != null)
                {
                    body["all"] = SourceExpressionConverter.ConvertToken(bodyall);
                    bodypropCount++;
                }

                if (bodyautoConfirm != null)
                {
                    body["autoConfirm"] = SourceExpressionConverter.ConvertToken(bodyautoConfirm);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SubscriberPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "instatusip")]
        public IBodyWorkflowAction<string> SubscriberDelete([WorkflowExpression] Func<string> pageId, [WorkflowExpression] Func<string> subscriberId)
        {
            SourceExpression.Validate(pageId, nameof(pageId), required: true);
            SourceExpression.Validate(subscriberId, nameof(subscriberId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/{0}/subscribers/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pageId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(subscriberId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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