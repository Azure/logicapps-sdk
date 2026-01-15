//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Wmata
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WmataActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetNextBusesResponse> GetNextBuses(Expression<Func<string>> stopID)
        {
            var apiCallPath = "/NextBusService.svc/json/jPredictions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["StopID"] = ExpressionConverter.Convert(stopID);
            return new ApiConnectionAction<GetNextBusesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetBusPositionsResponse> GetBusPositions(Expression<Func<string>> routeID = null, Expression<Func<double>> lat = null, Expression<Func<double>> lon = null, Expression<Func<double>> radius = null)
        {
            var apiCallPath = "/Bus.svc/json/jBusPositions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (routeID != null)
                callPayload.Queries["RouteID"] = ExpressionConverter.Convert(routeID);
            if (lat != null)
                callPayload.Queries["Lat"] = ExpressionConverter.Convert(lat);
            if (lon != null)
                callPayload.Queries["Lon"] = ExpressionConverter.Convert(lon);
            if (radius != null)
                callPayload.Queries["Radius"] = ExpressionConverter.Convert(radius);
            return new ApiConnectionAction<GetBusPositionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetRouteDetailsResponse> GetRouteDetails(Expression<Func<string>> routeID, Expression<Func<string>> date = null)
        {
            var apiCallPath = "/Bus.svc/json/jRouteDetails";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["RouteID"] = ExpressionConverter.Convert(routeID);
            if (date != null)
                callPayload.Queries["Date"] = ExpressionConverter.Convert(date);
            return new ApiConnectionAction<GetRouteDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetBusRoutesResponse> GetBusRoutes()
        {
            var apiCallPath = "/Bus.svc/json/jRoutes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetBusRoutesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetBusRouteScheduleResponse> GetBusRouteSchedule(Expression<Func<string>> routeID, Expression<Func<string>> date = null)
        {
            var apiCallPath = "/Bus.svc/json/jRouteSchedule";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["RouteID"] = ExpressionConverter.Convert(routeID);
            if (date != null)
                callPayload.Queries["Date"] = ExpressionConverter.Convert(date);
            return new ApiConnectionAction<GetBusRouteScheduleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetBusStopScheduleResponse> GetBusStopSchedule(Expression<Func<string>> stopID, Expression<Func<string>> date = null)
        {
            var apiCallPath = "/Bus.svc/json/jStopSchedule";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["StopID"] = ExpressionConverter.Convert(stopID);
            if (date != null)
                callPayload.Queries["Date"] = ExpressionConverter.Convert(date);
            return new ApiConnectionAction<GetBusStopScheduleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetBusStopsResponse> GetBusStops(Expression<Func<double>> lat = null, Expression<Func<double>> lon = null, Expression<Func<double>> radius = null)
        {
            var apiCallPath = "/Bus.svc/json/jStops";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lat != null)
                callPayload.Queries["Lat"] = ExpressionConverter.Convert(lat);
            if (lon != null)
                callPayload.Queries["Lon"] = ExpressionConverter.Convert(lon);
            if (radius != null)
                callPayload.Queries["Radius"] = ExpressionConverter.Convert(radius);
            return new ApiConnectionAction<GetBusStopsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetNextTrainsResponse> GetNextTrains(Expression<Func<string>> stationCodes)
        {
            var apiCallPath = String.Format("/StationPrediction.svc/json/GetPrediction/{0}", ExpressionConverter.ConvertWithUrlEncoding(stationCodes, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetNextTrainsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetRailLinesResponse> GetRailLines()
        {
            var apiCallPath = "/Rail.svc/json/jLines";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRailLinesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetStationParkingResponse> GetStationParking(Expression<Func<string>> stationCode = null)
        {
            var apiCallPath = "/Rail.svc/json/jStationParking";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (stationCode != null)
                callPayload.Queries["StationCode"] = ExpressionConverter.Convert(stationCode);
            return new ApiConnectionAction<GetStationParkingResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetPathBetweenStationsResponse> GetPathBetweenStations(Expression<Func<string>> fromStationCode, Expression<Func<string>> toStationCode)
        {
            var apiCallPath = "/Rail.svc/json/jPath";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FromStationCode"] = ExpressionConverter.Convert(fromStationCode);
            callPayload.Queries["ToStationCode"] = ExpressionConverter.Convert(toStationCode);
            return new ApiConnectionAction<GetPathBetweenStationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetJsonStationsResponse> GetJsonStations(Expression<Func<string>> lineCode = null)
        {
            var apiCallPath = "/Rail.svc/json/jStations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lineCode != null)
                callPayload.Queries["LineCode"] = ExpressionConverter.Convert(lineCode);
            return new ApiConnectionAction<GetJsonStationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetStationEntrancesResponse> GetStationEntrances(Expression<Func<double>> lat = null, Expression<Func<double>> lon = null, Expression<Func<double>> radius = null)
        {
            var apiCallPath = "/Rail.svc/json/jStationEntrances";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (lat != null)
                callPayload.Queries["Lat"] = ExpressionConverter.Convert(lat);
            if (lon != null)
                callPayload.Queries["Lon"] = ExpressionConverter.Convert(lon);
            if (radius != null)
                callPayload.Queries["Radius"] = ExpressionConverter.Convert(radius);
            return new ApiConnectionAction<GetStationEntrancesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetStationInfoResponse> GetStationInfo(Expression<Func<string>> stationCode)
        {
            var apiCallPath = "/Rail.svc/json/jStationInfo";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["StationCode"] = ExpressionConverter.Convert(stationCode);
            return new ApiConnectionAction<GetStationInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetStationTimesResponse> GetStationTimes(Expression<Func<string>> stationCode)
        {
            var apiCallPath = "/Rail.svc/json/jStationTimes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["StationCode"] = ExpressionConverter.Convert(stationCode);
            return new ApiConnectionAction<GetStationTimesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetStationToStationInfoResponse> GetStationToStationInfo(Expression<Func<string>> fromStationCode, Expression<Func<string>> toStationCode)
        {
            var apiCallPath = "/Rail.svc/json/jSrcStationToDstStationInfo";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["FromStationCode"] = ExpressionConverter.Convert(fromStationCode);
            callPayload.Queries["ToStationCode"] = ExpressionConverter.Convert(toStationCode);
            return new ApiConnectionAction<GetStationToStationInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetTrainPositionsResponse> GetTrainPositions()
        {
            var apiCallPath = "/TrainPositions/TrainPositions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentType"] = Convert.ToString("json");
            return new ApiConnectionAction<GetTrainPositionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetStandardRoutesResponse> GetStandardRoutes()
        {
            var apiCallPath = "/TrainPositions/StandardRoutes";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentType"] = Convert.ToString("json");
            return new ApiConnectionAction<GetStandardRoutesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetTrackCircuitsResponse> GetTrackCircuits()
        {
            var apiCallPath = "/TrainPositions/TrackCircuits";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["contentType"] = Convert.ToString("json");
            return new ApiConnectionAction<GetTrackCircuitsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetBusIncidentsResponse> GetBusIncidents(Expression<Func<string>> route = null)
        {
            var apiCallPath = "/Incidents.svc/json/BusIncidents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (route != null)
                callPayload.Queries["Route"] = ExpressionConverter.Convert(route);
            return new ApiConnectionAction<GetBusIncidentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetElevatorIncidentsResponse> GetElevatorIncidents(Expression<Func<string>> stationCode = null)
        {
            var apiCallPath = "/Incidents.svc/json/ElevatorIncidents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (stationCode != null)
                callPayload.Queries["StationCode"] = ExpressionConverter.Convert(stationCode);
            return new ApiConnectionAction<GetElevatorIncidentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<GetRailIncidentsResponse> GetRailIncidents()
        {
            var apiCallPath = "/Incidents.svc/json/Incidents";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRailIncidentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetBusGtfsStatic()
        {
            var apiCallPath = "/gtfs/bus-gtfs-static.zip";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetBusGtfsRtAlerts()
        {
            var apiCallPath = "/gtfs/bus-gtfsrt-alerts.pb";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetBusGtfsRtTripUpdates()
        {
            var apiCallPath = "/gtfs/bus-gtfsrt-tripupdates.pb";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetBusGtfsRtVehiclePositions()
        {
            var apiCallPath = "/gtfs/bus-gtfsrt-vehiclepositions.pb";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetRailGtfsStatic()
        {
            var apiCallPath = "/gtfs/rail-gtfs-static.zip";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetRailGtfsRtAlerts()
        {
            var apiCallPath = "/gtfs/rail-gtfsrt-alerts.pb";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetRailGtfsRtTripUpdates()
        {
            var apiCallPath = "/gtfs/rail-gtfsrt-tripupdates.pb";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetRailGtfsRtVehiclePositions()
        {
            var apiCallPath = "/gtfs/rail-gtfsrt-vehiclepositions.pb";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wmata")]
        public IBodyWorkflowAction<string> GetRailBusCombinedGtfsStatic()
        {
            var apiCallPath = "/gtfs/rail-bus-gtfs-static.zip";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Wmata;

    public partial class WorkflowManagedActions
    {
        public WmataActions Wmata(string connectionId) => new WmataActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WmataTriggers Wmata(string connectionId) => new WmataTriggers(connectionId);
    }
}