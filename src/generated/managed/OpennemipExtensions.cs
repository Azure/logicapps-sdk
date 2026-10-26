//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opennemip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpennemipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetNetworksResponseItem[], ApiConnectionActionConfiguration> GetNetworks()
        {
            return new DeferredBodyAction<GetNetworksResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/networks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetNetworksResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetStationsResponse, ApiConnectionActionConfiguration> GetStations(Expression<Func<bool>> facilitiesInclude = null, Expression<Func<bool>> onlyApproved = null, Expression<Func<string>> name = null, Expression<Func<int>> limit = null, Expression<Func<int>> page = null)
        {
            var __workflow_facilitiesInclude = WorkflowExpression.Compile(facilitiesInclude, nameof(facilitiesInclude), required: false);
            var __workflow_onlyApproved = WorkflowExpression.Compile(onlyApproved, nameof(onlyApproved), required: false);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            return new DeferredBodyAction<GetStationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/station/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_facilitiesInclude != null)
                    callPayload.Queries["facilities_include"] = ExpressionConverter.Convert(__workflow_facilitiesInclude);
                if (__workflow_onlyApproved != null)
                    callPayload.Queries["only_approved"] = ExpressionConverter.Convert(__workflow_onlyApproved);
                if (__workflow_name != null)
                    callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                return new ApiConnectionAction<GetStationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetStationByIdResponse, ApiConnectionActionConfiguration> GetStationById(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetStationByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/station/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetStationByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetSingleStationbyCodeResponse, ApiConnectionActionConfiguration> GetSingleStationbyCode(Expression<Func<string>> networkId, Expression<Func<string>> stationCode)
        {
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: true);
            var __workflow_stationCode = WorkflowExpression.Compile(stationCode, nameof(stationCode), required: true);
            return new DeferredBodyAction<GetSingleStationbyCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/station/{0}/{1}/{2}", WorkflowExpression.Literal("au").WithUrlEncoding(1), __workflow_networkId.WithUrlEncoding(1), __workflow_stationCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSingleStationbyCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetFacilitiesResponseItem[], ApiConnectionActionConfiguration> GetFacilities()
        {
            return new DeferredBodyAction<GetFacilitiesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/facility/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFacilitiesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetFacilitybyCodeResponse, ApiConnectionActionConfiguration> GetFacilitybyCode(Expression<Func<string>> facilityCode)
        {
            var __workflow_facilityCode = WorkflowExpression.Compile(facilityCode, nameof(facilityCode), required: true);
            return new DeferredBodyAction<GetFacilitybyCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/facility/{0}", __workflow_facilityCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFacilitybyCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetWeatherStationsResponseItem[], ApiConnectionActionConfiguration> GetWeatherStations()
        {
            return new DeferredBodyAction<GetWeatherStationsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/weather/station";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetWeatherStationsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetWeatherStationbyCodeResponse, ApiConnectionActionConfiguration> GetWeatherStationbyCode(Expression<Func<string>> stationCode)
        {
            var __workflow_stationCode = WorkflowExpression.Compile(stationCode, nameof(stationCode), required: true);
            return new DeferredBodyAction<GetWeatherStationbyCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/weather/station/{0}", __workflow_stationCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetWeatherStationbyCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetWeatherStationObservationsResponse, ApiConnectionActionConfiguration> GetWeatherStationObservations(Expression<Func<string>> stationCode, Expression<Func<string>> intervalHuman = null, Expression<Func<string>> periodHuman = null, Expression<Func<string>> networkCode = null, Expression<Func<string>> timezone = null, Expression<Func<string>> offset = null, Expression<Func<int>> year = null)
        {
            var __workflow_stationCode = WorkflowExpression.Compile(stationCode, nameof(stationCode), required: true);
            var __workflow_intervalHuman = WorkflowExpression.Compile(intervalHuman, nameof(intervalHuman), required: false);
            var __workflow_periodHuman = WorkflowExpression.Compile(periodHuman, nameof(periodHuman), required: false);
            var __workflow_networkCode = WorkflowExpression.Compile(networkCode, nameof(networkCode), required: false);
            var __workflow_timezone = WorkflowExpression.Compile(timezone, nameof(timezone), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_year = WorkflowExpression.Compile(year, nameof(year), required: false);
            return new DeferredBodyAction<GetWeatherStationObservationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/weather/station/observation/{0}", __workflow_stationCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_intervalHuman != null)
                    callPayload.Queries["interval_human"] = ExpressionConverter.Convert(__workflow_intervalHuman);
                if (__workflow_periodHuman != null)
                    callPayload.Queries["period_human"] = ExpressionConverter.Convert(__workflow_periodHuman);
                if (__workflow_networkCode != null)
                    callPayload.Queries["network_code"] = ExpressionConverter.Convert(__workflow_networkCode);
                if (__workflow_timezone != null)
                    callPayload.Queries["timezone"] = ExpressionConverter.Convert(__workflow_timezone);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_year != null)
                    callPayload.Queries["year"] = ExpressionConverter.Convert(__workflow_year);
                return new ApiConnectionAction<GetWeatherStationObservationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetNetworkRegionsResponseItem[], ApiConnectionActionConfiguration> GetNetworkRegions(Expression<Func<string>> networkCode)
        {
            var __workflow_networkCode = WorkflowExpression.Compile(networkCode, nameof(networkCode), required: true);
            return new DeferredBodyAction<GetNetworkRegionsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/networks/regions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_code"] = ExpressionConverter.Convert(__workflow_networkCode);
                return new ApiConnectionAction<GetNetworkRegionsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetFuelTechnologiesResponseItem[], ApiConnectionActionConfiguration> GetFuelTechnologies()
        {
            return new DeferredBodyAction<GetFuelTechnologiesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fueltechs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFuelTechnologiesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetIntervalsResponseItem[], ApiConnectionActionConfiguration> GetIntervals()
        {
            return new DeferredBodyAction<GetIntervalsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/intervals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetIntervalsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetPeriodsResponseItem[], ApiConnectionActionConfiguration> GetPeriods()
        {
            return new DeferredBodyAction<GetPeriodsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/periods";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPeriodsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetUnitsResponseItem[], ApiConnectionActionConfiguration> GetUnits()
        {
            return new DeferredBodyAction<GetUnitsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/units";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUnitsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetPowerbyStationResponse, ApiConnectionActionConfiguration> GetPowerbyStation(Expression<Func<string>> networkCode, Expression<Func<string>> stationCode, Expression<Func<string>> since = null, Expression<Func<string>> intervalHuman = null, Expression<Func<string>> periodHuman = null)
        {
            var __workflow_networkCode = WorkflowExpression.Compile(networkCode, nameof(networkCode), required: true);
            var __workflow_stationCode = WorkflowExpression.Compile(stationCode, nameof(stationCode), required: true);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: false);
            var __workflow_intervalHuman = WorkflowExpression.Compile(intervalHuman, nameof(intervalHuman), required: false);
            var __workflow_periodHuman = WorkflowExpression.Compile(periodHuman, nameof(periodHuman), required: false);
            return new DeferredBodyAction<GetPowerbyStationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/stats/power/station/{0}/{1}", __workflow_networkCode.WithUrlEncoding(1), __workflow_stationCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_since != null)
                    callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                if (__workflow_intervalHuman != null)
                    callPayload.Queries["interval_human"] = ExpressionConverter.Convert(__workflow_intervalHuman);
                if (__workflow_periodHuman != null)
                    callPayload.Queries["period_human"] = ExpressionConverter.Convert(__workflow_periodHuman);
                return new ApiConnectionAction<GetPowerbyStationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetEnergybyStationResponse, ApiConnectionActionConfiguration> GetEnergybyStation(Expression<Func<string>> networkCode, Expression<Func<string>> stationCode, Expression<Func<string>> interval = null, Expression<Func<string>> period = null)
        {
            var __workflow_networkCode = WorkflowExpression.Compile(networkCode, nameof(networkCode), required: true);
            var __workflow_stationCode = WorkflowExpression.Compile(stationCode, nameof(stationCode), required: true);
            var __workflow_interval = WorkflowExpression.Compile(interval, nameof(interval), required: false);
            var __workflow_period = WorkflowExpression.Compile(period, nameof(period), required: false);
            return new DeferredBodyAction<GetEnergybyStationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/stats/energy/station/{0}/{1}", __workflow_networkCode.WithUrlEncoding(1), __workflow_stationCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_interval != null)
                    callPayload.Queries["interval"] = ExpressionConverter.Convert(__workflow_interval);
                if (__workflow_period != null)
                    callPayload.Queries["period"] = ExpressionConverter.Convert(__workflow_period);
                return new ApiConnectionAction<GetEnergybyStationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetInterconnectorFlowNetworkResponse, ApiConnectionActionConfiguration> GetInterconnectorFlowNetwork(Expression<Func<string>> networkCode, Expression<Func<string>> month = null)
        {
            var __workflow_networkCode = WorkflowExpression.Compile(networkCode, nameof(networkCode), required: true);
            var __workflow_month = WorkflowExpression.Compile(month, nameof(month), required: false);
            return new DeferredBodyAction<GetInterconnectorFlowNetworkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/stats/flow/network/{0}", __workflow_networkCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_month != null)
                    callPayload.Queries["month"] = ExpressionConverter.Convert(__workflow_month);
                return new ApiConnectionAction<GetInterconnectorFlowNetworkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetPowerNetworkRegionByFueltechResponse, ApiConnectionActionConfiguration> GetPowerNetworkRegionByFueltech(Expression<Func<string>> networkCode, Expression<Func<string>> networkRegionCode, Expression<Func<string>> month = null)
        {
            var __workflow_networkCode = WorkflowExpression.Compile(networkCode, nameof(networkCode), required: true);
            var __workflow_networkRegionCode = WorkflowExpression.Compile(networkRegionCode, nameof(networkRegionCode), required: true);
            var __workflow_month = WorkflowExpression.Compile(month, nameof(month), required: false);
            return new DeferredBodyAction<GetPowerNetworkRegionByFueltechResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/stats/power/network/fueltech/{0}/{1}", __workflow_networkCode.WithUrlEncoding(1), __workflow_networkRegionCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_month != null)
                    callPayload.Queries["month"] = ExpressionConverter.Convert(__workflow_month);
                return new ApiConnectionAction<GetPowerNetworkRegionByFueltechResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetEmissionFactorPerNetworkRegionResponse, ApiConnectionActionConfiguration> GetEmissionFactorPerNetworkRegion(Expression<Func<string>> networkCode, Expression<Func<string>> interval = null)
        {
            var __workflow_networkCode = WorkflowExpression.Compile(networkCode, nameof(networkCode), required: true);
            var __workflow_interval = WorkflowExpression.Compile(interval, nameof(interval), required: false);
            return new DeferredBodyAction<GetEmissionFactorPerNetworkRegionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/stats/emissionfactor/network/{0}", __workflow_networkCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_interval != null)
                    callPayload.Queries["interval"] = ExpressionConverter.Convert(__workflow_interval);
                return new ApiConnectionAction<GetEmissionFactorPerNetworkRegionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetFueltechMixByNetworkResponse, ApiConnectionActionConfiguration> GetFueltechMixByNetwork(Expression<Func<string>> networkId)
        {
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: true);
            return new DeferredBodyAction<GetFueltechMixByNetworkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/stats/fueltech_mix/{0}", __workflow_networkId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFueltechMixByNetworkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetPriceHistoryByNetworkandNetworkRegionResponse, ApiConnectionActionConfiguration> GetPriceHistoryByNetworkandNetworkRegion(Expression<Func<string>> networkCode, Expression<Func<string>> networkRegion = null)
        {
            var __workflow_networkCode = WorkflowExpression.Compile(networkCode, nameof(networkCode), required: true);
            var __workflow_networkRegion = WorkflowExpression.Compile(networkRegion, nameof(networkRegion), required: false);
            return new DeferredBodyAction<GetPriceHistoryByNetworkandNetworkRegionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/stats/price/{0}", __workflow_networkCode.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_networkRegion != null)
                    callPayload.Queries["network_region"] = ExpressionConverter.Convert(__workflow_networkRegion);
                return new ApiConnectionAction<GetPriceHistoryByNetworkandNetworkRegionResponse>(callPayload);
            });
        }
    }

    public class OpennemipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetNetworksResponseItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("regions")]
        public GetNetworksResponseItemRegionsTypeItem[] Regions { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("interval_size")]
        public int IntervalSize { get; set; }
    }

    public class GetNetworksResponseItemRegionsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetStationsResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("response_status")]
        public string ResponseStatus { get; set; }

        [JsonProperty("total_records")]
        public int TotalRecords { get; set; }

        [JsonProperty("data")]
        public GetStationsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetStationsResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("network_name")]
        public string NetworkName { get; set; }

        [JsonProperty("location_id")]
        public int LocationId { get; set; }

        [JsonProperty("facilities")]
        public GetStationsResponseDataTypeItemFacilitiesTypeItem[] Facilities { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("wikipedia_link")]
        public string WikipediaLink { get; set; }

        [JsonProperty("wikidata_id")]
        public string WikidataId { get; set; }
    }

    public class GetStationsResponseDataTypeItemFacilitiesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("network")]
        public GetStationsResponseDataTypeItemFacilitiesTypeItemNetworkType Network { get; set; }

        [JsonProperty("fueltech")]
        public GetStationsResponseDataTypeItemFacilitiesTypeItemFueltechType Fueltech { get; set; }

        [JsonProperty("status")]
        public GetStationsResponseDataTypeItemFacilitiesTypeItemStatusType Status { get; set; }

        [JsonProperty("station_id")]
        public int StationId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("dispatch_type")]
        public string DispatchType { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("capacity_registered")]
        public double CapacityRegistered { get; set; }

        [JsonProperty("network_region")]
        public string NetworkRegion { get; set; }

        [JsonProperty("unit_number")]
        public int UnitNumber { get; set; }

        [JsonProperty("unit_capacity")]
        public double UnitCapacity { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("approved_by")]
        public string ApprovedBy { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }

        [JsonProperty("unit_id")]
        public int UnitId { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }

        [JsonProperty("emissions_factor_co2")]
        public double EmissionsFactorCo2 { get; set; }
    }

    public class GetStationsResponseDataTypeItemFacilitiesTypeItemNetworkType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("regions")]
        public GetStationsResponseDataTypeItemFacilitiesTypeItemNetworkTypeRegionsTypeItem[] Regions { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_database")]
        public string TimezoneDatabase { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("interval_size")]
        public int IntervalSize { get; set; }

        [JsonProperty("interval_shift")]
        public int IntervalShift { get; set; }

        [JsonProperty("intervals_per_hour")]
        public double IntervalsPerHour { get; set; }
    }

    public class GetStationsResponseDataTypeItemFacilitiesTypeItemNetworkTypeRegionsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetStationsResponseDataTypeItemFacilitiesTypeItemFueltechType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("renewable")]
        public bool Renewable { get; set; }
    }

    public class GetStationsResponseDataTypeItemFacilitiesTypeItemStatusType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetStationByIdResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("response_status")]
        public string ResponseStatus { get; set; }

        [JsonProperty("total_records")]
        public int TotalRecords { get; set; }

        [JsonProperty("record")]
        public GetStationByIdResponseRecordType Record { get; set; }
    }

    public class GetStationByIdResponseRecordType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("network_name")]
        public string NetworkName { get; set; }

        [JsonProperty("location_id")]
        public int LocationId { get; set; }

        [JsonProperty("facilities")]
        public GetStationByIdResponseRecordTypeFacilitiesTypeItem[] Facilities { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("wikipedia_link")]
        public string WikipediaLink { get; set; }

        [JsonProperty("wikidata_id")]
        public string WikidataId { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }
    }

    public class GetStationByIdResponseRecordTypeFacilitiesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("network")]
        public GetStationByIdResponseRecordTypeFacilitiesTypeItemNetworkType Network { get; set; }

        [JsonProperty("fueltech")]
        public GetStationByIdResponseRecordTypeFacilitiesTypeItemFueltechType Fueltech { get; set; }

        [JsonProperty("status")]
        public GetStationByIdResponseRecordTypeFacilitiesTypeItemStatusType Status { get; set; }

        [JsonProperty("station_id")]
        public int StationId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("dispatch_type")]
        public string DispatchType { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("capacity_registered")]
        public double CapacityRegistered { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }

        [JsonProperty("deregistered")]
        public string Deregistered { get; set; }

        [JsonProperty("expected_closure_date")]
        public string ExpectedClosureDate { get; set; }

        [JsonProperty("expected_closure_year")]
        public string ExpectedClosureYear { get; set; }

        [JsonProperty("network_region")]
        public string NetworkRegion { get; set; }

        [JsonProperty("unit_id")]
        public int UnitId { get; set; }

        [JsonProperty("unit_number")]
        public int UnitNumber { get; set; }

        [JsonProperty("unit_alias")]
        public string UnitAlias { get; set; }

        [JsonProperty("unit_capacity")]
        public double UnitCapacity { get; set; }

        [JsonProperty("emissions_factor_co2")]
        public double EmissionsFactorCo2 { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("approved_by")]
        public string ApprovedBy { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }
    }

    public class GetStationByIdResponseRecordTypeFacilitiesTypeItemNetworkType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("regions")]
        public GetStationByIdResponseRecordTypeFacilitiesTypeItemNetworkTypeRegionsTypeItem[] Regions { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_database")]
        public string TimezoneDatabase { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("interval_size")]
        public int IntervalSize { get; set; }

        [JsonProperty("interval_shift")]
        public int IntervalShift { get; set; }

        [JsonProperty("intervals_per_hour")]
        public double IntervalsPerHour { get; set; }
    }

    public class GetStationByIdResponseRecordTypeFacilitiesTypeItemNetworkTypeRegionsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetStationByIdResponseRecordTypeFacilitiesTypeItemFueltechType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("renewable")]
        public bool Renewable { get; set; }
    }

    public class GetStationByIdResponseRecordTypeFacilitiesTypeItemStatusType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetSingleStationbyCodeResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("facilities")]
        public GetSingleStationbyCodeResponseFacilitiesTypeItem[] Facilities { get; set; }

        [JsonProperty("photos")]
        public JToken[] Photos { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("network_name")]
        public string NetworkName { get; set; }

        [JsonProperty("location")]
        public GetSingleStationbyCodeResponseLocationType Location { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }
    }

    public class GetSingleStationbyCodeResponseFacilitiesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("fueltech")]
        public string Fueltech { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("dispatch_type")]
        public string DispatchType { get; set; }

        [JsonProperty("capacity_registered")]
        public double CapacityRegistered { get; set; }

        [JsonProperty("network_region")]
        public string NetworkRegion { get; set; }

        [JsonProperty("data_first_seen")]
        public string DataFirstSeen { get; set; }

        [JsonProperty("data_last_seen")]
        public string DataLastSeen { get; set; }
    }

    public class GetSingleStationbyCodeResponseLocationType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("geocode_approved")]
        public bool GeocodeApproved { get; set; }

        [JsonProperty("geocode_skip")]
        public bool GeocodeSkip { get; set; }

        [JsonProperty("geocode_by")]
        public string GeocodeBy { get; set; }

        [JsonProperty("geom")]
        public GetSingleStationbyCodeResponseLocationTypeGeomType Geom { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class GetSingleStationbyCodeResponseLocationTypeGeomType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("coordinates")]
        public double[] Coordinates { get; set; }
    }

    public class GetFacilitiesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("network")]
        public GetFacilitiesResponseItemNetworkType Network { get; set; }

        [JsonProperty("fueltech")]
        public GetFacilitiesResponseItemFueltechType Fueltech { get; set; }

        [JsonProperty("status")]
        public GetFacilitiesResponseItemStatusType Status { get; set; }

        [JsonProperty("station_id")]
        public int StationId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("dispatch_type")]
        public string DispatchType { get; set; }

        [JsonProperty("capacity_registered")]
        public double CapacityRegistered { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }

        [JsonProperty("deregistered")]
        public string Deregistered { get; set; }

        [JsonProperty("network_region")]
        public string NetworkRegion { get; set; }

        [JsonProperty("unit_id")]
        public int UnitId { get; set; }

        [JsonProperty("unit_number")]
        public int UnitNumber { get; set; }

        [JsonProperty("unit_alias")]
        public string UnitAlias { get; set; }

        [JsonProperty("unit_capacity")]
        public double UnitCapacity { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("approved_by")]
        public string ApprovedBy { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }
    }

    public class GetFacilitiesResponseItemNetworkType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("regions")]
        public GetFacilitiesResponseItemNetworkTypeRegionsTypeItem[] Regions { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_database")]
        public string TimezoneDatabase { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("interval_size")]
        public int IntervalSize { get; set; }

        [JsonProperty("interval_shift")]
        public int IntervalShift { get; set; }

        [JsonProperty("intervals_per_hour")]
        public double IntervalsPerHour { get; set; }
    }

    public class GetFacilitiesResponseItemNetworkTypeRegionsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetFacilitiesResponseItemFueltechType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("renewable")]
        public bool Renewable { get; set; }
    }

    public class GetFacilitiesResponseItemStatusType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetFacilitybyCodeResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("network")]
        public GetFacilitybyCodeResponseNetworkType Network { get; set; }

        [JsonProperty("fueltech")]
        public GetFacilitybyCodeResponseFueltechType Fueltech { get; set; }

        [JsonProperty("status")]
        public GetFacilitybyCodeResponseStatusType Status { get; set; }

        [JsonProperty("station_id")]
        public int StationId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("dispatch_type")]
        public string DispatchType { get; set; }

        [JsonProperty("capacity_registered")]
        public int CapacityRegistered { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }

        [JsonProperty("deregistered")]
        public string Deregistered { get; set; }

        [JsonProperty("network_region")]
        public string NetworkRegion { get; set; }

        [JsonProperty("unit_id")]
        public string UnitId { get; set; }

        [JsonProperty("unit_number")]
        public string UnitNumber { get; set; }

        [JsonProperty("unit_alias")]
        public string UnitAlias { get; set; }

        [JsonProperty("unit_capacity")]
        public string UnitCapacity { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("approved_by")]
        public string ApprovedBy { get; set; }

        [JsonProperty("approved_at")]
        public string ApprovedAt { get; set; }
    }

    public class GetFacilitybyCodeResponseNetworkType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("regions")]
        public GetFacilitybyCodeResponseNetworkTypeRegionsTypeItem[] Regions { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_database")]
        public string TimezoneDatabase { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("interval_size")]
        public int IntervalSize { get; set; }

        [JsonProperty("interval_shift")]
        public int IntervalShift { get; set; }

        [JsonProperty("intervals_per_hour")]
        public int IntervalsPerHour { get; set; }
    }

    public class GetFacilitybyCodeResponseNetworkTypeRegionsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetFacilitybyCodeResponseFueltechType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("renewable")]
        public bool Renewable { get; set; }
    }

    public class GetFacilitybyCodeResponseStatusType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
    }

    public class GetWeatherStationsResponseItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("name_alias")]
        public string NameAlias { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("altitude")]
        public int Altitude { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }
    }

    public class GetWeatherStationbyCodeResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("name_alias")]
        public string NameAlias { get; set; }

        [JsonProperty("registered")]
        public string Registered { get; set; }

        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("altitude")]
        public int Altitude { get; set; }

        [JsonProperty("lat")]
        public int Lat { get; set; }

        [JsonProperty("lng")]
        public int Lng { get; set; }

        [JsonProperty("observations")]
        public GetWeatherStationbyCodeResponseObservationsTypeItem[] Observations { get; set; }
    }

    public class GetWeatherStationbyCodeResponseObservationsTypeItem
    {
        [JsonProperty("observation_time")]
        public string ObservationTime { get; set; }

        [JsonProperty("station_id")]
        public int StationId { get; set; }

        [JsonProperty("temp_apparent")]
        public int TempApparent { get; set; }

        [JsonProperty("temp_air")]
        public int TempAir { get; set; }

        [JsonProperty("press_qnh")]
        public int PressQnh { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("wind_spd")]
        public int WindSpd { get; set; }

        [JsonProperty("wind_gust")]
        public int WindGust { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("cloud")]
        public string Cloud { get; set; }

        [JsonProperty("cloud_type")]
        public string CloudType { get; set; }
    }

    public class GetWeatherStationObservationsResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("response_status")]
        public string ResponseStatus { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }
    }

    public class GetNetworkRegionsResponseItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public class GetFuelTechnologiesResponseItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("renewable")]
        public bool Renewable { get; set; }
    }

    public class GetIntervalsResponseItem
    {
        [JsonProperty("interval")]
        public int Interval { get; set; }

        [JsonProperty("interval_human")]
        public string IntervalHuman { get; set; }

        [JsonProperty("interval_sql")]
        public string IntervalSql { get; set; }

        [JsonProperty("trunc")]
        public string Trunc { get; set; }
    }

    public class GetPeriodsResponseItem
    {
        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("period_human")]
        public string PeriodHuman { get; set; }

        [JsonProperty("period_sql")]
        public string PeriodSql { get; set; }
    }

    public class GetUnitsResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_alias")]
        public string NameAlias { get; set; }

        [JsonProperty("unit_type")]
        public string UnitType { get; set; }

        [JsonProperty("round_to")]
        public int RoundTo { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("cast_nulls")]
        public bool CastNulls { get; set; }
    }

    public class GetPowerbyStationResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("response_status")]
        public string ResponseStatus { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }
    }

    public class GetEnergybyStationResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("response_status")]
        public string ResponseStatus { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }
    }

    public class GetInterconnectorFlowNetworkResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("response_status")]
        public string ResponseStatus { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }
    }

    public class GetPowerNetworkRegionByFueltechResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("response_status")]
        public string ResponseStatus { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }
    }

    public class GetEmissionFactorPerNetworkRegionResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("response_status")]
        public string ResponseStatus { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }
    }

    public class GetFueltechMixByNetworkResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("response_status")]
        public string ResponseStatus { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }
    }

    public class GetPriceHistoryByNetworkandNetworkRegionResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("data")]
        public GetPriceHistoryByNetworkandNetworkRegionResponseDataTypeItem[] Data { get; set; }
    }

    public class GetPriceHistoryByNetworkandNetworkRegionResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("network")]
        public string Network { get; set; }

        [JsonProperty("data_type")]
        public string DataType { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }

        [JsonProperty("history")]
        public GetPriceHistoryByNetworkandNetworkRegionResponseDataTypeItemHistoryType History { get; set; }
    }

    public class GetPriceHistoryByNetworkandNetworkRegionResponseDataTypeItemHistoryType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Opennemip;

    public partial class WorkflowManagedActions
    {
        public OpennemipActions Opennemip(string connectionId) => new OpennemipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OpennemipTriggers Opennemip(string connectionId) => new OpennemipTriggers(connectionId);
    }
}