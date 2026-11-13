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
            return new DeferredBodyAction<UsergroupsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/usergroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UsergroupsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "workmobile")]
        public IBodyWorkflowAction<RetrieveMobileUsersResponseItem[], ApiConnectionActionConfiguration> RetrieveMobileUsers()
        {
            return new DeferredBodyAction<RetrieveMobileUsersResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/mobileusers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RetrieveMobileUsersResponseItem[]>(callPayload);
            });
        }
    }

    public class WorkmobileTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> FormDataHook(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/notifications/external";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
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

        [JsonProperty("Username")]
        public string UserName { get; set; }
        public bool UserActive { get; set; }
    }

    public class BodyInput
    {
        public BodyInput(int userFormId, bool includeSubFormData)
        {
            this.UserFormId = userFormId;
            this.IncludeSubFormData = includeSubFormData;
        }

        [JsonProperty("userFormId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int UserFormId { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("includeSubFormData", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IncludeSubFormData { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Description { get; set; } = "Power Automate";
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