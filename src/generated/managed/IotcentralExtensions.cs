//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iotcentral
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IotcentralActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iotcentral")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeviceCommandsRun(Expression<Func<string>> applicationId, Expression<Func<string>> deviceId, Expression<Func<string>> deviceCommandId, Expression<Func<object>> body, Expression<Func<string>> deviceTemplateDisplayId = null)
        {
            var __workflow_applicationId = WorkflowExpression.Compile(applicationId, nameof(applicationId), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_deviceCommandId = WorkflowExpression.Compile(deviceCommandId, nameof(deviceCommandId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_deviceTemplateDisplayId = WorkflowExpression.Compile(deviceTemplateDisplayId, nameof(deviceTemplateDisplayId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/applications/{0}/devices/{1}/commands/{2}", __workflow_applicationId.WithUrlEncoding(1), __workflow_deviceId.WithUrlEncoding(1), __workflow_deviceCommandId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_deviceTemplateDisplayId != null)
                    callPayload.Queries["deviceTemplateDisplayId"] = ExpressionConverter.Convert(__workflow_deviceTemplateDisplayId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iotcentral")]
        public IBodyWorkflowAction<Device, ApiConnectionActionConfiguration> DevicesCreate(Expression<Func<string>> applicationId, Expression<Func<DevicesCreateBodyInput>> body, Expression<Func<string>> deviceTemplateDisplayId = null)
        {
            var __workflow_applicationId = WorkflowExpression.Compile(applicationId, nameof(applicationId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_deviceTemplateDisplayId = WorkflowExpression.Compile(deviceTemplateDisplayId, nameof(deviceTemplateDisplayId), required: false);
            return new DeferredBodyAction<Device, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/applications/{0}/devices/", __workflow_applicationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_deviceTemplateDisplayId != null)
                    callPayload.Queries["deviceTemplateDisplayId"] = ExpressionConverter.Convert(__workflow_deviceTemplateDisplayId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Device>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iotcentral")]
        public IBodyWorkflowAction<Device, ApiConnectionActionConfiguration> DevicesGet(Expression<Func<string>> applicationId, Expression<Func<string>> deviceId, Expression<Func<string>> deviceTemplateDisplayId = null)
        {
            var __workflow_applicationId = WorkflowExpression.Compile(applicationId, nameof(applicationId), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_deviceTemplateDisplayId = WorkflowExpression.Compile(deviceTemplateDisplayId, nameof(deviceTemplateDisplayId), required: false);
            return new DeferredBodyAction<Device, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/applications/{0}/devices/{1}", __workflow_applicationId.WithUrlEncoding(1), __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_deviceTemplateDisplayId != null)
                    callPayload.Queries["deviceTemplateDisplayId"] = ExpressionConverter.Convert(__workflow_deviceTemplateDisplayId);
                return new ApiConnectionAction<Device>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iotcentral")]
        public IBodyWorkflowAction<Device, ApiConnectionActionConfiguration> DevicesUpdate(Expression<Func<string>> applicationId, Expression<Func<string>> deviceId, Expression<Func<DevicesUpdateBodyInput>> body, Expression<Func<string>> deviceTemplateDisplayId = null)
        {
            var __workflow_applicationId = WorkflowExpression.Compile(applicationId, nameof(applicationId), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_deviceTemplateDisplayId = WorkflowExpression.Compile(deviceTemplateDisplayId, nameof(deviceTemplateDisplayId), required: false);
            return new DeferredBodyAction<Device, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/applications/{0}/devices/{1}", __workflow_applicationId.WithUrlEncoding(1), __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_deviceTemplateDisplayId != null)
                    callPayload.Queries["deviceTemplateDisplayId"] = ExpressionConverter.Convert(__workflow_deviceTemplateDisplayId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Device>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iotcentral")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DevicesRemove(Expression<Func<string>> applicationId, Expression<Func<string>> deviceId)
        {
            var __workflow_applicationId = WorkflowExpression.Compile(applicationId, nameof(applicationId), required: true);
            var __workflow_deviceId = WorkflowExpression.Compile(deviceId, nameof(deviceId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/applications/{0}/devices/{1}", __workflow_applicationId.WithUrlEncoding(1), __workflow_deviceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class IotcentralTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Action, ApiConnectionTriggerConfiguration> ActionsCreate(Expression<Func<string>> applicationId, Expression<Func<ActionsCreateBodyInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_applicationId = WorkflowExpression.Compile(applicationId, nameof(applicationId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<Action, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/applications/{0}/actions/", __workflow_applicationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<Action>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class Device
    {
        [JsonProperty("id")]
        public string DeviceId { get; set; }

        [JsonProperty("name")]
        public string DeviceName { get; set; }

        [JsonProperty("simulated")]
        public bool DeviceSimulated { get; set; }

        [JsonProperty("deviceId")]
        public string DeviceConnectionId { get; set; }

        [JsonProperty("deviceTemplate")]
        public DevicesCreateDeviceTemplateReferenceResponse DeviceTemplate { get; set; }

        [JsonProperty("properties")]
        public DevicesCreateDevicePropertiesResponse Properties { get; set; }

        [JsonProperty("settings")]
        public DevicesCreateDeviceSettingsResponse Settings { get; set; }

        [JsonProperty("measurements")]
        public DevicesCreateDeviceMeasurementsResponse Measurements { get; set; }
    }

    public class DevicesCreateDeviceTemplateReferenceResponse
    {
        [JsonProperty("id")]
        public string DeviceTemplateId { get; set; }

        [JsonProperty("version")]
        public string DeviceTemplateVersion { get; set; }
    }

    public class DevicesCreateDevicePropertiesResponse
    {
        [JsonProperty("device")]
        public JToken Device { get; set; }

        [JsonProperty("cloud")]
        public JToken Cloud { get; set; }
    }

    public class DevicesCreateDeviceSettingsResponse
    {
        [JsonProperty("device")]
        public JToken Device { get; set; }
    }

    public class DevicesCreateDeviceMeasurementsResponse
    {
        [JsonProperty("telemetry")]
        public JToken Telemetry { get; set; }

        [JsonProperty("events")]
        public JToken Events { get; set; }

        [JsonProperty("states")]
        public JToken States { get; set; }
    }

    public class DevicesCreateBodyInput
    {
        [JsonProperty("id")]
        public string DeviceId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeviceName { get; set; }

        [JsonProperty("simulated", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeviceSimulated { get; set; } = false;

        [JsonProperty("deviceId")]
        public string DeviceConnectionId { get; set; }

        [JsonProperty("deviceTemplate", DefaultValueHandling = DefaultValueHandling.Include)]
        public DevicesCreateDeviceTemplateReference DeviceTemplate { get; set; }
    }

    public class DevicesCreateDeviceTemplateReference
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeviceTemplateId { get; set; }

        [JsonProperty("version", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeviceTemplateVersion { get; set; }
    }

    public class DevicesUpdateBodyInput
    {
        [JsonProperty("name")]
        public string DeviceName { get; set; }

        [JsonProperty("simulated")]
        public bool? DeviceSimulated { get; set; }

        [JsonProperty("deviceId")]
        public string DeviceConnectionId { get; set; }

        [JsonProperty("deviceTemplate")]
        public DeviceTemplateReferenceUpdate DeviceTemplate { get; set; }
    }

    public class DeviceTemplateReferenceUpdate
    {
        [JsonProperty("id")]
        public string DeviceTemplateId { get; set; }

        [JsonProperty("version")]
        public string DeviceTemplateVersion { get; set; }
    }

    public class Action
    {
        [JsonProperty("id")]
        public string ActionId { get; set; }

        [JsonProperty("ruleId")]
        public string Rule { get; set; }

        [JsonProperty("type")]
        public ActionActionTypeType ActionType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActionActionTypeType
    {
        [EnumMember(Value = "flow")]
        Flow
    }

    public class ActionsCreateBodyInput
    {
        [JsonProperty("id")]
        public string ActionId { get; set; }

        [JsonProperty("ruleId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Rule { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal BodyInputActionTypeType ActionType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iotcentral.BodyInputActionTypeType.Flow;

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputActionTypeType
    {
        [EnumMember(Value = "flow")]
        Flow
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iotcentral;

    public partial class WorkflowManagedActions
    {
        public IotcentralActions Iotcentral(string connectionId) => new IotcentralActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IotcentralTriggers Iotcentral(string connectionId) => new IotcentralTriggers(connectionId);
    }
}