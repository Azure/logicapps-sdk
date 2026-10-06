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
        public IBodyWorkflowAction<FaviconPostResponse> Favicon([WorkflowExpression] Func<string> bodyfaviconGenerationmasterPicturetype = null, [WorkflowExpression] Func<string> bodyfaviconGenerationmasterPictureurl = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfilesLocationtype = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfilesLocationpath = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigndesktopBrowserpictureAspect = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigndesktopBrowsermargin = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigndesktopBrowserbackgroundColor = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPicturetype = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPictureurl = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagebackgroundColor = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigniospictureAspect = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigniosmargin = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigniosbackgroundColor = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigniosstartupImagemasterPicturetype = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigniosstartupImagemasterPictureurl = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigniosstartupImagebackgroundColor = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationfaviconDesigniosassetsios6AndPriorIcons = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationfaviconDesigniosassetsios7AndLaterIcons = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationfaviconDesigniosassetsprecomposedIcons = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationfaviconDesigniosassetsdeclareOnlyDefaultIcon = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignwindowspictureAspect = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignwindowsbackgroundColor = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationfaviconDesignwindowsassetswindows80Ie10Tile = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilessmall = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesmedium = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesbig = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesrectangle = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignfirefoxApppictureAspect = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignfirefoxAppkeepPictureInCircle = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignfirefoxAppcircleInnerMargin = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignfirefoxAppbackgroundColor = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappName = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappDescription = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperName = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperUrl = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignandroidChromepictureAspect = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignandroidChromemanifestname = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignandroidChromemanifestdisplay = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignandroidChromemanifestorientation = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignandroidChromemanifeststartUrl = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignandroidChromemanifestexistingManifest = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationfaviconDesignandroidChromeassetslegacyIcon = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationfaviconDesignandroidChromeassetslowResolutionIcons = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignandroidChromethemeColor = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignsafariPinnedTabpictureAspect = null, [WorkflowExpression] Func<int> bodyfaviconGenerationfaviconDesignsafariPinnedTabthreshold = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignsafariPinnedTabthemeColor = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigncoastpictureAspect = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigncoastbackgroundColor = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesigncoastmargin = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignopenGraphpictureAspect = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignopenGraphbackgroundColor = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignopenGraphmargin = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignopenGraphratio = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignyandexBrowserbackgroundColor = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationfaviconDesignyandexBrowsermanifestshowTitle = null, [WorkflowExpression] Func<string> bodyfaviconGenerationfaviconDesignyandexBrowsermanifestversion = null, [WorkflowExpression] Func<string> bodyfaviconGenerationsettingscompression = null, [WorkflowExpression] Func<string> bodyfaviconGenerationsettingsscalingAlgorithm = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationsettingserrorOnImageTooSmall = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationsettingsreadmeFile = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationsettingshtmlCodeFile = null, [WorkflowExpression] Func<bool> bodyfaviconGenerationsettingsusePathAsIs = null, [WorkflowExpression] Func<string> bodyfaviconGenerationversioningparamName = null, [WorkflowExpression] Func<string> bodyfaviconGenerationversioningparamValue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/favicon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api_key"] = Convert.ToString("@connectionParameters('key')");
                var body = new JObject();
                var bodypropCount = 0;
                var faviconGenerationObject = new JObject();
                var faviconGenerationObjectpropCount = 0;
                var masterPictureObject = new JObject();
                var masterPictureObjectpropCount = 0;
                if (bodyfaviconGenerationmasterPicturetype != null)
                {
                    masterPictureObject["type"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationmasterPicturetype);
                    masterPictureObjectpropCount++;
                }

                if (bodyfaviconGenerationmasterPictureurl != null)
                {
                    masterPictureObject["url"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationmasterPictureurl);
                    masterPictureObjectpropCount++;
                }

                if (masterPictureObjectpropCount > 0)
                {
                    faviconGenerationObject["master_picture"] = masterPictureObject;
                    faviconGenerationObjectpropCount++;
                }

                var filesLocationObject = new JObject();
                var filesLocationObjectpropCount = 0;
                if (bodyfaviconGenerationfilesLocationtype != null)
                {
                    filesLocationObject["type"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfilesLocationtype);
                    filesLocationObjectpropCount++;
                }

                if (bodyfaviconGenerationfilesLocationpath != null)
                {
                    filesLocationObject["path"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfilesLocationpath);
                    filesLocationObjectpropCount++;
                }

                if (filesLocationObjectpropCount > 0)
                {
                    faviconGenerationObject["files_location"] = filesLocationObject;
                    faviconGenerationObjectpropCount++;
                }

                var faviconDesignObject = new JObject();
                var faviconDesignObjectpropCount = 0;
                var desktopBrowserObject = new JObject();
                var desktopBrowserObjectpropCount = 0;
                if (bodyfaviconGenerationfaviconDesigndesktopBrowserpictureAspect != null)
                {
                    desktopBrowserObject["picture_aspect"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigndesktopBrowserpictureAspect);
                    desktopBrowserObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesigndesktopBrowsermargin != null)
                {
                    desktopBrowserObject["margin"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigndesktopBrowsermargin);
                    desktopBrowserObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesigndesktopBrowserbackgroundColor != null)
                {
                    desktopBrowserObject["background_color"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigndesktopBrowserbackgroundColor);
                    desktopBrowserObjectpropCount++;
                }

                var startupImageObject = new JObject();
                var startupImageObjectpropCount = 0;
                var masterPictureObject2 = new JObject();
                var masterPictureObject2propCount = 0;
                if (bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPicturetype != null)
                {
                    masterPictureObject2["type"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPicturetype);
                    masterPictureObject2propCount++;
                }

                if (bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPictureurl != null)
                {
                    masterPictureObject2["url"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPictureurl);
                    masterPictureObject2propCount++;
                }

                if (masterPictureObject2propCount > 0)
                {
                    startupImageObject["master_picture"] = masterPictureObject2;
                    startupImageObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagebackgroundColor != null)
                {
                    startupImageObject["background_color"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagebackgroundColor);
                    startupImageObjectpropCount++;
                }

                if (startupImageObjectpropCount > 0)
                {
                    desktopBrowserObject["startup_image"] = startupImageObject;
                    desktopBrowserObjectpropCount++;
                }

                if (desktopBrowserObjectpropCount > 0)
                {
                    faviconDesignObject["desktop_browser"] = desktopBrowserObject;
                    faviconDesignObjectpropCount++;
                }

                var iosObject = new JObject();
                var iosObjectpropCount = 0;
                if (bodyfaviconGenerationfaviconDesigniospictureAspect != null)
                {
                    iosObject["picture_aspect"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigniospictureAspect);
                    iosObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesigniosmargin != null)
                {
                    iosObject["margin"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigniosmargin);
                    iosObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesigniosbackgroundColor != null)
                {
                    iosObject["background_color"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigniosbackgroundColor);
                    iosObjectpropCount++;
                }

                var startupImageObject2 = new JObject();
                var startupImageObject2propCount = 0;
                var masterPictureObject3 = new JObject();
                var masterPictureObject3propCount = 0;
                if (bodyfaviconGenerationfaviconDesigniosstartupImagemasterPicturetype != null)
                {
                    masterPictureObject3["type"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigniosstartupImagemasterPicturetype);
                    masterPictureObject3propCount++;
                }

                if (bodyfaviconGenerationfaviconDesigniosstartupImagemasterPictureurl != null)
                {
                    masterPictureObject3["url"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigniosstartupImagemasterPictureurl);
                    masterPictureObject3propCount++;
                }

                if (masterPictureObject3propCount > 0)
                {
                    startupImageObject2["master_picture"] = masterPictureObject3;
                    startupImageObject2propCount++;
                }

                if (bodyfaviconGenerationfaviconDesigniosstartupImagebackgroundColor != null)
                {
                    startupImageObject2["background_color"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigniosstartupImagebackgroundColor);
                    startupImageObject2propCount++;
                }

                if (startupImageObject2propCount > 0)
                {
                    iosObject["startup_image"] = startupImageObject2;
                    iosObjectpropCount++;
                }

                var assetsObject = new JObject();
                var assetsObjectpropCount = 0;
                if (bodyfaviconGenerationfaviconDesigniosassetsios6AndPriorIcons != null)
                {
                    assetsObject["ios6_and_prior_icons"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigniosassetsios6AndPriorIcons);
                    assetsObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesigniosassetsios7AndLaterIcons != null)
                {
                    assetsObject["ios7_and_later_icons"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigniosassetsios7AndLaterIcons);
                    assetsObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesigniosassetsprecomposedIcons != null)
                {
                    assetsObject["precomposed_icons"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigniosassetsprecomposedIcons);
                    assetsObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesigniosassetsdeclareOnlyDefaultIcon != null)
                {
                    assetsObject["declare_only_default_icon"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigniosassetsdeclareOnlyDefaultIcon);
                    assetsObjectpropCount++;
                }

                if (assetsObjectpropCount > 0)
                {
                    iosObject["assets"] = assetsObject;
                    iosObjectpropCount++;
                }

                if (iosObjectpropCount > 0)
                {
                    faviconDesignObject["ios"] = iosObject;
                    faviconDesignObjectpropCount++;
                }

                var windowsObject = new JObject();
                var windowsObjectpropCount = 0;
                if (bodyfaviconGenerationfaviconDesignwindowspictureAspect != null)
                {
                    windowsObject["picture_aspect"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignwindowspictureAspect);
                    windowsObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignwindowsbackgroundColor != null)
                {
                    windowsObject["background_color"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignwindowsbackgroundColor);
                    windowsObjectpropCount++;
                }

                var assetsObject2 = new JObject();
                var assetsObject2propCount = 0;
                if (bodyfaviconGenerationfaviconDesignwindowsassetswindows80Ie10Tile != null)
                {
                    assetsObject2["windows_80_ie_10_tile"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignwindowsassetswindows80Ie10Tile);
                    assetsObject2propCount++;
                }

                var windows10Ie11EdgeTilesObject = new JObject();
                var windows10Ie11EdgeTilesObjectpropCount = 0;
                if (bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilessmall != null)
                {
                    windows10Ie11EdgeTilesObject["small"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilessmall);
                    windows10Ie11EdgeTilesObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesmedium != null)
                {
                    windows10Ie11EdgeTilesObject["medium"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesmedium);
                    windows10Ie11EdgeTilesObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesbig != null)
                {
                    windows10Ie11EdgeTilesObject["big"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesbig);
                    windows10Ie11EdgeTilesObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesrectangle != null)
                {
                    windows10Ie11EdgeTilesObject["rectangle"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesrectangle);
                    windows10Ie11EdgeTilesObjectpropCount++;
                }

                if (windows10Ie11EdgeTilesObjectpropCount > 0)
                {
                    assetsObject2["windows_10_ie_11_edge_tiles"] = windows10Ie11EdgeTilesObject;
                    assetsObject2propCount++;
                }

                if (assetsObject2propCount > 0)
                {
                    windowsObject["assets"] = assetsObject2;
                    windowsObjectpropCount++;
                }

                if (windowsObjectpropCount > 0)
                {
                    faviconDesignObject["windows"] = windowsObject;
                    faviconDesignObjectpropCount++;
                }

                var firefoxAppObject = new JObject();
                var firefoxAppObjectpropCount = 0;
                if (bodyfaviconGenerationfaviconDesignfirefoxApppictureAspect != null)
                {
                    firefoxAppObject["picture_aspect"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignfirefoxApppictureAspect);
                    firefoxAppObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignfirefoxAppkeepPictureInCircle != null)
                {
                    firefoxAppObject["keep_picture_in_circle"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignfirefoxAppkeepPictureInCircle);
                    firefoxAppObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignfirefoxAppcircleInnerMargin != null)
                {
                    firefoxAppObject["circle_inner_margin"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignfirefoxAppcircleInnerMargin);
                    firefoxAppObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignfirefoxAppbackgroundColor != null)
                {
                    firefoxAppObject["background_color"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignfirefoxAppbackgroundColor);
                    firefoxAppObjectpropCount++;
                }

                var manifestObject = new JObject();
                var manifestObjectpropCount = 0;
                if (bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappName != null)
                {
                    manifestObject["app_name"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappName);
                    manifestObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappDescription != null)
                {
                    manifestObject["app_description"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappDescription);
                    manifestObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperName != null)
                {
                    manifestObject["developer_name"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperName);
                    manifestObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperUrl != null)
                {
                    manifestObject["developer_url"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperUrl);
                    manifestObjectpropCount++;
                }

                if (manifestObjectpropCount > 0)
                {
                    firefoxAppObject["manifest"] = manifestObject;
                    firefoxAppObjectpropCount++;
                }

                if (firefoxAppObjectpropCount > 0)
                {
                    faviconDesignObject["firefox_app"] = firefoxAppObject;
                    faviconDesignObjectpropCount++;
                }

                var androidChromeObject = new JObject();
                var androidChromeObjectpropCount = 0;
                if (bodyfaviconGenerationfaviconDesignandroidChromepictureAspect != null)
                {
                    androidChromeObject["picture_aspect"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignandroidChromepictureAspect);
                    androidChromeObjectpropCount++;
                }

                var manifestObject2 = new JObject();
                var manifestObject2propCount = 0;
                if (bodyfaviconGenerationfaviconDesignandroidChromemanifestname != null)
                {
                    manifestObject2["name"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignandroidChromemanifestname);
                    manifestObject2propCount++;
                }

                if (bodyfaviconGenerationfaviconDesignandroidChromemanifestdisplay != null)
                {
                    manifestObject2["display"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignandroidChromemanifestdisplay);
                    manifestObject2propCount++;
                }

                if (bodyfaviconGenerationfaviconDesignandroidChromemanifestorientation != null)
                {
                    manifestObject2["orientation"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignandroidChromemanifestorientation);
                    manifestObject2propCount++;
                }

                if (bodyfaviconGenerationfaviconDesignandroidChromemanifeststartUrl != null)
                {
                    manifestObject2["start_url"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignandroidChromemanifeststartUrl);
                    manifestObject2propCount++;
                }

                if (bodyfaviconGenerationfaviconDesignandroidChromemanifestexistingManifest != null)
                {
                    manifestObject2["existing_manifest"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignandroidChromemanifestexistingManifest);
                    manifestObject2propCount++;
                }

                if (manifestObject2propCount > 0)
                {
                    androidChromeObject["manifest"] = manifestObject2;
                    androidChromeObjectpropCount++;
                }

                var assetsObject3 = new JObject();
                var assetsObject3propCount = 0;
                if (bodyfaviconGenerationfaviconDesignandroidChromeassetslegacyIcon != null)
                {
                    assetsObject3["legacy_icon"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignandroidChromeassetslegacyIcon);
                    assetsObject3propCount++;
                }

                if (bodyfaviconGenerationfaviconDesignandroidChromeassetslowResolutionIcons != null)
                {
                    assetsObject3["low_resolution_icons"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignandroidChromeassetslowResolutionIcons);
                    assetsObject3propCount++;
                }

                if (assetsObject3propCount > 0)
                {
                    androidChromeObject["assets"] = assetsObject3;
                    androidChromeObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignandroidChromethemeColor != null)
                {
                    androidChromeObject["theme_color"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignandroidChromethemeColor);
                    androidChromeObjectpropCount++;
                }

                if (androidChromeObjectpropCount > 0)
                {
                    faviconDesignObject["android_chrome"] = androidChromeObject;
                    faviconDesignObjectpropCount++;
                }

                var safariPinnedTabObject = new JObject();
                var safariPinnedTabObjectpropCount = 0;
                if (bodyfaviconGenerationfaviconDesignsafariPinnedTabpictureAspect != null)
                {
                    safariPinnedTabObject["picture_aspect"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignsafariPinnedTabpictureAspect);
                    safariPinnedTabObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignsafariPinnedTabthreshold != null)
                {
                    safariPinnedTabObject["threshold"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignsafariPinnedTabthreshold);
                    safariPinnedTabObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignsafariPinnedTabthemeColor != null)
                {
                    safariPinnedTabObject["theme_color"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignsafariPinnedTabthemeColor);
                    safariPinnedTabObjectpropCount++;
                }

                if (safariPinnedTabObjectpropCount > 0)
                {
                    faviconDesignObject["safari_pinned_tab"] = safariPinnedTabObject;
                    faviconDesignObjectpropCount++;
                }

                var coastObject = new JObject();
                var coastObjectpropCount = 0;
                if (bodyfaviconGenerationfaviconDesigncoastpictureAspect != null)
                {
                    coastObject["picture_aspect"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigncoastpictureAspect);
                    coastObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesigncoastbackgroundColor != null)
                {
                    coastObject["background_color"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigncoastbackgroundColor);
                    coastObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesigncoastmargin != null)
                {
                    coastObject["margin"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesigncoastmargin);
                    coastObjectpropCount++;
                }

                if (coastObjectpropCount > 0)
                {
                    faviconDesignObject["coast"] = coastObject;
                    faviconDesignObjectpropCount++;
                }

                var openGraphObject = new JObject();
                var openGraphObjectpropCount = 0;
                if (bodyfaviconGenerationfaviconDesignopenGraphpictureAspect != null)
                {
                    openGraphObject["picture_aspect"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignopenGraphpictureAspect);
                    openGraphObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignopenGraphbackgroundColor != null)
                {
                    openGraphObject["background_color"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignopenGraphbackgroundColor);
                    openGraphObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignopenGraphmargin != null)
                {
                    openGraphObject["margin"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignopenGraphmargin);
                    openGraphObjectpropCount++;
                }

                if (bodyfaviconGenerationfaviconDesignopenGraphratio != null)
                {
                    openGraphObject["ratio"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignopenGraphratio);
                    openGraphObjectpropCount++;
                }

                if (openGraphObjectpropCount > 0)
                {
                    faviconDesignObject["open_graph"] = openGraphObject;
                    faviconDesignObjectpropCount++;
                }

                var yandexBrowserObject = new JObject();
                var yandexBrowserObjectpropCount = 0;
                if (bodyfaviconGenerationfaviconDesignyandexBrowserbackgroundColor != null)
                {
                    yandexBrowserObject["background_color"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignyandexBrowserbackgroundColor);
                    yandexBrowserObjectpropCount++;
                }

                var manifestObject3 = new JObject();
                var manifestObject3propCount = 0;
                if (bodyfaviconGenerationfaviconDesignyandexBrowsermanifestshowTitle != null)
                {
                    manifestObject3["show_title"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignyandexBrowsermanifestshowTitle);
                    manifestObject3propCount++;
                }

                if (bodyfaviconGenerationfaviconDesignyandexBrowsermanifestversion != null)
                {
                    manifestObject3["version"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationfaviconDesignyandexBrowsermanifestversion);
                    manifestObject3propCount++;
                }

                if (manifestObject3propCount > 0)
                {
                    yandexBrowserObject["manifest"] = manifestObject3;
                    yandexBrowserObjectpropCount++;
                }

                if (yandexBrowserObjectpropCount > 0)
                {
                    faviconDesignObject["yandex_browser"] = yandexBrowserObject;
                    faviconDesignObjectpropCount++;
                }

                if (faviconDesignObjectpropCount > 0)
                {
                    faviconGenerationObject["favicon_design"] = faviconDesignObject;
                    faviconGenerationObjectpropCount++;
                }

                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (bodyfaviconGenerationsettingscompression != null)
                {
                    settingsObject["compression"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationsettingscompression);
                    settingsObjectpropCount++;
                }

                if (bodyfaviconGenerationsettingsscalingAlgorithm != null)
                {
                    settingsObject["scaling_algorithm"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationsettingsscalingAlgorithm);
                    settingsObjectpropCount++;
                }

                if (bodyfaviconGenerationsettingserrorOnImageTooSmall != null)
                {
                    settingsObject["error_on_image_too_small"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationsettingserrorOnImageTooSmall);
                    settingsObjectpropCount++;
                }

                if (bodyfaviconGenerationsettingsreadmeFile != null)
                {
                    settingsObject["readme_file"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationsettingsreadmeFile);
                    settingsObjectpropCount++;
                }

                if (bodyfaviconGenerationsettingshtmlCodeFile != null)
                {
                    settingsObject["html_code_file"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationsettingshtmlCodeFile);
                    settingsObjectpropCount++;
                }

                if (bodyfaviconGenerationsettingsusePathAsIs != null)
                {
                    settingsObject["use_path_as_is"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationsettingsusePathAsIs);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    faviconGenerationObject["settings"] = settingsObject;
                    faviconGenerationObjectpropCount++;
                }

                var versioningObject = new JObject();
                var versioningObjectpropCount = 0;
                if (bodyfaviconGenerationversioningparamName != null)
                {
                    versioningObject["param_name"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationversioningparamName);
                    versioningObjectpropCount++;
                }

                if (bodyfaviconGenerationversioningparamValue != null)
                {
                    versioningObject["param_value"] = SourceExpressionConverter.ConvertToken(bodyfaviconGenerationversioningparamValue);
                    versioningObjectpropCount++;
                }

                if (versioningObjectpropCount > 0)
                {
                    faviconGenerationObject["versioning"] = versioningObject;
                    faviconGenerationObjectpropCount++;
                }

                if (faviconGenerationObjectpropCount > 0)
                {
                    body["favicon_generation"] = faviconGenerationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FaviconPostResponse>(BuildSourceInput);
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