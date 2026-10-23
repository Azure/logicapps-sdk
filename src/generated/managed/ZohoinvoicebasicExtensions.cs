//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zohoinvoicebasic
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZohoinvoicebasicActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactsGetResponse, ApiConnectionActionConfiguration> ContactsGet(Expression<Func<string>> contactName = null, Expression<Func<string>> companyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> address = null, Expression<Func<string>> email = null, Expression<Func<string>> phone = null, Expression<Func<filterByInput>> filterBy = null, Expression<Func<string>> searchText = null, Expression<Func<sortColumnInput>> sortColumn = null, Expression<Func<int>> zcrmContactId = null, Expression<Func<int>> zcrmAccountId = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_contactName = WorkflowExpression.Compile(contactName, nameof(contactName), required: false);
            var __workflow_companyName = WorkflowExpression.Compile(companyName, nameof(companyName), required: false);
            var __workflow_firstName = WorkflowExpression.Compile(firstName, nameof(firstName), required: false);
            var __workflow_lastName = WorkflowExpression.Compile(lastName, nameof(lastName), required: false);
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_phone = WorkflowExpression.Compile(phone, nameof(phone), required: false);
            var __workflow_filterBy = WorkflowExpression.Compile(filterBy, nameof(filterBy), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_sortColumn = WorkflowExpression.Compile(sortColumn, nameof(sortColumn), required: false);
            var __workflow_zcrmContactId = WorkflowExpression.Compile(zcrmContactId, nameof(zcrmContactId), required: false);
            var __workflow_zcrmAccountId = WorkflowExpression.Compile(zcrmAccountId, nameof(zcrmAccountId), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ContactsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invoice/v3/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_contactName != null)
                    callPayload.Queries["contact_name"] = ExpressionConverter.Convert(__workflow_contactName);
                if (__workflow_companyName != null)
                    callPayload.Queries["company_name"] = ExpressionConverter.Convert(__workflow_companyName);
                if (__workflow_firstName != null)
                    callPayload.Queries["first_name"] = ExpressionConverter.Convert(__workflow_firstName);
                if (__workflow_lastName != null)
                    callPayload.Queries["last_name"] = ExpressionConverter.Convert(__workflow_lastName);
                if (__workflow_address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_phone != null)
                    callPayload.Queries["phone"] = ExpressionConverter.Convert(__workflow_phone);
                if (__workflow_filterBy != null)
                    callPayload.Queries["filter_by"] = ExpressionConverter.Convert(__workflow_filterBy);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                if (__workflow_sortColumn != null)
                    callPayload.Queries["sort_column"] = ExpressionConverter.Convert(__workflow_sortColumn);
                if (__workflow_zcrmContactId != null)
                    callPayload.Queries["zcrm_contact_id"] = ExpressionConverter.Convert(__workflow_zcrmContactId);
                if (__workflow_zcrmAccountId != null)
                    callPayload.Queries["zcrm_account_id"] = ExpressionConverter.Convert(__workflow_zcrmAccountId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<ContactsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactPostResponse, ApiConnectionActionConfiguration> Contact(Expression<Func<string>> bodycontactName, Expression<Func<string>> bodycompanyName = null, Expression<Func<int>> bodypaymentTerms = null, Expression<Func<string>> bodycurrencyId = null, Expression<Func<string>> bodywebsite = null, Expression<Func<bodycustomFieldsInputItem[]>> bodycustomFields = null, Expression<Func<string>> bodybillingAddressattention = null, Expression<Func<string>> bodybillingAddressaddress = null, Expression<Func<string>> bodybillingAddressstreet2 = null, Expression<Func<string>> bodybillingAddressstateCode = null, Expression<Func<string>> bodybillingAddresscity = null, Expression<Func<string>> bodybillingAddressstate = null, Expression<Func<string>> bodybillingAddresszip = null, Expression<Func<string>> bodybillingAddresscountry = null, Expression<Func<string>> bodybillingAddressfax = null, Expression<Func<string>> bodybillingAddressphone = null, Expression<Func<string>> bodyshippingAddressattention = null, Expression<Func<string>> bodyshippingAddressaddress = null, Expression<Func<string>> bodyshippingAddressstreet2 = null, Expression<Func<string>> bodyshippingAddressstateCode = null, Expression<Func<string>> bodyshippingAddresscity = null, Expression<Func<string>> bodyshippingAddressstate = null, Expression<Func<string>> bodyshippingAddresszip = null, Expression<Func<string>> bodyshippingAddresscountry = null, Expression<Func<string>> bodyshippingAddressfax = null, Expression<Func<string>> bodyshippingAddressphone = null, Expression<Func<bodycontactPersonsInputItem[]>> bodycontactPersons = null, Expression<Func<string>> bodydefaultTemplatesinvoiceTemplateId = null, Expression<Func<string>> bodydefaultTemplatesinvoiceTemplateName = null, Expression<Func<string>> bodydefaultTemplatesestimateTemplateId = null, Expression<Func<string>> bodydefaultTemplatesestimateTemplateName = null, Expression<Func<string>> bodydefaultTemplatescreditnoteTemplateId = null, Expression<Func<string>> bodydefaultTemplatescreditnoteTemplateName = null, Expression<Func<string>> bodydefaultTemplatesinvoiceEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatesinvoiceEmailTemplateName = null, Expression<Func<string>> bodydefaultTemplatesestimateEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatesestimateEmailTemplateName = null, Expression<Func<string>> bodydefaultTemplatescreditnoteEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatescreditnoteEmailTemplateName = null, Expression<Func<bodylanguageCodeInput>> bodylanguageCode = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyvatRegNo = null, Expression<Func<string>> bodytaxRegNo = null, Expression<Func<string>> bodycountryCode = null, Expression<Func<string>> bodyvatTreatment = null, Expression<Func<string>> bodytaxTreatment = null, Expression<Func<bodytaxRegimeInput>> bodytaxRegime = null, Expression<Func<string>> bodylegalName = null, Expression<Func<bool>> bodyisTdsRegistered = null, Expression<Func<string>> bodyplaceOfContact = null, Expression<Func<string>> bodygstNo = null, Expression<Func<bodygstTreatmentInput>> bodygstTreatment = null, Expression<Func<string>> bodytaxAuthorityName = null, Expression<Func<string>> bodytaxExemptionCode = null, Expression<Func<string>> bodyavataxExemptNo = null, Expression<Func<string>> bodyavataxUseCode = null, Expression<Func<string>> bodytaxExemptionId = null, Expression<Func<string>> bodytaxAuthorityId = null, Expression<Func<string>> bodytaxId = null, Expression<Func<string>> bodytdsTaxId = null, Expression<Func<bool>> bodyisTaxable = null, Expression<Func<string>> bodyfacebook = null, Expression<Func<string>> bodytwitter = null)
        {
            var __workflow_bodycontactName = WorkflowExpression.Compile(bodycontactName, nameof(bodycontactName), required: true);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodypaymentTerms = WorkflowExpression.Compile(bodypaymentTerms, nameof(bodypaymentTerms), required: false);
            var __workflow_bodycurrencyId = WorkflowExpression.Compile(bodycurrencyId, nameof(bodycurrencyId), required: false);
            var __workflow_bodywebsite = WorkflowExpression.Compile(bodywebsite, nameof(bodywebsite), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodybillingAddressattention = WorkflowExpression.Compile(bodybillingAddressattention, nameof(bodybillingAddressattention), required: false);
            var __workflow_bodybillingAddressaddress = WorkflowExpression.Compile(bodybillingAddressaddress, nameof(bodybillingAddressaddress), required: false);
            var __workflow_bodybillingAddressstreet2 = WorkflowExpression.Compile(bodybillingAddressstreet2, nameof(bodybillingAddressstreet2), required: false);
            var __workflow_bodybillingAddressstateCode = WorkflowExpression.Compile(bodybillingAddressstateCode, nameof(bodybillingAddressstateCode), required: false);
            var __workflow_bodybillingAddresscity = WorkflowExpression.Compile(bodybillingAddresscity, nameof(bodybillingAddresscity), required: false);
            var __workflow_bodybillingAddressstate = WorkflowExpression.Compile(bodybillingAddressstate, nameof(bodybillingAddressstate), required: false);
            var __workflow_bodybillingAddresszip = WorkflowExpression.Compile(bodybillingAddresszip, nameof(bodybillingAddresszip), required: false);
            var __workflow_bodybillingAddresscountry = WorkflowExpression.Compile(bodybillingAddresscountry, nameof(bodybillingAddresscountry), required: false);
            var __workflow_bodybillingAddressfax = WorkflowExpression.Compile(bodybillingAddressfax, nameof(bodybillingAddressfax), required: false);
            var __workflow_bodybillingAddressphone = WorkflowExpression.Compile(bodybillingAddressphone, nameof(bodybillingAddressphone), required: false);
            var __workflow_bodyshippingAddressattention = WorkflowExpression.Compile(bodyshippingAddressattention, nameof(bodyshippingAddressattention), required: false);
            var __workflow_bodyshippingAddressaddress = WorkflowExpression.Compile(bodyshippingAddressaddress, nameof(bodyshippingAddressaddress), required: false);
            var __workflow_bodyshippingAddressstreet2 = WorkflowExpression.Compile(bodyshippingAddressstreet2, nameof(bodyshippingAddressstreet2), required: false);
            var __workflow_bodyshippingAddressstateCode = WorkflowExpression.Compile(bodyshippingAddressstateCode, nameof(bodyshippingAddressstateCode), required: false);
            var __workflow_bodyshippingAddresscity = WorkflowExpression.Compile(bodyshippingAddresscity, nameof(bodyshippingAddresscity), required: false);
            var __workflow_bodyshippingAddressstate = WorkflowExpression.Compile(bodyshippingAddressstate, nameof(bodyshippingAddressstate), required: false);
            var __workflow_bodyshippingAddresszip = WorkflowExpression.Compile(bodyshippingAddresszip, nameof(bodyshippingAddresszip), required: false);
            var __workflow_bodyshippingAddresscountry = WorkflowExpression.Compile(bodyshippingAddresscountry, nameof(bodyshippingAddresscountry), required: false);
            var __workflow_bodyshippingAddressfax = WorkflowExpression.Compile(bodyshippingAddressfax, nameof(bodyshippingAddressfax), required: false);
            var __workflow_bodyshippingAddressphone = WorkflowExpression.Compile(bodyshippingAddressphone, nameof(bodyshippingAddressphone), required: false);
            var __workflow_bodycontactPersons = WorkflowExpression.Compile(bodycontactPersons, nameof(bodycontactPersons), required: false);
            var __workflow_bodydefaultTemplatesinvoiceTemplateId = WorkflowExpression.Compile(bodydefaultTemplatesinvoiceTemplateId, nameof(bodydefaultTemplatesinvoiceTemplateId), required: false);
            var __workflow_bodydefaultTemplatesinvoiceTemplateName = WorkflowExpression.Compile(bodydefaultTemplatesinvoiceTemplateName, nameof(bodydefaultTemplatesinvoiceTemplateName), required: false);
            var __workflow_bodydefaultTemplatesestimateTemplateId = WorkflowExpression.Compile(bodydefaultTemplatesestimateTemplateId, nameof(bodydefaultTemplatesestimateTemplateId), required: false);
            var __workflow_bodydefaultTemplatesestimateTemplateName = WorkflowExpression.Compile(bodydefaultTemplatesestimateTemplateName, nameof(bodydefaultTemplatesestimateTemplateName), required: false);
            var __workflow_bodydefaultTemplatescreditnoteTemplateId = WorkflowExpression.Compile(bodydefaultTemplatescreditnoteTemplateId, nameof(bodydefaultTemplatescreditnoteTemplateId), required: false);
            var __workflow_bodydefaultTemplatescreditnoteTemplateName = WorkflowExpression.Compile(bodydefaultTemplatescreditnoteTemplateName, nameof(bodydefaultTemplatescreditnoteTemplateName), required: false);
            var __workflow_bodydefaultTemplatesinvoiceEmailTemplateId = WorkflowExpression.Compile(bodydefaultTemplatesinvoiceEmailTemplateId, nameof(bodydefaultTemplatesinvoiceEmailTemplateId), required: false);
            var __workflow_bodydefaultTemplatesinvoiceEmailTemplateName = WorkflowExpression.Compile(bodydefaultTemplatesinvoiceEmailTemplateName, nameof(bodydefaultTemplatesinvoiceEmailTemplateName), required: false);
            var __workflow_bodydefaultTemplatesestimateEmailTemplateId = WorkflowExpression.Compile(bodydefaultTemplatesestimateEmailTemplateId, nameof(bodydefaultTemplatesestimateEmailTemplateId), required: false);
            var __workflow_bodydefaultTemplatesestimateEmailTemplateName = WorkflowExpression.Compile(bodydefaultTemplatesestimateEmailTemplateName, nameof(bodydefaultTemplatesestimateEmailTemplateName), required: false);
            var __workflow_bodydefaultTemplatescreditnoteEmailTemplateId = WorkflowExpression.Compile(bodydefaultTemplatescreditnoteEmailTemplateId, nameof(bodydefaultTemplatescreditnoteEmailTemplateId), required: false);
            var __workflow_bodydefaultTemplatescreditnoteEmailTemplateName = WorkflowExpression.Compile(bodydefaultTemplatescreditnoteEmailTemplateName, nameof(bodydefaultTemplatescreditnoteEmailTemplateName), required: false);
            var __workflow_bodylanguageCode = WorkflowExpression.Compile(bodylanguageCode, nameof(bodylanguageCode), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyvatRegNo = WorkflowExpression.Compile(bodyvatRegNo, nameof(bodyvatRegNo), required: false);
            var __workflow_bodytaxRegNo = WorkflowExpression.Compile(bodytaxRegNo, nameof(bodytaxRegNo), required: false);
            var __workflow_bodycountryCode = WorkflowExpression.Compile(bodycountryCode, nameof(bodycountryCode), required: false);
            var __workflow_bodyvatTreatment = WorkflowExpression.Compile(bodyvatTreatment, nameof(bodyvatTreatment), required: false);
            var __workflow_bodytaxTreatment = WorkflowExpression.Compile(bodytaxTreatment, nameof(bodytaxTreatment), required: false);
            var __workflow_bodytaxRegime = WorkflowExpression.Compile(bodytaxRegime, nameof(bodytaxRegime), required: false);
            var __workflow_bodylegalName = WorkflowExpression.Compile(bodylegalName, nameof(bodylegalName), required: false);
            var __workflow_bodyisTdsRegistered = WorkflowExpression.Compile(bodyisTdsRegistered, nameof(bodyisTdsRegistered), required: false);
            var __workflow_bodyplaceOfContact = WorkflowExpression.Compile(bodyplaceOfContact, nameof(bodyplaceOfContact), required: false);
            var __workflow_bodygstNo = WorkflowExpression.Compile(bodygstNo, nameof(bodygstNo), required: false);
            var __workflow_bodygstTreatment = WorkflowExpression.Compile(bodygstTreatment, nameof(bodygstTreatment), required: false);
            var __workflow_bodytaxAuthorityName = WorkflowExpression.Compile(bodytaxAuthorityName, nameof(bodytaxAuthorityName), required: false);
            var __workflow_bodytaxExemptionCode = WorkflowExpression.Compile(bodytaxExemptionCode, nameof(bodytaxExemptionCode), required: false);
            var __workflow_bodyavataxExemptNo = WorkflowExpression.Compile(bodyavataxExemptNo, nameof(bodyavataxExemptNo), required: false);
            var __workflow_bodyavataxUseCode = WorkflowExpression.Compile(bodyavataxUseCode, nameof(bodyavataxUseCode), required: false);
            var __workflow_bodytaxExemptionId = WorkflowExpression.Compile(bodytaxExemptionId, nameof(bodytaxExemptionId), required: false);
            var __workflow_bodytaxAuthorityId = WorkflowExpression.Compile(bodytaxAuthorityId, nameof(bodytaxAuthorityId), required: false);
            var __workflow_bodytaxId = WorkflowExpression.Compile(bodytaxId, nameof(bodytaxId), required: false);
            var __workflow_bodytdsTaxId = WorkflowExpression.Compile(bodytdsTaxId, nameof(bodytdsTaxId), required: false);
            var __workflow_bodyisTaxable = WorkflowExpression.Compile(bodyisTaxable, nameof(bodyisTaxable), required: false);
            var __workflow_bodyfacebook = WorkflowExpression.Compile(bodyfacebook, nameof(bodyfacebook), required: false);
            var __workflow_bodytwitter = WorkflowExpression.Compile(bodytwitter, nameof(bodytwitter), required: false);
            return new DeferredBodyAction<ContactPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invoice/v3/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["contact_name"] = ExpressionConverter.ConvertO(__workflow_bodycontactName);
                if (__workflow_bodycompanyName != null)
                {
                    body["company_name"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodypaymentTerms != null)
                {
                    body["payment_terms"] = ExpressionConverter.ConvertO(__workflow_bodypaymentTerms);
                    bodypropCount++;
                }

                if (__workflow_bodycurrencyId != null)
                {
                    body["currency_id"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyId);
                    bodypropCount++;
                }

                if (__workflow_bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(__workflow_bodywebsite);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["custom_fields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                var billingAddressObject = new JObject();
                var billingAddressObjectpropCount = 0;
                if (__workflow_bodybillingAddressattention != null)
                {
                    billingAddressObject["attention"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressattention);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddressaddress != null)
                {
                    billingAddressObject["address"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressaddress);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddressstreet2 != null)
                {
                    billingAddressObject["street2"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressstreet2);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddressstateCode != null)
                {
                    billingAddressObject["state_code"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressstateCode);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddresscity != null)
                {
                    billingAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddresscity);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddressstate != null)
                {
                    billingAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressstate);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddresszip != null)
                {
                    billingAddressObject["zip"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddresszip);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddresscountry != null)
                {
                    billingAddressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddresscountry);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddressfax != null)
                {
                    billingAddressObject["fax"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressfax);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddressphone != null)
                {
                    billingAddressObject["phone"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressphone);
                    billingAddressObjectpropCount++;
                }

                if (billingAddressObjectpropCount > 0)
                {
                    body["billing_address"] = billingAddressObject;
                    bodypropCount++;
                }

                var shippingAddressObject = new JObject();
                var shippingAddressObjectpropCount = 0;
                if (__workflow_bodyshippingAddressattention != null)
                {
                    shippingAddressObject["attention"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressattention);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddressaddress != null)
                {
                    shippingAddressObject["address"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressaddress);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddressstreet2 != null)
                {
                    shippingAddressObject["street2"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressstreet2);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddressstateCode != null)
                {
                    shippingAddressObject["state_code"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressstateCode);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddresscity != null)
                {
                    shippingAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddresscity);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddressstate != null)
                {
                    shippingAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressstate);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddresszip != null)
                {
                    shippingAddressObject["zip"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddresszip);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddresscountry != null)
                {
                    shippingAddressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddresscountry);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddressfax != null)
                {
                    shippingAddressObject["fax"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressfax);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddressphone != null)
                {
                    shippingAddressObject["phone"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressphone);
                    shippingAddressObjectpropCount++;
                }

                if (shippingAddressObjectpropCount > 0)
                {
                    body["shipping_address"] = shippingAddressObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontactPersons != null)
                {
                    body["contact_persons"] = ExpressionConverter.ConvertO(__workflow_bodycontactPersons);
                    bodypropCount++;
                }

                var defaultTemplatesObject = new JObject();
                var defaultTemplatesObjectpropCount = 0;
                if (__workflow_bodydefaultTemplatesinvoiceTemplateId != null)
                {
                    defaultTemplatesObject["invoice_template_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesinvoiceTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesinvoiceTemplateName != null)
                {
                    defaultTemplatesObject["invoice_template_name"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesinvoiceTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesestimateTemplateId != null)
                {
                    defaultTemplatesObject["estimate_template_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesestimateTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesestimateTemplateName != null)
                {
                    defaultTemplatesObject["estimate_template_name"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesestimateTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatescreditnoteTemplateId != null)
                {
                    defaultTemplatesObject["creditnote_template_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatescreditnoteTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatescreditnoteTemplateName != null)
                {
                    defaultTemplatesObject["creditnote_template_name"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatescreditnoteTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesinvoiceEmailTemplateId != null)
                {
                    defaultTemplatesObject["invoice_email_template_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesinvoiceEmailTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesinvoiceEmailTemplateName != null)
                {
                    defaultTemplatesObject["invoice_email_template_name"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesinvoiceEmailTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesestimateEmailTemplateId != null)
                {
                    defaultTemplatesObject["estimate_email_template_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesestimateEmailTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesestimateEmailTemplateName != null)
                {
                    defaultTemplatesObject["estimate_email_template_name"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesestimateEmailTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatescreditnoteEmailTemplateId != null)
                {
                    defaultTemplatesObject["creditnote_email_template_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatescreditnoteEmailTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatescreditnoteEmailTemplateName != null)
                {
                    defaultTemplatesObject["creditnote_email_template_name"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatescreditnoteEmailTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (defaultTemplatesObjectpropCount > 0)
                {
                    body["default_templates"] = defaultTemplatesObject;
                    bodypropCount++;
                }

                if (__workflow_bodylanguageCode != null)
                {
                    body["language_code"] = ExpressionConverter.ConvertO(__workflow_bodylanguageCode);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyvatRegNo != null)
                {
                    body["vat_reg_no"] = ExpressionConverter.ConvertO(__workflow_bodyvatRegNo);
                    bodypropCount++;
                }

                if (__workflow_bodytaxRegNo != null)
                {
                    body["tax_reg_no"] = ExpressionConverter.ConvertO(__workflow_bodytaxRegNo);
                    bodypropCount++;
                }

                if (__workflow_bodycountryCode != null)
                {
                    body["country_code"] = ExpressionConverter.ConvertO(__workflow_bodycountryCode);
                    bodypropCount++;
                }

                if (__workflow_bodyvatTreatment != null)
                {
                    body["vat_treatment"] = ExpressionConverter.ConvertO(__workflow_bodyvatTreatment);
                    bodypropCount++;
                }

                if (__workflow_bodytaxTreatment != null)
                {
                    body["tax_treatment"] = ExpressionConverter.ConvertO(__workflow_bodytaxTreatment);
                    bodypropCount++;
                }

                if (__workflow_bodytaxRegime != null)
                {
                    body["tax_regime"] = ExpressionConverter.ConvertO(__workflow_bodytaxRegime);
                    bodypropCount++;
                }

                if (__workflow_bodylegalName != null)
                {
                    body["legal_name"] = ExpressionConverter.ConvertO(__workflow_bodylegalName);
                    bodypropCount++;
                }

                if (__workflow_bodyisTdsRegistered != null)
                {
                    body["is_tds_registered"] = ExpressionConverter.ConvertO(__workflow_bodyisTdsRegistered);
                    bodypropCount++;
                }

                if (__workflow_bodyplaceOfContact != null)
                {
                    body["place_of_contact"] = ExpressionConverter.ConvertO(__workflow_bodyplaceOfContact);
                    bodypropCount++;
                }

                if (__workflow_bodygstNo != null)
                {
                    body["gst_no"] = ExpressionConverter.ConvertO(__workflow_bodygstNo);
                    bodypropCount++;
                }

                if (__workflow_bodygstTreatment != null)
                {
                    body["gst_treatment"] = ExpressionConverter.ConvertO(__workflow_bodygstTreatment);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAuthorityName != null)
                {
                    body["tax_authority_name"] = ExpressionConverter.ConvertO(__workflow_bodytaxAuthorityName);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptionCode != null)
                {
                    body["tax_exemption_code"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptionCode);
                    bodypropCount++;
                }

                if (__workflow_bodyavataxExemptNo != null)
                {
                    body["avatax_exempt_no"] = ExpressionConverter.ConvertO(__workflow_bodyavataxExemptNo);
                    bodypropCount++;
                }

                if (__workflow_bodyavataxUseCode != null)
                {
                    body["avatax_use_code"] = ExpressionConverter.ConvertO(__workflow_bodyavataxUseCode);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptionId != null)
                {
                    body["tax_exemption_id"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptionId);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAuthorityId != null)
                {
                    body["tax_authority_id"] = ExpressionConverter.ConvertO(__workflow_bodytaxAuthorityId);
                    bodypropCount++;
                }

                if (__workflow_bodytaxId != null)
                {
                    body["tax_id"] = ExpressionConverter.ConvertO(__workflow_bodytaxId);
                    bodypropCount++;
                }

                if (__workflow_bodytdsTaxId != null)
                {
                    body["tds_tax_id"] = ExpressionConverter.ConvertO(__workflow_bodytdsTaxId);
                    bodypropCount++;
                }

                if (__workflow_bodyisTaxable != null)
                {
                    body["is_taxable"] = ExpressionConverter.ConvertO(__workflow_bodyisTaxable);
                    bodypropCount++;
                }

                if (__workflow_bodyfacebook != null)
                {
                    body["facebook"] = ExpressionConverter.ConvertO(__workflow_bodyfacebook);
                    bodypropCount++;
                }

                if (__workflow_bodytwitter != null)
                {
                    body["twitter"] = ExpressionConverter.ConvertO(__workflow_bodytwitter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ContactPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactGetResponse, ApiConnectionActionConfiguration> ContactGet(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<ContactGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoice/v3/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactDeleteResponse, ApiConnectionActionConfiguration> ContactDelete(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<ContactDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoice/v3/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactPutResponse, ApiConnectionActionConfiguration> ContactPut(Expression<Func<string>> contactId, Expression<Func<string>> bodycontactName, Expression<Func<string>> bodycompanyName = null, Expression<Func<int>> bodypaymentTerms = null, Expression<Func<string>> bodycurrencyId = null, Expression<Func<string>> bodywebsite = null, Expression<Func<bodycustomFieldsInputItem2[]>> bodycustomFields = null, Expression<Func<string>> bodybillingAddressattention = null, Expression<Func<string>> bodybillingAddressaddress = null, Expression<Func<string>> bodybillingAddressstreet2 = null, Expression<Func<string>> bodybillingAddressstateCode = null, Expression<Func<string>> bodybillingAddresscity = null, Expression<Func<string>> bodybillingAddressstate = null, Expression<Func<string>> bodybillingAddresszip = null, Expression<Func<string>> bodybillingAddresscountry = null, Expression<Func<string>> bodybillingAddressfax = null, Expression<Func<string>> bodybillingAddressphone = null, Expression<Func<string>> bodyshippingAddressattention = null, Expression<Func<string>> bodyshippingAddressaddress = null, Expression<Func<string>> bodyshippingAddressstreet2 = null, Expression<Func<string>> bodyshippingAddressstateCode = null, Expression<Func<string>> bodyshippingAddresscity = null, Expression<Func<string>> bodyshippingAddressstate = null, Expression<Func<string>> bodyshippingAddresszip = null, Expression<Func<string>> bodyshippingAddresscountry = null, Expression<Func<string>> bodyshippingAddressfax = null, Expression<Func<string>> bodyshippingAddressphone = null, Expression<Func<bodycontactPersonsInputItem[]>> bodycontactPersons = null, Expression<Func<string>> bodydefaultTemplatesinvoiceTemplateId = null, Expression<Func<string>> bodydefaultTemplatesinvoiceTemplateName = null, Expression<Func<string>> bodydefaultTemplatesestimateTemplateId = null, Expression<Func<string>> bodydefaultTemplatesestimateTemplateName = null, Expression<Func<string>> bodydefaultTemplatescreditnoteTemplateId = null, Expression<Func<string>> bodydefaultTemplatescreditnoteTemplateName = null, Expression<Func<string>> bodydefaultTemplatesinvoiceEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatesinvoiceEmailTemplateName = null, Expression<Func<string>> bodydefaultTemplatesestimateEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatesestimateEmailTemplateName = null, Expression<Func<string>> bodydefaultTemplatescreditnoteEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatescreditnoteEmailTemplateName = null, Expression<Func<bodylanguageCodeInput>> bodylanguageCode = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyvatRegNo = null, Expression<Func<string>> bodytaxRegNo = null, Expression<Func<string>> bodycountryCode = null, Expression<Func<bodyvatTreatmentInput>> bodyvatTreatment = null, Expression<Func<string>> bodytaxTreatment = null, Expression<Func<bodytaxRegimeInput>> bodytaxRegime = null, Expression<Func<string>> bodylegalName = null, Expression<Func<bool>> bodyisTdsRegistered = null, Expression<Func<string>> bodyplaceOfContact = null, Expression<Func<string>> bodygstNo = null, Expression<Func<bodygstTreatmentInput>> bodygstTreatment = null, Expression<Func<string>> bodytaxAuthorityName = null, Expression<Func<string>> bodytaxExemptionCode = null, Expression<Func<string>> bodyavataxExemptNo = null, Expression<Func<string>> bodyavataxUseCode = null, Expression<Func<string>> bodytaxExemptionId = null, Expression<Func<string>> bodytaxAuthorityId = null, Expression<Func<string>> bodytaxId = null, Expression<Func<string>> bodytdsTaxId = null, Expression<Func<bool>> bodyisTaxable = null, Expression<Func<string>> bodyfacebook = null, Expression<Func<string>> bodytwitter = null)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_bodycontactName = WorkflowExpression.Compile(bodycontactName, nameof(bodycontactName), required: true);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodypaymentTerms = WorkflowExpression.Compile(bodypaymentTerms, nameof(bodypaymentTerms), required: false);
            var __workflow_bodycurrencyId = WorkflowExpression.Compile(bodycurrencyId, nameof(bodycurrencyId), required: false);
            var __workflow_bodywebsite = WorkflowExpression.Compile(bodywebsite, nameof(bodywebsite), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodybillingAddressattention = WorkflowExpression.Compile(bodybillingAddressattention, nameof(bodybillingAddressattention), required: false);
            var __workflow_bodybillingAddressaddress = WorkflowExpression.Compile(bodybillingAddressaddress, nameof(bodybillingAddressaddress), required: false);
            var __workflow_bodybillingAddressstreet2 = WorkflowExpression.Compile(bodybillingAddressstreet2, nameof(bodybillingAddressstreet2), required: false);
            var __workflow_bodybillingAddressstateCode = WorkflowExpression.Compile(bodybillingAddressstateCode, nameof(bodybillingAddressstateCode), required: false);
            var __workflow_bodybillingAddresscity = WorkflowExpression.Compile(bodybillingAddresscity, nameof(bodybillingAddresscity), required: false);
            var __workflow_bodybillingAddressstate = WorkflowExpression.Compile(bodybillingAddressstate, nameof(bodybillingAddressstate), required: false);
            var __workflow_bodybillingAddresszip = WorkflowExpression.Compile(bodybillingAddresszip, nameof(bodybillingAddresszip), required: false);
            var __workflow_bodybillingAddresscountry = WorkflowExpression.Compile(bodybillingAddresscountry, nameof(bodybillingAddresscountry), required: false);
            var __workflow_bodybillingAddressfax = WorkflowExpression.Compile(bodybillingAddressfax, nameof(bodybillingAddressfax), required: false);
            var __workflow_bodybillingAddressphone = WorkflowExpression.Compile(bodybillingAddressphone, nameof(bodybillingAddressphone), required: false);
            var __workflow_bodyshippingAddressattention = WorkflowExpression.Compile(bodyshippingAddressattention, nameof(bodyshippingAddressattention), required: false);
            var __workflow_bodyshippingAddressaddress = WorkflowExpression.Compile(bodyshippingAddressaddress, nameof(bodyshippingAddressaddress), required: false);
            var __workflow_bodyshippingAddressstreet2 = WorkflowExpression.Compile(bodyshippingAddressstreet2, nameof(bodyshippingAddressstreet2), required: false);
            var __workflow_bodyshippingAddressstateCode = WorkflowExpression.Compile(bodyshippingAddressstateCode, nameof(bodyshippingAddressstateCode), required: false);
            var __workflow_bodyshippingAddresscity = WorkflowExpression.Compile(bodyshippingAddresscity, nameof(bodyshippingAddresscity), required: false);
            var __workflow_bodyshippingAddressstate = WorkflowExpression.Compile(bodyshippingAddressstate, nameof(bodyshippingAddressstate), required: false);
            var __workflow_bodyshippingAddresszip = WorkflowExpression.Compile(bodyshippingAddresszip, nameof(bodyshippingAddresszip), required: false);
            var __workflow_bodyshippingAddresscountry = WorkflowExpression.Compile(bodyshippingAddresscountry, nameof(bodyshippingAddresscountry), required: false);
            var __workflow_bodyshippingAddressfax = WorkflowExpression.Compile(bodyshippingAddressfax, nameof(bodyshippingAddressfax), required: false);
            var __workflow_bodyshippingAddressphone = WorkflowExpression.Compile(bodyshippingAddressphone, nameof(bodyshippingAddressphone), required: false);
            var __workflow_bodycontactPersons = WorkflowExpression.Compile(bodycontactPersons, nameof(bodycontactPersons), required: false);
            var __workflow_bodydefaultTemplatesinvoiceTemplateId = WorkflowExpression.Compile(bodydefaultTemplatesinvoiceTemplateId, nameof(bodydefaultTemplatesinvoiceTemplateId), required: false);
            var __workflow_bodydefaultTemplatesinvoiceTemplateName = WorkflowExpression.Compile(bodydefaultTemplatesinvoiceTemplateName, nameof(bodydefaultTemplatesinvoiceTemplateName), required: false);
            var __workflow_bodydefaultTemplatesestimateTemplateId = WorkflowExpression.Compile(bodydefaultTemplatesestimateTemplateId, nameof(bodydefaultTemplatesestimateTemplateId), required: false);
            var __workflow_bodydefaultTemplatesestimateTemplateName = WorkflowExpression.Compile(bodydefaultTemplatesestimateTemplateName, nameof(bodydefaultTemplatesestimateTemplateName), required: false);
            var __workflow_bodydefaultTemplatescreditnoteTemplateId = WorkflowExpression.Compile(bodydefaultTemplatescreditnoteTemplateId, nameof(bodydefaultTemplatescreditnoteTemplateId), required: false);
            var __workflow_bodydefaultTemplatescreditnoteTemplateName = WorkflowExpression.Compile(bodydefaultTemplatescreditnoteTemplateName, nameof(bodydefaultTemplatescreditnoteTemplateName), required: false);
            var __workflow_bodydefaultTemplatesinvoiceEmailTemplateId = WorkflowExpression.Compile(bodydefaultTemplatesinvoiceEmailTemplateId, nameof(bodydefaultTemplatesinvoiceEmailTemplateId), required: false);
            var __workflow_bodydefaultTemplatesinvoiceEmailTemplateName = WorkflowExpression.Compile(bodydefaultTemplatesinvoiceEmailTemplateName, nameof(bodydefaultTemplatesinvoiceEmailTemplateName), required: false);
            var __workflow_bodydefaultTemplatesestimateEmailTemplateId = WorkflowExpression.Compile(bodydefaultTemplatesestimateEmailTemplateId, nameof(bodydefaultTemplatesestimateEmailTemplateId), required: false);
            var __workflow_bodydefaultTemplatesestimateEmailTemplateName = WorkflowExpression.Compile(bodydefaultTemplatesestimateEmailTemplateName, nameof(bodydefaultTemplatesestimateEmailTemplateName), required: false);
            var __workflow_bodydefaultTemplatescreditnoteEmailTemplateId = WorkflowExpression.Compile(bodydefaultTemplatescreditnoteEmailTemplateId, nameof(bodydefaultTemplatescreditnoteEmailTemplateId), required: false);
            var __workflow_bodydefaultTemplatescreditnoteEmailTemplateName = WorkflowExpression.Compile(bodydefaultTemplatescreditnoteEmailTemplateName, nameof(bodydefaultTemplatescreditnoteEmailTemplateName), required: false);
            var __workflow_bodylanguageCode = WorkflowExpression.Compile(bodylanguageCode, nameof(bodylanguageCode), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyvatRegNo = WorkflowExpression.Compile(bodyvatRegNo, nameof(bodyvatRegNo), required: false);
            var __workflow_bodytaxRegNo = WorkflowExpression.Compile(bodytaxRegNo, nameof(bodytaxRegNo), required: false);
            var __workflow_bodycountryCode = WorkflowExpression.Compile(bodycountryCode, nameof(bodycountryCode), required: false);
            var __workflow_bodyvatTreatment = WorkflowExpression.Compile(bodyvatTreatment, nameof(bodyvatTreatment), required: false);
            var __workflow_bodytaxTreatment = WorkflowExpression.Compile(bodytaxTreatment, nameof(bodytaxTreatment), required: false);
            var __workflow_bodytaxRegime = WorkflowExpression.Compile(bodytaxRegime, nameof(bodytaxRegime), required: false);
            var __workflow_bodylegalName = WorkflowExpression.Compile(bodylegalName, nameof(bodylegalName), required: false);
            var __workflow_bodyisTdsRegistered = WorkflowExpression.Compile(bodyisTdsRegistered, nameof(bodyisTdsRegistered), required: false);
            var __workflow_bodyplaceOfContact = WorkflowExpression.Compile(bodyplaceOfContact, nameof(bodyplaceOfContact), required: false);
            var __workflow_bodygstNo = WorkflowExpression.Compile(bodygstNo, nameof(bodygstNo), required: false);
            var __workflow_bodygstTreatment = WorkflowExpression.Compile(bodygstTreatment, nameof(bodygstTreatment), required: false);
            var __workflow_bodytaxAuthorityName = WorkflowExpression.Compile(bodytaxAuthorityName, nameof(bodytaxAuthorityName), required: false);
            var __workflow_bodytaxExemptionCode = WorkflowExpression.Compile(bodytaxExemptionCode, nameof(bodytaxExemptionCode), required: false);
            var __workflow_bodyavataxExemptNo = WorkflowExpression.Compile(bodyavataxExemptNo, nameof(bodyavataxExemptNo), required: false);
            var __workflow_bodyavataxUseCode = WorkflowExpression.Compile(bodyavataxUseCode, nameof(bodyavataxUseCode), required: false);
            var __workflow_bodytaxExemptionId = WorkflowExpression.Compile(bodytaxExemptionId, nameof(bodytaxExemptionId), required: false);
            var __workflow_bodytaxAuthorityId = WorkflowExpression.Compile(bodytaxAuthorityId, nameof(bodytaxAuthorityId), required: false);
            var __workflow_bodytaxId = WorkflowExpression.Compile(bodytaxId, nameof(bodytaxId), required: false);
            var __workflow_bodytdsTaxId = WorkflowExpression.Compile(bodytdsTaxId, nameof(bodytdsTaxId), required: false);
            var __workflow_bodyisTaxable = WorkflowExpression.Compile(bodyisTaxable, nameof(bodyisTaxable), required: false);
            var __workflow_bodyfacebook = WorkflowExpression.Compile(bodyfacebook, nameof(bodyfacebook), required: false);
            var __workflow_bodytwitter = WorkflowExpression.Compile(bodytwitter, nameof(bodytwitter), required: false);
            return new DeferredBodyAction<ContactPutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoice/v3/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["contact_name"] = ExpressionConverter.ConvertO(__workflow_bodycontactName);
                if (__workflow_bodycompanyName != null)
                {
                    body["company_name"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodypaymentTerms != null)
                {
                    body["payment_terms"] = ExpressionConverter.ConvertO(__workflow_bodypaymentTerms);
                    bodypropCount++;
                }

                if (__workflow_bodycurrencyId != null)
                {
                    body["currency_id"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyId);
                    bodypropCount++;
                }

                if (__workflow_bodywebsite != null)
                {
                    body["website"] = ExpressionConverter.ConvertO(__workflow_bodywebsite);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["custom_fields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                var billingAddressObject = new JObject();
                var billingAddressObjectpropCount = 0;
                if (__workflow_bodybillingAddressattention != null)
                {
                    billingAddressObject["attention"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressattention);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddressaddress != null)
                {
                    billingAddressObject["address"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressaddress);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddressstreet2 != null)
                {
                    billingAddressObject["street2"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressstreet2);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddressstateCode != null)
                {
                    billingAddressObject["state_code"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressstateCode);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddresscity != null)
                {
                    billingAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddresscity);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddressstate != null)
                {
                    billingAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressstate);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddresszip != null)
                {
                    billingAddressObject["zip"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddresszip);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddresscountry != null)
                {
                    billingAddressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddresscountry);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddressfax != null)
                {
                    billingAddressObject["fax"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressfax);
                    billingAddressObjectpropCount++;
                }

                if (__workflow_bodybillingAddressphone != null)
                {
                    billingAddressObject["phone"] = ExpressionConverter.ConvertO(__workflow_bodybillingAddressphone);
                    billingAddressObjectpropCount++;
                }

                if (billingAddressObjectpropCount > 0)
                {
                    body["billing_address"] = billingAddressObject;
                    bodypropCount++;
                }

                var shippingAddressObject = new JObject();
                var shippingAddressObjectpropCount = 0;
                if (__workflow_bodyshippingAddressattention != null)
                {
                    shippingAddressObject["attention"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressattention);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddressaddress != null)
                {
                    shippingAddressObject["address"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressaddress);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddressstreet2 != null)
                {
                    shippingAddressObject["street2"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressstreet2);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddressstateCode != null)
                {
                    shippingAddressObject["state_code"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressstateCode);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddresscity != null)
                {
                    shippingAddressObject["city"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddresscity);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddressstate != null)
                {
                    shippingAddressObject["state"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressstate);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddresszip != null)
                {
                    shippingAddressObject["zip"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddresszip);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddresscountry != null)
                {
                    shippingAddressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddresscountry);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddressfax != null)
                {
                    shippingAddressObject["fax"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressfax);
                    shippingAddressObjectpropCount++;
                }

                if (__workflow_bodyshippingAddressphone != null)
                {
                    shippingAddressObject["phone"] = ExpressionConverter.ConvertO(__workflow_bodyshippingAddressphone);
                    shippingAddressObjectpropCount++;
                }

                if (shippingAddressObjectpropCount > 0)
                {
                    body["shipping_address"] = shippingAddressObject;
                    bodypropCount++;
                }

                if (__workflow_bodycontactPersons != null)
                {
                    body["contact_persons"] = ExpressionConverter.ConvertO(__workflow_bodycontactPersons);
                    bodypropCount++;
                }

                var defaultTemplatesObject = new JObject();
                var defaultTemplatesObjectpropCount = 0;
                if (__workflow_bodydefaultTemplatesinvoiceTemplateId != null)
                {
                    defaultTemplatesObject["invoice_template_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesinvoiceTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesinvoiceTemplateName != null)
                {
                    defaultTemplatesObject["invoice_template_name"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesinvoiceTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesestimateTemplateId != null)
                {
                    defaultTemplatesObject["estimate_template_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesestimateTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesestimateTemplateName != null)
                {
                    defaultTemplatesObject["estimate_template_name"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesestimateTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatescreditnoteTemplateId != null)
                {
                    defaultTemplatesObject["creditnote_template_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatescreditnoteTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatescreditnoteTemplateName != null)
                {
                    defaultTemplatesObject["creditnote_template_name"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatescreditnoteTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesinvoiceEmailTemplateId != null)
                {
                    defaultTemplatesObject["invoice_email_template_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesinvoiceEmailTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesinvoiceEmailTemplateName != null)
                {
                    defaultTemplatesObject["invoice_email_template_name"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesinvoiceEmailTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesestimateEmailTemplateId != null)
                {
                    defaultTemplatesObject["estimate_email_template_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesestimateEmailTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatesestimateEmailTemplateName != null)
                {
                    defaultTemplatesObject["estimate_email_template_name"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatesestimateEmailTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatescreditnoteEmailTemplateId != null)
                {
                    defaultTemplatesObject["creditnote_email_template_id"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatescreditnoteEmailTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (__workflow_bodydefaultTemplatescreditnoteEmailTemplateName != null)
                {
                    defaultTemplatesObject["creditnote_email_template_name"] = ExpressionConverter.ConvertO(__workflow_bodydefaultTemplatescreditnoteEmailTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (defaultTemplatesObjectpropCount > 0)
                {
                    body["default_templates"] = defaultTemplatesObject;
                    bodypropCount++;
                }

                if (__workflow_bodylanguageCode != null)
                {
                    body["language_code"] = ExpressionConverter.ConvertO(__workflow_bodylanguageCode);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyvatRegNo != null)
                {
                    body["vat_reg_no"] = ExpressionConverter.ConvertO(__workflow_bodyvatRegNo);
                    bodypropCount++;
                }

                if (__workflow_bodytaxRegNo != null)
                {
                    body["tax_reg_no"] = ExpressionConverter.ConvertO(__workflow_bodytaxRegNo);
                    bodypropCount++;
                }

                if (__workflow_bodycountryCode != null)
                {
                    body["country_code"] = ExpressionConverter.ConvertO(__workflow_bodycountryCode);
                    bodypropCount++;
                }

                if (__workflow_bodyvatTreatment != null)
                {
                    body["vat_treatment"] = ExpressionConverter.ConvertO(__workflow_bodyvatTreatment);
                    bodypropCount++;
                }

                if (__workflow_bodytaxTreatment != null)
                {
                    body["tax_treatment"] = ExpressionConverter.ConvertO(__workflow_bodytaxTreatment);
                    bodypropCount++;
                }

                if (__workflow_bodytaxRegime != null)
                {
                    body["tax_regime"] = ExpressionConverter.ConvertO(__workflow_bodytaxRegime);
                    bodypropCount++;
                }

                if (__workflow_bodylegalName != null)
                {
                    body["legal_name"] = ExpressionConverter.ConvertO(__workflow_bodylegalName);
                    bodypropCount++;
                }

                if (__workflow_bodyisTdsRegistered != null)
                {
                    body["is_tds_registered"] = ExpressionConverter.ConvertO(__workflow_bodyisTdsRegistered);
                    bodypropCount++;
                }

                if (__workflow_bodyplaceOfContact != null)
                {
                    body["place_of_contact"] = ExpressionConverter.ConvertO(__workflow_bodyplaceOfContact);
                    bodypropCount++;
                }

                if (__workflow_bodygstNo != null)
                {
                    body["gst_no"] = ExpressionConverter.ConvertO(__workflow_bodygstNo);
                    bodypropCount++;
                }

                if (__workflow_bodygstTreatment != null)
                {
                    body["gst_treatment"] = ExpressionConverter.ConvertO(__workflow_bodygstTreatment);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAuthorityName != null)
                {
                    body["tax_authority_name"] = ExpressionConverter.ConvertO(__workflow_bodytaxAuthorityName);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptionCode != null)
                {
                    body["tax_exemption_code"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptionCode);
                    bodypropCount++;
                }

                if (__workflow_bodyavataxExemptNo != null)
                {
                    body["avatax_exempt_no"] = ExpressionConverter.ConvertO(__workflow_bodyavataxExemptNo);
                    bodypropCount++;
                }

                if (__workflow_bodyavataxUseCode != null)
                {
                    body["avatax_use_code"] = ExpressionConverter.ConvertO(__workflow_bodyavataxUseCode);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptionId != null)
                {
                    body["tax_exemption_id"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptionId);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAuthorityId != null)
                {
                    body["tax_authority_id"] = ExpressionConverter.ConvertO(__workflow_bodytaxAuthorityId);
                    bodypropCount++;
                }

                if (__workflow_bodytaxId != null)
                {
                    body["tax_id"] = ExpressionConverter.ConvertO(__workflow_bodytaxId);
                    bodypropCount++;
                }

                if (__workflow_bodytdsTaxId != null)
                {
                    body["tds_tax_id"] = ExpressionConverter.ConvertO(__workflow_bodytdsTaxId);
                    bodypropCount++;
                }

                if (__workflow_bodyisTaxable != null)
                {
                    body["is_taxable"] = ExpressionConverter.ConvertO(__workflow_bodyisTaxable);
                    bodypropCount++;
                }

                if (__workflow_bodyfacebook != null)
                {
                    body["facebook"] = ExpressionConverter.ConvertO(__workflow_bodyfacebook);
                    bodypropCount++;
                }

                if (__workflow_bodytwitter != null)
                {
                    body["twitter"] = ExpressionConverter.ConvertO(__workflow_bodytwitter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ContactPutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoicesGetResponse, ApiConnectionActionConfiguration> InvoicesGet(Expression<Func<string>> invoiceNumber = null, Expression<Func<string>> itemName = null, Expression<Func<string>> itemId = null, Expression<Func<string>> itemDescription = null, Expression<Func<string>> referenceNumber = null, Expression<Func<string>> customerName = null, Expression<Func<string>> recurringInvoiceId = null, Expression<Func<string>> email = null, Expression<Func<string>> total = null, Expression<Func<string>> balance = null, Expression<Func<string>> customField = null, Expression<Func<string>> date = null, Expression<Func<string>> dueDate = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> customerId = null, Expression<Func<filterByInput>> filterBy = null, Expression<Func<string>> searchText = null, Expression<Func<sortColumnInput>> sortColumn = null, Expression<Func<string>> zcrmPotentialId = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_invoiceNumber = WorkflowExpression.Compile(invoiceNumber, nameof(invoiceNumber), required: false);
            var __workflow_itemName = WorkflowExpression.Compile(itemName, nameof(itemName), required: false);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: false);
            var __workflow_itemDescription = WorkflowExpression.Compile(itemDescription, nameof(itemDescription), required: false);
            var __workflow_referenceNumber = WorkflowExpression.Compile(referenceNumber, nameof(referenceNumber), required: false);
            var __workflow_customerName = WorkflowExpression.Compile(customerName, nameof(customerName), required: false);
            var __workflow_recurringInvoiceId = WorkflowExpression.Compile(recurringInvoiceId, nameof(recurringInvoiceId), required: false);
            var __workflow_email = WorkflowExpression.Compile(email, nameof(email), required: false);
            var __workflow_total = WorkflowExpression.Compile(total, nameof(total), required: false);
            var __workflow_balance = WorkflowExpression.Compile(balance, nameof(balance), required: false);
            var __workflow_customField = WorkflowExpression.Compile(customField, nameof(customField), required: false);
            var __workflow_date = WorkflowExpression.Compile(date, nameof(date), required: false);
            var __workflow_dueDate = WorkflowExpression.Compile(dueDate, nameof(dueDate), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_customerId = WorkflowExpression.Compile(customerId, nameof(customerId), required: false);
            var __workflow_filterBy = WorkflowExpression.Compile(filterBy, nameof(filterBy), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_sortColumn = WorkflowExpression.Compile(sortColumn, nameof(sortColumn), required: false);
            var __workflow_zcrmPotentialId = WorkflowExpression.Compile(zcrmPotentialId, nameof(zcrmPotentialId), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<InvoicesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invoice/v3/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_invoiceNumber != null)
                    callPayload.Queries["invoice_number"] = ExpressionConverter.Convert(__workflow_invoiceNumber);
                if (__workflow_itemName != null)
                    callPayload.Queries["item_name"] = ExpressionConverter.Convert(__workflow_itemName);
                if (__workflow_itemId != null)
                    callPayload.Queries["item_id"] = ExpressionConverter.Convert(__workflow_itemId);
                if (__workflow_itemDescription != null)
                    callPayload.Queries["item_description"] = ExpressionConverter.Convert(__workflow_itemDescription);
                if (__workflow_referenceNumber != null)
                    callPayload.Queries["reference_number"] = ExpressionConverter.Convert(__workflow_referenceNumber);
                if (__workflow_customerName != null)
                    callPayload.Queries["customer_name"] = ExpressionConverter.Convert(__workflow_customerName);
                if (__workflow_recurringInvoiceId != null)
                    callPayload.Queries["recurring_invoice_id"] = ExpressionConverter.Convert(__workflow_recurringInvoiceId);
                if (__workflow_email != null)
                    callPayload.Queries["email"] = ExpressionConverter.Convert(__workflow_email);
                if (__workflow_total != null)
                    callPayload.Queries["total"] = ExpressionConverter.Convert(__workflow_total);
                if (__workflow_balance != null)
                    callPayload.Queries["balance"] = ExpressionConverter.Convert(__workflow_balance);
                if (__workflow_customField != null)
                    callPayload.Queries["custom_field"] = ExpressionConverter.Convert(__workflow_customField);
                if (__workflow_date != null)
                    callPayload.Queries["date"] = ExpressionConverter.Convert(__workflow_date);
                if (__workflow_dueDate != null)
                    callPayload.Queries["due_date"] = ExpressionConverter.Convert(__workflow_dueDate);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_customerId != null)
                    callPayload.Queries["customer_id"] = ExpressionConverter.Convert(__workflow_customerId);
                if (__workflow_filterBy != null)
                    callPayload.Queries["filter_by"] = ExpressionConverter.Convert(__workflow_filterBy);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                if (__workflow_sortColumn != null)
                    callPayload.Queries["sort_column"] = ExpressionConverter.Convert(__workflow_sortColumn);
                if (__workflow_zcrmPotentialId != null)
                    callPayload.Queries["zcrm_potential_id"] = ExpressionConverter.Convert(__workflow_zcrmPotentialId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_perPage != null)
                    callPayload.Queries["per_page"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<InvoicesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoicePostResponse, ApiConnectionActionConfiguration> Invoice(Expression<Func<bool>> send = null, Expression<Func<bool>> ignoreAutoNumberGeneration = null, Expression<Func<string>> bodycustomerId = null, Expression<Func<int[]>> bodycontactPersons = null, Expression<Func<string>> bodyinvoiceNumber = null, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<string>> bodyplaceOfSupply = null, Expression<Func<string>> bodyvatTreatment = null, Expression<Func<string>> bodygstTreatment = null, Expression<Func<string>> bodytaxTreatment = null, Expression<Func<string>> bodycfdiUsage = null, Expression<Func<string>> bodygstNo = null, Expression<Func<string>> bodytemplateId = null, Expression<Func<string>> bodydate = null, Expression<Func<int>> bodypaymentTerms = null, Expression<Func<string>> bodypaymentTermsLabel = null, Expression<Func<string>> bodydueDate = null, Expression<Func<double>> bodydiscount = null, Expression<Func<bool>> bodyisDiscountBeforeTax = null, Expression<Func<string>> bodydiscountType = null, Expression<Func<bool>> bodyisInclusiveTax = null, Expression<Func<double>> bodyexchangeRate = null, Expression<Func<string>> bodyrecurringInvoiceId = null, Expression<Func<string>> bodyinvoicedEstimateId = null, Expression<Func<string>> bodysalespersonName = null, Expression<Func<bodycustomFieldsInputItem22[]>> bodycustomFields = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<bodylineItemsInputItem[]>> bodylineItems = null, Expression<Func<bodypaymentOptionspaymentGatewaysInputItem[]>> bodypaymentOptionspaymentGateways = null, Expression<Func<bool>> bodyallowPartialPayments = null, Expression<Func<string>> bodycustomBody = null, Expression<Func<string>> bodycustomSubject = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyterms = null, Expression<Func<double>> bodyshippingCharge = null, Expression<Func<double>> bodyadjustment = null, Expression<Func<string>> bodyadjustmentDescription = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodytaxAuthorityId = null, Expression<Func<string>> bodytaxExemptionId = null, Expression<Func<string>> bodyavataxUseCode = null, Expression<Func<string>> bodyavataxTaxCode = null, Expression<Func<string>> bodyavataxExemptNo = null)
        {
            var __workflow_send = WorkflowExpression.Compile(send, nameof(send), required: false);
            var __workflow_ignoreAutoNumberGeneration = WorkflowExpression.Compile(ignoreAutoNumberGeneration, nameof(ignoreAutoNumberGeneration), required: false);
            var __workflow_bodycustomerId = WorkflowExpression.Compile(bodycustomerId, nameof(bodycustomerId), required: false);
            var __workflow_bodycontactPersons = WorkflowExpression.Compile(bodycontactPersons, nameof(bodycontactPersons), required: false);
            var __workflow_bodyinvoiceNumber = WorkflowExpression.Compile(bodyinvoiceNumber, nameof(bodyinvoiceNumber), required: false);
            var __workflow_bodyreferenceNumber = WorkflowExpression.Compile(bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            var __workflow_bodyplaceOfSupply = WorkflowExpression.Compile(bodyplaceOfSupply, nameof(bodyplaceOfSupply), required: false);
            var __workflow_bodyvatTreatment = WorkflowExpression.Compile(bodyvatTreatment, nameof(bodyvatTreatment), required: false);
            var __workflow_bodygstTreatment = WorkflowExpression.Compile(bodygstTreatment, nameof(bodygstTreatment), required: false);
            var __workflow_bodytaxTreatment = WorkflowExpression.Compile(bodytaxTreatment, nameof(bodytaxTreatment), required: false);
            var __workflow_bodycfdiUsage = WorkflowExpression.Compile(bodycfdiUsage, nameof(bodycfdiUsage), required: false);
            var __workflow_bodygstNo = WorkflowExpression.Compile(bodygstNo, nameof(bodygstNo), required: false);
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodypaymentTerms = WorkflowExpression.Compile(bodypaymentTerms, nameof(bodypaymentTerms), required: false);
            var __workflow_bodypaymentTermsLabel = WorkflowExpression.Compile(bodypaymentTermsLabel, nameof(bodypaymentTermsLabel), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodydiscount = WorkflowExpression.Compile(bodydiscount, nameof(bodydiscount), required: false);
            var __workflow_bodyisDiscountBeforeTax = WorkflowExpression.Compile(bodyisDiscountBeforeTax, nameof(bodyisDiscountBeforeTax), required: false);
            var __workflow_bodydiscountType = WorkflowExpression.Compile(bodydiscountType, nameof(bodydiscountType), required: false);
            var __workflow_bodyisInclusiveTax = WorkflowExpression.Compile(bodyisInclusiveTax, nameof(bodyisInclusiveTax), required: false);
            var __workflow_bodyexchangeRate = WorkflowExpression.Compile(bodyexchangeRate, nameof(bodyexchangeRate), required: false);
            var __workflow_bodyrecurringInvoiceId = WorkflowExpression.Compile(bodyrecurringInvoiceId, nameof(bodyrecurringInvoiceId), required: false);
            var __workflow_bodyinvoicedEstimateId = WorkflowExpression.Compile(bodyinvoicedEstimateId, nameof(bodyinvoicedEstimateId), required: false);
            var __workflow_bodysalespersonName = WorkflowExpression.Compile(bodysalespersonName, nameof(bodysalespersonName), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodylineItems = WorkflowExpression.Compile(bodylineItems, nameof(bodylineItems), required: false);
            var __workflow_bodypaymentOptionspaymentGateways = WorkflowExpression.Compile(bodypaymentOptionspaymentGateways, nameof(bodypaymentOptionspaymentGateways), required: false);
            var __workflow_bodyallowPartialPayments = WorkflowExpression.Compile(bodyallowPartialPayments, nameof(bodyallowPartialPayments), required: false);
            var __workflow_bodycustomBody = WorkflowExpression.Compile(bodycustomBody, nameof(bodycustomBody), required: false);
            var __workflow_bodycustomSubject = WorkflowExpression.Compile(bodycustomSubject, nameof(bodycustomSubject), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyterms = WorkflowExpression.Compile(bodyterms, nameof(bodyterms), required: false);
            var __workflow_bodyshippingCharge = WorkflowExpression.Compile(bodyshippingCharge, nameof(bodyshippingCharge), required: false);
            var __workflow_bodyadjustment = WorkflowExpression.Compile(bodyadjustment, nameof(bodyadjustment), required: false);
            var __workflow_bodyadjustmentDescription = WorkflowExpression.Compile(bodyadjustmentDescription, nameof(bodyadjustmentDescription), required: false);
            var __workflow_bodyreason = WorkflowExpression.Compile(bodyreason, nameof(bodyreason), required: false);
            var __workflow_bodytaxAuthorityId = WorkflowExpression.Compile(bodytaxAuthorityId, nameof(bodytaxAuthorityId), required: false);
            var __workflow_bodytaxExemptionId = WorkflowExpression.Compile(bodytaxExemptionId, nameof(bodytaxExemptionId), required: false);
            var __workflow_bodyavataxUseCode = WorkflowExpression.Compile(bodyavataxUseCode, nameof(bodyavataxUseCode), required: false);
            var __workflow_bodyavataxTaxCode = WorkflowExpression.Compile(bodyavataxTaxCode, nameof(bodyavataxTaxCode), required: false);
            var __workflow_bodyavataxExemptNo = WorkflowExpression.Compile(bodyavataxExemptNo, nameof(bodyavataxExemptNo), required: false);
            return new DeferredBodyAction<InvoicePostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/invoice/v3/invoices";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_send != null)
                    callPayload.Queries["send"] = ExpressionConverter.Convert(__workflow_send);
                if (__workflow_ignoreAutoNumberGeneration != null)
                    callPayload.Queries["ignore_auto_number_generation"] = ExpressionConverter.Convert(__workflow_ignoreAutoNumberGeneration);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycustomerId != null)
                {
                    body["customer_id"] = ExpressionConverter.ConvertO(__workflow_bodycustomerId);
                    bodypropCount++;
                }

                if (__workflow_bodycontactPersons != null)
                {
                    body["contact_persons"] = ExpressionConverter.ConvertO(__workflow_bodycontactPersons);
                    bodypropCount++;
                }

                if (__workflow_bodyinvoiceNumber != null)
                {
                    body["invoice_number"] = ExpressionConverter.ConvertO(__workflow_bodyinvoiceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceNumber != null)
                {
                    body["reference_number"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyplaceOfSupply != null)
                {
                    body["place_of_supply"] = ExpressionConverter.ConvertO(__workflow_bodyplaceOfSupply);
                    bodypropCount++;
                }

                if (__workflow_bodyvatTreatment != null)
                {
                    body["vat_treatment"] = ExpressionConverter.ConvertO(__workflow_bodyvatTreatment);
                    bodypropCount++;
                }

                if (__workflow_bodygstTreatment != null)
                {
                    body["gst_treatment"] = ExpressionConverter.ConvertO(__workflow_bodygstTreatment);
                    bodypropCount++;
                }

                if (__workflow_bodytaxTreatment != null)
                {
                    body["tax_treatment"] = ExpressionConverter.ConvertO(__workflow_bodytaxTreatment);
                    bodypropCount++;
                }

                if (__workflow_bodycfdiUsage != null)
                {
                    body["cfdi_usage"] = ExpressionConverter.ConvertO(__workflow_bodycfdiUsage);
                    bodypropCount++;
                }

                if (__workflow_bodygstNo != null)
                {
                    body["gst_no"] = ExpressionConverter.ConvertO(__workflow_bodygstNo);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateId != null)
                {
                    body["template_id"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodypaymentTerms != null)
                {
                    body["payment_terms"] = ExpressionConverter.ConvertO(__workflow_bodypaymentTerms);
                    bodypropCount++;
                }

                if (__workflow_bodypaymentTermsLabel != null)
                {
                    body["payment_terms_label"] = ExpressionConverter.ConvertO(__workflow_bodypaymentTermsLabel);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["due_date"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodydiscount != null)
                {
                    body["discount"] = ExpressionConverter.ConvertO(__workflow_bodydiscount);
                    bodypropCount++;
                }

                if (__workflow_bodyisDiscountBeforeTax != null)
                {
                    body["is_discount_before_tax"] = ExpressionConverter.ConvertO(__workflow_bodyisDiscountBeforeTax);
                    bodypropCount++;
                }

                if (__workflow_bodydiscountType != null)
                {
                    body["discount_type"] = ExpressionConverter.ConvertO(__workflow_bodydiscountType);
                    bodypropCount++;
                }

                if (__workflow_bodyisInclusiveTax != null)
                {
                    body["is_inclusive_tax"] = ExpressionConverter.ConvertO(__workflow_bodyisInclusiveTax);
                    bodypropCount++;
                }

                if (__workflow_bodyexchangeRate != null)
                {
                    body["exchange_rate"] = ExpressionConverter.ConvertO(__workflow_bodyexchangeRate);
                    bodypropCount++;
                }

                if (__workflow_bodyrecurringInvoiceId != null)
                {
                    body["recurring_invoice_id"] = ExpressionConverter.ConvertO(__workflow_bodyrecurringInvoiceId);
                    bodypropCount++;
                }

                if (__workflow_bodyinvoicedEstimateId != null)
                {
                    body["invoiced_estimate_id"] = ExpressionConverter.ConvertO(__workflow_bodyinvoicedEstimateId);
                    bodypropCount++;
                }

                if (__workflow_bodysalespersonName != null)
                {
                    body["salesperson_name"] = ExpressionConverter.ConvertO(__workflow_bodysalespersonName);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["custom_fields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodylineItems != null)
                {
                    body["line_items"] = ExpressionConverter.ConvertO(__workflow_bodylineItems);
                    bodypropCount++;
                }

                var paymentOptionsObject = new JObject();
                var paymentOptionsObjectpropCount = 0;
                if (__workflow_bodypaymentOptionspaymentGateways != null)
                {
                    paymentOptionsObject["payment_gateways"] = ExpressionConverter.ConvertO(__workflow_bodypaymentOptionspaymentGateways);
                    paymentOptionsObjectpropCount++;
                }

                if (paymentOptionsObjectpropCount > 0)
                {
                    body["payment_options"] = paymentOptionsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyallowPartialPayments != null)
                {
                    body["allow_partial_payments"] = ExpressionConverter.ConvertO(__workflow_bodyallowPartialPayments);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBody != null)
                {
                    body["custom_body"] = ExpressionConverter.ConvertO(__workflow_bodycustomBody);
                    bodypropCount++;
                }

                if (__workflow_bodycustomSubject != null)
                {
                    body["custom_subject"] = ExpressionConverter.ConvertO(__workflow_bodycustomSubject);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyterms != null)
                {
                    body["terms"] = ExpressionConverter.ConvertO(__workflow_bodyterms);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingCharge != null)
                {
                    body["shipping_charge"] = ExpressionConverter.ConvertO(__workflow_bodyshippingCharge);
                    bodypropCount++;
                }

                if (__workflow_bodyadjustment != null)
                {
                    body["adjustment"] = ExpressionConverter.ConvertO(__workflow_bodyadjustment);
                    bodypropCount++;
                }

                if (__workflow_bodyadjustmentDescription != null)
                {
                    body["adjustment_description"] = ExpressionConverter.ConvertO(__workflow_bodyadjustmentDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(__workflow_bodyreason);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAuthorityId != null)
                {
                    body["tax_authority_id"] = ExpressionConverter.ConvertO(__workflow_bodytaxAuthorityId);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptionId != null)
                {
                    body["tax_exemption_id"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptionId);
                    bodypropCount++;
                }

                if (__workflow_bodyavataxUseCode != null)
                {
                    body["avatax_use_code"] = ExpressionConverter.ConvertO(__workflow_bodyavataxUseCode);
                    bodypropCount++;
                }

                if (__workflow_bodyavataxTaxCode != null)
                {
                    body["avatax_tax_code"] = ExpressionConverter.ConvertO(__workflow_bodyavataxTaxCode);
                    bodypropCount++;
                }

                if (__workflow_bodyavataxExemptNo != null)
                {
                    body["avatax_exempt_no"] = ExpressionConverter.ConvertO(__workflow_bodyavataxExemptNo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InvoicePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoiceGetResponse, ApiConnectionActionConfiguration> InvoiceGet(Expression<Func<string>> invoiceId)
        {
            var __workflow_invoiceId = WorkflowExpression.Compile(invoiceId, nameof(invoiceId), required: true);
            return new DeferredBodyAction<InvoiceGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoice/v3/invoices/{0}", __workflow_invoiceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InvoiceGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoiceDeleteResponse, ApiConnectionActionConfiguration> InvoiceDelete(Expression<Func<string>> invoiceId)
        {
            var __workflow_invoiceId = WorkflowExpression.Compile(invoiceId, nameof(invoiceId), required: true);
            return new DeferredBodyAction<InvoiceDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoice/v3/invoices/{0}", __workflow_invoiceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InvoiceDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoicePutResponse, ApiConnectionActionConfiguration> InvoicePut(Expression<Func<string>> invoiceId, Expression<Func<string>> bodycustomerId = null, Expression<Func<int[]>> bodycontactPersons = null, Expression<Func<string>> bodyinvoiceNumber = null, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<string>> bodyplaceOfSupply = null, Expression<Func<string>> bodyvatTreatment = null, Expression<Func<string>> bodygstTreatment = null, Expression<Func<string>> bodytaxTreatment = null, Expression<Func<string>> bodycfdiUsage = null, Expression<Func<string>> bodygstNo = null, Expression<Func<string>> bodytemplateId = null, Expression<Func<string>> bodydate = null, Expression<Func<int>> bodypaymentTerms = null, Expression<Func<string>> bodypaymentTermsLabel = null, Expression<Func<string>> bodydueDate = null, Expression<Func<double>> bodydiscount = null, Expression<Func<bool>> bodyisDiscountBeforeTax = null, Expression<Func<string>> bodydiscountType = null, Expression<Func<bool>> bodyisInclusiveTax = null, Expression<Func<double>> bodyexchangeRate = null, Expression<Func<string>> bodyrecurringInvoiceId = null, Expression<Func<string>> bodyinvoicedEstimateId = null, Expression<Func<string>> bodysalespersonName = null, Expression<Func<bodycustomFieldsInputItem22[]>> bodycustomFields = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<bodylineItemsInputItem[]>> bodylineItems = null, Expression<Func<bodypaymentOptionspaymentGatewaysInputItem[]>> bodypaymentOptionspaymentGateways = null, Expression<Func<bool>> bodyallowPartialPayments = null, Expression<Func<string>> bodycustomBody = null, Expression<Func<string>> bodycustomSubject = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyterms = null, Expression<Func<double>> bodyshippingCharge = null, Expression<Func<double>> bodyadjustment = null, Expression<Func<string>> bodyadjustmentDescription = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodytaxAuthorityId = null, Expression<Func<string>> bodytaxExemptionId = null, Expression<Func<string>> bodyavataxUseCode = null, Expression<Func<string>> bodyavataxTaxCode = null, Expression<Func<string>> bodyavataxExemptNo = null)
        {
            var __workflow_invoiceId = WorkflowExpression.Compile(invoiceId, nameof(invoiceId), required: true);
            var __workflow_bodycustomerId = WorkflowExpression.Compile(bodycustomerId, nameof(bodycustomerId), required: false);
            var __workflow_bodycontactPersons = WorkflowExpression.Compile(bodycontactPersons, nameof(bodycontactPersons), required: false);
            var __workflow_bodyinvoiceNumber = WorkflowExpression.Compile(bodyinvoiceNumber, nameof(bodyinvoiceNumber), required: false);
            var __workflow_bodyreferenceNumber = WorkflowExpression.Compile(bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            var __workflow_bodyplaceOfSupply = WorkflowExpression.Compile(bodyplaceOfSupply, nameof(bodyplaceOfSupply), required: false);
            var __workflow_bodyvatTreatment = WorkflowExpression.Compile(bodyvatTreatment, nameof(bodyvatTreatment), required: false);
            var __workflow_bodygstTreatment = WorkflowExpression.Compile(bodygstTreatment, nameof(bodygstTreatment), required: false);
            var __workflow_bodytaxTreatment = WorkflowExpression.Compile(bodytaxTreatment, nameof(bodytaxTreatment), required: false);
            var __workflow_bodycfdiUsage = WorkflowExpression.Compile(bodycfdiUsage, nameof(bodycfdiUsage), required: false);
            var __workflow_bodygstNo = WorkflowExpression.Compile(bodygstNo, nameof(bodygstNo), required: false);
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodypaymentTerms = WorkflowExpression.Compile(bodypaymentTerms, nameof(bodypaymentTerms), required: false);
            var __workflow_bodypaymentTermsLabel = WorkflowExpression.Compile(bodypaymentTermsLabel, nameof(bodypaymentTermsLabel), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodydiscount = WorkflowExpression.Compile(bodydiscount, nameof(bodydiscount), required: false);
            var __workflow_bodyisDiscountBeforeTax = WorkflowExpression.Compile(bodyisDiscountBeforeTax, nameof(bodyisDiscountBeforeTax), required: false);
            var __workflow_bodydiscountType = WorkflowExpression.Compile(bodydiscountType, nameof(bodydiscountType), required: false);
            var __workflow_bodyisInclusiveTax = WorkflowExpression.Compile(bodyisInclusiveTax, nameof(bodyisInclusiveTax), required: false);
            var __workflow_bodyexchangeRate = WorkflowExpression.Compile(bodyexchangeRate, nameof(bodyexchangeRate), required: false);
            var __workflow_bodyrecurringInvoiceId = WorkflowExpression.Compile(bodyrecurringInvoiceId, nameof(bodyrecurringInvoiceId), required: false);
            var __workflow_bodyinvoicedEstimateId = WorkflowExpression.Compile(bodyinvoicedEstimateId, nameof(bodyinvoicedEstimateId), required: false);
            var __workflow_bodysalespersonName = WorkflowExpression.Compile(bodysalespersonName, nameof(bodysalespersonName), required: false);
            var __workflow_bodycustomFields = WorkflowExpression.Compile(bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodyprojectId = WorkflowExpression.Compile(bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodylineItems = WorkflowExpression.Compile(bodylineItems, nameof(bodylineItems), required: false);
            var __workflow_bodypaymentOptionspaymentGateways = WorkflowExpression.Compile(bodypaymentOptionspaymentGateways, nameof(bodypaymentOptionspaymentGateways), required: false);
            var __workflow_bodyallowPartialPayments = WorkflowExpression.Compile(bodyallowPartialPayments, nameof(bodyallowPartialPayments), required: false);
            var __workflow_bodycustomBody = WorkflowExpression.Compile(bodycustomBody, nameof(bodycustomBody), required: false);
            var __workflow_bodycustomSubject = WorkflowExpression.Compile(bodycustomSubject, nameof(bodycustomSubject), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyterms = WorkflowExpression.Compile(bodyterms, nameof(bodyterms), required: false);
            var __workflow_bodyshippingCharge = WorkflowExpression.Compile(bodyshippingCharge, nameof(bodyshippingCharge), required: false);
            var __workflow_bodyadjustment = WorkflowExpression.Compile(bodyadjustment, nameof(bodyadjustment), required: false);
            var __workflow_bodyadjustmentDescription = WorkflowExpression.Compile(bodyadjustmentDescription, nameof(bodyadjustmentDescription), required: false);
            var __workflow_bodyreason = WorkflowExpression.Compile(bodyreason, nameof(bodyreason), required: false);
            var __workflow_bodytaxAuthorityId = WorkflowExpression.Compile(bodytaxAuthorityId, nameof(bodytaxAuthorityId), required: false);
            var __workflow_bodytaxExemptionId = WorkflowExpression.Compile(bodytaxExemptionId, nameof(bodytaxExemptionId), required: false);
            var __workflow_bodyavataxUseCode = WorkflowExpression.Compile(bodyavataxUseCode, nameof(bodyavataxUseCode), required: false);
            var __workflow_bodyavataxTaxCode = WorkflowExpression.Compile(bodyavataxTaxCode, nameof(bodyavataxTaxCode), required: false);
            var __workflow_bodyavataxExemptNo = WorkflowExpression.Compile(bodyavataxExemptNo, nameof(bodyavataxExemptNo), required: false);
            return new DeferredBodyAction<InvoicePutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/invoice/v3/invoices/{0}", __workflow_invoiceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycustomerId != null)
                {
                    body["customer_id"] = ExpressionConverter.ConvertO(__workflow_bodycustomerId);
                    bodypropCount++;
                }

                if (__workflow_bodycontactPersons != null)
                {
                    body["contact_persons"] = ExpressionConverter.ConvertO(__workflow_bodycontactPersons);
                    bodypropCount++;
                }

                if (__workflow_bodyinvoiceNumber != null)
                {
                    body["invoice_number"] = ExpressionConverter.ConvertO(__workflow_bodyinvoiceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceNumber != null)
                {
                    body["reference_number"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyplaceOfSupply != null)
                {
                    body["place_of_supply"] = ExpressionConverter.ConvertO(__workflow_bodyplaceOfSupply);
                    bodypropCount++;
                }

                if (__workflow_bodyvatTreatment != null)
                {
                    body["vat_treatment"] = ExpressionConverter.ConvertO(__workflow_bodyvatTreatment);
                    bodypropCount++;
                }

                if (__workflow_bodygstTreatment != null)
                {
                    body["gst_treatment"] = ExpressionConverter.ConvertO(__workflow_bodygstTreatment);
                    bodypropCount++;
                }

                if (__workflow_bodytaxTreatment != null)
                {
                    body["tax_treatment"] = ExpressionConverter.ConvertO(__workflow_bodytaxTreatment);
                    bodypropCount++;
                }

                if (__workflow_bodycfdiUsage != null)
                {
                    body["cfdi_usage"] = ExpressionConverter.ConvertO(__workflow_bodycfdiUsage);
                    bodypropCount++;
                }

                if (__workflow_bodygstNo != null)
                {
                    body["gst_no"] = ExpressionConverter.ConvertO(__workflow_bodygstNo);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateId != null)
                {
                    body["template_id"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodypaymentTerms != null)
                {
                    body["payment_terms"] = ExpressionConverter.ConvertO(__workflow_bodypaymentTerms);
                    bodypropCount++;
                }

                if (__workflow_bodypaymentTermsLabel != null)
                {
                    body["payment_terms_label"] = ExpressionConverter.ConvertO(__workflow_bodypaymentTermsLabel);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["due_date"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodydiscount != null)
                {
                    body["discount"] = ExpressionConverter.ConvertO(__workflow_bodydiscount);
                    bodypropCount++;
                }

                if (__workflow_bodyisDiscountBeforeTax != null)
                {
                    body["is_discount_before_tax"] = ExpressionConverter.ConvertO(__workflow_bodyisDiscountBeforeTax);
                    bodypropCount++;
                }

                if (__workflow_bodydiscountType != null)
                {
                    body["discount_type"] = ExpressionConverter.ConvertO(__workflow_bodydiscountType);
                    bodypropCount++;
                }

                if (__workflow_bodyisInclusiveTax != null)
                {
                    body["is_inclusive_tax"] = ExpressionConverter.ConvertO(__workflow_bodyisInclusiveTax);
                    bodypropCount++;
                }

                if (__workflow_bodyexchangeRate != null)
                {
                    body["exchange_rate"] = ExpressionConverter.ConvertO(__workflow_bodyexchangeRate);
                    bodypropCount++;
                }

                if (__workflow_bodyrecurringInvoiceId != null)
                {
                    body["recurring_invoice_id"] = ExpressionConverter.ConvertO(__workflow_bodyrecurringInvoiceId);
                    bodypropCount++;
                }

                if (__workflow_bodyinvoicedEstimateId != null)
                {
                    body["invoiced_estimate_id"] = ExpressionConverter.ConvertO(__workflow_bodyinvoicedEstimateId);
                    bodypropCount++;
                }

                if (__workflow_bodysalespersonName != null)
                {
                    body["salesperson_name"] = ExpressionConverter.ConvertO(__workflow_bodysalespersonName);
                    bodypropCount++;
                }

                if (__workflow_bodycustomFields != null)
                {
                    body["custom_fields"] = ExpressionConverter.ConvertO(__workflow_bodycustomFields);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectId != null)
                {
                    body["project_id"] = ExpressionConverter.ConvertO(__workflow_bodyprojectId);
                    bodypropCount++;
                }

                if (__workflow_bodylineItems != null)
                {
                    body["line_items"] = ExpressionConverter.ConvertO(__workflow_bodylineItems);
                    bodypropCount++;
                }

                var paymentOptionsObject = new JObject();
                var paymentOptionsObjectpropCount = 0;
                if (__workflow_bodypaymentOptionspaymentGateways != null)
                {
                    paymentOptionsObject["payment_gateways"] = ExpressionConverter.ConvertO(__workflow_bodypaymentOptionspaymentGateways);
                    paymentOptionsObjectpropCount++;
                }

                if (paymentOptionsObjectpropCount > 0)
                {
                    body["payment_options"] = paymentOptionsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyallowPartialPayments != null)
                {
                    body["allow_partial_payments"] = ExpressionConverter.ConvertO(__workflow_bodyallowPartialPayments);
                    bodypropCount++;
                }

                if (__workflow_bodycustomBody != null)
                {
                    body["custom_body"] = ExpressionConverter.ConvertO(__workflow_bodycustomBody);
                    bodypropCount++;
                }

                if (__workflow_bodycustomSubject != null)
                {
                    body["custom_subject"] = ExpressionConverter.ConvertO(__workflow_bodycustomSubject);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                if (__workflow_bodyterms != null)
                {
                    body["terms"] = ExpressionConverter.ConvertO(__workflow_bodyterms);
                    bodypropCount++;
                }

                if (__workflow_bodyshippingCharge != null)
                {
                    body["shipping_charge"] = ExpressionConverter.ConvertO(__workflow_bodyshippingCharge);
                    bodypropCount++;
                }

                if (__workflow_bodyadjustment != null)
                {
                    body["adjustment"] = ExpressionConverter.ConvertO(__workflow_bodyadjustment);
                    bodypropCount++;
                }

                if (__workflow_bodyadjustmentDescription != null)
                {
                    body["adjustment_description"] = ExpressionConverter.ConvertO(__workflow_bodyadjustmentDescription);
                    bodypropCount++;
                }

                if (__workflow_bodyreason != null)
                {
                    body["reason"] = ExpressionConverter.ConvertO(__workflow_bodyreason);
                    bodypropCount++;
                }

                if (__workflow_bodytaxAuthorityId != null)
                {
                    body["tax_authority_id"] = ExpressionConverter.ConvertO(__workflow_bodytaxAuthorityId);
                    bodypropCount++;
                }

                if (__workflow_bodytaxExemptionId != null)
                {
                    body["tax_exemption_id"] = ExpressionConverter.ConvertO(__workflow_bodytaxExemptionId);
                    bodypropCount++;
                }

                if (__workflow_bodyavataxUseCode != null)
                {
                    body["avatax_use_code"] = ExpressionConverter.ConvertO(__workflow_bodyavataxUseCode);
                    bodypropCount++;
                }

                if (__workflow_bodyavataxTaxCode != null)
                {
                    body["avatax_tax_code"] = ExpressionConverter.ConvertO(__workflow_bodyavataxTaxCode);
                    bodypropCount++;
                }

                if (__workflow_bodyavataxExemptNo != null)
                {
                    body["avatax_exempt_no"] = ExpressionConverter.ConvertO(__workflow_bodyavataxExemptNo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InvoicePutResponse>(callPayload);
            });
        }
    }

    public class ZohoinvoicebasicTriggers([ConnectionName] string connectionId)
    {
    }

    public class ContactsGetResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("contact")]
        public ContactsGetResponseContactTypeItem[] Contact { get; set; }
    }

    public class ContactsGetResponseContactTypeItem
    {
        [JsonProperty("contact_id")]
        public string ContactId { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("payment_terms")]
        public int PaymentTerms { get; set; }

        [JsonProperty("payment_terms_label")]
        public string PaymentTermsLabel { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("outstanding_receivable_amount")]
        public double OutstandingReceivableAmount { get; set; }

        [JsonProperty("unused_credits_receivable_amount")]
        public double UnusedCreditsReceivableAmount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_modified_time")]
        public string LastModifiedTime { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum filterByInput
    {
        [EnumMember(Value = "Status.All")]
        StatusAll,
        [EnumMember(Value = "Status.Sent")]
        StatusSent,
        [EnumMember(Value = "Status.Draft")]
        StatusDraft,
        [EnumMember(Value = "Status.OverDue")]
        StatusOverDue,
        [EnumMember(Value = "Status.Paid")]
        StatusPaid,
        [EnumMember(Value = "Status.Void")]
        StatusVoid,
        [EnumMember(Value = "Status.Unpaid")]
        StatusUnpaid,
        [EnumMember(Value = "Status.PartiallyPaid")]
        StatusPartiallyPaid,
        [EnumMember(Value = "Status.Viewed")]
        StatusViewed,
        [EnumMember(Value = "Date.PaymentExpectedDate")]
        DatePaymentExpectedDate
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortColumnInput
    {
        [EnumMember(Value = "customer_name")]
        CustomerName,
        [EnumMember(Value = "invoice_number")]
        InvoiceNumber,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "due_date")]
        DueDate,
        [EnumMember(Value = "total")]
        Total,
        [EnumMember(Value = "balance")]
        Balance,
        [EnumMember(Value = "created_time")]
        CreatedTime
    }

    public class ContactPostResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("contact")]
        public ContactPostResponseContactType Contact { get; set; }
    }

    public class ContactPostResponseContactType
    {
        [JsonProperty("contact_id")]
        public string ContactId { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("has_transaction")]
        public bool HasTransaction { get; set; }

        [JsonProperty("contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("is_taxable")]
        public bool IsTaxable { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("tds_tax_id")]
        public string TdsTaxId { get; set; }

        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        [JsonProperty("tax_percentage")]
        public int TaxPercentage { get; set; }

        [JsonProperty("tax_authority_id")]
        public string TaxAuthorityId { get; set; }

        [JsonProperty("tax_exemption_id")]
        public string TaxExemptionId { get; set; }

        [JsonProperty("tax_authority_name")]
        public string TaxAuthorityName { get; set; }

        [JsonProperty("tax_exemption_code")]
        public string TaxExemptionCode { get; set; }

        [JsonProperty("place_of_contact")]
        public string PlaceOfContact { get; set; }

        [JsonProperty("gst_no")]
        public string GstNo { get; set; }

        [JsonProperty("vat_treatment")]
        public string VatTreatment { get; set; }

        [JsonProperty("tax_treatment")]
        public string TaxTreatment { get; set; }

        [JsonProperty("tax_regime")]
        public string TaxRegime { get; set; }

        [JsonProperty("legal_name")]
        public string LegalName { get; set; }

        [JsonProperty("is_tds_registered")]
        public bool IsTdsRegistered { get; set; }

        [JsonProperty("gst_treatment")]
        public string GstTreatment { get; set; }

        [JsonProperty("is_linked_with_zohocrm")]
        public bool IsLinkedWithZohocrm { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("primary_contact_id")]
        public string PrimaryContactId { get; set; }

        [JsonProperty("payment_terms")]
        public int PaymentTerms { get; set; }

        [JsonProperty("payment_terms_label")]
        public string PaymentTermsLabel { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("outstanding_receivable_amount")]
        public double OutstandingReceivableAmount { get; set; }

        [JsonProperty("outstanding_receivable_amount_bcy")]
        public double OutstandingReceivableAmountBcy { get; set; }

        [JsonProperty("unused_credits_receivable_amount")]
        public double UnusedCreditsReceivableAmount { get; set; }

        [JsonProperty("unused_credits_receivable_amount_bcy")]
        public double UnusedCreditsReceivableAmountBcy { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("payment_reminder_enabled")]
        public bool PaymentReminderEnabled { get; set; }

        [JsonProperty("custom_fields")]
        public ContactPostResponseContactTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("billing_address")]
        public ContactPostResponseContactTypeBillingAddressType BillingAddress { get; set; }

        [JsonProperty("shipping_address")]
        public ContactPostResponseContactTypeShippingAddressType ShippingAddress { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("contact_persons")]
        public ContactPostResponseContactTypeContactPersonsTypeItem[] ContactPersons { get; set; }

        [JsonProperty("default_templates")]
        public ContactPostResponseContactTypeDefaultTemplatesType DefaultTemplates { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_modified_time")]
        public string LastModifiedTime { get; set; }
    }

    public class ContactPostResponseContactTypeCustomFieldsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class ContactPostResponseContactTypeBillingAddressType
    {
        [JsonProperty("attention")]
        public string Attention { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("street2")]
        public string Street2 { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class ContactPostResponseContactTypeShippingAddressType
    {
        [JsonProperty("attention")]
        public string Attention { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("street2")]
        public string Street2 { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class ContactPostResponseContactTypeContactPersonsTypeItem
    {
        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("is_primary_contact")]
        public bool IsPrimaryContact { get; set; }
    }

    public class ContactPostResponseContactTypeDefaultTemplatesType
    {
        [JsonProperty("invoice_template_id")]
        public string InvoiceTemplateId { get; set; }

        [JsonProperty("invoice_template_name")]
        public string InvoiceTemplateName { get; set; }

        [JsonProperty("estimate_template_id")]
        public string EstimateTemplateId { get; set; }

        [JsonProperty("estimate_template_name")]
        public string EstimateTemplateName { get; set; }

        [JsonProperty("creditnote_template_id")]
        public string CreditnoteTemplateId { get; set; }

        [JsonProperty("creditnote_template_name")]
        public string CreditnoteTemplateName { get; set; }

        [JsonProperty("invoice_email_template_id")]
        public string InvoiceEmailTemplateId { get; set; }

        [JsonProperty("invoice_email_template_name")]
        public string InvoiceEmailTemplateName { get; set; }

        [JsonProperty("estimate_email_template_id")]
        public string EstimateEmailTemplateId { get; set; }

        [JsonProperty("estimate_email_template_name")]
        public string EstimateEmailTemplateName { get; set; }

        [JsonProperty("creditnote_email_template_id")]
        public string CreditnoteEmailTemplateId { get; set; }

        [JsonProperty("creditnote_email_template_name")]
        public string CreditnoteEmailTemplateName { get; set; }
    }

    public class bodycustomFieldsInputItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }

    public class bodycontactPersonsInputItem
    {
        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("is_primary_contact")]
        public bool IsPrimaryContact { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylanguageCodeInput
    {
        [EnumMember(Value = "de")]
        De,
        [EnumMember(Value = "en")]
        En,
        [EnumMember(Value = "es")]
        Es,
        [EnumMember(Value = "fr")]
        Fr,
        [EnumMember(Value = "it")]
        It,
        [EnumMember(Value = "ja")]
        Ja,
        [EnumMember(Value = "nl")]
        Nl,
        [EnumMember(Value = "pt")]
        Pt,
        [EnumMember(Value = "sv")]
        Sv,
        [EnumMember(Value = "zh")]
        Zh
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytaxRegimeInput
    {
        [EnumMember(Value = "general_legal_person")]
        GeneralLegalPerson,
        [EnumMember(Value = "legal_entities_non_profit")]
        LegalEntitiesNonProfit,
        [EnumMember(Value = "resident_abroad")]
        ResidentAbroad,
        [EnumMember(Value = "production_cooperative_societies")]
        ProductionCooperativeSocieties,
        [EnumMember(Value = "agricultural_livestock")]
        AgriculturalLivestock,
        [EnumMember(Value = "optional_group_of_companies")]
        OptionalGroupOfCompanies,
        [EnumMember(Value = "coordinated")]
        Coordinated,
        [EnumMember(Value = "simplified_trust")]
        SimplifiedTrust,
        [EnumMember(Value = "wages_salaries_income")]
        WagesSalariesIncome,
        [EnumMember(Value = "lease")]
        Lease,
        [EnumMember(Value = "property_disposal_acquisition")]
        PropertyDisposalAcquisition,
        [EnumMember(Value = "other_income")]
        OtherIncome,
        [EnumMember(Value = "divident_income")]
        DividentIncome,
        [EnumMember(Value = "individual_business_professional")]
        IndividualBusinessProfessional,
        [EnumMember(Value = "interest_income")]
        InterestIncome,
        [EnumMember(Value = "income_obtaining_price")]
        IncomeObtainingPrice,
        [EnumMember(Value = "no_tax_obligation")]
        NoTaxObligation,
        [EnumMember(Value = "tax_incorporation")]
        TaxIncorporation,
        [EnumMember(Value = "income_through_technology_platform")]
        IncomeThroughTechnologyPlatform
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygstTreatmentInput
    {
        [EnumMember(Value = "business_gst")]
        BusinessGst,
        [EnumMember(Value = "business_none")]
        BusinessNone,
        [EnumMember(Value = "overseas")]
        Overseas,
        [EnumMember(Value = "consumer")]
        Consumer
    }

    public class ContactGetResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("contact")]
        public ContactGetResponseContactType Contact { get; set; }
    }

    public class ContactGetResponseContactType
    {
        [JsonProperty("contact_id")]
        public string ContactId { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("has_transaction")]
        public bool HasTransaction { get; set; }

        [JsonProperty("contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("is_taxable")]
        public bool IsTaxable { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        [JsonProperty("tax_percentage")]
        public int TaxPercentage { get; set; }

        [JsonProperty("tax_authority_id")]
        public string TaxAuthorityId { get; set; }

        [JsonProperty("tax_exemption_id")]
        public string TaxExemptionId { get; set; }

        [JsonProperty("tax_authority_name")]
        public string TaxAuthorityName { get; set; }

        [JsonProperty("tax_exemption_code")]
        public string TaxExemptionCode { get; set; }

        [JsonProperty("place_of_contact")]
        public string PlaceOfContact { get; set; }

        [JsonProperty("gst_no")]
        public string GstNo { get; set; }

        [JsonProperty("vat_treatment")]
        public string VatTreatment { get; set; }

        [JsonProperty("gst_treatment")]
        public string GstTreatment { get; set; }

        [JsonProperty("is_linked_with_zohocrm")]
        public bool IsLinkedWithZohocrm { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("primary_contact_id")]
        public string PrimaryContactId { get; set; }

        [JsonProperty("payment_terms")]
        public int PaymentTerms { get; set; }

        [JsonProperty("payment_terms_label")]
        public string PaymentTermsLabel { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("outstanding_receivable_amount")]
        public double OutstandingReceivableAmount { get; set; }

        [JsonProperty("outstanding_receivable_amount_bcy")]
        public double OutstandingReceivableAmountBcy { get; set; }

        [JsonProperty("unused_credits_receivable_amount")]
        public double UnusedCreditsReceivableAmount { get; set; }

        [JsonProperty("unused_credits_receivable_amount_bcy")]
        public double UnusedCreditsReceivableAmountBcy { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("payment_reminder_enabled")]
        public bool PaymentReminderEnabled { get; set; }

        [JsonProperty("custom_fields")]
        public ContactGetResponseContactTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("billing_address")]
        public ContactGetResponseContactTypeBillingAddressType BillingAddress { get; set; }

        [JsonProperty("shipping_address")]
        public ContactGetResponseContactTypeShippingAddressType ShippingAddress { get; set; }

        [JsonProperty("contact_persons")]
        public ContactGetResponseContactTypeContactPersonsTypeItem[] ContactPersons { get; set; }

        [JsonProperty("default_templates")]
        public ContactGetResponseContactTypeDefaultTemplatesType DefaultTemplates { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_modified_time")]
        public string LastModifiedTime { get; set; }
    }

    public class ContactGetResponseContactTypeCustomFieldsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class ContactGetResponseContactTypeBillingAddressType
    {
        [JsonProperty("attention")]
        public string Attention { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("street2")]
        public string Street2 { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class ContactGetResponseContactTypeShippingAddressType
    {
        [JsonProperty("attention")]
        public string Attention { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("street2")]
        public string Street2 { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class ContactGetResponseContactTypeContactPersonsTypeItem
    {
        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("is_primary_contact")]
        public bool IsPrimaryContact { get; set; }
    }

    public class ContactGetResponseContactTypeDefaultTemplatesType
    {
        [JsonProperty("invoice_template_id")]
        public string InvoiceTemplateId { get; set; }

        [JsonProperty("invoice_template_name")]
        public string InvoiceTemplateName { get; set; }

        [JsonProperty("estimate_template_id")]
        public string EstimateTemplateId { get; set; }

        [JsonProperty("estimate_template_name")]
        public string EstimateTemplateName { get; set; }

        [JsonProperty("creditnote_template_id")]
        public string CreditnoteTemplateId { get; set; }

        [JsonProperty("creditnote_template_name")]
        public string CreditnoteTemplateName { get; set; }

        [JsonProperty("invoice_email_template_id")]
        public string InvoiceEmailTemplateId { get; set; }

        [JsonProperty("invoice_email_template_name")]
        public string InvoiceEmailTemplateName { get; set; }

        [JsonProperty("estimate_email_template_id")]
        public string EstimateEmailTemplateId { get; set; }

        [JsonProperty("estimate_email_template_name")]
        public string EstimateEmailTemplateName { get; set; }

        [JsonProperty("creditnote_email_template_id")]
        public string CreditnoteEmailTemplateId { get; set; }

        [JsonProperty("creditnote_email_template_name")]
        public string CreditnoteEmailTemplateName { get; set; }
    }

    public class ContactDeleteResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ContactPutResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("contact")]
        public ContactPutResponseContactType Contact { get; set; }
    }

    public class ContactPutResponseContactType
    {
        [JsonProperty("contact_id")]
        public string ContactId { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("has_transaction")]
        public bool HasTransaction { get; set; }

        [JsonProperty("contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("is_taxable")]
        public bool IsTaxable { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("tds_tax_id")]
        public string TdsTaxId { get; set; }

        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        [JsonProperty("tax_percentage")]
        public int TaxPercentage { get; set; }

        [JsonProperty("tax_authority_id")]
        public string TaxAuthorityId { get; set; }

        [JsonProperty("tax_exemption_id")]
        public string TaxExemptionId { get; set; }

        [JsonProperty("tax_authority_name")]
        public string TaxAuthorityName { get; set; }

        [JsonProperty("tax_exemption_code")]
        public string TaxExemptionCode { get; set; }

        [JsonProperty("place_of_contact")]
        public string PlaceOfContact { get; set; }

        [JsonProperty("gst_no")]
        public string GstNo { get; set; }

        [JsonProperty("vat_treatment")]
        public string VatTreatment { get; set; }

        [JsonProperty("tax_treatment")]
        public string TaxTreatment { get; set; }

        [JsonProperty("tax_regime")]
        public string TaxRegime { get; set; }

        [JsonProperty("legal_name")]
        public string LegalName { get; set; }

        [JsonProperty("is_tds_registered")]
        public bool IsTdsRegistered { get; set; }

        [JsonProperty("gst_treatment")]
        public string GstTreatment { get; set; }

        [JsonProperty("is_linked_with_zohocrm")]
        public bool IsLinkedWithZohocrm { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("primary_contact_id")]
        public string PrimaryContactId { get; set; }

        [JsonProperty("payment_terms")]
        public int PaymentTerms { get; set; }

        [JsonProperty("payment_terms_label")]
        public string PaymentTermsLabel { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }

        [JsonProperty("outstanding_receivable_amount")]
        public double OutstandingReceivableAmount { get; set; }

        [JsonProperty("outstanding_receivable_amount_bcy")]
        public double OutstandingReceivableAmountBcy { get; set; }

        [JsonProperty("unused_credits_receivable_amount")]
        public double UnusedCreditsReceivableAmount { get; set; }

        [JsonProperty("unused_credits_receivable_amount_bcy")]
        public double UnusedCreditsReceivableAmountBcy { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("payment_reminder_enabled")]
        public bool PaymentReminderEnabled { get; set; }

        [JsonProperty("custom_fields")]
        public ContactPutResponseContactTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("billing_address")]
        public ContactPutResponseContactTypeBillingAddressType BillingAddress { get; set; }

        [JsonProperty("shipping_address")]
        public ContactPutResponseContactTypeShippingAddressType ShippingAddress { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("contact_persons")]
        public ContactPutResponseContactTypeContactPersonsTypeItem[] ContactPersons { get; set; }

        [JsonProperty("default_templates")]
        public ContactPutResponseContactTypeDefaultTemplatesType DefaultTemplates { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_modified_time")]
        public string LastModifiedTime { get; set; }
    }

    public class ContactPutResponseContactTypeCustomFieldsTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class ContactPutResponseContactTypeBillingAddressType
    {
        [JsonProperty("attention")]
        public string Attention { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("street2")]
        public string Street2 { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class ContactPutResponseContactTypeShippingAddressType
    {
        [JsonProperty("attention")]
        public string Attention { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("street2")]
        public string Street2 { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }
    }

    public class ContactPutResponseContactTypeContactPersonsTypeItem
    {
        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("is_primary_contact")]
        public bool IsPrimaryContact { get; set; }
    }

    public class ContactPutResponseContactTypeDefaultTemplatesType
    {
        [JsonProperty("invoice_template_id")]
        public string InvoiceTemplateId { get; set; }

        [JsonProperty("invoice_template_name")]
        public string InvoiceTemplateName { get; set; }

        [JsonProperty("estimate_template_id")]
        public string EstimateTemplateId { get; set; }

        [JsonProperty("estimate_template_name")]
        public string EstimateTemplateName { get; set; }

        [JsonProperty("creditnote_template_id")]
        public string CreditnoteTemplateId { get; set; }

        [JsonProperty("creditnote_template_name")]
        public string CreditnoteTemplateName { get; set; }

        [JsonProperty("invoice_email_template_id")]
        public string InvoiceEmailTemplateId { get; set; }

        [JsonProperty("invoice_email_template_name")]
        public string InvoiceEmailTemplateName { get; set; }

        [JsonProperty("estimate_email_template_id")]
        public string EstimateEmailTemplateId { get; set; }

        [JsonProperty("estimate_email_template_name")]
        public string EstimateEmailTemplateName { get; set; }

        [JsonProperty("creditnote_email_template_id")]
        public string CreditnoteEmailTemplateId { get; set; }

        [JsonProperty("creditnote_email_template_name")]
        public string CreditnoteEmailTemplateName { get; set; }
    }

    public class bodycustomFieldsInputItem2
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyvatTreatmentInput
    {
        [EnumMember(Value = "uk")]
        Uk,
        [EnumMember(Value = "eu_vat_registered")]
        EuVatRegistered,
        [EnumMember(Value = "overseas")]
        Overseas,
        [EnumMember(Value = "home_country_mexico")]
        HomeCountryMexico,
        [EnumMember(Value = "border_region_mexico")]
        BorderRegionMexico,
        [EnumMember(Value = "non_mexico")]
        NonMexico
    }

    public class InvoicesGetResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("invoices")]
        public InvoicesGetResponseInvoicesTypeItem[] Invoices { get; set; }
    }

    public class InvoicesGetResponseInvoicesTypeItem
    {
        [JsonProperty("invoice_id")]
        public string InvoiceId { get; set; }

        [JsonProperty("ach_payment_initiated")]
        public bool AchPaymentInitiated { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("is_pre_gst")]
        public bool IsPreGst { get; set; }

        [JsonProperty("place_of_supply")]
        public string PlaceOfSupply { get; set; }

        [JsonProperty("gst_no")]
        public string GstNo { get; set; }

        [JsonProperty("gst_treatment")]
        public string GstTreatment { get; set; }

        [JsonProperty("tax_treatment")]
        public string TaxTreatment { get; set; }

        [JsonProperty("cfdi_usage")]
        public string CfdiUsage { get; set; }

        [JsonProperty("vat_treatment")]
        public string VatTreatment { get; set; }

        [JsonProperty("vat_reg_no")]
        public string VatRegNo { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("payment_terms")]
        public int PaymentTerms { get; set; }

        [JsonProperty("payment_terms_label")]
        public string PaymentTermsLabel { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("payment_expected_date")]
        public string PaymentExpectedDate { get; set; }

        [JsonProperty("last_payment_date")]
        public string LastPaymentDate { get; set; }

        [JsonProperty("reference_number")]
        public string ReferenceNumber { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("contact_persons")]
        public string[] ContactPersons { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("exchange_rate")]
        public double ExchangeRate { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("is_discount_before_tax")]
        public bool IsDiscountBeforeTax { get; set; }

        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }

        [JsonProperty("is_inclusive_tax")]
        public bool IsInclusiveTax { get; set; }

        [JsonProperty("recurring_invoice_id")]
        public string RecurringInvoiceId { get; set; }

        [JsonProperty("is_viewed_by_client")]
        public bool IsViewedByClient { get; set; }

        [JsonProperty("has_attachment")]
        public bool HasAttachment { get; set; }

        [JsonProperty("client_viewed_time")]
        public string ClientViewedTime { get; set; }

        [JsonProperty("line_items")]
        public InvoicesGetResponseInvoicesTypeItemLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("shipping_charge")]
        public double ShippingCharge { get; set; }

        [JsonProperty("adjustment")]
        public double Adjustment { get; set; }

        [JsonProperty("adjustment_description")]
        public string AdjustmentDescription { get; set; }

        [JsonProperty("sub_total")]
        public double SubTotal { get; set; }

        [JsonProperty("tax_total")]
        public double TaxTotal { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("taxes")]
        public InvoicesGetResponseInvoicesTypeItemTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("payment_reminder_enabled")]
        public bool PaymentReminderEnabled { get; set; }

        [JsonProperty("payment_made")]
        public double PaymentMade { get; set; }

        [JsonProperty("credits_applied")]
        public double CreditsApplied { get; set; }

        [JsonProperty("tax_amount_withheld")]
        public double TaxAmountWithheld { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("write_off_amount")]
        public double WriteOffAmount { get; set; }

        [JsonProperty("allow_partial_payments")]
        public bool AllowPartialPayments { get; set; }

        [JsonProperty("price_precision")]
        public int PricePrecision { get; set; }

        [JsonProperty("payment_options")]
        public InvoicesGetResponseInvoicesTypeItemPaymentOptionsType PaymentOptions { get; set; }

        [JsonProperty("is_emailed")]
        public bool IsEmailed { get; set; }

        [JsonProperty("reminders_sent")]
        public int RemindersSent { get; set; }

        [JsonProperty("last_reminder_sent_date")]
        public string LastReminderSentDate { get; set; }

        [JsonProperty("billing_address")]
        public InvoicesGetResponseInvoicesTypeItemBillingAddressType BillingAddress { get; set; }

        [JsonProperty("shipping_address")]
        public InvoicesGetResponseInvoicesTypeItemShippingAddressType ShippingAddress { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("custom_fields")]
        public InvoicesGetResponseInvoicesTypeItemCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("template_name")]
        public string TemplateName { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_modified_time")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("attachment_name")]
        public string AttachmentName { get; set; }

        [JsonProperty("can_send_in_mail")]
        public bool CanSendInMail { get; set; }

        [JsonProperty("salesperson_id")]
        public string SalespersonId { get; set; }

        [JsonProperty("salesperson_name")]
        public string SalespersonName { get; set; }

        [JsonProperty("invoice_url")]
        public string InvoiceUrl { get; set; }
    }

    public class InvoicesGetResponseInvoicesTypeItemLineItemsTypeItem
    {
        [JsonProperty("line_item_id")]
        public string LineItemId { get; set; }

        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("time_entry_ids")]
        public int[] TimeEntryIds { get; set; }

        [JsonProperty("expense_id")]
        public string ExpenseId { get; set; }

        [JsonProperty("expense_receipt_name")]
        public string ExpenseReceiptName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("item_order")]
        public int ItemOrder { get; set; }

        [JsonProperty("bcy_rate")]
        public double BcyRate { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("discount_amount")]
        public double DiscountAmount { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("tds_tax_id")]
        public string TdsTaxId { get; set; }

        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        [JsonProperty("tax_type")]
        public string TaxType { get; set; }

        [JsonProperty("tax_percentage")]
        public double TaxPercentage { get; set; }

        [JsonProperty("item_total")]
        public double ItemTotal { get; set; }

        [JsonProperty("sat_item_key_code")]
        public int SatItemKeyCode { get; set; }

        [JsonProperty("unitkey_code")]
        public string UnitkeyCode { get; set; }
    }

    public class InvoicesGetResponseInvoicesTypeItemTaxesTypeItem
    {
        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        [JsonProperty("tax_amount")]
        public double TaxAmount { get; set; }
    }

    public class InvoicesGetResponseInvoicesTypeItemPaymentOptionsType
    {
        [JsonProperty("payment_gateways")]
        public InvoicesGetResponseInvoicesTypeItemPaymentOptionsTypePaymentGatewaysTypeItem[] PaymentGateways { get; set; }
    }

    public class InvoicesGetResponseInvoicesTypeItemPaymentOptionsTypePaymentGatewaysTypeItem
    {
        [JsonProperty("configured")]
        public bool Configured { get; set; }

        [JsonProperty("additional_field1")]
        public string AdditionalField1 { get; set; }

        [JsonProperty("gateway_name")]
        public string GatewayName { get; set; }
    }

    public class InvoicesGetResponseInvoicesTypeItemBillingAddressType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }
    }

    public class InvoicesGetResponseInvoicesTypeItemShippingAddressType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }
    }

    public class InvoicesGetResponseInvoicesTypeItemCustomFieldsTypeItem
    {
        [JsonProperty("customfield_id")]
        public string CustomfieldId { get; set; }

        [JsonProperty("data_type")]
        public string DataType { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("show_on_pdf")]
        public bool ShowOnPdf { get; set; }

        [JsonProperty("show_in_all_pdf")]
        public bool ShowInAllPdf { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum statusInput
    {
        [EnumMember(Value = "sent")]
        Sent,
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "overdue")]
        Overdue,
        [EnumMember(Value = "paid")]
        Paid,
        [EnumMember(Value = "void")]
        Void,
        [EnumMember(Value = "unpaid")]
        Unpaid,
        [EnumMember(Value = "partially_paid")]
        PartiallyPaid,
        [EnumMember(Value = "viewed")]
        Viewed
    }

    public class InvoicePostResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("invoice")]
        public InvoicePostResponseInvoiceType Invoice { get; set; }
    }

    public class InvoicePostResponseInvoiceType
    {
        [JsonProperty("invoice_id")]
        public string InvoiceId { get; set; }

        [JsonProperty("ach_payment_initiated")]
        public bool AchPaymentInitiated { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("is_pre_gst")]
        public bool IsPreGst { get; set; }

        [JsonProperty("place_of_supply")]
        public string PlaceOfSupply { get; set; }

        [JsonProperty("gst_no")]
        public string GstNo { get; set; }

        [JsonProperty("gst_treatment")]
        public string GstTreatment { get; set; }

        [JsonProperty("tax_treatment")]
        public string TaxTreatment { get; set; }

        [JsonProperty("cfdi_usage")]
        public string CfdiUsage { get; set; }

        [JsonProperty("vat_treatment")]
        public string VatTreatment { get; set; }

        [JsonProperty("vat_reg_no")]
        public string VatRegNo { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("payment_terms")]
        public int PaymentTerms { get; set; }

        [JsonProperty("payment_terms_label")]
        public string PaymentTermsLabel { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("payment_expected_date")]
        public string PaymentExpectedDate { get; set; }

        [JsonProperty("last_payment_date")]
        public string LastPaymentDate { get; set; }

        [JsonProperty("reference_number")]
        public string ReferenceNumber { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("contact_persons")]
        public string[] ContactPersons { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("exchange_rate")]
        public double ExchangeRate { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("is_discount_before_tax")]
        public bool IsDiscountBeforeTax { get; set; }

        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }

        [JsonProperty("is_inclusive_tax")]
        public bool IsInclusiveTax { get; set; }

        [JsonProperty("recurring_invoice_id")]
        public string RecurringInvoiceId { get; set; }

        [JsonProperty("is_viewed_by_client")]
        public bool IsViewedByClient { get; set; }

        [JsonProperty("has_attachment")]
        public bool HasAttachment { get; set; }

        [JsonProperty("client_viewed_time")]
        public string ClientViewedTime { get; set; }

        [JsonProperty("line_items")]
        public InvoicePostResponseInvoiceTypeLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("shipping_charge")]
        public double ShippingCharge { get; set; }

        [JsonProperty("adjustment")]
        public double Adjustment { get; set; }

        [JsonProperty("adjustment_description")]
        public string AdjustmentDescription { get; set; }

        [JsonProperty("sub_total")]
        public double SubTotal { get; set; }

        [JsonProperty("tax_total")]
        public double TaxTotal { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("taxes")]
        public InvoicePostResponseInvoiceTypeTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("payment_reminder_enabled")]
        public bool PaymentReminderEnabled { get; set; }

        [JsonProperty("payment_made")]
        public double PaymentMade { get; set; }

        [JsonProperty("credits_applied")]
        public double CreditsApplied { get; set; }

        [JsonProperty("tax_amount_withheld")]
        public double TaxAmountWithheld { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("write_off_amount")]
        public double WriteOffAmount { get; set; }

        [JsonProperty("allow_partial_payments")]
        public bool AllowPartialPayments { get; set; }

        [JsonProperty("price_precision")]
        public int PricePrecision { get; set; }

        [JsonProperty("payment_options")]
        public InvoicePostResponseInvoiceTypePaymentOptionsType PaymentOptions { get; set; }

        [JsonProperty("is_emailed")]
        public bool IsEmailed { get; set; }

        [JsonProperty("reminders_sent")]
        public int RemindersSent { get; set; }

        [JsonProperty("last_reminder_sent_date")]
        public string LastReminderSentDate { get; set; }

        [JsonProperty("billing_address")]
        public InvoicePostResponseInvoiceTypeBillingAddressType BillingAddress { get; set; }

        [JsonProperty("shipping_address")]
        public InvoicePostResponseInvoiceTypeShippingAddressType ShippingAddress { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("custom_fields")]
        public InvoicePostResponseInvoiceTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("template_name")]
        public string TemplateName { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_modified_time")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("attachment_name")]
        public string AttachmentName { get; set; }

        [JsonProperty("can_send_in_mail")]
        public bool CanSendInMail { get; set; }

        [JsonProperty("salesperson_id")]
        public string SalespersonId { get; set; }

        [JsonProperty("salesperson_name")]
        public string SalespersonName { get; set; }

        [JsonProperty("invoice_url")]
        public string InvoiceUrl { get; set; }
    }

    public class InvoicePostResponseInvoiceTypeLineItemsTypeItem
    {
        [JsonProperty("line_item_id")]
        public string LineItemId { get; set; }

        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("time_entry_ids")]
        public int[] TimeEntryIds { get; set; }

        [JsonProperty("expense_id")]
        public string ExpenseId { get; set; }

        [JsonProperty("expense_receipt_name")]
        public string ExpenseReceiptName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("item_order")]
        public int ItemOrder { get; set; }

        [JsonProperty("bcy_rate")]
        public double BcyRate { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("discount_amount")]
        public double DiscountAmount { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("tds_tax_id")]
        public string TdsTaxId { get; set; }

        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        [JsonProperty("tax_type")]
        public string TaxType { get; set; }

        [JsonProperty("tax_percentage")]
        public double TaxPercentage { get; set; }

        [JsonProperty("item_total")]
        public double ItemTotal { get; set; }

        [JsonProperty("sat_item_key_code")]
        public int SatItemKeyCode { get; set; }

        [JsonProperty("unitkey_code")]
        public string UnitkeyCode { get; set; }
    }

    public class InvoicePostResponseInvoiceTypeTaxesTypeItem
    {
        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        [JsonProperty("tax_amount")]
        public double TaxAmount { get; set; }
    }

    public class InvoicePostResponseInvoiceTypePaymentOptionsType
    {
        [JsonProperty("payment_gateways")]
        public InvoicePostResponseInvoiceTypePaymentOptionsTypePaymentGatewaysTypeItem[] PaymentGateways { get; set; }
    }

    public class InvoicePostResponseInvoiceTypePaymentOptionsTypePaymentGatewaysTypeItem
    {
        [JsonProperty("configured")]
        public bool Configured { get; set; }

        [JsonProperty("additional_field1")]
        public string AdditionalField1 { get; set; }

        [JsonProperty("gateway_name")]
        public string GatewayName { get; set; }
    }

    public class InvoicePostResponseInvoiceTypeBillingAddressType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }
    }

    public class InvoicePostResponseInvoiceTypeShippingAddressType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }
    }

    public class InvoicePostResponseInvoiceTypeCustomFieldsTypeItem
    {
        [JsonProperty("customfield_id")]
        public string CustomfieldId { get; set; }

        [JsonProperty("data_type")]
        public string DataType { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("show_on_pdf")]
        public bool ShowOnPdf { get; set; }

        [JsonProperty("show_in_all_pdf")]
        public bool ShowInAllPdf { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class bodycustomFieldsInputItem22
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class bodylineItemsInputItem
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("time_entry_ids")]
        public int[] TimeEntryIds { get; set; }

        [JsonProperty("expense_id")]
        public string ExpenseId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("hsn_or_sac")]
        public int HsnOrSac { get; set; }

        [JsonProperty("sat_item_key_code")]
        public int SatItemKeyCode { get; set; }

        [JsonProperty("unitkey_code")]
        public string UnitkeyCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("item_order")]
        public int ItemOrder { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("tds_tax_id")]
        public string TdsTaxId { get; set; }

        [JsonProperty("tax_exemption_id")]
        public string TaxExemptionId { get; set; }

        [JsonProperty("avatax_use_code")]
        public string AvataxUseCode { get; set; }

        [JsonProperty("avatax_exempt_no")]
        public string AvataxExemptNo { get; set; }

        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        [JsonProperty("tax_type")]
        public string TaxType { get; set; }

        [JsonProperty("tax_percentage")]
        public double TaxPercentage { get; set; }

        [JsonProperty("item_total")]
        public double ItemTotal { get; set; }
    }

    public class bodypaymentOptionspaymentGatewaysInputItem
    {
        [JsonProperty("configured")]
        public bool Configured { get; set; }

        [JsonProperty("additional_field1")]
        public string AdditionalField1 { get; set; }

        [JsonProperty("gateway_name")]
        public string GatewayName { get; set; }
    }

    public class InvoiceGetResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("invoice")]
        public InvoiceGetResponseInvoiceType Invoice { get; set; }
    }

    public class InvoiceGetResponseInvoiceType
    {
        [JsonProperty("invoice_id")]
        public string InvoiceId { get; set; }

        [JsonProperty("ach_payment_initiated")]
        public bool AchPaymentInitiated { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("is_pre_gst")]
        public bool IsPreGst { get; set; }

        [JsonProperty("place_of_supply")]
        public string PlaceOfSupply { get; set; }

        [JsonProperty("gst_no")]
        public string GstNo { get; set; }

        [JsonProperty("gst_treatment")]
        public string GstTreatment { get; set; }

        [JsonProperty("tax_treatment")]
        public string TaxTreatment { get; set; }

        [JsonProperty("cfdi_usage")]
        public string CfdiUsage { get; set; }

        [JsonProperty("vat_treatment")]
        public string VatTreatment { get; set; }

        [JsonProperty("vat_reg_no")]
        public string VatRegNo { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("payment_terms")]
        public int PaymentTerms { get; set; }

        [JsonProperty("payment_terms_label")]
        public string PaymentTermsLabel { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("payment_expected_date")]
        public string PaymentExpectedDate { get; set; }

        [JsonProperty("last_payment_date")]
        public string LastPaymentDate { get; set; }

        [JsonProperty("reference_number")]
        public string ReferenceNumber { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("contact_persons")]
        public string[] ContactPersons { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("exchange_rate")]
        public double ExchangeRate { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("is_discount_before_tax")]
        public bool IsDiscountBeforeTax { get; set; }

        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }

        [JsonProperty("is_inclusive_tax")]
        public bool IsInclusiveTax { get; set; }

        [JsonProperty("recurring_invoice_id")]
        public string RecurringInvoiceId { get; set; }

        [JsonProperty("is_viewed_by_client")]
        public bool IsViewedByClient { get; set; }

        [JsonProperty("has_attachment")]
        public bool HasAttachment { get; set; }

        [JsonProperty("client_viewed_time")]
        public string ClientViewedTime { get; set; }

        [JsonProperty("line_items")]
        public InvoiceGetResponseInvoiceTypeLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("shipping_charge")]
        public double ShippingCharge { get; set; }

        [JsonProperty("adjustment")]
        public double Adjustment { get; set; }

        [JsonProperty("adjustment_description")]
        public string AdjustmentDescription { get; set; }

        [JsonProperty("sub_total")]
        public double SubTotal { get; set; }

        [JsonProperty("tax_total")]
        public double TaxTotal { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("taxes")]
        public InvoiceGetResponseInvoiceTypeTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("payment_reminder_enabled")]
        public bool PaymentReminderEnabled { get; set; }

        [JsonProperty("payment_made")]
        public double PaymentMade { get; set; }

        [JsonProperty("credits_applied")]
        public double CreditsApplied { get; set; }

        [JsonProperty("tax_amount_withheld")]
        public double TaxAmountWithheld { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("write_off_amount")]
        public double WriteOffAmount { get; set; }

        [JsonProperty("allow_partial_payments")]
        public bool AllowPartialPayments { get; set; }

        [JsonProperty("price_precision")]
        public int PricePrecision { get; set; }

        [JsonProperty("payment_options")]
        public InvoiceGetResponseInvoiceTypePaymentOptionsType PaymentOptions { get; set; }

        [JsonProperty("is_emailed")]
        public bool IsEmailed { get; set; }

        [JsonProperty("reminders_sent")]
        public int RemindersSent { get; set; }

        [JsonProperty("last_reminder_sent_date")]
        public string LastReminderSentDate { get; set; }

        [JsonProperty("billing_address")]
        public InvoiceGetResponseInvoiceTypeBillingAddressType BillingAddress { get; set; }

        [JsonProperty("shipping_address")]
        public InvoiceGetResponseInvoiceTypeShippingAddressType ShippingAddress { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("custom_fields")]
        public InvoiceGetResponseInvoiceTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("template_name")]
        public string TemplateName { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_modified_time")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("attachment_name")]
        public string AttachmentName { get; set; }

        [JsonProperty("can_send_in_mail")]
        public bool CanSendInMail { get; set; }

        [JsonProperty("salesperson_id")]
        public string SalespersonId { get; set; }

        [JsonProperty("salesperson_name")]
        public string SalespersonName { get; set; }

        [JsonProperty("invoice_url")]
        public string InvoiceUrl { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypeLineItemsTypeItem
    {
        [JsonProperty("line_item_id")]
        public string LineItemId { get; set; }

        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("time_entry_ids")]
        public int[] TimeEntryIds { get; set; }

        [JsonProperty("expense_id")]
        public string ExpenseId { get; set; }

        [JsonProperty("expense_receipt_name")]
        public string ExpenseReceiptName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("item_order")]
        public int ItemOrder { get; set; }

        [JsonProperty("bcy_rate")]
        public double BcyRate { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("discount_amount")]
        public double DiscountAmount { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("tds_tax_id")]
        public string TdsTaxId { get; set; }

        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        [JsonProperty("tax_type")]
        public string TaxType { get; set; }

        [JsonProperty("tax_percentage")]
        public double TaxPercentage { get; set; }

        [JsonProperty("item_total")]
        public double ItemTotal { get; set; }

        [JsonProperty("sat_item_key_code")]
        public int SatItemKeyCode { get; set; }

        [JsonProperty("unitkey_code")]
        public string UnitkeyCode { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypeTaxesTypeItem
    {
        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        [JsonProperty("tax_amount")]
        public double TaxAmount { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypePaymentOptionsType
    {
        [JsonProperty("payment_gateways")]
        public InvoiceGetResponseInvoiceTypePaymentOptionsTypePaymentGatewaysTypeItem[] PaymentGateways { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypePaymentOptionsTypePaymentGatewaysTypeItem
    {
        [JsonProperty("configured")]
        public bool Configured { get; set; }

        [JsonProperty("additional_field1")]
        public string AdditionalField1 { get; set; }

        [JsonProperty("gateway_name")]
        public string GatewayName { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypeBillingAddressType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypeShippingAddressType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }
    }

    public class InvoiceGetResponseInvoiceTypeCustomFieldsTypeItem
    {
        [JsonProperty("customfield_id")]
        public string CustomfieldId { get; set; }

        [JsonProperty("data_type")]
        public string DataType { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("show_on_pdf")]
        public bool ShowOnPdf { get; set; }

        [JsonProperty("show_in_all_pdf")]
        public bool ShowInAllPdf { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class InvoiceDeleteResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class InvoicePutResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("invoice")]
        public InvoicePutResponseInvoiceType Invoice { get; set; }
    }

    public class InvoicePutResponseInvoiceType
    {
        [JsonProperty("invoice_id")]
        public string InvoiceId { get; set; }

        [JsonProperty("ach_payment_initiated")]
        public bool AchPaymentInitiated { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("is_pre_gst")]
        public bool IsPreGst { get; set; }

        [JsonProperty("place_of_supply")]
        public string PlaceOfSupply { get; set; }

        [JsonProperty("gst_no")]
        public string GstNo { get; set; }

        [JsonProperty("gst_treatment")]
        public string GstTreatment { get; set; }

        [JsonProperty("tax_treatment")]
        public string TaxTreatment { get; set; }

        [JsonProperty("cfdi_usage")]
        public string CfdiUsage { get; set; }

        [JsonProperty("vat_treatment")]
        public string VatTreatment { get; set; }

        [JsonProperty("vat_reg_no")]
        public string VatRegNo { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("payment_terms")]
        public int PaymentTerms { get; set; }

        [JsonProperty("payment_terms_label")]
        public string PaymentTermsLabel { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("payment_expected_date")]
        public string PaymentExpectedDate { get; set; }

        [JsonProperty("last_payment_date")]
        public string LastPaymentDate { get; set; }

        [JsonProperty("reference_number")]
        public string ReferenceNumber { get; set; }

        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }

        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }

        [JsonProperty("contact_persons")]
        public string[] ContactPersons { get; set; }

        [JsonProperty("currency_id")]
        public string CurrencyId { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("exchange_rate")]
        public double ExchangeRate { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("is_discount_before_tax")]
        public bool IsDiscountBeforeTax { get; set; }

        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }

        [JsonProperty("is_inclusive_tax")]
        public bool IsInclusiveTax { get; set; }

        [JsonProperty("recurring_invoice_id")]
        public string RecurringInvoiceId { get; set; }

        [JsonProperty("is_viewed_by_client")]
        public bool IsViewedByClient { get; set; }

        [JsonProperty("has_attachment")]
        public bool HasAttachment { get; set; }

        [JsonProperty("client_viewed_time")]
        public string ClientViewedTime { get; set; }

        [JsonProperty("line_items")]
        public InvoicePutResponseInvoiceTypeLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("shipping_charge")]
        public double ShippingCharge { get; set; }

        [JsonProperty("adjustment")]
        public double Adjustment { get; set; }

        [JsonProperty("adjustment_description")]
        public string AdjustmentDescription { get; set; }

        [JsonProperty("sub_total")]
        public double SubTotal { get; set; }

        [JsonProperty("tax_total")]
        public double TaxTotal { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("taxes")]
        public InvoicePutResponseInvoiceTypeTaxesTypeItem[] Taxes { get; set; }

        [JsonProperty("payment_reminder_enabled")]
        public bool PaymentReminderEnabled { get; set; }

        [JsonProperty("payment_made")]
        public double PaymentMade { get; set; }

        [JsonProperty("credits_applied")]
        public double CreditsApplied { get; set; }

        [JsonProperty("tax_amount_withheld")]
        public double TaxAmountWithheld { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("write_off_amount")]
        public double WriteOffAmount { get; set; }

        [JsonProperty("allow_partial_payments")]
        public bool AllowPartialPayments { get; set; }

        [JsonProperty("price_precision")]
        public int PricePrecision { get; set; }

        [JsonProperty("payment_options")]
        public InvoicePutResponseInvoiceTypePaymentOptionsType PaymentOptions { get; set; }

        [JsonProperty("is_emailed")]
        public bool IsEmailed { get; set; }

        [JsonProperty("reminders_sent")]
        public int RemindersSent { get; set; }

        [JsonProperty("last_reminder_sent_date")]
        public string LastReminderSentDate { get; set; }

        [JsonProperty("billing_address")]
        public InvoicePutResponseInvoiceTypeBillingAddressType BillingAddress { get; set; }

        [JsonProperty("shipping_address")]
        public InvoicePutResponseInvoiceTypeShippingAddressType ShippingAddress { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("custom_fields")]
        public InvoicePutResponseInvoiceTypeCustomFieldsTypeItem[] CustomFields { get; set; }

        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        [JsonProperty("template_name")]
        public string TemplateName { get; set; }

        [JsonProperty("created_time")]
        public string CreatedTime { get; set; }

        [JsonProperty("last_modified_time")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("attachment_name")]
        public string AttachmentName { get; set; }

        [JsonProperty("can_send_in_mail")]
        public bool CanSendInMail { get; set; }

        [JsonProperty("salesperson_id")]
        public string SalespersonId { get; set; }

        [JsonProperty("salesperson_name")]
        public string SalespersonName { get; set; }

        [JsonProperty("invoice_url")]
        public string InvoiceUrl { get; set; }
    }

    public class InvoicePutResponseInvoiceTypeLineItemsTypeItem
    {
        [JsonProperty("line_item_id")]
        public string LineItemId { get; set; }

        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }

        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("time_entry_ids")]
        public int[] TimeEntryIds { get; set; }

        [JsonProperty("expense_id")]
        public string ExpenseId { get; set; }

        [JsonProperty("expense_receipt_name")]
        public string ExpenseReceiptName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("item_order")]
        public int ItemOrder { get; set; }

        [JsonProperty("bcy_rate")]
        public double BcyRate { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("discount_amount")]
        public double DiscountAmount { get; set; }

        [JsonProperty("discount")]
        public double Discount { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("tds_tax_id")]
        public string TdsTaxId { get; set; }

        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        [JsonProperty("tax_type")]
        public string TaxType { get; set; }

        [JsonProperty("tax_percentage")]
        public double TaxPercentage { get; set; }

        [JsonProperty("item_total")]
        public double ItemTotal { get; set; }

        [JsonProperty("sat_item_key_code")]
        public int SatItemKeyCode { get; set; }

        [JsonProperty("unitkey_code")]
        public string UnitkeyCode { get; set; }
    }

    public class InvoicePutResponseInvoiceTypeTaxesTypeItem
    {
        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        [JsonProperty("tax_amount")]
        public double TaxAmount { get; set; }
    }

    public class InvoicePutResponseInvoiceTypePaymentOptionsType
    {
        [JsonProperty("payment_gateways")]
        public InvoicePutResponseInvoiceTypePaymentOptionsTypePaymentGatewaysTypeItem[] PaymentGateways { get; set; }
    }

    public class InvoicePutResponseInvoiceTypePaymentOptionsTypePaymentGatewaysTypeItem
    {
        [JsonProperty("configured")]
        public bool Configured { get; set; }

        [JsonProperty("additional_field1")]
        public string AdditionalField1 { get; set; }

        [JsonProperty("gateway_name")]
        public string GatewayName { get; set; }
    }

    public class InvoicePutResponseInvoiceTypeBillingAddressType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }
    }

    public class InvoicePutResponseInvoiceTypeShippingAddressType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }
    }

    public class InvoicePutResponseInvoiceTypeCustomFieldsTypeItem
    {
        [JsonProperty("customfield_id")]
        public string CustomfieldId { get; set; }

        [JsonProperty("data_type")]
        public string DataType { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("show_on_pdf")]
        public bool ShowOnPdf { get; set; }

        [JsonProperty("show_in_all_pdf")]
        public bool ShowInAllPdf { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zohoinvoicebasic;

    public partial class WorkflowManagedActions
    {
        public ZohoinvoicebasicActions Zohoinvoicebasic(string connectionId) => new ZohoinvoicebasicActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZohoinvoicebasicTriggers Zohoinvoicebasic(string connectionId) => new ZohoinvoicebasicTriggers(connectionId);
    }
}
