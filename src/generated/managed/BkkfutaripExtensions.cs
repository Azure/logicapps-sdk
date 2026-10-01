//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bkkfutarip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BkkfutaripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bkkfutarip")]
        public IBodyWorkflowAction<SearchAlertsResponse> SearchAlerts([WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<int> start = null, [WorkflowExpression] Func<int> end = null, [WorkflowExpression] Func<int> minResult = null, [WorkflowExpression] Func<includeReferencesInput> includeReferences = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/api/where/alert-search", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "otp"), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                callPayload.Queries["minResult"] = Convert.ToString(5);
                if (minResult != null)
                    callPayload.Queries["minResult"] = SourceExpressionConverter.ConvertO(minResult);
                callPayload.Queries["appVersion"] = Convert.ToString("1.1.abc");
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Queries["includeReferences"] = Convert.ToString("true");
                if (includeReferences != null)
                    callPayload.Queries["includeReferences"] = SourceExpressionConverter.Convert(includeReferences);
                return callPayload;
            }

            return new ApiConnectionAction<SearchAlertsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bkkfutarip")]
        public IBodyWorkflowAction<GetArrivalsAndDeparturesForStopResponse> GetArrivalsAndDeparturesForStop([WorkflowExpression] Func<string> stopId, [WorkflowExpression] Func<int> minutesBefore = null, [WorkflowExpression] Func<string> minutesAfter = null, [WorkflowExpression] Func<string> includeRouteId = null, [WorkflowExpression] Func<int> time = null, [WorkflowExpression] Func<bool> onlyDepartures = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<double> lat = null, [WorkflowExpression] Func<double> lon = null, [WorkflowExpression] Func<int> radius = null, [WorkflowExpression] Func<string> query = null, [WorkflowExpression] Func<int> minResult = null, [WorkflowExpression] Func<includeReferencesInput> includeReferences = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/api/where/arrivals-and-departures-for-stop", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "otp"), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (minutesBefore != null)
                    callPayload.Queries["minutesBefore"] = SourceExpressionConverter.ConvertO(minutesBefore);
                if (minutesAfter != null)
                    callPayload.Queries["minutesAfter"] = SourceExpressionConverter.ConvertO(minutesAfter);
                callPayload.Queries["stopId"] = SourceExpressionConverter.ConvertO(stopId);
                if (includeRouteId != null)
                    callPayload.Queries["includeRouteId"] = SourceExpressionConverter.ConvertO(includeRouteId);
                if (time != null)
                    callPayload.Queries["time"] = SourceExpressionConverter.ConvertO(time);
                if (onlyDepartures != null)
                    callPayload.Queries["onlyDepartures"] = SourceExpressionConverter.ConvertO(onlyDepartures);
                callPayload.Queries["limit"] = Convert.ToString(60);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                if (radius != null)
                    callPayload.Queries["radius"] = SourceExpressionConverter.ConvertO(radius);
                if (query != null)
                    callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                callPayload.Queries["minResult"] = Convert.ToString(5);
                if (minResult != null)
                    callPayload.Queries["minResult"] = SourceExpressionConverter.ConvertO(minResult);
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Queries["includeReferences"] = Convert.ToString("true");
                if (includeReferences != null)
                    callPayload.Queries["includeReferences"] = SourceExpressionConverter.Convert(includeReferences);
                callPayload.Queries["appVersion"] = Convert.ToString("1.1.abc");
                return callPayload;
            }

            return new ApiConnectionAction<GetArrivalsAndDeparturesForStopResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bkkfutarip")]
        public IBodyWorkflowAction<GetBicycleRentalStationsResponse> GetBicycleRentalStations([WorkflowExpression] Func<includeReferencesInput> includeReferences = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/api/where/bicycle-rental", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "otp"), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["appVersion"] = Convert.ToString("1.1.abc");
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Queries["includeReferences"] = Convert.ToString("true");
                if (includeReferences != null)
                    callPayload.Queries["includeReferences"] = SourceExpressionConverter.Convert(includeReferences);
                return callPayload;
            }

            return new ApiConnectionAction<GetBicycleRentalStationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bkkfutarip")]
        public IBodyWorkflowAction<GetScheduleForStopResponse> GetScheduleForStop([WorkflowExpression] Func<string> stopId, [WorkflowExpression] Func<string> date = null, [WorkflowExpression] Func<bool> onlyDepartures = null, [WorkflowExpression] Func<includeReferencesInput> includeReferences = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/api/where/schedule-for-stop", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "otp"), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["stopId"] = SourceExpressionConverter.ConvertO(stopId);
                if (date != null)
                    callPayload.Queries["date"] = SourceExpressionConverter.ConvertO(date);
                if (onlyDepartures != null)
                    callPayload.Queries["onlyDepartures"] = SourceExpressionConverter.ConvertO(onlyDepartures);
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Queries["includeReferences"] = Convert.ToString("true");
                if (includeReferences != null)
                    callPayload.Queries["includeReferences"] = SourceExpressionConverter.Convert(includeReferences);
                callPayload.Queries["appVersion"] = Convert.ToString("1.1.abc");
                return callPayload;
            }

            return new ApiConnectionAction<GetScheduleForStopResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bkkfutarip")]
        public IBodyWorkflowAction<GetStopsForLocationResponse> GetStopsForLocation([WorkflowExpression] Func<double> lat = null, [WorkflowExpression] Func<double> lon = null, [WorkflowExpression] Func<double> latSpan = null, [WorkflowExpression] Func<double> lonSpan = null, [WorkflowExpression] Func<int> radius = null, [WorkflowExpression] Func<int> minResult = null, [WorkflowExpression] Func<includeReferencesInput> includeReferences = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/api/where/stops-for-location", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "otp"), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["lat"] = SourceExpressionConverter.ConvertO(lat);
                if (lon != null)
                    callPayload.Queries["lon"] = SourceExpressionConverter.ConvertO(lon);
                if (latSpan != null)
                    callPayload.Queries["latSpan"] = SourceExpressionConverter.ConvertO(latSpan);
                if (lonSpan != null)
                    callPayload.Queries["lonSpan"] = SourceExpressionConverter.ConvertO(lonSpan);
                if (radius != null)
                    callPayload.Queries["radius"] = SourceExpressionConverter.ConvertO(radius);
                callPayload.Queries["minResult"] = Convert.ToString(5);
                if (minResult != null)
                    callPayload.Queries["minResult"] = SourceExpressionConverter.ConvertO(minResult);
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Queries["includeReferences"] = Convert.ToString("true");
                if (includeReferences != null)
                    callPayload.Queries["includeReferences"] = SourceExpressionConverter.Convert(includeReferences);
                callPayload.Queries["appVersion"] = Convert.ToString("1.1.abc");
                return callPayload;
            }

            return new ApiConnectionAction<GetStopsForLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bkkfutarip")]
        public IBodyWorkflowAction<GetVehiclesForStopResponse> GetVehiclesForStop([WorkflowExpression] Func<string> stopId, [WorkflowExpression] Func<int> ifModifiedSince = null, [WorkflowExpression] Func<includeReferencesInput> includeReferences = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/api/where/vehicles-for-stop", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "otp"), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["stopId"] = SourceExpressionConverter.ConvertO(stopId);
                if (ifModifiedSince != null)
                    callPayload.Queries["ifModifiedSince"] = SourceExpressionConverter.ConvertO(ifModifiedSince);
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Queries["includeReferences"] = Convert.ToString("true");
                if (includeReferences != null)
                    callPayload.Queries["includeReferences"] = SourceExpressionConverter.Convert(includeReferences);
                callPayload.Queries["appVersion"] = Convert.ToString("1.1.abc");
                return callPayload;
            }

            return new ApiConnectionAction<GetVehiclesForStopResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bkkfutarip")]
        public IBodyWorkflowAction<GetReferencesResponse> GetReferences([WorkflowExpression] Func<string> agencyId = null, [WorkflowExpression] Func<string> alertId = null, [WorkflowExpression] Func<string> routeId = null, [WorkflowExpression] Func<string> stopId = null, [WorkflowExpression] Func<includeReferencesInput> includeReferences = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/api/where/references", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "otp"), 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (agencyId != null)
                    callPayload.Queries["agencyId"] = SourceExpressionConverter.ConvertO(agencyId);
                if (alertId != null)
                    callPayload.Queries["alertId"] = SourceExpressionConverter.ConvertO(alertId);
                if (routeId != null)
                    callPayload.Queries["routeId"] = SourceExpressionConverter.ConvertO(routeId);
                if (stopId != null)
                    callPayload.Queries["stopId"] = SourceExpressionConverter.ConvertO(stopId);
                callPayload.Queries["version"] = Convert.ToString("2");
                callPayload.Queries["includeReferences"] = Convert.ToString("true");
                if (includeReferences != null)
                    callPayload.Queries["includeReferences"] = SourceExpressionConverter.Convert(includeReferences);
                callPayload.Queries["appVersion"] = Convert.ToString("1.1.abc");
                return callPayload;
            }

            return new ApiConnectionAction<GetReferencesResponse>(BuildSourceInput);
        }
    }

    public class BkkfutaripTriggers([ConnectionName] string connectionId)
    {
    }

    public class SearchAlertsResponse
    {
        [JsonProperty("currentTime")]
        public int CurrentTime { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("data")]
        public SearchAlertsResponseDataType Data { get; set; }
    }

    public class SearchAlertsResponseDataType
    {
        [JsonProperty("limitExceeded")]
        public bool LimitExceeded { get; set; }

        [JsonProperty("entry")]
        public SearchAlertsResponseDataTypeEntryType Entry { get; set; }

        [JsonProperty("references")]
        public ReferencesResponse References { get; set; }
    }

    public class SearchAlertsResponseDataTypeEntryType
    {
        [JsonProperty("stopIds")]
        public string[] StopIds { get; set; }

        [JsonProperty("routeIds")]
        public string[] RouteIds { get; set; }

        [JsonProperty("alertIds")]
        public string[] AlertIds { get; set; }
    }

    public class ReferencesResponse
    {
        [JsonProperty("agencies")]
        public JToken Agencies { get; set; }

        [JsonProperty("routes")]
        public JToken Routes { get; set; }

        [JsonProperty("stops")]
        public JToken Stops { get; set; }

        [JsonProperty("trips")]
        public JToken Trips { get; set; }

        [JsonProperty("alerts")]
        public JToken Alerts { get; set; }
    }

    public enum includeReferencesInput
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False,
        [EnumMember(Value = "compact")]
        Compact,
        [EnumMember(Value = "agencies")]
        Agencies,
        [EnumMember(Value = "routes")]
        Routes,
        [EnumMember(Value = "trips")]
        Trips,
        [EnumMember(Value = "stops")]
        Stops,
        [EnumMember(Value = "alerts")]
        Alerts,
        [EnumMember(Value = "stations")]
        Stations
    }

    public class GetArrivalsAndDeparturesForStopResponse
    {
        [JsonProperty("currentTime")]
        public int CurrentTime { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("data")]
        public GetArrivalsAndDeparturesForStopResponseDataType Data { get; set; }
    }

    public class GetArrivalsAndDeparturesForStopResponseDataType
    {
        [JsonProperty("limitExceeded")]
        public bool LimitExceeded { get; set; }

        [JsonProperty("entry")]
        public GetArrivalsAndDeparturesForStopResponseDataTypeEntryType Entry { get; set; }

        [JsonProperty("references")]
        public ReferencesResponse References { get; set; }
    }

    public class GetArrivalsAndDeparturesForStopResponseDataTypeEntryType
    {
        [JsonProperty("stopId")]
        public string StopId { get; set; }

        [JsonProperty("routeIds")]
        public string[] RouteIds { get; set; }

        [JsonProperty("alertIds")]
        public string[] AlertIds { get; set; }

        [JsonProperty("nearbyStopIds")]
        public string[] NearbyStopIds { get; set; }

        [JsonProperty("stopTimes")]
        public GetArrivalsAndDeparturesForStopResponseDataTypeEntryTypeStopTimesTypeItem[] StopTimes { get; set; }
    }

    public class GetArrivalsAndDeparturesForStopResponseDataTypeEntryTypeStopTimesTypeItem
    {
        [JsonProperty("stopId")]
        public string StopId { get; set; }

        [JsonProperty("stopHeadsign")]
        public string StopHeadsign { get; set; }

        [JsonProperty("arrivalTime")]
        public int ArrivalTime { get; set; }

        [JsonProperty("departureTime")]
        public int DepartureTime { get; set; }

        [JsonProperty("predictedArrivalTime")]
        public int PredictedArrivalTime { get; set; }

        [JsonProperty("predictedDepartureTime")]
        public int PredictedDepartureTime { get; set; }

        [JsonProperty("uncertain")]
        public bool Uncertain { get; set; }

        [JsonProperty("tripId")]
        public string TripId { get; set; }

        [JsonProperty("serviceDate")]
        public string ServiceDate { get; set; }

        [JsonProperty("wheelchairAccessible")]
        public bool WheelchairAccessible { get; set; }

        [JsonProperty("mayRequireBooking")]
        public bool MayRequireBooking { get; set; }

        [JsonProperty("alertIds")]
        public string[] AlertIds { get; set; }
    }

    public class GetBicycleRentalStationsResponse
    {
        [JsonProperty("currentTime")]
        public int CurrentTime { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("data")]
        public GetBicycleRentalStationsResponseDataType Data { get; set; }
    }

    public class GetBicycleRentalStationsResponseDataType
    {
        [JsonProperty("list")]
        public GetBicycleRentalStationsResponseDataTypeListTypeItem[] List { get; set; }

        [JsonProperty("limitExceeded")]
        public bool LimitExceeded { get; set; }

        [JsonProperty("references")]
        public ReferencesResponse References { get; set; }
    }

    public class GetBicycleRentalStationsResponseDataTypeListTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("bikes")]
        public int Bikes { get; set; }
    }

    public class GetScheduleForStopResponse
    {
        [JsonProperty("currentTime")]
        public int CurrentTime { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("data")]
        public GetScheduleForStopResponseDataType Data { get; set; }
    }

    public class GetScheduleForStopResponseDataType
    {
        [JsonProperty("entry")]
        public GetScheduleForStopResponseDataTypeEntryType Entry { get; set; }

        [JsonProperty("limitExceeded")]
        public bool LimitExceeded { get; set; }

        [JsonProperty("references")]
        public ReferencesResponse References { get; set; }
    }

    public class GetScheduleForStopResponseDataTypeEntryType
    {
        [JsonProperty("stopId")]
        public string StopId { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("routeIds")]
        public string[] RouteIds { get; set; }

        [JsonProperty("nearbyStopIds")]
        public string[] NearbyStopIds { get; set; }

        [JsonProperty("alertIds")]
        public string[] AlertIds { get; set; }

        [JsonProperty("schedules")]
        public GetScheduleForStopResponseDataTypeEntryTypeSchedulesTypeItem[] Schedules { get; set; }
    }

    public class GetScheduleForStopResponseDataTypeEntryTypeSchedulesTypeItem
    {
        [JsonProperty("routeId")]
        public string RouteId { get; set; }

        [JsonProperty("alertIds")]
        public string[] AlertIds { get; set; }

        [JsonProperty("directions")]
        public GetScheduleForStopResponseDataTypeEntryTypeSchedulesTypeItemDirectionsTypeItem[] Directions { get; set; }
    }

    public class GetScheduleForStopResponseDataTypeEntryTypeSchedulesTypeItemDirectionsTypeItem
    {
        [JsonProperty("directionId")]
        public string DirectionId { get; set; }

        [JsonProperty("groups")]
        public JToken Groups { get; set; }

        [JsonProperty("stopTimes")]
        public JToken[] StopTimes { get; set; }
    }

    public class GetStopsForLocationResponse
    {
        [JsonProperty("currentTime")]
        public int CurrentTime { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("data")]
        public GetStopsForLocationResponseDataType Data { get; set; }
    }

    public class GetStopsForLocationResponseDataType
    {
        [JsonProperty("list")]
        public GetStopsForLocationResponseDataTypeListTypeItem[] List { get; set; }

        [JsonProperty("limitExceeded")]
        public bool LimitExceeded { get; set; }

        [JsonProperty("references")]
        public ReferencesResponse References { get; set; }
    }

    public class GetStopsForLocationResponseDataTypeListTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("vertex")]
        public string Vertex { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("platformCode")]
        public string PlatformCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("locationType")]
        public int LocationType { get; set; }

        [JsonProperty("locationSubType")]
        public string LocationSubType { get; set; }

        [JsonProperty("parentStationId")]
        public string ParentStationId { get; set; }

        [JsonProperty("wheelchairBoarding")]
        public bool WheelchairBoarding { get; set; }

        [JsonProperty("routeIds")]
        public string[] RouteIds { get; set; }

        [JsonProperty("alertIds")]
        public string[] AlertIds { get; set; }
    }

    public class GetVehiclesForStopResponse
    {
        [JsonProperty("currentTime")]
        public int CurrentTime { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("data")]
        public GetVehiclesForStopResponseDataType Data { get; set; }
    }

    public class GetVehiclesForStopResponseDataType
    {
        [JsonProperty("list")]
        public GetVehiclesForStopResponseDataTypeListTypeItem[] List { get; set; }

        [JsonProperty("limitExceeded")]
        public bool LimitExceeded { get; set; }

        [JsonProperty("references")]
        public ReferencesResponse References { get; set; }
    }

    public class GetVehiclesForStopResponseDataTypeListTypeItem
    {
        [JsonProperty("vehicleId")]
        public string VehicleId { get; set; }

        [JsonProperty("stopId")]
        public string StopId { get; set; }

        [JsonProperty("stopSequence")]
        public int StopSequence { get; set; }

        [JsonProperty("routeId")]
        public string RouteId { get; set; }

        [JsonProperty("bearing")]
        public double Bearing { get; set; }

        [JsonProperty("location")]
        public GetVehiclesForStopResponseDataTypeListTypeItemLocationType Location { get; set; }

        [JsonProperty("licensePlate")]
        public string LicensePlate { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("deviated")]
        public bool Deviated { get; set; }

        [JsonProperty("lastUpdateTime")]
        public int LastUpdateTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("stopDistancePercent")]
        public int StopDistancePercent { get; set; }

        [JsonProperty("wheelchairAccessible")]
        public bool WheelchairAccessible { get; set; }

        [JsonProperty("capacity")]
        public JToken Capacity { get; set; }

        [JsonProperty("occupancy")]
        public JToken Occupancy { get; set; }

        [JsonProperty("tripId")]
        public string TripId { get; set; }

        [JsonProperty("vertex")]
        public string Vertex { get; set; }
    }

    public class GetVehiclesForStopResponseDataTypeListTypeItemLocationType
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }
    }

    public class GetReferencesResponse
    {
        [JsonProperty("currentTime")]
        public int CurrentTime { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("data")]
        public GetReferencesResponseDataType Data { get; set; }
    }

    public class GetReferencesResponseDataType
    {
        [JsonProperty("entry")]
        public GetReferencesResponseDataTypeEntryType Entry { get; set; }

        [JsonProperty("limitExceeded")]
        public bool LimitExceeded { get; set; }

        [JsonProperty("references")]
        public ReferencesResponse References { get; set; }
    }

    public class GetReferencesResponseDataTypeEntryType
    {
        [JsonProperty("errors")]
        public GetReferencesResponseDataTypeEntryTypeErrorsType Errors { get; set; }
    }

    public class GetReferencesResponseDataTypeEntryTypeErrorsType
    {
        [JsonProperty("agencyIds")]
        public string[] AgencyIds { get; set; }

        [JsonProperty("alertIds")]
        public string[] AlertIds { get; set; }

        [JsonProperty("routeIds")]
        public string[] RouteIds { get; set; }

        [JsonProperty("stopIds")]
        public string[] StopIds { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bkkfutarip;

    public partial class WorkflowManagedActions
    {
        public BkkfutaripActions Bkkfutarip(string connectionId) => new BkkfutaripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BkkfutaripTriggers Bkkfutarip(string connectionId) => new BkkfutaripTriggers(connectionId);
    }
}