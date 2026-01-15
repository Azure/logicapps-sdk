//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Todo
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TodoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2[]> GetAllTodoListsV2()
        {
            var apiCallPath = "/lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TodoListV2[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2> CreateToDoListV2(Expression<Func<string>> bodyname)
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

            return new ApiConnectionAction<TodoListV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2> GetToDoListV2(Expression<Func<string>> folderId)
        {
            var apiCallPath = String.Format("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TodoListV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2> UpdateToDoList(Expression<Func<string>> folderId, Expression<Func<string>> bodyname)
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

            return new ApiConnectionAction<TodoListV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IWorkflowAction DeleteToDoList(Expression<Func<string>> folderId)
        {
            var apiCallPath = String.Format("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2[]> ListToDosByFolderV2(Expression<Func<string>> folderId, Expression<Func<int>> top = null)
        {
            var apiCallPath = String.Format("/lists/{0}/tasks", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (top != null)
                callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
            return new ApiConnectionAction<ToDoV2[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2> CreateToDoV3(Expression<Func<string>> folderId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodydueDateTimedueDate = null, Expression<Func<string>> bodyreminderDateTimereminderDateTime = null, Expression<Func<bodyimportanceInput>> bodyimportance = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodybodycontent = null, Expression<Func<bool>> bodyisReminderOn = null)
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

            return new ApiConnectionAction<ToDoV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2> GetToDoV3(Expression<Func<string>> folderId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/lists/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ToDoV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2> UpdateToDoV2(Expression<Func<string>> folderId, Expression<Func<string>> id, Expression<Func<string>> bodydueDateTimedueDate = null, Expression<Func<string>> bodyreminderDateTimereminderDateTime = null, Expression<Func<bodyimportanceInput>> bodyimportance = null, Expression<Func<string>> bodytitle = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodybodycontent = null, Expression<Func<bool>> bodyisReminderOn = null)
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

            return new ApiConnectionAction<ToDoV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IWorkflowAction DeleteToDoV2(Expression<Func<string>> folderId, Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/lists/{0}/tasks/{1}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class TodoTriggers([ConnectionName] string connectionId)
    {
        public IOutputWorkflowTrigger<ToDoV2[]> OnNewToDoInFolderV2(Expression<Func<string>> folderId)
        {
            var apiCallPath = String.Format("/v2/trigger/onNewToDoInFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ToDoV2[]>(callPayload);
        }

        public IOutputWorkflowTrigger<ToDoV2[]> OnUpdateToDoInFolderV2(Expression<Func<string>> folderId)
        {
            var apiCallPath = String.Format("/v2/trigger/onUpdateToDoInFolder/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<ToDoV2[]>(callPayload);
        }
    }

    public class TodoListV2
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

    public class ToDoV2
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
        public ToDoV2BodyType Body { get; set; }

        [JsonProperty("bodyLastModifiedDateTime")]
        public string BodyLastModifiedDateTime { get; set; }

        [JsonProperty("completedDateTime")]
        public ToDoV2CompletedDateTimeType CompletedDateTime { get; set; }

        [JsonProperty("dueDateTime")]
        public ToDoV2DueDateTimeType DueDateTime { get; set; }

        [JsonProperty("importance")]
        public ToDoV2ImportanceType Importance { get; set; }

        [JsonProperty("isReminderOn")]
        public bool IsReminderOn { get; set; }

        [JsonProperty("reminderDateTime")]
        public ToDoV2ReminderDateTimeType ReminderDateTime { get; set; }

        [JsonProperty("status")]
        public ToDoV2StatusType Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ToDoV2BodyType
    {
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class ToDoV2CompletedDateTimeType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }
    }

    public class ToDoV2DueDateTimeType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }
    }

    public enum ToDoV2ImportanceType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    public class ToDoV2ReminderDateTimeType
    {
        [JsonProperty("dateTime")]
        public string DateTime { get; set; }
    }

    public enum ToDoV2StatusType
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
    using Microsoft.Azure.Workflows.Sdk.Todo;

    public partial class WorkflowManagedActions
    {
        public TodoActions Todo(string connectionId) => new TodoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TodoTriggers Todo(string connectionId) => new TodoTriggers(connectionId);
    }
}