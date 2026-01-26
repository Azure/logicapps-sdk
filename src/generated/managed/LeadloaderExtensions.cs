//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leadloader
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeadloaderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leadloader")]
        public IBodyWorkflowAction<UploadLeadsV3Response> UploadLeadsV3(Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodycompanyType = null, Expression<Func<string>> bodycompanyClass = null, Expression<Func<string>> bodycompanyCategory = null, Expression<Func<string>> bodycompanyPhone1 = null, Expression<Func<string>> bodycompanyPhone2 = null, Expression<Func<string>> bodycompanyFax = null, Expression<Func<string>> bodycompanyRegion = null, Expression<Func<string>> bodycompanyStreet = null, Expression<Func<string>> bodycompanyCity = null, Expression<Func<string>> bodycompanyState = null, Expression<Func<string>> bodycompanyZip = null, Expression<Func<string>> bodycompanyCountry = null, Expression<Func<string>> bodycompanyPoBox = null, Expression<Func<string>> bodycompanyWebsite = null, Expression<Func<string>> bodycompanyComments = null, Expression<Func<string>> bodycompanySalesTeam = null, Expression<Func<string>> bodycompanyIndustries = null, Expression<Func<string>> bodycompanyProductPotentials = null, Expression<Func<string>> bodycontactFirstName = null, Expression<Func<string>> bodycontactLastName = null, Expression<Func<string>> bodycontactFullName = null, Expression<Func<string>> bodycontactTitle = null, Expression<Func<string>> bodycontactBackground = null, Expression<Func<bool>> bodycontactPrimaryContact = null, Expression<Func<string>> bodycontactTypeName = null, Expression<Func<string>> bodycontactEmailAddressWork = null, Expression<Func<string>> bodycontactEmailAddressPersonal = null, Expression<Func<string>> bodycontactEmailAddressAlternate = null, Expression<Func<string>> bodycontactEmailAddressOther = null, Expression<Func<string>> bodycontactPhoneNumberWork = null, Expression<Func<string>> bodycontactPhoneNumberHome = null, Expression<Func<string>> bodycontactPhoneNumberMobile = null, Expression<Func<string>> bodycontactPhoneNumberAlternate = null, Expression<Func<string>> bodycontactFax = null, Expression<Func<string>> bodycontactBusinessStreet = null, Expression<Func<string>> bodycontactBusinessCity = null, Expression<Func<string>> bodycontactBusinessState = null, Expression<Func<string>> bodycontactBusinessZip = null, Expression<Func<string>> bodycontactBusinessCountry = null, Expression<Func<string>> bodycontactHomeStreet = null, Expression<Func<string>> bodycontactHomeCity = null, Expression<Func<string>> bodycontactHomeState = null, Expression<Func<string>> bodycontactHomeZip = null, Expression<Func<string>> bodycontactHomeCountry = null, Expression<Func<string>> bodycontactNotes = null, Expression<Func<string>> bodycontactGroups = null, Expression<Func<string>> bodycontactProductInterests = null, Expression<Func<string>> bodyopportunityPrincipalName = null, Expression<Func<string>> bodyopportunityProgram = null, Expression<Func<string>> bodyopportunityCustomerName = null, Expression<Func<string>> bodyopportunityDistributorName = null, Expression<Func<string>> bodyopportunityCustomerContact = null, Expression<Func<string>> bodyopportunityPrincipalContact = null, Expression<Func<string>> bodyopportunityDistributorContact = null, Expression<Func<string>> bodyopportunityNextStep = null, Expression<Func<string>> bodyopportunityActivity = null, Expression<Func<string>> bodyopportunityStatus = null, Expression<Func<string>> bodyopportunityFollowUp = null, Expression<Func<int>> bodyopportunityPriority = null, Expression<Func<int>> bodyopportunityPotential = null, Expression<Func<int>> bodyopportunityEau = null, Expression<Func<int>> bodyopportunityValue = null, Expression<Func<string>> bodyopportunityPrototypeDate = null, Expression<Func<string>> bodyopportunityProductionDate = null, Expression<Func<int>> bodyopportunityCloseStatus = null, Expression<Func<string>> bodyopportunityCloseDate = null, Expression<Func<string>> bodyopportunityDescription = null, Expression<Func<string>> bodyopportunityCompetitor1 = null, Expression<Func<string>> bodyopportunityCompetitor2 = null, Expression<Func<string>> bodyopportunityReportingComments = null, Expression<Func<string>> bodyopportunityLeadSourceName = null, Expression<Func<string>> bodydomain = null, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodypassword = null)
        {
            var apiCallPath = "/contact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycompany != null)
            {
                body["company"] = ExpressionConverter.ConvertO(bodycompany);
                bodypropCount++;
            }

            if (bodycompanyType != null)
            {
                body["company-type"] = ExpressionConverter.ConvertO(bodycompanyType);
                bodypropCount++;
            }

            if (bodycompanyClass != null)
            {
                body["company-class"] = ExpressionConverter.ConvertO(bodycompanyClass);
                bodypropCount++;
            }

            if (bodycompanyCategory != null)
            {
                body["company-category"] = ExpressionConverter.ConvertO(bodycompanyCategory);
                bodypropCount++;
            }

            if (bodycompanyPhone1 != null)
            {
                body["company-phone1"] = ExpressionConverter.ConvertO(bodycompanyPhone1);
                bodypropCount++;
            }

            if (bodycompanyPhone2 != null)
            {
                body["company-phone2"] = ExpressionConverter.ConvertO(bodycompanyPhone2);
                bodypropCount++;
            }

            if (bodycompanyFax != null)
            {
                body["company-fax"] = ExpressionConverter.ConvertO(bodycompanyFax);
                bodypropCount++;
            }

            if (bodycompanyRegion != null)
            {
                body["company-region"] = ExpressionConverter.ConvertO(bodycompanyRegion);
                bodypropCount++;
            }

            if (bodycompanyStreet != null)
            {
                body["company-street"] = ExpressionConverter.ConvertO(bodycompanyStreet);
                bodypropCount++;
            }

            if (bodycompanyCity != null)
            {
                body["company-city"] = ExpressionConverter.ConvertO(bodycompanyCity);
                bodypropCount++;
            }

            if (bodycompanyState != null)
            {
                body["company-state"] = ExpressionConverter.ConvertO(bodycompanyState);
                bodypropCount++;
            }

            if (bodycompanyZip != null)
            {
                body["company-zip"] = ExpressionConverter.ConvertO(bodycompanyZip);
                bodypropCount++;
            }

            if (bodycompanyCountry != null)
            {
                body["company-country"] = ExpressionConverter.ConvertO(bodycompanyCountry);
                bodypropCount++;
            }

            if (bodycompanyPoBox != null)
            {
                body["company-po-box"] = ExpressionConverter.ConvertO(bodycompanyPoBox);
                bodypropCount++;
            }

            if (bodycompanyWebsite != null)
            {
                body["company-website"] = ExpressionConverter.ConvertO(bodycompanyWebsite);
                bodypropCount++;
            }

            if (bodycompanyComments != null)
            {
                body["company-comments"] = ExpressionConverter.ConvertO(bodycompanyComments);
                bodypropCount++;
            }

            if (bodycompanySalesTeam != null)
            {
                body["company-sales-team"] = ExpressionConverter.ConvertO(bodycompanySalesTeam);
                bodypropCount++;
            }

            if (bodycompanyIndustries != null)
            {
                body["company-industries"] = ExpressionConverter.ConvertO(bodycompanyIndustries);
                bodypropCount++;
            }

            if (bodycompanyProductPotentials != null)
            {
                body["company-product-potentials"] = ExpressionConverter.ConvertO(bodycompanyProductPotentials);
                bodypropCount++;
            }

            if (bodycontactFirstName != null)
            {
                body["contact-first-name"] = ExpressionConverter.ConvertO(bodycontactFirstName);
                bodypropCount++;
            }

            if (bodycontactLastName != null)
            {
                body["contact-last-name"] = ExpressionConverter.ConvertO(bodycontactLastName);
                bodypropCount++;
            }

            if (bodycontactFullName != null)
            {
                body["contact-full-name"] = ExpressionConverter.ConvertO(bodycontactFullName);
                bodypropCount++;
            }

            if (bodycontactTitle != null)
            {
                body["contact-title"] = ExpressionConverter.ConvertO(bodycontactTitle);
                bodypropCount++;
            }

            if (bodycontactBackground != null)
            {
                body["contact-background"] = ExpressionConverter.ConvertO(bodycontactBackground);
                bodypropCount++;
            }

            if (bodycontactPrimaryContact != null)
            {
                body["contact-primary-contact"] = ExpressionConverter.ConvertO(bodycontactPrimaryContact);
                bodypropCount++;
            }

            if (bodycontactTypeName != null)
            {
                body["contact-type-name"] = ExpressionConverter.ConvertO(bodycontactTypeName);
                bodypropCount++;
            }

            if (bodycontactEmailAddressWork != null)
            {
                body["contact-email-address-work"] = ExpressionConverter.ConvertO(bodycontactEmailAddressWork);
                bodypropCount++;
            }

            if (bodycontactEmailAddressPersonal != null)
            {
                body["contact-email-address-personal"] = ExpressionConverter.ConvertO(bodycontactEmailAddressPersonal);
                bodypropCount++;
            }

            if (bodycontactEmailAddressAlternate != null)
            {
                body["contact-email-address-alternate"] = ExpressionConverter.ConvertO(bodycontactEmailAddressAlternate);
                bodypropCount++;
            }

            if (bodycontactEmailAddressOther != null)
            {
                body["contact-email-address-other"] = ExpressionConverter.ConvertO(bodycontactEmailAddressOther);
                bodypropCount++;
            }

            if (bodycontactPhoneNumberWork != null)
            {
                body["contact-phone-number-work"] = ExpressionConverter.ConvertO(bodycontactPhoneNumberWork);
                bodypropCount++;
            }

            if (bodycontactPhoneNumberHome != null)
            {
                body["contact-phone-number-home"] = ExpressionConverter.ConvertO(bodycontactPhoneNumberHome);
                bodypropCount++;
            }

            if (bodycontactPhoneNumberMobile != null)
            {
                body["contact-phone-number-mobile"] = ExpressionConverter.ConvertO(bodycontactPhoneNumberMobile);
                bodypropCount++;
            }

            if (bodycontactPhoneNumberAlternate != null)
            {
                body["contact-phone-number-alternate"] = ExpressionConverter.ConvertO(bodycontactPhoneNumberAlternate);
                bodypropCount++;
            }

            if (bodycontactFax != null)
            {
                body["contact-fax"] = ExpressionConverter.ConvertO(bodycontactFax);
                bodypropCount++;
            }

            if (bodycontactBusinessStreet != null)
            {
                body["contact-business-street"] = ExpressionConverter.ConvertO(bodycontactBusinessStreet);
                bodypropCount++;
            }

            if (bodycontactBusinessCity != null)
            {
                body["contact-business-city"] = ExpressionConverter.ConvertO(bodycontactBusinessCity);
                bodypropCount++;
            }

            if (bodycontactBusinessState != null)
            {
                body["contact-business-state"] = ExpressionConverter.ConvertO(bodycontactBusinessState);
                bodypropCount++;
            }

            if (bodycontactBusinessZip != null)
            {
                body["contact-business-zip"] = ExpressionConverter.ConvertO(bodycontactBusinessZip);
                bodypropCount++;
            }

            if (bodycontactBusinessCountry != null)
            {
                body["contact-business-country"] = ExpressionConverter.ConvertO(bodycontactBusinessCountry);
                bodypropCount++;
            }

            if (bodycontactHomeStreet != null)
            {
                body["contact-home-street"] = ExpressionConverter.ConvertO(bodycontactHomeStreet);
                bodypropCount++;
            }

            if (bodycontactHomeCity != null)
            {
                body["contact-home-city"] = ExpressionConverter.ConvertO(bodycontactHomeCity);
                bodypropCount++;
            }

            if (bodycontactHomeState != null)
            {
                body["contact-home-state"] = ExpressionConverter.ConvertO(bodycontactHomeState);
                bodypropCount++;
            }

            if (bodycontactHomeZip != null)
            {
                body["contact-home-zip"] = ExpressionConverter.ConvertO(bodycontactHomeZip);
                bodypropCount++;
            }

            if (bodycontactHomeCountry != null)
            {
                body["contact-home-country"] = ExpressionConverter.ConvertO(bodycontactHomeCountry);
                bodypropCount++;
            }

            if (bodycontactNotes != null)
            {
                body["contact-notes"] = ExpressionConverter.ConvertO(bodycontactNotes);
                bodypropCount++;
            }

            if (bodycontactGroups != null)
            {
                body["contact-groups"] = ExpressionConverter.ConvertO(bodycontactGroups);
                bodypropCount++;
            }

            if (bodycontactProductInterests != null)
            {
                body["contact-product-interests"] = ExpressionConverter.ConvertO(bodycontactProductInterests);
                bodypropCount++;
            }

            if (bodyopportunityPrincipalName != null)
            {
                body["opportunity-principal-name"] = ExpressionConverter.ConvertO(bodyopportunityPrincipalName);
                bodypropCount++;
            }

            if (bodyopportunityProgram != null)
            {
                body["opportunity-program"] = ExpressionConverter.ConvertO(bodyopportunityProgram);
                bodypropCount++;
            }

            if (bodyopportunityCustomerName != null)
            {
                body["opportunity-customer-name"] = ExpressionConverter.ConvertO(bodyopportunityCustomerName);
                bodypropCount++;
            }

            if (bodyopportunityDistributorName != null)
            {
                body["opportunity-distributor-name"] = ExpressionConverter.ConvertO(bodyopportunityDistributorName);
                bodypropCount++;
            }

            if (bodyopportunityCustomerContact != null)
            {
                body["opportunity-customer-contact"] = ExpressionConverter.ConvertO(bodyopportunityCustomerContact);
                bodypropCount++;
            }

            if (bodyopportunityPrincipalContact != null)
            {
                body["opportunity-principal-contact"] = ExpressionConverter.ConvertO(bodyopportunityPrincipalContact);
                bodypropCount++;
            }

            if (bodyopportunityDistributorContact != null)
            {
                body["opportunity-distributor-contact"] = ExpressionConverter.ConvertO(bodyopportunityDistributorContact);
                bodypropCount++;
            }

            if (bodyopportunityNextStep != null)
            {
                body["opportunity-next-step"] = ExpressionConverter.ConvertO(bodyopportunityNextStep);
                bodypropCount++;
            }

            if (bodyopportunityActivity != null)
            {
                body["opportunity-activity"] = ExpressionConverter.ConvertO(bodyopportunityActivity);
                bodypropCount++;
            }

            if (bodyopportunityStatus != null)
            {
                body["opportunity-status"] = ExpressionConverter.ConvertO(bodyopportunityStatus);
                bodypropCount++;
            }

            if (bodyopportunityFollowUp != null)
            {
                body["opportunity-follow-up"] = ExpressionConverter.ConvertO(bodyopportunityFollowUp);
                bodypropCount++;
            }

            if (bodyopportunityPriority != null)
            {
                body["opportunity-priority"] = ExpressionConverter.ConvertO(bodyopportunityPriority);
                bodypropCount++;
            }

            if (bodyopportunityPotential != null)
            {
                body["opportunity-potential"] = ExpressionConverter.ConvertO(bodyopportunityPotential);
                bodypropCount++;
            }

            if (bodyopportunityEau != null)
            {
                body["opportunity-eau"] = ExpressionConverter.ConvertO(bodyopportunityEau);
                bodypropCount++;
            }

            if (bodyopportunityValue != null)
            {
                body["opportunity-value"] = ExpressionConverter.ConvertO(bodyopportunityValue);
                bodypropCount++;
            }

            if (bodyopportunityPrototypeDate != null)
            {
                body["opportunity-prototype-date"] = ExpressionConverter.ConvertO(bodyopportunityPrototypeDate);
                bodypropCount++;
            }

            if (bodyopportunityProductionDate != null)
            {
                body["opportunity-production-date"] = ExpressionConverter.ConvertO(bodyopportunityProductionDate);
                bodypropCount++;
            }

            if (bodyopportunityCloseStatus != null)
            {
                body["opportunity-close-status"] = ExpressionConverter.ConvertO(bodyopportunityCloseStatus);
                bodypropCount++;
            }

            if (bodyopportunityCloseDate != null)
            {
                body["opportunity-close-date"] = ExpressionConverter.ConvertO(bodyopportunityCloseDate);
                bodypropCount++;
            }

            if (bodyopportunityDescription != null)
            {
                body["opportunity-description"] = ExpressionConverter.ConvertO(bodyopportunityDescription);
                bodypropCount++;
            }

            if (bodyopportunityCompetitor1 != null)
            {
                body["opportunity-competitor-1"] = ExpressionConverter.ConvertO(bodyopportunityCompetitor1);
                bodypropCount++;
            }

            if (bodyopportunityCompetitor2 != null)
            {
                body["opportunity-competitor-2"] = ExpressionConverter.ConvertO(bodyopportunityCompetitor2);
                bodypropCount++;
            }

            if (bodyopportunityReportingComments != null)
            {
                body["opportunity-reporting-comments"] = ExpressionConverter.ConvertO(bodyopportunityReportingComments);
                bodypropCount++;
            }

            if (bodyopportunityLeadSourceName != null)
            {
                body["opportunity-lead-source-name"] = ExpressionConverter.ConvertO(bodyopportunityLeadSourceName);
                bodypropCount++;
            }

            if (bodydomain != null)
            {
                body["domain"] = ExpressionConverter.ConvertO(bodydomain);
                bodypropCount++;
            }

            if (bodyusername != null)
            {
                body["username"] = ExpressionConverter.ConvertO(bodyusername);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = ExpressionConverter.ConvertO(bodypassword);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UploadLeadsV3Response>(callPayload);
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