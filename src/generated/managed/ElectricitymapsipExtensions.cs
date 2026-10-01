//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Electricitymapsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ElectricitymapsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "electricitymapsip")]
        public IBodyWorkflowAction<CarbonForecastResponse> CarbonForecast([WorkflowExpression] Func<string> zone = null, [WorkflowExpression] Func<string> lon = null, [WorkflowExpression] Func<string> lat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/carbon-intensity/forecast";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (zone != null)
                    callPayload.Queries["zone"] = SourceExpressionConverter.ConvertO(zone);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                return callPayload;
            }

            return new ApiConnectionAction<CarbonForecastResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "electricitymapsip")]
        public IBodyWorkflowAction<CarbonHistoryResponse> CarbonHistory([WorkflowExpression] Func<string> zone = null, [WorkflowExpression] Func<string> lon = null, [WorkflowExpression] Func<string> lat = null, [WorkflowExpression] Func<emissionFactorTypeInput> emissionFactorType = null, [WorkflowExpression] Func<bool> disableEstimations = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/carbon-intensity/history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (zone != null)
                    callPayload.Queries["zone"] = SourceExpressionConverter.ConvertO(zone);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                if (emissionFactorType != null)
                    callPayload.Queries["emissionFactorType"] = SourceExpressionConverter.Convert(emissionFactorType);
                if (disableEstimations != null)
                    callPayload.Queries["disableEstimations"] = SourceExpressionConverter.ConvertO(disableEstimations);
                return callPayload;
            }

            return new ApiConnectionAction<CarbonHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "electricitymapsip")]
        public IBodyWorkflowAction<CarbonLatestResponse> CarbonLatest([WorkflowExpression] Func<string> zone = null, [WorkflowExpression] Func<string> lon = null, [WorkflowExpression] Func<string> lat = null, [WorkflowExpression] Func<emissionFactorTypeInput> emissionFactorType = null, [WorkflowExpression] Func<bool> disableEstimations = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/carbon-intensity/latest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (zone != null)
                    callPayload.Queries["zone"] = SourceExpressionConverter.ConvertO(zone);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                if (emissionFactorType != null)
                    callPayload.Queries["emissionFactorType"] = SourceExpressionConverter.Convert(emissionFactorType);
                if (disableEstimations != null)
                    callPayload.Queries["disableEstimations"] = SourceExpressionConverter.ConvertO(disableEstimations);
                return callPayload;
            }

            return new ApiConnectionAction<CarbonLatestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "electricitymapsip")]
        public IBodyWorkflowAction<BreakdownHistoryResponse> BreakdownHistory([WorkflowExpression] Func<string> zone = null, [WorkflowExpression] Func<string> lon = null, [WorkflowExpression] Func<string> lat = null, [WorkflowExpression] Func<bool> disableEstimations = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power-breakdown/history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (zone != null)
                    callPayload.Queries["zone"] = SourceExpressionConverter.ConvertO(zone);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                if (disableEstimations != null)
                    callPayload.Queries["disableEstimations"] = SourceExpressionConverter.ConvertO(disableEstimations);
                return callPayload;
            }

            return new ApiConnectionAction<BreakdownHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "electricitymapsip")]
        public IBodyWorkflowAction<BreakdownLatestResponse> BreakdownLatest([WorkflowExpression] Func<string> zone = null, [WorkflowExpression] Func<string> lon = null, [WorkflowExpression] Func<string> lat = null, [WorkflowExpression] Func<bool> disableEstimations = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power-breakdown/latest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (zone != null)
                    callPayload.Queries["zone"] = SourceExpressionConverter.ConvertO(zone);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                if (disableEstimations != null)
                    callPayload.Queries["disableEstimations"] = SourceExpressionConverter.ConvertO(disableEstimations);
                return callPayload;
            }

            return new ApiConnectionAction<BreakdownLatestResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "electricitymapsip")]
        public IBodyWorkflowAction<ConsumptionForecastResponse> ConsumptionForecast([WorkflowExpression] Func<string> zone = null, [WorkflowExpression] Func<string> lon = null, [WorkflowExpression] Func<string> lat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power-consumption-breakdown/forecast";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (zone != null)
                    callPayload.Queries["zone"] = SourceExpressionConverter.ConvertO(zone);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                return callPayload;
            }

            return new ApiConnectionAction<ConsumptionForecastResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "electricitymapsip")]
        public IBodyWorkflowAction<BreakdownForecastResponse> BreakdownForecast([WorkflowExpression] Func<string> zone = null, [WorkflowExpression] Func<string> lon = null, [WorkflowExpression] Func<string> lat = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/power-production-breakdown/forecast";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (zone != null)
                    callPayload.Queries["zone"] = SourceExpressionConverter.ConvertO(zone);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                return callPayload;
            }

            return new ApiConnectionAction<BreakdownForecastResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "electricitymapsip")]
        public IBodyWorkflowAction<GetZonesResponse> GetZones()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/zones";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetZonesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "electricitymapsip")]
        public IBodyWorkflowAction<CheckHealthResponse> CheckHealth()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/health";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CheckHealthResponse>(BuildSourceInput);
        }
    }

    public class ElectricitymapsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CarbonForecastResponse
    {
        [JsonProperty("forecast")]
        public CarbonForecastResponseForecastsTypeItem[] Forecasts { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("zone")]
        public string Zone { get; set; }
    }

    public class CarbonForecastResponseForecastsTypeItem
    {
        [JsonProperty("carbonIntensity")]
        public double CarbonIntensity { get; set; }

        [JsonProperty("datetime")]
        public string DateAndTime { get; set; }
    }

    public class CarbonHistoryResponse
    {
        [JsonProperty("history")]
        public CarbonHistoryResponseHistoryTypeItem[] History { get; set; }

        [JsonProperty("zone")]
        public string Zone { get; set; }
    }

    public class CarbonHistoryResponseHistoryTypeItem
    {
        [JsonProperty("carbonIntensity")]
        public double CarbonIntensity { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("datetime")]
        public string DateAndTime { get; set; }

        [JsonProperty("emissionFactorType")]
        public string EmissionFactorType { get; set; }

        [JsonProperty("estimationMethod")]
        public string EstimationMethod { get; set; }

        [JsonProperty("isEstimated")]
        public bool IsEstimated { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public enum emissionFactorTypeInput
    {
        [EnumMember(Value = "lifecycle")]
        Lifecycle,
        [EnumMember(Value = "direct")]
        Direct
    }

    public class CarbonLatestResponse
    {
        [JsonProperty("carbonIntensity")]
        public double CarbonIntensity { get; set; }

        [JsonProperty("datetime")]
        public string DateAndTime { get; set; }

        [JsonProperty("emissionFactorType")]
        public string EmissionFactorType { get; set; }

        [JsonProperty("estimationMethod")]
        public string EstimationMethod { get; set; }

        [JsonProperty("isEstimated")]
        public bool IsEstimated { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("zone")]
        public string Zone { get; set; }
    }

    public class BreakdownHistoryResponse
    {
        [JsonProperty("history")]
        public BreakdownHistoryResponseHistoryTypeItem[] History { get; set; }

        [JsonProperty("zone")]
        public string Zone { get; set; }
    }

    public class BreakdownHistoryResponseHistoryTypeItem
    {
        [JsonProperty("datetime")]
        public string DateAndTime { get; set; }

        [JsonProperty("estimationMethod")]
        public string EstimationMethod { get; set; }

        [JsonProperty("fossilFreePercentage")]
        public double FossilFreePercentage { get; set; }

        [JsonProperty("isEstimated")]
        public bool IsEstimated { get; set; }

        [JsonProperty("powerConsumptionBreakdown")]
        public BreakdownHistoryResponseHistoryTypeItemPowerConsumptionType PowerConsumption { get; set; }

        [JsonProperty("powerConsumptionTotal")]
        public double TotalConsumption { get; set; }

        [JsonProperty("powerExportBreakdown")]
        public JToken PowerExportBreakdown { get; set; }

        [JsonProperty("powerExportTotal")]
        public double PowerExportTotal { get; set; }

        [JsonProperty("powerImportBreakdown")]
        public JToken PowerImportBreakdown { get; set; }

        [JsonProperty("powerImportTotal")]
        public double PowerImportTotal { get; set; }

        [JsonProperty("powerProductionBreakdown")]
        public BreakdownHistoryResponseHistoryTypeItemPowerProductionType PowerProduction { get; set; }

        [JsonProperty("powerProductionTotal")]
        public double TotalProduction { get; set; }

        [JsonProperty("renewablePercentage")]
        public double RenewablesPercentage { get; set; }
    }

    public class BreakdownHistoryResponseHistoryTypeItemPowerConsumptionType
    {
        [JsonProperty("battery discharge")]
        public double BatteryDischarge { get; set; }

        [JsonProperty("biomass")]
        public double Biomass { get; set; }

        [JsonProperty("coal")]
        public double Coal { get; set; }

        [JsonProperty("gas")]
        public double Gas { get; set; }

        [JsonProperty("geothermal")]
        public double Geothermal { get; set; }

        [JsonProperty("hydro")]
        public double Hydro { get; set; }

        [JsonProperty("hydro discharge")]
        public double HydroDischarge { get; set; }

        [JsonProperty("nuclear")]
        public double Nuclear { get; set; }

        [JsonProperty("oil")]
        public double Oil { get; set; }

        [JsonProperty("solar")]
        public double Solar { get; set; }

        [JsonProperty("unknown")]
        public double Unknown { get; set; }

        [JsonProperty("wind")]
        public double Wind { get; set; }
    }

    public class BreakdownHistoryResponseHistoryTypeItemPowerProductionType
    {
        [JsonProperty("battery discharge")]
        public double BatteryDischarge { get; set; }

        [JsonProperty("biomass")]
        public double Biomass { get; set; }

        [JsonProperty("coal")]
        public double Coal { get; set; }

        [JsonProperty("gas")]
        public double Gas { get; set; }

        [JsonProperty("geothermal")]
        public double Geothermal { get; set; }

        [JsonProperty("hydro")]
        public double Hydro { get; set; }

        [JsonProperty("hydro discharge")]
        public double HydroDischarge { get; set; }

        [JsonProperty("nuclear")]
        public double Nuclear { get; set; }

        [JsonProperty("oil")]
        public double Oil { get; set; }

        [JsonProperty("solar")]
        public double Solar { get; set; }

        [JsonProperty("unknown")]
        public double Unknown { get; set; }

        [JsonProperty("wind")]
        public double Wind { get; set; }
    }

    public class BreakdownLatestResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("datetime")]
        public string DateAndTime { get; set; }

        [JsonProperty("estimationMethod")]
        public string EstimationMethod { get; set; }

        [JsonProperty("fossilFreePercentage")]
        public double FossilFreePercentage { get; set; }

        [JsonProperty("isEstimated")]
        public bool IsEstimated { get; set; }

        [JsonProperty("powerConsumptionBreakdown")]
        public BreakdownLatestResponsePowerConsumptionType PowerConsumption { get; set; }

        [JsonProperty("powerConsumptionTotal")]
        public double TotalConsumption { get; set; }

        [JsonProperty("powerExportBreakdown")]
        public JToken PowerExportBreakdown { get; set; }

        [JsonProperty("powerExportTotal")]
        public double PowerExportTotal { get; set; }

        [JsonProperty("powerImportBreakdown")]
        public JToken PowerImportBreakdown { get; set; }

        [JsonProperty("powerImportTotal")]
        public double PowerImportTotal { get; set; }

        [JsonProperty("powerProductionBreakdown")]
        public BreakdownLatestResponsePowerProductionType PowerProduction { get; set; }

        [JsonProperty("powerProductionTotal")]
        public double TotalProduction { get; set; }

        [JsonProperty("renewablePercentage")]
        public double RenewablesPercentage { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("zone")]
        public string Zone { get; set; }
    }

    public class BreakdownLatestResponsePowerConsumptionType
    {
        [JsonProperty("battery discharge")]
        public double BatteryDischarge { get; set; }

        [JsonProperty("biomass")]
        public double Biomass { get; set; }

        [JsonProperty("coal")]
        public double Coal { get; set; }

        [JsonProperty("gas")]
        public double Gas { get; set; }

        [JsonProperty("geothermal")]
        public double Geothermal { get; set; }

        [JsonProperty("hydro")]
        public double Hydro { get; set; }

        [JsonProperty("hydro discharge")]
        public double HydroDischarge { get; set; }

        [JsonProperty("nuclear")]
        public double Nuclear { get; set; }

        [JsonProperty("oil")]
        public double Oil { get; set; }

        [JsonProperty("solar")]
        public double Solar { get; set; }

        [JsonProperty("unknown")]
        public double Unknown { get; set; }

        [JsonProperty("wind")]
        public double Wind { get; set; }
    }

    public class BreakdownLatestResponsePowerProductionType
    {
        [JsonProperty("battery discharge")]
        public double BatteryDischarge { get; set; }

        [JsonProperty("biomass")]
        public double Biomass { get; set; }

        [JsonProperty("coal")]
        public double Coal { get; set; }

        [JsonProperty("gas")]
        public double Gas { get; set; }

        [JsonProperty("geothermal")]
        public double Geothermal { get; set; }

        [JsonProperty("hydro")]
        public double Hydro { get; set; }

        [JsonProperty("hydro discharge")]
        public double HydroDischarge { get; set; }

        [JsonProperty("nuclear")]
        public double Nuclear { get; set; }

        [JsonProperty("oil")]
        public double Oil { get; set; }

        [JsonProperty("solar")]
        public double Solar { get; set; }

        [JsonProperty("unknown")]
        public double Unknown { get; set; }

        [JsonProperty("wind")]
        public double Wind { get; set; }
    }

    public class ConsumptionForecastResponse
    {
        [JsonProperty("forecast")]
        public ConsumptionForecastResponsePowerConsumptionForecastTypeItem[] PowerConsumptionForecast { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("zone")]
        public string Zone { get; set; }
    }

    public class ConsumptionForecastResponsePowerConsumptionForecastTypeItem
    {
        [JsonProperty("datetime")]
        public string DateAndTime { get; set; }

        [JsonProperty("powerConsumptionBreakdown")]
        public ConsumptionForecastResponsePowerConsumptionForecastTypeItemPowerConsumptionBreakdownType PowerConsumptionBreakdown { get; set; }

        [JsonProperty("powerConsumptionTotal")]
        public double TotalConsumption { get; set; }
    }

    public class ConsumptionForecastResponsePowerConsumptionForecastTypeItemPowerConsumptionBreakdownType
    {
        [JsonProperty("biomass")]
        public double Biomass { get; set; }

        [JsonProperty("coal")]
        public double Coal { get; set; }

        [JsonProperty("gas")]
        public double Gas { get; set; }

        [JsonProperty("hydro")]
        public double Hydro { get; set; }

        [JsonProperty("nuclear")]
        public double Nuclear { get; set; }

        [JsonProperty("solar")]
        public double Solar { get; set; }

        [JsonProperty("unknown")]
        public double Unknown { get; set; }

        [JsonProperty("wind")]
        public double Wind { get; set; }
    }

    public class BreakdownForecastResponse
    {
        [JsonProperty("forecast")]
        public BreakdownForecastResponsePowerProductionForecastTypeItem[] PowerProductionForecast { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("zone")]
        public string Zone { get; set; }
    }

    public class BreakdownForecastResponsePowerProductionForecastTypeItem
    {
        [JsonProperty("datetime")]
        public string DateAndTime { get; set; }

        [JsonProperty("powerProductionBreakdown")]
        public BreakdownForecastResponsePowerProductionForecastTypeItemPowerProductionBreakdownType PowerProductionBreakdown { get; set; }

        [JsonProperty("powerProductionTotal")]
        public double TotalProduction { get; set; }
    }

    public class BreakdownForecastResponsePowerProductionForecastTypeItemPowerProductionBreakdownType
    {
        [JsonProperty("biomass")]
        public double Biomass { get; set; }

        [JsonProperty("coal")]
        public double Coal { get; set; }

        [JsonProperty("gas")]
        public double Gas { get; set; }

        [JsonProperty("hydro")]
        public double Hydro { get; set; }

        [JsonProperty("nuclear")]
        public double Nuclear { get; set; }

        [JsonProperty("oil")]
        public double Oil { get; set; }

        [JsonProperty("solar")]
        public double Solar { get; set; }

        [JsonProperty("unknown")]
        public double Unknown { get; set; }

        [JsonProperty("wind")]
        public double Wind { get; set; }
    }

    public class GetZonesResponse
    {
        public GetZonesResponseZonesTypeItem[] Zones { get; set; }
    }

    public class GetZonesResponseZonesTypeItem
    {
        public string Name { get; set; }

        [JsonProperty("Details")]
        public GetZonesResponseZonesTypeItemZoneDetailsType ZoneDetails { get; set; }
    }

    public class GetZonesResponseZonesTypeItemZoneDetailsType
    {
        [JsonProperty("zoneName")]
        public string ZoneName { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }
    }

    public class CheckHealthResponse
    {
        [JsonProperty("monitors")]
        public CheckHealthResponseMonitorsType Monitors { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class CheckHealthResponseMonitorsType
    {
        [JsonProperty("state")]
        public string State { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Electricitymapsip;

    public partial class WorkflowManagedActions
    {
        public ElectricitymapsipActions Electricitymapsip(string connectionId) => new ElectricitymapsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ElectricitymapsipTriggers Electricitymapsip(string connectionId) => new ElectricitymapsipTriggers(connectionId);
    }
}