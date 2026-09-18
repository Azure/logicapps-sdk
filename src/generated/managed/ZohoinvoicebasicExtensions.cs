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
        public IBodyWorkflowAction<ContactsGetResponse> ContactsGet([WorkflowExpression] Func<string> contactName = null, [WorkflowExpression] Func<string> companyName = null, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> address = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> phone = null, [WorkflowExpression] Func<filterByInput> filterBy = null, [WorkflowExpression] Func<string> searchText = null, [WorkflowExpression] Func<sortColumnInput> sortColumn = null, [WorkflowExpression] Func<int> zcrmContactId = null, [WorkflowExpression] Func<int> zcrmAccountId = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(contactName, nameof(contactName), required: false);
            SourceExpression.Validate(companyName, nameof(companyName), required: false);
            SourceExpression.Validate(firstName, nameof(firstName), required: false);
            SourceExpression.Validate(lastName, nameof(lastName), required: false);
            SourceExpression.Validate(address, nameof(address), required: false);
            SourceExpression.Validate(email, nameof(email), required: false);
            SourceExpression.Validate(phone, nameof(phone), required: false);
            SourceExpression.Validate(filterBy, nameof(filterBy), required: false);
            SourceExpression.Validate(searchText, nameof(searchText), required: false);
            SourceExpression.Validate(sortColumn, nameof(sortColumn), required: false);
            SourceExpression.Validate(zcrmContactId, nameof(zcrmContactId), required: false);
            SourceExpression.Validate(zcrmAccountId, nameof(zcrmAccountId), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invoice/v3/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (contactName != null)
                    callPayload.Queries["contact_name"] = SourceExpressionConverter.ConvertO(contactName);
                if (companyName != null)
                    callPayload.Queries["company_name"] = SourceExpressionConverter.ConvertO(companyName);
                if (firstName != null)
                    callPayload.Queries["first_name"] = SourceExpressionConverter.ConvertO(firstName);
                if (lastName != null)
                    callPayload.Queries["last_name"] = SourceExpressionConverter.ConvertO(lastName);
                if (address != null)
                    callPayload.Queries["address"] = SourceExpressionConverter.ConvertO(address);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (phone != null)
                    callPayload.Queries["phone"] = SourceExpressionConverter.ConvertO(phone);
                if (filterBy != null)
                    callPayload.Queries["filter_by"] = SourceExpressionConverter.Convert(filterBy);
                if (searchText != null)
                    callPayload.Queries["search_text"] = SourceExpressionConverter.ConvertO(searchText);
                if (sortColumn != null)
                    callPayload.Queries["sort_column"] = SourceExpressionConverter.Convert(sortColumn);
                if (zcrmContactId != null)
                    callPayload.Queries["zcrm_contact_id"] = SourceExpressionConverter.ConvertO(zcrmContactId);
                if (zcrmAccountId != null)
                    callPayload.Queries["zcrm_account_id"] = SourceExpressionConverter.ConvertO(zcrmAccountId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<ContactsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactPostResponse> Contact([WorkflowExpression] Func<string> bodycontactName, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<int> bodypaymentTerms = null, [WorkflowExpression] Func<string> bodycurrencyId = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<bodycustomFieldsInputItem[]> bodycustomFields = null, [WorkflowExpression] Func<string> bodybillingAddressattention = null, [WorkflowExpression] Func<string> bodybillingAddressaddress = null, [WorkflowExpression] Func<string> bodybillingAddressstreet2 = null, [WorkflowExpression] Func<string> bodybillingAddressstateCode = null, [WorkflowExpression] Func<string> bodybillingAddresscity = null, [WorkflowExpression] Func<string> bodybillingAddressstate = null, [WorkflowExpression] Func<string> bodybillingAddresszip = null, [WorkflowExpression] Func<string> bodybillingAddresscountry = null, [WorkflowExpression] Func<string> bodybillingAddressfax = null, [WorkflowExpression] Func<string> bodybillingAddressphone = null, [WorkflowExpression] Func<string> bodyshippingAddressattention = null, [WorkflowExpression] Func<string> bodyshippingAddressaddress = null, [WorkflowExpression] Func<string> bodyshippingAddressstreet2 = null, [WorkflowExpression] Func<string> bodyshippingAddressstateCode = null, [WorkflowExpression] Func<string> bodyshippingAddresscity = null, [WorkflowExpression] Func<string> bodyshippingAddressstate = null, [WorkflowExpression] Func<string> bodyshippingAddresszip = null, [WorkflowExpression] Func<string> bodyshippingAddresscountry = null, [WorkflowExpression] Func<string> bodyshippingAddressfax = null, [WorkflowExpression] Func<string> bodyshippingAddressphone = null, [WorkflowExpression] Func<bodycontactPersonsInputItem[]> bodycontactPersons = null, [WorkflowExpression] Func<string> bodydefaultTemplatesinvoiceTemplateId = null, [WorkflowExpression] Func<string> bodydefaultTemplatesinvoiceTemplateName = null, [WorkflowExpression] Func<string> bodydefaultTemplatesestimateTemplateId = null, [WorkflowExpression] Func<string> bodydefaultTemplatesestimateTemplateName = null, [WorkflowExpression] Func<string> bodydefaultTemplatescreditnoteTemplateId = null, [WorkflowExpression] Func<string> bodydefaultTemplatescreditnoteTemplateName = null, [WorkflowExpression] Func<string> bodydefaultTemplatesinvoiceEmailTemplateId = null, [WorkflowExpression] Func<string> bodydefaultTemplatesinvoiceEmailTemplateName = null, [WorkflowExpression] Func<string> bodydefaultTemplatesestimateEmailTemplateId = null, [WorkflowExpression] Func<string> bodydefaultTemplatesestimateEmailTemplateName = null, [WorkflowExpression] Func<string> bodydefaultTemplatescreditnoteEmailTemplateId = null, [WorkflowExpression] Func<string> bodydefaultTemplatescreditnoteEmailTemplateName = null, [WorkflowExpression] Func<bodylanguageCodeInput> bodylanguageCode = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodyvatRegNo = null, [WorkflowExpression] Func<string> bodytaxRegNo = null, [WorkflowExpression] Func<string> bodycountryCode = null, [WorkflowExpression] Func<string> bodyvatTreatment = null, [WorkflowExpression] Func<string> bodytaxTreatment = null, [WorkflowExpression] Func<bodytaxRegimeInput> bodytaxRegime = null, [WorkflowExpression] Func<string> bodylegalName = null, [WorkflowExpression] Func<bool> bodyisTdsRegistered = null, [WorkflowExpression] Func<string> bodyplaceOfContact = null, [WorkflowExpression] Func<string> bodygstNo = null, [WorkflowExpression] Func<bodygstTreatmentInput> bodygstTreatment = null, [WorkflowExpression] Func<string> bodytaxAuthorityName = null, [WorkflowExpression] Func<string> bodytaxExemptionCode = null, [WorkflowExpression] Func<string> bodyavataxExemptNo = null, [WorkflowExpression] Func<string> bodyavataxUseCode = null, [WorkflowExpression] Func<string> bodytaxExemptionId = null, [WorkflowExpression] Func<string> bodytaxAuthorityId = null, [WorkflowExpression] Func<string> bodytaxId = null, [WorkflowExpression] Func<string> bodytdsTaxId = null, [WorkflowExpression] Func<bool> bodyisTaxable = null, [WorkflowExpression] Func<string> bodyfacebook = null, [WorkflowExpression] Func<string> bodytwitter = null)
        {
            SourceExpression.Validate(bodycontactName, nameof(bodycontactName), required: true);
            SourceExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            SourceExpression.Validate(bodypaymentTerms, nameof(bodypaymentTerms), required: false);
            SourceExpression.Validate(bodycurrencyId, nameof(bodycurrencyId), required: false);
            SourceExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            SourceExpression.Validate(bodycustomFields, nameof(bodycustomFields), required: false);
            SourceExpression.Validate(bodybillingAddressattention, nameof(bodybillingAddressattention), required: false);
            SourceExpression.Validate(bodybillingAddressaddress, nameof(bodybillingAddressaddress), required: false);
            SourceExpression.Validate(bodybillingAddressstreet2, nameof(bodybillingAddressstreet2), required: false);
            SourceExpression.Validate(bodybillingAddressstateCode, nameof(bodybillingAddressstateCode), required: false);
            SourceExpression.Validate(bodybillingAddresscity, nameof(bodybillingAddresscity), required: false);
            SourceExpression.Validate(bodybillingAddressstate, nameof(bodybillingAddressstate), required: false);
            SourceExpression.Validate(bodybillingAddresszip, nameof(bodybillingAddresszip), required: false);
            SourceExpression.Validate(bodybillingAddresscountry, nameof(bodybillingAddresscountry), required: false);
            SourceExpression.Validate(bodybillingAddressfax, nameof(bodybillingAddressfax), required: false);
            SourceExpression.Validate(bodybillingAddressphone, nameof(bodybillingAddressphone), required: false);
            SourceExpression.Validate(bodyshippingAddressattention, nameof(bodyshippingAddressattention), required: false);
            SourceExpression.Validate(bodyshippingAddressaddress, nameof(bodyshippingAddressaddress), required: false);
            SourceExpression.Validate(bodyshippingAddressstreet2, nameof(bodyshippingAddressstreet2), required: false);
            SourceExpression.Validate(bodyshippingAddressstateCode, nameof(bodyshippingAddressstateCode), required: false);
            SourceExpression.Validate(bodyshippingAddresscity, nameof(bodyshippingAddresscity), required: false);
            SourceExpression.Validate(bodyshippingAddressstate, nameof(bodyshippingAddressstate), required: false);
            SourceExpression.Validate(bodyshippingAddresszip, nameof(bodyshippingAddresszip), required: false);
            SourceExpression.Validate(bodyshippingAddresscountry, nameof(bodyshippingAddresscountry), required: false);
            SourceExpression.Validate(bodyshippingAddressfax, nameof(bodyshippingAddressfax), required: false);
            SourceExpression.Validate(bodyshippingAddressphone, nameof(bodyshippingAddressphone), required: false);
            SourceExpression.Validate(bodycontactPersons, nameof(bodycontactPersons), required: false);
            SourceExpression.Validate(bodydefaultTemplatesinvoiceTemplateId, nameof(bodydefaultTemplatesinvoiceTemplateId), required: false);
            SourceExpression.Validate(bodydefaultTemplatesinvoiceTemplateName, nameof(bodydefaultTemplatesinvoiceTemplateName), required: false);
            SourceExpression.Validate(bodydefaultTemplatesestimateTemplateId, nameof(bodydefaultTemplatesestimateTemplateId), required: false);
            SourceExpression.Validate(bodydefaultTemplatesestimateTemplateName, nameof(bodydefaultTemplatesestimateTemplateName), required: false);
            SourceExpression.Validate(bodydefaultTemplatescreditnoteTemplateId, nameof(bodydefaultTemplatescreditnoteTemplateId), required: false);
            SourceExpression.Validate(bodydefaultTemplatescreditnoteTemplateName, nameof(bodydefaultTemplatescreditnoteTemplateName), required: false);
            SourceExpression.Validate(bodydefaultTemplatesinvoiceEmailTemplateId, nameof(bodydefaultTemplatesinvoiceEmailTemplateId), required: false);
            SourceExpression.Validate(bodydefaultTemplatesinvoiceEmailTemplateName, nameof(bodydefaultTemplatesinvoiceEmailTemplateName), required: false);
            SourceExpression.Validate(bodydefaultTemplatesestimateEmailTemplateId, nameof(bodydefaultTemplatesestimateEmailTemplateId), required: false);
            SourceExpression.Validate(bodydefaultTemplatesestimateEmailTemplateName, nameof(bodydefaultTemplatesestimateEmailTemplateName), required: false);
            SourceExpression.Validate(bodydefaultTemplatescreditnoteEmailTemplateId, nameof(bodydefaultTemplatescreditnoteEmailTemplateId), required: false);
            SourceExpression.Validate(bodydefaultTemplatescreditnoteEmailTemplateName, nameof(bodydefaultTemplatescreditnoteEmailTemplateName), required: false);
            SourceExpression.Validate(bodylanguageCode, nameof(bodylanguageCode), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodyvatRegNo, nameof(bodyvatRegNo), required: false);
            SourceExpression.Validate(bodytaxRegNo, nameof(bodytaxRegNo), required: false);
            SourceExpression.Validate(bodycountryCode, nameof(bodycountryCode), required: false);
            SourceExpression.Validate(bodyvatTreatment, nameof(bodyvatTreatment), required: false);
            SourceExpression.Validate(bodytaxTreatment, nameof(bodytaxTreatment), required: false);
            SourceExpression.Validate(bodytaxRegime, nameof(bodytaxRegime), required: false);
            SourceExpression.Validate(bodylegalName, nameof(bodylegalName), required: false);
            SourceExpression.Validate(bodyisTdsRegistered, nameof(bodyisTdsRegistered), required: false);
            SourceExpression.Validate(bodyplaceOfContact, nameof(bodyplaceOfContact), required: false);
            SourceExpression.Validate(bodygstNo, nameof(bodygstNo), required: false);
            SourceExpression.Validate(bodygstTreatment, nameof(bodygstTreatment), required: false);
            SourceExpression.Validate(bodytaxAuthorityName, nameof(bodytaxAuthorityName), required: false);
            SourceExpression.Validate(bodytaxExemptionCode, nameof(bodytaxExemptionCode), required: false);
            SourceExpression.Validate(bodyavataxExemptNo, nameof(bodyavataxExemptNo), required: false);
            SourceExpression.Validate(bodyavataxUseCode, nameof(bodyavataxUseCode), required: false);
            SourceExpression.Validate(bodytaxExemptionId, nameof(bodytaxExemptionId), required: false);
            SourceExpression.Validate(bodytaxAuthorityId, nameof(bodytaxAuthorityId), required: false);
            SourceExpression.Validate(bodytaxId, nameof(bodytaxId), required: false);
            SourceExpression.Validate(bodytdsTaxId, nameof(bodytdsTaxId), required: false);
            SourceExpression.Validate(bodyisTaxable, nameof(bodyisTaxable), required: false);
            SourceExpression.Validate(bodyfacebook, nameof(bodyfacebook), required: false);
            SourceExpression.Validate(bodytwitter, nameof(bodytwitter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invoice/v3/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["contact_name"] = SourceExpressionConverter.ConvertToken(bodycontactName);
                if (bodycompanyName != null)
                {
                    body["company_name"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                    bodypropCount++;
                }

                if (bodypaymentTerms != null)
                {
                    body["payment_terms"] = SourceExpressionConverter.ConvertToken(bodypaymentTerms);
                    bodypropCount++;
                }

                if (bodycurrencyId != null)
                {
                    body["currency_id"] = SourceExpressionConverter.ConvertToken(bodycurrencyId);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = SourceExpressionConverter.ConvertToken(bodywebsite);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["custom_fields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                var billingAddressObject = new JObject();
                var billingAddressObjectpropCount = 0;
                if (bodybillingAddressattention != null)
                {
                    billingAddressObject["attention"] = SourceExpressionConverter.ConvertToken(bodybillingAddressattention);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddressaddress != null)
                {
                    billingAddressObject["address"] = SourceExpressionConverter.ConvertToken(bodybillingAddressaddress);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddressstreet2 != null)
                {
                    billingAddressObject["street2"] = SourceExpressionConverter.ConvertToken(bodybillingAddressstreet2);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddressstateCode != null)
                {
                    billingAddressObject["state_code"] = SourceExpressionConverter.ConvertToken(bodybillingAddressstateCode);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddresscity != null)
                {
                    billingAddressObject["city"] = SourceExpressionConverter.ConvertToken(bodybillingAddresscity);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddressstate != null)
                {
                    billingAddressObject["state"] = SourceExpressionConverter.ConvertToken(bodybillingAddressstate);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddresszip != null)
                {
                    billingAddressObject["zip"] = SourceExpressionConverter.ConvertToken(bodybillingAddresszip);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddresscountry != null)
                {
                    billingAddressObject["country"] = SourceExpressionConverter.ConvertToken(bodybillingAddresscountry);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddressfax != null)
                {
                    billingAddressObject["fax"] = SourceExpressionConverter.ConvertToken(bodybillingAddressfax);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddressphone != null)
                {
                    billingAddressObject["phone"] = SourceExpressionConverter.ConvertToken(bodybillingAddressphone);
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
                    shippingAddressObject["attention"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressattention);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddressaddress != null)
                {
                    shippingAddressObject["address"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressaddress);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddressstreet2 != null)
                {
                    shippingAddressObject["street2"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressstreet2);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddressstateCode != null)
                {
                    shippingAddressObject["state_code"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressstateCode);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddresscity != null)
                {
                    shippingAddressObject["city"] = SourceExpressionConverter.ConvertToken(bodyshippingAddresscity);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddressstate != null)
                {
                    shippingAddressObject["state"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressstate);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddresszip != null)
                {
                    shippingAddressObject["zip"] = SourceExpressionConverter.ConvertToken(bodyshippingAddresszip);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddresscountry != null)
                {
                    shippingAddressObject["country"] = SourceExpressionConverter.ConvertToken(bodyshippingAddresscountry);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddressfax != null)
                {
                    shippingAddressObject["fax"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressfax);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddressphone != null)
                {
                    shippingAddressObject["phone"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressphone);
                    shippingAddressObjectpropCount++;
                }

                if (shippingAddressObjectpropCount > 0)
                {
                    body["shipping_address"] = shippingAddressObject;
                    bodypropCount++;
                }

                if (bodycontactPersons != null)
                {
                    body["contact_persons"] = SourceExpressionConverter.ConvertToken(bodycontactPersons);
                    bodypropCount++;
                }

                var defaultTemplatesObject = new JObject();
                var defaultTemplatesObjectpropCount = 0;
                if (bodydefaultTemplatesinvoiceTemplateId != null)
                {
                    defaultTemplatesObject["invoice_template_id"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesinvoiceTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesinvoiceTemplateName != null)
                {
                    defaultTemplatesObject["invoice_template_name"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesinvoiceTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesestimateTemplateId != null)
                {
                    defaultTemplatesObject["estimate_template_id"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesestimateTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesestimateTemplateName != null)
                {
                    defaultTemplatesObject["estimate_template_name"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesestimateTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatescreditnoteTemplateId != null)
                {
                    defaultTemplatesObject["creditnote_template_id"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatescreditnoteTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatescreditnoteTemplateName != null)
                {
                    defaultTemplatesObject["creditnote_template_name"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatescreditnoteTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesinvoiceEmailTemplateId != null)
                {
                    defaultTemplatesObject["invoice_email_template_id"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesinvoiceEmailTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesinvoiceEmailTemplateName != null)
                {
                    defaultTemplatesObject["invoice_email_template_name"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesinvoiceEmailTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesestimateEmailTemplateId != null)
                {
                    defaultTemplatesObject["estimate_email_template_id"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesestimateEmailTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesestimateEmailTemplateName != null)
                {
                    defaultTemplatesObject["estimate_email_template_name"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesestimateEmailTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatescreditnoteEmailTemplateId != null)
                {
                    defaultTemplatesObject["creditnote_email_template_id"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatescreditnoteEmailTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatescreditnoteEmailTemplateName != null)
                {
                    defaultTemplatesObject["creditnote_email_template_name"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatescreditnoteEmailTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (defaultTemplatesObjectpropCount > 0)
                {
                    body["default_templates"] = defaultTemplatesObject;
                    bodypropCount++;
                }

                if (bodylanguageCode != null)
                {
                    body["language_code"] = SourceExpressionConverter.Convert(bodylanguageCode);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyvatRegNo != null)
                {
                    body["vat_reg_no"] = SourceExpressionConverter.ConvertToken(bodyvatRegNo);
                    bodypropCount++;
                }

                if (bodytaxRegNo != null)
                {
                    body["tax_reg_no"] = SourceExpressionConverter.ConvertToken(bodytaxRegNo);
                    bodypropCount++;
                }

                if (bodycountryCode != null)
                {
                    body["country_code"] = SourceExpressionConverter.ConvertToken(bodycountryCode);
                    bodypropCount++;
                }

                if (bodyvatTreatment != null)
                {
                    body["vat_treatment"] = SourceExpressionConverter.ConvertToken(bodyvatTreatment);
                    bodypropCount++;
                }

                if (bodytaxTreatment != null)
                {
                    body["tax_treatment"] = SourceExpressionConverter.ConvertToken(bodytaxTreatment);
                    bodypropCount++;
                }

                if (bodytaxRegime != null)
                {
                    body["tax_regime"] = SourceExpressionConverter.Convert(bodytaxRegime);
                    bodypropCount++;
                }

                if (bodylegalName != null)
                {
                    body["legal_name"] = SourceExpressionConverter.ConvertToken(bodylegalName);
                    bodypropCount++;
                }

                if (bodyisTdsRegistered != null)
                {
                    body["is_tds_registered"] = SourceExpressionConverter.ConvertToken(bodyisTdsRegistered);
                    bodypropCount++;
                }

                if (bodyplaceOfContact != null)
                {
                    body["place_of_contact"] = SourceExpressionConverter.ConvertToken(bodyplaceOfContact);
                    bodypropCount++;
                }

                if (bodygstNo != null)
                {
                    body["gst_no"] = SourceExpressionConverter.ConvertToken(bodygstNo);
                    bodypropCount++;
                }

                if (bodygstTreatment != null)
                {
                    body["gst_treatment"] = SourceExpressionConverter.Convert(bodygstTreatment);
                    bodypropCount++;
                }

                if (bodytaxAuthorityName != null)
                {
                    body["tax_authority_name"] = SourceExpressionConverter.ConvertToken(bodytaxAuthorityName);
                    bodypropCount++;
                }

                if (bodytaxExemptionCode != null)
                {
                    body["tax_exemption_code"] = SourceExpressionConverter.ConvertToken(bodytaxExemptionCode);
                    bodypropCount++;
                }

                if (bodyavataxExemptNo != null)
                {
                    body["avatax_exempt_no"] = SourceExpressionConverter.ConvertToken(bodyavataxExemptNo);
                    bodypropCount++;
                }

                if (bodyavataxUseCode != null)
                {
                    body["avatax_use_code"] = SourceExpressionConverter.ConvertToken(bodyavataxUseCode);
                    bodypropCount++;
                }

                if (bodytaxExemptionId != null)
                {
                    body["tax_exemption_id"] = SourceExpressionConverter.ConvertToken(bodytaxExemptionId);
                    bodypropCount++;
                }

                if (bodytaxAuthorityId != null)
                {
                    body["tax_authority_id"] = SourceExpressionConverter.ConvertToken(bodytaxAuthorityId);
                    bodypropCount++;
                }

                if (bodytaxId != null)
                {
                    body["tax_id"] = SourceExpressionConverter.ConvertToken(bodytaxId);
                    bodypropCount++;
                }

                if (bodytdsTaxId != null)
                {
                    body["tds_tax_id"] = SourceExpressionConverter.ConvertToken(bodytdsTaxId);
                    bodypropCount++;
                }

                if (bodyisTaxable != null)
                {
                    body["is_taxable"] = SourceExpressionConverter.ConvertToken(bodyisTaxable);
                    bodypropCount++;
                }

                if (bodyfacebook != null)
                {
                    body["facebook"] = SourceExpressionConverter.ConvertToken(bodyfacebook);
                    bodypropCount++;
                }

                if (bodytwitter != null)
                {
                    body["twitter"] = SourceExpressionConverter.ConvertToken(bodytwitter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactGetResponse> ContactGet([WorkflowExpression] Func<string> contactId)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoice/v3/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ContactGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactDeleteResponse> ContactDelete([WorkflowExpression] Func<string> contactId)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoice/v3/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ContactDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactPutResponse> ContactPut([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<string> bodycontactName, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<int> bodypaymentTerms = null, [WorkflowExpression] Func<string> bodycurrencyId = null, [WorkflowExpression] Func<string> bodywebsite = null, [WorkflowExpression] Func<bodycustomFieldsInputItem2[]> bodycustomFields = null, [WorkflowExpression] Func<string> bodybillingAddressattention = null, [WorkflowExpression] Func<string> bodybillingAddressaddress = null, [WorkflowExpression] Func<string> bodybillingAddressstreet2 = null, [WorkflowExpression] Func<string> bodybillingAddressstateCode = null, [WorkflowExpression] Func<string> bodybillingAddresscity = null, [WorkflowExpression] Func<string> bodybillingAddressstate = null, [WorkflowExpression] Func<string> bodybillingAddresszip = null, [WorkflowExpression] Func<string> bodybillingAddresscountry = null, [WorkflowExpression] Func<string> bodybillingAddressfax = null, [WorkflowExpression] Func<string> bodybillingAddressphone = null, [WorkflowExpression] Func<string> bodyshippingAddressattention = null, [WorkflowExpression] Func<string> bodyshippingAddressaddress = null, [WorkflowExpression] Func<string> bodyshippingAddressstreet2 = null, [WorkflowExpression] Func<string> bodyshippingAddressstateCode = null, [WorkflowExpression] Func<string> bodyshippingAddresscity = null, [WorkflowExpression] Func<string> bodyshippingAddressstate = null, [WorkflowExpression] Func<string> bodyshippingAddresszip = null, [WorkflowExpression] Func<string> bodyshippingAddresscountry = null, [WorkflowExpression] Func<string> bodyshippingAddressfax = null, [WorkflowExpression] Func<string> bodyshippingAddressphone = null, [WorkflowExpression] Func<bodycontactPersonsInputItem[]> bodycontactPersons = null, [WorkflowExpression] Func<string> bodydefaultTemplatesinvoiceTemplateId = null, [WorkflowExpression] Func<string> bodydefaultTemplatesinvoiceTemplateName = null, [WorkflowExpression] Func<string> bodydefaultTemplatesestimateTemplateId = null, [WorkflowExpression] Func<string> bodydefaultTemplatesestimateTemplateName = null, [WorkflowExpression] Func<string> bodydefaultTemplatescreditnoteTemplateId = null, [WorkflowExpression] Func<string> bodydefaultTemplatescreditnoteTemplateName = null, [WorkflowExpression] Func<string> bodydefaultTemplatesinvoiceEmailTemplateId = null, [WorkflowExpression] Func<string> bodydefaultTemplatesinvoiceEmailTemplateName = null, [WorkflowExpression] Func<string> bodydefaultTemplatesestimateEmailTemplateId = null, [WorkflowExpression] Func<string> bodydefaultTemplatesestimateEmailTemplateName = null, [WorkflowExpression] Func<string> bodydefaultTemplatescreditnoteEmailTemplateId = null, [WorkflowExpression] Func<string> bodydefaultTemplatescreditnoteEmailTemplateName = null, [WorkflowExpression] Func<bodylanguageCodeInput> bodylanguageCode = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodyvatRegNo = null, [WorkflowExpression] Func<string> bodytaxRegNo = null, [WorkflowExpression] Func<string> bodycountryCode = null, [WorkflowExpression] Func<bodyvatTreatmentInput> bodyvatTreatment = null, [WorkflowExpression] Func<string> bodytaxTreatment = null, [WorkflowExpression] Func<bodytaxRegimeInput> bodytaxRegime = null, [WorkflowExpression] Func<string> bodylegalName = null, [WorkflowExpression] Func<bool> bodyisTdsRegistered = null, [WorkflowExpression] Func<string> bodyplaceOfContact = null, [WorkflowExpression] Func<string> bodygstNo = null, [WorkflowExpression] Func<bodygstTreatmentInput> bodygstTreatment = null, [WorkflowExpression] Func<string> bodytaxAuthorityName = null, [WorkflowExpression] Func<string> bodytaxExemptionCode = null, [WorkflowExpression] Func<string> bodyavataxExemptNo = null, [WorkflowExpression] Func<string> bodyavataxUseCode = null, [WorkflowExpression] Func<string> bodytaxExemptionId = null, [WorkflowExpression] Func<string> bodytaxAuthorityId = null, [WorkflowExpression] Func<string> bodytaxId = null, [WorkflowExpression] Func<string> bodytdsTaxId = null, [WorkflowExpression] Func<bool> bodyisTaxable = null, [WorkflowExpression] Func<string> bodyfacebook = null, [WorkflowExpression] Func<string> bodytwitter = null)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            SourceExpression.Validate(bodycontactName, nameof(bodycontactName), required: true);
            SourceExpression.Validate(bodycompanyName, nameof(bodycompanyName), required: false);
            SourceExpression.Validate(bodypaymentTerms, nameof(bodypaymentTerms), required: false);
            SourceExpression.Validate(bodycurrencyId, nameof(bodycurrencyId), required: false);
            SourceExpression.Validate(bodywebsite, nameof(bodywebsite), required: false);
            SourceExpression.Validate(bodycustomFields, nameof(bodycustomFields), required: false);
            SourceExpression.Validate(bodybillingAddressattention, nameof(bodybillingAddressattention), required: false);
            SourceExpression.Validate(bodybillingAddressaddress, nameof(bodybillingAddressaddress), required: false);
            SourceExpression.Validate(bodybillingAddressstreet2, nameof(bodybillingAddressstreet2), required: false);
            SourceExpression.Validate(bodybillingAddressstateCode, nameof(bodybillingAddressstateCode), required: false);
            SourceExpression.Validate(bodybillingAddresscity, nameof(bodybillingAddresscity), required: false);
            SourceExpression.Validate(bodybillingAddressstate, nameof(bodybillingAddressstate), required: false);
            SourceExpression.Validate(bodybillingAddresszip, nameof(bodybillingAddresszip), required: false);
            SourceExpression.Validate(bodybillingAddresscountry, nameof(bodybillingAddresscountry), required: false);
            SourceExpression.Validate(bodybillingAddressfax, nameof(bodybillingAddressfax), required: false);
            SourceExpression.Validate(bodybillingAddressphone, nameof(bodybillingAddressphone), required: false);
            SourceExpression.Validate(bodyshippingAddressattention, nameof(bodyshippingAddressattention), required: false);
            SourceExpression.Validate(bodyshippingAddressaddress, nameof(bodyshippingAddressaddress), required: false);
            SourceExpression.Validate(bodyshippingAddressstreet2, nameof(bodyshippingAddressstreet2), required: false);
            SourceExpression.Validate(bodyshippingAddressstateCode, nameof(bodyshippingAddressstateCode), required: false);
            SourceExpression.Validate(bodyshippingAddresscity, nameof(bodyshippingAddresscity), required: false);
            SourceExpression.Validate(bodyshippingAddressstate, nameof(bodyshippingAddressstate), required: false);
            SourceExpression.Validate(bodyshippingAddresszip, nameof(bodyshippingAddresszip), required: false);
            SourceExpression.Validate(bodyshippingAddresscountry, nameof(bodyshippingAddresscountry), required: false);
            SourceExpression.Validate(bodyshippingAddressfax, nameof(bodyshippingAddressfax), required: false);
            SourceExpression.Validate(bodyshippingAddressphone, nameof(bodyshippingAddressphone), required: false);
            SourceExpression.Validate(bodycontactPersons, nameof(bodycontactPersons), required: false);
            SourceExpression.Validate(bodydefaultTemplatesinvoiceTemplateId, nameof(bodydefaultTemplatesinvoiceTemplateId), required: false);
            SourceExpression.Validate(bodydefaultTemplatesinvoiceTemplateName, nameof(bodydefaultTemplatesinvoiceTemplateName), required: false);
            SourceExpression.Validate(bodydefaultTemplatesestimateTemplateId, nameof(bodydefaultTemplatesestimateTemplateId), required: false);
            SourceExpression.Validate(bodydefaultTemplatesestimateTemplateName, nameof(bodydefaultTemplatesestimateTemplateName), required: false);
            SourceExpression.Validate(bodydefaultTemplatescreditnoteTemplateId, nameof(bodydefaultTemplatescreditnoteTemplateId), required: false);
            SourceExpression.Validate(bodydefaultTemplatescreditnoteTemplateName, nameof(bodydefaultTemplatescreditnoteTemplateName), required: false);
            SourceExpression.Validate(bodydefaultTemplatesinvoiceEmailTemplateId, nameof(bodydefaultTemplatesinvoiceEmailTemplateId), required: false);
            SourceExpression.Validate(bodydefaultTemplatesinvoiceEmailTemplateName, nameof(bodydefaultTemplatesinvoiceEmailTemplateName), required: false);
            SourceExpression.Validate(bodydefaultTemplatesestimateEmailTemplateId, nameof(bodydefaultTemplatesestimateEmailTemplateId), required: false);
            SourceExpression.Validate(bodydefaultTemplatesestimateEmailTemplateName, nameof(bodydefaultTemplatesestimateEmailTemplateName), required: false);
            SourceExpression.Validate(bodydefaultTemplatescreditnoteEmailTemplateId, nameof(bodydefaultTemplatescreditnoteEmailTemplateId), required: false);
            SourceExpression.Validate(bodydefaultTemplatescreditnoteEmailTemplateName, nameof(bodydefaultTemplatescreditnoteEmailTemplateName), required: false);
            SourceExpression.Validate(bodylanguageCode, nameof(bodylanguageCode), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodyvatRegNo, nameof(bodyvatRegNo), required: false);
            SourceExpression.Validate(bodytaxRegNo, nameof(bodytaxRegNo), required: false);
            SourceExpression.Validate(bodycountryCode, nameof(bodycountryCode), required: false);
            SourceExpression.Validate(bodyvatTreatment, nameof(bodyvatTreatment), required: false);
            SourceExpression.Validate(bodytaxTreatment, nameof(bodytaxTreatment), required: false);
            SourceExpression.Validate(bodytaxRegime, nameof(bodytaxRegime), required: false);
            SourceExpression.Validate(bodylegalName, nameof(bodylegalName), required: false);
            SourceExpression.Validate(bodyisTdsRegistered, nameof(bodyisTdsRegistered), required: false);
            SourceExpression.Validate(bodyplaceOfContact, nameof(bodyplaceOfContact), required: false);
            SourceExpression.Validate(bodygstNo, nameof(bodygstNo), required: false);
            SourceExpression.Validate(bodygstTreatment, nameof(bodygstTreatment), required: false);
            SourceExpression.Validate(bodytaxAuthorityName, nameof(bodytaxAuthorityName), required: false);
            SourceExpression.Validate(bodytaxExemptionCode, nameof(bodytaxExemptionCode), required: false);
            SourceExpression.Validate(bodyavataxExemptNo, nameof(bodyavataxExemptNo), required: false);
            SourceExpression.Validate(bodyavataxUseCode, nameof(bodyavataxUseCode), required: false);
            SourceExpression.Validate(bodytaxExemptionId, nameof(bodytaxExemptionId), required: false);
            SourceExpression.Validate(bodytaxAuthorityId, nameof(bodytaxAuthorityId), required: false);
            SourceExpression.Validate(bodytaxId, nameof(bodytaxId), required: false);
            SourceExpression.Validate(bodytdsTaxId, nameof(bodytdsTaxId), required: false);
            SourceExpression.Validate(bodyisTaxable, nameof(bodyisTaxable), required: false);
            SourceExpression.Validate(bodyfacebook, nameof(bodyfacebook), required: false);
            SourceExpression.Validate(bodytwitter, nameof(bodytwitter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoice/v3/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["contact_name"] = SourceExpressionConverter.ConvertToken(bodycontactName);
                if (bodycompanyName != null)
                {
                    body["company_name"] = SourceExpressionConverter.ConvertToken(bodycompanyName);
                    bodypropCount++;
                }

                if (bodypaymentTerms != null)
                {
                    body["payment_terms"] = SourceExpressionConverter.ConvertToken(bodypaymentTerms);
                    bodypropCount++;
                }

                if (bodycurrencyId != null)
                {
                    body["currency_id"] = SourceExpressionConverter.ConvertToken(bodycurrencyId);
                    bodypropCount++;
                }

                if (bodywebsite != null)
                {
                    body["website"] = SourceExpressionConverter.ConvertToken(bodywebsite);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["custom_fields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                var billingAddressObject = new JObject();
                var billingAddressObjectpropCount = 0;
                if (bodybillingAddressattention != null)
                {
                    billingAddressObject["attention"] = SourceExpressionConverter.ConvertToken(bodybillingAddressattention);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddressaddress != null)
                {
                    billingAddressObject["address"] = SourceExpressionConverter.ConvertToken(bodybillingAddressaddress);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddressstreet2 != null)
                {
                    billingAddressObject["street2"] = SourceExpressionConverter.ConvertToken(bodybillingAddressstreet2);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddressstateCode != null)
                {
                    billingAddressObject["state_code"] = SourceExpressionConverter.ConvertToken(bodybillingAddressstateCode);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddresscity != null)
                {
                    billingAddressObject["city"] = SourceExpressionConverter.ConvertToken(bodybillingAddresscity);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddressstate != null)
                {
                    billingAddressObject["state"] = SourceExpressionConverter.ConvertToken(bodybillingAddressstate);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddresszip != null)
                {
                    billingAddressObject["zip"] = SourceExpressionConverter.ConvertToken(bodybillingAddresszip);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddresscountry != null)
                {
                    billingAddressObject["country"] = SourceExpressionConverter.ConvertToken(bodybillingAddresscountry);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddressfax != null)
                {
                    billingAddressObject["fax"] = SourceExpressionConverter.ConvertToken(bodybillingAddressfax);
                    billingAddressObjectpropCount++;
                }

                if (bodybillingAddressphone != null)
                {
                    billingAddressObject["phone"] = SourceExpressionConverter.ConvertToken(bodybillingAddressphone);
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
                    shippingAddressObject["attention"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressattention);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddressaddress != null)
                {
                    shippingAddressObject["address"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressaddress);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddressstreet2 != null)
                {
                    shippingAddressObject["street2"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressstreet2);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddressstateCode != null)
                {
                    shippingAddressObject["state_code"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressstateCode);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddresscity != null)
                {
                    shippingAddressObject["city"] = SourceExpressionConverter.ConvertToken(bodyshippingAddresscity);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddressstate != null)
                {
                    shippingAddressObject["state"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressstate);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddresszip != null)
                {
                    shippingAddressObject["zip"] = SourceExpressionConverter.ConvertToken(bodyshippingAddresszip);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddresscountry != null)
                {
                    shippingAddressObject["country"] = SourceExpressionConverter.ConvertToken(bodyshippingAddresscountry);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddressfax != null)
                {
                    shippingAddressObject["fax"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressfax);
                    shippingAddressObjectpropCount++;
                }

                if (bodyshippingAddressphone != null)
                {
                    shippingAddressObject["phone"] = SourceExpressionConverter.ConvertToken(bodyshippingAddressphone);
                    shippingAddressObjectpropCount++;
                }

                if (shippingAddressObjectpropCount > 0)
                {
                    body["shipping_address"] = shippingAddressObject;
                    bodypropCount++;
                }

                if (bodycontactPersons != null)
                {
                    body["contact_persons"] = SourceExpressionConverter.ConvertToken(bodycontactPersons);
                    bodypropCount++;
                }

                var defaultTemplatesObject = new JObject();
                var defaultTemplatesObjectpropCount = 0;
                if (bodydefaultTemplatesinvoiceTemplateId != null)
                {
                    defaultTemplatesObject["invoice_template_id"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesinvoiceTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesinvoiceTemplateName != null)
                {
                    defaultTemplatesObject["invoice_template_name"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesinvoiceTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesestimateTemplateId != null)
                {
                    defaultTemplatesObject["estimate_template_id"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesestimateTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesestimateTemplateName != null)
                {
                    defaultTemplatesObject["estimate_template_name"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesestimateTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatescreditnoteTemplateId != null)
                {
                    defaultTemplatesObject["creditnote_template_id"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatescreditnoteTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatescreditnoteTemplateName != null)
                {
                    defaultTemplatesObject["creditnote_template_name"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatescreditnoteTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesinvoiceEmailTemplateId != null)
                {
                    defaultTemplatesObject["invoice_email_template_id"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesinvoiceEmailTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesinvoiceEmailTemplateName != null)
                {
                    defaultTemplatesObject["invoice_email_template_name"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesinvoiceEmailTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesestimateEmailTemplateId != null)
                {
                    defaultTemplatesObject["estimate_email_template_id"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesestimateEmailTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatesestimateEmailTemplateName != null)
                {
                    defaultTemplatesObject["estimate_email_template_name"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatesestimateEmailTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatescreditnoteEmailTemplateId != null)
                {
                    defaultTemplatesObject["creditnote_email_template_id"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatescreditnoteEmailTemplateId);
                    defaultTemplatesObjectpropCount++;
                }

                if (bodydefaultTemplatescreditnoteEmailTemplateName != null)
                {
                    defaultTemplatesObject["creditnote_email_template_name"] = SourceExpressionConverter.ConvertToken(bodydefaultTemplatescreditnoteEmailTemplateName);
                    defaultTemplatesObjectpropCount++;
                }

                if (defaultTemplatesObjectpropCount > 0)
                {
                    body["default_templates"] = defaultTemplatesObject;
                    bodypropCount++;
                }

                if (bodylanguageCode != null)
                {
                    body["language_code"] = SourceExpressionConverter.Convert(bodylanguageCode);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyvatRegNo != null)
                {
                    body["vat_reg_no"] = SourceExpressionConverter.ConvertToken(bodyvatRegNo);
                    bodypropCount++;
                }

                if (bodytaxRegNo != null)
                {
                    body["tax_reg_no"] = SourceExpressionConverter.ConvertToken(bodytaxRegNo);
                    bodypropCount++;
                }

                if (bodycountryCode != null)
                {
                    body["country_code"] = SourceExpressionConverter.ConvertToken(bodycountryCode);
                    bodypropCount++;
                }

                if (bodyvatTreatment != null)
                {
                    body["vat_treatment"] = SourceExpressionConverter.Convert(bodyvatTreatment);
                    bodypropCount++;
                }

                if (bodytaxTreatment != null)
                {
                    body["tax_treatment"] = SourceExpressionConverter.ConvertToken(bodytaxTreatment);
                    bodypropCount++;
                }

                if (bodytaxRegime != null)
                {
                    body["tax_regime"] = SourceExpressionConverter.Convert(bodytaxRegime);
                    bodypropCount++;
                }

                if (bodylegalName != null)
                {
                    body["legal_name"] = SourceExpressionConverter.ConvertToken(bodylegalName);
                    bodypropCount++;
                }

                if (bodyisTdsRegistered != null)
                {
                    body["is_tds_registered"] = SourceExpressionConverter.ConvertToken(bodyisTdsRegistered);
                    bodypropCount++;
                }

                if (bodyplaceOfContact != null)
                {
                    body["place_of_contact"] = SourceExpressionConverter.ConvertToken(bodyplaceOfContact);
                    bodypropCount++;
                }

                if (bodygstNo != null)
                {
                    body["gst_no"] = SourceExpressionConverter.ConvertToken(bodygstNo);
                    bodypropCount++;
                }

                if (bodygstTreatment != null)
                {
                    body["gst_treatment"] = SourceExpressionConverter.Convert(bodygstTreatment);
                    bodypropCount++;
                }

                if (bodytaxAuthorityName != null)
                {
                    body["tax_authority_name"] = SourceExpressionConverter.ConvertToken(bodytaxAuthorityName);
                    bodypropCount++;
                }

                if (bodytaxExemptionCode != null)
                {
                    body["tax_exemption_code"] = SourceExpressionConverter.ConvertToken(bodytaxExemptionCode);
                    bodypropCount++;
                }

                if (bodyavataxExemptNo != null)
                {
                    body["avatax_exempt_no"] = SourceExpressionConverter.ConvertToken(bodyavataxExemptNo);
                    bodypropCount++;
                }

                if (bodyavataxUseCode != null)
                {
                    body["avatax_use_code"] = SourceExpressionConverter.ConvertToken(bodyavataxUseCode);
                    bodypropCount++;
                }

                if (bodytaxExemptionId != null)
                {
                    body["tax_exemption_id"] = SourceExpressionConverter.ConvertToken(bodytaxExemptionId);
                    bodypropCount++;
                }

                if (bodytaxAuthorityId != null)
                {
                    body["tax_authority_id"] = SourceExpressionConverter.ConvertToken(bodytaxAuthorityId);
                    bodypropCount++;
                }

                if (bodytaxId != null)
                {
                    body["tax_id"] = SourceExpressionConverter.ConvertToken(bodytaxId);
                    bodypropCount++;
                }

                if (bodytdsTaxId != null)
                {
                    body["tds_tax_id"] = SourceExpressionConverter.ConvertToken(bodytdsTaxId);
                    bodypropCount++;
                }

                if (bodyisTaxable != null)
                {
                    body["is_taxable"] = SourceExpressionConverter.ConvertToken(bodyisTaxable);
                    bodypropCount++;
                }

                if (bodyfacebook != null)
                {
                    body["facebook"] = SourceExpressionConverter.ConvertToken(bodyfacebook);
                    bodypropCount++;
                }

                if (bodytwitter != null)
                {
                    body["twitter"] = SourceExpressionConverter.ConvertToken(bodytwitter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ContactPutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoicesGetResponse> InvoicesGet([WorkflowExpression] Func<string> invoiceNumber = null, [WorkflowExpression] Func<string> itemName = null, [WorkflowExpression] Func<string> itemId = null, [WorkflowExpression] Func<string> itemDescription = null, [WorkflowExpression] Func<string> referenceNumber = null, [WorkflowExpression] Func<string> customerName = null, [WorkflowExpression] Func<string> recurringInvoiceId = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> total = null, [WorkflowExpression] Func<string> balance = null, [WorkflowExpression] Func<string> customField = null, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<string> dueDate = null, [WorkflowExpression] Func<statusInput> status = null, [WorkflowExpression] Func<string> customerId = null, [WorkflowExpression] Func<filterByInput> filterBy = null, [WorkflowExpression] Func<string> searchText = null, [WorkflowExpression] Func<sortColumnInput> sortColumn = null, [WorkflowExpression] Func<string> zcrmPotentialId = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(invoiceNumber, nameof(invoiceNumber), required: false);
            SourceExpression.Validate(itemName, nameof(itemName), required: false);
            SourceExpression.Validate(itemId, nameof(itemId), required: false);
            SourceExpression.Validate(itemDescription, nameof(itemDescription), required: false);
            SourceExpression.Validate(referenceNumber, nameof(referenceNumber), required: false);
            SourceExpression.Validate(customerName, nameof(customerName), required: false);
            SourceExpression.Validate(recurringInvoiceId, nameof(recurringInvoiceId), required: false);
            SourceExpression.Validate(email, nameof(email), required: false);
            SourceExpression.Validate(total, nameof(total), required: false);
            SourceExpression.Validate(balance, nameof(balance), required: false);
            SourceExpression.Validate(customField, nameof(customField), required: false);
            SourceExpression.Validate(date, nameof(date), required: false);
            SourceExpression.Validate(dueDate, nameof(dueDate), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(customerId, nameof(customerId), required: false);
            SourceExpression.Validate(filterBy, nameof(filterBy), required: false);
            SourceExpression.Validate(searchText, nameof(searchText), required: false);
            SourceExpression.Validate(sortColumn, nameof(sortColumn), required: false);
            SourceExpression.Validate(zcrmPotentialId, nameof(zcrmPotentialId), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invoice/v3/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (invoiceNumber != null)
                    callPayload.Queries["invoice_number"] = SourceExpressionConverter.ConvertO(invoiceNumber);
                if (itemName != null)
                    callPayload.Queries["item_name"] = SourceExpressionConverter.ConvertO(itemName);
                if (itemId != null)
                    callPayload.Queries["item_id"] = SourceExpressionConverter.ConvertO(itemId);
                if (itemDescription != null)
                    callPayload.Queries["item_description"] = SourceExpressionConverter.ConvertO(itemDescription);
                if (referenceNumber != null)
                    callPayload.Queries["reference_number"] = SourceExpressionConverter.ConvertO(referenceNumber);
                if (customerName != null)
                    callPayload.Queries["customer_name"] = SourceExpressionConverter.ConvertO(customerName);
                if (recurringInvoiceId != null)
                    callPayload.Queries["recurring_invoice_id"] = SourceExpressionConverter.ConvertO(recurringInvoiceId);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (total != null)
                    callPayload.Queries["total"] = SourceExpressionConverter.ConvertO(total);
                if (balance != null)
                    callPayload.Queries["balance"] = SourceExpressionConverter.ConvertO(balance);
                if (customField != null)
                    callPayload.Queries["custom_field"] = SourceExpressionConverter.ConvertO(customField);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                if (dueDate != null)
                    callPayload.Queries["due_date"] = SourceExpressionConverter.ConvertO(dueDate);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.Convert(status);
                if (customerId != null)
                    callPayload.Queries["customer_id"] = SourceExpressionConverter.ConvertO(customerId);
                if (filterBy != null)
                    callPayload.Queries["filter_by"] = SourceExpressionConverter.Convert(filterBy);
                if (searchText != null)
                    callPayload.Queries["search_text"] = SourceExpressionConverter.ConvertO(searchText);
                if (sortColumn != null)
                    callPayload.Queries["sort_column"] = SourceExpressionConverter.Convert(sortColumn);
                if (zcrmPotentialId != null)
                    callPayload.Queries["zcrm_potential_id"] = SourceExpressionConverter.ConvertO(zcrmPotentialId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (perPage != null)
                    callPayload.Queries["per_page"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<InvoicesGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoicePostResponse> Invoice([WorkflowExpression] Func<bool> send = null, [WorkflowExpression] Func<bool> ignoreAutoNumberGeneration = null, [WorkflowExpression] Func<string> bodycustomerId = null, [WorkflowExpression] Func<int[]> bodycontactPersons = null, [WorkflowExpression] Func<string> bodyinvoiceNumber = null, [WorkflowExpression] Func<string> bodyreferenceNumber = null, [WorkflowExpression] Func<string> bodyplaceOfSupply = null, [WorkflowExpression] Func<string> bodyvatTreatment = null, [WorkflowExpression] Func<string> bodygstTreatment = null, [WorkflowExpression] Func<string> bodytaxTreatment = null, [WorkflowExpression] Func<string> bodycfdiUsage = null, [WorkflowExpression] Func<string> bodygstNo = null, [WorkflowExpression] Func<string> bodytemplateId = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<int> bodypaymentTerms = null, [WorkflowExpression] Func<string> bodypaymentTermsLabel = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<double> bodydiscount = null, [WorkflowExpression] Func<bool> bodyisDiscountBeforeTax = null, [WorkflowExpression] Func<string> bodydiscountType = null, [WorkflowExpression] Func<bool> bodyisInclusiveTax = null, [WorkflowExpression] Func<double> bodyexchangeRate = null, [WorkflowExpression] Func<string> bodyrecurringInvoiceId = null, [WorkflowExpression] Func<string> bodyinvoicedEstimateId = null, [WorkflowExpression] Func<string> bodysalespersonName = null, [WorkflowExpression] Func<bodycustomFieldsInputItem22[]> bodycustomFields = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<bodylineItemsInputItem[]> bodylineItems = null, [WorkflowExpression] Func<bodypaymentOptionspaymentGatewaysInputItem[]> bodypaymentOptionspaymentGateways = null, [WorkflowExpression] Func<bool> bodyallowPartialPayments = null, [WorkflowExpression] Func<string> bodycustomBody = null, [WorkflowExpression] Func<string> bodycustomSubject = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodyterms = null, [WorkflowExpression] Func<double> bodyshippingCharge = null, [WorkflowExpression] Func<double> bodyadjustment = null, [WorkflowExpression] Func<string> bodyadjustmentDescription = null, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<string> bodytaxAuthorityId = null, [WorkflowExpression] Func<string> bodytaxExemptionId = null, [WorkflowExpression] Func<string> bodyavataxUseCode = null, [WorkflowExpression] Func<string> bodyavataxTaxCode = null, [WorkflowExpression] Func<string> bodyavataxExemptNo = null)
        {
            SourceExpression.Validate(send, nameof(send), required: false);
            SourceExpression.Validate(ignoreAutoNumberGeneration, nameof(ignoreAutoNumberGeneration), required: false);
            SourceExpression.Validate(bodycustomerId, nameof(bodycustomerId), required: false);
            SourceExpression.Validate(bodycontactPersons, nameof(bodycontactPersons), required: false);
            SourceExpression.Validate(bodyinvoiceNumber, nameof(bodyinvoiceNumber), required: false);
            SourceExpression.Validate(bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            SourceExpression.Validate(bodyplaceOfSupply, nameof(bodyplaceOfSupply), required: false);
            SourceExpression.Validate(bodyvatTreatment, nameof(bodyvatTreatment), required: false);
            SourceExpression.Validate(bodygstTreatment, nameof(bodygstTreatment), required: false);
            SourceExpression.Validate(bodytaxTreatment, nameof(bodytaxTreatment), required: false);
            SourceExpression.Validate(bodycfdiUsage, nameof(bodycfdiUsage), required: false);
            SourceExpression.Validate(bodygstNo, nameof(bodygstNo), required: false);
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodypaymentTerms, nameof(bodypaymentTerms), required: false);
            SourceExpression.Validate(bodypaymentTermsLabel, nameof(bodypaymentTermsLabel), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodydiscount, nameof(bodydiscount), required: false);
            SourceExpression.Validate(bodyisDiscountBeforeTax, nameof(bodyisDiscountBeforeTax), required: false);
            SourceExpression.Validate(bodydiscountType, nameof(bodydiscountType), required: false);
            SourceExpression.Validate(bodyisInclusiveTax, nameof(bodyisInclusiveTax), required: false);
            SourceExpression.Validate(bodyexchangeRate, nameof(bodyexchangeRate), required: false);
            SourceExpression.Validate(bodyrecurringInvoiceId, nameof(bodyrecurringInvoiceId), required: false);
            SourceExpression.Validate(bodyinvoicedEstimateId, nameof(bodyinvoicedEstimateId), required: false);
            SourceExpression.Validate(bodysalespersonName, nameof(bodysalespersonName), required: false);
            SourceExpression.Validate(bodycustomFields, nameof(bodycustomFields), required: false);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            SourceExpression.Validate(bodylineItems, nameof(bodylineItems), required: false);
            SourceExpression.Validate(bodypaymentOptionspaymentGateways, nameof(bodypaymentOptionspaymentGateways), required: false);
            SourceExpression.Validate(bodyallowPartialPayments, nameof(bodyallowPartialPayments), required: false);
            SourceExpression.Validate(bodycustomBody, nameof(bodycustomBody), required: false);
            SourceExpression.Validate(bodycustomSubject, nameof(bodycustomSubject), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodyterms, nameof(bodyterms), required: false);
            SourceExpression.Validate(bodyshippingCharge, nameof(bodyshippingCharge), required: false);
            SourceExpression.Validate(bodyadjustment, nameof(bodyadjustment), required: false);
            SourceExpression.Validate(bodyadjustmentDescription, nameof(bodyadjustmentDescription), required: false);
            SourceExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            SourceExpression.Validate(bodytaxAuthorityId, nameof(bodytaxAuthorityId), required: false);
            SourceExpression.Validate(bodytaxExemptionId, nameof(bodytaxExemptionId), required: false);
            SourceExpression.Validate(bodyavataxUseCode, nameof(bodyavataxUseCode), required: false);
            SourceExpression.Validate(bodyavataxTaxCode, nameof(bodyavataxTaxCode), required: false);
            SourceExpression.Validate(bodyavataxExemptNo, nameof(bodyavataxExemptNo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invoice/v3/invoices";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (send != null)
                    callPayload.Queries["send"] = SourceExpressionConverter.ConvertO(send);
                if (ignoreAutoNumberGeneration != null)
                    callPayload.Queries["ignore_auto_number_generation"] = SourceExpressionConverter.ConvertO(ignoreAutoNumberGeneration);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycustomerId != null)
                {
                    body["customer_id"] = SourceExpressionConverter.ConvertToken(bodycustomerId);
                    bodypropCount++;
                }

                if (bodycontactPersons != null)
                {
                    body["contact_persons"] = SourceExpressionConverter.ConvertToken(bodycontactPersons);
                    bodypropCount++;
                }

                if (bodyinvoiceNumber != null)
                {
                    body["invoice_number"] = SourceExpressionConverter.ConvertToken(bodyinvoiceNumber);
                    bodypropCount++;
                }

                if (bodyreferenceNumber != null)
                {
                    body["reference_number"] = SourceExpressionConverter.ConvertToken(bodyreferenceNumber);
                    bodypropCount++;
                }

                if (bodyplaceOfSupply != null)
                {
                    body["place_of_supply"] = SourceExpressionConverter.ConvertToken(bodyplaceOfSupply);
                    bodypropCount++;
                }

                if (bodyvatTreatment != null)
                {
                    body["vat_treatment"] = SourceExpressionConverter.ConvertToken(bodyvatTreatment);
                    bodypropCount++;
                }

                if (bodygstTreatment != null)
                {
                    body["gst_treatment"] = SourceExpressionConverter.ConvertToken(bodygstTreatment);
                    bodypropCount++;
                }

                if (bodytaxTreatment != null)
                {
                    body["tax_treatment"] = SourceExpressionConverter.ConvertToken(bodytaxTreatment);
                    bodypropCount++;
                }

                if (bodycfdiUsage != null)
                {
                    body["cfdi_usage"] = SourceExpressionConverter.ConvertToken(bodycfdiUsage);
                    bodypropCount++;
                }

                if (bodygstNo != null)
                {
                    body["gst_no"] = SourceExpressionConverter.ConvertToken(bodygstNo);
                    bodypropCount++;
                }

                if (bodytemplateId != null)
                {
                    body["template_id"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodypaymentTerms != null)
                {
                    body["payment_terms"] = SourceExpressionConverter.ConvertToken(bodypaymentTerms);
                    bodypropCount++;
                }

                if (bodypaymentTermsLabel != null)
                {
                    body["payment_terms_label"] = SourceExpressionConverter.ConvertToken(bodypaymentTermsLabel);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["due_date"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodydiscount != null)
                {
                    body["discount"] = SourceExpressionConverter.ConvertToken(bodydiscount);
                    bodypropCount++;
                }

                if (bodyisDiscountBeforeTax != null)
                {
                    body["is_discount_before_tax"] = SourceExpressionConverter.ConvertToken(bodyisDiscountBeforeTax);
                    bodypropCount++;
                }

                if (bodydiscountType != null)
                {
                    body["discount_type"] = SourceExpressionConverter.ConvertToken(bodydiscountType);
                    bodypropCount++;
                }

                if (bodyisInclusiveTax != null)
                {
                    body["is_inclusive_tax"] = SourceExpressionConverter.ConvertToken(bodyisInclusiveTax);
                    bodypropCount++;
                }

                if (bodyexchangeRate != null)
                {
                    body["exchange_rate"] = SourceExpressionConverter.ConvertToken(bodyexchangeRate);
                    bodypropCount++;
                }

                if (bodyrecurringInvoiceId != null)
                {
                    body["recurring_invoice_id"] = SourceExpressionConverter.ConvertToken(bodyrecurringInvoiceId);
                    bodypropCount++;
                }

                if (bodyinvoicedEstimateId != null)
                {
                    body["invoiced_estimate_id"] = SourceExpressionConverter.ConvertToken(bodyinvoicedEstimateId);
                    bodypropCount++;
                }

                if (bodysalespersonName != null)
                {
                    body["salesperson_name"] = SourceExpressionConverter.ConvertToken(bodysalespersonName);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["custom_fields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodylineItems != null)
                {
                    body["line_items"] = SourceExpressionConverter.ConvertToken(bodylineItems);
                    bodypropCount++;
                }

                var paymentOptionsObject = new JObject();
                var paymentOptionsObjectpropCount = 0;
                if (bodypaymentOptionspaymentGateways != null)
                {
                    paymentOptionsObject["payment_gateways"] = SourceExpressionConverter.ConvertToken(bodypaymentOptionspaymentGateways);
                    paymentOptionsObjectpropCount++;
                }

                if (paymentOptionsObjectpropCount > 0)
                {
                    body["payment_options"] = paymentOptionsObject;
                    bodypropCount++;
                }

                if (bodyallowPartialPayments != null)
                {
                    body["allow_partial_payments"] = SourceExpressionConverter.ConvertToken(bodyallowPartialPayments);
                    bodypropCount++;
                }

                if (bodycustomBody != null)
                {
                    body["custom_body"] = SourceExpressionConverter.ConvertToken(bodycustomBody);
                    bodypropCount++;
                }

                if (bodycustomSubject != null)
                {
                    body["custom_subject"] = SourceExpressionConverter.ConvertToken(bodycustomSubject);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyterms != null)
                {
                    body["terms"] = SourceExpressionConverter.ConvertToken(bodyterms);
                    bodypropCount++;
                }

                if (bodyshippingCharge != null)
                {
                    body["shipping_charge"] = SourceExpressionConverter.ConvertToken(bodyshippingCharge);
                    bodypropCount++;
                }

                if (bodyadjustment != null)
                {
                    body["adjustment"] = SourceExpressionConverter.ConvertToken(bodyadjustment);
                    bodypropCount++;
                }

                if (bodyadjustmentDescription != null)
                {
                    body["adjustment_description"] = SourceExpressionConverter.ConvertToken(bodyadjustmentDescription);
                    bodypropCount++;
                }

                if (bodyreason != null)
                {
                    body["reason"] = SourceExpressionConverter.ConvertToken(bodyreason);
                    bodypropCount++;
                }

                if (bodytaxAuthorityId != null)
                {
                    body["tax_authority_id"] = SourceExpressionConverter.ConvertToken(bodytaxAuthorityId);
                    bodypropCount++;
                }

                if (bodytaxExemptionId != null)
                {
                    body["tax_exemption_id"] = SourceExpressionConverter.ConvertToken(bodytaxExemptionId);
                    bodypropCount++;
                }

                if (bodyavataxUseCode != null)
                {
                    body["avatax_use_code"] = SourceExpressionConverter.ConvertToken(bodyavataxUseCode);
                    bodypropCount++;
                }

                if (bodyavataxTaxCode != null)
                {
                    body["avatax_tax_code"] = SourceExpressionConverter.ConvertToken(bodyavataxTaxCode);
                    bodypropCount++;
                }

                if (bodyavataxExemptNo != null)
                {
                    body["avatax_exempt_no"] = SourceExpressionConverter.ConvertToken(bodyavataxExemptNo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InvoicePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoiceGetResponse> InvoiceGet([WorkflowExpression] Func<string> invoiceId)
        {
            SourceExpression.Validate(invoiceId, nameof(invoiceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoice/v3/invoices/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(invoiceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoiceDeleteResponse> InvoiceDelete([WorkflowExpression] Func<string> invoiceId)
        {
            SourceExpression.Validate(invoiceId, nameof(invoiceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoice/v3/invoices/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(invoiceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<InvoiceDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoicePutResponse> InvoicePut([WorkflowExpression] Func<string> invoiceId, [WorkflowExpression] Func<string> bodycustomerId = null, [WorkflowExpression] Func<int[]> bodycontactPersons = null, [WorkflowExpression] Func<string> bodyinvoiceNumber = null, [WorkflowExpression] Func<string> bodyreferenceNumber = null, [WorkflowExpression] Func<string> bodyplaceOfSupply = null, [WorkflowExpression] Func<string> bodyvatTreatment = null, [WorkflowExpression] Func<string> bodygstTreatment = null, [WorkflowExpression] Func<string> bodytaxTreatment = null, [WorkflowExpression] Func<string> bodycfdiUsage = null, [WorkflowExpression] Func<string> bodygstNo = null, [WorkflowExpression] Func<string> bodytemplateId = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<int> bodypaymentTerms = null, [WorkflowExpression] Func<string> bodypaymentTermsLabel = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<double> bodydiscount = null, [WorkflowExpression] Func<bool> bodyisDiscountBeforeTax = null, [WorkflowExpression] Func<string> bodydiscountType = null, [WorkflowExpression] Func<bool> bodyisInclusiveTax = null, [WorkflowExpression] Func<double> bodyexchangeRate = null, [WorkflowExpression] Func<string> bodyrecurringInvoiceId = null, [WorkflowExpression] Func<string> bodyinvoicedEstimateId = null, [WorkflowExpression] Func<string> bodysalespersonName = null, [WorkflowExpression] Func<bodycustomFieldsInputItem22[]> bodycustomFields = null, [WorkflowExpression] Func<string> bodyprojectId = null, [WorkflowExpression] Func<bodylineItemsInputItem[]> bodylineItems = null, [WorkflowExpression] Func<bodypaymentOptionspaymentGatewaysInputItem[]> bodypaymentOptionspaymentGateways = null, [WorkflowExpression] Func<bool> bodyallowPartialPayments = null, [WorkflowExpression] Func<string> bodycustomBody = null, [WorkflowExpression] Func<string> bodycustomSubject = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodyterms = null, [WorkflowExpression] Func<double> bodyshippingCharge = null, [WorkflowExpression] Func<double> bodyadjustment = null, [WorkflowExpression] Func<string> bodyadjustmentDescription = null, [WorkflowExpression] Func<string> bodyreason = null, [WorkflowExpression] Func<string> bodytaxAuthorityId = null, [WorkflowExpression] Func<string> bodytaxExemptionId = null, [WorkflowExpression] Func<string> bodyavataxUseCode = null, [WorkflowExpression] Func<string> bodyavataxTaxCode = null, [WorkflowExpression] Func<string> bodyavataxExemptNo = null)
        {
            SourceExpression.Validate(invoiceId, nameof(invoiceId), required: true);
            SourceExpression.Validate(bodycustomerId, nameof(bodycustomerId), required: false);
            SourceExpression.Validate(bodycontactPersons, nameof(bodycontactPersons), required: false);
            SourceExpression.Validate(bodyinvoiceNumber, nameof(bodyinvoiceNumber), required: false);
            SourceExpression.Validate(bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            SourceExpression.Validate(bodyplaceOfSupply, nameof(bodyplaceOfSupply), required: false);
            SourceExpression.Validate(bodyvatTreatment, nameof(bodyvatTreatment), required: false);
            SourceExpression.Validate(bodygstTreatment, nameof(bodygstTreatment), required: false);
            SourceExpression.Validate(bodytaxTreatment, nameof(bodytaxTreatment), required: false);
            SourceExpression.Validate(bodycfdiUsage, nameof(bodycfdiUsage), required: false);
            SourceExpression.Validate(bodygstNo, nameof(bodygstNo), required: false);
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodypaymentTerms, nameof(bodypaymentTerms), required: false);
            SourceExpression.Validate(bodypaymentTermsLabel, nameof(bodypaymentTermsLabel), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodydiscount, nameof(bodydiscount), required: false);
            SourceExpression.Validate(bodyisDiscountBeforeTax, nameof(bodyisDiscountBeforeTax), required: false);
            SourceExpression.Validate(bodydiscountType, nameof(bodydiscountType), required: false);
            SourceExpression.Validate(bodyisInclusiveTax, nameof(bodyisInclusiveTax), required: false);
            SourceExpression.Validate(bodyexchangeRate, nameof(bodyexchangeRate), required: false);
            SourceExpression.Validate(bodyrecurringInvoiceId, nameof(bodyrecurringInvoiceId), required: false);
            SourceExpression.Validate(bodyinvoicedEstimateId, nameof(bodyinvoicedEstimateId), required: false);
            SourceExpression.Validate(bodysalespersonName, nameof(bodysalespersonName), required: false);
            SourceExpression.Validate(bodycustomFields, nameof(bodycustomFields), required: false);
            SourceExpression.Validate(bodyprojectId, nameof(bodyprojectId), required: false);
            SourceExpression.Validate(bodylineItems, nameof(bodylineItems), required: false);
            SourceExpression.Validate(bodypaymentOptionspaymentGateways, nameof(bodypaymentOptionspaymentGateways), required: false);
            SourceExpression.Validate(bodyallowPartialPayments, nameof(bodyallowPartialPayments), required: false);
            SourceExpression.Validate(bodycustomBody, nameof(bodycustomBody), required: false);
            SourceExpression.Validate(bodycustomSubject, nameof(bodycustomSubject), required: false);
            SourceExpression.Validate(bodynotes, nameof(bodynotes), required: false);
            SourceExpression.Validate(bodyterms, nameof(bodyterms), required: false);
            SourceExpression.Validate(bodyshippingCharge, nameof(bodyshippingCharge), required: false);
            SourceExpression.Validate(bodyadjustment, nameof(bodyadjustment), required: false);
            SourceExpression.Validate(bodyadjustmentDescription, nameof(bodyadjustmentDescription), required: false);
            SourceExpression.Validate(bodyreason, nameof(bodyreason), required: false);
            SourceExpression.Validate(bodytaxAuthorityId, nameof(bodytaxAuthorityId), required: false);
            SourceExpression.Validate(bodytaxExemptionId, nameof(bodytaxExemptionId), required: false);
            SourceExpression.Validate(bodyavataxUseCode, nameof(bodyavataxUseCode), required: false);
            SourceExpression.Validate(bodyavataxTaxCode, nameof(bodyavataxTaxCode), required: false);
            SourceExpression.Validate(bodyavataxExemptNo, nameof(bodyavataxExemptNo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoice/v3/invoices/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(invoiceId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycustomerId != null)
                {
                    body["customer_id"] = SourceExpressionConverter.ConvertToken(bodycustomerId);
                    bodypropCount++;
                }

                if (bodycontactPersons != null)
                {
                    body["contact_persons"] = SourceExpressionConverter.ConvertToken(bodycontactPersons);
                    bodypropCount++;
                }

                if (bodyinvoiceNumber != null)
                {
                    body["invoice_number"] = SourceExpressionConverter.ConvertToken(bodyinvoiceNumber);
                    bodypropCount++;
                }

                if (bodyreferenceNumber != null)
                {
                    body["reference_number"] = SourceExpressionConverter.ConvertToken(bodyreferenceNumber);
                    bodypropCount++;
                }

                if (bodyplaceOfSupply != null)
                {
                    body["place_of_supply"] = SourceExpressionConverter.ConvertToken(bodyplaceOfSupply);
                    bodypropCount++;
                }

                if (bodyvatTreatment != null)
                {
                    body["vat_treatment"] = SourceExpressionConverter.ConvertToken(bodyvatTreatment);
                    bodypropCount++;
                }

                if (bodygstTreatment != null)
                {
                    body["gst_treatment"] = SourceExpressionConverter.ConvertToken(bodygstTreatment);
                    bodypropCount++;
                }

                if (bodytaxTreatment != null)
                {
                    body["tax_treatment"] = SourceExpressionConverter.ConvertToken(bodytaxTreatment);
                    bodypropCount++;
                }

                if (bodycfdiUsage != null)
                {
                    body["cfdi_usage"] = SourceExpressionConverter.ConvertToken(bodycfdiUsage);
                    bodypropCount++;
                }

                if (bodygstNo != null)
                {
                    body["gst_no"] = SourceExpressionConverter.ConvertToken(bodygstNo);
                    bodypropCount++;
                }

                if (bodytemplateId != null)
                {
                    body["template_id"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodypaymentTerms != null)
                {
                    body["payment_terms"] = SourceExpressionConverter.ConvertToken(bodypaymentTerms);
                    bodypropCount++;
                }

                if (bodypaymentTermsLabel != null)
                {
                    body["payment_terms_label"] = SourceExpressionConverter.ConvertToken(bodypaymentTermsLabel);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["due_date"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodydiscount != null)
                {
                    body["discount"] = SourceExpressionConverter.ConvertToken(bodydiscount);
                    bodypropCount++;
                }

                if (bodyisDiscountBeforeTax != null)
                {
                    body["is_discount_before_tax"] = SourceExpressionConverter.ConvertToken(bodyisDiscountBeforeTax);
                    bodypropCount++;
                }

                if (bodydiscountType != null)
                {
                    body["discount_type"] = SourceExpressionConverter.ConvertToken(bodydiscountType);
                    bodypropCount++;
                }

                if (bodyisInclusiveTax != null)
                {
                    body["is_inclusive_tax"] = SourceExpressionConverter.ConvertToken(bodyisInclusiveTax);
                    bodypropCount++;
                }

                if (bodyexchangeRate != null)
                {
                    body["exchange_rate"] = SourceExpressionConverter.ConvertToken(bodyexchangeRate);
                    bodypropCount++;
                }

                if (bodyrecurringInvoiceId != null)
                {
                    body["recurring_invoice_id"] = SourceExpressionConverter.ConvertToken(bodyrecurringInvoiceId);
                    bodypropCount++;
                }

                if (bodyinvoicedEstimateId != null)
                {
                    body["invoiced_estimate_id"] = SourceExpressionConverter.ConvertToken(bodyinvoicedEstimateId);
                    bodypropCount++;
                }

                if (bodysalespersonName != null)
                {
                    body["salesperson_name"] = SourceExpressionConverter.ConvertToken(bodysalespersonName);
                    bodypropCount++;
                }

                if (bodycustomFields != null)
                {
                    body["custom_fields"] = SourceExpressionConverter.ConvertToken(bodycustomFields);
                    bodypropCount++;
                }

                if (bodyprojectId != null)
                {
                    body["project_id"] = SourceExpressionConverter.ConvertToken(bodyprojectId);
                    bodypropCount++;
                }

                if (bodylineItems != null)
                {
                    body["line_items"] = SourceExpressionConverter.ConvertToken(bodylineItems);
                    bodypropCount++;
                }

                var paymentOptionsObject = new JObject();
                var paymentOptionsObjectpropCount = 0;
                if (bodypaymentOptionspaymentGateways != null)
                {
                    paymentOptionsObject["payment_gateways"] = SourceExpressionConverter.ConvertToken(bodypaymentOptionspaymentGateways);
                    paymentOptionsObjectpropCount++;
                }

                if (paymentOptionsObjectpropCount > 0)
                {
                    body["payment_options"] = paymentOptionsObject;
                    bodypropCount++;
                }

                if (bodyallowPartialPayments != null)
                {
                    body["allow_partial_payments"] = SourceExpressionConverter.ConvertToken(bodyallowPartialPayments);
                    bodypropCount++;
                }

                if (bodycustomBody != null)
                {
                    body["custom_body"] = SourceExpressionConverter.ConvertToken(bodycustomBody);
                    bodypropCount++;
                }

                if (bodycustomSubject != null)
                {
                    body["custom_subject"] = SourceExpressionConverter.ConvertToken(bodycustomSubject);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyterms != null)
                {
                    body["terms"] = SourceExpressionConverter.ConvertToken(bodyterms);
                    bodypropCount++;
                }

                if (bodyshippingCharge != null)
                {
                    body["shipping_charge"] = SourceExpressionConverter.ConvertToken(bodyshippingCharge);
                    bodypropCount++;
                }

                if (bodyadjustment != null)
                {
                    body["adjustment"] = SourceExpressionConverter.ConvertToken(bodyadjustment);
                    bodypropCount++;
                }

                if (bodyadjustmentDescription != null)
                {
                    body["adjustment_description"] = SourceExpressionConverter.ConvertToken(bodyadjustmentDescription);
                    bodypropCount++;
                }

                if (bodyreason != null)
                {
                    body["reason"] = SourceExpressionConverter.ConvertToken(bodyreason);
                    bodypropCount++;
                }

                if (bodytaxAuthorityId != null)
                {
                    body["tax_authority_id"] = SourceExpressionConverter.ConvertToken(bodytaxAuthorityId);
                    bodypropCount++;
                }

                if (bodytaxExemptionId != null)
                {
                    body["tax_exemption_id"] = SourceExpressionConverter.ConvertToken(bodytaxExemptionId);
                    bodypropCount++;
                }

                if (bodyavataxUseCode != null)
                {
                    body["avatax_use_code"] = SourceExpressionConverter.ConvertToken(bodyavataxUseCode);
                    bodypropCount++;
                }

                if (bodyavataxTaxCode != null)
                {
                    body["avatax_tax_code"] = SourceExpressionConverter.ConvertToken(bodyavataxTaxCode);
                    bodypropCount++;
                }

                if (bodyavataxExemptNo != null)
                {
                    body["avatax_exempt_no"] = SourceExpressionConverter.ConvertToken(bodyavataxExemptNo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InvoicePutResponse>(BuildSourceInput);
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