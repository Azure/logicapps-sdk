//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Groupmgr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GroupmgrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended> GroupMgrGroupApproval(Expression<Func<string>> bodyListItemId, Expression<Func<bodyApprovedInput>> bodyApproved)
        {
            var apiCallPath = "/api/ConfimationTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ListItemId"] = ExpressionConverter.ConvertO(bodyListItemId);
            bodypropCount++;
            body["Approved"] = ExpressionConverter.ConvertO(bodyApproved);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupExtended>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended> GroupMgrCreateGroup(Expression<Func<string>> bodyDisplayName, Expression<Func<string>> bodyEmail, Expression<Func<string[]>> bodyOwners, Expression<Func<string[]>> bodyMembers = null, Expression<Func<string>> bodyGroupType = null, Expression<Func<bodyIsPublicInput>> bodyIsPublic = null, Expression<Func<bool>> bodyCreateTeam = null, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodyCreatedBy = null)
        {
            var apiCallPath = "/api/GroupBuilderTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["DisplayName"] = ExpressionConverter.ConvertO(bodyDisplayName);
            bodypropCount++;
            body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
            bodypropCount++;
            body["Owners"] = ExpressionConverter.ConvertO(bodyOwners);
            if (bodyMembers != null)
            {
                body["Members"] = ExpressionConverter.ConvertO(bodyMembers);
                bodypropCount++;
            }

            if (bodyGroupType != null)
            {
                body["GroupType"] = ExpressionConverter.ConvertO(bodyGroupType);
                bodypropCount++;
            }

            if (bodyIsPublic != null)
            {
                body["IsPublic"] = ExpressionConverter.ConvertO(bodyIsPublic);
                bodypropCount++;
            }

            if (bodyCreateTeam != null)
            {
                body["CreateTeam"] = ExpressionConverter.ConvertO(bodyCreateTeam);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyCreatedBy != null)
            {
                body["CreatedBy"] = ExpressionConverter.ConvertO(bodyCreatedBy);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupExtended>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended> GroupMgrUpdateGroup(Expression<Func<string>> bodyGroupId, Expression<Func<string>> bodyDisplayName = null, Expression<Func<string[]>> bodyOwners = null, Expression<Func<string[]>> bodyMembers = null, Expression<Func<string>> bodyGroupType = null, Expression<Func<bodyIsPublicInput>> bodyIsPublic = null, Expression<Func<bool>> bodyCreateTeam = null, Expression<Func<string>> bodyDescription = null)
        {
            var apiCallPath = "/api/GroupBuilderTrigger";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["GroupId"] = ExpressionConverter.ConvertO(bodyGroupId);
            if (bodyDisplayName != null)
            {
                body["DisplayName"] = ExpressionConverter.ConvertO(bodyDisplayName);
                bodypropCount++;
            }

            if (bodyOwners != null)
            {
                body["Owners"] = ExpressionConverter.ConvertO(bodyOwners);
                bodypropCount++;
            }

            if (bodyMembers != null)
            {
                body["Members"] = ExpressionConverter.ConvertO(bodyMembers);
                bodypropCount++;
            }

            if (bodyGroupType != null)
            {
                body["GroupType"] = ExpressionConverter.ConvertO(bodyGroupType);
                bodypropCount++;
            }

            if (bodyIsPublic != null)
            {
                body["IsPublic"] = ExpressionConverter.ConvertO(bodyIsPublic);
                bodypropCount++;
            }

            if (bodyCreateTeam != null)
            {
                body["CreateTeam"] = ExpressionConverter.ConvertO(bodyCreateTeam);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupExtended>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IWorkflowAction GroupMgrDeleteGroup(Expression<Func<string>> bodyListItemId)
        {
            var apiCallPath = "/api/GroupBuilderTrigger";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ListItemId"] = ExpressionConverter.ConvertO(bodyListItemId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IWorkflowAction GroupMgrArchiveGroup(Expression<Func<string>> bodyListItemId, Expression<Func<bodyArchiveInput>> bodyArchive)
        {
            var apiCallPath = "/api/GroupBuilderTrigger";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ListItemId"] = ExpressionConverter.ConvertO(bodyListItemId);
            bodypropCount++;
            body["Archive"] = ExpressionConverter.ConvertO(bodyArchive);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class GroupmgrTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger GroupMgrGroupRequested(Expression<Func<string>> bodyname, string triggerName = null)
        {
            var apiCallPath = "/api/webhookrequest/GroupRequested";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            body["webhook"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger GroupMgrGroupCreated(string triggerName = null)
        {
            var apiCallPath = "/api/webhookrequest/GroupCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhook"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger GroupMgrGroupUpdated(string triggerName = null)
        {
            var apiCallPath = "/api/webhookrequest/GroupUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhook"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger GroupMgrGroupDeleted(string triggerName = null)
        {
            var apiCallPath = "/api/webhookrequest/GroupDeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhook"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }

    public class GroupExtended
    {
        public string GroupId { get; set; }
        public string ListItemId { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string[] Owners { get; set; }
        public string[] Members { get; set; }
        public string GroupType { get; set; }
        public bool IsPublic { get; set; }
        public string Status { get; set; }
        public string Url { get; set; }
        public string TeamsUrl { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
        public bool CreateTeam { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
    }

    public enum bodyApprovedInput
    {
        [EnumMember(Value = "true")]
        Approve,
        [EnumMember(Value = "false")]
        Reject
    }

    public enum bodyIsPublicInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        Public,
        [EnumMember(Value = "false")]
        Private
    }

    public enum bodyArchiveInput
    {
        [EnumMember(Value = "true")]
        Archive,
        [EnumMember(Value = "false")]
        Unarchive
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Groupmgr;

    public partial class WorkflowManagedActions
    {
        public GroupmgrActions Groupmgr(string connectionId) => new GroupmgrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GroupmgrTriggers Groupmgr(string connectionId) => new GroupmgrTriggers(connectionId);
    }
}