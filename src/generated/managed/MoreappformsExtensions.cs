//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Moreappforms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MoreappformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moreappforms")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateTask(Expression<Func<string>> formId, Expression<Func<CreateTaskInput>> body)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1.0/customers/:customerId:/{0}/tasks", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moreappforms")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DownloadFile(Expression<Func<string>> fileId)
        {
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1.0/customers/:customerId:/registrationFile/{0}/download", __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moreappforms")]
        public IBodyWorkflowAction<object, ApiConnectionActionConfiguration> DownloadReport(Expression<Func<string>> submissionId, Expression<Func<int>> reportNumber)
        {
            var __workflow_submissionId = WorkflowExpression.Compile(submissionId, nameof(submissionId), required: true);
            var __workflow_reportNumber = WorkflowExpression.Compile(reportNumber, nameof(reportNumber), required: true);
            return new DeferredBodyAction<object, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1.0/customers/:customerId:/submissions/{0}", __workflow_submissionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["reportNumber"] = ExpressionConverter.Convert(__workflow_reportNumber);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "moreappforms")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetFormVersion(Expression<Func<string>> formId)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1.0/forms/customer/:customerId:/forms/{0}/versions", __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class MoreappformsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> NewSubmission(Expression<Func<string>> formId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v1.0/webhooks/customer/:customerId:/subscribers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_formId != null)
                    callPayload.Headers["formId"] = ExpressionConverter.Convert(__workflow_formId);
                callPayload.Body = new NewSubmissionInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TaskFulfilled(Expression<Func<string>> formId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v1.0/webhooks/customer/:customerId1:/subscribers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_formId != null)
                    callPayload.Headers["formId"] = ExpressionConverter.Convert(__workflow_formId);
                callPayload.Body = new TaskFulfilledInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateTaskInput
    {
        [JsonProperty("recipients")]
        public string[] Recipients { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("publishInfo", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateTaskInputPublishInfoType PublishInfo { get; set; }
    }

    public class CreateTaskInputPublishInfoType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "IMMEDIATE";
    }

    public class NewSubmissionInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate: New submission";

        [JsonProperty("type")]
        public string[] Type { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Status { get; set; } = "ACTIVE";
    }

    public class TaskFulfilledInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Name { get; set; } = "Power Automate: Task fulfilled";

        [JsonProperty("type")]
        public string[] Type { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Status { get; set; } = "ACTIVE";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Moreappforms;

    public partial class WorkflowManagedActions
    {
        public MoreappformsActions Moreappforms(string connectionId) => new MoreappformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MoreappformsTriggers Moreappforms(string connectionId) => new MoreappformsTriggers(connectionId);
    }
}