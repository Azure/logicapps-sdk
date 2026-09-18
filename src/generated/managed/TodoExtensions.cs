//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Todo
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TodoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2> UpdateToDoList([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TodoListV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IWorkflowAction DeleteToDoList([WorkflowExpression] Func<string> folderId)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2> CreateToDo([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodydueDateTimedueDate = null, [WorkflowExpression] Func<string> bodyreminderDateTimereminderDateTime = null, [WorkflowExpression] Func<bodyimportanceInput> bodyimportance = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodybodycontent = null, [WorkflowExpression] Func<bool> bodyisReminderOn = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodydueDateTimedueDate, nameof(bodydueDateTimedueDate), required: false);
            SourceExpression.Validate(bodyreminderDateTimereminderDateTime, nameof(bodyreminderDateTimereminderDateTime), required: false);
            SourceExpression.Validate(bodyimportance, nameof(bodyimportance), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodybodycontent, nameof(bodybodycontent), required: false);
            SourceExpression.Validate(bodyisReminderOn, nameof(bodyisReminderOn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dueDateTimeObject = new JObject();
                var dueDateTimeObjectpropCount = 0;
                if (bodydueDateTimedueDate != null)
                {
                    dueDateTimeObject["dateTime"] = SourceExpressionConverter.ConvertToken(bodydueDateTimedueDate);
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
                    reminderDateTimeObject["dateTime"] = SourceExpressionConverter.ConvertToken(bodyreminderDateTimereminderDateTime);
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
                    body["importance"] = SourceExpressionConverter.Convert(bodyimportance);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodybodycontent != null)
                {
                    bodyObject["content"] = SourceExpressionConverter.ConvertToken(bodybodycontent);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    body["body"] = bodyObject;
                    bodypropCount++;
                }

                if (bodyisReminderOn != null)
                {
                    body["isReminderOn"] = SourceExpressionConverter.ConvertToken(bodyisReminderOn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ToDoV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2> CreateToDoList([WorkflowExpression] Func<string> bodyname)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["displayName"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TodoListV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IWorkflowAction DeleteToDo([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2[]> GetAllTodoLists()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TodoListV2[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2> GetToDo([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ToDoV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<TodoListV2> GetToDoList([WorkflowExpression] Func<string> folderId)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TodoListV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2[]> ListToDosByFolder([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<int> top = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(top, nameof(top), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                return callPayload;
            }

            return new ApiConnectionAction<ToDoV2[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "todo")]
        public IBodyWorkflowAction<ToDoV2> UpdateToDo([WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydueDateTimedueDate = null, [WorkflowExpression] Func<string> bodyreminderDateTimereminderDateTime = null, [WorkflowExpression] Func<bodyimportanceInput> bodyimportance = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodybodycontent = null, [WorkflowExpression] Func<bool> bodyisReminderOn = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodydueDateTimedueDate, nameof(bodydueDateTimedueDate), required: false);
            SourceExpression.Validate(bodyreminderDateTimereminderDateTime, nameof(bodyreminderDateTimereminderDateTime), required: false);
            SourceExpression.Validate(bodyimportance, nameof(bodyimportance), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            SourceExpression.Validate(bodybodycontent, nameof(bodybodycontent), required: false);
            SourceExpression.Validate(bodyisReminderOn, nameof(bodyisReminderOn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/tasks/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dueDateTimeObject = new JObject();
                var dueDateTimeObjectpropCount = 0;
                if (bodydueDateTimedueDate != null)
                {
                    dueDateTimeObject["dateTime"] = SourceExpressionConverter.ConvertToken(bodydueDateTimedueDate);
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
                    reminderDateTimeObject["dateTime"] = SourceExpressionConverter.ConvertToken(bodyreminderDateTimereminderDateTime);
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
                    body["importance"] = SourceExpressionConverter.Convert(bodyimportance);
                    bodypropCount++;
                }

                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                bodyObject["contentType"] = "html";
                bodyObjectpropCount++;
                if (bodybodycontent != null)
                {
                    bodyObject["content"] = SourceExpressionConverter.ConvertToken(bodybodycontent);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    body["body"] = bodyObject;
                    bodypropCount++;
                }

                if (bodyisReminderOn != null)
                {
                    body["isReminderOn"] = SourceExpressionConverter.ConvertToken(bodyisReminderOn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ToDoV2>(BuildSourceInput);
        }
    }

    public class TodoTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ToDoV2[]> OnNewToDoInFolder([WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/trigger/onNewToDoInFolder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ToDoV2[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ToDoV2[]> OnUpdateToDoInFolder([WorkflowExpression] Func<string> folderId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/trigger/onUpdateToDoInFolder/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<ToDoV2[]>(BuildSourceInput, triggerName, recurrence);
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