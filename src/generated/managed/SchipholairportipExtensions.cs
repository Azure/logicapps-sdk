//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Schipholairportip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SchipholairportipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        public IBodyWorkflowAction<RetrieveFlightUsingGETResponse> RetrieveFlightUsingGET(Expression<Func<string>> appId, Expression<Func<string>> appKey, Expression<Func<string>> resourceVersion, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/flights/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["app_id"] = ExpressionConverter.Convert(appId);
            callPayload.Headers["app_key"] = ExpressionConverter.Convert(appKey);
            callPayload.Headers["ResourceVersion"] = ExpressionConverter.Convert(resourceVersion);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveFlightUsingGETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        public IBodyWorkflowAction<RetrieveFlightsForDateOrPeriodUsingGETResponse> RetrieveFlightsForDateOrPeriodUsingGET(Expression<Func<string>> appId, Expression<Func<string>> appKey, Expression<Func<string>> resourceVersion, Expression<Func<string>> scheduleDate = null, Expression<Func<string>> scheduleTime = null, Expression<Func<string>> flightName = null, Expression<Func<flightDirectionInput>> flightDirection = null, Expression<Func<string>> airline = null, Expression<Func<int>> airlineCode = null, Expression<Func<string>> route = null, Expression<Func<bool>> includedelays = null, Expression<Func<int>> page = null, Expression<Func<string>> sort = null, Expression<Func<string>> fromDateTime = null, Expression<Func<string>> toDateTime = null, Expression<Func<string>> searchDateTimeField = null, Expression<Func<string>> fromScheduleDate = null, Expression<Func<string>> toScheduleDate = null)
        {
            var apiCallPath = "/flights";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (scheduleDate != null)
                callPayload.Queries["scheduleDate"] = ExpressionConverter.Convert(scheduleDate);
            if (scheduleTime != null)
                callPayload.Queries["scheduleTime"] = ExpressionConverter.Convert(scheduleTime);
            if (flightName != null)
                callPayload.Queries["flightName"] = ExpressionConverter.Convert(flightName);
            if (flightDirection != null)
                callPayload.Queries["flightDirection"] = ExpressionConverter.Convert(flightDirection);
            if (airline != null)
                callPayload.Queries["airline"] = ExpressionConverter.Convert(airline);
            if (airlineCode != null)
                callPayload.Queries["airlineCode"] = ExpressionConverter.Convert(airlineCode);
            if (route != null)
                callPayload.Queries["route"] = ExpressionConverter.Convert(route);
            callPayload.Queries["includedelays"] = Convert.ToString(false);
            if (includedelays != null)
                callPayload.Queries["includedelays"] = ExpressionConverter.Convert(includedelays);
            callPayload.Queries["page"] = Convert.ToString(0);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["sort"] = Convert.ToString("+scheduleTime");
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (fromDateTime != null)
                callPayload.Queries["fromDateTime"] = ExpressionConverter.Convert(fromDateTime);
            if (toDateTime != null)
                callPayload.Queries["toDateTime"] = ExpressionConverter.Convert(toDateTime);
            if (searchDateTimeField != null)
                callPayload.Queries["searchDateTimeField"] = ExpressionConverter.Convert(searchDateTimeField);
            if (fromScheduleDate != null)
                callPayload.Queries["fromScheduleDate"] = ExpressionConverter.Convert(fromScheduleDate);
            if (toScheduleDate != null)
                callPayload.Queries["toScheduleDate"] = ExpressionConverter.Convert(toScheduleDate);
            callPayload.Headers["app_id"] = ExpressionConverter.Convert(appId);
            callPayload.Headers["app_key"] = ExpressionConverter.Convert(appKey);
            callPayload.Headers["ResourceVersion"] = ExpressionConverter.Convert(resourceVersion);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveFlightsForDateOrPeriodUsingGETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        public IBodyWorkflowAction<RetrieveAllAirlinesUsingGETResponse> RetrieveAllAirlinesUsingGET(Expression<Func<string>> appId, Expression<Func<string>> appKey, Expression<Func<string>> resourceVersion, Expression<Func<int>> page = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/airlines";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(0);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["sort"] = Convert.ToString("+publicName");
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            callPayload.Headers["app_id"] = ExpressionConverter.Convert(appId);
            callPayload.Headers["app_key"] = ExpressionConverter.Convert(appKey);
            callPayload.Headers["ResourceVersion"] = ExpressionConverter.Convert(resourceVersion);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveAllAirlinesUsingGETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        public IBodyWorkflowAction<RetrieveAirlineUsingGETResponse> RetrieveAirlineUsingGET(Expression<Func<string>> appId, Expression<Func<string>> appKey, Expression<Func<string>> resourceVersion, Expression<Func<string>> airline)
        {
            var apiCallPath = String.Format("/airlines/{0}", ExpressionConverter.ConvertWithUrlEncoding(airline, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["app_id"] = ExpressionConverter.Convert(appId);
            callPayload.Headers["app_key"] = ExpressionConverter.Convert(appKey);
            callPayload.Headers["ResourceVersion"] = ExpressionConverter.Convert(resourceVersion);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveAirlineUsingGETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        public IBodyWorkflowAction<RetrieveAllAircraftTypesUsingGETResponse> RetrieveAllAircraftTypesUsingGET(Expression<Func<string>> appId, Expression<Func<string>> appKey, Expression<Func<string>> resourceVersion, Expression<Func<string>> iataMain = null, Expression<Func<string>> iataSub = null, Expression<Func<int>> page = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/aircrafttypes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (iataMain != null)
                callPayload.Queries["iataMain"] = ExpressionConverter.Convert(iataMain);
            if (iataSub != null)
                callPayload.Queries["iataSub"] = ExpressionConverter.Convert(iataSub);
            callPayload.Queries["page"] = Convert.ToString(0);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["sort"] = Convert.ToString("+iataMain");
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            callPayload.Headers["app_id"] = ExpressionConverter.Convert(appId);
            callPayload.Headers["app_key"] = ExpressionConverter.Convert(appKey);
            callPayload.Headers["ResourceVersion"] = ExpressionConverter.Convert(resourceVersion);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveAllAircraftTypesUsingGETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        public IBodyWorkflowAction<RetrieveAllDestinationsUsingGETResponse> RetrieveAllDestinationsUsingGET(Expression<Func<string>> appId, Expression<Func<string>> appKey, Expression<Func<string>> resourceVersion, Expression<Func<int>> page = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/destinations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(0);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["sort"] = Convert.ToString("+publicName.dutch");
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            callPayload.Headers["app_id"] = ExpressionConverter.Convert(appId);
            callPayload.Headers["app_key"] = ExpressionConverter.Convert(appKey);
            callPayload.Headers["ResourceVersion"] = ExpressionConverter.Convert(resourceVersion);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveAllDestinationsUsingGETResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        public IBodyWorkflowAction<RetrieveDestinationUsingGETResponse> RetrieveDestinationUsingGET(Expression<Func<string>> appId, Expression<Func<string>> appKey, Expression<Func<string>> resourceVersion, Expression<Func<string>> iata)
        {
            var apiCallPath = String.Format("/destinations/{0}", ExpressionConverter.ConvertWithUrlEncoding(iata, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["app_id"] = ExpressionConverter.Convert(appId);
            callPayload.Headers["app_key"] = ExpressionConverter.Convert(appKey);
            callPayload.Headers["ResourceVersion"] = ExpressionConverter.Convert(resourceVersion);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveDestinationUsingGETResponse>(callPayload);
        }
    }

    public class SchipholairportipTriggers([ConnectionName] string connectionId)
    {
    }

    public class RetrieveFlightUsingGETResponse
    {
        [JsonProperty("lastUpdatedAt")]
        public string LastUpdatedAt { get; set; }

        [JsonProperty("actualLandingTime")]
        public string ActualLandingTime { get; set; }

        [JsonProperty("aircraftType")]
        public RetrieveFlightUsingGETResponseAircraftTypeType AircraftType { get; set; }

        [JsonProperty("baggageClaim")]
        public RetrieveFlightUsingGETResponseBaggageClaimType BaggageClaim { get; set; }

        [JsonProperty("estimatedLandingTime")]
        public string EstimatedLandingTime { get; set; }

        [JsonProperty("expectedTimeOnBelt")]
        public string ExpectedTimeOnBelt { get; set; }

        [JsonProperty("flightDirection")]
        public string FlightDirection { get; set; }

        [JsonProperty("flightName")]
        public string FlightName { get; set; }

        [JsonProperty("flightNumber")]
        public int FlightNumber { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isOperationalFlight")]
        public bool IsOperationalFlight { get; set; }

        [JsonProperty("mainFlight")]
        public string MainFlight { get; set; }

        [JsonProperty("prefixIATA")]
        public string PrefixIATA { get; set; }

        [JsonProperty("prefixICAO")]
        public string PrefixICAO { get; set; }

        [JsonProperty("airlineCode")]
        public int AirlineCode { get; set; }

        [JsonProperty("publicFlightState")]
        public RetrieveFlightUsingGETResponsePublicFlightStateType PublicFlightState { get; set; }

        [JsonProperty("route")]
        public RetrieveFlightUsingGETResponseRouteType Route { get; set; }

        [JsonProperty("scheduleDateTime")]
        public string ScheduleDateTime { get; set; }

        [JsonProperty("scheduleDate")]
        public string ScheduleDate { get; set; }

        [JsonProperty("scheduleTime")]
        public string ScheduleTime { get; set; }

        [JsonProperty("serviceType")]
        public string ServiceType { get; set; }

        [JsonProperty("terminal")]
        public int Terminal { get; set; }

        [JsonProperty("schemaVersion")]
        public string SchemaVersion { get; set; }
    }

    public class RetrieveFlightUsingGETResponseAircraftTypeType
    {
        [JsonProperty("iataMain")]
        public string IataMain { get; set; }

        [JsonProperty("iataSub")]
        public string IataSub { get; set; }
    }

    public class RetrieveFlightUsingGETResponseBaggageClaimType
    {
        [JsonProperty("belts")]
        public string[] Belts { get; set; }
    }

    public class RetrieveFlightUsingGETResponsePublicFlightStateType
    {
        [JsonProperty("flightStates")]
        public string[] FlightStates { get; set; }
    }

    public class RetrieveFlightUsingGETResponseRouteType
    {
        [JsonProperty("destinations")]
        public string[] Destinations { get; set; }

        [JsonProperty("eu")]
        public string Eu { get; set; }

        [JsonProperty("visa")]
        public bool Visa { get; set; }
    }

    public class RetrieveFlightsForDateOrPeriodUsingGETResponse
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("headers")]
        public RetrieveFlightsForDateOrPeriodUsingGETResponseHeadersType Headers { get; set; }

        [JsonProperty("body")]
        public RetrieveFlightsForDateOrPeriodUsingGETResponseBodyType Body { get; set; }
    }

    public class RetrieveFlightsForDateOrPeriodUsingGETResponseHeadersType
    {
        [JsonProperty("Transfer-Encoding")]
        public string TransferEncoding { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("x-ms-apihub-cached-response")]
        public string XMsApihubCachedResponse { get; set; }

        [JsonProperty("x-ms-apihub-obo")]
        public string XMsApihubObo { get; set; }

        [JsonProperty("Cache-Control")]
        public string CacheControl { get; set; }
        public string Date { get; set; }

        [JsonProperty("Set-Cookie")]
        public string SetCookie { get; set; }

        [JsonProperty("Content-Type")]
        public string ContentType { get; set; }

        [JsonProperty("Content-Length")]
        public string ContentLength { get; set; }
    }

    public class RetrieveFlightsForDateOrPeriodUsingGETResponseBodyType
    {
        [JsonProperty("flights")]
        public RetrieveFlightsForDateOrPeriodUsingGETResponseBodyTypeFlightsTypeItem[] Flights { get; set; }
    }

    public class RetrieveFlightsForDateOrPeriodUsingGETResponseBodyTypeFlightsTypeItem
    {
        [JsonProperty("lastUpdatedAt")]
        public string LastUpdatedAt { get; set; }

        [JsonProperty("actualLandingTime")]
        public string ActualLandingTime { get; set; }

        [JsonProperty("aircraftType")]
        public RetrieveFlightsForDateOrPeriodUsingGETResponseBodyTypeFlightsTypeItemAircraftTypeType AircraftType { get; set; }

        [JsonProperty("baggageClaim")]
        public RetrieveFlightsForDateOrPeriodUsingGETResponseBodyTypeFlightsTypeItemBaggageClaimType BaggageClaim { get; set; }

        [JsonProperty("codeshares")]
        public RetrieveFlightsForDateOrPeriodUsingGETResponseBodyTypeFlightsTypeItemCodesharesType Codeshares { get; set; }

        [JsonProperty("estimatedLandingTime")]
        public string EstimatedLandingTime { get; set; }

        [JsonProperty("expectedTimeOnBelt")]
        public string ExpectedTimeOnBelt { get; set; }

        [JsonProperty("flightDirection")]
        public string FlightDirection { get; set; }

        [JsonProperty("flightName")]
        public string FlightName { get; set; }

        [JsonProperty("flightNumber")]
        public int FlightNumber { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isOperationalFlight")]
        public bool IsOperationalFlight { get; set; }

        [JsonProperty("mainFlight")]
        public string MainFlight { get; set; }

        [JsonProperty("prefixIATA")]
        public string PrefixIATA { get; set; }

        [JsonProperty("prefixICAO")]
        public string PrefixICAO { get; set; }

        [JsonProperty("airlineCode")]
        public int AirlineCode { get; set; }

        [JsonProperty("publicFlightState")]
        public RetrieveFlightsForDateOrPeriodUsingGETResponseBodyTypeFlightsTypeItemPublicFlightStateType PublicFlightState { get; set; }

        [JsonProperty("route")]
        public RetrieveFlightsForDateOrPeriodUsingGETResponseBodyTypeFlightsTypeItemRouteType Route { get; set; }

        [JsonProperty("scheduleDateTime")]
        public string ScheduleDateTime { get; set; }

        [JsonProperty("scheduleDate")]
        public string ScheduleDate { get; set; }

        [JsonProperty("scheduleTime")]
        public string ScheduleTime { get; set; }

        [JsonProperty("serviceType")]
        public string ServiceType { get; set; }

        [JsonProperty("terminal")]
        public int Terminal { get; set; }

        [JsonProperty("schemaVersion")]
        public string SchemaVersion { get; set; }

        [JsonProperty("actualOffBlockTime")]
        public string ActualOffBlockTime { get; set; }

        [JsonProperty("aircraftRegistration")]
        public string AircraftRegistration { get; set; }

        [JsonProperty("publicEstimatedOffBlockTime")]
        public string PublicEstimatedOffBlockTime { get; set; }
    }

    public class RetrieveFlightsForDateOrPeriodUsingGETResponseBodyTypeFlightsTypeItemAircraftTypeType
    {
        [JsonProperty("iataMain")]
        public string IataMain { get; set; }

        [JsonProperty("iataSub")]
        public string IataSub { get; set; }
    }

    public class RetrieveFlightsForDateOrPeriodUsingGETResponseBodyTypeFlightsTypeItemBaggageClaimType
    {
        [JsonProperty("belts")]
        public string[] Belts { get; set; }
    }

    public class RetrieveFlightsForDateOrPeriodUsingGETResponseBodyTypeFlightsTypeItemCodesharesType
    {
        [JsonProperty("codeshares")]
        public string[] Codeshares { get; set; }
    }

    public class RetrieveFlightsForDateOrPeriodUsingGETResponseBodyTypeFlightsTypeItemPublicFlightStateType
    {
        [JsonProperty("flightStates")]
        public string[] FlightStates { get; set; }
    }

    public class RetrieveFlightsForDateOrPeriodUsingGETResponseBodyTypeFlightsTypeItemRouteType
    {
        [JsonProperty("destinations")]
        public string[] Destinations { get; set; }

        [JsonProperty("eu")]
        public string Eu { get; set; }

        [JsonProperty("visa")]
        public bool Visa { get; set; }
    }

    public enum flightDirectionInput
    {
        A,
        D
    }

    public class RetrieveAllAirlinesUsingGETResponse
    {
        [JsonProperty("airlines")]
        public RetrieveAllAirlinesUsingGETResponseAirlinesTypeItem[] Airlines { get; set; }
    }

    public class RetrieveAllAirlinesUsingGETResponseAirlinesTypeItem
    {
        [JsonProperty("nvls")]
        public int Nvls { get; set; }

        [JsonProperty("publicName")]
        public string PublicName { get; set; }

        [JsonProperty("icao")]
        public string Icao { get; set; }

        [JsonProperty("iata")]
        public string Iata { get; set; }
    }

    public class RetrieveAirlineUsingGETResponse
    {
        [JsonProperty("iata")]
        public string Iata { get; set; }

        [JsonProperty("icao")]
        public string Icao { get; set; }

        [JsonProperty("nvls")]
        public int Nvls { get; set; }

        [JsonProperty("publicName")]
        public string PublicName { get; set; }
    }

    public class RetrieveAllAircraftTypesUsingGETResponse
    {
        [JsonProperty("aircraftTypes")]
        public RetrieveAllAircraftTypesUsingGETResponseAircraftTypesTypeItem[] AircraftTypes { get; set; }
    }

    public class RetrieveAllAircraftTypesUsingGETResponseAircraftTypesTypeItem
    {
        [JsonProperty("iataMain")]
        public string IataMain { get; set; }

        [JsonProperty("iataSub")]
        public string IataSub { get; set; }

        [JsonProperty("longDescription")]
        public string LongDescription { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }
    }

    public class RetrieveAllDestinationsUsingGETResponse
    {
        [JsonProperty("destinations")]
        public RetrieveAllDestinationsUsingGETResponseDestinationsTypeItem[] Destinations { get; set; }
    }

    public class RetrieveAllDestinationsUsingGETResponseDestinationsTypeItem
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("iata")]
        public string Iata { get; set; }

        [JsonProperty("publicName")]
        public RetrieveAllDestinationsUsingGETResponseDestinationsTypeItemPublicNameType PublicName { get; set; }
    }

    public class RetrieveAllDestinationsUsingGETResponseDestinationsTypeItemPublicNameType
    {
        [JsonProperty("dutch")]
        public string Dutch { get; set; }

        [JsonProperty("english")]
        public string English { get; set; }
    }

    public class RetrieveDestinationUsingGETResponse
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("iata")]
        public string Iata { get; set; }

        [JsonProperty("publicName")]
        public RetrieveDestinationUsingGETResponsePublicNameType PublicName { get; set; }
    }

    public class RetrieveDestinationUsingGETResponsePublicNameType
    {
        [JsonProperty("dutch")]
        public string Dutch { get; set; }

        [JsonProperty("english")]
        public string English { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Schipholairportip;

    public partial class WorkflowManagedActions
    {
        public SchipholairportipActions Schipholairportip(string connectionId) => new SchipholairportipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SchipholairportipTriggers Schipholairportip(string connectionId) => new SchipholairportipTriggers(connectionId);
    }
}