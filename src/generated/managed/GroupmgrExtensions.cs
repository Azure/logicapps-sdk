//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Groupmgr
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class GroupmgrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended> GroupMgrGroupApproval(Expression<Func<string>> bodylistItemId, Expression<Func<bodyapprovedInput>> bodyapproved)
        {
            var __workflow_bodylistItemId = bodylistItemId == null ? null : WorkflowExpression.Compile(bodylistItemId);
            WorkflowExpression.Validate(__workflow_bodylistItemId, nameof(bodylistItemId), required: true);
            var __workflow_bodyapproved = bodyapproved == null ? null : WorkflowExpression.Compile(bodyapproved);
            WorkflowExpression.Validate(__workflow_bodyapproved, nameof(bodyapproved), required: true);
            return new DeferredBodyAction<GroupExtended>(() =>
            {
                var apiCallPath = "/api/ConfimationTrigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ListItemId"] = ExpressionConverter.ConvertO(__workflow_bodylistItemId);
                bodypropCount++;
                body["Approved"] = ExpressionConverter.ConvertO(__workflow_bodyapproved);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GroupExtended>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended> GroupMgrCreateGroup(Expression<Func<string>> bodydisplayName, Expression<Func<string>> bodyemail, Expression<Func<string[]>> bodyowners, Expression<Func<string[]>> bodymembers = null, Expression<Func<string>> bodygroupType = null, Expression<Func<bodyisPublicInput>> bodyisPublic = null, Expression<Func<bool>> bodycreateTeam = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodycreatedBy = null)
        {
            var __workflow_bodydisplayName = bodydisplayName == null ? null : WorkflowExpression.Compile(bodydisplayName);
            WorkflowExpression.Validate(__workflow_bodydisplayName, nameof(bodydisplayName), required: true);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyowners = bodyowners == null ? null : WorkflowExpression.Compile(bodyowners);
            WorkflowExpression.Validate(__workflow_bodyowners, nameof(bodyowners), required: true);
            var __workflow_bodymembers = bodymembers == null ? null : WorkflowExpression.Compile(bodymembers);
            WorkflowExpression.Validate(__workflow_bodymembers, nameof(bodymembers), required: false);
            var __workflow_bodygroupType = bodygroupType == null ? null : WorkflowExpression.Compile(bodygroupType);
            WorkflowExpression.Validate(__workflow_bodygroupType, nameof(bodygroupType), required: false);
            var __workflow_bodyisPublic = bodyisPublic == null ? null : WorkflowExpression.Compile(bodyisPublic);
            WorkflowExpression.Validate(__workflow_bodyisPublic, nameof(bodyisPublic), required: false);
            var __workflow_bodycreateTeam = bodycreateTeam == null ? null : WorkflowExpression.Compile(bodycreateTeam);
            WorkflowExpression.Validate(__workflow_bodycreateTeam, nameof(bodycreateTeam), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodycreatedBy = bodycreatedBy == null ? null : WorkflowExpression.Compile(bodycreatedBy);
            WorkflowExpression.Validate(__workflow_bodycreatedBy, nameof(bodycreatedBy), required: false);
            return new DeferredBodyAction<GroupExtended>(() =>
            {
                var apiCallPath = "/api/GroupBuilderTrigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["DisplayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                bodypropCount++;
                body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                bodypropCount++;
                body["Owners"] = ExpressionConverter.ConvertO(__workflow_bodyowners);
                if (__workflow_bodymembers != null)
                {
                    body["Members"] = ExpressionConverter.ConvertO(__workflow_bodymembers);
                    bodypropCount++;
                }

                if (__workflow_bodygroupType != null)
                {
                    body["GroupType"] = ExpressionConverter.ConvertO(__workflow_bodygroupType);
                    bodypropCount++;
                }

                if (__workflow_bodyisPublic != null)
                {
                    if (__workflow_bodyisPublic != null)
                    {
                        body["IsPublic"] = ExpressionConverter.ConvertO(__workflow_bodyisPublic);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["IsPublic"] = "true";
                    bodypropCount++;
                }

                if (__workflow_bodycreateTeam != null)
                {
                    if (__workflow_bodycreateTeam != null)
                    {
                        body["CreateTeam"] = ExpressionConverter.ConvertO(__workflow_bodycreateTeam);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["CreateTeam"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodycreatedBy != null)
                {
                    body["CreatedBy"] = ExpressionConverter.ConvertO(__workflow_bodycreatedBy);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GroupExtended>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended> GroupMgrUpdateGroup(Expression<Func<string>> bodygroupId, Expression<Func<string>> bodydisplayName = null, Expression<Func<string[]>> bodyowners = null, Expression<Func<string[]>> bodymembers = null, Expression<Func<string>> bodygroupType = null, Expression<Func<bodyisPublicInput>> bodyisPublic = null, Expression<Func<bool>> bodycreateTeam = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_bodygroupId = bodygroupId == null ? null : WorkflowExpression.Compile(bodygroupId);
            WorkflowExpression.Validate(__workflow_bodygroupId, nameof(bodygroupId), required: true);
            var __workflow_bodydisplayName = bodydisplayName == null ? null : WorkflowExpression.Compile(bodydisplayName);
            WorkflowExpression.Validate(__workflow_bodydisplayName, nameof(bodydisplayName), required: false);
            var __workflow_bodyowners = bodyowners == null ? null : WorkflowExpression.Compile(bodyowners);
            WorkflowExpression.Validate(__workflow_bodyowners, nameof(bodyowners), required: false);
            var __workflow_bodymembers = bodymembers == null ? null : WorkflowExpression.Compile(bodymembers);
            WorkflowExpression.Validate(__workflow_bodymembers, nameof(bodymembers), required: false);
            var __workflow_bodygroupType = bodygroupType == null ? null : WorkflowExpression.Compile(bodygroupType);
            WorkflowExpression.Validate(__workflow_bodygroupType, nameof(bodygroupType), required: false);
            var __workflow_bodyisPublic = bodyisPublic == null ? null : WorkflowExpression.Compile(bodyisPublic);
            WorkflowExpression.Validate(__workflow_bodyisPublic, nameof(bodyisPublic), required: false);
            var __workflow_bodycreateTeam = bodycreateTeam == null ? null : WorkflowExpression.Compile(bodycreateTeam);
            WorkflowExpression.Validate(__workflow_bodycreateTeam, nameof(bodycreateTeam), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            return new DeferredBodyAction<GroupExtended>(() =>
            {
                var apiCallPath = "/api/GroupBuilderTrigger";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["GroupId"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                if (__workflow_bodydisplayName != null)
                {
                    body["DisplayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                    bodypropCount++;
                }

                if (__workflow_bodyowners != null)
                {
                    body["Owners"] = ExpressionConverter.ConvertO(__workflow_bodyowners);
                    bodypropCount++;
                }

                if (__workflow_bodymembers != null)
                {
                    body["Members"] = ExpressionConverter.ConvertO(__workflow_bodymembers);
                    bodypropCount++;
                }

                if (__workflow_bodygroupType != null)
                {
                    body["GroupType"] = ExpressionConverter.ConvertO(__workflow_bodygroupType);
                    bodypropCount++;
                }

                if (__workflow_bodyisPublic != null)
                {
                    if (__workflow_bodyisPublic != null)
                    {
                        body["IsPublic"] = ExpressionConverter.ConvertO(__workflow_bodyisPublic);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["IsPublic"] = "";
                    bodypropCount++;
                }

                if (__workflow_bodycreateTeam != null)
                {
                    if (__workflow_bodycreateTeam != null)
                    {
                        body["CreateTeam"] = ExpressionConverter.ConvertO(__workflow_bodycreateTeam);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["CreateTeam"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GroupExtended>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IWorkflowAction GroupMgrDeleteGroup(Expression<Func<string>> bodylistItemId)
        {
            var __workflow_bodylistItemId = bodylistItemId == null ? null : WorkflowExpression.Compile(bodylistItemId);
            WorkflowExpression.Validate(__workflow_bodylistItemId, nameof(bodylistItemId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/GroupBuilderTrigger";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ListItemId"] = ExpressionConverter.ConvertO(__workflow_bodylistItemId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IWorkflowAction GroupMgrArchiveGroup(Expression<Func<string>> bodylistItemId, Expression<Func<bodyarchiveInput>> bodyarchive)
        {
            var __workflow_bodylistItemId = bodylistItemId == null ? null : WorkflowExpression.Compile(bodylistItemId);
            WorkflowExpression.Validate(__workflow_bodylistItemId, nameof(bodylistItemId), required: true);
            var __workflow_bodyarchive = bodyarchive == null ? null : WorkflowExpression.Compile(bodyarchive);
            WorkflowExpression.Validate(__workflow_bodyarchive, nameof(bodyarchive), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/api/GroupBuilderTrigger";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ListItemId"] = ExpressionConverter.ConvertO(__workflow_bodylistItemId);
                bodypropCount++;
                body["Archive"] = ExpressionConverter.ConvertO(__workflow_bodyarchive);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class GroupmgrTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger GroupMgrGroupRequested(Expression<Func<string>> bodyname, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/webhookrequest/GroupRequested";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                body["webhook"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger GroupMgrGroupCreated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/webhookrequest/GroupCreated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhook"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger GroupMgrGroupUpdated(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/webhookrequest/GroupUpdated";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhook"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger GroupMgrGroupDeleted(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/webhookrequest/GroupDeleted";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhook"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyapprovedInput
    {
        [EnumMember(Value = "true")]
        Approve,
        [EnumMember(Value = "false")]
        Reject
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyisPublicInput
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        Public,
        [EnumMember(Value = "false")]
        Private
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
