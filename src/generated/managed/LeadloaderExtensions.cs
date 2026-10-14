//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leadloader
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class LeadloaderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leadloader")]
        public IBodyWorkflowAction<UploadLeadsV3Response> UploadLeads(Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodycompanyType = null, Expression<Func<string>> bodycompanyClass = null, Expression<Func<string>> bodycompanyCategory = null, Expression<Func<string>> bodycompanyPhone1 = null, Expression<Func<string>> bodycompanyPhone2 = null, Expression<Func<string>> bodycompanyFax = null, Expression<Func<string>> bodycompanyRegion = null, Expression<Func<string>> bodycompanyStreet = null, Expression<Func<string>> bodycompanyCity = null, Expression<Func<string>> bodycompanyState = null, Expression<Func<string>> bodycompanyZip = null, Expression<Func<string>> bodycompanyCountry = null, Expression<Func<string>> bodycompanyPoBox = null, Expression<Func<string>> bodycompanyWebsite = null, Expression<Func<string>> bodycompanyComments = null, Expression<Func<string>> bodycompanySalesTeam = null, Expression<Func<string>> bodycompanyIndustries = null, Expression<Func<string>> bodycompanyProductPotentials = null, Expression<Func<string>> bodycontactFirstName = null, Expression<Func<string>> bodycontactLastName = null, Expression<Func<string>> bodycontactFullName = null, Expression<Func<string>> bodycontactTitle = null, Expression<Func<string>> bodycontactBackground = null, Expression<Func<bool>> bodycontactPrimaryContact = null, Expression<Func<string>> bodycontactTypeName = null, Expression<Func<string>> bodycontactEmailAddressWork = null, Expression<Func<string>> bodycontactEmailAddressPersonal = null, Expression<Func<string>> bodycontactEmailAddressAlternate = null, Expression<Func<string>> bodycontactEmailAddressOther = null, Expression<Func<string>> bodycontactPhoneNumberWork = null, Expression<Func<string>> bodycontactPhoneNumberHome = null, Expression<Func<string>> bodycontactPhoneNumberMobile = null, Expression<Func<string>> bodycontactPhoneNumberAlternate = null, Expression<Func<string>> bodycontactFax = null, Expression<Func<string>> bodycontactBusinessStreet = null, Expression<Func<string>> bodycontactBusinessCity = null, Expression<Func<string>> bodycontactBusinessState = null, Expression<Func<string>> bodycontactBusinessZip = null, Expression<Func<string>> bodycontactBusinessCountry = null, Expression<Func<string>> bodycontactHomeStreet = null, Expression<Func<string>> bodycontactHomeCity = null, Expression<Func<string>> bodycontactHomeState = null, Expression<Func<string>> bodycontactHomeZip = null, Expression<Func<string>> bodycontactHomeCountry = null, Expression<Func<string>> bodycontactNotes = null, Expression<Func<string>> bodycontactGroups = null, Expression<Func<string>> bodycontactProductInterests = null, Expression<Func<string>> bodyopportunityPrincipalName = null, Expression<Func<string>> bodyopportunityProgram = null, Expression<Func<string>> bodyopportunityCustomerName = null, Expression<Func<string>> bodyopportunityDistributorName = null, Expression<Func<string>> bodyopportunityCustomerContact = null, Expression<Func<string>> bodyopportunityPrincipalContact = null, Expression<Func<string>> bodyopportunityDistributorContact = null, Expression<Func<string>> bodyopportunityNextStep = null, Expression<Func<string>> bodyopportunityActivity = null, Expression<Func<string>> bodyopportunityStatus = null, Expression<Func<string>> bodyopportunityFollowUp = null, Expression<Func<int>> bodyopportunityPriority = null, Expression<Func<int>> bodyopportunityPotential = null, Expression<Func<int>> bodyopportunityEau = null, Expression<Func<int>> bodyopportunityValue = null, Expression<Func<string>> bodyopportunityPrototypeDate = null, Expression<Func<string>> bodyopportunityProductionDate = null, Expression<Func<int>> bodyopportunityCloseStatus = null, Expression<Func<string>> bodyopportunityCloseDate = null, Expression<Func<string>> bodyopportunityDescription = null, Expression<Func<string>> bodyopportunityCompetitor1 = null, Expression<Func<string>> bodyopportunityCompetitor2 = null, Expression<Func<string>> bodyopportunityReportingComments = null, Expression<Func<string>> bodyopportunityLeadSourceName = null, Expression<Func<string>> bodydomain = null, Expression<Func<string>> bodyusername = null, Expression<Func<string>> bodypassword = null)
        {
            var __workflow_bodycompany = bodycompany == null ? null : WorkflowExpression.Compile(bodycompany);
            WorkflowExpression.Validate(__workflow_bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodycompanyType = bodycompanyType == null ? null : WorkflowExpression.Compile(bodycompanyType);
            WorkflowExpression.Validate(__workflow_bodycompanyType, nameof(bodycompanyType), required: false);
            var __workflow_bodycompanyClass = bodycompanyClass == null ? null : WorkflowExpression.Compile(bodycompanyClass);
            WorkflowExpression.Validate(__workflow_bodycompanyClass, nameof(bodycompanyClass), required: false);
            var __workflow_bodycompanyCategory = bodycompanyCategory == null ? null : WorkflowExpression.Compile(bodycompanyCategory);
            WorkflowExpression.Validate(__workflow_bodycompanyCategory, nameof(bodycompanyCategory), required: false);
            var __workflow_bodycompanyPhone1 = bodycompanyPhone1 == null ? null : WorkflowExpression.Compile(bodycompanyPhone1);
            WorkflowExpression.Validate(__workflow_bodycompanyPhone1, nameof(bodycompanyPhone1), required: false);
            var __workflow_bodycompanyPhone2 = bodycompanyPhone2 == null ? null : WorkflowExpression.Compile(bodycompanyPhone2);
            WorkflowExpression.Validate(__workflow_bodycompanyPhone2, nameof(bodycompanyPhone2), required: false);
            var __workflow_bodycompanyFax = bodycompanyFax == null ? null : WorkflowExpression.Compile(bodycompanyFax);
            WorkflowExpression.Validate(__workflow_bodycompanyFax, nameof(bodycompanyFax), required: false);
            var __workflow_bodycompanyRegion = bodycompanyRegion == null ? null : WorkflowExpression.Compile(bodycompanyRegion);
            WorkflowExpression.Validate(__workflow_bodycompanyRegion, nameof(bodycompanyRegion), required: false);
            var __workflow_bodycompanyStreet = bodycompanyStreet == null ? null : WorkflowExpression.Compile(bodycompanyStreet);
            WorkflowExpression.Validate(__workflow_bodycompanyStreet, nameof(bodycompanyStreet), required: false);
            var __workflow_bodycompanyCity = bodycompanyCity == null ? null : WorkflowExpression.Compile(bodycompanyCity);
            WorkflowExpression.Validate(__workflow_bodycompanyCity, nameof(bodycompanyCity), required: false);
            var __workflow_bodycompanyState = bodycompanyState == null ? null : WorkflowExpression.Compile(bodycompanyState);
            WorkflowExpression.Validate(__workflow_bodycompanyState, nameof(bodycompanyState), required: false);
            var __workflow_bodycompanyZip = bodycompanyZip == null ? null : WorkflowExpression.Compile(bodycompanyZip);
            WorkflowExpression.Validate(__workflow_bodycompanyZip, nameof(bodycompanyZip), required: false);
            var __workflow_bodycompanyCountry = bodycompanyCountry == null ? null : WorkflowExpression.Compile(bodycompanyCountry);
            WorkflowExpression.Validate(__workflow_bodycompanyCountry, nameof(bodycompanyCountry), required: false);
            var __workflow_bodycompanyPoBox = bodycompanyPoBox == null ? null : WorkflowExpression.Compile(bodycompanyPoBox);
            WorkflowExpression.Validate(__workflow_bodycompanyPoBox, nameof(bodycompanyPoBox), required: false);
            var __workflow_bodycompanyWebsite = bodycompanyWebsite == null ? null : WorkflowExpression.Compile(bodycompanyWebsite);
            WorkflowExpression.Validate(__workflow_bodycompanyWebsite, nameof(bodycompanyWebsite), required: false);
            var __workflow_bodycompanyComments = bodycompanyComments == null ? null : WorkflowExpression.Compile(bodycompanyComments);
            WorkflowExpression.Validate(__workflow_bodycompanyComments, nameof(bodycompanyComments), required: false);
            var __workflow_bodycompanySalesTeam = bodycompanySalesTeam == null ? null : WorkflowExpression.Compile(bodycompanySalesTeam);
            WorkflowExpression.Validate(__workflow_bodycompanySalesTeam, nameof(bodycompanySalesTeam), required: false);
            var __workflow_bodycompanyIndustries = bodycompanyIndustries == null ? null : WorkflowExpression.Compile(bodycompanyIndustries);
            WorkflowExpression.Validate(__workflow_bodycompanyIndustries, nameof(bodycompanyIndustries), required: false);
            var __workflow_bodycompanyProductPotentials = bodycompanyProductPotentials == null ? null : WorkflowExpression.Compile(bodycompanyProductPotentials);
            WorkflowExpression.Validate(__workflow_bodycompanyProductPotentials, nameof(bodycompanyProductPotentials), required: false);
            var __workflow_bodycontactFirstName = bodycontactFirstName == null ? null : WorkflowExpression.Compile(bodycontactFirstName);
            WorkflowExpression.Validate(__workflow_bodycontactFirstName, nameof(bodycontactFirstName), required: false);
            var __workflow_bodycontactLastName = bodycontactLastName == null ? null : WorkflowExpression.Compile(bodycontactLastName);
            WorkflowExpression.Validate(__workflow_bodycontactLastName, nameof(bodycontactLastName), required: false);
            var __workflow_bodycontactFullName = bodycontactFullName == null ? null : WorkflowExpression.Compile(bodycontactFullName);
            WorkflowExpression.Validate(__workflow_bodycontactFullName, nameof(bodycontactFullName), required: false);
            var __workflow_bodycontactTitle = bodycontactTitle == null ? null : WorkflowExpression.Compile(bodycontactTitle);
            WorkflowExpression.Validate(__workflow_bodycontactTitle, nameof(bodycontactTitle), required: false);
            var __workflow_bodycontactBackground = bodycontactBackground == null ? null : WorkflowExpression.Compile(bodycontactBackground);
            WorkflowExpression.Validate(__workflow_bodycontactBackground, nameof(bodycontactBackground), required: false);
            var __workflow_bodycontactPrimaryContact = bodycontactPrimaryContact == null ? null : WorkflowExpression.Compile(bodycontactPrimaryContact);
            WorkflowExpression.Validate(__workflow_bodycontactPrimaryContact, nameof(bodycontactPrimaryContact), required: false);
            var __workflow_bodycontactTypeName = bodycontactTypeName == null ? null : WorkflowExpression.Compile(bodycontactTypeName);
            WorkflowExpression.Validate(__workflow_bodycontactTypeName, nameof(bodycontactTypeName), required: false);
            var __workflow_bodycontactEmailAddressWork = bodycontactEmailAddressWork == null ? null : WorkflowExpression.Compile(bodycontactEmailAddressWork);
            WorkflowExpression.Validate(__workflow_bodycontactEmailAddressWork, nameof(bodycontactEmailAddressWork), required: false);
            var __workflow_bodycontactEmailAddressPersonal = bodycontactEmailAddressPersonal == null ? null : WorkflowExpression.Compile(bodycontactEmailAddressPersonal);
            WorkflowExpression.Validate(__workflow_bodycontactEmailAddressPersonal, nameof(bodycontactEmailAddressPersonal), required: false);
            var __workflow_bodycontactEmailAddressAlternate = bodycontactEmailAddressAlternate == null ? null : WorkflowExpression.Compile(bodycontactEmailAddressAlternate);
            WorkflowExpression.Validate(__workflow_bodycontactEmailAddressAlternate, nameof(bodycontactEmailAddressAlternate), required: false);
            var __workflow_bodycontactEmailAddressOther = bodycontactEmailAddressOther == null ? null : WorkflowExpression.Compile(bodycontactEmailAddressOther);
            WorkflowExpression.Validate(__workflow_bodycontactEmailAddressOther, nameof(bodycontactEmailAddressOther), required: false);
            var __workflow_bodycontactPhoneNumberWork = bodycontactPhoneNumberWork == null ? null : WorkflowExpression.Compile(bodycontactPhoneNumberWork);
            WorkflowExpression.Validate(__workflow_bodycontactPhoneNumberWork, nameof(bodycontactPhoneNumberWork), required: false);
            var __workflow_bodycontactPhoneNumberHome = bodycontactPhoneNumberHome == null ? null : WorkflowExpression.Compile(bodycontactPhoneNumberHome);
            WorkflowExpression.Validate(__workflow_bodycontactPhoneNumberHome, nameof(bodycontactPhoneNumberHome), required: false);
            var __workflow_bodycontactPhoneNumberMobile = bodycontactPhoneNumberMobile == null ? null : WorkflowExpression.Compile(bodycontactPhoneNumberMobile);
            WorkflowExpression.Validate(__workflow_bodycontactPhoneNumberMobile, nameof(bodycontactPhoneNumberMobile), required: false);
            var __workflow_bodycontactPhoneNumberAlternate = bodycontactPhoneNumberAlternate == null ? null : WorkflowExpression.Compile(bodycontactPhoneNumberAlternate);
            WorkflowExpression.Validate(__workflow_bodycontactPhoneNumberAlternate, nameof(bodycontactPhoneNumberAlternate), required: false);
            var __workflow_bodycontactFax = bodycontactFax == null ? null : WorkflowExpression.Compile(bodycontactFax);
            WorkflowExpression.Validate(__workflow_bodycontactFax, nameof(bodycontactFax), required: false);
            var __workflow_bodycontactBusinessStreet = bodycontactBusinessStreet == null ? null : WorkflowExpression.Compile(bodycontactBusinessStreet);
            WorkflowExpression.Validate(__workflow_bodycontactBusinessStreet, nameof(bodycontactBusinessStreet), required: false);
            var __workflow_bodycontactBusinessCity = bodycontactBusinessCity == null ? null : WorkflowExpression.Compile(bodycontactBusinessCity);
            WorkflowExpression.Validate(__workflow_bodycontactBusinessCity, nameof(bodycontactBusinessCity), required: false);
            var __workflow_bodycontactBusinessState = bodycontactBusinessState == null ? null : WorkflowExpression.Compile(bodycontactBusinessState);
            WorkflowExpression.Validate(__workflow_bodycontactBusinessState, nameof(bodycontactBusinessState), required: false);
            var __workflow_bodycontactBusinessZip = bodycontactBusinessZip == null ? null : WorkflowExpression.Compile(bodycontactBusinessZip);
            WorkflowExpression.Validate(__workflow_bodycontactBusinessZip, nameof(bodycontactBusinessZip), required: false);
            var __workflow_bodycontactBusinessCountry = bodycontactBusinessCountry == null ? null : WorkflowExpression.Compile(bodycontactBusinessCountry);
            WorkflowExpression.Validate(__workflow_bodycontactBusinessCountry, nameof(bodycontactBusinessCountry), required: false);
            var __workflow_bodycontactHomeStreet = bodycontactHomeStreet == null ? null : WorkflowExpression.Compile(bodycontactHomeStreet);
            WorkflowExpression.Validate(__workflow_bodycontactHomeStreet, nameof(bodycontactHomeStreet), required: false);
            var __workflow_bodycontactHomeCity = bodycontactHomeCity == null ? null : WorkflowExpression.Compile(bodycontactHomeCity);
            WorkflowExpression.Validate(__workflow_bodycontactHomeCity, nameof(bodycontactHomeCity), required: false);
            var __workflow_bodycontactHomeState = bodycontactHomeState == null ? null : WorkflowExpression.Compile(bodycontactHomeState);
            WorkflowExpression.Validate(__workflow_bodycontactHomeState, nameof(bodycontactHomeState), required: false);
            var __workflow_bodycontactHomeZip = bodycontactHomeZip == null ? null : WorkflowExpression.Compile(bodycontactHomeZip);
            WorkflowExpression.Validate(__workflow_bodycontactHomeZip, nameof(bodycontactHomeZip), required: false);
            var __workflow_bodycontactHomeCountry = bodycontactHomeCountry == null ? null : WorkflowExpression.Compile(bodycontactHomeCountry);
            WorkflowExpression.Validate(__workflow_bodycontactHomeCountry, nameof(bodycontactHomeCountry), required: false);
            var __workflow_bodycontactNotes = bodycontactNotes == null ? null : WorkflowExpression.Compile(bodycontactNotes);
            WorkflowExpression.Validate(__workflow_bodycontactNotes, nameof(bodycontactNotes), required: false);
            var __workflow_bodycontactGroups = bodycontactGroups == null ? null : WorkflowExpression.Compile(bodycontactGroups);
            WorkflowExpression.Validate(__workflow_bodycontactGroups, nameof(bodycontactGroups), required: false);
            var __workflow_bodycontactProductInterests = bodycontactProductInterests == null ? null : WorkflowExpression.Compile(bodycontactProductInterests);
            WorkflowExpression.Validate(__workflow_bodycontactProductInterests, nameof(bodycontactProductInterests), required: false);
            var __workflow_bodyopportunityPrincipalName = bodyopportunityPrincipalName == null ? null : WorkflowExpression.Compile(bodyopportunityPrincipalName);
            WorkflowExpression.Validate(__workflow_bodyopportunityPrincipalName, nameof(bodyopportunityPrincipalName), required: false);
            var __workflow_bodyopportunityProgram = bodyopportunityProgram == null ? null : WorkflowExpression.Compile(bodyopportunityProgram);
            WorkflowExpression.Validate(__workflow_bodyopportunityProgram, nameof(bodyopportunityProgram), required: false);
            var __workflow_bodyopportunityCustomerName = bodyopportunityCustomerName == null ? null : WorkflowExpression.Compile(bodyopportunityCustomerName);
            WorkflowExpression.Validate(__workflow_bodyopportunityCustomerName, nameof(bodyopportunityCustomerName), required: false);
            var __workflow_bodyopportunityDistributorName = bodyopportunityDistributorName == null ? null : WorkflowExpression.Compile(bodyopportunityDistributorName);
            WorkflowExpression.Validate(__workflow_bodyopportunityDistributorName, nameof(bodyopportunityDistributorName), required: false);
            var __workflow_bodyopportunityCustomerContact = bodyopportunityCustomerContact == null ? null : WorkflowExpression.Compile(bodyopportunityCustomerContact);
            WorkflowExpression.Validate(__workflow_bodyopportunityCustomerContact, nameof(bodyopportunityCustomerContact), required: false);
            var __workflow_bodyopportunityPrincipalContact = bodyopportunityPrincipalContact == null ? null : WorkflowExpression.Compile(bodyopportunityPrincipalContact);
            WorkflowExpression.Validate(__workflow_bodyopportunityPrincipalContact, nameof(bodyopportunityPrincipalContact), required: false);
            var __workflow_bodyopportunityDistributorContact = bodyopportunityDistributorContact == null ? null : WorkflowExpression.Compile(bodyopportunityDistributorContact);
            WorkflowExpression.Validate(__workflow_bodyopportunityDistributorContact, nameof(bodyopportunityDistributorContact), required: false);
            var __workflow_bodyopportunityNextStep = bodyopportunityNextStep == null ? null : WorkflowExpression.Compile(bodyopportunityNextStep);
            WorkflowExpression.Validate(__workflow_bodyopportunityNextStep, nameof(bodyopportunityNextStep), required: false);
            var __workflow_bodyopportunityActivity = bodyopportunityActivity == null ? null : WorkflowExpression.Compile(bodyopportunityActivity);
            WorkflowExpression.Validate(__workflow_bodyopportunityActivity, nameof(bodyopportunityActivity), required: false);
            var __workflow_bodyopportunityStatus = bodyopportunityStatus == null ? null : WorkflowExpression.Compile(bodyopportunityStatus);
            WorkflowExpression.Validate(__workflow_bodyopportunityStatus, nameof(bodyopportunityStatus), required: false);
            var __workflow_bodyopportunityFollowUp = bodyopportunityFollowUp == null ? null : WorkflowExpression.Compile(bodyopportunityFollowUp);
            WorkflowExpression.Validate(__workflow_bodyopportunityFollowUp, nameof(bodyopportunityFollowUp), required: false);
            var __workflow_bodyopportunityPriority = bodyopportunityPriority == null ? null : WorkflowExpression.Compile(bodyopportunityPriority);
            WorkflowExpression.Validate(__workflow_bodyopportunityPriority, nameof(bodyopportunityPriority), required: false);
            var __workflow_bodyopportunityPotential = bodyopportunityPotential == null ? null : WorkflowExpression.Compile(bodyopportunityPotential);
            WorkflowExpression.Validate(__workflow_bodyopportunityPotential, nameof(bodyopportunityPotential), required: false);
            var __workflow_bodyopportunityEau = bodyopportunityEau == null ? null : WorkflowExpression.Compile(bodyopportunityEau);
            WorkflowExpression.Validate(__workflow_bodyopportunityEau, nameof(bodyopportunityEau), required: false);
            var __workflow_bodyopportunityValue = bodyopportunityValue == null ? null : WorkflowExpression.Compile(bodyopportunityValue);
            WorkflowExpression.Validate(__workflow_bodyopportunityValue, nameof(bodyopportunityValue), required: false);
            var __workflow_bodyopportunityPrototypeDate = bodyopportunityPrototypeDate == null ? null : WorkflowExpression.Compile(bodyopportunityPrototypeDate);
            WorkflowExpression.Validate(__workflow_bodyopportunityPrototypeDate, nameof(bodyopportunityPrototypeDate), required: false);
            var __workflow_bodyopportunityProductionDate = bodyopportunityProductionDate == null ? null : WorkflowExpression.Compile(bodyopportunityProductionDate);
            WorkflowExpression.Validate(__workflow_bodyopportunityProductionDate, nameof(bodyopportunityProductionDate), required: false);
            var __workflow_bodyopportunityCloseStatus = bodyopportunityCloseStatus == null ? null : WorkflowExpression.Compile(bodyopportunityCloseStatus);
            WorkflowExpression.Validate(__workflow_bodyopportunityCloseStatus, nameof(bodyopportunityCloseStatus), required: false);
            var __workflow_bodyopportunityCloseDate = bodyopportunityCloseDate == null ? null : WorkflowExpression.Compile(bodyopportunityCloseDate);
            WorkflowExpression.Validate(__workflow_bodyopportunityCloseDate, nameof(bodyopportunityCloseDate), required: false);
            var __workflow_bodyopportunityDescription = bodyopportunityDescription == null ? null : WorkflowExpression.Compile(bodyopportunityDescription);
            WorkflowExpression.Validate(__workflow_bodyopportunityDescription, nameof(bodyopportunityDescription), required: false);
            var __workflow_bodyopportunityCompetitor1 = bodyopportunityCompetitor1 == null ? null : WorkflowExpression.Compile(bodyopportunityCompetitor1);
            WorkflowExpression.Validate(__workflow_bodyopportunityCompetitor1, nameof(bodyopportunityCompetitor1), required: false);
            var __workflow_bodyopportunityCompetitor2 = bodyopportunityCompetitor2 == null ? null : WorkflowExpression.Compile(bodyopportunityCompetitor2);
            WorkflowExpression.Validate(__workflow_bodyopportunityCompetitor2, nameof(bodyopportunityCompetitor2), required: false);
            var __workflow_bodyopportunityReportingComments = bodyopportunityReportingComments == null ? null : WorkflowExpression.Compile(bodyopportunityReportingComments);
            WorkflowExpression.Validate(__workflow_bodyopportunityReportingComments, nameof(bodyopportunityReportingComments), required: false);
            var __workflow_bodyopportunityLeadSourceName = bodyopportunityLeadSourceName == null ? null : WorkflowExpression.Compile(bodyopportunityLeadSourceName);
            WorkflowExpression.Validate(__workflow_bodyopportunityLeadSourceName, nameof(bodyopportunityLeadSourceName), required: false);
            var __workflow_bodydomain = bodydomain == null ? null : WorkflowExpression.Compile(bodydomain);
            WorkflowExpression.Validate(__workflow_bodydomain, nameof(bodydomain), required: false);
            var __workflow_bodyusername = bodyusername == null ? null : WorkflowExpression.Compile(bodyusername);
            WorkflowExpression.Validate(__workflow_bodyusername, nameof(bodyusername), required: false);
            var __workflow_bodypassword = bodypassword == null ? null : WorkflowExpression.Compile(bodypassword);
            WorkflowExpression.Validate(__workflow_bodypassword, nameof(bodypassword), required: false);
            return new DeferredBodyAction<UploadLeadsV3Response>(() =>
            {
                var apiCallPath = "/contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyType != null)
                {
                    body["company-type"] = ExpressionConverter.ConvertO(__workflow_bodycompanyType);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyClass != null)
                {
                    body["company-class"] = ExpressionConverter.ConvertO(__workflow_bodycompanyClass);
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

                if (__workflow_bodycompanySalesTeam != null)
                {
                    body["company-sales-team"] = ExpressionConverter.ConvertO(__workflow_bodycompanySalesTeam);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyIndustries != null)
                {
                    body["company-industries"] = ExpressionConverter.ConvertO(__workflow_bodycompanyIndustries);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyProductPotentials != null)
                {
                    body["company-product-potentials"] = ExpressionConverter.ConvertO(__workflow_bodycompanyProductPotentials);
                    bodypropCount++;
                }

                if (__workflow_bodycontactFirstName != null)
                {
                    body["contact-first-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactFirstName);
                    bodypropCount++;
                }

                if (__workflow_bodycontactLastName != null)
                {
                    body["contact-last-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactLastName);
                    bodypropCount++;
                }

                if (__workflow_bodycontactFullName != null)
                {
                    body["contact-full-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactFullName);
                    bodypropCount++;
                }

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

                if (__workflow_bodycontactPrimaryContact != null)
                {
                    body["contact-primary-contact"] = ExpressionConverter.ConvertO(__workflow_bodycontactPrimaryContact);
                    bodypropCount++;
                }

                if (__workflow_bodycontactTypeName != null)
                {
                    body["contact-type-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactTypeName);
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

                if (__workflow_bodycontactNotes != null)
                {
                    body["contact-notes"] = ExpressionConverter.ConvertO(__workflow_bodycontactNotes);
                    bodypropCount++;
                }

                if (__workflow_bodycontactGroups != null)
                {
                    body["contact-groups"] = ExpressionConverter.ConvertO(__workflow_bodycontactGroups);
                    bodypropCount++;
                }

                if (__workflow_bodycontactProductInterests != null)
                {
                    body["contact-product-interests"] = ExpressionConverter.ConvertO(__workflow_bodycontactProductInterests);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityPrincipalName != null)
                {
                    body["opportunity-principal-name"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityPrincipalName);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityProgram != null)
                {
                    body["opportunity-program"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityProgram);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityCustomerName != null)
                {
                    body["opportunity-customer-name"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityCustomerName);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityDistributorName != null)
                {
                    body["opportunity-distributor-name"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityDistributorName);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityCustomerContact != null)
                {
                    body["opportunity-customer-contact"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityCustomerContact);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityPrincipalContact != null)
                {
                    body["opportunity-principal-contact"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityPrincipalContact);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityDistributorContact != null)
                {
                    body["opportunity-distributor-contact"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityDistributorContact);
                    bodypropCount++;
                }

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

                if (__workflow_bodyopportunityFollowUp != null)
                {
                    body["opportunity-follow-up"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityFollowUp);
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

                if (__workflow_bodyopportunityDescription != null)
                {
                    body["opportunity-description"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityDescription);
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

                if (__workflow_bodyopportunityReportingComments != null)
                {
                    body["opportunity-reporting-comments"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityReportingComments);
                    bodypropCount++;
                }

                if (__workflow_bodyopportunityLeadSourceName != null)
                {
                    body["opportunity-lead-source-name"] = ExpressionConverter.ConvertO(__workflow_bodyopportunityLeadSourceName);
                    bodypropCount++;
                }

                if (__workflow_bodydomain != null)
                {
                    body["domain"] = ExpressionConverter.ConvertO(__workflow_bodydomain);
                    bodypropCount++;
                }

                if (__workflow_bodyusername != null)
                {
                    body["username"] = ExpressionConverter.ConvertO(__workflow_bodyusername);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
