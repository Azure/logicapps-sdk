//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pappers
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PappersActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pappers")]
        public IBodyWorkflowAction<CompanyFormat> CompanyGet([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> companyNumber, [WorkflowExpression] Func<fieldsInput> fields = null)
        {
            var apiCallPath = "/company";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
            callPayload.Queries["company_number"] = ExpressionConverter.Convert(companyNumber);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            return new ApiConnectionAction<CompanyFormat>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pappers")]
        public IBodyWorkflowAction<SearchResponse> SearchGet([WorkflowExpression] Func<countryCodeInput> countryCode, [WorkflowExpression] Func<string> q, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            var apiCallPath = "/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
            callPayload.Queries["q"] = ExpressionConverter.Convert(q);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["per_page"] = Convert.ToString(10);
            if (perPage != null)
                callPayload.Queries["per_page"] = ExpressionConverter.Convert(perPage);
            return new ApiConnectionAction<SearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pappers")]
        public IBodyWorkflowAction<DocumentGetResponse> DocumentGet([WorkflowExpression] Func<string> token)
        {
            var apiCallPath = "/download-file";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["token"] = ExpressionConverter.Convert(token);
            return new ApiConnectionAction<DocumentGetResponse>(callPayload);
        }
    }

    public class PappersTriggers([ConnectionName] string connectionId)
    {
    }

    public class CompanyFormat
    {
        [JsonProperty("company_number")]
        public string CompanyNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("trade_name")]
        public string TradeName { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("vat_number")]
        public string VatNumber { get; set; }

        [JsonProperty("local_legal_form_code")]
        public string LocalLegalFormCode { get; set; }

        [JsonProperty("local_legal_form_name")]
        public string LocalLegalFormName { get; set; }

        [JsonProperty("activities")]
        public Activity[] Activities { get; set; }

        [JsonProperty("fields_of_activity")]
        public string[] FieldsOfActivity { get; set; }

        [JsonProperty("local_activities")]
        public LocalActivity[] LocalActivities { get; set; }

        [JsonProperty("date_of_creation")]
        public string DateOfCreation { get; set; }

        [JsonProperty("status")]
        public CompanyFormatStatusType Status { get; set; }

        [JsonProperty("date_of_cessation")]
        public string DateOfCessation { get; set; }

        [JsonProperty("workforce")]
        public int Workforce { get; set; }

        [JsonProperty("workforce_range")]
        public string WorkforceRange { get; set; }

        [JsonProperty("head_office")]
        public CompanyFormatHeadOfficeType HeadOffice { get; set; }

        [JsonProperty("commercial_register_registration_status")]
        public CompanyFormatCommercialRegisterRegistrationStatusType CommercialRegisterRegistrationStatus { get; set; }

        [JsonProperty("commercial_register_registration_location")]
        public string CommercialRegisterRegistrationLocation { get; set; }

        [JsonProperty("commercial_register_registration_date")]
        public string CommercialRegisterRegistrationDate { get; set; }

        [JsonProperty("commercial_register_cessation_date")]
        public string CommercialRegisterCessationDate { get; set; }

        [JsonProperty("share_capital")]
        public int ShareCapital { get; set; }

        [JsonProperty("share_capital_currency")]
        public string ShareCapitalCurrency { get; set; }

        [JsonProperty("next_fiscal_year_end")]
        public string NextFiscalYearEnd { get; set; }

        [JsonProperty("fiscal_year_end")]
        public string FiscalYearEnd { get; set; }

        [JsonProperty("officers")]
        public Officer[] Officers { get; set; }

        [JsonProperty("ubos")]
        public Ubo[] Ubos { get; set; }

        [JsonProperty("financials")]
        public Financial[] Financials { get; set; }

        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        [JsonProperty("certificates")]
        public Certificate[] Certificates { get; set; }

        [JsonProperty("publications")]
        public Publication[] Publications { get; set; }

        [JsonProperty("establishments")]
        public Establishment[] Establishments { get; set; }

        [JsonProperty("contacts")]
        public Contact[] Contacts { get; set; }
    }

    public class Activity
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class LocalActivity
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }
    }

    public enum CompanyFormatStatusType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    public class CompanyFormatHeadOfficeType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
    }

    public enum CompanyFormatCommercialRegisterRegistrationStatusType
    {
        [EnumMember(Value = "registered")]
        Registered,
        [EnumMember(Value = "not_registered")]
        NotRegistered,
        [EnumMember(Value = "removed")]
        Removed,
        [EnumMember(Value = "unknown")]
        Unknown
    }

    public class Officer
    {
        [JsonProperty("type")]
        public OfficerTypeType Type { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("date_of_appointment")]
        public string DateOfAppointment { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("gender")]
        public OfficerGenderType Gender { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("date_of_birth_format")]
        public string DateOfBirthFormat { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("nationality_code")]
        public string NationalityCode { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("company_number")]
        public string CompanyNumber { get; set; }

        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
    }

    public enum OfficerTypeType
    {
        [EnumMember(Value = "legal")]
        Legal,
        [EnumMember(Value = "physical")]
        Physical
    }

    public enum OfficerGenderType
    {
        M,
        F
    }

    public class Ubo
    {
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("gender")]
        public UboGenderType Gender { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("date_of_birth_format")]
        public string DateOfBirthFormat { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("nationality_code")]
        public string NationalityCode { get; set; }

        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("percentage_of_shares")]
        public string PercentageOfShares { get; set; }

        [JsonProperty("voting_percentage")]
        public string VotingPercentage { get; set; }
    }

    public enum UboGenderType
    {
        M,
        F
    }

    public class Financial
    {
        [JsonProperty("type")]
        public FinancialTypeType Type { get; set; }

        [JsonProperty("financials_start_date")]
        public string FinancialsStartDate { get; set; }

        [JsonProperty("financials_end_date")]
        public string FinancialsEndDate { get; set; }

        [JsonProperty("deposit_date")]
        public string DepositDate { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("availability")]
        public FinancialAvailabilityType Availability { get; set; }

        [JsonProperty("ratios")]
        public Ratios Ratios { get; set; }

        [JsonProperty("related_documents")]
        public RelatedDocument[] RelatedDocuments { get; set; }
    }

    public enum FinancialTypeType
    {
        [EnumMember(Value = "accounts")]
        Accounts,
        [EnumMember(Value = "consolidated_accounts")]
        ConsolidatedAccounts
    }

    public enum FinancialAvailabilityType
    {
        [EnumMember(Value = "available")]
        Available,
        [EnumMember(Value = "unavailable")]
        Unavailable,
        [EnumMember(Value = "confidential")]
        Confidential,
        [EnumMember(Value = "partially-confidential")]
        PartiallyConfidential
    }

    public class Ratios
    {
        [JsonProperty("turnover")]
        public double Turnover { get; set; }

        [JsonProperty("gross_profit")]
        public double GrossProfit { get; set; }

        [JsonProperty("ebitda")]
        public double Ebitda { get; set; }

        [JsonProperty("operating_profit")]
        public double OperatingProfit { get; set; }

        [JsonProperty("net_income")]
        public double NetIncome { get; set; }

        [JsonProperty("revenue_growth_rate")]
        public double RevenueGrowthRate { get; set; }

        [JsonProperty("gross_margin_rate")]
        public double GrossMarginRate { get; set; }

        [JsonProperty("ebitda_margin")]
        public double EbitdaMargin { get; set; }

        [JsonProperty("ebit_margin")]
        public double EbitMargin { get; set; }

        [JsonProperty("working_capital_requirements")]
        public double WorkingCapitalRequirements { get; set; }

        [JsonProperty("day_sales_outstanding")]
        public double DaySalesOutstanding { get; set; }

        [JsonProperty("days_payable_outstanding")]
        public double DaysPayableOutstanding { get; set; }

        [JsonProperty("cash_flow_from_operations")]
        public double CashFlowFromOperations { get; set; }

        [JsonProperty("net_working_capital")]
        public double NetWorkingCapital { get; set; }

        [JsonProperty("cash")]
        public double Cash { get; set; }

        [JsonProperty("financial_debt")]
        public double FinancialDebt { get; set; }

        [JsonProperty("net_financial_debt")]
        public double NetFinancialDebt { get; set; }

        [JsonProperty("capital_debt_repayment_capacity")]
        public double CapitalDebtRepaymentCapacity { get; set; }

        [JsonProperty("gearing_ratio")]
        public double GearingRatio { get; set; }

        [JsonProperty("leverage_ratio")]
        public double LeverageRatio { get; set; }

        [JsonProperty("debts_payable_within_one_year")]
        public double DebtsPayableWithinOneYear { get; set; }

        [JsonProperty("debt_coverage_ratio")]
        public double DebtCoverageRatio { get; set; }

        [JsonProperty("equity")]
        public double Equity { get; set; }

        [JsonProperty("net_margin")]
        public double NetMargin { get; set; }

        [JsonProperty("return_on_equity")]
        public double ReturnOnEquity { get; set; }

        [JsonProperty("value_added_ratio")]
        public double ValueAddedRatio { get; set; }

        [JsonProperty("export_turnover")]
        public double ExportTurnover { get; set; }
    }

    public class RelatedDocument
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("file_available")]
        public bool FileAvailable { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("file_token")]
        public string FileToken { get; set; }

        [JsonProperty("file_format")]
        public string FileFormat { get; set; }
    }

    public class Document
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("file_available")]
        public bool FileAvailable { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("file_token")]
        public string FileToken { get; set; }

        [JsonProperty("file_format")]
        public string FileFormat { get; set; }
    }

    public class Certificate
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("file_available")]
        public bool FileAvailable { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("file_token")]
        public string FileToken { get; set; }

        [JsonProperty("file_format")]
        public string FileFormat { get; set; }
    }

    public class Publication
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class Establishment
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("trade_name")]
        public string TradeName { get; set; }

        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("activities")]
        public Activity[] Activities { get; set; }

        [JsonProperty("fields_of_activity")]
        public string[] FieldsOfActivity { get; set; }

        [JsonProperty("local_activities")]
        public LocalActivity[] LocalActivities { get; set; }

        [JsonProperty("date_of_creation")]
        public string DateOfCreation { get; set; }

        [JsonProperty("status")]
        public EstablishmentStatusType Status { get; set; }

        [JsonProperty("date_of_cessation")]
        public string DateOfCessation { get; set; }

        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public enum EstablishmentStatusType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    public class Contact
    {
        [JsonProperty("type")]
        public ContactTypeType Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum ContactTypeType
    {
        [EnumMember(Value = "website")]
        Website,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "phone")]
        Phone
    }

    public enum countryCodeInput
    {
        UK,
        FR,
        BE,
        CH
    }

    public enum fieldsInput
    {
        [EnumMember(Value = "officers")]
        Officers,
        [EnumMember(Value = "ubos")]
        Ubos,
        [EnumMember(Value = "financials")]
        Financials,
        [EnumMember(Value = "documents")]
        Documents,
        [EnumMember(Value = "certificates")]
        Certificates,
        [EnumMember(Value = "publications")]
        Publications,
        [EnumMember(Value = "establishments")]
        Establishments,
        [EnumMember(Value = "contacts")]
        Contacts
    }

    public class SearchResponse
    {
        [JsonProperty("results")]
        public SearchFormat[] Results { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }
    }

    public class SearchFormat
    {
        [JsonProperty("company_number")]
        public string CompanyNumber { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("local_legal_form_code")]
        public string LocalLegalFormCode { get; set; }

        [JsonProperty("local_legal_form_name")]
        public string LocalLegalFormName { get; set; }

        [JsonProperty("activities")]
        public Activity[] Activities { get; set; }

        [JsonProperty("local_activities")]
        public LocalActivity[] LocalActivities { get; set; }

        [JsonProperty("date_of_creation")]
        public string DateOfCreation { get; set; }

        [JsonProperty("status")]
        public SearchFormatStatusType Status { get; set; }

        [JsonProperty("date_of_cessation")]
        public string DateOfCessation { get; set; }

        [JsonProperty("head_office")]
        public SearchFormatHeadOfficeType HeadOffice { get; set; }
    }

    public enum SearchFormatStatusType
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "inactive")]
        Inactive
    }

    public class SearchFormatHeadOfficeType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
    }

    public class DocumentGetResponse
    {
        [JsonProperty("$content-type")]
        public string ContentType { get; set; }

        [JsonProperty("$content")]
        public string Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pappers;

    public partial class WorkflowManagedActions
    {
        public PappersActions Pappers(string connectionId) => new PappersActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PappersTriggers Pappers(string connectionId) => new PappersTriggers(connectionId);
    }
}