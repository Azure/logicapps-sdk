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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EventControllerSubscribeCallback(Expression<Func<EventControllerSubscribeCallbackInput>> @event)
        {
            var __workflow_event = WorkflowExpression.Compile(@event, nameof(@event), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/events/v1/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_event);
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
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> TrackingControllerSubscribeCallback(Expression<Func<TrackingControllerSubscribeCallbackInput>> position)
        {
            var __workflow_position = WorkflowExpression.Compile(position, nameof(position), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tracking/v1/tracking/gpsdata/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_position);
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

    public class EventControllerSubscribeCallbackInput
    {
        public string Id { get; set; }
        public int? EventType { get; set; }
        public string EventCode { get; set; }
        public string EventTime { get; set; }
        public string DeviceId { get; set; }
        public int? DeviceType { get; set; }
        public int? UserId { get; set; }
        public int? VehicleId { get; set; }
        public bool? UserLinkedToVehicle { get; set; }
        public double? Lat { get; set; }
        public double? Lon { get; set; }
        public string CustomEventDefinitionId { get; set; }
        public JToken EventParams { get; set; }
    }

    public class TrackingControllerSubscribeCallbackInput
    {
        public string Id { get; set; }
        public string DeviceId { get; set; }
        public int? DeviceType { get; set; }
        public string Timestamp { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
        public int? VehicleId { get; set; }
        public bool? UserLinkedToVehicle { get; set; }
        public string LocationProvider { get; set; }
        public double? Lat { get; set; }
        public double? Lon { get; set; }
        public double? AccuracyFt { get; set; }
        public double? AltitudeFt { get; set; }
        public int? Heading { get; set; }
        public double? SpeedMph { get; set; }
        public int? BatteryStatus { get; set; }
        public int? BatteryLevel { get; set; }
        public int? ActivityState { get; set; }
        public bool? IsNetworkConnected { get; set; }
        public int? Rssi { get; set; }
        public double? DOdoMl { get; set; }
        public double? VOdoMl { get; set; }
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