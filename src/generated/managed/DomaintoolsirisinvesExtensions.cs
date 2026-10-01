//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Domaintoolsirisinves
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DomaintoolsirisinvesActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> ReverseIP([WorkflowExpression] Func<string> ip, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/reverse-ip/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ip"] = SourceExpressionConverter.ConvertO(ip);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> PivotNameserverIP([WorkflowExpression] Func<string> nameserverIp, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/nameserver-ip";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["nameserver_ip"] = SourceExpressionConverter.ConvertO(nameserverIp);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> InvestigateDomain([WorkflowExpression] Func<string> domain, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/investigate_domain";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domain"] = SourceExpressionConverter.ConvertO(domain);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> PivotMXIP([WorkflowExpression] Func<string> mailserverIp, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/mx-ip";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mailserver_ip"] = SourceExpressionConverter.ConvertO(mailserverIp);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> ReverseEmail([WorkflowExpression] Func<string> email, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/reverse-email";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> LoadSearchHash([WorkflowExpression] Func<string> searchHash, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/search-hash";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search_hash"] = SourceExpressionConverter.ConvertO(searchHash);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> PivotSSLHash([WorkflowExpression] Func<string> sslHash, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/ssl-hash";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ssl_hash"] = SourceExpressionConverter.ConvertO(sslHash);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> PivotRegistrantOrg([WorkflowExpression] Func<string> registrantOrg, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/registrant-org";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["registrant_org"] = SourceExpressionConverter.ConvertO(registrantOrg);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> PivotRegistrantName([WorkflowExpression] Func<string> registrant, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/registrant";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["registrant"] = SourceExpressionConverter.ConvertO(registrant);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> ReverseEmailDomain([WorkflowExpression] Func<string> emailDomain, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/email-domain";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["email_domain"] = SourceExpressionConverter.ConvertO(emailDomain);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> PivotSSLEmail([WorkflowExpression] Func<string> sslEmail, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/ssl-email/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ssl_email"] = SourceExpressionConverter.ConvertO(sslEmail);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> PivotNameserverHost([WorkflowExpression] Func<string> nameserverHost, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/nameserver-host/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["nameserver_host"] = SourceExpressionConverter.ConvertO(nameserverHost);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> PivotMXHost([WorkflowExpression] Func<string> mailserverHost, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/mailserver-host/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["mailserver_host"] = SourceExpressionConverter.ConvertO(mailserverHost);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> ReturnTaggedAny([WorkflowExpression] Func<string> taggedWithAny, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/tagged-any/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tagged_with_any"] = SourceExpressionConverter.ConvertO(taggedWithAny);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<InvestigateResponse> ReturnTaggedAll([WorkflowExpression] Func<string> taggedWithAll, [WorkflowExpression] Func<bool> active = null, [WorkflowExpression] Func<string> createDate = null, [WorkflowExpression] Func<string> expirationDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/iris-investigate/tagged-all/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tagged_with_all"] = SourceExpressionConverter.ConvertO(taggedWithAll);
                if (active != null)
                    callPayload.Queries["active"] = SourceExpressionConverter.ConvertO(active);
                if (createDate != null)
                    callPayload.Queries["create_date"] = SourceExpressionConverter.ConvertO(createDate);
                if (expirationDate != null)
                    callPayload.Queries["expiration_date"] = SourceExpressionConverter.ConvertO(expirationDate);
                return callPayload;
            }

            return new ApiConnectionAction<InvestigateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "domaintoolsirisinves")]
        public IBodyWorkflowAction<AccountResponse> AccountInformation()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/account/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<AccountResponse>(BuildSourceInput);
        }
    }

    public class DomaintoolsirisinvesTriggers([ConnectionName] string connectionId)
    {
    }

    public class InvestigateResponse
    {
        [JsonProperty("response")]
        public InvestigateResponseResponseType Response { get; set; }
    }

    public class InvestigateResponseResponseType
    {
        [JsonProperty("limit_exceeded")]
        public bool LimitExceeded { get; set; }

        [JsonProperty("has_more_results")]
        public bool HasMoreResults { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("results_count")]
        public int ResultsCount { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("results")]
        public InvestigateResponseResponseTypeResultsTypeItem[] Results { get; set; }

        [JsonProperty("missing_domains")]
        public JToken[] MissingDomains { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItem
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("whois_url")]
        public string WhoisUrl { get; set; }

        [JsonProperty("adsense")]
        public InvestigateResponseResponseTypeResultsTypeItemAdsenseType Adsense { get; set; }

        [JsonProperty("popularity_rank")]
        public JToken PopularityRank { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("google_analytics")]
        public JToken GoogleAnalytics { get; set; }

        [JsonProperty("admin_contact")]
        public InvestigateResponseResponseTypeResultsTypeItemAdminContactType AdminContact { get; set; }

        [JsonProperty("billing_contact")]
        public InvestigateResponseResponseTypeResultsTypeItemBillingContactType BillingContact { get; set; }

        [JsonProperty("registrant_contact")]
        public InvestigateResponseResponseTypeResultsTypeItemRegistrantContactType RegistrantContact { get; set; }

        [JsonProperty("technical_contact")]
        public InvestigateResponseResponseTypeResultsTypeItemTechnicalContactType TechnicalContact { get; set; }

        [JsonProperty("create_date")]
        public InvestigateResponseResponseTypeResultsTypeItemCreateDateType CreateDate { get; set; }

        [JsonProperty("expiration_date")]
        public InvestigateResponseResponseTypeResultsTypeItemExpirationDateType ExpirationDate { get; set; }

        [JsonProperty("email_domain")]
        public InvestigateResponseResponseTypeResultsTypeItemEmailDomainTypeItem[] EmailDomain { get; set; }

        [JsonProperty("soa_email")]
        public InvestigateResponseResponseTypeResultsTypeItemSoaEmailTypeItem[] SoaEmail { get; set; }

        [JsonProperty("ssl_email")]
        public InvestigateResponseResponseTypeResultsTypeItemSslEmailTypeItem[] SslEmail { get; set; }

        [JsonProperty("additional_whois_email")]
        public InvestigateResponseResponseTypeResultsTypeItemAdditionalWhoisEmailTypeItem[] AdditionalWhoisEmail { get; set; }

        [JsonProperty("ip")]
        public InvestigateResponseResponseTypeResultsTypeItemIpTypeItem[] Ip { get; set; }

        [JsonProperty("mx")]
        public InvestigateResponseResponseTypeResultsTypeItemMxTypeItem[] Mx { get; set; }

        [JsonProperty("name_server")]
        public InvestigateResponseResponseTypeResultsTypeItemNameServerTypeItem[] NameServer { get; set; }

        [JsonProperty("domain_risk")]
        public InvestigateResponseResponseTypeResultsTypeItemDomainRiskType DomainRisk { get; set; }

        [JsonProperty("redirect")]
        public InvestigateResponseResponseTypeResultsTypeItemRedirectType Redirect { get; set; }

        [JsonProperty("redirect_domain")]
        public InvestigateResponseResponseTypeResultsTypeItemRedirectDomainType RedirectDomain { get; set; }

        [JsonProperty("registrant_name")]
        public InvestigateResponseResponseTypeResultsTypeItemRegistrantNameType RegistrantName { get; set; }

        [JsonProperty("registrant_org")]
        public InvestigateResponseResponseTypeResultsTypeItemRegistrantOrgType RegistrantOrg { get; set; }

        [JsonProperty("registrar")]
        public JToken Registrar { get; set; }

        [JsonProperty("registrar_status")]
        public string[] RegistrarStatus { get; set; }

        [JsonProperty("spf_info")]
        public string SpfInfo { get; set; }

        [JsonProperty("ssl_info")]
        public InvestigateResponseResponseTypeResultsTypeItemSslInfoTypeItem[] SslInfo { get; set; }

        [JsonProperty("tld")]
        public string Tld { get; set; }

        [JsonProperty("website_response")]
        public JToken WebsiteResponse { get; set; }

        [JsonProperty("data_updated_timestamp")]
        public string DataUpdatedTimestamp { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemAdsenseType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemAdminContactType
    {
        [JsonProperty("name")]
        public InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeNameType Name { get; set; }

        [JsonProperty("org")]
        public InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeOrgType Org { get; set; }

        [JsonProperty("street")]
        public InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeStreetType Street { get; set; }

        [JsonProperty("city")]
        public InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeCityType City { get; set; }

        [JsonProperty("state")]
        public InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeStateType State { get; set; }

        [JsonProperty("postal")]
        public InvestigateResponseResponseTypeResultsTypeItemAdminContactTypePostalType Postal { get; set; }

        [JsonProperty("country")]
        public InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeCountryType Country { get; set; }

        [JsonProperty("phone")]
        public InvestigateResponseResponseTypeResultsTypeItemAdminContactTypePhoneType Phone { get; set; }

        [JsonProperty("fax")]
        public InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeFaxType Fax { get; set; }

        [JsonProperty("email")]
        public InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeEmailTypeItem[] Email { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeOrgType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeStreetType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeCityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeStateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemAdminContactTypePostalType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeCountryType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemAdminContactTypePhoneType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeFaxType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemAdminContactTypeEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemBillingContactType
    {
        [JsonProperty("name")]
        public InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeNameType Name { get; set; }

        [JsonProperty("org")]
        public InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeOrgType Org { get; set; }

        [JsonProperty("street")]
        public InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeStreetType Street { get; set; }

        [JsonProperty("city")]
        public InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeCityType City { get; set; }

        [JsonProperty("state")]
        public InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeStateType State { get; set; }

        [JsonProperty("postal")]
        public InvestigateResponseResponseTypeResultsTypeItemBillingContactTypePostalType Postal { get; set; }

        [JsonProperty("country")]
        public InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeCountryType Country { get; set; }

        [JsonProperty("phone")]
        public InvestigateResponseResponseTypeResultsTypeItemBillingContactTypePhoneType Phone { get; set; }

        [JsonProperty("fax")]
        public InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeFaxType Fax { get; set; }

        [JsonProperty("email")]
        public InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeEmailTypeItem[] Email { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeOrgType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeStreetType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeCityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeStateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemBillingContactTypePostalType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeCountryType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemBillingContactTypePhoneType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeFaxType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemBillingContactTypeEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRegistrantContactType
    {
        [JsonProperty("name")]
        public InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeNameType Name { get; set; }

        [JsonProperty("org")]
        public InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeOrgType Org { get; set; }

        [JsonProperty("street")]
        public InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeStreetType Street { get; set; }

        [JsonProperty("city")]
        public InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeCityType City { get; set; }

        [JsonProperty("state")]
        public InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeStateType State { get; set; }

        [JsonProperty("postal")]
        public InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypePostalType Postal { get; set; }

        [JsonProperty("country")]
        public InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeCountryType Country { get; set; }

        [JsonProperty("phone")]
        public InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypePhoneType Phone { get; set; }

        [JsonProperty("fax")]
        public InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeFaxType Fax { get; set; }

        [JsonProperty("email")]
        public InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeEmailTypeItem[] Email { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeOrgType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeStreetType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeCityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeStateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypePostalType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeCountryType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypePhoneType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeFaxType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRegistrantContactTypeEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemTechnicalContactType
    {
        [JsonProperty("name")]
        public InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeNameType Name { get; set; }

        [JsonProperty("org")]
        public InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeOrgType Org { get; set; }

        [JsonProperty("street")]
        public InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeStreetType Street { get; set; }

        [JsonProperty("city")]
        public InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeCityType City { get; set; }

        [JsonProperty("state")]
        public InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeStateType State { get; set; }

        [JsonProperty("postal")]
        public InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypePostalType Postal { get; set; }

        [JsonProperty("country")]
        public InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeCountryType Country { get; set; }

        [JsonProperty("phone")]
        public InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypePhoneType Phone { get; set; }

        [JsonProperty("fax")]
        public InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeFaxType Fax { get; set; }

        [JsonProperty("email")]
        public InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeEmailTypeItem[] Email { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeOrgType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeStreetType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeCityType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeStateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypePostalType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeCountryType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypePhoneType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeFaxType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemTechnicalContactTypeEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemCreateDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemExpirationDateType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemEmailDomainTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemSoaEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemSslEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemAdditionalWhoisEmailTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemIpTypeItem
    {
        [JsonProperty("address")]
        public InvestigateResponseResponseTypeResultsTypeItemIpTypeItemAddressType Address { get; set; }

        [JsonProperty("asn")]
        public InvestigateResponseResponseTypeResultsTypeItemIpTypeItemAsnTypeItem[] Asn { get; set; }

        [JsonProperty("country_code")]
        public InvestigateResponseResponseTypeResultsTypeItemIpTypeItemCountryCodeType CountryCode { get; set; }

        [JsonProperty("isp")]
        public InvestigateResponseResponseTypeResultsTypeItemIpTypeItemIspType Isp { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemIpTypeItemAddressType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemIpTypeItemAsnTypeItem
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemIpTypeItemCountryCodeType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemIpTypeItemIspType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemMxTypeItem
    {
        [JsonProperty("host")]
        public InvestigateResponseResponseTypeResultsTypeItemMxTypeItemHostType Host { get; set; }

        [JsonProperty("domain")]
        public InvestigateResponseResponseTypeResultsTypeItemMxTypeItemDomainType Domain { get; set; }

        [JsonProperty("ip")]
        public InvestigateResponseResponseTypeResultsTypeItemMxTypeItemIpTypeItem[] Ip { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemMxTypeItemHostType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemMxTypeItemDomainType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemMxTypeItemIpTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemNameServerTypeItem
    {
        [JsonProperty("host")]
        public InvestigateResponseResponseTypeResultsTypeItemNameServerTypeItemHostType Host { get; set; }

        [JsonProperty("domain")]
        public InvestigateResponseResponseTypeResultsTypeItemNameServerTypeItemDomainType Domain { get; set; }

        [JsonProperty("ip")]
        public InvestigateResponseResponseTypeResultsTypeItemNameServerTypeItemIpTypeItem[] Ip { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemNameServerTypeItemHostType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemNameServerTypeItemDomainType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemNameServerTypeItemIpTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemDomainRiskType
    {
        [JsonProperty("risk_score")]
        public int RiskScore { get; set; }

        [JsonProperty("components")]
        public InvestigateResponseResponseTypeResultsTypeItemDomainRiskTypeComponentsTypeItem[] Components { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemDomainRiskTypeComponentsTypeItem
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

    public class InvestigateResponseResponseTypeResultsTypeItemRedirectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRedirectDomainType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRegistrantNameType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemRegistrantOrgType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemSslInfoTypeItem
    {
        [JsonProperty("hash")]
        public InvestigateResponseResponseTypeResultsTypeItemSslInfoTypeItemHashType Hash { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemSslInfoTypeItemHashType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("subject")]
        public InvestigateResponseResponseTypeResultsTypeItemSslInfoTypeItemHashTypeSubjectType Subject { get; set; }

        [JsonProperty("organization")]
        public InvestigateResponseResponseTypeResultsTypeItemSslInfoTypeItemHashTypeOrganizationType Organization { get; set; }

        [JsonProperty("email")]
        public string[] Email { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemSslInfoTypeItemHashTypeSubjectType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class InvestigateResponseResponseTypeResultsTypeItemSslInfoTypeItemHashTypeOrganizationType
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
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

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Domaintoolsirisinves;

    public partial class WorkflowManagedActions
    {
        public DomaintoolsirisinvesActions Domaintoolsirisinves(string connectionId) => new DomaintoolsirisinvesActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DomaintoolsirisinvesTriggers Domaintoolsirisinves(string connectionId) => new DomaintoolsirisinvesTriggers(connectionId);
    }
}