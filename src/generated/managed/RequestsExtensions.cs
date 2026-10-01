//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Requests
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RequestsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requests")]
        public IWorkflowAction RepfabricCreateContact([WorkflowExpression] Func<string> bodydomainName, [WorkflowExpression] Func<string> bodycontactFirstName, [WorkflowExpression] Func<string> bodycontactLastName, [WorkflowExpression] Func<string> bodycontactTitle = null, [WorkflowExpression] Func<string> bodycontactBackground = null, [WorkflowExpression] Func<string> bodycontactCompanyName = null, [WorkflowExpression] Func<bool> bodycontactPrimary = null, [WorkflowExpression] Func<string> bodycontactCompanyTypeName = null, [WorkflowExpression] Func<string> bodycontactEmailAddressWork = null, [WorkflowExpression] Func<string> bodycontactEmailAddressPersonal = null, [WorkflowExpression] Func<string> bodycontactEmailAddressAlternate = null, [WorkflowExpression] Func<string> bodycontactEmailAddressOther = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberWork = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberHome = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberMobile = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberAlternate = null, [WorkflowExpression] Func<string> bodycontactFax = null, [WorkflowExpression] Func<string> bodycontactBusinessStreet = null, [WorkflowExpression] Func<string> bodycontactBusinessCity = null, [WorkflowExpression] Func<string> bodycontactBusinessState = null, [WorkflowExpression] Func<string> bodycontactBusinessZip = null, [WorkflowExpression] Func<string> bodycontactBusinessCountry = null, [WorkflowExpression] Func<string> bodycontactHomeStreet = null, [WorkflowExpression] Func<string> bodycontactHomeCity = null, [WorkflowExpression] Func<string> bodycontactHomeState = null, [WorkflowExpression] Func<string> bodycontactHomeZip = null, [WorkflowExpression] Func<string> bodycontactHomeCountry = null, [WorkflowExpression] Func<string[]> bodycontactTags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domain-name"] = SourceExpressionConverter.ConvertToken(bodydomainName);
                bodypropCount++;
                body["contact-first-name"] = SourceExpressionConverter.ConvertToken(bodycontactFirstName);
                bodypropCount++;
                body["contact-last-name"] = SourceExpressionConverter.ConvertToken(bodycontactLastName);
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

                if (bodycontactCompanyName != null)
                {
                    body["contact-company-name"] = SourceExpressionConverter.ConvertToken(bodycontactCompanyName);
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

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requests")]
        public IWorkflowAction RepfabricCreateCompany([WorkflowExpression] Func<string> bodydomainName, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<int> bodycompanyTypeId = null, [WorkflowExpression] Func<string> bodycompanyType = null, [WorkflowExpression] Func<int> bodycompanyClassId = null, [WorkflowExpression] Func<string> bodycompanyClass = null, [WorkflowExpression] Func<int> bodycompanyCategoryId = null, [WorkflowExpression] Func<string> bodycompanyCategory = null, [WorkflowExpression] Func<string> bodycompanyPhone1 = null, [WorkflowExpression] Func<string> bodycompanyPhone2 = null, [WorkflowExpression] Func<string> bodycompanyFax = null, [WorkflowExpression] Func<string> bodycompanyRegion = null, [WorkflowExpression] Func<string> bodycompanyStreet = null, [WorkflowExpression] Func<string> bodycompanyCity = null, [WorkflowExpression] Func<string> bodycompanyState = null, [WorkflowExpression] Func<string> bodycompanyZip = null, [WorkflowExpression] Func<string> bodycompanyCountry = null, [WorkflowExpression] Func<string> bodycompanyPoBox = null, [WorkflowExpression] Func<string> bodycompanyWebsite = null, [WorkflowExpression] Func<string> bodycompanyComments = null, [WorkflowExpression] Func<int> bodycompanySalesTeamId = null, [WorkflowExpression] Func<string> bodycompanySalesTeam = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Company";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domain-name"] = SourceExpressionConverter.ConvertToken(bodydomainName);
                if (bodycompanyName != null)
                {
                    body["company-name"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                    bodypropCount++;
                }

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

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "requests")]
        public IWorkflowAction RepfabricCreateQuote([WorkflowExpression] Func<string> bodydomainName, [WorkflowExpression] Func<string> bodyquotesBaseUrl, [WorkflowExpression] Func<string> bodyauthQuotes, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<int> bodycompanyTypeId = null, [WorkflowExpression] Func<string> bodycompanyType = null, [WorkflowExpression] Func<string> bodycompanyPhone1 = null, [WorkflowExpression] Func<string> bodycompanyStreet = null, [WorkflowExpression] Func<string> bodycompanyCity = null, [WorkflowExpression] Func<string> bodycompanyState = null, [WorkflowExpression] Func<string> bodycompanyZip = null, [WorkflowExpression] Func<string> bodycompanyWebsite = null, [WorkflowExpression] Func<string> bodycontactFirstName = null, [WorkflowExpression] Func<string> bodycontactLastName = null, [WorkflowExpression] Func<string> bodycontactEmailAddressWork = null, [WorkflowExpression] Func<string> bodycontactPhoneNumberWork = null, [WorkflowExpression] Func<string> bodycontactTitle = null, [WorkflowExpression] Func<string> bodyquoteNumber = null, [WorkflowExpression] Func<string> bodyquoteDate = null, [WorkflowExpression] Func<string> bodyexpiryDate = null, [WorkflowExpression] Func<string> bodyfollowUp = null, [WorkflowExpression] Func<string> bodyprogram = null, [WorkflowExpression] Func<string> bodyprincipalName = null, [WorkflowExpression] Func<string> bodyvalue = null, [WorkflowExpression] Func<string> bodylineItempartNum = null, [WorkflowExpression] Func<string> bodylineItemcustPart = null, [WorkflowExpression] Func<string> bodylineItemdescription = null, [WorkflowExpression] Func<string> bodylineItemorderQty = null, [WorkflowExpression] Func<string> bodylineItemunitPrice = null, [WorkflowExpression] Func<string> bodylineItemextPrice = null, [WorkflowExpression] Func<string> bodylineItemproductLine = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Quote";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["domain-name"] = SourceExpressionConverter.ConvertToken(bodydomainName);
                bodypropCount++;
                body["quotes-base-url"] = SourceExpressionConverter.ConvertToken(bodyquotesBaseUrl);
                bodypropCount++;
                body["auth-quotes"] = SourceExpressionConverter.ConvertToken(bodyauthQuotes);
                if (bodycompanyName != null)
                {
                    body["company-name"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                    bodypropCount++;
                }

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

                if (bodycompanyPhone1 != null)
                {
                    body["company-phone1"] = SourceExpressionConverter.ConvertToken(bodycompanyPhone1);
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

                if (bodycompanyWebsite != null)
                {
                    body["company-website"] = SourceExpressionConverter.ConvertToken(bodycompanyWebsite);
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

                if (bodycontactEmailAddressWork != null)
                {
                    body["contact-email-address-work"] = SourceExpressionConverter.ConvertToken(bodycontactEmailAddressWork);
                    bodypropCount++;
                }

                if (bodycontactPhoneNumberWork != null)
                {
                    body["contact-phone-number-work"] = SourceExpressionConverter.ConvertToken(bodycontactPhoneNumberWork);
                    bodypropCount++;
                }

                if (bodycontactTitle != null)
                {
                    body["contact-title"] = SourceExpressionConverter.ConvertToken(bodycontactTitle);
                    bodypropCount++;
                }

                if (bodyquoteNumber != null)
                {
                    body["quote-number"] = SourceExpressionConverter.ConvertToken(bodyquoteNumber);
                    bodypropCount++;
                }

                if (bodyquoteDate != null)
                {
                    body["quote-date"] = SourceExpressionConverter.ConvertToken(bodyquoteDate);
                    bodypropCount++;
                }

                if (bodyexpiryDate != null)
                {
                    body["expiry-date"] = SourceExpressionConverter.ConvertToken(bodyexpiryDate);
                    bodypropCount++;
                }

                if (bodyfollowUp != null)
                {
                    body["follow-up"] = SourceExpressionConverter.ConvertToken(bodyfollowUp);
                    bodypropCount++;
                }

                if (bodyprogram != null)
                {
                    body["program"] = SourceExpressionConverter.ConvertToken(bodyprogram);
                    bodypropCount++;
                }

                if (bodyprincipalName != null)
                {
                    body["principal-name"] = SourceExpressionConverter.ConvertToken(bodyprincipalName);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                var lineItemObject = new JObject();
                var lineItemObjectpropCount = 0;
                if (bodylineItempartNum != null)
                {
                    lineItemObject["part-num"] = SourceExpressionConverter.ConvertToken(bodylineItempartNum);
                    lineItemObjectpropCount++;
                }

                if (bodylineItemcustPart != null)
                {
                    lineItemObject["cust-part"] = SourceExpressionConverter.ConvertToken(bodylineItemcustPart);
                    lineItemObjectpropCount++;
                }

                if (bodylineItemdescription != null)
                {
                    lineItemObject["description"] = SourceExpressionConverter.ConvertToken(bodylineItemdescription);
                    lineItemObjectpropCount++;
                }

                if (bodylineItemorderQty != null)
                {
                    lineItemObject["order-qty"] = SourceExpressionConverter.ConvertToken(bodylineItemorderQty);
                    lineItemObjectpropCount++;
                }

                if (bodylineItemunitPrice != null)
                {
                    lineItemObject["unit-price"] = SourceExpressionConverter.ConvertToken(bodylineItemunitPrice);
                    lineItemObjectpropCount++;
                }

                if (bodylineItemextPrice != null)
                {
                    lineItemObject["ext-price"] = SourceExpressionConverter.ConvertToken(bodylineItemextPrice);
                    lineItemObjectpropCount++;
                }

                if (bodylineItemproductLine != null)
                {
                    lineItemObject["product-line"] = SourceExpressionConverter.ConvertToken(bodylineItemproductLine);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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