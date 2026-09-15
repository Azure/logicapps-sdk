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
        public IBodyWorkflowAction<GroupExtended> GroupMgrGroupApproval(Expression<Func<string>> bodylistItemId, Expression<Func<bodyapprovedInput>> bodyapproved)
        {
            var apiCallPath = "/api/ConfimationTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ListItemId"] = CSharpExpressionConverter.ConvertToken(bodylistItemId);
            bodypropCount++;
            body["Approved"] = CSharpExpressionConverter.Convert(bodyapproved);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupExtended>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended> GroupMgrCreateGroup(Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodyemail, Expression<Func<string[]>> bodyowners, Expression<Func<string[]>> bodymembers = null, Expression<Func<string>> bodygroupType = null, Expression<Func<bodyisPublicInput>> bodyisPublic = null, Expression<Func<bool>> bodycreateTeam = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodycreatedBy = null)
        {
            var apiCallPath = "/api/GroupBuilderTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["DisplayName"] = CSharpExpressionConverter.ConvertToken(bodydisplayName);
            bodypropCount++;
            body["Email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            bodypropCount++;
            body["Owners"] = CSharpExpressionConverter.ConvertToken(bodyowners);
            if (bodymembers != null)
            {
                body["Members"] = CSharpExpressionConverter.ConvertToken(bodymembers);
                bodypropCount++;
            }

            if (bodygroupType != null)
            {
                body["GroupType"] = CSharpExpressionConverter.ConvertToken(bodygroupType);
                bodypropCount++;
            }

            if (bodyisPublic != null)
            {
                if (bodyisPublic != null)
                {
                    body["IsPublic"] = CSharpExpressionConverter.Convert(bodyisPublic);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["IsPublic"] = "true";
                bodypropCount++;
            }

            if (bodycreateTeam != null)
            {
                if (bodycreateTeam != null)
                {
                    body["CreateTeam"] = CSharpExpressionConverter.ConvertToken(bodycreateTeam);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["CreateTeam"] = false;
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodycreatedBy != null)
            {
                body["CreatedBy"] = CSharpExpressionConverter.ConvertToken(bodycreatedBy);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupExtended>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended> GroupMgrUpdateGroup(Expression<Func<string>> bodygroupId, Expression<Func<string>> bodydisplayName = null, Expression<Func<string[]>> bodyowners = null, Expression<Func<string[]>> bodymembers = null, Expression<Func<string>> bodygroupType = null, Expression<Func<bodyisPublicInput>> bodyisPublic = null, Expression<Func<bool>> bodycreateTeam = null, Expression<Func<string>> bodydescription = null)
        {
            var apiCallPath = "/api/GroupBuilderTrigger";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["GroupId"] = CSharpExpressionConverter.ConvertToken(bodygroupId);
            if (bodydisplayName != null)
            {
                body["DisplayName"] = CSharpExpressionConverter.ConvertToken(bodydisplayName);
                bodypropCount++;
            }

            if (bodyowners != null)
            {
                body["Owners"] = CSharpExpressionConverter.ConvertToken(bodyowners);
                bodypropCount++;
            }

            if (bodymembers != null)
            {
                body["Members"] = CSharpExpressionConverter.ConvertToken(bodymembers);
                bodypropCount++;
            }

            if (bodygroupType != null)
            {
                body["GroupType"] = CSharpExpressionConverter.ConvertToken(bodygroupType);
                bodypropCount++;
            }

            if (bodyisPublic != null)
            {
                if (bodyisPublic != null)
                {
                    body["IsPublic"] = CSharpExpressionConverter.Convert(bodyisPublic);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["IsPublic"] = "";
                bodypropCount++;
            }

            if (bodycreateTeam != null)
            {
                if (bodycreateTeam != null)
                {
                    body["CreateTeam"] = CSharpExpressionConverter.ConvertToken(bodycreateTeam);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["CreateTeam"] = false;
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupExtended>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IWorkflowAction GroupMgrDeleteGroup(Expression<Func<string>> bodylistItemId)
        {
            var apiCallPath = "/api/GroupBuilderTrigger";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ListItemId"] = CSharpExpressionConverter.ConvertToken(bodylistItemId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IWorkflowAction GroupMgrArchiveGroup(Expression<Func<string>> bodylistItemId, Expression<Func<bodyarchiveInput>> bodyarchive)
        {
            var apiCallPath = "/api/GroupBuilderTrigger";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ListItemId"] = CSharpExpressionConverter.ConvertToken(bodylistItemId);
            bodypropCount++;
            body["Archive"] = CSharpExpressionConverter.Convert(bodyarchive);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class GroupmgrTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger GroupMgrGroupRequested(Expression<Func<string>> bodyname, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/webhookrequest/GroupRequested";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            body["webhook"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger GroupMgrGroupCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/webhookrequest/GroupCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhook"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger GroupMgrGroupUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/webhookrequest/GroupUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhook"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger GroupMgrGroupDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/webhookrequest/GroupDeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhook"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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

    public enum bodyapprovedInput
    {
        [EnumMember(Value = "true")]
        Approve,
        [EnumMember(Value = "false")]
        Reject
    }

    public enum bodyisPublicInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        Public,
        [EnumMember(Value = "false")]
        Private
    }

    public enum bodyarchiveInput
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