//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Requests
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RequestsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requests")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RepfabricCreateContact(Expression<Func<string>> bodydomainName, Expression<Func<string>> bodycontactFirstName, Expression<Func<string>> bodycontactLastName, Expression<Func<string>> bodycontactTitle = null, Expression<Func<string>> bodycontactBackground = null, Expression<Func<string>> bodycontactCompanyName = null, Expression<Func<bool>> bodycontactPrimary = null, Expression<Func<string>> bodycontactCompanyTypeName = null, Expression<Func<string>> bodycontactEmailAddressWork = null, Expression<Func<string>> bodycontactEmailAddressPersonal = null, Expression<Func<string>> bodycontactEmailAddressAlternate = null, Expression<Func<string>> bodycontactEmailAddressOther = null, Expression<Func<string>> bodycontactPhoneNumberWork = null, Expression<Func<string>> bodycontactPhoneNumberHome = null, Expression<Func<string>> bodycontactPhoneNumberMobile = null, Expression<Func<string>> bodycontactPhoneNumberAlternate = null, Expression<Func<string>> bodycontactFax = null, Expression<Func<string>> bodycontactBusinessStreet = null, Expression<Func<string>> bodycontactBusinessCity = null, Expression<Func<string>> bodycontactBusinessState = null, Expression<Func<string>> bodycontactBusinessZip = null, Expression<Func<string>> bodycontactBusinessCountry = null, Expression<Func<string>> bodycontactHomeStreet = null, Expression<Func<string>> bodycontactHomeCity = null, Expression<Func<string>> bodycontactHomeState = null, Expression<Func<string>> bodycontactHomeZip = null, Expression<Func<string>> bodycontactHomeCountry = null, Expression<Func<string[]>> bodycontactTags = null)
        {
            var __workflow_bodydomainName = WorkflowExpression.Compile(bodydomainName, nameof(bodydomainName), required: true);
            var __workflow_bodycontactFirstName = WorkflowExpression.Compile(bodycontactFirstName, nameof(bodycontactFirstName), required: true);
            var __workflow_bodycontactLastName = WorkflowExpression.Compile(bodycontactLastName, nameof(bodycontactLastName), required: true);
            var __workflow_bodycontactTitle = WorkflowExpression.Compile(bodycontactTitle, nameof(bodycontactTitle), required: false);
            var __workflow_bodycontactBackground = WorkflowExpression.Compile(bodycontactBackground, nameof(bodycontactBackground), required: false);
            var __workflow_bodycontactCompanyName = WorkflowExpression.Compile(bodycontactCompanyName, nameof(bodycontactCompanyName), required: false);
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
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domain-name"] = ExpressionConverter.ConvertO(__workflow_bodydomainName);
                bodypropCount++;
                body["contact-first-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactFirstName);
                bodypropCount++;
                body["contact-last-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactLastName);
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

                if (__workflow_bodycontactCompanyName != null)
                {
                    body["contact-company-name"] = ExpressionConverter.ConvertO(__workflow_bodycontactCompanyName);
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

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requests")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RepfabricCreateCompany(Expression<Func<string>> bodydomainName, Expression<Func<string>> bodycompanyName = null, Expression<Func<int>> bodycompanyTypeId = null, Expression<Func<string>> bodycompanyType = null, Expression<Func<int>> bodycompanyClassId = null, Expression<Func<string>> bodycompanyClass = null, Expression<Func<int>> bodycompanyCategoryId = null, Expression<Func<string>> bodycompanyCategory = null, Expression<Func<string>> bodycompanyPhone1 = null, Expression<Func<string>> bodycompanyPhone2 = null, Expression<Func<string>> bodycompanyFax = null, Expression<Func<string>> bodycompanyRegion = null, Expression<Func<string>> bodycompanyStreet = null, Expression<Func<string>> bodycompanyCity = null, Expression<Func<string>> bodycompanyState = null, Expression<Func<string>> bodycompanyZip = null, Expression<Func<string>> bodycompanyCountry = null, Expression<Func<string>> bodycompanyPoBox = null, Expression<Func<string>> bodycompanyWebsite = null, Expression<Func<string>> bodycompanyComments = null, Expression<Func<int>> bodycompanySalesTeamId = null, Expression<Func<string>> bodycompanySalesTeam = null)
        {
            var __workflow_bodydomainName = WorkflowExpression.Compile(bodydomainName, nameof(bodydomainName), required: true);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: false);
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
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Company";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domain-name"] = ExpressionConverter.ConvertO(__workflow_bodydomainName);
                if (__workflow_bodycompanyName != null)
                {
                    body["company-name"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

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

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requests")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RepfabricCreateQuote(Expression<Func<string>> bodydomainName, Expression<Func<string>> bodyquotesBaseUrl, Expression<Func<string>> bodyauthQuotes, Expression<Func<string>> bodycompanyName = null, Expression<Func<int>> bodycompanyTypeId = null, Expression<Func<string>> bodycompanyType = null, Expression<Func<string>> bodycompanyPhone1 = null, Expression<Func<string>> bodycompanyStreet = null, Expression<Func<string>> bodycompanyCity = null, Expression<Func<string>> bodycompanyState = null, Expression<Func<string>> bodycompanyZip = null, Expression<Func<string>> bodycompanyWebsite = null, Expression<Func<string>> bodycontactFirstName = null, Expression<Func<string>> bodycontactLastName = null, Expression<Func<string>> bodycontactEmailAddressWork = null, Expression<Func<string>> bodycontactPhoneNumberWork = null, Expression<Func<string>> bodycontactTitle = null, Expression<Func<string>> bodyquoteNumber = null, Expression<Func<string>> bodyquoteDate = null, Expression<Func<string>> bodyexpiryDate = null, Expression<Func<string>> bodyfollowUp = null, Expression<Func<string>> bodyprogram = null, Expression<Func<string>> bodyprincipalName = null, Expression<Func<string>> bodyvalue = null, Expression<Func<string>> bodylineItempartNum = null, Expression<Func<string>> bodylineItemcustPart = null, Expression<Func<string>> bodylineItemdescription = null, Expression<Func<string>> bodylineItemorderQty = null, Expression<Func<string>> bodylineItemunitPrice = null, Expression<Func<string>> bodylineItemextPrice = null, Expression<Func<string>> bodylineItemproductLine = null)
        {
            var __workflow_bodydomainName = WorkflowExpression.Compile(bodydomainName, nameof(bodydomainName), required: true);
            var __workflow_bodyquotesBaseUrl = WorkflowExpression.Compile(bodyquotesBaseUrl, nameof(bodyquotesBaseUrl), required: true);
            var __workflow_bodyauthQuotes = WorkflowExpression.Compile(bodyauthQuotes, nameof(bodyauthQuotes), required: true);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodycompanyTypeId = WorkflowExpression.Compile(bodycompanyTypeId, nameof(bodycompanyTypeId), required: false);
            var __workflow_bodycompanyType = WorkflowExpression.Compile(bodycompanyType, nameof(bodycompanyType), required: false);
            var __workflow_bodycompanyPhone1 = WorkflowExpression.Compile(bodycompanyPhone1, nameof(bodycompanyPhone1), required: false);
            var __workflow_bodycompanyStreet = WorkflowExpression.Compile(bodycompanyStreet, nameof(bodycompanyStreet), required: false);
            var __workflow_bodycompanyCity = WorkflowExpression.Compile(bodycompanyCity, nameof(bodycompanyCity), required: false);
            var __workflow_bodycompanyState = WorkflowExpression.Compile(bodycompanyState, nameof(bodycompanyState), required: false);
            var __workflow_bodycompanyZip = WorkflowExpression.Compile(bodycompanyZip, nameof(bodycompanyZip), required: false);
            var __workflow_bodycompanyWebsite = WorkflowExpression.Compile(bodycompanyWebsite, nameof(bodycompanyWebsite), required: false);
            var __workflow_bodycontactFirstName = WorkflowExpression.Compile(bodycontactFirstName, nameof(bodycontactFirstName), required: false);
            var __workflow_bodycontactLastName = WorkflowExpression.Compile(bodycontactLastName, nameof(bodycontactLastName), required: false);
            var __workflow_bodycontactEmailAddressWork = WorkflowExpression.Compile(bodycontactEmailAddressWork, nameof(bodycontactEmailAddressWork), required: false);
            var __workflow_bodycontactPhoneNumberWork = WorkflowExpression.Compile(bodycontactPhoneNumberWork, nameof(bodycontactPhoneNumberWork), required: false);
            var __workflow_bodycontactTitle = WorkflowExpression.Compile(bodycontactTitle, nameof(bodycontactTitle), required: false);
            var __workflow_bodyquoteNumber = WorkflowExpression.Compile(bodyquoteNumber, nameof(bodyquoteNumber), required: false);
            var __workflow_bodyquoteDate = WorkflowExpression.Compile(bodyquoteDate, nameof(bodyquoteDate), required: false);
            var __workflow_bodyexpiryDate = WorkflowExpression.Compile(bodyexpiryDate, nameof(bodyexpiryDate), required: false);
            var __workflow_bodyfollowUp = WorkflowExpression.Compile(bodyfollowUp, nameof(bodyfollowUp), required: false);
            var __workflow_bodyprogram = WorkflowExpression.Compile(bodyprogram, nameof(bodyprogram), required: false);
            var __workflow_bodyprincipalName = WorkflowExpression.Compile(bodyprincipalName, nameof(bodyprincipalName), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodylineItempartNum = WorkflowExpression.Compile(bodylineItempartNum, nameof(bodylineItempartNum), required: false);
            var __workflow_bodylineItemcustPart = WorkflowExpression.Compile(bodylineItemcustPart, nameof(bodylineItemcustPart), required: false);
            var __workflow_bodylineItemdescription = WorkflowExpression.Compile(bodylineItemdescription, nameof(bodylineItemdescription), required: false);
            var __workflow_bodylineItemorderQty = WorkflowExpression.Compile(bodylineItemorderQty, nameof(bodylineItemorderQty), required: false);
            var __workflow_bodylineItemunitPrice = WorkflowExpression.Compile(bodylineItemunitPrice, nameof(bodylineItemunitPrice), required: false);
            var __workflow_bodylineItemextPrice = WorkflowExpression.Compile(bodylineItemextPrice, nameof(bodylineItemextPrice), required: false);
            var __workflow_bodylineItemproductLine = WorkflowExpression.Compile(bodylineItemproductLine, nameof(bodylineItemproductLine), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Quote";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domain-name"] = ExpressionConverter.ConvertO(__workflow_bodydomainName);
                bodypropCount++;
                body["quotes-base-url"] = ExpressionConverter.ConvertO(__workflow_bodyquotesBaseUrl);
                bodypropCount++;
                body["auth-quotes"] = ExpressionConverter.ConvertO(__workflow_bodyauthQuotes);
                if (__workflow_bodycompanyName != null)
                {
                    body["company-name"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

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

                if (__workflow_bodycompanyPhone1 != null)
                {
                    body["company-phone1"] = ExpressionConverter.ConvertO(__workflow_bodycompanyPhone1);
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

                if (__workflow_bodycompanyWebsite != null)
                {
                    body["company-website"] = ExpressionConverter.ConvertO(__workflow_bodycompanyWebsite);
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

                if (__workflow_bodycontactEmailAddressWork != null)
                {
                    body["contact-email-address-work"] = ExpressionConverter.ConvertO(__workflow_bodycontactEmailAddressWork);
                    bodypropCount++;
                }

                if (__workflow_bodycontactPhoneNumberWork != null)
                {
                    body["contact-phone-number-work"] = ExpressionConverter.ConvertO(__workflow_bodycontactPhoneNumberWork);
                    bodypropCount++;
                }

                if (__workflow_bodycontactTitle != null)
                {
                    body["contact-title"] = ExpressionConverter.ConvertO(__workflow_bodycontactTitle);
                    bodypropCount++;
                }

                if (__workflow_bodyquoteNumber != null)
                {
                    body["quote-number"] = ExpressionConverter.ConvertO(__workflow_bodyquoteNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyquoteDate != null)
                {
                    body["quote-date"] = ExpressionConverter.ConvertO(__workflow_bodyquoteDate);
                    bodypropCount++;
                }

                if (__workflow_bodyexpiryDate != null)
                {
                    body["expiry-date"] = ExpressionConverter.ConvertO(__workflow_bodyexpiryDate);
                    bodypropCount++;
                }

                if (__workflow_bodyfollowUp != null)
                {
                    body["follow-up"] = ExpressionConverter.ConvertO(__workflow_bodyfollowUp);
                    bodypropCount++;
                }

                if (__workflow_bodyprogram != null)
                {
                    body["program"] = ExpressionConverter.ConvertO(__workflow_bodyprogram);
                    bodypropCount++;
                }

                if (__workflow_bodyprincipalName != null)
                {
                    body["principal-name"] = ExpressionConverter.ConvertO(__workflow_bodyprincipalName);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                var lineItemObject = new JObject();
                var lineItemObjectpropCount = 0;
                if (__workflow_bodylineItempartNum != null)
                {
                    lineItemObject["part-num"] = ExpressionConverter.ConvertO(__workflow_bodylineItempartNum);
                    lineItemObjectpropCount++;
                }

                if (__workflow_bodylineItemcustPart != null)
                {
                    lineItemObject["cust-part"] = ExpressionConverter.ConvertO(__workflow_bodylineItemcustPart);
                    lineItemObjectpropCount++;
                }

                if (__workflow_bodylineItemdescription != null)
                {
                    lineItemObject["description"] = ExpressionConverter.ConvertO(__workflow_bodylineItemdescription);
                    lineItemObjectpropCount++;
                }

                if (__workflow_bodylineItemorderQty != null)
                {
                    lineItemObject["order-qty"] = ExpressionConverter.ConvertO(__workflow_bodylineItemorderQty);
                    lineItemObjectpropCount++;
                }

                if (__workflow_bodylineItemunitPrice != null)
                {
                    lineItemObject["unit-price"] = ExpressionConverter.ConvertO(__workflow_bodylineItemunitPrice);
                    lineItemObjectpropCount++;
                }

                if (__workflow_bodylineItemextPrice != null)
                {
                    lineItemObject["ext-price"] = ExpressionConverter.ConvertO(__workflow_bodylineItemextPrice);
                    lineItemObjectpropCount++;
                }

                if (__workflow_bodylineItemproductLine != null)
                {
                    lineItemObject["product-line"] = ExpressionConverter.ConvertO(__workflow_bodylineItemproductLine);
                    lineItemObjectpropCount++;
                }

                if (lineItemObjectpropCount > 0)
                {
                    body["line-item"] = lineItemObject;
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

    public class RequestsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Requests;

    public partial class WorkflowManagedActions
    {
        public RequestsActions Requests(string connectionId) => new RequestsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RequestsTriggers Requests(string connectionId) => new RequestsTriggers(connectionId);
    }
}