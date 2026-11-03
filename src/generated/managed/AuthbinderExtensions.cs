//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Authbinder
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AuthbinderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<EventResponse, ApiConnectionActionConfiguration> LogAgentEvent(Expression<Func<string>> bodytenantId, Expression<Func<string>> bodyagentId, Expression<Func<string>> bodytool, Expression<Func<string>> bodydestination = null, Expression<Func<string>> bodyaction = null, Expression<Func<bool>> bodyapproved = null, Expression<Func<bool>> bodysuccess = null, Expression<Func<string>> bodyuserId = null, Expression<Func<int>> bodydurationMs = null, Expression<Func<string>> bodytimestamp = null)
        {
            var __workflow_bodytenantId = WorkflowExpression.Compile(bodytenantId, nameof(bodytenantId), required: true);
            var __workflow_bodyagentId = WorkflowExpression.Compile(bodyagentId, nameof(bodyagentId), required: true);
            var __workflow_bodytool = WorkflowExpression.Compile(bodytool, nameof(bodytool), required: true);
            var __workflow_bodydestination = WorkflowExpression.Compile(bodydestination, nameof(bodydestination), required: false);
            var __workflow_bodyaction = WorkflowExpression.Compile(bodyaction, nameof(bodyaction), required: false);
            var __workflow_bodyapproved = WorkflowExpression.Compile(bodyapproved, nameof(bodyapproved), required: false);
            var __workflow_bodysuccess = WorkflowExpression.Compile(bodysuccess, nameof(bodysuccess), required: false);
            var __workflow_bodyuserId = WorkflowExpression.Compile(bodyuserId, nameof(bodyuserId), required: false);
            var __workflow_bodydurationMs = WorkflowExpression.Compile(bodydurationMs, nameof(bodydurationMs), required: false);
            var __workflow_bodytimestamp = WorkflowExpression.Compile(bodytimestamp, nameof(bodytimestamp), required: false);
            return new DeferredBodyAction<EventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/events";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tenantId"] = ExpressionConverter.ConvertO(__workflow_bodytenantId);
                bodypropCount++;
                body["agentId"] = ExpressionConverter.ConvertO(__workflow_bodyagentId);
                bodypropCount++;
                body["tool"] = ExpressionConverter.ConvertO(__workflow_bodytool);
                if (__workflow_bodydestination != null)
                {
                    body["destination"] = ExpressionConverter.ConvertO(__workflow_bodydestination);
                    bodypropCount++;
                }

                if (__workflow_bodyaction != null)
                {
                    body["action"] = ExpressionConverter.ConvertO(__workflow_bodyaction);
                    bodypropCount++;
                }

                if (__workflow_bodyapproved != null)
                {
                    body["approved"] = ExpressionConverter.ConvertO(__workflow_bodyapproved);
                    bodypropCount++;
                }

                if (__workflow_bodysuccess != null)
                {
                    body["success"] = ExpressionConverter.ConvertO(__workflow_bodysuccess);
                    bodypropCount++;
                }

                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (__workflow_bodydurationMs != null)
                {
                    body["durationMs"] = ExpressionConverter.ConvertO(__workflow_bodydurationMs);
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

                return new ApiConnectionAction<EventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<BatchResponse, ApiConnectionActionConfiguration> LogAgentEventsBatch(Expression<Func<EventIngest[]>> bodyevents)
        {
            var __workflow_bodyevents = WorkflowExpression.Compile(bodyevents, nameof(bodyevents), required: true);
            return new DeferredBodyAction<BatchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/events/batch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["events"] = ExpressionConverter.ConvertO(__workflow_bodyevents);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<BatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<ConnectionStatus, ApiConnectionActionConfiguration> GetConnectionStatus()
        {
            return new DeferredBodyAction<ConnectionStatus, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/connection-status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConnectionStatus>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<HealthResponse, ApiConnectionActionConfiguration> HealthCheck()
        {
            return new DeferredBodyAction<HealthResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/health";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<HealthResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<ListFindingsResponseItem[], ApiConnectionActionConfiguration> ListFindings(Expression<Func<string>> resolved = null, Expression<Func<string>> suppressed = null)
        {
            var __workflow_resolved = WorkflowExpression.Compile(resolved, nameof(resolved), required: false);
            var __workflow_suppressed = WorkflowExpression.Compile(suppressed, nameof(suppressed), required: false);
            return new DeferredBodyAction<ListFindingsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/findings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_resolved != null)
                    callPayload.Queries["resolved"] = ExpressionConverter.Convert(__workflow_resolved);
                if (__workflow_suppressed != null)
                    callPayload.Queries["suppressed"] = ExpressionConverter.Convert(__workflow_suppressed);
                return new ApiConnectionAction<ListFindingsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<ListReportsResponseItem[], ApiConnectionActionConfiguration> ListReports(Expression<Func<string>> status = null, Expression<Func<string>> reportType = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_reportType = WorkflowExpression.Compile(reportType, nameof(reportType), required: false);
            return new DeferredBodyAction<ListReportsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_reportType != null)
                    callPayload.Queries["report_type"] = ExpressionConverter.Convert(__workflow_reportType);
                return new ApiConnectionAction<ListReportsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "authbinder")]
        public IBodyWorkflowAction<GetReportResponse, ApiConnectionActionConfiguration> GetReport(Expression<Func<string>> reportId)
        {
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: true);
            return new DeferredBodyAction<GetReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/reports/{0}", __workflow_reportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetReportResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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