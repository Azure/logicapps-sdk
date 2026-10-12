//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Surexerolite
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SurexeroliteActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<GetStartedResponseItem[]> GetStarted()
        {
            var apiCallPath = "/connections";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetStartedResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        [WorkflowExpressionFactory(nameof(__BuildGetInvoices))]
        public IBodyWorkflowAction<GetInvoicesResponse> GetInvoices([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> where = null, [WorkflowExpression] Func<string> statuses = null, [WorkflowExpression] Func<string> iDs = null, [WorkflowExpression] Func<string> invoiceNumbers = null, [WorkflowExpression] Func<string> contactIDs = null, [WorkflowExpression] Func<bool> summaryOnly = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetInvoicesResponse> __BuildGetInvoices(WorkflowExpression<string> xeroTenantId, WorkflowExpression<string> where = null, WorkflowExpression<string> statuses = null, WorkflowExpression<string> iDs = null, WorkflowExpression<string> invoiceNumbers = null, WorkflowExpression<string> contactIDs = null, WorkflowExpression<bool> summaryOnly = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            WorkflowExpression.Validate(where, nameof(where), required: false);
            WorkflowExpression.Validate(statuses, nameof(statuses), required: false);
            WorkflowExpression.Validate(iDs, nameof(iDs), required: false);
            WorkflowExpression.Validate(invoiceNumbers, nameof(invoiceNumbers), required: false);
            WorkflowExpression.Validate(contactIDs, nameof(contactIDs), required: false);
            WorkflowExpression.Validate(summaryOnly, nameof(summaryOnly), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<GetInvoicesResponse>(() =>
            {
                var apiCallPath = "/api.xro/2.0/Invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (where != null)
                    callPayload.Queries["where"] = ExpressionConverter.Convert(where);
                if (statuses != null)
                    callPayload.Queries["Statuses"] = ExpressionConverter.Convert(statuses);
                if (iDs != null)
                    callPayload.Queries["IDs"] = ExpressionConverter.Convert(iDs);
                if (invoiceNumbers != null)
                    callPayload.Queries["InvoiceNumbers"] = ExpressionConverter.Convert(invoiceNumbers);
                if (contactIDs != null)
                    callPayload.Queries["ContactIDs"] = ExpressionConverter.Convert(contactIDs);
                if (summaryOnly != null)
                    callPayload.Queries["summaryOnly"] = ExpressionConverter.Convert(summaryOnly);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetInvoicesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        [WorkflowExpressionFactory(nameof(__BuildPostInvoice))]
        public IBodyWorkflowAction<PostInvoiceResponse> PostInvoice([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<bodylineItemsInputItem[]> bodylineItems, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodyreference = null, [WorkflowExpression] Func<string> bodycontactcontactID = null, [WorkflowExpression] Func<string> bodylineAmountTypes = null, [WorkflowExpression] Func<string> bodyinvoiceNumber = null, [WorkflowExpression] Func<string> bodycurrencyCode = null, [WorkflowExpression] Func<double> bodycurrencyRate = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyexpectedPaymentDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostInvoiceResponse> __BuildPostInvoice(WorkflowExpression<string> xeroTenantId, WorkflowExpression<string> bodytype, WorkflowExpression<bodylineItemsInputItem[]> bodylineItems, WorkflowExpression<string> bodydate = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<string> bodyreference = null, WorkflowExpression<string> bodycontactcontactID = null, WorkflowExpression<string> bodylineAmountTypes = null, WorkflowExpression<string> bodyinvoiceNumber = null, WorkflowExpression<string> bodycurrencyCode = null, WorkflowExpression<double> bodycurrencyRate = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyexpectedPaymentDate = null)
        {
            WorkflowExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodylineItems, nameof(bodylineItems), required: true);
            WorkflowExpression.Validate(bodydate, nameof(bodydate), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodyreference, nameof(bodyreference), required: false);
            WorkflowExpression.Validate(bodycontactcontactID, nameof(bodycontactcontactID), required: false);
            WorkflowExpression.Validate(bodylineAmountTypes, nameof(bodylineAmountTypes), required: false);
            WorkflowExpression.Validate(bodyinvoiceNumber, nameof(bodyinvoiceNumber), required: false);
            WorkflowExpression.Validate(bodycurrencyCode, nameof(bodycurrencyCode), required: false);
            WorkflowExpression.Validate(bodycurrencyRate, nameof(bodycurrencyRate), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyexpectedPaymentDate, nameof(bodyexpectedPaymentDate), required: false);
            return new DeferredBodyAction<PostInvoiceResponse>(() =>
            {
                var apiCallPath = "/api.xro/2.0/Invoices";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydate != null)
                {
                    body["Date"] = ExpressionConverter.ConvertO(bodydate);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["DueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Type"] = ExpressionConverter.ConvertO(bodytype);
                if (bodyreference != null)
                {
                    body["Reference"] = ExpressionConverter.ConvertO(bodyreference);
                    bodypropCount++;
                }

                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                if (bodycontactcontactID != null)
                {
                    contactObject["ContactID"] = ExpressionConverter.ConvertO(bodycontactcontactID);
                    contactObjectpropCount++;
                }

                if (contactObjectpropCount > 0)
                {
                    body["Contact"] = contactObject;
                    bodypropCount++;
                }

                if (bodylineAmountTypes != null)
                {
                    body["LineAmountTypes"] = ExpressionConverter.ConvertO(bodylineAmountTypes);
                    bodypropCount++;
                }

                if (bodyinvoiceNumber != null)
                {
                    body["InvoiceNumber"] = ExpressionConverter.ConvertO(bodyinvoiceNumber);
                    bodypropCount++;
                }

                bodypropCount++;
                body["LineItems"] = ExpressionConverter.ConvertO(bodylineItems);
                if (bodycurrencyCode != null)
                {
                    body["CurrencyCode"] = ExpressionConverter.ConvertO(bodycurrencyCode);
                    bodypropCount++;
                }

                if (bodycurrencyRate != null)
                {
                    body["CurrencyRate"] = ExpressionConverter.ConvertO(bodycurrencyRate);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyexpectedPaymentDate != null)
                {
                    body["ExpectedPaymentDate"] = ExpressionConverter.ConvertO(bodyexpectedPaymentDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostInvoiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        [WorkflowExpressionFactory(nameof(__BuildGetContacts))]
        public IBodyWorkflowAction<GetContactsResponse> GetContacts([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> where = null, [WorkflowExpression] Func<string> iDs = null, [WorkflowExpression] Func<bool> summaryOnly = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<bool> includeArchived = null, [WorkflowExpression] Func<string> searchTerm = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetContactsResponse> __BuildGetContacts(WorkflowExpression<string> xeroTenantId, WorkflowExpression<string> where = null, WorkflowExpression<string> iDs = null, WorkflowExpression<bool> summaryOnly = null, WorkflowExpression<int> page = null, WorkflowExpression<bool> includeArchived = null, WorkflowExpression<string> searchTerm = null)
        {
            WorkflowExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            WorkflowExpression.Validate(where, nameof(where), required: false);
            WorkflowExpression.Validate(iDs, nameof(iDs), required: false);
            WorkflowExpression.Validate(summaryOnly, nameof(summaryOnly), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(includeArchived, nameof(includeArchived), required: false);
            WorkflowExpression.Validate(searchTerm, nameof(searchTerm), required: false);
            return new DeferredBodyAction<GetContactsResponse>(() =>
            {
                var apiCallPath = "/api.xro/2.0/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (where != null)
                    callPayload.Queries["where"] = ExpressionConverter.Convert(where);
                if (iDs != null)
                    callPayload.Queries["IDs"] = ExpressionConverter.Convert(iDs);
                if (summaryOnly != null)
                    callPayload.Queries["summaryOnly"] = ExpressionConverter.Convert(summaryOnly);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (includeArchived != null)
                    callPayload.Queries["includeArchived"] = ExpressionConverter.Convert(includeArchived);
                if (searchTerm != null)
                    callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(searchTerm);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
                return new ApiConnectionAction<GetContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        [WorkflowExpressionFactory(nameof(__BuildPostContacts))]
        public IBodyWorkflowAction<PostContactsResponse> PostContacts([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<bodycontactsInputItem[]> bodycontacts)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PostContactsResponse> __BuildPostContacts(WorkflowExpression<string> xeroTenantId, WorkflowExpression<bodycontactsInputItem[]> bodycontacts)
        {
            WorkflowExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            WorkflowExpression.Validate(bodycontacts, nameof(bodycontacts), required: true);
            return new DeferredBodyAction<PostContactsResponse>(() =>
            {
                var apiCallPath = "/api.xro/2.0/Contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(xeroTenantId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Contacts"] = ExpressionConverter.ConvertO(bodycontacts);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostContactsResponse>(callPayload);
            });
        }
    }

    public class SurexeroliteTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetStartedResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("authEventId")]
        public string AuthEventId { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("tenantType")]
        public string TenantType { get; set; }

        [JsonProperty("tenantName")]
        public string TenantName { get; set; }

        [JsonProperty("createdDateUtc")]
        public string CreatedDateUtc { get; set; }

        [JsonProperty("updatedDateUtc")]
        public string UpdatedDateUtc { get; set; }
    }

    public class GetInvoicesResponse
    {
        public GetInvoicesResponseInvoicesTypeItem[] Invoices { get; set; }
    }

    public class GetInvoicesResponseInvoicesTypeItem
    {
        public GetInvoicesResponseInvoicesTypeItemContactType Contact { get; set; }
        public string Date { get; set; }
        public string DueDate { get; set; }
        public string Status { get; set; }
        public string LineAmountTypes { get; set; }
        public GetInvoicesResponseInvoicesTypeItemLineItemsTypeItem[] LineItems { get; set; }
        public double SubTotal { get; set; }
        public double TotalTax { get; set; }
        public double Total { get; set; }
        public string UpdatedDateUTC { get; set; }
        public string CurrencyCode { get; set; }
        public string Type { get; set; }
        public string InvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public double AmountDue { get; set; }
        public double AmountPaid { get; set; }
        public double AmountCredited { get; set; }
        public double CurrencyRate { get; set; }
        public string FullyPaidOnDate { get; set; }
        public GetInvoicesResponseInvoicesTypeItemPaymentsTypeItem[] Payments { get; set; }
    }

    public class GetInvoicesResponseInvoicesTypeItemContactType
    {
        public string ContactID { get; set; }
        public string Name { get; set; }
    }

    public class GetInvoicesResponseInvoicesTypeItemLineItemsTypeItem
    {
        public string Description { get; set; }
        public double UnitAmount { get; set; }
        public string TaxType { get; set; }
        public double TaxAmount { get; set; }
        public double LineAmount { get; set; }
        public string AccountCode { get; set; }
        public string AccountId { get; set; }
        public double Quantity { get; set; }
        public string LineItemID { get; set; }
    }

    public class GetInvoicesResponseInvoicesTypeItemPaymentsTypeItem
    {
        public string BatchPaymentID { get; set; }
        public string PaymentID { get; set; }
        public string Date { get; set; }
        public double Amount { get; set; }
        public double CurrencyRate { get; set; }
    }

    public class PostInvoiceResponse
    {
        public PostInvoiceResponseInvoicesTypeItem[] Invoices { get; set; }
    }

    public class PostInvoiceResponseInvoicesTypeItem
    {
        public PostInvoiceResponseInvoicesTypeItemContactType Contact { get; set; }
        public string Date { get; set; }
        public string DueDate { get; set; }
        public string Status { get; set; }
        public string LineAmountTypes { get; set; }
        public PostInvoiceResponseInvoicesTypeItemLineItemsTypeItem[] LineItems { get; set; }
        public double SubTotal { get; set; }
        public double TotalTax { get; set; }
        public double Total { get; set; }
        public string UpdatedDateUTC { get; set; }
        public string CurrencyCode { get; set; }
        public string Type { get; set; }
        public string InvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public double AmountDue { get; set; }
        public double AmountPaid { get; set; }
        public double AmountCredited { get; set; }
        public double CurrencyRate { get; set; }
    }

    public class PostInvoiceResponseInvoicesTypeItemContactType
    {
        public string ContactID { get; set; }
        public string Name { get; set; }
    }

    public class PostInvoiceResponseInvoicesTypeItemLineItemsTypeItem
    {
        public string Description { get; set; }
        public double UnitAmount { get; set; }
        public string TaxType { get; set; }
        public double TaxAmount { get; set; }
        public double LineAmount { get; set; }
        public string AccountCode { get; set; }
        public string AccountId { get; set; }
        public double Quantity { get; set; }
        public string LineItemID { get; set; }
    }

    public class bodylineItemsInputItem
    {
        public string Description { get; set; }
        public double Quantity { get; set; }
        public double UnitAmount { get; set; }
        public string AccountCode { get; set; }
        public double DiscountRate { get; set; }
    }

    public class GetContactsResponse
    {
        public GetContactsResponseContactsTypeItem[] Contacts { get; set; }
    }

    public class GetContactsResponseContactsTypeItem
    {
        public string ContactID { get; set; }
        public string ContactNumber { get; set; }
        public string ContactStatus { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string BankAccountDetails { get; set; }
        public GetContactsResponseContactsTypeItemAddressesTypeItem[] Addresses { get; set; }
        public GetContactsResponseContactsTypeItemPhonesTypeItem[] Phones { get; set; }
        public string UpdatedDateUTC { get; set; }
        public GetContactsResponseContactsTypeItemContactPersonsTypeItem[] ContactPersons { get; set; }
    }

    public class GetContactsResponseContactsTypeItemAddressesTypeItem
    {
        public string AddressType { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string AttentionTo { get; set; }
    }

    public class GetContactsResponseContactsTypeItemPhonesTypeItem
    {
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneAreaCode { get; set; }
        public string PhoneCountryCode { get; set; }
    }

    public class GetContactsResponseContactsTypeItemContactPersonsTypeItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }

    public class PostContactsResponse
    {
        public PostContactsResponseContactsTypeItem[] Contacts { get; set; }
    }

    public class PostContactsResponseContactsTypeItem
    {
        public string ContactID { get; set; }
        public string ContactNumber { get; set; }
        public string ContactStatus { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string BankAccountDetails { get; set; }
        public PostContactsResponseContactsTypeItemAddressesTypeItem[] Addresses { get; set; }
        public PostContactsResponseContactsTypeItemPhonesTypeItem[] Phones { get; set; }
        public string UpdatedDateUTC { get; set; }
        public PostContactsResponseContactsTypeItemContactPersonsTypeItem[] ContactPersons { get; set; }
    }

    public class PostContactsResponseContactsTypeItemAddressesTypeItem
    {
        public string AddressType { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class PostContactsResponseContactsTypeItemPhonesTypeItem
    {
        public string PhoneType { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneAreaCode { get; set; }
        public string PhoneCountryCode { get; set; }
    }

    public class PostContactsResponseContactsTypeItemContactPersonsTypeItem
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }

    public class bodycontactsInputItem
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string AccountsReceivableTaxType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Surexerolite;

    public partial class WorkflowManagedActions
    {
        public SurexeroliteActions Surexerolite(string connectionId) => new SurexeroliteActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SurexeroliteTriggers Surexerolite(string connectionId) => new SurexeroliteTriggers(connectionId);
    }
}