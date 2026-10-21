//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Finnishrailwaytrafip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
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
            var __workflow_departureStation = WorkflowExpression.Compile(departureStation, nameof(departureStation), required: true);
            var __workflow_arrivalStation = WorkflowExpression.Compile(arrivalStation, nameof(arrivalStation), required: true);
            var __workflow_departureDate = WorkflowExpression.Compile(departureDate, nameof(departureDate), required: false);
            return new DeferredBodyAction<GetSchedulesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/live-trains/station/{0}/{1}", __workflow_departureStation.WithUrlEncoding(1), __workflow_arrivalStation.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_departureDate != null)
                    callPayload.Queries["departure_date"] = ExpressionConverter.Convert(__workflow_departureDate);
                return new ApiConnectionAction<GetSchedulesResponseItem[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finnishrailwaytrafip")]
        public IBodyWorkflowAction<GetArrivalsAndDeparturesResponseItem[]> GetArrivalsAndDepartures(Expression<Func<string>> trainStation, Expression<Func<int>> arrivingTrains = null, Expression<Func<int>> departingTrains = null)
        {
            var __workflow_trainStation = WorkflowExpression.Compile(trainStation, nameof(trainStation), required: true);
            var __workflow_arrivingTrains = WorkflowExpression.Compile(arrivingTrains, nameof(arrivingTrains), required: false);
            var __workflow_departingTrains = WorkflowExpression.Compile(departingTrains, nameof(departingTrains), required: false);
            return new DeferredBodyAction<GetArrivalsAndDeparturesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/live-trains/station/{0}", __workflow_trainStation.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_arrivingTrains != null)
                    callPayload.Queries["arriving_trains"] = ExpressionConverter.Convert(__workflow_arrivingTrains);
                if (__workflow_departingTrains != null)
                    callPayload.Queries["departing_trains"] = ExpressionConverter.Convert(__workflow_departingTrains);
                return new ApiConnectionAction<GetArrivalsAndDeparturesResponseItem[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
