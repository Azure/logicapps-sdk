//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Whatismybrowserip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WhatismybrowseripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whatismybrowserip")]
        public IBodyWorkflowAction<DetectPostResponse> Detect([WorkflowExpression] Func<bodyheadersInputItem[]> bodyheaders = null)
        {
            var apiCallPath = "/detect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyheaders != null)
            {
                body["headers"] = ExpressionConverter.ConvertO(bodyheaders);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DetectPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "whatismybrowserip")]
        public IBodyWorkflowAction<VersionGetResponse> VersionGet()
        {
            var apiCallPath = "/version_numbers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VersionGetResponse>(callPayload);
        }
    }

    public class WhatismybrowseripTriggers([ConnectionName] string connectionId)
    {
    }

    public class DetectPostResponse
    {
        [JsonProperty("detection")]
        public DetectPostResponseDetectionType Detection { get; set; }

        [JsonProperty("version_check")]
        public DetectPostResponseVersionCheckType VersionCheck { get; set; }

        [JsonProperty("risks")]
        public DetectPostResponseRisksType Risks { get; set; }

        [JsonProperty("result")]
        public DetectPostResponseResultType Result { get; set; }
    }

    public class DetectPostResponseDetectionType
    {
        [JsonProperty("simple_software_string")]
        public string SimpleSoftwareString { get; set; }

        [JsonProperty("simple_sub_description_string")]
        public string SimpleSubDescriptionString { get; set; }

        [JsonProperty("simple_operating_platform_string")]
        public string SimpleOperatingPlatformString { get; set; }

        [JsonProperty("software")]
        public string Software { get; set; }

        [JsonProperty("software_name")]
        public string SoftwareName { get; set; }

        [JsonProperty("software_name_code")]
        public string SoftwareNameCode { get; set; }

        [JsonProperty("software_version")]
        public string SoftwareVersion { get; set; }

        [JsonProperty("software_version_full")]
        public string[] SoftwareVersionFull { get; set; }

        [JsonProperty("operating_system")]
        public string OperatingSystem { get; set; }

        [JsonProperty("operating_system_name")]
        public string OperatingSystemName { get; set; }

        [JsonProperty("operating_system_name_code")]
        public string OperatingSystemNameCode { get; set; }

        [JsonProperty("operating_system_flavour")]
        public string OperatingSystemFlavour { get; set; }

        [JsonProperty("operating_system_version")]
        public string OperatingSystemVersion { get; set; }

        [JsonProperty("operating_system_version_full")]
        public string[] OperatingSystemVersionFull { get; set; }

        [JsonProperty("operating_platform")]
        public string OperatingPlatform { get; set; }

        [JsonProperty("operating_platform_code")]
        public string OperatingPlatformCode { get; set; }

        [JsonProperty("operating_platform_code_name")]
        public string OperatingPlatformCodeName { get; set; }

        [JsonProperty("operating_platform_vendor_name")]
        public string OperatingPlatformVendorName { get; set; }

        [JsonProperty("extra_info")]
        public JToken ExtraInfo { get; set; }

        [JsonProperty("extra_info_dict")]
        public JToken ExtraInfoDict { get; set; }

        [JsonProperty("capabilities")]
        public string[] Capabilities { get; set; }

        [JsonProperty("layout_engine_name")]
        public string LayoutEngineName { get; set; }

        [JsonProperty("software_type")]
        public string SoftwareType { get; set; }

        [JsonProperty("software_sub_type")]
        public string SoftwareSubType { get; set; }

        [JsonProperty("hardware_type")]
        public string HardwareType { get; set; }

        [JsonProperty("hardware_sub_type")]
        public string HardwareSubType { get; set; }

        [JsonProperty("hardware_sub_sub_type")]
        public string HardwareSubSubType { get; set; }
    }

    public class DetectPostResponseVersionCheckType
    {
        [JsonProperty("software_version_check")]
        public DetectPostResponseVersionCheckTypeSoftwareVersionCheckType SoftwareVersionCheck { get; set; }
    }

    public class DetectPostResponseVersionCheckTypeSoftwareVersionCheckType
    {
        [JsonProperty("is_checkable")]
        public bool IsCheckable { get; set; }

        [JsonProperty("is_up_to_date")]
        public bool IsUpToDate { get; set; }

        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("hours_released_ago")]
        public int HoursReleasedAgo { get; set; }
    }

    public class DetectPostResponseRisksType
    {
        [JsonProperty("user_agent_risks")]
        public string[] UserAgentRisks { get; set; }

        [JsonProperty("client_hints_risks")]
        public string[] ClientHintsRisks { get; set; }
    }

    public class DetectPostResponseResultType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message_code")]
        public string MessageCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class bodyheadersInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class VersionGetResponse
    {
        [JsonProperty("version_data")]
        public VersionGetResponseVersionDataType VersionData { get; set; }

        [JsonProperty("result")]
        public VersionGetResponseResultType Result { get; set; }
    }

    public class VersionGetResponseVersionDataType
    {
        [JsonProperty("software")]
        public VersionGetResponseVersionDataTypeSoftwareType Software { get; set; }

        [JsonProperty("operating_system")]
        public VersionGetResponseVersionDataTypeOperatingSystemType OperatingSystem { get; set; }

        [JsonProperty("plugin")]
        public VersionGetResponseVersionDataTypePluginType Plugin { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareType
    {
        [JsonProperty("firefox")]
        public VersionGetResponseVersionDataTypeSoftwareTypeFirefoxType Firefox { get; set; }

        [JsonProperty("firefox-esr")]
        public VersionGetResponseVersionDataTypeSoftwareTypeFirefoxEsrType FirefoxEsr { get; set; }

        [JsonProperty("opera")]
        public VersionGetResponseVersionDataTypeSoftwareTypeOperaType Opera { get; set; }

        [JsonProperty("internet-explorer")]
        public VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerType InternetExplorer { get; set; }

        [JsonProperty("chrome")]
        public VersionGetResponseVersionDataTypeSoftwareTypeChromeType Chrome { get; set; }

        [JsonProperty("edge")]
        public VersionGetResponseVersionDataTypeSoftwareTypeEdgeType Edge { get; set; }

        [JsonProperty("safari")]
        public VersionGetResponseVersionDataTypeSoftwareTypeSafariType Safari { get; set; }

        [JsonProperty("vivaldi")]
        public VersionGetResponseVersionDataTypeSoftwareTypeVivaldiType Vivaldi { get; set; }

        [JsonProperty("yandex-browser")]
        public VersionGetResponseVersionDataTypeSoftwareTypeYandexBrowserType YandexBrowser { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeFirefoxType
    {
        [JsonProperty("standard")]
        public VersionGetResponseVersionDataTypeSoftwareTypeFirefoxTypeStandardType Standard { get; set; }

        [JsonProperty("android")]
        public VersionGetResponseVersionDataTypeSoftwareTypeFirefoxTypeAndroidType Android { get; set; }

        [JsonProperty("ios")]
        public VersionGetResponseVersionDataTypeSoftwareTypeFirefoxTypeIosType Ios { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeFirefoxTypeStandardType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeFirefoxTypeAndroidType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeFirefoxTypeIosType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeFirefoxEsrType
    {
        [JsonProperty("standard")]
        public VersionGetResponseVersionDataTypeSoftwareTypeFirefoxEsrTypeStandardType Standard { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeFirefoxEsrTypeStandardType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeOperaType
    {
        [JsonProperty("standard")]
        public VersionGetResponseVersionDataTypeSoftwareTypeOperaTypeStandardType Standard { get; set; }

        [JsonProperty("android")]
        public VersionGetResponseVersionDataTypeSoftwareTypeOperaTypeAndroidType Android { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeOperaTypeStandardType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeOperaTypeAndroidType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerType
    {
        [JsonProperty("internet-explorer-xp")]
        public VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerXpType InternetExplorerXp { get; set; }

        [JsonProperty("internet-explorer-vista")]
        public VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerVistaType InternetExplorerVista { get; set; }

        [JsonProperty("internet-explorer-windows-7")]
        public VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerWindows7Type InternetExplorerWindows7 { get; set; }

        [JsonProperty("internet-explorer-windows-8")]
        public VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerWindows8Type InternetExplorerWindows8 { get; set; }

        [JsonProperty("internet-explorer-windows-8-1")]
        public VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerWindows81Type InternetExplorerWindows81 { get; set; }

        [JsonProperty("internet-explorer-windows-10")]
        public VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerWindows10Type InternetExplorerWindows10 { get; set; }

        [JsonProperty("internet-explorer")]
        public VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerType InternetExplorer { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerXpType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerVistaType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerWindows7Type
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerWindows8Type
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerWindows81Type
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerWindows10Type
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeInternetExplorerTypeInternetExplorerType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeChromeType
    {
        [JsonProperty("windows")]
        public VersionGetResponseVersionDataTypeSoftwareTypeChromeTypeWindowsType Windows { get; set; }

        [JsonProperty("macos")]
        public VersionGetResponseVersionDataTypeSoftwareTypeChromeTypeMacosType Macos { get; set; }

        [JsonProperty("linux")]
        public VersionGetResponseVersionDataTypeSoftwareTypeChromeTypeLinuxType Linux { get; set; }

        [JsonProperty("android")]
        public VersionGetResponseVersionDataTypeSoftwareTypeChromeTypeAndroidType Android { get; set; }

        [JsonProperty("ios")]
        public VersionGetResponseVersionDataTypeSoftwareTypeChromeTypeIosType Ios { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeChromeTypeWindowsType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeChromeTypeMacosType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeChromeTypeLinuxType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeChromeTypeAndroidType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeChromeTypeIosType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeEdgeType
    {
        [JsonProperty("windows")]
        public VersionGetResponseVersionDataTypeSoftwareTypeEdgeTypeWindowsType Windows { get; set; }

        [JsonProperty("ios")]
        public VersionGetResponseVersionDataTypeSoftwareTypeEdgeTypeIosType Ios { get; set; }

        [JsonProperty("macos")]
        public VersionGetResponseVersionDataTypeSoftwareTypeEdgeTypeMacosType Macos { get; set; }

        [JsonProperty("android")]
        public VersionGetResponseVersionDataTypeSoftwareTypeEdgeTypeAndroidType Android { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeEdgeTypeWindowsType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeEdgeTypeIosType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeEdgeTypeMacosType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeEdgeTypeAndroidType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeSafariType
    {
        [JsonProperty("macos")]
        public VersionGetResponseVersionDataTypeSoftwareTypeSafariTypeMacosType Macos { get; set; }

        [JsonProperty("ios")]
        public VersionGetResponseVersionDataTypeSoftwareTypeSafariTypeIosType Ios { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeSafariTypeMacosType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeSafariTypeIosType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeVivaldiType
    {
        [JsonProperty("standard")]
        public VersionGetResponseVersionDataTypeSoftwareTypeVivaldiTypeStandardType Standard { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeVivaldiTypeStandardType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeYandexBrowserType
    {
        [JsonProperty("windows")]
        public VersionGetResponseVersionDataTypeSoftwareTypeYandexBrowserTypeWindowsType Windows { get; set; }

        [JsonProperty("ios")]
        public VersionGetResponseVersionDataTypeSoftwareTypeYandexBrowserTypeIosType Ios { get; set; }

        [JsonProperty("android")]
        public VersionGetResponseVersionDataTypeSoftwareTypeYandexBrowserTypeAndroidType Android { get; set; }

        [JsonProperty("macos")]
        public VersionGetResponseVersionDataTypeSoftwareTypeYandexBrowserTypeMacosType Macos { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeYandexBrowserTypeWindowsType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeYandexBrowserTypeIosType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeYandexBrowserTypeAndroidType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeSoftwareTypeYandexBrowserTypeMacosType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeOperatingSystemType
    {
        [JsonProperty("chrome-os")]
        public VersionGetResponseVersionDataTypeOperatingSystemTypeChromeOsType ChromeOs { get; set; }

        [JsonProperty("macos")]
        public VersionGetResponseVersionDataTypeOperatingSystemTypeMacosType Macos { get; set; }

        [JsonProperty("ios")]
        public VersionGetResponseVersionDataTypeOperatingSystemTypeIosType Ios { get; set; }

        [JsonProperty("windows")]
        public VersionGetResponseVersionDataTypeOperatingSystemTypeWindowsType Windows { get; set; }

        [JsonProperty("android")]
        public VersionGetResponseVersionDataTypeOperatingSystemTypeAndroidType Android { get; set; }
    }

    public class VersionGetResponseVersionDataTypeOperatingSystemTypeChromeOsType
    {
        [JsonProperty("standard")]
        public VersionGetResponseVersionDataTypeOperatingSystemTypeChromeOsTypeStandardType Standard { get; set; }
    }

    public class VersionGetResponseVersionDataTypeOperatingSystemTypeChromeOsTypeStandardType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("platform_version")]
        public string[] PlatformVersion { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeOperatingSystemTypeMacosType
    {
        [JsonProperty("standard")]
        public VersionGetResponseVersionDataTypeOperatingSystemTypeMacosTypeStandardType Standard { get; set; }
    }

    public class VersionGetResponseVersionDataTypeOperatingSystemTypeMacosTypeStandardType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeOperatingSystemTypeIosType
    {
        [JsonProperty("standard")]
        public VersionGetResponseVersionDataTypeOperatingSystemTypeIosTypeStandardType Standard { get; set; }
    }

    public class VersionGetResponseVersionDataTypeOperatingSystemTypeIosTypeStandardType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("update_url")]
        public string UpdateUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeOperatingSystemTypeWindowsType
    {
        [JsonProperty("standard")]
        public VersionGetResponseVersionDataTypeOperatingSystemTypeWindowsTypeStandardType Standard { get; set; }
    }

    public class VersionGetResponseVersionDataTypeOperatingSystemTypeWindowsTypeStandardType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("build")]
        public string[] Build { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypeOperatingSystemTypeAndroidType
    {
        [JsonProperty("standard")]
        public VersionGetResponseVersionDataTypeOperatingSystemTypeAndroidTypeStandardType Standard { get; set; }
    }

    public class VersionGetResponseVersionDataTypeOperatingSystemTypeAndroidTypeStandardType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypePluginType
    {
        [JsonProperty("flash")]
        public VersionGetResponseVersionDataTypePluginTypeFlashType Flash { get; set; }

        [JsonProperty("java")]
        public VersionGetResponseVersionDataTypePluginTypeJavaType Java { get; set; }
    }

    public class VersionGetResponseVersionDataTypePluginTypeFlashType
    {
        [JsonProperty("standard")]
        public VersionGetResponseVersionDataTypePluginTypeFlashTypeStandardType Standard { get; set; }

        [JsonProperty("android")]
        public VersionGetResponseVersionDataTypePluginTypeFlashTypeAndroidType Android { get; set; }
    }

    public class VersionGetResponseVersionDataTypePluginTypeFlashTypeStandardType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("update")]
        public string Update { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypePluginTypeFlashTypeAndroidType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("update")]
        public string Update { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseVersionDataTypePluginTypeJavaType
    {
        [JsonProperty("standard")]
        public VersionGetResponseVersionDataTypePluginTypeJavaTypeStandardType Standard { get; set; }
    }

    public class VersionGetResponseVersionDataTypePluginTypeJavaTypeStandardType
    {
        [JsonProperty("latest_version")]
        public string[] LatestVersion { get; set; }

        [JsonProperty("update")]
        public string Update { get; set; }

        [JsonProperty("download_url")]
        public string DownloadUrl { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }
    }

    public class VersionGetResponseResultType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message_code")]
        public string MessageCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Whatismybrowserip;

    public partial class WorkflowManagedActions
    {
        public WhatismybrowseripActions Whatismybrowserip(string connectionId) => new WhatismybrowseripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WhatismybrowseripTriggers Whatismybrowserip(string connectionId) => new WhatismybrowseripTriggers(connectionId);
    }
}