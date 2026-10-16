//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Freeagentip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FreeagentipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction DeleteContact(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<GetContactResponse> GetContact(Expression<Func<string>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<GetContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction UpdateContact(Expression<Func<string>> contactId, Expression<Func<bool>> bodycontactcontactNameOnInvoices = null, Expression<Func<int>> bodycontactdefaultPaymentTermsInDays = null, Expression<Func<string>> bodycontactlocale = null, Expression<Func<string>> bodycontactcountry = null)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            var __workflow_bodycontactcontactNameOnInvoices = WorkflowExpression.Compile(bodycontactcontactNameOnInvoices, nameof(bodycontactcontactNameOnInvoices), required: false);
            var __workflow_bodycontactdefaultPaymentTermsInDays = WorkflowExpression.Compile(bodycontactdefaultPaymentTermsInDays, nameof(bodycontactdefaultPaymentTermsInDays), required: false);
            var __workflow_bodycontactlocale = WorkflowExpression.Compile(bodycontactlocale, nameof(bodycontactlocale), required: false);
            var __workflow_bodycontactcountry = WorkflowExpression.Compile(bodycontactcountry, nameof(bodycontactcountry), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_contactId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                if (__workflow_bodycontactcontactNameOnInvoices != null)
                {
                    contactObject["contact_name_on_invoices"] = ExpressionConverter.ConvertO(__workflow_bodycontactcontactNameOnInvoices);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactdefaultPaymentTermsInDays != null)
                {
                    contactObject["default_payment_terms_in_days"] = ExpressionConverter.ConvertO(__workflow_bodycontactdefaultPaymentTermsInDays);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactlocale != null)
                {
                    contactObject["locale"] = ExpressionConverter.ConvertO(__workflow_bodycontactlocale);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactcountry != null)
                {
                    contactObject["country"] = ExpressionConverter.ConvertO(__workflow_bodycontactcountry);
                    contactObjectpropCount++;
                }

                if (contactObjectpropCount > 0)
                {
                    body["contact"] = contactObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction DeleteInvoice(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<ShowInvoiceResponse> ShowInvoice(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ShowInvoiceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ShowInvoiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction UpdateInvoice(Expression<Func<string>> id, Expression<Func<string>> bodyinvoicedatedOn = null, Expression<Func<string>> bodyinvoicedueOn = null, Expression<Func<string>> bodyinvoicecurrency = null, Expression<Func<string>> bodyinvoiceexchangeRate = null, Expression<Func<string>> bodyinvoicestatus = null, Expression<Func<bodyinvoiceinvoiceItemsInputItem[]>> bodyinvoiceinvoiceItems = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyinvoicedatedOn = WorkflowExpression.Compile(bodyinvoicedatedOn, nameof(bodyinvoicedatedOn), required: false);
            var __workflow_bodyinvoicedueOn = WorkflowExpression.Compile(bodyinvoicedueOn, nameof(bodyinvoicedueOn), required: false);
            var __workflow_bodyinvoicecurrency = WorkflowExpression.Compile(bodyinvoicecurrency, nameof(bodyinvoicecurrency), required: false);
            var __workflow_bodyinvoiceexchangeRate = WorkflowExpression.Compile(bodyinvoiceexchangeRate, nameof(bodyinvoiceexchangeRate), required: false);
            var __workflow_bodyinvoicestatus = WorkflowExpression.Compile(bodyinvoicestatus, nameof(bodyinvoicestatus), required: false);
            var __workflow_bodyinvoiceinvoiceItems = WorkflowExpression.Compile(bodyinvoiceinvoiceItems, nameof(bodyinvoiceinvoiceItems), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var invoiceObject = new JObject();
                var invoiceObjectpropCount = 0;
                if (__workflow_bodyinvoicedatedOn != null)
                {
                    invoiceObject["dated_on"] = ExpressionConverter.ConvertO(__workflow_bodyinvoicedatedOn);
                    invoiceObjectpropCount++;
                }

                if (__workflow_bodyinvoicedueOn != null)
                {
                    invoiceObject["due_on"] = ExpressionConverter.ConvertO(__workflow_bodyinvoicedueOn);
                    invoiceObjectpropCount++;
                }

                if (__workflow_bodyinvoicecurrency != null)
                {
                    invoiceObject["currency"] = ExpressionConverter.ConvertO(__workflow_bodyinvoicecurrency);
                    invoiceObjectpropCount++;
                }

                if (__workflow_bodyinvoiceexchangeRate != null)
                {
                    invoiceObject["exchange_rate"] = ExpressionConverter.ConvertO(__workflow_bodyinvoiceexchangeRate);
                    invoiceObjectpropCount++;
                }

                if (__workflow_bodyinvoicestatus != null)
                {
                    invoiceObject["status"] = ExpressionConverter.ConvertO(__workflow_bodyinvoicestatus);
                    invoiceObjectpropCount++;
                }

                if (__workflow_bodyinvoiceinvoiceItems != null)
                {
                    invoiceObject["invoice_items"] = ExpressionConverter.ConvertO(__workflow_bodyinvoiceinvoiceItems);
                    invoiceObjectpropCount++;
                }

                if (invoiceObjectpropCount > 0)
                {
                    body["invoice"] = invoiceObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<GetContactsResponse> GetContacts()
        {
            var apiCallPath = "/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetContactsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact(Expression<Func<string>> bodycontactfirstName = null, Expression<Func<string>> bodycontactlastName = null, Expression<Func<string>> bodycontactorganisationName = null, Expression<Func<string>> bodycontactemail = null, Expression<Func<string>> bodycontacttelephone = null, Expression<Func<string>> bodycontactmobile = null, Expression<Func<string>> bodycontactaddress1 = null, Expression<Func<string>> bodycontactaddress2 = null, Expression<Func<string>> bodycontactaddress3 = null, Expression<Func<string>> bodycontacttown = null, Expression<Func<string>> bodycontactregion = null, Expression<Func<string>> bodycontactpostcode = null, Expression<Func<string>> bodycontactcountry = null)
        {
            var __workflow_bodycontactfirstName = WorkflowExpression.Compile(bodycontactfirstName, nameof(bodycontactfirstName), required: false);
            var __workflow_bodycontactlastName = WorkflowExpression.Compile(bodycontactlastName, nameof(bodycontactlastName), required: false);
            var __workflow_bodycontactorganisationName = WorkflowExpression.Compile(bodycontactorganisationName, nameof(bodycontactorganisationName), required: false);
            var __workflow_bodycontactemail = WorkflowExpression.Compile(bodycontactemail, nameof(bodycontactemail), required: false);
            var __workflow_bodycontacttelephone = WorkflowExpression.Compile(bodycontacttelephone, nameof(bodycontacttelephone), required: false);
            var __workflow_bodycontactmobile = WorkflowExpression.Compile(bodycontactmobile, nameof(bodycontactmobile), required: false);
            var __workflow_bodycontactaddress1 = WorkflowExpression.Compile(bodycontactaddress1, nameof(bodycontactaddress1), required: false);
            var __workflow_bodycontactaddress2 = WorkflowExpression.Compile(bodycontactaddress2, nameof(bodycontactaddress2), required: false);
            var __workflow_bodycontactaddress3 = WorkflowExpression.Compile(bodycontactaddress3, nameof(bodycontactaddress3), required: false);
            var __workflow_bodycontacttown = WorkflowExpression.Compile(bodycontacttown, nameof(bodycontacttown), required: false);
            var __workflow_bodycontactregion = WorkflowExpression.Compile(bodycontactregion, nameof(bodycontactregion), required: false);
            var __workflow_bodycontactpostcode = WorkflowExpression.Compile(bodycontactpostcode, nameof(bodycontactpostcode), required: false);
            var __workflow_bodycontactcountry = WorkflowExpression.Compile(bodycontactcountry, nameof(bodycontactcountry), required: false);
            return new DeferredBodyAction<CreateContactResponse>(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                if (__workflow_bodycontactfirstName != null)
                {
                    contactObject["first_name"] = ExpressionConverter.ConvertO(__workflow_bodycontactfirstName);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactlastName != null)
                {
                    contactObject["last_name"] = ExpressionConverter.ConvertO(__workflow_bodycontactlastName);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactorganisationName != null)
                {
                    contactObject["organisation_name"] = ExpressionConverter.ConvertO(__workflow_bodycontactorganisationName);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactemail != null)
                {
                    contactObject["email"] = ExpressionConverter.ConvertO(__workflow_bodycontactemail);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontacttelephone != null)
                {
                    contactObject["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodycontacttelephone);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactmobile != null)
                {
                    contactObject["mobile"] = ExpressionConverter.ConvertO(__workflow_bodycontactmobile);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactaddress1 != null)
                {
                    contactObject["address1"] = ExpressionConverter.ConvertO(__workflow_bodycontactaddress1);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactaddress2 != null)
                {
                    contactObject["address2"] = ExpressionConverter.ConvertO(__workflow_bodycontactaddress2);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactaddress3 != null)
                {
                    contactObject["address3"] = ExpressionConverter.ConvertO(__workflow_bodycontactaddress3);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontacttown != null)
                {
                    contactObject["town"] = ExpressionConverter.ConvertO(__workflow_bodycontacttown);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactregion != null)
                {
                    contactObject["region"] = ExpressionConverter.ConvertO(__workflow_bodycontactregion);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactpostcode != null)
                {
                    contactObject["postcode"] = ExpressionConverter.ConvertO(__workflow_bodycontactpostcode);
                    contactObjectpropCount++;
                }

                if (__workflow_bodycontactcountry != null)
                {
                    contactObject["country"] = ExpressionConverter.ConvertO(__workflow_bodycontactcountry);
                    contactObjectpropCount++;
                }

                if (contactObjectpropCount > 0)
                {
                    body["contact"] = contactObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<ListAllRecurringInvoicesResponse> ListAllRecurringInvoices()
        {
            var apiCallPath = "/recurring_invoices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListAllRecurringInvoicesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<ListInvoicesResponse> ListInvoices()
        {
            var apiCallPath = "/invoices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListInvoicesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<CreateInvoiceResponse> CreateInvoice(Expression<Func<string>> bodyinvoicecontact = null, Expression<Func<string>> bodyinvoicedatedOn = null, Expression<Func<string>> bodyinvoicedueOn = null, Expression<Func<string>> bodyinvoicecurrency = null, Expression<Func<bool>> bodyinvoiceomitHeader = null, Expression<Func<bool>> bodyinvoicealwaysShowBICAndIBAN = null, Expression<Func<int>> bodyinvoicepaymentTermsInDays = null)
        {
            var __workflow_bodyinvoicecontact = WorkflowExpression.Compile(bodyinvoicecontact, nameof(bodyinvoicecontact), required: false);
            var __workflow_bodyinvoicedatedOn = WorkflowExpression.Compile(bodyinvoicedatedOn, nameof(bodyinvoicedatedOn), required: false);
            var __workflow_bodyinvoicedueOn = WorkflowExpression.Compile(bodyinvoicedueOn, nameof(bodyinvoicedueOn), required: false);
            var __workflow_bodyinvoicecurrency = WorkflowExpression.Compile(bodyinvoicecurrency, nameof(bodyinvoicecurrency), required: false);
            var __workflow_bodyinvoiceomitHeader = WorkflowExpression.Compile(bodyinvoiceomitHeader, nameof(bodyinvoiceomitHeader), required: false);
            var __workflow_bodyinvoicealwaysShowBICAndIBAN = WorkflowExpression.Compile(bodyinvoicealwaysShowBICAndIBAN, nameof(bodyinvoicealwaysShowBICAndIBAN), required: false);
            var __workflow_bodyinvoicepaymentTermsInDays = WorkflowExpression.Compile(bodyinvoicepaymentTermsInDays, nameof(bodyinvoicepaymentTermsInDays), required: false);
            return new DeferredBodyAction<CreateInvoiceResponse>(() =>
            {
                var apiCallPath = "/invoices";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var invoiceObject = new JObject();
                var invoiceObjectpropCount = 0;
                if (__workflow_bodyinvoicecontact != null)
                {
                    invoiceObject["contact"] = ExpressionConverter.ConvertO(__workflow_bodyinvoicecontact);
                    invoiceObjectpropCount++;
                }

                if (__workflow_bodyinvoicedatedOn != null)
                {
                    invoiceObject["dated_on"] = ExpressionConverter.ConvertO(__workflow_bodyinvoicedatedOn);
                    invoiceObjectpropCount++;
                }

                if (__workflow_bodyinvoicedueOn != null)
                {
                    invoiceObject["due_on"] = ExpressionConverter.ConvertO(__workflow_bodyinvoicedueOn);
                    invoiceObjectpropCount++;
                }

                if (__workflow_bodyinvoicecurrency != null)
                {
                    invoiceObject["currency"] = ExpressionConverter.ConvertO(__workflow_bodyinvoicecurrency);
                    invoiceObjectpropCount++;
                }

                if (__workflow_bodyinvoiceomitHeader != null)
                {
                    invoiceObject["omit_header"] = ExpressionConverter.ConvertO(__workflow_bodyinvoiceomitHeader);
                    invoiceObjectpropCount++;
                }

                if (__workflow_bodyinvoicealwaysShowBICAndIBAN != null)
                {
                    invoiceObject["always_show_bic_and_iban"] = ExpressionConverter.ConvertO(__workflow_bodyinvoicealwaysShowBICAndIBAN);
                    invoiceObjectpropCount++;
                }

                if (__workflow_bodyinvoicepaymentTermsInDays != null)
                {
                    invoiceObject["payment_terms_in_days"] = ExpressionConverter.ConvertO(__workflow_bodyinvoicepaymentTermsInDays);
                    invoiceObjectpropCount++;
                }

                if (invoiceObjectpropCount > 0)
                {
                    body["invoice"] = invoiceObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateInvoiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<ShowRecurringInvoiceResponse> ShowRecurringInvoice(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ShowRecurringInvoiceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/recurring_invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ShowRecurringInvoiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction MarkInvoiceAsCancelled(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoices/{0}/transitions/mark_as_cancelled", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction MarkInvoiceAsDraft(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoices/{0}/transitions/mark_as_draft", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction MarkInvoiceAsScheduled(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoices/{0}/transitions/mark_as_scheduled", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction MarkInvoiceAsSent(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoices/{0}/transitions/mark_as_sent", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class FreeagentipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetContactResponse
    {
        [JsonProperty("contact")]
        public GetContactResponseContactType Contact { get; set; }
    }

    public class GetContactResponseContactType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("organisation_name")]
        public string OrganisationName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("billing_email")]
        public string BillingEmail { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("town")]
        public string Town { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("contact_name_on_invoices")]
        public bool ContactNameOnInvoices { get; set; }

        [JsonProperty("default_payment_terms_in_days")]
        public int DefaultPaymentTermsInDays { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("account_balance")]
        public string AccountBalance { get; set; }

        [JsonProperty("uses_contact_invoice_sequence")]
        public bool UsesContactInvoiceSequence { get; set; }

        [JsonProperty("charge_sales_tax")]
        public string ChargeSalesTax { get; set; }

        [JsonProperty("sales_tax_registration_number")]
        public string SalesTaxRegistrationNumber { get; set; }

        [JsonProperty("active_projects_count")]
        public int ActiveProjectsCount { get; set; }

        [JsonProperty("direct_debit_mandate_state")]
        public string DirectDebitMandateState { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ShowInvoiceResponse
    {
        [JsonProperty("invoice")]
        public ShowInvoiceResponseInvoiceType Invoice { get; set; }
    }

    public class ShowInvoiceResponseInvoiceType
    {
        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("project")]
        public string Project { get; set; }

        [JsonProperty("dated_on")]
        public string DatedOn { get; set; }

        [JsonProperty("due_on")]
        public string DueOn { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("exchange_rate")]
        public string ExchangeRate { get; set; }

        [JsonProperty("net_value")]
        public string NetValue { get; set; }

        [JsonProperty("total_value")]
        public string TotalValue { get; set; }

        [JsonProperty("paid_value")]
        public string PaidValue { get; set; }

        [JsonProperty("due_value")]
        public string DueValue { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("long_status")]
        public string LongStatus { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("omit_header")]
        public bool OmitHeader { get; set; }

        [JsonProperty("always_show_bic_and_iban")]
        public bool AlwaysShowBICAndIBAN { get; set; }

        [JsonProperty("send_thank_you_emails")]
        public bool SendThankYouEmails { get; set; }

        [JsonProperty("send_reminder_emails")]
        public bool SendReminderEmails { get; set; }

        [JsonProperty("send_new_invoice_emails")]
        public bool SendNewInvoiceEmails { get; set; }

        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        [JsonProperty("payment_terms_in_days")]
        public int PaymentTermsInDays { get; set; }

        [JsonProperty("ec_status")]
        public string EcStatus { get; set; }

        [JsonProperty("payment_methods")]
        public ShowInvoiceResponseInvoiceTypePaymentMethodsType PaymentMethods { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("invoice_items")]
        public ShowInvoiceResponseInvoiceTypeInvoiceItemsTypeItem[] InvoiceItems { get; set; }
    }

    public class ShowInvoiceResponseInvoiceTypePaymentMethodsType
    {
        [JsonProperty("paypal")]
        public bool Paypal { get; set; }

        [JsonProperty("stripe")]
        public bool Stripe { get; set; }
    }

    public class ShowInvoiceResponseInvoiceTypeInvoiceItemsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }
    }

    public class bodyinvoiceinvoiceItemsInputItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("item_type")]
        public bodyinvoiceinvoiceItemsInputItemItemTypeType ItemType { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyinvoiceinvoiceItemsInputItemItemTypeType
    {
        Hours,
        Days,
        Weeks,
        Months,
        Years,
        Products,
        Services,
        Training,
        Expenses,
        Comment,
        Bills,
        Discount,
        Credit,
        VAT,
        Stock
    }

    public class GetContactsResponse
    {
        [JsonProperty("contacts")]
        public GetContactsResponseContactsTypeItem[] Contacts { get; set; }
    }

    public class GetContactsResponseContactsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("organisation_name")]
        public string OrganisationName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("billing_email")]
        public string BillingEmail { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("town")]
        public string Town { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("contact_name_on_invoices")]
        public bool ContactNameOnInvoices { get; set; }

        [JsonProperty("default_payment_terms_in_days")]
        public int DefaultPaymentTermsInDays { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("account_balance")]
        public string AccountBalance { get; set; }

        [JsonProperty("uses_contact_invoice_sequence")]
        public bool UsesContactInvoiceSequence { get; set; }

        [JsonProperty("charge_sales_tax")]
        public string ChargeSalesTax { get; set; }

        [JsonProperty("sales_tax_registration_number")]
        public string SalesTaxRegistrationNumber { get; set; }

        [JsonProperty("active_projects_count")]
        public int ActiveProjectsCount { get; set; }

        [JsonProperty("direct_debit_mandate_state")]
        public string DirectDebitMandateState { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class CreateContactResponse
    {
        [JsonProperty("contact")]
        public CreateContactResponseContactType Contact { get; set; }
    }

    public class CreateContactResponseContactType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("organisation_name")]
        public string OrganisationName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("billing_email")]
        public string BillingEmail { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("address3")]
        public string Address3 { get; set; }

        [JsonProperty("town")]
        public string Town { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("contact_name_on_invoices")]
        public bool ContactNameOnInvoices { get; set; }

        [JsonProperty("default_payment_terms_in_days")]
        public int DefaultPaymentTermsInDays { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("account_balance")]
        public string AccountBalance { get; set; }

        [JsonProperty("uses_contact_invoice_sequence")]
        public bool UsesContactInvoiceSequence { get; set; }

        [JsonProperty("charge_sales_tax")]
        public string ChargeSalesTax { get; set; }

        [JsonProperty("sales_tax_registration_number")]
        public string SalesTaxRegistrationNumber { get; set; }

        [JsonProperty("active_projects_count")]
        public int ActiveProjectsCount { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ListAllRecurringInvoicesResponse
    {
        [JsonProperty("recurring_invoices")]
        public ListAllRecurringInvoicesResponseRecurringInvoicesTypeItem[] RecurringInvoices { get; set; }
    }

    public class ListAllRecurringInvoicesResponseRecurringInvoicesTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("dated_on")]
        public string DatedOn { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("next_recurs_on")]
        public string NextRecursOn { get; set; }

        [JsonProperty("recurring_end_date")]
        public string RecurringEndDate { get; set; }

        [JsonProperty("recurring_status")]
        public string RecurringStatus { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("exchange_rate")]
        public string ExchangeRate { get; set; }

        [JsonProperty("net_value")]
        public string NetValue { get; set; }

        [JsonProperty("sales_tax_value")]
        public string SalesTaxValue { get; set; }

        [JsonProperty("total_value")]
        public string TotalValue { get; set; }

        [JsonProperty("omit_header")]
        public bool OmitHeader { get; set; }

        [JsonProperty("always_show_bic_and_iban")]
        public bool AlwaysShowBICAndIBAN { get; set; }

        [JsonProperty("payment_terms_in_days")]
        public int PaymentTermsInDays { get; set; }
    }

    public class ListInvoicesResponse
    {
        [JsonProperty("invoices")]
        public ListInvoicesResponseInvoicesTypeItem[] Invoices { get; set; }
    }

    public class ListInvoicesResponseInvoicesTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("dated_on")]
        public string DatedOn { get; set; }

        [JsonProperty("due_on")]
        public string DueOn { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("exchange_rate")]
        public string ExchangeRate { get; set; }

        [JsonProperty("net_value")]
        public string NetValue { get; set; }

        [JsonProperty("sales_tax_value")]
        public string SalesTaxValue { get; set; }

        [JsonProperty("total_value")]
        public string TotalValue { get; set; }

        [JsonProperty("paid_value")]
        public string PaidValue { get; set; }

        [JsonProperty("due_value")]
        public string DueValue { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("long_status")]
        public string LongStatus { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("omit_header")]
        public bool OmitHeader { get; set; }

        [JsonProperty("send_thank_you_emails")]
        public bool SendThankYouEmails { get; set; }

        [JsonProperty("send_reminder_emails")]
        public bool SendReminderEmails { get; set; }

        [JsonProperty("send_new_invoice_emails")]
        public bool SendNewInvoiceEmails { get; set; }

        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        [JsonProperty("always_show_bic_and_iban")]
        public bool AlwaysShowBICAndIBAN { get; set; }

        [JsonProperty("payment_terms_in_days")]
        public int PaymentTermsInDays { get; set; }

        [JsonProperty("ec_status")]
        public string EcStatus { get; set; }

        [JsonProperty("payment_methods")]
        public ListInvoicesResponseInvoicesTypeItemPaymentMethodsType PaymentMethods { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class ListInvoicesResponseInvoicesTypeItemPaymentMethodsType
    {
        [JsonProperty("paypal")]
        public bool Paypal { get; set; }

        [JsonProperty("stripe")]
        public bool Stripe { get; set; }
    }

    public class CreateInvoiceResponse
    {
        [JsonProperty("invoice")]
        public CreateInvoiceResponseInvoiceType Invoice { get; set; }
    }

    public class CreateInvoiceResponseInvoiceType
    {
        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("dated_on")]
        public string DatedOn { get; set; }

        [JsonProperty("due_on")]
        public string DueOn { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("exchange_rate")]
        public string ExchangeRate { get; set; }

        [JsonProperty("net_value")]
        public string NetValue { get; set; }

        [JsonProperty("total_value")]
        public string TotalValue { get; set; }

        [JsonProperty("paid_value")]
        public string PaidValue { get; set; }

        [JsonProperty("due_value")]
        public string DueValue { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("long_status")]
        public string LongStatus { get; set; }

        [JsonProperty("omit_header")]
        public bool OmitHeader { get; set; }

        [JsonProperty("always_show_bic_and_iban")]
        public bool AlwaysShowBICAndIBAN { get; set; }

        [JsonProperty("send_thank_you_emails")]
        public bool SendThankYouEmails { get; set; }

        [JsonProperty("send_reminder_emails")]
        public bool SendReminderEmails { get; set; }

        [JsonProperty("send_new_invoice_emails")]
        public bool SendNewInvoiceEmails { get; set; }

        [JsonProperty("bank_account")]
        public string BankAccount { get; set; }

        [JsonProperty("payment_terms_in_days")]
        public int PaymentTermsInDays { get; set; }

        [JsonProperty("payment_methods")]
        public CreateInvoiceResponseInvoiceTypePaymentMethodsType PaymentMethods { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("invoice_items")]
        public CreateInvoiceResponseInvoiceTypeInvoiceItemsTypeItem[] InvoiceItems { get; set; }
    }

    public class CreateInvoiceResponseInvoiceTypePaymentMethodsType
    {
        [JsonProperty("paypal")]
        public bool Paypal { get; set; }

        [JsonProperty("stripe")]
        public bool Stripe { get; set; }
    }

    public class CreateInvoiceResponseInvoiceTypeInvoiceItemsTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }
    }

    public class ShowRecurringInvoiceResponse
    {
        [JsonProperty("recurring_invoice")]
        public ShowRecurringInvoiceResponseRecurringInvoiceType RecurringInvoice { get; set; }
    }

    public class ShowRecurringInvoiceResponseRecurringInvoiceType
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("contact")]
        public string Contact { get; set; }

        [JsonProperty("dated_on")]
        public string DatedOn { get; set; }

        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("next_recurs_on")]
        public string NextRecursOn { get; set; }

        [JsonProperty("recurring_end_date")]
        public string RecurringEndDate { get; set; }

        [JsonProperty("recurring_status")]
        public string RecurringStatus { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("exchange_rate")]
        public string ExchangeRate { get; set; }

        [JsonProperty("net_value")]
        public string NetValue { get; set; }

        [JsonProperty("sales_tax_value")]
        public string SalesTaxValue { get; set; }

        [JsonProperty("total_value")]
        public string TotalValue { get; set; }

        [JsonProperty("omit_header")]
        public bool OmitHeader { get; set; }

        [JsonProperty("always_show_bic_and_iban")]
        public bool AlwaysShowBICAndIBAN { get; set; }

        [JsonProperty("payment_terms_in_days")]
        public int PaymentTermsInDays { get; set; }

        [JsonProperty("invoice_items")]
        public ShowRecurringInvoiceResponseRecurringInvoiceTypeInvoiceItemsTypeItem[] InvoiceItems { get; set; }
    }

    public class ShowRecurringInvoiceResponseRecurringInvoiceTypeInvoiceItemsTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("item_type")]
        public string ItemType { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("sales_tax_rate")]
        public string SalesTaxRate { get; set; }

        [JsonProperty("sales_tax_status")]
        public string SalesTaxStatus { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Freeagentip;

    public partial class WorkflowManagedActions
    {
        public FreeagentipActions Freeagentip(string connectionId) => new FreeagentipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FreeagentipTriggers Freeagentip(string connectionId) => new FreeagentipTriggers(connectionId);
    }
}
