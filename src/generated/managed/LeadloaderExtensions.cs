//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Leadloader
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LeadloaderActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leadloader")]
        [WorkflowExpressionFactory(nameof(__BuildUploadLeads))]
        public IBodyWorkflowAction<UploadLeadsV3Response> UploadLeads([WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodycompanyType = null, [WorkflowExpression] Func<string> bodycompanyClass = null, [WorkflowExpression] Func<string> bodycompanyCategory = null, [WorkflowExpression] Func<string> bodycompanyPhone1 = null, [WorkflowExpression] Func<string> bodycompanyPhone2 = null, [WorkflowExpression] Func<string> bodycompanyFax = null, [WorkflowExpression] Func<string> bodycompanyRegion = null, [WorkflowExpression] Func<string> bodycompanyStreet = null, [WorkflowExpression] Func<string> bodycompanyCity = null, [WorkflowExpression] Func<string> bodycompanyState = null, [WorkflowExpression] Func<string> bodycompanyZip = null, [WorkflowExpression] Func<string> bodycompanyCountry = null, [WorkflowExpression] Func<string> bodycompanyPoBox = null, [WorkflowExpression] Func<string> bodycompanyWebsite = null, [WorkflowExpression] Func<string> bodycompanyComments = null, [WorkflowExpression] Func<string> bodycompanySalesTeam = null, [WorkflowExpression] Func<string> bodycompanyIndustries = null, [WorkflowExpression] Func<string> bodycompanyProductPotentials = null, [WorkflowExpression] Func<string> bodycontactFirstName = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<string> bodycontactFullName = null, [WorkflowExpression] Func<string> bodycontactTitle = null, [WorkflowExpression] Func<string> bodycontactBackground = null, [WorkflowExpression] Func<bool> bodycontactPrimaryContact = null, [WorkflowExpression] Func<string> bodycontactTypeName = null, [WorkflowExpression] Func<string> bodycontactEmailAddressWork = null, [WorkflowExpression] Func<string> bodycontactEmailAddressPersonal = null, [WorkflowExpression] Func<string> bodycontactEmailAddressAlternate = null, [WorkflowExpression] Func<string> bodycontactEmailAddressOther = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberWork = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberHome = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberMobile = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberAlternate = null, [WorkflowExpression] Func<string> bodycontactFax = null, [WorkflowExpression] Func<string> bodycontactBusinessStreet = null, [WorkflowExpression] Func<string> bodycontactBusinessCity = null, [WorkflowExpression] Func<string> bodycontactBusinessState = null, [WorkflowExpression] Func<string> bodycontactBusinessZip = null, [WorkflowExpression] Func<string> bodycontactBusinessCountry = null, [WorkflowExpression] Func<string> bodycontactHomeStreet = null, [WorkflowExpression] Func<string> bodycontactHomeCity = null, [WorkflowExpression] Func<string> bodycontactHomeState = null, [WorkflowExpression] Func<string> bodycontactHomeZip = null, [WorkflowExpression] Func<string> bodycontactHomeCountry = null, [WorkflowExpression] Func<string> bodycontactNotes = null, [WorkflowExpression] Func<string> bodycontactGroups = null, [WorkflowExpression] Func<string> bodycontactProductInterests = null, [WorkflowExpression] Func<string> bodyopportunityPrincipalName = null, [WorkflowExpression] Func<string> bodyopportunityProgram = null, [WorkflowExpression] Func<string> bodyopportunityCustomerName = null, [WorkflowExpression] Func<string> bodyopportunityDistributorName = null, [WorkflowExpression] Func<string> bodyopportunityCustomerContact = null, [WorkflowExpression] Func<string> bodyopportunityPrincipalContact = null, [WorkflowExpression] Func<string> bodyopportunityDistributorContact = null, [WorkflowExpression] Func<string> bodyopportunityNextStep = null, [WorkflowExpression] Func<string> bodyopportunityActivity = null, [WorkflowExpression] Func<string> bodyopportunityStatus = null, [WorkflowExpression] Func<string> bodyopportunityFollowUp = null, [WorkflowExpression] Func<int> bodyopportunityPriority = null, [WorkflowExpression] Func<int> bodyopportunityPotential = null, [WorkflowExpression] Func<int> bodyopportunityEau = null, [WorkflowExpression] Func<int> bodyopportunityValue = null, [WorkflowExpression] Func<string> bodyopportunityPrototypeDate = null, [WorkflowExpression] Func<string> bodyopportunityProductionDate = null, [WorkflowExpression] Func<int> bodyopportunityCloseStatus = null, [WorkflowExpression] Func<string> bodyopportunityCloseDate = null, [WorkflowExpression] Func<string> bodyopportunityDescription = null, [WorkflowExpression] Func<string> bodyopportunityCompetitor1 = null, [WorkflowExpression] Func<string> bodyopportunityCompetitor2 = null, [WorkflowExpression] Func<string> bodyopportunityReportingComments = null, [WorkflowExpression] Func<string> bodyopportunityLeadSourceName = null, [WorkflowExpression] Func<string> bodydomain = null, [WorkflowExpression] Func<string> bodyusername = null, [WorkflowExpression] Func<string> bodypassword = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "leadloader")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadLeadsV3Response> __BuildUploadLeads(WorkflowExpression<string> bodycompany = null, WorkflowExpression<string> bodycompanyType = null, WorkflowExpression<string> bodycompanyClass = null, WorkflowExpression<string> bodycompanyCategory = null, WorkflowExpression<string> bodycompanyPhone1 = null, WorkflowExpression<string> bodycompanyPhone2 = null, WorkflowExpression<string> bodycompanyFax = null, WorkflowExpression<string> bodycompanyRegion = null, WorkflowExpression<string> bodycompanyStreet = null, WorkflowExpression<string> bodycompanyCity = null, WorkflowExpression<string> bodycompanyState = null, WorkflowExpression<string> bodycompanyZip = null, WorkflowExpression<string> bodycompanyCountry = null, WorkflowExpression<string> bodycompanyPoBox = null, WorkflowExpression<string> bodycompanyWebsite = null, WorkflowExpression<string> bodycompanyComments = null, WorkflowExpression<string> bodycompanySalesTeam = null, WorkflowExpression<string> bodycompanyIndustries = null, WorkflowExpression<string> bodycompanyProductPotentials = null, WorkflowExpression<string> bodycontactFirstName = null, WorkflowExpression<string> bodycontactLastName = null, WorkflowExpression<string> bodycontactFullName = null, WorkflowExpression<string> bodycontactTitle = null, WorkflowExpression<string> bodycontactBackground = null, WorkflowExpression<bool> bodycontactPrimaryContact = null, WorkflowExpression<string> bodycontactTypeName = null, WorkflowExpression<string> bodycontactEmailAddressWork = null, WorkflowExpression<string> bodycontactEmailAddressPersonal = null, WorkflowExpression<string> bodycontactEmailAddressAlternate = null, WorkflowExpression<string> bodycontactEmailAddressOther = null, WorkflowExpression<string> bodycontactPhoneNumberWork = null, WorkflowExpression<string> bodycontactPhoneNumberHome = null, WorkflowExpression<string> bodycontactPhoneNumberMobile = null, WorkflowExpression<string> bodycontactPhoneNumberAlternate = null, WorkflowExpression<string> bodycontactFax = null, WorkflowExpression<string> bodycontactBusinessStreet = null, WorkflowExpression<string> bodycontactBusinessCity = null, WorkflowExpression<string> bodycontactBusinessState = null, WorkflowExpression<string> bodycontactBusinessZip = null, WorkflowExpression<string> bodycontactBusinessCountry = null, WorkflowExpression<string> bodycontactHomeStreet = null, WorkflowExpression<string> bodycontactHomeCity = null, WorkflowExpression<string> bodycontactHomeState = null, WorkflowExpression<string> bodycontactHomeZip = null, WorkflowExpression<string> bodycontactHomeCountry = null, WorkflowExpression<string> bodycontactNotes = null, WorkflowExpression<string> bodycontactGroups = null, WorkflowExpression<string> bodycontactProductInterests = null, WorkflowExpression<string> bodyopportunityPrincipalName = null, WorkflowExpression<string> bodyopportunityProgram = null, WorkflowExpression<string> bodyopportunityCustomerName = null, WorkflowExpression<string> bodyopportunityDistributorName = null, WorkflowExpression<string> bodyopportunityCustomerContact = null, WorkflowExpression<string> bodyopportunityPrincipalContact = null, WorkflowExpression<string> bodyopportunityDistributorContact = null, WorkflowExpression<string> bodyopportunityNextStep = null, WorkflowExpression<string> bodyopportunityActivity = null, WorkflowExpression<string> bodyopportunityStatus = null, WorkflowExpression<string> bodyopportunityFollowUp = null, WorkflowExpression<int> bodyopportunityPriority = null, WorkflowExpression<int> bodyopportunityPotential = null, WorkflowExpression<int> bodyopportunityEau = null, WorkflowExpression<int> bodyopportunityValue = null, WorkflowExpression<string> bodyopportunityPrototypeDate = null, WorkflowExpression<string> bodyopportunityProductionDate = null, WorkflowExpression<int> bodyopportunityCloseStatus = null, WorkflowExpression<string> bodyopportunityCloseDate = null, WorkflowExpression<string> bodyopportunityDescription = null, WorkflowExpression<string> bodyopportunityCompetitor1 = null, WorkflowExpression<string> bodyopportunityCompetitor2 = null, WorkflowExpression<string> bodyopportunityReportingComments = null, WorkflowExpression<string> bodyopportunityLeadSourceName = null, WorkflowExpression<string> bodydomain = null, WorkflowExpression<string> bodyusername = null, WorkflowExpression<string> bodypassword = null)
        {
            WorkflowExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowExpression.Validate(bodycompanyType, nameof(bodycompanyType), required: false);
            WorkflowExpression.Validate(bodycompanyClass, nameof(bodycompanyClass), required: false);
            WorkflowExpression.Validate(bodycompanyCategory, nameof(bodycompanyCategory), required: false);
            WorkflowExpression.Validate(bodycompanyPhone1, nameof(bodycompanyPhone1), required: false);
            WorkflowExpression.Validate(bodycompanyPhone2, nameof(bodycompanyPhone2), required: false);
            WorkflowExpression.Validate(bodycompanyFax, nameof(bodycompanyFax), required: false);
            WorkflowExpression.Validate(bodycompanyRegion, nameof(bodycompanyRegion), required: false);
            WorkflowExpression.Validate(bodycompanyStreet, nameof(bodycompanyStreet), required: false);
            WorkflowExpression.Validate(bodycompanyCity, nameof(bodycompanyCity), required: false);
            WorkflowExpression.Validate(bodycompanyState, nameof(bodycompanyState), required: false);
            WorkflowExpression.Validate(bodycompanyZip, nameof(bodycompanyZip), required: false);
            WorkflowExpression.Validate(bodycompanyCountry, nameof(bodycompanyCountry), required: false);
            WorkflowExpression.Validate(bodycompanyPoBox, nameof(bodycompanyPoBox), required: false);
            WorkflowExpression.Validate(bodycompanyWebsite, nameof(bodycompanyWebsite), required: false);
            WorkflowExpression.Validate(bodycompanyComments, nameof(bodycompanyComments), required: false);
            WorkflowExpression.Validate(bodycompanySalesTeam, nameof(bodycompanySalesTeam), required: false);
            WorkflowExpression.Validate(bodycompanyIndustries, nameof(bodycompanyIndustries), required: false);
            WorkflowExpression.Validate(bodycompanyProductPotentials, nameof(bodycompanyProductPotentials), required: false);
            WorkflowExpression.Validate(bodycontactFirstName, nameof(bodycontactFirstName), required: false);
            WorkflowExpression.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            WorkflowExpression.Validate(bodycontactFullName, nameof(bodycontactFullName), required: false);
            WorkflowExpression.Validate(bodycontactTitle, nameof(bodycontactTitle), required: false);
            WorkflowExpression.Validate(bodycontactBackground, nameof(bodycontactBackground), required: false);
            WorkflowExpression.Validate(bodycontactPrimaryContact, nameof(bodycontactPrimaryContact), required: false);
            WorkflowExpression.Validate(bodycontactTypeName, nameof(bodycontactTypeName), required: false);
            WorkflowExpression.Validate(bodycontactEmailAddressWork, nameof(bodycontactEmailAddressWork), required: false);
            WorkflowExpression.Validate(bodycontactEmailAddressPersonal, nameof(bodycontactEmailAddressPersonal), required: false);
            WorkflowExpression.Validate(bodycontactEmailAddressAlternate, nameof(bodycontactEmailAddressAlternate), required: false);
            WorkflowExpression.Validate(bodycontactEmailAddressOther, nameof(bodycontactEmailAddressOther), required: false);
            WorkflowExpression.Validate(bodycontactPhoneNumberWork, nameof(bodycontactPhoneNumberWork), required: false);
            WorkflowExpression.Validate(bodycontactPhoneNumberHome, nameof(bodycontactPhoneNumberHome), required: false);
            WorkflowExpression.Validate(bodycontactPhoneNumberMobile, nameof(bodycontactPhoneNumberMobile), required: false);
            WorkflowExpression.Validate(bodycontactPhoneNumberAlternate, nameof(bodycontactPhoneNumberAlternate), required: false);
            WorkflowExpression.Validate(bodycontactFax, nameof(bodycontactFax), required: false);
            WorkflowExpression.Validate(bodycontactBusinessStreet, nameof(bodycontactBusinessStreet), required: false);
            WorkflowExpression.Validate(bodycontactBusinessCity, nameof(bodycontactBusinessCity), required: false);
            WorkflowExpression.Validate(bodycontactBusinessState, nameof(bodycontactBusinessState), required: false);
            WorkflowExpression.Validate(bodycontactBusinessZip, nameof(bodycontactBusinessZip), required: false);
            WorkflowExpression.Validate(bodycontactBusinessCountry, nameof(bodycontactBusinessCountry), required: false);
            WorkflowExpression.Validate(bodycontactHomeStreet, nameof(bodycontactHomeStreet), required: false);
            WorkflowExpression.Validate(bodycontactHomeCity, nameof(bodycontactHomeCity), required: false);
            WorkflowExpression.Validate(bodycontactHomeState, nameof(bodycontactHomeState), required: false);
            WorkflowExpression.Validate(bodycontactHomeZip, nameof(bodycontactHomeZip), required: false);
            WorkflowExpression.Validate(bodycontactHomeCountry, nameof(bodycontactHomeCountry), required: false);
            WorkflowExpression.Validate(bodycontactNotes, nameof(bodycontactNotes), required: false);
            WorkflowExpression.Validate(bodycontactGroups, nameof(bodycontactGroups), required: false);
            WorkflowExpression.Validate(bodycontactProductInterests, nameof(bodycontactProductInterests), required: false);
            WorkflowExpression.Validate(bodyopportunityPrincipalName, nameof(bodyopportunityPrincipalName), required: false);
            WorkflowExpression.Validate(bodyopportunityProgram, nameof(bodyopportunityProgram), required: false);
            WorkflowExpression.Validate(bodyopportunityCustomerName, nameof(bodyopportunityCustomerName), required: false);
            WorkflowExpression.Validate(bodyopportunityDistributorName, nameof(bodyopportunityDistributorName), required: false);
            WorkflowExpression.Validate(bodyopportunityCustomerContact, nameof(bodyopportunityCustomerContact), required: false);
            WorkflowExpression.Validate(bodyopportunityPrincipalContact, nameof(bodyopportunityPrincipalContact), required: false);
            WorkflowExpression.Validate(bodyopportunityDistributorContact, nameof(bodyopportunityDistributorContact), required: false);
            WorkflowExpression.Validate(bodyopportunityNextStep, nameof(bodyopportunityNextStep), required: false);
            WorkflowExpression.Validate(bodyopportunityActivity, nameof(bodyopportunityActivity), required: false);
            WorkflowExpression.Validate(bodyopportunityStatus, nameof(bodyopportunityStatus), required: false);
            WorkflowExpression.Validate(bodyopportunityFollowUp, nameof(bodyopportunityFollowUp), required: false);
            WorkflowExpression.Validate(bodyopportunityPriority, nameof(bodyopportunityPriority), required: false);
            WorkflowExpression.Validate(bodyopportunityPotential, nameof(bodyopportunityPotential), required: false);
            WorkflowExpression.Validate(bodyopportunityEau, nameof(bodyopportunityEau), required: false);
            WorkflowExpression.Validate(bodyopportunityValue, nameof(bodyopportunityValue), required: false);
            WorkflowExpression.Validate(bodyopportunityPrototypeDate, nameof(bodyopportunityPrototypeDate), required: false);
            WorkflowExpression.Validate(bodyopportunityProductionDate, nameof(bodyopportunityProductionDate), required: false);
            WorkflowExpression.Validate(bodyopportunityCloseStatus, nameof(bodyopportunityCloseStatus), required: false);
            WorkflowExpression.Validate(bodyopportunityCloseDate, nameof(bodyopportunityCloseDate), required: false);
            WorkflowExpression.Validate(bodyopportunityDescription, nameof(bodyopportunityDescription), required: false);
            WorkflowExpression.Validate(bodyopportunityCompetitor1, nameof(bodyopportunityCompetitor1), required: false);
            WorkflowExpression.Validate(bodyopportunityCompetitor2, nameof(bodyopportunityCompetitor2), required: false);
            WorkflowExpression.Validate(bodyopportunityReportingComments, nameof(bodyopportunityReportingComments), required: false);
            WorkflowExpression.Validate(bodyopportunityLeadSourceName, nameof(bodyopportunityLeadSourceName), required: false);
            WorkflowExpression.Validate(bodydomain, nameof(bodydomain), required: false);
            WorkflowExpression.Validate(bodyusername, nameof(bodyusername), required: false);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            return new DeferredBodyAction<UploadLeadsV3Response>(() =>
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