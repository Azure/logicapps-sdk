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
        public IBodyWorkflowAction<UploadLeadsV3Response> UploadLeads([WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodycompanyType = null, [WorkflowExpression] Func<string> bodycompanyClass = null, [WorkflowExpression] Func<string> bodycompanyCategory = null, [WorkflowExpression] Func<string> bodycompanyPhone1 = null, [WorkflowExpression] Func<string> bodycompanyPhone2 = null, [WorkflowExpression] Func<string> bodycompanyFax = null, [WorkflowExpression] Func<string> bodycompanyRegion = null, [WorkflowExpression] Func<string> bodycompanyStreet = null, [WorkflowExpression] Func<string> bodycompanyCity = null, [WorkflowExpression] Func<string> bodycompanyState = null, [WorkflowExpression] Func<string> bodycompanyZip = null, [WorkflowExpression] Func<string> bodycompanyCountry = null, [WorkflowExpression] Func<string> bodycompanyPoBox = null, [WorkflowExpression] Func<string> bodycompanyWebsite = null, [WorkflowExpression] Func<string> bodycompanyComments = null, [WorkflowExpression] Func<string> bodycompanySalesTeam = null, [WorkflowExpression] Func<string> bodycompanyIndustries = null, [WorkflowExpression] Func<string> bodycompanyProductPotentials = null, [WorkflowExpression] Func<string> bodycontactFirstName = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<string> bodycontactFullName = null, [WorkflowExpression] Func<string> bodycontactTitle = null, [WorkflowExpression] Func<string> bodycontactBackground = null, [WorkflowExpression] Func<bool> bodycontactPrimaryContact = null, [WorkflowExpression] Func<string> bodycontactTypeName = null, [WorkflowExpression] Func<string> bodycontactEmailAddressWork = null, [WorkflowExpression] Func<string> bodycontactEmailAddressPersonal = null, [WorkflowExpression] Func<string> bodycontactEmailAddressAlternate = null, [WorkflowExpression] Func<string> bodycontactEmailAddressOther = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberWork = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberHome = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberMobile = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberAlternate = null, [WorkflowExpression] Func<string> bodycontactFax = null, [WorkflowExpression] Func<string> bodycontactBusinessStreet = null, [WorkflowExpression] Func<string> bodycontactBusinessCity = null, [WorkflowExpression] Func<string> bodycontactBusinessState = null, [WorkflowExpression] Func<string> bodycontactBusinessZip = null, [WorkflowExpression] Func<string> bodycontactBusinessCountry = null, [WorkflowExpression] Func<string> bodycontactHomeStreet = null, [WorkflowExpression] Func<string> bodycontactHomeCity = null, [WorkflowExpression] Func<string> bodycontactHomeState = null, [WorkflowExpression] Func<string> bodycontactHomeZip = null, [WorkflowExpression] Func<string> bodycontactHomeCountry = null, [WorkflowExpression] Func<string> bodycontactNotes = null, [WorkflowExpression] Func<string> bodycontactGroups = null, [WorkflowExpression] Func<string> bodycontactProductInterests = null, [WorkflowExpression] Func<string> bodyopportunityPrincipalName = null, [WorkflowExpression] Func<string> bodyopportunityProgram = null, [WorkflowExpression] Func<string> bodyopportunityCustomerName = null, [WorkflowExpression] Func<string> bodyopportunityDistributorName = null, [WorkflowExpression] Func<string> bodyopportunityCustomerContact = null, [WorkflowExpression] Func<string> bodyopportunityPrincipalContact = null, [WorkflowExpression] Func<string> bodyopportunityDistributorContact = null, [WorkflowExpression] Func<string> bodyopportunityNextStep = null, [WorkflowExpression] Func<string> bodyopportunityActivity = null, [WorkflowExpression] Func<string> bodyopportunityStatus = null, [WorkflowExpression] Func<string> bodyopportunityFollowUp = null, [WorkflowExpression] Func<int> bodyopportunityPriority = null, [WorkflowExpression] Func<int> bodyopportunityPotential = null, [WorkflowExpression] Func<int> bodyopportunityEau = null, [WorkflowExpression] Func<int> bodyopportunityValue = null, [WorkflowExpression] Func<string> bodyopportunityPrototypeDate = null, [WorkflowExpression] Func<string> bodyopportunityProductionDate = null, [WorkflowExpression] Func<int> bodyopportunityCloseStatus = null, [WorkflowExpression] Func<string> bodyopportunityCloseDate = null, [WorkflowExpression] Func<string> bodyopportunityDescription = null, [WorkflowExpression] Func<string> bodyopportunityCompetitor1 = null, [WorkflowExpression] Func<string> bodyopportunityCompetitor2 = null, [WorkflowExpression] Func<string> bodyopportunityReportingComments = null, [WorkflowExpression] Func<string> bodyopportunityLeadSourceName = null, [WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<string> bodypassword = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodycompanyType != null)
                {
                    body["company-type"] = SourceExpressionConverter.ConvertToken(bodycompanyType);
                    bodypropCount++;
                }

                if (bodycompanyClass != null)
                {
                    body["company-class"] = SourceExpressionConverter.ConvertToken(bodycompanyClass);
                    bodypropCount++;
                }

                if (bodycompanyCategory != null)
                {
                    body["company-category"] = SourceExpressionConverter.ConvertToken(bodycompanyCategory);
                    bodypropCount++;
                }

                if (bodycompanyPhone1 != null)
                {
                    body["company-phone1"] = SourceExpressionConverter.ConvertToken(bodycompanyPhone1);
                    bodypropCount++;
                }

                if (bodycompanyPhone2 != null)
                {
                    body["company-phone2"] = SourceExpressionConverter.ConvertToken(bodycompanyPhone2);
                    bodypropCount++;
                }

                if (bodycompanyFax != null)
                {
                    body["company-fax"] = SourceExpressionConverter.ConvertToken(bodycompanyFax);
                    bodypropCount++;
                }

                if (bodycompanyRegion != null)
                {
                    body["company-region"] = SourceExpressionConverter.ConvertToken(bodycompanyRegion);
                    bodypropCount++;
                }

                if (bodycompanyStreet != null)
                {
                    body["company-street"] = SourceExpressionConverter.ConvertToken(bodycompanyStreet);
                    bodypropCount++;
                }

                if (bodycompanyCity != null)
                {
                    body["company-city"] = SourceExpressionConverter.ConvertToken(bodycompanyCity);
                    bodypropCount++;
                }

                if (bodycompanyState != null)
                {
                    body["company-state"] = SourceExpressionConverter.ConvertToken(bodycompanyState);
                    bodypropCount++;
                }

                if (bodycompanyZip != null)
                {
                    body["company-zip"] = SourceExpressionConverter.ConvertToken(bodycompanyZip);
                    bodypropCount++;
                }

                if (bodycompanyCountry != null)
                {
                    body["company-country"] = SourceExpressionConverter.ConvertToken(bodycompanyCountry);
                    bodypropCount++;
                }

                if (bodycompanyPoBox != null)
                {
                    body["company-po-box"] = SourceExpressionConverter.ConvertToken(bodycompanyPoBox);
                    bodypropCount++;
                }

                if (bodycompanyWebsite != null)
                {
                    body["company-website"] = SourceExpressionConverter.ConvertToken(bodycompanyWebsite);
                    bodypropCount++;
                }

                if (bodycompanyComments != null)
                {
                    body["company-comments"] = SourceExpressionConverter.ConvertToken(bodycompanyComments);
                    bodypropCount++;
                }

                if (bodycompanySalesTeam != null)
                {
                    body["company-sales-team"] = SourceExpressionConverter.ConvertToken(bodycompanySalesTeam);
                    bodypropCount++;
                }

                if (bodycompanyIndustries != null)
                {
                    body["company-industries"] = SourceExpressionConverter.ConvertToken(bodycompanyIndustries);
                    bodypropCount++;
                }

                if (bodycompanyProductPotentials != null)
                {
                    body["company-product-potentials"] = SourceExpressionConverter.ConvertToken(bodycompanyProductPotentials);
                    bodypropCount++;
                }

                if (bodycontactFirstName != null)
                {
                    body["contact-first-name"] = SourceExpressionConverter.ConvertToken(bodycontactFirstName);
                    bodypropCount++;
                }

                if (bodycontactLastName != null)
                {
                    body["contact-last-name"] = SourceExpressionConverter.ConvertToken(bodycontactLastName);
                    bodypropCount++;
                }

                if (bodycontactFullName != null)
                {
                    body["contact-full-name"] = SourceExpressionConverter.ConvertToken(bodycontactFullName);
                    bodypropCount++;
                }

                if (bodycontactTitle != null)
                {
                    body["contact-title"] = SourceExpressionConverter.ConvertToken(bodycontactTitle);
                    bodypropCount++;
                }

                if (bodycontactBackground != null)
                {
                    body["contact-background"] = SourceExpressionConverter.ConvertToken(bodycontactBackground);
                    bodypropCount++;
                }

                if (bodycontactPrimaryContact != null)
                {
                    body["contact-primary-contact"] = SourceExpressionConverter.ConvertToken(bodycontactPrimaryContact);
                    bodypropCount++;
                }

                if (bodycontactTypeName != null)
                {
                    body["contact-type-name"] = SourceExpressionConverter.ConvertToken(bodycontactTypeName);
                    bodypropCount++;
                }

                if (bodycontactEmailAddressWork != null)
                {
                    body["contact-email-address-work"] = SourceExpressionConverter.ConvertToken(bodycontactEmailAddressWork);
                    bodypropCount++;
                }

                if (bodycontactEmailAddressPersonal != null)
                {
                    body["contact-email-address-personal"] = SourceExpressionConverter.ConvertToken(bodycontactEmailAddressPersonal);
                    bodypropCount++;
                }

                if (bodycontactEmailAddressAlternate != null)
                {
                    body["contact-email-address-alternate"] = SourceExpressionConverter.ConvertToken(bodycontactEmailAddressAlternate);
                    bodypropCount++;
                }

                if (bodycontactEmailAddressOther != null)
                {
                    body["contact-email-address-other"] = SourceExpressionConverter.ConvertToken(bodycontactEmailAddressOther);
                    bodypropCount++;
                }

                if (bodycontactPhoneNumberWork != null)
                {
                    body["contact-phone-number-work"] = SourceExpressionConverter.ConvertToken(bodycontactPhoneNumberWork);
                    bodypropCount++;
                }

                if (bodycontactPhoneNumberHome != null)
                {
                    body["contact-phone-number-home"] = SourceExpressionConverter.ConvertToken(bodycontactPhoneNumberHome);
                    bodypropCount++;
                }

                if (bodycontactPhoneNumberMobile != null)
                {
                    body["contact-phone-number-mobile"] = SourceExpressionConverter.ConvertToken(bodycontactPhoneNumberMobile);
                    bodypropCount++;
                }

                if (bodycontactPhoneNumberAlternate != null)
                {
                    body["contact-phone-number-alternate"] = SourceExpressionConverter.ConvertToken(bodycontactPhoneNumberAlternate);
                    bodypropCount++;
                }

                if (bodycontactFax != null)
                {
                    body["contact-fax"] = SourceExpressionConverter.ConvertToken(bodycontactFax);
                    bodypropCount++;
                }

                if (bodycontactBusinessStreet != null)
                {
                    body["contact-business-street"] = SourceExpressionConverter.ConvertToken(bodycontactBusinessStreet);
                    bodypropCount++;
                }

                if (bodycontactBusinessCity != null)
                {
                    body["contact-business-city"] = SourceExpressionConverter.ConvertToken(bodycontactBusinessCity);
                    bodypropCount++;
                }

                if (bodycontactBusinessState != null)
                {
                    body["contact-business-state"] = SourceExpressionConverter.ConvertToken(bodycontactBusinessState);
                    bodypropCount++;
                }

                if (bodycontactBusinessZip != null)
                {
                    body["contact-business-zip"] = SourceExpressionConverter.ConvertToken(bodycontactBusinessZip);
                    bodypropCount++;
                }

                if (bodycontactBusinessCountry != null)
                {
                    body["contact-business-country"] = SourceExpressionConverter.ConvertToken(bodycontactBusinessCountry);
                    bodypropCount++;
                }

                if (bodycontactHomeStreet != null)
                {
                    body["contact-home-street"] = SourceExpressionConverter.ConvertToken(bodycontactHomeStreet);
                    bodypropCount++;
                }

                if (bodycontactHomeCity != null)
                {
                    body["contact-home-city"] = SourceExpressionConverter.ConvertToken(bodycontactHomeCity);
                    bodypropCount++;
                }

                if (bodycontactHomeState != null)
                {
                    body["contact-home-state"] = SourceExpressionConverter.ConvertToken(bodycontactHomeState);
                    bodypropCount++;
                }

                if (bodycontactHomeZip != null)
                {
                    body["contact-home-zip"] = SourceExpressionConverter.ConvertToken(bodycontactHomeZip);
                    bodypropCount++;
                }

                if (bodycontactHomeCountry != null)
                {
                    body["contact-home-country"] = SourceExpressionConverter.ConvertToken(bodycontactHomeCountry);
                    bodypropCount++;
                }

                if (bodycontactNotes != null)
                {
                    body["contact-notes"] = SourceExpressionConverter.ConvertToken(bodycontactNotes);
                    bodypropCount++;
                }

                if (bodycontactGroups != null)
                {
                    body["contact-groups"] = SourceExpressionConverter.ConvertToken(bodycontactGroups);
                    bodypropCount++;
                }

                if (bodycontactProductInterests != null)
                {
                    body["contact-product-interests"] = SourceExpressionConverter.ConvertToken(bodycontactProductInterests);
                    bodypropCount++;
                }

                if (bodyopportunityPrincipalName != null)
                {
                    body["opportunity-principal-name"] = SourceExpressionConverter.ConvertToken(bodyopportunityPrincipalName);
                    bodypropCount++;
                }

                if (bodyopportunityProgram != null)
                {
                    body["opportunity-program"] = SourceExpressionConverter.ConvertToken(bodyopportunityProgram);
                    bodypropCount++;
                }

                if (bodyopportunityCustomerName != null)
                {
                    body["opportunity-customer-name"] = SourceExpressionConverter.ConvertToken(bodyopportunityCustomerName);
                    bodypropCount++;
                }

                if (bodyopportunityDistributorName != null)
                {
                    body["opportunity-distributor-name"] = SourceExpressionConverter.ConvertToken(bodyopportunityDistributorName);
                    bodypropCount++;
                }

                if (bodyopportunityCustomerContact != null)
                {
                    body["opportunity-customer-contact"] = SourceExpressionConverter.ConvertToken(bodyopportunityCustomerContact);
                    bodypropCount++;
                }

                if (bodyopportunityPrincipalContact != null)
                {
                    body["opportunity-principal-contact"] = SourceExpressionConverter.ConvertToken(bodyopportunityPrincipalContact);
                    bodypropCount++;
                }

                if (bodyopportunityDistributorContact != null)
                {
                    body["opportunity-distributor-contact"] = SourceExpressionConverter.ConvertToken(bodyopportunityDistributorContact);
                    bodypropCount++;
                }

                if (bodyopportunityNextStep != null)
                {
                    body["opportunity-next-step"] = SourceExpressionConverter.ConvertToken(bodyopportunityNextStep);
                    bodypropCount++;
                }

                if (bodyopportunityActivity != null)
                {
                    body["opportunity-activity"] = SourceExpressionConverter.ConvertToken(bodyopportunityActivity);
                    bodypropCount++;
                }

                if (bodyopportunityStatus != null)
                {
                    body["opportunity-status"] = SourceExpressionConverter.ConvertToken(bodyopportunityStatus);
                    bodypropCount++;
                }

                if (bodyopportunityFollowUp != null)
                {
                    body["opportunity-follow-up"] = SourceExpressionConverter.ConvertToken(bodyopportunityFollowUp);
                    bodypropCount++;
                }

                if (bodyopportunityPriority != null)
                {
                    body["opportunity-priority"] = SourceExpressionConverter.ConvertToken(bodyopportunityPriority);
                    bodypropCount++;
                }

                if (bodyopportunityPotential != null)
                {
                    body["opportunity-potential"] = SourceExpressionConverter.ConvertToken(bodyopportunityPotential);
                    bodypropCount++;
                }

                if (bodyopportunityEau != null)
                {
                    body["opportunity-eau"] = SourceExpressionConverter.ConvertToken(bodyopportunityEau);
                    bodypropCount++;
                }

                if (bodyopportunityValue != null)
                {
                    body["opportunity-value"] = SourceExpressionConverter.ConvertToken(bodyopportunityValue);
                    bodypropCount++;
                }

                if (bodyopportunityPrototypeDate != null)
                {
                    body["opportunity-prototype-date"] = SourceExpressionConverter.ConvertToken(bodyopportunityPrototypeDate);
                    bodypropCount++;
                }

                if (bodyopportunityProductionDate != null)
                {
                    body["opportunity-production-date"] = SourceExpressionConverter.ConvertToken(bodyopportunityProductionDate);
                    bodypropCount++;
                }

                if (bodyopportunityCloseStatus != null)
                {
                    body["opportunity-close-status"] = SourceExpressionConverter.ConvertToken(bodyopportunityCloseStatus);
                    bodypropCount++;
                }

                if (bodyopportunityCloseDate != null)
                {
                    body["opportunity-close-date"] = SourceExpressionConverter.ConvertToken(bodyopportunityCloseDate);
                    bodypropCount++;
                }

                if (bodyopportunityDescription != null)
                {
                    body["opportunity-description"] = SourceExpressionConverter.ConvertToken(bodyopportunityDescription);
                    bodypropCount++;
                }

                if (bodyopportunityCompetitor1 != null)
                {
                    body["opportunity-competitor-1"] = SourceExpressionConverter.ConvertToken(bodyopportunityCompetitor1);
                    bodypropCount++;
                }

                if (bodyopportunityCompetitor2 != null)
                {
                    body["opportunity-competitor-2"] = SourceExpressionConverter.ConvertToken(bodyopportunityCompetitor2);
                    bodypropCount++;
                }

                if (bodyopportunityReportingComments != null)
                {
                    body["opportunity-reporting-comments"] = SourceExpressionConverter.ConvertToken(bodyopportunityReportingComments);
                    bodypropCount++;
                }

                if (bodyopportunityLeadSourceName != null)
                {
                    body["opportunity-lead-source-name"] = SourceExpressionConverter.ConvertToken(bodyopportunityLeadSourceName);
                    bodypropCount++;
                }

                if (bodydomain != null)
                {
                    body["domain"] = SourceExpressionConverter.ConvertToken(bodydomain);
                    bodypropCount++;
                }

                if (bodyusername != null)
                {
                    body["username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UploadLeadsV3Response>(BuildSourceInput);
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