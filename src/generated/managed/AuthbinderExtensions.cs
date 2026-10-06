//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Authbinder
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AuthbinderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<EventResponse> LogAgentEvent([WorkflowExpression] Func<string> bodytenantId, [WorkflowExpression] Func<string> bodyagentId, [WorkflowExpression] Func<string> bodytool, [WorkflowExpression] Func<string> bodydestination = null, [WorkflowExpression] Func<string> bodyaction = null, [WorkflowExpression] Func<bool> bodyapproved = null, [WorkflowExpression] Func<bool> bodysuccess = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<int> bodydurationMs = null, [WorkflowExpression] Func<string> bodytimestamp = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tenantId"] = SourceExpressionConverter.ConvertToken(bodytenantId);
                bodypropCount++;
                body["agentId"] = SourceExpressionConverter.ConvertToken(bodyagentId);
                bodypropCount++;
                body["tool"] = SourceExpressionConverter.ConvertToken(bodytool);
                if (bodydestination != null)
                {
                    body["destination"] = SourceExpressionConverter.ConvertToken(bodydestination);
                    bodypropCount++;
                }

                if (bodyaction != null)
                {
                    body["action"] = SourceExpressionConverter.ConvertToken(bodyaction);
                    bodypropCount++;
                }

                if (bodyapproved != null)
                {
                    body["approved"] = SourceExpressionConverter.ConvertToken(bodyapproved);
                    bodypropCount++;
                }

                if (bodysuccess != null)
                {
                    body["success"] = SourceExpressionConverter.ConvertToken(bodysuccess);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodydurationMs != null)
                {
                    body["durationMs"] = SourceExpressionConverter.ConvertToken(bodydurationMs);
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

            return new ApiConnectionAction<EventResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<BatchResponse> LogAgentEventsBatch([WorkflowExpression] Func<EventIngest[]> bodyevents)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/events/batch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["events"] = SourceExpressionConverter.ConvertToken(bodyevents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BatchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<ConnectionStatus> GetConnectionStatus()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/connection-status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConnectionStatus>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<HealthResponse> HealthCheck()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/health";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<HealthResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<ListFindingsResponseItem[]> ListFindings([WorkflowExpression] Func<string> resolved = null, [WorkflowExpression] Func<string> suppressed = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/findings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (resolved != null)
                    callPayload.Queries["resolved"] = SourceExpressionConverter.ConvertO(resolved);
                if (suppressed != null)
                    callPayload.Queries["suppressed"] = SourceExpressionConverter.ConvertO(suppressed);
                return callPayload;
            }

            return new ApiConnectionAction<ListFindingsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<ListReportsResponseItem[]> ListReports([WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> reportType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (reportType != null)
                    callPayload.Queries["report_type"] = SourceExpressionConverter.ConvertO(reportType);
                return callPayload;
            }

            return new ApiConnectionAction<ListReportsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<GetReportResponse> GetReport([WorkflowExpression] Func<string> reportId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/reports/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetReportResponse>(BuildSourceInput);
        }
    }

    public class AuthbinderTriggers([ConnectionName] string connectionId)
    {
    }

    public class EventResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("agentRef")]
        public string AgentRef { get; set; }

        [JsonProperty("toolName")]
        public string ToolName { get; set; }

        [JsonProperty("riskLevel")]
        public EventResponseRiskLevelType RiskLevel { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public enum EventResponseRiskLevelType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "critical")]
        Critical
    }

    public class BatchResponse
    {
        [JsonProperty("ingested")]
        public int Ingested { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("errors")]
        public JToken[] Errors { get; set; }
    }

    public class EventIngest
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("agentId")]
        public string AgentId { get; set; }

        [JsonProperty("tool")]
        public string Tool { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("approved")]
        public bool Approved { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("durationMs")]
        public int DurationMs { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class ConnectionStatus
    {
        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("connected")]
        public bool Connected { get; set; }

        [JsonProperty("eventsReceived")]
        public int EventsReceived { get; set; }

        [JsonProperty("lastSeen")]
        public string LastSeen { get; set; }

        [JsonProperty("firstSeen")]
        public string FirstSeen { get; set; }
    }

    public class HealthResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class ListFindingsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("severity")]
        public string Severity { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("agentRef")]
        public string AgentRef { get; set; }

        [JsonProperty("toolName")]
        public string ToolName { get; set; }

        [JsonProperty("evidence")]
        public ListFindingsResponseItemEvidenceType Evidence { get; set; }

        [JsonProperty("recommendation")]
        public string Recommendation { get; set; }

        [JsonProperty("analystNote")]
        public string AnalystNote { get; set; }

        [JsonProperty("reviewed")]
        public bool Reviewed { get; set; }

        [JsonProperty("suppressed")]
        public bool Suppressed { get; set; }

        [JsonProperty("resolved")]
        public bool Resolved { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
    }

    public class ListFindingsResponseItemEvidenceType
    {
        [JsonProperty("eventId")]
        public string EventId { get; set; }

        [JsonProperty("matchedKeyNames")]
        public string[] MatchedKeyNames { get; set; }
    }

    public class ListReportsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reportType")]
        public string ReportType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("blobUrl")]
        public string BlobUrl { get; set; }

        [JsonProperty("analystNotes")]
        public string AnalystNotes { get; set; }

        [JsonProperty("analystApproved")]
        public bool AnalystApproved { get; set; }

        [JsonProperty("analystApprovedAt")]
        public string AnalystApprovedAt { get; set; }

        [JsonProperty("deliveredAt")]
        public string DeliveredAt { get; set; }

        [JsonProperty("generatedAt")]
        public string GeneratedAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class GetReportResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reportType")]
        public string ReportType { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("blobUrl")]
        public string BlobUrl { get; set; }

        [JsonProperty("analystNotes")]
        public string AnalystNotes { get; set; }

        [JsonProperty("analystApproved")]
        public bool AnalystApproved { get; set; }

        [JsonProperty("analystApprovedAt")]
        public string AnalystApprovedAt { get; set; }

        [JsonProperty("deliveredAt")]
        public string DeliveredAt { get; set; }

        [JsonProperty("generatedAt")]
        public string GeneratedAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Authbinder;

    public partial class WorkflowManagedActions
    {
        public AuthbinderActions Authbinder(string connectionId) => new AuthbinderActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AuthbinderTriggers Authbinder(string connectionId) => new AuthbinderTriggers(connectionId);
    }
}