//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leadloader
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeadloaderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leadloader")]
        public IBodyWorkflowAction<UploadLeadsV3Response, ApiConnectionActionConfiguration> UploadLeads(Expression<Func<UploadLeadsV3Input>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UploadLeadsV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UploadLeadsV3Response>(callPayload);
            });
        }
    }

    public class LeadloaderTriggers([ConnectionName] string connectionId)
    {
    }

    public class UploadLeadsV3Response
    {
        [JsonProperty("API-Status")]
        public string APIStatus { get; set; }

        [JsonProperty("API-Response")]
        public string APIResponse { get; set; }

        [JsonProperty("Company-Result")]
        public string CompanyResult { get; set; }

        [JsonProperty("Company-Link")]
        public string CompanyLink { get; set; }

        [JsonProperty("Contact-Result")]
        public string ContactResult { get; set; }

        [JsonProperty("Contact-Link")]
        public string ContactLink { get; set; }

        [JsonProperty("Opportunity-Result")]
        public string OpportunityResult { get; set; }

        [JsonProperty("Opportunity-Link")]
        public string OpportunityLink { get; set; }
    }

    public class UploadLeadsV3Input
    {
        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("company-type")]
        public string CompanyType { get; set; }

        [JsonProperty("company-class")]
        public string CompanyClass { get; set; }

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

        [JsonProperty("company-sales-team")]
        public string CompanySalesTeam { get; set; }

        [JsonProperty("company-industries")]
        public string CompanyIndustries { get; set; }

        [JsonProperty("company-product-potentials")]
        public string CompanyProductPotentials { get; set; }

        [JsonProperty("contact-first-name")]
        public string ContactFirstName { get; set; }

        [JsonProperty("contact-last-name")]
        public string ContactLastName { get; set; }

        [JsonProperty("contact-full-name")]
        public string ContactFullName { get; set; }

        [JsonProperty("contact-title")]
        public string ContactTitle { get; set; }

        [JsonProperty("contact-background")]
        public string ContactBackground { get; set; }

        [JsonProperty("contact-primary-contact")]
        public bool? ContactPrimaryContact { get; set; }

        [JsonProperty("contact-type-name")]
        public string ContactTypeName { get; set; }

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

        [JsonProperty("contact-notes")]
        public string ContactNotes { get; set; }

        [JsonProperty("contact-groups")]
        public string ContactGroups { get; set; }

        [JsonProperty("contact-product-interests")]
        public string ContactProductInterests { get; set; }

        [JsonProperty("opportunity-principal-name")]
        public string OpportunityPrincipalName { get; set; }

        [JsonProperty("opportunity-program")]
        public string OpportunityProgram { get; set; }

        [JsonProperty("opportunity-customer-name")]
        public string OpportunityCustomerName { get; set; }

        [JsonProperty("opportunity-distributor-name")]
        public string OpportunityDistributorName { get; set; }

        [JsonProperty("opportunity-customer-contact")]
        public string OpportunityCustomerContact { get; set; }

        [JsonProperty("opportunity-principal-contact")]
        public string OpportunityPrincipalContact { get; set; }

        [JsonProperty("opportunity-distributor-contact")]
        public string OpportunityDistributorContact { get; set; }

        [JsonProperty("opportunity-next-step")]
        public string OpportunityNextStep { get; set; }

        [JsonProperty("opportunity-activity")]
        public string OpportunityActivity { get; set; }

        [JsonProperty("opportunity-status")]
        public string OpportunityStatus { get; set; }

        [JsonProperty("opportunity-follow-up")]
        public string OpportunityFollowUp { get; set; }

        [JsonProperty("opportunity-priority")]
        public int? OpportunityPriority { get; set; }

        [JsonProperty("opportunity-potential")]
        public int? OpportunityPotential { get; set; }

        [JsonProperty("opportunity-eau")]
        public int? OpportunityEau { get; set; }

        [JsonProperty("opportunity-value")]
        public int? OpportunityValue { get; set; }

        [JsonProperty("opportunity-prototype-date")]
        public string OpportunityPrototypeDate { get; set; }

        [JsonProperty("opportunity-production-date")]
        public string OpportunityProductionDate { get; set; }

        [JsonProperty("opportunity-close-status")]
        public int? OpportunityCloseStatus { get; set; }

        [JsonProperty("opportunity-close-date")]
        public string OpportunityCloseDate { get; set; }

        [JsonProperty("opportunity-description")]
        public string OpportunityDescription { get; set; }

        [JsonProperty("opportunity-competitor-1")]
        public string OpportunityCompetitor1 { get; set; }

        [JsonProperty("opportunity-competitor-2")]
        public string OpportunityCompetitor2 { get; set; }

        [JsonProperty("opportunity-reporting-comments")]
        public string OpportunityReportingComments { get; set; }

        [JsonProperty("opportunity-lead-source-name")]
        public string OpportunityLeadSourceName { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Leadloader;

    public partial class WorkflowManagedActions
    {
        public LeadloaderActions Leadloader(string connectionId) => new LeadloaderActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LeadloaderTriggers Leadloader(string connectionId) => new LeadloaderTriggers(connectionId);
    }
}