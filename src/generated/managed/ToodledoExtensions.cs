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
        public IBodyWorkflowAction<TaskObject[]> ListTasks([WorkflowExpression] Func<int> comp = null)
        {
            SourceExpression.Validate(comp, nameof(comp), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tasks/get.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["comp"] = Convert.ToString(-1);
                if (comp != null)
                    callPayload.Queries["comp"] = SourceExpressionConverter.ConvertO(comp);
                return callPayload;
            }

            return new ApiConnectionAction<TaskObject[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<TaskObject> CreateTask([WorkflowExpression] Func<string> tasktitle = null, [WorkflowExpression] Func<int> taskfolderId = null, [WorkflowExpression] Func<int> taskpriority = null, [WorkflowExpression] Func<string> tasknote = null, [WorkflowExpression] Func<string> taskdueDate = null, [WorkflowExpression] Func<string> taskdueTime = null)
        {
            SourceExpression.Validate(tasktitle, nameof(tasktitle), required: false);
            SourceExpression.Validate(taskfolderId, nameof(taskfolderId), required: false);
            SourceExpression.Validate(taskpriority, nameof(taskpriority), required: false);
            SourceExpression.Validate(tasknote, nameof(tasknote), required: false);
            SourceExpression.Validate(taskdueDate, nameof(taskdueDate), required: false);
            SourceExpression.Validate(taskdueTime, nameof(taskdueTime), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tasks/add.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                if (tasktitle != null)
                {
                    task["title"] = SourceExpressionConverter.ConvertToken(tasktitle);
                    taskpropCount++;
                }

                if (taskfolderId != null)
                {
                    task["folder"] = SourceExpressionConverter.ConvertToken(taskfolderId);
                    taskpropCount++;
                }

                if (taskpriority != null)
                {
                    task["priority"] = SourceExpressionConverter.ConvertToken(taskpriority);
                    taskpropCount++;
                }

                if (tasknote != null)
                {
                    task["note"] = SourceExpressionConverter.ConvertToken(tasknote);
                    taskpropCount++;
                }

                if (taskdueDate != null)
                {
                    task["duedate"] = SourceExpressionConverter.ConvertToken(taskdueDate);
                    taskpropCount++;
                }

                if (taskdueTime != null)
                {
                    task["duetime"] = SourceExpressionConverter.ConvertToken(taskdueTime);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<TaskObject> GetTaskById([WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tasks/getById.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<TaskObject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<TaskObject> UpdateTask([WorkflowExpression] Func<int> taskid = null, [WorkflowExpression] Func<string> tasktitle = null, [WorkflowExpression] Func<string> taskcompleted = null, [WorkflowExpression] Func<string> taskdueDate = null, [WorkflowExpression] Func<string> taskdueTime = null, [WorkflowExpression] Func<string> tasknote = null, [WorkflowExpression] Func<int> taskpriority = null, [WorkflowExpression] Func<int> taskfolder = null, [WorkflowExpression] Func<string> taskmodified = null)
        {
            SourceExpression.Validate(taskid, nameof(taskid), required: false);
            SourceExpression.Validate(tasktitle, nameof(tasktitle), required: false);
            SourceExpression.Validate(taskcompleted, nameof(taskcompleted), required: false);
            SourceExpression.Validate(taskdueDate, nameof(taskdueDate), required: false);
            SourceExpression.Validate(taskdueTime, nameof(taskdueTime), required: false);
            SourceExpression.Validate(tasknote, nameof(tasknote), required: false);
            SourceExpression.Validate(taskpriority, nameof(taskpriority), required: false);
            SourceExpression.Validate(taskfolder, nameof(taskfolder), required: false);
            SourceExpression.Validate(taskmodified, nameof(taskmodified), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tasks/edit.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                if (taskid != null)
                {
                    task["id"] = SourceExpressionConverter.ConvertToken(taskid);
                    taskpropCount++;
                }

                if (tasktitle != null)
                {
                    task["title"] = SourceExpressionConverter.ConvertToken(tasktitle);
                    taskpropCount++;
                }

                if (taskcompleted != null)
                {
                    task["completed"] = SourceExpressionConverter.ConvertToken(taskcompleted);
                    taskpropCount++;
                }

                if (taskdueDate != null)
                {
                    task["duedate"] = SourceExpressionConverter.ConvertToken(taskdueDate);
                    taskpropCount++;
                }

                if (taskdueTime != null)
                {
                    task["duetime"] = SourceExpressionConverter.ConvertToken(taskdueTime);
                    taskpropCount++;
                }

                if (tasknote != null)
                {
                    task["note"] = SourceExpressionConverter.ConvertToken(tasknote);
                    taskpropCount++;
                }

                if (taskpriority != null)
                {
                    task["priority"] = SourceExpressionConverter.ConvertToken(taskpriority);
                    taskpropCount++;
                }

                if (taskfolder != null)
                {
                    task["folder"] = SourceExpressionConverter.ConvertToken(taskfolder);
                    taskpropCount++;
                }

                if (taskmodified != null)
                {
                    task["modified"] = SourceExpressionConverter.ConvertToken(taskmodified);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "toodledo")]
        public IBodyWorkflowAction<Folder[]> GetFolders()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/folders/get.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Folder[]>(BuildSourceInput);
        }
    }

    public class ToodledoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<TaskObject[]> TrigOnNewTask(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/tasks/get.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<TaskObject[]>(BuildSourceInput, triggerName, recurrence);
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