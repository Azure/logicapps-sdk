//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ameeopenbusinessip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AmeeopenbusinessipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ameeopenbusinessip")]
        public IBodyWorkflowAction<GetCompaniesResponse> GetCompanies(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> companyName = null, Expression<Func<int>> gupAmeeCompanyId = null, Expression<Func<bool>> isGup = null, Expression<Func<string>> city = null, Expression<Func<int>> postcode = null, Expression<Func<string>> provinceName = null, Expression<Func<string>> ukSic2007 = null, Expression<Func<int>> minEmployees = null, Expression<Func<int>> maxEmployees = null, Expression<Func<int>> minAnnualSalesLocal = null, Expression<Func<int>> maxAnnualSalesLocal = null, Expression<Func<int>> minScore = null, Expression<Func<int>> maxScore = null, Expression<Func<string>> fromLatLon = null, Expression<Func<int>> distance = null, Expression<Func<string>> stats = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_companyName = WorkflowExpression.Compile(companyName, nameof(companyName), required: false);
            var __workflow_gupAmeeCompanyId = WorkflowExpression.Compile(gupAmeeCompanyId, nameof(gupAmeeCompanyId), required: false);
            var __workflow_isGup = WorkflowExpression.Compile(isGup, nameof(isGup), required: false);
            var __workflow_city = WorkflowExpression.Compile(city, nameof(city), required: false);
            var __workflow_postcode = WorkflowExpression.Compile(postcode, nameof(postcode), required: false);
            var __workflow_provinceName = WorkflowExpression.Compile(provinceName, nameof(provinceName), required: false);
            var __workflow_ukSic2007 = WorkflowExpression.Compile(ukSic2007, nameof(ukSic2007), required: false);
            var __workflow_minEmployees = WorkflowExpression.Compile(minEmployees, nameof(minEmployees), required: false);
            var __workflow_maxEmployees = WorkflowExpression.Compile(maxEmployees, nameof(maxEmployees), required: false);
            var __workflow_minAnnualSalesLocal = WorkflowExpression.Compile(minAnnualSalesLocal, nameof(minAnnualSalesLocal), required: false);
            var __workflow_maxAnnualSalesLocal = WorkflowExpression.Compile(maxAnnualSalesLocal, nameof(maxAnnualSalesLocal), required: false);
            var __workflow_minScore = WorkflowExpression.Compile(minScore, nameof(minScore), required: false);
            var __workflow_maxScore = WorkflowExpression.Compile(maxScore, nameof(maxScore), required: false);
            var __workflow_fromLatLon = WorkflowExpression.Compile(fromLatLon, nameof(fromLatLon), required: false);
            var __workflow_distance = WorkflowExpression.Compile(distance, nameof(distance), required: false);
            var __workflow_stats = WorkflowExpression.Compile(stats, nameof(stats), required: false);
            return new DeferredBodyAction<GetCompaniesResponse>(() =>
            {
                var apiCallPath = "/companies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_companyName != null)
                    callPayload.Queries["company_name"] = ExpressionConverter.Convert(__workflow_companyName);
                if (__workflow_gupAmeeCompanyId != null)
                    callPayload.Queries["gup_amee_company_id"] = ExpressionConverter.Convert(__workflow_gupAmeeCompanyId);
                if (__workflow_isGup != null)
                    callPayload.Queries["is_gup"] = ExpressionConverter.Convert(__workflow_isGup);
                if (__workflow_city != null)
                    callPayload.Queries["city"] = ExpressionConverter.Convert(__workflow_city);
                if (__workflow_postcode != null)
                    callPayload.Queries["postcode"] = ExpressionConverter.Convert(__workflow_postcode);
                if (__workflow_provinceName != null)
                    callPayload.Queries["province_name"] = ExpressionConverter.Convert(__workflow_provinceName);
                if (__workflow_ukSic2007 != null)
                    callPayload.Queries["uk_sic_2007"] = ExpressionConverter.Convert(__workflow_ukSic2007);
                if (__workflow_minEmployees != null)
                    callPayload.Queries["min_employees"] = ExpressionConverter.Convert(__workflow_minEmployees);
                if (__workflow_maxEmployees != null)
                    callPayload.Queries["max_employees"] = ExpressionConverter.Convert(__workflow_maxEmployees);
                if (__workflow_minAnnualSalesLocal != null)
                    callPayload.Queries["min_annual_sales_local"] = ExpressionConverter.Convert(__workflow_minAnnualSalesLocal);
                if (__workflow_maxAnnualSalesLocal != null)
                    callPayload.Queries["max_annual_sales_local"] = ExpressionConverter.Convert(__workflow_maxAnnualSalesLocal);
                if (__workflow_minScore != null)
                    callPayload.Queries["min_score"] = ExpressionConverter.Convert(__workflow_minScore);
                if (__workflow_maxScore != null)
                    callPayload.Queries["max_score"] = ExpressionConverter.Convert(__workflow_maxScore);
                if (__workflow_fromLatLon != null)
                    callPayload.Queries["from_lat_lon"] = ExpressionConverter.Convert(__workflow_fromLatLon);
                if (__workflow_distance != null)
                    callPayload.Queries["distance"] = ExpressionConverter.Convert(__workflow_distance);
                if (__workflow_stats != null)
                    callPayload.Queries["stats"] = ExpressionConverter.Convert(__workflow_stats);
                return new ApiConnectionAction<GetCompaniesResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ameeopenbusinessip")]
        public IBodyWorkflowAction<GetCompanyResponse> GetCompany(Expression<Func<string>> id, Expression<Func<string>> type = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            return new DeferredBodyAction<GetCompanyResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/companies/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<GetCompanyResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
