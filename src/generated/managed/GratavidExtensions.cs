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
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> bodyemail, Expression<Func<string>> bodycomments, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodycustomUserId = null, Expression<Func<string>> bodycustomAccountId = null, Expression<Func<string>> bodytextOptIn = null, Expression<Func<string>> bodycellNumber = null, Expression<Func<string>> bodyassignedTo = null)
        {
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodycustomUserId = WorkflowExpression.Compile(bodycustomUserId, nameof(bodycustomUserId), required: false);
            var __workflow_bodycustomAccountId = WorkflowExpression.Compile(bodycustomAccountId, nameof(bodycustomAccountId), required: false);
            var __workflow_bodytextOptIn = WorkflowExpression.Compile(bodytextOptIn, nameof(bodytextOptIn), required: false);
            var __workflow_bodycellNumber = WorkflowExpression.Compile(bodycellNumber, nameof(bodycellNumber), required: false);
            var __workflow_bodyassignedTo = WorkflowExpression.Compile(bodyassignedTo, nameof(bodyassignedTo), required: false);
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
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodycustomUserId != null)
                {
                    body["customUserId"] = ExpressionConverter.ConvertO(__workflow_bodycustomUserId);
                    bodypropCount++;
                }

                if (__workflow_bodycustomAccountId != null)
                {
                    body["customAccountId"] = ExpressionConverter.ConvertO(__workflow_bodycustomAccountId);
                    bodypropCount++;
                }

                if (__workflow_bodytextOptIn != null)
                {
                    body["textOptIn"] = ExpressionConverter.ConvertO(__workflow_bodytextOptIn);
                    bodypropCount++;
                }

                if (__workflow_bodycellNumber != null)
                {
                    body["cellNumber"] = ExpressionConverter.ConvertO(__workflow_bodycellNumber);
                    bodypropCount++;
                }

                bodypropCount++;
                body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                if (__workflow_bodyassignedTo != null)
                {
                    body["assignedTo"] = ExpressionConverter.ConvertO(__workflow_bodyassignedTo);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateTaskResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gratavid")]
        public IBodyWorkflowAction<SendNoteResponse> SendNote(Expression<Func<string>> bodynoteId, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodycustomUserId = null, Expression<Func<string>> bodycustomAccountId = null, Expression<Func<string>> bodytextOptIn = null, Expression<Func<string>> bodycellNumber = null)
        {
            var __workflow_bodynoteId = WorkflowExpression.Compile(bodynoteId, nameof(bodynoteId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodycustomUserId = WorkflowExpression.Compile(bodycustomUserId, nameof(bodycustomUserId), required: false);
            var __workflow_bodycustomAccountId = WorkflowExpression.Compile(bodycustomAccountId, nameof(bodycustomAccountId), required: false);
            var __workflow_bodytextOptIn = WorkflowExpression.Compile(bodytextOptIn, nameof(bodytextOptIn), required: false);
            var __workflow_bodycellNumber = WorkflowExpression.Compile(bodycellNumber, nameof(bodycellNumber), required: false);
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
                body["noteId"] = ExpressionConverter.ConvertO(__workflow_bodynoteId);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodycustomUserId != null)
                {
                    body["customUserId"] = ExpressionConverter.ConvertO(__workflow_bodycustomUserId);
                    bodypropCount++;
                }

                if (__workflow_bodycustomAccountId != null)
                {
                    body["customAccountId"] = ExpressionConverter.ConvertO(__workflow_bodycustomAccountId);
                    bodypropCount++;
                }

                if (__workflow_bodytextOptIn != null)
                {
                    body["textOptIn"] = ExpressionConverter.ConvertO(__workflow_bodytextOptIn);
                    bodypropCount++;
                }

                if (__workflow_bodycellNumber != null)
                {
                    body["cellNumber"] = ExpressionConverter.ConvertO(__workflow_bodycellNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendNoteResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class GratavidTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger NewEvent(Expression<Func<webookHookEventInput>> webookHookEvent, FlowRecurrence recurrence = null)
        {
            var __workflow_webookHookEvent = WorkflowExpression.Compile(webookHookEvent, nameof(webookHookEvent), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/manageIntegrations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("microsoftPowerAutomate");
                callPayload.Queries["event"] = Convert.ToString("webhookSubscribe");
                callPayload.Queries["webookHookEvent"] = ExpressionConverter.Convert(__workflow_webookHookEvent);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookURL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingProfiles.ManagedConnector);
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
