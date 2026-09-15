//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Toodledo
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ToodledoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<TaskObject[]> ListTasks(Expression<Func<int>> comp = null)
        {
            var apiCallPath = "/tasks/get.php";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["comp"] = Convert.ToString(-1);
            if (comp != null)
                callPayload.Queries["comp"] = CSharpExpressionConverter.ConvertO(comp);
            return new ApiConnectionAction<TaskObject[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<TaskObject> CreateTask(Expression<Func<string>> tasktitle = null, Expression<Func<int>> taskfolderId = null, Expression<Func<int>> taskpriority = null, Expression<Func<string>> tasknote = null, Expression<Func<string>> taskdueDate = null, Expression<Func<string>> taskdueTime = null)
        {
            var apiCallPath = "/tasks/add.php";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var task = new JObject();
            var taskpropCount = 0;
            if (tasktitle != null)
            {
                task["title"] = CSharpExpressionConverter.ConvertToken(tasktitle);
                taskpropCount++;
            }

            if (taskfolderId != null)
            {
                task["folder"] = CSharpExpressionConverter.ConvertToken(taskfolderId);
                taskpropCount++;
            }

            if (taskpriority != null)
            {
                task["priority"] = CSharpExpressionConverter.ConvertToken(taskpriority);
                taskpropCount++;
            }

            if (tasknote != null)
            {
                task["note"] = CSharpExpressionConverter.ConvertToken(tasknote);
                taskpropCount++;
            }

            if (taskdueDate != null)
            {
                task["duedate"] = CSharpExpressionConverter.ConvertToken(taskdueDate);
                taskpropCount++;
            }

            if (taskdueTime != null)
            {
                task["duetime"] = CSharpExpressionConverter.ConvertToken(taskdueTime);
                taskpropCount++;
            }

            if (taskpropCount > 0)
            {
                callPayload.Body = task;
            }

            return new ApiConnectionAction<TaskObject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<TaskObject> GetTaskById(Expression<Func<int>> id)
        {
            var apiCallPath = "/tasks/getById.php";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = CSharpExpressionConverter.ConvertO(id);
            return new ApiConnectionAction<TaskObject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<TaskObject> UpdateTask(Expression<Func<int>> taskid = null, Expression<Func<string>> tasktitle = null, Expression<Func<string>> taskcompleted = null, Expression<Func<string>> taskdueDate = null, Expression<Func<string>> taskdueTime = null, Expression<Func<string>> tasknote = null, Expression<Func<int>> taskpriority = null, Expression<Func<int>> taskfolder = null, Expression<Func<string>> taskmodified = null)
        {
            var apiCallPath = "/tasks/edit.php";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var task = new JObject();
            var taskpropCount = 0;
            if (taskid != null)
            {
                task["id"] = CSharpExpressionConverter.ConvertToken(taskid);
                taskpropCount++;
            }

            if (tasktitle != null)
            {
                task["title"] = CSharpExpressionConverter.ConvertToken(tasktitle);
                taskpropCount++;
            }

            if (taskcompleted != null)
            {
                task["completed"] = CSharpExpressionConverter.ConvertToken(taskcompleted);
                taskpropCount++;
            }

            if (taskdueDate != null)
            {
                task["duedate"] = CSharpExpressionConverter.ConvertToken(taskdueDate);
                taskpropCount++;
            }

            if (taskdueTime != null)
            {
                task["duetime"] = CSharpExpressionConverter.ConvertToken(taskdueTime);
                taskpropCount++;
            }

            if (tasknote != null)
            {
                task["note"] = CSharpExpressionConverter.ConvertToken(tasknote);
                taskpropCount++;
            }

            if (taskpriority != null)
            {
                task["priority"] = CSharpExpressionConverter.ConvertToken(taskpriority);
                taskpropCount++;
            }

            if (taskfolder != null)
            {
                task["folder"] = CSharpExpressionConverter.ConvertToken(taskfolder);
                taskpropCount++;
            }

            if (taskmodified != null)
            {
                task["modified"] = CSharpExpressionConverter.ConvertToken(taskmodified);
                taskpropCount++;
            }

            if (taskpropCount > 0)
            {
                callPayload.Body = task;
            }

            return new ApiConnectionAction<TaskObject>(callPayload);
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
        public IBodyWorkflowTrigger<TaskObject[]> TrigOnNewTask(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/tasks/get.php";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<TaskObject[]>(callPayload, triggerName, recurrence);
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