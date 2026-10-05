//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Repfabricleadloader
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RepfabricleadloaderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "repfabricleadloader")]
        [WorkflowExpressionFactory(nameof(__BuildRepfabricCreateLead))]
        public IWorkflowAction RepfabricCreateLead([WorkflowExpression] Func<string> bodydomainName, [WorkflowExpression] Func<string> bodycompanyName, [WorkflowExpression] Func<string> bodycontactFirstName, [WorkflowExpression] Func<string> bodycontactCompanyName, [WorkflowExpression] Func<string> bodyopportunityPrincipalName, [WorkflowExpression] Func<string> bodyopportunityProgram, [WorkflowExpression] Func<int> bodycompanyTypeId = null, [WorkflowExpression] Func<string> bodycompanyType = null, [WorkflowExpression] Func<string> bodycompanyClassId = null, [WorkflowExpression] Func<string> bodycompanyClass = null, [WorkflowExpression] Func<int> bodycompanyCategoryId = null, [WorkflowExpression] Func<string> bodycompanyCategory = null, [WorkflowExpression] Func<string> bodycompanyPhone1 = null, [WorkflowExpression] Func<string> bodycompanyPhone2 = null, [WorkflowExpression] Func<string> bodycompanyFax = null, [WorkflowExpression] Func<string> bodycompanyRegion = null, [WorkflowExpression] Func<string> bodycompanyStreet = null, [WorkflowExpression] Func<string> bodycompanyCity = null, [WorkflowExpression] Func<string> bodycompanyState = null, [WorkflowExpression] Func<string> bodycompanyZip = null, [WorkflowExpression] Func<string> bodycompanyCountry = null, [WorkflowExpression] Func<string> bodycompanyPoBox = null, [WorkflowExpression] Func<string> bodycompanyWebsite = null, [WorkflowExpression] Func<string> bodycompanyComments = null, [WorkflowExpression] Func<int> bodycompanySalesTeamId = null, [WorkflowExpression] Func<string> bodycompanySalesTeam = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<string> bodycontactTitle = null, [WorkflowExpression] Func<string> bodycontactBackground = null, [WorkflowExpression] Func<bool> bodycontactPrimary = null, [WorkflowExpression] Func<string> bodycontactCompanyTypeName = null, [WorkflowExpression] Func<string> bodycontactEmailAddressWork = null, [WorkflowExpression] Func<string> bodycontactEmailAddressPersonal = null, [WorkflowExpression] Func<string> bodycontactEmailAddressAlternate = null, [WorkflowExpression] Func<string> bodycontactEmailAddressOther = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberWork = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberHome = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberMobile = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberAlternate = null, [WorkflowExpression] Func<string> bodycontactFax = null, [WorkflowExpression] Func<string> bodycontactBusinessStreet = null, [WorkflowExpression] Func<string> bodycontactBusinessCity = null, [WorkflowExpression] Func<string> bodycontactBusinessState = null, [WorkflowExpression] Func<string> bodycontactBusinessZip = null, [WorkflowExpression] Func<string> bodycontactBusinessCountry = null, [WorkflowExpression] Func<string> bodycontactHomeStreet = null, [WorkflowExpression] Func<string> bodycontactHomeCity = null, [WorkflowExpression] Func<string> bodycontactHomeState = null, [WorkflowExpression] Func<string> bodycontactHomeZip = null, [WorkflowExpression] Func<string> bodycontactHomeCountry = null, [WorkflowExpression] Func<JToken[]> bodycontactTags = null, [WorkflowExpression] Func<int> bodyopportunityId = null, [WorkflowExpression] Func<int> bodyopportunityCustomerId = null, [WorkflowExpression] Func<string> bodyopportunityCustomerName = null, [WorkflowExpression] Func<int> bodyopportunityPrincipalId = null, [WorkflowExpression] Func<string> bodyopportunityDistributorId = null, [WorkflowExpression] Func<string> bodyopportunityDistributorName = null, [WorkflowExpression] Func<string> bodyopportunityCustomerContactId = null, [WorkflowExpression] Func<string> bodyopportunityCustomerContact = null, [WorkflowExpression] Func<string> bodyopportunityPrincipalContactId = null, [WorkflowExpression] Func<string> bodyopportunityPrincipalContact = null, [WorkflowExpression] Func<string> bodyopportunityDistributorContactId = null, [WorkflowExpression] Func<string> bodyopportunityDistributorContact = null, [WorkflowExpression] Func<string> bodyopportunityNextStep = null, [WorkflowExpression] Func<string> bodyopportunityActivity = null, [WorkflowExpression] Func<string> bodyopportunityStatus = null, [WorkflowExpression] Func<int> bodyopportunitySalesTeamId = null, [WorkflowExpression] Func<string> bodyopportunitySalesTeam = null, [WorkflowExpression] Func<string> bodyopportunityFollowUp = null, [WorkflowExpression] Func<int> bodyopportunityOppOwner = null, [WorkflowExpression] Func<int> bodyopportunityPriority = null, [WorkflowExpression] Func<int> bodyopportunityPotential = null, [WorkflowExpression] Func<int> bodyopportunityEau = null, [WorkflowExpression] Func<double> bodyopportunityValue = null, [WorkflowExpression] Func<string> bodyopportunityPrototypeDate = null, [WorkflowExpression] Func<string> bodyopportunityProductionDate = null, [WorkflowExpression] Func<int> bodyopportunityCloseStatus = null, [WorkflowExpression] Func<string> bodyopportunityCloseDate = null, [WorkflowExpression] Func<string> bodyopportunityCompetitor1 = null, [WorkflowExpression] Func<string> bodyopportunityCompetitor2 = null, [WorkflowExpression] Func<string> bodyopportunityDescription = null, [WorkflowExpression] Func<string> bodyopportunityReportingComments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRepfabricCreateLead(WorkflowValue<string> bodydomainName, WorkflowValue<string> bodycompanyName, WorkflowValue<string> bodycontactFirstName, WorkflowValue<string> bodycontactCompanyName, WorkflowValue<string> bodyopportunityPrincipalName, WorkflowValue<string> bodyopportunityProgram, WorkflowValue<int> bodycompanyTypeId = null, WorkflowValue<string> bodycompanyType = null, WorkflowValue<string> bodycompanyClassId = null, WorkflowValue<string> bodycompanyClass = null, WorkflowValue<int> bodycompanyCategoryId = null, WorkflowValue<string> bodycompanyCategory = null, WorkflowValue<string> bodycompanyPhone1 = null, WorkflowValue<string> bodycompanyPhone2 = null, WorkflowValue<string> bodycompanyFax = null, WorkflowValue<string> bodycompanyRegion = null, WorkflowValue<string> bodycompanyStreet = null, WorkflowValue<string> bodycompanyCity = null, WorkflowValue<string> bodycompanyState = null, WorkflowValue<string> bodycompanyZip = null, WorkflowValue<string> bodycompanyCountry = null, WorkflowValue<string> bodycompanyPoBox = null, WorkflowValue<string> bodycompanyWebsite = null, WorkflowValue<string> bodycompanyComments = null, WorkflowValue<int> bodycompanySalesTeamId = null, WorkflowValue<string> bodycompanySalesTeam = null, WorkflowValue<string> bodycontactLastName = null, WorkflowValue<string> bodycontactTitle = null, WorkflowValue<string> bodycontactBackground = null, WorkflowValue<bool> bodycontactPrimary = null, WorkflowValue<string> bodycontactCompanyTypeName = null, WorkflowValue<string> bodycontactEmailAddressWork = null, WorkflowValue<string> bodycontactEmailAddressPersonal = null, WorkflowValue<string> bodycontactEmailAddressAlternate = null, WorkflowValue<string> bodycontactEmailAddressOther = null, WorkflowValue<string> bodycontactPhoneNumberWork = null, WorkflowValue<string> bodycontactPhoneNumberHome = null, WorkflowValue<string> bodycontactPhoneNumberMobile = null, WorkflowValue<string> bodycontactPhoneNumberAlternate = null, WorkflowValue<string> bodycontactFax = null, WorkflowValue<string> bodycontactBusinessStreet = null, WorkflowValue<string> bodycontactBusinessCity = null, WorkflowValue<string> bodycontactBusinessState = null, WorkflowValue<string> bodycontactBusinessZip = null, WorkflowValue<string> bodycontactBusinessCountry = null, WorkflowValue<string> bodycontactHomeStreet = null, WorkflowValue<string> bodycontactHomeCity = null, WorkflowValue<string> bodycontactHomeState = null, WorkflowValue<string> bodycontactHomeZip = null, WorkflowValue<string> bodycontactHomeCountry = null, WorkflowValue<JToken[]> bodycontactTags = null, WorkflowValue<int> bodyopportunityId = null, WorkflowValue<int> bodyopportunityCustomerId = null, WorkflowValue<string> bodyopportunityCustomerName = null, WorkflowValue<int> bodyopportunityPrincipalId = null, WorkflowValue<string> bodyopportunityDistributorId = null, WorkflowValue<string> bodyopportunityDistributorName = null, WorkflowValue<string> bodyopportunityCustomerContactId = null, WorkflowValue<string> bodyopportunityCustomerContact = null, WorkflowValue<string> bodyopportunityPrincipalContactId = null, WorkflowValue<string> bodyopportunityPrincipalContact = null, WorkflowValue<string> bodyopportunityDistributorContactId = null, WorkflowValue<string> bodyopportunityDistributorContact = null, WorkflowValue<string> bodyopportunityNextStep = null, WorkflowValue<string> bodyopportunityActivity = null, WorkflowValue<string> bodyopportunityStatus = null, WorkflowValue<int> bodyopportunitySalesTeamId = null, WorkflowValue<string> bodyopportunitySalesTeam = null, WorkflowValue<string> bodyopportunityFollowUp = null, WorkflowValue<int> bodyopportunityOppOwner = null, WorkflowValue<int> bodyopportunityPriority = null, WorkflowValue<int> bodyopportunityPotential = null, WorkflowValue<int> bodyopportunityEau = null, WorkflowValue<double> bodyopportunityValue = null, WorkflowValue<string> bodyopportunityPrototypeDate = null, WorkflowValue<string> bodyopportunityProductionDate = null, WorkflowValue<int> bodyopportunityCloseStatus = null, WorkflowValue<string> bodyopportunityCloseDate = null, WorkflowValue<string> bodyopportunityCompetitor1 = null, WorkflowValue<string> bodyopportunityCompetitor2 = null, WorkflowValue<string> bodyopportunityDescription = null, WorkflowValue<string> bodyopportunityReportingComments = null)
        {
            WorkflowValue.Validate(bodydomainName, nameof(bodydomainName), required: true);
            WorkflowValue.Validate(bodycompanyName, nameof(bodycompanyName), required: true);
            WorkflowValue.Validate(bodycontactFirstName, nameof(bodycontactFirstName), required: true);
            WorkflowValue.Validate(bodycontactCompanyName, nameof(bodycontactCompanyName), required: true);
            WorkflowValue.Validate(bodyopportunityPrincipalName, nameof(bodyopportunityPrincipalName), required: true);
            WorkflowValue.Validate(bodyopportunityProgram, nameof(bodyopportunityProgram), required: true);
            WorkflowValue.Validate(bodycompanyTypeId, nameof(bodycompanyTypeId), required: false);
            WorkflowValue.Validate(bodycompanyType, nameof(bodycompanyType), required: false);
            WorkflowValue.Validate(bodycompanyClassId, nameof(bodycompanyClassId), required: false);
            WorkflowValue.Validate(bodycompanyClass, nameof(bodycompanyClass), required: false);
            WorkflowValue.Validate(bodycompanyCategoryId, nameof(bodycompanyCategoryId), required: false);
            WorkflowValue.Validate(bodycompanyCategory, nameof(bodycompanyCategory), required: false);
            WorkflowValue.Validate(bodycompanyPhone1, nameof(bodycompanyPhone1), required: false);
            WorkflowValue.Validate(bodycompanyPhone2, nameof(bodycompanyPhone2), required: false);
            WorkflowValue.Validate(bodycompanyFax, nameof(bodycompanyFax), required: false);
            WorkflowValue.Validate(bodycompanyRegion, nameof(bodycompanyRegion), required: false);
            WorkflowValue.Validate(bodycompanyStreet, nameof(bodycompanyStreet), required: false);
            WorkflowValue.Validate(bodycompanyCity, nameof(bodycompanyCity), required: false);
            WorkflowValue.Validate(bodycompanyState, nameof(bodycompanyState), required: false);
            WorkflowValue.Validate(bodycompanyZip, nameof(bodycompanyZip), required: false);
            WorkflowValue.Validate(bodycompanyCountry, nameof(bodycompanyCountry), required: false);
            WorkflowValue.Validate(bodycompanyPoBox, nameof(bodycompanyPoBox), required: false);
            WorkflowValue.Validate(bodycompanyWebsite, nameof(bodycompanyWebsite), required: false);
            WorkflowValue.Validate(bodycompanyComments, nameof(bodycompanyComments), required: false);
            WorkflowValue.Validate(bodycompanySalesTeamId, nameof(bodycompanySalesTeamId), required: false);
            WorkflowValue.Validate(bodycompanySalesTeam, nameof(bodycompanySalesTeam), required: false);
            WorkflowValue.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            WorkflowValue.Validate(bodycontactTitle, nameof(bodycontactTitle), required: false);
            WorkflowValue.Validate(bodycontactBackground, nameof(bodycontactBackground), required: false);
            WorkflowValue.Validate(bodycontactPrimary, nameof(bodycontactPrimary), required: false);
            WorkflowValue.Validate(bodycontactCompanyTypeName, nameof(bodycontactCompanyTypeName), required: false);
            WorkflowValue.Validate(bodycontactEmailAddressWork, nameof(bodycontactEmailAddressWork), required: false);
            WorkflowValue.Validate(bodycontactEmailAddressPersonal, nameof(bodycontactEmailAddressPersonal), required: false);
            WorkflowValue.Validate(bodycontactEmailAddressAlternate, nameof(bodycontactEmailAddressAlternate), required: false);
            WorkflowValue.Validate(bodycontactEmailAddressOther, nameof(bodycontactEmailAddressOther), required: false);
            WorkflowValue.Validate(bodycontactPhoneNumberWork, nameof(bodycontactPhoneNumberWork), required: false);
            WorkflowValue.Validate(bodycontactPhoneNumberHome, nameof(bodycontactPhoneNumberHome), required: false);
            WorkflowValue.Validate(bodycontactPhoneNumberMobile, nameof(bodycontactPhoneNumberMobile), required: false);
            WorkflowValue.Validate(bodycontactPhoneNumberAlternate, nameof(bodycontactPhoneNumberAlternate), required: false);
            WorkflowValue.Validate(bodycontactFax, nameof(bodycontactFax), required: false);
            WorkflowValue.Validate(bodycontactBusinessStreet, nameof(bodycontactBusinessStreet), required: false);
            WorkflowValue.Validate(bodycontactBusinessCity, nameof(bodycontactBusinessCity), required: false);
            WorkflowValue.Validate(bodycontactBusinessState, nameof(bodycontactBusinessState), required: false);
            WorkflowValue.Validate(bodycontactBusinessZip, nameof(bodycontactBusinessZip), required: false);
            WorkflowValue.Validate(bodycontactBusinessCountry, nameof(bodycontactBusinessCountry), required: false);
            WorkflowValue.Validate(bodycontactHomeStreet, nameof(bodycontactHomeStreet), required: false);
            WorkflowValue.Validate(bodycontactHomeCity, nameof(bodycontactHomeCity), required: false);
            WorkflowValue.Validate(bodycontactHomeState, nameof(bodycontactHomeState), required: false);
            WorkflowValue.Validate(bodycontactHomeZip, nameof(bodycontactHomeZip), required: false);
            WorkflowValue.Validate(bodycontactHomeCountry, nameof(bodycontactHomeCountry), required: false);
            WorkflowValue.Validate(bodycontactTags, nameof(bodycontactTags), required: false);
            WorkflowValue.Validate(bodyopportunityId, nameof(bodyopportunityId), required: false);
            WorkflowValue.Validate(bodyopportunityCustomerId, nameof(bodyopportunityCustomerId), required: false);
            WorkflowValue.Validate(bodyopportunityCustomerName, nameof(bodyopportunityCustomerName), required: false);
            WorkflowValue.Validate(bodyopportunityPrincipalId, nameof(bodyopportunityPrincipalId), required: false);
            WorkflowValue.Validate(bodyopportunityDistributorId, nameof(bodyopportunityDistributorId), required: false);
            WorkflowValue.Validate(bodyopportunityDistributorName, nameof(bodyopportunityDistributorName), required: false);
            WorkflowValue.Validate(bodyopportunityCustomerContactId, nameof(bodyopportunityCustomerContactId), required: false);
            WorkflowValue.Validate(bodyopportunityCustomerContact, nameof(bodyopportunityCustomerContact), required: false);
            WorkflowValue.Validate(bodyopportunityPrincipalContactId, nameof(bodyopportunityPrincipalContactId), required: false);
            WorkflowValue.Validate(bodyopportunityPrincipalContact, nameof(bodyopportunityPrincipalContact), required: false);
            WorkflowValue.Validate(bodyopportunityDistributorContactId, nameof(bodyopportunityDistributorContactId), required: false);
            WorkflowValue.Validate(bodyopportunityDistributorContact, nameof(bodyopportunityDistributorContact), required: false);
            WorkflowValue.Validate(bodyopportunityNextStep, nameof(bodyopportunityNextStep), required: false);
            WorkflowValue.Validate(bodyopportunityActivity, nameof(bodyopportunityActivity), required: false);
            WorkflowValue.Validate(bodyopportunityStatus, nameof(bodyopportunityStatus), required: false);
            WorkflowValue.Validate(bodyopportunitySalesTeamId, nameof(bodyopportunitySalesTeamId), required: false);
            WorkflowValue.Validate(bodyopportunitySalesTeam, nameof(bodyopportunitySalesTeam), required: false);
            WorkflowValue.Validate(bodyopportunityFollowUp, nameof(bodyopportunityFollowUp), required: false);
            WorkflowValue.Validate(bodyopportunityOppOwner, nameof(bodyopportunityOppOwner), required: false);
            WorkflowValue.Validate(bodyopportunityPriority, nameof(bodyopportunityPriority), required: false);
            WorkflowValue.Validate(bodyopportunityPotential, nameof(bodyopportunityPotential), required: false);
            WorkflowValue.Validate(bodyopportunityEau, nameof(bodyopportunityEau), required: false);
            WorkflowValue.Validate(bodyopportunityValue, nameof(bodyopportunityValue), required: false);
            WorkflowValue.Validate(bodyopportunityPrototypeDate, nameof(bodyopportunityPrototypeDate), required: false);
            WorkflowValue.Validate(bodyopportunityProductionDate, nameof(bodyopportunityProductionDate), required: false);
            WorkflowValue.Validate(bodyopportunityCloseStatus, nameof(bodyopportunityCloseStatus), required: false);
            WorkflowValue.Validate(bodyopportunityCloseDate, nameof(bodyopportunityCloseDate), required: false);
            WorkflowValue.Validate(bodyopportunityCompetitor1, nameof(bodyopportunityCompetitor1), required: false);
            WorkflowValue.Validate(bodyopportunityCompetitor2, nameof(bodyopportunityCompetitor2), required: false);
            WorkflowValue.Validate(bodyopportunityDescription, nameof(bodyopportunityDescription), required: false);
            WorkflowValue.Validate(bodyopportunityReportingComments, nameof(bodyopportunityReportingComments), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
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
