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
        public IBodyWorkflowAction<SendEventResponse, ApiConnectionActionConfiguration> SendEvent(Expression<Func<bodyeventTypeInput>> bodyeventType, Expression<Func<string>> bodytitle, Expression<Func<string>> bodyhost, Expression<Func<bodyseverityInput>> bodyseverity, Expression<Func<string>> bodymessage = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodytimestamp = null)
        {
            var __workflow_bodyeventType = WorkflowExpression.Compile(bodyeventType, nameof(bodyeventType), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyhost = WorkflowExpression.Compile(bodyhost, nameof(bodyhost), required: true);
            var __workflow_bodyseverity = WorkflowExpression.Compile(bodyseverity, nameof(bodyseverity), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            var __workflow_bodytimestamp = WorkflowExpression.Compile(bodytimestamp, nameof(bodytimestamp), required: false);
            return new DeferredBodyAction<SendEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_type"] = ExpressionConverter.ConvertO(__workflow_bodyeventType);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["host"] = ExpressionConverter.ConvertO(__workflow_bodyhost);
                bodypropCount++;
                body["severity"] = ExpressionConverter.ConvertO(__workflow_bodyseverity);
                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (__workflow_bodytimestamp != null)
                {
                    body["timestamp"] = ExpressionConverter.ConvertO(__workflow_bodytimestamp);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyeventTypeInput
    {
        [EnumMember(Value = "alert")]
        Alert,
        [EnumMember(Value = "resolve")]
        Resolve
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyseverityInput
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