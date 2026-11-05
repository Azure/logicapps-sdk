//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nrelip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NrelipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nrelip")]
        public IBodyWorkflowAction<StandardWorkSpecsResponseItem[], ApiConnectionActionConfiguration> StandardWorkSpecs(Expression<Func<int>> nid = null, Expression<Func<string>> spec = null, Expression<Func<HtInput>> ht = null, Expression<Func<int>> section = null, Expression<Func<int>> topic = null, Expression<Func<int>> subtopic = null)
        {
            var __workflow_nid = WorkflowExpression.Compile(nid, nameof(nid), required: false);
            var __workflow_spec = WorkflowExpression.Compile(spec, nameof(spec), required: false);
            var __workflow_ht = WorkflowExpression.Compile(ht, nameof(ht), required: false);
            var __workflow_section = WorkflowExpression.Compile(section, nameof(section), required: false);
            var __workflow_topic = WorkflowExpression.Compile(topic, nameof(topic), required: false);
            var __workflow_subtopic = WorkflowExpression.Compile(subtopic, nameof(subtopic), required: false);
            return new DeferredBodyAction<StandardWorkSpecsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/standard-work-specs/spec/v1.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_nid != null)
                    callPayload.Queries["nid"] = ExpressionConverter.Convert(__workflow_nid);
                if (__workflow_spec != null)
                    callPayload.Queries["spec"] = ExpressionConverter.Convert(__workflow_spec);
                if (__workflow_ht != null)
                    callPayload.Queries["ht"] = ExpressionConverter.Convert(__workflow_ht);
                if (__workflow_section != null)
                    callPayload.Queries["section"] = ExpressionConverter.Convert(__workflow_section);
                if (__workflow_topic != null)
                    callPayload.Queries["topic"] = ExpressionConverter.Convert(__workflow_topic);
                if (__workflow_subtopic != null)
                    callPayload.Queries["subtopic"] = ExpressionConverter.Convert(__workflow_subtopic);
                return new ApiConnectionAction<StandardWorkSpecsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nrelip")]
        public IBodyWorkflowAction<UtilityRatesResponse, ApiConnectionActionConfiguration> UtilityRates(Expression<Func<string>> address = null, Expression<Func<double>> lat = null, Expression<Func<double>> lon = null, Expression<Func<double>> radius = null, Expression<Func<int>> limit = null)
        {
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: false);
            var __workflow_lat = WorkflowExpression.Compile(lat, nameof(lat), required: false);
            var __workflow_lon = WorkflowExpression.Compile(lon, nameof(lon), required: false);
            var __workflow_radius = WorkflowExpression.Compile(radius, nameof(radius), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<UtilityRatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/utility_rates/v3.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(__workflow_lat);
                if (__workflow_lon != null)
                    callPayload.Queries["lon"] = ExpressionConverter.Convert(__workflow_lon);
                callPayload.Queries["radius"] = Convert.ToString(0);
                if (__workflow_radius != null)
                    callPayload.Queries["radius"] = ExpressionConverter.Convert(__workflow_radius);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<UtilityRatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nrelip")]
        public IBodyWorkflowAction<UtilityRatesCensusResponse, ApiConnectionActionConfiguration> UtilityRatesCensus(Expression<Func<int>> id = null, Expression<Func<string>> address = null, Expression<Func<double>> lat = null, Expression<Func<double>> lon = null, Expression<Func<RegionInput>> region = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: false);
            var __workflow_lat = WorkflowExpression.Compile(lat, nameof(lat), required: false);
            var __workflow_lon = WorkflowExpression.Compile(lon, nameof(lon), required: false);
            var __workflow_region = WorkflowExpression.Compile(region, nameof(region), required: false);
            return new DeferredBodyAction<UtilityRatesCensusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/census_rate/v3.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(__workflow_lat);
                if (__workflow_lon != null)
                    callPayload.Queries["lon"] = ExpressionConverter.Convert(__workflow_lon);
                callPayload.Queries["region"] = Convert.ToString("block");
                if (__workflow_region != null)
                    callPayload.Queries["region"] = ExpressionConverter.Convert(__workflow_region);
                return new ApiConnectionAction<UtilityRatesCensusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nrelip")]
        public IBodyWorkflowAction<SolarResourceResponse, ApiConnectionActionConfiguration> SolarResource(Expression<Func<string>> address = null, Expression<Func<double>> lat = null, Expression<Func<double>> lon = null)
        {
            var __workflow_address = WorkflowExpression.Compile(address, nameof(address), required: false);
            var __workflow_lat = WorkflowExpression.Compile(lat, nameof(lat), required: false);
            var __workflow_lon = WorkflowExpression.Compile(lon, nameof(lon), required: false);
            return new DeferredBodyAction<SolarResourceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/solar/solar_resource/v1.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_address != null)
                    callPayload.Queries["address"] = ExpressionConverter.Convert(__workflow_address);
                if (__workflow_lat != null)
                    callPayload.Queries["lat"] = ExpressionConverter.Convert(__workflow_lat);
                if (__workflow_lon != null)
                    callPayload.Queries["lon"] = ExpressionConverter.Convert(__workflow_lon);
                return new ApiConnectionAction<SolarResourceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nrelip")]
        public IBodyWorkflowAction<AlternativeFuelStationsResponse, ApiConnectionActionConfiguration> AlternativeFuelStations(Expression<Func<StatusInput>> status = null, Expression<Func<AccessInput>> access = null, Expression<Func<string>> fuelType = null, Expression<Func<string>> cardsAccepted = null, Expression<Func<string>> ownerType = null, Expression<Func<string>> federalAgency = null, Expression<Func<string>> cngFillType = null, Expression<Func<string>> cngPsa = null, Expression<Func<CngVehicleClassInput>> cngVehicleClass = null, Expression<Func<E85HasBlenderPumpInput>> e85HasBlenderPump = null, Expression<Func<string>> evNetwork = null, Expression<Func<EvChargingLevelInput>> evChargingLevel = null, Expression<Func<EvConnectorTypeInput>> evConnectorType = null, Expression<Func<string>> hyIsRetail = null, Expression<Func<LngVehicleClassInput>> lngVehicleClass = null, Expression<Func<LpgIncludeSecondaryInput>> lpgIncludeSecondary = null, Expression<Func<string>> state = null, Expression<Func<string>> zip = null, Expression<Func<CountryInput>> country = null, Expression<Func<string>> limit = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_access = WorkflowExpression.Compile(access, nameof(access), required: false);
            var __workflow_fuelType = WorkflowExpression.Compile(fuelType, nameof(fuelType), required: false);
            var __workflow_cardsAccepted = WorkflowExpression.Compile(cardsAccepted, nameof(cardsAccepted), required: false);
            var __workflow_ownerType = WorkflowExpression.Compile(ownerType, nameof(ownerType), required: false);
            var __workflow_federalAgency = WorkflowExpression.Compile(federalAgency, nameof(federalAgency), required: false);
            var __workflow_cngFillType = WorkflowExpression.Compile(cngFillType, nameof(cngFillType), required: false);
            var __workflow_cngPsa = WorkflowExpression.Compile(cngPsa, nameof(cngPsa), required: false);
            var __workflow_cngVehicleClass = WorkflowExpression.Compile(cngVehicleClass, nameof(cngVehicleClass), required: false);
            var __workflow_e85HasBlenderPump = WorkflowExpression.Compile(e85HasBlenderPump, nameof(e85HasBlenderPump), required: false);
            var __workflow_evNetwork = WorkflowExpression.Compile(evNetwork, nameof(evNetwork), required: false);
            var __workflow_evChargingLevel = WorkflowExpression.Compile(evChargingLevel, nameof(evChargingLevel), required: false);
            var __workflow_evConnectorType = WorkflowExpression.Compile(evConnectorType, nameof(evConnectorType), required: false);
            var __workflow_hyIsRetail = WorkflowExpression.Compile(hyIsRetail, nameof(hyIsRetail), required: false);
            var __workflow_lngVehicleClass = WorkflowExpression.Compile(lngVehicleClass, nameof(lngVehicleClass), required: false);
            var __workflow_lpgIncludeSecondary = WorkflowExpression.Compile(lpgIncludeSecondary, nameof(lpgIncludeSecondary), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_zip = WorkflowExpression.Compile(zip, nameof(zip), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            return new DeferredBodyAction<AlternativeFuelStationsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/alt-fuel-stations/v1.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_access != null)
                    callPayload.Queries["access"] = ExpressionConverter.Convert(__workflow_access);
                if (__workflow_fuelType != null)
                    callPayload.Queries["fuel_type"] = ExpressionConverter.Convert(__workflow_fuelType);
                if (__workflow_cardsAccepted != null)
                    callPayload.Queries["cards_accepted"] = ExpressionConverter.Convert(__workflow_cardsAccepted);
                if (__workflow_ownerType != null)
                    callPayload.Queries["owner_type"] = ExpressionConverter.Convert(__workflow_ownerType);
                if (__workflow_federalAgency != null)
                    callPayload.Queries["federal_agency"] = ExpressionConverter.Convert(__workflow_federalAgency);
                if (__workflow_cngFillType != null)
                    callPayload.Queries["cng_fill_type"] = ExpressionConverter.Convert(__workflow_cngFillType);
                if (__workflow_cngPsa != null)
                    callPayload.Queries["cng_psa"] = ExpressionConverter.Convert(__workflow_cngPsa);
                if (__workflow_cngVehicleClass != null)
                    callPayload.Queries["cng_vehicle_class"] = ExpressionConverter.Convert(__workflow_cngVehicleClass);
                if (__workflow_e85HasBlenderPump != null)
                    callPayload.Queries["e85_has_blender_pump"] = ExpressionConverter.Convert(__workflow_e85HasBlenderPump);
                if (__workflow_evNetwork != null)
                    callPayload.Queries["ev_network"] = ExpressionConverter.Convert(__workflow_evNetwork);
                if (__workflow_evChargingLevel != null)
                    callPayload.Queries["ev_charging_level"] = ExpressionConverter.Convert(__workflow_evChargingLevel);
                if (__workflow_evConnectorType != null)
                    callPayload.Queries["ev_connector_type"] = ExpressionConverter.Convert(__workflow_evConnectorType);
                if (__workflow_hyIsRetail != null)
                    callPayload.Queries["hy_is_retail"] = ExpressionConverter.Convert(__workflow_hyIsRetail);
                if (__workflow_lngVehicleClass != null)
                    callPayload.Queries["lng_vehicle_class"] = ExpressionConverter.Convert(__workflow_lngVehicleClass);
                if (__workflow_lpgIncludeSecondary != null)
                    callPayload.Queries["lpg_include_secondary"] = ExpressionConverter.Convert(__workflow_lpgIncludeSecondary);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(__workflow_zip);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                return new ApiConnectionAction<AlternativeFuelStationsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nrelip")]
        public IBodyWorkflowAction<AlternativeFuelStationResponse, ApiConnectionActionConfiguration> AlternativeFuelStation(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AlternativeFuelStationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/alt-fuel-stations/v1/{0}.json", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AlternativeFuelStationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nrelip")]
        public IBodyWorkflowAction<AlternativeFuelNearestResponse, ApiConnectionActionConfiguration> AlternativeFuelNearest(Expression<Func<string>> location = null, Expression<Func<double>> latitude = null, Expression<Func<double>> longitude = null, Expression<Func<double>> radius = null, Expression<Func<StatusInput>> status = null, Expression<Func<AccessInput>> access = null, Expression<Func<string>> fuelType = null, Expression<Func<string>> cardsAccepted = null, Expression<Func<string>> ownerType = null, Expression<Func<string>> federalAgency = null, Expression<Func<string>> cngFillType = null, Expression<Func<string>> cngPsa = null, Expression<Func<CngVehicleClassInput>> cngVehicleClass = null, Expression<Func<E85HasBlenderPumpInput>> e85HasBlenderPump = null, Expression<Func<string>> evNetwork = null, Expression<Func<EvChargingLevelInput>> evChargingLevel = null, Expression<Func<EvConnectorTypeInput>> evConnectorType = null, Expression<Func<string>> hyIsRetail = null, Expression<Func<LngVehicleClassInput>> lngVehicleClass = null, Expression<Func<LpgIncludeSecondaryInput>> lpgIncludeSecondary = null, Expression<Func<string>> state = null, Expression<Func<string>> zip = null, Expression<Func<CountryInput>> country = null, Expression<Func<string>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: false);
            var __workflow_latitude = WorkflowExpression.Compile(latitude, nameof(latitude), required: false);
            var __workflow_longitude = WorkflowExpression.Compile(longitude, nameof(longitude), required: false);
            var __workflow_radius = WorkflowExpression.Compile(radius, nameof(radius), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_access = WorkflowExpression.Compile(access, nameof(access), required: false);
            var __workflow_fuelType = WorkflowExpression.Compile(fuelType, nameof(fuelType), required: false);
            var __workflow_cardsAccepted = WorkflowExpression.Compile(cardsAccepted, nameof(cardsAccepted), required: false);
            var __workflow_ownerType = WorkflowExpression.Compile(ownerType, nameof(ownerType), required: false);
            var __workflow_federalAgency = WorkflowExpression.Compile(federalAgency, nameof(federalAgency), required: false);
            var __workflow_cngFillType = WorkflowExpression.Compile(cngFillType, nameof(cngFillType), required: false);
            var __workflow_cngPsa = WorkflowExpression.Compile(cngPsa, nameof(cngPsa), required: false);
            var __workflow_cngVehicleClass = WorkflowExpression.Compile(cngVehicleClass, nameof(cngVehicleClass), required: false);
            var __workflow_e85HasBlenderPump = WorkflowExpression.Compile(e85HasBlenderPump, nameof(e85HasBlenderPump), required: false);
            var __workflow_evNetwork = WorkflowExpression.Compile(evNetwork, nameof(evNetwork), required: false);
            var __workflow_evChargingLevel = WorkflowExpression.Compile(evChargingLevel, nameof(evChargingLevel), required: false);
            var __workflow_evConnectorType = WorkflowExpression.Compile(evConnectorType, nameof(evConnectorType), required: false);
            var __workflow_hyIsRetail = WorkflowExpression.Compile(hyIsRetail, nameof(hyIsRetail), required: false);
            var __workflow_lngVehicleClass = WorkflowExpression.Compile(lngVehicleClass, nameof(lngVehicleClass), required: false);
            var __workflow_lpgIncludeSecondary = WorkflowExpression.Compile(lpgIncludeSecondary, nameof(lpgIncludeSecondary), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            var __workflow_zip = WorkflowExpression.Compile(zip, nameof(zip), required: false);
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<AlternativeFuelNearestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/alt-fuel-stations/v1/nearest.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_location != null)
                    callPayload.Queries["location"] = ExpressionConverter.Convert(__workflow_location);
                if (__workflow_latitude != null)
                    callPayload.Queries["latitude"] = ExpressionConverter.Convert(__workflow_latitude);
                if (__workflow_longitude != null)
                    callPayload.Queries["longitude"] = ExpressionConverter.Convert(__workflow_longitude);
                callPayload.Queries["radius"] = Convert.ToString(0);
                if (__workflow_radius != null)
                    callPayload.Queries["radius"] = ExpressionConverter.Convert(__workflow_radius);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_access != null)
                    callPayload.Queries["access"] = ExpressionConverter.Convert(__workflow_access);
                if (__workflow_fuelType != null)
                    callPayload.Queries["fuel_type"] = ExpressionConverter.Convert(__workflow_fuelType);
                if (__workflow_cardsAccepted != null)
                    callPayload.Queries["cards_accepted"] = ExpressionConverter.Convert(__workflow_cardsAccepted);
                if (__workflow_ownerType != null)
                    callPayload.Queries["owner_type"] = ExpressionConverter.Convert(__workflow_ownerType);
                if (__workflow_federalAgency != null)
                    callPayload.Queries["federal_agency"] = ExpressionConverter.Convert(__workflow_federalAgency);
                if (__workflow_cngFillType != null)
                    callPayload.Queries["cng_fill_type"] = ExpressionConverter.Convert(__workflow_cngFillType);
                if (__workflow_cngPsa != null)
                    callPayload.Queries["cng_psa"] = ExpressionConverter.Convert(__workflow_cngPsa);
                if (__workflow_cngVehicleClass != null)
                    callPayload.Queries["cng_vehicle_class"] = ExpressionConverter.Convert(__workflow_cngVehicleClass);
                if (__workflow_e85HasBlenderPump != null)
                    callPayload.Queries["e85_has_blender_pump"] = ExpressionConverter.Convert(__workflow_e85HasBlenderPump);
                if (__workflow_evNetwork != null)
                    callPayload.Queries["ev_network"] = ExpressionConverter.Convert(__workflow_evNetwork);
                if (__workflow_evChargingLevel != null)
                    callPayload.Queries["ev_charging_level"] = ExpressionConverter.Convert(__workflow_evChargingLevel);
                if (__workflow_evConnectorType != null)
                    callPayload.Queries["ev_connector_type"] = ExpressionConverter.Convert(__workflow_evConnectorType);
                if (__workflow_hyIsRetail != null)
                    callPayload.Queries["hy_is_retail"] = ExpressionConverter.Convert(__workflow_hyIsRetail);
                if (__workflow_lngVehicleClass != null)
                    callPayload.Queries["lng_vehicle_class"] = ExpressionConverter.Convert(__workflow_lngVehicleClass);
                if (__workflow_lpgIncludeSecondary != null)
                    callPayload.Queries["lpg_include_secondary"] = ExpressionConverter.Convert(__workflow_lpgIncludeSecondary);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                if (__workflow_zip != null)
                    callPayload.Queries["zip"] = ExpressionConverter.Convert(__workflow_zip);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<AlternativeFuelNearestResponse>(callPayload);
            });
        }
    }

    public class NrelipTriggers([ConnectionName] string connectionId)
    {
    }

    public class StandardWorkSpecsResponseItem
    {
        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("subtopic")]
        public string Subtopic { get; set; }

        [JsonProperty("desired_outcome")]
        public string DesiredOutcome { get; set; }

        [JsonProperty("housing_types")]
        public string[] HousingTypes { get; set; }

        [JsonProperty("details")]
        public StandardWorkSpecsResponseItemDetailsTypeItem[] Details { get; set; }
    }

    public class StandardWorkSpecsResponseItemDetailsTypeItem
    {
        [JsonProperty("objective")]
        public string Objective { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("specification")]
        public string Specification { get; set; }

        [JsonProperty("housing_type")]
        public string[] HousingType { get; set; }
    }

    public enum HtInput
    {
        _1 = 1,
        _2 = 2,
        _3 = 3
    }

    public class UtilityRatesResponse
    {
        [JsonProperty("inputs")]
        public UtilityRatesResponseInputsType Inputs { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("metadata")]
        public UtilityRatesResponseMetadataType Metadata { get; set; }

        [JsonProperty("outputs")]
        public UtilityRatesResponseOutputsType Outputs { get; set; }
    }

    public class UtilityRatesResponseInputsType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }
    }

    public class UtilityRatesResponseMetadataType
    {
        [JsonProperty("sources")]
        public string[] Sources { get; set; }
    }

    public class UtilityRatesResponseOutputsType
    {
        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("utility_name")]
        public string UtilityName { get; set; }

        [JsonProperty("utility_info")]
        public UtilityRatesResponseOutputsTypeUtilityInfoTypeItem[] UtilityInfo { get; set; }

        [JsonProperty("commercial")]
        public double Commercial { get; set; }

        [JsonProperty("industrial")]
        public double Industrial { get; set; }

        [JsonProperty("residential")]
        public double Residential { get; set; }
    }

    public class UtilityRatesResponseOutputsTypeUtilityInfoTypeItem
    {
        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("utility_name")]
        public string UtilityName { get; set; }
    }

    public class UtilityRatesCensusResponse
    {
        [JsonProperty("inputs")]
        public UtilityRatesCensusResponseInputsType Inputs { get; set; }

        [JsonProperty("outputs")]
        public UtilityRatesCensusResponseOutputsType Outputs { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("metadata")]
        public UtilityRatesCensusResponseMetadataType Metadata { get; set; }
    }

    public class UtilityRatesCensusResponseInputsType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }
    }

    public class UtilityRatesCensusResponseOutputsType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("census_region")]
        public string CensusRegion { get; set; }

        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("utility_name")]
        public string UtilityName { get; set; }

        [JsonProperty("utility_info")]
        public UtilityRatesCensusResponseOutputsTypeUtilityInfoTypeItem[] UtilityInfo { get; set; }

        [JsonProperty("commercial")]
        public double Commercial { get; set; }

        [JsonProperty("industrial")]
        public double Industrial { get; set; }

        [JsonProperty("residential")]
        public double Residential { get; set; }
    }

    public class UtilityRatesCensusResponseOutputsTypeUtilityInfoTypeItem
    {
        [JsonProperty("company_id")]
        public string CompanyId { get; set; }

        [JsonProperty("utility_name")]
        public string UtilityName { get; set; }
    }

    public class UtilityRatesCensusResponseMetadataType
    {
        [JsonProperty("sources")]
        public string[] Sources { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RegionInput
    {
        [EnumMember(Value = "block")]
        Block,
        [EnumMember(Value = "blockgroup")]
        Blockgroup,
        [EnumMember(Value = "track")]
        Track
    }

    public class SolarResourceResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("metadata")]
        public SolarResourceResponseMetadataType Metadata { get; set; }

        [JsonProperty("inputs")]
        public SolarResourceResponseInputsType Inputs { get; set; }

        [JsonProperty("outputs")]
        public SolarResourceResponseOutputsType Outputs { get; set; }
    }

    public class SolarResourceResponseMetadataType
    {
        [JsonProperty("sources")]
        public string[] Sources { get; set; }
    }

    public class SolarResourceResponseInputsType
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lon")]
        public string Lon { get; set; }
    }

    public class SolarResourceResponseOutputsType
    {
        [JsonProperty("avg_dni")]
        public SolarResourceResponseOutputsTypeAvgDniType AvgDni { get; set; }

        [JsonProperty("avg_ghi")]
        public SolarResourceResponseOutputsTypeAvgGhiType AvgGhi { get; set; }

        [JsonProperty("avg_lat_tilt")]
        public SolarResourceResponseOutputsTypeAvgLatTiltType AvgLatTilt { get; set; }
    }

    public class SolarResourceResponseOutputsTypeAvgDniType
    {
        [JsonProperty("annual")]
        public double Annual { get; set; }

        [JsonProperty("monthly")]
        public SolarResourceResponseOutputsTypeAvgDniTypeMonthlyType Monthly { get; set; }
    }

    public class SolarResourceResponseOutputsTypeAvgDniTypeMonthlyType
    {
        [JsonProperty("jan")]
        public double Jan { get; set; }

        [JsonProperty("feb")]
        public double Feb { get; set; }

        [JsonProperty("mar")]
        public double Mar { get; set; }

        [JsonProperty("apr")]
        public double Apr { get; set; }

        [JsonProperty("may")]
        public double May { get; set; }

        [JsonProperty("jun")]
        public double Jun { get; set; }

        [JsonProperty("jul")]
        public double Jul { get; set; }

        [JsonProperty("aug")]
        public double Aug { get; set; }

        [JsonProperty("sep")]
        public double Sep { get; set; }

        [JsonProperty("oct")]
        public double Oct { get; set; }

        [JsonProperty("nov")]
        public double Nov { get; set; }

        [JsonProperty("dec")]
        public double Dec { get; set; }
    }

    public class SolarResourceResponseOutputsTypeAvgGhiType
    {
        [JsonProperty("annual")]
        public double Annual { get; set; }

        [JsonProperty("monthly")]
        public SolarResourceResponseOutputsTypeAvgGhiTypeMonthlyType Monthly { get; set; }
    }

    public class SolarResourceResponseOutputsTypeAvgGhiTypeMonthlyType
    {
        [JsonProperty("jan")]
        public double Jan { get; set; }

        [JsonProperty("feb")]
        public double Feb { get; set; }

        [JsonProperty("mar")]
        public double Mar { get; set; }

        [JsonProperty("apr")]
        public double Apr { get; set; }

        [JsonProperty("may")]
        public double May { get; set; }

        [JsonProperty("jun")]
        public double Jun { get; set; }

        [JsonProperty("jul")]
        public double Jul { get; set; }

        [JsonProperty("aug")]
        public double Aug { get; set; }

        [JsonProperty("sep")]
        public double Sep { get; set; }

        [JsonProperty("oct")]
        public double Oct { get; set; }

        [JsonProperty("nov")]
        public double Nov { get; set; }

        [JsonProperty("dec")]
        public double Dec { get; set; }
    }

    public class SolarResourceResponseOutputsTypeAvgLatTiltType
    {
        [JsonProperty("annual")]
        public double Annual { get; set; }

        [JsonProperty("monthly")]
        public SolarResourceResponseOutputsTypeAvgLatTiltTypeMonthlyType Monthly { get; set; }
    }

    public class SolarResourceResponseOutputsTypeAvgLatTiltTypeMonthlyType
    {
        [JsonProperty("jan")]
        public double Jan { get; set; }

        [JsonProperty("feb")]
        public double Feb { get; set; }

        [JsonProperty("mar")]
        public double Mar { get; set; }

        [JsonProperty("apr")]
        public double Apr { get; set; }

        [JsonProperty("may")]
        public double May { get; set; }

        [JsonProperty("jun")]
        public double Jun { get; set; }

        [JsonProperty("jul")]
        public double Jul { get; set; }

        [JsonProperty("aug")]
        public double Aug { get; set; }

        [JsonProperty("sep")]
        public double Sep { get; set; }

        [JsonProperty("oct")]
        public double Oct { get; set; }

        [JsonProperty("nov")]
        public double Nov { get; set; }

        [JsonProperty("dec")]
        public double Dec { get; set; }
    }

    public class AlternativeFuelStationsResponse
    {
        [JsonProperty("station_locator_url")]
        public string StationLocatorUrl { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("station_counts")]
        public AlternativeFuelStationsResponseStationCountsType StationCounts { get; set; }

        [JsonProperty("fuel_stations")]
        public AlternativeFuelStationsResponseFuelStationsTypeItem[] FuelStations { get; set; }
    }

    public class AlternativeFuelStationsResponseStationCountsType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("fuels")]
        public AlternativeFuelStationsResponseStationCountsTypeFuelsType Fuels { get; set; }
    }

    public class AlternativeFuelStationsResponseStationCountsTypeFuelsType
    {
        public AlternativeFuelStationsResponseStationCountsTypeFuelsTypeBDType BD { get; set; }
        public AlternativeFuelStationsResponseStationCountsTypeFuelsTypeE85Type E85 { get; set; }
        public AlternativeFuelStationsResponseStationCountsTypeFuelsTypeELECType ELEC { get; set; }
        public AlternativeFuelStationsResponseStationCountsTypeFuelsTypeHYType HY { get; set; }
        public AlternativeFuelStationsResponseStationCountsTypeFuelsTypeLNGType LNG { get; set; }
        public AlternativeFuelStationsResponseStationCountsTypeFuelsTypeCNGType CNG { get; set; }
        public AlternativeFuelStationsResponseStationCountsTypeFuelsTypeLPGType LPG { get; set; }
    }

    public class AlternativeFuelStationsResponseStationCountsTypeFuelsTypeBDType
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelStationsResponseStationCountsTypeFuelsTypeE85Type
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelStationsResponseStationCountsTypeFuelsTypeELECType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("stations")]
        public AlternativeFuelStationsResponseStationCountsTypeFuelsTypeELECTypeStationsType Stations { get; set; }
    }

    public class AlternativeFuelStationsResponseStationCountsTypeFuelsTypeELECTypeStationsType
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelStationsResponseStationCountsTypeFuelsTypeHYType
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelStationsResponseStationCountsTypeFuelsTypeLNGType
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelStationsResponseStationCountsTypeFuelsTypeCNGType
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelStationsResponseStationCountsTypeFuelsTypeLPGType
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelStationsResponseFuelStationsTypeItem
    {
        [JsonProperty("access_code")]
        public string AccessCode { get; set; }

        [JsonProperty("access_days_time")]
        public string AccessDaysTime { get; set; }

        [JsonProperty("access_detail_code")]
        public string AccessDetailCode { get; set; }

        [JsonProperty("cards_accepted")]
        public string CardsAccepted { get; set; }

        [JsonProperty("date_last_confirmed")]
        public string DateLastConfirmed { get; set; }

        [JsonProperty("expected_date")]
        public string ExpectedDate { get; set; }

        [JsonProperty("fuel_type_code")]
        public string FuelTypeCode { get; set; }

        [JsonProperty("groups_with_access_code")]
        public string GroupsWithAccessCode { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("open_date")]
        public string OpenDate { get; set; }

        [JsonProperty("owner_type_code")]
        public string OwnerTypeCode { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("restricted_access")]
        public bool RestrictedAccess { get; set; }

        [JsonProperty("station_name")]
        public string StationName { get; set; }

        [JsonProperty("station_phone")]
        public string StationPhone { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("facility_type")]
        public string FacilityType { get; set; }

        [JsonProperty("geocode_status")]
        public string GeocodeStatus { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("intersection_directions")]
        public string IntersectionDirections { get; set; }

        [JsonProperty("plus4")]
        public string Plus4 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("street_address")]
        public string StreetAddress { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("bd_blends")]
        public string BdBlends { get; set; }

        [JsonProperty("cng_dispenser_num")]
        public int CngDispenserNum { get; set; }

        [JsonProperty("cng_fill_type_code")]
        public string CngFillTypeCode { get; set; }

        [JsonProperty("cng_psi")]
        public string CngPsi { get; set; }

        [JsonProperty("cng_renewable_source")]
        public string CngRenewableSource { get; set; }

        [JsonProperty("cng_vehicle_class")]
        public string CngVehicleClass { get; set; }

        [JsonProperty("e85_blender_pump")]
        public string E85BlenderPump { get; set; }

        [JsonProperty("e85_other_ethanol_blends")]
        public string E85OtherEthanolBlends { get; set; }

        [JsonProperty("ev_connector_types")]
        public string EvConnectorTypes { get; set; }

        [JsonProperty("ev_dc_fast_num")]
        public string EvDcFastNum { get; set; }

        [JsonProperty("ev_level1_evse_num")]
        public string EvLevel1EvseNum { get; set; }

        [JsonProperty("ev_level2_evse_num")]
        public string EvLevel2EvseNum { get; set; }

        [JsonProperty("ev_network")]
        public string EvNetwork { get; set; }

        [JsonProperty("ev_network_web")]
        public string EvNetworkWeb { get; set; }

        [JsonProperty("ev_other_evse")]
        public string EvOtherEvse { get; set; }

        [JsonProperty("ev_pricing")]
        public string EvPricing { get; set; }

        [JsonProperty("ev_renewable_source")]
        public string EvRenewableSource { get; set; }

        [JsonProperty("hy_is_retail")]
        public string HyIsRetail { get; set; }

        [JsonProperty("hy_pressures")]
        public string HyPressures { get; set; }

        [JsonProperty("hy_standards")]
        public string HyStandards { get; set; }

        [JsonProperty("hy_status_link")]
        public string HyStatusLink { get; set; }

        [JsonProperty("lng_renewable_source")]
        public string LngRenewableSource { get; set; }

        [JsonProperty("lng_vehicle_class")]
        public string LngVehicleClass { get; set; }

        [JsonProperty("lpg_primary")]
        public string LpgPrimary { get; set; }

        [JsonProperty("lpg_nozzle_types")]
        public string LpgNozzleTypes { get; set; }

        [JsonProperty("ng_fill_type_code")]
        public string NgFillTypeCode { get; set; }

        [JsonProperty("ng_psi")]
        public string NgPsi { get; set; }

        [JsonProperty("ng_vehicle_class")]
        public string NgVehicleClass { get; set; }

        [JsonProperty("rd_blends")]
        public string RdBlends { get; set; }

        [JsonProperty("rd_blends_fr")]
        public string RdBlendsFr { get; set; }

        [JsonProperty("rd_blended_with_biodiesel")]
        public string RdBlendedWithBiodiesel { get; set; }

        [JsonProperty("rd_max_biodiesel_level")]
        public string RdMaxBiodieselLevel { get; set; }

        [JsonProperty("access_days_time_fr")]
        public string AccessDaysTimeFr { get; set; }

        [JsonProperty("intersection_directions_fr")]
        public string IntersectionDirectionsFr { get; set; }

        [JsonProperty("bd_blends_fr")]
        public string BdBlendsFr { get; set; }

        [JsonProperty("groups_with_access_code_fr")]
        public string GroupsWithAccessCodeFr { get; set; }

        [JsonProperty("ev_pricing_fr")]
        public string EvPricingFr { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StatusInput
    {
        [EnumMember(Value = "all")]
        All,
        E,
        P,
        T
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AccessInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "private")]
        Private
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CngVehicleClassInput
    {
        [EnumMember(Value = "all")]
        All,
        LD,
        MD,
        HD
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum E85HasBlenderPumpInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "true")]
        True
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EvChargingLevelInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "dc_fast")]
        DcFast,
        [EnumMember(Value = "legacy")]
        Legacy
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EvConnectorTypeInput
    {
        [EnumMember(Value = "all")]
        All,
        NEMA1450,
        NEMA515,
        NEMA520,
        J1772,
        J1772COMBO,
        CHADEMO,
        TESLA
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LngVehicleClassInput
    {
        [EnumMember(Value = "all")]
        All,
        LD,
        MD,
        HD
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LpgIncludeSecondaryInput
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "false")]
        False
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CountryInput
    {
        [EnumMember(Value = "all")]
        All,
        US,
        CA
    }

    public class AlternativeFuelStationResponse
    {
        [JsonProperty("alt_fuel_station")]
        public AlternativeFuelStationResponseAltFuelStationType AltFuelStation { get; set; }
    }

    public class AlternativeFuelStationResponseAltFuelStationType
    {
        [JsonProperty("access_code")]
        public string AccessCode { get; set; }

        [JsonProperty("access_days_time")]
        public string AccessDaysTime { get; set; }

        [JsonProperty("access_detail_code")]
        public string AccessDetailCode { get; set; }

        [JsonProperty("cards_accepted")]
        public string CardsAccepted { get; set; }

        [JsonProperty("date_last_confirmed")]
        public string DateLastConfirmed { get; set; }

        [JsonProperty("expected_date")]
        public string ExpectedDate { get; set; }

        [JsonProperty("fuel_type_code")]
        public string FuelTypeCode { get; set; }

        [JsonProperty("groups_with_access_code")]
        public string GroupsWithAccessCode { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("open_date")]
        public string OpenDate { get; set; }

        [JsonProperty("owner_type_code")]
        public string OwnerTypeCode { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("restricted_access")]
        public bool RestrictedAccess { get; set; }

        [JsonProperty("station_name")]
        public string StationName { get; set; }

        [JsonProperty("station_phone")]
        public string StationPhone { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("facility_type")]
        public string FacilityType { get; set; }

        [JsonProperty("geocode_status")]
        public string GeocodeStatus { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("intersection_directions")]
        public string IntersectionDirections { get; set; }

        [JsonProperty("plus4")]
        public string Plus4 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("street_address")]
        public string StreetAddress { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("bd_blends")]
        public string BdBlends { get; set; }

        [JsonProperty("cng_dispenser_num")]
        public int CngDispenserNum { get; set; }

        [JsonProperty("cng_fill_type_code")]
        public string CngFillTypeCode { get; set; }

        [JsonProperty("cng_psi")]
        public string CngPsi { get; set; }

        [JsonProperty("cng_renewable_source")]
        public string CngRenewableSource { get; set; }

        [JsonProperty("cng_vehicle_class")]
        public string CngVehicleClass { get; set; }

        [JsonProperty("e85_blender_pump")]
        public string E85BlenderPump { get; set; }

        [JsonProperty("e85_other_ethanol_blends")]
        public string E85OtherEthanolBlends { get; set; }

        [JsonProperty("ev_connector_types")]
        public string EvConnectorTypes { get; set; }

        [JsonProperty("ev_dc_fast_num")]
        public int EvDcFastNum { get; set; }

        [JsonProperty("ev_level1_evse_num")]
        public string EvLevel1EvseNum { get; set; }

        [JsonProperty("ev_level2_evse_num")]
        public string EvLevel2EvseNum { get; set; }

        [JsonProperty("ev_network")]
        public string EvNetwork { get; set; }

        [JsonProperty("ev_network_web")]
        public string EvNetworkWeb { get; set; }

        [JsonProperty("ev_other_evse")]
        public string EvOtherEvse { get; set; }

        [JsonProperty("ev_pricing")]
        public string EvPricing { get; set; }

        [JsonProperty("ev_renewable_source")]
        public string EvRenewableSource { get; set; }

        [JsonProperty("hy_is_retail")]
        public string HyIsRetail { get; set; }

        [JsonProperty("hy_pressures")]
        public string HyPressures { get; set; }

        [JsonProperty("hy_standards")]
        public string HyStandards { get; set; }

        [JsonProperty("hy_status_link")]
        public string HyStatusLink { get; set; }

        [JsonProperty("lng_renewable_source")]
        public string LngRenewableSource { get; set; }

        [JsonProperty("lng_vehicle_class")]
        public string LngVehicleClass { get; set; }

        [JsonProperty("lpg_primary")]
        public string LpgPrimary { get; set; }

        [JsonProperty("lpg_nozzle_types")]
        public string LpgNozzleTypes { get; set; }

        [JsonProperty("ng_fill_type_code")]
        public string NgFillTypeCode { get; set; }

        [JsonProperty("ng_psi")]
        public string NgPsi { get; set; }

        [JsonProperty("ng_vehicle_class")]
        public string NgVehicleClass { get; set; }

        [JsonProperty("rd_blends")]
        public string RdBlends { get; set; }

        [JsonProperty("rd_blends_fr")]
        public string RdBlendsFr { get; set; }

        [JsonProperty("rd_blended_with_biodiesel")]
        public string RdBlendedWithBiodiesel { get; set; }

        [JsonProperty("rd_max_biodiesel_level")]
        public string RdMaxBiodieselLevel { get; set; }

        [JsonProperty("access_days_time_fr")]
        public string AccessDaysTimeFr { get; set; }

        [JsonProperty("intersection_directions_fr")]
        public string IntersectionDirectionsFr { get; set; }

        [JsonProperty("bd_blends_fr")]
        public string BdBlendsFr { get; set; }

        [JsonProperty("groups_with_access_code_fr")]
        public string GroupsWithAccessCodeFr { get; set; }

        [JsonProperty("ev_pricing_fr")]
        public string EvPricingFr { get; set; }
    }

    public class AlternativeFuelNearestResponse
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("location_country")]
        public string LocationCountry { get; set; }

        [JsonProperty("precision")]
        public AlternativeFuelNearestResponsePrecisionType Precision { get; set; }

        [JsonProperty("station_locator_url")]
        public string StationLocatorUrl { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("station_counts")]
        public AlternativeFuelNearestResponseStationCountsType StationCounts { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("fuel_stations")]
        public AlternativeFuelNearestResponseFuelStationsTypeItem[] FuelStations { get; set; }
    }

    public class AlternativeFuelNearestResponsePrecisionType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("types")]
        public string[] Types { get; set; }
    }

    public class AlternativeFuelNearestResponseStationCountsType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("fuels")]
        public AlternativeFuelNearestResponseStationCountsTypeFuelsType Fuels { get; set; }
    }

    public class AlternativeFuelNearestResponseStationCountsTypeFuelsType
    {
        public AlternativeFuelNearestResponseStationCountsTypeFuelsTypeBDType BD { get; set; }
        public AlternativeFuelNearestResponseStationCountsTypeFuelsTypeE85Type E85 { get; set; }
        public AlternativeFuelNearestResponseStationCountsTypeFuelsTypeELECType ELEC { get; set; }
        public AlternativeFuelNearestResponseStationCountsTypeFuelsTypeHYType HY { get; set; }
        public AlternativeFuelNearestResponseStationCountsTypeFuelsTypeLNGType LNG { get; set; }
        public AlternativeFuelNearestResponseStationCountsTypeFuelsTypeCNGType CNG { get; set; }
        public AlternativeFuelNearestResponseStationCountsTypeFuelsTypeLPGType LPG { get; set; }
    }

    public class AlternativeFuelNearestResponseStationCountsTypeFuelsTypeBDType
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelNearestResponseStationCountsTypeFuelsTypeE85Type
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelNearestResponseStationCountsTypeFuelsTypeELECType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("stations")]
        public AlternativeFuelNearestResponseStationCountsTypeFuelsTypeELECTypeStationsType Stations { get; set; }
    }

    public class AlternativeFuelNearestResponseStationCountsTypeFuelsTypeELECTypeStationsType
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelNearestResponseStationCountsTypeFuelsTypeHYType
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelNearestResponseStationCountsTypeFuelsTypeLNGType
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelNearestResponseStationCountsTypeFuelsTypeCNGType
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelNearestResponseStationCountsTypeFuelsTypeLPGType
    {
        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AlternativeFuelNearestResponseFuelStationsTypeItem
    {
        [JsonProperty("access_code")]
        public string AccessCode { get; set; }

        [JsonProperty("access_days_time")]
        public string AccessDaysTime { get; set; }

        [JsonProperty("access_detail_code")]
        public string AccessDetailCode { get; set; }

        [JsonProperty("cards_accepted")]
        public string CardsAccepted { get; set; }

        [JsonProperty("date_last_confirmed")]
        public string DateLastConfirmed { get; set; }

        [JsonProperty("expected_date")]
        public string ExpectedDate { get; set; }

        [JsonProperty("fuel_type_code")]
        public string FuelTypeCode { get; set; }

        [JsonProperty("groups_with_access_code")]
        public string GroupsWithAccessCode { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("open_date")]
        public string OpenDate { get; set; }

        [JsonProperty("owner_type_code")]
        public string OwnerTypeCode { get; set; }

        [JsonProperty("status_code")]
        public string StatusCode { get; set; }

        [JsonProperty("restricted_access")]
        public string RestrictedAccess { get; set; }

        [JsonProperty("station_name")]
        public string StationName { get; set; }

        [JsonProperty("station_phone")]
        public string StationPhone { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("facility_type")]
        public string FacilityType { get; set; }

        [JsonProperty("geocode_status")]
        public string GeocodeStatus { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("intersection_directions")]
        public string IntersectionDirections { get; set; }

        [JsonProperty("plus4")]
        public string Plus4 { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("street_address")]
        public string StreetAddress { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("bd_blends")]
        public string BdBlends { get; set; }

        [JsonProperty("cng_dispenser_num")]
        public int CngDispenserNum { get; set; }

        [JsonProperty("cng_fill_type_code")]
        public string CngFillTypeCode { get; set; }

        [JsonProperty("cng_psi")]
        public string CngPsi { get; set; }

        [JsonProperty("cng_renewable_source")]
        public string CngRenewableSource { get; set; }

        [JsonProperty("cng_vehicle_class")]
        public string CngVehicleClass { get; set; }

        [JsonProperty("e85_blender_pump")]
        public string E85BlenderPump { get; set; }

        [JsonProperty("e85_other_ethanol_blends")]
        public string E85OtherEthanolBlends { get; set; }

        [JsonProperty("ev_connector_types")]
        public string EvConnectorTypes { get; set; }

        [JsonProperty("ev_dc_fast_num")]
        public string EvDcFastNum { get; set; }

        [JsonProperty("ev_level1_evse_num")]
        public string EvLevel1EvseNum { get; set; }

        [JsonProperty("ev_level2_evse_num")]
        public string EvLevel2EvseNum { get; set; }

        [JsonProperty("ev_network")]
        public string EvNetwork { get; set; }

        [JsonProperty("ev_network_web")]
        public string EvNetworkWeb { get; set; }

        [JsonProperty("ev_other_evse")]
        public string EvOtherEvse { get; set; }

        [JsonProperty("ev_pricing")]
        public string EvPricing { get; set; }

        [JsonProperty("ev_renewable_source")]
        public string EvRenewableSource { get; set; }

        [JsonProperty("hy_is_retail")]
        public string HyIsRetail { get; set; }

        [JsonProperty("hy_pressures")]
        public string HyPressures { get; set; }

        [JsonProperty("hy_standards")]
        public string HyStandards { get; set; }

        [JsonProperty("hy_status_link")]
        public string HyStatusLink { get; set; }

        [JsonProperty("lng_renewable_source")]
        public string LngRenewableSource { get; set; }

        [JsonProperty("lng_vehicle_class")]
        public string LngVehicleClass { get; set; }

        [JsonProperty("lpg_primary")]
        public string LpgPrimary { get; set; }

        [JsonProperty("lpg_nozzle_types")]
        public string LpgNozzleTypes { get; set; }

        [JsonProperty("ng_fill_type_code")]
        public string NgFillTypeCode { get; set; }

        [JsonProperty("ng_psi")]
        public string NgPsi { get; set; }

        [JsonProperty("ng_vehicle_class")]
        public string NgVehicleClass { get; set; }

        [JsonProperty("rd_blends")]
        public string RdBlends { get; set; }

        [JsonProperty("rd_blends_fr")]
        public string RdBlendsFr { get; set; }

        [JsonProperty("rd_blended_with_biodiesel")]
        public string RdBlendedWithBiodiesel { get; set; }

        [JsonProperty("rd_max_biodiesel_level")]
        public string RdMaxBiodieselLevel { get; set; }

        [JsonProperty("access_days_time_fr")]
        public string AccessDaysTimeFr { get; set; }

        [JsonProperty("intersection_directions_fr")]
        public string IntersectionDirectionsFr { get; set; }

        [JsonProperty("bd_blends_fr")]
        public string BdBlendsFr { get; set; }

        [JsonProperty("groups_with_access_code_fr")]
        public string GroupsWithAccessCodeFr { get; set; }

        [JsonProperty("ev_pricing_fr")]
        public string EvPricingFr { get; set; }

        [JsonProperty("ev_network_ids")]
        public AlternativeFuelNearestResponseFuelStationsTypeItemEvNetworkIdsType EvNetworkIds { get; set; }

        [JsonProperty("distance")]
        public double Distance { get; set; }

        [JsonProperty("distance_km")]
        public double DistanceKm { get; set; }
    }

    public class AlternativeFuelNearestResponseFuelStationsTypeItemEvNetworkIdsType
    {
        [JsonProperty("station")]
        public string[] Station { get; set; }

        [JsonProperty("posts")]
        public string[] Posts { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nrelip;

    public partial class WorkflowManagedActions
    {
        public NrelipActions Nrelip(string connectionId) => new NrelipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NrelipTriggers Nrelip(string connectionId) => new NrelipTriggers(connectionId);
    }
}