//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Freshbooks
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FreshbooksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshbooks")]
        public IBodyWorkflowAction<Expense[], ApiConnectionActionConfiguration> ListExpenses(Expression<Func<string>> accountid)
        {
            var __workflow_accountid = WorkflowExpression.Compile(accountid, nameof(accountid), required: true);
            return new DeferredBodyAction<Expense[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounting/account/{0}/expenses/expenses", __workflow_accountid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["per_page"] = Convert.ToString(100);
                return new ApiConnectionAction<Expense[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshbooks")]
        public IBodyWorkflowAction<Expense, ApiConnectionActionConfiguration> AddExpense(Expression<Func<string>> accountid, Expression<Func<AddExpenseBodyInput>> body)
        {
            var __workflow_accountid = WorkflowExpression.Compile(accountid, nameof(accountid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Expense, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounting/account/{0}/expenses/expenses", __workflow_accountid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["per_page"] = Convert.ToString(100);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Expense>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshbooks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateExpense(Expression<Func<string>> accountid, Expression<Func<string>> expenseid, Expression<Func<UpdateExpenseBodyInput>> body)
        {
            var __workflow_accountid = WorkflowExpression.Compile(accountid, nameof(accountid), required: true);
            var __workflow_expenseid = WorkflowExpression.Compile(expenseid, nameof(expenseid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounting/account/{0}/expenses/expenses/{1}", __workflow_accountid.WithUrlEncoding(1), __workflow_expenseid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["per_page"] = Convert.ToString(100);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshbooks")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteExpense(Expression<Func<string>> accountid, Expression<Func<string>> expenseid)
        {
            var __workflow_accountid = WorkflowExpression.Compile(accountid, nameof(accountid), required: true);
            var __workflow_expenseid = WorkflowExpression.Compile(expenseid, nameof(expenseid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/placeholder/accounting/account/{0}/expenses/expenses/{1}", __workflow_accountid.WithUrlEncoding(1), __workflow_expenseid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["per_page"] = Convert.ToString(100);
                callPayload.Body = new DeleteExpenseBodyInput().ToJToken();
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "freshbooks")]
        public IBodyWorkflowAction<Client, ApiConnectionActionConfiguration> AddClient(Expression<Func<string>> accountid, Expression<Func<AddClientBodyInput>> body)
        {
            var __workflow_accountid = WorkflowExpression.Compile(accountid, nameof(accountid), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Client, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/accounting/account/{0}/users/clients", __workflow_accountid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["per_page"] = Convert.ToString(100);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Client>(callPayload);
            });
        }
    }

    public class FreshbooksTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Invoice[], ApiConnectionPollingTriggerConfiguration> TrigUpdatedInvoice(Expression<Func<string>> accountid)
        {
            var __workflow_accountid = WorkflowExpression.Compile(accountid, nameof(accountid), required: true);
            return new DeferredBodyTrigger<Invoice[], ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/accounting/account/{0}/invoices/invoices", __workflow_accountid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["include[]"] = Convert.ToString("client");
                callPayload.Queries["per_page"] = Convert.ToString(100);
                return new ApiConnectionPollingTrigger<Invoice[]>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<Expense[], ApiConnectionPollingTriggerConfiguration> TrigUpdatedExpense(Expression<Func<string>> accountid)
        {
            var __workflow_accountid = WorkflowExpression.Compile(accountid, nameof(accountid), required: true);
            return new DeferredBodyTrigger<Expense[], ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/accounting/account/{0}/expenses/expenses", __workflow_accountid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["per_page"] = Convert.ToString(100);
                return new ApiConnectionPollingTrigger<Expense[]>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<Payment[], ApiConnectionPollingTriggerConfiguration> TrigUpdatedPayment(Expression<Func<string>> accountid)
        {
            var __workflow_accountid = WorkflowExpression.Compile(accountid, nameof(accountid), required: true);
            return new DeferredBodyTrigger<Payment[], ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/accounting/account/{0}/payments/payments", __workflow_accountid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["include[]"] = Convert.ToString("client");
                callPayload.Queries["per_page"] = Convert.ToString(100);
                return new ApiConnectionPollingTrigger<Payment[]>(callPayload);
            });
        }
    }

    public class Expense
    {
        [JsonProperty("id")]
        public int ExpenseId { get; set; }

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

    public class AddExpenseBodyInput
    {
        public AddExpenseBodyInput(AddExpenseBodyInputExpenseType expense)
        {
            this.Expense = expense;
        }

        [JsonProperty("expense", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddExpenseBodyInputExpenseType Expense { get; set; }
    }

    public class AddExpenseBodyInputExpenseType
    {
        public AddExpenseBodyInputExpenseType(AddExpenseBodyInputExpenseTypeAmountType amount, int category, int staff, string date)
        {
            this.Amount = amount;
            this.Category = category;
            this.Staff = staff;
            this.Date = date;
        }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public AddExpenseBodyInputExpenseTypeAmountType Amount { get; set; }

        [JsonProperty("categoryid", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Category { get; set; }

        [JsonProperty("staffid", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Staff { get; set; }

        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class AddExpenseBodyInputExpenseTypeAmountType
    {
        public AddExpenseBodyInputExpenseTypeAmountType(string amount)
        {
            this.Amount = amount;
        }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Amount { get; set; }

        [JsonProperty("code")]
        public BodyInputExpenseTypeAmountTypeCurrencyType? Currency { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputExpenseTypeAmountTypeCurrencyType
    {
        [EnumMember(Value = "AED")]
        Aed,
        [EnumMember(Value = "AMD")]
        Amd,
        [EnumMember(Value = "ANG")]
        Ang,
        [EnumMember(Value = "ARS")]
        Ars,
        [EnumMember(Value = "AUD")]
        Aud,
        [EnumMember(Value = "AWG")]
        Awg,
        [EnumMember(Value = "AZN")]
        Azn,
        [EnumMember(Value = "BAM")]
        Bam,
        [EnumMember(Value = "BBD")]
        Bbd,
        [EnumMember(Value = "BDT")]
        Bdt,
        [EnumMember(Value = "BGN")]
        Bgn,
        [EnumMember(Value = "BHD")]
        Bhd,
        [EnumMember(Value = "BIF")]
        Bif,
        [EnumMember(Value = "BMD")]
        Bmd,
        [EnumMember(Value = "BND")]
        Bnd,
        [EnumMember(Value = "BOB")]
        Bob,
        [EnumMember(Value = "BOV")]
        Bov,
        [EnumMember(Value = "BRL")]
        Brl,
        [EnumMember(Value = "BSD")]
        Bsd,
        [EnumMember(Value = "BTN")]
        Btn,
        [EnumMember(Value = "BWP")]
        Bwp,
        [EnumMember(Value = "BYN")]
        Byn,
        [EnumMember(Value = "BYR")]
        Byr,
        [EnumMember(Value = "BZD")]
        Bzd,
        [EnumMember(Value = "CAD")]
        Cad,
        [EnumMember(Value = "CDF")]
        Cdf,
        [EnumMember(Value = "CHE")]
        Che,
        [EnumMember(Value = "CHF")]
        Chf,
        [EnumMember(Value = "CHW")]
        Chw,
        [EnumMember(Value = "CLF")]
        Clf,
        [EnumMember(Value = "CLP")]
        Clp,
        [EnumMember(Value = "CNY")]
        Cny,
        [EnumMember(Value = "COP")]
        Cop,
        [EnumMember(Value = "COU")]
        Cou,
        [EnumMember(Value = "CRC")]
        Crc,
        [EnumMember(Value = "CUC")]
        Cuc,
        [EnumMember(Value = "CUP")]
        Cup,
        [EnumMember(Value = "CVE")]
        Cve,
        [EnumMember(Value = "CZK")]
        Czk,
        [EnumMember(Value = "DJF")]
        Djf,
        [EnumMember(Value = "DKK")]
        Dkk,
        [EnumMember(Value = "DOP")]
        Dop,
        [EnumMember(Value = "EGP")]
        Egp,
        [EnumMember(Value = "ERN")]
        Ern,
        [EnumMember(Value = "ETB")]
        Etb,
        [EnumMember(Value = "EUR")]
        Eur,
        [EnumMember(Value = "FJD")]
        Fjd,
        [EnumMember(Value = "FKP")]
        Fkp,
        [EnumMember(Value = "GBP")]
        Gbp,
        [EnumMember(Value = "GEL")]
        Gel,
        [EnumMember(Value = "GHS")]
        Ghs,
        [EnumMember(Value = "GIP")]
        Gip,
        [EnumMember(Value = "GMD")]
        Gmd,
        [EnumMember(Value = "GNF")]
        Gnf,
        [EnumMember(Value = "GTQ")]
        Gtq,
        [EnumMember(Value = "GYD")]
        Gyd,
        [EnumMember(Value = "HKD")]
        Hkd,
        [EnumMember(Value = "HNL")]
        Hnl,
        [EnumMember(Value = "HRK")]
        Hrk,
        [EnumMember(Value = "HTG")]
        Htg,
        [EnumMember(Value = "HUF")]
        Huf,
        [EnumMember(Value = "IDR")]
        Idr,
        [EnumMember(Value = "ILS")]
        Ils,
        [EnumMember(Value = "INR")]
        Inr,
        [EnumMember(Value = "IQD")]
        Iqd,
        [EnumMember(Value = "IRR")]
        Irr,
        [EnumMember(Value = "ISK")]
        Isk,
        [EnumMember(Value = "JMD")]
        Jmd,
        [EnumMember(Value = "JOD")]
        Jod,
        [EnumMember(Value = "JPY")]
        Jpy,
        [EnumMember(Value = "KES")]
        Kes,
        [EnumMember(Value = "KGS")]
        Kgs,
        [EnumMember(Value = "KHR")]
        Khr,
        [EnumMember(Value = "KMF")]
        Kmf,
        [EnumMember(Value = "KPW")]
        Kpw,
        [EnumMember(Value = "KRW")]
        Krw,
        [EnumMember(Value = "KWD")]
        Kwd,
        [EnumMember(Value = "KYD")]
        Kyd,
        [EnumMember(Value = "KZT")]
        Kzt,
        [EnumMember(Value = "LAK")]
        Lak,
        [EnumMember(Value = "LBP")]
        Lbp,
        [EnumMember(Value = "LKR")]
        Lkr,
        [EnumMember(Value = "LRD")]
        Lrd,
        [EnumMember(Value = "LSL")]
        Lsl,
        [EnumMember(Value = "LYD")]
        Lyd,
        [EnumMember(Value = "MAD")]
        Mad,
        [EnumMember(Value = "MDL")]
        Mdl,
        [EnumMember(Value = "MGA")]
        Mga,
        [EnumMember(Value = "MKD")]
        Mkd,
        [EnumMember(Value = "MMK")]
        Mmk,
        [EnumMember(Value = "MNT")]
        Mnt,
        [EnumMember(Value = "MOP")]
        Mop,
        [EnumMember(Value = "MRO")]
        Mro,
        [EnumMember(Value = "MUR")]
        Mur,
        [EnumMember(Value = "MVR")]
        Mvr,
        [EnumMember(Value = "MWK")]
        Mwk,
        [EnumMember(Value = "MXN")]
        Mxn,
        [EnumMember(Value = "MXV")]
        Mxv,
        [EnumMember(Value = "MYR")]
        Myr,
        [EnumMember(Value = "MZN")]
        Mzn,
        [EnumMember(Value = "NAD")]
        Nad,
        [EnumMember(Value = "NGN")]
        Ngn,
        [EnumMember(Value = "NIO")]
        Nio,
        [EnumMember(Value = "NOK")]
        Nok,
        [EnumMember(Value = "NPR")]
        Npr,
        [EnumMember(Value = "NZD")]
        Nzd,
        [EnumMember(Value = "OMR")]
        Omr,
        [EnumMember(Value = "PAB")]
        Pab,
        [EnumMember(Value = "PEN")]
        Pen,
        [EnumMember(Value = "PGK")]
        Pgk,
        [EnumMember(Value = "PHP")]
        Php,
        [EnumMember(Value = "PKR")]
        Pkr,
        [EnumMember(Value = "PLN")]
        Pln,
        [EnumMember(Value = "PYG")]
        Pyg,
        [EnumMember(Value = "QAR")]
        Qar,
        [EnumMember(Value = "RON")]
        Ron,
        [EnumMember(Value = "RSD")]
        Rsd,
        [EnumMember(Value = "RUB")]
        Rub,
        [EnumMember(Value = "RWF")]
        Rwf,
        [EnumMember(Value = "SAR")]
        Sar,
        [EnumMember(Value = "SBD")]
        Sbd,
        [EnumMember(Value = "SCR")]
        Scr,
        [EnumMember(Value = "SDG")]
        Sdg,
        [EnumMember(Value = "SEK")]
        Sek,
        [EnumMember(Value = "SGD")]
        Sgd,
        [EnumMember(Value = "SHP")]
        Shp,
        [EnumMember(Value = "SLL")]
        Sll,
        [EnumMember(Value = "SOS")]
        Sos,
        [EnumMember(Value = "SRD")]
        Srd,
        [EnumMember(Value = "SSP")]
        Ssp,
        [EnumMember(Value = "STD")]
        Std,
        [EnumMember(Value = "SVC")]
        Svc,
        [EnumMember(Value = "SYP")]
        Syp,
        [EnumMember(Value = "SZL")]
        Szl,
        [EnumMember(Value = "THB")]
        Thb,
        [EnumMember(Value = "TJS")]
        Tjs,
        [EnumMember(Value = "TMT")]
        Tmt,
        [EnumMember(Value = "TND")]
        Tnd,
        [EnumMember(Value = "TOP")]
        Top,
        [EnumMember(Value = "TRY")]
        Try,
        [EnumMember(Value = "TTD")]
        Ttd,
        [EnumMember(Value = "TWD")]
        Twd,
        [EnumMember(Value = "TZS")]
        Tzs,
        [EnumMember(Value = "UAH")]
        Uah,
        [EnumMember(Value = "UGX")]
        Ugx,
        [EnumMember(Value = "USD")]
        Usd,
        [EnumMember(Value = "USN")]
        Usn,
        [EnumMember(Value = "UYI")]
        Uyi,
        [EnumMember(Value = "UYU")]
        Uyu,
        [EnumMember(Value = "UZS")]
        Uzs,
        [EnumMember(Value = "VEF")]
        Vef,
        [EnumMember(Value = "VND")]
        Vnd,
        [EnumMember(Value = "VUV")]
        Vuv,
        [EnumMember(Value = "WST")]
        Wst,
        [EnumMember(Value = "XAF")]
        Xaf,
        [EnumMember(Value = "XAG")]
        Xag,
        [EnumMember(Value = "XAU")]
        Xau,
        [EnumMember(Value = "XBA")]
        Xba,
        [EnumMember(Value = "XBB")]
        Xbb,
        [EnumMember(Value = "XBC")]
        Xbc,
        [EnumMember(Value = "XBD")]
        Xbd,
        [EnumMember(Value = "XCD")]
        Xcd,
        [EnumMember(Value = "XDR")]
        Xdr,
        [EnumMember(Value = "XOF")]
        Xof,
        [EnumMember(Value = "XPD")]
        Xpd,
        [EnumMember(Value = "XPF")]
        Xpf,
        [EnumMember(Value = "XPT")]
        Xpt,
        [EnumMember(Value = "XSU")]
        Xsu,
        [EnumMember(Value = "XTS")]
        Xts,
        [EnumMember(Value = "XUA")]
        Xua,
        [EnumMember(Value = "XXX")]
        Xxx,
        [EnumMember(Value = "YER")]
        Yer,
        [EnumMember(Value = "ZAR")]
        Zar,
        [EnumMember(Value = "ZMW")]
        Zmw,
        [EnumMember(Value = "ZWL")]
        Zwl
    }

    public class UpdateExpenseBodyInput
    {
        public UpdateExpenseBodyInput(UpdateExpenseBodyInputExpenseType expense)
        {
            this.Expense = expense;
        }

        [JsonProperty("expense", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateExpenseBodyInputExpenseType Expense { get; set; }
    }

    public class UpdateExpenseBodyInputExpenseType
    {
        [JsonProperty("amount")]
        public UpdateExpenseBodyInputExpenseTypeAmountType Amount { get; set; }

        [JsonProperty("categoryid")]
        public int? Category { get; set; }

        [JsonProperty("staffid")]
        public int? Staff { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public class UpdateExpenseBodyInputExpenseTypeAmountType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("code")]
        public BodyInputExpenseTypeAmountTypeCurrencyType? Currency { get; set; }
    }

    public class DeleteExpenseBodyInput
    {
        [JsonProperty("expense", DefaultValueHandling = DefaultValueHandling.Include)]
        public DeleteExpenseBodyInputExpenseType Expense { get; set; } = new DeleteExpenseBodyInputExpenseType();
    }

    public class DeleteExpenseBodyInputExpenseType
    {
        [JsonProperty("vis_state", DefaultValueHandling = DefaultValueHandling.Include)]
        internal int VisState { get; set; } = 1;
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
        public string VatNumber { get; set; }

        [JsonProperty("vat_name")]
        public string VatName { get; set; }

        [JsonProperty("id")]
        public int ClientId { get; set; }

        [JsonProperty("s_province")]
        public string Province { get; set; }

        [JsonProperty("s_country")]
        public string Country { get; set; }

        [JsonProperty("s_city")]
        public string City { get; set; }

        [JsonProperty("s_street")]
        public string Street { get; set; }

        [JsonProperty("s_street2")]
        public string Street2 { get; set; }

        [JsonProperty("s_code")]
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
        public string UserName { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("p_province")]
        public string Province2 { get; set; }

        [JsonProperty("p_country")]
        public string Country2 { get; set; }

        [JsonProperty("p_city")]
        public string City2 { get; set; }

        [JsonProperty("p_street")]
        public string Street3 { get; set; }

        [JsonProperty("p_code")]
        public string PostalCode2 { get; set; }

        [JsonProperty("p_street2")]
        public string Street22 { get; set; }

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

    public class AddClientBodyInput
    {
        public AddClientBodyInput(BodyInputClientType client)
        {
            this.Client = client;
        }

        [JsonProperty("client", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputClientType Client { get; set; }
    }

    public class BodyInputClientType
    {
        [JsonProperty("fname")]
        public string FirstName { get; set; }

        [JsonProperty("lname")]
        public string LastName { get; set; }

        [JsonProperty("organization")]
        public string Organization { get; set; }

        [JsonProperty("email")]
        public string EmailAddress { get; set; }

        [JsonProperty("bus_phone")]
        public string PhoneNumber { get; set; }

        [JsonProperty("currency_code")]
        public BodyInputClientTypeCurrencyType? Currency { get; set; }

        [JsonProperty("p_street")]
        public string StreetAddress1 { get; set; }

        [JsonProperty("p_street2")]
        public string StreetAddress2 { get; set; }

        [JsonProperty("p_city")]
        public string City { get; set; }

        [JsonProperty("p_code")]
        public string PostalCode { get; set; }

        [JsonProperty("p_country")]
        public string Country { get; set; }

        [JsonProperty("p_province")]
        public string Province { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputClientTypeCurrencyType
    {
        [EnumMember(Value = "AED")]
        Aed,
        [EnumMember(Value = "AMD")]
        Amd,
        [EnumMember(Value = "ANG")]
        Ang,
        [EnumMember(Value = "ARS")]
        Ars,
        [EnumMember(Value = "AUD")]
        Aud,
        [EnumMember(Value = "AWG")]
        Awg,
        [EnumMember(Value = "AZN")]
        Azn,
        [EnumMember(Value = "BAM")]
        Bam,
        [EnumMember(Value = "BBD")]
        Bbd,
        [EnumMember(Value = "BDT")]
        Bdt,
        [EnumMember(Value = "BGN")]
        Bgn,
        [EnumMember(Value = "BHD")]
        Bhd,
        [EnumMember(Value = "BIF")]
        Bif,
        [EnumMember(Value = "BMD")]
        Bmd,
        [EnumMember(Value = "BND")]
        Bnd,
        [EnumMember(Value = "BOB")]
        Bob,
        [EnumMember(Value = "BOV")]
        Bov,
        [EnumMember(Value = "BRL")]
        Brl,
        [EnumMember(Value = "BSD")]
        Bsd,
        [EnumMember(Value = "BTN")]
        Btn,
        [EnumMember(Value = "BWP")]
        Bwp,
        [EnumMember(Value = "BYN")]
        Byn,
        [EnumMember(Value = "BYR")]
        Byr,
        [EnumMember(Value = "BZD")]
        Bzd,
        [EnumMember(Value = "CAD")]
        Cad,
        [EnumMember(Value = "CDF")]
        Cdf,
        [EnumMember(Value = "CHE")]
        Che,
        [EnumMember(Value = "CHF")]
        Chf,
        [EnumMember(Value = "CHW")]
        Chw,
        [EnumMember(Value = "CLF")]
        Clf,
        [EnumMember(Value = "CLP")]
        Clp,
        [EnumMember(Value = "CNY")]
        Cny,
        [EnumMember(Value = "COP")]
        Cop,
        [EnumMember(Value = "COU")]
        Cou,
        [EnumMember(Value = "CRC")]
        Crc,
        [EnumMember(Value = "CUC")]
        Cuc,
        [EnumMember(Value = "CUP")]
        Cup,
        [EnumMember(Value = "CVE")]
        Cve,
        [EnumMember(Value = "CZK")]
        Czk,
        [EnumMember(Value = "DJF")]
        Djf,
        [EnumMember(Value = "DKK")]
        Dkk,
        [EnumMember(Value = "DOP")]
        Dop,
        [EnumMember(Value = "EGP")]
        Egp,
        [EnumMember(Value = "ERN")]
        Ern,
        [EnumMember(Value = "ETB")]
        Etb,
        [EnumMember(Value = "EUR")]
        Eur,
        [EnumMember(Value = "FJD")]
        Fjd,
        [EnumMember(Value = "FKP")]
        Fkp,
        [EnumMember(Value = "GBP")]
        Gbp,
        [EnumMember(Value = "GEL")]
        Gel,
        [EnumMember(Value = "GHS")]
        Ghs,
        [EnumMember(Value = "GIP")]
        Gip,
        [EnumMember(Value = "GMD")]
        Gmd,
        [EnumMember(Value = "GNF")]
        Gnf,
        [EnumMember(Value = "GTQ")]
        Gtq,
        [EnumMember(Value = "GYD")]
        Gyd,
        [EnumMember(Value = "HKD")]
        Hkd,
        [EnumMember(Value = "HNL")]
        Hnl,
        [EnumMember(Value = "HRK")]
        Hrk,
        [EnumMember(Value = "HTG")]
        Htg,
        [EnumMember(Value = "HUF")]
        Huf,
        [EnumMember(Value = "IDR")]
        Idr,
        [EnumMember(Value = "ILS")]
        Ils,
        [EnumMember(Value = "INR")]
        Inr,
        [EnumMember(Value = "IQD")]
        Iqd,
        [EnumMember(Value = "IRR")]
        Irr,
        [EnumMember(Value = "ISK")]
        Isk,
        [EnumMember(Value = "JMD")]
        Jmd,
        [EnumMember(Value = "JOD")]
        Jod,
        [EnumMember(Value = "JPY")]
        Jpy,
        [EnumMember(Value = "KES")]
        Kes,
        [EnumMember(Value = "KGS")]
        Kgs,
        [EnumMember(Value = "KHR")]
        Khr,
        [EnumMember(Value = "KMF")]
        Kmf,
        [EnumMember(Value = "KPW")]
        Kpw,
        [EnumMember(Value = "KRW")]
        Krw,
        [EnumMember(Value = "KWD")]
        Kwd,
        [EnumMember(Value = "KYD")]
        Kyd,
        [EnumMember(Value = "KZT")]
        Kzt,
        [EnumMember(Value = "LAK")]
        Lak,
        [EnumMember(Value = "LBP")]
        Lbp,
        [EnumMember(Value = "LKR")]
        Lkr,
        [EnumMember(Value = "LRD")]
        Lrd,
        [EnumMember(Value = "LSL")]
        Lsl,
        [EnumMember(Value = "LYD")]
        Lyd,
        [EnumMember(Value = "MAD")]
        Mad,
        [EnumMember(Value = "MDL")]
        Mdl,
        [EnumMember(Value = "MGA")]
        Mga,
        [EnumMember(Value = "MKD")]
        Mkd,
        [EnumMember(Value = "MMK")]
        Mmk,
        [EnumMember(Value = "MNT")]
        Mnt,
        [EnumMember(Value = "MOP")]
        Mop,
        [EnumMember(Value = "MRO")]
        Mro,
        [EnumMember(Value = "MUR")]
        Mur,
        [EnumMember(Value = "MVR")]
        Mvr,
        [EnumMember(Value = "MWK")]
        Mwk,
        [EnumMember(Value = "MXN")]
        Mxn,
        [EnumMember(Value = "MXV")]
        Mxv,
        [EnumMember(Value = "MYR")]
        Myr,
        [EnumMember(Value = "MZN")]
        Mzn,
        [EnumMember(Value = "NAD")]
        Nad,
        [EnumMember(Value = "NGN")]
        Ngn,
        [EnumMember(Value = "NIO")]
        Nio,
        [EnumMember(Value = "NOK")]
        Nok,
        [EnumMember(Value = "NPR")]
        Npr,
        [EnumMember(Value = "NZD")]
        Nzd,
        [EnumMember(Value = "OMR")]
        Omr,
        [EnumMember(Value = "PAB")]
        Pab,
        [EnumMember(Value = "PEN")]
        Pen,
        [EnumMember(Value = "PGK")]
        Pgk,
        [EnumMember(Value = "PHP")]
        Php,
        [EnumMember(Value = "PKR")]
        Pkr,
        [EnumMember(Value = "PLN")]
        Pln,
        [EnumMember(Value = "PYG")]
        Pyg,
        [EnumMember(Value = "QAR")]
        Qar,
        [EnumMember(Value = "RON")]
        Ron,
        [EnumMember(Value = "RSD")]
        Rsd,
        [EnumMember(Value = "RUB")]
        Rub,
        [EnumMember(Value = "RWF")]
        Rwf,
        [EnumMember(Value = "SAR")]
        Sar,
        [EnumMember(Value = "SBD")]
        Sbd,
        [EnumMember(Value = "SCR")]
        Scr,
        [EnumMember(Value = "SDG")]
        Sdg,
        [EnumMember(Value = "SEK")]
        Sek,
        [EnumMember(Value = "SGD")]
        Sgd,
        [EnumMember(Value = "SHP")]
        Shp,
        [EnumMember(Value = "SLL")]
        Sll,
        [EnumMember(Value = "SOS")]
        Sos,
        [EnumMember(Value = "SRD")]
        Srd,
        [EnumMember(Value = "SSP")]
        Ssp,
        [EnumMember(Value = "STD")]
        Std,
        [EnumMember(Value = "SVC")]
        Svc,
        [EnumMember(Value = "SYP")]
        Syp,
        [EnumMember(Value = "SZL")]
        Szl,
        [EnumMember(Value = "THB")]
        Thb,
        [EnumMember(Value = "TJS")]
        Tjs,
        [EnumMember(Value = "TMT")]
        Tmt,
        [EnumMember(Value = "TND")]
        Tnd,
        [EnumMember(Value = "TOP")]
        Top,
        [EnumMember(Value = "TRY")]
        Try,
        [EnumMember(Value = "TTD")]
        Ttd,
        [EnumMember(Value = "TWD")]
        Twd,
        [EnumMember(Value = "TZS")]
        Tzs,
        [EnumMember(Value = "UAH")]
        Uah,
        [EnumMember(Value = "UGX")]
        Ugx,
        [EnumMember(Value = "USD")]
        Usd,
        [EnumMember(Value = "USN")]
        Usn,
        [EnumMember(Value = "UYI")]
        Uyi,
        [EnumMember(Value = "UYU")]
        Uyu,
        [EnumMember(Value = "UZS")]
        Uzs,
        [EnumMember(Value = "VEF")]
        Vef,
        [EnumMember(Value = "VND")]
        Vnd,
        [EnumMember(Value = "VUV")]
        Vuv,
        [EnumMember(Value = "WST")]
        Wst,
        [EnumMember(Value = "XAF")]
        Xaf,
        [EnumMember(Value = "XAG")]
        Xag,
        [EnumMember(Value = "XAU")]
        Xau,
        [EnumMember(Value = "XBA")]
        Xba,
        [EnumMember(Value = "XBB")]
        Xbb,
        [EnumMember(Value = "XBC")]
        Xbc,
        [EnumMember(Value = "XBD")]
        Xbd,
        [EnumMember(Value = "XCD")]
        Xcd,
        [EnumMember(Value = "XDR")]
        Xdr,
        [EnumMember(Value = "XOF")]
        Xof,
        [EnumMember(Value = "XPD")]
        Xpd,
        [EnumMember(Value = "XPF")]
        Xpf,
        [EnumMember(Value = "XPT")]
        Xpt,
        [EnumMember(Value = "XSU")]
        Xsu,
        [EnumMember(Value = "XTS")]
        Xts,
        [EnumMember(Value = "XUA")]
        Xua,
        [EnumMember(Value = "XXX")]
        Xxx,
        [EnumMember(Value = "YER")]
        Yer,
        [EnumMember(Value = "ZAR")]
        Zar,
        [EnumMember(Value = "ZMW")]
        Zmw,
        [EnumMember(Value = "ZWL")]
        Zwl
    }

    public class Invoice
    {
        [JsonProperty("id")]
        public int InvoiceId { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("accountid")]
        public string AccountId { get; set; }

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
        public int CustomerId { get; set; }

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
        public int PaymentId { get; set; }

        [JsonProperty("type")]
        public string PaymentType { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("date")]
        public string PaymentDate { get; set; }

        [JsonProperty("clientid")]
        public int CustomerId { get; set; }

        [JsonProperty("amount")]
        public PaymentAmountType Amount { get; set; }

        [JsonProperty("accounting_systemid")]
        public string AccountId { get; set; }

        [JsonProperty("invoiceid")]
        public int InvoiceId { get; set; }

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
        public string UserName { get; set; }

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