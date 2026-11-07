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
        public IBodyWorkflowAction<TodoListV2, ApiConnectionActionConfiguration> UpdateToDoList(Expression<Func<string>> folderId, Expression<Func<CreateToDoListBodyInput>> body)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TodoListV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TodoListV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2, ApiConnectionActionConfiguration> CreateToDo(Expression<Func<string>> folderId, Expression<Func<CreateToDoBodyInput>> body)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ToDoV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ToDoV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2, ApiConnectionActionConfiguration> CreateToDoList(Expression<Func<CreateToDoListBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<TodoListV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<TodoListV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2[], ApiConnectionActionConfiguration> GetAllTodoLists()
        {
            return new DeferredBodyAction<TodoListV2[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TodoListV2[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2, ApiConnectionActionConfiguration> GetToDo(Expression<Func<string>> folderId, Expression<Func<string>> id)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ToDoV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks/{1}", __workflow_folderId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ToDoV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2, ApiConnectionActionConfiguration> GetToDoList(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<TodoListV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TodoListV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2[], ApiConnectionActionConfiguration> ListToDosByFolder(Expression<Func<string>> folderId, Expression<Func<int>> top = null)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            return new DeferredBodyAction<ToDoV2[], ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<ToDoV2, ApiConnectionActionConfiguration> UpdateToDo(Expression<Func<string>> folderId, Expression<Func<string>> id, Expression<Func<UpdateToDoBodyInput>> body)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ToDoV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/tasks/{1}", __workflow_folderId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ToDoV2>(callPayload);
            });
        }
    }

    public class TodoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ToDoV2[], ApiConnectionPollingTriggerConfiguration> OnNewToDoInFolder(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<ToDoV2[], ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/trigger/onNewToDoInFolder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionPollingTrigger<ToDoV2[]>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<ToDoV2[], ApiConnectionPollingTriggerConfiguration> OnUpdateToDoInFolder(Expression<Func<string>> folderId)
        {
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyTrigger<ToDoV2[], ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/trigger/onUpdateToDoInFolder/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionPollingTrigger<ToDoV2[]>(callPayload);
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

    public class CreateToDoListBodyInput
    {
        [JsonProperty("displayName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }
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