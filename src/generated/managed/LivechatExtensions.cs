//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Livechat
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LivechatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateAgent(Expression<Func<CreateAgentV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3.6/configuration/action/create_agent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAgent(Expression<Func<DeleteAgentV2Input>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3.6/configuration/action/delete_agent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IBodyWorkflowAction<AgentV2[], ApiConnectionActionConfiguration> ListAgents()
        {
            return new DeferredBodyAction<AgentV2[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3.6/configuration/action/list_agents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AgentV2[]>(callPayload);
            });
        }
    }

    public class LivechatTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateAgentV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AgentId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAgentV2InputRoleType? Role { get; set; } = CreateAgentV2InputRoleType.Normal;

        [JsonProperty("login_status", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAgentV2InputLoginStatusType? LoginStatus { get; set; } = CreateAgentV2InputLoginStatusType.NotAcceptingChats;

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("max_chats_count", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChatCount { get; set; } = 6;

        [JsonProperty("awaiting_approval", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AwaitingApproval { get; set; } = true;

        [JsonProperty("groups")]
        public AgentGroupV2[] Groups { get; set; }

        [JsonProperty("notifications")]
        public string[] Notifications { get; set; }

        [JsonProperty("email_subscriptions")]
        public CreateAgentV2InputEmailSubscriptionsTypeItem[] EmailSubscriptions { get; set; }

        [JsonProperty("work_scheduler")]
        public WorkSchedulerV2 WorkScheduler { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgentV2InputRoleType
    {
        [EnumMember(Value = "viceowner")]
        Viceowner,
        [EnumMember(Value = "administrator")]
        Administrator,
        [EnumMember(Value = "normal")]
        Normal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgentV2InputLoginStatusType
    {
        [EnumMember(Value = "accepting chats")]
        AcceptingChats,
        [EnumMember(Value = "not accepting chats")]
        NotAcceptingChats
    }

    public class AgentGroupV2
    {
        [JsonProperty("id")]
        public int GroupId { get; set; }

        [JsonProperty("priority")]
        public AgentGroupV2PriorityType Priority { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AgentGroupV2PriorityType
    {
        [EnumMember(Value = "first")]
        First,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "last")]
        Last,
        [EnumMember(Value = "supervisor")]
        Supervisor
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgentV2InputEmailSubscriptionsTypeItem
    {
        [EnumMember(Value = "daily_summary")]
        DailySummary,
        [EnumMember(Value = "weekly_summary")]
        WeeklySummary
    }

    public class WorkSchedulerV2
    {
        [JsonProperty("timezone")]
        public string TimeZone { get; set; }

        [JsonProperty("schedule")]
        public WorkScheduleEntryV2[] Schedule { get; set; }
    }

    public class WorkScheduleEntryV2
    {
        [JsonProperty("day")]
        public WorkScheduleEntryV2DayType Day { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkScheduleEntryV2DayType
    {
        [EnumMember(Value = "sunday")]
        Sunday,
        [EnumMember(Value = "monday")]
        Monday,
        [EnumMember(Value = "tuesday")]
        Tuesday,
        [EnumMember(Value = "wednesday")]
        Wednesday,
        [EnumMember(Value = "thursday")]
        Thursday,
        [EnumMember(Value = "friday")]
        Friday,
        [EnumMember(Value = "saturday")]
        Saturday
    }

    public class DeleteAgentV2Input
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AgentId { get; set; }
    }

    public class AgentV2
    {
        [JsonProperty("id")]
        public string AgentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("login_status")]
        public string LoginStatus { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("max_chats_count")]
        public int MaximumChatCount { get; set; }

        [JsonProperty("suspended")]
        public bool Suspended { get; set; }

        [JsonProperty("awaiting_approval")]
        public bool AwaitingApproval { get; set; }

        [JsonProperty("groups")]
        public AgentGroupV2[] Groups { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Livechat;

    public partial class WorkflowManagedActions
    {
        public LivechatActions Livechat(string connectionId) => new LivechatActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LivechatTriggers Livechat(string connectionId) => new LivechatTriggers(connectionId);
    }
}