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
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateAgent(Expression<Func<CreateAgentBodyInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAgent(Expression<Func<DeleteAgentBodyInput>> body)
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

    public class CreateAgentBodyInput
    {
        public CreateAgentBodyInput(string agentId, string name)
        {
            this.AgentId = agentId;
            this.Name = name;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AgentId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputRoleType? Role { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Livechat.BodyInputRoleType.Normal;

        [JsonProperty("login_status", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputLoginStatusType? LoginStatus { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Livechat.BodyInputLoginStatusType.NotAcceptingChats;

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        [JsonProperty("max_chats_count", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChatCount { get; set; } = 6;

        [JsonProperty("awaiting_approval", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AwaitingApproval { get; set; } = true;

        [JsonProperty("groups")]
        public CreateAgentAgentGroupV2[] Groups { get; set; }

        [JsonProperty("notifications")]
        public string[] Notifications { get; set; }

        [JsonProperty("email_subscriptions")]
        public BodyInputEmailSubscriptionsTypeItem[] EmailSubscriptions { get; set; }

        [JsonProperty("work_scheduler")]
        public WorkSchedulerV2 WorkScheduler { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputRoleType
    {
        [EnumMember(Value = "viceowner")]
        Viceowner,
        [EnumMember(Value = "administrator")]
        Administrator,
        [EnumMember(Value = "normal")]
        Normal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLoginStatusType
    {
        [EnumMember(Value = "accepting chats")]
        AcceptingChats,
        [EnumMember(Value = "not accepting chats")]
        NotAcceptingChats
    }

    public class CreateAgentAgentGroupV2
    {
        public CreateAgentAgentGroupV2(int groupId, CreateAgentAgentGroupV2PriorityType priority)
        {
            this.GroupId = groupId;
            this.Priority = priority;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int GroupId { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAgentAgentGroupV2PriorityType Priority { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAgentAgentGroupV2PriorityType
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
    public enum BodyInputEmailSubscriptionsTypeItem
    {
        [EnumMember(Value = "daily_summary")]
        DailySummary,
        [EnumMember(Value = "weekly_summary")]
        WeeklySummary
    }

    public class WorkSchedulerV2
    {
        public WorkSchedulerV2(WorkScheduleEntryV2[] schedule)
        {
            this.Schedule = schedule;
        }

        [JsonProperty("timezone")]
        public string TimeZone { get; set; }

        [JsonProperty("schedule", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkScheduleEntryV2[] Schedule { get; set; }
    }

    public class WorkScheduleEntryV2
    {
        public WorkScheduleEntryV2(WorkScheduleEntryV2DayType day, bool enabled, string start, string end)
        {
            this.Day = day;
            this.Enabled = enabled;
            this.Start = start;
            this.End = end;
        }

        [JsonProperty("day", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkScheduleEntryV2DayType Day { get; set; }

        [JsonProperty("enabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Enabled { get; set; }

        [JsonProperty("start", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Start { get; set; }

        [JsonProperty("end", DefaultValueHandling = DefaultValueHandling.Include)]
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

    public class DeleteAgentBodyInput
    {
        public DeleteAgentBodyInput(string agentId)
        {
            this.AgentId = agentId;
        }

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
        public ListAgentsAgentGroupV2Response[] Groups { get; set; }
    }

    public class ListAgentsAgentGroupV2Response
    {
        [JsonProperty("id")]
        public int GroupId { get; set; }

        [JsonProperty("priority")]
        public ListAgentsAgentGroupV2PriorityTypeResponse Priority { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListAgentsAgentGroupV2PriorityTypeResponse
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