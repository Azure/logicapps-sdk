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
        public IBodyWorkflowAction<GetStartedResponseItem[]> GetStarted()
        {
            var apiCallPath = "/connections";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetStartedResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<GetInvoicesResponse> GetInvoices(Expression<Func<string>> xeroTenantId, Expression<Func<string>> where = null, Expression<Func<string>> statuses = null, Expression<Func<string>> iDs = null, Expression<Func<string>> invoiceNumbers = null, Expression<Func<string>> contactIDs = null, Expression<Func<bool>> summaryOnly = null, Expression<Func<int>> page = null)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_where = WorkflowExpression.Compile(where, nameof(where), required: false);
            var __workflow_statuses = WorkflowExpression.Compile(statuses, nameof(statuses), required: false);
            var __workflow_iDs = WorkflowExpression.Compile(iDs, nameof(iDs), required: false);
            var __workflow_invoiceNumbers = WorkflowExpression.Compile(invoiceNumbers, nameof(invoiceNumbers), required: false);
            var __workflow_contactIDs = WorkflowExpression.Compile(contactIDs, nameof(contactIDs), required: false);
            var __workflow_summaryOnly = WorkflowExpression.Compile(summaryOnly, nameof(summaryOnly), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<GetInvoicesResponse>(() =>
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<PostInvoiceResponse> PostInvoice(Expression<Func<string>> xeroTenantId, Expression<Func<string>> bodytype, Expression<Func<bodylineItemsInputItem[]>> bodylineItems, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyreference = null, Expression<Func<string>> bodycontactcontactID = null, Expression<Func<string>> bodylineAmountTypes = null, Expression<Func<string>> bodyinvoiceNumber = null, Expression<Func<string>> bodycurrencyCode = null, Expression<Func<double>> bodycurrencyRate = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyexpectedPaymentDate = null)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodylineItems = WorkflowExpression.Compile(bodylineItems, nameof(bodylineItems), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodyreference = WorkflowExpression.Compile(bodyreference, nameof(bodyreference), required: false);
            var __workflow_bodycontactcontactID = WorkflowExpression.Compile(bodycontactcontactID, nameof(bodycontactcontactID), required: false);
            var __workflow_bodylineAmountTypes = WorkflowExpression.Compile(bodylineAmountTypes, nameof(bodylineAmountTypes), required: false);
            var __workflow_bodyinvoiceNumber = WorkflowExpression.Compile(bodyinvoiceNumber, nameof(bodyinvoiceNumber), required: false);
            var __workflow_bodycurrencyCode = WorkflowExpression.Compile(bodycurrencyCode, nameof(bodycurrencyCode), required: false);
            var __workflow_bodycurrencyRate = WorkflowExpression.Compile(bodycurrencyRate, nameof(bodycurrencyRate), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyexpectedPaymentDate = WorkflowExpression.Compile(bodyexpectedPaymentDate, nameof(bodyexpectedPaymentDate), required: false);
            return new DeferredBodyAction<PostInvoiceResponse>(() =>
            {
                var apiCallPath = "/api.xro/2.0/Invoices";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(__workflow_xeroTenantId);
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydate != null)
                {
                    body["Date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["DueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodyreference != null)
                {
                    body["Reference"] = ExpressionConverter.ConvertO(__workflow_bodyreference);
                    bodypropCount++;
                }

                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                if (__workflow_bodycontactcontactID != null)
                {
                    contactObject["ContactID"] = ExpressionConverter.ConvertO(__workflow_bodycontactcontactID);
                    contactObjectpropCount++;
                }

                if (contactObjectpropCount > 0)
                {
                    body["Contact"] = contactObject;
                    bodypropCount++;
                }

                if (__workflow_bodylineAmountTypes != null)
                {
                    body["LineAmountTypes"] = ExpressionConverter.ConvertO(__workflow_bodylineAmountTypes);
                    bodypropCount++;
                }

                if (__workflow_bodyinvoiceNumber != null)
                {
                    body["InvoiceNumber"] = ExpressionConverter.ConvertO(__workflow_bodyinvoiceNumber);
                    bodypropCount++;
                }

                bodypropCount++;
                body["LineItems"] = ExpressionConverter.ConvertO(__workflow_bodylineItems);
                if (__workflow_bodycurrencyCode != null)
                {
                    body["CurrencyCode"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyCode);
                    bodypropCount++;
                }

                if (__workflow_bodycurrencyRate != null)
                {
                    body["CurrencyRate"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyRate);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedPaymentDate != null)
                {
                    body["ExpectedPaymentDate"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedPaymentDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostInvoiceResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<GetContactsResponse> GetContacts(Expression<Func<string>> xeroTenantId, Expression<Func<string>> where = null, Expression<Func<string>> iDs = null, Expression<Func<bool>> summaryOnly = null, Expression<Func<int>> page = null, Expression<Func<bool>> includeArchived = null, Expression<Func<string>> searchTerm = null)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_where = WorkflowExpression.Compile(where, nameof(where), required: false);
            var __workflow_iDs = WorkflowExpression.Compile(iDs, nameof(iDs), required: false);
            var __workflow_summaryOnly = WorkflowExpression.Compile(summaryOnly, nameof(summaryOnly), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_includeArchived = WorkflowExpression.Compile(includeArchived, nameof(includeArchived), required: false);
            var __workflow_searchTerm = WorkflowExpression.Compile(searchTerm, nameof(searchTerm), required: false);
            return new DeferredBodyAction<GetContactsResponse>(() =>
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<PostContactsResponse> PostContacts(Expression<Func<string>> xeroTenantId, Expression<Func<bodycontactsInputItem[]>> bodycontacts)
        {
            var __workflow_xeroTenantId = WorkflowExpression.Compile(xeroTenantId, nameof(xeroTenantId), required: true);
            var __workflow_bodycontacts = WorkflowExpression.Compile(bodycontacts, nameof(bodycontacts), required: true);
            return new DeferredBodyAction<PostContactsResponse>(() =>
            {
                var apiCallPath = "/api.xro/2.0/Contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["xero-tenant-id"] = ExpressionConverter.Convert(__workflow_xeroTenantId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Contacts"] = ExpressionConverter.ConvertO(__workflow_bodycontacts);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<PostContactsResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
