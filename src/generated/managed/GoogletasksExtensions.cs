//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googletasks
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GoogletasksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskListList, ApiConnectionActionConfiguration> ListTaskLists()
        {
            return new DeferredBodyAction<TaskListList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users/@me/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskListList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskListEntry, ApiConnectionActionConfiguration> CreateTaskList(Expression<Func<CreateTaskListInput>> list)
        {
            var __workflow_list = WorkflowExpression.Compile(list, nameof(list), required: true);
            return new DeferredBodyAction<TaskListEntry, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users/@me/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_list);
                return new ApiConnectionAction<TaskListEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskList, ApiConnectionActionConfiguration> ListTasks(Expression<Func<string>> taskListId)
        {
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyAction<TaskList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks", __workflow_taskListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> CraeteTask(Expression<Func<string>> taskListId, Expression<Func<CraeteTaskInput>> task)
        {
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            var __workflow_task = WorkflowExpression.Compile(task, nameof(task), required: true);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks", __workflow_taskListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_task);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> ListTask(Expression<Func<string>> taskListId, Expression<Func<string>> taskId)
        {
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks/{1}", __workflow_taskListId.WithUrlEncoding(1), __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }
    }

    public class GoogletasksTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TaskListList, ApiConnectionTriggerConfiguration> OnNewTaskList(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<TaskListList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger1/users/@me/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<TaskListList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<TaskList, ApiConnectionTriggerConfiguration> OnNewTaskInList(Expression<Func<string>> taskListId, FlowRecurrence recurrence = null)
        {
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyTrigger<TaskList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger2/lists/{0}/tasks", __workflow_taskListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<TaskList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<TaskList, ApiConnectionTriggerConfiguration> OnDueTaskInList(Expression<Func<string>> taskListId, FlowRecurrence recurrence = null)
        {
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyTrigger<TaskList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger4/lists/{0}/tasks", __workflow_taskListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<TaskList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<TaskList, ApiConnectionTriggerConfiguration> OnCompletedTaskInList(Expression<Func<string>> taskListId, FlowRecurrence recurrence = null)
        {
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyTrigger<TaskList, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger5/lists/{0}/tasks", __workflow_taskListId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<TaskList>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class TaskListList
    {
        [JsonProperty("items")]
        public TaskListEntry[] Items { get; set; }
    }

    public class TaskListEntry
    {
        [JsonProperty("id")]
        public string TaskListId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("selfLink")]
        public string HTMLLink { get; set; }

        [JsonProperty("updated")]
        public string UpdatedTime { get; set; }
    }

    public class CreateTaskListInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }
    }

    public class TaskList
    {
        [JsonProperty("items")]
        public TaskObject[] Items { get; set; }
    }

    public class TaskObject
    {
        [JsonProperty("id")]
        public string TaskId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("selfLink")]
        public string HTMLLink { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("due")]
        public string Due { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }
    }

    public class CraeteTaskInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("due")]
        public string Due { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Googletasks;

    public partial class WorkflowManagedActions
    {
        public GoogletasksActions Googletasks(string connectionId) => new GoogletasksActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GoogletasksTriggers Googletasks(string connectionId) => new GoogletasksTriggers(connectionId);
    }
}