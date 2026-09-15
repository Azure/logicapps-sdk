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
        public IBodyWorkflowAction<UploadLeadsV3Response> UploadLeads(Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodycompanyType = null, Expression<Func<string>> bodycompanyClass = null, Expression<Func<string>> bodycompanyCategory = null, Expression<Func<string>> bodycompanyPhone1 = null, Expression<Func<string>> bodycompanyPhone2 = null, Expression<Func<string>> bodycompanyFax = null, Expression<Func<string>> bodycompanyRegion = null, Expression<Func<string>> bodycompanyStreet = null, Expression<Func<string>> bodycompanyCity = null, Expression<Func<string>> bodycompanyState = null, Expression<Func<string>> bodycompanyZip = null, Expression<Func<string>> bodycompanyCountry = null, Expression<Func<string>> bodycompanyPoBox = null, Expression<Func<string>> bodycompanyWebsite = null, Expression<Func<string>> bodycompanyComments = null, Expression<Func<string>> bodycompanySalesTeam = null, Expression<Func<string>> bodycompanyIndustries = null, Expression<Func<string>> bodycompanyProductPotentials = null, Expression<Func<string>> bodycontactFirstName = null, Expression<Func<string>> bodycontactLastName = null, Expression<Func<string>> bodycontactFullName = null, Expression<Func<string>> bodycontactTitle = null, Expression<Func<string>> bodycontactBackground = null, Expression<Func<bool>> bodycontactPrimaryContact = null, Expression<Func<string>> bodycontactTypeName = null, Expression<Func<string>> bodycontactEmailAddressWork = null, Expression<Func<string>> bodycontactEmailAddressPersonal = null, Expression<Func<string>> bodycontactEmailAddressAlternate = null, Expression<Func<string>> bodycontactEmailAddressOther = null, Expression<Func<string>> bodycontactPhoneNumberWork = null, Expression<Func<string>> bodycontactPhoneNumberHome = null, Expression<Func<string>> bodycontactPhoneNumberMobile = null, Expression<Func<string>> bodycontactPhoneNumberAlternate = null, Expression<Func<string>> bodycontactFax = null, Expression<Func<string>> bodycontactBusinessStreet = null, Expression<Func<string>> bodycontactBusinessCity = null, Expression<Func<string>> bodycontactBusinessState = null, Expression<Func<string>> bodycontactBusinessZip = null, Expression<Func<string>> bodycontactBusinessCountry = null, Expression<Func<string>> bodycontactHomeStreet = null, Expression<Func<string>> bodycontactHomeCity = null, Expression<Func<string>> bodycontactHomeState = null, Expression<Func<string>> bodycontactHomeZip = null, Expression<Func<string>> bodycontactHomeCountry = null, Expression<Func<string>> bodycontactNotes = null, Expression<Func<string>> bodycontactGroups = null, Expression<Func<string>> bodycontactProductInterests = null, Expression<Func<string>> bodyopportunityPrincipalName = null, Expression<Func<string>> bodyopportunityProgram = null, Expression<Func<string>> bodyopportunityCustomerName = null, Expression<Func<string>> bodyopportunityDistributorName = null, Expression<Func<string>> bodyopportunityCustomerContact = null, Expression<Func<string>> bodyopportunityPrincipalContact = null, Expression<Func<string>> bodyopportunityDistributorContact = null, Expression<Func<string>> bodyopportunityNextStep = null, Expression<Func<string>> bodyopportunityActivity = null, Expression<Func<string>> bodyopportunityStatus = null, Expression<Func<string>> bodyopportunityFollowUp = null, Expression<Func<int>> bodyopportunityPriority = null, Expression<Func<int>> bodyopportunityPotential = null, Expression<Func<int>> bodyopportunityEau = null, Expression<Func<int>> bodyopportunityValue = null, Expression<Func<string>> bodyopportunityPrototypeDate = null, Expression<Func<string>> bodyopportunityProductionDate = null, Expression<Func<int>> bodyopportunityCloseStatus = null, Expression<Func<string>> bodyopportunityCloseDate = null, Expression<Func<string>> bodyopportunityDescription = null, Expression<Func<string>> bodyopportunityCompetitor1 = null, Expression<Func<string>> bodyopportunityCompetitor2 = null, Expression<Func<string>> bodyopportunityReportingComments = null, Expression<Func<string>> bodyopportunityLeadSourceName = null, Expression<Func<string>> bodydomain = null, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodypassword = null)
        {
            var apiCallPath = "/contact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycompany != null)
            {
                body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
            }

            if (bodycompanyType != null)
            {
                body["company-type"] = CSharpExpressionConverter.ConvertToken(bodycompanyType);
                bodypropCount++;
            }

            if (bodycompanyClass != null)
            {
                body["company-class"] = CSharpExpressionConverter.ConvertToken(bodycompanyClass);
                bodypropCount++;
            }

            if (bodycompanyCategory != null)
            {
                body["company-category"] = CSharpExpressionConverter.ConvertToken(bodycompanyCategory);
                bodypropCount++;
            }

            if (bodycompanyPhone1 != null)
            {
                body["company-phone1"] = CSharpExpressionConverter.ConvertToken(bodycompanyPhone1);
                bodypropCount++;
            }

            if (bodycompanyPhone2 != null)
            {
                body["company-phone2"] = CSharpExpressionConverter.ConvertToken(bodycompanyPhone2);
                bodypropCount++;
            }

            if (bodycompanyFax != null)
            {
                body["company-fax"] = CSharpExpressionConverter.ConvertToken(bodycompanyFax);
                bodypropCount++;
            }

            if (bodycompanyRegion != null)
            {
                body["company-region"] = CSharpExpressionConverter.ConvertToken(bodycompanyRegion);
                bodypropCount++;
            }

            if (bodycompanyStreet != null)
            {
                body["company-street"] = CSharpExpressionConverter.ConvertToken(bodycompanyStreet);
                bodypropCount++;
            }

            if (bodycompanyCity != null)
            {
                body["company-city"] = CSharpExpressionConverter.ConvertToken(bodycompanyCity);
                bodypropCount++;
            }

            if (bodycompanyState != null)
            {
                body["company-state"] = CSharpExpressionConverter.ConvertToken(bodycompanyState);
                bodypropCount++;
            }

            if (bodycompanyZip != null)
            {
                body["company-zip"] = CSharpExpressionConverter.ConvertToken(bodycompanyZip);
                bodypropCount++;
            }

            if (bodycompanyCountry != null)
            {
                body["company-country"] = CSharpExpressionConverter.ConvertToken(bodycompanyCountry);
                bodypropCount++;
            }

            if (bodycompanyPoBox != null)
            {
                body["company-po-box"] = CSharpExpressionConverter.ConvertToken(bodycompanyPoBox);
                bodypropCount++;
            }

            if (bodycompanyWebsite != null)
            {
                body["company-website"] = CSharpExpressionConverter.ConvertToken(bodycompanyWebsite);
                bodypropCount++;
            }

            if (bodycompanyComments != null)
            {
                body["company-comments"] = CSharpExpressionConverter.ConvertToken(bodycompanyComments);
                bodypropCount++;
            }

            if (bodycompanySalesTeam != null)
            {
                body["company-sales-team"] = CSharpExpressionConverter.ConvertToken(bodycompanySalesTeam);
                bodypropCount++;
            }

            if (bodycompanyIndustries != null)
            {
                body["company-industries"] = CSharpExpressionConverter.ConvertToken(bodycompanyIndustries);
                bodypropCount++;
            }

            if (bodycompanyProductPotentials != null)
            {
                body["company-product-potentials"] = CSharpExpressionConverter.ConvertToken(bodycompanyProductPotentials);
                bodypropCount++;
            }

            if (bodycontactFirstName != null)
            {
                body["contact-first-name"] = CSharpExpressionConverter.ConvertToken(bodycontactFirstName);
                bodypropCount++;
            }

            if (bodycontactLastName != null)
            {
                body["contact-last-name"] = CSharpExpressionConverter.ConvertToken(bodycontactLastName);
                bodypropCount++;
            }

            if (bodycontactFullName != null)
            {
                body["contact-full-name"] = CSharpExpressionConverter.ConvertToken(bodycontactFullName);
                bodypropCount++;
            }

            if (bodycontactTitle != null)
            {
                body["contact-title"] = CSharpExpressionConverter.ConvertToken(bodycontactTitle);
                bodypropCount++;
            }

            if (bodycontactBackground != null)
            {
                body["contact-background"] = CSharpExpressionConverter.ConvertToken(bodycontactBackground);
                bodypropCount++;
            }

            if (bodycontactPrimaryContact != null)
            {
                body["contact-primary-contact"] = CSharpExpressionConverter.ConvertToken(bodycontactPrimaryContact);
                bodypropCount++;
            }

            if (bodycontactTypeName != null)
            {
                body["contact-type-name"] = CSharpExpressionConverter.ConvertToken(bodycontactTypeName);
                bodypropCount++;
            }

            if (bodycontactEmailAddressWork != null)
            {
                body["contact-email-address-work"] = CSharpExpressionConverter.ConvertToken(bodycontactEmailAddressWork);
                bodypropCount++;
            }

            if (bodycontactEmailAddressPersonal != null)
            {
                body["contact-email-address-personal"] = CSharpExpressionConverter.ConvertToken(bodycontactEmailAddressPersonal);
                bodypropCount++;
            }

            if (bodycontactEmailAddressAlternate != null)
            {
                body["contact-email-address-alternate"] = CSharpExpressionConverter.ConvertToken(bodycontactEmailAddressAlternate);
                bodypropCount++;
            }

            if (bodycontactEmailAddressOther != null)
            {
                body["contact-email-address-other"] = CSharpExpressionConverter.ConvertToken(bodycontactEmailAddressOther);
                bodypropCount++;
            }

            if (bodycontactPhoneNumberWork != null)
            {
                body["contact-phone-number-work"] = CSharpExpressionConverter.ConvertToken(bodycontactPhoneNumberWork);
                bodypropCount++;
            }

            if (bodycontactPhoneNumberHome != null)
            {
                body["contact-phone-number-home"] = CSharpExpressionConverter.ConvertToken(bodycontactPhoneNumberHome);
                bodypropCount++;
            }

            if (bodycontactPhoneNumberMobile != null)
            {
                body["contact-phone-number-mobile"] = CSharpExpressionConverter.ConvertToken(bodycontactPhoneNumberMobile);
                bodypropCount++;
            }

            if (bodycontactPhoneNumberAlternate != null)
            {
                body["contact-phone-number-alternate"] = CSharpExpressionConverter.ConvertToken(bodycontactPhoneNumberAlternate);
                bodypropCount++;
            }

            if (bodycontactFax != null)
            {
                body["contact-fax"] = CSharpExpressionConverter.ConvertToken(bodycontactFax);
                bodypropCount++;
            }

            if (bodycontactBusinessStreet != null)
            {
                body["contact-business-street"] = CSharpExpressionConverter.ConvertToken(bodycontactBusinessStreet);
                bodypropCount++;
            }

            if (bodycontactBusinessCity != null)
            {
                body["contact-business-city"] = CSharpExpressionConverter.ConvertToken(bodycontactBusinessCity);
                bodypropCount++;
            }

            if (bodycontactBusinessState != null)
            {
                body["contact-business-state"] = CSharpExpressionConverter.ConvertToken(bodycontactBusinessState);
                bodypropCount++;
            }

            if (bodycontactBusinessZip != null)
            {
                body["contact-business-zip"] = CSharpExpressionConverter.ConvertToken(bodycontactBusinessZip);
                bodypropCount++;
            }

            if (bodycontactBusinessCountry != null)
            {
                body["contact-business-country"] = CSharpExpressionConverter.ConvertToken(bodycontactBusinessCountry);
                bodypropCount++;
            }

            if (bodycontactHomeStreet != null)
            {
                body["contact-home-street"] = CSharpExpressionConverter.ConvertToken(bodycontactHomeStreet);
                bodypropCount++;
            }

            if (bodycontactHomeCity != null)
            {
                body["contact-home-city"] = CSharpExpressionConverter.ConvertToken(bodycontactHomeCity);
                bodypropCount++;
            }

            if (bodycontactHomeState != null)
            {
                body["contact-home-state"] = CSharpExpressionConverter.ConvertToken(bodycontactHomeState);
                bodypropCount++;
            }

            if (bodycontactHomeZip != null)
            {
                body["contact-home-zip"] = CSharpExpressionConverter.ConvertToken(bodycontactHomeZip);
                bodypropCount++;
            }

            if (bodycontactHomeCountry != null)
            {
                body["contact-home-country"] = CSharpExpressionConverter.ConvertToken(bodycontactHomeCountry);
                bodypropCount++;
            }

            if (bodycontactNotes != null)
            {
                body["contact-notes"] = CSharpExpressionConverter.ConvertToken(bodycontactNotes);
                bodypropCount++;
            }

            if (bodycontactGroups != null)
            {
                body["contact-groups"] = CSharpExpressionConverter.ConvertToken(bodycontactGroups);
                bodypropCount++;
            }

            if (bodycontactProductInterests != null)
            {
                body["contact-product-interests"] = CSharpExpressionConverter.ConvertToken(bodycontactProductInterests);
                bodypropCount++;
            }

            if (bodyopportunityPrincipalName != null)
            {
                body["opportunity-principal-name"] = CSharpExpressionConverter.ConvertToken(bodyopportunityPrincipalName);
                bodypropCount++;
            }

            if (bodyopportunityProgram != null)
            {
                body["opportunity-program"] = CSharpExpressionConverter.ConvertToken(bodyopportunityProgram);
                bodypropCount++;
            }

            if (bodyopportunityCustomerName != null)
            {
                body["opportunity-customer-name"] = CSharpExpressionConverter.ConvertToken(bodyopportunityCustomerName);
                bodypropCount++;
            }

            if (bodyopportunityDistributorName != null)
            {
                body["opportunity-distributor-name"] = CSharpExpressionConverter.ConvertToken(bodyopportunityDistributorName);
                bodypropCount++;
            }

            if (bodyopportunityCustomerContact != null)
            {
                body["opportunity-customer-contact"] = CSharpExpressionConverter.ConvertToken(bodyopportunityCustomerContact);
                bodypropCount++;
            }

            if (bodyopportunityPrincipalContact != null)
            {
                body["opportunity-principal-contact"] = CSharpExpressionConverter.ConvertToken(bodyopportunityPrincipalContact);
                bodypropCount++;
            }

            if (bodyopportunityDistributorContact != null)
            {
                body["opportunity-distributor-contact"] = CSharpExpressionConverter.ConvertToken(bodyopportunityDistributorContact);
                bodypropCount++;
            }

            if (bodyopportunityNextStep != null)
            {
                body["opportunity-next-step"] = CSharpExpressionConverter.ConvertToken(bodyopportunityNextStep);
                bodypropCount++;
            }

            if (bodyopportunityActivity != null)
            {
                body["opportunity-activity"] = CSharpExpressionConverter.ConvertToken(bodyopportunityActivity);
                bodypropCount++;
            }

            if (bodyopportunityStatus != null)
            {
                body["opportunity-status"] = CSharpExpressionConverter.ConvertToken(bodyopportunityStatus);
                bodypropCount++;
            }

            if (bodyopportunityFollowUp != null)
            {
                body["opportunity-follow-up"] = CSharpExpressionConverter.ConvertToken(bodyopportunityFollowUp);
                bodypropCount++;
            }

            if (bodyopportunityPriority != null)
            {
                body["opportunity-priority"] = CSharpExpressionConverter.ConvertToken(bodyopportunityPriority);
                bodypropCount++;
            }

            if (bodyopportunityPotential != null)
            {
                body["opportunity-potential"] = CSharpExpressionConverter.ConvertToken(bodyopportunityPotential);
                bodypropCount++;
            }

            if (bodyopportunityEau != null)
            {
                body["opportunity-eau"] = CSharpExpressionConverter.ConvertToken(bodyopportunityEau);
                bodypropCount++;
            }

            if (bodyopportunityValue != null)
            {
                body["opportunity-value"] = CSharpExpressionConverter.ConvertToken(bodyopportunityValue);
                bodypropCount++;
            }

            if (bodyopportunityPrototypeDate != null)
            {
                body["opportunity-prototype-date"] = CSharpExpressionConverter.ConvertToken(bodyopportunityPrototypeDate);
                bodypropCount++;
            }

            if (bodyopportunityProductionDate != null)
            {
                body["opportunity-production-date"] = CSharpExpressionConverter.ConvertToken(bodyopportunityProductionDate);
                bodypropCount++;
            }

            if (bodyopportunityCloseStatus != null)
            {
                body["opportunity-close-status"] = CSharpExpressionConverter.ConvertToken(bodyopportunityCloseStatus);
                bodypropCount++;
            }

            if (bodyopportunityCloseDate != null)
            {
                body["opportunity-close-date"] = CSharpExpressionConverter.ConvertToken(bodyopportunityCloseDate);
                bodypropCount++;
            }

            if (bodyopportunityDescription != null)
            {
                body["opportunity-description"] = CSharpExpressionConverter.ConvertToken(bodyopportunityDescription);
                bodypropCount++;
            }

            if (bodyopportunityCompetitor1 != null)
            {
                body["opportunity-competitor-1"] = CSharpExpressionConverter.ConvertToken(bodyopportunityCompetitor1);
                bodypropCount++;
            }

            if (bodyopportunityCompetitor2 != null)
            {
                body["opportunity-competitor-2"] = CSharpExpressionConverter.ConvertToken(bodyopportunityCompetitor2);
                bodypropCount++;
            }

            if (bodyopportunityReportingComments != null)
            {
                body["opportunity-reporting-comments"] = CSharpExpressionConverter.ConvertToken(bodyopportunityReportingComments);
                bodypropCount++;
            }

            if (bodyopportunityLeadSourceName != null)
            {
                body["opportunity-lead-source-name"] = CSharpExpressionConverter.ConvertToken(bodyopportunityLeadSourceName);
                bodypropCount++;
            }

            if (bodydomain != null)
            {
                body["domain"] = CSharpExpressionConverter.ConvertToken(bodydomain);
                bodypropCount++;
            }

            if (bodyusername != null)
            {
                body["username"] = CSharpExpressionConverter.ConvertToken(bodyusername);
                bodypropCount++;
            }

            if (bodypassword != null)
            {
                body["password"] = CSharpExpressionConverter.ConvertToken(bodypassword);
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