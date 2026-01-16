//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Repfabricleadloader
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RepfabricleadloaderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "repfabricleadloader")]
        public IWorkflowAction RepfabricCreateLead(Expression<Func<string>> bodydomainName, Expression<Func<string>> bodycompanyName, Expression<Func<string>> bodycontactFirstName, Expression<Func<string>> bodycontactCompanyName, Expression<Func<string>> bodyopportunityPrincipalName, Expression<Func<string>> bodyopportunityProgram, Expression<Func<int>> bodycompanyTypeId = null, Expression<Func<string>> bodycompanyType = null, Expression<Func<string>> bodycompanyClassId = null, Expression<Func<string>> bodycompanyClass = null, Expression<Func<int>> bodycompanyCategoryId = null, Expression<Func<string>> bodycompanyCategory = null, Expression<Func<string>> bodycompanyPhone1 = null, Expression<Func<string>> bodycompanyPhone2 = null, Expression<Func<string>> bodycompanyFax = null, Expression<Func<string>> bodycompanyRegion = null, Expression<Func<string>> bodycompanyStreet = null, Expression<Func<string>> bodycompanyCity = null, Expression<Func<string>> bodycompanyState = null, Expression<Func<string>> bodycompanyZip = null, Expression<Func<string>> bodycompanyCountry = null, Expression<Func<string>> bodycompanyPoBox = null, Expression<Func<string>> bodycompanyWebsite = null, Expression<Func<string>> bodycompanyComments = null, Expression<Func<int>> bodycompanySalesTeamId = null, Expression<Func<string>> bodycompanySalesTeam = null, Expression<Func<string>> bodycontactLastName = null, Expression<Func<string>> bodycontactTitle = null, Expression<Func<string>> bodycontactBackground = null, Expression<Func<bool>> bodycontactPrimary = null, Expression<Func<string>> bodycontactCompanyTypeName = null, Expression<Func<string>> bodycontactEmailAddressWork = null, Expression<Func<string>> bodycontactEmailAddressPersonal = null, Expression<Func<string>> bodycontactEmailAddressAlternate = null, Expression<Func<string>> bodycontactEmailAddressOther = null, Expression<Func<string>> bodycontactPhoneNumberWork = null, Expression<Func<string>> bodycontactPhoneNumberHome = null, Expression<Func<string>> bodycontactPhoneNumberMobile = null, Expression<Func<string>> bodycontactPhoneNumberAlternate = null, Expression<Func<string>> bodycontactFax = null, Expression<Func<string>> bodycontactBusinessStreet = null, Expression<Func<string>> bodycontactBusinessCity = null, Expression<Func<string>> bodycontactBusinessState = null, Expression<Func<string>> bodycontactBusinessZip = null, Expression<Func<string>> bodycontactBusinessCountry = null, Expression<Func<string>> bodycontactHomeStreet = null, Expression<Func<string>> bodycontactHomeCity = null, Expression<Func<string>> bodycontactHomeState = null, Expression<Func<string>> bodycontactHomeZip = null, Expression<Func<string>> bodycontactHomeCountry = null, Expression<Func<JToken[]>> bodycontactTags = null, Expression<Func<int>> bodyopportunityId = null, Expression<Func<int>> bodyopportunityCustomerId = null, Expression<Func<string>> bodyopportunityCustomerName = null, Expression<Func<int>> bodyopportunityPrincipalId = null, Expression<Func<string>> bodyopportunityDistributorId = null, Expression<Func<string>> bodyopportunityDistributorName = null, Expression<Func<string>> bodyopportunityCustomerContactId = null, Expression<Func<string>> bodyopportunityCustomerContact = null, Expression<Func<string>> bodyopportunityPrincipalContactId = null, Expression<Func<string>> bodyopportunityPrincipalContact = null, Expression<Func<string>> bodyopportunityDistributorContactId = null, Expression<Func<string>> bodyopportunityDistributorContact = null, Expression<Func<string>> bodyopportunityNextStep = null, Expression<Func<string>> bodyopportunityActivity = null, Expression<Func<string>> bodyopportunityStatus = null, Expression<Func<int>> bodyopportunitySalesTeamId = null, Expression<Func<string>> bodyopportunitySalesTeam = null, Expression<Func<string>> bodyopportunityFollowUp = null, Expression<Func<int>> bodyopportunityOppOwner = null, Expression<Func<int>> bodyopportunityPriority = null, Expression<Func<int>> bodyopportunityPotential = null, Expression<Func<int>> bodyopportunityEau = null, Expression<Func<double>> bodyopportunityValue = null, Expression<Func<string>> bodyopportunityPrototypeDate = null, Expression<Func<string>> bodyopportunityProductionDate = null, Expression<Func<int>> bodyopportunityCloseStatus = null, Expression<Func<string>> bodyopportunityCloseDate = null, Expression<Func<string>> bodyopportunityCompetitor1 = null, Expression<Func<string>> bodyopportunityCompetitor2 = null, Expression<Func<string>> bodyopportunityDescription = null, Expression<Func<string>> bodyopportunityReportingComments = null)
        {
            var apiCallPath = "/default/LeadLoaderConnector";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["domain-name"] = ExpressionConverter.ConvertO(bodydomainName);
            bodypropCount++;
            body["company-name"] = ExpressionConverter.ConvertO(bodycompanyName);
            if (bodycompanyTypeId != null)
            {
                body["company-type-id"] = ExpressionConverter.ConvertO(bodycompanyTypeId);
                bodypropCount++;
            }

            if (bodycompanyType != null)
            {
                body["company-type"] = ExpressionConverter.ConvertO(bodycompanyType);
                bodypropCount++;
            }

            if (bodycompanyClassId != null)
            {
                body["company-class-id"] = ExpressionConverter.ConvertO(bodycompanyClassId);
                bodypropCount++;
            }

            if (bodycompanyClass != null)
            {
                body["company-class"] = ExpressionConverter.ConvertO(bodycompanyClass);
                bodypropCount++;
            }

            if (bodycompanyCategoryId != null)
            {
                body["company-category-id"] = ExpressionConverter.ConvertO(bodycompanyCategoryId);
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

            if (bodycompanySalesTeamId != null)
            {
                body["company-sales-team-id"] = ExpressionConverter.ConvertO(bodycompanySalesTeamId);
                bodypropCount++;
            }

            if (bodycompanySalesTeam != null)
            {
                body["company-sales-team"] = ExpressionConverter.ConvertO(bodycompanySalesTeam);
                bodypropCount++;
            }

            bodypropCount++;
            body["contact-first-name"] = ExpressionConverter.ConvertO(bodycontactFirstName);
            if (bodycontactLastName != null)
            {
                body["contact-last-name"] = ExpressionConverter.ConvertO(bodycontactLastName);
                bodypropCount++;
            }

            bodypropCount++;
            body["contact-company-name"] = ExpressionConverter.ConvertO(bodycontactCompanyName);
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

            if (bodycontactPrimary != null)
            {
                body["contact-primary"] = ExpressionConverter.ConvertO(bodycontactPrimary);
                bodypropCount++;
            }

            if (bodycontactCompanyTypeName != null)
            {
                body["contact-company-type-name"] = ExpressionConverter.ConvertO(bodycontactCompanyTypeName);
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

            if (bodycontactTags != null)
            {
                body["contact-tags"] = ExpressionConverter.ConvertO(bodycontactTags);
                bodypropCount++;
            }

            if (bodyopportunityId != null)
            {
                body["opportunity-id"] = ExpressionConverter.ConvertO(bodyopportunityId);
                bodypropCount++;
            }

            if (bodyopportunityCustomerId != null)
            {
                body["opportunity-customer-id"] = ExpressionConverter.ConvertO(bodyopportunityCustomerId);
                bodypropCount++;
            }

            if (bodyopportunityCustomerName != null)
            {
                body["opportunity-customer-name"] = ExpressionConverter.ConvertO(bodyopportunityCustomerName);
                bodypropCount++;
            }

            if (bodyopportunityPrincipalId != null)
            {
                body["opportunity-principal-id"] = ExpressionConverter.ConvertO(bodyopportunityPrincipalId);
                bodypropCount++;
            }

            bodypropCount++;
            body["opportunity-principal-name"] = ExpressionConverter.ConvertO(bodyopportunityPrincipalName);
            if (bodyopportunityDistributorId != null)
            {
                body["opportunity-distributor-id"] = ExpressionConverter.ConvertO(bodyopportunityDistributorId);
                bodypropCount++;
            }

            if (bodyopportunityDistributorName != null)
            {
                body["opportunity-distributor-name"] = ExpressionConverter.ConvertO(bodyopportunityDistributorName);
                bodypropCount++;
            }

            if (bodyopportunityCustomerContactId != null)
            {
                body["opportunity-customer-contact-id"] = ExpressionConverter.ConvertO(bodyopportunityCustomerContactId);
                bodypropCount++;
            }

            if (bodyopportunityCustomerContact != null)
            {
                body["opportunity-customer-contact"] = ExpressionConverter.ConvertO(bodyopportunityCustomerContact);
                bodypropCount++;
            }

            if (bodyopportunityPrincipalContactId != null)
            {
                body["opportunity-principal-contact-id"] = ExpressionConverter.ConvertO(bodyopportunityPrincipalContactId);
                bodypropCount++;
            }

            if (bodyopportunityPrincipalContact != null)
            {
                body["opportunity-principal-contact"] = ExpressionConverter.ConvertO(bodyopportunityPrincipalContact);
                bodypropCount++;
            }

            if (bodyopportunityDistributorContactId != null)
            {
                body["opportunity-distributor-contact-id"] = ExpressionConverter.ConvertO(bodyopportunityDistributorContactId);
                bodypropCount++;
            }

            if (bodyopportunityDistributorContact != null)
            {
                body["opportunity-distributor-contact"] = ExpressionConverter.ConvertO(bodyopportunityDistributorContact);
                bodypropCount++;
            }

            bodypropCount++;
            body["opportunity-program"] = ExpressionConverter.ConvertO(bodyopportunityProgram);
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

            if (bodyopportunitySalesTeamId != null)
            {
                body["opportunity-sales-team-id"] = ExpressionConverter.ConvertO(bodyopportunitySalesTeamId);
                bodypropCount++;
            }

            if (bodyopportunitySalesTeam != null)
            {
                body["opportunity-sales-team"] = ExpressionConverter.ConvertO(bodyopportunitySalesTeam);
                bodypropCount++;
            }

            if (bodyopportunityFollowUp != null)
            {
                body["opportunity-follow-up"] = ExpressionConverter.ConvertO(bodyopportunityFollowUp);
                bodypropCount++;
            }

            if (bodyopportunityOppOwner != null)
            {
                body["opportunity-opp-owner"] = ExpressionConverter.ConvertO(bodyopportunityOppOwner);
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

            if (bodyopportunityDescription != null)
            {
                body["opportunity-description"] = ExpressionConverter.ConvertO(bodyopportunityDescription);
                bodypropCount++;
            }

            if (bodyopportunityReportingComments != null)
            {
                body["opportunity-reporting-comments"] = ExpressionConverter.ConvertO(bodyopportunityReportingComments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class RepfabricleadloaderTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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