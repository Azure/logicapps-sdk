//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Groupmgr
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GroupmgrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended> GroupMgrGroupApproval([WorkflowExpression] Func<string> bodylistItemId, [WorkflowExpression] Func<bodyapprovedInput> bodyapproved)
        {
            var apiCallPath = "/api/ConfimationTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ListItemId"] = ExpressionConverter.ConvertO(bodylistItemId);
            bodypropCount++;
            body["Approved"] = ExpressionConverter.ConvertO(bodyapproved);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupExtended>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended> GroupMgrCreateGroup([WorkflowExpression] Func<string> bodydisplayName, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string[]> bodyowners, [WorkflowExpression] Func<string[]> bodymembers = null, [WorkflowExpression] Func<string> bodygroupType = null, [WorkflowExpression] Func<bodyisPublicInput> bodyisPublic = null, [WorkflowExpression] Func<bool> bodycreateTeam = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodycreatedBy = null)
        {
            var apiCallPath = "/api/GroupBuilderTrigger";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["DisplayName"] = ExpressionConverter.ConvertO(bodydisplayName);
            bodypropCount++;
            body["Email"] = ExpressionConverter.ConvertO(bodyemail);
            bodypropCount++;
            body["Owners"] = ExpressionConverter.ConvertO(bodyowners);
            if (bodymembers != null)
            {
                body["Members"] = ExpressionConverter.ConvertO(bodymembers);
                bodypropCount++;
            }

            if (bodygroupType != null)
            {
                body["GroupType"] = ExpressionConverter.ConvertO(bodygroupType);
                bodypropCount++;
            }

            if (bodyisPublic != null)
            {
                if (bodyisPublic != null)
                {
                    body["IsPublic"] = ExpressionConverter.ConvertO(bodyisPublic);
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
                    body["CreateTeam"] = ExpressionConverter.ConvertO(bodycreateTeam);
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
                body["Description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodycreatedBy != null)
            {
                body["CreatedBy"] = ExpressionConverter.ConvertO(bodycreatedBy);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupExtended>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended> GroupMgrUpdateGroup([WorkflowExpression] Func<string> bodygroupId, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string[]> bodyowners = null, [WorkflowExpression] Func<string[]> bodymembers = null, [WorkflowExpression] Func<string> bodygroupType = null, [WorkflowExpression] Func<bodyisPublicInput> bodyisPublic = null, [WorkflowExpression] Func<bool> bodycreateTeam = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            var apiCallPath = "/api/GroupBuilderTrigger";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["GroupId"] = ExpressionConverter.ConvertO(bodygroupId);
            if (bodydisplayName != null)
            {
                body["DisplayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                bodypropCount++;
            }

            if (bodyowners != null)
            {
                body["Owners"] = ExpressionConverter.ConvertO(bodyowners);
                bodypropCount++;
            }

            if (bodymembers != null)
            {
                body["Members"] = ExpressionConverter.ConvertO(bodymembers);
                bodypropCount++;
            }

            if (bodygroupType != null)
            {
                body["GroupType"] = ExpressionConverter.ConvertO(bodygroupType);
                bodypropCount++;
            }

            if (bodyisPublic != null)
            {
                if (bodyisPublic != null)
                {
                    body["IsPublic"] = ExpressionConverter.ConvertO(bodyisPublic);
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
                    body["CreateTeam"] = ExpressionConverter.ConvertO(bodycreateTeam);
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
                body["Description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GroupExtended>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IWorkflowAction GroupMgrDeleteGroup([WorkflowExpression] Func<string> bodylistItemId)
        {
            var apiCallPath = "/api/GroupBuilderTrigger";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ListItemId"] = ExpressionConverter.ConvertO(bodylistItemId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IWorkflowAction GroupMgrArchiveGroup([WorkflowExpression] Func<string> bodylistItemId, [WorkflowExpression] Func<bodyarchiveInput> bodyarchive)
        {
            var apiCallPath = "/api/GroupBuilderTrigger";
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["ListItemId"] = ExpressionConverter.ConvertO(bodylistItemId);
            bodypropCount++;
            body["Archive"] = ExpressionConverter.ConvertO(bodyarchive);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class GroupmgrTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger GroupMgrGroupRequested([WorkflowExpression] Func<string> bodyname, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/webhookrequest/GroupRequested";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
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