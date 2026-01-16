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
        public IBodyWorkflowAction<TakeGetResponse> TakeGet(Expression<Func<string>> url = null, Expression<Func<string>> html = null, Expression<Func<formatInput>> format = null, Expression<Func<responseTypeInput>> responseType = null, Expression<Func<string>> selector = null, Expression<Func<bool>> captureBeyondViewport = null, Expression<Func<string>> scrollIntoView = null, Expression<Func<int>> scrollIntoViewAdjustTop = null, Expression<Func<bool>> fullPage = null, Expression<Func<bool>> fullPageScroll = null, Expression<Func<int>> fullPageScrollDelay = null, Expression<Func<int>> fullPageScrollBy = null, Expression<Func<int>> fullPageMaxHeight = null, Expression<Func<string>> viewportDevice = null, Expression<Func<int>> viewportWidth = null, Expression<Func<int>> viewportHeight = null, Expression<Func<int>> deviceScaleFactor = null, Expression<Func<bool>> viewportMobile = null, Expression<Func<bool>> viewportHasTouch = null, Expression<Func<bool>> viewportLandscape = null, Expression<Func<int>> imageQuality = null, Expression<Func<int>> imageWidth = null, Expression<Func<int>> imageHeight = null, Expression<Func<bool>> omitBackground = null, Expression<Func<bool>> darkMode = null, Expression<Func<bool>> reducedMotion = null, Expression<Func<string>> mediaType = null, Expression<Func<string>> hideSelectors = null, Expression<Func<string>> scripts = null, Expression<Func<string>> scriptsWaitUntil = null, Expression<Func<string>> styles = null, Expression<Func<string>> click = null, Expression<Func<bool>> blockCookieBanners = null, Expression<Func<bool>> blockBannersByHeuristics = null, Expression<Func<bool>> blockChats = null, Expression<Func<bool>> blockAds = null, Expression<Func<bool>> blockTrackers = null, Expression<Func<string>> blockRequests = null, Expression<Func<string>> blockResources = null, Expression<Func<double>> geolocationLatitude = null, Expression<Func<double>> geolocationLongitude = null, Expression<Func<int>> geolocationAccuracy = null, Expression<Func<ipCountryCodeInput>> ipCountryCode = null, Expression<Func<string>> proxy = null, Expression<Func<string>> userAgent = null, Expression<Func<string>> authorization = null, Expression<Func<string>> cookies = null, Expression<Func<string>> headers = null, Expression<Func<timeZoneInput>> timeZone = null, Expression<Func<string>> waitUntil = null, Expression<Func<int>> delay = null, Expression<Func<int>> timeout = null, Expression<Func<int>> navigationTimeout = null, Expression<Func<string>> waitForSelector = null, Expression<Func<bool>> cache = null, Expression<Func<int>> cacheTtl = null, Expression<Func<int>> cacheKey = null, Expression<Func<bool>> store = null, Expression<Func<string>> storagePath = null, Expression<Func<string>> storageBucket = null, Expression<Func<storageClassInput>> storageClass = null, Expression<Func<string>> storageAcl = null, Expression<Func<bool>> metadataImageSize = null, Expression<Func<bool>> ignoreHostErrors = null, Expression<Func<bool>> errorOnSelectorNotFound = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "screenshotoneip")]
        public IBodyWorkflowAction<TakeAnimatedGetResponse> TakeAnimatedGet(Expression<Func<string>> url = null, Expression<Func<string>> scenario = null, Expression<Func<int>> scrollDelay = null, Expression<Func<int>> scrollDuration = null, Expression<Func<int>> scrollBy = null, Expression<Func<bool>> scrollStartImmediately = null, Expression<Func<bool>> scrollBack = null, Expression<Func<int>> scrollBackAfterDuration = null, Expression<Func<bool>> scrollComplete = null, Expression<Func<int>> scrollStopAfterDuration = null, Expression<Func<scrollEasingInput>> scrollEasing = null, Expression<Func<formatInput>> format = null, Expression<Func<int>> duration = null, Expression<Func<int>> width = null, Expression<Func<int>> height = null, Expression<Func<string>> aspectRatio = null, Expression<Func<string>> viewportDevice = null, Expression<Func<int>> viewportWidth = null, Expression<Func<int>> viewportHeight = null, Expression<Func<int>> deviceScaleFactor = null, Expression<Func<bool>> viewportMobile = null, Expression<Func<bool>> viewportHasTouch = null, Expression<Func<bool>> viewportLandscape = null, Expression<Func<bool>> blockCookieBanners = null, Expression<Func<bool>> blockBannersByHeuristics = null, Expression<Func<bool>> blockChats = null, Expression<Func<bool>> blockAds = null, Expression<Func<bool>> blockTrackers = null, Expression<Func<string>> blockRequests = null, Expression<Func<string>> blockResources = null, Expression<Func<double>> geolocationLatitude = null, Expression<Func<double>> geolocationLongitude = null, Expression<Func<int>> geolocationAccuracy = null, Expression<Func<ipCountryCodeInput>> ipCountryCode = null, Expression<Func<string>> proxy = null, Expression<Func<string>> userAgent = null, Expression<Func<string>> authorization = null, Expression<Func<string>> cookies = null, Expression<Func<string>> headers = null, Expression<Func<timeZoneInput>> timeZone = null, Expression<Func<string>> waitUntil = null, Expression<Func<int>> delay = null, Expression<Func<int>> timeout = null, Expression<Func<int>> navigationTimeout = null, Expression<Func<string>> waitForSelector = null, Expression<Func<bool>> cache = null, Expression<Func<int>> cacheTtl = null, Expression<Func<int>> cacheKey = null, Expression<Func<bool>> store = null, Expression<Func<string>> storagePath = null, Expression<Func<string>> storageBucket = null, Expression<Func<storageClassInput>> storageClass = null, Expression<Func<string>> storageAcl = null, Expression<Func<bool>> metadataImageSize = null, Expression<Func<bool>> ignoreHostErrors = null, Expression<Func<bool>> errorOnSelectorNotFound = null)
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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