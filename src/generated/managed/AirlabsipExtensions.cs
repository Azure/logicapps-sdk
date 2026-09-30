//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Airlabsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AirlabsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<ListFlightsResponse> ListFlights([WorkflowExpression] Func<string> flag = null, [WorkflowExpression] Func<string> flightIcao = null, [WorkflowExpression] Func<string> flightIata = null, [WorkflowExpression] Func<string> depIcao = null, [WorkflowExpression] Func<string> depIata = null, [WorkflowExpression] Func<string> arrIcao = null, [WorkflowExpression] Func<string> arrIata = null)
        {
            var apiCallPath = "/flights";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (flag != null)
                callPayload.Queries["flag"] = ExpressionConverter.Convert(flag);
            if (flightIcao != null)
                callPayload.Queries["flight_icao"] = ExpressionConverter.Convert(flightIcao);
            if (flightIata != null)
                callPayload.Queries["flight_iata"] = ExpressionConverter.Convert(flightIata);
            if (depIcao != null)
                callPayload.Queries["dep_icao"] = ExpressionConverter.Convert(depIcao);
            if (depIata != null)
                callPayload.Queries["dep_iata"] = ExpressionConverter.Convert(depIata);
            if (arrIcao != null)
                callPayload.Queries["arr_icao"] = ExpressionConverter.Convert(arrIcao);
            if (arrIata != null)
                callPayload.Queries["arr_iata"] = ExpressionConverter.Convert(arrIata);
            return new ApiConnectionAction<ListFlightsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<GetFlightResponse> GetFlight([WorkflowExpression] Func<string> flightIata = null, [WorkflowExpression] Func<string> flightIcao = null)
        {
            var apiCallPath = "/flight";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (flightIata != null)
                callPayload.Queries["flight_iata"] = ExpressionConverter.Convert(flightIata);
            if (flightIcao != null)
                callPayload.Queries["flight_icao"] = ExpressionConverter.Convert(flightIcao);
            return new ApiConnectionAction<GetFlightResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<ListAirlinesResponse> ListAirlines([WorkflowExpression] Func<string> iataCode = null, [WorkflowExpression] Func<string> iataPrefix = null, [WorkflowExpression] Func<string> iataAccounting = null, [WorkflowExpression] Func<string> icaoCode = null, [WorkflowExpression] Func<string> callsign = null, [WorkflowExpression] Func<string> countryCode = null, [WorkflowExpression] Func<string> Fields = null)
        {
            var apiCallPath = "/airlines";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (iataCode != null)
                callPayload.Queries["iata_code"] = ExpressionConverter.Convert(iataCode);
            if (iataPrefix != null)
                callPayload.Queries["iata_prefix"] = ExpressionConverter.Convert(iataPrefix);
            if (iataAccounting != null)
                callPayload.Queries["iata_accounting"] = ExpressionConverter.Convert(iataAccounting);
            if (icaoCode != null)
                callPayload.Queries["icao_code"] = ExpressionConverter.Convert(icaoCode);
            if (callsign != null)
                callPayload.Queries["callsign"] = ExpressionConverter.Convert(callsign);
            if (countryCode != null)
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
            if (Fields != null)
                callPayload.Queries["_fields"] = ExpressionConverter.Convert(Fields);
            return new ApiConnectionAction<ListAirlinesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<ListRoutesResponse> ListRoutes([WorkflowExpression] Func<string> depIata = null, [WorkflowExpression] Func<string> depIcao = null, [WorkflowExpression] Func<string> arrIata = null, [WorkflowExpression] Func<string> arrIcao = null, [WorkflowExpression] Func<string> airlineIcao = null, [WorkflowExpression] Func<string> airlineIata = null, [WorkflowExpression] Func<string> flightIcao = null, [WorkflowExpression] Func<string> flightIata = null, [WorkflowExpression] Func<string> Fields = null)
        {
            var apiCallPath = "/routes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (depIata != null)
                callPayload.Queries["dep_iata"] = ExpressionConverter.Convert(depIata);
            if (depIcao != null)
                callPayload.Queries["dep_icao"] = ExpressionConverter.Convert(depIcao);
            if (arrIata != null)
                callPayload.Queries["arr_iata"] = ExpressionConverter.Convert(arrIata);
            if (arrIcao != null)
                callPayload.Queries["arr_icao"] = ExpressionConverter.Convert(arrIcao);
            if (airlineIcao != null)
                callPayload.Queries["airline_icao"] = ExpressionConverter.Convert(airlineIcao);
            if (airlineIata != null)
                callPayload.Queries["airline_iata"] = ExpressionConverter.Convert(airlineIata);
            if (flightIcao != null)
                callPayload.Queries["flight_icao"] = ExpressionConverter.Convert(flightIcao);
            if (flightIata != null)
                callPayload.Queries["flight_iata"] = ExpressionConverter.Convert(flightIata);
            if (Fields != null)
                callPayload.Queries["_fields"] = ExpressionConverter.Convert(Fields);
            return new ApiConnectionAction<ListRoutesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<ListSchedulesResponse> ListSchedules([WorkflowExpression] Func<string> depIata = null, [WorkflowExpression] Func<string> depIcao = null, [WorkflowExpression] Func<string> arrIata = null, [WorkflowExpression] Func<string> arrIcao = null, [WorkflowExpression] Func<string> airlineIcao = null, [WorkflowExpression] Func<string> airlineIata = null, [WorkflowExpression] Func<string> flightIcao = null, [WorkflowExpression] Func<string> flightIata = null, [WorkflowExpression] Func<string> Fields = null)
        {
            var apiCallPath = "/schedules";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (depIata != null)
                callPayload.Queries["dep_iata"] = ExpressionConverter.Convert(depIata);
            if (depIcao != null)
                callPayload.Queries["dep_icao"] = ExpressionConverter.Convert(depIcao);
            if (arrIata != null)
                callPayload.Queries["arr_iata"] = ExpressionConverter.Convert(arrIata);
            if (arrIcao != null)
                callPayload.Queries["arr_icao"] = ExpressionConverter.Convert(arrIcao);
            if (airlineIcao != null)
                callPayload.Queries["airline_icao"] = ExpressionConverter.Convert(airlineIcao);
            if (airlineIata != null)
                callPayload.Queries["airline_iata"] = ExpressionConverter.Convert(airlineIata);
            if (flightIcao != null)
                callPayload.Queries["flight_icao"] = ExpressionConverter.Convert(flightIcao);
            if (flightIata != null)
                callPayload.Queries["flight_iata"] = ExpressionConverter.Convert(flightIata);
            if (Fields != null)
                callPayload.Queries["_fields"] = ExpressionConverter.Convert(Fields);
            return new ApiConnectionAction<ListSchedulesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<ListAirportsResponse> ListAirports([WorkflowExpression] Func<string> iataCode = null, [WorkflowExpression] Func<string> icaoCode = null, [WorkflowExpression] Func<string> cityCode = null, [WorkflowExpression] Func<string> countryCode = null, [WorkflowExpression] Func<string> Fields = null)
        {
            var apiCallPath = "/airports";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (iataCode != null)
                callPayload.Queries["iata_code"] = ExpressionConverter.Convert(iataCode);
            if (icaoCode != null)
                callPayload.Queries["icao_code"] = ExpressionConverter.Convert(icaoCode);
            if (cityCode != null)
                callPayload.Queries["city_code"] = ExpressionConverter.Convert(cityCode);
            if (countryCode != null)
                callPayload.Queries["country_code"] = ExpressionConverter.Convert(countryCode);
            if (Fields != null)
                callPayload.Queries["_fields"] = ExpressionConverter.Convert(Fields);
            return new ApiConnectionAction<ListAirportsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "airlabsip")]
        public IBodyWorkflowAction<ListCountriesResponse> ListCountries([WorkflowExpression] Func<string> code = null, [WorkflowExpression] Func<string> code3 = null, [WorkflowExpression] Func<string> continent = null, [WorkflowExpression] Func<string> Fields = null)
        {
            var apiCallPath = "/countries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (code != null)
                callPayload.Queries["code"] = ExpressionConverter.Convert(code);
            if (code3 != null)
                callPayload.Queries["code3"] = ExpressionConverter.Convert(code3);
            if (continent != null)
                callPayload.Queries["continent"] = ExpressionConverter.Convert(continent);
            if (Fields != null)
                callPayload.Queries["_fields"] = ExpressionConverter.Convert(Fields);
            return new ApiConnectionAction<ListCountriesResponse>(callPayload);
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