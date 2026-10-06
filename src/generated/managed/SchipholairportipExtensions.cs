//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Schipholairportip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SchipholairportipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveFlightUsingGET))]
        public IBodyWorkflowAction<RetrieveFlightUsingGETResponse> RetrieveFlightUsingGET([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> appKey, [WorkflowExpression] Func<string> resourceVersion, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveFlightUsingGETResponse> __BuildRetrieveFlightUsingGET(WorkflowExpression<string> appId, WorkflowExpression<string> appKey, WorkflowExpression<string> resourceVersion, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            WorkflowExpression.Validate(appKey, nameof(appKey), required: true);
            WorkflowExpression.Validate(resourceVersion, nameof(resourceVersion), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RetrieveFlightUsingGETResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/flights/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["app_id"] = ExpressionConverter.Convert(appId);
                callPayload.Headers["app_key"] = ExpressionConverter.Convert(appKey);
                callPayload.Headers["ResourceVersion"] = ExpressionConverter.Convert(resourceVersion);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveFlightUsingGETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveFlightsForDateOrPeriodUsingGET))]
        public IBodyWorkflowAction<RetrieveFlightsForDateOrPeriodUsingGETResponse> RetrieveFlightsForDateOrPeriodUsingGET([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> appKey, [WorkflowExpression] Func<string> resourceVersion, [WorkflowExpression] Func<string> scheduleDate = null, [WorkflowExpression] Func<string> scheduleTime = null, [WorkflowExpression] Func<string> flightName = null, [WorkflowExpression] Func<flightDirectionInput> flightDirection = null, [WorkflowExpression] Func<string> airline = null, [WorkflowExpression] Func<int> airlineCode = null, [WorkflowExpression] Func<string> route = null, [WorkflowExpression] Func<bool> includedelays = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> fromDateTime = null, [WorkflowExpression] Func<string> toDateTime = null, [WorkflowExpression] Func<string> searchDateTimeField = null, [WorkflowExpression] Func<string> fromScheduleDate = null, [WorkflowExpression] Func<string> toScheduleDate = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveFlightsForDateOrPeriodUsingGETResponse> __BuildRetrieveFlightsForDateOrPeriodUsingGET(WorkflowExpression<string> appId, WorkflowExpression<string> appKey, WorkflowExpression<string> resourceVersion, WorkflowExpression<string> scheduleDate = null, WorkflowExpression<string> scheduleTime = null, WorkflowExpression<string> flightName = null, WorkflowExpression<flightDirectionInput> flightDirection = null, WorkflowExpression<string> airline = null, WorkflowExpression<int> airlineCode = null, WorkflowExpression<string> route = null, WorkflowExpression<bool> includedelays = null, WorkflowExpression<int> page = null, WorkflowExpression<string> sort = null, WorkflowExpression<string> fromDateTime = null, WorkflowExpression<string> toDateTime = null, WorkflowExpression<string> searchDateTimeField = null, WorkflowExpression<string> fromScheduleDate = null, WorkflowExpression<string> toScheduleDate = null)
        {
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            WorkflowExpression.Validate(appKey, nameof(appKey), required: true);
            WorkflowExpression.Validate(resourceVersion, nameof(resourceVersion), required: true);
            WorkflowExpression.Validate(scheduleDate, nameof(scheduleDate), required: false);
            WorkflowExpression.Validate(scheduleTime, nameof(scheduleTime), required: false);
            WorkflowExpression.Validate(flightName, nameof(flightName), required: false);
            WorkflowExpression.Validate(flightDirection, nameof(flightDirection), required: false);
            WorkflowExpression.Validate(airline, nameof(airline), required: false);
            WorkflowExpression.Validate(airlineCode, nameof(airlineCode), required: false);
            WorkflowExpression.Validate(route, nameof(route), required: false);
            WorkflowExpression.Validate(includedelays, nameof(includedelays), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            WorkflowExpression.Validate(fromDateTime, nameof(fromDateTime), required: false);
            WorkflowExpression.Validate(toDateTime, nameof(toDateTime), required: false);
            WorkflowExpression.Validate(searchDateTimeField, nameof(searchDateTimeField), required: false);
            WorkflowExpression.Validate(fromScheduleDate, nameof(fromScheduleDate), required: false);
            WorkflowExpression.Validate(toScheduleDate, nameof(toScheduleDate), required: false);
            return new DeferredBodyAction<RetrieveFlightsForDateOrPeriodUsingGETResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveAllAirlinesUsingGET))]
        public IBodyWorkflowAction<RetrieveAllAirlinesUsingGETResponse> RetrieveAllAirlinesUsingGET([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> appKey, [WorkflowExpression] Func<string> resourceVersion, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveAllAirlinesUsingGETResponse> __BuildRetrieveAllAirlinesUsingGET(WorkflowExpression<string> appId, WorkflowExpression<string> appKey, WorkflowExpression<string> resourceVersion, WorkflowExpression<int> page = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            WorkflowExpression.Validate(appKey, nameof(appKey), required: true);
            WorkflowExpression.Validate(resourceVersion, nameof(resourceVersion), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<RetrieveAllAirlinesUsingGETResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveAirlineUsingGET))]
        public IBodyWorkflowAction<RetrieveAirlineUsingGETResponse> RetrieveAirlineUsingGET([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> appKey, [WorkflowExpression] Func<string> resourceVersion, [WorkflowExpression] Func<string> airline)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveAirlineUsingGETResponse> __BuildRetrieveAirlineUsingGET(WorkflowExpression<string> appId, WorkflowExpression<string> appKey, WorkflowExpression<string> resourceVersion, WorkflowExpression<string> airline)
        {
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            WorkflowExpression.Validate(appKey, nameof(appKey), required: true);
            WorkflowExpression.Validate(resourceVersion, nameof(resourceVersion), required: true);
            WorkflowExpression.Validate(airline, nameof(airline), required: true);
            return new DeferredBodyAction<RetrieveAirlineUsingGETResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/airlines/{0}", ExpressionConverter.ConvertWithUrlEncoding(airline, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["app_id"] = ExpressionConverter.Convert(appId);
                callPayload.Headers["app_key"] = ExpressionConverter.Convert(appKey);
                callPayload.Headers["ResourceVersion"] = ExpressionConverter.Convert(resourceVersion);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveAirlineUsingGETResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveAllAircraftTypesUsingGET))]
        public IBodyWorkflowAction<RetrieveAllAircraftTypesUsingGETResponse> RetrieveAllAircraftTypesUsingGET([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> appKey, [WorkflowExpression] Func<string> resourceVersion, [WorkflowExpression] Func<string> iataMain = null, [WorkflowExpression] Func<string> iataSub = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveAllAircraftTypesUsingGETResponse> __BuildRetrieveAllAircraftTypesUsingGET(WorkflowExpression<string> appId, WorkflowExpression<string> appKey, WorkflowExpression<string> resourceVersion, WorkflowExpression<string> iataMain = null, WorkflowExpression<string> iataSub = null, WorkflowExpression<int> page = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            WorkflowExpression.Validate(appKey, nameof(appKey), required: true);
            WorkflowExpression.Validate(resourceVersion, nameof(resourceVersion), required: true);
            WorkflowExpression.Validate(iataMain, nameof(iataMain), required: false);
            WorkflowExpression.Validate(iataSub, nameof(iataSub), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<RetrieveAllAircraftTypesUsingGETResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveAllDestinationsUsingGET))]
        public IBodyWorkflowAction<RetrieveAllDestinationsUsingGETResponse> RetrieveAllDestinationsUsingGET([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> appKey, [WorkflowExpression] Func<string> resourceVersion, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveAllDestinationsUsingGETResponse> __BuildRetrieveAllDestinationsUsingGET(WorkflowExpression<string> appId, WorkflowExpression<string> appKey, WorkflowExpression<string> resourceVersion, WorkflowExpression<int> page = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            WorkflowExpression.Validate(appKey, nameof(appKey), required: true);
            WorkflowExpression.Validate(resourceVersion, nameof(resourceVersion), required: true);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<RetrieveAllDestinationsUsingGETResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveDestinationUsingGET))]
        public IBodyWorkflowAction<RetrieveDestinationUsingGETResponse> RetrieveDestinationUsingGET([WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> appKey, [WorkflowExpression] Func<string> resourceVersion, [WorkflowExpression] Func<string> iata)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "schipholairportip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveDestinationUsingGETResponse> __BuildRetrieveDestinationUsingGET(WorkflowExpression<string> appId, WorkflowExpression<string> appKey, WorkflowExpression<string> resourceVersion, WorkflowExpression<string> iata)
        {
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            WorkflowExpression.Validate(appKey, nameof(appKey), required: true);
            WorkflowExpression.Validate(resourceVersion, nameof(resourceVersion), required: true);
            WorkflowExpression.Validate(iata, nameof(iata), required: true);
            return new DeferredBodyAction<RetrieveDestinationUsingGETResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/destinations/{0}", ExpressionConverter.ConvertWithUrlEncoding(iata, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["app_id"] = ExpressionConverter.Convert(appId);
                callPayload.Headers["app_key"] = ExpressionConverter.Convert(appKey);
                callPayload.Headers["ResourceVersion"] = ExpressionConverter.Convert(resourceVersion);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveDestinationUsingGETResponse>(callPayload);
            });
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