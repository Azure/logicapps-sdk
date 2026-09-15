//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Finnishrailwaytrafip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinnishrailwaytrafipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finnishrailwaytrafip")]
        public IBodyWorkflowAction<GetStationsResponseItem[]> GetStations()
        {
            var apiCallPath = "/metadata/stations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetStationsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finnishrailwaytrafip")]
        public IBodyWorkflowAction<GetSchedulesResponseItem[]> GetSchedules(Expression<Func<string>> departureStation, Expression<Func<string>> arrivalStation, Expression<Func<string>> departureDate = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/live-trains/station/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(departureStation, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(arrivalStation, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (departureDate != null)
                callPayload.Queries["departure_date"] = CSharpExpressionConverter.ConvertO(departureDate);
            return new ApiConnectionAction<GetSchedulesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finnishrailwaytrafip")]
        public IBodyWorkflowAction<GetArrivalsAndDeparturesResponseItem[]> GetArrivalsAndDepartures(Expression<Func<string>> trainStation, Expression<Func<int>> arrivingTrains = null, Expression<Func<int>> departingTrains = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/live-trains/station/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(trainStation, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (arrivingTrains != null)
                callPayload.Queries["arriving_trains"] = CSharpExpressionConverter.ConvertO(arrivingTrains);
            if (departingTrains != null)
                callPayload.Queries["departing_trains"] = CSharpExpressionConverter.ConvertO(departingTrains);
            return new ApiConnectionAction<GetArrivalsAndDeparturesResponseItem[]>(callPayload);
        }
    }

    public class FinnishrailwaytrafipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetStationsResponseItem
    {
        [JsonProperty("passengerTraffic")]
        public bool PassengerTraffic { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("stationName")]
        public string StationName { get; set; }

        [JsonProperty("stationShortCode")]
        public string StationShortCode { get; set; }

        [JsonProperty("stationUICCode")]
        public int StationUICCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }
    }

    public class GetSchedulesResponseItem
    {
        [JsonProperty("trainNumber")]
        public int TrainNumber { get; set; }

        [JsonProperty("departureDate")]
        public string DepartureDate { get; set; }

        [JsonProperty("operatorUICCode")]
        public int OperatorUICCode { get; set; }

        [JsonProperty("operatorShortCode")]
        public string OperatorShortCode { get; set; }

        [JsonProperty("trainType")]
        public string TrainType { get; set; }

        [JsonProperty("trainCategory")]
        public string TrainCategory { get; set; }

        [JsonProperty("commuterLineID")]
        public string CommuterLineID { get; set; }

        [JsonProperty("runningCurrently")]
        public bool RunningCurrently { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("timetableType")]
        public string TimetableType { get; set; }

        [JsonProperty("timetableAcceptanceDate")]
        public string TimetableAcceptanceDate { get; set; }

        [JsonProperty("timeTableRows")]
        public GetSchedulesResponseItemTimeTableRowsTypeItem[] TimeTableRows { get; set; }
    }

    public class GetSchedulesResponseItemTimeTableRowsTypeItem
    {
        [JsonProperty("stationShortCode")]
        public string StationShortCode { get; set; }

        [JsonProperty("stationUICCode")]
        public int StationUICCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("trainStopping")]
        public bool TrainStopping { get; set; }

        [JsonProperty("commercialStop")]
        public bool CommercialStop { get; set; }

        [JsonProperty("commercialTrack")]
        public string CommercialTrack { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("scheduledTime")]
        public string ScheduledTime { get; set; }
    }

    public class GetArrivalsAndDeparturesResponseItem
    {
        [JsonProperty("trainNumber")]
        public int TrainNumber { get; set; }

        [JsonProperty("departureDate")]
        public string DepartureDate { get; set; }

        [JsonProperty("operatorUICCode")]
        public int OperatorUICCode { get; set; }

        [JsonProperty("operatorShortCode")]
        public string OperatorShortCode { get; set; }

        [JsonProperty("trainType")]
        public string TrainType { get; set; }

        [JsonProperty("trainCategory")]
        public string TrainCategory { get; set; }

        [JsonProperty("commuterLineID")]
        public string CommuterLineID { get; set; }

        [JsonProperty("runningCurrently")]
        public bool RunningCurrently { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("timetableType")]
        public string TimetableType { get; set; }

        [JsonProperty("timetableAcceptanceDate")]
        public string TimetableAcceptanceDate { get; set; }

        [JsonProperty("timeTableRows")]
        public GetArrivalsAndDeparturesResponseItemTimeTableRowsTypeItem[] TimeTableRows { get; set; }
    }

    public class GetArrivalsAndDeparturesResponseItemTimeTableRowsTypeItem
    {
        [JsonProperty("stationShortCode")]
        public string StationShortCode { get; set; }

        [JsonProperty("stationUICCode")]
        public int StationUICCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("trainStopping")]
        public bool TrainStopping { get; set; }

        [JsonProperty("commercialStop")]
        public bool CommercialStop { get; set; }

        [JsonProperty("commercialTrack")]
        public string CommercialTrack { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("scheduledTime")]
        public string ScheduledTime { get; set; }

        [JsonProperty("actualTime")]
        public string ActualTime { get; set; }

        [JsonProperty("differenceInMinutes")]
        public int DifferenceInMinutes { get; set; }

        [JsonProperty("causes")]
        public GetArrivalsAndDeparturesResponseItemTimeTableRowsTypeItemCausesTypeItem[] Causes { get; set; }

        [JsonProperty("trainReady")]
        public GetArrivalsAndDeparturesResponseItemTimeTableRowsTypeItemTrainReadyType TrainReady { get; set; }

        [JsonProperty("liveEstimateTime")]
        public string LiveEstimateTime { get; set; }

        [JsonProperty("estimateSource")]
        public string EstimateSource { get; set; }
    }

    public class GetArrivalsAndDeparturesResponseItemTimeTableRowsTypeItemCausesTypeItem
    {
        [JsonProperty("categoryCode")]
        public string CategoryCode { get; set; }

        [JsonProperty("detailedCategoryCode")]
        public string DetailedCategoryCode { get; set; }

        [JsonProperty("categoryCodeId")]
        public int CategoryCodeId { get; set; }

        [JsonProperty("detailedCategoryCodeId")]
        public int DetailedCategoryCodeId { get; set; }

        [JsonProperty("thirdCategoryCode")]
        public string ThirdCategoryCode { get; set; }

        [JsonProperty("thirdCategoryCodeId")]
        public int ThirdCategoryCodeId { get; set; }
    }

    public class GetArrivalsAndDeparturesResponseItemTimeTableRowsTypeItemTrainReadyType
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("accepted")]
        public bool Accepted { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Finnishrailwaytrafip;

    public partial class WorkflowManagedActions
    {
        public FinnishrailwaytrafipActions Finnishrailwaytrafip(string connectionId) => new FinnishrailwaytrafipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FinnishrailwaytrafipTriggers Finnishrailwaytrafip(string connectionId) => new FinnishrailwaytrafipTriggers(connectionId);
    }
}