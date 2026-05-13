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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshbooks")]
        public IBodyWorkflowAction<Expense> AddExpense(Expression<Func<string>> accountid, Expression<Func<string>> bodyexpenseamountamount, Expression<Func<bodyexpenseamountcurrencyInput>> bodyexpenseamountcurrency = null, Expression<Func<int>> bodyexpensecategory = null, Expression<Func<int>> bodyexpensestaff = null, Expression<Func<string>> bodyexpensedate = null, Expression<Func<string>> bodyexpensevendor = null, Expression<Func<string>> bodyexpensenotes = null)
        {
            var apiCallPath = String.Format("/accounting/account/{0}/expenses/expenses", ExpressionConverter.ConvertWithUrlEncoding(accountid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["per_page"] = Convert.ToString(100);
            var body = new JObject();
            var bodypropCount = 0;
            var expenseObject = new JObject();
            var expenseObjectpropCount = 0;
            var amountObject = new JObject();
            var amountObjectpropCount = 0;
            amountObjectpropCount++;
            amountObject["amount"] = ExpressionConverter.ConvertO(bodyexpenseamountamount);
            if (bodyexpenseamountcurrency != null)
            {
                amountObject["code"] = ExpressionConverter.ConvertO(bodyexpenseamountcurrency);
                amountObjectpropCount++;
            }

            if (amountObjectpropCount > 0)
            {
                expenseObject["amount"] = amountObject;
                expenseObjectpropCount++;
            }

            if (bodyexpensecategory != null)
            {
                expenseObject["categoryid"] = ExpressionConverter.ConvertO(bodyexpensecategory);
                expenseObjectpropCount++;
            }

            if (bodyexpensestaff != null)
            {
                expenseObject["staffid"] = ExpressionConverter.ConvertO(bodyexpensestaff);
                expenseObjectpropCount++;
            }

            if (bodyexpensedate != null)
            {
                expenseObject["date"] = ExpressionConverter.ConvertO(bodyexpensedate);
                expenseObjectpropCount++;
            }

            if (bodyexpensevendor != null)
            {
                expenseObject["vendor"] = ExpressionConverter.ConvertO(bodyexpensevendor);
                expenseObjectpropCount++;
            }

            if (bodyexpensenotes != null)
            {
                expenseObject["notes"] = ExpressionConverter.ConvertO(bodyexpensenotes);
                expenseObjectpropCount++;
            }

            if (expenseObjectpropCount > 0)
            {
                body["expense"] = expenseObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Expense>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshbooks")]
        public IWorkflowAction UpdateExpense(Expression<Func<string>> accountid, Expression<Func<string>> expenseid, Expression<Func<string>> bodyexpenseamountamount = null, Expression<Func<bodyexpenseamountcurrencyInput>> bodyexpenseamountcurrency = null, Expression<Func<int>> bodyexpensecategory = null, Expression<Func<int>> bodyexpensestaff = null, Expression<Func<string>> bodyexpensedate = null, Expression<Func<string>> bodyexpensevendor = null, Expression<Func<string>> bodyexpensenotes = null)
        {
            var apiCallPath = String.Format("/accounting/account/{0}/expenses/expenses/{1}", ExpressionConverter.ConvertWithUrlEncoding(accountid, 1), ExpressionConverter.ConvertWithUrlEncoding(expenseid, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["per_page"] = Convert.ToString(100);
            var body = new JObject();
            var bodypropCount = 0;
            var expenseObject = new JObject();
            var expenseObjectpropCount = 0;
            var amountObject = new JObject();
            var amountObjectpropCount = 0;
            if (bodyexpenseamountamount != null)
            {
                amountObject["amount"] = ExpressionConverter.ConvertO(bodyexpenseamountamount);
                amountObjectpropCount++;
            }

            if (bodyexpenseamountcurrency != null)
            {
                amountObject["code"] = ExpressionConverter.ConvertO(bodyexpenseamountcurrency);
                amountObjectpropCount++;
            }

            if (amountObjectpropCount > 0)
            {
                expenseObject["amount"] = amountObject;
                expenseObjectpropCount++;
            }

            if (bodyexpensecategory != null)
            {
                expenseObject["categoryid"] = ExpressionConverter.ConvertO(bodyexpensecategory);
                expenseObjectpropCount++;
            }

            if (bodyexpensestaff != null)
            {
                expenseObject["staffid"] = ExpressionConverter.ConvertO(bodyexpensestaff);
                expenseObjectpropCount++;
            }

            if (bodyexpensedate != null)
            {
                expenseObject["date"] = ExpressionConverter.ConvertO(bodyexpensedate);
                expenseObjectpropCount++;
            }

            if (bodyexpensevendor != null)
            {
                expenseObject["vendor"] = ExpressionConverter.ConvertO(bodyexpensevendor);
                expenseObjectpropCount++;
            }

            if (bodyexpensenotes != null)
            {
                expenseObject["notes"] = ExpressionConverter.ConvertO(bodyexpensenotes);
                expenseObjectpropCount++;
            }

            if (expenseObjectpropCount > 0)
            {
                body["expense"] = expenseObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshbooks")]
        public IWorkflowAction DeleteExpense(Expression<Func<string>> accountid, Expression<Func<string>> expenseid)
        {
            var apiCallPath = String.Format("/placeholder/accounting/account/{0}/expenses/expenses/{1}", ExpressionConverter.ConvertWithUrlEncoding(accountid, 1), ExpressionConverter.ConvertWithUrlEncoding(expenseid, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["per_page"] = Convert.ToString(100);
            var body = new JObject();
            var bodypropCount = 0;
            var expenseObject = new JObject();
            var expenseObjectpropCount = 0;
            expenseObject["vis_state"] = 1;
            expenseObjectpropCount++;
            if (expenseObjectpropCount > 0)
            {
                body["expense"] = expenseObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshbooks")]
        public IBodyWorkflowAction<Client> AddClient(Expression<Func<string>> accountid, Expression<Func<string>> bodyclientfirstName = null, Expression<Func<string>> bodyclientlastName = null, Expression<Func<string>> bodyclientorganization = null, Expression<Func<string>> bodyclientemailAddress = null, Expression<Func<string>> bodyclientphoneNumber = null, Expression<Func<bodyclientcurrencyInput>> bodyclientcurrency = null, Expression<Func<string>> bodyclientstreetAddress1 = null, Expression<Func<string>> bodyclientstreetAddress2 = null, Expression<Func<string>> bodyclientcity = null, Expression<Func<string>> bodyclientpostalCode = null, Expression<Func<string>> bodyclientcountry = null, Expression<Func<string>> bodyclientprovince = null)
        {
            var apiCallPath = String.Format("/accounting/account/{0}/users/clients", ExpressionConverter.ConvertWithUrlEncoding(accountid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["per_page"] = Convert.ToString(100);
            var body = new JObject();
            var bodypropCount = 0;
            var clientObject = new JObject();
            var clientObjectpropCount = 0;
            if (bodyclientfirstName != null)
            {
                clientObject["fname"] = ExpressionConverter.ConvertO(bodyclientfirstName);
                clientObjectpropCount++;
            }

            if (bodyclientlastName != null)
            {
                clientObject["lname"] = ExpressionConverter.ConvertO(bodyclientlastName);
                clientObjectpropCount++;
            }

            if (bodyclientorganization != null)
            {
                clientObject["organization"] = ExpressionConverter.ConvertO(bodyclientorganization);
                clientObjectpropCount++;
            }

            if (bodyclientemailAddress != null)
            {
                clientObject["email"] = ExpressionConverter.ConvertO(bodyclientemailAddress);
                clientObjectpropCount++;
            }

            if (bodyclientphoneNumber != null)
            {
                clientObject["bus_phone"] = ExpressionConverter.ConvertO(bodyclientphoneNumber);
                clientObjectpropCount++;
            }

            if (bodyclientcurrency != null)
            {
                clientObject["currency_code"] = ExpressionConverter.ConvertO(bodyclientcurrency);
                clientObjectpropCount++;
            }

            if (bodyclientstreetAddress1 != null)
            {
                clientObject["p_street"] = ExpressionConverter.ConvertO(bodyclientstreetAddress1);
                clientObjectpropCount++;
            }

            if (bodyclientstreetAddress2 != null)
            {
                clientObject["p_street2"] = ExpressionConverter.ConvertO(bodyclientstreetAddress2);
                clientObjectpropCount++;
            }

            if (bodyclientcity != null)
            {
                clientObject["p_city"] = ExpressionConverter.ConvertO(bodyclientcity);
                clientObjectpropCount++;
            }

            if (bodyclientpostalCode != null)
            {
                clientObject["p_code"] = ExpressionConverter.ConvertO(bodyclientpostalCode);
                clientObjectpropCount++;
            }

            if (bodyclientcountry != null)
            {
                clientObject["p_country"] = ExpressionConverter.ConvertO(bodyclientcountry);
                clientObjectpropCount++;
            }

            if (bodyclientprovince != null)
            {
                clientObject["p_province"] = ExpressionConverter.ConvertO(bodyclientprovince);
                clientObjectpropCount++;
            }

            if (clientObjectpropCount > 0)
            {
                body["client"] = clientObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Client>(callPayload);
        }
    }

    public class FreshbooksTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Invoice[]> TrigUpdatedInvoice(Expression<Func<string>> accountid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/accounting/account/{0}/invoices/invoices", ExpressionConverter.ConvertWithUrlEncoding(accountid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["include[]"] = Convert.ToString("client");
            callPayload.Queries["per_page"] = Convert.ToString(100);
            return new ApiConnectionTrigger<Invoice[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Expense[]> TrigUpdatedExpense(Expression<Func<string>> accountid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/accounting/account/{0}/expenses/expenses", ExpressionConverter.ConvertWithUrlEncoding(accountid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["per_page"] = Convert.ToString(100);
            return new ApiConnectionTrigger<Expense[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<Payment[]> TrigUpdatedPayment(Expression<Func<string>> accountid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/accounting/account/{0}/payments/payments", ExpressionConverter.ConvertWithUrlEncoding(accountid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["include[]"] = Convert.ToString("client");
            callPayload.Queries["per_page"] = Convert.ToString(100);
            return new ApiConnectionTrigger<Payment[]>(callPayload, triggerName, recurrence);
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

    public enum bodyexpenseamountcurrencyInput
    {
        AED,
        AMD,
        ANG,
        ARS,
        AUD,
        AWG,
        AZN,
        BAM,
        BBD,
        BDT,
        BGN,
        BHD,
        BIF,
        BMD,
        BND,
        BOB,
        BOV,
        BRL,
        BSD,
        BTN,
        BWP,
        BYN,
        BYR,
        BZD,
        CAD,
        CDF,
        CHE,
        CHF,
        CHW,
        CLF,
        CLP,
        CNY,
        COP,
        COU,
        CRC,
        CUC,
        CUP,
        CVE,
        CZK,
        DJF,
        DKK,
        DOP,
        EGP,
        ERN,
        ETB,
        EUR,
        FJD,
        FKP,
        GBP,
        GEL,
        GHS,
        GIP,
        GMD,
        GNF,
        GTQ,
        GYD,
        HKD,
        HNL,
        HRK,
        HTG,
        HUF,
        IDR,
        ILS,
        INR,
        IQD,
        IRR,
        ISK,
        JMD,
        JOD,
        JPY,
        KES,
        KGS,
        KHR,
        KMF,
        KPW,
        KRW,
        KWD,
        KYD,
        KZT,
        LAK,
        LBP,
        LKR,
        LRD,
        LSL,
        LYD,
        MAD,
        MDL,
        MGA,
        MKD,
        MMK,
        MNT,
        MOP,
        MRO,
        MUR,
        MVR,
        MWK,
        MXN,
        MXV,
        MYR,
        MZN,
        NAD,
        NGN,
        NIO,
        NOK,
        NPR,
        NZD,
        OMR,
        PAB,
        PEN,
        PGK,
        PHP,
        PKR,
        PLN,
        PYG,
        QAR,
        RON,
        RSD,
        RUB,
        RWF,
        SAR,
        SBD,
        SCR,
        SDG,
        SEK,
        SGD,
        SHP,
        SLL,
        SOS,
        SRD,
        SSP,
        STD,
        SVC,
        SYP,
        SZL,
        THB,
        TJS,
        TMT,
        TND,
        TOP,
        TRY,
        TTD,
        TWD,
        TZS,
        UAH,
        UGX,
        USD,
        USN,
        UYI,
        UYU,
        UZS,
        VEF,
        VND,
        VUV,
        WST,
        XAF,
        XAG,
        XAU,
        XBA,
        XBB,
        XBC,
        XBD,
        XCD,
        XDR,
        XOF,
        XPD,
        XPF,
        XPT,
        XSU,
        XTS,
        XUA,
        XXX,
        YER,
        ZAR,
        ZMW,
        ZWL
    }

    public class Client
    {
        [JsonProperty("response")]
        public ClientValueType Value { get; set; }
    }

    public class ClientValueType
    {
        [JsonProperty("result")]
        public ClientValueTypeValueType Value { get; set; }
    }

    public class ClientValueTypeValueType
    {
        [JsonProperty("client")]
        public ClientValueTypeValueTypeValueType Value { get; set; }
    }

    public class ClientValueTypeValueTypeValueType
    {
        [JsonProperty("fname")]
        public string FirstName { get; set; }

        [JsonProperty("lname")]
        public string LastName { get; set; }

        [JsonProperty("fax")]
        public string FaNumber { get; set; }

        [JsonProperty("vat_number")]
        public string VATNumber { get; set; }

        [JsonProperty("vat_name")]
        public string VATName { get; set; }

        [JsonProperty("id")]
        public int ClientId { get; set; }

        [JsonProperty("p_province")]
        public string Province { get; set; }

        [JsonProperty("p_country")]
        public string Country { get; set; }

        [JsonProperty("p_city")]
        public string City { get; set; }

        [JsonProperty("p_street")]
        public string Street { get; set; }

        [JsonProperty("p_street2")]
        public string Street2 { get; set; }

        [JsonProperty("p_code")]
        public string PostalCode { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("mob_phone")]
        public string MobilePhone { get; set; }

        [JsonProperty("home_phone")]
        public string HomePhone { get; set; }

        [JsonProperty("company_industry")]
        public string CompanyIndustry { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("bus_phone")]
        public string Phone { get; set; }

        [JsonProperty("company_size")]
        public string Size { get; set; }

        [JsonProperty("accounting_systemid")]
        public string SystemId { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
    }

    public enum bodyclientcurrencyInput
    {
        AED,
        AMD,
        ANG,
        ARS,
        AUD,
        AWG,
        AZN,
        BAM,
        BBD,
        BDT,
        BGN,
        BHD,
        BIF,
        BMD,
        BND,
        BOB,
        BOV,
        BRL,
        BSD,
        BTN,
        BWP,
        BYN,
        BYR,
        BZD,
        CAD,
        CDF,
        CHE,
        CHF,
        CHW,
        CLF,
        CLP,
        CNY,
        COP,
        COU,
        CRC,
        CUC,
        CUP,
        CVE,
        CZK,
        DJF,
        DKK,
        DOP,
        EGP,
        ERN,
        ETB,
        EUR,
        FJD,
        FKP,
        GBP,
        GEL,
        GHS,
        GIP,
        GMD,
        GNF,
        GTQ,
        GYD,
        HKD,
        HNL,
        HRK,
        HTG,
        HUF,
        IDR,
        ILS,
        INR,
        IQD,
        IRR,
        ISK,
        JMD,
        JOD,
        JPY,
        KES,
        KGS,
        KHR,
        KMF,
        KPW,
        KRW,
        KWD,
        KYD,
        KZT,
        LAK,
        LBP,
        LKR,
        LRD,
        LSL,
        LYD,
        MAD,
        MDL,
        MGA,
        MKD,
        MMK,
        MNT,
        MOP,
        MRO,
        MUR,
        MVR,
        MWK,
        MXN,
        MXV,
        MYR,
        MZN,
        NAD,
        NGN,
        NIO,
        NOK,
        NPR,
        NZD,
        OMR,
        PAB,
        PEN,
        PGK,
        PHP,
        PKR,
        PLN,
        PYG,
        QAR,
        RON,
        RSD,
        RUB,
        RWF,
        SAR,
        SBD,
        SCR,
        SDG,
        SEK,
        SGD,
        SHP,
        SLL,
        SOS,
        SRD,
        SSP,
        STD,
        SVC,
        SYP,
        SZL,
        THB,
        TJS,
        TMT,
        TND,
        TOP,
        TRY,
        TTD,
        TWD,
        TZS,
        UAH,
        UGX,
        USD,
        USN,
        UYI,
        UYU,
        UZS,
        VEF,
        VND,
        VUV,
        WST,
        XAF,
        XAG,
        XAU,
        XBA,
        XBB,
        XBC,
        XBD,
        XCD,
        XDR,
        XOF,
        XPD,
        XPF,
        XPT,
        XSU,
        XTS,
        XUA,
        XXX,
        YER,
        ZAR,
        ZMW,
        ZWL
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

namespace Microsoft.Azure.Workflows.Sdk
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