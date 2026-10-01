//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Itoc360
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Itoc360Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "itoc360")]
        public IBodyWorkflowAction<SendEventResponse> SendEvent([WorkflowExpression] Func<bodyeventTypeInput> bodyeventType, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyhost, [WorkflowExpression] Func<bodyseverityInput> bodyseverity, [WorkflowExpression] Func<string> bodymessage = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodytimestamp = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event_type"] = SourceExpressionConverter.Convert(bodyeventType);
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
                body["host"] = SourceExpressionConverter.ConvertToken(bodyhost);
                bodypropCount++;
                body["severity"] = SourceExpressionConverter.Convert(bodyseverity);
                if (bodymessage != null)
                {
                    body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                if (bodytimestamp != null)
                {
                    body["timestamp"] = SourceExpressionConverter.ConvertToken(bodytimestamp);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendEventResponse>(BuildSourceInput);
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

    public enum bodyeventTypeInput
    {
        [EnumMember(Value = "alert")]
        Alert,
        [EnumMember(Value = "resolve")]
        Resolve
    }

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