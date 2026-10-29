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
        public IBodyWorkflowAction<DispatchContextActionResult, ApiConnectionActionConfiguration> ContextsDispatchAction(Expression<Func<ContextsDispatchActionInput>> command)
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
        public IBodyWorkflowAction<AddTaskResponseResult, ApiConnectionActionConfiguration> TasksAddResponse(Expression<Func<TasksAddResponseInput>> command)
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
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenTaskCreatedPost(Expression<Func<WhenTaskCreatedPostInput>> request, FlowRecurrence recurrence = null)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/WhenTaskCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenTaskUpdatedPost(Expression<Func<WhenTaskUpdatedPostInput>> request, FlowRecurrence recurrence = null)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/WhenTaskUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenTaskArchivedPost(Expression<Func<WhenTaskArchivedPostInput>> request, FlowRecurrence recurrence = null)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/WhenTaskArchived";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenMilestoneReachedPost(Expression<Func<WhenMilestoneReachedPostInput>> request, FlowRecurrence recurrence = null)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/WhenMilestoneReached";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> WhenMilestoneClearedPost(Expression<Func<WhenMilestoneClearedPostInput>> request, FlowRecurrence recurrence = null)
        {
            var __workflow_request = WorkflowExpression.Compile(request, nameof(request), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/WhenMilestoneCleared";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_request);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
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

    public class ContextsDispatchActionInput
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

    public class TasksAddResponseInput
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

    public class WhenTaskCreatedPostInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("contextTypeName")]
        public string ContextTypeName { get; set; }

        [JsonProperty("taskTypeName")]
        public string TaskTypeName { get; set; }
    }

    public class WhenTaskUpdatedPostInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("contextTypeName")]
        public string ContextTypeName { get; set; }

        [JsonProperty("taskTypeName")]
        public string TaskTypeName { get; set; }
    }

    public class WhenTaskArchivedPostInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("contextTypeName")]
        public string ContextTypeName { get; set; }

        [JsonProperty("taskTypeName")]
        public string TaskTypeName { get; set; }
    }

    public class WhenMilestoneReachedPostInput
    {
        [JsonProperty("callbackUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string CallbackUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("contextTypeName")]
        public string ContextTypeName { get; set; }

        [JsonProperty("milestoneName")]
        public string MilestoneName { get; set; }
    }

    public class WhenMilestoneClearedPostInput
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