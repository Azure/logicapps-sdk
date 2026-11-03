//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clockifyip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClockifyipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clockifyip")]
        public IBodyWorkflowAction<GetClientsV1ResponseItem[], ApiConnectionActionConfiguration> GetClients(Expression<Func<string>> workspaceId, Expression<Func<bool>> archived = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredBodyAction<GetClientsV1ResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/workspaces/{0}/clients", __workflow_workspaceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction<GetClientsV1ResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clockifyip")]
        public IBodyWorkflowAction<GetTimeEntriesForUserV1ResponseItem[], ApiConnectionActionConfiguration> GetTimeEntriesForUser(Expression<Func<string>> workspaceId, Expression<Func<string>> userId, Expression<Func<string>> start = null, Expression<Func<string>> end = null, Expression<Func<string>> project = null, Expression<Func<string>> task = null, Expression<Func<int>> page = null, Expression<Func<int>> pageSize = null)
        {
            var __workflow_workspaceId = WorkflowExpression.Compile(workspaceId, nameof(workspaceId), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            var __workflow_start = WorkflowExpression.Compile(start, nameof(start), required: false);
            var __workflow_end = WorkflowExpression.Compile(end, nameof(end), required: false);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: false);
            var __workflow_task = WorkflowExpression.Compile(task, nameof(task), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_pageSize = WorkflowExpression.Compile(pageSize, nameof(pageSize), required: false);
            return new DeferredBodyAction<GetTimeEntriesForUserV1ResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/workspaces/{0}/user/{1}/time-entries", __workflow_workspaceId.WithUrlEncoding(1), __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_start != null)
                    callPayload.Queries["start"] = ExpressionConverter.Convert(__workflow_start);
                if (__workflow_end != null)
                    callPayload.Queries["end"] = ExpressionConverter.Convert(__workflow_end);
                if (__workflow_project != null)
                    callPayload.Queries["project"] = ExpressionConverter.Convert(__workflow_project);
                if (__workflow_task != null)
                    callPayload.Queries["task"] = ExpressionConverter.Convert(__workflow_task);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_pageSize != null)
                    callPayload.Queries["page-size"] = ExpressionConverter.Convert(__workflow_pageSize);
                return new ApiConnectionAction<GetTimeEntriesForUserV1ResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clockifyip")]
        public IBodyWorkflowAction<GetWorkspacesV1ResponseItem[], ApiConnectionActionConfiguration> GetWorkspaces()
        {
            return new DeferredBodyAction<GetWorkspacesV1ResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/workspaces";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetWorkspacesV1ResponseItem[]>(callPayload);
            });
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