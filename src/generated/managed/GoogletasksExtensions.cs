//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googletasks
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

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
        [WorkflowExpressionFactory(nameof(__BuildCreateTaskList))]
        public IBodyWorkflowAction<TaskListEntry> CreateTaskList([WorkflowExpression] Func<string> listtitle)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskListEntry> __BuildCreateTaskList(WorkflowExpression<string> listtitle)
        {
            WorkflowExpression.Validate(listtitle, nameof(listtitle), required: true);
            return new DeferredBodyAction<TaskListEntry>(() =>
            {
                var apiCallPath = "/users/@me/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var list = new JObject();
                var listpropCount = 0;
                listpropCount++;
                list["title"] = ExpressionConverter.ConvertO(listtitle);
                if (listpropCount > 0)
                {
                    callPayload.Body = list;
                }

                return new ApiConnectionAction<TaskListEntry>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        [WorkflowExpressionFactory(nameof(__BuildListTasks))]
        public IBodyWorkflowAction<TaskList> ListTasks([WorkflowExpression] Func<string> taskListId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskList> __BuildListTasks(WorkflowExpression<string> taskListId)
        {
            WorkflowExpression.Validate(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyAction<TaskList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        [WorkflowExpressionFactory(nameof(__BuildCraeteTask))]
        public IBodyWorkflowAction<TaskObject> CraeteTask([WorkflowExpression] Func<string> taskListId, [WorkflowExpression] Func<string> tasktitle, [WorkflowExpression] Func<string> tasknotes = null, [WorkflowExpression] Func<string> taskdue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskObject> __BuildCraeteTask(WorkflowExpression<string> taskListId, WorkflowExpression<string> tasktitle, WorkflowExpression<string> tasknotes = null, WorkflowExpression<string> taskdue = null)
        {
            WorkflowExpression.Validate(taskListId, nameof(taskListId), required: true);
            WorkflowExpression.Validate(tasktitle, nameof(tasktitle), required: true);
            WorkflowExpression.Validate(tasknotes, nameof(tasknotes), required: false);
            WorkflowExpression.Validate(taskdue, nameof(taskdue), required: false);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                taskpropCount++;
                task["title"] = ExpressionConverter.ConvertO(tasktitle);
                if (tasknotes != null)
                {
                    task["notes"] = ExpressionConverter.ConvertO(tasknotes);
                    taskpropCount++;
                }

                if (taskdue != null)
                {
                    task["due"] = ExpressionConverter.ConvertO(taskdue);
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
        [WorkflowExpressionFactory(nameof(__BuildListTask))]
        public IBodyWorkflowAction<TaskObject> ListTask([WorkflowExpression] Func<string> taskListId, [WorkflowExpression] Func<string> taskId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskObject> __BuildListTask(WorkflowExpression<string> taskListId, WorkflowExpression<string> taskId)
        {
            WorkflowExpression.Validate(taskListId, nameof(taskListId), required: true);
            WorkflowExpression.Validate(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1), ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
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

        [WorkflowExpressionFactory(nameof(__BuildOnNewTaskInList))]
        public IBodyWorkflowTrigger<TaskList> OnNewTaskInList([WorkflowExpression] Func<string> taskListId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TaskList> __BuildOnNewTaskInList(WorkflowExpression<string> taskListId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyTrigger<TaskList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger2/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<TaskList>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnCompletedTaskInList))]
        public IBodyWorkflowTrigger<TaskList> OnCompletedTaskInList([WorkflowExpression] Func<string> taskListId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TaskList> __BuildOnCompletedTaskInList(WorkflowExpression<string> taskListId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyTrigger<TaskList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger3/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<TaskList>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnDueTaskInList))]
        public IBodyWorkflowTrigger<TaskList> OnDueTaskInList([WorkflowExpression] Func<string> taskListId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<TaskList> __BuildOnDueTaskInList(WorkflowExpression<string> taskListId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(taskListId, nameof(taskListId), required: true);
            return new DeferredBodyTrigger<TaskList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger4/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
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