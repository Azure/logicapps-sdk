//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workmobile
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkmobileActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workmobile")]
        public IBodyWorkflowAction<UsergroupsResponseItem[]> Usergroups()
        {
            var apiCallPath = "/api/usergroups";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UsergroupsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workmobile")]
        public IBodyWorkflowAction<RetrieveMobileUsersResponseItem[]> RetrieveMobileUsers()
        {
            var apiCallPath = "/api/mobileusers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RetrieveMobileUsersResponseItem[]>(callPayload);
        }
    }

    public class WorkmobileTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger FormDataHook(Expression<Func<int>> bodyuserFormId, Expression<Func<bool>> bodyincludeSubFormData)
        {
            var apiCallPath = "/api/notifications/external";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["userFormId"] = ExpressionConverter.ConvertO(bodyuserFormId);
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            bodypropCount++;
            body["includeSubFormData"] = ExpressionConverter.ConvertO(bodyincludeSubFormData);
            body["description"] = "Power Automate";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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