//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Realfavicongenerator
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RealfavicongeneratorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "realfavicongenerator")]
        public IBodyWorkflowAction<FaviconPostResponse, ApiConnectionActionConfiguration> Favicon(Expression<Func<string>> bodyfaviconGenerationmasterPicturetype = null, Expression<Func<string>> bodyfaviconGenerationmasterPictureurl = null, Expression<Func<string>> bodyfaviconGenerationfilesLocationtype = null, Expression<Func<string>> bodyfaviconGenerationfilesLocationpath = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigndesktopBrowserpictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigndesktopBrowsermargin = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigndesktopBrowserbackgroundColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPicturetype = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPictureurl = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagebackgroundColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigniospictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigniosmargin = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigniosbackgroundColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigniosstartupImagemasterPicturetype = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigniosstartupImagemasterPictureurl = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigniosstartupImagebackgroundColor = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesigniosassetsios6AndPriorIcons = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesigniosassetsios7AndLaterIcons = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesigniosassetsprecomposedIcons = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesigniosassetsdeclareOnlyDefaultIcon = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignwindowspictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignwindowsbackgroundColor = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignwindowsassetswindows80Ie10Tile = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilessmall = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesmedium = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesbig = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesrectangle = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxApppictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppkeepPictureInCircle = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppcircleInnerMargin = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppbackgroundColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappName = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappDescription = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperName = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperUrl = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromepictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromemanifestname = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromemanifestdisplay = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromemanifestorientation = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromemanifeststartUrl = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromemanifestexistingManifest = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignandroidChromeassetslegacyIcon = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignandroidChromeassetslowResolutionIcons = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignandroidChromethemeColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignsafariPinnedTabpictureAspect = null, Expression<Func<int>> bodyfaviconGenerationfaviconDesignsafariPinnedTabthreshold = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignsafariPinnedTabthemeColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigncoastpictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigncoastbackgroundColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesigncoastmargin = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignopenGraphpictureAspect = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignopenGraphbackgroundColor = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignopenGraphmargin = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignopenGraphratio = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignyandexBrowserbackgroundColor = null, Expression<Func<bool>> bodyfaviconGenerationfaviconDesignyandexBrowsermanifestshowTitle = null, Expression<Func<string>> bodyfaviconGenerationfaviconDesignyandexBrowsermanifestversion = null, Expression<Func<string>> bodyfaviconGenerationsettingscompression = null, Expression<Func<string>> bodyfaviconGenerationsettingsscalingAlgorithm = null, Expression<Func<bool>> bodyfaviconGenerationsettingserrorOnImageTooSmall = null, Expression<Func<bool>> bodyfaviconGenerationsettingsreadmeFile = null, Expression<Func<bool>> bodyfaviconGenerationsettingshtmlCodeFile = null, Expression<Func<bool>> bodyfaviconGenerationsettingsusePathAsIs = null, Expression<Func<string>> bodyfaviconGenerationversioningparamName = null, Expression<Func<string>> bodyfaviconGenerationversioningparamValue = null)
        {
            var __workflow_bodyfaviconGenerationmasterPicturetype = WorkflowExpression.Compile(bodyfaviconGenerationmasterPicturetype, nameof(bodyfaviconGenerationmasterPicturetype), required: false);
            var __workflow_bodyfaviconGenerationmasterPictureurl = WorkflowExpression.Compile(bodyfaviconGenerationmasterPictureurl, nameof(bodyfaviconGenerationmasterPictureurl), required: false);
            var __workflow_bodyfaviconGenerationfilesLocationtype = WorkflowExpression.Compile(bodyfaviconGenerationfilesLocationtype, nameof(bodyfaviconGenerationfilesLocationtype), required: false);
            var __workflow_bodyfaviconGenerationfilesLocationpath = WorkflowExpression.Compile(bodyfaviconGenerationfilesLocationpath, nameof(bodyfaviconGenerationfilesLocationpath), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserpictureAspect = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigndesktopBrowserpictureAspect, nameof(bodyfaviconGenerationfaviconDesigndesktopBrowserpictureAspect), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigndesktopBrowsermargin = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigndesktopBrowsermargin, nameof(bodyfaviconGenerationfaviconDesigndesktopBrowsermargin), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserbackgroundColor = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigndesktopBrowserbackgroundColor, nameof(bodyfaviconGenerationfaviconDesigndesktopBrowserbackgroundColor), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPicturetype = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPicturetype, nameof(bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPicturetype), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPictureurl = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPictureurl, nameof(bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPictureurl), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagebackgroundColor = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagebackgroundColor, nameof(bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagebackgroundColor), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigniospictureAspect = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigniospictureAspect, nameof(bodyfaviconGenerationfaviconDesigniospictureAspect), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigniosmargin = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigniosmargin, nameof(bodyfaviconGenerationfaviconDesigniosmargin), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigniosbackgroundColor = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigniosbackgroundColor, nameof(bodyfaviconGenerationfaviconDesigniosbackgroundColor), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigniosstartupImagemasterPicturetype = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigniosstartupImagemasterPicturetype, nameof(bodyfaviconGenerationfaviconDesigniosstartupImagemasterPicturetype), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigniosstartupImagemasterPictureurl = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigniosstartupImagemasterPictureurl, nameof(bodyfaviconGenerationfaviconDesigniosstartupImagemasterPictureurl), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigniosstartupImagebackgroundColor = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigniosstartupImagebackgroundColor, nameof(bodyfaviconGenerationfaviconDesigniosstartupImagebackgroundColor), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigniosassetsios6AndPriorIcons = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigniosassetsios6AndPriorIcons, nameof(bodyfaviconGenerationfaviconDesigniosassetsios6AndPriorIcons), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigniosassetsios7AndLaterIcons = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigniosassetsios7AndLaterIcons, nameof(bodyfaviconGenerationfaviconDesigniosassetsios7AndLaterIcons), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigniosassetsprecomposedIcons = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigniosassetsprecomposedIcons, nameof(bodyfaviconGenerationfaviconDesigniosassetsprecomposedIcons), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigniosassetsdeclareOnlyDefaultIcon = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigniosassetsdeclareOnlyDefaultIcon, nameof(bodyfaviconGenerationfaviconDesigniosassetsdeclareOnlyDefaultIcon), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignwindowspictureAspect = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignwindowspictureAspect, nameof(bodyfaviconGenerationfaviconDesignwindowspictureAspect), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignwindowsbackgroundColor = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignwindowsbackgroundColor, nameof(bodyfaviconGenerationfaviconDesignwindowsbackgroundColor), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows80Ie10Tile = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignwindowsassetswindows80Ie10Tile, nameof(bodyfaviconGenerationfaviconDesignwindowsassetswindows80Ie10Tile), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilessmall = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilessmall, nameof(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilessmall), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesmedium = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesmedium, nameof(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesmedium), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesbig = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesbig, nameof(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesbig), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesrectangle = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesrectangle, nameof(bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesrectangle), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignfirefoxApppictureAspect = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignfirefoxApppictureAspect, nameof(bodyfaviconGenerationfaviconDesignfirefoxApppictureAspect), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignfirefoxAppkeepPictureInCircle = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignfirefoxAppkeepPictureInCircle, nameof(bodyfaviconGenerationfaviconDesignfirefoxAppkeepPictureInCircle), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignfirefoxAppcircleInnerMargin = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignfirefoxAppcircleInnerMargin, nameof(bodyfaviconGenerationfaviconDesignfirefoxAppcircleInnerMargin), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignfirefoxAppbackgroundColor = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignfirefoxAppbackgroundColor, nameof(bodyfaviconGenerationfaviconDesignfirefoxAppbackgroundColor), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappName = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappName, nameof(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappName), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappDescription = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappDescription, nameof(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappDescription), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperName = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperName, nameof(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperName), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperUrl = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperUrl, nameof(bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperUrl), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignandroidChromepictureAspect = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignandroidChromepictureAspect, nameof(bodyfaviconGenerationfaviconDesignandroidChromepictureAspect), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifestname = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignandroidChromemanifestname, nameof(bodyfaviconGenerationfaviconDesignandroidChromemanifestname), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifestdisplay = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignandroidChromemanifestdisplay, nameof(bodyfaviconGenerationfaviconDesignandroidChromemanifestdisplay), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifestorientation = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignandroidChromemanifestorientation, nameof(bodyfaviconGenerationfaviconDesignandroidChromemanifestorientation), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifeststartUrl = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignandroidChromemanifeststartUrl, nameof(bodyfaviconGenerationfaviconDesignandroidChromemanifeststartUrl), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifestexistingManifest = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignandroidChromemanifestexistingManifest, nameof(bodyfaviconGenerationfaviconDesignandroidChromemanifestexistingManifest), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignandroidChromeassetslegacyIcon = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignandroidChromeassetslegacyIcon, nameof(bodyfaviconGenerationfaviconDesignandroidChromeassetslegacyIcon), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignandroidChromeassetslowResolutionIcons = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignandroidChromeassetslowResolutionIcons, nameof(bodyfaviconGenerationfaviconDesignandroidChromeassetslowResolutionIcons), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignandroidChromethemeColor = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignandroidChromethemeColor, nameof(bodyfaviconGenerationfaviconDesignandroidChromethemeColor), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignsafariPinnedTabpictureAspect = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignsafariPinnedTabpictureAspect, nameof(bodyfaviconGenerationfaviconDesignsafariPinnedTabpictureAspect), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignsafariPinnedTabthreshold = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignsafariPinnedTabthreshold, nameof(bodyfaviconGenerationfaviconDesignsafariPinnedTabthreshold), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignsafariPinnedTabthemeColor = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignsafariPinnedTabthemeColor, nameof(bodyfaviconGenerationfaviconDesignsafariPinnedTabthemeColor), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigncoastpictureAspect = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigncoastpictureAspect, nameof(bodyfaviconGenerationfaviconDesigncoastpictureAspect), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigncoastbackgroundColor = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigncoastbackgroundColor, nameof(bodyfaviconGenerationfaviconDesigncoastbackgroundColor), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesigncoastmargin = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesigncoastmargin, nameof(bodyfaviconGenerationfaviconDesigncoastmargin), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignopenGraphpictureAspect = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignopenGraphpictureAspect, nameof(bodyfaviconGenerationfaviconDesignopenGraphpictureAspect), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignopenGraphbackgroundColor = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignopenGraphbackgroundColor, nameof(bodyfaviconGenerationfaviconDesignopenGraphbackgroundColor), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignopenGraphmargin = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignopenGraphmargin, nameof(bodyfaviconGenerationfaviconDesignopenGraphmargin), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignopenGraphratio = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignopenGraphratio, nameof(bodyfaviconGenerationfaviconDesignopenGraphratio), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignyandexBrowserbackgroundColor = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignyandexBrowserbackgroundColor, nameof(bodyfaviconGenerationfaviconDesignyandexBrowserbackgroundColor), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignyandexBrowsermanifestshowTitle = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignyandexBrowsermanifestshowTitle, nameof(bodyfaviconGenerationfaviconDesignyandexBrowsermanifestshowTitle), required: false);
            var __workflow_bodyfaviconGenerationfaviconDesignyandexBrowsermanifestversion = WorkflowExpression.Compile(bodyfaviconGenerationfaviconDesignyandexBrowsermanifestversion, nameof(bodyfaviconGenerationfaviconDesignyandexBrowsermanifestversion), required: false);
            var __workflow_bodyfaviconGenerationsettingscompression = WorkflowExpression.Compile(bodyfaviconGenerationsettingscompression, nameof(bodyfaviconGenerationsettingscompression), required: false);
            var __workflow_bodyfaviconGenerationsettingsscalingAlgorithm = WorkflowExpression.Compile(bodyfaviconGenerationsettingsscalingAlgorithm, nameof(bodyfaviconGenerationsettingsscalingAlgorithm), required: false);
            var __workflow_bodyfaviconGenerationsettingserrorOnImageTooSmall = WorkflowExpression.Compile(bodyfaviconGenerationsettingserrorOnImageTooSmall, nameof(bodyfaviconGenerationsettingserrorOnImageTooSmall), required: false);
            var __workflow_bodyfaviconGenerationsettingsreadmeFile = WorkflowExpression.Compile(bodyfaviconGenerationsettingsreadmeFile, nameof(bodyfaviconGenerationsettingsreadmeFile), required: false);
            var __workflow_bodyfaviconGenerationsettingshtmlCodeFile = WorkflowExpression.Compile(bodyfaviconGenerationsettingshtmlCodeFile, nameof(bodyfaviconGenerationsettingshtmlCodeFile), required: false);
            var __workflow_bodyfaviconGenerationsettingsusePathAsIs = WorkflowExpression.Compile(bodyfaviconGenerationsettingsusePathAsIs, nameof(bodyfaviconGenerationsettingsusePathAsIs), required: false);
            var __workflow_bodyfaviconGenerationversioningparamName = WorkflowExpression.Compile(bodyfaviconGenerationversioningparamName, nameof(bodyfaviconGenerationversioningparamName), required: false);
            var __workflow_bodyfaviconGenerationversioningparamValue = WorkflowExpression.Compile(bodyfaviconGenerationversioningparamValue, nameof(bodyfaviconGenerationversioningparamValue), required: false);
            return new DeferredBodyAction<FaviconPostResponse, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_bodyfaviconGenerationmasterPicturetype != null)
                {
                    masterPictureObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationmasterPicturetype);
                    masterPictureObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationmasterPictureurl != null)
                {
                    masterPictureObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationmasterPictureurl);
                    masterPictureObjectpropCount++;
                }

                if (masterPictureObjectpropCount > 0)
                {
                    faviconGenerationObject["master_picture"] = masterPictureObject;
                    faviconGenerationObjectpropCount++;
                }

                var filesLocationObject = new JObject();
                var filesLocationObjectpropCount = 0;
                if (__workflow_bodyfaviconGenerationfilesLocationtype != null)
                {
                    filesLocationObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfilesLocationtype);
                    filesLocationObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfilesLocationpath != null)
                {
                    filesLocationObject["path"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfilesLocationpath);
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
                if (__workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserpictureAspect != null)
                {
                    desktopBrowserObject["picture_aspect"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserpictureAspect);
                    desktopBrowserObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesigndesktopBrowsermargin != null)
                {
                    desktopBrowserObject["margin"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigndesktopBrowsermargin);
                    desktopBrowserObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserbackgroundColor != null)
                {
                    desktopBrowserObject["background_color"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserbackgroundColor);
                    desktopBrowserObjectpropCount++;
                }

                var startupImageObject = new JObject();
                var startupImageObjectpropCount = 0;
                var masterPictureObject2 = new JObject();
                var masterPictureObject2propCount = 0;
                if (__workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPicturetype != null)
                {
                    masterPictureObject2["type"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPicturetype);
                    masterPictureObject2propCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPictureurl != null)
                {
                    masterPictureObject2["url"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagemasterPictureurl);
                    masterPictureObject2propCount++;
                }

                if (masterPictureObject2propCount > 0)
                {
                    startupImageObject["master_picture"] = masterPictureObject2;
                    startupImageObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagebackgroundColor != null)
                {
                    startupImageObject["background_color"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigndesktopBrowserstartupImagebackgroundColor);
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
                if (__workflow_bodyfaviconGenerationfaviconDesigniospictureAspect != null)
                {
                    iosObject["picture_aspect"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigniospictureAspect);
                    iosObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesigniosmargin != null)
                {
                    iosObject["margin"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigniosmargin);
                    iosObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesigniosbackgroundColor != null)
                {
                    iosObject["background_color"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigniosbackgroundColor);
                    iosObjectpropCount++;
                }

                var startupImageObject2 = new JObject();
                var startupImageObject2propCount = 0;
                var masterPictureObject3 = new JObject();
                var masterPictureObject3propCount = 0;
                if (__workflow_bodyfaviconGenerationfaviconDesigniosstartupImagemasterPicturetype != null)
                {
                    masterPictureObject3["type"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigniosstartupImagemasterPicturetype);
                    masterPictureObject3propCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesigniosstartupImagemasterPictureurl != null)
                {
                    masterPictureObject3["url"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigniosstartupImagemasterPictureurl);
                    masterPictureObject3propCount++;
                }

                if (masterPictureObject3propCount > 0)
                {
                    startupImageObject2["master_picture"] = masterPictureObject3;
                    startupImageObject2propCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesigniosstartupImagebackgroundColor != null)
                {
                    startupImageObject2["background_color"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigniosstartupImagebackgroundColor);
                    startupImageObject2propCount++;
                }

                if (startupImageObject2propCount > 0)
                {
                    iosObject["startup_image"] = startupImageObject2;
                    iosObjectpropCount++;
                }

                var assetsObject = new JObject();
                var assetsObjectpropCount = 0;
                if (__workflow_bodyfaviconGenerationfaviconDesigniosassetsios6AndPriorIcons != null)
                {
                    assetsObject["ios6_and_prior_icons"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigniosassetsios6AndPriorIcons);
                    assetsObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesigniosassetsios7AndLaterIcons != null)
                {
                    assetsObject["ios7_and_later_icons"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigniosassetsios7AndLaterIcons);
                    assetsObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesigniosassetsprecomposedIcons != null)
                {
                    assetsObject["precomposed_icons"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigniosassetsprecomposedIcons);
                    assetsObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesigniosassetsdeclareOnlyDefaultIcon != null)
                {
                    assetsObject["declare_only_default_icon"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigniosassetsdeclareOnlyDefaultIcon);
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
                if (__workflow_bodyfaviconGenerationfaviconDesignwindowspictureAspect != null)
                {
                    windowsObject["picture_aspect"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignwindowspictureAspect);
                    windowsObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignwindowsbackgroundColor != null)
                {
                    windowsObject["background_color"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignwindowsbackgroundColor);
                    windowsObjectpropCount++;
                }

                var assetsObject2 = new JObject();
                var assetsObject2propCount = 0;
                if (__workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows80Ie10Tile != null)
                {
                    assetsObject2["windows_80_ie_10_tile"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows80Ie10Tile);
                    assetsObject2propCount++;
                }

                var windows10Ie11EdgeTilesObject = new JObject();
                var windows10Ie11EdgeTilesObjectpropCount = 0;
                if (__workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilessmall != null)
                {
                    windows10Ie11EdgeTilesObject["small"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilessmall);
                    windows10Ie11EdgeTilesObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesmedium != null)
                {
                    windows10Ie11EdgeTilesObject["medium"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesmedium);
                    windows10Ie11EdgeTilesObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesbig != null)
                {
                    windows10Ie11EdgeTilesObject["big"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesbig);
                    windows10Ie11EdgeTilesObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesrectangle != null)
                {
                    windows10Ie11EdgeTilesObject["rectangle"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignwindowsassetswindows10Ie11EdgeTilesrectangle);
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
                if (__workflow_bodyfaviconGenerationfaviconDesignfirefoxApppictureAspect != null)
                {
                    firefoxAppObject["picture_aspect"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignfirefoxApppictureAspect);
                    firefoxAppObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppkeepPictureInCircle != null)
                {
                    firefoxAppObject["keep_picture_in_circle"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppkeepPictureInCircle);
                    firefoxAppObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppcircleInnerMargin != null)
                {
                    firefoxAppObject["circle_inner_margin"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppcircleInnerMargin);
                    firefoxAppObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppbackgroundColor != null)
                {
                    firefoxAppObject["background_color"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppbackgroundColor);
                    firefoxAppObjectpropCount++;
                }

                var manifestObject = new JObject();
                var manifestObjectpropCount = 0;
                if (__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappName != null)
                {
                    manifestObject["app_name"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappName);
                    manifestObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappDescription != null)
                {
                    manifestObject["app_description"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppmanifestappDescription);
                    manifestObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperName != null)
                {
                    manifestObject["developer_name"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperName);
                    manifestObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperUrl != null)
                {
                    manifestObject["developer_url"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignfirefoxAppmanifestdeveloperUrl);
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
                if (__workflow_bodyfaviconGenerationfaviconDesignandroidChromepictureAspect != null)
                {
                    androidChromeObject["picture_aspect"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignandroidChromepictureAspect);
                    androidChromeObjectpropCount++;
                }

                var manifestObject2 = new JObject();
                var manifestObject2propCount = 0;
                if (__workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifestname != null)
                {
                    manifestObject2["name"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifestname);
                    manifestObject2propCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifestdisplay != null)
                {
                    manifestObject2["display"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifestdisplay);
                    manifestObject2propCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifestorientation != null)
                {
                    manifestObject2["orientation"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifestorientation);
                    manifestObject2propCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifeststartUrl != null)
                {
                    manifestObject2["start_url"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifeststartUrl);
                    manifestObject2propCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifestexistingManifest != null)
                {
                    manifestObject2["existing_manifest"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignandroidChromemanifestexistingManifest);
                    manifestObject2propCount++;
                }

                if (manifestObject2propCount > 0)
                {
                    androidChromeObject["manifest"] = manifestObject2;
                    androidChromeObjectpropCount++;
                }

                var assetsObject3 = new JObject();
                var assetsObject3propCount = 0;
                if (__workflow_bodyfaviconGenerationfaviconDesignandroidChromeassetslegacyIcon != null)
                {
                    assetsObject3["legacy_icon"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignandroidChromeassetslegacyIcon);
                    assetsObject3propCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignandroidChromeassetslowResolutionIcons != null)
                {
                    assetsObject3["low_resolution_icons"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignandroidChromeassetslowResolutionIcons);
                    assetsObject3propCount++;
                }

                if (assetsObject3propCount > 0)
                {
                    androidChromeObject["assets"] = assetsObject3;
                    androidChromeObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignandroidChromethemeColor != null)
                {
                    androidChromeObject["theme_color"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignandroidChromethemeColor);
                    androidChromeObjectpropCount++;
                }

                if (androidChromeObjectpropCount > 0)
                {
                    faviconDesignObject["android_chrome"] = androidChromeObject;
                    faviconDesignObjectpropCount++;
                }

                var safariPinnedTabObject = new JObject();
                var safariPinnedTabObjectpropCount = 0;
                if (__workflow_bodyfaviconGenerationfaviconDesignsafariPinnedTabpictureAspect != null)
                {
                    safariPinnedTabObject["picture_aspect"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignsafariPinnedTabpictureAspect);
                    safariPinnedTabObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignsafariPinnedTabthreshold != null)
                {
                    safariPinnedTabObject["threshold"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignsafariPinnedTabthreshold);
                    safariPinnedTabObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignsafariPinnedTabthemeColor != null)
                {
                    safariPinnedTabObject["theme_color"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignsafariPinnedTabthemeColor);
                    safariPinnedTabObjectpropCount++;
                }

                if (safariPinnedTabObjectpropCount > 0)
                {
                    faviconDesignObject["safari_pinned_tab"] = safariPinnedTabObject;
                    faviconDesignObjectpropCount++;
                }

                var coastObject = new JObject();
                var coastObjectpropCount = 0;
                if (__workflow_bodyfaviconGenerationfaviconDesigncoastpictureAspect != null)
                {
                    coastObject["picture_aspect"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigncoastpictureAspect);
                    coastObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesigncoastbackgroundColor != null)
                {
                    coastObject["background_color"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigncoastbackgroundColor);
                    coastObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesigncoastmargin != null)
                {
                    coastObject["margin"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesigncoastmargin);
                    coastObjectpropCount++;
                }

                if (coastObjectpropCount > 0)
                {
                    faviconDesignObject["coast"] = coastObject;
                    faviconDesignObjectpropCount++;
                }

                var openGraphObject = new JObject();
                var openGraphObjectpropCount = 0;
                if (__workflow_bodyfaviconGenerationfaviconDesignopenGraphpictureAspect != null)
                {
                    openGraphObject["picture_aspect"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignopenGraphpictureAspect);
                    openGraphObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignopenGraphbackgroundColor != null)
                {
                    openGraphObject["background_color"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignopenGraphbackgroundColor);
                    openGraphObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignopenGraphmargin != null)
                {
                    openGraphObject["margin"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignopenGraphmargin);
                    openGraphObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignopenGraphratio != null)
                {
                    openGraphObject["ratio"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignopenGraphratio);
                    openGraphObjectpropCount++;
                }

                if (openGraphObjectpropCount > 0)
                {
                    faviconDesignObject["open_graph"] = openGraphObject;
                    faviconDesignObjectpropCount++;
                }

                var yandexBrowserObject = new JObject();
                var yandexBrowserObjectpropCount = 0;
                if (__workflow_bodyfaviconGenerationfaviconDesignyandexBrowserbackgroundColor != null)
                {
                    yandexBrowserObject["background_color"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignyandexBrowserbackgroundColor);
                    yandexBrowserObjectpropCount++;
                }

                var manifestObject3 = new JObject();
                var manifestObject3propCount = 0;
                if (__workflow_bodyfaviconGenerationfaviconDesignyandexBrowsermanifestshowTitle != null)
                {
                    manifestObject3["show_title"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignyandexBrowsermanifestshowTitle);
                    manifestObject3propCount++;
                }

                if (__workflow_bodyfaviconGenerationfaviconDesignyandexBrowsermanifestversion != null)
                {
                    manifestObject3["version"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationfaviconDesignyandexBrowsermanifestversion);
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
                if (__workflow_bodyfaviconGenerationsettingscompression != null)
                {
                    settingsObject["compression"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationsettingscompression);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationsettingsscalingAlgorithm != null)
                {
                    settingsObject["scaling_algorithm"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationsettingsscalingAlgorithm);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationsettingserrorOnImageTooSmall != null)
                {
                    settingsObject["error_on_image_too_small"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationsettingserrorOnImageTooSmall);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationsettingsreadmeFile != null)
                {
                    settingsObject["readme_file"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationsettingsreadmeFile);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationsettingshtmlCodeFile != null)
                {
                    settingsObject["html_code_file"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationsettingshtmlCodeFile);
                    settingsObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationsettingsusePathAsIs != null)
                {
                    settingsObject["use_path_as_is"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationsettingsusePathAsIs);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    faviconGenerationObject["settings"] = settingsObject;
                    faviconGenerationObjectpropCount++;
                }

                var versioningObject = new JObject();
                var versioningObjectpropCount = 0;
                if (__workflow_bodyfaviconGenerationversioningparamName != null)
                {
                    versioningObject["param_name"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationversioningparamName);
                    versioningObjectpropCount++;
                }

                if (__workflow_bodyfaviconGenerationversioningparamValue != null)
                {
                    versioningObject["param_value"] = ExpressionConverter.ConvertO(__workflow_bodyfaviconGenerationversioningparamValue);
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

                return new ApiConnectionAction<FaviconPostResponse>(callPayload);
            });
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