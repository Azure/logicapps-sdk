//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mergeshuttleservice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MergeshuttleserviceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mergeshuttleservice")]
        public IBodyWorkflowAction<GetFixedRouteResponseItem[]> GetFixedRoute()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/shuttle/fixedroute";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetFixedRouteResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mergeshuttleservice")]
        public IWorkflowAction PostFixedRoute([WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/shuttle/fixedrouteschedule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class MergeshuttleserviceTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetFixedRouteResponseItem
    {
        [JsonProperty("routeMasterId")]
        public int RouteMasterId { get; set; }

        [JsonProperty("routeMasterName")]
        public string RouteMasterName { get; set; }

        [JsonProperty("tripSchedules")]
        public GetFixedRouteResponseItemTripSchedulesTypeItem[] TripSchedules { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }
    }

    public class GetFixedRouteResponseItemTripSchedulesTypeItem
    {
        [JsonProperty("stops")]
        public GetFixedRouteResponseItemTripSchedulesTypeItemStopsTypeItem[] Stops { get; set; }

        [JsonProperty("tripDetail")]
        public GetFixedRouteResponseItemTripSchedulesTypeItemTripDetailTypeItem[] TripDetail { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("tripFrequency")]
        public string TripFrequency { get; set; }
    }

    public class GetFixedRouteResponseItemTripSchedulesTypeItemStopsTypeItem
    {
        [JsonProperty("feedstoreBuildingId")]
        public int FeedstoreBuildingId { get; set; }

        [JsonProperty("refBuildingId")]
        public int RefBuildingId { get; set; }

        [JsonProperty("refBuildingName")]
        public string RefBuildingName { get; set; }

        [JsonProperty("stopName")]
        public string StopName { get; set; }

        [JsonProperty("isPickup")]
        public bool IsPickup { get; set; }

        [JsonProperty("isDropOff")]
        public bool IsDropOff { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
    }

    public class GetFixedRouteResponseItemTripSchedulesTypeItemTripDetailTypeItem
    {
        [JsonProperty("vehicleName")]
        public string VehicleName { get; set; }

        [JsonProperty("stopSchedules")]
        public GetFixedRouteResponseItemTripSchedulesTypeItemTripDetailTypeItemStopSchedulesTypeItem[] StopSchedules { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
    }

    public class GetFixedRouteResponseItemTripSchedulesTypeItemTripDetailTypeItemStopSchedulesTypeItem
    {
        [JsonProperty("stopName")]
        public string StopName { get; set; }

        [JsonProperty("stopTime")]
        public string StopTime { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("routeMasterName")]
        public string RouteMasterName { get; set; }

        [JsonProperty("tripSchedules")]
        public bodyInputItemTripSchedulesTypeItem[] TripSchedules { get; set; }

        [JsonProperty("routeMasterId")]
        public int RouteMasterId { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }
    }

    public class bodyInputItemTripSchedulesTypeItem
    {
        [JsonProperty("stops")]
        public bodyInputItemTripSchedulesTypeItemStopsTypeItem[] Stops { get; set; }

        [JsonProperty("tripDetail")]
        public bodyInputItemTripSchedulesTypeItemTripDetailTypeItem[] TripDetail { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }
    }

    public class bodyInputItemTripSchedulesTypeItemStopsTypeItem
    {
        [JsonProperty("feedstoreBuildingId")]
        public int FeedstoreBuildingId { get; set; }

        [JsonProperty("stopName")]
        public string StopName { get; set; }

        [JsonProperty("isPickup")]
        public bool IsPickup { get; set; }

        [JsonProperty("isDropOff")]
        public bool IsDropOff { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }

        [JsonProperty("refBuildingName")]
        public string RefBuildingName { get; set; }

        [JsonProperty("refBuildingId")]
        public int RefBuildingId { get; set; }
    }

    public class bodyInputItemTripSchedulesTypeItemTripDetailTypeItem
    {
        [JsonProperty("stopSchedules")]
        public bodyInputItemTripSchedulesTypeItemTripDetailTypeItemStopSchedulesTypeItem[] StopSchedules { get; set; }

        [JsonProperty("vehicleName")]
        public string VehicleName { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
    }

    public class bodyInputItemTripSchedulesTypeItemTripDetailTypeItemStopSchedulesTypeItem
    {
        [JsonProperty("stopName")]
        public string StopName { get; set; }

        [JsonProperty("stopTime")]
        public string StopTime { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mergeshuttleservice;

    public partial class WorkflowManagedActions
    {
        public MergeshuttleserviceActions Mergeshuttleservice(string connectionId) => new MergeshuttleserviceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MergeshuttleserviceTriggers Mergeshuttleservice(string connectionId) => new MergeshuttleserviceTriggers(connectionId);
    }
}