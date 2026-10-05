//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Processstreet
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProcessstreetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorkflowRun))]
        public IBodyWorkflowAction<CreateWorkflowRunResponse> CreateWorkflowRun([WorkflowExpression] Func<string> bodyworkflowID, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydueDate = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateWorkflowRunResponse> __BuildCreateWorkflowRun(WorkflowValue<string> bodyworkflowID, WorkflowValue<string> bodyname, WorkflowValue<string> bodydueDate = null)
        {
            WorkflowValue.Validate(bodyworkflowID, nameof(bodyworkflowID), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodydueDate, nameof(bodydueDate), required: false);
            return new DeferredBodyAction<CreateWorkflowRunResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        [WorkflowExpressionFactory(nameof(__BuildGetUser))]
        public IBodyWorkflowAction<SimpleUser> GetUser([WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SimpleUser> __BuildGetUser(WorkflowValue<string> userId)
        {
            WorkflowValue.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<SimpleUser>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SimpleUser>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateWorkflowRun))]
        public IBodyWorkflowAction<WorkflowRunResponse> UpdateWorkflowRun([WorkflowExpression] Func<string> workflowRunId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodydueDate, [WorkflowExpression] Func<bool> bodyshared)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkflowRunResponse> __BuildUpdateWorkflowRun(WorkflowValue<string> workflowRunId, WorkflowValue<string> bodyname, WorkflowValue<bodystatusInput> bodystatus, WorkflowValue<string> bodydueDate, WorkflowValue<bool> bodyshared)
        {
            WorkflowValue.Validate(workflowRunId, nameof(workflowRunId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: true);
            WorkflowValue.Validate(bodydueDate, nameof(bodydueDate), required: true);
            WorkflowValue.Validate(bodyshared, nameof(bodyshared), required: true);
            return new DeferredBodyAction<WorkflowRunResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/workflow-runs/{0}", ExpressionConverter.ConvertWithUrlEncoding(workflowRunId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        [WorkflowExpressionFactory(nameof(__BuildFindWorkflowRuns))]
        public IBodyWorkflowAction<FindWorkflowRunsResponse> FindWorkflowRuns([WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string[]> bodyassignees = null, [WorkflowExpression] Func<object> bodyformFields = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindWorkflowRunsResponse> __BuildFindWorkflowRuns(WorkflowValue<string> workflowId, WorkflowValue<string> bodyname = null, WorkflowValue<string[]> bodyassignees = null, WorkflowValue<object> bodyformFields = null)
        {
            WorkflowValue.Validate(workflowId, nameof(workflowId), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodyassignees, nameof(bodyassignees), required: false);
            WorkflowValue.Validate(bodyformFields, nameof(bodyformFields), required: false);
            return new DeferredBodyAction<FindWorkflowRunsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/workflows/{0}/workflow-runs/search", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        [WorkflowExpressionFactory(nameof(__BuildListFormFieldValues))]
        public IBodyWorkflowAction<JToken> ListFormFieldValues([WorkflowExpression] Func<string> workflowRunId, [WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<string> taskId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildListFormFieldValues(WorkflowValue<string> workflowRunId, WorkflowValue<string> workflowId, WorkflowValue<string> taskId = null)
        {
            WorkflowValue.Validate(workflowRunId, nameof(workflowRunId), required: true);
            WorkflowValue.Validate(workflowId, nameof(workflowId), required: true);
            WorkflowValue.Validate(taskId, nameof(taskId), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/workflow-runs/{0}/form-fields", ExpressionConverter.ConvertWithUrlEncoding(workflowRunId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workflowId"] = ExpressionConverter.Convert(workflowId);
                if (taskId != null)
                    callPayload.Queries["taskId"] = ExpressionConverter.Convert(taskId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateFormFieldValuesWithWorkflowId))]
        public IBodyWorkflowAction<UpdateMultipleFormFieldValuesResponse> UpdateFormFieldValuesWithWorkflowId([WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<string> workflowRunId, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateMultipleFormFieldValuesResponse> __BuildUpdateFormFieldValuesWithWorkflowId(WorkflowValue<string> workflowId, WorkflowValue<string> workflowRunId, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(workflowId, nameof(workflowId), required: true);
            WorkflowValue.Validate(workflowRunId, nameof(workflowRunId), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateMultipleFormFieldValuesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/workflows/{0}/workflow-runs/{1}/form-fields", ExpressionConverter.ConvertWithUrlEncoding(workflowId, 1), ExpressionConverter.ConvertWithUrlEncoding(workflowRunId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<UpdateMultipleFormFieldValuesResponse>(callPayload);
            });
        }
    }

    public class ProcessstreetTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildCreateTaskStateChangedTrigger))]
        public IWorkflowTrigger CreateTaskStateChangedTrigger([WorkflowExpression] Func<bodytaskStateInput> bodytaskState, [WorkflowExpression] Func<string> bodyworkflowID = null, [WorkflowExpression] Func<string> bodytaskID = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateTaskStateChangedTrigger(WorkflowValue<bodytaskStateInput> bodytaskState, WorkflowValue<string> bodyworkflowID = null, WorkflowValue<string> bodytaskID = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytaskState, nameof(bodytaskState), required: true);
            WorkflowValue.Validate(bodyworkflowID, nameof(bodyworkflowID), required: false);
            WorkflowValue.Validate(bodytaskID, nameof(bodytaskID), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/triggers/task-state-changed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateWorkflowRunCreatedTrigger))]
        public IWorkflowTrigger CreateWorkflowRunCreatedTrigger([WorkflowExpression] Func<string> bodyworkflowID = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateWorkflowRunCreatedTrigger(WorkflowValue<string> bodyworkflowID = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyworkflowID, nameof(bodyworkflowID), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/triggers/workflow-run-created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateWorkflowRunCompletedTrigger))]
        public IWorkflowTrigger CreateWorkflowRunCompletedTrigger([WorkflowExpression] Func<string> bodyworkflowID = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateWorkflowRunCompletedTrigger(WorkflowValue<string> bodyworkflowID = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyworkflowID, nameof(bodyworkflowID), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/triggers/workflow-run-completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
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

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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
