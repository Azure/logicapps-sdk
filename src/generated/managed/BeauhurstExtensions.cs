//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Beauhurst
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BeauhurstActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "beauhurst")]
        [WorkflowExpressionFactory(nameof(__BuildGetCompanyFid))]
        public IBodyWorkflowAction<GetCompanyFidResponse> GetCompanyFid([WorkflowExpression] Func<string> names)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCompanyFidResponse> __BuildGetCompanyFid(WorkflowValue<string> names)
        {
            WorkflowValue.Validate(names, nameof(names), required: true);
            return new DeferredBodyAction<GetCompanyFidResponse>(() =>
            {
                var apiCallPath = "/_api/v1/companies/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["names"] = ExpressionConverter.Convert(names);
                return new ApiConnectionAction<GetCompanyFidResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "beauhurst")]
        [WorkflowExpressionFactory(nameof(__BuildCompanyInfoByFID))]
        public IBodyWorkflowAction<CompanyInfoByFIDResponse> CompanyInfoByFID([WorkflowExpression] Func<string> fID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompanyInfoByFIDResponse> __BuildCompanyInfoByFID(WorkflowValue<string> fID)
        {
            WorkflowValue.Validate(fID, nameof(fID), required: true);
            return new DeferredBodyAction<CompanyInfoByFIDResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/_api/v1/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(fID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includes"] = Convert.ToString("registered_name&includes=registration_date&includes=other_trading_names&includes=companies_house_id&includes=employee_count_range&includes=last_modified_date&includes=website&includes=tracked_status&includes=company_status&includes=is_sme&includes=sectors&includes=top_level_sector_groups&includes=latest_stage_of_evolution&includes=description&includes=tracking_reasons&includes=target_markets&includes=founder_female_percentage&includes=sic_codes&includes=actively_hiring&includes=n_fundraisings&includes=total_amount_fundraisings&includes=n_grants&includes=total_amount_grants&includes=latest_valuation&includes=country&includes=lep&includes=region&includes=postcode&includes=address&includes=emails&includes=telephone&includes=key_contacts&includes=year_end_date&includes=turnover&includes=ebitda&includes=total_assets&includes=number_of_employees&includes=cash&includes=total_liabilities&includes=net_assets");
                return new ApiConnectionAction<CompanyInfoByFIDResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "beauhurst")]
        [WorkflowExpressionFactory(nameof(__BuildFundsByFID))]
        public IBodyWorkflowAction<FundsByFIDResponse> FundsByFID([WorkflowExpression] Func<string> companyIds, [WorkflowExpression] Func<includesInput> includes)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FundsByFIDResponse> __BuildFundsByFID(WorkflowValue<string> companyIds, WorkflowValue<includesInput> includes)
        {
            WorkflowValue.Validate(companyIds, nameof(companyIds), required: true);
            WorkflowValue.Validate(includes, nameof(includes), required: true);
            return new DeferredBodyAction<FundsByFIDResponse>(() =>
            {
                var apiCallPath = "/_api/v1/transactions/company";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_ids"] = ExpressionConverter.Convert(companyIds);
                callPayload.Queries["includes"] = ExpressionConverter.Convert(includes);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<FundsByFIDResponse>(callPayload);
            });
        }
    }

    public class BeauhurstTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCompanyFidResponse
    {
        [JsonProperty("meta")]
        public GetCompanyFidResponseMetaType Meta { get; set; }

        [JsonProperty("results")]
        public GetCompanyFidResponseResultsTypeItem[] Results { get; set; }
    }

    public class GetCompanyFidResponseMetaType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class GetCompanyFidResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CompanyInfoByFIDResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("basic")]
        public CompanyInfoByFIDResponseBasicType Basic { get; set; }

        [JsonProperty("classification")]
        public CompanyInfoByFIDResponseClassificationType Classification { get; set; }

        [JsonProperty("transactions")]
        public CompanyInfoByFIDResponseTransactionsType Transactions { get; set; }

        [JsonProperty("contact_information")]
        public CompanyInfoByFIDResponseContactInformationType ContactInformation { get; set; }

        [JsonProperty("latest_accounts")]
        public CompanyInfoByFIDResponseLatestAccountsType LatestAccounts { get; set; }

        [JsonProperty("historic_accounts")]
        public CompanyInfoByFIDResponseHistoricAccountsTypeItem[] HistoricAccounts { get; set; }
    }

    public class CompanyInfoByFIDResponseBasicType
    {
        [JsonProperty("registered_name")]
        public string RegisteredName { get; set; }

        [JsonProperty("registration_date")]
        public string RegistrationDate { get; set; }

        [JsonProperty("other_trading_names")]
        public JToken[] OtherTradingNames { get; set; }

        [JsonProperty("companies_house_id")]
        public string CompaniesHouseId { get; set; }

        [JsonProperty("employee_count_range")]
        public string EmployeeCountRange { get; set; }

        [JsonProperty("last_modified_date")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("tracked_status")]
        public string TrackedStatus { get; set; }

        [JsonProperty("company_status")]
        public string CompanyStatus { get; set; }

        [JsonProperty("is_sme")]
        public bool IsSme { get; set; }
    }

    public class CompanyInfoByFIDResponseClassificationType
    {
        [JsonProperty("sectors")]
        public string[] Sectors { get; set; }

        [JsonProperty("top_level_sector_groups")]
        public string[] TopLevelSectorGroups { get; set; }

        [JsonProperty("latest_stage_of_evolution")]
        public string LatestStageOfEvolution { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tracking_reasons")]
        public JToken[] TrackingReasons { get; set; }

        [JsonProperty("target_markets")]
        public string[] TargetMarkets { get; set; }

        [JsonProperty("founder_female_percentage")]
        public string FounderFemalePercentage { get; set; }

        [JsonProperty("sic_codes")]
        public CompanyInfoByFIDResponseClassificationTypeSicCodesTypeItem[] SicCodes { get; set; }

        [JsonProperty("actively_hiring")]
        public string ActivelyHiring { get; set; }
    }

    public class CompanyInfoByFIDResponseClassificationTypeSicCodesTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CompanyInfoByFIDResponseTransactionsType
    {
        [JsonProperty("n_fundraisings")]
        public int NFundraisings { get; set; }

        [JsonProperty("total_amount_fundraisings")]
        public int TotalAmountFundraisings { get; set; }

        [JsonProperty("n_grants")]
        public int NGrants { get; set; }

        [JsonProperty("total_amount_grants")]
        public int TotalAmountGrants { get; set; }

        [JsonProperty("latest_valuation")]
        public string LatestValuation { get; set; }
    }

    public class CompanyInfoByFIDResponseContactInformationType
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("lep")]
        public string Lep { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("emails")]
        public JToken[] Emails { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("key_contacts")]
        public JToken[] KeyContacts { get; set; }
    }

    public class CompanyInfoByFIDResponseLatestAccountsType
    {
        [JsonProperty("year_end_date")]
        public string YearEndDate { get; set; }

        [JsonProperty("turnover")]
        public int Turnover { get; set; }

        [JsonProperty("ebitda")]
        public int Ebitda { get; set; }

        [JsonProperty("total_assets")]
        public int TotalAssets { get; set; }

        [JsonProperty("number_of_employees")]
        public int NumberOfEmployees { get; set; }

        [JsonProperty("cash")]
        public int Cash { get; set; }

        [JsonProperty("total_liabilities")]
        public int TotalLiabilities { get; set; }

        [JsonProperty("net_assets")]
        public int NetAssets { get; set; }
    }

    public class CompanyInfoByFIDResponseHistoricAccountsTypeItem
    {
        [JsonProperty("year_end_date")]
        public string YearEndDate { get; set; }

        [JsonProperty("turnover")]
        public int Turnover { get; set; }

        [JsonProperty("ebitda")]
        public int Ebitda { get; set; }

        [JsonProperty("total_assets")]
        public int TotalAssets { get; set; }

        [JsonProperty("number_of_employees")]
        public int NumberOfEmployees { get; set; }

        [JsonProperty("cash")]
        public int Cash { get; set; }

        [JsonProperty("total_liabilities")]
        public int TotalLiabilities { get; set; }

        [JsonProperty("net_assets")]
        public int NetAssets { get; set; }
    }

    public class FundsByFIDResponse
    {
        [JsonProperty("meta")]
        public FundsByFIDResponseMetaType Meta { get; set; }

        [JsonProperty("results")]
        public FundsByFIDResponseResultsTypeItem[] Results { get; set; }
    }

    public class FundsByFIDResponseMetaType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public class FundsByFIDResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("companies_house_id")]
        public string CompaniesHouseId { get; set; }

        [JsonProperty("grants")]
        public FundsByFIDResponseResultsTypeItemGrantsTypeItem[] Grants { get; set; }
    }

    public class FundsByFIDResponseResultsTypeItemGrantsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date_grant_recieved")]
        public string DateGrantRecieved { get; set; }

        [JsonProperty("amount_recieved_gbp")]
        public int AmountRecievedGbp { get; set; }

        [JsonProperty("stage_of_evolution_at_grant_date")]
        public string StageOfEvolutionAtGrantDate { get; set; }

        [JsonProperty("beauhurst_url")]
        public string BeauhurstUrl { get; set; }

        [JsonProperty("is_lead_participant")]
        public bool IsLeadParticipant { get; set; }

        [JsonProperty("project_title")]
        public string ProjectTitle { get; set; }

        [JsonProperty("project_start_date")]
        public string ProjectStartDate { get; set; }

        [JsonProperty("project_end_date")]
        public string ProjectEndDate { get; set; }

        [JsonProperty("project_grants_total_gbp")]
        public int ProjectGrantsTotalGbp { get; set; }

        [JsonProperty("granting_body")]
        public string GrantingBody { get; set; }
    }

    public enum includesInput
    {
        [EnumMember(Value = "grants")]
        Grants,
        [EnumMember(Value = "fundraisings")]
        Fundraisings
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Beauhurst;

    public partial class WorkflowManagedActions
    {
        public BeauhurstActions Beauhurst(string connectionId) => new BeauhurstActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BeauhurstTriggers Beauhurst(string connectionId) => new BeauhurstTriggers(connectionId);
    }
}
