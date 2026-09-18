//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Freeagentip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FreeagentipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction DeleteContact([WorkflowExpression] Func<string> contactId)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<GetContactResponse> GetContact([WorkflowExpression] Func<string> contactId)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction UpdateContact([WorkflowExpression] Func<string> contactId, [WorkflowExpression] Func<bool> bodycontactcontactNameOnInvoices = null, [WorkflowExpression] Func<int> bodycontactdefaultPaymentTermsInDays = null, [WorkflowExpression] Func<string> bodycontactlocale = null, [WorkflowExpression] Func<string> bodycontactcountry = null)
        {
            SourceExpression.Validate(contactId, nameof(contactId), required: true);
            SourceExpression.Validate(bodycontactcontactNameOnInvoices, nameof(bodycontactcontactNameOnInvoices), required: false);
            SourceExpression.Validate(bodycontactdefaultPaymentTermsInDays, nameof(bodycontactdefaultPaymentTermsInDays), required: false);
            SourceExpression.Validate(bodycontactlocale, nameof(bodycontactlocale), required: false);
            SourceExpression.Validate(bodycontactcountry, nameof(bodycontactcountry), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/contacts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contactId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                if (bodycontactcontactNameOnInvoices != null)
                {
                    contactObject["contact_name_on_invoices"] = SourceExpressionConverter.ConvertToken(bodycontactcontactNameOnInvoices);
                    contactObjectpropCount++;
                }

                if (bodycontactdefaultPaymentTermsInDays != null)
                {
                    contactObject["default_payment_terms_in_days"] = SourceExpressionConverter.ConvertToken(bodycontactdefaultPaymentTermsInDays);
                    contactObjectpropCount++;
                }

                if (bodycontactlocale != null)
                {
                    contactObject["locale"] = SourceExpressionConverter.ConvertToken(bodycontactlocale);
                    contactObjectpropCount++;
                }

                if (bodycontactcountry != null)
                {
                    contactObject["country"] = SourceExpressionConverter.ConvertToken(bodycontactcountry);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction DeleteInvoice([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoices/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<ShowInvoiceResponse> ShowInvoice([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoices/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ShowInvoiceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction UpdateInvoice([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyinvoicedatedOn = null, [WorkflowExpression] Func<string> bodyinvoicedueOn = null, [WorkflowExpression] Func<string> bodyinvoicecurrency = null, [WorkflowExpression] Func<string> bodyinvoiceexchangeRate = null, [WorkflowExpression] Func<string> bodyinvoicestatus = null, [WorkflowExpression] Func<bodyinvoiceinvoiceItemsInputItem[]> bodyinvoiceinvoiceItems = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyinvoicedatedOn, nameof(bodyinvoicedatedOn), required: false);
            SourceExpression.Validate(bodyinvoicedueOn, nameof(bodyinvoicedueOn), required: false);
            SourceExpression.Validate(bodyinvoicecurrency, nameof(bodyinvoicecurrency), required: false);
            SourceExpression.Validate(bodyinvoiceexchangeRate, nameof(bodyinvoiceexchangeRate), required: false);
            SourceExpression.Validate(bodyinvoicestatus, nameof(bodyinvoicestatus), required: false);
            SourceExpression.Validate(bodyinvoiceinvoiceItems, nameof(bodyinvoiceinvoiceItems), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoices/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var invoiceObject = new JObject();
                var invoiceObjectpropCount = 0;
                if (bodyinvoicedatedOn != null)
                {
                    invoiceObject["dated_on"] = SourceExpressionConverter.ConvertToken(bodyinvoicedatedOn);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicedueOn != null)
                {
                    invoiceObject["due_on"] = SourceExpressionConverter.ConvertToken(bodyinvoicedueOn);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicecurrency != null)
                {
                    invoiceObject["currency"] = SourceExpressionConverter.ConvertToken(bodyinvoicecurrency);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoiceexchangeRate != null)
                {
                    invoiceObject["exchange_rate"] = SourceExpressionConverter.ConvertToken(bodyinvoiceexchangeRate);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicestatus != null)
                {
                    invoiceObject["status"] = SourceExpressionConverter.ConvertToken(bodyinvoicestatus);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoiceinvoiceItems != null)
                {
                    invoiceObject["invoice_items"] = SourceExpressionConverter.ConvertToken(bodyinvoiceinvoiceItems);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<GetContactsResponse> GetContacts()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<CreateContactResponse> CreateContact([WorkflowExpression] Func<string> bodycontactfirstName = null, [WorkflowExpression] Func<string> bodycontactlastName = null, [WorkflowExpression] Func<string> bodycontactorganisationName = null, [WorkflowExpression] Func<string> bodycontactemail = null, [WorkflowExpression] Func<string> bodycontacttelephone = null, [WorkflowExpression] Func<string> bodycontactmobile = null, [WorkflowExpression] Func<string> bodycontactaddress1 = null, [WorkflowExpression] Func<string> bodycontactaddress2 = null, [WorkflowExpression] Func<string> bodycontactaddress3 = null, [WorkflowExpression] Func<string> bodycontacttown = null, [WorkflowExpression] Func<string> bodycontactregion = null, [WorkflowExpression] Func<string> bodycontactpostcode = null, [WorkflowExpression] Func<string> bodycontactcountry = null)
        {
            SourceExpression.Validate(bodycontactfirstName, nameof(bodycontactfirstName), required: false);
            SourceExpression.Validate(bodycontactlastName, nameof(bodycontactlastName), required: false);
            SourceExpression.Validate(bodycontactorganisationName, nameof(bodycontactorganisationName), required: false);
            SourceExpression.Validate(bodycontactemail, nameof(bodycontactemail), required: false);
            SourceExpression.Validate(bodycontacttelephone, nameof(bodycontacttelephone), required: false);
            SourceExpression.Validate(bodycontactmobile, nameof(bodycontactmobile), required: false);
            SourceExpression.Validate(bodycontactaddress1, nameof(bodycontactaddress1), required: false);
            SourceExpression.Validate(bodycontactaddress2, nameof(bodycontactaddress2), required: false);
            SourceExpression.Validate(bodycontactaddress3, nameof(bodycontactaddress3), required: false);
            SourceExpression.Validate(bodycontacttown, nameof(bodycontacttown), required: false);
            SourceExpression.Validate(bodycontactregion, nameof(bodycontactregion), required: false);
            SourceExpression.Validate(bodycontactpostcode, nameof(bodycontactpostcode), required: false);
            SourceExpression.Validate(bodycontactcountry, nameof(bodycontactcountry), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                if (bodycontactfirstName != null)
                {
                    contactObject["first_name"] = SourceExpressionConverter.ConvertToken(bodycontactfirstName);
                    contactObjectpropCount++;
                }

                if (bodycontactlastName != null)
                {
                    contactObject["last_name"] = SourceExpressionConverter.ConvertToken(bodycontactlastName);
                    contactObjectpropCount++;
                }

                if (bodycontactorganisationName != null)
                {
                    contactObject["organisation_name"] = SourceExpressionConverter.ConvertToken(bodycontactorganisationName);
                    contactObjectpropCount++;
                }

                if (bodycontactemail != null)
                {
                    contactObject["email"] = SourceExpressionConverter.ConvertToken(bodycontactemail);
                    contactObjectpropCount++;
                }

                if (bodycontacttelephone != null)
                {
                    contactObject["phone_number"] = SourceExpressionConverter.ConvertToken(bodycontacttelephone);
                    contactObjectpropCount++;
                }

                if (bodycontactmobile != null)
                {
                    contactObject["mobile"] = SourceExpressionConverter.ConvertToken(bodycontactmobile);
                    contactObjectpropCount++;
                }

                if (bodycontactaddress1 != null)
                {
                    contactObject["address1"] = SourceExpressionConverter.ConvertToken(bodycontactaddress1);
                    contactObjectpropCount++;
                }

                if (bodycontactaddress2 != null)
                {
                    contactObject["address2"] = SourceExpressionConverter.ConvertToken(bodycontactaddress2);
                    contactObjectpropCount++;
                }

                if (bodycontactaddress3 != null)
                {
                    contactObject["address3"] = SourceExpressionConverter.ConvertToken(bodycontactaddress3);
                    contactObjectpropCount++;
                }

                if (bodycontacttown != null)
                {
                    contactObject["town"] = SourceExpressionConverter.ConvertToken(bodycontacttown);
                    contactObjectpropCount++;
                }

                if (bodycontactregion != null)
                {
                    contactObject["region"] = SourceExpressionConverter.ConvertToken(bodycontactregion);
                    contactObjectpropCount++;
                }

                if (bodycontactpostcode != null)
                {
                    contactObject["postcode"] = SourceExpressionConverter.ConvertToken(bodycontactpostcode);
                    contactObjectpropCount++;
                }

                if (bodycontactcountry != null)
                {
                    contactObject["country"] = SourceExpressionConverter.ConvertToken(bodycontactcountry);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<ListAllRecurringInvoicesResponse> ListAllRecurringInvoices()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/recurring_invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListAllRecurringInvoicesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<ListInvoicesResponse> ListInvoices()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListInvoicesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<CreateInvoiceResponse> CreateInvoice([WorkflowExpression] Func<string> bodyinvoicecontact = null, [WorkflowExpression] Func<string> bodyinvoicedatedOn = null, [WorkflowExpression] Func<string> bodyinvoicedueOn = null, [WorkflowExpression] Func<string> bodyinvoicecurrency = null, [WorkflowExpression] Func<bool> bodyinvoiceomitHeader = null, [WorkflowExpression] Func<bool> bodyinvoicealwaysShowBICAndIBAN = null, [WorkflowExpression] Func<int> bodyinvoicepaymentTermsInDays = null)
        {
            SourceExpression.Validate(bodyinvoicecontact, nameof(bodyinvoicecontact), required: false);
            SourceExpression.Validate(bodyinvoicedatedOn, nameof(bodyinvoicedatedOn), required: false);
            SourceExpression.Validate(bodyinvoicedueOn, nameof(bodyinvoicedueOn), required: false);
            SourceExpression.Validate(bodyinvoicecurrency, nameof(bodyinvoicecurrency), required: false);
            SourceExpression.Validate(bodyinvoiceomitHeader, nameof(bodyinvoiceomitHeader), required: false);
            SourceExpression.Validate(bodyinvoicealwaysShowBICAndIBAN, nameof(bodyinvoicealwaysShowBICAndIBAN), required: false);
            SourceExpression.Validate(bodyinvoicepaymentTermsInDays, nameof(bodyinvoicepaymentTermsInDays), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/invoices";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var invoiceObject = new JObject();
                var invoiceObjectpropCount = 0;
                if (bodyinvoicecontact != null)
                {
                    invoiceObject["contact"] = SourceExpressionConverter.ConvertToken(bodyinvoicecontact);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicedatedOn != null)
                {
                    invoiceObject["dated_on"] = SourceExpressionConverter.ConvertToken(bodyinvoicedatedOn);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicedueOn != null)
                {
                    invoiceObject["due_on"] = SourceExpressionConverter.ConvertToken(bodyinvoicedueOn);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicecurrency != null)
                {
                    invoiceObject["currency"] = SourceExpressionConverter.ConvertToken(bodyinvoicecurrency);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoiceomitHeader != null)
                {
                    invoiceObject["omit_header"] = SourceExpressionConverter.ConvertToken(bodyinvoiceomitHeader);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicealwaysShowBICAndIBAN != null)
                {
                    invoiceObject["always_show_bic_and_iban"] = SourceExpressionConverter.ConvertToken(bodyinvoicealwaysShowBICAndIBAN);
                    invoiceObjectpropCount++;
                }

                if (bodyinvoicepaymentTermsInDays != null)
                {
                    invoiceObject["payment_terms_in_days"] = SourceExpressionConverter.ConvertToken(bodyinvoicepaymentTermsInDays);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateInvoiceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IBodyWorkflowAction<ShowRecurringInvoiceResponse> ShowRecurringInvoice([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/recurring_invoices/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ShowRecurringInvoiceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction MarkInvoiceAsCancelled([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoices/{0}/transitions/mark_as_cancelled", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction MarkInvoiceAsDraft([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoices/{0}/transitions/mark_as_draft", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction MarkInvoiceAsScheduled([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoices/{0}/transitions/mark_as_scheduled", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freeagentip")]
        public IWorkflowAction MarkInvoiceAsSent([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/invoices/{0}/transitions/mark_as_sent", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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