//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Surexerolite
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SurexeroliteActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<GetStartedResponseItem[]> GetStarted()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetStartedResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<GetInvoicesResponse> GetInvoices([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> where = null, [WorkflowExpression] Func<string> statuses = null, [WorkflowExpression] Func<string> iDs = null, [WorkflowExpression] Func<string> invoiceNumbers = null, [WorkflowExpression] Func<string> contactIDs = null, [WorkflowExpression] Func<bool> summaryOnly = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            SourceExpression.Validate(where, nameof(where), required: false);
            SourceExpression.Validate(statuses, nameof(statuses), required: false);
            SourceExpression.Validate(iDs, nameof(iDs), required: false);
            SourceExpression.Validate(invoiceNumbers, nameof(invoiceNumbers), required: false);
            SourceExpression.Validate(contactIDs, nameof(contactIDs), required: false);
            SourceExpression.Validate(summaryOnly, nameof(summaryOnly), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api.xro/2.0/Invoices";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (where != null)
                    callPayload.Queries["where"] = SourceExpressionConverter.ConvertO(where);
                if (statuses != null)
                    callPayload.Queries["Statuses"] = SourceExpressionConverter.ConvertO(statuses);
                if (iDs != null)
                    callPayload.Queries["IDs"] = SourceExpressionConverter.ConvertO(iDs);
                if (invoiceNumbers != null)
                    callPayload.Queries["InvoiceNumbers"] = SourceExpressionConverter.ConvertO(invoiceNumbers);
                if (contactIDs != null)
                    callPayload.Queries["ContactIDs"] = SourceExpressionConverter.ConvertO(contactIDs);
                if (summaryOnly != null)
                    callPayload.Queries["summaryOnly"] = SourceExpressionConverter.ConvertO(summaryOnly);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Headers["xero-tenant-id"] = SourceExpressionConverter.ConvertO(xeroTenantId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return callPayload;
            }

            return new ApiConnectionAction<GetInvoicesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<PostInvoiceResponse> PostInvoice([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<bodylineItemsInputItem[]> bodylineItems, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodyreference = null, [WorkflowExpression] Func<string> bodycontactcontactID = null, [WorkflowExpression] Func<string> bodylineAmountTypes = null, [WorkflowExpression] Func<string> bodyinvoiceNumber = null, [WorkflowExpression] Func<string> bodycurrencyCode = null, [WorkflowExpression] Func<double> bodycurrencyRate = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyexpectedPaymentDate = null)
        {
            SourceExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodylineItems, nameof(bodylineItems), required: true);
            SourceExpression.Validate(bodydate, nameof(bodydate), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodyreference, nameof(bodyreference), required: false);
            SourceExpression.Validate(bodycontactcontactID, nameof(bodycontactcontactID), required: false);
            SourceExpression.Validate(bodylineAmountTypes, nameof(bodylineAmountTypes), required: false);
            SourceExpression.Validate(bodyinvoiceNumber, nameof(bodyinvoiceNumber), required: false);
            SourceExpression.Validate(bodycurrencyCode, nameof(bodycurrencyCode), required: false);
            SourceExpression.Validate(bodycurrencyRate, nameof(bodycurrencyRate), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodyexpectedPaymentDate, nameof(bodyexpectedPaymentDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api.xro/2.0/Invoices";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["xero-tenant-id"] = SourceExpressionConverter.ConvertO(xeroTenantId);
                callPayload.Headers["Accept"] = Convert.ToString(" application/json");
                callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydate != null)
                {
                    body["Date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["DueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Type"] = SourceExpressionConverter.ConvertToken(bodytype);
                if (bodyreference != null)
                {
                    body["Reference"] = SourceExpressionConverter.ConvertToken(bodyreference);
                    bodypropCount++;
                }

                var contactObject = new JObject();
                var contactObjectpropCount = 0;
                if (bodycontactcontactID != null)
                {
                    contactObject["ContactID"] = SourceExpressionConverter.ConvertToken(bodycontactcontactID);
                    contactObjectpropCount++;
                }

                if (contactObjectpropCount > 0)
                {
                    body["Contact"] = contactObject;
                    bodypropCount++;
                }

                if (bodylineAmountTypes != null)
                {
                    body["LineAmountTypes"] = SourceExpressionConverter.ConvertToken(bodylineAmountTypes);
                    bodypropCount++;
                }

                if (bodyinvoiceNumber != null)
                {
                    body["InvoiceNumber"] = SourceExpressionConverter.ConvertToken(bodyinvoiceNumber);
                    bodypropCount++;
                }

                bodypropCount++;
                body["LineItems"] = SourceExpressionConverter.ConvertToken(bodylineItems);
                if (bodycurrencyCode != null)
                {
                    body["CurrencyCode"] = SourceExpressionConverter.ConvertToken(bodycurrencyCode);
                    bodypropCount++;
                }

                if (bodycurrencyRate != null)
                {
                    body["CurrencyRate"] = SourceExpressionConverter.ConvertToken(bodycurrencyRate);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyexpectedPaymentDate != null)
                {
                    body["ExpectedPaymentDate"] = SourceExpressionConverter.ConvertToken(bodyexpectedPaymentDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostInvoiceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<GetContactsResponse> GetContacts([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<string> where = null, [WorkflowExpression] Func<string> iDs = null, [WorkflowExpression] Func<bool> summaryOnly = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<bool> includeArchived = null, [WorkflowExpression] Func<string> searchTerm = null)
        {
            SourceExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            SourceExpression.Validate(where, nameof(where), required: false);
            SourceExpression.Validate(iDs, nameof(iDs), required: false);
            SourceExpression.Validate(summaryOnly, nameof(summaryOnly), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(includeArchived, nameof(includeArchived), required: false);
            SourceExpression.Validate(searchTerm, nameof(searchTerm), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api.xro/2.0/Contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (where != null)
                    callPayload.Queries["where"] = SourceExpressionConverter.ConvertO(where);
                if (iDs != null)
                    callPayload.Queries["IDs"] = SourceExpressionConverter.ConvertO(iDs);
                if (summaryOnly != null)
                    callPayload.Queries["summaryOnly"] = SourceExpressionConverter.ConvertO(summaryOnly);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (includeArchived != null)
                    callPayload.Queries["includeArchived"] = SourceExpressionConverter.ConvertO(includeArchived);
                if (searchTerm != null)
                    callPayload.Queries["searchTerm"] = SourceExpressionConverter.ConvertO(searchTerm);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["xero-tenant-id"] = SourceExpressionConverter.ConvertO(xeroTenantId);
                return callPayload;
            }

            return new ApiConnectionAction<GetContactsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "surexerolite")]
        public IBodyWorkflowAction<PostContactsResponse> PostContacts([WorkflowExpression] Func<string> xeroTenantId, [WorkflowExpression] Func<bodycontactsInputItem[]> bodycontacts)
        {
            SourceExpression.Validate(xeroTenantId, nameof(xeroTenantId), required: true);
            SourceExpression.Validate(bodycontacts, nameof(bodycontacts), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api.xro/2.0/Contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Headers["xero-tenant-id"] = SourceExpressionConverter.ConvertO(xeroTenantId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Contacts"] = SourceExpressionConverter.ConvertToken(bodycontacts);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PostContactsResponse>(BuildSourceInput);
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