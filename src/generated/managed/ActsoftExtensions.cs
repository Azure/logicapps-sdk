//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Actsoft
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ActsoftActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIModelsCustomListsCustomListDefinitionListItemApiModel[], ApiConnectionActionConfiguration> CustomListControllerGet()
        {
            return new DeferredBodyAction<CustomerAPIModelsCustomListsCustomListDefinitionListItemApiModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/custom-lists/v1/custom-lists/definitions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return new ApiConnectionAction<CustomerAPIModelsCustomListsCustomListDefinitionListItemApiModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIInfrastructureErrorHandlingResponseError[], ApiConnectionActionConfiguration> EventControllerDelete(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CustomerAPIInfrastructureErrorHandlingResponseError[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/events/v1/definitions/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return new ApiConnectionAction<CustomerAPIInfrastructureErrorHandlingResponseError[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIInfrastructureErrorHandlingResponseError[], ApiConnectionActionConfiguration> EventControllerRemoveEventDataFeedSubscription(Expression<Func<string>> subscriptionId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredBodyAction<CustomerAPIInfrastructureErrorHandlingResponseError[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/events/v1/subscribe";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionId"] = ExpressionConverter.Convert(__workflow_subscriptionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return new ApiConnectionAction<CustomerAPIInfrastructureErrorHandlingResponseError[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[], ApiConnectionActionConfiguration> EventControllerGetSubscriptions()
        {
            return new DeferredBodyAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/events/v1/subscriptions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return new ApiConnectionAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EventControllerSubscribeCallback(Expression<Func<string>> eventid = null, Expression<Func<int>> eventeventType = null, Expression<Func<string>> eventeventCode = null, Expression<Func<string>> eventeventTime = null, Expression<Func<string>> eventdeviceId = null, Expression<Func<int>> eventdeviceType = null, Expression<Func<int>> eventuserId = null, Expression<Func<int>> eventvehicleId = null, Expression<Func<bool>> eventuserLinkedToVehicle = null, Expression<Func<double>> eventlat = null, Expression<Func<double>> eventlon = null, Expression<Func<string>> eventcustomEventDefinitionId = null)
        {
            var __workflow_eventid = WorkflowExpression.Compile(eventid, nameof(eventid), required: false);
            var __workflow_eventeventType = WorkflowExpression.Compile(eventeventType, nameof(eventeventType), required: false);
            var __workflow_eventeventCode = WorkflowExpression.Compile(eventeventCode, nameof(eventeventCode), required: false);
            var __workflow_eventeventTime = WorkflowExpression.Compile(eventeventTime, nameof(eventeventTime), required: false);
            var __workflow_eventdeviceId = WorkflowExpression.Compile(eventdeviceId, nameof(eventdeviceId), required: false);
            var __workflow_eventdeviceType = WorkflowExpression.Compile(eventdeviceType, nameof(eventdeviceType), required: false);
            var __workflow_eventuserId = WorkflowExpression.Compile(eventuserId, nameof(eventuserId), required: false);
            var __workflow_eventvehicleId = WorkflowExpression.Compile(eventvehicleId, nameof(eventvehicleId), required: false);
            var __workflow_eventuserLinkedToVehicle = WorkflowExpression.Compile(eventuserLinkedToVehicle, nameof(eventuserLinkedToVehicle), required: false);
            var __workflow_eventlat = WorkflowExpression.Compile(eventlat, nameof(eventlat), required: false);
            var __workflow_eventlon = WorkflowExpression.Compile(eventlon, nameof(eventlon), required: false);
            var __workflow_eventcustomEventDefinitionId = WorkflowExpression.Compile(eventcustomEventDefinitionId, nameof(eventcustomEventDefinitionId), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/events/v1/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                var @event = new JObject();
                var @eventpropCount = 0;
                if (__workflow_eventid != null)
                {
                    @event["Id"] = ExpressionConverter.ConvertO(__workflow_eventid);
                    @eventpropCount++;
                }

                if (__workflow_eventeventType != null)
                {
                    @event["EventType"] = ExpressionConverter.ConvertO(__workflow_eventeventType);
                    @eventpropCount++;
                }

                if (__workflow_eventeventCode != null)
                {
                    @event["EventCode"] = ExpressionConverter.ConvertO(__workflow_eventeventCode);
                    @eventpropCount++;
                }

                if (__workflow_eventeventTime != null)
                {
                    @event["EventTime"] = ExpressionConverter.ConvertO(__workflow_eventeventTime);
                    @eventpropCount++;
                }

                if (__workflow_eventdeviceId != null)
                {
                    @event["DeviceId"] = ExpressionConverter.ConvertO(__workflow_eventdeviceId);
                    @eventpropCount++;
                }

                if (__workflow_eventdeviceType != null)
                {
                    @event["DeviceType"] = ExpressionConverter.ConvertO(__workflow_eventdeviceType);
                    @eventpropCount++;
                }

                if (__workflow_eventuserId != null)
                {
                    @event["UserId"] = ExpressionConverter.ConvertO(__workflow_eventuserId);
                    @eventpropCount++;
                }

                if (__workflow_eventvehicleId != null)
                {
                    @event["VehicleId"] = ExpressionConverter.ConvertO(__workflow_eventvehicleId);
                    @eventpropCount++;
                }

                if (__workflow_eventuserLinkedToVehicle != null)
                {
                    @event["UserLinkedToVehicle"] = ExpressionConverter.ConvertO(__workflow_eventuserLinkedToVehicle);
                    @eventpropCount++;
                }

                if (__workflow_eventlat != null)
                {
                    @event["Lat"] = ExpressionConverter.ConvertO(__workflow_eventlat);
                    @eventpropCount++;
                }

                if (__workflow_eventlon != null)
                {
                    @event["Lon"] = ExpressionConverter.ConvertO(__workflow_eventlon);
                    @eventpropCount++;
                }

                if (__workflow_eventcustomEventDefinitionId != null)
                {
                    @event["CustomEventDefinitionId"] = ExpressionConverter.ConvertO(__workflow_eventcustomEventDefinitionId);
                    @eventpropCount++;
                }

                var eventParamsObject = new JObject();
                var eventParamsObjectpropCount = 0;
                if (eventParamsObjectpropCount > 0)
                {
                    @event["EventParams"] = eventParamsObject;
                    @eventpropCount++;
                }

                if (@eventpropCount > 0)
                {
                    callPayload.Body = @event;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EventControllerResetSubscriptionHealthStatus(Expression<Func<int>> subscriptionId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/events/v1/subscription/{0}/reset", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIInfrastructureErrorHandlingResponseError[], ApiConnectionActionConfiguration> GeofenceControllerDeleteGeofence(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CustomerAPIInfrastructureErrorHandlingResponseError[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/geofences/v1/geofences/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return new ApiConnectionAction<CustomerAPIInfrastructureErrorHandlingResponseError[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIInfrastructureErrorHandlingResponseError[], ApiConnectionActionConfiguration> TrackingControllerRemoveGpsDataFeedSubscription(Expression<Func<string>> subscriptionId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredBodyAction<CustomerAPIInfrastructureErrorHandlingResponseError[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tracking/v1/tracking/gpsdata/subscribe";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionId"] = ExpressionConverter.Convert(__workflow_subscriptionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return new ApiConnectionAction<CustomerAPIInfrastructureErrorHandlingResponseError[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[], ApiConnectionActionConfiguration> TrackingControllerGetSubscriptions()
        {
            return new DeferredBodyAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tracking/v1/tracking/gpsdata/subscriptions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return new ApiConnectionAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> TrackingControllerSubscribeCallback(Expression<Func<string>> positionid = null, Expression<Func<string>> positiondeviceId = null, Expression<Func<int>> positiondeviceType = null, Expression<Func<string>> positiontimestamp = null, Expression<Func<int>> positioncompanyId = null, Expression<Func<int>> positionuserId = null, Expression<Func<int>> positionvehicleId = null, Expression<Func<bool>> positionuserLinkedToVehicle = null, Expression<Func<string>> positionlocationProvider = null, Expression<Func<double>> positionlat = null, Expression<Func<double>> positionlon = null, Expression<Func<double>> positionaccuracyFt = null, Expression<Func<double>> positionaltitudeFt = null, Expression<Func<int>> positionheading = null, Expression<Func<double>> positionspeedMph = null, Expression<Func<int>> positionbatteryStatus = null, Expression<Func<int>> positionbatteryLevel = null, Expression<Func<int>> positionactivityState = null, Expression<Func<bool>> positionisNetworkConnected = null, Expression<Func<int>> positionrssi = null, Expression<Func<double>> positiondOdoMl = null, Expression<Func<double>> positionvOdoMl = null)
        {
            var __workflow_positionid = WorkflowExpression.Compile(positionid, nameof(positionid), required: false);
            var __workflow_positiondeviceId = WorkflowExpression.Compile(positiondeviceId, nameof(positiondeviceId), required: false);
            var __workflow_positiondeviceType = WorkflowExpression.Compile(positiondeviceType, nameof(positiondeviceType), required: false);
            var __workflow_positiontimestamp = WorkflowExpression.Compile(positiontimestamp, nameof(positiontimestamp), required: false);
            var __workflow_positioncompanyId = WorkflowExpression.Compile(positioncompanyId, nameof(positioncompanyId), required: false);
            var __workflow_positionuserId = WorkflowExpression.Compile(positionuserId, nameof(positionuserId), required: false);
            var __workflow_positionvehicleId = WorkflowExpression.Compile(positionvehicleId, nameof(positionvehicleId), required: false);
            var __workflow_positionuserLinkedToVehicle = WorkflowExpression.Compile(positionuserLinkedToVehicle, nameof(positionuserLinkedToVehicle), required: false);
            var __workflow_positionlocationProvider = WorkflowExpression.Compile(positionlocationProvider, nameof(positionlocationProvider), required: false);
            var __workflow_positionlat = WorkflowExpression.Compile(positionlat, nameof(positionlat), required: false);
            var __workflow_positionlon = WorkflowExpression.Compile(positionlon, nameof(positionlon), required: false);
            var __workflow_positionaccuracyFt = WorkflowExpression.Compile(positionaccuracyFt, nameof(positionaccuracyFt), required: false);
            var __workflow_positionaltitudeFt = WorkflowExpression.Compile(positionaltitudeFt, nameof(positionaltitudeFt), required: false);
            var __workflow_positionheading = WorkflowExpression.Compile(positionheading, nameof(positionheading), required: false);
            var __workflow_positionspeedMph = WorkflowExpression.Compile(positionspeedMph, nameof(positionspeedMph), required: false);
            var __workflow_positionbatteryStatus = WorkflowExpression.Compile(positionbatteryStatus, nameof(positionbatteryStatus), required: false);
            var __workflow_positionbatteryLevel = WorkflowExpression.Compile(positionbatteryLevel, nameof(positionbatteryLevel), required: false);
            var __workflow_positionactivityState = WorkflowExpression.Compile(positionactivityState, nameof(positionactivityState), required: false);
            var __workflow_positionisNetworkConnected = WorkflowExpression.Compile(positionisNetworkConnected, nameof(positionisNetworkConnected), required: false);
            var __workflow_positionrssi = WorkflowExpression.Compile(positionrssi, nameof(positionrssi), required: false);
            var __workflow_positiondOdoMl = WorkflowExpression.Compile(positiondOdoMl, nameof(positiondOdoMl), required: false);
            var __workflow_positionvOdoMl = WorkflowExpression.Compile(positionvOdoMl, nameof(positionvOdoMl), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tracking/v1/tracking/gpsdata/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                var position = new JObject();
                var positionpropCount = 0;
                if (__workflow_positionid != null)
                {
                    position["Id"] = ExpressionConverter.ConvertO(__workflow_positionid);
                    positionpropCount++;
                }

                if (__workflow_positiondeviceId != null)
                {
                    position["DeviceId"] = ExpressionConverter.ConvertO(__workflow_positiondeviceId);
                    positionpropCount++;
                }

                if (__workflow_positiondeviceType != null)
                {
                    position["DeviceType"] = ExpressionConverter.ConvertO(__workflow_positiondeviceType);
                    positionpropCount++;
                }

                if (__workflow_positiontimestamp != null)
                {
                    position["Timestamp"] = ExpressionConverter.ConvertO(__workflow_positiontimestamp);
                    positionpropCount++;
                }

                if (__workflow_positioncompanyId != null)
                {
                    position["CompanyId"] = ExpressionConverter.ConvertO(__workflow_positioncompanyId);
                    positionpropCount++;
                }

                if (__workflow_positionuserId != null)
                {
                    position["UserId"] = ExpressionConverter.ConvertO(__workflow_positionuserId);
                    positionpropCount++;
                }

                if (__workflow_positionvehicleId != null)
                {
                    position["VehicleId"] = ExpressionConverter.ConvertO(__workflow_positionvehicleId);
                    positionpropCount++;
                }

                if (__workflow_positionuserLinkedToVehicle != null)
                {
                    position["UserLinkedToVehicle"] = ExpressionConverter.ConvertO(__workflow_positionuserLinkedToVehicle);
                    positionpropCount++;
                }

                if (__workflow_positionlocationProvider != null)
                {
                    position["LocationProvider"] = ExpressionConverter.ConvertO(__workflow_positionlocationProvider);
                    positionpropCount++;
                }

                if (__workflow_positionlat != null)
                {
                    position["Lat"] = ExpressionConverter.ConvertO(__workflow_positionlat);
                    positionpropCount++;
                }

                if (__workflow_positionlon != null)
                {
                    position["Lon"] = ExpressionConverter.ConvertO(__workflow_positionlon);
                    positionpropCount++;
                }

                if (__workflow_positionaccuracyFt != null)
                {
                    position["AccuracyFt"] = ExpressionConverter.ConvertO(__workflow_positionaccuracyFt);
                    positionpropCount++;
                }

                if (__workflow_positionaltitudeFt != null)
                {
                    position["AltitudeFt"] = ExpressionConverter.ConvertO(__workflow_positionaltitudeFt);
                    positionpropCount++;
                }

                if (__workflow_positionheading != null)
                {
                    position["Heading"] = ExpressionConverter.ConvertO(__workflow_positionheading);
                    positionpropCount++;
                }

                if (__workflow_positionspeedMph != null)
                {
                    position["SpeedMph"] = ExpressionConverter.ConvertO(__workflow_positionspeedMph);
                    positionpropCount++;
                }

                if (__workflow_positionbatteryStatus != null)
                {
                    position["BatteryStatus"] = ExpressionConverter.ConvertO(__workflow_positionbatteryStatus);
                    positionpropCount++;
                }

                if (__workflow_positionbatteryLevel != null)
                {
                    position["BatteryLevel"] = ExpressionConverter.ConvertO(__workflow_positionbatteryLevel);
                    positionpropCount++;
                }

                if (__workflow_positionactivityState != null)
                {
                    position["ActivityState"] = ExpressionConverter.ConvertO(__workflow_positionactivityState);
                    positionpropCount++;
                }

                if (__workflow_positionisNetworkConnected != null)
                {
                    position["IsNetworkConnected"] = ExpressionConverter.ConvertO(__workflow_positionisNetworkConnected);
                    positionpropCount++;
                }

                if (__workflow_positionrssi != null)
                {
                    position["Rssi"] = ExpressionConverter.ConvertO(__workflow_positionrssi);
                    positionpropCount++;
                }

                if (__workflow_positiondOdoMl != null)
                {
                    position["DOdoMl"] = ExpressionConverter.ConvertO(__workflow_positiondOdoMl);
                    positionpropCount++;
                }

                if (__workflow_positionvOdoMl != null)
                {
                    position["VOdoMl"] = ExpressionConverter.ConvertO(__workflow_positionvOdoMl);
                    positionpropCount++;
                }

                if (positionpropCount > 0)
                {
                    callPayload.Body = position;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TrackingControllerResetSubscriptionHealthStatus(Expression<Func<int>> subscriptionId)
        {
            var __workflow_subscriptionId = WorkflowExpression.Compile(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tracking/v1/tracking/gpsdata/subscription/{0}/reset", __workflow_subscriptionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IWorkflowAction<ApiConnectionActionConfiguration> VersionControllerGet()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v1/minorversion";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return new ApiConnectionAction(callPayload);
            });
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
        _1 = 1,
        _2 = 2
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