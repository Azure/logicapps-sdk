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
        public IBodyWorkflowAction<CreateCardResponse> CreateCard([WorkflowExpression] Func<int> boardId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<int> bodycolumnId = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyassigneeEmail = null, [WorkflowExpression] Func<int> bodyplanletId = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<int> bodylabelId = null)
        {
            SourceExpression.Validate(boardId, nameof(boardId), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodycolumnId, nameof(bodycolumnId), required: false);
            SourceExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            SourceExpression.Validate(bodyassigneeEmail, nameof(bodyassigneeEmail), required: false);
            SourceExpression.Validate(bodyplanletId, nameof(bodyplanletId), required: false);
            SourceExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            SourceExpression.Validate(bodylabelId, nameof(bodylabelId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/external_notifications/{0}/create_card", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(boardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycolumnId != null)
                {
                    body["column_id"] = SourceExpressionConverter.ConvertToken(bodycolumnId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyassigneeEmail != null)
                {
                    body["assignee_email"] = SourceExpressionConverter.ConvertToken(bodyassigneeEmail);
                    bodypropCount++;
                }

                if (bodyplanletId != null)
                {
                    body["planlet_id"] = SourceExpressionConverter.ConvertToken(bodyplanletId);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["due_date"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodylabelId != null)
                {
                    body["label_id"] = SourceExpressionConverter.ConvertToken(bodylabelId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateCardResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectplace")]
        public IBodyWorkflowAction<MoveCardResponse> MoveCard([WorkflowExpression] Func<int> boardId, [WorkflowExpression] Func<int> bodycardId, [WorkflowExpression] Func<string> bodycardTitle = null, [WorkflowExpression] Func<int> bodycolumnId = null)
        {
            SourceExpression.Validate(boardId, nameof(boardId), required: true);
            SourceExpression.Validate(bodycardId, nameof(bodycardId), required: true);
            SourceExpression.Validate(bodycardTitle, nameof(bodycardTitle), required: false);
            SourceExpression.Validate(bodycolumnId, nameof(bodycolumnId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/external_notifications/{0}/move_card", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(boardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["card_id"] = SourceExpressionConverter.ConvertToken(bodycardId);
                if (bodycardTitle != null)
                {
                    body["card_title"] = SourceExpressionConverter.ConvertToken(bodycardTitle);
                    bodypropCount++;
                }

                if (bodycolumnId != null)
                {
                    body["column_id"] = SourceExpressionConverter.ConvertToken(bodycolumnId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MoveCardResponse>(BuildSourceInput);
        }
    }

    public class ProjectplaceTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger SetWebhookCardCreate([WorkflowExpression] Func<int> bodyboardId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
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
                body["board_id"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger SetWebhookPropertiesChange([WorkflowExpression] Func<bool> bodycardBlocked, [WorkflowExpression] Func<bool> bodycardUnblock, [WorkflowExpression] Func<bool> bodystatusChange, [WorkflowExpression] Func<bool> bodycardDone, [WorkflowExpression] Func<bool> bodydescriptionChanged, [WorkflowExpression] Func<bool> bodydueDateChanged, [WorkflowExpression] Func<int> bodyboardId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodycardBlocked, nameof(bodycardBlocked), required: true);
            SourceExpression.Validate(bodycardUnblock, nameof(bodycardUnblock), required: true);
            SourceExpression.Validate(bodystatusChange, nameof(bodystatusChange), required: true);
            SourceExpression.Validate(bodycardDone, nameof(bodycardDone), required: true);
            SourceExpression.Validate(bodydescriptionChanged, nameof(bodydescriptionChanged), required: true);
            SourceExpression.Validate(bodydueDateChanged, nameof(bodydueDateChanged), required: true);
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/external_notifications/1/hooks/set_power_hook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["card_blocked"] = SourceExpressionConverter.ConvertToken(bodycardBlocked);
                bodypropCount++;
                body["card_unblock"] = SourceExpressionConverter.ConvertToken(bodycardUnblock);
                bodypropCount++;
                body["status_change"] = SourceExpressionConverter.ConvertToken(bodystatusChange);
                bodypropCount++;
                body["card_done"] = SourceExpressionConverter.ConvertToken(bodycardDone);
                bodypropCount++;
                body["description_changed"] = SourceExpressionConverter.ConvertToken(bodydescriptionChanged);
                bodypropCount++;
                body["due_date_changed"] = SourceExpressionConverter.ConvertToken(bodydueDateChanged);
                body["webhook"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["board_id"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger SetWebhookCardDueDate([WorkflowExpression] Func<int> bodyboardId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyboardId, nameof(bodyboardId), required: true);
            ApiConnectionActionInput BuildSourceInput()
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
                body["board_id"] = SourceExpressionConverter.ConvertToken(bodyboardId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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