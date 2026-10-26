//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gratavid
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GratavidActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gratavid")]
        public IBodyWorkflowAction<CreateTaskResponse, ApiConnectionActionConfiguration> CreateTask(Expression<Func<CreateTaskInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/integrationsEndpoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("microsoftPowerAutomate");
                callPayload.Queries["event"] = Convert.ToString("createTask");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gratavid")]
        public IBodyWorkflowAction<SendNoteResponse, ApiConnectionActionConfiguration> SendNote(Expression<Func<SendNoteInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SendNoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/integrationsEndpoint";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("microsoftPowerAutomate");
                callPayload.Queries["event"] = Convert.ToString("sendNote");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendNoteResponse>(callPayload);
            });
        }
    }

    public class GratavidTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> NewEvent(Expression<Func<webookHookEventInput>> webookHookEvent, Expression<Func<NewEventInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_webookHookEvent = WorkflowExpression.Compile(webookHookEvent, nameof(webookHookEvent), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/manageIntegrations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("microsoftPowerAutomate");
                callPayload.Queries["event"] = Convert.ToString("webhookSubscribe");
                callPayload.Queries["webookHookEvent"] = ExpressionConverter.Convert(__workflow_webookHookEvent);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateTaskResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("viewInGratavidLink")]
        public string ViewInGratavidLink { get; set; }
    }

    public class CreateTaskInput
    {
        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("customUserId")]
        public string CustomUserId { get; set; }

        [JsonProperty("customAccountId")]
        public string CustomAccountId { get; set; }

        [JsonProperty("textOptIn")]
        public string TextOptIn { get; set; }

        [JsonProperty("cellNumber")]
        public string CellNumber { get; set; }

        [JsonProperty("comments", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Comments { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }
    }

    public class SendNoteResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("noteId")]
        public string NoteId { get; set; }

        [JsonProperty("gvSendId")]
        public string GvSendId { get; set; }

        [JsonProperty("viewInGratavidLink")]
        public string ViewInGratavidLink { get; set; }
    }

    public class SendNoteInput
    {
        [JsonProperty("noteId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string NoteId { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("customUserId")]
        public string CustomUserId { get; set; }

        [JsonProperty("customAccountId")]
        public string CustomAccountId { get; set; }

        [JsonProperty("textOptIn")]
        public string TextOptIn { get; set; }

        [JsonProperty("cellNumber")]
        public string CellNumber { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum webookHookEventInput
    {
        [EnumMember(Value = "taskSent")]
        GratavidTaskSentToAContact,
        [EnumMember(Value = "reply")]
        ContactRepliesToAGratavid,
        [EnumMember(Value = "noteWatched")]
        ContactWatchesAGratavidAllTheWayThrough,
        [EnumMember(Value = "unsubscribe")]
        ContactUnsubscribesFromEmailAfterReceivingGratavidEmail,
        [EnumMember(Value = "stopText")]
        ContactOptOutOfTextRepliesSTOPAfterReceivingGratavid
    }

    public class NewEventInput
    {
        [JsonProperty("webhookURL", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string WebhookURL { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Gratavid;

    public partial class WorkflowManagedActions
    {
        public GratavidActions Gratavid(string connectionId) => new GratavidActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GratavidTriggers Gratavid(string connectionId) => new GratavidTriggers(connectionId);
    }
}