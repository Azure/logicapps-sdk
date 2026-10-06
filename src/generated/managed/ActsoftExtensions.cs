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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/custom-lists/v1/custom-lists/definitions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerAPIModelsCustomListsCustomListDefinitionListItemApiModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIInfrastructureErrorHandlingResponseError[]> EventControllerDelete([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/events/v1/definitions/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerAPIInfrastructureErrorHandlingResponseError[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIInfrastructureErrorHandlingResponseError[]> EventControllerRemoveEventDataFeedSubscription([WorkflowExpression] Func<string> subscriptionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/events/v1/subscribe";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionId"] = SourceExpressionConverter.ConvertO(subscriptionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerAPIInfrastructureErrorHandlingResponseError[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[]> EventControllerGetSubscriptions()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/events/v1/subscriptions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<JToken> EventControllerSubscribeCallback([WorkflowExpression] Func<string> eventid = null, [WorkflowExpression] Func<int> eventeventType = null, [WorkflowExpression] Func<string> eventeventCode = null, [WorkflowExpression] Func<string> eventeventTime = null, [WorkflowExpression] Func<string> eventdeviceId = null, [WorkflowExpression] Func<int> eventdeviceType = null, [WorkflowExpression] Func<int> eventuserId = null, [WorkflowExpression] Func<int> eventvehicleId = null, [WorkflowExpression] Func<bool> eventuserLinkedToVehicle = null, [WorkflowExpression] Func<double> eventlat = null, [WorkflowExpression] Func<double> eventlon = null, [WorkflowExpression] Func<string> eventcustomEventDefinitionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/events/v1/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                var @event = new JObject();
                var @eventpropCount = 0;
                if (eventid != null)
                {
                    @event["Id"] = SourceExpressionConverter.ConvertToken(eventid);
                    @eventpropCount++;
                }

                if (eventeventType != null)
                {
                    @event["EventType"] = SourceExpressionConverter.ConvertToken(eventeventType);
                    @eventpropCount++;
                }

                if (eventeventCode != null)
                {
                    @event["EventCode"] = SourceExpressionConverter.ConvertToken(eventeventCode);
                    @eventpropCount++;
                }

                if (eventeventTime != null)
                {
                    @event["EventTime"] = SourceExpressionConverter.ConvertToken(eventeventTime);
                    @eventpropCount++;
                }

                if (eventdeviceId != null)
                {
                    @event["DeviceId"] = SourceExpressionConverter.ConvertToken(eventdeviceId);
                    @eventpropCount++;
                }

                if (eventdeviceType != null)
                {
                    @event["DeviceType"] = SourceExpressionConverter.ConvertToken(eventdeviceType);
                    @eventpropCount++;
                }

                if (eventuserId != null)
                {
                    @event["UserId"] = SourceExpressionConverter.ConvertToken(eventuserId);
                    @eventpropCount++;
                }

                if (eventvehicleId != null)
                {
                    @event["VehicleId"] = SourceExpressionConverter.ConvertToken(eventvehicleId);
                    @eventpropCount++;
                }

                if (eventuserLinkedToVehicle != null)
                {
                    @event["UserLinkedToVehicle"] = SourceExpressionConverter.ConvertToken(eventuserLinkedToVehicle);
                    @eventpropCount++;
                }

                if (eventlat != null)
                {
                    @event["Lat"] = SourceExpressionConverter.ConvertToken(eventlat);
                    @eventpropCount++;
                }

                if (eventlon != null)
                {
                    @event["Lon"] = SourceExpressionConverter.ConvertToken(eventlon);
                    @eventpropCount++;
                }

                if (eventcustomEventDefinitionId != null)
                {
                    @event["CustomEventDefinitionId"] = SourceExpressionConverter.ConvertToken(eventcustomEventDefinitionId);
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
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IWorkflowAction EventControllerResetSubscriptionHealthStatus([WorkflowExpression] Func<int> subscriptionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/events/v1/subscription/{0}/reset", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(subscriptionId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIInfrastructureErrorHandlingResponseError[]> GeofenceControllerDeleteGeofence([WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/geofences/v1/geofences/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerAPIInfrastructureErrorHandlingResponseError[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIInfrastructureErrorHandlingResponseError[]> TrackingControllerRemoveGpsDataFeedSubscription([WorkflowExpression] Func<string> subscriptionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tracking/v1/tracking/gpsdata/subscribe";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["subscriptionId"] = SourceExpressionConverter.ConvertO(subscriptionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerAPIInfrastructureErrorHandlingResponseError[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[]> TrackingControllerGetSubscriptions()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tracking/v1/tracking/gpsdata/subscriptions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return callPayload;
            }

            return new ApiConnectionAction<CustomerAPIModelsWebHookSubscriptionWebHookSubscriptionInfoApiModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IBodyWorkflowAction<JToken> TrackingControllerSubscribeCallback([WorkflowExpression] Func<string> positionid = null, [WorkflowExpression] Func<string> positiondeviceId = null, [WorkflowExpression] Func<int> positiondeviceType = null, [WorkflowExpression] Func<string> positiontimestamp = null, [WorkflowExpression] Func<int> positioncompanyId = null, [WorkflowExpression] Func<int> positionuserId = null, [WorkflowExpression] Func<int> positionvehicleId = null, [WorkflowExpression] Func<bool> positionuserLinkedToVehicle = null, [WorkflowExpression] Func<string> positionlocationProvider = null, [WorkflowExpression] Func<double> positionlat = null, [WorkflowExpression] Func<double> positionlon = null, [WorkflowExpression] Func<double> positionaccuracyFt = null, [WorkflowExpression] Func<double> positionaltitudeFt = null, [WorkflowExpression] Func<int> positionheading = null, [WorkflowExpression] Func<double> positionspeedMph = null, [WorkflowExpression] Func<int> positionbatteryStatus = null, [WorkflowExpression] Func<int> positionbatteryLevel = null, [WorkflowExpression] Func<int> positionactivityState = null, [WorkflowExpression] Func<bool> positionisNetworkConnected = null, [WorkflowExpression] Func<int> positionrssi = null, [WorkflowExpression] Func<double> positiondOdoMl = null, [WorkflowExpression] Func<double> positionvOdoMl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tracking/v1/tracking/gpsdata/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                var position = new JObject();
                var positionpropCount = 0;
                if (positionid != null)
                {
                    position["Id"] = SourceExpressionConverter.ConvertToken(positionid);
                    positionpropCount++;
                }

                if (positiondeviceId != null)
                {
                    position["DeviceId"] = SourceExpressionConverter.ConvertToken(positiondeviceId);
                    positionpropCount++;
                }

                if (positiondeviceType != null)
                {
                    position["DeviceType"] = SourceExpressionConverter.ConvertToken(positiondeviceType);
                    positionpropCount++;
                }

                if (positiontimestamp != null)
                {
                    position["Timestamp"] = SourceExpressionConverter.ConvertToken(positiontimestamp);
                    positionpropCount++;
                }

                if (positioncompanyId != null)
                {
                    position["CompanyId"] = SourceExpressionConverter.ConvertToken(positioncompanyId);
                    positionpropCount++;
                }

                if (positionuserId != null)
                {
                    position["UserId"] = SourceExpressionConverter.ConvertToken(positionuserId);
                    positionpropCount++;
                }

                if (positionvehicleId != null)
                {
                    position["VehicleId"] = SourceExpressionConverter.ConvertToken(positionvehicleId);
                    positionpropCount++;
                }

                if (positionuserLinkedToVehicle != null)
                {
                    position["UserLinkedToVehicle"] = SourceExpressionConverter.ConvertToken(positionuserLinkedToVehicle);
                    positionpropCount++;
                }

                if (positionlocationProvider != null)
                {
                    position["LocationProvider"] = SourceExpressionConverter.ConvertToken(positionlocationProvider);
                    positionpropCount++;
                }

                if (positionlat != null)
                {
                    position["Lat"] = SourceExpressionConverter.ConvertToken(positionlat);
                    positionpropCount++;
                }

                if (positionlon != null)
                {
                    position["Lon"] = SourceExpressionConverter.ConvertToken(positionlon);
                    positionpropCount++;
                }

                if (positionaccuracyFt != null)
                {
                    position["AccuracyFt"] = SourceExpressionConverter.ConvertToken(positionaccuracyFt);
                    positionpropCount++;
                }

                if (positionaltitudeFt != null)
                {
                    position["AltitudeFt"] = SourceExpressionConverter.ConvertToken(positionaltitudeFt);
                    positionpropCount++;
                }

                if (positionheading != null)
                {
                    position["Heading"] = SourceExpressionConverter.ConvertToken(positionheading);
                    positionpropCount++;
                }

                if (positionspeedMph != null)
                {
                    position["SpeedMph"] = SourceExpressionConverter.ConvertToken(positionspeedMph);
                    positionpropCount++;
                }

                if (positionbatteryStatus != null)
                {
                    position["BatteryStatus"] = SourceExpressionConverter.ConvertToken(positionbatteryStatus);
                    positionpropCount++;
                }

                if (positionbatteryLevel != null)
                {
                    position["BatteryLevel"] = SourceExpressionConverter.ConvertToken(positionbatteryLevel);
                    positionpropCount++;
                }

                if (positionactivityState != null)
                {
                    position["ActivityState"] = SourceExpressionConverter.ConvertToken(positionactivityState);
                    positionpropCount++;
                }

                if (positionisNetworkConnected != null)
                {
                    position["IsNetworkConnected"] = SourceExpressionConverter.ConvertToken(positionisNetworkConnected);
                    positionpropCount++;
                }

                if (positionrssi != null)
                {
                    position["Rssi"] = SourceExpressionConverter.ConvertToken(positionrssi);
                    positionpropCount++;
                }

                if (positiondOdoMl != null)
                {
                    position["DOdoMl"] = SourceExpressionConverter.ConvertToken(positiondOdoMl);
                    positionpropCount++;
                }

                if (positionvOdoMl != null)
                {
                    position["VOdoMl"] = SourceExpressionConverter.ConvertToken(positionvOdoMl);
                    positionpropCount++;
                }

                if (positionpropCount > 0)
                {
                    callPayload.Body = position;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IWorkflowAction TrackingControllerResetSubscriptionHealthStatus([WorkflowExpression] Func<int> subscriptionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tracking/v1/tracking/gpsdata/subscription/{0}/reset", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(subscriptionId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "actsoft")]
        public IWorkflowAction VersionControllerGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v1/minorversion";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-API-Version"] = Convert.ToString(15);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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