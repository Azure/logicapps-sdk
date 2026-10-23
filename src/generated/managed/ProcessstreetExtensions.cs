//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Processstreet
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProcessstreetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<CreateWorkflowRunResponse> CreateWorkflowRun(Expression<Func<string>> bodyworkflowID, Expression<Func<string>> bodyname, Expression<Func<string>> bodydueDate = null)
        {
            var __workflow_bodyworkflowID = WorkflowExpression.Compile(bodyworkflowID, nameof(bodyworkflowID), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            return new DeferredBodyAction<CreateWorkflowRunResponse>(() =>
            {
                var apiCallPath = "/workflow-runs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workflowId"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowID);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodydueDate != null)
                {
                    body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateWorkflowRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<SimpleUser> GetUser(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<SimpleUser>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SimpleUser>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<WorkflowRunResponse> UpdateWorkflowRun(Expression<Func<string>> workflowRunId, Expression<Func<string>> bodyname, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodydueDate, Expression<Func<bool>> bodyshared)
        {
            var __workflow_workflowRunId = WorkflowExpression.Compile(workflowRunId, nameof(workflowRunId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: true);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: true);
            var __workflow_bodyshared = WorkflowExpression.Compile(bodyshared, nameof(bodyshared), required: true);
            return new DeferredBodyAction<WorkflowRunResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflow-runs/{0}", __workflow_workflowRunId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                bodypropCount++;
                body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                bodypropCount++;
                body["shared"] = ExpressionConverter.ConvertO(__workflow_bodyshared);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WorkflowRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<FindWorkflowRunsResponse> FindWorkflowRuns(Expression<Func<string>> workflowId, Expression<Func<string>> bodyname = null, Expression<Func<string[]>> bodyassignees = null, Expression<Func<object>> bodyformFields = null)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyassignees = WorkflowExpression.Compile(bodyassignees, nameof(bodyassignees), required: false);
            var __workflow_bodyformFields = WorkflowExpression.Compile(bodyformFields, nameof(bodyformFields), required: false);
            return new DeferredBodyAction<FindWorkflowRunsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflows/{0}/workflow-runs/search", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyassignees != null)
                {
                    body["assignees"] = ExpressionConverter.ConvertO(__workflow_bodyassignees);
                    bodypropCount++;
                }

                if (__workflow_bodyformFields != null)
                {
                    body["formFields"] = ExpressionConverter.ConvertO(__workflow_bodyformFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<FindWorkflowRunsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<JToken> ListFormFieldValues(Expression<Func<string>> workflowRunId, Expression<Func<string>> workflowId, Expression<Func<string>> taskId = null)
        {
            var __workflow_workflowRunId = WorkflowExpression.Compile(workflowRunId, nameof(workflowRunId), required: true);
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflow-runs/{0}/form-fields", __workflow_workflowRunId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workflowId"] = ExpressionConverter.Convert(__workflow_workflowId);
                if (__workflow_taskId != null)
                    callPayload.Queries["taskId"] = ExpressionConverter.Convert(__workflow_taskId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<UpdateMultipleFormFieldValuesResponse> UpdateFormFieldValuesWithWorkflowId(Expression<Func<string>> workflowId, Expression<Func<string>> workflowRunId, Expression<Func<object>> body = null)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_workflowRunId = WorkflowExpression.Compile(workflowRunId, nameof(workflowRunId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateMultipleFormFieldValuesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflows/{0}/workflow-runs/{1}/form-fields", __workflow_workflowId.WithUrlEncoding(1), __workflow_workflowRunId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateMultipleFormFieldValuesResponse>(callPayload);
            });
        }
    }

    public class ProcessstreetTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateTaskStateChangedTrigger(Expression<Func<bodytaskStateInput>> bodytaskState, Expression<Func<string>> bodyworkflowID = null, Expression<Func<string>> bodytaskID = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytaskState = WorkflowExpression.Compile(bodytaskState, nameof(bodytaskState), required: true);
            var __workflow_bodyworkflowID = WorkflowExpression.Compile(bodyworkflowID, nameof(bodyworkflowID), required: false);
            var __workflow_bodytaskID = WorkflowExpression.Compile(bodytaskID, nameof(bodytaskID), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/triggers/task-state-changed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodyworkflowID != null)
                {
                    body["workflowId"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowID);
                    bodypropCount++;
                }

                if (__workflow_bodytaskID != null)
                {
                    body["taskId"] = ExpressionConverter.ConvertO(__workflow_bodytaskID);
                    bodypropCount++;
                }

                bodypropCount++;
                body["triggerType"] = ExpressionConverter.ConvertO(__workflow_bodytaskState);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger CreateWorkflowRunCreatedTrigger(Expression<Func<string>> bodyworkflowID = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkflowID = WorkflowExpression.Compile(bodyworkflowID, nameof(bodyworkflowID), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/triggers/workflow-run-created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodyworkflowID != null)
                {
                    body["workflowId"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger CreateWorkflowRunCompletedTrigger(Expression<Func<string>> bodyworkflowID = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyworkflowID = WorkflowExpression.Compile(bodyworkflowID, nameof(bodyworkflowID), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/triggers/workflow-run-completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodyworkflowID != null)
                {
                    body["workflowId"] = ExpressionConverter.ConvertO(__workflow_bodyworkflowID);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
