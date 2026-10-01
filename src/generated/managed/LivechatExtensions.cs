//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Livechat
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LivechatActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IWorkflowAction CreateAgent([WorkflowExpression] Func<string> bodyagentId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<WorkScheduleEntryV2[]> bodyworkSchedulerschedule, [WorkflowExpression] Func<bodyroleInput> bodyrole = null, [WorkflowExpression] Func<bodyloginStatusInput> bodyloginStatus = null, [WorkflowExpression] Func<string> bodyjobTitle = null, [WorkflowExpression] Func<string> bodymobile = null, [WorkflowExpression] Func<int> bodymaximumChatCount = null, [WorkflowExpression] Func<bool> bodyawaitingApproval = null, [WorkflowExpression] Func<AgentGroupV2[]> bodygroups = null, [WorkflowExpression] Func<string[]> bodynotifications = null, [WorkflowExpression] Func<bodyemailSubscriptionsInputItem[]> bodyemailSubscriptions = null, [WorkflowExpression] Func<string> bodyworkSchedulertimeZone = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3.6/configuration/action/create_agent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyagentId);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodyrole != null)
                {
                    if (bodyrole != null)
                    {
                        body["role"] = SourceExpressionConverter.Convert(bodyrole);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["role"] = "normal";
                    bodypropCount++;
                }

                if (bodyloginStatus != null)
                {
                    if (bodyloginStatus != null)
                    {
                        body["login_status"] = SourceExpressionConverter.Convert(bodyloginStatus);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["login_status"] = "not accepting chats";
                    bodypropCount++;
                }

                if (bodyjobTitle != null)
                {
                    body["job_title"] = SourceExpressionConverter.ConvertToken(bodyjobTitle);
                    bodypropCount++;
                }

                if (bodymobile != null)
                {
                    body["mobile"] = SourceExpressionConverter.ConvertToken(bodymobile);
                    bodypropCount++;
                }

                if (bodymaximumChatCount != null)
                {
                    if (bodymaximumChatCount != null)
                    {
                        body["max_chats_count"] = SourceExpressionConverter.ConvertToken(bodymaximumChatCount);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["max_chats_count"] = 6;
                    bodypropCount++;
                }

                if (bodyawaitingApproval != null)
                {
                    if (bodyawaitingApproval != null)
                    {
                        body["awaiting_approval"] = SourceExpressionConverter.ConvertToken(bodyawaitingApproval);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["awaiting_approval"] = true;
                    bodypropCount++;
                }

                if (bodygroups != null)
                {
                    body["groups"] = SourceExpressionConverter.ConvertToken(bodygroups);
                    bodypropCount++;
                }

                if (bodynotifications != null)
                {
                    body["notifications"] = SourceExpressionConverter.ConvertToken(bodynotifications);
                    bodypropCount++;
                }

                if (bodyemailSubscriptions != null)
                {
                    body["email_subscriptions"] = SourceExpressionConverter.ConvertToken(bodyemailSubscriptions);
                    bodypropCount++;
                }

                var workSchedulerObject = new JObject();
                var workSchedulerObjectpropCount = 0;
                if (bodyworkSchedulertimeZone != null)
                {
                    workSchedulerObject["timezone"] = SourceExpressionConverter.ConvertToken(bodyworkSchedulertimeZone);
                    workSchedulerObjectpropCount++;
                }

                workSchedulerObjectpropCount++;
                workSchedulerObject["schedule"] = SourceExpressionConverter.ConvertToken(bodyworkSchedulerschedule);
                if (workSchedulerObjectpropCount > 0)
                {
                    body["work_scheduler"] = workSchedulerObject;
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IWorkflowAction DeleteAgent([WorkflowExpression] Func<string> bodyagentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3.6/configuration/action/delete_agent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyagentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "livechat")]
        public IBodyWorkflowAction<AgentV2[]> ListAgents()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3.6/configuration/action/list_agents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AgentV2[]>(BuildSourceInput);
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

    public enum bodyroleInput
    {
        [EnumMember(Value = "viceowner")]
        Viceowner,
        [EnumMember(Value = "administrator")]
        Administrator,
        [EnumMember(Value = "normal")]
        Normal
    }

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
        public int GroupID { get; set; }

        [JsonProperty("priority")]
        public AgentGroupV2PriorityType Priority { get; set; }
    }

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
        public string AgentID { get; set; }

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