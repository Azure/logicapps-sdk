//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Todoconsumer
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TodoconsumerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<TodoList[], ApiConnectionActionConfiguration> GetAllTodoLists()
        {
            return new DeferredBodyAction<TodoList[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TodoList[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<TodoList, ApiConnectionActionConfiguration> CreateToDoList(Expression<Func<CreateToDoListBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TodoList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TodoList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<TodoList, ApiConnectionActionConfiguration> GetToDoList(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<TodoList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TodoList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<TodoList, ApiConnectionActionConfiguration> UpdateToDoList(Expression<Func<string>> folderId, Expression<Func<CreateToDoListBodyInput>> body)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TodoList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TodoList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteToDoList(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<ToDo[], ApiConnectionActionConfiguration> ListToDosByFolder(Expression<Func<string>> folderId, Expression<Func<int>> top = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ToDo[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                return new ApiConnectionAction<ToDo[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<ToDo, ApiConnectionActionConfiguration> CreateToDo(Expression<Func<string>> folderId, Expression<Func<CreateToDoBodyInput>> body)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ToDo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ToDo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<ToDo, ApiConnectionActionConfiguration> GetToDo(Expression<Func<string>> folderId, Expression<Func<string>> id)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ToDo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks/{1}", __workflow_folderId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ToDo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IBodyWorkflowAction<ToDo, ApiConnectionActionConfiguration> UpdateToDo(Expression<Func<string>> folderId, Expression<Func<string>> id, Expression<Func<UpdateToDoBodyInput>> body)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ToDo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks/{1}", __workflow_folderId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ToDo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todoconsumer")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteToDo(Expression<Func<string>> folderId, Expression<Func<string>> id)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks/{1}", __workflow_folderId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class TodoconsumerTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ToDo[], ApiConnectionTriggerConfiguration> OnNewToDoInFolder(Expression<Func<string>> folderId, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<ToDo[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/onNewToDoInFolder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<ToDo[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ToDo[], ApiConnectionTriggerConfiguration> OnUpdateToDoInFolder(Expression<Func<string>> folderId, FlowRecurrence recurrence = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<ToDo[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/trigger/onUpdateToDoInFolder/{0}", __workflow_folderId.WithUrlEncoding(1)));
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

    public class CreateToDoListBodyInput
    {
        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class CreateToDoBodyInput
    {
        [JsonProperty("dueDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDueDateTimeType DueDateTime { get; set; } = new BodyInputDueDateTimeType();

        [JsonProperty("reminderDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputReminderDateTimeType ReminderDateTime { get; set; } = new BodyInputReminderDateTimeType();

        [JsonProperty("importance")]
        public BodyInputImportanceType? Importance { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; } = "DefaultToDo";

        [JsonProperty("status")]
        public BodyInputStatusType? Status { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputBodyType Body { get; set; } = new BodyInputBodyType();

        [JsonProperty("isReminderOn")]
        public bool? IsReminderOn { get; set; }
    }

    public class BodyInputDueDateTimeType
    {
        [JsonProperty("dateTime")]
        public string DueDate { get; set; }

        [JsonProperty("timeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string DueTimeZone { get; set; } = "UTC";
    }

    public class BodyInputReminderDateTimeType
    {
        [JsonProperty("dateTime")]
        public string ReminderDateTime { get; set; }

        [JsonProperty("timeZone", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ReminderTimeZone { get; set; } = "UTC";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputImportanceType
    {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputStatusType
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

    public class BodyInputBodyType
    {
        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ContentType { get; set; } = "html";

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class UpdateToDoBodyInput
    {
        [JsonProperty("dueDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDueDateTimeType DueDateTime { get; set; } = new BodyInputDueDateTimeType();

        [JsonProperty("reminderDateTime", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputReminderDateTimeType ReminderDateTime { get; set; } = new BodyInputReminderDateTimeType();

        [JsonProperty("importance")]
        public BodyInputImportanceType? Importance { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public BodyInputStatusType? Status { get; set; }

        [JsonProperty("body", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputBodyType Body { get; set; } = new BodyInputBodyType();

        [JsonProperty("isReminderOn")]
        public bool? IsReminderOn { get; set; }
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