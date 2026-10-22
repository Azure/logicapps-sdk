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
        public IWorkflowAction<ApiConnectionActionConfiguration> RepfabricCreateLead(Expression<Func<string>> bodydomainName, Expression<Func<string>> bodycompanyName, Expression<Func<string>> bodycontactFirstName, Expression<Func<string>> bodycontactCompanyName, Expression<Func<string>> bodyopportunityPrincipalName, Expression<Func<string>> bodyopportunityProgram, Expression<Func<int>> bodycompanyTypeId = null, Expression<Func<string>> bodycompanyType = null, Expression<Func<string>> bodycompanyClassId = null, Expression<Func<string>> bodycompanyClass = null, Expression<Func<int>> bodycompanyCategoryId = null, Expression<Func<string>> bodycompanyCategory = null, Expression<Func<string>> bodycompanyPhone1 = null, Expression<Func<string>> bodycompanyPhone2 = null, Expression<Func<string>> bodycompanyFax = null, Expression<Func<string>> bodycompanyRegion = null, Expression<Func<string>> bodycompanyStreet = null, Expression<Func<string>> bodycompanyCity = null, Expression<Func<string>> bodycompanyState = null, Expression<Func<string>> bodycompanyZip = null, Expression<Func<string>> bodycompanyCountry = null, Expression<Func<string>> bodycompanyPoBox = null, Expression<Func<string>> bodycompanyWebsite = null, Expression<Func<string>> bodycompanyComments = null, Expression<Func<int>> bodycompanySalesTeamId = null, Expression<Func<string>> bodycompanySalesTeam = null, Expression<Func<string>> bodycontactLastName = null, Expression<Func<string>> bodycontactTitle = null, Expression<Func<string>> bodycontactBackground = null, Expression<Func<bool>> bodycontactPrimary = null, Expression<Func<string>> bodycontactCompanyTypeName = null, Expression<Func<string>> bodycontactEmailAddressWork = null, Expression<Func<string>> bodycontactEmailAddressPersonal = null, Expression<Func<string>> bodycontactEmailAddressAlternate = null, Expression<Func<string>> bodycontactEmailAddressOther = null, Expression<Func<string>> bodycontactPhoneNumberWork = null, Expression<Func<string>> bodycontactPhoneNumberHome = null, Expression<Func<string>> bodycontactPhoneNumberMobile = null, Expression<Func<string>> bodycontactPhoneNumberAlternate = null, Expression<Func<string>> bodycontactFax = null, Expression<Func<string>> bodycontactBusinessStreet = null, Expression<Func<string>> bodycontactBusinessCity = null, Expression<Func<string>> bodycontactBusinessState = null, Expression<Func<string>> bodycontactBusinessZip = null, Expression<Func<string>> bodycontactBusinessCountry = null, Expression<Func<string>> bodycontactHomeStreet = null, Expression<Func<string>> bodycontactHomeCity = null, Expression<Func<string>> bodycontactHomeState = null, Expression<Func<string>> bodycontactHomeZip = null, Expression<Func<string>> bodycontactHomeCountry = null, Expression<Func<JToken[]>> bodycontactTags = null, Expression<Func<int>> bodyopportunityId = null, Expression<Func<int>> bodyopportunityCustomerId = null, Expression<Func<string>> bodyopportunityCustomerName = null, Expression<Func<int>> bodyopportunityPrincipalId = null, Expression<Func<string>> bodyopportunityDistributorId = null, Expression<Func<string>> bodyopportunityDistributorName = null, Expression<Func<string>> bodyopportunityCustomerContactId = null, Expression<Func<string>> bodyopportunityCustomerContact = null, Expression<Func<string>> bodyopportunityPrincipalContactId = null, Expression<Func<string>> bodyopportunityPrincipalContact = null, Expression<Func<string>> bodyopportunityDistributorContactId = null, Expression<Func<string>> bodyopportunityDistributorContact = null, Expression<Func<string>> bodyopportunityNextStep = null, Expression<Func<string>> bodyopportunityActivity = null, Expression<Func<string>> bodyopportunityStatus = null, Expression<Func<int>> bodyopportunitySalesTeamId = null, Expression<Func<string>> bodyopportunitySalesTeam = null, Expression<Func<string>> bodyopportunityFollowUp = null, Expression<Func<int>> bodyopportunityOppOwner = null, Expression<Func<int>> bodyopportunityPriority = null, Expression<Func<int>> bodyopportunityPotential = null, Expression<Func<int>> bodyopportunityEau = null, Expression<Func<double>> bodyopportunityValue = null, Expression<Func<string>> bodyopportunityPrototypeDate = null, Expression<Func<string>> bodyopportunityProductionDate = null, Expression<Func<int>> bodyopportunityCloseStatus = null, Expression<Func<string>> bodyopportunityCloseDate = null, Expression<Func<string>> bodyopportunityCompetitor1 = null, Expression<Func<string>> bodyopportunityCompetitor2 = null, Expression<Func<string>> bodyopportunityDescription = null, Expression<Func<string>> bodyopportunityReportingComments = null)
        {
            var __workflow_bodydomainName = WorkflowExpression.Compile(bodydomainName, nameof(bodydomainName), required: true);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: true);
            var __workflow_bodycontactFirstName = WorkflowExpression.Compile(bodycontactFirstName, nameof(bodycontactFirstName), required: true);
            var __workflow_bodycontactCompanyName = WorkflowExpression.Compile(bodycontactCompanyName, nameof(bodycontactCompanyName), required: true);
            var __workflow_bodyopportunityPrincipalName = WorkflowExpression.Compile(bodyopportunityPrincipalName, nameof(bodyopportunityPrincipalName), required: true);
            var __workflow_bodyopportunityProgram = WorkflowExpression.Compile(bodyopportunityProgram, nameof(bodyopportunityProgram), required: true);
            var __workflow_bodycompanyTypeId = WorkflowExpression.Compile(bodycompanyTypeId, nameof(bodycompanyTypeId), required: false);
            var __workflow_bodycompanyType = WorkflowExpression.Compile(bodycompanyType, nameof(bodycompanyType), required: false);
            var __workflow_bodycompanyClassId = WorkflowExpression.Compile(bodycompanyClassId, nameof(bodycompanyClassId), required: false);
            var __workflow_bodycompanyClass = WorkflowExpression.Compile(bodycompanyClass, nameof(bodycompanyClass), required: false);
            var __workflow_bodycompanyCategoryId = WorkflowExpression.Compile(bodycompanyCategoryId, nameof(bodycompanyCategoryId), required: false);
            var __workflow_bodycompanyCategory = WorkflowExpression.Compile(bodycompanyCategory, nameof(bodycompanyCategory), required: false);
            var __workflow_bodycompanyPhone1 = WorkflowExpression.Compile(bodycompanyPhone1, nameof(bodycompanyPhone1), required: false);
            var __workflow_bodycompanyPhone2 = WorkflowExpression.Compile(bodycompanyPhone2, nameof(bodycompanyPhone2), required: false);
            var __workflow_bodycompanyFax = WorkflowExpression.Compile(bodycompanyFax, nameof(bodycompanyFax), required: false);
            var __workflow_bodycompanyRegion = WorkflowExpression.Compile(bodycompanyRegion, nameof(bodycompanyRegion), required: false);
            var __workflow_bodycompanyStreet = WorkflowExpression.Compile(bodycompanyStreet, nameof(bodycompanyStreet), required: false);
            var __workflow_bodycompanyCity = WorkflowExpression.Compile(bodycompanyCity, nameof(bodycompanyCity), required: false);
            var __workflow_bodycompanyState = WorkflowExpression.Compile(bodycompanyState, nameof(bodycompanyState), required: false);
            var __workflow_bodycompanyZip = WorkflowExpression.Compile(bodycompanyZip, nameof(bodycompanyZip), required: false);
            var __workflow_bodycompanyCountry = WorkflowExpression.Compile(bodycompanyCountry, nameof(bodycompanyCountry), required: false);
            var __workflow_bodycompanyPoBox = WorkflowExpression.Compile(bodycompanyPoBox, nameof(bodycompanyPoBox), required: false);
            var __workflow_bodycompanyWebsite = WorkflowExpression.Compile(bodycompanyWebsite, nameof(bodycompanyWebsite), required: false);
            var __workflow_bodycompanyComments = WorkflowExpression.Compile(bodycompanyComments, nameof(bodycompanyComments), required: false);
            var __workflow_bodycompanySalesTeamId = WorkflowExpression.Compile(bodycompanySalesTeamId, nameof(bodycompanySalesTeamId), required: false);
            var __workflow_bodycompanySalesTeam = WorkflowExpression.Compile(bodycompanySalesTeam, nameof(bodycompanySalesTeam), required: false);
            var __workflow_bodycontactLastName = WorkflowExpression.Compile(bodycontactLastName, nameof(bodycontactLastName), required: false);
            var __workflow_bodycontactTitle = WorkflowExpression.Compile(bodycontactTitle, nameof(bodycontactTitle), required: false);
            var __workflow_bodycontactBackground = WorkflowExpression.Compile(bodycontactBackground, nameof(bodycontactBackground), required: false);
            var __workflow_bodycontactPrimary = WorkflowExpression.Compile(bodycontactPrimary, nameof(bodycontactPrimary), required: false);
            var __workflow_bodycontactCompanyTypeName = WorkflowExpression.Compile(bodycontactCompanyTypeName, nameof(bodycontactCompanyTypeName), required: false);
            var __workflow_bodycontactEmailAddressWork = WorkflowExpression.Compile(bodycontactEmailAddressWork, nameof(bodycontactEmailAddressWork), required: false);
            var __workflow_bodycontactEmailAddressPersonal = WorkflowExpression.Compile(bodycontactEmailAddressPersonal, nameof(bodycontactEmailAddressPersonal), required: false);
            var __workflow_bodycontactEmailAddressAlternate = WorkflowExpression.Compile(bodycontactEmailAddressAlternate, nameof(bodycontactEmailAddressAlternate), required: false);
            var __workflow_bodycontactEmailAddressOther = WorkflowExpression.Compile(bodycontactEmailAddressOther, nameof(bodycontactEmailAddressOther), required: false);
            var __workflow_bodycontactPhoneNumberWork = WorkflowExpression.Compile(bodycontactPhoneNumberWork, nameof(bodycontactPhoneNumberWork), required: false);
            var __workflow_bodycontactPhoneNumberHome = WorkflowExpression.Compile(bodycontactPhoneNumberHome, nameof(bodycontactPhoneNumberHome), required: false);
            var __workflow_bodycontactPhoneNumberMobile = WorkflowExpression.Compile(bodycontactPhoneNumberMobile, nameof(bodycontactPhoneNumberMobile), required: false);
            var __workflow_bodycontactPhoneNumberAlternate = WorkflowExpression.Compile(bodycontactPhoneNumberAlternate, nameof(bodycontactPhoneNumberAlternate), required: false);
            var __workflow_bodycontactFax = WorkflowExpression.Compile(bodycontactFax, nameof(bodycontactFax), required: false);
            var __workflow_bodycontactBusinessStreet = WorkflowExpression.Compile(bodycontactBusinessStreet, nameof(bodycontactBusinessStreet), required: false);
            var __workflow_bodycontactBusinessCity = WorkflowExpression.Compile(bodycontactBusinessCity, nameof(bodycontactBusinessCity), required: false);
            var __workflow_bodycontactBusinessState = WorkflowExpression.Compile(bodycontactBusinessState, nameof(bodycontactBusinessState), required: false);
            var __workflow_bodycontactBusinessZip = WorkflowExpression.Compile(bodycontactBusinessZip, nameof(bodycontactBusinessZip), required: false);
            var __workflow_bodycontactBusinessCountry = WorkflowExpression.Compile(bodycontactBusinessCountry, nameof(bodycontactBusinessCountry), required: false);
            var __workflow_bodycontactHomeStreet = WorkflowExpression.Compile(bodycontactHomeStreet, nameof(bodycontactHomeStreet), required: false);
            var __workflow_bodycontactHomeCity = WorkflowExpression.Compile(bodycontactHomeCity, nameof(bodycontactHomeCity), required: false);
            var __workflow_bodycontactHomeState = WorkflowExpression.Compile(bodycontactHomeState, nameof(bodycontactHomeState), required: false);
            var __workflow_bodycontactHomeZip = WorkflowExpression.Compile(bodycontactHomeZip, nameof(bodycontactHomeZip), required: false);
            var __workflow_bodycontactHomeCountry = WorkflowExpression.Compile(bodycontactHomeCountry, nameof(bodycontactHomeCountry), required: false);
            var __workflow_bodycontactTags = WorkflowExpression.Compile(bodycontactTags, nameof(bodycontactTags), required: false);
            var __workflow_bodyopportunityId = WorkflowExpression.Compile(bodyopportunityId, nameof(bodyopportunityId), required: false);
            var __workflow_bodyopportunityCustomerId = WorkflowExpression.Compile(bodyopportunityCustomerId, nameof(bodyopportunityCustomerId), required: false);
            var __workflow_bodyopportunityCustomerName = WorkflowExpression.Compile(bodyopportunityCustomerName, nameof(bodyopportunityCustomerName), required: false);
            var __workflow_bodyopportunityPrincipalId = WorkflowExpression.Compile(bodyopportunityPrincipalId, nameof(bodyopportunityPrincipalId), required: false);
            var __workflow_bodyopportunityDistributorId = WorkflowExpression.Compile(bodyopportunityDistributorId, nameof(bodyopportunityDistributorId), required: false);
            var __workflow_bodyopportunityDistributorName = WorkflowExpression.Compile(bodyopportunityDistributorName, nameof(bodyopportunityDistributorName), required: false);
            var __workflow_bodyopportunityCustomerContactId = WorkflowExpression.Compile(bodyopportunityCustomerContactId, nameof(bodyopportunityCustomerContactId), required: false);
            var __workflow_bodyopportunityCustomerContact = WorkflowExpression.Compile(bodyopportunityCustomerContact, nameof(bodyopportunityCustomerContact), required: false);
            var __workflow_bodyopportunityPrincipalContactId = WorkflowExpression.Compile(bodyopportunityPrincipalContactId, nameof(bodyopportunityPrincipalContactId), required: false);
            var __workflow_bodyopportunityPrincipalContact = WorkflowExpression.Compile(bodyopportunityPrincipalContact, nameof(bodyopportunityPrincipalContact), required: false);
            var __workflow_bodyopportunityDistributorContactId = WorkflowExpression.Compile(bodyopportunityDistributorContactId, nameof(bodyopportunityDistributorContactId), required: false);
            var __workflow_bodyopportunityDistributorContact = WorkflowExpression.Compile(bodyopportunityDistributorContact, nameof(bodyopportunityDistributorContact), required: false);
            var __workflow_bodyopportunityNextStep = WorkflowExpression.Compile(bodyopportunityNextStep, nameof(bodyopportunityNextStep), required: false);
            var __workflow_bodyopportunityActivity = WorkflowExpression.Compile(bodyopportunityActivity, nameof(bodyopportunityActivity), required: false);
            var __workflow_bodyopportunityStatus = WorkflowExpression.Compile(bodyopportunityStatus, nameof(bodyopportunityStatus), required: false);
            var __workflow_bodyopportunitySalesTeamId = WorkflowExpression.Compile(bodyopportunitySalesTeamId, nameof(bodyopportunitySalesTeamId), required: false);
            var __workflow_bodyopportunitySalesTeam = WorkflowExpression.Compile(bodyopportunitySalesTeam, nameof(bodyopportunitySalesTeam), required: false);
            var __workflow_bodyopportunityFollowUp = WorkflowExpression.Compile(bodyopportunityFollowUp, nameof(bodyopportunityFollowUp), required: false);
            var __workflow_bodyopportunityOppOwner = WorkflowExpression.Compile(bodyopportunityOppOwner, nameof(bodyopportunityOppOwner), required: false);
            var __workflow_bodyopportunityPriority = WorkflowExpression.Compile(bodyopportunityPriority, nameof(bodyopportunityPriority), required: false);
            var __workflow_bodyopportunityPotential = WorkflowExpression.Compile(bodyopportunityPotential, nameof(bodyopportunityPotential), required: false);
            var __workflow_bodyopportunityEau = WorkflowExpression.Compile(bodyopportunityEau, nameof(bodyopportunityEau), required: false);
            var __workflow_bodyopportunityValue = WorkflowExpression.Compile(bodyopportunityValue, nameof(bodyopportunityValue), required: false);
            var __workflow_bodyopportunityPrototypeDate = WorkflowExpression.Compile(bodyopportunityPrototypeDate, nameof(bodyopportunityPrototypeDate), required: false);
            var __workflow_bodyopportunityProductionDate = WorkflowExpression.Compile(bodyopportunityProductionDate, nameof(bodyopportunityProductionDate), required: false);
            var __workflow_bodyopportunityCloseStatus = WorkflowExpression.Compile(bodyopportunityCloseStatus, nameof(bodyopportunityCloseStatus), required: false);
            var __workflow_bodyopportunityCloseDate = WorkflowExpression.Compile(bodyopportunityCloseDate, nameof(bodyopportunityCloseDate), required: false);
            var __workflow_bodyopportunityCompetitor1 = WorkflowExpression.Compile(bodyopportunityCompetitor1, nameof(bodyopportunityCompetitor1), required: false);
            var __workflow_bodyopportunityCompetitor2 = WorkflowExpression.Compile(bodyopportunityCompetitor2, nameof(bodyopportunityCompetitor2), required: false);
            var __workflow_bodyopportunityDescription = WorkflowExpression.Compile(bodyopportunityDescription, nameof(bodyopportunityDescription), required: false);
            var __workflow_bodyopportunityReportingComments = WorkflowExpression.Compile(bodyopportunityReportingComments, nameof(bodyopportunityReportingComments), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/default/LeadLoaderConnector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domain-name"] = ExpressionConverter.ConvertO(__workflow_bodydomainName);
                bodypropCount++;
                body["company-name"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                if (__workflow_bodycompanyTypeId != null)
                {
                    body["company-type-id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyTypeId);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyType != null)
                {
                    body["company-type"] = ExpressionConverter.ConvertO(__workflow_bodycompanyType);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyClassId != null)
                {
                    body["company-class-id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyClassId);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyClass != null)
                {
                    body["company-class"] = ExpressionConverter.ConvertO(__workflow_bodycompanyClass);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyCategoryId != null)
                {
                    body["company-category-id"] = ExpressionConverter.ConvertO(__workflow_bodycompanyCategoryId);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyCategory != null)
                {
                    body["company-category"] = ExpressionConverter.ConvertO(__workflow_bodycompanyCategory);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyPhone1 != null)
                {
                    body["company-phone1"] = ExpressionConverter.ConvertO(__workflow_bodycompanyPhone1);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyPhone2 != null)
                {
                    body["company-phone2"] = ExpressionConverter.ConvertO(__workflow_bodycompanyPhone2);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyFax != null)
                {
                    body["company-fax"] = ExpressionConverter.ConvertO(__workflow_bodycompanyFax);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyRegion != null)
                {
                    body["company-region"] = ExpressionConverter.ConvertO(__workflow_bodycompanyRegion);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyStreet != null)
                {
                    body["company-street"] = ExpressionConverter.ConvertO(__workflow_bodycompanyStreet);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyCity != null)
                {
                    body["company-city"] = ExpressionConverter.ConvertO(__workflow_bodycompanyCity);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyState != null)
                {
                    body["company-state"] = ExpressionConverter.ConvertO(__workflow_bodycompanyState);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyZip != null)
                {
                    body["company-zip"] = ExpressionConverter.ConvertO(__workflow_bodycompanyZip);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyCountry != null)
                {
                    body["company-country"] = ExpressionConverter.ConvertO(__workflow_bodycompanyCountry);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyPoBox != null)
                {
                    body["company-po-box"] = ExpressionConverter.ConvertO(__workflow_bodycompanyPoBox);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyWebsite != null)
                {
                    body["company-website"] = ExpressionConverter.ConvertO(__workflow_bodycompanyWebsite);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyComments != null)
                {
                    body["company-comments"] = ExpressionConverter.ConvertO(__workflow_bodycompanyComments);
                    bodypropCount++;
                }

                if (__workflow_bodycompanySalesTeamId != null)
                {
                    body["company-sales-team-id"] = ExpressionConverter.ConvertO(__workflow_bodycompanySalesTeamId);
                    bodypropCount++;
                }

                if (__workflow_bodycompanySalesTeam != null)
                {
                    body["company-sales-team"] = ExpressionConverter.ConvertO(__workflow_bodycompanySalesTeam);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contact-first-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactFirstName);
                if (__workflow_bodycontactLastName != null)
                {
                    body["contact-last-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactLastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["contact-company-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactCompanyName);
                if (__workflow_bodycontactTitle != null)
                {
                    body["contact-title"] = ExpressionConverter.ConvertO(__workflow_bodycontactTitle);
                    bodypropCount++;
                }

                if (__workflow_bodycontactBackground != null)
                {
                    body["contact-background"] = ExpressionConverter.ConvertO(__workflow_bodycontactBackground);
                    bodypropCount++;
                }

                if (__workflow_bodycontactPrimary != null)
                {
                    body["contact-primary"] = ExpressionConverter.ConvertO(__workflow_bodycontactPrimary);
                    bodypropCount++;
                }

                if (__workflow_bodycontactCompanyTypeName != null)
                {
                    body["contact-company-type-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactCompanyTypeName);
                    bodypropCount++;
                }

                if (__workflow_bodycontactEmailAddressWork != null)
                {
                    body["contact-email-address-work"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmailAddressWork);
                    bodypropCount++;
                }

                if (__workflow_bodycontactEmailAddressPersonal != null)
                {
                    body["contact-email-address-personal"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmailAddressPersonal);
                    bodypropCount++;
                }

                if (__workflow_bodycontactEmailAddressAlternate != null)
                {
                    body["contact-email-address-alternate"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmailAddressAlternate);
                    bodypropCount++;
                }

                if (__workflow_bodycontactEmailAddressOther != null)
                {
                    body["contact-email-address-other"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmailAddressOther);
                    bodypropCount++;
                }

                if (__workflow_bodycontactPhoneNumberWork != null)
                {
                    body["contact-phone-number-work"] = ExpressionConverter.ConvertO(__workflow_bodycontactPhoneNumberWork);
                    bodypropCount++;
                }

                if (__workflow_bodycontactPhoneNumberHome != null)
                {
                    body["contact-phone-number-home"] = ExpressionConverter.ConvertO(__workflow_bodycontactPhoneNumberHome);
                    bodypropCount++;
                }

                if (__workflow_bodycontactPhoneNumberMobile != null)
                {
                    body["contact-phone-number-mobile"] = ExpressionConverter.ConvertO(__workflow_bodycontactPhoneNumberMobile);
                    bodypropCount++;
                }

                if (__workflow_bodycontactPhoneNumberAlternate != null)
                {
                    body["contact-phone-number-alternate"] = ExpressionConverter.ConvertO(__workflow_bodycontactPhoneNumberAlternate);
                    bodypropCount++;
                }

                if (__workflow_bodycontactFax != null)
                {
                    body["contact-fax"] = ExpressionConverter.ConvertO(__workflow_bodycontactFax);
                    bodypropCount++;
                }

                if (__workflow_bodycontactBusinessStreet != null)
                {
                    body["contact-business-street"] = ExpressionConverter.ConvertO(__workflow_bodycontactBusinessStreet);
                    bodypropCount++;
                }

                if (__workflow_bodycontactBusinessCity != null)
                {
                    body["contact-business-city"] = ExpressionConverter.ConvertO(__workflow_bodycontactBusinessCity);
                    bodypropCount++;
                }

                if (__workflow_bodycontactBusinessState != null)
                {
                    body["contact-business-state"] = ExpressionConverter.ConvertO(__workflow_bodycontactBusinessState);
                    bodypropCount++;
                }

                if (__workflow_bodycontactBusinessZip != null)
                {
                    body["contact-business-zip"] = ExpressionConverter.ConvertO(__workflow_bodycontactBusinessZip);
                    bodypropCount++;
                }

                if (__workflow_bodycontactBusinessCountry != null)
                {
                    body["contact-business-country"] = ExpressionConverter.ConvertO(__workflow_bodycontactBusinessCountry);
                    bodypropCount++;
                }

                if (__workflow_bodycontactHomeStreet != null)
                {
                    body["contact-home-street"] = ExpressionConverter.ConvertO(__workflow_bodycontactHomeStreet);
                    bodypropCount++;
                }

                if (__workflow_bodycontactHomeCity != null)
                {
                    body["contact-home-city"] = ExpressionConverter.ConvertO(__workflow_bodycontactHomeCity);
                    bodypropCount++;
                }

                if (__workflow_bodycontactHomeState != null)
                {
                    body["contact-home-state"] = ExpressionConverter.ConvertO(__workflow_bodycontactHomeState);
                    bodypropCount++;
                }

                if (__workflow_bodycontactHomeZip != null)
                {
                    body["contact-home-zip"] = ExpressionConverter.ConvertO(__workflow_bodycontactHomeZip);
                    bodypropCount++;
                }

                if (__workflow_bodycontactHomeCountry != null)
                {
                    body["contact-home-country"] = ExpressionConverter.ConvertO(__workflow_bodycontactHomeCountry);
                    bodypropCount++;
                }

                if (__workflow_bodycontactTags != null)
                {
                    body["contact-tags"] = ExpressionConverter.ConvertO(__workflow_bodycontactTags);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityId != null)
                {
                    body["opportunity-id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityId);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityCustomerId != null)
                {
                    body["opportunity-customer-id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityCustomerId);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityCustomerName != null)
                {
                    body["opportunity-customer-name"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityCustomerName);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityPrincipalId != null)
                {
                    body["opportunity-principal-id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityPrincipalId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["opportunity-principal-name"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityPrincipalName);
                if (__workflow_bodyopportunityDistributorId != null)
                {
                    body["opportunity-distributor-id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityDistributorId);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityDistributorName != null)
                {
                    body["opportunity-distributor-name"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityDistributorName);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityCustomerContactId != null)
                {
                    body["opportunity-customer-contact-id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityCustomerContactId);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityCustomerContact != null)
                {
                    body["opportunity-customer-contact"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityCustomerContact);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityPrincipalContactId != null)
                {
                    body["opportunity-principal-contact-id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityPrincipalContactId);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityPrincipalContact != null)
                {
                    body["opportunity-principal-contact"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityPrincipalContact);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityDistributorContactId != null)
                {
                    body["opportunity-distributor-contact-id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityDistributorContactId);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityDistributorContact != null)
                {
                    body["opportunity-distributor-contact"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityDistributorContact);
                    bodypropCount++;
                }

                bodypropCount++;
                body["opportunity-program"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityProgram);
                if (__workflow_bodyopportunityNextStep != null)
                {
                    body["opportunity-next-step"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityNextStep);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityActivity != null)
                {
                    body["opportunity-activity"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityActivity);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityStatus != null)
                {
                    body["opportunity-status"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunitySalesTeamId != null)
                {
                    body["opportunity-sales-team-id"] = ExpressionConverter.ConvertO(__workflow_bodyopportunitySalesTeamId);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunitySalesTeam != null)
                {
                    body["opportunity-sales-team"] = ExpressionConverter.ConvertO(__workflow_bodyopportunitySalesTeam);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityFollowUp != null)
                {
                    body["opportunity-follow-up"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityFollowUp);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityOppOwner != null)
                {
                    body["opportunity-opp-owner"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityOppOwner);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityPriority != null)
                {
                    body["opportunity-priority"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityPriority);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityPotential != null)
                {
                    body["opportunity-potential"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityPotential);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityEau != null)
                {
                    body["opportunity-eau"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityEau);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityValue != null)
                {
                    body["opportunity-value"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityValue);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityPrototypeDate != null)
                {
                    body["opportunity-prototype-date"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityPrototypeDate);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityProductionDate != null)
                {
                    body["opportunity-production-date"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityProductionDate);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityCloseStatus != null)
                {
                    body["opportunity-close-status"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityCloseStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityCloseDate != null)
                {
                    body["opportunity-close-date"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityCloseDate);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityCompetitor1 != null)
                {
                    body["opportunity-competitor-1"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityCompetitor1);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityCompetitor2 != null)
                {
                    body["opportunity-competitor-2"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityCompetitor2);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityDescription != null)
                {
                    body["opportunity-description"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityReportingComments != null)
                {
                    body["opportunity-reporting-comments"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityReportingComments);
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
