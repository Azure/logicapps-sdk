//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pagepixelsscreenshot
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PagepixelsscreenshotActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pagepixelsscreenshot")]
        public IBodyWorkflowAction<QuickSnapResponse, ApiConnectionActionConfiguration> QuickSnap(Expression<Func<string>> url, Expression<Func<string>> timeZone = null, Expression<Func<string[]>> multiStepActions = null, Expression<Func<int>> wait = null, Expression<Func<string>> waitFor = null, Expression<Func<bool>> incrementalScroll = null, Expression<Func<int>> pageWidth = null, Expression<Func<int>> pageHeight = null, Expression<Func<bool>> fullpage = null, Expression<Func<bool>> fullpageAdvanced = null, Expression<Func<string>> selectors = null, Expression<Func<bool>> hoverOnSelected = null, Expression<Func<ImageFormatInput>> imageFormat = null, Expression<Func<int>> quality = null, Expression<Func<ScaleFactorInput>> scaleFactor = null, Expression<Func<string>> cssInject = null, Expression<Func<string>> jsInject = null, Expression<Func<string>> userAgent = null, Expression<Func<string[]>> headers = null, Expression<Func<string[]>> cookies = null, Expression<Func<int>> ttl = null, Expression<Func<string>> acceptLanguage = null, Expression<Func<string>> latitude = null, Expression<Func<string>> longitude = null, Expression<Func<string>> accuracy = null, Expression<Func<int>> thumbWidth = null, Expression<Func<int>> thumbHeight = null, Expression<Func<bool>> noAds = null, Expression<Func<bool>> noTracking = null, Expression<Func<bool>> noCookieBanners = null, Expression<Func<bool>> disableJs = null, Expression<Func<bool>> disableThirdPartyJs = null, Expression<Func<string>> customTitle = null, Expression<Func<string>> customDescription = null)
        {
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: true);
            var __workflow_timeZone = WorkflowExpression.Compile(timeZone, nameof(timeZone), required: false);
            var __workflow_multiStepActions = WorkflowExpression.Compile(multiStepActions, nameof(multiStepActions), required: false);
            var __workflow_wait = WorkflowExpression.Compile(wait, nameof(wait), required: false);
            var __workflow_waitFor = WorkflowExpression.Compile(waitFor, nameof(waitFor), required: false);
            var __workflow_incrementalScroll = WorkflowExpression.Compile(incrementalScroll, nameof(incrementalScroll), required: false);
            var __workflow_pageWidth = WorkflowExpression.Compile(pageWidth, nameof(pageWidth), required: false);
            var __workflow_pageHeight = WorkflowExpression.Compile(pageHeight, nameof(pageHeight), required: false);
            var __workflow_fullpage = WorkflowExpression.Compile(fullpage, nameof(fullpage), required: false);
            var __workflow_fullpageAdvanced = WorkflowExpression.Compile(fullpageAdvanced, nameof(fullpageAdvanced), required: false);
            var __workflow_selectors = WorkflowExpression.Compile(selectors, nameof(selectors), required: false);
            var __workflow_hoverOnSelected = WorkflowExpression.Compile(hoverOnSelected, nameof(hoverOnSelected), required: false);
            var __workflow_imageFormat = WorkflowExpression.Compile(imageFormat, nameof(imageFormat), required: false);
            var __workflow_quality = WorkflowExpression.Compile(quality, nameof(quality), required: false);
            var __workflow_scaleFactor = WorkflowExpression.Compile(scaleFactor, nameof(scaleFactor), required: false);
            var __workflow_cssInject = WorkflowExpression.Compile(cssInject, nameof(cssInject), required: false);
            var __workflow_jsInject = WorkflowExpression.Compile(jsInject, nameof(jsInject), required: false);
            var __workflow_userAgent = WorkflowExpression.Compile(userAgent, nameof(userAgent), required: false);
            var __workflow_headers = WorkflowExpression.Compile(headers, nameof(headers), required: false);
            var __workflow_cookies = WorkflowExpression.Compile(cookies, nameof(cookies), required: false);
            var __workflow_ttl = WorkflowExpression.Compile(ttl, nameof(ttl), required: false);
            var __workflow_acceptLanguage = WorkflowExpression.Compile(acceptLanguage, nameof(acceptLanguage), required: false);
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: false);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: false);
            var __workflow_accuracy = WorkflowExpression.Compile(accuracy, nameof(accuracy), required: false);
            var __workflow_thumbWidth = WorkflowExpression.Compile(thumbWidth, nameof(thumbWidth), required: false);
            var __workflow_thumbHeight = WorkflowExpression.Compile(thumbHeight, nameof(thumbHeight), required: false);
            var __workflow_noAds = WorkflowExpression.Compile(noAds, nameof(noAds), required: false);
            var __workflow_noTracking = WorkflowExpression.Compile(noTracking, nameof(noTracking), required: false);
            var __workflow_noCookieBanners = WorkflowExpression.Compile(noCookieBanners, nameof(noCookieBanners), required: false);
            var __workflow_disableJs = WorkflowExpression.Compile(disableJs, nameof(disableJs), required: false);
            var __workflow_disableThirdPartyJs = WorkflowExpression.Compile(disableThirdPartyJs, nameof(disableThirdPartyJs), required: false);
            var __workflow_customTitle = WorkflowExpression.Compile(customTitle, nameof(customTitle), required: false);
            var __workflow_customDescription = WorkflowExpression.Compile(customDescription, nameof(customDescription), required: false);
            return new DeferredBodyAction<QuickSnapResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/snap";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["microsoft"] = Convert.ToString(true);
                callPayload.Queries["json"] = Convert.ToString(true);
                callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                if (__workflow_timeZone != null)
                    callPayload.Queries["time_zone"] = ExpressionConverter.Convert(__workflow_timeZone);
                if (__workflow_multiStepActions != null)
                    callPayload.Queries["multi_step_actions"] = ExpressionConverter.Convert(__workflow_multiStepActions);
                if (__workflow_wait != null)
                    callPayload.Queries["wait"] = ExpressionConverter.Convert(__workflow_wait);
                if (__workflow_waitFor != null)
                    callPayload.Queries["wait_for"] = ExpressionConverter.Convert(__workflow_waitFor);
                if (__workflow_incrementalScroll != null)
                    callPayload.Queries["incremental_scroll"] = ExpressionConverter.Convert(__workflow_incrementalScroll);
                if (__workflow_pageWidth != null)
                    callPayload.Queries["page_width"] = ExpressionConverter.Convert(__workflow_pageWidth);
                if (__workflow_pageHeight != null)
                    callPayload.Queries["page_height"] = ExpressionConverter.Convert(__workflow_pageHeight);
                if (__workflow_fullpage != null)
                    callPayload.Queries["fullpage"] = ExpressionConverter.Convert(__workflow_fullpage);
                if (__workflow_fullpageAdvanced != null)
                    callPayload.Queries["fullpage_advanced"] = ExpressionConverter.Convert(__workflow_fullpageAdvanced);
                if (__workflow_selectors != null)
                    callPayload.Queries["selectors"] = ExpressionConverter.Convert(__workflow_selectors);
                if (__workflow_hoverOnSelected != null)
                    callPayload.Queries["hover_on_selected"] = ExpressionConverter.Convert(__workflow_hoverOnSelected);
                if (__workflow_imageFormat != null)
                    callPayload.Queries["image_format"] = ExpressionConverter.Convert(__workflow_imageFormat);
                if (__workflow_quality != null)
                    callPayload.Queries["quality"] = ExpressionConverter.Convert(__workflow_quality);
                callPayload.Queries["scale_factor"] = Convert.ToString(1);
                if (__workflow_scaleFactor != null)
                    callPayload.Queries["scale_factor"] = ExpressionConverter.Convert(__workflow_scaleFactor);
                if (__workflow_cssInject != null)
                    callPayload.Queries["css_inject"] = ExpressionConverter.Convert(__workflow_cssInject);
                if (__workflow_jsInject != null)
                    callPayload.Queries["js_inject"] = ExpressionConverter.Convert(__workflow_jsInject);
                if (__workflow_userAgent != null)
                    callPayload.Queries["user_agent"] = ExpressionConverter.Convert(__workflow_userAgent);
                if (__workflow_headers != null)
                    callPayload.Queries["headers"] = ExpressionConverter.Convert(__workflow_headers);
                if (__workflow_cookies != null)
                    callPayload.Queries["cookies"] = ExpressionConverter.Convert(__workflow_cookies);
                if (__workflow_ttl != null)
                    callPayload.Queries["ttl"] = ExpressionConverter.Convert(__workflow_ttl);
                if (__workflow_acceptLanguage != null)
                    callPayload.Queries["accept_language"] = ExpressionConverter.Convert(__workflow_acceptLanguage);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_accuracy != null)
                    callPayload.Queries["accuracy"] = ExpressionConverter.Convert(__workflow_accuracy);
                if (__workflow_thumbWidth != null)
                    callPayload.Queries["thumb_width"] = ExpressionConverter.Convert(__workflow_thumbWidth);
                if (__workflow_thumbHeight != null)
                    callPayload.Queries["thumb_height"] = ExpressionConverter.Convert(__workflow_thumbHeight);
                if (__workflow_noAds != null)
                    callPayload.Queries["no_ads"] = ExpressionConverter.Convert(__workflow_noAds);
                if (__workflow_noTracking != null)
                    callPayload.Queries["no_tracking"] = ExpressionConverter.Convert(__workflow_noTracking);
                if (__workflow_noCookieBanners != null)
                    callPayload.Queries["no_cookie_banners"] = ExpressionConverter.Convert(__workflow_noCookieBanners);
                if (__workflow_disableJs != null)
                    callPayload.Queries["disable_js"] = ExpressionConverter.Convert(__workflow_disableJs);
                if (__workflow_disableThirdPartyJs != null)
                    callPayload.Queries["disable_third_party_js"] = ExpressionConverter.Convert(__workflow_disableThirdPartyJs);
                if (__workflow_customTitle != null)
                    callPayload.Queries["custom_title"] = ExpressionConverter.Convert(__workflow_customTitle);
                if (__workflow_customDescription != null)
                    callPayload.Queries["custom_description"] = ExpressionConverter.Convert(__workflow_customDescription);
                return new ApiConnectionAction<QuickSnapResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pagepixelsscreenshot")]
        public IBodyWorkflowAction<SnapHtmlResponse, ApiConnectionActionConfiguration> SnapHtml(Expression<Func<string>> htmlContent, Expression<Func<string>> timeZone = null, Expression<Func<string[]>> multiStepActions = null, Expression<Func<int>> wait = null, Expression<Func<string>> waitFor = null, Expression<Func<bool>> incrementalScroll = null, Expression<Func<int>> pageWidth = null, Expression<Func<int>> pageHeight = null, Expression<Func<bool>> fullpage = null, Expression<Func<bool>> fullpageAdvanced = null, Expression<Func<string>> selectors = null, Expression<Func<bool>> hoverOnSelected = null, Expression<Func<ImageFormatInput>> imageFormat = null, Expression<Func<int>> quality = null, Expression<Func<ScaleFactorInput>> scaleFactor = null, Expression<Func<string>> cssInject = null, Expression<Func<string>> jsInject = null, Expression<Func<string>> userAgent = null, Expression<Func<string[]>> headers = null, Expression<Func<string[]>> cookies = null, Expression<Func<int>> ttl = null, Expression<Func<string>> acceptLanguage = null, Expression<Func<string>> latitude = null, Expression<Func<string>> longitude = null, Expression<Func<string>> accuracy = null, Expression<Func<int>> thumbWidth = null, Expression<Func<int>> thumbHeight = null, Expression<Func<bool>> noAds = null, Expression<Func<bool>> noTracking = null, Expression<Func<bool>> noCookieBanners = null, Expression<Func<bool>> disableJs = null, Expression<Func<bool>> disableThirdPartyJs = null, Expression<Func<string>> customTitle = null, Expression<Func<string>> customDescription = null)
        {
            var __workflow_htmlContent = WorkflowExpression.Compile(htmlContent, nameof(htmlContent), required: true);
            var __workflow_timeZone = WorkflowExpression.Compile(timeZone, nameof(timeZone), required: false);
            var __workflow_multiStepActions = WorkflowExpression.Compile(multiStepActions, nameof(multiStepActions), required: false);
            var __workflow_wait = WorkflowExpression.Compile(wait, nameof(wait), required: false);
            var __workflow_waitFor = WorkflowExpression.Compile(waitFor, nameof(waitFor), required: false);
            var __workflow_incrementalScroll = WorkflowExpression.Compile(incrementalScroll, nameof(incrementalScroll), required: false);
            var __workflow_pageWidth = WorkflowExpression.Compile(pageWidth, nameof(pageWidth), required: false);
            var __workflow_pageHeight = WorkflowExpression.Compile(pageHeight, nameof(pageHeight), required: false);
            var __workflow_fullpage = WorkflowExpression.Compile(fullpage, nameof(fullpage), required: false);
            var __workflow_fullpageAdvanced = WorkflowExpression.Compile(fullpageAdvanced, nameof(fullpageAdvanced), required: false);
            var __workflow_selectors = WorkflowExpression.Compile(selectors, nameof(selectors), required: false);
            var __workflow_hoverOnSelected = WorkflowExpression.Compile(hoverOnSelected, nameof(hoverOnSelected), required: false);
            var __workflow_imageFormat = WorkflowExpression.Compile(imageFormat, nameof(imageFormat), required: false);
            var __workflow_quality = WorkflowExpression.Compile(quality, nameof(quality), required: false);
            var __workflow_scaleFactor = WorkflowExpression.Compile(scaleFactor, nameof(scaleFactor), required: false);
            var __workflow_cssInject = WorkflowExpression.Compile(cssInject, nameof(cssInject), required: false);
            var __workflow_jsInject = WorkflowExpression.Compile(jsInject, nameof(jsInject), required: false);
            var __workflow_userAgent = WorkflowExpression.Compile(userAgent, nameof(userAgent), required: false);
            var __workflow_headers = WorkflowExpression.Compile(headers, nameof(headers), required: false);
            var __workflow_cookies = WorkflowExpression.Compile(cookies, nameof(cookies), required: false);
            var __workflow_ttl = WorkflowExpression.Compile(ttl, nameof(ttl), required: false);
            var __workflow_acceptLanguage = WorkflowExpression.Compile(acceptLanguage, nameof(acceptLanguage), required: false);
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: false);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: false);
            var __workflow_accuracy = WorkflowExpression.Compile(accuracy, nameof(accuracy), required: false);
            var __workflow_thumbWidth = WorkflowExpression.Compile(thumbWidth, nameof(thumbWidth), required: false);
            var __workflow_thumbHeight = WorkflowExpression.Compile(thumbHeight, nameof(thumbHeight), required: false);
            var __workflow_noAds = WorkflowExpression.Compile(noAds, nameof(noAds), required: false);
            var __workflow_noTracking = WorkflowExpression.Compile(noTracking, nameof(noTracking), required: false);
            var __workflow_noCookieBanners = WorkflowExpression.Compile(noCookieBanners, nameof(noCookieBanners), required: false);
            var __workflow_disableJs = WorkflowExpression.Compile(disableJs, nameof(disableJs), required: false);
            var __workflow_disableThirdPartyJs = WorkflowExpression.Compile(disableThirdPartyJs, nameof(disableThirdPartyJs), required: false);
            var __workflow_customTitle = WorkflowExpression.Compile(customTitle, nameof(customTitle), required: false);
            var __workflow_customDescription = WorkflowExpression.Compile(customDescription, nameof(customDescription), required: false);
            return new DeferredBodyAction<SnapHtmlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/snap_html";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["microsoft"] = Convert.ToString(true);
                callPayload.Queries["json"] = Convert.ToString(true);
                callPayload.Queries["html_content"] = ExpressionConverter.Convert(__workflow_htmlContent);
                if (__workflow_timeZone != null)
                    callPayload.Queries["time_zone"] = ExpressionConverter.Convert(__workflow_timeZone);
                if (__workflow_multiStepActions != null)
                    callPayload.Queries["multi_step_actions"] = ExpressionConverter.Convert(__workflow_multiStepActions);
                if (__workflow_wait != null)
                    callPayload.Queries["wait"] = ExpressionConverter.Convert(__workflow_wait);
                if (__workflow_waitFor != null)
                    callPayload.Queries["wait_for"] = ExpressionConverter.Convert(__workflow_waitFor);
                if (__workflow_incrementalScroll != null)
                    callPayload.Queries["incremental_scroll"] = ExpressionConverter.Convert(__workflow_incrementalScroll);
                if (__workflow_pageWidth != null)
                    callPayload.Queries["page_width"] = ExpressionConverter.Convert(__workflow_pageWidth);
                if (__workflow_pageHeight != null)
                    callPayload.Queries["page_height"] = ExpressionConverter.Convert(__workflow_pageHeight);
                if (__workflow_fullpage != null)
                    callPayload.Queries["fullpage"] = ExpressionConverter.Convert(__workflow_fullpage);
                if (__workflow_fullpageAdvanced != null)
                    callPayload.Queries["fullpage_advanced"] = ExpressionConverter.Convert(__workflow_fullpageAdvanced);
                if (__workflow_selectors != null)
                    callPayload.Queries["selectors"] = ExpressionConverter.Convert(__workflow_selectors);
                if (__workflow_hoverOnSelected != null)
                    callPayload.Queries["hover_on_selected"] = ExpressionConverter.Convert(__workflow_hoverOnSelected);
                if (__workflow_imageFormat != null)
                    callPayload.Queries["image_format"] = ExpressionConverter.Convert(__workflow_imageFormat);
                if (__workflow_quality != null)
                    callPayload.Queries["quality"] = ExpressionConverter.Convert(__workflow_quality);
                callPayload.Queries["scale_factor"] = Convert.ToString(1);
                if (__workflow_scaleFactor != null)
                    callPayload.Queries["scale_factor"] = ExpressionConverter.Convert(__workflow_scaleFactor);
                if (__workflow_cssInject != null)
                    callPayload.Queries["css_inject"] = ExpressionConverter.Convert(__workflow_cssInject);
                if (__workflow_jsInject != null)
                    callPayload.Queries["js_inject"] = ExpressionConverter.Convert(__workflow_jsInject);
                if (__workflow_userAgent != null)
                    callPayload.Queries["user_agent"] = ExpressionConverter.Convert(__workflow_userAgent);
                if (__workflow_headers != null)
                    callPayload.Queries["headers"] = ExpressionConverter.Convert(__workflow_headers);
                if (__workflow_cookies != null)
                    callPayload.Queries["cookies"] = ExpressionConverter.Convert(__workflow_cookies);
                if (__workflow_ttl != null)
                    callPayload.Queries["ttl"] = ExpressionConverter.Convert(__workflow_ttl);
                if (__workflow_acceptLanguage != null)
                    callPayload.Queries["accept_language"] = ExpressionConverter.Convert(__workflow_acceptLanguage);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_accuracy != null)
                    callPayload.Queries["accuracy"] = ExpressionConverter.Convert(__workflow_accuracy);
                if (__workflow_thumbWidth != null)
                    callPayload.Queries["thumb_width"] = ExpressionConverter.Convert(__workflow_thumbWidth);
                if (__workflow_thumbHeight != null)
                    callPayload.Queries["thumb_height"] = ExpressionConverter.Convert(__workflow_thumbHeight);
                if (__workflow_noAds != null)
                    callPayload.Queries["no_ads"] = ExpressionConverter.Convert(__workflow_noAds);
                if (__workflow_noTracking != null)
                    callPayload.Queries["no_tracking"] = ExpressionConverter.Convert(__workflow_noTracking);
                if (__workflow_noCookieBanners != null)
                    callPayload.Queries["no_cookie_banners"] = ExpressionConverter.Convert(__workflow_noCookieBanners);
                if (__workflow_disableJs != null)
                    callPayload.Queries["disable_js"] = ExpressionConverter.Convert(__workflow_disableJs);
                if (__workflow_disableThirdPartyJs != null)
                    callPayload.Queries["disable_third_party_js"] = ExpressionConverter.Convert(__workflow_disableThirdPartyJs);
                if (__workflow_customTitle != null)
                    callPayload.Queries["custom_title"] = ExpressionConverter.Convert(__workflow_customTitle);
                if (__workflow_customDescription != null)
                    callPayload.Queries["custom_description"] = ExpressionConverter.Convert(__workflow_customDescription);
                return new ApiConnectionAction<SnapHtmlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pagepixelsscreenshot")]
        public IBodyWorkflowAction<RealLocationScreenshotResponse, ApiConnectionActionConfiguration> RealLocationScreenshot(Expression<Func<string>> url, Expression<Func<ProxyServerInput>> proxyServer, Expression<Func<string>> timeZone = null, Expression<Func<string[]>> multiStepActions = null, Expression<Func<int>> wait = null, Expression<Func<string>> waitFor = null, Expression<Func<bool>> incrementalScroll = null, Expression<Func<int>> pageWidth = null, Expression<Func<int>> pageHeight = null, Expression<Func<bool>> fullpage = null, Expression<Func<bool>> fullpageAdvanced = null, Expression<Func<string>> selectors = null, Expression<Func<bool>> hoverOnSelected = null, Expression<Func<ImageFormatInput>> imageFormat = null, Expression<Func<int>> quality = null, Expression<Func<ScaleFactorInput>> scaleFactor = null, Expression<Func<string>> cssInject = null, Expression<Func<string>> jsInject = null, Expression<Func<string>> userAgent = null, Expression<Func<string[]>> headers = null, Expression<Func<string[]>> cookies = null, Expression<Func<int>> ttl = null, Expression<Func<string>> acceptLanguage = null, Expression<Func<string>> latitude = null, Expression<Func<string>> longitude = null, Expression<Func<string>> accuracy = null, Expression<Func<int>> thumbWidth = null, Expression<Func<int>> thumbHeight = null, Expression<Func<bool>> noAds = null, Expression<Func<bool>> noTracking = null, Expression<Func<bool>> noCookieBanners = null, Expression<Func<bool>> disableJs = null, Expression<Func<bool>> disableThirdPartyJs = null, Expression<Func<string>> customTitle = null, Expression<Func<string>> customDescription = null)
        {
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: true);
            var __workflow_proxyServer = WorkflowExpression.Compile(proxyServer, nameof(proxyServer), required: true);
            var __workflow_timeZone = WorkflowExpression.Compile(timeZone, nameof(timeZone), required: false);
            var __workflow_multiStepActions = WorkflowExpression.Compile(multiStepActions, nameof(multiStepActions), required: false);
            var __workflow_wait = WorkflowExpression.Compile(wait, nameof(wait), required: false);
            var __workflow_waitFor = WorkflowExpression.Compile(waitFor, nameof(waitFor), required: false);
            var __workflow_incrementalScroll = WorkflowExpression.Compile(incrementalScroll, nameof(incrementalScroll), required: false);
            var __workflow_pageWidth = WorkflowExpression.Compile(pageWidth, nameof(pageWidth), required: false);
            var __workflow_pageHeight = WorkflowExpression.Compile(pageHeight, nameof(pageHeight), required: false);
            var __workflow_fullpage = WorkflowExpression.Compile(fullpage, nameof(fullpage), required: false);
            var __workflow_fullpageAdvanced = WorkflowExpression.Compile(fullpageAdvanced, nameof(fullpageAdvanced), required: false);
            var __workflow_selectors = WorkflowExpression.Compile(selectors, nameof(selectors), required: false);
            var __workflow_hoverOnSelected = WorkflowExpression.Compile(hoverOnSelected, nameof(hoverOnSelected), required: false);
            var __workflow_imageFormat = WorkflowExpression.Compile(imageFormat, nameof(imageFormat), required: false);
            var __workflow_quality = WorkflowExpression.Compile(quality, nameof(quality), required: false);
            var __workflow_scaleFactor = WorkflowExpression.Compile(scaleFactor, nameof(scaleFactor), required: false);
            var __workflow_cssInject = WorkflowExpression.Compile(cssInject, nameof(cssInject), required: false);
            var __workflow_jsInject = WorkflowExpression.Compile(jsInject, nameof(jsInject), required: false);
            var __workflow_userAgent = WorkflowExpression.Compile(userAgent, nameof(userAgent), required: false);
            var __workflow_headers = WorkflowExpression.Compile(headers, nameof(headers), required: false);
            var __workflow_cookies = WorkflowExpression.Compile(cookies, nameof(cookies), required: false);
            var __workflow_ttl = WorkflowExpression.Compile(ttl, nameof(ttl), required: false);
            var __workflow_acceptLanguage = WorkflowExpression.Compile(acceptLanguage, nameof(acceptLanguage), required: false);
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: false);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: false);
            var __workflow_accuracy = WorkflowExpression.Compile(accuracy, nameof(accuracy), required: false);
            var __workflow_thumbWidth = WorkflowExpression.Compile(thumbWidth, nameof(thumbWidth), required: false);
            var __workflow_thumbHeight = WorkflowExpression.Compile(thumbHeight, nameof(thumbHeight), required: false);
            var __workflow_noAds = WorkflowExpression.Compile(noAds, nameof(noAds), required: false);
            var __workflow_noTracking = WorkflowExpression.Compile(noTracking, nameof(noTracking), required: false);
            var __workflow_noCookieBanners = WorkflowExpression.Compile(noCookieBanners, nameof(noCookieBanners), required: false);
            var __workflow_disableJs = WorkflowExpression.Compile(disableJs, nameof(disableJs), required: false);
            var __workflow_disableThirdPartyJs = WorkflowExpression.Compile(disableThirdPartyJs, nameof(disableThirdPartyJs), required: false);
            var __workflow_customTitle = WorkflowExpression.Compile(customTitle, nameof(customTitle), required: false);
            var __workflow_customDescription = WorkflowExpression.Compile(customDescription, nameof(customDescription), required: false);
            return new DeferredBodyAction<RealLocationScreenshotResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/snap_real_location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["microsoft"] = Convert.ToString(true);
                callPayload.Queries["json"] = Convert.ToString(true);
                callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                callPayload.Queries["proxy_server"] = ExpressionConverter.Convert(__workflow_proxyServer);
                if (__workflow_timeZone != null)
                    callPayload.Queries["time_zone"] = ExpressionConverter.Convert(__workflow_timeZone);
                if (__workflow_multiStepActions != null)
                    callPayload.Queries["multi_step_actions"] = ExpressionConverter.Convert(__workflow_multiStepActions);
                if (__workflow_wait != null)
                    callPayload.Queries["wait"] = ExpressionConverter.Convert(__workflow_wait);
                if (__workflow_waitFor != null)
                    callPayload.Queries["wait_for"] = ExpressionConverter.Convert(__workflow_waitFor);
                if (__workflow_incrementalScroll != null)
                    callPayload.Queries["incremental_scroll"] = ExpressionConverter.Convert(__workflow_incrementalScroll);
                if (__workflow_pageWidth != null)
                    callPayload.Queries["page_width"] = ExpressionConverter.Convert(__workflow_pageWidth);
                if (__workflow_pageHeight != null)
                    callPayload.Queries["page_height"] = ExpressionConverter.Convert(__workflow_pageHeight);
                if (__workflow_fullpage != null)
                    callPayload.Queries["fullpage"] = ExpressionConverter.Convert(__workflow_fullpage);
                if (__workflow_fullpageAdvanced != null)
                    callPayload.Queries["fullpage_advanced"] = ExpressionConverter.Convert(__workflow_fullpageAdvanced);
                if (__workflow_selectors != null)
                    callPayload.Queries["selectors"] = ExpressionConverter.Convert(__workflow_selectors);
                if (__workflow_hoverOnSelected != null)
                    callPayload.Queries["hover_on_selected"] = ExpressionConverter.Convert(__workflow_hoverOnSelected);
                if (__workflow_imageFormat != null)
                    callPayload.Queries["image_format"] = ExpressionConverter.Convert(__workflow_imageFormat);
                if (__workflow_quality != null)
                    callPayload.Queries["quality"] = ExpressionConverter.Convert(__workflow_quality);
                callPayload.Queries["scale_factor"] = Convert.ToString(1);
                if (__workflow_scaleFactor != null)
                    callPayload.Queries["scale_factor"] = ExpressionConverter.Convert(__workflow_scaleFactor);
                if (__workflow_cssInject != null)
                    callPayload.Queries["css_inject"] = ExpressionConverter.Convert(__workflow_cssInject);
                if (__workflow_jsInject != null)
                    callPayload.Queries["js_inject"] = ExpressionConverter.Convert(__workflow_jsInject);
                if (__workflow_userAgent != null)
                    callPayload.Queries["user_agent"] = ExpressionConverter.Convert(__workflow_userAgent);
                if (__workflow_headers != null)
                    callPayload.Queries["headers"] = ExpressionConverter.Convert(__workflow_headers);
                if (__workflow_cookies != null)
                    callPayload.Queries["cookies"] = ExpressionConverter.Convert(__workflow_cookies);
                if (__workflow_ttl != null)
                    callPayload.Queries["ttl"] = ExpressionConverter.Convert(__workflow_ttl);
                if (__workflow_acceptLanguage != null)
                    callPayload.Queries["accept_language"] = ExpressionConverter.Convert(__workflow_acceptLanguage);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_accuracy != null)
                    callPayload.Queries["accuracy"] = ExpressionConverter.Convert(__workflow_accuracy);
                if (__workflow_thumbWidth != null)
                    callPayload.Queries["thumb_width"] = ExpressionConverter.Convert(__workflow_thumbWidth);
                if (__workflow_thumbHeight != null)
                    callPayload.Queries["thumb_height"] = ExpressionConverter.Convert(__workflow_thumbHeight);
                if (__workflow_noAds != null)
                    callPayload.Queries["no_ads"] = ExpressionConverter.Convert(__workflow_noAds);
                if (__workflow_noTracking != null)
                    callPayload.Queries["no_tracking"] = ExpressionConverter.Convert(__workflow_noTracking);
                if (__workflow_noCookieBanners != null)
                    callPayload.Queries["no_cookie_banners"] = ExpressionConverter.Convert(__workflow_noCookieBanners);
                if (__workflow_disableJs != null)
                    callPayload.Queries["disable_js"] = ExpressionConverter.Convert(__workflow_disableJs);
                if (__workflow_disableThirdPartyJs != null)
                    callPayload.Queries["disable_third_party_js"] = ExpressionConverter.Convert(__workflow_disableThirdPartyJs);
                if (__workflow_customTitle != null)
                    callPayload.Queries["custom_title"] = ExpressionConverter.Convert(__workflow_customTitle);
                if (__workflow_customDescription != null)
                    callPayload.Queries["custom_description"] = ExpressionConverter.Convert(__workflow_customDescription);
                return new ApiConnectionAction<RealLocationScreenshotResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pagepixelsscreenshot")]
        public IBodyWorkflowAction<AiAnalysisScreenshotResponse, ApiConnectionActionConfiguration> AiAnalysisScreenshot(Expression<Func<string>> url, Expression<Func<string>> aiPrompt, Expression<Func<string>> timeZone = null, Expression<Func<string[]>> multiStepActions = null, Expression<Func<int>> wait = null, Expression<Func<string>> waitFor = null, Expression<Func<bool>> incrementalScroll = null, Expression<Func<int>> pageWidth = null, Expression<Func<int>> pageHeight = null, Expression<Func<bool>> fullpage = null, Expression<Func<bool>> fullpageAdvanced = null, Expression<Func<string>> selectors = null, Expression<Func<bool>> hoverOnSelected = null, Expression<Func<ImageFormatInput>> imageFormat = null, Expression<Func<int>> quality = null, Expression<Func<ScaleFactorInput>> scaleFactor = null, Expression<Func<string>> cssInject = null, Expression<Func<string>> jsInject = null, Expression<Func<string>> userAgent = null, Expression<Func<string[]>> headers = null, Expression<Func<string[]>> cookies = null, Expression<Func<int>> ttl = null, Expression<Func<string>> acceptLanguage = null, Expression<Func<string>> latitude = null, Expression<Func<string>> longitude = null, Expression<Func<string>> accuracy = null, Expression<Func<int>> thumbWidth = null, Expression<Func<int>> thumbHeight = null, Expression<Func<bool>> noAds = null, Expression<Func<bool>> noTracking = null, Expression<Func<bool>> noCookieBanners = null, Expression<Func<bool>> disableJs = null, Expression<Func<bool>> disableThirdPartyJs = null, Expression<Func<string>> customTitle = null, Expression<Func<string>> customDescription = null)
        {
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: true);
            var __workflow_aiPrompt = WorkflowExpression.Compile(aiPrompt, nameof(aiPrompt), required: true);
            var __workflow_timeZone = WorkflowExpression.Compile(timeZone, nameof(timeZone), required: false);
            var __workflow_multiStepActions = WorkflowExpression.Compile(multiStepActions, nameof(multiStepActions), required: false);
            var __workflow_wait = WorkflowExpression.Compile(wait, nameof(wait), required: false);
            var __workflow_waitFor = WorkflowExpression.Compile(waitFor, nameof(waitFor), required: false);
            var __workflow_incrementalScroll = WorkflowExpression.Compile(incrementalScroll, nameof(incrementalScroll), required: false);
            var __workflow_pageWidth = WorkflowExpression.Compile(pageWidth, nameof(pageWidth), required: false);
            var __workflow_pageHeight = WorkflowExpression.Compile(pageHeight, nameof(pageHeight), required: false);
            var __workflow_fullpage = WorkflowExpression.Compile(fullpage, nameof(fullpage), required: false);
            var __workflow_fullpageAdvanced = WorkflowExpression.Compile(fullpageAdvanced, nameof(fullpageAdvanced), required: false);
            var __workflow_selectors = WorkflowExpression.Compile(selectors, nameof(selectors), required: false);
            var __workflow_hoverOnSelected = WorkflowExpression.Compile(hoverOnSelected, nameof(hoverOnSelected), required: false);
            var __workflow_imageFormat = WorkflowExpression.Compile(imageFormat, nameof(imageFormat), required: false);
            var __workflow_quality = WorkflowExpression.Compile(quality, nameof(quality), required: false);
            var __workflow_scaleFactor = WorkflowExpression.Compile(scaleFactor, nameof(scaleFactor), required: false);
            var __workflow_cssInject = WorkflowExpression.Compile(cssInject, nameof(cssInject), required: false);
            var __workflow_jsInject = WorkflowExpression.Compile(jsInject, nameof(jsInject), required: false);
            var __workflow_userAgent = WorkflowExpression.Compile(userAgent, nameof(userAgent), required: false);
            var __workflow_headers = WorkflowExpression.Compile(headers, nameof(headers), required: false);
            var __workflow_cookies = WorkflowExpression.Compile(cookies, nameof(cookies), required: false);
            var __workflow_ttl = WorkflowExpression.Compile(ttl, nameof(ttl), required: false);
            var __workflow_acceptLanguage = WorkflowExpression.Compile(acceptLanguage, nameof(acceptLanguage), required: false);
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: false);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: false);
            var __workflow_accuracy = WorkflowExpression.Compile(accuracy, nameof(accuracy), required: false);
            var __workflow_thumbWidth = WorkflowExpression.Compile(thumbWidth, nameof(thumbWidth), required: false);
            var __workflow_thumbHeight = WorkflowExpression.Compile(thumbHeight, nameof(thumbHeight), required: false);
            var __workflow_noAds = WorkflowExpression.Compile(noAds, nameof(noAds), required: false);
            var __workflow_noTracking = WorkflowExpression.Compile(noTracking, nameof(noTracking), required: false);
            var __workflow_noCookieBanners = WorkflowExpression.Compile(noCookieBanners, nameof(noCookieBanners), required: false);
            var __workflow_disableJs = WorkflowExpression.Compile(disableJs, nameof(disableJs), required: false);
            var __workflow_disableThirdPartyJs = WorkflowExpression.Compile(disableThirdPartyJs, nameof(disableThirdPartyJs), required: false);
            var __workflow_customTitle = WorkflowExpression.Compile(customTitle, nameof(customTitle), required: false);
            var __workflow_customDescription = WorkflowExpression.Compile(customDescription, nameof(customDescription), required: false);
            return new DeferredBodyAction<AiAnalysisScreenshotResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/snap_ai_analysis";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["microsoft"] = Convert.ToString(true);
                callPayload.Queries["json"] = Convert.ToString(true);
                callPayload.Queries["analyze_image_with_ai"] = Convert.ToString(true);
                callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                callPayload.Queries["ai_prompt"] = ExpressionConverter.Convert(__workflow_aiPrompt);
                if (__workflow_timeZone != null)
                    callPayload.Queries["time_zone"] = ExpressionConverter.Convert(__workflow_timeZone);
                if (__workflow_multiStepActions != null)
                    callPayload.Queries["multi_step_actions"] = ExpressionConverter.Convert(__workflow_multiStepActions);
                if (__workflow_wait != null)
                    callPayload.Queries["wait"] = ExpressionConverter.Convert(__workflow_wait);
                if (__workflow_waitFor != null)
                    callPayload.Queries["wait_for"] = ExpressionConverter.Convert(__workflow_waitFor);
                if (__workflow_incrementalScroll != null)
                    callPayload.Queries["incremental_scroll"] = ExpressionConverter.Convert(__workflow_incrementalScroll);
                if (__workflow_pageWidth != null)
                    callPayload.Queries["page_width"] = ExpressionConverter.Convert(__workflow_pageWidth);
                if (__workflow_pageHeight != null)
                    callPayload.Queries["page_height"] = ExpressionConverter.Convert(__workflow_pageHeight);
                if (__workflow_fullpage != null)
                    callPayload.Queries["fullpage"] = ExpressionConverter.Convert(__workflow_fullpage);
                if (__workflow_fullpageAdvanced != null)
                    callPayload.Queries["fullpage_advanced"] = ExpressionConverter.Convert(__workflow_fullpageAdvanced);
                if (__workflow_selectors != null)
                    callPayload.Queries["selectors"] = ExpressionConverter.Convert(__workflow_selectors);
                if (__workflow_hoverOnSelected != null)
                    callPayload.Queries["hover_on_selected"] = ExpressionConverter.Convert(__workflow_hoverOnSelected);
                if (__workflow_imageFormat != null)
                    callPayload.Queries["image_format"] = ExpressionConverter.Convert(__workflow_imageFormat);
                if (__workflow_quality != null)
                    callPayload.Queries["quality"] = ExpressionConverter.Convert(__workflow_quality);
                callPayload.Queries["scale_factor"] = Convert.ToString(1);
                if (__workflow_scaleFactor != null)
                    callPayload.Queries["scale_factor"] = ExpressionConverter.Convert(__workflow_scaleFactor);
                if (__workflow_cssInject != null)
                    callPayload.Queries["css_inject"] = ExpressionConverter.Convert(__workflow_cssInject);
                if (__workflow_jsInject != null)
                    callPayload.Queries["js_inject"] = ExpressionConverter.Convert(__workflow_jsInject);
                if (__workflow_userAgent != null)
                    callPayload.Queries["user_agent"] = ExpressionConverter.Convert(__workflow_userAgent);
                if (__workflow_headers != null)
                    callPayload.Queries["headers"] = ExpressionConverter.Convert(__workflow_headers);
                if (__workflow_cookies != null)
                    callPayload.Queries["cookies"] = ExpressionConverter.Convert(__workflow_cookies);
                if (__workflow_ttl != null)
                    callPayload.Queries["ttl"] = ExpressionConverter.Convert(__workflow_ttl);
                if (__workflow_acceptLanguage != null)
                    callPayload.Queries["accept_language"] = ExpressionConverter.Convert(__workflow_acceptLanguage);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                if (__workflow_accuracy != null)
                    callPayload.Queries["accuracy"] = ExpressionConverter.Convert(__workflow_accuracy);
                if (__workflow_thumbWidth != null)
                    callPayload.Queries["thumb_width"] = ExpressionConverter.Convert(__workflow_thumbWidth);
                if (__workflow_thumbHeight != null)
                    callPayload.Queries["thumb_height"] = ExpressionConverter.Convert(__workflow_thumbHeight);
                if (__workflow_noAds != null)
                    callPayload.Queries["no_ads"] = ExpressionConverter.Convert(__workflow_noAds);
                if (__workflow_noTracking != null)
                    callPayload.Queries["no_tracking"] = ExpressionConverter.Convert(__workflow_noTracking);
                if (__workflow_noCookieBanners != null)
                    callPayload.Queries["no_cookie_banners"] = ExpressionConverter.Convert(__workflow_noCookieBanners);
                if (__workflow_disableJs != null)
                    callPayload.Queries["disable_js"] = ExpressionConverter.Convert(__workflow_disableJs);
                if (__workflow_disableThirdPartyJs != null)
                    callPayload.Queries["disable_third_party_js"] = ExpressionConverter.Convert(__workflow_disableThirdPartyJs);
                if (__workflow_customTitle != null)
                    callPayload.Queries["custom_title"] = ExpressionConverter.Convert(__workflow_customTitle);
                if (__workflow_customDescription != null)
                    callPayload.Queries["custom_description"] = ExpressionConverter.Convert(__workflow_customDescription);
                return new ApiConnectionAction<AiAnalysisScreenshotResponse>(callPayload);
            });
        }
    }

    public class PagepixelsscreenshotTriggers([ConnectionName] string connectionId)
    {
    }

    public class QuickSnapResponse
    {
        [JsonProperty("id")]
        public string ScreenshotId { get; set; }

        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonProperty("is_browser_extension_screenshot")]
        public bool BrowserExtensionCapture { get; set; }

        [JsonProperty("screenshot_configuration_id")]
        public string ConfigurationId { get; set; }

        [JsonProperty("direct_link")]
        public string DirectLink { get; set; }

        [JsonProperty("direct_thumbnail_link")]
        public string ThumbnailLink { get; set; }

        [JsonProperty("taken_at_timestamp")]
        public string TakenAtTimestamp { get; set; }

        [JsonProperty("taken_at")]
        public string TakenAt { get; set; }

        [JsonProperty("ai")]
        public QuickSnapResponseAIAnalysisType AIAnalysis { get; set; }

        [JsonProperty("job_id")]
        public string JobId { get; set; }
    }

    public class QuickSnapResponseAIAnalysisType
    {
        [JsonProperty("ai_analyzed")]
        public bool AIAnalyzed { get; set; }

        [JsonProperty("ai_prompt")]
        public string AIPrompt { get; set; }

        [JsonProperty("ai_response")]
        public string AIResponse { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImageFormatInput
    {
        [EnumMember(Value = "jpeg")]
        Jpeg,
        [EnumMember(Value = "png")]
        Png,
        [EnumMember(Value = "webp")]
        Webp
    }

    public enum ScaleFactorInput
    {
        _1 = 1,
        _2 = 2
    }

    public class SnapHtmlResponse
    {
        [JsonProperty("id")]
        public string ScreenshotId { get; set; }

        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonProperty("is_browser_extension_screenshot")]
        public bool BrowserExtensionCapture { get; set; }

        [JsonProperty("screenshot_configuration_id")]
        public string ConfigurationId { get; set; }

        [JsonProperty("direct_link")]
        public string DirectLink { get; set; }

        [JsonProperty("direct_thumbnail_link")]
        public string ThumbnailLink { get; set; }

        [JsonProperty("taken_at_timestamp")]
        public string TakenAtTimestamp { get; set; }

        [JsonProperty("taken_at")]
        public string TakenAt { get; set; }

        [JsonProperty("ai")]
        public SnapHtmlResponseAIAnalysisType AIAnalysis { get; set; }

        [JsonProperty("job_id")]
        public string JobId { get; set; }
    }

    public class SnapHtmlResponseAIAnalysisType
    {
        [JsonProperty("ai_analyzed")]
        public bool AIAnalyzed { get; set; }

        [JsonProperty("ai_prompt")]
        public string AIPrompt { get; set; }

        [JsonProperty("ai_response")]
        public string AIResponse { get; set; }
    }

    public class RealLocationScreenshotResponse
    {
        [JsonProperty("id")]
        public string ScreenshotId { get; set; }

        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonProperty("is_browser_extension_screenshot")]
        public bool BrowserExtensionCapture { get; set; }

        [JsonProperty("screenshot_configuration_id")]
        public string ConfigurationId { get; set; }

        [JsonProperty("direct_link")]
        public string DirectLink { get; set; }

        [JsonProperty("direct_thumbnail_link")]
        public string ThumbnailLink { get; set; }

        [JsonProperty("taken_at_timestamp")]
        public string TakenAtTimestamp { get; set; }

        [JsonProperty("taken_at")]
        public string TakenAt { get; set; }

        [JsonProperty("ai")]
        public RealLocationScreenshotResponseAIAnalysisType AIAnalysis { get; set; }

        [JsonProperty("job_id")]
        public string JobId { get; set; }
    }

    public class RealLocationScreenshotResponseAIAnalysisType
    {
        [JsonProperty("ai_analyzed")]
        public bool AIAnalyzed { get; set; }

        [JsonProperty("ai_prompt")]
        public string AIPrompt { get; set; }

        [JsonProperty("ai_response")]
        public string AIResponse { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProxyServerInput
    {
        Afghanistan,
        Alabama,
        Alaska,
        Albania,
        All,
        Andorra,
        Angola,
        Argentina,
        Arizona,
        Arkansas,
        Armenia,
        Aruba,
        Australia,
        Austria,
        Azerbaijan,
        Bahamas,
        Bahrain,
        Bangladesh,
        Belarus,
        Belgium,
        Belize,
        Benin,
        Berlin,
        Bhutan,
        Bolivia,
        [EnumMember(Value = "Bosnia and Herzegovina")]
        BosniaAndHerzegovina,
        Brazil,
        [EnumMember(Value = "British Virgin Islands")]
        BritishVirginIslands,
        Bulgaria,
        California,
        Cambodia,
        Cameroon,
        Canada,
        Chad,
        Chicago,
        Chile,
        China,
        Colombia,
        Colorado,
        Connecticut,
        [EnumMember(Value = "Costa Rica")]
        CostaRica,
        [EnumMember(Value = "Côte d'Ivoire")]
        CôteDIvoire,
        Croatia,
        Cuba,
        Cyprus,
        [EnumMember(Value = "Czech Republic")]
        CzechRepublic,
        Delaware,
        Denmark,
        Djibouti,
        Dominica,
        Ecuador,
        Egypt,
        Estonia,
        Ethiopia,
        Europe,
        Fiji,
        Finland,
        Florida,
        France,
        Gambia,
        Georgia,
        [EnumMember(Value = "Georgia (US)")]
        GeorgiaUS,
        Germany,
        Ghana,
        [EnumMember(Value = "Great Britain")]
        GreatBritain,
        Greece,
        Haiti,
        Hawaii,
        Honduras,
        [EnumMember(Value = "Hong Kong")]
        HongKong,
        Houston,
        Hungary,
        Iceland,
        Idaho,
        Illinois,
        India,
        Indiana,
        Indonesia,
        Iowa,
        Iran,
        Iraq,
        Ireland,
        Israel,
        Italy,
        Jamaica,
        Japan,
        Jordan,
        Kansas,
        Kazakhstan,
        Kentucky,
        Kenya,
        Latvia,
        Lebanon,
        Liberia,
        Liechtenstein,
        Lithuania,
        London,
        [EnumMember(Value = "Los Angeles")]
        LosAngeles,
        Louisiana,
        Luxembourg,
        Macedonia,
        Madagascar,
        Maine,
        Malaysia,
        Maldives,
        Mali,
        Malta,
        Maryland,
        Massachusetts,
        Mauritania,
        Mauritius,
        Mexico,
        Miami,
        Michigan,
        Minnesota,
        Mississippi,
        Missouri,
        Moldova,
        Monaco,
        Mongolia,
        Montana,
        Montenegro,
        Morocco,
        Moscow,
        Mozambique,
        Myanmar,
        Nebraska,
        Netherlands,
        Nevada,
        [EnumMember(Value = "New Hampshire")]
        NewHampshire,
        [EnumMember(Value = "New Jersey")]
        NewJersey,
        [EnumMember(Value = "New Mexico")]
        NewMexico,
        [EnumMember(Value = "New York")]
        NewYork,
        [EnumMember(Value = "New Zealand")]
        NewZealand,
        Nigeria,
        [EnumMember(Value = "North Carolina")]
        NorthCarolina,
        [EnumMember(Value = "North Dakota")]
        NorthDakota,
        Norway,
        Ohio,
        Oklahoma,
        Oman,
        Oregon,
        Pakistan,
        Panama,
        Paraguay,
        Pennsylvania,
        Peru,
        Philippines,
        Poland,
        Portugal,
        [EnumMember(Value = "Puerto Rico")]
        PuertoRico,
        Qatar,
        Random,
        [EnumMember(Value = "Rhode Island")]
        RhodeIsland,
        Romania,
        Russia,
        [EnumMember(Value = "Saudi Arabia")]
        SaudiArabia,
        Senegal,
        Serbia,
        Seychelles,
        Singapore,
        Slovakia,
        Slovenia,
        [EnumMember(Value = "South Africa")]
        SouthAfrica,
        [EnumMember(Value = "South Carolina")]
        SouthCarolina,
        [EnumMember(Value = "South Dakota")]
        SouthDakota,
        [EnumMember(Value = "South Korea")]
        SouthKorea,
        [EnumMember(Value = "South Sudan")]
        SouthSudan,
        Spain,
        Sudan,
        Sweden,
        Switzerland,
        Syria,
        Taiwan,
        Tennessee,
        Texas,
        Thailand,
        Togo,
        [EnumMember(Value = "Trinidad and Tobago")]
        TrinidadAndTobago,
        Tunisia,
        Turkey,
        Turkmenistan,
        [EnumMember(Value = "UAE")]
        Uae,
        Uganda,
        Ukraine,
        [EnumMember(Value = "United Kingdom")]
        UnitedKingdom,
        Uruguay,
        US,
        [EnumMember(Value = "USA")]
        Usa,
        Utah,
        Uzbekistan,
        Vermont,
        Vietnam,
        Virginia,
        Washington,
        [EnumMember(Value = "West Virginia")]
        WestVirginia,
        Wisconsin,
        Wyoming,
        Yemen,
        Zambia,
        Zimbabwe
    }

    public class AiAnalysisScreenshotResponse
    {
        [JsonProperty("id")]
        public string ScreenshotId { get; set; }

        [JsonProperty("embed_url")]
        public string EmbedUrl { get; set; }

        [JsonProperty("is_browser_extension_screenshot")]
        public bool BrowserExtensionCapture { get; set; }

        [JsonProperty("screenshot_configuration_id")]
        public string ConfigurationId { get; set; }

        [JsonProperty("direct_link")]
        public string DirectLink { get; set; }

        [JsonProperty("direct_thumbnail_link")]
        public string ThumbnailLink { get; set; }

        [JsonProperty("taken_at_timestamp")]
        public string TakenAtTimestamp { get; set; }

        [JsonProperty("taken_at")]
        public string TakenAt { get; set; }

        [JsonProperty("ai")]
        public AiAnalysisScreenshotResponseAIAnalysisType AIAnalysis { get; set; }

        [JsonProperty("job_id")]
        public string JobId { get; set; }
    }

    public class AiAnalysisScreenshotResponseAIAnalysisType
    {
        [JsonProperty("ai_analyzed")]
        public bool AIAnalyzed { get; set; }

        [JsonProperty("ai_prompt")]
        public string AIPrompt { get; set; }

        [JsonProperty("ai_response")]
        public string AIResponse { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pagepixelsscreenshot;

    public partial class WorkflowManagedActions
    {
        public PagepixelsscreenshotActions Pagepixelsscreenshot(string connectionId) => new PagepixelsscreenshotActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PagepixelsscreenshotTriggers Pagepixelsscreenshot(string connectionId) => new PagepixelsscreenshotTriggers(connectionId);
    }
}