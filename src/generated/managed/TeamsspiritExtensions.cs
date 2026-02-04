//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamsspirit
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TeamsspiritActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IBodyWorkflowAction<GetApprovalsResponseItem[]> GetApprovals()
        {
            var apiCallPath = "/approvals";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetApprovalsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction Approve(Expression<Func<string>> approvalID)
        {
            var apiCallPath = String.Format("/approvals/{0}/approve", ExpressionConverter.ConvertWithUrlEncoding(approvalID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction Reject(Expression<Func<string>> approvalID)
        {
            var apiCallPath = String.Format("/approvals/{0}", ExpressionConverter.ConvertWithUrlEncoding(approvalID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ArchiveTeam(Expression<Func<string>> groupID, Expression<Func<bool>> bodysharePointReadOnly)
        {
            var apiCallPath = String.Format("/groups/{0}/archive", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["sharePointReadOnly"] = ExpressionConverter.ConvertO(bodysharePointReadOnly);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction DeleteTeam(Expression<Func<string>> groupID)
        {
            var apiCallPath = String.Format("/groups/{0}", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ChangeTagValue(Expression<Func<string>> groupID, Expression<Func<string>> contentid = null, Expression<Func<string>> contentvalue = null)
        {
            var apiCallPath = String.Format("/groups/{0}/change-tag-value", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var content = new JObject();
            var contentpropCount = 0;
            if (contentid != null)
            {
                content["id"] = ExpressionConverter.ConvertO(contentid);
                contentpropCount++;
            }

            if (contentvalue != null)
            {
                content["value"] = ExpressionConverter.ConvertO(contentvalue);
                contentpropCount++;
            }

            if (contentpropCount > 0)
            {
                callPayload.Body = content;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction RemoveAllUsersExeptOwners(Expression<Func<string>> groupID)
        {
            var apiCallPath = String.Format("/groups/{0}/remove-all-users-not-owner", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction RemoveAllUsersExceptOneOwner(Expression<Func<string>> groupID, Expression<Func<string>> bodyownerId = null)
        {
            var apiCallPath = String.Format("/groups/{0}/remove-all-users-except-selected-owner", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyownerId != null)
            {
                body["ownerId"] = ExpressionConverter.ConvertO(bodyownerId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction RemoveGuests(Expression<Func<string>> groupID)
        {
            var apiCallPath = String.Format("/groups/{0}/remove-all-guests", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction RemoveUser(Expression<Func<string>> groupID, Expression<Func<string>> bodyuserId = null)
        {
            var apiCallPath = String.Format("/groups/{0}/remove-user", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyuserId != null)
            {
                body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ChangeRoleToMember(Expression<Func<string>> groupID, Expression<Func<string>> bodyuserId = null)
        {
            var apiCallPath = String.Format("/groups/{0}/change-role-to-member", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyuserId != null)
            {
                body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ChangeRoleToOwner(Expression<Func<string>> groupID, Expression<Func<string>> bodyuserId = null)
        {
            var apiCallPath = String.Format("/groups/{0}/change-role-to-owner", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyuserId != null)
            {
                body["userId"] = ExpressionConverter.ConvertO(bodyuserId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ExtendExpirationDate(Expression<Func<string>> groupID, Expression<Func<string>> bodyweeks = null)
        {
            var apiCallPath = String.Format("/groups/{0}/extend-expiration", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyweeks != null)
            {
                body["weeks"] = ExpressionConverter.ConvertO(bodyweeks);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IBodyWorkflowAction<string> GetTagValue(Expression<Func<string>> groupID, Expression<Func<string>> tagID)
        {
            var apiCallPath = String.Format("/groups/{0}/attribute/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1), ExpressionConverter.ConvertWithUrlEncoding(tagID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class TeamsspiritTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ActionTriggerResponse> ActionTrigger(Expression<Func<string>> bodyname, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<ActionTriggerResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class GetApprovalsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("createForExternalUser")]
        public bool CreateForExternalUser { get; set; }

        [JsonProperty("externalUserId")]
        public string ExternalUserId { get; set; }

        [JsonProperty("reactingUserId")]
        public string ReactingUserId { get; set; }

        [JsonProperty("reactingUserName")]
        public string ReactingUserName { get; set; }

        [JsonProperty("requestTime")]
        public string RequestTime { get; set; }

        [JsonProperty("expirationDateTime")]
        public string ExpirationDateTime { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("groupDescription")]
        public string GroupDescription { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("rejectReason")]
        public string RejectReason { get; set; }

        [JsonProperty("access")]
        public bool Access { get; set; }

        [JsonProperty("reactionTime")]
        public string ReactionTime { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("attributeSettings")]
        public GetApprovalsResponseItemAttributeSettingsTypeItem[] AttributeSettings { get; set; }
    }

    public class GetApprovalsResponseItemAttributeSettingsTypeItem
    {
        [JsonProperty("attributeId")]
        public string AttributeId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }
    }

    public class ActionTriggerResponse
    {
        [JsonProperty("unsubscribeUrl")]
        public string UnsubscribeUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Teamsspirit;

    public partial class WorkflowManagedActions
    {
        public TeamsspiritActions Teamsspirit(string connectionId) => new TeamsspiritActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TeamsspiritTriggers Teamsspirit(string connectionId) => new TeamsspiritTriggers(connectionId);
    }
}