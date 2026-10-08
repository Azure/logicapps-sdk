//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ameeopenbusinessip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AmeeopenbusinessipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ameeopenbusinessip")]
        [WorkflowExpressionFactory(nameof(__BuildGetCompanies))]
        public IBodyWorkflowAction<GetCompaniesResponse> GetCompanies([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> companyName = null, [WorkflowExpression] Func<int> gupAmeeCompanyId = null, [WorkflowExpression] Func<bool> isGup = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<int> postcode = null, [WorkflowExpression] Func<string> provinceName = null, [WorkflowExpression] Func<string> ukSic2007 = null, [WorkflowExpression] Func<int> minEmployees = null, [WorkflowExpression] Func<int> maxEmployees = null, [WorkflowExpression] Func<int> minAnnualSalesLocal = null, [WorkflowExpression] Func<int> maxAnnualSalesLocal = null, [WorkflowExpression] Func<int> minScore = null, [WorkflowExpression] Func<int> maxScore = null, [WorkflowExpression] Func<string> fromLatLon = null, [WorkflowExpression] Func<int> distance = null, [WorkflowExpression] Func<string> stats = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCompaniesResponse> __BuildGetCompanies(WorkflowExpression<int> limit = null, WorkflowExpression<int> page = null, WorkflowExpression<string> companyName = null, WorkflowExpression<int> gupAmeeCompanyId = null, WorkflowExpression<bool> isGup = null, WorkflowExpression<string> city = null, WorkflowExpression<int> postcode = null, WorkflowExpression<string> provinceName = null, WorkflowExpression<string> ukSic2007 = null, WorkflowExpression<int> minEmployees = null, WorkflowExpression<int> maxEmployees = null, WorkflowExpression<int> minAnnualSalesLocal = null, WorkflowExpression<int> maxAnnualSalesLocal = null, WorkflowExpression<int> minScore = null, WorkflowExpression<int> maxScore = null, WorkflowExpression<string> fromLatLon = null, WorkflowExpression<int> distance = null, WorkflowExpression<string> stats = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(companyName, nameof(companyName), required: false);
            WorkflowExpression.Validate(gupAmeeCompanyId, nameof(gupAmeeCompanyId), required: false);
            WorkflowExpression.Validate(isGup, nameof(isGup), required: false);
            WorkflowExpression.Validate(city, nameof(city), required: false);
            WorkflowExpression.Validate(postcode, nameof(postcode), required: false);
            WorkflowExpression.Validate(provinceName, nameof(provinceName), required: false);
            WorkflowExpression.Validate(ukSic2007, nameof(ukSic2007), required: false);
            WorkflowExpression.Validate(minEmployees, nameof(minEmployees), required: false);
            WorkflowExpression.Validate(maxEmployees, nameof(maxEmployees), required: false);
            WorkflowExpression.Validate(minAnnualSalesLocal, nameof(minAnnualSalesLocal), required: false);
            WorkflowExpression.Validate(maxAnnualSalesLocal, nameof(maxAnnualSalesLocal), required: false);
            WorkflowExpression.Validate(minScore, nameof(minScore), required: false);
            WorkflowExpression.Validate(maxScore, nameof(maxScore), required: false);
            WorkflowExpression.Validate(fromLatLon, nameof(fromLatLon), required: false);
            WorkflowExpression.Validate(distance, nameof(distance), required: false);
            WorkflowExpression.Validate(stats, nameof(stats), required: false);
            return new DeferredBodyAction<GetCompaniesResponse>(() =>
            {
                var apiCallPath = "/companies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (companyName != null)
                    callPayload.Queries["company_name"] = ExpressionConverter.Convert(companyName);
                if (gupAmeeCompanyId != null)
                    callPayload.Queries["gup_amee_company_id"] = ExpressionConverter.Convert(gupAmeeCompanyId);
                if (isGup != null)
                    callPayload.Queries["is_gup"] = ExpressionConverter.Convert(isGup);
                if (city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(city);
                if (postcode != null)
                    callPayload.Queries["postcode"] = ExpressionConverter.Convert(postcode);
                if (provinceName != null)
                    callPayload.Queries["province_name"] = ExpressionConverter.Convert(provinceName);
                if (ukSic2007 != null)
                    callPayload.Queries["uk_sic_2007"] = ExpressionConverter.Convert(ukSic2007);
                if (minEmployees != null)
                    callPayload.Queries["min_employees"] = ExpressionConverter.Convert(minEmployees);
                if (maxEmployees != null)
                    callPayload.Queries["max_employees"] = ExpressionConverter.Convert(maxEmployees);
                if (minAnnualSalesLocal != null)
                    callPayload.Queries["min_annual_sales_local"] = ExpressionConverter.Convert(minAnnualSalesLocal);
                if (maxAnnualSalesLocal != null)
                    callPayload.Queries["max_annual_sales_local"] = ExpressionConverter.Convert(maxAnnualSalesLocal);
                if (minScore != null)
                    callPayload.Queries["min_score"] = ExpressionConverter.Convert(minScore);
                if (maxScore != null)
                    callPayload.Queries["max_score"] = ExpressionConverter.Convert(maxScore);
                if (fromLatLon != null)
                    callPayload.Queries["from_lat_lon"] = ExpressionConverter.Convert(fromLatLon);
                if (distance != null)
                    callPayload.Queries["distance"] = ExpressionConverter.Convert(distance);
                if (stats != null)
                    callPayload.Queries["stats"] = ExpressionConverter.Convert(stats);
                return new ApiConnectionAction<GetCompaniesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ameeopenbusinessip")]
        [WorkflowExpressionFactory(nameof(__BuildGetCompany))]
        public IBodyWorkflowAction<GetCompanyResponse> GetCompany([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> type = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCompanyResponse> __BuildGetCompany(WorkflowExpression<string> id, WorkflowExpression<string> type = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            return new DeferredBodyAction<GetCompanyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/companies/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<GetCompanyResponse>(callPayload);
            });
        }
    }

    public class AmeeopenbusinessipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetCompaniesResponse
    {
        [JsonProperty("companies")]
        public CompanyModel[] Companies { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class CompanyModel
    {
        [JsonProperty("amee_company_id")]
        public string AmeeCompanyId { get; set; }

        [JsonProperty("gup_amee_company_id")]
        public string GupAmeeCompanyId { get; set; }

        [JsonProperty("is_gup")]
        public bool IsGup { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amee_industry_score")]
        public int AmeeIndustryScore { get; set; }

        [JsonProperty("amee_score_status")]
        public string AmeeScoreStatus { get; set; }

        [JsonProperty("annual_sales_local")]
        public int AnnualSalesLocal { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("emissions_scope1_tco2e")]
        public string EmissionsScope1Tco2e { get; set; }

        [JsonProperty("emissions_scope2_tco2e")]
        public string EmissionsScope2Tco2e { get; set; }

        [JsonProperty("emissions_status")]
        public string EmissionsStatus { get; set; }

        [JsonProperty("emissions_total_tco2e")]
        public int EmissionsTotalTco2e { get; set; }

        [JsonProperty("employees_total")]
        public int EmployeesTotal { get; set; }

        [JsonProperty("uk_sic_2007")]
        public int UkSic2007 { get; set; }

        [JsonProperty("national_identification_number")]
        public string NationalIdentificationNumber { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("province_name")]
        public string ProvinceName { get; set; }

        [JsonProperty("street_address_1")]
        public string StreetAddress1 { get; set; }

        [JsonProperty("street_address_2")]
        public string StreetAddress2 { get; set; }

        [JsonProperty("street_address_3")]
        public string StreetAddress3 { get; set; }

        [JsonProperty("street_address_4")]
        public string StreetAddress4 { get; set; }

        [JsonProperty("sustainability_report_url")]
        public string SustainabilityReportUrl { get; set; }

        [JsonProperty("sustainability_report_year")]
        public string SustainabilityReportYear { get; set; }

        [JsonProperty("total_assets_local")]
        public string TotalAssetsLocal { get; set; }

        [JsonProperty("waste_hazardous_kg")]
        public string WasteHazardousKg { get; set; }

        [JsonProperty("waste_non_hazardous_kg")]
        public string WasteNonHazardousKg { get; set; }

        [JsonProperty("waste_status")]
        public string WasteStatus { get; set; }

        [JsonProperty("water_status")]
        public string WaterStatus { get; set; }

        [JsonProperty("water_withdrawn_l")]
        public string WaterWithdrawnL { get; set; }

        [JsonProperty("amee_industry_score_icon")]
        public string AmeeIndustryScoreIcon { get; set; }

        [JsonProperty("line_of_business")]
        public string LineOfBusiness { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("trading_status")]
        public string TradingStatus { get; set; }
    }

    public class GetCompanyResponse
    {
        [JsonProperty("company")]
        public CompanyModel Company { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ameeopenbusinessip;

    public partial class WorkflowManagedActions
    {
        public AmeeopenbusinessipActions Ameeopenbusinessip(string connectionId) => new AmeeopenbusinessipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AmeeopenbusinessipTriggers Ameeopenbusinessip(string connectionId) => new AmeeopenbusinessipTriggers(connectionId);
    }
}