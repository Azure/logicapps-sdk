//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Solaredgeip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SolaredgeipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<SitesListResponse, ApiConnectionActionConfiguration> SitesList()
        {
            return new DeferredBodyAction<SitesListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/sites/list";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SitesListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<SiteDetailsResponse, ApiConnectionActionConfiguration> SiteDetails(Expression<Func<int>> siteId)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            return new DeferredBodyAction<SiteDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/site/{0}/details", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SiteDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<SiteOverviewResponse, ApiConnectionActionConfiguration> SiteOverview(Expression<Func<int>> siteId)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            return new DeferredBodyAction<SiteOverviewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/site/{0}/overview", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SiteOverviewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<SiteEnvironmentalBenefitsResponse, ApiConnectionActionConfiguration> SiteEnvironmentalBenefits(Expression<Func<int>> siteId)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            return new DeferredBodyAction<SiteEnvironmentalBenefitsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/site/{0}/envBenefits", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SiteEnvironmentalBenefitsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<SiteInventoryResponse, ApiConnectionActionConfiguration> SiteInventory(Expression<Func<int>> siteId)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            return new DeferredBodyAction<SiteInventoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/site/{0}/inventory", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SiteInventoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<SitePowerResponse, ApiConnectionActionConfiguration> SitePower(Expression<Func<string>> startTime, Expression<Func<string>> endTime, Expression<Func<int>> siteId)
        {
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: true);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: true);
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            return new DeferredBodyAction<SitePowerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/site/{0}/power", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                callPayload.Queries["endTime"] = ExpressionConverter.Convert(__workflow_endTime);
                return new ApiConnectionAction<SitePowerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<SiteEnergyResponse, ApiConnectionActionConfiguration> SiteEnergy(Expression<Func<int>> siteId, Expression<Func<string>> timeUnit, Expression<Func<string>> startDate, Expression<Func<string>> endDate)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            var __workflow_timeUnit = WorkflowExpression.Compile(timeUnit, nameof(timeUnit), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            return new DeferredBodyAction<SiteEnergyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/site/{0}/energy", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timeUnit"] = ExpressionConverter.Convert(__workflow_timeUnit);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<SiteEnergyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<SiteEnergyDetailedResponse, ApiConnectionActionConfiguration> SiteEnergyDetailed(Expression<Func<int>> siteId, Expression<Func<string>> timeUnit, Expression<Func<string>> startTime, Expression<Func<string>> endTime, Expression<Func<string>> meters)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            var __workflow_timeUnit = WorkflowExpression.Compile(timeUnit, nameof(timeUnit), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: true);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: true);
            var __workflow_meters = WorkflowExpression.Compile(meters, nameof(meters), required: true);
            return new DeferredBodyAction<SiteEnergyDetailedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/site/{0}/energyDetails", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timeUnit"] = ExpressionConverter.Convert(__workflow_timeUnit);
                callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                callPayload.Queries["endTime"] = ExpressionConverter.Convert(__workflow_endTime);
                callPayload.Queries["Meters"] = ExpressionConverter.Convert(__workflow_meters);
                return new ApiConnectionAction<SiteEnergyDetailedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<SitePowerDetailedResponse, ApiConnectionActionConfiguration> SitePowerDetailed(Expression<Func<int>> siteId, Expression<Func<string>> startTime, Expression<Func<string>> endTime)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: true);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: true);
            return new DeferredBodyAction<SitePowerDetailedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/site/{0}/powerDetails", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                callPayload.Queries["endTime"] = ExpressionConverter.Convert(__workflow_endTime);
                return new ApiConnectionAction<SitePowerDetailedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<SitePowerFlowResponse, ApiConnectionActionConfiguration> SitePowerFlow(Expression<Func<int>> siteId)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            return new DeferredBodyAction<SitePowerFlowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/site/{0}/currentPowerFlow", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SitePowerFlowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<SiteEnergyTimePeriodResponse, ApiConnectionActionConfiguration> SiteEnergyTimePeriod(Expression<Func<int>> siteId, Expression<Func<string>> startDate, Expression<Func<string>> endDate)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: true);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: true);
            return new DeferredBodyAction<SiteEnergyTimePeriodResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/site/{0}/timeFrameEnergy", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<SiteEnergyTimePeriodResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<GetMetersDataResponse, ApiConnectionActionConfiguration> GetMetersData(Expression<Func<int>> siteId, Expression<Func<string>> startTime, Expression<Func<string>> endTime, Expression<Func<string>> timeUnit = null, Expression<Func<string>> meters = null)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: true);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: true);
            var __workflow_timeUnit = WorkflowExpression.Compile(timeUnit, nameof(timeUnit), required: false);
            var __workflow_meters = WorkflowExpression.Compile(meters, nameof(meters), required: false);
            return new DeferredBodyAction<GetMetersDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/site/{0}/meters", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["timeUnit"] = Convert.ToString("QUARTER_OF_AN_HOUR");
                if (__workflow_timeUnit != null)
                    callPayload.Queries["timeUnit"] = ExpressionConverter.Convert(__workflow_timeUnit);
                callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                callPayload.Queries["endTime"] = ExpressionConverter.Convert(__workflow_endTime);
                if (__workflow_meters != null)
                    callPayload.Queries["meters"] = ExpressionConverter.Convert(__workflow_meters);
                return new ApiConnectionAction<GetMetersDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<StorageInformationResponse, ApiConnectionActionConfiguration> StorageInformation(Expression<Func<int>> siteId, Expression<Func<string>> startTime, Expression<Func<string>> endTime, Expression<Func<string>> serials = null)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: true);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: true);
            var __workflow_serials = WorkflowExpression.Compile(serials, nameof(serials), required: false);
            return new DeferredBodyAction<StorageInformationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/site/{0}/storageData", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                callPayload.Queries["endTime"] = ExpressionConverter.Convert(__workflow_endTime);
                if (__workflow_serials != null)
                    callPayload.Queries["serials"] = ExpressionConverter.Convert(__workflow_serials);
                return new ApiConnectionAction<StorageInformationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<ComponentsListResponse, ApiConnectionActionConfiguration> ComponentsList(Expression<Func<int>> siteId)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            return new DeferredBodyAction<ComponentsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/equipment/{0}/list", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ComponentsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<GetSensorListResponse, ApiConnectionActionConfiguration> GetSensorList(Expression<Func<int>> siteId)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            return new DeferredBodyAction<GetSensorListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/equipment/{0}/sensors", __workflow_siteId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSensorListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<InverterTechnicalDataResponse, ApiConnectionActionConfiguration> InverterTechnicalData(Expression<Func<int>> siteId, Expression<Func<string>> equipmentId, Expression<Func<string>> startTime, Expression<Func<string>> endTime)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            var __workflow_equipmentId = WorkflowExpression.Compile(equipmentId, nameof(equipmentId), required: true);
            var __workflow_startTime = WorkflowExpression.Compile(startTime, nameof(startTime), required: true);
            var __workflow_endTime = WorkflowExpression.Compile(endTime, nameof(endTime), required: true);
            return new DeferredBodyAction<InverterTechnicalDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/equipment/{0}/{1}/data", __workflow_siteId.WithUrlEncoding(1), __workflow_equipmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["startTime"] = ExpressionConverter.Convert(__workflow_startTime);
                callPayload.Queries["endTime"] = ExpressionConverter.Convert(__workflow_endTime);
                return new ApiConnectionAction<InverterTechnicalDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "solaredgeip")]
        public IBodyWorkflowAction<EquipmentChangeLogResponse, ApiConnectionActionConfiguration> EquipmentChangeLog(Expression<Func<int>> siteId, Expression<Func<string>> equipmentId)
        {
            var __workflow_siteId = WorkflowExpression.Compile(siteId, nameof(siteId), required: true);
            var __workflow_equipmentId = WorkflowExpression.Compile(equipmentId, nameof(equipmentId), required: true);
            return new DeferredBodyAction<EquipmentChangeLogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/equipment/{0}/{1}/changeLog", __workflow_siteId.WithUrlEncoding(1), __workflow_equipmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<EquipmentChangeLogResponse>(callPayload);
            });
        }
    }

    public class SolaredgeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SitesListResponse
    {
        [JsonProperty("sites")]
        public SitesListResponseSitesType Sites { get; set; }
    }

    public class SitesListResponseSitesType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("site")]
        public SitesListResponseSitesTypeSiteTypeItem[] Site { get; set; }
    }

    public class SitesListResponseSitesTypeSiteTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("accountId")]
        public int AccountId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("peakPower")]
        public double PeakPower { get; set; }

        [JsonProperty("lastUpdateTime")]
        public string LastUpdateTime { get; set; }

        [JsonProperty("installationDate")]
        public string InstallationDate { get; set; }

        [JsonProperty("ptoDate")]
        public string PtoDate { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public SitesListResponseSitesTypeSiteTypeItemLocationType Location { get; set; }

        [JsonProperty("primaryModule")]
        public SitesListResponseSitesTypeSiteTypeItemPrimaryModuleType PrimaryModule { get; set; }
    }

    public class SitesListResponseSitesTypeSiteTypeItemLocationType
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class SitesListResponseSitesTypeSiteTypeItemPrimaryModuleType
    {
        [JsonProperty("manufacturerName")]
        public string ManufacturerName { get; set; }

        [JsonProperty("modelName")]
        public string ModelName { get; set; }

        [JsonProperty("maximumPower")]
        public double MaximumPower { get; set; }

        [JsonProperty("temperatureCoef")]
        public double TemperatureCoef { get; set; }
    }

    public class SiteDetailsResponse
    {
        [JsonProperty("details")]
        public SiteDetailsResponseDetailsType Details { get; set; }
    }

    public class SiteDetailsResponseDetailsType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("accountId")]
        public int AccountId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("peakPower")]
        public double PeakPower { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("installationDate")]
        public string InstallationDate { get; set; }

        [JsonProperty("ptoDate")]
        public string PtoDate { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public SiteDetailsResponseDetailsTypeLocationType Location { get; set; }

        [JsonProperty("alertQuantity")]
        public int AlertQuantity { get; set; }

        [JsonProperty("alertSeverity")]
        public string AlertSeverity { get; set; }

        [JsonProperty("uris")]
        public SiteDetailsResponseDetailsTypeUrisType Uris { get; set; }
    }

    public class SiteDetailsResponseDetailsTypeLocationType
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }

    public class SiteDetailsResponseDetailsTypeUrisType
    {
        [JsonProperty("IMAGE_URI")]
        public string IMAGEURI { get; set; }
    }

    public class SiteOverviewResponse
    {
        [JsonProperty("overview")]
        public SiteOverviewResponseOverviewType Overview { get; set; }
    }

    public class SiteOverviewResponseOverviewType
    {
        [JsonProperty("lastUpdateTime")]
        public string LastUpdateTime { get; set; }

        [JsonProperty("lifeTimeData")]
        public SiteOverviewResponseOverviewTypeLifeTimeDataType LifeTimeData { get; set; }

        [JsonProperty("lastYearData")]
        public SiteOverviewResponseOverviewTypeLastYearDataType LastYearData { get; set; }

        [JsonProperty("lastMonthData")]
        public SiteOverviewResponseOverviewTypeLastMonthDataType LastMonthData { get; set; }

        [JsonProperty("lastDayData")]
        public SiteOverviewResponseOverviewTypeLastDayDataType LastDayData { get; set; }

        [JsonProperty("currentPower")]
        public SiteOverviewResponseOverviewTypeCurrentPowerType CurrentPower { get; set; }

        [JsonProperty("measuredBy")]
        public string MeasuredBy { get; set; }
    }

    public class SiteOverviewResponseOverviewTypeLifeTimeDataType
    {
        [JsonProperty("energy")]
        public double Energy { get; set; }
    }

    public class SiteOverviewResponseOverviewTypeLastYearDataType
    {
        [JsonProperty("energy")]
        public double Energy { get; set; }
    }

    public class SiteOverviewResponseOverviewTypeLastMonthDataType
    {
        [JsonProperty("energy")]
        public double Energy { get; set; }
    }

    public class SiteOverviewResponseOverviewTypeLastDayDataType
    {
        [JsonProperty("energy")]
        public double Energy { get; set; }
    }

    public class SiteOverviewResponseOverviewTypeCurrentPowerType
    {
        [JsonProperty("power")]
        public double Power { get; set; }
    }

    public class SiteEnvironmentalBenefitsResponse
    {
        [JsonProperty("envBenefits")]
        public SiteEnvironmentalBenefitsResponseEnvBenefitsType EnvBenefits { get; set; }
    }

    public class SiteEnvironmentalBenefitsResponseEnvBenefitsType
    {
        [JsonProperty("gasEmissionSaved")]
        public SiteEnvironmentalBenefitsResponseEnvBenefitsTypeGasEmissionSavedType GasEmissionSaved { get; set; }

        [JsonProperty("treesPlanted")]
        public double TreesPlanted { get; set; }

        [JsonProperty("lightBulbs")]
        public double LightBulbs { get; set; }
    }

    public class SiteEnvironmentalBenefitsResponseEnvBenefitsTypeGasEmissionSavedType
    {
        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("co2")]
        public double Co2 { get; set; }

        [JsonProperty("so2")]
        public double So2 { get; set; }

        [JsonProperty("nox")]
        public double Nox { get; set; }
    }

    public class SiteInventoryResponse
    {
        public SiteInventoryResponseInventoryType Inventory { get; set; }
    }

    public class SiteInventoryResponseInventoryType
    {
        [JsonProperty("meters")]
        public SiteInventoryResponseInventoryTypeMetersTypeItem[] Meters { get; set; }

        [JsonProperty("sensors")]
        public SiteInventoryResponseInventoryTypeSensorsTypeItem[] Sensors { get; set; }

        [JsonProperty("gateways")]
        public SiteInventoryResponseInventoryTypeGatewaysTypeItem[] Gateways { get; set; }

        [JsonProperty("batteries")]
        public SiteInventoryResponseInventoryTypeBatteriesTypeItem[] Batteries { get; set; }

        [JsonProperty("inverters")]
        public SiteInventoryResponseInventoryTypeInvertersTypeItem[] Inverters { get; set; }
    }

    public class SiteInventoryResponseInventoryTypeMetersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("firmwareVersion")]
        public string FirmwareVersion { get; set; }

        [JsonProperty("connectedSolaredgeDeviceSN")]
        public string ConnectedSolaredgeDeviceSN { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("form")]
        public string Form { get; set; }
    }

    public class SiteInventoryResponseInventoryTypeSensorsTypeItem
    {
        [JsonProperty("connectedSolaredgeDeviceSN")]
        public string ConnectedSolaredgeDeviceSN { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("connectedTo")]
        public string ConnectedTo { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SiteInventoryResponseInventoryTypeGatewaysTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("firmwareVersion")]
        public string FirmwareVersion { get; set; }
        public string SN { get; set; }
    }

    public class SiteInventoryResponseInventoryTypeBatteriesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("firmwareVersion")]
        public string FirmwareVersion { get; set; }

        [JsonProperty("connectedInverterSn")]
        public string ConnectedInverterSn { get; set; }

        [JsonProperty("nameplateCapacity")]
        public int NameplateCapacity { get; set; }
        public string SN { get; set; }
    }

    public class SiteInventoryResponseInventoryTypeInvertersTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("firmwareVersion")]
        public string FirmwareVersion { get; set; }
        public string SN { get; set; }

        [JsonProperty("connectedOptimizers")]
        public int ConnectedOptimizers { get; set; }
    }

    public class SitePowerResponse
    {
        [JsonProperty("power")]
        public SitePowerResponsePowerType Power { get; set; }
    }

    public class SitePowerResponsePowerType
    {
        [JsonProperty("timeUnit")]
        public string TimeUnit { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("measuredBy")]
        public string MeasuredBy { get; set; }

        [JsonProperty("values")]
        public SitePowerResponsePowerTypeValuesTypeItem[] Values { get; set; }
    }

    public class SitePowerResponsePowerTypeValuesTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class SiteEnergyResponse
    {
        [JsonProperty("energy")]
        public SiteEnergyResponseEnergyType Energy { get; set; }
    }

    public class SiteEnergyResponseEnergyType
    {
        [JsonProperty("timeUnit")]
        public string TimeUnit { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("measuredBy")]
        public string MeasuredBy { get; set; }

        [JsonProperty("values")]
        public SiteEnergyResponseEnergyTypeValuesTypeItem[] Values { get; set; }
    }

    public class SiteEnergyResponseEnergyTypeValuesTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class SiteEnergyDetailedResponse
    {
        [JsonProperty("energyDetails")]
        public SiteEnergyDetailedResponseEnergyDetailsType EnergyDetails { get; set; }
    }

    public class SiteEnergyDetailedResponseEnergyDetailsType
    {
        [JsonProperty("timeUnit")]
        public string TimeUnit { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("meters")]
        public SiteEnergyDetailedResponseEnergyDetailsTypeMetersTypeItem[] Meters { get; set; }
    }

    public class SiteEnergyDetailedResponseEnergyDetailsTypeMetersTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public SiteEnergyDetailedResponseEnergyDetailsTypeMetersTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class SiteEnergyDetailedResponseEnergyDetailsTypeMetersTypeItemValuesTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class SitePowerDetailedResponse
    {
        [JsonProperty("powerDetails")]
        public SitePowerDetailedResponsePowerDetailsType PowerDetails { get; set; }
    }

    public class SitePowerDetailedResponsePowerDetailsType
    {
        [JsonProperty("timeUnit")]
        public string TimeUnit { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("meters")]
        public SitePowerDetailedResponsePowerDetailsTypeMetersTypeItem[] Meters { get; set; }
    }

    public class SitePowerDetailedResponsePowerDetailsTypeMetersTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("values")]
        public SitePowerDetailedResponsePowerDetailsTypeMetersTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class SitePowerDetailedResponsePowerDetailsTypeMetersTypeItemValuesTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class SitePowerFlowResponse
    {
        [JsonProperty("siteCurrentPowerFlow")]
        public SitePowerFlowResponseSiteCurrentPowerFlowType SiteCurrentPowerFlow { get; set; }
    }

    public class SitePowerFlowResponseSiteCurrentPowerFlowType
    {
        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("connections")]
        public SitePowerFlowResponseSiteCurrentPowerFlowTypeConnectionsTypeItem[] Connections { get; set; }

        [JsonProperty("GRID")]
        public SitePowerFlowResponseSiteCurrentPowerFlowTypeGRIdType GRId { get; set; }
        public SitePowerFlowResponseSiteCurrentPowerFlowTypeLOADType LOAD { get; set; }
        public SitePowerFlowResponseSiteCurrentPowerFlowTypePVType PV { get; set; }
        public SitePowerFlowResponseSiteCurrentPowerFlowTypeSTORAGEType STORAGE { get; set; }
    }

    public class SitePowerFlowResponseSiteCurrentPowerFlowTypeConnectionsTypeItem
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }
    }

    public class SitePowerFlowResponseSiteCurrentPowerFlowTypeGRIdType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("currentPower")]
        public double CurrentPower { get; set; }
    }

    public class SitePowerFlowResponseSiteCurrentPowerFlowTypeLOADType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("currentPower")]
        public double CurrentPower { get; set; }
    }

    public class SitePowerFlowResponseSiteCurrentPowerFlowTypePVType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("currentPower")]
        public double CurrentPower { get; set; }
    }

    public class SitePowerFlowResponseSiteCurrentPowerFlowTypeSTORAGEType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("currentPower")]
        public double CurrentPower { get; set; }

        [JsonProperty("chargeLevel")]
        public int ChargeLevel { get; set; }

        [JsonProperty("critical")]
        public bool Critical { get; set; }

        [JsonProperty("timeLeft")]
        public int TimeLeft { get; set; }
    }

    public class SiteEnergyTimePeriodResponse
    {
        [JsonProperty("timeFrameEnergy")]
        public SiteEnergyTimePeriodResponseTimeFrameEnergyType TimeFrameEnergy { get; set; }
    }

    public class SiteEnergyTimePeriodResponseTimeFrameEnergyType
    {
        [JsonProperty("energy")]
        public double Energy { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("measuredBy")]
        public string MeasuredBy { get; set; }

        [JsonProperty("startLifetimeEnergy")]
        public SiteEnergyTimePeriodResponseTimeFrameEnergyTypeStartLifetimeEnergyType StartLifetimeEnergy { get; set; }

        [JsonProperty("endLifetimeEnergy")]
        public SiteEnergyTimePeriodResponseTimeFrameEnergyTypeEndLifetimeEnergyType EndLifetimeEnergy { get; set; }
    }

    public class SiteEnergyTimePeriodResponseTimeFrameEnergyTypeStartLifetimeEnergyType
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("energy")]
        public double Energy { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class SiteEnergyTimePeriodResponseTimeFrameEnergyTypeEndLifetimeEnergyType
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("energy")]
        public double Energy { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class GetMetersDataResponse
    {
        [JsonProperty("meterEnergyDetails")]
        public GetMetersDataResponseMeterEnergyDetailsType MeterEnergyDetails { get; set; }
    }

    public class GetMetersDataResponseMeterEnergyDetailsType
    {
        [JsonProperty("timeUnit")]
        public string TimeUnit { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("meters")]
        public GetMetersDataResponseMeterEnergyDetailsTypeMetersTypeItem[] Meters { get; set; }
    }

    public class GetMetersDataResponseMeterEnergyDetailsTypeMetersTypeItem
    {
        [JsonProperty("meterSerialNumber")]
        public string MeterSerialNumber { get; set; }

        [JsonProperty("connectedSolaredgeDeviceSN")]
        public string ConnectedSolaredgeDeviceSN { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("meterType")]
        public string MeterType { get; set; }

        [JsonProperty("values")]
        public GetMetersDataResponseMeterEnergyDetailsTypeMetersTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class GetMetersDataResponseMeterEnergyDetailsTypeMetersTypeItemValuesTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class StorageInformationResponse
    {
        [JsonProperty("storageData")]
        public StorageInformationResponseStorageDataType StorageData { get; set; }
    }

    public class StorageInformationResponseStorageDataType
    {
        [JsonProperty("batteryCount")]
        public int BatteryCount { get; set; }

        [JsonProperty("batteries")]
        public StorageInformationResponseStorageDataTypeBatteriesTypeItem[] Batteries { get; set; }
    }

    public class StorageInformationResponseStorageDataTypeBatteriesTypeItem
    {
        [JsonProperty("nameplate")]
        public int Nameplate { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("modelNumber")]
        public string ModelNumber { get; set; }

        [JsonProperty("telemetryCount")]
        public int TelemetryCount { get; set; }

        [JsonProperty("telemetries")]
        public StorageInformationResponseStorageDataTypeBatteriesTypeItemTelemetriesTypeItem[] Telemetries { get; set; }
    }

    public class StorageInformationResponseStorageDataTypeBatteriesTypeItemTelemetriesTypeItem
    {
        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }

        [JsonProperty("power")]
        public int Power { get; set; }

        [JsonProperty("batteryState")]
        public int BatteryState { get; set; }

        [JsonProperty("lifeTimeEnergyCharged")]
        public double LifeTimeEnergyCharged { get; set; }

        [JsonProperty("lifeTimeEnergyDischarged")]
        public double LifeTimeEnergyDischarged { get; set; }

        [JsonProperty("fullPackEnergyAvailable")]
        public int FullPackEnergyAvailable { get; set; }

        [JsonProperty("internalTemp")]
        public int InternalTemp { get; set; }
        public int ACGridCharging { get; set; }

        [JsonProperty("stateOfCharge")]
        public int StateOfCharge { get; set; }
    }

    public class ComponentsListResponse
    {
        [JsonProperty("reporters")]
        public ComponentsListResponseReportersType Reporters { get; set; }
    }

    public class ComponentsListResponseReportersType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("list")]
        public ComponentsListResponseReportersTypeListTypeItem[] List { get; set; }
    }

    public class ComponentsListResponseReportersTypeListTypeItem
    {
        [JsonProperty("componentname")]
        public string Componentname { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
    }

    public class GetSensorListResponse
    {
        public GetSensorListResponseSiteSensorsType SiteSensors { get; set; }
    }

    public class GetSensorListResponseSiteSensorsType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("list")]
        public GetSensorListResponseSiteSensorsTypeListTypeItem[] List { get; set; }
    }

    public class GetSensorListResponseSiteSensorsTypeListTypeItem
    {
        [JsonProperty("connectedTo")]
        public string ConnectedTo { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("sensors")]
        public GetSensorListResponseSiteSensorsTypeListTypeItemSensorsTypeItem[] Sensors { get; set; }
    }

    public class GetSensorListResponseSiteSensorsTypeListTypeItemSensorsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("measurement")]
        public string Measurement { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class InverterTechnicalDataResponse
    {
        [JsonProperty("data")]
        public InverterTechnicalDataResponseDataType Data { get; set; }
    }

    public class InverterTechnicalDataResponseDataType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("telemetries")]
        public InverterTechnicalDataResponseDataTypeTelemetriesTypeItem[] Telemetries { get; set; }
    }

    public class InverterTechnicalDataResponseDataTypeTelemetriesTypeItem
    {
        [JsonProperty("threePhaseInverterTelemetry")]
        public InverterTechnicalDataResponseDataTypeTelemetriesTypeItemThreePhaseInverterTelemetryTypeItem[] ThreePhaseInverterTelemetry { get; set; }
    }

    public class InverterTechnicalDataResponseDataTypeTelemetriesTypeItemThreePhaseInverterTelemetryTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("totalActivePower")]
        public string TotalActivePower { get; set; }

        [JsonProperty("dcVoltage")]
        public double DcVoltage { get; set; }

        [JsonProperty("groundFaultResistance")]
        public double GroundFaultResistance { get; set; }

        [JsonProperty("powerLimit")]
        public double PowerLimit { get; set; }

        [JsonProperty("totalEnergy")]
        public int TotalEnergy { get; set; }

        [JsonProperty("temperature")]
        public double Temperature { get; set; }

        [JsonProperty("inverterMode")]
        public string InverterMode { get; set; }

        [JsonProperty("operationMode")]
        public int OperationMode { get; set; }
        public InverterTechnicalDataResponseDataTypeTelemetriesTypeItemThreePhaseInverterTelemetryTypeItemL1DataType L1Data { get; set; }

        [JsonProperty("vL1To2")]
        public double VL1To2 { get; set; }

        [JsonProperty("vL2To3")]
        public double VL2To3 { get; set; }

        [JsonProperty("vL3To1")]
        public double VL3To1 { get; set; }
        public InverterTechnicalDataResponseDataTypeTelemetriesTypeItemThreePhaseInverterTelemetryTypeItemL2DataType L2Data { get; set; }
        public InverterTechnicalDataResponseDataTypeTelemetriesTypeItemThreePhaseInverterTelemetryTypeItemL3DataType L3Data { get; set; }
    }

    public class InverterTechnicalDataResponseDataTypeTelemetriesTypeItemThreePhaseInverterTelemetryTypeItemL1DataType
    {
        [JsonProperty("acCurrent")]
        public double AcCurrent { get; set; }

        [JsonProperty("acVoltage")]
        public double AcVoltage { get; set; }

        [JsonProperty("acFrequency")]
        public double AcFrequency { get; set; }

        [JsonProperty("apparentPower")]
        public int ApparentPower { get; set; }

        [JsonProperty("activePower")]
        public int ActivePower { get; set; }

        [JsonProperty("reactivePower")]
        public int ReactivePower { get; set; }

        [JsonProperty("cosPhi")]
        public int CosPhi { get; set; }
    }

    public class InverterTechnicalDataResponseDataTypeTelemetriesTypeItemThreePhaseInverterTelemetryTypeItemL2DataType
    {
        [JsonProperty("acCurrent")]
        public double AcCurrent { get; set; }

        [JsonProperty("acVoltage")]
        public double AcVoltage { get; set; }

        [JsonProperty("acFrequency")]
        public double AcFrequency { get; set; }

        [JsonProperty("apparentPower")]
        public int ApparentPower { get; set; }

        [JsonProperty("activePower")]
        public int ActivePower { get; set; }

        [JsonProperty("reactivePower")]
        public int ReactivePower { get; set; }

        [JsonProperty("cosPhi")]
        public int CosPhi { get; set; }
    }

    public class InverterTechnicalDataResponseDataTypeTelemetriesTypeItemThreePhaseInverterTelemetryTypeItemL3DataType
    {
        [JsonProperty("acCurrent")]
        public double AcCurrent { get; set; }

        [JsonProperty("acVoltage")]
        public double AcVoltage { get; set; }

        [JsonProperty("acFrequency")]
        public double AcFrequency { get; set; }

        [JsonProperty("apparentPower")]
        public int ApparentPower { get; set; }

        [JsonProperty("activePower")]
        public int ActivePower { get; set; }

        [JsonProperty("reactivePower")]
        public int ReactivePower { get; set; }

        [JsonProperty("cosPhi")]
        public int CosPhi { get; set; }
    }

    public class EquipmentChangeLogResponse
    {
        public EquipmentChangeLogResponseChangeLogType ChangeLog { get; set; }
    }

    public class EquipmentChangeLogResponseChangeLogType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("list")]
        public EquipmentChangeLogResponseChangeLogTypeListType List { get; set; }
    }

    public class EquipmentChangeLogResponseChangeLogTypeListType
    {
        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("partNumber")]
        public string PartNumber { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Solaredgeip;

    public partial class WorkflowManagedActions
    {
        public SolaredgeipActions Solaredgeip(string connectionId) => new SolaredgeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SolaredgeipTriggers Solaredgeip(string connectionId) => new SolaredgeipTriggers(connectionId);
    }
}