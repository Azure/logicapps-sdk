//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Realfavicongenerator
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RealfavicongeneratorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "realfavicongenerator")]
        public IBodyWorkflowAction<FaviconPostResponse> FaviconPost(Expression<Func<string>> bodyfaviconGenerationmasterPicturetype = null, Expression<Func<string>> bodyfaviconGenerationmasterPictureurl = null, Expression<Func<string>> bodyfaviconGenerationfilesLocationtype = null, Expression<Func<string>> bodyfaviconGenerationfilesLocationpath = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigndesktopBrowserpictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigndesktopBrowsermargin = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigndesktopBrowserbackgroundColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPicturetype = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPictureurl = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagebackgroundColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigniospictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigniosmargin = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigniosbackgroundColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigniosstartupImagemasterPicturetype = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigniosstartupImagemasterPictureurl = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigniosstartupImagebackgroundColor = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesigniosassetsios6AndPriorIcons = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesigniosassetsios7AndLaterIcons = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesigniosassetsprecomposedIcons = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesigniosassetsdeclareOnlyDefaultIcon = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignwindowspictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignwindowsbackgroundColor = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignwindowsassetswindows80Ie10Tile = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilessmall = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesmedium = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesbig = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesrectangle = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxApppictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppkeepPictureInCircle = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppcircleInnerMargin = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppbackgroundColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappName = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappDescription = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperName = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperUrl = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromepictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromemanifestname = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromemanifestdisplay = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromemanifestorientation = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromemanifeststartUrl = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromemanifestexistingManifest = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignandroidChromeassetslegacyIcon = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignandroidChromeassetslowResolutionIcons = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromethemeColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignsafariPinnedTabpictureAspect = null, Expression<Func<int>> bodyfaviconGenerationfaviconDesignsafariPinnedTabthreshold = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignsafariPinnedTabthemeColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigncoastpictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigncoastbackgroundColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigncoastmargin = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignopenGraphpictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignopenGraphbackgroundColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignopenGraphmargin = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignopenGraphratio = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignyandexBrowserbackgroundColor = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignyandexBrowsermanifestshowTitle = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignyandexBrowsermanifestversion = null, Expression<Func<string>> bodyfaviconGenerationsettingscompression = null, Expression<Func<string>> bodyfaviconGenerationsettingsscalingAlgorithm = null, Expression<Func<bool>> bodyfaviconGenerationsettingserrorOnImageTooSmall = null, Expression<Func<bool>> bodyfaviconGenerationsettingsreadmeFile = null, Expression<Func<bool>> bodyfaviconGenerationsettingshtmlCodeFile = null, Expression<Func<bool>> bodyfaviconGenerationsettingsusePathAsIs = null, Expression<Func<string>> bodyfaviconGenerationversioningparamName = null, Expression<Func<string>> bodyfaviconGenerationversioningparamValue = null)
        {
            var apiCallPath = "/favicon";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["api_key"] = Convert.ToString("@connectionParameters('key')");
            var body = new JObject();
            var bodypropCount = 0;
            var favicon_generationObject = new JObject();
            var favicon_generationObjectpropCount = 0;
            var master_pictureObject = new JObject();
            var master_pictureObjectpropCount = 0;
            if (bodyfaviconGenerationmasterPicturetype != null)
            {
                master_pictureObject["type"] = ExpressionConverter.ConvertO(bodyfaviconGenerationmasterPicturetype);
                master_pictureObjectpropCount++;
            }

            if (bodyfaviconGenerationmasterPictureurl != null)
            {
                master_pictureObject["url"] = ExpressionConverter.ConvertO(bodyfaviconGenerationmasterPictureurl);
                master_pictureObjectpropCount++;
            }

            if (master_pictureObjectpropCount > 0)
            {
                favicon_generationObject["master_picture"] = master_pictureObject;
                favicon_generationObjectpropCount++;
            }

            var files_locationObject = new JObject();
            var files_locationObjectpropCount = 0;
            if (bodyfaviconGenerationfilesLocationtype != null)
            {
                files_locationObject["type"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfilesLocationtype);
                files_locationObjectpropCount++;
            }

            if (bodyfaviconGenerationfilesLocationpath != null)
            {
                files_locationObject["path"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfilesLocationpath);
                files_locationObjectpropCount++;
            }

            if (files_locationObjectpropCount > 0)
            {
                favicon_generationObject["files_location"] = files_locationObject;
                favicon_generationObjectpropCount++;
            }

            var favicon_designObject = new JObject();
            var favicon_designObjectpropCount = 0;
            var desktop_browserObject = new JObject();
            var desktop_browserObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesigndesktopBrowserpictureAspect != null)
            {
                desktop_browserObject["picture_aspect"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigndesktopBrowserpictureAspect);
                desktop_browserObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesigndesktopBrowsermargin != null)
            {
                desktop_browserObject["margin"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigndesktopBrowsermargin);
                desktop_browserObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesigndesktopBrowserbackgroundColor != null)
            {
                desktop_browserObject["background_color"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigndesktopBrowserbackgroundColor);
                desktop_browserObjectpropCount++;
            }

            var startup_imageObject = new JObject();
            var startup_imageObjectpropCount = 0;
            var master_pictureObject = new JObject();
            var master_pictureObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPicturetype != null)
            {
                master_pictureObject["type"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPicturetype);
                master_pictureObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPictureurl != null)
            {
                master_pictureObject["url"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPictureurl);
                master_pictureObjectpropCount++;
            }

            if (master_pictureObjectpropCount > 0)
            {
                startup_imageObject["master_picture"] = master_pictureObject;
                startup_imageObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagebackgroundColor != null)
            {
                startup_imageObject["background_color"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagebackgroundColor);
                startup_imageObjectpropCount++;
            }

            if (startup_imageObjectpropCount > 0)
            {
                desktop_browserObject["startup_image"] = startup_imageObject;
                desktop_browserObjectpropCount++;
            }

            if (desktop_browserObjectpropCount > 0)
            {
                favicon_designObject["desktop_browser"] = desktop_browserObject;
                favicon_designObjectpropCount++;
            }

            var iosObject = new JObject();
            var iosObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesigniospictureAspect != null)
            {
                iosObject["picture_aspect"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigniospictureAspect);
                iosObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesigniosmargin != null)
            {
                iosObject["margin"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigniosmargin);
                iosObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesigniosbackgroundColor != null)
            {
                iosObject["background_color"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigniosbackgroundColor);
                iosObjectpropCount++;
            }

            var startup_imageObject = new JObject();
            var startup_imageObjectpropCount = 0;
            var master_pictureObject = new JObject();
            var master_pictureObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesigniosstartupImagemasterPicturetype != null)
            {
                master_pictureObject["type"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigniosstartupImagemasterPicturetype);
                master_pictureObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesigniosstartupImagemasterPictureurl != null)
            {
                master_pictureObject["url"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigniosstartupImagemasterPictureurl);
                master_pictureObjectpropCount++;
            }

            if (master_pictureObjectpropCount > 0)
            {
                startup_imageObject["master_picture"] = master_pictureObject;
                startup_imageObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesigniosstartupImagebackgroundColor != null)
            {
                startup_imageObject["background_color"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigniosstartupImagebackgroundColor);
                startup_imageObjectpropCount++;
            }

            if (startup_imageObjectpropCount > 0)
            {
                iosObject["startup_image"] = startup_imageObject;
                iosObjectpropCount++;
            }

            var assetsObject = new JObject();
            var assetsObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesigniosassetsios6AndPriorIcons != null)
            {
                assetsObject["ios6_and_prior_icons"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigniosassetsios6AndPriorIcons);
                assetsObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesigniosassetsios7AndLaterIcons != null)
            {
                assetsObject["ios7_and_later_icons"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigniosassetsios7AndLaterIcons);
                assetsObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesigniosassetsprecomposedIcons != null)
            {
                assetsObject["precomposed_icons"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigniosassetsprecomposedIcons);
                assetsObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesigniosassetsdeclareOnlyDefaultIcon != null)
            {
                assetsObject["declare_only_default_icon"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigniosassetsdeclareOnlyDefaultIcon);
                assetsObjectpropCount++;
            }

            if (assetsObjectpropCount > 0)
            {
                iosObject["assets"] = assetsObject;
                iosObjectpropCount++;
            }

            if (iosObjectpropCount > 0)
            {
                favicon_designObject["ios"] = iosObject;
                favicon_designObjectpropCount++;
            }

            var windowsObject = new JObject();
            var windowsObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesignwindowspictureAspect != null)
            {
                windowsObject["picture_aspect"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignwindowspictureAspect);
                windowsObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignwindowsbackgroundColor != null)
            {
                windowsObject["background_color"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignwindowsbackgroundColor);
                windowsObjectpropCount++;
            }

            var assetsObject = new JObject();
            var assetsObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesignwindowsassetswindows80Ie10Tile != null)
            {
                assetsObject["windows_80_ie_10_tile"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignwindowsassetswindows80Ie10Tile);
                assetsObjectpropCount++;
            }

            var windows_10_ie_11_edge_tilesObject = new JObject();
            var windows_10_ie_11_edge_tilesObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilessmall != null)
            {
                windows_10_ie_11_edge_tilesObject["small"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilessmall);
                windows_10_ie_11_edge_tilesObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesmedium != null)
            {
                windows_10_ie_11_edge_tilesObject["medium"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesmedium);
                windows_10_ie_11_edge_tilesObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesbig != null)
            {
                windows_10_ie_11_edge_tilesObject["big"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesbig);
                windows_10_ie_11_edge_tilesObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesrectangle != null)
            {
                windows_10_ie_11_edge_tilesObject["rectangle"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesrectangle);
                windows_10_ie_11_edge_tilesObjectpropCount++;
            }

            if (windows_10_ie_11_edge_tilesObjectpropCount > 0)
            {
                assetsObject["windows_10_ie_11_edge_tiles"] = windows_10_ie_11_edge_tilesObject;
                assetsObjectpropCount++;
            }

            if (assetsObjectpropCount > 0)
            {
                windowsObject["assets"] = assetsObject;
                windowsObjectpropCount++;
            }

            if (windowsObjectpropCount > 0)
            {
                favicon_designObject["windows"] = windowsObject;
                favicon_designObjectpropCount++;
            }

            var firefox_appObject = new JObject();
            var firefox_appObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesignfirefoxApppictureAspect != null)
            {
                firefox_appObject["picture_aspect"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignfirefoxApppictureAspect);
                firefox_appObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignfirefoxAppkeepPictureInCircle != null)
            {
                firefox_appObject["keep_picture_in_circle"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignfirefoxAppkeepPictureInCircle);
                firefox_appObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignfirefoxAppcircleInnerMargin != null)
            {
                firefox_appObject["circle_inner_margin"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignfirefoxAppcircleInnerMargin);
                firefox_appObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignfirefoxAppbackgroundColor != null)
            {
                firefox_appObject["background_color"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignfirefoxAppbackgroundColor);
                firefox_appObjectpropCount++;
            }

            var manifestObject = new JObject();
            var manifestObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappName != null)
            {
                manifestObject["app_name"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappName);
                manifestObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappDescription != null)
            {
                manifestObject["app_description"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappDescription);
                manifestObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperName != null)
            {
                manifestObject["developer_name"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperName);
                manifestObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperUrl != null)
            {
                manifestObject["developer_url"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperUrl);
                manifestObjectpropCount++;
            }

            if (manifestObjectpropCount > 0)
            {
                firefox_appObject["manifest"] = manifestObject;
                firefox_appObjectpropCount++;
            }

            if (firefox_appObjectpropCount > 0)
            {
                favicon_designObject["firefox_app"] = firefox_appObject;
                favicon_designObjectpropCount++;
            }

            var android_chromeObject = new JObject();
            var android_chromeObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesignandroidChromepictureAspect != null)
            {
                android_chromeObject["picture_aspect"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignandroidChromepictureAspect);
                android_chromeObjectpropCount++;
            }

            var manifestObject = new JObject();
            var manifestObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesignandroidChromemanifestname != null)
            {
                manifestObject["name"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignandroidChromemanifestname);
                manifestObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignandroidChromemanifestdisplay != null)
            {
                manifestObject["display"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignandroidChromemanifestdisplay);
                manifestObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignandroidChromemanifestorientation != null)
            {
                manifestObject["orientation"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignandroidChromemanifestorientation);
                manifestObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignandroidChromemanifeststartUrl != null)
            {
                manifestObject["start_url"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignandroidChromemanifeststartUrl);
                manifestObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignandroidChromemanifestexistingManifest != null)
            {
                manifestObject["existing_manifest"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignandroidChromemanifestexistingManifest);
                manifestObjectpropCount++;
            }

            if (manifestObjectpropCount > 0)
            {
                android_chromeObject["manifest"] = manifestObject;
                android_chromeObjectpropCount++;
            }

            var assetsObject = new JObject();
            var assetsObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesignandroidChromeassetslegacyIcon != null)
            {
                assetsObject["legacy_icon"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignandroidChromeassetslegacyIcon);
                assetsObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignandroidChromeassetslowResolutionIcons != null)
            {
                assetsObject["low_resolution_icons"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignandroidChromeassetslowResolutionIcons);
                assetsObjectpropCount++;
            }

            if (assetsObjectpropCount > 0)
            {
                android_chromeObject["assets"] = assetsObject;
                android_chromeObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignandroidChromethemeColor != null)
            {
                android_chromeObject["theme_color"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignandroidChromethemeColor);
                android_chromeObjectpropCount++;
            }

            if (android_chromeObjectpropCount > 0)
            {
                favicon_designObject["android_chrome"] = android_chromeObject;
                favicon_designObjectpropCount++;
            }

            var safari_pinned_tabObject = new JObject();
            var safari_pinned_tabObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesignsafariPinnedTabpictureAspect != null)
            {
                safari_pinned_tabObject["picture_aspect"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignsafariPinnedTabpictureAspect);
                safari_pinned_tabObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignsafariPinnedTabthreshold != null)
            {
                safari_pinned_tabObject["threshold"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignsafariPinnedTabthreshold);
                safari_pinned_tabObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignsafariPinnedTabthemeColor != null)
            {
                safari_pinned_tabObject["theme_color"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignsafariPinnedTabthemeColor);
                safari_pinned_tabObjectpropCount++;
            }

            if (safari_pinned_tabObjectpropCount > 0)
            {
                favicon_designObject["safari_pinned_tab"] = safari_pinned_tabObject;
                favicon_designObjectpropCount++;
            }

            var coastObject = new JObject();
            var coastObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesigncoastpictureAspect != null)
            {
                coastObject["picture_aspect"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigncoastpictureAspect);
                coastObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesigncoastbackgroundColor != null)
            {
                coastObject["background_color"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigncoastbackgroundColor);
                coastObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesigncoastmargin != null)
            {
                coastObject["margin"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesigncoastmargin);
                coastObjectpropCount++;
            }

            if (coastObjectpropCount > 0)
            {
                favicon_designObject["coast"] = coastObject;
                favicon_designObjectpropCount++;
            }

            var open_graphObject = new JObject();
            var open_graphObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesignopenGraphpictureAspect != null)
            {
                open_graphObject["picture_aspect"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignopenGraphpictureAspect);
                open_graphObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignopenGraphbackgroundColor != null)
            {
                open_graphObject["background_color"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignopenGraphbackgroundColor);
                open_graphObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignopenGraphmargin != null)
            {
                open_graphObject["margin"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignopenGraphmargin);
                open_graphObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignopenGraphratio != null)
            {
                open_graphObject["ratio"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignopenGraphratio);
                open_graphObjectpropCount++;
            }

            if (open_graphObjectpropCount > 0)
            {
                favicon_designObject["open_graph"] = open_graphObject;
                favicon_designObjectpropCount++;
            }

            var yandex_browserObject = new JObject();
            var yandex_browserObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesignyandexBrowserbackgroundColor != null)
            {
                yandex_browserObject["background_color"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignyandexBrowserbackgroundColor);
                yandex_browserObjectpropCount++;
            }

            var manifestObject = new JObject();
            var manifestObjectpropCount = 0;
            if (bodyfaviconGenerationfaviconDesignyandexBrowsermanifestshowTitle != null)
            {
                manifestObject["show_title"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignyandexBrowsermanifestshowTitle);
                manifestObjectpropCount++;
            }

            if (bodyfaviconGenerationfaviconDesignyandexBrowsermanifestversion != null)
            {
                manifestObject["version"] = ExpressionConverter.ConvertO(bodyfaviconGenerationfaviconDesignyandexBrowsermanifestversion);
                manifestObjectpropCount++;
            }

            if (manifestObjectpropCount > 0)
            {
                yandex_browserObject["manifest"] = manifestObject;
                yandex_browserObjectpropCount++;
            }

            if (yandex_browserObjectpropCount > 0)
            {
                favicon_designObject["yandex_browser"] = yandex_browserObject;
                favicon_designObjectpropCount++;
            }

            if (favicon_designObjectpropCount > 0)
            {
                favicon_generationObject["favicon_design"] = favicon_designObject;
                favicon_generationObjectpropCount++;
            }

            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            if (bodyfaviconGenerationsettingscompression != null)
            {
                settingsObject["compression"] = ExpressionConverter.ConvertO(bodyfaviconGenerationsettingscompression);
                settingsObjectpropCount++;
            }

            if (bodyfaviconGenerationsettingsscalingAlgorithm != null)
            {
                settingsObject["scaling_algorithm"] = ExpressionConverter.ConvertO(bodyfaviconGenerationsettingsscalingAlgorithm);
                settingsObjectpropCount++;
            }

            if (bodyfaviconGenerationsettingserrorOnImageTooSmall != null)
            {
                settingsObject["error_on_image_too_small"] = ExpressionConverter.ConvertO(bodyfaviconGenerationsettingserrorOnImageTooSmall);
                settingsObjectpropCount++;
            }

            if (bodyfaviconGenerationsettingsreadmeFile != null)
            {
                settingsObject["readme_file"] = ExpressionConverter.ConvertO(bodyfaviconGenerationsettingsreadmeFile);
                settingsObjectpropCount++;
            }

            if (bodyfaviconGenerationsettingshtmlCodeFile != null)
            {
                settingsObject["html_code_file"] = ExpressionConverter.ConvertO(bodyfaviconGenerationsettingshtmlCodeFile);
                settingsObjectpropCount++;
            }

            if (bodyfaviconGenerationsettingsusePathAsIs != null)
            {
                settingsObject["use_path_as_is"] = ExpressionConverter.ConvertO(bodyfaviconGenerationsettingsusePathAsIs);
                settingsObjectpropCount++;
            }

            if (settingsObjectpropCount > 0)
            {
                favicon_generationObject["settings"] = settingsObject;
                favicon_generationObjectpropCount++;
            }

            var versioningObject = new JObject();
            var versioningObjectpropCount = 0;
            if (bodyfaviconGenerationversioningparamName != null)
            {
                versioningObject["param_name"] = ExpressionConverter.ConvertO(bodyfaviconGenerationversioningparamName);
                versioningObjectpropCount++;
            }

            if (bodyfaviconGenerationversioningparamValue != null)
            {
                versioningObject["param_value"] = ExpressionConverter.ConvertO(bodyfaviconGenerationversioningparamValue);
                versioningObjectpropCount++;
            }

            if (versioningObjectpropCount > 0)
            {
                favicon_generationObject["versioning"] = versioningObject;
                favicon_generationObjectpropCount++;
            }

            if (favicon_generationObjectpropCount > 0)
            {
                body["favicon_generation"] = favicon_generationObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FaviconPostResponse>(callPayload);
        }
    }

    public class RealfavicongeneratorTriggers([ConnectionName] string connectionId)
    {
    }

    public class FaviconPostResponse
    {
        [JsonProperty("favicon_generation_result")]
        public FaviconPostResponseFaviconGenerationResultType FaviconGenerationResult { get; set; }
    }

    public class FaviconPostResponseFaviconGenerationResultType
    {
        [JsonProperty("result")]
        public FaviconPostResponseFaviconGenerationResultTypeResultType Result { get; set; }

        [JsonProperty("favicon")]
        public FaviconPostResponseFaviconGenerationResultTypeFaviconType Favicon { get; set; }

        [JsonProperty("files_location")]
        public FaviconPostResponseFaviconGenerationResultTypeFilesLocationType FilesLocation { get; set; }

        [JsonProperty("preview_picture_url")]
        public string PreviewPictureUrl { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class FaviconPostResponseFaviconGenerationResultTypeResultType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class FaviconPostResponseFaviconGenerationResultTypeFaviconType
    {
        [JsonProperty("package_url")]
        public string PackageUrl { get; set; }

        [JsonProperty("files_urls")]
        public string[] FilesUrls { get; set; }

        [JsonProperty("html_code")]
        public string HtmlCode { get; set; }

        [JsonProperty("compression")]
        public string Compression { get; set; }

        [JsonProperty("overlapping_markups")]
        public string[] OverlappingMarkups { get; set; }
    }

    public class FaviconPostResponseFaviconGenerationResultTypeFilesLocationType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Realfavicongenerator;

    public partial class WorkflowManagedActions
    {
        public RealfavicongeneratorActions Realfavicongenerator(string connectionId) => new RealfavicongeneratorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RealfavicongeneratorTriggers Realfavicongenerator(string connectionId) => new RealfavicongeneratorTriggers(connectionId);
    }
}