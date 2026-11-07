//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Kanbanize
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class KanbanizeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IBodyWorkflowAction<GetCardAttachmentsResponse, ApiConnectionActionConfiguration> GetCardAttachments(Expression<Func<int>> cardId)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<GetCardAttachmentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/cards/{0}/attachments", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCardAttachmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IBodyWorkflowAction<GetCardResponse, ApiConnectionActionConfiguration> GetCardByCustomId(Expression<Func<string>> customIds, Expression<Func<int>> boardIds = null)
        {
            var __workflow_customIds = WorkflowExpression.Compile(customIds, nameof(customIds), required: true);
            var __workflow_boardIds = WorkflowExpression.Compile(boardIds, nameof(boardIds), required: false);
            return new DeferredBodyAction<GetCardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/cards/GetCardByCustomId";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["custom_ids"] = ExpressionConverter.Convert(__workflow_customIds);
                if (__workflow_boardIds != null)
                    callPayload.Queries["board_ids"] = ExpressionConverter.Convert(__workflow_boardIds);
                callPayload.Queries["fields"] = Convert.ToString("card_id,title,description,custom_id,owner_user_id,type_id,size,priority,color,deadline,reporter,created_at,last_modified,board_id,workflow_id,column_id,lane_id,section,position,is_blocked");
                callPayload.Queries["expand"] = Convert.ToString("custom_fields,stickers,tag_ids,linked_cards");
                return new ApiConnectionAction<GetCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetCustomField(Expression<Func<int>> cardId, Expression<Func<SetCustomFieldBodyInput>> body)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/cards/{0}/SetCustomField", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BlockCard(Expression<Func<int>> boardId, Expression<Func<int>> cardId, Expression<Func<BlockCardBodyInput>> body)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/cards/{0}/BlockCard", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnblockCard(Expression<Func<int>> cardId)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/cards/{0}/blockReason", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LinkCard(Expression<Func<int>> cardId, Expression<Func<LinkCardBodyInput>> body)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/cards/{0}/LinkCard", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UnlinkCard(Expression<Func<int>> cardId, Expression<Func<LinkCardBodyInput>> body)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/cards/{0}/UnlinkCard", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IBodyWorkflowAction<DownloadAttachmentResponse, ApiConnectionActionConfiguration> DownloadAttachment(Expression<Func<int>> cardId, Expression<Func<int>> attachmentId)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            return new DeferredBodyAction<DownloadAttachmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/files/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["card_id"] = ExpressionConverter.Convert(__workflow_cardId);
                callPayload.Headers["attachment_id"] = ExpressionConverter.Convert(__workflow_attachmentId);
                callPayload.Headers["encoding"] = Convert.ToString("base64");
                return new ApiConnectionAction<DownloadAttachmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IBodyWorkflowAction<UploadAttachmentResponse, ApiConnectionActionConfiguration> UploadAttachment(Expression<Func<int>> cardId, Expression<Func<UploadAttachmentBodyInput>> body)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UploadAttachmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["card_id"] = ExpressionConverter.Convert(__workflow_cardId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UploadAttachmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IBodyWorkflowAction<GetObjectNameResponse, ApiConnectionActionConfiguration> GetObjectName(Expression<Func<int>> boardId, Expression<Func<ItemInput>> item, Expression<Func<int>> id)
        {
            var __workflow_boardId = WorkflowExpression.Compile(boardId, nameof(boardId), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetObjectNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/{0}/{1}", __workflow_item.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["board_id"] = ExpressionConverter.Convert(__workflow_boardId);
                return new ApiConnectionAction<GetObjectNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddComment(Expression<Func<int>> cardId, Expression<Func<AddCommentBodyInput>> body)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/cards/{0}/comments", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IBodyWorkflowAction<GetAllCardsResponse, ApiConnectionActionConfiguration> GetAllCards(Expression<Func<int>> boardIds, Expression<Func<string[]>> customIds = null, Expression<Func<int>> page = null, Expression<Func<StateInput>> state = null)
        {
            var __workflow_boardIds = WorkflowExpression.Compile(boardIds, nameof(boardIds), required: true);
            var __workflow_customIds = WorkflowExpression.Compile(customIds, nameof(customIds), required: false);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_state = WorkflowExpression.Compile(state, nameof(state), required: false);
            return new DeferredBodyAction<GetAllCardsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/cards";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["board_ids"] = ExpressionConverter.Convert(__workflow_boardIds);
                if (__workflow_customIds != null)
                    callPayload.Queries["custom_ids"] = ExpressionConverter.Convert(__workflow_customIds);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["state"] = Convert.ToString("active");
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                return new ApiConnectionAction<GetAllCardsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IBodyWorkflowAction<GetCardResponse, ApiConnectionActionConfiguration> GetCard(Expression<Func<int>> cardId)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<GetCardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/cards/{0}", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LogTime(Expression<Func<LogTimeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/loggedTime/LogTime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "kanbanize")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveCard(Expression<Func<int>> cardId, Expression<Func<MoveCardBodyInput>> body)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/cards/{0}/MoveCard", __workflow_cardId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class KanbanizeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CardHookResponse, ApiConnectionPollingTriggerConfiguration> CardHook(Expression<Func<CardHookBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<CardHookResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v2/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<CardHookResponse>(callPayload);
            });
        }
    }

    public class GetCardAttachmentsResponse
    {
        [JsonProperty("data")]
        public GetCardAttachmentsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetCardAttachmentsResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GetCardResponse
    {
        [JsonProperty("data")]
        public GetCardResponseDataType Data { get; set; }
    }

    public class GetCardResponseDataType
    {
        [JsonProperty("card_id")]
        public int CardId { get; set; }

        [JsonProperty("custom_id")]
        public string CustomId { get; set; }

        [JsonProperty("board_id")]
        public int BoardId { get; set; }

        [JsonProperty("workflow_id")]
        public int WorkflowId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("owner_user_id")]
        public JToken OwnerUserId { get; set; }

        [JsonProperty("type_id")]
        public JToken TypeId { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("section")]
        public int Section { get; set; }

        [JsonProperty("column_id")]
        public int ColumnId { get; set; }

        [JsonProperty("lane_id")]
        public int LaneId { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("size")]
        public JToken Size { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        [JsonProperty("reporter")]
        public GetCardResponseDataTypeReporterType Reporter { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("is_blocked")]
        public int IsBlocked { get; set; }

        [JsonProperty("custom_fields")]
        public GetCardResponseDataTypeCustomFieldsTypeItem[] CustomFields { get; set; }
    }

    public class GetCardResponseDataTypeReporterType
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class GetCardResponseDataTypeCustomFieldsTypeItem
    {
        [JsonProperty("field_id")]
        public int FieldId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("display_value")]
        public JToken DisplayValue { get; set; }

        [JsonProperty("values")]
        public GetCardResponseDataTypeCustomFieldsTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class GetCardResponseDataTypeCustomFieldsTypeItemValuesTypeItem
    {
        [JsonProperty("value_id")]
        public int ValueId { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class SetCustomFieldBodyInput
    {
        [JsonProperty("board_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int BoardId { get; set; }

        [JsonProperty("field_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int FieldId { get; set; }

        [JsonProperty("values", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Values { get; set; }
    }

    public class BlockCardBodyInput
    {
        [JsonProperty("block_reason", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputBlockReasonType BlockReason { get; set; }
    }

    public class BodyInputBlockReasonType
    {
        [JsonProperty("reason_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ReasonId { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class LinkCardBodyInput
    {
        [JsonProperty("link_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputLinkTypeType LinkType { get; set; }

        [JsonProperty("linked_card_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int LinkedCardId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputLinkTypeType
    {
        [EnumMember(Value = "child")]
        Parent,
        [EnumMember(Value = "parent")]
        Child,
        [EnumMember(Value = "relative")]
        Relative,
        [EnumMember(Value = "predecessor")]
        Successor,
        [EnumMember(Value = "successor")]
        Predecessor
    }

    public class DownloadAttachmentResponse
    {
        [JsonProperty("data")]
        public DownloadAttachmentResponseDataType Data { get; set; }
    }

    public class DownloadAttachmentResponseDataType
    {
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
    }

    public class UploadAttachmentResponse
    {
        [JsonProperty("data")]
        public UploadAttachmentResponseDataTypeItem[] Data { get; set; }
    }

    public class UploadAttachmentResponseDataTypeItem
    {
        [JsonProperty("card_id")]
        public int CardId { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }
    }

    public class UploadAttachmentBodyInput
    {
        [JsonProperty("file_name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }
    }

    public class GetObjectNameResponse
    {
        [JsonProperty("data")]
        public GetObjectNameResponseDataType Data { get; set; }
    }

    public class GetObjectNameResponseDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ItemInput
    {
        [EnumMember(Value = "boards")]
        Board,
        [EnumMember(Value = "workflows")]
        Workflow,
        [EnumMember(Value = "lanes")]
        Lane,
        [EnumMember(Value = "columns")]
        Column,
        [EnumMember(Value = "users")]
        User,
        [EnumMember(Value = "cardTemplates")]
        Template,
        [EnumMember(Value = "cardTypes")]
        Type,
        [EnumMember(Value = "stickers")]
        Sticker,
        [EnumMember(Value = "tags")]
        Tag,
        [EnumMember(Value = "blockReasons")]
        BlockReason
    }

    public class AddCommentBodyInput
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class GetAllCardsResponse
    {
        [JsonProperty("data")]
        public GetAllCardsResponseDataType Data { get; set; }
    }

    public class GetAllCardsResponseDataType
    {
        [JsonProperty("pagination")]
        public GetAllCardsResponseDataTypePaginationType Pagination { get; set; }

        [JsonProperty("data")]
        public GetAllCardsResponseDataTypeDataTypeItem[] Data { get; set; }
    }

    public class GetAllCardsResponseDataTypePaginationType
    {
        [JsonProperty("all_pages")]
        public int AllPages { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("results_per_page")]
        public int ResultsPerPage { get; set; }
    }

    public class GetAllCardsResponseDataTypeDataTypeItem
    {
        [JsonProperty("card_id")]
        public int CardId { get; set; }

        [JsonProperty("custom_id")]
        public string CustomId { get; set; }

        [JsonProperty("board_id")]
        public int BoardId { get; set; }

        [JsonProperty("workflow_id")]
        public int WorkflowId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("owner_user_id")]
        public JToken OwnerUserId { get; set; }

        [JsonProperty("type_id")]
        public JToken TypeId { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("section")]
        public int Section { get; set; }

        [JsonProperty("column_id")]
        public int ColumnId { get; set; }

        [JsonProperty("lane_id")]
        public int LaneId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StateInput
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "archived")]
        Archived,
        [EnumMember(Value = "discarded")]
        Discarded
    }

    public class LogTimeBodyInput
    {
        [JsonProperty("card_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CardId { get; set; }

        [JsonProperty("time_unit", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTimeUnitType TimeUnit { get; set; }

        [JsonProperty("time", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Time { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTimeUnitType
    {
        Seconds,
        Minutes,
        Hours,
        Days
    }

    public class MoveCardBodyInput
    {
        [JsonProperty("board_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int BoardId { get; set; }

        [JsonProperty("workflow_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int WorkflowId { get; set; }

        [JsonProperty("column_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken ColumnId { get; set; }

        [JsonProperty("lane_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken LaneId { get; set; }
    }

    public class CardHookResponse
    {
        [JsonProperty("data")]
        public CardHookResponseDataTypeItem[] Data { get; set; }
    }

    public class CardHookResponseDataTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_enabled")]
        public int IsEnabled { get; set; }

        [JsonProperty("board_id")]
        public int BoardId { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("webhook_id")]
        public int WebhookId { get; set; }
    }

    public class CardHookBodyInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("board_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BoardId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Kanbanize;

    public partial class WorkflowManagedActions
    {
        public KanbanizeActions Kanbanize(string connectionId) => new KanbanizeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public KanbanizeTriggers Kanbanize(string connectionId) => new KanbanizeTriggers(connectionId);
    }
}