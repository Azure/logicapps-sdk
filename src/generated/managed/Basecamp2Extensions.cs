//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Basecamp2
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Basecamp2Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp2")]
        public IBodyWorkflowAction<CreateMessageResponse> PostMessage(Expression<Func<int>> id, Expression<Func<int>> projectId, Expression<Func<string>> bodysubject, Expression<Func<string>> bodycontent)
        {
            var apiCallPath = String.Format("/{0}/api/v1/projects/{1}/messages.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["subject"] = ExpressionConverter.ConvertO(bodysubject);
            bodypropCount++;
            body["content"] = ExpressionConverter.ConvertO(bodycontent);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateMessageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp2")]
        public IBodyWorkflowAction<CreateDocumentResponse> CreateDocument(Expression<Func<int>> id, Expression<Func<int>> projectId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodycontent)
        {
            var apiCallPath = String.Format("/{0}/api/v1/projects/{1}/documents.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            bodypropCount++;
            body["content"] = ExpressionConverter.ConvertO(bodycontent);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp2")]
        public IBodyWorkflowAction<CreateToDoResponse> CreateToDo(Expression<Func<int>> id, Expression<Func<int>> projectId, Expression<Func<int>> listId, Expression<Func<string>> bodycontent, Expression<Func<string>> bodydueDate)
        {
            var apiCallPath = String.Format("/{0}/api/v1/projects/{1}/todolists/{2}/todos.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["content"] = ExpressionConverter.ConvertO(bodycontent);
            bodypropCount++;
            body["due_at"] = ExpressionConverter.ConvertO(bodydueDate);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateToDoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "basecamp2")]
        public IBodyWorkflowAction<CreateEventResponse> CreateEvent(Expression<Func<int>> id, Expression<Func<int>> projectId, Expression<Func<string>> bodysummary, Expression<Func<string>> bodydescription, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodyendDate = null, Expression<Func<string>> bodyreminderDate = null)
        {
            var apiCallPath = String.Format("/{0}/api/v1/projects/{1}/calendar_events.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["summary"] = ExpressionConverter.ConvertO(bodysummary);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            bodypropCount++;
            body["starts_at"] = ExpressionConverter.ConvertO(bodystartDate);
            if (bodyendDate != null)
            {
                body["ends_at"] = ExpressionConverter.ConvertO(bodyendDate);
                bodypropCount++;
            }

            if (bodyreminderDate != null)
            {
                body["remind_at"] = ExpressionConverter.ConvertO(bodyreminderDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateEventResponse>(callPayload);
        }
    }

    public class Basecamp2Triggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CreateDocumentResponse[]> OnDocumentCreated(Expression<Func<int>> id, Expression<Func<int>> projectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/{0}/api/v1/projects/{1}/documents.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<CreateDocumentResponse[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CreateToDoResponse[]> OnToDoCreated(Expression<Func<int>> id, Expression<Func<int>> projectId, Expression<Func<int>> listId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/{0}/api/v1/projects/{1}/todolists/{2}/todos.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            return new ApiConnectionTrigger<CreateToDoResponse[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<CreateEventResponse[]> OnEventCreated(Expression<Func<int>> id, Expression<Func<int>> projectId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/trigger/{0}/api/v1/projects/{1}/calendar_events.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString(" application/json");
            return new ApiConnectionTrigger<CreateEventResponse[]>(callPayload, triggerName, recurrence);
        }
    }

    public class CreateMessageResponse
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("private")]
        public bool PrivacyStatus { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class CreateDocumentResponse
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CreateToDoResponse
    {
        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDate { get; set; }

        [JsonProperty("due_at")]
        public string DueDate { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public class CreateEventResponse
    {
        [JsonProperty("all_day")]
        public bool AllDay { get; set; }

        [JsonProperty("created_at")]
        public string CreatedDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ends_at")]
        public string EndTime { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("starts_at")]
        public string StartDate { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Basecamp2;

    public partial class WorkflowManagedActions
    {
        public Basecamp2Actions Basecamp2(string connectionId) => new Basecamp2Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Basecamp2Triggers Basecamp2(string connectionId) => new Basecamp2Triggers(connectionId);
    }
}