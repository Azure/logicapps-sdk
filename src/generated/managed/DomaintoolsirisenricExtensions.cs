//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Domaintoolsirisenric
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DomaintoolsirisenricActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisenric")]
        public IBodyWorkflowAction<EnrichResponse> EnrichDomain(Expression<Func<string>> domain)
        {
            var apiCallPath = "/iris-enrich/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["domain"] = ExpressionConverter.Convert(domain);
            return new ApiConnectionAction<EnrichResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisenric")]
        public IBodyWorkflowAction<AccountResponse> AccountInformation()
        {
            var apiCallPath = "/account/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<AccountResponse>(callPayload);
        }
    }

    public class DomaintoolsirisenricTriggers([ConnectionName] string connectionId)
    {
    }

    public class EnrichResponse
    {
        [JsonProperty("response")]
        public EnrichResponseResponseType Response { get; set; }
    }

    public class EnrichResponseResponseType
    {
        [JsonProperty("limit_exceeded")]
        public bool LimitExceeded { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("results_count")]
        public int ResultsCount { get; set; }

        [JsonProperty("results")]
        public EnrichResponseResponseTypeResultsTypeItem[] Results { get; set; }

        [JsonProperty("missing_domains")]
        public JToken[] MissingDomains { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItem
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("whois_url")]
        public string WhoisUrl { get; set; }

        [JsonProperty("adsense")]
        public EnrichResponseResponseTypeResultsTypeItemAdsenseType Adsense { get; set; }

        [JsonProperty("popularity_rank")]
        public JToken PopularityRank { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("google_analytics")]
        public JToken GoogleAnalytics { get; set; }

        [JsonProperty("admin_contact")]
        public EnrichResponseResponseTypeResultsTypeItemAdminContactType AdminContact { get; set; }

        [JsonProperty("billing_contact")]
        public EnrichResponseResponseTypeResultsTypeItemBillingContactType BillingContact { get; set; }

        [JsonProperty("registrant_contact")]
        public EnrichResponseResponseTypeResultsTypeItemRegistrantContactType RegistrantContact { get; set; }

        [JsonProperty("technical_contact")]
        public EnrichResponseResponseTypeResultsTypeItemTechnicalContactType TechnicalContact { get; set; }

        [JsonProperty("create_date")]
        public EnrichResponseResponseTypeResultsTypeItemCreateDateType CreateDate { get; set; }

        [JsonProperty("expiration_date")]
        public EnrichResponseResponseTypeResultsTypeItemExpirationDateType ExpirationDate { get; set; }

        [JsonProperty("email_domain")]
        public EnrichResponseResponseTypeResultsTypeItemEmailDomainTypeItem[] EmailDomain { get; set; }

        [JsonProperty("soa_email")]
        public EnrichResponseResponseTypeResultsTypeItemSoaEmailTypeItem[] SoaEmail { get; set; }

        [JsonProperty("ssl_email")]
        public EnrichResponseResponseTypeResultsTypeItemSslEmailTypeItem[] SslEmail { get; set; }

        [JsonProperty("additional_whois_email")]
        public EnrichResponseResponseTypeResultsTypeItemAdditionalWhoisEmailTypeItem[] AdditionalWhoisEmail { get; set; }

        [JsonProperty("ip")]
        public EnrichResponseResponseTypeResultsTypeItemIpTypeItem[] Ip { get; set; }

        [JsonProperty("mx")]
        public EnrichResponseResponseTypeResultsTypeItemMxTypeItem[] Mx { get; set; }

        [JsonProperty("name_server")]
        public EnrichResponseResponseTypeResultsTypeItemNameServerTypeItem[] NameServer { get; set; }

        [JsonProperty("domain_risk")]
        public EnrichResponseResponseTypeResultsTypeItemDomainRiskType DomainRisk { get; set; }

        [JsonProperty("redirect")]
        public EnrichResponseResponseTypeResultsTypeItemRedirectType Redirect { get; set; }

        [JsonProperty("redirect_domain")]
        public EnrichResponseResponseTypeResultsTypeItemRedirectDomainType RedirectDomain { get; set; }

        [JsonProperty("registrant_name")]
        public EnrichResponseResponseTypeResultsTypeItemRegistrantNameType RegistrantName { get; set; }

        [JsonProperty("registrant_org")]
        public EnrichResponseResponseTypeResultsTypeItemRegistrantOrgType RegistrantOrg { get; set; }

        [JsonProperty("registrar")]
        public JToken Registrar { get; set; }

        [JsonProperty("registrar_status")]
        public string[] RegistrarStatus { get; set; }

        [JsonProperty("spf_info")]
        public string SpfInfo { get; set; }

        [JsonProperty("ssl_info")]
        public EnrichResponseResponseTypeResultsTypeItemSslInfoTypeItem[] SslInfo { get; set; }

        [JsonProperty("tld")]
        public string Tld { get; set; }

        [JsonProperty("website_response")]
        public JToken WebsiteResponse { get; set; }

        [JsonProperty("data_updated_timestamp")]
        public string DataUpdatedTimestamp { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemAdsenseType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemAdminContactType
    {
        [JsonProperty("name")]
        public EnrichResponseResponseTypeResultsTypeItemAdminContactTypeNameType Name { get; set; }

        [JsonProperty("org")]
        public EnrichResponseResponseTypeResultsTypeItemAdminContactTypeOrgType Org { get; set; }

        [JsonProperty("street")]
        public EnrichResponseResponseTypeResultsTypeItemAdminContactTypeStreetType Street { get; set; }

        [JsonProperty("city")]
        public EnrichResponseResponseTypeResultsTypeItemAdminContactTypeCityType City { get; set; }

        [JsonProperty("state")]
        public EnrichResponseResponseTypeResultsTypeItemAdminContactTypeStateType State { get; set; }

        [JsonProperty("postal")]
        public EnrichResponseResponseTypeResultsTypeItemAdminContactTypePostalType Postal { get; set; }

        [JsonProperty("country")]
        public EnrichResponseResponseTypeResultsTypeItemAdminContactTypeCountryType Country { get; set; }

        [JsonProperty("phone")]
        public EnrichResponseResponseTypeResultsTypeItemAdminContactTypePhoneType Phone { get; set; }

        [JsonProperty("fax")]
        public EnrichResponseResponseTypeResultsTypeItemAdminContactTypeFaxType Fax { get; set; }

        [JsonProperty("email")]
        public EnrichResponseResponseTypeResultsTypeItemAdminContactTypeEmailTypeItem[] Email { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemAdminContactTypeNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemAdminContactTypeOrgType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemAdminContactTypeStreetType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemAdminContactTypeCityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemAdminContactTypeStateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemAdminContactTypePostalType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemAdminContactTypeCountryType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemAdminContactTypePhoneType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemAdminContactTypeFaxType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemAdminContactTypeEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemBillingContactType
    {
        [JsonProperty("name")]
        public EnrichResponseResponseTypeResultsTypeItemBillingContactTypeNameType Name { get; set; }

        [JsonProperty("org")]
        public EnrichResponseResponseTypeResultsTypeItemBillingContactTypeOrgType Org { get; set; }

        [JsonProperty("street")]
        public EnrichResponseResponseTypeResultsTypeItemBillingContactTypeStreetType Street { get; set; }

        [JsonProperty("city")]
        public EnrichResponseResponseTypeResultsTypeItemBillingContactTypeCityType City { get; set; }

        [JsonProperty("state")]
        public EnrichResponseResponseTypeResultsTypeItemBillingContactTypeStateType State { get; set; }

        [JsonProperty("postal")]
        public EnrichResponseResponseTypeResultsTypeItemBillingContactTypePostalType Postal { get; set; }

        [JsonProperty("country")]
        public EnrichResponseResponseTypeResultsTypeItemBillingContactTypeCountryType Country { get; set; }

        [JsonProperty("phone")]
        public EnrichResponseResponseTypeResultsTypeItemBillingContactTypePhoneType Phone { get; set; }

        [JsonProperty("fax")]
        public EnrichResponseResponseTypeResultsTypeItemBillingContactTypeFaxType Fax { get; set; }

        [JsonProperty("email")]
        public EnrichResponseResponseTypeResultsTypeItemBillingContactTypeEmailTypeItem[] Email { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemBillingContactTypeNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemBillingContactTypeOrgType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemBillingContactTypeStreetType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemBillingContactTypeCityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemBillingContactTypeStateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemBillingContactTypePostalType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemBillingContactTypeCountryType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemBillingContactTypePhoneType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemBillingContactTypeFaxType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemBillingContactTypeEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRegistrantContactType
    {
        [JsonProperty("name")]
        public EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeNameType Name { get; set; }

        [JsonProperty("org")]
        public EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeOrgType Org { get; set; }

        [JsonProperty("street")]
        public EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeStreetType Street { get; set; }

        [JsonProperty("city")]
        public EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeCityType City { get; set; }

        [JsonProperty("state")]
        public EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeStateType State { get; set; }

        [JsonProperty("postal")]
        public EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypePostalType Postal { get; set; }

        [JsonProperty("country")]
        public EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeCountryType Country { get; set; }

        [JsonProperty("phone")]
        public EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypePhoneType Phone { get; set; }

        [JsonProperty("fax")]
        public EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeFaxType Fax { get; set; }

        [JsonProperty("email")]
        public EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeEmailTypeItem[] Email { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeOrgType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeStreetType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeCityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeStateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypePostalType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeCountryType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypePhoneType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeFaxType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRegistrantContactTypeEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemTechnicalContactType
    {
        [JsonProperty("name")]
        public EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeNameType Name { get; set; }

        [JsonProperty("org")]
        public EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeOrgType Org { get; set; }

        [JsonProperty("street")]
        public EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeStreetType Street { get; set; }

        [JsonProperty("city")]
        public EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeCityType City { get; set; }

        [JsonProperty("state")]
        public EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeStateType State { get; set; }

        [JsonProperty("postal")]
        public EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypePostalType Postal { get; set; }

        [JsonProperty("country")]
        public EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeCountryType Country { get; set; }

        [JsonProperty("phone")]
        public EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypePhoneType Phone { get; set; }

        [JsonProperty("fax")]
        public EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeFaxType Fax { get; set; }

        [JsonProperty("email")]
        public EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeEmailTypeItem[] Email { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeOrgType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeStreetType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeCityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeStateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypePostalType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeCountryType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypePhoneType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeFaxType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemTechnicalContactTypeEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemCreateDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemExpirationDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemEmailDomainTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemSoaEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemSslEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemAdditionalWhoisEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemIpTypeItem
    {
        [JsonProperty("address")]
        public EnrichResponseResponseTypeResultsTypeItemIpTypeItemAddressType Address { get; set; }

        [JsonProperty("asn")]
        public EnrichResponseResponseTypeResultsTypeItemIpTypeItemAsnTypeItem[] Asn { get; set; }

        [JsonProperty("country_code")]
        public EnrichResponseResponseTypeResultsTypeItemIpTypeItemCountryCodeType CountryCode { get; set; }

        [JsonProperty("isp")]
        public EnrichResponseResponseTypeResultsTypeItemIpTypeItemIspType Isp { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemIpTypeItemAddressType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemIpTypeItemAsnTypeItem
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemIpTypeItemCountryCodeType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemIpTypeItemIspType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemMxTypeItem
    {
        [JsonProperty("host")]
        public EnrichResponseResponseTypeResultsTypeItemMxTypeItemHostType Host { get; set; }

        [JsonProperty("domain")]
        public EnrichResponseResponseTypeResultsTypeItemMxTypeItemDomainType Domain { get; set; }

        [JsonProperty("ip")]
        public EnrichResponseResponseTypeResultsTypeItemMxTypeItemIpTypeItem[] Ip { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemMxTypeItemHostType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemMxTypeItemDomainType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemMxTypeItemIpTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemNameServerTypeItem
    {
        [JsonProperty("host")]
        public EnrichResponseResponseTypeResultsTypeItemNameServerTypeItemHostType Host { get; set; }

        [JsonProperty("domain")]
        public EnrichResponseResponseTypeResultsTypeItemNameServerTypeItemDomainType Domain { get; set; }

        [JsonProperty("ip")]
        public EnrichResponseResponseTypeResultsTypeItemNameServerTypeItemIpTypeItem[] Ip { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemNameServerTypeItemHostType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemNameServerTypeItemDomainType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemNameServerTypeItemIpTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemDomainRiskType
    {
        [JsonProperty("risk_score")]
        public int RiskScore { get; set; }

        [JsonProperty("components")]
        public EnrichResponseResponseTypeResultsTypeItemDomainRiskTypeComponentsTypeItem[] Components { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemDomainRiskTypeComponentsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("risk_score")]
        public int RiskScore { get; set; }

        [JsonProperty("threats")]
        public string[] Threats { get; set; }

        [JsonProperty("evidence")]
        public string[] Evidence { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRedirectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRedirectDomainType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRegistrantNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemRegistrantOrgType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemSslInfoTypeItem
    {
        [JsonProperty("hash")]
        public EnrichResponseResponseTypeResultsTypeItemSslInfoTypeItemHashType Hash { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemSslInfoTypeItemHashType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("subject")]
        public EnrichResponseResponseTypeResultsTypeItemSslInfoTypeItemHashTypeSubjectType Subject { get; set; }

        [JsonProperty("organization")]
        public EnrichResponseResponseTypeResultsTypeItemSslInfoTypeItemHashTypeOrganizationType Organization { get; set; }

        [JsonProperty("email")]
        public string[] Email { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemSslInfoTypeItemHashTypeSubjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class EnrichResponseResponseTypeResultsTypeItemSslInfoTypeItemHashTypeOrganizationType
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class AccountResponse
    {
        [JsonProperty("account")]
        public AccountResponseAccountType Account { get; set; }

        [JsonProperty("products")]
        public AccountResponseProductsTypeItem[] Products { get; set; }
    }

    public class AccountResponseAccountType
    {
        [JsonProperty("api_username")]
        public string ApiUsername { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class AccountResponseProductsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("per_month_limit")]
        public string PerMonthLimit { get; set; }

        [JsonProperty("per_minute_limit")]
        public string PerMinuteLimit { get; set; }

        [JsonProperty("absolute_limit")]
        public string AbsoluteLimit { get; set; }

        [JsonProperty("usage")]
        public AccountResponseProductsTypeItemUsageType Usage { get; set; }

        [JsonProperty("expiration_date")]
        public string ExpirationDate { get; set; }
    }

    public class AccountResponseProductsTypeItemUsageType
    {
        [JsonProperty("today")]
        public string Today { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Domaintoolsirisenric;

    public partial class WorkflowManagedActions
    {
        public DomaintoolsirisenricActions Domaintoolsirisenric(string connectionId) => new DomaintoolsirisenricActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DomaintoolsirisenricTriggers Domaintoolsirisenric(string connectionId) => new DomaintoolsirisenricTriggers(connectionId);
    }
}