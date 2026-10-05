//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Screenshotoneip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ScreenshotoneipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "screenshotoneip")]
        [WorkflowExpressionFactory(nameof(__BuildTakeGet))]
        public IBodyWorkflowAction<TakeGetResponse> TakeGet([WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<string> html = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<responseTypeInput> responseType = null, [WorkflowExpression] Func<string> selector = null, [WorkflowExpression] Func<bool> captureBeyondViewport = null, [WorkflowExpression] Func<string> scrollIntoView = null, [WorkflowExpression] Func<int> scrollIntoViewAdjustTop = null, [WorkflowExpression] Func<bool> fullPage = null, [WorkflowExpression] Func<bool> fullPageScroll = null, [WorkflowExpression] Func<int> fullPageScrollDelay = null, [WorkflowExpression] Func<int> fullPageScrollBy = null, [WorkflowExpression] Func<int> fullPageMaxHeight = null, [WorkflowExpression] Func<string> viewportDevice = null, [WorkflowExpression] Func<int> viewportWidth = null, [WorkflowExpression] Func<int> viewportHeight = null, [WorkflowExpression] Func<int> deviceScaleFactor = null, [WorkflowExpression] Func<bool> viewportMobile = null, [WorkflowExpression] Func<bool> viewportHasTouch = null, [WorkflowExpression] Func<bool> viewportLandscape = null, [WorkflowExpression] Func<int> imageQuality = null, [WorkflowExpression] Func<int> imageWidth = null, [WorkflowExpression] Func<int> imageHeight = null, [WorkflowExpression] Func<bool> omitBackground = null, [WorkflowExpression] Func<bool> darkMode = null, [WorkflowExpression] Func<bool> reducedMotion = null, [WorkflowExpression] Func<string> mediaType = null, [WorkflowExpression] Func<string> hideSelectors = null, [WorkflowExpression] Func<string> scripts = null, [WorkflowExpression] Func<string> scriptsWaitUntil = null, [WorkflowExpression] Func<string> styles = null, [WorkflowExpression] Func<string> click = null, [WorkflowExpression] Func<bool> blockCookieBanners = null, [WorkflowExpression] Func<bool> blockBannersByHeuristics = null, [WorkflowExpression] Func<bool> blockChats = null, [WorkflowExpression] Func<bool> blockAds = null, [WorkflowExpression] Func<bool> blockTrackers = null, [WorkflowExpression] Func<string> blockRequests = null, [WorkflowExpression] Func<string> blockResources = null, [WorkflowExpression] Func<double> geolocationLatitude = null, [WorkflowExpression] Func<double> geolocationLongitude = null, [WorkflowExpression] Func<int> geolocationAccuracy = null, [WorkflowExpression] Func<ipCountryCodeInput> ipCountryCode = null, [WorkflowExpression] Func<string> proxy = null, [WorkflowExpression] Func<string> userAgent = null, [WorkflowExpression] Func<string> authorization = null, [WorkflowExpression] Func<string> cookies = null, [WorkflowExpression] Func<string> headers = null, [WorkflowExpression] Func<timeZoneInput> timeZone = null, [WorkflowExpression] Func<string> waitUntil = null, [WorkflowExpression] Func<int> delay = null, [WorkflowExpression] Func<int> timeout = null, [WorkflowExpression] Func<int> navigationTimeout = null, [WorkflowExpression] Func<string> waitForSelector = null, [WorkflowExpression] Func<bool> cache = null, [WorkflowExpression] Func<int> cacheTtl = null, [WorkflowExpression] Func<int> cacheKey = null, [WorkflowExpression] Func<bool> store = null, [WorkflowExpression] Func<string> storagePath = null, [WorkflowExpression] Func<string> storageBucket = null, [WorkflowExpression] Func<storageClassInput> storageClass = null, [WorkflowExpression] Func<string> storageAcl = null, [WorkflowExpression] Func<bool> metadataImageSize = null, [WorkflowExpression] Func<bool> ignoreHostErrors = null, [WorkflowExpression] Func<bool> errorOnSelectorNotFound = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TakeGetResponse> __BuildTakeGet(WorkflowValue<string> url = null, WorkflowValue<string> html = null, WorkflowValue<formatInput> format = null, WorkflowValue<responseTypeInput> responseType = null, WorkflowValue<string> selector = null, WorkflowValue<bool> captureBeyondViewport = null, WorkflowValue<string> scrollIntoView = null, WorkflowValue<int> scrollIntoViewAdjustTop = null, WorkflowValue<bool> fullPage = null, WorkflowValue<bool> fullPageScroll = null, WorkflowValue<int> fullPageScrollDelay = null, WorkflowValue<int> fullPageScrollBy = null, WorkflowValue<int> fullPageMaxHeight = null, WorkflowValue<string> viewportDevice = null, WorkflowValue<int> viewportWidth = null, WorkflowValue<int> viewportHeight = null, WorkflowValue<int> deviceScaleFactor = null, WorkflowValue<bool> viewportMobile = null, WorkflowValue<bool> viewportHasTouch = null, WorkflowValue<bool> viewportLandscape = null, WorkflowValue<int> imageQuality = null, WorkflowValue<int> imageWidth = null, WorkflowValue<int> imageHeight = null, WorkflowValue<bool> omitBackground = null, WorkflowValue<bool> darkMode = null, WorkflowValue<bool> reducedMotion = null, WorkflowValue<string> mediaType = null, WorkflowValue<string> hideSelectors = null, WorkflowValue<string> scripts = null, WorkflowValue<string> scriptsWaitUntil = null, WorkflowValue<string> styles = null, WorkflowValue<string> click = null, WorkflowValue<bool> blockCookieBanners = null, WorkflowValue<bool> blockBannersByHeuristics = null, WorkflowValue<bool> blockChats = null, WorkflowValue<bool> blockAds = null, WorkflowValue<bool> blockTrackers = null, WorkflowValue<string> blockRequests = null, WorkflowValue<string> blockResources = null, WorkflowValue<double> geolocationLatitude = null, WorkflowValue<double> geolocationLongitude = null, WorkflowValue<int> geolocationAccuracy = null, WorkflowValue<ipCountryCodeInput> ipCountryCode = null, WorkflowValue<string> proxy = null, WorkflowValue<string> userAgent = null, WorkflowValue<string> authorization = null, WorkflowValue<string> cookies = null, WorkflowValue<string> headers = null, WorkflowValue<timeZoneInput> timeZone = null, WorkflowValue<string> waitUntil = null, WorkflowValue<int> delay = null, WorkflowValue<int> timeout = null, WorkflowValue<int> navigationTimeout = null, WorkflowValue<string> waitForSelector = null, WorkflowValue<bool> cache = null, WorkflowValue<int> cacheTtl = null, WorkflowValue<int> cacheKey = null, WorkflowValue<bool> store = null, WorkflowValue<string> storagePath = null, WorkflowValue<string> storageBucket = null, WorkflowValue<storageClassInput> storageClass = null, WorkflowValue<string> storageAcl = null, WorkflowValue<bool> metadataImageSize = null, WorkflowValue<bool> ignoreHostErrors = null, WorkflowValue<bool> errorOnSelectorNotFound = null)
        {
            WorkflowValue.Validate(url, nameof(url), required: false);
            WorkflowValue.Validate(html, nameof(html), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(responseType, nameof(responseType), required: false);
            WorkflowValue.Validate(selector, nameof(selector), required: false);
            WorkflowValue.Validate(captureBeyondViewport, nameof(captureBeyondViewport), required: false);
            WorkflowValue.Validate(scrollIntoView, nameof(scrollIntoView), required: false);
            WorkflowValue.Validate(scrollIntoViewAdjustTop, nameof(scrollIntoViewAdjustTop), required: false);
            WorkflowValue.Validate(fullPage, nameof(fullPage), required: false);
            WorkflowValue.Validate(fullPageScroll, nameof(fullPageScroll), required: false);
            WorkflowValue.Validate(fullPageScrollDelay, nameof(fullPageScrollDelay), required: false);
            WorkflowValue.Validate(fullPageScrollBy, nameof(fullPageScrollBy), required: false);
            WorkflowValue.Validate(fullPageMaxHeight, nameof(fullPageMaxHeight), required: false);
            WorkflowValue.Validate(viewportDevice, nameof(viewportDevice), required: false);
            WorkflowValue.Validate(viewportWidth, nameof(viewportWidth), required: false);
            WorkflowValue.Validate(viewportHeight, nameof(viewportHeight), required: false);
            WorkflowValue.Validate(deviceScaleFactor, nameof(deviceScaleFactor), required: false);
            WorkflowValue.Validate(viewportMobile, nameof(viewportMobile), required: false);
            WorkflowValue.Validate(viewportHasTouch, nameof(viewportHasTouch), required: false);
            WorkflowValue.Validate(viewportLandscape, nameof(viewportLandscape), required: false);
            WorkflowValue.Validate(imageQuality, nameof(imageQuality), required: false);
            WorkflowValue.Validate(imageWidth, nameof(imageWidth), required: false);
            WorkflowValue.Validate(imageHeight, nameof(imageHeight), required: false);
            WorkflowValue.Validate(omitBackground, nameof(omitBackground), required: false);
            WorkflowValue.Validate(darkMode, nameof(darkMode), required: false);
            WorkflowValue.Validate(reducedMotion, nameof(reducedMotion), required: false);
            WorkflowValue.Validate(mediaType, nameof(mediaType), required: false);
            WorkflowValue.Validate(hideSelectors, nameof(hideSelectors), required: false);
            WorkflowValue.Validate(scripts, nameof(scripts), required: false);
            WorkflowValue.Validate(scriptsWaitUntil, nameof(scriptsWaitUntil), required: false);
            WorkflowValue.Validate(styles, nameof(styles), required: false);
            WorkflowValue.Validate(click, nameof(click), required: false);
            WorkflowValue.Validate(blockCookieBanners, nameof(blockCookieBanners), required: false);
            WorkflowValue.Validate(blockBannersByHeuristics, nameof(blockBannersByHeuristics), required: false);
            WorkflowValue.Validate(blockChats, nameof(blockChats), required: false);
            WorkflowValue.Validate(blockAds, nameof(blockAds), required: false);
            WorkflowValue.Validate(blockTrackers, nameof(blockTrackers), required: false);
            WorkflowValue.Validate(blockRequests, nameof(blockRequests), required: false);
            WorkflowValue.Validate(blockResources, nameof(blockResources), required: false);
            WorkflowValue.Validate(geolocationLatitude, nameof(geolocationLatitude), required: false);
            WorkflowValue.Validate(geolocationLongitude, nameof(geolocationLongitude), required: false);
            WorkflowValue.Validate(geolocationAccuracy, nameof(geolocationAccuracy), required: false);
            WorkflowValue.Validate(ipCountryCode, nameof(ipCountryCode), required: false);
            WorkflowValue.Validate(proxy, nameof(proxy), required: false);
            WorkflowValue.Validate(userAgent, nameof(userAgent), required: false);
            WorkflowValue.Validate(authorization, nameof(authorization), required: false);
            WorkflowValue.Validate(cookies, nameof(cookies), required: false);
            WorkflowValue.Validate(headers, nameof(headers), required: false);
            WorkflowValue.Validate(timeZone, nameof(timeZone), required: false);
            WorkflowValue.Validate(waitUntil, nameof(waitUntil), required: false);
            WorkflowValue.Validate(delay, nameof(delay), required: false);
            WorkflowValue.Validate(timeout, nameof(timeout), required: false);
            WorkflowValue.Validate(navigationTimeout, nameof(navigationTimeout), required: false);
            WorkflowValue.Validate(waitForSelector, nameof(waitForSelector), required: false);
            WorkflowValue.Validate(cache, nameof(cache), required: false);
            WorkflowValue.Validate(cacheTtl, nameof(cacheTtl), required: false);
            WorkflowValue.Validate(cacheKey, nameof(cacheKey), required: false);
            WorkflowValue.Validate(store, nameof(store), required: false);
            WorkflowValue.Validate(storagePath, nameof(storagePath), required: false);
            WorkflowValue.Validate(storageBucket, nameof(storageBucket), required: false);
            WorkflowValue.Validate(storageClass, nameof(storageClass), required: false);
            WorkflowValue.Validate(storageAcl, nameof(storageAcl), required: false);
            WorkflowValue.Validate(metadataImageSize, nameof(metadataImageSize), required: false);
            WorkflowValue.Validate(ignoreHostErrors, nameof(ignoreHostErrors), required: false);
            WorkflowValue.Validate(errorOnSelectorNotFound, nameof(errorOnSelectorNotFound), required: false);
            return new DeferredBodyAction<TakeGetResponse>(() =>
            {
                var apiCallPath = "/take";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                if (html != null)
                    callPayload.Queries["html"] = ExpressionConverter.Convert(html);
                callPayload.Queries["format"] = Convert.ToString("jpg");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Queries["response_type"] = Convert.ToString("by_format");
                if (responseType != null)
                    callPayload.Queries["response_type"] = ExpressionConverter.Convert(responseType);
                if (selector != null)
                    callPayload.Queries["selector"] = ExpressionConverter.Convert(selector);
                if (captureBeyondViewport != null)
                    callPayload.Queries["capture_beyond_viewport"] = ExpressionConverter.Convert(captureBeyondViewport);
                if (scrollIntoView != null)
                    callPayload.Queries["scroll_into_view"] = ExpressionConverter.Convert(scrollIntoView);
                if (scrollIntoViewAdjustTop != null)
                    callPayload.Queries["scroll_into_view_adjust_top"] = ExpressionConverter.Convert(scrollIntoViewAdjustTop);
                if (fullPage != null)
                    callPayload.Queries["full_page"] = ExpressionConverter.Convert(fullPage);
                if (fullPageScroll != null)
                    callPayload.Queries["full_page_scroll"] = ExpressionConverter.Convert(fullPageScroll);
                if (fullPageScrollDelay != null)
                    callPayload.Queries["full_page_scroll_delay"] = ExpressionConverter.Convert(fullPageScrollDelay);
                if (fullPageScrollBy != null)
                    callPayload.Queries["full_page_scroll_by"] = ExpressionConverter.Convert(fullPageScrollBy);
                if (fullPageMaxHeight != null)
                    callPayload.Queries["full_page_max_height"] = ExpressionConverter.Convert(fullPageMaxHeight);
                if (viewportDevice != null)
                    callPayload.Queries["viewport_device"] = ExpressionConverter.Convert(viewportDevice);
                if (viewportWidth != null)
                    callPayload.Queries["viewport_width"] = ExpressionConverter.Convert(viewportWidth);
                if (viewportHeight != null)
                    callPayload.Queries["viewport_height"] = ExpressionConverter.Convert(viewportHeight);
                if (deviceScaleFactor != null)
                    callPayload.Queries["device_scale_factor"] = ExpressionConverter.Convert(deviceScaleFactor);
                if (viewportMobile != null)
                    callPayload.Queries["viewport_mobile"] = ExpressionConverter.Convert(viewportMobile);
                if (viewportHasTouch != null)
                    callPayload.Queries["viewport_has_touch"] = ExpressionConverter.Convert(viewportHasTouch);
                if (viewportLandscape != null)
                    callPayload.Queries["viewport_landscape"] = ExpressionConverter.Convert(viewportLandscape);
                if (imageQuality != null)
                    callPayload.Queries["image_quality"] = ExpressionConverter.Convert(imageQuality);
                if (imageWidth != null)
                    callPayload.Queries["image_width"] = ExpressionConverter.Convert(imageWidth);
                if (imageHeight != null)
                    callPayload.Queries["image_height"] = ExpressionConverter.Convert(imageHeight);
                if (omitBackground != null)
                    callPayload.Queries["omit_background"] = ExpressionConverter.Convert(omitBackground);
                if (darkMode != null)
                    callPayload.Queries["dark_mode"] = ExpressionConverter.Convert(darkMode);
                if (reducedMotion != null)
                    callPayload.Queries["reduced_motion"] = ExpressionConverter.Convert(reducedMotion);
                if (mediaType != null)
                    callPayload.Queries["media_type"] = ExpressionConverter.Convert(mediaType);
                if (hideSelectors != null)
                    callPayload.Queries["hide_selectors"] = ExpressionConverter.Convert(hideSelectors);
                if (scripts != null)
                    callPayload.Queries["scripts"] = ExpressionConverter.Convert(scripts);
                if (scriptsWaitUntil != null)
                    callPayload.Queries["scripts_wait_until"] = ExpressionConverter.Convert(scriptsWaitUntil);
                if (styles != null)
                    callPayload.Queries["styles"] = ExpressionConverter.Convert(styles);
                if (click != null)
                    callPayload.Queries["click"] = ExpressionConverter.Convert(click);
                if (blockCookieBanners != null)
                    callPayload.Queries["block_cookie_banners"] = ExpressionConverter.Convert(blockCookieBanners);
                if (blockBannersByHeuristics != null)
                    callPayload.Queries["block_banners_by_heuristics"] = ExpressionConverter.Convert(blockBannersByHeuristics);
                if (blockChats != null)
                    callPayload.Queries["block_chats"] = ExpressionConverter.Convert(blockChats);
                if (blockAds != null)
                    callPayload.Queries["block_ads"] = ExpressionConverter.Convert(blockAds);
                if (blockTrackers != null)
                    callPayload.Queries["block_trackers"] = ExpressionConverter.Convert(blockTrackers);
                if (blockRequests != null)
                    callPayload.Queries["block_requests"] = ExpressionConverter.Convert(blockRequests);
                if (blockResources != null)
                    callPayload.Queries["block_resources"] = ExpressionConverter.Convert(blockResources);
                if (geolocationLatitude != null)
                    callPayload.Queries["geolocation_latitude"] = ExpressionConverter.Convert(geolocationLatitude);
                if (geolocationLongitude != null)
                    callPayload.Queries["geolocation_longitude"] = ExpressionConverter.Convert(geolocationLongitude);
                if (geolocationAccuracy != null)
                    callPayload.Queries["geolocation_accuracy"] = ExpressionConverter.Convert(geolocationAccuracy);
                callPayload.Queries["ip_country_code"] = Convert.ToString("us");
                if (ipCountryCode != null)
                    callPayload.Queries["ip_country_code"] = ExpressionConverter.Convert(ipCountryCode);
                if (proxy != null)
                    callPayload.Queries["proxy"] = ExpressionConverter.Convert(proxy);
                if (userAgent != null)
                    callPayload.Queries["user_agent"] = ExpressionConverter.Convert(userAgent);
                if (authorization != null)
                    callPayload.Queries["authorization"] = ExpressionConverter.Convert(authorization);
                if (cookies != null)
                    callPayload.Queries["cookies"] = ExpressionConverter.Convert(cookies);
                if (headers != null)
                    callPayload.Queries["headers"] = ExpressionConverter.Convert(headers);
                if (timeZone != null)
                    callPayload.Queries["time_zone"] = ExpressionConverter.Convert(timeZone);
                if (waitUntil != null)
                    callPayload.Queries["wait_until"] = ExpressionConverter.Convert(waitUntil);
                if (delay != null)
                    callPayload.Queries["delay"] = ExpressionConverter.Convert(delay);
                if (timeout != null)
                    callPayload.Queries["timeout"] = ExpressionConverter.Convert(timeout);
                if (navigationTimeout != null)
                    callPayload.Queries["navigation_timeout"] = ExpressionConverter.Convert(navigationTimeout);
                if (waitForSelector != null)
                    callPayload.Queries["wait_for_selector"] = ExpressionConverter.Convert(waitForSelector);
                if (cache != null)
                    callPayload.Queries["cache"] = ExpressionConverter.Convert(cache);
                if (cacheTtl != null)
                    callPayload.Queries["cache_ttl"] = ExpressionConverter.Convert(cacheTtl);
                if (cacheKey != null)
                    callPayload.Queries["cache_key"] = ExpressionConverter.Convert(cacheKey);
                if (store != null)
                    callPayload.Queries["store"] = ExpressionConverter.Convert(store);
                if (storagePath != null)
                    callPayload.Queries["storage_path"] = ExpressionConverter.Convert(storagePath);
                if (storageBucket != null)
                    callPayload.Queries["storage_bucket"] = ExpressionConverter.Convert(storageBucket);
                if (storageClass != null)
                    callPayload.Queries["storage_class"] = ExpressionConverter.Convert(storageClass);
                if (storageAcl != null)
                    callPayload.Queries["storage_acl"] = ExpressionConverter.Convert(storageAcl);
                if (metadataImageSize != null)
                    callPayload.Queries["metadata_image_size"] = ExpressionConverter.Convert(metadataImageSize);
                if (ignoreHostErrors != null)
                    callPayload.Queries["ignore_host_errors"] = ExpressionConverter.Convert(ignoreHostErrors);
                if (errorOnSelectorNotFound != null)
                    callPayload.Queries["error_on_selector_not_found"] = ExpressionConverter.Convert(errorOnSelectorNotFound);
                return new ApiConnectionAction<TakeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "screenshotoneip")]
        [WorkflowExpressionFactory(nameof(__BuildTakeAnimatedGet))]
        public IBodyWorkflowAction<TakeAnimatedGetResponse> TakeAnimatedGet([WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<string> scenario = null, [WorkflowExpression] Func<int> scrollDelay = null, [WorkflowExpression] Func<int> scrollDuration = null, [WorkflowExpression] Func<int> scrollBy = null, [WorkflowExpression] Func<bool> scrollStartImmediately = null, [WorkflowExpression] Func<bool> scrollBack = null, [WorkflowExpression] Func<int> scrollBackAfterDuration = null, [WorkflowExpression] Func<bool> scrollComplete = null, [WorkflowExpression] Func<int> scrollStopAfterDuration = null, [WorkflowExpression] Func<scrollEasingInput> scrollEasing = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<int> duration = null, [WorkflowExpression] Func<int> width = null, [WorkflowExpression] Func<int> height = null, [WorkflowExpression] Func<string> aspectRatio = null, [WorkflowExpression] Func<string> viewportDevice = null, [WorkflowExpression] Func<int> viewportWidth = null, [WorkflowExpression] Func<int> viewportHeight = null, [WorkflowExpression] Func<int> deviceScaleFactor = null, [WorkflowExpression] Func<bool> viewportMobile = null, [WorkflowExpression] Func<bool> viewportHasTouch = null, [WorkflowExpression] Func<bool> viewportLandscape = null, [WorkflowExpression] Func<bool> blockCookieBanners = null, [WorkflowExpression] Func<bool> blockBannersByHeuristics = null, [WorkflowExpression] Func<bool> blockChats = null, [WorkflowExpression] Func<bool> blockAds = null, [WorkflowExpression] Func<bool> blockTrackers = null, [WorkflowExpression] Func<string> blockRequests = null, [WorkflowExpression] Func<string> blockResources = null, [WorkflowExpression] Func<double> geolocationLatitude = null, [WorkflowExpression] Func<double> geolocationLongitude = null, [WorkflowExpression] Func<int> geolocationAccuracy = null, [WorkflowExpression] Func<ipCountryCodeInput> ipCountryCode = null, [WorkflowExpression] Func<string> proxy = null, [WorkflowExpression] Func<string> userAgent = null, [WorkflowExpression] Func<string> authorization = null, [WorkflowExpression] Func<string> cookies = null, [WorkflowExpression] Func<string> headers = null, [WorkflowExpression] Func<timeZoneInput> timeZone = null, [WorkflowExpression] Func<string> waitUntil = null, [WorkflowExpression] Func<int> delay = null, [WorkflowExpression] Func<int> timeout = null, [WorkflowExpression] Func<int> navigationTimeout = null, [WorkflowExpression] Func<string> waitForSelector = null, [WorkflowExpression] Func<bool> cache = null, [WorkflowExpression] Func<int> cacheTtl = null, [WorkflowExpression] Func<int> cacheKey = null, [WorkflowExpression] Func<bool> store = null, [WorkflowExpression] Func<string> storagePath = null, [WorkflowExpression] Func<string> storageBucket = null, [WorkflowExpression] Func<storageClassInput> storageClass = null, [WorkflowExpression] Func<string> storageAcl = null, [WorkflowExpression] Func<bool> metadataImageSize = null, [WorkflowExpression] Func<bool> ignoreHostErrors = null, [WorkflowExpression] Func<bool> errorOnSelectorNotFound = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TakeAnimatedGetResponse> __BuildTakeAnimatedGet(WorkflowValue<string> url = null, WorkflowValue<string> scenario = null, WorkflowValue<int> scrollDelay = null, WorkflowValue<int> scrollDuration = null, WorkflowValue<int> scrollBy = null, WorkflowValue<bool> scrollStartImmediately = null, WorkflowValue<bool> scrollBack = null, WorkflowValue<int> scrollBackAfterDuration = null, WorkflowValue<bool> scrollComplete = null, WorkflowValue<int> scrollStopAfterDuration = null, WorkflowValue<scrollEasingInput> scrollEasing = null, WorkflowValue<formatInput> format = null, WorkflowValue<int> duration = null, WorkflowValue<int> width = null, WorkflowValue<int> height = null, WorkflowValue<string> aspectRatio = null, WorkflowValue<string> viewportDevice = null, WorkflowValue<int> viewportWidth = null, WorkflowValue<int> viewportHeight = null, WorkflowValue<int> deviceScaleFactor = null, WorkflowValue<bool> viewportMobile = null, WorkflowValue<bool> viewportHasTouch = null, WorkflowValue<bool> viewportLandscape = null, WorkflowValue<bool> blockCookieBanners = null, WorkflowValue<bool> blockBannersByHeuristics = null, WorkflowValue<bool> blockChats = null, WorkflowValue<bool> blockAds = null, WorkflowValue<bool> blockTrackers = null, WorkflowValue<string> blockRequests = null, WorkflowValue<string> blockResources = null, WorkflowValue<double> geolocationLatitude = null, WorkflowValue<double> geolocationLongitude = null, WorkflowValue<int> geolocationAccuracy = null, WorkflowValue<ipCountryCodeInput> ipCountryCode = null, WorkflowValue<string> proxy = null, WorkflowValue<string> userAgent = null, WorkflowValue<string> authorization = null, WorkflowValue<string> cookies = null, WorkflowValue<string> headers = null, WorkflowValue<timeZoneInput> timeZone = null, WorkflowValue<string> waitUntil = null, WorkflowValue<int> delay = null, WorkflowValue<int> timeout = null, WorkflowValue<int> navigationTimeout = null, WorkflowValue<string> waitForSelector = null, WorkflowValue<bool> cache = null, WorkflowValue<int> cacheTtl = null, WorkflowValue<int> cacheKey = null, WorkflowValue<bool> store = null, WorkflowValue<string> storagePath = null, WorkflowValue<string> storageBucket = null, WorkflowValue<storageClassInput> storageClass = null, WorkflowValue<string> storageAcl = null, WorkflowValue<bool> metadataImageSize = null, WorkflowValue<bool> ignoreHostErrors = null, WorkflowValue<bool> errorOnSelectorNotFound = null)
        {
            WorkflowValue.Validate(url, nameof(url), required: false);
            WorkflowValue.Validate(scenario, nameof(scenario), required: false);
            WorkflowValue.Validate(scrollDelay, nameof(scrollDelay), required: false);
            WorkflowValue.Validate(scrollDuration, nameof(scrollDuration), required: false);
            WorkflowValue.Validate(scrollBy, nameof(scrollBy), required: false);
            WorkflowValue.Validate(scrollStartImmediately, nameof(scrollStartImmediately), required: false);
            WorkflowValue.Validate(scrollBack, nameof(scrollBack), required: false);
            WorkflowValue.Validate(scrollBackAfterDuration, nameof(scrollBackAfterDuration), required: false);
            WorkflowValue.Validate(scrollComplete, nameof(scrollComplete), required: false);
            WorkflowValue.Validate(scrollStopAfterDuration, nameof(scrollStopAfterDuration), required: false);
            WorkflowValue.Validate(scrollEasing, nameof(scrollEasing), required: false);
            WorkflowValue.Validate(format, nameof(format), required: false);
            WorkflowValue.Validate(duration, nameof(duration), required: false);
            WorkflowValue.Validate(width, nameof(width), required: false);
            WorkflowValue.Validate(height, nameof(height), required: false);
            WorkflowValue.Validate(aspectRatio, nameof(aspectRatio), required: false);
            WorkflowValue.Validate(viewportDevice, nameof(viewportDevice), required: false);
            WorkflowValue.Validate(viewportWidth, nameof(viewportWidth), required: false);
            WorkflowValue.Validate(viewportHeight, nameof(viewportHeight), required: false);
            WorkflowValue.Validate(deviceScaleFactor, nameof(deviceScaleFactor), required: false);
            WorkflowValue.Validate(viewportMobile, nameof(viewportMobile), required: false);
            WorkflowValue.Validate(viewportHasTouch, nameof(viewportHasTouch), required: false);
            WorkflowValue.Validate(viewportLandscape, nameof(viewportLandscape), required: false);
            WorkflowValue.Validate(blockCookieBanners, nameof(blockCookieBanners), required: false);
            WorkflowValue.Validate(blockBannersByHeuristics, nameof(blockBannersByHeuristics), required: false);
            WorkflowValue.Validate(blockChats, nameof(blockChats), required: false);
            WorkflowValue.Validate(blockAds, nameof(blockAds), required: false);
            WorkflowValue.Validate(blockTrackers, nameof(blockTrackers), required: false);
            WorkflowValue.Validate(blockRequests, nameof(blockRequests), required: false);
            WorkflowValue.Validate(blockResources, nameof(blockResources), required: false);
            WorkflowValue.Validate(geolocationLatitude, nameof(geolocationLatitude), required: false);
            WorkflowValue.Validate(geolocationLongitude, nameof(geolocationLongitude), required: false);
            WorkflowValue.Validate(geolocationAccuracy, nameof(geolocationAccuracy), required: false);
            WorkflowValue.Validate(ipCountryCode, nameof(ipCountryCode), required: false);
            WorkflowValue.Validate(proxy, nameof(proxy), required: false);
            WorkflowValue.Validate(userAgent, nameof(userAgent), required: false);
            WorkflowValue.Validate(authorization, nameof(authorization), required: false);
            WorkflowValue.Validate(cookies, nameof(cookies), required: false);
            WorkflowValue.Validate(headers, nameof(headers), required: false);
            WorkflowValue.Validate(timeZone, nameof(timeZone), required: false);
            WorkflowValue.Validate(waitUntil, nameof(waitUntil), required: false);
            WorkflowValue.Validate(delay, nameof(delay), required: false);
            WorkflowValue.Validate(timeout, nameof(timeout), required: false);
            WorkflowValue.Validate(navigationTimeout, nameof(navigationTimeout), required: false);
            WorkflowValue.Validate(waitForSelector, nameof(waitForSelector), required: false);
            WorkflowValue.Validate(cache, nameof(cache), required: false);
            WorkflowValue.Validate(cacheTtl, nameof(cacheTtl), required: false);
            WorkflowValue.Validate(cacheKey, nameof(cacheKey), required: false);
            WorkflowValue.Validate(store, nameof(store), required: false);
            WorkflowValue.Validate(storagePath, nameof(storagePath), required: false);
            WorkflowValue.Validate(storageBucket, nameof(storageBucket), required: false);
            WorkflowValue.Validate(storageClass, nameof(storageClass), required: false);
            WorkflowValue.Validate(storageAcl, nameof(storageAcl), required: false);
            WorkflowValue.Validate(metadataImageSize, nameof(metadataImageSize), required: false);
            WorkflowValue.Validate(ignoreHostErrors, nameof(ignoreHostErrors), required: false);
            WorkflowValue.Validate(errorOnSelectorNotFound, nameof(errorOnSelectorNotFound), required: false);
            return new DeferredBodyAction<TakeAnimatedGetResponse>(() =>
            {
                var apiCallPath = "/animate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (url != null)
                    callPayload.Queries["url"] = ExpressionConverter.Convert(url);
                if (scenario != null)
                    callPayload.Queries["scenario"] = ExpressionConverter.Convert(scenario);
                if (scrollDelay != null)
                    callPayload.Queries["scroll_delay"] = ExpressionConverter.Convert(scrollDelay);
                if (scrollDuration != null)
                    callPayload.Queries["scroll_duration"] = ExpressionConverter.Convert(scrollDuration);
                if (scrollBy != null)
                    callPayload.Queries["scroll_by"] = ExpressionConverter.Convert(scrollBy);
                if (scrollStartImmediately != null)
                    callPayload.Queries["scroll_start_immediately"] = ExpressionConverter.Convert(scrollStartImmediately);
                if (scrollBack != null)
                    callPayload.Queries["scroll_back"] = ExpressionConverter.Convert(scrollBack);
                if (scrollBackAfterDuration != null)
                    callPayload.Queries["scroll_back_after_duration"] = ExpressionConverter.Convert(scrollBackAfterDuration);
                if (scrollComplete != null)
                    callPayload.Queries["scroll_complete"] = ExpressionConverter.Convert(scrollComplete);
                if (scrollStopAfterDuration != null)
                    callPayload.Queries["scroll_stop_after_duration"] = ExpressionConverter.Convert(scrollStopAfterDuration);
                if (scrollEasing != null)
                    callPayload.Queries["scroll_easing"] = ExpressionConverter.Convert(scrollEasing);
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (duration != null)
                    callPayload.Queries["duration"] = ExpressionConverter.Convert(duration);
                if (width != null)
                    callPayload.Queries["width"] = ExpressionConverter.Convert(width);
                if (height != null)
                    callPayload.Queries["height"] = ExpressionConverter.Convert(height);
                if (aspectRatio != null)
                    callPayload.Queries["aspect_ratio"] = ExpressionConverter.Convert(aspectRatio);
                if (viewportDevice != null)
                    callPayload.Queries["viewport_device"] = ExpressionConverter.Convert(viewportDevice);
                if (viewportWidth != null)
                    callPayload.Queries["viewport_width"] = ExpressionConverter.Convert(viewportWidth);
                if (viewportHeight != null)
                    callPayload.Queries["viewport_height"] = ExpressionConverter.Convert(viewportHeight);
                if (deviceScaleFactor != null)
                    callPayload.Queries["device_scale_factor"] = ExpressionConverter.Convert(deviceScaleFactor);
                if (viewportMobile != null)
                    callPayload.Queries["viewport_mobile"] = ExpressionConverter.Convert(viewportMobile);
                if (viewportHasTouch != null)
                    callPayload.Queries["viewport_has_touch"] = ExpressionConverter.Convert(viewportHasTouch);
                if (viewportLandscape != null)
                    callPayload.Queries["viewport_landscape"] = ExpressionConverter.Convert(viewportLandscape);
                if (blockCookieBanners != null)
                    callPayload.Queries["block_cookie_banners"] = ExpressionConverter.Convert(blockCookieBanners);
                if (blockBannersByHeuristics != null)
                    callPayload.Queries["block_banners_by_heuristics"] = ExpressionConverter.Convert(blockBannersByHeuristics);
                if (blockChats != null)
                    callPayload.Queries["block_chats"] = ExpressionConverter.Convert(blockChats);
                if (blockAds != null)
                    callPayload.Queries["block_ads"] = ExpressionConverter.Convert(blockAds);
                if (blockTrackers != null)
                    callPayload.Queries["block_trackers"] = ExpressionConverter.Convert(blockTrackers);
                if (blockRequests != null)
                    callPayload.Queries["block_requests"] = ExpressionConverter.Convert(blockRequests);
                if (blockResources != null)
                    callPayload.Queries["block_resources"] = ExpressionConverter.Convert(blockResources);
                if (geolocationLatitude != null)
                    callPayload.Queries["geolocation_latitude"] = ExpressionConverter.Convert(geolocationLatitude);
                if (geolocationLongitude != null)
                    callPayload.Queries["geolocation_longitude"] = ExpressionConverter.Convert(geolocationLongitude);
                if (geolocationAccuracy != null)
                    callPayload.Queries["geolocation_accuracy"] = ExpressionConverter.Convert(geolocationAccuracy);
                callPayload.Queries["ip_country_code"] = Convert.ToString("us");
                if (ipCountryCode != null)
                    callPayload.Queries["ip_country_code"] = ExpressionConverter.Convert(ipCountryCode);
                if (proxy != null)
                    callPayload.Queries["proxy"] = ExpressionConverter.Convert(proxy);
                if (userAgent != null)
                    callPayload.Queries["user_agent"] = ExpressionConverter.Convert(userAgent);
                if (authorization != null)
                    callPayload.Queries["authorization"] = ExpressionConverter.Convert(authorization);
                if (cookies != null)
                    callPayload.Queries["cookies"] = ExpressionConverter.Convert(cookies);
                if (headers != null)
                    callPayload.Queries["headers"] = ExpressionConverter.Convert(headers);
                if (timeZone != null)
                    callPayload.Queries["time_zone"] = ExpressionConverter.Convert(timeZone);
                if (waitUntil != null)
                    callPayload.Queries["wait_until"] = ExpressionConverter.Convert(waitUntil);
                if (delay != null)
                    callPayload.Queries["delay"] = ExpressionConverter.Convert(delay);
                if (timeout != null)
                    callPayload.Queries["timeout"] = ExpressionConverter.Convert(timeout);
                if (navigationTimeout != null)
                    callPayload.Queries["navigation_timeout"] = ExpressionConverter.Convert(navigationTimeout);
                if (waitForSelector != null)
                    callPayload.Queries["wait_for_selector"] = ExpressionConverter.Convert(waitForSelector);
                if (cache != null)
                    callPayload.Queries["cache"] = ExpressionConverter.Convert(cache);
                if (cacheTtl != null)
                    callPayload.Queries["cache_ttl"] = ExpressionConverter.Convert(cacheTtl);
                if (cacheKey != null)
                    callPayload.Queries["cache_key"] = ExpressionConverter.Convert(cacheKey);
                if (store != null)
                    callPayload.Queries["store"] = ExpressionConverter.Convert(store);
                if (storagePath != null)
                    callPayload.Queries["storage_path"] = ExpressionConverter.Convert(storagePath);
                if (storageBucket != null)
                    callPayload.Queries["storage_bucket"] = ExpressionConverter.Convert(storageBucket);
                if (storageClass != null)
                    callPayload.Queries["storage_class"] = ExpressionConverter.Convert(storageClass);
                if (storageAcl != null)
                    callPayload.Queries["storage_acl"] = ExpressionConverter.Convert(storageAcl);
                if (metadataImageSize != null)
                    callPayload.Queries["metadata_image_size"] = ExpressionConverter.Convert(metadataImageSize);
                if (ignoreHostErrors != null)
                    callPayload.Queries["ignore_host_errors"] = ExpressionConverter.Convert(ignoreHostErrors);
                if (errorOnSelectorNotFound != null)
                    callPayload.Queries["error_on_selector_not_found"] = ExpressionConverter.Convert(errorOnSelectorNotFound);
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

    public enum responseTypeInput
    {
        [EnumMember(Value = "by_format")]
        ByFormat,
        [EnumMember(Value = "empty")]
        Empty,
        [EnumMember(Value = "json")]
        Json
    }

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
