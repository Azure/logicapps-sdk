//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Gratavid
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GratavidActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gratavid")]
        public IBodyWorkflowAction<CreateTaskResponse> CreateTask(Expression<Func<string>> bodyemail, Expression<Func<string>> bodycomments, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodycustomUserId = null, Expression<Func<string>> bodycustomAccountId = null, Expression<Func<string>> bodytextOptIn = null, Expression<Func<string>> bodycellNumber = null, Expression<Func<string>> bodyassignedTo = null)
        {
            var apiCallPath = "/api/integrationsEndpoint";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = Convert.ToString("microsoftPowerAutomate");
            callPayload.Queries["event"] = Convert.ToString("createTask");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            if (bodyfirstName != null)
            {
                body["firstName"] = CSharpExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = CSharpExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
            }

            if (bodycustomUserId != null)
            {
                body["customUserId"] = CSharpExpressionConverter.ConvertToken(bodycustomUserId);
                bodypropCount++;
            }

            if (bodycustomAccountId != null)
            {
                body["customAccountId"] = CSharpExpressionConverter.ConvertToken(bodycustomAccountId);
                bodypropCount++;
            }

            if (bodytextOptIn != null)
            {
                body["textOptIn"] = CSharpExpressionConverter.ConvertToken(bodytextOptIn);
                bodypropCount++;
            }

            if (bodycellNumber != null)
            {
                body["cellNumber"] = CSharpExpressionConverter.ConvertToken(bodycellNumber);
                bodypropCount++;
            }

            bodypropCount++;
            body["comments"] = CSharpExpressionConverter.ConvertToken(bodycomments);
            if (bodyassignedTo != null)
            {
                body["assignedTo"] = CSharpExpressionConverter.ConvertToken(bodyassignedTo);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateTaskResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "gratavid")]
        public IBodyWorkflowAction<SendNoteResponse> SendNote(Expression<Func<string>> bodynoteId, Expression<Func<string>> bodyemail, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodycustomUserId = null, Expression<Func<string>> bodycustomAccountId = null, Expression<Func<string>> bodytextOptIn = null, Expression<Func<string>> bodycellNumber = null)
        {
            var apiCallPath = "/api/integrationsEndpoint";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = Convert.ToString("microsoftPowerAutomate");
            callPayload.Queries["event"] = Convert.ToString("sendNote");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["noteId"] = CSharpExpressionConverter.ConvertToken(bodynoteId);
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            if (bodyfirstName != null)
            {
                body["firstName"] = CSharpExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = CSharpExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
            }

            if (bodycustomUserId != null)
            {
                body["customUserId"] = CSharpExpressionConverter.ConvertToken(bodycustomUserId);
                bodypropCount++;
            }

            if (bodycustomAccountId != null)
            {
                body["customAccountId"] = CSharpExpressionConverter.ConvertToken(bodycustomAccountId);
                bodypropCount++;
            }

            if (bodytextOptIn != null)
            {
                body["textOptIn"] = CSharpExpressionConverter.ConvertToken(bodytextOptIn);
                bodypropCount++;
            }

            if (bodycellNumber != null)
            {
                body["cellNumber"] = CSharpExpressionConverter.ConvertToken(bodycellNumber);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendNoteResponse>(callPayload);
        }
    }

    public class GratavidTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger NewEvent(Expression<Func<webookHookEventInput>> webookHookEvent, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/manageIntegrations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = Convert.ToString("microsoftPowerAutomate");
            callPayload.Queries["event"] = Convert.ToString("webhookSubscribe");
            callPayload.Queries["webookHookEvent"] = CSharpExpressionConverter.Convert(webookHookEvent);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookURL"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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