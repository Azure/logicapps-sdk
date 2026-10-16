//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Screenshotoneip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ScreenshotoneipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "screenshotoneip")]
        public IBodyWorkflowAction<TakeGetResponse> TakeGet(Expression<Func<string>> url = null, Expression<Func<string>> html = null, Expression<Func<formatInput>> format = null, Expression<Func<responseTypeInput>> responseType = null, Expression<Func<string>> selector = null, Expression<Func<bool>> captureBeyondViewport = null, Expression<Func<string>> scrollIntoView = null, Expression<Func<int>> scrollIntoViewAdjustTop = null, Expression<Func<bool>> fullPage = null, Expression<Func<bool>> fullPageScroll = null, Expression<Func<int>> fullPageScrollDelay = null, Expression<Func<int>> fullPageScrollBy = null, Expression<Func<int>> fullPageMaxHeight = null, Expression<Func<string>> viewportDevice = null, Expression<Func<int>> viewportWidth = null, Expression<Func<int>> viewportHeight = null, Expression<Func<int>> deviceScaleFactor = null, Expression<Func<bool>> viewportMobile = null, Expression<Func<bool>> viewportHasTouch = null, Expression<Func<bool>> viewportLandscape = null, Expression<Func<int>> imageQuality = null, Expression<Func<int>> imageWidth = null, Expression<Func<int>> imageHeight = null, Expression<Func<bool>> omitBackground = null, Expression<Func<bool>> darkMode = null, Expression<Func<bool>> reducedMotion = null, Expression<Func<string>> mediaType = null, Expression<Func<string>> hideSelectors = null, Expression<Func<string>> scripts = null, Expression<Func<string>> scriptsWaitUntil = null, Expression<Func<string>> styles = null, Expression<Func<string>> click = null, Expression<Func<bool>> blockCookieBanners = null, Expression<Func<bool>> blockBannersByHeuristics = null, Expression<Func<bool>> blockChats = null, Expression<Func<bool>> blockAds = null, Expression<Func<bool>> blockTrackers = null, Expression<Func<string>> blockRequests = null, Expression<Func<string>> blockResources = null, Expression<Func<double>> geolocationLatitude = null, Expression<Func<double>> geolocationLongitude = null, Expression<Func<int>> geolocationAccuracy = null, Expression<Func<ipCountryCodeInput>> ipCountryCode = null, Expression<Func<string>> proxy = null, Expression<Func<string>> userAgent = null, Expression<Func<string>> authorization = null, Expression<Func<string>> cookies = null, Expression<Func<string>> headers = null, Expression<Func<timeZoneInput>> timeZone = null, Expression<Func<string>> waitUntil = null, Expression<Func<int>> delay = null, Expression<Func<int>> timeout = null, Expression<Func<int>> navigationTimeout = null, Expression<Func<string>> waitForSelector = null, Expression<Func<bool>> cache = null, Expression<Func<int>> cacheTtl = null, Expression<Func<int>> cacheKey = null, Expression<Func<bool>> store = null, Expression<Func<string>> storagePath = null, Expression<Func<string>> storageBucket = null, Expression<Func<storageClassInput>> storageClass = null, Expression<Func<string>> storageAcl = null, Expression<Func<bool>> metadataImageSize = null, Expression<Func<bool>> ignoreHostErrors = null, Expression<Func<bool>> errorOnSelectorNotFound = null)
        {
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: false);
            var __workflow_html = WorkflowExpression.Compile(html, nameof(html), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_responseType = WorkflowExpression.Compile(responseType, nameof(responseType), required: false);
            var __workflow_selector = WorkflowExpression.Compile(selector, nameof(selector), required: false);
            var __workflow_captureBeyondViewport = WorkflowExpression.Compile(captureBeyondViewport, nameof(captureBeyondViewport), required: false);
            var __workflow_scrollIntoView = WorkflowExpression.Compile(scrollIntoView, nameof(scrollIntoView), required: false);
            var __workflow_scrollIntoViewAdjustTop = WorkflowExpression.Compile(scrollIntoViewAdjustTop, nameof(scrollIntoViewAdjustTop), required: false);
            var __workflow_fullPage = WorkflowExpression.Compile(fullPage, nameof(fullPage), required: false);
            var __workflow_fullPageScroll = WorkflowExpression.Compile(fullPageScroll, nameof(fullPageScroll), required: false);
            var __workflow_fullPageScrollDelay = WorkflowExpression.Compile(fullPageScrollDelay, nameof(fullPageScrollDelay), required: false);
            var __workflow_fullPageScrollBy = WorkflowExpression.Compile(fullPageScrollBy, nameof(fullPageScrollBy), required: false);
            var __workflow_fullPageMaxHeight = WorkflowExpression.Compile(fullPageMaxHeight, nameof(fullPageMaxHeight), required: false);
            var __workflow_viewportDevice = WorkflowExpression.Compile(viewportDevice, nameof(viewportDevice), required: false);
            var __workflow_viewportWidth = WorkflowExpression.Compile(viewportWidth, nameof(viewportWidth), required: false);
            var __workflow_viewportHeight = WorkflowExpression.Compile(viewportHeight, nameof(viewportHeight), required: false);
            var __workflow_deviceScaleFactor = WorkflowExpression.Compile(deviceScaleFactor, nameof(deviceScaleFactor), required: false);
            var __workflow_viewportMobile = WorkflowExpression.Compile(viewportMobile, nameof(viewportMobile), required: false);
            var __workflow_viewportHasTouch = WorkflowExpression.Compile(viewportHasTouch, nameof(viewportHasTouch), required: false);
            var __workflow_viewportLandscape = WorkflowExpression.Compile(viewportLandscape, nameof(viewportLandscape), required: false);
            var __workflow_imageQuality = WorkflowExpression.Compile(imageQuality, nameof(imageQuality), required: false);
            var __workflow_imageWidth = WorkflowExpression.Compile(imageWidth, nameof(imageWidth), required: false);
            var __workflow_imageHeight = WorkflowExpression.Compile(imageHeight, nameof(imageHeight), required: false);
            var __workflow_omitBackground = WorkflowExpression.Compile(omitBackground, nameof(omitBackground), required: false);
            var __workflow_darkMode = WorkflowExpression.Compile(darkMode, nameof(darkMode), required: false);
            var __workflow_reducedMotion = WorkflowExpression.Compile(reducedMotion, nameof(reducedMotion), required: false);
            var __workflow_mediaType = WorkflowExpression.Compile(mediaType, nameof(mediaType), required: false);
            var __workflow_hideSelectors = WorkflowExpression.Compile(hideSelectors, nameof(hideSelectors), required: false);
            var __workflow_scripts = WorkflowExpression.Compile(scripts, nameof(scripts), required: false);
            var __workflow_scriptsWaitUntil = WorkflowExpression.Compile(scriptsWaitUntil, nameof(scriptsWaitUntil), required: false);
            var __workflow_styles = WorkflowExpression.Compile(styles, nameof(styles), required: false);
            var __workflow_click = WorkflowExpression.Compile(click, nameof(click), required: false);
            var __workflow_blockCookieBanners = WorkflowExpression.Compile(blockCookieBanners, nameof(blockCookieBanners), required: false);
            var __workflow_blockBannersByHeuristics = WorkflowExpression.Compile(blockBannersByHeuristics, nameof(blockBannersByHeuristics), required: false);
            var __workflow_blockChats = WorkflowExpression.Compile(blockChats, nameof(blockChats), required: false);
            var __workflow_blockAds = WorkflowExpression.Compile(blockAds, nameof(blockAds), required: false);
            var __workflow_blockTrackers = WorkflowExpression.Compile(blockTrackers, nameof(blockTrackers), required: false);
            var __workflow_blockRequests = WorkflowExpression.Compile(blockRequests, nameof(blockRequests), required: false);
            var __workflow_blockResources = WorkflowExpression.Compile(blockResources, nameof(blockResources), required: false);
            var __workflow_geolocationLatitude = WorkflowExpression.Compile(geolocationLatitude, nameof(geolocationLatitude), required: false);
            var __workflow_geolocationLongitude = WorkflowExpression.Compile(geolocationLongitude, nameof(geolocationLongitude), required: false);
            var __workflow_geolocationAccuracy = WorkflowExpression.Compile(geolocationAccuracy, nameof(geolocationAccuracy), required: false);
            var __workflow_ipCountryCode = WorkflowExpression.Compile(ipCountryCode, nameof(ipCountryCode), required: false);
            var __workflow_proxy = WorkflowExpression.Compile(proxy, nameof(proxy), required: false);
            var __workflow_userAgent = WorkflowExpression.Compile(userAgent, nameof(userAgent), required: false);
            var __workflow_authorization = WorkflowExpression.Compile(authorization, nameof(authorization), required: false);
            var __workflow_cookies = WorkflowExpression.Compile(cookies, nameof(cookies), required: false);
            var __workflow_headers = WorkflowExpression.Compile(headers, nameof(headers), required: false);
            var __workflow_timeZone = WorkflowExpression.Compile(timeZone, nameof(timeZone), required: false);
            var __workflow_waitUntil = WorkflowExpression.Compile(waitUntil, nameof(waitUntil), required: false);
            var __workflow_delay = WorkflowExpression.Compile(delay, nameof(delay), required: false);
            var __workflow_timeout = WorkflowExpression.Compile(timeout, nameof(timeout), required: false);
            var __workflow_navigationTimeout = WorkflowExpression.Compile(navigationTimeout, nameof(navigationTimeout), required: false);
            var __workflow_waitForSelector = WorkflowExpression.Compile(waitForSelector, nameof(waitForSelector), required: false);
            var __workflow_cache = WorkflowExpression.Compile(cache, nameof(cache), required: false);
            var __workflow_cacheTtl = WorkflowExpression.Compile(cacheTtl, nameof(cacheTtl), required: false);
            var __workflow_cacheKey = WorkflowExpression.Compile(cacheKey, nameof(cacheKey), required: false);
            var __workflow_store = WorkflowExpression.Compile(store, nameof(store), required: false);
            var __workflow_storagePath = WorkflowExpression.Compile(storagePath, nameof(storagePath), required: false);
            var __workflow_storageBucket = WorkflowExpression.Compile(storageBucket, nameof(storageBucket), required: false);
            var __workflow_storageClass = WorkflowExpression.Compile(storageClass, nameof(storageClass), required: false);
            var __workflow_storageAcl = WorkflowExpression.Compile(storageAcl, nameof(storageAcl), required: false);
            var __workflow_metadataImageSize = WorkflowExpression.Compile(metadataImageSize, nameof(metadataImageSize), required: false);
            var __workflow_ignoreHostErrors = WorkflowExpression.Compile(ignoreHostErrors, nameof(ignoreHostErrors), required: false);
            var __workflow_errorOnSelectorNotFound = WorkflowExpression.Compile(errorOnSelectorNotFound, nameof(errorOnSelectorNotFound), required: false);
            return new DeferredBodyAction<TakeGetResponse>(() =>
            {
                var apiCallPath = "/take";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                if (__workflow_html != null)
                    callPayload.Queries["html"] = ExpressionConverter.Convert(__workflow_html);
                callPayload.Queries["format"] = Convert.ToString("jpg");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Queries["response_type"] = Convert.ToString("by_format");
                if (__workflow_responseType != null)
                    callPayload.Queries["response_type"] = ExpressionConverter.Convert(__workflow_responseType);
                if (__workflow_selector != null)
                    callPayload.Queries["selector"] = ExpressionConverter.Convert(__workflow_selector);
                if (__workflow_captureBeyondViewport != null)
                    callPayload.Queries["capture_beyond_viewport"] = ExpressionConverter.Convert(__workflow_captureBeyondViewport);
                if (__workflow_scrollIntoView != null)
                    callPayload.Queries["scroll_into_view"] = ExpressionConverter.Convert(__workflow_scrollIntoView);
                if (__workflow_scrollIntoViewAdjustTop != null)
                    callPayload.Queries["scroll_into_view_adjust_top"] = ExpressionConverter.Convert(__workflow_scrollIntoViewAdjustTop);
                if (__workflow_fullPage != null)
                    callPayload.Queries["full_page"] = ExpressionConverter.Convert(__workflow_fullPage);
                if (__workflow_fullPageScroll != null)
                    callPayload.Queries["full_page_scroll"] = ExpressionConverter.Convert(__workflow_fullPageScroll);
                if (__workflow_fullPageScrollDelay != null)
                    callPayload.Queries["full_page_scroll_delay"] = ExpressionConverter.Convert(__workflow_fullPageScrollDelay);
                if (__workflow_fullPageScrollBy != null)
                    callPayload.Queries["full_page_scroll_by"] = ExpressionConverter.Convert(__workflow_fullPageScrollBy);
                if (__workflow_fullPageMaxHeight != null)
                    callPayload.Queries["full_page_max_height"] = ExpressionConverter.Convert(__workflow_fullPageMaxHeight);
                if (__workflow_viewportDevice != null)
                    callPayload.Queries["viewport_device"] = ExpressionConverter.Convert(__workflow_viewportDevice);
                if (__workflow_viewportWidth != null)
                    callPayload.Queries["viewport_width"] = ExpressionConverter.Convert(__workflow_viewportWidth);
                if (__workflow_viewportHeight != null)
                    callPayload.Queries["viewport_height"] = ExpressionConverter.Convert(__workflow_viewportHeight);
                if (__workflow_deviceScaleFactor != null)
                    callPayload.Queries["device_scale_factor"] = ExpressionConverter.Convert(__workflow_deviceScaleFactor);
                if (__workflow_viewportMobile != null)
                    callPayload.Queries["viewport_mobile"] = ExpressionConverter.Convert(__workflow_viewportMobile);
                if (__workflow_viewportHasTouch != null)
                    callPayload.Queries["viewport_has_touch"] = ExpressionConverter.Convert(__workflow_viewportHasTouch);
                if (__workflow_viewportLandscape != null)
                    callPayload.Queries["viewport_landscape"] = ExpressionConverter.Convert(__workflow_viewportLandscape);
                if (__workflow_imageQuality != null)
                    callPayload.Queries["image_quality"] = ExpressionConverter.Convert(__workflow_imageQuality);
                if (__workflow_imageWidth != null)
                    callPayload.Queries["image_width"] = ExpressionConverter.Convert(__workflow_imageWidth);
                if (__workflow_imageHeight != null)
                    callPayload.Queries["image_height"] = ExpressionConverter.Convert(__workflow_imageHeight);
                if (__workflow_omitBackground != null)
                    callPayload.Queries["omit_background"] = ExpressionConverter.Convert(__workflow_omitBackground);
                if (__workflow_darkMode != null)
                    callPayload.Queries["dark_mode"] = ExpressionConverter.Convert(__workflow_darkMode);
                if (__workflow_reducedMotion != null)
                    callPayload.Queries["reduced_motion"] = ExpressionConverter.Convert(__workflow_reducedMotion);
                if (__workflow_mediaType != null)
                    callPayload.Queries["media_type"] = ExpressionConverter.Convert(__workflow_mediaType);
                if (__workflow_hideSelectors != null)
                    callPayload.Queries["hide_selectors"] = ExpressionConverter.Convert(__workflow_hideSelectors);
                if (__workflow_scripts != null)
                    callPayload.Queries["scripts"] = ExpressionConverter.Convert(__workflow_scripts);
                if (__workflow_scriptsWaitUntil != null)
                    callPayload.Queries["scripts_wait_until"] = ExpressionConverter.Convert(__workflow_scriptsWaitUntil);
                if (__workflow_styles != null)
                    callPayload.Queries["styles"] = ExpressionConverter.Convert(__workflow_styles);
                if (__workflow_click != null)
                    callPayload.Queries["click"] = ExpressionConverter.Convert(__workflow_click);
                if (__workflow_blockCookieBanners != null)
                    callPayload.Queries["block_cookie_banners"] = ExpressionConverter.Convert(__workflow_blockCookieBanners);
                if (__workflow_blockBannersByHeuristics != null)
                    callPayload.Queries["block_banners_by_heuristics"] = ExpressionConverter.Convert(__workflow_blockBannersByHeuristics);
                if (__workflow_blockChats != null)
                    callPayload.Queries["block_chats"] = ExpressionConverter.Convert(__workflow_blockChats);
                if (__workflow_blockAds != null)
                    callPayload.Queries["block_ads"] = ExpressionConverter.Convert(__workflow_blockAds);
                if (__workflow_blockTrackers != null)
                    callPayload.Queries["block_trackers"] = ExpressionConverter.Convert(__workflow_blockTrackers);
                if (__workflow_blockRequests != null)
                    callPayload.Queries["block_requests"] = ExpressionConverter.Convert(__workflow_blockRequests);
                if (__workflow_blockResources != null)
                    callPayload.Queries["block_resources"] = ExpressionConverter.Convert(__workflow_blockResources);
                if (__workflow_geolocationLatitude != null)
                    callPayload.Queries["geolocation_latitude"] = ExpressionConverter.Convert(__workflow_geolocationLatitude);
                if (__workflow_geolocationLongitude != null)
                    callPayload.Queries["geolocation_longitude"] = ExpressionConverter.Convert(__workflow_geolocationLongitude);
                if (__workflow_geolocationAccuracy != null)
                    callPayload.Queries["geolocation_accuracy"] = ExpressionConverter.Convert(__workflow_geolocationAccuracy);
                callPayload.Queries["ip_country_code"] = Convert.ToString("us");
                if (__workflow_ipCountryCode != null)
                    callPayload.Queries["ip_country_code"] = ExpressionConverter.Convert(__workflow_ipCountryCode);
                if (__workflow_proxy != null)
                    callPayload.Queries["proxy"] = ExpressionConverter.Convert(__workflow_proxy);
                if (__workflow_userAgent != null)
                    callPayload.Queries["user_agent"] = ExpressionConverter.Convert(__workflow_userAgent);
                if (__workflow_authorization != null)
                    callPayload.Queries["authorization"] = ExpressionConverter.Convert(__workflow_authorization);
                if (__workflow_cookies != null)
                    callPayload.Queries["cookies"] = ExpressionConverter.Convert(__workflow_cookies);
                if (__workflow_headers != null)
                    callPayload.Queries["headers"] = ExpressionConverter.Convert(__workflow_headers);
                if (__workflow_timeZone != null)
                    callPayload.Queries["time_zone"] = ExpressionConverter.Convert(__workflow_timeZone);
                if (__workflow_waitUntil != null)
                    callPayload.Queries["wait_until"] = ExpressionConverter.Convert(__workflow_waitUntil);
                if (__workflow_delay != null)
                    callPayload.Queries["delay"] = ExpressionConverter.Convert(__workflow_delay);
                if (__workflow_timeout != null)
                    callPayload.Queries["timeout"] = ExpressionConverter.Convert(__workflow_timeout);
                if (__workflow_navigationTimeout != null)
                    callPayload.Queries["navigation_timeout"] = ExpressionConverter.Convert(__workflow_navigationTimeout);
                if (__workflow_waitForSelector != null)
                    callPayload.Queries["wait_for_selector"] = ExpressionConverter.Convert(__workflow_waitForSelector);
                if (__workflow_cache != null)
                    callPayload.Queries["cache"] = ExpressionConverter.Convert(__workflow_cache);
                if (__workflow_cacheTtl != null)
                    callPayload.Queries["cache_ttl"] = ExpressionConverter.Convert(__workflow_cacheTtl);
                if (__workflow_cacheKey != null)
                    callPayload.Queries["cache_key"] = ExpressionConverter.Convert(__workflow_cacheKey);
                if (__workflow_store != null)
                    callPayload.Queries["store"] = ExpressionConverter.Convert(__workflow_store);
                if (__workflow_storagePath != null)
                    callPayload.Queries["storage_path"] = ExpressionConverter.Convert(__workflow_storagePath);
                if (__workflow_storageBucket != null)
                    callPayload.Queries["storage_bucket"] = ExpressionConverter.Convert(__workflow_storageBucket);
                if (__workflow_storageClass != null)
                    callPayload.Queries["storage_class"] = ExpressionConverter.Convert(__workflow_storageClass);
                if (__workflow_storageAcl != null)
                    callPayload.Queries["storage_acl"] = ExpressionConverter.Convert(__workflow_storageAcl);
                if (__workflow_metadataImageSize != null)
                    callPayload.Queries["metadata_image_size"] = ExpressionConverter.Convert(__workflow_metadataImageSize);
                if (__workflow_ignoreHostErrors != null)
                    callPayload.Queries["ignore_host_errors"] = ExpressionConverter.Convert(__workflow_ignoreHostErrors);
                if (__workflow_errorOnSelectorNotFound != null)
                    callPayload.Queries["error_on_selector_not_found"] = ExpressionConverter.Convert(__workflow_errorOnSelectorNotFound);
                return new ApiConnectionAction<TakeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "screenshotoneip")]
        public IBodyWorkflowAction<TakeAnimatedGetResponse> TakeAnimatedGet(Expression<Func<string>> url = null, Expression<Func<string>> scenario = null, Expression<Func<int>> scrollDelay = null, Expression<Func<int>> scrollDuration = null, Expression<Func<int>> scrollBy = null, Expression<Func<bool>> scrollStartImmediately = null, Expression<Func<bool>> scrollBack = null, Expression<Func<int>> scrollBackAfterDuration = null, Expression<Func<bool>> scrollComplete = null, Expression<Func<int>> scrollStopAfterDuration = null, Expression<Func<scrollEasingInput>> scrollEasing = null, Expression<Func<formatInput>> format = null, Expression<Func<int>> duration = null, Expression<Func<int>> width = null, Expression<Func<int>> height = null, Expression<Func<string>> aspectRatio = null, Expression<Func<string>> viewportDevice = null, Expression<Func<int>> viewportWidth = null, Expression<Func<int>> viewportHeight = null, Expression<Func<int>> deviceScaleFactor = null, Expression<Func<bool>> viewportMobile = null, Expression<Func<bool>> viewportHasTouch = null, Expression<Func<bool>> viewportLandscape = null, Expression<Func<bool>> blockCookieBanners = null, Expression<Func<bool>> blockBannersByHeuristics = null, Expression<Func<bool>> blockChats = null, Expression<Func<bool>> blockAds = null, Expression<Func<bool>> blockTrackers = null, Expression<Func<string>> blockRequests = null, Expression<Func<string>> blockResources = null, Expression<Func<double>> geolocationLatitude = null, Expression<Func<double>> geolocationLongitude = null, Expression<Func<int>> geolocationAccuracy = null, Expression<Func<ipCountryCodeInput>> ipCountryCode = null, Expression<Func<string>> proxy = null, Expression<Func<string>> userAgent = null, Expression<Func<string>> authorization = null, Expression<Func<string>> cookies = null, Expression<Func<string>> headers = null, Expression<Func<timeZoneInput>> timeZone = null, Expression<Func<string>> waitUntil = null, Expression<Func<int>> delay = null, Expression<Func<int>> timeout = null, Expression<Func<int>> navigationTimeout = null, Expression<Func<string>> waitForSelector = null, Expression<Func<bool>> cache = null, Expression<Func<int>> cacheTtl = null, Expression<Func<int>> cacheKey = null, Expression<Func<bool>> store = null, Expression<Func<string>> storagePath = null, Expression<Func<string>> storageBucket = null, Expression<Func<storageClassInput>> storageClass = null, Expression<Func<string>> storageAcl = null, Expression<Func<bool>> metadataImageSize = null, Expression<Func<bool>> ignoreHostErrors = null, Expression<Func<bool>> errorOnSelectorNotFound = null)
        {
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: false);
            var __workflow_scenario = WorkflowExpression.Compile(scenario, nameof(scenario), required: false);
            var __workflow_scrollDelay = WorkflowExpression.Compile(scrollDelay, nameof(scrollDelay), required: false);
            var __workflow_scrollDuration = WorkflowExpression.Compile(scrollDuration, nameof(scrollDuration), required: false);
            var __workflow_scrollBy = WorkflowExpression.Compile(scrollBy, nameof(scrollBy), required: false);
            var __workflow_scrollStartImmediately = WorkflowExpression.Compile(scrollStartImmediately, nameof(scrollStartImmediately), required: false);
            var __workflow_scrollBack = WorkflowExpression.Compile(scrollBack, nameof(scrollBack), required: false);
            var __workflow_scrollBackAfterDuration = WorkflowExpression.Compile(scrollBackAfterDuration, nameof(scrollBackAfterDuration), required: false);
            var __workflow_scrollComplete = WorkflowExpression.Compile(scrollComplete, nameof(scrollComplete), required: false);
            var __workflow_scrollStopAfterDuration = WorkflowExpression.Compile(scrollStopAfterDuration, nameof(scrollStopAfterDuration), required: false);
            var __workflow_scrollEasing = WorkflowExpression.Compile(scrollEasing, nameof(scrollEasing), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            var __workflow_duration = WorkflowExpression.Compile(duration, nameof(duration), required: false);
            var __workflow_width = WorkflowExpression.Compile(width, nameof(width), required: false);
            var __workflow_height = WorkflowExpression.Compile(height, nameof(height), required: false);
            var __workflow_aspectRatio = WorkflowExpression.Compile(aspectRatio, nameof(aspectRatio), required: false);
            var __workflow_viewportDevice = WorkflowExpression.Compile(viewportDevice, nameof(viewportDevice), required: false);
            var __workflow_viewportWidth = WorkflowExpression.Compile(viewportWidth, nameof(viewportWidth), required: false);
            var __workflow_viewportHeight = WorkflowExpression.Compile(viewportHeight, nameof(viewportHeight), required: false);
            var __workflow_deviceScaleFactor = WorkflowExpression.Compile(deviceScaleFactor, nameof(deviceScaleFactor), required: false);
            var __workflow_viewportMobile = WorkflowExpression.Compile(viewportMobile, nameof(viewportMobile), required: false);
            var __workflow_viewportHasTouch = WorkflowExpression.Compile(viewportHasTouch, nameof(viewportHasTouch), required: false);
            var __workflow_viewportLandscape = WorkflowExpression.Compile(viewportLandscape, nameof(viewportLandscape), required: false);
            var __workflow_blockCookieBanners = WorkflowExpression.Compile(blockCookieBanners, nameof(blockCookieBanners), required: false);
            var __workflow_blockBannersByHeuristics = WorkflowExpression.Compile(blockBannersByHeuristics, nameof(blockBannersByHeuristics), required: false);
            var __workflow_blockChats = WorkflowExpression.Compile(blockChats, nameof(blockChats), required: false);
            var __workflow_blockAds = WorkflowExpression.Compile(blockAds, nameof(blockAds), required: false);
            var __workflow_blockTrackers = WorkflowExpression.Compile(blockTrackers, nameof(blockTrackers), required: false);
            var __workflow_blockRequests = WorkflowExpression.Compile(blockRequests, nameof(blockRequests), required: false);
            var __workflow_blockResources = WorkflowExpression.Compile(blockResources, nameof(blockResources), required: false);
            var __workflow_geolocationLatitude = WorkflowExpression.Compile(geolocationLatitude, nameof(geolocationLatitude), required: false);
            var __workflow_geolocationLongitude = WorkflowExpression.Compile(geolocationLongitude, nameof(geolocationLongitude), required: false);
            var __workflow_geolocationAccuracy = WorkflowExpression.Compile(geolocationAccuracy, nameof(geolocationAccuracy), required: false);
            var __workflow_ipCountryCode = WorkflowExpression.Compile(ipCountryCode, nameof(ipCountryCode), required: false);
            var __workflow_proxy = WorkflowExpression.Compile(proxy, nameof(proxy), required: false);
            var __workflow_userAgent = WorkflowExpression.Compile(userAgent, nameof(userAgent), required: false);
            var __workflow_authorization = WorkflowExpression.Compile(authorization, nameof(authorization), required: false);
            var __workflow_cookies = WorkflowExpression.Compile(cookies, nameof(cookies), required: false);
            var __workflow_headers = WorkflowExpression.Compile(headers, nameof(headers), required: false);
            var __workflow_timeZone = WorkflowExpression.Compile(timeZone, nameof(timeZone), required: false);
            var __workflow_waitUntil = WorkflowExpression.Compile(waitUntil, nameof(waitUntil), required: false);
            var __workflow_delay = WorkflowExpression.Compile(delay, nameof(delay), required: false);
            var __workflow_timeout = WorkflowExpression.Compile(timeout, nameof(timeout), required: false);
            var __workflow_navigationTimeout = WorkflowExpression.Compile(navigationTimeout, nameof(navigationTimeout), required: false);
            var __workflow_waitForSelector = WorkflowExpression.Compile(waitForSelector, nameof(waitForSelector), required: false);
            var __workflow_cache = WorkflowExpression.Compile(cache, nameof(cache), required: false);
            var __workflow_cacheTtl = WorkflowExpression.Compile(cacheTtl, nameof(cacheTtl), required: false);
            var __workflow_cacheKey = WorkflowExpression.Compile(cacheKey, nameof(cacheKey), required: false);
            var __workflow_store = WorkflowExpression.Compile(store, nameof(store), required: false);
            var __workflow_storagePath = WorkflowExpression.Compile(storagePath, nameof(storagePath), required: false);
            var __workflow_storageBucket = WorkflowExpression.Compile(storageBucket, nameof(storageBucket), required: false);
            var __workflow_storageClass = WorkflowExpression.Compile(storageClass, nameof(storageClass), required: false);
            var __workflow_storageAcl = WorkflowExpression.Compile(storageAcl, nameof(storageAcl), required: false);
            var __workflow_metadataImageSize = WorkflowExpression.Compile(metadataImageSize, nameof(metadataImageSize), required: false);
            var __workflow_ignoreHostErrors = WorkflowExpression.Compile(ignoreHostErrors, nameof(ignoreHostErrors), required: false);
            var __workflow_errorOnSelectorNotFound = WorkflowExpression.Compile(errorOnSelectorNotFound, nameof(errorOnSelectorNotFound), required: false);
            return new DeferredBodyAction<TakeAnimatedGetResponse>(() =>
            {
                var apiCallPath = "/animate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(__workflow_url);
                if (__workflow_scenario != null)
                    callPayload.Queries["scenario"] = ExpressionConverter.Convert(__workflow_scenario);
                if (__workflow_scrollDelay != null)
                    callPayload.Queries["scroll_delay"] = ExpressionConverter.Convert(__workflow_scrollDelay);
                if (__workflow_scrollDuration != null)
                    callPayload.Queries["scroll_duration"] = ExpressionConverter.Convert(__workflow_scrollDuration);
                if (__workflow_scrollBy != null)
                    callPayload.Queries["scroll_by"] = ExpressionConverter.Convert(__workflow_scrollBy);
                if (__workflow_scrollStartImmediately != null)
                    callPayload.Queries["scroll_start_immediately"] = ExpressionConverter.Convert(__workflow_scrollStartImmediately);
                if (__workflow_scrollBack != null)
                    callPayload.Queries["scroll_back"] = ExpressionConverter.Convert(__workflow_scrollBack);
                if (__workflow_scrollBackAfterDuration != null)
                    callPayload.Queries["scroll_back_after_duration"] = ExpressionConverter.Convert(__workflow_scrollBackAfterDuration);
                if (__workflow_scrollComplete != null)
                    callPayload.Queries["scroll_complete"] = ExpressionConverter.Convert(__workflow_scrollComplete);
                if (__workflow_scrollStopAfterDuration != null)
                    callPayload.Queries["scroll_stop_after_duration"] = ExpressionConverter.Convert(__workflow_scrollStopAfterDuration);
                if (__workflow_scrollEasing != null)
                    callPayload.Queries["scroll_easing"] = ExpressionConverter.Convert(__workflow_scrollEasing);
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_duration != null)
                    callPayload.Queries["duration"] = ExpressionConverter.Convert(__workflow_duration);
                if (__workflow_width != null)
                    callPayload.Queries["width"] = ExpressionConverter.Convert(__workflow_width);
                if (__workflow_height != null)
                    callPayload.Queries["height"] = ExpressionConverter.Convert(__workflow_height);
                if (__workflow_aspectRatio != null)
                    callPayload.Queries["aspect_ratio"] = ExpressionConverter.Convert(__workflow_aspectRatio);
                if (__workflow_viewportDevice != null)
                    callPayload.Queries["viewport_device"] = ExpressionConverter.Convert(__workflow_viewportDevice);
                if (__workflow_viewportWidth != null)
                    callPayload.Queries["viewport_width"] = ExpressionConverter.Convert(__workflow_viewportWidth);
                if (__workflow_viewportHeight != null)
                    callPayload.Queries["viewport_height"] = ExpressionConverter.Convert(__workflow_viewportHeight);
                if (__workflow_deviceScaleFactor != null)
                    callPayload.Queries["device_scale_factor"] = ExpressionConverter.Convert(__workflow_deviceScaleFactor);
                if (__workflow_viewportMobile != null)
                    callPayload.Queries["viewport_mobile"] = ExpressionConverter.Convert(__workflow_viewportMobile);
                if (__workflow_viewportHasTouch != null)
                    callPayload.Queries["viewport_has_touch"] = ExpressionConverter.Convert(__workflow_viewportHasTouch);
                if (__workflow_viewportLandscape != null)
                    callPayload.Queries["viewport_landscape"] = ExpressionConverter.Convert(__workflow_viewportLandscape);
                if (__workflow_blockCookieBanners != null)
                    callPayload.Queries["block_cookie_banners"] = ExpressionConverter.Convert(__workflow_blockCookieBanners);
                if (__workflow_blockBannersByHeuristics != null)
                    callPayload.Queries["block_banners_by_heuristics"] = ExpressionConverter.Convert(__workflow_blockBannersByHeuristics);
                if (__workflow_blockChats != null)
                    callPayload.Queries["block_chats"] = ExpressionConverter.Convert(__workflow_blockChats);
                if (__workflow_blockAds != null)
                    callPayload.Queries["block_ads"] = ExpressionConverter.Convert(__workflow_blockAds);
                if (__workflow_blockTrackers != null)
                    callPayload.Queries["block_trackers"] = ExpressionConverter.Convert(__workflow_blockTrackers);
                if (__workflow_blockRequests != null)
                    callPayload.Queries["block_requests"] = ExpressionConverter.Convert(__workflow_blockRequests);
                if (__workflow_blockResources != null)
                    callPayload.Queries["block_resources"] = ExpressionConverter.Convert(__workflow_blockResources);
                if (__workflow_geolocationLatitude != null)
                    callPayload.Queries["geolocation_latitude"] = ExpressionConverter.Convert(__workflow_geolocationLatitude);
                if (__workflow_geolocationLongitude != null)
                    callPayload.Queries["geolocation_longitude"] = ExpressionConverter.Convert(__workflow_geolocationLongitude);
                if (__workflow_geolocationAccuracy != null)
                    callPayload.Queries["geolocation_accuracy"] = ExpressionConverter.Convert(__workflow_geolocationAccuracy);
                callPayload.Queries["ip_country_code"] = Convert.ToString("us");
                if (__workflow_ipCountryCode != null)
                    callPayload.Queries["ip_country_code"] = ExpressionConverter.Convert(__workflow_ipCountryCode);
                if (__workflow_proxy != null)
                    callPayload.Queries["proxy"] = ExpressionConverter.Convert(__workflow_proxy);
                if (__workflow_userAgent != null)
                    callPayload.Queries["user_agent"] = ExpressionConverter.Convert(__workflow_userAgent);
                if (__workflow_authorization != null)
                    callPayload.Queries["authorization"] = ExpressionConverter.Convert(__workflow_authorization);
                if (__workflow_cookies != null)
                    callPayload.Queries["cookies"] = ExpressionConverter.Convert(__workflow_cookies);
                if (__workflow_headers != null)
                    callPayload.Queries["headers"] = ExpressionConverter.Convert(__workflow_headers);
                if (__workflow_timeZone != null)
                    callPayload.Queries["time_zone"] = ExpressionConverter.Convert(__workflow_timeZone);
                if (__workflow_waitUntil != null)
                    callPayload.Queries["wait_until"] = ExpressionConverter.Convert(__workflow_waitUntil);
                if (__workflow_delay != null)
                    callPayload.Queries["delay"] = ExpressionConverter.Convert(__workflow_delay);
                if (__workflow_timeout != null)
                    callPayload.Queries["timeout"] = ExpressionConverter.Convert(__workflow_timeout);
                if (__workflow_navigationTimeout != null)
                    callPayload.Queries["navigation_timeout"] = ExpressionConverter.Convert(__workflow_navigationTimeout);
                if (__workflow_waitForSelector != null)
                    callPayload.Queries["wait_for_selector"] = ExpressionConverter.Convert(__workflow_waitForSelector);
                if (__workflow_cache != null)
                    callPayload.Queries["cache"] = ExpressionConverter.Convert(__workflow_cache);
                if (__workflow_cacheTtl != null)
                    callPayload.Queries["cache_ttl"] = ExpressionConverter.Convert(__workflow_cacheTtl);
                if (__workflow_cacheKey != null)
                    callPayload.Queries["cache_key"] = ExpressionConverter.Convert(__workflow_cacheKey);
                if (__workflow_store != null)
                    callPayload.Queries["store"] = ExpressionConverter.Convert(__workflow_store);
                if (__workflow_storagePath != null)
                    callPayload.Queries["storage_path"] = ExpressionConverter.Convert(__workflow_storagePath);
                if (__workflow_storageBucket != null)
                    callPayload.Queries["storage_bucket"] = ExpressionConverter.Convert(__workflow_storageBucket);
                if (__workflow_storageClass != null)
                    callPayload.Queries["storage_class"] = ExpressionConverter.Convert(__workflow_storageClass);
                if (__workflow_storageAcl != null)
                    callPayload.Queries["storage_acl"] = ExpressionConverter.Convert(__workflow_storageAcl);
                if (__workflow_metadataImageSize != null)
                    callPayload.Queries["metadata_image_size"] = ExpressionConverter.Convert(__workflow_metadataImageSize);
                if (__workflow_ignoreHostErrors != null)
                    callPayload.Queries["ignore_host_errors"] = ExpressionConverter.Convert(__workflow_ignoreHostErrors);
                if (__workflow_errorOnSelectorNotFound != null)
                    callPayload.Queries["error_on_selector_not_found"] = ExpressionConverter.Convert(__workflow_errorOnSelectorNotFound);
                return new ApiConnectionAction<TakeAnimatedGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "screenshotoneip")]
        public IBodyWorkflowAction<DeviceGetResponseItem[]> DeviceGet()
        {
            var apiCallPath = "/devices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeviceGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "screenshotoneip")]
        public IBodyWorkflowAction<UsageGetResponse> UsageGet()
        {
            var apiCallPath = "/usage";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UsageGetResponse>(callPayload);
        }
    }

    public class ScreenshotoneipTriggers([ConnectionName] string connectionId)
    {
    }

    public class TakeGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "mp4")]
        Mp4,
        [EnumMember(Value = "mov")]
        Mov,
        [EnumMember(Value = "avi")]
        Avi,
        [EnumMember(Value = "webm")]
        Webm,
        [EnumMember(Value = "gif")]
        Gif
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum responseTypeInput
    {
        [EnumMember(Value = "by_format")]
        ByFormat,
        [EnumMember(Value = "empty")]
        Empty,
        [EnumMember(Value = "json")]
        Json
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ipCountryCodeInput
    {
        [EnumMember(Value = "us")]
        Us,
        [EnumMember(Value = "gb")]
        Gb,
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "cn")]
        Cn,
        [EnumMember(Value = "ca")]
        Ca,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "jp")]
        Jp,
        [EnumMember(Value = "kr")]
        Kr,
        [EnumMember(Value = "in")]
        In,
        [EnumMember(Value = "au")]
        Au,
        [EnumMember(Value = "br")]
        Br,
        [EnumMember(Value = "mx")]
        Mx
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum timeZoneInput
    {
        [EnumMember(Value = "America/Belize")]
        AmericaBelize,
        [EnumMember(Value = "America/Cayman")]
        AmericaCayman,
        [EnumMember(Value = "America/Chicago")]
        AmericaChicago,
        [EnumMember(Value = "America/Costa_Rica")]
        AmericaCostaRica,
        [EnumMember(Value = "America/Denver")]
        AmericaDenver,
        [EnumMember(Value = "America/Edmonton")]
        AmericaEdmonton,
        [EnumMember(Value = "America/El_Salvador")]
        AmericaElSalvador,
        [EnumMember(Value = "America/Guatemala")]
        AmericaGuatemala,
        [EnumMember(Value = "America/Guayaquil")]
        AmericaGuayaquil,
        [EnumMember(Value = "America/Hermosillo")]
        AmericaHermosillo,
        [EnumMember(Value = "America/Jamaica")]
        AmericaJamaica,
        [EnumMember(Value = "America/Los_Angeles")]
        AmericaLosAngeles,
        [EnumMember(Value = "America/Mexico_City")]
        AmericaMexicoCity,
        [EnumMember(Value = "America/Nassau")]
        AmericaNassau,
        [EnumMember(Value = "America/New_York")]
        AmericaNewYork,
        [EnumMember(Value = "America/Panama")]
        AmericaPanama,
        [EnumMember(Value = "America/Port-au-Prince")]
        AmericaPortAuPrince,
        [EnumMember(Value = "America/Santiago")]
        AmericaSantiago,
        [EnumMember(Value = "America/Tegucigalpa")]
        AmericaTegucigalpa,
        [EnumMember(Value = "America/Tijuana")]
        AmericaTijuana,
        [EnumMember(Value = "America/Toronto")]
        AmericaToronto,
        [EnumMember(Value = "America/Vancouver")]
        AmericaVancouver,
        [EnumMember(Value = "America/Winnipeg")]
        AmericaWinnipeg,
        [EnumMember(Value = "Asia/Kuala_Lumpur")]
        AsiaKualaLumpur,
        [EnumMember(Value = "Asia/Shanghai")]
        AsiaShanghai,
        [EnumMember(Value = "Asia/Tashkent")]
        AsiaTashkent,
        [EnumMember(Value = "Europe/Berlin")]
        EuropeBerlin,
        [EnumMember(Value = "Europe/Kiev")]
        EuropeKiev,
        [EnumMember(Value = "Europe/Lisbon")]
        EuropeLisbon,
        [EnumMember(Value = "Europe/London")]
        EuropeLondon,
        [EnumMember(Value = "Europe/Madrid")]
        EuropeMadrid,
        [EnumMember(Value = "Pacific/Auckland")]
        PacificAuckland,
        [EnumMember(Value = "Pacific/Majuro")]
        PacificMajuro
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum storageClassInput
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "reduced_redundancy")]
        ReducedRedundancy,
        [EnumMember(Value = "standard_ia")]
        StandardIa,
        [EnumMember(Value = "onezone_ia")]
        OnezoneIa,
        [EnumMember(Value = "intelligent_tiering")]
        IntelligentTiering,
        [EnumMember(Value = "glacier")]
        Glacier,
        [EnumMember(Value = "deep_archive")]
        DeepArchive,
        [EnumMember(Value = "outposts")]
        Outposts,
        [EnumMember(Value = "glacier_ir")]
        GlacierIr
    }

    public class TakeAnimatedGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum scrollEasingInput
    {
        [EnumMember(Value = "linear")]
        Linear,
        [EnumMember(Value = "ease_in_quad")]
        EaseInQuad,
        [EnumMember(Value = "ease_out_quad")]
        EaseOutQuad,
        [EnumMember(Value = "ease_in_out_quad")]
        EaseInOutQuad,
        [EnumMember(Value = "ease_in_cubic")]
        EaseInCubic,
        [EnumMember(Value = "ease_out_cubic")]
        EaseOutCubic,
        [EnumMember(Value = "ease_in_out_cubic")]
        EaseInOutCubic,
        [EnumMember(Value = "ease_in_quart")]
        EaseInQuart,
        [EnumMember(Value = "ease_out_quart")]
        EaseOutQuart,
        [EnumMember(Value = "ease_in_out_quart")]
        EaseInOutQuart,
        [EnumMember(Value = "ease_in_quint")]
        EaseInQuint,
        [EnumMember(Value = "ease_out_quint")]
        EaseOutQuint,
        [EnumMember(Value = "ease_in_out_quint")]
        EaseInOutQuint
    }

    public class DeviceGetResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }

        [JsonProperty("viewport")]
        public DeviceGetResponseItemViewportType Viewport { get; set; }
    }

    public class DeviceGetResponseItemViewportType
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("deviceScaleFactor")]
        public double DeviceScaleFactor { get; set; }

        [JsonProperty("isMobile")]
        public bool IsMobile { get; set; }

        [JsonProperty("hasTouch")]
        public bool HasTouch { get; set; }

        [JsonProperty("isLandscape")]
        public bool IsLandscape { get; set; }
    }

    public class UsageGetResponse
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("available")]
        public int Available { get; set; }

        [JsonProperty("used")]
        public int Used { get; set; }

        [JsonProperty("concurrency")]
        public UsageGetResponseConcurrencyType Concurrency { get; set; }
    }

    public class UsageGetResponseConcurrencyType
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("reset")]
        public int Reset { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Screenshotoneip;

    public partial class WorkflowManagedActions
    {
        public ScreenshotoneipActions Screenshotoneip(string connectionId) => new ScreenshotoneipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ScreenshotoneipTriggers Screenshotoneip(string connectionId) => new ScreenshotoneipTriggers(connectionId);
    }
}
