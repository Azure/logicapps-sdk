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
        public IBodyWorkflowAction<FaviconResponse, ApiConnectionActionConfiguration> Favicon(Expression<Func<BodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<FaviconResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/favicon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["api_key"] = Convert.ToString("@connectionParameters('key')");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FaviconResponse>(callPayload);
            });
        }
    }

    public class RealfavicongeneratorTriggers([ConnectionName] string connectionId)
    {
    }

    public class FaviconResponse
    {
        [JsonProperty("favicon_generation_result")]
        public FaviconResponseFaviconGenerationResultType FaviconGenerationResult { get; set; }
    }

    public class FaviconResponseFaviconGenerationResultType
    {
        [JsonProperty("result")]
        public FaviconResponseFaviconGenerationResultTypeResultType Result { get; set; }

        [JsonProperty("favicon")]
        public FaviconResponseFaviconGenerationResultTypeFaviconType Favicon { get; set; }

        [JsonProperty("files_location")]
        public FaviconResponseFaviconGenerationResultTypeFilesLocationType FilesLocation { get; set; }

        [JsonProperty("preview_picture_url")]
        public string PreviewPictureUrl { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class FaviconResponseFaviconGenerationResultTypeResultType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class FaviconResponseFaviconGenerationResultTypeFaviconType
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

    public class FaviconResponseFaviconGenerationResultTypeFilesLocationType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class BodyInput
    {
        [JsonProperty("favicon_generation")]
        public BodyInputFaviconGenerationType FaviconGeneration { get; set; }
    }

    public class BodyInputFaviconGenerationType
    {
        [JsonProperty("master_picture")]
        public BodyInputFaviconGenerationTypeMasterPictureType MasterPicture { get; set; }

        [JsonProperty("files_location")]
        public BodyInputFaviconGenerationTypeFilesLocationType FilesLocation { get; set; }

        [JsonProperty("favicon_design")]
        public BodyInputFaviconGenerationTypeFaviconDesignType FaviconDesign { get; set; }

        [JsonProperty("settings")]
        public BodyInputFaviconGenerationTypeSettingsType Settings { get; set; }

        [JsonProperty("versioning")]
        public BodyInputFaviconGenerationTypeVersioningType Versioning { get; set; }
    }

    public class BodyInputFaviconGenerationTypeMasterPictureType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFilesLocationType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignType
    {
        [JsonProperty("desktop_browser")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeDesktopBrowserType DesktopBrowser { get; set; }

        [JsonProperty("ios")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeIosType Ios { get; set; }

        [JsonProperty("windows")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeWindowsType Windows { get; set; }

        [JsonProperty("firefox_app")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeFirefoxAppType FirefoxApp { get; set; }

        [JsonProperty("android_chrome")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeAndroidChromeType AndroidChrome { get; set; }

        [JsonProperty("safari_pinned_tab")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeSafariPinnedTabType SafariPinnedTab { get; set; }

        [JsonProperty("coast")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeCoastType Coast { get; set; }

        [JsonProperty("open_graph")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeOpenGraphType OpenGraph { get; set; }

        [JsonProperty("yandex_browser")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeYandexBrowserType YandexBrowser { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeDesktopBrowserType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("margin")]
        public string Margin { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("startup_image")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeDesktopBrowserTypeStartupImageType StartupImage { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeDesktopBrowserTypeStartupImageType
    {
        [JsonProperty("master_picture")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeDesktopBrowserTypeStartupImageTypeMasterPictureType MasterPicture { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeDesktopBrowserTypeStartupImageTypeMasterPictureType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeIosType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("margin")]
        public string Margin { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("startup_image")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeIosTypeStartupImageType StartupImage { get; set; }

        [JsonProperty("assets")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeIosTypeAssetsType Assets { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeIosTypeStartupImageType
    {
        [JsonProperty("master_picture")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeIosTypeStartupImageTypeMasterPictureType MasterPicture { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeIosTypeStartupImageTypeMasterPictureType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeIosTypeAssetsType
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

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeWindowsType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("assets")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeWindowsTypeAssetsType Assets { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeWindowsTypeAssetsType
    {
        [JsonProperty("windows_80_ie_10_tile")]
        public bool? Windows80Ie10Tile { get; set; }

        [JsonProperty("windows_10_ie_11_edge_tiles")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeWindowsTypeAssetsTypeWindows10Ie11EdgeTilesType Windows10Ie11EdgeTiles { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeWindowsTypeAssetsTypeWindows10Ie11EdgeTilesType
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

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeFirefoxAppType
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
        public BodyInputFaviconGenerationTypeFaviconDesignTypeFirefoxAppTypeManifestType Manifest { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeFirefoxAppTypeManifestType
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

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeAndroidChromeType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("manifest")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeAndroidChromeTypeManifestType Manifest { get; set; }

        [JsonProperty("assets")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeAndroidChromeTypeAssetsType Assets { get; set; }

        [JsonProperty("theme_color")]
        public string ThemeColor { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeAndroidChromeTypeManifestType
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

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeAndroidChromeTypeAssetsType
    {
        [JsonProperty("legacy_icon")]
        public bool? LegacyIcon { get; set; }

        [JsonProperty("low_resolution_icons")]
        public bool? LowResolutionIcons { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeSafariPinnedTabType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("threshold")]
        public int? Threshold { get; set; }

        [JsonProperty("theme_color")]
        public string ThemeColor { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeCoastType
    {
        [JsonProperty("picture_aspect")]
        public string PictureAspect { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("margin")]
        public string Margin { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeOpenGraphType
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

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeYandexBrowserType
    {
        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("manifest")]
        public BodyInputFaviconGenerationTypeFaviconDesignTypeYandexBrowserTypeManifestType Manifest { get; set; }
    }

    public class BodyInputFaviconGenerationTypeFaviconDesignTypeYandexBrowserTypeManifestType
    {
        [JsonProperty("show_title")]
        public bool? ShowTitle { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class BodyInputFaviconGenerationTypeSettingsType
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

    public class BodyInputFaviconGenerationTypeVersioningType
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