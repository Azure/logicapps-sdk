//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gsasitescanning
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GsasitescanningActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gsasitescanning")]
        public IBodyWorkflowAction<AnalysisDto> AnalysisControllerGetResults(Expression<Func<string>> targetUrlDomain = null, Expression<Func<string>> finalUrlDomain = null, Expression<Func<bool>> finalUrlLive = null, Expression<Func<bool>> targetUrlRedirects = null, Expression<Func<string>> targetUrlAgencyOwner = null, Expression<Func<string>> targetUrlBureauOwner = null, Expression<Func<primaryScanStatusInput>> primaryScanStatus = null, Expression<Func<bool>> dapDetectedFinalUrl = null)
        {
            var __workflow_targetUrlDomain = WorkflowExpression.Compile(targetUrlDomain, nameof(targetUrlDomain), required: false);
            var __workflow_finalUrlDomain = WorkflowExpression.Compile(finalUrlDomain, nameof(finalUrlDomain), required: false);
            var __workflow_finalUrlLive = WorkflowExpression.Compile(finalUrlLive, nameof(finalUrlLive), required: false);
            var __workflow_targetUrlRedirects = WorkflowExpression.Compile(targetUrlRedirects, nameof(targetUrlRedirects), required: false);
            var __workflow_targetUrlAgencyOwner = WorkflowExpression.Compile(targetUrlAgencyOwner, nameof(targetUrlAgencyOwner), required: false);
            var __workflow_targetUrlBureauOwner = WorkflowExpression.Compile(targetUrlBureauOwner, nameof(targetUrlBureauOwner), required: false);
            var __workflow_primaryScanStatus = WorkflowExpression.Compile(primaryScanStatus, nameof(primaryScanStatus), required: false);
            var __workflow_dapDetectedFinalUrl = WorkflowExpression.Compile(dapDetectedFinalUrl, nameof(dapDetectedFinalUrl), required: false);
            return new DeferredBodyAction<AnalysisDto>(() =>
            {
                var apiCallPath = "/analysis";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_targetUrlDomain != null)
                    callPayload.Queries["target_url_domain"] = ExpressionConverter.Convert(__workflow_targetUrlDomain);
                if (__workflow_finalUrlDomain != null)
                    callPayload.Queries["final_url_domain"] = ExpressionConverter.Convert(__workflow_finalUrlDomain);
                if (__workflow_finalUrlLive != null)
                    callPayload.Queries["final_url_live"] = ExpressionConverter.Convert(__workflow_finalUrlLive);
                if (__workflow_targetUrlRedirects != null)
                    callPayload.Queries["target_url_redirects"] = ExpressionConverter.Convert(__workflow_targetUrlRedirects);
                if (__workflow_targetUrlAgencyOwner != null)
                    callPayload.Queries["target_url_agency_owner"] = ExpressionConverter.Convert(__workflow_targetUrlAgencyOwner);
                if (__workflow_targetUrlBureauOwner != null)
                    callPayload.Queries["target_url_bureau_owner"] = ExpressionConverter.Convert(__workflow_targetUrlBureauOwner);
                if (__workflow_primaryScanStatus != null)
                    callPayload.Queries["primary_scan_status"] = ExpressionConverter.Convert(__workflow_primaryScanStatus);
                if (__workflow_dapDetectedFinalUrl != null)
                    callPayload.Queries["dap_detected_final_url"] = ExpressionConverter.Convert(__workflow_dapDetectedFinalUrl);
                return new ApiConnectionAction<AnalysisDto>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gsasitescanning")]
        public IBodyWorkflowAction<PaginatedWebsiteResponseDto> WebsiteControllerGetResults(Expression<Func<string>> targetUrlDomain = null, Expression<Func<string>> finalUrlDomain = null, Expression<Func<bool>> finalUrlLive = null, Expression<Func<bool>> targetUrlRedirects = null, Expression<Func<string>> targetUrlAgencyOwner = null, Expression<Func<string>> targetUrlBureauOwner = null, Expression<Func<primaryScanStatusInput>> primaryScanStatus = null, Expression<Func<bool>> dapDetectedFinalUrl = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null)
        {
            var __workflow_targetUrlDomain = WorkflowExpression.Compile(targetUrlDomain, nameof(targetUrlDomain), required: false);
            var __workflow_finalUrlDomain = WorkflowExpression.Compile(finalUrlDomain, nameof(finalUrlDomain), required: false);
            var __workflow_finalUrlLive = WorkflowExpression.Compile(finalUrlLive, nameof(finalUrlLive), required: false);
            var __workflow_targetUrlRedirects = WorkflowExpression.Compile(targetUrlRedirects, nameof(targetUrlRedirects), required: false);
            var __workflow_targetUrlAgencyOwner = WorkflowExpression.Compile(targetUrlAgencyOwner, nameof(targetUrlAgencyOwner), required: false);
            var __workflow_targetUrlBureauOwner = WorkflowExpression.Compile(targetUrlBureauOwner, nameof(targetUrlBureauOwner), required: false);
            var __workflow_primaryScanStatus = WorkflowExpression.Compile(primaryScanStatus, nameof(primaryScanStatus), required: false);
            var __workflow_dapDetectedFinalUrl = WorkflowExpression.Compile(dapDetectedFinalUrl, nameof(dapDetectedFinalUrl), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<PaginatedWebsiteResponseDto>(() =>
            {
                var apiCallPath = "/websites";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_targetUrlDomain != null)
                    callPayload.Queries["target_url_domain"] = ExpressionConverter.Convert(__workflow_targetUrlDomain);
                if (__workflow_finalUrlDomain != null)
                    callPayload.Queries["final_url_domain"] = ExpressionConverter.Convert(__workflow_finalUrlDomain);
                if (__workflow_finalUrlLive != null)
                    callPayload.Queries["final_url_live"] = ExpressionConverter.Convert(__workflow_finalUrlLive);
                if (__workflow_targetUrlRedirects != null)
                    callPayload.Queries["target_url_redirects"] = ExpressionConverter.Convert(__workflow_targetUrlRedirects);
                if (__workflow_targetUrlAgencyOwner != null)
                    callPayload.Queries["target_url_agency_owner"] = ExpressionConverter.Convert(__workflow_targetUrlAgencyOwner);
                if (__workflow_targetUrlBureauOwner != null)
                    callPayload.Queries["target_url_bureau_owner"] = ExpressionConverter.Convert(__workflow_targetUrlBureauOwner);
                if (__workflow_primaryScanStatus != null)
                    callPayload.Queries["primary_scan_status"] = ExpressionConverter.Convert(__workflow_primaryScanStatus);
                if (__workflow_dapDetectedFinalUrl != null)
                    callPayload.Queries["dap_detected_final_url"] = ExpressionConverter.Convert(__workflow_dapDetectedFinalUrl);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<PaginatedWebsiteResponseDto>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gsasitescanning")]
        public IBodyWorkflowAction<WebsiteApiResultDto> WebsiteControllerGetResultByUrl(Expression<Func<string>> url)
        {
            var __workflow_url = WorkflowExpression.Compile(url, nameof(url), required: true);
            return new DeferredBodyAction<WebsiteApiResultDto>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/websites/{0}", __workflow_url.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WebsiteApiResultDto>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }
    }

    public class GsasitescanningTriggers([ConnectionName] string connectionId)
    {
    }

    public class AnalysisDto
    {
        [JsonProperty("total")]
        public double TotalAnalyzedItems { get; set; }

        [JsonProperty("totalAgencies")]
        public double TotalAgenciesAnalyzed { get; set; }

        [JsonProperty("totalFinalUrlBaseDomains")]
        public double TotalFinalURLBaseDomains { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum primaryScanStatusInput
    {
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "timeout")]
        Timeout,
        [EnumMember(Value = "dns_resolution_error")]
        DnsResolutionError,
        [EnumMember(Value = "unknown_error")]
        UnknownError,
        [EnumMember(Value = "invalid_ssl_cert")]
        InvalidSslCert,
        [EnumMember(Value = "connection_refused")]
        ConnectionRefused,
        [EnumMember(Value = "connection_reset")]
        ConnectionReset
    }

    public class PaginatedWebsiteResponseDto
    {
        [JsonProperty("items")]
        public WebsiteApiResultDto[] WebsiteItems { get; set; }

        [JsonProperty("links")]
        public PaginatedWebsiteResponseDtoPaginationLinksType PaginationLinks { get; set; }

        [JsonProperty("meta")]
        public PaginatedWebsiteResponseDtoPaginationMetadataType PaginationMetadata { get; set; }
    }

    public class WebsiteApiResultDto
    {
        [JsonProperty("canonical_link")]
        public string CanonicalLink { get; set; }

        [JsonProperty("cloud_dot_gov_pages")]
        public bool CloudGovPagesHosting { get; set; }

        [JsonProperty("cms")]
        public string ContentManagementSystemCMS { get; set; }

        [JsonProperty("dap_detected_final_url")]
        public bool DAPDetectedAtFinalURL { get; set; }

        [JsonProperty("dap_parameters_final_url")]
        public JToken DAPParametersAtFinalURL { get; set; }

        [JsonProperty("dns_hostname")]
        public string DNSHostname { get; set; }

        [JsonProperty("final_url")]
        public string FinalURL { get; set; }

        [JsonProperty("final_url_MIMEType")]
        public string FinalURLMIMEType { get; set; }

        [JsonProperty("final_url_domain")]
        public string FinalURLDomain { get; set; }

        [JsonProperty("final_url_live")]
        public bool FinalURLLive { get; set; }

        [JsonProperty("final_url_same_domain")]
        public bool FinalURLSameDomain { get; set; }

        [JsonProperty("final_url_same_website")]
        public bool FinalURLSameWebsite { get; set; }

        [JsonProperty("final_url_status_code")]
        public double FinalURLStatusCode { get; set; }

        [JsonProperty("final_url_website")]
        public string FinalURLWebsite { get; set; }

        [JsonProperty("main_element_present_final_url")]
        public bool MainElementPresenceAtFinalURL { get; set; }

        [JsonProperty("og_article_modified_final_url")]
        public string OpenGraphArticleModifiedDateAtFinalURL { get; set; }

        [JsonProperty("og_article_published_final_url")]
        public string OpenGraphArticlePublishedDateAtFinalURL { get; set; }

        [JsonProperty("og_description_final_url")]
        public string OpenGraphDescriptionAtFinalURL { get; set; }

        [JsonProperty("og_title_final_url")]
        public string OpenGraphTitleAtFinalURL { get; set; }

        [JsonProperty("robots_txt_crawl_delay")]
        public int RobotsTxtCrawlDelay { get; set; }

        [JsonProperty("robots_txt_detected")]
        public bool RobotsTxtDetected { get; set; }

        [JsonProperty("robots_txt_final_url")]
        public string RobotsTxtFinalURL { get; set; }

        [JsonProperty("robots_txt_final_url_MIMETYPE")]
        public string RobotsTxtFinalURLMIMEType { get; set; }

        [JsonProperty("robots_txt_final_url_live")]
        public bool RobotsTxtFinalURLLive { get; set; }

        [JsonProperty("robots_txt_final_url_size_in_bytes")]
        public double RobotsTxtFinalURLSizeInBytes { get; set; }

        [JsonProperty("robots_txt_final_url_status_code")]
        public double RobotsTxtFinalURLStatusCode { get; set; }

        [JsonProperty("robots_txt_target_url_redirects")]
        public bool RobotsTxtTargetURLRedirects { get; set; }

        [JsonProperty("scan_date")]
        public string ScanDate { get; set; }

        [JsonProperty("primary_scan_status")]
        public WebsiteApiResultDtoScanStatusType ScanStatus { get; set; }

        [JsonProperty("sitemap_xml_count")]
        public int SitemapXmlURLCount { get; set; }

        [JsonProperty("sitemap_xml_detected")]
        public bool SitemapXmlDetected { get; set; }

        [JsonProperty("sitemap_xml_final_url")]
        public string SitemapXmlFinalURL { get; set; }

        [JsonProperty("sitemap_xml_final_url_MIMETYPE")]
        public string SitemapXmlFinalURLMIMEType { get; set; }

        [JsonProperty("sitemap_xml_final_url_filesize")]
        public int SitemapXmlFinalURLFilesize { get; set; }

        [JsonProperty("sitemap_xml_final_url_live")]
        public bool SitemapXmlFinalURLLive { get; set; }

        [JsonProperty("sitemap_xml_final_url_status_code")]
        public double SitemapXmlFinalURLStatusCode { get; set; }

        [JsonProperty("sitemap_xml_pdf_count")]
        public int SitemapXmlPDFURLCount { get; set; }

        [JsonProperty("sitemap_xml_target_url_redirects")]
        public bool SitemapXmlTargetURLRedirects { get; set; }

        [JsonProperty("source_list_dap")]
        public bool SourcedFromDAPList { get; set; }

        [JsonProperty("source_list_federal_domains")]
        public bool SourcedFromFederalDomainsList { get; set; }

        [JsonProperty("source_list_other")]
        public bool SourcedFromOtherLists { get; set; }

        [JsonProperty("source_list_pulse")]
        public bool SourcedFromPulseCIOList { get; set; }

        [JsonProperty("target_url")]
        public string TargetURL { get; set; }

        [JsonProperty("target_url_404_test")]
        public bool TargetURL404Test { get; set; }

        [JsonProperty("target_url_agency_owner")]
        public string TargetURLAgencyOwner { get; set; }

        [JsonProperty("target_url_branch")]
        public string TargetURLGovernmentBranch { get; set; }

        [JsonProperty("target_url_bureau_owner")]
        public string TargetURLBureauOwner { get; set; }

        [JsonProperty("target_url_domain")]
        public string TargetURLDomain { get; set; }

        [JsonProperty("target_url_redirects")]
        public bool TargetURLRedirects { get; set; }

        [JsonProperty("third_party_service_count")]
        public double ThirdPartyServiceCount { get; set; }

        [JsonProperty("third_party_service_domains")]
        public string[] ThirdPartyServiceDomains { get; set; }

        [JsonProperty("uswds_count")]
        public double USWDSCount { get; set; }

        [JsonProperty("uswds_favicon")]
        public double USWDSFavicon { get; set; }

        [JsonProperty("uswds_favicon_in_css")]
        public double USWDSFaviconInCSS { get; set; }

        [JsonProperty("uswds_inline_css")]
        public double USWDSInlineCSS { get; set; }

        [JsonProperty("uswds_publicsans_font")]
        public double USWDSPublicSansFont { get; set; }

        [JsonProperty("uswds_semantic_version")]
        public string USWDSSemanticVersion { get; set; }

        [JsonProperty("uswds_source_sans_font")]
        public double USWDSSourceSansFont { get; set; }

        [JsonProperty("uswds_string")]
        public double USWDSStringOccurrences { get; set; }

        [JsonProperty("uswds_string_in_css")]
        public double USWDSStringInCSS { get; set; }

        [JsonProperty("uswds_tables")]
        public double USWDSTables { get; set; }

        [JsonProperty("uswds_usa_classes")]
        public double USWDSUSAClasses { get; set; }

        [JsonProperty("uswds_version")]
        public double USWDSVersion { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WebsiteApiResultDtoScanStatusType
    {
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "timeout")]
        Timeout,
        [EnumMember(Value = "dns_resolution_error")]
        DnsResolutionError,
        [EnumMember(Value = "unknown_error")]
        UnknownError,
        [EnumMember(Value = "invalid_ssl_cert")]
        InvalidSslCert,
        [EnumMember(Value = "connection_refused")]
        ConnectionRefused,
        [EnumMember(Value = "connection_reset")]
        ConnectionReset
    }

    public class PaginatedWebsiteResponseDtoPaginationLinksType
    {
        [JsonProperty("first")]
        public string FirstPageLink { get; set; }

        [JsonProperty("last")]
        public string LastPageLink { get; set; }

        [JsonProperty("next")]
        public string NextPageLink { get; set; }

        [JsonProperty("previous")]
        public string PreviousPageLink { get; set; }
    }

    public class PaginatedWebsiteResponseDtoPaginationMetadataType
    {
        [JsonProperty("currentPage")]
        public double CurrentPage { get; set; }

        [JsonProperty("itemCount")]
        public double ItemCount { get; set; }

        [JsonProperty("itemsPerPage")]
        public double ItemsPerPage { get; set; }

        [JsonProperty("totalItems")]
        public double TotalItems { get; set; }

        [JsonProperty("totalPages")]
        public double TotalPages { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gsasitescanning;

    public partial class WorkflowManagedActions
    {
        public GsasitescanningActions Gsasitescanning(string connectionId) => new GsasitescanningActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GsasitescanningTriggers Gsasitescanning(string connectionId) => new GsasitescanningTriggers(connectionId);
    }
}
