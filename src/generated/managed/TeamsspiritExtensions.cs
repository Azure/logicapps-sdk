//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamsspirit
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
            var __workflow_approvalID = approvalID == null ? null : WorkflowExpression.Compile(approvalID);
            WorkflowExpression.Validate(__workflow_approvalID, nameof(approvalID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/approvals/{0}/approve", ExpressionConverter.ConvertWithUrlEncoding(__workflow_approvalID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction Reject(Expression<Func<string>> approvalID)
        {
            var __workflow_approvalID = approvalID == null ? null : WorkflowExpression.Compile(approvalID);
            WorkflowExpression.Validate(__workflow_approvalID, nameof(approvalID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/approvals/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_approvalID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ArchiveTeam(Expression<Func<string>> groupID, Expression<Func<bool>> bodysharePointReadOnly)
        {
            var __workflow_groupID = groupID == null ? null : WorkflowExpression.Compile(groupID);
            WorkflowExpression.Validate(__workflow_groupID, nameof(groupID), required: true);
            var __workflow_bodysharePointReadOnly = bodysharePointReadOnly == null ? null : WorkflowExpression.Compile(bodysharePointReadOnly);
            WorkflowExpression.Validate(__workflow_bodysharePointReadOnly, nameof(bodysharePointReadOnly), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/archive", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sharePointReadOnly"] = ExpressionConverter.ConvertO(__workflow_bodysharePointReadOnly);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction DeleteTeam(Expression<Func<string>> groupID)
        {
            var __workflow_groupID = groupID == null ? null : WorkflowExpression.Compile(groupID);
            WorkflowExpression.Validate(__workflow_groupID, nameof(groupID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ChangeTagValue(Expression<Func<string>> groupID, Expression<Func<string>> contentid = null, Expression<Func<string>> contentvalue = null)
        {
            var __workflow_groupID = groupID == null ? null : WorkflowExpression.Compile(groupID);
            WorkflowExpression.Validate(__workflow_groupID, nameof(groupID), required: true);
            var __workflow_contentid = contentid == null ? null : WorkflowExpression.Compile(contentid);
            WorkflowExpression.Validate(__workflow_contentid, nameof(contentid), required: false);
            var __workflow_contentvalue = contentvalue == null ? null : WorkflowExpression.Compile(contentvalue);
            WorkflowExpression.Validate(__workflow_contentvalue, nameof(contentvalue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/change-tag-value", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupID, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                if (__workflow_contentid != null)
                {
                    content["id"] = ExpressionConverter.ConvertO(__workflow_contentid);
                    contentpropCount++;
                }

                if (__workflow_contentvalue != null)
                {
                    content["value"] = ExpressionConverter.ConvertO(__workflow_contentvalue);
                    contentpropCount++;
                }

                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction RemoveAllUsersExeptOwners(Expression<Func<string>> groupID)
        {
            var __workflow_groupID = groupID == null ? null : WorkflowExpression.Compile(groupID);
            WorkflowExpression.Validate(__workflow_groupID, nameof(groupID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/remove-all-users-not-owner", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction RemoveAllUsersExceptOneOwner(Expression<Func<string>> groupID, Expression<Func<string>> bodyownerId = null)
        {
            var __workflow_groupID = groupID == null ? null : WorkflowExpression.Compile(groupID);
            WorkflowExpression.Validate(__workflow_groupID, nameof(groupID), required: true);
            var __workflow_bodyownerId = bodyownerId == null ? null : WorkflowExpression.Compile(bodyownerId);
            WorkflowExpression.Validate(__workflow_bodyownerId, nameof(bodyownerId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/remove-all-users-except-selected-owner", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyownerId != null)
                {
                    body["ownerId"] = ExpressionConverter.ConvertO(__workflow_bodyownerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction RemoveGuests(Expression<Func<string>> groupID)
        {
            var __workflow_groupID = groupID == null ? null : WorkflowExpression.Compile(groupID);
            WorkflowExpression.Validate(__workflow_groupID, nameof(groupID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/remove-all-guests", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction RemoveUser(Expression<Func<string>> groupID, Expression<Func<string>> bodyuserId = null)
        {
            var __workflow_groupID = groupID == null ? null : WorkflowExpression.Compile(groupID);
            WorkflowExpression.Validate(__workflow_groupID, nameof(groupID), required: true);
            var __workflow_bodyuserId = bodyuserId == null ? null : WorkflowExpression.Compile(bodyuserId);
            WorkflowExpression.Validate(__workflow_bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/remove-user", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ChangeRoleToMember(Expression<Func<string>> groupID, Expression<Func<string>> bodyuserId = null)
        {
            var __workflow_groupID = groupID == null ? null : WorkflowExpression.Compile(groupID);
            WorkflowExpression.Validate(__workflow_groupID, nameof(groupID), required: true);
            var __workflow_bodyuserId = bodyuserId == null ? null : WorkflowExpression.Compile(bodyuserId);
            WorkflowExpression.Validate(__workflow_bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/change-role-to-member", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ChangeRoleToOwner(Expression<Func<string>> groupID, Expression<Func<string>> bodyuserId = null)
        {
            var __workflow_groupID = groupID == null ? null : WorkflowExpression.Compile(groupID);
            WorkflowExpression.Validate(__workflow_groupID, nameof(groupID), required: true);
            var __workflow_bodyuserId = bodyuserId == null ? null : WorkflowExpression.Compile(bodyuserId);
            WorkflowExpression.Validate(__workflow_bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/change-role-to-owner", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserId != null)
                {
                    body["userId"] = ExpressionConverter.ConvertO(__workflow_bodyuserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ExtendExpirationDate(Expression<Func<string>> groupID, Expression<Func<string>> bodyweeks = null)
        {
            var __workflow_groupID = groupID == null ? null : WorkflowExpression.Compile(groupID);
            WorkflowExpression.Validate(__workflow_groupID, nameof(groupID), required: true);
            var __workflow_bodyweeks = bodyweeks == null ? null : WorkflowExpression.Compile(bodyweeks);
            WorkflowExpression.Validate(__workflow_bodyweeks, nameof(bodyweeks), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/extend-expiration", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyweeks != null)
                {
                    if (__workflow_bodyweeks != null)
                    {
                        body["weeks"] = ExpressionConverter.ConvertO(__workflow_bodyweeks);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["weeks"] = "4'";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IBodyWorkflowAction<string> GetTagValue(Expression<Func<string>> groupID, Expression<Func<string>> tagID)
        {
            var __workflow_groupID = groupID == null ? null : WorkflowExpression.Compile(groupID);
            WorkflowExpression.Validate(__workflow_groupID, nameof(groupID), required: true);
            var __workflow_tagID = tagID == null ? null : WorkflowExpression.Compile(tagID);
            WorkflowExpression.Validate(__workflow_tagID, nameof(tagID), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/attribute/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_groupID, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_tagID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class TeamsspiritTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ActionTriggerResponse> ActionTrigger(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            return new DeferredBodyTrigger<ActionTriggerResponse>(() =>
            {
                var apiCallPath = "/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<ActionTriggerResponse>(callPayload, recurrence: recurrence);
            });
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
