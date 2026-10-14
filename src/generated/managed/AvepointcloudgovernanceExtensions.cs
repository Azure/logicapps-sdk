//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Avepointcloudgovernance
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AvepointcloudgovernanceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<JToken> FlowGetOffice365Setting(Expression<Func<string>> actionType, Expression<Func<object>> body = null)
        {
            var __workflow_actionType = actionType == null ? null : WorkflowExpression.Compile(actionType);
            WorkflowExpression.Validate(__workflow_actionType, nameof(actionType), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
        public IWorkflowAction FlowUpdateOffice365Setting(Expression<Func<string>> actionType, Expression<Func<object>> body = null)
        {
            var __workflow_actionType = actionType == null ? null : WorkflowExpression.Compile(actionType);
            WorkflowExpression.Validate(__workflow_actionType, nameof(actionType), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<JToken> FlowGetRequestById(Expression<Func<string>> serviceType, Expression<Func<string>> serviceId, Expression<Func<string>> requestId)
        {
            var __workflow_serviceType = serviceType == null ? null : WorkflowExpression.Compile(serviceType);
            WorkflowExpression.Validate(__workflow_serviceType, nameof(serviceType), required: true);
            var __workflow_serviceId = serviceId == null ? null : WorkflowExpression.Compile(serviceId);
            WorkflowExpression.Validate(__workflow_serviceId, nameof(serviceId), required: true);
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/flow/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["serviceType"] = ExpressionConverter.Convert(__workflow_serviceType);
                callPayload.Queries["serviceId"] = ExpressionConverter.Convert(__workflow_serviceId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<string> FlowSubmitRequest(Expression<Func<string>> serviceType, Expression<Func<string>> serviceId, Expression<Func<string>> delegateUserPrincipalName = null, Expression<Func<object>> body = null)
        {
            var __workflow_serviceType = serviceType == null ? null : WorkflowExpression.Compile(serviceType);
            WorkflowExpression.Validate(__workflow_serviceType, nameof(serviceType), required: true);
            var __workflow_serviceId = serviceId == null ? null : WorkflowExpression.Compile(serviceId);
            WorkflowExpression.Validate(__workflow_serviceId, nameof(serviceId), required: true);
            var __workflow_delegateUserPrincipalName = delegateUserPrincipalName == null ? null : WorkflowExpression.Compile(delegateUserPrincipalName);
            WorkflowExpression.Validate(__workflow_delegateUserPrincipalName, nameof(delegateUserPrincipalName), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
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
        public IWorkflowAction FlowEditRequest(Expression<Func<string>> serviceType, Expression<Func<string>> serviceId, Expression<Func<string>> id, Expression<Func<object>> body = null)
        {
            var __workflow_serviceType = serviceType == null ? null : WorkflowExpression.Compile(serviceType);
            WorkflowExpression.Validate(__workflow_serviceType, nameof(serviceType), required: true);
            var __workflow_serviceId = serviceId == null ? null : WorkflowExpression.Compile(serviceId);
            WorkflowExpression.Validate(__workflow_serviceId, nameof(serviceId), required: true);
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowAction<JToken> FlowListWorkspace(Expression<Func<string>> workspaceType = null, Expression<Func<string>> primaryContact = null, Expression<Func<string>> status = null, Expression<Func<string>> urlorIdorEmail = null, Expression<Func<string>> secondaryContact = null, Expression<Func<int>> top = null, Expression<Func<string>> nextLink = null)
        {
            var __workflow_workspaceType = workspaceType == null ? null : WorkflowExpression.Compile(workspaceType);
            WorkflowExpression.Validate(__workflow_workspaceType, nameof(workspaceType), required: false);
            var __workflow_primaryContact = primaryContact == null ? null : WorkflowExpression.Compile(primaryContact);
            WorkflowExpression.Validate(__workflow_primaryContact, nameof(primaryContact), required: false);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_urlorIdorEmail = urlorIdorEmail == null ? null : WorkflowExpression.Compile(urlorIdorEmail);
            WorkflowExpression.Validate(__workflow_urlorIdorEmail, nameof(urlorIdorEmail), required: false);
            var __workflow_secondaryContact = secondaryContact == null ? null : WorkflowExpression.Compile(secondaryContact);
            WorkflowExpression.Validate(__workflow_secondaryContact, nameof(secondaryContact), required: false);
            var __workflow_top = top == null ? null : WorkflowExpression.Compile(top);
            WorkflowExpression.Validate(__workflow_top, nameof(top), required: false);
            var __workflow_nextLink = nextLink == null ? null : WorkflowExpression.Compile(nextLink);
            WorkflowExpression.Validate(__workflow_nextLink, nameof(nextLink), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
        public IBodyWorkflowAction<string> FlowWorkspaceActions(Expression<Func<string>> workspaceType, Expression<Func<string>> workspaceAction, Expression<Func<object>> body = null)
        {
            var __workflow_workspaceType = workspaceType == null ? null : WorkflowExpression.Compile(workspaceType);
            WorkflowExpression.Validate(__workflow_workspaceType, nameof(workspaceType), required: true);
            var __workflow_workspaceAction = workspaceAction == null ? null : WorkflowExpression.Compile(workspaceAction);
            WorkflowExpression.Validate(__workflow_workspaceAction, nameof(workspaceAction), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<string>(() =>
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
        public IBodyWorkflowTrigger<string> FlowCreateHookForCommon(Expression<Func<string>> flowTriggerType, FlowRecurrence recurrence = null)
        {
            var __workflow_flowTriggerType = flowTriggerType == null ? null : WorkflowExpression.Compile(flowTriggerType);
            WorkflowExpression.Validate(__workflow_flowTriggerType, nameof(flowTriggerType), required: true);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = "/flow/hooks/common";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["flowTriggerType"] = ExpressionConverter.Convert(__workflow_flowTriggerType);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForErrorTaskCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/errortask/created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForErrorTaskRetried(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/errortask/retried";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForRequestCancelled(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/request/cancelled";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForRequestCompleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/request/completed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForRequestSubmitted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/request/submitted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForTaskApproved(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/task/approved";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForFullyAutoImportCompleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/task/autoimport";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForConfirmDetailCompleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/task/confirm";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForTaskCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/task/created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForTaskRejected(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/task/rejected";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForRenewalTaskCompleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/task/renewal/completed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForRenewalTaskException(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/task/renewal/exception";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForRenewalTaskOverdue(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/task/renewal/overdue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForErrorTaskSkipped(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/task/skipped";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
        }
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
