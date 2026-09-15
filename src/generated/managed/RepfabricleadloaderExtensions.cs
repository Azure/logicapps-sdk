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
            body["domain-name"] = CSharpExpressionConverter.ConvertToken(bodydomainName);
            bodypropCount++;
            body["company-name"] = CSharpExpressionConverter.ConvertToken(bodycompanyName);
            if (bodycompanyTypeId != null)
            {
                body["company-type-id"] = CSharpExpressionConverter.ConvertToken(bodycompanyTypeId);
                bodypropCount++;
            }

            if (bodycompanyType != null)
            {
                body["company-type"] = CSharpExpressionConverter.ConvertToken(bodycompanyType);
                bodypropCount++;
            }

            if (bodycompanyClassId != null)
            {
                body["company-class-id"] = CSharpExpressionConverter.ConvertToken(bodycompanyClassId);
                bodypropCount++;
            }

            if (bodycompanyClass != null)
            {
                body["company-class"] = CSharpExpressionConverter.ConvertToken(bodycompanyClass);
                bodypropCount++;
            }

            if (bodycompanyCategoryId != null)
            {
                body["company-category-id"] = CSharpExpressionConverter.ConvertToken(bodycompanyCategoryId);
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

            if (bodycompanySalesTeamId != null)
            {
                body["company-sales-team-id"] = CSharpExpressionConverter.ConvertToken(bodycompanySalesTeamId);
                bodypropCount++;
            }

            if (bodycompanySalesTeam != null)
            {
                body["company-sales-team"] = CSharpExpressionConverter.ConvertToken(bodycompanySalesTeam);
                bodypropCount++;
            }

            bodypropCount++;
            body["contact-first-name"] = CSharpExpressionConverter.ConvertToken(bodycontactFirstName);
            if (bodycontactLastName != null)
            {
                body["contact-last-name"] = CSharpExpressionConverter.ConvertToken(bodycontactLastName);
                bodypropCount++;
            }

            bodypropCount++;
            body["contact-company-name"] = CSharpExpressionConverter.ConvertToken(bodycontactCompanyName);
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

            if (bodycontactPrimary != null)
            {
                body["contact-primary"] = CSharpExpressionConverter.ConvertToken(bodycontactPrimary);
                bodypropCount++;
            }

            if (bodycontactCompanyTypeName != null)
            {
                body["contact-company-type-name"] = CSharpExpressionConverter.ConvertToken(bodycontactCompanyTypeName);
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

            if (bodycontactTags != null)
            {
                body["contact-tags"] = CSharpExpressionConverter.ConvertToken(bodycontactTags);
                bodypropCount++;
            }

            if (bodyopportunityId != null)
            {
                body["opportunity-id"] = CSharpExpressionConverter.ConvertToken(bodyopportunityId);
                bodypropCount++;
            }

            if (bodyopportunityCustomerId != null)
            {
                body["opportunity-customer-id"] = CSharpExpressionConverter.ConvertToken(bodyopportunityCustomerId);
                bodypropCount++;
            }

            if (bodyopportunityCustomerName != null)
            {
                body["opportunity-customer-name"] = CSharpExpressionConverter.ConvertToken(bodyopportunityCustomerName);
                bodypropCount++;
            }

            if (bodyopportunityPrincipalId != null)
            {
                body["opportunity-principal-id"] = CSharpExpressionConverter.ConvertToken(bodyopportunityPrincipalId);
                bodypropCount++;
            }

            bodypropCount++;
            body["opportunity-principal-name"] = CSharpExpressionConverter.ConvertToken(bodyopportunityPrincipalName);
            if (bodyopportunityDistributorId != null)
            {
                body["opportunity-distributor-id"] = CSharpExpressionConverter.ConvertToken(bodyopportunityDistributorId);
                bodypropCount++;
            }

            if (bodyopportunityDistributorName != null)
            {
                body["opportunity-distributor-name"] = CSharpExpressionConverter.ConvertToken(bodyopportunityDistributorName);
                bodypropCount++;
            }

            if (bodyopportunityCustomerContactId != null)
            {
                body["opportunity-customer-contact-id"] = CSharpExpressionConverter.ConvertToken(bodyopportunityCustomerContactId);
                bodypropCount++;
            }

            if (bodyopportunityCustomerContact != null)
            {
                body["opportunity-customer-contact"] = CSharpExpressionConverter.ConvertToken(bodyopportunityCustomerContact);
                bodypropCount++;
            }

            if (bodyopportunityPrincipalContactId != null)
            {
                body["opportunity-principal-contact-id"] = CSharpExpressionConverter.ConvertToken(bodyopportunityPrincipalContactId);
                bodypropCount++;
            }

            if (bodyopportunityPrincipalContact != null)
            {
                body["opportunity-principal-contact"] = CSharpExpressionConverter.ConvertToken(bodyopportunityPrincipalContact);
                bodypropCount++;
            }

            if (bodyopportunityDistributorContactId != null)
            {
                body["opportunity-distributor-contact-id"] = CSharpExpressionConverter.ConvertToken(bodyopportunityDistributorContactId);
                bodypropCount++;
            }

            if (bodyopportunityDistributorContact != null)
            {
                body["opportunity-distributor-contact"] = CSharpExpressionConverter.ConvertToken(bodyopportunityDistributorContact);
                bodypropCount++;
            }

            bodypropCount++;
            body["opportunity-program"] = CSharpExpressionConverter.ConvertToken(bodyopportunityProgram);
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

            if (bodyopportunitySalesTeamId != null)
            {
                body["opportunity-sales-team-id"] = CSharpExpressionConverter.ConvertToken(bodyopportunitySalesTeamId);
                bodypropCount++;
            }

            if (bodyopportunitySalesTeam != null)
            {
                body["opportunity-sales-team"] = CSharpExpressionConverter.ConvertToken(bodyopportunitySalesTeam);
                bodypropCount++;
            }

            if (bodyopportunityFollowUp != null)
            {
                body["opportunity-follow-up"] = CSharpExpressionConverter.ConvertToken(bodyopportunityFollowUp);
                bodypropCount++;
            }

            if (bodyopportunityOppOwner != null)
            {
                body["opportunity-opp-owner"] = CSharpExpressionConverter.ConvertToken(bodyopportunityOppOwner);
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

            if (bodyopportunityDescription != null)
            {
                body["opportunity-description"] = CSharpExpressionConverter.ConvertToken(bodyopportunityDescription);
                bodypropCount++;
            }

            if (bodyopportunityReportingComments != null)
            {
                body["opportunity-reporting-comments"] = CSharpExpressionConverter.ConvertToken(bodyopportunityReportingComments);
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