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
        public IBodyWorkflowAction<FaviconPostResponse, ApiConnectionActionConfiguration> Favicon(Expression<Func<FaviconPostInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<FaviconPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/favicon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api_key"] = Convert.ToString("@connectionParameters('key')");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class FaviconPostInput
    {
        [JsonProperty("favicon_generation")]
        public FaviconPostInputFaviconGenerationType FaviconGeneration { get; set; }
    }

    public class FaviconPostInputFaviconGenerationType
    {
        [JsonProperty("master_picture")]
        public FaviconPostInputFaviconGenerationTypeMasterPictureType MasterPicture { get; set; }

        [JsonProperty("files_location")]
        public FaviconPostInputFaviconGenerationTypeFilesLocationType FilesLocation { get; set; }

        [JsonProperty("favicon_design")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignType FaviconDesign { get; set; }

        [JsonProperty("settings")]
        public FaviconPostInputFaviconGenerationTypeSettingsType Settings { get; set; }

        [JsonProperty("versioning")]
        public FaviconPostInputFaviconGenerationTypeVersioningType Versioning { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeMasterPictureType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFilesLocationType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignType
    {
        [JsonProperty("desktop_browser")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeDesktopBrowserType DesktopBrowser { get; set; }

        [JsonProperty("ios")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeIosType Ios { get; set; }

        [JsonProperty("windows")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeWindowsType Windows { get; set; }

        [JsonProperty("firefox_app")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeFirefoxAppType FirefoxApp { get; set; }

        [JsonProperty("android_chrome")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeAndroidChromeType AndroidChrome { get; set; }

        [JsonProperty("safari_pinned_tab")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeSafariPinnedTabType SafariPinnedTab { get; set; }

        [JsonProperty("coast")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeCoastType Coast { get; set; }

        [JsonProperty("open_graph")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeOpenGraphType OpenGraph { get; set; }

        [JsonProperty("yandex_browser")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeYandexBrowserType YandexBrowser { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeDesktopBrowserType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("margin")]
        public string Margin { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("startup_image")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeDesktopBrowserTypeStartupImageType StartupImage { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeDesktopBrowserTypeStartupImageType
    {
        [JsonProperty("master_picture")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeDesktopBrowserTypeStartupImageTypeMasterPictureType MasterPicture { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeDesktopBrowserTypeStartupImageTypeMasterPictureType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeIosType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("margin")]
        public string Margin { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("startup_image")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeIosTypeStartupImageType StartupImage { get; set; }

        [JsonProperty("assets")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeIosTypeAssetsType Assets { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeIosTypeStartupImageType
    {
        [JsonProperty("master_picture")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeIosTypeStartupImageTypeMasterPictureType MasterPicture { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeIosTypeStartupImageTypeMasterPictureType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeIosTypeAssetsType
    {
        [JsonProperty("ios6_and_prior_icons")]
        public bool? Ios6AndPriorIcons { get; set; }

        [JsonProperty("ios7_and_later_icons")]
        public bool? Ios7AndLaterIcons { get; set; }

        [JsonProperty("precomposed_icons")]
        public bool? PrecomposedIcons { get; set; }

        [JsonProperty("declare_only_default_icon")]
        public bool? DeclareOnlyDefaultIcon { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeWindowsType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("assets")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeWindowsTypeAssetsType Assets { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeWindowsTypeAssetsType
    {
        [JsonProperty("windows_80_ie_10_tile")]
        public bool? Windows80Ie10Tile { get; set; }

        [JsonProperty("windows_10_ie_11_edge_tiles")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeWindowsTypeAssetsTypeWindows10Ie11EdgeTilesType Windows10Ie11EdgeTiles { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeWindowsTypeAssetsTypeWindows10Ie11EdgeTilesType
    {
        [JsonProperty("small")]
        public bool? Small { get; set; }

        [JsonProperty("medium")]
        public bool? Medium { get; set; }

        [JsonProperty("big")]
        public bool? Big { get; set; }

        [JsonProperty("rectangle")]
        public bool? Rectangle { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeFirefoxAppType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("keep_picture_in_circle")]
        public string KeepPictureInCircle { get; set; }

        [JsonProperty("circle_inner_margin")]
        public string CircleInnerMargin { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("manifest")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeFirefoxAppTypeManifestType Manifest { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeFirefoxAppTypeManifestType
    {
        [JsonProperty("app_name")]
        public string AppName { get; set; }

        [JsonProperty("app_description")]
        public string AppDescription { get; set; }

        [JsonProperty("developer_name")]
        public string DeveloperName { get; set; }

        [JsonProperty("developer_url")]
        public string DeveloperUrl { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeAndroidChromeType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("manifest")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeAndroidChromeTypeManifestType Manifest { get; set; }

        [JsonProperty("assets")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeAndroidChromeTypeAssetsType Assets { get; set; }

        [JsonProperty("theme_color")]
        public string ThemeColor { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeAndroidChromeTypeManifestType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }

        [JsonProperty("orientation")]
        public string Orientation { get; set; }

        [JsonProperty("start_url")]
        public string StartUrl { get; set; }

        [JsonProperty("existing_manifest")]
        public string ExistingManifest { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeAndroidChromeTypeAssetsType
    {
        [JsonProperty("legacy_icon")]
        public bool? LegacyIcon { get; set; }

        [JsonProperty("low_resolution_icons")]
        public bool? LowResolutionIcons { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeSafariPinnedTabType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("threshold")]
        public int? Threshold { get; set; }

        [JsonProperty("theme_color")]
        public string ThemeColor { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeCoastType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("margin")]
        public string Margin { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeOpenGraphType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("margin")]
        public string Margin { get; set; }

        [JsonProperty("ratio")]
        public string Ratio { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeYandexBrowserType
    {
        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("manifest")]
        public FaviconPostInputFaviconGenerationTypeFaviconDesignTypeYandexBrowserTypeManifestType Manifest { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeFaviconDesignTypeYandexBrowserTypeManifestType
    {
        [JsonProperty("show_title")]
        public bool? ShowTitle { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeSettingsType
    {
        [JsonProperty("compression")]
        public string Compression { get; set; }

        [JsonProperty("scaling_algorithm")]
        public string ScalingAlgorithm { get; set; }

        [JsonProperty("error_on_image_too_small")]
        public bool? ErrorOnImageTooSmall { get; set; }

        [JsonProperty("readme_file")]
        public bool? ReadmeFile { get; set; }

        [JsonProperty("html_code_file")]
        public bool? HtmlCodeFile { get; set; }

        [JsonProperty("use_path_as_is")]
        public bool? UsePathAsIs { get; set; }
    }

    public class FaviconPostInputFaviconGenerationTypeVersioningType
    {
        [JsonProperty("param_name")]
        public string ParamName { get; set; }

        [JsonProperty("param_value")]
        public string ParamValue { get; set; }
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