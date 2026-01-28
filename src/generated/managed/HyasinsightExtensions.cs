//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hyasinsight
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HyasinsightActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hyasinsight")]
        public IBodyWorkflowAction<DeviceGeoItem[]> MobileGeolocation(Expression<Func<indicatorTypeInput>> indicatorType, Expression<Func<string>> indicatorValue)
        {
            var apiCallPath = "/device_geo";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indicator_type"] = ExpressionConverter.Convert(indicatorType);
            callPayload.Queries["indicator_value"] = ExpressionConverter.Convert(indicatorValue);
            return new ApiConnectionAction<DeviceGeoItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hyasinsight")]
        public IBodyWorkflowAction<SinkholeItem[]> Sinkhole(Expression<Func<indicatorTypeInput>> indicatorType, Expression<Func<string>> indicatorValue)
        {
            var apiCallPath = "/sinkhole";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indicator_type"] = ExpressionConverter.Convert(indicatorType);
            callPayload.Queries["indicator_value"] = ExpressionConverter.Convert(indicatorValue);
            return new ApiConnectionAction<SinkholeItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hyasinsight")]
        public IBodyWorkflowAction<PassivednsItem[]> PassiveDNS(Expression<Func<indicatorTypeInput>> indicatorType, Expression<Func<string>> indicatorValue)
        {
            var apiCallPath = "/passivedns";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indicator_type"] = ExpressionConverter.Convert(indicatorType);
            callPayload.Queries["indicator_value"] = ExpressionConverter.Convert(indicatorValue);
            return new ApiConnectionAction<PassivednsItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hyasinsight")]
        public IBodyWorkflowAction<DynamicdnsItem[]> DynamicDNS(Expression<Func<indicatorTypeInput>> indicatorType, Expression<Func<string>> indicatorValue)
        {
            var apiCallPath = "/dynamicdns";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indicator_type"] = ExpressionConverter.Convert(indicatorType);
            callPayload.Queries["indicator_value"] = ExpressionConverter.Convert(indicatorValue);
            return new ApiConnectionAction<DynamicdnsItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hyasinsight")]
        public IBodyWorkflowAction<PassivehashItem[]> PassiveHash(Expression<Func<indicatorTypeInput>> indicatorType, Expression<Func<string>> indicatorValue)
        {
            var apiCallPath = "/passivehash";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indicator_type"] = ExpressionConverter.Convert(indicatorType);
            callPayload.Queries["indicator_value"] = ExpressionConverter.Convert(indicatorValue);
            return new ApiConnectionAction<PassivehashItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hyasinsight")]
        public IBodyWorkflowAction<Sslcertificate> SSLCertificate(Expression<Func<indicatorTypeInput>> indicatorType, Expression<Func<string>> indicatorValue)
        {
            var apiCallPath = "/ssl_certificate";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indicator_type"] = ExpressionConverter.Convert(indicatorType);
            callPayload.Queries["indicator_value"] = ExpressionConverter.Convert(indicatorValue);
            return new ApiConnectionAction<Sslcertificate>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hyasinsight")]
        public IBodyWorkflowAction<WhoisItem[]> Whois(Expression<Func<indicatorTypeInput>> indicatorType, Expression<Func<string>> indicatorValue)
        {
            var apiCallPath = "/whois";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indicator_type"] = ExpressionConverter.Convert(indicatorType);
            callPayload.Queries["indicator_value"] = ExpressionConverter.Convert(indicatorValue);
            return new ApiConnectionAction<WhoisItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hyasinsight")]
        public IBodyWorkflowAction<C2attributionItem[]> C2Attribution(Expression<Func<indicatorTypeInput>> indicatorType, Expression<Func<string>> indicatorValue)
        {
            var apiCallPath = "/c2attribution";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indicator_type"] = ExpressionConverter.Convert(indicatorType);
            callPayload.Queries["indicator_value"] = ExpressionConverter.Convert(indicatorValue);
            return new ApiConnectionAction<C2attributionItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hyasinsight")]
        public IBodyWorkflowAction<SampleInformation> SampleInformation(Expression<Func<indicatorTypeInput>> indicatorType, Expression<Func<string>> indicatorValue)
        {
            var apiCallPath = "/sample/information";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indicator_type"] = ExpressionConverter.Convert(indicatorType);
            callPayload.Queries["indicator_value"] = ExpressionConverter.Convert(indicatorValue);
            return new ApiConnectionAction<SampleInformation>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hyasinsight")]
        public IBodyWorkflowAction<SampleItem[]> Sample(Expression<Func<indicatorTypeInput>> indicatorType, Expression<Func<string>> indicatorValue)
        {
            var apiCallPath = "/sample";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indicator_type"] = ExpressionConverter.Convert(indicatorType);
            callPayload.Queries["indicator_value"] = ExpressionConverter.Convert(indicatorValue);
            return new ApiConnectionAction<SampleItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hyasinsight")]
        public IBodyWorkflowAction<OsIndicatorsItem[]> OpenSourceIndicators(Expression<Func<indicatorTypeInput>> indicatorType, Expression<Func<string>> indicatorValue)
        {
            var apiCallPath = "/os_indicators";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["indicator_type"] = ExpressionConverter.Convert(indicatorType);
            callPayload.Queries["indicator_value"] = ExpressionConverter.Convert(indicatorValue);
            return new ApiConnectionAction<OsIndicatorsItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hyasinsight")]
        public IBodyWorkflowAction<WhoisCurrent> CurrentWhois(Expression<Func<string>> bodyappliedFiltersdomain = null)
        {
            var apiCallPath = "/whois/v1";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var appliedFiltersObject = new JObject();
            var appliedFiltersObjectpropCount = 0;
            if (bodyappliedFiltersdomain != null)
            {
                appliedFiltersObject["domain"] = ExpressionConverter.ConvertO(bodyappliedFiltersdomain);
                appliedFiltersObjectpropCount++;
            }

            appliedFiltersObject["current"] = true;
            appliedFiltersObjectpropCount++;
            if (appliedFiltersObjectpropCount > 0)
            {
                body["applied_filters"] = appliedFiltersObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WhoisCurrent>(callPayload);
        }
    }

    public class HyasinsightTriggers([ConnectionName] string connectionId)
    {
    }

    public class DeviceGeoItem
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("device_user_agent")]
        public string DeviceUserAgent { get; set; }

        [JsonProperty("geo_country_alpha_2")]
        public string GeoCountryAlpha2 { get; set; }

        [JsonProperty("geo_horizontal_accuracy")]
        public double GeoHorizontalAccuracy { get; set; }

        [JsonProperty("ipv4")]
        public string Ipv4 { get; set; }

        [JsonProperty("ipv6")]
        public string Ipv6 { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("wifi_bssid")]
        public string WifiBssid { get; set; }
    }

    public enum indicatorTypeInput
    {
        [EnumMember(Value = "ipv4")]
        Ipv4,
        [EnumMember(Value = "ipv6")]
        Ipv6,
        [EnumMember(Value = "domain")]
        Domain,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256,
        [EnumMember(Value = "md5")]
        Md5
    }

    public class SinkholeItem
    {
        [JsonProperty("count")]
        public double Count { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("data_port")]
        public double DataPort { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("ipv4")]
        public string Ipv4 { get; set; }

        [JsonProperty("last_seen")]
        public string LastSeen { get; set; }

        [JsonProperty("organization_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("sink_source")]
        public string SinkSource { get; set; }
    }

    public class PassivednsItem
    {
        [JsonProperty("cert_name")]
        public string CertName { get; set; }

        [JsonProperty("count")]
        public double Count { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("first_seen")]
        public string FirstSeen { get; set; }

        [JsonProperty("ip")]
        public PassivednsItemIpType Ip { get; set; }

        [JsonProperty("ipv4")]
        public string Ipv4 { get; set; }

        [JsonProperty("ipv6")]
        public string Ipv6 { get; set; }

        [JsonProperty("last_seen")]
        public string LastSeen { get; set; }

        [JsonProperty("sources")]
        public string[] Sources { get; set; }
    }

    public class PassivednsItemIpType
    {
        [JsonProperty("geo")]
        public PassivednsItemIpTypeGeoType Geo { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("isp")]
        public PassivednsItemIpTypeIspType Isp { get; set; }
    }

    public class PassivednsItemIpTypeGeoType
    {
        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("country_iso_code")]
        public string CountryIsoCode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("location_latitude")]
        public string LocationLatitude { get; set; }

        [JsonProperty("location_longitude")]
        public string LocationLongitude { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
    }

    public class PassivednsItemIpTypeIspType
    {
        [JsonProperty("autonomous_system_number")]
        public string AutonomousSystemNumber { get; set; }

        [JsonProperty("autonomous_system_organization")]
        public string AutonomousSystemOrganization { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("isp")]
        public string Isp { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }
    }

    public class DynamicdnsItem
    {
        [JsonProperty("a_record")]
        public string ARecord { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("created_ip")]
        public string CreatedIp { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("domain_creator_ip")]
        public string DomainCreatorIp { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class PassivehashItem
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("md5_count")]
        public double Md5Count { get; set; }
    }

    public class Sslcertificate
    {
        [JsonProperty("related_count")]
        public double RelatedCount { get; set; }

        [JsonProperty("ssl_certs")]
        public SslcertificateSslCertsTypeItem[] SslCerts { get; set; }
    }

    public class SslcertificateSslCertsTypeItem
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("ssl_cert")]
        public SslcertificateSslCertsTypeItemSslCertType SslCert { get; set; }
    }

    public class SslcertificateSslCertsTypeItemSslCertType
    {
        [JsonProperty("cert_key")]
        public string CertKey { get; set; }

        [JsonProperty("expire_date")]
        public string ExpireDate { get; set; }

        [JsonProperty("issue_date")]
        public string IssueDate { get; set; }

        [JsonProperty("issuer_commonName")]
        public string IssuerCommonName { get; set; }

        [JsonProperty("issuer_countryName")]
        public string IssuerCountryName { get; set; }

        [JsonProperty("issuer_localityName")]
        public string IssuerLocalityName { get; set; }

        [JsonProperty("issuer_organizationName")]
        public string IssuerOrganizationName { get; set; }

        [JsonProperty("issuer_organizationalUnitName")]
        public string IssuerOrganizationalUnitName { get; set; }

        [JsonProperty("issuer_stateOrProvinceName")]
        public string IssuerStateOrProvinceName { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("serial_number")]
        public string SerialNumber { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("sha_256")]
        public string Sha256 { get; set; }

        [JsonProperty("sig_algo")]
        public string SigAlgo { get; set; }

        [JsonProperty("signature")]
        public string Signature { get; set; }

        [JsonProperty("ssl_version")]
        public JToken SslVersion { get; set; }

        [JsonProperty("subject_commonName")]
        public string SubjectCommonName { get; set; }

        [JsonProperty("subject_countryName")]
        public string SubjectCountryName { get; set; }

        [JsonProperty("subject_localityName")]
        public string SubjectLocalityName { get; set; }

        [JsonProperty("subject_organizationName")]
        public string SubjectOrganizationName { get; set; }

        [JsonProperty("subject_organizationalUnitName")]
        public string SubjectOrganizationalUnitName { get; set; }

        [JsonProperty("subject_stateOrProvinceName")]
        public string SubjectStateOrProvinceName { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class WhoisItem
    {
        [JsonProperty("address")]
        public string[] Address { get; set; }

        [JsonProperty("city")]
        public string[] City { get; set; }

        [JsonProperty("country")]
        public string[] Country { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("domain_2tld")]
        public string Domain2tld { get; set; }

        [JsonProperty("domain_created_datetime")]
        public string DomainCreatedDatetime { get; set; }

        [JsonProperty("domain_expires_datetime")]
        public string DomainExpiresDatetime { get; set; }

        [JsonProperty("domain_updated_datetime")]
        public string DomainUpdatedDatetime { get; set; }

        [JsonProperty("email")]
        public string[] Email { get; set; }

        [JsonProperty("idn_name")]
        public string IdnName { get; set; }

        [JsonProperty("nameserver")]
        public string[] Nameserver { get; set; }

        [JsonProperty("phone")]
        public WhoisItemPhoneTypeItem[] Phone { get; set; }

        [JsonProperty("privacy_punch")]
        public bool PrivacyPunch { get; set; }

        [JsonProperty("registrar")]
        public string Registrar { get; set; }

        [JsonProperty("whois_hash")]
        public string WhoisHash { get; set; }

        [JsonProperty("whois_id")]
        public string WhoisId { get; set; }
    }

    public class WhoisItemPhoneTypeItem
    {
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phone_info")]
        public WhoisItemPhoneTypeItemPhoneInfoType PhoneInfo { get; set; }
    }

    public class WhoisItemPhoneTypeItemPhoneInfoType
    {
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("geo")]
        public string Geo { get; set; }
    }

    public class C2attributionItem
    {
        [JsonProperty("actor_ipv4")]
        public string ActorIpv4 { get; set; }

        [JsonProperty("c2_domain")]
        public string C2Domain { get; set; }

        [JsonProperty("c2_ip")]
        public string C2Ip { get; set; }

        [JsonProperty("c2_url")]
        public string C2Url { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_domain")]
        public string EmailDomain { get; set; }

        [JsonProperty("referrer_domain")]
        public string ReferrerDomain { get; set; }

        [JsonProperty("referrer_ipv4")]
        public string ReferrerIpv4 { get; set; }

        [JsonProperty("referrer_url")]
        public string ReferrerUrl { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }
    }

    public class SampleInformation
    {
        [JsonProperty("avscan_score")]
        public string AvscanScore { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("scan_results")]
        public SampleInformationScanResultsTypeItem[] ScanResults { get; set; }

        [JsonProperty("scan_time")]
        public string ScanTime { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("sha512")]
        public string Sha512 { get; set; }
    }

    public class SampleInformationScanResultsTypeItem
    {
        [JsonProperty("av_name")]
        public string AvName { get; set; }

        [JsonProperty("def_time")]
        public string DefTime { get; set; }

        [JsonProperty("threat_found")]
        public string ThreatFound { get; set; }
    }

    public class SampleItem
    {
        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("ipv4")]
        public string Ipv4 { get; set; }

        [JsonProperty("ipv6")]
        public string Ipv6 { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }
    }

    public class OsIndicatorsItem
    {
        [JsonProperty("context")]
        public string Context { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("domain_2tld")]
        public string Domain2tld { get; set; }

        [JsonProperty("first_seen")]
        public string FirstSeen { get; set; }

        [JsonProperty("ipv4")]
        public string Ipv4 { get; set; }

        [JsonProperty("ipv6")]
        public string Ipv6 { get; set; }

        [JsonProperty("last_seen")]
        public string LastSeen { get; set; }

        [JsonProperty("md5")]
        public string Md5 { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("sha256")]
        public string Sha256 { get; set; }

        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        [JsonProperty("source_url")]
        public string SourceUrl { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class WhoisCurrent
    {
        [JsonProperty("items")]
        public WhoisCurrentItemsTypeItem[] Items { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("total_count")]
        public double TotalCount { get; set; }
    }

    public class WhoisCurrentItemsTypeItem
    {
        [JsonProperty("abuse_emails")]
        public string[] AbuseEmails { get; set; }

        [JsonProperty("address")]
        public string[] Address { get; set; }

        [JsonProperty("city")]
        public string[] City { get; set; }

        [JsonProperty("country")]
        public string[] Country { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("domain_2tld")]
        public string Domain2tld { get; set; }

        [JsonProperty("domain_created_datetime")]
        public string DomainCreatedDatetime { get; set; }

        [JsonProperty("domain_expires_datetime")]
        public string DomainExpiresDatetime { get; set; }

        [JsonProperty("domain_updated_datetime")]
        public string DomainUpdatedDatetime { get; set; }

        [JsonProperty("email")]
        public string[] Email { get; set; }

        [JsonProperty("idn_name")]
        public string IdnName { get; set; }

        [JsonProperty("meta_data")]
        public string MetaData { get; set; }

        [JsonProperty("name")]
        public string[] Name { get; set; }

        [JsonProperty("nameserver")]
        public string[] Nameserver { get; set; }

        [JsonProperty("organization")]
        public string[] Organization { get; set; }

        [JsonProperty("phone")]
        public JToken[] Phone { get; set; }

        [JsonProperty("registrar")]
        public string Registrar { get; set; }

        [JsonProperty("state")]
        public JToken[] State { get; set; }

        [JsonProperty("whois_hash")]
        public string WhoisHash { get; set; }

        [JsonProperty("whois_id")]
        public string WhoisId { get; set; }

        [JsonProperty("whois_nameserver")]
        public WhoisCurrentItemsTypeItemWhoisNameserverTypeItem[] WhoisNameserver { get; set; }

        [JsonProperty("whois_pii")]
        public WhoisCurrentItemsTypeItemWhoisPiiTypeItem[] WhoisPii { get; set; }
    }

    public class WhoisCurrentItemsTypeItemWhoisNameserverTypeItem
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("domain_2tld")]
        public string Domain2tld { get; set; }

        [JsonProperty("whois_related_nameserver_id")]
        public string WhoisRelatedNameserverId { get; set; }
    }

    public class WhoisCurrentItemsTypeItemWhoisPiiTypeItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("geo_country_alpha_2")]
        public string GeoCountryAlpha2 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("phone_e164")]
        public string PhoneE164 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("whois_related_pii_id")]
        public string WhoisRelatedPiiId { get; set; }

        [JsonProperty("whois_related_type")]
        public string WhoisRelatedType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hyasinsight;

    public partial class WorkflowManagedActions
    {
        public HyasinsightActions Hyasinsight(string connectionId) => new HyasinsightActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HyasinsightTriggers Hyasinsight(string connectionId) => new HyasinsightTriggers(connectionId);
    }
}