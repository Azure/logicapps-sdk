//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Processstreet
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProcessstreetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<CreateWorkflowRunResponse> CreateWorkflowRun(Expression<Func<string>> bodyworkflowID, Expression<Func<string>> bodyname, Expression<Func<string>> bodydueDate = null)
        {
            var apiCallPath = "/workflow-runs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["workflowId"] = ExpressionConverter.ConvertO(bodyworkflowID);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodydueDate != null)
            {
                body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateWorkflowRunResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<SimpleUser> GetUser(Expression<Func<string>> userId)
        {
            var apiCallPath = String.Format("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SimpleUser>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<WorkflowRunResponse> UpdateWorkflowRun(Expression<Func<string>> workflowRunId, Expression<Func<string>> bodyname, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodydueDate, Expression<Func<bool>> bodyshared)
        {
            var apiCallPath = String.Format("/workflow-runs/{0}", ExpressionConverter.ConvertWithUrlEncoding(workflowRunId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            bodypropCount++;
            body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
            bodypropCount++;
            body["shared"] = ExpressionConverter.ConvertO(bodyshared);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkflowRunResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<FindWorkflowRunsResponse> FindWorkflowRuns(Expression<Func<string>> workflowId, Expression<Func<string>> bodyname = null, Expression<Func<string[]>> bodyassignees = null, Expression<Func<object>> bodyformFields = null)
        {
            var apiCallPath = String.Format("/workflows/{0}/workflow-runs/search", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyassignees != null)
            {
                body["assignees"] = ExpressionConverter.ConvertO(bodyassignees);
                bodypropCount++;
            }

            if (bodyformFields != null)
            {
                body["formFields"] = ExpressionConverter.ConvertO(bodyformFields);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<FindWorkflowRunsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<JToken> ListFormFieldValues(Expression<Func<string>> workflowRunId, Expression<Func<string>> workflowId, Expression<Func<string>> taskId = null)
        {
            var apiCallPath = String.Format("/workflow-runs/{0}/form-fields", ExpressionConverter.ConvertWithUrlEncoding(workflowRunId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workflowId"] = ExpressionConverter.Convert(workflowId);
            if (taskId != null)
                callPayload.Queries["taskId"] = ExpressionConverter.Convert(taskId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<UpdateMultipleFormFieldValuesResponse> UpdateFormFieldValuesWithWorkflowId(Expression<Func<string>> workflowId, Expression<Func<string>> workflowRunId, Expression<Func<object>> body = null)
        {
            var apiCallPath = String.Format("/workflows/{0}/workflow-runs/{1}/form-fields", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1), ExpressionConverter.ConvertWithUrlEncoding(workflowRunId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<UpdateMultipleFormFieldValuesResponse>(callPayload);
        }
    }

    public class ProcessstreetTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateTaskStateChangedTrigger(Expression<Func<bodytaskStateInput>> bodytaskState, Expression<Func<string>> bodyworkflowID = null, Expression<Func<string>> bodytaskID = null, string triggerName = null)
        {
            var apiCallPath = "/triggers/task-state-changed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodyworkflowID != null)
            {
                body["workflowId"] = ExpressionConverter.ConvertO(bodyworkflowID);
                bodypropCount++;
            }

            if (bodytaskID != null)
            {
                body["taskId"] = ExpressionConverter.ConvertO(bodytaskID);
                bodypropCount++;
            }

            bodypropCount++;
            body["triggerType"] = ExpressionConverter.ConvertO(bodytaskState);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger CreateWorkflowRunCreatedTrigger(Expression<Func<string>> bodyworkflowID = null, string triggerName = null)
        {
            var apiCallPath = "/triggers/workflow-run-created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodyworkflowID != null)
            {
                body["workflowId"] = ExpressionConverter.ConvertO(bodyworkflowID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger CreateWorkflowRunCompletedTrigger(Expression<Func<string>> bodyworkflowID = null, string triggerName = null)
        {
            var apiCallPath = "/triggers/workflow-run-completed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodyworkflowID != null)
            {
                body["workflowId"] = ExpressionConverter.ConvertO(bodyworkflowID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }

    public class CreateWorkflowRunResponse
    {
        [JsonProperty("workflowRun")]
        public WorkflowRunResponse WorkflowRun { get; set; }
    }

    public class WorkflowRunResponse
    {
        [JsonProperty("completedById")]
        public string CompletedById { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shared")]
        public bool Shared { get; set; }

        [JsonProperty("status")]
        public WorkflowRunResponseStatusType Status { get; set; }

        [JsonProperty("updatedById")]
        public string UpdatedById { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("workflowId")]
        public string WorkflowId { get; set; }

        [JsonProperty("workflowRunUrl")]
        public string WorkflowRunUrl { get; set; }

        [JsonProperty("workflowName")]
        public string WorkflowName { get; set; }

        [JsonProperty("workflowUrl")]
        public string WorkflowUrl { get; set; }
    }

    public enum WorkflowRunResponseStatusType
    {
        Active,
        Completed,
        Archived,
        Deleted
    }

    public class SimpleUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("userType")]
        public string UserType { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
    }

    public enum bodystatusInput
    {
        Active,
        Completed,
        Archived,
        Deleted
    }

    public class FindWorkflowRunsResponse
    {
        [JsonProperty("workflowRuns")]
        public WorkflowRunResponse[] WorkflowRuns { get; set; }
    }

    public class UpdateMultipleFormFieldValuesResponse
    {
        [JsonProperty("fields")]
        public SimplifiedFormFieldValue[] Fields { get; set; }
    }

    public class SimplifiedFormFieldValue
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("taskId")]
        public string TaskId { get; set; }
    }

    public enum bodytaskStateInput
    {
        [EnumMember(Value = "Task Checked")]
        TaskChecked,
        [EnumMember(Value = "Task Unchecked")]
        TaskUnchecked,
        [EnumMember(Value = "Task Checked or Unchecked")]
        TaskCheckedOrUnchecked,
        [EnumMember(Value = "Task Ready")]
        TaskReady
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Processstreet;

    public partial class WorkflowManagedActions
    {
        public ProcessstreetActions Processstreet(string connectionId) => new ProcessstreetActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ProcessstreetTriggers Processstreet(string connectionId) => new ProcessstreetTriggers(connectionId);
    }
}