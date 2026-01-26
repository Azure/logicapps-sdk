//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iotcentral
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IotcentralActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iotcentral")]
        public IWorkflowAction DeviceCommandsRun(Expression<Func<string>> applicationId, Expression<Func<string>> deviceId, Expression<Func<string>> deviceCommandId, Expression<Func<object>> body = null, Expression<Func<string>> deviceTemplateDisplayId = null)
        {
            var apiCallPath = String.Format("/applications/{0}/devices/{1}/commands/{2}", ExpressionConverter.ConvertWithUrlEncoding(applicationId, 1), ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1), ExpressionConverter.ConvertWithUrlEncoding(deviceCommandId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (deviceTemplateDisplayId != null)
                callPayload.Queries["deviceTemplateDisplayId"] = ExpressionConverter.Convert(deviceTemplateDisplayId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iotcentral")]
        public IBodyWorkflowAction<Device> DevicesGet(Expression<Func<string>> applicationId, Expression<Func<string>> deviceId, Expression<Func<string>> deviceTemplateDisplayId = null)
        {
            var apiCallPath = String.Format("/applications/{0}/devices/{1}", ExpressionConverter.ConvertWithUrlEncoding(applicationId, 1), ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (deviceTemplateDisplayId != null)
                callPayload.Queries["deviceTemplateDisplayId"] = ExpressionConverter.Convert(deviceTemplateDisplayId);
            return new ApiConnectionAction<Device>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iotcentral")]
        public IBodyWorkflowAction<Device> DevicesUpdate(Expression<Func<string>> applicationId, Expression<Func<string>> deviceId, Expression<Func<bodyInput>> body = null, Expression<Func<string>> deviceTemplateDisplayId = null)
        {
            var apiCallPath = String.Format("/applications/{0}/devices/{1}", ExpressionConverter.ConvertWithUrlEncoding(applicationId, 1), ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (deviceTemplateDisplayId != null)
                callPayload.Queries["deviceTemplateDisplayId"] = ExpressionConverter.Convert(deviceTemplateDisplayId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<Device>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iotcentral")]
        public IWorkflowAction DevicesRemove(Expression<Func<string>> applicationId, Expression<Func<string>> deviceId)
        {
            var apiCallPath = String.Format("/applications/{0}/devices/{1}", ExpressionConverter.ConvertWithUrlEncoding(applicationId, 1), ExpressionConverter.ConvertWithUrlEncoding(deviceId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class IotcentralTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<Action> ActionsCreate(Expression<Func<string>> applicationId, Expression<Func<string>> bodyrule, Expression<Func<string>> bodyactionID = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/applications/{0}/actions/", ExpressionConverter.ConvertWithUrlEncoding(applicationId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyactionID != null)
            {
                body["id"] = ExpressionConverter.ConvertO(bodyactionID);
                bodypropCount++;
            }

            bodypropCount++;
            body["ruleId"] = ExpressionConverter.ConvertO(bodyrule);
            body["type"] = "flow";
            bodypropCount++;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<Action>(callPayload, triggerName, recurrence);
        }
    }

    public class Device
    {
        [JsonProperty("id")]
        public string DeviceID { get; set; }

        [JsonProperty("name")]
        public string DeviceName { get; set; }

        [JsonProperty("simulated")]
        public bool DeviceSimulated { get; set; }

        [JsonProperty("deviceId")]
        public string DeviceConnectionID { get; set; }

        [JsonProperty("deviceTemplate")]
        public DeviceTemplateReference DeviceTemplate { get; set; }

        [JsonProperty("properties")]
        public DeviceProperties Properties { get; set; }

        [JsonProperty("settings")]
        public DeviceSettings Settings { get; set; }

        [JsonProperty("measurements")]
        public DeviceMeasurements Measurements { get; set; }
    }

    public class DeviceTemplateReference
    {
        [JsonProperty("id")]
        public string DeviceTemplateID { get; set; }

        [JsonProperty("version")]
        public string DeviceTemplateVersion { get; set; }
    }

    public class DeviceProperties
    {
        [JsonProperty("device")]
        public JToken Device { get; set; }

        [JsonProperty("cloud")]
        public JToken Cloud { get; set; }
    }

    public class DeviceSettings
    {
        [JsonProperty("device")]
        public JToken Device { get; set; }
    }

    public class DeviceMeasurements
    {
        [JsonProperty("telemetry")]
        public JToken Telemetry { get; set; }

        [JsonProperty("events")]
        public JToken Events { get; set; }

        [JsonProperty("states")]
        public JToken States { get; set; }
    }

    public class bodyInput
    {
        [JsonProperty("name")]
        public string DeviceName { get; set; }

        [JsonProperty("simulated")]
        public bool DeviceSimulated { get; set; }

        [JsonProperty("deviceId")]
        public string DeviceConnectionID { get; set; }

        [JsonProperty("deviceTemplate")]
        public DeviceTemplateReferenceUpdate DeviceTemplate { get; set; }

        [JsonProperty("properties")]
        public DevicePropertiesUpdate Properties { get; set; }

        [JsonProperty("settings")]
        public DeviceSettingsUpdate Settings { get; set; }
    }

    public class DeviceTemplateReferenceUpdate
    {
        [JsonProperty("id")]
        public string DeviceTemplateID { get; set; }

        [JsonProperty("version")]
        public string DeviceTemplateVersion { get; set; }
    }

    public class DevicePropertiesUpdate
    {
        [JsonProperty("cloud")]
        public JToken Cloud { get; set; }
    }

    public class DeviceSettingsUpdate
    {
        [JsonProperty("device")]
        public JToken Device { get; set; }
    }

    public class Action
    {
        [JsonProperty("id")]
        public string ActionID { get; set; }

        [JsonProperty("ruleId")]
        public string Rule { get; set; }

        [JsonProperty("type")]
        public ActionActionTypeType ActionType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public enum ActionActionTypeType
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