//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clockifyip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClockifyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clockifyip")]
        public IBodyWorkflowAction<GetClientsV1ResponseItem[]> GetClients([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<bool> archived = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/workspaces/{0}/clients", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction<GetClientsV1ResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clockifyip")]
        public IBodyWorkflowAction<GetTimeEntriesForUserV1ResponseItem[]> GetTimeEntriesForUser([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> project = null, [WorkflowExpression] Func<string> task = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/workspaces/{0}/user/{1}/time-entries", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workspaceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (start != null)
                    callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                if (end != null)
                    callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                if (project != null)
                    callPayload.Queries["project"] = SourceExpressionConverter.ConvertO(project);
                if (task != null)
                    callPayload.Queries["task"] = SourceExpressionConverter.ConvertO(task);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (pageSize != null)
                    callPayload.Queries["page-size"] = SourceExpressionConverter.ConvertO(pageSize);
                return callPayload;
            }

            return new ApiConnectionAction<GetTimeEntriesForUserV1ResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clockifyip")]
        public IBodyWorkflowAction<GetWorkspacesV1ResponseItem[]> GetWorkspaces()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/workspaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetWorkspacesV1ResponseItem[]>(BuildSourceInput);
        }
    }

    public class ClockifyipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetClientsV1ResponseItem
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }
    }

    public class GetTimeEntriesForUserV1ResponseItem
    {
        [JsonProperty("id")]
        public string TimeEntryId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("projectId")]
        public string ProjectId { get; set; }

        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("workspaceId")]
        public string WorkspaceId { get; set; }

        [JsonProperty("timeInterval")]
        public GetTimeEntriesForUserV1ResponseItemTimeIntervalType TimeInterval { get; set; }
    }

    public class GetTimeEntriesForUserV1ResponseItemTimeIntervalType
    {
        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("end")]
        public string EndTime { get; set; }

        [JsonProperty("start")]
        public string StartTime { get; set; }
    }

    public class GetWorkspacesV1ResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Clockifyip;

    public partial class WorkflowManagedActions
    {
        public ClockifyipActions Clockifyip(string connectionId) => new ClockifyipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ClockifyipTriggers Clockifyip(string connectionId) => new ClockifyipTriggers(connectionId);
    }
}