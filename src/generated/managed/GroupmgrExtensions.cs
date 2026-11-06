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
        public IBodyWorkflowAction<GroupExtended, ApiConnectionActionConfiguration> GroupMgrGroupApproval(Expression<Func<GroupMgrGroupApprovalBodyInput>> body)
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
        public IBodyWorkflowAction<GroupExtended, ApiConnectionActionConfiguration> GroupMgrCreateGroup(Expression<Func<GroupMgrCreateGroupBodyInput>> body)
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
        public IBodyWorkflowAction<GroupExtended, ApiConnectionActionConfiguration> GroupMgrUpdateGroup(Expression<Func<GroupMgrUpdateGroupBodyInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GroupMgrDeleteGroup(Expression<Func<GroupMgrDeleteGroupBodyInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> GroupMgrArchiveGroup(Expression<Func<GroupMgrArchiveGroupBodyInput>> body)
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
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> GroupMgrGroupRequested(Expression<Func<GroupMgrGroupRequestedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/webhookrequest/GroupRequested";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> GroupMgrGroupCreated()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/webhookrequest/GroupCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new GroupMgrGroupCreatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> GroupMgrGroupUpdated()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/webhookrequest/GroupUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new GroupMgrGroupCreatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> GroupMgrGroupDeleted()
        {
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/webhookrequest/GroupDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new GroupMgrGroupCreatedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger(callPayload);
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

    public class GroupMgrGroupApprovalBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListItemId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputApprovedType Approved { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Groupmgr.BodyInputApprovedType.Approve;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputApprovedType
    {
        [EnumMember(Value = "true")]
        Approve,
        [EnumMember(Value = "false")]
        Reject
    }

    public class GroupMgrCreateGroupBodyInput
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
        public GroupMgrCreateGroupBodyInputIsPublicType? IsPublic { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Groupmgr.GroupMgrCreateGroupBodyInputIsPublicType.Public;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateTeam { get; set; } = false;
        public string Description { get; set; }
        public string CreatedBy { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GroupMgrCreateGroupBodyInputIsPublicType
    {
        [EnumMember(Value = "true")]
        Public,
        [EnumMember(Value = "false")]
        Private
    }

    public class GroupMgrUpdateGroupBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string GroupId { get; set; }
        public string DisplayName { get; set; }
        public string[] Owners { get; set; }
        public string[] Members { get; set; }
        public string GroupType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GroupMgrUpdateGroupBodyInputIsPublicType? IsPublic { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Groupmgr.GroupMgrUpdateGroupBodyInputIsPublicType.None;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateTeam { get; set; } = false;
        public string Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GroupMgrUpdateGroupBodyInputIsPublicType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        Public,
        [EnumMember(Value = "false")]
        Private
    }

    public class GroupMgrDeleteGroupBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListItemId { get; set; }
    }

    public class GroupMgrArchiveGroupBodyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListItemId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputArchiveType Archive { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Groupmgr.BodyInputArchiveType.Archive;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputArchiveType
    {
        [EnumMember(Value = "true")]
        Archive,
        [EnumMember(Value = "false")]
        Unarchive
    }

    public class GroupMgrGroupRequestedBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhook { get; set; } = "#{listCallbackUrl()}";
    }

    public class GroupMgrGroupCreatedBodyInput
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