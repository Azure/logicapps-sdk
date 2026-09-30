//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Opennemip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OpennemipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetNetworksResponseItem[]> GetNetworks()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/networks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetNetworksResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetStationsResponse> GetStations([WorkflowExpression] Func<bool> facilitiesInclude = null, [WorkflowExpression] Func<bool> onlyApproved = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> page = null)
        {
            SourceExpression.Validate(facilitiesInclude, nameof(facilitiesInclude), required: false);
            SourceExpression.Validate(onlyApproved, nameof(onlyApproved), required: false);
            SourceExpression.Validate(name, nameof(name), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(page, nameof(page), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/station/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (facilitiesInclude != null)
                    callPayload.Queries["facilities_include"] = SourceExpressionConverter.ConvertO(facilitiesInclude);
                if (onlyApproved != null)
                    callPayload.Queries["only_approved"] = SourceExpressionConverter.ConvertO(onlyApproved);
                if (name != null)
                    callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<GetStationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetStationByIdResponse> GetStationById([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/station/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetStationByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetSingleStationbyCodeResponse> GetSingleStationbyCode([WorkflowExpression] Func<string> networkId, [WorkflowExpression] Func<string> stationCode)
        {
            SourceExpression.Validate(networkId, nameof(networkId), required: true);
            SourceExpression.Validate(stationCode, nameof(stationCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/station/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "au"), 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(networkId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSingleStationbyCodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetFacilitiesResponseItem[]> GetFacilities()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/facility/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFacilitiesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetFacilitybyCodeResponse> GetFacilitybyCode([WorkflowExpression] Func<string> facilityCode)
        {
            SourceExpression.Validate(facilityCode, nameof(facilityCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/facility/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(facilityCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFacilitybyCodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetWeatherStationsResponseItem[]> GetWeatherStations()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/weather/station";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetWeatherStationsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetWeatherStationbyCodeResponse> GetWeatherStationbyCode([WorkflowExpression] Func<string> stationCode)
        {
            SourceExpression.Validate(stationCode, nameof(stationCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/weather/station/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetWeatherStationbyCodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetWeatherStationObservationsResponse> GetWeatherStationObservations([WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> intervalHuman = null, [WorkflowExpression] Func<string> periodHuman = null, [WorkflowExpression] Func<string> networkCode = null, [WorkflowExpression] Func<string> timezone = null, [WorkflowExpression] Func<string> offset = null, [WorkflowExpression] Func<int> year = null)
        {
            SourceExpression.Validate(stationCode, nameof(stationCode), required: true);
            SourceExpression.Validate(intervalHuman, nameof(intervalHuman), required: false);
            SourceExpression.Validate(periodHuman, nameof(periodHuman), required: false);
            SourceExpression.Validate(networkCode, nameof(networkCode), required: false);
            SourceExpression.Validate(timezone, nameof(timezone), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            SourceExpression.Validate(year, nameof(year), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/weather/station/observation/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (intervalHuman != null)
                    callPayload.Queries["interval_human"] = SourceExpressionConverter.ConvertO(intervalHuman);
                if (periodHuman != null)
                    callPayload.Queries["period_human"] = SourceExpressionConverter.ConvertO(periodHuman);
                if (networkCode != null)
                    callPayload.Queries["network_code"] = SourceExpressionConverter.ConvertO(networkCode);
                if (timezone != null)
                    callPayload.Queries["timezone"] = SourceExpressionConverter.ConvertO(timezone);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (year != null)
                    callPayload.Queries["year"] = SourceExpressionConverter.ConvertO(year);
                return callPayload;
            }

            return new ApiConnectionAction<GetWeatherStationObservationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetNetworkRegionsResponseItem[]> GetNetworkRegions([WorkflowExpression] Func<string> networkCode)
        {
            SourceExpression.Validate(networkCode, nameof(networkCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/networks/regions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["network_code"] = SourceExpressionConverter.ConvertO(networkCode);
                return callPayload;
            }

            return new ApiConnectionAction<GetNetworkRegionsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetFuelTechnologiesResponseItem[]> GetFuelTechnologies()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fueltechs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFuelTechnologiesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetIntervalsResponseItem[]> GetIntervals()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/intervals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetIntervalsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetPeriodsResponseItem[]> GetPeriods()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/periods";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetPeriodsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetUnitsResponseItem[]> GetUnits()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/units";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetUnitsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetPowerbyStationResponse> GetPowerbyStation([WorkflowExpression] Func<string> networkCode, [WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> since = null, [WorkflowExpression] Func<string> intervalHuman = null, [WorkflowExpression] Func<string> periodHuman = null)
        {
            SourceExpression.Validate(networkCode, nameof(networkCode), required: true);
            SourceExpression.Validate(stationCode, nameof(stationCode), required: true);
            SourceExpression.Validate(since, nameof(since), required: false);
            SourceExpression.Validate(intervalHuman, nameof(intervalHuman), required: false);
            SourceExpression.Validate(periodHuman, nameof(periodHuman), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/stats/power/station/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(networkCode, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (since != null)
                    callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                if (intervalHuman != null)
                    callPayload.Queries["interval_human"] = SourceExpressionConverter.ConvertO(intervalHuman);
                if (periodHuman != null)
                    callPayload.Queries["period_human"] = SourceExpressionConverter.ConvertO(periodHuman);
                return callPayload;
            }

            return new ApiConnectionAction<GetPowerbyStationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetEnergybyStationResponse> GetEnergybyStation([WorkflowExpression] Func<string> networkCode, [WorkflowExpression] Func<string> stationCode, [WorkflowExpression] Func<string> interval = null, [WorkflowExpression] Func<string> period = null)
        {
            SourceExpression.Validate(networkCode, nameof(networkCode), required: true);
            SourceExpression.Validate(stationCode, nameof(stationCode), required: true);
            SourceExpression.Validate(interval, nameof(interval), required: false);
            SourceExpression.Validate(period, nameof(period), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/stats/energy/station/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(networkCode, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (interval != null)
                    callPayload.Queries["interval"] = SourceExpressionConverter.ConvertO(interval);
                if (period != null)
                    callPayload.Queries["period"] = SourceExpressionConverter.ConvertO(period);
                return callPayload;
            }

            return new ApiConnectionAction<GetEnergybyStationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetInterconnectorFlowNetworkResponse> GetInterconnectorFlowNetwork([WorkflowExpression] Func<string> networkCode, [WorkflowExpression] Func<string> month = null)
        {
            SourceExpression.Validate(networkCode, nameof(networkCode), required: true);
            SourceExpression.Validate(month, nameof(month), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/stats/flow/network/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(networkCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (month != null)
                    callPayload.Queries["month"] = SourceExpressionConverter.ConvertO(month);
                return callPayload;
            }

            return new ApiConnectionAction<GetInterconnectorFlowNetworkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetPowerNetworkRegionByFueltechResponse> GetPowerNetworkRegionByFueltech([WorkflowExpression] Func<string> networkCode, [WorkflowExpression] Func<string> networkRegionCode, [WorkflowExpression] Func<string> month = null)
        {
            SourceExpression.Validate(networkCode, nameof(networkCode), required: true);
            SourceExpression.Validate(networkRegionCode, nameof(networkRegionCode), required: true);
            SourceExpression.Validate(month, nameof(month), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/stats/power/network/fueltech/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(networkCode, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(networkRegionCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (month != null)
                    callPayload.Queries["month"] = SourceExpressionConverter.ConvertO(month);
                return callPayload;
            }

            return new ApiConnectionAction<GetPowerNetworkRegionByFueltechResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetEmissionFactorPerNetworkRegionResponse> GetEmissionFactorPerNetworkRegion([WorkflowExpression] Func<string> networkCode, [WorkflowExpression] Func<string> interval = null)
        {
            SourceExpression.Validate(networkCode, nameof(networkCode), required: true);
            SourceExpression.Validate(interval, nameof(interval), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/stats/emissionfactor/network/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(networkCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (interval != null)
                    callPayload.Queries["interval"] = SourceExpressionConverter.ConvertO(interval);
                return callPayload;
            }

            return new ApiConnectionAction<GetEmissionFactorPerNetworkRegionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetFueltechMixByNetworkResponse> GetFueltechMixByNetwork([WorkflowExpression] Func<string> networkId)
        {
            SourceExpression.Validate(networkId, nameof(networkId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/stats/fueltech_mix/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(networkId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFueltechMixByNetworkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "opennemip")]
        public IBodyWorkflowAction<GetPriceHistoryByNetworkandNetworkRegionResponse> GetPriceHistoryByNetworkandNetworkRegion([WorkflowExpression] Func<string> networkCode, [WorkflowExpression] Func<string> networkRegion = null)
        {
            SourceExpression.Validate(networkCode, nameof(networkCode), required: true);
            SourceExpression.Validate(networkRegion, nameof(networkRegion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/stats/price/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(networkCode, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (networkRegion != null)
                    callPayload.Queries["network_region"] = SourceExpressionConverter.ConvertO(networkRegion);
                return callPayload;
            }

            return new ApiConnectionAction<GetPriceHistoryByNetworkandNetworkRegionResponse>(BuildSourceInput);
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