//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Itoc360
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Itoc360Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "itoc360")]
        public IBodyWorkflowAction<SendEventResponse, ApiConnectionActionConfiguration> SendEvent(Expression<Func<SendEventInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendEventResponse>(callPayload);
            });
        }
    }

    public class Itoc360Triggers([ConnectionName] string connectionId)
    {
    }

    public class SendEventResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("payload")]
        public JToken Payload { get; set; }

        [JsonProperty("tenant_id")]
        public string TenantId { get; set; }

        [JsonProperty("provider_id")]
        public int ProviderId { get; set; }

        [JsonProperty("source_id")]
        public string SourceId { get; set; }

        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }
    }

    public class SendEventInput
    {
        [JsonProperty("event_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendEventInputEventTypeType EventType { get; set; } = SendEventInputEventTypeType.Alert;

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("host", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Host { get; set; }

        [JsonProperty("severity", DefaultValueHandling = DefaultValueHandling.Include)]
        public SendEventInputSeverityType Severity { get; set; } = SendEventInputSeverityType.Medium;

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendEventInputEventTypeType
    {
        [EnumMember(Value = "alert")]
        Alert,
        [EnumMember(Value = "resolve")]
        Resolve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendEventInputSeverityType
    {
        [EnumMember(Value = "critical")]
        Critical,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "low")]
        Low
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Itoc360;

    public partial class WorkflowManagedActions
    {
        public Itoc360Actions Itoc360(string connectionId) => new Itoc360Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Itoc360Triggers Itoc360(string connectionId) => new Itoc360Triggers(connectionId);
    }
}