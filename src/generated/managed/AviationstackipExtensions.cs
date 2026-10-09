//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Aviationstackip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AviationstackipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aviationstackip")]
        [WorkflowExpressionFactory(nameof(__BuildFlightGet))]
        public IBodyWorkflowAction<FlightGetResponse> FlightGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<flightStatusInput> flightStatus = null, [WorkflowExpression] Func<string> flightDate = null, [WorkflowExpression] Func<string> depIata = null, [WorkflowExpression] Func<string> arrIata = null, [WorkflowExpression] Func<string> depIcao = null, [WorkflowExpression] Func<string> arrIcao = null, [WorkflowExpression] Func<string> airlineName = null, [WorkflowExpression] Func<string> airlineIata = null, [WorkflowExpression] Func<string> airlineIcao = null, [WorkflowExpression] Func<int> flightNumber = null, [WorkflowExpression] Func<string> flightIata = null, [WorkflowExpression] Func<string> flightIcao = null, [WorkflowExpression] Func<int> minDelayDep = null, [WorkflowExpression] Func<int> minDelayArr = null, [WorkflowExpression] Func<int> maxDelayDep = null, [WorkflowExpression] Func<int> maxDelayArr = null, [WorkflowExpression] Func<string> arrScheduledTimeArr = null, [WorkflowExpression] Func<string> arrScheduledTimeDep = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FlightGetResponse> __BuildFlightGet(WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null, WorkflowExpression<flightStatusInput> flightStatus = null, WorkflowExpression<string> flightDate = null, WorkflowExpression<string> depIata = null, WorkflowExpression<string> arrIata = null, WorkflowExpression<string> depIcao = null, WorkflowExpression<string> arrIcao = null, WorkflowExpression<string> airlineName = null, WorkflowExpression<string> airlineIata = null, WorkflowExpression<string> airlineIcao = null, WorkflowExpression<int> flightNumber = null, WorkflowExpression<string> flightIata = null, WorkflowExpression<string> flightIcao = null, WorkflowExpression<int> minDelayDep = null, WorkflowExpression<int> minDelayArr = null, WorkflowExpression<int> maxDelayDep = null, WorkflowExpression<int> maxDelayArr = null, WorkflowExpression<string> arrScheduledTimeArr = null, WorkflowExpression<string> arrScheduledTimeDep = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            WorkflowExpression.Validate(flightStatus, nameof(flightStatus), required: false);
            WorkflowExpression.Validate(flightDate, nameof(flightDate), required: false);
            WorkflowExpression.Validate(depIata, nameof(depIata), required: false);
            WorkflowExpression.Validate(arrIata, nameof(arrIata), required: false);
            WorkflowExpression.Validate(depIcao, nameof(depIcao), required: false);
            WorkflowExpression.Validate(arrIcao, nameof(arrIcao), required: false);
            WorkflowExpression.Validate(airlineName, nameof(airlineName), required: false);
            WorkflowExpression.Validate(airlineIata, nameof(airlineIata), required: false);
            WorkflowExpression.Validate(airlineIcao, nameof(airlineIcao), required: false);
            WorkflowExpression.Validate(flightNumber, nameof(flightNumber), required: false);
            WorkflowExpression.Validate(flightIata, nameof(flightIata), required: false);
            WorkflowExpression.Validate(flightIcao, nameof(flightIcao), required: false);
            WorkflowExpression.Validate(minDelayDep, nameof(minDelayDep), required: false);
            WorkflowExpression.Validate(minDelayArr, nameof(minDelayArr), required: false);
            WorkflowExpression.Validate(maxDelayDep, nameof(maxDelayDep), required: false);
            WorkflowExpression.Validate(maxDelayArr, nameof(maxDelayArr), required: false);
            WorkflowExpression.Validate(arrScheduledTimeArr, nameof(arrScheduledTimeArr), required: false);
            WorkflowExpression.Validate(arrScheduledTimeDep, nameof(arrScheduledTimeDep), required: false);
            return new DeferredBodyAction<FlightGetResponse>(() =>
            {
                var apiCallPath = "/flights";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                if (flightStatus != null)
                    callPayload.Queries["flight_status"] = ExpressionConverter.Convert(flightStatus);
                if (flightDate != null)
                    callPayload.Queries["flight_date"] = ExpressionConverter.Convert(flightDate);
                if (depIata != null)
                    callPayload.Queries["dep_iata"] = ExpressionConverter.Convert(depIata);
                if (arrIata != null)
                    callPayload.Queries["arr_iata"] = ExpressionConverter.Convert(arrIata);
                if (depIcao != null)
                    callPayload.Queries["dep_icao"] = ExpressionConverter.Convert(depIcao);
                if (arrIcao != null)
                    callPayload.Queries["arr_icao"] = ExpressionConverter.Convert(arrIcao);
                if (airlineName != null)
                    callPayload.Queries["airline_name"] = ExpressionConverter.Convert(airlineName);
                if (airlineIata != null)
                    callPayload.Queries["airline_iata"] = ExpressionConverter.Convert(airlineIata);
                if (airlineIcao != null)
                    callPayload.Queries["airline_icao"] = ExpressionConverter.Convert(airlineIcao);
                if (flightNumber != null)
                    callPayload.Queries["flight_number"] = ExpressionConverter.Convert(flightNumber);
                if (flightIata != null)
                    callPayload.Queries["flight_iata"] = ExpressionConverter.Convert(flightIata);
                if (flightIcao != null)
                    callPayload.Queries["flight_icao"] = ExpressionConverter.Convert(flightIcao);
                if (minDelayDep != null)
                    callPayload.Queries["min_delay_dep"] = ExpressionConverter.Convert(minDelayDep);
                if (minDelayArr != null)
                    callPayload.Queries["min_delay_arr"] = ExpressionConverter.Convert(minDelayArr);
                if (maxDelayDep != null)
                    callPayload.Queries["max_delay_dep"] = ExpressionConverter.Convert(maxDelayDep);
                if (maxDelayArr != null)
                    callPayload.Queries["max_delay_arr"] = ExpressionConverter.Convert(maxDelayArr);
                if (arrScheduledTimeArr != null)
                    callPayload.Queries["arr_scheduled_time_arr"] = ExpressionConverter.Convert(arrScheduledTimeArr);
                if (arrScheduledTimeDep != null)
                    callPayload.Queries["arr_scheduled_time_dep"] = ExpressionConverter.Convert(arrScheduledTimeDep);
                return new ApiConnectionAction<FlightGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aviationstackip")]
        [WorkflowExpressionFactory(nameof(__BuildAirportGet))]
        public IBodyWorkflowAction<AirportGetResponse> AirportGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AirportGetResponse> __BuildAirportGet(WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<AirportGetResponse>(() =>
            {
                var apiCallPath = "/airports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<AirportGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aviationstackip")]
        [WorkflowExpressionFactory(nameof(__BuildAirlineGet))]
        public IBodyWorkflowAction<AirlineGetResponse> AirlineGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AirlineGetResponse> __BuildAirlineGet(WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<AirlineGetResponse>(() =>
            {
                var apiCallPath = "/airlines";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<AirlineGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aviationstackip")]
        [WorkflowExpressionFactory(nameof(__BuildAirplaneGet))]
        public IBodyWorkflowAction<AirplaneGetResponse> AirplaneGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AirplaneGetResponse> __BuildAirplaneGet(WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<AirplaneGetResponse>(() =>
            {
                var apiCallPath = "/airplanes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<AirplaneGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aviationstackip")]
        [WorkflowExpressionFactory(nameof(__BuildAircraftGet))]
        public IBodyWorkflowAction<AircraftGetResponse> AircraftGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AircraftGetResponse> __BuildAircraftGet(WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<AircraftGetResponse>(() =>
            {
                var apiCallPath = "/aircraft_types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<AircraftGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aviationstackip")]
        [WorkflowExpressionFactory(nameof(__BuildTaxesGet))]
        public IBodyWorkflowAction<TaxesGetResponse> TaxesGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaxesGetResponse> __BuildTaxesGet(WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<TaxesGetResponse>(() =>
            {
                var apiCallPath = "/taxes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<TaxesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aviationstackip")]
        [WorkflowExpressionFactory(nameof(__BuildCityGet))]
        public IBodyWorkflowAction<CityGetResponse> CityGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CityGetResponse> __BuildCityGet(WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<CityGetResponse>(() =>
            {
                var apiCallPath = "/cities";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<CityGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "aviationstackip")]
        [WorkflowExpressionFactory(nameof(__BuildCountryGet))]
        public IBodyWorkflowAction<CountryGetResponse> CountryGet([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CountryGetResponse> __BuildCountryGet(WorkflowExpression<int> limit = null, WorkflowExpression<int> offset = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<CountryGetResponse>(() =>
            {
                var apiCallPath = "/countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
                return new ApiConnectionAction<CountryGetResponse>(callPayload);
            });
        }
    }

    public class AviationstackipTriggers([ConnectionName] string connectionId)
    {
    }

    public class FlightGetResponse
    {
        [JsonProperty("pagination")]
        public FlightGetResponsePaginationType Pagination { get; set; }

        [JsonProperty("data")]
        public FlightGetResponseDataTypeItem[] Data { get; set; }
    }

    public class FlightGetResponsePaginationType
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class FlightGetResponseDataTypeItem
    {
        [JsonProperty("flight_date")]
        public string FlightDate { get; set; }

        [JsonProperty("flight_status")]
        public string FlightStatus { get; set; }

        [JsonProperty("departure")]
        public FlightGetResponseDataTypeItemDepartureType Departure { get; set; }

        [JsonProperty("arrival")]
        public FlightGetResponseDataTypeItemArrivalType Arrival { get; set; }

        [JsonProperty("airline")]
        public FlightGetResponseDataTypeItemAirlineType Airline { get; set; }

        [JsonProperty("flight")]
        public FlightGetResponseDataTypeItemFlightType Flight { get; set; }
    }

    public class FlightGetResponseDataTypeItemDepartureType
    {
        [JsonProperty("airport")]
        public string Airport { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("iata")]
        public string Iata { get; set; }

        [JsonProperty("icao")]
        public string Icao { get; set; }

        [JsonProperty("terminal")]
        public string Terminal { get; set; }

        [JsonProperty("scheduled")]
        public string Scheduled { get; set; }

        [JsonProperty("estimated")]
        public string Estimated { get; set; }

        [JsonProperty("delay")]
        public int Delay { get; set; }

        [JsonProperty("gate")]
        public string Gate { get; set; }
    }

    public class FlightGetResponseDataTypeItemArrivalType
    {
        [JsonProperty("airport")]
        public string Airport { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("iata")]
        public string Iata { get; set; }

        [JsonProperty("icao")]
        public string Icao { get; set; }

        [JsonProperty("scheduled")]
        public string Scheduled { get; set; }

        [JsonProperty("estimated")]
        public string Estimated { get; set; }

        [JsonProperty("terminal")]
        public string Terminal { get; set; }

        [JsonProperty("gate")]
        public string Gate { get; set; }

        [JsonProperty("baggage")]
        public string Baggage { get; set; }
    }

    public class FlightGetResponseDataTypeItemAirlineType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("iata")]
        public string Iata { get; set; }

        [JsonProperty("icao")]
        public string Icao { get; set; }
    }

    public class FlightGetResponseDataTypeItemFlightType
    {
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("iata")]
        public string Iata { get; set; }

        [JsonProperty("icao")]
        public string Icao { get; set; }

        [JsonProperty("codeshared")]
        public FlightGetResponseDataTypeItemFlightTypeCodesharedType Codeshared { get; set; }
    }

    public class FlightGetResponseDataTypeItemFlightTypeCodesharedType
    {
        [JsonProperty("airline_name")]
        public string AirlineName { get; set; }

        [JsonProperty("airline_iata")]
        public string AirlineIata { get; set; }

        [JsonProperty("airline_icao")]
        public string AirlineIcao { get; set; }

        [JsonProperty("flight_number")]
        public string FlightNumber { get; set; }

        [JsonProperty("flight_iata")]
        public string FlightIata { get; set; }

        [JsonProperty("flight_icao")]
        public string FlightIcao { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum flightStatusInput
    {
        [EnumMember(Value = "scheduled")]
        Scheduled,
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "landed")]
        Landed,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "incident")]
        Incident,
        [EnumMember(Value = "diverted")]
        Diverted
    }

    public class AirportGetResponse
    {
        [JsonProperty("pagination")]
        public AirportGetResponsePaginationType Pagination { get; set; }

        [JsonProperty("data")]
        public AirportGetResponseDataTypeItem[] Data { get; set; }
    }

    public class AirportGetResponsePaginationType
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AirportGetResponseDataTypeItem
    {
        [JsonProperty("airport_name")]
        public string AirportName { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }

        [JsonProperty("icao_code")]
        public string IcaoCode { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("geoname_id")]
        public string GeonameId { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("gmt")]
        public string Gmt { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_iso2")]
        public string CountryIso2 { get; set; }

        [JsonProperty("city_iata_code")]
        public string CityIataCode { get; set; }
    }

    public class AirlineGetResponse
    {
        [JsonProperty("pagination")]
        public AirlineGetResponsePaginationType Pagination { get; set; }

        [JsonProperty("data")]
        public AirlineGetResponseDataTypeItem[] Data { get; set; }
    }

    public class AirlineGetResponsePaginationType
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AirlineGetResponseDataTypeItem
    {
        [JsonProperty("airline_name")]
        public string AirlineName { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }

        [JsonProperty("iata_prefix_accounting")]
        public string IataPrefixAccounting { get; set; }

        [JsonProperty("icao_code")]
        public string IcaoCode { get; set; }

        [JsonProperty("callsign")]
        public string Callsign { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("fleet_size")]
        public string FleetSize { get; set; }

        [JsonProperty("fleet_average_age")]
        public string FleetAverageAge { get; set; }

        [JsonProperty("date_founded")]
        public string DateFounded { get; set; }

        [JsonProperty("hub_code")]
        public string HubCode { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_iso2")]
        public string CountryIso2 { get; set; }
    }

    public class AirplaneGetResponse
    {
        [JsonProperty("pagination")]
        public AirplaneGetResponsePaginationType Pagination { get; set; }

        [JsonProperty("data")]
        public AirplaneGetResponseDataTypeItem[] Data { get; set; }
    }

    public class AirplaneGetResponsePaginationType
    {
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AirplaneGetResponseDataTypeItem
    {
        [JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }

        [JsonProperty("production_line")]
        public string ProductionLine { get; set; }

        [JsonProperty("iata_type")]
        public string IataType { get; set; }

        [JsonProperty("model_name")]
        public string ModelName { get; set; }

        [JsonProperty("model_code")]
        public string ModelCode { get; set; }

        [JsonProperty("icao_code_hex")]
        public string IcaoCodeHex { get; set; }

        [JsonProperty("iata_code_short")]
        public string IataCodeShort { get; set; }

        [JsonProperty("construction_number")]
        public string ConstructionNumber { get; set; }

        [JsonProperty("test_registration_number")]
        public string TestRegistrationNumber { get; set; }

        [JsonProperty("rollout_date")]
        public string RolloutDate { get; set; }

        [JsonProperty("first_flight_date")]
        public string FirstFlightDate { get; set; }

        [JsonProperty("delivery_date")]
        public string DeliveryDate { get; set; }

        [JsonProperty("registration_date")]
        public string RegistrationDate { get; set; }

        [JsonProperty("line_number")]
        public string LineNumber { get; set; }

        [JsonProperty("plane_series")]
        public string PlaneSeries { get; set; }

        [JsonProperty("airline_iata_code")]
        public string AirlineIataCode { get; set; }

        [JsonProperty("airline_icao_code")]
        public string AirlineIcaoCode { get; set; }

        [JsonProperty("plane_owner")]
        public string PlaneOwner { get; set; }

        [JsonProperty("engines_count")]
        public string EnginesCount { get; set; }

        [JsonProperty("engines_type")]
        public string EnginesType { get; set; }

        [JsonProperty("plane_age")]
        public string PlaneAge { get; set; }

        [JsonProperty("plane_status")]
        public string PlaneStatus { get; set; }

        [JsonProperty("plane_class")]
        public string PlaneClass { get; set; }
    }

    public class AircraftGetResponse
    {
        [JsonProperty("pagination")]
        public AircraftGetResponsePaginationType Pagination { get; set; }

        [JsonProperty("data")]
        public AircraftGetResponseDataTypeItem[] Data { get; set; }
    }

    public class AircraftGetResponsePaginationType
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class AircraftGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }

        [JsonProperty("aircraft_name")]
        public string AircraftName { get; set; }

        [JsonProperty("plane_type_id")]
        public string PlaneTypeId { get; set; }
    }

    public class TaxesGetResponse
    {
        [JsonProperty("pagination")]
        public TaxesGetResponsePaginationType Pagination { get; set; }

        [JsonProperty("data")]
        public TaxesGetResponseDataTypeItem[] Data { get; set; }
    }

    public class TaxesGetResponsePaginationType
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class TaxesGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }

        [JsonProperty("tax_name")]
        public string TaxName { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }
    }

    public class CityGetResponse
    {
        [JsonProperty("pagination")]
        public CityGetResponsePaginationType Pagination { get; set; }

        [JsonProperty("data")]
        public CityGetResponseDataTypeItem[] Data { get; set; }
    }

    public class CityGetResponsePaginationType
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class CityGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("gmt")]
        public string Gmt { get; set; }

        [JsonProperty("city_id")]
        public string CityId { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }

        [JsonProperty("country_iso2")]
        public string CountryIso2 { get; set; }

        [JsonProperty("geoname_id")]
        public string GeonameId { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("city_name")]
        public string CityName { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public class CountryGetResponse
    {
        [JsonProperty("pagination")]
        public CountryGetResponsePaginationType Pagination { get; set; }

        [JsonProperty("data")]
        public CountryGetResponseDataTypeItem[] Data { get; set; }
    }

    public class CountryGetResponsePaginationType
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class CountryGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("capital")]
        public string Capital { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("fips_code")]
        public string FipsCode { get; set; }

        [JsonProperty("country_iso2")]
        public string CountryIso2 { get; set; }

        [JsonProperty("country_iso3")]
        public string CountryIso3 { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("country_id")]
        public string CountryId { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("currency_name")]
        public string CurrencyName { get; set; }

        [JsonProperty("country_iso_numeric")]
        public string CountryIsoNumeric { get; set; }

        [JsonProperty("phone_prefix")]
        public string PhonePrefix { get; set; }

        [JsonProperty("population")]
        public string Population { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aviationstackip;

    public partial class WorkflowManagedActions
    {
        public AviationstackipActions Aviationstackip(string connectionId) => new AviationstackipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AviationstackipTriggers Aviationstackip(string connectionId) => new AviationstackipTriggers(connectionId);
    }
}