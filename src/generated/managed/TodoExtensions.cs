//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Todo
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TodoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2> UpdateToDoList(Expression<Func<string>> folderId, Expression<Func<string>> bodyname)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<TodoListV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TodoListV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IWorkflowAction DeleteToDoList(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2> CreateToDo(Expression<Func<string>> folderId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodydueDateTimedueDate = null, Expression<Func<string>> bodyreminderDateTimereminderDateTime = null, Expression<Func<bodyimportanceInput>> bodyimportance = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodybodycontent = null, Expression<Func<bool>> bodyisReminderOn = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodydueDateTimedueDate = WorkflowExpression.Compile(bodydueDateTimedueDate, nameof(bodydueDateTimedueDate), required: false);
            var __workflow_bodyreminderDateTimereminderDateTime = WorkflowExpression.Compile(bodyreminderDateTimereminderDateTime, nameof(bodyreminderDateTimereminderDateTime), required: false);
            var __workflow_bodyimportance = WorkflowExpression.Compile(bodyimportance, nameof(bodyimportance), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodybodycontent = WorkflowExpression.Compile(bodybodycontent, nameof(bodybodycontent), required: false);
            var __workflow_bodyisReminderOn = WorkflowExpression.Compile(bodyisReminderOn, nameof(bodyisReminderOn), required: false);
            return new DeferredBodyAction<ToDoV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dueDateTimeObject = new JObject();
                var dueDateTimeObjectpropCount = 0;
                if (__workflow_bodydueDateTimedueDate != null)
                {
                    dueDateTimeObject["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodydueDateTimedueDate);
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
                if (__workflow_bodyreminderDateTimereminderDateTime != null)
                {
                    reminderDateTimeObject["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodyreminderDateTimereminderDateTime);
                    reminderDateTimeObjectpropCount++;
                }

                reminderDateTimeObject["timeZone"] = "UTC";
                reminderDateTimeObjectpropCount++;
                if (reminderDateTimeObjectpropCount > 0)
                {
                    body["reminderDateTime"] = reminderDateTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodyimportance != null)
                {
                    body["importance"] = ExpressionConverter.ConvertO(__workflow_bodyimportance);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (__workflow_bodybodycontent != null)
                {
                    bodyObject["content"] = ExpressionConverter.ConvertO(__workflow_bodybodycontent);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    body["body"] = bodyObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisReminderOn != null)
                {
                    body["isReminderOn"] = ExpressionConverter.ConvertO(__workflow_bodyisReminderOn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ToDoV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2> CreateToDoList(Expression<Func<string>> bodyname)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            return new DeferredBodyAction<TodoListV2>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TodoListV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IWorkflowAction DeleteToDo(Expression<Func<string>> folderId, Expression<Func<string>> id)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks/{1}", __workflow_folderId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2[]> GetAllTodoLists()
        {
            var apiCallPath = "/lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TodoListV2[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2> GetToDo(Expression<Func<string>> folderId, Expression<Func<string>> id)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ToDoV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks/{1}", __workflow_folderId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ToDoV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2> GetToDoList(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<TodoListV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TodoListV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2[]> ListToDosByFolder(Expression<Func<string>> folderId, Expression<Func<int>> top = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ToDoV2[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ToDoV2[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2> UpdateToDo(Expression<Func<string>> folderId, Expression<Func<string>> id, Expression<Func<string>> bodydueDateTimedueDate = null, Expression<Func<string>> bodyreminderDateTimereminderDateTime = null, Expression<Func<bodyimportanceInput>> bodyimportance = null, Expression<Func<string>> bodytitle = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodybodycontent = null, Expression<Func<bool>> bodyisReminderOn = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodydueDateTimedueDate = WorkflowExpression.Compile(bodydueDateTimedueDate, nameof(bodydueDateTimedueDate), required: false);
            var __workflow_bodyreminderDateTimereminderDateTime = WorkflowExpression.Compile(bodyreminderDateTimereminderDateTime, nameof(bodyreminderDateTimereminderDateTime), required: false);
            var __workflow_bodyimportance = WorkflowExpression.Compile(bodyimportance, nameof(bodyimportance), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodybodycontent = WorkflowExpression.Compile(bodybodycontent, nameof(bodybodycontent), required: false);
            var __workflow_bodyisReminderOn = WorkflowExpression.Compile(bodyisReminderOn, nameof(bodyisReminderOn), required: false);
            return new DeferredBodyAction<ToDoV2>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks/{1}", __workflow_folderId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dueDateTimeObject = new JObject();
                var dueDateTimeObjectpropCount = 0;
                if (__workflow_bodydueDateTimedueDate != null)
                {
                    dueDateTimeObject["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodydueDateTimedueDate);
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
                if (__workflow_bodyreminderDateTimereminderDateTime != null)
                {
                    reminderDateTimeObject["dateTime"] = ExpressionConverter.ConvertO(__workflow_bodyreminderDateTimereminderDateTime);
                    reminderDateTimeObjectpropCount++;
                }

                reminderDateTimeObject["timeZone"] = "UTC";
                reminderDateTimeObjectpropCount++;
                if (reminderDateTimeObjectpropCount > 0)
                {
                    body["reminderDateTime"] = reminderDateTimeObject;
                    bodypropCount++;
                }

                if (__workflow_bodyimportance != null)
                {
                    body["importance"] = ExpressionConverter.ConvertO(__workflow_bodyimportance);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (__workflow_bodybodycontent != null)
                {
                    bodyObject["content"] = ExpressionConverter.ConvertO(__workflow_bodybodycontent);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    body["body"] = bodyObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisReminderOn != null)
                {
                    body["isReminderOn"] = ExpressionConverter.ConvertO(__workflow_bodyisReminderOn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ToDoV2>(callPayload);
            });
        }
    }

    public class TodoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ToDoV2[]> OnNewToDoInFolder(Expression<Func<string>> folderId, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<ToDoV2[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/trigger/onNewToDoInFolder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ToDoV2[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ToDoV2[]> OnUpdateToDoInFolder(Expression<Func<string>> folderId, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<ToDoV2[]>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/trigger/onUpdateToDoInFolder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ToDoV2[]>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyimportanceInput
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Todo;

    public partial class WorkflowManagedActions
    {
        public TodoActions Todo(string connectionId) => new TodoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TodoTriggers Todo(string connectionId) => new TodoTriggers(connectionId);
    }
}
