//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googletasks
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class GoogletasksActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskListList> ListTaskLists()
        {
            var apiCallPath = "/users/@me/lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskListList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskListEntry> CreateTaskList(Expression<Func<string>> listtitle)
        {
            var __workflow_listtitle = WorkflowExpression.Compile(listtitle, nameof(listtitle), required: true);
            return new DeferredBodyAction<TaskListEntry>(() =>
            {
                var apiCallPath = "/users/@me/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var list = new JObject();
                var listpropCount = 0;
                listpropCount++;
                list["title"] = ExpressionConverter.ConvertO(__workflow_listtitle);
                if (listpropCount > 0)
                {
                    callPayload.Body = list;
                }

                return new ApiConnectionAction<TaskListEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskList> ListTasks(Expression<Func<string>> taskListId)
        {
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyAction<TaskList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskObject> CraeteTask(Expression<Func<string>> taskListId, Expression<Func<string>> tasktitle, Expression<Func<string>> tasknotes = null, Expression<Func<string>> taskdue = null)
        {
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            var __workflow_tasktitle = WorkflowExpression.Compile(tasktitle, nameof(tasktitle), required: true);
            var __workflow_tasknotes = WorkflowExpression.Compile(tasknotes, nameof(tasknotes), required: false);
            var __workflow_taskdue = WorkflowExpression.Compile(taskdue, nameof(taskdue), required: false);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                taskpropCount++;
                task["title"] = ExpressionConverter.ConvertO(__workflow_tasktitle);
                if (__workflow_tasknotes != null)
                {
                    task["notes"] = ExpressionConverter.ConvertO(__workflow_tasknotes);
                    taskpropCount++;
                }

                if (__workflow_taskdue != null)
                {
                    task["due"] = ExpressionConverter.ConvertO(__workflow_taskdue);
                    taskpropCount++;
                }

                if (taskpropCount > 0)
                {
                    callPayload.Body = task;
                }

                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskObject> ListTask(Expression<Func<string>> taskListId, Expression<Func<string>> taskId)
        {
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskListId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }
    }

    public class GoogletasksTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TaskListList> OnNewTaskList(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger1/users/@me/lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TaskListList>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<TaskList> OnNewTaskInList(Expression<Func<string>> taskListId, FlowRecurrence recurrence = null)
        {
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyTrigger<TaskList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger2/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<TaskList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<TaskList> OnCompletedTaskInList(Expression<Func<string>> taskListId, FlowRecurrence recurrence = null)
        {
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyTrigger<TaskList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger3/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<TaskList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<TaskList> OnDueTaskInList(Expression<Func<string>> taskListId, FlowRecurrence recurrence = null)
        {
            var __workflow_taskListId = WorkflowExpression.Compile(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyTrigger<TaskList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger4/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskListId, 1));
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
        public string TaskListID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("selfLink")]
        public string HTMLLink { get; set; }

        [JsonProperty("updated")]
        public string UpdatedTime { get; set; }
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
