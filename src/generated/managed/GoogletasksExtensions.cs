//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Googletasks
{
    using System.Linq.Expressions;
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
        public IBodyWorkflowAction<TaskListEntry> CreateTaskList(Expression<Func<string>> listtitle)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskList> ListTasks(Expression<Func<string>> taskListId)
        {
            var apiCallPath = String.Format("/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskObject> CraeteTask(Expression<Func<string>> taskListId, Expression<Func<string>> tasktitle, Expression<Func<string>> tasknotes = null, Expression<Func<string>> taskdue = null)
        {
            var apiCallPath = String.Format("/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskObject> ListTask(Expression<Func<string>> taskListId, Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/lists/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1), ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskObject>(callPayload);
        }
    }

    public class GoogletasksTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<TaskListList> OnNewTaskList(string triggerName = null)
        {
            var apiCallPath = "/trigger1/users/@me/lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TaskListList>(callPayload);
        }

        public IOutputWorkflowTrigger<TaskList> OnNewTaskInList(Expression<Func<string>> taskListId, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger2/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TaskList>(callPayload);
        }

        public IOutputWorkflowTrigger<TaskList> OnCompletedTaskInList(Expression<Func<string>> taskListId, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger3/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TaskList>(callPayload);
        }

        public IOutputWorkflowTrigger<TaskList> OnDueTaskInList(Expression<Func<string>> taskListId, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger4/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TaskList>(callPayload);
        }

        public IOutputWorkflowTrigger<TaskList> OnCompletedTaskInListV2(Expression<Func<string>> taskListId, string triggerName = null)
        {
            var apiCallPath = String.Format("/trigger5/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(taskListId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TaskList>(callPayload);
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