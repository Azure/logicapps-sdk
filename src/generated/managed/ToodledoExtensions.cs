//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Toodledo
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ToodledoActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        [WorkflowExpressionFactory(nameof(__BuildListTasks))]
        public IBodyWorkflowAction<TaskObject[]> ListTasks([WorkflowExpression] Func<int> comp = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskObject[]> __BuildListTasks(WorkflowExpression<int> comp = null)
        {
            WorkflowExpression.Validate(comp, nameof(comp), required: false);
            return new DeferredBodyAction<TaskObject[]>(() =>
            {
                var apiCallPath = "/tasks/get.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["comp"] = Convert.ToString(-1);
                if (comp != null)
                    callPayload.Queries["comp"] = ExpressionConverter.Convert(comp);
                return new ApiConnectionAction<TaskObject[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTask))]
        public IBodyWorkflowAction<TaskObject> CreateTask([WorkflowExpression] Func<string> tasktitle = null, [WorkflowExpression] Func<int> taskfolderId = null, [WorkflowExpression] Func<int> taskpriority = null, [WorkflowExpression] Func<string> tasknote = null, [WorkflowExpression] Func<string> taskdueDate = null, [WorkflowExpression] Func<string> taskdueTime = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskObject> __BuildCreateTask(WorkflowExpression<string> tasktitle = null, WorkflowExpression<int> taskfolderId = null, WorkflowExpression<int> taskpriority = null, WorkflowExpression<string> tasknote = null, WorkflowExpression<string> taskdueDate = null, WorkflowExpression<string> taskdueTime = null)
        {
            WorkflowExpression.Validate(tasktitle, nameof(tasktitle), required: false);
            WorkflowExpression.Validate(taskfolderId, nameof(taskfolderId), required: false);
            WorkflowExpression.Validate(taskpriority, nameof(taskpriority), required: false);
            WorkflowExpression.Validate(tasknote, nameof(tasknote), required: false);
            WorkflowExpression.Validate(taskdueDate, nameof(taskdueDate), required: false);
            WorkflowExpression.Validate(taskdueTime, nameof(taskdueTime), required: false);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = "/tasks/add.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                if (tasktitle != null)
                {
                    task["title"] = ExpressionConverter.ConvertO(tasktitle);
                    taskpropCount++;
                }

                if (taskfolderId != null)
                {
                    task["folder"] = ExpressionConverter.ConvertO(taskfolderId);
                    taskpropCount++;
                }

                if (taskpriority != null)
                {
                    task["priority"] = ExpressionConverter.ConvertO(taskpriority);
                    taskpropCount++;
                }

                if (tasknote != null)
                {
                    task["note"] = ExpressionConverter.ConvertO(tasknote);
                    taskpropCount++;
                }

                if (taskdueDate != null)
                {
                    task["duedate"] = ExpressionConverter.ConvertO(taskdueDate);
                    taskpropCount++;
                }

                if (taskdueTime != null)
                {
                    task["duetime"] = ExpressionConverter.ConvertO(taskdueTime);
                    taskpropCount++;
                }

                if (taskpropCount > 0)
                {
                    callPayload.Body = task;
                }

                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        [WorkflowExpressionFactory(nameof(__BuildGetTaskById))]
        public IBodyWorkflowAction<TaskObject> GetTaskById([WorkflowExpression] Func<int> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskObject> __BuildGetTaskById(WorkflowExpression<int> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = "/tasks/getById.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateTask))]
        public IBodyWorkflowAction<TaskObject> UpdateTask([WorkflowExpression] Func<int> taskid = null, [WorkflowExpression] Func<string> tasktitle = null, [WorkflowExpression] Func<string> taskcompleted = null, [WorkflowExpression] Func<string> taskdueDate = null, [WorkflowExpression] Func<string> taskdueTime = null, [WorkflowExpression] Func<string> tasknote = null, [WorkflowExpression] Func<int> taskpriority = null, [WorkflowExpression] Func<int> taskfolder = null, [WorkflowExpression] Func<string> taskmodified = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskObject> __BuildUpdateTask(WorkflowExpression<int> taskid = null, WorkflowExpression<string> tasktitle = null, WorkflowExpression<string> taskcompleted = null, WorkflowExpression<string> taskdueDate = null, WorkflowExpression<string> taskdueTime = null, WorkflowExpression<string> tasknote = null, WorkflowExpression<int> taskpriority = null, WorkflowExpression<int> taskfolder = null, WorkflowExpression<string> taskmodified = null)
        {
            WorkflowExpression.Validate(taskid, nameof(taskid), required: false);
            WorkflowExpression.Validate(tasktitle, nameof(tasktitle), required: false);
            WorkflowExpression.Validate(taskcompleted, nameof(taskcompleted), required: false);
            WorkflowExpression.Validate(taskdueDate, nameof(taskdueDate), required: false);
            WorkflowExpression.Validate(taskdueTime, nameof(taskdueTime), required: false);
            WorkflowExpression.Validate(tasknote, nameof(tasknote), required: false);
            WorkflowExpression.Validate(taskpriority, nameof(taskpriority), required: false);
            WorkflowExpression.Validate(taskfolder, nameof(taskfolder), required: false);
            WorkflowExpression.Validate(taskmodified, nameof(taskmodified), required: false);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = "/tasks/edit.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                if (taskid != null)
                {
                    task["id"] = ExpressionConverter.ConvertO(taskid);
                    taskpropCount++;
                }

                if (tasktitle != null)
                {
                    task["title"] = ExpressionConverter.ConvertO(tasktitle);
                    taskpropCount++;
                }

                if (taskcompleted != null)
                {
                    task["completed"] = ExpressionConverter.ConvertO(taskcompleted);
                    taskpropCount++;
                }

                if (taskdueDate != null)
                {
                    task["duedate"] = ExpressionConverter.ConvertO(taskdueDate);
                    taskpropCount++;
                }

                if (taskdueTime != null)
                {
                    task["duetime"] = ExpressionConverter.ConvertO(taskdueTime);
                    taskpropCount++;
                }

                if (tasknote != null)
                {
                    task["note"] = ExpressionConverter.ConvertO(tasknote);
                    taskpropCount++;
                }

                if (taskpriority != null)
                {
                    task["priority"] = ExpressionConverter.ConvertO(taskpriority);
                    taskpropCount++;
                }

                if (taskfolder != null)
                {
                    task["folder"] = ExpressionConverter.ConvertO(taskfolder);
                    taskpropCount++;
                }

                if (taskmodified != null)
                {
                    task["modified"] = ExpressionConverter.ConvertO(taskmodified);
                    taskpropCount++;
                }

                if (taskpropCount > 0)
                {
                    callPayload.Body = task;
                }

                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<Folder[]> GetFolders()
        {
            var apiCallPath = "/folders/get.php";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Folder[]>(callPayload);
        }
    }

    public class ToodledoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TaskObject[]> TrigOnNewTask(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/tasks/get.php";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TaskObject[]>(callPayload, recurrence: recurrence);
        }
    }

    public class TaskObject
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("duedate")]
        public string DueDate { get; set; }

        [JsonProperty("duetime")]
        public string DueTime { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("folder")]
        public int Folder { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }
    }

    public class Folder
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("archived")]
        public int Archived { get; set; }

        [JsonProperty("private")]
        public int Private { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Toodledo;

    public partial class WorkflowManagedActions
    {
        public ToodledoActions Toodledo(string connectionId) => new ToodledoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ToodledoTriggers Toodledo(string connectionId) => new ToodledoTriggers(connectionId);
    }
}