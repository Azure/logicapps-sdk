//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamsspirit
{
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
        [WorkflowExpressionFactory(nameof(__BuildApprove))]
        public IWorkflowAction Approve([WorkflowExpression] Func<string> approvalID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildApprove(WorkflowValue<string> approvalID)
        {
            WorkflowValue.Validate(approvalID, nameof(approvalID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/approvals/{0}/approve", ExpressionConverter.ConvertWithUrlEncoding(approvalID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        [WorkflowExpressionFactory(nameof(__BuildReject))]
        public IWorkflowAction Reject([WorkflowExpression] Func<string> approvalID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReject(WorkflowValue<string> approvalID)
        {
            WorkflowValue.Validate(approvalID, nameof(approvalID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/approvals/{0}", ExpressionConverter.ConvertWithUrlEncoding(approvalID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        [WorkflowExpressionFactory(nameof(__BuildArchiveTeam))]
        public IWorkflowAction ArchiveTeam([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<bool> bodysharePointReadOnly)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildArchiveTeam(WorkflowValue<string> groupID, WorkflowValue<bool> bodysharePointReadOnly)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
            WorkflowValue.Validate(bodysharePointReadOnly, nameof(bodysharePointReadOnly), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/archive", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteTeam))]
        public IWorkflowAction DeleteTeam([WorkflowExpression] Func<string> groupID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteTeam(WorkflowValue<string> groupID)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        [WorkflowExpressionFactory(nameof(__BuildChangeTagValue))]
        public IWorkflowAction ChangeTagValue([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> contentid = null, [WorkflowExpression] Func<string> contentvalue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildChangeTagValue(WorkflowValue<string> groupID, WorkflowValue<string> contentid = null, WorkflowValue<string> contentvalue = null)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
            WorkflowValue.Validate(contentid, nameof(contentid), required: false);
            WorkflowValue.Validate(contentvalue, nameof(contentvalue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/change-tag-value", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveAllUsersExeptOwners))]
        public IWorkflowAction RemoveAllUsersExeptOwners([WorkflowExpression] Func<string> groupID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveAllUsersExeptOwners(WorkflowValue<string> groupID)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/remove-all-users-not-owner", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveAllUsersExceptOneOwner))]
        public IWorkflowAction RemoveAllUsersExceptOneOwner([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> bodyownerId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveAllUsersExceptOneOwner(WorkflowValue<string> groupID, WorkflowValue<string> bodyownerId = null)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
            WorkflowValue.Validate(bodyownerId, nameof(bodyownerId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/remove-all-users-except-selected-owner", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveGuests))]
        public IWorkflowAction RemoveGuests([WorkflowExpression] Func<string> groupID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveGuests(WorkflowValue<string> groupID)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/remove-all-guests", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveUser))]
        public IWorkflowAction RemoveUser([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveUser(WorkflowValue<string> groupID, WorkflowValue<string> bodyuserId = null)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/remove-user", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        [WorkflowExpressionFactory(nameof(__BuildChangeRoleToMember))]
        public IWorkflowAction ChangeRoleToMember([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildChangeRoleToMember(WorkflowValue<string> groupID, WorkflowValue<string> bodyuserId = null)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/change-role-to-member", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        [WorkflowExpressionFactory(nameof(__BuildChangeRoleToOwner))]
        public IWorkflowAction ChangeRoleToOwner([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildChangeRoleToOwner(WorkflowValue<string> groupID, WorkflowValue<string> bodyuserId = null)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/change-role-to-owner", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        [WorkflowExpressionFactory(nameof(__BuildExtendExpirationDate))]
        public IWorkflowAction ExtendExpirationDate([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> bodyweeks = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildExtendExpirationDate(WorkflowValue<string> groupID, WorkflowValue<string> bodyweeks = null)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
            WorkflowValue.Validate(bodyweeks, nameof(bodyweeks), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/extend-expiration", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyweeks != null)
                {
                    if (bodyweeks != null)
                    {
                        body["weeks"] = ExpressionConverter.ConvertO(bodyweeks);
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
        [WorkflowExpressionFactory(nameof(__BuildGetTagValue))]
        public IBodyWorkflowAction<string> GetTagValue([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> tagID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetTagValue(WorkflowValue<string> groupID, WorkflowValue<string> tagID)
        {
            WorkflowValue.Validate(groupID, nameof(groupID), required: true);
            WorkflowValue.Validate(tagID, nameof(tagID), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/groups/{0}/attribute/{1}", ExpressionConverter.ConvertWithUrlEncoding(groupID, 1), ExpressionConverter.ConvertWithUrlEncoding(tagID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class TeamsspiritTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildActionTrigger))]
        public IBodyWorkflowTrigger<ActionTriggerResponse> ActionTrigger([WorkflowExpression] Func<string> bodyname, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ActionTriggerResponse> __BuildActionTrigger(WorkflowValue<string> bodyname, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
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
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<ActionTriggerResponse>(callPayload, triggerName, recurrence);
            }, triggerName);
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
