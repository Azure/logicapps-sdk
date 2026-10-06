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
        public IWorkflowAction RepfabricCreateLead([WorkflowExpression] Func<string> bodydomainName, [WorkflowExpression] Func<string> bodycompanyName, [WorkflowExpression] Func<string> bodycontactFirstName, [WorkflowExpression] Func<string> bodycontactCompanyName, [WorkflowExpression] Func<string> bodyopportunityPrincipalName, [WorkflowExpression] Func<string> bodyopportunityProgram, [WorkflowExpression] Func<int> bodycompanyTypeId = null, [WorkflowExpression] Func<string> bodycompanyType = null, [WorkflowExpression] Func<string> bodycompanyClassId = null, [WorkflowExpression] Func<string> bodycompanyClass = null, [WorkflowExpression] Func<int> bodycompanyCategoryId = null, [WorkflowExpression] Func<string> bodycompanyCategory = null, [WorkflowExpression] Func<string> bodycompanyPhone1 = null, [WorkflowExpression] Func<string> bodycompanyPhone2 = null, [WorkflowExpression] Func<string> bodycompanyFax = null, [WorkflowExpression] Func<string> bodycompanyRegion = null, [WorkflowExpression] Func<string> bodycompanyStreet = null, [WorkflowExpression] Func<string> bodycompanyCity = null, [WorkflowExpression] Func<string> bodycompanyState = null, [WorkflowExpression] Func<string> bodycompanyZip = null, [WorkflowExpression] Func<string> bodycompanyCountry = null, [WorkflowExpression] Func<string> bodycompanyPoBox = null, [WorkflowExpression] Func<string> bodycompanyWebsite = null, [WorkflowExpression] Func<string> bodycompanyComments = null, [WorkflowExpression] Func<int> bodycompanySalesTeamId = null, [WorkflowExpression] Func<string> bodycompanySalesTeam = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<string> bodycontactTitle = null, [WorkflowExpression] Func<string> bodycontactBackground = null, [WorkflowExpression] Func<bool> bodycontactPrimary = null, [WorkflowExpression] Func<string> bodycontactCompanyTypeName = null, [WorkflowExpression] Func<string> bodycontactEmailAddressWork = null, [WorkflowExpression] Func<string> bodycontactEmailAddressPersonal = null, [WorkflowExpression] Func<string> bodycontactEmailAddressAlternate = null, [WorkflowExpression] Func<string> bodycontactEmailAddressOther = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberWork = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberHome = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberMobile = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberAlternate = null, [WorkflowExpression] Func<string> bodycontactFax = null, [WorkflowExpression] Func<string> bodycontactBusinessStreet = null, [WorkflowExpression] Func<string> bodycontactBusinessCity = null, [WorkflowExpression] Func<string> bodycontactBusinessState = null, [WorkflowExpression] Func<string> bodycontactBusinessZip = null, [WorkflowExpression] Func<string> bodycontactBusinessCountry = null, [WorkflowExpression] Func<string> bodycontactHomeStreet = null, [WorkflowExpression] Func<string> bodycontactHomeCity = null, [WorkflowExpression] Func<string> bodycontactHomeState = null, [WorkflowExpression] Func<string> bodycontactHomeZip = null, [WorkflowExpression] Func<string> bodycontactHomeCountry = null, [WorkflowExpression] Func<JToken[]> bodycontactTags = null, [WorkflowExpression] Func<int> bodyopportunityId = null, [WorkflowExpression] Func<int> bodyopportunityCustomerId = null, [WorkflowExpression] Func<string> bodyopportunityCustomerName = null, [WorkflowExpression] Func<int> bodyopportunityPrincipalId = null, [WorkflowExpression] Func<string> bodyopportunityDistributorId = null, [WorkflowExpression] Func<string> bodyopportunityDistributorName = null, [WorkflowExpression] Func<string> bodyopportunityCustomerContactId = null, [WorkflowExpression] Func<string> bodyopportunityCustomerContact = null, [WorkflowExpression] Func<string> bodyopportunityPrincipalContactId = null, [WorkflowExpression] Func<string> bodyopportunityPrincipalContact = null, [WorkflowExpression] Func<string> bodyopportunityDistributorContactId = null, [WorkflowExpression] Func<string> bodyopportunityDistributorContact = null, [WorkflowExpression] Func<string> bodyopportunityNextStep = null, [WorkflowExpression] Func<string> bodyopportunityActivity = null, [WorkflowExpression] Func<string> bodyopportunityStatus = null, [WorkflowExpression] Func<int> bodyopportunitySalesTeamId = null, [WorkflowExpression] Func<string> bodyopportunitySalesTeam = null, [WorkflowExpression] Func<string> bodyopportunityFollowUp = null, [WorkflowExpression] Func<int> bodyopportunityOppOwner = null, [WorkflowExpression] Func<int> bodyopportunityPriority = null, [WorkflowExpression] Func<int> bodyopportunityPotential = null, [WorkflowExpression] Func<int> bodyopportunityEau = null, [WorkflowExpression] Func<double> bodyopportunityValue = null, [WorkflowExpression] Func<string> bodyopportunityPrototypeDate = null, [WorkflowExpression] Func<string> bodyopportunityProductionDate = null, [WorkflowExpression] Func<int> bodyopportunityCloseStatus = null, [WorkflowExpression] Func<string> bodyopportunityCloseDate = null, [WorkflowExpression] Func<string> bodyopportunityCompetitor1 = null, [WorkflowExpression] Func<string> bodyopportunityCompetitor2 = null, [WorkflowExpression] Func<string> bodyopportunityDescription = null, [WorkflowExpression] Func<string> bodyopportunityReportingComments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/default/LeadLoaderConnector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domain-name"] = SourceExpressionConverter.ConvertToken(bodydomainName);
                bodypropCount++;
                body["company-name"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                if (bodycompanyTypeId != null)
                {
                    body["company-type-id"] = SourceExpressionConverter.ConvertToken(bodycompanyTypeId);
                    bodypropCount++;
                }

                if (bodycompanyType != null)
                {
                    body["company-type"] = SourceExpressionConverter.ConvertToken(bodycompanyType);
                    bodypropCount++;
                }

                if (bodycompanyClassId != null)
                {
                    body["company-class-id"] = SourceExpressionConverter.ConvertToken(bodycompanyClassId);
                    bodypropCount++;
                }

                if (bodycompanyClass != null)
                {
                    body["company-class"] = SourceExpressionConverter.ConvertToken(bodycompanyClass);
                    bodypropCount++;
                }

                if (bodycompanyCategoryId != null)
                {
                    body["company-category-id"] = SourceExpressionConverter.ConvertToken(bodycompanyCategoryId);
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

                if (bodycompanySalesTeamId != null)
                {
                    body["company-sales-team-id"] = SourceExpressionConverter.ConvertToken(bodycompanySalesTeamId);
                    bodypropCount++;
                }

                if (bodycompanySalesTeam != null)
                {
                    body["company-sales-team"] = SourceExpressionConverter.ConvertToken(bodycompanySalesTeam);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contact-first-name"] = SourceExpressionConverter.ConvertToken(bodycontactFirstName);
                if (bodycontactLastName != null)
                {
                    body["contact-last-name"] = SourceExpressionConverter.ConvertToken(bodycontactLastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contact-company-name"] = SourceExpressionConverter.ConvertToken(bodycontactCompanyName);
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

                if (bodycontactPrimary != null)
                {
                    body["contact-primary"] = SourceExpressionConverter.ConvertToken(bodycontactPrimary);
                    bodypropCount++;
                }

                if (bodycontactCompanyTypeName != null)
                {
                    body["contact-company-type-name"] = SourceExpressionConverter.ConvertToken(bodycontactCompanyTypeName);
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

                if (bodycontactTags != null)
                {
                    body["contact-tags"] = SourceExpressionConverter.ConvertToken(bodycontactTags);
                    bodypropCount++;
                }

                if (bodyopportunityId != null)
                {
                    body["opportunity-id"] = SourceExpressionConverter.ConvertToken(bodyopportunityId);
                    bodypropCount++;
                }

                if (bodyopportunityCustomerId != null)
                {
                    body["opportunity-customer-id"] = SourceExpressionConverter.ConvertToken(bodyopportunityCustomerId);
                    bodypropCount++;
                }

                if (bodyopportunityCustomerName != null)
                {
                    body["opportunity-customer-name"] = SourceExpressionConverter.ConvertToken(bodyopportunityCustomerName);
                    bodypropCount++;
                }

                if (bodyopportunityPrincipalId != null)
                {
                    body["opportunity-principal-id"] = SourceExpressionConverter.ConvertToken(bodyopportunityPrincipalId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["opportunity-principal-name"] = SourceExpressionConverter.ConvertToken(bodyopportunityPrincipalName);
                if (bodyopportunityDistributorId != null)
                {
                    body["opportunity-distributor-id"] = SourceExpressionConverter.ConvertToken(bodyopportunityDistributorId);
                    bodypropCount++;
                }

                if (bodyopportunityDistributorName != null)
                {
                    body["opportunity-distributor-name"] = SourceExpressionConverter.ConvertToken(bodyopportunityDistributorName);
                    bodypropCount++;
                }

                if (bodyopportunityCustomerContactId != null)
                {
                    body["opportunity-customer-contact-id"] = SourceExpressionConverter.ConvertToken(bodyopportunityCustomerContactId);
                    bodypropCount++;
                }

                if (bodyopportunityCustomerContact != null)
                {
                    body["opportunity-customer-contact"] = SourceExpressionConverter.ConvertToken(bodyopportunityCustomerContact);
                    bodypropCount++;
                }

                if (bodyopportunityPrincipalContactId != null)
                {
                    body["opportunity-principal-contact-id"] = SourceExpressionConverter.ConvertToken(bodyopportunityPrincipalContactId);
                    bodypropCount++;
                }

                if (bodyopportunityPrincipalContact != null)
                {
                    body["opportunity-principal-contact"] = SourceExpressionConverter.ConvertToken(bodyopportunityPrincipalContact);
                    bodypropCount++;
                }

                if (bodyopportunityDistributorContactId != null)
                {
                    body["opportunity-distributor-contact-id"] = SourceExpressionConverter.ConvertToken(bodyopportunityDistributorContactId);
                    bodypropCount++;
                }

                if (bodyopportunityDistributorContact != null)
                {
                    body["opportunity-distributor-contact"] = SourceExpressionConverter.ConvertToken(bodyopportunityDistributorContact);
                    bodypropCount++;
                }

                bodypropCount++;
                body["opportunity-program"] = SourceExpressionConverter.ConvertToken(bodyopportunityProgram);
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

                if (bodyopportunitySalesTeamId != null)
                {
                    body["opportunity-sales-team-id"] = SourceExpressionConverter.ConvertToken(bodyopportunitySalesTeamId);
                    bodypropCount++;
                }

                if (bodyopportunitySalesTeam != null)
                {
                    body["opportunity-sales-team"] = SourceExpressionConverter.ConvertToken(bodyopportunitySalesTeam);
                    bodypropCount++;
                }

                if (bodyopportunityFollowUp != null)
                {
                    body["opportunity-follow-up"] = SourceExpressionConverter.ConvertToken(bodyopportunityFollowUp);
                    bodypropCount++;
                }

                if (bodyopportunityOppOwner != null)
                {
                    body["opportunity-opp-owner"] = SourceExpressionConverter.ConvertToken(bodyopportunityOppOwner);
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

                if (bodyopportunityDescription != null)
                {
                    body["opportunity-description"] = SourceExpressionConverter.ConvertToken(bodyopportunityDescription);
                    bodypropCount++;
                }

                if (bodyopportunityReportingComments != null)
                {
                    body["opportunity-reporting-comments"] = SourceExpressionConverter.ConvertToken(bodyopportunityReportingComments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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