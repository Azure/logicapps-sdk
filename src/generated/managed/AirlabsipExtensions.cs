//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airlabsip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirlabsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<ListFlightsResponse, ApiConnectionActionConfiguration> ListFlights(Expression<Func<string>> flag = null, Expression<Func<string>> flightIcao = null, Expression<Func<string>> flightIata = null, Expression<Func<string>> depIcao = null, Expression<Func<string>> depIata = null, Expression<Func<string>> arrIcao = null, Expression<Func<string>> arrIata = null)
        {
            var __workflow_flag = WorkflowExpression.Compile(flag, nameof(flag), required: false);
            var __workflow_flightIcao = WorkflowExpression.Compile(flightIcao, nameof(flightIcao), required: false);
            var __workflow_flightIata = WorkflowExpression.Compile(flightIata, nameof(flightIata), required: false);
            var __workflow_depIcao = WorkflowExpression.Compile(depIcao, nameof(depIcao), required: false);
            var __workflow_depIata = WorkflowExpression.Compile(depIata, nameof(depIata), required: false);
            var __workflow_arrIcao = WorkflowExpression.Compile(arrIcao, nameof(arrIcao), required: false);
            var __workflow_arrIata = WorkflowExpression.Compile(arrIata, nameof(arrIata), required: false);
            return new DeferredBodyAction<ListFlightsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flights";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_flag != null)
                    callPayload.Queries["flag"] = ExpressionConverter.Convert(__workflow_flag);
                if (__workflow_flightIcao != null)
                    callPayload.Queries["flight_icao"] = ExpressionConverter.Convert(__workflow_flightIcao);
                if (__workflow_flightIata != null)
                    callPayload.Queries["flight_iata"] = ExpressionConverter.Convert(__workflow_flightIata);
                if (__workflow_depIcao != null)
                    callPayload.Queries["dep_icao"] = ExpressionConverter.Convert(__workflow_depIcao);
                if (__workflow_depIata != null)
                    callPayload.Queries["dep_iata"] = ExpressionConverter.Convert(__workflow_depIata);
                if (__workflow_arrIcao != null)
                    callPayload.Queries["arr_icao"] = ExpressionConverter.Convert(__workflow_arrIcao);
                if (__workflow_arrIata != null)
                    callPayload.Queries["arr_iata"] = ExpressionConverter.Convert(__workflow_arrIata);
                return new ApiConnectionAction<ListFlightsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<GetFlightResponse, ApiConnectionActionConfiguration> GetFlight(Expression<Func<string>> flightIata = null, Expression<Func<string>> flightIcao = null)
        {
            var __workflow_flightIata = WorkflowExpression.Compile(flightIata, nameof(flightIata), required: false);
            var __workflow_flightIcao = WorkflowExpression.Compile(flightIcao, nameof(flightIcao), required: false);
            return new DeferredBodyAction<GetFlightResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flight";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_flightIata != null)
                    callPayload.Queries["flight_iata"] = ExpressionConverter.Convert(__workflow_flightIata);
                if (__workflow_flightIcao != null)
                    callPayload.Queries["flight_icao"] = ExpressionConverter.Convert(__workflow_flightIcao);
                return new ApiConnectionAction<GetFlightResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<ListAirlinesResponse, ApiConnectionActionConfiguration> ListAirlines(Expression<Func<string>> iataCode = null, Expression<Func<string>> iataPrefix = null, Expression<Func<string>> iataAccounting = null, Expression<Func<string>> icaoCode = null, Expression<Func<string>> callsign = null, Expression<Func<string>> countryCode = null, Expression<Func<string>> Fields = null)
        {
            var __workflow_iataCode = WorkflowExpression.Compile(iataCode, nameof(iataCode), required: false);
            var __workflow_iataPrefix = WorkflowExpression.Compile(iataPrefix, nameof(iataPrefix), required: false);
            var __workflow_iataAccounting = WorkflowExpression.Compile(iataAccounting, nameof(iataAccounting), required: false);
            var __workflow_icaoCode = WorkflowExpression.Compile(icaoCode, nameof(icaoCode), required: false);
            var __workflow_callsign = WorkflowExpression.Compile(callsign, nameof(callsign), required: false);
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: false);
            var __workflow_Fields = WorkflowExpression.Compile(Fields, nameof(Fields), required: false);
            return new DeferredBodyAction<ListAirlinesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/airlines";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_iataCode != null)
                    callPayload.Queries["iata_code"] = ExpressionConverter.Convert(__workflow_iataCode);
                if (__workflow_iataPrefix != null)
                    callPayload.Queries["iata_prefix"] = ExpressionConverter.Convert(__workflow_iataPrefix);
                if (__workflow_iataAccounting != null)
                    callPayload.Queries["iata_accounting"] = ExpressionConverter.Convert(__workflow_iataAccounting);
                if (__workflow_icaoCode != null)
                    callPayload.Queries["icao_code"] = ExpressionConverter.Convert(__workflow_icaoCode);
                if (__workflow_callsign != null)
                    callPayload.Queries["callsign"] = ExpressionConverter.Convert(__workflow_callsign);
                if (__workflow_countryCode != null)
                    callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                if (__workflow_Fields != null)
                    callPayload.Queries["_fields"] = ExpressionConverter.Convert(__workflow_Fields);
                return new ApiConnectionAction<ListAirlinesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<ListRoutesResponse, ApiConnectionActionConfiguration> ListRoutes(Expression<Func<string>> depIata = null, Expression<Func<string>> depIcao = null, Expression<Func<string>> arrIata = null, Expression<Func<string>> arrIcao = null, Expression<Func<string>> airlineIcao = null, Expression<Func<string>> airlineIata = null, Expression<Func<string>> flightIcao = null, Expression<Func<string>> flightIata = null, Expression<Func<string>> Fields = null)
        {
            var __workflow_depIata = WorkflowExpression.Compile(depIata, nameof(depIata), required: false);
            var __workflow_depIcao = WorkflowExpression.Compile(depIcao, nameof(depIcao), required: false);
            var __workflow_arrIata = WorkflowExpression.Compile(arrIata, nameof(arrIata), required: false);
            var __workflow_arrIcao = WorkflowExpression.Compile(arrIcao, nameof(arrIcao), required: false);
            var __workflow_airlineIcao = WorkflowExpression.Compile(airlineIcao, nameof(airlineIcao), required: false);
            var __workflow_airlineIata = WorkflowExpression.Compile(airlineIata, nameof(airlineIata), required: false);
            var __workflow_flightIcao = WorkflowExpression.Compile(flightIcao, nameof(flightIcao), required: false);
            var __workflow_flightIata = WorkflowExpression.Compile(flightIata, nameof(flightIata), required: false);
            var __workflow_Fields = WorkflowExpression.Compile(Fields, nameof(Fields), required: false);
            return new DeferredBodyAction<ListRoutesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/routes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_depIata != null)
                    callPayload.Queries["dep_iata"] = ExpressionConverter.Convert(__workflow_depIata);
                if (__workflow_depIcao != null)
                    callPayload.Queries["dep_icao"] = ExpressionConverter.Convert(__workflow_depIcao);
                if (__workflow_arrIata != null)
                    callPayload.Queries["arr_iata"] = ExpressionConverter.Convert(__workflow_arrIata);
                if (__workflow_arrIcao != null)
                    callPayload.Queries["arr_icao"] = ExpressionConverter.Convert(__workflow_arrIcao);
                if (__workflow_airlineIcao != null)
                    callPayload.Queries["airline_icao"] = ExpressionConverter.Convert(__workflow_airlineIcao);
                if (__workflow_airlineIata != null)
                    callPayload.Queries["airline_iata"] = ExpressionConverter.Convert(__workflow_airlineIata);
                if (__workflow_flightIcao != null)
                    callPayload.Queries["flight_icao"] = ExpressionConverter.Convert(__workflow_flightIcao);
                if (__workflow_flightIata != null)
                    callPayload.Queries["flight_iata"] = ExpressionConverter.Convert(__workflow_flightIata);
                if (__workflow_Fields != null)
                    callPayload.Queries["_fields"] = ExpressionConverter.Convert(__workflow_Fields);
                return new ApiConnectionAction<ListRoutesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<ListSchedulesResponse, ApiConnectionActionConfiguration> ListSchedules(Expression<Func<string>> depIata = null, Expression<Func<string>> depIcao = null, Expression<Func<string>> arrIata = null, Expression<Func<string>> arrIcao = null, Expression<Func<string>> airlineIcao = null, Expression<Func<string>> airlineIata = null, Expression<Func<string>> flightIcao = null, Expression<Func<string>> flightIata = null, Expression<Func<string>> Fields = null)
        {
            var __workflow_depIata = WorkflowExpression.Compile(depIata, nameof(depIata), required: false);
            var __workflow_depIcao = WorkflowExpression.Compile(depIcao, nameof(depIcao), required: false);
            var __workflow_arrIata = WorkflowExpression.Compile(arrIata, nameof(arrIata), required: false);
            var __workflow_arrIcao = WorkflowExpression.Compile(arrIcao, nameof(arrIcao), required: false);
            var __workflow_airlineIcao = WorkflowExpression.Compile(airlineIcao, nameof(airlineIcao), required: false);
            var __workflow_airlineIata = WorkflowExpression.Compile(airlineIata, nameof(airlineIata), required: false);
            var __workflow_flightIcao = WorkflowExpression.Compile(flightIcao, nameof(flightIcao), required: false);
            var __workflow_flightIata = WorkflowExpression.Compile(flightIata, nameof(flightIata), required: false);
            var __workflow_Fields = WorkflowExpression.Compile(Fields, nameof(Fields), required: false);
            return new DeferredBodyAction<ListSchedulesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/schedules";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_depIata != null)
                    callPayload.Queries["dep_iata"] = ExpressionConverter.Convert(__workflow_depIata);
                if (__workflow_depIcao != null)
                    callPayload.Queries["dep_icao"] = ExpressionConverter.Convert(__workflow_depIcao);
                if (__workflow_arrIata != null)
                    callPayload.Queries["arr_iata"] = ExpressionConverter.Convert(__workflow_arrIata);
                if (__workflow_arrIcao != null)
                    callPayload.Queries["arr_icao"] = ExpressionConverter.Convert(__workflow_arrIcao);
                if (__workflow_airlineIcao != null)
                    callPayload.Queries["airline_icao"] = ExpressionConverter.Convert(__workflow_airlineIcao);
                if (__workflow_airlineIata != null)
                    callPayload.Queries["airline_iata"] = ExpressionConverter.Convert(__workflow_airlineIata);
                if (__workflow_flightIcao != null)
                    callPayload.Queries["flight_icao"] = ExpressionConverter.Convert(__workflow_flightIcao);
                if (__workflow_flightIata != null)
                    callPayload.Queries["flight_iata"] = ExpressionConverter.Convert(__workflow_flightIata);
                if (__workflow_Fields != null)
                    callPayload.Queries["_fields"] = ExpressionConverter.Convert(__workflow_Fields);
                return new ApiConnectionAction<ListSchedulesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<ListAirportsResponse, ApiConnectionActionConfiguration> ListAirports(Expression<Func<string>> iataCode = null, Expression<Func<string>> icaoCode = null, Expression<Func<string>> cityCode = null, Expression<Func<string>> countryCode = null, Expression<Func<string>> Fields = null)
        {
            var __workflow_iataCode = WorkflowExpression.Compile(iataCode, nameof(iataCode), required: false);
            var __workflow_icaoCode = WorkflowExpression.Compile(icaoCode, nameof(icaoCode), required: false);
            var __workflow_cityCode = WorkflowExpression.Compile(cityCode, nameof(cityCode), required: false);
            var __workflow_countryCode = WorkflowExpression.Compile(countryCode, nameof(countryCode), required: false);
            var __workflow_Fields = WorkflowExpression.Compile(Fields, nameof(Fields), required: false);
            return new DeferredBodyAction<ListAirportsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/airports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_iataCode != null)
                    callPayload.Queries["iata_code"] = ExpressionConverter.Convert(__workflow_iataCode);
                if (__workflow_icaoCode != null)
                    callPayload.Queries["icao_code"] = ExpressionConverter.Convert(__workflow_icaoCode);
                if (__workflow_cityCode != null)
                    callPayload.Queries["city_code"] = ExpressionConverter.Convert(__workflow_cityCode);
                if (__workflow_countryCode != null)
                    callPayload.Queries["country_code"] = ExpressionConverter.Convert(__workflow_countryCode);
                if (__workflow_Fields != null)
                    callPayload.Queries["_fields"] = ExpressionConverter.Convert(__workflow_Fields);
                return new ApiConnectionAction<ListAirportsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<ListCountriesResponse, ApiConnectionActionConfiguration> ListCountries(Expression<Func<string>> code = null, Expression<Func<string>> code3 = null, Expression<Func<string>> continent = null, Expression<Func<string>> Fields = null)
        {
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: false);
            var __workflow_code3 = WorkflowExpression.Compile(code3, nameof(code3), required: false);
            var __workflow_continent = WorkflowExpression.Compile(continent, nameof(continent), required: false);
            var __workflow_Fields = WorkflowExpression.Compile(Fields, nameof(Fields), required: false);
            return new DeferredBodyAction<ListCountriesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/countries";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_code != null)
                    callPayload.Queries["code"] = ExpressionConverter.Convert(__workflow_code);
                if (__workflow_code3 != null)
                    callPayload.Queries["code3"] = ExpressionConverter.Convert(__workflow_code3);
                if (__workflow_continent != null)
                    callPayload.Queries["continent"] = ExpressionConverter.Convert(__workflow_continent);
                if (__workflow_Fields != null)
                    callPayload.Queries["_fields"] = ExpressionConverter.Convert(__workflow_Fields);
                return new ApiConnectionAction<ListCountriesResponse>(callPayload);
            });
        }
    }

    public class AirlabsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListFlightsResponse
    {
        [JsonProperty("request")]
        public JToken Request { get; set; }

        [JsonProperty("response")]
        public ListFlightsResponseResponseTypeItem[] Response { get; set; }
    }

    public class ListFlightsResponseResponseTypeItem
    {
        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("reg_number")]
        public string RegNumber { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("alt")]
        public int Alt { get; set; }

        [JsonProperty("dir")]
        public int Dir { get; set; }

        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("v_speed")]
        public double VSpeed { get; set; }

        [JsonProperty("squawk")]
        public string Squawk { get; set; }

        [JsonProperty("flight_number")]
        public string FlightNumber { get; set; }

        [JsonProperty("flight_icao")]
        public string FlightIcao { get; set; }

        [JsonProperty("flight_iata")]
        public string FlightIata { get; set; }

        [JsonProperty("dep_icao")]
        public string DepIcao { get; set; }

        [JsonProperty("dep_iata")]
        public string DepIata { get; set; }

        [JsonProperty("arr_icao")]
        public string ArrIcao { get; set; }

        [JsonProperty("arr_iata")]
        public string ArrIata { get; set; }

        [JsonProperty("airline_icao")]
        public string AirlineIcao { get; set; }

        [JsonProperty("airline_iata")]
        public string AirlineIata { get; set; }

        [JsonProperty("aircraft_icao")]
        public string AircraftIcao { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetFlightResponse
    {
        [JsonProperty("request")]
        public JToken Request { get; set; }

        [JsonProperty("response")]
        public GetFlightResponseResponseType Response { get; set; }
    }

    public class GetFlightResponseResponseType
    {
        [JsonProperty("aircraft_icao")]
        public string AircraftIcao { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("built")]
        public int Built { get; set; }

        [JsonProperty("engine")]
        public string Engine { get; set; }

        [JsonProperty("engine_count")]
        public string EngineCount { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("msn")]
        public string Msn { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reg_number")]
        public string RegNumber { get; set; }

        [JsonProperty("hex")]
        public string Hex { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("alt")]
        public int Alt { get; set; }

        [JsonProperty("dir")]
        public int Dir { get; set; }

        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("v_speed")]
        public double VSpeed { get; set; }

        [JsonProperty("squawk")]
        public string Squawk { get; set; }

        [JsonProperty("flight_number")]
        public string FlightNumber { get; set; }

        [JsonProperty("flight_icao")]
        public string FlightIcao { get; set; }

        [JsonProperty("flight_iata")]
        public string FlightIata { get; set; }

        [JsonProperty("dep_icao")]
        public string DepIcao { get; set; }

        [JsonProperty("dep_iata")]
        public string DepIata { get; set; }

        [JsonProperty("arr_icao")]
        public string ArrIcao { get; set; }

        [JsonProperty("arr_iata")]
        public string ArrIata { get; set; }

        [JsonProperty("airline_icao")]
        public string AirlineIcao { get; set; }

        [JsonProperty("airline_iata")]
        public string AirlineIata { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ListAirlinesResponse
    {
        [JsonProperty("request")]
        public JToken Request { get; set; }

        [JsonProperty("response")]
        public ListAirlinesResponseResponseTypeItem[] Response { get; set; }
    }

    public class ListAirlinesResponseResponseTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }

        [JsonProperty("icao_code")]
        public string IcaoCode { get; set; }

        [JsonProperty("iata_prefix")]
        public int IataPrefix { get; set; }

        [JsonProperty("iata_accounting")]
        public int IataAccounting { get; set; }

        [JsonProperty("callsign")]
        public string Callsign { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("iosa_registered")]
        public int IosaRegistered { get; set; }

        [JsonProperty("is_scheduled")]
        public string IsScheduled { get; set; }

        [JsonProperty("is_passenger")]
        public int IsPassenger { get; set; }

        [JsonProperty("is_cargo")]
        public int IsCargo { get; set; }

        [JsonProperty("is_international")]
        public int IsInternational { get; set; }

        [JsonProperty("total_aircrafts")]
        public int TotalAircrafts { get; set; }

        [JsonProperty("average_fleet_age")]
        public int AverageFleetAge { get; set; }

        [JsonProperty("accidents_last_5y")]
        public int AccidentsLast5y { get; set; }

        [JsonProperty("crashes_last_5y")]
        public int CrashesLast5y { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class ListRoutesResponse
    {
        [JsonProperty("request")]
        public JToken Request { get; set; }

        [JsonProperty("response")]
        public ListRoutesResponseResponseTypeItem[] Response { get; set; }
    }

    public class ListRoutesResponseResponseTypeItem
    {
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

        [JsonProperty("cs_airline_iata")]
        public string CsAirlineIata { get; set; }

        [JsonProperty("cs_flight_iata")]
        public string CsFlightIata { get; set; }

        [JsonProperty("cs_flight_number")]
        public string CsFlightNumber { get; set; }

        [JsonProperty("dep_iata")]
        public string DepIata { get; set; }

        [JsonProperty("dep_icao")]
        public string DepIcao { get; set; }

        [JsonProperty("dep_terminals")]
        public string[] DepTerminals { get; set; }

        [JsonProperty("dep_time")]
        public string DepTime { get; set; }

        [JsonProperty("dep_time_utc")]
        public string DepTimeUtc { get; set; }

        [JsonProperty("arr_iata")]
        public string ArrIata { get; set; }

        [JsonProperty("arr_icao")]
        public string ArrIcao { get; set; }

        [JsonProperty("arr_terminals")]
        public string[] ArrTerminals { get; set; }

        [JsonProperty("arr_time")]
        public string ArrTime { get; set; }

        [JsonProperty("arr_time_utc")]
        public string ArrTimeUtc { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("days")]
        public string[] Days { get; set; }
    }

    public class ListSchedulesResponse
    {
        [JsonProperty("request")]
        public JToken Request { get; set; }

        [JsonProperty("response")]
        public ListSchedulesResponseResponseTypeItem[] Response { get; set; }
    }

    public class ListSchedulesResponseResponseTypeItem
    {
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

        [JsonProperty("cs_airline_iata")]
        public string CsAirlineIata { get; set; }

        [JsonProperty("cs_flight_iata")]
        public string CsFlightIata { get; set; }

        [JsonProperty("cs_flight_number")]
        public string CsFlightNumber { get; set; }

        [JsonProperty("dep_iata")]
        public string DepIata { get; set; }

        [JsonProperty("dep_icao")]
        public string DepIcao { get; set; }

        [JsonProperty("dep_terminal")]
        public string DepTerminal { get; set; }

        [JsonProperty("dep_gate")]
        public string DepGate { get; set; }

        [JsonProperty("dep_time")]
        public string DepTime { get; set; }

        [JsonProperty("dep_time_ts")]
        public int DepTimeTs { get; set; }

        [JsonProperty("dep_time_utc")]
        public string DepTimeUtc { get; set; }

        [JsonProperty("dep_estimated")]
        public string DepEstimated { get; set; }

        [JsonProperty("dep_estimated_ts")]
        public int DepEstimatedTs { get; set; }

        [JsonProperty("dep_estimated_utc")]
        public string DepEstimatedUtc { get; set; }

        [JsonProperty("arr_iata")]
        public string ArrIata { get; set; }

        [JsonProperty("arr_icao")]
        public string ArrIcao { get; set; }

        [JsonProperty("arr_terminal")]
        public string ArrTerminal { get; set; }

        [JsonProperty("arr_gate")]
        public string ArrGate { get; set; }

        [JsonProperty("arr_baggage")]
        public string ArrBaggage { get; set; }

        [JsonProperty("arr_time")]
        public string ArrTime { get; set; }

        [JsonProperty("arr_time_ts")]
        public int ArrTimeTs { get; set; }

        [JsonProperty("arr_time_utc")]
        public string ArrTimeUtc { get; set; }

        [JsonProperty("arr_estimated")]
        public string ArrEstimated { get; set; }

        [JsonProperty("arr_estimated_ts")]
        public int ArrEstimatedTs { get; set; }

        [JsonProperty("arr_estimated_utc")]
        public string ArrEstimatedUtc { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("dep_delayed")]
        public int DepDelayed { get; set; }

        [JsonProperty("arr_delayed")]
        public int ArrDelayed { get; set; }
    }

    public class ListAirportsResponse
    {
        [JsonProperty("request")]
        public JToken Request { get; set; }

        [JsonProperty("response")]
        public ListAirportsResponseResponseTypeItem[] Response { get; set; }
    }

    public class ListAirportsResponseResponseTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("iata_code")]
        public string IataCode { get; set; }

        [JsonProperty("icao_code")]
        public string IcaoCode { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lng")]
        public double Lng { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        [JsonProperty("un_locode")]
        public string UnLocode { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("names")]
        public JToken Names { get; set; }

        [JsonProperty("runways")]
        public int Runways { get; set; }

        [JsonProperty("departures")]
        public int Departures { get; set; }

        [JsonProperty("connections")]
        public int Connections { get; set; }

        [JsonProperty("is_major")]
        public bool IsMajor { get; set; }

        [JsonProperty("is_international")]
        public int IsInternational { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("instagram")]
        public string Instagram { get; set; }

        [JsonProperty("linkedin")]
        public string Linkedin { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public class ListCountriesResponse
    {
        [JsonProperty("request")]
        public JToken Request { get; set; }

        [JsonProperty("response")]
        public ListCountriesResponseResponseTypeItem[] Response { get; set; }
    }

    public class ListCountriesResponseResponseTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("code3")]
        public string Code3 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("population")]
        public int Population { get; set; }

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("names")]
        public JToken Names { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Airlabsip;

    public partial class WorkflowManagedActions
    {
        public AirlabsipActions Airlabsip(string connectionId) => new AirlabsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AirlabsipTriggers Airlabsip(string connectionId) => new AirlabsipTriggers(connectionId);
    }
}
