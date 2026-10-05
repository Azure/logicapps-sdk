//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ip2whoisip
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Ip2whoisipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ip2whoisip")]
        [WorkflowExpressionFactory(nameof(__BuildCheckDomain))]
        public IBodyWorkflowAction<CheckDomainResponse> CheckDomain([WorkflowExpression] Func<string> domain)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CheckDomainResponse> __BuildCheckDomain(WorkflowValue<string> domain)
        {
            WorkflowValue.Validate(domain, nameof(domain), required: true);
            return new DeferredBodyAction<CheckDomainResponse>(() =>
            {
                var apiCallPath = "/v2";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["domain"] = ExpressionConverter.Convert(domain);
                return new ApiConnectionAction<CheckDomainResponse>(callPayload);
            });
        }
    }

    public class Ip2whoisipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CheckDomainResponse
    {
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("domain_id")]
        public string DomainId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("create_date")]
        public string CreateDate { get; set; }

        [JsonProperty("update_date")]
        public string UpdateDate { get; set; }

        [JsonProperty("expire_date")]
        public string ExpireDate { get; set; }

        [JsonProperty("domain_age")]
        public int DomainAge { get; set; }

        [JsonProperty("whois_server")]
        public string WhoisServer { get; set; }

        [JsonProperty("registrar")]
        public CheckDomainResponseRegistrarType Registrar { get; set; }

        [JsonProperty("registrant")]
        public CheckDomainResponseRegistrantType Registrant { get; set; }

        [JsonProperty("admin")]
        public CheckDomainResponseAdminType Admin { get; set; }

        [JsonProperty("tech")]
        public CheckDomainResponseTechType Tech { get; set; }

        [JsonProperty("billing")]
        public CheckDomainResponseBillingType Billing { get; set; }

        [JsonProperty("nameservers")]
        public string[] Nameservers { get; set; }
    }

    public class CheckDomainResponseRegistrarType
    {
        [JsonProperty("iana_id")]
        public string IanaId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class CheckDomainResponseRegistrantType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("street_address")]
        public string StreetAddress { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class CheckDomainResponseAdminType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("street_address")]
        public string StreetAddress { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class CheckDomainResponseTechType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("street_address")]
        public string StreetAddress { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class CheckDomainResponseBillingType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("street_address")]
        public string StreetAddress { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ip2whoisip;

    public partial class WorkflowManagedActions
    {
        public Ip2whoisipActions Ip2whoisip(string connectionId) => new Ip2whoisipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Ip2whoisipTriggers Ip2whoisip(string connectionId) => new Ip2whoisipTriggers(connectionId);
    }
}
