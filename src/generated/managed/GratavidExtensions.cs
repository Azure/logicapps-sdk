//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gratavid
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GratavidActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gratavid")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTask))]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodycomments, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodycustomUserId = null, [WorkflowExpression] Func<string> bodycustomAccountId = null, [WorkflowExpression] Func<string> bodytextOptIn = null, [WorkflowExpression] Func<string> bodycellNumber = null, [WorkflowExpression] Func<string> bodyassignedTo = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gratavid")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateTaskResponse> __BuildCreateTask(WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodycomments, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodycustomUserId = null, WorkflowExpression<string> bodycustomAccountId = null, WorkflowExpression<string> bodytextOptIn = null, WorkflowExpression<string> bodycellNumber = null, WorkflowExpression<string> bodyassignedTo = null)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodycomments, nameof(bodycomments), required: true);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodycustomUserId, nameof(bodycustomUserId), required: false);
            WorkflowExpression.Validate(bodycustomAccountId, nameof(bodycustomAccountId), required: false);
            WorkflowExpression.Validate(bodytextOptIn, nameof(bodytextOptIn), required: false);
            WorkflowExpression.Validate(bodycellNumber, nameof(bodycellNumber), required: false);
            WorkflowExpression.Validate(bodyassignedTo, nameof(bodyassignedTo), required: false);
            return new DeferredBodyAction<CreateTaskResponse>(() =>
            {
                var apiCallPath = "/api/integrationsEndpoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("microsoftPowerAutomate");
                callPayload.Queries["event"] = Convert.ToString("createTask");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodycustomUserId != null)
                {
                    body["customUserId"] = ExpressionConverter.ConvertO(bodycustomUserId);
                    bodypropCount++;
                }

                if (bodycustomAccountId != null)
                {
                    body["customAccountId"] = ExpressionConverter.ConvertO(bodycustomAccountId);
                    bodypropCount++;
                }

                if (bodytextOptIn != null)
                {
                    body["textOptIn"] = ExpressionConverter.ConvertO(bodytextOptIn);
                    bodypropCount++;
                }

                if (bodycellNumber != null)
                {
                    body["cellNumber"] = ExpressionConverter.ConvertO(bodycellNumber);
                    bodypropCount++;
                }

                bodypropCount++;
                body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                if (bodyassignedTo != null)
                {
                    body["assignedTo"] = ExpressionConverter.ConvertO(bodyassignedTo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gratavid")]
        [WorkflowExpressionFactory(nameof(__BuildSendNote))]
        public IBodyWorkflowAction<SendNoteResponse> SendNote([WorkflowExpression] Func<string> bodynoteId, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodycustomUserId = null, [WorkflowExpression] Func<string> bodycustomAccountId = null, [WorkflowExpression] Func<string> bodytextOptIn = null, [WorkflowExpression] Func<string> bodycellNumber = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gratavid")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendNoteResponse> __BuildSendNote(WorkflowExpression<string> bodynoteId, WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodycustomUserId = null, WorkflowExpression<string> bodycustomAccountId = null, WorkflowExpression<string> bodytextOptIn = null, WorkflowExpression<string> bodycellNumber = null)
        {
            WorkflowExpression.Validate(bodynoteId, nameof(bodynoteId), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodycustomUserId, nameof(bodycustomUserId), required: false);
            WorkflowExpression.Validate(bodycustomAccountId, nameof(bodycustomAccountId), required: false);
            WorkflowExpression.Validate(bodytextOptIn, nameof(bodytextOptIn), required: false);
            WorkflowExpression.Validate(bodycellNumber, nameof(bodycellNumber), required: false);
            return new DeferredBodyAction<SendNoteResponse>(() =>
            {
                var apiCallPath = "/api/integrationsEndpoint";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("microsoftPowerAutomate");
                callPayload.Queries["event"] = Convert.ToString("sendNote");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["noteId"] = ExpressionConverter.ConvertO(bodynoteId);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodycustomUserId != null)
                {
                    body["customUserId"] = ExpressionConverter.ConvertO(bodycustomUserId);
                    bodypropCount++;
                }

                if (bodycustomAccountId != null)
                {
                    body["customAccountId"] = ExpressionConverter.ConvertO(bodycustomAccountId);
                    bodypropCount++;
                }

                if (bodytextOptIn != null)
                {
                    body["textOptIn"] = ExpressionConverter.ConvertO(bodytextOptIn);
                    bodypropCount++;
                }

                if (bodycellNumber != null)
                {
                    body["cellNumber"] = ExpressionConverter.ConvertO(bodycellNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendNoteResponse>(callPayload);
            });
        }
    }

    public class GratavidTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildNewEvent))]
        public IWorkflowTrigger NewEvent([WorkflowExpression] Func<webookHookEventInput> webookHookEvent,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildNewEvent(WorkflowExpression<webookHookEventInput> webookHookEvent,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(webookHookEvent, nameof(webookHookEvent), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/manageIntegrations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("microsoftPowerAutomate");
                callPayload.Queries["event"] = Convert.ToString("webhookSubscribe");
                callPayload.Queries["webookHookEvent"] = ExpressionConverter.Convert(webookHookEvent);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookURL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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