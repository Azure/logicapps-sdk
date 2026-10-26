//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Surexerolite
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SurexeroliteActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<GetStartedResponseItem[], ApiConnectionActionConfiguration> GetStarted()
        {
            return new DeferredBodyAction<GetStartedResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetStartedResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<GetInvoicesResponse, ApiConnectionActionConfiguration> GetInvoices(Expression<Func<string>> xeroTenantId, Expression<Func<string>> where = null, Expression<Func<string>> statuses = null, Expression<Func<string>> iDs = null, Expression<Func<string>> invoiceNumbers = null, Expression<Func<string>> contactIDs = null, Expression<Func<bool>> summaryOnly = null, Expression<Func<int>> page = null)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_where = WorkflowExpression.Compile(where, nameof(where), required: false);
            var __workflow_statuses = WorkflowExpression.Compile(statuses, nameof(statuses), required: false);
            var __workflow_iDs = WorkflowExpression.Compile(iDs, nameof(iDs), required: false);
            var __workflow_invoiceNumbers = WorkflowExpression.Compile(invoiceNumbers, nameof(invoiceNumbers), required: false);
            var __workflow_contactIDs = WorkflowExpression.Compile(contactIDs, nameof(contactIDs), required: false);
            var __workflow_summaryOnly = WorkflowExpression.Compile(summaryOnly, nameof(summaryOnly), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<GetInvoicesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api.xro/2.0/Invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_where != null)
                    callPayload.Queries["where"] = ExpressionConverter.Convert(__workflow_where);
                if (__workflow_statuses != null)
                    callPayload.Queries["Statuses"] = ExpressionConverter.Convert(__workflow_statuses);
                if (__workflow_iDs != null)
                    callPayload.Queries["IDs"] = ExpressionConverter.Convert(__workflow_iDs);
                if (__workflow_invoiceNumbers != null)
                    callPayload.Queries["InvoiceNumbers"] = ExpressionConverter.Convert(__workflow_invoiceNumbers);
                if (__workflow_contactIDs != null)
                    callPayload.Queries["ContactIDs"] = ExpressionConverter.Convert(__workflow_contactIDs);
                if (__workflow_summaryOnly != null)
                    callPayload.Queries["summaryOnly"] = ExpressionConverter.Convert(__workflow_summaryOnly);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(__workflow_xeroTenantId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction<GetInvoicesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<PostInvoiceResponse, ApiConnectionActionConfiguration> PostInvoice(Expression<Func<string>> xeroTenantId, Expression<Func<PostInvoiceInput>> body)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<PostInvoiceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api.xro/2.0/Invoices";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(__workflow_xeroTenantId);
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostInvoiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<GetContactsResponse, ApiConnectionActionConfiguration> GetContacts(Expression<Func<string>> xeroTenantId, Expression<Func<string>> where = null, Expression<Func<string>> iDs = null, Expression<Func<bool>> summaryOnly = null, Expression<Func<int>> page = null, Expression<Func<bool>> includeArchived = null, Expression<Func<string>> searchTerm = null)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_where = WorkflowExpression.Compile(where, nameof(where), required: false);
            var __workflow_iDs = WorkflowExpression.Compile(iDs, nameof(iDs), required: false);
            var __workflow_summaryOnly = WorkflowExpression.Compile(summaryOnly, nameof(summaryOnly), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_includeArchived = WorkflowExpression.Compile(includeArchived, nameof(includeArchived), required: false);
            var __workflow_searchTerm = WorkflowExpression.Compile(searchTerm, nameof(searchTerm), required: false);
            return new DeferredBodyAction<GetContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api.xro/2.0/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_where != null)
                    callPayload.Queries["where"] = ExpressionConverter.Convert(__workflow_where);
                if (__workflow_iDs != null)
                    callPayload.Queries["IDs"] = ExpressionConverter.Convert(__workflow_iDs);
                if (__workflow_summaryOnly != null)
                    callPayload.Queries["summaryOnly"] = ExpressionConverter.Convert(__workflow_summaryOnly);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_includeArchived != null)
                    callPayload.Queries["includeArchived"] = ExpressionConverter.Convert(__workflow_includeArchived);
                if (__workflow_searchTerm != null)
                    callPayload.Queries["searchTerm"] = ExpressionConverter.Convert(__workflow_searchTerm);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(__workflow_xeroTenantId);
                return new ApiConnectionAction<GetContactsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<PostContactsResponse, ApiConnectionActionConfiguration> PostContacts(Expression<Func<string>> xeroTenantId, Expression<Func<PostContactsInput>> body = null)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostContactsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api.xro/2.0/Contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(__workflow_xeroTenantId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

        [JsonProperty("InvoiceID")]
        public string InvoiceId { get; set; }
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
        [JsonProperty("ContactID")]
        public string ContactId { get; set; }
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

        [JsonProperty("LineItemID")]
        public string LineItemId { get; set; }
    }

    public class GetInvoicesResponseInvoicesTypeItemPaymentsTypeItem
    {
        [JsonProperty("BatchPaymentID")]
        public string BatchPaymentId { get; set; }

        [JsonProperty("PaymentID")]
        public string PaymentId { get; set; }
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

        [JsonProperty("InvoiceID")]
        public string InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public double AmountDue { get; set; }
        public double AmountPaid { get; set; }
        public double AmountCredited { get; set; }
        public double CurrencyRate { get; set; }
    }

    public class PostInvoiceResponseInvoicesTypeItemContactType
    {
        [JsonProperty("ContactID")]
        public string ContactId { get; set; }
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

        [JsonProperty("LineItemID")]
        public string LineItemId { get; set; }
    }

    public class PostInvoiceInput
    {
        public string Date { get; set; }
        public string DueDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Type { get; set; } = "ACCREC";
        public string Reference { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public PostInvoiceInputContactType Contact { get; set; }
        public string LineAmountTypes { get; set; }
        public string InvoiceNumber { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public PostInvoiceInputLineItemsTypeItem[] LineItems { get; set; }
        public string CurrencyCode { get; set; }
        public double? CurrencyRate { get; set; }
        public string Status { get; set; }
        public string ExpectedPaymentDate { get; set; }
    }

    public class PostInvoiceInputContactType
    {
        [JsonProperty("ContactID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContactId { get; set; }
    }

    public class PostInvoiceInputLineItemsTypeItem
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double Quantity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double UnitAmount { get; set; }
        public string AccountCode { get; set; }
        public double? DiscountRate { get; set; }
    }

    public class GetContactsResponse
    {
        public GetContactsResponseContactsTypeItem[] Contacts { get; set; }
    }

    public class GetContactsResponseContactsTypeItem
    {
        [JsonProperty("ContactID")]
        public string ContactId { get; set; }
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
        [JsonProperty("ContactID")]
        public string ContactId { get; set; }
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

    public class PostContactsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public PostContactsInputContactsTypeItem[] Contacts { get; set; }
    }

    public class PostContactsInputContactsTypeItem
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
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