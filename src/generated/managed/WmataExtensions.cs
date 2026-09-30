//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wmata
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WmataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetNextBusesResponse> GetNextBuses([WorkflowExpression] Func<string> stopId)
        {
            SourceExpression.Validate(stopId, nameof(stopId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/NextBusService.svc/json/jPredictions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["StopID"] = SourceExpressionConverter.ConvertO(stopId);
                return callPayload;
            }

            return new ApiConnectionAction<GetNextBusesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetBusPositionsResponse> GetBusPositions([WorkflowExpression] Func<string> routeId = null, [WorkflowExpression] Func<double> lat = null, [WorkflowExpression] Func<double> lon = null, [WorkflowExpression] Func<double> radius = null)
        {
            SourceExpression.Validate(routeId, nameof(routeId), required: false);
            SourceExpression.Validate(lat, nameof(lat), required: false);
            SourceExpression.Validate(lon, nameof(lon), required: false);
            SourceExpression.Validate(radius, nameof(radius), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Bus.svc/json/jBusPositions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (routeId != null)
                    callPayload.Queries["RouteID"] = SourceExpressionConverter.ConvertO(routeId);
                if (lat != null)
                    callPayload.Queries["Lat"] = SourceExpressionConverter.ConvertO(lat);
                if (lon != null)
                    callPayload.Queries["Lon"] = SourceExpressionConverter.ConvertO(lon);
                if (radius != null)
                    callPayload.Queries["Radius"] = SourceExpressionConverter.ConvertO(radius);
                return callPayload;
            }

            return new ApiConnectionAction<GetBusPositionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetRouteDetailsResponse> GetRouteDetails([WorkflowExpression] Func<string> routeId, [WorkflowExpression] Func<string> date = null)
        {
            SourceExpression.Validate(routeId, nameof(routeId), required: true);
            SourceExpression.Validate(date, nameof(date), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Bus.svc/json/jRouteDetails";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["RouteID"] = SourceExpressionConverter.ConvertO(routeId);
                if (date != null)
                    callPayload.Queries["Date"] = SourceExpressionConverter.ConvertO(date);
                return callPayload;
            }

            return new ApiConnectionAction<GetRouteDetailsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetBusRoutesResponse> GetBusRoutes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Bus.svc/json/jRoutes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetBusRoutesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetBusRouteScheduleResponse> GetBusRouteSchedule([WorkflowExpression] Func<string> routeId, [WorkflowExpression] Func<string> date = null)
        {
            SourceExpression.Validate(routeId, nameof(routeId), required: true);
            SourceExpression.Validate(date, nameof(date), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Bus.svc/json/jRouteSchedule";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["RouteID"] = SourceExpressionConverter.ConvertO(routeId);
                if (date != null)
                    callPayload.Queries["Date"] = SourceExpressionConverter.ConvertO(date);
                return callPayload;
            }

            return new ApiConnectionAction<GetBusRouteScheduleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetBusStopScheduleResponse> GetBusStopSchedule([WorkflowExpression] Func<string> stopId, [WorkflowExpression] Func<string> date = null)
        {
            SourceExpression.Validate(stopId, nameof(stopId), required: true);
            SourceExpression.Validate(date, nameof(date), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Bus.svc/json/jStopSchedule";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["StopID"] = SourceExpressionConverter.ConvertO(stopId);
                if (date != null)
                    callPayload.Queries["Date"] = SourceExpressionConverter.ConvertO(date);
                return callPayload;
            }

            return new ApiConnectionAction<GetBusStopScheduleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetBusStopsResponse> GetBusStops([WorkflowExpression] Func<double> lat = null, [WorkflowExpression] Func<double> lon = null, [WorkflowExpression] Func<double> radius = null)
        {
            SourceExpression.Validate(lat, nameof(lat), required: false);
            SourceExpression.Validate(lon, nameof(lon), required: false);
            SourceExpression.Validate(radius, nameof(radius), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Bus.svc/json/jStops";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["Lat"] = SourceExpressionConverter.ConvertO(lat);
                if (lon != null)
                    callPayload.Queries["Lon"] = SourceExpressionConverter.ConvertO(lon);
                if (radius != null)
                    callPayload.Queries["Radius"] = SourceExpressionConverter.ConvertO(radius);
                return callPayload;
            }

            return new ApiConnectionAction<GetBusStopsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetNextTrainsResponse> GetNextTrains([WorkflowExpression] Func<string> stationCodes)
        {
            SourceExpression.Validate(stationCodes, nameof(stationCodes), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/StationPrediction.svc/json/GetPrediction/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(stationCodes, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetNextTrainsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetRailLinesResponse> GetRailLines()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Rail.svc/json/jLines";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetRailLinesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetStationParkingResponse> GetStationParking([WorkflowExpression] Func<string> stationCode = null)
        {
            SourceExpression.Validate(stationCode, nameof(stationCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Rail.svc/json/jStationParking";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["StationCode"] = SourceExpressionConverter.ConvertO(stationCode);
                return callPayload;
            }

            return new ApiConnectionAction<GetStationParkingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetPathBetweenStationsResponse> GetPathBetweenStations([WorkflowExpression] Func<string> fromStationCode, [WorkflowExpression] Func<string> toStationCode)
        {
            SourceExpression.Validate(fromStationCode, nameof(fromStationCode), required: true);
            SourceExpression.Validate(toStationCode, nameof(toStationCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Rail.svc/json/jPath";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FromStationCode"] = SourceExpressionConverter.ConvertO(fromStationCode);
                callPayload.Queries["ToStationCode"] = SourceExpressionConverter.ConvertO(toStationCode);
                return callPayload;
            }

            return new ApiConnectionAction<GetPathBetweenStationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetJsonStationsResponse> GetJsonStations([WorkflowExpression] Func<string> lineCode = null)
        {
            SourceExpression.Validate(lineCode, nameof(lineCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Rail.svc/json/jStations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lineCode != null)
                    callPayload.Queries["LineCode"] = SourceExpressionConverter.ConvertO(lineCode);
                return callPayload;
            }

            return new ApiConnectionAction<GetJsonStationsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetStationEntrancesResponse> GetStationEntrances([WorkflowExpression] Func<double> lat = null, [WorkflowExpression] Func<double> lon = null, [WorkflowExpression] Func<double> radius = null)
        {
            SourceExpression.Validate(lat, nameof(lat), required: false);
            SourceExpression.Validate(lon, nameof(lon), required: false);
            SourceExpression.Validate(radius, nameof(radius), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Rail.svc/json/jStationEntrances";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (lat != null)
                    callPayload.Queries["Lat"] = SourceExpressionConverter.ConvertO(lat);
                if (lon != null)
                    callPayload.Queries["Lon"] = SourceExpressionConverter.ConvertO(lon);
                if (radius != null)
                    callPayload.Queries["Radius"] = SourceExpressionConverter.ConvertO(radius);
                return callPayload;
            }

            return new ApiConnectionAction<GetStationEntrancesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetStationInfoResponse> GetStationInfo([WorkflowExpression] Func<string> stationCode)
        {
            SourceExpression.Validate(stationCode, nameof(stationCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Rail.svc/json/jStationInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["StationCode"] = SourceExpressionConverter.ConvertO(stationCode);
                return callPayload;
            }

            return new ApiConnectionAction<GetStationInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetStationTimesResponse> GetStationTimes([WorkflowExpression] Func<string> stationCode)
        {
            SourceExpression.Validate(stationCode, nameof(stationCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Rail.svc/json/jStationTimes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["StationCode"] = SourceExpressionConverter.ConvertO(stationCode);
                return callPayload;
            }

            return new ApiConnectionAction<GetStationTimesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetStationToStationInfoResponse> GetStationToStationInfo([WorkflowExpression] Func<string> fromStationCode, [WorkflowExpression] Func<string> toStationCode)
        {
            SourceExpression.Validate(fromStationCode, nameof(fromStationCode), required: true);
            SourceExpression.Validate(toStationCode, nameof(toStationCode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Rail.svc/json/jSrcStationToDstStationInfo";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["FromStationCode"] = SourceExpressionConverter.ConvertO(fromStationCode);
                callPayload.Queries["ToStationCode"] = SourceExpressionConverter.ConvertO(toStationCode);
                return callPayload;
            }

            return new ApiConnectionAction<GetStationToStationInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetTrainPositionsResponse> GetTrainPositions()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/TrainPositions/TrainPositions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentType"] = Convert.ToString("json");
                return callPayload;
            }

            return new ApiConnectionAction<GetTrainPositionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetStandardRoutesResponse> GetStandardRoutes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/TrainPositions/StandardRoutes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentType"] = Convert.ToString("json");
                return callPayload;
            }

            return new ApiConnectionAction<GetStandardRoutesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetTrackCircuitsResponse> GetTrackCircuits()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/TrainPositions/TrackCircuits";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["contentType"] = Convert.ToString("json");
                return callPayload;
            }

            return new ApiConnectionAction<GetTrackCircuitsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetBusIncidentsResponse> GetBusIncidents([WorkflowExpression] Func<string> route = null)
        {
            SourceExpression.Validate(route, nameof(route), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Incidents.svc/json/BusIncidents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (route != null)
                    callPayload.Queries["Route"] = SourceExpressionConverter.ConvertO(route);
                return callPayload;
            }

            return new ApiConnectionAction<GetBusIncidentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetElevatorIncidentsResponse> GetElevatorIncidents([WorkflowExpression] Func<string> stationCode = null)
        {
            SourceExpression.Validate(stationCode, nameof(stationCode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Incidents.svc/json/ElevatorIncidents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (stationCode != null)
                    callPayload.Queries["StationCode"] = SourceExpressionConverter.ConvertO(stationCode);
                return callPayload;
            }

            return new ApiConnectionAction<GetElevatorIncidentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetRailIncidentsResponse> GetRailIncidents()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Incidents.svc/json/Incidents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetRailIncidentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetBusGtfsStatic()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gtfs/bus-gtfs-static.zip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetBusGtfsRtAlerts()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gtfs/bus-gtfsrt-alerts.pb";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetBusGtfsRtTripUpdates()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gtfs/bus-gtfsrt-tripupdates.pb";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetBusGtfsRtVehiclePositions()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gtfs/bus-gtfsrt-vehiclepositions.pb";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetRailGtfsStatic()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gtfs/rail-gtfs-static.zip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetRailGtfsRtAlerts()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gtfs/rail-gtfsrt-alerts.pb";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetRailGtfsRtTripUpdates()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gtfs/rail-gtfsrt-tripupdates.pb";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetRailGtfsRtVehiclePositions()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gtfs/rail-gtfsrt-vehiclepositions.pb";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetRailBusCombinedGtfsStatic()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gtfs/rail-bus-gtfs-static.zip";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class WmataTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetNextBusesResponse
    {
        public string StopName { get; set; }

        [JsonProperty("Predictions")]
        public GetNextBusesResponseBusPredictionsTypeItem[] BusPredictions { get; set; }
    }

    public class GetNextBusesResponseBusPredictionsTypeItem
    {
        [JsonProperty("DirectionNum")]
        public string DirectionNumber { get; set; }
        public string DirectionText { get; set; }

        [JsonProperty("Minutes")]
        public int MinutesToArrival { get; set; }
        public string RouteID { get; set; }
        public string TripID { get; set; }
        public string VehicleID { get; set; }
    }

    public class GetBusPositionsResponse
    {
        public GetBusPositionsResponseBusPositionsTypeItem[] BusPositions { get; set; }
    }

    public class GetBusPositionsResponseBusPositionsTypeItem
    {
        [JsonProperty("DateTime")]
        public string LastUpdate { get; set; }

        [JsonProperty("Deviation")]
        public double ScheduleDeviation { get; set; }

        [JsonProperty("DirectionText")]
        public string Direction { get; set; }

        [JsonProperty("Lat")]
        public double Latitude { get; set; }

        [JsonProperty("Lon")]
        public double Longitude { get; set; }
        public string RouteID { get; set; }
        public string TripEndTime { get; set; }
        public string TripHeadsign { get; set; }
        public string TripID { get; set; }
        public string VehicleID { get; set; }
    }

    public class GetRouteDetailsResponse
    {
        [JsonProperty("Direction0")]
        public GetRouteDetailsResponseDirection0DetailsType Direction0Details { get; set; }

        [JsonProperty("Direction1")]
        public GetRouteDetailsResponseDirection1DetailsType Direction1Details { get; set; }
    }

    public class GetRouteDetailsResponseDirection0DetailsType
    {
        [JsonProperty("DirectionNum")]
        public string DirectionNumber { get; set; }
        public string DirectionText { get; set; }

        [JsonProperty("Shape")]
        public GetRouteDetailsResponseDirection0DetailsTypeRouteShapeTypeItem[] RouteShape { get; set; }
        public GetRouteDetailsResponseDirection0DetailsTypeStopsTypeItem[] Stops { get; set; }
    }

    public class GetRouteDetailsResponseDirection0DetailsTypeRouteShapeTypeItem
    {
        [JsonProperty("Lat")]
        public double Latitude { get; set; }

        [JsonProperty("Lon")]
        public double Longitude { get; set; }

        [JsonProperty("SeqNum")]
        public int SequenceNumber { get; set; }
    }

    public class GetRouteDetailsResponseDirection0DetailsTypeStopsTypeItem
    {
        [JsonProperty("Lat")]
        public double StopLatitude { get; set; }

        [JsonProperty("Lon")]
        public double StopLongitude { get; set; }

        [JsonProperty("Name")]
        public string StopName { get; set; }
        public string StopID { get; set; }

        [JsonProperty("Routes")]
        public string[] RoutesAtStop { get; set; }
    }

    public class GetRouteDetailsResponseDirection1DetailsType
    {
        [JsonProperty("DirectionNum")]
        public string DirectionNumber { get; set; }
        public string DirectionText { get; set; }

        [JsonProperty("Shape")]
        public GetRouteDetailsResponseDirection1DetailsTypeRouteShapeTypeItem[] RouteShape { get; set; }
        public GetRouteDetailsResponseDirection1DetailsTypeStopsTypeItem[] Stops { get; set; }
    }

    public class GetRouteDetailsResponseDirection1DetailsTypeRouteShapeTypeItem
    {
        [JsonProperty("Lat")]
        public double Latitude { get; set; }

        [JsonProperty("Lon")]
        public double Longitude { get; set; }

        [JsonProperty("SeqNum")]
        public int SequenceNumber { get; set; }
    }

    public class GetRouteDetailsResponseDirection1DetailsTypeStopsTypeItem
    {
        [JsonProperty("Lat")]
        public double StopLatitude { get; set; }

        [JsonProperty("Lon")]
        public double StopLongitude { get; set; }

        [JsonProperty("Name")]
        public string StopName { get; set; }
        public string StopID { get; set; }

        [JsonProperty("Routes")]
        public string[] RoutesAtStop { get; set; }
    }

    public class GetBusRoutesResponse
    {
        [JsonProperty("Routes")]
        public GetBusRoutesResponseBusRoutesTypeItem[] BusRoutes { get; set; }
    }

    public class GetBusRoutesResponseBusRoutesTypeItem
    {
        public string RouteID { get; set; }

        [JsonProperty("Name")]
        public string RouteName { get; set; }
        public string LineDescription { get; set; }
    }

    public class GetBusRouteScheduleResponse
    {
        public GetBusRouteScheduleResponseRouteSchedulesTypeItem[] RouteSchedules { get; set; }
    }

    public class GetBusRouteScheduleResponseRouteSchedulesTypeItem
    {
        public string RouteID { get; set; }
        public string TripID { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public GetBusRouteScheduleResponseRouteSchedulesTypeItemStopsTypeItem[] Stops { get; set; }
    }

    public class GetBusRouteScheduleResponseRouteSchedulesTypeItemStopsTypeItem
    {
        public string StopID { get; set; }

        [JsonProperty("Name")]
        public string StopName { get; set; }

        [JsonProperty("Time")]
        public string ArrivalTime { get; set; }
    }

    public class GetBusStopScheduleResponse
    {
        public GetBusStopScheduleResponseStopSchedulesTypeItem[] StopSchedules { get; set; }
    }

    public class GetBusStopScheduleResponseStopSchedulesTypeItem
    {
        public string RouteID { get; set; }
        public string TripID { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }

    public class GetBusStopsResponse
    {
        public GetBusStopsResponseStopsTypeItem[] Stops { get; set; }
    }

    public class GetBusStopsResponseStopsTypeItem
    {
        public string StopID { get; set; }

        [JsonProperty("Name")]
        public string StopName { get; set; }

        [JsonProperty("Lat")]
        public double Latitude { get; set; }

        [JsonProperty("Lon")]
        public double Longitude { get; set; }
    }

    public class GetNextTrainsResponse
    {
        public GetNextTrainsResponseTrainsTypeItem[] Trains { get; set; }
    }

    public class GetNextTrainsResponseTrainsTypeItem
    {
        [JsonProperty("Car")]
        public string TrainCars { get; set; }
        public string Destination { get; set; }

        [JsonProperty("DestinationCode")]
        public string DestinationStationCode { get; set; }
        public string DestinationName { get; set; }

        [JsonProperty("Group")]
        public string TrackGroup { get; set; }

        [JsonProperty("Line")]
        public string LineAbbreviation { get; set; }

        [JsonProperty("LocationCode")]
        public string ArrivalStationCode { get; set; }

        [JsonProperty("LocationName")]
        public string ArrivalStationName { get; set; }

        [JsonProperty("Min")]
        public string MinutesToArrival { get; set; }
    }

    public class GetRailLinesResponse
    {
        [JsonProperty("Lines")]
        public GetRailLinesResponseRailLinesTypeItem[] RailLines { get; set; }
    }

    public class GetRailLinesResponseRailLinesTypeItem
    {
        public string DisplayName { get; set; }
        public string EndStationCode { get; set; }
        public string InternalDestination1 { get; set; }
        public string InternalDestination2 { get; set; }
        public string LineCode { get; set; }
        public string StartStationCode { get; set; }
    }

    public class GetStationParkingResponse
    {
        public GetStationParkingResponseStationsParkingTypeItem[] StationsParking { get; set; }
    }

    public class GetStationParkingResponseStationsParkingTypeItem
    {
        [JsonProperty("Code")]
        public string StationCode { get; set; }

        [JsonProperty("Notes")]
        public string ParkingNotes { get; set; }
        public GetStationParkingResponseStationsParkingTypeItemAllDayParkingType AllDayParking { get; set; }
        public GetStationParkingResponseStationsParkingTypeItemShortTermParkingType ShortTermParking { get; set; }
    }

    public class GetStationParkingResponseStationsParkingTypeItemAllDayParkingType
    {
        [JsonProperty("TotalCount")]
        public int TotalParkingSpots { get; set; }
        public double RiderCost { get; set; }
        public double NonRiderCost { get; set; }
    }

    public class GetStationParkingResponseStationsParkingTypeItemShortTermParkingType
    {
        [JsonProperty("TotalCount")]
        public int TotalShortTermParkingSpots { get; set; }

        [JsonProperty("Notes")]
        public string ShortTermParkingNotes { get; set; }
    }

    public class GetPathBetweenStationsResponse
    {
        [JsonProperty("Path")]
        public GetPathBetweenStationsResponsePathBetweenStationsTypeItem[] PathBetweenStations { get; set; }
    }

    public class GetPathBetweenStationsResponsePathBetweenStationsTypeItem
    {
        [JsonProperty("DistanceToPrev")]
        public int DistanceToPreviousStation { get; set; }
        public string LineCode { get; set; }

        [JsonProperty("SeqNum")]
        public int SequenceNumber { get; set; }
        public string StationCode { get; set; }
        public string StationName { get; set; }
    }

    public class GetJsonStationsResponse
    {
        public GetJsonStationsResponseStationsTypeItem[] Stations { get; set; }
    }

    public class GetJsonStationsResponseStationsTypeItem
    {
        public GetJsonStationsResponseStationsTypeItemAddressType Address { get; set; }

        [JsonProperty("Code")]
        public string StationCode { get; set; }

        [JsonProperty("Lat")]
        public double Latitude { get; set; }

        [JsonProperty("Lon")]
        public double Longitude { get; set; }

        [JsonProperty("Name")]
        public string StationName { get; set; }

        [JsonProperty("LineCode1")]
        public string PrimaryLineCode { get; set; }

        [JsonProperty("LineCode2")]
        public string SecondaryLineCode { get; set; }

        [JsonProperty("LineCode3")]
        public string TertiaryLineCode { get; set; }

        [JsonProperty("LineCode4")]
        public string QuaternaryLineCode { get; set; }

        [JsonProperty("StationTogether1")]
        public string ConnectedStationCode1 { get; set; }

        [JsonProperty("StationTogether2")]
        public string ConnectedStationCode2 { get; set; }
    }

    public class GetJsonStationsResponseStationsTypeItemAddressType
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }

        [JsonProperty("Zip")]
        public string ZipCode { get; set; }
    }

    public class GetStationEntrancesResponse
    {
        [JsonProperty("Entrances")]
        public GetStationEntrancesResponseStationEntrancesTypeItem[] StationEntrances { get; set; }
    }

    public class GetStationEntrancesResponseStationEntrancesTypeItem
    {
        [JsonProperty("Description")]
        public string EntranceDescription { get; set; }

        [JsonProperty("Lat")]
        public double Latitude { get; set; }

        [JsonProperty("Lon")]
        public double Longitude { get; set; }

        [JsonProperty("Name")]
        public string EntranceName { get; set; }
        public string StationCode1 { get; set; }
        public string StationCode2 { get; set; }
    }

    public class GetStationInfoResponse
    {
        [JsonProperty("Address")]
        public GetStationInfoResponseStationAddressType StationAddress { get; set; }

        [JsonProperty("Code")]
        public string StationCode { get; set; }

        [JsonProperty("Lat")]
        public double Latitude { get; set; }

        [JsonProperty("Lon")]
        public double Longitude { get; set; }

        [JsonProperty("Name")]
        public string StationName { get; set; }

        [JsonProperty("LineCode1")]
        public string PrimaryLineCode { get; set; }

        [JsonProperty("LineCode2")]
        public string SecondaryLineCode { get; set; }

        [JsonProperty("LineCode3")]
        public string TertiaryLineCode { get; set; }

        [JsonProperty("StationTogether1")]
        public string ConnectedStationCode1 { get; set; }

        [JsonProperty("StationTogether2")]
        public string ConnectedStationCode2 { get; set; }
    }

    public class GetStationInfoResponseStationAddressType
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }

        [JsonProperty("Zip")]
        public string ZipCode { get; set; }
    }

    public class GetStationTimesResponse
    {
        public GetStationTimesResponseStationTimesTypeItem[] StationTimes { get; set; }
    }

    public class GetStationTimesResponseStationTimesTypeItem
    {
        [JsonProperty("Code")]
        public string StationCode { get; set; }
        public string StationName { get; set; }
        public DaySchedule Monday { get; set; }
        public DaySchedule Tuesday { get; set; }
        public DaySchedule Wednesday { get; set; }
        public DaySchedule Thursday { get; set; }
        public DaySchedule Friday { get; set; }
        public DaySchedule Saturday { get; set; }
        public DaySchedule Sunday { get; set; }
    }

    public class DaySchedule
    {
        public string OpeningTime { get; set; }
        public DayScheduleFirstTrainsTypeItem[] FirstTrains { get; set; }
        public DayScheduleLastTrainsTypeItem[] LastTrains { get; set; }
    }

    public class DayScheduleFirstTrainsTypeItem
    {
        [JsonProperty("Time")]
        public string DepartureTime { get; set; }
        public string DestinationStation { get; set; }
    }

    public class DayScheduleLastTrainsTypeItem
    {
        [JsonProperty("Time")]
        public string DepartureTime { get; set; }
        public string DestinationStation { get; set; }
    }

    public class GetStationToStationInfoResponse
    {
        [JsonProperty("StationToStationInfos")]
        public GetStationToStationInfoResponseStationToStationInfoTypeItem[] StationToStationInfo { get; set; }
    }

    public class GetStationToStationInfoResponseStationToStationInfoTypeItem
    {
        [JsonProperty("CompositeMiles")]
        public double DistanceInMiles { get; set; }
        public string DestinationStation { get; set; }
        public GetStationToStationInfoResponseStationToStationInfoTypeItemRailFareType RailFare { get; set; }

        [JsonProperty("RailTime")]
        public int TravelTime { get; set; }
        public string SourceStation { get; set; }
    }

    public class GetStationToStationInfoResponseStationToStationInfoTypeItemRailFareType
    {
        [JsonProperty("PeakTime")]
        public double PeakFare { get; set; }

        [JsonProperty("OffPeakTime")]
        public double OffPeakFare { get; set; }

        [JsonProperty("SeniorDisabled")]
        public double SeniorDisabledFare { get; set; }
    }

    public class GetTrainPositionsResponse
    {
        public GetTrainPositionsResponseTrainPositionsTypeItem[] TrainPositions { get; set; }
    }

    public class GetTrainPositionsResponseTrainPositionsTypeItem
    {
        [JsonProperty("TrainId")]
        public string TrainID { get; set; }
        public string TrainNumber { get; set; }
        public int CarCount { get; set; }

        [JsonProperty("DirectionNum")]
        public int DirectionNumber { get; set; }

        [JsonProperty("CircuitId")]
        public int CircuitID { get; set; }
        public string DestinationStationCode { get; set; }
        public string LineCode { get; set; }
        public int SecondsAtLocation { get; set; }
        public string ServiceType { get; set; }
    }

    public class GetStandardRoutesResponse
    {
        public GetStandardRoutesResponseStandardRoutesTypeItem[] StandardRoutes { get; set; }
    }

    public class GetStandardRoutesResponseStandardRoutesTypeItem
    {
        public string LineCode { get; set; }
        public GetStandardRoutesResponseStandardRoutesTypeItemTrackCircuitsTypeItem[] TrackCircuits { get; set; }
    }

    public class GetStandardRoutesResponseStandardRoutesTypeItemTrackCircuitsTypeItem
    {
        [JsonProperty("CircuitId")]
        public int CircuitID { get; set; }

        [JsonProperty("SeqNum")]
        public int SequenceNumber { get; set; }
        public string StationCode { get; set; }
    }

    public class GetTrackCircuitsResponse
    {
        public GetTrackCircuitsResponseTrackCircuitsTypeItem[] TrackCircuits { get; set; }
    }

    public class GetTrackCircuitsResponseTrackCircuitsTypeItem
    {
        [JsonProperty("CircuitId")]
        public int CircuitID { get; set; }

        [JsonProperty("Track")]
        public int TrackNumber { get; set; }
        public GetTrackCircuitsResponseTrackCircuitsTypeItemNeighborsTypeItem[] Neighbors { get; set; }
    }

    public class GetTrackCircuitsResponseTrackCircuitsTypeItemNeighborsTypeItem
    {
        public string NeighborType { get; set; }

        [JsonProperty("CircuitIds")]
        public int[] CircuitIDs { get; set; }
    }

    public class GetBusIncidentsResponse
    {
        public GetBusIncidentsResponseBusIncidentsTypeItem[] BusIncidents { get; set; }
    }

    public class GetBusIncidentsResponseBusIncidentsTypeItem
    {
        public string DateUpdated { get; set; }

        [JsonProperty("Description")]
        public string IncidentDescription { get; set; }
        public string IncidentID { get; set; }
        public string IncidentType { get; set; }
        public string[] RoutesAffected { get; set; }
    }

    public class GetElevatorIncidentsResponse
    {
        public GetElevatorIncidentsResponseElevatorIncidentsTypeItem[] ElevatorIncidents { get; set; }
    }

    public class GetElevatorIncidentsResponseElevatorIncidentsTypeItem
    {
        [JsonProperty("DateOutOfServ")]
        public string DateOutOfService { get; set; }
        public string DateUpdated { get; set; }
        public string EstimatedReturnToService { get; set; }
        public string LocationDescription { get; set; }
        public string StationCode { get; set; }
        public string StationName { get; set; }
        public string SymptomDescription { get; set; }
        public string UnitName { get; set; }
        public string UnitType { get; set; }
    }

    public class GetRailIncidentsResponse
    {
        [JsonProperty("Incidents")]
        public GetRailIncidentsResponseRailIncidentsTypeItem[] RailIncidents { get; set; }
    }

    public class GetRailIncidentsResponseRailIncidentsTypeItem
    {
        public string DateUpdated { get; set; }

        [JsonProperty("Description")]
        public string IncidentDescription { get; set; }
        public string IncidentID { get; set; }
        public string IncidentType { get; set; }
        public string LinesAffected { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wmata;

    public partial class WorkflowManagedActions
    {
        public WmataActions Wmata(string connectionId) => new WmataActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WmataTriggers Wmata(string connectionId) => new WmataTriggers(connectionId);
    }
}