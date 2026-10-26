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
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateAgent(Expression<Func<string>> bodyagentId, Expression<Func<string>> bodyname, Expression<Func<WorkScheduleEntryV2[]>> bodyworkSchedulerschedule, Expression<Func<bodyroleInput>> bodyrole = null, Expression<Func<bodyloginStatusInput>> bodyloginStatus = null, Expression<Func<string>> bodyjobTitle = null, Expression<Func<string>> bodymobile = null, Expression<Func<int>> bodymaximumChatCount = null, Expression<Func<bool>> bodyawaitingApproval = null, Expression<Func<AgentGroupV2[]>> bodygroups = null, Expression<Func<string[]>> bodynotifications = null, Expression<Func<bodyemailSubscriptionsInputItem[]>> bodyemailSubscriptions = null, Expression<Func<string>> bodyworkSchedulertimeZone = null)
        {
            var __workflow_bodyagentId = WorkflowExpression.Compile(bodyagentId, nameof(bodyagentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyworkSchedulerschedule = WorkflowExpression.Compile(bodyworkSchedulerschedule, nameof(bodyworkSchedulerschedule), required: true);
            var __workflow_bodyrole = WorkflowExpression.Compile(bodyrole, nameof(bodyrole), required: false);
            var __workflow_bodyloginStatus = WorkflowExpression.Compile(bodyloginStatus, nameof(bodyloginStatus), required: false);
            var __workflow_bodyjobTitle = WorkflowExpression.Compile(bodyjobTitle, nameof(bodyjobTitle), required: false);
            var __workflow_bodymobile = WorkflowExpression.Compile(bodymobile, nameof(bodymobile), required: false);
            var __workflow_bodymaximumChatCount = WorkflowExpression.Compile(bodymaximumChatCount, nameof(bodymaximumChatCount), required: false);
            var __workflow_bodyawaitingApproval = WorkflowExpression.Compile(bodyawaitingApproval, nameof(bodyawaitingApproval), required: false);
            var __workflow_bodygroups = WorkflowExpression.Compile(bodygroups, nameof(bodygroups), required: false);
            var __workflow_bodynotifications = WorkflowExpression.Compile(bodynotifications, nameof(bodynotifications), required: false);
            var __workflow_bodyemailSubscriptions = WorkflowExpression.Compile(bodyemailSubscriptions, nameof(bodyemailSubscriptions), required: false);
            var __workflow_bodyworkSchedulertimeZone = WorkflowExpression.Compile(bodyworkSchedulertimeZone, nameof(bodyworkSchedulertimeZone), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3.6/configuration/action/create_agent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyagentId);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodyrole != null)
                {
                    if (__workflow_bodyrole != null)
                    {
                        body["role"] = ExpressionConverter.ConvertO(__workflow_bodyrole);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["role"] = "normal";
                    bodypropCount++;
                }

                if (__workflow_bodyloginStatus != null)
                {
                    if (__workflow_bodyloginStatus != null)
                    {
                        body["login_status"] = ExpressionConverter.ConvertO(__workflow_bodyloginStatus);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["login_status"] = "not accepting chats";
                    bodypropCount++;
                }

                if (__workflow_bodyjobTitle != null)
                {
                    body["job_title"] = ExpressionConverter.ConvertO(__workflow_bodyjobTitle);
                    bodypropCount++;
                }

                if (__workflow_bodymobile != null)
                {
                    body["mobile"] = ExpressionConverter.ConvertO(__workflow_bodymobile);
                    bodypropCount++;
                }

                if (__workflow_bodymaximumChatCount != null)
                {
                    if (__workflow_bodymaximumChatCount != null)
                    {
                        body["max_chats_count"] = ExpressionConverter.ConvertO(__workflow_bodymaximumChatCount);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_chats_count"] = 6;
                    bodypropCount++;
                }

                if (__workflow_bodyawaitingApproval != null)
                {
                    if (__workflow_bodyawaitingApproval != null)
                    {
                        body["awaiting_approval"] = ExpressionConverter.ConvertO(__workflow_bodyawaitingApproval);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["awaiting_approval"] = true;
                    bodypropCount++;
                }

                if (__workflow_bodygroups != null)
                {
                    body["groups"] = ExpressionConverter.ConvertO(__workflow_bodygroups);
                    bodypropCount++;
                }

                if (__workflow_bodynotifications != null)
                {
                    body["notifications"] = ExpressionConverter.ConvertO(__workflow_bodynotifications);
                    bodypropCount++;
                }

                if (__workflow_bodyemailSubscriptions != null)
                {
                    body["email_subscriptions"] = ExpressionConverter.ConvertO(__workflow_bodyemailSubscriptions);
                    bodypropCount++;
                }

                var workSchedulerObject = new JObject();
                var workSchedulerObjectpropCount = 0;
                if (__workflow_bodyworkSchedulertimeZone != null)
                {
                    workSchedulerObject["timezone"] = ExpressionConverter.ConvertO(__workflow_bodyworkSchedulertimeZone);
                    workSchedulerObjectpropCount++;
                }

                workSchedulerObjectpropCount++;
                workSchedulerObject["schedule"] = ExpressionConverter.ConvertO(__workflow_bodyworkSchedulerschedule);
                if (workSchedulerObjectpropCount > 0)
                {
                    body["work_scheduler"] = workSchedulerObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAgent(Expression<Func<string>> bodyagentId)
        {
            var __workflow_bodyagentId = WorkflowExpression.Compile(bodyagentId, nameof(bodyagentId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3.6/configuration/action/delete_agent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyagentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyroleInput
    {
        [EnumMember(Value = "viceowner")]
        Viceowner,
        [EnumMember(Value = "administrator")]
        Administrator,
        [EnumMember(Value = "normal")]
        Normal
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyloginStatusInput
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
    public enum bodyemailSubscriptionsInputItem
    {
        [EnumMember(Value = "daily_summary")]
        DailySummary,
        [EnumMember(Value = "weekly_summary")]
        WeeklySummary
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