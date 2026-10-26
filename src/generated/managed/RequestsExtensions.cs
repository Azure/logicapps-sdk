//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Requests
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RequestsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requests")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RepfabricCreateContact(Expression<Func<RepfabricCreateContactInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requests")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RepfabricCreateCompany(Expression<Func<RepfabricCreateCompanyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Company";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requests")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RepfabricCreateQuote(Expression<Func<RepfabricCreateQuoteInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Quote";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class RequestsTriggers([ConnectionName] string connectionId)
    {
    }

    public class RepfabricCreateContactInput
    {
        [JsonProperty("domain-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DomainName { get; set; }

        [JsonProperty("contact-first-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactFirstName { get; set; }

        [JsonProperty("contact-last-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactLastName { get; set; }

        [JsonProperty("contact-title")]
        public string ContactTitle { get; set; }

        [JsonProperty("contact-background")]
        public string ContactBackground { get; set; }

        [JsonProperty("contact-company-name")]
        public string ContactCompanyName { get; set; }

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
        public string[] ContactTags { get; set; }
    }

    public class RepfabricCreateCompanyInput
    {
        [JsonProperty("domain-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DomainName { get; set; }

        [JsonProperty("company-name")]
        public string CompanyName { get; set; }

        [JsonProperty("company-type-id")]
        public int? CompanyTypeId { get; set; }

        [JsonProperty("company-type")]
        public string CompanyType { get; set; }

        [JsonProperty("company-class-id")]
        public int? CompanyClassId { get; set; }

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
    }

    public class RepfabricCreateQuoteInput
    {
        [JsonProperty("domain-name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DomainName { get; set; }

        [JsonProperty("quotes-base-url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string QuotesBaseUrl { get; set; }

        [JsonProperty("auth-quotes", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AuthQuotes { get; set; }

        [JsonProperty("company-name")]
        public string CompanyName { get; set; }

        [JsonProperty("company-type-id")]
        public int? CompanyTypeId { get; set; }

        [JsonProperty("company-type")]
        public string CompanyType { get; set; }

        [JsonProperty("company-phone1")]
        public string CompanyPhone1 { get; set; }

        [JsonProperty("company-street")]
        public string CompanyStreet { get; set; }

        [JsonProperty("company-city")]
        public string CompanyCity { get; set; }

        [JsonProperty("company-state")]
        public string CompanyState { get; set; }

        [JsonProperty("company-zip")]
        public string CompanyZip { get; set; }

        [JsonProperty("company-website")]
        public string CompanyWebsite { get; set; }

        [JsonProperty("contact-first-name")]
        public string ContactFirstName { get; set; }

        [JsonProperty("contact-last-name")]
        public string ContactLastName { get; set; }

        [JsonProperty("contact-email-address-work")]
        public string ContactEmailAddressWork { get; set; }

        [JsonProperty("contact-phone-number-work")]
        public string ContactPhoneNumberWork { get; set; }

        [JsonProperty("contact-title")]
        public string ContactTitle { get; set; }

        [JsonProperty("quote-number")]
        public string QuoteNumber { get; set; }

        [JsonProperty("quote-date")]
        public string QuoteDate { get; set; }

        [JsonProperty("expiry-date")]
        public string ExpiryDate { get; set; }

        [JsonProperty("follow-up")]
        public string FollowUp { get; set; }

        [JsonProperty("program")]
        public string Program { get; set; }

        [JsonProperty("principal-name")]
        public string PrincipalName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("line-item")]
        public RepfabricCreateQuoteInputLineItemType LineItem { get; set; }
    }

    public class RepfabricCreateQuoteInputLineItemType
    {
        [JsonProperty("part-num")]
        public string PartNum { get; set; }

        [JsonProperty("cust-part")]
        public string CustPart { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("order-qty")]
        public string OrderQty { get; set; }

        [JsonProperty("unit-price")]
        public string UnitPrice { get; set; }

        [JsonProperty("ext-price")]
        public string ExtPrice { get; set; }

        [JsonProperty("product-line")]
        public string ProductLine { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Requests;

    public partial class WorkflowManagedActions
    {
        public RequestsActions Requests(string connectionId) => new RequestsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RequestsTriggers Requests(string connectionId) => new RequestsTriggers(connectionId);
    }
}