//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Toodledo
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ToodledoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<TaskObject[], ApiConnectionActionConfiguration> ListTasks(Expression<Func<int>> comp = null)
        {
            var __workflow_comp = WorkflowExpression.Compile(comp, nameof(comp), required: false);
            return new DeferredBodyAction<TaskObject[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> CreateTask(Expression<Func<CreateTaskInput>> task)
        {
            var __workflow_task = WorkflowExpression.Compile(task, nameof(task), required: true);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tasks/add.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_task);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> GetTaskById(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tasks/getById.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<TaskObject, ApiConnectionActionConfiguration> UpdateTask(Expression<Func<UpdateTaskInput>> task)
        {
            var __workflow_task = WorkflowExpression.Compile(task, nameof(task), required: true);
            return new DeferredBodyAction<TaskObject, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/tasks/edit.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_task);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<Folder[], ApiConnectionActionConfiguration> GetFolders()
        {
            return new DeferredBodyAction<Folder[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders/get.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Folder[]>(callPayload);
            });
        }
    }

    public class ToodledoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TaskObject[], ApiConnectionTriggerConfiguration> TrigOnNewTask(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<TaskObject[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/tasks/get.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<TaskObject[]>(callPayload, recurrence: recurrence);
            });
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

    public class CreateTaskInput
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("folder")]
        public int? FolderId { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("duedate")]
        public string DueDate { get; set; }

        [JsonProperty("duetime")]
        public string DueTime { get; set; }
    }

    public class UpdateTaskInput
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

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
        public int? Priority { get; set; }

        [JsonProperty("folder")]
        public int? Folder { get; set; }

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