//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Groupmgr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GroupmgrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended, ApiConnectionActionConfiguration> GroupMgrGroupApproval(Expression<Func<GroupMgrGroupApprovalInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GroupExtended, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/ConfimationTrigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GroupExtended>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended, ApiConnectionActionConfiguration> GroupMgrCreateGroup(Expression<Func<GroupMgrCreateGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GroupExtended, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/GroupBuilderTrigger";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GroupExtended>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IBodyWorkflowAction<GroupExtended, ApiConnectionActionConfiguration> GroupMgrUpdateGroup(Expression<Func<GroupMgrUpdateGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GroupExtended, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/GroupBuilderTrigger";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GroupExtended>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GroupMgrDeleteGroup(Expression<Func<GroupMgrDeleteGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/GroupBuilderTrigger";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groupmgr")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GroupMgrArchiveGroup(Expression<Func<GroupMgrArchiveGroupInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/GroupBuilderTrigger";
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class GroupmgrTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> GroupMgrGroupRequested(Expression<Func<GroupMgrGroupRequestedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/webhookrequest/GroupRequested";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> GroupMgrGroupCreated(Expression<Func<GroupMgrGroupCreatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/webhookrequest/GroupCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> GroupMgrGroupUpdated(Expression<Func<GroupMgrGroupUpdatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/webhookrequest/GroupUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> GroupMgrGroupDeleted(Expression<Func<GroupMgrGroupDeletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/webhookrequest/GroupDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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

    public class GroupMgrGroupApprovalInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListItemId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GroupMgrGroupApprovalInputApprovedType Approved { get; set; } = GroupMgrGroupApprovalInputApprovedType.Approve;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GroupMgrGroupApprovalInputApprovedType
    {
        [EnumMember(Value = "true")]
        Approve,
        [EnumMember(Value = "false")]
        Reject
    }

    public class GroupMgrCreateGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DisplayName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Owners { get; set; }
        public string[] Members { get; set; }
        public string GroupType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GroupMgrCreateGroupInputIsPublicType? IsPublic { get; set; } = GroupMgrCreateGroupInputIsPublicType.Public;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateTeam { get; set; } = false;
        public string Description { get; set; }
        public string CreatedBy { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GroupMgrCreateGroupInputIsPublicType
    {
        [EnumMember(Value = "true")]
        Public,
        [EnumMember(Value = "false")]
        Private
    }

    public class GroupMgrUpdateGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupId { get; set; }
        public string DisplayName { get; set; }
        public string[] Owners { get; set; }
        public string[] Members { get; set; }
        public string GroupType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GroupMgrUpdateGroupInputIsPublicType? IsPublic { get; set; } = GroupMgrUpdateGroupInputIsPublicType.None;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateTeam { get; set; } = false;
        public string Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GroupMgrUpdateGroupInputIsPublicType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        Public,
        [EnumMember(Value = "false")]
        Private
    }

    public class GroupMgrDeleteGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListItemId { get; set; }
    }

    public class GroupMgrArchiveGroupInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListItemId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GroupMgrArchiveGroupInputArchiveType Archive { get; set; } = GroupMgrArchiveGroupInputArchiveType.Archive;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GroupMgrArchiveGroupInputArchiveType
    {
        [EnumMember(Value = "true")]
        Archive,
        [EnumMember(Value = "false")]
        Unarchive
    }

    public class GroupMgrGroupRequestedInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhook { get; set; } = "#{listCallbackUrl()}";
    }

    public class GroupMgrGroupCreatedInput
    {
        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhook { get; set; } = "#{listCallbackUrl()}";
    }

    public class GroupMgrGroupUpdatedInput
    {
        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhook { get; set; } = "#{listCallbackUrl()}";
    }

    public class GroupMgrGroupDeletedInput
    {
        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhook { get; set; } = "#{listCallbackUrl()}";
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