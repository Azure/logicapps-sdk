//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zohoinvoicebasic
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ZohoinvoicebasicActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactsGetResponse> ContactsGet(Expression<Func<string>> contactName = null, Expression<Func<string>> companyName = null, Expression<Func<string>> firstName = null, Expression<Func<string>> lastName = null, Expression<Func<string>> address = null, Expression<Func<string>> email = null, Expression<Func<string>> phone = null, Expression<Func<filterByInput>> filterBy = null, Expression<Func<string>> searchText = null, Expression<Func<sortColumnInput>> sortColumn = null, Expression<Func<int>> zcrmContactId = null, Expression<Func<int>> zcrmAccountId = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_contactName = contactName == null ? null : WorkflowExpression.Compile(contactName);
            WorkflowExpression.Validate(__workflow_contactName, nameof(contactName), required: false);
            var __workflow_companyName = companyName == null ? null : WorkflowExpression.Compile(companyName);
            WorkflowExpression.Validate(__workflow_companyName, nameof(companyName), required: false);
            var __workflow_firstName = firstName == null ? null : WorkflowExpression.Compile(firstName);
            WorkflowExpression.Validate(__workflow_firstName, nameof(firstName), required: false);
            var __workflow_lastName = lastName == null ? null : WorkflowExpression.Compile(lastName);
            WorkflowExpression.Validate(__workflow_lastName, nameof(lastName), required: false);
            var __workflow_address = address == null ? null : WorkflowExpression.Compile(address);
            WorkflowExpression.Validate(__workflow_address, nameof(address), required: false);
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: false);
            var __workflow_phone = phone == null ? null : WorkflowExpression.Compile(phone);
            WorkflowExpression.Validate(__workflow_phone, nameof(phone), required: false);
            var __workflow_filterBy = filterBy == null ? null : WorkflowExpression.Compile(filterBy);
            WorkflowExpression.Validate(__workflow_filterBy, nameof(filterBy), required: false);
            var __workflow_searchText = searchText == null ? null : WorkflowExpression.Compile(searchText);
            WorkflowExpression.Validate(__workflow_searchText, nameof(searchText), required: false);
            var __workflow_sortColumn = sortColumn == null ? null : WorkflowExpression.Compile(sortColumn);
            WorkflowExpression.Validate(__workflow_sortColumn, nameof(sortColumn), required: false);
            var __workflow_zcrmContactId = zcrmContactId == null ? null : WorkflowExpression.Compile(zcrmContactId);
            WorkflowExpression.Validate(__workflow_zcrmContactId, nameof(zcrmContactId), required: false);
            var __workflow_zcrmAccountId = zcrmAccountId == null ? null : WorkflowExpression.Compile(zcrmAccountId);
            WorkflowExpression.Validate(__workflow_zcrmAccountId, nameof(zcrmAccountId), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_perPage = perPage == null ? null : WorkflowExpression.Compile(perPage);
            WorkflowExpression.Validate(__workflow_perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<ContactsGetResponse>(() =>
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
        public IBodyWorkflowAction<ContactPostResponse> Contact(Expression<Func<string>> bodycontactName, Expression<Func<string>> bodycompanyName = null, Expression<Func<int>> bodypaymentTerms = null, Expression<Func<string>> bodycurrencyId = null, Expression<Func<string>> bodywebsite = null, Expression<Func<bodycustomFieldsInputItem[]>> bodycustomFields = null, Expression<Func<string>> bodybillingAddressattention = null, Expression<Func<string>> bodybillingAddressaddress = null, Expression<Func<string>> bodybillingAddressstreet2 = null, Expression<Func<string>> bodybillingAddressstateCode = null, Expression<Func<string>> bodybillingAddresscity = null, Expression<Func<string>> bodybillingAddressstate = null, Expression<Func<string>> bodybillingAddresszip = null, Expression<Func<string>> bodybillingAddresscountry = null, Expression<Func<string>> bodybillingAddressfax = null, Expression<Func<string>> bodybillingAddressphone = null, Expression<Func<string>> bodyshippingAddressattention = null, Expression<Func<string>> bodyshippingAddressaddress = null, Expression<Func<string>> bodyshippingAddressstreet2 = null, Expression<Func<string>> bodyshippingAddressstateCode = null, Expression<Func<string>> bodyshippingAddresscity = null, Expression<Func<string>> bodyshippingAddressstate = null, Expression<Func<string>> bodyshippingAddresszip = null, Expression<Func<string>> bodyshippingAddresscountry = null, Expression<Func<string>> bodyshippingAddressfax = null, Expression<Func<string>> bodyshippingAddressphone = null, Expression<Func<bodycontactPersonsInputItem[]>> bodycontactPersons = null, Expression<Func<string>> bodydefaultTemplatesinvoiceTemplateId = null, Expression<Func<string>> bodydefaultTemplatesinvoiceTemplateName = null, Expression<Func<string>> bodydefaultTemplatesestimateTemplateId = null, Expression<Func<string>> bodydefaultTemplatesestimateTemplateName = null, Expression<Func<string>> bodydefaultTemplatescreditnoteTemplateId = null, Expression<Func<string>> bodydefaultTemplatescreditnoteTemplateName = null, Expression<Func<string>> bodydefaultTemplatesinvoiceEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatesinvoiceEmailTemplateName = null, Expression<Func<string>> bodydefaultTemplatesestimateEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatesestimateEmailTemplateName = null, Expression<Func<string>> bodydefaultTemplatescreditnoteEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatescreditnoteEmailTemplateName = null, Expression<Func<bodylanguageCodeInput>> bodylanguageCode = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyvatRegNo = null, Expression<Func<string>> bodytaxRegNo = null, Expression<Func<string>> bodycountryCode = null, Expression<Func<string>> bodyvatTreatment = null, Expression<Func<string>> bodytaxTreatment = null, Expression<Func<bodytaxRegimeInput>> bodytaxRegime = null, Expression<Func<string>> bodylegalName = null, Expression<Func<bool>> bodyisTdsRegistered = null, Expression<Func<string>> bodyplaceOfContact = null, Expression<Func<string>> bodygstNo = null, Expression<Func<bodygstTreatmentInput>> bodygstTreatment = null, Expression<Func<string>> bodytaxAuthorityName = null, Expression<Func<string>> bodytaxExemptionCode = null, Expression<Func<string>> bodyavataxExemptNo = null, Expression<Func<string>> bodyavataxUseCode = null, Expression<Func<string>> bodytaxExemptionId = null, Expression<Func<string>> bodytaxAuthorityId = null, Expression<Func<string>> bodytaxId = null, Expression<Func<string>> bodytdsTaxId = null, Expression<Func<bool>> bodyisTaxable = null, Expression<Func<string>> bodyfacebook = null, Expression<Func<string>> bodytwitter = null)
        {
            var __workflow_bodycontactName = bodycontactName == null ? null : WorkflowExpression.Compile(bodycontactName);
            WorkflowExpression.Validate(__workflow_bodycontactName, nameof(bodycontactName), required: true);
            var __workflow_bodycompanyName = bodycompanyName == null ? null : WorkflowExpression.Compile(bodycompanyName);
            WorkflowExpression.Validate(__workflow_bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodypaymentTerms = bodypaymentTerms == null ? null : WorkflowExpression.Compile(bodypaymentTerms);
            WorkflowExpression.Validate(__workflow_bodypaymentTerms, nameof(bodypaymentTerms), required: false);
            var __workflow_bodycurrencyId = bodycurrencyId == null ? null : WorkflowExpression.Compile(bodycurrencyId);
            WorkflowExpression.Validate(__workflow_bodycurrencyId, nameof(bodycurrencyId), required: false);
            var __workflow_bodywebsite = bodywebsite == null ? null : WorkflowExpression.Compile(bodywebsite);
            WorkflowExpression.Validate(__workflow_bodywebsite, nameof(bodywebsite), required: false);
            var __workflow_bodycustomFields = bodycustomFields == null ? null : WorkflowExpression.Compile(bodycustomFields);
            WorkflowExpression.Validate(__workflow_bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodybillingAddressattention = bodybillingAddressattention == null ? null : WorkflowExpression.Compile(bodybillingAddressattention);
            WorkflowExpression.Validate(__workflow_bodybillingAddressattention, nameof(bodybillingAddressattention), required: false);
            var __workflow_bodybillingAddressaddress = bodybillingAddressaddress == null ? null : WorkflowExpression.Compile(bodybillingAddressaddress);
            WorkflowExpression.Validate(__workflow_bodybillingAddressaddress, nameof(bodybillingAddressaddress), required: false);
            var __workflow_bodybillingAddressstreet2 = bodybillingAddressstreet2 == null ? null : WorkflowExpression.Compile(bodybillingAddressstreet2);
            WorkflowExpression.Validate(__workflow_bodybillingAddressstreet2, nameof(bodybillingAddressstreet2), required: false);
            var __workflow_bodybillingAddressstateCode = bodybillingAddressstateCode == null ? null : WorkflowExpression.Compile(bodybillingAddressstateCode);
            WorkflowExpression.Validate(__workflow_bodybillingAddressstateCode, nameof(bodybillingAddressstateCode), required: false);
            var __workflow_bodybillingAddresscity = bodybillingAddresscity == null ? null : WorkflowExpression.Compile(bodybillingAddresscity);
            WorkflowExpression.Validate(__workflow_bodybillingAddresscity, nameof(bodybillingAddresscity), required: false);
            var __workflow_bodybillingAddressstate = bodybillingAddressstate == null ? null : WorkflowExpression.Compile(bodybillingAddressstate);
            WorkflowExpression.Validate(__workflow_bodybillingAddressstate, nameof(bodybillingAddressstate), required: false);
            var __workflow_bodybillingAddresszip = bodybillingAddresszip == null ? null : WorkflowExpression.Compile(bodybillingAddresszip);
            WorkflowExpression.Validate(__workflow_bodybillingAddresszip, nameof(bodybillingAddresszip), required: false);
            var __workflow_bodybillingAddresscountry = bodybillingAddresscountry == null ? null : WorkflowExpression.Compile(bodybillingAddresscountry);
            WorkflowExpression.Validate(__workflow_bodybillingAddresscountry, nameof(bodybillingAddresscountry), required: false);
            var __workflow_bodybillingAddressfax = bodybillingAddressfax == null ? null : WorkflowExpression.Compile(bodybillingAddressfax);
            WorkflowExpression.Validate(__workflow_bodybillingAddressfax, nameof(bodybillingAddressfax), required: false);
            var __workflow_bodybillingAddressphone = bodybillingAddressphone == null ? null : WorkflowExpression.Compile(bodybillingAddressphone);
            WorkflowExpression.Validate(__workflow_bodybillingAddressphone, nameof(bodybillingAddressphone), required: false);
            var __workflow_bodyshippingAddressattention = bodyshippingAddressattention == null ? null : WorkflowExpression.Compile(bodyshippingAddressattention);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressattention, nameof(bodyshippingAddressattention), required: false);
            var __workflow_bodyshippingAddressaddress = bodyshippingAddressaddress == null ? null : WorkflowExpression.Compile(bodyshippingAddressaddress);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressaddress, nameof(bodyshippingAddressaddress), required: false);
            var __workflow_bodyshippingAddressstreet2 = bodyshippingAddressstreet2 == null ? null : WorkflowExpression.Compile(bodyshippingAddressstreet2);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressstreet2, nameof(bodyshippingAddressstreet2), required: false);
            var __workflow_bodyshippingAddressstateCode = bodyshippingAddressstateCode == null ? null : WorkflowExpression.Compile(bodyshippingAddressstateCode);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressstateCode, nameof(bodyshippingAddressstateCode), required: false);
            var __workflow_bodyshippingAddresscity = bodyshippingAddresscity == null ? null : WorkflowExpression.Compile(bodyshippingAddresscity);
            WorkflowExpression.Validate(__workflow_bodyshippingAddresscity, nameof(bodyshippingAddresscity), required: false);
            var __workflow_bodyshippingAddressstate = bodyshippingAddressstate == null ? null : WorkflowExpression.Compile(bodyshippingAddressstate);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressstate, nameof(bodyshippingAddressstate), required: false);
            var __workflow_bodyshippingAddresszip = bodyshippingAddresszip == null ? null : WorkflowExpression.Compile(bodyshippingAddresszip);
            WorkflowExpression.Validate(__workflow_bodyshippingAddresszip, nameof(bodyshippingAddresszip), required: false);
            var __workflow_bodyshippingAddresscountry = bodyshippingAddresscountry == null ? null : WorkflowExpression.Compile(bodyshippingAddresscountry);
            WorkflowExpression.Validate(__workflow_bodyshippingAddresscountry, nameof(bodyshippingAddresscountry), required: false);
            var __workflow_bodyshippingAddressfax = bodyshippingAddressfax == null ? null : WorkflowExpression.Compile(bodyshippingAddressfax);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressfax, nameof(bodyshippingAddressfax), required: false);
            var __workflow_bodyshippingAddressphone = bodyshippingAddressphone == null ? null : WorkflowExpression.Compile(bodyshippingAddressphone);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressphone, nameof(bodyshippingAddressphone), required: false);
            var __workflow_bodycontactPersons = bodycontactPersons == null ? null : WorkflowExpression.Compile(bodycontactPersons);
            WorkflowExpression.Validate(__workflow_bodycontactPersons, nameof(bodycontactPersons), required: false);
            var __workflow_bodydefaultTemplatesinvoiceTemplateId = bodydefaultTemplatesinvoiceTemplateId == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesinvoiceTemplateId);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesinvoiceTemplateId, nameof(bodydefaultTemplatesinvoiceTemplateId), required: false);
            var __workflow_bodydefaultTemplatesinvoiceTemplateName = bodydefaultTemplatesinvoiceTemplateName == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesinvoiceTemplateName);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesinvoiceTemplateName, nameof(bodydefaultTemplatesinvoiceTemplateName), required: false);
            var __workflow_bodydefaultTemplatesestimateTemplateId = bodydefaultTemplatesestimateTemplateId == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesestimateTemplateId);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesestimateTemplateId, nameof(bodydefaultTemplatesestimateTemplateId), required: false);
            var __workflow_bodydefaultTemplatesestimateTemplateName = bodydefaultTemplatesestimateTemplateName == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesestimateTemplateName);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesestimateTemplateName, nameof(bodydefaultTemplatesestimateTemplateName), required: false);
            var __workflow_bodydefaultTemplatescreditnoteTemplateId = bodydefaultTemplatescreditnoteTemplateId == null ? null : WorkflowExpression.Compile(bodydefaultTemplatescreditnoteTemplateId);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatescreditnoteTemplateId, nameof(bodydefaultTemplatescreditnoteTemplateId), required: false);
            var __workflow_bodydefaultTemplatescreditnoteTemplateName = bodydefaultTemplatescreditnoteTemplateName == null ? null : WorkflowExpression.Compile(bodydefaultTemplatescreditnoteTemplateName);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatescreditnoteTemplateName, nameof(bodydefaultTemplatescreditnoteTemplateName), required: false);
            var __workflow_bodydefaultTemplatesinvoiceEmailTemplateId = bodydefaultTemplatesinvoiceEmailTemplateId == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesinvoiceEmailTemplateId);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesinvoiceEmailTemplateId, nameof(bodydefaultTemplatesinvoiceEmailTemplateId), required: false);
            var __workflow_bodydefaultTemplatesinvoiceEmailTemplateName = bodydefaultTemplatesinvoiceEmailTemplateName == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesinvoiceEmailTemplateName);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesinvoiceEmailTemplateName, nameof(bodydefaultTemplatesinvoiceEmailTemplateName), required: false);
            var __workflow_bodydefaultTemplatesestimateEmailTemplateId = bodydefaultTemplatesestimateEmailTemplateId == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesestimateEmailTemplateId);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesestimateEmailTemplateId, nameof(bodydefaultTemplatesestimateEmailTemplateId), required: false);
            var __workflow_bodydefaultTemplatesestimateEmailTemplateName = bodydefaultTemplatesestimateEmailTemplateName == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesestimateEmailTemplateName);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesestimateEmailTemplateName, nameof(bodydefaultTemplatesestimateEmailTemplateName), required: false);
            var __workflow_bodydefaultTemplatescreditnoteEmailTemplateId = bodydefaultTemplatescreditnoteEmailTemplateId == null ? null : WorkflowExpression.Compile(bodydefaultTemplatescreditnoteEmailTemplateId);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatescreditnoteEmailTemplateId, nameof(bodydefaultTemplatescreditnoteEmailTemplateId), required: false);
            var __workflow_bodydefaultTemplatescreditnoteEmailTemplateName = bodydefaultTemplatescreditnoteEmailTemplateName == null ? null : WorkflowExpression.Compile(bodydefaultTemplatescreditnoteEmailTemplateName);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatescreditnoteEmailTemplateName, nameof(bodydefaultTemplatescreditnoteEmailTemplateName), required: false);
            var __workflow_bodylanguageCode = bodylanguageCode == null ? null : WorkflowExpression.Compile(bodylanguageCode);
            WorkflowExpression.Validate(__workflow_bodylanguageCode, nameof(bodylanguageCode), required: false);
            var __workflow_bodynotes = bodynotes == null ? null : WorkflowExpression.Compile(bodynotes);
            WorkflowExpression.Validate(__workflow_bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyvatRegNo = bodyvatRegNo == null ? null : WorkflowExpression.Compile(bodyvatRegNo);
            WorkflowExpression.Validate(__workflow_bodyvatRegNo, nameof(bodyvatRegNo), required: false);
            var __workflow_bodytaxRegNo = bodytaxRegNo == null ? null : WorkflowExpression.Compile(bodytaxRegNo);
            WorkflowExpression.Validate(__workflow_bodytaxRegNo, nameof(bodytaxRegNo), required: false);
            var __workflow_bodycountryCode = bodycountryCode == null ? null : WorkflowExpression.Compile(bodycountryCode);
            WorkflowExpression.Validate(__workflow_bodycountryCode, nameof(bodycountryCode), required: false);
            var __workflow_bodyvatTreatment = bodyvatTreatment == null ? null : WorkflowExpression.Compile(bodyvatTreatment);
            WorkflowExpression.Validate(__workflow_bodyvatTreatment, nameof(bodyvatTreatment), required: false);
            var __workflow_bodytaxTreatment = bodytaxTreatment == null ? null : WorkflowExpression.Compile(bodytaxTreatment);
            WorkflowExpression.Validate(__workflow_bodytaxTreatment, nameof(bodytaxTreatment), required: false);
            var __workflow_bodytaxRegime = bodytaxRegime == null ? null : WorkflowExpression.Compile(bodytaxRegime);
            WorkflowExpression.Validate(__workflow_bodytaxRegime, nameof(bodytaxRegime), required: false);
            var __workflow_bodylegalName = bodylegalName == null ? null : WorkflowExpression.Compile(bodylegalName);
            WorkflowExpression.Validate(__workflow_bodylegalName, nameof(bodylegalName), required: false);
            var __workflow_bodyisTdsRegistered = bodyisTdsRegistered == null ? null : WorkflowExpression.Compile(bodyisTdsRegistered);
            WorkflowExpression.Validate(__workflow_bodyisTdsRegistered, nameof(bodyisTdsRegistered), required: false);
            var __workflow_bodyplaceOfContact = bodyplaceOfContact == null ? null : WorkflowExpression.Compile(bodyplaceOfContact);
            WorkflowExpression.Validate(__workflow_bodyplaceOfContact, nameof(bodyplaceOfContact), required: false);
            var __workflow_bodygstNo = bodygstNo == null ? null : WorkflowExpression.Compile(bodygstNo);
            WorkflowExpression.Validate(__workflow_bodygstNo, nameof(bodygstNo), required: false);
            var __workflow_bodygstTreatment = bodygstTreatment == null ? null : WorkflowExpression.Compile(bodygstTreatment);
            WorkflowExpression.Validate(__workflow_bodygstTreatment, nameof(bodygstTreatment), required: false);
            var __workflow_bodytaxAuthorityName = bodytaxAuthorityName == null ? null : WorkflowExpression.Compile(bodytaxAuthorityName);
            WorkflowExpression.Validate(__workflow_bodytaxAuthorityName, nameof(bodytaxAuthorityName), required: false);
            var __workflow_bodytaxExemptionCode = bodytaxExemptionCode == null ? null : WorkflowExpression.Compile(bodytaxExemptionCode);
            WorkflowExpression.Validate(__workflow_bodytaxExemptionCode, nameof(bodytaxExemptionCode), required: false);
            var __workflow_bodyavataxExemptNo = bodyavataxExemptNo == null ? null : WorkflowExpression.Compile(bodyavataxExemptNo);
            WorkflowExpression.Validate(__workflow_bodyavataxExemptNo, nameof(bodyavataxExemptNo), required: false);
            var __workflow_bodyavataxUseCode = bodyavataxUseCode == null ? null : WorkflowExpression.Compile(bodyavataxUseCode);
            WorkflowExpression.Validate(__workflow_bodyavataxUseCode, nameof(bodyavataxUseCode), required: false);
            var __workflow_bodytaxExemptionId = bodytaxExemptionId == null ? null : WorkflowExpression.Compile(bodytaxExemptionId);
            WorkflowExpression.Validate(__workflow_bodytaxExemptionId, nameof(bodytaxExemptionId), required: false);
            var __workflow_bodytaxAuthorityId = bodytaxAuthorityId == null ? null : WorkflowExpression.Compile(bodytaxAuthorityId);
            WorkflowExpression.Validate(__workflow_bodytaxAuthorityId, nameof(bodytaxAuthorityId), required: false);
            var __workflow_bodytaxId = bodytaxId == null ? null : WorkflowExpression.Compile(bodytaxId);
            WorkflowExpression.Validate(__workflow_bodytaxId, nameof(bodytaxId), required: false);
            var __workflow_bodytdsTaxId = bodytdsTaxId == null ? null : WorkflowExpression.Compile(bodytdsTaxId);
            WorkflowExpression.Validate(__workflow_bodytdsTaxId, nameof(bodytdsTaxId), required: false);
            var __workflow_bodyisTaxable = bodyisTaxable == null ? null : WorkflowExpression.Compile(bodyisTaxable);
            WorkflowExpression.Validate(__workflow_bodyisTaxable, nameof(bodyisTaxable), required: false);
            var __workflow_bodyfacebook = bodyfacebook == null ? null : WorkflowExpression.Compile(bodyfacebook);
            WorkflowExpression.Validate(__workflow_bodyfacebook, nameof(bodyfacebook), required: false);
            var __workflow_bodytwitter = bodytwitter == null ? null : WorkflowExpression.Compile(bodytwitter);
            WorkflowExpression.Validate(__workflow_bodytwitter, nameof(bodytwitter), required: false);
            return new DeferredBodyAction<ContactPostResponse>(() =>
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
        public IBodyWorkflowAction<ContactGetResponse> ContactGet(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = contactId == null ? null : WorkflowExpression.Compile(contactId);
            WorkflowExpression.Validate(__workflow_contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<ContactGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoice/v3/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactDeleteResponse> ContactDelete(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = contactId == null ? null : WorkflowExpression.Compile(contactId);
            WorkflowExpression.Validate(__workflow_contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<ContactDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoice/v3/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ContactDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<ContactPutResponse> ContactPut(Expression<Func<string>> contactId, Expression<Func<string>> bodycontactName, Expression<Func<string>> bodycompanyName = null, Expression<Func<int>> bodypaymentTerms = null, Expression<Func<string>> bodycurrencyId = null, Expression<Func<string>> bodywebsite = null, Expression<Func<bodycustomFieldsInputItem2[]>> bodycustomFields = null, Expression<Func<string>> bodybillingAddressattention = null, Expression<Func<string>> bodybillingAddressaddress = null, Expression<Func<string>> bodybillingAddressstreet2 = null, Expression<Func<string>> bodybillingAddressstateCode = null, Expression<Func<string>> bodybillingAddresscity = null, Expression<Func<string>> bodybillingAddressstate = null, Expression<Func<string>> bodybillingAddresszip = null, Expression<Func<string>> bodybillingAddresscountry = null, Expression<Func<string>> bodybillingAddressfax = null, Expression<Func<string>> bodybillingAddressphone = null, Expression<Func<string>> bodyshippingAddressattention = null, Expression<Func<string>> bodyshippingAddressaddress = null, Expression<Func<string>> bodyshippingAddressstreet2 = null, Expression<Func<string>> bodyshippingAddressstateCode = null, Expression<Func<string>> bodyshippingAddresscity = null, Expression<Func<string>> bodyshippingAddressstate = null, Expression<Func<string>> bodyshippingAddresszip = null, Expression<Func<string>> bodyshippingAddresscountry = null, Expression<Func<string>> bodyshippingAddressfax = null, Expression<Func<string>> bodyshippingAddressphone = null, Expression<Func<bodycontactPersonsInputItem[]>> bodycontactPersons = null, Expression<Func<string>> bodydefaultTemplatesinvoiceTemplateId = null, Expression<Func<string>> bodydefaultTemplatesinvoiceTemplateName = null, Expression<Func<string>> bodydefaultTemplatesestimateTemplateId = null, Expression<Func<string>> bodydefaultTemplatesestimateTemplateName = null, Expression<Func<string>> bodydefaultTemplatescreditnoteTemplateId = null, Expression<Func<string>> bodydefaultTemplatescreditnoteTemplateName = null, Expression<Func<string>> bodydefaultTemplatesinvoiceEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatesinvoiceEmailTemplateName = null, Expression<Func<string>> bodydefaultTemplatesestimateEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatesestimateEmailTemplateName = null, Expression<Func<string>> bodydefaultTemplatescreditnoteEmailTemplateId = null, Expression<Func<string>> bodydefaultTemplatescreditnoteEmailTemplateName = null, Expression<Func<bodylanguageCodeInput>> bodylanguageCode = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyvatRegNo = null, Expression<Func<string>> bodytaxRegNo = null, Expression<Func<string>> bodycountryCode = null, Expression<Func<bodyvatTreatmentInput>> bodyvatTreatment = null, Expression<Func<string>> bodytaxTreatment = null, Expression<Func<bodytaxRegimeInput>> bodytaxRegime = null, Expression<Func<string>> bodylegalName = null, Expression<Func<bool>> bodyisTdsRegistered = null, Expression<Func<string>> bodyplaceOfContact = null, Expression<Func<string>> bodygstNo = null, Expression<Func<bodygstTreatmentInput>> bodygstTreatment = null, Expression<Func<string>> bodytaxAuthorityName = null, Expression<Func<string>> bodytaxExemptionCode = null, Expression<Func<string>> bodyavataxExemptNo = null, Expression<Func<string>> bodyavataxUseCode = null, Expression<Func<string>> bodytaxExemptionId = null, Expression<Func<string>> bodytaxAuthorityId = null, Expression<Func<string>> bodytaxId = null, Expression<Func<string>> bodytdsTaxId = null, Expression<Func<bool>> bodyisTaxable = null, Expression<Func<string>> bodyfacebook = null, Expression<Func<string>> bodytwitter = null)
        {
            var __workflow_contactId = contactId == null ? null : WorkflowExpression.Compile(contactId);
            WorkflowExpression.Validate(__workflow_contactId, nameof(contactId), required: true);
            var __workflow_bodycontactName = bodycontactName == null ? null : WorkflowExpression.Compile(bodycontactName);
            WorkflowExpression.Validate(__workflow_bodycontactName, nameof(bodycontactName), required: true);
            var __workflow_bodycompanyName = bodycompanyName == null ? null : WorkflowExpression.Compile(bodycompanyName);
            WorkflowExpression.Validate(__workflow_bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodypaymentTerms = bodypaymentTerms == null ? null : WorkflowExpression.Compile(bodypaymentTerms);
            WorkflowExpression.Validate(__workflow_bodypaymentTerms, nameof(bodypaymentTerms), required: false);
            var __workflow_bodycurrencyId = bodycurrencyId == null ? null : WorkflowExpression.Compile(bodycurrencyId);
            WorkflowExpression.Validate(__workflow_bodycurrencyId, nameof(bodycurrencyId), required: false);
            var __workflow_bodywebsite = bodywebsite == null ? null : WorkflowExpression.Compile(bodywebsite);
            WorkflowExpression.Validate(__workflow_bodywebsite, nameof(bodywebsite), required: false);
            var __workflow_bodycustomFields = bodycustomFields == null ? null : WorkflowExpression.Compile(bodycustomFields);
            WorkflowExpression.Validate(__workflow_bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodybillingAddressattention = bodybillingAddressattention == null ? null : WorkflowExpression.Compile(bodybillingAddressattention);
            WorkflowExpression.Validate(__workflow_bodybillingAddressattention, nameof(bodybillingAddressattention), required: false);
            var __workflow_bodybillingAddressaddress = bodybillingAddressaddress == null ? null : WorkflowExpression.Compile(bodybillingAddressaddress);
            WorkflowExpression.Validate(__workflow_bodybillingAddressaddress, nameof(bodybillingAddressaddress), required: false);
            var __workflow_bodybillingAddressstreet2 = bodybillingAddressstreet2 == null ? null : WorkflowExpression.Compile(bodybillingAddressstreet2);
            WorkflowExpression.Validate(__workflow_bodybillingAddressstreet2, nameof(bodybillingAddressstreet2), required: false);
            var __workflow_bodybillingAddressstateCode = bodybillingAddressstateCode == null ? null : WorkflowExpression.Compile(bodybillingAddressstateCode);
            WorkflowExpression.Validate(__workflow_bodybillingAddressstateCode, nameof(bodybillingAddressstateCode), required: false);
            var __workflow_bodybillingAddresscity = bodybillingAddresscity == null ? null : WorkflowExpression.Compile(bodybillingAddresscity);
            WorkflowExpression.Validate(__workflow_bodybillingAddresscity, nameof(bodybillingAddresscity), required: false);
            var __workflow_bodybillingAddressstate = bodybillingAddressstate == null ? null : WorkflowExpression.Compile(bodybillingAddressstate);
            WorkflowExpression.Validate(__workflow_bodybillingAddressstate, nameof(bodybillingAddressstate), required: false);
            var __workflow_bodybillingAddresszip = bodybillingAddresszip == null ? null : WorkflowExpression.Compile(bodybillingAddresszip);
            WorkflowExpression.Validate(__workflow_bodybillingAddresszip, nameof(bodybillingAddresszip), required: false);
            var __workflow_bodybillingAddresscountry = bodybillingAddresscountry == null ? null : WorkflowExpression.Compile(bodybillingAddresscountry);
            WorkflowExpression.Validate(__workflow_bodybillingAddresscountry, nameof(bodybillingAddresscountry), required: false);
            var __workflow_bodybillingAddressfax = bodybillingAddressfax == null ? null : WorkflowExpression.Compile(bodybillingAddressfax);
            WorkflowExpression.Validate(__workflow_bodybillingAddressfax, nameof(bodybillingAddressfax), required: false);
            var __workflow_bodybillingAddressphone = bodybillingAddressphone == null ? null : WorkflowExpression.Compile(bodybillingAddressphone);
            WorkflowExpression.Validate(__workflow_bodybillingAddressphone, nameof(bodybillingAddressphone), required: false);
            var __workflow_bodyshippingAddressattention = bodyshippingAddressattention == null ? null : WorkflowExpression.Compile(bodyshippingAddressattention);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressattention, nameof(bodyshippingAddressattention), required: false);
            var __workflow_bodyshippingAddressaddress = bodyshippingAddressaddress == null ? null : WorkflowExpression.Compile(bodyshippingAddressaddress);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressaddress, nameof(bodyshippingAddressaddress), required: false);
            var __workflow_bodyshippingAddressstreet2 = bodyshippingAddressstreet2 == null ? null : WorkflowExpression.Compile(bodyshippingAddressstreet2);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressstreet2, nameof(bodyshippingAddressstreet2), required: false);
            var __workflow_bodyshippingAddressstateCode = bodyshippingAddressstateCode == null ? null : WorkflowExpression.Compile(bodyshippingAddressstateCode);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressstateCode, nameof(bodyshippingAddressstateCode), required: false);
            var __workflow_bodyshippingAddresscity = bodyshippingAddresscity == null ? null : WorkflowExpression.Compile(bodyshippingAddresscity);
            WorkflowExpression.Validate(__workflow_bodyshippingAddresscity, nameof(bodyshippingAddresscity), required: false);
            var __workflow_bodyshippingAddressstate = bodyshippingAddressstate == null ? null : WorkflowExpression.Compile(bodyshippingAddressstate);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressstate, nameof(bodyshippingAddressstate), required: false);
            var __workflow_bodyshippingAddresszip = bodyshippingAddresszip == null ? null : WorkflowExpression.Compile(bodyshippingAddresszip);
            WorkflowExpression.Validate(__workflow_bodyshippingAddresszip, nameof(bodyshippingAddresszip), required: false);
            var __workflow_bodyshippingAddresscountry = bodyshippingAddresscountry == null ? null : WorkflowExpression.Compile(bodyshippingAddresscountry);
            WorkflowExpression.Validate(__workflow_bodyshippingAddresscountry, nameof(bodyshippingAddresscountry), required: false);
            var __workflow_bodyshippingAddressfax = bodyshippingAddressfax == null ? null : WorkflowExpression.Compile(bodyshippingAddressfax);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressfax, nameof(bodyshippingAddressfax), required: false);
            var __workflow_bodyshippingAddressphone = bodyshippingAddressphone == null ? null : WorkflowExpression.Compile(bodyshippingAddressphone);
            WorkflowExpression.Validate(__workflow_bodyshippingAddressphone, nameof(bodyshippingAddressphone), required: false);
            var __workflow_bodycontactPersons = bodycontactPersons == null ? null : WorkflowExpression.Compile(bodycontactPersons);
            WorkflowExpression.Validate(__workflow_bodycontactPersons, nameof(bodycontactPersons), required: false);
            var __workflow_bodydefaultTemplatesinvoiceTemplateId = bodydefaultTemplatesinvoiceTemplateId == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesinvoiceTemplateId);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesinvoiceTemplateId, nameof(bodydefaultTemplatesinvoiceTemplateId), required: false);
            var __workflow_bodydefaultTemplatesinvoiceTemplateName = bodydefaultTemplatesinvoiceTemplateName == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesinvoiceTemplateName);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesinvoiceTemplateName, nameof(bodydefaultTemplatesinvoiceTemplateName), required: false);
            var __workflow_bodydefaultTemplatesestimateTemplateId = bodydefaultTemplatesestimateTemplateId == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesestimateTemplateId);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesestimateTemplateId, nameof(bodydefaultTemplatesestimateTemplateId), required: false);
            var __workflow_bodydefaultTemplatesestimateTemplateName = bodydefaultTemplatesestimateTemplateName == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesestimateTemplateName);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesestimateTemplateName, nameof(bodydefaultTemplatesestimateTemplateName), required: false);
            var __workflow_bodydefaultTemplatescreditnoteTemplateId = bodydefaultTemplatescreditnoteTemplateId == null ? null : WorkflowExpression.Compile(bodydefaultTemplatescreditnoteTemplateId);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatescreditnoteTemplateId, nameof(bodydefaultTemplatescreditnoteTemplateId), required: false);
            var __workflow_bodydefaultTemplatescreditnoteTemplateName = bodydefaultTemplatescreditnoteTemplateName == null ? null : WorkflowExpression.Compile(bodydefaultTemplatescreditnoteTemplateName);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatescreditnoteTemplateName, nameof(bodydefaultTemplatescreditnoteTemplateName), required: false);
            var __workflow_bodydefaultTemplatesinvoiceEmailTemplateId = bodydefaultTemplatesinvoiceEmailTemplateId == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesinvoiceEmailTemplateId);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesinvoiceEmailTemplateId, nameof(bodydefaultTemplatesinvoiceEmailTemplateId), required: false);
            var __workflow_bodydefaultTemplatesinvoiceEmailTemplateName = bodydefaultTemplatesinvoiceEmailTemplateName == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesinvoiceEmailTemplateName);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesinvoiceEmailTemplateName, nameof(bodydefaultTemplatesinvoiceEmailTemplateName), required: false);
            var __workflow_bodydefaultTemplatesestimateEmailTemplateId = bodydefaultTemplatesestimateEmailTemplateId == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesestimateEmailTemplateId);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesestimateEmailTemplateId, nameof(bodydefaultTemplatesestimateEmailTemplateId), required: false);
            var __workflow_bodydefaultTemplatesestimateEmailTemplateName = bodydefaultTemplatesestimateEmailTemplateName == null ? null : WorkflowExpression.Compile(bodydefaultTemplatesestimateEmailTemplateName);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatesestimateEmailTemplateName, nameof(bodydefaultTemplatesestimateEmailTemplateName), required: false);
            var __workflow_bodydefaultTemplatescreditnoteEmailTemplateId = bodydefaultTemplatescreditnoteEmailTemplateId == null ? null : WorkflowExpression.Compile(bodydefaultTemplatescreditnoteEmailTemplateId);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatescreditnoteEmailTemplateId, nameof(bodydefaultTemplatescreditnoteEmailTemplateId), required: false);
            var __workflow_bodydefaultTemplatescreditnoteEmailTemplateName = bodydefaultTemplatescreditnoteEmailTemplateName == null ? null : WorkflowExpression.Compile(bodydefaultTemplatescreditnoteEmailTemplateName);
            WorkflowExpression.Validate(__workflow_bodydefaultTemplatescreditnoteEmailTemplateName, nameof(bodydefaultTemplatescreditnoteEmailTemplateName), required: false);
            var __workflow_bodylanguageCode = bodylanguageCode == null ? null : WorkflowExpression.Compile(bodylanguageCode);
            WorkflowExpression.Validate(__workflow_bodylanguageCode, nameof(bodylanguageCode), required: false);
            var __workflow_bodynotes = bodynotes == null ? null : WorkflowExpression.Compile(bodynotes);
            WorkflowExpression.Validate(__workflow_bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyvatRegNo = bodyvatRegNo == null ? null : WorkflowExpression.Compile(bodyvatRegNo);
            WorkflowExpression.Validate(__workflow_bodyvatRegNo, nameof(bodyvatRegNo), required: false);
            var __workflow_bodytaxRegNo = bodytaxRegNo == null ? null : WorkflowExpression.Compile(bodytaxRegNo);
            WorkflowExpression.Validate(__workflow_bodytaxRegNo, nameof(bodytaxRegNo), required: false);
            var __workflow_bodycountryCode = bodycountryCode == null ? null : WorkflowExpression.Compile(bodycountryCode);
            WorkflowExpression.Validate(__workflow_bodycountryCode, nameof(bodycountryCode), required: false);
            var __workflow_bodyvatTreatment = bodyvatTreatment == null ? null : WorkflowExpression.Compile(bodyvatTreatment);
            WorkflowExpression.Validate(__workflow_bodyvatTreatment, nameof(bodyvatTreatment), required: false);
            var __workflow_bodytaxTreatment = bodytaxTreatment == null ? null : WorkflowExpression.Compile(bodytaxTreatment);
            WorkflowExpression.Validate(__workflow_bodytaxTreatment, nameof(bodytaxTreatment), required: false);
            var __workflow_bodytaxRegime = bodytaxRegime == null ? null : WorkflowExpression.Compile(bodytaxRegime);
            WorkflowExpression.Validate(__workflow_bodytaxRegime, nameof(bodytaxRegime), required: false);
            var __workflow_bodylegalName = bodylegalName == null ? null : WorkflowExpression.Compile(bodylegalName);
            WorkflowExpression.Validate(__workflow_bodylegalName, nameof(bodylegalName), required: false);
            var __workflow_bodyisTdsRegistered = bodyisTdsRegistered == null ? null : WorkflowExpression.Compile(bodyisTdsRegistered);
            WorkflowExpression.Validate(__workflow_bodyisTdsRegistered, nameof(bodyisTdsRegistered), required: false);
            var __workflow_bodyplaceOfContact = bodyplaceOfContact == null ? null : WorkflowExpression.Compile(bodyplaceOfContact);
            WorkflowExpression.Validate(__workflow_bodyplaceOfContact, nameof(bodyplaceOfContact), required: false);
            var __workflow_bodygstNo = bodygstNo == null ? null : WorkflowExpression.Compile(bodygstNo);
            WorkflowExpression.Validate(__workflow_bodygstNo, nameof(bodygstNo), required: false);
            var __workflow_bodygstTreatment = bodygstTreatment == null ? null : WorkflowExpression.Compile(bodygstTreatment);
            WorkflowExpression.Validate(__workflow_bodygstTreatment, nameof(bodygstTreatment), required: false);
            var __workflow_bodytaxAuthorityName = bodytaxAuthorityName == null ? null : WorkflowExpression.Compile(bodytaxAuthorityName);
            WorkflowExpression.Validate(__workflow_bodytaxAuthorityName, nameof(bodytaxAuthorityName), required: false);
            var __workflow_bodytaxExemptionCode = bodytaxExemptionCode == null ? null : WorkflowExpression.Compile(bodytaxExemptionCode);
            WorkflowExpression.Validate(__workflow_bodytaxExemptionCode, nameof(bodytaxExemptionCode), required: false);
            var __workflow_bodyavataxExemptNo = bodyavataxExemptNo == null ? null : WorkflowExpression.Compile(bodyavataxExemptNo);
            WorkflowExpression.Validate(__workflow_bodyavataxExemptNo, nameof(bodyavataxExemptNo), required: false);
            var __workflow_bodyavataxUseCode = bodyavataxUseCode == null ? null : WorkflowExpression.Compile(bodyavataxUseCode);
            WorkflowExpression.Validate(__workflow_bodyavataxUseCode, nameof(bodyavataxUseCode), required: false);
            var __workflow_bodytaxExemptionId = bodytaxExemptionId == null ? null : WorkflowExpression.Compile(bodytaxExemptionId);
            WorkflowExpression.Validate(__workflow_bodytaxExemptionId, nameof(bodytaxExemptionId), required: false);
            var __workflow_bodytaxAuthorityId = bodytaxAuthorityId == null ? null : WorkflowExpression.Compile(bodytaxAuthorityId);
            WorkflowExpression.Validate(__workflow_bodytaxAuthorityId, nameof(bodytaxAuthorityId), required: false);
            var __workflow_bodytaxId = bodytaxId == null ? null : WorkflowExpression.Compile(bodytaxId);
            WorkflowExpression.Validate(__workflow_bodytaxId, nameof(bodytaxId), required: false);
            var __workflow_bodytdsTaxId = bodytdsTaxId == null ? null : WorkflowExpression.Compile(bodytdsTaxId);
            WorkflowExpression.Validate(__workflow_bodytdsTaxId, nameof(bodytdsTaxId), required: false);
            var __workflow_bodyisTaxable = bodyisTaxable == null ? null : WorkflowExpression.Compile(bodyisTaxable);
            WorkflowExpression.Validate(__workflow_bodyisTaxable, nameof(bodyisTaxable), required: false);
            var __workflow_bodyfacebook = bodyfacebook == null ? null : WorkflowExpression.Compile(bodyfacebook);
            WorkflowExpression.Validate(__workflow_bodyfacebook, nameof(bodyfacebook), required: false);
            var __workflow_bodytwitter = bodytwitter == null ? null : WorkflowExpression.Compile(bodytwitter);
            WorkflowExpression.Validate(__workflow_bodytwitter, nameof(bodytwitter), required: false);
            return new DeferredBodyAction<ContactPutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoice/v3/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactId, 1));
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
        public IBodyWorkflowAction<InvoicesGetResponse> InvoicesGet(Expression<Func<string>> invoiceNumber = null, Expression<Func<string>> itemName = null, Expression<Func<string>> itemId = null, Expression<Func<string>> itemDescription = null, Expression<Func<string>> referenceNumber = null, Expression<Func<string>> customerName = null, Expression<Func<string>> recurringInvoiceId = null, Expression<Func<string>> email = null, Expression<Func<string>> total = null, Expression<Func<string>> balance = null, Expression<Func<string>> customField = null, Expression<Func<string>> date = null, Expression<Func<string>> dueDate = null, Expression<Func<statusInput>> status = null, Expression<Func<string>> customerId = null, Expression<Func<filterByInput>> filterBy = null, Expression<Func<string>> searchText = null, Expression<Func<sortColumnInput>> sortColumn = null, Expression<Func<string>> zcrmPotentialId = null, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_invoiceNumber = invoiceNumber == null ? null : WorkflowExpression.Compile(invoiceNumber);
            WorkflowExpression.Validate(__workflow_invoiceNumber, nameof(invoiceNumber), required: false);
            var __workflow_itemName = itemName == null ? null : WorkflowExpression.Compile(itemName);
            WorkflowExpression.Validate(__workflow_itemName, nameof(itemName), required: false);
            var __workflow_itemId = itemId == null ? null : WorkflowExpression.Compile(itemId);
            WorkflowExpression.Validate(__workflow_itemId, nameof(itemId), required: false);
            var __workflow_itemDescription = itemDescription == null ? null : WorkflowExpression.Compile(itemDescription);
            WorkflowExpression.Validate(__workflow_itemDescription, nameof(itemDescription), required: false);
            var __workflow_referenceNumber = referenceNumber == null ? null : WorkflowExpression.Compile(referenceNumber);
            WorkflowExpression.Validate(__workflow_referenceNumber, nameof(referenceNumber), required: false);
            var __workflow_customerName = customerName == null ? null : WorkflowExpression.Compile(customerName);
            WorkflowExpression.Validate(__workflow_customerName, nameof(customerName), required: false);
            var __workflow_recurringInvoiceId = recurringInvoiceId == null ? null : WorkflowExpression.Compile(recurringInvoiceId);
            WorkflowExpression.Validate(__workflow_recurringInvoiceId, nameof(recurringInvoiceId), required: false);
            var __workflow_email = email == null ? null : WorkflowExpression.Compile(email);
            WorkflowExpression.Validate(__workflow_email, nameof(email), required: false);
            var __workflow_total = total == null ? null : WorkflowExpression.Compile(total);
            WorkflowExpression.Validate(__workflow_total, nameof(total), required: false);
            var __workflow_balance = balance == null ? null : WorkflowExpression.Compile(balance);
            WorkflowExpression.Validate(__workflow_balance, nameof(balance), required: false);
            var __workflow_customField = customField == null ? null : WorkflowExpression.Compile(customField);
            WorkflowExpression.Validate(__workflow_customField, nameof(customField), required: false);
            var __workflow_date = date == null ? null : WorkflowExpression.Compile(date);
            WorkflowExpression.Validate(__workflow_date, nameof(date), required: false);
            var __workflow_dueDate = dueDate == null ? null : WorkflowExpression.Compile(dueDate);
            WorkflowExpression.Validate(__workflow_dueDate, nameof(dueDate), required: false);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_customerId = customerId == null ? null : WorkflowExpression.Compile(customerId);
            WorkflowExpression.Validate(__workflow_customerId, nameof(customerId), required: false);
            var __workflow_filterBy = filterBy == null ? null : WorkflowExpression.Compile(filterBy);
            WorkflowExpression.Validate(__workflow_filterBy, nameof(filterBy), required: false);
            var __workflow_searchText = searchText == null ? null : WorkflowExpression.Compile(searchText);
            WorkflowExpression.Validate(__workflow_searchText, nameof(searchText), required: false);
            var __workflow_sortColumn = sortColumn == null ? null : WorkflowExpression.Compile(sortColumn);
            WorkflowExpression.Validate(__workflow_sortColumn, nameof(sortColumn), required: false);
            var __workflow_zcrmPotentialId = zcrmPotentialId == null ? null : WorkflowExpression.Compile(zcrmPotentialId);
            WorkflowExpression.Validate(__workflow_zcrmPotentialId, nameof(zcrmPotentialId), required: false);
            var __workflow_page = page == null ? null : WorkflowExpression.Compile(page);
            WorkflowExpression.Validate(__workflow_page, nameof(page), required: false);
            var __workflow_perPage = perPage == null ? null : WorkflowExpression.Compile(perPage);
            WorkflowExpression.Validate(__workflow_perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<InvoicesGetResponse>(() =>
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
        public IBodyWorkflowAction<InvoicePostResponse> Invoice(Expression<Func<bool>> send = null, Expression<Func<bool>> ignoreAutoNumberGeneration = null, Expression<Func<string>> bodycustomerId = null, Expression<Func<int[]>> bodycontactPersons = null, Expression<Func<string>> bodyinvoiceNumber = null, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<string>> bodyplaceOfSupply = null, Expression<Func<string>> bodyvatTreatment = null, Expression<Func<string>> bodygstTreatment = null, Expression<Func<string>> bodytaxTreatment = null, Expression<Func<string>> bodycfdiUsage = null, Expression<Func<string>> bodygstNo = null, Expression<Func<string>> bodytemplateId = null, Expression<Func<string>> bodydate = null, Expression<Func<int>> bodypaymentTerms = null, Expression<Func<string>> bodypaymentTermsLabel = null, Expression<Func<string>> bodydueDate = null, Expression<Func<double>> bodydiscount = null, Expression<Func<bool>> bodyisDiscountBeforeTax = null, Expression<Func<string>> bodydiscountType = null, Expression<Func<bool>> bodyisInclusiveTax = null, Expression<Func<double>> bodyexchangeRate = null, Expression<Func<string>> bodyrecurringInvoiceId = null, Expression<Func<string>> bodyinvoicedEstimateId = null, Expression<Func<string>> bodysalespersonName = null, Expression<Func<bodycustomFieldsInputItem22[]>> bodycustomFields = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<bodylineItemsInputItem[]>> bodylineItems = null, Expression<Func<bodypaymentOptionspaymentGatewaysInputItem[]>> bodypaymentOptionspaymentGateways = null, Expression<Func<bool>> bodyallowPartialPayments = null, Expression<Func<string>> bodycustomBody = null, Expression<Func<string>> bodycustomSubject = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyterms = null, Expression<Func<double>> bodyshippingCharge = null, Expression<Func<double>> bodyadjustment = null, Expression<Func<string>> bodyadjustmentDescription = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodytaxAuthorityId = null, Expression<Func<string>> bodytaxExemptionId = null, Expression<Func<string>> bodyavataxUseCode = null, Expression<Func<string>> bodyavataxTaxCode = null, Expression<Func<string>> bodyavataxExemptNo = null)
        {
            var __workflow_send = send == null ? null : WorkflowExpression.Compile(send);
            WorkflowExpression.Validate(__workflow_send, nameof(send), required: false);
            var __workflow_ignoreAutoNumberGeneration = ignoreAutoNumberGeneration == null ? null : WorkflowExpression.Compile(ignoreAutoNumberGeneration);
            WorkflowExpression.Validate(__workflow_ignoreAutoNumberGeneration, nameof(ignoreAutoNumberGeneration), required: false);
            var __workflow_bodycustomerId = bodycustomerId == null ? null : WorkflowExpression.Compile(bodycustomerId);
            WorkflowExpression.Validate(__workflow_bodycustomerId, nameof(bodycustomerId), required: false);
            var __workflow_bodycontactPersons = bodycontactPersons == null ? null : WorkflowExpression.Compile(bodycontactPersons);
            WorkflowExpression.Validate(__workflow_bodycontactPersons, nameof(bodycontactPersons), required: false);
            var __workflow_bodyinvoiceNumber = bodyinvoiceNumber == null ? null : WorkflowExpression.Compile(bodyinvoiceNumber);
            WorkflowExpression.Validate(__workflow_bodyinvoiceNumber, nameof(bodyinvoiceNumber), required: false);
            var __workflow_bodyreferenceNumber = bodyreferenceNumber == null ? null : WorkflowExpression.Compile(bodyreferenceNumber);
            WorkflowExpression.Validate(__workflow_bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            var __workflow_bodyplaceOfSupply = bodyplaceOfSupply == null ? null : WorkflowExpression.Compile(bodyplaceOfSupply);
            WorkflowExpression.Validate(__workflow_bodyplaceOfSupply, nameof(bodyplaceOfSupply), required: false);
            var __workflow_bodyvatTreatment = bodyvatTreatment == null ? null : WorkflowExpression.Compile(bodyvatTreatment);
            WorkflowExpression.Validate(__workflow_bodyvatTreatment, nameof(bodyvatTreatment), required: false);
            var __workflow_bodygstTreatment = bodygstTreatment == null ? null : WorkflowExpression.Compile(bodygstTreatment);
            WorkflowExpression.Validate(__workflow_bodygstTreatment, nameof(bodygstTreatment), required: false);
            var __workflow_bodytaxTreatment = bodytaxTreatment == null ? null : WorkflowExpression.Compile(bodytaxTreatment);
            WorkflowExpression.Validate(__workflow_bodytaxTreatment, nameof(bodytaxTreatment), required: false);
            var __workflow_bodycfdiUsage = bodycfdiUsage == null ? null : WorkflowExpression.Compile(bodycfdiUsage);
            WorkflowExpression.Validate(__workflow_bodycfdiUsage, nameof(bodycfdiUsage), required: false);
            var __workflow_bodygstNo = bodygstNo == null ? null : WorkflowExpression.Compile(bodygstNo);
            WorkflowExpression.Validate(__workflow_bodygstNo, nameof(bodygstNo), required: false);
            var __workflow_bodytemplateId = bodytemplateId == null ? null : WorkflowExpression.Compile(bodytemplateId);
            WorkflowExpression.Validate(__workflow_bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodydate = bodydate == null ? null : WorkflowExpression.Compile(bodydate);
            WorkflowExpression.Validate(__workflow_bodydate, nameof(bodydate), required: false);
            var __workflow_bodypaymentTerms = bodypaymentTerms == null ? null : WorkflowExpression.Compile(bodypaymentTerms);
            WorkflowExpression.Validate(__workflow_bodypaymentTerms, nameof(bodypaymentTerms), required: false);
            var __workflow_bodypaymentTermsLabel = bodypaymentTermsLabel == null ? null : WorkflowExpression.Compile(bodypaymentTermsLabel);
            WorkflowExpression.Validate(__workflow_bodypaymentTermsLabel, nameof(bodypaymentTermsLabel), required: false);
            var __workflow_bodydueDate = bodydueDate == null ? null : WorkflowExpression.Compile(bodydueDate);
            WorkflowExpression.Validate(__workflow_bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodydiscount = bodydiscount == null ? null : WorkflowExpression.Compile(bodydiscount);
            WorkflowExpression.Validate(__workflow_bodydiscount, nameof(bodydiscount), required: false);
            var __workflow_bodyisDiscountBeforeTax = bodyisDiscountBeforeTax == null ? null : WorkflowExpression.Compile(bodyisDiscountBeforeTax);
            WorkflowExpression.Validate(__workflow_bodyisDiscountBeforeTax, nameof(bodyisDiscountBeforeTax), required: false);
            var __workflow_bodydiscountType = bodydiscountType == null ? null : WorkflowExpression.Compile(bodydiscountType);
            WorkflowExpression.Validate(__workflow_bodydiscountType, nameof(bodydiscountType), required: false);
            var __workflow_bodyisInclusiveTax = bodyisInclusiveTax == null ? null : WorkflowExpression.Compile(bodyisInclusiveTax);
            WorkflowExpression.Validate(__workflow_bodyisInclusiveTax, nameof(bodyisInclusiveTax), required: false);
            var __workflow_bodyexchangeRate = bodyexchangeRate == null ? null : WorkflowExpression.Compile(bodyexchangeRate);
            WorkflowExpression.Validate(__workflow_bodyexchangeRate, nameof(bodyexchangeRate), required: false);
            var __workflow_bodyrecurringInvoiceId = bodyrecurringInvoiceId == null ? null : WorkflowExpression.Compile(bodyrecurringInvoiceId);
            WorkflowExpression.Validate(__workflow_bodyrecurringInvoiceId, nameof(bodyrecurringInvoiceId), required: false);
            var __workflow_bodyinvoicedEstimateId = bodyinvoicedEstimateId == null ? null : WorkflowExpression.Compile(bodyinvoicedEstimateId);
            WorkflowExpression.Validate(__workflow_bodyinvoicedEstimateId, nameof(bodyinvoicedEstimateId), required: false);
            var __workflow_bodysalespersonName = bodysalespersonName == null ? null : WorkflowExpression.Compile(bodysalespersonName);
            WorkflowExpression.Validate(__workflow_bodysalespersonName, nameof(bodysalespersonName), required: false);
            var __workflow_bodycustomFields = bodycustomFields == null ? null : WorkflowExpression.Compile(bodycustomFields);
            WorkflowExpression.Validate(__workflow_bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodyprojectId = bodyprojectId == null ? null : WorkflowExpression.Compile(bodyprojectId);
            WorkflowExpression.Validate(__workflow_bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodylineItems = bodylineItems == null ? null : WorkflowExpression.Compile(bodylineItems);
            WorkflowExpression.Validate(__workflow_bodylineItems, nameof(bodylineItems), required: false);
            var __workflow_bodypaymentOptionspaymentGateways = bodypaymentOptionspaymentGateways == null ? null : WorkflowExpression.Compile(bodypaymentOptionspaymentGateways);
            WorkflowExpression.Validate(__workflow_bodypaymentOptionspaymentGateways, nameof(bodypaymentOptionspaymentGateways), required: false);
            var __workflow_bodyallowPartialPayments = bodyallowPartialPayments == null ? null : WorkflowExpression.Compile(bodyallowPartialPayments);
            WorkflowExpression.Validate(__workflow_bodyallowPartialPayments, nameof(bodyallowPartialPayments), required: false);
            var __workflow_bodycustomBody = bodycustomBody == null ? null : WorkflowExpression.Compile(bodycustomBody);
            WorkflowExpression.Validate(__workflow_bodycustomBody, nameof(bodycustomBody), required: false);
            var __workflow_bodycustomSubject = bodycustomSubject == null ? null : WorkflowExpression.Compile(bodycustomSubject);
            WorkflowExpression.Validate(__workflow_bodycustomSubject, nameof(bodycustomSubject), required: false);
            var __workflow_bodynotes = bodynotes == null ? null : WorkflowExpression.Compile(bodynotes);
            WorkflowExpression.Validate(__workflow_bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyterms = bodyterms == null ? null : WorkflowExpression.Compile(bodyterms);
            WorkflowExpression.Validate(__workflow_bodyterms, nameof(bodyterms), required: false);
            var __workflow_bodyshippingCharge = bodyshippingCharge == null ? null : WorkflowExpression.Compile(bodyshippingCharge);
            WorkflowExpression.Validate(__workflow_bodyshippingCharge, nameof(bodyshippingCharge), required: false);
            var __workflow_bodyadjustment = bodyadjustment == null ? null : WorkflowExpression.Compile(bodyadjustment);
            WorkflowExpression.Validate(__workflow_bodyadjustment, nameof(bodyadjustment), required: false);
            var __workflow_bodyadjustmentDescription = bodyadjustmentDescription == null ? null : WorkflowExpression.Compile(bodyadjustmentDescription);
            WorkflowExpression.Validate(__workflow_bodyadjustmentDescription, nameof(bodyadjustmentDescription), required: false);
            var __workflow_bodyreason = bodyreason == null ? null : WorkflowExpression.Compile(bodyreason);
            WorkflowExpression.Validate(__workflow_bodyreason, nameof(bodyreason), required: false);
            var __workflow_bodytaxAuthorityId = bodytaxAuthorityId == null ? null : WorkflowExpression.Compile(bodytaxAuthorityId);
            WorkflowExpression.Validate(__workflow_bodytaxAuthorityId, nameof(bodytaxAuthorityId), required: false);
            var __workflow_bodytaxExemptionId = bodytaxExemptionId == null ? null : WorkflowExpression.Compile(bodytaxExemptionId);
            WorkflowExpression.Validate(__workflow_bodytaxExemptionId, nameof(bodytaxExemptionId), required: false);
            var __workflow_bodyavataxUseCode = bodyavataxUseCode == null ? null : WorkflowExpression.Compile(bodyavataxUseCode);
            WorkflowExpression.Validate(__workflow_bodyavataxUseCode, nameof(bodyavataxUseCode), required: false);
            var __workflow_bodyavataxTaxCode = bodyavataxTaxCode == null ? null : WorkflowExpression.Compile(bodyavataxTaxCode);
            WorkflowExpression.Validate(__workflow_bodyavataxTaxCode, nameof(bodyavataxTaxCode), required: false);
            var __workflow_bodyavataxExemptNo = bodyavataxExemptNo == null ? null : WorkflowExpression.Compile(bodyavataxExemptNo);
            WorkflowExpression.Validate(__workflow_bodyavataxExemptNo, nameof(bodyavataxExemptNo), required: false);
            return new DeferredBodyAction<InvoicePostResponse>(() =>
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
        public IBodyWorkflowAction<InvoiceGetResponse> InvoiceGet(Expression<Func<string>> invoiceId)
        {
            var __workflow_invoiceId = invoiceId == null ? null : WorkflowExpression.Compile(invoiceId);
            WorkflowExpression.Validate(__workflow_invoiceId, nameof(invoiceId), required: true);
            return new DeferredBodyAction<InvoiceGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoice/v3/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_invoiceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InvoiceGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoiceDeleteResponse> InvoiceDelete(Expression<Func<string>> invoiceId)
        {
            var __workflow_invoiceId = invoiceId == null ? null : WorkflowExpression.Compile(invoiceId);
            WorkflowExpression.Validate(__workflow_invoiceId, nameof(invoiceId), required: true);
            return new DeferredBodyAction<InvoiceDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoice/v3/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_invoiceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<InvoiceDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zohoinvoicebasic")]
        public IBodyWorkflowAction<InvoicePutResponse> InvoicePut(Expression<Func<string>> invoiceId, Expression<Func<string>> bodycustomerId = null, Expression<Func<int[]>> bodycontactPersons = null, Expression<Func<string>> bodyinvoiceNumber = null, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<string>> bodyplaceOfSupply = null, Expression<Func<string>> bodyvatTreatment = null, Expression<Func<string>> bodygstTreatment = null, Expression<Func<string>> bodytaxTreatment = null, Expression<Func<string>> bodycfdiUsage = null, Expression<Func<string>> bodygstNo = null, Expression<Func<string>> bodytemplateId = null, Expression<Func<string>> bodydate = null, Expression<Func<int>> bodypaymentTerms = null, Expression<Func<string>> bodypaymentTermsLabel = null, Expression<Func<string>> bodydueDate = null, Expression<Func<double>> bodydiscount = null, Expression<Func<bool>> bodyisDiscountBeforeTax = null, Expression<Func<string>> bodydiscountType = null, Expression<Func<bool>> bodyisInclusiveTax = null, Expression<Func<double>> bodyexchangeRate = null, Expression<Func<string>> bodyrecurringInvoiceId = null, Expression<Func<string>> bodyinvoicedEstimateId = null, Expression<Func<string>> bodysalespersonName = null, Expression<Func<bodycustomFieldsInputItem22[]>> bodycustomFields = null, Expression<Func<string>> bodyprojectId = null, Expression<Func<bodylineItemsInputItem[]>> bodylineItems = null, Expression<Func<bodypaymentOptionspaymentGatewaysInputItem[]>> bodypaymentOptionspaymentGateways = null, Expression<Func<bool>> bodyallowPartialPayments = null, Expression<Func<string>> bodycustomBody = null, Expression<Func<string>> bodycustomSubject = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodyterms = null, Expression<Func<double>> bodyshippingCharge = null, Expression<Func<double>> bodyadjustment = null, Expression<Func<string>> bodyadjustmentDescription = null, Expression<Func<string>> bodyreason = null, Expression<Func<string>> bodytaxAuthorityId = null, Expression<Func<string>> bodytaxExemptionId = null, Expression<Func<string>> bodyavataxUseCode = null, Expression<Func<string>> bodyavataxTaxCode = null, Expression<Func<string>> bodyavataxExemptNo = null)
        {
            var __workflow_invoiceId = invoiceId == null ? null : WorkflowExpression.Compile(invoiceId);
            WorkflowExpression.Validate(__workflow_invoiceId, nameof(invoiceId), required: true);
            var __workflow_bodycustomerId = bodycustomerId == null ? null : WorkflowExpression.Compile(bodycustomerId);
            WorkflowExpression.Validate(__workflow_bodycustomerId, nameof(bodycustomerId), required: false);
            var __workflow_bodycontactPersons = bodycontactPersons == null ? null : WorkflowExpression.Compile(bodycontactPersons);
            WorkflowExpression.Validate(__workflow_bodycontactPersons, nameof(bodycontactPersons), required: false);
            var __workflow_bodyinvoiceNumber = bodyinvoiceNumber == null ? null : WorkflowExpression.Compile(bodyinvoiceNumber);
            WorkflowExpression.Validate(__workflow_bodyinvoiceNumber, nameof(bodyinvoiceNumber), required: false);
            var __workflow_bodyreferenceNumber = bodyreferenceNumber == null ? null : WorkflowExpression.Compile(bodyreferenceNumber);
            WorkflowExpression.Validate(__workflow_bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            var __workflow_bodyplaceOfSupply = bodyplaceOfSupply == null ? null : WorkflowExpression.Compile(bodyplaceOfSupply);
            WorkflowExpression.Validate(__workflow_bodyplaceOfSupply, nameof(bodyplaceOfSupply), required: false);
            var __workflow_bodyvatTreatment = bodyvatTreatment == null ? null : WorkflowExpression.Compile(bodyvatTreatment);
            WorkflowExpression.Validate(__workflow_bodyvatTreatment, nameof(bodyvatTreatment), required: false);
            var __workflow_bodygstTreatment = bodygstTreatment == null ? null : WorkflowExpression.Compile(bodygstTreatment);
            WorkflowExpression.Validate(__workflow_bodygstTreatment, nameof(bodygstTreatment), required: false);
            var __workflow_bodytaxTreatment = bodytaxTreatment == null ? null : WorkflowExpression.Compile(bodytaxTreatment);
            WorkflowExpression.Validate(__workflow_bodytaxTreatment, nameof(bodytaxTreatment), required: false);
            var __workflow_bodycfdiUsage = bodycfdiUsage == null ? null : WorkflowExpression.Compile(bodycfdiUsage);
            WorkflowExpression.Validate(__workflow_bodycfdiUsage, nameof(bodycfdiUsage), required: false);
            var __workflow_bodygstNo = bodygstNo == null ? null : WorkflowExpression.Compile(bodygstNo);
            WorkflowExpression.Validate(__workflow_bodygstNo, nameof(bodygstNo), required: false);
            var __workflow_bodytemplateId = bodytemplateId == null ? null : WorkflowExpression.Compile(bodytemplateId);
            WorkflowExpression.Validate(__workflow_bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodydate = bodydate == null ? null : WorkflowExpression.Compile(bodydate);
            WorkflowExpression.Validate(__workflow_bodydate, nameof(bodydate), required: false);
            var __workflow_bodypaymentTerms = bodypaymentTerms == null ? null : WorkflowExpression.Compile(bodypaymentTerms);
            WorkflowExpression.Validate(__workflow_bodypaymentTerms, nameof(bodypaymentTerms), required: false);
            var __workflow_bodypaymentTermsLabel = bodypaymentTermsLabel == null ? null : WorkflowExpression.Compile(bodypaymentTermsLabel);
            WorkflowExpression.Validate(__workflow_bodypaymentTermsLabel, nameof(bodypaymentTermsLabel), required: false);
            var __workflow_bodydueDate = bodydueDate == null ? null : WorkflowExpression.Compile(bodydueDate);
            WorkflowExpression.Validate(__workflow_bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodydiscount = bodydiscount == null ? null : WorkflowExpression.Compile(bodydiscount);
            WorkflowExpression.Validate(__workflow_bodydiscount, nameof(bodydiscount), required: false);
            var __workflow_bodyisDiscountBeforeTax = bodyisDiscountBeforeTax == null ? null : WorkflowExpression.Compile(bodyisDiscountBeforeTax);
            WorkflowExpression.Validate(__workflow_bodyisDiscountBeforeTax, nameof(bodyisDiscountBeforeTax), required: false);
            var __workflow_bodydiscountType = bodydiscountType == null ? null : WorkflowExpression.Compile(bodydiscountType);
            WorkflowExpression.Validate(__workflow_bodydiscountType, nameof(bodydiscountType), required: false);
            var __workflow_bodyisInclusiveTax = bodyisInclusiveTax == null ? null : WorkflowExpression.Compile(bodyisInclusiveTax);
            WorkflowExpression.Validate(__workflow_bodyisInclusiveTax, nameof(bodyisInclusiveTax), required: false);
            var __workflow_bodyexchangeRate = bodyexchangeRate == null ? null : WorkflowExpression.Compile(bodyexchangeRate);
            WorkflowExpression.Validate(__workflow_bodyexchangeRate, nameof(bodyexchangeRate), required: false);
            var __workflow_bodyrecurringInvoiceId = bodyrecurringInvoiceId == null ? null : WorkflowExpression.Compile(bodyrecurringInvoiceId);
            WorkflowExpression.Validate(__workflow_bodyrecurringInvoiceId, nameof(bodyrecurringInvoiceId), required: false);
            var __workflow_bodyinvoicedEstimateId = bodyinvoicedEstimateId == null ? null : WorkflowExpression.Compile(bodyinvoicedEstimateId);
            WorkflowExpression.Validate(__workflow_bodyinvoicedEstimateId, nameof(bodyinvoicedEstimateId), required: false);
            var __workflow_bodysalespersonName = bodysalespersonName == null ? null : WorkflowExpression.Compile(bodysalespersonName);
            WorkflowExpression.Validate(__workflow_bodysalespersonName, nameof(bodysalespersonName), required: false);
            var __workflow_bodycustomFields = bodycustomFields == null ? null : WorkflowExpression.Compile(bodycustomFields);
            WorkflowExpression.Validate(__workflow_bodycustomFields, nameof(bodycustomFields), required: false);
            var __workflow_bodyprojectId = bodyprojectId == null ? null : WorkflowExpression.Compile(bodyprojectId);
            WorkflowExpression.Validate(__workflow_bodyprojectId, nameof(bodyprojectId), required: false);
            var __workflow_bodylineItems = bodylineItems == null ? null : WorkflowExpression.Compile(bodylineItems);
            WorkflowExpression.Validate(__workflow_bodylineItems, nameof(bodylineItems), required: false);
            var __workflow_bodypaymentOptionspaymentGateways = bodypaymentOptionspaymentGateways == null ? null : WorkflowExpression.Compile(bodypaymentOptionspaymentGateways);
            WorkflowExpression.Validate(__workflow_bodypaymentOptionspaymentGateways, nameof(bodypaymentOptionspaymentGateways), required: false);
            var __workflow_bodyallowPartialPayments = bodyallowPartialPayments == null ? null : WorkflowExpression.Compile(bodyallowPartialPayments);
            WorkflowExpression.Validate(__workflow_bodyallowPartialPayments, nameof(bodyallowPartialPayments), required: false);
            var __workflow_bodycustomBody = bodycustomBody == null ? null : WorkflowExpression.Compile(bodycustomBody);
            WorkflowExpression.Validate(__workflow_bodycustomBody, nameof(bodycustomBody), required: false);
            var __workflow_bodycustomSubject = bodycustomSubject == null ? null : WorkflowExpression.Compile(bodycustomSubject);
            WorkflowExpression.Validate(__workflow_bodycustomSubject, nameof(bodycustomSubject), required: false);
            var __workflow_bodynotes = bodynotes == null ? null : WorkflowExpression.Compile(bodynotes);
            WorkflowExpression.Validate(__workflow_bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodyterms = bodyterms == null ? null : WorkflowExpression.Compile(bodyterms);
            WorkflowExpression.Validate(__workflow_bodyterms, nameof(bodyterms), required: false);
            var __workflow_bodyshippingCharge = bodyshippingCharge == null ? null : WorkflowExpression.Compile(bodyshippingCharge);
            WorkflowExpression.Validate(__workflow_bodyshippingCharge, nameof(bodyshippingCharge), required: false);
            var __workflow_bodyadjustment = bodyadjustment == null ? null : WorkflowExpression.Compile(bodyadjustment);
            WorkflowExpression.Validate(__workflow_bodyadjustment, nameof(bodyadjustment), required: false);
            var __workflow_bodyadjustmentDescription = bodyadjustmentDescription == null ? null : WorkflowExpression.Compile(bodyadjustmentDescription);
            WorkflowExpression.Validate(__workflow_bodyadjustmentDescription, nameof(bodyadjustmentDescription), required: false);
            var __workflow_bodyreason = bodyreason == null ? null : WorkflowExpression.Compile(bodyreason);
            WorkflowExpression.Validate(__workflow_bodyreason, nameof(bodyreason), required: false);
            var __workflow_bodytaxAuthorityId = bodytaxAuthorityId == null ? null : WorkflowExpression.Compile(bodytaxAuthorityId);
            WorkflowExpression.Validate(__workflow_bodytaxAuthorityId, nameof(bodytaxAuthorityId), required: false);
            var __workflow_bodytaxExemptionId = bodytaxExemptionId == null ? null : WorkflowExpression.Compile(bodytaxExemptionId);
            WorkflowExpression.Validate(__workflow_bodytaxExemptionId, nameof(bodytaxExemptionId), required: false);
            var __workflow_bodyavataxUseCode = bodyavataxUseCode == null ? null : WorkflowExpression.Compile(bodyavataxUseCode);
            WorkflowExpression.Validate(__workflow_bodyavataxUseCode, nameof(bodyavataxUseCode), required: false);
            var __workflow_bodyavataxTaxCode = bodyavataxTaxCode == null ? null : WorkflowExpression.Compile(bodyavataxTaxCode);
            WorkflowExpression.Validate(__workflow_bodyavataxTaxCode, nameof(bodyavataxTaxCode), required: false);
            var __workflow_bodyavataxExemptNo = bodyavataxExemptNo == null ? null : WorkflowExpression.Compile(bodyavataxExemptNo);
            WorkflowExpression.Validate(__workflow_bodyavataxExemptNo, nameof(bodyavataxExemptNo), required: false);
            return new DeferredBodyAction<InvoicePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoice/v3/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_invoiceId, 1));
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
