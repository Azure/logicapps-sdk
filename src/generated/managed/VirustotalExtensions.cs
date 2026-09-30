//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Virustotal
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VirustotalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "virustotal")]
        public IBodyWorkflowAction<UrlResult> VirusTotalGetUrlReport([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/urls/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UrlResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "virustotal")]
        public IBodyWorkflowAction<DomainResult> VirusTotalGetDomainReport([WorkflowExpression] Func<string> domain)
        {
            SourceExpression.Validate(domain, nameof(domain), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/domains/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domain, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DomainResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "virustotal")]
        public IBodyWorkflowAction<Ip> VirusTotalGetIpScanV3([WorkflowExpression] Func<string> ip)
        {
            SourceExpression.Validate(ip, nameof(ip), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/ip_addresses/connectorV2/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(ip, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Ip>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "virustotal")]
        public IBodyWorkflowAction<Analyses> VirusTotalRetrieveInfo([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/analyses/connectorV2/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Analyses>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "virustotal")]
        public IBodyWorkflowAction<File> VirusTotalRetrieveInfoaboutFile([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/files/connectorV2/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<File>(BuildSourceInput);
        }
    }

    public class VirustotalTriggers([ConnectionName] string connectionId)
    {
    }

    public class UrlResult
    {
        [JsonProperty("data")]
        public UrlResultDataType Data { get; set; }
    }

    public class UrlResultDataType
    {
        [JsonProperty("attributes")]
        public UrlResultDataTypeAttributesType Attributes { get; set; }
    }

    public class UrlResultDataTypeAttributesType
    {
        [JsonProperty("categories")]
        public JToken Categories { get; set; }

        [JsonProperty("first_submission_date")]
        public int FirstSubmissionDate { get; set; }

        [JsonProperty("html_meta")]
        public JToken HTMLMetaTags { get; set; }

        [JsonProperty("last_analysis_date")]
        public int LastAnalysisDate { get; set; }

        [JsonProperty("last_analysis_results")]
        public JToken LastAnalysisResults { get; set; }

        [JsonProperty("last_analysis_stats")]
        public UrlResultDataTypeAttributesTypeLastAnalysisStatisticsType LastAnalysisStatistics { get; set; }

        [JsonProperty("last_final_url")]
        public string LastFinalUrl { get; set; }

        [JsonProperty("last_http_response_code")]
        public int LastHTTPResponseCode { get; set; }

        [JsonProperty("last_http_response_content_length")]
        public int LastHTTPResponseContentLength { get; set; }

        [JsonProperty("last_http_response_content_sha256")]
        public string LastHTTPResponseContentSHA256 { get; set; }

        [JsonProperty("last_http_response_cookies")]
        public JToken LastHTTPResponseCookies { get; set; }

        [JsonProperty("last_http_response_headers")]
        public JToken LastHTTPResponseHeaders { get; set; }

        [JsonProperty("last_modification_date")]
        public int LastModificationDate { get; set; }

        [JsonProperty("last_submission_date")]
        public int LastSubmissionDate { get; set; }

        [JsonProperty("outgoing_links")]
        public JToken[] OutgoingLinks { get; set; }

        [JsonProperty("reputation")]
        public int Reputation { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("targeted_brand")]
        public JToken TargetedBrand { get; set; }

        [JsonProperty("times_submitted")]
        public int TimesSubmitted { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("total_votes")]
        public UrlResultDataTypeAttributesTypeTotalVotesType TotalVotes { get; set; }

        [JsonProperty("trackers")]
        public JToken Trackers { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public class UrlResultDataTypeAttributesTypeLastAnalysisStatisticsType
    {
        [JsonProperty("harmless")]
        public int Harmless { get; set; }

        [JsonProperty("malicious")]
        public int Malicious { get; set; }

        [JsonProperty("suspicious")]
        public int Suspicious { get; set; }

        [JsonProperty("timeout")]
        public int Timeout { get; set; }

        [JsonProperty("undetected")]
        public int Undetected { get; set; }
    }

    public class UrlResultDataTypeAttributesTypeTotalVotesType
    {
        [JsonProperty("harmless")]
        public int Harmless { get; set; }

        [JsonProperty("malicious")]
        public int Malicious { get; set; }
    }

    public class DomainResult
    {
        [JsonProperty("data")]
        public DomainResultDataType Data { get; set; }
    }

    public class DomainResultDataType
    {
        [JsonProperty("attributes")]
        public DomainResultDataTypeAttributesType Attributes { get; set; }
    }

    public class DomainResultDataTypeAttributesType
    {
        [JsonProperty("categories")]
        public JToken Categories { get; set; }

        [JsonProperty("creation_date")]
        public int CreationDate { get; set; }

        [JsonProperty("last_analysis_results")]
        public JToken LastAnalysisResults { get; set; }

        [JsonProperty("last_analysis_stats")]
        public DomainResultDataTypeAttributesTypeLastAnalysisStatisticsType LastAnalysisStatistics { get; set; }

        [JsonProperty("last_dns_records")]
        public JToken[] LastDNSRecords { get; set; }

        [JsonProperty("last_dns_records_date")]
        public int LastDNSRecordsDate { get; set; }

        [JsonProperty("last_https_certificate")]
        public JToken LastHTTPSCertificate { get; set; }

        [JsonProperty("last_https_certificate_date")]
        public int LastHTTPSCertificateDate { get; set; }

        [JsonProperty("last_modification_date")]
        public int LastModificationDateFormat { get; set; }

        [JsonProperty("last_update_date")]
        public int LastUpdateDate { get; set; }

        [JsonProperty("popularity_ranks")]
        public JToken PopularityRanks { get; set; }

        [JsonProperty("registrar")]
        public string Registrar { get; set; }

        [JsonProperty("reputation")]
        public int Reputation { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("total_votes")]
        public DomainResultDataTypeAttributesTypeTotalVotesType TotalVotes { get; set; }

        [JsonProperty("whois")]
        public string WHOIS { get; set; }

        [JsonProperty("whois_date")]
        public int WHOISDate { get; set; }
    }

    public class DomainResultDataTypeAttributesTypeLastAnalysisStatisticsType
    {
        [JsonProperty("harmless")]
        public int Harmless { get; set; }

        [JsonProperty("malicious")]
        public int Malicious { get; set; }

        [JsonProperty("suspicious")]
        public int Suspicious { get; set; }

        [JsonProperty("timeout")]
        public int Timeout { get; set; }

        [JsonProperty("undetected")]
        public int Undetected { get; set; }
    }

    public class DomainResultDataTypeAttributesTypeTotalVotesType
    {
        [JsonProperty("harmless")]
        public int Harmless { get; set; }

        [JsonProperty("malicious")]
        public int Malicious { get; set; }
    }

    public class Ip
    {
        [JsonProperty("data")]
        public IpDataType Data { get; set; }
    }

    public class IpDataType
    {
        [JsonProperty("attributes")]
        public IpDataTypeAttributesType Attributes { get; set; }
    }

    public class IpDataTypeAttributesType
    {
        [JsonProperty("as_owner")]
        public string Owner { get; set; }

        [JsonProperty("asn")]
        public int ASN { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("last_analysis_results")]
        public JToken LastAnalysisResults { get; set; }

        [JsonProperty("last_analysis_stats")]
        public IpDataTypeAttributesTypeLastAnalysisStatisticsType LastAnalysisStatistics { get; set; }

        [JsonProperty("last_https_certificate")]
        public JToken LastHttpsCertificate { get; set; }

        [JsonProperty("last_https_certificate_date")]
        public int LastHttpsCertificateDate { get; set; }

        [JsonProperty("last_modification_date")]
        public int LastModificationDate { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("regional_internet_registry")]
        public string RegionalInternetRegistry { get; set; }

        [JsonProperty("reputation")]
        public int Reputation { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("total_votes")]
        public IpDataTypeAttributesTypeTotalVotesType TotalVotes { get; set; }

        [JsonProperty("whois")]
        public string WHOIS { get; set; }

        [JsonProperty("whois_date")]
        public int WHOISDate { get; set; }
    }

    public class IpDataTypeAttributesTypeLastAnalysisStatisticsType
    {
        [JsonProperty("harmless")]
        public int Harmless { get; set; }

        [JsonProperty("malicious")]
        public int Malicious { get; set; }

        [JsonProperty("suspicious")]
        public int Suspicious { get; set; }

        [JsonProperty("timeout")]
        public int Timeout { get; set; }

        [JsonProperty("undetected")]
        public int Undetected { get; set; }
    }

    public class IpDataTypeAttributesTypeTotalVotesType
    {
        [JsonProperty("harmless")]
        public int Harmless { get; set; }

        [JsonProperty("malicious")]
        public int Malicious { get; set; }
    }

    public class Analyses
    {
        [JsonProperty("data")]
        public AnalysesDataType Data { get; set; }
    }

    public class AnalysesDataType
    {
        [JsonProperty("attributes")]
        public AnalysesDataTypeAttributesType Attributes { get; set; }
    }

    public class AnalysesDataTypeAttributesType
    {
        [JsonProperty("date")]
        public int Date { get; set; }

        [JsonProperty("results")]
        public JToken Results { get; set; }

        [JsonProperty("stats")]
        public AnalysesDataTypeAttributesTypeStatisticsType Statistics { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class AnalysesDataTypeAttributesTypeStatisticsType
    {
        [JsonProperty("confirmed-timeout")]
        public int ConfirmedTimeout { get; set; }

        [JsonProperty("failure")]
        public int Failure { get; set; }

        [JsonProperty("harmless")]
        public int Harmless { get; set; }

        [JsonProperty("malicious")]
        public int Malicious { get; set; }

        [JsonProperty("suspicious")]
        public int Suspicious { get; set; }

        [JsonProperty("timeout")]
        public int Timeout { get; set; }

        [JsonProperty("type-unsupported")]
        public int TypeUnsupported { get; set; }

        [JsonProperty("undetected")]
        public int Undetected { get; set; }
    }

    public class File
    {
        [JsonProperty("data")]
        public FileDataType Data { get; set; }
    }

    public class FileDataType
    {
        [JsonProperty("attributes")]
        public FileDataTypeAttributesType Attributes { get; set; }
    }

    public class FileDataTypeAttributesType
    {
        [JsonProperty("authentihash")]
        public string AuthenticationHash { get; set; }

        [JsonProperty("creation_date")]
        public int CreationDate { get; set; }

        [JsonProperty("first_seen_itw_date")]
        public int FirstSeenITWDate { get; set; }

        [JsonProperty("first_submission_date")]
        public int FirstSubmissionDate { get; set; }

        [JsonProperty("last_analysis_date")]
        public int LastAnalysisDate { get; set; }

        [JsonProperty("last_analysis_results")]
        public JToken LastAnalysisResults { get; set; }

        [JsonProperty("last_analysis_stats")]
        public FileDataTypeAttributesTypeLastAnalysisStatisticsType LastAnalysisStatistics { get; set; }

        [JsonProperty("last_modification_date")]
        public int LastModificationDate { get; set; }

        [JsonProperty("last_submission_date")]
        public int LastSubmissionDate { get; set; }

        [JsonProperty("magic")]
        public string Magic { get; set; }

        [JsonProperty("md5")]
        public string MD5 { get; set; }

        [JsonProperty("meaningful_name")]
        public string MeaningfulName { get; set; }

        [JsonProperty("names")]
        public string[] Names { get; set; }

        [JsonProperty("pe_info")]
        public JToken PortableExecutable { get; set; }

        [JsonProperty("reputation")]
        public int Reputation { get; set; }

        [JsonProperty("sha1")]
        public string SHA1 { get; set; }

        [JsonProperty("sha256")]
        public string SHA256 { get; set; }

        [JsonProperty("signature_info")]
        public JToken SignatureInfo { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("ssdeep")]
        public string Ssdeep { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("times_submitted")]
        public int TimesSubmitted { get; set; }

        [JsonProperty("tlsh")]
        public string TLSH { get; set; }

        [JsonProperty("total_votes")]
        public FileDataTypeAttributesTypeTotalVotesType TotalVotes { get; set; }

        [JsonProperty("trid")]
        public JToken[] TRID { get; set; }

        [JsonProperty("type_description")]
        public string TypeDescription { get; set; }

        [JsonProperty("type_extension")]
        public string TypeExtension { get; set; }

        [JsonProperty("type_tag")]
        public string TypeTag { get; set; }

        [JsonProperty("unique_sources")]
        public int UniqueSources { get; set; }

        [JsonProperty("vhash")]
        public string Vhash { get; set; }
    }

    public class FileDataTypeAttributesTypeLastAnalysisStatisticsType
    {
        [JsonProperty("harmless")]
        public int Harmless { get; set; }

        [JsonProperty("malicious")]
        public int Malicious { get; set; }

        [JsonProperty("suspicious")]
        public int Suspicious { get; set; }

        [JsonProperty("timeout")]
        public int Timeout { get; set; }

        [JsonProperty("undetected")]
        public int Undetected { get; set; }
    }

    public class FileDataTypeAttributesTypeTotalVotesType
    {
        [JsonProperty("harmless")]
        public int Harmless { get; set; }

        [JsonProperty("malicious")]
        public int Malicious { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Virustotal;

    public partial class WorkflowManagedActions
    {
        public VirustotalActions Virustotal(string connectionId) => new VirustotalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VirustotalTriggers Virustotal(string connectionId) => new VirustotalTriggers(connectionId);
    }
}