//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Avepointcloudgovernance
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AvepointcloudgovernanceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<JToken> FlowGetOffice365Setting([WorkflowExpression] Func<string> actionType, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = "/flow/office365/settings";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["actionType"] = ExpressionConverter.Convert(actionType);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IWorkflowAction FlowUpdateOffice365Setting([WorkflowExpression] Func<string> actionType, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = "/flow/office365/settings";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["actionType"] = ExpressionConverter.Convert(actionType);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<JToken> FlowGetRequestById([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> serviceType, [WorkflowExpression] Func<string> serviceId, [WorkflowExpression] Func<string> requestId)
        {
            var apiCallPath = String.Format("/flow/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["serviceType"] = ExpressionConverter.Convert(serviceType);
            callPayload.Queries["serviceId"] = ExpressionConverter.Convert(serviceId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<string> FlowSubmitRequest([WorkflowExpression] Func<string> serviceType, [WorkflowExpression] Func<string> serviceId, [WorkflowExpression] Func<string> delegateUserPrincipalName = null, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = "/flow/requests";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["serviceType"] = ExpressionConverter.Convert(serviceType);
            callPayload.Queries["serviceId"] = ExpressionConverter.Convert(serviceId);
            if (delegateUserPrincipalName != null)
                callPayload.Queries["DelegateUserPrincipalName"] = ExpressionConverter.Convert(delegateUserPrincipalName);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IWorkflowAction FlowEditRequest([WorkflowExpression] Func<string> serviceType, [WorkflowExpression] Func<string> serviceId, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = "/flow/requests";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["serviceType"] = ExpressionConverter.Convert(serviceType);
            callPayload.Queries["serviceId"] = ExpressionConverter.Convert(serviceId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<JToken> FlowListWorkspace([WorkflowExpression] Func<string> workspaceType = null, [WorkflowExpression] Func<string> primaryContact = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> urlorIdorEmail = null, [WorkflowExpression] Func<string> secondaryContact = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> nextLink = null)
        {
            var apiCallPath = "/flow/workspace";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceType"] = Convert.ToString("All");
            if (workspaceType != null)
                callPayload.Queries["workspaceType"] = ExpressionConverter.Convert(workspaceType);
            callPayload.Queries["primaryContact"] = Convert.ToString("");
            if (primaryContact != null)
                callPayload.Queries["primaryContact"] = ExpressionConverter.Convert(primaryContact);
            callPayload.Queries["status"] = Convert.ToString("All");
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            callPayload.Queries["urlorIdorEmail"] = Convert.ToString("");
            if (urlorIdorEmail != null)
                callPayload.Queries["urlorIdorEmail"] = ExpressionConverter.Convert(urlorIdorEmail);
            callPayload.Queries["secondaryContact"] = Convert.ToString("");
            if (secondaryContact != null)
                callPayload.Queries["secondaryContact"] = ExpressionConverter.Convert(secondaryContact);
            callPayload.Queries["top"] = Convert.ToString(2000);
            if (top != null)
                callPayload.Queries["top"] = ExpressionConverter.Convert(top);
            callPayload.Queries["nextLink"] = Convert.ToString("");
            if (nextLink != null)
                callPayload.Queries["nextLink"] = ExpressionConverter.Convert(nextLink);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<string> FlowWorkspaceActions([WorkflowExpression] Func<string> workspaceType, [WorkflowExpression] Func<string> workspaceAction, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = "/flow/workspace/actions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["workspaceType"] = ExpressionConverter.Convert(workspaceType);
            callPayload.Queries["workspaceAction"] = ExpressionConverter.Convert(workspaceAction);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class AvepointcloudgovernanceTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<string> FlowCreateHookForCommon([WorkflowExpression] Func<string> flowTriggerType, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/flow/hooks/common";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["flowTriggerType"] = ExpressionConverter.Convert(flowTriggerType);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForErrorTaskCreated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForErrorTaskRetried(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForRequestCancelled(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForRequestCompleted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForRequestSubmitted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForTaskApproved(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForFullyAutoImportCompleted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForConfirmDetailCompleted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForTaskCreated(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForTaskRejected(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForRenewalTaskCompleted(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForRenewalTaskException(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForRenewalTaskOverdue(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> FlowCreateHookForErrorTaskSkipped(string triggerName = null, FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger<string>(callPayload, triggerName, recurrence);
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