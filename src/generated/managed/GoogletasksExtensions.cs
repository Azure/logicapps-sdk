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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users/@me/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskListList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskListEntry> CreateTaskList([WorkflowExpression] Func<string> listtitle)
        {
            SourceExpression.Validate(listtitle, nameof(listtitle), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/users/@me/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var list = new JObject();
                var listpropCount = 0;
                listpropCount++;
                list["title"] = SourceExpressionConverter.ConvertToken(listtitle);
                if (listpropCount > 0)
                {
                    callPayload.Body = list;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskListEntry>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskList> ListTasks([WorkflowExpression] Func<string> taskListId)
        {
            SourceExpression.Validate(taskListId, nameof(taskListId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskObject> CraeteTask([WorkflowExpression] Func<string> taskListId, [WorkflowExpression] Func<string> tasktitle, [WorkflowExpression] Func<string> tasknotes = null, [WorkflowExpression] Func<string> taskdue = null)
        {
            SourceExpression.Validate(taskListId, nameof(taskListId), required: true);
            SourceExpression.Validate(tasktitle, nameof(tasktitle), required: true);
            SourceExpression.Validate(tasknotes, nameof(tasknotes), required: false);
            SourceExpression.Validate(taskdue, nameof(taskdue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskListId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                taskpropCount++;
                task["title"] = SourceExpressionConverter.ConvertToken(tasktitle);
                if (tasknotes != null)
                {
                    task["notes"] = SourceExpressionConverter.ConvertToken(tasknotes);
                    taskpropCount++;
                }

                if (taskdue != null)
                {
                    task["due"] = SourceExpressionConverter.ConvertToken(taskdue);
                    taskpropCount++;
                }

                if (taskpropCount > 0)
                {
                    callPayload.Body = task;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TaskObject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "googletasks")]
        public IBodyWorkflowAction<TaskObject> ListTask([WorkflowExpression] Func<string> taskListId, [WorkflowExpression] Func<string> taskId)
        {
            SourceExpression.Validate(taskListId, nameof(taskListId), required: true);
            SourceExpression.Validate(taskId, nameof(taskId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskListId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskObject>(BuildSourceInput);
        }
    }

    public class GoogletasksTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TaskListList> OnNewTaskList(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger1/users/@me/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<TaskListList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TaskList> OnNewTaskInList([WorkflowExpression] Func<string> taskListId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(taskListId, nameof(taskListId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger2/lists/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<TaskList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TaskList> OnDueTaskInList([WorkflowExpression] Func<string> taskListId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(taskListId, nameof(taskListId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger4/lists/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<TaskList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<TaskList> OnCompletedTaskInList([WorkflowExpression] Func<string> taskListId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(taskListId, nameof(taskListId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/trigger5/lists/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskListId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<TaskList>(BuildSourceInput, triggerName, recurrence);
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