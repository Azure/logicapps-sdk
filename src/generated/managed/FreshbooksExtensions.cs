//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Freshbooks
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FreshbooksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshbooks")]
        public IBodyWorkflowAction<Expense[]> ListExpenses(Expression<Func<string>> accountid)
        {
            var apiCallPath = String.Format("/accounting/account/{0}/expenses/expenses", ExpressionConverter.ConvertWithUrlEncoding(accountid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["per_page"] = Convert.ToString(100);
            return new ApiConnectionAction<Expense[]>(callPayload);
        }
    }

    public class FreshbooksTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<Invoice[]> TrigUpdatedInvoice(Expression<Func<string>> accountid, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger/accounting/account/{0}/invoices/invoices", ExpressionConverter.ConvertWithUrlEncoding(accountid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["include[]"] = Convert.ToString("client");
            callPayload.Queries["per_page"] = Convert.ToString(100);
            return new ApiConnectionTrigger<Invoice[]>(callPayload);
        }

        public IOutputWorkflowTrigger<Expense[]> TrigUpdatedExpense(Expression<Func<string>> accountid, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger/accounting/account/{0}/expenses/expenses", ExpressionConverter.ConvertWithUrlEncoding(accountid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["per_page"] = Convert.ToString(100);
            return new ApiConnectionTrigger<Expense[]>(callPayload);
        }

        public IOutputWorkflowTrigger<Payment[]> TrigUpdatedPayment(Expression<Func<string>> accountid, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger/accounting/account/{0}/payments/payments", ExpressionConverter.ConvertWithUrlEncoding(accountid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["include[]"] = Convert.ToString("client");
            callPayload.Queries["per_page"] = Convert.ToString(100);
            return new ApiConnectionTrigger<Payment[]>(callPayload);
        }
    }

    public class Expense
    {
        [JsonProperty("id")]
        public int ExpenseID { get; set; }

        [JsonProperty("markup_percent")]
        public string MarkupPercent { get; set; }

        [JsonProperty("projectid")]
        public int ProjectId { get; set; }

        [JsonProperty("clientid")]
        public int ClientId { get; set; }

        [JsonProperty("taxPercent1")]
        public string TaxPercent1 { get; set; }

        [JsonProperty("taxName1")]
        public string TaxName1 { get; set; }

        [JsonProperty("taxAmount1")]
        public ExpenseTaxAmount1Type TaxAmount1 { get; set; }

        [JsonProperty("taxPercent2")]
        public string TaxPercent2 { get; set; }

        [JsonProperty("taxName2")]
        public string TaxName2 { get; set; }

        [JsonProperty("taxAmount2")]
        public ExpenseTaxAmount2Type TaxAmount2 { get; set; }

        [JsonProperty("invoiceid")]
        public int InvoiceId { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("has_receipt")]
        public bool HasReceipt { get; set; }

        [JsonProperty("ext_systemid")]
        public int ExternalSystemId { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("transactionid")]
        public string TransactionId { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("amount")]
        public ExpenseAmountType Amount { get; set; }

        [JsonProperty("compounded_tax")]
        public bool CompoundedTax { get; set; }

        [JsonProperty("accountid")]
        public string AccountId { get; set; }
    }

    public class ExpenseTaxAmount1Type
    {
        [JsonProperty("amount")]
        public string FirstTaskAmount { get; set; }

        [JsonProperty("code")]
        public string FirstTaxCurrencyCode { get; set; }
    }

    public class ExpenseTaxAmount2Type
    {
        [JsonProperty("amount")]
        public string SecondTaxAmount { get; set; }

        [JsonProperty("code")]
        public string SecondTaxCurrencyCode { get; set; }
    }

    public class ExpenseAmountType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("code")]
        public string CurrencyCode { get; set; }
    }

    public class Invoice
    {
        [JsonProperty("id")]
        public int InvoiceID { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("accountid")]
        public string AccountID { get; set; }

        [JsonProperty("currency_code")]
        public string _3LetterCurrencyCode { get; set; }

        [JsonProperty("v3_status")]
        public string InvoiceStatus { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("language")]
        public string TwoLetterLanguageCode { get; set; }

        [JsonProperty("customerid")]
        public int CustomerID { get; set; }

        [JsonProperty("organization")]
        public string OrganizationInvoiced { get; set; }

        [JsonProperty("fname")]
        public string CustomerFirstName { get; set; }

        [JsonProperty("lname")]
        public string CustomerLastName { get; set; }

        [JsonProperty("create_date")]
        public string InvoiceCreateDate { get; set; }

        [JsonProperty("due_date")]
        public string InvoiceDueDate { get; set; }

        [JsonProperty("updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("created_at")]
        public string CreateDate { get; set; }

        [JsonProperty("date_paid")]
        public string InvoicePaidDate { get; set; }

        [JsonProperty("payment_status")]
        public string PaymentStatus { get; set; }

        [JsonProperty("amount")]
        public InvoiceAmountType Amount { get; set; }

        [JsonProperty("paid")]
        public InvoicePaidType Paid { get; set; }

        [JsonProperty("outstanding")]
        public InvoiceOutstandingType Outstanding { get; set; }

        [JsonProperty("discount")]
        public InvoiceDiscountType Discount { get; set; }

        [JsonProperty("client")]
        public InvoiceClientType Client { get; set; }
    }

    public class InvoiceAmountType
    {
        [JsonProperty("amount")]
        public string InvoiceAmount { get; set; }
    }

    public class InvoicePaidType
    {
        [JsonProperty("amount")]
        public string AmountPaid { get; set; }
    }

    public class InvoiceOutstandingType
    {
        [JsonProperty("amount")]
        public string OutstandingAmount { get; set; }
    }

    public class InvoiceDiscountType
    {
        [JsonProperty("amount")]
        public string DiscountAmount { get; set; }
    }

    public class InvoiceClientType
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class Payment
    {
        [JsonProperty("id")]
        public int PaymentID { get; set; }

        [JsonProperty("type")]
        public string PaymentType { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("date")]
        public string PaymentDate { get; set; }

        [JsonProperty("clientid")]
        public int CustomerID { get; set; }

        [JsonProperty("amount")]
        public PaymentAmountType Amount { get; set; }

        [JsonProperty("accounting_systemid")]
        public string AccountID { get; set; }

        [JsonProperty("invoiceid")]
        public int InvoiceID { get; set; }

        [JsonProperty("updated")]
        public string LastUpdated { get; set; }

        [JsonProperty("client")]
        public PaymentClientType Client { get; set; }
    }

    public class PaymentAmountType
    {
        [JsonProperty("amount")]
        public string InvoiceAmount { get; set; }

        [JsonProperty("code")]
        public string _3LetterCurrencyCode { get; set; }
    }

    public class PaymentClientType
    {
        [JsonProperty("fname")]
        public string FirstName { get; set; }

        [JsonProperty("lname")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Freshbooks;

    public partial class WorkflowManagedActions
    {
        public FreshbooksActions Freshbooks(string connectionId) => new FreshbooksActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FreshbooksTriggers Freshbooks(string connectionId) => new FreshbooksTriggers(connectionId);
    }
}