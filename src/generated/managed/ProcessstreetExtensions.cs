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
        public IBodyWorkflowAction<SimpleUser, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> userId)
        {
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<SimpleUser, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/users/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SimpleUser>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<CreateWorkflowRunResponse, ApiConnectionActionConfiguration> CreateWorkflowRun(Expression<Func<CreateWorkflowRunInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateWorkflowRunResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/workflow-runs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateWorkflowRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<WorkflowRunResponse, ApiConnectionActionConfiguration> UpdateWorkflowRun(Expression<Func<string>> workflowRunId, Expression<Func<UpdateWorkflowRunInput>> body)
        {
            var __workflow_workflowRunId = WorkflowExpression.Compile(workflowRunId, nameof(workflowRunId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<WorkflowRunResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflow-runs/{0}", __workflow_workflowRunId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WorkflowRunResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ListFormFieldValues(Expression<Func<string>> workflowRunId, Expression<Func<string>> workflowId, Expression<Func<string>> taskId = null)
        {
            var __workflow_workflowRunId = WorkflowExpression.Compile(workflowRunId, nameof(workflowRunId), required: true);
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<FindWorkflowRunsResponse, ApiConnectionActionConfiguration> FindWorkflowRuns(Expression<Func<string>> workflowId, Expression<Func<FindWorkflowRunsInput>> body)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<FindWorkflowRunsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflows/{0}/workflow-runs/search", __workflow_workflowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<FindWorkflowRunsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<UpdateMultipleFormFieldValuesResponse, ApiConnectionActionConfiguration> UpdateFormFieldValuesWithWorkflowId(Expression<Func<string>> workflowId, Expression<Func<string>> workflowRunId, Expression<Func<object>> body, Expression<Func<string>> taskId = null)
        {
            var __workflow_workflowId = WorkflowExpression.Compile(workflowId, nameof(workflowId), required: true);
            var __workflow_workflowRunId = WorkflowExpression.Compile(workflowRunId, nameof(workflowRunId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: false);
            return new DeferredBodyAction<UpdateMultipleFormFieldValuesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/workflows/{0}/workflow-runs/{1}/form-fields", __workflow_workflowId.WithUrlEncoding(1), __workflow_workflowRunId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_taskId != null)
                    callPayload.Queries["taskId"] = ExpressionConverter.Convert(__workflow_taskId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateMultipleFormFieldValuesResponse>(callPayload);
            });
        }
    }

    public class ProcessstreetTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CreateTaskStateChangedTrigger(Expression<Func<CreateTaskStateChangedTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/triggers/task-state-changed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CreateWorkflowRunCompletedTrigger(Expression<Func<CreateWorkflowRunCompletedTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/triggers/workflow-run-completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CreateWorkflowRunCreatedTrigger(Expression<Func<CreateWorkflowRunCreatedTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/triggers/workflow-run-created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class SimpleUser
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("userType")]
        public string UserType { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
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

        [JsonProperty("workflowName")]
        public string WorkflowName { get; set; }

        [JsonProperty("workflowRunUrl")]
        public string WorkflowRunUrl { get; set; }

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

    public class CreateWorkflowRunInput
    {
        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shared")]
        public bool? Shared { get; set; }

        [JsonProperty("workflowId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkflowId { get; set; }
    }

    public class UpdateWorkflowRunInput
    {
        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("shared", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Shared { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateWorkflowRunInputStatusType Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UpdateWorkflowRunInputStatusType
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

    public class FindWorkflowRunsInput
    {
        [JsonProperty("assignees")]
        public string[] Assignees { get; set; }

        [JsonProperty("formFields")]
        public JToken FormFields { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class UpdateMultipleFormFieldValuesResponse
    {
        [JsonProperty("fields")]
        public SimplifiedFormFieldValue[] Fields { get; set; }
    }

    public class SimplifiedFormFieldValue
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("dataSetLinked")]
        public bool DataSetLinked { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("links")]
        public Link[] Links { get; set; }

        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("updatedBy")]
        public SimplifiedUser UpdatedBy { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("workflowRunId")]
        public string WorkflowRunId { get; set; }
    }

    public class Link
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class SimplifiedUser
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class CreateTaskStateChangedTriggerInput
    {
        [JsonProperty("taskId")]
        public string TaskId { get; set; }

        [JsonProperty("triggerType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTaskStateChangedTriggerInputTaskStateType TaskState { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("workflowId")]
        public string WorkflowId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateTaskStateChangedTriggerInputTaskStateType
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

    public class CreateWorkflowRunCompletedTriggerInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("workflowId")]
        public string WorkflowId { get; set; }
    }

    public class CreateWorkflowRunCreatedTriggerInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("workflowId")]
        public string WorkflowId { get; set; }
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