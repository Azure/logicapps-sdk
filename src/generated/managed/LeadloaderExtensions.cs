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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadLeadsV3Response> __BuildUploadLeads(WorkflowValue<string> bodycompany = null, WorkflowValue<string> bodycompanyType = null, WorkflowValue<string> bodycompanyClass = null, WorkflowValue<string> bodycompanyCategory = null, WorkflowValue<string> bodycompanyPhone1 = null, WorkflowValue<string> bodycompanyPhone2 = null, WorkflowValue<string> bodycompanyFax = null, WorkflowValue<string> bodycompanyRegion = null, WorkflowValue<string> bodycompanyStreet = null, WorkflowValue<string> bodycompanyCity = null, WorkflowValue<string> bodycompanyState = null, WorkflowValue<string> bodycompanyZip = null, WorkflowValue<string> bodycompanyCountry = null, WorkflowValue<string> bodycompanyPoBox = null, WorkflowValue<string> bodycompanyWebsite = null, WorkflowValue<string> bodycompanyComments = null, WorkflowValue<string> bodycompanySalesTeam = null, WorkflowValue<string> bodycompanyIndustries = null, WorkflowValue<string> bodycompanyProductPotentials = null, WorkflowValue<string> bodycontactFirstName = null, WorkflowValue<string> bodycontactLastName = null, WorkflowValue<string> bodycontactFullName = null, WorkflowValue<string> bodycontactTitle = null, WorkflowValue<string> bodycontactBackground = null, WorkflowValue<bool> bodycontactPrimaryContact = null, WorkflowValue<string> bodycontactTypeName = null, WorkflowValue<string> bodycontactEmailAddressWork = null, WorkflowValue<string> bodycontactEmailAddressPersonal = null, WorkflowValue<string> bodycontactEmailAddressAlternate = null, WorkflowValue<string> bodycontactEmailAddressOther = null, WorkflowValue<string> bodycontactPhoneNumberWork = null, WorkflowValue<string> bodycontactPhoneNumberHome = null, WorkflowValue<string> bodycontactPhoneNumberMobile = null, WorkflowValue<string> bodycontactPhoneNumberAlternate = null, WorkflowValue<string> bodycontactFax = null, WorkflowValue<string> bodycontactBusinessStreet = null, WorkflowValue<string> bodycontactBusinessCity = null, WorkflowValue<string> bodycontactBusinessState = null, WorkflowValue<string> bodycontactBusinessZip = null, WorkflowValue<string> bodycontactBusinessCountry = null, WorkflowValue<string> bodycontactHomeStreet = null, WorkflowValue<string> bodycontactHomeCity = null, WorkflowValue<string> bodycontactHomeState = null, WorkflowValue<string> bodycontactHomeZip = null, WorkflowValue<string> bodycontactHomeCountry = null, WorkflowValue<string> bodycontactNotes = null, WorkflowValue<string> bodycontactGroups = null, WorkflowValue<string> bodycontactProductInterests = null, WorkflowValue<string> bodyopportunityPrincipalName = null, WorkflowValue<string> bodyopportunityProgram = null, WorkflowValue<string> bodyopportunityCustomerName = null, WorkflowValue<string> bodyopportunityDistributorName = null, WorkflowValue<string> bodyopportunityCustomerContact = null, WorkflowValue<string> bodyopportunityPrincipalContact = null, WorkflowValue<string> bodyopportunityDistributorContact = null, WorkflowValue<string> bodyopportunityNextStep = null, WorkflowValue<string> bodyopportunityActivity = null, WorkflowValue<string> bodyopportunityStatus = null, WorkflowValue<string> bodyopportunityFollowUp = null, WorkflowValue<int> bodyopportunityPriority = null, WorkflowValue<int> bodyopportunityPotential = null, WorkflowValue<int> bodyopportunityEau = null, WorkflowValue<int> bodyopportunityValue = null, WorkflowValue<string> bodyopportunityPrototypeDate = null, WorkflowValue<string> bodyopportunityProductionDate = null, WorkflowValue<int> bodyopportunityCloseStatus = null, WorkflowValue<string> bodyopportunityCloseDate = null, WorkflowValue<string> bodyopportunityDescription = null, WorkflowValue<string> bodyopportunityCompetitor1 = null, WorkflowValue<string> bodyopportunityCompetitor2 = null, WorkflowValue<string> bodyopportunityReportingComments = null, WorkflowValue<string> bodyopportunityLeadSourceName = null, WorkflowValue<string> bodydomain = null, WorkflowValue<string> bodyusername = null, WorkflowValue<string> bodypassword = null)
        {
            WorkflowValue.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowValue.Validate(bodycompanyType, nameof(bodycompanyType), required: false);
            WorkflowValue.Validate(bodycompanyClass, nameof(bodycompanyClass), required: false);
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
            WorkflowValue.Validate(bodycompanySalesTeam, nameof(bodycompanySalesTeam), required: false);
            WorkflowValue.Validate(bodycompanyIndustries, nameof(bodycompanyIndustries), required: false);
            WorkflowValue.Validate(bodycompanyProductPotentials, nameof(bodycompanyProductPotentials), required: false);
            WorkflowValue.Validate(bodycontactFirstName, nameof(bodycontactFirstName), required: false);
            WorkflowValue.Validate(bodycontactLastName, nameof(bodycontactLastName), required: false);
            WorkflowValue.Validate(bodycontactFullName, nameof(bodycontactFullName), required: false);
            WorkflowValue.Validate(bodycontactTitle, nameof(bodycontactTitle), required: false);
            WorkflowValue.Validate(bodycontactBackground, nameof(bodycontactBackground), required: false);
            WorkflowValue.Validate(bodycontactPrimaryContact, nameof(bodycontactPrimaryContact), required: false);
            WorkflowValue.Validate(bodycontactTypeName, nameof(bodycontactTypeName), required: false);
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
            WorkflowValue.Validate(bodycontactNotes, nameof(bodycontactNotes), required: false);
            WorkflowValue.Validate(bodycontactGroups, nameof(bodycontactGroups), required: false);
            WorkflowValue.Validate(bodycontactProductInterests, nameof(bodycontactProductInterests), required: false);
            WorkflowValue.Validate(bodyopportunityPrincipalName, nameof(bodyopportunityPrincipalName), required: false);
            WorkflowValue.Validate(bodyopportunityProgram, nameof(bodyopportunityProgram), required: false);
            WorkflowValue.Validate(bodyopportunityCustomerName, nameof(bodyopportunityCustomerName), required: false);
            WorkflowValue.Validate(bodyopportunityDistributorName, nameof(bodyopportunityDistributorName), required: false);
            WorkflowValue.Validate(bodyopportunityCustomerContact, nameof(bodyopportunityCustomerContact), required: false);
            WorkflowValue.Validate(bodyopportunityPrincipalContact, nameof(bodyopportunityPrincipalContact), required: false);
            WorkflowValue.Validate(bodyopportunityDistributorContact, nameof(bodyopportunityDistributorContact), required: false);
            WorkflowValue.Validate(bodyopportunityNextStep, nameof(bodyopportunityNextStep), required: false);
            WorkflowValue.Validate(bodyopportunityActivity, nameof(bodyopportunityActivity), required: false);
            WorkflowValue.Validate(bodyopportunityStatus, nameof(bodyopportunityStatus), required: false);
            WorkflowValue.Validate(bodyopportunityFollowUp, nameof(bodyopportunityFollowUp), required: false);
            WorkflowValue.Validate(bodyopportunityPriority, nameof(bodyopportunityPriority), required: false);
            WorkflowValue.Validate(bodyopportunityPotential, nameof(bodyopportunityPotential), required: false);
            WorkflowValue.Validate(bodyopportunityEau, nameof(bodyopportunityEau), required: false);
            WorkflowValue.Validate(bodyopportunityValue, nameof(bodyopportunityValue), required: false);
            WorkflowValue.Validate(bodyopportunityPrototypeDate, nameof(bodyopportunityPrototypeDate), required: false);
            WorkflowValue.Validate(bodyopportunityProductionDate, nameof(bodyopportunityProductionDate), required: false);
            WorkflowValue.Validate(bodyopportunityCloseStatus, nameof(bodyopportunityCloseStatus), required: false);
            WorkflowValue.Validate(bodyopportunityCloseDate, nameof(bodyopportunityCloseDate), required: false);
            WorkflowValue.Validate(bodyopportunityDescription, nameof(bodyopportunityDescription), required: false);
            WorkflowValue.Validate(bodyopportunityCompetitor1, nameof(bodyopportunityCompetitor1), required: false);
            WorkflowValue.Validate(bodyopportunityCompetitor2, nameof(bodyopportunityCompetitor2), required: false);
            WorkflowValue.Validate(bodyopportunityReportingComments, nameof(bodyopportunityReportingComments), required: false);
            WorkflowValue.Validate(bodyopportunityLeadSourceName, nameof(bodyopportunityLeadSourceName), required: false);
            WorkflowValue.Validate(bodydomain, nameof(bodydomain), required: false);
            WorkflowValue.Validate(bodyusername, nameof(bodyusername), required: false);
            WorkflowValue.Validate(bodypassword, nameof(bodypassword), required: false);
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
