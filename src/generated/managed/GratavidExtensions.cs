//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Gratavid
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
        }
    }

    public class GratavidTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger NewEvent(Expression<Func<webookHookEventInput>> webookHookEvent)
        {
            var apiCallPath = "/api/manageIntegrations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = Convert.ToString("microsoftPowerAutomate");
            callPayload.Queries["event"] = Convert.ToString("webhookSubscribe");
            callPayload.Queries["webookHookEvent"] = ExpressionConverter.Convert(webookHookEvent);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookURL"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Gratavid;

    public partial class WorkflowManagedActions
    {
        public GratavidActions Gratavid(string connectionId) => new GratavidActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GratavidTriggers Gratavid(string connectionId) => new GratavidTriggers(connectionId);
    }
}