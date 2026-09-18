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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/approvals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetApprovalsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction Approve([WorkflowExpression] Func<string> approvalID)
        {
            SourceExpression.Validate(approvalID, nameof(approvalID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/approvals/{0}/approve", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(approvalID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction Reject([WorkflowExpression] Func<string> approvalID)
        {
            SourceExpression.Validate(approvalID, nameof(approvalID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/approvals/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(approvalID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ArchiveTeam([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<bool> bodysharePointReadOnly)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            SourceExpression.Validate(bodysharePointReadOnly, nameof(bodysharePointReadOnly), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/archive", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sharePointReadOnly"] = SourceExpressionConverter.ConvertToken(bodysharePointReadOnly);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction DeleteTeam([WorkflowExpression] Func<string> groupID)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ChangeTagValue([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> contentid = null, [WorkflowExpression] Func<string> contentvalue = null)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            SourceExpression.Validate(contentid, nameof(contentid), required: false);
            SourceExpression.Validate(contentvalue, nameof(contentvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/change-tag-value", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var content = new JObject();
                var contentpropCount = 0;
                if (contentid != null)
                {
                    content["id"] = SourceExpressionConverter.ConvertToken(contentid);
                    contentpropCount++;
                }

                if (contentvalue != null)
                {
                    content["value"] = SourceExpressionConverter.ConvertToken(contentvalue);
                    contentpropCount++;
                }

                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction RemoveAllUsersExeptOwners([WorkflowExpression] Func<string> groupID)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/remove-all-users-not-owner", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction RemoveAllUsersExceptOneOwner([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> bodyownerId = null)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            SourceExpression.Validate(bodyownerId, nameof(bodyownerId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/remove-all-users-except-selected-owner", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyownerId != null)
                {
                    body["ownerId"] = SourceExpressionConverter.ConvertToken(bodyownerId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction RemoveGuests([WorkflowExpression] Func<string> groupID)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/remove-all-guests", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction RemoveUser([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/remove-user", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ChangeRoleToMember([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/change-role-to-member", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ChangeRoleToOwner([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> bodyuserId = null)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            SourceExpression.Validate(bodyuserId, nameof(bodyuserId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/change-role-to-owner", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserId != null)
                {
                    body["userId"] = SourceExpressionConverter.ConvertToken(bodyuserId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IWorkflowAction ExtendExpirationDate([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> bodyweeks = null)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            SourceExpression.Validate(bodyweeks, nameof(bodyweeks), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/extend-expiration", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyweeks != null)
                {
                    if (bodyweeks != null)
                    {
                        body["weeks"] = SourceExpressionConverter.ConvertToken(bodyweeks);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamsspirit")]
        public IBodyWorkflowAction<string> GetTagValue([WorkflowExpression] Func<string> groupID, [WorkflowExpression] Func<string> tagID)
        {
            SourceExpression.Validate(groupID, nameof(groupID), required: true);
            SourceExpression.Validate(tagID, nameof(tagID), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/groups/{0}/attribute/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupID, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class TeamsspiritTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ActionTriggerResponse> ActionTrigger([WorkflowExpression] Func<string> bodyname, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "@listCallbackUrl()";
                bodypropCount++;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<ActionTriggerResponse>(BuildSourceInput, triggerName, recurrence);
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