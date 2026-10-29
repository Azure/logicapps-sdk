//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workmobile
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkmobileActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workmobile")]
        public IBodyWorkflowAction<UsergroupsResponseItem[], ApiConnectionActionConfiguration> Usergroups()
        {
            var apiCallPath = "/api/usergroups";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UsergroupsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workmobile")]
        public IBodyWorkflowAction<RetrieveMobileUsersResponseItem[], ApiConnectionActionConfiguration> RetrieveMobileUsers()
        {
            var apiCallPath = "/api/mobileusers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RetrieveMobileUsersResponseItem[]>(callPayload);
        }
    }

    public class WorkmobileTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> FormDataHook(Expression<Func<int>> bodyuserFormId, Expression<Func<bool>> bodyincludeSubFormData, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyuserFormId = WorkflowExpression.Compile(bodyuserFormId, nameof(bodyuserFormId), required: true);
            var __workflow_bodyincludeSubFormData = WorkflowExpression.Compile(bodyincludeSubFormData, nameof(bodyincludeSubFormData), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/notifications/external";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userFormId"] = ExpressionConverter.ConvertO(__workflow_bodyuserFormId);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["includeSubFormData"] = ExpressionConverter.ConvertO(__workflow_bodyincludeSubFormData);
                body["description"] = "Power Automate";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class UsergroupsResponseItem
    {
        public int UserGroupId { get; set; }
        public string Created { get; set; }
        public string CreatedBy { get; set; }
        public string Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string Name { get; set; }
        public bool DefaultGroup { get; set; }
        public string MenuId { get; set; }
    }

    public class RetrieveMobileUsersResponseItem
    {
        public int MobileUserId { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string JobTitle { get; set; }
        public int UserGroupId { get; set; }
        public string Created { get; set; }
        public string CreatedBy { get; set; }
        public string Modified { get; set; }
        public string ModifiedBy { get; set; }
        public string Username { get; set; }
        public bool UserActive { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Workmobile;

    public partial class WorkflowManagedActions
    {
        public WorkmobileActions Workmobile(string connectionId) => new WorkmobileActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorkmobileTriggers Workmobile(string connectionId) => new WorkmobileTriggers(connectionId);
    }
}
