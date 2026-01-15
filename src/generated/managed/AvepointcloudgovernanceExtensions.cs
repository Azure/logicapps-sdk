//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Avepointcloudgovernance
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AvepointcloudgovernanceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<JToken> FlowGetOffice365Setting(Expression<Func<string>> actionType, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/flow/office365/settings";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["actionType"] = ExpressionConverter.Convert(actionType);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IWorkflowAction FlowUpdateOffice365Setting(Expression<Func<string>> actionType, Expression<Func<object>> body = null)
        {
            var apiCallPath = "/flow/office365/settings";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["actionType"] = ExpressionConverter.Convert(actionType);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<JToken> FlowGetRequestById(Expression<Func<string>> serviceType, Expression<Func<string>> serviceId, Expression<Func<string>> requestId)
        {
            var apiCallPath = String.Format("/flow/requests/{0}", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["serviceType"] = ExpressionConverter.Convert(serviceType);
            callPayload.Queries["serviceId"] = ExpressionConverter.Convert(serviceId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "avepointcloudgovernance")]
        public IBodyWorkflowAction<string> FlowSubmitRequest(Expression<Func<string>> serviceType, Expression<Func<string>> serviceId, Expression<Func<string>> delegateUserPrincipalName = null, Expression<Func<object>> body = null)
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
        public IWorkflowAction FlowEditRequest(Expression<Func<string>> serviceType, Expression<Func<string>> serviceId, Expression<Func<string>> id, Expression<Func<object>> body = null)
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
        public IBodyWorkflowAction<JToken> FlowListWorkspace(Expression<Func<string>> workspaceType = null, Expression<Func<string>> primaryContact = null, Expression<Func<string>> status = null, Expression<Func<string>> urlorIdorEmail = null, Expression<Func<string>> secondaryContact = null, Expression<Func<int>> top = null, Expression<Func<string>> nextLink = null)
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
        public IBodyWorkflowAction<string> FlowWorkspaceActions(Expression<Func<string>> workspaceType, Expression<Func<string>> workspaceAction, Expression<Func<object>> body = null)
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
        public IOutputWorkflowTrigger<string> FlowCreateHookForCommon(Expression<Func<string>> flowTriggerType)
        {
            var apiCallPath = "/flow/hooks/common";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["flowTriggerType"] = ExpressionConverter.Convert(flowTriggerType);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForErrorTaskCreated()
        {
            var apiCallPath = "/flow/hooks/errortask/created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForErrorTaskRetried()
        {
            var apiCallPath = "/flow/hooks/errortask/retried";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForRequestCancelled()
        {
            var apiCallPath = "/flow/hooks/request/cancelled";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForRequestCompleted()
        {
            var apiCallPath = "/flow/hooks/request/completed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForRequestSubmitted()
        {
            var apiCallPath = "/flow/hooks/request/submitted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForTaskApproved()
        {
            var apiCallPath = "/flow/hooks/task/approved";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForFullyAutoImportCompleted()
        {
            var apiCallPath = "/flow/hooks/task/autoimport";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForConfirmDetailCompleted()
        {
            var apiCallPath = "/flow/hooks/task/confirm";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForTaskCreated()
        {
            var apiCallPath = "/flow/hooks/task/created";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForTaskRejected()
        {
            var apiCallPath = "/flow/hooks/task/rejected";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForRenewalTaskCompleted()
        {
            var apiCallPath = "/flow/hooks/task/renewal/completed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForRenewalTaskException()
        {
            var apiCallPath = "/flow/hooks/task/renewal/exception";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForRenewalTaskOverdue()
        {
            var apiCallPath = "/flow/hooks/task/renewal/overdue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }

        public IOutputWorkflowTrigger<string> FlowCreateHookForErrorTaskSkipped()
        {
            var apiCallPath = "/flow/hooks/task/skipped";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<string>(callPayload);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Avepointcloudgovernance;

    public partial class WorkflowManagedActions
    {
        public AvepointcloudgovernanceActions Avepointcloudgovernance(string connectionId) => new AvepointcloudgovernanceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AvepointcloudgovernanceTriggers Avepointcloudgovernance(string connectionId) => new AvepointcloudgovernanceTriggers(connectionId);
    }
}