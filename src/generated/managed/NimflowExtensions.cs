//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nimflow
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NimflowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nimflow")]
        public IBodyWorkflowAction<DispatchContextActionResult, ApiConnectionActionConfiguration> ContextsDispatchAction(Expression<Func<ContextsDispatchActionCommandInput>> command)
        {
            var __workflow_command = WorkflowExpression.Compile(command, nameof(command), required: true);
            return new DeferredBodyAction<DispatchContextActionResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Contexts/DispatchAction";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_command);
                return new ApiConnectionAction<DispatchContextActionResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nimflow")]
        public IBodyWorkflowAction<AddTaskResponseResult, ApiConnectionActionConfiguration> TasksAddResponse(Expression<Func<TasksAddResponseCommandInput>> command)
        {
            var __workflow_command = WorkflowExpression.Compile(command, nameof(command), required: true);
            return new DeferredBodyAction<AddTaskResponseResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Tasks/AddResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_command);
                return new ApiConnectionAction<AddTaskResponseResult>(callPayload);
            });
        }
    }

    public class NimflowTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WhenTaskCreatedPost(Expression<Func<WhenTaskArchivedPostRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/WhenTaskCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WhenTaskUpdatedPost(Expression<Func<WhenTaskArchivedPostRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/WhenTaskUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WhenTaskArchivedPost(Expression<Func<WhenTaskArchivedPostRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/WhenTaskArchived";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WhenMilestoneReachedPost(Expression<Func<WhenMilestoneClearedPostRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/WhenMilestoneReached";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> WhenMilestoneClearedPost(Expression<Func<WhenMilestoneClearedPostRequestInput>> request)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/WhenMilestoneCleared";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class DispatchContextActionResult
    {
        [JsonProperty("contextId")]
        public string ContextId { get; set; }

        [JsonProperty("isNew")]
        public bool IsNew { get; set; }
    }

    public class ContextsDispatchActionCommandInput
    {
        [JsonProperty("contextTypeName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContextTypeName { get; set; }

        [JsonProperty("reference", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Reference { get; set; }

        [JsonProperty("action", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Action { get; set; }

        [JsonProperty("payload")]
        public JToken Payload { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }
    }

    public class AddTaskResponseResult
    {
        [JsonProperty("responseId")]
        public string ResponseId { get; set; }
    }

    public class TasksAddResponseCommandInput
    {
        [JsonProperty("contextReference", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContextReference { get; set; }

        [JsonProperty("sentBy")]
        public string SentBy { get; set; }

        [JsonProperty("payload")]
        public JToken Payload { get; set; }

        [JsonProperty("startedOn")]
        public string StartedOn { get; set; }

        [JsonProperty("sentOn")]
        public string SentOn { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("contextTypeName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContextTypeName { get; set; }

        [JsonProperty("taskTypeName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TaskTypeName { get; set; }

        [JsonProperty("responseTypeName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ResponseTypeName { get; set; }

        [JsonProperty("itemKey")]
        public string ItemKey { get; set; }
    }

    public class WhenTaskArchivedPostRequestInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("contextTypeName")]
        public string ContextTypeName { get; set; }

        [JsonProperty("taskTypeName")]
        public string TaskTypeName { get; set; }
    }

    public class WhenMilestoneClearedPostRequestInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("contextTypeName")]
        public string ContextTypeName { get; set; }

        [JsonProperty("milestoneName")]
        public string MilestoneName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nimflow;

    public partial class WorkflowManagedActions
    {
        public NimflowActions Nimflow(string connectionId) => new NimflowActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NimflowTriggers Nimflow(string connectionId) => new NimflowTriggers(connectionId);
    }
}