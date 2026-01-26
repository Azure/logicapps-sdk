//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Actsoft
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ActsoftActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIModelsCustomListsCustomListDefinitionListItemApiModel[]> CustomListControllerGet()
        {
            var apiCallPath = "/custom-lists/v1/custom-lists/definitions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Version"] = Convert.ToString(15);
            return new ApiConnectionAction<CustomerAPIModelsCustomListsCustomListDefinitionListItemApiModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIInfrastructureErrorHandlingResponseError[]> EventControllerDelete(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/events/v1/definitions/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Version"] = Convert.ToString(15);
            return new ApiConnectionAction<CustomerAPIInfrastructureErrorHandlingResponseError[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIInfrastructureErrorHandlingResponseError[]> EventControllerRemoveEventDataFeedSubscription(Expression<Func<string>> subscriptionId)
        {
            var apiCallPath = "/events/v1/subscribe";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["subscriptionId"] = ExpressionConverter.Convert(subscriptionId);
            callPayload.Headers["X-API-Version"] = Convert.ToString(15);
            return new ApiConnectionAction<CustomerAPIInfrastructureErrorHandlingResponseError[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[]> EventControllerGetSubscriptions()
        {
            var apiCallPath = "/events/v1/subscriptions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Version"] = Convert.ToString(15);
            return new ApiConnectionAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<JToken> EventControllerSubscribeCallback(Expression<Func<string>> eventId = null, Expression<Func<int>> eventEventType = null, Expression<Func<string>> eventEventCode = null, Expression<Func<string>> eventEventTime = null, Expression<Func<string>> eventDeviceId = null, Expression<Func<int>> eventDeviceType = null, Expression<Func<int>> eventUserId = null, Expression<Func<int>> eventVehicleId = null, Expression<Func<bool>> eventUserLinkedToVehicle = null, Expression<Func<double>> eventLat = null, Expression<Func<double>> eventLon = null, Expression<Func<string>> eventCustomEventDefinitionId = null)
        {
            var apiCallPath = "/events/v1/subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Version"] = Convert.ToString(15);
            var @event = new JObject();
            var @eventpropCount = 0;
            if (eventId != null)
            {
                @event["Id"] = ExpressionConverter.ConvertO(eventId);
                @eventpropCount++;
            }

            if (eventEventType != null)
            {
                @event["EventType"] = ExpressionConverter.ConvertO(eventEventType);
                @eventpropCount++;
            }

            if (eventEventCode != null)
            {
                @event["EventCode"] = ExpressionConverter.ConvertO(eventEventCode);
                @eventpropCount++;
            }

            if (eventEventTime != null)
            {
                @event["EventTime"] = ExpressionConverter.ConvertO(eventEventTime);
                @eventpropCount++;
            }

            if (eventDeviceId != null)
            {
                @event["DeviceId"] = ExpressionConverter.ConvertO(eventDeviceId);
                @eventpropCount++;
            }

            if (eventDeviceType != null)
            {
                @event["DeviceType"] = ExpressionConverter.ConvertO(eventDeviceType);
                @eventpropCount++;
            }

            if (eventUserId != null)
            {
                @event["UserId"] = ExpressionConverter.ConvertO(eventUserId);
                @eventpropCount++;
            }

            if (eventVehicleId != null)
            {
                @event["VehicleId"] = ExpressionConverter.ConvertO(eventVehicleId);
                @eventpropCount++;
            }

            if (eventUserLinkedToVehicle != null)
            {
                @event["UserLinkedToVehicle"] = ExpressionConverter.ConvertO(eventUserLinkedToVehicle);
                @eventpropCount++;
            }

            if (eventLat != null)
            {
                @event["Lat"] = ExpressionConverter.ConvertO(eventLat);
                @eventpropCount++;
            }

            if (eventLon != null)
            {
                @event["Lon"] = ExpressionConverter.ConvertO(eventLon);
                @eventpropCount++;
            }

            if (eventCustomEventDefinitionId != null)
            {
                @event["CustomEventDefinitionId"] = ExpressionConverter.ConvertO(eventCustomEventDefinitionId);
                @eventpropCount++;
            }

            var EventParamsObject = new JObject();
            var EventParamsObjectpropCount = 0;
            if (EventParamsObjectpropCount > 0)
            {
                @event["EventParams"] = EventParamsObject;
                @eventpropCount++;
            }

            if (@eventpropCount > 0)
            {
                callPayload.Body = @event;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IWorkflowAction EventControllerResetSubscriptionHealthStatus(Expression<Func<int>> subscriptionId)
        {
            var apiCallPath = String.Format("/events/v1/subscription/{0}/reset", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Version"] = Convert.ToString(15);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIInfrastructureErrorHandlingResponseError[]> GeofenceControllerDeleteGeofence(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/geofences/v1/geofences/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Version"] = Convert.ToString(15);
            return new ApiConnectionAction<CustomerAPIInfrastructureErrorHandlingResponseError[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIInfrastructureErrorHandlingResponseError[]> TrackingControllerRemoveGpsDataFeedSubscription(Expression<Func<string>> subscriptionId)
        {
            var apiCallPath = "/tracking/v1/tracking/gpsdata/subscribe";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["subscriptionId"] = ExpressionConverter.Convert(subscriptionId);
            callPayload.Headers["X-API-Version"] = Convert.ToString(15);
            return new ApiConnectionAction<CustomerAPIInfrastructureErrorHandlingResponseError[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[]> TrackingControllerGetSubscriptions()
        {
            var apiCallPath = "/tracking/v1/tracking/gpsdata/subscriptions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Version"] = Convert.ToString(15);
            return new ApiConnectionAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<JToken> TrackingControllerSubscribeCallback(Expression<Func<string>> positionId = null, Expression<Func<string>> positionDeviceId = null, Expression<Func<int>> positionDeviceType = null, Expression<Func<string>> positionTimestamp = null, Expression<Func<int>> positionCompanyId = null, Expression<Func<int>> positionUserId = null, Expression<Func<int>> positionVehicleId = null, Expression<Func<bool>> positionUserLinkedToVehicle = null, Expression<Func<string>> positionLocationProvider = null, Expression<Func<double>> positionLat = null, Expression<Func<double>> positionLon = null, Expression<Func<double>> positionAccuracyFt = null, Expression<Func<double>> positionAltitudeFt = null, Expression<Func<int>> positionHeading = null, Expression<Func<double>> positionSpeedMph = null, Expression<Func<int>> positionBatteryStatus = null, Expression<Func<int>> positionBatteryLevel = null, Expression<Func<int>> positionActivityState = null, Expression<Func<bool>> positionIsNetworkConnected = null, Expression<Func<int>> positionRssi = null, Expression<Func<double>> positionDOdoMl = null, Expression<Func<double>> positionVOdoMl = null)
        {
            var apiCallPath = "/tracking/v1/tracking/gpsdata/subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Version"] = Convert.ToString(15);
            var position = new JObject();
            var positionpropCount = 0;
            if (positionId != null)
            {
                position["Id"] = ExpressionConverter.ConvertO(positionId);
                positionpropCount++;
            }

            if (positionDeviceId != null)
            {
                position["DeviceId"] = ExpressionConverter.ConvertO(positionDeviceId);
                positionpropCount++;
            }

            if (positionDeviceType != null)
            {
                position["DeviceType"] = ExpressionConverter.ConvertO(positionDeviceType);
                positionpropCount++;
            }

            if (positionTimestamp != null)
            {
                position["Timestamp"] = ExpressionConverter.ConvertO(positionTimestamp);
                positionpropCount++;
            }

            if (positionCompanyId != null)
            {
                position["CompanyId"] = ExpressionConverter.ConvertO(positionCompanyId);
                positionpropCount++;
            }

            if (positionUserId != null)
            {
                position["UserId"] = ExpressionConverter.ConvertO(positionUserId);
                positionpropCount++;
            }

            if (positionVehicleId != null)
            {
                position["VehicleId"] = ExpressionConverter.ConvertO(positionVehicleId);
                positionpropCount++;
            }

            if (positionUserLinkedToVehicle != null)
            {
                position["UserLinkedToVehicle"] = ExpressionConverter.ConvertO(positionUserLinkedToVehicle);
                positionpropCount++;
            }

            if (positionLocationProvider != null)
            {
                position["LocationProvider"] = ExpressionConverter.ConvertO(positionLocationProvider);
                positionpropCount++;
            }

            if (positionLat != null)
            {
                position["Lat"] = ExpressionConverter.ConvertO(positionLat);
                positionpropCount++;
            }

            if (positionLon != null)
            {
                position["Lon"] = ExpressionConverter.ConvertO(positionLon);
                positionpropCount++;
            }

            if (positionAccuracyFt != null)
            {
                position["AccuracyFt"] = ExpressionConverter.ConvertO(positionAccuracyFt);
                positionpropCount++;
            }

            if (positionAltitudeFt != null)
            {
                position["AltitudeFt"] = ExpressionConverter.ConvertO(positionAltitudeFt);
                positionpropCount++;
            }

            if (positionHeading != null)
            {
                position["Heading"] = ExpressionConverter.ConvertO(positionHeading);
                positionpropCount++;
            }

            if (positionSpeedMph != null)
            {
                position["SpeedMph"] = ExpressionConverter.ConvertO(positionSpeedMph);
                positionpropCount++;
            }

            if (positionBatteryStatus != null)
            {
                position["BatteryStatus"] = ExpressionConverter.ConvertO(positionBatteryStatus);
                positionpropCount++;
            }

            if (positionBatteryLevel != null)
            {
                position["BatteryLevel"] = ExpressionConverter.ConvertO(positionBatteryLevel);
                positionpropCount++;
            }

            if (positionActivityState != null)
            {
                position["ActivityState"] = ExpressionConverter.ConvertO(positionActivityState);
                positionpropCount++;
            }

            if (positionIsNetworkConnected != null)
            {
                position["IsNetworkConnected"] = ExpressionConverter.ConvertO(positionIsNetworkConnected);
                positionpropCount++;
            }

            if (positionRssi != null)
            {
                position["Rssi"] = ExpressionConverter.ConvertO(positionRssi);
                positionpropCount++;
            }

            if (positionDOdoMl != null)
            {
                position["DOdoMl"] = ExpressionConverter.ConvertO(positionDOdoMl);
                positionpropCount++;
            }

            if (positionVOdoMl != null)
            {
                position["VOdoMl"] = ExpressionConverter.ConvertO(positionVOdoMl);
                positionpropCount++;
            }

            if (positionpropCount > 0)
            {
                callPayload.Body = position;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IWorkflowAction TrackingControllerResetSubscriptionHealthStatus(Expression<Func<int>> subscriptionId)
        {
            var apiCallPath = String.Format("/tracking/v1/tracking/gpsdata/subscription/{0}/reset", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Version"] = Convert.ToString(15);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IWorkflowAction VersionControllerGet()
        {
            var apiCallPath = "/api/v1/minorversion";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-API-Version"] = Convert.ToString(15);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class ActsoftTriggers([ConnectionName] string connectionId)
    {
    }

    public class CustomerAPIModelsCustomListsCustomListDefinitionListItemApiModel
    {
        public int CustomListId { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
    }

    public class CustomerAPIInfrastructureErrorHandlingResponseError
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }

    public class CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel
    {
        public string SubscriptionId { get; set; }
        public string Url { get; set; }
        public CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModelStatusType Status { get; set; }
    }

    public enum CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModelStatusType
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Actsoft;

    public partial class WorkflowManagedActions
    {
        public ActsoftActions Actsoft(string connectionId) => new ActsoftActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ActsoftTriggers Actsoft(string connectionId) => new ActsoftTriggers(connectionId);
    }
}