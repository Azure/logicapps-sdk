//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Projectplace
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProjectplaceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectplace")]
        public IBodyWorkflowAction<CreateCardResponse> CreateCard(Expression<Func<int>> boardId, Expression<Func<string>> bodytitle, Expression<Func<int>> bodycolumnId = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyassigneeEmail = null, Expression<Func<int>> bodyplanletId = null, Expression<Func<string>> bodydueDate = null, Expression<Func<int>> bodylabelId = null)
        {
            var apiCallPath = String.Format("/v1/external_notifications/{0}/create_card", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycolumnId != null)
            {
                body["column_id"] = ExpressionConverter.ConvertO(bodycolumnId);
                bodypropCount++;
            }

            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyassigneeEmail != null)
            {
                body["assignee_email"] = ExpressionConverter.ConvertO(bodyassigneeEmail);
                bodypropCount++;
            }

            if (bodyplanletId != null)
            {
                body["planlet_id"] = ExpressionConverter.ConvertO(bodyplanletId);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["due_date"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodylabelId != null)
            {
                body["label_id"] = ExpressionConverter.ConvertO(bodylabelId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CreateCardResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectplace")]
        public IBodyWorkflowAction<MoveCardResponse> MoveCard(Expression<Func<int>> boardId, Expression<Func<int>> bodycardId, Expression<Func<string>> bodycardTitle = null, Expression<Func<int>> bodycolumnId = null)
        {
            var apiCallPath = String.Format("/v1/external_notifications/{0}/move_card", ExpressionConverter.ConvertWithUrlEncoding(boardId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["card_id"] = ExpressionConverter.ConvertO(bodycardId);
            if (bodycardTitle != null)
            {
                body["card_title"] = ExpressionConverter.ConvertO(bodycardTitle);
                bodypropCount++;
            }

            if (bodycolumnId != null)
            {
                body["column_id"] = ExpressionConverter.ConvertO(bodycolumnId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<MoveCardResponse>(callPayload);
        }
    }

    public class ProjectplaceTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger SetWebhookCardCreate(Expression<Func<int>> bodyboardId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/external_notifications/0/hooks/set_power_hook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["card_create"] = true;
            bodypropCount++;
            body["webhook"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["board_id"] = ExpressionConverter.ConvertO(bodyboardId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger SetWebhookPropertiesChange(Expression<Func<bool>> bodycardBlocked, Expression<Func<bool>> bodycardUnblock, Expression<Func<bool>> bodystatusChange, Expression<Func<bool>> bodycardDone, Expression<Func<bool>> bodydescriptionChanged, Expression<Func<bool>> bodydueDateChanged, Expression<Func<int>> bodyboardId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/external_notifications/1/hooks/set_power_hook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["card_blocked"] = ExpressionConverter.ConvertO(bodycardBlocked);
            bodypropCount++;
            body["card_unblock"] = ExpressionConverter.ConvertO(bodycardUnblock);
            bodypropCount++;
            body["status_change"] = ExpressionConverter.ConvertO(bodystatusChange);
            bodypropCount++;
            body["card_done"] = ExpressionConverter.ConvertO(bodycardDone);
            bodypropCount++;
            body["description_changed"] = ExpressionConverter.ConvertO(bodydescriptionChanged);
            bodypropCount++;
            body["due_date_changed"] = ExpressionConverter.ConvertO(bodydueDateChanged);
            body["webhook"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["board_id"] = ExpressionConverter.ConvertO(bodyboardId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger SetWebhookCardDueDate(Expression<Func<int>> bodyboardId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v1/external_notifications/2/hooks/set_power_hook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["due_today"] = true;
            bodypropCount++;
            body["webhook"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["board_id"] = ExpressionConverter.ConvertO(bodyboardId);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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