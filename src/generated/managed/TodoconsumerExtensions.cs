//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Todoconsumer
{
    using System.Linq.Expressions;
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
        public IBodyWorkflowAction<TodoList> CreateToDoList(Expression<Func<string>> bodyname)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<TodoList> GetToDoList(Expression<Func<string>> folderId)
        {
            var apiCallPath = String.Format("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TodoList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<TodoList> UpdateToDoList(Expression<Func<string>> folderId, Expression<Func<string>> bodyname)
        {
            var apiCallPath = String.Format("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IWorkflowAction DeleteToDoList(Expression<Func<string>> folderId)
        {
            var apiCallPath = String.Format("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<ToDo[]> ListToDosByFolder(Expression<Func<string>> folderId, Expression<Func<int>> top = null)
        {
            var apiCallPath = String.Format("/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<ToDo[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<ToDo> CreateToDo(Expression<Func<string>> folderId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodydueDateTimedueDate = null, Expression<Func<string>> bodyreminderDateTimereminderDateTime = null, Expression<Func<bodyimportanceInput>> bodyimportance = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodybodycontent = null, Expression<Func<bool>> bodyisReminderOn = null)
        {
            var apiCallPath = String.Format("/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<ToDo> GetToDo(Expression<Func<string>> folderId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/lists/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ToDo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<ToDo> UpdateToDo(Expression<Func<string>> folderId, Expression<Func<string>> id, Expression<Func<string>> bodydueDateTimedueDate = null, Expression<Func<string>> bodyreminderDateTimereminderDateTime = null, Expression<Func<bodyimportanceInput>> bodyimportance = null, Expression<Func<string>> bodytitle = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodybodycontent = null, Expression<Func<bool>> bodyisReminderOn = null)
        {
            var apiCallPath = String.Format("/lists/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IWorkflowAction DeleteToDo(Expression<Func<string>> folderId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/lists/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class TodoconsumerTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<ToDo[]> OnNewToDoInFolder(Expression<Func<string>> folderId)
        {
            var apiCallPath = String.Format("/trigger/onNewToDoInFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ToDo[]>(callPayload);
        }

        public IOutputWorkflowTrigger<ToDo[]> OnUpdateToDoInFolder(Expression<Func<string>> folderId)
        {
            var apiCallPath = String.Format("/trigger/onUpdateToDoInFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ToDo[]>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Todoconsumer;

    public partial class WorkflowManagedActions
    {
        public TodoconsumerActions Todoconsumer(string connectionId) => new TodoconsumerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TodoconsumerTriggers Todoconsumer(string connectionId) => new TodoconsumerTriggers(connectionId);
    }
}