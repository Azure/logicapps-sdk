//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Todoconsumer
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TodoconsumerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<TodoList[]> GetAllTodoLists()
        {
            var apiCallPath = "/lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TodoList[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [WorkflowExpressionFactory(nameof(__BuildCreateToDoList))]
        public IBodyWorkflowAction<TodoList> CreateToDoList([WorkflowExpression] Func<string> bodyname)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TodoList> __BuildCreateToDoList(WorkflowExpression<string> bodyname)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<TodoList>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TodoList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [WorkflowExpressionFactory(nameof(__BuildGetToDoList))]
        public IBodyWorkflowAction<TodoList> GetToDoList([WorkflowExpression] Func<string> folderId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TodoList> __BuildGetToDoList(WorkflowExpression<string> folderId)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<TodoList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TodoList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateToDoList))]
        public IBodyWorkflowAction<TodoList> UpdateToDoList([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> bodyname)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TodoList> __BuildUpdateToDoList(WorkflowExpression<string> folderId, WorkflowExpression<string> bodyname)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<TodoList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TodoList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteToDoList))]
        public IWorkflowAction DeleteToDoList([WorkflowExpression] Func<string> folderId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteToDoList(WorkflowExpression<string> folderId)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [WorkflowExpressionFactory(nameof(__BuildListToDosByFolder))]
        public IBodyWorkflowAction<ToDo[]> ListToDosByFolder([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<int> top = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ToDo[]> __BuildListToDosByFolder(WorkflowExpression<string> folderId, WorkflowExpression<int> top = null)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            return new DeferredBodyAction<ToDo[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                return new ApiConnectionAction<ToDo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [WorkflowExpressionFactory(nameof(__BuildCreateToDo))]
        public IBodyWorkflowAction<ToDo> CreateToDo([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodydueDateTimedueDate = null, [WorkflowExpression] Func<string> bodyreminderDateTimereminderDateTime = null, [WorkflowExpression] Func<bodyimportanceInput> bodyimportance = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodybodycontent = null, [WorkflowExpression] Func<bool> bodyisReminderOn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ToDo> __BuildCreateToDo(WorkflowExpression<string> folderId, WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodydueDateTimedueDate = null, WorkflowExpression<string> bodyreminderDateTimereminderDateTime = null, WorkflowExpression<bodyimportanceInput> bodyimportance = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<string> bodybodycontent = null, WorkflowExpression<bool> bodyisReminderOn = null)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodydueDateTimedueDate, nameof(bodydueDateTimedueDate), required: false);
            WorkflowExpression.Validate(bodyreminderDateTimereminderDateTime, nameof(bodyreminderDateTimereminderDateTime), required: false);
            WorkflowExpression.Validate(bodyimportance, nameof(bodyimportance), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodybodycontent, nameof(bodybodycontent), required: false);
            WorkflowExpression.Validate(bodyisReminderOn, nameof(bodyisReminderOn), required: false);
            return new DeferredBodyAction<ToDo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dueDateTimeObject = new JObject();
                var dueDateTimeObjectpropCount = 0;
                if (bodydueDateTimedueDate != null)
                {
                    dueDateTimeObject["dateTime"] = ExpressionConverter.ConvertO(bodydueDateTimedueDate);
                    dueDateTimeObjectpropCount++;
                }

                dueDateTimeObject["timeZone"] = "UTC";
                dueDateTimeObjectpropCount++;
                if (dueDateTimeObjectpropCount > 0)
                {
                    body["dueDateTime"] = dueDateTimeObject;
                    bodypropCount++;
                }

                var reminderDateTimeObject = new JObject();
                var reminderDateTimeObjectpropCount = 0;
                if (bodyreminderDateTimereminderDateTime != null)
                {
                    reminderDateTimeObject["dateTime"] = ExpressionConverter.ConvertO(bodyreminderDateTimereminderDateTime);
                    reminderDateTimeObjectpropCount++;
                }

                reminderDateTimeObject["timeZone"] = "UTC";
                reminderDateTimeObjectpropCount++;
                if (reminderDateTimeObjectpropCount > 0)
                {
                    body["reminderDateTime"] = reminderDateTimeObject;
                    bodypropCount++;
                }

                if (bodyimportance != null)
                {
                    body["importance"] = ExpressionConverter.ConvertO(bodyimportance);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodybodycontent != null)
                {
                    bodyObject["content"] = ExpressionConverter.ConvertO(bodybodycontent);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    body["body"] = bodyObject;
                    bodypropCount++;
                }

                if (bodyisReminderOn != null)
                {
                    body["isReminderOn"] = ExpressionConverter.ConvertO(bodyisReminderOn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ToDo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [WorkflowExpressionFactory(nameof(__BuildGetToDo))]
        public IBodyWorkflowAction<ToDo> GetToDo([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ToDo> __BuildGetToDo(WorkflowExpression<string> folderId, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ToDo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ToDo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateToDo))]
        public IBodyWorkflowAction<ToDo> UpdateToDo([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydueDateTimedueDate = null, [WorkflowExpression] Func<string> bodyreminderDateTimereminderDateTime = null, [WorkflowExpression] Func<bodyimportanceInput> bodyimportance = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodybodycontent = null, [WorkflowExpression] Func<bool> bodyisReminderOn = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ToDo> __BuildUpdateToDo(WorkflowExpression<string> folderId, WorkflowExpression<string> id, WorkflowExpression<string> bodydueDateTimedueDate = null, WorkflowExpression<string> bodyreminderDateTimereminderDateTime = null, WorkflowExpression<bodyimportanceInput> bodyimportance = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<bodystatusInput> bodystatus = null, WorkflowExpression<string> bodybodycontent = null, WorkflowExpression<bool> bodyisReminderOn = null)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodydueDateTimedueDate, nameof(bodydueDateTimedueDate), required: false);
            WorkflowExpression.Validate(bodyreminderDateTimereminderDateTime, nameof(bodyreminderDateTimereminderDateTime), required: false);
            WorkflowExpression.Validate(bodyimportance, nameof(bodyimportance), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodybodycontent, nameof(bodybodycontent), required: false);
            WorkflowExpression.Validate(bodyisReminderOn, nameof(bodyisReminderOn), required: false);
            return new DeferredBodyAction<ToDo>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dueDateTimeObject = new JObject();
                var dueDateTimeObjectpropCount = 0;
                if (bodydueDateTimedueDate != null)
                {
                    dueDateTimeObject["dateTime"] = ExpressionConverter.ConvertO(bodydueDateTimedueDate);
                    dueDateTimeObjectpropCount++;
                }

                dueDateTimeObject["timeZone"] = "UTC";
                dueDateTimeObjectpropCount++;
                if (dueDateTimeObjectpropCount > 0)
                {
                    body["dueDateTime"] = dueDateTimeObject;
                    bodypropCount++;
                }

                var reminderDateTimeObject = new JObject();
                var reminderDateTimeObjectpropCount = 0;
                if (bodyreminderDateTimereminderDateTime != null)
                {
                    reminderDateTimeObject["dateTime"] = ExpressionConverter.ConvertO(bodyreminderDateTimereminderDateTime);
                    reminderDateTimeObjectpropCount++;
                }

                reminderDateTimeObject["timeZone"] = "UTC";
                reminderDateTimeObjectpropCount++;
                if (reminderDateTimeObjectpropCount > 0)
                {
                    body["reminderDateTime"] = reminderDateTimeObject;
                    bodypropCount++;
                }

                if (bodyimportance != null)
                {
                    body["importance"] = ExpressionConverter.ConvertO(bodyimportance);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodybodycontent != null)
                {
                    bodyObject["content"] = ExpressionConverter.ConvertO(bodybodycontent);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    body["body"] = bodyObject;
                    bodypropCount++;
                }

                if (bodyisReminderOn != null)
                {
                    body["isReminderOn"] = ExpressionConverter.ConvertO(bodyisReminderOn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ToDo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteToDo))]
        public IWorkflowAction DeleteToDo([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteToDo(WorkflowExpression<string> folderId, WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class TodoconsumerTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildOnNewToDoInFolder))]
        public IBodyWorkflowTrigger<ToDo[]> OnNewToDoInFolder([WorkflowExpression] Func<string> folderId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ToDo[]> __BuildOnNewToDoInFolder(WorkflowExpression<string> folderId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<ToDo[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/onNewToDoInFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ToDo[]>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildOnUpdateToDoInFolder))]
        public IBodyWorkflowTrigger<ToDo[]> OnUpdateToDoInFolder([WorkflowExpression] Func<string> folderId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ToDo[]> __BuildOnUpdateToDoInFolder(WorkflowExpression<string> folderId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<ToDo[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/trigger/onUpdateToDoInFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ToDo[]>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class TodoList
    {
        [JsonProperty("@odata.etag")]
        public string Etag { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("wellknownListName")]
        public string WellKnownName { get; set; }

        [JsonProperty("isOwner")]
        public bool IsOwner { get; set; }

        [JsonProperty("isShared")]
        public bool IsShared { get; set; }
    }

    public class ToDo
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.etag")]
        public string Etag { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("lastModifiedDateTime")]
        public string LastModifiedDateTime { get; set; }

        [JsonProperty("body")]
        public ToDoBodyType Body { get; set; }

        [JsonProperty("bodyLastModifiedDateTime")]
        public string BodyLastModifiedDateTime { get; set; }

        [JsonProperty("completedDateTime")]
        public ToDoCompletedDateTimeType CompletedDateTime { get; set; }

        [JsonProperty("dueDateTime")]
        public ToDoDueDateTimeType DueDateTime { get; set; }

        [JsonProperty("importance")]
        public ToDoImportanceType Importance { get; set; }

        [JsonProperty("isReminderOn")]
        public bool IsReminderOn { get; set; }

        [JsonProperty("reminderDateTime")]
        public ToDoReminderDateTimeType ReminderDateTime { get; set; }

        [JsonProperty("status")]
        public ToDoStatusType Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ToDoBodyType
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class ToDoCompletedDateTimeType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }
    }

    public class ToDoDueDateTimeType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }
    }

    public enum ToDoImportanceType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    public class ToDoReminderDateTimeType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }
    }

    public enum ToDoStatusType
    {
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "waitingOnOthers")]
        WaitingOnOthers,
        [EnumMember(Value = "deferred")]
        Deferred
    }

    public enum bodyimportanceInput
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    public enum bodystatusInput
    {
        [EnumMember(Value = "notStarted")]
        NotStarted,
        [EnumMember(Value = "inProgress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "waitingOnOthers")]
        WaitingOnOthers,
        [EnumMember(Value = "deferred")]
        Deferred
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Todoconsumer;

    public partial class WorkflowManagedActions
    {
        public TodoconsumerActions Todoconsumer(string connectionId) => new TodoconsumerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TodoconsumerTriggers Todoconsumer(string connectionId) => new TodoconsumerTriggers(connectionId);
    }
}