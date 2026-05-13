//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zohoinvoicebasic
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZohoinvoicebasicActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactsGetResponse> ContactsGet(Expression<Func<string>> contactName = null, Expression<Func<string>> companyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> address = null, Expression<Func<string>> email = null, Expression<Func<string>> phone = null, Expression<Func<filterByInput>> filterBy = null, Expression<Func<string>> searchText = null, Expression<Func<sortColumnInput>> sortColumn = null, Expression<Func<int>> zcrmContactId = null, Expression<Func<int>> zcrmAccountId = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = "/invoice/v3/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (contactName != null)
                callPayload.Queries["contact_name"] = ExpressionConverter.Convert(contactName);
            if (companyName != null)
                callPayload.Queries["company_name"] = ExpressionConverter.Convert(companyName);
            if (firstName != null)
                callPayload.Queries["first_name"] = ExpressionConverter.Convert(firstName);
            if (lastName != null)
                callPayload.Queries["last_name"] = ExpressionConverter.Convert(lastName);
            if (address != null)
                callPayload.Queries["address"] = ExpressionConverter.Convert(address);
            if (email != null)
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            if (phone != null)
                callPayload.Queries["phone"] = ExpressionConverter.Convert(phone);
            if (filterBy != null)
                callPayload.Queries["filter_by"] = ExpressionConverter.Convert(filterBy);
            if (searchText != null)
                callPayload.Queries["search_text"] = ExpressionConverter.Convert(searchText);
            if (sortColumn != null)
                callPayload.Queries["sort_column"] = ExpressionConverter.Convert(sortColumn);
            if (zcrmContactId != null)
                callPayload.Queries["zcrm_contact_id"] = ExpressionConverter.Convert(zcrmContactId);
            if (zcrmAccountId != null)
                callPayload.Queries["zcrm_account_id"] = ExpressionConverter.Convert(zcrmAccountId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<ContactsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactPostResponse> Contact(Expression<Func<string>> bodycontactName, Expression<Func<string>> bodycompanyName = null, Expression<Func<int>> bodypaymentTerms = null, Expression<Func<string>> bodycurrencyId = null, Expression<Func<string>> bodywebsite = null, Expression<Func<bodycustomFieldsInputItem[]>> bodycustomFields = null, Expression<Func<string>> bodybillingAddressattention = null, Expression<Func<string>> bodybillingAddressaddress = null, Expression<Func<string>> bodybillingAddressstreet2 = null, Expression<Func<string>> bodybillingAddressstateCode = null, Expression<Func<string>> bodybillingAddresscity = null, Expression<Func<string>> bodybillingAddressstate = null, Expression<Func<string>> bodybillingAddresszip = null, Expression<Func<string>> bodybillingAddresscountry = null, Expression<Func<string>> bodybillingAddressfax = null, Expression<Func<string>> bodybillingAddressphone = null, Expression<Func<string>> bodyshippingAddressattention = null, Expression<Func<string>> bodyshippingAddressaddress = null, Expression<Func<string>> bodyshippingAddressstreet2 = null, Expression<Func<string>> bodyshippingAddressstateCode = null, Expression<Func<string>> bodyshippingAddresscity = null, Expression<Func<string>> bodyshippingAddressstate = null, Expression<Func<string>> bodyshippingAddresszip = null, Expression<Func<string>> bodyshippingAddresscountry = null, Expression<Func<string>> bodyshippingAddressfax = null, Expression<Func<string>> bodyshippingAddressphone = null, Expression<Func<bodycontactPersonsInputItem[]>> bodycontactPersons = null, Expression<Func<string>> bodydefaultTemplatesinvoiceTemplateId = null, Expression<Func<string>> bodydefaultTemplatesinvoiceTemplateName = null, Expression<Func<string>> bodydefaultTemplatesestimateTemplateId = null, Expression<Func<string>> bodydefaultTemplatesestimateTemplateName = null, Expression<Func<string>> bodydefaultTemplatescreditnoteTemplateId = null, Expression<Func<string>> bodydefaultTemplatescreditnoteTemplateName = null, Expression<Func<string>> bodydefaultTemplatesinvoiceEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatesinvoiceEmailTemplateName = null, Expression<Func<string>> bodydefaultTemplatesestimateEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatesestimateEmailTemplateName = null, Expression<Func<string>> bodydefaultTemplatescreditnoteEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatescreditnoteEmailTemplateName = null, Expression<Func<bodylanguageCodeInput>> bodylanguageCode = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyvatRegNo = null, Expression<Func<string>> bodytaxRegNo = null, Expression<Func<string>> bodycountryCode = null, Expression<Func<string>> bodyvatTreatment = null, Expression<Func<string>> bodytaxTreatment = null, Expression<Func<bodytaxRegimeInput>> bodytaxRegime = null, Expression<Func<string>> bodylegalName = null, Expression<Func<bool>> bodyisTdsRegistered = null, Expression<Func<string>> bodyplaceOfContact = null, Expression<Func<string>> bodygstNo = null, Expression<Func<bodygstTreatmentInput>> bodygstTreatment = null, Expression<Func<string>> bodytaxAuthorityName = null, Expression<Func<string>> bodytaxExemptionCode = null, Expression<Func<string>> bodyavataxExemptNo = null, Expression<Func<string>> bodyavataxUseCode = null, Expression<Func<string>> bodytaxExemptionId = null, Expression<Func<string>> bodytaxAuthorityId = null, Expression<Func<string>> bodytaxId = null, Expression<Func<string>> bodytdsTaxId = null, Expression<Func<bool>> bodyisTaxable = null, Expression<Func<string>> bodyfacebook = null, Expression<Func<string>> bodytwitter = null)
        {
            var apiCallPath = "/invoice/v3/contacts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["contact_name"] = ExpressionConverter.ConvertO(bodycontactName);
            if (bodycompanyName != null)
            {
                body["company_name"] = ExpressionConverter.ConvertO(bodycompanyName);
                bodypropCount++;
            }

            if (bodypaymentTerms != null)
            {
                body["payment_terms"] = ExpressionConverter.ConvertO(bodypaymentTerms);
                bodypropCount++;
            }

            if (bodycurrencyId != null)
            {
                body["currency_id"] = ExpressionConverter.ConvertO(bodycurrencyId);
                bodypropCount++;
            }

            if (bodywebsite != null)
            {
                body["website"] = ExpressionConverter.ConvertO(bodywebsite);
                bodypropCount++;
            }

            if (bodycustomFields != null)
            {
                body["custom_fields"] = ExpressionConverter.ConvertO(bodycustomFields);
                bodypropCount++;
            }

            var billingAddressObject = new JObject();
            var billingAddressObjectpropCount = 0;
            if (bodybillingAddressattention != null)
            {
                billingAddressObject["attention"] = ExpressionConverter.ConvertO(bodybillingAddressattention);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddressaddress != null)
            {
                billingAddressObject["address"] = ExpressionConverter.ConvertO(bodybillingAddressaddress);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddressstreet2 != null)
            {
                billingAddressObject["street2"] = ExpressionConverter.ConvertO(bodybillingAddressstreet2);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddressstateCode != null)
            {
                billingAddressObject["state_code"] = ExpressionConverter.ConvertO(bodybillingAddressstateCode);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddresscity != null)
            {
                billingAddressObject["city"] = ExpressionConverter.ConvertO(bodybillingAddresscity);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddressstate != null)
            {
                billingAddressObject["state"] = ExpressionConverter.ConvertO(bodybillingAddressstate);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddresszip != null)
            {
                billingAddressObject["zip"] = ExpressionConverter.ConvertO(bodybillingAddresszip);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddresscountry != null)
            {
                billingAddressObject["country"] = ExpressionConverter.ConvertO(bodybillingAddresscountry);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddressfax != null)
            {
                billingAddressObject["fax"] = ExpressionConverter.ConvertO(bodybillingAddressfax);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddressphone != null)
            {
                billingAddressObject["phone"] = ExpressionConverter.ConvertO(bodybillingAddressphone);
                billingAddressObjectpropCount++;
            }

            if (billingAddressObjectpropCount > 0)
            {
                body["billing_address"] = billingAddressObject;
                bodypropCount++;
            }

            var shippingAddressObject = new JObject();
            var shippingAddressObjectpropCount = 0;
            if (bodyshippingAddressattention != null)
            {
                shippingAddressObject["attention"] = ExpressionConverter.ConvertO(bodyshippingAddressattention);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddressaddress != null)
            {
                shippingAddressObject["address"] = ExpressionConverter.ConvertO(bodyshippingAddressaddress);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddressstreet2 != null)
            {
                shippingAddressObject["street2"] = ExpressionConverter.ConvertO(bodyshippingAddressstreet2);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddressstateCode != null)
            {
                shippingAddressObject["state_code"] = ExpressionConverter.ConvertO(bodyshippingAddressstateCode);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddresscity != null)
            {
                shippingAddressObject["city"] = ExpressionConverter.ConvertO(bodyshippingAddresscity);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddressstate != null)
            {
                shippingAddressObject["state"] = ExpressionConverter.ConvertO(bodyshippingAddressstate);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddresszip != null)
            {
                shippingAddressObject["zip"] = ExpressionConverter.ConvertO(bodyshippingAddresszip);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddresscountry != null)
            {
                shippingAddressObject["country"] = ExpressionConverter.ConvertO(bodyshippingAddresscountry);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddressfax != null)
            {
                shippingAddressObject["fax"] = ExpressionConverter.ConvertO(bodyshippingAddressfax);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddressphone != null)
            {
                shippingAddressObject["phone"] = ExpressionConverter.ConvertO(bodyshippingAddressphone);
                shippingAddressObjectpropCount++;
            }

            if (shippingAddressObjectpropCount > 0)
            {
                body["shipping_address"] = shippingAddressObject;
                bodypropCount++;
            }

            if (bodycontactPersons != null)
            {
                body["contact_persons"] = ExpressionConverter.ConvertO(bodycontactPersons);
                bodypropCount++;
            }

            var defaultTemplatesObject = new JObject();
            var defaultTemplatesObjectpropCount = 0;
            if (bodydefaultTemplatesinvoiceTemplateId != null)
            {
                defaultTemplatesObject["invoice_template_id"] = ExpressionConverter.ConvertO(bodydefaultTemplatesinvoiceTemplateId);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesinvoiceTemplateName != null)
            {
                defaultTemplatesObject["invoice_template_name"] = ExpressionConverter.ConvertO(bodydefaultTemplatesinvoiceTemplateName);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesestimateTemplateId != null)
            {
                defaultTemplatesObject["estimate_template_id"] = ExpressionConverter.ConvertO(bodydefaultTemplatesestimateTemplateId);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesestimateTemplateName != null)
            {
                defaultTemplatesObject["estimate_template_name"] = ExpressionConverter.ConvertO(bodydefaultTemplatesestimateTemplateName);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatescreditnoteTemplateId != null)
            {
                defaultTemplatesObject["creditnote_template_id"] = ExpressionConverter.ConvertO(bodydefaultTemplatescreditnoteTemplateId);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatescreditnoteTemplateName != null)
            {
                defaultTemplatesObject["creditnote_template_name"] = ExpressionConverter.ConvertO(bodydefaultTemplatescreditnoteTemplateName);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesinvoiceEmailTemplateId != null)
            {
                defaultTemplatesObject["invoice_email_template_id"] = ExpressionConverter.ConvertO(bodydefaultTemplatesinvoiceEmailTemplateId);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesinvoiceEmailTemplateName != null)
            {
                defaultTemplatesObject["invoice_email_template_name"] = ExpressionConverter.ConvertO(bodydefaultTemplatesinvoiceEmailTemplateName);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesestimateEmailTemplateId != null)
            {
                defaultTemplatesObject["estimate_email_template_id"] = ExpressionConverter.ConvertO(bodydefaultTemplatesestimateEmailTemplateId);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesestimateEmailTemplateName != null)
            {
                defaultTemplatesObject["estimate_email_template_name"] = ExpressionConverter.ConvertO(bodydefaultTemplatesestimateEmailTemplateName);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatescreditnoteEmailTemplateId != null)
            {
                defaultTemplatesObject["creditnote_email_template_id"] = ExpressionConverter.ConvertO(bodydefaultTemplatescreditnoteEmailTemplateId);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatescreditnoteEmailTemplateName != null)
            {
                defaultTemplatesObject["creditnote_email_template_name"] = ExpressionConverter.ConvertO(bodydefaultTemplatescreditnoteEmailTemplateName);
                defaultTemplatesObjectpropCount++;
            }

            if (defaultTemplatesObjectpropCount > 0)
            {
                body["default_templates"] = defaultTemplatesObject;
                bodypropCount++;
            }

            if (bodylanguageCode != null)
            {
                body["language_code"] = ExpressionConverter.ConvertO(bodylanguageCode);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyvatRegNo != null)
            {
                body["vat_reg_no"] = ExpressionConverter.ConvertO(bodyvatRegNo);
                bodypropCount++;
            }

            if (bodytaxRegNo != null)
            {
                body["tax_reg_no"] = ExpressionConverter.ConvertO(bodytaxRegNo);
                bodypropCount++;
            }

            if (bodycountryCode != null)
            {
                body["country_code"] = ExpressionConverter.ConvertO(bodycountryCode);
                bodypropCount++;
            }

            if (bodyvatTreatment != null)
            {
                body["vat_treatment"] = ExpressionConverter.ConvertO(bodyvatTreatment);
                bodypropCount++;
            }

            if (bodytaxTreatment != null)
            {
                body["tax_treatment"] = ExpressionConverter.ConvertO(bodytaxTreatment);
                bodypropCount++;
            }

            if (bodytaxRegime != null)
            {
                body["tax_regime"] = ExpressionConverter.ConvertO(bodytaxRegime);
                bodypropCount++;
            }

            if (bodylegalName != null)
            {
                body["legal_name"] = ExpressionConverter.ConvertO(bodylegalName);
                bodypropCount++;
            }

            if (bodyisTdsRegistered != null)
            {
                body["is_tds_registered"] = ExpressionConverter.ConvertO(bodyisTdsRegistered);
                bodypropCount++;
            }

            if (bodyplaceOfContact != null)
            {
                body["place_of_contact"] = ExpressionConverter.ConvertO(bodyplaceOfContact);
                bodypropCount++;
            }

            if (bodygstNo != null)
            {
                body["gst_no"] = ExpressionConverter.ConvertO(bodygstNo);
                bodypropCount++;
            }

            if (bodygstTreatment != null)
            {
                body["gst_treatment"] = ExpressionConverter.ConvertO(bodygstTreatment);
                bodypropCount++;
            }

            if (bodytaxAuthorityName != null)
            {
                body["tax_authority_name"] = ExpressionConverter.ConvertO(bodytaxAuthorityName);
                bodypropCount++;
            }

            if (bodytaxExemptionCode != null)
            {
                body["tax_exemption_code"] = ExpressionConverter.ConvertO(bodytaxExemptionCode);
                bodypropCount++;
            }

            if (bodyavataxExemptNo != null)
            {
                body["avatax_exempt_no"] = ExpressionConverter.ConvertO(bodyavataxExemptNo);
                bodypropCount++;
            }

            if (bodyavataxUseCode != null)
            {
                body["avatax_use_code"] = ExpressionConverter.ConvertO(bodyavataxUseCode);
                bodypropCount++;
            }

            if (bodytaxExemptionId != null)
            {
                body["tax_exemption_id"] = ExpressionConverter.ConvertO(bodytaxExemptionId);
                bodypropCount++;
            }

            if (bodytaxAuthorityId != null)
            {
                body["tax_authority_id"] = ExpressionConverter.ConvertO(bodytaxAuthorityId);
                bodypropCount++;
            }

            if (bodytaxId != null)
            {
                body["tax_id"] = ExpressionConverter.ConvertO(bodytaxId);
                bodypropCount++;
            }

            if (bodytdsTaxId != null)
            {
                body["tds_tax_id"] = ExpressionConverter.ConvertO(bodytdsTaxId);
                bodypropCount++;
            }

            if (bodyisTaxable != null)
            {
                body["is_taxable"] = ExpressionConverter.ConvertO(bodyisTaxable);
                bodypropCount++;
            }

            if (bodyfacebook != null)
            {
                body["facebook"] = ExpressionConverter.ConvertO(bodyfacebook);
                bodypropCount++;
            }

            if (bodytwitter != null)
            {
                body["twitter"] = ExpressionConverter.ConvertO(bodytwitter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ContactPostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactGetResponse> ContactGet(Expression<Func<string>> contactId)
        {
            var apiCallPath = String.Format("/invoice/v3/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ContactGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactDeleteResponse> ContactDelete(Expression<Func<string>> contactId)
        {
            var apiCallPath = String.Format("/invoice/v3/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ContactDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactPutResponse> ContactPut(Expression<Func<string>> contactId, Expression<Func<string>> bodycontactName, Expression<Func<string>> bodycompanyName = null, Expression<Func<int>> bodypaymentTerms = null, Expression<Func<string>> bodycurrencyId = null, Expression<Func<string>> bodywebsite = null, Expression<Func<bodycustomFieldsInputItem2[]>> bodycustomFields = null, Expression<Func<string>> bodybillingAddressattention = null, Expression<Func<string>> bodybillingAddressaddress = null, Expression<Func<string>> bodybillingAddressstreet2 = null, Expression<Func<string>> bodybillingAddressstateCode = null, Expression<Func<string>> bodybillingAddresscity = null, Expression<Func<string>> bodybillingAddressstate = null, Expression<Func<string>> bodybillingAddresszip = null, Expression<Func<string>> bodybillingAddresscountry = null, Expression<Func<string>> bodybillingAddressfax = null, Expression<Func<string>> bodybillingAddressphone = null, Expression<Func<string>> bodyshippingAddressattention = null, Expression<Func<string>> bodyshippingAddressaddress = null, Expression<Func<string>> bodyshippingAddressstreet2 = null, Expression<Func<string>> bodyshippingAddressstateCode = null, Expression<Func<string>> bodyshippingAddresscity = null, Expression<Func<string>> bodyshippingAddressstate = null, Expression<Func<string>> bodyshippingAddresszip = null, Expression<Func<string>> bodyshippingAddresscountry = null, Expression<Func<string>> bodyshippingAddressfax = null, Expression<Func<string>> bodyshippingAddressphone = null, Expression<Func<bodycontactPersonsInputItem[]>> bodycontactPersons = null, Expression<Func<string>> bodydefaultTemplatesinvoiceTemplateId = null, Expression<Func<string>> bodydefaultTemplatesinvoiceTemplateName = null, Expression<Func<string>> bodydefaultTemplatesestimateTemplateId = null, Expression<Func<string>> bodydefaultTemplatesestimateTemplateName = null, Expression<Func<string>> bodydefaultTemplatescreditnoteTemplateId = null, Expression<Func<string>> bodydefaultTemplatescreditnoteTemplateName = null, Expression<Func<string>> bodydefaultTemplatesinvoiceEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatesinvoiceEmailTemplateName = null, Expression<Func<string>> bodydefaultTemplatesestimateEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatesestimateEmailTemplateName = null, Expression<Func<string>> bodydefaultTemplatescreditnoteEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatescreditnoteEmailTemplateName = null, Expression<Func<bodylanguageCodeInput>> bodylanguageCode = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyvatRegNo = null, Expression<Func<string>> bodytaxRegNo = null, Expression<Func<string>> bodycountryCode = null, Expression<Func<bodyvatTreatmentInput>> bodyvatTreatment = null, Expression<Func<string>> bodytaxTreatment = null, Expression<Func<bodytaxRegimeInput>> bodytaxRegime = null, Expression<Func<string>> bodylegalName = null, Expression<Func<bool>> bodyisTdsRegistered = null, Expression<Func<string>> bodyplaceOfContact = null, Expression<Func<string>> bodygstNo = null, Expression<Func<bodygstTreatmentInput>> bodygstTreatment = null, Expression<Func<string>> bodytaxAuthorityName = null, Expression<Func<string>> bodytaxExemptionCode = null, Expression<Func<string>> bodyavataxExemptNo = null, Expression<Func<string>> bodyavataxUseCode = null, Expression<Func<string>> bodytaxExemptionId = null, Expression<Func<string>> bodytaxAuthorityId = null, Expression<Func<string>> bodytaxId = null, Expression<Func<string>> bodytdsTaxId = null, Expression<Func<bool>> bodyisTaxable = null, Expression<Func<string>> bodyfacebook = null, Expression<Func<string>> bodytwitter = null)
        {
            var apiCallPath = String.Format("/invoice/v3/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(contactId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["contact_name"] = ExpressionConverter.ConvertO(bodycontactName);
            if (bodycompanyName != null)
            {
                body["company_name"] = ExpressionConverter.ConvertO(bodycompanyName);
                bodypropCount++;
            }

            if (bodypaymentTerms != null)
            {
                body["payment_terms"] = ExpressionConverter.ConvertO(bodypaymentTerms);
                bodypropCount++;
            }

            if (bodycurrencyId != null)
            {
                body["currency_id"] = ExpressionConverter.ConvertO(bodycurrencyId);
                bodypropCount++;
            }

            if (bodywebsite != null)
            {
                body["website"] = ExpressionConverter.ConvertO(bodywebsite);
                bodypropCount++;
            }

            if (bodycustomFields != null)
            {
                body["custom_fields"] = ExpressionConverter.ConvertO(bodycustomFields);
                bodypropCount++;
            }

            var billingAddressObject = new JObject();
            var billingAddressObjectpropCount = 0;
            if (bodybillingAddressattention != null)
            {
                billingAddressObject["attention"] = ExpressionConverter.ConvertO(bodybillingAddressattention);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddressaddress != null)
            {
                billingAddressObject["address"] = ExpressionConverter.ConvertO(bodybillingAddressaddress);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddressstreet2 != null)
            {
                billingAddressObject["street2"] = ExpressionConverter.ConvertO(bodybillingAddressstreet2);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddressstateCode != null)
            {
                billingAddressObject["state_code"] = ExpressionConverter.ConvertO(bodybillingAddressstateCode);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddresscity != null)
            {
                billingAddressObject["city"] = ExpressionConverter.ConvertO(bodybillingAddresscity);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddressstate != null)
            {
                billingAddressObject["state"] = ExpressionConverter.ConvertO(bodybillingAddressstate);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddresszip != null)
            {
                billingAddressObject["zip"] = ExpressionConverter.ConvertO(bodybillingAddresszip);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddresscountry != null)
            {
                billingAddressObject["country"] = ExpressionConverter.ConvertO(bodybillingAddresscountry);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddressfax != null)
            {
                billingAddressObject["fax"] = ExpressionConverter.ConvertO(bodybillingAddressfax);
                billingAddressObjectpropCount++;
            }

            if (bodybillingAddressphone != null)
            {
                billingAddressObject["phone"] = ExpressionConverter.ConvertO(bodybillingAddressphone);
                billingAddressObjectpropCount++;
            }

            if (billingAddressObjectpropCount > 0)
            {
                body["billing_address"] = billingAddressObject;
                bodypropCount++;
            }

            var shippingAddressObject = new JObject();
            var shippingAddressObjectpropCount = 0;
            if (bodyshippingAddressattention != null)
            {
                shippingAddressObject["attention"] = ExpressionConverter.ConvertO(bodyshippingAddressattention);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddressaddress != null)
            {
                shippingAddressObject["address"] = ExpressionConverter.ConvertO(bodyshippingAddressaddress);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddressstreet2 != null)
            {
                shippingAddressObject["street2"] = ExpressionConverter.ConvertO(bodyshippingAddressstreet2);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddressstateCode != null)
            {
                shippingAddressObject["state_code"] = ExpressionConverter.ConvertO(bodyshippingAddressstateCode);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddresscity != null)
            {
                shippingAddressObject["city"] = ExpressionConverter.ConvertO(bodyshippingAddresscity);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddressstate != null)
            {
                shippingAddressObject["state"] = ExpressionConverter.ConvertO(bodyshippingAddressstate);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddresszip != null)
            {
                shippingAddressObject["zip"] = ExpressionConverter.ConvertO(bodyshippingAddresszip);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddresscountry != null)
            {
                shippingAddressObject["country"] = ExpressionConverter.ConvertO(bodyshippingAddresscountry);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddressfax != null)
            {
                shippingAddressObject["fax"] = ExpressionConverter.ConvertO(bodyshippingAddressfax);
                shippingAddressObjectpropCount++;
            }

            if (bodyshippingAddressphone != null)
            {
                shippingAddressObject["phone"] = ExpressionConverter.ConvertO(bodyshippingAddressphone);
                shippingAddressObjectpropCount++;
            }

            if (shippingAddressObjectpropCount > 0)
            {
                body["shipping_address"] = shippingAddressObject;
                bodypropCount++;
            }

            if (bodycontactPersons != null)
            {
                body["contact_persons"] = ExpressionConverter.ConvertO(bodycontactPersons);
                bodypropCount++;
            }

            var defaultTemplatesObject = new JObject();
            var defaultTemplatesObjectpropCount = 0;
            if (bodydefaultTemplatesinvoiceTemplateId != null)
            {
                defaultTemplatesObject["invoice_template_id"] = ExpressionConverter.ConvertO(bodydefaultTemplatesinvoiceTemplateId);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesinvoiceTemplateName != null)
            {
                defaultTemplatesObject["invoice_template_name"] = ExpressionConverter.ConvertO(bodydefaultTemplatesinvoiceTemplateName);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesestimateTemplateId != null)
            {
                defaultTemplatesObject["estimate_template_id"] = ExpressionConverter.ConvertO(bodydefaultTemplatesestimateTemplateId);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesestimateTemplateName != null)
            {
                defaultTemplatesObject["estimate_template_name"] = ExpressionConverter.ConvertO(bodydefaultTemplatesestimateTemplateName);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatescreditnoteTemplateId != null)
            {
                defaultTemplatesObject["creditnote_template_id"] = ExpressionConverter.ConvertO(bodydefaultTemplatescreditnoteTemplateId);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatescreditnoteTemplateName != null)
            {
                defaultTemplatesObject["creditnote_template_name"] = ExpressionConverter.ConvertO(bodydefaultTemplatescreditnoteTemplateName);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesinvoiceEmailTemplateId != null)
            {
                defaultTemplatesObject["invoice_email_template_id"] = ExpressionConverter.ConvertO(bodydefaultTemplatesinvoiceEmailTemplateId);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesinvoiceEmailTemplateName != null)
            {
                defaultTemplatesObject["invoice_email_template_name"] = ExpressionConverter.ConvertO(bodydefaultTemplatesinvoiceEmailTemplateName);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesestimateEmailTemplateId != null)
            {
                defaultTemplatesObject["estimate_email_template_id"] = ExpressionConverter.ConvertO(bodydefaultTemplatesestimateEmailTemplateId);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatesestimateEmailTemplateName != null)
            {
                defaultTemplatesObject["estimate_email_template_name"] = ExpressionConverter.ConvertO(bodydefaultTemplatesestimateEmailTemplateName);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatescreditnoteEmailTemplateId != null)
            {
                defaultTemplatesObject["creditnote_email_template_id"] = ExpressionConverter.ConvertO(bodydefaultTemplatescreditnoteEmailTemplateId);
                defaultTemplatesObjectpropCount++;
            }

            if (bodydefaultTemplatescreditnoteEmailTemplateName != null)
            {
                defaultTemplatesObject["creditnote_email_template_name"] = ExpressionConverter.ConvertO(bodydefaultTemplatescreditnoteEmailTemplateName);
                defaultTemplatesObjectpropCount++;
            }

            if (defaultTemplatesObjectpropCount > 0)
            {
                body["default_templates"] = defaultTemplatesObject;
                bodypropCount++;
            }

            if (bodylanguageCode != null)
            {
                body["language_code"] = ExpressionConverter.ConvertO(bodylanguageCode);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyvatRegNo != null)
            {
                body["vat_reg_no"] = ExpressionConverter.ConvertO(bodyvatRegNo);
                bodypropCount++;
            }

            if (bodytaxRegNo != null)
            {
                body["tax_reg_no"] = ExpressionConverter.ConvertO(bodytaxRegNo);
                bodypropCount++;
            }

            if (bodycountryCode != null)
            {
                body["country_code"] = ExpressionConverter.ConvertO(bodycountryCode);
                bodypropCount++;
            }

            if (bodyvatTreatment != null)
            {
                body["vat_treatment"] = ExpressionConverter.ConvertO(bodyvatTreatment);
                bodypropCount++;
            }

            if (bodytaxTreatment != null)
            {
                body["tax_treatment"] = ExpressionConverter.ConvertO(bodytaxTreatment);
                bodypropCount++;
            }

            if (bodytaxRegime != null)
            {
                body["tax_regime"] = ExpressionConverter.ConvertO(bodytaxRegime);
                bodypropCount++;
            }

            if (bodylegalName != null)
            {
                body["legal_name"] = ExpressionConverter.ConvertO(bodylegalName);
                bodypropCount++;
            }

            if (bodyisTdsRegistered != null)
            {
                body["is_tds_registered"] = ExpressionConverter.ConvertO(bodyisTdsRegistered);
                bodypropCount++;
            }

            if (bodyplaceOfContact != null)
            {
                body["place_of_contact"] = ExpressionConverter.ConvertO(bodyplaceOfContact);
                bodypropCount++;
            }

            if (bodygstNo != null)
            {
                body["gst_no"] = ExpressionConverter.ConvertO(bodygstNo);
                bodypropCount++;
            }

            if (bodygstTreatment != null)
            {
                body["gst_treatment"] = ExpressionConverter.ConvertO(bodygstTreatment);
                bodypropCount++;
            }

            if (bodytaxAuthorityName != null)
            {
                body["tax_authority_name"] = ExpressionConverter.ConvertO(bodytaxAuthorityName);
                bodypropCount++;
            }

            if (bodytaxExemptionCode != null)
            {
                body["tax_exemption_code"] = ExpressionConverter.ConvertO(bodytaxExemptionCode);
                bodypropCount++;
            }

            if (bodyavataxExemptNo != null)
            {
                body["avatax_exempt_no"] = ExpressionConverter.ConvertO(bodyavataxExemptNo);
                bodypropCount++;
            }

            if (bodyavataxUseCode != null)
            {
                body["avatax_use_code"] = ExpressionConverter.ConvertO(bodyavataxUseCode);
                bodypropCount++;
            }

            if (bodytaxExemptionId != null)
            {
                body["tax_exemption_id"] = ExpressionConverter.ConvertO(bodytaxExemptionId);
                bodypropCount++;
            }

            if (bodytaxAuthorityId != null)
            {
                body["tax_authority_id"] = ExpressionConverter.ConvertO(bodytaxAuthorityId);
                bodypropCount++;
            }

            if (bodytaxId != null)
            {
                body["tax_id"] = ExpressionConverter.ConvertO(bodytaxId);
                bodypropCount++;
            }

            if (bodytdsTaxId != null)
            {
                body["tds_tax_id"] = ExpressionConverter.ConvertO(bodytdsTaxId);
                bodypropCount++;
            }

            if (bodyisTaxable != null)
            {
                body["is_taxable"] = ExpressionConverter.ConvertO(bodyisTaxable);
                bodypropCount++;
            }

            if (bodyfacebook != null)
            {
                body["facebook"] = ExpressionConverter.ConvertO(bodyfacebook);
                bodypropCount++;
            }

            if (bodytwitter != null)
            {
                body["twitter"] = ExpressionConverter.ConvertO(bodytwitter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ContactPutResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoicesGetResponse> InvoicesGet(Expression<Func<string>> invoiceNumber = null, Expression<Func<string>> itemName = null, Expression<Func<string>> itemId = null, Expression<Func<string>> itemDescription = null, Expression<Func<string>> referenceNumber = null, Expression<Func<string>> customerName = null, Expression<Func<string>> recurringInvoiceId = null, Expression<Func<string>> email = null, Expression<Func<string>> total = null, Expression<Func<string>> balance = null, Expression<Func<string>> customField = null, Expression<Func<string>> date = null, Expression<Func<string>> dueDate = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> customerId = null, Expression<Func<filterByInput>> filterBy = null, Expression<Func<string>> searchText = null, Expression<Func<sortColumnInput>> sortColumn = null, Expression<Func<string>> zcrmPotentialId = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var apiCallPath = "/invoice/v3/invoices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (invoiceNumber != null)
                callPayload.Queries["invoice_number"] = ExpressionConverter.Convert(invoiceNumber);
            if (itemName != null)
                callPayload.Queries["item_name"] = ExpressionConverter.Convert(itemName);
            if (itemId != null)
                callPayload.Queries["item_id"] = ExpressionConverter.Convert(itemId);
            if (itemDescription != null)
                callPayload.Queries["item_description"] = ExpressionConverter.Convert(itemDescription);
            if (referenceNumber != null)
                callPayload.Queries["reference_number"] = ExpressionConverter.Convert(referenceNumber);
            if (customerName != null)
                callPayload.Queries["customer_name"] = ExpressionConverter.Convert(customerName);
            if (recurringInvoiceId != null)
                callPayload.Queries["recurring_invoice_id"] = ExpressionConverter.Convert(recurringInvoiceId);
            if (email != null)
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            if (total != null)
                callPayload.Queries["total"] = ExpressionConverter.Convert(total);
            if (balance != null)
                callPayload.Queries["balance"] = ExpressionConverter.Convert(balance);
            if (customField != null)
                callPayload.Queries["custom_field"] = ExpressionConverter.Convert(customField);
            if (date != null)
                callPayload.Queries["date"] = ExpressionConverter.Convert(date);
            if (dueDate != null)
                callPayload.Queries["due_date"] = ExpressionConverter.Convert(dueDate);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (customerId != null)
                callPayload.Queries["customer_id"] = ExpressionConverter.Convert(customerId);
            if (filterBy != null)
                callPayload.Queries["filter_by"] = ExpressionConverter.Convert(filterBy);
            if (searchText != null)
                callPayload.Queries["search_text"] = ExpressionConverter.Convert(searchText);
            if (sortColumn != null)
                callPayload.Queries["sort_column"] = ExpressionConverter.Convert(sortColumn);
            if (zcrmPotentialId != null)
                callPayload.Queries["zcrm_potential_id"] = ExpressionConverter.Convert(zcrmPotentialId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<InvoicesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoicePostResponse> Invoice(Expression<Func<bool>> send = null, Expression<Func<bool>> ignoreAutoNumberGeneration = null, Expression<Func<string>> bodycustomerId = null, Expression<Func<int[]>> bodycontactPersons = null, Expression<Func<string>> bodyinvoiceNumber = null, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<string>> bodyplaceOfSupply = null, Expression<Func<string>> bodyvatTreatment = null, Expression<Func<string>> bodygstTreatment = null, Expression<Func<string>> bodytaxTreatment = null, Expression<Func<string>> bodycfdiUsage = null, Expression<Func<string>> bodygstNo = null, Expression<Func<string>> bodytemplateId = null, Expression<Func<string>> bodydate = null, Expression<Func<int>> bodypaymentTerms = null, Expression<Func<string>> bodypaymentTermsLabel = null, Expression<Func<string>> bodydueDate = null, Expression<Func<double>> bodydiscount = null, Expression<Func<bool>> bodyisDiscountBeforeTax = null, Expression<Func<string>> bodydiscountType = null, Expression<Func<bool>> bodyisInclusiveTax = null, Expression<Func<double>> bodyexchangeRate = null, Expression<Func<string>> bodyrecurringInvoiceId = null, Expression<Func<string>> bodyinvoicedEstimateId = null, Expression<Func<string>> bodysalespersonName = null, Expression<Func<bodycustomFieldsInputItem22[]>> bodycustomFields = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<bodylineItemsInputItem[]>> bodylineItems = null, Expression<Func<bodypaymentOptionspaymentGatewaysInputItem[]>> bodypaymentOptionspaymentGateways = null, Expression<Func<bool>> bodyallowPartialPayments = null, Expression<Func<string>> bodycustomBody = null, Expression<Func<string>> bodycustomSubject = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyterms = null, Expression<Func<double>> bodyshippingCharge = null, Expression<Func<double>> bodyadjustment = null, Expression<Func<string>> bodyadjustmentDescription = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodytaxAuthorityId = null, Expression<Func<string>> bodytaxExemptionId = null, Expression<Func<string>> bodyavataxUseCode = null, Expression<Func<string>> bodyavataxTaxCode = null, Expression<Func<string>> bodyavataxExemptNo = null)
        {
            var apiCallPath = "/invoice/v3/invoices";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (send != null)
                callPayload.Queries["send"] = ExpressionConverter.Convert(send);
            if (ignoreAutoNumberGeneration != null)
                callPayload.Queries["ignore_auto_number_generation"] = ExpressionConverter.Convert(ignoreAutoNumberGeneration);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycustomerId != null)
            {
                body["customer_id"] = ExpressionConverter.ConvertO(bodycustomerId);
                bodypropCount++;
            }

            if (bodycontactPersons != null)
            {
                body["contact_persons"] = ExpressionConverter.ConvertO(bodycontactPersons);
                bodypropCount++;
            }

            if (bodyinvoiceNumber != null)
            {
                body["invoice_number"] = ExpressionConverter.ConvertO(bodyinvoiceNumber);
                bodypropCount++;
            }

            if (bodyreferenceNumber != null)
            {
                body["reference_number"] = ExpressionConverter.ConvertO(bodyreferenceNumber);
                bodypropCount++;
            }

            if (bodyplaceOfSupply != null)
            {
                body["place_of_supply"] = ExpressionConverter.ConvertO(bodyplaceOfSupply);
                bodypropCount++;
            }

            if (bodyvatTreatment != null)
            {
                body["vat_treatment"] = ExpressionConverter.ConvertO(bodyvatTreatment);
                bodypropCount++;
            }

            if (bodygstTreatment != null)
            {
                body["gst_treatment"] = ExpressionConverter.ConvertO(bodygstTreatment);
                bodypropCount++;
            }

            if (bodytaxTreatment != null)
            {
                body["tax_treatment"] = ExpressionConverter.ConvertO(bodytaxTreatment);
                bodypropCount++;
            }

            if (bodycfdiUsage != null)
            {
                body["cfdi_usage"] = ExpressionConverter.ConvertO(bodycfdiUsage);
                bodypropCount++;
            }

            if (bodygstNo != null)
            {
                body["gst_no"] = ExpressionConverter.ConvertO(bodygstNo);
                bodypropCount++;
            }

            if (bodytemplateId != null)
            {
                body["template_id"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodypaymentTerms != null)
            {
                body["payment_terms"] = ExpressionConverter.ConvertO(bodypaymentTerms);
                bodypropCount++;
            }

            if (bodypaymentTermsLabel != null)
            {
                body["payment_terms_label"] = ExpressionConverter.ConvertO(bodypaymentTermsLabel);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["due_date"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodydiscount != null)
            {
                body["discount"] = ExpressionConverter.ConvertO(bodydiscount);
                bodypropCount++;
            }

            if (bodyisDiscountBeforeTax != null)
            {
                body["is_discount_before_tax"] = ExpressionConverter.ConvertO(bodyisDiscountBeforeTax);
                bodypropCount++;
            }

            if (bodydiscountType != null)
            {
                body["discount_type"] = ExpressionConverter.ConvertO(bodydiscountType);
                bodypropCount++;
            }

            if (bodyisInclusiveTax != null)
            {
                body["is_inclusive_tax"] = ExpressionConverter.ConvertO(bodyisInclusiveTax);
                bodypropCount++;
            }

            if (bodyexchangeRate != null)
            {
                body["exchange_rate"] = ExpressionConverter.ConvertO(bodyexchangeRate);
                bodypropCount++;
            }

            if (bodyrecurringInvoiceId != null)
            {
                body["recurring_invoice_id"] = ExpressionConverter.ConvertO(bodyrecurringInvoiceId);
                bodypropCount++;
            }

            if (bodyinvoicedEstimateId != null)
            {
                body["invoiced_estimate_id"] = ExpressionConverter.ConvertO(bodyinvoicedEstimateId);
                bodypropCount++;
            }

            if (bodysalespersonName != null)
            {
                body["salesperson_name"] = ExpressionConverter.ConvertO(bodysalespersonName);
                bodypropCount++;
            }

            if (bodycustomFields != null)
            {
                body["custom_fields"] = ExpressionConverter.ConvertO(bodycustomFields);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            if (bodylineItems != null)
            {
                body["line_items"] = ExpressionConverter.ConvertO(bodylineItems);
                bodypropCount++;
            }

            var paymentOptionsObject = new JObject();
            var paymentOptionsObjectpropCount = 0;
            if (bodypaymentOptionspaymentGateways != null)
            {
                paymentOptionsObject["payment_gateways"] = ExpressionConverter.ConvertO(bodypaymentOptionspaymentGateways);
                paymentOptionsObjectpropCount++;
            }

            if (paymentOptionsObjectpropCount > 0)
            {
                body["payment_options"] = paymentOptionsObject;
                bodypropCount++;
            }

            if (bodyallowPartialPayments != null)
            {
                body["allow_partial_payments"] = ExpressionConverter.ConvertO(bodyallowPartialPayments);
                bodypropCount++;
            }

            if (bodycustomBody != null)
            {
                body["custom_body"] = ExpressionConverter.ConvertO(bodycustomBody);
                bodypropCount++;
            }

            if (bodycustomSubject != null)
            {
                body["custom_subject"] = ExpressionConverter.ConvertO(bodycustomSubject);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyterms != null)
            {
                body["terms"] = ExpressionConverter.ConvertO(bodyterms);
                bodypropCount++;
            }

            if (bodyshippingCharge != null)
            {
                body["shipping_charge"] = ExpressionConverter.ConvertO(bodyshippingCharge);
                bodypropCount++;
            }

            if (bodyadjustment != null)
            {
                body["adjustment"] = ExpressionConverter.ConvertO(bodyadjustment);
                bodypropCount++;
            }

            if (bodyadjustmentDescription != null)
            {
                body["adjustment_description"] = ExpressionConverter.ConvertO(bodyadjustmentDescription);
                bodypropCount++;
            }

            if (bodyreason != null)
            {
                body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                bodypropCount++;
            }

            if (bodytaxAuthorityId != null)
            {
                body["tax_authority_id"] = ExpressionConverter.ConvertO(bodytaxAuthorityId);
                bodypropCount++;
            }

            if (bodytaxExemptionId != null)
            {
                body["tax_exemption_id"] = ExpressionConverter.ConvertO(bodytaxExemptionId);
                bodypropCount++;
            }

            if (bodyavataxUseCode != null)
            {
                body["avatax_use_code"] = ExpressionConverter.ConvertO(bodyavataxUseCode);
                bodypropCount++;
            }

            if (bodyavataxTaxCode != null)
            {
                body["avatax_tax_code"] = ExpressionConverter.ConvertO(bodyavataxTaxCode);
                bodypropCount++;
            }

            if (bodyavataxExemptNo != null)
            {
                body["avatax_exempt_no"] = ExpressionConverter.ConvertO(bodyavataxExemptNo);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<InvoicePostResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoiceGetResponse> InvoiceGet(Expression<Func<string>> invoiceId)
        {
            var apiCallPath = String.Format("/invoice/v3/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(invoiceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<InvoiceGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoiceDeleteResponse> InvoiceDelete(Expression<Func<string>> invoiceId)
        {
            var apiCallPath = String.Format("/invoice/v3/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(invoiceId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<InvoiceDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoicePutResponse> InvoicePut(Expression<Func<string>> invoiceId, Expression<Func<string>> bodycustomerId = null, Expression<Func<int[]>> bodycontactPersons = null, Expression<Func<string>> bodyinvoiceNumber = null, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<string>> bodyplaceOfSupply = null, Expression<Func<string>> bodyvatTreatment = null, Expression<Func<string>> bodygstTreatment = null, Expression<Func<string>> bodytaxTreatment = null, Expression<Func<string>> bodycfdiUsage = null, Expression<Func<string>> bodygstNo = null, Expression<Func<string>> bodytemplateId = null, Expression<Func<string>> bodydate = null, Expression<Func<int>> bodypaymentTerms = null, Expression<Func<string>> bodypaymentTermsLabel = null, Expression<Func<string>> bodydueDate = null, Expression<Func<double>> bodydiscount = null, Expression<Func<bool>> bodyisDiscountBeforeTax = null, Expression<Func<string>> bodydiscountType = null, Expression<Func<bool>> bodyisInclusiveTax = null, Expression<Func<double>> bodyexchangeRate = null, Expression<Func<string>> bodyrecurringInvoiceId = null, Expression<Func<string>> bodyinvoicedEstimateId = null, Expression<Func<string>> bodysalespersonName = null, Expression<Func<bodycustomFieldsInputItem22[]>> bodycustomFields = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<bodylineItemsInputItem[]>> bodylineItems = null, Expression<Func<bodypaymentOptionspaymentGatewaysInputItem[]>> bodypaymentOptionspaymentGateways = null, Expression<Func<bool>> bodyallowPartialPayments = null, Expression<Func<string>> bodycustomBody = null, Expression<Func<string>> bodycustomSubject = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyterms = null, Expression<Func<double>> bodyshippingCharge = null, Expression<Func<double>> bodyadjustment = null, Expression<Func<string>> bodyadjustmentDescription = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodytaxAuthorityId = null, Expression<Func<string>> bodytaxExemptionId = null, Expression<Func<string>> bodyavataxUseCode = null, Expression<Func<string>> bodyavataxTaxCode = null, Expression<Func<string>> bodyavataxExemptNo = null)
        {
            var apiCallPath = String.Format("/invoice/v3/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(invoiceId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycustomerId != null)
            {
                body["customer_id"] = ExpressionConverter.ConvertO(bodycustomerId);
                bodypropCount++;
            }

            if (bodycontactPersons != null)
            {
                body["contact_persons"] = ExpressionConverter.ConvertO(bodycontactPersons);
                bodypropCount++;
            }

            if (bodyinvoiceNumber != null)
            {
                body["invoice_number"] = ExpressionConverter.ConvertO(bodyinvoiceNumber);
                bodypropCount++;
            }

            if (bodyreferenceNumber != null)
            {
                body["reference_number"] = ExpressionConverter.ConvertO(bodyreferenceNumber);
                bodypropCount++;
            }

            if (bodyplaceOfSupply != null)
            {
                body["place_of_supply"] = ExpressionConverter.ConvertO(bodyplaceOfSupply);
                bodypropCount++;
            }

            if (bodyvatTreatment != null)
            {
                body["vat_treatment"] = ExpressionConverter.ConvertO(bodyvatTreatment);
                bodypropCount++;
            }

            if (bodygstTreatment != null)
            {
                body["gst_treatment"] = ExpressionConverter.ConvertO(bodygstTreatment);
                bodypropCount++;
            }

            if (bodytaxTreatment != null)
            {
                body["tax_treatment"] = ExpressionConverter.ConvertO(bodytaxTreatment);
                bodypropCount++;
            }

            if (bodycfdiUsage != null)
            {
                body["cfdi_usage"] = ExpressionConverter.ConvertO(bodycfdiUsage);
                bodypropCount++;
            }

            if (bodygstNo != null)
            {
                body["gst_no"] = ExpressionConverter.ConvertO(bodygstNo);
                bodypropCount++;
            }

            if (bodytemplateId != null)
            {
                body["template_id"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodypaymentTerms != null)
            {
                body["payment_terms"] = ExpressionConverter.ConvertO(bodypaymentTerms);
                bodypropCount++;
            }

            if (bodypaymentTermsLabel != null)
            {
                body["payment_terms_label"] = ExpressionConverter.ConvertO(bodypaymentTermsLabel);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["due_date"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodydiscount != null)
            {
                body["discount"] = ExpressionConverter.ConvertO(bodydiscount);
                bodypropCount++;
            }

            if (bodyisDiscountBeforeTax != null)
            {
                body["is_discount_before_tax"] = ExpressionConverter.ConvertO(bodyisDiscountBeforeTax);
                bodypropCount++;
            }

            if (bodydiscountType != null)
            {
                body["discount_type"] = ExpressionConverter.ConvertO(bodydiscountType);
                bodypropCount++;
            }

            if (bodyisInclusiveTax != null)
            {
                body["is_inclusive_tax"] = ExpressionConverter.ConvertO(bodyisInclusiveTax);
                bodypropCount++;
            }

            if (bodyexchangeRate != null)
            {
                body["exchange_rate"] = ExpressionConverter.ConvertO(bodyexchangeRate);
                bodypropCount++;
            }

            if (bodyrecurringInvoiceId != null)
            {
                body["recurring_invoice_id"] = ExpressionConverter.ConvertO(bodyrecurringInvoiceId);
                bodypropCount++;
            }

            if (bodyinvoicedEstimateId != null)
            {
                body["invoiced_estimate_id"] = ExpressionConverter.ConvertO(bodyinvoicedEstimateId);
                bodypropCount++;
            }

            if (bodysalespersonName != null)
            {
                body["salesperson_name"] = ExpressionConverter.ConvertO(bodysalespersonName);
                bodypropCount++;
            }

            if (bodycustomFields != null)
            {
                body["custom_fields"] = ExpressionConverter.ConvertO(bodycustomFields);
                bodypropCount++;
            }

            if (bodyprojectId != null)
            {
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectId);
                bodypropCount++;
            }

            if (bodylineItems != null)
            {
                body["line_items"] = ExpressionConverter.ConvertO(bodylineItems);
                bodypropCount++;
            }

            var paymentOptionsObject = new JObject();
            var paymentOptionsObjectpropCount = 0;
            if (bodypaymentOptionspaymentGateways != null)
            {
                paymentOptionsObject["payment_gateways"] = ExpressionConverter.ConvertO(bodypaymentOptionspaymentGateways);
                paymentOptionsObjectpropCount++;
            }

            if (paymentOptionsObjectpropCount > 0)
            {
                body["payment_options"] = paymentOptionsObject;
                bodypropCount++;
            }

            if (bodyallowPartialPayments != null)
            {
                body["allow_partial_payments"] = ExpressionConverter.ConvertO(bodyallowPartialPayments);
                bodypropCount++;
            }

            if (bodycustomBody != null)
            {
                body["custom_body"] = ExpressionConverter.ConvertO(bodycustomBody);
                bodypropCount++;
            }

            if (bodycustomSubject != null)
            {
                body["custom_subject"] = ExpressionConverter.ConvertO(bodycustomSubject);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            if (bodyterms != null)
            {
                body["terms"] = ExpressionConverter.ConvertO(bodyterms);
                bodypropCount++;
            }

            if (bodyshippingCharge != null)
            {
                body["shipping_charge"] = ExpressionConverter.ConvertO(bodyshippingCharge);
                bodypropCount++;
            }

            if (bodyadjustment != null)
            {
                body["adjustment"] = ExpressionConverter.ConvertO(bodyadjustment);
                bodypropCount++;
            }

            if (bodyadjustmentDescription != null)
            {
                body["adjustment_description"] = ExpressionConverter.ConvertO(bodyadjustmentDescription);
                bodypropCount++;
            }

            if (bodyreason != null)
            {
                body["reason"] = ExpressionConverter.ConvertO(bodyreason);
                bodypropCount++;
            }

            if (bodytaxAuthorityId != null)
            {
                body["tax_authority_id"] = ExpressionConverter.ConvertO(bodytaxAuthorityId);
                bodypropCount++;
            }

            if (bodytaxExemptionId != null)
            {
                body["tax_exemption_id"] = ExpressionConverter.ConvertO(bodytaxExemptionId);
                bodypropCount++;
            }

            if (bodyavataxUseCode != null)
            {
                body["avatax_use_code"] = ExpressionConverter.ConvertO(bodyavataxUseCode);
                bodypropCount++;
            }

            if (bodyavataxTaxCode != null)
            {
                body["avatax_tax_code"] = ExpressionConverter.ConvertO(bodyavataxTaxCode);
                bodypropCount++;
            }

            if (bodyavataxExemptNo != null)
            {
                body["avatax_exempt_no"] = ExpressionConverter.ConvertO(bodyavataxExemptNo);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<InvoicePutResponse>(callPayload);
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