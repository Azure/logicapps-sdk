//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Projectplace
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProjectplaceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectplace")]
        public IBodyWorkflowAction<CreateCardResponse, ApiConnectionActionConfiguration> CreateCard(Expression<Func<int>> boardId, Expression<Func<CreateCardInput>> body = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateCardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/external_notifications/{0}/create_card", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectplace")]
        public IBodyWorkflowAction<MoveCardResponse, ApiConnectionActionConfiguration> MoveCard(Expression<Func<int>> boardId, Expression<Func<MoveCardInput>> body = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<MoveCardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/external_notifications/{0}/move_card", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<MoveCardResponse>(callPayload);
            });
        }
    }

    public class ProjectplaceTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> SetWebhookCardCreate(Expression<Func<SetWebhookCardCreateInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/external_notifications/0/hooks/set_power_hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> SetWebhookPropertiesChange(Expression<Func<SetWebhookPropertiesChangeInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/external_notifications/1/hooks/set_power_hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> SetWebhookCardDueDate(Expression<Func<SetWebhookCardDueDateInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/external_notifications/2/hooks/set_power_hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreateCardResponse
    {
        [JsonProperty("access")]
        public string Access { get; set; }

        [JsonProperty("assignee")]
        public JToken Assignee { get; set; }

        [JsonProperty("assignee_id")]
        public int AssigneeId { get; set; }

        [JsonProperty("board_id")]
        public int BoardId { get; set; }

        [JsonProperty("board_name")]
        public string BoardName { get; set; }

        [JsonProperty("direct_url")]
        public string DirectUrl { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("estimated_time")]
        public string EstimatedTime { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_blocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty("is_blocked_reason")]
        public string IsBlockedReason { get; set; }

        [JsonProperty("is_done")]
        public bool IsDone { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        [JsonProperty("label_id")]
        public int LabelId { get; set; }

        [JsonProperty("planlet_id")]
        public int PlanletId { get; set; }

        [JsonProperty("reported_time")]
        public string ReportedTime { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CreateCardInput
    {
        [JsonProperty("column_id")]
        public int? ColumnId { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("assignee_email")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("planlet_id")]
        public int? PlanletId { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("label_id")]
        public int? LabelId { get; set; }
    }

    public class MoveCardResponse
    {
        [JsonProperty("access")]
        public string Access { get; set; }

        [JsonProperty("assignee_id")]
        public int AssigneeId { get; set; }

        [JsonProperty("board_id")]
        public int BoardId { get; set; }

        [JsonProperty("board_name")]
        public string BoardName { get; set; }

        [JsonProperty("column_id")]
        public int ColumnId { get; set; }

        [JsonProperty("column_name")]
        public string ColumnName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("direct_url")]
        public string DirectUrl { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("estimated_time")]
        public string EstimatedTime { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_blocked")]
        public bool IsBlocked { get; set; }

        [JsonProperty("is_blocked_reason")]
        public string IsBlockedReason { get; set; }

        [JsonProperty("is_done")]
        public bool IsDone { get; set; }

        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        [JsonProperty("label_id")]
        public int LabelId { get; set; }

        [JsonProperty("label_name")]
        public string LabelName { get; set; }

        [JsonProperty("planlet_id")]
        public int PlanletId { get; set; }

        [JsonProperty("reported_time")]
        public string ReportedTime { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class MoveCardInput
    {
        [JsonProperty("card_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int CardId { get; set; }

        [JsonProperty("card_title")]
        public string CardTitle { get; set; }

        [JsonProperty("column_id")]
        public int? ColumnId { get; set; }
    }

    public class SetWebhookCardCreateInput
    {
        [JsonProperty("card_create", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool CardCreate { get; set; } = true;

        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhook { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("board_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int BoardId { get; set; }
    }

    public class SetWebhookPropertiesChangeInput
    {
        [JsonProperty("card_blocked", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CardBlocked { get; set; } = true;

        [JsonProperty("card_unblock", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CardUnblock { get; set; } = true;

        [JsonProperty("status_change", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool StatusChange { get; set; } = true;

        [JsonProperty("card_done", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool CardDone { get; set; } = true;

        [JsonProperty("description_changed", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool DescriptionChanged { get; set; } = true;

        [JsonProperty("due_date_changed", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool DueDateChanged { get; set; } = true;

        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhook { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("board_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int BoardId { get; set; }
    }

    public class SetWebhookCardDueDateInput
    {
        [JsonProperty("due_today", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool DueToday { get; set; } = true;

        [JsonProperty("webhook", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Webhook { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("board_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int BoardId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Projectplace;

    public partial class WorkflowManagedActions
    {
        public ProjectplaceActions Projectplace(string connectionId) => new ProjectplaceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ProjectplaceTriggers Projectplace(string connectionId) => new ProjectplaceTriggers(connectionId);
    }
}