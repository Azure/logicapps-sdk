//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clockifyip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClockifyipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clockifyip")]
        [WorkflowExpressionFactory(nameof(__BuildGetClients))]
        public IBodyWorkflowAction<GetClientsV1ResponseItem[]> GetClients([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetClientsV1ResponseItem[]> __BuildGetClients(WorkflowExpression<string> workspaceId, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredBodyAction<GetClientsV1ResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/workspaces/{0}/clients", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction<GetClientsV1ResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clockifyip")]
        [WorkflowExpressionFactory(nameof(__BuildGetTimeEntriesForUser))]
        public IBodyWorkflowAction<GetTimeEntriesForUserV1ResponseItem[]> GetTimeEntriesForUser([WorkflowExpression] Func<string> workspaceId, [WorkflowExpression] Func<string> userId, [WorkflowExpression] Func<string> start = null, [WorkflowExpression] Func<string> end = null, [WorkflowExpression] Func<string> project = null, [WorkflowExpression] Func<string> task = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> pageSize = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTimeEntriesForUserV1ResponseItem[]> __BuildGetTimeEntriesForUser(WorkflowExpression<string> workspaceId, WorkflowExpression<string> userId, WorkflowExpression<string> start = null, WorkflowExpression<string> end = null, WorkflowExpression<string> project = null, WorkflowExpression<string> task = null, WorkflowExpression<int> page = null, WorkflowExpression<int> pageSize = null)
        {
            WorkflowExpression.Validate(workspaceId, nameof(workspaceId), required: true);
            WorkflowExpression.Validate(userId, nameof(userId), required: true);
            WorkflowExpression.Validate(start, nameof(start), required: false);
            WorkflowExpression.Validate(end, nameof(end), required: false);
            WorkflowExpression.Validate(project, nameof(project), required: false);
            WorkflowExpression.Validate(task, nameof(task), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<GetTimeEntriesForUserV1ResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/workspaces/{0}/user/{1}/time-entries", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(start);
                if (end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(end);
                if (project != null)
                    callPayload.Queries["project"] = ExpressionConverter.Convert(project);
                if (task != null)
                    callPayload.Queries["task"] = ExpressionConverter.Convert(task);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (pageSize != null)
                    callPayload.Queries["page-size"] = ExpressionConverter.Convert(pageSize);
                return new ApiConnectionAction<GetTimeEntriesForUserV1ResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clockifyip")]
        public IBodyWorkflowAction<GetWorkspacesV1ResponseItem[]> GetWorkspaces()
        {
            var apiCallPath = "/v1/workspaces";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetWorkspacesV1ResponseItem[]>(callPayload);
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