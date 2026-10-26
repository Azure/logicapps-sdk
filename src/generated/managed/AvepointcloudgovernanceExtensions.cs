//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Avepointcloudgovernance
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AvepointcloudgovernanceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FlowGetOffice365Setting(Expression<Func<string>> actionType, Expression<Func<object>> body)
        {
            var __workflow_actionType = WorkflowExpression.Compile(actionType, nameof(actionType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/office365/settings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["actionType"] = ExpressionConverter.Convert(__workflow_actionType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowUpdateOffice365Setting(Expression<Func<string>> actionType, Expression<Func<object>> body)
        {
            var __workflow_actionType = WorkflowExpression.Compile(actionType, nameof(actionType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/office365/settings";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["actionType"] = ExpressionConverter.Convert(__workflow_actionType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FlowGetRequestById(Expression<Func<string>> serviceType, Expression<Func<string>> serviceId, Expression<Func<string>> requestId)
        {
            var __workflow_serviceType = WorkflowExpression.Compile(serviceType, nameof(serviceType), required: true);
            var __workflow_serviceId = WorkflowExpression.Compile(serviceId, nameof(serviceId), required: true);
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/flow/requests/{0}", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["serviceType"] = ExpressionConverter.Convert(__workflow_serviceType);
                callPayload.Queries["serviceId"] = ExpressionConverter.Convert(__workflow_serviceId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FlowSubmitRequest(Expression<Func<string>> serviceType, Expression<Func<string>> serviceId, Expression<Func<object>> body, Expression<Func<string>> delegateUserPrincipalName = null)
        {
            var __workflow_serviceType = WorkflowExpression.Compile(serviceType, nameof(serviceType), required: true);
            var __workflow_serviceId = WorkflowExpression.Compile(serviceId, nameof(serviceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_delegateUserPrincipalName = WorkflowExpression.Compile(delegateUserPrincipalName, nameof(delegateUserPrincipalName), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/requests";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["serviceType"] = ExpressionConverter.Convert(__workflow_serviceType);
                callPayload.Queries["serviceId"] = ExpressionConverter.Convert(__workflow_serviceId);
                if (__workflow_delegateUserPrincipalName != null)
                    callPayload.Queries["DelegateUserPrincipalName"] = ExpressionConverter.Convert(__workflow_delegateUserPrincipalName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IWorkflowAction<ApiConnectionActionConfiguration> FlowEditRequest(Expression<Func<string>> serviceType, Expression<Func<string>> serviceId, Expression<Func<string>> id, Expression<Func<object>> body)
        {
            var __workflow_serviceType = WorkflowExpression.Compile(serviceType, nameof(serviceType), required: true);
            var __workflow_serviceId = WorkflowExpression.Compile(serviceId, nameof(serviceId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/requests";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["serviceType"] = ExpressionConverter.Convert(__workflow_serviceType);
                callPayload.Queries["serviceId"] = ExpressionConverter.Convert(__workflow_serviceId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> FlowListWorkspace(Expression<Func<string>> workspaceType = null, Expression<Func<string>> primaryContact = null, Expression<Func<string>> status = null, Expression<Func<string>> urlorIdorEmail = null, Expression<Func<string>> secondaryContact = null, Expression<Func<int>> top = null, Expression<Func<string>> nextLink = null)
        {
            var __workflow_workspaceType = WorkflowExpression.Compile(workspaceType, nameof(workspaceType), required: false);
            var __workflow_primaryContact = WorkflowExpression.Compile(primaryContact, nameof(primaryContact), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_urlorIdorEmail = WorkflowExpression.Compile(urlorIdorEmail, nameof(urlorIdorEmail), required: false);
            var __workflow_secondaryContact = WorkflowExpression.Compile(secondaryContact, nameof(secondaryContact), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_nextLink = WorkflowExpression.Compile(nextLink, nameof(nextLink), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/workspace";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceType"] = Convert.ToString("All");
                if (__workflow_workspaceType != null)
                    callPayload.Queries["workspaceType"] = ExpressionConverter.Convert(__workflow_workspaceType);
                callPayload.Queries["primaryContact"] = Convert.ToString("");
                if (__workflow_primaryContact != null)
                    callPayload.Queries["primaryContact"] = ExpressionConverter.Convert(__workflow_primaryContact);
                callPayload.Queries["status"] = Convert.ToString("All");
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                callPayload.Queries["urlorIdorEmail"] = Convert.ToString("");
                if (__workflow_urlorIdorEmail != null)
                    callPayload.Queries["urlorIdorEmail"] = ExpressionConverter.Convert(__workflow_urlorIdorEmail);
                callPayload.Queries["secondaryContact"] = Convert.ToString("");
                if (__workflow_secondaryContact != null)
                    callPayload.Queries["secondaryContact"] = ExpressionConverter.Convert(__workflow_secondaryContact);
                callPayload.Queries["top"] = Convert.ToString(2000);
                if (__workflow_top != null)
                    callPayload.Queries["top"] = ExpressionConverter.Convert(__workflow_top);
                callPayload.Queries["nextLink"] = Convert.ToString("");
                if (__workflow_nextLink != null)
                    callPayload.Queries["nextLink"] = ExpressionConverter.Convert(__workflow_nextLink);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> FlowWorkspaceActions(Expression<Func<string>> workspaceType, Expression<Func<string>> workspaceAction, Expression<Func<object>> body)
        {
            var __workflow_workspaceType = WorkflowExpression.Compile(workspaceType, nameof(workspaceType), required: true);
            var __workflow_workspaceAction = WorkflowExpression.Compile(workspaceAction, nameof(workspaceAction), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/workspace/actions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["workspaceType"] = ExpressionConverter.Convert(__workflow_workspaceType);
                callPayload.Queries["workspaceAction"] = ExpressionConverter.Convert(__workflow_workspaceAction);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class AvepointcloudgovernanceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForCommon(Expression<Func<string>> flowTriggerType, Expression<Func<FlowCreateHookForCommonInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_flowTriggerType = WorkflowExpression.Compile(flowTriggerType, nameof(flowTriggerType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/common";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["flowTriggerType"] = ExpressionConverter.Convert(__workflow_flowTriggerType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForErrorTaskCreated(Expression<Func<FlowCreateHookForErrorTaskCreatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/errortask/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForErrorTaskRetried(Expression<Func<FlowCreateHookForErrorTaskRetriedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/errortask/retried";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForRequestCancelled(Expression<Func<FlowCreateHookForRequestCancelledInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/request/cancelled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForRequestCompleted(Expression<Func<FlowCreateHookForRequestCompletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/request/completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForRequestSubmitted(Expression<Func<FlowCreateHookForRequestSubmittedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/request/submitted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForTaskApproved(Expression<Func<FlowCreateHookForTaskApprovedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/task/approved";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForFullyAutoImportCompleted(Expression<Func<FlowCreateHookForFullyAutoImportCompletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/task/autoimport";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForConfirmDetailCompleted(Expression<Func<FlowCreateHookForConfirmDetailCompletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/task/confirm";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForTaskCreated(Expression<Func<FlowCreateHookForTaskCreatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/task/created";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForTaskRejected(Expression<Func<FlowCreateHookForTaskRejectedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/task/rejected";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForRenewalTaskCompleted(Expression<Func<FlowCreateHookForRenewalTaskCompletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/task/renewal/completed";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForRenewalTaskException(Expression<Func<FlowCreateHookForRenewalTaskExceptionInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/task/renewal/exception";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForRenewalTaskOverdue(Expression<Func<FlowCreateHookForRenewalTaskOverdueInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/task/renewal/overdue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string, ApiConnectionTriggerConfiguration> FlowCreateHookForErrorTaskSkipped(Expression<Func<FlowCreateHookForErrorTaskSkippedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<string, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/flow/hooks/task/skipped";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class FlowCreateHookForCommonInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForErrorTaskCreatedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForErrorTaskRetriedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForRequestCancelledInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForRequestCompletedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForRequestSubmittedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForTaskApprovedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForFullyAutoImportCompletedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForConfirmDetailCompletedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForTaskCreatedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForTaskRejectedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForRenewalTaskCompletedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForRenewalTaskExceptionInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForRenewalTaskOverdueInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }

    public class FlowCreateHookForErrorTaskSkippedInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TriggeUrl { get; set; } = "#{listCallbackUrl()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Avepointcloudgovernance;

    public partial class WorkflowManagedActions
    {
        public AvepointcloudgovernanceActions Avepointcloudgovernance(string connectionId) => new AvepointcloudgovernanceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AvepointcloudgovernanceTriggers Avepointcloudgovernance(string connectionId) => new AvepointcloudgovernanceTriggers(connectionId);
    }
}