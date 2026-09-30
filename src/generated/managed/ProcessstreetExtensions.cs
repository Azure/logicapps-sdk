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
        public IBodyWorkflowAction<SimpleUser> GetUser([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SimpleUser>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<CreateWorkflowRunResponse> CreateWorkflowRun([WorkflowExpression] Func<string> bodyworkflowId, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bool> bodyshared = null)
        {
            SourceExpression.Validate(bodyworkflowId, nameof(bodyworkflowId), required: true);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyshared, nameof(bodyshared), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/workflow-runs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyshared != null)
                {
                    body["shared"] = SourceExpressionConverter.ConvertToken(bodyshared);
                    bodypropCount++;
                }

                bodypropCount++;
                body["workflowId"] = SourceExpressionConverter.ConvertToken(bodyworkflowId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateWorkflowRunResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<WorkflowRunResponse> UpdateWorkflowRun([WorkflowExpression] Func<string> workflowRunId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bool> bodyshared, [WorkflowExpression] Func<bodystatusInput> bodystatus, [WorkflowExpression] Func<string> bodydueDate = null)
        {
            SourceExpression.Validate(workflowRunId, nameof(workflowRunId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyshared, nameof(bodyshared), required: true);
            SourceExpression.Validate(bodystatus, nameof(bodystatus), required: true);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflow-runs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workflowRunId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydueDate != null)
                {
                    body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["shared"] = SourceExpressionConverter.ConvertToken(bodyshared);
                bodypropCount++;
                body["status"] = SourceExpressionConverter.Convert(bodystatus);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkflowRunResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<JToken> ListFormFieldValues([WorkflowExpression] Func<string> workflowRunId, [WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<string> taskId = null)
        {
            SourceExpression.Validate(workflowRunId, nameof(workflowRunId), required: true);
            SourceExpression.Validate(workflowId, nameof(workflowId), required: true);
            SourceExpression.Validate(taskId, nameof(taskId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflow-runs/{0}/form-fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workflowRunId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workflowId"] = SourceExpressionConverter.ConvertO(workflowId);
                if (taskId != null)
                    callPayload.Queries["taskId"] = SourceExpressionConverter.ConvertO(taskId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<FindWorkflowRunsResponse> FindWorkflowRuns([WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<string[]> bodyassignees = null, [WorkflowExpression] Func<object> bodyformFields = null, [WorkflowExpression] Func<string> bodyname = null)
        {
            SourceExpression.Validate(workflowId, nameof(workflowId), required: true);
            SourceExpression.Validate(bodyassignees, nameof(bodyassignees), required: false);
            SourceExpression.Validate(bodyformFields, nameof(bodyformFields), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflows/{0}/workflow-runs/search", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workflowId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyassignees != null)
                {
                    body["assignees"] = SourceExpressionConverter.ConvertToken(bodyassignees);
                    bodypropCount++;
                }

                if (bodyformFields != null)
                {
                    body["formFields"] = SourceExpressionConverter.ConvertToken(bodyformFields);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FindWorkflowRunsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "processstreet")]
        public IBodyWorkflowAction<UpdateMultipleFormFieldValuesResponse> UpdateFormFieldValuesWithWorkflowId([WorkflowExpression] Func<string> workflowId, [WorkflowExpression] Func<string> workflowRunId, [WorkflowExpression] Func<string> taskId = null, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(workflowId, nameof(workflowId), required: true);
            SourceExpression.Validate(workflowRunId, nameof(workflowRunId), required: true);
            SourceExpression.Validate(taskId, nameof(taskId), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/workflows/{0}/workflow-runs/{1}/form-fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workflowId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workflowRunId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (taskId != null)
                    callPayload.Queries["taskId"] = SourceExpressionConverter.ConvertO(taskId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<UpdateMultipleFormFieldValuesResponse>(BuildSourceInput);
        }
    }

    public class ProcessstreetTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateTaskStateChangedTrigger([WorkflowExpression] Func<bodytaskStateInput> bodytaskState, [WorkflowExpression] Func<string> bodytaskId = null, [WorkflowExpression] Func<string> bodyworkflowId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytaskState, nameof(bodytaskState), required: true);
            SourceExpression.Validate(bodytaskId, nameof(bodytaskId), required: false);
            SourceExpression.Validate(bodyworkflowId, nameof(bodyworkflowId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/triggers/task-state-changed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytaskId != null)
                {
                    body["taskId"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["triggerType"] = SourceExpressionConverter.Convert(bodytaskState);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodyworkflowId != null)
                {
                    body["workflowId"] = SourceExpressionConverter.ConvertToken(bodyworkflowId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CreateWorkflowRunCompletedTrigger([WorkflowExpression] Func<string> bodyworkflowId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkflowId, nameof(bodyworkflowId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/triggers/workflow-run-completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodyworkflowId != null)
                {
                    body["workflowId"] = SourceExpressionConverter.ConvertToken(bodyworkflowId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CreateWorkflowRunCreatedTrigger([WorkflowExpression] Func<string> bodyworkflowId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyworkflowId, nameof(bodyworkflowId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/triggers/workflow-run-created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodyworkflowId != null)
                {
                    body["workflowId"] = SourceExpressionConverter.ConvertToken(bodyworkflowId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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

    public enum WorkflowRunResponseStatusType
    {
        Active,
        Completed,
        Archived,
        Deleted
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