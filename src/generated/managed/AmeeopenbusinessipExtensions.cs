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
        public IBodyWorkflowAction<GetCompaniesResponse> GetCompanies([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> companyName = null, [WorkflowExpression] Func<int> gupAmeeCompanyId = null, [WorkflowExpression] Func<bool> isGup = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<int> postcode = null, [WorkflowExpression] Func<string> provinceName = null, [WorkflowExpression] Func<string> ukSic2007 = null, [WorkflowExpression] Func<int> minEmployees = null, [WorkflowExpression] Func<int> maxEmployees = null, [WorkflowExpression] Func<int> minAnnualSalesLocal = null, [WorkflowExpression] Func<int> maxAnnualSalesLocal = null, [WorkflowExpression] Func<int> minScore = null, [WorkflowExpression] Func<int> maxScore = null, [WorkflowExpression] Func<string> fromLatLon = null, [WorkflowExpression] Func<int> distance = null, [WorkflowExpression] Func<string> stats = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(companyName, nameof(companyName), required: false);
            SourceExpression.Validate(gupAmeeCompanyId, nameof(gupAmeeCompanyId), required: false);
            SourceExpression.Validate(isGup, nameof(isGup), required: false);
            SourceExpression.Validate(city, nameof(city), required: false);
            SourceExpression.Validate(postcode, nameof(postcode), required: false);
            SourceExpression.Validate(provinceName, nameof(provinceName), required: false);
            SourceExpression.Validate(ukSic2007, nameof(ukSic2007), required: false);
            SourceExpression.Validate(minEmployees, nameof(minEmployees), required: false);
            SourceExpression.Validate(maxEmployees, nameof(maxEmployees), required: false);
            SourceExpression.Validate(minAnnualSalesLocal, nameof(minAnnualSalesLocal), required: false);
            SourceExpression.Validate(maxAnnualSalesLocal, nameof(maxAnnualSalesLocal), required: false);
            SourceExpression.Validate(minScore, nameof(minScore), required: false);
            SourceExpression.Validate(maxScore, nameof(maxScore), required: false);
            SourceExpression.Validate(fromLatLon, nameof(fromLatLon), required: false);
            SourceExpression.Validate(distance, nameof(distance), required: false);
            SourceExpression.Validate(stats, nameof(stats), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/companies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (companyName != null)
                    callPayload.Queries["company_name"] = SourceExpressionConverter.ConvertO(companyName);
                if (gupAmeeCompanyId != null)
                    callPayload.Queries["gup_amee_company_id"] = SourceExpressionConverter.ConvertO(gupAmeeCompanyId);
                if (isGup != null)
                    callPayload.Queries["is_gup"] = SourceExpressionConverter.ConvertO(isGup);
                if (city != null)
                    callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                if (postcode != null)
                    callPayload.Queries["postcode"] = SourceExpressionConverter.ConvertO(postcode);
                if (provinceName != null)
                    callPayload.Queries["province_name"] = SourceExpressionConverter.ConvertO(provinceName);
                if (ukSic2007 != null)
                    callPayload.Queries["uk_sic_2007"] = SourceExpressionConverter.ConvertO(ukSic2007);
                if (minEmployees != null)
                    callPayload.Queries["min_employees"] = SourceExpressionConverter.ConvertO(minEmployees);
                if (maxEmployees != null)
                    callPayload.Queries["max_employees"] = SourceExpressionConverter.ConvertO(maxEmployees);
                if (minAnnualSalesLocal != null)
                    callPayload.Queries["min_annual_sales_local"] = SourceExpressionConverter.ConvertO(minAnnualSalesLocal);
                if (maxAnnualSalesLocal != null)
                    callPayload.Queries["max_annual_sales_local"] = SourceExpressionConverter.ConvertO(maxAnnualSalesLocal);
                if (minScore != null)
                    callPayload.Queries["min_score"] = SourceExpressionConverter.ConvertO(minScore);
                if (maxScore != null)
                    callPayload.Queries["max_score"] = SourceExpressionConverter.ConvertO(maxScore);
                if (fromLatLon != null)
                    callPayload.Queries["from_lat_lon"] = SourceExpressionConverter.ConvertO(fromLatLon);
                if (distance != null)
                    callPayload.Queries["distance"] = SourceExpressionConverter.ConvertO(distance);
                if (stats != null)
                    callPayload.Queries["stats"] = SourceExpressionConverter.ConvertO(stats);
                return callPayload;
            }

            return new ApiConnectionAction<GetCompaniesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ameeopenbusinessip")]
        public IBodyWorkflowAction<GetCompanyResponse> GetCompany([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> type = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(type, nameof(type), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/companies/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                return callPayload;
            }

            return new ApiConnectionAction<GetCompanyResponse>(BuildSourceInput);
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