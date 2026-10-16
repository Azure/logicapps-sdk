//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Toodledo
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ToodledoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<TaskObject[]> ListTasks(Expression<Func<int>> comp = null)
        {
            var __workflow_comp = WorkflowExpression.Compile(comp, nameof(comp), required: false);
            return new DeferredBodyAction<TaskObject[]>(() =>
            {
                var apiCallPath = "/tasks/get.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["comp"] = Convert.ToString(-1);
                if (__workflow_comp != null)
                    callPayload.Queries["comp"] = ExpressionConverter.Convert(__workflow_comp);
                return new ApiConnectionAction<TaskObject[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<TaskObject> CreateTask(Expression<Func<string>> tasktitle = null, Expression<Func<int>> taskfolderId = null, Expression<Func<int>> taskpriority = null, Expression<Func<string>> tasknote = null, Expression<Func<string>> taskdueDate = null, Expression<Func<string>> taskdueTime = null)
        {
            var __workflow_tasktitle = WorkflowExpression.Compile(tasktitle, nameof(tasktitle), required: false);
            var __workflow_taskfolderId = WorkflowExpression.Compile(taskfolderId, nameof(taskfolderId), required: false);
            var __workflow_taskpriority = WorkflowExpression.Compile(taskpriority, nameof(taskpriority), required: false);
            var __workflow_tasknote = WorkflowExpression.Compile(tasknote, nameof(tasknote), required: false);
            var __workflow_taskdueDate = WorkflowExpression.Compile(taskdueDate, nameof(taskdueDate), required: false);
            var __workflow_taskdueTime = WorkflowExpression.Compile(taskdueTime, nameof(taskdueTime), required: false);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = "/tasks/add.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                if (__workflow_tasktitle != null)
                {
                    task["title"] = ExpressionConverter.ConvertO(__workflow_tasktitle);
                    taskpropCount++;
                }

                if (__workflow_taskfolderId != null)
                {
                    task["folder"] = ExpressionConverter.ConvertO(__workflow_taskfolderId);
                    taskpropCount++;
                }

                if (__workflow_taskpriority != null)
                {
                    task["priority"] = ExpressionConverter.ConvertO(__workflow_taskpriority);
                    taskpropCount++;
                }

                if (__workflow_tasknote != null)
                {
                    task["note"] = ExpressionConverter.ConvertO(__workflow_tasknote);
                    taskpropCount++;
                }

                if (__workflow_taskdueDate != null)
                {
                    task["duedate"] = ExpressionConverter.ConvertO(__workflow_taskdueDate);
                    taskpropCount++;
                }

                if (__workflow_taskdueTime != null)
                {
                    task["duetime"] = ExpressionConverter.ConvertO(__workflow_taskdueTime);
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
        public IBodyWorkflowAction<TaskObject> GetTaskById(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = "/tasks/getById.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<TaskObject> UpdateTask(Expression<Func<int>> taskid = null, Expression<Func<string>> tasktitle = null, Expression<Func<string>> taskcompleted = null, Expression<Func<string>> taskdueDate = null, Expression<Func<string>> taskdueTime = null, Expression<Func<string>> tasknote = null, Expression<Func<int>> taskpriority = null, Expression<Func<int>> taskfolder = null, Expression<Func<string>> taskmodified = null)
        {
            var __workflow_taskid = WorkflowExpression.Compile(taskid, nameof(taskid), required: false);
            var __workflow_tasktitle = WorkflowExpression.Compile(tasktitle, nameof(tasktitle), required: false);
            var __workflow_taskcompleted = WorkflowExpression.Compile(taskcompleted, nameof(taskcompleted), required: false);
            var __workflow_taskdueDate = WorkflowExpression.Compile(taskdueDate, nameof(taskdueDate), required: false);
            var __workflow_taskdueTime = WorkflowExpression.Compile(taskdueTime, nameof(taskdueTime), required: false);
            var __workflow_tasknote = WorkflowExpression.Compile(tasknote, nameof(tasknote), required: false);
            var __workflow_taskpriority = WorkflowExpression.Compile(taskpriority, nameof(taskpriority), required: false);
            var __workflow_taskfolder = WorkflowExpression.Compile(taskfolder, nameof(taskfolder), required: false);
            var __workflow_taskmodified = WorkflowExpression.Compile(taskmodified, nameof(taskmodified), required: false);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = "/tasks/edit.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                if (__workflow_taskid != null)
                {
                    task["id"] = ExpressionConverter.ConvertO(__workflow_taskid);
                    taskpropCount++;
                }

                if (__workflow_tasktitle != null)
                {
                    task["title"] = ExpressionConverter.ConvertO(__workflow_tasktitle);
                    taskpropCount++;
                }

                if (__workflow_taskcompleted != null)
                {
                    task["completed"] = ExpressionConverter.ConvertO(__workflow_taskcompleted);
                    taskpropCount++;
                }

                if (__workflow_taskdueDate != null)
                {
                    task["duedate"] = ExpressionConverter.ConvertO(__workflow_taskdueDate);
                    taskpropCount++;
                }

                if (__workflow_taskdueTime != null)
                {
                    task["duetime"] = ExpressionConverter.ConvertO(__workflow_taskdueTime);
                    taskpropCount++;
                }

                if (__workflow_tasknote != null)
                {
                    task["note"] = ExpressionConverter.ConvertO(__workflow_tasknote);
                    taskpropCount++;
                }

                if (__workflow_taskpriority != null)
                {
                    task["priority"] = ExpressionConverter.ConvertO(__workflow_taskpriority);
                    taskpropCount++;
                }

                if (__workflow_taskfolder != null)
                {
                    task["folder"] = ExpressionConverter.ConvertO(__workflow_taskfolder);
                    taskpropCount++;
                }

                if (__workflow_taskmodified != null)
                {
                    task["modified"] = ExpressionConverter.ConvertO(__workflow_taskmodified);
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
