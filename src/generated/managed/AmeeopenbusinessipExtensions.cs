//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ameeopenbusinessip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AmeeopenbusinessipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ameeopenbusinessip")]
        public IBodyWorkflowAction<GetCompaniesResponse> GetCompanies(Expression<Func<int>> limit = null, Expression<Func<int>> page = null, Expression<Func<string>> companyName = null, Expression<Func<int>> gupAmeeCompanyId = null, Expression<Func<bool>> isGup = null, Expression<Func<string>> city = null, Expression<Func<int>> postcode = null, Expression<Func<string>> provinceName = null, Expression<Func<string>> ukSic2007 = null, Expression<Func<int>> minEmployees = null, Expression<Func<int>> maxEmployees = null, Expression<Func<int>> minAnnualSalesLocal = null, Expression<Func<int>> maxAnnualSalesLocal = null, Expression<Func<int>> minScore = null, Expression<Func<int>> maxScore = null, Expression<Func<string>> fromLatLon = null, Expression<Func<int>> distance = null, Expression<Func<string>> stats = null)
        {
            var apiCallPath = "/companies";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (page != null)
                callPayload.Queries["page"] = CSharpExpressionConverter.ConvertO(page);
            if (companyName != null)
                callPayload.Queries["company_name"] = CSharpExpressionConverter.ConvertO(companyName);
            if (gupAmeeCompanyId != null)
                callPayload.Queries["gup_amee_company_id"] = CSharpExpressionConverter.ConvertO(gupAmeeCompanyId);
            if (isGup != null)
                callPayload.Queries["is_gup"] = CSharpExpressionConverter.ConvertO(isGup);
            if (city != null)
                callPayload.Queries["city"] = CSharpExpressionConverter.ConvertO(city);
            if (postcode != null)
                callPayload.Queries["postcode"] = CSharpExpressionConverter.ConvertO(postcode);
            if (provinceName != null)
                callPayload.Queries["province_name"] = CSharpExpressionConverter.ConvertO(provinceName);
            if (ukSic2007 != null)
                callPayload.Queries["uk_sic_2007"] = CSharpExpressionConverter.ConvertO(ukSic2007);
            if (minEmployees != null)
                callPayload.Queries["min_employees"] = CSharpExpressionConverter.ConvertO(minEmployees);
            if (maxEmployees != null)
                callPayload.Queries["max_employees"] = CSharpExpressionConverter.ConvertO(maxEmployees);
            if (minAnnualSalesLocal != null)
                callPayload.Queries["min_annual_sales_local"] = CSharpExpressionConverter.ConvertO(minAnnualSalesLocal);
            if (maxAnnualSalesLocal != null)
                callPayload.Queries["max_annual_sales_local"] = CSharpExpressionConverter.ConvertO(maxAnnualSalesLocal);
            if (minScore != null)
                callPayload.Queries["min_score"] = CSharpExpressionConverter.ConvertO(minScore);
            if (maxScore != null)
                callPayload.Queries["max_score"] = CSharpExpressionConverter.ConvertO(maxScore);
            if (fromLatLon != null)
                callPayload.Queries["from_lat_lon"] = CSharpExpressionConverter.ConvertO(fromLatLon);
            if (distance != null)
                callPayload.Queries["distance"] = CSharpExpressionConverter.ConvertO(distance);
            if (stats != null)
                callPayload.Queries["stats"] = CSharpExpressionConverter.ConvertO(stats);
            return new ApiConnectionAction<GetCompaniesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ameeopenbusinessip")]
        public IBodyWorkflowAction<GetCompanyResponse> GetCompany(Expression<Func<string>> id, Expression<Func<string>> type = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/companies/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (type != null)
                callPayload.Queries["type"] = CSharpExpressionConverter.ConvertO(type);
            return new ApiConnectionAction<GetCompanyResponse>(callPayload);
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