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
        public IBodyWorkflowAction<CreateCardResponse, ApiConnectionActionConfiguration> CreateCard(Expression<Func<int>> boardId, Expression<Func<string>> bodytitle, Expression<Func<int>> bodycolumnId = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyassigneeEmail = null, Expression<Func<int>> bodyplanletId = null, Expression<Func<string>> bodydueDate = null, Expression<Func<int>> bodylabelId = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodycolumnId = WorkflowExpression.Compile(bodycolumnId, nameof(bodycolumnId), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyassigneeEmail = WorkflowExpression.Compile(bodyassigneeEmail, nameof(bodyassigneeEmail), required: false);
            var __workflow_bodyplanletId = WorkflowExpression.Compile(bodyplanletId, nameof(bodyplanletId), required: false);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: false);
            var __workflow_bodylabelId = WorkflowExpression.Compile(bodylabelId, nameof(bodylabelId), required: false);
            return new DeferredBodyAction<CreateCardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/external_notifications/{0}/create_card", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycolumnId != null)
                {
                    body["column_id"] = ExpressionConverter.ConvertO(__workflow_bodycolumnId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyassigneeEmail != null)
                {
                    body["assignee_email"] = ExpressionConverter.ConvertO(__workflow_bodyassigneeEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyplanletId != null)
                {
                    body["planlet_id"] = ExpressionConverter.ConvertO(__workflow_bodyplanletId);
                    bodypropCount++;
                }

                if (__workflow_bodydueDate != null)
                {
                    body["due_date"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                    bodypropCount++;
                }

                if (__workflow_bodylabelId != null)
                {
                    body["label_id"] = ExpressionConverter.ConvertO(__workflow_bodylabelId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectplace")]
        public IBodyWorkflowAction<MoveCardResponse, ApiConnectionActionConfiguration> MoveCard(Expression<Func<int>> boardId, Expression<Func<int>> bodycardId, Expression<Func<string>> bodycardTitle = null, Expression<Func<int>> bodycolumnId = null)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_bodycardId = WorkflowExpression.Compile(bodycardId, nameof(bodycardId), required: true);
            var __workflow_bodycardTitle = WorkflowExpression.Compile(bodycardTitle, nameof(bodycardTitle), required: false);
            var __workflow_bodycolumnId = WorkflowExpression.Compile(bodycolumnId, nameof(bodycolumnId), required: false);
            return new DeferredBodyAction<MoveCardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/external_notifications/{0}/move_card", __workflow_boardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["card_id"] = ExpressionConverter.ConvertO(__workflow_bodycardId);
                if (__workflow_bodycardTitle != null)
                {
                    body["card_title"] = ExpressionConverter.ConvertO(__workflow_bodycardTitle);
                    bodypropCount++;
                }

                if (__workflow_bodycolumnId != null)
                {
                    body["column_id"] = ExpressionConverter.ConvertO(__workflow_bodycolumnId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<MoveCardResponse>(callPayload);
            });
        }
    }

    public class ProjectplaceTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> SetWebhookCardCreate(Expression<Func<int>> bodyboardId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/external_notifications/0/hooks/set_power_hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["card_create"] = true;
                bodypropCount++;
                body["webhook"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["board_id"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> SetWebhookPropertiesChange(Expression<Func<bool>> bodycardBlocked, Expression<Func<bool>> bodycardUnblock, Expression<Func<bool>> bodystatusChange, Expression<Func<bool>> bodycardDone, Expression<Func<bool>> bodydescriptionChanged, Expression<Func<bool>> bodydueDateChanged, Expression<Func<int>> bodyboardId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodycardBlocked = WorkflowExpression.Compile(bodycardBlocked, nameof(bodycardBlocked), required: true);
            var __workflow_bodycardUnblock = WorkflowExpression.Compile(bodycardUnblock, nameof(bodycardUnblock), required: true);
            var __workflow_bodystatusChange = WorkflowExpression.Compile(bodystatusChange, nameof(bodystatusChange), required: true);
            var __workflow_bodycardDone = WorkflowExpression.Compile(bodycardDone, nameof(bodycardDone), required: true);
            var __workflow_bodydescriptionChanged = WorkflowExpression.Compile(bodydescriptionChanged, nameof(bodydescriptionChanged), required: true);
            var __workflow_bodydueDateChanged = WorkflowExpression.Compile(bodydueDateChanged, nameof(bodydueDateChanged), required: true);
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/external_notifications/1/hooks/set_power_hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["card_blocked"] = ExpressionConverter.ConvertO(__workflow_bodycardBlocked);
                bodypropCount++;
                body["card_unblock"] = ExpressionConverter.ConvertO(__workflow_bodycardUnblock);
                bodypropCount++;
                body["status_change"] = ExpressionConverter.ConvertO(__workflow_bodystatusChange);
                bodypropCount++;
                body["card_done"] = ExpressionConverter.ConvertO(__workflow_bodycardDone);
                bodypropCount++;
                body["description_changed"] = ExpressionConverter.ConvertO(__workflow_bodydescriptionChanged);
                bodypropCount++;
                body["due_date_changed"] = ExpressionConverter.ConvertO(__workflow_bodydueDateChanged);
                body["webhook"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["board_id"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> SetWebhookCardDueDate(Expression<Func<int>> bodyboardId, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyboardId = WorkflowExpression.Compile(bodyboardId, nameof(bodyboardId), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/external_notifications/2/hooks/set_power_hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["due_today"] = true;
                bodypropCount++;
                body["webhook"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["board_id"] = ExpressionConverter.ConvertO(__workflow_bodyboardId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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