//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Screenshotoneip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ScreenshotoneipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "screenshotoneip")]
        public IBodyWorkflowAction<TakeGetResponse> TakeGet([WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<string> html = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<responseTypeInput> responseType = null, [WorkflowExpression] Func<string> selector = null, [WorkflowExpression] Func<bool> captureBeyondViewport = null, [WorkflowExpression] Func<string> scrollIntoView = null, [WorkflowExpression] Func<int> scrollIntoViewAdjustTop = null, [WorkflowExpression] Func<bool> fullPage = null, [WorkflowExpression] Func<bool> fullPageScroll = null, [WorkflowExpression] Func<int> fullPageScrollDelay = null, [WorkflowExpression] Func<int> fullPageScrollBy = null, [WorkflowExpression] Func<int> fullPageMaxHeight = null, [WorkflowExpression] Func<string> viewportDevice = null, [WorkflowExpression] Func<int> viewportWidth = null, [WorkflowExpression] Func<int> viewportHeight = null, [WorkflowExpression] Func<int> deviceScaleFactor = null, [WorkflowExpression] Func<bool> viewportMobile = null, [WorkflowExpression] Func<bool> viewportHasTouch = null, [WorkflowExpression] Func<bool> viewportLandscape = null, [WorkflowExpression] Func<int> imageQuality = null, [WorkflowExpression] Func<int> imageWidth = null, [WorkflowExpression] Func<int> imageHeight = null, [WorkflowExpression] Func<bool> omitBackground = null, [WorkflowExpression] Func<bool> darkMode = null, [WorkflowExpression] Func<bool> reducedMotion = null, [WorkflowExpression] Func<string> mediaType = null, [WorkflowExpression] Func<string> hideSelectors = null, [WorkflowExpression] Func<string> scripts = null, [WorkflowExpression] Func<string> scriptsWaitUntil = null, [WorkflowExpression] Func<string> styles = null, [WorkflowExpression] Func<string> click = null, [WorkflowExpression] Func<bool> blockCookieBanners = null, [WorkflowExpression] Func<bool> blockBannersByHeuristics = null, [WorkflowExpression] Func<bool> blockChats = null, [WorkflowExpression] Func<bool> blockAds = null, [WorkflowExpression] Func<bool> blockTrackers = null, [WorkflowExpression] Func<string> blockRequests = null, [WorkflowExpression] Func<string> blockResources = null, [WorkflowExpression] Func<double> geolocationLatitude = null, [WorkflowExpression] Func<double> geolocationLongitude = null, [WorkflowExpression] Func<int> geolocationAccuracy = null, [WorkflowExpression] Func<ipCountryCodeInput> ipCountryCode = null, [WorkflowExpression] Func<string> proxy = null, [WorkflowExpression] Func<string> userAgent = null, [WorkflowExpression] Func<string> authorization = null, [WorkflowExpression] Func<string> cookies = null, [WorkflowExpression] Func<string> headers = null, [WorkflowExpression] Func<timeZoneInput> timeZone = null, [WorkflowExpression] Func<string> waitUntil = null, [WorkflowExpression] Func<int> delay = null, [WorkflowExpression] Func<int> timeout = null, [WorkflowExpression] Func<int> navigationTimeout = null, [WorkflowExpression] Func<string> waitForSelector = null, [WorkflowExpression] Func<bool> cache = null, [WorkflowExpression] Func<int> cacheTtl = null, [WorkflowExpression] Func<int> cacheKey = null, [WorkflowExpression] Func<bool> store = null, [WorkflowExpression] Func<string> storagePath = null, [WorkflowExpression] Func<string> storageBucket = null, [WorkflowExpression] Func<storageClassInput> storageClass = null, [WorkflowExpression] Func<string> storageAcl = null, [WorkflowExpression] Func<bool> metadataImageSize = null, [WorkflowExpression] Func<bool> ignoreHostErrors = null, [WorkflowExpression] Func<bool> errorOnSelectorNotFound = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/take";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (url != null)
                    callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                if (html != null)
                    callPayload.Queries["html"] = SourceExpressionConverter.ConvertO(html);
                callPayload.Queries["format"] = Convert.ToString("jpg");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Queries["response_type"] = Convert.ToString("by_format");
                if (responseType != null)
                    callPayload.Queries["response_type"] = SourceExpressionConverter.Convert(responseType);
                if (selector != null)
                    callPayload.Queries["selector"] = SourceExpressionConverter.ConvertO(selector);
                if (captureBeyondViewport != null)
                    callPayload.Queries["capture_beyond_viewport"] = SourceExpressionConverter.ConvertO(captureBeyondViewport);
                if (scrollIntoView != null)
                    callPayload.Queries["scroll_into_view"] = SourceExpressionConverter.ConvertO(scrollIntoView);
                if (scrollIntoViewAdjustTop != null)
                    callPayload.Queries["scroll_into_view_adjust_top"] = SourceExpressionConverter.ConvertO(scrollIntoViewAdjustTop);
                if (fullPage != null)
                    callPayload.Queries["full_page"] = SourceExpressionConverter.ConvertO(fullPage);
                if (fullPageScroll != null)
                    callPayload.Queries["full_page_scroll"] = SourceExpressionConverter.ConvertO(fullPageScroll);
                if (fullPageScrollDelay != null)
                    callPayload.Queries["full_page_scroll_delay"] = SourceExpressionConverter.ConvertO(fullPageScrollDelay);
                if (fullPageScrollBy != null)
                    callPayload.Queries["full_page_scroll_by"] = SourceExpressionConverter.ConvertO(fullPageScrollBy);
                if (fullPageMaxHeight != null)
                    callPayload.Queries["full_page_max_height"] = SourceExpressionConverter.ConvertO(fullPageMaxHeight);
                if (viewportDevice != null)
                    callPayload.Queries["viewport_device"] = SourceExpressionConverter.ConvertO(viewportDevice);
                if (viewportWidth != null)
                    callPayload.Queries["viewport_width"] = SourceExpressionConverter.ConvertO(viewportWidth);
                if (viewportHeight != null)
                    callPayload.Queries["viewport_height"] = SourceExpressionConverter.ConvertO(viewportHeight);
                if (deviceScaleFactor != null)
                    callPayload.Queries["device_scale_factor"] = SourceExpressionConverter.ConvertO(deviceScaleFactor);
                if (viewportMobile != null)
                    callPayload.Queries["viewport_mobile"] = SourceExpressionConverter.ConvertO(viewportMobile);
                if (viewportHasTouch != null)
                    callPayload.Queries["viewport_has_touch"] = SourceExpressionConverter.ConvertO(viewportHasTouch);
                if (viewportLandscape != null)
                    callPayload.Queries["viewport_landscape"] = SourceExpressionConverter.ConvertO(viewportLandscape);
                if (imageQuality != null)
                    callPayload.Queries["image_quality"] = SourceExpressionConverter.ConvertO(imageQuality);
                if (imageWidth != null)
                    callPayload.Queries["image_width"] = SourceExpressionConverter.ConvertO(imageWidth);
                if (imageHeight != null)
                    callPayload.Queries["image_height"] = SourceExpressionConverter.ConvertO(imageHeight);
                if (omitBackground != null)
                    callPayload.Queries["omit_background"] = SourceExpressionConverter.ConvertO(omitBackground);
                if (darkMode != null)
                    callPayload.Queries["dark_mode"] = SourceExpressionConverter.ConvertO(darkMode);
                if (reducedMotion != null)
                    callPayload.Queries["reduced_motion"] = SourceExpressionConverter.ConvertO(reducedMotion);
                if (mediaType != null)
                    callPayload.Queries["media_type"] = SourceExpressionConverter.ConvertO(mediaType);
                if (hideSelectors != null)
                    callPayload.Queries["hide_selectors"] = SourceExpressionConverter.ConvertO(hideSelectors);
                if (scripts != null)
                    callPayload.Queries["scripts"] = SourceExpressionConverter.ConvertO(scripts);
                if (scriptsWaitUntil != null)
                    callPayload.Queries["scripts_wait_until"] = SourceExpressionConverter.ConvertO(scriptsWaitUntil);
                if (styles != null)
                    callPayload.Queries["styles"] = SourceExpressionConverter.ConvertO(styles);
                if (click != null)
                    callPayload.Queries["click"] = SourceExpressionConverter.ConvertO(click);
                if (blockCookieBanners != null)
                    callPayload.Queries["block_cookie_banners"] = SourceExpressionConverter.ConvertO(blockCookieBanners);
                if (blockBannersByHeuristics != null)
                    callPayload.Queries["block_banners_by_heuristics"] = SourceExpressionConverter.ConvertO(blockBannersByHeuristics);
                if (blockChats != null)
                    callPayload.Queries["block_chats"] = SourceExpressionConverter.ConvertO(blockChats);
                if (blockAds != null)
                    callPayload.Queries["block_ads"] = SourceExpressionConverter.ConvertO(blockAds);
                if (blockTrackers != null)
                    callPayload.Queries["block_trackers"] = SourceExpressionConverter.ConvertO(blockTrackers);
                if (blockRequests != null)
                    callPayload.Queries["block_requests"] = SourceExpressionConverter.ConvertO(blockRequests);
                if (blockResources != null)
                    callPayload.Queries["block_resources"] = SourceExpressionConverter.ConvertO(blockResources);
                if (geolocationLatitude != null)
                    callPayload.Queries["geolocation_latitude"] = SourceExpressionConverter.ConvertO(geolocationLatitude);
                if (geolocationLongitude != null)
                    callPayload.Queries["geolocation_longitude"] = SourceExpressionConverter.ConvertO(geolocationLongitude);
                if (geolocationAccuracy != null)
                    callPayload.Queries["geolocation_accuracy"] = SourceExpressionConverter.ConvertO(geolocationAccuracy);
                callPayload.Queries["ip_country_code"] = Convert.ToString("us");
                if (ipCountryCode != null)
                    callPayload.Queries["ip_country_code"] = SourceExpressionConverter.Convert(ipCountryCode);
                if (proxy != null)
                    callPayload.Queries["proxy"] = SourceExpressionConverter.ConvertO(proxy);
                if (userAgent != null)
                    callPayload.Queries["user_agent"] = SourceExpressionConverter.ConvertO(userAgent);
                if (authorization != null)
                    callPayload.Queries["authorization"] = SourceExpressionConverter.ConvertO(authorization);
                if (cookies != null)
                    callPayload.Queries["cookies"] = SourceExpressionConverter.ConvertO(cookies);
                if (headers != null)
                    callPayload.Queries["headers"] = SourceExpressionConverter.ConvertO(headers);
                if (timeZone != null)
                    callPayload.Queries["time_zone"] = SourceExpressionConverter.Convert(timeZone);
                if (waitUntil != null)
                    callPayload.Queries["wait_until"] = SourceExpressionConverter.ConvertO(waitUntil);
                if (delay != null)
                    callPayload.Queries["delay"] = SourceExpressionConverter.ConvertO(delay);
                if (timeout != null)
                    callPayload.Queries["timeout"] = SourceExpressionConverter.ConvertO(timeout);
                if (navigationTimeout != null)
                    callPayload.Queries["navigation_timeout"] = SourceExpressionConverter.ConvertO(navigationTimeout);
                if (waitForSelector != null)
                    callPayload.Queries["wait_for_selector"] = SourceExpressionConverter.ConvertO(waitForSelector);
                if (cache != null)
                    callPayload.Queries["cache"] = SourceExpressionConverter.ConvertO(cache);
                if (cacheTtl != null)
                    callPayload.Queries["cache_ttl"] = SourceExpressionConverter.ConvertO(cacheTtl);
                if (cacheKey != null)
                    callPayload.Queries["cache_key"] = SourceExpressionConverter.ConvertO(cacheKey);
                if (store != null)
                    callPayload.Queries["store"] = SourceExpressionConverter.ConvertO(store);
                if (storagePath != null)
                    callPayload.Queries["storage_path"] = SourceExpressionConverter.ConvertO(storagePath);
                if (storageBucket != null)
                    callPayload.Queries["storage_bucket"] = SourceExpressionConverter.ConvertO(storageBucket);
                if (storageClass != null)
                    callPayload.Queries["storage_class"] = SourceExpressionConverter.Convert(storageClass);
                if (storageAcl != null)
                    callPayload.Queries["storage_acl"] = SourceExpressionConverter.ConvertO(storageAcl);
                if (metadataImageSize != null)
                    callPayload.Queries["metadata_image_size"] = SourceExpressionConverter.ConvertO(metadataImageSize);
                if (ignoreHostErrors != null)
                    callPayload.Queries["ignore_host_errors"] = SourceExpressionConverter.ConvertO(ignoreHostErrors);
                if (errorOnSelectorNotFound != null)
                    callPayload.Queries["error_on_selector_not_found"] = SourceExpressionConverter.ConvertO(errorOnSelectorNotFound);
                return callPayload;
            }

            return new ApiConnectionAction<TakeGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "screenshotoneip")]
        public IBodyWorkflowAction<TakeAnimatedGetResponse> TakeAnimatedGet([WorkflowExpression] Func<string> url = null, [WorkflowExpression] Func<string> scenario = null, [WorkflowExpression] Func<int> scrollDelay = null, [WorkflowExpression] Func<int> scrollDuration = null, [WorkflowExpression] Func<int> scrollBy = null, [WorkflowExpression] Func<bool> scrollStartImmediately = null, [WorkflowExpression] Func<bool> scrollBack = null, [WorkflowExpression] Func<int> scrollBackAfterDuration = null, [WorkflowExpression] Func<bool> scrollComplete = null, [WorkflowExpression] Func<int> scrollStopAfterDuration = null, [WorkflowExpression] Func<scrollEasingInput> scrollEasing = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<int> duration = null, [WorkflowExpression] Func<int> width = null, [WorkflowExpression] Func<int> height = null, [WorkflowExpression] Func<string> aspectRatio = null, [WorkflowExpression] Func<string> viewportDevice = null, [WorkflowExpression] Func<int> viewportWidth = null, [WorkflowExpression] Func<int> viewportHeight = null, [WorkflowExpression] Func<int> deviceScaleFactor = null, [WorkflowExpression] Func<bool> viewportMobile = null, [WorkflowExpression] Func<bool> viewportHasTouch = null, [WorkflowExpression] Func<bool> viewportLandscape = null, [WorkflowExpression] Func<bool> blockCookieBanners = null, [WorkflowExpression] Func<bool> blockBannersByHeuristics = null, [WorkflowExpression] Func<bool> blockChats = null, [WorkflowExpression] Func<bool> blockAds = null, [WorkflowExpression] Func<bool> blockTrackers = null, [WorkflowExpression] Func<string> blockRequests = null, [WorkflowExpression] Func<string> blockResources = null, [WorkflowExpression] Func<double> geolocationLatitude = null, [WorkflowExpression] Func<double> geolocationLongitude = null, [WorkflowExpression] Func<int> geolocationAccuracy = null, [WorkflowExpression] Func<ipCountryCodeInput> ipCountryCode = null, [WorkflowExpression] Func<string> proxy = null, [WorkflowExpression] Func<string> userAgent = null, [WorkflowExpression] Func<string> authorization = null, [WorkflowExpression] Func<string> cookies = null, [WorkflowExpression] Func<string> headers = null, [WorkflowExpression] Func<timeZoneInput> timeZone = null, [WorkflowExpression] Func<string> waitUntil = null, [WorkflowExpression] Func<int> delay = null, [WorkflowExpression] Func<int> timeout = null, [WorkflowExpression] Func<int> navigationTimeout = null, [WorkflowExpression] Func<string> waitForSelector = null, [WorkflowExpression] Func<bool> cache = null, [WorkflowExpression] Func<int> cacheTtl = null, [WorkflowExpression] Func<int> cacheKey = null, [WorkflowExpression] Func<bool> store = null, [WorkflowExpression] Func<string> storagePath = null, [WorkflowExpression] Func<string> storageBucket = null, [WorkflowExpression] Func<storageClassInput> storageClass = null, [WorkflowExpression] Func<string> storageAcl = null, [WorkflowExpression] Func<bool> metadataImageSize = null, [WorkflowExpression] Func<bool> ignoreHostErrors = null, [WorkflowExpression] Func<bool> errorOnSelectorNotFound = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/animate";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (url != null)
                    callPayload.Queries["url"] = SourceExpressionConverter.ConvertO(url);
                if (scenario != null)
                    callPayload.Queries["scenario"] = SourceExpressionConverter.ConvertO(scenario);
                if (scrollDelay != null)
                    callPayload.Queries["scroll_delay"] = SourceExpressionConverter.ConvertO(scrollDelay);
                if (scrollDuration != null)
                    callPayload.Queries["scroll_duration"] = SourceExpressionConverter.ConvertO(scrollDuration);
                if (scrollBy != null)
                    callPayload.Queries["scroll_by"] = SourceExpressionConverter.ConvertO(scrollBy);
                if (scrollStartImmediately != null)
                    callPayload.Queries["scroll_start_immediately"] = SourceExpressionConverter.ConvertO(scrollStartImmediately);
                if (scrollBack != null)
                    callPayload.Queries["scroll_back"] = SourceExpressionConverter.ConvertO(scrollBack);
                if (scrollBackAfterDuration != null)
                    callPayload.Queries["scroll_back_after_duration"] = SourceExpressionConverter.ConvertO(scrollBackAfterDuration);
                if (scrollComplete != null)
                    callPayload.Queries["scroll_complete"] = SourceExpressionConverter.ConvertO(scrollComplete);
                if (scrollStopAfterDuration != null)
                    callPayload.Queries["scroll_stop_after_duration"] = SourceExpressionConverter.ConvertO(scrollStopAfterDuration);
                if (scrollEasing != null)
                    callPayload.Queries["scroll_easing"] = SourceExpressionConverter.Convert(scrollEasing);
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (duration != null)
                    callPayload.Queries["duration"] = SourceExpressionConverter.ConvertO(duration);
                if (width != null)
                    callPayload.Queries["width"] = SourceExpressionConverter.ConvertO(width);
                if (height != null)
                    callPayload.Queries["height"] = SourceExpressionConverter.ConvertO(height);
                if (aspectRatio != null)
                    callPayload.Queries["aspect_ratio"] = SourceExpressionConverter.ConvertO(aspectRatio);
                if (viewportDevice != null)
                    callPayload.Queries["viewport_device"] = SourceExpressionConverter.ConvertO(viewportDevice);
                if (viewportWidth != null)
                    callPayload.Queries["viewport_width"] = SourceExpressionConverter.ConvertO(viewportWidth);
                if (viewportHeight != null)
                    callPayload.Queries["viewport_height"] = SourceExpressionConverter.ConvertO(viewportHeight);
                if (deviceScaleFactor != null)
                    callPayload.Queries["device_scale_factor"] = SourceExpressionConverter.ConvertO(deviceScaleFactor);
                if (viewportMobile != null)
                    callPayload.Queries["viewport_mobile"] = SourceExpressionConverter.ConvertO(viewportMobile);
                if (viewportHasTouch != null)
                    callPayload.Queries["viewport_has_touch"] = SourceExpressionConverter.ConvertO(viewportHasTouch);
                if (viewportLandscape != null)
                    callPayload.Queries["viewport_landscape"] = SourceExpressionConverter.ConvertO(viewportLandscape);
                if (blockCookieBanners != null)
                    callPayload.Queries["block_cookie_banners"] = SourceExpressionConverter.ConvertO(blockCookieBanners);
                if (blockBannersByHeuristics != null)
                    callPayload.Queries["block_banners_by_heuristics"] = SourceExpressionConverter.ConvertO(blockBannersByHeuristics);
                if (blockChats != null)
                    callPayload.Queries["block_chats"] = SourceExpressionConverter.ConvertO(blockChats);
                if (blockAds != null)
                    callPayload.Queries["block_ads"] = SourceExpressionConverter.ConvertO(blockAds);
                if (blockTrackers != null)
                    callPayload.Queries["block_trackers"] = SourceExpressionConverter.ConvertO(blockTrackers);
                if (blockRequests != null)
                    callPayload.Queries["block_requests"] = SourceExpressionConverter.ConvertO(blockRequests);
                if (blockResources != null)
                    callPayload.Queries["block_resources"] = SourceExpressionConverter.ConvertO(blockResources);
                if (geolocationLatitude != null)
                    callPayload.Queries["geolocation_latitude"] = SourceExpressionConverter.ConvertO(geolocationLatitude);
                if (geolocationLongitude != null)
                    callPayload.Queries["geolocation_longitude"] = SourceExpressionConverter.ConvertO(geolocationLongitude);
                if (geolocationAccuracy != null)
                    callPayload.Queries["geolocation_accuracy"] = SourceExpressionConverter.ConvertO(geolocationAccuracy);
                callPayload.Queries["ip_country_code"] = Convert.ToString("us");
                if (ipCountryCode != null)
                    callPayload.Queries["ip_country_code"] = SourceExpressionConverter.Convert(ipCountryCode);
                if (proxy != null)
                    callPayload.Queries["proxy"] = SourceExpressionConverter.ConvertO(proxy);
                if (userAgent != null)
                    callPayload.Queries["user_agent"] = SourceExpressionConverter.ConvertO(userAgent);
                if (authorization != null)
                    callPayload.Queries["authorization"] = SourceExpressionConverter.ConvertO(authorization);
                if (cookies != null)
                    callPayload.Queries["cookies"] = SourceExpressionConverter.ConvertO(cookies);
                if (headers != null)
                    callPayload.Queries["headers"] = SourceExpressionConverter.ConvertO(headers);
                if (timeZone != null)
                    callPayload.Queries["time_zone"] = SourceExpressionConverter.Convert(timeZone);
                if (waitUntil != null)
                    callPayload.Queries["wait_until"] = SourceExpressionConverter.ConvertO(waitUntil);
                if (delay != null)
                    callPayload.Queries["delay"] = SourceExpressionConverter.ConvertO(delay);
                if (timeout != null)
                    callPayload.Queries["timeout"] = SourceExpressionConverter.ConvertO(timeout);
                if (navigationTimeout != null)
                    callPayload.Queries["navigation_timeout"] = SourceExpressionConverter.ConvertO(navigationTimeout);
                if (waitForSelector != null)
                    callPayload.Queries["wait_for_selector"] = SourceExpressionConverter.ConvertO(waitForSelector);
                if (cache != null)
                    callPayload.Queries["cache"] = SourceExpressionConverter.ConvertO(cache);
                if (cacheTtl != null)
                    callPayload.Queries["cache_ttl"] = SourceExpressionConverter.ConvertO(cacheTtl);
                if (cacheKey != null)
                    callPayload.Queries["cache_key"] = SourceExpressionConverter.ConvertO(cacheKey);
                if (store != null)
                    callPayload.Queries["store"] = SourceExpressionConverter.ConvertO(store);
                if (storagePath != null)
                    callPayload.Queries["storage_path"] = SourceExpressionConverter.ConvertO(storagePath);
                if (storageBucket != null)
                    callPayload.Queries["storage_bucket"] = SourceExpressionConverter.ConvertO(storageBucket);
                if (storageClass != null)
                    callPayload.Queries["storage_class"] = SourceExpressionConverter.Convert(storageClass);
                if (storageAcl != null)
                    callPayload.Queries["storage_acl"] = SourceExpressionConverter.ConvertO(storageAcl);
                if (metadataImageSize != null)
                    callPayload.Queries["metadata_image_size"] = SourceExpressionConverter.ConvertO(metadataImageSize);
                if (ignoreHostErrors != null)
                    callPayload.Queries["ignore_host_errors"] = SourceExpressionConverter.ConvertO(ignoreHostErrors);
                if (errorOnSelectorNotFound != null)
                    callPayload.Queries["error_on_selector_not_found"] = SourceExpressionConverter.ConvertO(errorOnSelectorNotFound);
                return callPayload;
            }

            return new ApiConnectionAction<TakeAnimatedGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "screenshotoneip")]
        public IBodyWorkflowAction<DeviceGetResponseItem[]> DeviceGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/devices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DeviceGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "screenshotoneip")]
        public IBodyWorkflowAction<UsageGetResponse> UsageGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/usage";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UsageGetResponse>(BuildSourceInput);
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