//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Repfabricleadloader
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RepfabricleadloaderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "repfabricleadloader")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RepfabricCreateLead(Expression<Func<RepfabricCreateLeadInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/default/LeadLoaderConnector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class RepfabricleadloaderTriggers([ConnectionName] string connectionId)
    {
    }

    public class RepfabricCreateLeadInput
    {
        [JsonProperty("domain-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DomainName { get; set; }

        [JsonProperty("company-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CompanyName { get; set; }

        [JsonProperty("company-type-id")]
        public int? CompanyTypeId { get; set; }

        [JsonProperty("company-type")]
        public string CompanyType { get; set; }

        [JsonProperty("company-class-id")]
        public string CompanyClassId { get; set; }

        [JsonProperty("company-class")]
        public string CompanyClass { get; set; }

        [JsonProperty("company-category-id")]
        public int? CompanyCategoryId { get; set; }

        [JsonProperty("company-category")]
        public string CompanyCategory { get; set; }

        [JsonProperty("company-phone1")]
        public string CompanyPhone1 { get; set; }

        [JsonProperty("company-phone2")]
        public string CompanyPhone2 { get; set; }

        [JsonProperty("company-fax")]
        public string CompanyFax { get; set; }

        [JsonProperty("company-region")]
        public string CompanyRegion { get; set; }

        [JsonProperty("company-street")]
        public string CompanyStreet { get; set; }

        [JsonProperty("company-city")]
        public string CompanyCity { get; set; }

        [JsonProperty("company-state")]
        public string CompanyState { get; set; }

        [JsonProperty("company-zip")]
        public string CompanyZip { get; set; }

        [JsonProperty("company-country")]
        public string CompanyCountry { get; set; }

        [JsonProperty("company-po-box")]
        public string CompanyPoBox { get; set; }

        [JsonProperty("company-website")]
        public string CompanyWebsite { get; set; }

        [JsonProperty("company-comments")]
        public string CompanyComments { get; set; }

        [JsonProperty("company-sales-team-id")]
        public int? CompanySalesTeamId { get; set; }

        [JsonProperty("company-sales-team")]
        public string CompanySalesTeam { get; set; }

        [JsonProperty("contact-first-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactFirstName { get; set; }

        [JsonProperty("contact-last-name")]
        public string ContactLastName { get; set; }

        [JsonProperty("contact-company-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactCompanyName { get; set; }

        [JsonProperty("contact-title")]
        public string ContactTitle { get; set; }

        [JsonProperty("contact-background")]
        public string ContactBackground { get; set; }

        [JsonProperty("contact-primary")]
        public bool? ContactPrimary { get; set; }

        [JsonProperty("contact-company-type-name")]
        public string ContactCompanyTypeName { get; set; }

        [JsonProperty("contact-email-address-work")]
        public string ContactEmailAddressWork { get; set; }

        [JsonProperty("contact-email-address-personal")]
        public string ContactEmailAddressPersonal { get; set; }

        [JsonProperty("contact-email-address-alternate")]
        public string ContactEmailAddressAlternate { get; set; }

        [JsonProperty("contact-email-address-other")]
        public string ContactEmailAddressOther { get; set; }

        [JsonProperty("contact-phone-number-work")]
        public string ContactPhoneNumberWork { get; set; }

        [JsonProperty("contact-phone-number-home")]
        public string ContactPhoneNumberHome { get; set; }

        [JsonProperty("contact-phone-number-mobile")]
        public string ContactPhoneNumberMobile { get; set; }

        [JsonProperty("contact-phone-number-alternate")]
        public string ContactPhoneNumberAlternate { get; set; }

        [JsonProperty("contact-fax")]
        public string ContactFax { get; set; }

        [JsonProperty("contact-business-street")]
        public string ContactBusinessStreet { get; set; }

        [JsonProperty("contact-business-city")]
        public string ContactBusinessCity { get; set; }

        [JsonProperty("contact-business-state")]
        public string ContactBusinessState { get; set; }

        [JsonProperty("contact-business-zip")]
        public string ContactBusinessZip { get; set; }

        [JsonProperty("contact-business-country")]
        public string ContactBusinessCountry { get; set; }

        [JsonProperty("contact-home-street")]
        public string ContactHomeStreet { get; set; }

        [JsonProperty("contact-home-city")]
        public string ContactHomeCity { get; set; }

        [JsonProperty("contact-home-state")]
        public string ContactHomeState { get; set; }

        [JsonProperty("contact-home-zip")]
        public string ContactHomeZip { get; set; }

        [JsonProperty("contact-home-country")]
        public string ContactHomeCountry { get; set; }

        [JsonProperty("contact-tags")]
        public JToken[] ContactTags { get; set; }

        [JsonProperty("opportunity-id")]
        public int? OpportunityId { get; set; }

        [JsonProperty("opportunity-customer-id")]
        public int? OpportunityCustomerId { get; set; }

        [JsonProperty("opportunity-customer-name")]
        public string OpportunityCustomerName { get; set; }

        [JsonProperty("opportunity-principal-id")]
        public int? OpportunityPrincipalId { get; set; }

        [JsonProperty("opportunity-principal-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OpportunityPrincipalName { get; set; }

        [JsonProperty("opportunity-distributor-id")]
        public string OpportunityDistributorId { get; set; }

        [JsonProperty("opportunity-distributor-name")]
        public string OpportunityDistributorName { get; set; }

        [JsonProperty("opportunity-customer-contact-id")]
        public string OpportunityCustomerContactId { get; set; }

        [JsonProperty("opportunity-customer-contact")]
        public string OpportunityCustomerContact { get; set; }

        [JsonProperty("opportunity-principal-contact-id")]
        public string OpportunityPrincipalContactId { get; set; }

        [JsonProperty("opportunity-principal-contact")]
        public string OpportunityPrincipalContact { get; set; }

        [JsonProperty("opportunity-distributor-contact-id")]
        public string OpportunityDistributorContactId { get; set; }

        [JsonProperty("opportunity-distributor-contact")]
        public string OpportunityDistributorContact { get; set; }

        [JsonProperty("opportunity-program", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OpportunityProgram { get; set; }

        [JsonProperty("opportunity-next-step")]
        public string OpportunityNextStep { get; set; }

        [JsonProperty("opportunity-activity")]
        public string OpportunityActivity { get; set; }

        [JsonProperty("opportunity-status")]
        public string OpportunityStatus { get; set; }

        [JsonProperty("opportunity-sales-team-id")]
        public int? OpportunitySalesTeamId { get; set; }

        [JsonProperty("opportunity-sales-team")]
        public string OpportunitySalesTeam { get; set; }

        [JsonProperty("opportunity-follow-up")]
        public string OpportunityFollowUp { get; set; }

        [JsonProperty("opportunity-opp-owner")]
        public int? OpportunityOppOwner { get; set; }

        [JsonProperty("opportunity-priority")]
        public int? OpportunityPriority { get; set; }

        [JsonProperty("opportunity-potential")]
        public int? OpportunityPotential { get; set; }

        [JsonProperty("opportunity-eau")]
        public int? OpportunityEau { get; set; }

        [JsonProperty("opportunity-value")]
        public double? OpportunityValue { get; set; }

        [JsonProperty("opportunity-prototype-date")]
        public string OpportunityPrototypeDate { get; set; }

        [JsonProperty("opportunity-production-date")]
        public string OpportunityProductionDate { get; set; }

        [JsonProperty("opportunity-close-status")]
        public int? OpportunityCloseStatus { get; set; }

        [JsonProperty("opportunity-close-date")]
        public string OpportunityCloseDate { get; set; }

        [JsonProperty("opportunity-competitor-1")]
        public string OpportunityCompetitor1 { get; set; }

        [JsonProperty("opportunity-competitor-2")]
        public string OpportunityCompetitor2 { get; set; }

        [JsonProperty("opportunity-description")]
        public string OpportunityDescription { get; set; }

        [JsonProperty("opportunity-reporting-comments")]
        public string OpportunityReportingComments { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Repfabricleadloader;

    public partial class WorkflowManagedActions
    {
        public RepfabricleadloaderActions Repfabricleadloader(string connectionId) => new RepfabricleadloaderActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RepfabricleadloaderTriggers Repfabricleadloader(string connectionId) => new RepfabricleadloaderTriggers(connectionId);
    }
}